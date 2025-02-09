<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Backupdb
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
        Me.ButtonDiscard = New Guna.UI2.WinForms.Guna2Button()
        Me.btnbackup = New Guna.UI.WinForms.GunaButton()
        Me.lblBackupNote = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.SuspendLayout()
        '
        'ButtonDiscard
        '
        Me.ButtonDiscard.Animated = True
        Me.ButtonDiscard.CheckedState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.CustomImages.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.FillColor = System.Drawing.Color.Transparent
        Me.ButtonDiscard.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDiscard.ForeColor = System.Drawing.Color.Gray
        Me.ButtonDiscard.HoverState.FillColor = System.Drawing.Color.Silver
        Me.ButtonDiscard.HoverState.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDiscard.HoverState.ForeColor = System.Drawing.Color.Gray
        Me.ButtonDiscard.HoverState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Location = New System.Drawing.Point(241, 304)
        Me.ButtonDiscard.Name = "ButtonDiscard"
        Me.ButtonDiscard.ShadowDecoration.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Size = New System.Drawing.Size(169, 38)
        Me.ButtonDiscard.TabIndex = 97
        Me.ButtonDiscard.Text = "Discard"
        '
        'btnbackup
        '
        Me.btnbackup.AnimationHoverSpeed = 0.07!
        Me.btnbackup.AnimationSpeed = 0.03!
        Me.btnbackup.BackColor = System.Drawing.Color.Transparent
        Me.btnbackup.BaseColor = System.Drawing.Color.Transparent
        Me.btnbackup.BorderColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnbackup.BorderSize = 2
        Me.btnbackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbackup.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnbackup.FocusedColor = System.Drawing.Color.Transparent
        Me.btnbackup.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbackup.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnbackup.Image = Nothing
        Me.btnbackup.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnbackup.Location = New System.Drawing.Point(212, 252)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnbackup.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnbackup.OnHoverForeColor = System.Drawing.Color.White
        Me.btnbackup.OnHoverImage = Nothing
        Me.btnbackup.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnbackup.OnPressedDepth = 25
        Me.btnbackup.Radius = 21
        Me.btnbackup.Size = New System.Drawing.Size(226, 46)
        Me.btnbackup.TabIndex = 96
        Me.btnbackup.Text = "Backup"
        Me.btnbackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBackupNote
        '
        Me.lblBackupNote.AutoSize = True
        Me.lblBackupNote.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBackupNote.ForeColor = System.Drawing.Color.Red
        Me.lblBackupNote.Location = New System.Drawing.Point(51, 377)
        Me.lblBackupNote.Name = "lblBackupNote"
        Me.lblBackupNote.Size = New System.Drawing.Size(0, 26)
        Me.lblBackupNote.TabIndex = 98
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Snow
        Me.Label3.Location = New System.Drawing.Point(147, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(354, 37)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Backup your database in 1 Click!"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Lucida Sans Unicode", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(28, 28)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(340, 45)
        Me.GunaLabel3.TabIndex = 101
        Me.GunaLabel3.Text = "Backup Database"
        '
        'Backupdb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(664, 504)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblBackupNote)
        Me.Controls.Add(Me.ButtonDiscard)
        Me.Controls.Add(Me.btnbackup)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Backupdb"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backupdb"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonDiscard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnbackup As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblBackupNote As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
End Class
