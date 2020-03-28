Imports System.Data
Imports System.Data.SQLite

Public Class LibraryBooks
    Public Shared Function BuscarLibro()

    End Function

    Public Shared Function ObtenerListaLibros(con As SQLiteConnection) As DataView
        Dim Ds As New DataSet
        Dim Da As New SQLiteDataAdapter("select id, titulo, autor, isbn, editorial, descripcion, googleid from libros", con)

        Da.Fill(Ds, "libros")

        Dim myDataView As DataView = New DataView(Ds.Tables("libros"))
        Return myDataView
    End Function
End Class
