Imports System.Collections
Public Class ItemData

    Private Descri��o As String
    Private Identificador As Integer
    Private IdenticadorString As String


    Public Sub New(ByVal NewDescri��o As String, ByVal NewId As Integer, ByVal NewIdString As String)
        Descri��o = NewDescri��o
        Identificador = NewId
        IdenticadorString = NewIdString
    End Sub


    Public ReadOnly Property GetDescri��o() As String
        Get
            Return Descri��o
        End Get
    End Property

    Public ReadOnly Property GetIdentificador() As Integer
        Get
            Return Identificador
        End Get
    End Property

    Public ReadOnly Property GetIdentificadorString() As String
        Get
            Return IdenticadorString
        End Get
    End Property

End Class

