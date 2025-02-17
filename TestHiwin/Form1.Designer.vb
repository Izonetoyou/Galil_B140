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
        Me.components = New System.ComponentModel.Container()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.bt_A_Jog_reverse = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.bt_A_Jog_forward = New System.Windows.Forms.Button()
        Me.txt_speed_jogA = New System.Windows.Forms.TextBox()
        Me.bt_P1 = New System.Windows.Forms.Button()
        Me.txt_GalilIP = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bt_Disable_A = New System.Windows.Forms.Button()
        Me.Bt_enable_A = New System.Windows.Forms.Button()
        Me.bt_Home_A = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_smoothA = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_DecA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_AccA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_speedA = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bt_Disable_B = New System.Windows.Forms.Button()
        Me.Bt_enable_B = New System.Windows.Forms.Button()
        Me.bt_Home_B = New System.Windows.Forms.Button()
        Me.txt_speed_jogB = New System.Windows.Forms.TextBox()
        Me.bt_B_Jog_forward = New System.Windows.Forms.Button()
        Me.bt_B_Jog_reverse = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_smoothB = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_DecB = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_AccB = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_speedB = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.bt_Disable_C = New System.Windows.Forms.Button()
        Me.Bt_enable_C = New System.Windows.Forms.Button()
        Me.bt_Home_C = New System.Windows.Forms.Button()
        Me.txt_speed_jogC = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.bt_C_Jog_forward = New System.Windows.Forms.Button()
        Me.txt_smoothC = New System.Windows.Forms.TextBox()
        Me.bt_C_Jog_reverse = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_DecC = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_AccC = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_speedC = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Lb_Status_Galil = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Lb_A_position = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Lb_B_position = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Lb_C_position = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cb_position = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txt_B_P1 = New System.Windows.Forms.TextBox()
        Me.txt_C_P1 = New System.Windows.Forms.TextBox()
        Me.txt_C_P2 = New System.Windows.Forms.TextBox()
        Me.txt_B_P2 = New System.Windows.Forms.TextBox()
        Me.bt_P2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(165, 28)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 0
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'bt_A_Jog_reverse
        '
        Me.bt_A_Jog_reverse.Location = New System.Drawing.Point(201, 188)
        Me.bt_A_Jog_reverse.Name = "bt_A_Jog_reverse"
        Me.bt_A_Jog_reverse.Size = New System.Drawing.Size(75, 23)
        Me.bt_A_Jog_reverse.TabIndex = 0
        Me.bt_A_Jog_reverse.Tag = "A"
        Me.bt_A_Jog_reverse.Text = "Jog -"
        Me.bt_A_Jog_reverse.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(715, 18)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(39, 13)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Label1"
        '
        'bt_A_Jog_forward
        '
        Me.bt_A_Jog_forward.Location = New System.Drawing.Point(119, 189)
        Me.bt_A_Jog_forward.Name = "bt_A_Jog_forward"
        Me.bt_A_Jog_forward.Size = New System.Drawing.Size(75, 23)
        Me.bt_A_Jog_forward.TabIndex = 2
        Me.bt_A_Jog_forward.Tag = "A"
        Me.bt_A_Jog_forward.Text = "Jog +"
        Me.bt_A_Jog_forward.UseVisualStyleBackColor = True
        '
        'txt_speed_jogA
        '
        Me.txt_speed_jogA.Location = New System.Drawing.Point(18, 191)
        Me.txt_speed_jogA.Name = "txt_speed_jogA"
        Me.txt_speed_jogA.Size = New System.Drawing.Size(76, 20)
        Me.txt_speed_jogA.TabIndex = 3
        Me.txt_speed_jogA.Text = "10000"
        '
        'bt_P1
        '
        Me.bt_P1.Location = New System.Drawing.Point(704, 65)
        Me.bt_P1.Name = "bt_P1"
        Me.bt_P1.Size = New System.Drawing.Size(75, 23)
        Me.bt_P1.TabIndex = 0
        Me.bt_P1.Text = "P1"
        Me.bt_P1.UseVisualStyleBackColor = True
        '
        'txt_GalilIP
        '
        Me.txt_GalilIP.Location = New System.Drawing.Point(59, 28)
        Me.txt_GalilIP.Name = "txt_GalilIP"
        Me.txt_GalilIP.Size = New System.Drawing.Size(100, 20)
        Me.txt_GalilIP.TabIndex = 4
        Me.txt_GalilIP.Text = "192.168.1.2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bt_Disable_A)
        Me.GroupBox1.Controls.Add(Me.Bt_enable_A)
        Me.GroupBox1.Controls.Add(Me.bt_Home_A)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_smoothA)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_speed_jogA)
        Me.GroupBox1.Controls.Add(Me.txt_DecA)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.bt_A_Jog_forward)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.bt_A_Jog_reverse)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_AccA)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_speedA)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 353)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Servo A"
        '
        'bt_Disable_A
        '
        Me.bt_Disable_A.Location = New System.Drawing.Point(181, 146)
        Me.bt_Disable_A.Name = "bt_Disable_A"
        Me.bt_Disable_A.Size = New System.Drawing.Size(75, 23)
        Me.bt_Disable_A.TabIndex = 25
        Me.bt_Disable_A.Tag = "A"
        Me.bt_Disable_A.Text = "Disable"
        Me.bt_Disable_A.UseVisualStyleBackColor = True
        '
        'Bt_enable_A
        '
        Me.Bt_enable_A.Location = New System.Drawing.Point(100, 146)
        Me.Bt_enable_A.Name = "Bt_enable_A"
        Me.Bt_enable_A.Size = New System.Drawing.Size(75, 23)
        Me.Bt_enable_A.TabIndex = 24
        Me.Bt_enable_A.Tag = "A"
        Me.Bt_enable_A.Text = "Enable"
        Me.Bt_enable_A.UseVisualStyleBackColor = True
        '
        'bt_Home_A
        '
        Me.bt_Home_A.Location = New System.Drawing.Point(19, 146)
        Me.bt_Home_A.Name = "bt_Home_A"
        Me.bt_Home_A.Size = New System.Drawing.Size(75, 23)
        Me.bt_Home_A.TabIndex = 22
        Me.bt_Home_A.Tag = "A"
        Me.bt_Home_A.Text = "Home"
        Me.bt_Home_A.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Smooth facter"
        '
        'txt_smoothA
        '
        Me.txt_smoothA.Location = New System.Drawing.Point(92, 103)
        Me.txt_smoothA.Name = "txt_smoothA"
        Me.txt_smoothA.Size = New System.Drawing.Size(100, 20)
        Me.txt_smoothA.TabIndex = 12
        Me.txt_smoothA.Text = "100"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(198, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "cts/sec²"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Dec"
        '
        'txt_DecA
        '
        Me.txt_DecA.Location = New System.Drawing.Point(92, 77)
        Me.txt_DecA.Name = "txt_DecA"
        Me.txt_DecA.Size = New System.Drawing.Size(100, 20)
        Me.txt_DecA.TabIndex = 9
        Me.txt_DecA.Text = "100000"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(198, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "cts/sec²"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(198, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "cts/sec"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(198, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "cts/sec²"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Acc"
        '
        'txt_AccA
        '
        Me.txt_AccA.Location = New System.Drawing.Point(92, 51)
        Me.txt_AccA.Name = "txt_AccA"
        Me.txt_AccA.Size = New System.Drawing.Size(100, 20)
        Me.txt_AccA.TabIndex = 7
        Me.txt_AccA.Text = "100000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Speed"
        '
        'txt_speedA
        '
        Me.txt_speedA.Location = New System.Drawing.Point(92, 25)
        Me.txt_speedA.Name = "txt_speedA"
        Me.txt_speedA.Size = New System.Drawing.Size(100, 20)
        Me.txt_speedA.TabIndex = 5
        Me.txt_speedA.Text = "50000"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.bt_Disable_B)
        Me.GroupBox2.Controls.Add(Me.Bt_enable_B)
        Me.GroupBox2.Controls.Add(Me.bt_Home_B)
        Me.GroupBox2.Controls.Add(Me.txt_speed_jogB)
        Me.GroupBox2.Controls.Add(Me.bt_B_Jog_forward)
        Me.GroupBox2.Controls.Add(Me.bt_B_Jog_reverse)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_smoothB)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txt_DecB)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txt_AccB)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txt_speedB)
        Me.GroupBox2.Location = New System.Drawing.Point(362, 146)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(291, 353)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Servo B"
        '
        'bt_Disable_B
        '
        Me.bt_Disable_B.Location = New System.Drawing.Point(184, 146)
        Me.bt_Disable_B.Name = "bt_Disable_B"
        Me.bt_Disable_B.Size = New System.Drawing.Size(75, 23)
        Me.bt_Disable_B.TabIndex = 24
        Me.bt_Disable_B.Tag = "B"
        Me.bt_Disable_B.Text = "Disable"
        Me.bt_Disable_B.UseVisualStyleBackColor = True
        '
        'Bt_enable_B
        '
        Me.Bt_enable_B.Location = New System.Drawing.Point(103, 146)
        Me.Bt_enable_B.Name = "Bt_enable_B"
        Me.Bt_enable_B.Size = New System.Drawing.Size(75, 23)
        Me.Bt_enable_B.TabIndex = 23
        Me.Bt_enable_B.Tag = "B"
        Me.Bt_enable_B.Text = "Enable"
        Me.Bt_enable_B.UseVisualStyleBackColor = True
        '
        'bt_Home_B
        '
        Me.bt_Home_B.Location = New System.Drawing.Point(13, 146)
        Me.bt_Home_B.Name = "bt_Home_B"
        Me.bt_Home_B.Size = New System.Drawing.Size(75, 23)
        Me.bt_Home_B.TabIndex = 21
        Me.bt_Home_B.Tag = "B"
        Me.bt_Home_B.Text = "Home"
        Me.bt_Home_B.UseVisualStyleBackColor = True
        '
        'txt_speed_jogB
        '
        Me.txt_speed_jogB.Location = New System.Drawing.Point(18, 191)
        Me.txt_speed_jogB.Name = "txt_speed_jogB"
        Me.txt_speed_jogB.Size = New System.Drawing.Size(76, 20)
        Me.txt_speed_jogB.TabIndex = 16
        Me.txt_speed_jogB.Text = "10000"
        '
        'bt_B_Jog_forward
        '
        Me.bt_B_Jog_forward.Location = New System.Drawing.Point(119, 189)
        Me.bt_B_Jog_forward.Name = "bt_B_Jog_forward"
        Me.bt_B_Jog_forward.Size = New System.Drawing.Size(75, 23)
        Me.bt_B_Jog_forward.TabIndex = 15
        Me.bt_B_Jog_forward.Tag = "B"
        Me.bt_B_Jog_forward.Text = "Jog +"
        Me.bt_B_Jog_forward.UseVisualStyleBackColor = True
        '
        'bt_B_Jog_reverse
        '
        Me.bt_B_Jog_reverse.Location = New System.Drawing.Point(201, 188)
        Me.bt_B_Jog_reverse.Name = "bt_B_Jog_reverse"
        Me.bt_B_Jog_reverse.Size = New System.Drawing.Size(75, 23)
        Me.bt_B_Jog_reverse.TabIndex = 14
        Me.bt_B_Jog_reverse.Tag = "B"
        Me.bt_B_Jog_reverse.Text = "Jog -"
        Me.bt_B_Jog_reverse.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Smooth facter"
        '
        'txt_smoothB
        '
        Me.txt_smoothB.Location = New System.Drawing.Point(92, 103)
        Me.txt_smoothB.Name = "txt_smoothB"
        Me.txt_smoothB.Size = New System.Drawing.Size(100, 20)
        Me.txt_smoothB.TabIndex = 12
        Me.txt_smoothB.Text = "100"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(198, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "cts/sec²"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Dec"
        '
        'txt_DecB
        '
        Me.txt_DecB.Location = New System.Drawing.Point(92, 77)
        Me.txt_DecB.Name = "txt_DecB"
        Me.txt_DecB.Size = New System.Drawing.Size(100, 20)
        Me.txt_DecB.TabIndex = 9
        Me.txt_DecB.Text = "100000"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(198, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "cts/sec²"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(198, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "cts/sec"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(198, 54)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "cts/sec²"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Acc"
        '
        'txt_AccB
        '
        Me.txt_AccB.Location = New System.Drawing.Point(92, 51)
        Me.txt_AccB.Name = "txt_AccB"
        Me.txt_AccB.Size = New System.Drawing.Size(100, 20)
        Me.txt_AccB.TabIndex = 7
        Me.txt_AccB.Text = "100000"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Speed"
        '
        'txt_speedB
        '
        Me.txt_speedB.Location = New System.Drawing.Point(92, 25)
        Me.txt_speedB.Name = "txt_speedB"
        Me.txt_speedB.Size = New System.Drawing.Size(100, 20)
        Me.txt_speedB.TabIndex = 5
        Me.txt_speedB.Text = "50000"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.bt_Disable_C)
        Me.GroupBox3.Controls.Add(Me.Bt_enable_C)
        Me.GroupBox3.Controls.Add(Me.bt_Home_C)
        Me.GroupBox3.Controls.Add(Me.txt_speed_jogC)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.bt_C_Jog_forward)
        Me.GroupBox3.Controls.Add(Me.txt_smoothC)
        Me.GroupBox3.Controls.Add(Me.bt_C_Jog_reverse)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txt_DecC)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.txt_AccC)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.txt_speedC)
        Me.GroupBox3.Location = New System.Drawing.Point(677, 146)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(291, 353)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Servo C"
        '
        'bt_Disable_C
        '
        Me.bt_Disable_C.Location = New System.Drawing.Point(181, 146)
        Me.bt_Disable_C.Name = "bt_Disable_C"
        Me.bt_Disable_C.Size = New System.Drawing.Size(75, 23)
        Me.bt_Disable_C.TabIndex = 22
        Me.bt_Disable_C.Tag = "C"
        Me.bt_Disable_C.Text = "Disable"
        Me.bt_Disable_C.UseVisualStyleBackColor = True
        '
        'Bt_enable_C
        '
        Me.Bt_enable_C.Location = New System.Drawing.Point(99, 146)
        Me.Bt_enable_C.Name = "Bt_enable_C"
        Me.Bt_enable_C.Size = New System.Drawing.Size(75, 23)
        Me.Bt_enable_C.TabIndex = 22
        Me.Bt_enable_C.Tag = "C"
        Me.Bt_enable_C.Text = "Enable"
        Me.Bt_enable_C.UseVisualStyleBackColor = True
        '
        'bt_Home_C
        '
        Me.bt_Home_C.Location = New System.Drawing.Point(18, 146)
        Me.bt_Home_C.Name = "bt_Home_C"
        Me.bt_Home_C.Size = New System.Drawing.Size(75, 23)
        Me.bt_Home_C.TabIndex = 20
        Me.bt_Home_C.Tag = "C"
        Me.bt_Home_C.Text = "Home"
        Me.bt_Home_C.UseVisualStyleBackColor = True
        '
        'txt_speed_jogC
        '
        Me.txt_speed_jogC.Location = New System.Drawing.Point(27, 191)
        Me.txt_speed_jogC.Name = "txt_speed_jogC"
        Me.txt_speed_jogC.Size = New System.Drawing.Size(76, 20)
        Me.txt_speed_jogC.TabIndex = 19
        Me.txt_speed_jogC.Text = "10000"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(15, 106)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 13)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Smooth facter"
        '
        'bt_C_Jog_forward
        '
        Me.bt_C_Jog_forward.Location = New System.Drawing.Point(128, 189)
        Me.bt_C_Jog_forward.Name = "bt_C_Jog_forward"
        Me.bt_C_Jog_forward.Size = New System.Drawing.Size(75, 23)
        Me.bt_C_Jog_forward.TabIndex = 18
        Me.bt_C_Jog_forward.Tag = "C"
        Me.bt_C_Jog_forward.Text = "Jog +"
        Me.bt_C_Jog_forward.UseVisualStyleBackColor = True
        '
        'txt_smoothC
        '
        Me.txt_smoothC.Location = New System.Drawing.Point(92, 103)
        Me.txt_smoothC.Name = "txt_smoothC"
        Me.txt_smoothC.Size = New System.Drawing.Size(100, 20)
        Me.txt_smoothC.TabIndex = 12
        Me.txt_smoothC.Text = "100"
        '
        'bt_C_Jog_reverse
        '
        Me.bt_C_Jog_reverse.Location = New System.Drawing.Point(210, 188)
        Me.bt_C_Jog_reverse.Name = "bt_C_Jog_reverse"
        Me.bt_C_Jog_reverse.Size = New System.Drawing.Size(75, 23)
        Me.bt_C_Jog_reverse.TabIndex = 17
        Me.bt_C_Jog_reverse.Tag = "C"
        Me.bt_C_Jog_reverse.Text = "Jog -"
        Me.bt_C_Jog_reverse.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(198, 106)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 13)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "cts/sec²"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(15, 80)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(27, 13)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "Dec"
        '
        'txt_DecC
        '
        Me.txt_DecC.Location = New System.Drawing.Point(92, 77)
        Me.txt_DecC.Name = "txt_DecC"
        Me.txt_DecC.Size = New System.Drawing.Size(100, 20)
        Me.txt_DecC.TabIndex = 9
        Me.txt_DecC.Text = "100000"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(198, 80)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(46, 13)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "cts/sec²"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(198, 28)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 13)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "cts/sec"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(198, 54)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(46, 13)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "cts/sec²"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(15, 54)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(26, 13)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "Acc"
        '
        'txt_AccC
        '
        Me.txt_AccC.Location = New System.Drawing.Point(92, 51)
        Me.txt_AccC.Name = "txt_AccC"
        Me.txt_AccC.Size = New System.Drawing.Size(100, 20)
        Me.txt_AccC.TabIndex = 7
        Me.txt_AccC.Text = "100000"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(15, 28)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(38, 13)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "Speed"
        '
        'txt_speedC
        '
        Me.txt_speedC.Location = New System.Drawing.Point(92, 25)
        Me.txt_speedC.Name = "txt_speedC"
        Me.txt_speedC.Size = New System.Drawing.Size(100, 20)
        Me.txt_speedC.TabIndex = 5
        Me.txt_speedC.Text = "50000"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(15, 31)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(40, 13)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "Galil IP"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Lb_Status_Galil, Me.Lb_A_position, Me.Lb_B_position, Me.Lb_C_position})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 509)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(999, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Lb_Status_Galil
        '
        Me.Lb_Status_Galil.Name = "Lb_Status_Galil"
        Me.Lb_Status_Galil.Size = New System.Drawing.Size(39, 17)
        Me.Lb_Status_Galil.Text = "Status"
        '
        'Lb_A_position
        '
        Me.Lb_A_position.Name = "Lb_A_position"
        Me.Lb_A_position.Size = New System.Drawing.Size(32, 17)
        Me.Lb_A_position.Text = "A= 0"
        '
        'Lb_B_position
        '
        Me.Lb_B_position.Name = "Lb_B_position"
        Me.Lb_B_position.Size = New System.Drawing.Size(31, 17)
        Me.Lb_B_position.Text = "B= 0"
        '
        'Lb_C_position
        '
        Me.Lb_C_position.Name = "Lb_C_position"
        Me.Lb_C_position.Size = New System.Drawing.Size(35, 17)
        Me.Lb_C_position.Text = "C = 0"
        '
        'cb_position
        '
        Me.cb_position.AutoSize = True
        Me.cb_position.Location = New System.Drawing.Point(870, 23)
        Me.cb_position.Name = "cb_position"
        Me.cb_position.Size = New System.Drawing.Size(63, 17)
        Me.cb_position.TabIndex = 10
        Me.cb_position.Text = "Position"
        Me.cb_position.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'txt_B_P1
        '
        Me.txt_B_P1.Location = New System.Drawing.Point(465, 68)
        Me.txt_B_P1.Name = "txt_B_P1"
        Me.txt_B_P1.Size = New System.Drawing.Size(100, 20)
        Me.txt_B_P1.TabIndex = 11
        Me.txt_B_P1.Text = "-1000"
        '
        'txt_C_P1
        '
        Me.txt_C_P1.Location = New System.Drawing.Point(589, 68)
        Me.txt_C_P1.Name = "txt_C_P1"
        Me.txt_C_P1.Size = New System.Drawing.Size(100, 20)
        Me.txt_C_P1.TabIndex = 12
        Me.txt_C_P1.Text = "1000"
        '
        'txt_C_P2
        '
        Me.txt_C_P2.Location = New System.Drawing.Point(590, 97)
        Me.txt_C_P2.Name = "txt_C_P2"
        Me.txt_C_P2.Size = New System.Drawing.Size(100, 20)
        Me.txt_C_P2.TabIndex = 15
        Me.txt_C_P2.Text = "2500"
        '
        'txt_B_P2
        '
        Me.txt_B_P2.Location = New System.Drawing.Point(466, 97)
        Me.txt_B_P2.Name = "txt_B_P2"
        Me.txt_B_P2.Size = New System.Drawing.Size(100, 20)
        Me.txt_B_P2.TabIndex = 14
        Me.txt_B_P2.Text = "-2500"
        '
        'bt_P2
        '
        Me.bt_P2.Location = New System.Drawing.Point(705, 94)
        Me.bt_P2.Name = "bt_P2"
        Me.bt_P2.Size = New System.Drawing.Size(75, 23)
        Me.bt_P2.TabIndex = 13
        Me.bt_P2.Text = "P2"
        Me.bt_P2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 531)
        Me.Controls.Add(Me.txt_C_P2)
        Me.Controls.Add(Me.txt_B_P2)
        Me.Controls.Add(Me.bt_P2)
        Me.Controls.Add(Me.txt_C_P1)
        Me.Controls.Add(Me.txt_B_P1)
        Me.Controls.Add(Me.cb_position)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_GalilIP)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.bt_P1)
        Me.Controls.Add(Me.btnConnect)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConnect As Button
    Friend WithEvents bt_A_Jog_reverse As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents bt_A_Jog_forward As Button
    Friend WithEvents txt_speed_jogA As TextBox
    Friend WithEvents bt_P1 As Button
    Friend WithEvents txt_GalilIP As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_speedA As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_DecA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_AccA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_smoothA As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_smoothB As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_DecB As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_AccB As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_speedB As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_smoothC As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_DecC As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txt_AccC As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txt_speedC As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Lb_Status_Galil As ToolStripStatusLabel
    Friend WithEvents txt_speed_jogB As TextBox
    Friend WithEvents bt_B_Jog_forward As Button
    Friend WithEvents bt_B_Jog_reverse As Button
    Friend WithEvents txt_speed_jogC As TextBox
    Friend WithEvents bt_C_Jog_forward As Button
    Friend WithEvents bt_C_Jog_reverse As Button
    Friend WithEvents bt_Home_C As Button
    Friend WithEvents bt_Home_B As Button
    Friend WithEvents bt_Home_A As Button
    Friend WithEvents Lb_A_position As ToolStripStatusLabel
    Friend WithEvents Lb_B_position As ToolStripStatusLabel
    Friend WithEvents Lb_C_position As ToolStripStatusLabel
    Friend WithEvents cb_position As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents bt_Disable_C As Button
    Friend WithEvents Bt_enable_C As Button
    Friend WithEvents Bt_enable_A As Button
    Friend WithEvents Bt_enable_B As Button
    Friend WithEvents bt_Disable_A As Button
    Friend WithEvents bt_Disable_B As Button
    Friend WithEvents txt_B_P1 As TextBox
    Friend WithEvents txt_C_P1 As TextBox
    Friend WithEvents txt_C_P2 As TextBox
    Friend WithEvents txt_B_P2 As TextBox
    Friend WithEvents bt_P2 As Button
End Class
