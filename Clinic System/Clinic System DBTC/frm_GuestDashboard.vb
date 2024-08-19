Imports System.ComponentModel

Public Class frm_GuestDashboard
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            ' Check if any of the textboxes are empty
            If String.IsNullOrWhiteSpace(txtFacultyID.Text) OrElse
           String.IsNullOrWhiteSpace(txtLastname.Text) OrElse
           String.IsNullOrWhiteSpace(txtFirstname.Text) OrElse
           String.IsNullOrWhiteSpace(txtAge.Text) OrElse
           String.IsNullOrWhiteSpace(txtDepartment.Text) OrElse
           String.IsNullOrWhiteSpace(txtReason.Text) Then
                MessageBox.Show("Please fill in all fields before adding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'count += 1
                'lblTime.Text = count.ToString()
                create("INSERT INTO patient_record_staff(faculty_id, l_name, f_name, department, age, reason, treatment)VALUES('" & txtFacultyID.Text & "', '" & txtLastname.Text & "', '" & txtFirstname.Text & "', '" & txtDepartment.Text & "', '" & txtAge.Text & "', '" & txtReason.Text & "', '" & txtTreatment.Text & "')")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            reloadtxt("UPDATE patient_record_staff SET l_name='" & txtLastname.Text & "', f_name='" & txtFirstname.Text & "', department='" & txtDepartment.Text & "', age='" & txtAge.Text & "', reason='" & txtReason.Text & "', treatment='" & txtTreatment.Text & "' WHERE faculty_id='" & txtFacultyID.Text & "' ")
            MessageBox.Show("UPDATE SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFacultyID.Clear()
        txtLastname.Clear()
        txtFirstname.Clear()
        txtDepartment.Clear()
        txtAge.Clear()
        txtReason.Clear()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            reload("SELECT * FROM patient_record_staff WHERE l_name LIKE'%" & txtSearch.Text & "%' OR department LIKE'%" & txtSearch.Text & "%'", DataGridView1)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        'txtID.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtFacultyID.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        txtLastname.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        txtFirstname.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        txtDepartment.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        txtAge.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        txtReason.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        txtTreatment.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
    End Sub
    Public Sub LoadData()
        Try
            reload("Select * FROM patient_record_staff", DataGridView1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadData()
    End Sub

    Private Sub frm_GuestDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frm_GuestDashboard_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub
End Class