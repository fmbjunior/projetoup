Public Class AlterarSenha

    Dim SEAntiga As String = ""

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub AlterarSenha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        Me.Login.Text = My.Forms.Login.Usuario.Text
        AchaSenhaAntiga()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salvar.Click
        If Me.Login.Text = "" Then
            MsgBox("O login não pode ser nulo", 64, "Validação de Dados")
            Me.Login.Focus()
            Exit Sub
        ElseIf Me.SenhaAntiga.Text = "" Then
            MsgBox("O usuário deve informar a senha antiga para trocar de senha", 64, "Validação de Dados")
            Me.SenhaAntiga.Focus()
            Exit Sub
        ElseIf Me.SenhaNova.Text = "" Then
            MsgBox("O usuário deve informar a nova senha", 64, "Validação de Dados")
            Me.SenhaNova.Focus()
            Exit Sub
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))


        CNN.Open()

        Dim Sql As String = "Update LoginUser set Login = @1, Senha = @2 Where Login = '" & Me.Login.Text & "'"
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Login.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.SenhaNova.Text, 1)))

        Try
            If SEAntiga = Me.SenhaAntiga.Text Then
                cmd.ExecuteNonQuery()
                MsgBox("Senha alterada com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Confirmou, Me.Login.Text)
                CNN.Close()
                Me.Close()
                Me.Dispose()
            Else
                MsgBox("Senha antiga informada não confere, verifique.", 64, "Validação de Dados")
                Me.SenhaAntiga.Focus()
                Me.SenhaAntiga.SelectAll()
                Exit Sub
            End If

        Catch x As Exception
            MsgBox(x.Message)
            Exit Sub
        End Try

    End Sub

    Public Sub AchaSenhaAntiga()
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim CMD As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        With CMD
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * From LoginUser Where Login = '" & Me.Login.Text & "'"
            .CommandType = CommandType.Text
        End With

        DataReader = CMD.ExecuteReader
        DataReader.Read()
        If DataReader.HasRows Then
            SEAntiga = DataReader.Item("Senha") & ""
        Else
            MsgBox("Usuário não encontrado, verifique.", 64, "Validação de Dados")
            Exit Sub
        End If

        Cnn.Close()
    End Sub

End Class