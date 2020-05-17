<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5_MantenimientoClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5_MantenimientoClientes))
        Me.tb_clientes = New System.Windows.Forms.TabControl()
        Me.tb_infoPersonal = New System.Windows.Forms.TabPage()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.cbx_pais = New System.Windows.Forms.ComboBox()
        Me.cbx_Distrito = New System.Windows.Forms.ComboBox()
        Me.cbx_Canton = New System.Windows.Forms.ComboBox()
        Me.cbx_Provincia = New System.Windows.Forms.ComboBox()
        Me.lbl_distrito = New System.Windows.Forms.Label()
        Me.lbl_astdist = New System.Windows.Forms.Label()
        Me.lbl_canton = New System.Windows.Forms.Label()
        Me.lbl_astcant = New System.Windows.Forms.Label()
        Me.lbl_provincia = New System.Windows.Forms.Label()
        Me.lbl_astprov = New System.Windows.Forms.Label()
        Me.lbl_area = New System.Windows.Forms.Label()
        Me.lbl_astarea = New System.Windows.Forms.Label()
        Me.cbx_tipoID = New System.Windows.Forms.ComboBox()
        Me.lbl_tipoCedula = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.lbl_direccion = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_apellido2 = New System.Windows.Forms.TextBox()
        Me.lbl_apellido2 = New System.Windows.Forms.Label()
        Me.lbl_astApell2 = New System.Windows.Forms.Label()
        Me.txt_apellido1 = New System.Windows.Forms.TextBox()
        Me.lbl_apellido1 = New System.Windows.Forms.Label()
        Me.lbl_astapell1 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_astnom = New System.Windows.Forms.Label()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.lbl_cedula = New System.Windows.Forms.Label()
        Me.lbl_astced = New System.Windows.Forms.Label()
        Me.pnl_barra = New System.Windows.Forms.Panel()
        Me.lbl_tituloBarra = New System.Windows.Forms.Label()
        Me.btn_cerrar = New System.Windows.Forms.PictureBox()
        Me.btn_Minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_Maximizar = New System.Windows.Forms.PictureBox()
        Me.btn_Guardar = New System.Windows.Forms.PictureBox()
        Me.btn_actualizarBarra = New System.Windows.Forms.PictureBox()
        Me.btn_Back = New System.Windows.Forms.PictureBox()
        Me.pnl_barra2 = New System.Windows.Forms.Panel()
        Me.DGV_Clientes = New System.Windows.Forms.DataGridView()
        Me.btn_mostrar = New System.Windows.Forms.Button()
        Me.btn_registrarCliente = New System.Windows.Forms.Button()
        Me.btn_Restaurar = New System.Windows.Forms.PictureBox()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.ErrorProviderForm5 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tb_clientes.SuspendLayout()
        Me.tb_infoPersonal.SuspendLayout()
        Me.pnl_barra.SuspendLayout()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Guardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_actualizarBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Restaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderForm5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_clientes
        '
        Me.tb_clientes.Controls.Add(Me.tb_infoPersonal)
        Me.tb_clientes.Location = New System.Drawing.Point(399, 114)
        Me.tb_clientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_clientes.Name = "tb_clientes"
        Me.tb_clientes.SelectedIndex = 0
        Me.tb_clientes.Size = New System.Drawing.Size(1022, 313)
        Me.tb_clientes.TabIndex = 1
        '
        'tb_infoPersonal
        '
        Me.tb_infoPersonal.Controls.Add(Me.btn_buscar)
        Me.tb_infoPersonal.Controls.Add(Me.cbx_pais)
        Me.tb_infoPersonal.Controls.Add(Me.cbx_Distrito)
        Me.tb_infoPersonal.Controls.Add(Me.cbx_Canton)
        Me.tb_infoPersonal.Controls.Add(Me.cbx_Provincia)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_distrito)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_astdist)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_canton)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_astcant)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_provincia)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_astprov)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_area)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_astarea)
        Me.tb_infoPersonal.Controls.Add(Me.cbx_tipoID)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_tipoCedula)
        Me.tb_infoPersonal.Controls.Add(Me.txt_direccion)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_direccion)
        Me.tb_infoPersonal.Controls.Add(Me.txt_telefono)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_telefono)
        Me.tb_infoPersonal.Controls.Add(Me.txt_email)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_email)
        Me.tb_infoPersonal.Controls.Add(Me.txt_apellido2)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_apellido2)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_astApell2)
        Me.tb_infoPersonal.Controls.Add(Me.txt_apellido1)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_apellido1)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_astapell1)
        Me.tb_infoPersonal.Controls.Add(Me.txt_nombre)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_nombre)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_astnom)
        Me.tb_infoPersonal.Controls.Add(Me.txt_cedula)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_cedula)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_astced)
        Me.tb_infoPersonal.Location = New System.Drawing.Point(4, 25)
        Me.tb_infoPersonal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_infoPersonal.Name = "tb_infoPersonal"
        Me.tb_infoPersonal.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_infoPersonal.Size = New System.Drawing.Size(1014, 284)
        Me.tb_infoPersonal.TabIndex = 0
        Me.tb_infoPersonal.Text = "Información Personal"
        Me.tb_infoPersonal.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.BackgroundImage = Global.Contador_Final.My.Resources.Resources.magnifier_search_1034
        Me.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_buscar.Location = New System.Drawing.Point(361, 50)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(28, 23)
        Me.btn_buscar.TabIndex = 4
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'cbx_pais
        '
        Me.cbx_pais.FormattingEnabled = True
        Me.cbx_pais.Location = New System.Drawing.Point(191, 200)
        Me.cbx_pais.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_pais.Name = "cbx_pais"
        Me.cbx_pais.Size = New System.Drawing.Size(144, 24)
        Me.cbx_pais.TabIndex = 9
        '
        'cbx_Distrito
        '
        Me.cbx_Distrito.Enabled = False
        Me.cbx_Distrito.FormattingEnabled = True
        Me.cbx_Distrito.Location = New System.Drawing.Point(548, 89)
        Me.cbx_Distrito.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_Distrito.Name = "cbx_Distrito"
        Me.cbx_Distrito.Size = New System.Drawing.Size(186, 24)
        Me.cbx_Distrito.TabIndex = 13
        '
        'cbx_Canton
        '
        Me.cbx_Canton.Enabled = False
        Me.cbx_Canton.FormattingEnabled = True
        Me.cbx_Canton.Location = New System.Drawing.Point(548, 54)
        Me.cbx_Canton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_Canton.Name = "cbx_Canton"
        Me.cbx_Canton.Size = New System.Drawing.Size(186, 24)
        Me.cbx_Canton.TabIndex = 12
        '
        'cbx_Provincia
        '
        Me.cbx_Provincia.Enabled = False
        Me.cbx_Provincia.FormattingEnabled = True
        Me.cbx_Provincia.Location = New System.Drawing.Point(548, 18)
        Me.cbx_Provincia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_Provincia.Name = "cbx_Provincia"
        Me.cbx_Provincia.Size = New System.Drawing.Size(186, 24)
        Me.cbx_Provincia.TabIndex = 11
        '
        'lbl_distrito
        '
        Me.lbl_distrito.AutoSize = True
        Me.lbl_distrito.Location = New System.Drawing.Point(452, 87)
        Me.lbl_distrito.Name = "lbl_distrito"
        Me.lbl_distrito.Size = New System.Drawing.Size(56, 17)
        Me.lbl_distrito.TabIndex = 34
        Me.lbl_distrito.Text = "Distrito:"
        '
        'lbl_astdist
        '
        Me.lbl_astdist.AutoSize = True
        Me.lbl_astdist.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_astdist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_astdist.Location = New System.Drawing.Point(430, 87)
        Me.lbl_astdist.Name = "lbl_astdist"
        Me.lbl_astdist.Size = New System.Drawing.Size(17, 24)
        Me.lbl_astdist.TabIndex = 33
        Me.lbl_astdist.Text = "*"
        '
        'lbl_canton
        '
        Me.lbl_canton.AutoSize = True
        Me.lbl_canton.Location = New System.Drawing.Point(452, 54)
        Me.lbl_canton.Name = "lbl_canton"
        Me.lbl_canton.Size = New System.Drawing.Size(57, 17)
        Me.lbl_canton.TabIndex = 32
        Me.lbl_canton.Text = "Canton:"
        '
        'lbl_astcant
        '
        Me.lbl_astcant.AutoSize = True
        Me.lbl_astcant.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_astcant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_astcant.Location = New System.Drawing.Point(430, 54)
        Me.lbl_astcant.Name = "lbl_astcant"
        Me.lbl_astcant.Size = New System.Drawing.Size(17, 24)
        Me.lbl_astcant.TabIndex = 31
        Me.lbl_astcant.Text = "*"
        '
        'lbl_provincia
        '
        Me.lbl_provincia.AutoSize = True
        Me.lbl_provincia.Location = New System.Drawing.Point(452, 25)
        Me.lbl_provincia.Name = "lbl_provincia"
        Me.lbl_provincia.Size = New System.Drawing.Size(70, 17)
        Me.lbl_provincia.TabIndex = 30
        Me.lbl_provincia.Text = "Provincia:"
        '
        'lbl_astprov
        '
        Me.lbl_astprov.AutoSize = True
        Me.lbl_astprov.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_astprov.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_astprov.Location = New System.Drawing.Point(430, 22)
        Me.lbl_astprov.Name = "lbl_astprov"
        Me.lbl_astprov.Size = New System.Drawing.Size(17, 24)
        Me.lbl_astprov.TabIndex = 29
        Me.lbl_astprov.Text = "*"
        '
        'lbl_area
        '
        Me.lbl_area.AutoSize = True
        Me.lbl_area.Location = New System.Drawing.Point(56, 202)
        Me.lbl_area.Name = "lbl_area"
        Me.lbl_area.Size = New System.Drawing.Size(42, 17)
        Me.lbl_area.TabIndex = 27
        Me.lbl_area.Text = "Área:"
        '
        'lbl_astarea
        '
        Me.lbl_astarea.AutoSize = True
        Me.lbl_astarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_astarea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_astarea.Location = New System.Drawing.Point(34, 202)
        Me.lbl_astarea.Name = "lbl_astarea"
        Me.lbl_astarea.Size = New System.Drawing.Size(17, 24)
        Me.lbl_astarea.TabIndex = 26
        Me.lbl_astarea.Text = "*"
        '
        'cbx_tipoID
        '
        Me.cbx_tipoID.FormattingEnabled = True
        Me.cbx_tipoID.Location = New System.Drawing.Point(191, 18)
        Me.cbx_tipoID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_tipoID.Name = "cbx_tipoID"
        Me.cbx_tipoID.Size = New System.Drawing.Size(144, 24)
        Me.cbx_tipoID.TabIndex = 2
        '
        'lbl_tipoCedula
        '
        Me.lbl_tipoCedula.AutoSize = True
        Me.lbl_tipoCedula.Location = New System.Drawing.Point(56, 25)
        Me.lbl_tipoCedula.Name = "lbl_tipoCedula"
        Me.lbl_tipoCedula.Size = New System.Drawing.Size(88, 17)
        Me.lbl_tipoCedula.TabIndex = 24
        Me.lbl_tipoCedula.Text = "Tipo Cédula:"
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(548, 130)
        Me.txt_direccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_direccion.Multiline = True
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(256, 107)
        Me.txt_direccion.TabIndex = 14
        '
        'lbl_direccion
        '
        Me.lbl_direccion.AutoSize = True
        Me.lbl_direccion.Location = New System.Drawing.Point(452, 174)
        Me.lbl_direccion.Name = "lbl_direccion"
        Me.lbl_direccion.Size = New System.Drawing.Size(71, 17)
        Me.lbl_direccion.TabIndex = 22
        Me.lbl_direccion.Text = "Dirección:"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(191, 230)
        Me.txt_telefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(144, 22)
        Me.txt_telefono.TabIndex = 10
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(56, 233)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(68, 17)
        Me.lbl_telefono.TabIndex = 16
        Me.lbl_telefono.Text = "Telefono:"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(191, 172)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(144, 22)
        Me.txt_email.TabIndex = 8
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(56, 174)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(46, 17)
        Me.lbl_email.TabIndex = 13
        Me.lbl_email.Text = "Email:"
        '
        'txt_apellido2
        '
        Me.txt_apellido2.Location = New System.Drawing.Point(191, 142)
        Me.txt_apellido2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_apellido2.Name = "txt_apellido2"
        Me.txt_apellido2.Size = New System.Drawing.Size(144, 22)
        Me.txt_apellido2.TabIndex = 7
        '
        'lbl_apellido2
        '
        Me.lbl_apellido2.AutoSize = True
        Me.lbl_apellido2.Location = New System.Drawing.Point(56, 144)
        Me.lbl_apellido2.Name = "lbl_apellido2"
        Me.lbl_apellido2.Size = New System.Drawing.Size(123, 17)
        Me.lbl_apellido2.TabIndex = 10
        Me.lbl_apellido2.Text = "Segundo Apellido:"
        '
        'lbl_astApell2
        '
        Me.lbl_astApell2.AutoSize = True
        Me.lbl_astApell2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_astApell2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_astApell2.Location = New System.Drawing.Point(34, 144)
        Me.lbl_astApell2.Name = "lbl_astApell2"
        Me.lbl_astApell2.Size = New System.Drawing.Size(17, 24)
        Me.lbl_astApell2.TabIndex = 9
        Me.lbl_astApell2.Text = "*"
        '
        'txt_apellido1
        '
        Me.txt_apellido1.Location = New System.Drawing.Point(191, 112)
        Me.txt_apellido1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_apellido1.Name = "txt_apellido1"
        Me.txt_apellido1.Size = New System.Drawing.Size(144, 22)
        Me.txt_apellido1.TabIndex = 6
        '
        'lbl_apellido1
        '
        Me.lbl_apellido1.AutoSize = True
        Me.lbl_apellido1.Location = New System.Drawing.Point(56, 114)
        Me.lbl_apellido1.Name = "lbl_apellido1"
        Me.lbl_apellido1.Size = New System.Drawing.Size(107, 17)
        Me.lbl_apellido1.TabIndex = 7
        Me.lbl_apellido1.Text = "Primer Apellido:"
        '
        'lbl_astapell1
        '
        Me.lbl_astapell1.AutoSize = True
        Me.lbl_astapell1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_astapell1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_astapell1.Location = New System.Drawing.Point(34, 114)
        Me.lbl_astapell1.Name = "lbl_astapell1"
        Me.lbl_astapell1.Size = New System.Drawing.Size(17, 24)
        Me.lbl_astapell1.TabIndex = 6
        Me.lbl_astapell1.Text = "*"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(191, 80)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(144, 22)
        Me.txt_nombre.TabIndex = 5
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(56, 82)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(62, 17)
        Me.lbl_nombre.TabIndex = 4
        Me.lbl_nombre.Text = "Nombre:"
        '
        'lbl_astnom
        '
        Me.lbl_astnom.AutoSize = True
        Me.lbl_astnom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_astnom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_astnom.Location = New System.Drawing.Point(34, 82)
        Me.lbl_astnom.Name = "lbl_astnom"
        Me.lbl_astnom.Size = New System.Drawing.Size(17, 24)
        Me.lbl_astnom.TabIndex = 3
        Me.lbl_astnom.Text = "*"
        '
        'txt_cedula
        '
        Me.txt_cedula.Location = New System.Drawing.Point(191, 50)
        Me.txt_cedula.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(144, 22)
        Me.txt_cedula.TabIndex = 3
        '
        'lbl_cedula
        '
        Me.lbl_cedula.AutoSize = True
        Me.lbl_cedula.Location = New System.Drawing.Point(56, 52)
        Me.lbl_cedula.Name = "lbl_cedula"
        Me.lbl_cedula.Size = New System.Drawing.Size(56, 17)
        Me.lbl_cedula.TabIndex = 1
        Me.lbl_cedula.Text = "Cédula:"
        '
        'lbl_astced
        '
        Me.lbl_astced.AutoSize = True
        Me.lbl_astced.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_astced.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_astced.Location = New System.Drawing.Point(34, 50)
        Me.lbl_astced.Name = "lbl_astced"
        Me.lbl_astced.Size = New System.Drawing.Size(17, 24)
        Me.lbl_astced.TabIndex = 0
        Me.lbl_astced.Text = "*"
        '
        'pnl_barra
        '
        Me.pnl_barra.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.pnl_barra.Controls.Add(Me.lbl_tituloBarra)
        Me.pnl_barra.Controls.Add(Me.btn_cerrar)
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
        Me.pnl_barra.TabIndex = 5
        '
        'lbl_tituloBarra
        '
        Me.lbl_tituloBarra.AutoSize = True
        Me.lbl_tituloBarra.Font = New System.Drawing.Font("Arial Narrow", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tituloBarra.ForeColor = System.Drawing.Color.White
        Me.lbl_tituloBarra.Location = New System.Drawing.Point(146, 11)
        Me.lbl_tituloBarra.Name = "lbl_tituloBarra"
        Me.lbl_tituloBarra.Size = New System.Drawing.Size(210, 23)
        Me.lbl_tituloBarra.TabIndex = 9
        Me.lbl_tituloBarra.Text = "Mantenimiento de Clientes"
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
        'pnl_barra2
        '
        Me.pnl_barra2.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_barra2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_barra2.Location = New System.Drawing.Point(0, 40)
        Me.pnl_barra2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_barra2.Name = "pnl_barra2"
        Me.pnl_barra2.Size = New System.Drawing.Size(1725, 8)
        Me.pnl_barra2.TabIndex = 6
        '
        'DGV_Clientes
        '
        Me.DGV_Clientes.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Clientes.Location = New System.Drawing.Point(215, 583)
        Me.DGV_Clientes.Name = "DGV_Clientes"
        Me.DGV_Clientes.RowHeadersWidth = 51
        Me.DGV_Clientes.RowTemplate.Height = 24
        Me.DGV_Clientes.Size = New System.Drawing.Size(1457, 322)
        Me.DGV_Clientes.TabIndex = 20
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
        Me.btn_mostrar.Location = New System.Drawing.Point(776, 530)
        Me.btn_mostrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_mostrar.Name = "btn_mostrar"
        Me.btn_mostrar.Size = New System.Drawing.Size(259, 32)
        Me.btn_mostrar.TabIndex = 19
        Me.btn_mostrar.Text = "MOSTRAR CLIENTES"
        Me.btn_mostrar.UseVisualStyleBackColor = False
        '
        'btn_registrarCliente
        '
        Me.btn_registrarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btn_registrarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_registrarCliente.FlatAppearance.BorderSize = 0
        Me.btn_registrarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_registrarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_registrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrarCliente.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrarCliente.ForeColor = System.Drawing.Color.White
        Me.btn_registrarCliente.Location = New System.Drawing.Point(732, 449)
        Me.btn_registrarCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_registrarCliente.Name = "btn_registrarCliente"
        Me.btn_registrarCliente.Size = New System.Drawing.Size(187, 32)
        Me.btn_registrarCliente.TabIndex = 16
        Me.btn_registrarCliente.Text = "REGISTRAR"
        Me.btn_registrarCliente.UseVisualStyleBackColor = False
        '
        'btn_Restaurar
        '
        Me.btn_Restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restaurar.Image = Global.Contador_Final.My.Resources.Resources.restore_14803
        Me.btn_Restaurar.Location = New System.Drawing.Point(1630, 7)
        Me.btn_Restaurar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Restaurar.Name = "btn_Restaurar"
        Me.btn_Restaurar.Size = New System.Drawing.Size(30, 28)
        Me.btn_Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Restaurar.TabIndex = 7
        Me.btn_Restaurar.TabStop = False
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
        Me.btn_limpiar.Location = New System.Drawing.Point(535, 449)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(179, 32)
        Me.btn_limpiar.TabIndex = 15
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
        Me.btn_eliminar.Location = New System.Drawing.Point(1127, 449)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(179, 32)
        Me.btn_eliminar.TabIndex = 18
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
        Me.btn_actualizar.Location = New System.Drawing.Point(932, 449)
        Me.btn_actualizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(179, 32)
        Me.btn_actualizar.TabIndex = 17
        Me.btn_actualizar.Text = "ACTUALIZAR"
        Me.btn_actualizar.UseVisualStyleBackColor = False
        '
        'ErrorProviderForm5
        '
        Me.ErrorProviderForm5.ContainerControl = Me
        '
        'Form5_MantenimientoClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1725, 925)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_actualizar)
        Me.Controls.Add(Me.btn_registrarCliente)
        Me.Controls.Add(Me.btn_mostrar)
        Me.Controls.Add(Me.btn_Restaurar)
        Me.Controls.Add(Me.DGV_Clientes)
        Me.Controls.Add(Me.pnl_barra2)
        Me.Controls.Add(Me.pnl_barra)
        Me.Controls.Add(Me.tb_clientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form5_MantenimientoClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5_Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tb_clientes.ResumeLayout(False)
        Me.tb_infoPersonal.ResumeLayout(False)
        Me.tb_infoPersonal.PerformLayout()
        Me.pnl_barra.ResumeLayout(False)
        Me.pnl_barra.PerformLayout()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Guardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_actualizarBarra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Restaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderForm5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tb_clientes As TabControl
    Friend WithEvents tb_infoPersonal As TabPage
    Friend WithEvents cbx_tipoID As ComboBox
    Friend WithEvents lbl_tipoCedula As Label
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents lbl_direccion As Label
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents lbl_telefono As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents txt_apellido2 As TextBox
    Friend WithEvents lbl_apellido2 As Label
    Friend WithEvents lbl_astApell2 As Label
    Friend WithEvents txt_apellido1 As TextBox
    Friend WithEvents lbl_apellido1 As Label
    Friend WithEvents lbl_astapell1 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_astnom As Label
    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents lbl_cedula As Label
    Friend WithEvents lbl_astced As Label
    Friend WithEvents lbl_area As Label
    Friend WithEvents lbl_astarea As Label
    Friend WithEvents lbl_distrito As Label
    Friend WithEvents lbl_astdist As Label
    Friend WithEvents lbl_canton As Label
    Friend WithEvents lbl_astcant As Label
    Friend WithEvents lbl_provincia As Label
    Friend WithEvents lbl_astprov As Label
    Friend WithEvents cbx_Distrito As ComboBox
    Friend WithEvents cbx_Canton As ComboBox
    Friend WithEvents cbx_Provincia As ComboBox
    Friend WithEvents pnl_barra As Panel
    Friend WithEvents btn_cerrar As PictureBox
    Friend WithEvents btn_Restaurar As PictureBox
    Friend WithEvents btn_Minimizar As PictureBox
    Friend WithEvents btn_Maximizar As PictureBox
    Friend WithEvents btn_Guardar As PictureBox
    Friend WithEvents btn_actualizarBarra As PictureBox
    Friend WithEvents btn_Back As PictureBox
    Friend WithEvents pnl_barra2 As Panel
    Friend WithEvents lbl_tituloBarra As Label
    Friend WithEvents cbx_pais As ComboBox
    Friend WithEvents DGV_Clientes As DataGridView
    Friend WithEvents btn_mostrar As Button
    Friend WithEvents btn_registrarCliente As Button
    Friend WithEvents btn_buscar As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents ErrorProviderForm5 As ErrorProvider
End Class
