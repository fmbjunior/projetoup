Public Class UserSenhaAllItens


    Public DSPermiss�es As DataSet


    Private Sub UserSenhaAllItens_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Cnn.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)
        Cnn.Open()

        DSPermiss�es = New DataSet()
        Dim Sql As String = "SELECT * from LoginUserPermissao where Login = '" & My.Forms.UserSenha.Login.Text & "' order by DescricaoTela"
        Me.Cmd.CommandText = Sql

        Me.Da.SelectCommand = Me.Cmd
        Da.Fill(DSPermiss�es, "Telas")
        Me.DGPermiss�es.DataSource = DSPermiss�es
        Me.DGPermiss�es.DataMember = "Telas"
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAtualizar.Click
        Try
            Da.Update(DSPermiss�es, "Telas")
            MsgBox("Permiss�es atualizada com sucesso.", 64, "Valida��o de Dados")
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Valida��o de Dados")
        End Try

    End Sub

  
End Class