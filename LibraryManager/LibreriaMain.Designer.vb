<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LibreriaMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LibreriaMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarLaSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibreríaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoLibroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurarProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurarCuentaDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprobarActualizacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaEnLíneaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RellenarLibrosByTituloToolStrip = New System.Windows.Forms.ToolStrip()
        Me.TituloToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.TituloToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.RellenarLibrosByTituloToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.RellenarLibrosByDescripcionToolStrip = New System.Windows.Forms.ToolStrip()
        Me.DescripcionToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.DescripcionToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.RellenarLibrosByDescripcionToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.RellenarLibrosByAutorToolStrip = New System.Windows.Forms.ToolStrip()
        Me.AutorToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.AutorToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.RellenarLibrosByAutorToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.RellenarLibrosByIsbnToolStrip = New System.Windows.Forms.ToolStrip()
        Me.IsbnToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.IsbnToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RellenarLibrosByIsbnToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GroupBoxBookPreview = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.labelDescripcion = New System.Windows.Forms.Label()
        Me.labelTitulo = New System.Windows.Forms.Label()
        Me.btnLimpiarBusqueda = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TituloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AutorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsbnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditorialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibreriaieleDataSet = New LibraryManager.LibraryManagerDataSet()
        Me.LibrosTableAdapter = New LibraryManager.LibraryManagerDataSetTableAdapters.librosTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RellenarLibrosByTituloToolStrip.SuspendLayout()
        Me.RellenarLibrosByDescripcionToolStrip.SuspendLayout()
        Me.RellenarLibrosByAutorToolStrip.SuspendLayout()
        Me.RellenarLibrosByIsbnToolStrip.SuspendLayout()
        Me.GroupBoxBookPreview.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibreriaieleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Sen", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.LibreríaToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1197, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarLaSesiónToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(63, 22)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'CerrarLaSesiónToolStripMenuItem
        '
        Me.CerrarLaSesiónToolStripMenuItem.Name = "CerrarLaSesiónToolStripMenuItem"
        Me.CerrarLaSesiónToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CerrarLaSesiónToolStripMenuItem.Text = "Cerrar la sesión"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'LibreríaToolStripMenuItem
        '
        Me.LibreríaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibrosToolStripMenuItem, Me.VentasToolStripMenuItem})
        Me.LibreríaToolStripMenuItem.Name = "LibreríaToolStripMenuItem"
        Me.LibreríaToolStripMenuItem.Size = New System.Drawing.Size(66, 22)
        Me.LibreríaToolStripMenuItem.Text = "Librería"
        '
        'LibrosToolStripMenuItem
        '
        Me.LibrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoLibroToolStripMenuItem})
        Me.LibrosToolStripMenuItem.Name = "LibrosToolStripMenuItem"
        Me.LibrosToolStripMenuItem.Size = New System.Drawing.Size(307, 22)
        Me.LibrosToolStripMenuItem.Text = "Libros"
        '
        'NuevoLibroToolStripMenuItem
        '
        Me.NuevoLibroToolStripMenuItem.Name = "NuevoLibroToolStripMenuItem"
        Me.NuevoLibroToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.NuevoLibroToolStripMenuItem.Text = "Nuevo libro"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarVentasToolStripMenuItem, Me.NuevaVentaToolStripMenuItem})
        Me.VentasToolStripMenuItem.Enabled = False
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(307, 22)
        Me.VentasToolStripMenuItem.Text = "Ventas (Disponible en futuras versiones)"
        '
        'ConsultarVentasToolStripMenuItem
        '
        Me.ConsultarVentasToolStripMenuItem.Name = "ConsultarVentasToolStripMenuItem"
        Me.ConsultarVentasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConsultarVentasToolStripMenuItem.Text = "Consultar ventas"
        '
        'NuevaVentaToolStripMenuItem
        '
        Me.NuevaVentaToolStripMenuItem.Name = "NuevaVentaToolStripMenuItem"
        Me.NuevaVentaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NuevaVentaToolStripMenuItem.Text = "Nueva venta"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigurarProgramaToolStripMenuItem, Me.ConfigurarCuentaDeUsuarioToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Enabled = False
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'ConfigurarProgramaToolStripMenuItem
        '
        Me.ConfigurarProgramaToolStripMenuItem.Name = "ConfigurarProgramaToolStripMenuItem"
        Me.ConfigurarProgramaToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.ConfigurarProgramaToolStripMenuItem.Text = "Configurar Programa"
        '
        'ConfigurarCuentaDeUsuarioToolStripMenuItem
        '
        Me.ConfigurarCuentaDeUsuarioToolStripMenuItem.Name = "ConfigurarCuentaDeUsuarioToolStripMenuItem"
        Me.ConfigurarCuentaDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.ConfigurarCuentaDeUsuarioToolStripMenuItem.Text = "Configurar Cuenta de Usuario"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.ComprobarActualizacionesToolStripMenuItem, Me.AyudaEnLíneaToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(56, 22)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'ComprobarActualizacionesToolStripMenuItem
        '
        Me.ComprobarActualizacionesToolStripMenuItem.Name = "ComprobarActualizacionesToolStripMenuItem"
        Me.ComprobarActualizacionesToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ComprobarActualizacionesToolStripMenuItem.Text = "Comprobar actualizaciones"
        '
        'AyudaEnLíneaToolStripMenuItem
        '
        Me.AyudaEnLíneaToolStripMenuItem.Name = "AyudaEnLíneaToolStripMenuItem"
        Me.AyudaEnLíneaToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.AyudaEnLíneaToolStripMenuItem.Text = "Ayuda en línea"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1177, 471)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.TituloDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.AutorDataGridViewTextBoxColumn, Me.IsbnDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.EditorialDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LibrosBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1171, 452)
        Me.DataGridView1.TabIndex = 0
        '
        'RellenarLibrosByTituloToolStrip
        '
        Me.RellenarLibrosByTituloToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.RellenarLibrosByTituloToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TituloToolStripLabel, Me.TituloToolStripTextBox, Me.RellenarLibrosByTituloToolStripButton})
        Me.RellenarLibrosByTituloToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.RellenarLibrosByTituloToolStrip.Name = "RellenarLibrosByTituloToolStrip"
        Me.RellenarLibrosByTituloToolStrip.Size = New System.Drawing.Size(260, 25)
        Me.RellenarLibrosByTituloToolStrip.TabIndex = 5
        Me.RellenarLibrosByTituloToolStrip.Text = "RellenarLibrosByTituloToolStrip"
        '
        'TituloToolStripLabel
        '
        Me.TituloToolStripLabel.Font = New System.Drawing.Font("Sen", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TituloToolStripLabel.Name = "TituloToolStripLabel"
        Me.TituloToolStripLabel.Size = New System.Drawing.Size(45, 22)
        Me.TituloToolStripLabel.Text = "Título:"
        '
        'TituloToolStripTextBox
        '
        Me.TituloToolStripTextBox.Font = New System.Drawing.Font("Sen", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TituloToolStripTextBox.Name = "TituloToolStripTextBox"
        Me.TituloToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'RellenarLibrosByTituloToolStripButton
        '
        Me.RellenarLibrosByTituloToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RellenarLibrosByTituloToolStripButton.Font = New System.Drawing.Font("Sen", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RellenarLibrosByTituloToolStripButton.Name = "RellenarLibrosByTituloToolStripButton"
        Me.RellenarLibrosByTituloToolStripButton.Size = New System.Drawing.Size(101, 22)
        Me.RellenarLibrosByTituloToolStripButton.Text = "Buscar por Título"
        '
        'RellenarLibrosByDescripcionToolStrip
        '
        Me.RellenarLibrosByDescripcionToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.RellenarLibrosByDescripcionToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DescripcionToolStripLabel, Me.DescripcionToolStripTextBox, Me.RellenarLibrosByDescripcionToolStripButton})
        Me.RellenarLibrosByDescripcionToolStrip.Location = New System.Drawing.Point(256, 24)
        Me.RellenarLibrosByDescripcionToolStrip.Name = "RellenarLibrosByDescripcionToolStrip"
        Me.RellenarLibrosByDescripcionToolStrip.Size = New System.Drawing.Size(313, 25)
        Me.RellenarLibrosByDescripcionToolStrip.TabIndex = 6
        Me.RellenarLibrosByDescripcionToolStrip.Text = "RellenarLibrosByDescripcionToolStrip"
        '
        'DescripcionToolStripLabel
        '
        Me.DescripcionToolStripLabel.Font = New System.Drawing.Font("Sen", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionToolStripLabel.Name = "DescripcionToolStripLabel"
        Me.DescripcionToolStripLabel.Size = New System.Drawing.Size(70, 22)
        Me.DescripcionToolStripLabel.Text = "Descripción:"
        '
        'DescripcionToolStripTextBox
        '
        Me.DescripcionToolStripTextBox.Font = New System.Drawing.Font("Sen", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionToolStripTextBox.Name = "DescripcionToolStripTextBox"
        Me.DescripcionToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'RellenarLibrosByDescripcionToolStripButton
        '
        Me.RellenarLibrosByDescripcionToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RellenarLibrosByDescripcionToolStripButton.Font = New System.Drawing.Font("Sen", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RellenarLibrosByDescripcionToolStripButton.Name = "RellenarLibrosByDescripcionToolStripButton"
        Me.RellenarLibrosByDescripcionToolStripButton.Size = New System.Drawing.Size(129, 22)
        Me.RellenarLibrosByDescripcionToolStripButton.Text = "Buscar por Descripción"
        '
        'RellenarLibrosByAutorToolStrip
        '
        Me.RellenarLibrosByAutorToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.RellenarLibrosByAutorToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutorToolStripLabel, Me.AutorToolStripTextBox, Me.RellenarLibrosByAutorToolStripButton})
        Me.RellenarLibrosByAutorToolStrip.Location = New System.Drawing.Point(574, 24)
        Me.RellenarLibrosByAutorToolStrip.Name = "RellenarLibrosByAutorToolStrip"
        Me.RellenarLibrosByAutorToolStrip.Size = New System.Drawing.Size(253, 25)
        Me.RellenarLibrosByAutorToolStrip.TabIndex = 7
        Me.RellenarLibrosByAutorToolStrip.Text = "RellenarLibrosByAutorToolStrip"
        '
        'AutorToolStripLabel
        '
        Me.AutorToolStripLabel.Font = New System.Drawing.Font("Sen", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutorToolStripLabel.Name = "AutorToolStripLabel"
        Me.AutorToolStripLabel.Size = New System.Drawing.Size(40, 22)
        Me.AutorToolStripLabel.Text = "Autor:"
        '
        'AutorToolStripTextBox
        '
        Me.AutorToolStripTextBox.Font = New System.Drawing.Font("Sen", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutorToolStripTextBox.Name = "AutorToolStripTextBox"
        Me.AutorToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'RellenarLibrosByAutorToolStripButton
        '
        Me.RellenarLibrosByAutorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RellenarLibrosByAutorToolStripButton.Font = New System.Drawing.Font("Sen", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RellenarLibrosByAutorToolStripButton.Name = "RellenarLibrosByAutorToolStripButton"
        Me.RellenarLibrosByAutorToolStripButton.Size = New System.Drawing.Size(99, 22)
        Me.RellenarLibrosByAutorToolStripButton.Text = "Buscar por Autor"
        '
        'RellenarLibrosByIsbnToolStrip
        '
        Me.RellenarLibrosByIsbnToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.RellenarLibrosByIsbnToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IsbnToolStripLabel, Me.IsbnToolStripTextBox, Me.ToolStripSeparator1, Me.RellenarLibrosByIsbnToolStripButton})
        Me.RellenarLibrosByIsbnToolStrip.Location = New System.Drawing.Point(828, 24)
        Me.RellenarLibrosByIsbnToolStrip.Name = "RellenarLibrosByIsbnToolStrip"
        Me.RellenarLibrosByIsbnToolStrip.Size = New System.Drawing.Size(255, 25)
        Me.RellenarLibrosByIsbnToolStrip.TabIndex = 8
        Me.RellenarLibrosByIsbnToolStrip.Text = "RellenarLibrosByIsbnToolStrip"
        '
        'IsbnToolStripLabel
        '
        Me.IsbnToolStripLabel.Font = New System.Drawing.Font("Sen", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsbnToolStripLabel.Name = "IsbnToolStripLabel"
        Me.IsbnToolStripLabel.Size = New System.Drawing.Size(38, 22)
        Me.IsbnToolStripLabel.Text = "ISBN:"
        '
        'IsbnToolStripTextBox
        '
        Me.IsbnToolStripTextBox.Font = New System.Drawing.Font("Sen", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsbnToolStripTextBox.Name = "IsbnToolStripTextBox"
        Me.IsbnToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'RellenarLibrosByIsbnToolStripButton
        '
        Me.RellenarLibrosByIsbnToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RellenarLibrosByIsbnToolStripButton.Font = New System.Drawing.Font("Sen", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RellenarLibrosByIsbnToolStripButton.Name = "RellenarLibrosByIsbnToolStripButton"
        Me.RellenarLibrosByIsbnToolStripButton.Size = New System.Drawing.Size(97, 22)
        Me.RellenarLibrosByIsbnToolStripButton.Text = "Buscar por ISBN"
        '
        'GroupBoxBookPreview
        '
        Me.GroupBoxBookPreview.Controls.Add(Me.Button2)
        Me.GroupBoxBookPreview.Controls.Add(Me.Button1)
        Me.GroupBoxBookPreview.Controls.Add(Me.PictureBox1)
        Me.GroupBoxBookPreview.Controls.Add(Me.labelDescripcion)
        Me.GroupBoxBookPreview.Controls.Add(Me.labelTitulo)
        Me.GroupBoxBookPreview.Font = New System.Drawing.Font("Sen", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxBookPreview.Location = New System.Drawing.Point(12, 529)
        Me.GroupBoxBookPreview.Name = "GroupBoxBookPreview"
        Me.GroupBoxBookPreview.Size = New System.Drawing.Size(1174, 281)
        Me.GroupBoxBookPreview.TabIndex = 9
        Me.GroupBoxBookPreview.TabStop = False
        Me.GroupBoxBookPreview.Text = "Previsualizar Libro"
        Me.GroupBoxBookPreview.Visible = False
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(1012, 252)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Vender"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1093, 252)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Ver Detalle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'labelDescripcion
        '
        Me.labelDescripcion.Font = New System.Drawing.Font("Sen", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDescripcion.Location = New System.Drawing.Point(266, 62)
        Me.labelDescripcion.Name = "labelDescripcion"
        Me.labelDescripcion.Size = New System.Drawing.Size(902, 176)
        Me.labelDescripcion.TabIndex = 2
        Me.labelDescripcion.Text = "Label1"
        '
        'labelTitulo
        '
        Me.labelTitulo.Font = New System.Drawing.Font("Sen", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitulo.Location = New System.Drawing.Point(263, 20)
        Me.labelTitulo.Name = "labelTitulo"
        Me.labelTitulo.Size = New System.Drawing.Size(905, 33)
        Me.labelTitulo.TabIndex = 1
        Me.labelTitulo.Text = "Label_Titulo"
        '
        'btnLimpiarBusqueda
        '
        Me.btnLimpiarBusqueda.Font = New System.Drawing.Font("Sen", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarBusqueda.Location = New System.Drawing.Point(1082, 25)
        Me.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda"
        Me.btnLimpiarBusqueda.Size = New System.Drawing.Size(107, 23)
        Me.btnLimpiarBusqueda.TabIndex = 10
        Me.btnLimpiarBusqueda.Text = "Limpiar"
        Me.btnLimpiarBusqueda.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(6, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 255)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TituloDataGridViewTextBoxColumn
        '
        Me.TituloDataGridViewTextBoxColumn.DataPropertyName = "titulo"
        Me.TituloDataGridViewTextBoxColumn.HeaderText = "titulo"
        Me.TituloDataGridViewTextBoxColumn.Name = "TituloDataGridViewTextBoxColumn"
        Me.TituloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AutorDataGridViewTextBoxColumn
        '
        Me.AutorDataGridViewTextBoxColumn.DataPropertyName = "autor"
        Me.AutorDataGridViewTextBoxColumn.HeaderText = "autor"
        Me.AutorDataGridViewTextBoxColumn.Name = "AutorDataGridViewTextBoxColumn"
        Me.AutorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IsbnDataGridViewTextBoxColumn
        '
        Me.IsbnDataGridViewTextBoxColumn.DataPropertyName = "isbn"
        Me.IsbnDataGridViewTextBoxColumn.HeaderText = "isbn"
        Me.IsbnDataGridViewTextBoxColumn.Name = "IsbnDataGridViewTextBoxColumn"
        Me.IsbnDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EditorialDataGridViewTextBoxColumn
        '
        Me.EditorialDataGridViewTextBoxColumn.DataPropertyName = "editorial"
        Me.EditorialDataGridViewTextBoxColumn.HeaderText = "editorial"
        Me.EditorialDataGridViewTextBoxColumn.Name = "EditorialDataGridViewTextBoxColumn"
        Me.EditorialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LibrosBindingSource
        '
        Me.LibrosBindingSource.DataMember = "libros"
        Me.LibrosBindingSource.DataSource = Me.LibreriaieleDataSet
        '
        'LibreriaieleDataSet
        '
        Me.LibreriaieleDataSet.DataSetName = "libreriaieleDataSet"
        Me.LibreriaieleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LibrosTableAdapter
        '
        Me.LibrosTableAdapter.ClearBeforeFill = True
        '
        'LibreriaMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 822)
        Me.Controls.Add(Me.btnLimpiarBusqueda)
        Me.Controls.Add(Me.GroupBoxBookPreview)
        Me.Controls.Add(Me.RellenarLibrosByIsbnToolStrip)
        Me.Controls.Add(Me.RellenarLibrosByAutorToolStrip)
        Me.Controls.Add(Me.RellenarLibrosByDescripcionToolStrip)
        Me.Controls.Add(Me.RellenarLibrosByTituloToolStrip)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "LibreriaMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Manager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RellenarLibrosByTituloToolStrip.ResumeLayout(False)
        Me.RellenarLibrosByTituloToolStrip.PerformLayout()
        Me.RellenarLibrosByDescripcionToolStrip.ResumeLayout(False)
        Me.RellenarLibrosByDescripcionToolStrip.PerformLayout()
        Me.RellenarLibrosByAutorToolStrip.ResumeLayout(False)
        Me.RellenarLibrosByAutorToolStrip.PerformLayout()
        Me.RellenarLibrosByIsbnToolStrip.ResumeLayout(False)
        Me.RellenarLibrosByIsbnToolStrip.PerformLayout()
        Me.GroupBoxBookPreview.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibreriaieleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarLaSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibreríaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoLibroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprobarActualizacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaEnLíneaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LibreriaieleDataSet As LibraryManagerDataSet
    Friend WithEvents LibrosBindingSource As BindingSource
    Friend WithEvents LibrosTableAdapter As LibraryManagerDataSetTableAdapters.librosTableAdapter
    Friend WithEvents RellenarLibrosByTituloToolStrip As ToolStrip
    Friend WithEvents TituloToolStripLabel As ToolStripLabel
    Friend WithEvents TituloToolStripTextBox As ToolStripTextBox
    Friend WithEvents RellenarLibrosByTituloToolStripButton As ToolStripButton
    Friend WithEvents RellenarLibrosByDescripcionToolStrip As ToolStrip
    Friend WithEvents DescripcionToolStripLabel As ToolStripLabel
    Friend WithEvents DescripcionToolStripTextBox As ToolStripTextBox
    Friend WithEvents RellenarLibrosByDescripcionToolStripButton As ToolStripButton
    Friend WithEvents RellenarLibrosByAutorToolStrip As ToolStrip
    Friend WithEvents AutorToolStripLabel As ToolStripLabel
    Friend WithEvents AutorToolStripTextBox As ToolStripTextBox
    Friend WithEvents RellenarLibrosByAutorToolStripButton As ToolStripButton
    Friend WithEvents RellenarLibrosByIsbnToolStrip As ToolStrip
    Friend WithEvents IsbnToolStripLabel As ToolStripLabel
    Friend WithEvents IsbnToolStripTextBox As ToolStripTextBox
    Friend WithEvents RellenarLibrosByIsbnToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TituloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AutorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsbnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EditorialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBoxBookPreview As GroupBox
    Friend WithEvents labelTitulo As Label
    Friend WithEvents labelDescripcion As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLimpiarBusqueda As Button
    Friend WithEvents ConfigurarProgramaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfigurarCuentaDeUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
