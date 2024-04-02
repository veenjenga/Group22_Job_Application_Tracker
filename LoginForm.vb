Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private txtUsernameEmail As TextBox
    Private txtPassword As TextBox

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Login"
        Me.Size = New Size(400, 200)

        ' Add Labels
        AddLabel("lblUsernameEmail", "Username or Email:", New Point(10, 20))
        AddLabel("lblPassword", "Password:", New Point(10, 50))

        ' Username or Email TextBox
        txtUsernameEmail = AddTextBox("txtUsernameEmail", New Point(150, 20), False)

        ' Password TextBox
        txtPassword = AddTextBox("txtPassword", New Point(150, 50), True)

        ' Login Button
        AddButton("btnLogin", "Login", New Point(150, 80))
    End Sub

    ' Helper method to add a Label
    Private Sub AddLabel(name As String, text As String, location As Point)
        Dim lbl As New Label()
        lbl.Name = name
        lbl.Text = text
        lbl.Location = location
        lbl.AutoSize = True
        Me.Controls.Add(lbl)
    End Sub

    ' Helper method to add a TextBox
    Private Function AddTextBox(name As String, location As Point, usePasswordChar As Boolean) As TextBox
        Dim txt As New TextBox()
        txt.Name = name
        txt.Location = location
        txt.Size = New Size(200, 20)
        If usePasswordChar Then
            txt.PasswordChar = "*"c
        End If
        Me.Controls.Add(txt)
        Return txt
    End Function

    ' Helper method to add a Button
    Private Sub AddButton(name As String, text As String, location As Point)
        Dim btn As New Button()
        btn.Name = name
        btn.Text = text
        btn.Location = location
        btn.Size = New Size(100, 30)
        AddHandler btn.Click, AddressOf Me.LoginButton_Click
        Me.Controls.Add(btn)
    End Sub

    ' Login Button Click Event Handler
    Private Sub LoginButton_Click(sender As Object, e As EventArgs)
        Dim query As String = "SELECT password FROM users WHERE username = @username OR email = @username LIMIT 1"
        Dim parameters As New Dictionary(Of String, Object) From {{"@username", txtUsernameEmail.Text}}

        Using connection As MySqlConnection = DatabaseModule.OpenConnection()
            If connection IsNot Nothing Then
                Using command As New MySqlCommand(query, connection)
                    For Each param As KeyValuePair(Of String, Object) In parameters
                        command.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                    Try
                        Dim dbPassword As Object = command.ExecuteScalar()
                        If dbPassword IsNot Nothing AndAlso dbPassword.ToString() = txtPassword.Text Then
                            MessageBox.Show("Login successful.")
                            Me.Hide()
                            Dim dashboardForm As New DashboardForm()
                            dashboardForm.ShowDialog()
                            Me.Close()
                        Else
                            MessageBox.Show("Incorrect login details.")
                        End If
                    Catch ex As MySqlException
                        MessageBox.Show($"An error occurred: {ex.Message}")
                    End Try
                End Using
            End If
        End Using
    End Sub
End Class