Imports System.Data.SQLite
Imports System.Reflection
Imports LibraryData.LibraryData

Public Class Principal
    Public con As SQLiteConnection = Conectar("LibraryManagerDB.db")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            con.Open()
            If CheckIfTableExists(con, "libros") = False Then
                CrearBdLibros(con)
            End If

            If CheckIfTableExists(con, "ventas") = False Then
                CrearBdVentas(con)
            End If

            If CheckIfTableExists(con, "ventas_libros") = False Then
                CrearBdVentasLibros(con)
            End If

            ActualizarListaLibros()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ActualizarListaLibros()
        Dim Ds As New DataSet
        Dim Da As New SQLiteDataAdapter("select id, titulo, autor, isbn, editorial, descripcion, googleid from libros", con)

        Da.Fill(Ds, "libros")

        Dim myDataView As DataView = New DataView(Ds.Tables("libros"))

        DataGridView1.DataSource = myDataView
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.ExitThread()
    End Sub

    Private Function CheckIfTableExists(con As SQLiteConnection, table As String) As Boolean
        Dim command As New SQLiteCommand("SELECT name FROM sqlite_master WHERE type='table' AND name='" & table & "'", con)

        Dim Reader = command.ExecuteReader()
        Return Reader.HasRows
    End Function

    Private Sub CrearBdLibros(con As SQLiteConnection)
        Dim command As New SQLiteCommand("CREATE TABLE 'libros' ('id' INTEGER, 'titulo' TEXT, 'autor' TEXT, 'isbn' TEXT, 'editorial' TEXT, 'descripcion' TEXT,'portada' TEXT, 'googleid' TEXT, 'imagetype' TEXT);", con)
        command.ExecuteNonQuery()
    End Sub

    Private Sub CrearBdVentas(con As SQLiteConnection)
        Dim command As New SQLiteCommand("CREATE TABLE IF NOT EXISTS 'ventas' ('id' INTEGER, 'persona' TEXT, 'telefono' INTEGER, 'total' REAL, 'fecha_venta' TEXT, 'pagado' INTEGER, 'fecha_estimada_pago' TEXT);", con)
        command.ExecuteNonQuery()
    End Sub

    Private Sub CrearBdVentasLibros(con As SQLiteConnection)
        Dim command As New SQLiteCommand("CREATE TABLE 'ventas_libros' ('id' INTEGER, 'id_venta' INTEGER, 'id_libro'  INTEGER);", con)
        command.ExecuteNonQuery()
    End Sub

    Private Sub NuevoLibroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoLibroToolStripMenuItem.Click
        NuevoLibro.ShowDialog()
    End Sub
End Class
