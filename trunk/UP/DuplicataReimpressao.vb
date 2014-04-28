Public Class DuplicataReimpressao

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btimprimir.Click
        ModeloDuplicata = "DUPLICATA"
        RelatorioCarregar = "ImpressDP"
        My.Forms.VisualizadorRelatorio.ShowDialog()
    End Sub
End Class