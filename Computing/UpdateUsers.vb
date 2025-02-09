Imports System.Collections.Specialized.BitVector32
Imports System.Data.OleDb

Public Class UpdateUsers
    Private Sub UpdateUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub setvotersinfo(username As String, password As String, firstName As String, lastName As String, role As String, accesslevel As String, accountstatus As String)

        txtusername.Text = username
        txtpassword.Text = password
        cborole.Text = role
        txtfirstname.Text = firstName
        txtlastname.Text = lastName
        cboAccesslevel.Text = accesslevel
        cboStatus.Text = accountstatus
    End Sub

    Private Sub ButtonDiscard_Click(sender As Object, e As EventArgs) Handles ButtonDiscard.Click
        Me.Close()
    End Sub

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        updatedata()
    End Sub
    Private Sub updatedata()
        Try
            connection()

            If String.IsNullOrWhiteSpace(txtusername.Text) OrElse
           String.IsNullOrWhiteSpace(txtpassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtfirstname.Text) OrElse
           String.IsNullOrWhiteSpace(txtlastname.Text) OrElse
           String.IsNullOrWhiteSpace(cboAccesslevel.Text) OrElse
           String.IsNullOrWhiteSpace(cboStatus.Text) OrElse
           String.IsNullOrWhiteSpace(cborole.Text) Then

                MsgBox("Please fill in all required fields.", MsgBoxStyle.Exclamation)
                Return
            End If

            Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\POSdb.accdb")
                cn.Open()

                Dim sql As String = "UPDATE tblUsers SET [Password]=?, [AcctStatus]=?, [AccessLevel]=?, [Lastname]=?, [Firstname]=?, [Role]=? WHERE Username=?"
                Dim cmd As New OleDbCommand(sql, cn)

                With cmd
                    .Parameters.AddWithValue("?", txtpassword.Text)
                    .Parameters.AddWithValue("?", cboStatus.Text)
                    .Parameters.AddWithValue("?", cboAccesslevel.Text)
                    .Parameters.AddWithValue("?", txtlastname.Text)
                    .Parameters.AddWithValue("?", txtfirstname.Text)
                    .Parameters.AddWithValue("?", cborole.Text)
                    .Parameters.AddWithValue("?", txtusername.Text)
                End With


                Console.WriteLine("Executing query with parameters:")
                Console.WriteLine("@username: " & txtusername.Text)
                Console.WriteLine("@Password: " & txtpassword.Text)

                cmd.ExecuteNonQuery()

                MsgBox("Users Record Successfully Updated", MsgBoxStyle.Information)
            End Using
        Catch ex As Exception
            MsgBox("Error updating user record: " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub


    Private Sub txtusername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusername.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) AndAlso e.KeyChar <> "-" Then
            e.Handled = True
        End If
    End Sub





    Private Sub TextFirstname_TextChanged(sender As Object, e As EventArgs) Handles txtfirstname.TextChanged
        txtfirstname.Text = New String(txtfirstname.Text.Where(Function(c) Char.IsLetter(c) OrElse Char.IsWhiteSpace(c)).ToArray())
        txtfirstname.SelectionStart = txtfirstname.Text.Length
    End Sub

    Private Sub TextLastname_TextChanged(sender As Object, e As EventArgs) Handles txtlastname.TextChanged
        txtlastname.Text = New String(txtlastname.Text.Where(Function(c) Char.IsLetter(c) OrElse Char.IsWhiteSpace(c)).ToArray())
        txtlastname.SelectionStart = txtlastname.Text.Length
    End Sub
End Class