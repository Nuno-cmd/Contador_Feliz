<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6_Facturar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6_Facturar))
        Me.pnl_barra2 = New System.Windows.Forms.Panel()
        Me.pnl_barra = New System.Windows.Forms.Panel()
        Me.lbl_tituloBarra = New System.Windows.Forms.Label()
        Me.btn_cerrar = New System.Windows.Forms.PictureBox()
        Me.btn_Restaurar = New System.Windows.Forms.PictureBox()
        Me.btn_Minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_Maximizar = New System.Windows.Forms.PictureBox()
        Me.btn_Guardar = New System.Windows.Forms.PictureBox()
        Me.btn_Actualizar = New System.Windows.Forms.PictureBox()
        Me.btn_Back = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_moneda = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_numDocumento = New System.Windows.Forms.TextBox()
        Me.cbx_tipoDocumento = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_emailEmpresa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_buscaEmpresa = New System.Windows.Forms.Button()
        Me.txt_buscaEmpresa = New System.Windows.Forms.TextBox()
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_referencia = New System.Windows.Forms.TextBox()
        Me.txt_DireccionEmpresa = New System.Windows.Forms.TextBox()
        Me.txt_TipoIDEmpresa = New System.Windows.Forms.TextBox()
        Me.txt_IDEmpresa = New System.Windows.Forms.TextBox()
        Me.txt_nombreEmpresa = New System.Windows.Forms.TextBox()
        Me.txt_Apellido1Empresa = New System.Windows.Forms.TextBox()
        Me.txt_Apellido2Empresa = New System.Windows.Forms.TextBox()
        Me.lbl_telEmpresa = New System.Windows.Forms.Label()
        Me.txt_FaxEmpresa = New System.Windows.Forms.TextBox()
        Me.lbl_faxDatosEmisor = New System.Windows.Forms.Label()
        Me.txt_Tel2Empresa = New System.Windows.Forms.TextBox()
        Me.lbl_direccionDatosEmisor = New System.Windows.Forms.Label()
        Me.txt_Tel1Empresa = New System.Windows.Forms.TextBox()
        Me.txt_DistritoEmpresa = New System.Windows.Forms.TextBox()
        Me.txt_CantonEmpresa = New System.Windows.Forms.TextBox()
        Me.txt_ProvinciaEmpresa = New System.Windows.Forms.TextBox()
        Me.txt_fecha = New System.Windows.Forms.TextBox()
        Me.lbl_emailDatosEmpresa = New System.Windows.Forms.Label()
        Me.txt_nombreComercial = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_apellido2 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_apellido1 = New System.Windows.Forms.TextBox()
        Me.lbl_apellido1Cliente = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_buscarCliente = New System.Windows.Forms.Button()
        Me.txt_idInternoCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cambioMonedaCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbx_Distrito = New System.Windows.Forms.ComboBox()
        Me.cbx_Canton = New System.Windows.Forms.ComboBox()
        Me.cbx_Provincia = New System.Windows.Forms.ComboBox()
        Me.lbl_distrito = New System.Windows.Forms.Label()
        Me.lbl_canton = New System.Windows.Forms.Label()
        Me.lbl_provincia = New System.Windows.Forms.Label()
        Me.cbx_pais = New System.Windows.Forms.ComboBox()
        Me.lbl_area = New System.Windows.Forms.Label()
        Me.cbx_tipoID = New System.Windows.Forms.ComboBox()
        Me.lbl_tipoCedula = New System.Windows.Forms.Label()
        Me.txt_direccionCliente = New System.Windows.Forms.TextBox()
        Me.lbl_direccion = New System.Windows.Forms.Label()
        Me.txt_ordenCompraCliente = New System.Windows.Forms.TextBox()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.txt_emailCliente = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_telefonoCliente = New System.Windows.Forms.TextBox()
        Me.lbl_apellido2 = New System.Windows.Forms.Label()
        Me.txt_destinatarioCliente = New System.Windows.Forms.TextBox()
        Me.lbl_apellido1 = New System.Windows.Forms.Label()
        Me.txt_nombreCliente = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.lbl_cedula = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_codEliminar = New System.Windows.Forms.TextBox()
        Me.btn_eliminarLinea = New System.Windows.Forms.Button()
        Me.DGV_detalleVenta = New System.Windows.Forms.DataGridView()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btn_agregarLinea = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_descripcionProducto = New System.Windows.Forms.TextBox()
        Me.txt_cantidadProducto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_codProducto = New System.Windows.Forms.TextBox()
        Me.btn_buscarProducto = New System.Windows.Forms.Button()
        Me.btn_limpiarLinea = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_precioUnitario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbx_unidadMedida = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_lineaTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_registrarDocumento = New System.Windows.Forms.Button()
        Me.pnl_Montos = New System.Windows.Forms.Panel()
        Me.txt_montoTotal = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_impuestoMonto = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.pnl_condicionVenta = New System.Windows.Forms.Panel()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbx_medioPago = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.cbx_condicionVenta = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.horafecha = New System.Windows.Forms.Timer(Me.components)
        Me.pnl_barra.SuspendLayout()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Restaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Guardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Actualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DGV_detalleVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.pnl_Montos.SuspendLayout()
        Me.pnl_condicionVenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_barra2
        '
        Me.pnl_barra2.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_barra2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_barra2.Location = New System.Drawing.Point(0, 40)
        Me.pnl_barra2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_barra2.Name = "pnl_barra2"
        Me.pnl_barra2.Size = New System.Drawing.Size(1707, 8)
        Me.pnl_barra2.TabIndex = 10
        '
        'pnl_barra
        '
        Me.pnl_barra.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.pnl_barra.Controls.Add(Me.lbl_tituloBarra)
        Me.pnl_barra.Controls.Add(Me.btn_cerrar)
        Me.pnl_barra.Controls.Add(Me.btn_Restaurar)
        Me.pnl_barra.Controls.Add(Me.btn_Minimizar)
        Me.pnl_barra.Controls.Add(Me.btn_Maximizar)
        Me.pnl_barra.Controls.Add(Me.btn_Guardar)
        Me.pnl_barra.Controls.Add(Me.btn_Actualizar)
        Me.pnl_barra.Controls.Add(Me.btn_Back)
        Me.pnl_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_barra.Location = New System.Drawing.Point(0, 0)
        Me.pnl_barra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_barra.Name = "pnl_barra"
        Me.pnl_barra.Size = New System.Drawing.Size(1707, 40)
        Me.pnl_barra.TabIndex = 9
        '
        'lbl_tituloBarra
        '
        Me.lbl_tituloBarra.AutoSize = True
        Me.lbl_tituloBarra.Font = New System.Drawing.Font("Arial Narrow", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tituloBarra.ForeColor = System.Drawing.Color.White
        Me.lbl_tituloBarra.Location = New System.Drawing.Point(141, 11)
        Me.lbl_tituloBarra.Name = "lbl_tituloBarra"
        Me.lbl_tituloBarra.Size = New System.Drawing.Size(74, 23)
        Me.lbl_tituloBarra.TabIndex = 11
        Me.lbl_tituloBarra.Text = "Facturar"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cerrar.Image = Global.Contador_Final.My.Resources.Resources.exit_delete_17827
        Me.btn_cerrar.Location = New System.Drawing.Point(1644, 2)
        Me.btn_cerrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(40, 34)
        Me.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_cerrar.TabIndex = 7
        Me.btn_cerrar.TabStop = False
        '
        'btn_Restaurar
        '
        Me.btn_Restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restaurar.Image = Global.Contador_Final.My.Resources.Resources.restore_14803
        Me.btn_Restaurar.Location = New System.Drawing.Point(1612, 6)
        Me.btn_Restaurar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Restaurar.Name = "btn_Restaurar"
        Me.btn_Restaurar.Size = New System.Drawing.Size(30, 28)
        Me.btn_Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Restaurar.TabIndex = 7
        Me.btn_Restaurar.TabStop = False
        '
        'btn_Minimizar
        '
        Me.btn_Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Minimizar.Image = Global.Contador_Final.My.Resources.Resources.minimize_14775
        Me.btn_Minimizar.Location = New System.Drawing.Point(1577, 7)
        Me.btn_Minimizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Minimizar.Name = "btn_Minimizar"
        Me.btn_Minimizar.Size = New System.Drawing.Size(30, 28)
        Me.btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Minimizar.TabIndex = 6
        Me.btn_Minimizar.TabStop = False
        '
        'btn_Maximizar
        '
        Me.btn_Maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Maximizar.Image = Global.Contador_Final.My.Resources.Resources.window_maximize_icon_137012
        Me.btn_Maximizar.Location = New System.Drawing.Point(1612, 7)
        Me.btn_Maximizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Maximizar.Name = "btn_Maximizar"
        Me.btn_Maximizar.Size = New System.Drawing.Size(30, 28)
        Me.btn_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Maximizar.TabIndex = 8
        Me.btn_Maximizar.TabStop = False
        Me.btn_Maximizar.Visible = False
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Guardar.Image = Global.Contador_Final.My.Resources.Resources.save_14706
        Me.btn_Guardar.Location = New System.Drawing.Point(98, 5)
        Me.btn_Guardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(32, 33)
        Me.btn_Guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Guardar.TabIndex = 5
        Me.btn_Guardar.TabStop = False
        '
        'btn_Actualizar
        '
        Me.btn_Actualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Actualizar.Image = Global.Contador_Final.My.Resources.Resources.blue_upgrade_recyclearrows_arrow_azul_12426
        Me.btn_Actualizar.Location = New System.Drawing.Point(54, 2)
        Me.btn_Actualizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Actualizar.Name = "btn_Actualizar"
        Me.btn_Actualizar.Size = New System.Drawing.Size(38, 35)
        Me.btn_Actualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Actualizar.TabIndex = 4
        Me.btn_Actualizar.TabStop = False
        '
        'btn_Back
        '
        Me.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Back.Image = Global.Contador_Final.My.Resources.Resources.arrow_left_17809
        Me.btn_Back.Location = New System.Drawing.Point(11, 2)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(38, 35)
        Me.btn_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Back.TabIndex = 3
        Me.btn_Back.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.txt_moneda)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txt_numDocumento)
        Me.GroupBox1.Controls.Add(Me.cbx_tipoDocumento)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.txt_emailEmpresa)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btn_buscaEmpresa)
        Me.GroupBox1.Controls.Add(Me.txt_buscaEmpresa)
        Me.GroupBox1.Controls.Add(Me.txt_hora)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_referencia)
        Me.GroupBox1.Controls.Add(Me.txt_DireccionEmpresa)
        Me.GroupBox1.Controls.Add(Me.txt_TipoIDEmpresa)
        Me.GroupBox1.Controls.Add(Me.txt_IDEmpresa)
        Me.GroupBox1.Controls.Add(Me.txt_nombreEmpresa)
        Me.GroupBox1.Controls.Add(Me.txt_Apellido1Empresa)
        Me.GroupBox1.Controls.Add(Me.txt_Apellido2Empresa)
        Me.GroupBox1.Controls.Add(Me.lbl_telEmpresa)
        Me.GroupBox1.Controls.Add(Me.txt_FaxEmpresa)
        Me.GroupBox1.Controls.Add(Me.lbl_faxDatosEmisor)
        Me.GroupBox1.Controls.Add(Me.txt_Tel2Empresa)
        Me.GroupBox1.Controls.Add(Me.lbl_direccionDatosEmisor)
        Me.GroupBox1.Controls.Add(Me.txt_Tel1Empresa)
        Me.GroupBox1.Controls.Add(Me.txt_DistritoEmpresa)
        Me.GroupBox1.Controls.Add(Me.txt_CantonEmpresa)
        Me.GroupBox1.Controls.Add(Me.txt_ProvinciaEmpresa)
        Me.GroupBox1.Controls.Add(Me.txt_fecha)
        Me.GroupBox1.Controls.Add(Me.lbl_emailDatosEmpresa)
        Me.GroupBox1.Controls.Add(Me.txt_nombreComercial)
        Me.GroupBox1.Location = New System.Drawing.Point(98, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1359, 197)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Empresa"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(500, 158)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(63, 17)
        Me.Label25.TabIndex = 142
        Me.Label25.Text = "Moneda:"
        '
        'txt_moneda
        '
        Me.txt_moneda.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.txt_moneda.Location = New System.Drawing.Point(569, 158)
        Me.txt_moneda.Name = "txt_moneda"
        Me.txt_moneda.Size = New System.Drawing.Size(197, 22)
        Me.txt_moneda.TabIndex = 141
        Me.txt_moneda.TabStop = False
        Me.txt_moneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(277, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 17)
        Me.Label11.TabIndex = 140
        Me.Label11.Text = "N° Documento:"
        '
        'txt_numDocumento
        '
        Me.txt_numDocumento.Location = New System.Drawing.Point(277, 158)
        Me.txt_numDocumento.Name = "txt_numDocumento"
        Me.txt_numDocumento.Size = New System.Drawing.Size(175, 22)
        Me.txt_numDocumento.TabIndex = 139
        '
        'cbx_tipoDocumento
        '
        Me.cbx_tipoDocumento.FormattingEnabled = True
        Me.cbx_tipoDocumento.Location = New System.Drawing.Point(53, 156)
        Me.cbx_tipoDocumento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_tipoDocumento.Name = "cbx_tipoDocumento"
        Me.cbx_tipoDocumento.Size = New System.Drawing.Size(208, 24)
        Me.cbx_tipoDocumento.TabIndex = 137
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(49, 138)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(136, 17)
        Me.Label23.TabIndex = 138
        Me.Label23.Text = "Tipo de Documento:"
        '
        'txt_emailEmpresa
        '
        Me.txt_emailEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.txt_emailEmpresa.Location = New System.Drawing.Point(569, 117)
        Me.txt_emailEmpresa.Name = "txt_emailEmpresa"
        Me.txt_emailEmpresa.Size = New System.Drawing.Size(197, 22)
        Me.txt_emailEmpresa.TabIndex = 69
        Me.txt_emailEmpresa.TabStop = False
        Me.txt_emailEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 15)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Nombre Comercial: "
        '
        'btn_buscaEmpresa
        '
        Me.btn_buscaEmpresa.BackgroundImage = Global.Contador_Final.My.Resources.Resources.magnifier_search_1034
        Me.btn_buscaEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_buscaEmpresa.Location = New System.Drawing.Point(198, 70)
        Me.btn_buscaEmpresa.Name = "btn_buscaEmpresa"
        Me.btn_buscaEmpresa.Size = New System.Drawing.Size(28, 23)
        Me.btn_buscaEmpresa.TabIndex = 3
        Me.btn_buscaEmpresa.UseVisualStyleBackColor = True
        '
        'txt_buscaEmpresa
        '
        Me.txt_buscaEmpresa.Location = New System.Drawing.Point(48, 72)
        Me.txt_buscaEmpresa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_buscaEmpresa.Name = "txt_buscaEmpresa"
        Me.txt_buscaEmpresa.Size = New System.Drawing.Size(144, 22)
        Me.txt_buscaEmpresa.TabIndex = 2
        '
        'txt_hora
        '
        Me.txt_hora.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.txt_hora.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hora.Location = New System.Drawing.Point(44, 29)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(75, 15)
        Me.txt_hora.TabIndex = 67
        Me.txt_hora.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 15)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Fact. Electrónica. Ref: "
        '
        'txt_referencia
        '
        Me.txt_referencia.BackColor = System.Drawing.Color.White
        Me.txt_referencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_referencia.Location = New System.Drawing.Point(196, 103)
        Me.txt_referencia.Name = "txt_referencia"
        Me.txt_referencia.Size = New System.Drawing.Size(132, 22)
        Me.txt_referencia.TabIndex = 4
        '
        'txt_DireccionEmpresa
        '
        Me.txt_DireccionEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.txt_DireccionEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DireccionEmpresa.Location = New System.Drawing.Point(999, 57)
        Me.txt_DireccionEmpresa.Multiline = True
        Me.txt_DireccionEmpresa.Name = "txt_DireccionEmpresa"
        Me.txt_DireccionEmpresa.Size = New System.Drawing.Size(207, 46)
        Me.txt_DireccionEmpresa.TabIndex = 65
        Me.txt_DireccionEmpresa.TabStop = False
        '
        'txt_TipoIDEmpresa
        '
        Me.txt_TipoIDEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.txt_TipoIDEmpresa.Location = New System.Drawing.Point(493, 89)
        Me.txt_TipoIDEmpresa.Name = "txt_TipoIDEmpresa"
        Me.txt_TipoIDEmpresa.Size = New System.Drawing.Size(197, 22)
        Me.txt_TipoIDEmpresa.TabIndex = 64
        Me.txt_TipoIDEmpresa.TabStop = False
        Me.txt_TipoIDEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_IDEmpresa
        '
        Me.txt_IDEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.txt_IDEmpresa.Location = New System.Drawing.Point(696, 89)
        Me.txt_IDEmpresa.Name = "txt_IDEmpresa"
        Me.txt_IDEmpresa.Size = New System.Drawing.Size(197, 22)
        Me.txt_IDEmpresa.TabIndex = 63
        Me.txt_IDEmpresa.TabStop = False
        Me.txt_IDEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_nombreEmpresa
        '
        Me.txt_nombreEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.txt_nombreEmpresa.Location = New System.Drawing.Point(290, 61)
        Me.txt_nombreEmpresa.Name = "txt_nombreEmpresa"
        Me.txt_nombreEmpresa.Size = New System.Drawing.Size(197, 22)
        Me.txt_nombreEmpresa.TabIndex = 62
        Me.txt_nombreEmpresa.TabStop = False
        Me.txt_nombreEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Apellido1Empresa
        '
        Me.txt_Apellido1Empresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.txt_Apellido1Empresa.Location = New System.Drawing.Point(493, 61)
        Me.txt_Apellido1Empresa.Name = "txt_Apellido1Empresa"
        Me.txt_Apellido1Empresa.Size = New System.Drawing.Size(197, 22)
        Me.txt_Apellido1Empresa.TabIndex = 61
        Me.txt_Apellido1Empresa.TabStop = False
        Me.txt_Apellido1Empresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Apellido2Empresa
        '
        Me.txt_Apellido2Empresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.txt_Apellido2Empresa.Location = New System.Drawing.Point(696, 61)
        Me.txt_Apellido2Empresa.Name = "txt_Apellido2Empresa"
        Me.txt_Apellido2Empresa.Size = New System.Drawing.Size(197, 22)
        Me.txt_Apellido2Empresa.TabIndex = 60
        Me.txt_Apellido2Empresa.TabStop = False
        Me.txt_Apellido2Empresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_telEmpresa
        '
        Me.lbl_telEmpresa.AutoSize = True
        Me.lbl_telEmpresa.Location = New System.Drawing.Point(911, 114)
        Me.lbl_telEmpresa.Name = "lbl_telEmpresa"
        Me.lbl_telEmpresa.Size = New System.Drawing.Size(79, 17)
        Me.lbl_telEmpresa.TabIndex = 59
        Me.lbl_telEmpresa.Text = "Teléfonos: "
        '
        'txt_FaxEmpresa
        '
        Me.txt_FaxEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.txt_FaxEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FaxEmpresa.Location = New System.Drawing.Point(1214, 108)
        Me.txt_FaxEmpresa.Name = "txt_FaxEmpresa"
        Me.txt_FaxEmpresa.Size = New System.Drawing.Size(100, 21)
        Me.txt_FaxEmpresa.TabIndex = 58
        Me.txt_FaxEmpresa.TabStop = False
        Me.txt_FaxEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_faxDatosEmisor
        '
        Me.lbl_faxDatosEmisor.AutoSize = True
        Me.lbl_faxDatosEmisor.Location = New System.Drawing.Point(1211, 85)
        Me.lbl_faxDatosEmisor.Name = "lbl_faxDatosEmisor"
        Me.lbl_faxDatosEmisor.Size = New System.Drawing.Size(38, 17)
        Me.lbl_faxDatosEmisor.TabIndex = 57
        Me.lbl_faxDatosEmisor.Text = "Fax: "
        '
        'txt_Tel2Empresa
        '
        Me.txt_Tel2Empresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.txt_Tel2Empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tel2Empresa.Location = New System.Drawing.Point(1105, 109)
        Me.txt_Tel2Empresa.Name = "txt_Tel2Empresa"
        Me.txt_Tel2Empresa.Size = New System.Drawing.Size(100, 21)
        Me.txt_Tel2Empresa.TabIndex = 56
        Me.txt_Tel2Empresa.TabStop = False
        Me.txt_Tel2Empresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_direccionDatosEmisor
        '
        Me.lbl_direccionDatosEmisor.AutoSize = True
        Me.lbl_direccionDatosEmisor.Location = New System.Drawing.Point(911, 32)
        Me.lbl_direccionDatosEmisor.Name = "lbl_direccionDatosEmisor"
        Me.lbl_direccionDatosEmisor.Size = New System.Drawing.Size(71, 17)
        Me.lbl_direccionDatosEmisor.TabIndex = 55
        Me.lbl_direccionDatosEmisor.Text = "Dirección:"
        '
        'txt_Tel1Empresa
        '
        Me.txt_Tel1Empresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.txt_Tel1Empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tel1Empresa.Location = New System.Drawing.Point(999, 109)
        Me.txt_Tel1Empresa.Name = "txt_Tel1Empresa"
        Me.txt_Tel1Empresa.Size = New System.Drawing.Size(100, 21)
        Me.txt_Tel1Empresa.TabIndex = 54
        Me.txt_Tel1Empresa.TabStop = False
        Me.txt_Tel1Empresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_DistritoEmpresa
        '
        Me.txt_DistritoEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.txt_DistritoEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DistritoEmpresa.Location = New System.Drawing.Point(1214, 32)
        Me.txt_DistritoEmpresa.Name = "txt_DistritoEmpresa"
        Me.txt_DistritoEmpresa.Size = New System.Drawing.Size(100, 21)
        Me.txt_DistritoEmpresa.TabIndex = 53
        Me.txt_DistritoEmpresa.TabStop = False
        Me.txt_DistritoEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_CantonEmpresa
        '
        Me.txt_CantonEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.txt_CantonEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CantonEmpresa.Location = New System.Drawing.Point(1105, 32)
        Me.txt_CantonEmpresa.Name = "txt_CantonEmpresa"
        Me.txt_CantonEmpresa.Size = New System.Drawing.Size(100, 21)
        Me.txt_CantonEmpresa.TabIndex = 52
        Me.txt_CantonEmpresa.TabStop = False
        Me.txt_CantonEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_ProvinciaEmpresa
        '
        Me.txt_ProvinciaEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.txt_ProvinciaEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ProvinciaEmpresa.Location = New System.Drawing.Point(999, 32)
        Me.txt_ProvinciaEmpresa.Name = "txt_ProvinciaEmpresa"
        Me.txt_ProvinciaEmpresa.Size = New System.Drawing.Size(100, 21)
        Me.txt_ProvinciaEmpresa.TabIndex = 51
        Me.txt_ProvinciaEmpresa.TabStop = False
        Me.txt_ProvinciaEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_fecha
        '
        Me.txt_fecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.txt_fecha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fecha.Location = New System.Drawing.Point(125, 30)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(214, 15)
        Me.txt_fecha.TabIndex = 50
        Me.txt_fecha.TabStop = False
        '
        'lbl_emailDatosEmpresa
        '
        Me.lbl_emailDatosEmpresa.AutoSize = True
        Me.lbl_emailDatosEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_emailDatosEmpresa.Location = New System.Drawing.Point(502, 120)
        Me.lbl_emailDatosEmpresa.Name = "lbl_emailDatosEmpresa"
        Me.lbl_emailDatosEmpresa.Size = New System.Drawing.Size(46, 17)
        Me.lbl_emailDatosEmpresa.TabIndex = 1
        Me.lbl_emailDatosEmpresa.Text = "Email:"
        '
        'txt_nombreComercial
        '
        Me.txt_nombreComercial.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.txt_nombreComercial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombreComercial.Location = New System.Drawing.Point(466, 30)
        Me.txt_nombreComercial.Name = "txt_nombreComercial"
        Me.txt_nombreComercial.Size = New System.Drawing.Size(329, 27)
        Me.txt_nombreComercial.TabIndex = 45
        Me.txt_nombreComercial.TabStop = False
        Me.txt_nombreComercial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_apellido2)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txt_apellido1)
        Me.GroupBox2.Controls.Add(Me.lbl_apellido1Cliente)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.btn_buscarCliente)
        Me.GroupBox2.Controls.Add(Me.txt_idInternoCliente)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_cambioMonedaCliente)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cbx_Distrito)
        Me.GroupBox2.Controls.Add(Me.cbx_Canton)
        Me.GroupBox2.Controls.Add(Me.cbx_Provincia)
        Me.GroupBox2.Controls.Add(Me.lbl_distrito)
        Me.GroupBox2.Controls.Add(Me.lbl_canton)
        Me.GroupBox2.Controls.Add(Me.lbl_provincia)
        Me.GroupBox2.Controls.Add(Me.cbx_pais)
        Me.GroupBox2.Controls.Add(Me.lbl_area)
        Me.GroupBox2.Controls.Add(Me.cbx_tipoID)
        Me.GroupBox2.Controls.Add(Me.lbl_tipoCedula)
        Me.GroupBox2.Controls.Add(Me.txt_direccionCliente)
        Me.GroupBox2.Controls.Add(Me.lbl_direccion)
        Me.GroupBox2.Controls.Add(Me.txt_ordenCompraCliente)
        Me.GroupBox2.Controls.Add(Me.lbl_telefono)
        Me.GroupBox2.Controls.Add(Me.txt_emailCliente)
        Me.GroupBox2.Controls.Add(Me.lbl_email)
        Me.GroupBox2.Controls.Add(Me.txt_telefonoCliente)
        Me.GroupBox2.Controls.Add(Me.lbl_apellido2)
        Me.GroupBox2.Controls.Add(Me.txt_destinatarioCliente)
        Me.GroupBox2.Controls.Add(Me.lbl_apellido1)
        Me.GroupBox2.Controls.Add(Me.txt_nombreCliente)
        Me.GroupBox2.Controls.Add(Me.lbl_nombre)
        Me.GroupBox2.Controls.Add(Me.txt_cedula)
        Me.GroupBox2.Controls.Add(Me.lbl_cedula)
        Me.GroupBox2.Location = New System.Drawing.Point(98, 256)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1365, 227)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Cliente"
        '
        'txt_apellido2
        '
        Me.txt_apellido2.Location = New System.Drawing.Point(275, 123)
        Me.txt_apellido2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_apellido2.Name = "txt_apellido2"
        Me.txt_apellido2.Size = New System.Drawing.Size(144, 22)
        Me.txt_apellido2.TabIndex = 12
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(273, 105)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(74, 17)
        Me.Label20.TabIndex = 146
        Me.Label20.Text = "Apellido 2:"
        '
        'txt_apellido1
        '
        Me.txt_apellido1.Location = New System.Drawing.Point(76, 123)
        Me.txt_apellido1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_apellido1.Name = "txt_apellido1"
        Me.txt_apellido1.Size = New System.Drawing.Size(144, 22)
        Me.txt_apellido1.TabIndex = 11
        '
        'lbl_apellido1Cliente
        '
        Me.lbl_apellido1Cliente.AutoSize = True
        Me.lbl_apellido1Cliente.Location = New System.Drawing.Point(74, 105)
        Me.lbl_apellido1Cliente.Name = "lbl_apellido1Cliente"
        Me.lbl_apellido1Cliente.Size = New System.Drawing.Size(74, 17)
        Me.lbl_apellido1Cliente.TabIndex = 145
        Me.lbl_apellido1Cliente.Text = "Apellido 1:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(199, 33)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(18, 20)
        Me.Label18.TabIndex = 144
        Me.Label18.Text = "¢"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Contador_Final.My.Resources.Resources.dollars_96693
        Me.PictureBox1.Location = New System.Drawing.Point(166, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 143
        Me.PictureBox1.TabStop = False
        '
        'btn_buscarCliente
        '
        Me.btn_buscarCliente.BackgroundImage = Global.Contador_Final.My.Resources.Resources.magnifier_search_1034
        Me.btn_buscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_buscarCliente.Location = New System.Drawing.Point(424, 78)
        Me.btn_buscarCliente.Name = "btn_buscarCliente"
        Me.btn_buscarCliente.Size = New System.Drawing.Size(28, 23)
        Me.btn_buscarCliente.TabIndex = 9
        Me.btn_buscarCliente.UseVisualStyleBackColor = True
        '
        'txt_idInternoCliente
        '
        Me.txt_idInternoCliente.Location = New System.Drawing.Point(1128, 174)
        Me.txt_idInternoCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_idInternoCliente.Name = "txt_idInternoCliente"
        Me.txt_idInternoCliente.Size = New System.Drawing.Size(185, 22)
        Me.txt_idInternoCliente.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1124, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 142
        Me.Label4.Text = "ID Interno:"
        '
        'txt_cambioMonedaCliente
        '
        Me.txt_cambioMonedaCliente.Location = New System.Drawing.Point(220, 30)
        Me.txt_cambioMonedaCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_cambioMonedaCliente.Name = "txt_cambioMonedaCliente"
        Me.txt_cambioMonedaCliente.Size = New System.Drawing.Size(94, 22)
        Me.txt_cambioMonedaCliente.TabIndex = 6
        Me.txt_cambioMonedaCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "Tipo Cambio:"
        '
        'cbx_Distrito
        '
        Me.cbx_Distrito.FormattingEnabled = True
        Me.cbx_Distrito.Location = New System.Drawing.Point(677, 173)
        Me.cbx_Distrito.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_Distrito.Name = "cbx_Distrito"
        Me.cbx_Distrito.Size = New System.Drawing.Size(186, 24)
        Me.cbx_Distrito.TabIndex = 16
        '
        'cbx_Canton
        '
        Me.cbx_Canton.FormattingEnabled = True
        Me.cbx_Canton.Location = New System.Drawing.Point(676, 125)
        Me.cbx_Canton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_Canton.Name = "cbx_Canton"
        Me.cbx_Canton.Size = New System.Drawing.Size(186, 24)
        Me.cbx_Canton.TabIndex = 15
        '
        'cbx_Provincia
        '
        Me.cbx_Provincia.FormattingEnabled = True
        Me.cbx_Provincia.Location = New System.Drawing.Point(676, 78)
        Me.cbx_Provincia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_Provincia.Name = "cbx_Provincia"
        Me.cbx_Provincia.Size = New System.Drawing.Size(186, 24)
        Me.cbx_Provincia.TabIndex = 14
        '
        'lbl_distrito
        '
        Me.lbl_distrito.AutoSize = True
        Me.lbl_distrito.Location = New System.Drawing.Point(674, 155)
        Me.lbl_distrito.Name = "lbl_distrito"
        Me.lbl_distrito.Size = New System.Drawing.Size(56, 17)
        Me.lbl_distrito.TabIndex = 140
        Me.lbl_distrito.Text = "Distrito:"
        '
        'lbl_canton
        '
        Me.lbl_canton.AutoSize = True
        Me.lbl_canton.Location = New System.Drawing.Point(673, 104)
        Me.lbl_canton.Name = "lbl_canton"
        Me.lbl_canton.Size = New System.Drawing.Size(57, 17)
        Me.lbl_canton.TabIndex = 139
        Me.lbl_canton.Text = "Canton:"
        '
        'lbl_provincia
        '
        Me.lbl_provincia.AutoSize = True
        Me.lbl_provincia.Location = New System.Drawing.Point(690, 57)
        Me.lbl_provincia.Name = "lbl_provincia"
        Me.lbl_provincia.Size = New System.Drawing.Size(70, 17)
        Me.lbl_provincia.TabIndex = 138
        Me.lbl_provincia.Text = "Provincia:"
        '
        'cbx_pais
        '
        Me.cbx_pais.FormattingEnabled = True
        Me.cbx_pais.Location = New System.Drawing.Point(487, 122)
        Me.cbx_pais.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_pais.Name = "cbx_pais"
        Me.cbx_pais.Size = New System.Drawing.Size(144, 24)
        Me.cbx_pais.TabIndex = 13
        '
        'lbl_area
        '
        Me.lbl_area.AutoSize = True
        Me.lbl_area.Location = New System.Drawing.Point(480, 155)
        Me.lbl_area.Name = "lbl_area"
        Me.lbl_area.Size = New System.Drawing.Size(135, 17)
        Me.lbl_area.TabIndex = 137
        Me.lbl_area.Text = "# Orden de compra:"
        '
        'cbx_tipoID
        '
        Me.cbx_tipoID.FormattingEnabled = True
        Me.cbx_tipoID.Location = New System.Drawing.Point(75, 75)
        Me.cbx_tipoID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_tipoID.Name = "cbx_tipoID"
        Me.cbx_tipoID.Size = New System.Drawing.Size(144, 24)
        Me.cbx_tipoID.TabIndex = 7
        '
        'lbl_tipoCedula
        '
        Me.lbl_tipoCedula.AutoSize = True
        Me.lbl_tipoCedula.Location = New System.Drawing.Point(71, 57)
        Me.lbl_tipoCedula.Name = "lbl_tipoCedula"
        Me.lbl_tipoCedula.Size = New System.Drawing.Size(77, 17)
        Me.lbl_tipoCedula.TabIndex = 136
        Me.lbl_tipoCedula.Text = "Tipo de ID:"
        '
        'txt_direccionCliente
        '
        Me.txt_direccionCliente.Location = New System.Drawing.Point(942, 75)
        Me.txt_direccionCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_direccionCliente.Multiline = True
        Me.txt_direccionCliente.Name = "txt_direccionCliente"
        Me.txt_direccionCliente.Size = New System.Drawing.Size(371, 72)
        Me.txt_direccionCliente.TabIndex = 17
        '
        'lbl_direccion
        '
        Me.lbl_direccion.AutoSize = True
        Me.lbl_direccion.Location = New System.Drawing.Point(939, 57)
        Me.lbl_direccion.Name = "lbl_direccion"
        Me.lbl_direccion.Size = New System.Drawing.Size(71, 17)
        Me.lbl_direccion.TabIndex = 135
        Me.lbl_direccion.Text = "Dirección:"
        '
        'txt_ordenCompraCliente
        '
        Me.txt_ordenCompraCliente.Location = New System.Drawing.Point(483, 174)
        Me.txt_ordenCompraCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_ordenCompraCliente.Name = "txt_ordenCompraCliente"
        Me.txt_ordenCompraCliente.Size = New System.Drawing.Size(144, 22)
        Me.txt_ordenCompraCliente.TabIndex = 22
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(283, 153)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(68, 17)
        Me.lbl_telefono.TabIndex = 134
        Me.lbl_telefono.Text = "Teléfono:"
        '
        'txt_emailCliente
        '
        Me.txt_emailCliente.Location = New System.Drawing.Point(908, 174)
        Me.txt_emailCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_emailCliente.Name = "txt_emailCliente"
        Me.txt_emailCliente.Size = New System.Drawing.Size(185, 22)
        Me.txt_emailCliente.TabIndex = 18
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(905, 155)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(128, 17)
        Me.lbl_email.TabIndex = 133
        Me.lbl_email.Text = "Correo electrónico:"
        '
        'txt_telefonoCliente
        '
        Me.txt_telefonoCliente.Location = New System.Drawing.Point(289, 174)
        Me.txt_telefonoCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_telefonoCliente.Name = "txt_telefonoCliente"
        Me.txt_telefonoCliente.Size = New System.Drawing.Size(144, 22)
        Me.txt_telefonoCliente.TabIndex = 21
        '
        'lbl_apellido2
        '
        Me.lbl_apellido2.AutoSize = True
        Me.lbl_apellido2.Location = New System.Drawing.Point(73, 155)
        Me.lbl_apellido2.Name = "lbl_apellido2"
        Me.lbl_apellido2.Size = New System.Drawing.Size(88, 17)
        Me.lbl_apellido2.TabIndex = 132
        Me.lbl_apellido2.Text = "Destinatario:"
        '
        'txt_destinatarioCliente
        '
        Me.txt_destinatarioCliente.Location = New System.Drawing.Point(75, 174)
        Me.txt_destinatarioCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_destinatarioCliente.Name = "txt_destinatarioCliente"
        Me.txt_destinatarioCliente.Size = New System.Drawing.Size(198, 22)
        Me.txt_destinatarioCliente.TabIndex = 20
        '
        'lbl_apellido1
        '
        Me.lbl_apellido1.AutoSize = True
        Me.lbl_apellido1.Location = New System.Drawing.Point(485, 104)
        Me.lbl_apellido1.Name = "lbl_apellido1"
        Me.lbl_apellido1.Size = New System.Drawing.Size(42, 17)
        Me.lbl_apellido1.TabIndex = 131
        Me.lbl_apellido1.Text = "Área:"
        '
        'txt_nombreCliente
        '
        Me.txt_nombreCliente.Location = New System.Drawing.Point(488, 76)
        Me.txt_nombreCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nombreCliente.Name = "txt_nombreCliente"
        Me.txt_nombreCliente.Size = New System.Drawing.Size(144, 22)
        Me.txt_nombreCliente.TabIndex = 10
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(486, 58)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(62, 17)
        Me.lbl_nombre.TabIndex = 130
        Me.lbl_nombre.Text = "Nombre:"
        '
        'txt_cedula
        '
        Me.txt_cedula.Location = New System.Drawing.Point(274, 78)
        Me.txt_cedula.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(144, 22)
        Me.txt_cedula.TabIndex = 8
        '
        'lbl_cedula
        '
        Me.lbl_cedula.AutoSize = True
        Me.lbl_cedula.Location = New System.Drawing.Point(272, 57)
        Me.lbl_cedula.Name = "lbl_cedula"
        Me.lbl_cedula.Size = New System.Drawing.Size(56, 17)
        Me.lbl_cedula.TabIndex = 129
        Me.lbl_cedula.Text = "Cédula:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.DGV_detalleVenta)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.btn_agregarLinea)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.txt_descripcionProducto)
        Me.GroupBox3.Controls.Add(Me.txt_cantidadProducto)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txt_codProducto)
        Me.GroupBox3.Controls.Add(Me.btn_buscarProducto)
        Me.GroupBox3.Controls.Add(Me.btn_limpiarLinea)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txt_precioUnitario)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.cbx_unidadMedida)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txt_lineaTotal)
        Me.GroupBox3.Location = New System.Drawing.Point(98, 490)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1365, 242)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Líneas de Detalle"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.txt_codEliminar)
        Me.GroupBox5.Controls.Add(Me.btn_eliminarLinea)
        Me.GroupBox5.Location = New System.Drawing.Point(546, 94)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(137, 121)
        Me.GroupBox5.TabIndex = 119
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Eliminar Línea"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(16, 24)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(102, 17)
        Me.Label24.TabIndex = 116
        Me.Label24.Text = "Cód. Producto:"
        '
        'txt_codEliminar
        '
        Me.txt_codEliminar.Location = New System.Drawing.Point(11, 46)
        Me.txt_codEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_codEliminar.Name = "txt_codEliminar"
        Me.txt_codEliminar.Size = New System.Drawing.Size(116, 22)
        Me.txt_codEliminar.TabIndex = 115
        Me.txt_codEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_eliminarLinea
        '
        Me.btn_eliminarLinea.Location = New System.Drawing.Point(8, 73)
        Me.btn_eliminarLinea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_eliminarLinea.Name = "btn_eliminarLinea"
        Me.btn_eliminarLinea.Size = New System.Drawing.Size(119, 38)
        Me.btn_eliminarLinea.TabIndex = 114
        Me.btn_eliminarLinea.Text = "ELIMINAR"
        Me.btn_eliminarLinea.UseVisualStyleBackColor = True
        '
        'DGV_detalleVenta
        '
        Me.DGV_detalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_detalleVenta.BackgroundColor = System.Drawing.Color.White
        Me.DGV_detalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_detalleVenta.Location = New System.Drawing.Point(698, 38)
        Me.DGV_detalleVenta.Name = "DGV_detalleVenta"
        Me.DGV_detalleVenta.RowHeadersWidth = 51
        Me.DGV_detalleVenta.RowTemplate.Height = 24
        Me.DGV_detalleVenta.Size = New System.Drawing.Size(649, 177)
        Me.DGV_detalleVenta.TabIndex = 36
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(266, 194)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(18, 20)
        Me.Label22.TabIndex = 113
        Me.Label22.Text = "¢"
        '
        'btn_agregarLinea
        '
        Me.btn_agregarLinea.Location = New System.Drawing.Point(546, 45)
        Me.btn_agregarLinea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_agregarLinea.Name = "btn_agregarLinea"
        Me.btn_agregarLinea.Size = New System.Drawing.Size(137, 31)
        Me.btn_agregarLinea.TabIndex = 34
        Me.btn_agregarLinea.Text = "AGREGAR LINEA"
        Me.btn_agregarLinea.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(217, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(215, 17)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Descripción Mercadería/Servicio:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(265, 142)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(18, 20)
        Me.Label21.TabIndex = 112
        Me.Label21.Text = "¢"
        '
        'txt_descripcionProducto
        '
        Me.txt_descripcionProducto.Location = New System.Drawing.Point(221, 38)
        Me.txt_descripcionProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_descripcionProducto.Multiline = True
        Me.txt_descripcionProducto.Name = "txt_descripcionProducto"
        Me.txt_descripcionProducto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_descripcionProducto.Size = New System.Drawing.Size(306, 72)
        Me.txt_descripcionProducto.TabIndex = 26
        '
        'txt_cantidadProducto
        '
        Me.txt_cantidadProducto.Location = New System.Drawing.Point(180, 143)
        Me.txt_cantidadProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_cantidadProducto.Name = "txt_cantidadProducto"
        Me.txt_cantidadProducto.Size = New System.Drawing.Size(78, 22)
        Me.txt_cantidadProducto.TabIndex = 29
        Me.txt_cantidadProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 17)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Cód. Producto:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(177, 124)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 17)
        Me.Label19.TabIndex = 110
        Me.Label19.Text = "Cantidad:"
        '
        'txt_codProducto
        '
        Me.txt_codProducto.Location = New System.Drawing.Point(21, 48)
        Me.txt_codProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_codProducto.Name = "txt_codProducto"
        Me.txt_codProducto.Size = New System.Drawing.Size(151, 22)
        Me.txt_codProducto.TabIndex = 24
        Me.txt_codProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_buscarProducto
        '
        Me.btn_buscarProducto.BackgroundImage = Global.Contador_Final.My.Resources.Resources.magnifier_search_1034
        Me.btn_buscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_buscarProducto.Location = New System.Drawing.Point(178, 48)
        Me.btn_buscarProducto.Name = "btn_buscarProducto"
        Me.btn_buscarProducto.Size = New System.Drawing.Size(28, 23)
        Me.btn_buscarProducto.TabIndex = 25
        Me.btn_buscarProducto.UseVisualStyleBackColor = True
        '
        'btn_limpiarLinea
        '
        Me.btn_limpiarLinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiarLinea.Location = New System.Drawing.Point(443, 157)
        Me.btn_limpiarLinea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_limpiarLinea.Name = "btn_limpiarLinea"
        Me.btn_limpiarLinea.Size = New System.Drawing.Size(84, 38)
        Me.btn_limpiarLinea.TabIndex = 35
        Me.btn_limpiarLinea.Text = "LIMPIAR"
        Me.btn_limpiarLinea.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(286, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 17)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = "Precio Unitario:"
        '
        'txt_precioUnitario
        '
        Me.txt_precioUnitario.Location = New System.Drawing.Point(289, 142)
        Me.txt_precioUnitario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_precioUnitario.Name = "txt_precioUnitario"
        Me.txt_precioUnitario.Size = New System.Drawing.Size(144, 22)
        Me.txt_precioUnitario.TabIndex = 30
        Me.txt_precioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 17)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Unidad de Medida:"
        '
        'cbx_unidadMedida
        '
        Me.cbx_unidadMedida.FormattingEnabled = True
        Me.cbx_unidadMedida.Location = New System.Drawing.Point(21, 143)
        Me.cbx_unidadMedida.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_unidadMedida.Name = "cbx_unidadMedida"
        Me.cbx_unidadMedida.Size = New System.Drawing.Size(144, 24)
        Me.cbx_unidadMedida.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(287, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 17)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Total Línea:"
        '
        'txt_lineaTotal
        '
        Me.txt_lineaTotal.Location = New System.Drawing.Point(290, 192)
        Me.txt_lineaTotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_lineaTotal.Name = "txt_lineaTotal"
        Me.txt_lineaTotal.Size = New System.Drawing.Size(143, 22)
        Me.txt_lineaTotal.TabIndex = 33
        Me.txt_lineaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_registrarDocumento)
        Me.GroupBox4.Controls.Add(Me.pnl_Montos)
        Me.GroupBox4.Controls.Add(Me.pnl_condicionVenta)
        Me.GroupBox4.Location = New System.Drawing.Point(98, 745)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1365, 279)
        Me.GroupBox4.TabIndex = 37
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Totales"
        '
        'btn_registrarDocumento
        '
        Me.btn_registrarDocumento.Location = New System.Drawing.Point(988, 193)
        Me.btn_registrarDocumento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_registrarDocumento.Name = "btn_registrarDocumento"
        Me.btn_registrarDocumento.Size = New System.Drawing.Size(207, 38)
        Me.btn_registrarDocumento.TabIndex = 35
        Me.btn_registrarDocumento.Text = "REGISTRAR DOCUMENTO"
        Me.btn_registrarDocumento.UseVisualStyleBackColor = True
        '
        'pnl_Montos
        '
        Me.pnl_Montos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_Montos.Controls.Add(Me.txt_montoTotal)
        Me.pnl_Montos.Controls.Add(Me.Label17)
        Me.pnl_Montos.Controls.Add(Me.txt_impuestoMonto)
        Me.pnl_Montos.Controls.Add(Me.Label15)
        Me.pnl_Montos.Controls.Add(Me.txt_subtotal)
        Me.pnl_Montos.Controls.Add(Me.Label14)
        Me.pnl_Montos.Location = New System.Drawing.Point(908, 57)
        Me.pnl_Montos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_Montos.Name = "pnl_Montos"
        Me.pnl_Montos.Size = New System.Drawing.Size(336, 115)
        Me.pnl_Montos.TabIndex = 3
        '
        'txt_montoTotal
        '
        Me.txt_montoTotal.Location = New System.Drawing.Point(171, 74)
        Me.txt_montoTotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_montoTotal.Name = "txt_montoTotal"
        Me.txt_montoTotal.Size = New System.Drawing.Size(150, 22)
        Me.txt_montoTotal.TabIndex = 44
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(18, 77)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 17)
        Me.Label17.TabIndex = 90
        Me.Label17.Text = "Monto Total:"
        '
        'txt_impuestoMonto
        '
        Me.txt_impuestoMonto.Location = New System.Drawing.Point(171, 40)
        Me.txt_impuestoMonto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_impuestoMonto.Name = "txt_impuestoMonto"
        Me.txt_impuestoMonto.Size = New System.Drawing.Size(150, 22)
        Me.txt_impuestoMonto.TabIndex = 43
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 17)
        Me.Label15.TabIndex = 88
        Me.Label15.Text = "Impuestos:"
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Location = New System.Drawing.Point(171, 8)
        Me.txt_subtotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(150, 22)
        Me.txt_subtotal.TabIndex = 42
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 17)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "SubTotal Neto:"
        '
        'pnl_condicionVenta
        '
        Me.pnl_condicionVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_condicionVenta.Controls.Add(Me.TextBox12)
        Me.pnl_condicionVenta.Controls.Add(Me.Label16)
        Me.pnl_condicionVenta.Controls.Add(Me.cbx_medioPago)
        Me.pnl_condicionVenta.Controls.Add(Me.Label13)
        Me.pnl_condicionVenta.Controls.Add(Me.TextBox6)
        Me.pnl_condicionVenta.Controls.Add(Me.cbx_condicionVenta)
        Me.pnl_condicionVenta.Controls.Add(Me.Label8)
        Me.pnl_condicionVenta.Controls.Add(Me.Label12)
        Me.pnl_condicionVenta.Location = New System.Drawing.Point(219, 34)
        Me.pnl_condicionVenta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_condicionVenta.Name = "pnl_condicionVenta"
        Me.pnl_condicionVenta.Size = New System.Drawing.Size(576, 219)
        Me.pnl_condicionVenta.TabIndex = 2
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(15, 85)
        Me.TextBox12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox12.Multiline = True
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(540, 86)
        Me.TextBox12.TabIndex = 40
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 67)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 17)
        Me.Label16.TabIndex = 96
        Me.Label16.Text = "Notas:"
        '
        'cbx_medioPago
        '
        Me.cbx_medioPago.FormattingEnabled = True
        Me.cbx_medioPago.Location = New System.Drawing.Point(303, 31)
        Me.cbx_medioPago.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_medioPago.Name = "cbx_medioPago"
        Me.cbx_medioPago.Size = New System.Drawing.Size(183, 24)
        Me.cbx_medioPago.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(302, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 17)
        Me.Label13.TabIndex = 90
        Me.Label13.Text = "Medio de Pago:"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(174, 181)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(150, 22)
        Me.TextBox6.TabIndex = 41
        '
        'cbx_condicionVenta
        '
        Me.cbx_condicionVenta.FormattingEnabled = True
        Me.cbx_condicionVenta.Location = New System.Drawing.Point(73, 31)
        Me.cbx_condicionVenta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_condicionVenta.Name = "cbx_condicionVenta"
        Me.cbx_condicionVenta.Size = New System.Drawing.Size(172, 24)
        Me.cbx_condicionVenta.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 17)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "Fecha de vencimiento:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(68, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(135, 17)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "Condicion de Venta:"
        '
        'horafecha
        '
        Me.horafecha.Enabled = True
        '
        'Form6_Facturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1707, 1036)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pnl_barra2)
        Me.Controls.Add(Me.pnl_barra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form6_Facturar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_barra.ResumeLayout(False)
        Me.pnl_barra.PerformLayout()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Restaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Guardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Actualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DGV_detalleVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.pnl_Montos.ResumeLayout(False)
        Me.pnl_Montos.PerformLayout()
        Me.pnl_condicionVenta.ResumeLayout(False)
        Me.pnl_condicionVenta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_barra2 As Panel
    Friend WithEvents pnl_barra As Panel
    Friend WithEvents lbl_tituloBarra As Label
    Friend WithEvents btn_cerrar As PictureBox
    Friend WithEvents btn_Restaurar As PictureBox
    Friend WithEvents btn_Minimizar As PictureBox
    Friend WithEvents btn_Maximizar As PictureBox
    Friend WithEvents btn_Guardar As PictureBox
    Friend WithEvents btn_Actualizar As PictureBox
    Friend WithEvents btn_Back As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_emailEmpresa As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_buscaEmpresa As Button
    Friend WithEvents txt_buscaEmpresa As TextBox
    Friend WithEvents txt_hora As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_referencia As TextBox
    Friend WithEvents txt_DireccionEmpresa As TextBox
    Friend WithEvents txt_TipoIDEmpresa As TextBox
    Friend WithEvents txt_IDEmpresa As TextBox
    Friend WithEvents txt_nombreEmpresa As TextBox
    Friend WithEvents txt_Apellido1Empresa As TextBox
    Friend WithEvents txt_Apellido2Empresa As TextBox
    Friend WithEvents lbl_telEmpresa As Label
    Friend WithEvents txt_FaxEmpresa As TextBox
    Friend WithEvents lbl_faxDatosEmisor As Label
    Friend WithEvents txt_Tel2Empresa As TextBox
    Friend WithEvents lbl_direccionDatosEmisor As Label
    Friend WithEvents txt_Tel1Empresa As TextBox
    Friend WithEvents txt_DistritoEmpresa As TextBox
    Friend WithEvents txt_CantonEmpresa As TextBox
    Friend WithEvents txt_ProvinciaEmpresa As TextBox
    Friend WithEvents txt_fecha As TextBox
    Friend WithEvents lbl_emailDatosEmpresa As Label
    Friend WithEvents txt_nombreComercial As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_apellido2 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_apellido1 As TextBox
    Friend WithEvents lbl_apellido1Cliente As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_buscarCliente As Button
    Friend WithEvents txt_idInternoCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cambioMonedaCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbx_Distrito As ComboBox
    Friend WithEvents cbx_Canton As ComboBox
    Friend WithEvents cbx_Provincia As ComboBox
    Friend WithEvents lbl_distrito As Label
    Friend WithEvents lbl_canton As Label
    Friend WithEvents lbl_provincia As Label
    Friend WithEvents cbx_pais As ComboBox
    Friend WithEvents lbl_area As Label
    Friend WithEvents cbx_tipoID As ComboBox
    Friend WithEvents lbl_tipoCedula As Label
    Friend WithEvents txt_direccionCliente As TextBox
    Friend WithEvents lbl_direccion As Label
    Friend WithEvents txt_ordenCompraCliente As TextBox
    Friend WithEvents lbl_telefono As Label
    Friend WithEvents txt_emailCliente As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents txt_telefonoCliente As TextBox
    Friend WithEvents lbl_apellido2 As Label
    Friend WithEvents txt_destinatarioCliente As TextBox
    Friend WithEvents lbl_apellido1 As Label
    Friend WithEvents txt_nombreCliente As TextBox
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents lbl_cedula As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DGV_detalleVenta As DataGridView
    Friend WithEvents Label22 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txt_descripcionProducto As TextBox
    Friend WithEvents txt_cantidadProducto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_codProducto As TextBox
    Friend WithEvents btn_buscarProducto As Button
    Friend WithEvents btn_limpiarLinea As Button
    Friend WithEvents btn_agregarLinea As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_precioUnitario As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbx_unidadMedida As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_lineaTotal As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents pnl_Montos As Panel
    Friend WithEvents txt_montoTotal As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_impuestoMonto As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents pnl_condicionVenta As Panel
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cbx_medioPago As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents cbx_condicionVenta As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents horafecha As Timer
    Friend WithEvents cbx_tipoDocumento As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btn_eliminarLinea As Button
    Friend WithEvents btn_registrarDocumento As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents txt_codEliminar As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_numDocumento As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txt_moneda As TextBox
End Class
