Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class RelOrcamentoSellShoes 
    Dim I As Integer
   
    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        If (I Mod 2) = 0 Then
            Me.Detail1.BackColor = Color.Silver
        Else
            Me.Detail1.BackColor = Color.Transparent
        End If
        I += 1
    End Sub

    Private Sub RelOrcamentoSellShoes_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart

    End Sub

    Private Sub ReportFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportFooter1.Format
        Me.TextBox4.Text = Me.TextBox5.Text
    End Sub
End Class
