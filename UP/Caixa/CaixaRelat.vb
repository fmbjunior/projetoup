Public Class CaixaRelat

    Private Sub btVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVisualizar.Click
        If Me.A1.Checked = True Then
            RelatorioCarregar = "RelFluxoCaixa"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A2.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usuário deve informar a data inicial para o relatório.", 64, "Validação de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usuário deve informar a data Final para o relatório.", 64, "Validação de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If
            RelatorioCarregar = "RelFluxoCaixaPeriodo"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A3.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usuário deve informar a data inicial para o relatório.", 64, "Validação de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usuário deve informar a data Final para o relatório.", 64, "Validação de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If
            RelatorioCarregar = "RelPagarReceberPeriodo"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A4.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usuário deve informar a data inicial para o relatório.", 64, "Validação de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usuário deve informar a data Final para o relatório.", 64, "Validação de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If
            RelatorioCarregar = "CaixaSintetico"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged, A4.CheckedChanged
        If Me.A1.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.DataInicial.Focus()
        End If

        If Me.A2.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.DataInicial.Focus()
        End If

        If Me.A3.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.DataInicial.Focus()
        End If

        If Me.A4.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.DataInicial.Focus()
        End If

    End Sub

End Class