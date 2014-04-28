Imports System.Data.OleDb
Public Class PedidoVendaSenhaItem

    Private Sub btCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelar.Click
        Me.Close()
        Me.Dispose()
        My.Forms.PedidoAddItem.Desconto.Focus()
    End Sub

    Private Sub btConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConfirmar.Click

        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim CMD As New OleDbCommand()
        Dim DataReader As OleDbDataReader

        With CMD
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * From LoginUser Where Login = '" & Me.Usuario.Text & "'"
            .CommandType = CommandType.Text
        End With

        DataReader = CMD.ExecuteReader

        DataReader.Read()
        If DataReader.HasRows = True Then

            If DataReader.Item("Senha") = Me.Senha.Text Then
                TRVDados(Me.Usuario.Text, "PedidoVendaSenhaItem")
                If Ina = True Then
                    MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
                    Exit Sub
                End If
                MsgBox("Autorizada por " & DataReader.Item("NomeUser"))


                My.Forms.PedidoAddItem.UserSenhaDesconto.Text = DataReader.Item("Login") & "-" & DataReader.Item("Senha")
                My.Forms.OSorcamentoItemServicoAdd.UserSenhaDesconto.Text = DataReader.Item("Login") & "-" & DataReader.Item("Senha")
                My.Forms.PedidoAddItemOS.UserSenhaDesconto.Text = DataReader.Item("Login") & "-" & DataReader.Item("Senha")
                My.Forms.OrçamentoItens.UserSenhaDesconto.Text = DataReader.Item("Login") & "-" & DataReader.Item("Senha")
                My.Forms.OSorçamentoItens.UserSenhaDesconto.Text = DataReader.Item("Login") & "-" & DataReader.Item("Senha")
                My.Forms.PedOSServicoAdd.UserSenhaDesconto.Text = DataReader.Item("Login") & "-" & DataReader.Item("Senha")
                DataReader.Close()
                Cnn.Close()
                Me.Close()
                Me.Dispose()
                'My.Forms.PedidoVenda.Desconto.Focus()
            Else
                MsgBox("Senha invalida para este usuário. Verifique.....", 64, "Validação de Dados")
                Me.Usuario.Clear()
                Me.Senha.Clear()
                Me.Usuario.Focus()
                Exit Sub
            End If
        Else
            MsgBox("Usuário não cadastrado. Verifique.....", 64, "Validação de Dados")
            Me.Usuario.Clear()
            Me.Senha.Clear()
            Me.Usuario.Focus()
            Exit Sub
        End If

        DataReader.Close()
        Cnn.Close()

    End Sub
End Class