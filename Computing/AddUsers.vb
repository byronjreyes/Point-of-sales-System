Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Threading.Tasks

Public Class AddUsers
    Sub New()
        InitializeComponent()
        DoubleBuffered = True
    End Sub

    Private Sub ButtonDiscard_Click(sender As Object, e As EventArgs) Handles ButtonDiscard.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If ValidateInputs() Then
            savedata()
        Else
            MsgBox("Please fill in all required fields.", vbExclamation, "Validation Error")
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        ' Perform basic validation here
        If String.IsNullOrWhiteSpace(txtfirstname.Text) OrElse
       String.IsNullOrWhiteSpace(txtlastname.Text) OrElse
       String.IsNullOrWhiteSpace(txtusername.Text) OrElse
       String.IsNullOrWhiteSpace(txtpassword.Text) OrElse
       String.IsNullOrWhiteSpace(cborole.Text) OrElse
             String.IsNullOrWhiteSpace(cboStatus.Text) OrElse
       String.IsNullOrWhiteSpace(cboAccesslevel.Text) Then
            Return False
        End If

        Return True
    End Function


    Private Sub savedata()
        Try
            sql = "Insert into tblUsers ([Username],[password], [AcctStatus], [AccessLevel], [Lastname], [Firstname], [Role], [LoginAttempts]) Values (?, ?, ?, ?, ?, ?, ?, ?)"
            cmd = New OleDbCommand(sql, cn)

            With cmd
                .Parameters.AddWithValue("0", txtusername.Text)
                .Parameters.AddWithValue("1", txtpassword.Text)
                .Parameters.AddWithValue("2", cboStatus.Text)
                .Parameters.AddWithValue("3", cboAccesslevel.Text)
                .Parameters.AddWithValue("4", txtlastname.Text)
                .Parameters.AddWithValue("5", txtfirstname.Text)
                .Parameters.AddWithValue("6", cborole.Text)
                .Parameters.AddWithValue("7", 0)

                .ExecuteNonQuery()
            End With

            MsgBox("User added successfully", vbInformation, "Success")
            txtfirstname.Clear()
            txtpassword.Clear()
            cboStatus = Nothing
            cboAccesslevel = Nothing
            txtlastname.Clear()
            txtfirstname.Clear()
            cborole = Nothing
            Me.Close()
        Catch ex As Exception
            MsgBox("Error adding user: " & ex.Message, vbExclamation, "Error")
        End Try
    End Sub

    Private Sub AddUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
    End Sub
    Private _username As String
    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value

            txtusername.Text = value
        End Set
    End Property

End Class
