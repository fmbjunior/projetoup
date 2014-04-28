
Public Class ExporPAFPedido

    Private vTipoRegistro As String
    Private vNumeroDocumento As String
    Private vDataEmissao As String
    Private vCPFVendedor As String
    Private vCPFCliente As String
    Private vTotalVenda As String
    Private vValorAcrescimo As String
    Private vValorDesconto As String
    Private vTotalPagar As String
    Private vValorComissao As String
    Private vFormaPagamento As String
    Private vTipoPagamento As String
    Private vDescricaoPagamento As String
    Private vNumeroParcelas As String
    Private vPagamentoVista As String
    Public Property TipoRegistro() As String
        Get
            Return vTipoRegistro
        End Get
        Set(ByVal value As String)
            vTipoRegistro = value
        End Set
    End Property
    Public Property NumeroDocumento() As String
        Get
            Return vNumeroDocumento
        End Get
        Set(ByVal value As String)
            vNumeroDocumento = value
            vNumeroDocumento = vNumeroDocumento.PadLeft(10, "0")
        End Set
    End Property

    Public Property DataEmissao() As String
        Get
            Return vDataEmissao
        End Get
        Set(ByVal value As String)
            vDataEmissao = value
            vDataEmissao = Replace(value, "/", "") 'Retira o ponto

        End Set
    End Property
    Public Property CPFVendedor() As String
        Get
            Return vCPFVendedor
        End Get
        Set(ByVal value As String)
            vCPFVendedor = value
        End Set
    End Property
    Public Property CPFCliente() As String
        Get
            Return vCPFCliente
        End Get
        Set(ByVal value As String)
            vCPFCliente = value
        End Set
    End Property
    Public Property TotalVenda() As String
        Get
            Return vTotalVenda
        End Get
        Set(ByVal value As String)
            vTotalVenda = Replace(value, ".", "") 'Retira o ponto
            vTotalVenda = Replace(vTotalVenda, ",", "") 'retira a virgula
            vTotalVenda = vTotalVenda.PadLeft(11, "0") 'Insere zero a esquerda

        End Set
    End Property
    Public Property ValorAcrescimo() As String
        Get
            Return vValorAcrescimo
        End Get
        Set(ByVal value As String)
            vValorAcrescimo = Replace(value, ".", "") 'Retira o ponto
            vValorAcrescimo = Replace(vValorAcrescimo, ",", "") 'retira a virgula
            vValorAcrescimo = vValorAcrescimo.PadLeft(11, "0") 'Insere zero a esquerda
        End Set
    End Property
    Public Property ValorDesconto() As String
        Get
            Return vValorDesconto
        End Get
        Set(ByVal value As String)
            vValorDesconto = Replace(value, ".", "") 'Retira o ponto
            vValorDesconto = Replace(vValorDesconto, ",", "") 'retira a virgula
            vValorDesconto = vValorDesconto.PadLeft(11, "0") 'Insere zero a esquerda

        End Set
    End Property
    Public Property TotalPagar() As String
        Get
            Return vTotalPagar
        End Get
        Set(ByVal value As String)
            vTotalPagar = Replace(value, ".", "") 'Retira o ponto
            vTotalPagar = Replace(vTotalPagar, ",", "") 'retira a virgula
            vTotalPagar = vTotalPagar.PadLeft(11, "0") 'Insere zero a esquerda

        End Set
    End Property
    Public Property ValorComissao() As String
        Get
            Return vValorComissao
        End Get
        Set(ByVal value As String)
            vValorComissao = Replace(value, ".", "") 'Retira o ponto
            vValorComissao = Replace(vValorComissao, ",", "") 'retira a virgula
            vValorComissao = vValorComissao.PadLeft(11, "0") 'Insere zero a esquerda
        End Set
    End Property
    Public Property FormaPagamento() As String
        Get
            Return vFormaPagamento
        End Get
        Set(ByVal value As String)
            vFormaPagamento = value
        End Set
    End Property
    Public Property TipoPagamento() As String
        Get
            Return vTipoPagamento
        End Get
        Set(ByVal value As String)
            vTipoPagamento = value
        End Set
    End Property
    Public Property DescricaoPagamento() As String
        Get
            Return vDescricaoPagamento
        End Get
        Set(ByVal value As String)
            vDescricaoPagamento = value
        End Set
    End Property
    Public Property NumeroParcelas() As String
        Get
            Return vNumeroParcelas
        End Get
        Set(ByVal value As String)
            vNumeroParcelas = value
        End Set
    End Property
    Public Property PagamentoVista() As String
        Get
            Return vPagamentoVista
        End Get
        Set(ByVal value As String)
            vPagamentoVista = value
        End Set
    End Property



End Class
