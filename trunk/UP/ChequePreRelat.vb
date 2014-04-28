Public Class ChequePreRelat

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

   
    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged, A4.CheckedChanged
        If Me.A1.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelEntreguePor.Visible = False
            Me.DataInicial.Focus()
        End If

        If Me.A2.Checked = True Then
            Me.PainelPeriodo.Visible = False
            Me.PainelEntreguePor.Visible = False
        End If

        If Me.A3.Checked = True Then
            Me.PainelPeriodo.Visible = False
            Me.PainelEntreguePor.Visible = True
            Me.EntreguePor.Focus()
        End If

        If Me.A4.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelEntreguePor.Visible = False
            Me.DataInicial.Focus()
        End If

    End Sub

    Private Sub btVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVisualizar.Click
        If Me.A1.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usuário deve informar a data inicial para o relatório.", 64, "Validação de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usuário deve informar a data Final para o relatório.", 64, "Validação de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelChequePrePeriodo"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A2.Checked = True Then
            RelatorioCarregar = "RelChequePreGeral"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A3.Checked = True Then
            If Me.EntreguePor.Text = "" Then
                MsgBox("O usuário deve informar por quem foi entregue o cheque para gerar o relatório.", 64, "Validação de Dados")
                Me.EntreguePor.Focus()
                Exit Sub
            End If
            RelatorioCarregar = "RelChequePreEntreguePor"
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
            RelatorioCarregar = "RelChequePreBaixadoPeriodo"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If


    End Sub
End Class