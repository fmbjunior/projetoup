Public Class DiaAbrirFechar

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btFecharCriar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFecharCriar.Click

        If Me.DiaAtual.Text = "" Then
            MessageBox.Show("O dia atual não foi informado, verifique.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.NovoDia.Text = "" Then
            MessageBox.Show("O novo dia não foi informado, verifique.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If CDate(Me.DiaAtual.Text) > CDate(Me.NovoDia.Text) Then
            MessageBox.Show("O novo dia não pode ser menor que o dia Atual, verifique.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim Sql As String = "SELECT CaixaDia.DataCaixaDia, CaixaDia.CaixaCod, CaixaDia.SaldoDiaAnterior, CaixaDia.SaldoDia, CaixaDia.Fechado, CaixaDia.Empresa FROM CaixaDia WHERE DataCaixaDia = #" & Format(CDate(Me.DiaAtual.Text), "MM/dd/yyyy") & "# And CaixaDia.Fechado = False"

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Transacao As OleDb.OleDbTransaction = Cnn.BeginTransaction()

        Dim CmdVER As OleDb.OleDbCommand = Cnn.CreateCommand
        Dim CmdAtual As OleDb.OleDbCommand = Cnn.CreateCommand
        Dim CmdNovo As OleDb.OleDbCommand = Cnn.CreateCommand

        CmdVER.Transaction = Transacao
        CmdAtual.Transaction = Transacao
        CmdNovo.Transaction = Transacao

        Try
            CmdVER.CommandText = Sql
            Dim DR As OleDb.OleDbDataReader

            DR = CmdVER.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                MessageBox.Show("Existe caixa aberto neste dia, o dia não pode ser finalizado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Transacao.Rollback()
                Cnn.Close()
                Me.Close()
                Me.Dispose()
                Exit Sub
            Else
                Sql = "UPDATE DiaTrabalho SET DiaTrabalho.Fechado = True WHERE DiaTrabalho.DiaTrabalho =#" & Format(CDate(Me.DiaAtual.Text), "MM/dd/yyyy") & "# AND DiaTrabalho.Empresa = " & CodEmpresa
                CmdAtual.CommandText = Sql
                CmdAtual.ExecuteNonQuery()

                Sql = "INSERT INTO DiaTrabalho ( DiaTrabalho, Fechado, Empresa ) Values (@1, @2, @3)"
                CmdNovo.CommandText = Sql

                CmdNovo.Parameters.Add(New OleDb.OleDbParameter("@1", Me.NovoDia.Text))
                CmdNovo.Parameters.Add(New OleDb.OleDbParameter("@2", False))
                CmdNovo.Parameters.Add(New OleDb.OleDbParameter("@3", CodEmpresa))
                CmdNovo.ExecuteNonQuery()

                Transacao.Commit()
                Cnn.Close()
                MessageBox.Show("Dia de Trabalho fechado com sucesso.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)


                ErroLivre = "Encerrado e Gerado Novo Dia para o Caixa com sucesso"
                GerarLog(Me.Text, AçãoTP.Livre, Me.DiaAtual.Text)

                End
            End If
        Catch ex As Exception
            Transacao.Rollback()
            Cnn.Close()
            MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End Try
    End Sub

    Private Sub DiaAbrirFechar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DiaAtual.Text = DataDia

        Dim Seg As Boolean
        Dim Ter As Boolean
        Dim Qua As Boolean
        Dim Qui As Boolean
        Dim Sex As Boolean
        Dim Sab As Boolean
        Dim Dom As Boolean

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Empresa where CódigoEmpresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Seg = DR.Item("Segunda")
            Ter = DR.Item("Terca")
            Qua = DR.Item("Quarta")
            Qui = DR.Item("Quinta")
            Sex = DR.Item("Sexta")
            Sab = DR.Item("Sabado")
            Dom = DR.Item("Domingo")
        End If

        DR.Close()
        CNN.Close()




        Dim DiaNovo As Date = DataDia.AddDays(1)

        If DiaNovo.DayOfWeek = DayOfWeek.Monday And Seg = False Then DiaNovo = DiaNovo.AddDays(1)
        If DiaNovo.DayOfWeek = DayOfWeek.Tuesday And Ter = False Then DiaNovo = DiaNovo.AddDays(1)
        If DiaNovo.DayOfWeek = DayOfWeek.Wednesday And Qua = False Then DiaNovo = DiaNovo.AddDays(1)
        If DiaNovo.DayOfWeek = DayOfWeek.Thursday And Qui = False Then DiaNovo = DiaNovo.AddDays(1)
        If DiaNovo.DayOfWeek = DayOfWeek.Friday And Sex = False Then DiaNovo = DiaNovo.AddDays(1)
        If DiaNovo.DayOfWeek = DayOfWeek.Saturday And Sab = False Then DiaNovo = DiaNovo.AddDays(1)
        If DiaNovo.DayOfWeek = DayOfWeek.Sunday And Dom = False Then DiaNovo = DiaNovo.AddDays(1)


        Me.NovoDia.Text = Format(CDate(DiaNovo), "dd/MM/yyyy")

    End Sub
End Class