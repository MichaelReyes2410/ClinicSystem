Imports System.ComponentModel

Public Class frm_PatientLogBookAdmin
    Dim count As Integer = 0
    Friend resamMain As String

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
                count += 1
                'lblTime.Text = count.ToString()
                create("INSERT INTO table_patient(STUDENT_ID, L_NAME, F_NAME, AGE, COURSE, REASON, TREATMENT)VALUES('" & txtStudentID.Text & "', '" & txtLastname.Text & "', '" & txtFirstname.Text & "', '" & txtAge.Text & "', '" & txtCourse.Text & "', '" & txtReason.Text & "', '" & txtTreatment.Text & "')")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub LoadData()
        Try
            reload("Select * FROM table_patient", DataGridView1)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadData()
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            reloadtxt("UPDATE table_patient SET L_NAME='" & txtLastname.Text & "', F_NAME='" & txtFirstname.Text & "', AGE='" & txtAge.Text & "', COURSE='" & txtCourse.Text & "', REASON='" & txtReason.Text & "', TREATMENT='" & txtTreatment.Text & "' WHERE STUDENT_ID='" & txtStudentID.Text & "' ")
            MessageBox.Show("UPDATE SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            reloadtxt("DELETE FROM table_patient WHERE STUDENT_ID='" & DataGridView1.CurrentRow.Cells(1).Value.ToString() & "' ")
            MessageBox.Show("DELETED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            reload("SELECT * FROM table_patient WHERE L_NAME LIKE'%" & txtSearch.Text & "%' OR COURSE LIKE'%" & txtSearch.Text & "%'", DataGridView1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imgbmp As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(imgbmp, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(imgbmp, 0, 0)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub frm_PatientLogBookAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        Timer2.Start()
    End Sub

    Private Sub frm_PatientLogBookAdmin_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub
End Class