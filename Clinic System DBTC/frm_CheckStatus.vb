Imports System.ComponentModel

Public Class frm_CheckStatus
    Public Sub ReloadAttendance()
        Try
            reload("SELECT CONCAT(L_NAME, ' ', F_NAME) AS FULLNAME, LOGDATE, COURSE, TIMEIN, TIMEOUT FROM db_attendance INNER JOIN table_patient ON db_attendance.STUDENT_ID = table_patient.STUDENT_ID", DataGridView1)
        Catch ex As Exception
            ' Handle exception
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            reload("SELECT CONCAT(L_NAME, ' ', F_NAME) AS FULLNAME, COURSE, TIMEIN, TIMEOUT FROM db_attendance INNER JOIN table_patient ON db_attendance.STUDENT_ID = table_patient.STUDENT_ID WHERE REASON LIKE '%" & txtSearch.Text & "%' OR CONCAT(L_NAME, ' ', F_NAME) LIKE '%" & txtSearch.Text & "%'", DataGridView1)
        Catch ex As Exception
            ' Handle exception
        End Try
    End Sub

    Private Sub frm_CheckStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        ReloadAttendance()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ReloadAttendance()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label1.Text = Format(Now, "h:mm:ss")
    End Sub

    Private Sub frm_CheckStatus_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub
End Class