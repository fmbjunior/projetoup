Imports System.Data.OleDb
Public Class clsAddItemPedidoCompra
    Private cComprainterno As Integer
    Private cCodigoproduto As Integer
    Private cqtd As Double
    Private cvalorunitario As Double
    Private cTotalproduto As Double
    Private ccfop As String
    Private ctamanho As String
    Private cretorno As String
    Private cQtdEntregue As Double
    Private cDgvCustom As DataGridView
    Public Sub AtGrade(ByVal xID As Integer)

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim sql As String = "SELECT PedidoCompraItem.Id, PedidoCompraItem.CompraInterno, PedidoCompraItem.CodigoProduto, PedidoCompraItem.Tamanho, Produtos.Descrição, PedidoCompraItem.Qtd, PedidoCompraItem.QtdEntregue, PedidoCompraItem.ValorUnitario, PedidoCompraItem.TotalProduto, PedidoCompraItem.CFOP, PedidoCompraItem.SeqNf FROM PedidoCompraItem INNER JOIN Produtos ON PedidoCompraItem.CodigoProduto = Produtos.CodigoProduto WHERE PedidoCompraItem.CompraInterno=" & xID


        Dim CMD As New OleDb.OleDbCommand(sql, CNN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet

        Try


            Da.Fill(ds, "Table")

            SellShoesPedidoCompra.dgv.DataSource = ds.Tables("Table").DefaultView
            SellShoesPedidoCompra.TotalItensLançado.Text = FormatCurrency(NzZero(ds.Tables(0).Compute("SUM(TotalProduto)", "")), 2)
            For Each row As DataGridViewRow In Me.DgvCustom.Rows
                row.Cells("gResta").Value = row.Cells("Qtdp").Value - row.Cells("QtdEntregue").Value
                
            Next row

            Da.Dispose()
            CNN.Close()
        Catch ex As Exception
            Da.Dispose()
            CNN.Close()
        Finally
            CNN.Close()
        End Try
    End Sub
    Public Sub Gravar()

        Dim sql As String
        sql = "INSERT INTO PedidoCompraItem (CompraInterno, CodigoProduto, qtd, ValorUnitario, TotalProduto, CFOP, Tamanho,QtdEntregue)" _
                             & " Values (@1,@2,@3,@4,@5,@6,@7,@8)"


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Try
            CNN.Open()
            Dim cmd As New OleDbCommand(sql, CNN)
            With cmd.Parameters
                .Add(New OleDb.OleDbParameter("@1", Me.Comprainterno))
                .Add(New OleDb.OleDbParameter("@2", Me.Codigoproduto))
                .Add(New OleDb.OleDbParameter("@3", NzZero(Me.Qtd)))
                .Add(New OleDb.OleDbParameter("@4", NzZero(Me.Valorunitario)))
                .Add(New OleDb.OleDbParameter("@5", Me.Totalproduto))
                .Add(New OleDb.OleDbParameter("@6", Me.Cfop))
                .Add(New OleDb.OleDbParameter("@7", Me.Tamanho))
                .Add(New OleDb.OleDbParameter("@8", Me.QtdEntregue))


            End With
            cmd.ExecuteNonQuery()


        Catch ex As Exception

            Throw ex
        Finally
            CNN.Close()
        End Try


    End Sub
    Public Sub Editar(ByVal xID As Integer)

        Dim sql As String

        sql = "Update PedidoCompraItem Set codigoproduto=@2, qtd=@3, valorunitario=@4, totalproduto=@5, cfop=@6, tamanho=@7 where id=" & xID
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Try
            CNN.Open()
            Dim cmd As New OleDbCommand(sql, CNN)
            With cmd.Parameters
                .Add(New OleDb.OleDbParameter("@2", Me.Codigoproduto))
                .Add(New OleDb.OleDbParameter("@3", NzZero(Me.Qtd)))
                .Add(New OleDb.OleDbParameter("@4", NzZero(Me.Valorunitario)))
                .Add(New OleDb.OleDbParameter("@5", Me.Totalproduto))
                .Add(New OleDb.OleDbParameter("@6", Me.Cfop))
                .Add(New OleDb.OleDbParameter("@7", Me.Tamanho))

            End With
            cmd.ExecuteNonQuery()

        Catch ex As Exception

            Throw ex
        Finally
            CNN.Close()
        End Try


    End Sub
    Public Sub Excluir(ByVal xID As Integer)

        Dim sql As String

        sql = "Delete * from PedidoCompraItem where id=" & xID
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Try
            CNN.Open()
            Dim cmd As New OleDbCommand(sql, CNN)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            CNN.Close()
        End Try


    End Sub
    Public Sub Localizar(ByVal xID As Integer)

        'Dim sql As String

        'sql = "Select * from Produtos where Prod_CodigoProduto=" & xID
        'Dim conn As New OleDbConnection
        'Dim DR As OleDbDataReader
        'Try
        '    conn = db.AbreBanco()
        '    Dim cmd As New OleDbCommand(sql, conn)
        '    DR = cmd.ExecuteReader
        '    DR.Read()

        '    cCodigoProduto = DR.Item("Prod_CodigoProduto")
        '    cDescricao = DR.Item("Prod_Descricao")
        '    cGrupo = NzZero(DR.Item("grp_codigogrupo"))
        '    cMarca = NzZero(DR.Item("Prod_marca"))
        '    cCodigoBarra = DR.Item("Prod_Codigobarra") & ""
        '    cCodigoFabrica = DR.Item("Prod_CodigoFabrica") & ""
        '    cUnidadeCompra = DR.Item("Prod_UnidadeCompra") & ""
        '    cUnidadeVenda = DR.Item("Prod_unidadeVenda") & ""
        '    cEstoqueMinimo = NzZero(DR.Item("Prod_QuantidadeMinima"))
        '    cEstoque = NzZero(DR.Item("Prod_QuantidadeEstoque"))
        '    cFatorDivisao = IIf(IsDBNull(DR.Item("Prod_FatorDivisao")), 1, DR.Item("Prod_FatorDivisao"))
        '    cUltimaCompra = DR.Item("Prod_DataCompra") & ""
        '    cUltimoValor = NzZero(DR.Item("Prod_PrecoCompraAnterior"))
        '    cDescontoMaximo = NzZero(DR.Item("Prod_Desconto"))
        '    cValorCompra = NzZero(DR.Item("Prod_PrecoCompra"))
        '    cValorVendas = NzZero(DR.Item("Prod_ValorVenda"))
        '    cOM = DR.Item("Prod_OM") & ""
        '    cCT = DR.Item("Prod_CT") & ""
        '    cNcm = DR.Item("Prod_ncm") & ""
        '    cProdutoInativo = DR.Item("Prod_Inativo")
        '    cControlaEstoque = DR.Item("Prod_ControlaEstoque")
        '    cAplicacao = DR.Item("Prod_Aplicacao") & ""


        'Catch ex As Exception
        '    Throw ex
        'Finally
        '    db.fechabanco(conn)
        'End Try

    End Sub

    Public Property Comprainterno() As Integer
        Get
            Return cComprainterno
        End Get
        Set(ByVal value As Integer)
            cComprainterno = value
        End Set
    End Property

    Public Property Codigoproduto() As Integer
        Get
            Return cCodigoproduto
        End Get
        Set(ByVal value As Integer)
            cCodigoproduto = value
        End Set
    End Property

    Public Property Qtd() As Double
        Get
            Return cqtd
        End Get
        Set(ByVal value As Double)
            cqtd = value
        End Set
    End Property

    Public Property Valorunitario() As Double
        Get
            Return cvalorunitario
        End Get
        Set(ByVal value As Double)
            cvalorunitario = value
        End Set
    End Property

    Public Property Totalproduto() As Double
        Get
            Return cTotalproduto
        End Get
        Set(ByVal value As Double)
            cTotalproduto = value
        End Set
    End Property

    Public Property Cfop() As String
        Get
            Return ccfop
        End Get
        Set(ByVal value As String)
            ccfop = value
        End Set
    End Property

    Public Property Tamanho() As String
        Get
            Return ctamanho
        End Get
        Set(ByVal value As String)
            ctamanho = value
        End Set
    End Property

    Public Property Retorno() As String
        Get
            Return cRetorno
        End Get
        Set(ByVal value As String)
            cretorno = value
        End Set
    End Property
    Public Property QtdEntregue() As Double
        Get
            Return cQtdEntregue
        End Get
        Set(ByVal value As Double)
            cQtdEntregue = value
        End Set
    End Property

    Public Property DgvCustom() As DataGridView
        Get
            Return cDgvCustom
        End Get
        Set(ByVal value As DataGridView)
            cDgvCustom = value
        End Set
    End Property

End Class
