Public Class PedidoProcuraProdutoFind

    'Private Sub btProcura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btProcura.Click
    '    If Me.TxtProcura.Text = "" Then Exit Sub
    '    My.Forms.ctrAnimalProcura.BuscarAnimal()
    'End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    'Private Sub CtrAnimalProcuraFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    If My.Forms.ctrAnimalProcura.ColunaProcurar = 4 Then
    '        Me.TxtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
    '    End If
    'End Sub

    Private Sub TxtProcura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtProcura.KeyDown
        If e.KeyCode = Keys.Enter Then
            btFechar_Click(sender, e)
        End If
    End Sub


    Private Sub TxtProcura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtProcura.TextChanged
        My.Forms.PedidoProcuraProduto.AcharPorColuna(My.Forms.PedidoProcuraProduto.ColunaProcurar, Me.TxtProcura.Text)
    End Sub
End Class