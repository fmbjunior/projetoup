Imports System.Data.OleDb

Public Class clsPedidoMP

    Private cRetorno As String
    Dim db As New clsBancoDados
    Private m_CodigoCliente As Integer
    Private m_CodigoFuncionario As Integer
    Private m_CodigoPagamento As String
    Private m_codigopagamentodesc As String
    Private m_Comissao As Double
    Private m_Contato As String
    Private m_DataFechamento As String
    Private m_DataPedido As String
    Private m_DataPrazoEntrega As String
    Private m_DateFechamento2 As String
    Private m_email As String
    Private m_empresa As String
    Private m_ErroRetorno As Boolean
    Private m_Fechado As Boolean
    Private m_Inativo As Boolean
    Private m_Localizado As Boolean
    Private m_modelo As String
    Private m_nomeCliente As String
    Private m_nomeoperacao As String
    Private m_NomeVendedor As String
    Private m_NumeroPedido As String
    Private m_Observacao As String
    Private m_operacao As String
    Private m_Status As String
    Private m_telefone As String
    Private m_TotalBruto As Double
    Private m_TotalDesconto As Double
    Private m_TotalLiquido As Double
    Private m_ValorBordado As Double
    Private m_valorcheque As Double
    Private m_ValorComissao As Double
    Private m_valorfaturar As Double
    Private m_ValorMP As Double
    Private m_ValorSerigrafia As Double
    Private m_valorvista As Double
    Private m_gerado_pedido As Boolean
    Private m_datavalidade As String
    Private m_orcForPed As String
    Public Property Gerado_pedido() As Boolean
        Get
            Return m_gerado_pedido
        End Get
        Set(ByVal value As Boolean)
            m_gerado_pedido = value
        End Set
    End Property
    Public Property Datavalidade() As String
        Get
            Return m_datavalidade
        End Get
        Set(ByVal value As String)
            m_datavalidade = value
        End Set
    End Property

    Public SalvaCabecalho As Boolean = False

    Public Property CodigoCliente() As Integer
        Get
            Return m_CodigoCliente
        End Get
        Set(ByVal value As Integer)
            m_CodigoCliente = value
        End Set
    End Property

    Public Property CodigoFuncionario() As Integer
        Get
            Return m_CodigoFuncionario
        End Get
        Set(ByVal value As Integer)
            m_CodigoFuncionario = value
        End Set
    End Property

    Public Property CodigoPagamento As String
        Get
            Return m_CodigoPagamento
        End Get
        Set(ByVal value As String)
            m_CodigoPagamento = value
        End Set
    End Property

    Public Property Codigopagamentodesc() As String
        Get
            Return m_codigopagamentodesc
        End Get
        Set(ByVal value As String)
            m_codigopagamentodesc = value
        End Set
    End Property

    Public Property Comissao() As Double
        Get
            Return m_Comissao
        End Get
        Set(ByVal value As Double)
            m_Comissao = value
        End Set
    End Property

    Public Property Contato() As String
        Get
            Return m_Contato
        End Get
        Set(ByVal value As String)
            m_Contato = value
        End Set
    End Property

    Public Property DataFechamento() As String
        Get
            Return m_DataFechamento
        End Get
        Set(ByVal value As String)
            m_DataFechamento = value
        End Set
    End Property

    Public Property DataPedido() As String
        Get
            Return m_DataPedido
        End Get
        Set(ByVal value As String)
            m_DataPedido = value
        End Set
    End Property

    Public Property DataPrazoEntrega() As String
        Get
            Return m_DataPrazoEntrega
        End Get
        Set(ByVal value As String)
            m_DataPrazoEntrega = value
        End Set
    End Property

    Public Property DateFechamento2() As String
        Get
            Return m_DateFechamento2
        End Get
        Set(ByVal value As String)
            m_DateFechamento2 = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return m_email
        End Get
        Set(ByVal value As String)
            m_email = value
        End Set
    End Property

    Public Property Empresa() As String
        Get
            Return m_empresa
        End Get
        Set(ByVal value As String)
            m_empresa = value
        End Set
    End Property

    Public Property ErroRetorno() As Boolean
        Get
            Return m_ErroRetorno
        End Get
        Set(ByVal value As Boolean)
            m_ErroRetorno = value
        End Set
    End Property

    Public Property Fechado() As Boolean
        Get
            Return m_Fechado
        End Get
        Set(ByVal value As Boolean)
            m_Fechado = value
        End Set
    End Property

    Public Property Inativo() As Boolean
        Get
            Return m_Inativo
        End Get
        Set(ByVal value As Boolean)
            m_Inativo = value
        End Set
    End Property

    Public Property Localizado() As Boolean
        Get
            Return m_Localizado
        End Get
        Set(ByVal value As Boolean)
            m_Localizado = value
        End Set
    End Property

    Public Property Modelo() As String
        Get
            Return m_modelo
        End Get
        Set(ByVal value As String)
            m_modelo = value
        End Set
    End Property

    Public Property nomeCliente() As String
        Get
            Return m_nomeCliente
        End Get
        Set(ByVal value As String)
            m_nomeCliente = value
        End Set
    End Property

    Public Property Nomeoperacao() As String
        Get
            Return m_nomeoperacao
        End Get
        Set(ByVal value As String)
            m_nomeoperacao = value
        End Set
    End Property

    Public Property NomeVendedor() As String
        Get
            Return m_NomeVendedor
        End Get
        Set(ByVal value As String)
            m_NomeVendedor = value
        End Set
    End Property

    Public Property NumeroPedido() As String
        Get
            Return m_NumeroPedido
        End Get
        Set(ByVal value As String)
            m_NumeroPedido = value
        End Set
    End Property

    Public Property Observacao() As String
        Get
            Return m_Observacao
        End Get
        Set(ByVal value As String)
            m_Observacao = value
        End Set
    End Property

    Public Property Operacao() As String
        Get
            Return m_operacao
        End Get
        Set(ByVal value As String)
            m_operacao = value
        End Set
    End Property

    Public Property Status() As String
        Get
            Return m_Status
        End Get
        Set(ByVal value As String)
            m_Status = value
        End Set
    End Property

    Public Property Telefone() As String
        Get
            Return m_telefone
        End Get
        Set(ByVal value As String)
            m_telefone = value
        End Set
    End Property

    Public Property TotalBruto() As Double
        Get
            Return m_TotalBruto
        End Get
        Set(ByVal value As Double)
            m_TotalBruto = value
        End Set
    End Property

    Public Property TotalDesconto() As Double
        Get
            Return m_TotalDesconto
        End Get
        Set(ByVal value As Double)
            m_TotalDesconto = value
        End Set
    End Property

    Public Property TotalLiquido() As Double
        Get
            Return m_TotalLiquido
        End Get
        Set(ByVal value As Double)
            m_TotalLiquido = value
        End Set
    End Property

    Public Property ValorBordado() As Double
        Get
            Return m_ValorBordado
        End Get
        Set(ByVal value As Double)
            m_ValorBordado = value
        End Set
    End Property

    Public Property Valorcheque() As Double
        Get
            Return m_valorcheque
        End Get
        Set(ByVal value As Double)
            m_valorcheque = value
        End Set
    End Property

    Public Property ValorComissao() As Double
        Get
            Return m_ValorComissao
        End Get
        Set(ByVal value As Double)
            m_ValorComissao = value
        End Set
    End Property

    Public Property Valorfaturar() As Double
        Get
            Return m_valorfaturar
        End Get
        Set(ByVal value As Double)
            m_valorfaturar = value
        End Set
    End Property

    Public Property ValorMP() As Double
        Get
            Return m_ValorMP
        End Get
        Set(ByVal value As Double)
            m_ValorMP = value
        End Set
    End Property

    Public Property ValorSerigrafia() As Double
        Get
            Return m_ValorSerigrafia
        End Get
        Set(ByVal value As Double)
            m_ValorSerigrafia = value
        End Set
    End Property

    Public Property Valorvista() As Double
        Get
            Return m_valorvista
        End Get
        Set(ByVal value As Double)
            m_valorvista = value
        End Set
    End Property

    Public Sub Editar(ByVal xID As Integer)
        Dim cnn As New OleDbConnection
        Dim sql As String

        sql = "Update PEDIDOMATERIAPRIMA Set CodigoCliente=@1,Observacao=@2,Datapedido=@3,Datafechamento=@4,DataPrazoEntrega=@6,CodigoFuncionario=@7,TotalBruto=@8,TotalDesconto=@9,TotalLiquido=@10,CodigoPagamento=@11,Contato=@12,ValorSerigrafia=@13,ValorBordado=@14,ValorMp=@15,Status=@16,NomeCliente=@18, telefone=@19, email=@20,ValorAVista=@21,ValorOutros=@22, ValorAFaturar=@23, DataValidade=@24, GeradoPedido=@25, OrcForPed=@26 where Modelo='" & Modelo & "' and  NumeroPedido=" & xID
        Try
            cnn = db.AbreBanco
            Dim cmd As New OleDbCommand(sql, cnn)
            With cmd.Parameters
                .Add(New OleDb.OleDbParameter("@1", CodigoCliente))
                .Add(New OleDb.OleDbParameter("@2", Nz(Observacao, 1)))
                .Add(New OleDb.OleDbParameter("@3", Nz(Me.DataPedido, 1)))
                .Add(New OleDb.OleDbParameter("@4", Nz(Me.DataFechamento, 1)))
                .Add(New OleDb.OleDbParameter("@6", Nz(Me.DataPrazoEntrega, 1)))
                .Add(New OleDb.OleDbParameter("07", Me.CodigoFuncionario))
                .Add(New OleDb.OleDbParameter("@8", NzZero(TotalBruto)))
                .Add(New OleDb.OleDbParameter("@9", NzZero(TotalDesconto)))
                .Add(New OleDb.OleDbParameter("@10", NzZero(TotalLiquido)))
                .Add(New OleDb.OleDbParameter("@11", NzVlr(CodigoPagamento)))
                .Add(New OleDb.OleDbParameter("@12", Nz(Contato, 1)))
                .Add(New OleDb.OleDbParameter("@13", NzZero(ValorSerigrafia)))
                .Add(New OleDb.OleDbParameter("@14", NzZero(ValorBordado)))
                .Add(New OleDb.OleDbParameter("@15", Nz(ValorMP, 3)))
                .Add(New OleDb.OleDbParameter("@16", Status))
                .Add(New OleDb.OleDbParameter("@18", nomeCliente))
                .Add(New OleDb.OleDbParameter("@19", Telefone))
                .Add(New OleDb.OleDbParameter("@20", Email))
                .Add(New OleDb.OleDbParameter("@21", Valorvista))
                .Add(New OleDb.OleDbParameter("@22", Valorcheque))
                .Add(New OleDb.OleDbParameter("@23", Valorfaturar))
                .Add(New OleDb.OleDbParameter("@24", Nz(Datavalidade, 1)))
                .Add(New OleDb.OleDbParameter("@25", Gerado_pedido))
                .Add(New OleDb.OleDbParameter("@26", NzZero(OrcForPed)))


            End With
            cmd.ExecuteNonQuery()

        Catch ex As Exception

            Throw ex
        Finally
            cnn.Close()
        End Try


    End Sub

    Public Function EncheGrid(ByVal ds As DataSet, ByVal mode As String) As DataSet
        Try
            Dim conn As New OleDbConnection()
            conn = db.AbreBanco
            Dim sql As String
            sql = "SELECT PedidoMateriaPrima.NumeroPedido, PedidoMateriaPrima.Modelo, PedidoMateriaPrima.DataPedido, PedidoMateriaPrima.NomeCliente AS Cliente, Funcionários.Nome AS Vendedor, PedidoMateriaPrima.TotalLiquido, PedidoMateriaPrima.Status FROM (Funcionários INNER JOIN (Clientes RIGHT JOIN PedidoMateriaPrima ON Clientes.Codigo = PedidoMateriaPrima.CodigoCliente) ON Funcionários.CódigoFuncionário = PedidoMateriaPrima.CodigoFuncionario) WHERE PedidoMateriaPrima.Modelo='" & mode & "';"
            Dim CMD As New OleDb.OleDbCommand(sql, conn)
            Dim Da As New OleDb.OleDbDataAdapter(CMD)
            Da.Fill(ds, "Table")
            Da.Dispose()
            conn.Close()
            Return ds
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return ds
        End Try
    End Function

    Public Sub ExcluirParcelas(ByVal xID As Integer, ByVal opc As String)

        Dim sql As String = ""

        Select Case opc
            Case "0" ' exclui somente o item selecionsado
                sql = "Delete idParcelamento from PedidoCompraParcelamento where ididParcelamento=" & xID
            Case "1" ' exclui todos os items
                sql = "Delete * from PedidoCompraParcelamento where CodigoPedidoCompra=" & xID
        End Select
        Dim cnn As New OleDbConnection
        Try
            cnn.Open()
            Dim cmd As New OleDbCommand(sql, cnn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            cnn.Close()
        End Try


    End Sub
    Public Sub Gravar()

        Dim sql As String
        sql = "INSERT INTO PEDIDOMATERIAPRIMA (CodigoCliente,Observacao,Datapedido,Datafechamento,DataPrazoEntrega,CodigoFuncionario,TotalBruto,TotalDesconto,TotalLiquido,CodigoPagamento,Contato,ValorSerigrafia,ValorBordado,ValorMp,Status,NumeroPedido,Modelo, NomeCliente, Telefone, Email, Empresa, DataValidade, GeradoPedido) Values (@1,@2,@3,@4,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@18,@19,@20,@21,@22,@23,@24,@25)"

        Dim conn As New OleDbConnection
        Try
            conn = db.AbreBanco

            Dim cmd As OleDbCommand

            If Modelo = "P" Then
                cmd = New OleDbCommand("SELECT Max(PedidoMateriaPrima.NumeroPedido) AS MáxDeNumeroPedido  FROM PedidoMateriaPrima WHERE (((PedidoMateriaPrima.Modelo)='P'))", conn)
            Else
                cmd = New OleDbCommand("SELECT Max(PedidoMateriaPrima.NumeroPedido) AS MáxDeNumeroPedido  FROM PedidoMateriaPrima WHERE (((PedidoMateriaPrima.Modelo)='O'))", conn)
            End If


            Retorno = cmd.ExecuteScalar.ToString
            If Retorno = "" Then
                Retorno = "1"
            Else
                Retorno = String.Format("{0:00}", Convert.ToInt16(Retorno) + 1)
            End If

            cmd = New OleDbCommand(sql, conn)
            With cmd.Parameters
                .Add(New OleDb.OleDbParameter("@@", CodigoCliente))
                .Add(New OleDb.OleDbParameter("@2", Nz(Me.Observacao, 1)))
                .Add(New OleDb.OleDbParameter("@3", Nz(Me.DataPedido, 1)))
                .Add(New OleDb.OleDbParameter("@4", Nz(Me.DataFechamento, 1)))
                .Add(New OleDb.OleDbParameter("@6", Nz(Me.DataPrazoEntrega, 1)))
                .Add(New OleDb.OleDbParameter("07", Me.CodigoFuncionario))
                .Add(New OleDb.OleDbParameter("@8", NzZero(TotalBruto)))
                .Add(New OleDb.OleDbParameter("@9", NzZero(TotalDesconto)))
                .Add(New OleDb.OleDbParameter("@10", NzZero(TotalLiquido)))
                .Add(New OleDb.OleDbParameter("@11", NzVlr(CodigoPagamento)))
                .Add(New OleDb.OleDbParameter("@12", Nz(Contato, 1)))
                .Add(New OleDb.OleDbParameter("@13", NzZero(ValorSerigrafia)))
                .Add(New OleDb.OleDbParameter("@14", NzZero(ValorBordado)))
                .Add(New OleDb.OleDbParameter("@15", Nz(ValorMP, 3)))
                .Add(New OleDb.OleDbParameter("@16", Status))
                .Add(New OleDb.OleDbParameter("@18", Retorno))
                .Add(New OleDb.OleDbParameter("@19", Modelo))
                .Add(New OleDb.OleDbParameter("@20", nomeCliente))
                .Add(New OleDb.OleDbParameter("@21", Telefone))
                .Add(New OleDb.OleDbParameter("@22", Email))
                .Add(New OleDb.OleDbParameter("@23", Empresa))
                .Add(New OleDb.OleDbParameter("@24", Nz(Datavalidade, 1)))
                .Add(New OleDb.OleDbParameter("@25", Gerado_pedido))

            End With
            'Dim ss As Object = System.DBNull.Value
            'Dim tt As String = NzVlr(ss)
            cmd.ExecuteNonQuery()

            ErroRetorno = False

        Catch ex As Exception
            Throw ex
            ErroRetorno = True
        Finally
            conn.Close()
        End Try


    End Sub

    Public Sub Localizar(ByVal xID As Integer)
        Dim cnn As New OleDbConnection


        Dim Sql As String = "SELECT PedidoCompra.*, Funcionários.Nome, Fornecedor.RazãoSocial FROM (PedidoCompra INNER JOIN Funcionários ON PedidoCompra.CodigoFuncionario = Funcionários.CódigoFuncionário) INNER JOIN Fornecedor ON PedidoCompra.CodigoFornecedor = Fornecedor.CódigoFornecedor WHERE PedidoCompra.CodigoPedidoCompra=" & xID

        Dim DR As OleDb.OleDbDataReader
        Try
            cnn.Open()
            Dim cmd As New OleDbCommand(Sql, cnn)
            DR = cmd.ExecuteReader
            DR.Read()

            If DR.HasRows Then
                NumeroPedido = DR.Item("CodigoPedidocompra")
                CodigoCliente = DR.Item("codigofornecedor")
                CodigoFuncionario = NzZero(DR.Item("codigofuncionario"))
                nomeCliente = DR.Item("RazãoSocial")
                NomeVendedor = DR.Item("Nome")
                DataPedido = DR.Item("DataLancamento")
                DataPrazoEntrega = DR.Item("DataPrevistaEntrega") & ""
                TotalLiquido = DR.Item("Totalpedidocompra")
                Observacao = DR.Item("obs") & ""
                Localizado = True
            Else
                Localizado = False
            End If

        Catch ex As Exception
            Throw ex
        Finally
            cnn.Close()
        End Try

    End Sub

    Public Sub LoclizaItemParaEditar(ByVal xID As Integer)
        Dim cnn As New OleDbConnection


        Dim Sql As String = "SELECT PedidoCompraItem.CompraInterno, PedidoCompra.Confirmado, [qtd]-[QtdEntregue] AS Resta FROM PedidoCompraItem INNER JOIN PedidoCompra ON PedidoCompraItem.CompraInterno = PedidoCompra.CodigoPedidoCompra WHERE (((PedidoCompraItem.CompraInterno)=" & xID & ") AND ((PedidoCompra.Confirmado)=True) AND (([qtd]-[QtdEntregue])>0));"
        Dim DR As OleDb.OleDbDataReader
        Try
            cnn.Open()
            Dim cmd As New OleDbCommand(Sql, cnn)
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
            cnn.Close()
        End Try

    End Sub

    Public Sub MostrarPedido(ByVal xid As Integer, mode As String)
        Dim sql As String
        sql = "SELECT PedidoMateriaPrima.*, Clientes.Nome AS Cliente, Funcionários.Nome AS Vendedor, FormaPgto.Descrição AS FormaPgto FROM FormaPgto RIGHT JOIN (Clientes RIGHT JOIN (Funcionários INNER JOIN PedidoMateriaPrima ON Funcionários.CódigoFuncionário = PedidoMateriaPrima.CodigoFuncionario) ON Clientes.Codigo = PedidoMateriaPrima.CodigoCliente) ON FormaPgto.CodFormaPgto = PedidoMateriaPrima.CodigoPagamento WHERE (((PedidoMateriaPrima.NumeroPedido)=" & xid & ") and ((PedidoMateriaPrima.Modelo)='" & mode & "'));"

        Dim conn As New OleDbConnection
        Dim DR As OleDbDataReader

        Try

            conn = db.AbreBanco()
            Dim cmd As New OleDbCommand(sql, conn)
            DR = cmd.ExecuteReader

            DR.Read()
            If DR.HasRows Then
                Me.NumeroPedido = String.Format("{0:000000}", DR.Item("NumeroPedido"))
                Me.CodigoCliente = DR.Item("Codigocliente") & ""
                Me.nomeCliente = DR.Item("NomeCliente") & ""
                Me.Telefone = DR.Item("Telefone") & ""
                Me.Email = DR.Item("email") & ""
                Me.Observacao = DR.Item("Observacao") & ""
                Me.DataPedido = DR.Item("DataPedido") & ""
                Me.DataFechamento = DR.Item("DataFechamento") & ""
                Me.DataPrazoEntrega = DR.Item("DataPrazoEntrega") & ""
                Me.CodigoFuncionario = DR.Item("CodigoFuncionario") & ""
                Me.TotalBruto = DR.Item("TotalBruto") & ""
                Me.TotalDesconto = DR.Item("TotalDesconto") & ""
                Me.TotalLiquido = DR.Item("TotalLiquido") & ""
                Me.CodigoPagamento = DR.Item("CodigoPagamento") & ""
                Me.Fechado = DR.Item("Fechado") & ""
                Me.Inativo = DR.Item("Inativo") & ""
                Me.ValorSerigrafia = DR.Item("ValorSerigrafia") & ""
                Me.ValorBordado = DR.Item("ValorBordado") & ""
                Me.ValorMP = DR.Item("ValorMP") & ""
                Me.Status = DR.Item("Status") & ""
                Me.Contato = DR.Item("Contato") & ""
                Me.NomeVendedor = DR.Item("Vendedor") & ""
                Me.Codigopagamentodesc = DR.Item("FormaPgto") & ""
                Me.Valorcheque = NzZero(DR.Item("ValorOutros"))
                Me.Valorvista = NzZero(DR.Item("ValorAVista"))
                Me.Valorfaturar = NzZero(DR.Item("ValorAFaturar"))
                Datavalidade = DR.Item("DataValidade") & ""
                Gerado_pedido = DR.Item("GeradoPedido")
                OrcForPed = DR.Item("OrcForPed") & ""
                If mode = "O" Then
                    Me.Modelo = "ORCAMENTO"
                Else
                    Me.Modelo = "PEDIDO"
                End If
                ErroRetorno = False
            Else
                ErroRetorno = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            db.fechabanco(conn)
        End Try
    End Sub

    Public Sub SaveItensPedido(ByVal IdPed As String)
        Dim sql As String
        sql = "INSERT INTO ItensPedidoMPConfec ( NumeroPedidoMP, Modelo, Descricao, Tamanho, Qtd, ValorUnitario, Valortotal, CodigoGrupo, CodigoProdutoMP, QtdReserva, LancamentoNaReserva ) SELECT " & Retorno & ", 'P', ItensPedidoMPConfec.Descricao, ItensPedidoMPConfec.Tamanho, ItensPedidoMPConfec.Qtd, ItensPedidoMPConfec.ValorUnitario, ItensPedidoMPConfec.Valortotal, ItensPedidoMPConfec.CodigoGrupo, ItensPedidoMPConfec.CodigoProdutoMP, ItensPedidoMPConfec.QtdReserva, ItensPedidoMPConfec.LancamentoNaReserva FROM ItensPedidoMPConfec WHERE (((ItensPedidoMPConfec.NumeroPedidoMP)=" & IdPed & ") AND ((ItensPedidoMPConfec.Modelo)='O'));"
        Dim conn As New OleDbConnection

        Try
            conn = db.AbreBanco
            Dim cmd As New OleDbCommand(sql, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Foi gerado o Pedido de número " & Retorno & " com sucesso!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        Catch ex As Exception
            Throw ex
        Finally
            db.fechabanco(conn)
        End Try
    End Sub
    Public Property OrcForPed() As String
        Get
            Return m_orcForPed
        End Get
        Set(ByVal value As String)
            m_orcForPed = value
        End Set
    End Property
End Class
