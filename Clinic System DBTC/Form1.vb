Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient ' Import MySQL Data Provider

Public Class Form1
    Dim conn As MySqlConnection
    Dim connectionString As String = "server=localhost;userid=root;password=;database=dbclinic"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection(connectionString)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ''UserDashboard.Location = Screen.AllScreens(UBound(Screen.AllScreens)).Bounds.Location + New Point(100, 100)
        ''UserDashboard.Show()


        Dim username As String = txtUname.Text.Trim()
        Dim password As String = txtPass.Text
        ' Dim cbx As String = ComboBox1.Text

        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter username and password.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            conn.Open()

            Using cmd As New MySqlCommand("SELECT `TYPE` FROM logindb WHERE `USERNAME` = @USERNAME AND `PASSWORD` = @PASSWORD", conn)
                cmd.Parameters.AddWithValue("@USERNAME", username)
                cmd.Parameters.AddWithValue("@PASSWORD", password)

                Dim userType As String = Convert.ToString(cmd.ExecuteScalar())

                If userType = "Admin" Then
                    ShowDashboard("Admin Dashboard", username)

                ElseIf userType = "User" Then
                    ShowDashboard("User Dashboard", username)

                ElseIf userType = "Nurse" Then
                    ShowDashboard("Nurse Dashboard", username)


                Else
                    ShowLoginError()

                End If
            End Using
        Catch ex As MySqlException
            ShowLoginError()
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ShowDashboard(dashboardName As String, username As String)


        If dashboardName = "Admin Dashboard" Then
            Dim adminDashboard As New frm_AdminDashboard()
            adminDashboard.AdminMain = username
            adminDashboard.Show()

        ElseIf dashboardName = "User Dashboard" Then
            Dim userDashboard As New frm_UserDashboard()
            userDashboard.UserMain = username
            userDashboard.Show()

        ElseIf dashboardName = "Nurse Dashboard" Then
            Dim NurseDashboard As New frm_NurseDashboard()
            NurseDashboard.NurseMain = username
            NurseDashboard.Show()

        End If

        Me.Hide()

    End Sub

    Private Sub ShowLoginError()
        MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        txtUname.Text = ""
        txtPass.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub
End Class
