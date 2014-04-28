Public Class FolhaPgtoRelat
    Dim Ação As New TrfGerais

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Visualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Visualizar.Click
        If Me.A1.Checked = True Then
            RelatorioCarregar = "RelFolhaPgtoValeFuncionario"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A2.Checked = True Then
            RelatorioCarregar = "RelFolhaPgtoValores"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A3.Checked = True Then
            RelatorioCarregar = "RelFolhaPgtoValesViaCaixa"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A4.Checked = True Then
            RelatorioCarregar = "RelFolhaPgtoPIS"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

    End Sub

    Private Sub FolhaPgtoRelat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()
    End Sub

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

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged
        If Me.A1.Checked = True Then
            Me.PainelCompetencia.Visible = False
            Me.PainelFuncionario.Visible = False
            Me.SubRelat.Visible = False
        End If

        If Me.A2.Checked = True Then
            Me.PainelCompetencia.Visible = True
            Me.PainelFuncionario.Visible = False
            Me.SubRelat.Visible = False
            Me.Competencia.Focus()
        End If

        If Me.A3.Checked = True Then
            If B2.Checked = True And Me.Competencia.Text = "" Then
                MsgBox("O usuário deve informar a Competência para gerar o relatório", 64, "Validação de Dados")
                Exit Sub
            End If

            If B3.Checked = True And Me.Func.Text = "" Then
                MsgBox("O usuário deve informar o funcionário para gerar o relatório", 64, "Validação de Dados")
                Exit Sub
            End If

            If B4.Checked = True Then
                If Me.Competencia.Text = "" Then
                    MsgBox("O usuário deve informar a Competência para gerar o relatório", 64, "Validação de Dados")
                    Exit Sub
                End If
                If Me.Func.Text = "" Then
                    MsgBox("O usuário deve informar o funcionário para gerar o relatório", 64, "Validação de Dados")
                    Exit Sub
                End If
            End If


            Me.PainelCompetencia.Visible = False
            Me.PainelFuncionario.Visible = False
            Me.SubRelat.Visible = True
        End If

        If Me.A4.Checked = True Then
            Me.PainelCompetencia.Visible = False
            Me.PainelFuncionario.Visible = False
            Me.SubRelat.Visible = False
        End If

    End Sub

    Private Sub Func_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Func.KeyDown
        If e.KeyCode = Keys.F5 Then
            ChamaTelaProcura("Codigo", "Nome", "", "Funcionários", "CódigoFuncionário", "Nome", "", True)
            Me.Func.Text = RetornoProcura
        End If
    End Sub

    Private Sub Func_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Func.Validated
        If Me.Func.Text <> "" Then
            Ação.Descrição_ItenRegistro(Me.Func, Me.FuncDesc, "Funcionários", "CódigoFuncionário", Me.Func.Text, "Nome", TrfGerais.TipoDados.Numérico, True)
        End If
    End Sub

    Private Sub B1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.CheckedChanged, B2.CheckedChanged, B3.CheckedChanged, B4.CheckedChanged, B5.CheckedChanged
        If Me.B1.Checked = True Then
            Me.PainelCompetencia.Visible = False
            Me.PainelFuncionario.Visible = False
            Me.PainelEvento.Visible = False
        End If

        If Me.B2.Checked = True Then
            Me.PainelCompetencia.Visible = True
            Me.PainelFuncionario.Visible = False
            Me.PainelEvento.Visible = False
            Me.Competencia.Focus()
        End If

        If Me.B3.Checked = True Then
            Me.PainelCompetencia.Visible = False
            Me.PainelFuncionario.Visible = True
            Me.PainelEvento.Visible = False
            Me.Func.Focus()
        End If

        If Me.B4.Checked = True Then
            Me.PainelCompetencia.Visible = True
            Me.PainelFuncionario.Visible = True
            Me.PainelEvento.Visible = False
            Me.Competencia.Focus()
        End If

        If Me.B5.Checked = True Then
            Me.PainelCompetencia.Visible = True
            Me.PainelFuncionario.Visible = False
            Me.PainelEvento.Visible = True
            Me.Competencia.Focus()
        End If

    End Sub

    Private Sub TipoGeradorBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoGeradorBT.Click
        Dim X As New Point(27, 0)
        Me.MenuTipoGerador.Show(Me.TipoGeradorBT, X)
    End Sub

    Private Sub MensalDiaristaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MensalDiaristaToolStripMenuItem.Click, DécimoTerceiroToolStripMenuItem.Click, FériasToolStripMenuItem.Click, PgtoPISToolStripMenuItem.Click, RecisãoToolStripMenuItem.Click, PISToolStripMenuItem.Click, ValeQuinzenalToolStripMenuItem.Click
        Me.Modulo.Text = sender.ToString
    End Sub
End Class