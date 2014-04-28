Public Class Contrato

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Dim Autorizado As Boolean
    Dim AlterarContrato As Boolean = False

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)

        Dim I As Integer
        For I = 0 To Me.Lista.Rows.Count - 1
            Me.Lista.Rows.RemoveAt(0)
        Next

        Me.CodContrato.Enabled = False
        Me.CodContrato.Text = "000000"
        Me.Cliente.Focus()
        Operation = INS

        'bloquear textbox
        Me.txtSaldo.Enabled = False
        Me.txtTotalDespesas.Enabled = False
        Me.txtTotalProdutos.Enabled = False

    End Sub

    Private Sub btEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEditar.Click
        If Me.CodContrato.Text = "" Then
            MsgBox("Não existe Contrato para ser editado.", 64, "Validação de Dados")
            Exit Sub
        End If
        If Me.CodContrato.Text = "000000" Then
            MsgBox("Não existe Contrato para ser editado.", 64, "Validação de Dados")
            Exit Sub
        End If
        Operation = UPD
        Ação.Desbloquear_Controle(Me, True)
        Me.CodContrato.Enabled = False
        Me.Cliente.Focus()
    End Sub

    Private Function VerificarClienteTemContrato() As Boolean

        Dim Ret As Boolean = False

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()
        Dim Sql As String = "SELECT Contratos.*, Clientes.Nome, Contratos.CodContrato FROM (Contratos LEFT JOIN Clientes ON Contratos.Cliente = Clientes.Codigo) WHERE (((Contratos.Cliente)=" & Me.Cliente.Text & ")) and Contratos.Finalizado = 'N';"
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Ret = True
        Else
            Ret = False
        End If
        Cnn.Close()

        Return Ret

    End Function

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        'Area destinada para as validacoes
        If Me.CodContrato.Text = "" Then
            MsgBox("O Código do Contrato não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.CodContrato.Focus()
            Exit Sub
        ElseIf Me.Cliente.Text = "" Then
            MsgBox("O  Cliente do Contrato não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Cliente.Focus()
            Exit Sub
        End If

        If Not AlterarContrato Then
            Dim TemContratoPendente As Boolean = VerificarClienteTemContrato()

            If TemContratoPendente = True Then
                If MessageBox.Show("Este Cliente ja tem um Contrato pendente registrado, deseja criar outro Contrato ?", "Validação de Dados", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Cancel Then
                    Ação.LimpaTextBox(Me)
                    Ação.Desbloquear_Controle(Me, True)

                    Dim I As Integer
                    For I = 0 To Me.Lista.Rows.Count - 1
                        Me.Lista.Rows.RemoveAt(0)
                    Next

                    Me.CodContrato.Enabled = False
                    Me.CodContrato.Text = "000000"
                    Me.Cliente.Focus()
                    Operation = INS
                    Exit Sub
                End If
            End If
        End If 'fim alterarcontrato
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Me.Finalizado.Text = "" Then Me.Finalizado.Text = "N"
        If Operation = INS Then
            CNN.Open()

            UltimoReg()
            Dim Sql As String = "INSERT INTO Contratos (CodContrato, Cliente, ValorContrato, DataContrato, OBS, Finalizado, Empresa, ContaBalancete) VALUES (@1, @2, @3, @4, @5, @6, @7, @8)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CodContrato.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Cliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.ValorContrato.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataContrato.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.OBS.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Finalizado.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.ContaBalancete.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                GerarParcelamento()
                EncheListaReceber()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                Operation = UPD
                GerarLog(Me.Text, AçãoTP.Adicionou, Me.CodContrato.Text)

            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            Ação.Desbloquear_Controle(Me, False)


        ElseIf Operation = UPD Then
            CNN.Open()
            Dim transacao As OleDb.OleDbTransaction = CNN.BeginTransaction

            Dim Sql As String = "Update Contratos set Obs = @1, Finalizado = @2,valorcontrato=@3 Where CodContrato = '" & Me.CodContrato.Text & "'"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN, transacao)


            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.OBS.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Finalizado.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Convert.ToDouble(Me.ValorContrato.Text)))

            Try
                cmd.ExecuteNonQuery()

                If AlterarContrato Then
                    Dim cmd1 As New OleDb.OleDbCommand()
                    Dim dValorC As Double = 0
                    Dim dDif As Double = 0

                    cmd1.CommandText = "Select ValorDocumento From Receber where OriginalParcial='O' and documento='" & CodContrato.Text & "-C" & "'"
                    cmd1.Connection = CNN
                    cmd1.Transaction = transacao
                    dValorC = cmd1.ExecuteScalar
                    dDif = Convert.ToDouble(Me.ValorContrato.Text) - dValorC


                    cmd1.CommandText = "Update Receber Set ValorDocumento=ValorDocumento +" & dDif & " where documento='" & CodContrato.Text & "-C" & "'"
                    cmd1.ExecuteNonQuery()


                End If
                transacao.Commit()
                EncheListaReceber()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Editou, Me.CodContrato.Text)
                CNN.Close()
                Operation = UPD
            Catch x As Exception
                transacao.Rollback()
            End Try
            Ação.Desbloquear_Controle(Me, False)

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
            .CommandText = "Select max(CodContrato) from Contratos"
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

        Dim vlr As String = CInt(Ult) + 1
        Me.CodContrato.Text = vlr.PadLeft(6, "0")
        Me.Cliente.Focus()
        'fim inserir ultimo registro

    End Sub

    Private Sub Cliente_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Cliente.Validating
        If String.CompareOrdinal(Me.Cliente.Text, Me.Cliente.TextoAntigo) Then
            AchaCliente()
        End If
    End Sub

    Private Sub AchaCliente()

        If Me.Cliente.Text = "" Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()
        'String para filtragem de clientes na base de dados
        Dim Sql As String = "SELECT Clientes.* FROM Clientes WHERE Clientes.Empresa = " & CodEmpresa & " AND Clientes.Codigo = " & Me.Cliente.Text


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

    Private Sub btFindCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindCliente.Click
        Me.Cliente.Clear()
        Me.ClienteDesc.Clear()
        My.Forms.ClientesProcura.ShowDialog()
        Me.Cliente.Focus()
    End Sub

    Private Sub Cliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cliente.KeyDown
        If e.KeyCode = Keys.F5 Then
            Me.Cliente.Clear()
            Me.ClienteDesc.Clear()
            My.Forms.ClientesProcura.ShowDialog()
            Me.Cliente.Focus()
        End If
    End Sub

    Public Sub AchaContaCR(ByVal Conta As String, ByVal CampoParaRetornar As Control)

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()
        Dim Sql As String = "Select * from ContasCR2 where CR2 = '" & Conta & "' And Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            CampoParaRetornar.Text = DR.Item("DescCr2") & ""
        Else
            CampoParaRetornar.Text = ""
            Exit Sub
        End If
        Cnn.Close()
    End Sub

    Private Sub btFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFinalizar.Click
        If Me.CodContrato.Text = "" Then
            MsgBox("O Código do Contrato não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.CodContrato.Focus()
            Exit Sub
        End If

        If Me.Finalizado.Text.Equals("S") Then
            MessageBox.Show("Este contrato já foi finalizado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MsgBox("Deseja realmente finalizar o contrato." & Chr(13) & Chr(13) & "Se fechar o Contrato, o usuário não podera mais fazer pedido para este contrato", 36, "Validação de Dados") = 6 Then

            If Operation = INS Then
                MessageBox.Show("O Contrato deve estar no modo de edição, favor verificar...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ErroLivre = "Contrato finalizado com sucesso"
            GerarLog(Me.Text, AçãoTP.Livre, Me.CodContrato.Text)
            Me.Finalizado.Text = "S"

            'Area destinada para as validacoes
            If Me.CodContrato.Text = "" Then
                MsgBox("O Código do Contrato não foi informado, favor verificar.", 64, "Validação de Dados")
                Me.CodContrato.Focus()
                Exit Sub
            ElseIf Me.Cliente.Text = "" Then
                MsgBox("O  Cliente do Contrato não foi informado, favor verificar.", 64, "Validação de Dados")
                Me.Cliente.Focus()
                Exit Sub
            End If

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "Update Contratos set Finalizado = @1 Where CodContrato = '" & Me.CodContrato.Text & "'"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Finalizado.Text, 1)))

            Try
                cmd.ExecuteNonQuery()

                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")

                CNN.Close()
                GerarLog(Me.Text, AçãoTP.Editou, Me.CodContrato.Text)
            Catch x As Exception
                'MsgBox(x.Message)
                'Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, False)
        End If

    End Sub

    Private Sub btLocalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLocalizar.Click
        My.Forms.ContratoProcura.ShowDialog()
        AcharContrato()
        Ação.Desbloquear_Controle(Me, False)
        ProdutosDespesas()
    End Sub

    Private Sub Contrato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ação.Desbloquear_Controle(Me, False)
    End Sub
    Private Sub ProdutosDespesas()
        Try
            Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            Cnn.Open()
            Dim CMD As OleDb.OleDbCommand


            Dim vlrP As Double = 0
            Dim vlrD As Double = 0

            Dim sql = "SELECT  Sum(ItensPedido.TotalProduto) AS SomaDeTotalProduto FROM Contratos INNER JOIN (Pedido INNER JOIN ItensPedido ON Pedido.PedidoSequencia = ItensPedido.PedidoSequencia) ON Contratos.CodContrato = Pedido.Contrato GROUP BY Contratos.CodContrato HAVING Contratos.CodContrato like '" & Me.CodContrato.Text & "'"
            Dim sqlD = "SELECT Sum(CompraCtrlPedido.ValorPedido) AS SomaDeValorPedido FROM Contratos INNER JOIN CompraCtrlPedido ON Contratos.CodContrato = CompraCtrlPedido.Contrato GROUP BY Contratos.CodContrato HAVING Contratos.CodContrato like '" & Me.CodContrato.Text & "'"

            CMD = New OleDb.OleDbCommand(sql, Cnn)

            If IsDBNull(CMD.ExecuteScalar) Then
                vlrP = 0
            Else
                vlrP = CMD.ExecuteScalar
            End If

            CMD.CommandText = sqlD
            CMD.Connection = Cnn

            If IsDBNull(CMD.ExecuteScalar) Then
                vlrD = 0
            Else
                vlrD = CMD.ExecuteScalar
            End If
            Me.txtTotalProdutos.Text = FormatNumber(vlrP, 2)
            Me.txtTotalDespesas.Text = FormatNumber(vlrD, 2)
            Me.txtSaldo.Text = FormatNumber(Convert.ToDouble(Me.ValorContrato.Text) - (vlrP + vlrD), 2)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
       


    End Sub
    Private Sub AcharContrato()
        If Me.CodContrato.Text = "" Then
            Exit Sub
        End If

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()
        Dim Sql As String = "SELECT Contratos.*, Clientes.Nome, Contratos.CodContrato FROM (Contratos LEFT JOIN Clientes ON Contratos.Cliente = Clientes.Codigo) WHERE (((Contratos.CodContrato)='" & Me.CodContrato.Text & "'));"
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.Cliente.Text = DR.Item("Cliente")
            Me.ClienteDesc.Text = DR.Item("Nome")
            Me.ValorContrato.Text = DR.Item("ValorContrato")
            Me.DataContrato.Text = DR.Item("DataContrato")
            Me.ContaBalancete.Text = DR.Item("ContaBalancete")
            Me.OBS.Text = DR.Item("OBS") & ""
            Me.Finalizado.Text = DR.Item("Finalizado")

            AchaContaBalancete()
            Operation = UPD

        Else
            MessageBox.Show("Contrato não encontrado, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CodContrato.Clear()
            Exit Sub
        End If
        Cnn.Close()
        EncheListaReceber()
    End Sub

    Private Sub GerarParcelamento()
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim ds As New DataSet()

        Dim Sqlstr As String = String.Empty
        Sqlstr = "SELECT * from Receber Where Documento  = '" & Me.CodContrato.Text & "-C'"

        Dim DAReceber As New OleDb.OleDbDataAdapter(Sqlstr, Cnn)

        DAReceber.Fill(ds, "Receber")
        If ds.Tables("Receber").Rows.Count = 0 Then

            Dim TBL As DataTable
            TBL = ds.Tables("Receber")

            Dim DRnovo As DataRow
            DRnovo = TBL.NewRow()
            DRnovo("Documento") = Me.CodContrato.Text & "-C"
            DRnovo("DataDocumento") = Me.DataContrato.Text
            DRnovo("ValorDocumento") = CDbl(Me.ValorContrato.Text)
            DRnovo("ValorLiquido") = CDbl(0)
            DRnovo("LocalPgto") = "CARTEIRA"
            DRnovo("PedidoProdutos") = 0
            DRnovo("CodCliente") = Me.Cliente.Text
            DRnovo("Cliente") = Me.ClienteDesc.Text
            DRnovo("Empresa") = CodEmpresa
            DRnovo("OriginalParcial") = "O"
            DRnovo("Vencimento") = CDate(Me.DataContrato.Text).AddDays(30)
            DRnovo("Recebimento") = System.DBNull.Value
            DRnovo("Baixado") = False
            DRnovo("ContaValorBaixado") = Me.ContaBalancete.Text
            DRnovo("ContaCr") = "000000"
            DRnovo("PercentComissao") = 0
            DRnovo("Virtual") = False
            DRnovo("CodigoContrato") = Me.CodContrato.Text
            TBL.Rows.Add(DRnovo)

        End If
        Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAReceber)
        DAReceber.Update(ds, "Receber")

        ds.Dispose()

        Cnn.Close()

    End Sub

    Private Sub ContaBalancete_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContaBalancete.Leave
        If String.CompareOrdinal(Me.ContaBalancete.Text, Me.ContaBalancete.TextoAntigo) Then
            AchaContaBalancete()
        End If
    End Sub

    Private Sub ContaBalancete_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ContaBalancete.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.BalanceteContasProcura.TipoConta = "C"
            My.Forms.BalanceteContasProcura.ShowDialog()
        End If
    End Sub

    Private Sub btFindContaLanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindContaLanc.Click

        My.Forms.BalanceteContasProcura.TipoConta = "C"
        My.Forms.BalanceteContasProcura.ShowDialog()
        AchaContaBalancete()
        Me.ContaBalancete.Focus()
    End Sub

    Public Sub AchaContaBalancete()

        Dim Cn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cn.Open()
        Dim Sql As String = "Select * from ContasG3 where ContaGrupo3 = '" & Me.ContaBalancete.Text & "' And Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, Cn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.ContaBalanceteDesc.Text = DR.Item("DescContaGrupo3") & ""
        End If
        Cn.Close()
    End Sub


    Private Sub EncheListaReceber()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty


        Sql = "SELECT Receber.Documento, Receber.ValorDocumento, Receber.ValorLiquido, Receber.Vencimento, Receber.Recebimento FROM(Receber) WHERE (((Receber.Documento)= '" & Me.CodContrato.Text & "-C')) order by receber.Id"


        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Recebido.Text = FormatNumber(NzZero(ds.Tables("Table").Compute("sum(ValorLiquido)", "")), 2)
        Me.Lista.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        Cnn.Close()

    End Sub


    Private Sub btExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExcluir.Click
        If Me.Finalizado.Text.Equals("S") Then
            MessageBox.Show("Este contrato já foi finalizado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Me.CodContrato.Text = "" Then Exit Sub

        Autorizado = PedirPermissao(Me.Text, Me.CodContrato.Text)
        Autorizado = varAutorizado
        If Autorizado = False Then
            Exit Sub
        End If



        If Autorizado = False Then
            Exit Sub
        End If


        If Me.Finalizado.Text = "S" Then
            MessageBox.Show("O contrato já foi finalizado, não pode ser excluido", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If CDbl(NzZero(Me.Recebido.Text)) > CDbl(0) Then
            MessageBox.Show("Existe recebimento feito neste contrato, o contrato não pode ser excluido", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If MessageBox.Show("Deseja realmente excluir o Contrato selecionado.", "Validação de Dados", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim ds As New DataSet
            Dim Sql As String = String.Empty

            Sql = "Select * from Contratos Where CodContrato = '" & Me.CodContrato.Text & "'"
            Dim DAContrato As New OleDb.OleDbDataAdapter(Sql, CNN)
            DAContrato.Fill(ds, "Contrato")

            Sql = "Select * from Pedido Where Contrato = '" & Me.CodContrato.Text & "'"
            Dim DAPedido As New OleDb.OleDbDataAdapter(Sql, CNN)
            DAPedido.Fill(ds, "Pedido")

            Sql = "SELECT Receber.Documento, Receber.ValorDocumento, Receber.ValorLiquido, Receber.Vencimento, Receber.Recebimento FROM(Receber) WHERE (((Receber.Documento)= '" & Me.CodContrato.Text & "-C')) order by receber.Id"
            Dim DAReceber As New OleDb.OleDbDataAdapter(Sql, CNN)
            DAReceber.Fill(ds, "Receber")


            Try
                If ds.Tables("Pedido").Rows.Count = 0 Then 'Se nao existir pedido com contrto entra e faz as exclusoes
                    If ds.Tables("Contrato").Rows.Count = 1 Then
                        ds.Tables("Contrato").Rows(0).Delete()

                        Sql = "Delete * FROM Receber WHERE Receber.Documento = '" & Me.CodContrato.Text & "-C'"
                        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)
                        cmd.ExecuteNonQuery()
                    End If

                    Dim objBuilder As New OleDb.OleDbCommandBuilder(DAContrato)
                    DAContrato.Update(ds, "Contrato")
                    MessageBox.Show("Registro Excluido com sucesso", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Ação.LimpaTextBox(Me)
                    Ação.Desbloquear_Controle(Me, True)

                    Dim I As Integer
                    For I = 0 To Me.Lista.Rows.Count - 1
                        Me.Lista.Rows.RemoveAt(0)
                    Next

                    Me.CodContrato.Enabled = False
                    Me.CodContrato.Text = "000000"
                    Me.Cliente.Focus()
                    Operation = INS
                    CNN.Close()
                Else
                    MessageBox.Show("Existe pedido feito para este contrato, o contrato não pode ser excluido", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ds.Dispose()
                    CNN.Close()
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                CNN.Close()
                Exit Sub
            End Try

        End If


    End Sub


    Private Sub Cliente_TextChanged(sender As Object, e As EventArgs) Handles Cliente.TextChanged

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click

        Autorizado = PedirPermissao(Me.Text, Me.CodContrato.Text)
        Autorizado = varAutorizado
        If Autorizado = False Then
            Exit Sub
        End If



        If String.IsNullOrEmpty(CodContrato.Text) Or Me.CodContrato.Text.Equals("000000") Or Me.Finalizado.Text.Equals("S") Then
            Exit Sub
        End If

        Me.ValorContrato.Enabled = True
        Me.OBS.Enabled = True
        AlterarContrato = True
    End Sub

    Private Sub ValorContrato_Leave(sender As Object, e As EventArgs) Handles ValorContrato.Leave
        Me.ValorContrato.Enabled = False
    End Sub

    Private Sub btn_impExtrato_Click(sender As Object, e As EventArgs) Handles btn_impExtrato.Click
        Try
            RelatorioCarregar = "RelExtratoContrato.rpt"
            Dim strFormula As String = "{Receber.Documento}='" & Me.CodContrato.Text & "-C'"
            'chama a classe e passa os parametros para o relatorio
            Dim f As New ClassView.cView
            f.frm(DirRelat & RelatorioCarregar, LocalBD & Nome_BD, SenhaBancoDados, strFormula)


        Catch ex As Exception

        End Try

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Try
            RelatorioCarregar = "Contrato.rpt"
            Dim strFormula As String = "{Contratos.CodContrato}='" & Me.CodContrato.Text & "'"
            'chama a classe e passa os parametros para o relatorio
            Dim f As New ClassView.cView
            f.frm(DirRelat & RelatorioCarregar, LocalBD & Nome_BD, SenhaBancoDados, "Produtos  do Contrato", strFormula)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLancarDespContrato_Click(sender As Object, e As EventArgs) Handles btnLancarDespContrato.Click
        'passa o numero do contrato para a vareavel sContrato e carrega o form DocumentoEntrada 
        My.Forms.DocumentoEntrada.sContrato = Me.CodContrato.Text
        'chama o form 
        My.Forms.DocumentoEntrada.ShowDialog()

        'faz a atualização no campo de totalprodutos e totaldespesas
        ProdutosDespesas()

    End Sub
End Class