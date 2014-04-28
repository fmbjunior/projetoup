Public Class UserSenhaAllItens


    Public DSPermissões As DataSet


    Private Sub UserSenhaAllItens_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Cnn.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)
        Cnn.Open()

        DSPermissões = New DataSet()
        Dim Sql As String = "SELECT * from LoginUserPermissao where Login = '" & My.Forms.UserSenha.Login.Text & "' order by DescricaoTela"
        Me.Cmd.CommandText = Sql

        Me.Da.SelectCommand = Me.Cmd
        Da.Fill(DSPermissões, "Telas")
        Me.DGPermissões.DataSource = DSPermissões
        Me.DGPermissões.DataMember = "Telas"
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAtualizar.Click
        Try
            Da.Update(DSPermissões, "Telas")
            MsgBox("Permissões atualizada com sucesso.", 64, "Validação de Dados")
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try

    End Sub

  
End Class