<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1_RecContrasena
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1_RecContrasena))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Pregunta = New System.Windows.Forms.TextBox()
        Me.btn_verificaRespuesta = New System.Windows.Forms.Button()
        Me.txt_respuesta = New System.Windows.Forms.TextBox()
        Me.lbl_respuesta = New System.Windows.Forms.Label()
        Me.pnl_barraTitulo = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pcbx_logout = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.btn_solicitaPregunta = New System.Windows.Forms.Button()
        Me.pnl_barraTitulo.SuspendLayout()
        CType(Me.pcbx_logout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(65, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Responde tu pregunta de seguridad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(65, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "para restablecer contraseña"
        '
        'txt_Pregunta
        '
        Me.txt_Pregunta.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Pregunta.Enabled = False
        Me.txt_Pregunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Pregunta.Location = New System.Drawing.Point(38, 308)
        Me.txt_Pregunta.Multiline = True
        Me.txt_Pregunta.Name = "txt_Pregunta"
        Me.txt_Pregunta.Size = New System.Drawing.Size(334, 36)
        Me.txt_Pregunta.TabIndex = 3
        Me.txt_Pregunta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_verificaRespuesta
        '
        Me.btn_verificaRespuesta.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btn_verificaRespuesta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_verificaRespuesta.Enabled = False
        Me.btn_verificaRespuesta.FlatAppearance.BorderSize = 0
        Me.btn_verificaRespuesta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_verificaRespuesta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_verificaRespuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_verificaRespuesta.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_verificaRespuesta.ForeColor = System.Drawing.Color.White
        Me.btn_verificaRespuesta.Location = New System.Drawing.Point(69, 467)
        Me.btn_verificaRespuesta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_verificaRespuesta.Name = "btn_verificaRespuesta"
        Me.btn_verificaRespuesta.Size = New System.Drawing.Size(259, 35)
        Me.btn_verificaRespuesta.TabIndex = 5
        Me.btn_verificaRespuesta.Text = "VERIFICAR RESPUESTA"
        Me.btn_verificaRespuesta.UseVisualStyleBackColor = False
        '
        'txt_respuesta
        '
        Me.txt_respuesta.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.txt_respuesta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_respuesta.Enabled = False
        Me.txt_respuesta.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_respuesta.ForeColor = System.Drawing.Color.White
        Me.txt_respuesta.Location = New System.Drawing.Point(69, 416)
        Me.txt_respuesta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_respuesta.Name = "txt_respuesta"
        Me.txt_respuesta.Size = New System.Drawing.Size(259, 28)
        Me.txt_respuesta.TabIndex = 4
        Me.txt_respuesta.UseSystemPasswordChar = True
        '
        'lbl_respuesta
        '
        Me.lbl_respuesta.AutoSize = True
        Me.lbl_respuesta.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_respuesta.Location = New System.Drawing.Point(65, 380)
        Me.lbl_respuesta.Name = "lbl_respuesta"
        Me.lbl_respuesta.Size = New System.Drawing.Size(102, 21)
        Me.lbl_respuesta.TabIndex = 12
        Me.lbl_respuesta.Text = "Respuesta:"
        '
        'pnl_barraTitulo
        '
        Me.pnl_barraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_barraTitulo.Controls.Add(Me.Label3)
        Me.pnl_barraTitulo.Controls.Add(Me.pcbx_logout)
        Me.pnl_barraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_barraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnl_barraTitulo.Name = "pnl_barraTitulo"
        Me.pnl_barraTitulo.Size = New System.Drawing.Size(411, 61)
        Me.pnl_barraTitulo.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(111, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Olvidé mi Contraseña"
        '
        'pcbx_logout
        '
        Me.pcbx_logout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbx_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbx_logout.Image = Global.Contador_Final.My.Resources.Resources.off_logout_17916_48
        Me.pcbx_logout.Location = New System.Drawing.Point(12, 9)
        Me.pcbx_logout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcbx_logout.Name = "pcbx_logout"
        Me.pcbx_logout.Size = New System.Drawing.Size(39, 39)
        Me.pcbx_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbx_logout.TabIndex = 19
        Me.pcbx_logout.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(65, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 21)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Ingresar usuario:"
        '
        'txt_usuario
        '
        Me.txt_usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.txt_usuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_usuario.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.ForeColor = System.Drawing.Color.White
        Me.txt_usuario.Location = New System.Drawing.Point(69, 132)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(236, 28)
        Me.txt_usuario.TabIndex = 1
        '
        'btn_solicitaPregunta
        '
        Me.btn_solicitaPregunta.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.btn_solicitaPregunta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_solicitaPregunta.FlatAppearance.BorderSize = 0
        Me.btn_solicitaPregunta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_solicitaPregunta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_solicitaPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_solicitaPregunta.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_solicitaPregunta.ForeColor = System.Drawing.Color.White
        Me.btn_solicitaPregunta.Location = New System.Drawing.Point(69, 244)
        Me.btn_solicitaPregunta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_solicitaPregunta.Name = "btn_solicitaPregunta"
        Me.btn_solicitaPregunta.Size = New System.Drawing.Size(259, 32)
        Me.btn_solicitaPregunta.TabIndex = 2
        Me.btn_solicitaPregunta.Text = "SOLICITAR PREGUNTA"
        Me.btn_solicitaPregunta.UseVisualStyleBackColor = False
        '
        'Form1_RecContrasena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(411, 587)
        Me.Controls.Add(Me.btn_solicitaPregunta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.pnl_barraTitulo)
        Me.Controls.Add(Me.lbl_respuesta)
        Me.Controls.Add(Me.txt_respuesta)
        Me.Controls.Add(Me.btn_verificaRespuesta)
        Me.Controls.Add(Me.txt_Pregunta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(411, 587)
        Me.MinimumSize = New System.Drawing.Size(411, 587)
        Me.Name = "Form1_RecContrasena"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnl_barraTitulo.ResumeLayout(False)
        Me.pnl_barraTitulo.PerformLayout()
        CType(Me.pcbx_logout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Pregunta As TextBox
    Friend WithEvents btn_verificaRespuesta As Button
    Friend WithEvents txt_respuesta As TextBox
    Friend WithEvents lbl_respuesta As Label
    Friend WithEvents pnl_barraTitulo As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents btn_solicitaPregunta As Button
    Friend WithEvents pcbx_logout As PictureBox
End Class
