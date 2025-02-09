Imports System.Data.OleDb

Public Class AddProducts
    Private Sub AddProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtprodcode.Text = GenerateNewProductCode()

    End Sub

    Private Sub savedata()

        sql = "INSERT INTO tblProducts (ProductCode, ProdName, ProdDescription, Category, Amount, Quantity, CriticalLevel, Status) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        cmd = New OleDbCommand(sql, cn)

        With cmd
            .Parameters.AddWithValue("@0", txtprodcode.Text)
            .Parameters.AddWithValue("@1", txtproductname.Text)
            .Parameters.AddWithValue("@2", txtproddes.Text)
            .Parameters.AddWithValue("@3", txtcategory.Text)
            .Parameters.AddWithValue("@4", txtamount.Text)
            .Parameters.AddWithValue("@5", txtquantity.Text)
            .Parameters.AddWithValue("@6", txtcrit.Text)
            .Parameters.AddWithValue("@7", cbostatus.Text)
            .ExecuteNonQuery()
        End With
        txtprodcode.Clear()
        txtproductname.Clear()
        txtproddes.Clear()
        txtcategory.Text = Nothing
        txtamount.Clear()
        txtquantity.Clear()
        txtcrit.Clear()
        cbostatus.Text = Nothing

        MsgBox("Product Record Successfully Saved", MsgBoxStyle.Information)

    End Sub

    Private Sub ButtonDiscard_Click(sender As Object, e As EventArgs) Handles ButtonDiscard.Click
        Me.Close()
    End Sub

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        savedata()
    End Sub

    Private Function GenerateNewProductCode() As String
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\POSdb.accdb"
        Dim query As String = "SELECT MAX(ProductCode) FROM tblProducts"

        Using cn As New OleDbConnection(connectionString)
            Using cmd As New OleDbCommand(query, cn)
                Try
                    cn.Open()
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot DBNull.Value Then
                        Dim newProductCode As Integer = Convert.ToInt32(result) + 1
                        Return newProductCode.ToString("D6")
                    Else
                        Return "100000"
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error generating new product code: " & ex.Message)
                End Try
            End Using
        End Using
        Return "100000"
    End Function



End Class