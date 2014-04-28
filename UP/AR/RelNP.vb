Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class RelNP
    Dim dtserial As New npExteso
    Dim extenso As New ActiveIT.cExtenso
    Public cPed As Integer
    Public rdp As String

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        Me.dataserial.Text = dtserial.xExtenso(Me.txtVencimento2.Text)
        Me.lblValorExtenso.Text = extenso.Executar(Me.txtValorDocumento1.Text)
        Me.txtLocalData.Text = Me.txtCidadeEstado.Text + Me.txtDataDocumento1.Text

    End Sub

   
    Private Sub RelNP_DataInitialize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.DataInitialize
        Dim Conect As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Conect.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)

        Conect.SQL = "SELECT Empresa.RazãoSocial, Empresa.Cgc, Empresa.Cidade, Empresa.Estado, Receber.ID, Receber.PedidoProdutos, Receber.DataDocumento, Receber.Documento, Receber.ValorDocumento, Receber.Vencimento, Clientes.CpfCgc, Clientes.RG, Clientes.Nome, Clientes.Endereço, Clientes.Nro, Clientes.Cidade, Clientes.Estado, Clientes.CEP FROM (Receber INNER JOIN Empresa ON Receber.Empresa = Empresa.CódigoEmpresa) INNER JOIN Clientes ON Receber.CodCliente = Clientes.Codigo WHERE (((Receber.PedidoProdutos)=" & cPed & "));"

        Me.DataSource = Conect
    End Sub

    Private Sub RelNP_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart

    End Sub

    Private Sub PageFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageFooter1.Format
        Me.ReportInfo2.FormatString = rdp
    End Sub
End Class
