<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2_Menu))
        Me.pnl_barraTitulo = New System.Windows.Forms.Panel()
        Me.btn_restaurar = New System.Windows.Forms.PictureBox()
        Me.lbl_empresa = New System.Windows.Forms.Label()
        Me.btn_maximizar = New System.Windows.Forms.PictureBox()
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_cerrar = New System.Windows.Forms.PictureBox()
        Me.pcbx_logo = New System.Windows.Forms.PictureBox()
        Me.btn_Menu = New System.Windows.Forms.Button()
        Me.btn_Inicio = New System.Windows.Forms.Button()
        Me.btn_Administracion = New System.Windows.Forms.Button()
        Me.btn_Clientes = New System.Windows.Forms.Button()
        Me.btn_Productos = New System.Windows.Forms.Button()
        Me.btn_Facturacion = New System.Windows.Forms.Button()
        Me.pnl_izquierda = New System.Windows.Forms.Panel()
        Me.btn_Documentos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pcbx_logout = New System.Windows.Forms.PictureBox()
        Me.pbl_sup2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnl_sup3 = New System.Windows.Forms.Panel()
        Me.pnl_subMenuAdministracion = New System.Windows.Forms.Panel()
        Me.btn_Descuento = New System.Windows.Forms.Button()
        Me.btn_tipoCambio = New System.Windows.Forms.Button()
        Me.btn_datosEmpresa = New System.Windows.Forms.Button()
        Me.btn_Empresa = New System.Windows.Forms.Button()
        Me.btn_mantenimientoUsuarios = New System.Windows.Forms.Button()
        Me.btn_Seguridad = New System.Windows.Forms.Button()
        Me.pnl_Facturacion = New System.Windows.Forms.Panel()
        Me.btn_facturaElectronica = New System.Windows.Forms.Button()
        Me.btn_facturarCliente = New System.Windows.Forms.Button()
        Me.btn_facturar = New System.Windows.Forms.Button()
        Me.pnl_barraTitulo.SuspendLayout()
        CType(Me.btn_restaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbx_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_izquierda.SuspendLayout()
        CType(Me.pcbx_logout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_subMenuAdministracion.SuspendLayout()
        Me.pnl_Facturacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_barraTitulo
        '
        Me.pnl_barraTitulo.BackColor = System.Drawing.Color.White
        Me.pnl_barraTitulo.Controls.Add(Me.btn_restaurar)
        Me.pnl_barraTitulo.Controls.Add(Me.lbl_empresa)
        Me.pnl_barraTitulo.Controls.Add(Me.btn_maximizar)
        Me.pnl_barraTitulo.Controls.Add(Me.btn_minimizar)
        Me.pnl_barraTitulo.Controls.Add(Me.btn_cerrar)
        Me.pnl_barraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_barraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnl_barraTitulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_barraTitulo.Name = "pnl_barraTitulo"
        Me.pnl_barraTitulo.Size = New System.Drawing.Size(1725, 40)
        Me.pnl_barraTitulo.TabIndex = 0
        '
        'btn_restaurar
        '
        Me.btn_restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_restaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_restaurar.Image = Global.Contador_Final.My.Resources.Resources.restore_14803
        Me.btn_restaurar.Location = New System.Drawing.Point(1615, 7)
        Me.btn_restaurar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_restaurar.Name = "btn_restaurar"
        Me.btn_restaurar.Size = New System.Drawing.Size(44, 28)
        Me.btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_restaurar.TabIndex = 3
        Me.btn_restaurar.TabStop = False
        '
        'lbl_empresa
        '
        Me.lbl_empresa.AutoSize = True
        Me.lbl_empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_empresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.lbl_empresa.Location = New System.Drawing.Point(509, 10)
        Me.lbl_empresa.Name = "lbl_empresa"
        Me.lbl_empresa.Size = New System.Drawing.Size(324, 24)
        Me.lbl_empresa.TabIndex = 4
        Me.lbl_empresa.Text = "EMPRESA EL CONTADOR FELIZ"
        '
        'btn_maximizar
        '
        Me.btn_maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_maximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_maximizar.Image = Global.Contador_Final.My.Resources.Resources.window_maximize_icon_137012
        Me.btn_maximizar.Location = New System.Drawing.Point(1615, 7)
        Me.btn_maximizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_maximizar.Name = "btn_maximizar"
        Me.btn_maximizar.Size = New System.Drawing.Size(44, 28)
        Me.btn_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_maximizar.TabIndex = 2
        Me.btn_maximizar.TabStop = False
        Me.btn_maximizar.Visible = False
        '
        'btn_minimizar
        '
        Me.btn_minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimizar.Image = Global.Contador_Final.My.Resources.Resources.minimize_14775
        Me.btn_minimizar.Location = New System.Drawing.Point(1567, 7)
        Me.btn_minimizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(44, 28)
        Me.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_minimizar.TabIndex = 1
        Me.btn_minimizar.TabStop = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cerrar.Image = Global.Contador_Final.My.Resources.Resources.exit_delete_17827
        Me.btn_cerrar.Location = New System.Drawing.Point(1661, 0)
        Me.btn_cerrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(53, 40)
        Me.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_cerrar.TabIndex = 0
        Me.btn_cerrar.TabStop = False
        '
        'pcbx_logo
        '
        Me.pcbx_logo.Image = Global.Contador_Final.My.Resources.Resources.ContadorFelizLogo
        Me.pcbx_logo.Location = New System.Drawing.Point(20, 19)
        Me.pcbx_logo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcbx_logo.Name = "pcbx_logo"
        Me.pcbx_logo.Size = New System.Drawing.Size(171, 110)
        Me.pcbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbx_logo.TabIndex = 0
        Me.pcbx_logo.TabStop = False
        '
        'btn_Menu
        '
        Me.btn_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Menu.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Menu.FlatAppearance.BorderSize = 0
        Me.btn_Menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Menu.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Menu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_Menu.Image = Global.Contador_Final.My.Resources.Resources._1486564398_menu2_81519
        Me.btn_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Menu.Location = New System.Drawing.Point(20, 150)
        Me.btn_Menu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Menu.Name = "btn_Menu"
        Me.btn_Menu.Size = New System.Drawing.Size(171, 48)
        Me.btn_Menu.TabIndex = 1
        Me.btn_Menu.Text = "Menu"
        Me.btn_Menu.UseVisualStyleBackColor = False
        '
        'btn_Inicio
        '
        Me.btn_Inicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Inicio.FlatAppearance.BorderSize = 0
        Me.btn_Inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Inicio.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Inicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_Inicio.Image = Global.Contador_Final.My.Resources.Resources.blue_home_house_12608
        Me.btn_Inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Inicio.Location = New System.Drawing.Point(20, 202)
        Me.btn_Inicio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Inicio.Name = "btn_Inicio"
        Me.btn_Inicio.Size = New System.Drawing.Size(171, 48)
        Me.btn_Inicio.TabIndex = 2
        Me.btn_Inicio.Text = "Inicio"
        Me.btn_Inicio.UseVisualStyleBackColor = False
        '
        'btn_Administracion
        '
        Me.btn_Administracion.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Administracion.FlatAppearance.BorderSize = 0
        Me.btn_Administracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_Administracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Administracion.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Administracion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_Administracion.Image = Global.Contador_Final.My.Resources.Resources.blue_user_client_person_12581
        Me.btn_Administracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Administracion.Location = New System.Drawing.Point(20, 255)
        Me.btn_Administracion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Administracion.Name = "btn_Administracion"
        Me.btn_Administracion.Size = New System.Drawing.Size(171, 48)
        Me.btn_Administracion.TabIndex = 3
        Me.btn_Administracion.Text = "        Administracion"
        Me.btn_Administracion.UseVisualStyleBackColor = False
        '
        'btn_Clientes
        '
        Me.btn_Clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Clientes.FlatAppearance.BorderSize = 0
        Me.btn_Clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Clientes.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_Clientes.Image = Global.Contador_Final.My.Resources.Resources.blue_users_customers_clients_people_12438
        Me.btn_Clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Clientes.Location = New System.Drawing.Point(20, 310)
        Me.btn_Clientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Clientes.Name = "btn_Clientes"
        Me.btn_Clientes.Size = New System.Drawing.Size(171, 48)
        Me.btn_Clientes.TabIndex = 4
        Me.btn_Clientes.Text = "Clientes"
        Me.btn_Clientes.UseVisualStyleBackColor = False
        '
        'btn_Productos
        '
        Me.btn_Productos.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Productos.FlatAppearance.BorderSize = 0
        Me.btn_Productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Productos.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Productos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_Productos.Image = Global.Contador_Final.My.Resources.Resources.blueshoppingcart_azul_12543
        Me.btn_Productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Productos.Location = New System.Drawing.Point(20, 362)
        Me.btn_Productos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Productos.Name = "btn_Productos"
        Me.btn_Productos.Size = New System.Drawing.Size(171, 48)
        Me.btn_Productos.TabIndex = 5
        Me.btn_Productos.Text = "   Productos"
        Me.btn_Productos.UseVisualStyleBackColor = False
        '
        'btn_Facturacion
        '
        Me.btn_Facturacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Facturacion.FlatAppearance.BorderSize = 0
        Me.btn_Facturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_Facturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Facturacion.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Facturacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_Facturacion.Image = Global.Contador_Final.My.Resources.Resources.creditcard_23779
        Me.btn_Facturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Facturacion.Location = New System.Drawing.Point(20, 415)
        Me.btn_Facturacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Facturacion.Name = "btn_Facturacion"
        Me.btn_Facturacion.Size = New System.Drawing.Size(171, 48)
        Me.btn_Facturacion.TabIndex = 6
        Me.btn_Facturacion.Text = "      Facturación"
        Me.btn_Facturacion.UseVisualStyleBackColor = False
        '
        'pnl_izquierda
        '
        Me.pnl_izquierda.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.pnl_izquierda.Controls.Add(Me.btn_Documentos)
        Me.pnl_izquierda.Controls.Add(Me.Label1)
        Me.pnl_izquierda.Controls.Add(Me.pcbx_logout)
        Me.pnl_izquierda.Controls.Add(Me.pcbx_logo)
        Me.pnl_izquierda.Controls.Add(Me.btn_Menu)
        Me.pnl_izquierda.Controls.Add(Me.btn_Facturacion)
        Me.pnl_izquierda.Controls.Add(Me.btn_Inicio)
        Me.pnl_izquierda.Controls.Add(Me.btn_Productos)
        Me.pnl_izquierda.Controls.Add(Me.btn_Administracion)
        Me.pnl_izquierda.Controls.Add(Me.btn_Clientes)
        Me.pnl_izquierda.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_izquierda.Location = New System.Drawing.Point(0, 40)
        Me.pnl_izquierda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_izquierda.Name = "pnl_izquierda"
        Me.pnl_izquierda.Size = New System.Drawing.Size(197, 885)
        Me.pnl_izquierda.TabIndex = 12
        '
        'btn_Documentos
        '
        Me.btn_Documentos.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Documentos.FlatAppearance.BorderSize = 0
        Me.btn_Documentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_Documentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Documentos.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Documentos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_Documentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Documentos.Location = New System.Drawing.Point(20, 469)
        Me.btn_Documentos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Documentos.Name = "btn_Documentos"
        Me.btn_Documentos.Size = New System.Drawing.Size(171, 47)
        Me.btn_Documentos.TabIndex = 17
        Me.btn_Documentos.Text = "   Documentos Emitidos"
        Me.btn_Documentos.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 603)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Cerrar sesión"
        '
        'pcbx_logout
        '
        Me.pcbx_logout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbx_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbx_logout.Image = Global.Contador_Final.My.Resources.Resources.off_logout_17916_48
        Me.pcbx_logout.Location = New System.Drawing.Point(20, 574)
        Me.pcbx_logout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcbx_logout.Name = "pcbx_logout"
        Me.pcbx_logout.Size = New System.Drawing.Size(53, 47)
        Me.pcbx_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbx_logout.TabIndex = 15
        Me.pcbx_logout.TabStop = False
        '
        'pbl_sup2
        '
        Me.pbl_sup2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.pbl_sup2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbl_sup2.Location = New System.Drawing.Point(197, 40)
        Me.pbl_sup2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbl_sup2.Name = "pbl_sup2"
        Me.pbl_sup2.Size = New System.Drawing.Size(1528, 40)
        Me.pbl_sup2.TabIndex = 13
        '
        'pnl_sup3
        '
        Me.pnl_sup3.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_sup3.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_sup3.Location = New System.Drawing.Point(197, 80)
        Me.pnl_sup3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_sup3.Name = "pnl_sup3"
        Me.pnl_sup3.Size = New System.Drawing.Size(1528, 40)
        Me.pnl_sup3.TabIndex = 14
        '
        'pnl_subMenuAdministracion
        '
        Me.pnl_subMenuAdministracion.BackColor = System.Drawing.Color.White
        Me.pnl_subMenuAdministracion.Controls.Add(Me.btn_Descuento)
        Me.pnl_subMenuAdministracion.Controls.Add(Me.btn_tipoCambio)
        Me.pnl_subMenuAdministracion.Controls.Add(Me.btn_datosEmpresa)
        Me.pnl_subMenuAdministracion.Controls.Add(Me.btn_Empresa)
        Me.pnl_subMenuAdministracion.Controls.Add(Me.btn_mantenimientoUsuarios)
        Me.pnl_subMenuAdministracion.Controls.Add(Me.btn_Seguridad)
        Me.pnl_subMenuAdministracion.Location = New System.Drawing.Point(201, 295)
        Me.pnl_subMenuAdministracion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_subMenuAdministracion.Name = "pnl_subMenuAdministracion"
        Me.pnl_subMenuAdministracion.Size = New System.Drawing.Size(188, 205)
        Me.pnl_subMenuAdministracion.TabIndex = 15
        Me.pnl_subMenuAdministracion.Visible = False
        '
        'btn_Descuento
        '
        Me.btn_Descuento.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Descuento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Descuento.FlatAppearance.BorderSize = 0
        Me.btn_Descuento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_Descuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Descuento.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Descuento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_Descuento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Descuento.Location = New System.Drawing.Point(3, 169)
        Me.btn_Descuento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Descuento.Name = "btn_Descuento"
        Me.btn_Descuento.Size = New System.Drawing.Size(183, 32)
        Me.btn_Descuento.TabIndex = 20
        Me.btn_Descuento.Text = "- Descuentos"
        Me.btn_Descuento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Descuento.UseVisualStyleBackColor = False
        '
        'btn_tipoCambio
        '
        Me.btn_tipoCambio.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_tipoCambio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_tipoCambio.FlatAppearance.BorderSize = 0
        Me.btn_tipoCambio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_tipoCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tipoCambio.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tipoCambio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_tipoCambio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_tipoCambio.Location = New System.Drawing.Point(3, 135)
        Me.btn_tipoCambio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_tipoCambio.Name = "btn_tipoCambio"
        Me.btn_tipoCambio.Size = New System.Drawing.Size(183, 32)
        Me.btn_tipoCambio.TabIndex = 3
        Me.btn_tipoCambio.Text = "- Tipos de cambio"
        Me.btn_tipoCambio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_tipoCambio.UseVisualStyleBackColor = False
        '
        'btn_datosEmpresa
        '
        Me.btn_datosEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_datosEmpresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_datosEmpresa.FlatAppearance.BorderSize = 0
        Me.btn_datosEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_datosEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_datosEmpresa.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_datosEmpresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_datosEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_datosEmpresa.Location = New System.Drawing.Point(3, 102)
        Me.btn_datosEmpresa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_datosEmpresa.Name = "btn_datosEmpresa"
        Me.btn_datosEmpresa.Size = New System.Drawing.Size(183, 32)
        Me.btn_datosEmpresa.TabIndex = 2
        Me.btn_datosEmpresa.Text = "- Datos de empresa"
        Me.btn_datosEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_datosEmpresa.UseVisualStyleBackColor = False
        '
        'btn_Empresa
        '
        Me.btn_Empresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Empresa.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Empresa.FlatAppearance.BorderSize = 0
        Me.btn_Empresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Empresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Empresa.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Empresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_Empresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Empresa.Location = New System.Drawing.Point(3, 69)
        Me.btn_Empresa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Empresa.Name = "btn_Empresa"
        Me.btn_Empresa.Size = New System.Drawing.Size(183, 32)
        Me.btn_Empresa.TabIndex = 17
        Me.btn_Empresa.Text = "Empresa"
        Me.btn_Empresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Empresa.UseVisualStyleBackColor = False
        '
        'btn_mantenimientoUsuarios
        '
        Me.btn_mantenimientoUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_mantenimientoUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mantenimientoUsuarios.FlatAppearance.BorderSize = 0
        Me.btn_mantenimientoUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_mantenimientoUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mantenimientoUsuarios.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mantenimientoUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_mantenimientoUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mantenimientoUsuarios.Location = New System.Drawing.Point(3, 35)
        Me.btn_mantenimientoUsuarios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_mantenimientoUsuarios.Name = "btn_mantenimientoUsuarios"
        Me.btn_mantenimientoUsuarios.Size = New System.Drawing.Size(183, 32)
        Me.btn_mantenimientoUsuarios.TabIndex = 1
        Me.btn_mantenimientoUsuarios.Text = "- Mantenimiento usuarios"
        Me.btn_mantenimientoUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mantenimientoUsuarios.UseVisualStyleBackColor = False
        '
        'btn_Seguridad
        '
        Me.btn_Seguridad.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Seguridad.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Seguridad.FlatAppearance.BorderSize = 0
        Me.btn_Seguridad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Seguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Seguridad.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Seguridad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_Seguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Seguridad.Location = New System.Drawing.Point(3, 2)
        Me.btn_Seguridad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Seguridad.Name = "btn_Seguridad"
        Me.btn_Seguridad.Size = New System.Drawing.Size(183, 32)
        Me.btn_Seguridad.TabIndex = 16
        Me.btn_Seguridad.Text = "Seguridad"
        Me.btn_Seguridad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Seguridad.UseVisualStyleBackColor = False
        '
        'pnl_Facturacion
        '
        Me.pnl_Facturacion.BackColor = System.Drawing.Color.White
        Me.pnl_Facturacion.Controls.Add(Me.btn_facturaElectronica)
        Me.pnl_Facturacion.Controls.Add(Me.btn_facturarCliente)
        Me.pnl_Facturacion.Controls.Add(Me.btn_facturar)
        Me.pnl_Facturacion.Location = New System.Drawing.Point(201, 455)
        Me.pnl_Facturacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_Facturacion.Name = "pnl_Facturacion"
        Me.pnl_Facturacion.Size = New System.Drawing.Size(188, 102)
        Me.pnl_Facturacion.TabIndex = 16
        Me.pnl_Facturacion.Visible = False
        '
        'btn_facturaElectronica
        '
        Me.btn_facturaElectronica.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_facturaElectronica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_facturaElectronica.FlatAppearance.BorderSize = 0
        Me.btn_facturaElectronica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_facturaElectronica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_facturaElectronica.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_facturaElectronica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_facturaElectronica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_facturaElectronica.Location = New System.Drawing.Point(3, 69)
        Me.btn_facturaElectronica.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_facturaElectronica.Name = "btn_facturaElectronica"
        Me.btn_facturaElectronica.Size = New System.Drawing.Size(183, 32)
        Me.btn_facturaElectronica.TabIndex = 5
        Me.btn_facturaElectronica.Text = "- Factura electrónica"
        Me.btn_facturaElectronica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_facturaElectronica.UseVisualStyleBackColor = False
        '
        'btn_facturarCliente
        '
        Me.btn_facturarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_facturarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_facturarCliente.FlatAppearance.BorderSize = 0
        Me.btn_facturarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_facturarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_facturarCliente.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_facturarCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_facturarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_facturarCliente.Location = New System.Drawing.Point(3, 35)
        Me.btn_facturarCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_facturarCliente.Name = "btn_facturarCliente"
        Me.btn_facturarCliente.Size = New System.Drawing.Size(183, 32)
        Me.btn_facturarCliente.TabIndex = 4
        Me.btn_facturarCliente.Text = "- Facturar Cliente"
        Me.btn_facturarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_facturarCliente.UseVisualStyleBackColor = False
        '
        'btn_facturar
        '
        Me.btn_facturar.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_facturar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_facturar.FlatAppearance.BorderSize = 0
        Me.btn_facturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_facturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_facturar.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_facturar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_facturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_facturar.Location = New System.Drawing.Point(3, 2)
        Me.btn_facturar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_facturar.Name = "btn_facturar"
        Me.btn_facturar.Size = New System.Drawing.Size(183, 32)
        Me.btn_facturar.TabIndex = 16
        Me.btn_facturar.Text = "Facturar"
        Me.btn_facturar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_facturar.UseVisualStyleBackColor = False
        '
        'Form2_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BackgroundImage = Global.Contador_Final.My.Resources.Resources.RegistrosContables
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1725, 925)
        Me.Controls.Add(Me.pnl_Facturacion)
        Me.Controls.Add(Me.pnl_subMenuAdministracion)
        Me.Controls.Add(Me.pnl_sup3)
        Me.Controls.Add(Me.pbl_sup2)
        Me.Controls.Add(Me.pnl_izquierda)
        Me.Controls.Add(Me.pnl_barraTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form2_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_barraTitulo.ResumeLayout(False)
        Me.pnl_barraTitulo.PerformLayout()
        CType(Me.btn_restaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbx_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_izquierda.ResumeLayout(False)
        Me.pnl_izquierda.PerformLayout()
        CType(Me.pcbx_logout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_subMenuAdministracion.ResumeLayout(False)
        Me.pnl_Facturacion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_barraTitulo As Panel
    Friend WithEvents btn_cerrar As PictureBox
    Friend WithEvents btn_minimizar As PictureBox
    Friend WithEvents btn_maximizar As PictureBox
    Friend WithEvents btn_restaurar As PictureBox
    Friend WithEvents btn_Facturacion As Button
    Friend WithEvents btn_Productos As Button
    Friend WithEvents btn_Clientes As Button
    Friend WithEvents btn_Administracion As Button
    Friend WithEvents btn_Inicio As Button
    Friend WithEvents btn_Menu As Button
    Friend WithEvents pcbx_logo As PictureBox
    Friend WithEvents pnl_izquierda As Panel
    Friend WithEvents lbl_empresa As Label
    Friend WithEvents pbl_sup2 As FlowLayoutPanel
    Friend WithEvents pnl_sup3 As Panel
    Friend WithEvents pcbx_logout As PictureBox
    Friend WithEvents pnl_subMenuAdministracion As Panel
    Friend WithEvents btn_Descuento As Button
    Friend WithEvents btn_tipoCambio As Button
    Friend WithEvents btn_datosEmpresa As Button
    Friend WithEvents btn_Empresa As Button
    Friend WithEvents btn_mantenimientoUsuarios As Button
    Friend WithEvents btn_Seguridad As Button
    Friend WithEvents pnl_Facturacion As Panel
    Friend WithEvents btn_facturaElectronica As Button
    Friend WithEvents btn_facturarCliente As Button
    Friend WithEvents btn_facturar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Documentos As Button
End Class
