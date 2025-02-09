Imports System.Data.OleDb

Public Class frmPayment

    Private _callingForm As frmPOS

    Public WriteOnly Property CallingForm As frmPOS
        Set(value As frmPOS)
            _callingForm = value
        End Set
    End Property
    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadMOP()
    End Sub
    Private Sub loadMOP()
        sql = "Select distinct PaymentMode from tblPaymentMode where status='1'"

        cmd = New OleDbCommand(sql, cn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cboMOP.DataSource = dt
        cboMOP.DisplayMember = "PaymentMode"

    End Sub

    Private Sub cboMOP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMOP.SelectedIndexChanged
        If cboMOP.Text = "Cash" Then
            txtRefNo.ReadOnly = True
            txtAmountPaid.Clear()
            txtAmountPaid.Enabled = True
        Else
            txtRefNo.ReadOnly = False
            txtAmountPaid.Text = lblGrandTotal.Text
            txtChange.Text = "0.00"
            txtAmountPaid.Enabled = False

        End If
    End Sub

    Private Sub txtAmountPaid_TextChanged(sender As Object, e As EventArgs) Handles txtAmountPaid.TextChanged
        Dim change As Double
        change = Val(txtAmountPaid.Text) - Val(lblGrandTotal.Text)
        txtChange.Text = Format(Val(change), "0.00")

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If Val(txtAmountPaid.Text) < Val(lblGrandTotal.Text) Then
            MsgBox("Insufficient Payment", vbCritical, "Payment Error")
        Else
            _callingForm.lblAmountPaid.Text = Me.txtAmountPaid.Text
            _callingForm.lblChange.Text = Me.txtChange.Text
            _callingForm.lblMOP.Text = Me.cboMOP.Text
            _callingForm.lblRefNo.Text = Me.txtRefNo.Text
            Me.Close()
        End If
    End Sub


    Private Sub btnplus_Click(sender As Object, e As EventArgs) Handles btnplus.Click
        Dim a As String = InputBox("Enter Mode of payment")
        sql = "Insert into tblPaymentmode(paymentmode,status)values(@paymentmode,@status)"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@paymentmode", a)
            .Parameters.AddWithValue("@status", "1")
            .ExecuteNonQuery()

        End With
    End Sub
End Class