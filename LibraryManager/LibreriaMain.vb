Public Class LibreriaMain

    Dim token As String
    Dim user As String
    Dim id_libreria As String

    Public Function getToken() As String
        Return token
    End Function
    Public Function getUser() As String
        Return user
    End Function

    Public Function getLibreria() As String
        Return id_libreria
    End Function

    Public Sub setToken(t As String)
        token = t
    End Sub

    Public Sub setUser(u As String)
        user = u
    End Sub

    Public Sub setLibreria(u As String)
        id_libreria = u
    End Sub


    Private Sub LibreriaMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim statusCheck As Boolean = Tools.CheckSecurity(user, token)
        If statusCheck = True Then
            LibrosTableAdapter.GetLibros(Me.LibreriaieleDataSet.libros, id_libreria)
        Else
            MessageBox.Show("Fallo de seguridad al cargar libros", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
        End If
    End Sub

    Private Sub RellenarLibrosByTituloToolStripButton_Click(sender As Object, e As EventArgs) Handles RellenarLibrosByTituloToolStripButton.Click
        Try
            LibrosTableAdapter.RellenarLibrosByTitulo(Me.LibreriaieleDataSet.libros, TituloToolStripTextBox.Text, id_libreria)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub RellenarLibrosByDescripcionToolStripButton_Click(sender As Object, e As EventArgs) Handles RellenarLibrosByDescripcionToolStripButton.Click
        Try
            LibrosTableAdapter.RellenarLibrosByDescripcion(Me.LibreriaieleDataSet.libros, DescripcionToolStripTextBox.Text, id_libreria)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub RellenarLibrosByAutorToolStripButton_Click(sender As Object, e As EventArgs) Handles RellenarLibrosByAutorToolStripButton.Click
        Try
            LibrosTableAdapter.RellenarLibrosByAutor(Me.LibreriaieleDataSet.libros, AutorToolStripTextBox.Text, id_libreria)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub RellenarLibrosByIsbnToolStripButton_Click(sender As Object, e As EventArgs) Handles RellenarLibrosByIsbnToolStripButton.Click
        Try
            LibrosTableAdapter.RellenarLibrosByIsbn(Me.LibreriaieleDataSet.libros, IsbnToolStripTextBox.Text, id_libreria)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub AyudaEnLíneaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaEnLíneaToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://librarymanager.es/index.php?id=documentacion")
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        AcercaDe.ShowDialog()
    End Sub

    Private Sub CerrarLaSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarLaSesiónToolStripMenuItem.Click
        setToken("")
        setUser("")
        setLibreria("")
        Me.Close()
        Login.Show()
        Login.MostrarLibreríaToolStripMenuItem.Enabled = False
        Login.CerrarSesiónToolStripMenuItem.Enabled = False
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim Msg As MsgBoxResult
        Msg = MsgBox("Cerrar el programa, ¿Desea salir?", vbYesNo, "Salir del Programa")
        If Msg = MsgBoxResult.Yes Then
            Application.ExitThread()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Dim id_libro As String = DataGridView1.CurrentRow.Cells(0).Value
        If id_libro <> "" Then
            RellenarInfoLibroPreview(id_libro)
        End If
    End Sub

    Private Sub RellenarInfoLibroPreview(id_libro As String)
        GroupBoxBookPreview.Visible = False
        Dim infoLibro As LibraryManagerDataSet.librosDataTable = LibrosTableAdapter.GetLibroById(id_libro, id_libreria)
        If infoLibro.Rows.Count = 0 Then
            MessageBox.Show("El libro no existe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                labelTitulo.Text = infoLibro(0).titulo
            Catch ex As Exception
                labelTitulo.Text = ""
            End Try

            Try
                labelDescripcion.Text = infoLibro(0).descripcion
            Catch ex As Exception
                labelDescripcion.Text = ""
            End Try

            PictureBox1.Load("http://iele.amprogramacion.es/libreria/foto_libro.php?libro=" + id_libro)

            GroupBoxBookPreview.Visible = True
        End If
    End Sub

    Private Sub btnLimpiarBusqueda_Click(sender As Object, e As EventArgs) Handles btnLimpiarBusqueda.Click

        TituloToolStripTextBox.Text = ""
        DescripcionToolStripTextBox.Text = ""
        AutorToolStripTextBox.Text = ""
        IsbnToolStripTextBox.Text = ""
        GroupBoxBookPreview.Visible = False


        Dim statusCheck As Boolean = Tools.CheckSecurity(user, token)
        If statusCheck = True Then
            LibrosTableAdapter.Fill(Me.LibreriaieleDataSet.libros)
        Else
            MessageBox.Show("Fallo de seguridad al cargar libros", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
        End If
    End Sub

    Private Sub ConsultarVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarVentasToolStripMenuItem.Click
        Ventas.Show()
    End Sub

    Private Sub ComprobarActualizacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprobarActualizacionesToolStripMenuItem.Click
        MessageBox.Show("Por el momento no existen actualizaciones automáticas.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
End Class
