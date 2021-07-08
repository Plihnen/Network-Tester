<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.txtIP2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chbPort = New System.Windows.Forms.CheckBox()
        Me.txtPorts = New System.Windows.Forms.TextBox()
        Me.pbRun = New System.Windows.Forms.ProgressBar()
        Me.fGrid = New System.Windows.Forms.DataGridView()
        Me.rtbOut2 = New System.Windows.Forms.RichTextBox()
        Me.rtbOut3 = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbFtp = New System.Windows.Forms.CheckBox()
        Me.cbSmtp = New System.Windows.Forms.CheckBox()
        Me.cbSmtps = New System.Windows.Forms.CheckBox()
        Me.cbFtps = New System.Windows.Forms.CheckBox()
        Me.cbSsh = New System.Windows.Forms.CheckBox()
        Me.cbTelnet = New System.Windows.Forms.CheckBox()
        Me.cbDns = New System.Windows.Forms.CheckBox()
        Me.cbFinger = New System.Windows.Forms.CheckBox()
        Me.cbHTTP = New System.Windows.Forms.CheckBox()
        Me.cbHTTPS = New System.Windows.Forms.CheckBox()
        Me.cbTelssl = New System.Windows.Forms.CheckBox()
        Me.cbRDP = New System.Windows.Forms.CheckBox()
        CType(Me.fGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(471, 118)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 6
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(471, 58)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "IP address range"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Ports Please seperate with ,"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(144, 60)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(111, 20)
        Me.txtIP.TabIndex = 1
        '
        'txtIP2
        '
        Me.txtIP2.Location = New System.Drawing.Point(287, 60)
        Me.txtIP2.Name = "txtIP2"
        Me.txtIP2.Size = New System.Drawing.Size(117, 20)
        Me.txtIP2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "To"
        '
        'chbPort
        '
        Me.chbPort.AutoSize = True
        Me.chbPort.Location = New System.Drawing.Point(201, 157)
        Me.chbPort.Name = "chbPort"
        Me.chbPort.Size = New System.Drawing.Size(115, 17)
        Me.chbPort.TabIndex = 4
        Me.chbPort.Text = "Port Scan Enabled"
        Me.chbPort.UseVisualStyleBackColor = True
        '
        'txtPorts
        '
        Me.txtPorts.Location = New System.Drawing.Point(45, 154)
        Me.txtPorts.Name = "txtPorts"
        Me.txtPorts.Size = New System.Drawing.Size(150, 20)
        Me.txtPorts.TabIndex = 3
        '
        'pbRun
        '
        Me.pbRun.Location = New System.Drawing.Point(22, 592)
        Me.pbRun.Name = "pbRun"
        Me.pbRun.Size = New System.Drawing.Size(524, 23)
        Me.pbRun.TabIndex = 18
        '
        'fGrid
        '
        Me.fGrid.AllowUserToAddRows = False
        Me.fGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.fGrid.Location = New System.Drawing.Point(22, 364)
        Me.fGrid.Name = "fGrid"
        Me.fGrid.ReadOnly = True
        Me.fGrid.Size = New System.Drawing.Size(524, 222)
        Me.fGrid.TabIndex = 20
        '
        'rtbOut2
        '
        Me.rtbOut2.HideSelection = False
        Me.rtbOut2.Location = New System.Drawing.Point(569, 334)
        Me.rtbOut2.Name = "rtbOut2"
        Me.rtbOut2.ReadOnly = True
        Me.rtbOut2.Size = New System.Drawing.Size(181, 281)
        Me.rtbOut2.TabIndex = 21
        Me.rtbOut2.Text = ""
        '
        'rtbOut3
        '
        Me.rtbOut3.HideSelection = False
        Me.rtbOut3.Location = New System.Drawing.Point(779, 334)
        Me.rtbOut3.Name = "rtbOut3"
        Me.rtbOut3.ReadOnly = True
        Me.rtbOut3.Size = New System.Drawing.Size(183, 281)
        Me.rtbOut3.TabIndex = 22
        Me.rtbOut3.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(618, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Open Ports"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(832, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Closed Ports"
        '
        'cbFtp
        '
        Me.cbFtp.AutoSize = True
        Me.cbFtp.Location = New System.Drawing.Point(45, 195)
        Me.cbFtp.Name = "cbFtp"
        Me.cbFtp.Size = New System.Drawing.Size(85, 17)
        Me.cbFtp.TabIndex = 25
        Me.cbFtp.Text = "21: FTP port"
        Me.cbFtp.UseVisualStyleBackColor = True
        '
        'cbSmtp
        '
        Me.cbSmtp.AutoSize = True
        Me.cbSmtp.Location = New System.Drawing.Point(144, 195)
        Me.cbSmtp.Name = "cbSmtp"
        Me.cbSmtp.Size = New System.Drawing.Size(95, 17)
        Me.cbSmtp.TabIndex = 26
        Me.cbSmtp.Text = "25: SMTP port"
        Me.cbSmtp.UseVisualStyleBackColor = True
        '
        'cbSmtps
        '
        Me.cbSmtps.AutoSize = True
        Me.cbSmtps.Location = New System.Drawing.Point(144, 218)
        Me.cbSmtps.Name = "cbSmtps"
        Me.cbSmtps.Size = New System.Drawing.Size(129, 17)
        Me.cbSmtps.TabIndex = 27
        Me.cbSmtps.Text = "587,465 :SMTPS port"
        Me.cbSmtps.UseVisualStyleBackColor = True
        '
        'cbFtps
        '
        Me.cbFtps.AutoSize = True
        Me.cbFtps.Location = New System.Drawing.Point(45, 218)
        Me.cbFtps.Name = "cbFtps"
        Me.cbFtps.Size = New System.Drawing.Size(98, 17)
        Me.cbFtps.TabIndex = 28
        Me.cbFtps.Text = "990: FTPS port"
        Me.cbFtps.UseVisualStyleBackColor = True
        '
        'cbSsh
        '
        Me.cbSsh.AutoSize = True
        Me.cbSsh.Location = New System.Drawing.Point(45, 241)
        Me.cbSsh.Name = "cbSsh"
        Me.cbSsh.Size = New System.Drawing.Size(87, 17)
        Me.cbSsh.TabIndex = 29
        Me.cbSsh.Text = "22: SSH port"
        Me.cbSsh.UseVisualStyleBackColor = True
        '
        'cbTelnet
        '
        Me.cbTelnet.AutoSize = True
        Me.cbTelnet.Location = New System.Drawing.Point(144, 241)
        Me.cbTelnet.Name = "cbTelnet"
        Me.cbTelnet.Size = New System.Drawing.Size(95, 17)
        Me.cbTelnet.TabIndex = 30
        Me.cbTelnet.Text = "23: Telnet port"
        Me.cbTelnet.UseVisualStyleBackColor = True
        '
        'cbDns
        '
        Me.cbDns.AutoSize = True
        Me.cbDns.Location = New System.Drawing.Point(45, 264)
        Me.cbDns.Name = "cbDns"
        Me.cbDns.Size = New System.Drawing.Size(88, 17)
        Me.cbDns.TabIndex = 31
        Me.cbDns.Text = "53: DNS port"
        Me.cbDns.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cbDns.UseVisualStyleBackColor = True
        '
        'cbFinger
        '
        Me.cbFinger.AutoSize = True
        Me.cbFinger.Location = New System.Drawing.Point(144, 264)
        Me.cbFinger.Name = "cbFinger"
        Me.cbFinger.Size = New System.Drawing.Size(94, 17)
        Me.cbFinger.TabIndex = 32
        Me.cbFinger.Text = "79: Finger port"
        Me.cbFinger.UseVisualStyleBackColor = True
        '
        'cbHTTP
        '
        Me.cbHTTP.AutoSize = True
        Me.cbHTTP.Location = New System.Drawing.Point(279, 195)
        Me.cbHTTP.Name = "cbHTTP"
        Me.cbHTTP.Size = New System.Drawing.Size(94, 17)
        Me.cbHTTP.TabIndex = 33
        Me.cbHTTP.Text = "80: HTTP port"
        Me.cbHTTP.UseVisualStyleBackColor = True
        '
        'cbHTTPS
        '
        Me.cbHTTPS.AutoSize = True
        Me.cbHTTPS.Location = New System.Drawing.Point(279, 218)
        Me.cbHTTPS.Name = "cbHTTPS"
        Me.cbHTTPS.Size = New System.Drawing.Size(107, 17)
        Me.cbHTTPS.TabIndex = 34
        Me.cbHTTPS.Text = "443: HTTPS port"
        Me.cbHTTPS.UseVisualStyleBackColor = True
        '
        'cbTelssl
        '
        Me.cbTelssl.AutoSize = True
        Me.cbTelssl.Location = New System.Drawing.Point(279, 241)
        Me.cbTelssl.Name = "cbTelssl"
        Me.cbTelssl.Size = New System.Drawing.Size(127, 17)
        Me.cbTelssl.TabIndex = 35
        Me.cbTelssl.Text = "992: Telnet (ssl) ports"
        Me.cbTelssl.UseVisualStyleBackColor = True
        '
        'cbRDP
        '
        Me.cbRDP.AutoSize = True
        Me.cbRDP.Location = New System.Drawing.Point(279, 264)
        Me.cbRDP.Name = "cbRDP"
        Me.cbRDP.Size = New System.Drawing.Size(208, 17)
        Me.cbRDP.TabIndex = 36
        Me.cbRDP.Text = "3389: Microsoft Terminal Server (RDP)"
        Me.cbRDP.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 627)
        Me.Controls.Add(Me.cbRDP)
        Me.Controls.Add(Me.cbTelssl)
        Me.Controls.Add(Me.cbHTTPS)
        Me.Controls.Add(Me.cbHTTP)
        Me.Controls.Add(Me.cbFinger)
        Me.Controls.Add(Me.cbDns)
        Me.Controls.Add(Me.cbTelnet)
        Me.Controls.Add(Me.cbSsh)
        Me.Controls.Add(Me.cbFtps)
        Me.Controls.Add(Me.cbSmtps)
        Me.Controls.Add(Me.cbSmtp)
        Me.Controls.Add(Me.cbFtp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rtbOut3)
        Me.Controls.Add(Me.rtbOut2)
        Me.Controls.Add(Me.fGrid)
        Me.Controls.Add(Me.pbRun)
        Me.Controls.Add(Me.txtPorts)
        Me.Controls.Add(Me.chbPort)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIP2)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIP)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.fGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStop As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIP As TextBox
    Friend WithEvents txtIP2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chbPort As CheckBox
    Friend WithEvents txtPorts As TextBox
    Friend WithEvents pbRun As ProgressBar
    Friend WithEvents fGrid As DataGridView
    Friend WithEvents rtbOut2 As RichTextBox
    Friend WithEvents rtbOut3 As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbFtp As CheckBox
    Friend WithEvents cbSmtp As CheckBox
    Friend WithEvents cbSmtps As CheckBox
    Friend WithEvents cbFtps As CheckBox
    Friend WithEvents cbSsh As CheckBox
    Friend WithEvents cbTelnet As CheckBox
    Friend WithEvents cbDns As CheckBox
    Friend WithEvents cbFinger As CheckBox
    Friend WithEvents cbHTTP As CheckBox
    Friend WithEvents cbHTTPS As CheckBox
    Friend WithEvents cbTelssl As CheckBox
    Friend WithEvents cbRDP As CheckBox

End Class
