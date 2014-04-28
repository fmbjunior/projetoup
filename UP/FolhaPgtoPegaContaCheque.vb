Public Class FolhaPgtoPegaContaCheque

    Private Sub BancoCheque_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BancoCheque.KeyDown
        If e.KeyCode = Keys.F5 Then
            ChamaTelaProcura("Codigo", "Conta Corrente", "", "Banco", "Codigo", "ContaCorrente", "", True)
            Me.BancoCheque.Text = RetornoProcura
        End If
    End Sub

    Private Sub BancoCheque_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles BancoCheque.Validated
        LocalizaDadosBanco(Me.BancoCheque.Text)
    End Sub

    Public Sub LocalizaDadosBanco(ByVal Cod As String)
        If Cod = "" Then Exit Sub

        Dim DBOpen As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        DBOpen.Open()
        Dim Sql As String = "Select * from Banco where Codigo = " & Cod & " and Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, DBOpen)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.BancoChequeDesc.Text = DR.Item("NomeBanco") & ""
            Me.BancoChequeConta.Text = DR.Item("PCBanco") & ""
        End If

        DR.Close()
        DBOpen.Close()

    End Sub

    Private Sub btOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOK.Click
        If Me.BancoCheque.Text = "" Then
            MsgBox("O usuário deve informar a conta do banco, Verifique...", 64, "Validação de Dados")
            Me.BancoCheque.Focus()
            Exit Sub
        End If
        If Me.Inicial.Text = "" Then
            MsgBox("O usuário deve informar o cheque inicial, Verifique...", 64, "Validação de Dados")
            Me.Inicial.Focus()
            Exit Sub
        End If
        If Me.Final.Text = "" Then
            MsgBox("O usuário deve informar o cheque final, Verifique...", 64, "Validação de Dados")
            Me.Final.Focus()
            Exit Sub
        End If

        My.Forms.FolhaPgtoGerarLancamentos.ContaCheque = Me.BancoChequeConta.Text
        My.Forms.FolhaPgtoGerarLancamentos.ContaChequeCod = Me.BancoCheque.Text
        My.Forms.FolhaPgtoGerarLancamentos.ChequeInicial = Me.Inicial.Text
        My.Forms.FolhaPgtoGerarLancamentos.ChequeFinal = Me.Final.Text

        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class