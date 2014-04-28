Imports System.Threading
Public Class EstoqueAtualizarCtrPedido
    Private TRD As Thread

    Public Sub Run_AtualizadorEstoque()
        TRD = New Thread(AddressOf AtualizaEstoqueCtrPedido)
        TRD.IsBackground = True
        TRD.Start()
    End Sub

    Private Sub AtualizaEstoqueCtrPedido()
        Try
            Dim DBEngine As New DAO.DBEngine
            Dim Banco As DAO.Database
            Dim Rst As DAO.Recordset
            Dim RstProduto As DAO.Recordset
            Dim SqlEstoque As String

            If EstaCarregado("CompraCtrPedido") = True Then
                SqlEstoque = "SELECT EstoqueEFocus.CodigoProduto, First(Produtos.Descrição) AS PrimeiroDeDescrição, Sum(IIf([EstoqueEfocus.Tipo]='E',[EstoqueEfocus.Qtd],[EstoqueEfocus.Qtd]*-1)) AS Saldo, CompraCtrlPedidoItens.IdPedido FROM (EstoqueEFocus INNER JOIN Produtos ON EstoqueEFocus.CodigoProduto = Produtos.CodigoProduto) INNER JOIN CompraCtrlPedidoItens ON Produtos.CodigoProduto = CompraCtrlPedidoItens.Produto GROUP BY EstoqueEFocus.CodigoProduto, CompraCtrlPedidoItens.IdPedido HAVING (((CompraCtrlPedidoItens.IdPedido)= " & RetornoProcura & "));"
            Else
                SqlEstoque = "SELECT EstoqueEFocus.CodigoProduto, First(Produtos.Descrição) AS PrimeiroDeDescrição, Sum(IIf([EstoqueEfocus.Tipo]='E',[EstoqueEfocus.Qtd],[EstoqueEfocus.Qtd]*-1)) AS Saldo, ItensCompra.CompraInterno FROM (EstoqueEFocus INNER JOIN Produtos ON EstoqueEFocus.CodigoProduto = Produtos.CodigoProduto) INNER JOIN ItensCompra ON Produtos.CodigoProduto = ItensCompra.CodigoProduto GROUP BY EstoqueEFocus.CodigoProduto, ItensCompra.CompraInterno HAVING (((ItensCompra.CompraInterno)= " & RetornoProcura & "));"
            End If

            Banco = DBEngine.OpenDatabase(LocalBD & Nome_BD)
            Rst = Banco.OpenRecordset(SqlEstoque)
            RstProduto = Banco.OpenRecordset("Produtos")
            RstProduto.Index = "PrimaryKey"

            While Not Rst.EOF
                RstProduto.Seek("=", Rst.Fields("CodigoProduto").Value)
                If RstProduto.NoMatch = False Then
                    RstProduto.Edit()
                    RstProduto.Fields("QuantidadeEstoque").Value = Rst.Fields("Saldo").Value
                    RstProduto.Update()
                End If
                Rst.MoveNext()
            End While

            Rst.Close()
            RstProduto.Close()
            Banco.Close()
        Catch ex As Exception
            MsgBox("Erro ao atualizar o estoque geral dos produtos", 64, TituloMsgbox)
        End Try

    End Sub
End Class
