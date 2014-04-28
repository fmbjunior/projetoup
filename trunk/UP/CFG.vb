Imports System
Imports Microsoft.Win32
Public Class CFG
    Inherits System.Windows.Forms.Form

    Dim LocalEXE As String = My.Application.Info.DirectoryPath
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents BDnfe As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btNfe As System.Windows.Forms.Button


    Dim Ação As New TrfGerais()

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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btNfe = New System.Windows.Forms.Button()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(9, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
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
        Me.Label6.Size = New System.Drawing.Size(116, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Nome Banco de Dados"
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
        Me.Label10.TabIndex = 14
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
        Me.LogCaminho.TabIndex = 15
        '
        'BtLog
        '
        Me.BtLog.BackColor = System.Drawing.SystemColors.Control
        Me.BtLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtLog.Location = New System.Drawing.Point(560, 151)
        Me.BtLog.Name = "BtLog"
        Me.BtLog.Size = New System.Drawing.Size(32, 20)
        Me.BtLog.TabIndex = 13
        Me.BtLog.Text = "..."
        Me.BtLog.UseVisualStyleBackColor = False
        '
        'Fechar
        '
        Me.Fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Fechar.Location = New System.Drawing.Point(509, 240)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(85, 25)
        Me.Fechar.TabIndex = 17
        Me.Fechar.Text = "Fechar"
        '
        'Salvar
        '
        Me.Salvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Salvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Salvar.Location = New System.Drawing.Point(418, 240)
        Me.Salvar.Name = "Salvar"
        Me.Salvar.Size = New System.Drawing.Size(85, 25)
        Me.Salvar.TabIndex = 16
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
        Me.Label4.Size = New System.Drawing.Size(116, 20)
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
        Me.Label8.Size = New System.Drawing.Size(116, 20)
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
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.btNfe)
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
        Me.PanelEx1.Size = New System.Drawing.Size(606, 277)
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
        Me.BDnfe.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(9, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Local Bd NFe"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btNfe
        '
        Me.btNfe.BackColor = System.Drawing.SystemColors.Control
        Me.btNfe.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btNfe.Location = New System.Drawing.Point(560, 186)
        Me.btNfe.Name = "btNfe"
        Me.btNfe.Size = New System.Drawing.Size(34, 20)
        Me.btNfe.TabIndex = 20
        Me.btNfe.Text = "..."
        Me.btNfe.UseVisualStyleBackColor = False
        '
        'CFG
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(606, 277)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CFG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurações - T272"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salvar.Click

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
        writer.WriteElementString("CodigoEmpresa", Me.CodigoEmpresa.Text)
        writer.WriteElementString("BDnfe", Me.BDnfe.Text)

        writer.WriteEndElement()
        writer.Close()

        MsgBox("Arquivo de configuração salvo com sucesso, o sistema sera fechado, favor reiniciar", 64, "Configuração do Sistema")

        End

    End Sub

    Private Sub CFGFocus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If IO.File.Exists(LocalEXE & "\upConf.Xml") = False Then
            MessageBox.Show("O arquivo de Configuração dos Dados não foi criado, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Dim ds As New DataSet()
            ds.ReadXml(LocalEXE & "\upConf.Xml")

            Dim Dr As DataRow
            For Each Dr In ds.Tables("Bd").Rows
                Me.LocalBaseDados.Text = Dr.Item("LocalBD")
                Me.NomeBancoDados.Text = Dr.Item("NomeBancoDados")
                Me.SenhaBD.Text = Dr.Item("ShBancoDados")
                Me.LocalRelatorios.Text = Dr.Item("LocalRelatorios")
                Me.LogCaminho.Text = Dr.Item("LogCaminho")
                Me.CodigoEmpresa.Text = Dr.Item("CodigoEmpresa")
                Me.BDnfe.Text = Dr.Item("BDnfe")
            Next

            ds.Dispose()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub CodigoEmpresa_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CodigoEmpresa.Leave
        If LocalBD = "" Then
            LocalBD = Me.LocalBaseDados.Text
        End If
        If Me.CodigoEmpresa.Text = "" Then
            Exit Sub
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

    Private Sub BDnfe_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDnfe.TextChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class