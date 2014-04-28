Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class RelResumoServicoGrupo 
    Dim _tot As Double = 0
    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        If Me.txtSomaDeTotalservico1.Text = "" Then
        Else
            Me.TextBox1.Text = FormatNumber(Me.txtSomaDeTotalservico1.Text / _tot * 100, 2) & "%"

        End If
    End Sub

    Private Sub RelResumoServicoGrupo_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataInitialize
        _tot = OsRelat.vTotalResumo
    End Sub

    Private Sub RelResumoServicoGrupo_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart

    End Sub
End Class
