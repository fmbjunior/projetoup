Public Class ClienteCPFCNPJ

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOK.Click
        If Me.TipoPessoa.Text = "" Then
            MessageBox.Show("Favor informar o tipo de Pessoa.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.TipoPessoa.Focus()
            Exit Sub
        End If
        If Me.CpfCgc.Text = "" Then
            MessageBox.Show("Favor informar o CPF/CNPJ do Cliente.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CpfCgc.Focus()
            Exit Sub
        End If

        My.Forms.Clientes.TipoPessoa.Text = Me.TipoPessoa.Text
        My.Forms.Clientes.CpfCgc.Text = Me.CpfCgc.Text
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub CpfCgc_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CpfCgc.Enter
        If Me.TipoPessoa.Text = "" Then
            Me.TipoPessoa.Focus()
            Exit Sub
        End If
        If Me.TipoPessoa.Text = "F" Then
            If NaoValidarDocumento = False Then Me.CpfCgc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Cpf
            If NaoValidarDocumento = True Then Me.CpfCgc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.CpfLivre
        Else
            If NaoValidarDocumento = False Then Me.CpfCgc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Cnpj
            If NaoValidarDocumento = True Then Me.CpfCgc.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.CnpjLivre
        End If
    End Sub
End Class