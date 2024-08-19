Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml.XPath
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class frm_AddStudentRecord
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=dbclinic")
    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If FieldsAreNotEmpty() Then
            Dim connectionString As String = "server=localhost;userid=root;password=;database=dbclinic" ' Replace this with your MySQL connection string
            Using conn As New MySqlConnection(connectionString)
                Try
                    conn.Open()
                    Dim query As String = "INSERT INTO patient_record(name, address, street, city, state, contact, p_birth, birthday, height, weight, gender, medical_history, medical_problems, list_medication, list_allergies, others) VALUES (@name, @address, @street, @city, @state, @contact, @p_birth, @birthday, @height, @weight, @gender, @medical_history, @medical_problems, @list_medication, @list_allergies, @others)"
                    Dim command As New MySqlCommand(query, conn)
                    command.Parameters.AddWithValue("@name", txtName.Text)
                    command.Parameters.AddWithValue("@address", txtAddress.Text)
                    command.Parameters.AddWithValue("@street", txtStreet.Text)
                    command.Parameters.AddWithValue("@city", txtCity.Text)
                    command.Parameters.AddWithValue("@state", txtState.Text)
                    command.Parameters.AddWithValue("@contact", txtContact.Text)
                    command.Parameters.AddWithValue("@p_birth", txtBirthPlace.Text)
                    command.Parameters.AddWithValue("@birthday", date_birth.Value) ' Assuming date_birth is a DateTimePicker control
                    command.Parameters.AddWithValue("@height", txtHeight.Text)
                    command.Parameters.AddWithValue("@weight", txtWeight.Text)
                    command.Parameters.AddWithValue("@gender", cmbGender.SelectedItem.ToString())
                    command.Parameters.AddWithValue("@medical_history", txtSignificantMed.Text)
                    command.Parameters.AddWithValue("@medical_problems", txtMedProb.Text)
                    command.Parameters.AddWithValue("@list_medication", txtMedication.Text)
                    command.Parameters.AddWithValue("@list_allergies", txtAllergies.Text)
                    command.Parameters.AddWithValue("@others", txtOtherCond.Text)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error inserting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        Else
            MessageBox.Show("Please fill up all fields. Write NA if none.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function FieldsAreNotEmpty() As Boolean
        Return Not String.IsNullOrWhiteSpace(txtName.Text) AndAlso
            Not String.IsNullOrWhiteSpace(txtAddress.Text) AndAlso
           Not String.IsNullOrWhiteSpace(txtStreet.Text) AndAlso
           Not String.IsNullOrWhiteSpace(txtCity.Text) AndAlso
           Not String.IsNullOrWhiteSpace(txtState.Text) AndAlso
           Not String.IsNullOrWhiteSpace(txtContact.Text) AndAlso
           Not String.IsNullOrWhiteSpace(txtBirthPlace.Text) AndAlso
           Not String.IsNullOrWhiteSpace(txtHeight.Text) AndAlso
           Not String.IsNullOrWhiteSpace(txtWeight.Text) AndAlso
           Not String.IsNullOrWhiteSpace(cmbGender.SelectedItem.ToString()) AndAlso
           Not String.IsNullOrWhiteSpace(txtSignificantMed.Text) AndAlso
           Not String.IsNullOrWhiteSpace(txtMedProb.Text) AndAlso
           Not String.IsNullOrWhiteSpace(txtMedication.Text) AndAlso
           Not String.IsNullOrWhiteSpace(txtAllergies.Text) AndAlso
           Not String.IsNullOrWhiteSpace(txtOtherCond.Text)
    End Function

    Public Sub LoadData()
        Try
            reload("Select * FROM patient_record", DataGridView1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frm_AddStudentRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        'txtID.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        txtAddress.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        txtStreet.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        txtCity.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        txtState.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        txtContact.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        txtBirthPlace.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString(0)
        date_birth.Value = DataGridView1.CurrentRow.Cells(8).Value.ToString()
        txtHeight.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString()
        txtWeight.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString()
        txtGender.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString()
        txtSignificantMed.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString()
        txtMedProb.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString()
        txtMedication.Text = DataGridView1.CurrentRow.Cells(14).Value.ToString()
        txtAllergies.Text = DataGridView1.CurrentRow.Cells(15).Value.ToString()
        txtOtherCond.Text = DataGridView1.CurrentRow.Cells(16).Value.ToString()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            reload("SELECT * FROM patient_record WHERE name LIKE'%" & txtSearch.Text & "%' OR street LIKE'%" & txtSearch.Text & "%'", DataGridView1)
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
End Class