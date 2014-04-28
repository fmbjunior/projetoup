Public Class FeriasImpressao

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        RelatorioCarregar = "FeriasImpressao"
        My.Forms.VisualizadorRelatorio.Show()
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class