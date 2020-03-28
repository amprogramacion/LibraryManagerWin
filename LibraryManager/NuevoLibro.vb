Imports System.Data.SQLite

Public Class NuevoLibro
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If isbnTxt.Text = "" Then
            MsgBox("El ISBN es obligatorio")
        ElseIf tituloTxt.Text = "" Then
            MsgBox("El TÍTULO es obligatorio")
        Else
            Dim command As New SQLiteCommand("INSERT INTO 'libros' (titulo, isbn, autor, editorial, descripcion) values ('" & tituloTxt.Text & "', '" & isbnTxt.Text & "', '" & autorTxt.Text & "', '" & editorialTxt.Text & "', '" & descripcionTxt.Text & "');", Principal.con)
            command.ExecuteNonQuery()
            Principal.ActualizarListaLibros()
            Me.Close()
        End If
    End Sub
End Class