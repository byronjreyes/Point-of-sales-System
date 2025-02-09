Imports System.Data.OleDb
Imports System.Net
Imports System.Windows.Forms.AxHost

Public Class UsersPanel
    Private Sub UsersPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub loadaccount()
        Try
            Dim historySql As String = "SELECT Username, Password, AcctStatus, AccessLevel, Lastname, Firstname, Role FROM tblUsers WHERE AccessLevel <> 'Super Admin'"
            cmd = New OleDbCommand(historySql, cn)

            Dim adapter As New OleDbDataAdapter(cmd)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            DataGridView1.DataSource = dataTable

        Catch ex As Exception
            MsgBox("Error loading admin users " & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub TextSearch_TextChanged(sender As Object, e As EventArgs) Handles TextSearch.TextChanged
        searchvoters(TextSearch.Text)
    End Sub



    Private Sub searchvoters(keyword As String)
        Try
            Dim searchsql As String = "SELECT Username, Password, AcctStatus, AccessLevel, Lastname, Firstname, Role FROM tblUsers WHERE (AccessLevel <> 'Super Admin') AND (firstname LIKE '%" & keyword & "%' OR lastname LIKE '%" & keyword & "%' OR Username LIKE '%" & keyword & "%')"
            cmd = New OleDbCommand(searchsql, cn)

            Dim adapter As New OleDbDataAdapter(cmd)
            Dim datatable As New DataTable()
            adapter.Fill(datatable)
            DataGridView1.DataSource = datatable

        Catch ex As Exception
            MsgBox("Error searching voters: " & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        If DataGridView1.SelectedRows.Count > 0 Then

            Dim username As String = DataGridView1.SelectedRows(0).Cells("Username").Value.ToString()
            Dim password As String = DataGridView1.SelectedRows(0).Cells("Password").Value.ToString()
            Dim role As String = DataGridView1.SelectedRows(0).Cells("Role").Value.ToString()

            Dim accesslevel As String = DataGridView1.SelectedRows(0).Cells("AccessLevel").Value.ToString()
            Dim lastName As String = DataGridView1.SelectedRows(0).Cells("Lastname").Value.ToString()
            Dim firstName As String = DataGridView1.SelectedRows(0).Cells("Firstname").Value.ToString()
            Dim accountstatus As String = DataGridView1.SelectedRows(0).Cells("AcctStatus").Value.ToString()



            Dim formodal As New Form
            Try
                Dim votersInfoForm As New UsersInfo(username, password, firstName, lastName, role, accesslevel, accountstatus)
                formodal.StartPosition = FormStartPosition.CenterScreen
                formodal.FormBorderStyle = FormBorderStyle.None
                formodal.Opacity = 0.5D
                formodal.BackColor = Color.Black
                formodal.WindowState = FormWindowState.Maximized
                formodal.TopMost = True
                formodal.Location = Location
                formodal.ShowInTaskbar = False
                formodal.Show()
                votersInfoForm.Owner = formodal
                votersInfoForm.ShowDialog()

            Catch ex As Exception
            Finally
                formodal.Dispose()
            End Try
        End If
    End Sub

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click

        Dim formodal As New Form
        Try
            Dim modal As New AddUsers
            formodal.StartPosition = FormStartPosition.CenterScreen
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5D
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.TopMost = True
            formodal.Location = Location
            formodal.ShowInTaskbar = False
            formodal.Show()
            modal.Owner = formodal
            AddUsers.ShowDialog()

        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try
    End Sub
    Private Sub TextSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextSearch.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) AndAlso e.KeyChar <> "-" Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnreload_Click(sender As Object, e As EventArgs) Handles btnreload.Click
        loadaccount()
    End Sub
End Class