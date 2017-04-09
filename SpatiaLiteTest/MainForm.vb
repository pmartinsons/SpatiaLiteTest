Imports System.Data.SQLite

Public Class MainForm


    Private Sub CreateNewSpatiallyEnabledDatabase_Click(sender As Object, e As EventArgs) Handles mnuNewSpatiaLiteDB.Click
        If FileDialog1.ShowDialog(Me) = DialogResult.Cancel Then Exit Sub

        Dim fname As String = FileDialog1.FileName()

        Dim tb As New System.Text.StringBuilder()

        Using cn As System.Data.SQLite.SQLiteConnection = New SQLiteConnection(String.Format("Data Source={0}; Pooling=true; FailIfMissing=false", fname))
            Try

                ' Open a database
                cn.Open()

                Dim cmd As SQLiteCommand = cn.CreateCommand()

                cmd.CommandText = "CREATE TABLE test (
                key   VARCHAR(20) PRIMARY KEY,
                value VARCHAR(50) );"

                cmd.ExecuteNonQuery()

                tb.AppendLine("test table created.")

                ' Enabling extensions is optional, it seems
                cn.EnableExtensions(True)
                cn.LoadExtension("mod_spatialite", "sqlite3_modspatialite_init") ' module name without filename extension, entry function name
                tb.AppendLine("mod_spatialite extension loaded.")

                ' Next 3 commented lines will not work on newer versions
                'Dim cmd2 As SQLiteCommand = cn.CreateCommand()
                'cmd2.CommandText = "SELECT load_extension('mod_spatialite', 'sqlite3_modspatialite_init')"'"not authorized" exception
                'cmd2.ExecuteNonQuery()

                ' Initialize spatial metadata
                Dim cmd3 As SQLiteCommand = cn.CreateCommand()
                cmd3.CommandText = "SELECT InitSpatialMetaData(1)" ' without 1 as param will take minutes.
                cmd3.ExecuteNonQuery()
                tb.AppendLine("Spatial database initialized.")

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

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        Dim n = New AboutBox1()
        n.ShowDialog(Me)
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub
End Class
