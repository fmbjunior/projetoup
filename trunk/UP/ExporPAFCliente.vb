Public Class ExporPAFCliente
    Private vCodigoCliente As String
    Private vNome As String
    Private vCpfCgc As String
    Private vRg As String
    Private vIE As String
    Private vIM As String
    Private vEmail As String
    Private vTelResidencial As String
    Private vTelComercial As String
    Private vTelCelular As String
    Private vTelObs As String
    Private vLimiteCredito As String
    Private vCRM As String
    Private vcidade As String
    Private vEstado As String
    Private vTipoLogradouro As String
    Private vLogradouro As String
    Private vNum As String
    Private vTipoBairro
    Private vBairro
    Private vComplemento As String
    Private vCep As String

    Public Property codigo() As String
        Get
            Return vCodigoCliente
        End Get
        Set(ByVal value As String)
            vCodigoCliente = value
        End Set
    End Property
    Public Property CPFCGC() As String
        Get
            Return vCpfCgc
        End Get
        Set(ByVal value As String)
            vCpfCgc = value
        End Set
    End Property
    Public Property Nome() As String
        Get
            Return vNome
        End Get
        Set(ByVal value As String)
            vNome = value
        End Set
    End Property
    Public Property RG() As String
        Get
            Return vRg
        End Get
        Set(ByVal value As String)
            vRg = value
        End Set
    End Property
    Public Property IE() As String
        Get
            Return vIE
        End Get
        Set(ByVal value As String)
            vIE = value
        End Set
    End Property
    Public Property IM() As String
        Get
            Return vIM
        End Get
        Set(ByVal value As String)
            vIM = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return vEmail
        End Get
        Set(ByVal value As String)
            vEmail = value
        End Set
    End Property
    Public Property TelResidencial() As String
        Get
            Return vTelResidencial
        End Get
        Set(ByVal value As String)
            vTelResidencial = Replace(value, "(", "") 'Retira o caracter "("
            vTelResidencial = Replace(vTelResidencial, ")", "") 'Retira o caracter ")"
            vTelResidencial = Replace(vTelResidencial, "-", "") 'Retira o caracter "-"
        End Set
    End Property
    Public Property TelComercial() As String

        Get
            Return vTelComercial
        End Get
        Set(ByVal value As String)
            vTelComercial = Replace(value, "(", "") 'Retira o caracter "("
            vTelComercial = Replace(vTelComercial, ")", "") 'Retira o caracter ")"
            vTelComercial = Replace(vTelComercial, "-", "") 'Retira o caracter "-"
        End Set
    End Property
    Public Property TelCelular() As String
        Get
            Return vTelCelular
        End Get
        Set(ByVal value As String)
            vTelCelular = Replace(value, "(", "") 'Retira o caracter "("
            vTelCelular = Replace(vTelCelular, ")", "") 'Retira o caracter ")"
            vTelCelular = Replace(vTelCelular, "-", "") 'Retira o caracter "-"

        End Set
    End Property
    Public Property TelObs() As String
        Get
            Return vTelObs
        End Get
        Set(ByVal value As String)
            vTelObs = value
        End Set
    End Property
    Public Property LimiteCredito() As String
        Get
            Return vLimiteCredito
        End Get
        Set(ByVal value As String)
            vLimiteCredito = Replace(value, ".", "") 'Retira o ponto
            vLimiteCredito = Replace(vLimiteCredito, ",", "") 'retira a virgula
            vLimiteCredito = vLimiteCredito.PadLeft(11, "0") 'Insere zero a esquerda

        End Set
    End Property
    Public Property CRM() As String
        Get
            Return vCRM
        End Get
        Set(ByVal value As String)
            vCRM = value
        End Set
    End Property
    Public Property Cidade() As String
        Get
            Return vcidade
        End Get
        Set(ByVal value As String)
            vcidade = value
        End Set
    End Property
    Public Property UF() As String
        Get
            Return vEstado
        End Get
        Set(ByVal value As String)
            vEstado = value
        End Set
    End Property
    Public Property TipoLogradouro() As String
        Get
            Return vTipoLogradouro
        End Get
        Set(ByVal value As String)
            vTipoLogradouro = value
        End Set
    End Property
    Public Property Logradouro() As String
        Get
            Return vLogradouro
        End Get
        Set(ByVal value As String)
            vLogradouro = value
        End Set
    End Property
    Public Property Numero() As String
        Get
            Return vNum
        End Get
        Set(ByVal value As String)
            vNum = value
        End Set
    End Property
    Public Property TipoBairro() As String
        Get
            Return vTipoBairro
        End Get
        Set(ByVal value As String)
            vTipoBairro = value
        End Set
    End Property
    Public Property Bairro() As String
        Get
            Return vBairro
        End Get
        Set(ByVal value As String)
            vBairro = value
        End Set
    End Property
    Public Property Complemento() As String
        Get
            Return vComplemento
        End Get
        Set(ByVal value As String)
            vComplemento = value
        End Set
    End Property
    Public Property Cep() As String
        Get
            Return vCep
        End Get
        Set(ByVal value As String)
            vCep = Replace(value, "-", "")
        End Set
    End Property
End Class

