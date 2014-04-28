Public Class CLPermissõesArray
    Private _Login As String = ""
    Public _Tela As String = ""
    Private _Senha As String = ""

    Private _Exclui As Boolean
    Private _Adiciona As Boolean
    Private _Altera As Boolean
    Private _Consultar As Boolean
    Private _UsarSenha As Boolean
    Private _Inativo As Boolean

    Public Sub New(ByVal Tela As String, ByVal Login As String, ByVal Senha As String, ByVal Exclui As Boolean, ByVal Adiciona As Boolean, ByVal Altera As Boolean, ByVal Consultar As Boolean, ByVal UsarSenha As Boolean, ByVal Inativo As Boolean)
        Me.Login = Login
        Me.Tela = Tela
        Me.Senha = Senha

        Me.Exclui = Exclui
        Me.Adiciona = Adiciona
        Me.Altera = Altera
        Me.Consultar = Consultar
        Me.UsarSenha = UsarSenha
        Me.Inativo = Inativo
    End Sub
    Public Property Tela() As String
        Get
            Return _Tela
        End Get
        Set(ByVal Valor As String)
            _Tela = Valor
        End Set
    End Property
    Public Property Login() As String
        Get
            Return _Login
        End Get
        Set(ByVal Valor As String)
            _Login = Valor
        End Set
    End Property
    Public Property Senha() As String
        Get
            Return _Senha
        End Get
        Set(ByVal Valor As String)
            _Senha = Valor
        End Set
    End Property

    Public Property Exclui() As Boolean
        Get
            Return _Exclui
        End Get
        Set(ByVal Valor As Boolean)
            _Exclui = Valor
        End Set
    End Property
    Public Property Adiciona() As Boolean
        Get
            Return _Adiciona
        End Get
        Set(ByVal Valor As Boolean)
            _Adiciona = Valor
        End Set
    End Property
    Public Property Altera() As Boolean
        Get
            Return _Altera
        End Get
        Set(ByVal Valor As Boolean)
            _Altera = Valor
        End Set
    End Property
    Public Property Consultar() As Boolean
        Get
            Return _Consultar
        End Get
        Set(ByVal Valor As Boolean)
            _Consultar = Valor
        End Set
    End Property
    Public Property UsarSenha() As Boolean
        Get
            Return _UsarSenha
        End Get
        Set(ByVal Valor As Boolean)
            _UsarSenha = Valor
        End Set
    End Property
    Public Property Inativo() As Boolean
        Get
            Return _Inativo
        End Get
        Set(ByVal Valor As Boolean)
            _Inativo = Valor
        End Set
    End Property

End Class
