Imports System.ComponentModel

Public Class frm_TimeInOut
    Private Sub btnTimeInOut_Click(sender As Object, e As EventArgs) Handles btnTimeInOut.Click


        Try
            If txtStudentId.Text = "" Then
                MessageBox.Show("Please enter ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                ' Check if the student ID exists in the table_patient
                reloadtxt("SELECT * FROM table_patient WHERE STUDENT_ID = '" & txtStudentId.Text & "'")
                If dt.Rows.Count > 0 Then
                    ' Check if the student has already logged time in and out for the current date
                    reloadtxt("SELECT * FROM db_attendance WHERE STUDENT_ID = '" & txtStudentId.Text & "' AND LOGDATE = '" & Label1.Text & "' AND AM_STATUS='Time In' AND PM_STATUS='Time Out'")
                    If dt.Rows.Count > 0 Then
                        ' If already logged, show a message
                        MessageBox.Show("You have already timed in and out for today", "Already Logged", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        ' Check if the student has logged time in for the current date
                        reloadtxt("SELECT * FROM db_attendance WHERE STUDENT_ID = '" & txtStudentId.Text & "' AND LOGDATE = '" & Label1.Text & "' AND AM_STATUS = 'Time In'")
                        If dt.Rows.Count > 0 Then
                            ' If time in already exists for the student today, log the timeout
                            updatesLogged("UPDATE db_attendance SET TIMEOUT = '" & TimeOfDay & "', PM_STATUS = 'Time Out', MINUTES=TIMEOUT-TIMEIN WHERE STUDENT_ID = '" & txtStudentId.Text & "' AND LOGDATE = '" & Label1.Text & "'")
                            MessageBox.Show("Success timeout", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            ' If no time in exists, log the time in
                            createlogged("INSERT INTO db_attendance(STUDENT_ID, LOGDATE, TIMEIN, AM_STATUS) VALUES('" & txtStudentId.Text & "', '" & Label1.Text & "', '" & TimeOfDay & "', 'Time In')")
                            MessageBox.Show("Success time in", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Else
                    MessageBox.Show("ID not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ReloadAttendance()
        Try
            reload("SELECT CONCAT(L_NAME,' ',F_NAME) AS FULLNAME, LOGDATE, TIMEIN, AM_STATUS, TIMEOUT, PM_STATUS, MINUTES FROM db_attendance INNER JOIN table_patient ON db_attendance.STUDENT_ID = table_patient.STUDENT_ID", DataGridView1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ReloadAttendance()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString("yyyy/M/dd")
    End Sub

    Private Sub frm_TimeInOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frm_TimeInOut_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub
End Class