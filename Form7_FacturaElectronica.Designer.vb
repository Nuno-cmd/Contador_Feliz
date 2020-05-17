<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7_FacturaElectronica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7_FacturaElectronica))
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
        Me.pnl_barra.SuspendLayout()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Restaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Guardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Actualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Back, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnl_barra2.TabIndex = 8
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
        Me.pnl_barra.Size = New System.Drawing.Size(1725, 40)
        Me.pnl_barra.TabIndex = 7
        '
        'lbl_tituloBarra
        '
        Me.lbl_tituloBarra.AutoSize = True
        Me.lbl_tituloBarra.Font = New System.Drawing.Font("Arial Narrow", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tituloBarra.ForeColor = System.Drawing.Color.White
        Me.lbl_tituloBarra.Location = New System.Drawing.Point(141, 11)
        Me.lbl_tituloBarra.Name = "lbl_tituloBarra"
        Me.lbl_tituloBarra.Size = New System.Drawing.Size(157, 23)
        Me.lbl_tituloBarra.TabIndex = 11
        Me.lbl_tituloBarra.Text = "Factura Electrónica"
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
        'Form7_FacturaElectronica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1725, 925)
        Me.Controls.Add(Me.pnl_barra2)
        Me.Controls.Add(Me.pnl_barra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form7_FacturaElectronica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_barra2 As Panel
    Friend WithEvents pnl_barra As Panel
    Friend WithEvents btn_cerrar As PictureBox
    Friend WithEvents btn_Restaurar As PictureBox
    Friend WithEvents btn_Minimizar As PictureBox
    Friend WithEvents btn_Maximizar As PictureBox
    Friend WithEvents btn_Guardar As PictureBox
    Friend WithEvents btn_Actualizar As PictureBox
    Friend WithEvents btn_Back As PictureBox
    Friend WithEvents lbl_tituloBarra As Label
End Class
