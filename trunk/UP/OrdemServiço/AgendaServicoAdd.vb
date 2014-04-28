Imports DevComponents.Schedule.Model

Public Class AgendaServicoAdd

    Dim Ação As New TrfGerais()


    Dim IdProcura As Integer
    Public Property Procurar As Integer
        Get
            Return IdProcura
        End Get
        Set(ByVal Value As Integer)
            IdProcura = Value
        End Set
    End Property


    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)
        Me.DataLancamento.Text = DataDia
        Me.Cliente.Focus()
    End Sub

    Private Sub btEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEditar.Click
        If Me.Id.Text = "" Then
            MsgBox("Não existe Agendamento para ser editado.", 64, "Validação de Dados")
            Exit Sub
        End If
        Me.Cliente.Enabled = True
        Me.ClienteDesc.Enabled = True
        Me.Compromisso.Enabled = True
        Me.DataAgenda.Enabled = True
        Me.DiasAntecipadoAvisar.Enabled = True
        Me.HorasCompromisso.Enabled = True
        Me.Usuario.Enabled = True
        Me.DataAgenda.Focus()

    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        If Me.AddTodos.Checked = True Then
            SalvarDadosTodos()
        Else
            SalvarDados()
        End If


    End Sub

    Private Sub SalvarDadosTodos()
        If Me.DataAgenda.Text = "" Then
            MessageBox.Show("Favor informar a data do Compromisso", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.DiasAntecipadoAvisar.Text = "" Then
            MessageBox.Show("Favor informar os dia antecipado para avisar", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.Compromisso.Text = "" Then
            MessageBox.Show("Favor informar o Compromisso", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.Cliente.Text = "" Then
            MessageBox.Show("Favor informar o Cliente", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.Usuario.Text = "" Then
            MessageBox.Show("Favor informar o Usuário para o agendamento", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Fim da Area destinada para as validacoes


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & "upAgendaDados.Mdb"))
        CNN.Open()


        Dim ds As New DataSet
        Dim Sql As String = String.Empty

        Sql = "SELECT * from AgendaServico where Id = " & CInt(NzZero(Me.Id.Text))
        Dim DAAgendaServico As New OleDb.OleDbDataAdapter(Sql, CNN)
        DAAgendaServico.Fill(ds, "AgendaServico")


        'Sql = "Select LoginUser.Login from LoginUser Where LoginUser.Empresa = " & CodEmpresa & " And LoginUser.Inativo = false Order by LoginUser.Login"
        'Dim da As New OleDb.OleDbDataAdapter(Sql, CNN)
        'da.Fill(ds, "LoginUser")

        If CDate(Me.DataAgenda.Text) < CDate(DataDia) Then
            MessageBox.Show("A data de Agendamento não pode ser menor que a data do dia Atual", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try

            For Each itm As Object In Me.Usuario.Items
               
                Dim DRnovo As DataRow
                DRnovo = ds.Tables("AgendaServico").NewRow

                DRnovo("Cliente") = Nz(Me.Cliente.Text, 1)
                DRnovo("ClienteDesc") = Nz(Me.ClienteDesc.Text, 1)
                DRnovo("DataLancamento") = Nz(Me.DataLancamento.Text, 1)
                DRnovo("Compromisso") = Nz(Me.Compromisso.Text, 1)
                DRnovo("DataAgenda") = Nz(Me.DataAgenda.Text, 1)
                DRnovo("DiasAntecipadoAvisar") = Nz(Me.DiasAntecipadoAvisar.Text, 1)
                DRnovo("HorasCompromisso") = IIf(IsDBNull(Me.HorasCompromisso.Text), "12:00:00", Me.HorasCompromisso.Text)
                Me.Status.Text = "AGENDADO"
                DRnovo("Status") = Nz(Me.Status.Text, 1)
                DRnovo("Usuario") = Nz(itm(0), 1)
                ds.Tables("AgendaServico").Rows.Add(DRnovo)

            Next


            Dim objBuilder As New OleDb.OleDbCommandBuilder(DAAgendaServico)
            DAAgendaServico.Update(ds, "AgendaServico")


            MessageBox.Show("Registros salvo com sucesso", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CNN.Close()
            Me.Close()
            Me.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
            CNN.Close()
            Exit Sub
        End Try

    End Sub


    Private Sub SalvarDados()
        If Me.DataAgenda.Text = "" Then
            MessageBox.Show("Favor informar a data do Compromisso", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.DiasAntecipadoAvisar.Text = "" Then
            MessageBox.Show("Favor informar os dia antecipado para avisar", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.Compromisso.Text = "" Then
            MessageBox.Show("Favor informar o Compromisso", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.Cliente.Text = "" Then
            MessageBox.Show("Favor informar o Cliente", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.Usuario.Text = "" Then
            MessageBox.Show("Favor informar o Usuário para o agendamento", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Fim da Area destinada para as validacoes


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & "upAgendaDados.Mdb"))
        CNN.Open()


        Dim ds As New DataSet
        Dim Sql As String = String.Empty

        Sql = "SELECT * from AgendaServico where Id = " & CInt(NzZero(Me.Id.Text))
        Dim DAAgendaServico As New OleDb.OleDbDataAdapter(Sql, CNN)
        DAAgendaServico.Fill(ds, "AgendaServico")

        Try
            If ds.Tables("AgendaServico").Rows.Count = 0 Then

                If CDate(Me.DataAgenda.Text) < CDate(DataDia) Then
                    MessageBox.Show("A data de Agendamento não pode ser menor que a data do dia Atual", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim DRnovo As DataRow
                DRnovo = ds.Tables("AgendaServico").NewRow

                DRnovo("Cliente") = Nz(Me.Cliente.Text, 1)
                DRnovo("ClienteDesc") = Nz(Me.ClienteDesc.Text, 1)
                DRnovo("DataLancamento") = Nz(Me.DataLancamento.Text, 1)
                DRnovo("Compromisso") = Nz(Me.Compromisso.Text, 1)
                DRnovo("DataAgenda") = Nz(Me.DataAgenda.Text, 1)
                DRnovo("DiasAntecipadoAvisar") = Nz(Me.DiasAntecipadoAvisar.Text, 1)
                DRnovo("HorasCompromisso") = IIf(IsDBNull(Me.HorasCompromisso.Text), "12:00:00", Me.HorasCompromisso.Text)
                Me.Status.Text = "AGENDADO"
                DRnovo("Status") = Nz(Me.Status.Text, 1)
                DRnovo("Usuario") = Nz(Me.Usuario.Text, 1)
                ds.Tables("AgendaServico").Rows.Add(DRnovo)

            Else
                ds.Tables("AgendaServico").Rows(0).BeginEdit()
                ds.Tables("AgendaServico").Rows(0)("Cliente") = Nz(Me.Cliente.Text, 1)
                ds.Tables("AgendaServico").Rows(0)("ClienteDesc") = Nz(Me.ClienteDesc.Text, 1)
                ds.Tables("AgendaServico").Rows(0)("DataLancamento") = Nz(Me.DataLancamento.Text, 1)
                ds.Tables("AgendaServico").Rows(0)("Compromisso") = Nz(Me.Compromisso.Text, 1)
                ds.Tables("AgendaServico").Rows(0)("DataAgenda") = Nz(Me.DataAgenda.Text, 1)
                ds.Tables("AgendaServico").Rows(0)("DiasAntecipadoAvisar") = Nz(Me.DiasAntecipadoAvisar.Text, 1)
                ds.Tables("AgendaServico").Rows(0)("HorasCompromisso") = IIf(IsDBNull(Me.HorasCompromisso.Text), "12:00:00", Me.HorasCompromisso.Text)
                ds.Tables("AgendaServico").Rows(0)("Status") = Nz(Me.Status.Text, 1)
                ds.Tables("AgendaServico").Rows(0)("Usuario") = Nz(Me.Usuario.Text, 1)
                ds.Tables("AgendaServico").Rows(0).EndEdit()
            End If


            Dim objBuilder As New OleDb.OleDbCommandBuilder(DAAgendaServico)
            DAAgendaServico.Update(ds, "AgendaServico")

            If Me.Id.Text = "" Then
                Dim cmd As New OleDb.OleDbCommand("SELECT @@IDENTITY", CNN)
                Me.Id.Text = cmd.ExecuteScalar()
            End If


            MessageBox.Show("Registro salvo com sucesso", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CNN.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
            CNN.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub btFindClintes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindClintes.Click
        My.Forms.ClientesProcura.ShowDialog()
        If Me.Cliente.Text <> "" Then
            LocalizaDadosCliente()
            Me.Cliente.Focus()
        End If
    End Sub

    Private Sub LocalizaDadosCliente()

        If Me.Cliente.Text = "" Then
            Exit Sub
        End If
        'String para filtragem de clientes na base de dados
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT Clientes.* FROM Clientes WHERE Clientes.Empresa =" & CodEmpresa & " and Clientes.Inativo = False AND Clientes.Codigo = " & Me.Cliente.Text


        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.ClienteDesc.Text = DR.Item("Nome") & ""
        End If

        DR.Close()
        CNN.Close()

    End Sub

    Private Sub Cliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cliente.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ClientesProcura.ShowDialog()
            If Me.Cliente.Text <> "" Then
                LocalizaDadosCliente()
                Me.Cliente.Focus()
            End If
        End If
    End Sub

    Private Sub Cliente_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cliente.Validated
        If String.CompareOrdinal(Me.Cliente.Text, Me.Cliente.TextoAntigo) Then
            LocalizaDadosCliente()
        End If
    End Sub

    Private Sub btCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelar.Click
        If Me.Id.Text = "" Then
            MsgBox("Não existe Agendamento para ser cancelado.", 64, "Validação de Dados")
            Exit Sub
        End If

        If MessageBox.Show("Deseja realmente cancelar o Agendamento", "Validação de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Me.Status.Text = "CANCELADO"
            SalvarDados()
        End If
    End Sub

    Private Sub AgendaServicoAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ação.Desbloquear_Controle(Me, False)
        ListaUsuarios()
        If IdProcura <> 0 Then
            AcharAgendamento(IdProcura)
        End If
    End Sub

    Private Sub ListaUsuarios()

        Try
            Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            Dim Sql As String = String.Empty

            Sql = "Select LoginUser.Login from LoginUser Where LoginUser.Empresa = " & CodEmpresa & " And LoginUser.Inativo = false Order by LoginUser.Login"

            Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
            Dim ds As New DataSet
            da.Fill(ds, "Table")

            Me.Usuario.DataSource = ds.Tables("Table").DefaultView
            Me.Usuario.DisplayMember = "Login"
            Me.Usuario.ValueMember = "Login"
            Me.Usuario.SelectedValue = -1

            da.Dispose()
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub AcharAgendamento(ByVal Var_Id As Integer)

        Ação.Desbloquear_Controle(Me, False)

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & "upAgendaDados.Mdb"))
        CNN.Open()


        Dim ds As New DataSet
        Dim Sql As String = String.Empty

        Sql = "SELECT * from AgendaServico where Id = " & CInt(Var_Id)
        Dim DAAgendaServico As New OleDb.OleDbDataAdapter(Sql, CNN)
        DAAgendaServico.Fill(ds, "AgendaServico")

        Try
            If ds.Tables("AgendaServico").Rows.Count = 1 Then
                Me.Id.Text = ds.Tables("AgendaServico").Rows(0)("Id")
                Me.Cliente.Text = ds.Tables("AgendaServico").Rows(0)("Cliente")
                Me.ClienteDesc.Text = ds.Tables("AgendaServico").Rows(0)("ClienteDesc")
                Me.DataLancamento.Text = ds.Tables("AgendaServico").Rows(0)("DataLancamento")
                Me.Compromisso.Text = ds.Tables("AgendaServico").Rows(0)("Compromisso")
                Me.DataAgenda.Text = ds.Tables("AgendaServico").Rows(0)("DataAgenda")
                Me.DiasAntecipadoAvisar.Text = ds.Tables("AgendaServico").Rows(0)("DiasAntecipadoAvisar")
                Me.HorasCompromisso.Text = IIf(IsDBNull(ds.Tables("AgendaServico").Rows(0)("HorasCompromisso")), "12:00:00", ds.Tables("AgendaServico").Rows(0)("HorasCompromisso"))
                Me.Status.Text = ds.Tables("AgendaServico").Rows(0)("Status")
                Me.Usuario.SelectedValue = ds.Tables("AgendaServico").Rows(0)("Usuario")
            End If
            CNN.Close()

            Me.Compromisso.Enabled = True
            Me.DataAgenda.Enabled = True
            Me.DiasAntecipadoAvisar.Enabled = True
            Me.HorasCompromisso.Enabled = True
            Me.DataAgenda.Focus()

        Catch ex As Exception
            MsgBox(ex.Message)
            CNN.Close()
            Exit Sub
        End Try


    End Sub

    Private Sub btEmAndamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEmAndamento.Click
        If Me.Id.Text = "" Then
            MsgBox("Não existe Agendamento para ser colocado em Andamento.", 64, "Validação de Dados")
            Exit Sub
        End If

        If MessageBox.Show("Deseja definir o Agendamento em Andamento", "Validação de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Me.Status.Text = "EM ANDAMENTO"
            SalvarDados()
        End If
    End Sub

    Private Sub btFinalizado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFinalizado.Click
        If Me.Id.Text = "" Then
            MsgBox("Não existe Agendamento para ser Fionalizado.", 64, "Validação de Dados")
            Exit Sub
        End If

        If MessageBox.Show("Deseja finalizar o Agendamento", "Validação de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Me.Status.Text = "FINALIZADO"
            SalvarDados()
        End If
    End Sub

    Private Sub HorasCompromisso_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HorasCompromisso.Leave

        If IsTime(Me.HorasCompromisso.Text) = False Then
            MessageBox.Show("Favor informar um horário Válido.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.HorasCompromisso.Focus()
            Exit Sub
        End If

        Me.HorasCompromisso.Text = FormatDateTime(Me.HorasCompromisso.Text, DateFormat.LongTime)
    End Sub

    Private Function IsTime(ByVal strHora As String) As Boolean
        Try
            Convert.ToDateTime(strHora)
            Return True
        Catch
            Return False
        End Try
    End Function
End Class