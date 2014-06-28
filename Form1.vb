Imports System.Net.Sockets
Imports System.Net
Imports System.Text

Public Class Form1
    'various variables
    Dim hostIp As IPAddress, serverIp As Byte()
    Dim ep As IPEndPoint
    Dim tnSocket As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)

    'args used for ip scanner
    Private Class ScannerArgs
        Public IPAddress As System.Net.IPAddress
        Public IntArg As Integer
    End Class

    Private Sub ScanIP(ByVal e As ScannerArgs)

        'basically builds a ip from the IP bytes then tries to connect to the IP:8102 and if successful assumes it is a pioneer device
        'TODO - Implement SSDP request instead of this bad method to find the AVR.
        Dim tmpClient As New TcpClient()
        Try
            Dim bytes As Byte() = e.IPAddress.GetAddressBytes()
            bytes(3) = e.IntArg

            Dim newIP As New IPEndPoint(New IPAddress(bytes), 8102)
            tmpClient.Connect(newIP)
            Threading.Thread.Sleep(50) '50 is the Timeout in ms
            If tmpClient.Connected = True Then
                NotifyIcon1.ShowBalloonTip(3000, "VSX Remote", "Connected to " & newIP.ToString & vbNewLine & "Double click icon to open interface", ToolTipIcon.Info)
                serverIp = bytes
            End If
            tmpClient.Close()
        Catch ex As Exception
            tmpClient.Close()
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Sets Form to bottom right corner, Mkaes invisible and hides from taskbar
        Me.Location = New System.Drawing.Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)
        ' Me.Opacity = 0
        ' Me.WindowState = FormWindowState.Minimized
        ' Me.ShowInTaskbar = False

        'Gets IP Range from network adapter and adds to arguments.ipaddress
        hostIp = Dns.GetHostEntry(String.Empty).AddressList.[Single](Function(x) x.AddressFamily = AddressFamily.InterNetwork)
        Dim Arguments As New ScannerArgs
        Arguments.IPAddress = hostIp

        'creates 254 threads to scan 254 IP's extremely quickly.
        For i As Integer = 0 To 254
            Arguments.IntArg = i
            Dim tmpThread As New System.Threading.Thread(AddressOf ScanIP)
            tmpThread.IsBackground = True
            tmpThread.Start(Arguments)
        Next

        'attempts to check if device found
        Try
            Do While serverIp.Length = 0
            Loop
        Catch ex As Exception
            MsgBox("No Pioneer AVR Detected, You will be able to manually config the application in a future release")
            Application.Exit()
        End Try
        'checks if device is powered on or not
        CheckPwr(False, False)

        'checks if device is muted to show correct text/graphics
        If CheckMute() Then
            btnMute.Text = "UN-MUTE"
            btnMute.Image = Global.Pioneer_VSX_Series_Remote_Control.My.Resources.Resources.NotMuted
            lblMVolume.Visible = False
            lblMuted.Visible = True
        End If
    End Sub

    Private Function ConnectToVSX(ByVal ip() As Byte, ByVal Port As String)

        'If socket is already connected skips connecting and returns true
        If tnSocket.Connected Then Return True

        'Connects to IP:8102
        ep = New IPEndPoint(New IPAddress(ip), CType(Port.Trim, Integer))
        Try
            tnSocket.Connect(ep)
        Catch oEX As SocketException
            Return False
        End Try

        'Confirms we are connected
        Try
            If tnSocket.Connected Then
                Return True
            Else
                Return False
            End If
        Catch oEX As Exception
            Return False
        End Try
    End Function

    Private Function SendCommands(ByVal cmd As String, Optional ByVal expectedresult As String = "", Optional ByVal amount As Integer = 1)
        'Checks if connected if not connects
        If ConnectToVSX(serverIp, "8102") = True Then
            Dim output As String = ""
            Dim result As String()
            Dim SendBytes As [Byte]() = Encoding.ASCII.GetBytes(cmd & vbCrLf)
            Dim RecvString As String = String.Empty
            Dim NumBytes As Integer = 0
            Dim RecvBytes(255) As [Byte]

            'loops through the command the amount of times specified by the "amount" parameter
            For i As Integer = 1 To amount
                tnSocket.Send(SendBytes, SendBytes.Length, SocketFlags.None)
                Threading.Thread.Sleep(50)
            Next
            'sleep for 200ms just to make sure command(s) are sent
            Threading.Thread.Sleep(200)
            Do
                NumBytes = tnSocket.Receive(RecvBytes, RecvBytes.Length, 0)
                RecvString = RecvString + Encoding.ASCII.GetString(RecvBytes, 0, NumBytes)
                output = output & RecvString
                result = output.Split(vbCrLf)
            Loop While NumBytes = 256

            cmd = Nothing

            'loops through all response strings
            For i As Integer = result.Count - 1 To 0 Step -1

                'finds the one that is the latest and matches desired output
                If Not expectedresult = "" Then
                    If Not result(i).ToString.Contains(expectedresult) AndAlso Not result(i).ToString.Contains("FL") AndAlso Not result(i).ToString = vbLf AndAlso Not result(i).ToString = "" Then
                        Return result(i).ToString
                    End If
                End If

                'if no desired output specified grabs latest non "FL" or blank response
                If Not result(i).ToString.Contains("FL") AndAlso Not result(i).ToString = vbLf AndAlso Not result(i).ToString = "" Then
                    Return result(i).ToString
                End If
            Next
        End If
        Return Nothing
    End Function

    Private Function CheckPwr(Optional ByVal pwron As Boolean = True, Optional ByVal pwroff As Boolean = False)
        'sends ?p command to check power status
        If SendCommands("?p", "PWR").ToString = "PWR0" Then

            'if status is on and if parameter pwroff is set to true then turns system off and sets GUI to represent this
            If pwroff = True Then
                SendCommands("PF")
                btnPwr.Text = "OFF"
                btnPwr.SideColor = CustomSideButton._Color.Red
                lblPowerOff.Visible = True
                Return False

                'if status is on and if parameter pwroff is set to false then just sets GUI to represent this
            Else
                btnPwr.Text = "ON"
                btnPwr.SideColor = CustomSideButton._Color.Green
                lblPowerOff.Visible = False
                Dim percent As Integer = (SendCommands("?v").ToString.Replace("VOL", "").TrimStart("0"c) / 185) * 100
                lblMVolume.Text = "VOLUME " & percent & "%"
                Return True
            End If

        Else

            'if status is off and if parameter pwron is set to true then turns system on and sets GUI to represent this
            If pwron = True Then
                SendCommands("PO")
                btnPwr.Text = "ON"
                lblPowerOff.Visible = False
                btnPwr.SideColor = CustomSideButton._Color.Green
                Dim percent As Integer = (SendCommands("?v").ToString.Replace("VOL", "").TrimStart("0"c) / 185) * 100
                lblMVolume.Text = "VOLUME " & percent & "%"
                Return True

                'if status is on and if parameter pwron is set to false then just sets GUI to represent this
            Else
                btnPwr.Text = "OFF"
                lblPowerOff.Visible = True
                btnPwr.SideColor = CustomSideButton._Color.Red
                Return False
            End If
        End If
    End Function

    Private Function CheckMute()
        'sends ?m command to check mute status
        If SendCommands("?m", "MUT").ToString = "MUT0" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'Properly disconnect and close the socket
        tnSocket.Disconnect(False)
        tnSocket.Close()
    End Sub

    Private Sub btnPwr_Click(sender As Object, e As EventArgs) Handles btnPwr.Click
        'checks power status and since it has both parameters set to true also turns device off if on and on if off
        CheckPwr(True, True)
    End Sub

    Private Sub btnMVolumeDown_Click(sender As Object, e As EventArgs) Handles btnMVolumeDown.Click
        'sends 10 volume down commands and then mathematically works out a percent from current volume and sets GUI to match
        Dim percent As Integer = (SendCommands("VD", "VOL", 10).ToString.Replace("VOL", "").TrimStart("0"c) / 185) * 100
        lblMVolume.Text = "VOLUME " & percent & "%"
    End Sub

    Private Sub btnMVolumeUp_Click(sender As Object, e As EventArgs) Handles btnMVolumeUp.Click
        'sends 10 volume up commands and then mathematically works out a percent from current volume and sets GUI to match
        Dim percent As Integer = (SendCommands("VU", "VOL", 10).ToString.Replace("VOL", "").TrimStart("0"c) / 185) * 100
        lblMVolume.Text = "VOLUME " & percent & "%"
    End Sub

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick, ShowInterface.Click
        'Show form and show in taskbar when notification icon double clicked or showinterface menu option clicked
        Me.WindowState = FormWindowState.Normal
        Me.Opacity = 1
        Me.ShowInTaskbar = True
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        'Loops increased opacity for a fade out like effect
        For counter = 1.1 To 0.0 Step -0.1
            Me.Opacity = counter
            Me.Refresh()
            Threading.Thread.Sleep(25)
        Next counter
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
    End Sub

    Private Sub ExitApplication_Click(sender As Object, e As EventArgs) Handles ExitApplication.Click
        'close application correctly
        Application.Exit()
    End Sub

    Private Sub btnMute_Click(sender As Object, e As EventArgs) Handles btnMute.Click
        'Sends MZ to toggle mute status then gets new mute status and sets GUI accordingly
        SendCommands("MZ")
        If CheckMute() Then
            btnMute.Text = "UN-MUTE"
            btnMute.Image = Global.Pioneer_VSX_Series_Remote_Control.My.Resources.Resources.Muted
            lblMVolume.Visible = False
            lblMuted.Visible = True
        Else
            btnMute.Text = "   MUTE"
            btnMute.Image = Global.Pioneer_VSX_Series_Remote_Control.My.Resources.Resources.NotMuted
            lblMuted.Visible = False
            lblMVolume.Visible = True
        End If
    End Sub

    Private Sub SliderMVolume_Scroll(sender As Object) Handles SliderMVolume.Scroll
        Dim percent As Integer = (SliderMVolume.Value / 185) * 100
        If SliderMVolume.Value < 10 Then
            SendCommands("00" & SliderMVolume.Value.ToString & "VL", "VL")
        ElseIf SliderMVolume.Value < 100 Then
            SendCommands("0" & SliderMVolume.Value.ToString & "VL", "VL")
        Else
            SendCommands(SliderMVolume.Value.ToString & "VL", "VL")
        End If
        lblMVolume.Text = "VOLUME " & percent & "%"
    End Sub
End Class