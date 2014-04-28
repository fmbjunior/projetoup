Public Class PermissaoPost

    Public Tela As String = String.Empty
    Public IdRegistro As String = String.Empty

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Function GetRandomPassword(ByVal length As Integer) As String
        Static rand As New Random
        Dim password As New System.Text.StringBuilder(length)

        For i As Integer = 1 To length
            Dim charIndex As Integer
            ' allow only digits and letters 
            Do
                charIndex = rand.Next(48, 123)
            Loop Until (charIndex >= 48 AndAlso charIndex <= 57) OrElse (charIndex _
            >= 65 AndAlso charIndex <= 90) OrElse (charIndex >= 97 AndAlso _
            charIndex <= 122)
            ' add the random char to the password being built 
            password.Append(Convert.ToChar(charIndex))
        Next
        Return password.ToString()
    End Function

    Private Sub GetPermissao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.tUsuario.Text = "Usuario: " & UserAtivo
        Me.tTela.Text = "Tela: " & Tela
        Me.tIDRegistro.Text = "Id do Registro: " & IdRegistro
        Me.tDataHora.Text = "Data e Hora da Solicitação: " & Date.Now
    End Sub

    Private Sub Motivo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Motivo.TextChanged
        Me.tRestante.Text = "Texto Restante: " & CDbl(Me.Motivo.MaxLength) - CDbl(Len(Me.Motivo.Text))
    End Sub

    Private Sub btEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnviar.Click

        If Me.Motivo.Text = "" Then
            MsgBox("O Código do Grupo não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Motivo.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        CNN.Open()

        Dim Sql As String = "INSERT INTO getAutorizacao (Tela, Usuario, IdRegistro, Motivo, DataHora, Status, StatusModificadoPor, Utilizada) VALUES (@1, @2, @3, @4, @5, @6, @7, @8)"
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Tela))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", UserAtivo))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@3", IdRegistro))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Motivo.Text, 1)))
        Dim dt As String = Date.Now
        cmd.Parameters.Add(New OleDb.OleDbParameter("@5", dt))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@6", "Solicitação")) 'Solicitação/Autorizado/Revogado
        cmd.Parameters.Add(New OleDb.OleDbParameter("@7", System.DBNull.Value))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@8", False))

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Solicitação enviada com sucesso", 64, "Validação de Dados")
            ErroLivre = "Solicitação enviada para mudança de informações: " & Me.Motivo.Text
            GerarLog(Me.Text, AçãoTP.Livre, IdRegistro)

        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try
        CNN.Close()
        Me.Close()
        Me.Dispose()

    End Sub

    
    
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class