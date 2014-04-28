Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class RelComissaoFaixaSub
    Dim Vlr1 As Double
    Dim Vlr2 As Double

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format

        If Me.txtCarteira1.Text = "Vlr Carteira" Then
            Vlr1 = NzZero(Me.txtSomaDeValorDocumento1.Text)
        Else
            Vlr2 = NzZero(Me.txtSomaDeValorDocumento1.Text)
        End If

    End Sub

    
    Private Sub ReportFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportFooter1.Format
        Try
            Me.Indice.Text = FormatNumber((CDbl(Vlr2) / CDbl(Vlr1)) * 100, 2)
        Catch ex As Exception
            Me.Indice.Text = FormatNumber(0, 2)
        End Try


    End Sub
End Class
