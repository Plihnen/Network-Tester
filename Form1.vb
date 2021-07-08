Imports System.Threading
Imports System.Net.NetworkInformation
Imports System.Management
Imports System.Net.Sockets
Partial Public Class Form1

    Private success As New List(Of Integer)
    Private done As New List(Of Integer)
    Private fThread As Thread
    Private fThread2 As Thread
    Private pthread As Thread
    Private clicked As Boolean
    Private coreCount As Integer
    Private stopb As Boolean

    Public Delegate Sub AddRowDelegate(ByVal column As Integer)
    Delegate Sub CheckOnlineDelegate(ByVal rowindex As Integer)
    Delegate Sub SetOnlineDelegate(ByVal rowindex As Integer)



    Private Sub progress()
        Dim fg As Decimal = fGrid.RowCount
        Dim max As Decimal = (100.0 / fg)
        Dim increment As Decimal = max


        If clicked = True Then pbRun.Value = 0 And increment = 0
        If clicked = True Then clicked = False

            If pbRun.Value + increment > 100 Then
                pbRun.Value = 100 - increment
            End If
            pbRun.Value += increment










    End Sub

    Private Sub AddRow(ByVal rowindex As Integer)
        Dim ip1 As String = txtIP.Text
        Dim ip2 As String = txtIP2.Text
        Dim ipsplit As String() = ip1.Split(".")
        Dim ip2split As String() = ip2.Split(".")
        If stopb = False Then



            If fGrid.Rows(rowindex).Cells(1).Value Is Nothing OrElse fGrid.Rows(rowindex).Cells(1).Value.ToString.Contains(".....") OrElse Not fGrid.Rows(rowindex).Cells(1).Value.ToString.Contains("Pinging") Then
                fGrid.Rows(rowindex).Cells(1).Value = "Pinging "
            Else
                fGrid.Rows(rowindex).Cells(1).Value = fGrid.Rows(rowindex).Cells(0).Value.ToString & "."
            End If
            fGrid.Rows(rowindex).Cells(1).Style.BackColor = Drawing.Color.White

        Else
        End If
    End Sub

    Private Sub FindAddresses()
        Dim item As Object




        For Each item In New System.Management.ManagementObjectSearcher("Select * from Win32_Processor").[Get]()
            coreCount += Integer.Parse(item("NumberOfCores").ToString())
            coreCount = (coreCount * 2) - 1

        Next


    End Sub





    Private Sub SetOnline(ByVal rowindex As Integer)
        If stopb = False Then

            If Not success.Contains(rowindex) Then
                fGrid.Rows(rowindex).Cells(1).Value = "Offline"
                fGrid.Rows(rowindex).Cells(1).Style.BackColor = Drawing.Color.Red
            Else
                fGrid.Rows(rowindex).Cells(1).Value = "Online"
                fGrid.Rows(rowindex).Cells(1).Style.BackColor = Drawing.Color.Green
            End If
        Else

        End If
    End Sub

    Private Sub ThreadProc()
        Dim r As Integer = fGrid.RowCount


        Parallel.For(0, r, (New ParallelOptions() With {.MaxDegreeOfParallelism = coreCount}),
                     Sub(b)

                         Do While Not done.Contains(b)
                             fGrid.Invoke(New AddRowDelegate(AddressOf AddRow), New Object() {b})
                             Thread.Sleep(4000)

                         Loop
                         fGrid.Invoke(New SetOnlineDelegate(AddressOf SetOnline), New Object() {b})
                     End Sub)
    End Sub
    Private Sub ThreadProc2()
        Dim r As Integer = fGrid.RowCount

        Parallel.For(0, r, Sub(b) '(New ParallelOptions() With {.MaxDegreeOfParallelism = coreCount}),

                               CheckOnline(b)
                               host(b)
                               Thread.Sleep(4000)
                           End Sub)
    End Sub
    'Private Sub ThreadProc3()
    '    Dim r As Integer = fGrid.RowCount


    '    Parallel.For(0, r, Sub(b) '(New ParallelOptions() With {.MaxDegreeOfParallelism = coreCount}),

    '                           popports(b)
    '                     Thread.Sleep(1000)
    '                 End Sub)
    'End Sub

    Private Sub CheckOnline(ByVal rowindex As Integer)
        Dim ip1 As String = txtIP.Text
        Dim ip2 As String = txtIP2.Text
        Dim ipsplit As String() = ip1.Split(".")
        Dim ip2split As String() = ip2.Split(".")
        Dim _ping As New Ping
        Dim timeout As Integer = 5
        Dim i As Integer = CInt(ipsplit(3))
        Do Until i = CInt(ip2split(3)) + 1
            Try
                Dim _pingreply = _ping.Send(fGrid.Rows(rowindex).Cells(0).Value.ToString, timeout)
                If _pingreply.Status = IPStatus.Success Then
                    SyncLock success
                        success.Add(rowindex)
                    End SyncLock
                End If
            Catch ex As Exception
            End Try
            SyncLock done
                done.Add(rowindex)
            End SyncLock
            i += 1
        Loop

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fGrid.Columns.Add("Ip", "Ip")
        fGrid.Columns.Add("Ping", "Ping")
        fGrid.Columns.Add("Host", "Host")
        fGrid.Columns(0).Width = 160
        fGrid.Columns(1).Width = 160
        fGrid.Columns(2).Width = 160
        FindAddresses()
        btdisable()
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub Fill_IP()
        Dim ip1 As String = txtIP.Text
        Dim ip2 As String = txtIP2.Text
        Dim ipsplit As String() = ip1.Split(".")
        Dim ip2split As String() = ip2.Split(".")
        Dim i As Integer = CInt(ipsplit(3))
        Do
            Dim myRowIndex = fGrid.Rows.Add()
            fGrid.Rows(myRowIndex).Cells(0).Value = ipsplit(0) + "." & ipsplit(1) & "." & ipsplit(2) + "." & i.ToString
            i += 1
        Loop Until i = CInt(ip2split(3)) + 1
    End Sub

    'Private Sub progress()

    '    Dim fg As Decimal = fGrid.RowCount
    '    Dim max As Decimal = (100.0 / fg)
    '    Dim increment As Decimal = max

    '    If clicked = True Then pbRun.Value = 0 And increment = 0
    '    If clicked = True Then clicked = False

    '    If pbRun.Value + increment > 100 Then
    '        pbRun.Value = 100 - increment
    '    End If
    '    pbRun.Value += increment

    'End Sub
    Private Sub host(ByVal i As Integer)
        Dim ip1 As String = txtIP.Text
        Dim ip2 As String = txtIP2.Text
        Dim ipsplit As String() = ip1.Split(".")
        Dim ip2split As String() = ip2.Split(".")

        Try
            fGrid.Rows(i).Cells(2).Value = (System.Net.Dns.GetHostEntry(ipsplit(0) + "." & ipsplit(1) & "." & ipsplit(2) + "." & i.ToString).HostName.ToString & vbCrLf & vbCrLf)
        Catch ex As Exception
        End Try


        ' If chbPort.Checked = False Then progress()

    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If fGrid.Rows IsNot Nothing Then fGrid.Rows.Clear()
        If rtbOut2 IsNot Nothing Then rtbOut2.Clear()
        If rtbOut3 IsNot Nothing Then rtbOut3.Clear()
        pbRun.Value = 0

        FindAddresses()

        If chbPort.Checked = True Then
            portrun()
        Else
            start()
        End If
        btenable()

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click

        Try
            fThread.Abort()
            fThread2.Abort()

            If chbPort.Checked = True Then
                pthread.Abort()

            End If


        Catch ex As ThreadAbortException


        Finally
            If fGrid.Rows IsNot Nothing Then fGrid.Rows.Clear()
            If rtbOut2 IsNot Nothing Then rtbOut2.Clear()
            If rtbOut3 IsNot Nothing Then rtbOut3.Clear()
            pbRun.Value = 0

            btdisable()
        End Try
        stopb = True







    End Sub


    Private Sub btenable()
        stopb = False
        btnStart.Enabled = False
        btnStop.Enabled = True
        cbDns.Enabled = False
        cbFinger.Enabled = False
        cbFtp.Enabled = False
        cbFtps.Enabled = False
        cbHTTP.Enabled = False
        cbHTTPS.Enabled = False
        cbRDP.Enabled = False
        cbSmtp.Enabled = False
        cbSmtps.Enabled = False
        cbSsh.Enabled = False
        cbTelnet.Enabled = False
        cbTelssl.Enabled = False
        chbPort.Enabled = False
        txtIP.Enabled = False
        txtIP2.Enabled = False
        txtPorts.Enabled = False
    End Sub
    Private Sub btdisable()

        stopb = False
        btnStart.Enabled = True
        btnStop.Enabled = False
        cbDns.Enabled = True
        cbFinger.Enabled = True
        cbFtp.Enabled = True
        cbFtps.Enabled = True
        cbHTTP.Enabled = True
        cbHTTPS.Enabled = True
        cbRDP.Enabled = True
        cbSmtp.Enabled = True
        cbSmtps.Enabled = True
        cbSsh.Enabled = True
        cbTelnet.Enabled = True
        cbTelssl.Enabled = True
        chbPort.Enabled = True
        txtIP.Enabled = True
        txtIP2.Enabled = True
        txtPorts.Enabled = True



    End Sub
    Private Sub start()
        Dim ip1 As String = txtIP.Text
        Dim ip2 As String = txtIP2.Text
        Dim ipsplit As String() = ip1.Split(".")
        Dim ip2split As String() = ip2.Split(".")
        Dim path1 As String = ipsplit(0) + ipsplit(1) + ipsplit(2) + ipsplit(3)
        Dim path2 As String = ip2split(0) + ip2split(1) + ip2split(2) + ip2split(3)

        If ipsplit.Length < 4 Or ip2split.Length < 4 Then
            MsgBox("Please enter a valid IP")
        ElseIf letters(path1) = True Or letters(path2) = True Or ipsplit(3) = "" Or ip2split(3) = "" Then
            MsgBox("Please enter a valid IP")
        ElseIf nonstr(path1) = True Or nonstr(path2) = True Then

            MsgBox("Please enter a valid IP")
        ElseIf ipsplit.Length > 4 Or ip2split.Length > 4 Then
            MsgBox("Please enter a valid IP")

        ElseIf CInt(ip2split(3)) < CInt(ipsplit(3)) Then
            MsgBox("Please enter the lower ip first")
        ElseIf CInt(ip2split(2)) <> CInt(ipsplit(2)) Or CInt(ip2split(1)) <> CInt(ipsplit(1)) Or CInt(ip2split(0)) <> CInt(ipsplit(0)) Then
            MsgBox("Please enter a valid range")
        Else

            Fill_IP()
            done = New List(Of Integer)
            success = New List(Of Integer)
            fThread = New Thread(New ThreadStart(AddressOf ThreadProc))
            ' fThread.IsBackground = True
            fThread.Start()
            fThread2 = New Thread(New ThreadStart(AddressOf ThreadProc2))
            'fThread2.IsBackground = True
            fThread2.Start()
            'fThread.Join()
            'fThread2.Join()
            clicked = True

        End If
    End Sub
    Private Sub portrun()

        Dim txtprt As String = txtPorts.Text
            If letters(txtPorts.Text) = True Then
                MsgBox("Please enter a valid port")

            Else
                pthread = New Thread(New ThreadStart(AddressOf popports))
                pthread.IsBackground = True
                pthread.Start()
                'pthread.Join()
                start()
            End If

    End Sub

    Function letters(ByVal ipsplit As String)
        Dim IsAlpha As Boolean = False
        If System.Text.RegularExpressions.Regex.IsMatch(ipsplit, "[a-zA-Z]") Then
            IsAlpha = True
        Else
            IsAlpha = False
        End If
        Return IsAlpha
    End Function
    Function nonstr(ByVal ipsplit As String)
        Dim IsAlpha As Boolean = False
        If System.Text.RegularExpressions.Regex.IsMatch(ipsplit, "[!,@,#,$,%,^,&,*,(,),_,+,~,?,/,;,:,|,\,`,-]") Then
            IsAlpha = True
        Else
            IsAlpha = False
        End If
        Return IsAlpha
    End Function
    Private Sub popports()
        Dim txtprt As String = txtPorts.Text
        Dim portschecked As String
        Dim ports1 As String() = txtprt.Split(",")
        Dim prt As String
        'Dim ports2 As String() = portschecked.Split(",")
        Dim ip1 As String = txtIP.Text
        Dim ip2 As String = txtIP2.Text
        Dim ipsplit As String() = ip1.Split(".")
        Dim ip2split As String() = ip2.Split(".")
        'Dim i As Integer = CInt(ipsplit(3)) - 1
        Dim i As Integer = 0
        Dim ip As String
        If stopb = False Then

            If cbFtp.Checked = True Then portschecked = " 21,"
            If cbFtps.Checked = True Then portschecked = portschecked & " 990,"
            If cbSsh.Checked = True Then portschecked = portschecked & " 22,"
            If cbDns.Checked = True Then portschecked = portschecked & " 53,"
            If cbSmtp.Checked = True Then portschecked = portschecked & " 25,"
            If cbSmtps.Checked = True Then portschecked = portschecked & " 587, 465,"
            If cbTelnet.Checked = True Then portschecked = portschecked & " 23,"
            If cbFinger.Checked = True Then portschecked = portschecked & " 79,"
            If cbHTTP.Checked = True Then portschecked = portschecked & " 80,"
            If cbHTTPS.Checked = True Then portschecked = portschecked & " 443,"
            If cbTelssl.Checked = True Then portschecked = portschecked & " 992,"
            If cbRDP.Checked = True Then portschecked = portschecked & " 3389,"

            Do
                If portschecked = "" Then

                Else

                    Dim ports2 As String() = portschecked.Split(",")


                    For Each prt In ports2
                        If prt = "" Then

                        Else
                            Dim thisPort As Integer
                            thisPort = CInt(Trim(prt))
                            If thisPort > -1 Then

                                ip = fGrid.Rows(i).Cells(0).Value

                                Try
                                    Dim Range As TcpClient = New TcpClient(ip, thisPort)
                                    If Range.Connected = True Then
                                        rtbOut2.AppendText("IP " & ip & " " & thisPort & " is Open")
                                        rtbOut2.AppendText(vbCrLf)
                                    End If
                                Catch ex As Exception
                                    rtbOut3.AppendText("IP " & ip & " " & thisPort & " is Closed")
                                    rtbOut3.AppendText(vbCrLf)
                                End Try

                            End If
                        End If
                    Next
                End If
                If txtPorts.Text = "" Then

                Else
                    For Each prt In ports1
                        Dim thisPort As Integer

                        If prt = "" Or System.Text.RegularExpressions.Regex.IsMatch(prt, "[!,@,#,$,%,^,&,*,(,),_,+,~,?,/,;,:,|,\,`,-]") Then

                        Else

                            thisPort = CInt(Trim(prt))
                            If thisPort > -1 Then
                                ip = fGrid.Rows(i).Cells(0).Value

                                Try
                                    Dim Range As TcpClient = New TcpClient(ip, thisPort)
                                    If Range.Connected = True Then
                                        rtbOut2.AppendText("IP " & ip & " " & thisPort & " is Open" & vbCrLf)
                                        rtbOut2.AppendText(vbCrLf)
                                    End If
                                Catch ex As Exception
                                    rtbOut3.AppendText("IP " & ip & " " & thisPort & " is Closed" & vbCrLf)
                                    rtbOut3.AppendText(vbCrLf)
                                End Try

                            End If
                        End If
                    Next
                End If
                'If chbPort.Checked = True Then progress()
                i += 1

            Loop Until i = CInt(ip2split(3)) - CInt(ipsplit(3)) + 1
        Else
            If rtbOut2 IsNot Nothing Then rtbOut2.Clear()
            If rtbOut3 IsNot Nothing Then rtbOut3.Clear()

        End If
    End Sub


End Class