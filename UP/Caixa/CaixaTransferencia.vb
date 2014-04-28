Public Class CaixaTransferencia

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub CaixaTransferencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SaldoAtual.Text = FormatNumber(CDbl(My.Forms.Caixa.SaldoAtual.Text), 2)
        EncheListaCaixaTransferir()
        EncheListaBancoTransferir()

    End Sub


    Private Sub EncheListaCaixaTransferir()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT CaixaCadastro.CodigoCaixa, CaixaCadastro.CaixaNome, CaixaCadastro.Inativo, CaixaDia.DataCaixaDia, CaixaDia.Empresa FROM CaixaDia INNER JOIN CaixaCadastro ON CaixaDia.CaixaCod = CaixaCadastro.CodigoCaixa WHERE (((CaixaCadastro.CodigoCaixa) <> '" & My.Forms.Caixa.CaixaCod.Text & "') AND ((CaixaCadastro.Inativo)=False) AND ((CaixaDia.DataCaixaDia)=#" & Format(CDate(My.Forms.Caixa.DataCaixa.Text), "MM/dd/yyyy") & "#) AND ((CaixaDia.Empresa)=" & CodEmpresa & "));"


        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.CaixaTransferir.DataSource = ds.Tables("Table").DefaultView
        Me.CaixaTransferir.DisplayMember = "CaixaNome"
        Me.CaixaTransferir.ValueMember = "CodigoCaixa"
        Me.CaixaTransferir.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

    End Sub


    Private Sub EncheListaBancoTransferir()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT Banco.Codigo, [ContaCorrente] & '-' & [NomeBanco] AS CC, Banco.Inativo, Banco.Empresa FROM(Banco) WHERE (((Banco.Inativo)=False) AND ((Banco.Empresa)=" & CodEmpresa & "));"


        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.BancoTransferir.DataSource = ds.Tables("Table").DefaultView
        Me.BancoTransferir.DisplayMember = "CC"
        Me.BancoTransferir.ValueMember = "Codigo"
        Me.BancoTransferir.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

    End Sub


    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged
        If Me.A1.Checked = True Then
            Me.PainelBanco.Visible = False
            Me.PainelCaixa.Visible = True
            Me.CaixaTransferir.Focus()
        End If
        If Me.A2.Checked = True Then
            Me.PainelBanco.Visible = True
            Me.PainelCaixa.Visible = False
            Me.BancoTransferir.Focus()
        End If
    End Sub

    Private Sub btTranferir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTranferir.Click

        Me.btTranferir.Enabled = False

        If Me.A1.Checked = True Then
            If CDbl(NzZero(Me.ValorTransferirCaixa.Text)) > CDbl(NzZero(Me.SaldoAtual.Text)) Then
                MessageBox.Show("O Valor de Tranferência não pode ser maior que o saldo do caixa", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.ValorTransferirCaixa.Focus()
                Exit Sub
            End If

            If NzZero(Me.ValorTransferirCaixa.Text) = 0 Then
                MessageBox.Show("Favor informar o valor a ser transferido.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.ValorTransferirCaixa.Focus()
                Exit Sub
            End If
            If Me.CaixaTransferir.Text = "" Then
                MessageBox.Show("Favor informar o caixa que o valor será transferido.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.CaixaTransferir.Focus()
                Exit Sub
            End If
            CaixaTransf()
        End If

        If Me.A2.Checked = True Then
            If CDbl(NzZero(Me.ValorTransferirBanco.Text)) > CDbl(NzZero(Me.SaldoAtual.Text)) Then
                MessageBox.Show("O Valor de Tranferência não pode ser maior que o saldo do caixa", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.ValorTransferirCaixa.Focus()
                Exit Sub
            End If

            If NzZero(Me.ValorTransferirBanco.Text) = 0 Then
                MessageBox.Show("Favor informar o valor a ser transferido.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.ValorTransferirBanco.Focus()
                Exit Sub
            End If
            If Me.BancoTransferir.Text = "" Then
                MessageBox.Show("Favor informar o banco que o valor será transferido.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.BancoTransferir.Focus()
                Exit Sub
            End If
            BancoTransf()
        End If

    End Sub


    Private Sub CaixaTransf()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim idRel As Integer = 0
        Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
        Dim CmdCaixa As OleDb.OleDbCommand = CNN.CreateCommand
        Dim CmdTransf As OleDb.OleDbCommand = CNN.CreateCommand

        CmdCaixa.Transaction = Transacao
        CmdTransf.Transaction = Transacao

        Try

            Dim Sql As String = "INSERT INTO LancamentoBanco (Id, DataLancamento, PreDatado, DataPreDatado, Documento, DataDocumento, TipoLancamento, Favorecido, Historico, CaiuBanco, ConfirmadoLancamento, Empresa, ValorDocumento, ContaCorrente, EmitirCheque, ContaBalancete, Tipo, IdLancamento, IdProcura) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19)"
            CmdCaixa.CommandText = Sql

            Dim Ult As Integer = UltimoReg()

            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@1", Ult))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@2", DataDia))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@3", False))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@4", System.DBNull.Value))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@5", "T" & Ult))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@6", DataDia))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@7", "D"))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@8", "TRANSF. DE CAIXA"))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@9", "TRANSF. CAIXA: " & My.Forms.Caixa.CaixaCod.Text & " PARA CAIXA: " & Me.CaixaTransferir.SelectedValue))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@10", Nz("N", 1)))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@11", True)) 'Confirmado Lancamento como true
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@12", CodEmpresa))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@13", (Me.ValorTransferirCaixa.Text * -1)))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(My.Forms.Caixa.CaixaCod.Text, 1)))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@15", "N"))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@16", "000000")) 'Conta Balancete
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@17", "CAIXA"))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@18", "TRANSFCAIXA"))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@19", Ult))

            CmdCaixa.ExecuteNonQuery()
            idRel = Ult



            Sql = "INSERT INTO LancamentoBanco (DataLancamento, PreDatado, DataPreDatado, Documento, DataDocumento, TipoLancamento, Favorecido, Historico, CaiuBanco, ConfirmadoLancamento, Empresa, ValorDocumento, ContaCorrente, EmitirCheque, ContaBalancete, Tipo, IdLancamento, IdProcura) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18)"
            CmdTransf.CommandText = Sql

            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@1", DataDia))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@2", False))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@3", System.DBNull.Value))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@4", "T" & Ult))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@5", DataDia))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@6", "C"))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@7", "TRANSF. DE CAIXA"))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@8", "TRANSF. CAIXA: " & My.Forms.Caixa.CaixaCod.Text & " PARA CAIXA: " & Me.CaixaTransferir.SelectedValue))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@9", Nz("S", 1)))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@10", True)) 'Confirmado Lancamento como true
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@11", CodEmpresa))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@12", Me.ValorTransferirCaixa.Text))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.CaixaTransferir.SelectedValue, 1)))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@14", "N"))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@15", "000000")) 'Conta Balancete
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@16", "CAIXA"))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@17", "TRANSFCAIXA"))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@18", Ult))

            CmdTransf.ExecuteNonQuery()

            Transacao.Commit()
            CNN.Close()

            MessageBox.Show("Transferência realizada com sucesso.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ErroLivre = "Transferência realizada com sucesso para  " & Me.CaixaTransferir.Text
            GerarLog(Me.Text, AçãoTP.Livre, Me.ValorTransferirCaixa.Text)


            'Dim Rel As New ReciboCaixa
            'Rel.cPed = idRel
            'ViewReport.VerRelat.Document = Rel.Document
            'Rel.Run()
            'ViewReport.ShowDialog()

            Try
                RelatorioCarregar = "Rel_Recibo_Caixa.rpt"
                Dim strFormula As String = "{comando.Id}=" & idRel
                'chama a classe e passa os parametros para o relatorio
                Dim f As New ClassView.cView
                f.frm(DirRelat & RelatorioCarregar, LocalBD & Nome_BD, SenhaBancoDados, strFormula)

            Catch ex As Exception

            End Try




            My.Forms.Caixa.MostraCaixa()
            Me.Close()
            Me.Dispose()

        Catch ex As Exception
            Transacao.Rollback()
            CNN.Close()
            MsgBox("Erro na Criação do Lancamento no caixa.", 64, "Validação de Dados")
            MsgBox(ex.Message, 64, "Validação de Dados")
            CNN.Close()
        End Try

    End Sub


    Private Sub BancoTransf()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
        Dim CmdCaixa As OleDb.OleDbCommand = CNN.CreateCommand
        Dim CmdTransf As OleDb.OleDbCommand = CNN.CreateCommand

        CmdCaixa.Transaction = Transacao
        CmdTransf.Transaction = Transacao

        Try

            Dim Sql As String = "INSERT INTO LancamentoBanco (Id, DataLancamento, PreDatado, DataPreDatado, Documento, DataDocumento, TipoLancamento, Favorecido, Historico, CaiuBanco, ConfirmadoLancamento, Empresa, ValorDocumento, ContaCorrente, EmitirCheque, ContaBalancete, Tipo, IdLancamento, IdProcura) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19)"
            CmdCaixa.CommandText = Sql

            Dim Ult As Integer = UltimoReg()

            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@1", Ult))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@2", DataDia))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@3", False))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@4", System.DBNull.Value))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@5", "T" & Ult))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@6", DataDia))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@7", "D"))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@8", "TRANSF. DE CAIXA"))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@9", "TRANSF. CAIXA: " & My.Forms.Caixa.CaixaCod.Text & " PARA BANCO: " & Me.BancoTransferir.SelectedValue))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@10", Nz("N", 1)))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@11", True)) 'Confirmado Lancamento como true
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@12", CodEmpresa))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@13", (Me.ValorTransferirBanco.Text * -1)))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(My.Forms.Caixa.CaixaCod.Text, 1)))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@15", "N"))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@16", "000000")) 'Conta Balancete
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@17", "CAIXA"))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@18", "TRANSFCAIXA"))
            CmdCaixa.Parameters.Add(New OleDb.OleDbParameter("@19", Ult))

            CmdCaixa.ExecuteNonQuery()


            Sql = "INSERT INTO LancamentoBanco (DataLancamento, PreDatado, DataPreDatado, Documento, DataDocumento, TipoLancamento, Favorecido, Historico, CaiuBanco, ConfirmadoLancamento, Empresa, ValorDocumento, ContaCorrente, EmitirCheque, ContaBalancete, Tipo, IdLancamento, IdProcura) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18)"
            CmdTransf.CommandText = Sql

            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@1", DataDia))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@2", False))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@3", System.DBNull.Value))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@4", "T" & Ult))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@5", DataDia))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@6", "C"))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@7", "TRANSF. DE CAIXA"))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@8", "TRANSF. CAIXA: " & My.Forms.Caixa.CaixaCod.Text & " PARA BANCO: " & Me.BancoTransferir.SelectedValue))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@9", Nz("N", 1)))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@10", True)) 'Confirmado Lancamento como true
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@11", CodEmpresa))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@12", Me.ValorTransferirBanco.Text))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.BancoTransferir.SelectedValue, 1)))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@14", "N"))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@15", "000000")) 'Conta Balancete
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@16", "BANCO"))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@17", "TRANSFCAIXA"))
            CmdTransf.Parameters.Add(New OleDb.OleDbParameter("@18", Ult))

            CmdTransf.ExecuteNonQuery()

            Transacao.Commit()
            CNN.Close()

            MessageBox.Show("Transferência realizada com sucesso.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ErroLivre = "Transferência realizada para Banco com sucesso"
            GerarLog(Me.Text, AçãoTP.Livre, Me.ValorTransferirBanco.Text)



            My.Forms.Caixa.MostraCaixa()
            Me.Close()
            Me.Dispose()

        Catch ex As Exception
            Transacao.Rollback()
            CNN.Close()
            MsgBox("Erro na Criação do Lancamento no caixa.", 64, "Validação de Dados")
            MsgBox(ex.Message, 64, "Validação de Dados")
            CNN.Close()
        End Try

    End Sub


    Public Function UltimoReg() As Integer
        'Inserir ultimo registro

        Dim Cn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cn.Open()

        Dim Sql As String = "Select max(Id) from LancamentoBanco"
        Dim Cmd As New OleDb.OleDbCommand(Sql, Cn)
        Dim DR As OleDb.OleDbDataReader
        Dim Ult As Integer

        Try
            DR = Cmd.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Ult = DR.Item(0)
            End If
            DR.Close()

        Catch Merror As System.Exception
            Return 0
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Function
            End If
        End Try

        Return Ult + 1


    End Function


End Class