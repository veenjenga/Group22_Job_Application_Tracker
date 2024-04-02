Imports MySql.Data.MySqlClient

Public Class DbConnectionForm
    Private lblServer As Label
    Private txtServer As TextBox
    Private lblUsername As Label
    Private txtUsername As TextBox
    Private lblPassword As Label
    Private txtPassword As TextBox
    Private lblDatabase As Label
    Private txtDatabase As TextBox
    Private btnConnect As Button
    Private lblStatus As Label

    Private Sub DbConnectionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Database Connection"
        Me.Size = New Size(400, 250)

        ' Server Address
        AddLabel(lblServer, "Server:", New Point(10, 20))
        txtServer = AddTextBox(New Point(100, 20), "localhost")

        ' Username
        AddLabel(lblUsername, "Username:", New Point(10, 50))
        txtUsername = AddTextBox(New Point(100, 50), "")

        ' Password
        AddLabel(lblPassword, "Password:", New Point(10, 80))
        txtPassword = AddTextBox(New Point(100, 80), "")
        txtPassword.UseSystemPasswordChar = True

        ' Database Name
        AddLabel(lblDatabase, "Database:", New Point(10, 110))
        txtDatabase = AddTextBox(New Point(100, 110), "jobapp")

        ' Connect Button
        btnConnect = New Button With {.Text = "Connect", .Location = New Point(100, 140)}
        AddHandler btnConnect.Click, AddressOf Me.BtnConnect_Click
        Me.Controls.Add(btnConnect)

        ' Status Label
        lblStatus = New Label With {.AutoSize = True, .Location = New Point(10, 170)}
        Me.Controls.Add(lblStatus)
    End Sub

    Private Function AddTextBox(location As Point, text As String) As TextBox
        Dim txt As New TextBox With {.Location = location, .Width = 250, .Text = text}
        Me.Controls.Add(txt)
        Return txt
    End Function

    Private Sub AddLabel(ByRef lbl As Label, text As String, location As Point)
        lbl = New Label With {.Text = text, .Location = location, .AutoSize = True}
        Me.Controls.Add(lbl)
    End Sub

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs)
        Dim connectionString As String = $"Server={txtServer.Text}; database={txtDatabase.Text}; UID={txtUsername.Text}; password={txtPassword.Text}"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                lblStatus.Text = "Connection successful!"
                lblStatus.ForeColor = Color.Green
            Catch ex As Exception
                lblStatus.Text = $"Failed to connect: {ex.Message}"
                lblStatus.ForeColor = Color.Red
            End Try
        End Using
    End Sub
End Class