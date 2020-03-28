Imports System.Data.SQLite

Public Class LibraryData
    Public Shared Function Conectar(file As String) As SQLiteConnection
        Try
            Dim con As New SQLiteConnection("Data Source=" & file & "; Version=3")
            Return con
        Catch e As Exception
            Throw New System.Exception("No se ha podido encontrar el archivo de base de datos")
        End Try
    End Function

    Public Shared Function CrearBdLibros(con As SQLiteConnection) As Boolean
        Try
            Dim command As New SQLiteCommand("CREATE TABLE 'libros' ('id' INTEGER, 'titulo' TEXT, 'autor' TEXT, 'isbn' TEXT, 'editorial' TEXT, 'descripcion' TEXT,'portada' TEXT, 'googleid' TEXT, 'imagetype' TEXT);", con)
            command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function CrearBdVentas(con As SQLiteConnection) As Boolean
        Try
            Dim command As New SQLiteCommand("CREATE TABLE IF NOT EXISTS 'ventas' ('id' INTEGER, 'persona' TEXT, 'telefono' INTEGER, 'total' REAL, 'fecha_venta' TEXT, 'pagado' INTEGER, 'fecha_estimada_pago' TEXT);", con)
            command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function CrearBdVentasLibros(con As SQLiteConnection) As Boolean
        Dim command As New SQLiteCommand("CREATE TABLE 'ventas_libros' ('id' INTEGER, 'id_venta' INTEGER, 'id_libro'  INTEGER);", con)
        command.ExecuteNonQuery()
        Return True
    End Function

    Public Shared Function ComprobarBasesDeDatos(con As SQLiteConnection) As Boolean
        If CheckIfTableExists(con, "libros") = False Then
            CrearBdLibros(con)
        End If

        If CheckIfTableExists(con, "ventas") = False Then
            CrearBdVentas(con)
        End If

        If CheckIfTableExists(con, "ventas_libros") = False Then
            CrearBdVentasLibros(con)
        End If
        Return True
    End Function

    Private Shared Function CheckIfTableExists(con As SQLiteConnection, table As String) As Boolean
        Dim command As New SQLiteCommand("SELECT name FROM sqlite_master WHERE type='table' AND name='" & table & "'", con)
        Dim Reader = command.ExecuteReader()
        Return Reader.HasRows
    End Function
End Class
