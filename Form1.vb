Imports System.Data.OleDb

''Login form
Public Class Form1


    Private Sub ButtonVisibility_Click(sender As Object, e As EventArgs) Handles Guna2Button1.CheckedChanged
        txtpassword.UseSystemPasswordChar = Not txtpassword.UseSystemPasswordChar
    End Sub
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        connection()

        Dim username As String = txtusername.Text
        Dim password As String = txtpassword.Text

        If ValidateForm() Then
            Try
                If Not cn.State = ConnectionState.Open Then
                    cn.Open()
                End If

                Dim selectSql As String = "SELECT ID, Username, Password, LoginAttempts, AcctStatus, AccessLevel, Role FROM tblUsers WHERE Username = @username;"
                cmd = New OleDbCommand(selectSql, cn)
                cmd.Parameters.AddWithValue("@username", username)
                dr = cmd.ExecuteReader()

                If dr.Read() Then
                    Dim userid = dr("ID")
                    Dim dbUsername As String = dr("Username")
                    Dim dbPassword As String = dr("Password")
                    Dim loginAttempts As Integer = CInt(dr("LoginAttempts"))
                    Dim acctStatus As String = dr("AcctStatus")
                    Dim accessLevel As String = dr("AccessLevel")
                    Dim role As String = dr("Role")

                    If acctStatus = "Disabled" Then
                        lblValidationErrors.Text = "- Account is disabled. Please contact the admin to enable your account."
                    ElseIf password = dbPassword Then
                        vbinformationpanel.setAlert("Login Success", vbinformationpanel.AlertType.Success)
                        InsertActivityLog(username, "Login", DateTime.Now)
                        If role = "Cashier" Then
                            Dim frmPOS As New frmPOS()
                            frmPOS.lblCashier.Text = txtusername.Text
                            frmPOS.Show()
                        Else
                            Dim mainDashboard As New MainDashboard()
                            mainDashboard.txtusername.Text = txtusername.Text
                            mainDashboard.Show()
                        End If

                        Me.Hide()
                        txtpassword.Clear()

                        Dim updateSql As String = "UPDATE tblUsers SET LoginAttempts = 0 WHERE ID = @userid;"
                        cmd = New OleDbCommand(updateSql, cn)
                        cmd.Parameters.AddWithValue("@userid", userid)
                        cmd.ExecuteNonQuery()
                    Else
                        loginAttempts += 1
                        lblValidationErrors.Text = "- Incorrect password. You have " & (3 - loginAttempts) & " attempts left."
                        txtpassword.Select()

                        InsertActivityLog(username, "Login Attempt", DateTime.Now)

                        Dim updateSql As String = "UPDATE tblUsers SET LoginAttempts = @loginAttempts WHERE ID = @userid;"
                        cmd = New OleDbCommand(updateSql, cn)
                        cmd.Parameters.AddWithValue("@loginAttempts", loginAttempts)
                        cmd.Parameters.AddWithValue("@userid", userid)
                        cmd.ExecuteNonQuery()

                        If loginAttempts >= 3 Then
                            lblValidationErrors.Text = "- Account is locked. Please contact the admin to unlock your account."
                            txtusername.Select()
                            txtpassword.Clear()

                            Dim lockSql As String = "UPDATE tblUsers SET AcctStatus = 'Disabled' WHERE ID = @userid;"
                            cmd = New OleDbCommand(lockSql, cn)
                            cmd.Parameters.AddWithValue("@userid", userid)
                            cmd.ExecuteNonQuery()
                        End If
                    End If
                Else
                    lblValidationErrors.Text = "- User not found and Password error."
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                dr.Close()
            End Try
        End If
    End Sub



    Private Function ValidateForm() As Boolean
        Dim UsernameLength = txtusername.Text.Length
        Dim PasswordLength = txtpassword.Text.Length

        PanelUsernameStatus.BackColor = SystemColors.Control
        PanelPasswordStatus.BackColor = SystemColors.Control

        Dim ValidationError As String = ""

        If UsernameLength < 6 AndAlso txtusername.Text.Trim() <> "" Then
            ValidationError += "- Username must have at least 6 characters" & Environment.NewLine
            PanelUsernameStatus.BackColor = Color.Red
        ElseIf txtusername.Text.Trim() = "" Then
            ValidationError += "- Username is required" & Environment.NewLine
            PanelUsernameStatus.BackColor = Color.Red
        End If

        If PasswordLength < 6 AndAlso txtpassword.Text.Trim() <> "" Then
            ValidationError += "- Password must have at least 6 characters" & Environment.NewLine
            PanelPasswordStatus.BackColor = Color.Red
            txtpassword.Select()
        ElseIf txtpassword.Text.Trim() = "" Then
            ValidationError += "- Password is required" & Environment.NewLine
            PanelPasswordStatus.BackColor = Color.Red
        End If

        If ValidationError <> "" Then
            lblValidationErrors.Text = ValidationError
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim vbInformationPanel As New vbinformationpanel()

        If ValidateForm() Then
            sql = "Select * from tblUsers where Username='" & txtusername.Text & "' and Password='" & txtpassword.Text & "'"
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                vbInformationPanel.setAlert("Login Success", vbinformationpanel.AlertType.Success)
                ' Insert activity log
                InsertActivityLog(txtusername.Text, "Login", DateTime.Now)
            Else
                vbInformationPanel.setAlert("Login failed", vbinformationpanel.AlertType.Error)
            End If

            dr.Close()
        End If
    End Sub

    Private Sub InsertActivityLog(username As String, activityType As String, logDateTime As DateTime)
        Dim insertLogSql As String = "INSERT INTO tblActivitylogs (Username, TypeActivity, LogDateTime) VALUES (@username, @activityType, @logDateTime);"
        cmd = New OleDbCommand(insertLogSql, cn)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@activityType", activityType)

        ' Use OleDbDbType.Date for Date/Time fields
        cmd.Parameters.Add("@logDateTime", OleDbType.Date).Value = logDateTime

        cmd.ExecuteNonQuery()
    End Sub



End Class
