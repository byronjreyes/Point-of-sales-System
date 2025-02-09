Public Class ProductInfo
    Public Sub New(productCode As String, prodName As String, prodDescription As String, category As String, amount As Decimal, quantity As Integer, criticalLevel As Integer, status As String)
        InitializeComponent()

        ' Set labels with the passed data
        LabelProductCode.Text = productCode
        LabelProdName.Text = prodName
        LabelProdDescription.Text = prodDescription
        LabelCategory.Text = category
        LabelAmount.Text = amount.ToString()

        LabelQuantity.Text = quantity.ToString()
        LabelCriticalLevel.Text = criticalLevel.ToString()
        LabelStatus.Text = status
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub




    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnUpdateProduct_Click(sender As Object, e As EventArgs) Handles btnupdateproducts.Click

        Dim productCode As String = LabelProductCode.Text
        Dim prodName As String = LabelProdName.Text
        Dim prodDescription As String = LabelProdDescription.Text
        Dim category As String = LabelCategory.Text
        Dim amount As Decimal = Decimal.Parse(LabelAmount.Text)
        Dim quantity As Integer = Integer.Parse(LabelQuantity.Text)
        Dim criticalLevel As Integer = Integer.Parse(LabelCriticalLevel.Text)
        Dim status As String = LabelStatus.Text
        Dim updateForm As New UpdateProducts()
        updateForm.SetProductInfo(productCode, prodName, prodDescription, category, amount, quantity, criticalLevel, status)
        updateForm.ShowDialog()

        Me.Close()
    End Sub


End Class

