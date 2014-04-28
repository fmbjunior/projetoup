Public Class CadTelaPermissaoAddEdd

    Public Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub CadTelaPermissaoAddEdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Operation = INS Then
            EncheListaUsuario()
        End If
    End Sub


    Public Sub AcharLogin(ByVal cTela As String, ByVal cLogin As String)

        If cTela = "" Then Exit Sub
        If cLogin = "" Then Exit Sub

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from LoginUserPermissao where Login = '" & cLogin & "' and Tela = '" & cTela & "'"
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.Tela.Text = DR.Item("Tela") & ""
            Me.DescricaoTela.Text = DR.Item("DescricaoTela") & ""
            Me.Login.SelectedValue = DR.Item("Login")

            Me.Exclui.Checked = DR.Item("Exclui") & ""
            Me.Adiciona.Checked = DR.Item("Adiciona") & ""
            Me.Altera.Checked = DR.Item("Altera") & ""
            Me.Consultar.Checked = DR.Item("Consultar") & ""
            Me.Inativo.Checked = DR.Item("Inativo") & ""

            Me.Login.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Sim
            Operation = UPD
        End If
    End Sub

    Public Sub EncheListaUsuario()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT LoginUser.Login FROM(LoginUser) WHERE(((LoginUser.Inativo) = False)) ORDER BY LoginUser.Login;"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Login.DataSource = ds.Tables("Table").DefaultView
        Me.Login.DisplayMember = "Login"
        Me.Login.ValueMember = "Login"
        Me.Login.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

    End Sub

  
    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        'Area destinada para as validacoes
        If Me.Tela.Text = "" Then
            MsgBox("O Nome da tela não foi carregado, feche e inicie Novamento.", 64, "Validação de Dados")
            Exit Sub
        ElseIf Me.DescricaoTela.Text = "" Then
            MsgBox("A  descrição da Tela não foi carregada feche e inicie novamente.", 64, "Validação de Dados")
            Exit Sub
        ElseIf Me.Login.Text = "" Then
            MsgBox("Não foi informado o login, Verifique...", 64, "Validação de Dados")
            Me.Login.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        If Operation = INS Then

            Dim Sql As String = "INSERT INTO LoginUserPermissao ( Login, Tela, DescricaoTela, Exclui, Adiciona, Altera, Consultar, Inativo) VALUES (@1, @2, @3, @4, @5, @6, @7, @8)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Login.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Tela.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DescricaoTela.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Me.Exclui.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Me.Adiciona.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.Altera.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Me.Consultar.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Me.Inativo.Checked))

            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")

                My.Forms.CadTelaPermissao.AlteracoesCadastro()
                Me.Close()
                Me.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try


        ElseIf Operation = UPD Then

            Dim Sql As String = "Update LoginUserPermissao set Login = @1, Tela = @2, DescricaoTela = @3, Exclui = @4, Adiciona = @5, Altera = @6, Consultar = @7, Inativo = @8 Where Login = '" & Me.Login.Text & "' and Tela = '" & Me.Tela.Text & "'"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Login.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Tela.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DescricaoTela.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Me.Exclui.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Me.Adiciona.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.Altera.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Me.Consultar.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Me.Inativo.Checked))

            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                My.Forms.CadTelaPermissao.AlteracoesCadastro()
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub btExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExcluir.Click

        If Me.Tela.Text = "" Then Exit Sub
        If Me.Login.Text = "" Then Exit Sub

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim Sql As String = "Delete * from LoginUserPermissao Where Login = '" & Me.Login.Text & "' and Tela = '" & Me.Tela.Text & "'"
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        Try
            cmd.ExecuteNonQuery()
            CNN.Close()
            MsgBox("Registro excluido com sucesso", 64, "Validação de Dados")

            My.Forms.CadTelaPermissao.AlteracoesCadastro()
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try


    End Sub
End Class