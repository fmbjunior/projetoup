Imports System.Data.OleDb

Public Class PagarAgrupar

    Dim bs As New BindingSource
    Dim DaPagar As OleDb.OleDbDataAdapter
    Dim DsPagar As New DataSet


    Public varPegaConta As String = String.Empty


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

        Sql = "SELECT Fornecedor.RazãoSocial, * FROM PagarAgrupar INNER JOIN Fornecedor ON PagarAgrupar.Fornecedor = Fornecedor.CódigoFornecedor WHERE (((PagarAgrupar.IdAgrupar)=" & idVZ & "))"

        Dim daCab = New OleDb.OleDbDataAdapter(Sql, Cnn)
        daCab.Fill(DS, "Cab")

        If DS.Tables("Cab").Rows.Count = 1 Then
            Me.IdAgrupar.Text = DS.Tables("Cab").Rows(0)("IdAgrupar")
            Me.DataLancamento.Text = DS.Tables("Cab").Rows(0)("DataLancamento")
            Me.Descricao.Text = DS.Tables("Cab").Rows(0)("Descricao")
            Me.Fornecedor.Text = DS.Tables("Cab").Rows(0)("Fornecedor")
            Me.FornecedorDesc.Text = DS.Tables("Cab").Rows(0)("RazãoSocial")
            Me.ValorAgrupado.Text = DS.Tables("Cab").Rows(0)("ValorAgrupado")
            Me.DiasParcelamento.Text = DS.Tables("Cab").Rows(0)("DiasParcelamento")
            Me.Confirmado.Checked = DS.Tables("Cab").Rows(0)("Confirmado")
            Me.Fornecedor.Text = DS.Tables("Cab").Rows(0)("Fornecedor")
        End If

        Sql = "SELECT id,documento,valordocumento FROM Pagar WHERE CodFornecedor = " & Me.Fornecedor.Text & " and Baixado = False and Empresa = " & CodEmpresa & " and Agrupada = true And IdAgrupamento = " & idVZ & " order by Vencimento"
        Dim DaAgrupados As New OleDb.OleDbDataAdapter(Sql, Cnn)
        DaAgrupados.Fill(DS, "Agrupados")

        Me.Lista.DataSource = DS.Tables("Agrupados").DefaultView

        For Each row As DataGridViewRow In Lista.Rows
            row.Cells("Selecao").Value = True
        Next row


        Sql = "SELECT  Id,Documento,ValorDocumento,Vencimento,LocalPgto,CodFornecedor FROM Pagar WHERE Pagar.IdAgrupamento = " & Me.IdAgrupar.Text & " AND Agrupada = False ORDER BY Pagar.Vencimento"
        Dim NovoReceber As New OleDb.OleDbDataAdapter(Sql, Cnn)
        NovoReceber.Fill(DS, "NovoPagar")

        Me.ListaPagar.DataSource = DS.Tables("NovoPagar").DefaultView

        Me.TotParcelado.Text = FormatNumber(NzZero(DS.Tables("NovoPagar").Compute("sum(ValorDocumento)", "")), 2)

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
        Me.ListaPagar.ReadOnly = False

        Dim I As Integer
        For I = 0 To Me.Lista.Rows.Count - 1
            Me.Lista.Rows.RemoveAt(0)
        Next
        Dim II As Integer
        For II = 0 To Me.ListaPagar.Rows.Count - 1
            Me.ListaPagar.Rows.RemoveAt(0)
        Next

        Operation = INS
        Me.Fornecedor.Focus()
    End Sub

    Private Sub btFindClintes_Click(sender As Object, e As EventArgs) Handles btFindClintes.Click
        If Operation <> INS Then Exit Sub

        Me.Fornecedor.Text = ""
        Me.ValorAgrupado.Text = FormatNumber(0, 2)
        If Me.Fornecedor.Text = "" Then
            RetornoProcura = ""
            My.Forms.PagarProcuraFor.ShowDialog()
            If Me.Fornecedor.Text <> "" Then
                achaFornecedor()
            End If
        End If
        Me.Fornecedor.Focus()
    End Sub


    Private Sub achaFornecedor()
        If Me.Fornecedor.Text = "" Then Exit Sub

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty
        Cnn.Open()

        Dim DS As New DataSet

        Sql = "SELECT * from fornecedor where CódigoFornecedor = " & Me.Fornecedor.Text
        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)

        da.Fill(DS, "Fornecedor")

        If DS.Tables("Fornecedor").Rows.Count = 1 Then
            Me.FornecedorDesc.Text = DS.Tables("Fornecedor").Rows(0)("RazãoSocial")
        End If

        da.Dispose()
        DS.Dispose()
        Cnn.Close()


    End Sub

    Private Sub EncheLista()


        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty
        Cnn.Open()

        Dim DS As New DataSet

        Sql = "SELECT id,documento,valordocumento FROM Pagar WHERE CodFornecedor = " & Me.Fornecedor.Text & " and Baixado = False and Empresa = " & CodEmpresa & " and Inativo = False  and  Virtual = False and IdAgrupamento is null order by Vencimento"
        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)

        da.Fill(DS, "Pagar")

        Lista.DataSource = DS.Tables("Pagar")

        da.Dispose()
        DS.Dispose()
        Cnn.Close()

    End Sub

    Private Sub Fornecedor_Leave(sender As Object, e As EventArgs) Handles Fornecedor.Leave
        If Me.Fornecedor.Text = "" Then
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

    Private Sub Cliente_KeyDown(sender As Object, e As KeyEventArgs) Handles Fornecedor.KeyDown
        If e.KeyCode = Keys.F5 Then
            Me.Fornecedor.Text = ""
            Me.ValorAgrupado.Text = FormatNumber(0, 2)
            If Me.Fornecedor.Text = "" Then
                RetornoProcura = ""
                My.Forms.PagarProcuraFor.ShowDialog()
                If Me.Fornecedor.Text <> "" Then
                    achaFornecedor()
                End If
            End If
            Me.Fornecedor.Focus()
        End If
    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        If Me.Confirmado.Checked = True Then
            MessageBox.Show("Este Agrupamento foi confirmado e não pode ser alterado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        SalvarCab()
    End Sub

    Private Sub SalvarCab()

        If Me.Inativo.Checked = True Then
            MessageBox.Show("Este Agrupamento foi cancelado e não pode ser alterado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

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

                Dim Sql As String = "INSERT INTO PagarAgrupar (DataLancamento,Descricao,Fornecedor,ValorAgrupado,DiasParcelamento,Confirmado,Empresa,Extornado,Conta1,Conta2,Conta3,Conta4,Conta5,Conta6,Vlr1,Vlr2,Vlr3,Vlr4,Vlr5,Vlr6,ContaDespesa) VALUES (@DataLancamento,@Descricao,@Fornecedor,@ValorAgrupado,@DiasParcelamento,@Confirmado,@Empresa,@Extornado,@Conta1,@Conta2,@Conta3,@Conta4,@Conta5,@Conta6,@Vlr1,@Vlr2,@Vlr3,@Vlr4,@Vlr5,@Vlr6,@ContaDespesa)"
                Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@DataLancamento", Me.DataLancamento.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Descricao", Me.Descricao.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Fornecedor", Me.Fornecedor.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@ValorAgrupado", NzZero(Me.ValorAgrupado.Text)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@DiasParcelamento", Me.DiasParcelamento.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Confirmado", True))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Empresa", CodEmpresa))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Extornado", False))

                cmd.Parameters.Add(New OleDb.OleDbParameter("@Conta1", nzNUL(Me.Conta1.Text)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Conta2", nzNUL(Me.Conta2.Text)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Conta3", nzNUL(Me.Conta3.Text)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Conta4", nzNUL(Me.Conta4.Text)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Conta5", nzNUL(Me.Conta5.Text)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Conta6", nzNUL(Me.Conta6.Text)))

                cmd.Parameters.Add(New OleDb.OleDbParameter("@Vlr1", nzNUL(Me.Vlr1.Text)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Vlr2", nzNUL(Me.Vlr2.Text)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Vlr3", nzNUL(Me.Vlr3.Text)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Vlr4", nzNUL(Me.Vlr4.Text)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Vlr5", nzNUL(Me.Vlr5.Text)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Vlr6", nzNUL(Me.Vlr6.Text)))

                cmd.Parameters.Add(New OleDb.OleDbParameter("@ContaDespesa", nzNUL(Me.ContaDespesa.Text)))


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


        Dim CNNPagar As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNNPagar.Open()

        Dim Ds As New DataSet

        Dim Sql As String = "SELECT * from Pagar Where Id = -1"

        Dim DAPagar As New OleDb.OleDbDataAdapter(Sql, CNNPagar)
        DAPagar.Fill(Ds, "Pagar")

        Dividido = Me.ValorAgrupado.Text / Parcelas.Length

        For Contar = 1 To Parcelas.Length
            Dim DrNew As DataRow
            DrNew = Ds.Tables("Pagar").NewRow

            Dim Parc As String = Me.IdAgrupar.Text & "-" & Contar & "/" & Parcelas.Length & "-AG"
            DrNew("Documento") = Parc
            DrNew("DataDocumento") = Me.DataLancamento.Text
            DrNew("ValorDocumento") = Dividido
            DrNew("LocalPgto") = "CARTEIRA"
            DrNew("IdCompra") = 0
            DrNew("CodFornecedor") = Me.Fornecedor.Text
            DrNew("Fornecedor") = Me.FornecedorDesc.Text
            DrNew("Empresa") = CodEmpresa
            DrNew("Vencimento") = CDate(Me.DataLancamento.Text).AddDays(CInt(Parcelas(Contar - 1)))
            DrNew("Referencia") = "PAGAMENTO AGRUPADO DIA " & DataLancamento.Text & " FORNECEDOR " & Me.FornecedorDesc.Text
            DrNew("Virtual") = False
            DrNew("IdAgrupamento") = Me.IdAgrupar.Text
            DrNew("ContaValorBaixado") = nzNUL(Me.ContaDespesa.Text)

            DrNew("Conta1") = nzNUL(Me.Conta1.Text)
            DrNew("Conta2") = nzNUL(Me.Conta2.Text)
            DrNew("Conta3") = nzNUL(Me.Conta3.Text)
            DrNew("Conta4") = nzNUL(Me.Conta4.Text)
            DrNew("Conta5") = nzNUL(Me.Conta5.Text)
            DrNew("Conta6") = nzNUL(Me.Conta6.Text)

            DrNew("Vlr1") = nzNUM(Me.Vlr1.Text)
            DrNew("Vlr2") = nzNUM(Me.Vlr2.Text)
            DrNew("Vlr3") = nzNUM(Me.Vlr3.Text)
            DrNew("Vlr4") = nzNUM(Me.Vlr4.Text)
            DrNew("Vlr5") = nzNUM(Me.Vlr5.Text)
            DrNew("Vlr6") = nzNUM(Me.Vlr6.Text)

            DrNew("Percent1") = IIf(NzZero(Me.Vlr1.Text) > 0, CDbl(NzZero(Me.Vlr1.Text)) / (CDbl(Me.ValorAgrupado.Text)) * 100, System.DBNull.Value)
            DrNew("Percent2") = IIf(NzZero(Me.Vlr2.Text) > 0, CDbl(NzZero(Me.Vlr2.Text)) / (CDbl(Me.ValorAgrupado.Text)) * 100, System.DBNull.Value)
            DrNew("Percent3") = IIf(NzZero(Me.Vlr3.Text) > 0, CDbl(NzZero(Me.Vlr3.Text)) / (CDbl(Me.ValorAgrupado.Text)) * 100, System.DBNull.Value)
            DrNew("Percent4") = IIf(NzZero(Me.Vlr4.Text) > 0, CDbl(NzZero(Me.Vlr4.Text)) / (CDbl(Me.ValorAgrupado.Text)) * 100, System.DBNull.Value)
            DrNew("Percent5") = IIf(NzZero(Me.Vlr5.Text) > 0, CDbl(NzZero(Me.Vlr5.Text)) / (CDbl(Me.ValorAgrupado.Text)) * 100, System.DBNull.Value)
            DrNew("Percent6") = IIf(NzZero(Me.Vlr6.Text) > 0, CDbl(NzZero(Me.Vlr6.Text)) / (CDbl(Me.ValorAgrupado.Text)) * 100, System.DBNull.Value)

            Ds.Tables("Pagar").Rows.Add(DrNew)

        Next

        Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAPagar)
        DAPagar.Update(Ds, "Pagar")


        For Each row As DataGridViewRow In Lista.Rows

            If row.Cells("Selecao").Value = True Then
                Sql = "Update Pagar set IdAgrupamento =" & Me.IdAgrupar.Text & ", Agrupada = True, Inativo = True Where Id = " & row.Cells("cID").Value
                Dim cmd1 As New OleDb.OleDbCommand(Sql, CNNPagar)
                cmd1.ExecuteNonQuery()
            End If

        Next row
        CNNPagar.Close()

        EncheListaPagar()
    End Sub

    Public Sub EncheListaPagar()

        If Me.IdAgrupar.Text = "" Then Exit Sub


        Dim CNNListaPagar As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNNListaPagar.Open()


        Dim Sql As String = "SELECT  Id,Documento,ValorDocumento,Vencimento,LocalPgto,CodFornecedor FROM Pagar WHERE Pagar.IdAgrupamento = " & Me.IdAgrupar.Text & " AND Agrupada = False ORDER BY Vencimento"
        Dim Cmd As New OleDb.OleDbCommand(Sql, CNNListaPagar)
        DaPagar = New OleDb.OleDbDataAdapter(Cmd)
        DaPagar.Fill(DsPagar, "Pagar")

        bs.DataSource = DsPagar.Tables("Pagar").DefaultView
        Me.ListaPagar.DataSource = bs

        CNNListaPagar.Close()

    End Sub

    Private Sub Descricao_Enter(sender As Object, e As EventArgs) Handles Descricao.Enter
        If Me.Descricao.Text = "" Then
            Me.Descricao.Text = "AG. DE CONTAS DIA " & Me.DataLancamento.Text & " - " & Me.FornecedorDesc.Text
        End If
    End Sub

    Private Sub Fornecedor_Validated(sender As Object, e As EventArgs) Handles Fornecedor.Validated
        achaFornecedor()
    End Sub

    Private Sub btLocalizarAgrupamento_Click(sender As Object, e As EventArgs) Handles btLocalizarAgrupamento.Click
        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)
        Me.IdAgrupar.Enabled = False
        Me.IdAgrupar.Text = ""
        Operation = CON
        My.Forms.PagarAgruparLocalizar.ShowDialog()
        AcharAgrupamento()
    End Sub

    Private Sub AcharAgrupamento()
        If Me.IdAgrupar.Text = "" Then Exit Sub

        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT * FROM PagarAgrupar  WHERE PagarAgrupar.IdAgrupar = " & Me.IdAgrupar.Text & " AND PagarAgrupar.Confirmado = True"

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
            Me.Fornecedor.Text = ds.Tables("Agrupamento").Rows(0)("Fornecedor")
        End If

        If Me.Inativo.Checked = False Then
            Sql = "SELECT  Id,Documento,ValorDocumento,Vencimento,LocalPgto,CodFornecedor FROM Pagar WHERE Pagar.IdAgrupamento = " & Me.IdAgrupar.Text & " AND Agrupada = False ORDER BY Vencimento"
            Dim Cmd As New OleDb.OleDbCommand(Sql, Cnn)
            Dim DaR As New OleDb.OleDbDataAdapter(Cmd)
            DaR.Fill(DsPagar, "Pagar")

            Me.ListaPagar.DataSource = DsPagar.Tables("Pagar").DefaultView
            Dim ValorListaReceber As Double
            For Each row As DataGridViewRow In ListaPagar.Rows
                ValorListaReceber += row.Cells("ValorDocumento").Value
            Next

            Me.TotParcelado.Text = FormatNumber(ValorListaReceber, 2)
            Me.ListaPagar.ReadOnly = True


            Sql = "SELECT id,documento,IdCompra,valordocumento FROM Pagar WHERE IdAgrupamento = " & Me.IdAgrupar.Text & " And Agrupada = true"
            Dim daLista As New OleDb.OleDbDataAdapter(Sql, Cnn)

            daLista.Fill(ds, "PagarLista")

            Lista.DataSource = ds.Tables("PagarLista")
            For Each row As DataGridViewRow In Lista.Rows
                row.Cells("Selecao").Value = True
            Next
            Me.Lista.ReadOnly = True


            DaR.Dispose()
            daLista.Dispose()
            da.Dispose()
        End If

        Cnn.Close()
        achaFornecedor()

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
            Sql = "Update PagarAgrupar set Inativo = True Where IdAgrupar = " & Me.IdAgrupar.Text
            Cmd.CommandText = Sql
            Cmd.ExecuteNonQuery()

            Sql = "Delete FROM Pagar WHERE Pagar.IdAgrupamento = " & Me.IdAgrupar.Text & " AND Agrupada = False"
            Cmd.CommandText = Sql
            Cmd.ExecuteNonQuery()

            Sql = "Update Pagar set Inativo = False, Agrupada = false, IdAgrupamento = Null WHERE IdAgrupamento = " & Me.IdAgrupar.Text & " And Agrupada = true"
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
            Me.ListaPagar.ReadOnly = False

            Dim I As Integer
            For I = 0 To Me.Lista.Rows.Count - 1
                Me.Lista.Rows.RemoveAt(0)
            Next
            Dim II As Integer
            For II = 0 To Me.ListaPagar.Rows.Count - 1
                Me.ListaPagar.Rows.RemoveAt(0)
            Next

            Operation = INS
            Me.Fornecedor.Focus()

        Catch ex As Exception
            Transacao.Rollback()
            Cnn.Close()
            MsgBox(ex.Message, 64, "Validação de Dados")
            MsgBox("Erro ao estornar o agrupamento de recebimento.", 64, "Validação de Dados")
            Exit Sub
        End Try

    End Sub

    Private Sub Find1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find1.Click
        varPegaConta = String.Empty
        My.Forms.CentroCustoNewLocalizar.ShowDialog()
        Me.Conta1.Text = varPegaConta
        AchaContaCR(Me.Conta1.Text, Me.DescConta1)
        Me.Conta1.Focus()

    End Sub

    Private Sub Find2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find2.Click
        varPegaConta = String.Empty
        My.Forms.CentroCustoNewLocalizar.ShowDialog()
        Me.Conta2.Text = varPegaConta
        AchaContaCR(Me.Conta2.Text, Me.DescConta2)
        Me.Conta2.Focus()
    End Sub

    Private Sub Find3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find3.Click
        varPegaConta = String.Empty
        My.Forms.CentroCustoNewLocalizar.ShowDialog()
        Me.Conta3.Text = varPegaConta
        AchaContaCR(Me.Conta3.Text, Me.DescConta3)
        Me.Conta3.Focus()
    End Sub

    Private Sub Find4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find4.Click
        varPegaConta = String.Empty
        My.Forms.CentroCustoNewLocalizar.ShowDialog()
        Me.Conta4.Text = varPegaConta
        AchaContaCR(Me.Conta4.Text, Me.DescConta4)
        Me.Conta4.Focus()
    End Sub

    Private Sub Find5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find5.Click
        varPegaConta = String.Empty
        My.Forms.CentroCustoNewLocalizar.ShowDialog()
        Me.Conta5.Text = varPegaConta
        AchaContaCR(Me.Conta5.Text, Me.DescConta5)
        Me.Conta5.Focus()
    End Sub

    Private Sub Find6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find6.Click
        varPegaConta = String.Empty
        My.Forms.CentroCustoNewLocalizar.ShowDialog()
        Me.Conta6.Text = varPegaConta
        AchaContaCR(Me.Conta6.Text, Me.DescConta6)
        Me.Conta6.Focus()
    End Sub

    Private Sub Conta1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Conta1.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.CentroCustoNewLocalizar.ShowDialog()
            Me.Conta1.Text = varPegaConta
            AchaContaCR(Me.Conta1.Text, Me.DescConta1)
            Me.Conta1.Focus()
        End If
    End Sub

    Private Sub Conta2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Conta2.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.CentroCustoNewLocalizar.ShowDialog()
            Me.Conta2.Text = varPegaConta
            AchaContaCR(Me.Conta2.Text, Me.DescConta2)
            Me.Conta2.Focus()
        End If
    End Sub

    Private Sub Conta3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Conta3.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.CentroCustoNewLocalizar.ShowDialog()
            Me.Conta3.Text = varPegaConta
            AchaContaCR(Me.Conta3.Text, Me.DescConta3)
            Me.Conta3.Focus()
        End If
    End Sub

    Private Sub Conta4_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Conta4.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.CentroCustoNewLocalizar.ShowDialog()
            Me.Conta4.Text = varPegaConta
            AchaContaCR(Me.Conta4.Text, Me.DescConta4)
            Me.Conta4.Focus()
        End If
    End Sub

    Private Sub Conta5_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Conta5.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.CentroCustoNewLocalizar.ShowDialog()
            Me.Conta5.Text = varPegaConta
            AchaContaCR(Me.Conta5.Text, Me.DescConta5)
            Me.Conta5.Focus()
        End If
    End Sub

    Private Sub Conta6_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Conta6.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.CentroCustoNewLocalizar.ShowDialog()
            Me.Conta6.Text = varPegaConta
            AchaContaCR(Me.Conta6.Text, Me.DescConta6)
            Me.Conta6.Focus()
        End If
    End Sub

    Private Sub Conta1_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Conta1.Validating, Conta2.Validating, Conta3.Validating, Conta4.Validating, Conta5.Validating, Conta6.Validating
        Select Case CType(sender, TextBox).Name
            Case "Conta1"
                If String.CompareOrdinal(Me.Conta1.Text, Me.Conta1.TextoAntigo) Then
                    AchaContaCR(Me.Conta1.Text, Me.DescConta1)
                End If
            Case "Conta2"
                If String.CompareOrdinal(Me.Conta2.Text, Me.Conta2.TextoAntigo) Then
                    AchaContaCR(Me.Conta2.Text, Me.DescConta2)
                End If
            Case "Conta3"
                If String.CompareOrdinal(Me.Conta3.Text, Me.Conta3.TextoAntigo) Then
                    AchaContaCR(Me.Conta3.Text, Me.DescConta3)
                End If
            Case "Conta4"
                If String.CompareOrdinal(Me.Conta4.Text, Me.Conta4.TextoAntigo) Then
                    AchaContaCR(Me.Conta4.Text, Me.DescConta4)
                End If
            Case "Conta5"
                If String.CompareOrdinal(Me.Conta5.Text, Me.Conta5.TextoAntigo) Then
                    AchaContaCR(Me.Conta5.Text, Me.DescConta5)
                End If
            Case "Conta6"
                If String.CompareOrdinal(Me.Conta6.Text, Me.Conta6.TextoAntigo) Then
                    AchaContaCR(Me.Conta6.Text, Me.DescConta6)
                End If
        End Select
    End Sub

    Public Sub AchaContaCR(ByVal Conta As String, ByVal CampoParaRetornar As Control)

        If Conta = "" Then Exit Sub

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()
        Dim Sql As String = "Select * from CC3 where ContaGrupo3 = '" & Conta & "' And Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            CampoParaRetornar.Text = DR.Item("DescContaGrupo3") & ""
        Else
            CampoParaRetornar.Text = ""
            Exit Sub
        End If
        Cnn.Close()
    End Sub

    Private Sub Vlr1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vlr1.Leave, Vlr2.Leave, Vlr3.Leave, Vlr4.Leave, Vlr5.Leave, Vlr6.Leave

        Select Case CType(sender, TextBox).Name

            Case "Vlr1"

                If String.CompareOrdinal(Me.Vlr1.Text, Me.Vlr1.TextoAntigo) Then
                    If CDbl(NzZero(Me.Vlr1.Text)) > 0 Then
                        Dim Resta As Double = CDbl(NzZero(Me.ValorAgrupado.Text)) - CDbl(NzZero(Me.Vlr1.Text))
                        If Resta <> 0 Then
                            If CDbl(NzZero(Me.ValorAgrupado.Text)) - CDbl(NzZero(Me.Vlr1.Text)) < 0 Then
                                MessageBox.Show("A Soma dos Valores de Lançamento é maio que a do Pedido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Me.Vlr1.Focus()
                                Exit Sub
                            End If

                            Me.Conta2.Enabled = True : Me.DescConta2.Enabled = True : Me.Find2.Enabled = True : Me.Vlr2.Enabled = True
                            Me.Vlr2.Text = CDbl(NzZero(Me.ValorAgrupado.Text)) - CDbl(NzZero(Me.Vlr1.Text))
                            Me.Vlr3.Text = FormatNumber(0, 2)
                            Me.Vlr4.Text = FormatNumber(0, 2)
                            Me.Vlr5.Text = FormatNumber(0, 2)
                            Me.Vlr6.Text = FormatNumber(0, 2)
                            Me.Conta2.Focus()
                        Else
                            Me.Conta2.Enabled = False : Me.DescConta2.Enabled = False : Me.Find2.Enabled = False : Me.Vlr2.Enabled = False
                        End If
                    End If
                End If

            Case "Vlr2"
                If String.CompareOrdinal(Me.Vlr2.Text, Me.Vlr2.TextoAntigo) Then
                    If CDbl(NzZero(Me.Vlr2.Text)) > 0 Then
                        Dim Resta As Double = CDbl(NzZero(Me.ValorAgrupado.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text))
                        If Resta <> 0 Then
                            If (CDbl(NzZero(Me.ValorAgrupado.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text))) < 0 Then
                                MessageBox.Show("A Soma dos Valores de Lançamento é maio que a do Pedido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Me.Vlr2.Focus()
                                Exit Sub
                            End If

                            Me.Conta3.Enabled = True : Me.DescConta3.Enabled = True : Me.Find3.Enabled = True : Me.Vlr3.Enabled = True
                            Me.Vlr3.Text = CDbl(NzZero(Me.ValorAgrupado.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text))
                            Me.Vlr4.Text = FormatNumber(0, 2)
                            Me.Vlr5.Text = FormatNumber(0, 2)
                            Me.Vlr6.Text = FormatNumber(0, 2)
                            Me.Conta3.Focus()
                        Else
                            Me.Conta3.Enabled = False : Me.DescConta3.Enabled = False : Me.Find3.Enabled = False : Me.Vlr3.Enabled = False
                        End If
                    End If
                End If
            Case "Vlr3"
                If String.CompareOrdinal(Me.Vlr3.Text, Me.Vlr3.TextoAntigo) Then
                    If CDbl(NzZero(Me.Vlr3.Text)) > 0 Then
                        Dim Resta As Double = CDbl(NzZero(Me.ValorAgrupado.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text))
                        If Resta <> 0 Then
                            If (CDbl(NzZero(Me.ValorAgrupado.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text))) < 0 Then
                                MessageBox.Show("A Soma dos Valores de Lançamento é maio que a do Pedido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Me.Vlr3.Focus()
                                Exit Sub
                            End If

                            Me.Conta4.Enabled = True : Me.DescConta4.Enabled = True : Me.Find4.Enabled = True : Me.Vlr4.Enabled = True
                            Me.Vlr4.Text = CDbl(NzZero(Me.ValorAgrupado.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text))
                            Me.Vlr5.Text = FormatNumber(0, 2)
                            Me.Vlr6.Text = FormatNumber(0, 2)
                            Me.Conta4.Focus()
                        Else
                            Me.Conta4.Enabled = False : Me.DescConta4.Enabled = False : Me.Find4.Enabled = False : Me.Vlr4.Enabled = False
                        End If
                    End If
                End If
            Case "Vlr4"
                If String.CompareOrdinal(Me.Vlr4.Text, Me.Vlr4.TextoAntigo) Then
                    If CDbl(NzZero(Me.Vlr4.Text)) > 0 Then
                        Dim Resta As Double = CDbl(NzZero(Me.ValorAgrupado.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text))
                        If Resta <> 0 Then
                            If (CDbl(NzZero(Me.ValorAgrupado.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text))) < 0 Then
                                MessageBox.Show("A Soma dos Valores de Lançamento é maio que a do Pedido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Me.Vlr4.Focus()
                                Exit Sub
                            End If

                            Me.Conta5.Enabled = True : Me.DescConta5.Enabled = True : Me.Find5.Enabled = True : Me.Vlr5.Enabled = True
                            Me.Vlr5.Text = CDbl(NzZero(Me.ValorAgrupado.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text))
                            Me.Vlr6.Text = FormatNumber(0, 2)
                            Me.Conta5.Focus()
                        Else
                            Me.Conta5.Enabled = False : Me.DescConta5.Enabled = False : Me.Find5.Enabled = False : Me.Vlr5.Enabled = False
                        End If
                    End If
                End If
            Case "Vlr5"
                If String.CompareOrdinal(Me.Vlr5.Text, Me.Vlr5.TextoAntigo) Then
                    If CDbl(NzZero(Me.Vlr5.Text)) > 0 Then
                        Dim Resta As Double = CDbl(NzZero(Me.ValorAgrupado.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text)) - CDbl(NzZero(Me.Vlr5.Text))
                        If Resta <> 0 Then
                            If (CDbl(NzZero(Me.ValorAgrupado.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text)) - CDbl(NzZero(Me.Vlr5.Text))) < 0 Then
                                MessageBox.Show("A Soma dos Valores de Lançamento é maio que a do Pedido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Me.Vlr5.Focus()
                                Exit Sub
                            End If

                            Me.Conta6.Enabled = True : Me.DescConta6.Enabled = True : Me.Find6.Enabled = True : Me.Vlr6.Enabled = True
                            Me.Vlr6.Text = CDbl(NzZero(Me.ValorAgrupado.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text)) - CDbl(NzZero(Me.Vlr5.Text))
                            Me.Conta6.Focus()
                        Else
                            Me.Conta6.Enabled = False : Me.DescConta6.Enabled = False : Me.Find6.Enabled = False : Me.Vlr6.Enabled = False
                        End If
                    End If
                End If
            Case "Vlr6"
                If (CDbl(NzZero(Me.ValorAgrupado.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text)) - CDbl(NzZero(Me.Vlr5.Text)) - CDbl(NzZero(Me.Vlr6.Text))) < 0 Then
                    MessageBox.Show("A Soma dos Valores de Lançamento é maio que a do Pedido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Vlr6.Focus()
                    Exit Sub
                End If

        End Select


        If CDbl(NzZero(Me.ValorAgrupado.Text)) < (CDbl(NzZero(Me.Vlr1.Text)) + CDbl(NzZero(Me.Vlr2.Text)) + CDbl(NzZero(Me.Vlr3.Text)) + CDbl(NzZero(Me.Vlr4.Text)) + CDbl(NzZero(Me.Vlr5.Text)) + CDbl(NzZero(Me.Vlr6.Text))) Then
            MessageBox.Show("O Valor dos Lançamentos esta maior que o valor do Pedido, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CType(sender, TextBox).Focus()
            Exit Sub
        End If
    End Sub


    Private Sub btFindValor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindValor.Click
        varPegaConta = String.Empty
        My.Forms.BalanceteContasProcura.TipoConta = "D"
        My.Forms.BalanceteContasProcura.ShowDialog()
        Me.ContaDespesa.Text = varPegaConta
        AchaContaBalancete(Me.ContaDespesa.Text, Me.ContaCRDesc, True)
        Me.ContaDespesa.Focus()
    End Sub

    Public Sub AchaContaBalancete(ByVal ContaBalancete As String, ByVal CampoParaRetornar As Control, ByVal retErro As Boolean)

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()
        Dim Sql As String = "Select * from ContasG3 where ContaGrupo3 = '" & ContaBalancete & "' And Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            CampoParaRetornar.Text = DR.Item("DescContaGrupo3") & ""
        Else
            If retErro = True Then
                MessageBox.Show("Conta Inexistente, Favor verificar...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CType(CampoParaRetornar, TextBox).Clear()
                If CType(CampoParaRetornar, TextBox).Name = "DescConta1" Then Me.Conta1.Focus()
                If CType(CampoParaRetornar, TextBox).Name = "DescConta2" Then Me.Conta2.Focus()
                If CType(CampoParaRetornar, TextBox).Name = "DescConta3" Then Me.Conta3.Focus()
                If CType(CampoParaRetornar, TextBox).Name = "DescConta4" Then Me.Conta4.Focus()
                If CType(CampoParaRetornar, TextBox).Name = "DescConta5" Then Me.Conta5.Focus()
                If CType(CampoParaRetornar, TextBox).Name = "DescConta6" Then Me.Conta6.Focus()
                Exit Sub
            End If
        End If
        Cnn.Close()
    End Sub

    Private Sub ContaLancamento_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContaDespesa.Leave
        If String.CompareOrdinal(Me.ContaDespesa.Text, Me.ContaDespesa.TextoAntigo) Then
            AchaContaBalancete(Me.ContaDespesa.Text, Me.ContaCRDesc, True)
        End If
    End Sub

    Private Sub ContaLancamento_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ContaDespesa.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.BalanceteContasProcura.TipoConta = "D"
            My.Forms.BalanceteContasProcura.ShowDialog()
            Me.ContaDespesa.Text = varPegaConta
            AchaContaBalancete(Me.ContaDespesa.Text, Me.ContaCRDesc, True)
            Me.ContaDespesa.Focus()
        End If

    End Sub
End Class