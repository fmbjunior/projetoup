Public Class CaixaFechar

    Private Sub CaixaFecharAtualizarDados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DataCaixa.Text = My.Forms.Caixa.DataCaixa.Text
        Me.TotalCaixa.Text = My.Forms.Caixa.SaldoAtual.Text
    End Sub

    Private Sub btAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAtualizar.Click

        If Me.DataCaixa.Text = "" Then
            MsgBox("A data do caixa não foi informado, favor verificar.", 64, "Validação de Dados")
            Exit Sub
        ElseIf Me.TotalCaixa.Text = "" Then
            MsgBox("O total do caixa não foi informado, favor verificar.", 64, "Validação de Dados")
            Exit Sub
        End If

        Dim Msg As String = "Deseja fechar o caixa " & My.Forms.Caixa.CaixaCod.Text & " do dia " & Me.DataCaixa.Text & Chr(13) & "O Caixa depois de fechado não mais poderá ser alterado." & Chr(13) & "Qualquer duvida procure ajuda do responsavel."

        If Me.DataCaixa.Text = DataDia Then
            If MsgBox(Msg, 36, "Validação de Dados") = 6 Then


                Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
                Cnn.Open()

                Dim DS As New DataSet()
                Dim daCX As OleDb.OleDbDataAdapter

                Dim Sql As String = "SELECT * FROM CaixaDia WHERE CaixaCod = '" & My.Forms.Caixa.CaixaCod.Text & "' And DataCaixaDia = #" & Format(CDate(Me.DataCaixa.Text), "MM/dd/yyyy") & "# And Empresa = " & CodEmpresa
                daCX = New OleDb.OleDbDataAdapter(Sql, Cnn)
                daCX.Fill(DS, "CX")

                If DS.Tables("CX").Rows.Count > 0 Then
                    DS.Tables("CX").Rows(0).BeginEdit()
                    DS.Tables("CX").Rows(0)("SaldoDia") = CDbl(NzZero(Me.TotalCaixa.Text))
                    DS.Tables("CX").Rows(0)("Fechado") = True
                    DS.Tables("CX").Rows(0).EndEdit()

                    Dim objCommandBuilder1 As New OleDb.OleDbCommandBuilder(daCX)
                    daCX.Update(DS, "CX")
                    DS.Dispose()
                    Cnn.Close()
                    MessageBox.Show("Caixa Fechado com sucesso.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ErroLivre = "Caixa do dia finalizado com sucesso " & Me.TotalCaixa.Text
                    GerarLog(Me.Text, AçãoTP.Livre, My.Forms.Caixa.CaixaCod.Text)

                    CaixaAtivo = ""
                    Me.Close()
                    Me.Dispose()

                    System.Threading.Thread.Sleep(1500)
                    RelatorioCarregar = "RelCaixa"
                    My.Forms.VisualizadorRelatorio.ShowDialog()

                    My.Forms.Caixa.btFecharCX.Enabled = False
                    My.Forms.Caixa.btLancamentos.Enabled = False
                    My.Forms.Caixa.btAtualizar.Enabled = False
                    My.Forms.Caixa.DisplayAberto.Visible = False
                    My.Forms.Caixa.DisplayFechado.Visible = True

                Else
                    MessageBox.Show("Este caixa não foi criado neste dia, favor verificar.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Cnn.Close()
                    Exit Sub
                End If

            End If
        Else
            MsgBox("A data do caixa não é a mesma data do sistema, este caixa não pode ser fechado", 64, "Validação de Dados")
            Me.DataCaixa.Focus()
            Exit Sub
        End If

    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

End Class