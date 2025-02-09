Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.Globalization

Public Class SalesDetails
    Dim passedTransNumber As String
    Dim printDocument As New PrintDocument()

    Public Sub New(transNumber As String)
        InitializeComponent()
        passedTransNumber = transNumber
    End Sub

    Private Sub SalesDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labeltransnumber.Text = passedTransNumber
        LoadProductSalesDetails(passedTransNumber)
    End Sub

    Private Sub LoadProductSalesDetails(transNumber As String)
        Try
            Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\POSdb.accdb")
                cn.Open()
                Dim sql As String = $"SELECT TransDate, ProductCode, Prodname, Amount, Qty, Total FROM qrySalesDetails WHERE TransNo = '{transNumber}'"
                Dim salesDataTable As New DataTable()

                Using adapter As New OleDbDataAdapter(sql, cn)
                    adapter.Fill(salesDataTable)
                End Using
                DataGridViewSalesDetails.DataSource = salesDataTable

                Dim totalSales As Decimal = 0
                Dim totalQuantity As Integer = 0

                For Each row As DataRow In salesDataTable.Rows
                    totalSales += Convert.ToDecimal(row("Total"))
                    totalQuantity += Convert.ToInt32(row("Qty"))
                Next
                LabelTotalSales.Text = $"Total Sales: {totalSales.ToString("C", CultureInfo.CreateSpecificCulture("en-PH"))}"
                LabelTotalQuantity.Text = $"Total Items: {totalQuantity}"
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading product sales details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage
        Dim printPreviewDialog As New PrintPreviewDialog()
        printPreviewDialog.Document = printDocument
        printPreviewDialog.ShowDialog()
    End Sub
    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim printFontHeader As New Font("Arial", 10, FontStyle.Bold)
        Dim printFontTableHeader As New Font("Arial", 10, FontStyle.Bold)
        Dim printFontTableData As New Font("Arial", 10)
        Dim lineHeight As Single = printFontTableData.GetHeight() + 34
        Dim xPosition As Single = e.MarginBounds.Left
        Dim yPosition As Single = e.MarginBounds.Top
        Dim count As Integer = 0

        Dim companyName As String = "POS SYSTEM"
        Dim companyAddress As String = "Km. 30 National Road, Tunasan, Muntinlupa City"

        e.Graphics.DrawString(companyName, printFontHeader, Brushes.Black, xPosition, yPosition)
        yPosition += lineHeight
        e.Graphics.DrawString(companyAddress, printFontTableData, Brushes.Black, xPosition, yPosition)
        yPosition += 3 * lineHeight

        Dim tableWidth As Single = 19
        Dim tableHeight As Single = 23
        Dim cellPadding As Single = 21
        Dim rect As New RectangleF(xPosition, yPosition, 0, 0)

        For Each column As DataGridViewColumn In DataGridViewSalesDetails.Columns
            tableWidth += column.Width
        Next

        tableHeight = lineHeight

        For Each column As DataGridViewColumn In DataGridViewSalesDetails.Columns
            rect.Width = column.Width
            rect.Height = lineHeight
            e.Graphics.DrawRectangle(Pens.Black, rect.Left, rect.Top, rect.Width, rect.Height)
            Dim stringFormat As New StringFormat()
            stringFormat.Alignment = StringAlignment.Center
            stringFormat.LineAlignment = StringAlignment.Center
            e.Graphics.DrawString(column.HeaderText, printFontTableHeader, Brushes.Black, rect, stringFormat)
            rect.X += rect.Width
            count += 1
        Next

        count = 0
        yPosition += lineHeight

        For Each row As DataGridViewRow In DataGridViewSalesDetails.Rows
            rect.X = xPosition
            rect.Y = yPosition
            rect.Height = lineHeight

            For Each cell As DataGridViewCell In row.Cells
                rect.Width = DataGridViewSalesDetails.Columns(count).Width
                e.Graphics.DrawRectangle(Pens.Black, rect.Left, rect.Top, rect.Width, rect.Height)
                Dim stringFormat As New StringFormat()
                stringFormat.Alignment = StringAlignment.Center
                stringFormat.LineAlignment = StringAlignment.Center
                e.Graphics.DrawString(cell.Value.ToString(), printFontTableData, Brushes.Black, rect, stringFormat)
                rect.X += rect.Width
                count += 1
            Next

            count = 0
            yPosition += lineHeight
            tableHeight += lineHeight
        Next

        Dim totalTableHeight As Single = yPosition - e.MarginBounds.Top

        Dim totalSalesLabel As String = LabelTotalSales.Text
        Dim totalQuantityLabel As String = LabelTotalQuantity.Text
        Dim totalLabelsHeight As Single = 3 * lineHeight + totalTableHeight


        Dim totalLabelsYPosition As Single = e.MarginBounds.Bottom - totalLabelsHeight

        Dim labelFont As New Font("Arial", 12, FontStyle.Bold)

        e.Graphics.DrawString(totalSalesLabel, labelFont, Brushes.Black, xPosition, totalLabelsYPosition)
        e.Graphics.DrawString(totalQuantityLabel, labelFont, Brushes.Black, xPosition, totalLabelsYPosition + lineHeight)

        e.Graphics.DrawString("Thank you for Shopping!", labelFont, Brushes.Black, xPosition, totalLabelsYPosition + 2 * lineHeight)

        e.HasMorePages = False
    End Sub




    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub


End Class