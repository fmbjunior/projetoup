Public Class DefinirAnoCompetencia
    Dim A��o As New TrfGerais
    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub Definir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Definir.Click

        If Len(Me.AnoComp.Text) < 4 Then
            MsgBox("Falta de algorismos, tente digitar novamente; ex: 2009", 48, "ATEN��O")
            Me.AnoComp.Clear()
        Else


            If existeTabela("L" & AnoComp.Text) = False Then
                MessageBox.Show("O ano informando n�o existe?", "Tabela n�o Existe", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)

                Me.AnoComp.Clear()
                Me.AnoComp.Focus()
                Me.Close()
                Me.Dispose()

                Exit Sub
            Else



                AnoContabel = "L" & Me.AnoComp.Text
                MessageBox.Show("Ano de compet�ncia definido com sucesso...", "Defini��o do Ano de Compet�ncia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                My.Forms.MenuGeral.lblCompetencia.Text = "Ano Cont�bil: " & Mid(AnoContabel, 2)

                If A��o.VerAnoCont(AnoContabel, CodEmpresa) = True Then
                    Liberado = False
                Else
                    Liberado = True

                End If

                Me.Close()
                Me.Dispose()

            End If
        End If
    End Sub

    Private Sub AnoComp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AnoComp.KeyDown
        If Not IsNumeric(Chr(e.KeyCode)) And e.KeyCode <> 8 Then
            e.SuppressKeyPress = True
        End If

    End Sub


    Private Sub DefinirAnoCompetencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AnoComp.Focus()
    End Sub


    Private Sub AnoComp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles AnoComp.Validating

        If (Me.AnoComp.Text.Trim().Length < 4) Then
            ErrorProv.SetError(AnoComp, "Informe o Ano com 4 digitos Ex: 2009")
        Else
            ErrorProv.SetError(AnoComp, "")


        End If

    End Sub


    Private Sub AnoComp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnoComp.TextChanged

    End Sub
End Class