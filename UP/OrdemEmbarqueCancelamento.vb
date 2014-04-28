Public Class OrdemEmbarqueCancelamento

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub OrdemEmbarqueCancelamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        If Me.OrdemEmbarque.Text = "" Then
            MsgBox("Não foi informado ordem de Embarque para o cancelamento.", 64, TituloMsgbox)
            Exit Sub
        End If

        Dim HH As DateTime = Now
        Dim CodSegurança As String = InputBox("Favor informar o Código de Segurança.", TituloMsgbox, 0)

        If VerificaCodigoSegurança(CodSegurança) = False Then
            MsgBox("Código de Segurança inválido, Verifique.", 64, TituloMsgbox)
            Exit Sub
        Else

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

            CNN.Open()

            Dim Sql As String


            Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
            Dim cmd As OleDb.OleDbCommand = CNN.CreateCommand
            cmd.Transaction = Transacao

            'Procura a ordem para o cancelamento
            cmd.CommandText = "Select * from OrdemImbarque Where OrdemImbarque.Ordem = " & Me.OrdemEmbarque.Text
            Dim DR As OleDb.OleDbDataReader
            DR = cmd.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                MsgBox("Não foi encontrada a ordem de embarque selecionada, verifique", 64, TituloMsgbox)
                Exit Sub
            End If
            DR.Close()


            Try

                'Volta a Qtd retirada do Pedido
                Sql = "UPDATE (OrdemImbarque INNER JOIN OrdemImbarqueItens ON OrdemImbarque.Ordem = OrdemImbarqueItens.Ordem) INNER JOIN ItensPedido ON (OrdemImbarqueItens.Pedido = ItensPedido.PedidoSequencia) AND (OrdemImbarqueItens.Produto = ItensPedido.CodigoProduto) SET ItensPedido.QtdRetirada = [QtdRetirada]-[OrdemImbarqueItens].[Qtd] WHERE (((OrdemImbarque.Ordem)=" & Me.OrdemEmbarque.Text & "));"
                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()

                'Deleta o estoque retirado e Atualiza cadastro de Produto
                Sql = "UPDATE Produtos INNER JOIN EstoqueEFocusFabrica ON Produtos.CodigoProduto = EstoqueEFocusFabrica.CodigoProduto SET Produtos.EstPatio = [Produtos].[EstPatio]-[EstoqueEFocusFabrica].[EstPatio], Produtos.EstEmpresa = [Produtos].[EstEmpresa]-[EstoqueEFocusFabrica].[EstEmpresa], Produtos.EstEmpresaControlada = [Produtos].[EstEmpresaControlada]-[EstoqueEFocusFabrica].[EstEmpresaControlada] WHERE (((EstoqueEFocusFabrica.IdLancamento)=" & Me.OrdemEmbarque.Text & ") AND ((EstoqueEFocusFabrica.Prg)='OrdemEmbarque') AND ((Produtos.ProdutoIndustria)=True));"
                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()

                Sql = "Delete * From EstoqueEFocusFabrica where Prg = 'OrdemEmbarque' and IdLancamento = " & Me.OrdemEmbarque.Text
                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()

                'Deleta Itens da ordem de Embarque
                Sql = "Delete * From OrdemImbarqueItens Where Ordem = " & Me.OrdemEmbarque.Text
                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()

                'Cancela a ordem de embarque
                Sql = "UPDATE OrdemImbarque SET OrdemImbarque.Cancelada = True WHERE (((OrdemImbarque.Ordem)=" & Me.OrdemEmbarque.Text & "));"
                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()

                Transacao.Commit()
                MsgBox("Ordem de Embarque cancelada com sucesso.", 64, TituloMsgbox)
                CriaLog(UserAtivo, "OrdemEmbarqueCancelamento", "Cancelou a ordem : " & Me.OrdemEmbarque.Text)

                CNN.Close()

            Catch ex As Exception
                Transacao.Rollback()
                CNN.Close()
                MsgBox(ex.Message, 64, TituloMsgbox)
                MsgBox("Erro ao cancelar a Ordem de Embarque, tente cancelar novamente ou consulte o administrador.", 64, TituloMsgbox)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub Degrade()
        Try
            Dim CCor() As String
            Dim corTemp As String

            corTemp = Cor1TelaPrimaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))

            corTemp = Cor2TelaPrimaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))
        Catch ex As Exception
        End Try
    End Sub
End Class