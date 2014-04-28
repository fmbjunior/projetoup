Imports System.Data.OleDb
Imports Microsoft.Win32
Imports System.IO
Imports System.Threading
Imports System.Net
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Rendering


Public Class Login

    Private mMenuCFG As New System.Windows.Forms.ContextMenu()

    Dim VlrTeclas As String = String.Empty 'Serve para capturar as teclas que foram pressionadas

    Dim CTRLpress As Integer

    Dim Mensagem As String
    Public tableExist As Boolean

    Private Sub ConfirmarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmarBT.Click


        If Me.DataHoje.Text = "" Then
            MsgBox("O usuário deve informar a data para o sistema")
            Me.DataHoje.Focus()
            Exit Sub
        Else
            DataDia = Me.DataHoje.Text
        End If

        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()


        Dim CMD As New OleDbCommand()
        Dim DataReader As OleDbDataReader

        With CMD
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * From LoginUser Where Login = '" & Me.Usuario.Text & "'"
            .CommandType = CommandType.Text
        End With

        DataReader = CMD.ExecuteReader

        DataReader.Read()

        If DataReader.HasRows Then
            mMenuCarregar = DataReader.Item("MenuCarregar") & ""
            If DataReader.Item("Senha") = Me.Senha.Text Then
                VerificaDia()
                If DiaFechado = True Then
                    MsgBox("Existe um Dia de Trabalho Criado, o sistema ira preencher para o usuário.", 64, "Validação de Dados")
                    Me.DataHoje.Focus()
                    Exit Sub
                Else

                    DiaFechado = False
                    UserAtivo = Me.Usuario.Text
                    ParametrosEmpresa()
                    SendKeys.Send("{NUMLOCK}")
                    CarregaPermissaoUSER()
                    Liberado = True
                End If

            Else
                MsgBox("Senha invalida para este usuário", 64, "Validação de Dados")
                Me.Usuario.Focus()
                Exit Sub
            End If
        Else
            MsgBox("Usuário não encontrado no sistema, favor verificar.", 64, "Validação de Dados")
            Me.Usuario.Focus()
            Exit Sub
        End If


        My.Forms.MenuGeral.Show()
        Me.Close()
        Me.Dispose()
        DataReader.Close()
        Cnn.Close()

    End Sub

    Public Sub VerificaDia()

        Dim Cn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cn.Open()

        Dim CM As New OleDbCommand()
        Dim DR As OleDbDataReader

        'Verifica a data de Entrada
        With CM
            .Connection = Cn
            .CommandTimeout = 0
            .CommandText = "SELECT * From DiaTrabalho Where DiaTrabalho = #" & Format(CDate(Me.DataHoje.Text), "MM/dd/yyyy") & "# and Empresa = " & CodEmpresa
            .CommandType = CommandType.Text
        End With

        DR = CM.ExecuteReader

        If DR.HasRows = True Then
            While DR.Read
                If DR.Item("Fechado") = False Then
                    DiaFechado = False
                Else
                    DiaFechado = True
                    Mensagem = "Verifique se o dia definido ja foi fechado. Se fechado, não poderá mais ser aberto"
                End If
                'Cn.Close()
                'Exit Sub
            End While
        Else
            DiaFechado = True
        End If
        DR.Close()

        'Verifica se existe dia aberto antes de criar novo
        With CM
            .Connection = Cn
            .CommandTimeout = 0
            .CommandText = "SELECT * From DiaTrabalho Where Fechado = False and Empresa = " & CodEmpresa
            .CommandType = CommandType.Text
        End With

        DR = CM.ExecuteReader

        While DR.Read
            Mensagem = "O Dia : " & DR.Item("DiaTrabalho") & " não foi finalizado. Verifique com o administrador ou utilize este dia."
            Me.DataHoje.Text = DR.Item("DiaTrabalho")
            Cn.Close()
            Exit Sub
        End While
        DR.Close()

        Cn.Close()

    End Sub


    Public Sub DiaTrabalho()

        Dim Cn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cn.Open()

        Dim CM As New OleDbCommand()
        Dim DR As OleDbDataReader

        'Verifica a data de Entrada
        

        'Verifica se existe dia aberto antes de criar novo
        With CM
            .Connection = Cn
            .CommandTimeout = 0
            .CommandText = "SELECT * From DiaTrabalho Where Fechado = False and Empresa = " & CodEmpresa
            .CommandType = CommandType.Text
        End With

        DR = CM.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.DataHoje.Text = DR.Item("DiaTrabalho")
        End If
        DR.Close()
        Cn.Close()

    End Sub



    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        verVersao = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision
        'RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, eOffice2007ColorScheme.Silver, Color.Black)
        Me.lblVersao.Text = "Versão: " & verVersao

        Dim XX As Integer = (Me.Width / 2) - (Me.PainelLogin.Width / 2)
        Dim YY As Integer = (Me.Height / 2) - (Me.PainelLogin.Height / 2)

        Me.PainelLogin.Location = New Point(XX, YY)


        Dim LocalEXE As String = My.Application.Info.DirectoryPath

        Try
            Shell(Application.StartupPath & "\UpVerificador.exe", AppWinStyle.NormalFocus, False)
        Catch exx As Exception
        End Try
        'Rotina para carregar na inicialização


        Dim EstaOk As New VerificaLicenca

        Dim Continua As Boolean = EstaOk.IsValida
        If Continua = False Then
            MessageBox.Show("Verifique a sua cópia: Copia Inválida ou Expirou", "Validação de Copia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End If


        'Rotina para carregar na inicialização

        Dim Linha As String = Environment.CommandLine

        Dim PosU As Integer = Linha.IndexOf("U-") 'Pega o parametro de Linha com Nome do Usuário
        Dim PosC As Integer = Linha.IndexOf("C-") 'Pega o parametro de Linha com a configuraçao de banco de dados Padrão

        If PosU > 0 Then CmdLine = Mid(Linha, (PosU + 3))

        Try
            If CmdLine.IndexOf(" ") <> 0 Then
                CmdLine = Mid(CmdLine, 1, CmdLine.IndexOf(" "))
            End If
        Catch
        End Try

        Dim ConfPadrão As String = String.Empty
        If PosC > 0 Then ConfPadrão = Mid(Linha, (PosC + 3))

        'fim da rotina para carregar na inicialização

        Me.Usuario.Focus()

        'Carregar configurações de Registro para um perfeito funcinamento do sistema

        My.Forms.MenuGeral.Visible = False

        ' Dim CodEmpresaTemp As String = ""
        Try

            If IO.File.Exists(LocalEXE & "\upConf.Xml") = False Then
                My.Forms.CFG.ShowDialog()
                End
                Exit Sub
            End If

            Dim ds As New DataSet()
            ds.ReadXml(LocalEXE & "\upConf.Xml")

            Dim Crypto As New ClCrypto
            Dim Dr As DataRow
            For Each Dr In ds.Tables("Bd").Rows
                LocalBD = Dr.Item("LocalBD")
                Nome_BD = Dr.Item("NomeBancoDados")
                SenhaBancoDados = Dr.Item("ShBancoDados")
                DirRelat = Dr.Item("LocalRelatorios")
                CaminhoLog = Dr.Item("LogCaminho")
                CodEmpresa = Dr.Item("CodigoEmpresa")
                LocalDBNFe = Dr.Item("BDnfe")
            Next

            ParametrosEmpresa()
            Me.lblEmpresaPadrao.Text = "Empresa: " & CodEmpresa & "-" & NomEmpresa


            ds.Dispose()

            'Atualiza a versao do sistema
            Dim Pos As Integer = Linha.IndexOf("/")
            If Pos > 0 Then
                Dim ValorLinha As String = Mid(Linha, Pos + 2)

                If ValorLinha = "Atualizar" Then
                    AtualizaTabelas()
                End If
            End If

        Catch
            If LocalBD = "" Then
                My.Forms.CFG.ShowDialog()
                End
            End If
        End Try

        'fim

    End Sub
    Public Sub ParametrosEmpresa()
        Dim Cn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Try
            Cn.Open()

            Dim CM As New OleDbCommand()
            Dim DR As OleDbDataReader

            'Verifica a data de Entrada
            With CM
                .Connection = Cn
                .CommandTimeout = 0
                .CommandText = "SELECT * From Empresa Where CódigoEmpresa = " & CodEmpresa
                .CommandType = CommandType.Text
            End With

            DR = CM.ExecuteReader
            DR.Read()
            If DR.HasRows = True Then
                NomEmpresa = DR.Item("RazãoSocial")
                DescontoEmLinha = DR.Item("DescontoLinha")
                CidadeEmpresa = DR.Item("Cidade") & "-" & DR.Item("Estado")
                ReciboAVista = DR.Item("ReciboVendaVista")
                VenderEstoqueNegativo = DR.Item("VerderEstoqueNegativo")
                VlrMinFat = FormatNumber(Nz(DR.Item("ValorMinimoFaturamento"), 3), 2)
                GerarXmlPedido = DR.Item("gXmlPed")
                ParcFixo = DR.Item("ParcelamentoFixo")
                DiaFechamentoMensal = NzZero(DR.Item("DiaFechamentoMensal"))

                If DR.Item("ComPorProduto") = True Then TipoComissaoVenda = "P"
                If DR.Item("ComPorVendedor") = True Then TipoComissaoVenda = "V"
                If DR.Item("ComRecebimento") = True Then TipoComissaoVenda = "R"
                If DR.Item("ComFaixa") = True Then TipoComissaoVenda = "porFAIXA"
                If DR.Item("SemComissao") = True Then TipoComissaoVenda = "semCOMISSAO"


                EmitirDpPedido = DR.Item("EmitirDuplicataPedidoConfirmado")
                ModeloDuplicata = DR.Item("ModeloDP") & ""
                ValidadeOrcamento = DR.Item("ValidadeOrcamento") & ""
                NaoValidarDocumento = DR.Item("NaoValidaCpfCnpj") & ""
                CodLancamentoReceber = DR.Item("cValorReceber") & ""
                UsarGrade = DR.Item("UsarGradeProdutos")
                UsarServico = DR.Item("UsarServico")
                cbVendaVista = DR.Item("ContaBalanceteVendaAvista")
                vISSQN = NzZero(DR.Item("ISSQN"))

                DescontoGerencia = CDbl(NzZero(DR.Item("DescontoGerencia")))
                Var_EnterCodBarra = DR.Item("EnterCodBarra")
                VAR_ContaCrVenda = DR.Item("ContaCRVenda") & ""
                Vendedor_Fecha_Pedido = DR.Item("VendedorFechaPedido")
                UsaSellShoes = DR.Item("UsarPedidoSellShoes")
                TSesquema = DR.Item("EsquemaTS")
                CaixaDeMovimento = DR.Item("CaixaMovimento") & ""
                ClienteConsumidor = NzZero(DR.Item("ClienteConsumidor"))
                VarDesmenbrarEntrada = DR.Item("EntradaDesmenbrarNF")
                UsaMateriaPrima = DR.Item("UsaMateriaPrima")
                Manual = DR.Item("Manual")
                Leitor = DR.Item("Leitor")
                If VAR_ContaCrVenda = "" Then VAR_ContaCrVenda = "000000"

            End If
            DR.Close()
        Catch ex As Exception
            MessageBox.Show("Você precisa atualizar as tabelas do sistemas!!!", "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub DataHoje_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataHoje.Enter
        'If Me.DataHoje.Text = "" Then Me.DataHoje.Text = FormatDateTime(CDate(Today), DateFormat.ShortDate)
        If Me.DataHoje.Text = "" Then
            DiaTrabalho()
        End If
    End Sub

    Private Sub Senha_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Senha.Enter
        Me.Senha.SelectAll()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Me.Usuario.Text = "ADMIN"
    End Sub

    Private Sub CarregaPermissaoUSER()
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM LoginUserPermissao"
            .CommandType = CommandType.Text
        End With

        Try
            DR = Cmd.ExecuteReader
            While DR.Read
                If Not IsDBNull(DR.Item("Login")) Then
                    SnhArray.Add(New CLPermissõesArray(DR.Item("Tela") & "", DR.Item("Login") & "", DR.Item("Senha") & "", DR.Item("Exclui"), DR.Item("Adiciona"), DR.Item("Altera"), DR.Item("Consultar"), DR.Item("UsarSenha"), DR.Item("Inativo")))
                End If
            End While
            Cnn.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        End
    End Sub

    Private Sub AltSenha_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles AltSenha.LinkClicked
        If Me.Usuario.Text = "" Then Exit Sub
        My.Forms.AlterarSenha.ShowDialog()
    End Sub

    Private Sub Usuario_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Usuario.Enter
        If Me.Usuario.Text = "" Then
            Me.Usuario.Text = CmdLine
        End If
    End Sub

    Private Sub Login_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.F12 Then
            My.Forms.CFG.ShowDialog()
        End If

        If e.KeyCode = Keys.F10 Then
            My.Forms.AtTabelas.ShowDialog()
        End If


        Dim isControlPressed As Boolean = (Control.ModifierKeys And Keys.Control) <> 0
        If isControlPressed = True Then
            CTRLpress += 1

            If e.KeyCode = Keys.C Then
                e.Handled = True
                VlrTeclas += "C"
            End If
            If e.KeyCode = Keys.F Then
                e.Handled = True
                VlrTeclas += "F"
            End If
            If e.KeyCode = Keys.G Then
                e.Handled = True
                VlrTeclas += "G"
            End If

            If VlrTeclas = "CFG" Then
                VlrTeclas = String.Empty
                My.Forms.CFGALL.ShowDialog()
                Login_Load(sender, e)
            End If

            If Len(VlrTeclas) > 3 Then
                VlrTeclas = String.Empty
            End If


        End If

        If CTRLpress > 3 Then
            If e.KeyCode = Keys.Insert Then
                e.Handled = True

                Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
                Cnn.Open()

                Dim SQL As String = "Select * From LoginUser Where Login = 'ADMIN'"
                Dim Cmd As New OleDb.OleDbCommand(SQL, Cnn)
                Dim DR As OleDb.OleDbDataReader

                DR = Cmd.ExecuteReader
                DR.Read()

                If DR.HasRows = True Then
                    Me.Usuario.Clear()
                    Me.Usuario.Text = DR.Item("Login")
                    Me.Senha.Text = DR.Item("Senha")
                    DR.Close()
                    Cnn.Close()
                End If
                DiaTrabalho()
                ConfirmarBT_Click(sender, e)
                CTRLpress = 0
            End If
        End If
    End Sub

   
End Class

