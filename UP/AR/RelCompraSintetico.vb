Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class RelCompraSintetico 
    Dim I As Integer
    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        If (I Mod 2) = 0 Then
            Me.Detail1.BackColor = Color.Silver
        Else
            Me.Detail1.BackColor = Color.Transparent
        End If
        I += 1
    End Sub

    Private Sub RelCompraSintetico_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataInitialize
        Dim Conect As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Conect.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)

        Conect.SQL = "SELECT Compra.CompraInterno, Compra.NotaFiscal, Compra.DataLan�amento, Compra.DataCompra, Compra.ValorCompra, Compra.Confirmado, Compra.CFOP, Compra.Tipo, Compra.Inativo, Format([c�digoFornecedor],'00000') & '-' & [Fornecedor.Raz�oSocial] AS CodNomeFornecedor, Empresa.NomeFantasia FROM Empresa INNER JOIN (Compra INNER JOIN Fornecedor ON Compra.CodigoFornecedor = Fornecedor.C�digoFornecedor) ON Empresa.C�digoEmpresa = Compra.Empresa WHERE (((Compra.DataLan�amento) Between #" & Format(CDate(My.Forms.ComprasRelat.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(My.Forms.ComprasRelat.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Compra.Tipo)='NF') AND ((Compra.Inativo)=False)) ORDER BY Compra.CompraInterno, Compra.DataLan�amento;"

        Me.DataSource = Conect
    End Sub

    Private Sub RelCompraSintetico_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart

    End Sub
End Class
