Public Class DashboardForm
    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Dashboard"
        Me.Size = New Size(400, 250) ' Adjust the form size if needed

        ' Welcome Label or any other dashboard information
        Dim lblWelcome As New Label()
        lblWelcome.Text = "Dashboard - Job Tracker App"
        lblWelcome.AutoSize = True
        lblWelcome.Location = New Point(50, 20)
        Me.Controls.Add(lblWelcome)

        ' Open Job Application Form Button
        Dim btnOpenJobApplicationForm As New Button()
        btnOpenJobApplicationForm.Text = "Open Job Application Form"
        btnOpenJobApplicationForm.Location = New Point(50, 60)
        btnOpenJobApplicationForm.Size = New Size(200, 40) ' Adjust the size to fit the text
        AddHandler btnOpenJobApplicationForm.Click, AddressOf Me.BtnOpenJobApplicationForm_Click
        Me.Controls.Add(btnOpenJobApplicationForm)

        ' Open Applied Jobs Form Button
        Dim btnOpenAppliedJobsForm As New Button()
        btnOpenAppliedJobsForm.Text = "View Applied Jobs"
        btnOpenAppliedJobsForm.Location = New Point(50, 110)
        btnOpenAppliedJobsForm.Size = New Size(200, 40) ' Adjust the size to fit the text
        AddHandler btnOpenAppliedJobsForm.Click, AddressOf Me.BtnOpenAppliedJobsForm_Click
        Me.Controls.Add(btnOpenAppliedJobsForm)
    End Sub

    Private Sub BtnOpenJobApplicationForm_Click(sender As Object, e As EventArgs)
        Dim jobApplicationForm As New JobApplicationForm()
        jobApplicationForm.ShowDialog() ' Show the Job Application Form as a modal dialog
    End Sub

    Private Sub BtnOpenAppliedJobsForm_Click(sender As Object, e As EventArgs)
        Dim appliedJobsForm As New AppliedJobsForm() ' Assuming you have this form created
        appliedJobsForm.ShowDialog() ' Show the Applied Jobs Form as a modal dialog
    End Sub
End Class