Public Class CartaoCreditoMenu

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub LocalizaPedido()

        Dim dsV As New DataSet

        Dim CN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CN.Open()

        Dim Sql As String = String.Empty

        Sql = "SELECT Pedido.*, Clientes.*, Municipio.NomeMunic, UF.NomeUF, Funcionários.Nome, FormaPgto.Descrição FROM ((Pedido INNER JOIN ((Clientes LEFT JOIN UF ON Clientes.cUF = UF.CodigoUF) LEFT JOIN Municipio ON Clientes.cMun = Municipio.CodMunicipio) ON Pedido.CódigoCliente = Clientes.Codigo) INNER JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário) LEFT JOIN FormaPgto ON Pedido.FormaPgto = FormaPgto.CodFormaPgto WHERE (((Pedido.PedidoSequencia)=" & Me.pPedido.Text & ") AND ((Pedido.Inativo)=False) AND ((Pedido.Empresa)=" & CodEmpresa & "));"
        Dim DaVenda As New OleDb.OleDbDataAdapter(Sql, CN)
        DaVenda.Fill(dsV, "Venda")

        If dsV.Tables("Venda").Rows.Count > 0 Then
            Me.xCodCliente.Text = dsV.Tables("Venda").Rows(0)("Codigo").ToString
            Me.xNome.Text = dsV.Tables("Venda").Rows(0)("Clientes.Nome").ToString
            Me.xCpfCnpj.Text = dsV.Tables("Venda").Rows(0)("CpfCgc").ToString
            Me.xEndereco.Text = dsV.Tables("Venda").Rows(0)("Endereço").ToString
            Me.xBairro.Text = dsV.Tables("Venda").Rows(0)("Bairro").ToString
            Me.xCidadeEstado.Text = dsV.Tables("Venda").Rows(0)("Cidade").ToString & "-" & dsV.Tables("Venda").Rows(0)("NomeUF").ToString

        End If

        'Carrega o Recebimento

        Dim CmdAPrazo As New OleDb.OleDbCommand
        Dim DAReceber As OleDb.OleDbDataAdapter

        Sql = "SELECT Receber.Documento, Receber.Vencimento, Receber.ValorDocumento, Receber.Cartao, Receber.DocNSU, Receber.codAutenticacao, Receber.DataAutenticacao from Receber Where PedidoProdutos = " & CInt(Me.pPedido.Text) & " and Receber.Baixado = false"

        CmdAPrazo.Connection = CN
        CmdAPrazo.CommandText = Sql

        DAReceber = New OleDb.OleDbDataAdapter(CmdAPrazo)
        DAReceber.Fill(dsV, "Receber")


        Me.ListaReceber.DataSource = dsV.Tables("Receber").DefaultView
        'Me.ListaReceber.Enabled = False
        'Fim do Carregamento do recebimento

        CN.Close()

    End Sub

    Private Sub pPedido_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pPedido.Leave
        LocalizaPedido()
        Me.Cartao.Focus()
    End Sub

    Private Sub btLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLimpar.Click
        Me.pPedido.Clear()
        Me.Cartao.Clear()
        Me.DocNSU.Clear()
        Me.DataAutenticacao.Clear()
        Me.codAutenticacao.Clear()
        Me.pPedido.Focus()
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click

        If Me.Cartao.Text = "" Then
            MessageBox.Show("O usuário deve informar o Código do Cartão", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Cartao.Focus()
            Exit Sub
        End If
        If Me.DocNSU.Text = "" Then
            MessageBox.Show("O usuário deve informar o NSU da Operação", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DocNSU.Focus()
            Exit Sub
        End If
        If Me.codAutenticacao.Text = "" Then
            MessageBox.Show("O usuário deve informar o Código da autenticação", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.codAutenticacao.Focus()
            Exit Sub
        End If
        If Me.DataAutenticacao.Text = "" Then
            MessageBox.Show("O usuário deve informar a data da autenticação", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DataAutenticacao.Focus()
            Exit Sub
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim Sql As String = "Update Receber set CartaoCredito = @CartaoCredito,Cartao = @Cartao, DocNSU = @DocNSU, codAutenticacao = @codAutenticacao, DataAutenticacao = @DataAutenticacao Where PedidoProdutos = " & CInt(Me.pPedido.Text) & " and Receber.Baixado = false"
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@CartaoCredito", True))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@Cartao", Nz(Me.Cartao.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@DocNSU", Nz(Me.DocNSU.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@codAutenticacao", Nz(Me.codAutenticacao.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@DataAutenticacao", Nz(Me.DataAutenticacao.Text, 1)))

        Try
            cmd.ExecuteNonQuery()
            CNN.Close()
            LocalizaPedido()

            Me.Cartao.Clear()
            Me.DocNSU.Clear()
            Me.DataAutenticacao.Clear()
            Me.codAutenticacao.Clear()
            Me.pPedido.Focus()

            MsgBox("Dados do Cartão Atualizado com sucesso", 64, "Validação de Dados")
            GerarLog(Me.Text, AçãoTP.Adicionou, Me.pPedido.Text)
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try



    End Sub


    Private Sub VerLancamentos()
        Dim dsVer As New DataSet

        Dim CN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CN.Open()

        Dim Sql As String = String.Empty

        Dim CmdAPrazo As New OleDb.OleDbCommand
        Dim DAReceber As OleDb.OleDbDataAdapter

        Dim Filtro As String = String.Empty

        If A1.Checked = True Then
            Filtro = " Receber.CodCliente = " & Me.Cliente.Text & " And Receber.Baixado = False and CartaoCredito = true"
        End If
        If A2.Checked = True Then
            Filtro = " Receber.Vencimento Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "# And Receber.Baixado = False and CartaoCredito = true"
        End If
        If A3.Checked = True Then
            Filtro = " Receber.DocNSU = '" & Me.NSUprocura.Text & "' And Receber.Baixado = False and CartaoCredito = true"
        End If
        If A4.Checked = True Then
            Filtro = " Receber.Baixado = False and CartaoCredito = true"
        End If


        Sql = "SELECT Receber.Documento, Receber.Vencimento, Receber.ValorDocumento, Receber.Cartao, Receber.DocNSU, Receber.codAutenticacao, Receber.DataAutenticacao, Receber.ID from Receber Where " & Filtro

        CmdAPrazo.Connection = CN
        CmdAPrazo.CommandText = Sql

        DAReceber = New OleDb.OleDbDataAdapter(CmdAPrazo)
        DAReceber.Fill(dsVer, "VerReceber")


        Me.ListaVer.DataSource = dsVer.Tables("VerReceber").DefaultView
        
        CN.Close()

    End Sub
    
 
    Private Sub SuperTabItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuperTabItem1.Click
        Me.pPedido.Focus()
    End Sub

    Private Sub Cliente_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cliente.Validated
        If Me.Cliente.Text = "" Then
            Exit Sub
        Else
            If String.CompareOrdinal(Me.Cliente.Text, Me.Cliente.TextoAntigo) Then
                LocalizaDadosCliente()
            End If
            VerLancamentos()
        End If
    End Sub

    Public Sub LocalizaDadosCliente()

        If Me.Cliente.Text = "" Then
            Exit Sub
        End If
        'String para filtragem de clientes na base de dados
        Dim Sql As String = "SELECT * FROM Clientes  WHERE Clientes.Empresa =" & CodEmpresa & " AND Clientes.Codigo = " & Me.Cliente.Text

        Dim DBOPEN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        DBOPEN.Open()

        Dim CMD As New OleDb.OleDbCommand(Sql, DBOPEN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.ClienteDesc.Text = DR.Item("Nome") & ""
        End If
        DR.Close()
        DBOPEN.Close()

    End Sub


    Private Sub DataFinal_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataFinal.Validated
        If Me.DataFinal.Text <> "" Then
            If Me.DataInicial.Text = "" Then
                MessageBox.Show("Favor informar a data Inicial", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DataInicial.Focus()
            End If
            VerLancamentos()
        End If
    End Sub


    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged, A4.CheckedChanged

        Me.ListaVer.DataSource = Nothing

        If Me.A1.Checked = True Then
            Me.PainelCliente.Location = New Point(317, 16)
            Me.PainelCliente.Size = New Size(541, 46)
            Me.PainelCliente.Visible = True
            Me.PainelPeriodo.Visible = False
            Me.PainelNSU.Visible = False
            Me.Cliente.Focus()
        End If

        If Me.A2.Checked = True Then
            Me.PainelCliente.Visible = False
            Me.PainelPeriodo.Location = New Point(317, 16)
            Me.PainelPeriodo.Size = New Size(541, 46)
            Me.PainelNSU.Visible = False
            Me.PainelPeriodo.Visible = True
            Me.DataInicial.Focus()
        End If

        If Me.A3.Checked = True Then
            Me.PainelCliente.Visible = False
            Me.PainelPeriodo.Visible = False
            Me.PainelNSU.Visible = True
            Me.PainelNSU.Location = New Point(317, 16)
        End If

        If Me.A4.Checked = True Then
            Me.PainelCliente.Visible = False
            Me.PainelPeriodo.Visible = False
            Me.PainelNSU.Visible = False
            VerLancamentos()
        End If


    End Sub

    Private Sub btFindClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindClientes.Click
        My.Forms.ClientesProcura.ShowDialog()
        Me.Cliente.Focus()
    End Sub

    Private Sub Cliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cliente.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ClientesProcura.ShowDialog()
        End If
    End Sub

    Private Sub btVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVisualizar.Click

        If Me.ListaVer.RowCount = 0 Then
            Exit Sub
        Else

            Dim Tel As New Form() ' Create a new instance of the form.

            'TelaCr = Tel
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
            VerRelat.Load(DirRelat & "RelReceberCartao.rpt")
            VerRelat.DataSourceConnections.Item(0).SetConnection("", LocalBD & Nome_BD, False)
            VerRelat.DataSourceConnections.Item(0).SetLogon("", Crypto.clsCrypto(SenhaBancoDados, False))


            Dim Filtro As String = String.Empty

            If A1.Checked = True Then
                Filtro = "{Receber.CodCliente} = " & Me.Cliente.Text & " And {Receber.Baixado} = False and {Receber.CartaoCredito} = true"
            End If
            If A2.Checked = True Then
                Filtro = "{Receber.Vencimento}>=Date (" & Format(CDate(Me.DataInicial.Text), "yyyy,MM,dd") & ") and {Receber.Vencimento}<=date (" & Format(CDate(Me.DataFinal.Text), "yyyy,MM,dd") & ") And {Receber.Baixado} = False and {Receber.CartaoCredito} = true"
            End If
            If A3.Checked = True Then
                Filtro = "{Receber.DocNSU} = '" & Me.NSUprocura.Text & "' And {Receber.Baixado} = False and {Receber.CartaoCredito} = true"
            End If
            If A4.Checked = True Then
                Filtro = "{Receber.Baixado} = False and {Receber.CartaoCredito} = true"
            End If

            VerRelat.DataDefinition.RecordSelectionFormula = Filtro

            Vz.ReportSource = VerRelat

            Tel.Controls.Add(Vz)

            Tel.ShowDialog()

        End If


    End Sub

    Private Sub ListaVer_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListaVer.CellDoubleClick

        If Len(CaixaAtivo) <> 4 Then
            MessageBox.Show("O usuário deve selecionar um caixa antes de baixar o documento", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If MsgBox("Deseja Ativar o caixa agora", 36, "Validação de Dados") = 6 Then
                TRVDados(UserAtivo, "CaixaAtivarDesativar")
                If Ina = True Then
                    MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
                    Exit Sub
                Else
                    My.Forms.CaixaAtivarDesativar.ShowDialog()
                    ListaVer_CellDoubleClick(sender, e)
                End If
            End If
            Exit Sub
        End If

        If NzZero(Me.ListaVer.CurrentRow.Cells("cID").Value) = 0 Then
            Exit Sub
        End If

        My.Forms.ReceberBaixa.AchaRegistro(Me.ListaVer.CurrentRow.Cells("cID").Value)
        My.Forms.ReceberBaixa.ShowDialog()
        VerLancamentos()
    End Sub

   
    Private Sub xCodCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xCodCliente.Click

    End Sub

    Private Sub NSUprocura_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NSUprocura.Validated
        If Me.NSUprocura.Text = "" Then
            Exit Sub
        Else
            VerLancamentos()
        End If
    End Sub
End Class