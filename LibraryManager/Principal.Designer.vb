<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.DataGridViewLibros = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoLibroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.buscarAutor = New System.Windows.Forms.TextBox()
        Me.buscarIsbn = New System.Windows.Forms.TextBox()
        Me.buscarTitulo = New System.Windows.Forms.TextBox()
        Me.buscarEditorial = New System.Windows.Forms.TextBox()
        Me.buscarDescripcion = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnReiniciar = New System.Windows.Forms.Button()
        CType(Me.DataGridViewLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewLibros
        '
        Me.DataGridViewLibros.AllowUserToAddRows = False
        Me.DataGridViewLibros.AllowUserToDeleteRows = False
        Me.DataGridViewLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewLibros.Location = New System.Drawing.Point(12, 120)
        Me.DataGridViewLibros.Name = "DataGridViewLibros"
        Me.DataGridViewLibros.ReadOnly = True
        Me.DataGridViewLibros.Size = New System.Drawing.Size(1069, 425)
        Me.DataGridViewLibros.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.LibrosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1093, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'LibrosToolStripMenuItem
        '
        Me.LibrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoLibroToolStripMenuItem})
        Me.LibrosToolStripMenuItem.Name = "LibrosToolStripMenuItem"
        Me.LibrosToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.LibrosToolStripMenuItem.Text = "&Libros"
        '
        'NuevoLibroToolStripMenuItem
        '
        Me.NuevoLibroToolStripMenuItem.Name = "NuevoLibroToolStripMenuItem"
        Me.NuevoLibroToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.NuevoLibroToolStripMenuItem.Text = "&Nuevo Libro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Título"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(498, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Autor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(287, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ISBN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(762, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Editorial"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Descripción"
        '
        'buscarAutor
        '
        Me.buscarAutor.Location = New System.Drawing.Point(536, 23)
        Me.buscarAutor.Name = "buscarAutor"
        Me.buscarAutor.Size = New System.Drawing.Size(220, 20)
        Me.buscarAutor.TabIndex = 8
        '
        'buscarIsbn
        '
        Me.buscarIsbn.Location = New System.Drawing.Point(325, 23)
        Me.buscarIsbn.Name = "buscarIsbn"
        Me.buscarIsbn.Size = New System.Drawing.Size(167, 20)
        Me.buscarIsbn.TabIndex = 9
        '
        'buscarTitulo
        '
        Me.buscarTitulo.Location = New System.Drawing.Point(75, 23)
        Me.buscarTitulo.Name = "buscarTitulo"
        Me.buscarTitulo.Size = New System.Drawing.Size(206, 20)
        Me.buscarTitulo.TabIndex = 10
        '
        'buscarEditorial
        '
        Me.buscarEditorial.Location = New System.Drawing.Point(812, 23)
        Me.buscarEditorial.Name = "buscarEditorial"
        Me.buscarEditorial.Size = New System.Drawing.Size(251, 20)
        Me.buscarEditorial.TabIndex = 11
        '
        'buscarDescripcion
        '
        Me.buscarDescripcion.Location = New System.Drawing.Point(75, 49)
        Me.buscarDescripcion.Name = "buscarDescripcion"
        Me.buscarDescripcion.Size = New System.Drawing.Size(681, 20)
        Me.buscarDescripcion.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnReiniciar)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.buscarAutor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.buscarDescripcion)
        Me.GroupBox1.Controls.Add(Me.buscarTitulo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.buscarEditorial)
        Me.GroupBox1.Controls.Add(Me.buscarIsbn)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1069, 87)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Libros"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(762, 47)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(143, 23)
        Me.btnBuscar.TabIndex = 13
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnReiniciar
        '
        Me.btnReiniciar.Location = New System.Drawing.Point(911, 47)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(152, 23)
        Me.btnReiniciar.TabIndex = 14
        Me.btnReiniciar.Text = "Reiniciar Filtro"
        Me.btnReiniciar.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 557)
        Me.Controls.Add(Me.DataGridViewLibros)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Principal"
        Me.Text = "Library Manager"
        CType(Me.DataGridViewLibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewLibros As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoLibroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents buscarAutor As TextBox
    Friend WithEvents buscarIsbn As TextBox
    Friend WithEvents buscarTitulo As TextBox
    Friend WithEvents buscarEditorial As TextBox
    Friend WithEvents buscarDescripcion As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnReiniciar As Button
    Friend WithEvents btnBuscar As Button
End Class
