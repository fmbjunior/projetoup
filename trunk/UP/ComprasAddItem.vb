Public Class ComprasAddItem

    Dim PercentualFrete As Double = 0

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2
    Public v_ValorCompra As Double = 0
    Public vIDlinha As Integer

    Private Sub codigoproduto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoProduto.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ProcuraProduto.ShowDialog()
            LocalizaProduto()
        End If
    End Sub

    Private Sub codigoproduto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoProduto.Leave
        LocalizaProduto()
    End Sub

    Public Sub LocalizaProduto()
        If Me.CodigoProduto.Text = "" Then
            Exit Sub
            End
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Produtos where CodigoProduto = " & Me.CodigoProduto.Text '& " and tipo = " & TipoItensProcurar
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            v_ValorCompra = NzZero(DR.Item("ValorCompra"))
            Me.DescProduto.Text = DR.Item("Descrição") & ""
            If Me.ValorUnitario.Text = "" Then Me.ValorUnitario.Text = FormatCurrency(Nz(0, 3), 2)
            Me.ConversorQtd.Text = FormatNumber(NzZero(DR.Item("Multiplos")), 2)
            'Me.IcmsProduto.Text = FormatNumber(NzZero(DR.Item("Icms")), 2)
            'Me.IpiProduto.Text = FormatNumber(NzZero(DR.Item("Icms")), 2)
            'Me.PisProduto.Text = FormatNumber(NzZero(DR.Item("pPIS")), 2)
            'Me.CofinsProduto.Text = FormatNumber(NzZero(DR.Item("pCofins")), 2)

            If My.Forms.Compra.cTipo.Text = "DOC" Then
                Me.ctb.Text = 0
                Me.CSTICMS.Text = 0
                Me.CSTICMSEnt.Text = 0
                Me.BaseCalcIcms.Text = FormatNumber(0, 2)
                Me.IcmsProduto.Text = 0
                Me.ValorIcmsProduto.Text = FormatNumber(0, 2)
                Me.BaseCalcST.Text = FormatNumber(0, 2)
                Me.AliquotaIcmsST.Text = 0
                Me.ValorIcmsST.Text = FormatNumber(0, 2)
                Me.IsentoIcms.Text = FormatNumber(0, 2)
                Me.ValorOutrosIcms.Text = FormatNumber(0, 2)
                Me.CSTIPI.Text = 0
                Me.CSTIPIent.Text = 0
                Me.cEnq.Text = 999
                Me.BaseCalcIpi.Text = FormatNumber(0, 2)
                Me.IpiProduto.Text = 0
                Me.ValorIpiProduto.Text = FormatNumber(0, 2)
                Me.IsentoIpi.Text = FormatNumber(0, 2)
                Me.ValorOutrosIpi.Text = FormatNumber(0, 2)
                Me.CSTpis.Text = 0
                Me.CSTPISent.Text = 0
                Me.vBCpis.Text = FormatNumber(0, 2)
                Me.PisProduto.Text = 0
                Me.ValorPisProduto.Text = FormatNumber(0, 2)
                Me.CSTcofins.Text = 0
                Me.CSTCOFINSent.Text = 0
                Me.vBCcofins.Text = FormatNumber(0, 2)
                Me.CofinsProduto.Text = 0
                Me.ValorCofinsProduto.Text = FormatNumber(0, 2)
            End If

        Else
            Me.CodigoProduto.Clear()
            Me.DescProduto.Clear()
        End If

        DR.Close()
        CNN.Close()

    End Sub

    Private Sub Qtd_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qtd.Enter
        If Me.Qtd.Text = "" Then
            Me.Qtd.Text = FormatNumber(0, 2)
        End If
    End Sub

    Private Sub Qtd_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qtd.Leave
        Me.Qtd.Text = FormatNumber(Nz(Me.Qtd.Text, 3), 4)
    End Sub

    Private Sub IpiProduto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IpiProduto.Leave
        If Me.IpiProduto.Text = "" Then
            Me.IpiProduto.Text = 0
            Me.ValorIpiProduto.Text = FormatCurrency(0, 2)
        Else
            Me.ValorIpiProduto.Text = FormatCurrency(CDbl(Me.BaseCalcIpi.Text) * CDbl(Me.IpiProduto.Text) / 100, 2)
        End If
    End Sub

    Private Sub PisProduto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PisProduto.Leave
        Me.ValorPisProduto.Text = CDbl(NzZero(Me.Total.Text)) * CDbl(NzZero(Me.PisProduto.Text)) / 100
    End Sub

    Private Sub CofinsProduto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CofinsProduto.Leave
        Me.ValorCofinsProduto.Text = CDbl(NzZero(Me.Total.Text)) * CDbl(NzZero(Me.CofinsProduto.Text)) / 100
    End Sub

    Private Sub SalvarItens_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarItens.Click
        If Me.CodigoProduto.Text = "" Then
            MsgBox("Não foi localizado um produto válido", 48, "Validador de Dados")
            Exit Sub
        End If

        If Me.CFOP.Text = "" Then
            MsgBox("Não foi informado o CFOP do produto.", 48, "Validador de Dados")
            Exit Sub
        End If

        If NzZero(Me.Qtd.Text) = 0 Then
            MessageBox.Show("O usuário não pode adicionar item com quantidade ZERO, favor verificar.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Qtd.Focus()
            Exit Sub
        End If

        If NzZero(Me.ValorUnitario.Text) = 0 Then
            MessageBox.Show("O usuário não pode adicionar um item com valor unitario ZERO.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ValorUnitario.Focus()
            Exit Sub
        End If

        If NzZero(Me.Total.Text) = 0 Then
            MessageBox.Show("O usuário não pode adicionar um item com valor Total ZERO.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Total.Focus()
            Exit Sub
        End If


        If Me.Serie.Text = "" Then
            MessageBox.Show("O usuário deve informar a Série da NF, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Serie.Focus()
        End If
        

        Dim MensagemErro As String = ""
        'Testar os Impostos

        'If CDbl(Me.Total.Text) <> CDbl(CDbl(NzZero(Me.Qtd.Text)) * CDbl(NzZero(Me.ValorUnitario.Text))) Then
        '    MessageBox.Show("A Quantidade multiplicada pelo valor unitário esta diferente do Valor informado, verifique.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    MensagemErro = "Dados Inconsistente"
        'End If

        'If Me.SeqNf.Text = "" Then
        '    MessageBox.Show("Não foi informada a sequência do iten na nf, verifique.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    MensagemErro = "Dados Inconsistente"
        'End If

        'If CDbl(Me.ValorIcmsProduto.Text) <> CDbl(CDbl(NzZero(Me.BaseCalcIcms.Text)) * CDbl(NzZero(Me.IcmsProduto.Text)) / 100) Then
        '    MessageBox.Show("O Valor do ICMS esta Incorreto, verifique.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    MensagemErro = "Dados Inconsistente"
        'End If

        'If CDbl(Me.ValorIcmsST.Text) <> CDbl(CDbl(NzZero(Me.BaseCalcST.Text)) * CDbl(NzZero(Me.AliquotaIcmsST.Text)) / 100) Then
        '    MessageBox.Show("O Valor do ICMS ST esta Incorreto, verifique.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    MensagemErro = "Dados Inconsistente"
        'End If


        'If CDbl(Me.ValorIpiProduto.Text) <> CDbl(CDbl(NzZero(Me.BaseCalcIpi.Text)) * CDbl(NzZero(Me.IpiProduto.Text)) / 100) Then
        '    MessageBox.Show("O Valor do IPI esta Incorreto, verifique.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    MensagemErro = "Dados Inconsistente"
        'End If

        'If CDbl(Me.ValorPisProduto.Text) <> CDbl(CDbl(NzZero(Me.vBCpis.Text)) * CDbl(NzZero(Me.PisProduto.Text)) / 100) Then
        '    MessageBox.Show("O Valor do PIS esta Incorreto, verifique.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    MensagemErro = "Dados Inconsistente"
        'End If

        'If CDbl(Me.ValorCofinsProduto.Text) <> CDbl(CDbl(NzZero(Me.vBCcofins.Text)) * CDbl(NzZero(Me.CofinsProduto.Text)) / 100) Then
        '    MessageBox.Show("O Valor do COFINS esta Incorreto, verifique.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    MensagemErro = "Dados Inconsistente"
        'End If

        'Fim dos Teste de Imposto

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        If Operation = INS Then


            Dim Sql As String = "INSERT INTO ItensCompra (CodigoProduto, Qtd, ValorUnitario, TotalProduto, Ipi, ValorIpi, CompraInterno, IcmsProduto, ValorIcmsProduto, PisProduto, ValorPisProduto, CofinsProduto, ValorCofinsProduto, ctb, ValorFreteProduto, ConversorQtd, CFOP, ValorP, SeqNf, IsentoIcms, ValorOutrosIcms, IsentoIpi, ValorOutrosIpi, Serie, SubSerie, BaseCalcIcms, BaseCalcIpi, vSeg, vOutro, CSTICMS, cEnq, CSTIPI, CSTpis, vBCpis, CSTcofins, vBCcofins, BaseCalcST, AliquotaIcmsST, ValorIcmsST, MensagemErro, CSTCOFINSent, CSTPISent, CSTIPIent, CSTICMSEnt, CFOPent, ValorDesconto) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22, @23, @24, @25, @26, @27, @28, @29, @30, @31, @32, @33, @34, @35, @36, @37, @38, @39, @40, @41, @42, @43, @44, @45, @46)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", CInt(Me.CodigoProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", CDbl(Me.Qtd.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", CDbl(Me.ValorUnitario.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", CDbl(NzZero(Me.Total.Text))))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", CDbl(Me.IpiProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", CDbl(Me.ValorIpiProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", CInt(My.Forms.Compra.CompraInterno.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", NzZero(Me.IcmsProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzZero(Me.ValorIcmsProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", NzZero(Me.PisProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", NzZero(Me.ValorPisProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", NzZero(Me.CofinsProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", NzZero(Me.ValorCofinsProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.ctb.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", NzZero(Me.ValorFreteProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", NzZero(Me.ConversorQtd.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@17", NzZero(Me.CFOP.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@18", NzZero(Me.ValorP.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@19", NzZero(Me.SeqNf.Text)))

            'Calcula dos valores do icms
            Dim IsentoIcms As Double = 0
            Dim BaseCalcIcms As Double = 0
            Dim OutrosImcs As Double = 0

            If Me.IcmsProduto.Text > 0 Then BaseCalcIcms = NzZero(Me.BaseCalcIcms.Text) Else BaseCalcIcms = 0
            'OutrosImcs = CDbl(Me.Total.Text) - CDbl(BaseCalcIcms) - CDbl(IsentoIcms)
            'If NzZero(OutrosImcs) < 0 Then OutrosImcs = NzZero(OutrosImcs) * -1
            OutrosImcs = NzZero(Me.ValorOutrosIcms.Text)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@20", NzZero(Me.IsentoIcms.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@21", NzZero(OutrosImcs)))


            'Calcula dos valores do Ipi
            Dim IsentoIPIVar As Double = NzZero(Me.IsentoIpi.Text)
            Dim BaseCalcIPI As Double = 0
            Dim OutrosIPI As Double = 0


            If Me.IpiProduto.Text > 0 Then BaseCalcIPI = NzZero(Me.BaseCalcIpi.Text) Else BaseCalcIPI = 0
            'OutrosIPI = CDbl(Me.Total.Text) - CDbl(BaseCalcIPI) - CDbl(IsentoIPI)
            OutrosIPI = NzZero(Me.ValorOutrosIpi.Text) 'lelo

            cmd.Parameters.Add(New OleDb.OleDbParameter("@22", NzZero(IsentoIPIVar)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@23", NzZero(OutrosIPI)))

            cmd.Parameters.Add(New OleDb.OleDbParameter("@24", Nz(Me.Serie.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@25", Nz(Me.SubSerie.Text, 1)))

            cmd.Parameters.Add(New OleDb.OleDbParameter("@26", NzZero(Me.BaseCalcIcms.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@27", NzZero(Me.BaseCalcIpi.Text)))

            cmd.Parameters.Add(New OleDb.OleDbParameter("@28", NzZero(Me.vSeg.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@29", NzZero(Me.vOutro.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@30", Nz(Me.CSTICMS.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@31", Nz(Me.cEnq.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@32", Nz(Me.CSTIPI.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@33", Nz(Me.CSTpis.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@34", NzZero(Me.vBCpis.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@35", Nz(Me.CSTcofins.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@36", NzZero(Me.vBCcofins.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@37", NzZero(Me.BaseCalcST.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@38", NzZero(Me.AliquotaIcmsST.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@39", NzZero(Me.ValorIcmsST.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@40", MensagemErro))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@41", Nz(Me.CSTCOFINSent.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@42", Nz(Me.CSTPISent.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@43", Nz(Me.CSTIPIent.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@44", Nz(Me.CSTICMSEnt.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@45", Nz(Me.CFOPent.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@46", NzZero(Me.ValorDesconto.Text)))

            Try
                cmd.ExecuteNonQuery()
                cmd.CommandText = "SELECT @@IDENTITY"
                vIDlinha = cmd.ExecuteScalar.ToString
                CNN.Close()

                MsgBox("Registro adicionado com sucesso", 64, "Validador de Dados")

                If v_ValorCompra < CDbl(Me.ValorUnitario.Text) Then
                    If MsgBox("Deseja alterar o custo do produto agora", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Atenção") = MsgBoxResult.Yes Then
                        CompraAlterarCusto.ShowDialog()
                    End If

                End If


                My.Forms.Compra.EncheListaItens()

            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validador de Dados")
            End Try
        ElseIf Operation = UPD Then

            'CSTCOFINSent, CSTPISent, CSTIPIent, CSTICMSEnt
            Dim Sql As String = "Update ItensCompra set CodigoProduto = @1, Qtd = @2, ValorUnitario = @3, TotalProduto = @4, Ipi = @5, ValorIpi = @6, CompraInterno = @7, IcmsProduto = @8, ValorIcmsProduto = @9, PisProduto = @10, ValorPisProduto = @11, CofinsProduto = @12, ValorCofinsProduto = @13, ctb = @14, ValorFreteProduto = @15, ConversorQtd = @16, CFOP = @17, ValorP = @18, SeqNf = @19, IsentoIcms = @20, ValorOutrosIcms = @21, IsentoIpi = @22, ValorOutrosIpi = @23, Serie = @24, SubSerie = @25, BaseCalcIcms = @26, BaseCalcIpi = @27, vSeg = @28, vOutro = @29, CSTICMS = @30, cEnq = @31, CSTIPI = @32, CSTpis = @33, vBCpis = @34, CSTcofins = @35, vBCcofins = @36, BaseCalcST = @37, AliquotaIcmsST = @38, ValorIcmsST = @39, MensagemErro = @40, CSTCOFINSent = @41, CSTPISent = @42, CSTIPIent = @43, CSTICMSEnt = @44, CFOPent = @45, ValorDesconto = @46 Where Id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", CInt(Me.CodigoProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", CDbl(Me.Qtd.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", CDbl(Me.ValorUnitario.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", CDbl(Me.Total.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", CDbl(Me.IpiProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", CDbl(Me.ValorIpiProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", CInt(My.Forms.Compra.CompraInterno.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", NzZero(Me.IcmsProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzZero(Me.ValorIcmsProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", NzZero(Me.PisProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", NzZero(Me.ValorPisProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", NzZero(Me.CofinsProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", NzZero(Me.ValorCofinsProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.ctb.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", NzZero(Me.ValorFreteProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", NzZero(Me.ConversorQtd.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@17", NzZero(Me.CFOP.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@18", NzZero(Me.ValorP.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@19", NzZero(Me.SeqNf.Text)))

            'Calcula dos valores do icms
            Dim IsentoIcms As Double = 0
            Dim BaseCalcIcms As Double = 0
            Dim OutrosImcs As Double = 0

            If Me.IcmsProduto.Text > 0 Then BaseCalcIcms = Me.BaseCalcIcms.Text Else BaseCalcIcms = 0
            'OutrosImcs = CDbl(Me.Total.Text) - CDbl(BaseCalcIcms) - CDbl(IsentoIcms)
            'If NzZero(OutrosImcs) < 0 Then OutrosImcs = NzZero(OutrosImcs) * -1
            OutrosImcs = NzZero(Me.ValorOutrosIcms.Text)


            cmd.Parameters.Add(New OleDb.OleDbParameter("@20", NzZero(Me.IsentoIcms.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@21", NzZero(OutrosImcs)))


            'Calcula dos valores do Ipi
            Dim IsentoIPIVar As Double = NzZero(Me.IsentoIpi.Text)
            Dim BaseCalcIPI As Double = 0
            Dim OutrosIPI As Double = 0

            If Me.IpiProduto.Text > 0 Then BaseCalcIPI = Me.Total.Text Else BaseCalcIPI = 0
            'OutrosIPI = CDbl(Me.Total.Text) - CDbl(BaseCalcIPI) - CDbl(IsentoIPI)
            OutrosIPI = NzZero(Me.ValorOutrosIpi.Text) 'lelo

            cmd.Parameters.Add(New OleDb.OleDbParameter("@22", NzZero(IsentoIPIVar)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@23", NzZero(OutrosIPI)))

            cmd.Parameters.Add(New OleDb.OleDbParameter("@24", Nz(Me.Serie.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@25", Nz(Me.SubSerie.Text, 1)))

            cmd.Parameters.Add(New OleDb.OleDbParameter("@26", NzZero(Me.BaseCalcIcms.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@27", NzZero(Me.BaseCalcIpi.Text)))

            cmd.Parameters.Add(New OleDb.OleDbParameter("@28", NzZero(Me.vSeg.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@29", NzZero(Me.vOutro.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@30", Nz(Me.CSTICMS.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@31", Nz(Me.cEnq.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@32", Nz(Me.CSTIPI.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@33", Nz(Me.CSTpis.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@34", NzZero(Me.vBCpis.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@35", Nz(Me.CSTcofins.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@36", NzZero(Me.vBCcofins.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@37", NzZero(Me.BaseCalcST.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@38", NzZero(Me.AliquotaIcmsST.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@39", NzZero(Me.ValorIcmsST.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@40", MensagemErro))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@41", Nz(Me.CSTCOFINSent.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@42", Nz(Me.CSTPISent.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@43", Nz(Me.CSTIPIent.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@44", Nz(Me.CSTICMSEnt.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@45", Nz(Me.CFOPent.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@46", NzZero(Me.ValorDesconto.Text)))

            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                My.Forms.Compra.EncheListaItens()

                MsgBox("Registro Atualizado com sucesso", 64, "Validador de Dados")
                My.Forms.Compra.EncheListaItens()

            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
        End If

        Operation = INS
        Me.CodigoProduto.Clear()
        Me.DescProduto.Clear()
        Me.Qtd.Clear()
        Me.ValorUnitario.Clear()
        Me.Total.Clear()
        Me.ValorFreteProduto.Clear()
        Me.IcmsProduto.Clear()
        Me.ValorIcmsProduto.Clear()
        Me.IpiProduto.Clear()
        Me.ValorIpiProduto.Clear()
        Me.PisProduto.Clear()
        Me.ValorPisProduto.Clear()
        Me.CofinsProduto.Clear()
        Me.ValorCofinsProduto.Clear()
        Me.ConversorQtd.Clear()
        Me.ValorP.Clear()

        Me.CFOP.Clear()
        Me.CFOPDesc.Clear()

        Me.CFOPent.Clear()
        Me.CFOPdescEnt.Clear()



        Me.SeqNf.Clear()
        Me.Serie.Clear()
        Me.SubSerie.Clear()
        Me.BaseCalcIcms.Clear()
        Me.BaseCalcIpi.Clear()
        Me.IpiProduto.Clear()
        Me.ValorIpiProduto.Clear()
        Me.IsentoIpi.Clear()
        Me.ValorOutrosIpi.Clear()

        Me.ctb.Clear()
        Me.vSeg.Clear()
        Me.vOutro.Clear()
        Me.CSTICMSEnt.Clear()
        Me.CSTICMS.Clear()
        Me.BaseCalcIcms.Clear()
        Me.cEnq.Clear()
        Me.CSTIPI.Clear()
        Me.CSTIPIent.Clear()
        Me.CSTpis.Clear()
        Me.CSTPISent.Clear()
        Me.vBCpis.Clear()
        Me.CSTcofins.Clear()
        Me.CSTCOFINSent.Clear()
        Me.vBCcofins.Clear()
        Me.BaseCalcST.Clear()
        Me.AliquotaIcmsST.Clear()
        Me.ValorIcmsST.Clear()


        Me.CodigoProduto.Focus()

    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        ' My.Forms.Compra.TabGeral.SelectedTab = My.Forms.Compra.TabItem1
       
        Me.Close()

        Me.Dispose()
    End Sub

    Public Sub LocalizaItens()
        If Me.Id.Text = "" Then
            Exit Sub
            End
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        ' Dim Sql As String = "SELECT ItensCompra.*, Produtos.Descrição, ItensCompra.Id FROM ItensCompra INNER JOIN Produtos ON ItensCompra.CodigoProduto = Produtos.CodigoProduto WHERE ItensCompra.Id = " & Me.Id.Text
        Dim Sql As String = "SELECT ItensCompra.*, Produtos.Descrição, CFOP.Descrição, ItensCompra.Id FROM (ItensCompra INNER JOIN Produtos ON ItensCompra.CodigoProduto = Produtos.CodigoProduto) LEFT JOIN CFOP ON ItensCompra.CFOP = CFOP.CFOP WHERE (((ItensCompra.Id)=" & Me.Id.Text & "));"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.CodigoProduto.Text = DR.Item("CodigoProduto")
            Me.DescProduto.Text = DR.Item("Produtos.Descrição") & ""
            Me.Serie.Text = DR.Item("Serie") & ""
            Me.SubSerie.Text = DR.Item("SubSerie") & ""

            Me.CFOP.Text = DR.Item("CFOP") & ""
            Me.CFOPDesc.Text = DR.Item("CFOP.Descrição") & ""
            Me.CFOPent.Text = DR.Item("CFOPent") & ""
            AcharCFOP(NzZero(DR.Item("CFOPent")), Me.CFOPent, Me.CFOPdescEnt)

            Me.Qtd.Text = FormatNumber(DR.Item("Qtd"), 4)
            Me.ConversorQtd.Text = FormatNumber(NzZero(DR.Item("ConversorQtd")), 4)
            Me.ValorUnitario.Text = FormatCurrency(NzZero(DR.Item("ValorUnitario")), 5)
            Me.ValorDesconto.Text = FormatCurrency(NzZero(DR.Item("ValorDesconto")), 2)
            Me.ValorP.Text = FormatCurrency(NzZero(DR.Item("ValorP")), 5)
            Me.Total.Text = FormatCurrency(NzZero(DR.Item("TotalProduto")), 2)

            Me.IcmsProduto.Text = FormatNumber(NzZero(DR.Item("IcmsProduto")), 2)
            Me.ValorIcmsProduto.Text = FormatCurrency(NzZero(DR.Item("ValorIcmsProduto")), 2)
            Me.IpiProduto.Text = FormatNumber(NzZero(DR.Item("Ipi")), 2)
            Me.ValorIpiProduto.Text = FormatCurrency(NzZero(DR.Item("ValorIpi")), 2)
            Me.PisProduto.Text = FormatNumber(NzZero(DR.Item("PisProduto")), 2)
            Me.ValorPisProduto.Text = FormatCurrency(NzZero(DR.Item("ValorPisProduto")), 2)
            Me.CofinsProduto.Text = FormatNumber(NzZero(DR.Item("CofinsProduto")), 2)
            Me.ValorCofinsProduto.Text = FormatCurrency(NzZero(DR.Item("ValorCofinsProduto")), 2)
            Me.ValorFreteProduto.Text = FormatCurrency(NzZero(DR.Item("ValorFreteProduto")), 2)
            Me.SeqNf.Text = FormatNumber(NzZero(DR.Item("SeqNf")), 0)
            Me.BaseCalcIcms.Text = FormatNumber(NzZero(DR.Item("BaseCalcIcms")), 2)
            Me.BaseCalcIpi.Text = FormatNumber(NzZero(DR.Item("BaseCalcIpi")), 2)


            Me.ctb.Text = DR.Item("ctb") & ""
            Me.vSeg.Text = FormatNumber(NzZero(DR.Item("vSeg")), 2)
            Me.vOutro.Text = FormatNumber(NzZero(DR.Item("vOutro")), 2)
            Me.CSTICMS.Text = DR.Item("CSTICMS") & ""
            Me.cEnq.Text = DR.Item("cEnq") & ""
            Me.CSTIPI.Text = DR.Item("CSTIPI") & ""
            Me.CSTpis.Text = DR.Item("CSTpis") & ""
            Me.vBCpis.Text = FormatNumber(NzZero(DR.Item("vBCpis")), 2)
            Me.CSTcofins.Text = DR.Item("CSTcofins") & ""
            Me.vBCcofins.Text = FormatNumber(NzZero(DR.Item("vBCcofins")), 2)
            Me.BaseCalcST.Text = FormatNumber(NzZero(DR.Item("BaseCalcST")), 2)
            Me.AliquotaIcmsST.Text = FormatNumber(NzZero(DR.Item("AliquotaIcmsST")), 2)
            Me.ValorIcmsST.Text = FormatNumber(NzZero(DR.Item("ValorIcmsST")), 2)


            Me.IsentoIcms.Text = FormatNumber(NzZero(DR.Item("IsentoIcms")), 2)
            Me.ValorOutrosIcms.Text = FormatNumber(NzZero(DR.Item("ValorOutrosIcms")), 2)

            Me.ValorOutrosIpi.Text = FormatNumber(NzZero(DR.Item("ValorOutrosIpi")), 2)
            Me.IsentoIpi.Text = FormatNumber(NzZero(DR.Item("IsentoIpi")), 2)


            Me.CSTCOFINSent.Text = DR.Item("CSTCOFINSent") & ""
            Me.CSTPISent.Text = DR.Item("CSTPISent") & ""
            Me.CSTIPIent.Text = DR.Item("CSTIPIent") & ""
            Me.CSTICMSEnt.Text = DR.Item("CSTICMSEnt") & ""

            Operation = UPD
        Else
            MessageBox.Show("Esta identificação do Produto não foi encontrada.", "Validador de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Operation = INS
            Me.CodigoProduto.Clear()
            Me.Qtd.Clear()
            Me.ValorUnitario.Clear()
            Me.ValorP.Clear()
            Me.Total.Clear()
            Me.ValorFreteProduto.Clear()
            Me.IcmsProduto.Clear()
            Me.ValorIcmsProduto.Clear()
            Me.IpiProduto.Clear()
            Me.ValorIpiProduto.Clear()
            Me.PisProduto.Clear()
            Me.ValorPisProduto.Clear()
            Me.CofinsProduto.Clear()
            Me.ValorCofinsProduto.Clear()
            Me.CodigoProduto.Focus()

            Me.ctb.Clear()
            Me.vSeg.Clear()
            Me.vOutro.Clear()
            Me.CSTICMS.Clear()
            Me.cEnq.Clear()
            Me.CSTIPI.Clear()
            Me.CSTpis.Clear()
            Me.vBCpis.Clear()
            Me.CSTcofins.Clear()
            Me.vBCcofins.Clear()
            Me.BaseCalcST.Clear()
            Me.AliquotaIcmsST.Clear()
            Me.ValorIcmsST.Clear()

            Me.CSTCOFINSent.Clear()
            Me.CSTPISent.Clear()
            Me.CSTIPIent.Clear()
            Me.CSTICMSEnt.Clear()
            Me.CFOPent.Clear()
            Me.CFOPdescEnt.Clear()

        End If

        DR.Close()
        CNN.Close()

    End Sub

    Private Sub ComprasAddItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'ao carregar tela verifica o percentual do frete
        If My.Forms.Compra.Visible = True Then
            If My.Forms.Compra.ValorFrete.Text > 0 Then
                PercentualFrete = (NzZero(CDbl(My.Forms.Compra.ValorFrete.Text)) / NzZero(CDbl(My.Forms.Compra.ValorCompra.Text))) * 100
            End If
        End If
    End Sub


    Private Sub AcharCFOP(ByVal CfopValor As String, ByVal CFOPcontrole As Control, ByVal DESCcontrole As Control)
        If CfopValor = "" Then Exit Sub

        Dim DR As OleDb.OleDbDataReader

        Dim CNNBanco As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNNBanco.Open()

        Dim Sql As String = "Select * from CFOP where CFOP = '" & CfopValor & "' And inativo = False"
        Dim CMD As New OleDb.OleDbCommand(Sql, CNNBanco)

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows = True Then
            CFOPcontrole.Text = DR.Item("CFOP") & ""
            DESCcontrole.Text = DR.Item("Descrição") & ""
        Else
            CFOPcontrole.Text = ""
            DESCcontrole.Text = ""
            CFOPcontrole.Focus()
        End If
        DR.Close()
        CNNBanco.Close()
    End Sub

    Private Sub CFOP_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CFOP.Validated
        If String.CompareOrdinal(Me.CFOP.Text, Me.CFOP.TextoAntigo) Then
            AcharCFOP(Me.CFOP.Text, Me.CFOP, Me.CFOPDesc)
        End If
    End Sub

    Private Sub btFindProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindProduto.Click
        My.Forms.ProcuraProduto.ShowDialog()
        LocalizaProduto()
    End Sub

    Private Sub btFindCFOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindCFOP.Click
        My.Forms.CFOPProcura.ShowDialog()
        AcharCFOP(Me.CFOP.Text, Me.CFOP, Me.CFOPDesc)
    End Sub

    Private Sub CFOP_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CFOP.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.CFOPProcura.ShowDialog()
            AcharCFOP(Me.CFOP.Text, Me.CFOP, Me.CFOPDesc)
        End If
    End Sub

    
    Private Sub SubSerie_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubSerie.Enter
        Me.SubSerie.Text = My.Forms.Compra.SubSerie.Text
    End Sub

    Private Sub Serie_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Serie.Enter
        Me.Serie.Text = My.Forms.Compra.Serie.Text
    End Sub

    Private Sub BaseCalcIcms_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaseCalcIcms.Enter
        If Me.BaseCalcIcms.Text = "" Then Me.BaseCalcIcms.Text = FormatNumber(NzZero(Me.Total.Text), 2)
    End Sub

    Private Sub BaseCalcIpi_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaseCalcIpi.Enter
        If Me.BaseCalcIpi.Text = "" Then Me.BaseCalcIpi.Text = FormatNumber(NzZero(Me.Total.Text), 2)
    End Sub

    Private Sub IsentoIpi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IsentoIpi.TextChanged

    End Sub

   
    Private Sub CFOPent_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CFOPent.Validated
        If String.CompareOrdinal(Me.CFOPent.Text, Me.CFOPent.TextoAntigo) Then
            AcharCFOP(Me.CFOPent.Text, Me.CFOPent, Me.CFOPdescEnt)
        End If

        Try
            Dim VarCFOP As Integer = Mid(Me.CFOPent.Text, 1, 1)

            If VarCFOP > 2 Then
                MessageBox.Show("Verifique o [CFOP], inválido para esta operação", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.CFOPent.Clear()
                Me.CFOPent.Focus()
                Exit Sub
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btCFOPent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCFOPent.Click
        My.Forms.CFOPProcura.CampoNome = "CFOPent"
        My.Forms.CFOPProcura.ShowDialog()
        AcharCFOP(Me.CFOPent.Text, Me.CFOPent, Me.CFOPdescEnt)
    End Sub

    Private Sub CFOPent_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CFOPent.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.CFOPProcura.CampoNome = "CFOPent"
            My.Forms.CFOPProcura.ShowDialog()
            AcharCFOP(Me.CFOPent.Text, Me.CFOPent, Me.CFOPdescEnt)
        End If
    End Sub
End Class