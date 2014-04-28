Public Class ClientesCredBaixar

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Cliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cliente.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ClientesProcura.ShowDialog()
            LocalizaDadosCliente()
        End If
    End Sub

    Private Sub Cliente_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cliente.Leave
        LocalizaDadosCliente()
    End Sub

    Public Sub LocalizaDadosCliente()
        If Me.Cliente.Text = "" Then
            Me.ClienteDesc.Clear()
            Exit Sub
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT * FROM Clientes WHERE Clientes.Empresa = " & CodEmpresa & " AND Clientes.Codigo =" & Me.Cliente.Text

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.ClienteDesc.Text = DR.Item("Nome") & ""
        Else
            MessageBox.Show("Cliente não encontrado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Tcredito.Text = FormatNumber(0, 2)
            Me.Trestante.Text = FormatNumber(0, 2)
            Me.ClienteDesc.Clear()
            Me.Cliente.Clear()
            Me.Cliente.Focus()
        End If

        DR.Close()
        CNN.Close()

        VerificaCredito365Dias()

    End Sub

    Private Sub btFindClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindClientes.Click
        My.Forms.ClientesProcura.ShowDialog()
        LocalizaDadosCliente()
    End Sub


    Private Sub VerificaCredito365Dias()
        If Me.Cliente.Text = "" Then
            Exit Sub
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT ClienteCred.Cliente, Sum(ClienteCred.ValorCred) AS SomaDeValorCred FROM(ClienteCred) WHERE (((ClienteCred.VencimentoCred)>=#" & Format(DataDia, "MM/dd/yyyy") & "#) AND ((ClienteCred.Empresa)=" & CodEmpresa & ") AND ((ClienteCred.Confirmado)=True) AND ((ClienteCred.Inativo)=False)) GROUP BY ClienteCred.Cliente HAVING (((ClienteCred.Cliente)=" & Me.Cliente.Text & "));"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.Tcredito.Text = FormatNumber(NzZero(DR.Item("SomaDeValorCred")), 2)
        Else
            Me.Tcredito.Text = FormatNumber(NzZero(0), 2)
        End If
        If NzZero(Me.Tcredito.Text) = 0 Then
            Me.btBaixarValor.Enabled = False
        Else
            Me.btBaixarValor.Enabled = True
        End If

        DR.Close()

    End Sub

   
    Private Sub Tbaixar_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbaixar.Validated
        Me.Tbaixar.Text = FormatNumber(NzZero(Me.Tbaixar.Text), 2)
        Me.Trestante.Text = FormatNumber(CDbl(NzZero(Me.Tcredito.Text)) - CDbl(NzZero(Me.Tbaixar.Text)), 2)

        If CDbl(NzZero(Me.Trestante.Text)) < 0 Then
            MessageBox.Show("O usuário não pode baixar um valor maior que o crédito", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Tcredito.Text = FormatNumber(0, 2)
            Me.Trestante.Text = FormatNumber(CDbl(NzZero(Me.Tcredito.Text)) - CDbl(NzZero(Me.Tbaixar.Text)), 2)
            Me.Tbaixar.Text = "0,00"
            Me.Tbaixar.Focus()
        End If

    End Sub

    Private Sub btBaixarValor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBaixarValor.Click
        'Area destinada para as validacoes
        If Me.Cliente.Text = "" Then
            MsgBox("O Código do Cliente não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Cliente.Focus()
            Exit Sub
        End If

        If NzZero(Me.Tbaixar.Text) = 0 Then
            MsgBox("O valor a ser baixado não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Tbaixar.Focus()
            Exit Sub
        End If

        'Fim da Area destinada para as validacoes

       
            'Se o caixa ativo for diferente de 4 então
            If Len(CaixaAtivo) <> 4 Then '
                MessageBox.Show("O usuário deve selecionar um caixa antes de baixar o documento", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Se o botão clicado for correspondente ao botao 6 então
                If MsgBox("Deseja Ativar o caixa agora", 36, "Validação de Dados") = 6 Then
                    TRVDados(UserAtivo, "CaixaAtivarDesativar")
                    If Ina = True Then
                        MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
                        Exit Sub
                    Else
                        My.Forms.CaixaAtivarDesativar.ShowDialog()
                    End If
                End If
            End If
            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()

            Dim CmdCred As OleDb.OleDbCommand = CNN.CreateCommand
            Dim CmdCaixa As OleDb.OleDbCommand = CNN.CreateCommand

            CmdCred.Transaction = Transacao
            CmdCaixa.Transaction = Transacao

            Try

                Dim Sql As String = "INSERT INTO ClienteCred (Cliente, DescCred, DataCred, VencimentoCred, ValorCred, Empresa, Confirmado) VALUES (@1, @2, @3, @4, @5, @6, @7)"
                CmdCred.CommandText = Sql

                CmdCred.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Cliente.Text, 1)))
                CmdCred.Parameters.Add(New OleDb.OleDbParameter("@2", Nz("PGTO DE CREDITO CLIENTE: " & UCase(Me.ClienteDesc.Text), 1)))
                CmdCred.Parameters.Add(New OleDb.OleDbParameter("@3", CStr(DataDia)))
                CmdCred.Parameters.Add(New OleDb.OleDbParameter("@4", CStr(DataDia)))

                Dim vBaixar As Double = CDbl(NzZero(Me.Tbaixar.Text)) * -1
                CmdCred.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(vBaixar, 3)))
                CmdCred.Parameters.Add(New OleDb.OleDbParameter("@6", CodEmpresa))
                CmdCred.Parameters.Add(New OleDb.OleDbParameter("@7", True))
                CmdCred.ExecuteNonQuery()

                Dim IdCredito As Integer
                CmdCred.CommandText = "SELECT @@IDENTITY"
                IdCredito = CmdCred.ExecuteScalar.ToString


                Sql = "INSERT INTO LancamentoBanco (DataLancamento, PreDatado, DataPreDatado, Documento, DataDocumento, TipoLancamento, Favorecido, Historico, CaiuBanco, ConfirmadoLancamento, Empresa, ValorDocumento, ContaCorrente, EmitirCheque, ContaBalancete, Tipo, IdLancamento, IdProcura) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18)"
                CmdCaixa.CommandText = Sql

                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(CStr(DataDia), 1)))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@2", False))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@3", System.DBNull.Value))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@4", "CRD-" & IdCredito))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(CStr(DataDia), 1)))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@6", Nz("D", 1)))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.ClienteDesc.Text, 1)))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@8", Nz("PGTO DE CREDITO CLIENTE: " & UCase(Me.ClienteDesc.Text), 1)))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@9", Nz("S", 1)))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@10", True)) 'Confirmado Lancamento como true
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@11", CodEmpresa))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(vBaixar, 3)))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(CaixaAtivo, 1)))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@14", "N"))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@15", Nz("000000", 1)))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@16", "CAIXA"))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@17", "BXCREDCLI"))
                CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@18", IdCredito))
                CmdCaixa.ExecuteNonQuery()
                Transacao.Commit()
                CNN.Close()
                'Fazer a impressao
                ImprimirRecibo(IdCredito)

                MsgBox("Crédito baixado com sucesso", 64, "Validação de Dados")
                ErroLivre = "Baixou credito do Cliente: " & UCase(Me.ClienteDesc.Text) & " ID: " & IdCredito
                GerarLog(Me.Text, AçãoTP.Adicionou, IdCredito)

                Me.Tcredito.Text = FormatNumber(0, 2)
                Me.Tbaixar.Text = FormatNumber(0, 2)
                Me.Trestante.Text = FormatNumber(0, 2)

                Me.Cliente.Focus()
            Catch ex As Exception
                MsgBox("Erro na baixa do Crédito.", 64, "Validação de Dados")
                Transacao.Rollback()
                MsgBox(ex.Message, 64, "Validação de Dados")
                CNN.Close()
            End Try
    


    End Sub

    Private Sub ImprimirRecibo(ByVal IdRecibo As Integer)

        Dim Tel As New Form() ' Create a new instance of the form.
        Dim Vz As New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Dim F As New Font("Comic Sans MS", 8, System.Drawing.GraphicsUnit.Point)

        Tel.Text = "Visualizador de Relatório"
        Tel.Size = New Size(576, 352)
        Tel.HelpButton = False
        Tel.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        Tel.MaximizeBox = True
        Tel.MinimizeBox = True
        Tel.ControlBox = True
        Tel.Font = F
        Tel.StartPosition = FormStartPosition.CenterScreen
        Tel.ShowInTaskbar = True
        Tel.WindowState = FormWindowState.Maximized

        Vz.Dock = DockStyle.Fill


        Dim Crypto As New ClCrypto 'Para descriptografar a senha do banco de dados
        'Carrega o relatorio
        Dim VerRelat As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        VerRelat.Load(DirRelat & "RelReciboPgtoCreditoCli.rpt")
        VerRelat.DataSourceConnections.Item(0).SetConnection("", LocalBD & Nome_BD, False)
        VerRelat.DataSourceConnections.Item(0).SetLogon("", Crypto.clsCrypto(SenhaBancoDados, False))
        VerRelat.DataDefinition.RecordSelectionFormula = "{ClienteCred.Id} = " & IdRecibo

        Vz.ReportSource = VerRelat
        Tel.Controls.Add(Vz)
        Tel.ShowDialog()

    End Sub

    Public Function UltimoReg()
        'Inserir ultimo registro
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer
        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select max(Id) from ClienteCred"
            .CommandType = CommandType.Text
        End With
        Try
            Cnn.Open()
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    Ult = DataReader.Item(0)
                End If
            End While
            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Return 1
                Exit Function
            End If
        End Try
        Cnn.Close()

        Return Ult + 1


    End Function

    Private Sub ClientesCredBaixar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        'A10 produtos vendidos no perido para o cliente

        Try
            RelatorioCarregar = "RelExtratoCreditoCliente.rpt"
            Dim strFormula As String = "{ClienteCred.cliente}=" & Me.Cliente.Text
            'chama a classe e passa os parametros para o relatorio
            Dim f As New ClassView.cView

            f.frm(DirRelat & RelatorioCarregar, LocalBD & Nome_BD, SenhaBancoDados, strFormula)

        Catch ex As Exception

        End Try


    End Sub

    Private Sub Tbaixar_TextChanged(sender As Object, e As EventArgs) Handles Tbaixar.TextChanged

    End Sub
End Class