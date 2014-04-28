Public Class FuncionariosRelat
    Dim Ação As New TrfGerais

    Private Sub btVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVisualizar.Click
        If Me.A1.Checked = True Then
            RelatorioCarregar = "RelFuncionaiosFoto"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A2.Checked = True Then
            RelatorioCarregar = "RelFuncionariosHistorico"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A3.Checked = True Then
            RelatorioCarregar = "RelFuncionariosDepartamento"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A4.Checked = True Then
            RelatorioCarregar = "RelFuncionariosDepartamentoSeleção"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A5.Checked = True Then
            RelatorioCarregar = "RelFuncionariosDataAdmissãoPeriodo"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A6.Checked = True Then
            RelatorioCarregar = "RelFuncionarioAtivos"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged, A4.CheckedChanged, A5.CheckedChanged
        If Me.A1.Checked = True Then
            Me.PainelFuncionario.Visible = False
            Me.PainelDepartamento.Visible = False
            Me.PainelPeriodo.Visible = False
        End If
        If Me.A2.Checked = True Then
            Me.PainelFuncionario.Visible = True
            Me.PainelDepartamento.Visible = False
            Me.PainelPeriodo.Visible = False
            Me.Func.Focus()
        End If
        If Me.A3.Checked = True Then
            Me.PainelFuncionario.Visible = False
            Me.PainelDepartamento.Visible = False
            Me.PainelPeriodo.Visible = False
            Me.Func.Focus()
        End If
        If Me.A4.Checked = True Then
            Me.PainelFuncionario.Visible = False
            Me.PainelDepartamento.Visible = True
            Me.PainelPeriodo.Visible = False
            Me.Departamento.Focus()
        End If
        If Me.A5.Checked = True Then
            Me.PainelFuncionario.Visible = False
            Me.PainelDepartamento.Visible = False
            Me.PainelPeriodo.Visible = True
            Me.DataInicial.Focus()
        End If

        If Me.A6.Checked = True Then
            Me.PainelFuncionario.Visible = False
            Me.PainelDepartamento.Visible = False
            Me.PainelPeriodo.Visible = False
        End If

    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Func_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Func.KeyDown
        If e.KeyCode = Keys.F5 Then
            ChamaTelaProcura("Codigo", "Nome", "", "Funcionários", "CódigoFuncionário", "Nome", "", True)
            Me.Func.Text = RetornoProcura
            Ação.Descrição_ItenRegistro(Me.Func, Me.FuncDesc, "Funcionários", "CódigoFuncionário", Me.Func.Text, "Nome", TrfGerais.TipoDados.Numérico, True)
        End If
    End Sub

    Private Sub Departamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Departamento.KeyDown
        If e.KeyCode = Keys.F5 Then
            ChamaTelaProcura("Codigo", "Descrição", "", "Departamentos", "Codigo", "Departamento", "", True)
            Me.Departamento.Text = RetornoProcura
            Ação.Descrição_ItenRegistro(Me.Departamento, Me.DepartamentoDesc, "Departamentos", "Codigo", Me.Departamento.Text, "Departamento", TrfGerais.TipoDados.Numérico, True)
        End If
    End Sub

    Private Sub FuncionariosRelat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
End Class