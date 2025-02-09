<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsPanel
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.BtnChangePassword = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnbackupdata = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Controls.Add(Me.Guna2GradientPanel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Guna2GradientPanel2)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(74, 177)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(581, 398)
        Me.FlowLayoutPanel1.TabIndex = 79
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BorderRadius = 9
        Me.Guna2GradientPanel1.Controls.Add(Me.BtnChangePassword)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label3)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Guna2GradientPanel1.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.BorderRadius = 9
        Me.Guna2GradientPanel1.ShadowDecoration.Color = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.ShadowDecoration.Depth = 0
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(279, 127)
        Me.Guna2GradientPanel1.TabIndex = 13
        '
        'BtnChangePassword
        '
        Me.BtnChangePassword.Animated = True
        Me.BtnChangePassword.BorderColor = System.Drawing.Color.Transparent
        Me.BtnChangePassword.BorderRadius = 9
        Me.BtnChangePassword.CheckedState.Parent = Me.BtnChangePassword
        Me.BtnChangePassword.CustomImages.Parent = Me.BtnChangePassword
        Me.BtnChangePassword.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnChangePassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnChangePassword.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnChangePassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnChangePassword.ForeColor = System.Drawing.Color.White
        Me.BtnChangePassword.HoverState.Parent = Me.BtnChangePassword
        Me.BtnChangePassword.Location = New System.Drawing.Point(0, 95)
        Me.BtnChangePassword.Name = "BtnChangePassword"
        Me.BtnChangePassword.ShadowDecoration.Color = System.Drawing.Color.Transparent
        Me.BtnChangePassword.ShadowDecoration.Depth = 0
        Me.BtnChangePassword.ShadowDecoration.Parent = Me.BtnChangePassword
        Me.BtnChangePassword.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.BtnChangePassword.Size = New System.Drawing.Size(279, 32)
        Me.BtnChangePassword.TabIndex = 1
        Me.BtnChangePassword.Text = "More Info"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(27, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 46)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "You can update your password " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "here."
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.BorderRadius = 9
        Me.Guna2GradientPanel2.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel2.Controls.Add(Me.btnbackupdata)
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Guna2GradientPanel2.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(288, 3)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.ShadowDecoration.BorderRadius = 9
        Me.Guna2GradientPanel2.ShadowDecoration.Color = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel2.ShadowDecoration.Depth = 0
        Me.Guna2GradientPanel2.ShadowDecoration.Parent = Me.Guna2GradientPanel2
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(279, 127)
        Me.Guna2GradientPanel2.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(44, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Backup your  database"
        '
        'btnbackupdata
        '
        Me.btnbackupdata.Animated = True
        Me.btnbackupdata.BorderColor = System.Drawing.Color.Transparent
        Me.btnbackupdata.BorderRadius = 9
        Me.btnbackupdata.CheckedState.Parent = Me.btnbackupdata
        Me.btnbackupdata.CustomImages.Parent = Me.btnbackupdata
        Me.btnbackupdata.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnbackupdata.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnbackupdata.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnbackupdata.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnbackupdata.ForeColor = System.Drawing.Color.White
        Me.btnbackupdata.HoverState.Parent = Me.btnbackupdata
        Me.btnbackupdata.Location = New System.Drawing.Point(0, 95)
        Me.btnbackupdata.Name = "btnbackupdata"
        Me.btnbackupdata.ShadowDecoration.Color = System.Drawing.Color.Transparent
        Me.btnbackupdata.ShadowDecoration.Depth = 0
        Me.btnbackupdata.ShadowDecoration.Parent = Me.btnbackupdata
        Me.btnbackupdata.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.btnbackupdata.Size = New System.Drawing.Size(279, 32)
        Me.btnbackupdata.TabIndex = 1
        Me.btnbackupdata.Text = "More Info"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Lucida Sans Unicode", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(28, 28)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(173, 45)
        Me.GunaLabel3.TabIndex = 80
        Me.GunaLabel3.Text = "Settings"
        '
        'SettingsPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1031, 751)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SettingsPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SettingsPanel"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents BtnChangePassword As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnbackupdata As Guna.UI2.WinForms.Guna2GradientButton
End Class
