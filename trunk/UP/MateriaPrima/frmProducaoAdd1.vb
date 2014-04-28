Public Class frmProducaoAdd1
    Dim ORDEM As New clsProducao()
    Dim PED As New clsPedidoMP
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Dispose()
    End Sub
    Private Sub frmProducaoAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnSeguir_Click(sender As Object, e As EventArgs) Handles btnSeguir.Click
        'Verificar se já foi criado a ordem de produção  para o pedido e mostrar a tela com os dados do pedito
        If (String.IsNullOrEmpty(Me.txtNumeroPedido.Text)) Then
            MessageBox.Show("O Numero do Pedido não pode ser nulo", "VALIDAÇÃO DE DADOS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        PED.MostrarPedido(Me.txtNumeroPedido.Text, "P")
        If (PED.ErroRetorno) Then
            MessageBox.Show("Pedido não Existente nos Registros. Verifique se o código digitado está correto.", "VALIDAÇÃO DE DADOS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        If (ORDEM.TemOP(Me.txtNumeroPedido.Text)) Then
            MessageBox.Show("Já existe Ordem de Produção para este Pedido", "VALIDAÇÃO DE DADOS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim f As frmProducaoAdd2 = New frmProducaoAdd2(txtNumeroPedido.Text)
        f.ShowDialog()

    End Sub
    Private Sub frmProducaoAdd1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub
End Class