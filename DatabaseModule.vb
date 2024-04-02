Imports MySql.Data.MySqlClient

Module DatabaseModule
    Private connectionString As String = "server=localhost;user=root;password=(RootPassword123);database=jobapp"

    ' Function to open a database connection
    Public Function OpenConnection() As MySqlConnection
        Try
            Dim connection As New MySqlConnection(connectionString)
            connection.Open()
            Return connection
        Catch ex As Exception
            MessageBox.Show($"An error occurred connecting to the database: {ex.Message}", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    ' Execute a non-query (INSERT, UPDATE, DELETE)
    Public Sub ExecuteNonQuery(query As String, parameters As Dictionary(Of String, Object))
        Using connection As MySqlConnection = OpenConnection()
            If connection IsNot Nothing Then
                Using command As New MySqlCommand(query, connection)
                    For Each param As KeyValuePair(Of String, Object) In parameters
                        command.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                    Try
                        command.ExecuteNonQuery()
                    Catch ex As Exception
                        MessageBox.Show($"An error occurred executing the query: {ex.Message}", "Query Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End If
        End Using
    End Sub

    ' Add other database operations as needed...
End Module
