Public Class CLMenuArray

    Private _Item As String
    Private _Ativo As Boolean

    Public Sub New(ByVal Item As String, ByVal Ativo As Boolean)
        Me.Item = Item
        Me.Ativo = Ativo
    End Sub
    Public Property Item() As String
        Get
            Return _Item
        End Get
        Set(ByVal Valor As String)
            _Item = Valor
        End Set
    End Property

    Public Property Ativo() As String
        Get
            Return _Ativo
        End Get
        Set(ByVal Valor As String)
            _Ativo = Valor
        End Set
    End Property

End Class
