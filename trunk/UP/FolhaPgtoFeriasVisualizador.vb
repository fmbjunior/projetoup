Public Class FolhaPgtoFeriasVisualizador
    Dim CRITERIO As Integer
    Dim Ação As New TrfGerais()

    Public Edição As Boolean = False
    Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

    Public Sub EncheLista()
        If Me.Funcionario.Text = "" Then
            MyLista.Items.Clear()
            Exit Sub
        End If

        MyLista.Items.Clear()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader


        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM FolhaPgtoFerias WHERE  Funcionario = " & Me.Funcionario.Text & " order by Id"
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            Dim Zebrar As Boolean = False
            While DR.Read
                If Not IsDBNull(DR.Item("Id")) Then
                    Dim AA As String = DR.Item("Id")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("Periodo1"))
                    It.SubItems.Add(DR.Item("Periodo2"))
                    It.SubItems.Add(DR.Item("DiasTotal"))
                    It.SubItems.Add(DR.Item("DiasGozo"))
                    It.SubItems.Add(Nz(DR.Item("DataInicial"), 2))
                    It.SubItems.Add(Nz(DR.Item("DataFinal"), 2))
                    It.SubItems.Add(FormatNumber(Nz(DR.Item("SalarioReg"), 3), 2))
                    It.SubItems.Add(FormatNumber(Nz(DR.Item("SalarioDif"), 3), 2))
                    It.SubItems.Add(FormatNumber(Nz(DR.Item("Variaveis"), 3), 2))
                    It.SubItems.Add(FormatNumber(Nz(DR.Item("ValorFerias"), 3), 2))
                    It.SubItems.Add(FormatNumber(Nz(DR.Item("ValorInss"), 3), 2))
                    It.SubItems.Add(FormatNumber(Nz(DR.Item("ValorLiquido"), 3), 2))
                    It.SubItems.Add(FormatNumber(Nz(DR.Item("Vale"), 3), 2))
                    It.SubItems.Add(DR.Item("Pago"))

                    MyLista.Items.AddRange(New ListViewItem() {It})

                    If Zebrar = True Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.MistyRose
                        Zebrar = True
                    End If

                End If
            End While

            DR.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Exit Sub
        End Try

    End Sub

    Private Sub Funcionario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Funcionario.KeyDown
        If e.KeyCode = Keys.F5 Then
            If Me.Funcionario.Text = "" Then
                RetornoProcura = ""
                ChamaTelaProcura("Codigo", "Nome", "", "Funcionários", "CódigoFuncionário", "Nome", "", True)
                Me.Funcionario.Text = RetornoProcura
            End If
        End If
    End Sub

    Private Sub Funcionario_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Funcionario.Leave
        LocalizaDadosFuncionario()
        EncheLista()
    End Sub

    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        Cnn.Close()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub LocalizarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizarBT.Click
        Ação.Desbloquear_Controle(Me, True)
        Ação.LimpaTextBox(Me)
        Me.EncheLista()
    End Sub

    Public Sub LocalizaDadosFuncionario()

        If Me.Funcionario.Text = "" Then Exit Sub

        Dim Sql As String = "Select * from Funcionários where CódigoFuncionário = " & Me.Funcionario.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.FuncionarioDesc.Text = DR.Item("Nome") & ""
            Me.Cpf.Text = DR.Item("Cpf") & ""
            Me.DataAdmissao.Text = DR.Item("DataAdmissão") & ""
            Me.DataRecisao.Text = DR.Item("DataRecisao") & ""
            Me.SalarioReg.Text = FormatNumber(Nz(DR.Item("SalarioRegistro"), 3), 2)
            Me.SalarioDif.Text = FormatNumber(Nz(DR.Item("Salario"), 3), 2)
        Else
            Ação.LimpaTextBox(Me)
            Me.Funcionario.Focus()
        End If

        DR.Close()

    End Sub

    Private Sub FolhaPgtoFeriasVisualizador_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F7
                Ação.LimpaTextBox(Me)
                Me.MyLista.Items.Clear()
            Case Keys.F12
                Me.Close()

        End Select

    End Sub

    Private Sub FolhaPgtoFeriasVisualizador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()
        Ação.Desbloquear_Controle(Me, False)
        Cnn.Open()
    End Sub

    Private Sub CadFuncionarioBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadFuncionarioBT.Click
        My.Forms.Funcionarios.ShowDialog()
    End Sub

    Private Sub AddPeriodoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPeriodoBT.Click

        'Verifica se o funcionário é vazio, se for da uma mensagem e sai da sub.
        If Me.Funcionario.Text = "" Then
            MsgBox("Não existe funcioário pada adicionar férias.", 64, "Validação de Dados")
            Exit Sub
        End If

        If MesAnoCompetencia = "" Then
            MsgBox("Não foi definido a Competência para trabalho, favor definir.", 64, "Validação de Dados")
            My.Forms.FolhaPgtoDefinirCompetencia.ShowDialog()
            Exit Sub
        End If


        Edição = False
        My.Forms.FolhaPgtoFeriasAddEdd.ShowDialog()

        If Cnn.State = ConnectionState.Open Then
            EncheLista()
        Else
            Cnn.Open()
            EncheLista()
        End If

    End Sub


    'Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
    '    If Me.Funcionario.Text = "" Then
    '        MsgBox("Não existe funcioário pada adicionar férias.", 64, "Validação de Dados")
    '        Exit Sub
    '    End If

    '    If MesAnoCompetencia = "" Then
    '        MsgBox("Não foi definido a Competência para trabalho, favor definir.", 64, "Validação de Dados")
    '        My.Forms.FolhaPgtoDefinirCompetencia.ShowDialog()
    '        Exit Sub
    '    End If

    '    Edição = True
    '    My.Forms.FolhaPgtoFeriasAddEdd.ShowDialog()
    '    Cnn.Open()
    '    EncheLista()
    'End Sub

    Private Sub Degrade()
        Try
            Dim CCor() As String
            Dim corTemp As String

            corTemp = Cor1TelaPrimaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))

            corTemp = Cor2TelaPrimaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))
        Catch ex As Exception
        End Try
    End Sub



    Private Sub pagarFerias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pagarFerias.Click
        Me.Cursor = Cursors.WaitCursor
        My.Forms.FolhaPgtoFeriasGerarLancamento.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub



    Private Sub ExcluirLançamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirLançamentoToolStripMenuItem.Click
        Try

            If CRITERIO = 0 Then
                Me.ExcluirLançamentoToolStripMenuItem.Enabled = False

            Else
                'Verifica se a tecla Delete foi pressionada.
                'Se for execute:

                Me.ExcluirLançamentoToolStripMenuItem.Enabled = True
                Dim Cmd As New OleDb.OleDbCommand()
                Dim DR As OleDb.OleDbDataReader

                With Cmd
                    .Connection = Cnn
                    .CommandTimeout = 0
                    .CommandText = "Delete * FROM FolhaPgtoFerias WHERE  ID = " & CRITERIO
                    .CommandType = CommandType.Text
                End With

                'Executa  o Data Reader atraves do objeto command
                DR = Cmd.ExecuteReader

                'Enche o listveiw
                EncheLista()
                'Aqui fecha o Data Reader
                DR.Close()
                CRITERIO = 0
            End If
            'Fim da condição if.


        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub MyLista_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyLista.MouseClick
        CRITERIO = Me.MyLista.Items(0).Text
    End Sub


    Private Sub EditarLançamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarLançamentoToolStripMenuItem.Click
        Edição = True
        My.Forms.FolhaPgtoFeriasAddEdd.ShowDialog()
    End Sub

    Private Sub Funcionario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Funcionario.TextChanged

    End Sub
End Class