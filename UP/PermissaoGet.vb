Public Class PermissaoGet

    Public Tela As String = String.Empty
    Public IdRegistro As String = String.Empty

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub PermissaoGet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.tUsuario.Text = "Usuario: " & UserAtivo
        Me.tTela.Text = "Tela: " & Tela
        Me.tIDRegistro.Text = "Id do Registro: " & IdRegistro


        Me.tLiberaçao.Text = "Aguardando Liberação"

        If Me.tLiberaçao.Text = "Aguardando Liberação" Then
            Me.btOK.Enabled = False
        Else
            Me.btOK.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

       Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from getAutorizacao where Usuario = '" & UserAtivo & "' and IdRegistro = '" & IdRegistro & "' And Tela = '" & Tela & "' And Utilizada = False"
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            If DR.Item("Status") = "Autorizado" Then
                Me.tLiberaçao.Text = "Solicitação Autorizado"
                Me.Text = "Solicitação Autorizado"
                Me.btOK.DialogResult = Windows.Forms.DialogResult.Yes
                Me.btOK.Enabled = True
                Me.Timer2.Enabled = True
            End If

            If DR.Item("Status") = "Revogado" Then
                Me.tLiberaçao.Text = "Solicitação Revogada"
                Me.Text = "Solicitação Revogada"
                Me.btOK.DialogResult = Windows.Forms.DialogResult.No
                Me.btOK.Enabled = False
                Me.Timer2.Enabled = True

                Sql = "update getAutorizacao set Utilizada = @1 where Usuario = '" & UserAtivo & "' and IdRegistro = '" & IdRegistro & "' And Tela = '" & Tela & "' and Utilizada = false"
                Dim cmdRevogada As New OleDb.OleDbCommand(Sql, CNN)

                cmdRevogada.Parameters.Add(New OleDb.OleDbParameter("@1", True))

                Try
                    cmdRevogada.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, 64, "Validação de Dados")
                End Try

            End If
        Else
            Me.btOK.Enabled = False

        End If
        DR.Close()
        CNN.Close()

        If Me.Timer1.Interval = 10 Then
            Me.Timer1.Interval = 40000
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Me.tLiberaçao.ForeColor = Color.Black Then
            Me.tLiberaçao.ForeColor = Color.Red
        Else
            Me.tLiberaçao.ForeColor = Color.Black
        End If
    End Sub

    
    Private Sub btOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOK.Click

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        CNN.Open()

        Dim Sql As String = "update getAutorizacao set Utilizada = @1 where Usuario = '" & UserAtivo & "' and IdRegistro = '" & IdRegistro & "' And Tela = '" & Tela & "' and Utilizada = false"
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", True))
        
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try
        CNN.Close()
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub btVerificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVerificar.Click
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from getAutorizacao where Usuario = '" & UserAtivo & "' and IdRegistro = '" & IdRegistro & "' And Tela = '" & Tela & "' And Utilizada = False"
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            If DR.Item("Status") = "Autorizado" Then
                Me.tLiberaçao.Text = "Solicitação Autorizado"
                Me.Text = "Solicitação Autorizado"
                Me.btOK.DialogResult = Windows.Forms.DialogResult.Yes
                Me.btOK.Enabled = True
                Me.Timer2.Enabled = True
                varAutorizado = True
            End If

            If DR.Item("Status") = "Revogado" Then
                Me.tLiberaçao.Text = "Solicitação Revogada"
                Me.Text = "Solicitação Revogada"
                Me.btOK.DialogResult = Windows.Forms.DialogResult.No
                Me.btOK.Enabled = False
                Me.Timer2.Enabled = True
                varAutorizado = False

                Sql = "update getAutorizacao set Utilizada = @1 where Usuario = '" & UserAtivo & "' and IdRegistro = '" & IdRegistro & "' And Tela = '" & Tela & "' and Utilizada = false"
                Dim cmdRevogada As New OleDb.OleDbCommand(Sql, CNN)

                cmdRevogada.Parameters.Add(New OleDb.OleDbParameter("@1", True))

                Try
                    cmdRevogada.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, 64, "Validação de Dados")
                End Try

            End If
        Else
            Me.btOK.Enabled = False

        End If
        DR.Close()
        CNN.Close()
    End Sub

    Private Sub btGetPostPermissao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGetPostPermissao.Click
        TRVDados(UserAtivo, "PermissaoGetPost")
        If Ina = True Then
            MsgBox("O usuário não está autorizado a usar esta opção do sistema.", 48, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.PermissaoGetPost.ShowDialog()
        End If
    End Sub
End Class