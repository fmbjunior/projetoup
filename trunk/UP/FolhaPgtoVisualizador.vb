Imports System.IO
Imports Microsoft.Win32


Public Class FolhaPgtoVisualizador

    Public NewItens As Boolean

    'Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
    '    If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
    '        SendKeys.Send("{Tab}")
    '        Return True
    '    End If
    '    Return MyBase.ProcessCmdKey(msg, keyData)
    'End Function

    Private Sub FolhaPgtoVisualizador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()
        Me.MesCompetencia.Text = MesAnoCompetencia
    End Sub

    Private Sub TipoGeradorBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoGeradorBT.Click
        Dim X As New Point(27, 0)
        Me.MenuTipoGerador.Show(Me.TipoGeradorBT, X)
    End Sub

    Private Sub MensalDiaristaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MensalDiaristaToolStripMenuItem.Click, DécimoTerceiroToolStripMenuItem.Click, FériasToolStripMenuItem.Click, PgtoPISToolStripMenuItem.Click, RecisãoToolStripMenuItem.Click, PISToolStripMenuItem.Click, ValeQuinzenalToolStripMenuItem.Click
        Me.Modulo.Text = sender.ToString
    End Sub


    Public Sub LocalizaDadosFuncionario()
        If Me.Funcionario.Text = "" Then Exit Sub

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()
        Dim Sql As String = "SELECT Funcionários.*, Profissao.Descrição, Funcionários.CódigoFuncionário FROM Funcionários INNER JOIN Profissao ON Funcionários.Profissão = Profissao.Codigo WHERE Funcionários.CódigoFuncionário = " & Me.Funcionario.Text & " And DataRecisao is null"
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.FuncionarioDesc.Text = DR.Item("Nome") & ""
            Me.Profissão.Text = DR.Item("Descrição") & ""
            Me.DataAdmissão.Text = DR.Item("DataAdmissão") & ""
            Me.Salario.Text = FormatNumber(Nz(DR.Item("Salario"), 3), 2)
            Me.SalarioRegistro.Text = FormatNumber(Nz(DR.Item("SalarioRegistro"), 3), 2)
            Me.CodPlanoContas.Text = DR.Item("CodPlanoContas") & ""

            If Not IsDBNull(DR.Item("Foto")) Then
                Dim ByteData() As Byte = DR.Item("Foto") 'stream em memória recebe a imagem
                Dim ImgVer As New IO.MemoryStream(ByteData)
                Me.Display.Visible = True
                Me.Display.Image = Image.FromStream(ImgVer)
            Else
                Me.Display.Image = Me.SemFoto.Image
            End If
        Else
            MsgBox("Funcioário não cadastrado ou não trabalha mais na empresa.", 64, "Validação de Dados")
            Me.Funcionario.Clear()
            Me.Funcionario.Focus()
        End If



        DR.Close()
        Cnn.Close()

    End Sub

    Private Sub Funcionario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Funcionario.KeyDown
        If e.KeyCode = Keys.F5 Then
            Me.Display.Image = Me.SemFoto.Image
            Me.Funcionario.Clear()
            Me.FuncionarioDesc.Clear()
            Me.DataAdmissão.Clear()
            Me.Profissão.Clear()
            Me.SalarioRegistro.Clear()
            Me.Salario.Clear()
            ChamaTelaProcura("Codigo", "Nome", "", "Funcionários", "CódigoFuncionário", "Nome", "", True)
            Me.Funcionario.Text = RetornoProcura
        End If
    End Sub

    Private Sub Funcionario_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Funcionario.Validated
        LocalizaDadosFuncionario()
        EncheLista()
    End Sub

    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub EncheLista()

        If Me.Funcionario.Text = "" Then Exit Sub

        MyLista.Items.Clear()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            If Me.Modulo.Text = "Mensalistas" Then
                .CommandText = "SELECT FolhaPgto.Id, FolhaPgto.Competencia, FolhaPgto.Modulo, FolhaPgto.Funcionario, FolhaPgto.Evento, FolhaPgto.Historico, FolhaPgto.Referencia, FolhaPgto.VlrDebito, FolhaPgto.VlrCredito, FolhaPgto.Empresa, FolhaPgto.Confirmado, FolhaPgto.Usuario, FolhaPgto.ContaDebito, FolhaPgto.ContaCredito, FolhaPgto.Protegido FROM(FolhaPgto) WHERE(((FolhaPgto.Competencia) = '" & Me.MesCompetencia.Text & "') And ((FolhaPgto.Modulo) = '" & Me.Modulo.Text & "' Or (FolhaPgto.Modulo) = 'Vale Quinzenal') And ((FolhaPgto.Funcionario) = " & Me.Funcionario.Text & ") And ((FolhaPgto.Empresa) = " & CodEmpresa & ")) ORDER BY FolhaPgto.Id;"
            Else
                .CommandText = "SELECT * FROM FolhaPgto Where Competencia = '" & Me.MesCompetencia.Text & "' and Modulo = '" & Me.Modulo.Text & "' and Funcionario = " & Me.Funcionario.Text & " Order by Id"
            End If
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            Dim Zebrar As Boolean = False

            Dim TDebito As Double = 0
            Dim TCredito As Double = 0
            While DR.Read
                If Not IsDBNull(DR.Item("id")) Then
                    Dim AA As String = DR.Item("id")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("Evento"))
                    It.SubItems.Add(DR.Item("Historico"))
                    It.SubItems.Add(DR.Item("Referencia"))
                    It.SubItems.Add(FormatNumber(DR.Item("VlrDebito"), 2))
                    It.SubItems.Add(FormatNumber(DR.Item("VlrCredito"), 2))
                    It.SubItems.Add(DR.Item("Confirmado"))
                    It.SubItems.Add(DR.Item("Usuario"))
                    It.SubItems.Add(DR.Item("Protegido"))

                    MyLista.Items.AddRange(New ListViewItem() {It})

                    If Zebrar = True Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.MistyRose
                        Zebrar = True
                    End If
                    TDebito += FormatNumber(NzVlr(DR.Item("VlrDebito")), 2)
                    TCredito += FormatNumber(NzVlr(DR.Item("VlrCredito")), 2)
                End If
            End While
            Me.TotDebito.Text = FormatNumber(TDebito, 2)
            Me.TotCredito.Text = FormatNumber(TCredito, 2)
            Me.Liquido.Text = FormatNumber(TCredito - TDebito, 2)

            DR.Close()
            Cnn.Close()
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Exit Sub
        End Try


    End Sub


    Private Sub NovoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click
        Me.MesCompetencia.Clear()
        Me.Modulo.Clear()
        Me.Funcionario.Clear()
        Me.DataAdmissão.Clear()
        Me.Profissão.Clear()
        Me.Salario.Clear()
        Me.SalarioRegistro.Clear()
        Me.FuncionarioDesc.Clear()
        Me.MyLista.Items.Clear()
        Me.MesCompetencia.Focus()
    End Sub

    Private Sub LocalizarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizarBT.Click
        Me.Funcionario.Clear()
        Me.DataAdmissão.Clear()
        Me.Profissão.Clear()
        Me.Salario.Clear()
        Me.SalarioRegistro.Clear()
        ChamaTelaProcura("Codigo", "Nome", "", "Funcionários", "CódigoFuncionário", "Nome", "", True)
        Me.Funcionario.Text = RetornoProcura
        Me.Funcionario.Focus()
    End Sub


    Private Sub NovoItemNaFolhaDePagamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoItemNaFolhaDePagamentoToolStripMenuItem.Click
        If Me.MesCompetencia.Text = "" Then
            MsgBox("O usuário deve informar o mês de competência", 64, "Validação de Dados")
            Exit Sub
        End If
        If Me.Modulo.Text = "" Then
            MsgBox("O usuário deve informar o modulo", 64, "Validação de Dados")
            Exit Sub
        End If
        If Me.Funcionario.Text = "" Then
            MsgBox("O usuário deve informar o funcionário", 64, "Validação de Dados")
            Exit Sub
        End If
        NewItens = True
        My.Forms.FolhaPgtoAdd.ShowDialog()
        EncheLista()
    End Sub

    Private Sub ExcluirItemSelecionadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirItemSelecionadoToolStripMenuItem.Click
        Dim I As Integer = 0

        Dim Idselecionado As String = ""
        Dim UserDoItem As String = ""
        Dim hist As String = ""
        Dim EstaConfirmado As Boolean = False
        Dim EstaProtegido As String = ""
        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then Idselecionado = (MyLista.Items(I).Text.Substring(0))
            If MyLista.Items(I).Selected = True Then hist = (MyLista.Items(I).SubItems(2).Text.Substring(0))
            If MyLista.Items(I).Selected = True Then EstaConfirmado = (MyLista.Items(I).SubItems(6).Text.Substring(0))
            If MyLista.Items(I).Selected = True Then UserDoItem = (MyLista.Items(I).SubItems(7).Text.Substring(0))
            If MyLista.Items(I).Selected = True Then EstaProtegido = (MyLista.Items(I).SubItems(8).Text.Substring(0))

        Next

        If EstaConfirmado = True Then
            MsgBox("Este item ja foi feito lançamentos e não pode ser excluido", 64, "Validação de Dados")
            Exit Sub
        End If

        If EstaProtegido = "S" Then
            MsgBox("Este item esta protegido não pode ser excluido", 64, "Validação de Dados")
            Exit Sub
        End If

        If Idselecionado <> "" Then
            If UserDoItem = UserAtivo Then


                Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
                Cnn.Open()

                Dim Sql As String = "Delete * from FolhaPgto where Id = " & Idselecionado & " and Confirmado= False"
                Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
                Dim DR As OleDb.OleDbDataReader

                DR = CMD.ExecuteReader

                DR.Close()
                Cnn.Close()
                EncheLista()
            Else
                MsgBox("Este lançamento não foi feito por este usuário, não pode ser excluido.", 64, "Validação de Dados")
                Exit Sub
            End If
        End If

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

    Private Sub CadFuncionarioBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadFuncionarioBT.Click
        My.Forms.Funcionarios.ShowDialog()
    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        Dim I As Integer = 0
        RetornoProcura = ""

        Dim EstaConfirmado As Boolean = False

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then RetornoProcura = (MyLista.Items(I).Text.Substring(0))
            If MyLista.Items(I).Selected = True Then EstaConfirmado = (MyLista.Items(I).SubItems(6).Text.Substring(0))
        Next

        If RetornoProcura = "" Then
            Exit Sub
        Else
            If EstaConfirmado = True Then
                MsgBox("Este item ja foi feito lançamentos e não pode ser Editado", 64, "Validação de Dados")
                Exit Sub
            End If
            NewItens = False
            My.Forms.FolhaPgtoAdd.ShowDialog()
            EncheLista()
        End If
    End Sub

    Private Sub btRecibo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRecibo.Click
        RelatorioCarregar = "RelReciboFolha"
        My.Forms.VisualizadorRelatorio.ShowDialog()
    End Sub
End Class