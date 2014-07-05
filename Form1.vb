Imports System.Net.Sockets
Imports System.Net
Imports System.Text
Imports System.Runtime.InteropServices

Public Class Form1
    'Various variables.
    Dim hostIp As IPAddress, serverIp As Byte()
    Dim ep As IPEndPoint
    Dim tnSocket As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
    Dim CheckScreen As New System.Threading.Thread(AddressOf UpdateScreen)
    Dim autohide As Boolean = True
    Dim preventpowertoggle As Boolean = True

    'Args used for ip scanner.
    Private Class ScannerArgs
        Public IPAddress As System.Net.IPAddress
        Public IntArg As Integer
    End Class

    'basically builds a ip from the IP bytes then tries to connect to the IP:8102 and if successful assumes it is a pioneer device.
    'TODO - Implement SSDP request instead of this bad method to find the AVR.
    Private Sub ScanIP(ByVal e As ScannerArgs)
        Dim tmpClient As New TcpClient()
        Try
            Dim bytes As Byte() = e.IPAddress.GetAddressBytes()
            bytes(3) = e.IntArg

            Dim newIP As New IPEndPoint(New IPAddress(bytes), 8102)
            tmpClient.Connect(newIP)
            Threading.Thread.Sleep(50) '50 is the Timeout in ms
            If tmpClient.Connected = True Then
                NotifyIcon1.ShowBalloonTip(3000, "VSX Remote", "Connected to " & newIP.ToString & vbNewLine & "click the icon to open the interface", ToolTipIcon.Info)
                serverIp = bytes
            End If
            tmpClient.Close()
        Catch ex As Exception
            tmpClient.Close()
        End Try
    End Sub
    Private Sub Form1_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets Form to bottom right corner, Mkaes invisible and hides from taskbar.
        Me.Location = New System.Drawing.Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)
        Me.Opacity = 0
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False

        'Gets IP Range from network adapter and adds to arguments.ipaddress.
        hostIp = Dns.GetHostEntry(String.Empty).AddressList.[Single](Function(x) x.AddressFamily = AddressFamily.InterNetwork)
        Dim Arguments As New ScannerArgs
        Arguments.IPAddress = hostIp

        'Creates 254 threads to scan 254 IP's extremely quickly.
        For i As Integer = 0 To 254
            Arguments.IntArg = i
            Dim tmpThread As New System.Threading.Thread(AddressOf ScanIP)
            tmpThread.IsBackground = True
            tmpThread.Start(Arguments)
        Next

        'Check PollInfo Sub.
        PollInfo()

        'Starts OSD thread and injects LCD font.
        CheckScreen.IsBackground = True
        CheckScreen.Start()
        lblOSD.Font = CustomFont.GetInstance(lblOSD.Font.Size, FontStyle.Regular)
        lblMainInput.Font = CustomFont.GetInstance(lblMainInput.Font.Size, FontStyle.Regular)
        lblMVolume.Font = CustomFont.GetInstance(lblMVolume.Font.Size, FontStyle.Regular)
        If autohide Then Timer1.Start()
    End Sub

    'Queries input, mute status, volume status (easiest way is to increase volume .5dB as ?v caused issues) and power status.
    Private Sub PollInfo()
        SendCommands("?f")
        SendCommands("?m")
        SendCommands("VU")
        SendCommands("?p")
    End Sub

    'Connects to VSX if not already.
    Private Function ConnectToVSX(ByVal ip() As Byte, ByVal Port As String)
        If tnSocket.Connected Then Return True

        'Connects to IP:8102
        Try
            ep = New IPEndPoint(New IPAddress(ip), CType(Port.Trim, Integer))
        Catch ex As ArgumentNullException
            'do stuff...
        End Try
        Try
            tnSocket.Connect(ep)
            If tnSocket.Connected Then
                Return True
            Else
                Return False
            End If
        Catch oEX As Exception
            Return False
        End Try
    End Function

    'Sends "cmd" to VSX.
    Private Function SendCommands(ByVal cmd As String)
        If ConnectToVSX(serverIp, "8102") = True Then
            Dim output As String = ""
            Dim SendBytes As [Byte]() = Encoding.ASCII.GetBytes(cmd & vbCrLf)
            Dim RecvString As String = String.Empty
            Dim NumBytes As Integer = 0
            Dim RecvBytes(255) As [Byte]
            tnSocket.Send(SendBytes, SendBytes.Length, SocketFlags.None)
        End If
        Return Nothing
    End Function

    'Quick sub to parse volume and remove/add needed amount of zero's.
    Private Sub ValidateVolume(volume As String)
        'if value is less than 10 pre-fix 2 "0"s else if less than 100 pre-fix 1 "0" else just send the command without added "0"s
        If volume <= 0 Then
            volume = 0
            SendCommands(volume & "VL")
        ElseIf volume >= 185 Then
            volume = 185
            SendCommands(volume & "VL")
        ElseIf volume = 0 Then
            SendCommands("000VL")
        ElseIf volume < 10 Then
            SendCommands("00" & volume & "VL")
        ElseIf volume < 100 Then
            SendCommands("0" & volume & "VL")
        Else
            SendCommands(volume & "VL")
        End If
    End Sub

    'Properly disconnect and close the socket
    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            tnSocket.Disconnect(False)
            tnSocket.Close()
        Catch ex As Exception
            'do stuff soon
        End Try
    End Sub

    'Checks power status and toggles power
    Private Sub btnPwr_Click(sender As Object, e As EventArgs) Handles btnPwr.Click
        preventpowertoggle = False
        SendCommands("?p")
    End Sub

    'Set volume to current volume - 5
    Private Sub btnMVolumeDown_Click(sender As Object, e As EventArgs) Handles btnMVolumeDown.Click
        ValidateVolume(SliderMVolume.Value - 5)
    End Sub

    'Set volume to current volume + 5
    Private Sub btnMVolumeUp_Click(sender As Object, e As EventArgs) Handles btnMVolumeUp.Click
        ValidateVolume(SliderMVolume.Value + 5)
    End Sub

    'Show form and show in taskbar when notification icon clicked or showinterface menu option clicked and update information.
    Private Sub NotifyIcon1_Click(sender As Object, e As EventArgs) Handles ShowInterface.Click, NotifyIcon1.Click
        Me.WindowState = FormWindowState.Normal
        Me.Opacity = 1
        Me.ShowInTaskbar = True
        PollInfo()
        If autohide Then Timer1.Start()
    End Sub

    'Fade out style form hiding.
    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        For counter = 1.1 To 0.0 Step -0.1
            Me.Opacity = counter
            Me.Refresh()
            Threading.Thread.Sleep(25)
        Next counter
        Me.ShowInTaskbar = False
        If autohide Then Timer1.Stop()
    End Sub

    'Close application correctly.
    Private Sub ExitApplication_Click(sender As Object, e As EventArgs) Handles ExitApplication.Click
        Application.Exit()
    End Sub

    'Sends MZ (Mute Toggle) command.
    Private Sub btnMute_Click(sender As Object, e As EventArgs) Handles btnMute.Click
        SendCommands("MZ")
    End Sub

    'Hides form if mouse is not over form for 3 seconds.
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim Rectangle = New Rectangle(Me.Location.X, Me.Location.Y, Me.Width, Me.Height)
        Dim pt As POINTAPI
        GetCursorPos(pt)
        If Not Rectangle.Contains(New Point(pt.x, pt.y)) Then
            For counter = 1.1 To 0.0 Step -0.1
                Me.Opacity = counter
                Me.Refresh()
                Threading.Thread.Sleep(25)
            Next counter
            Me.ShowInTaskbar = False
            If autohide Then Timer1.Stop()
        End If
    End Sub

    <DllImport("User32.dll")>
    Public Shared Function GetCursorPos(ByRef pt As POINTAPI) As Integer
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Public Structure POINTAPI
        Public x As Integer
        Public y As Integer
    End Structure

    'Checks if autohide is currently enabled if it is disables it else enables it, also it changes button text to relevant message and toggles timer.
    Private Sub btnAutoHide_Click(sender As Object, e As EventArgs) Handles btnAutoHide.Click
        If autohide = False Then
            autohide = True
            btnAutoHide.Text = "Always Show"
            Timer1.Start()
        Else
            autohide = False
            btnAutoHide.Text = "Auto Hide"
            Timer1.Stop()
        End If
    End Sub

    'Background Sub to constantly update the UI with updated information from the screen.
    Private Sub UpdateScreen()
        CheckForIllegalCrossThreadCalls = False
        If ConnectToVSX(serverIp, "8102") = True Then
            Dim output As String = ""
            Dim result As String()
            Dim RecvString As String = String.Empty
            Dim NumBytes As Integer = 0
            Dim OSD As String = ""
            Dim RecvBytes(255) As [Byte]
            Do
                NumBytes = tnSocket.Receive(RecvBytes, RecvBytes.Length, 0)
                RecvString = RecvString + Encoding.ASCII.GetString(RecvBytes, 0, NumBytes)
                output = output & RecvString
                result = output.Split(vbCrLf)
            Loop While NumBytes = 256

            'loops through all response strings
            For Each i In result
                If i = vbCrLf Or i = vbLf Then Continue For
                ParseScreen(i)
            Next
            'Repeats sub
            UpdateScreen()
        End If
    End Sub

    'Converts pioneers FL strings such as "FL022020202053544552454F20202020" to readable text "STEREO".
    'First we remove the FL and then any 00's are ignored as they basically are alignments.
    'Basically it is hex code for a ASCII character so we substring each 2 characters from the string.
    'Then we "convert.toint32" them to get a integer we can then simply "Chr" the number to get the character.
    Function DecryptScreen(temp As String)
        Dim OSD As String = temp.ToString.Replace("FL", "").Replace(vbLf, "").Replace(vbCrLf, "").Replace("2020", "")
        Dim output As String = ""
        For x As Integer = 0 To OSD.Length - 1 Step 2
            If Not OSD.Substring(x, 2) = "00" Then
                output = output & Chr(Convert.ToInt32("0x" & OSD.Substring(x, 2), 16))
            End If
        Next
        Return output
    End Function

    'A Sub to seperate the output in to various sections and respond appropiately.
    Sub ParseScreen(output As String)
        'SCREEN INFORMATION
        If output.ToString.Contains("FL") Then
            Dim decryptedOSD As String = DecryptScreen(output)
            If decryptedOSD.ToString.Contains("M.VOL") Then
                lblMVolume.Text = decryptedOSD.ToString.Replace("M.VOL", "").Replace(" ", "")
                lblMVolume.ForeColor = Color.Lime
                btnMute.Text = "  MUTE"
                btnMute.Image = Global.Pioneer_VSX_Series_Remote_Control.My.Resources.Resources.NotMuted
            ElseIf decryptedOSD.ToString.Contains("MUTE ") Then
                If decryptedOSD.ToString.Contains("MUTE ON") Then
                    lblMVolume.ForeColor = Color.Red
                    btnMute.Text = "UN-MUTE"
                    btnMute.Image = Global.Pioneer_VSX_Series_Remote_Control.My.Resources.Resources.Muted
                ElseIf decryptedOSD.ToString.Contains("MUTE OFF") Then
                    lblMVolume.ForeColor = Color.Lime
                    btnMute.Text = "  MUTE"
                    btnMute.Image = Global.Pioneer_VSX_Series_Remote_Control.My.Resources.Resources.NotMuted
                End If
            End If
            lblOSD.Text = decryptedOSD
        End If

        'POWER INFORMATION
        If output.ToString.Contains("PWR0") Then
            btnPwr.Text = " ON"
            btnPwr.SideColor = CustomSideButton._Color.Green
            If preventpowertoggle = False Then SendCommands("PZ")
            preventpowertoggle = True
        End If
        If output.ToString.Contains("PWR1") Then
            btnPwr.Text = "OFF"
            btnPwr.SideColor = CustomSideButton._Color.Red
            If preventpowertoggle = False Then SendCommands("PZ")
            preventpowertoggle = True
        End If

        'INPUT INFORMATION (MAIN)
        If output.ToString.Contains("FN") Then
            SendCommands("?RGB" & output.ToString.Remove(0, 2))
        End If

        'VOLUME INFORMATION (MAIN)
        If output.ToString.Contains("VOL") Then
            Dim volume As Integer = output.Replace("VOL", "").TrimStart("0"c)
            SliderMVolume.Value = volume
        End If

        'INPUT NAME INFORMATION
        If output.ToString.Contains("RGB") Then
            lblMainInput.Text = output.ToString.Remove(0, 6)
        End If

    End Sub
    Private Sub SliderMVolume_MouseUp(sender As Object, e As MouseEventArgs) Handles SliderMVolume.MouseUp
        'Set volume of AVR to value of slider on mouse release.
        ValidateVolume(SliderMVolume.Value)
    End Sub
End Class