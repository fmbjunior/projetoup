Public Class ExporPAFProduto
    Private vCodigoBarra As String
    Private vDescricaoResumida As String
    Private vDescricaoCompleta As String
    Private vUnidadeMedida As String
    Private vUnidade As String
    Private vGrupo As String
    Private vSubGrupo As String
    Private vLaboratorio As String
    Private vMarca As String
    Private vTipoTributo As String
    Private vAliquota As String
    Private vST As String
    Private vQtdPorEmbalagem As String
    Private vComissao As String
    Private vFatoracao As String
    Private vAplicacao As String
    Private vPrecoVenda As String
    Private vPrecoCusto As String
    Private vEstoqueMinimo As String
    Private vEstoqueAtual As String
    Private vLocalizacao As String
    Private vNumeroOP As String
    Private vNumeroPeca As String
    Private vMedida As String

    Public Property CodigoBarra() As String
        Get
            Return vCodigoBarra
        End Get
        Set(ByVal value As String)
            vCodigoBarra = value
        End Set
    End Property
    Public Property DescricaoResumida() As String
        Get
            Return vDescricaoResumida
        End Get
        Set(ByVal value As String)
            vDescricaoResumida = value
        End Set
    End Property
    Public Property DescricaoCompleta() As String
        Get
            Return vDescricaoCompleta
        End Get
        Set(ByVal value As String)
            vDescricaoCompleta = value
        End Set
    End Property
    Public Property UnidadeMedida() As String
        Get
            Return vUnidadeMedida
        End Get
        Set(ByVal value As String)
            vUnidadeMedida = value
        End Set
    End Property
    Public Property Unidade() As String
        Get
            Return vUnidade
        End Get
        Set(ByVal value As String)
            vUnidade = value
        End Set
    End Property
    Public Property Grupo() As String
        Get
            Return vGrupo
        End Get
        Set(ByVal value As String)
            vGrupo = value
        End Set
    End Property
    Public Property SubGrupo() As String
        Get
            Return vSubGrupo
        End Get
        Set(ByVal value As String)
            vSubGrupo = value
        End Set
    End Property
    Public Property Laboratorio() As String
        Get
            Return vLaboratorio
        End Get
        Set(ByVal value As String)
            vLaboratorio = value
        End Set
    End Property
    Public Property Marca() As String
        Get
            Return vMarca
        End Get
        Set(ByVal value As String)
            vMarca = value
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
    Public Property Aliquota() As String
        Get
            Return vAliquota
        End Get
        Set(ByVal value As String)
            vAliquota = Replace(value, ".", "") 'Retira o ponto
            vAliquota = Replace(vAliquota, ",", "") 'retira a virgula
            vAliquota = vAliquota.PadLeft(5, "0") 'Insere zero a esquerda
        End Set
    End Property
    Public Property QtdPorEmbalagem() As String
        Get
            Return vQtdPorEmbalagem
        End Get
        Set(ByVal value As String)
            vQtdPorEmbalagem = value
        End Set
    End Property
    Public Property ST() As String
        Get
            Return vST
        End Get
        Set(ByVal value As String)
            vST = value
            vST = vST.PadLeft(3, "0") 'Insere zero a esquerda
        End Set
    End Property
    Public Property Comissao() As String
        Get
            Return vComissao
        End Get
        Set(ByVal value As String)
            vComissao = Replace(value, ".", "") 'Retira o ponto
            vComissao = Replace(vComissao, ",", "") 'retira a virgula
            vComissao = vComissao.PadLeft(5, "0") 'Insere zero a esquerda
        End Set
    End Property
    Public Property Fatoracao() As String
        Get
            Return vFatoracao
        End Get
        Set(ByVal value As String)
            vFatoracao = Replace(value, ".", "") 'Retira o ponto
            vFatoracao = Replace(vFatoracao, ",", "") 'retira a virgula
            vFatoracao = vFatoracao.PadLeft(5, "0") 'Insere zero a esquerda
        End Set
    End Property
    Public Property Aplicacao() As String
        Get
            Return vAplicacao
        End Get
        Set(ByVal value As String)
            vAplicacao = value.TrimStart
        End Set
    End Property
    Public Property PrecoVenda() As String
        Get
            Return vPrecoVenda
        End Get
        Set(ByVal value As String)
            vPrecoVenda = Replace(value, ".", "") 'Retira o ponto
            vPrecoVenda = Replace(vPrecoVenda, ",", "") 'retira a virgula
            vPrecoVenda = vPrecoVenda.PadLeft(11, "0") 'Insere zero a esquerda
        End Set
    End Property
    Public Property PrecoCusto() As String
        Get
            Return vPrecoCusto
        End Get
        Set(ByVal value As String)
            vPrecoCusto = Replace(value, ".", "") 'Retira o ponto
            vPrecoCusto = Replace(vPrecoCusto, ",", "") 'retira a virgula
            vPrecoCusto = vPrecoCusto.PadLeft(11, "0") 'Insere zero a esquerda
        End Set
    End Property
    Public Property EstoqueMinimo() As String
        Get
            Return vEstoqueMinimo
        End Get
        Set(ByVal value As String)
            vEstoqueMinimo = Replace(value, ".", "") 'Retira o ponto
            vEstoqueMinimo = Replace(vEstoqueMinimo, ",", "") 'retira a virgula
            vEstoqueMinimo = vEstoqueMinimo.PadLeft(11, "0") 'Insere zero a esquerda
        End Set
    End Property
    Public Property EstoqueAtual() As String
        Get
            Return vEstoqueAtual
        End Get
        Set(ByVal value As String)
            vEstoqueAtual = Replace(value, ".", "") 'Retira o ponto
            vEstoqueAtual = Replace(vEstoqueAtual, ",", "") 'retira a virgula
            vEstoqueAtual = vEstoqueAtual.PadLeft(11, "0") 'Insere zero a esquerda
        End Set
    End Property
    Public Property Localizacao() As String
        Get
            Return vLocalizacao
        End Get
        Set(ByVal value As String)
            vLocalizacao = value
        End Set
    End Property
    Public Property NumeroOP() As String
        Get
            Return vNumeroOP
        End Get
        Set(ByVal value As String)
            vNumeroOP = value
        End Set
    End Property
    Public Property NumeroPeca() As String
        Get
            Return vNumeroPeca
        End Get
        Set(ByVal value As String)
            vNumeroPeca = value
        End Set
    End Property
    Public Property Medida() As String
        Get
            Return vMedida
        End Get
        Set(ByVal value As String)
            vMedida = value
        End Set
    End Property


End Class
