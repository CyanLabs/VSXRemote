Imports System.Net.Sockets
Imports System.Net
Imports System.Text
Imports System.Runtime.InteropServices

Public Class Form1

    'Various variables.
    Dim hostIp As IPAddress, serverIp As Byte(), ep As IPEndPoint
    Dim tnSocket As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
    Dim CheckScreen As New System.Threading.Thread(AddressOf UpdateScreen)
    Dim autohide As Boolean = False
    Dim preventpowertoggle As Boolean = True, preventHDZtoggle As Boolean = True, preventZ2toggle As Boolean = True
    Dim dictionary As New Dictionary(Of String, Integer)
    Dim sleeptimer As String = ""

    'Args used for ip scanner.
    Private Class ScannerArgs
        Public IPAddress As System.Net.IPAddress
        Public IntArg As Integer
    End Class

    'Sound Modes, Long List
    Dim soundmodes() As String = {"STEREO (cyclic)", "STANDARD", "STEREO (direct set)", "(2ch source)", "PRO LOGIC2 MOVIE",
    "PRO LOGIC2x MOVIE", "PRO LOGIC2 MUSIC", "PRO LOGIC2x MUSIC", "PRO LOGIC2 GAME", "PRO LOGIC2x GAME", "PRO LOGIC2z HEIGHT",
    "WIDE SURROUND MOVIE", "WIDE SURROUND MUSIC", "PRO LOGIC", "Neo:6 CINEMA", "Neo:6 MUSIC", "XM HD SURROUND", "NEURAL SURROUND",
    "Neo:X CINEMA", "Neo:X MUSIC", "Neo:X GAME", "NEURAL SURROUND+Neo:X CINEMA", "NEURAL SURROUND+Neo:X MUSIC",
    "NEURAL SURROUND+Neo:X GAME", "(Multi ch source)", "(Multi ch source)+DOLBY EX", "(Multi ch source)+PRO LOGIC2x MOVIE",
    "(Multi ch source)+PRO LOGIC2x MUSIC", "(Multi-ch Source)+PRO LOGIC2z HEIGHT", "(Multi-ch Source)+WIDE SURROUND MOVIE",
    "(Multi-ch Source)+WIDE SURROUND MUSIC", "(Multi ch source)DTS-ES Neo:6", "(Multi ch source)DTS-ES matrix",
    "(Multi ch source)DTS-ES discrete", "(Multi ch source)DTS-ES 8ch discrete", "(Multi ch source)DTS-ES Neo:X",
    "ADVANCED SURROUND (cyclic)", "ACTION", "DRAMA", "SCI-FI", "MONO FILM", "ENTERTAINMENT SHOW", "EXPANDED THEATER", "TV SURROUND",
    "ADVANCED GAME", "SPORTS", "CLASSICAL", "ROCK/POP", "UNPLUGGED", "EXTENDED STEREO", "Front Stage Surround Advance Focus", "Front Stage Surround Advance Wide",
     "RETRIEVER AIR", "PHONES SURROUND", "THX (cyclic)", "PROLOGIC + THX CINEMA", "PL2 MOVIE + THX CINEMA", "Neo:6 CINEMA + THX CINEMA",
    "PL2x MOVIE + THX CINEMA", "PL2z HEIGHT + THX CINEMA", "THX SELECT2 GAMES", "THX CINEMA (for 2ch)", "THX MUSIC (for 2ch)",
    "THX GAMES (for 2ch)", "PL2 MUSIC + THX MUSIC", "PL2x MUSIC + THX MUSIC", "PL2z HEIGHT + THX MUSIC", "Neo:6 MUSIC + THX MUSIC",
    "PL2 GAME + THX GAMES", "PL2x GAME + THX GAMES", "PL2z HEIGHT + THX GAMES", "THX ULTRA2 GAMES", "PROLOGIC + THX MUSIC", "PROLOGIC + THX GAMES",
    "Neo:X CINEMA + THX CINEMA", "Neo:X MUSIC + THX MUSIC", "Neo:X GAME + THX GAMES", "THX CINEMA (for multi ch)", "THX SURROUND EX (for multi ch)",
    "PL2x MOVIE + THX CINEMA (for multi ch)", "PL2z HEIGHT + THX CINEMA (for multi ch)", "ES Neo:6 + THX CINEMA (for multi ch)", "ES MATRIX + THX CINEMA (for multi ch)",
    "ES DISCRETE + THX CINEMA (for multi ch)", "ES 8ch DISCRETE + THX CINEMA (for multi ch)", "THX SELECT2 CINEMA (for multi ch)", "THX SELECT2 MUSIC (for multi ch)",
    "THX SELECT2 GAMES (for multi ch)", "THX ULTRA2 CINEMA (for multi ch)", "THX ULTRA2 MUSIC (for multi ch)", "THX ULTRA2 GAMES (for multi ch)", "THX MUSIC (for multi ch)",
    "THX GAMES (for multi ch)", "PL2x MUSIC + THX MUSIC (for multi ch)", "PL2z HEIGHT + THX MUSIC (for multi ch)", "EX + THX GAMES (for multi ch)",
    "PL2z HEIGHT + THX GAMES (for multi ch)", "Neo:6 + THX MUSIC (for multi ch)", "Neo:6 + THX GAMES (for multi ch)", "ES MATRIX + THX MUSIC (for multi ch)",
    "ES MATRIX + THX GAMES (for multi ch)", "ES DISCRETE + THX MUSIC (for multi ch)", "ES DISCRETE + THX GAMES (for multi ch)", "ES 8CH DISCRETE + THX MUSIC (for multi ch)",
    "ES 8CH DISCRETE + THX GAMES (for multi ch)", "Neo:X + THX CINEMA (for multi ch)", "Neo:X + THX MUSIC (for multi ch)", "Neo:X + THX GAMES (for multi ch)",
    "AUTO SURR/STREAM DIRECT (cyclic)", "AUTO SURROUND", "Auto Level Control (A.L.C.)", "DIRECT", "PURE DIRECT", "OPTIMUM SURROUND"}

    'basically builds a ip from the IP bytes then tries to connect to the IP:8102 and if successful assumes it is a pioneer device.
    'TODO - Implement SSDP request instead of this bad method to find the AVR.
    Private Sub ScanIP(ByVal e As ScannerArgs)
        If Not serverIp Is Nothing Then If Not serverIp.Length = 0 Then Exit Sub
        Dim tmpClient As New TcpClient()
        Try
            Dim bytes As Byte() = e.IPAddress.GetAddressBytes()
            bytes(3) = e.IntArg

            Dim newIP As New IPEndPoint(New IPAddress(bytes), 8102)
            tmpClient.Connect(newIP)
            Threading.Thread.Sleep(350) 'Timeout in ms
            If tmpClient.Connected = True Then
                serverIp = bytes
            End If
        Catch ex As System.Net.Sockets.SocketException
            'Ignore exception and continue.
        Finally
            tmpClient.Close()
        End Try
    End Sub
    Private Sub Form1_load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

        'Sets Form to bottom right corner, Mkaes invisible and hides from taskbar.
        Me.Location = New System.Drawing.Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)
        Me.Opacity = 0
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False

        'Gets IP Range from network adapter and adds to arguments.ipaddress.
        'TODO: fix issue with multiple adapters
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

        lblOSD.Font = CustomFont.GetInstance(lblOSD.Font.Size, FontStyle.Regular)
        lblMainInput.Font = CustomFont.GetInstance(lblMainInput.Font.Size, FontStyle.Regular)
        lblMVolume.Font = CustomFont.GetInstance(lblMVolume.Font.Size, FontStyle.Regular)

        cmbMainInputs.DisplayMember = "Key"
        cmbMainInputs.ValueMember = "Value"
        cmbHDZInputs.DisplayMember = "Key"
        cmbHDZInputs.ValueMember = "Value"
        cmbZ2Inputs.DisplayMember = "Key"
        cmbZ2Inputs.ValueMember = "Value"
        cmbSoundModes.DisplayMember = "Key"
        cmbSoundModes.ValueMember = "Value"

        cmbSoundModes.Items.AddRange(soundmodes)

        Do While serverIp Is Nothing
            Threading.Thread.Sleep(1000)
        Loop
        NotifyIcon1.ShowBalloonTip(3000, "VSX Remote", "Connected to " & New IPAddress(serverIp).ToString, ToolTipIcon.Info)
        If ConnectToVSX(serverIp, "8102") = True Then
            'Get input names.
            For i As Integer = 0 To 60
                If i < 10 Then
                    SendCommands("?RGB0" & i)
                Else
                    SendCommands("?RGB" & i)
                End If
            Next

            PollInfo()

            'Starts OSD thread and injects LCD font.
            CheckScreen.IsBackground = True
            CheckScreen.Start()
        End If

        If autohide Then Timer1.Start()
    End Sub

    Private Sub PollInfo()
        'Zone 2 Volume
        SendCommands("?zv")

        'Main Power
        SendCommands("?p")

        'Zone 2 Power
        SendCommands("?ap")

        'HDZone Power
        SendCommands("?zep")

        'MCACC Status
        SendCommands("?mc")

        'Sleep Status
        SendCommands("?sab")

        'HDMI Passthrough
        SendCommands("?ha")

        'Phase Control
        SendCommands("?is")

        Threading.Thread.Sleep(1000)

        'VHT
        SendCommands("?vht")

        'VSB
        SendCommands("?vsb")

        'PQLS
        SendCommands("?pq")

        'EQ
        SendCommands("?atc")

        'Main input
        SendCommands("?f")

        'HDZone input
        SendCommands("?zea")

        'Zone 2 Input
        SendCommands("?zs")

        'Main Mute
        SendCommands("?m")

        'Zone 2 Mute
        SendCommands("?z2m")

        'Volume Down
        SendCommands("vd")

        'Volume Up
        SendCommands("vu")
    End Sub

    'Connects to VSX if not already.
    Private Function ConnectToVSX(ByVal ip() As Byte, ByVal Port As String)
        If tnSocket.Connected Then Return True
        Try
            ep = New IPEndPoint(New IPAddress(ip), CType(Port.Trim, Integer))
        Catch ex As ArgumentNullException
            'do stuff...
        End Try
        Try
            tnSocket.Connect(ep)
            If tnSocket.Connected Then Return True
        Catch oEX As Exception
            Return False
        End Try
        Return False
    End Function

    'Sends "cmd" to VSX.
    Private Function SendCommands(ByVal cmd As String)
            Dim SendBytes As [Byte]() = Encoding.ASCII.GetBytes(cmd & vbCrLf)
            Dim NumBytes As Integer = 0
            tnSocket.Send(SendBytes, SendBytes.Length, SocketFlags.None)
        Return Nothing
    End Function

    'Quick sub to parse volume and remove/add needed amount of zero's.
    Private Sub ValidateVolume(volume As String)
        'if value is less than 10 pre-fix 2 "0"s else if less than 100 pre-fix 1 "0" else just send the command without added "0"s
        If volume >= 185 Then
            SendCommands("185VL")
        ElseIf volume <= 0 Then
            SendCommands("000VL")
        ElseIf volume < 10 Then
            SendCommands("00" & volume & "VL")
        ElseIf volume < 100 Then
            SendCommands("0" & volume & "VL")
        Else
            SendCommands(volume & "VL")
        End If
    End Sub

    'Quick sub to parse Zone 2 Volume and remove/add needed amount of zero's.
    Private Sub ValidateZ2Volume(volume As String)
        'if value is less than 10 pre-fix 2 "0"s else if less than 100 pre-fix 1 "0" else just send the command without added "0"s
        If volume >= 81 Then
            SendCommands("81ZV")
        ElseIf volume <= 0 Then
            SendCommands("00ZV")
        ElseIf volume < 10 Then
            SendCommands("0" & volume & "ZV")
        Else
            SendCommands(volume & "ZV")
        End If
    End Sub

    'Properly disconnect and close the socket.
    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            tnSocket.Disconnect(False)
            tnSocket.Close()
        Catch ex As Exception
            'do stuff soon
        End Try
    End Sub

    'Checks power status and toggles power.
    Private Sub btnPwr_Click(sender As Object, e As EventArgs) Handles btnPwr.Click
        preventpowertoggle = False
        SendCommands("?p")
    End Sub

    'Set volume to current volume - 5.
    Private Sub btnMVolumeDown_Click(sender As Object, e As EventArgs) Handles btnMVolumeDown.Click
        ValidateVolume(SliderMVolume.Value - 5)
    End Sub

    'Set volume to current volume + 5.
    Private Sub btnMVolumeUp_Click(sender As Object, e As EventArgs) Handles btnMVolumeUp.Click
        ValidateVolume(SliderMVolume.Value + 5)
    End Sub

    'Show form and show in taskbar when notification icon clicked or showinterface menu option clicked and update information.
    Private Sub ShowInterface_Click(sender As Object, e As EventArgs) Handles ShowInterface.Click
        Me.WindowState = FormWindowState.Normal
        Me.Opacity = 1
        Me.ShowInTaskbar = True
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
        Dim Rectangle = New Rectangle(Me.Location.X, Me.Location.Y, Me.Width, Screen.PrimaryScreen.WorkingArea.Height)
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
        Try
            output = output.Replace(vbLf, "").Replace(vbCrLf, "")

            If output.ToString.Substring(0, 3) = "IS1" Then
                btnSoundPhaseControl.SideColor = CustomSideButton._Color.Green
            ElseIf output.ToString.Substring(0, 3) = "IS0" Then
                btnSoundPhaseControl.SideColor = CustomSideButton._Color.Red
            End If

            If output.ToString.Substring(0, 4) = "VHT1" Then
                btnSoundVirtualHeight.SideColor = CustomSideButton._Color.Green
            ElseIf output.ToString.Substring(0, 4) = "VHT0" Then
                btnSoundVirtualHeight.SideColor = CustomSideButton._Color.Red
            End If

            If output.ToString.Substring(0, 4) = "VSB1" Then
                btnSoundVirtualSB.SideColor = CustomSideButton._Color.Green
            ElseIf output.ToString.Substring(0, 4) = "VSB0" Then
                btnSoundVirtualSB.SideColor = CustomSideButton._Color.Red
            End If

            If output.ToString.Substring(0, 3) = "PQ1" Then
                btnSoundPQLS.SideColor = CustomSideButton._Color.Green
            ElseIf output.ToString.Substring(0, 3) = "PQ0" Then
                btnSoundPQLS.SideColor = CustomSideButton._Color.Red
            End If

            If output.ToString.Substring(0, 4) = "ATC1" Then
                btnSoundEQ.SideColor = CustomSideButton._Color.Green
            ElseIf output.ToString.Substring(0, 4) = "ATC0" Then
                btnSoundEQ.SideColor = CustomSideButton._Color.Red
            End If

            If output.ToString.Substring(0, 3) = "HA1" Then
                btnSoundPassthrough.SideColor = CustomSideButton._Color.Green
            ElseIf output.ToString.Substring(0, 3) = "HA0" Then
                btnSoundPassthrough.SideColor = CustomSideButton._Color.Red
            End If

            'SCREEN INFORMATION
            If output.ToString.Contains("FL0") Then
                Dim TempScreen = output
                Dim decryptedOSD As String = DecryptScreen(TempScreen)
                If decryptedOSD.ToString.Contains("M.VOL") Then
                    lblMVolume.Text = decryptedOSD.ToString.Replace("M.VOL", "").Replace(" ", "")
                    lblMVolume.ForeColor = Color.Lime
                    btnMute.Text = "  MUTE"
                    btnMute.Image = Global.Pioneer_VSX_Series_Remote_Control.My.Resources.Resources.NotMuted
                End If
                lblOSD.Text = decryptedOSD
            End If

            'POWER INFORMATION
            If output.ToString.Substring(0, 4) = "PWR0" Then
                btnPwr.Text = " ON"
                btnPwr.SideColor = CustomSideButton._Color.Green
                If preventpowertoggle = False Then SendCommands("PZ")
                preventpowertoggle = True
            ElseIf output.ToString.Substring(0, 4) = "PWR1" Then
                btnPwr.Text = "OFF"
                btnPwr.SideColor = CustomSideButton._Color.Red
                If preventpowertoggle = False Then SendCommands("PZ")
                preventpowertoggle = True
            End If

            If output.ToString.Substring(0, 4) = "ZEP0" Then
                btnHDZPwr.Text = " HDZONE ON"
                btnHDZPwr.SideColor = CustomSideButton._Color.Green
                If preventHDZtoggle = False Then SendCommands("ZEZ")
                preventHDZtoggle = True
            ElseIf output.ToString.Substring(0, 4) = "ZEP1" Then
                btnHDZPwr.Text = "HDZONE OFF"
                btnHDZPwr.SideColor = CustomSideButton._Color.Red
                If preventHDZtoggle = False Then SendCommands("ZEZ")
                preventHDZtoggle = True
            End If

            If output.ToString.Substring(0, 4) = "APR0" Then
                btnZ2Pwr.Text = " ZONE 2 ON"
                btnZ2Pwr.SideColor = CustomSideButton._Color.Green
                If preventZ2toggle = False Then SendCommands("APZ")
                preventZ2toggle = True
            ElseIf output.ToString.Substring(0, 4) = "APR1" Then
                btnZ2Pwr.Text = "ZONE 2 OFF"
                btnZ2Pwr.SideColor = CustomSideButton._Color.Red
                If preventZ2toggle = False Then SendCommands("APZ")
                preventZ2toggle = True
            End If

            'INPUT INFORMATION (MAIN)
            If output.ToString.Substring(0, 2) = "FN" Then
                Dim TempInput = output.ToString.Remove(0, 2)
                cmbMainInputs.SelectedValue = Convert.ToInt32(TempInput)
                btnMainInputPrev.Text = cmbMainInputs.Items.Item(cmbMainInputs.SelectedIndex - 1).key.ToString & "  (PREV)"
                btnMainInputPrev.Tag = cmbMainInputs.Items.Item(cmbMainInputs.SelectedIndex - 1).value.ToString
                btnMainInputNext.Text = cmbMainInputs.Items.Item(cmbMainInputs.SelectedIndex + 1).key.ToString & " (NEXT)"
                btnMainInputNext.Tag = cmbMainInputs.Items.Item(cmbMainInputs.SelectedIndex + 1).value.ToString
                SendCommands("?RGB" & TempInput)
            End If

            'INPUT INFORMATION (HDZONE)
            If output.ToString.Substring(0, 3) = "ZEA" Then
                Dim TempHDZInput = output.ToString.Remove(0, 3)
                cmbHDZInputs.SelectedValue = Convert.ToInt32(TempHDZInput)
                btnHDZInputPrev.Text = cmbHDZInputs.Items.Item(cmbHDZInputs.SelectedIndex - 1).key.ToString & "  (PREV)"
                btnHDZInputPrev.Tag = cmbHDZInputs.Items.Item(cmbHDZInputs.SelectedIndex - 1).value.ToString
                btnHDZInputNext.Text = cmbHDZInputs.Items.Item(cmbHDZInputs.SelectedIndex + 1).key.ToString & " (NEXT)"
                btnHDZInputNext.Tag = cmbHDZInputs.Items.Item(cmbHDZInputs.SelectedIndex + 1).value.ToString
            End If

            'INPUT INFORMATION (ZONE2)
            If output.ToString.Substring(0, 3) = "Z2F" Then
                Dim TempZ2Input = output.ToString.Remove(0, 3)
                cmbZ2Inputs.SelectedValue = Convert.ToInt32(TempZ2Input)
                btnZ2InputPrev.Text = cmbZ2Inputs.Items.Item(cmbZ2Inputs.SelectedIndex - 1).key.ToString & "  (PREV)"
                btnZ2InputPrev.Tag = cmbZ2Inputs.Items.Item(cmbZ2Inputs.SelectedIndex - 1).value.ToString
                btnZ2InputNext.Text = cmbZ2Inputs.Items.Item(cmbZ2Inputs.SelectedIndex + 1).key.ToString & " (NEXT)"
                btnZ2InputNext.Tag = cmbZ2Inputs.Items.Item(cmbZ2Inputs.SelectedIndex + 1).value.ToString
            End If

            'VOLUME INFORMATION (MAIN)
            If output.ToString.Substring(0, 2) = "ZV" Then
                Dim TempVol = output
                If TempVol.ToString = "ZV00" Then
                    SliderZ2Volume.Value = 0
                Else
                    Dim volume As Integer = TempVol.Replace("ZV", "").TrimStart("0"c)
                    SliderZ2Volume.Value = volume
                End If
            End If

            'VOLUME INFORMATION (ZONE2)
            If output.ToString.Substring(0, 3) = "VOL" Then
                Dim TempVol = output
                If TempVol.ToString = "VOL000" Then
                    SliderMVolume.Value = 0
                Else
                    Dim volume As Integer = TempVol.Replace("VOL", "").TrimStart("0"c)
                    SliderMVolume.Value = volume
                End If
            End If

            'INPUT NAME INFORMATION
            If output.ToString.Substring(0, 3) = "RGB" Then
                Dim TempInputName = output
                lblMainInput.Text = TempInputName.ToString.Remove(0, 6)
                If dictionary.TryGetValue(TempInputName.ToString.Remove(0, 6), TempInputName.ToString.Substring(3, 2)) = False AndAlso TempInputName.Length < 24 Then
                    dictionary.Add(TempInputName.ToString.Remove(0, 6), TempInputName.ToString.Substring(3, 2))
                    cmbMainInputs.DataSource = New BindingSource(dictionary, Nothing)
                    cmbHDZInputs.DataSource = New BindingSource(dictionary, Nothing)
                    cmbZ2Inputs.DataSource = New BindingSource(dictionary, Nothing)
                End If
            End If

            'PARSE ERROR CODES
            If output.ToString = "E04" Then
                lblOSD.Text = "COMMAND ERROR"
            End If

            'PARSE BUSY CODE
            If output.ToString = "B00" Then
                lblOSD.Text = "DEVICE BUSY"
            End If

            'SLEEP INFORMATION
            If output.ToString.Substring(0, 3) = "SAB" Then sleeptimer = output.ToString

            'MUTE INFORMATION (Main)
            If output.ToString.Substring(0, 4) = "MUT0" Then
                lblMVolume.ForeColor = Color.Red
                btnMute.Text = "UN-MUTE"
                btnMute.Image = Global.Pioneer_VSX_Series_Remote_Control.My.Resources.Resources.Muted
            End If
            If output.ToString.Substring(0, 4) = "MUT1" Then
                lblMVolume.ForeColor = Color.Lime
                btnMute.Text = "  MUTE"
                btnMute.Image = Global.Pioneer_VSX_Series_Remote_Control.My.Resources.Resources.NotMuted
            End If

            'MUTE INFORMATION (Zone 2)
            If output.ToString.Substring(0, 6) = "Z2MUT0" Then
                btnZ2Mute.Text = "UN-MUTE"
                btnZ2Mute.Image = Global.Pioneer_VSX_Series_Remote_Control.My.Resources.Resources.Muted
            End If
            If output.ToString.Substring(0, 6) = "Z2MUT1" Then
                btnZ2Mute.Text = "  MUTE"
                btnZ2Mute.Image = Global.Pioneer_VSX_Series_Remote_Control.My.Resources.Resources.NotMuted
            End If
        Catch
        End Try
    End Sub

    'Set volume of AVR to value of slider on mouse release.
    Private Sub SliderMVolume_MouseUp(sender As Object, e As MouseEventArgs) Handles SliderMVolume.MouseUp
        ValidateVolume(SliderMVolume.Value)
    End Sub

    'Resizes window, Switches active tab depending on circumstances.
    Private Sub btnMainZone_Click_1(sender As Object, e As EventArgs) Handles btnZone2.Click, btnMainZone.Click, btnHDZone.Click, btnSound.Click, btnPlayback.Click, btnNavigation.Click
        Dim color = sender.sidecolor

        btnMainZone.SideColor = CustomSideButton._Color.Yellow
        btnHDZone.SideColor = CustomSideButton._Color.Yellow
        btnZone2.SideColor = CustomSideButton._Color.Yellow
        btnSound.SideColor = CustomSideButton._Color.Yellow
        btnNavigation.SideColor = CustomSideButton._Color.Yellow
        btnPlayback.SideColor = CustomSideButton._Color.Yellow

        If Me.Height = 400 And color = CustomSideButton._Color.Green Then
            Me.Height = 200
        ElseIf color = CustomSideButton._Color.Yellow OrElse Me.Height = 200 Then
            Me.Height = 400
            sender.sidecolor = CustomSideButton._Color.Green
        End If

        If sender.name = "btnMainZone" Then tabControls.SelectedIndex = 0
        If sender.name = "btnHDZone" Then tabControls.SelectedIndex = 1
        If sender.name = "btnZone2" Then tabControls.SelectedIndex = 2
        If sender.name = "btnSound" Then tabControls.SelectedIndex = 3
        If sender.name = "btnNavigation" Then tabControls.SelectedIndex = 4
        If sender.name = "btnPlayback" Then tabControls.SelectedIndex = 5

        Me.Location = New System.Drawing.Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)
    End Sub

    'Changes input to the input selected in cmbMainInputs combobox.
    Private Sub cmbMainInputs_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbMainInputs.SelectionChangeCommitted
        SendCommands(cmbMainInputs.SelectedItem.value & "FN")
    End Sub

    'Left click only, Shows UI.
    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.WindowState = FormWindowState.Normal
            Me.Opacity = 1
            Me.ShowInTaskbar = True
            If autohide Then Timer1.Start()
        End If
    End Sub

    'Change input to the sender.tag's value.
    Private Sub btnMainInputCycle_Click(sender As Object, e As EventArgs) Handles CustomSideButton4.Click, CustomSideButton3.Click, CustomSideButton2.Click, CustomSideButton1.Click, btnMainInputPrev.Click, btnMainInputNext.Click
        If Not sender.tag = "" Then SendCommands(sender.tag & "FN")
    End Sub

    'Send DPAD Enter.
    Private Sub btnNavOK_Click(sender As Object, e As EventArgs) Handles btnNavOK.Click
        SendCommands("CEN")
    End Sub

    'Send DPAD Right.
    Private Sub btnNavRight_Click(sender As Object, e As EventArgs) Handles btnNavRight.Click
        SendCommands("CRI")
    End Sub

    'Send DPAD Left.
    Private Sub btnNavLeft_Click(sender As Object, e As EventArgs) Handles btnNavLeft.Click
        SendCommands("CLE")
    End Sub

    'Send DPAD Up.
    Private Sub btnNavUp_Click(sender As Object, e As EventArgs) Handles btnNavUp.Click
        SendCommands("CUP")
    End Sub

    'Send DPAD Down.
    Private Sub btnNavDown_Click(sender As Object, e As EventArgs) Handles btnNavDown.Click
        SendCommands("CDN")
    End Sub

    'Send Audio Parameters.
    Private Sub btnNavAudio_Click(sender As Object, e As EventArgs) Handles btnNavAudio.Click
        SendCommands("APA")
    End Sub

    'Send Video Parameters.
    Private Sub btnNavVideo_Click(sender As Object, e As EventArgs) Handles btnNavVideo.Click
        SendCommands("VPA")
    End Sub

    'Send Home/Menu.
    Private Sub btnNavHome_Click(sender As Object, e As EventArgs) Handles btnNavHome.Click
        SendCommands("HM")
    End Sub

    'Send DPAD Return.
    Private Sub btnNavReturn_Click(sender As Object, e As EventArgs) Handles btnNavReturn.Click
        SendCommands("CRT")
    End Sub

    'Send Info/Status.
    Private Sub btnNavInfo_Click(sender As Object, e As EventArgs) Handles btnNavInfo.Click
        SendCommands("STS")
    End Sub

    'Toggle Sleep Status.
    Private Sub btnNavSleep_Click(sender As Object, e As EventArgs) Handles btnNavSleep.Click
        If sleeptimer = "SAB000" Then
            SendCommands("030SAB")
        ElseIf sleeptimer = "SAB030" Then
            SendCommands("060SAB")
        ElseIf sleeptimer = "SAB060" Then
            SendCommands("090SAB")
        ElseIf sleeptimer = "SAB090" Then
            SendCommands("000SAB")
        End If
    End Sub

    'Change HDZone input to the sender.tag's value.
    Private Sub btnHDZInputCycle_Click(sender As Object, e As EventArgs) Handles btnHDZInputNext.Click, btnHDZInputPrev.Click
        If Not sender.tag = "" Then SendCommands(sender.tag & "ZEA")
    End Sub

    'Changes HDZone input to the input selected in cmbHDZInputs combobox.
    Private Sub cmbHDZInputs_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbHDZInputs.SelectionChangeCommitted
        SendCommands(cmbHDZInputs.SelectedItem.value & "ZEA")
    End Sub

    'Checks HDZone power status and toggles power.
    Private Sub btnHDZPwr_Click(sender As Object, e As EventArgs) Handles btnHDZPwr.Click
        preventHDZtoggle = False
        SendCommands("?ZEP")
    End Sub

    'Sends Z2MZ (Zone 2 Mute Toggle) command.
    Private Sub btnZ2Mute_Click(sender As Object, e As EventArgs) Handles btnZ2Mute.Click
        SendCommands("Z2MZ")
    End Sub

    'Update Zone 2 Volume
    Private Sub SliderZ2Volume_MouseUp(sender As Object, e As MouseEventArgs) Handles SliderZ2Volume.MouseUp
        ValidateZ2Volume(SliderZ2Volume.Value)
    End Sub

    'Decrease Zone 2 Volume by 5
    Private Sub btnZ2VolumeDown_Click(sender As Object, e As EventArgs) Handles btnZ2VolumeDown.Click
        ValidateZ2Volume(SliderZ2Volume.Value - 5)
    End Sub

    'Increase Zone 2 Volume by 5
    Private Sub btnZ2VolumeUp_Click(sender As Object, e As EventArgs) Handles btnZ2VolumeUp.Click
        ValidateZ2Volume(SliderZ2Volume.Value + 5)
    End Sub

    'Checks Zone 2 power status and toggles power.
    Private Sub btnZ2Pwr_Click(sender As Object, e As EventArgs) Handles btnZ2Pwr.Click
        preventZ2toggle = False
        SendCommands("?AP")
    End Sub

    Private Sub btnSoundPhaseControl_Click(sender As Object, e As EventArgs) Handles btnSoundPhaseControl.Click
        If sender.sidecolor = CustomSideButton._Color.Green Then
            SendCommands("0IS")
        Else
            SendCommands("1IS")
        End If
    End Sub

    Private Sub btnSoundVirtualHeight_Click(sender As Object, e As EventArgs) Handles btnSoundVirtualHeight.Click
        If sender.sidecolor = CustomSideButton._Color.Green Then
            SendCommands("0VHT")
        Else
            SendCommands("1VHT")
        End If
    End Sub

    Private Sub btnSoundVirtualSB_Click(sender As Object, e As EventArgs) Handles btnSoundVirtualSB.Click
        If sender.sidecolor = CustomSideButton._Color.Green Then
            SendCommands("0VSB")
        Else
            SendCommands("1VSB")
        End If
    End Sub

    Private Sub btnSoundPQLS_Click(sender As Object, e As EventArgs) Handles btnSoundPQLS.Click
        If sender.sidecolor = CustomSideButton._Color.Green Then
            SendCommands("0PQ")
        Else
            SendCommands("1PQ")
        End If
    End Sub

    Private Sub btnEQToggle_Click(sender As Object, e As EventArgs) Handles btnSoundEQ.Click
        If sender.sidecolor = CustomSideButton._Color.Green Then
            SendCommands("0ATC")
        Else
            SendCommands("1ATC")
        End If
    End Sub

    Private Sub btnSoundOutputToggle_Click(sender As Object, e As EventArgs) Handles btnSoundPassthrough.Click
        If sender.sidecolor = CustomSideButton._Color.Green Then
            SendCommands("0HA")
        Else
            SendCommands("1HA")
        End If
    End Sub

    Private Sub cmbMCACC_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbMCACC.SelectionChangeCommitted
        SendCommands((cmbMCACC.SelectedIndex + 1) & "MC")
    End Sub
End Class