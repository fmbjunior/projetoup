Imports System.Data.OleDb
Public Class NotaFiscalCancelamento

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelar.Click
        Dim HH As DateTime = Now
        Dim CodSeguran�a As String = InformaCodigoSeguranca()

        If VerificaCodigoSeguran�a(CodSeguran�a) = False Then
            MsgBox("C�digo de Seguran�a inv�lido, Verifique.", 64, "Valida��o de Dados")
            Me.Cursor = Cursors.Default
            Exit Sub
        Else

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = ""
            Dim Transa��o As OleDbTransaction = CNN.BeginTransaction
            Dim Cmd As OleDb.OleDbCommand = CNN.CreateCommand

            Cmd.Transaction = Transa��o

            Try
                Sql = "Update NotaFiscal set Situa�ao = 'C' Where NotaFiscal = " & Me.NotaFiscal.Text
                Cmd.CommandText = Sql
                Cmd.ExecuteNonQuery()


                Transa��o.Commit()
                MsgBox("A Nota Fiscal foi cancelada.", 64, "Valida��o de Dados")
                Me.NotaFiscal.Clear()
                Me.NotaFiscal.Focus()
                CNN.Close()

            Catch
                MsgBox("Erro ao Cancelar a Nota Fiscal, Verifique.", 64, "Valida��o de Dados")
                Transa��o.Rollback()
                Exit Sub
            End Try

        End If
    End Sub


    Private Sub NotaFiscalCancelamento_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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