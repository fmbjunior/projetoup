Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class RelRepasseCheque 

    Private Sub ReportFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportFooter1.Format
        Me.CaixaDestinoASS.Text = Me.CaixaDestino.Text
        Me.CaixaOrigemASS.Text = Me.CaixaOrigem.Text
    End Sub
End Class
