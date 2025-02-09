Imports System.Data.OleDb

Public Class UpdateProducts
    Private Sub UpdateProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtprodcode.Enabled = False
        connection()
    End Sub

    Public Sub SetProductInfo(productCode As String, prodName As String, prodDescription As String, category As String, amount As Decimal, quantity As Integer, criticalLevel As Integer, status As String)

        txtprodcode.Text = productCode
        txtproductname.Text = prodName
        txtproddes.Text = prodDescription
        txtcategory.Text = category
        txtamount.Text = amount.ToString()
        txtquantity.Text = quantity.ToString()
        txtcrit.Text = criticalLevel.ToString()
        cbostatus.Text = status
    End Sub

    Private Sub ButtonDiscard_Click(sender As Object, e As EventArgs) Handles ButtonDiscard.Click
        Me.Close()
    End Sub


    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        updatedata()
    End Sub

    Private Sub updatedata()
        Try
            Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\POSdb.accdb")
                cn.Open()

                Dim sql As String = "UPDATE tblProducts SET ProdName=@ProdName, ProdDescription=@ProdDescription, Category=@Category, Amount=@Amount, Quantity=@Quantity, CriticalLevel=@CriticalLevel, Status=@Status WHERE ProductCode=@ProductCode"
                Using cmd As New OleDbCommand(sql, cn)
                    With cmd
                        .Parameters.AddWithValue("@ProdName", txtproductname.Text)
                        .Parameters.AddWithValue("@ProdDescription", txtproddes.Text)
                        .Parameters.AddWithValue("@Category", txtcategory.Text)
                        .Parameters.AddWithValue("@Amount", Decimal.Parse(txtamount.Text))
                        .Parameters.AddWithValue("@Quantity", Integer.Parse(txtquantity.Text))
                        .Parameters.AddWithValue("@CriticalLevel", Integer.Parse(txtcrit.Text))
                        .Parameters.AddWithValue("@Status", cbostatus.Text)
                        .Parameters.AddWithValue("@ProductCode", txtprodcode.Text)

                        .ExecuteNonQuery()
                    End With
                End Using
            End Using


            MsgBox("Product Record Successfully Updated", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("Error updating product record: " & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub


End Class
