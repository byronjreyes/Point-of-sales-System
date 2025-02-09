Public Class UsersInfo
    Private Sub UsersInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub New()
        InitializeComponent()
        DoubleBuffered = True
    End Sub
    Public Sub New(username As String, password As String, firstName As String, lastName As String, role As String, accesslevel As String, accountstatus As String)
        InitializeComponent()

        lblusername.Text = username
        lblpassword.Text = password
        lblfirstname.Text = firstName
        lbllastname.Text = lastName
        lblaccesslevel.Text = accesslevel
        lblrole.Text = role
        If accountstatus.ToUpper() = "ACTIVE" Then
            lblaccstatus.Text = "Active"
            lblaccstatus.BackColor = Color.Green
        ElseIf accountstatus.ToUpper() = "INACTIVE" Then
            lblaccstatus.Text = "Inactive"
            lblaccstatus.BackColor = Color.Red
        Else
            lblaccstatus.Text = accountstatus
        End If
    End Sub



    Private Sub updateinfo_Click(sender As Object, e As EventArgs) Handles updateinfo.Click
        Dim username As String = lblusername.Text
        Dim password As String = lblpassword.Text
        Dim firstName As String = lblfirstname.Text
        Dim lastName As String = lbllastname.Text
        Dim role As String = lblrole.Text
        Dim accesslevel As String = lblaccesslevel.Text
        Dim accountstatus As String = lblaccstatus.Text
        Dim updateForm As New UpdateUsers()
        updateForm.setvotersinfo(username, password, firstName, lastName, role, accesslevel, accountstatus)
        updateForm.ShowDialog()

        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub
End Class