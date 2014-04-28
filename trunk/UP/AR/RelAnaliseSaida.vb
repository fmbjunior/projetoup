Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class RelAnaliseSaida
    Dim v As Double = 0
    Private Sub GroupHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format

    End Sub

    Private Sub GroupFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        Me.TextBox4.Text = FormatNumber(CDbl(Me.TextBox3.Text) / CDbl(Me.TextBox2.Text) * 100, 2)
        Me.TextBox5.Text = FormatCurrency(CDbl(Me.TextBox3.Text) / CDbl(Me.TextBox9.Text), 4)
        v = CDbl(Me.txtValorCompra1.Text) * CDbl(Me.TextBox9.Text)
        Me.TextBox6.Text = FormatCurrency(CDbl(Me.TextBox3.Text) - v, 2)
    End Sub
End Class
