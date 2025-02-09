Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.Globalization
Imports CrystalDecisions
Public Class Reports
    Dim dataTable As New DataTable()

    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CalculateAndDisplayTotal()
        LoadSalesDetailsData()
        fromdatepicker.Value = DateTime.Now
        todatepicker.Value = DateTime.Now
    End Sub



    Private Sub CalculateAndDisplayTotal()
        Try
            Dim fromDate As String = fromdatepicker.Value.ToString("MM/dd/yyyy")
            Dim toDate As String = todatepicker.Value.ToString("MM/dd/yyyy")

            Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\POSdb.accdb")
                cn.Open()

                Dim sql As String = "SELECT Sum(TotalAmount) AS GrandTotal FROM qrySales WHERE TransDate BETWEEN #" & fromDate & "# AND #" & toDate & "#"

                Using cmd As New OleDbCommand(sql, cn)
                    Dim total As Object = cmd.ExecuteScalar()

                    If total IsNot DBNull.Value Then
                        Labeltotal.Text = "Total Sales: " & Convert.ToDecimal(total).ToString("C", CultureInfo.CreateSpecificCulture("en-PH"))
                    Else
                        Labeltotal.Text = "Total Sales: ₱0.00"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving total: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim transnumber As String = DataGridView1.Rows(e.RowIndex).Cells("TransNo").Value.ToString()

            Dim formModal As New Form()
            Try
                Dim salesDetailsForm As New SalesDetails(transnumber)
                formModal.StartPosition = FormStartPosition.CenterScreen
                formModal.FormBorderStyle = FormBorderStyle.None

                formModal.TopMost = True
                formModal.Location = Location
                formModal.ShowInTaskbar = False
                formModal.Show()
                salesDetailsForm.Owner = formModal
                salesDetailsForm.ShowDialog()
            Catch ex As Exception
                MessageBox.Show("Error displaying sales details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                formModal.Dispose()
            End Try
        End If
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        Try
            Dim fromDate As String = fromdatepicker.Value.ToString("MM/dd/yyyy")
            Dim toDate As String = todatepicker.Value.ToString("MM/dd/yyyy")

            Dim sql As String = "SELECT * FROM qrySales WHERE TransDate BETWEEN #" & fromDate & "# AND #" & toDate & "#"

            Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\POSdb.accdb")
                cn.Open()

                Using adapter As New OleDbDataAdapter(sql, cn)
                    dataTable.Clear()
                    adapter.Fill(dataTable)
                End Using
            End Using

            DataGridView1.DataSource = dataTable

            CalculateAndDisplayTotal()

        Catch ex As Exception
            MessageBox.Show("Error loading sales details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Dim printDocument As New PrintDocument()


    Private Sub LoadSalesDetailsData()
        Try
            Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\POSdb.accdb")
                cn.Open()

                Dim sql As String = "SELECT * FROM qrySales"
                Dim salesDataTable As New DataTable()
                Using adapter As New OleDbDataAdapter(sql, cn)
                    adapter.Fill(salesDataTable)

                    DataGridView1.DataSource = salesDataTable
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading sales details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnprintofrmprint_Click(sender As Object, e As EventArgs) Handles btnprintofrmprint.Click
        AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage

        Dim printPreviewDialog As New PrintPreviewDialog()
        printPreviewDialog.Document = printDocument
        printPreviewDialog.ShowDialog()
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim printFontHeader As New Font("Arial", 12, FontStyle.Bold)
        Dim printFontTableHeader As New Font("Arial", 9, FontStyle.Bold)
        Dim printFontTableData As New Font("Arial", 9)
        Dim lineHeight As Single = printFontTableData.GetHeight() + 34
        Dim xPosition As Single = e.MarginBounds.Left
        Dim yPosition As Single = e.MarginBounds.Top
        Dim count As Integer = 0

        Dim companyName As String = "POS SYSTEM"
        Dim companyAddress As String = "Km. 30 National Road, Tunasan, Muntinlupa City"

        e.Graphics.DrawString(companyName, printFontHeader, Brushes.Black, xPosition, yPosition)
        yPosition += lineHeight
        e.Graphics.DrawString(companyAddress, printFontTableData, Brushes.Black, xPosition, yPosition)
        yPosition += 2 * lineHeight

        ' Include Date Pickers
        Dim fromDate As String = "From: " & fromdatepicker.Value.ToShortDateString()
        Dim toDate As String = "To: " & todatepicker.Value.ToShortDateString()

        yPosition += lineHeight
        e.Graphics.DrawString(fromDate, printFontHeader, Brushes.Black, xPosition, yPosition)
        yPosition += lineHeight
        e.Graphics.DrawString(toDate, printFontHeader, Brushes.Black, xPosition, yPosition)
        yPosition += lineHeight
        e.Graphics.DrawString("" & Labeltotal.Text, printFontHeader, Brushes.Black, xPosition, yPosition)
        yPosition += lineHeight
        yPosition += lineHeight



        Dim rect As New RectangleF(xPosition, yPosition, 0, 0)

        Dim tableHeight As Single = 23

        Dim selectedColumns As String() = {"TransNo", "TransDate", "TotalAmount", "VAT", "Discount", "DiscountType", "AmountPaid", "AmountChange", "CashierName"}

        Dim tableWidth As Single = 0
        For Each columnName As String In selectedColumns
            tableWidth += DataGridView1.Columns(columnName).Width
        Next

        tableHeight = lineHeight

        For Each columnName As String In selectedColumns
            rect.Width = DataGridView1.Columns(columnName).Width
            rect.Height = lineHeight
            e.Graphics.DrawRectangle(Pens.Black, rect.Left, rect.Top, rect.Width, rect.Height)
            Dim stringFormat As New StringFormat()
            stringFormat.Alignment = StringAlignment.Center
            stringFormat.LineAlignment = StringAlignment.Center
            e.Graphics.DrawString(DataGridView1.Columns(columnName).HeaderText, printFontTableHeader, Brushes.Black, rect, stringFormat)
            rect.X += rect.Width
            count += 1
        Next

        count = 0
        yPosition += lineHeight

        For Each row As DataGridViewRow In DataGridView1.Rows
            rect.X = xPosition
            rect.Y = yPosition
            rect.Height = lineHeight

            For Each columnName As String In selectedColumns
                rect.Width = DataGridView1.Columns(columnName).Width
                e.Graphics.DrawRectangle(Pens.Black, rect.Left, rect.Top, rect.Width, rect.Height)
                Dim stringFormat As New StringFormat()
                stringFormat.Alignment = StringAlignment.Center
                stringFormat.LineAlignment = StringAlignment.Center
                e.Graphics.DrawString(row.Cells(columnName).Value.ToString(), printFontTableData, Brushes.Black, rect, stringFormat)
                rect.X += rect.Width
            Next

            count = 0
            yPosition += lineHeight
            tableHeight += lineHeight
        Next

        Dim totalTableHeight As Single = yPosition - e.MarginBounds.Top

        e.HasMorePages = False
    End Sub


    Private Sub fromdatepicker_ValueChanged(sender As Object, e As EventArgs) Handles fromdatepicker.ValueChanged

    End Sub

    Private Sub todatepicker_ValueChanged(sender As Object, e As EventArgs) Handles todatepicker.ValueChanged

    End Sub

    Private Sub Labeltotal_Click(sender As Object, e As EventArgs) Handles Labeltotal.Click

    End Sub
End Class
