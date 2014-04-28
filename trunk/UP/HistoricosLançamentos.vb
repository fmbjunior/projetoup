Public Class HistoricosLançamentos

    
    Private Sub Confirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Confirmar.Click
        If Me.Hist.Text = "" Then
            MsgBox("O Histórico não pode ser nulo.", 64, "Validação de Dados")
            Me.Hist.Focus()
            Exit Sub
        End If
        HistoricoDocumentos = Me.Hist.Text
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub HistoricosLançamentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hist.Text = HistoricoDocumentos
        Me.Display.Text = LegendaHistoricoDocumento
    End Sub
End Class