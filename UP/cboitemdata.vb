Public Class cboItemData
    'Public Valor As Object = Nothing
    'Public Descri��o As String = Nothing

    'Public Sub New(ByVal Novo_Valor As Object, ByVal Nova_Descricao As String)
    '    Valor = Novo_Valor
    '    Descri��o = Nova_Descricao
    'End Sub

    'Public Overrides Function ToString() As String
    '    Return Descri��o
    'End Function


    Public Descri��o As String
    Public Valor As String   'You can also declare this as String.

    Public Sub New()
        Valor = 0
        Descri��o = ""
    End Sub

    Public Sub New(ByVal ID As String, ByVal Name As String)
        Valor = ID
        Descri��o = Name
    End Sub

    Public Property Name() As String
        Get
            Return Descri��o
        End Get

        Set(ByVal sValue As String)
            Descri��o = sValue
        End Set
    End Property

    Public Property ItemData() As String
        Get
            Return Valor
        End Get

        Set(ByVal iValue As String)
            Valor = iValue
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Descri��o
    End Function

    
End Class
