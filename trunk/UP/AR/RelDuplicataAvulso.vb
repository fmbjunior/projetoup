Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class RelDuplicataAvulso
    Dim extenso As New ActiveIT.cExtenso
    Dim lenQtd As Integer = 174
    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        Me.txtExtenso.Text = "#" & extenso.Executar(Me.txtValor.Text) & "#"

        Me.Label46.Text = "Reconheço(emos) a exatidão desta DUPLCATA DE VENDA MERCANTIL E/OU PRESTAÇAO DE SERVIÇOS, na importância acima que pagarei(emos) à " & TextBox12.Text & " ., Ou à sua ordem na praça e vencimento indicado."
        Me.Label47.Text = "Reconheço(emos) a exatidão desta DUPLCATA DE VENDA MERCANTIL E/OU PRESTAÇAO DE SERVIÇOS, na importância acima que pagarei(emos) à " & TextBox12.Text & " ., Ou à sua ordem na praça e vencimento indicado."
        lenQtd = Len(Me.ctxtValor.Text)

        Me.ctxtValor.Text = "#" & extenso.Executar(Me.txtValor.Text) & "#"


        'Me.ctxtValor.Text = Me.ctxtValor.Text.PadRight(lenQtd, "x.x ")
        'Me.txtExtenso.Text = Me.txtExtenso.Text.PadRight(lenQtd, "x")
    End Sub


    Private Sub NewActiveReport1_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
    End Sub
End Class
