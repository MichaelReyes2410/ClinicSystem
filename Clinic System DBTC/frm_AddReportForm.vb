Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class frm_AddReportForm
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim dataset As New DataTable

    Private Sub btnDaily_Click(sender As Object, e As EventArgs) Handles btnDaily.Click
        Try
            reload("SELECT CONCAT(L_NAME,' ',F_NAME) AS FULLNAME, LOGDATE, TIMEIN, AM_STATUS, TIMEOUT, PM_STATUS, MINUTES FROM db_attendance INNER JOIN table_patient ON db_attendance.STUDENT_ID = table_patient.STUDENT_ID WHERE DATE(LOGDATE)=CURDATE()", DataGridView1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnWeekly_Click(sender As Object, e As EventArgs) Handles btnWeekly.Click
        Try
            reload("SELECT CONCAT(L_NAME,' ',F_NAME) AS FULLNAME, LOGDATE, TIMEIN, AM_STATUS, TIMEOUT, PM_STATUS, MINUTES FROM db_attendance INNER JOIN table_patient ON db_attendance.STUDENT_ID = table_patient.STUDENT_ID WHERE WEEK(LOGDATE)=WEEK(NOW())", DataGridView1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMonthly_Click(sender As Object, e As EventArgs) Handles btnMonthly.Click
        Try
            reload("SELECT CONCAT(L_NAME,' ',F_NAME) AS FULLNAME, LOGDATE, TIMEIN, AM_STATUS, TIMEOUT, PM_STATUS, MINUTES FROM db_attendance INNER JOIN table_patient ON db_attendance.STUDENT_ID = table_patient.STUDENT_ID WHERE MONTH(LOGDATE)=MONTH(NOW())", DataGridView1)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=dbclinic"

        Dim reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim query As String
            query = "select * from dbclinic.table_patient"
            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader
            While reader.Read
                Chart1.Series("AGE_VS_REASON").Points.AddXY(reader.GetString("reason"), reader.GetInt32("age"))
            End While
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub frm_AddReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frm_AddReportForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub
End Class