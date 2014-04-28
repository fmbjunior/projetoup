Public Class Conectar
    Public ReadOnly Property ConectarBD(ByVal Local As String) As String
        Get
            Dim Crypto As New ClCrypto
            'ConectarBd = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & Local & ";Persist Security Info=False"
            'ConectarBD = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Local & ";User ID=Admin;Password=abc"

            ConectarBD = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Local & ";Jet OLEDB:Database Password=" & Crypto.clsCrypto(SenhaBancoDados, False)


        End Get
    End Property
End Class
