Imports System.ComponentModel

Public Class frm_AddLogForm
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            ' Check if any of the textboxes are empty
            If String.IsNullOrWhiteSpace(txtStudentID.Text) OrElse
           String.IsNullOrWhiteSpace(txtLastname.Text) OrElse
           String.IsNullOrWhiteSpace(txtFirstname.Text) OrElse
           String.IsNullOrWhiteSpace(txtAge.Text) OrElse
           String.IsNullOrWhiteSpace(txtCourse.Text) OrElse
           String.IsNullOrWhiteSpace(txtReason.Text) Then
                MessageBox.Show("Please fill in all fields before adding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                create("INSERT INTO table_patient(STUDENT_ID, L_NAME, F_NAME, AGE, COURSE, REASON, TREATMENT)VALUES('" & txtStudentID.Text & "', '" & txtLastname.Text & "', '" & txtFirstname.Text & "', '" & txtAge.Text & "', '" & txtCourse.Text & "', '" & txtReason.Text & "', '" & txtTreatment.Text & "')")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtStudentID.Clear()
        txtLastname.Clear()
        txtFirstname.Clear()
        txtAge.Clear()
        txtCourse.Clear()
        txtReason.Clear()
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        'txtID.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtStudentID.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        txtLastname.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        txtFirstname.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        txtAge.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        txtCourse.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        txtReason.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        txtTreatment.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
    End Sub

    Public Sub LoadData()
        Try
            reload("Select * FROM table_patient", DataGridView1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frm_AddLogForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub frm_AddLogForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub
End Class