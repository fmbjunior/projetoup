Public Class ReceberBaixaLote

    Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

    Dim Ds As New DataSet
    Dim DALista As OleDb.OleDbDataAdapter
    Dim CmdLista As New OleDb.OleDbCommand

    'Variaveis para lancamento de contas Padrao
    Dim cbJuros As String = String.Empty
    Dim cbMulta As String = String.Empty
    Dim cbDesco As String = String.Empty
    Dim cbValor As String = String.Empty



    Private Sub btFindClintes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindClintes.Click
        Me.Cliente.Clear()
        Me.ClienteDesc.Clear()
        If Me.Cliente.Text = "" Then
            RetornoProcura = ""
            My.Forms.ReceberCliProcura.ShowDialog()
            Me.Cliente.Focus()
        End If
    End Sub

    Private Sub Cliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cliente.KeyDown
        If e.KeyCode = Keys.F5 Then
            Me.Cliente.Clear()
            Me.ClienteDesc.Clear()
            My.Forms.ReceberCliProcura.ShowDialog()
        End If
    End Sub

    Public Sub LocalizaDadosCliente()

        If Me.Cliente.Text = "" Then
            Exit Sub
        End If

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "SELECT * FROM Clientes WHERE Clientes.Empresa = " & CodEmpresa & " AND Clientes.Codigo = " & Me.Cliente.Text

        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.ClienteDesc.Text = DR.Item("Nome") & ""
        End If

        DR.Close()
        Cnn.Close()

    End Sub


    Private Sub EncheLista()

        Dim Sql As String = String.Empty

        Sql = "SELECT Receber.ID, Receber.Documento, Receber.NotaFiscal, Receber.ControlePedido, Receber.Cliente, Receber.DataDocumento, Receber.Vencimento, Receber.ValorDocumento, Receber.DiasAtraso, Receber.JurosP, Receber.ValorJuros, Receber.ValorDesconto, Receber.Multa, Receber.ValorLiquido, Receber.Recebimento, Receber.Baixado, Receber.LocalPgto, Receber.ContaCR, Receber.Banco,Receber.DocRecebBanco FROM(Receber) WHERE(((Receber.ValorDocumento) > 0) And ((Receber.CodCliente) = " & Me.Cliente.Text & ") And ((Receber.Empresa) = " & CodEmpresa & ") And ((Receber.Inativo) = False) And ((Receber.Baixado) = False)) and Virtual = False and CartaoCredito = False ORDER BY Receber.Vencimento;"

        CmdLista.Connection = Cnn
        CmdLista.CommandText = Sql

        DALista = New OleDb.OleDbDataAdapter(CmdLista)
        daLista.Fill(Ds, "Receber")

        'Fazer os Calculos de Juros e Multas


        Dim DrLinha As DataRow

        For Each DrLinha In Ds.Tables("Receber").Rows
            DrLinha.BeginEdit()
            DrLinha("DiasAtraso") = 0
            DrLinha("JurosP") = FormatNumber(0, 2)
            DrLinha("ValorJuros") = FormatNumber(0, 2)
            DrLinha("Multa") = FormatNumber(0, 2)
            DrLinha("ValorDesconto") = FormatNumber(0, 2)
            DrLinha("ValorLiquido") = FormatNumber(0, 2)
            DrLinha.EndEdit()
        Next

        Me.Lista.DataSource = Ds.Tables("Receber").DefaultView


        Try

            For Each row As DataGridViewRow In Me.Lista.Rows

                row.Cells("cDiasAtraso").Value = DateDiff(DateInterval.Day, CType(row.Cells("cVencimento").Value, Date), CType(DataDia, Date))
                row.Cells("cJurosP").Value = FormatNumber(Me.Juros.Text, 2)

                If CDbl(row.Cells("cDiasAtraso").Value) > 3 Then
                    If NzZero(Me.Juros.Text) > FormatNumber(0, 2) Then
                        Dim JDias As Double = FormatNumber((row.Cells("cJurosP").Value / 30) * CDbl(row.Cells("cDiasAtraso").Value), 2)
                        Dim VlrJ As Double = FormatNumber((CDbl(NzZero(row.Cells("cValor").Value)) * CDbl(JDias)) / 100, 2)
                        row.Cells("cValorJuros").Value = CDbl(FormatNumber(VlrJ, 2))
                    End If

                    If Me.Multa.Text = 0 Then
                        row.Cells("cMulta").Value = FormatNumber(0, 2)
                    Else
                        row.Cells("cMulta").Value = FormatNumber((CDbl(row.Cells("cValor").Value) * CDbl(Me.Multa.Text)) / 100, 2)
                    End If
                Else
                    row.Cells("cValorJuros").Value = FormatNumber(0, 2)
                    row.Cells("cMulta").Value = FormatNumber(0, 2)
                End If

                row.Cells("cValorDesconto").Value = FormatNumber(0, 2)
                row.Cells("cValorLiquido").Value = NzZero(row.Cells("cValor").Value) + NzZero(row.Cells("cMulta").Value) + NzZero(row.Cells("cValorJuros").Value) - NzZero(row.Cells("cValorDesconto").Value)
            Next


        Catch ex As Exception

        End Try






    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCalcular.Click

        If Me.btCalcular.Text = "Mostrar" Then
            If Me.Cliente.Text = "" Then
                MessageBox.Show("O campo Cliente não pode conter um valor nulo", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Multa.Focus()
                Exit Sub
            End If
            If Me.Multa.Text = "" Then
                MessageBox.Show("O Valor da Multa não pode ser nulo", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Multa.Focus()
                Exit Sub
            End If
            If Me.Juros.Text = "" Then
                MessageBox.Show("O Valor do Juros não pode ser nulo", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Juros.Focus()
                Exit Sub
            End If

            If Me.Contas.SelectedValue Is Nothing Then
                MessageBox.Show("O usuário deve selecionar para qual conta irá fazer a baixa em Lote.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Contas.Focus()
                Exit Sub
            End If

            If Len(CaixaAtivo) <> 4 Then
                MessageBox.Show("O usuario deve selecionar um caixa antes de localizar as contas do cliente.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If MsgBox("Deseja Ativar o caixa agora", 36, "Validação de Dados") = 6 Then
                    TRVDados(UserAtivo, "CaixaAtivarDesativar")
                    If Ina = True Then
                        MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
                        Exit Sub
                    Else
                        My.Forms.CaixaAtivarDesativar.ShowDialog()
                        If Len(CaixaAtivo) <> 4 Then
                            MessageBox.Show("O Caixa não foi Ativado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If
                Else
                    Exit Sub
                End If
            End If

            Ds.Clear()
            EncheLista()
            Me.tMulta.Text = "00,00"
            Me.tJuros.Text = "00,00"

            Me.Cliente.Enabled = False
            Me.ClienteDesc.Enabled = False
            Me.btFindClintes.Enabled = False
            Me.Multa.Enabled = False
            Me.Juros.Enabled = False
            Me.Contas.Enabled = False
            Me.DocBanco.Enabled = False
            Me.btCalcular.Text = "Alterar"
        Else
            Me.tMulta.Text = "00,00"
            Me.tJuros.Text = "00,00"
            Me.tDoc.Text = "00,00"
            Me.tLiquido.Text = "00,00"

            Dim I As Integer
            For I = 0 To Me.Lista.Rows.Count - 1
                Me.Lista.Rows.RemoveAt(0)
            Next

            Me.Cliente.Enabled = True
            Me.ClienteDesc.Enabled = True
            Me.btFindClintes.Enabled = True
            Me.Multa.Enabled = True
            Me.Juros.Enabled = True
            Me.Contas.Enabled = True
            Me.DocBanco.Enabled = True
            Me.btCalcular.Text = "Mostrar"
            Me.Cliente.Focus()
        End If

    End Sub

    Private Sub Cliente_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cliente.Validated
        'If String.CompareOrdinal(Me.Cliente.Text, Me.Cliente.TextoAntigo) Then
        LocalizaDadosCliente()

        Me.tDoc.Text = FormatNumber(0, 2)
        Me.tJuros.Text = FormatNumber(0, 2)
        Me.tMulta.Text = FormatNumber(0, 2)
        Me.tLiquido.Text = FormatNumber(0, 2)


        Ds.Clear()
        'Me.Lista.DataSource = Ds.Tables("Receber").DefaultView
        'End If
    End Sub

        Private Sub Lista_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellContentClick

        If e.RowIndex = Me.Lista.Rows.GetLastRow(DataGridViewElementStates.None) Then
            Me.Lista.CurrentCell = Me.Lista.Item(0, 0)
        Else
            Me.Lista.CurrentCell = Me.Lista.Item("cBX", e.RowIndex + 1)
        End If



        'Try


        'If Me.Lista.CurrentCell.ColumnIndex = 0 Then
        '    If Me.Lista.CurrentRow.Cells("cBX").Value = False Then
        '        CalculaValores(True)
        '        Me.tDoc.Text = FormatNumber(CDbl(Me.tDoc.Text) + CDbl(Me.Lista.CurrentRow.Cells("cValor").Value), 2)
        '        Me.tJuros.Text = FormatNumber(CDbl(Me.tJuros.Text) + CDbl(Me.Lista.CurrentRow.Cells("cValorJuros").Value), 2)
        '        Me.tMulta.Text = FormatNumber(CDbl(Me.tMulta.Text) + CDbl(Me.Lista.CurrentRow.Cells("cMulta").Value), 2)
        '        Me.tLiquido.Text = FormatNumber(CDbl(Me.tLiquido.Text) + CDbl(Me.Lista.CurrentRow.Cells("cValorLiquido").Value), 2)

        '        If e.RowIndex = Me.Lista.Rows.GetLastRow(DataGridViewElementStates.None) Then
        '            Me.Lista.CurrentCell = Me.Lista.Item(0, 0)
        '        Else
        '            System.Windows.Forms.SendKeys.Send("{Tab}")
        '        End If
        '    Else
        '        Me.tDoc.Text = FormatNumber(CDbl(Me.tDoc.Text) - CDbl(Me.Lista.CurrentRow.Cells("cValor").Value), 2)
        '        Me.tJuros.Text = FormatNumber(CDbl(Me.tJuros.Text) - CDbl(Me.Lista.CurrentRow.Cells("cValorJuros").Value), 2)
        '        Me.tMulta.Text = FormatNumber(CDbl(Me.tMulta.Text) - CDbl(Me.Lista.CurrentRow.Cells("cMulta").Value), 2)
        '        Me.tLiquido.Text = FormatNumber(CDbl(Me.tLiquido.Text) - CDbl(Me.Lista.CurrentRow.Cells("cValorLiquido").Value), 2)
        '        CalculaValores(False)

        '        If e.RowIndex = Me.Lista.Rows.GetLastRow(DataGridViewElementStates.None) Then
        '            Me.Lista.CurrentCell = Me.Lista.Item(0, 0)
        '        Else
        '            System.Windows.Forms.SendKeys.Send("{Tab}")
        '        End If
        '    End If
        '    End If

        'Catch ex As Exception

        'End Try
    End Sub

    'Private Sub CalculaValores(ByVal Calcula As Boolean)

    '    If Calcula = True Then
    '        Me.Lista.CurrentRow.Cells("cDiasAtraso").Value = DateDiff(DateInterval.Day, CType(Me.Lista.CurrentRow.Cells("cVencimento").Value, Date), CType(DataDia, Date))
    '        Me.Lista.CurrentRow.Cells("cJurosP").Value = FormatNumber(Me.Juros.Text, 2)

    '        If CDbl(Me.Lista.CurrentRow.Cells("cDiasAtraso").Value) > 3 Then
    '            If NzZero(Me.Juros.Text) > FormatNumber(0, 2) Then
    '                Dim JDias As Double = FormatNumber((Me.Lista.CurrentRow.Cells("cJurosP").Value / 30) * CDbl(Me.Lista.CurrentRow.Cells("cDiasAtraso").Value), 2)
    '                Me.Lista.CurrentRow.Cells("cValorJuros").Value = FormatNumber((CDbl(Me.Lista.CurrentRow.Cells("cValor").Value) * CDbl(JDias)) / 100, 2)
    '                    If Me.Multa.Text = 0 Then
    '                    Me.Lista.CurrentRow.Cells("cMulta").Value = FormatNumber(0, 2)
    '                Else
    '                    Me.Lista.CurrentRow.Cells("cMulta").Value = FormatNumber((CDbl(Me.Lista.CurrentRow.Cells("cValor").Value) * CDbl(Me.Multa.Text)) / 100, 2)
    '                End If

    '            End If
    '        Else
    '            Me.Lista.CurrentRow.Cells("cValorJuros").Value = FormatNumber(0, 2)
    '            Me.Lista.CurrentRow.Cells("cMulta").Value = FormatNumber(0, 2)
    '        End If

    '        Me.Lista.CurrentRow.Cells("cValorDesconto").Value = FormatNumber(0, 2)
    '        Me.Lista.CurrentRow.Cells("cValorLiquido").Value = NzZero(Me.Lista.CurrentRow.Cells("cValor").Value) + NzZero(Me.Lista.CurrentRow.Cells("cMulta").Value) + NzZero(Me.Lista.CurrentRow.Cells("cValorJuros").Value) - NzZero(Me.Lista.CurrentRow.Cells("cValorDesconto").Value)
    '    Else
    '        Me.Lista.CurrentRow.Cells("cDiasAtraso").Value = 0
    '        Me.Lista.CurrentRow.Cells("cJurosP").Value = FormatNumber(0, 2)
    '        Me.Lista.CurrentRow.Cells("cValorJuros").Value = FormatNumber(0, 2)
    '        Me.Lista.CurrentRow.Cells("cMulta").Value = FormatNumber(0, 2)
    '        Me.Lista.CurrentRow.Cells("cValorDesconto").Value = FormatNumber(0, 2)
    '        Me.Lista.CurrentRow.Cells("cValorLiquido").Value = FormatNumber(0, 2)
    '    End If

    'End Sub

    Private Sub btBaixar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBaixar.Click

        If Me.Contas.SelectedValue Is Nothing Then
            MessageBox.Show("O usuário deve selecionar para qual conta irá fazer a baixa em Lote.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Contas.Focus()
            Exit Sub
        End If

        If NzZero(Me.Contas.SelectedValue) > 0 Then
            If Me.DocBanco.Text = "" Then
                MessageBox.Show("O usuário deve informar o numero do documento do banco para fazer a baixa em Lote.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DocBanco.Focus()
                Exit Sub
            End If
        End If

        If CDbl(NzZero(Me.tLiquido.Text)) = 0 Then
            MessageBox.Show("Não foi selecionado Documento ou os valores são iguais a [00,00]", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        My.Forms.ReceberBaixaVerTroco.ShowDialog()

        If ConnectionState.Open = ConnectionState.Closed Then
            Cnn.Open()
        End If

        Dim Transacao As OleDb.OleDbTransaction
        Transacao = Cnn.BeginTransaction()

        CmdLista.Transaction = Transacao


        Dim varLOCAL As String = String.Empty 'CAIXA/BANCO
        Dim varCONTA As String = String.Empty 'Usado para capturar a conta que ira ser feito o Lançamento

        Try

            Dim Sql As String = String.Empty
            Sql = "SELECT * from LancamentoBanco Where Id  = -1"

            Dim CmdLcto As New OleDb.OleDbCommand(Sql, Cnn)
            CmdLcto.Transaction = Transacao
            Dim DALcto As New OleDb.OleDbDataAdapter(CmdLcto)
            DALcto.Fill(Ds, "Lcto")


            For Each Linha As DataGridViewRow In Me.Lista.Rows
                If Linha.Cells("cBX").Value = True Then 'O Documento foi Selecionado ?

                    If Me.Contas.SelectedValue = 0 Then
                        varLOCAL = "CAIXA"
                        varCONTA = CaixaAtivo
                    Else
                        varLOCAL = "BANCO"
                        varCONTA = Me.Contas.SelectedValue
                    End If


                    Dim EditLinha() As DataRow
                    EditLinha = Ds.Tables("Receber").Select("Id = " & NzZero(Linha.Cells("cId").Value))

                    If EditLinha.Length <> 0 Then
                        EditLinha(0).BeginEdit()
                        EditLinha(0)("DiasAtraso") = Linha.Cells("cDiasAtraso").Value
                        EditLinha(0)("JurosP") = Linha.Cells("cJurosP").Value
                        EditLinha(0)("ValorJuros") = Linha.Cells("cValorJuros").Value
                        EditLinha(0)("Multa") = Linha.Cells("cMulta").Value
                        EditLinha(0)("ValorDesconto") = Linha.Cells("cValorDesconto").Value
                        EditLinha(0)("ValorLiquido") = Linha.Cells("cValorLiquido").Value
                        EditLinha(0)("Recebimento") = DataDia
                        EditLinha(0)("Baixado") = True
                        EditLinha(0)("LocalPgto") = IIf(varLOCAL = "CAIXA", "CARTEIRA", "BANCO")

                        If NzZero(Me.Contas.SelectedValue) > 0 Then
                            EditLinha(0)("Banco") = varCONTA
                            EditLinha(0)("DocRecebBanco") = Nz(Me.DocBanco.Text, 1)
                        End If

                        EditLinha(0).EndEdit()


                        Dim DrNew As DataRow
                        DrNew = Ds.Tables("Lcto").NewRow

                        Dim Hist As String = String.Empty
                        Hist = "BX DOC. " & Linha.Cells("cDocumento").Value

                        DrNew("DataLancamento") = DataDia
                        DrNew("PreDatado") = False
                        DrNew("DataPreDatado") = System.DBNull.Value
                        DrNew("Documento") = Linha.Cells("cDocumento").Value
                        DrNew("DataDocumento") = DataDia
                        DrNew("TipoLancamento") = "C"
                        DrNew("Favorecido") = Linha.Cells("cCliente").Value
                        DrNew("Historico") = Hist
                        DrNew("CaiuBanco") = "S"
                        DrNew("ConfirmadoLancamento") = True
                        DrNew("Empresa") = CodEmpresa
                        DrNew("ValorDocumento") = Linha.Cells("cValor").Value
                        DrNew("ContaCorrente") = varCONTA
                        DrNew("EmitirCheque") = "N"
                        DrNew("ContaBalancete") = cbValor
                        DrNew("Tipo") = varLOCAL
                        DrNew("IdLancamento") = "RECEBERLOTE"
                        DrNew("IdProcura") = Linha.Cells("cId").Value
                        Ds.Tables("Lcto").Rows.Add(DrNew)

                        If CDbl(Linha.Cells("cValorJuros").Value) > 0 Then

                            DrNew = Ds.Tables("Lcto").NewRow

                            Hist = "BX JUROS DOC. " & Linha.Cells("cDocumento").Value

                            DrNew("DataLancamento") = DataDia
                            DrNew("PreDatado") = False
                            DrNew("DataPreDatado") = System.DBNull.Value
                            DrNew("Documento") = Linha.Cells("cDocumento").Value
                            DrNew("DataDocumento") = DataDia
                            DrNew("TipoLancamento") = "C"
                            DrNew("Favorecido") = Linha.Cells("cCliente").Value
                            DrNew("Historico") = Hist
                            DrNew("CaiuBanco") = "S"
                            DrNew("ConfirmadoLancamento") = True
                            DrNew("Empresa") = CodEmpresa
                            DrNew("ValorDocumento") = Linha.Cells("cValorJuros").Value
                            DrNew("ContaCorrente") = varCONTA
                            DrNew("EmitirCheque") = "N"
                            DrNew("ContaBalancete") = cbJuros
                            DrNew("Tipo") = varLOCAL
                            DrNew("IdLancamento") = "RECEBERLOTE"
                            DrNew("IdProcura") = Linha.Cells("cId").Value
                            Ds.Tables("Lcto").Rows.Add(DrNew)
                        End If

                        If CDbl(NzZero(Linha.Cells("cMulta").Value)) > 0 Then

                            DrNew = Ds.Tables("Lcto").NewRow

                            Hist = "BX MULTA DOC. " & Linha.Cells("cDocumento").Value

                            DrNew("DataLancamento") = DataDia
                            DrNew("PreDatado") = False
                            DrNew("DataPreDatado") = System.DBNull.Value
                            DrNew("Documento") = Linha.Cells("cDocumento").Value
                            DrNew("DataDocumento") = DataDia
                            DrNew("TipoLancamento") = "C"
                            DrNew("Favorecido") = Linha.Cells("cCliente").Value
                            DrNew("Historico") = Hist
                            DrNew("CaiuBanco") = "S"
                            DrNew("ConfirmadoLancamento") = True
                            DrNew("Empresa") = CodEmpresa
                            DrNew("ValorDocumento") = Linha.Cells("cMulta").Value
                            DrNew("ContaCorrente") = varCONTA
                            DrNew("EmitirCheque") = "N"
                            DrNew("ContaBalancete") = cbMulta
                            DrNew("Tipo") = varLOCAL
                            DrNew("IdLancamento") = "RECEBERLOTE"
                            DrNew("IdProcura") = Linha.Cells("cId").Value
                            Ds.Tables("Lcto").Rows.Add(DrNew)
                        End If

                        If CDbl(NzZero(Linha.Cells("cValorDesconto").Value)) > 0 Then

                            DrNew = Ds.Tables("Lcto").NewRow

                            Hist = "DESC. CONCEDIDO DOC. " & Linha.Cells("cDocumento").Value

                            DrNew("DataLancamento") = DataDia
                            DrNew("PreDatado") = False
                            DrNew("DataPreDatado") = System.DBNull.Value
                            DrNew("Documento") = Linha.Cells("cDocumento").Value
                            DrNew("DataDocumento") = DataDia
                            DrNew("TipoLancamento") = "D"
                            DrNew("Favorecido") = Linha.Cells("cCliente").Value
                            DrNew("Historico") = Hist
                            DrNew("CaiuBanco") = "S"
                            DrNew("ConfirmadoLancamento") = True
                            DrNew("Empresa") = CodEmpresa
                            DrNew("ValorDocumento") = (CDbl(NzZero(Linha.Cells("cValorDesconto").Value)) * -1)
                            DrNew("ContaCorrente") = varCONTA
                            DrNew("EmitirCheque") = "N"
                            DrNew("ContaBalancete") = cbDesco
                            DrNew("Tipo") = varLOCAL
                            DrNew("IdLancamento") = "RECEBERLOTE"
                            DrNew("IdProcura") = Linha.Cells("cId").Value
                            Ds.Tables("Lcto").Rows.Add(DrNew)
                        End If

                    End If

                End If
            Next

            Dim ObjLcto As New OleDb.OleDbCommandBuilder(DALcto)
            DALcto.Update(Ds, "Lcto")

            Dim ObjReceber As New OleDb.OleDbCommandBuilder(DALista)
            DALista.Update(Ds, "Receber")

            Transacao.Commit()
            Cnn.Close()

            MessageBox.Show("Documentos Baixado com sucesso.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GerarLog(Me.Text, AçãoTP.Confirmou, Me.Cliente.Text)
            Ds.Clear()
            EncheLista()

            Me.tDoc.Text = FormatNumber(0, 2)
            Me.tJuros.Text = FormatNumber(0, 2)
            Me.tMulta.Text = FormatNumber(0, 2)
            Me.tLiquido.Text = FormatNumber(0, 2)

        Catch ex As Exception
            Transacao.Rollback()
            MsgBox(ex.Message)
        End Try


    End Sub

    Public Sub LocalizaDadosEmpresa()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "Select * from Empresa where CódigoEmpresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            cbJuros = DR.Item("cJurosReceber") & ""
            cbMulta = DR.Item("cMultaReceber") & ""
            cbDesco = DR.Item("cDescReceber") & ""
            cbValor = DR.Item("cValorReceber") & ""
        End If
        DR.Close()
    End Sub

    Private Sub ReceberBaixaLote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LocalizaDadosEmpresa()
        CarregaContas()
        Cnn.Open()
    End Sub

    Private Sub CarregaContas()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT Banco.Codigo AS Cod, [ContaCorrente] & '-' & [NomeBanco] AS [Desc] FROM(Banco) WHERE (((Banco.Inativo)=False) AND ((Banco.Empresa)=" & CodEmpresa & ")); UNION SELECT 0 AS Cod, 'CAIXA' AS [Desc] FROM Banco;"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")


        Me.Contas.DataSource = ds.Tables("Table").DefaultView
        Me.Contas.DisplayMember = "Desc"
        Me.Contas.ValueMember = "Cod"
        Me.Contas.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

    End Sub
   
    Private Sub Contas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Contas.SelectedIndexChanged
        If NzZero(Me.Contas.SelectedValue) > 0 Then
            Me.DocBanco.Visible = True
            Me.LabelDocBanco.Visible = True
        Else
            Me.DocBanco.Visible = False
            Me.LabelDocBanco.Visible = False
        End If
    End Sub

    'Private Sub Lista_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Lista.KeyDown
    '    If e.KeyCode = Keys.Space Then
    '        If Me.Lista.CurrentRow.Cells("cBX").Value = True Then
    '            Me.Lista.CurrentRow.Cells("cBX").Value = False
    '        Else
    '            Me.Lista.CurrentRow.Cells("cBX").Value = True
    '        End If

    '    End If
    'End Sub

    Private Sub Lista_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Lista.CellEndEdit
        CalculaSelecionados(e.RowIndex)
    End Sub

    Private Sub CalculaSelecionados(LinhaSelecionada As Integer)

        Dim VlrDocum As Double = 0
        Dim VlrJuros As Double = 0
        Dim VlrMulta As Double = 0
        Dim VlrLiqui As Double = 0

        For Each dr As DataGridViewRow In Me.Lista.Rows
            If Me.Lista.Rows(dr.Index).Cells("cBX").Value = True Then
                VlrDocum += FormatNumber(CDbl(Me.Lista.Rows(dr.Index).Cells("cValor").Value), 2)
                VlrJuros += FormatNumber(CDbl(Me.Lista.Rows(dr.Index).Cells("cValorJuros").Value), 2)
                VlrMulta += FormatNumber(CDbl(Me.Lista.Rows(dr.Index).Cells("cMulta").Value), 2)
                VlrLiqui += FormatNumber(CDbl(Me.Lista.Rows(dr.Index).Cells("cValorLiquido").Value), 2)
            End If
        Next dr
        'Me.ValorAgrupado.Text = FormatNumber(Vlr, 2)

        Me.tDoc.Text = FormatNumber(VlrDocum, 2)
        Me.tJuros.Text = FormatNumber(VlrJuros, 2)
        Me.tMulta.Text = FormatNumber(VlrMulta, 2)
        Me.tLiquido.Text = FormatNumber(VlrLiqui, 2)


    End Sub

    Private Sub Multa_Leave(sender As Object, e As EventArgs) Handles Multa.Leave
        If CDbl(NzZero(Me.Multa.Text)) > 0 Then
            If cbMulta = "" Then
                MessageBox.Show("Não foi definido conta para Multa, a multa não pode ser aplicada.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Multa.Text = FormatNumber(0, 2)
            End If
        End If
    End Sub

    Private Sub Juros_Leave(sender As Object, e As EventArgs) Handles Juros.Leave
        If CDbl(NzZero(Me.Juros.Text)) > 0 Then
            If cbJuros = "" Then
                MessageBox.Show("Não foi definido conta para Juros, o juros não pode ser aplicado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Juros.Text = FormatNumber(0, 2)
            End If
        End If
    End Sub
End Class