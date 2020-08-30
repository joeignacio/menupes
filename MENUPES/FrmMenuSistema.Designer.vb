<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenuSistema
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuSistema))
        Me.RibbonControl1 = New DevComponents.DotNetBar.RibbonControl()
        Me.RibbonPanel3 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar14 = New DevComponents.DotNetBar.RibbonBar()
        Me.MenuCatalogo_Clientes = New DevComponents.DotNetBar.ButtonItem()
        Me.MenuCatalogo_Proveedores = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar9 = New DevComponents.DotNetBar.RibbonBar()
        Me.MenuCatalogo_TipoExistencias = New DevComponents.DotNetBar.ButtonItem()
        Me.MenuCatalogo_Lineas = New DevComponents.DotNetBar.ButtonItem()
        Me.MenuCatalogo_Categorias = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar8 = New DevComponents.DotNetBar.RibbonBar()
        Me.MenuCatalogo_ProductosServicios = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonPanel13 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar35 = New DevComponents.DotNetBar.RibbonBar()
        Me.MenuOpciones_CambiarContrasenia = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonPanel14 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar38 = New DevComponents.DotNetBar.RibbonBar()
        Me.MenuSalir_Salir = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar37 = New DevComponents.DotNetBar.RibbonBar()
        Me.MenuSalir_BloquearSistema = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar36 = New DevComponents.DotNetBar.RibbonBar()
        Me.MenuSalir_CambiarUsuario = New DevComponents.DotNetBar.ButtonItem()
        Me.ModuloArchivo = New DevComponents.DotNetBar.RibbonTabItem()
        Me.MenuOpciones = New DevComponents.DotNetBar.RibbonTabItem()
        Me.MenuSalir = New DevComponents.DotNetBar.RibbonTabItem()
        Me.TabbedMDIManager1 = New Syncfusion.Windows.Forms.Tools.TabbedMDIManager(Me.components)
        Me.RibbonControl1.SuspendLayout()
        Me.RibbonPanel3.SuspendLayout()
        Me.RibbonPanel13.SuspendLayout()
        Me.RibbonPanel14.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.RibbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel3)
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel14)
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel13)
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonControl1.ForeColor = System.Drawing.Color.Black
        Me.RibbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ModuloArchivo, Me.MenuOpciones, Me.MenuSalir})
        Me.RibbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.RibbonControl1.Size = New System.Drawing.Size(1120, 138)
        Me.RibbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
        Me.RibbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
        Me.RibbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
        Me.RibbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
        Me.RibbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
        Me.RibbonControl1.SystemText.QatDialogAddButton = "&Add >>"
        Me.RibbonControl1.SystemText.QatDialogCancelButton = "Cancel"
        Me.RibbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
        Me.RibbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
        Me.RibbonControl1.SystemText.QatDialogOkButton = "OK"
        Me.RibbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
        Me.RibbonControl1.SystemText.QatDialogRemoveButton = "&Remove"
        Me.RibbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
        Me.RibbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
        Me.RibbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
        Me.RibbonControl1.TabGroupHeight = 14
        Me.RibbonControl1.TabIndex = 1
        Me.RibbonControl1.UseCustomizeDialog = False
        '
        'RibbonPanel3
        '
        Me.RibbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel3.Controls.Add(Me.RibbonBar14)
        Me.RibbonPanel3.Controls.Add(Me.RibbonBar9)
        Me.RibbonPanel3.Controls.Add(Me.RibbonBar8)
        Me.RibbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel3.Location = New System.Drawing.Point(0, 26)
        Me.RibbonPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.RibbonPanel3.Name = "RibbonPanel3"
        Me.RibbonPanel3.Padding = New System.Windows.Forms.Padding(4, 0, 4, 3)
        Me.RibbonPanel3.Size = New System.Drawing.Size(1120, 109)
        '
        '
        '
        Me.RibbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel3.TabIndex = 3
        '
        'RibbonBar14
        '
        Me.RibbonBar14.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar14.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar14.ContainerControlProcessDialogKey = True
        Me.RibbonBar14.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar14.DragDropSupport = True
        Me.RibbonBar14.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MenuCatalogo_Clientes, Me.MenuCatalogo_Proveedores})
        Me.RibbonBar14.Location = New System.Drawing.Point(304, 0)
        Me.RibbonBar14.Margin = New System.Windows.Forms.Padding(4)
        Me.RibbonBar14.Name = "RibbonBar14"
        Me.RibbonBar14.Size = New System.Drawing.Size(165, 106)
        Me.RibbonBar14.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar14.TabIndex = 6
        '
        '
        '
        Me.RibbonBar14.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar14.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MenuCatalogo_Clientes
        '
        Me.MenuCatalogo_Clientes.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.MenuCatalogo_Clientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuCatalogo_Clientes.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.MenuCatalogo_Clientes.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.MenuCatalogo_Clientes.Name = "MenuCatalogo_Clientes"
        Me.MenuCatalogo_Clientes.SubItemsExpandWidth = 14
        Me.MenuCatalogo_Clientes.Symbol = ""
        Me.MenuCatalogo_Clientes.SymbolColor = System.Drawing.Color.MediumTurquoise
        Me.MenuCatalogo_Clientes.SymbolSize = 27.0!
        Me.MenuCatalogo_Clientes.Text = "Clientes"
        '
        'MenuCatalogo_Proveedores
        '
        Me.MenuCatalogo_Proveedores.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.MenuCatalogo_Proveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuCatalogo_Proveedores.ForeColor = System.Drawing.Color.Tomato
        Me.MenuCatalogo_Proveedores.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.MenuCatalogo_Proveedores.Name = "MenuCatalogo_Proveedores"
        Me.MenuCatalogo_Proveedores.SubItemsExpandWidth = 14
        Me.MenuCatalogo_Proveedores.Symbol = ""
        Me.MenuCatalogo_Proveedores.SymbolColor = System.Drawing.Color.LightSalmon
        Me.MenuCatalogo_Proveedores.SymbolSize = 27.0!
        Me.MenuCatalogo_Proveedores.Text = "Proveedores"
        '
        'RibbonBar9
        '
        Me.RibbonBar9.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar9.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar9.ContainerControlProcessDialogKey = True
        Me.RibbonBar9.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar9.DragDropSupport = True
        Me.RibbonBar9.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MenuCatalogo_TipoExistencias, Me.MenuCatalogo_Lineas, Me.MenuCatalogo_Categorias})
        Me.RibbonBar9.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.RibbonBar9.Location = New System.Drawing.Point(107, 0)
        Me.RibbonBar9.Margin = New System.Windows.Forms.Padding(4)
        Me.RibbonBar9.Name = "RibbonBar9"
        Me.RibbonBar9.Size = New System.Drawing.Size(197, 106)
        Me.RibbonBar9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar9.TabIndex = 1
        '
        '
        '
        Me.RibbonBar9.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar9.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MenuCatalogo_TipoExistencias
        '
        Me.MenuCatalogo_TipoExistencias.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.MenuCatalogo_TipoExistencias.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.MenuCatalogo_TipoExistencias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuCatalogo_TipoExistencias.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.MenuCatalogo_TipoExistencias.Name = "MenuCatalogo_TipoExistencias"
        Me.MenuCatalogo_TipoExistencias.SubItemsExpandWidth = 14
        Me.MenuCatalogo_TipoExistencias.Symbol = ""
        Me.MenuCatalogo_TipoExistencias.SymbolColor = System.Drawing.Color.CornflowerBlue
        Me.MenuCatalogo_TipoExistencias.SymbolSize = 14.0!
        Me.MenuCatalogo_TipoExistencias.Text = "Tipo de Existencias"
        '
        'MenuCatalogo_Lineas
        '
        Me.MenuCatalogo_Lineas.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.MenuCatalogo_Lineas.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.MenuCatalogo_Lineas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuCatalogo_Lineas.ForeColor = System.Drawing.Color.DimGray
        Me.MenuCatalogo_Lineas.Name = "MenuCatalogo_Lineas"
        Me.MenuCatalogo_Lineas.SubItemsExpandWidth = 14
        Me.MenuCatalogo_Lineas.Symbol = ""
        Me.MenuCatalogo_Lineas.SymbolColor = System.Drawing.Color.DimGray
        Me.MenuCatalogo_Lineas.SymbolSize = 14.0!
        Me.MenuCatalogo_Lineas.Text = "Lineas de Productos"
        '
        'MenuCatalogo_Categorias
        '
        Me.MenuCatalogo_Categorias.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.MenuCatalogo_Categorias.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.MenuCatalogo_Categorias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuCatalogo_Categorias.ForeColor = System.Drawing.Color.Chocolate
        Me.MenuCatalogo_Categorias.Name = "MenuCatalogo_Categorias"
        Me.MenuCatalogo_Categorias.SubItemsExpandWidth = 14
        Me.MenuCatalogo_Categorias.Symbol = ""
        Me.MenuCatalogo_Categorias.SymbolColor = System.Drawing.Color.Peru
        Me.MenuCatalogo_Categorias.SymbolSize = 14.0!
        Me.MenuCatalogo_Categorias.Text = "Categoría de Productos"
        '
        'RibbonBar8
        '
        Me.RibbonBar8.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar8.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar8.ContainerControlProcessDialogKey = True
        Me.RibbonBar8.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar8.DragDropSupport = True
        Me.RibbonBar8.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MenuCatalogo_ProductosServicios})
        Me.RibbonBar8.Location = New System.Drawing.Point(4, 0)
        Me.RibbonBar8.Margin = New System.Windows.Forms.Padding(4)
        Me.RibbonBar8.Name = "RibbonBar8"
        Me.RibbonBar8.Size = New System.Drawing.Size(103, 106)
        Me.RibbonBar8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar8.TabIndex = 0
        '
        '
        '
        Me.RibbonBar8.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar8.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MenuCatalogo_ProductosServicios
        '
        Me.MenuCatalogo_ProductosServicios.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.MenuCatalogo_ProductosServicios.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.MenuCatalogo_ProductosServicios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuCatalogo_ProductosServicios.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.MenuCatalogo_ProductosServicios.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.MenuCatalogo_ProductosServicios.Name = "MenuCatalogo_ProductosServicios"
        Me.MenuCatalogo_ProductosServicios.SubItemsExpandWidth = 14
        Me.MenuCatalogo_ProductosServicios.Symbol = ""
        Me.MenuCatalogo_ProductosServicios.SymbolColor = System.Drawing.Color.LightSeaGreen
        Me.MenuCatalogo_ProductosServicios.SymbolSize = 27.0!
        Me.MenuCatalogo_ProductosServicios.Text = "Productos y Servicios"
        '
        'RibbonPanel13
        '
        Me.RibbonPanel13.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel13.Controls.Add(Me.RibbonBar35)
        Me.RibbonPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel13.Location = New System.Drawing.Point(0, 26)
        Me.RibbonPanel13.Margin = New System.Windows.Forms.Padding(4)
        Me.RibbonPanel13.Name = "RibbonPanel13"
        Me.RibbonPanel13.Padding = New System.Windows.Forms.Padding(4, 0, 4, 3)
        Me.RibbonPanel13.Size = New System.Drawing.Size(1120, 109)
        '
        '
        '
        Me.RibbonPanel13.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel13.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel13.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel13.TabIndex = 13
        Me.RibbonPanel13.Visible = False
        '
        'RibbonBar35
        '
        Me.RibbonBar35.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar35.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar35.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar35.ContainerControlProcessDialogKey = True
        Me.RibbonBar35.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar35.DragDropSupport = True
        Me.RibbonBar35.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MenuOpciones_CambiarContrasenia})
        Me.RibbonBar35.Location = New System.Drawing.Point(4, 0)
        Me.RibbonBar35.Margin = New System.Windows.Forms.Padding(4)
        Me.RibbonBar35.Name = "RibbonBar35"
        Me.RibbonBar35.Size = New System.Drawing.Size(115, 106)
        Me.RibbonBar35.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar35.TabIndex = 0
        '
        '
        '
        Me.RibbonBar35.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar35.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MenuOpciones_CambiarContrasenia
        '
        Me.MenuOpciones_CambiarContrasenia.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.MenuOpciones_CambiarContrasenia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuOpciones_CambiarContrasenia.ForeColor = System.Drawing.Color.Maroon
        Me.MenuOpciones_CambiarContrasenia.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.MenuOpciones_CambiarContrasenia.Name = "MenuOpciones_CambiarContrasenia"
        Me.MenuOpciones_CambiarContrasenia.SubItemsExpandWidth = 14
        Me.MenuOpciones_CambiarContrasenia.Symbol = "59533"
        Me.MenuOpciones_CambiarContrasenia.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuOpciones_CambiarContrasenia.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.MenuOpciones_CambiarContrasenia.SymbolSize = 27.0!
        Me.MenuOpciones_CambiarContrasenia.Text = "Cambiar Contraseña"
        '
        'RibbonPanel14
        '
        Me.RibbonPanel14.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel14.Controls.Add(Me.RibbonBar38)
        Me.RibbonPanel14.Controls.Add(Me.RibbonBar37)
        Me.RibbonPanel14.Controls.Add(Me.RibbonBar36)
        Me.RibbonPanel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel14.Location = New System.Drawing.Point(0, 26)
        Me.RibbonPanel14.Margin = New System.Windows.Forms.Padding(4)
        Me.RibbonPanel14.Name = "RibbonPanel14"
        Me.RibbonPanel14.Padding = New System.Windows.Forms.Padding(4, 0, 4, 3)
        Me.RibbonPanel14.Size = New System.Drawing.Size(1120, 109)
        '
        '
        '
        Me.RibbonPanel14.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel14.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel14.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel14.TabIndex = 14
        Me.RibbonPanel14.Visible = False
        '
        'RibbonBar38
        '
        Me.RibbonBar38.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar38.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar38.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar38.ContainerControlProcessDialogKey = True
        Me.RibbonBar38.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar38.DragDropSupport = True
        Me.RibbonBar38.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MenuSalir_Salir})
        Me.RibbonBar38.Location = New System.Drawing.Point(215, 0)
        Me.RibbonBar38.Margin = New System.Windows.Forms.Padding(4)
        Me.RibbonBar38.Name = "RibbonBar38"
        Me.RibbonBar38.Size = New System.Drawing.Size(105, 106)
        Me.RibbonBar38.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar38.TabIndex = 2
        '
        '
        '
        Me.RibbonBar38.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar38.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MenuSalir_Salir
        '
        Me.MenuSalir_Salir.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.MenuSalir_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuSalir_Salir.ForeColor = System.Drawing.Color.Crimson
        Me.MenuSalir_Salir.Name = "MenuSalir_Salir"
        Me.MenuSalir_Salir.SubItemsExpandWidth = 14
        Me.MenuSalir_Salir.Symbol = "57410"
        Me.MenuSalir_Salir.SymbolColor = System.Drawing.Color.Crimson
        Me.MenuSalir_Salir.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.MenuSalir_Salir.SymbolSize = 27.0!
        Me.MenuSalir_Salir.Text = "Salir"
        '
        'RibbonBar37
        '
        Me.RibbonBar37.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar37.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar37.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar37.ContainerControlProcessDialogKey = True
        Me.RibbonBar37.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar37.DragDropSupport = True
        Me.RibbonBar37.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MenuSalir_BloquearSistema})
        Me.RibbonBar37.Location = New System.Drawing.Point(119, 0)
        Me.RibbonBar37.Margin = New System.Windows.Forms.Padding(4)
        Me.RibbonBar37.Name = "RibbonBar37"
        Me.RibbonBar37.Size = New System.Drawing.Size(96, 106)
        Me.RibbonBar37.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar37.TabIndex = 1
        '
        '
        '
        Me.RibbonBar37.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar37.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MenuSalir_BloquearSistema
        '
        Me.MenuSalir_BloquearSistema.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.MenuSalir_BloquearSistema.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuSalir_BloquearSistema.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.MenuSalir_BloquearSistema.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.MenuSalir_BloquearSistema.Name = "MenuSalir_BloquearSistema"
        Me.MenuSalir_BloquearSistema.SubItemsExpandWidth = 14
        Me.MenuSalir_BloquearSistema.Symbol = "57395"
        Me.MenuSalir_BloquearSistema.SymbolColor = System.Drawing.Color.PaleVioletRed
        Me.MenuSalir_BloquearSistema.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.MenuSalir_BloquearSistema.SymbolSize = 27.0!
        Me.MenuSalir_BloquearSistema.Text = "Bloquear Sistema"
        '
        'RibbonBar36
        '
        Me.RibbonBar36.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar36.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar36.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar36.ContainerControlProcessDialogKey = True
        Me.RibbonBar36.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar36.DragDropSupport = True
        Me.RibbonBar36.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MenuSalir_CambiarUsuario})
        Me.RibbonBar36.Location = New System.Drawing.Point(4, 0)
        Me.RibbonBar36.Margin = New System.Windows.Forms.Padding(4)
        Me.RibbonBar36.Name = "RibbonBar36"
        Me.RibbonBar36.Size = New System.Drawing.Size(115, 106)
        Me.RibbonBar36.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar36.TabIndex = 0
        '
        '
        '
        Me.RibbonBar36.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar36.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MenuSalir_CambiarUsuario
        '
        Me.MenuSalir_CambiarUsuario.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.MenuSalir_CambiarUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuSalir_CambiarUsuario.ForeColor = System.Drawing.Color.Teal
        Me.MenuSalir_CambiarUsuario.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.MenuSalir_CambiarUsuario.Name = "MenuSalir_CambiarUsuario"
        Me.MenuSalir_CambiarUsuario.SubItemsExpandWidth = 14
        Me.MenuSalir_CambiarUsuario.Symbol = "59486"
        Me.MenuSalir_CambiarUsuario.SymbolColor = System.Drawing.Color.Teal
        Me.MenuSalir_CambiarUsuario.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.MenuSalir_CambiarUsuario.SymbolSize = 27.0!
        Me.MenuSalir_CambiarUsuario.Text = "Cambiar de Usuario"
        '
        'ModuloArchivo
        '
        Me.ModuloArchivo.Checked = True
        Me.ModuloArchivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ModuloArchivo.Name = "ModuloArchivo"
        Me.ModuloArchivo.Panel = Me.RibbonPanel3
        Me.ModuloArchivo.Text = "Catálogos"
        '
        'MenuOpciones
        '
        Me.MenuOpciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuOpciones.Name = "MenuOpciones"
        Me.MenuOpciones.Panel = Me.RibbonPanel13
        Me.MenuOpciones.Text = "Opciones"
        '
        'MenuSalir
        '
        Me.MenuSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuSalir.Name = "MenuSalir"
        Me.MenuSalir.Panel = Me.RibbonPanel14
        Me.MenuSalir.Text = "Salir"
        '
        'TabbedMDIManager1
        '
        Me.TabbedMDIManager1.AttachedTo = Me
        Me.TabbedMDIManager1.CloseButtonBackColor = System.Drawing.Color.White
        Me.TabbedMDIManager1.CloseButtonToolTip = ""
        Me.TabbedMDIManager1.CloseOnMiddleButtonClick = True
        Me.TabbedMDIManager1.DropDownButtonToolTip = ""
        Me.TabbedMDIManager1.ImageSize = New System.Drawing.Size(16, 16)
        Me.TabbedMDIManager1.NeedUpdateHostedForm = False
        Me.TabbedMDIManager1.ShowCloseButton = True
        Me.TabbedMDIManager1.ShowCloseButtonBackColor = True
        Me.TabbedMDIManager1.ShowCloseButtonForActiveTabOnly = True
        Me.TabbedMDIManager1.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererWorkbookMode)
        '
        'FrmMenuSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 607)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMenuSistema"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.RibbonControl1.ResumeLayout(False)
        Me.RibbonControl1.PerformLayout()
        Me.RibbonPanel3.ResumeLayout(False)
        Me.RibbonPanel13.ResumeLayout(False)
        Me.RibbonPanel14.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonControl1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents RibbonPanel3 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents ModuloArchivo As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents TabbedMDIManager1 As Syncfusion.Windows.Forms.Tools.TabbedMDIManager
    Friend WithEvents RibbonBar8 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents MenuCatalogo_ProductosServicios As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar9 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents MenuCatalogo_TipoExistencias As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents MenuCatalogo_Lineas As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents MenuCatalogo_Categorias As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar14 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents MenuCatalogo_Clientes As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents MenuCatalogo_Proveedores As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonPanel13 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonBar35 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents MenuOpciones_CambiarContrasenia As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonPanel14 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents MenuOpciones As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents MenuSalir As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents RibbonBar36 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents MenuSalir_CambiarUsuario As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar38 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents MenuSalir_Salir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar37 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents MenuSalir_BloquearSistema As DevComponents.DotNetBar.ButtonItem
End Class
