Imports System
Imports Microsoft.Win32
Public Class CFGALL
    Inherits System.Windows.Forms.Form

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NomeCFG As System.Windows.Forms.TextBox


    Dim Ação As New TrfGerais()

    Dim ds As DataSet
    Private dt As DataTable
    Friend WithEvents btPadrao As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BDnfe As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btNfe As System.Windows.Forms.Button

    Friend WithEvents Lista As DevComponents.DotNetBar.Controls.DataGridViewX

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LocalBaseDados As System.Windows.Forms.TextBox
    Friend WithEvents CodigoEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents BTBancoDados As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NomeBancoDados As System.Windows.Forms.TextBox
    Friend WithEvents BTNomeBd As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LogCaminho As System.Windows.Forms.TextBox
    Friend WithEvents BtLog As System.Windows.Forms.Button
    Friend WithEvents Fechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Salvar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btRelatorios As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LocalRelatorios As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SenhaBD As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CodigoEmpresa = New System.Windows.Forms.TextBox()
        Me.LocalBaseDados = New System.Windows.Forms.TextBox()
        Me.BTBancoDados = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NomeBancoDados = New System.Windows.Forms.TextBox()
        Me.BTNomeBd = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LogCaminho = New System.Windows.Forms.TextBox()
        Me.BtLog = New System.Windows.Forms.Button()
        Me.Fechar = New DevComponents.DotNetBar.ButtonX()
        Me.Salvar = New DevComponents.DotNetBar.ButtonX()
        Me.btRelatorios = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LocalRelatorios = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SenhaBD = New System.Windows.Forms.TextBox()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.BDnfe = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btNfe = New System.Windows.Forms.Button()
        Me.btPadrao = New DevComponents.DotNetBar.ButtonX()
        Me.Lista = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NomeCFG = New System.Windows.Forms.TextBox()
        Me.PanelEx1.SuspendLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(9, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Cod. Empresa"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Local Bd"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CodigoEmpresa
        '
        Me.CodigoEmpresa.BackColor = System.Drawing.Color.White
        Me.CodigoEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CodigoEmpresa.Location = New System.Drawing.Point(127, 128)
        Me.CodigoEmpresa.Name = "CodigoEmpresa"
        Me.CodigoEmpresa.Size = New System.Drawing.Size(79, 23)
        Me.CodigoEmpresa.TabIndex = 12
        '
        'LocalBaseDados
        '
        Me.LocalBaseDados.BackColor = System.Drawing.Color.White
        Me.LocalBaseDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LocalBaseDados.Location = New System.Drawing.Point(127, 12)
        Me.LocalBaseDados.Name = "LocalBaseDados"
        Me.LocalBaseDados.Size = New System.Drawing.Size(427, 23)
        Me.LocalBaseDados.TabIndex = 1
        '
        'BTBancoDados
        '
        Me.BTBancoDados.BackColor = System.Drawing.SystemColors.Control
        Me.BTBancoDados.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTBancoDados.Location = New System.Drawing.Point(560, 12)
        Me.BTBancoDados.Name = "BTBancoDados"
        Me.BTBancoDados.Size = New System.Drawing.Size(34, 20)
        Me.BTBancoDados.TabIndex = 2
        Me.BTBancoDados.Text = "..."
        Me.BTBancoDados.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(9, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Nome do B.D"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NomeBancoDados
        '
        Me.NomeBancoDados.BackColor = System.Drawing.Color.White
        Me.NomeBancoDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NomeBancoDados.Location = New System.Drawing.Point(127, 41)
        Me.NomeBancoDados.Name = "NomeBancoDados"
        Me.NomeBancoDados.Size = New System.Drawing.Size(427, 23)
        Me.NomeBancoDados.TabIndex = 4
        '
        'BTNomeBd
        '
        Me.BTNomeBd.BackColor = System.Drawing.SystemColors.Control
        Me.BTNomeBd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNomeBd.Location = New System.Drawing.Point(560, 41)
        Me.BTNomeBd.Name = "BTNomeBd"
        Me.BTNomeBd.Size = New System.Drawing.Size(34, 20)
        Me.BTNomeBd.TabIndex = 5
        Me.BTNomeBd.Text = "..."
        Me.BTNomeBd.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(9, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 20)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Log"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogCaminho
        '
        Me.LogCaminho.BackColor = System.Drawing.Color.White
        Me.LogCaminho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LogCaminho.Location = New System.Drawing.Point(127, 157)
        Me.LogCaminho.Name = "LogCaminho"
        Me.LogCaminho.Size = New System.Drawing.Size(427, 23)
        Me.LogCaminho.TabIndex = 14
        '
        'BtLog
        '
        Me.BtLog.BackColor = System.Drawing.SystemColors.Control
        Me.BtLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtLog.Location = New System.Drawing.Point(560, 157)
        Me.BtLog.Name = "BtLog"
        Me.BtLog.Size = New System.Drawing.Size(32, 20)
        Me.BtLog.TabIndex = 15
        Me.BtLog.Text = "..."
        Me.BtLog.UseVisualStyleBackColor = False
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Location = New System.Drawing.Point(505, 244)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(85, 25)
        Me.Fechar.TabIndex = 23
        Me.Fechar.Text = "Fechar"
        '
        'Salvar
        '
        Me.Salvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Salvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Salvar.Location = New System.Drawing.Point(414, 244)
        Me.Salvar.Name = "Salvar"
        Me.Salvar.Size = New System.Drawing.Size(85, 25)
        Me.Salvar.TabIndex = 21
        Me.Salvar.Text = "Salvar"
        '
        'btRelatorios
        '
        Me.btRelatorios.BackColor = System.Drawing.SystemColors.Control
        Me.btRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btRelatorios.Location = New System.Drawing.Point(560, 99)
        Me.btRelatorios.Name = "btRelatorios"
        Me.btRelatorios.Size = New System.Drawing.Size(34, 20)
        Me.btRelatorios.TabIndex = 10
        Me.btRelatorios.Text = "..."
        Me.btRelatorios.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(9, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Local dos Relatórios"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LocalRelatorios
        '
        Me.LocalRelatorios.BackColor = System.Drawing.Color.White
        Me.LocalRelatorios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LocalRelatorios.Location = New System.Drawing.Point(127, 99)
        Me.LocalRelatorios.Name = "LocalRelatorios"
        Me.LocalRelatorios.Size = New System.Drawing.Size(427, 23)
        Me.LocalRelatorios.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(9, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Senha do BD"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SenhaBD
        '
        Me.SenhaBD.BackColor = System.Drawing.Color.White
        Me.SenhaBD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SenhaBD.Location = New System.Drawing.Point(127, 70)
        Me.SenhaBD.MaxLength = 15
        Me.SenhaBD.Name = "SenhaBD"
        Me.SenhaBD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SenhaBD.Size = New System.Drawing.Size(272, 23)
        Me.SenhaBD.TabIndex = 7
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.BDnfe)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.btNfe)
        Me.PanelEx1.Controls.Add(Me.btPadrao)
        Me.PanelEx1.Controls.Add(Me.Lista)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.NomeCFG)
        Me.PanelEx1.Controls.Add(Me.LocalBaseDados)
        Me.PanelEx1.Controls.Add(Me.Salvar)
        Me.PanelEx1.Controls.Add(Me.Label8)
        Me.PanelEx1.Controls.Add(Me.Fechar)
        Me.PanelEx1.Controls.Add(Me.CodigoEmpresa)
        Me.PanelEx1.Controls.Add(Me.SenhaBD)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.btRelatorios)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.LocalRelatorios)
        Me.PanelEx1.Controls.Add(Me.BTBancoDados)
        Me.PanelEx1.Controls.Add(Me.NomeBancoDados)
        Me.PanelEx1.Controls.Add(Me.Label6)
        Me.PanelEx1.Controls.Add(Me.Label10)
        Me.PanelEx1.Controls.Add(Me.BTNomeBd)
        Me.PanelEx1.Controls.Add(Me.LogCaminho)
        Me.PanelEx1.Controls.Add(Me.BtLog)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(606, 441)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'BDnfe
        '
        Me.BDnfe.AcceptsReturn = True
        Me.BDnfe.BackColor = System.Drawing.Color.White
        Me.BDnfe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BDnfe.Location = New System.Drawing.Point(127, 186)
        Me.BDnfe.Name = "BDnfe"
        Me.BDnfe.Size = New System.Drawing.Size(427, 23)
        Me.BDnfe.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(9, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Local Bd NFe"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btNfe
        '
        Me.btNfe.BackColor = System.Drawing.SystemColors.Control
        Me.btNfe.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btNfe.Location = New System.Drawing.Point(560, 186)
        Me.btNfe.Name = "btNfe"
        Me.btNfe.Size = New System.Drawing.Size(34, 20)
        Me.btNfe.TabIndex = 18
        Me.btNfe.Text = "..."
        Me.btNfe.UseVisualStyleBackColor = False
        '
        'btPadrao
        '
        Me.btPadrao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btPadrao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btPadrao.Location = New System.Drawing.Point(12, 244)
        Me.btPadrao.Name = "btPadrao"
        Me.btPadrao.Size = New System.Drawing.Size(118, 25)
        Me.btPadrao.TabIndex = 22
        Me.btPadrao.Text = "Definir como Padrão"
        '
        'Lista
        '
        Me.Lista.AllowUserToAddRows = False
        Me.Lista.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.Lista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Lista.DefaultCellStyle = DataGridViewCellStyle2
        Me.Lista.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Lista.Location = New System.Drawing.Point(12, 276)
        Me.Lista.Name = "Lista"
        Me.Lista.ReadOnly = True
        Me.Lista.RowHeadersWidth = 20
        Me.Lista.SelectAllSignVisible = False
        Me.Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Lista.Size = New System.Drawing.Size(582, 159)
        Me.Lista.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(9, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Nome da CFG"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NomeCFG
        '
        Me.NomeCFG.BackColor = System.Drawing.Color.White
        Me.NomeCFG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NomeCFG.Location = New System.Drawing.Point(127, 215)
        Me.NomeCFG.Name = "NomeCFG"
        Me.NomeCFG.Size = New System.Drawing.Size(427, 23)
        Me.NomeCFG.TabIndex = 20
        '
        'CFGALL
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(606, 441)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CFGALL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurações - T273"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salvar.Click

        Dim Crypto As New ClCrypto

        Dim DrLinha() As DataRow
        DrLinha = ds.Tables("CFG").Select("NomeCFG = '" & Me.NomeCFG.Text & "'")

        If DrLinha.Length = 0 Then
            Dim dr As DataRow = dt.NewRow()
            dr(0) = Me.NomeCFG.Text
            dr(1) = Me.LocalBaseDados.Text
            dr(2) = Me.NomeBancoDados.Text
            dr(3) = Crypto.clsCrypto(Me.SenhaBD.Text, True)
            dr(4) = Me.LocalRelatorios.Text
            dr(5) = Me.LogCaminho.Text
            dr(6) = Me.CodigoEmpresa.Text
            dr(7) = Me.BDnfe.Text
            dt.Rows.Add(dr)
            ds.WriteXml("C:\Windows\upCFGALL.Xml")
            MessageBox.Show("Dados salvo com sucesso...")
        Else

            DrLinha(0).BeginEdit()
            DrLinha(0)("NomeCFG") = Me.NomeCFG.Text
            DrLinha(0)("LocalBD") = Me.LocalBaseDados.Text
            DrLinha(0)("NomeBancoDados") = Me.NomeBancoDados.Text
            DrLinha(0)("ShBancoDados") = Crypto.clsCrypto(Me.SenhaBD.Text, True)
            DrLinha(0)("LocalRelatorios") = Me.LocalRelatorios.Text
            DrLinha(0)("LogCaminho") = Me.LogCaminho.Text
            DrLinha(0)("BDnfe") = Me.BDnfe.Text
            DrLinha(0)("CodigoEmpresa") = Me.CodigoEmpresa.Text

            DrLinha(0).EndEdit()

            ds.WriteXml("C:\Windows\upCFGALL.Xml")
            MessageBox.Show("Dados editado com sucesso...")
        End If

    End Sub


    Private Sub BTBancoDados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTBancoDados.Click
        Dim OpenFolder As New FolderBrowserDialog

        OpenFolder.ShowDialog()

        If OpenFolder.SelectedPath <> "" Then
            Me.LocalBaseDados.Text = OpenFolder.SelectedPath & "\"
            Me.LocalBaseDados.Focus()
        End If
    End Sub

    Private Sub BTNomeBd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNomeBd.Click
        Dim OpenFileDialog1 As New OpenFileDialog()
        OpenFileDialog1.Filter = "(Banco de Dados) *.Mdb | *.mdb"
        OpenFileDialog1.Title = "Selecione um arquivo MDB para inserir no campo Nome do banco de Dados"
        OpenFileDialog1.FileName = Me.LocalBaseDados.Text
        OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.FileName <> "" Then
            Dim BBD As String
            Dim Pos As Integer
            BBD = OpenFileDialog1.FileName
            Pos = BBD.LastIndexOf("\")
            Me.NomeBancoDados.Text = Mid(BBD, (Pos + 2))
            Me.NomeBancoDados.Focus()
        End If
    End Sub



    Private Sub BtLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtLog.Click
        Dim OpenFolder As New FolderBrowserDialog

        OpenFolder.ShowDialog()

        If OpenFolder.SelectedPath <> "" Then
            Me.LogCaminho.Text = OpenFolder.SelectedPath & "\"
            Me.LogCaminho.Focus()
        End If

    End Sub

    Private Sub btRelatorios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRelatorios.Click
        Dim OpenFolder As New FolderBrowserDialog

        OpenFolder.ShowDialog()

        If OpenFolder.SelectedPath <> "" Then
            Me.LocalRelatorios.Text = OpenFolder.SelectedPath & "\"
            Me.LocalRelatorios.Focus()
        End If
    End Sub

    Private Sub SenhaBD_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SenhaBD.Enter
        Me.SenhaBD.PasswordChar = "*"
    End Sub

    Private Sub CFGALL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds = New DataSet()
        Try
            ds.ReadXml("C:\Windows\upCFGALL.Xml")
            dt = ds.Tables("CFG")
        Catch ex As IO.FileNotFoundException
            dt = New DataTable("CFG")
            dt.Columns.Add("NomeCFG")
            dt.Columns.Add("LocalBD")
            dt.Columns.Add("NomeBancoDados")
            dt.Columns.Add("ShBancoDados")
            dt.Columns.Add("LocalRelatorios")
            dt.Columns.Add("LogCaminho")
            dt.Columns.Add("BDnfe")
            dt.Columns.Add("CodigoEmpresa")
            ds.Tables.Add(dt)
        End Try
        Me.Lista.DataSource = dt

    End Sub

    Private Sub Lista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellDoubleClick

        Dim Crypto As New ClCrypto

        Me.NomeCFG.Text = Me.Lista.CurrentRow.Cells(0).Value
        Me.LocalBaseDados.Text = Me.Lista.CurrentRow.Cells(1).Value
        Me.NomeBancoDados.Text = Me.Lista.CurrentRow.Cells(2).Value
        Me.SenhaBD.Text = Crypto.clsCrypto(Me.Lista.CurrentRow.Cells(3).Value, False)
        Me.LocalRelatorios.Text = Me.Lista.CurrentRow.Cells(4).Value
        Me.LogCaminho.Text = Me.Lista.CurrentRow.Cells(5).Value
        Me.BDnfe.Text = Me.Lista.CurrentRow.Cells(6).Value
        Me.CodigoEmpresa.Text = Me.Lista.CurrentRow.Cells(7).Value

    End Sub





    
    Private Sub btPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPadrao.Click

        Dim LocalEXE As String = My.Application.Info.DirectoryPath

        Dim Crypto As New ClCrypto

        Dim n As System.Text.Encoding = System.Text.Encoding.UTF8
        Dim writer As New Xml.XmlTextWriter(LocalEXE & "\upConf.Xml", n)

        writer.WriteStartDocument()
        writer.Formatting = Xml.Formatting.Indented


        writer.WriteStartElement("Bd")
        writer.WriteElementString("LocalBD", Me.LocalBaseDados.Text)
        writer.WriteElementString("NomeBancoDados", Me.NomeBancoDados.Text)
        writer.WriteElementString("ShBancoDados", Crypto.clsCrypto(Me.SenhaBD.Text, True))
        writer.WriteElementString("LocalRelatorios", Me.LocalRelatorios.Text)
        writer.WriteElementString("LogCaminho", Me.LogCaminho.Text)
        writer.WriteElementString("BDnfe", Me.BDnfe.Text)
        writer.WriteElementString("CodigoEmpresa", Me.CodigoEmpresa.Text)

        writer.WriteEndElement()
        writer.Close()

        MsgBox("Configuração definida como padrão.", 64, "Configuração do Sistema")
    End Sub

    Private Sub btNfe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNfe.Click
        Dim OpenFileDialog1 As New OpenFileDialog()
        OpenFileDialog1.Filter = "(Banco de Dados) *.Mdb | *.mdb"
        OpenFileDialog1.Title = "Selecione um arquivo MDB para inserir no campo Nome do banco de Dados"
        OpenFileDialog1.FileName = Me.LocalBaseDados.Text
        OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.FileName <> "" Then
            Dim BBD As String
            BBD = OpenFileDialog1.FileName
            Me.BDnfe.Text = BBD
            Me.BDnfe.Focus()
        End If
    End Sub
End Class