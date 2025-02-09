Imports System.Data.OleDb
Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class MainDashboard

    Public ReadOnly Property LoggedInUsername As String
        Get
            Return txtusername.Text
        End Get
    End Property
    Private Function IsSuperAdmin(username As String) As Boolean
        Try
            Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\POSdb.accdb")
                cn.Open()
                Dim sql As String = "SELECT AccessLevel FROM tblUsers WHERE Username = @username"
                Using cmd As New OleDbCommand(sql, cn)
                    cmd.Parameters.Clear() ' Clear existing parameters
                    cmd.Parameters.AddWithValue("@username", username)
                    Dim accessLevel As Object = cmd.ExecuteScalar()

                    If accessLevel IsNot Nothing AndAlso accessLevel IsNot DBNull.Value Then
                        Dim level As String = accessLevel.ToString()
                        Return level = "Super Admin" OrElse level = "Assistant Boss"
                    Else
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking access level: " & ex.Message)
            Return False
        End Try
    End Function




    Private Sub MainDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        userscount()
        productcount()
        CalculateAndDisplayTotal()
        Guna2ShadowForm1.SetShadowForm(Me)
        loadtblusers()
        CalculateAndDisplayMonthlySalesTotal()
        noofmonthlysales()
        nooftodaysales()
        noofcriticallevelsproducts()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldate.Text = Now.ToShortDateString
        lbltime.Text = Now.ToShortTimeString
    End Sub


    Private Sub noofcriticallevelsproducts()
        Try
            connection()

            Dim currentDate As Date = DateTime.Now.Date

            sql = "SELECT COUNT(*) FROM tblProducts WHERE Status = 'Critical Level'"
            cmd = New OleDbCommand(sql, cn)

            Dim totalCriticalProducts As Integer = CInt(cmd.ExecuteScalar())

            lblcriticallevels.Text = totalCriticalProducts.ToString()
        Catch ex As Exception
            MsgBox("Error updating tblProducts count: " & ex.Message, vbCritical)
        End Try
    End Sub


    Private Sub nooftodaysales()
        Try
            connection()

            Dim currentDate As Date = DateTime.Now.Date

            sql = "SELECT COUNT(*) FROM tblTransactions WHERE TransDate = @CurrentDate"
            cmd = New OleDbCommand(sql, cn)
            cmd.Parameters.AddWithValue("@CurrentDate", currentDate)

            Dim totalSales As Integer = CInt(cmd.ExecuteScalar())

            lblnotodaysales.Text = totalSales.ToString()
        Catch ex As Exception
            MsgBox("Error updating tblTransactions count: " & ex.Message, vbCritical)
        End Try
    End Sub



    Private Sub noofmonthlysales()
        Try
            connection()
            Dim currentMonth As Integer = DateTime.Now.Month
            Dim currentYear As Integer = DateTime.Now.Year

            sql = "SELECT COUNT(*) FROM tblTransactions WHERE MONTH(TransDate) = @Month AND YEAR(TransDate) = @Year"
            cmd = New OleDbCommand(sql, cn)
            cmd.Parameters.AddWithValue("@Month", currentMonth)
            cmd.Parameters.AddWithValue("@Year", currentYear)

            Dim totalSales As Integer = CInt(cmd.ExecuteScalar())

            lblnomonthlysales.Text = totalSales.ToString()
        Catch ex As Exception
            MsgBox("Error updating tblTransactions count: " & ex.Message, vbCritical)
        End Try
    End Sub


    Private Sub userscount()
        Try
            connection()
            sql = "SELECT COUNT(*) FROM tblUsers WHERE AccessLevel <> 'Super Admin'"
            cmd = New OleDbCommand(sql, cn)
            Dim totalusers As Integer = CInt(cmd.ExecuteScalar())

            lblUsers.Text = totalusers.ToString()
        Catch ex As Exception
            MsgBox("Error updating tblUsers count: " & ex.Message, vbCritical)
        End Try
    End Sub



    Private Sub productcount()
        Try
            connection()
            sql = "SELECT COUNT(*) FROM tblProducts"
            cmd = New OleDbCommand(sql, cn)
            Dim totalusers As Integer = CInt(cmd.ExecuteScalar())

            lblprods.Text = totalusers.ToString()
        Catch ex As Exception
            MsgBox("Error updating tblUsers count: " & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub CalculateAndDisplayTotal()
        Try
            connection()

            Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\POSdb.accdb")
                cn.Open()

                ' Get today's date in the format "M/d/yyyy"
                Dim today As String = DateTime.Today.ToString("M/d/yyyy")

                Dim sql As String = "SELECT Sum(TotalAmount) AS GrandTotal FROM qrySales WHERE TransDate = @Today"

                Using cmd As New OleDbCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@Today", today)

                    Dim total As Object = cmd.ExecuteScalar()

                    If total IsNot DBNull.Value Then
                        labeltotal.Text = "₱" & Convert.ToDecimal(total).ToString("N2")
                    Else
                        labeltotal.Text = "₱0.00"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving total: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub CalculateAndDisplayMonthlySalesTotal()
        Try
            Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\POSdb.accdb")
                cn.Open()

                ' Get the latest transaction date
                Dim latestTransDate As DateTime
                Dim latestTransDateSql As String = "SELECT TOP 1 TransDate FROM qrySales ORDER BY TransDate DESC"
                Using cmdDate As New OleDbCommand(latestTransDateSql, cn)
                    Dim dateResult As Object = cmdDate.ExecuteScalar()
                    If dateResult IsNot DBNull.Value Then
                        latestTransDate = Convert.ToDateTime(dateResult)
                    End If
                End Using

                ' Calculate monthly sales total for the latest month
                Dim sqlMonthly As String = "SELECT Sum(TotalAmount) AS MonthlyTotal FROM qrySales WHERE MONTH(TransDate) = MONTH(@LatestTransDate) AND YEAR(TransDate) = YEAR(@LatestTransDate)"
                Using cmdMonthly As New OleDbCommand(sqlMonthly, cn)
                    cmdMonthly.Parameters.AddWithValue("@LatestTransDate", latestTransDate)
                    Dim monthlyTotal As Object = cmdMonthly.ExecuteScalar()

                    If monthlyTotal IsNot DBNull.Value Then
                        labelMonthlyTotal.Text = "₱" & Convert.ToDecimal(monthlyTotal).ToString("N2")
                    Else
                        labelMonthlyTotal.Text = "₱0.00"
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error retrieving monthly total: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    Private Sub backtomain()
        If currentform IsNot Nothing Then
            currentform.Hide()
            currentform = Nothing
            userscount()
            loadtblusers()
        End If

        If Form1.Visible Then
            Form1.Hide()
        End If
        Me.Show()
    End Sub



    Private currentform As Form = Nothing

    Private Sub openchildform(childForm As Form)
        If currentform IsNot Nothing Then currentform.Close()
        currentform = childForm

        If TypeOf childForm Is ProductsPanel Then
            Dim productsPanel As ProductsPanel = DirectCast(childForm, ProductsPanel)
            productsPanel.LoggedInUsername = LoggedInUsername
        ElseIf TypeOf childForm Is SettingsPanel Then
            Dim productsPanel As SettingsPanel = DirectCast(childForm, SettingsPanel)
            productsPanel.LoggedInUsername = LoggedInUsername
        End If


        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        mainform.Controls.Add(childForm)
        mainform.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
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

    Private Sub btnlogout_Click_1(sender As Object, e As EventArgs) Handles btnlogout.Click
        If MsgBox("Logout Account?", vbQuestion + vbYesNo) = vbYes Then
            MsgBox("Good bye" & txtusername.Text & " " & " Have a nice day!!", vbInformation, "Logut User")
            ' Insert activity log for logout
            InsertActivityLog(txtusername.Text, "Logout", DateTime.Now)
            Me.Hide()
            Form1.Show()
        End If
    End Sub
    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        If IsSuperAdmin(LoggedInUsername) Then
            backtomain()
            openchildform(New ProductsPanel())
        Else
            MessageBox.Show("Only Manager can open this.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btnSettings_Click_1(sender As Object, e As EventArgs) Handles btnSettings.Click
        backtomain()
        openchildform(New SettingsPanel())
    End Sub


    Private Sub ButtonHome_Click_1(sender As Object, e As EventArgs) Handles ButtonHome.Click
        backtomain()
    End Sub



    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        backtomain()
        openchildform(New Reports())
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click

        backtomain()
        openchildform(New UsersPanel())
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub loadtblusers()
        Try
            Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\POSdb.accdb")
                cn.Open()

                ' Select users excluding those with 'Super Admin' access level
                Dim sql As String = "SELECT Username, TypeActivity, LogDateTime from tblActivitylogs"

                Dim usersDataTable As New DataTable()

                Using adapter As New OleDbDataAdapter(sql, cn)
                    adapter.Fill(usersDataTable)
                End Using

                ' Clear existing columns in DataGridView
                DataGridView1.Columns.Clear()

                ' Add custom columns
                Dim usernameColumn As New DataGridViewTextBoxColumn()
                usernameColumn.HeaderText = "Username"
                usernameColumn.DataPropertyName = "Username"
                DataGridView1.Columns.Add(usernameColumn)

                Dim activityColumn As New DataGridViewTextBoxColumn()
                activityColumn.HeaderText = "Activity"
                activityColumn.DataPropertyName = "TypeActivity"
                DataGridView1.Columns.Add(activityColumn)

                Dim logDateTimeColumn As New DataGridViewTextBoxColumn()
                logDateTimeColumn.HeaderText = "Log DateTime"
                logDateTimeColumn.DataPropertyName = "LogDateTime"
                DataGridView1.Columns.Add(logDateTimeColumn)

                ' Set the data source
                DataGridView1.DataSource = usersDataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnSettings_MouseEnter(sender As Object, e As EventArgs) Handles btnSettings.MouseEnter
        btnSettings.Size = New Size(45, 32)
    End Sub

    Private Sub btnSettings_MouseLeave(sender As Object, e As EventArgs) Handles btnSettings.MouseLeave
        btnSettings.Size = New Size(38, 27)
    End Sub

    Private Sub ButtonHome_MouseEnter(sender As Object, e As EventArgs) Handles ButtonHome.MouseEnter
        ButtonHome.Size = New Size(45, 32)
    End Sub

    Private Sub ButtonHome_MouseLeave(sender As Object, e As EventArgs) Handles ButtonHome.MouseLeave
        ButtonHome.Size = New Size(38, 27)
    End Sub

    Private Sub btnProducts_MouseEnter(sender As Object, e As EventArgs) Handles btnProducts.MouseEnter
        btnProducts.Size = New Size(45, 32)
    End Sub

    Private Sub btnProducts_MouseLeave(sender As Object, e As EventArgs) Handles btnProducts.MouseLeave
        btnProducts.Size = New Size(38, 27)
    End Sub

    Private Sub btnReports_MouseEnter(sender As Object, e As EventArgs) Handles btnReports.MouseEnter
        btnReports.Size = New Size(45, 32)
    End Sub

    Private Sub btnReports_MouseLeave(sender As Object, e As EventArgs) Handles btnReports.MouseLeave
        btnReports.Size = New Size(38, 27)
    End Sub

    Private Sub btnUsers_MouseEnter(sender As Object, e As EventArgs) Handles btnUsers.MouseEnter
        btnUsers.Size = New Size(45, 32)
    End Sub

    Private Sub btnUsers_MouseLeave(sender As Object, e As EventArgs) Handles btnUsers.MouseLeave
        btnUsers.Size = New Size(38, 27)
    End Sub
    Private Sub btnreturn_MouseEnter(sender As Object, e As EventArgs) Handles btninquiry.MouseEnter
        btninquiry.Size = New Size(45, 32)
    End Sub

    Private Sub btnreturn_MouseLeave(sender As Object, e As EventArgs) Handles btninquiry.MouseLeave
        btninquiry.Size = New Size(38, 27)
    End Sub
    Private Sub btnlogout_MouseEnter(sender As Object, e As EventArgs) Handles btnlogout.MouseEnter
        btnlogout.Size = New Size(45, 32)
    End Sub

    Private Sub btnlogout_MouseLeave(sender As Object, e As EventArgs) Handles btnlogout.MouseLeave
        btnlogout.Size = New Size(38, 27)
    End Sub

    Private Sub inforeports_Click(sender As Object, e As EventArgs) Handles inforeports.Click
        backtomain()
        openchildform(New Reports())
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        backtomain()
        openchildform(New Reports())
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        If IsSuperAdmin(LoggedInUsername) Then
            backtomain()
            openchildform(New ProductsPanel())
        Else
            MessageBox.Show("Only Manager can open this.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        backtomain()
        openchildform(New Reports())
    End Sub

    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        backtomain()
        openchildform(New UsersPanel())
    End Sub

    Private Sub Guna2GradientButton6_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton6.Click
        backtomain()
        openchildform(New ProductsPanel())
    End Sub

    Private Sub btninquiry_Click(sender As Object, e As EventArgs) Handles btninquiry.Click
        backtomain()
        openchildform(New Inquirypanel())
    End Sub


End Class