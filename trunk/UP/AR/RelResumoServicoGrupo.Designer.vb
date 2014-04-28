<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RelResumoServicoGrupo 
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelResumoServicoGrupo))
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtNome1 = New DataDynamics.ActiveReports.TextBox
        Me.txtSomaDeTotalservico1 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        CType(Me.txtNome1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSomaDeTotalservico1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNome1, Me.txtSomaDeTotalservico1, Me.TextBox1})
        Me.Detail1.Height = 0.2083333!
        Me.Detail1.Name = "Detail1"
        '
        'txtNome1
        '
        Me.txtNome1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtNome1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNome1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtNome1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNome1.Border.RightColor = System.Drawing.Color.Black
        Me.txtNome1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNome1.Border.TopColor = System.Drawing.Color.Black
        Me.txtNome1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNome1.DataField = "Nome"
        Me.txtNome1.Height = 0.1968504!
        Me.txtNome1.Left = 0.0246063!
        Me.txtNome1.Name = "txtNome1"
        Me.txtNome1.Style = "font-weight: bold; font-size: 9pt; font-family: Tahoma; "
        Me.txtNome1.Text = "txtNome1"
        Me.txtNome1.Top = 0.0!
        Me.txtNome1.Width = 2.952756!
        '
        'txtSomaDeTotalservico1
        '
        Me.txtSomaDeTotalservico1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtSomaDeTotalservico1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSomaDeTotalservico1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtSomaDeTotalservico1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSomaDeTotalservico1.Border.RightColor = System.Drawing.Color.Black
        Me.txtSomaDeTotalservico1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSomaDeTotalservico1.Border.TopColor = System.Drawing.Color.Black
        Me.txtSomaDeTotalservico1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtSomaDeTotalservico1.DataField = "SomaDeTotalservico"
        Me.txtSomaDeTotalservico1.Height = 0.2!
        Me.txtSomaDeTotalservico1.Left = 3.001969!
        Me.txtSomaDeTotalservico1.Name = "txtSomaDeTotalservico1"
        Me.txtSomaDeTotalservico1.OutputFormat = resources.GetString("txtSomaDeTotalservico1.OutputFormat")
        Me.txtSomaDeTotalservico1.Style = "text-align: right; font-weight: bold; font-size: 9pt; font-family: Tahoma; "
        Me.txtSomaDeTotalservico1.Text = "txtSomaDeTotalservico1"
        Me.txtSomaDeTotalservico1.Top = 0.0!
        Me.txtSomaDeTotalservico1.Width = 1.0!
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
        Me.TextBox1.Height = 0.1875!
        Me.TextBox1.Left = 4.0625!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
        Me.TextBox1.Style = "text-align: right; font-weight: bold; font-size: 9pt; font-family: Tahoma; "
        Me.TextBox1.Text = "TextBox1"
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 0.8125!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label1})
        Me.GroupHeader1.Height = 0.2708333!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'Label1
        '
        Me.Label1.Border.BottomColor = System.Drawing.Color.Black
        Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.LeftColor = System.Drawing.Color.Black
        Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.RightColor = System.Drawing.Color.Black
        Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.TopColor = System.Drawing.Color.Black
        Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Height = 0.1979167!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.0!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-weight: bold; font-style: italic; font-size: 10pt; font-family: Tahoma; "
        Me.Label1.Text = "Resumo Final"
        Me.Label1.Top = 0.0625!
        Me.Label1.Width = 1.0!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'RelResumoServicoGrupo
        '
        Me.MasterReport = False
        OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Prj Up\Dados\retificams\upDados.m" & _
            "db;Jet oledb:database password=abc"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 5.041667!
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.txtNome1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSomaDeTotalservico1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents txtNome1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtSomaDeTotalservico1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Public WithEvents Detail1 As DataDynamics.ActiveReports.Detail
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
End Class
