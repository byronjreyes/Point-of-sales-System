<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPOS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lblTransNo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtprodname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAmt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtQty1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCrit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtStatus = New System.Windows.Forms.Label()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRemoved = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPayment = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboDiscount = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblRefNo = New System.Windows.Forms.Label()
        Me.lblMOP = New System.Windows.Forms.Label()
        Me.lblDisc = New System.Windows.Forms.Label()
        Me.lblVSales = New System.Windows.Forms.Label()
        Me.lblVAT = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblAmountPaid = New System.Windows.Forms.Label()
        Me.lblTotalitems = New System.Windows.Forms.Label()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblref = New System.Windows.Forms.Label()
        Me.lblmod = New System.Windows.Forms.Label()
        Me.lblamountc = New System.Windows.Forms.Label()
        Me.lblamountp = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblCashier = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lbltime)
        Me.Panel1.Controls.Add(Me.lbldate)
        Me.Panel1.Controls.Add(Me.lblTransNo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1261, 103)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(275, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "KM 31 NATIONAL ROAD TUNASAN MUNTINLUPA CITY"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(834, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 37)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "DATE AND TIME:"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(1124, 63)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(51, 34)
        Me.lbltime.TabIndex = 0
        Me.lbltime.Text = "****"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(1013, 63)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(51, 34)
        Me.lbldate.TabIndex = 0
        Me.lbldate.Text = "****"
        '
        'lblTransNo
        '
        Me.lblTransNo.AutoSize = True
        Me.lblTransNo.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransNo.Location = New System.Drawing.Point(1094, 24)
        Me.lblTransNo.Name = "lblTransNo"
        Me.lblTransNo.Size = New System.Drawing.Size(81, 34)
        Me.lblTransNo.TabIndex = 0
        Me.lblTransNo.Text = "100000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(834, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(254, 37)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "TRANSACTION NUMBER:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "POINT OF SALES SYSTEM"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbltotal)
        Me.GroupBox1.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.GroupBox1.Location = New System.Drawing.Point(841, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 115)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GRAND TOTAL"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(23, 44)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(74, 42)
        Me.lbltotal.TabIndex = 0
        Me.lbltotal.Text = "0. 00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 28)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Product Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(165, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 28)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Product Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(328, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 28)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Amount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(420, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 28)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Quantity"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(548, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 28)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Critical Level"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(693, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 28)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Status"
        '
        'txtcode
        '
        Me.txtcode.BorderRadius = 12
        Me.txtcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcode.DefaultText = ""
        Me.txtcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcode.DisabledState.Parent = Me.txtcode
        Me.txtcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcode.FocusedState.Parent = Me.txtcode
        Me.txtcode.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.ForeColor = System.Drawing.Color.Black
        Me.txtcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcode.HoverState.Parent = Me.txtcode
        Me.txtcode.Location = New System.Drawing.Point(13, 154)
        Me.txtcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcode.PlaceholderText = ""
        Me.txtcode.SelectedText = ""
        Me.txtcode.ShadowDecoration.Parent = Me.txtcode
        Me.txtcode.Size = New System.Drawing.Size(120, 33)
        Me.txtcode.TabIndex = 3
        '
        'txtprodname
        '
        Me.txtprodname.BorderRadius = 12
        Me.txtprodname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtprodname.DefaultText = ""
        Me.txtprodname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtprodname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtprodname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtprodname.DisabledState.Parent = Me.txtprodname
        Me.txtprodname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtprodname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtprodname.FocusedState.Parent = Me.txtprodname
        Me.txtprodname.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprodname.ForeColor = System.Drawing.Color.Black
        Me.txtprodname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtprodname.HoverState.Parent = Me.txtprodname
        Me.txtprodname.Location = New System.Drawing.Point(155, 154)
        Me.txtprodname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprodname.Name = "txtprodname"
        Me.txtprodname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtprodname.PlaceholderText = ""
        Me.txtprodname.SelectedText = ""
        Me.txtprodname.ShadowDecoration.Parent = Me.txtprodname
        Me.txtprodname.Size = New System.Drawing.Size(150, 33)
        Me.txtprodname.TabIndex = 3
        '
        'txtAmt
        '
        Me.txtAmt.BorderRadius = 12
        Me.txtAmt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmt.DefaultText = ""
        Me.txtAmt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAmt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAmt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAmt.DisabledState.Parent = Me.txtAmt
        Me.txtAmt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAmt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAmt.FocusedState.Parent = Me.txtAmt
        Me.txtAmt.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmt.ForeColor = System.Drawing.Color.Black
        Me.txtAmt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAmt.HoverState.Parent = Me.txtAmt
        Me.txtAmt.Location = New System.Drawing.Point(330, 154)
        Me.txtAmt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAmt.PlaceholderText = ""
        Me.txtAmt.ReadOnly = True
        Me.txtAmt.SelectedText = ""
        Me.txtAmt.ShadowDecoration.Parent = Me.txtAmt
        Me.txtAmt.Size = New System.Drawing.Size(73, 33)
        Me.txtAmt.TabIndex = 3
        '
        'txtQty1
        '
        Me.txtQty1.BorderRadius = 12
        Me.txtQty1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQty1.DefaultText = ""
        Me.txtQty1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtQty1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtQty1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQty1.DisabledState.Parent = Me.txtQty1
        Me.txtQty1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQty1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQty1.FocusedState.Parent = Me.txtQty1
        Me.txtQty1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty1.ForeColor = System.Drawing.Color.Black
        Me.txtQty1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQty1.HoverState.Parent = Me.txtQty1
        Me.txtQty1.Location = New System.Drawing.Point(425, 154)
        Me.txtQty1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQty1.Name = "txtQty1"
        Me.txtQty1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQty1.PlaceholderText = ""
        Me.txtQty1.ReadOnly = True
        Me.txtQty1.SelectedText = ""
        Me.txtQty1.ShadowDecoration.Parent = Me.txtQty1
        Me.txtQty1.Size = New System.Drawing.Size(76, 33)
        Me.txtQty1.TabIndex = 3
        '
        'txtCrit
        '
        Me.txtCrit.BorderRadius = 12
        Me.txtCrit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCrit.DefaultText = ""
        Me.txtCrit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCrit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCrit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCrit.DisabledState.Parent = Me.txtCrit
        Me.txtCrit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCrit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCrit.FocusedState.Parent = Me.txtCrit
        Me.txtCrit.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCrit.ForeColor = System.Drawing.Color.Black
        Me.txtCrit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCrit.HoverState.Parent = Me.txtCrit
        Me.txtCrit.Location = New System.Drawing.Point(552, 153)
        Me.txtCrit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCrit.Name = "txtCrit"
        Me.txtCrit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCrit.PlaceholderText = ""
        Me.txtCrit.ReadOnly = True
        Me.txtCrit.SelectedText = ""
        Me.txtCrit.ShadowDecoration.Parent = Me.txtCrit
        Me.txtCrit.Size = New System.Drawing.Size(108, 33)
        Me.txtCrit.TabIndex = 3
        '
        'txtStatus
        '
        Me.txtStatus.AutoSize = True
        Me.txtStatus.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(692, 153)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(51, 34)
        Me.txtStatus.TabIndex = 0
        Me.txtStatus.Text = "****"
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView2.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(14, 243)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(817, 444)
        Me.ListView2.TabIndex = 4
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Product Code"
        Me.ColumnHeader1.Width = 206
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Product Name"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 218
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Amount"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 142
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Quantity"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 99
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Sub Total"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 148
        '
        'btnAdd
        '
        Me.btnAdd.Animated = True
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnAdd.BorderRadius = 21
        Me.btnAdd.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnAdd.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnAdd.CheckedState.Parent = Me.btnAdd
        Me.btnAdd.CustomImages.Parent = Me.btnAdd
        Me.btnAdd.FillColor = System.Drawing.Color.Transparent
        Me.btnAdd.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.HoverState.Parent = Me.btnAdd
        Me.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdd.Location = New System.Drawing.Point(13, 716)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Parent = Me.btnAdd
        Me.btnAdd.Size = New System.Drawing.Size(150, 94)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "ADD TO CART"
        '
        'btnRemoved
        '
        Me.btnRemoved.Animated = True
        Me.btnRemoved.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnRemoved.BorderRadius = 21
        Me.btnRemoved.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnRemoved.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnRemoved.CheckedState.Parent = Me.btnRemoved
        Me.btnRemoved.CustomImages.Parent = Me.btnRemoved
        Me.btnRemoved.FillColor = System.Drawing.Color.Transparent
        Me.btnRemoved.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoved.ForeColor = System.Drawing.Color.White
        Me.btnRemoved.HoverState.Parent = Me.btnRemoved
        Me.btnRemoved.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRemoved.Location = New System.Drawing.Point(179, 716)
        Me.btnRemoved.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRemoved.Name = "btnRemoved"
        Me.btnRemoved.ShadowDecoration.Parent = Me.btnRemoved
        Me.btnRemoved.Size = New System.Drawing.Size(150, 94)
        Me.btnRemoved.TabIndex = 5
        Me.btnRemoved.Text = "REMOVE"
        '
        'btnPayment
        '
        Me.btnPayment.Animated = True
        Me.btnPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnPayment.BorderRadius = 21
        Me.btnPayment.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnPayment.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnPayment.CheckedState.Parent = Me.btnPayment
        Me.btnPayment.CustomImages.Parent = Me.btnPayment
        Me.btnPayment.FillColor = System.Drawing.Color.Transparent
        Me.btnPayment.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.ForeColor = System.Drawing.Color.White
        Me.btnPayment.HoverState.Parent = Me.btnPayment
        Me.btnPayment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnPayment.Location = New System.Drawing.Point(351, 716)
        Me.btnPayment.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.ShadowDecoration.Parent = Me.btnPayment
        Me.btnPayment.Size = New System.Drawing.Size(141, 94)
        Me.btnPayment.TabIndex = 5
        Me.btnPayment.Text = "PAYMENT"
        '
        'btnSave
        '
        Me.btnSave.Animated = True
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnSave.BorderRadius = 21
        Me.btnSave.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnSave.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.FillColor = System.Drawing.Color.Transparent
        Me.btnSave.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSave.Location = New System.Drawing.Point(510, 716)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(150, 94)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "SAVE"
        '
        'btnCancel
        '
        Me.btnCancel.Animated = True
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnCancel.BorderRadius = 21
        Me.btnCancel.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnCancel.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.Color.Transparent
        Me.btnCancel.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCancel.Location = New System.Drawing.Point(680, 716)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(150, 94)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "CANCEL"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboDiscount)
        Me.GroupBox2.Controls.Add(Me.lblRefNo)
        Me.GroupBox2.Controls.Add(Me.lblMOP)
        Me.GroupBox2.Controls.Add(Me.lblDisc)
        Me.GroupBox2.Controls.Add(Me.lblVSales)
        Me.GroupBox2.Controls.Add(Me.lblVAT)
        Me.GroupBox2.Controls.Add(Me.lblChange)
        Me.GroupBox2.Controls.Add(Me.lblAmountPaid)
        Me.GroupBox2.Controls.Add(Me.lblTotalitems)
        Me.GroupBox2.Controls.Add(Me.Guna2Separator2)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.lblref)
        Me.GroupBox2.Controls.Add(Me.lblmod)
        Me.GroupBox2.Controls.Add(Me.lblamountc)
        Me.GroupBox2.Controls.Add(Me.lblamountp)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(841, 242)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 445)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'cboDiscount
        '
        Me.cboDiscount.BackColor = System.Drawing.Color.Transparent
        Me.cboDiscount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiscount.FocusedColor = System.Drawing.Color.Empty
        Me.cboDiscount.FocusedState.Parent = Me.cboDiscount
        Me.cboDiscount.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboDiscount.FormattingEnabled = True
        Me.cboDiscount.HoverState.Parent = Me.cboDiscount
        Me.cboDiscount.ItemHeight = 30
        Me.cboDiscount.Items.AddRange(New Object() {"Senior Citizen", "PWD"})
        Me.cboDiscount.ItemsAppearance.Parent = Me.cboDiscount
        Me.cboDiscount.Location = New System.Drawing.Point(228, 381)
        Me.cboDiscount.Name = "cboDiscount"
        Me.cboDiscount.ShadowDecoration.Parent = Me.cboDiscount
        Me.cboDiscount.Size = New System.Drawing.Size(140, 36)
        Me.cboDiscount.TabIndex = 22
        '
        'lblRefNo
        '
        Me.lblRefNo.AutoSize = True
        Me.lblRefNo.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefNo.Location = New System.Drawing.Point(221, 206)
        Me.lblRefNo.Name = "lblRefNo"
        Me.lblRefNo.Size = New System.Drawing.Size(138, 42)
        Me.lblRefNo.TabIndex = 0
        Me.lblRefNo.Text = "**********"
        '
        'lblMOP
        '
        Me.lblMOP.AutoSize = True
        Me.lblMOP.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMOP.Location = New System.Drawing.Point(221, 169)
        Me.lblMOP.Name = "lblMOP"
        Me.lblMOP.Size = New System.Drawing.Size(138, 42)
        Me.lblMOP.TabIndex = 0
        Me.lblMOP.Text = "**********"
        '
        'lblDisc
        '
        Me.lblDisc.AutoSize = True
        Me.lblDisc.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisc.Location = New System.Drawing.Point(260, 342)
        Me.lblDisc.Name = "lblDisc"
        Me.lblDisc.Size = New System.Drawing.Size(60, 34)
        Me.lblDisc.TabIndex = 0
        Me.lblDisc.Text = "0. 00"
        '
        'lblVSales
        '
        Me.lblVSales.AutoSize = True
        Me.lblVSales.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVSales.Location = New System.Drawing.Point(260, 303)
        Me.lblVSales.Name = "lblVSales"
        Me.lblVSales.Size = New System.Drawing.Size(60, 34)
        Me.lblVSales.TabIndex = 0
        Me.lblVSales.Text = "0. 00"
        '
        'lblVAT
        '
        Me.lblVAT.AutoSize = True
        Me.lblVAT.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVAT.Location = New System.Drawing.Point(260, 266)
        Me.lblVAT.Name = "lblVAT"
        Me.lblVAT.Size = New System.Drawing.Size(60, 34)
        Me.lblVAT.TabIndex = 0
        Me.lblVAT.Text = "0. 00"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(260, 114)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(60, 34)
        Me.lblChange.TabIndex = 0
        Me.lblChange.Text = "0. 00"
        '
        'lblAmountPaid
        '
        Me.lblAmountPaid.AutoSize = True
        Me.lblAmountPaid.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountPaid.Location = New System.Drawing.Point(260, 74)
        Me.lblAmountPaid.Name = "lblAmountPaid"
        Me.lblAmountPaid.Size = New System.Drawing.Size(60, 34)
        Me.lblAmountPaid.TabIndex = 0
        Me.lblAmountPaid.Text = "0. 00"
        '
        'lblTotalitems
        '
        Me.lblTotalitems.AutoSize = True
        Me.lblTotalitems.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalitems.Location = New System.Drawing.Point(260, 32)
        Me.lblTotalitems.Name = "lblTotalitems"
        Me.lblTotalitems.Size = New System.Drawing.Size(60, 34)
        Me.lblTotalitems.TabIndex = 0
        Me.lblTotalitems.Text = "0. 00"
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator2.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Guna2Separator2.FillStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2Separator2.FillThickness = 3
        Me.Guna2Separator2.Location = New System.Drawing.Point(0, 242)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(408, 21)
        Me.Guna2Separator2.TabIndex = 21
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(7, 381)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(153, 34)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Discount Type:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 342)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(102, 34)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Discount:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 303)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(185, 34)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "VAT Amount(12%):"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 266)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(151, 34)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Vatable Sales:"
        '
        'lblref
        '
        Me.lblref.AutoSize = True
        Me.lblref.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblref.Location = New System.Drawing.Point(6, 211)
        Me.lblref.Name = "lblref"
        Me.lblref.Size = New System.Drawing.Size(198, 34)
        Me.lblref.TabIndex = 0
        Me.lblref.Text = "Reference Number:"
        '
        'lblmod
        '
        Me.lblmod.AutoSize = True
        Me.lblmod.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmod.Location = New System.Drawing.Point(6, 169)
        Me.lblmod.Name = "lblmod"
        Me.lblmod.Size = New System.Drawing.Size(186, 34)
        Me.lblmod.TabIndex = 0
        Me.lblmod.Text = "Mode of Payment:"
        '
        'lblamountc
        '
        Me.lblamountc.AutoSize = True
        Me.lblamountc.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamountc.Location = New System.Drawing.Point(6, 122)
        Me.lblamountc.Name = "lblamountc"
        Me.lblamountc.Size = New System.Drawing.Size(173, 34)
        Me.lblamountc.TabIndex = 0
        Me.lblamountc.Text = "Amount Change"
        '
        'lblamountp
        '
        Me.lblamountp.AutoSize = True
        Me.lblamountp.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamountp.Location = New System.Drawing.Point(6, 82)
        Me.lblamountp.Name = "lblamountp"
        Me.lblamountp.Size = New System.Drawing.Size(142, 34)
        Me.lblamountp.TabIndex = 0
        Me.lblamountp.Text = "Amount Paid:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(219, 34)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Total Product(s) Sold:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 211)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 28)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "CART:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(845, 716)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(156, 34)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Cashier Name:"
        '
        'lblCashier
        '
        Me.lblCashier.AutoSize = True
        Me.lblCashier.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashier.Location = New System.Drawing.Point(845, 750)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(69, 34)
        Me.lblCashier.TabIndex = 0
        Me.lblCashier.Text = "******"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Guna2Button1.BorderRadius = 21
        Me.Guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.Guna2Button1.CheckedState.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.Location = New System.Drawing.Point(1099, 716)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(150, 94)
        Me.Guna2Button1.TabIndex = 5
        Me.Guna2Button1.Text = "btnLogout"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1261, 843)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.btnRemoved)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.txtCrit)
        Me.Controls.Add(Me.txtQty1)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.lblCashier)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtAmt)
        Me.Controls.Add(Me.txtprodname)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maindashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents lblTransNo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtprodname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAmt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtQty1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCrit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStatus As Label
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRemoved As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPayment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents lblref As Label
    Friend WithEvents lblmod As Label
    Friend WithEvents lblamountc As Label
    Friend WithEvents lblamountp As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cboDiscount As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblRefNo As Label
    Friend WithEvents lblMOP As Label
    Friend WithEvents lblDisc As Label
    Friend WithEvents lblVSales As Label
    Friend WithEvents lblVAT As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents lblAmountPaid As Label
    Friend WithEvents lblTotalitems As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblCashier As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
End Class
