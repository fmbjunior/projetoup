Public Class CodigoSegurancaInformar

    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click
        If Me.Codigo.Text = "" Then Me.Codigo.Text = 0
        RetornoCodSeguran�a = Me.Codigo.Text
        Me.Close()
        Me.Dispose()
    End Sub

   
    Private Sub CodigoSegurancaInformar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Insert Then
            TRVDados(UserAtivo, "CodigoSeguran�a")
            If Ina = True Then
                MsgBox("O usu�rio n�o esta autorizado a usar esta op��o do sistema.", 64, "Valida��o de Dados")
                Exit Sub
            Else
                My.Forms.CodigoSeguran�a.ShowDialog()
            End If
        End If
    End Sub
End Class