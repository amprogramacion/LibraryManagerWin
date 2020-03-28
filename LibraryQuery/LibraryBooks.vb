Imports System.Data
Imports System.Data.SQLite

Public Class LibraryBooks
    Public Shared Function BuscarLibro(con As SQLiteConnection, titulo As String, isbn As String, editorial As String, descripcion As String) As DataView

        Dim busqueda As List(Of String) = New List(Of String)

        If titulo <> "" Then
            busqueda.Add("titulo Like '%" & titulo & "%'")
        End If

        If isbn <> "" Then
            busqueda.Add("isbn Like '%" & isbn & "%'")
        End If

        If editorial <> "" Then
            busqueda.Add("editorial Like '%" & editorial & "%'")
        End If

        If descripcion <> "" Then
            busqueda.Add("descripcion Like '%" & descripcion & "%'")
        End If

        If busqueda.Count >= 1 Then
            Try
                Dim Ds As New DataSet
                Dim q As String = "select id, titulo, autor, isbn, editorial, descripcion, " &
            "googleid from libros where (" & String.Join(" or ", busqueda) & ")"
                Dim Da As New SQLiteDataAdapter(q, con)

                Da.Fill(Ds, "libros")

                Dim myDataView As DataView = New DataView(Ds.Tables("libros"))
                Return myDataView
            Catch ex As Exception
                Dim q As String = "select id, titulo, autor, isbn, editorial, descripcion, " &
            "googleid from libros where (" & String.Join(" or ", busqueda) & ")"
                Throw New Exception(q)
            End Try
        Else
            Throw New Exception("No se ha tecleado nada para buscar")
        End If
    End Function

    Public Shared Function ObtenerListaLibros(con As SQLiteConnection) As DataView
        Try
            Dim Ds As New DataSet
            Dim Da As New SQLiteDataAdapter("select id, titulo, autor, isbn, editorial, descripcion, googleid from libros", con)

            Da.Fill(Ds, "libros")

            Dim myDataView As DataView = New DataView(Ds.Tables("libros"))
            Return myDataView
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Shared Function CrearLibro(con As SQLiteConnection, titulo As String, isbn As String, autor As String, editorial As String, descripcion As String) As Boolean
        Try
            Dim command As New SQLiteCommand("INSERT INTO 'libros' (titulo, isbn, autor, editorial, descripcion) " &
                                             "values ('" & titulo & "', '" & isbn & "', '" & autor & "', '" & editorial & "', '" & descripcion & "');", con)
            command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
