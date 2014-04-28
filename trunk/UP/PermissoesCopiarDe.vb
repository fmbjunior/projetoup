Public Class PermissoesCopiarDe

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub PermissoesCopiarDe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EncheListaUser()
    End Sub


    Private Sub EncheListaUser()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT * FROM LoginUser order by NomeUser"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.UsuarioCopiar.DataSource = ds.Tables("Table").DefaultView
        Me.UsuarioCopiar.DisplayMember = "NomeUser"
        Me.UsuarioCopiar.ValueMember = "Login"
        Me.UsuarioCopiar.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

    End Sub


    Private Sub EncheListaUserNovo()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT * FROM LoginUser Where Login <> '" & Me.UsuarioCopiar.SelectedValue & "' order by NomeUser"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.UsuarioNovo.DataSource = ds.Tables("Table").DefaultView
        Me.UsuarioNovo.DisplayMember = "NomeUser"
        Me.UsuarioNovo.ValueMember = "Login"
        Me.UsuarioNovo.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

    End Sub




    Private Sub btCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCopiar.Click
        If Me.UsuarioCopiar.Text = "" Then
            MessageBox.Show("Favor selecionar um usuário para que a copia seja feita", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "INSERT INTO LoginUserPermissao ( Id, Login, Tela, Senha, DescricaoTela, Exclui, Adiciona, Altera, Consultar, UsarSenha, Inativo ) SELECT LoginUserPermissao.Id, '" & Me.UsuarioNovo.SelectedValue & "' AS LoginNovo, LoginUserPermissao.Tela, LoginUserPermissao.Senha, LoginUserPermissao.DescricaoTela, LoginUserPermissao.Exclui, LoginUserPermissao.Adiciona, LoginUserPermissao.Altera, LoginUserPermissao.Consultar, LoginUserPermissao.UsarSenha, LoginUserPermissao.Inativo FROM(LoginUserPermissao) WHERE (((LoginUserPermissao.login)='" & Me.UsuarioCopiar.SelectedValue & "'));"
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        Try
            cmd.ExecuteNonQuery()
            CNN.Close()
            MessageBox.Show("Permissões copiadas com sucesso", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            CNN.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub UsuarioCopiar_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuarioCopiar.Validated
        EncheListaUserNovo()
    End Sub

End Class