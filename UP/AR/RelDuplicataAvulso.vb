Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class RelDuplicataAvulso
    Dim extenso As New ActiveIT.cExtenso
    Dim lenQtd As Integer = 174
    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        Me.txtExtenso.Text = "#" & extenso.Executar(Me.txtValor.Text) & "#"

        Me.Label46.Text = "Reconhe�o(emos) a exatid�o desta DUPLCATA DE VENDA MERCANTIL E/OU PRESTA�AO DE SERVI�OS, na import�ncia acima que pagarei(emos) � " & TextBox12.Text & " ., Ou � sua ordem na pra�a e vencimento indicado."
        Me.Label47.Text = "Reconhe�o(emos) a exatid�o desta DUPLCATA DE VENDA MERCANTIL E/OU PRESTA�AO DE SERVI�OS, na import�ncia acima que pagarei(emos) � " & TextBox12.Text & " ., Ou � sua ordem na pra�a e vencimento indicado."
        lenQtd = Len(Me.ctxtValor.Text)

        Me.ctxtValor.Text = "#" & extenso.Executar(Me.txtValor.Text) & "#"


        'Me.ctxtValor.Text = Me.ctxtValor.Text.PadRight(lenQtd, "x.x ")
        'Me.txtExtenso.Text = Me.txtExtenso.Text.PadRight(lenQtd, "x")
    End Sub


    Private Sub NewActiveReport1_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
    End Sub
End Class
