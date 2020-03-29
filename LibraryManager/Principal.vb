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
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub ActualizarListaLibros()
        Try
            Dim Lista As DataView = ObtenerListaLibros(con)
            DataGridViewLibros.DataSource = Nothing
            DataGridViewLibros.Refresh()
            DataGridViewLibros.DataSource = Lista
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        CerrarAplicacion()
    End Sub

    Private Sub NuevoLibroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoLibroToolStripMenuItem.Click
        NuevoLibro.ShowDialog()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            Dim Buscar As DataView = BuscarLibro(con, buscarTitulo.Text, buscarIsbn.Text, buscarEditorial.Text, buscarDescripcion.Text)
            DataGridViewLibros.DataSource = Nothing
            DataGridViewLibros.Refresh()
            DataGridViewLibros.DataSource = Buscar
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BtnReiniciar_Click(sender As Object, e As EventArgs) Handles BtnReiniciar.Click
        ActualizarListaLibros()
    End Sub

    Private Sub SalirDeLaAplicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirDeLaAplicaciónToolStripMenuItem.Click
        CerrarAplicacion()
    End Sub

    Private Sub NotifyIconBarraTareas_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIconBarraTareas.MouseDoubleClick
        Show()
        AbrirAplicaciónToolStripMenuItem.Enabled = False
    End Sub

    Private Sub MinimizarProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizarProgramaToolStripMenuItem.Click
        Hide()
        AbrirAplicaciónToolStripMenuItem.Enabled = True
    End Sub

    Private Sub AbrirAplicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirAplicaciónToolStripMenuItem.Click
        Show()
        AbrirAplicaciónToolStripMenuItem.Enabled = False
    End Sub

    Private Sub CerrarAplicacion()
        Dim result As DialogResult = MessageBox.Show("¿Seguro que deseas cerrar el programa?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Application.ExitThread()
        End If
    End Sub
End Class
