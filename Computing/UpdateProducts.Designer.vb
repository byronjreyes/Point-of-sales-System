<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateProducts
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
        Me.ButtonDiscard = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.cbostatus = New Guna.UI.WinForms.GunaComboBox()
        Me.txtcategory = New Guna.UI.WinForms.GunaComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcrit = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtquantity = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtamount = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtproddes = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtproductname = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtprodcode = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Guna2ShadowPanel3 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonDiscard
        '
        Me.ButtonDiscard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDiscard.Animated = True
        Me.ButtonDiscard.CheckedState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.CustomImages.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.FillColor = System.Drawing.Color.Transparent
        Me.ButtonDiscard.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ButtonDiscard.ForeColor = System.Drawing.Color.Gray
        Me.ButtonDiscard.HoverState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Location = New System.Drawing.Point(42, 384)
        Me.ButtonDiscard.Name = "ButtonDiscard"
        Me.ButtonDiscard.ShadowDecoration.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Size = New System.Drawing.Size(175, 38)
        Me.ButtonDiscard.TabIndex = 94
        Me.ButtonDiscard.Text = "Discard"
        '
        'ButtonSubmit
        '
        Me.ButtonSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSubmit.BorderRadius = 12
        Me.ButtonSubmit.CheckedState.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.CustomImages.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.FillColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonSubmit.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ButtonSubmit.ForeColor = System.Drawing.Color.Black
        Me.ButtonSubmit.HoverState.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ButtonSubmit.ImageOffset = New System.Drawing.Point(1, 1)
        Me.ButtonSubmit.ImageSize = New System.Drawing.Size(15, 15)
        Me.ButtonSubmit.Location = New System.Drawing.Point(482, 384)
        Me.ButtonSubmit.Name = "ButtonSubmit"
        Me.ButtonSubmit.ShadowDecoration.Parent = Me.ButtonSubmit
        Me.ButtonSubmit.Size = New System.Drawing.Size(169, 38)
        Me.ButtonSubmit.TabIndex = 93
        Me.ButtonSubmit.Text = "Update"
        '
        'cbostatus
        '
        Me.cbostatus.BackColor = System.Drawing.Color.Transparent
        Me.cbostatus.BaseColor = System.Drawing.Color.White
        Me.cbostatus.BorderColor = System.Drawing.Color.Transparent
        Me.cbostatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbostatus.FocusedColor = System.Drawing.Color.Empty
        Me.cbostatus.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbostatus.ForeColor = System.Drawing.Color.Black
        Me.cbostatus.FormattingEnabled = True
        Me.cbostatus.Items.AddRange(New Object() {"Available", "Critical Level", "Out of Stock"})
        Me.cbostatus.Location = New System.Drawing.Point(382, 321)
        Me.cbostatus.Name = "cbostatus"
        Me.cbostatus.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbostatus.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbostatus.Radius = 10
        Me.cbostatus.Size = New System.Drawing.Size(269, 31)
        Me.cbostatus.TabIndex = 92
        '
        'txtcategory
        '
        Me.txtcategory.BackColor = System.Drawing.Color.Transparent
        Me.txtcategory.BaseColor = System.Drawing.Color.White
        Me.txtcategory.BorderColor = System.Drawing.Color.Transparent
        Me.txtcategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtcategory.FocusedColor = System.Drawing.Color.Empty
        Me.txtcategory.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcategory.ForeColor = System.Drawing.Color.Black
        Me.txtcategory.FormattingEnabled = True
        Me.txtcategory.Items.AddRange(New Object() {"Computer", "Monitor", "PSU", "Ram", "Gpu", "Fans", "Motherboard", "SSD", "Case"})
        Me.txtcategory.Location = New System.Drawing.Point(39, 321)
        Me.txtcategory.Name = "txtcategory"
        Me.txtcategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcategory.OnHoverItemForeColor = System.Drawing.Color.White
        Me.txtcategory.Radius = 10
        Me.txtcategory.Size = New System.Drawing.Size(269, 31)
        Me.txtcategory.TabIndex = 91
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Snow
        Me.Label8.Location = New System.Drawing.Point(378, 295)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 23)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Status:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Snow
        Me.Label7.Location = New System.Drawing.Point(378, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 23)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Critical Level:"
        '
        'txtcrit
        '
        Me.txtcrit.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.txtcrit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcrit.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtcrit.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcrit.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtcrit.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtcrit.LineSize = 2
        Me.txtcrit.Location = New System.Drawing.Point(382, 252)
        Me.txtcrit.Name = "txtcrit"
        Me.txtcrit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcrit.SelectedText = ""
        Me.txtcrit.Size = New System.Drawing.Size(269, 30)
        Me.txtcrit.TabIndex = 88
        Me.txtcrit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Snow
        Me.Label6.Location = New System.Drawing.Point(379, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 23)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Quantity of Item:"
        '
        'txtquantity
        '
        Me.txtquantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.txtquantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtquantity.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtquantity.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtquantity.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtquantity.LineSize = 2
        Me.txtquantity.Location = New System.Drawing.Point(383, 183)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtquantity.SelectedText = ""
        Me.txtquantity.Size = New System.Drawing.Size(269, 30)
        Me.txtquantity.TabIndex = 86
        Me.txtquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Snow
        Me.Label5.Location = New System.Drawing.Point(378, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 23)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Amount of Item"
        '
        'txtamount
        '
        Me.txtamount.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.txtamount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtamount.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtamount.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtamount.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtamount.LineSize = 2
        Me.txtamount.Location = New System.Drawing.Point(382, 121)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtamount.SelectedText = ""
        Me.txtamount.Size = New System.Drawing.Size(269, 30)
        Me.txtamount.TabIndex = 84
        Me.txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Snow
        Me.Label3.Location = New System.Drawing.Point(35, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 23)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Snow
        Me.Label2.Location = New System.Drawing.Point(35, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 23)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Product Description:"
        '
        'txtproddes
        '
        Me.txtproddes.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.txtproddes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtproddes.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtproddes.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproddes.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtproddes.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtproddes.LineSize = 2
        Me.txtproddes.Location = New System.Drawing.Point(39, 252)
        Me.txtproddes.Name = "txtproddes"
        Me.txtproddes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtproddes.SelectedText = ""
        Me.txtproddes.Size = New System.Drawing.Size(269, 30)
        Me.txtproddes.TabIndex = 81
        Me.txtproddes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(35, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 23)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Product Name:"
        '
        'txtproductname
        '
        Me.txtproductname.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.txtproductname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtproductname.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtproductname.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproductname.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtproductname.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtproductname.LineSize = 2
        Me.txtproductname.Location = New System.Drawing.Point(39, 183)
        Me.txtproductname.Name = "txtproductname"
        Me.txtproductname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtproductname.SelectedText = ""
        Me.txtproductname.Size = New System.Drawing.Size(269, 30)
        Me.txtproductname.TabIndex = 79
        Me.txtproductname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Snow
        Me.Label4.Location = New System.Drawing.Point(35, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 23)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Product Code"
        '
        'txtprodcode
        '
        Me.txtprodcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.txtprodcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtprodcode.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtprodcode.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprodcode.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtprodcode.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtprodcode.LineSize = 2
        Me.txtprodcode.Location = New System.Drawing.Point(39, 121)
        Me.txtprodcode.Name = "txtprodcode"
        Me.txtprodcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtprodcode.SelectedText = ""
        Me.txtprodcode.Size = New System.Drawing.Size(269, 30)
        Me.txtprodcode.TabIndex = 77
        Me.txtprodcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2ShadowPanel3
        '
        Me.Guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel3.Controls.Add(Me.Label9)
        Me.Guna2ShadowPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2ShadowPanel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Guna2ShadowPanel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2ShadowPanel3.Name = "Guna2ShadowPanel3"
        Me.Guna2ShadowPanel3.Radius = 9
        Me.Guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel3.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped
        Me.Guna2ShadowPanel3.Size = New System.Drawing.Size(690, 78)
        Me.Guna2ShadowPanel3.TabIndex = 95
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(12, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(205, 42)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Update Product"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 35
        Me.Guna2Elipse1.TargetControl = Me
        '
        'UpdateProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(690, 450)
        Me.Controls.Add(Me.Guna2ShadowPanel3)
        Me.Controls.Add(Me.ButtonDiscard)
        Me.Controls.Add(Me.ButtonSubmit)
        Me.Controls.Add(Me.cbostatus)
        Me.Controls.Add(Me.txtcategory)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtcrit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtproddes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtproductname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtprodcode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UpdateProducts"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateProducts"
        Me.TopMost = True
        Me.Guna2ShadowPanel3.ResumeLayout(False)
        Me.Guna2ShadowPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonDiscard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbostatus As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtcategory As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcrit As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtquantity As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtamount As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtproddes As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtproductname As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtprodcode As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Guna2ShadowPanel3 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
End Class
