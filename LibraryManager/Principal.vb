Imports System.Data.SQLite
Imports System.Reflection
Imports LibraryData.LibraryData

Public Class Principal
    Public con As SQLiteConnection = Conectar("LibraryManagerDB.db")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.Open()

            ComprobarBasesDeDatos(con)
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

        DataGridViewLibros.DataSource = myDataView
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.ExitThread()
    End Sub

    Private Sub NuevoLibroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoLibroToolStripMenuItem.Click
        NuevoLibro.ShowDialog()
    End Sub
End Class
