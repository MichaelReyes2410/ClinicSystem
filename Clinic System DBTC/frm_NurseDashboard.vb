Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class frm_NurseDashboard
    Public Property NurseMain As String


    Private Sub ShowPanel(panel As Form)
        ' Clear the existing content of Panel2
        Panel2.Controls.Clear()

        ' Set the panel properties and display it
        panel.TopLevel = False
        panel.FormBorderStyle = FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub NavigateToPanel(panel As Form)
        ' Show a confirmation dialog if the user is about to switch panels and there are unsaved changes (optional)
        If CheckUnsavedChanges() Then
            ' Prompt the user to save or discard changes
            Dim result = MessageBox.Show("You have unsaved changes. Do you want to save them?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                ' Save changes (if applicable)
                SaveChanges()
            ElseIf result = DialogResult.No Then
                ' Discard changes (if applicable)
                DiscardChanges()
            Else
                ' Cancel navigation
                Return
            End If
        End If

        ' Show the selected panel
        ShowPanel(panel)
    End Sub
    Private Function CheckUnsavedChanges() As Boolean
        ' Check if there are unsaved changes in the current panel
        ' Return True if there are unsaved changes, False otherwise
        Return False
    End Function

    ' Sample methods for saving and discarding changes (you should implement these)
    Private Sub SaveChanges()
        ' Save changes in the current panel
    End Sub

    Private Sub DiscardChanges()
        ' Discard changes in the current panel
    End Sub

    Private Sub btnCollege_Click(sender As Object, e As EventArgs) Handles btnCollege.Click
        NavigateToPanel(New frm_TimeInOut())

    End Sub

    Private Sub btnAddPnt_Click(sender As Object, e As EventArgs) Handles btnAddPnt.Click
        NavigateToPanel(New frm_PatientLogBookAdmin())
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        ' Show a confirmation dialog if the user is about to log out (optional)
        Dim result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Log out and return to the login form
            Me.Hide()
            Dim loginForm As New Form1()
            loginForm.Show()
        End If

    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        NavigateToPanel(New frm_AddReportForm())
    End Sub

    Private Sub btnBed_Click(sender As Object, e As EventArgs) Handles btnBed.Click
        frm_AddStudentRecord.Show()
    End Sub

    Private Sub btnBackupDB_Click(sender As Object, e As EventArgs) Handles btnBackupDB.Click
        Dim backp As New SaveFileDialog()
        backp.InitialDirectory = "C:\"
        backp.Title = "BACKUP DATABASE"
        backp.CheckFileExists = False
        backp.CheckPathExists = False
        backp.DefaultExt = "sql"
        backp.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*"
        backp.RestoreDirectory = True

        If backp.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim con As MySqlConnection = New MySqlConnection("server=localhost;userid=root;password=;database=dbclinic;charset=utf8")
                Dim cmd As MySqlCommand = New MySqlCommand()
                cmd.Connection = con
                con.Open()
                Dim mb As MySqlBackup = New MySqlBackup(cmd)
                mb.ExportToFile(backp.FileName)
                con.Close()
                MessageBox.Show("Backup successful", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else ' If the user cancels the dialog
            Return
        End If
    End Sub

    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        NavigateToPanel(New frm_GuestDashboardAdmin())

    End Sub

    Private Sub frm_NurseDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the dashboard with a welcome message
        Label1.Text = "Welcome To Don Bosco Clinic, " & NurseMain & "!"

        ' Show a default panel when the form loads (optional)
        ShowPanel(New frm_MainDashboard())
    End Sub

    Private Sub frm_NurseDashboard_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub
End Class