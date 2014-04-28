Public Class ServicoComissao

    Private Sub ValorServico_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValorServico.Validated
        If Me.ValorServico.Text <> "" Then
            My.Forms.ServicoFuncionario.sv.Comissao = Me.ValorServico.Text
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class