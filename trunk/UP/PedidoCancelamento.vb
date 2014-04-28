Imports System.Data.OleDb

Public Class PedidoCancelamentoOS

    Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        CNN.Close()
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub btCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelar.Click


        If Len(CaixaAtivo) <> 4 Then
            MessageBox.Show("O usuario deve selecionar um caixa antes de baixar um documento. Verifique", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.Pedido.Text = "" Then
            MessageBox.Show("Não foi informado o numero do Pedido, Verifique", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim FoiConfirmado As Boolean = False
        Dim éDevolução As Boolean = False

        Dim HH As DateTime = Now

   
        'Dim CodSegurança As String = InformaCodigoSeguranca()

        'If VerificaCodigoSegurança(CodSegurança) = False Then
        '    MsgBox("Código de Segurança inválido, Verifique.", 64, "Validação de Dados")
        '    Exit Sub
        'End If


        Dim Autorizado As Boolean = PedirPermissao(Me.Text, Me.Pedido.Text)
        Autorizado = varAutorizado
        If Autorizado = False Then
            Exit Sub
        End If


        Dim Sql As String = "Select * from Pedido where PedidoSequencia = " & Me.Pedido.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()


        Dim CodCli As String = String.Empty
        Dim TotPedido As Double = 0
        Dim nPedidoVenda As String = String.Empty
        If DR.HasRows = True Then
            FoiConfirmado = DR.Item("Confirmado")
            If DR.Item("PedidoTipo") = "DEVOLUÇÃO" Then
                MessageBox.Show("Não pode ser cancelado um pedido de devolução, Refaça a venda para corrigir se necessário ", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
                éDevolução = True
                CodCli = DR.Item("CódigoCliente")
                TotPedido = DR.Item("TotalPedido")
                nPedidoVenda = DR.Item("DevNumero")
            End If

            If DR.Item("Inativo") = True Then
                MessageBox.Show("Este Pedido já foi inativado, Verifique ou escolha outro.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If Not IsDBNull(DR.Item("DataFechamento")) Then
                If DR.Item("Confirmado") = True And CDate(DR.Item("DataFechamento")) <> DataDia Then
                    MessageBox.Show("Este pedido já foi confirmado em outro dia, não pode ser cancelado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

        Else
            MessageBox.Show("Este Pedido não foi encontrado, verifique ou escolha outro.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        DR.Close()


        'Verificar se existe pagamento feito
        Sql = "SELECT Receber.ID, Receber.PedidoProdutos, Receber.ValorDocumento, Receber.ValorLiquido, Receber.Vencimento, Receber.Recebimento, Receber.Baixado FROM(Receber) WHERE (((Receber.PedidoProdutos)=" & Me.Pedido.Text & ") AND ((Receber.Baixado)=True));"
        CMD = New OleDb.OleDbCommand(Sql, CNN)
        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows = True Then
            MessageBox.Show("Existe recebimento para este pedido não pode ser cancelado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        DR.Close()

        'Verifica se existe ordem de entrega
        Sql = "SELECT OrdemEntrega.Ordem, OrdemEntrega.Pedido, OrdemEntrega.Cancelada, OrdemEntrega.Confirmado FROM(OrdemEntrega) WHERE (((OrdemEntrega.Pedido)=" & Me.Pedido.Text & ") AND ((OrdemEntrega.Cancelada)=False) AND ((OrdemEntrega.Confirmado)='S'));"
        Dim CmdOrdem As New OleDb.OleDbCommand(Sql, CNN)
        Dim DrOrdem As OleDb.OleDbDataReader

        DrOrdem = CmdOrdem.ExecuteReader
        DrOrdem.Read()

        If DrOrdem.HasRows = True Then
            MessageBox.Show("Existe Ordem de Entrega confirmada neste Pedido, não pode ser cancelado." & Chr(13) & "Cancele todas as Ordem depois cancele o Pedido.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        DrOrdem.Close()


        Dim Transacao As OleDbTransaction = CNN.BeginTransaction()
        Dim CmdReceber As OleDbCommand = CNN.CreateCommand()
        Dim CmdCheque As OleDbCommand = CNN.CreateCommand()
        Dim CmdPedido As OleDbCommand = CNN.CreateCommand()
        Dim CmdEstoque As OleDbCommand = CNN.CreateCommand()
        Dim CmdEstProd As OleDbCommand = CNN.CreateCommand
        Dim CmdCaixa As OleDbCommand = CNN.CreateCommand
        Dim CmdComissao As OleDbCommand = CNN.CreateCommand
        Dim CmdCred As OleDbCommand = CNN.CreateCommand

        CmdReceber.Transaction = Transacao
        CmdCheque.Transaction = Transacao
        CmdPedido.Transaction = Transacao
        CmdEstoque.Transaction = Transacao
        CmdEstProd.Transaction = Transacao
        CmdCaixa.Transaction = Transacao
        CmdComissao.Transaction = Transacao
        CmdCred.Transaction = Transacao

        Try

            If FoiConfirmado = True Then
                Sql = "DELETE EstoqueUP.PedidoOrdem, EstoqueUP.Prg FROM(EstoqueUP) WHERE (((EstoqueUP.PedidoOrdem)=" & Me.Pedido.Text & ") AND ((EstoqueUP.Prg)='PedidoVenda' or (EstoqueUP.Prg)='SELLSHOES'));"
                CmdEstoque.CommandText = Sql
                CmdEstoque.ExecuteNonQuery()

                Sql = "UPDATE Produtos INNER JOIN ItensPedido ON Produtos.CodigoProduto = ItensPedido.CodigoProduto SET Produtos.QuantidadeEstoque = [QuantidadeEstoque]+[Qtd] WHERE (((ItensPedido.PedidoSequencia)=" & Me.Pedido.Text & ") AND ((Produtos.ControlaEstoque)='SIM'));"
                CmdEstProd.CommandText = Sql
                CmdEstProd.ExecuteNonQuery()

                'Fazer o extorno das comissoes referente ao Pedido
                Sql = "INSERT INTO FuncionarioComissao ( DataLancamento, DataDocumento, Funcionario, Documento, PedidoVenda, Produto, Percentual, ValorDocumento, ValorComissao, TipoComissao, ComissaoFaturamento, OndeVeio, IdOrigem, DescComissao ) SELECT #" & Format(CDate(DataDia), "MM/dd/yyyy") & "# AS DataLanc, FuncionarioComissao.DataDocumento, FuncionarioComissao.Funcionario, FuncionarioComissao.Documento, FuncionarioComissao.PedidoVenda, FuncionarioComissao.Produto, FuncionarioComissao.Percentual, FuncionarioComissao.ValorDocumento *-1, [ValorComissao]*-1 AS ComissaoEXT, FuncionarioComissao.TipoComissao, FuncionarioComissao.ComissaoFaturamento, FuncionarioComissao.OndeVeio, FuncionarioComissao.IdOrigem, 'EXT. CANC. ' & [DescComissao] AS DescComissaoEXT FROM(FuncionarioComissao) WHERE (((FuncionarioComissao.OndeVeio)='PEDIDO') AND ((FuncionarioComissao.IdOrigem)=" & Me.Pedido.Text & "));"
                CmdComissao.CommandText = Sql
                CmdComissao.ExecuteNonQuery()
                'Fim
            End If

            If éDevolução = True Then

                Dim SqlCred As String = "INSERT INTO ClienteCred (Cliente, DescCred, DataCred, VencimentoCred, ValorCred, Empresa, Confirmado) VALUES (@1, @2, @3, @4, @5, @6, @7)"
                CmdCred.CommandText = SqlCred

                Dim VlrDV As Double = Nz((CDbl(TotPedido)), 3)

                CmdCred.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(CodCli, 1)))
                CmdCred.Parameters.Add(New OleDb.OleDbParameter("@2", Nz("EXTORNO CRED. DEV: " & Nz(Me.Pedido.Text, 1), 1)))
                CmdCred.Parameters.Add(New OleDb.OleDbParameter("@3", CDate(DataDia)))
                CmdCred.Parameters.Add(New OleDb.OleDbParameter("@4", CDate(DataDia)))
                CmdCred.Parameters.Add(New OleDb.OleDbParameter("@5", VlrDV))
                CmdCred.Parameters.Add(New OleDb.OleDbParameter("@6", CodEmpresa))
                CmdCred.Parameters.Add(New OleDb.OleDbParameter("@7", True))
                CmdCred.ExecuteNonQuery()

                'Retornar a quantidade devolvida

                Dim ds As New DataSet

                Dim CmdItensDevolvido As OleDb.OleDbCommand = CNN.CreateCommand

                CmdItensDevolvido.Transaction = Transacao

                Sql = "SELECT * from ItensPedido Where PedidoSequencia  = " & nPedidoVenda
                Dim CmdItVenda As New OleDb.OleDbCommand(Sql, CNN)
                CmdItVenda.Transaction = Transacao
                Dim DAItVenda As New OleDb.OleDbDataAdapter(CmdItVenda)
                DAItVenda.Fill(ds, "ItVenda")

                Sql = "SELECT * from ItensPedido Where PedidoSequencia  = " & Me.Pedido.Text
                Dim CmdItDev As New OleDb.OleDbCommand(Sql, CNN)
                CmdItDev.Transaction = Transacao
                Dim DAItDev As New OleDb.OleDbDataAdapter(CmdItDev)
                DAItDev.Fill(ds, "ItDev")

                Dim DrLinha As DataRow
                For Each DrLinha In ds.Tables("ItDev").Rows
                    Dim DrLinhaIten() As DataRow
                    DrLinhaIten = ds.Tables("ItVenda").Select("Id = " & DrLinha("DevolvidoId").ToString)

                    If DrLinhaIten.Length <> 0 Then
                        DrLinhaIten(0).BeginEdit()
                        DrLinhaIten(0)("QtdDevolvido") -= DrLinha("Qtd").ToString

                        If DrLinhaIten(0)("QtdDevolvido") <> DrLinhaIten(0)("Qtd") Then
                            DrLinhaIten(0)("Devolvido") = False
                        End If

                        DrLinhaIten(0).EndEdit()
                    End If

                Next
                Dim objIt As New OleDb.OleDbCommandBuilder(DAItVenda)
                DAItVenda.Update(ds, "ItVenda")

            End If

            Sql = "Delete * from Receber Where PedidoProdutos = " & Me.Pedido.Text
            CmdReceber.CommandText = Sql
            CmdReceber.ExecuteNonQuery()

            Sql = "Delete * from ArquivoCheque Where Pedido = " & Me.Pedido.Text
            CmdCheque.CommandText = Sql
            CmdCheque.ExecuteNonQuery()

            Sql = "Update Pedido set Confirmado = False, Inativo = True, DataFechamento = #" & Format(CDate(DataDia), "MM/dd/yyyy") & "# Where PedidoSequencia = " & Me.Pedido.Text
            CmdPedido.CommandText = Sql
            CmdPedido.ExecuteNonQuery()

            Sql = "DELETE LancamentoBanco.Id FROM LancamentoBanco WHERE LancamentoBanco.Tipo ='CAIXA' AND LancamentoBanco.IdLancamento = 'PEDIDO' AND LancamentoBanco.IdProcura = " & Me.Pedido.Text
            CmdCaixa.CommandText = Sql
            CmdCaixa.ExecuteNonQuery()









            Transacao.Commit()
            CNN.Close()

            MessageBox.Show("Pedido cancelado....Verifique se não existe erro no caixa.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ErroLivre = "Pedido cancelado com sucesso"
            GerarLog(Me.Text, AçãoTP.Livre, Me.Pedido.Text)


            If My.Forms.PedidoVenda.Visible = True Then
                My.Forms.PedidoVenda.Close()
                My.Forms.PedidoVenda.Dispose()

            End If
            Me.Close()
            Me.Dispose()

        Catch ex As Exception
            Transacao.Rollback()
            CNN.Close()
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try

    End Sub


    Private Sub PedidoCancelamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CNN.Open()
        If My.Forms.PedidoVenda.Visible = True Then
            Me.Pedido.Text = My.Forms.PedidoVenda.PedidoSequencia.Text
        End If
    End Sub


End Class