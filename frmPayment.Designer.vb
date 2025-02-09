<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboMOP = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtRefNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAmountPaid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.Label()
        Me.btnEnter = New Guna.UI2.WinForms.Guna2Button()
        Me.btnplus = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(30, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 48)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Payment Mode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(30, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 48)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Reference Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(30, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 48)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Grand Total:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(30, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 48)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Amount Paid:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(30, 347)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(248, 48)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Amount Change:"
        '
        'cboMOP
        '
        Me.cboMOP.BackColor = System.Drawing.Color.Transparent
        Me.cboMOP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboMOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMOP.FocusedColor = System.Drawing.Color.Empty
        Me.cboMOP.FocusedState.Parent = Me.cboMOP
        Me.cboMOP.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboMOP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboMOP.FormattingEnabled = True
        Me.cboMOP.HoverState.Parent = Me.cboMOP
        Me.cboMOP.ItemHeight = 30
        Me.cboMOP.ItemsAppearance.Parent = Me.cboMOP
        Me.cboMOP.Location = New System.Drawing.Point(375, 36)
        Me.cboMOP.Name = "cboMOP"
        Me.cboMOP.ShadowDecoration.Parent = Me.cboMOP
        Me.cboMOP.Size = New System.Drawing.Size(183, 36)
        Me.cboMOP.TabIndex = 23
        '
        'txtRefNo
        '
        Me.txtRefNo.BorderRadius = 12
        Me.txtRefNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRefNo.DefaultText = ""
        Me.txtRefNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRefNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRefNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRefNo.DisabledState.Parent = Me.txtRefNo
        Me.txtRefNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRefNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRefNo.FocusedState.Parent = Me.txtRefNo
        Me.txtRefNo.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefNo.ForeColor = System.Drawing.Color.Black
        Me.txtRefNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRefNo.HoverState.Parent = Me.txtRefNo
        Me.txtRefNo.Location = New System.Drawing.Point(375, 123)
        Me.txtRefNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRefNo.PlaceholderText = ""
        Me.txtRefNo.SelectedText = ""
        Me.txtRefNo.ShadowDecoration.Parent = Me.txtRefNo
        Me.txtRefNo.Size = New System.Drawing.Size(183, 33)
        Me.txtRefNo.TabIndex = 24
        '
        'txtAmountPaid
        '
        Me.txtAmountPaid.BorderRadius = 12
        Me.txtAmountPaid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmountPaid.DefaultText = ""
        Me.txtAmountPaid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAmountPaid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAmountPaid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAmountPaid.DisabledState.Parent = Me.txtAmountPaid
        Me.txtAmountPaid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAmountPaid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAmountPaid.FocusedState.Parent = Me.txtAmountPaid
        Me.txtAmountPaid.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountPaid.ForeColor = System.Drawing.Color.Black
        Me.txtAmountPaid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAmountPaid.HoverState.Parent = Me.txtAmountPaid
        Me.txtAmountPaid.Location = New System.Drawing.Point(375, 282)
        Me.txtAmountPaid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAmountPaid.PlaceholderText = ""
        Me.txtAmountPaid.SelectedText = ""
        Me.txtAmountPaid.ShadowDecoration.Parent = Me.txtAmountPaid
        Me.txtAmountPaid.Size = New System.Drawing.Size(183, 33)
        Me.txtAmountPaid.TabIndex = 24
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotal.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblGrandTotal.Location = New System.Drawing.Point(369, 204)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(60, 34)
        Me.lblGrandTotal.TabIndex = 25
        Me.lblGrandTotal.Text = "0. 00"
        '
        'txtChange
        '
        Me.txtChange.AutoSize = True
        Me.txtChange.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtChange.Location = New System.Drawing.Point(369, 356)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(60, 34)
        Me.txtChange.TabIndex = 25
        Me.txtChange.Text = "0. 00"
        '
        'btnEnter
        '
        Me.btnEnter.Animated = True
        Me.btnEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnEnter.BorderRadius = 21
        Me.btnEnter.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnEnter.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnEnter.CheckedState.Parent = Me.btnEnter
        Me.btnEnter.CustomImages.Parent = Me.btnEnter
        Me.btnEnter.FillColor = System.Drawing.Color.Transparent
        Me.btnEnter.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.White
        Me.btnEnter.HoverState.Parent = Me.btnEnter
        Me.btnEnter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEnter.Location = New System.Drawing.Point(354, 427)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.ShadowDecoration.Parent = Me.btnEnter
        Me.btnEnter.Size = New System.Drawing.Size(224, 42)
        Me.btnEnter.TabIndex = 26
        Me.btnEnter.Text = "Enter Payment"
        '
        'btnplus
        '
        Me.btnplus.Animated = True
        Me.btnplus.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnplus.BorderRadius = 21
        Me.btnplus.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnplus.CheckedState.ForeColor = System.Drawing.Color.White
        Me.btnplus.CheckedState.Parent = Me.btnplus
        Me.btnplus.CustomImages.Parent = Me.btnplus
        Me.btnplus.FillColor = System.Drawing.Color.Transparent
        Me.btnplus.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnplus.ForeColor = System.Drawing.Color.White
        Me.btnplus.HoverState.Parent = Me.btnplus
        Me.btnplus.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnplus.Location = New System.Drawing.Point(578, 36)
        Me.btnplus.Margin = New System.Windows.Forms.Padding(0)
        Me.btnplus.Name = "btnplus"
        Me.btnplus.ShadowDecoration.Parent = Me.btnplus
        Me.btnplus.Size = New System.Drawing.Size(59, 48)
        Me.btnplus.TabIndex = 26
        Me.btnplus.Text = "+"
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(701, 515)
        Me.Controls.Add(Me.btnplus)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.lblGrandTotal)
        Me.Controls.Add(Me.txtAmountPaid)
        Me.Controls.Add(Me.txtRefNo)
        Me.Controls.Add(Me.cboMOP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPayment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboMOP As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtRefNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAmountPaid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblGrandTotal As Label
    Friend WithEvents txtChange As Label
    Friend WithEvents btnEnter As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnplus As Guna.UI2.WinForms.Guna2Button
End Class
