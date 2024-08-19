Imports System.ComponentModel

Public Class frm_UserDashboard
    Public Property UserMain As String


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

    Private Sub SaveChanges()
        ' Save changes in the current panel
    End Sub

    Private Sub DiscardChanges()
        ' Discard changes in the current panel
    End Sub

    ' Event handlers for panel navigation


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ''   NavigateToPanel(New recordForm())
    End Sub


    Private Function CheckUnsavedChanges() As Boolean
        ' Check if there are unsaved changes in the current panel
        ' Return True if there are unsaved changes, False otherwise
        Return False
    End Function

    Private Sub btnBed_Click(sender As Object, e As EventArgs) Handles btnBed.Click
        NavigateToPanel(New frm_CheckStatus())
    End Sub




    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Log out and return to the login form
            Me.Hide()
            Dim loginForm As New Form1()
            loginForm.Show()
        End If
    End Sub

    Private Sub btnAddPnt_Click(sender As Object, e As EventArgs) Handles btnAddPnt.Click
        NavigateToPanel(New frm_AddLogForm())
    End Sub

    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        NavigateToPanel(New frm_GuestDashboard())
    End Sub

    Private Sub frm_UserDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowPanel(New frm_MainDashboard())
    End Sub

    Private Sub frm_UserDashboard_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub
End Class