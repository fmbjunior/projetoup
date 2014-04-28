Public Class ReceberRelatPeriodoValor

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged, A4.CheckedChanged
        If A1.Checked = True Then
            Me.Label1.Visible = True
            Me.Vlr1.Visible = True
            Me.Label2.Visible = False
            Me.Vlr2.Visible = False
            Me.Vlr1.Focus()
        ElseIf A2.Checked = True Then
            Me.Label1.Visible = True
            Me.Vlr1.Visible = True
            Me.Label2.Visible = False
            Me.Vlr2.Visible = False
            Me.Vlr1.Focus()
        ElseIf A3.Checked = True Then
            Me.Label1.Visible = True
            Me.Vlr1.Visible = True
            Me.Label2.Visible = False
            Me.Vlr2.Visible = False
            Me.Vlr1.Focus()
        ElseIf A4.Checked = True Then
            Me.Label1.Visible = True
            Me.Vlr1.Visible = True
            Me.Label2.Visible = True
            Me.Vlr2.Visible = True
            Me.Vlr1.Focus()
        End If
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVisualizar.Click

        If Me.DataInicial.Text = "" Then
            MsgBox("O usuário deve informar a data inicial para o relatório.", 64, "Validação de Dados")
            Me.DataInicial.Focus()
            Exit Sub
        ElseIf Me.DataFinal.Text = "" Then
            MsgBox("O usuário deve informar a data Final para o relatório.", 64, "Validação de Dados")
            Me.DataFinal.Focus()
            Exit Sub
        End If

        If Me.A1.Checked = True Then
            RelatorioCarregar = "RelReceberPeriodoValor"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        ElseIf Me.A2.Checked = True Then
            RelatorioCarregar = "RelReceberPeriodoValor"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        ElseIf Me.A3.Checked = True Then
            RelatorioCarregar = "RelReceberPeriodoValor"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        ElseIf Me.A4.Checked = True Then
            RelatorioCarregar = "RelReceberPeriodoValor"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class