Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Public Class cImpressaoPedido

    Private mcodigopedido As Integer
    Public erro As Boolean = False
    Public rReimpressao As Boolean = False


    Public Property CodigoPedido() As Integer
        Get
            Return mcodigopedido
        End Get
        Set(ByVal value As Integer)
            mcodigopedido = value
        End Set
    End Property

    Public Sub Impressao(ByVal Visualizar As Boolean)

        Try
            Dim Rel As New RelPedidoSellShoes

            Rel.cPed = mcodigopedido
            If rReimpressao = False Then
                Rel.lblReimpresso.Visible = False
            Else
                Rel.lblReimpresso.Visible = True
            End If
            My.Forms.ViewReport.VerRelat.Document = Rel.Document
            My.Forms.ViewReport.VerRelat.Document.Name = "RelSellShoes"
            Rel.Run()


            If Visualizar = True Then
                My.Forms.ViewReport.ShowDialog()
            Else
                Rel.Document.Print(False, False)
            End If

            erro = False
        Catch ex As Exception
            erro = True
        End Try
    End Sub
    Public Sub ImpressaoLiquido(ByVal Visualizar As Boolean)

        Try
            Dim Rel As New RelPedidoLiquido
            Rel.cPed = mcodigopedido
            My.Forms.ViewReport.VerRelat.Document = Rel.Document
            My.Forms.ViewReport.VerRelat.Document.Name = "RelSellShoes"
            Rel.Run()


            If Visualizar = True Then
                My.Forms.ViewReport.ShowDialog()
            Else
                Rel.Document.Print(False, False)
            End If

            erro = False
        Catch ex As Exception
            erro = True
        End Try
    End Sub

End Class
