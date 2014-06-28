Imports System.Net.Sockets
Imports System.Net
Imports System.Text

Public Class Form1
    Dim hostIp As IPAddress, serverIp As Byte()
    Private Sub ScanIP(ByVal e As Args)
        Try
            ' If Not serverIp.Length = 0 Then Exit Try
            Dim bytes As Byte() = e.IPAddress.GetAddressBytes()
            bytes(3) = e.IntArg
            Dim tmpClient As New TcpClient()
            Dim newIP As New IPEndPoint(New IPAddress(bytes), 8102)
            tmpClient.Connect(newIP)
            Threading.Thread.Sleep(5) '50 is the Timeout in ms.
                If tmpClient.Connected = True Then
                    Debug.WriteLine("Possible VSX Device Found:  " & newIP.ToString)
                serverIp = bytes
                End If
            tmpClient.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hostIp = Dns.GetHostEntry(String.Empty).AddressList.[Single](Function(x) x.AddressFamily = AddressFamily.InterNetwork)
        Dim Arguments As New Args
        Arguments.IPAddress = hostIp
        For i As Integer = 0 To 254
            Arguments.IntArg = i
            Dim tmpThread As New System.Threading.Thread(AddressOf ScanIP)
            tmpThread.IsBackground = True
            tmpThread.Start(Arguments)
        Next
        Do While serverIp.Length = 0

        Loop
        TrackBar1.Value = SendCommands("VU").ToString.Replace("VOL", "").TrimStart("0"c)
        Dim percent As Integer = (TrackBar1.Value / 185) * 100
        Label1.Text = "VOLUME " & percent & "%"
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

    Private Function SendCommands(ByVal cmd As String)
        If ConnectToVSX(serverIp, "8102") = True Then
            Dim output As String = ""
            Dim result As String()
            Dim SendBytes As [Byte]() = Encoding.ASCII.GetBytes(cmd & vbCrLf)
            Dim RecvString As String = String.Empty
            Dim NumBytes As Integer = 0
            Dim RecvBytes(255) As [Byte]
            tnSocket.Send(SendBytes, SendBytes.Length, SocketFlags.None)
            Threading.Thread.Sleep(200)
            Do
                NumBytes = tnSocket.Receive(RecvBytes, RecvBytes.Length, 0)
                RecvString = RecvString + Encoding.ASCII.GetString(RecvBytes, 0, NumBytes)
                output = output & RecvString
                result = output.Split(vbCrLf)
                
            Loop While NumBytes = 256
            cmd = Nothing
            If result.Length >= 2 Then
                Return result(result.Length - 2).Replace(vbCrLf, "").Replace(vbLf, "")
            Else
                Return result(result.Length).Replace(vbCrLf, "").Replace(vbLf, "")
            End If

        End If
        Return "Error"
    End Function

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        tnSocket.Disconnect(False)
        tnSocket.Close()
    End Sub
    Private Class Args
        Public IPAddress As System.Net.IPAddress
        Public IntArg As Integer
    End Class

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TrackBar1.Value = SendCommands("VU").ToString.Replace("VOL", "").TrimStart("0"c)
        Dim percent As Integer = (TrackBar1.Value / 185) * 100
        Label1.Text = "VOLUME " & percent & "%"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TrackBar1.Value = SendCommands("VD").ToString.Replace("VOL", "").TrimStart("0"c)
        Dim percent As Integer = (TrackBar1.Value / 185) * 100
        Label1.Text = "VOLUME " & percent & "%"
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Dim percent As Integer = (TrackBar1.Value / 185) * 100
        If TrackBar1.Value < 10 Then
            SendCommands("00" & TrackBar1.Value.ToString & "VL")
        ElseIf TrackBar1.Value < 100 Then
            SendCommands("0" & TrackBar1.Value.ToString & "VL")
        Else
            SendCommands(TrackBar1.Value.ToString & "VL")
        End If
        Label1.Text = "VOLUME " & percent & "%"
    End Sub
End Class