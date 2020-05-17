<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1_Login))
        Me.pnl_izquierdo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pcbx_logout = New System.Windows.Forms.PictureBox()
        Me.pnl_logo = New System.Windows.Forms.Panel()
        Me.btn_ingresar = New System.Windows.Forms.Button()
        Me.gbx_iniciarSesion = New System.Windows.Forms.GroupBox()
        Me.btn_olvido = New System.Windows.Forms.Button()
        Me.pnl_pictLlave = New System.Windows.Forms.Panel()
        Me.lbl_contrasena = New System.Windows.Forms.Label()
        Me.txt_contrasena = New System.Windows.Forms.TextBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.ErrorProviderLogin = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnl_izquierdo.SuspendLayout()
        CType(Me.pcbx_logout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_iniciarSesion.SuspendLayout()
        CType(Me.ErrorProviderLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_izquierdo
        '
        Me.pnl_izquierdo.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_izquierdo.Controls.Add(Me.Label1)
        Me.pnl_izquierdo.Controls.Add(Me.pcbx_logout)
        Me.pnl_izquierdo.Controls.Add(Me.pnl_logo)
        Me.pnl_izquierdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_izquierdo.Location = New System.Drawing.Point(0, 0)
        Me.pnl_izquierdo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_izquierdo.Name = "pnl_izquierdo"
        Me.pnl_izquierdo.Size = New System.Drawing.Size(222, 347)
        Me.pnl_izquierdo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 321)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Salir"
        '
        'pcbx_logout
        '
        Me.pcbx_logout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbx_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbx_logout.Image = Global.Contador_Final.My.Resources.Resources.off_logout_17916_48
        Me.pcbx_logout.Location = New System.Drawing.Point(11, 272)
        Me.pcbx_logout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcbx_logout.Name = "pcbx_logout"
        Me.pcbx_logout.Size = New System.Drawing.Size(53, 47)
        Me.pcbx_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbx_logout.TabIndex = 17
        Me.pcbx_logout.TabStop = False
        '
        'pnl_logo
        '
        Me.pnl_logo.BackgroundImage = Global.Contador_Final.My.Resources.Resources.ContadorFelizVerde
        Me.pnl_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnl_logo.Location = New System.Drawing.Point(11, 98)
        Me.pnl_logo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_logo.Name = "pnl_logo"
        Me.pnl_logo.Size = New System.Drawing.Size(196, 118)
        Me.pnl_logo.TabIndex = 0
        '
        'btn_ingresar
        '
        Me.btn_ingresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btn_ingresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ingresar.FlatAppearance.BorderSize = 0
        Me.btn_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ingresar.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ingresar.ForeColor = System.Drawing.Color.White
        Me.btn_ingresar.Location = New System.Drawing.Point(107, 187)
        Me.btn_ingresar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(259, 32)
        Me.btn_ingresar.TabIndex = 3
        Me.btn_ingresar.Text = "INGRESAR"
        Me.btn_ingresar.UseVisualStyleBackColor = False
        '
        'gbx_iniciarSesion
        '
        Me.gbx_iniciarSesion.Controls.Add(Me.btn_olvido)
        Me.gbx_iniciarSesion.Controls.Add(Me.pnl_pictLlave)
        Me.gbx_iniciarSesion.Controls.Add(Me.lbl_contrasena)
        Me.gbx_iniciarSesion.Controls.Add(Me.txt_contrasena)
        Me.gbx_iniciarSesion.Controls.Add(Me.lbl_usuario)
        Me.gbx_iniciarSesion.Controls.Add(Me.txt_usuario)
        Me.gbx_iniciarSesion.Controls.Add(Me.btn_ingresar)
        Me.gbx_iniciarSesion.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_iniciarSesion.ForeColor = System.Drawing.Color.White
        Me.gbx_iniciarSesion.Location = New System.Drawing.Point(260, 21)
        Me.gbx_iniciarSesion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbx_iniciarSesion.Name = "gbx_iniciarSesion"
        Me.gbx_iniciarSesion.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbx_iniciarSesion.Size = New System.Drawing.Size(414, 302)
        Me.gbx_iniciarSesion.TabIndex = 6
        Me.gbx_iniciarSesion.TabStop = False
        Me.gbx_iniciarSesion.Text = "INICIAR SESION"
        '
        'btn_olvido
        '
        Me.btn_olvido.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btn_olvido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_olvido.FlatAppearance.BorderSize = 0
        Me.btn_olvido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_olvido.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_olvido.Location = New System.Drawing.Point(135, 240)
        Me.btn_olvido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_olvido.Name = "btn_olvido"
        Me.btn_olvido.Size = New System.Drawing.Size(230, 32)
        Me.btn_olvido.TabIndex = 4
        Me.btn_olvido.Text = "¿ Olvidó la contraseña ?"
        Me.btn_olvido.UseVisualStyleBackColor = False
        '
        'pnl_pictLlave
        '
        Me.pnl_pictLlave.BackgroundImage = Global.Contador_Final.My.Resources.Resources.password_key_9431
        Me.pnl_pictLlave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnl_pictLlave.Location = New System.Drawing.Point(107, 242)
        Me.pnl_pictLlave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_pictLlave.Name = "pnl_pictLlave"
        Me.pnl_pictLlave.Size = New System.Drawing.Size(28, 32)
        Me.pnl_pictLlave.TabIndex = 12
        '
        'lbl_contrasena
        '
        Me.lbl_contrasena.AutoSize = True
        Me.lbl_contrasena.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contrasena.Location = New System.Drawing.Point(53, 126)
        Me.lbl_contrasena.Name = "lbl_contrasena"
        Me.lbl_contrasena.Size = New System.Drawing.Size(114, 21)
        Me.lbl_contrasena.TabIndex = 11
        Me.lbl_contrasena.Text = "Contraseña:"
        '
        'txt_contrasena
        '
        Me.txt_contrasena.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.txt_contrasena.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_contrasena.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contrasena.ForeColor = System.Drawing.Color.White
        Me.txt_contrasena.Location = New System.Drawing.Point(179, 124)
        Me.txt_contrasena.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_contrasena.Name = "txt_contrasena"
        Me.txt_contrasena.Size = New System.Drawing.Size(187, 28)
        Me.txt_contrasena.TabIndex = 2
        Me.txt_contrasena.UseSystemPasswordChar = True
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.Location = New System.Drawing.Point(53, 67)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(75, 21)
        Me.lbl_usuario.TabIndex = 9
        Me.lbl_usuario.Text = "Usuario:"
        '
        'txt_usuario
        '
        Me.txt_usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.txt_usuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_usuario.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.ForeColor = System.Drawing.Color.White
        Me.txt_usuario.Location = New System.Drawing.Point(179, 66)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(187, 28)
        Me.txt_usuario.TabIndex = 1
        '
        'ErrorProviderLogin
        '
        Me.ErrorProviderLogin.ContainerControl = Me
        '
        'Form1_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(702, 347)
        Me.Controls.Add(Me.gbx_iniciarSesion)
        Me.Controls.Add(Me.pnl_izquierdo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximumSize = New System.Drawing.Size(702, 347)
        Me.MinimumSize = New System.Drawing.Size(702, 347)
        Me.Name = "Form1_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.pnl_izquierdo.ResumeLayout(False)
        Me.pnl_izquierdo.PerformLayout()
        CType(Me.pcbx_logout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_iniciarSesion.ResumeLayout(False)
        Me.gbx_iniciarSesion.PerformLayout()
        CType(Me.ErrorProviderLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_izquierdo As Panel
    Friend WithEvents btn_ingresar As Button
    Friend WithEvents gbx_iniciarSesion As GroupBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents lbl_contrasena As Label
    Friend WithEvents txt_contrasena As TextBox
    Friend WithEvents pnl_logo As Panel
    Friend WithEvents pnl_pictLlave As Panel
    Friend WithEvents btn_olvido As Button
    Friend WithEvents ErrorProviderLogin As ErrorProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents pcbx_logout As PictureBox
End Class
