Public Class CodigoSegurancaInformar

    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click
        If Me.Codigo.Text = "" Then Me.Codigo.Text = 0
        RetornoCodSegurança = Me.Codigo.Text
        Me.Close()
        Me.Dispose()
    End Sub

   
    Private Sub CodigoSegurancaInformar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Insert Then
            TRVDados(UserAtivo, "CodigoSegurança")
            If Ina = True Then
                MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
                Exit Sub
            Else
                My.Forms.CodigoSegurança.ShowDialog()
            End If
        End If
    End Sub
End Class