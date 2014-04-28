Public Class FolhaPgtoAdd

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Private Sub FolhaPgtoAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()

        Ação.Desbloquear_Controle(Me, False)

        If My.Forms.FolhaPgtoVisualizador.NewItens = True Then
            NovoBT_Click(sender, e)
        Else
            Operation = UPD
            LocalizaDados()
        End If
    End Sub

    Private Sub NovoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click
        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)
        Me.ModuloDescontar.Enabled = False
        Me.CompetenciaDesconto.Enabled = False
        Me.Funcionario.Enabled = False
        Me.FuncionarioDesc.Enabled = False
        Me.ModuloDescontar.Text = My.Forms.FolhaPgtoVisualizador.Modulo.Text
        Me.CompetenciaDesconto.Text = My.Forms.FolhaPgtoVisualizador.MesCompetencia.Text
        Me.Funcionario.Text = My.Forms.FolhaPgtoVisualizador.Funcionario.Text
        Me.FuncionarioDesc.Text = My.Forms.FolhaPgtoVisualizador.FuncionarioDesc.Text
        Me.CodPlanoContas.Text = My.Forms.FolhaPgtoVisualizador.CodPlanoContas.Text
        Me.Id.Text = "0000"
        Me.Id.Focus()
        Operation = INS
    End Sub

    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click
        'Area destinada para as validacoes

        If Me.Id.Text = "" Then
            MsgBox("O Código do Lançamento não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Id.Focus()
            Exit Sub
        ElseIf Me.ModuloDescontar.Text = "" Then
            MsgBox("O modulo de Quitação do débito não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.ModuloDescontar.Focus()
            Exit Sub
        ElseIf Me.VlrDebito.Text = "" Then
            MsgBox("O Valor do Débito deve ser zero ou conter um valor, favor verificar.", 64, "Validação de Dados")
            Me.VlrDebito.Focus()
            Exit Sub
        ElseIf Me.VlrCredito.Text = "" Then
            MsgBox("O Valor do Crédito deve ser zero ou conter um valor, favor verificar.", 64, "Validação de Dados")
            Me.VlrCredito.Focus()
            Exit Sub
        ElseIf Me.Evento.Text = "" Then
            MsgBox("O evento não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Evento.Focus()
            Exit Sub
        ElseIf Me.ContaDebito.Text = "" Then
            MsgBox("A conta de Débito não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Evento.Focus()
            Exit Sub
        ElseIf Me.ContaCredito.Text = "" Then
            MsgBox("A conta de Crédito não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Evento.Focus()
            Exit Sub
        ElseIf Me.Usuario.Text = "" Then
            MsgBox("A conta de Crédito não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Evento.Focus()
            Exit Sub
        ElseIf Me.Historico.Text = "" Then
            MsgBox("A descrição do evento não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Evento.Focus()
            Exit Sub
        ElseIf Me.Referencia.Text = "" Then
            MsgBox("A Referência não pode ser nula, verifique....", 64, "Validação de Dados")
            Me.Referencia.Focus()
            Exit Sub
        End If

        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            UltimoReg()
            Dim Sql As String = "INSERT INTO FolhaPgto (Id, Competencia, Modulo, Funcionario, Evento, Historico, Referencia, VlrDebito, VlrCredito, Empresa, Confirmado, Usuario, ContaDebito, ContaCredito, Protegido) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Id.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.CompetenciaDesconto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.ModuloDescontar.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Funcionario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Evento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Historico.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Referencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.VlrDebito.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.VlrCredito.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Me.Confirmado.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.Usuario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.ContaDebito.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.ContaCredito.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz("N", 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                Operation = UPD
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            Ação.Desbloquear_Controle(Me, False)
            CNN.Close()

        ElseIf Operation = UPD Then
            CNN.Open()

            Dim Sql As String = "Update FolhaPgto set Id = @1, Competencia = @2, Modulo = @3, Funcionario = @4, Evento = @5, Historico = @6, Referencia = @7, VlrDebito = @8, VlrCredito = @9, Empresa = @10, Confirmado = @11, Usuario = @12, ContaDebito = @13, ContaCredito = @14, Protegido = @15 Where Id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Id.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.CompetenciaDesconto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.ModuloDescontar.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Funcionario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Evento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Historico.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Referencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.VlrDebito.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.VlrCredito.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Me.Confirmado.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.Usuario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.ContaDebito.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.ContaCredito.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz("N", 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                Operation = UPD
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, False)
            CNN.Close()
        End If

    End Sub

    Public Sub UltimoReg()
        'Inserir ultimo registro
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer
        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select max(Id) from FolhaPgto"
            .CommandType = CommandType.Text
        End With
        Try
            Cnn.Open()
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    'Achou o iten procurado o iten as caixas serão preenchida
                    Ult = DataReader.Item(0)
                End If
            End While
            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()

        Me.Id.Text = Ult + 1

    End Sub

    Private Sub Funcionario_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Funcionario.Enter
        If Me.Evento.Text = "" Then
            MsgBox("O usuário deve informar primeiro o evento e depois o funcionário.", 64, "Validação de Dados")
            Me.Evento.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub Funcionario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Funcionario.KeyDown
        If e.KeyCode = Keys.F5 Then
            ChamaTelaProcura("Codigo", "Nome", "", "Funcionários", "CódigoFuncionário", "Nome", "", True)
            Me.Funcionario.Text = RetornoProcura
        End If
    End Sub

    Private Sub Funcionario_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Funcionario.Validated
        LocalizaDadosFuncionario()
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
            Me.CodPlanoContas.Text = DR.Item("CodPlanoContas") & ""
            If Me.ContaDebito.Text = "00000000000000" Then Me.ContaDebito.Text = Me.CodPlanoContas.Text
            If Me.ContaCredito.Text = "00000000000000" Then Me.ContaCredito.Text = Me.CodPlanoContas.Text
        Else
            MsgBox("Funcioário não cadastrado ou não trabalha mais na empresa.", 64, "Validação de Dados")
            Me.Funcionario.Clear()
            Me.Funcionario.Focus()
        End If


        DR.Close()
        Cnn.Close()

    End Sub

    Private Sub Evento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Evento.KeyDown
        If e.KeyCode = Keys.F5 Then
            SomenteEvento = "S"
            ChamaTelaProcura("Codigo", "Descricão", "", "FolhaPgtoEventos", "CodigoEvento", "Descrição", "", True)
            Me.Evento.Text = RetornoProcura
            Me.Evento.Focus()
        End If
    End Sub

    Private Sub Evento_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Evento.Validated
        LocalizaDadosEvento()
    End Sub

    Public Sub LocalizaDadosEvento()
        If Me.Evento.Text = "" Then Exit Sub

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from FolhaPgtoEventos where CodigoEvento = " & Me.Evento.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            If Me.Historico.Text = "" Then Me.Historico.Text = DR.Item("Descrição") & ""
            If Me.ContaDebito.Text = "" Then Me.ContaDebito.Text = DR.Item("Debito") & ""
            If Me.ContaCredito.Text = "" Then Me.ContaCredito.Text = DR.Item("Credito") & ""
        End If
        DR.Close()
        CNN.Close()
    End Sub

    Private Sub Usuario_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Usuario.Enter
        If Me.Usuario.Text = "" Then
            Me.Usuario.Text = UserAtivo
        End If
    End Sub

    Private Sub ExcluirBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Opção Indisponivel")
    End Sub

    Private Sub LocalizarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Ação.Desbloquear_Controle(Me, False)
        ChamaTelaProcura("Codigo", "Descrição", "Valor", "FolhaPgtoValeFuncionarios", "Id", "EventoDesc", "ValorLancamento", True)

        Me.Id.Text = RetornoProcura
        If Me.Id.Text <> "" Then
            LocalizaDados()
            Me.VlrDebito.Focus()
        End If
    End Sub

    Public Sub LocalizaDados()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT FolhaPgto.Id, FolhaPgto.Competencia, FolhaPgto.Modulo, FolhaPgto.Funcionario, Funcionários.Nome, Funcionários.CodPlanoContas, FolhaPgto.Evento, FolhaPgto.Historico, FolhaPgto.Referencia, FolhaPgto.VlrDebito, FolhaPgto.VlrCredito, FolhaPgto.Empresa, FolhaPgto.Confirmado, FolhaPgto.Usuario, FolhaPgto.ContaDebito, FolhaPgto.ContaCredito, FolhaPgto.Protegido FROM FolhaPgto INNER JOIN Funcionários ON FolhaPgto.Funcionario = Funcionários.CódigoFuncionário WHERE (((FolhaPgto.Id)=" & RetornoProcura & "));"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.Id.Text = DR.Item("id") & ""
            Me.CompetenciaDesconto.Text = DR.Item("Competencia") & ""
            Me.ModuloDescontar.Text = DR.Item("Modulo") & ""
            Me.Funcionario.Text = DR.Item("Funcionario") & ""
            Me.FuncionarioDesc.Text = DR.Item("Nome") & ""
            Me.CodPlanoContas.Text = DR.Item("CodPlanoContas") & ""
            Me.Evento.Text = DR.Item("Evento") & ""
            Me.Historico.Text = DR.Item("Historico") & ""
            Me.Referencia.Text = DR.Item("Referencia") & ""
            Me.VlrDebito.Text = FormatNumber(NzVlr(DR.Item("VlrDebito")), 2)
            Me.VlrCredito.Text = FormatNumber(NzVlr(DR.Item("VlrCredito")), 2)
            Me.Confirmado.Checked = DR.Item("Confirmado")
            Me.Usuario.Text = DR.Item("Usuario") & ""
            Me.ContaDebito.Text = DR.Item("ContaDebito") & ""
            Me.ContaCredito.Text = DR.Item("ContaCredito") & ""

            Ação.Desbloquear_Controle(Me, True)
            Me.ModuloDescontar.Enabled = False
            Me.CompetenciaDesconto.Enabled = False
            Me.Funcionario.Enabled = False
            Me.FuncionarioDesc.Enabled = False

        End If

        Operation = UPD
        DR.Close()
    End Sub

    Private Sub Degrade()
        Try
            Dim CCor() As String
            Dim corTemp As String

            corTemp = Cor1TelaSecundaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))

            corTemp = Cor2TelaSecundaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Referencia_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Referencia.Enter
        If Me.Referencia.Text = "" Then
            Me.Referencia.Text = 1
        End If
    End Sub
End Class