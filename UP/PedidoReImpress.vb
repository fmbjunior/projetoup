Public Class PedidoReImpress

    Private Sub btVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVisualizar.Click
        If Me.Pedido.Text = "" Then
            MsgBox("O usu�rio deve informar o n� do pedido para ser reimpresso.", 64, "Valida��o de Dados")
            Me.Pedido.Focus()
            Exit Sub
        End If
        If Me.Espelho.Checked = False Then
            RelatorioCarregar = "RelPedidoReImpress"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        Else
            RelatorioCarregar = "RelPedidoReImpressEspelho"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class