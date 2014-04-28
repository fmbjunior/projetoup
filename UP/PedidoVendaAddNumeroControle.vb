Public Class PedidoVendaAddNumeroControle

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click

        If Me.NumeroControle.Text = "" Then
            MessageBox.Show("O usuário deve informar o número do controle ou cancele a operação.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()
        Dim vPed As Integer

        If My.Forms.PedidoVenda.Visible = True Then
            vPed = NzZero(My.Forms.PedidoVenda.PedidoSequencia.Text)
        ElseIf My.Forms.PedidoOS.Visible = True Then
            vPed = My.Forms.PedidoOS.PedidoSequencia.Text
        End If
       
        Dim Sql As String = "Update Pedido  Set Requisicao = @1 Where Pedido.PedidoSequencia = " & vPed
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.NumeroControle.Text, 1)))

        Try
            cmd.ExecuteNonQuery()
            CNN.Close()
            If PedidoVenda.Visible = True Then
                My.Forms.PedidoVenda.NumeroControle.Text = Me.NumeroControle.Text
                ' My.Forms.PedidoVenda.btAddNumeroControle.Visible = False
            End If
            If PedidoOS.Visible = True Then
                My.Forms.PedidoOS.NumeroControle.Text = Me.NumeroControle.Text
                ' My.Forms.PedidoOS.btAddNumeroControle.Visible = False
            End If

            Me.Close()
            Me.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try


    End Sub
End Class