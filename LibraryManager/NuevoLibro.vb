Imports System.Data.SQLite
Imports LibraryQuery.LibraryBooks

Public Class NuevoLibro
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If isbnTxt.Text = "" Then
            MessageBox.Show("El ISBN es obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf IsNumeric(isbnTxt.Text) = False Then
            MessageBox.Show("El ISBN debe ser numérico", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf isbnTxt.Text.Length.ToString <> "10" And isbnTxt.Text.Length.ToString <> "13" Then
            MessageBox.Show("El ISBN debe ser un número entre 10 y 13 cifras", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf tituloTxt.Text = "" Then
            MessageBox.Show("El TÍTULO es obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                CrearLibro(Principal.con, tituloTxt.Text, isbnTxt.Text, autorTxt.Text, editorialTxt.Text, descripcionTxt.Text)
                Principal.ActualizarListaLibros()

                tituloTxt.Text = ""
                isbnTxt.Text = ""
                autorTxt.Text = ""
                editorialTxt.Text = ""
                descripcionTxt.Text = ""

                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Ha ocurrido un error: " & ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class