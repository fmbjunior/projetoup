Public Class NFRelat

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged
        If Me.A1.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelCliente.Visible = False
            Me.PainelPedido.Visible = False
            Me.DataInicial.Focus()
        End If

        If Me.A2.Checked = True Then
            Me.PainelPeriodo.Visible = False
            Me.PainelCliente.Visible = True
            Me.PainelPedido.Visible = False
            Me.Cliente.Focus()
        End If

        If Me.A3.Checked = True Then
            Me.PainelPeriodo.Visible = False
            Me.PainelCliente.Visible = False
            Me.PainelPedido.Visible = True
            Me.Pedido.Focus()
        End If

    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Visualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Visualizar.Click

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

            RelatorioCarregar = "RelNfCFOP"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A2.Checked = True Then
            If Me.Cliente.Text = "" Then
                MsgBox("O usuário deve informar o cliente para gerar o relatório.", 64, "Validação de Dados")
                Exit Sub
            End If
            RelatorioCarregar = "RelNfsPorCliente"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A3.Checked = True Then
            If Me.Pedido.Text = "" Then
                MsgBox("O usuário deve informar o numero do pedido para gerar o relatório.", 48, "Validação de Dados")
                Exit Sub
            End If
            RelatorioCarregar = "RelNfsPorPedido"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

    End Sub

    Private Sub Cliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cliente.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ClientesProcura.ShowDialog()
            Me.Cliente.Text = RetornoProcura
            If Me.Cliente.Text <> "" Then
                Dim Ação As New TrfGerais
                Ação.Descrição_ItenRegistro(Me.Cliente, Me.ClienteDesc, "Clientes", "Codigo", Me.Cliente.Text, "Nome", TrfGerais.TipoDados.Numérico, True)
            End If
        End If
    End Sub

End Class