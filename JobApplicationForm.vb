Imports System.Windows.Forms

Public Class JobApplicationForm
    Inherits Form

    Private txtCompanyName As TextBox
    Private txtPositionTitle As TextBox
    Private txtContactName As TextBox
    Private txtContactEmail As TextBox
    Private txtLocation As TextBox
    Private cmbFeedbackStatus As ComboBox
    Private WithEvents btnSubmit As Button

    Public Sub New()
        MyBase.New()
        InitializeFormControls()
    End Sub

    Private Sub InitializeFormControls()
        Me.Size = New Size(400, 300)
        Me.Text = "Job Application Form"

        ' Company Name
        AddLabel("lblCompanyName", "Company Name:", New Point(10, 20))
        txtCompanyName = AddTextBox("txtCompanyName", New Point(120, 20))

        ' Position Title
        AddLabel("lblPositionTitle", "Position Title:", New Point(10, 50))
        txtPositionTitle = AddTextBox("txtPositionTitle", New Point(120, 50))

        ' Contact Name
        AddLabel("lblContactName", "Contact Name:", New Point(10, 80))
        txtContactName = AddTextBox("txtContactName", New Point(120, 80))

        ' Contact Email
        AddLabel("lblContactEmail", "Contact Email:", New Point(10, 110))
        txtContactEmail = AddTextBox("txtContactEmail", New Point(120, 110))

        ' Location
        AddLabel("lblLocation", "Location:", New Point(10, 140))
        txtLocation = AddTextBox("txtLocation", New Point(120, 140))

        ' Feedback Status
        AddLabel("lblFeedbackStatus", "Feedback Status:", New Point(10, 170))
        cmbFeedbackStatus = AddComboBox("cmbFeedbackStatus", New Point(120, 170), New String() {"Pending", "Rejected", "Interviewing"})

        ' Submit Button
        btnSubmit = AddButton("btnSubmit", "Submit", New Point(120, 200))
    End Sub

    Private Sub AddLabel(name As String, text As String, location As Point)
        Dim lbl As New Label()
        lbl.Name = name
        lbl.Text = text
        lbl.Location = location
        Me.Controls.Add(lbl)
    End Sub

    Private Function AddTextBox(name As String, location As Point) As TextBox
        Dim txt As New TextBox()
        txt.Name = name
        txt.Location = location
        Me.Controls.Add(txt)
        Return txt
    End Function

    Private Function AddComboBox(name As String, location As Point, items As String()) As ComboBox
        Dim cmb As New ComboBox()
        cmb.Name = name
        cmb.Location = location
        cmb.DropDownStyle = ComboBoxStyle.DropDownList
        cmb.Items.AddRange(items)
        Me.Controls.Add(cmb)
        Return cmb
    End Function

    Private Function AddButton(name As String, text As String, location As Point) As Button
        Dim btn As New Button()
        btn.Name = name
        btn.Text = text
        btn.Location = location
        Me.Controls.Add(btn)
        Return btn
    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Validate inputs (ensure they're not empty, etc.) before proceeding

        ' Prepare SQL query and parameters for inserting a new job application
        Dim query As String = "INSERT INTO job_applications (company_name, position_title, contact_name, contact_email, location, feedback_status) VALUES (@company_name, @position_title, @contact_name, @contact_email, @location, @feedback_status)"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@company_name", txtCompanyName.Text},
            {"@position_title", txtPositionTitle.Text},
            {"@contact_name", txtContactName.Text},
            {"@contact_email", txtContactEmail.Text},
            {"@location", txtLocation.Text},
            {"@feedback_status", cmbFeedbackStatus.SelectedItem.ToString()}
        }

        ' Call DatabaseModule.ExecuteNonQuery to insert the new job application
        DatabaseModule.ExecuteNonQuery(query, parameters)

        MessageBox.Show("Application submitted successfully!")
    End Sub
End Class