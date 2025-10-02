Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class

Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New MySqlConnection()
        conn.ConnectionString = "server=127.0.0.1;= root;password='';database=test"

        Try
            conn.Open()
            Dim Query As String = "INSERT INTO login (username, password) VALUES (@username, @password)"
            COMMAND = New MySqlCommand(Query, conn)
            COMMAND.Parameters.AddWithValue("@username", TextBox1.Text)
            COMMAND.Parameters.AddWithValue("@password", TextBox2.Text)
            Dim RowsAffected As Integer = COMMAND.ExecuteNonQuery
            If RowsAffected > 0 Then
                MessageBox.Show("Data Inserted Successfully")
            Else
                MessageBox.Show("Data Insertion Failed")
            End If
        Catch ex As Exception
            MsgBox("Error:" & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class