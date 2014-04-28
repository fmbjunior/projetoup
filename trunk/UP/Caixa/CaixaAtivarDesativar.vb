Public Class CaixaAtivarDesativar

    Dim VarSenha As String

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub CodigoCaixa_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CodigoCaixa.Leave
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()
        Dim Sql As String = "Select * from CaixaCadastro where CodigoCaixa = '" & Me.CodigoCaixa.Text & "' And Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.CaixaNome.Text = DR.Item("CaixaNome") & ""
            Me.Responsavel.Text = DR.Item("Responsavel") & ""
            VarSenha = DR.Item("Senha")
        Else
            MessageBox.Show("Caixa inexistente, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CodigoCaixa.Clear()
            Me.CodigoCaixa.Focus()
            Exit Sub
        End If
        DR.Close()

        Sql = "Select * From CaixaDia Where DataCaixaDia = #" & Format(CDate(DataDia), "MM/dd/yyyy") & "# And CaixaCod = '" & Me.CodigoCaixa.Text & "' and Empresa = " & CodEmpresa & " And Fechado = False"
        CMD = New OleDb.OleDbCommand(Sql, Cnn)

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.DataCaixa.Text = DR.Item("DataCaixaDia")
        Else
            Me.DataCaixa.Text = DataDia
        End If
        DR.Close()

        Cnn.Close()
    End Sub

    Private Sub btAtivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAtivar.Click

        If CaixaAtivo = Me.CodigoCaixa.Text Then
            MessageBox.Show("Esta conta de Caixa já esta ativada use a opção Desativar o Caixa.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.Senha.Text = VarSenha Then

            'Verificar se tem caixa Aberto
            Dim Sql As String = "SELECT CaixaDia.DataCaixaDia, CaixaDia.CaixaCod, CaixaDia.SaldoDiaAnterior, CaixaDia.SaldoDia, CaixaDia.Fechado, CaixaDia.Empresa FROM CaixaDia WHERE DataCaixaDia = #" & Format(CDate(DataDia), "MM/dd/yyyy") & "# And CaixaDia.CaixaCod = '" & Me.CodigoCaixa.Text & "' AND CaixaDia.Fechado = False"

            Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            Cnn.Open()

            Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
            Dim DR As OleDb.OleDbDataReader

            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                If Format(CDate(DR.Item("DataCaixaDia")), "dd/MM/yyyy") = Format(CDate(DataDia), "dd/MM/yyyy") Then
                    CaixaAtivo = Me.CodigoCaixa.Text
                    CaixaNomeVar = Mid(Me.CaixaNome.Text, 1, 15)
                    My.Forms.MenuGeral.DisplayCaixaAtivo.Text = "Caixa Ativo: " & CaixaAtivo
                    MessageBox.Show("Conta do Caixa ativado com Sucesso.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    My.Forms.Caixa.btFecharCX.Enabled = True
                    'GerarLog(Me.Text, AçãoTP.Adicionou, Me.CaixaNome.Text)
                    ErroLivre = "Caixa Ativado Nr.  " & Me.CodigoCaixa.Text
                    GerarLog(Me.Text, AçãoTP.Livre, Me.CaixaNome.Text)


                End If
            Else
                MessageBox.Show("Não existe Caixa aberto para este código, caixa não ativado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Cnn.Close()
                Me.btCriarCaixa.Visible = True
                Exit Sub
            End If
            Cnn.Close()
            'fim desta verificação

            Me.Close()
            Me.Dispose()
        Else
            MessageBox.Show("Senha do Caixa Incorreta.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Senha.SelectAll()
            Me.Senha.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub btDesativar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDesativar.Click
        If CaixaAtivo = "" Then
            MessageBox.Show("Esta conta de Caixa não esta ativa use a opção Ativar o Caixa.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.Senha.Text = VarSenha Then
            CaixaAtivo = ""
            My.Forms.MenuGeral.DisplayCaixaAtivo.Text = "Caixa Ativo: "
            MessageBox.Show("Conta do Caixa Desativado com Sucesso.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GerarLog(Me.Text, AçãoTP.Inativou, Me.CaixaNome.Text)
            Me.Close()
            Me.Dispose()
        Else
            MessageBox.Show("Senha do Caixa Incorreta.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Senha.SelectAll()
            Me.Senha.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub btCriarCaixa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCriarCaixa.Click

        If Me.Senha.Text = VarSenha Then

            'Verificar se tem caixa Aberto
            Dim Sql As String = "SELECT CaixaDia.DataCaixaDia, CaixaDia.CaixaCod, CaixaDia.SaldoDiaAnterior, CaixaDia.SaldoDia, CaixaDia.Fechado, CaixaDia.Empresa FROM CaixaDia WHERE DataCaixaDia = #" & Format(CDate(DataDia), "MM/dd/yyyy") & "# And CaixaDia.CaixaCod = '" & Me.CodigoCaixa.Text & "' and Empresa = " & CodEmpresa

            Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            Cnn.Open()

            Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
            Dim DR As OleDb.OleDbDataReader

            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                If CDate(DataDia) = CDate(Me.DataCaixa.Text) Then

                    'buscar o saldo do ultimo caixa
                    'Sql = "SELECT Last(CaixaDia.DataCaixaDia) AS ÚltimoDeDataCaixaDia, Last(CaixaDia.CaixaCod) AS ÚltimoDeCaixaCod, Last(CaixaDia.SaldoDia) AS ÚltimoDeSaldoDia, Last(CaixaDia.Empresa) AS ÚltimoDeEmpresa FROM(CaixaDia) WHERE(((CaixaDia.Fechado) = True)) HAVING (((Last(CaixaDia.CaixaCod))='" & Me.CodigoCaixa.Text & "') AND ((Last(CaixaDia.Empresa))=" & CodEmpresa & "));"
                    'Sql = "SELECT Last(CaixaDia.DataCaixaDia) AS ÚltimoDeDataCaixaDia, Last(CaixaDia.SaldoDia) AS ÚltimoDeSaldoDia FROM(CaixaDia) WHERE (((CaixaDia.CaixaCod)='" & Me.CodigoCaixa.Text & "') AND ((CaixaDia.Fechado)=True) AND ((CaixaDia.Empresa)=" & CodEmpresa & "));"

                    Sql = "SELECT Max(CaixaDia.DataCaixaDia) AS MáxDeDataCaixaDia FROM CaixaDia WHERE (((CaixaDia.CaixaCod)='" & Me.CodigoCaixa.Text & "') AND ((CaixaDia.Fechado)=True) AND ((CaixaDia.Empresa)=" & CodEmpresa & "));"
                    Dim CmdSaldo As New OleDb.OleDbCommand(Sql, Cnn)
                    Dim DrSaldo As OleDb.OleDbDataReader

                    DrSaldo = CmdSaldo.ExecuteReader
                    DrSaldo.Read()

                    Dim UltData As String = String.Empty
                    If DrSaldo.HasRows = True Then
                        UltData = DrSaldo.Item("MáxDeDataCaixaDia")
                        'SaldoAnt = NzZero(DrSaldo.Item("MáxDeSaldoDia"))
                    End If
                    DrSaldo.Close()


                    Sql = "SELECT * FROM CaixaDia WHERE (((CaixaDia.CaixaCod)='" & Me.CodigoCaixa.Text & "') AND ((CaixaDia.Fechado)=True) AND ((CaixaDia.Empresa)=" & CodEmpresa & ")) and DataCaixaDia = #" & Format(CDate(UltData), "MM/dd/yyy") & "#"
                    Dim CmdSaldo1 As New OleDb.OleDbCommand(Sql, Cnn)
                    Dim DrSaldo1 As OleDb.OleDbDataReader

                    DrSaldo1 = CmdSaldo1.ExecuteReader
                    DrSaldo1.Read()

                    Dim SaldoAnt As Double = 0
                    If DrSaldo1.HasRows = True Then
                        SaldoAnt = NzZero(DrSaldo1.Item("SaldoDia"))
                    End If
                    DrSaldo1.Close()



                    Sql = "INSERT INTO CaixaDia ( DataCaixaDia, CaixaCod, SaldoDiaAnterior, SaldoDia, Fechado, Empresa ) Values (@1, @2, @3, @4, @5, @6) "
                    Dim CmdCriar As New OleDb.OleDbCommand(Sql, Cnn)

                    CmdCriar.Parameters.Add(New OleDb.OleDbParameter("@1", Me.DataCaixa.Text))
                    CmdCriar.Parameters.Add(New OleDb.OleDbParameter("@2", Me.CodigoCaixa.Text))
                    CmdCriar.Parameters.Add(New OleDb.OleDbParameter("@3", SaldoAnt))
                    CmdCriar.Parameters.Add(New OleDb.OleDbParameter("@4", 0))
                    CmdCriar.Parameters.Add(New OleDb.OleDbParameter("@5", False))
                    CmdCriar.Parameters.Add(New OleDb.OleDbParameter("@6", CodEmpresa))
                    CmdCriar.ExecuteNonQuery()
                    CaixaAtivo = Me.CodigoCaixa.Text
                    My.Forms.MenuGeral.DisplayCaixaAtivo.Text = "Caixa Ativo: " & CaixaAtivo

                    ErroLivre = "Criado Caixa para o Dia de Trabalho com sucesso, Caixa NR. " & Me.CodigoCaixa.Text
                    GerarLog(Me.Text, AçãoTP.Livre, Me.CaixaNome.Text)

                    MessageBox.Show("Caixa Criado e Ativado com sucesso.", "Validaçao de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    Cnn.Close()
                    Me.Close()
                    Me.Dispose()
                End If
            Else
                MessageBox.Show("Este Caixa ja existe neste dia e não pode ser mais criado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Cnn.Close()
                Exit Sub
            End If
            Cnn.Close()
            'fim desta verificação
        Else
            MessageBox.Show("Senha do Caixa Incorreta.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Senha.SelectAll()
            Me.Senha.Focus()
            Exit Sub
        End If

    End Sub

    Private Sub btFindCaixa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindCaixa.Click
        My.Forms.CaixaProcura.ShowDialog()
        Me.CodigoCaixa.Focus()
    End Sub

    Private Sub CodigoCaixa_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoCaixa.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.CaixaProcura.ShowDialog()
            Me.CodigoCaixa.Focus()
        End If
    End Sub
End Class