Imports System.Data.SQLite
Imports LibraryData.LibraryData
Imports LibraryQuery.LibraryBooks

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
        Dim Lista As DataView = ObtenerListaLibros(con)
        DataGridViewLibros.DataSource = Lista
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.ExitThread()
    End Sub

    Private Sub NuevoLibroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoLibroToolStripMenuItem.Click
        NuevoLibro.ShowDialog()
    End Sub
End Class
