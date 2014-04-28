Imports System.Data.OleDb
Public Class ClassMostraPedido
    Dim db As New clsBancoDados
    Private m_nomecliente As String
    Private m_valorbordado As Double
    Private m_valorserigrafia As Double
    Private m_comissao As Double
    Private m_codigopagamento As String
    Private m_codigofuncionario As String
    Private m_dataprazoentrega As String
    Private m_datafechamento2 As String
    Private m_fechado As Boolean
    Private m_Tipo As String
    Private m_inativo As Boolean
    Private m_geradodp As Boolean
    Private m_contato As String
    Private m_status As String
    Private m_valormp As Double
    Private m_nomefazenda As String
    Private m_condicaopagamentoDesc As String
    Private m_nomevendedor As String
    Private m_nomeoperacao As String
    Private m_obs As String
    Private m_datafechamento As String
    Private m_totalliquido As Double
    Private m_totalbruto As Double
    Private m_totaldescontos As Double
    Private m_datapedido As String
    Private m_codigocliente As String
    Private m_codigovendeor As String
    Private m_requisicao As String
    Private m_codigofazenda As String
    Private m_CodigoOperacao As String
    Private m_numeroPedido As String
    Public Property nomecliente() As String
        Get
            Return m_nomecliente
        End Get
        Set(ByVal value As String)
            m_nomecliente = value
        End Set
    End Property

    Public Sub MostrarPedido(ByVal xid As Integer)
        Dim sql As String

        sql = "SELECT PedidoMateriaPrima.*, Operacao.Descricao AS NomeOperacao, Funcionario.Func_Apelido, Clientes.Nome, CondicaoPagamento.Descricao AS CondicaoPagamento, Fazendas.Faz_NomeFazenda FROM Funcionario INNER JOIN (Clientes INNER JOIN (Fazendas RIGHT JOIN ((Operacao INNER JOIN PedidoMateriaPrima ON Operacao.codOperacao = PedidoMateriaPrima.Operacao) LEFT JOIN CondicaoPagamento ON PedidoMateriaPrima.CodigoPagamento = CondicaoPagamento.CodigoPagamento) ON Fazendas.Faz_ID = PedidoMateriaPrima.Propriedade) ON Clientes.Codigo = PedidoMateriaPrima.CodigoCliente) ON Funcionario.Func_Codigo = PedidoMateriaPrima.CodigoFuncionario WHERE (((PedidoMateriaPrima.NumeroPedido)=" & xid & "));"


        Dim conn As New OleDbConnection
        Dim DR As OleDbDataReader

        Try
            conn = db.AbreBanco()
            Dim cmd As New OleDbCommand(sql, conn)
            DR = cmd.ExecuteReader
            DR.Read()

            Me.numeroPedido = String.Format("{0:00000}", DR.Item(0))
            Me.codigocliente = DR.Item(1) & ""
            Me.obs = DR.Item(2) & ""
            Me.datapedido = DR.Item(3) & ""
            Me.datafechamento = DR.Item(4) & ""
            Me.datafechamento2 = DR.Item(5) & ""
            Me.dataprazoentrega = DR.Item(6) & ""
            Me.codigofuncionario = DR.Item(7) & ""
            Me.totalbruto = DR.Item(8) & ""
            Me.totaldescontos = DR.Item(9) & ""
            Me.totalliquido = DR.Item(10) & ""
            Me.codigopagamento = DR.Item(11) & ""
            Me.fechado = DR.Item(12) & ""
            Me.geradodp = DR.Item(13) & ""
            Me.Tipo = DR.Item(14) & ""
            Me.comissao = DR.Item(16) & ""
            Me.inativo = DR.Item(18) & ""
            Me.valorserigrafia = DR.Item(19) & ""
            Me.valorbordado = DR.Item(20) & ""
            Me.valormp = DR.Item(21) & ""
            Me.status = DR.Item(22) & ""
            Me.CodigoOperacao = DR.Item(23)
            Me.contato = DR.Item(24) & ""
            Me.codigofazenda = DR.Item(25) & ""
            Me.nomeoperacao = DR.Item(26) & ""
            Me.nomevendedor = DR.Item(27) & ""
            Me.nomecliente = DR.Item(28) & ""
            Me.condicaopagamentoDesc = DR.Item(29) & ""
            Me.nomefazenda = DR.Item(30) & ""
        Catch ex As Exception
            Throw ex
        Finally
            db.fechabanco(conn)
        End Try
    End Sub
    Public Property comissao() As Double
        Get
            Return m_comissao
        End Get
        Set(ByVal value As Double)
            m_comissao = value
        End Set
    End Property
    Public Property valorserigrafia() As Double
        Get
            Return m_valorserigrafia
        End Get
        Set(ByVal value As Double)
            m_valorserigrafia = value
        End Set
    End Property
    Public Property numeroPedido() As String
        Get
            Return m_numeroPedido
        End Get
        Set(ByVal value As String)
            m_numeroPedido = value
        End Set
    End Property

    Public Property CodigoOperacao() As String
        Get
            Return m_CodigoOperacao
        End Get
        Set(ByVal value As String)
            m_CodigoOperacao = value
        End Set
    End Property

    Public Property codigofazenda() As String
        Get
            Return m_codigofazenda
        End Get
        Set(ByVal value As String)
            m_codigofazenda = value
        End Set
    End Property

    Public Property requisicao() As String
        Get
            Return m_requisicao
        End Get
        Set(ByVal value As String)
            m_requisicao = value
        End Set
    End Property

    Public Property codigovendeor() As String
        Get
            Return m_codigovendeor
        End Get
        Set(ByVal value As String)
            m_codigovendeor = value
        End Set
    End Property

    Public Property codigocliente() As String
        Get
            Return m_codigocliente
        End Get
        Set(ByVal value As String)
            m_codigocliente = value
        End Set
    End Property

    Public Property datapedido() As String
        Get
            Return m_datapedido
        End Get
        Set(ByVal value As String)
            m_datapedido = value
        End Set
    End Property

    Public Property totaldescontos() As Double
        Get
            Return m_totaldescontos
        End Get
        Set(ByVal value As Double)
            m_totaldescontos = value
        End Set
    End Property

    Public Property totalbruto() As Double
        Get
            Return m_totalbruto
        End Get
        Set(ByVal value As Double)
            m_totalbruto = value
        End Set
    End Property

    Public Property totalliquido() As Double
        Get
            Return m_totalliquido
        End Get
        Set(ByVal value As Double)
            m_totalliquido = value
        End Set
    End Property

    Public Property datafechamento() As String
        Get
            Return m_datafechamento
        End Get
        Set(ByVal value As String)
            m_datafechamento = value
        End Set
    End Property

    Public Property obs() As String
        Get
            Return m_obs
        End Get
        Set(ByVal value As String)
            m_obs = value
        End Set
    End Property

    Public Property nomeoperacao() As String
        Get
            Return m_nomeoperacao
        End Get
        Set(ByVal value As String)
            m_nomeoperacao = value
        End Set
    End Property

    Public Property nomevendedor() As String
        Get
            Return m_nomevendedor
        End Get
        Set(ByVal value As String)
            m_nomevendedor = value
        End Set
    End Property

    Public Property condicaopagamentoDesc() As String
        Get
            Return m_condicaopagamentoDesc
        End Get
        Set(ByVal value As String)
            m_condicaopagamentoDesc = value
        End Set
    End Property

    Public Property nomefazenda() As String
        Get
            Return m_nomefazenda
        End Get
        Set(ByVal value As String)
            m_nomefazenda = value
        End Set
    End Property

    Public Property valormp() As Double
        Get
            Return m_valormp
        End Get
        Set(ByVal value As Double)
            m_valormp = value
        End Set
    End Property

    Public Property status() As String
        Get
            Return m_status
        End Get
        Set(ByVal value As String)
            m_status = value
        End Set
    End Property

    Public Property contato() As String
        Get
            Return m_contato
        End Get
        Set(ByVal value As String)
            m_contato = value
        End Set
    End Property

    Public Property geradodp() As Boolean
        Get
            Return m_geradodp
        End Get
        Set(ByVal value As Boolean)
            m_geradodp = value
        End Set
    End Property

    Public Property inativo() As Boolean
        Get
            Return m_inativo
        End Get
        Set(ByVal value As Boolean)
            m_inativo = value
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return m_Tipo
        End Get
        Set(ByVal value As String)
            m_Tipo = value
        End Set
    End Property

    Public Property fechado() As Boolean
        Get
            Return m_fechado
        End Get
        Set(ByVal value As Boolean)
            m_fechado = value
        End Set
    End Property

    Public Property datafechamento2() As String
        Get
            Return m_datafechamento2
        End Get
        Set(ByVal value As String)
            m_datafechamento2 = value
        End Set
    End Property

    Public Property dataprazoentrega() As String
        Get
            Return m_dataprazoentrega
        End Get
        Set(ByVal value As String)
            m_dataprazoentrega = value
        End Set
    End Property

    Public Property codigofuncionario() As String
        Get
            Return m_codigofuncionario
        End Get
        Set(ByVal value As String)
            m_codigofuncionario = value
        End Set
    End Property

    Public Property codigopagamento() As String
        Get
            Return m_codigopagamento
        End Get
        Set(ByVal value As String)
            m_codigopagamento = value
        End Set
    End Property

    Public Property valorbordado() As Double
        Get
            Return m_valorbordado
        End Get
        Set(ByVal value As Double)
            m_valorbordado = value
        End Set
    End Property

End Class
