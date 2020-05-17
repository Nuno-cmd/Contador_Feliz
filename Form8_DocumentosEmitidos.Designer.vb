<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form8_DocumentosEmitidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8_DocumentosEmitidos))
        Me.btn_mostrar = New System.Windows.Forms.Button()
        Me.DGV_Documentos = New System.Windows.Forms.DataGridView()
        Me.pnl_barra2 = New System.Windows.Forms.Panel()
        Me.pnl_barra = New System.Windows.Forms.Panel()
        Me.lbl_tituloBarra = New System.Windows.Forms.Label()
        Me.btn_cerrar = New System.Windows.Forms.PictureBox()
        Me.btn_Restaurar = New System.Windows.Forms.PictureBox()
        Me.btn_Minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_Maximizar = New System.Windows.Forms.PictureBox()
        Me.btn_Actualizar = New System.Windows.Forms.PictureBox()
        Me.btn_Back = New System.Windows.Forms.PictureBox()
        Me.tb_clientes = New System.Windows.Forms.TabControl()
        Me.tb_infoPersonal = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.cbx_pais = New System.Windows.Forms.ComboBox()
        Me.cbx_Provincia = New System.Windows.Forms.ComboBox()
        Me.lbl_provincia = New System.Windows.Forms.Label()
        Me.lbl_area = New System.Windows.Forms.Label()
        Me.lbl_tipoCedula = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.lbl_cedula = New System.Windows.Forms.Label()
        CType(Me.DGV_Documentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_barra.SuspendLayout()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Restaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Actualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tb_clientes.SuspendLayout()
        Me.tb_infoPersonal.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btn_mostrar.Location = New System.Drawing.Point(709, 360)
        Me.btn_mostrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_mostrar.Name = "btn_mostrar"
        Me.btn_mostrar.Size = New System.Drawing.Size(259, 32)
        Me.btn_mostrar.TabIndex = 14
        Me.btn_mostrar.Text = "MOSTRAR DOCUMENTOS"
        Me.btn_mostrar.UseVisualStyleBackColor = False
        '
        'DGV_Documentos
        '
        Me.DGV_Documentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_Documentos.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Documentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Documentos.Location = New System.Drawing.Point(148, 413)
        Me.DGV_Documentos.Name = "DGV_Documentos"
        Me.DGV_Documentos.RowHeadersWidth = 51
        Me.DGV_Documentos.RowTemplate.Height = 24
        Me.DGV_Documentos.Size = New System.Drawing.Size(1457, 322)
        Me.DGV_Documentos.TabIndex = 13
        '
        'pnl_barra2
        '
        Me.pnl_barra2.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_barra2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_barra2.Location = New System.Drawing.Point(0, 40)
        Me.pnl_barra2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_barra2.Name = "pnl_barra2"
        Me.pnl_barra2.Size = New System.Drawing.Size(1725, 8)
        Me.pnl_barra2.TabIndex = 12
        '
        'pnl_barra
        '
        Me.pnl_barra.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.pnl_barra.Controls.Add(Me.lbl_tituloBarra)
        Me.pnl_barra.Controls.Add(Me.btn_cerrar)
        Me.pnl_barra.Controls.Add(Me.btn_Restaurar)
        Me.pnl_barra.Controls.Add(Me.btn_Minimizar)
        Me.pnl_barra.Controls.Add(Me.btn_Maximizar)
        Me.pnl_barra.Controls.Add(Me.btn_Actualizar)
        Me.pnl_barra.Controls.Add(Me.btn_Back)
        Me.pnl_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_barra.Location = New System.Drawing.Point(0, 0)
        Me.pnl_barra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_barra.Name = "pnl_barra"
        Me.pnl_barra.Size = New System.Drawing.Size(1725, 40)
        Me.pnl_barra.TabIndex = 11
        '
        'lbl_tituloBarra
        '
        Me.lbl_tituloBarra.AutoSize = True
        Me.lbl_tituloBarra.Font = New System.Drawing.Font("Arial Narrow", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tituloBarra.ForeColor = System.Drawing.Color.White
        Me.lbl_tituloBarra.Location = New System.Drawing.Point(146, 11)
        Me.lbl_tituloBarra.Name = "lbl_tituloBarra"
        Me.lbl_tituloBarra.Size = New System.Drawing.Size(177, 23)
        Me.lbl_tituloBarra.TabIndex = 9
        Me.lbl_tituloBarra.Text = "Documentos Emitidos"
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
        Me.btn_Restaurar.Location = New System.Drawing.Point(1630, 7)
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
        'tb_clientes
        '
        Me.tb_clientes.Controls.Add(Me.tb_infoPersonal)
        Me.tb_clientes.Location = New System.Drawing.Point(244, 128)
        Me.tb_clientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_clientes.Name = "tb_clientes"
        Me.tb_clientes.SelectedIndex = 0
        Me.tb_clientes.Size = New System.Drawing.Size(1254, 188)
        Me.tb_clientes.TabIndex = 10
        '
        'tb_infoPersonal
        '
        Me.tb_infoPersonal.Controls.Add(Me.Label2)
        Me.tb_infoPersonal.Controls.Add(Me.Label1)
        Me.tb_infoPersonal.Controls.Add(Me.TextBox1)
        Me.tb_infoPersonal.Controls.Add(Me.btn_buscar)
        Me.tb_infoPersonal.Controls.Add(Me.cbx_pais)
        Me.tb_infoPersonal.Controls.Add(Me.cbx_Provincia)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_provincia)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_area)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_tipoCedula)
        Me.tb_infoPersonal.Controls.Add(Me.txt_email)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_email)
        Me.tb_infoPersonal.Controls.Add(Me.txt_nombre)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_nombre)
        Me.tb_infoPersonal.Controls.Add(Me.txt_cedula)
        Me.tb_infoPersonal.Controls.Add(Me.lbl_cedula)
        Me.tb_infoPersonal.Location = New System.Drawing.Point(4, 25)
        Me.tb_infoPersonal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_infoPersonal.Name = "tb_infoPersonal"
        Me.tb_infoPersonal.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tb_infoPersonal.Size = New System.Drawing.Size(1246, 159)
        Me.tb_infoPersonal.TabIndex = 0
        Me.tb_infoPersonal.Text = "Documentos Emitidos"
        Me.tb_infoPersonal.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(753, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Opciones"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Cliente:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1011, 44)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(144, 22)
        Me.TextBox1.TabIndex = 41
        '
        'btn_buscar
        '
        Me.btn_buscar.BackgroundImage = Global.Contador_Final.My.Resources.Resources.magnifier_search_1034
        Me.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_buscar.Location = New System.Drawing.Point(756, 82)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(40, 34)
        Me.btn_buscar.TabIndex = 40
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'cbx_pais
        '
        Me.cbx_pais.FormattingEnabled = True
        Me.cbx_pais.Location = New System.Drawing.Point(194, 93)
        Me.cbx_pais.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_pais.Name = "cbx_pais"
        Me.cbx_pais.Size = New System.Drawing.Size(144, 24)
        Me.cbx_pais.TabIndex = 39
        '
        'cbx_Provincia
        '
        Me.cbx_Provincia.Enabled = False
        Me.cbx_Provincia.FormattingEnabled = True
        Me.cbx_Provincia.Location = New System.Drawing.Point(452, 93)
        Me.cbx_Provincia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_Provincia.Name = "cbx_Provincia"
        Me.cbx_Provincia.Size = New System.Drawing.Size(186, 24)
        Me.cbx_Provincia.TabIndex = 35
        '
        'lbl_provincia
        '
        Me.lbl_provincia.AutoSize = True
        Me.lbl_provincia.Location = New System.Drawing.Point(377, 99)
        Me.lbl_provincia.Name = "lbl_provincia"
        Me.lbl_provincia.Size = New System.Drawing.Size(56, 17)
        Me.lbl_provincia.TabIndex = 30
        Me.lbl_provincia.Text = "Estado:"
        '
        'lbl_area
        '
        Me.lbl_area.AutoSize = True
        Me.lbl_area.Location = New System.Drawing.Point(143, 99)
        Me.lbl_area.Name = "lbl_area"
        Me.lbl_area.Size = New System.Drawing.Size(40, 17)
        Me.lbl_area.TabIndex = 27
        Me.lbl_area.Text = "Tipo:"
        '
        'lbl_tipoCedula
        '
        Me.lbl_tipoCedula.AutoSize = True
        Me.lbl_tipoCedula.Location = New System.Drawing.Point(102, 27)
        Me.lbl_tipoCedula.Name = "lbl_tipoCedula"
        Me.lbl_tipoCedula.Size = New System.Drawing.Size(58, 17)
        Me.lbl_tipoCedula.TabIndex = 24
        Me.lbl_tipoCedula.Text = "Nombre"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(194, 41)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(144, 22)
        Me.txt_email.TabIndex = 14
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(956, 46)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(49, 17)
        Me.lbl_email.TabIndex = 13
        Me.lbl_email.Text = "Hasta:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(756, 44)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(144, 22)
        Me.txt_nombre.TabIndex = 5
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(689, 46)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(53, 17)
        Me.lbl_nombre.TabIndex = 4
        Me.lbl_nombre.Text = "Desde:"
        '
        'txt_cedula
        '
        Me.txt_cedula.Location = New System.Drawing.Point(452, 41)
        Me.txt_cedula.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(186, 22)
        Me.txt_cedula.TabIndex = 2
        '
        'lbl_cedula
        '
        Me.lbl_cedula.AutoSize = True
        Me.lbl_cedula.Location = New System.Drawing.Point(380, 43)
        Me.lbl_cedula.Name = "lbl_cedula"
        Me.lbl_cedula.Size = New System.Drawing.Size(56, 17)
        Me.lbl_cedula.TabIndex = 1
        Me.lbl_cedula.Text = "Cédula:"
        '
        'Form8_DocumentosEmitidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1725, 925)
        Me.Controls.Add(Me.btn_mostrar)
        Me.Controls.Add(Me.DGV_Documentos)
        Me.Controls.Add(Me.pnl_barra2)
        Me.Controls.Add(Me.pnl_barra)
        Me.Controls.Add(Me.tb_clientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form8_DocumentosEmitidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form8_DocumentosEmitidos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGV_Documentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_barra.ResumeLayout(False)
        Me.pnl_barra.PerformLayout()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Restaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Actualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tb_clientes.ResumeLayout(False)
        Me.tb_infoPersonal.ResumeLayout(False)
        Me.tb_infoPersonal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_mostrar As Button
    Friend WithEvents DGV_Documentos As DataGridView
    Friend WithEvents pnl_barra2 As Panel
    Friend WithEvents pnl_barra As Panel
    Friend WithEvents lbl_tituloBarra As Label
    Friend WithEvents btn_cerrar As PictureBox
    Friend WithEvents btn_Restaurar As PictureBox
    Friend WithEvents btn_Minimizar As PictureBox
    Friend WithEvents btn_Maximizar As PictureBox
    Friend WithEvents btn_Actualizar As PictureBox
    Friend WithEvents btn_Back As PictureBox
    Friend WithEvents tb_clientes As TabControl
    Friend WithEvents tb_infoPersonal As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents cbx_pais As ComboBox
    Friend WithEvents cbx_Provincia As ComboBox
    Friend WithEvents lbl_provincia As Label
    Friend WithEvents lbl_area As Label
    Friend WithEvents lbl_tipoCedula As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents lbl_cedula As Label
End Class
