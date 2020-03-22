Imports System.Security.Cryptography
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.IO

Public Class Tools
    ' Método para generar una clave con un hash SHA-1, a partir de una cadena dada

    Public Shared Function textToSha1(ByVal cadena As String) As String

        Dim enc As New UTF8Encoding
        Dim data() As Byte = enc.GetBytes(cadena)
        Dim result() As Byte

        Dim sha As New SHA1CryptoServiceProvider

        result = sha.ComputeHash(data)

        Dim sb As New StringBuilder
        Dim max As Int32 = result.Length



        For i As Integer = 0 To max - 1


            'Convertimos los valores en hexadecimal
            'cuando tiene una cifra hay que rellenarlo con cero
            'para que siempre ocupen dos dígitos.
            If (result(i) < 16) Then
                sb.Append("0")
            End If

            sb.Append(result(i).ToString("x"))


        Next


        'Devolvemos la cadena con el hash en mayúsculas para que quede más chuli :)
        Return sb.ToString()

    End Function

    Friend Shared Sub RemoveConfigFile(filename As String)
        Dim path As String = My.Application.Info.DirectoryPath & "\" & filename
        Dim fs As FileStream = File.Create(path)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("[Login]" + vbLf + "Email=")
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub

    Friend Shared Sub SaveConfigFile(filename As String, text As String)
        Dim path As String = My.Application.Info.DirectoryPath & "\" & filename
        Dim fs As FileStream = File.Create(path)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("[Login]" + vbLf + "Email=" + text)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub

    Friend Shared Function CheckSecurity(user As String, token As String) As Boolean
        Dim usuariosTableAdapter As LibraryManagerDataSetTableAdapters.usuariosTableAdapter = New LibraryManagerDataSetTableAdapters.usuariosTableAdapter
        Dim userData As LibraryManagerDataSet.usuariosDataTable = usuariosTableAdapter.GetUserDataByemail(user)
        If userData.Rows.Count = 0 Then
            Return False
        Else
            If token = userData(0).pass_desktop Then
                Return True
            Else
                Return False
            End If
        End If
    End Function



    <DllImport("kernel32")>
    Private Shared Function GetPrivateProfileString(ByVal section As String, ByVal key As String, ByVal def As String, ByVal retVal As StringBuilder, ByVal size As Integer, ByVal filePath As String) As Integer
    End Function

    Friend Shared Function GetIniValue(section As String, key As String, filename As String, Optional defaultValue As String = "") As String
        Dim sb As New StringBuilder(500)
        If GetPrivateProfileString(section, key, defaultValue, sb, sb.Capacity, filename) > 0 Then
            Return sb.ToString
        Else
            Return defaultValue
        End If
    End Function

    Friend Shared Sub CheckIfConfigFileExists(filename As String)
        Dim path As String = My.Application.Info.DirectoryPath & "\" & filename
        If File.Exists(path) = False Then
            Dim fs As FileStream = File.Create(path)
            Dim info As Byte() = New UTF8Encoding(True).GetBytes("[Login]" + vbLf + "Email=")
            fs.Write(info, 0, info.Length)
            fs.Close()
        End If
    End Sub
End Class
