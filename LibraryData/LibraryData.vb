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

End Class
