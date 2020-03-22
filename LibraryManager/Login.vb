Imports System.Configuration
Imports System.Net.Mime.MediaTypeNames

Public Class Login

    Dim tmpuser As String
    Dim tmptoken As String
    Dim tmpidlibreria As String

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        'Comprobar si debemos guardar el usuario en el ini
        If chkRecordarEmail.Checked = True Then
            Dim emailIni As String = Tools.GetIniValue("Login", "Email", My.Application.Info.DirectoryPath & "\Config.ini")
            If emailIni <> txtEmail.Text Then
                Tools.SaveConfigFile("Config.ini", txtEmail.Text)
            End If
        Else
            Tools.RemoveConfigFile("Config.ini")
        End If


        Dim usuariosTableAdapter As LibraryManagerDataSetTableAdapters.usuariosTableAdapter = New LibraryManagerDataSetTableAdapters.usuariosTableAdapter
        Try
            Dim user As LibraryManagerDataSet.usuariosDataTable = usuariosTableAdapter.GetUserDataByemail(txtEmail.Text)
            If user.Rows.Count = 0 Then
                MessageBox.Show("El usuario introducido no existe en el sistema", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                'Calcular el ID de librería
                Dim usuarios_libreriasTableAdapter As LibraryManagerDataSetTableAdapters.usuarios_libreriasTableAdapter = New LibraryManagerDataSetTableAdapters.usuarios_libreriasTableAdapter
                Dim librerias_user As LibraryManagerDataSet.usuarios_libreriasDataTable = usuarios_libreriasTableAdapter.GetLibreriaByIdUsuario(user(0).id)
                CheckPassword(user(0).email, user(0).pass_desktop, librerias_user(0).id_libreria)
            End If
        Catch ex As Exception
            MessageBox.Show("No se puede acceder a la base de datos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CheckPassword(user As String, pass As String, id_libreria As String)
        If pass = Tools.textToSha1(txtPass.Text) Then
            LibreriaMain.setToken(pass)
            LibreriaMain.setUser(user)
            LibreriaMain.setLibreria(id_libreria)
            LibreriaMain.Show()
            Me.Hide()
            MostrarLibreríaToolStripMenuItem.Enabled = True
            CerrarSesiónToolStripMenuItem.Enabled = True
            tmpuser = user
            tmptoken = pass
            tmpidlibreria = id_libreria
        Else
            MessageBox.Show("La contraseña introducida es incorrecta", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim Msg As MsgBoxResult
        Msg = MsgBox("Cerrar el programa, ¿Desea salir?", vbYesNo, "Salir del Programa")
        If Msg = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarLibreríaToolStripMenuItem.Enabled = False
        CerrarSesiónToolStripMenuItem.Enabled = True

        Tools.CheckIfConfigFileExists("Config.ini")

        Dim emailIni As String = Tools.GetIniValue("Login", "Email", My.Application.Info.DirectoryPath & "\Config.ini")
        If emailIni <> "" Then
            txtEmail.Text = emailIni
            chkRecordarEmail.Checked = True
            txtPass.Select()
        End If


    End Sub

    Private Sub MostrarLibreríaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarLibreríaToolStripMenuItem.Click
        LibreriaMain.setToken(tmptoken)
        LibreriaMain.setUser(tmpuser)
        LibreriaMain.setLibreria(tmpidlibreria)
        LibreriaMain.Show()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        LibreriaMain.setToken("")
        LibreriaMain.setUser("")
        LibreriaMain.setLibreria("")
        LibreriaMain.Close()
        Show()
        MostrarLibreríaToolStripMenuItem.Enabled = False
        CerrarSesiónToolStripMenuItem.Enabled = False
    End Sub
End Class
