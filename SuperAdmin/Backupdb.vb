Imports System.IO

Public Class Backupdb
    Private Sub ButtonDiscard_Click(sender As Object, e As EventArgs) Handles ButtonDiscard.Click
        Me.Close()
    End Sub

    Private Sub Backupdb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnbackup.Click
        Try
            Dim sourceDatabasePath As String = "C:\Users\Admin\Desktop\finals-banag\POSSYSTEM\IPT-Reyes-Final\POS-FINAL-REYES\bin\x64\Debug\POSdb.accdb"
            Dim backupFolder As String = "C:\Users\Admin\Desktop\finals-banag\POSSYSTEM\IPT-Reyes-Final\POS-FINAL-REYES\bin\x64\Backup"
            Dim backupFileName As String = "POSdb_Backup.accdb"

            If Not Directory.Exists(backupFolder) Then
                Directory.CreateDirectory(backupFolder)
            End If

            Dim backupFilePath As String = Path.Combine(backupFolder, backupFileName)

            File.Copy(sourceDatabasePath, backupFilePath, True)

            MessageBox.Show("Backup completed successfully.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblBackupNote.Text = "Kindly ensure that the file is renamed as 'POSdb.accdb' without appending " & Environment.NewLine & " 'Backup' at the conclusion."
        Catch ex As Exception
            MessageBox.Show("Backup failed. Error: " & ex.Message, "Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class