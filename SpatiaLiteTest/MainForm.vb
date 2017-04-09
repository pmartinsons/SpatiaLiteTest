Imports System.Data.SQLite

Public Class MainForm
    Private Sub btnExecuteSQL_Click(sender As Object, e As EventArgs) Handles btnExecuteSQL.Click
        'Dim cn As System.Data.SQLite.SQLiteConnection = Nothing
        Dim tb As New System.Text.StringBuilder()

        Using cn As System.Data.SQLite.SQLiteConnection = New SQLiteConnection("Data Source=test.db; Pooling=true; FailIfMissing=false")
            Try
                'cn = New SQLiteConnection("Data Source=test.db; Pooling=true; FailIfMissing=false")
                ' Opens an unencrypted database
                cn.Open()
                'Dim cmd As SQLiteCommand = cn.CreateCommand()
                'cmd.CommandText = "CREATE TABLE test (
                'key   VARCHAR (20) PRIMARY KEY,
                'value VARCHAR (50) 
                '               );"

                'cmd.ExecuteNonQuery()

                'tb.AppendLine("test table created.")

                cn.EnableExtensions(True)
                cn.LoadExtension("mod_spatialite", "sqlite3_modspatialite_init")
                tb.AppendLine("mod_spatialite extension loaded.")

                'SELECT load_extension('C:/personal/projekti/Blog/006_C#_spatialite/SpatiaLiteTest/SpatiaLiteTest/bin/Debug/mod_spatialite
                'System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly.)
                'Dim cmd2 As SQLiteCommand = cn.CreateCommand()
                'cmd2.CommandText = "SELECT load_extension('mod_spatialite', 'sqlite3_modspatialite_init')"'"not authorized"
                'cmd2.ExecuteNonQuery()
                'tb.AppendLine("mod_spatialite loaded.")

                Dim cmd3 As SQLiteCommand = cn.CreateCommand()
                cmd3.CommandText = "SELECT InitSpatialMetaData(1)" ' without 1 as param will take minutes.
                cmd3.ExecuteNonQuery()
                tb.AppendLine("Spatial database initialized.")

                cn.Close()
            Catch ex As Exception
                tb.AppendLine(ex.Message)
                tb.AppendLine(ex.StackTrace)


            Finally
                txtOutput.Text = tb.ToString()

                If Not IsNothing(cn) Then
                    cn.Close()
                    cn.Dispose()
                End If
            End Try
        End Using

    End Sub
End Class
