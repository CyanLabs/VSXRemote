Imports System.Net.Sockets
Imports System.Net
Imports System.Text

Public Class Form1
    Dim hostIp As IPAddress, serverIp As Byte()
    Private Sub ScanIP(ByVal e As Args)
        Dim tmpClient As New TcpClient()
        Try
            Dim bytes As Byte() = e.IPAddress.GetAddressBytes()
            bytes(3) = e.IntArg

            Dim newIP As New IPEndPoint(New IPAddress(bytes), 8102)
            tmpClient.Connect(newIP)
            Threading.Thread.Sleep(50) '50 is the Timeout in ms.
            If tmpClient.Connected = True Then
                NotifyIcon1.ShowBalloonTip(3000, "VSX Remote", "Connected to " & newIP.ToString & vbNewLine & "Double click icon to open interface", ToolTipIcon.Info)
                Debug.WriteLine("Possible VSX Device Found:  " & newIP.ToString)
                serverIp = bytes
            End If
            tmpClient.Close()
        Catch ex As Exception
            tmpClient.Close()
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New System.Drawing.Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)
        Me.Opacity = 0
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False

        hostIp = Dns.GetHostEntry(String.Empty).AddressList.[Single](Function(x) x.AddressFamily = AddressFamily.InterNetwork)
        Dim Arguments As New Args
        Arguments.IPAddress = hostIp
        For i As Integer = 0 To 254
            Arguments.IntArg = i
            Dim tmpThread As New System.Threading.Thread(AddressOf ScanIP)
            tmpThread.IsBackground = True
            tmpThread.Start(Arguments)
        Next
        Try
            Do While serverIp.Length = 0
            Loop
        Catch ex As Exception
            MsgBox("No Pioneer AVR Detected, You will be able to manually config the application in a future release")
            Application.Exit()
        End Try
        Dim percent As Integer = (SendCommands("?v", True, False).ToString.Replace("VOL", "").TrimStart("0"c) / 185) * 100
        lblMVolume.Text = "VOLUME " & percent & "%"

        If CheckMute() Then
            btnMute.Text = "UN-MUTE"
            btnMute.Image = Global.Pioneer_VSX_Series_Remote_Control.My.Resources.Resources.NotMuted
            lblMVolume.Visible = False
            lblMuted.Visible = True
        End If

        CheckPwr(False, False)
    End Sub

    Dim ep As IPEndPoint
    Dim tnSocket As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
    Private Function ConnectToVSX(ByVal ip() As Byte, ByVal Port As String)
        If tnSocket.Connected Then Return True
        ep = New IPEndPoint(New IPAddress(ip), CType(Port.Trim, Integer))
        Try
            tnSocket.Connect(ep)
        Catch oEX As SocketException
            Return False
        End Try

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

    Private Function SendCommands(ByVal cmd As String, Optional ByVal bypasscheck As Boolean = False, Optional ByVal pwron As Boolean = True, Optional ByVal amount As Integer = 1)
        If CheckPwr(bypasscheck, pwron) = True Then
            If ConnectToVSX(serverIp, "8102") = True Then
                Dim output As String = ""
                Dim result As String()
                Dim SendBytes As [Byte]() = Encoding.ASCII.GetBytes(cmd & vbCrLf)
                Dim RecvString As String = String.Empty
                Dim NumBytes As Integer = 0
                Dim RecvBytes(255) As [Byte]
                For i As Integer = 1 To amount
                    tnSocket.Send(SendBytes, SendBytes.Length, SocketFlags.None)
                Next
                Threading.Thread.Sleep(200)
                Do
                    NumBytes = tnSocket.Receive(RecvBytes, RecvBytes.Length, 0)
                    RecvString = RecvString + Encoding.ASCII.GetString(RecvBytes, 0, NumBytes)
                    output = output & RecvString
                    result = output.Split(vbCrLf)
                Loop While NumBytes = 256

                cmd = Nothing

                For i As Integer = result.Count - 1 To 0 Step -1
                    If Not result(i).ToString.Contains("FL") AndAlso Not result(i).ToString = vbLf AndAlso Not result(i).ToString = "" Then
                        Return result(i).ToString
                    End If
                Next
            End If
        End If
        Return Nothing
    End Function

    Private Function CheckPwr(Optional ByVal bypasscheck As Boolean = False, Optional ByVal pwron As Boolean = True, Optional ByVal pwroff As Boolean = False)
        If bypasscheck = True Then Return True

        If SendCommands("?p", True).ToString = "PWR0" Then
            If pwroff = True Then
                SendCommands("PF", True)
                btnPwr.Text = "OFF"
                btnPwr.SideColor = CustomSideButton._Color.Red
                Return False
            Else
                btnPwr.Text = "ON"
                btnPwr.SideColor = CustomSideButton._Color.Green
                Return True
            End If

        Else
            If pwron = True Then
                SendCommands("PO", True)
                btnPwr.Text = "ON"
                btnPwr.SideColor = CustomSideButton._Color.Green
                Return True
            Else
                btnPwr.Text = "OFF"
                btnPwr.SideColor = CustomSideButton._Color.Red
                Return False
            End If
        End If
    End Function

    Private Function CheckMute()
        If SendCommands("?m", True).ToString = "MUT0" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        tnSocket.Disconnect(False)
        tnSocket.Close()
    End Sub
    Private Class Args
        Public IPAddress As System.Net.IPAddress
        Public IntArg As Integer
    End Class

    Private Sub btnPwr_Click(sender As Object, e As EventArgs) Handles btnPwr.Click
        CheckPwr(False, True, True)
    End Sub

    Private Sub btnMVolumeDown_Click(sender As Object, e As EventArgs) Handles btnMVolumeDown.Click
        Dim percent As Integer = (SendCommands("VD", False, False, 10).ToString.Replace("VOL", "").TrimStart("0"c) / 185) * 100
        lblMVolume.Text = "VOLUME " & percent & "%"
    End Sub

    Private Sub btnMVolumeUp_Click(sender As Object, e As EventArgs) Handles btnMVolumeUp.Click
        Dim percent As Integer = (SendCommands("VU").ToString.Replace("VOL", "").TrimStart("0"c) / 185) * 100
        lblMVolume.Text = "VOLUME " & percent & "%"
    End Sub

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick, ShowInterface.Click
        Me.Opacity = 1
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        Me.Opacity = 0
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
    End Sub

    Private Sub ExitApplication_Click(sender As Object, e As EventArgs) Handles ExitApplication.Click
        Application.Exit()
    End Sub

    Private Sub btnMute_Click(sender As Object, e As EventArgs) Handles btnMute.Click
        SendCommands("MZ", True)
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
End Class