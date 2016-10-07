<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnGrupo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSubgrupo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnProducto = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSaldoInicial = New DevExpress.XtraBars.BarButtonItem()
        Me.pageConfiguracion = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.grbConfiguracion = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.grbEntradas = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRecibirTrasladoSucursal = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRecibirtrasladofabrica = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPagarTrasladosucursal = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPagarTrasladoFabrica = New DevExpress.XtraBars.BarButtonItem()
        Me.grbSalidas = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.btnMuetras = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBajas = New DevExpress.XtraBars.BarButtonItem()
        Me.pagGastos = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.grbGastos = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.btnComprarInsumos = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.ExpandCollapseItem.Name = ""
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnGrupo, Me.btnSubgrupo, Me.btnProducto, Me.btnSaldoInicial, Me.BarButtonItem3, Me.BarButtonItem4, Me.btnRecibirTrasladoSucursal, Me.BarButtonItem6, Me.BarButtonItem7, Me.btnRecibirtrasladofabrica, Me.btnPagarTrasladosucursal, Me.btnPagarTrasladoFabrica, Me.btnMuetras, Me.btnBajas, Me.btnComprarInsumos, Me.BarButtonItem1})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 22
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.pageConfiguracion, Me.RibbonPage2, Me.RibbonPage3, Me.pagGastos})
        Me.RibbonControl.Size = New System.Drawing.Size(952, 147)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnGrupo
        '
        Me.btnGrupo.Caption = "Grupo"
        Me.btnGrupo.Id = 4
        Me.btnGrupo.LargeWidth = 75
        Me.btnGrupo.Name = "btnGrupo"
        Me.btnGrupo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnSubgrupo
        '
        Me.btnSubgrupo.Caption = "Subgrupo"
        Me.btnSubgrupo.Id = 5
        Me.btnSubgrupo.Name = "btnSubgrupo"
        '
        'btnProducto
        '
        Me.btnProducto.Caption = "Producto"
        Me.btnProducto.Id = 6
        Me.btnProducto.Name = "btnProducto"
        '
        'btnSaldoInicial
        '
        Me.btnSaldoInicial.Caption = "Saldo Inicial"
        Me.btnSaldoInicial.Id = 7
        Me.btnSaldoInicial.Name = "btnSaldoInicial"
        Me.btnSaldoInicial.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'pageConfiguracion
        '
        Me.pageConfiguracion.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.grbConfiguracion})
        Me.pageConfiguracion.Name = "pageConfiguracion"
        Me.pageConfiguracion.Text = "Configuracion"
        '
        'grbConfiguracion
        '
        Me.grbConfiguracion.ItemLinks.Add(Me.btnGrupo)
        Me.grbConfiguracion.ItemLinks.Add(Me.btnSubgrupo)
        Me.grbConfiguracion.ItemLinks.Add(Me.btnProducto)
        Me.grbConfiguracion.Name = "grbConfiguracion"
        Me.grbConfiguracion.Text = "Configuracion"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.grbEntradas})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Entradas"
        '
        'grbEntradas
        '
        Me.grbEntradas.ItemLinks.Add(Me.btnSaldoInicial)
        Me.grbEntradas.ItemLinks.Add(Me.btnRecibirTrasladoSucursal)
        Me.grbEntradas.ItemLinks.Add(Me.btnRecibirtrasladofabrica)
        Me.grbEntradas.ItemLinks.Add(Me.BarButtonItem6)
        Me.grbEntradas.Name = "grbEntradas"
        Me.grbEntradas.Text = "Entradas"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.grbSalidas})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Salidas"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 426)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(952, 23)
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Blue"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Facturacion"
        Me.BarButtonItem3.Id = 8
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Remision"
        Me.BarButtonItem4.Id = 9
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'btnRecibirTrasladoSucursal
        '
        Me.btnRecibirTrasladoSucursal.Caption = "Recibir Traslado Sucursal"
        Me.btnRecibirTrasladoSucursal.Id = 10
        Me.btnRecibirTrasladoSucursal.Name = "btnRecibirTrasladoSucursal"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Ajuste por Entrada"
        Me.BarButtonItem6.Id = 11
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Prestamos"
        Me.BarButtonItem7.Id = 12
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'btnRecibirtrasladofabrica
        '
        Me.btnRecibirtrasladofabrica.Caption = "Recibir Traslado de Fabrica"
        Me.btnRecibirtrasladofabrica.Id = 13
        Me.btnRecibirtrasladofabrica.Name = "btnRecibirtrasladofabrica"
        '
        'btnPagarTrasladosucursal
        '
        Me.btnPagarTrasladosucursal.Caption = "Pagar Traslado Sucursal"
        Me.btnPagarTrasladosucursal.Id = 14
        Me.btnPagarTrasladosucursal.Name = "btnPagarTrasladosucursal"
        '
        'btnPagarTrasladoFabrica
        '
        Me.btnPagarTrasladoFabrica.Caption = "Pagar Traslado Fabrica"
        Me.btnPagarTrasladoFabrica.Id = 15
        Me.btnPagarTrasladoFabrica.Name = "btnPagarTrasladoFabrica"
        '
        'grbSalidas
        '
        Me.grbSalidas.ItemLinks.Add(Me.BarButtonItem4)
        Me.grbSalidas.ItemLinks.Add(Me.BarButtonItem3)
        Me.grbSalidas.ItemLinks.Add(Me.BarButtonItem7)
        Me.grbSalidas.ItemLinks.Add(Me.btnMuetras)
        Me.grbSalidas.ItemLinks.Add(Me.btnBajas)
        Me.grbSalidas.Name = "grbSalidas"
        Me.grbSalidas.Text = "Salidas"
        '
        'btnMuetras
        '
        Me.btnMuetras.Caption = "Muestras"
        Me.btnMuetras.Id = 17
        Me.btnMuetras.Name = "btnMuetras"
        '
        'btnBajas
        '
        Me.btnBajas.Caption = "Bajas de Productos"
        Me.btnBajas.Id = 18
        Me.btnBajas.Name = "btnBajas"
        '
        'pagGastos
        '
        Me.pagGastos.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.grbGastos})
        Me.pagGastos.Name = "pagGastos"
        Me.pagGastos.Text = "Gastos"
        '
        'grbGastos
        '
        Me.grbGastos.ItemLinks.Add(Me.btnPagarTrasladoFabrica)
        Me.grbGastos.ItemLinks.Add(Me.btnPagarTrasladosucursal)
        Me.grbGastos.ItemLinks.Add(Me.btnComprarInsumos)
        Me.grbGastos.Name = "grbGastos"
        Me.grbGastos.Text = "Gastos"
        '
        'btnComprarInsumos
        '
        Me.btnComprarInsumos.Caption = "Comprar Insumos"
        Me.btnComprarInsumos.Id = 19
        Me.btnComprarInsumos.Name = "btnComprarInsumos"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 21
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'frmPrincipal
        '
        Me.AllowMdiBar = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 449)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.IsMdiContainer = True
        Me.Name = "frmPrincipal"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Inventario"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents pageConfiguracion As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnGrupo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSubgrupo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnProducto As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grbConfiguracion As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents btnSaldoInicial As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grbEntradas As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRecibirTrasladoSucursal As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRecibirtrasladofabrica As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPagarTrasladosucursal As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPagarTrasladoFabrica As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMuetras As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBajas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grbSalidas As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents pagGastos As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents grbGastos As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnComprarInsumos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem


End Class
