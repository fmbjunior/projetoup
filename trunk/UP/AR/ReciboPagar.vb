Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class ReciboPagar 
    Dim extenso As New ActiveIT.cExtenso
    Public i As Integer
    Private Sub PageHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader1.Format
        Me.lblUser.Text = "Data de Trabalho: " & DataDia & " - Usuário: " & UserAtivo
    End Sub

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        Me.lblextenso.Text = "#" & extenso.Executar(Me.txtValorLiquido1.Text) & "#"
        Me.lbllocaldata.Text = "Dourados,MS, " & String.Format("{0:D}", Me.txtPagamento1.Text)
    End Sub

    Private Sub ReciboPagar_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataInitialize
        Dim Conect As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Conect.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)

        Conect.SQL = "SELECT Pagar.*, Empresa.RazãoSocial, Empresa.Cgc, Pagar.Id,Fornecedor.CgcCpf  FROM (Pagar INNER JOIN Empresa ON Pagar.Empresa = Empresa.CódigoEmpresa) INNER JOIN Fornecedor ON Pagar.CodFornecedor = Fornecedor.CódigoFornecedor WHERE Pagar.Id=" & i

        Me.DataSource = Conect
    End Sub

    Private Sub ReciboPagar_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart

    End Sub
End Class
