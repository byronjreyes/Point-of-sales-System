Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.Runtime.CompilerServices

Public Class frmPOS
    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
        getTransactionNo()
        InitializePrintDocument()
        InitializeListView()
    End Sub
    Private WithEvents printDocument As New PrintDocument()
    Private Sub InitializePrintDocument()
        AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage
    End Sub
    Private Sub InitializeListView()
        ListView2.Columns.Add("Product Code", 100)
        ListView2.Columns.Add("Product Name", 200)
        ListView2.Columns.Add("Amount", 100)
        ListView2.Columns.Add("Quantity", 80)
        ListView2.Columns.Add("Total", 100)

        ListView2.View = View.Details
        ListView2.GridLines = True
        ListView2.FullRowSelect = True
    End Sub
    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim printFont As New Font("Arial", 10)
        Dim lineHeight As Integer = 20
        Dim yPos As Integer = 100

        Dim sf As New StringFormat()

        e.Graphics.DrawString("Transaction No: " & lblTransNo.Text, printFont, Brushes.Black, 100, yPos)
        yPos += lineHeight
        e.Graphics.DrawString("Date: " & lbldate.Text, printFont, Brushes.Black, 100, yPos)
        yPos += lineHeight
        e.Graphics.DrawString("Time: " & lbltime.Text, printFont, Brushes.Black, 100, yPos)
        yPos += lineHeight
        e.Graphics.DrawString("Cashier: " & lblCashier.Text, printFont, Brushes.Black, 100, yPos)
        yPos += lineHeight

        Dim column1X As Integer = 100
        Dim column2X As Integer = 200
        Dim column3X As Integer = 400
        Dim column4X As Integer = 500
        Dim column5X As Integer = 600

        e.Graphics.DrawLine(Pens.Black, column1X, yPos, column5X, yPos)

        Dim headerFormat As New StringFormat()
        headerFormat.Alignment = StringAlignment.Center

        Dim rectProductCode As New RectangleF(column1X, yPos, column2X - column1X, lineHeight)
        Dim rectProductName As New RectangleF(column2X, yPos, column3X - column2X, lineHeight)
        Dim rectAmount As New RectangleF(column3X, yPos, column4X - column3X, lineHeight)
        Dim rectQuantity As New RectangleF(column4X, yPos, column5X - column4X, lineHeight)
        Dim rectTotal As New RectangleF(column5X, yPos, 700 - column5X, lineHeight)

        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectProductCode))
        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectProductName))
        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectAmount))
        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectQuantity))
        e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectTotal))

        e.Graphics.DrawString("Product Code", printFont, Brushes.Black, rectProductCode, headerFormat)
        e.Graphics.DrawString("Product Name", printFont, Brushes.Black, rectProductName, headerFormat)
        e.Graphics.DrawString("Amount", printFont, Brushes.Black, rectAmount, headerFormat)
        e.Graphics.DrawString("Quantity", printFont, Brushes.Black, rectQuantity, headerFormat)
        e.Graphics.DrawString("Total", printFont, Brushes.Black, rectTotal, headerFormat)

        yPos += lineHeight

        e.Graphics.DrawLine(Pens.Black, column1X, yPos, column5X, yPos)


        sf.Alignment = StringAlignment.Center

        For Each item As ListViewItem In ListView2.Items
            rectProductCode = New RectangleF(column1X, yPos, column2X - column1X, lineHeight)
            rectProductName = New RectangleF(column2X, yPos, column3X - column2X, lineHeight)
            rectAmount = New RectangleF(column3X, yPos, column4X - column3X, lineHeight)
            rectQuantity = New RectangleF(column4X, yPos, column5X - column4X, lineHeight)
            rectTotal = New RectangleF(column5X, yPos, 700 - column5X, lineHeight)

            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectProductCode))
            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectProductName))
            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectAmount))
            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectQuantity))
            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rectTotal))

            e.Graphics.DrawString(item.SubItems(0).Text, printFont, Brushes.Black, rectProductCode, sf)
            e.Graphics.DrawString(item.SubItems(1).Text, printFont, Brushes.Black, rectProductName)
            e.Graphics.DrawString(item.SubItems(2).Text, printFont, Brushes.Black, rectAmount, sf)
            e.Graphics.DrawString(item.SubItems(3).Text, printFont, Brushes.Black, rectQuantity, sf)
            e.Graphics.DrawString(item.SubItems(4).Text, printFont, Brushes.Black, rectTotal, sf)

            yPos += lineHeight
        Next

        e.Graphics.DrawLine(Pens.Black, column1X, yPos, column5X, yPos)

        yPos += lineHeight
        Dim boldPrintFon1t As New Font("Arial", 10, FontStyle.Bold)
        e.Graphics.DrawString("Total: ₱" & lbltotal.Text, boldPrintFon1t, Brushes.Black, 600, yPos)

        e.Graphics.DrawString("Discount: " & lblDisc.Text, printFont, Brushes.Black, 100, yPos)
        yPos += lineHeight

        Dim boldPrintFon1t2 As New Font("Arial", 10, FontStyle.Bold)
        e.Graphics.DrawString("Amount Paid:₱ " & lblAmountPaid.Text, boldPrintFon1t2, Brushes.Black, 600, yPos)
        yPos += lineHeight

        Dim boldPrintFont As New Font("Arial", 10, FontStyle.Bold)
        e.Graphics.DrawString("Change:₱ " & lblChange.Text, boldPrintFont, Brushes.Black, 600, yPos)
        yPos += lineHeight
        e.Graphics.DrawString("VAT: " & lblVAT.Text, printFont, Brushes.Black, 100, yPos)
        yPos += lineHeight
        e.Graphics.DrawString("Vatable Sales: " & lblVSales.Text, printFont, Brushes.Black, 100, yPos)
        yPos += lineHeight


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldate.Text = Now.ToShortDateString
        lbltime.Text = Now.ToShortTimeString
    End Sub

    Private Sub getTransactionNo()
        sql = "Select TransNo from tblTransactions order by TransNo desc"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblTransNo.Text = Val(dr(0)) + 1
        Else
            lblTransNo.Text = 1000001
        End If
    End Sub

    Private Sub txtcode_TextChanged(sender As Object, e As EventArgs) Handles txtcode.TextChanged

        connection()
        sql = "Select prodName,Amount,Quantity,CriticalLevel,Status from qryProducts where productCode='" & txtcode.Text & "' and Quantity>'0'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtprodname.Text = dr(0) 'product name
            txtAmt.Text = dr(1) 'amount
            txtQty1.Text = dr(2) 'quantity
            txtCrit.Text = dr(3)
            txtStatus.Text = dr(4) 'status
        Else

            cleartxt()
        End If
    End Sub

    Private Sub cleartxt()
        txtprodname.Clear()
        txtAmt.Clear()
        txtCrit.Clear()
        txtQty1.Clear()
        txtStatus.Text = "******"
    End Sub

    Dim l As ListViewItem
    Dim amount As Double
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim a As String = InputBox("Enter number of products?", "Quantity")

        If String.IsNullOrEmpty(a) Or Not IsNumeric(a) Then
            MsgBox("Please enter a valid number of products")
        Else
            Dim quantityToAdd As Integer = CInt(a)
            Dim currentQty As Integer = Val(txtQty1.Text)
            Dim newQty As Integer = currentQty - quantityToAdd

            If newQty < 0 Then
                MsgBox("Please restock the product", MsgBoxStyle.Exclamation, "Restock Required")
                Exit Sub
            ElseIf newQty = 0 Then
                Dim proceed As DialogResult = MessageBox.Show("Warning: This will reduce the quantity to 0. Do you want to proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If proceed = DialogResult.No Then
                    Exit Sub
                End If
            End If

            txtQty1.Text = newQty

            amount = Decimal.Parse(txtAmt.Text) * quantityToAdd

            UpdateProductDetails(txtcode.Text, quantityToAdd)

            ' Add the item to ListView with SubItems for each column
            l = Me.ListView2.Items.Add(txtcode.Text)
            l.SubItems.Add(txtprodname.Text)
            l.SubItems.Add(txtAmt.Text)
            l.SubItems.Add(quantityToAdd.ToString())
            l.SubItems.Add(amount.ToString("0.00"))


            If newQty = 0 Then
                txtStatus.Text = "Out of Stock"
            ElseIf newQty < txtCrit.Text Then
                txtStatus.Text = "Critical Level"
            Else
                txtStatus.Text = "Available"
            End If

            GetTotal()
            GetTotalItem()
            getVAT()
        End If
    End Sub


    Private Sub GetTotal()
        Const col As Integer = 4
        Dim total As Decimal = 0
        Dim lvsi As ListViewItem.ListViewSubItem

        For i As Integer = 0 To ListView2.Items.Count - 1
            lvsi = ListView2.Items(i).SubItems(col)
            total += Decimal.Parse(lvsi.Text)
        Next

        lbltotal.Text = total.ToString("0.00")
    End Sub


    Private Sub GetTotalItem()
        Const col As Integer = 3
        Dim total As Integer
        Dim lvsi As ListViewItem.ListViewSubItem
        For i As Integer = 0 To ListView2.Items.Count - 1
            lvsi = ListView2.Items(i).SubItems(col)
            total += Double.Parse(lvsi.Text)

        Next
        lblTotalitems.Text = Val(total)
    End Sub
    Private Sub UpdateProductDetailsRemove(productCode As String, newQuantity As Integer)

        Dim updateProductSql As String = "UPDATE tblProducts SET Quantity = ? WHERE ProductCode = ?"
        Dim updateProductCmd As New OleDbCommand(updateProductSql, cn)
        updateProductCmd.Parameters.AddWithValue("?", newQuantity)

        updateProductCmd.Parameters.AddWithValue("?", productCode)
        updateProductCmd.ExecuteNonQuery()
    End Sub

    Private Sub UpdateProductDetails(productCode As String, quantityChange As Integer)
        Dim updateProductSql As String = "UPDATE tblProducts SET Quantity = Quantity - ? WHERE ProductCode = ?"
        Dim updateProductCmd As New OleDbCommand(updateProductSql, cn)
        updateProductCmd.Parameters.AddWithValue("?", quantityChange)
        updateProductCmd.Parameters.AddWithValue("?", productCode)
        updateProductCmd.ExecuteNonQuery()
    End Sub

    Private Sub UpdateProductDetailscancel(productCode As String, quantityChange As Integer)
        Dim updateProductSql As String = "UPDATE tblProducts SET Quantity = Quantity + ? WHERE ProductCode = ?"
        Dim updateProductCmd As New OleDbCommand(updateProductSql, cn)
        updateProductCmd.Parameters.AddWithValue("?", quantityChange)
        updateProductCmd.ExecuteNonQuery()
    End Sub

    Private Sub btnRemoved_Click(sender As Object, e As EventArgs) Handles btnRemoved.Click
        If MsgBox("Removed Product?", vbQuestion + vbYesNo) = vbYes Then
            If ListView2.Items.Count = 0 Then
                MsgBox("No Products on the list", vbCritical, "Product Error")
            Else
                If ListView2.SelectedItems.Count > 0 Then
                    Dim lvalue As Integer = Integer.Parse(ListView2.SelectedItems(0).SubItems(3).Text)
                    Dim newQty As Integer = lvalue + Val(txtQty1.Text)
                    txtQty1.Text = newQty
                    UpdateProductDetailsRemove(ListView2.FocusedItem.Text, newQty)
                    ListView2.Items.Remove(ListView2.FocusedItem)
                    If Val(txtQty1.Text) > Val(txtCrit.Text) Then
                        txtStatus.Text = "Available"
                    End If
                    GetTotal()
                    GetTotalItem()
                    getVAT()
                End If
            End If
            lblVAT.Text = "0.00"
            lblVSales.Text = "0.00"
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Cancel Transaction?", vbQuestion + vbYesNo) = vbYes Then
            For Each item As ListViewItem In ListView2.Items
                Dim quantityChange As Integer = Val(item.SubItems(3).Text)
                UpdateProductDetailscancel(item.Text, quantityChange)
            Next

            ResetText()
            cleartxt()
            ListView2.Items.Clear()
            resetcurrency()
        End If
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        frmPayment.Show()
        frmPayment.CallingForm = Me
        frmPayment.lblGrandTotal.Text = Me.lbltotal.Text
    End Sub

    Private Sub getVAT()

        If Double.TryParse(lbltotal.Text, Nothing) Then
            Dim totalAmount As Double = CDbl(lbltotal.Text)
            Dim vatRate As Double = 0.12

            Dim vatableSales As Double = totalAmount / (1 + vatRate)
            Dim vatAmount As Double = totalAmount - vatableSales

            lblVSales.Text = Format(vatAmount, "0.00")
            lblVAT.Text = Format(vatableSales, "0.00")
        Else
            MsgBox("Invalid total amount for VAT calculation.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub cboDiscount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDiscount.SelectedIndexChanged
        Dim originalTotal, discount, newtotal As Double

        originalTotal = Val(lbltotal.Text)

        discount = originalTotal * 0.2
        lblDisc.Text = String.Format("{0:0.00}", discount)

        newtotal = originalTotal - discount
        lbltotal.Text = String.Format("{0:0.00}", newtotal)
        lblVAT.Text = "0.00"
        lblVSales.Text = "0.00"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            connection()

            If MsgBox("Save Transaction?", vbQuestion + vbYesNo) = vbYes Then
                If Val(lblAmountPaid.Text) < Val(lbltotal.Text) Then
                    MsgBox("Insufficient Amount Paid", vbCritical, "Please Re-Enter Payment")
                Else
                    ''Saving transaction
                    sql = "INSERT INTO tblTransactions (TransNo, TransDate, TransTime, TotalAmount, Vat, VatableSales, Discount, DiscountType, CashierName) " &
                    "VALUES (@TransNo, @TransDate, @TransTime, @TotalAmount, @Vat, @VatableSales, @Discount, @DiscountType, @CashierName)"
                    cmd = New OleDbCommand(sql, cn)
                    With cmd
                        .Parameters.AddWithValue("@TransNo", lblTransNo.Text)
                        .Parameters.AddWithValue("@TransDate", lbldate.Text)
                        .Parameters.AddWithValue("@TransTime", lbltime.Text)
                        .Parameters.AddWithValue("@TotalAmount", lbltotal.Text)
                        .Parameters.AddWithValue("@Vat", lblVAT.Text)
                        .Parameters.AddWithValue("@VatableSales", lblVSales.Text)
                        .Parameters.AddWithValue("@Discount", lblDisc.Text)
                        .Parameters.AddWithValue("@DiscountType", cboDiscount.Text)
                        .Parameters.AddWithValue("@CashierName", lblCashier.Text)
                        .ExecuteNonQuery()
                    End With

                    ''saving details

                    For Each i As ListViewItem In ListView2.Items
                        sql = "INSERT INTO tblTransactionDetails (TransNo, ProductCode, Amount, Qty, Total) " &
        "VALUES (@TransNo, @ProductCode, @Amount, @Qty, @Total)"
                        cmd = New OleDbCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@TransNo", lblTransNo.Text)
                        cmd.Parameters.AddWithValue("@ProductCode", i.Text)
                        cmd.Parameters.AddWithValue("@Amount", i.SubItems(2).Text)
                        cmd.Parameters.AddWithValue("@Qty", i.SubItems(3).Text)
                        cmd.Parameters.AddWithValue("@Total", i.SubItems(4).Text)
                        cmd.ExecuteNonQuery()

                        ' Update product status and critical level in the database
                        If Val(txtQty1.Text) <= 5 And txtStatus.Text = "Critical Level" Then
                            UpdateProductStatusAndCriticalLevel(i.Text, "Critical Level", 5)
                        ElseIf Val(txtQty1.Text) = 0 Then
                            UpdateProductStatusAndCriticalLevel(i.Text, "Out of Stock", 0)
                        End If
                    Next


                    'paymentts
                    sql = "INSERT INTO tblPayments (TransNo, TotalAmount, AmountPaid, AmountChange, MOP, RefNo) " &
                    "VALUES (@TransNo, @TotalAmount, @AmountPaid, @AmountChange, @MOP, @RefNo)"
                    cmd = New OleDbCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@TransNo", lblTransNo.Text)
                    cmd.Parameters.AddWithValue("@TotalAmount", lbltotal.Text)
                    cmd.Parameters.AddWithValue("@AmountPaid", lblAmountPaid.Text)
                    cmd.Parameters.AddWithValue("@AmountChange", lblChange.Text)
                    cmd.Parameters.AddWithValue("@MOP", lblMOP.Text)
                    cmd.Parameters.AddWithValue("@RefNo", lblRefNo.Text)
                    cmd.ExecuteNonQuery()


                    Dim printDialog As New PrintDialog()
                    If printDialog.ShowDialog() = DialogResult.OK Then
                        Dim printPreviewDialog As New PrintPreviewDialog()
                        printPreviewDialog.Document = printDocument
                        printPreviewDialog.ShowDialog()
                    End If

                    MsgBox("Transaction Successfully Saved", vbInformation, "Saved")

                    ListView2.Items.Clear()
                    resetcurrency()
                End If
            End If
            getTransactionNo()
        Catch ex As Exception
            ' Handle exceptions
        End Try
    End Sub

    Private Sub UpdateProductStatusAndCriticalLevel(productCode As String, newStatus As String, newCriticalLevel As Integer)
        ' Update product status and critical level in the database
        Dim updateStatusSql As String = "UPDATE tblProducts SET Status = ?, CriticalLevel = ? WHERE ProductCode = ?"
        Dim updateStatusCmd As New OleDbCommand(updateStatusSql, cn)
        updateStatusCmd.Parameters.AddWithValue("?", newStatus)
        updateStatusCmd.Parameters.AddWithValue("?", newCriticalLevel)
        updateStatusCmd.Parameters.AddWithValue("?", productCode)
        updateStatusCmd.ExecuteNonQuery()
    End Sub

    Private Sub resetcurrency()
        lblAmountPaid.Text = "0.00"
        lblVAT.Text = "0.00"
        lblVSales.Text = "0.00"
        lblTotalitems.Text = "0.00"
        lblMOP.Text = "*******"
        lblDisc.Text = "0.00"
        lblRefNo.Text = "*******"
        lbltotal.Text = "0.00"
        lblChange.Text = "0.00"
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If MsgBox("Logout Account?", vbQuestion + vbYesNo) = vbYes Then
            MsgBox("Good bye" & lblCashier.Text & " " & " Have a nice day!!", vbInformation, "Logut User")
            Me.Hide()
            Form1.Show()
        End If
    End Sub


End Class