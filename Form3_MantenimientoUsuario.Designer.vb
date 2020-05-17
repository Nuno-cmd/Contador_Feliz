<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3_MantenimientoUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3_MantenimientoUsuario))
        Me.pbl_sup2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.pbl_barraTitulo = New System.Windows.Forms.Panel()
        Me.lbl_tituloBarra = New System.Windows.Forms.Label()
        Me.btn_cerrar = New System.Windows.Forms.PictureBox()
        Me.btn_restaurar = New System.Windows.Forms.PictureBox()
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_Maximizar = New System.Windows.Forms.PictureBox()
        Me.btn_Guardar = New System.Windows.Forms.PictureBox()
        Me.btn_ActualizarBarra = New System.Windows.Forms.PictureBox()
        Me.btn_Back = New System.Windows.Forms.PictureBox()
        Me.tb_informacion = New System.Windows.Forms.TabControl()
        Me.tb_infoPersonal = New System.Windows.Forms.TabPage()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.lbl_direccion = New System.Windows.Forms.Label()
        Me.lbl_astDir = New System.Windows.Forms.Label()
        Me.txt_extension = New System.Windows.Forms.TextBox()
        Me.lbl_extension = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.lbl_astTel = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_astEmail = New System.Windows.Forms.Label()
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
        Me.tb_infoSeguridad = New System.Windows.Forms.TabPage()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbx_pregunta = New System.Windows.Forms.ComboBox()
        Me.txt_repitaContrasena = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_astRepContra = New System.Windows.Forms.Label()
        Me.txt_contrasena = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_astContra = New System.Windows.Forms.Label()
        Me.txt_respuesta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_astRes = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_astPreg = New System.Windows.Forms.Label()
        Me.lbl_subtitCambio = New System.Windows.Forms.Label()
        Me.btn_mostrarUsuarios = New System.Windows.Forms.Button()
        Me.DGV_Usuarios = New System.Windows.Forms.DataGridView()
        Me.ErrorProviderForm3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btn_registrarUsuario = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.pbl_barraTitulo.SuspendLayout()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_restaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Guardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_ActualizarBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tb_informacion.SuspendLayout()
        Me.tb_infoPersonal.SuspendLayout()
        Me.tb_infoSeguridad.SuspendLayout()
        CType(Me.DGV_Usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderForm3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbl_sup2
        '
        Me.pbl_sup2.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pbl_sup2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbl_sup2.Location = New System.Drawing.Point(0, 40)
        Me.pbl_sup2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbl_sup2.Name = "pbl_sup2"
        Me.pbl_sup2.Size = New System.Drawing.Size(1725, 8)
        Me.pbl_sup2.TabIndex = 1
        '
        'pbl_barraTitulo
        '
        Me.pbl_barraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.pbl_barraTitulo.Controls.Add(Me.lbl_tituloBarra)
        Me.pbl_barraTitulo.Controls.Add(Me.btn_cerrar)
        Me.pbl_barraTitulo.Controls.Add(Me.btn_restaurar)
        Me.pbl_barraTitulo.Controls.Add(Me.btn_minimizar)
        Me.pbl_barraTitulo.Controls.Add(Me.btn_Maximizar)
        Me.pbl_barraTitulo.Controls.Add(Me.btn_Guardar)
        Me.pbl_barraTitulo.Controls.Add(Me.btn_ActualizarBarra)
        Me.pbl_barraTitulo.Controls.Add(Me.btn_Back)
        Me.pbl_barraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbl_barraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pbl_barraTitulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbl_barraTitulo.Name = "pbl_barraTitulo"
        Me.pbl_barraTitulo.Size = New System.Drawing.Size(1725, 40)
        Me.pbl_barraTitulo.TabIndex = 0
        '
        'lbl_tituloBarra
        '
        Me.lbl_tituloBarra.AutoSize = True
        Me.lbl_tituloBarra.Font = New System.Drawing.Font("Arial Narrow", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tituloBarra.ForeColor = System.Drawing.Color.White
        Me.lbl_tituloBarra.Location = New System.Drawing.Point(143, 13)
        Me.lbl_tituloBarra.Name = "lbl_tituloBarra"
        Me.lbl_tituloBarra.Size = New System.Drawing.Size(217, 23)
        Me.lbl_tituloBarra.TabIndex = 7
        Me.lbl_tituloBarra.Text = "Mantenimiento de Usuarios"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cerrar.Image = Global.Contador_Final.My.Resources.Resources.exit_delete_17827
        Me.btn_cerrar.Location = New System.Drawing.Point(1662, 1)
        Me.btn_cerrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(40, 34)
        Me.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_cerrar.TabIndex = 6
        Me.btn_cerrar.TabStop = False
        '
        'btn_restaurar
        '
        Me.btn_restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_restaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_restaurar.Image = Global.Contador_Final.My.Resources.Resources.restore_14803
        Me.btn_restaurar.Location = New System.Drawing.Point(1627, 6)
        Me.btn_restaurar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_restaurar.Name = "btn_restaurar"
        Me.btn_restaurar.Size = New System.Drawing.Size(30, 28)
        Me.btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_restaurar.TabIndex = 5
        Me.btn_restaurar.TabStop = False
        '
        'btn_minimizar
        '
        Me.btn_minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimizar.Image = Global.Contador_Final.My.Resources.Resources.minimize_147751
        Me.btn_minimizar.Location = New System.Drawing.Point(1591, 6)
        Me.btn_minimizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(30, 28)
        Me.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_minimizar.TabIndex = 3
        Me.btn_minimizar.TabStop = False
        '
        'btn_Maximizar
        '
        Me.btn_Maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Maximizar.Image = Global.Contador_Final.My.Resources.Resources.window_maximize_icon_137012
        Me.btn_Maximizar.Location = New System.Drawing.Point(1627, 6)
        Me.btn_Maximizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Maximizar.Name = "btn_Maximizar"
        Me.btn_Maximizar.Size = New System.Drawing.Size(30, 28)
        Me.btn_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Maximizar.TabIndex = 4
        Me.btn_Maximizar.TabStop = False
        Me.btn_Maximizar.Visible = False
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Guardar.Image = Global.Contador_Final.My.Resources.Resources.save_14706
        Me.btn_Guardar.Location = New System.Drawing.Point(91, 6)
        Me.btn_Guardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(32, 33)
        Me.btn_Guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Guardar.TabIndex = 2
        Me.btn_Guardar.TabStop = False
        '
        'btn_ActualizarBarra
        '
        Me.btn_ActualizarBarra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ActualizarBarra.Image = Global.Contador_Final.My.Resources.Resources.blue_upgrade_recyclearrows_arrow_azul_12426
        Me.btn_ActualizarBarra.Location = New System.Drawing.Point(47, 3)
        Me.btn_ActualizarBarra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_ActualizarBarra.Name = "btn_ActualizarBarra"
        Me.btn_ActualizarBarra.Size = New System.Drawing.Size(38, 35)
        Me.btn_ActualizarBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_ActualizarBarra.TabIndex = 1
        Me.btn_ActualizarBarra.TabStop = False
        '
        'btn_Back
        '
        Me.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Back.Image = Global.Contador_Final.My.Resources.Resources.arrow_left_17809
        Me.btn_Back.Location = New System.Drawing.Point(4, 3)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(38, 35)
        Me.btn_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Back.TabIndex = 0
        Me.btn_Back.TabStop = False
        '
        'tb_informacion
        '
        Me.tb_informacion.Controls.Add(Me.tb_infoPersonal)
        Me.tb_informacion.Controls.Add(Me.tb_infoSeguridad)
        Me.tb_informacion.Location = New System.Drawing.Point(391, 133)
        Me.tb_informacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_informacion.Name = "tb_informacion"
        Me.tb_informacion.SelectedIndex = 0
        Me.tb_informacion.Size = New System.Drawing.Size(1022, 280)
        Me.tb_informacion.TabIndex = 1
        '
        'tb_infoPersonal
        '
        Me.tb_infoPersonal.Controls.Add(Me.txt_direccion)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_direccion)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_astDir)
        Me.tb_infoPersonal.Controls.Add(Me.txt_extension)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_extension)
        Me.tb_infoPersonal.Controls.Add(Me.txt_telefono)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_telefono)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_astTel)
        Me.tb_infoPersonal.Controls.Add(Me.txt_email)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_email)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_astEmail)
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
        Me.tb_infoPersonal.Size = New System.Drawing.Size(1014, 251)
        Me.tb_infoPersonal.TabIndex = 0
        Me.tb_infoPersonal.Text = "Información Personal"
        Me.tb_infoPersonal.UseVisualStyleBackColor = True
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(663, 26)
        Me.txt_direccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_direccion.Multiline = True
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(256, 107)
        Me.txt_direccion.TabIndex = 9
        '
        'lbl_direccion
        '
        Me.lbl_direccion.AutoSize = True
        Me.lbl_direccion.Location = New System.Drawing.Point(573, 26)
        Me.lbl_direccion.Name = "lbl_direccion"
        Me.lbl_direccion.Size = New System.Drawing.Size(71, 17)
        Me.lbl_direccion.TabIndex = 22
        Me.lbl_direccion.Text = "Dirección:"
        '
        'lbl_astDir
        '
        Me.lbl_astDir.AutoSize = True
        Me.lbl_astDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_astDir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_astDir.Location = New System.Drawing.Point(551, 24)
        Me.lbl_astDir.Name = "lbl_astDir"
        Me.lbl_astDir.Size = New System.Drawing.Size(17, 24)
        Me.lbl_astDir.TabIndex = 21
        Me.lbl_astDir.Text = "*"
        '
        'txt_extension
        '
        Me.txt_extension.Location = New System.Drawing.Point(395, 180)
        Me.txt_extension.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_extension.Name = "txt_extension"
        Me.txt_extension.Size = New System.Drawing.Size(103, 22)
        Me.txt_extension.TabIndex = 8
        '
        'lbl_extension
        '
        Me.lbl_extension.AutoSize = True
        Me.lbl_extension.Location = New System.Drawing.Point(358, 185)
        Me.lbl_extension.Name = "lbl_extension"
        Me.lbl_extension.Size = New System.Drawing.Size(35, 17)
        Me.lbl_extension.TabIndex = 19
        Me.lbl_extension.Text = "Ext.:"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(191, 180)
        Me.txt_telefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(144, 22)
        Me.txt_telefono.TabIndex = 7
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(56, 182)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(68, 17)
        Me.lbl_telefono.TabIndex = 16
        Me.lbl_telefono.Text = "Telefono:"
        '
        'lbl_astTel
        '
        Me.lbl_astTel.AutoSize = True
        Me.lbl_astTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_astTel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_astTel.Location = New System.Drawing.Point(34, 182)
        Me.lbl_astTel.Name = "lbl_astTel"
        Me.lbl_astTel.Size = New System.Drawing.Size(17, 24)
        Me.lbl_astTel.TabIndex = 15
        Me.lbl_astTel.Text = "*"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(191, 149)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(144, 22)
        Me.txt_email.TabIndex = 6
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(56, 151)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(46, 17)
        Me.lbl_email.TabIndex = 13
        Me.lbl_email.Text = "Email:"
        '
        'lbl_astEmail
        '
        Me.lbl_astEmail.AutoSize = True
        Me.lbl_astEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_astEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_astEmail.Location = New System.Drawing.Point(34, 151)
        Me.lbl_astEmail.Name = "lbl_astEmail"
        Me.lbl_astEmail.Size = New System.Drawing.Size(17, 24)
        Me.lbl_astEmail.TabIndex = 12
        Me.lbl_astEmail.Text = "*"
        '
        'txt_apellido2
        '
        Me.txt_apellido2.Location = New System.Drawing.Point(191, 118)
        Me.txt_apellido2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_apellido2.Name = "txt_apellido2"
        Me.txt_apellido2.Size = New System.Drawing.Size(144, 22)
        Me.txt_apellido2.TabIndex = 5
        '
        'lbl_apellido2
        '
        Me.lbl_apellido2.AutoSize = True
        Me.lbl_apellido2.Location = New System.Drawing.Point(56, 121)
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
        Me.lbl_astApell2.Location = New System.Drawing.Point(34, 121)
        Me.lbl_astApell2.Name = "lbl_astApell2"
        Me.lbl_astApell2.Size = New System.Drawing.Size(17, 24)
        Me.lbl_astApell2.TabIndex = 9
        Me.lbl_astApell2.Text = "*"
        '
        'txt_apellido1
        '
        Me.txt_apellido1.Location = New System.Drawing.Point(191, 89)
        Me.txt_apellido1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_apellido1.Name = "txt_apellido1"
        Me.txt_apellido1.Size = New System.Drawing.Size(144, 22)
        Me.txt_apellido1.TabIndex = 4
        '
        'lbl_apellido1
        '
        Me.lbl_apellido1.AutoSize = True
        Me.lbl_apellido1.Location = New System.Drawing.Point(56, 91)
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
        Me.lbl_astapell1.Location = New System.Drawing.Point(34, 91)
        Me.lbl_astapell1.Name = "lbl_astapell1"
        Me.lbl_astapell1.Size = New System.Drawing.Size(17, 24)
        Me.lbl_astapell1.TabIndex = 6
        Me.lbl_astapell1.Text = "*"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(191, 57)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(144, 22)
        Me.txt_nombre.TabIndex = 3
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(56, 59)
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
        Me.lbl_astnom.Location = New System.Drawing.Point(34, 59)
        Me.lbl_astnom.Name = "lbl_astnom"
        Me.lbl_astnom.Size = New System.Drawing.Size(17, 24)
        Me.lbl_astnom.TabIndex = 3
        Me.lbl_astnom.Text = "*"
        '
        'txt_cedula
        '
        Me.txt_cedula.Location = New System.Drawing.Point(191, 26)
        Me.txt_cedula.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(144, 22)
        Me.txt_cedula.TabIndex = 2
        '
        'lbl_cedula
        '
        Me.lbl_cedula.AutoSize = True
        Me.lbl_cedula.Location = New System.Drawing.Point(56, 29)
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
        Me.lbl_astced.Location = New System.Drawing.Point(34, 26)
        Me.lbl_astced.Name = "lbl_astced"
        Me.lbl_astced.Size = New System.Drawing.Size(17, 24)
        Me.lbl_astced.TabIndex = 0
        Me.lbl_astced.Text = "*"
        '
        'tb_infoSeguridad
        '
        Me.tb_infoSeguridad.Controls.Add(Me.txt_usuario)
        Me.tb_infoSeguridad.Controls.Add(Me.lbl_usuario)
        Me.tb_infoSeguridad.Controls.Add(Me.Label4)
        Me.tb_infoSeguridad.Controls.Add(Me.Panel1)
        Me.tb_infoSeguridad.Controls.Add(Me.cbx_pregunta)
        Me.tb_infoSeguridad.Controls.Add(Me.txt_repitaContrasena)
        Me.tb_infoSeguridad.Controls.Add(Me.Label1)
        Me.tb_infoSeguridad.Controls.Add(Me.lbl_astRepContra)
        Me.tb_infoSeguridad.Controls.Add(Me.txt_contrasena)
        Me.tb_infoSeguridad.Controls.Add(Me.Label3)
        Me.tb_infoSeguridad.Controls.Add(Me.lbl_astContra)
        Me.tb_infoSeguridad.Controls.Add(Me.txt_respuesta)
        Me.tb_infoSeguridad.Controls.Add(Me.Label5)
        Me.tb_infoSeguridad.Controls.Add(Me.lbl_astRes)
        Me.tb_infoSeguridad.Controls.Add(Me.Label7)
        Me.tb_infoSeguridad.Controls.Add(Me.lbl_astPreg)
        Me.tb_infoSeguridad.Controls.Add(Me.lbl_subtitCambio)
        Me.tb_infoSeguridad.Location = New System.Drawing.Point(4, 25)
        Me.tb_infoSeguridad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_infoSeguridad.Name = "tb_infoSeguridad"
        Me.tb_infoSeguridad.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_infoSeguridad.Size = New System.Drawing.Size(1014, 251)
        Me.tb_infoSeguridad.TabIndex = 1
        Me.tb_infoSeguridad.Text = "Seguridad"
        Me.tb_infoSeguridad.UseVisualStyleBackColor = True
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(503, 53)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(196, 22)
        Me.txt_usuario.TabIndex = 10
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(368, 55)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(61, 17)
        Me.lbl_usuario.TabIndex = 26
        Me.lbl_usuario.Text = "Usuario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(346, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 24)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "*"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(321, 38)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 4)
        Me.Panel1.TabIndex = 4
        '
        'cbx_pregunta
        '
        Me.cbx_pregunta.FormattingEnabled = True
        Me.cbx_pregunta.ItemHeight = 16
        Me.cbx_pregunta.Location = New System.Drawing.Point(503, 85)
        Me.cbx_pregunta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_pregunta.Name = "cbx_pregunta"
        Me.cbx_pregunta.Size = New System.Drawing.Size(363, 24)
        Me.cbx_pregunta.TabIndex = 10
        Me.cbx_pregunta.Text = "Seleccionar"
        '
        'txt_repitaContrasena
        '
        Me.txt_repitaContrasena.Location = New System.Drawing.Point(503, 177)
        Me.txt_repitaContrasena.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_repitaContrasena.Name = "txt_repitaContrasena"
        Me.txt_repitaContrasena.Size = New System.Drawing.Size(196, 22)
        Me.txt_repitaContrasena.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(368, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 17)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Repita Contraseña:"
        '
        'lbl_astRepContra
        '
        Me.lbl_astRepContra.AutoSize = True
        Me.lbl_astRepContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_astRepContra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_astRepContra.Location = New System.Drawing.Point(346, 180)
        Me.lbl_astRepContra.Name = "lbl_astRepContra"
        Me.lbl_astRepContra.Size = New System.Drawing.Size(17, 24)
        Me.lbl_astRepContra.TabIndex = 21
        Me.lbl_astRepContra.Text = "*"
        '
        'txt_contrasena
        '
        Me.txt_contrasena.Location = New System.Drawing.Point(503, 148)
        Me.txt_contrasena.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_contrasena.Name = "txt_contrasena"
        Me.txt_contrasena.Size = New System.Drawing.Size(196, 22)
        Me.txt_contrasena.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(368, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Contraseña:"
        '
        'lbl_astContra
        '
        Me.lbl_astContra.AutoSize = True
        Me.lbl_astContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_astContra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_astContra.Location = New System.Drawing.Point(346, 150)
        Me.lbl_astContra.Name = "lbl_astContra"
        Me.lbl_astContra.Size = New System.Drawing.Size(17, 24)
        Me.lbl_astContra.TabIndex = 18
        Me.lbl_astContra.Text = "*"
        '
        'txt_respuesta
        '
        Me.txt_respuesta.Location = New System.Drawing.Point(503, 116)
        Me.txt_respuesta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_respuesta.Name = "txt_respuesta"
        Me.txt_respuesta.Size = New System.Drawing.Size(196, 22)
        Me.txt_respuesta.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(368, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Respuesta:"
        '
        'lbl_astRes
        '
        Me.lbl_astRes.AutoSize = True
        Me.lbl_astRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_astRes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_astRes.Location = New System.Drawing.Point(346, 118)
        Me.lbl_astRes.Name = "lbl_astRes"
        Me.lbl_astRes.Size = New System.Drawing.Size(17, 24)
        Me.lbl_astRes.TabIndex = 15
        Me.lbl_astRes.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(368, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Pregunta:"
        '
        'lbl_astPreg
        '
        Me.lbl_astPreg.AutoSize = True
        Me.lbl_astPreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_astPreg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_astPreg.Location = New System.Drawing.Point(346, 85)
        Me.lbl_astPreg.Name = "lbl_astPreg"
        Me.lbl_astPreg.Size = New System.Drawing.Size(17, 24)
        Me.lbl_astPreg.TabIndex = 12
        Me.lbl_astPreg.Text = "*"
        '
        'lbl_subtitCambio
        '
        Me.lbl_subtitCambio.AutoSize = True
        Me.lbl_subtitCambio.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtitCambio.Location = New System.Drawing.Point(454, 18)
        Me.lbl_subtitCambio.Name = "lbl_subtitCambio"
        Me.lbl_subtitCambio.Size = New System.Drawing.Size(154, 22)
        Me.lbl_subtitCambio.TabIndex = 0
        Me.lbl_subtitCambio.Text = "Cambiar contraseña:"
        '
        'btn_mostrarUsuarios
        '
        Me.btn_mostrarUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btn_mostrarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mostrarUsuarios.FlatAppearance.BorderSize = 0
        Me.btn_mostrarUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_mostrarUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_mostrarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mostrarUsuarios.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mostrarUsuarios.ForeColor = System.Drawing.Color.White
        Me.btn_mostrarUsuarios.Location = New System.Drawing.Point(708, 510)
        Me.btn_mostrarUsuarios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_mostrarUsuarios.Name = "btn_mostrarUsuarios"
        Me.btn_mostrarUsuarios.Size = New System.Drawing.Size(259, 32)
        Me.btn_mostrarUsuarios.TabIndex = 19
        Me.btn_mostrarUsuarios.Text = "MOSTRAR USUARIOS"
        Me.btn_mostrarUsuarios.UseVisualStyleBackColor = False
        '
        'DGV_Usuarios
        '
        Me.DGV_Usuarios.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Usuarios.Location = New System.Drawing.Point(147, 563)
        Me.DGV_Usuarios.Name = "DGV_Usuarios"
        Me.DGV_Usuarios.RowHeadersWidth = 51
        Me.DGV_Usuarios.RowTemplate.Height = 24
        Me.DGV_Usuarios.Size = New System.Drawing.Size(1457, 322)
        Me.DGV_Usuarios.TabIndex = 20
        '
        'ErrorProviderForm3
        '
        Me.ErrorProviderForm3.ContainerControl = Me
        '
        'btn_registrarUsuario
        '
        Me.btn_registrarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btn_registrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_registrarUsuario.FlatAppearance.BorderSize = 0
        Me.btn_registrarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_registrarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_registrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrarUsuario.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrarUsuario.ForeColor = System.Drawing.Color.White
        Me.btn_registrarUsuario.Location = New System.Drawing.Point(683, 439)
        Me.btn_registrarUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_registrarUsuario.Name = "btn_registrarUsuario"
        Me.btn_registrarUsuario.Size = New System.Drawing.Size(179, 32)
        Me.btn_registrarUsuario.TabIndex = 16
        Me.btn_registrarUsuario.Text = "REGISTRAR"
        Me.btn_registrarUsuario.UseVisualStyleBackColor = False
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
        Me.btn_actualizar.Location = New System.Drawing.Point(883, 439)
        Me.btn_actualizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(179, 32)
        Me.btn_actualizar.TabIndex = 17
        Me.btn_actualizar.Text = "ACTUALIZAR"
        Me.btn_actualizar.UseVisualStyleBackColor = False
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
        Me.btn_eliminar.Location = New System.Drawing.Point(1078, 439)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(179, 32)
        Me.btn_eliminar.TabIndex = 18
        Me.btn_eliminar.Text = "ELIMINAR"
        Me.btn_eliminar.UseVisualStyleBackColor = False
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
        Me.btn_limpiar.Location = New System.Drawing.Point(486, 439)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(179, 32)
        Me.btn_limpiar.TabIndex = 15
        Me.btn_limpiar.Text = "LIMPIAR"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'Form3_MantenimientoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1725, 925)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_actualizar)
        Me.Controls.Add(Me.btn_registrarUsuario)
        Me.Controls.Add(Me.btn_mostrarUsuarios)
        Me.Controls.Add(Me.DGV_Usuarios)
        Me.Controls.Add(Me.tb_informacion)
        Me.Controls.Add(Me.pbl_sup2)
        Me.Controls.Add(Me.pbl_barraTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form3_MantenimientoUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pbl_barraTitulo.ResumeLayout(False)
        Me.pbl_barraTitulo.PerformLayout()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_restaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Guardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_ActualizarBarra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tb_informacion.ResumeLayout(False)
        Me.tb_infoPersonal.ResumeLayout(False)
        Me.tb_infoPersonal.PerformLayout()
        Me.tb_infoSeguridad.ResumeLayout(False)
        Me.tb_infoSeguridad.PerformLayout()
        CType(Me.DGV_Usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderForm3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbl_sup2 As FlowLayoutPanel
    Friend WithEvents pbl_barraTitulo As Panel
    Friend WithEvents btn_Back As PictureBox
    Friend WithEvents btn_Guardar As PictureBox
    Friend WithEvents btn_ActualizarBarra As PictureBox
    Friend WithEvents btn_minimizar As PictureBox
    Friend WithEvents btn_restaurar As PictureBox
    Friend WithEvents btn_Maximizar As PictureBox
    Friend WithEvents btn_cerrar As PictureBox
    Friend WithEvents tb_informacion As TabControl
    Friend WithEvents tb_infoPersonal As TabPage
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents lbl_direccion As Label
    Friend WithEvents lbl_astDir As Label
    Friend WithEvents txt_extension As TextBox
    Friend WithEvents lbl_extension As Label
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents lbl_telefono As Label
    Friend WithEvents lbl_astTel As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_astEmail As Label
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
    Friend WithEvents tb_infoSeguridad As TabPage
    Friend WithEvents lbl_tituloBarra As Label
    Friend WithEvents lbl_subtitCambio As Label
    Friend WithEvents cbx_pregunta As ComboBox
    Friend WithEvents txt_repitaContrasena As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_astRepContra As Label
    Friend WithEvents txt_contrasena As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_astContra As Label
    Friend WithEvents txt_respuesta As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_astRes As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_astPreg As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_mostrarUsuarios As Button
    Friend WithEvents DGV_Usuarios As DataGridView
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ErrorProviderForm3 As ErrorProvider
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents btn_registrarUsuario As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_limpiar As Button
End Class
