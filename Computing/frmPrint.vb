

Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class frmPrint
    Private _salesDataTable As DataTable

    ' Modify the constructor to accept a DataTable parameter
    Public Sub New(salesDataTable As DataTable)
        InitializeComponent()

        ' Store the passed DataTable in the private variable
        _salesDataTable = salesDataTable
    End Sub

    Private _salesInfo As List(Of String)

    Public Sub New(salesInfo As List(Of String))
        InitializeComponent()

        ' Store the passed information in the private variable
        _salesInfo = salesInfo
    End Sub
    Private Sub LoadItemstoDatagrid(salesDataTable As DataTable)
        Dim y As Integer
        Try
            ' Clear existing rows
            dgw.Rows.Clear()

            ' Add rows from the DataTable (_salesDataTable)
            For Each row As DataRow In salesDataTable.Rows
                dgw.Rows.Add(row("Qty"), row("Prodname"), row("Amount"), row("Total"))
                dgw.Height += 19
                y += 19
            Next

            ' Adjust layout based on the added rows
            Panel2.Location = New Point(9, 187 + y)
            Panel1.Height += y
            Me.Height += y
            dgw.Height -= 20

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LoadReceiptInfo()
        Try
            sql = "Select CashierName, VAT, TotalAmount, MOP, AmountChange from qrySales where TransNo = @transno"
            connection()
            cmd = New OleDbCommand(sql, cn)
            cmd.Parameters.AddWithValue("@transno", lblTransNo.Text)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                lbltransactions.Text = dr("TransNo")
                lblEmpName.Text = dr("CashierName")
                lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
                lblTime.Text = Date.Now.ToString("hh:mm:ss")
                lblVat.Text = FormatNumber(dr("VAT"))
                lblTotal.Text = FormatNumber(dr("TotalAmount"))
                lblCash.Text = FormatNumber(dr("MOP"))
                lblChange.Text = FormatNumber(dr("AmountChange"))

                Dim salesDataTable As New DataTable()

                For i As Integer = 0 To dr.FieldCount - 1
                    salesDataTable.Columns.Add(dr.GetName(i))
                Next

                Dim dataRow As DataRow = salesDataTable.NewRow()
                For i As Integer = 0 To dr.FieldCount - 1
                    dataRow(i) = dr(i)
                Next
                salesDataTable.Rows.Add(dataRow)

                LoadItemstoDatagrid(salesDataTable)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            dr.Close()
        End Try
    End Sub


    Private Sub frmPrintReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadReceiptInfo()
        PrintDocument1.Print()
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)
        Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub
End Class