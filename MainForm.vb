Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Job Tracker Application"
        Me.Size = New Size(300, 250) ' Adjusted the size to accommodate the new button

        ' Welcome Label
        Dim lblWelcome As New Label()
        lblWelcome.Text = "Welcome to Job Tracker app"
        lblWelcome.AutoSize = True
        lblWelcome.Location = New Point(50, 20) ' Adjust as needed
        Me.Controls.Add(lblWelcome)

        ' Signup Button
        Dim btnSignup As New Button()
        btnSignup.Text = "Signup"
        btnSignup.Location = New Point(50, 60) ' Adjust as needed
        AddHandler btnSignup.Click, AddressOf Me.BtnSignup_Click
        Me.Controls.Add(btnSignup)

        ' Login Button
        Dim btnLogin As New Button()
        btnLogin.Text = "Login"
        btnLogin.Location = New Point(50, 100) ' Adjust as needed
        AddHandler btnLogin.Click, AddressOf Me.BtnLogin_Click
        Me.Controls.Add(btnLogin)

        ' DB Connection Button
        Dim btnDbConnection As New Button()
        btnDbConnection.Text = "DB Connection"
        btnDbConnection.Location = New Point(50, 140) ' Positioned below the Login button
        AddHandler btnDbConnection.Click, AddressOf Me.BtnDbConnection_Click
        Me.Controls.Add(btnDbConnection)
    End Sub

    Private Sub BtnSignup_Click(sender As Object, e As EventArgs)
        Dim signupForm As New UserRegistrationForm()
        signupForm.ShowDialog() ' Show the User Registration Form as a modal dialog
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs)
        Dim loginForm As New LoginForm()
        loginForm.ShowDialog() ' Show the Login Form as a modal dialog
    End Sub

    Private Sub BtnDbConnection_Click(sender As Object, e As EventArgs)
        Dim dbConnectionForm As New DbConnectionForm()
        dbConnectionForm.ShowDialog() ' Show the DB Connection Form as a modal dialog
    End Sub
End Class