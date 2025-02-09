<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUsers
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
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.txtfirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblLastNameValidation = New System.Windows.Forms.Label()
        Me.lblCourseValidation = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.flpMain = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtusername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblLRNValidation = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblStudentIDValidation = New System.Windows.Forms.Label()
        Me.lblFirstNameValidation = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cborole = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtlastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblYearLevelValidation = New System.Windows.Forms.Label()
        Me.lblSectionValidation = New System.Windows.Forms.Label()
        Me.ErrorCourse = New System.Windows.Forms.Label()
        Me.cboStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboAccesslevel = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnsave = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonDiscard = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.flpMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(13, 14)
        Me.Guna2HtmlLabel4.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(89, 27)
        Me.Guna2HtmlLabel4.TabIndex = 13
        Me.Guna2HtmlLabel4.Text = "Firstname:"
        '
        'LabelInfo
        '
        Me.LabelInfo.AutoSize = True
        Me.LabelInfo.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInfo.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelInfo.Location = New System.Drawing.Point(8, 421)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(0, 28)
        Me.LabelInfo.TabIndex = 36
        '
        'txtfirstname
        '
        Me.txtfirstname.BorderRadius = 5
        Me.txtfirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfirstname.DefaultText = ""
        Me.txtfirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtfirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtfirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfirstname.DisabledState.Parent = Me.txtfirstname
        Me.txtfirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfirstname.FocusedState.Parent = Me.txtfirstname
        Me.txtfirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfirstname.HoverState.Parent = Me.txtfirstname
        Me.txtfirstname.Location = New System.Drawing.Point(13, 44)
        Me.txtfirstname.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfirstname.PlaceholderText = ""
        Me.txtfirstname.SelectedText = ""
        Me.txtfirstname.ShadowDecoration.Parent = Me.txtfirstname
        Me.txtfirstname.Size = New System.Drawing.Size(370, 32)
        Me.txtfirstname.TabIndex = 18
        '
        'lblLastNameValidation
        '
        Me.lblLastNameValidation.AutoSize = True
        Me.lblLastNameValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastNameValidation.ForeColor = System.Drawing.Color.Red
        Me.lblLastNameValidation.Location = New System.Drawing.Point(32, 84)
        Me.lblLastNameValidation.Name = "lblLastNameValidation"
        Me.lblLastNameValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblLastNameValidation.TabIndex = 34
        '
        'lblCourseValidation
        '
        Me.lblCourseValidation.AutoSize = True
        Me.lblCourseValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseValidation.ForeColor = System.Drawing.Color.Red
        Me.lblCourseValidation.Location = New System.Drawing.Point(27, 186)
        Me.lblCourseValidation.Name = "lblCourseValidation"
        Me.lblCourseValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblCourseValidation.TabIndex = 34
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(13, 110)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(87, 27)
        Me.Guna2HtmlLabel6.TabIndex = 21
        Me.Guna2HtmlLabel6.Text = "Lastname:"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(10, 317)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(132, 27)
        Me.Guna2HtmlLabel5.TabIndex = 20
        Me.Guna2HtmlLabel5.Text = "Account Status:"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(13, 212)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(111, 27)
        Me.Guna2HtmlLabel7.TabIndex = 20
        Me.Guna2HtmlLabel7.Text = "Access Level:"
        '
        'flpMain
        '
        Me.flpMain.AutoScroll = True
        Me.flpMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.flpMain.Controls.Add(Me.Panel1)
        Me.flpMain.Controls.Add(Me.Panel3)
        Me.flpMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpMain.Location = New System.Drawing.Point(12, 92)
        Me.flpMain.Name = "flpMain"
        Me.flpMain.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.flpMain.Size = New System.Drawing.Size(443, 418)
        Me.flpMain.TabIndex = 56
        Me.flpMain.WrapContents = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel1.Controls.Add(Me.txtusername)
        Me.Panel1.Controls.Add(Me.lblLRNValidation)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Panel1.Controls.Add(Me.txtpassword)
        Me.Panel1.Controls.Add(Me.lblStudentIDValidation)
        Me.Panel1.Controls.Add(Me.lblFirstNameValidation)
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Panel1.Controls.Add(Me.cborole)
        Me.Panel1.Location = New System.Drawing.Point(13, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(403, 306)
        Me.Panel1.TabIndex = 0
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(13, 3)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(92, 27)
        Me.Guna2HtmlLabel1.TabIndex = 15
        Me.Guna2HtmlLabel1.Text = "Username:"
        '
        'txtusername
        '
        Me.txtusername.BorderRadius = 5
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusername.DefaultText = ""
        Me.txtusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtusername.DisabledState.Parent = Me.txtusername
        Me.txtusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtusername.FocusedState.Parent = Me.txtusername
        Me.txtusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtusername.HoverState.Parent = Me.txtusername
        Me.txtusername.Location = New System.Drawing.Point(13, 38)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.PlaceholderText = ""
        Me.txtusername.SelectedText = ""
        Me.txtusername.ShadowDecoration.Parent = Me.txtusername
        Me.txtusername.Size = New System.Drawing.Size(370, 33)
        Me.txtusername.TabIndex = 16
        '
        'lblLRNValidation
        '
        Me.lblLRNValidation.AutoSize = True
        Me.lblLRNValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLRNValidation.ForeColor = System.Drawing.Color.Red
        Me.lblLRNValidation.Location = New System.Drawing.Point(32, 79)
        Me.lblLRNValidation.Name = "lblLRNValidation"
        Me.lblLRNValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblLRNValidation.TabIndex = 35
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(13, 104)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(87, 27)
        Me.Guna2HtmlLabel2.TabIndex = 15
        Me.Guna2HtmlLabel2.Text = "Password:"
        '
        'txtpassword
        '
        Me.txtpassword.BorderRadius = 5
        Me.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpassword.DefaultText = ""
        Me.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassword.DisabledState.Parent = Me.txtpassword
        Me.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpassword.FocusedState.Parent = Me.txtpassword
        Me.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpassword.HoverState.Parent = Me.txtpassword
        Me.txtpassword.Location = New System.Drawing.Point(13, 134)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpassword.PlaceholderText = ""
        Me.txtpassword.SelectedText = ""
        Me.txtpassword.ShadowDecoration.Parent = Me.txtpassword
        Me.txtpassword.Size = New System.Drawing.Size(370, 33)
        Me.txtpassword.TabIndex = 16
        '
        'lblStudentIDValidation
        '
        Me.lblStudentIDValidation.AutoSize = True
        Me.lblStudentIDValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentIDValidation.ForeColor = System.Drawing.Color.Red
        Me.lblStudentIDValidation.Location = New System.Drawing.Point(32, 175)
        Me.lblStudentIDValidation.Name = "lblStudentIDValidation"
        Me.lblStudentIDValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblStudentIDValidation.TabIndex = 34
        '
        'lblFirstNameValidation
        '
        Me.lblFirstNameValidation.AutoSize = True
        Me.lblFirstNameValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstNameValidation.ForeColor = System.Drawing.Color.Red
        Me.lblFirstNameValidation.Location = New System.Drawing.Point(32, 271)
        Me.lblFirstNameValidation.Name = "lblFirstNameValidation"
        Me.lblFirstNameValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblFirstNameValidation.TabIndex = 34
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(13, 201)
        Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(44, 27)
        Me.Guna2HtmlLabel3.TabIndex = 14
        Me.Guna2HtmlLabel3.Text = "Role:"
        '
        'cborole
        '
        Me.cborole.BackColor = System.Drawing.Color.Transparent
        Me.cborole.BorderRadius = 5
        Me.cborole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cborole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cborole.FocusedColor = System.Drawing.Color.Empty
        Me.cborole.FocusedState.Parent = Me.cborole
        Me.cborole.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cborole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cborole.FormattingEnabled = True
        Me.cborole.HoverState.Parent = Me.cborole
        Me.cborole.ItemHeight = 30
        Me.cborole.Items.AddRange(New Object() {"IT", "Cashier", "Manager"})
        Me.cborole.ItemsAppearance.Parent = Me.cborole
        Me.cborole.Location = New System.Drawing.Point(13, 232)
        Me.cborole.Name = "cborole"
        Me.cborole.ShadowDecoration.Parent = Me.cborole
        Me.cborole.Size = New System.Drawing.Size(370, 36)
        Me.cborole.TabIndex = 24
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Panel3.Controls.Add(Me.LabelInfo)
        Me.Panel3.Controls.Add(Me.txtlastname)
        Me.Panel3.Controls.Add(Me.txtfirstname)
        Me.Panel3.Controls.Add(Me.lblYearLevelValidation)
        Me.Panel3.Controls.Add(Me.lblSectionValidation)
        Me.Panel3.Controls.Add(Me.lblLastNameValidation)
        Me.Panel3.Controls.Add(Me.lblCourseValidation)
        Me.Panel3.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Panel3.Controls.Add(Me.ErrorCourse)
        Me.Panel3.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Panel3.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Panel3.Controls.Add(Me.cboStatus)
        Me.Panel3.Controls.Add(Me.cboAccesslevel)
        Me.Panel3.Location = New System.Drawing.Point(13, 320)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(403, 429)
        Me.Panel3.TabIndex = 1
        '
        'txtlastname
        '
        Me.txtlastname.BorderRadius = 5
        Me.txtlastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtlastname.DefaultText = ""
        Me.txtlastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtlastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtlastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtlastname.DisabledState.Parent = Me.txtlastname
        Me.txtlastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtlastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtlastname.FocusedState.Parent = Me.txtlastname
        Me.txtlastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtlastname.HoverState.Parent = Me.txtlastname
        Me.txtlastname.Location = New System.Drawing.Point(13, 149)
        Me.txtlastname.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlastname.PlaceholderText = ""
        Me.txtlastname.SelectedText = ""
        Me.txtlastname.ShadowDecoration.Parent = Me.txtlastname
        Me.txtlastname.Size = New System.Drawing.Size(370, 32)
        Me.txtlastname.TabIndex = 18
        '
        'lblYearLevelValidation
        '
        Me.lblYearLevelValidation.AutoSize = True
        Me.lblYearLevelValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearLevelValidation.ForeColor = System.Drawing.Color.Red
        Me.lblYearLevelValidation.Location = New System.Drawing.Point(27, 386)
        Me.lblYearLevelValidation.Name = "lblYearLevelValidation"
        Me.lblYearLevelValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblYearLevelValidation.TabIndex = 34
        '
        'lblSectionValidation
        '
        Me.lblSectionValidation.AutoSize = True
        Me.lblSectionValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectionValidation.ForeColor = System.Drawing.Color.Red
        Me.lblSectionValidation.Location = New System.Drawing.Point(27, 291)
        Me.lblSectionValidation.Name = "lblSectionValidation"
        Me.lblSectionValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblSectionValidation.TabIndex = 34
        '
        'ErrorCourse
        '
        Me.ErrorCourse.AutoSize = True
        Me.ErrorCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.ErrorCourse.ForeColor = System.Drawing.Color.Red
        Me.ErrorCourse.Location = New System.Drawing.Point(28, 168)
        Me.ErrorCourse.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.ErrorCourse.Name = "ErrorCourse"
        Me.ErrorCourse.Size = New System.Drawing.Size(0, 13)
        Me.ErrorCourse.TabIndex = 22
        '
        'cboStatus
        '
        Me.cboStatus.BackColor = System.Drawing.Color.Transparent
        Me.cboStatus.BorderRadius = 5
        Me.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FocusedColor = System.Drawing.Color.Empty
        Me.cboStatus.FocusedState.Parent = Me.cboStatus
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.HoverState.Parent = Me.cboStatus
        Me.cboStatus.ItemHeight = 30
        Me.cboStatus.Items.AddRange(New Object() {"Active", "Inactive", "Disabled"})
        Me.cboStatus.ItemsAppearance.Parent = Me.cboStatus
        Me.cboStatus.Location = New System.Drawing.Point(10, 350)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.ShadowDecoration.Parent = Me.cboStatus
        Me.cboStatus.Size = New System.Drawing.Size(370, 36)
        Me.cboStatus.TabIndex = 25
        '
        'cboAccesslevel
        '
        Me.cboAccesslevel.BackColor = System.Drawing.Color.Transparent
        Me.cboAccesslevel.BorderRadius = 5
        Me.cboAccesslevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAccesslevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccesslevel.FocusedColor = System.Drawing.Color.Empty
        Me.cboAccesslevel.FocusedState.Parent = Me.cboAccesslevel
        Me.cboAccesslevel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboAccesslevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboAccesslevel.FormattingEnabled = True
        Me.cboAccesslevel.HoverState.Parent = Me.cboAccesslevel
        Me.cboAccesslevel.ItemHeight = 30
        Me.cboAccesslevel.Items.AddRange(New Object() {"Admin", "Employee", "Assistant Boss"})
        Me.cboAccesslevel.ItemsAppearance.Parent = Me.cboAccesslevel
        Me.cboAccesslevel.Location = New System.Drawing.Point(13, 242)
        Me.cboAccesslevel.Name = "cboAccesslevel"
        Me.cboAccesslevel.ShadowDecoration.Parent = Me.cboAccesslevel
        Me.cboAccesslevel.Size = New System.Drawing.Size(370, 36)
        Me.cboAccesslevel.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(25, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 56)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Add Users"
        '
        'btnsave
        '
        Me.btnsave.BorderRadius = 12
        Me.btnsave.CheckedState.Parent = Me.btnsave
        Me.btnsave.CustomImages.Parent = Me.btnsave
        Me.btnsave.FillColor = System.Drawing.SystemColors.ControlLight
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnsave.ForeColor = System.Drawing.Color.Black
        Me.btnsave.HoverState.Parent = Me.btnsave
        Me.btnsave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnsave.ImageOffset = New System.Drawing.Point(1, 1)
        Me.btnsave.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnsave.Location = New System.Drawing.Point(309, 557)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.ShadowDecoration.Parent = Me.btnsave
        Me.btnsave.Size = New System.Drawing.Size(146, 38)
        Me.btnsave.TabIndex = 53
        Me.btnsave.Text = "Submit"
        '
        'ButtonDiscard
        '
        Me.ButtonDiscard.Animated = True
        Me.ButtonDiscard.CheckedState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.CustomImages.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.FillColor = System.Drawing.Color.Transparent
        Me.ButtonDiscard.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ButtonDiscard.ForeColor = System.Drawing.Color.DarkGray
        Me.ButtonDiscard.HoverState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Location = New System.Drawing.Point(12, 557)
        Me.ButtonDiscard.Name = "ButtonDiscard"
        Me.ButtonDiscard.ShadowDecoration.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Size = New System.Drawing.Size(189, 38)
        Me.ButtonDiscard.TabIndex = 54
        Me.ButtonDiscard.Text = "Discard"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Label4)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(468, 66)
        Me.Guna2GradientPanel1.TabIndex = 55
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.FillColor = System.Drawing.Color.DimGray
        Me.Guna2Separator1.Location = New System.Drawing.Point(-46, 540)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(562, 10)
        Me.Guna2Separator1.TabIndex = 57
        '
        'AddUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(468, 637)
        Me.Controls.Add(Me.flpMain)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.ButtonDiscard)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddUsers"
        Me.TopMost = True
        Me.flpMain.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LabelInfo As Label
    Friend WithEvents txtfirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblLastNameValidation As Label
    Friend WithEvents lblCourseValidation As Label
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents flpMain As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtusername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblLRNValidation As Label
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblStudentIDValidation As Label
    Friend WithEvents lblFirstNameValidation As Label
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cborole As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtlastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblYearLevelValidation As Label
    Friend WithEvents lblSectionValidation As Label
    Friend WithEvents ErrorCourse As Label
    Friend WithEvents cboStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboAccesslevel As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnsave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonDiscard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
End Class
