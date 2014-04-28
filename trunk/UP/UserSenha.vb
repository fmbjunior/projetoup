Imports System.Data.OleDb
Imports System.IO
Public Class UserSenha
    Inherits System.Windows.Forms.Form

    Dim CaminhoImagem As String = ""
    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents BarraBt As System.Windows.Forms.ToolStrip
    Friend WithEvents NovoBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents SalvarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ExcluirBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents FecharBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents LocalizarBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents PermissoesBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuCarregar As CBOAutoCompleteFocus.CboFocus
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Dim Cm As New OleDbCommand()


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
    Friend WithEvents Login As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Senha As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Tipo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NomeUser As TexBoxFocusNet.TextBoxFocusNet

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserSenha))
        Me.Login = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Senha = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tipo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NomeUser = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Fundo = New DevComponents.DotNetBar.PanelEx()
        Me.MenuCarregar = New CBOAutoCompleteFocus.CboFocus()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BarraBt = New System.Windows.Forms.ToolStrip()
        Me.NovoBT = New System.Windows.Forms.ToolStripButton()
        Me.SalvarBT = New System.Windows.Forms.ToolStripButton()
        Me.EditarBT = New System.Windows.Forms.ToolStripButton()
        Me.ExcluirBT = New System.Windows.Forms.ToolStripButton()
        Me.FecharBT = New System.Windows.Forms.ToolStripButton()
        Me.LocalizarBT = New System.Windows.Forms.ToolStripButton()
        Me.PermissoesBT = New System.Windows.Forms.ToolStripButton()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Fundo.SuspendLayout()
        Me.BarraBt.SuspendLayout()
        Me.SuspendLayout()
        '
        'Login
        '
        Me.Login.AceitaColarTexto = True
        Me.Login.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Login.CasasDecimais = 0
        Me.Login.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Login.CPObrigatorio = False
        Me.Login.CPObrigatorioMsg = Nothing
        Me.Login.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Login.FlatBorder = False
        Me.Login.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Login.FocusColor = System.Drawing.Color.LightBlue
        Me.Login.FocusColorEnd = System.Drawing.Color.Empty
        Me.Login.HighlightBorderOnEnter = False
        Me.Login.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Login.Location = New System.Drawing.Point(87, 82)
        Me.Login.Name = "Login"
        Me.Login.PreencherZeroEsqueda = False
        Me.Login.RegraValidação = Nothing
        Me.Login.RegraValidaçãoMensagem = Nothing
        Me.Login.Size = New System.Drawing.Size(110, 23)
        Me.Login.TabIndex = 2
        Me.Login.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Login.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Login"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Senha"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Senha
        '
        Me.Senha.AceitaColarTexto = True
        Me.Senha.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Senha.CasasDecimais = 0
        Me.Senha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Senha.CPObrigatorio = False
        Me.Senha.CPObrigatorioMsg = Nothing
        Me.Senha.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Senha.FlatBorder = False
        Me.Senha.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Senha.FocusColor = System.Drawing.Color.LightBlue
        Me.Senha.FocusColorEnd = System.Drawing.Color.Empty
        Me.Senha.HighlightBorderOnEnter = False
        Me.Senha.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Senha.Location = New System.Drawing.Point(87, 140)
        Me.Senha.Name = "Senha"
        Me.Senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Senha.PreencherZeroEsqueda = False
        Me.Senha.RegraValidação = Nothing
        Me.Senha.RegraValidaçãoMensagem = Nothing
        Me.Senha.Size = New System.Drawing.Size(110, 23)
        Me.Senha.TabIndex = 6
        Me.Senha.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Senha.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(356, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tipo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tipo
        '
        Me.Tipo.AceitaColarTexto = True
        Me.Tipo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Tipo.CasasDecimais = 0
        Me.Tipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tipo.CPObrigatorio = False
        Me.Tipo.CPObrigatorioMsg = Nothing
        Me.Tipo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.Tipo.FlatBorder = False
        Me.Tipo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.Tipo.FocusColor = System.Drawing.Color.LightBlue
        Me.Tipo.FocusColorEnd = System.Drawing.Color.Empty
        Me.Tipo.HighlightBorderOnEnter = False
        Me.Tipo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.Tipo.Location = New System.Drawing.Point(431, 140)
        Me.Tipo.Name = "Tipo"
        Me.Tipo.PreencherZeroEsqueda = False
        Me.Tipo.RegraValidação = Nothing
        Me.Tipo.RegraValidaçãoMensagem = Nothing
        Me.Tipo.Size = New System.Drawing.Size(40, 23)
        Me.Tipo.TabIndex = 8
        Me.Tipo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Tipo.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nome User"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NomeUser
        '
        Me.NomeUser.AceitaColarTexto = True
        Me.NomeUser.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NomeUser.CasasDecimais = 0
        Me.NomeUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NomeUser.CPObrigatorio = False
        Me.NomeUser.CPObrigatorioMsg = Nothing
        Me.NomeUser.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NomeUser.FlatBorder = False
        Me.NomeUser.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NomeUser.FocusColor = System.Drawing.Color.LightBlue
        Me.NomeUser.FocusColorEnd = System.Drawing.Color.Empty
        Me.NomeUser.HighlightBorderOnEnter = False
        Me.NomeUser.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NomeUser.Location = New System.Drawing.Point(87, 111)
        Me.NomeUser.Name = "NomeUser"
        Me.NomeUser.PreencherZeroEsqueda = False
        Me.NomeUser.RegraValidação = Nothing
        Me.NomeUser.RegraValidaçãoMensagem = Nothing
        Me.NomeUser.Size = New System.Drawing.Size(384, 23)
        Me.NomeUser.TabIndex = 4
        Me.NomeUser.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NomeUser.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Fundo.Controls.Add(Me.MenuCarregar)
        Me.Fundo.Controls.Add(Me.Label25)
        Me.Fundo.Controls.Add(Me.BarraBt)
        Me.Fundo.Controls.Add(Me.Login)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.NomeUser)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Senha)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.Tipo)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(485, 208)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Fundo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 0
        '
        'MenuCarregar
        '
        Me.MenuCarregar.Auto_Complete = True
        Me.MenuCarregar.AutoLimitar_Lista = True
        Me.MenuCarregar.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.MenuCarregar.CPObrigatorio = False
        Me.MenuCarregar.CPObrigatorioMsg = Nothing
        Me.MenuCarregar.FlatBorder = False
        Me.MenuCarregar.FlatBorderColor = System.Drawing.Color.DimGray
        Me.MenuCarregar.FormattingEnabled = True
        Me.MenuCarregar.HighlightBorderColor = System.Drawing.Color.Empty
        Me.MenuCarregar.HighlightBorderOnEnter = False
        Me.MenuCarregar.Items.AddRange(New Object() {"MenuDisplay", "MenuVendaShoes"})
        Me.MenuCarregar.Location = New System.Drawing.Point(87, 169)
        Me.MenuCarregar.Name = "MenuCarregar"
        Me.MenuCarregar.Size = New System.Drawing.Size(243, 23)
        Me.MenuCarregar.TabIndex = 10
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(10, 171)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(71, 19)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Menu"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BarraBt
        '
        Me.BarraBt.BackColor = System.Drawing.Color.Transparent
        Me.BarraBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BarraBt.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraBt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.HelpProvider1.SetHelpNavigator(Me.BarraBt, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.BarraBt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoBT, Me.SalvarBT, Me.EditarBT, Me.ExcluirBT, Me.FecharBT, Me.LocalizarBT, Me.PermissoesBT})
        Me.BarraBt.Location = New System.Drawing.Point(0, 0)
        Me.BarraBt.Name = "BarraBt"
        Me.BarraBt.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.HelpProvider1.SetShowHelp(Me.BarraBt, True)
        Me.BarraBt.Size = New System.Drawing.Size(485, 58)
        Me.BarraBt.TabIndex = 0
        Me.BarraBt.Text = "ToolStrip1"
        '
        'NovoBT
        '
        Me.NovoBT.Image = CType(resources.GetObject("NovoBT.Image"), System.Drawing.Image)
        Me.NovoBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NovoBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NovoBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NovoBT.Name = "NovoBT"
        Me.NovoBT.Size = New System.Drawing.Size(40, 55)
        Me.NovoBT.Text = "Novo"
        Me.NovoBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.NovoBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SalvarBT
        '
        Me.SalvarBT.Image = CType(resources.GetObject("SalvarBT.Image"), System.Drawing.Image)
        Me.SalvarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalvarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SalvarBT.Name = "SalvarBT"
        Me.SalvarBT.Size = New System.Drawing.Size(45, 55)
        Me.SalvarBT.Text = "Salvar"
        Me.SalvarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SalvarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'EditarBT
        '
        Me.EditarBT.Image = CType(resources.GetObject("EditarBT.Image"), System.Drawing.Image)
        Me.EditarBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EditarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditarBT.Name = "EditarBT"
        Me.EditarBT.Size = New System.Drawing.Size(43, 55)
        Me.EditarBT.Text = "Editar"
        Me.EditarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EditarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ExcluirBT
        '
        Me.ExcluirBT.Image = CType(resources.GetObject("ExcluirBT.Image"), System.Drawing.Image)
        Me.ExcluirBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExcluirBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExcluirBT.Name = "ExcluirBT"
        Me.ExcluirBT.Size = New System.Drawing.Size(54, 55)
        Me.ExcluirBT.Text = "Inativar"
        Me.ExcluirBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ExcluirBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FecharBT
        '
        Me.FecharBT.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.FecharBT.Image = CType(resources.GetObject("FecharBT.Image"), System.Drawing.Image)
        Me.FecharBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FecharBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FecharBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FecharBT.Name = "FecharBT"
        Me.FecharBT.Size = New System.Drawing.Size(46, 55)
        Me.FecharBT.Text = "Fechar"
        Me.FecharBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FecharBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LocalizarBT
        '
        Me.LocalizarBT.Image = CType(resources.GetObject("LocalizarBT.Image"), System.Drawing.Image)
        Me.LocalizarBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LocalizarBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LocalizarBT.Name = "LocalizarBT"
        Me.LocalizarBT.Size = New System.Drawing.Size(59, 55)
        Me.LocalizarBT.Text = "Localizar"
        Me.LocalizarBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LocalizarBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PermissoesBT
        '
        Me.PermissoesBT.Image = CType(resources.GetObject("PermissoesBT.Image"), System.Drawing.Image)
        Me.PermissoesBT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PermissoesBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PermissoesBT.Name = "PermissoesBT"
        Me.PermissoesBT.Size = New System.Drawing.Size(67, 55)
        Me.PermissoesBT.Text = "Permissões"
        Me.PermissoesBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.PermissoesBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\UpSistemas\Help\dblsistemas.chm"
        '
        'UserSenha
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(485, 208)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "UserSenha"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserSenha - T214"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.BarraBt.ResumeLayout(False)
        Me.BarraBt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region


    'Public Sub AtualizarPermissao()

    '    If Me.Login.Text = "" Then Exit Sub

    '    Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
    '    CNN.Open()

    '    Dim Ds As New DataSet

    '    Dim DaTelas As New OleDbDataAdapter("Select * from TelasSistema", CNN)
    '    DaTelas.SelectCommand.CommandType = CommandType.Text
    '    DaTelas.Fill(DS, "Telas")

    '    Dim DaPermissao As New OleDbDataAdapter("Select * from LoginUserPermissao Where Login = '" & Me.Login.Text & "'", CNN)
    '    DaPermissao.SelectCommand.CommandType = CommandType.Text
    '    DaPermissao.Fill(Ds, "LoginUserPermissao")


    '    Dim DrTelas As DataRow
    '    For Each DrTelas In DS.Tables("Telas").Rows
    '        Dim DrAcheiPermissao() As DataRow
    '        DrAcheiPermissao = Ds.Tables("LoginUserPermissao").Select("Tela = '" & DrTelas("Tela").ToString & "'")

    '        If DrAcheiPermissao.Length = 0 Then
    '            'Adiciona
    '            Dim DRnovo As DataRow
    '            DRnovo = Ds.Tables("LoginUserPermissao").NewRow
    '            DRnovo("Login") = Me.Login.Text
    '            DRnovo("Tela") = DrTelas("Tela").ToString
    '            DRnovo("DescricaoTela") = DrTelas("DescricaoTela").ToString
    '            DRnovo("Adiciona") = False
    '            DRnovo("Altera") = False
    '            DRnovo("Exclui") = False
    '            DRnovo("Consultar") = True
    '            DRnovo("UsarSenha") = False
    '            DRnovo("Inativo") = False
    '            Ds.Tables("LoginUserPermissao").Rows.Add(DRnovo)
    '        Else
    '            'Edita
    '            DrAcheiPermissao(0).BeginEdit()
    '            DrAcheiPermissao(0)("Tela") = DrTelas("Tela").ToString
    '            DrAcheiPermissao(0)("DescricaoTela") = DrTelas("DescricaoTela").ToString
    '            DrAcheiPermissao(0).EndEdit()
    '        End If

    '    Next

    '    Dim objCommandBuilder As New OleDbCommandBuilder(DaPermissao)
    '    DaPermissao.Update(Ds, "LoginUserPermissao")

    '    DaTelas.Dispose()
    '    DaPermissao.Dispose()

    'End Sub

    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        CarregaPermissaoUSER()
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub Localizar_Registro()
        If RetornoProcura = "" Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from LoginUser where Login = '" & Me.Login.Text & "' And inativo = false"
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.NomeUser.Text = DR.Item("NomeUser") & ""
            Me.Senha.Text = DR.Item("Senha") & ""
            Me.Tipo.Text = DR.Item("Tipo") & ""
            Me.MenuCarregar.Text = DR.Item("MenuCarregar") & ""
        End If
        Me.Login.Focus()
        Operation = UPD

    End Sub

    Private Sub SalvaBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click

        If Me.Login.Text = "" Then
            MsgBox("O login não pode ser nulo", 64, "Validação de Dados")
            Me.Login.Focus()
            Exit Sub
        ElseIf Me.NomeUser.Text = "" Then
            MsgBox("O nome do usuário não pode ser nulo", 64, "Validação de Dados")
            Me.NomeUser.Focus()
            Exit Sub
        ElseIf Me.Senha.Text = "" Then
            MsgBox("A senha do login não pode ser nulo", 64, "Validação de Dados")
            Me.Senha.Focus()
            Exit Sub
        ElseIf Me.Tipo.Text = "" Then
            MsgBox("O tipo de login não pode ser nulo", 64, "Validação de Dados")
            Me.Tipo.Focus()
            Exit Sub
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            Dim Sql As String = "INSERT INTO LoginUser (Login, NomeUser, Senha, Tipo, MenuCarregar, Empresa) VALUES (@1, @2, @3, @4, @5, @6)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Login.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.NomeUser.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Senha.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Tipo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.MenuCarregar.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", CodEmpresa))

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Registro adicionado com sucesso", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GerarLog(Me.Text, AçãoTP.Confirmou, Me.Login.Text)
                Operation = UPD
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            Me.Login.Enabled = False
            Me.NomeUser.Enabled = False
            Me.Senha.Enabled = False
            Me.Tipo.Enabled = False
            Me.MenuCarregar.Enabled = False
            CNN.Close()

        ElseIf Operation = UPD Then
            CNN.Open()

            Dim Sql As String = "Update LoginUser set Login = @1, NomeUser = @2, Senha = @3, Tipo = @4, MenuCarregar = @5, Empresa = @6 Where Login = '" & Me.Login.Text & "'"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Login.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.NomeUser.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Senha.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Tipo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.MenuCarregar.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", CodEmpresa))

            Try
                cmd.ExecuteNonQuery()
                Operation = UPD
                MessageBox.Show("Registro Atualizado com sucesso", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GerarLog(Me.Text, AçãoTP.Editou, Me.Login.Text)
            Catch x As Exception
                'MsgBox(x.Message)
                'Exit Sub
            End Try
            Me.Login.Enabled = False
            Me.NomeUser.Enabled = False
            Me.Senha.Enabled = False
            Me.Tipo.Enabled = False
            Me.MenuCarregar.Enabled = False
            CNN.Close()
        End If
    End Sub


    Private Sub GerarPermissoesTodos()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Ds As New DataSet

        Dim Sql As String = String.Empty
        Sql = "SELECT * from Pedido Where PedidoSequencia  = " & My.Forms.SellShoes.Venda.Text

        Dim Cmd As New OleDb.OleDbCommand(Sql, CNN)

        Dim DA As New OleDb.OleDbDataAdapter(Cmd)
        DA.Fill(Ds, "Venda")

        Ds.Tables("Venda").Rows(0).BeginEdit()
        Ds.Tables("Venda").Rows(0)("DataFechamento") = DataDia
        Ds.Tables("Venda").Rows(0)("Confirmado") = True
        Ds.Tables("Venda").Rows(0)("StatusAndamentos") = "FINALIZADO"
        Ds.Tables("Venda").Rows(0).EndEdit()

        Dim Obj As New OleDb.OleDbCommandBuilder(DA)
        DA.Update(Ds, "Venda")

    End Sub


    Private Sub NovoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click
        Me.Login.Clear()
        Me.NomeUser.Clear()
        Me.Tipo.Clear()
        Me.Senha.Clear()
        Me.MenuCarregar.SelectedIndex = -1

        Operation = INS
        Ação.Desbloquear_Controle(Me, True)
        Me.Login.Focus()
    End Sub

    Private Sub EditarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBT.Click
        If Me.Login.Text = "" Then
            MsgBox("No existe Login para ser editado.", 64, "Validação de Dados")
            Exit Sub
        End If
        Operation = UPD
        Ação.Desbloquear_Controle(Me, True)
        Me.MenuCarregar.Enabled = True
        Me.Login.Focus()
    End Sub

    Private Sub UserSenha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ação.Desbloquear_Controle(Me, False)
    End Sub


    Private Sub CarregaPermissaoUSER()

        If Me.Login.Text = "" Then Exit Sub

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM LoginUserPermissao where Login = '" & Me.Login.Text & "'"
            .CommandType = CommandType.Text
        End With

        Try
            DR = Cmd.ExecuteReader
            While DR.Read
                If Not IsDBNull(DR.Item("Login")) Then
                    SnhArray.Add(New CLPermissõesArray(DR.Item("Tela"), DR.Item("Login"), DR.Item("Senha") & "", DR.Item("Exclui"), DR.Item("Adiciona"), DR.Item("Altera"), DR.Item("Consultar"), DR.Item("UsarSenha"), DR.Item("Inativo")))
                End If
            End While
            Cnn.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub LocalizarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizarBT.Click
        ChamaTelaProcura("Login", "User", "", "LoginUser", "Login", "NomeUser", "", False)
        Me.Login.Text = RetornoProcura
        Localizar_Registro()

    End Sub

    Private Sub PermissoesBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermissoesBT.Click
        'AtualizarPermissao()
        My.Forms.UserSenhaAllItens.ShowDialog()
        CarregaPermissaoUSER()
    End Sub

    Private Sub ExcluirBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirBT.Click

        If Me.Login.Text = "" Then
            MessageBox.Show("Favor informar um login para inativar.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Login.Clear()
            Me.Login.Focus()
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Update LoginUser set Inativo = @1 Where Login = '" & Me.Login.Text & "'"
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", True))

        Try
            cmd.ExecuteNonQuery()
            Operation = UPD
            MessageBox.Show("Usuário Inativado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch x As Exception
            'MsgBox(x.Message)
            'Exit Sub
        End Try
        Me.Login.Enabled = False
        Me.NomeUser.Enabled = False
        Me.Senha.Enabled = False
        Me.Tipo.Enabled = False
        Me.MenuCarregar.Enabled = False
        CNN.Close()

    End Sub
End Class
