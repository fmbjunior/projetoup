Public Class FolhaPgtoValeFuncionario

    Dim A��o As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Private Sub FolhaPgtoValeFuncionario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()
        A��o.Desbloquear_Controle(Me, False)
    End Sub

    Private Sub NovoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click
        A��o.LimpaTextBox(Me)
        A��o.Desbloquear_Controle(Me, True)
        Me.Id.Text = "0000"
        Me.Display.Image = Me.SemFoto.Image
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
        ElseIf Me.DataLancamento.Text = "" Then
            MsgBox("A Data de lan�amento n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.DataLancamento.Focus()
            Exit Sub
        ElseIf Me.DataQuitar.Text = "" Then
            MsgBox("A Data de Quita��o do d�bito n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.DataQuitar.Focus()
            Exit Sub
        ElseIf Me.ModuloDescontar.Text = "" Then
            MsgBox("O modulo de Quita��o do d�bito n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.ModuloDescontar.Focus()
            Exit Sub
        ElseIf Me.ValorLancamento.Text = "" Then
            MsgBox("O Valor do Lan�amento n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.ValorLancamento.Focus()
            Exit Sub
        ElseIf Me.Evento.Text = "" Then
            MsgBox("O evento n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Evento.Focus()
            Exit Sub
        ElseIf Me.Debito.Text = "" Then
            MsgBox("A conta de D�bito n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Evento.Focus()
            Exit Sub
        ElseIf Me.Credito.Text = "" Then
            MsgBox("A conta de Cr�dito n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Evento.Focus()
            Exit Sub
        ElseIf Me.Usuario.Text = "" Then
            MsgBox("A conta de Cr�dito n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Evento.Focus()
            Exit Sub
        ElseIf Me.EventoDesc.Text = "" Then
            MsgBox("A descri��o do evento n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Evento.Focus()
            Exit Sub

        End If

        If Me.CompetenciaDesconto.Text = "" Then
            If Me.ModuloDescontar.Text = "Mensalistas" Then
                MsgBox("A Compet�ncia para Quita��o do d�bito n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
                Me.DataQuitar.Focus()
                Exit Sub
            End If
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            UltimoReg()
            Dim Sql As String = "INSERT INTO FolhaPgtoValeFuncionarios (Id, DataLancamento, DataQuitar, CompetenciaDesconto, ModuloDescontar, ValorLancamento, Funcionario, Evento, LancadoFolha, Confirmado, Debito, Credito, Empresa, Usuario, EventoDesc) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Id.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataLancamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataQuitar.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.CompetenciaDesconto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.ModuloDescontar.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.ValorLancamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Funcionario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Evento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.LancadoFolha.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Me.Confirmado.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Debito.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.Credito.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.Usuario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.EventoDesc.Text, 1)))

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

            Dim Sql As String = "Update FolhaPgtoValeFuncionarios set Id = @1, DataLancamento = @2, DataQuitar = @3, CompetenciaDesconto = @4, ModuloDescontar = @5, ValorLancamento = @6, Funcionario = @7, Evento = @8, LancadoFolha = @9, Confirmado = @10, Debito = @11, Credito = @12, Empresa = @13, Usuario = @14, EventoDesc = @15 Where Id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Id.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataLancamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataQuitar.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.CompetenciaDesconto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.ModuloDescontar.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.ValorLancamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Funcionario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Evento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.LancadoFolha.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Me.Confirmado.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Debito.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.Credito.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.Usuario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.EventoDesc.Text, 1)))

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
            .CommandText = "Select max(Id) from FolhaPgtoValeFuncionarios"
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

    Private Sub DataLancamento_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataLancamento.Enter
        If Me.DataLancamento.Text = "" Then
            Me.DataLancamento.Text = DataDia
        End If
    End Sub

    Private Sub TipoGeradorBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoGeradorBT.Click
        Dim X As New Point(27, 0)
        Me.MenuTipoGerador.Show(Me.TipoGeradorBT, X)
    End Sub

    Private Sub MensalistasMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MensalistasMenu.Click, FeriasMenu.Click, DecimoParcela2Menu.Click, PgtoPISMenu.Click, Recis�oMenu.Click, DecimoParcela1menu.Click
        Me.ModuloDescontar.Text = sender.ToString
        If Me.ModuloDescontar.Text <> "Mensalistas" Then
            Me.CompetenciaDesconto.Clear()
        Else
            If Me.CompetenciaDesconto.Text = "" Then
                Me.CompetenciaDesconto.Text = Mid(Format(CDate(Me.DataQuitar.Text), "dd/MM/yyyy"), 4, 7)
            End If
        End If
    End Sub

    Private Sub ValorLancamento_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorLancamento.Leave
        If Me.LancadoFolha.Text = "" Then
            Me.LancadoFolha.Text = "N"
        End If
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
            Me.Profiss�o.Text = DR.Item("Descri��o") & ""
            Me.DataAdmiss�o.Text = DR.Item("DataAdmiss�o") & ""
            Me.CodPlanoContas.Text = DR.Item("CodPlanoContas") & ""
            If Me.Debito.Text = "00000000000000" Then Me.Debito.Text = Me.CodPlanoContas.Text
            If Me.Credito.Text = "00000000000000" Then Me.Credito.Text = Me.CodPlanoContas.Text

            If Not IsDBNull(DR.Item("Foto")) Then
                Dim ByteData() As Byte = DR.Item("Foto") 'stream em mem�ria recebe a imagem
                Dim ImgVer As New IO.MemoryStream(ByteData)
                Me.Display.Visible = True
                Me.Display.Image = Image.FromStream(ImgVer)
            Else
                Me.Display.Image = Me.SemFoto.Image
            End If
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
            If Me.EventoDesc.Text = "" Then Me.EventoDesc.Text = DR.Item("Descri��o") & ""
            If Me.Debito.Text = "" Then Me.Debito.Text = DR.Item("Debito") & ""
            If Me.Credito.Text = "" Then Me.Credito.Text = DR.Item("Credito") & ""
        End If
        DR.Close()
        CNN.Close()
    End Sub

    Private Sub Usuario_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Usuario.Enter
        If Me.Usuario.Text = "" Then
            Me.Usuario.Text = UserAtivo
        End If
    End Sub

    Private Sub ExcluirBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirBT.Click
        MsgBox("Op��o Indisponivel")
    End Sub

    Private Sub LocalizarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizarBT.Click
        A��o.Desbloquear_Controle(Me, False)
        ChamaTelaProcura("Codigo", "Descri��o", "Valor", "FolhaPgtoValeFuncionarios", "Id", "EventoDesc", "ValorLancamento", True)

        Me.Id.Text = RetornoProcura
        If Me.Id.Text <> "" Then
            LocalizaDados()
            Me.DataLancamento.Focus()
        End If
    End Sub

    Private Sub ImprimirConfirmarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirConfirmarBT.Click
        If MsgBox("Deseja confirmar e imprimir o vale do Funcion�rio", 36, "Valida��o de Dados") = 6 Then

            'Fazer lancameto de D�bito e Cr�dito no Plano de contas

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

            CNN.Open()

            Dim Sql As String
            Dim Ultimo As Integer = 0
            Dim CompSql As String = ""

            Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
            Dim DR As OleDb.OleDbDataReader
            Dim cmd As OleDb.OleDbCommand = CNN.CreateCommand
            cmd.Transaction = Transacao

            Try

                cmd.CommandText = "SELECT Max(" & AnoContabel & ".Id) AS M�xDeId FROM " & AnoContabel & ";"
                DR = cmd.ExecuteReader

                DR.Read()
                If DR.HasRows Then
                    Ultimo = DR.Item("M�xDeId")
                End If
                Ultimo += 1
                DR.Close()

                CompSql = Ultimo & ", #" & Format(CDate(Me.DataLancamento.Text), "MM/dd/yyyy") & "#, '" & Me.Debito.Text & "', '" & Me.Credito.Text _
                          & "', " & Me.Id.Text & ", #" & Format(CDate(Me.DataLancamento.Text), "MM/dd/yyyy") & "#, '" & CDbl(Me.ValorLancamento.Text) & "', '" & 0 & "', " & "'" & Me.EventoDesc.Text & " Func: " & Me.FuncionarioDesc.Text & "'" _
                          & ", " & CodEmpresa & ", " & "'ValeFunc'" & ", " & Ultimo & ", " & Me.Id.Text & ", " & 0

                Sql = "INSERT INTO " & AnoContabel & " ( Id, DataLancamento, PlanoContas, ContraPartida, Documento, DataDocumento, ValorDebito, ValorCredito, Historico, Empresa, IdLancamento, IdProcura, IdOrigem, NotaFiscal) VALUES (" & CompSql & ")"
                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()


                CompSql = (Ultimo + 1) & ", #" & Format(CDate(Me.DataLancamento.Text), "MM/dd/yyyy") & "#, '" & Me.Credito.Text & "', '" & Me.Debito.Text _
                                          & "', " & Me.Id.Text & ", #" & Format(CDate(Me.DataLancamento.Text), "MM/dd/yyyy") & "#, " & 0 & ", '" & CDbl(Me.ValorLancamento.Text) & "', " & "'" & Me.EventoDesc.Text & " Func: " & Me.FuncionarioDesc.Text & "'" _
                                          & ", " & CodEmpresa & ", " & "'ValeFunc'" & ", " & Ultimo & ", " & Me.Id.Text & ", " & 0


                Sql = "INSERT INTO " & AnoContabel & " ( Id, DataLancamento, PlanoContas, ContraPartida, Documento, DataDocumento, ValorDebito, ValorCredito, Historico, Empresa, IdLancamento, IdProcura, IdOrigem, NotaFiscal) VALUES (" & CompSql & ")"
                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()

                Transacao.Commit()

                Me.Confirmado.Checked = True
                Me.LancadoFolha.Text = "N"
                SalvarBT_Click(sender, e)

                CNN.Close()

            Catch ex As Exception
                Transacao.Rollback()
                CNN.Close()
                MsgBox(ex.Message, 64, "Valida��o de Dados")
                MsgBox("Erro ao fazer lancamentos do vale, tente confirmar novamente ou consulte o administrador.", 64, "Valida��o de Dados")
                Exit Sub
            End Try

            'fim

            RelatorioCarregar = "RelValeFuncionario"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If
    End Sub

    Public Sub LocalizaDados()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT FolhaPgtoValeFuncionarios.Id, FolhaPgtoValeFuncionarios.DataLancamento, FolhaPgtoValeFuncionarios.DataQuitar, FolhaPgtoValeFuncionarios.CompetenciaDesconto, FolhaPgtoValeFuncionarios.ModuloDescontar, FolhaPgtoValeFuncionarios.ValorLancamento, FolhaPgtoValeFuncionarios.Funcionario, Funcion�rios.Nome, Funcion�rios.Foto, Funcion�rios.DataAdmiss�o, Profissao.Descri��o, Funcion�rios.CodPlanoContas, FolhaPgtoValeFuncionarios.Evento, FolhaPgtoValeFuncionarios.EventoDesc, FolhaPgtoValeFuncionarios.LancadoFolha, FolhaPgtoValeFuncionarios.Confirmado, FolhaPgtoValeFuncionarios.Debito, FolhaPgtoValeFuncionarios.Credito, FolhaPgtoValeFuncionarios.Empresa, FolhaPgtoValeFuncionarios.Inativo, FolhaPgtoValeFuncionarios.Usuario FROM (FolhaPgtoValeFuncionarios INNER JOIN Funcion�rios ON FolhaPgtoValeFuncionarios.Funcionario = Funcion�rios.C�digoFuncion�rio) INNER JOIN Profissao ON Funcion�rios.Profiss�o = Profissao.Codigo WHERE (((FolhaPgtoValeFuncionarios.Id)=" & Me.Id.Text & "));"


        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then

            Me.Id.Text = DR.Item("id") & ""
            Me.DataLancamento.Text = DR.Item("DataLancamento") & ""
            Me.DataQuitar.Text = DR.Item("DataQuitar") & ""
            Me.CompetenciaDesconto.Text = DR.Item("CompetenciaDesconto") & ""
            Me.ModuloDescontar.Text = DR.Item("ModuloDescontar") & ""
            Me.ValorLancamento.Text = DR.Item("ValorLancamento") & ""
            Me.Funcionario.Text = DR.Item("Funcionario") & ""
            Me.FuncionarioDesc.Text = DR.Item("Nome") & ""
            Me.DataAdmiss�o.Text = DR.Item("DataAdmiss�o") & ""
            Me.CodPlanoContas.Text = DR.Item("CodPlanoContas") & ""
            Me.Profiss�o.Text = DR.Item("Descri��o") & ""
            Me.Evento.Text = DR.Item("Evento") & ""
            Me.LancadoFolha.Text = DR.Item("LancadoFolha") & ""
            Me.Confirmado.Checked = DR.Item("Confirmado") & ""
            Me.Debito.Text = DR.Item("Debito") & ""
            Me.Credito.Text = DR.Item("Credito") & ""
            Me.Usuario.Text = DR.Item("Usuario") & ""
            Me.EventoDesc.Text = DR.Item("EventoDesc") & ""

            If Not IsDBNull(DR.Item("Foto")) Then
                Dim ByteData() As Byte = DR.Item("Foto") 'stream em mem�ria recebe a imagem
                Dim ImgVer As New IO.MemoryStream(ByteData)
                Me.Display.Visible = True
                Me.Display.Image = Image.FromStream(ImgVer)
            Else
                Me.Display.Image = Me.SemFoto.Image
            End If

            If Me.Confirmado.Checked = True Then
                MsgBox("Este vale ja foi confirmado n�o pode mais ser alterado.", 64, "Valida��o de Dados")
                A��o.Desbloquear_Controle(Me, False)
            Else
                A��o.Desbloquear_Controle(Me, True)
            End If
        End If

        Operation = UPD
        DR.Close()
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