Public Class ChequePreLancarAvulso

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ChequePreLancar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregaCadBancos()
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        If Me.BancoCheque.Text = "" Then
            MsgBox("O Banco que o cheque pertence não pode ser nulo", 64, "Validação de Dados")
            Me.BancoCheque.Focus()
            Exit Sub
        End If

        If Me.Cheque.Text = "" Then
            MsgBox("O numero do cheque não pode ser nulo", 64, "Validação de Dados")
            Me.Cheque.Focus()
            Exit Sub
        End If

        If Me.CC.Text = "" Then
            MsgBox("O numero da conta corrente não pode ser nulo", 64, "Validação de Dados")
            Me.CC.Focus()
            Exit Sub
        End If

        If Me.Titular.Text = "" Then
            MsgBox("O titular do cheque não pode ser nulo", 64, "Validação de Dados")
            Me.Titular.Focus()
            Exit Sub
        End If

        If Me.EntreguePor.Text = "" Then
            MsgBox("Por quem foi entregue o cheque não pode ser nulo", 64, "Validação de Dados")
            Me.EntreguePor.Focus()
            Exit Sub
        End If

        If Me.ValorCh.Text = "" Then
            MsgBox("O valor cheque não pode ser nulo", 64, "Validação de Dados")
            Me.ValorCh.Focus()
            Exit Sub
        End If

        If Me.Vencimento.Text = "" Then
            MsgBox("O vencimento do cheque não pode ser nulo", 64, "Validação de Dados")
            Me.Vencimento.Focus()
            Exit Sub
        End If


        'Cadastrar o cheque no controle de cheque


        UltimoReg()

        Dim Sql As String = String.Empty

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        'Verifica se o Cheque ja esta cadastrado na conta corrente
        Sql = "Select * From ArquivoCheque Where Cheque = '" & Me.Cheque.Text & "'  and CC = '" & Me.CC.Text & "'"
        Dim VerCheque As New OleDb.OleDbCommand(Sql, CNN)
        Dim Dr As OleDb.OleDbDataReader

        Dr = VerCheque.ExecuteReader
        Dr.Read()

        If Dr.HasRows Then
            MsgBox("Ja existe um cheque com este numero e esta conta, favor digitar um outro documento.", 64, "Validação de Dados")
            Exit Sub
        End If
        'Fim da verificão se o cheque existe

        Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
        Dim CmdCheque As OleDb.OleDbCommand = CNN.CreateCommand

        CmdCheque.Transaction = Transacao

        Try
            Sql = "INSERT INTO ArquivoCheque (Cheque, CC, BancoCheque, Titular, EntreguePor, ValorCh, Vencimento, Empresa, Historico, IdCodigo, Cliente) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11)"
            CmdCheque.CommandText = Sql

            CmdCheque.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Cheque.Text, 1)))
            CmdCheque.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.CC.Text, 1)))
            CmdCheque.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.BancoCheque.SelectedValue, 1)))
            CmdCheque.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Titular.Text, 1)))
            CmdCheque.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.EntreguePor.Text, 1)))
            CmdCheque.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.ValorCh.Text, 1)))
            CmdCheque.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Vencimento.Text, 1)))
            CmdCheque.Parameters.Add(New OleDb.OleDbParameter("@8", CodEmpresa))
            CmdCheque.Parameters.Add(New OleDb.OleDbParameter("@9", "CHEQUE-PRE"))
            CmdCheque.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.IdCodigo.Text, 3)))
            CmdCheque.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Cliente.Text, 3)))
            CmdCheque.ExecuteNonQuery()


            Transacao.Commit()

            MsgBox("Cheque adicionado com sucesso", 64, "Validação de Dados")
            CNN.Close()
            btNovo_Click(sender, e)

        Catch ex As Exception
            Transacao.Rollback()
            CNN.Close()
            MsgBox(ex.Message)
            Exit Sub
        End Try

        'Fim do cadastro no controle de cheque



    End Sub

    Public Sub UltimoReg()
        'Inserir ultimo registro
        Dim CnnDados As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CnnDados.Open()

        Dim Sql As String = "Select max(IdCodigo) from ArquivoCheque"

        Dim Cmd As New OleDb.OleDbCommand(Sql, CnnDados)
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer

        Try
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    Ult = DataReader.Item(0)
                End If
            End While
            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                CnnDados.Close()
                Exit Sub
            End If
        End Try

        Me.IdCodigo.Text = Ult + 1
        CnnDados.Close()

    End Sub

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        Me.Cheque.Clear()
        Me.CC.Clear()
        Me.BancoCheque.SelectedValue = 0
        Me.Titular.Clear()
        Me.EntreguePor.Clear()
        Me.ValorCh.Clear()
        Me.Vencimento.Clear()
        Ação.Desbloquear_Controle(Me, True)
        Operation = INS
        Me.Cheque.Focus()
    End Sub

    Private Sub ValorCh_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorCh.Validated
        If Me.ValorCh.Text = "" Then Me.ValorCh.Text = 0
        Me.ValorCh.Text = FormatCurrency(Me.ValorCh.Text, 3)
    End Sub

    Private Sub CarregaCadBancos()

        Dim CnnDados As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CnnDados.Open()

        Dim Ds As New DataSet
        Dim Sql As String = String.Empty

        Sql = "SELECT * from CadBancos"
        Dim DACadBancos As New OleDb.OleDbDataAdapter(Sql, CnnDados)
        DACadBancos.Fill(Ds, "CadBancos")

        Me.BancoCheque.DataSource = Ds.Tables("CadBancos")
        Me.BancoCheque.DisplayMember = "NomeBanco"
        Me.BancoCheque.ValueMember = "NomeBanco"
        Me.BancoCheque.SelectedValue = 0
        CnnDados.Close()

    End Sub

    Private Sub Cliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cliente.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ClientesProcura.ShowDialog()
        End If
    End Sub


    Public Sub LocalizaDadosCliente()
        If Me.Cliente.Text = "" Then
            Exit Sub
        End If

        Dim CnnDados As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CnnDados.Open()

        Dim Sql As String = "SELECT Clientes.* FROM Clientes Where Codigo = " & Me.Cliente.Text

        Dim CMD As New OleDb.OleDbCommand(Sql, CnnDados)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.ClienteDesc.Text = DR.Item("Nome") & ""
        End If
        DR.Close()
        CnnDados.Close()

    End Sub

    Private Sub Cliente_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cliente.Leave
        If String.CompareOrdinal(Me.Cliente.Text, Me.Cliente.TextoAntigo) Then
            LocalizaDadosCliente()
        End If
    End Sub
End Class