Imports System.Collections
Public Class ItemData

    Private Descrição As String
    Private Identificador As Integer
    Private IdenticadorString As String


    Public Sub New(ByVal NewDescrição As String, ByVal NewId As Integer, ByVal NewIdString As String)
        Descrição = NewDescrição
        Identificador = NewId
        IdenticadorString = NewIdString
    End Sub


    Public ReadOnly Property GetDescrição() As String
        Get
            Return Descrição
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

