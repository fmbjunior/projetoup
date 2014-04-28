Public Class ExportPAFItemVenda
    Private vSequencialItem As String
    Private vCodigoBarra As String
    Private vQuantidade As String
    Private vValorUnitario As String
    Private vValorAcrescimo As String
    Private vValorDesconto As String
    Private vTotalPagar As String
    Private vTipoTributo As String
    Private vValorAliquota As String
    Private vValorLiquido As String
    Public Property SequencialItem() As String
        Get
            Return vSequencialItem
        End Get
        Set(ByVal value As String)
            vSequencialItem = value
            vSequencialItem = vSequencialItem.PadLeft(3, "0") 'Insere zero a esquerda
        End Set
    End Property
    Public Property CodigoBarra() As String
        Get
            Return vCodigoBarra
        End Get
        Set(ByVal value As String)
            vCodigoBarra = value
            vCodigoBarra = vCodigoBarra.PadLeft(13, "0") 'Insere zero a esquerda
        End Set
    End Property

    Public Property Quantidade() As String
        Get
            Return vQuantidade
        End Get
        Set(ByVal value As String)
            vQuantidade = Replace(value, ".", "") 'Retira o ponto
            vQuantidade = Replace(vQuantidade, ",", "") 'retira a virgula
            vQuantidade = vQuantidade.PadLeft(10, "0") 'Insere zero a esquerda
        End Set
    End Property
    Public Property ValorUnitario() As String
        Get
            Return vValorUnitario
        End Get
        Set(ByVal value As String)
            vValorUnitario = Replace(value, ".", "") 'Retira o ponto
            vValorUnitario = Replace(vValorUnitario, ",", "") 'retira a virgula
            vValorUnitario = vValorUnitario.PadLeft(11, "0") 'Insere zero a esquerda

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
    Public Property TipoTributo() As String
        Get
            Return vTipoTributo
        End Get
        Set(ByVal value As String)
            vTipoTributo = value
        End Set
    End Property
    Public Property ValorAliquota() As String
        Get
            Return vValorAliquota
        End Get
        Set(ByVal value As String)
            vValorAliquota = Replace(value, ".", "") 'Retira o ponto
            vValorAliquota = Replace(vValorAliquota, ",", "") 'retira a virgula
            vValorAliquota = vValorAliquota.PadLeft(5, "0") 'Insere zero a esquerda

        End Set
    End Property
    Public Property ValorLiquido() As String
        Get
            Return vValorLiquido
        End Get
        Set(ByVal value As String)
            vValorLiquido = Replace(value, ".", "") 'Retira o ponto
            vValorLiquido = Replace(vValorLiquido, ",", "") 'retira a virgula
            vValorLiquido = vValorLiquido.PadLeft(11, "0") 'Insere zero a esquerda

        End Set
    End Property
End Class
