Imports System.Data.OleDb
Imports System.Text
Public Class clsPedidoCompra
    Private cCodigoFornecedor As String
    Private cObservacao As String
    Private cDataLancamento As String
    Private cDataPrevista As String
    Private cCodigoFuncionario As String
    Private cTotalPedido As Double
    Private cParcelamento As Single
    Private cInativo As Boolean
    Private cConfirmado As Boolean
    Private cDataPrimeiroVencimento As String
    Private cCodigoPedidoCompra As String
    Private cnomeFornecedor As String
    Private cnomeFuncionario As String
    Private cStatus As String





    Public SalvaCabecalho As Boolean = False
    Private cRetorno As String
    Private cLocalizado As Boolean
    Private cRetornaErro As Boolean
    Private myTrans As OleDb.OleDbTransaction
    Public Property Localizado() As Boolean
        Get
            Return cLocalizado
        End Get
        Set(ByVal value As Boolean)
            cLocalizado = value
        End Set
    End Property
    Public Property CodigoFornecedor() As String
        Get
            Return cCodigoFornecedor
        End Get
        Set(ByVal value As String)
            cCodigoFornecedor = value
        End Set
    End Property

    Public Property Observacao() As String
        Get
            Return cObservacao
        End Get
        Set(ByVal value As String)
            cObservacao = value
        End Set
    End Property

    Public Property DataLancamento() As String
        Get
            Return cDataLancamento
        End Get
        Set(ByVal value As String)
            cDataLancamento = value
        End Set
    End Property

    Public Property DataPrevista() As String
        Get
            Return cDataPrevista
        End Get
        Set(ByVal value As String)
            cDataPrevista = value
        End Set
    End Property

    Public Property CodigoFuncionario() As String
        Get
            Return cCodigoFuncionario
        End Get
        Set(ByVal value As String)
            cCodigoFuncionario = value
        End Set
    End Property

    Public Property TotalPedido() As Double
        Get
            Return cTotalPedido
        End Get
        Set(ByVal value As Double)
            cTotalPedido = value
        End Set
    End Property

    Public Property Parcelamento() As Single
        Get
            Return cParcelamento
        End Get
        Set(ByVal value As Single)
            cParcelamento = value
        End Set
    End Property

    Public Property Inativo() As Boolean
        Get
            Return cInativo
        End Get
        Set(ByVal value As Boolean)
            cInativo = value
        End Set
    End Property

    Public Property Confirmado() As Boolean
        Get
            Return cConfirmado
        End Get
        Set(ByVal value As Boolean)
            cConfirmado = value
        End Set
    End Property

    Public Sub Gravar()

        Dim sql As String
        sql = "INSERT INTO PedidoCompra (CodigoFornecedor, CodigoFuncionario, DataLancamento, dataprevistaentrega, totalpedidocompra, inativo, confirmado, obs,Status)" _
                             & " Values (@1,@2,@3,@4,@5,@6,@7,@8,@9)"


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Try
            CNN.Open()
            Dim cmd As New OleDbCommand(sql, CNN)
            With cmd.Parameters
                .Add(New OleDb.OleDbParameter("@1", NzVlr(Me.CodigoFornecedor)))
                .Add(New OleDb.OleDbParameter("@2", NzVlr(Me.CodigoFuncionario)))
                .Add(New OleDb.OleDbParameter("@3", NzVlr(Me.DataLancamento)))
                .Add(New OleDb.OleDbParameter("@4", NzVlr(Me.DataPrevista)))
                .Add(New OleDb.OleDbParameter("@5", Me.TotalPedido))
                .Add(New OleDb.OleDbParameter("@6", Me.Inativo))
                .Add(New OleDb.OleDbParameter("07", Me.Confirmado))
                .Add(New OleDb.OleDbParameter("@8", NzVlr(Observacao)))
                .Add(New OleDb.OleDbParameter("@9", Status))

            End With
            cmd.ExecuteNonQuery()
            cmd.CommandText = "SELECT @@IDENTITY"
            Retorno = cmd.ExecuteScalar.ToString


        Catch ex As Exception

            Throw ex
        Finally
            CNN.Close()
        End Try


    End Sub
    Public Sub Editar(ByVal xID As Integer)

        Dim sql As String

        sql = "Update PedidoCompra Set CodigoFornecedor=@1, CodigoFuncionario=@2, DataLancamento=@3, DataPrevistaEntrega=@4, totalpedidocompra=@5, inativo=@6, confirmado=@7, obs=@10 where CodigoPedidoCompra=" & xID
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        Try
            CNN.Open()
            myTrans = CNN.BeginTransaction()
            Dim cmd As New OleDbCommand(sql, CNN, myTrans)
            With cmd.Parameters
                .Add(New OleDb.OleDbParameter("@1", NzVlr(Me.CodigoFornecedor)))
                .Add(New OleDb.OleDbParameter("@2", NzVlr(Me.CodigoFuncionario)))
                .Add(New OleDb.OleDbParameter("@3", NzVlr(Me.DataLancamento)))
                .Add(New OleDb.OleDbParameter("@4", Me.DataPrevista))
                .Add(New OleDb.OleDbParameter("@5", Me.TotalPedido))
                .Add(New OleDb.OleDbParameter("@6", Me.Inativo))
                .Add(New OleDb.OleDbParameter("@7", Confirmado))
                .Add(New OleDb.OleDbParameter("@8", NzVlr(Observacao)))

            End With
            cmd.ExecuteNonQuery()
            myTrans.Commit()
            Me.RetornaErro = False
        Catch ex As Exception
            myTrans.Rollback()
            Me.RetornaErro = True
            Throw ex
        Finally
            CNN.Close()
        End Try


    End Sub
    Public Sub ConfirmarPedido(ByVal xID As Integer)

        Dim sql As String

        sql = "Update PedidoCompra Set CodigoFornecedor=@1, CodigoFuncionario=@2, DataLancamento=@3, DataPrevistaEntrega=@4, totalpedidocompra=@5, inativo=@6, confirmado=@7, obs=@8 where CodigoPedidoCompra=" & xID
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        Try
            CNN.Open()
            myTrans = CNN.BeginTransaction()
            Dim cmd As New OleDbCommand(sql, CNN, myTrans)
            With cmd.Parameters
                .Add(New OleDb.OleDbParameter("@1", NzVlr(Me.CodigoFornecedor)))
                .Add(New OleDb.OleDbParameter("@2", NzVlr(Me.CodigoFuncionario)))
                .Add(New OleDb.OleDbParameter("@3", NzVlr(Me.DataLancamento)))
                .Add(New OleDb.OleDbParameter("@4", Me.DataPrevista))
                .Add(New OleDb.OleDbParameter("@5", Me.TotalPedido))
                .Add(New OleDb.OleDbParameter("@6", Me.Inativo))
                .Add(New OleDb.OleDbParameter("@7", Confirmado))
                .Add(New OleDb.OleDbParameter("@8", NzVlr(Observacao)))

            End With

            Dim sb As StringBuilder = New StringBuilder
            sb.Append("Insert into Pagar ")
            sb.Append("(Documento,")
            sb.Append("CodFornecedor,")
            sb.Append("DataDocumento,")
            sb.Append("Vencimento,")
            sb.Append("ValorDocumento,")
            sb.Append("LocalPgto,")
            sb.Append("Empresa,")
            sb.Append("IdPedidoCompra,")
            sb.Append("Virtual, ")
            sb.Append("Fornecedor) ")
            sb.Append("Values ")
            sb.Append("(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10)")

            Dim Sql1 As String = sb.ToString
            Dim cmd1 As New OleDbCommand(Sql1, CNN, myTrans)
            With cmd1.Parameters
                .Add(New OleDb.OleDbParameter("@1", "VIRTUAL-" & Me.CodigoPedidoCompra))
                .Add(New OleDb.OleDbParameter("@2", Me.CodigoFornecedor))
                .Add(New OleDb.OleDbParameter("@3", NzVlr(Me.DataLancamento)))
                .Add(New OleDb.OleDbParameter("@4", CDate(Me.DataLancamento).AddDays(30)))
                .Add(New OleDb.OleDbParameter("@5", Me.TotalPedido))
                .Add(New OleDb.OleDbParameter("@6", "CARTEIRA"))
                .Add(New OleDb.OleDbParameter("@7", CodEmpresa))
                .Add(New OleDb.OleDbParameter("@8", Me.CodigoPedidoCompra))
                .Add(New OleDb.OleDbParameter("@9", True))
                .Add(New OleDb.OleDbParameter("@10", Me.NomeFornecedor))

            End With
           

            cmd.ExecuteNonQuery()
            cmd1.ExecuteNonQuery()
            myTrans.Commit()
            Me.RetornaErro = False
        Catch ex As Exception
            myTrans.Rollback()
            Me.RetornaErro = True
            Throw ex
        Finally
            CNN.Close()
        End Try


    End Sub
    Public Sub ExcluirParcelas(ByVal xID As Integer, ByVal opc As String)

        Dim sql As String = ""

        Select Case opc
            Case "0" ' exclui somente o item selecionsado
                sql = "Delete idParcelamento from PedidoCompraParcelamento where ididParcelamento=" & xID
            Case "1" ' exclui todos os items
                sql = "Delete * from PedidoCompraParcelamento where CodigoPedidoCompra=" & xID
        End Select
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
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        Dim Sql As String = String.Empty

        Sql = "SELECT PedidoCompra.*, Funcionários.Nome, Fornecedor.RazãoSocial FROM (PedidoCompra INNER JOIN Funcionários ON PedidoCompra.CodigoFuncionario = Funcionários.CódigoFuncionário) INNER JOIN Fornecedor ON PedidoCompra.CodigoFornecedor = Fornecedor.CódigoFornecedor WHERE PedidoCompra.CodigoPedidoCompra=" & xID


        Dim DR As OleDb.OleDbDataReader
        Try
            CNN.Open()
            Dim cmd As New OleDbCommand(Sql, CNN)
            DR = cmd.ExecuteReader
            DR.Read()

            If DR.HasRows Then
                CodigoPedidoCompra = DR.Item("CodigoPedidocompra")
                CodigoFornecedor = DR.Item("codigofornecedor")
                CodigoFuncionario = NzZero(DR.Item("codigofuncionario"))
                NomeFornecedor = DR.Item("RazãoSocial")
                NomeFuncionario = DR.Item("Nome")
                DataLancamento = DR.Item("DataLancamento")
                DataPrevista = DR.Item("DataPrevistaEntrega") & ""
                TotalPedido = DR.Item("Totalpedidocompra")
                Parcelamento = DR.Item("parcelas")
                Inativo = DR.Item("inativo")
                Confirmado = DR.Item("confirmado")
                DataPrimeiroVencimento = DR.Item("Dataprimeirovencimento") & ""
                Observacao = DR.Item("obs") & ""
                Status = DR.Item("status") & ""
                Localizado = True
            Else
                Localizado = False
            End If

        Catch ex As Exception
            Throw ex
        Finally
            CNN.Close()
        End Try

    End Sub
    Public Sub LoclizaItemParaEditar(ByVal xID As Integer)
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))


        Dim Sql As String = "SELECT PedidoCompraItem.CompraInterno, PedidoCompra.Confirmado, [qtd]-[QtdEntregue] AS Resta FROM PedidoCompraItem INNER JOIN PedidoCompra ON PedidoCompraItem.CompraInterno = PedidoCompra.CodigoPedidoCompra WHERE (((PedidoCompraItem.CompraInterno)=" & xID & ") AND ((PedidoCompra.Status)='EM ANDAMENTO') AND ((PedidoCompra.Confirmado)=True) AND (([qtd]-[QtdEntregue])>0));"
        ' "SELECT PedidoCompraItem.CompraInterno, PedidoCompra.Confirmado, [qtd]-[QtdEntregue] AS Resta FROM PedidoCompraItem INNER JOIN PedidoCompra ON PedidoCompraItem.CompraInterno = PedidoCompra.CodigoPedidoCompra WHERE (((PedidoCompraItem.CompraInterno)=" & xID & ") AND ((PedidoCompra.Confirmado)=True) AND (([qtd]-[QtdEntregue])>0));"
        Dim DR As OleDb.OleDbDataReader
        Try
            CNN.Open()
            Dim cmd As New OleDbCommand(Sql, CNN)
            DR = cmd.ExecuteReader
            DR.Read()

            If DR.HasRows Then
                'Encontrei registro libero o pedido de compra
                Localizado = True
            Else
                'Não encontrei registro travo o pedido de compra
                Localizado = False
            End If

        Catch ex As Exception
            Throw ex
        Finally
            CNN.Close()
        End Try

    End Sub
    Public Sub EntregouTodoItem(ByVal xID As Integer)
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim sql As String = "SELECT PedidoCompraItem.Id, PedidoCompraItem.CompraInterno, PedidoCompraItem.CodigoProduto, PedidoCompraItem.Tamanho, Produtos.Descrição, [qtd]-[qtdentregue] AS QtdResta, PedidoCompraItem.Qtd, PedidoCompraItem.QtdEntregue, PedidoCompraItem.ValorUnitario, PedidoCompraItem.TotalProduto, PedidoCompraItem.CFOP, PedidoCompraItem.SeqNf FROM PedidoCompraItem INNER JOIN Produtos ON PedidoCompraItem.CodigoProduto = Produtos.CodigoProduto WHERE (((PedidoCompraItem.CompraInterno)=" & xID & ") AND (([qtd]-[qtdentregue])>0));"
        Dim ocmd As New OleDb.OleDbCommand(sql, CNN)

        Dim odr As OleDb.OleDbDataReader
        odr = ocmd.ExecuteReader

        odr.Read()
        If odr.HasRows Then
            UpdStatusPedido(xID, "EM ANDAMENTO")
            Me.Status = "EM ANDAMENTO"
        Else
            UpdStatusPedido(xID, "FINALIZADO")
            Me.Status = "FINALIZADO"
        End If

    End Sub
    Public Function verStatusNF(ByVal xid) As Boolean
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim dr As OleDb.OleDbDataReader
        Try
            CNN.Open()
            Dim cmd As New OleDbCommand("SELECT Compra.CompraInterno, Compra.PedidoCompra, Compra.Inativo FROM(Compra) WHERE (((Compra.PedidoCompra)=" & xid & ") AND ((Compra.Inativo)=False));", CNN)
            DR = cmd.ExecuteReader
            DR.Read()

            If DR.HasRows Then
                'Encontrei registro 
                Return True
            Else
                'Não encontrei registro 
                Return False
            End If

        Catch ex As Exception
            Throw ex
        Finally
            CNN.Close()
        End Try

    End Function
    Public Sub UpdStatusPedido(ByVal xID As Integer, ByVal varStatus As String)
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim sql As String = "Update PedidoCompra Set Status='" & varStatus & "' where CodigoPedidoCompra=" & xID
        Dim ocmd As New OleDb.OleDbCommand(sql, CNN)
        Try
            ocmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        CNN.Close()
    End Sub


    Public Property DataPrimeiroVencimento() As String
        Get
            Return cDataPrimeiroVencimento
        End Get
        Set(ByVal value As String)
            cDataPrimeiroVencimento = value
        End Set
    End Property

    Public Property Retorno() As String
        Get
            Return cRetorno
        End Get
        Set(ByVal value As String)
            cRetorno = value
        End Set
    End Property

    Public Property CodigoPedidoCompra() As String
        Get
            Return cCodigoPedidoCompra
        End Get
        Set(ByVal value As String)
            cCodigoPedidoCompra = value
        End Set
    End Property

    Public Property NomeFornecedor() As String
        Get
            Return cnomeFornecedor
        End Get
        Set(ByVal value As String)
            cnomeFornecedor = value
        End Set
    End Property

    Public Property NomeFuncionario() As String
        Get
            Return cnomeFuncionario
        End Get
        Set(ByVal value As String)
            cnomeFuncionario = value
        End Set
    End Property

    Public Property Status() As String
        Get
            Return cStatus
        End Get
        Set(ByVal value As String)
            cStatus = value
        End Set
    End Property

    Public Property RetornaErro() As Boolean
        Get
            Return cRetornaErro
        End Get
        Set(ByVal value As Boolean)
            cRetornaErro = value
        End Set
    End Property
    Function OnlyNumber(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            OnlyNumber = 0
        Else
            OnlyNumber = Keyascii
        End If
        Select Case Keyascii
            Case 8
                OnlyNumber = Keyascii
            Case 13
                OnlyNumber = Keyascii
            Case 32
                OnlyNumber = Keyascii
        End Select

    End Function
End Class
