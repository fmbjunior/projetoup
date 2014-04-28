Public Class PedidoOSNumeroNF

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()
        Dim vPed As Integer

     
            vPed = My.Forms.PedidoOS.PedidoSequencia.Text

        Try
            Dim Sql As String = "Update Pedido  Set NfePecas = @1, NfeServico=@2 Where Pedido.PedidoSequencia = " & vPed
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Nfe.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Nfs.Text, 1)))
            cmd.ExecuteNonQuery()


            'Atualiza os Registros do Contas a Receber
            If My.Forms.PedidoOS.MyLista1.Items.Count > 0 Then
                cmd = New OleDb.OleDbCommand()
                cmd.CommandText = "UPDATE Receber SET Receber.NotaFiscal = @30, Receber.NotaFiscalServico =@32 WHERE Receber.PedidoProdutos=" & vPed
                cmd.Connection = CNN
                cmd.Parameters.Add(New OleDb.OleDbParameter("@30", Nz(Me.Nfe.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@32", Nz(Me.Nfs.Text, 1)))
                cmd.ExecuteNonQuery()
            End If

            CNN.Close()

            My.Forms.PedidoOS.txtNfePecas.Text = Me.Nfe.Text
            My.Forms.PedidoOS.txtNfeServico.Text = Me.Nfs.Text


            Me.Close()
            Me.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try



    End Sub
End Class