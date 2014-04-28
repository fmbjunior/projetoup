Public Class BalanceteOrcamentario

  

    Public Sub MostraBalancete()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT BalanceteOrcamentario.AnoOrcFin, ContasG1.DescContaGrupo1, ContasG2.DescContaGrupo2, BalanceteOrcamentario.Conta, ContasG3.DescContaGrupo3, BalanceteOrcamentario.ControlaDespesas, BalanceteOrcamentario.JanPrevisto, BalanceteOrcamentario.JanExecutado, BalanceteOrcamentario.FevPrevisto, BalanceteOrcamentario.FevExecutado, BalanceteOrcamentario.MarPrevisto, BalanceteOrcamentario.MarExecutado, BalanceteOrcamentario.AbrPrevisto, BalanceteOrcamentario.AbrExecutado, BalanceteOrcamentario.MaiPrevisto, BalanceteOrcamentario.MaiExecutado, BalanceteOrcamentario.JunPrevisto, BalanceteOrcamentario.JunExecutado, BalanceteOrcamentario.JulPrevisto, BalanceteOrcamentario.JulExecutado, BalanceteOrcamentario.AgoPrevisto, BalanceteOrcamentario.AgoExecutado, BalanceteOrcamentario.SetPrevisto, BalanceteOrcamentario.SetExecutado, BalanceteOrcamentario.OutPrevisto, BalanceteOrcamentario.OutExecutado, BalanceteOrcamentario.NovPrevisto, BalanceteOrcamentario.NovExecutado, BalanceteOrcamentario.DezPrevisto, BalanceteOrcamentario.DezExecutado FROM ((ContasG1 INNER JOIN ContasG3 ON ContasG1.ContaGrupo1 = ContasG3.ContaGrupo1) INNER JOIN BalanceteOrcamentario ON ContasG3.ContaGrupo3 = BalanceteOrcamentario.Conta) INNER JOIN ContasG2 ON (ContasG2.ContaGrupo2 = ContasG3.ContaGrupo2) AND (ContasG2.ContaGrupo1 = ContasG3.ContaGrupo1) AND (ContasG1.ContaGrupo1 = ContasG2.ContaGrupo1) WHERE(((BalanceteOrcamentario.AnoOrcFin) = '" & Me.AnoPesquisar.Text & "') And ((ContasG1.DescContaGrupo1) = 'RECEITAS')) ORDER BY ContasG1.DescContaGrupo1 DESC , ContasG2.DescContaGrupo2, BalanceteOrcamentario.Conta;"
        Dim daReceitas = New OleDb.OleDbDataAdapter(Sql, Cnn)

        Sql = "SELECT BalanceteOrcamentario.AnoOrcFin, ContasG1.DescContaGrupo1, ContasG2.DescContaGrupo2, BalanceteOrcamentario.Conta, ContasG3.DescContaGrupo3, BalanceteOrcamentario.ControlaDespesas, BalanceteOrcamentario.JanPrevisto, BalanceteOrcamentario.JanExecutado, BalanceteOrcamentario.FevPrevisto, BalanceteOrcamentario.FevExecutado, BalanceteOrcamentario.MarPrevisto, BalanceteOrcamentario.MarExecutado, BalanceteOrcamentario.AbrPrevisto, BalanceteOrcamentario.AbrExecutado, BalanceteOrcamentario.MaiPrevisto, BalanceteOrcamentario.MaiExecutado, BalanceteOrcamentario.JunPrevisto, BalanceteOrcamentario.JunExecutado, BalanceteOrcamentario.JulPrevisto, BalanceteOrcamentario.JulExecutado, BalanceteOrcamentario.AgoPrevisto, BalanceteOrcamentario.AgoExecutado, BalanceteOrcamentario.SetPrevisto, BalanceteOrcamentario.SetExecutado, BalanceteOrcamentario.OutPrevisto, BalanceteOrcamentario.OutExecutado, BalanceteOrcamentario.NovPrevisto, BalanceteOrcamentario.NovExecutado, BalanceteOrcamentario.DezPrevisto, BalanceteOrcamentario.DezExecutado FROM ((ContasG1 INNER JOIN ContasG3 ON ContasG1.ContaGrupo1 = ContasG3.ContaGrupo1) INNER JOIN BalanceteOrcamentario ON ContasG3.ContaGrupo3 = BalanceteOrcamentario.Conta) INNER JOIN ContasG2 ON (ContasG2.ContaGrupo2 = ContasG3.ContaGrupo2) AND (ContasG2.ContaGrupo1 = ContasG3.ContaGrupo1) AND (ContasG1.ContaGrupo1 = ContasG2.ContaGrupo1) WHERE(((BalanceteOrcamentario.AnoOrcFin) = '" & Me.AnoPesquisar.Text & "') And ((ContasG1.DescContaGrupo1) = 'DESPESAS')) ORDER BY ContasG1.DescContaGrupo1 DESC , ContasG2.DescContaGrupo2, BalanceteOrcamentario.Conta;"
        Dim daDespesas = New OleDb.OleDbDataAdapter(Sql, Cnn)

        Dim ds As New DataSet
        daReceitas.Fill(ds, "Receitas")
        daDespesas.Fill(ds, "Despesas")


        Me.ListaReceitas.DataSource = ds.Tables("Receitas").DefaultView
        daReceitas.Dispose()

        Me.ListaDespesas.DataSource = ds.Tables("Despesas").DefaultView
        daDespesas.Dispose()

        Cnn.Close()

    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAtualizar.Click
        If Me.AnoPesquisar.Text = "" Then
            Exit Sub
        End If
        AtSaldos()
        MostraBalancete()
    End Sub

    Private Sub ListaReceitas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListaReceitas.CellDoubleClick
        Dim vIDano As Integer
        Dim vIdConta As String = String.Empty
        vIDano = CInt(Me.ListaReceitas.CurrentRow.Cells(0).Value)
        vIdConta = Me.ListaReceitas.CurrentRow.Cells(3).Value

        Dim FrmBalancete As New BalanceteOrcamentarioEdd(vIdConta, vIDano)
        FrmBalancete.ShowDialog()
    End Sub

    Private Sub ListaDespesas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListaDespesas.CellDoubleClick
        Dim vIDano As Integer
        Dim vIdConta As String = String.Empty
        vIDano = CInt(Me.ListaDespesas.CurrentRow.Cells(0).Value)
        vIdConta = Me.ListaDespesas.CurrentRow.Cells(3).Value

        Dim FrmBalancete As New BalanceteOrcamentarioEdd(vIdConta, vIDano)
        FrmBalancete.ShowDialog()
    End Sub

    Private Sub AtSaldos()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Ds As New DataSet()

        Dim Sqlstr As String = String.Empty
        Sqlstr = "SELECT * from BalanceteOrcamentario Where AnoOrcFin  = '" & Me.AnoPesquisar.Text & "'"

        Dim DABalancete As New OleDb.OleDbDataAdapter(Sqlstr, Cnn)
        DABalancete.Fill(Ds, "Balancete")

        Sqlstr = "SELECT LancamentoBanco.ContaBalancete, Month([DataLancamento]) AS MesLanc, Sum(LancamentoBanco.ValorDocumento) AS SomaDeValorDocumento, LancamentoBanco.Inativo, LancamentoBanco.Empresa FROM(LancamentoBanco) WHERE(((Year([DataLancamento])) = '" & Me.AnoPesquisar.Text & "')) GROUP BY LancamentoBanco.ContaBalancete, Month([DataLancamento]), LancamentoBanco.Inativo, LancamentoBanco.Empresa HAVING (((LancamentoBanco.ContaBalancete) Is Not Null) AND ((LancamentoBanco.Inativo)=False) AND ((LancamentoBanco.Empresa)=" & CodEmpresa & "));"
        Dim DALanc As New OleDb.OleDbDataAdapter(Sqlstr, Cnn)
        DALanc.Fill(Ds, "Lancamentos")

        Dim TotalLinhas As Integer = Ds.Tables("Lancamentos").Rows.Count
        If TotalLinhas = 0 Then TotalLinhas = 1
        MyBarra.Visible = True
        MyBarra.Minimum = 1
        MyBarra.Maximum = TotalLinhas + 1
        MyBarra.Value = 1
        MyBarra.Step = 1
        Me.Cursor = Cursors.WaitCursor

        Dim DrLinha As DataRow
        For Each DrLinha In Ds.Tables("Lancamentos").Rows
            Dim DrLinhaAtual() As DataRow
            DrLinhaAtual = Ds.Tables("Balancete").Select("Conta = '" & DrLinha("ContaBalancete").ToString & "'")

            If DrLinhaAtual.Length = 0 Then

                If Me.AnoPesquisar.Text <> CDate(DataDia).Year Then
                    MessageBox.Show("Não pode criar o balancete para um ano diferente do ano da data atual.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Ds.Dispose()
                    Cnn.Close()
                    Exit Sub
                End If

                Dim TBL As DataTable
                TBL = Ds.Tables("Balancete")

                Dim DRnovo As DataRow
                DRnovo = TBL.NewRow()
                DRnovo("AnoOrcFin") = Me.AnoPesquisar.Text
                DRnovo("Conta") = DrLinha("ContaBalancete").ToString
                DRnovo("ControlaDespesas") = False

                DRnovo("JanPrevisto") = 0
                DRnovo("FevPrevisto") = 0
                DRnovo("MarPrevisto") = 0
                DRnovo("AbrPrevisto") = 0
                DRnovo("MaiPrevisto") = 0
                DRnovo("JunPrevisto") = 0
                DRnovo("JulPrevisto") = 0
                DRnovo("AgoPrevisto") = 0
                DRnovo("SetPrevisto") = 0
                DRnovo("OutPrevisto") = 0
                DRnovo("NovPrevisto") = 0
                DRnovo("DezPrevisto") = 0

                DRnovo("JanExecutado") = 0
                DRnovo("FevExecutado") = 0
                DRnovo("MarExecutado") = 0
                DRnovo("AbrExecutado") = 0
                DRnovo("MaiExecutado") = 0
                DRnovo("JunExecutado") = 0
                DRnovo("JulExecutado") = 0
                DRnovo("AgoExecutado") = 0
                DRnovo("SetExecutado") = 0
                DRnovo("OutExecutado") = 0
                DRnovo("NovExecutado") = 0
                DRnovo("DezExecutado") = 0

                Select Case DrLinha("MesLanc").ToString
                    Case 1
                        DRnovo("JanExecutado") = DrLinha("SomaDeValorDocumento").ToString
                    Case 2
                        DRnovo("FevExecutado") = DrLinha("SomaDeValorDocumento").ToString
                    Case 3
                        DRnovo("MarExecutado") = DrLinha("SomaDeValorDocumento").ToString
                    Case 4
                        DRnovo("AbrExecutado") = DrLinha("SomaDeValorDocumento").ToString
                    Case 5
                        DRnovo("MaiExecutado") = DrLinha("SomaDeValorDocumento").ToString
                    Case 6
                        DRnovo("JunExecutado") = DrLinha("SomaDeValorDocumento").ToString
                    Case 7
                        DRnovo("JulExecutado") = DrLinha("SomaDeValorDocumento").ToString
                    Case 8
                        DRnovo("AgoExecutado") = DrLinha("SomaDeValorDocumento").ToString
                    Case 9
                        DRnovo("SetExecutado") = DrLinha("SomaDeValorDocumento").ToString
                    Case 10
                        DRnovo("OutExecutado") = DrLinha("SomaDeValorDocumento").ToString
                    Case 11
                        DRnovo("NovExecutado") = DrLinha("SomaDeValorDocumento").ToString
                    Case 12
                        DRnovo("DezExecutado") = DrLinha("SomaDeValorDocumento").ToString
                End Select
                TBL.Rows.Add(DRnovo)

            Else

                DrLinhaAtual(0).BeginEdit()
                Select Case DrLinha("MesLanc").ToString
                    Case 1
                        DrLinhaAtual(0)("JanExecutado") = DrLinha("SomaDeValorDocumento").ToString
                    Case 2
                        DrLinhaAtual(0)("FevExecutado") = DrLinha("SomaDeValorDocumento").ToString
                    Case 3
                        DrLinhaAtual(0)("MarExecutado") = DrLinha("SomaDeValorDocumento").ToString
                    Case 4
                        DrLinhaAtual(0)("AbrExecutado") = DrLinha("SomaDeValorDocumento").ToString
                    Case 5
                        DrLinhaAtual(0)("MaiExecutado") = DrLinha("SomaDeValorDocumento").ToString
                    Case 6
                        DrLinhaAtual(0)("JunExecutado") = DrLinha("SomaDeValorDocumento").ToString
                    Case 7
                        DrLinhaAtual(0)("JulExecutado") = DrLinha("SomaDeValorDocumento").ToString
                    Case 8
                        DrLinhaAtual(0)("AgoExecutado") = DrLinha("SomaDeValorDocumento").ToString
                    Case 9
                        DrLinhaAtual(0)("SetExecutado") = DrLinha("SomaDeValorDocumento").ToString
                    Case 10
                        DrLinhaAtual(0)("OutExecutado") = DrLinha("SomaDeValorDocumento").ToString
                    Case 11
                        DrLinhaAtual(0)("NovExecutado") = DrLinha("SomaDeValorDocumento").ToString
                    Case 12
                        DrLinhaAtual(0)("DezExecutado") = DrLinha("SomaDeValorDocumento").ToString
                End Select
                DrLinhaAtual(0).EndEdit()
            End If
            Me.MyBarra.PerformStep()

        Next


        Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DABalancete)
        DABalancete.Update(Ds, "Balancete")
        Me.MyBarra.PerformStep()
        Me.MyBarra.Visible = False

        Ds.Dispose()
        Cnn.Close()

        Me.btRelatorio.Text = "Relat. do Ano " & Me.AnoPesquisar.Text
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AtSaldos()
    End Sub

    Private Sub btRelatorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRelatorio.Click
        If Me.AnoPesquisar.Text = "" Then
            Exit Sub
        End If

        RelatorioCarregar = "RelBalanceteOrcamentario"
        My.Forms.VisualizadorRelatorio.ShowDialog()

    End Sub

    Private Sub btADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btADD.Click

        If Me.AnoPesquisar.Text = "" Then
            MessageBox.Show("O usuário deve informar o ano.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Ds As New DataSet()

        Dim Sqlstr As String = String.Empty
        Sqlstr = "SELECT * from BalanceteOrcamentario Where AnoOrcFin  = '" & Me.AnoPesquisar.Text & "'"

        Dim DABalancete As New OleDb.OleDbDataAdapter(Sqlstr, Cnn)
        DABalancete.Fill(Ds, "Balancete")

        Sqlstr = "SELECT * From ContasG3"
        Dim DALanc As New OleDb.OleDbDataAdapter(Sqlstr, Cnn)
        DALanc.Fill(Ds, "ContasG3")

        Dim TotalLinhas As Integer = Ds.Tables("ContasG3").Rows.Count
        If TotalLinhas = 0 Then TotalLinhas = 1
        MyBarra.Visible = True
        MyBarra.Minimum = 1
        MyBarra.Maximum = TotalLinhas + 1
        MyBarra.Value = 1
        MyBarra.Step = 1
        Me.Cursor = Cursors.WaitCursor

        Dim DrLinha As DataRow
        For Each DrLinha In Ds.Tables("ContasG3").Rows
            Dim DrLinhaAtual() As DataRow
            DrLinhaAtual = Ds.Tables("Balancete").Select("Conta = '" & DrLinha("ContaGrupo3").ToString & "'")

            If DrLinhaAtual.Length = 0 Then

                Dim TBL As DataTable
                TBL = Ds.Tables("Balancete")

                Dim DRnovo As DataRow
                DRnovo = TBL.NewRow()
                DRnovo("AnoOrcFin") = Me.AnoPesquisar.Text
                DRnovo("Conta") = DrLinha("ContaGrupo3").ToString
                DRnovo("ControlaDespesas") = False

                DRnovo("JanPrevisto") = 0
                DRnovo("FevPrevisto") = 0
                DRnovo("MarPrevisto") = 0
                DRnovo("AbrPrevisto") = 0
                DRnovo("MaiPrevisto") = 0
                DRnovo("JunPrevisto") = 0
                DRnovo("JulPrevisto") = 0
                DRnovo("AgoPrevisto") = 0
                DRnovo("SetPrevisto") = 0
                DRnovo("OutPrevisto") = 0
                DRnovo("NovPrevisto") = 0
                DRnovo("DezPrevisto") = 0

                DRnovo("JanExecutado") = 0
                DRnovo("FevExecutado") = 0
                DRnovo("MarExecutado") = 0
                DRnovo("AbrExecutado") = 0
                DRnovo("MaiExecutado") = 0
                DRnovo("JunExecutado") = 0
                DRnovo("JulExecutado") = 0
                DRnovo("AgoExecutado") = 0
                DRnovo("SetExecutado") = 0
                DRnovo("OutExecutado") = 0
                DRnovo("NovExecutado") = 0
                DRnovo("DezExecutado") = 0
                TBL.Rows.Add(DRnovo)
            End If
            Me.MyBarra.PerformStep()

        Next


        Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DABalancete)
        DABalancete.Update(Ds, "Balancete")
        Me.MyBarra.PerformStep()
        Me.MyBarra.Visible = False

        Ds.Dispose()
        Cnn.Close()

        AtSaldos()
        MostraBalancete()

        Me.Cursor = Cursors.Default

    End Sub
End Class