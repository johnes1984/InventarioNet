<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrupo
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl85 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl86 = New DevExpress.XtraEditors.LabelControl()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDescargarReferencias = New System.Windows.Forms.ToolStripButton()
        Me.btnNuevoResAmbulatoria = New System.Windows.Forms.ToolStripButton()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.DxError = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.ReadOnly = True
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.ReadOnly = True
        Me.RepositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'GroupControl6
        '
        Me.GroupControl6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl6.Controls.Add(Me.txtNombre)
        Me.GroupControl6.Controls.Add(Me.LabelControl85)
        Me.GroupControl6.Controls.Add(Me.txtCodigo)
        Me.GroupControl6.Controls.Add(Me.LabelControl86)
        Me.GroupControl6.Location = New System.Drawing.Point(0, 42)
        Me.GroupControl6.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.GroupControl6.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(740, 96)
        Me.GroupControl6.TabIndex = 40
        Me.GroupControl6.Text = "Datos"
        '
        'LabelControl85
        '
        Me.LabelControl85.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl85.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl85.Location = New System.Drawing.Point(6, 37)
        Me.LabelControl85.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.LabelControl85.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl85.Name = "LabelControl85"
        Me.LabelControl85.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl85.TabIndex = 18
        Me.LabelControl85.Text = "Codigo"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(62, 34)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.MaxLength = 20
        Me.txtCodigo.Size = New System.Drawing.Size(73, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'LabelControl86
        '
        Me.LabelControl86.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl86.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl86.Location = New System.Drawing.Point(6, 64)
        Me.LabelControl86.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.LabelControl86.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl86.Name = "LabelControl86"
        Me.LabelControl86.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl86.TabIndex = 18
        Me.LabelControl86.Text = "Nombre"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator7, Me.btnNuevoResAmbulatoria, Me.btnBuscar, Me.btnGuardar, Me.ToolStripLabel1, Me.ToolStripSeparator9, Me.btnImprimir, Me.ToolStripSeparator10, Me.btnDescargarReferencias})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(748, 39)
        Me.ToolStrip1.TabIndex = 41
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 39)
        '
        'btnBuscar
        '
        Me.btnBuscar.AutoSize = False
        Me.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBuscar.Image = Global.Inventario.My.Resources.Resources.Search_24
        Me.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(36, 36)
        Me.btnBuscar.Text = "Buscar Solicitud"
        '
        'btnGuardar
        '
        Me.btnGuardar.AutoSize = False
        Me.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGuardar.Image = Global.Inventario.My.Resources.Resources.save_24
        Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(36, 36)
        Me.btnGuardar.Text = "Guardar Solicitud"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 36)
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 39)
        '
        'btnImprimir
        '
        Me.btnImprimir.AutoSize = False
        Me.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImprimir.Image = Global.Inventario.My.Resources.Resources.printer_32
        Me.btnImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(36, 36)
        Me.btnImprimir.Text = "Enviar Solicitud al Api"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 39)
        '
        'btnDescargarReferencias
        '
        Me.btnDescargarReferencias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDescargarReferencias.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDescargarReferencias.Name = "btnDescargarReferencias"
        Me.btnDescargarReferencias.Size = New System.Drawing.Size(23, 36)
        Me.btnDescargarReferencias.Text = "Descargar Referencias"
        '
        'btnNuevoResAmbulatoria
        '
        Me.btnNuevoResAmbulatoria.AutoSize = False
        Me.btnNuevoResAmbulatoria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNuevoResAmbulatoria.Image = Global.Inventario.My.Resources.Resources.nuevo_24
        Me.btnNuevoResAmbulatoria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNuevoResAmbulatoria.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevoResAmbulatoria.Name = "btnNuevoResAmbulatoria"
        Me.btnNuevoResAmbulatoria.Size = New System.Drawing.Size(36, 36)
        Me.btnNuevoResAmbulatoria.Text = "Nueva Solicitud"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(62, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.MaxLength = 20
        Me.txtNombre.Size = New System.Drawing.Size(384, 20)
        Me.txtNombre.TabIndex = 19
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 144)
        Me.GroupControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(740, 410)
        Me.GroupControl1.TabIndex = 40
        Me.GroupControl1.Text = "Datos"
        '
        'DxError
        '
        Me.DxError.ContainerControl = Me
        '
        'frmGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 566)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupControl6)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmGrupo"
        Me.Text = "Grupos"
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        Me.GroupControl6.PerformLayout()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl85 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl86 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNuevoResAmbulatoria As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDescargarReferencias As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DxError As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
End Class
