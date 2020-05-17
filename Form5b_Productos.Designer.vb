<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5b_Productos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5b_Productos))
        Me.pnl_barra2 = New System.Windows.Forms.Panel()
        Me.pnl_barra = New System.Windows.Forms.Panel()
        Me.lbl_tituloBarra = New System.Windows.Forms.Label()
        Me.btn_cerrar = New System.Windows.Forms.PictureBox()
        Me.btn_Restaurar = New System.Windows.Forms.PictureBox()
        Me.btn_Minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_Maximizar = New System.Windows.Forms.PictureBox()
        Me.btn_Guardar = New System.Windows.Forms.PictureBox()
        Me.btn_actualizarBarra = New System.Windows.Forms.PictureBox()
        Me.btn_Back = New System.Windows.Forms.PictureBox()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.btn_mostrar = New System.Windows.Forms.Button()
        Me.DGV_Productos = New System.Windows.Forms.DataGridView()
        Me.tb_clientes = New System.Windows.Forms.TabControl()
        Me.tb_infoProductos = New System.Windows.Forms.TabPage()
        Me.lbl_apellido2 = New System.Windows.Forms.Label()
        Me.lbl_astApell2 = New System.Windows.Forms.Label()
        Me.lbl_apellido1 = New System.Windows.Forms.Label()
        Me.lbl_astapell1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_buscarProducto = New System.Windows.Forms.Button()
        Me.cbx_unidadMedida = New System.Windows.Forms.ComboBox()
        Me.lbl_tipoCedula = New System.Windows.Forms.Label()
        Me.txt_descripcionProducto = New System.Windows.Forms.TextBox()
        Me.lbl_direccion = New System.Windows.Forms.Label()
        Me.txt_precioUnitario = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_astnom = New System.Windows.Forms.Label()
        Me.txt_codProducto = New System.Windows.Forms.TextBox()
        Me.lbl_cedula = New System.Windows.Forms.Label()
        Me.lbl_astced = New System.Windows.Forms.Label()
        Me.ErrorProviderForm5 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnl_barra.SuspendLayout()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Restaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Guardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_actualizarBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tb_clientes.SuspendLayout()
        Me.tb_infoProductos.SuspendLayout()
        CType(Me.ErrorProviderForm5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_barra2
        '
        Me.pnl_barra2.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_barra2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_barra2.Location = New System.Drawing.Point(0, 40)
        Me.pnl_barra2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_barra2.Name = "pnl_barra2"
        Me.pnl_barra2.Size = New System.Drawing.Size(1725, 8)
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
        Me.pnl_barra.Controls.Add(Me.btn_actualizarBarra)
        Me.pnl_barra.Controls.Add(Me.btn_Back)
        Me.pnl_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_barra.Location = New System.Drawing.Point(0, 0)
        Me.pnl_barra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_barra.Name = "pnl_barra"
        Me.pnl_barra.Size = New System.Drawing.Size(1725, 40)
        Me.pnl_barra.TabIndex = 9
        '
        'lbl_tituloBarra
        '
        Me.lbl_tituloBarra.AutoSize = True
        Me.lbl_tituloBarra.Font = New System.Drawing.Font("Arial Narrow", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tituloBarra.ForeColor = System.Drawing.Color.White
        Me.lbl_tituloBarra.Location = New System.Drawing.Point(141, 11)
        Me.lbl_tituloBarra.Name = "lbl_tituloBarra"
        Me.lbl_tituloBarra.Size = New System.Drawing.Size(89, 23)
        Me.lbl_tituloBarra.TabIndex = 11
        Me.lbl_tituloBarra.Text = "Productos"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cerrar.Image = Global.Contador_Final.My.Resources.Resources.exit_delete_17827
        Me.btn_cerrar.Location = New System.Drawing.Point(1662, 2)
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
        Me.btn_Restaurar.Location = New System.Drawing.Point(1630, 6)
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
        Me.btn_Minimizar.Location = New System.Drawing.Point(1595, 7)
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
        Me.btn_Maximizar.Location = New System.Drawing.Point(1630, 7)
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
        'btn_actualizarBarra
        '
        Me.btn_actualizarBarra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_actualizarBarra.Image = Global.Contador_Final.My.Resources.Resources.blue_upgrade_recyclearrows_arrow_azul_12426
        Me.btn_actualizarBarra.Location = New System.Drawing.Point(54, 2)
        Me.btn_actualizarBarra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_actualizarBarra.Name = "btn_actualizarBarra"
        Me.btn_actualizarBarra.Size = New System.Drawing.Size(38, 35)
        Me.btn_actualizarBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_actualizarBarra.TabIndex = 4
        Me.btn_actualizarBarra.TabStop = False
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
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_limpiar.FlatAppearance.BorderSize = 0
        Me.btn_limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpiar.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.ForeColor = System.Drawing.Color.White
        Me.btn_limpiar.Location = New System.Drawing.Point(191, 278)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(179, 32)
        Me.btn_limpiar.TabIndex = 22
        Me.btn_limpiar.Text = "LIMPIAR"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eliminar.FlatAppearance.BorderSize = 0
        Me.btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.ForeColor = System.Drawing.Color.White
        Me.btn_eliminar.Location = New System.Drawing.Point(1104, 405)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(179, 32)
        Me.btn_eliminar.TabIndex = 25
        Me.btn_eliminar.Text = "ELIMINAR"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_actualizar
        '
        Me.btn_actualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_actualizar.FlatAppearance.BorderSize = 0
        Me.btn_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_actualizar.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizar.ForeColor = System.Drawing.Color.White
        Me.btn_actualizar.Location = New System.Drawing.Point(897, 405)
        Me.btn_actualizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(187, 32)
        Me.btn_actualizar.TabIndex = 24
        Me.btn_actualizar.Text = "ACTUALIZAR"
        Me.btn_actualizar.UseVisualStyleBackColor = False
        '
        'btn_registrar
        '
        Me.btn_registrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btn_registrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_registrar.FlatAppearance.BorderSize = 0
        Me.btn_registrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrar.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrar.ForeColor = System.Drawing.Color.White
        Me.btn_registrar.Location = New System.Drawing.Point(690, 405)
        Me.btn_registrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(187, 32)
        Me.btn_registrar.TabIndex = 23
        Me.btn_registrar.Text = "REGISTRAR"
        Me.btn_registrar.UseVisualStyleBackColor = False
        '
        'btn_mostrar
        '
        Me.btn_mostrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btn_mostrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mostrar.FlatAppearance.BorderSize = 0
        Me.btn_mostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_mostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mostrar.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mostrar.ForeColor = System.Drawing.Color.White
        Me.btn_mostrar.Location = New System.Drawing.Point(1300, 405)
        Me.btn_mostrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_mostrar.Name = "btn_mostrar"
        Me.btn_mostrar.Size = New System.Drawing.Size(179, 32)
        Me.btn_mostrar.TabIndex = 26
        Me.btn_mostrar.Text = "MOSTRAR"
        Me.btn_mostrar.UseVisualStyleBackColor = False
        '
        'DGV_Productos
        '
        Me.DGV_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV_Productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_Productos.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Productos.Location = New System.Drawing.Point(609, 37)
        Me.DGV_Productos.Name = "DGV_Productos"
        Me.DGV_Productos.RowHeadersWidth = 51
        Me.DGV_Productos.RowTemplate.Height = 24
        Me.DGV_Productos.Size = New System.Drawing.Size(1009, 335)
        Me.DGV_Productos.TabIndex = 27
        '
        'tb_clientes
        '
        Me.tb_clientes.Controls.Add(Me.tb_infoProductos)
        Me.tb_clientes.Location = New System.Drawing.Point(54, 97)
        Me.tb_clientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_clientes.Name = "tb_clientes"
        Me.tb_clientes.SelectedIndex = 0
        Me.tb_clientes.Size = New System.Drawing.Size(1648, 486)
        Me.tb_clientes.TabIndex = 21
        '
        'tb_infoProductos
        '
        Me.tb_infoProductos.Controls.Add(Me.btn_limpiar)
        Me.tb_infoProductos.Controls.Add(Me.lbl_apellido2)
        Me.tb_infoProductos.Controls.Add(Me.btn_eliminar)
        Me.tb_infoProductos.Controls.Add(Me.lbl_astApell2)
        Me.tb_infoProductos.Controls.Add(Me.btn_actualizar)
        Me.tb_infoProductos.Controls.Add(Me.lbl_apellido1)
        Me.tb_infoProductos.Controls.Add(Me.btn_registrar)
        Me.tb_infoProductos.Controls.Add(Me.btn_mostrar)
        Me.tb_infoProductos.Controls.Add(Me.lbl_astapell1)
        Me.tb_infoProductos.Controls.Add(Me.Label3)
        Me.tb_infoProductos.Controls.Add(Me.DGV_Productos)
        Me.tb_infoProductos.Controls.Add(Me.Label4)
        Me.tb_infoProductos.Controls.Add(Me.Label5)
        Me.tb_infoProductos.Controls.Add(Me.Label6)
        Me.tb_infoProductos.Controls.Add(Me.Label2)
        Me.tb_infoProductos.Controls.Add(Me.Label1)
        Me.tb_infoProductos.Controls.Add(Me.btn_buscarProducto)
        Me.tb_infoProductos.Controls.Add(Me.cbx_unidadMedida)
        Me.tb_infoProductos.Controls.Add(Me.lbl_tipoCedula)
        Me.tb_infoProductos.Controls.Add(Me.txt_descripcionProducto)
        Me.tb_infoProductos.Controls.Add(Me.lbl_direccion)
        Me.tb_infoProductos.Controls.Add(Me.txt_precioUnitario)
        Me.tb_infoProductos.Controls.Add(Me.lbl_nombre)
        Me.tb_infoProductos.Controls.Add(Me.lbl_astnom)
        Me.tb_infoProductos.Controls.Add(Me.txt_codProducto)
        Me.tb_infoProductos.Controls.Add(Me.lbl_cedula)
        Me.tb_infoProductos.Controls.Add(Me.lbl_astced)
        Me.tb_infoProductos.Location = New System.Drawing.Point(4, 25)
        Me.tb_infoProductos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_infoProductos.Name = "tb_infoProductos"
        Me.tb_infoProductos.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_infoProductos.Size = New System.Drawing.Size(1640, 457)
        Me.tb_infoProductos.TabIndex = 0
        Me.tb_infoProductos.Text = "Información de Productos"
        Me.tb_infoProductos.UseVisualStyleBackColor = True
        '
        'lbl_apellido2
        '
        Me.lbl_apellido2.AutoSize = True
        Me.lbl_apellido2.Location = New System.Drawing.Point(56, 227)
        Me.lbl_apellido2.Name = "lbl_apellido2"
        Me.lbl_apellido2.Size = New System.Drawing.Size(105, 17)
        Me.lbl_apellido2.TabIndex = 34
        Me.lbl_apellido2.Text = "Precio Unitario:"
        '
        'lbl_astApell2
        '
        Me.lbl_astApell2.AutoSize = True
        Me.lbl_astApell2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_astApell2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_astApell2.Location = New System.Drawing.Point(34, 227)
        Me.lbl_astApell2.Name = "lbl_astApell2"
        Me.lbl_astApell2.Size = New System.Drawing.Size(17, 24)
        Me.lbl_astApell2.TabIndex = 33
        Me.lbl_astApell2.Text = "*"
        '
        'lbl_apellido1
        '
        Me.lbl_apellido1.AutoSize = True
        Me.lbl_apellido1.Location = New System.Drawing.Point(56, 181)
        Me.lbl_apellido1.Name = "lbl_apellido1"
        Me.lbl_apellido1.Size = New System.Drawing.Size(127, 17)
        Me.lbl_apellido1.TabIndex = 32
        Me.lbl_apellido1.Text = "Unidad de Medida:"
        '
        'lbl_astapell1
        '
        Me.lbl_astapell1.AutoSize = True
        Me.lbl_astapell1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_astapell1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_astapell1.Location = New System.Drawing.Point(34, 181)
        Me.lbl_astapell1.Name = "lbl_astapell1"
        Me.lbl_astapell1.Size = New System.Drawing.Size(17, 24)
        Me.lbl_astapell1.TabIndex = 31
        Me.lbl_astapell1.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Descripción:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(40, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 24)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Código:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(40, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 24)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(27, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 24)
        Me.Label2.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(33, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 24)
        Me.Label1.TabIndex = 25
        '
        'btn_buscarProducto
        '
        Me.btn_buscarProducto.BackgroundImage = Global.Contador_Final.My.Resources.Resources.magnifier_search_1034
        Me.btn_buscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_buscarProducto.Location = New System.Drawing.Point(361, 24)
        Me.btn_buscarProducto.Name = "btn_buscarProducto"
        Me.btn_buscarProducto.Size = New System.Drawing.Size(28, 23)
        Me.btn_buscarProducto.TabIndex = 4
        Me.btn_buscarProducto.UseVisualStyleBackColor = True
        '
        'cbx_unidadMedida
        '
        Me.cbx_unidadMedida.FormattingEnabled = True
        Me.cbx_unidadMedida.Location = New System.Drawing.Point(191, 177)
        Me.cbx_unidadMedida.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_unidadMedida.Name = "cbx_unidadMedida"
        Me.cbx_unidadMedida.Size = New System.Drawing.Size(144, 24)
        Me.cbx_unidadMedida.TabIndex = 2
        '
        'lbl_tipoCedula
        '
        Me.lbl_tipoCedula.AutoSize = True
        Me.lbl_tipoCedula.Location = New System.Drawing.Point(56, 192)
        Me.lbl_tipoCedula.Name = "lbl_tipoCedula"
        Me.lbl_tipoCedula.Size = New System.Drawing.Size(0, 17)
        Me.lbl_tipoCedula.TabIndex = 24
        '
        'txt_descripcionProducto
        '
        Me.txt_descripcionProducto.Location = New System.Drawing.Point(191, 68)
        Me.txt_descripcionProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_descripcionProducto.Multiline = True
        Me.txt_descripcionProducto.Name = "txt_descripcionProducto"
        Me.txt_descripcionProducto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_descripcionProducto.Size = New System.Drawing.Size(380, 89)
        Me.txt_descripcionProducto.TabIndex = 14
        '
        'lbl_direccion
        '
        Me.lbl_direccion.AutoSize = True
        Me.lbl_direccion.Location = New System.Drawing.Point(50, 208)
        Me.lbl_direccion.Name = "lbl_direccion"
        Me.lbl_direccion.Size = New System.Drawing.Size(0, 17)
        Me.lbl_direccion.TabIndex = 22
        '
        'txt_precioUnitario
        '
        Me.txt_precioUnitario.Location = New System.Drawing.Point(191, 226)
        Me.txt_precioUnitario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_precioUnitario.Name = "txt_precioUnitario"
        Me.txt_precioUnitario.Size = New System.Drawing.Size(144, 22)
        Me.txt_precioUnitario.TabIndex = 5
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(56, 228)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(0, 17)
        Me.lbl_nombre.TabIndex = 4
        '
        'lbl_astnom
        '
        Me.lbl_astnom.AutoSize = True
        Me.lbl_astnom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_astnom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_astnom.Location = New System.Drawing.Point(34, 226)
        Me.lbl_astnom.Name = "lbl_astnom"
        Me.lbl_astnom.Size = New System.Drawing.Size(0, 24)
        Me.lbl_astnom.TabIndex = 3
        '
        'txt_codProducto
        '
        Me.txt_codProducto.Location = New System.Drawing.Point(191, 24)
        Me.txt_codProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_codProducto.Name = "txt_codProducto"
        Me.txt_codProducto.Size = New System.Drawing.Size(144, 22)
        Me.txt_codProducto.TabIndex = 3
        '
        'lbl_cedula
        '
        Me.lbl_cedula.AutoSize = True
        Me.lbl_cedula.Location = New System.Drawing.Point(56, 26)
        Me.lbl_cedula.Name = "lbl_cedula"
        Me.lbl_cedula.Size = New System.Drawing.Size(0, 17)
        Me.lbl_cedula.TabIndex = 1
        '
        'lbl_astced
        '
        Me.lbl_astced.AutoSize = True
        Me.lbl_astced.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_astced.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_astced.Location = New System.Drawing.Point(34, 24)
        Me.lbl_astced.Name = "lbl_astced"
        Me.lbl_astced.Size = New System.Drawing.Size(0, 24)
        Me.lbl_astced.TabIndex = 0
        '
        'ErrorProviderForm5
        '
        Me.ErrorProviderForm5.ContainerControl = Me
        '
        'Form5b_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1725, 633)
        Me.Controls.Add(Me.tb_clientes)
        Me.Controls.Add(Me.pnl_barra2)
        Me.Controls.Add(Me.pnl_barra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form5b_Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5b_Productos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_barra.ResumeLayout(False)
        Me.pnl_barra.PerformLayout()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Restaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Guardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_actualizarBarra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tb_clientes.ResumeLayout(False)
        Me.tb_infoProductos.ResumeLayout(False)
        Me.tb_infoProductos.PerformLayout()
        CType(Me.ErrorProviderForm5, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btn_actualizarBarra As PictureBox
    Friend WithEvents btn_Back As PictureBox
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents btn_registrar As Button
    Friend WithEvents btn_mostrar As Button
    Friend WithEvents DGV_Productos As DataGridView
    Friend WithEvents tb_clientes As TabControl
    Friend WithEvents ErrorProviderForm5 As ErrorProvider
    Friend WithEvents tb_infoProductos As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_buscarProducto As Button
    Friend WithEvents cbx_unidadMedida As ComboBox
    Friend WithEvents lbl_tipoCedula As Label
    Friend WithEvents txt_descripcionProducto As TextBox
    Friend WithEvents lbl_direccion As Label
    Friend WithEvents txt_precioUnitario As TextBox
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_astnom As Label
    Friend WithEvents txt_codProducto As TextBox
    Friend WithEvents lbl_cedula As Label
    Friend WithEvents lbl_astced As Label
    Friend WithEvents lbl_apellido2 As Label
    Friend WithEvents lbl_astApell2 As Label
    Friend WithEvents lbl_apellido1 As Label
    Friend WithEvents lbl_astapell1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
