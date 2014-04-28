Public Class SellShoesEnderecoEntrega

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConfirmar.Click

        If My.Forms.SellShoes.Visible = True Then

            My.Forms.SellShoes.EnderecoEntrega.Text = Me.EnderecoEntrega.Text
        Else

            My.Forms.SellShoesOrcamento.EnderecoEntrega.Text = Me.EnderecoEntrega.Text
        End If

        Me.Close()
        Me.Dispose()

    End Sub

   
    Private Sub SellShoesEnderecoEntrega_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If My.Forms.SellShoes.Visible = True Then
            Me.Label20.Text = "Informe o endereço de Entrega"
            Me.EnderecoEntrega.Text = My.Forms.SellShoes.EnderecoEntrega.Text
        Else
            Me.Label20.Text = "Observações"
            Me.EnderecoEntrega.Text = My.Forms.SellShoesOrcamento.EnderecoEntrega.Text
        End If

    End Sub
End Class