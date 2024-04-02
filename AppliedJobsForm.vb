Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class AppliedJobsForm
    Inherits Form
    Private cmbFilterStatus As ComboBox
    Private btnFilter As Button
    Private dgvJobApplications As DataGridView
    Private WithEvents btnEditJob As Button ' Button for editing job applications

    Public Sub New()
        MyBase.New()
        InitializeFormControls()
        ' Optionally, you might want to call your filter or load method here to populate the DataGridView when the form loads.
    End Sub

    Private Sub InitializeFormControls()
        Me.Size = New Size(800, 500) ' Adjusted form size to accommodate new button
        Me.Text = "Applied Jobs Report"

        ' ComboBox for Status Filter
        cmbFilterStatus = New ComboBox With {
            .Location = New Point(20, 20),
            .Size = New Size(200, 24)
        }
        cmbFilterStatus.Items.AddRange(New String() {"All", "Pending", "Rejected", "Interviewing"})
        cmbFilterStatus.SelectedIndex = 0 ' Default to "All"
        Me.Controls.Add(cmbFilterStatus)

        ' Filter Button
        btnFilter = New Button With {
            .Text = "Filter",
            .Location = New Point(230, 20),
            .Size = New Size(75, 24)
        }
        AddHandler btnFilter.Click, AddressOf Me.btnFilter_Click
        Me.Controls.Add(btnFilter)

        ' DataGridView for displaying the job applications
        dgvJobApplications = New DataGridView With {
            .Location = New Point(20, 60),
            .Size = New Size(760, 350),
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        }
        Me.Controls.Add(dgvJobApplications)
        InitializeDataGridView()

        ' Button for editing selected job application
        btnEditJob = New Button With {
            .Text = "Edit Selected Job",
            .Location = New Point(320, 420),
            .Size = New Size(150, 24)
        }
        Me.Controls.Add(btnEditJob)
    End Sub

    Private Sub InitializeDataGridView()
        dgvJobApplications.AutoGenerateColumns = False ' Prevent auto-generation
        dgvJobApplications.Columns.Clear() ' Clear existing columns

        ' Assuming "ID" is a part of your data but you do not want to display it
        dgvJobApplications.Columns.Add(New DataGridViewTextBoxColumn With {.Name = "ID", .HeaderText = "ID", .DataPropertyName = "id", .Visible = False})

        dgvJobApplications.Columns.Add("Company Name", "Company Name")
        dgvJobApplications.Columns.Add("Position Title", "Position Title")
        dgvJobApplications.Columns.Add("Contact Name", "Contact Name")
        dgvJobApplications.Columns.Add("Contact Email", "Contact Email")
        dgvJobApplications.Columns.Add("Location", "Location")
        dgvJobApplications.Columns.Add("Feedback Status", "Feedback Status")
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs)
        Dim statusFilter As String = cmbFilterStatus.SelectedItem.ToString()
        Dim query As String
        If statusFilter = "All" Then
            query = "SELECT id, company_name, position_title, contact_name, contact_email, location, feedback_status FROM job_applications"
        Else
            query = $"SELECT id, company_name, position_title, contact_name, contact_email, location, feedback_status FROM job_applications WHERE feedback_status = '{statusFilter}'"
        End If

        Try
            Using connection As MySqlConnection = DatabaseModule.OpenConnection()
                Dim command As New MySqlCommand(query, connection)
                Dim reader As MySqlDataReader = command.ExecuteReader()
                dgvJobApplications.Rows.Clear() ' Clear existing rows before adding new ones
                While reader.Read()
                    ' The "id" is assumed to be the first column, adjust if your database structure is different
                    dgvJobApplications.Rows.Add(reader("id"), reader("company_name"), reader("position_title"), reader("contact_name"), reader("contact_email"), reader("location"), reader("feedback_status"))
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred fetching the data: {ex.Message}", "Data Fetch Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEditJob_Click(sender As Object, e As EventArgs) Handles btnEditJob.Click
        If dgvJobApplications.CurrentRow IsNot Nothing Then
            Dim selectedRowIndex As Integer = dgvJobApplications.CurrentRow.Index
            If selectedRowIndex >= 0 Then
                Dim jobId As Integer = Convert.ToInt32(dgvJobApplications.Rows(selectedRowIndex).Cells("ID").Value)
                Dim editForm As New EditJobApplicationForm(jobId)
                editForm.ShowDialog()

                btnFilter.PerformClick() ' Refresh the list after editing
            End If
        Else
            MessageBox.Show("Please select a job to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class