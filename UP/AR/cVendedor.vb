Public Class cVendedor

    Public codigovendedor As Integer
    Public nomevendedor As String
    Public fonevendedor As String

    Public Sub AchaVendedor(ByVal i As Integer)
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select CódigoFuncionário, Nome, Telefone FROM Funcionários WHERE CódigoFuncionário=" & i

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader
        Try
            DR = CMD.ExecuteReader
            DR.Read()

            codigovendedor = DR.Item("CódigoFuncionário")
            nomevendedor = DR.Item("nome").ToString
            fonevendedor = DR.Item("telefone").ToString
            DR.Close()
            CNN.Close()
        Catch ex As Exception
            CNN.Close()
        End Try


    End Sub

End Class
