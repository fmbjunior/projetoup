Public Class OrdemCompraRelat

    Private Sub Visualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Visualizar.Click
        If A1.Checked = True Or A2.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MessageBox.Show("O usuário deve informar a data inicial", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If Me.DataFinal.Text = "" Then
                MessageBox.Show("O usuário deve informar a data Final", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            RelatorioCarregar = "OrdemCompraPeriodo"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If A3.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MessageBox.Show("O usuário deve informar a data inicial", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If Me.DataFinal.Text = "" Then
                MessageBox.Show("O usuário deve informar a data Final", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If Me.i1.Checked = False And Me.i2.Checked = False And Me.i3.Checked = False Then
                MessageBox.Show("O usuário deve selecionar uma opção de itens", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If


            RelatorioCarregar = "RelApontamentoEstoque"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged
        If A1.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelApontamento.Visible = False
            Me.DataInicial.Focus()
        End If

        If A2.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelApontamento.Visible = False
            Me.DataInicial.Focus()
        End If

        If A3.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelApontamento.Visible = True
            Me.DataInicial.Focus()
        End If

    End Sub

    
End Class