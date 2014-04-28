Imports System.Data.OleDb
Imports System.IO
Public Class PedidoVendaConfirmarOutrosOS
    Dim Ação As New TrfGerais


    Private OperationItensOutros As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2


    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Dim EstoqueGeral As New EstoqueAtualizar
        EstoqueGeral.Run_AtualizadorEstoquePedido(My.Forms.PedidoOS.PedidoSequencia.Text)

        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub PedidoVendaConfirmarOutros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TotalPedido.Text = My.Forms.PedidoOS.TPedido.Text
    End Sub


    Private Sub btConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConfirmar.Click



        If Me.TotalPedido.Text = "" Then
            MsgBox("o Valor do Pedido não foi importado, verifique...", 64, "Validação de Dados")
            Me.TotalPedido.Focus()
            Exit Sub
        End If

        If MsgBox("Deseja Finalizar o Pedido/Venda", 36, "Validação de Dados") = 6 Then

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = ""

            Dim Transacao As OleDbTransaction = CNN.BeginTransaction()
            Dim Cmd As OleDbCommand = CNN.CreateCommand()
            Dim CmdAtItens As OleDbCommand = CNN.CreateCommand
            Dim CmdEstoque As OleDbCommand = CNN.CreateCommand



            Cmd.Transaction = Transacao
            CmdAtItens.Transaction = Transacao
            CmdEstoque.Transaction = Transacao


            Try

                'Atualizar o pedido confirmando
                Dim StatusPed As String
                If My.Forms.PedidoOS.TipoEntrega.Text = "IMEDIATA" Then
                    'Entrega Imediata atualiza a quantidade de entrega para quantidade do item
                    Sql = "UPDATE ItensPedido SET ItensPedido.QtdRetirada = [Qtd] WHERE (((ItensPedido.PedidoSequencia)=" & My.Forms.PedidoOS.PedidoSequencia.Text & "));"
                    CmdAtItens.CommandText = Sql
                    CmdAtItens.ExecuteNonQuery()

                    StatusPed = "FINALIZADO"
                Else
                    StatusPed = "INICIAL"
                End If

                Sql = "Update Pedido  set Confirmado = @1, DataFechamento = @2, StatusAndamentos = @3 Where PedidoSequencia = " & My.Forms.PedidoOS.PedidoSequencia.Text
                Cmd.CommandText = Sql

                Cmd.Parameters.Add(New OleDb.OleDbParameter("@1", True))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", DataDia))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", StatusPed))
                Cmd.ExecuteNonQuery()


                'Atualizar estoque Tabela EstoqueUp
                If My.Forms.PedidoOS.TipoEntrega.Text = "IMEDIATA" Then
                    Sql = "INSERT INTO EstoqueUP (CodigoProduto, Qtd, Tipo, IdLancamento, DataLancamento, PedidoOrdem, Prg, ClienteFornecedor, NFDoc) SELECT ItensPedido.CodigoProduto, [Qtd]*-1 AS QtdEst, 'S' AS Expr1, 0 AS Expr2, Pedido.DataFechamento, Pedido.PedidoSequencia, 'PedidoOS' AS Expr3,'" & My.Forms.PedidoOS.NomeCliente.Text & "' AS Expr4, '" & My.Forms.PedidoOS.PedidoSequencia.Text & "' As Expr5 FROM (ItensPedido INNER JOIN Pedido ON ItensPedido.PedidoSequencia = Pedido.PedidoSequencia) INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto WHERE (((ItensPedido.PedidoSequencia)=" & My.Forms.PedidoOS.PedidoSequencia.Text & ") AND ((Pedido.Empresa)=" & CodEmpresa & ") AND ((Produtos.ControlaEstoque)='SIM'));"
                    CmdEstoque.CommandText = Sql
                    CmdEstoque.ExecuteNonQuery()
                End If

                'Throw New System.Exception()
                Transacao.Commit()


                My.Forms.PedidoOS.Confirmado.Checked = True
                My.Forms.PedidoOS.ConfImg.Visible = True

                MsgBox("Pedido confirmado com sucesso", 64, "Validação de Dados")

                If My.Forms.PedidoOS.TipoEntrega.Text = "IMEDIATA" Then
                    'Atualizar o Estoque do Cadastro de Produtos
                    Dim EstoqueGeral As New EstoqueAtualizar
                    EstoqueGeral.Run_AtualizadorEstoquePedido(My.Forms.PedidoOS.PedidoSequencia.Text)
                End If

                My.Forms.PedidoOS.TabPedido.SelectedTab = My.Forms.PedidoOS.TabCliente


            Catch ex As Exception
                Transacao.Rollback()
                MsgBox(ex.Message, 64, "Validação de Dados")
                MsgBox("Erro ao confirmar o Pedido, tente novamente confirmar ou consulte o administrador.", 64, "Validação de Dados")
            End Try
            CNN.Close()
            Me.Close()
            Me.Dispose()

        End If

    End Sub

    Private Sub ValorAVista_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TotalPedido.Validated
        If Me.TotalPedido.Text = "" Then Me.TotalPedido.Text = FormatCurrency(0, 2)
    End Sub

End Class