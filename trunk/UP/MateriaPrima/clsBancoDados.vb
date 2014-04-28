Imports System.Data.OleDb
Public Class clsBancoDados
    Public Function AbreBanco() As OleDbConnection
        Dim conn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        conn.Open()
        Return conn
    End Function

    Public Sub fechabanco(ByVal conn As OleDbConnection)
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
End Class
