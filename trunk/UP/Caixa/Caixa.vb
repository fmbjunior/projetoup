Imports System.Data.OleDb
Public Class Caixa
  
    Dim VlrLancamentos As Double

    Private Sub Caixa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DataCaixa.Text = DataDia
        If Len(CaixaAtivo) = 4 Then Me.CaixaCod.Text = CaixaAtivo

        If Len(CaixaAtivo) <> 4 Then
            Me.btAtivarCaixa.Visible = True
        Else
            Me.btAtivarCaixa.Visible = False
        End If
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAtualizar.Click
        If Me.DataCaixa.Text = "" Then Exit Sub

        MostraCaixa()

        Dim THRD As New Threading.Thread(AddressOf MostraCheque)
        THRD.Priority = Threading.ThreadPriority.Highest
        THRD.IsBackground = True
        THRD.Start()

    End Sub

    Public Sub MostraCaixa()
        If Me.CaixaCod.Text = "" Then
            MessageBox.Show("O usuário deve informar o código do caixa.", "Validação de Dados.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.DataCaixa.Text = "" Then
            MessageBox.Show("O usuário deve informar a data do caixa.", "Validação de Dados.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from CaixaDia Where DataCaixaDia = #" & Format(CDate(Me.DataCaixa.Text), "MM/dd/yyy") & "# And CaixaCod = '" & Me.CaixaCod.Text & "' And Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.SaldoAnterior.Text = FormatNumber(DR.Item("SaldoDiaAnterior"), 2)

            If DR.Item("Fechado") = True Then
                Me.DisplayFechado.Visible = True
                Me.DisplayAberto.Visible = False
            Else
                Me.DisplayFechado.Visible = False
                Me.DisplayAberto.Visible = True
                Me.DisplayAberto.Location = New Point(599, 9)
            End If
            DR.Close()
            CNN.Close()

            CarregaItens()

            Me.SaldoAtual.Text = FormatCurrency(CDbl(NzZero(Me.SaldoAnterior.Text) + VlrLancamentos), 2)

        Else
            MessageBox.Show("Não existe caixa para este código neste dia, Verifique.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DR.Close()
            CNN.Close()
            Exit Sub
        End If

    End Sub

    Private Sub CarregaItens()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        'Sql = "Select Id, ContaCorrente, DataLancamento, Documento, DataDocumento, Favorecido, Historico, ValorDocumento, Empresa, IdLancamento, IdProcura, Tipo from LancamentoBanco Where DataLancamento = #" & Format(CDate(Me.DataCaixa.Text), "MM/dd/yyy") & "# And ContaCorrente = '" & Me.CaixaCod.Text & "' and Tipo = 'CAIXA' And Empresa = " & CodEmpresa
        Sql = "SELECT Id, ContaCorrente, DataLancamento, Documento, DataDocumento, Favorecido, Historico, ValorDocumento, IdLancamento, IdProcura, Tipo, ContaBalancete,ContasG3.DescContaGrupo3 FROM LancamentoBanco Left JOIN ContasG3 ON LancamentoBanco.ContaBalancete = ContasG3.ContaGrupo3 WHERE (((LancamentoBanco.[DataLancamento])=#" & Format(CDate(Me.DataCaixa.Text), "MM/dd/yyy") & "#) AND ((LancamentoBanco.ContaCorrente)='" & Me.CaixaCod.Text & "') AND ((LancamentoBanco.Tipo)='CAIXA') AND ((LancamentoBanco.Empresa)=" & CodEmpresa & "))"




        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        VlrLancamentos = NzZero(ds.Tables("Table").Compute("sum(ValorDocumento)", ""))
        Me.Lista.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        ds.Dispose()
        Cnn.Close()

    End Sub

    Private Sub btLancamentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLancamentos.Click

        Dim cxFechado As New CaixaFechado
        cxFechado.CaixaEstaFechado()

        If Len(CaixaAtivo) <> 4 Then
            MessageBox.Show("O usuário deve selecionar um caixa para fazer o lançamento.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.SaldoAtual.Text = "" Then btAtualizar_Click(sender, e)

        If Me.DisplayFechado.Visible = True Then
            MessageBox.Show("O usuário não pode fazer um novo lançamento em um caixa fechado, Verifique.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        My.Forms.CaixaLançamentos.ShowDialog()
    End Sub

    Private Sub btFecharCX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFecharCX.Click

        If Me.CaixaCod.Text = "" Then Exit Sub

        If Me.SaldoAtual.Text = "" Then btAtualizar_Click(sender, e)

        If Me.DisplayFechado.Visible = True Then
            MessageBox.Show("O usuário não pode Fechar este caixa, pois o mesmo já foi Fechado, Verifique.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Verifica se tem Pedidos em abertos para este dia e verifica se o caixa é o caixa de movimento

        If Me.CaixaCod.Text = CaixaDeMovimento Then
            Dim Ds As New DataSet

            Dim CN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CN.Open()

            Dim Sql As String = "SELECT Pedido.PedidoSequencia, Pedido.DataPedido, Pedido.Inativo, Pedido.Confirmado, Pedido.Empresa FROM Pedido  WHERE Pedido.DataPedido = #" & Format(CDate(Me.DataCaixa.Text), "MM/dd/yyyy") & "# AND Pedido.Inativo = False AND Pedido.Confirmado = False AND Pedido.Empresa = " & CodEmpresa


            Dim CMD As New OleDb.OleDbCommand(Sql, CN)
            Dim DaPendentes As New OleDb.OleDbDataAdapter(CMD)

            DaPendentes.Fill(Ds, "Pendentes")

            If Ds.Tables("Pendentes").Rows.Count > 0 Then
                MessageBox.Show("Existem pedido a serem confirmados para o dia informado, confirme os pedido ou cancele para fechar o caixa", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DataCaixa.Focus()
                Exit Sub
            End If
        End If


        My.Forms.CaixaFechar.ShowDialog()

        'RelatorioCarregar = "RelCaixa"
        'My.Forms.VisualizadorRelatorio.ShowDialog()

        'Me.btFecharCX.Enabled = False
        'Me.btLancamentos.Enabled = False
        'Me.btAtualizar.Enabled = False


    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImprimir.Click
        If Me.SaldoAtual.Text = "" Then btAtualizar_Click(sender, e)

        RelatorioCarregar = "RelCaixa"
        My.Forms.VisualizadorRelatorio.ShowDialog()

    End Sub

#Region "Carrega dados dos Cheques"
    Delegate Sub myDelegate()

    Private Sub MostraCheque()
        If Me.CaixaCod.Text = "" Then
            Exit Sub
        End If

        If Me.InvokeRequired Then
            Me.Invoke(New myDelegate(AddressOf EncheListaCheque))
        End If
    End Sub

    Private Sub EncheListaCheque()
        Dim CnnTRD As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CnnTRD.Open()

        Dim Sql As String = String.Empty


        Sql = "SELECT ArquivoCheque.Cheque, ArquivoCheque.CC, Clientes.Nome, ArquivoCheque.Titular, ArquivoCheque.EntreguePor, ArquivoCheque.ValorCh, ArquivoCheque.Vencimento FROM ArquivoCheque LEFT JOIN Clientes ON ArquivoCheque.Cliente = Clientes.Codigo WHERE ArquivoCheque.DataBaixa Is Null And ArquivoCheque.CaixaCheque = '" & Me.CaixaCod.Text & "'"

        Dim da = New OleDb.OleDbDataAdapter(Sql, CnnTRD)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.ListaCheque.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        CnnTRD.Close()

    End Sub
#End Region

    Private Sub TodosOsChequeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodosOsChequeToolStripMenuItem.Click
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = String.Empty


        Sql = "SELECT ArquivoCheque.Cheque, ArquivoCheque.CC, Clientes.Nome, ArquivoCheque.Titular, ArquivoCheque.EntreguePor, ArquivoCheque.ValorCh, ArquivoCheque.Vencimento FROM ArquivoCheque LEFT JOIN Clientes ON ArquivoCheque.Cliente = Clientes.Codigo WHERE (((ArquivoCheque.CaixaCheque)='" & Me.CaixaCod.Text & "')) And ArquivoCheque.Historico <> 'BAIXADO' ;"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.ListaCheque.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub TodosDoDiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodosDoDiaToolStripMenuItem.Click
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = String.Empty

        Sql = "SELECT ArquivoCheque.Cheque, ArquivoCheque.CC, Clientes.Nome, ArquivoCheque.Titular, ArquivoCheque.EntreguePor, ArquivoCheque.ValorCh, ArquivoCheque.Vencimento FROM ArquivoCheque LEFT JOIN Clientes ON ArquivoCheque.Cliente = Clientes.Codigo WHERE (((ArquivoCheque.CaixaCheque)='" & Me.CaixaCod.Text & "') AND ((ArquivoCheque.DataLancamento) = #" & Format(CDate(Me.DataCaixa.Text), "MM/dd/yyyy") & "#));"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.ListaCheque.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub btChequeDia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btChequeDia.Click
        Dim X As New Point(30, 0)
        Me.ContextMenuCheque.Show(Me.btChequeDia, X)
    End Sub

    Private Sub btRepasseCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRepasseCheque.Click
        TRVDados(UserAtivo, "CaixaRepasseCheque")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.CaixaRepasseCheque.ShowDialog()
        End If
    End Sub

    Private Sub btTransferencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTransferencia.Click

        Dim cxFechado As New CaixaFechado
        cxFechado.CaixaEstaFechado()

        If Me.DisplayFechado.Visible = True Then
            MessageBox.Show("Este caixa já foi finalizado e não pode mais executar esta operação.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        My.Forms.CaixaTransferencia.ShowDialog()
    End Sub

    Private Sub btAtivarCaixa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAtivarCaixa.Click
        If Len(CaixaAtivo) <> 4 Then
            If MsgBox("Deseja Ativar o caixa agora", 36, "Validação de Dados") = 6 Then
                TRVDados(UserAtivo, "CaixaAtivarDesativar")
                If Ina = True Then
                    MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
                    Exit Sub
                Else
                    My.Forms.CaixaAtivarDesativar.ShowDialog()
                    If Len(CaixaAtivo) = 4 Then
                        Me.DataCaixa.Text = DataDia
                        If Len(CaixaAtivo) = 4 Then Me.CaixaCod.Text = CaixaAtivo
                        btAtualizar_Click(sender, e)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btCaixasAberto_Click(sender As Object, e As EventArgs) Handles btCaixasAberto.Click
        My.Forms.CaixasAbertos.ShowDialog()
    End Sub

    Private Sub ButtonX1_Click_1(sender As Object, e As EventArgs) Handles ButtonX1.Click
        My.Forms.DiaAbrirFechar.ShowDialog()
    End Sub
End Class