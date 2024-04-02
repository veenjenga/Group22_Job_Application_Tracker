Public Class UserRegistrationForm
    Private txtUsername As TextBox
    Private txtPassword As TextBox
    Private txtEmail As TextBox
    Private txtFirstName As TextBox
    Private txtLastName As TextBox

    Private Sub UserRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "User Registration"
        Me.Size = New Size(400, 300)

        ' Username
        AddLabel("lblUsername", "Username:", New Point(10, 20))
        txtUsername = AddTextBox("txtUsername", New Point(120, 20), False)

        ' Password
        AddLabel("lblPassword", "Password:", New Point(10, 50))
        txtPassword = AddTextBox("txtPassword", New Point(120, 50), True)

        ' Email Address
        AddLabel("lblEmail", "Email Address:", New Point(10, 80))
        txtEmail = AddTextBox("txtEmail", New Point(120, 80), False)

        ' First Name
        AddLabel("lblFirstName", "First Name:", New Point(10, 110))
        txtFirstName = AddTextBox("txtFirstName", New Point(120, 110), False)

        ' Last Name
        AddLabel("lblLastName", "Last Name:", New Point(10, 140))
        txtLastName = AddTextBox("txtLastName", New Point(120, 140), False)

        ' Register Button
        AddButton("btnRegister", "Register", New Point(120, 170))
    End Sub

    Private Sub AddLabel(name As String, text As String, location As Point)
        Dim lbl As New Label
        lbl.Name = name
        lbl.Text = text
        lbl.Location = location
        Me.Controls.Add(lbl)
    End Sub

    Private Function AddTextBox(name As String, location As Point, usePasswordChar As Boolean) As TextBox
        Dim txt As New TextBox
        txt.Name = name
        txt.Location = location
        If usePasswordChar Then txt.PasswordChar = "*"c
        Me.Controls.Add(txt)
        Return txt
    End Function

    Private Sub AddButton(name As String, text As String, location As Point)
        Dim btn As New Button
        btn.Name = name
        btn.Text = text
        btn.Location = location
        AddHandler btn.Click, AddressOf Me.RegisterButton_Click
        Me.Controls.Add(btn)
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs)
        ' Prepare SQL query and parameters for inserting a new user
        Dim query As String = "INSERT INTO users (username, password, email, first_name, last_name) VALUES (@username, @password, @email, @first_name, @last_name)"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@username", txtUsername.Text},
            {"@password", txtPassword.Text},  ' Password should be hashed
            {"@email", txtEmail.Text},
            {"@first_name", txtFirstName.Text},
            {"@last_name", txtLastName.Text}
        }

        ' Use DatabaseModule to execute query
        DatabaseModule.ExecuteNonQuery(query, parameters)
        MessageBox.Show("Registration successful!")

        ' Open LoginForm after successful registration
        Me.Hide() ' Optionally hide or close the registration form
        Dim loginForm As New LoginForm()
        loginForm.ShowDialog()
        Me.Close() ' Close the registration form if it's no longer needed
    End Sub
End Class