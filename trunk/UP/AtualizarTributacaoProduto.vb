Public Class AtualizarTributacaoProduto

    Private Sub btFechar_Click(sender As Object, e As EventArgs) Handles btFechar.Click
        Me.Close()

    End Sub

    Private Sub btAtualizar_Click(sender As Object, e As EventArgs) Handles btAtualizar.Click

        If Len(txtncm.Text) < 8 Then
            MessageBox.Show("O NCM está incorreto. Verifique", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtCofins.Text) Or String.IsNullOrEmpty(txtpis.Text) Then
            MessageBox.Show("O PIS ou COFINS está incorreto. Verifique", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If Len(txtCofins.Text) < 2 Or Len(txtCofins.Text) > 3 Or Len(txtpis.Text) < 2 Or Len(txtpis.Text) > 3 Then
            MessageBox.Show("O PIS ou COFINS está incorreto. Verifique", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()
        Try
            Dim cmd As New OleDb.OleDbCommand()
            cmd.CommandText = "UPDATE PRODUTOS SET CSTPIS=@1,CSTCOFINS=@2 WHERE CF='" & txtncm.Text & "'"
            cmd.Connection = Cnn
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@1", txtpis.Text)
            cmd.Parameters.AddWithValue("@2", txtCofins.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Registros Atualizados. Verifique no cadastro de produtos os valores alterados", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.txtncm.Clear()
            Me.txtCofins.Clear()
            Me.txtpis.Clear()

            txtncm.Focus()

        Catch ex As Exception

        End Try
      

    End Sub

    Private Sub txtncm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtncm.KeyPress
        'so aceita numeros ***beto
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(OnlyNumber(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtpis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpis.KeyPress
        'so aceita numeros ***beto
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(OnlyNumber(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCofins_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCofins.KeyPress
        'so aceita numeros ***beto
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(OnlyNumber(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
End Class