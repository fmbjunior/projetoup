Public Class FolhaPgtoAdd

    Dim A��o As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Private Sub FolhaPgtoAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()

        A��o.Desbloquear_Controle(Me, False)

        If My.Forms.FolhaPgtoVisualizador.NewItens = True Then
            NovoBT_Click(sender, e)
        Else
            Operation = UPD
            LocalizaDados()
        End If
    End Sub

    Private Sub NovoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click
        A��o.LimpaTextBox(Me)
        A��o.Desbloquear_Controle(Me, True)
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
            MsgBox("O C�digo do Lan�amento n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Id.Focus()
            Exit Sub
        ElseIf Me.ModuloDescontar.Text = "" Then
            MsgBox("O modulo de Quita��o do d�bito n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.ModuloDescontar.Focus()
            Exit Sub
        ElseIf Me.VlrDebito.Text = "" Then
            MsgBox("O Valor do D�bito deve ser zero ou conter um valor, favor verificar.", 64, "Valida��o de Dados")
            Me.VlrDebito.Focus()
            Exit Sub
        ElseIf Me.VlrCredito.Text = "" Then
            MsgBox("O Valor do Cr�dito deve ser zero ou conter um valor, favor verificar.", 64, "Valida��o de Dados")
            Me.VlrCredito.Focus()
            Exit Sub
        ElseIf Me.Evento.Text = "" Then
            MsgBox("O evento n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Evento.Focus()
            Exit Sub
        ElseIf Me.ContaDebito.Text = "" Then
            MsgBox("A conta de D�bito n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Evento.Focus()
            Exit Sub
        ElseIf Me.ContaCredito.Text = "" Then
            MsgBox("A conta de Cr�dito n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Evento.Focus()
            Exit Sub
        ElseIf Me.Usuario.Text = "" Then
            MsgBox("A conta de Cr�dito n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Evento.Focus()
            Exit Sub
        ElseIf Me.Historico.Text = "" Then
            MsgBox("A descri��o do evento n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Evento.Focus()
            Exit Sub
        ElseIf Me.Referencia.Text = "" Then
            MsgBox("A Refer�ncia n�o pode ser nula, verifique....", 64, "Valida��o de Dados")
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
                MsgBox("Registro adicionado com sucesso", 64, "Valida��o de Dados")
                Operation = UPD
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Valida��o de Dados")
            End Try
            A��o.Desbloquear_Controle(Me, False)
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
                MsgBox("Registro Atualizado com sucesso", 64, "Valida��o de Dados")
                Operation = UPD
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            A��o.Desbloquear_Controle(Me, False)
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
                    'Achou o iten procurado o iten as caixas ser�o preenchida
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
            MsgBox("O usu�rio deve informar primeiro o evento e depois o funcion�rio.", 64, "Valida��o de Dados")
            Me.Evento.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub Funcionario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Funcionario.KeyDown
        If e.KeyCode = Keys.F5 Then
            ChamaTelaProcura("Codigo", "Nome", "", "Funcion�rios", "C�digoFuncion�rio", "Nome", "", True)
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
        Dim Sql As String = "SELECT Funcion�rios.*, Profissao.Descri��o, Funcion�rios.C�digoFuncion�rio FROM Funcion�rios INNER JOIN Profissao ON Funcion�rios.Profiss�o = Profissao.Codigo WHERE Funcion�rios.C�digoFuncion�rio = " & Me.Funcionario.Text & " And DataRecisao is null"
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
            MsgBox("Funcio�rio n�o cadastrado ou n�o trabalha mais na empresa.", 64, "Valida��o de Dados")
            Me.Funcionario.Clear()
            Me.Funcionario.Focus()
        End If


        DR.Close()
        Cnn.Close()

    End Sub

    Private Sub Evento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Evento.KeyDown
        If e.KeyCode = Keys.F5 Then
            SomenteEvento = "S"
            ChamaTelaProcura("Codigo", "Descric�o", "", "FolhaPgtoEventos", "CodigoEvento", "Descri��o", "", True)
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
            If Me.Historico.Text = "" Then Me.Historico.Text = DR.Item("Descri��o") & ""
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
        MsgBox("Op��o Indisponivel")
    End Sub

    Private Sub LocalizarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        A��o.Desbloquear_Controle(Me, False)
        ChamaTelaProcura("Codigo", "Descri��o", "Valor", "FolhaPgtoValeFuncionarios", "Id", "EventoDesc", "ValorLancamento", True)

        Me.Id.Text = RetornoProcura
        If Me.Id.Text <> "" Then
            LocalizaDados()
            Me.VlrDebito.Focus()
        End If
    End Sub

    Public Sub LocalizaDados()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT FolhaPgto.Id, FolhaPgto.Competencia, FolhaPgto.Modulo, FolhaPgto.Funcionario, Funcion�rios.Nome, Funcion�rios.CodPlanoContas, FolhaPgto.Evento, FolhaPgto.Historico, FolhaPgto.Referencia, FolhaPgto.VlrDebito, FolhaPgto.VlrCredito, FolhaPgto.Empresa, FolhaPgto.Confirmado, FolhaPgto.Usuario, FolhaPgto.ContaDebito, FolhaPgto.ContaCredito, FolhaPgto.Protegido FROM FolhaPgto INNER JOIN Funcion�rios ON FolhaPgto.Funcionario = Funcion�rios.C�digoFuncion�rio WHERE (((FolhaPgto.Id)=" & RetornoProcura & "));"

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

            A��o.Desbloquear_Controle(Me, True)
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