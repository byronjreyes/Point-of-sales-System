Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.Globalization

Public Class printerchecker
    Private WithEvents printDocument As New PrintDocument()
    Private Sub printerchecker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFinalizedResults()
    End Sub
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\POSdb.accdb"


    Private Sub LoadFinalizedResults()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT SD.ProductCode, SD.Prodname, SD.Qty, SD.Total, SD.Amount, S.TransDate, S.TransTime, S.TotalAmount, S.VAT, S.CashierName, S.Discount, S.AmountPaid, S.AmountChange " &
                                  "FROM qrySalesDetails AS SD INNER JOIN qrySales AS S ON SD.TransNo = S.TransNo"

                Using command As New OleDbCommand(query, connection)
                    Using reader As OleDbDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim resultControl As New ResultPrintchecker()

                            resultControl.lbltransno.Text = reader("TransNo").ToString()
                            resultControl.lblproductcode.Text = reader("ProductCode").ToString()
                            resultControl.lblproductname.Text = reader("Prodname").ToString()
                            resultControl.lblquantity.Text = reader("Qty").ToString()
                            resultControl.lbltotal.Text = reader("Total").ToString()
                            resultControl.lblamount.Text = reader("Amount").ToString()

                            resultControl.lblDate.Text = reader("TransDate").ToString()
                            resultControl.lblTime.Text = reader("TransTime").ToString()
                            resultControl.lblVat.Text = reader("VAT").ToString()
                            resultControl.lblCashiername.Text = reader("CashierName").ToString()
                            resultControl.lblDiscount.Text = reader("Discount").ToString()
                            resultControl.lblAmountPaid.Text = reader("AmountPaid").ToString()
                            resultControl.lblAmountChange.Text = reader("AmountChange").ToString()

                            flowLayoutPanelResults.Controls.Add(resultControl)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading finalized results: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ButtonDiscard_Click(sender As Object, e As EventArgs) Handles ButtonDiscard.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            Dim printPreviewDialog As New PrintPreviewDialog()

            printPreviewDialog.Document = printDocument

            printPreviewDialog.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Error printing document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub printDocument_PrintPage(sender As Object, e As PrintPageEventArgs) Handles printDocument.PrintPage
        Dim g As Graphics = e.Graphics

        printDocument.DefaultPageSettings.PaperSize = New PaperSize("Custom", 425, 440)

        Dim totalHeight As Integer = 0
        For Each control As Control In flowLayoutPanelResults.Controls
            totalHeight += control.Height
        Next

        Dim scale As Single = 0.5F * e.MarginBounds.Height / totalHeight

        Dim bitmap As New Bitmap(flowLayoutPanelResults.Width, totalHeight)
        flowLayoutPanelResults.DrawToBitmap(bitmap, New Rectangle(0, 0, flowLayoutPanelResults.Width, totalHeight))

        e.Graphics.DrawImage(bitmap, e.MarginBounds.Left, e.MarginBounds.Top, bitmap.Width * scale, bitmap.Height * scale)

        e.HasMorePages = False
    End Sub


End Class