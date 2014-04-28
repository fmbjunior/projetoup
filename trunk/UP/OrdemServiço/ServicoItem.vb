Public Class ServicoItem
    Private mcodigoLancamento As Integer
    Private mcodigofuncionario As Integer
    Private mcodigoservico As Integer
    Private mcomissao As Double



    Public Property CodigoLancamento() As Integer
        Get
            Return mcodigoLancamento
        End Get
        Set(ByVal value As Integer)
            mcodigoLancamento = value
        End Set
    End Property

    Public Property Codigofuncionario() As Integer
        Get
            Return mcodigofuncionario
        End Get
        Set(ByVal value As Integer)
            mcodigofuncionario = value
        End Set
    End Property

    Public Property Codigoservico() As Integer
        Get
            Return mcodigoservico
        End Get
        Set(ByVal value As Integer)
            mcodigoservico = value
        End Set
    End Property

    Public Property Comissao() As Double
        Get
            Return mcomissao
        End Get
        Set(ByVal value As Double)
            mcomissao = value
        End Set
    End Property

End Class
