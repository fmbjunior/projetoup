Public Class SellShoesDevolucaoQtd

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConfirmar.Click
        My.Forms.SellShoesDevolucao.Q_Devolver = NzZero(Me.Qtd.Text)
        Me.Close()
        Me.Dispose()
    End Sub
End Class