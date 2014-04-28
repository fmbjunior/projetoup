Imports System.Threading
Public Class EstoqueAtualizar

    'Esta rotina ja esta atualizada para o novo formato
#Region "Estoque Pedido"

    Dim PedidoOrdem As String
    Private TRD As Thread

    Public Sub Run_AtualizadorEstoquePedido(ByVal IdPedidoOrdem As String)
        PedidoOrdem = IdPedidoOrdem
        TRD = New Thread(AddressOf AtEstoquePedido)
        TRD.IsBackground = True
        TRD.Start()
    End Sub

    Private Sub AtEstoquePedido()

        Dim CnnEstGeral As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CnnEstGeral.Open()

        Dim dsEstGeral As New DataSet()

        Try

            Dim sql = "SELECT EstoqueUP.CodigoProduto, Sum(EstoqueUP.Qtd) AS SomaDeQtd, Sum(EstoqueUP.QtdF) AS SomaDeQtdF FROM(EstoqueUP) GROUP BY EstoqueUP.CodigoProduto;"
            Dim daEstoque As New OleDb.OleDbDataAdapter(sql, CnnEstGeral)
            daEstoque.Fill(dsEstGeral, "Estoque")

            sql = "SELECT CodigoProduto,QuantidadeEstoque FROM Produtos"
            Dim daProduto As New OleDb.OleDbDataAdapter(sql, CnnEstGeral)
            daProduto.Fill(dsEstGeral, "Produtos")

            sql = "SELECT ItensPedido.PedidoSequencia, ItensPedido.CodigoProduto FROM ItensPedido INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto GROUP BY ItensPedido.PedidoSequencia, ItensPedido.CodigoProduto, Produtos.ControlaEstoque HAVING (((ItensPedido.PedidoSequencia)=" & PedidoOrdem & ") AND ((Produtos.ControlaEstoque)='SIM'));"
            Dim daIT As New OleDb.OleDbDataAdapter(sql, CnnEstGeral)
            daIT.Fill(dsEstGeral, "Itens")


            Dim DrLinha As DataRow

            For Each DrLinha In dsEstGeral.Tables("Itens").Rows
                Dim drEst() As DataRow
                drEst = dsEstGeral.Tables("Estoque").Select("CodigoProduto = " & DrLinha("CodigoProduto"))

                Dim drProduto() As DataRow
                drProduto = dsEstGeral.Tables("Produtos").Select("CodigoProduto = " & DrLinha("CodigoProduto"))


                drProduto(0).BeginEdit()
                drProduto(0)("QuantidadeEstoque") = drEst(0)("SomaDeQtd")
                drProduto(0).EndEdit()

            Next DrLinha


            Dim objProduto As New OleDb.OleDbCommandBuilder(daProduto)
            daProduto.Update(dsEstGeral, "Produtos")

        Catch ex As Exception
            CnnEstGeral.Close()
            MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK)
            MessageBox.Show("Aconteceram erros ao atualizar o estoque de Numeração do Produto, favor fazer atualização geral do estoque", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try

    End Sub

#End Region

    'Esta rotina ja esta atualizada para o novo formato
#Region "Estoque Compra"

    Dim VlrIdCompra As String
    Private TRDCompra As Thread

    Public Sub Run_AtualizadorNFCompra(ByVal idCompra As String)
        VlrIdCompra = idCompra
        TRDCompra = New Thread(AddressOf AtualizaEstoqueNFCompra)
        TRDCompra.IsBackground = True
        TRDCompra.Start()
    End Sub

    Private Sub AtualizaEstoqueNFCompra()

        Dim CnnEstGeral As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CnnEstGeral.Open()


        Dim dsEstGeral As New DataSet()

        Try



            Dim sql = "SELECT EstoqueUP.CodigoProduto, Sum(EstoqueUP.Qtd) AS SomaDeQtd, Sum(EstoqueUP.QtdF) AS SomaDeQtdF FROM(EstoqueUP) GROUP BY EstoqueUP.CodigoProduto;"

            Dim daEstoque As New OleDb.OleDbDataAdapter(sql, CnnEstGeral)
            daEstoque.Fill(dsEstGeral, "Estoque")

            sql = "SELECT CodigoProduto, QuantidadeEstoque FROM Produtos"
            Dim daProduto As New OleDb.OleDbDataAdapter(sql, CnnEstGeral)
            daProduto.Fill(dsEstGeral, "Produtos")

            sql = "SELECT ItensCompra.CompraInterno, ItensCompra.CodigoProduto FROM ItensCompra INNER JOIN Produtos ON ItensCompra.CodigoProduto = Produtos.CodigoProduto WHERE(((Produtos.ControlaEstoque) = 'SIM')) GROUP BY ItensCompra.CompraInterno, ItensCompra.CodigoProduto HAVING (((ItensCompra.CompraInterno)=" & VlrIdCompra & "));"
            Dim daIT As New OleDb.OleDbDataAdapter(sql, CnnEstGeral)
            daIT.Fill(dsEstGeral, "Itens")

            Dim DrLinha As DataRow
            For Each DrLinha In dsEstGeral.Tables("Itens").Rows
                Dim drEst() As DataRow
                drEst = dsEstGeral.Tables("Estoque").Select("CodigoProduto = " & DrLinha("CodigoProduto"))

                Dim drProduto() As DataRow
                drProduto = dsEstGeral.Tables("Produtos").Select("CodigoProduto = " & DrLinha("CodigoProduto"))


                drProduto(0).BeginEdit()
                drProduto(0)("QuantidadeEstoque") = drEst(0)("SomaDeQtd")
                drProduto(0).EndEdit()
            Next

            Dim objProduto As New OleDb.OleDbCommandBuilder(daProduto)
            daProduto.Update(dsEstGeral, "Produtos")

        Catch ex As Exception
            CnnEstGeral.Close()
            MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK)
            MessageBox.Show("Aconteceram erros ao atualizar o estoque de Numeração do Produto, favor fazer atualização geral do estoque", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try

    End Sub

#End Region

#Region "Estoque OrdemProdução"
    Dim PedidoOrdemProducao As String
    Private TRDOrdemProducao As Thread

    Public Sub Run_AtualizadorEstoqueOrdemProducao(ByVal IdOrdemProducao As String)
        PedidoOrdemProducao = IdOrdemProducao
        TRDOrdemProducao = New Thread(AddressOf AtEstoqueOrdemProducao)
        TRDOrdemProducao.IsBackground = True
        TRDOrdemProducao.Start()
    End Sub

    Private Sub AtEstoqueOrdemProducao()

        Dim CnnEstoque As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CnnEstoque.Open()


        Dim CmdEst As OleDb.OleDbCommand = CnnEstoque.CreateCommand
        Dim ds As New DataSet()
        Dim DataReader As OleDb.OleDbDataReader

        Try
            Dim sql = "SELECT EstoqueUP.CodigoProduto, Sum(EstoqueUP.Qtd) AS SomaDeQtd, ProducaoItem.OrdemProducao FROM ProducaoItem INNER JOIN EstoqueUP ON ProducaoItem.Produto = EstoqueUP.CodigoProduto GROUP BY EstoqueUP.CodigoProduto, ProducaoItem.OrdemProducao HAVING (((ProducaoItem.OrdemProducao)=" & PedidoOrdemProducao & "));"
            Dim SqlEstoque As String = "SELECT Produtos.CodigoProduto, Produtos.EstoqueFiscal, Produtos.QuantidadeEstoque FROM ProducaoItem INNER JOIN Produtos ON ProducaoItem.Produto = Produtos.CodigoProduto WHERE (((ProducaoItem.OrdemProducao)=" & PedidoOrdemProducao & ") AND ((Produtos.ControlaEstoque)='SIM'));"
            Dim oDA As New OleDb.OleDbDataAdapter(SqlEstoque, CnnEstoque)
            oDA.Fill(ds, "Produto")

            With CmdEst
                .Connection = CnnEstoque
                .CommandTimeout = 0
                .CommandText = sql
                .CommandType = CommandType.Text
            End With

            DataReader = CmdEst.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    'Achou o iten procurado o iten as caixas serão preenchida
                    Dim Drw() As DataRow
                    Drw = ds.Tables("Produto").Select("CodigoProduto = " & DataReader.Item("CodigoProduto"))
                    Drw(0).BeginEdit()
                    Drw(0)("QuantidadeEstoque") = DataReader.Item("SomaDeQtd")
                    Drw(0).EndEdit()
                End If
            End While
            DataReader.Close()
            Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(oDA)
            oDA.Update(ds, "Produto")
            DataReader.Close()




            sql = "SELECT EstoqueUP.CodigoProduto, Sum(EstoqueUP.Qtd) AS SomaDeQtd, ProducaoItemSub.OrdemProducao FROM ProducaoItemSub INNER JOIN EstoqueUP ON ProducaoItemSub.Produto = EstoqueUP.CodigoProduto GROUP BY EstoqueUP.CodigoProduto, ProducaoItemSub.OrdemProducao HAVING (((ProducaoItemSub.OrdemProducao)=" & PedidoOrdemProducao & "));"
            SqlEstoque = "SELECT Produtos.CodigoProduto, Produtos.EstoqueFiscal, Produtos.QuantidadeEstoque FROM ProducaoItemSub INNER JOIN Produtos ON ProducaoItemSub.Produto = Produtos.CodigoProduto WHERE (((ProducaoItemSub.OrdemProducao)=" & PedidoOrdemProducao & "));"
            Dim oDA1 As New OleDb.OleDbDataAdapter(SqlEstoque, CnnEstoque)
            oDA1.Fill(ds, "Produto")

            With CmdEst
                .Connection = CnnEstoque
                .CommandTimeout = 0
                .CommandText = sql
                .CommandType = CommandType.Text
            End With

            DataReader = CmdEst.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    'Achou o iten procurado o iten as caixas serão preenchida
                    Dim Drw() As DataRow
                    Drw = ds.Tables("Produto").Select("CodigoProduto = " & DataReader.Item("CodigoProduto"))
                    Drw(0).BeginEdit()
                    Drw(0)("QuantidadeEstoque") = DataReader.Item("SomaDeQtd")
                    Drw(0).EndEdit()
                End If
            End While
            DataReader.Close()
            Dim objCommandBuilder1 As New OleDb.OleDbCommandBuilder(oDA1)
            oDA.Update(ds, "Produto")

            CnnEstoque.Close()

        Catch ex As Exception
            CnnEstoque.Close()
            MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK)
            MessageBox.Show("Aconteceram erros ao atualizar o estoque do cadastro de Produto, favor fazer atualização geral do estoque", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try

    End Sub

#End Region

    'Esta rotina ja esta atualizada para o novo formato
#Region "Estoque Numeração"
    Dim VendaSellShoes As String
    Private trdSellShoes As Thread

    Public Sub Run_AtualizadorNumeracao(ByVal IdVendaSellShoes As String)
        VendaSellShoes = IdVendaSellShoes
        trdSellShoes = New Thread(AddressOf AtEstoqueNumeracao)
        trdSellShoes.IsBackground = True
        trdSellShoes.Start()
    End Sub

    Private Sub AtEstoqueNumeracao()

        Dim CnnEstNumeros As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CnnEstNumeros.Open()


        Dim CmdNumeros As OleDb.OleDbCommand = CnnEstNumeros.CreateCommand
        Dim ds As New DataSet()

        Try

            Dim sql = "SELECT EstoqueUP.CodigoProduto, EstoqueUP.Numero, Sum(EstoqueUP.Qtd) AS SomaDeQtd FROM(EstoqueUP) GROUP BY EstoqueUP.CodigoProduto, EstoqueUP.Numero;"
            Dim daEstoque As New OleDb.OleDbDataAdapter(sql, CnnEstNumeros)
            daEstoque.Fill(ds, "Estoque")

            sql = "SELECT * FROM ProdutoGrade"
            Dim daGrade As New OleDb.OleDbDataAdapter(sql, CnnEstNumeros)
            daGrade.Fill(ds, "Numeracao")

            sql = "SELECT ItensPedido.PedidoSequencia, ItensPedido.CodigoProduto, ItensPedido.Numero FROM ItensPedido INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto WHERE (((ItensPedido.PedidoSequencia)=" & VendaSellShoes & ") AND ((Produtos.ControlaEstoque)='SIM'));"
            Dim daIT As New OleDb.OleDbDataAdapter(sql, CnnEstNumeros)
            daIT.Fill(ds, "Itens")


            Dim DrLinha As DataRow
            For Each DrLinha In ds.Tables("Itens").Rows
                Dim drEst() As DataRow
                drEst = ds.Tables("Estoque").Select("CodigoProduto = " & DrLinha("CodigoProduto") & " And Numero = '" & DrLinha("Numero") & "'")

                Dim drGrade() As DataRow
                drGrade = ds.Tables("Numeracao").Select("Produto = " & DrLinha("CodigoProduto") & " And Numero = '" & DrLinha("Numero") & "'")


                drGrade(0).BeginEdit()
                drGrade(0)("QtdEst") = NzZero(drEst(0)("SomaDeQtd"))
                drGrade(0).EndEdit()
            Next


            Dim objGrade As New OleDb.OleDbCommandBuilder(daGrade)
            daGrade.Update(ds, "Numeracao")

        Catch ex As Exception
            CnnEstNumeros.Close()
            MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK)
            MessageBox.Show("Aconteceram erros ao atualizar o estoque de Numeração do Produto, favor fazer atualização geral do estoque", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try

    End Sub

#End Region

#Region "Estoque Numeração Entrada"
    Dim CompraSellShoes As String
    Private ThreadSellShoes As Thread

    Public Sub Run_AtualizadorNumeracaoEntrada(ByVal IdCompraSellShoes As String)
        CompraSellShoes = IdCompraSellShoes
        ThreadSellShoes = New Thread(AddressOf AtEstoqueNumeracaoEntrada)
        ThreadSellShoes.IsBackground = True
        ThreadSellShoes.Start()
    End Sub

    Private Sub AtEstoqueNumeracaoEntrada()

        Dim CnnEstNumeros As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CnnEstNumeros.Open()


        Dim CmdNumeros As OleDb.OleDbCommand = CnnEstNumeros.CreateCommand
        Dim ds As New DataSet()

        Try

            Dim sql = "SELECT EstoqueUP.CodigoProduto, EstoqueUP.Numero, Sum(EstoqueUP.Qtd) AS SomaDeQtd FROM(EstoqueUP) GROUP BY EstoqueUP.CodigoProduto, EstoqueUP.Numero;"
            Dim daEstoque As New OleDb.OleDbDataAdapter(sql, CnnEstNumeros)
            daEstoque.Fill(ds, "Estoque")

            sql = "SELECT * FROM ProdutoGrade"
            Dim daGrade As New OleDb.OleDbDataAdapter(sql, CnnEstNumeros)
            daGrade.Fill(ds, "Numeracao")

            sql = "SELECT ItensCompra.CompraInterno, ItensCompra.CodigoProduto, ItensCompra.Tamanho FROM ItensCompra INNER JOIN Produtos ON ItensCompra.CodigoProduto = Produtos.CodigoProduto WHERE (((ItensCompra.CompraInterno)=" & CompraSellShoes & ") AND ((Produtos.ControlaEstoque)='SIM'));"
            Dim daIT As New OleDb.OleDbDataAdapter(sql, CnnEstNumeros)
            daIT.Fill(ds, "Itens")


            Dim DrLinha As DataRow
            For Each DrLinha In ds.Tables("Itens").Rows
                Dim drEst() As DataRow
                drEst = ds.Tables("Estoque").Select("CodigoProduto = " & DrLinha("CodigoProduto") & " And Numero = '" & DrLinha("Tamanho") & "'")

                Dim drGrade() As DataRow
                drGrade = ds.Tables("Numeracao").Select("Produto = " & DrLinha("CodigoProduto") & " And Numero = '" & DrLinha("Tamanho") & "'")


                drGrade(0).BeginEdit()
                drGrade(0)("QtdEst") = drEst(0)("SomaDeQtd")
                drGrade(0).EndEdit()
            Next


            Dim objGrade As New OleDb.OleDbCommandBuilder(daGrade)
            daGrade.Update(ds, "Numeracao")

        Catch ex As Exception
            CnnEstNumeros.Close()
            MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK)
            MessageBox.Show("Aconteceram erros ao atualizar o estoque de Numeração do Produto, favor fazer atualização geral do estoque", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try

    End Sub

#End Region

End Class
