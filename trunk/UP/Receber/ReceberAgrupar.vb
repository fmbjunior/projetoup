Imports System.Data.OleDb

Public Class ReceberAgrupar

    Dim bs As New BindingSource
    Dim DaReceber As OleDb.OleDbDataAdapter
    Dim DsReceber As New DataSet

    Dim VZ As Boolean
    Public Property Visualizador() As Boolean
        Get
            Return VZ
        End Get
        Set(ByVal Value As Boolean)
            VZ = Value
        End Set
    End Property

    Dim idVZ As Integer
    Public Property IDVisualizador() As Integer
        Get
            Return idVZ
        End Get
        Set(ByVal Value As Integer)
            idVZ = Value
        End Set
    End Property


    Dim Ação As New TrfGerais


    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2
    Const CON As Byte = 3
    Const VAZ As Byte = 9


    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
            SendKeys.Send("{Tab}")
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function


    Private Sub btFechar_Click(sender As Object, e As EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ReceberAgrupar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, False)
        Operation = VAZ

        If VZ = True Then
            Operation = CON
            MostrarId()
        End If
    End Sub

    Private Sub MostrarId()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty
        Cnn.Open()

        Dim DS As New DataSet

        ' Sql = "Select * from ReceberAgrupar Where IdAgrupar = " & idVZ
        Sql = "SELECT Clientes.Nome, * FROM ReceberAgrupar INNER JOIN Clientes ON ReceberAgrupar.Cliente = Clientes.Codigo WHERE (((ReceberAgrupar.[IdAgrupar])=" & idVZ & "))"

        Dim daCab = New OleDb.OleDbDataAdapter(Sql, Cnn)
        daCab.Fill(DS, "Cab")

        If DS.Tables("Cab").Rows.Count = 1 Then
            Me.IdAgrupar.Text = DS.Tables("Cab").Rows(0)("IdAgrupar")
            Me.DataLancamento.Text = DS.Tables("Cab").Rows(0)("DataLancamento")
            Me.Descricao.Text = DS.Tables("Cab").Rows(0)("Descricao")
            Me.Cliente.Text = DS.Tables("Cab").Rows(0)("Cliente")
            Me.ClienteDesc.Text = DS.Tables("Cab").Rows(0)("Nome")
            Me.ValorAgrupado.Text = DS.Tables("Cab").Rows(0)("ValorAgrupado")
            Me.DiasParcelamento.Text = DS.Tables("Cab").Rows(0)("DiasParcelamento")
            Me.Confirmado.Checked = DS.Tables("Cab").Rows(0)("Confirmado")
        End If

        Sql = "SELECT id,documento,PedidoProdutos,valordocumento FROM Receber WHERE CodCliente = " & Me.Cliente.Text & " and Baixado = False and Empresa = " & CodEmpresa & " and Agrupada = true And IdAgrupamento = " & idVZ & " order by Vencimento"
        Dim DaAgrupados As New OleDb.OleDbDataAdapter(Sql, Cnn)
        DaAgrupados.Fill(DS, "Agrupados")

        Me.Lista.DataSource = DS.Tables("Agrupados").DefaultView

        For Each row As DataGridViewRow In Lista.Rows
            row.Cells("Selecao").Value = True
        Next row


        Sql = "SELECT  Id,Documento,ValorDocumento,Vencimento,LocalPgto,CodCliente FROM Receber WHERE Receber.IdAgrupamento = " & Me.IdAgrupar.Text & " AND Receber.OriginalParcial = 'O' And Agrupada = False ORDER BY Receber.Vencimento"
        Dim NovoReceber As New OleDb.OleDbDataAdapter(Sql, Cnn)
        NovoReceber.Fill(DS, "NovoReceber")

        Me.ListaReceber.DataSource = DS.Tables("NovoReceber").DefaultView

        Me.TotParcelado.Text = FormatNumber(NzZero(DS.Tables("NovoReceber").Compute("sum(ValorDocumento)", "")), 2)

        NovoReceber.Dispose()
        DaAgrupados.Dispose()
        daCab.Dispose()
        DS.Dispose()
        Cnn.Close()

    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)
        Me.IdAgrupar.Enabled = False
        Me.IdAgrupar.Text = "0000"
        Me.DataLancamento.Text = DataDia
        Me.ListaReceber.ReadOnly = False

        Dim I As Integer
        For I = 0 To Me.Lista.Rows.Count - 1
            Me.Lista.Rows.RemoveAt(0)
        Next
        Dim II As Integer
        For II = 0 To Me.ListaReceber.Rows.Count - 1
            Me.ListaReceber.Rows.RemoveAt(0)
        Next

        Operation = INS
        Me.Cliente.Focus()
    End Sub

    Private Sub btFindClintes_Click(sender As Object, e As EventArgs) Handles btFindClintes.Click
        If Operation <> INS Then Exit Sub

        Me.Cliente.Text = ""
        Me.ValorAgrupado.Text = FormatNumber(0, 2)
        If Me.Cliente.Text = "" Then
            RetornoProcura = ""
            My.Forms.ReceberCliProcura.ShowDialog()
            If Me.Cliente.Text <> "" Then
                Ação.Descrição_ItenRegistro(Me.Cliente, Me.ClienteDesc, "Clientes", "Codigo", Me.Cliente.Text, "Nome", TrfGerais.TipoDados.Numérico, True)
            End If
        End If
        Me.Cliente.Focus()
    End Sub

    Private Sub EncheLista()


        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty
        Cnn.Open()

        Dim DS As New DataSet

        Sql = "SELECT id,documento,PedidoProdutos,valordocumento FROM Receber WHERE CodCliente = " & Me.Cliente.Text & " and Baixado = False and Empresa = " & CodEmpresa & " and Inativo = False and CartaoCredito = False and  Virtual = False and IdAgrupamento is null order by Vencimento"
        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)

        da.Fill(DS, "Receber")

        Lista.DataSource = DS.Tables("Receber")

        da.Dispose()
        DS.Dispose()
        Cnn.Close()

    End Sub

    Private Sub Cliente_Leave(sender As Object, e As EventArgs) Handles Cliente.Leave
        If Me.Cliente.Text = "" Then
            Exit Sub
        End If
        EncheLista()
    End Sub

    Private Sub CalculaSelecionados(LinhaSelecionada As Integer)

        Dim Vlr As Double = 0
        For Each dr As DataGridViewRow In Me.Lista.Rows
            If Me.Lista.Rows(dr.Index).Cells("Selecao").Value = True Then
                Vlr += Me.Lista.Rows(dr.Index).Cells("cValorDocumento").Value
            End If
        Next dr
        Me.ValorAgrupado.Text = FormatNumber(Vlr, 2)

    End Sub

    Private Sub Lista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Lista.CellContentClick

        If e.RowIndex = Me.Lista.Rows.GetLastRow(DataGridViewElementStates.None) Then
            Me.Lista.CurrentCell = Me.Lista.Item(0, 0)
        Else
            Me.Lista.CurrentCell = Me.Lista.Item("Selecao", e.RowIndex + 1)
        End If

    End Sub


    Private Sub Lista_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Lista.CellEndEdit
        CalculaSelecionados(e.RowIndex)
    End Sub

    Private Sub Cliente_KeyDown(sender As Object, e As KeyEventArgs) Handles Cliente.KeyDown
        If e.KeyCode = Keys.F5 Then
            Me.Cliente.Text = ""
            Me.ValorAgrupado.Text = FormatNumber(0, 2)
            If Me.Cliente.Text = "" Then
                RetornoProcura = ""
                My.Forms.ReceberCliProcura.ShowDialog()
                If Me.Cliente.Text <> "" Then
                    Ação.Descrição_ItenRegistro(Me.Cliente, Me.ClienteDesc, "Clientes", "Codigo", Me.Cliente.Text, "Nome", TrfGerais.TipoDados.Numérico, True)
                End If
            End If
            Me.Cliente.Focus()
        End If
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        If Me.Confirmado.Checked = True Then
            MessageBox.Show("Este Agrupamento foi Confirmado e não pode ser alterado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        SalvarCab()
    End Sub

    Private Sub SalvarCab()

        If NzZero(Me.ValorAgrupado.Text) = 0 Then
            MsgBox("O Valor a ser agrupado não pode ser zero, favor verificar.", 64, "Validação de Dados")
            Exit Sub
        ElseIf Me.DataLancamento.Text = "" Then
            MsgBox("A data de Lancamento não pode ser nula, favor verificar.", 64, "Validação de Dados")
            Me.DataLancamento.Focus()
            Exit Sub
        ElseIf Me.Descricao.Text = "" Then
            MsgBox("A descrição não pode ser nula, favor verificar.", 64, "Validação de Dados")
            Me.Descricao.Focus()
            Exit Sub
        ElseIf Me.DiasParcelamento.Text = "" Then
            MsgBox("O parcelamento não pode ser nulo, favor verificar.", 64, "Validação de Dados")
            Me.DiasParcelamento.Focus()
            Exit Sub
        End If

        'Valida os dias de Parcelamento
        Try
            Dim Parcelas() As String = Split(Me.DiasParcelamento.Text, "-")
            For i As Integer = 0 To Parcelas.Length - 1
                Dim Vlr As Integer = Convert.ToInt32(Parcelas(i).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DiasParcelamento.Clear()
            Me.DiasParcelamento.Focus()
            Exit Sub
        End Try


        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        If Operation = INS Then

            Try

                Dim Sql As String = "INSERT INTO ReceberAgrupar (DataLancamento,Descricao,Cliente,ValorAgrupado,DiasParcelamento,Confirmado,Empresa,Extornado) VALUES (@DataLancamento,@Descricao,@Cliente,@ValorAgrupado,@DiasParcelamento,@Confirmado,@Empresa,@Extornado)"
                Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@DataLancamento", Me.DataLancamento.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Descricao", Me.Descricao.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Cliente", Me.Cliente.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@ValorAgrupado", NzZero(Me.ValorAgrupado.Text)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@DiasParcelamento", Me.DiasParcelamento.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Confirmado", True))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Empresa", CodEmpresa))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Extornado", False))
                cmd.ExecuteNonQuery()

                cmd.CommandText = "SELECT @@IDENTITY"
                Me.IdAgrupar.Text = cmd.ExecuteScalar.ToString

                CNN.Close()
                Ação.Desbloquear_Controle(Me, False)
                GerarParcelamentos()
                Operation = UPD
                MessageBox.Show("Agrupamento gerado com sucesso", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                If ConnectionState.Open Then
                    CNN.Close()
                End If
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try

        Else

            Dim Sql As String = "Update ReceberAgrupar set DataLancamento = @DataLancamento,Descricao = @Descricao,Cliente = @Cliente,ValorAgrupado = @ValorAgrupado,DiasParcelamento = @DiasParcelamento,Confirmado = @Confirmado,Empresa = @Empresa,Extornado = @Extornado Where IdAgrupar = " & Me.IdAgrupar.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@DataLancamento", Me.DataLancamento.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@Descricao", Me.Descricao.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@Cliente", Me.Cliente.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@ValorAgrupado", NzZero(Me.ValorAgrupado.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@DiasParcelamento", Me.DiasParcelamento.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@Confirmado", True))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@Empresa", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@Extornado", False))
            cmd.ExecuteNonQuery()

            CNN.Close()
            Ação.Desbloquear_Controle(Me, False)

            If Me.ListaReceber.RowCount = 0 Then
                GerarParcelamentos()
            End If
            MessageBox.Show("Agrupamento atualizado e gerado com sucesso", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If

    End Sub

    Public Sub GerarParcelamentos()

        If NzZero(Me.ValorAgrupado.Text) = 0 Then
            Exit Sub
        End If

        If Me.DiasParcelamento.Text = "" Then
            Exit Sub
        End If

        'Pegar o total de Parcelamentos
        Dim Parcelas() As String = Split(Me.DiasParcelamento.Text, "-")
        Dim Contar As Integer
        Dim Dividido As Decimal


        Dim CNNReceber As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNNReceber.Open()

        Dim Ds As New DataSet

        Dim Sql As String = "SELECT * from Receber Where Id = -1"

        Dim DAReceber As New OleDb.OleDbDataAdapter(Sql, CNNReceber)
        DAReceber.Fill(Ds, "Receber")

        Dividido = Me.ValorAgrupado.Text / Parcelas.Length

        For Contar = 1 To Parcelas.Length
            Dim DrNew As DataRow
            DrNew = Ds.Tables("Receber").NewRow

            Dim Parc As String = Me.IdAgrupar.Text & "-" & Contar & "/" & Parcelas.Length & "-AG"
            DrNew("Documento") = Parc
            DrNew("DataDocumento") = Me.DataLancamento.Text
            DrNew("ValorDocumento") = Dividido
            DrNew("LocalPgto") = "CARTEIRA"
            DrNew("PedidoProdutos") = 0
            DrNew("CodCliente") = Me.Cliente.Text
            DrNew("Cliente") = Me.ClienteDesc.Text
            DrNew("Empresa") = CodEmpresa
            DrNew("OriginalParcial") = "O"
            DrNew("Vendedor") = 0
            DrNew("Vencimento") = CDate(Me.DataLancamento.Text).AddDays(CInt(Parcelas(Contar - 1)))
            DrNew("MediaDescontoPedido") = 0
            DrNew("PercentComissao") = 0
            DrNew("ControlePedido") = 0
            DrNew("Referencia") = "RECEBIMENTO AGRUPADO DIA " & DataLancamento.Text & " CLIENTE " & Me.ClienteDesc.Text
            DrNew("ContaValorBaixado") = Nz(CodLancamentoReceber, 1)
            DrNew("Virtual") = False
            DrNew("IdAgrupamento") = Me.IdAgrupar.Text

            Ds.Tables("Receber").Rows.Add(DrNew)

        Next

        Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAReceber)
        DAReceber.Update(Ds, "Receber")


        For Each row As DataGridViewRow In Lista.Rows

            If row.Cells("Selecao").Value = True Then
                Sql = "Update Receber set IdAgrupamento =" & Me.IdAgrupar.Text & ", Agrupada = True, Inativo = True Where Id = " & row.Cells("cID").Value
                Dim cmd1 As New OleDb.OleDbCommand(Sql, CNNReceber)
                cmd1.ExecuteNonQuery()
            End If

        Next row
        CNNReceber.Close()

        EncheListaReceber()
    End Sub

    Public Sub EncheListaReceber()

        If Me.IdAgrupar.Text = "" Then Exit Sub


        Dim CNNListaReceber As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNNListaReceber.Open()


        Dim Sql As String = "SELECT  Id,Documento,ValorDocumento,Vencimento,LocalPgto,CodCliente FROM Receber WHERE Receber.IdAgrupamento = " & Me.IdAgrupar.Text & " AND Receber.OriginalParcial = 'O' And Agrupada = False ORDER BY Receber.Vencimento"
        Dim Cmd As New OleDb.OleDbCommand(Sql, CNNListaReceber)
        DaReceber = New OleDb.OleDbDataAdapter(Cmd)
        DaReceber.Fill(DsReceber, "Receber")

        bs.DataSource = DsReceber.Tables("Receber").DefaultView
        Me.ListaReceber.DataSource = bs

        CNNListaReceber.Close()

    End Sub

    Private Sub Descricao_Enter(sender As Object, e As EventArgs) Handles Descricao.Enter
        If Me.Descricao.Text = "" Then
            Me.Descricao.Text = "AG. DE CONTAS DIA " & Me.DataLancamento.Text & " - " & Me.ClienteDesc.Text
        End If
    End Sub

    Private Sub Cliente_Validated(sender As Object, e As EventArgs) Handles Cliente.Validated
        Ação.Descrição_ItenRegistro(Me.Cliente, Me.ClienteDesc, "Clientes", "Codigo", Me.Cliente.Text, "Nome", TrfGerais.TipoDados.Numérico, True)
    End Sub

    Private Sub btSalvarReceber_Click(sender As Object, e As EventArgs) Handles btSalvarReceber.Click

        If Me.Confirmado.Checked = True Then
            MessageBox.Show("O Agrupamento já foi confirmado e não pode ser alterado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim ValorListaReceber As Double
        For Each row As DataGridViewRow In ListaReceber.Rows
            ValorListaReceber += row.Cells("ValorDocumento").Value
        Next

        Me.TotParcelado.Text = FormatNumber(ValorListaReceber, 2)

        If NzZero(Me.TotParcelado.Text) <> (Me.ValorAgrupado.Text) Then
            MessageBox.Show("O valor do parcelamento esta diferente do valor agrupado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim obj As New OleDb.OleDbCommandBuilder(DaReceber)
        DaReceber.Update(DsReceber, "Receber")


    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        Ação.Desbloquear_Controle(Me, True)
        Me.DiasParcelamento.Focus()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub


    Private Sub btLocalizarAgrupamento_Click(sender As Object, e As EventArgs) Handles btLocalizarAgrupamento.Click
        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)
        Me.IdAgrupar.Enabled = False
        Me.IdAgrupar.Text = ""
        Operation = CON
        My.Forms.ReceberAgruparLocalizar.ShowDialog()
        AcharAgrupamento()
    End Sub

    Private Sub AcharAgrupamento()
        If Me.IdAgrupar.Text = "" Then Exit Sub

        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT * FROM ReceberAgrupar  WHERE ReceberAgrupar.IdAgrupar = " & Me.IdAgrupar.Text & " AND ReceberAgrupar.Confirmado = True"
        
        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Agrupamento")


        If ds.Tables("Agrupamento").Rows.Count = 1 Then
            Me.ValorAgrupado.Text = ds.Tables("Agrupamento").Rows(0)("ValorAgrupado")
            Me.DataLancamento.Text = ds.Tables("Agrupamento").Rows(0)("DataLancamento")
            Me.Descricao.Text = ds.Tables("Agrupamento").Rows(0)("Descricao")
            Me.DiasParcelamento.Text = ds.Tables("Agrupamento").Rows(0)("DiasParcelamento")
            Me.Confirmado.Checked = ds.Tables("Agrupamento").Rows(0)("Confirmado")
            Me.Inativo.Checked = ds.Tables("Agrupamento").Rows(0)("Inativo")
        End If

        If Me.Inativo.Checked = False Then
            Sql = "SELECT  Id,Documento,ValorDocumento,Vencimento,LocalPgto,CodCliente FROM Receber WHERE Receber.IdAgrupamento = " & Me.IdAgrupar.Text & " AND Receber.OriginalParcial = 'O' And Agrupada = False ORDER BY Receber.Vencimento"
            Dim Cmd As New OleDb.OleDbCommand(Sql, Cnn)
            Dim DaR As New OleDb.OleDbDataAdapter(Cmd)
            DaR.Fill(ds, "ReceberAG")

            Me.ListaReceber.DataSource = ds.Tables("ReceberAG").DefaultView
            Dim ValorListaReceber As Double
            For Each row As DataGridViewRow In ListaReceber.Rows
                ValorListaReceber += row.Cells("ValorDocumento").Value
            Next

            Me.TotParcelado.Text = FormatNumber(ValorListaReceber, 2)
            Me.ListaReceber.ReadOnly = True


            Sql = "SELECT id,documento,PedidoProdutos,valordocumento FROM Receber WHERE IdAgrupamento = " & Me.IdAgrupar.Text & " And Agrupada = true"
            Dim daLista As New OleDb.OleDbDataAdapter(Sql, Cnn)

            daLista.Fill(ds, "ReceberLista")

            Lista.DataSource = ds.Tables("ReceberLista")
            For Each row As DataGridViewRow In Lista.Rows
                row.Cells("Selecao").Value = True
            Next
            Me.Lista.ReadOnly = True


            DaR.Dispose()
            daLista.Dispose()
            da.Dispose()
        End If

        Cnn.Close()


    End Sub

    Private Sub btDesfazer_Click(sender As Object, e As EventArgs) Handles btDesfazer.Click

        If Me.IdAgrupar.Text = "" Then
            MessageBox.Show("Favor informar um agrupamento válido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = ""
        Dim Cmd As OleDb.OleDbCommand = Cnn.CreateCommand

        
        'Apagar registros nescessario e fazer os extornos

        Dim Autorizado As Boolean = PedirPermissao(Me.Text, Me.IdAgrupar.Text)
        Autorizado = varAutorizado
        If Autorizado = False Then
            Exit Sub
        End If

        Dim Transacao As OleDb.OleDbTransaction = Cnn.BeginTransaction()

        Cmd.Transaction = Transacao

        Try
            Sql = "Update ReceberAgrupar set Inativo = True Where IdAgrupar = " & Me.IdAgrupar.Text
            Cmd.CommandText = Sql
            Cmd.ExecuteNonQuery()

            Sql = "Delete FROM Receber WHERE Receber.IdAgrupamento = " & Me.IdAgrupar.Text & " AND Receber.OriginalParcial = 'O' And Agrupada = False"
            Cmd.CommandText = Sql
            Cmd.ExecuteNonQuery()

            Sql = "Update Receber set Inativo = False, Agrupada = false,IdAgrupamento = Null  WHERE IdAgrupamento = " & Me.IdAgrupar.Text & " And Agrupada = true"
            Cmd.CommandText = Sql
            Cmd.ExecuteNonQuery()

            Transacao.Commit()
            MsgBox("Agrupamento retornado com sucesso.", 64, "Validação de Dados")

            ErroLivre = "Cancelamento de agrupamento"
            GerarLog(Me.Text, AçãoTP.Livre, Me.IdAgrupar.Text)

            Ação.LimpaTextBox(Me)
            Ação.Desbloquear_Controle(Me, True)
            Me.IdAgrupar.Enabled = False
            Me.IdAgrupar.Text = "0000"
            Me.DataLancamento.Text = DataDia
            Me.ListaReceber.ReadOnly = False

            Dim I As Integer
            For I = 0 To Me.Lista.Rows.Count - 1
                Me.Lista.Rows.RemoveAt(0)
            Next
            Dim II As Integer
            For II = 0 To Me.ListaReceber.Rows.Count - 1
                Me.ListaReceber.Rows.RemoveAt(0)
            Next
            Operation = INS
            Me.Cliente.Focus()


        Catch ex As Exception
            Transacao.Rollback()
            Cnn.Close()
            MsgBox(ex.Message, 64, "Validação de Dados")
            MsgBox("Erro ao estornar o agrupamento de recebimento.", 64, "Validação de Dados")
            Exit Sub
        End Try

    End Sub
End Class