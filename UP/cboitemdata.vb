Public Class cboItemData
    'Public Valor As Object = Nothing
    'Public Descrição As String = Nothing

    'Public Sub New(ByVal Novo_Valor As Object, ByVal Nova_Descricao As String)
    '    Valor = Novo_Valor
    '    Descrição = Nova_Descricao
    'End Sub

    'Public Overrides Function ToString() As String
    '    Return Descrição
    'End Function


    Public Descrição As String
    Public Valor As String   'You can also declare this as String.

    Public Sub New()
        Valor = 0
        Descrição = ""
    End Sub

    Public Sub New(ByVal ID As String, ByVal Name As String)
        Valor = ID
        Descrição = Name
    End Sub

    Public Property Name() As String
        Get
            Return Descrição
        End Get

        Set(ByVal sValue As String)
            Descrição = sValue
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
        Return Descrição
    End Function

    
End Class
