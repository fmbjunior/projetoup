Public Class ReceberBaixaVerTroco

    Private Sub ReceberBaixaVerTroco_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Forms.ReceberBaixa.Visible = True Then
            Me.ValorLiquido.Text = FormatNumber(My.Forms.ReceberBaixa.ValorLiquido.Text, 2)
        End If

        If My.Forms.ReceberBaixaLote.Visible = True Then
            Me.ValorLiquido.Text = FormatNumber(My.Forms.ReceberBaixaLote.tLiquido.Text, 2)
        End If

    End Sub
    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Recebido_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Recebido.Enter
        Me.Recebido.Text = FormatNumber(Me.ValorLiquido.Text, 2)
    End Sub

    Private Sub Recebido_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Recebido.Leave
        Me.Recebido.Text = FormatNumber(Me.Recebido.Text, 2)
    End Sub

    Private Sub Troco_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Troco.Enter
        Me.Troco.Text = FormatNumber(CDbl(Me.Recebido.Text) - CDbl(Me.ValorLiquido.Text), 2)
    End Sub

End Class