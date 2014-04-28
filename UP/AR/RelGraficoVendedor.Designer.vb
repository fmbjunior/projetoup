<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RelGraficoVendedor 
    Inherits DataDynamics.ActiveReports.ActiveReport

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub
    
    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
    Private WithEvents PageHeader1 As DataDynamics.ActiveReports.PageHeader
    Private WithEvents Detail1 As DataDynamics.ActiveReports.Detail
    Private WithEvents PageFooter1 As DataDynamics.ActiveReports.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As DataDynamics.ActiveReports.Chart.ChartArea = New DataDynamics.ActiveReports.Chart.ChartArea
        Dim Axis1 As DataDynamics.ActiveReports.Chart.Axis = New DataDynamics.ActiveReports.Chart.Axis
        Dim Axis2 As DataDynamics.ActiveReports.Chart.Axis = New DataDynamics.ActiveReports.Chart.Axis
        Dim Axis3 As DataDynamics.ActiveReports.Chart.Axis = New DataDynamics.ActiveReports.Chart.Axis
        Dim Axis4 As DataDynamics.ActiveReports.Chart.Axis = New DataDynamics.ActiveReports.Chart.Axis
        Dim Axis5 As DataDynamics.ActiveReports.Chart.Axis = New DataDynamics.ActiveReports.Chart.Axis
        Dim WallRange1 As DataDynamics.ActiveReports.Chart.WallRange = New DataDynamics.ActiveReports.Chart.WallRange
        Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelGraficoVendedor))
        Dim Legend1 As DataDynamics.ActiveReports.Chart.Legend = New DataDynamics.ActiveReports.Chart.Legend
        Dim Title1 As DataDynamics.ActiveReports.Chart.Title = New DataDynamics.ActiveReports.Chart.Title
        Dim Title2 As DataDynamics.ActiveReports.Chart.Title = New DataDynamics.ActiveReports.Chart.Title
        Dim Series1 As DataDynamics.ActiveReports.Chart.Series = New DataDynamics.ActiveReports.Chart.Series
        Dim OleDBDataSource2 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.lblEmpresa = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.lblPeriodo = New DataDynamics.ActiveReports.Label
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtNome1 = New DataDynamics.ActiveReports.TextBox
        Me.txtSomaDeTotalPedido1 = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo
        Me.Label12 = New DataDynamics.ActiveReports.Label
        Me.Chart = New DataDynamics.ActiveReports.ChartControl
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Line1 = New DataDynamics.ActiveReports.Line
        CType(Me.lblEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNome1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSomaDeTotalPedido1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblEmpresa, Me.Label4, Me.lblPeriodo, Me.Line3})
        Me.PageHeader1.Height = 1.041667!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.Height = 0.2291667!
        Me.lblEmpresa.HyperLink = Nothing
        Me.lblEmpresa.Left = 0.0625!
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Style = "font-family: Tahoma; font-size: 12pt; font-weight: bold"
        Me.lblEmpresa.Text = "Empresa"
        Me.lblEmpresa.Top = 0.0625!
        Me.lblEmpresa.Width = 5.083333!
        '
        'Label4
        '
        Me.Label4.Height = 0.2291667!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.0625!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: Tahoma; font-size: 11pt; font-weight: bold"
        Me.Label4.Text = "Reltório de Vendas por vendedores [SINTÉTICO]"
        Me.Label4.Top = 0.5833333!
        Me.Label4.Width = 3.927083!
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Height = 0.2291667!
        Me.lblPeriodo.HyperLink = Nothing
        Me.lblPeriodo.Left = 4.166667!
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Style = "font-family: Tahoma; font-size: 8pt; font-weight: normal; text-align: right"
        Me.lblPeriodo.Text = "período"
        Me.lblPeriodo.Top = 0.5833333!
        Me.lblPeriodo.Width = 3.145833!
        '
        'Line3
        '
        Me.Line3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Line3.Height = 0.0!
        Me.Line3.Left = 0.02083333!
        Me.Line3.LineWeight = 3.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.9583333!
        Me.Line3.Width = 7.299705!
        Me.Line3.X1 = 0.02083333!
        Me.Line3.X2 = 7.320538!
        Me.Line3.Y1 = 0.9583333!
        Me.Line3.Y2 = 0.9583333!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNome1, Me.txtSomaDeTotalPedido1})
        Me.Detail1.Height = 0.25!
        Me.Detail1.Name = "Detail1"
        '
        'txtNome1
        '
        Me.txtNome1.DataField = "Nome"
        Me.txtNome1.Height = 0.2!
        Me.txtNome1.Left = 0.03125!
        Me.txtNome1.Name = "txtNome1"
        Me.txtNome1.Style = "font-family: Tahoma; font-size: 11pt; font-weight: bold"
        Me.txtNome1.Text = "txtNome1"
        Me.txtNome1.Top = 0.0!
        Me.txtNome1.Width = 4.6875!
        '
        'txtSomaDeTotalPedido1
        '
        Me.txtSomaDeTotalPedido1.DataField = "SomaDeTotalPedido"
        Me.txtSomaDeTotalPedido1.Height = 0.2!
        Me.txtSomaDeTotalPedido1.Left = 5.010417!
        Me.txtSomaDeTotalPedido1.Name = "txtSomaDeTotalPedido1"
        Me.txtSomaDeTotalPedido1.OutputFormat = resources.GetString("txtSomaDeTotalPedido1.OutputFormat")
        Me.txtSomaDeTotalPedido1.Style = "font-family: Tahoma; font-size: 11pt; font-weight: bold; text-align: right"
        Me.txtSomaDeTotalPedido1.Text = "txtSomaDeTotalPedido1"
        Me.txtSomaDeTotalPedido1.Top = 0.0!
        Me.txtSomaDeTotalPedido1.Width = 1.739583!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.ReportInfo1, Me.Label12})
        Me.PageFooter1.Height = 0.2291667!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'ReportInfo1
        '
        Me.ReportInfo1.FormatString = "Pag.: {PageNumber} de {PageCount} : {RunDateTime}"
        Me.ReportInfo1.Height = 0.1902067!
        Me.ReportInfo1.Left = 4.072917!
        Me.ReportInfo1.Name = "ReportInfo1"
        Me.ReportInfo1.Style = "color: Black; font-family: Tahoma; font-size: 8pt; font-weight: bold; text-align:" & _
            " right; ddo-char-set: 1"
        Me.ReportInfo1.Top = 0.0!
        Me.ReportInfo1.Width = 3.207596!
        '
        'Label12
        '
        Me.Label12.Height = 0.1230315!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 0.0!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-size: 6pt"
        Me.Label12.Text = "Sistemas Up"
        Me.Label12.Top = 0.0!
        Me.Label12.Width = 1.008858!
        '
        'Chart
        '
        Me.Chart.AutoRefresh = True
        Me.Chart.Backdrop = New DataDynamics.ActiveReports.Chart.BackdropItem(DataDynamics.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.SteelBlue, DataDynamics.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, Nothing, DataDynamics.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched)
        ChartArea1.AntiAliasMode = DataDynamics.ActiveReports.Chart.Graphics.AntiAliasMode.Graphics
        Axis1.Arrow = DataDynamics.ActiveReports.Chart.ArrowType.Triangle
        Axis1.AxisType = DataDynamics.ActiveReports.Chart.AxisType.Categorical
        Axis1.LabelFont = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
        Axis1.MajorTick = New DataDynamics.ActiveReports.Chart.Tick(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, 0.0!, False)
        Axis1.MinorTick = New DataDynamics.ActiveReports.Chart.Tick(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, 0.0!, False)
        Axis1.Title = "Axis X"
        Axis1.TitleFont = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
        Axis2.LabelFont = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
        Axis2.LabelsGap = 0
        Axis2.LabelsVisible = False
        Axis2.Line = New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None)
        Axis2.MajorTick = New DataDynamics.ActiveReports.Chart.Tick(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, 0.0!, False)
        Axis2.MinorTick = New DataDynamics.ActiveReports.Chart.Tick(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, 0.0!, False)
        Axis2.Position = 0
        Axis2.TickOffset = 0
        Axis2.TitleFont = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
        Axis2.Visible = False
        Axis3.LabelFont = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
        Axis3.LabelsGap = 0
        Axis3.LabelsVisible = False
        Axis3.MajorTick = New DataDynamics.ActiveReports.Chart.Tick(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, 0.0!, False)
        Axis3.MinorTick = New DataDynamics.ActiveReports.Chart.Tick(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, 0.0!, False)
        Axis3.Position = 0
        Axis3.Title = "Axis Y"
        Axis3.TitleFont = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), -90.0!)
        Axis4.LabelFont = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
        Axis4.LabelsVisible = False
        Axis4.Line = New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None)
        Axis4.MajorTick = New DataDynamics.ActiveReports.Chart.Tick(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, 0.0!, False)
        Axis4.MinorTick = New DataDynamics.ActiveReports.Chart.Tick(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, 0.0!, False)
        Axis4.TitleFont = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
        Axis4.Visible = False
        Axis5.LabelFont = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
        Axis5.LabelsGap = 0
        Axis5.LabelsVisible = False
        Axis5.Line = New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None)
        Axis5.MajorTick = New DataDynamics.ActiveReports.Chart.Tick(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, 0.0!, False)
        Axis5.MinorTick = New DataDynamics.ActiveReports.Chart.Tick(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, 0.0!, False)
        Axis5.Position = 0
        Axis5.TickOffset = 0
        Axis5.TitleFont = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
        Axis5.Visible = False
        ChartArea1.Axes.AddRange(New DataDynamics.ActiveReports.Chart.AxisBase() {Axis1, Axis2, Axis3, Axis4, Axis5})
        ChartArea1.Backdrop = New DataDynamics.ActiveReports.Chart.BackdropItem(DataDynamics.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, DataDynamics.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, Nothing, DataDynamics.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched)
        ChartArea1.Border = New DataDynamics.ActiveReports.Chart.Border(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black)
        ChartArea1.Light = New DataDynamics.ActiveReports.Chart.Light(New DataDynamics.ActiveReports.Chart.Graphics.Point3d(10.0!, 40.0!, 20.0!), DataDynamics.ActiveReports.Chart.LightType.InfiniteDirectional, 0.3!)
        ChartArea1.Name = "defaultArea"
        ChartArea1.Projection = New DataDynamics.ActiveReports.Chart.Projection(DataDynamics.ActiveReports.Chart.Graphics.ProjectionType.Orthogonal, 0.1!, 0.1!, 0.0!, 37.0!)
        WallRange1.Backdrop = New DataDynamics.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.LightGray)
        WallRange1.Border = New DataDynamics.ActiveReports.Chart.Border(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Black, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None))
        WallRange1.Name = "range1"
        WallRange1.PrimaryAxis = Axis1
        ChartArea1.WallRanges.AddRange(New DataDynamics.ActiveReports.Chart.WallRange() {WallRange1})
        ChartArea1.WallXY = New DataDynamics.ActiveReports.Chart.PlaneItem(New DataDynamics.ActiveReports.Chart.Graphics.Backdrop, False, 0.0!)
        ChartArea1.WallXZ = New DataDynamics.ActiveReports.Chart.PlaneItem(New DataDynamics.ActiveReports.Chart.Graphics.Backdrop, False, 0.0!)
        ChartArea1.WallYZ = New DataDynamics.ActiveReports.Chart.PlaneItem(New DataDynamics.ActiveReports.Chart.Graphics.Backdrop, False, 0.0!)
        Me.Chart.ChartAreas.AddRange(New DataDynamics.ActiveReports.Chart.ChartArea() {ChartArea1})
        Me.Chart.ChartBorder = New DataDynamics.ActiveReports.Chart.Border(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black)
        OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Z:\CD\upDados.mdb;Persist Security I" & _
            "nfo=False;Jet OLEDB:Database Password=abc"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.Chart.DataSource = OleDBDataSource1
        Me.Chart.Height = 5.302083!
        Me.Chart.Left = 0.08333334!
        Legend1.Alignment = DataDynamics.ActiveReports.Chart.Alignment.Bottom
        Legend1.Backdrop = New DataDynamics.ActiveReports.Chart.BackdropItem(System.Drawing.Color.Transparent, CType(189, Byte))
        Legend1.Border = New DataDynamics.ActiveReports.Chart.Border(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Black, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Transparent)
        Legend1.DockArea = ChartArea1
        Title1.Backdrop = New DataDynamics.ActiveReports.Chart.Graphics.Backdrop(DataDynamics.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, DataDynamics.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, Nothing, DataDynamics.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched)
        Title1.Border = New DataDynamics.ActiveReports.Chart.Border(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black)
        Title1.DockArea = Nothing
        Title1.Font = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
        Title1.Name = ""
        Title1.Text = ""
        Legend1.Footer = Title1
        Legend1.GridLayout = New DataDynamics.ActiveReports.Chart.GridLayout(2, 3)
        Title2.Alignment = DataDynamics.ActiveReports.Chart.Alignment.Top
        Title2.Backdrop = New DataDynamics.ActiveReports.Chart.Graphics.Backdrop(DataDynamics.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.Black, DataDynamics.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, Nothing, DataDynamics.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched)
        Title2.Border = New DataDynamics.ActiveReports.Chart.Border(New DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Transparent)
        Title2.DockArea = Nothing
        Title2.Font = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Tahoma", 7.0!))
        Title2.Name = ""
        Title2.Text = "Categoria"
        Legend1.Header = Title2
        Legend1.LabelsFont = New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Tahoma", 7.0!))
        Legend1.MarginX = 8
        Legend1.MarginY = 8
        Legend1.Name = "CategorieLegenda"
        Me.Chart.Legends.AddRange(New DataDynamics.ActiveReports.Chart.Legend() {Legend1})
        Me.Chart.Name = "Chart"
        Series1.AxisX = Axis1
        Series1.AxisY = Axis3
        Series1.ChartArea = ChartArea1
        Series1.ColorPalette = DataDynamics.ActiveReports.Chart.ColorPalette.[Default]
        Series1.Legend = Legend1
        Series1.LegendText = "Categoria Sales"
        Series1.Name = "Sales"
        Series1.Properties = New DataDynamics.ActiveReports.Chart.CustomProperties(New DataDynamics.ActiveReports.Chart.KeyValuePair() {New DataDynamics.ActiveReports.Chart.KeyValuePair("Backdrop", New DataDynamics.ActiveReports.Chart.Graphics.Backdrop), New DataDynamics.ActiveReports.Chart.KeyValuePair("BorderLine", New DataDynamics.ActiveReports.Chart.Graphics.Line), New DataDynamics.ActiveReports.Chart.KeyValuePair("ExplodeFactor", 0.05!), New DataDynamics.ActiveReports.Chart.KeyValuePair("HoleSize", 0.0!), New DataDynamics.ActiveReports.Chart.KeyValuePair("StartAngle", 1.0!), New DataDynamics.ActiveReports.Chart.KeyValuePair("Marker", New DataDynamics.ActiveReports.Chart.Marker(10, DataDynamics.ActiveReports.Chart.MarkerStyle.None, New DataDynamics.ActiveReports.Chart.Graphics.Backdrop, New DataDynamics.ActiveReports.Chart.Graphics.Line, New DataDynamics.ActiveReports.Chart.LabelInfo(New DataDynamics.ActiveReports.Chart.Graphics.Line, New DataDynamics.ActiveReports.Chart.Graphics.Backdrop, New DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Tahoma", 7.0!)), "{Pct:#.00}%", DataDynamics.ActiveReports.Chart.Alignment.Bottom))), New DataDynamics.ActiveReports.Chart.KeyValuePair("Tooltip", New DataDynamics.ActiveReports.Chart.LabelInfo)})
        Series1.Type = DataDynamics.ActiveReports.Chart.ChartType.Doughnut3D
        Series1.ValueMembersY = "SomaDeTotalPedido"
        Series1.ValueMemberX = "Nome"
        Me.Chart.Series.AddRange(New DataDynamics.ActiveReports.Chart.Series() {Series1})
        Me.Chart.Top = 0.1458333!
        Me.Chart.UIOptions = DataDynamics.ActiveReports.Chart.UIOptions.ForceHitTesting
        Me.Chart.Width = 7.135667!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Chart, Me.Label1, Me.Label2, Me.Line2})
        Me.GroupHeader1.Height = 5.9375!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'Label1
        '
        Me.Label1.Height = 0.1979167!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.1458333!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: Tahoma; font-size: 11pt; font-weight: bold"
        Me.Label1.Text = "Vendedor"
        Me.Label1.Top = 5.666667!
        Me.Label1.Width = 2.166667!
        '
        'Label2
        '
        Me.Label2.Height = 0.1979167!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 4.958333!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: Tahoma; font-size: 11pt; font-weight: bold; text-align: right"
        Me.Label2.Text = "Total Venda"
        Me.Label2.Top = 5.697917!
        Me.Label2.Width = 1.791667!
        '
        'Line2
        '
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.0!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 5.614583!
        Me.Line2.Width = 7.299705!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 7.299705!
        Me.Line2.Y1 = 5.614583!
        Me.Line2.Y2 = 5.614583!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox3, Me.Label3, Me.Line1})
        Me.GroupFooter1.Height = 0.2604167!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'TextBox3
        '
        Me.TextBox3.DataField = "SomaDeTotalPedido"
        Me.TextBox3.Height = 0.1968504!
        Me.TextBox3.Left = 4.96875!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.OutputFormat = resources.GetString("TextBox3.OutputFormat")
        Me.TextBox3.Style = "font-family: Tahoma; font-size: 11pt; font-weight: bold; text-align: right"
        Me.TextBox3.SummaryGroup = "GroupHeader1"
        Me.TextBox3.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox3.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0625!
        Me.TextBox3.Width = 1.845965!
        '
        'Label3
        '
        Me.Label3.Height = 0.1979167!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 3.90625!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: Tahoma; font-size: 11pt; font-weight: bold; text-align: center"
        Me.Label3.Text = "Total"
        Me.Label3.Top = 0.07291666!
        Me.Label3.Width = 1.0!
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.05208333!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.02083333!
        Me.Line1.Width = 7.310122!
        Me.Line1.X1 = 0.05208333!
        Me.Line1.X2 = 7.362205!
        Me.Line1.Y1 = 0.02083333!
        Me.Line1.Y2 = 0.02083333!
        '
        'RelGraficoVendedor
        '
        Me.MasterReport = False
        OleDBDataSource2.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Projetos dblsistemas\Prj Up\Dados" & _
            "\CD\upDados.mdb;Persist Security Info=False;Jet OLEDB:Database Password=abc"
        OleDBDataSource2.SQL = resources.GetString("OleDBDataSource2.SQL")
        Me.DataSource = OleDBDataSource2
        Me.PageSettings.Margins.Bottom = 0.3937008!
        Me.PageSettings.Margins.Left = 0.3937008!
        Me.PageSettings.Margins.Right = 0.3937008!
        Me.PageSettings.Margins.Top = 0.3937008!
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 7.458333!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.lblEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNome1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSomaDeTotalPedido1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Chart As DataDynamics.ActiveReports.ChartControl
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents txtNome1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSomaDeTotalPedido1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents lblEmpresa As DataDynamics.ActiveReports.Label
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents lblPeriodo As DataDynamics.ActiveReports.Label
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
    Friend WithEvents Label12 As DataDynamics.ActiveReports.Label
End Class 
