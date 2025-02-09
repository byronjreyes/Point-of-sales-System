Imports System.Data.OleDb
Imports Guna.UI2.WinForms

Public Class ProductsPanel
    Private _loggedInUsername As String
    Public Property LoggedInUsername() As String
        Get
            Return _loggedInUsername
        End Get
        Set(ByVal value As String)
            _loggedInUsername = value
        End Set
    End Property
    Private Sub ProductsPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private currentform As Form = Nothing
    Private Sub GoBackToClientDashboard()
        If currentform IsNot Nothing Then
            currentform.Hide()
        End If
        If Form1.Visible Then
            Form1.Hide()
        End If
        Me.Show()
    End Sub

    Private Sub TextSearch_TextChanged(sender As Object, e As EventArgs) Handles TextSearch.TextChanged
        findproducts(TextSearch.Text)
    End Sub



    Private Sub findproducts(keyword As String)

        Try
            connection()
            Dim searchsql As String = "select ProductCode, ProdName, ProdDescription, Category, Amount, Quantity, CriticalLevel, Status from tblProducts where ProdName like '%" & keyword & "%' or ProductCode like '%" & keyword & "%' or Category like '%" & keyword & "%'"
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
            Dim filtersql As String = "SELECT ProductCode, ProdName, ProdDescription, Category, Amount, Quantity, CriticalLevel, Status FROM tblProducts WHERE Category = @category"
            cmd = New OleDbCommand(filtersql, cn)
            cmd.Parameters.AddWithValue("@category", category)

            Dim adapter As New OleDbDataAdapter(cmd)
            Dim datatable As New DataTable()
            adapter.Fill(datatable)
            DataGridView1.DataSource = datatable
        Catch ex As Exception
            MsgBox("Error filtering products by category: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private PreviousFilter As Guna2Button = Nothing

    Private Sub ButtonFilter_Click(sender As Object, e As EventArgs) Handles ButtonFilterAll.Click, ButtonFilter1st.Click, ButtonFilter4th.Click, ButtonFilter3rd.Click, ButtonFilter2nd.Click, ButtonFilter9th.Click, ButtonFilter8th.Click, ButtonFilter7th.Click, ButtonFilter6th.Click, ButtonFilter5th.Click
        Dim clickedButton As Guna2Button = DirectCast(sender, Guna2Button)

        If (PreviousFilter IsNot Nothing AndAlso clickedButton.Equals(PreviousFilter)) Then Return
        ButtonFilterAll.FillColor = SystemColors.Control
        ButtonFilterAll.ForeColor = SystemColors.ControlDarkDark

        If PreviousFilter IsNot Nothing Then
            PreviousFilter.FillColor = SystemColors.Control
            PreviousFilter.ForeColor = SystemColors.ControlDarkDark
        End If

        clickedButton.FillColor = Color.Gainsboro
        clickedButton.ForeColor = Color.Black
        PreviousFilter = clickedButton

        loadprod()
    End Sub

    Private Sub loadprod()
        If ButtonFilterAll.Equals(PreviousFilter) Then
            loadproducts()
        ElseIf ButtonFilter1st.Equals(PreviousFilter) Then
            filterbycategory("Computer")
        ElseIf ButtonFilter2nd.Equals(PreviousFilter) Then
            filterbycategory("Monitor")
        ElseIf ButtonFilter3rd.Equals(PreviousFilter) Then
            filterbycategory("PSU")
        ElseIf ButtonFilter4th.Equals(PreviousFilter) Then
            filterbycategory("Ram")
        ElseIf ButtonFilter5th.Equals(PreviousFilter) Then
            filterbycategory("Gpu")
        ElseIf ButtonFilter6th.Equals(PreviousFilter) Then
            filterbycategory("Fans")
        ElseIf ButtonFilter7th.Equals(PreviousFilter) Then
            filterbycategory("Motherboard")
        ElseIf ButtonFilter8th.Equals(PreviousFilter) Then
            filterbycategory("SSD")
        ElseIf ButtonFilter9th.Equals(PreviousFilter) Then
            filterbycategory("Case")


        End If
    End Sub


    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim productCode As String = DataGridView1.SelectedRows(0).Cells("ProductCode").Value.ToString()
            Dim prodName As String = DataGridView1.SelectedRows(0).Cells("ProdName").Value.ToString()
            Dim prodDescription As String = DataGridView1.SelectedRows(0).Cells("ProdDescription").Value.ToString()
            Dim category As String = DataGridView1.SelectedRows(0).Cells("Category").Value.ToString()
            Dim amount As Decimal = Convert.ToDecimal(DataGridView1.SelectedRows(0).Cells("Amount").Value)
            Dim quantity As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("Quantity").Value)
            Dim criticalLevel As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("CriticalLevel").Value)
            Dim status As String = DataGridView1.SelectedRows(0).Cells("Status").Value.ToString()

            Dim formModal As New Form()
            Try
                Dim productInfoForm As New ProductInfo(productCode, prodName, prodDescription, category, amount, quantity, criticalLevel, status)
                formModal.StartPosition = FormStartPosition.CenterScreen
                formModal.FormBorderStyle = FormBorderStyle.None
                formModal.Opacity = 0.5D
                formModal.BackColor = Color.Black
                formModal.WindowState = FormWindowState.Maximized
                formModal.TopMost = True
                formModal.Location = Location
                formModal.ShowInTaskbar = False
                formModal.Show()
                productInfoForm.Owner = formModal
                productInfoForm.ShowDialog()
            Catch ex As Exception
                MessageBox.Show("Error displaying product information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                formModal.Dispose()
            End Try
        End If
    End Sub

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        Dim formodal As New Form
        Try
            Dim modal As New AddProducts
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
            AddProducts.ShowDialog()

        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try
    End Sub

    Private Sub btnreload_Click(sender As Object, e As EventArgs) Handles btnreload.Click
        loadproducts()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub


End Class