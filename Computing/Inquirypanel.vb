Imports System.Data.OleDb
Imports Guna.UI2.WinForms

Public Class Inquirypanel
    Private Sub Inquirypanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadproducts()
        connection()
    End Sub



    Public Sub loadproducts()
        Try
            connection()
            Dim historySql As String = "SELECT ProductCode, ProdName, ProdDescription, Category, Amount, Quantity, CriticalLevel, Status FROM tblProducts"
            cmd = New OleDbCommand(historySql, cn)

            Dim adapter As New OleDbDataAdapter(cmd)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            DataGridView1.DataSource = dataTable

        Catch ex As Exception
            MsgBox("Error loading Products " & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub TextSearch_TextChanged(sender As Object, e As EventArgs) Handles TextSearch.TextChanged
        findproducts(TextSearch.Text)
    End Sub



    Private Sub findproducts(keyword As String)

        Try
            connection()
            Dim searchsql As String = "select ProductCode, ProdName, ProdDescription, Category, Amount, Quantity, CriticalLevel, Status from tblProducts where ProdName like '%" & keyword & "%' or ProductCode like '%" & keyword & "%' or Category like '%" & keyword & "%' or Status like '%" & keyword & "%'"
            cmd = New OleDbCommand(searchsql, cn)

            Dim adapter As New OleDbDataAdapter(cmd)
            Dim datatable As New DataTable()
            adapter.Fill(datatable)
            DataGridView1.DataSource = datatable

        Catch ex As Exception
            MsgBox("error searching products: " & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub filterbycategory(category As String)
        Try
            Dim filtersql As String = "SELECT ProductCode, ProdName, ProdDescription, Category, Amount, Quantity, CriticalLevel, Status FROM tblProducts WHERE Status = @status"
            cmd = New OleDbCommand(filtersql, cn)
            cmd.Parameters.AddWithValue("@status", category)

            Dim adapter As New OleDbDataAdapter(cmd)
            Dim datatable As New DataTable()
            adapter.Fill(datatable)
            DataGridView1.DataSource = datatable
        Catch ex As Exception
            MsgBox("Error filtering products by status: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private PreviousFilter As Guna2Button = Nothing

    Private Sub ButtonFilter_Click(sender As Object, e As EventArgs) Handles ButtonFilterAll.Click, ButtonFilter1st.Click, ButtonFilter3rd.Click, ButtonFilter2nd.Click
        Dim clickedButton As Guna2Button = DirectCast(sender, Guna2Button)

        If (PreviousFilter IsNot Nothing AndAlso clickedButton.Equals(PreviousFilter)) Then Return
        ButtonFilterAll.FillColor = SystemColors.Control
        ButtonFilterAll.ForeColor = SystemColors.ControlDarkDark

        If PreviousFilter IsNot Nothing Then
            PreviousFilter.FillColor = SystemColors.Control
            PreviousFilter.ForeColor = SystemColors.ControlDarkDark
        End If

        clickedButton.FillColor = Color.FromArgb(30, 30, 42)
        clickedButton.ForeColor = Color.White
        PreviousFilter = clickedButton

        loadprod()
    End Sub

    Private Sub loadprod()
        If ButtonFilterAll.Equals(PreviousFilter) Then
            loadproducts()
        ElseIf ButtonFilter1st.Equals(PreviousFilter) Then
            filterbycategory("Available")
        ElseIf ButtonFilter2nd.Equals(PreviousFilter) Then
            filterbycategory("Critical Level")
        ElseIf ButtonFilter3rd.Equals(PreviousFilter) Then
            filterbycategory("Out of Stock")



        End If
    End Sub
    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        If DataGridView1.SelectedRows.Count > 0 Then
            Try

                Dim productCode As String = DataGridView1.SelectedRows(0).Cells("ProductCode").Value.ToString()
                Dim prodName As String = DataGridView1.SelectedRows(0).Cells("ProdName").Value.ToString()
                Dim prodDescription As String = DataGridView1.SelectedRows(0).Cells("ProdDescription").Value.ToString()
                Dim category As String = DataGridView1.SelectedRows(0).Cells("Category").Value.ToString()
                Dim amount As Decimal = Convert.ToDecimal(DataGridView1.SelectedRows(0).Cells("Amount").Value)
                Dim quantity As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("Quantity").Value)
                Dim criticalLevel As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("CriticalLevel").Value)
                Dim status As String = DataGridView1.SelectedRows(0).Cells("Status").Value.ToString()


            Catch ex As Exception
                MessageBox.Show("Error displaying product information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally

            End Try
        End If
    End Sub
End Class