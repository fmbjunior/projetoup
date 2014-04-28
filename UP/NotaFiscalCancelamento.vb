Imports System.Data.OleDb
Public Class NotaFiscalCancelamento

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelar.Click
        Dim HH As DateTime = Now
        Dim CodSegurança As String = InformaCodigoSeguranca()

        If VerificaCodigoSegurança(CodSegurança) = False Then
            MsgBox("Código de Segurança inválido, Verifique.", 64, "Validação de Dados")
            Me.Cursor = Cursors.Default
            Exit Sub
        Else

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = ""
            Dim Transação As OleDbTransaction = CNN.BeginTransaction
            Dim Cmd As OleDb.OleDbCommand = CNN.CreateCommand

            Cmd.Transaction = Transação

            Try
                Sql = "Update NotaFiscal set Situaçao = 'C' Where NotaFiscal = " & Me.NotaFiscal.Text
                Cmd.CommandText = Sql
                Cmd.ExecuteNonQuery()


                Transação.Commit()
                MsgBox("A Nota Fiscal foi cancelada.", 64, "Validação de Dados")
                Me.NotaFiscal.Clear()
                Me.NotaFiscal.Focus()
                CNN.Close()

            Catch
                MsgBox("Erro ao Cancelar a Nota Fiscal, Verifique.", 64, "Validação de Dados")
                Transação.Rollback()
                Exit Sub
            End Try

        End If
    End Sub


    Private Sub NotaFiscalCancelamento_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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