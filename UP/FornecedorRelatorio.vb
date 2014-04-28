Public Class FornecedorRelatorio

    Private Sub Visualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Visualizar.Click
        RelatorioCarregar = "Fornecedor"
        My.Forms.VisualizadorRelatorio.ShowDialog()
    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class