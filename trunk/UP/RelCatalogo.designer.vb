<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RelCatalogo 
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
        Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelCatalogo))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Picture1 = New DataDynamics.ActiveReports.Picture
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.txtMensagem1 = New DataDynamics.ActiveReports.TextBox
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtCodigoProduto1 = New DataDynamics.ActiveReports.TextBox
        Me.Shape1 = New DataDynamics.ActiveReports.Shape
        Me.Picture2 = New DataDynamics.ActiveReports.Picture
        Me.Shape2 = New DataDynamics.ActiveReports.Shape
        Me.txtDescrição1 = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMensagem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoProduto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescrição1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.BackColor = System.Drawing.Color.Black
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Picture1, Me.TextBox1, Me.txtMensagem1})
        Me.PageHeader1.Height = 0.9479167!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Picture1
        '
        Me.Picture1.Border.BottomColor = System.Drawing.Color.Black
        Me.Picture1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Border.LeftColor = System.Drawing.Color.Black
        Me.Picture1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Border.RightColor = System.Drawing.Color.Black
        Me.Picture1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.Border.TopColor = System.Drawing.Color.Black
        Me.Picture1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture1.DataField = "Empresa.Foto"
        Me.Picture1.Height = 0.8976378!
        Me.Picture1.Image = Nothing
        Me.Picture1.ImageData = Nothing
        Me.Picture1.Left = 0.04374453!
        Me.Picture1.LineWeight = 0.0!
        Me.Picture1.Name = "Picture1"
        Me.Picture1.SizeMode = DataDynamics.ActiveReports.SizeModes.Stretch
        Me.Picture1.Top = 0.0!
        Me.Picture1.Width = 1.562992!
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.DataField = "=""Telefone:"" + Telefone"
        Me.TextBox1.Height = 0.3062117!
        Me.TextBox1.Left = 1.662292!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "color: White; text-align: center; font-weight: bold; font-size: 16pt; font-family" & _
            ": Tahoma; "
        Me.TextBox1.Text = "Titulo"
        Me.TextBox1.Top = 0.04374453!
        Me.TextBox1.Width = 6.124235!
        '
        'txtMensagem1
        '
        Me.txtMensagem1.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtMensagem1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txtMensagem1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtMensagem1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMensagem1.Border.RightColor = System.Drawing.Color.Black
        Me.txtMensagem1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtMensagem1.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtMensagem1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txtMensagem1.DataField = "Mensagem"
        Me.txtMensagem1.Height = 0.2187227!
        Me.txtMensagem1.Left = 1.662292!
        Me.txtMensagem1.Name = "txtMensagem1"
        Me.txtMensagem1.Style = "color: Red; text-align: center; font-weight: bold; font-size: 12pt; font-family: " & _
            "Tahoma; "
        Me.txtMensagem1.Text = "txtMensagem1"
        Me.txtMensagem1.Top = 0.4374453!
        Me.txtMensagem1.Width = 6.124235!
        '
        'Detail1
        '
        Me.Detail1.ColumnCount = 4
        Me.Detail1.ColumnDirection = DataDynamics.ActiveReports.ColumnDirection.AcrossDown
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCodigoProduto1, Me.Shape1, Me.Picture2, Me.Shape2, Me.txtDescrição1})
        Me.Detail1.Height = 1.895833!
        Me.Detail1.KeepTogether = True
        Me.Detail1.Name = "Detail1"
        '
        'txtCodigoProduto1
        '
        Me.txtCodigoProduto1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCodigoProduto1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoProduto1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCodigoProduto1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoProduto1.Border.RightColor = System.Drawing.Color.Black
        Me.txtCodigoProduto1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoProduto1.Border.TopColor = System.Drawing.Color.Black
        Me.txtCodigoProduto1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodigoProduto1.DataField = "CodigoProduto"
        Me.txtCodigoProduto1.Height = 0.1749781!
        Me.txtCodigoProduto1.Left = 0.0!
        Me.txtCodigoProduto1.Name = "txtCodigoProduto1"
        Me.txtCodigoProduto1.Style = "color: White; text-align: center; font-weight: bold; background-color: Black; fon" & _
            "t-family: Tahoma; "
        Me.txtCodigoProduto1.Text = "txtCodigoProduto1"
        Me.txtCodigoProduto1.Top = 0.04374453!
        Me.txtCodigoProduto1.Width = 1.92476!
        '
        'Shape1
        '
        Me.Shape1.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.RightColor = System.Drawing.Color.Black
        Me.Shape1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.TopColor = System.Drawing.Color.Black
        Me.Shape1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Height = 1.356081!
        Me.Shape1.Left = 0.0!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 9.999999!
        Me.Shape1.Style = DataDynamics.ActiveReports.ShapeType.RoundRect
        Me.Shape1.Top = 0.04374453!
        Me.Shape1.Width = 1.92476!
        '
        'Picture2
        '
        Me.Picture2.Border.BottomColor = System.Drawing.Color.Black
        Me.Picture2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture2.Border.LeftColor = System.Drawing.Color.Black
        Me.Picture2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture2.Border.RightColor = System.Drawing.Color.Black
        Me.Picture2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture2.Border.TopColor = System.Drawing.Color.Black
        Me.Picture2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Picture2.DataField = "ProdutosFoto.Foto"
        Me.Picture2.Height = 1.090551!
        Me.Picture2.Image = Nothing
        Me.Picture2.ImageData = Nothing
        Me.Picture2.Left = 0.3937008!
        Me.Picture2.LineWeight = 0.0!
        Me.Picture2.Name = "Picture2"
        Me.Picture2.SizeMode = DataDynamics.ActiveReports.SizeModes.Stretch
        Me.Picture2.Top = 0.2624672!
        Me.Picture2.Width = 1.090551!
        '
        'Shape2
        '
        Me.Shape2.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape2.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape2.Border.RightColor = System.Drawing.Color.Black
        Me.Shape2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape2.Border.TopColor = System.Drawing.Color.Black
        Me.Shape2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape2.Height = 0.4811898!
        Me.Shape2.Left = 0.0!
        Me.Shape2.Name = "Shape2"
        Me.Shape2.RoundingRadius = 9.999999!
        Me.Shape2.Style = DataDynamics.ActiveReports.ShapeType.RoundRect
        Me.Shape2.Top = 1.399825!
        Me.Shape2.Width = 1.92476!
        '
        'txtDescrição1
        '
        Me.txtDescrição1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtDescrição1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescrição1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtDescrição1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescrição1.Border.RightColor = System.Drawing.Color.Black
        Me.txtDescrição1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescrição1.Border.TopColor = System.Drawing.Color.Black
        Me.txtDescrição1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtDescrição1.DataField = "Descrição"
        Me.txtDescrição1.Height = 0.3937007!
        Me.txtDescrição1.Left = 0.04374453!
        Me.txtDescrição1.Name = "txtDescrição1"
        Me.txtDescrição1.Style = "ddo-char-set: 0; font-size: 6.75pt; font-family: Tahoma; "
        Me.txtDescrição1.Text = "txtDescrição1"
        Me.txtDescrição1.Top = 1.44357!
        Me.txtDescrição1.Width = 1.83727!
        '
        'PageFooter1
        '
        Me.PageFooter1.BackColor = System.Drawing.Color.Black
        Me.PageFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.ReportInfo1})
        Me.PageFooter1.Height = 0.21875!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'ReportInfo1
        '
        Me.ReportInfo1.Border.BottomColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.Border.LeftColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.Border.RightColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.Border.TopColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.FormatString = "Pagina {PageNumber} de {PageCount}"
        Me.ReportInfo1.Height = 0.2187227!
        Me.ReportInfo1.Left = 3.980753!
        Me.ReportInfo1.Name = "ReportInfo1"
        Me.ReportInfo1.Style = "color: White; ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9" & _
            ".75pt; font-family: Tahoma; "
        Me.ReportInfo1.Top = 0.0!
        Me.ReportInfo1.Width = 3.805774!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.BackColor = System.Drawing.Color.LightGray
        Me.GroupHeader1.ColumnGroupKeepTogether = True
        Me.GroupHeader1.ColumnLayout = False
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox2})
        Me.GroupHeader1.Height = 0.1875!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.DataField = "=Cor + ""-"" + CorDesc"
        Me.TextBox2.Height = 0.1749781!
        Me.TextBox2.Left = 0.0!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; font-family: Tahoma; "
        Me.TextBox2.Text = "CorGrupo"
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 4.286964!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.Visible = False
        '
        'RelCatalogo
        '
        Me.MasterReport = False
        OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Sistemas -Up\Prj Up\Dados\max\upD" & _
            "ados.mdb;Jet oledb:database password=abc"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.Margins.Bottom = 0.1968504!
        Me.PageSettings.Margins.Left = 0.1968504!
        Me.PageSettings.Margins.Right = 0.1574803!
        Me.PageSettings.Margins.Top = 0.1574803!
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 7.833333!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMensagem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoProduto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescrição1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Picture1 As DataDynamics.ActiveReports.Picture
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtMensagem1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Picture2 As DataDynamics.ActiveReports.Picture
    Friend WithEvents txtCodigoProduto1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Shape2 As DataDynamics.ActiveReports.Shape
    Friend WithEvents txtDescrição1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
End Class
