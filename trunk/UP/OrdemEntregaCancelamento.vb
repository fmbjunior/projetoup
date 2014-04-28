Public Class OrdemEntregaCancelamento

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub OrdemEntregaCancelamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Insert Then
            TRVDados(UserAtivo, "CodigoSegurança")
            If Ina = True Then
                MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
                Exit Sub
            Else
                My.Forms.CodigoSegurança.ShowDialog()
            End If
        End If
    End Sub

   
    Private Sub btCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelar.Click

        If Len(CaixaAtivo) <> 4 Then
            MessageBox.Show("O usuario deve selecionar um caixa antes de Cancelar uma Ordem de Entrega. Verifique", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.OrdemEntrega.Text = "" Then
            MsgBox("Não foi informado ordem de entrega para o cancelamento.", 64, "Validação de Dados")
            Exit Sub
        End If

        Dim HH As DateTime = Now
        Dim CodSegurança As String = InformaCodigoSeguranca()

        If VerificaCodigoSegurança(CodSegurança) = False Then
            MsgBox("Código de Segurança inválido, Verifique.", 64, "Validação de Dados")
            Exit Sub
        Else

            Dim PedidoDaOrdem As Integer

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

            CNN.Open()

            Dim Sql As String


            Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
            Dim cmd As OleDb.OleDbCommand = CNN.CreateCommand
            cmd.Transaction = Transacao

            'Procura a ordem para o cancelamento
            cmd.CommandText = "Select * from OrdemEntrega Where OrdemEntrega.Ordem = " & Me.OrdemEntrega.Text
            Dim DR As OleDb.OleDbDataReader
            DR = cmd.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                MsgBox("Não foi encontrada a ordem de embarque selecionada, verifique", 64, "Validação de Dados")
                Exit Sub
            Else
                PedidoDaOrdem = DR.Item("Pedido")
            End If
            DR.Close()


            Try

                'Volta a Qtd retirada do Pedido
                Sql = "UPDATE (OrdemEntrega INNER JOIN OrdemEntregaItens ON OrdemEntrega.Ordem = OrdemEntregaItens.Ordem) INNER JOIN ItensPedido ON (OrdemEntregaItens.Pedido = ItensPedido.PedidoSequencia) AND (OrdemEntregaItens.Produto = ItensPedido.CodigoProduto) SET ItensPedido.QtdRetirada = [QtdRetirada]-[OrdemEntregaItens].[Qtd] WHERE (((OrdemEntrega.Ordem)=" & Me.OrdemEntrega.Text & "));"
                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()

                'Deleta o estoque retirado e Atualiza cadastro de Produto
                Sql = "UPDATE (Produtos INNER JOIN OrdemEntregaItens ON Produtos.CodigoProduto = OrdemEntregaItens.Produto) INNER JOIN OrdemEntrega ON OrdemEntregaItens.Ordem = OrdemEntrega.Ordem SET Produtos.QuantidadeEstoque = [QuantidadeEstoque]+[Qtd] WHERE (((OrdemEntregaItens.Ordem)=" & Me.OrdemEntrega.Text & ") AND ((Produtos.ControlaEstoque)='SIM') AND ((OrdemEntrega.Confirmado)='S'));"
                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()

                Sql = "Delete * From EstoqueUP Where Prg = 'OrdemEntrega' and PedidoOrdem = " & Me.OrdemEntrega.Text
                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()

                'Deleta Itens da ordem de Embarque
                Sql = "Delete * From OrdemEntregaItens Where Ordem = " & Me.OrdemEntrega.Text
                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()

                'Cancela a ordem de embarque
                Sql = "UPDATE OrdemEntrega SET OrdemEntrega.Cancelada = True WHERE OrdemEntrega.Ordem = " & Me.OrdemEntrega.Text
                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()

                Transacao.Commit()
                MessageBox.Show("Ordem de Embarque cancelada com sucesso.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GerarLog(Me.Text, AçãoTP.Excluiu, Me.OrdemEntrega.Text)
                CNN.Close()
                AtStatusPedido(PedidoDaOrdem)
                Me.OrdemEntrega.Clear()
                Me.OrdemEntrega.Focus()


            Catch ex As Exception
                Transacao.Rollback()
                CNN.Close()
                MsgBox(ex.Message, 64, "Validação de Dados")
                MsgBox("Erro ao cancelar a Ordem de Embarque, tente cancelar novamente ou consulte o administrador.", 64, "Validação de Dados")
                Exit Sub
            End Try
        End If
    End Sub



    Private Sub AtStatusPedido(ByVal Pedido As Integer)
        Me.Cursor = Cursors.WaitCursor

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim ds As New DataSet()

        Dim Sql As String = String.Empty

        Sql = "SELECT Pedido.PedidoSequencia, Pedido.StatusAndamentos FROM(Pedido) WHERE (((Pedido.PedidoSequencia)=" & Pedido & ") AND ((Pedido.StatusAndamentos)<>'FINALIZADO' Or (Pedido.StatusAndamentos) Is Null));"

        Dim DAPedidos As New OleDb.OleDbDataAdapter(Sql, CNN)
        DAPedidos.Fill(ds, "Pedidos")

        Sql = "SELECT Pedido.StatusAndamentos, ItensPedido.PedidoSequencia, Sum(ItensPedido.Qtd) AS SomaDeQtd, Sum(ItensPedido.QtdRetirada) AS SomaDeQtdRetirada FROM Pedido INNER JOIN ItensPedido ON Pedido.PedidoSequencia = ItensPedido.PedidoSequencia GROUP BY Pedido.StatusAndamentos, ItensPedido.PedidoSequencia HAVING (((Pedido.StatusAndamentos)<>'FINALIZADO' Or (Pedido.StatusAndamentos) Is Null) AND ((ItensPedido.PedidoSequencia)=" & Pedido & "));"
        Dim DAItens As New OleDb.OleDbDataAdapter(Sql, CNN)
        DAItens.Fill(ds, "ItensPedidos")


        Dim Status As String = String.Empty

        Dim DrItem As DataRow
        For Each DrItem In ds.Tables("ItensPedidos").Rows
            Dim DrPedido() As DataRow
            DrPedido = ds.Tables("Pedidos").Select("PedidoSequencia = " & DrItem("PedidoSequencia").ToString)

            Dim TBL As DataTable
            TBL = ds.Tables("Pedidos")

            If DrItem("SomaDeQtdRetirada") = 0 Then Status = "INICIAL"
            If DrItem("SomaDeQtdRetirada") > 0 And DrItem("SomaDeQtdRetirada") < DrItem("SomaDeQtd") Then Status = "EM ANDAMENTO"
            If DrItem("SomaDeQtdRetirada") = DrItem("SomaDeQtd") Then Status = "FINALIZADO"

            If DrPedido.Length <> 0 Then
                DrPedido(0).BeginEdit()
                DrPedido(0)("StatusAndamentos") = Status
                DrPedido(0).EndEdit()

                If Status = "FINALIZADO" Then
                    If PedidoOS.Visible = True Then
                        My.Forms.PedidoOS.StatusAndamentos.Text = Status
                    Else
                        My.Forms.PedidoVenda.StatusAndamentos.Text = Status
                    End If
                End If
            End If
        Next

        Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAPedidos)
        DAPedidos.Update(ds, "Pedidos")

        DAPedidos.Dispose()
        ds.Dispose()
        CNN.Close()

        Me.Cursor = Cursors.Default

    End Sub


    
End Class