Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.OleDb
Imports System.Data.SqlClient



Public Class VisualizadorRelatorio

    Dim Crypto As New ClCrypto 'Para descriptografar a senha do banco de dados

    Public vFornecedor As Integer


    Private Sub VisualizadorRelatorio_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Visualizador.Dispose()

    End Sub

    Private Sub VisualizadorRelatorio_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Visualizador.Dispose()
        Me.Dispose()
    End Sub

    Private Sub VisualizadorRelatorio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Dim isControlPressed As Boolean = (Control.ModifierKeys And Keys.Control) <> 0
        If isControlPressed = True Then
            If e.KeyCode = Keys.P Then
                Me.Visualizador.PrintReport()
            End If
            If e.KeyCode = Keys.O Then
                Me.Visualizador.PrintReport()
                Me.Visualizador.Dispose()
                Me.Close()
                Me.Dispose()
            End If
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
            Me.Dispose()
        End If
    End Sub

#Region "CadGeraisRelat" 'Usado pelo Up
    Private Sub RelCadGerais(ByVal NomeRelatorio As String)
        Me.Cursor = Cursors.WaitCursor

        Dim VerRelat As New ReportDocument()

        If NomeRelatorio = "RelGrupos" Then VerRelat.Load(DirRelat & "RelGrupos.rpt")
        If NomeRelatorio = "RelSubGrupos" Then VerRelat.Load(DirRelat & "RelSubGrupos.rpt")
        If NomeRelatorio = "RelTipoGrupos" Then VerRelat.Load(DirRelat & "RelTipoGrupos.rpt")
        If NomeRelatorio = "RelMarcas" Then VerRelat.Load(DirRelat & "RelMarcas.rpt")
        If NomeRelatorio = "RelCor" Then VerRelat.Load(DirRelat & "RelCor.rpt")

        Dim logOnInfo As New TableLogOnInfo()
        Dim i As Integer
        For i = 0 To VerRelat.Database.Tables.Count - 1
            logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.UserID = ""
            logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
            VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
        Next i


        Me.Visualizador.ReportSource = VerRelat
        Me.Cursor = Cursors.Default
    End Sub
#End Region

#Region "RelPropriedade"
    Private Sub RelFotoPropriedade()
        Me.Cursor = Cursors.WaitCursor

        Dim VerRelat As New ReportDocument()

        VerRelat.Load(DirRelat & "RelFotoPropriedade.rpt")

        Dim logOnInfo As New TableLogOnInfo()
        Dim i As Integer
        For i = 0 To VerRelat.Database.Tables.Count - 1
            logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.UserID = ""
            logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
            VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
        Next i

        Dim SelectFormula As String
        SelectFormula = "{Propriedades.id} = " & My.Forms.ClientesPropriedades.Id.Text
        Visualizador.SelectionFormula = SelectFormula


        Me.Visualizador.ReportSource = VerRelat
        Me.Cursor = Cursors.Default

    End Sub

#End Region

#Region "RelReceberPeriodo"
    Private Sub RelReceberPeriodo()
        Me.Cursor = Cursors.WaitCursor

        Dim VerRelat As New ReportDocument()
        VerRelat.Load(DirRelat & "RelReceber.rpt")

        Dim logOnInfo As New TableLogOnInfo()
        Dim i As Integer
        For i = 0 To VerRelat.Database.Tables.Count - 1
            logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.UserID = ""
            logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
            VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
        Next i

        Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
        T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
        T.Text = "Contas a Receber no Período de : " & My.Forms.ReceberRelat.DataInicial.Text & " a " & My.Forms.ReceberRelat.DataFinal.Text

        Dim SelectFormula As String
        SelectFormula = CrDateBetween("{Receber.Vencimento}", My.Forms.ReceberRelat.DataInicial.Text, My.Forms.ReceberRelat.DataFinal.Text) & " And {Receber.Virtual} = False and {Receber.Baixado} = False and {Receber.Inativo} = False and {Receber.Empresa} = " & CodEmpresa & " and {Receber.ContaPerdida} = False and {Receber.CartaoCredito} = False"
        Visualizador.SelectionFormula = SelectFormula

        Me.Visualizador.ReportSource = VerRelat
        Me.Cursor = Cursors.Default

    End Sub
#End Region


#Region "RelReceberPeriodoRegiao"
    Private Sub RelReceberPeriodoRegiao()
        Me.Cursor = Cursors.WaitCursor

        Dim VerRelat As New ReportDocument()
        VerRelat.Load(DirRelat & "RelReceberPeriodoRegiao.rpt")

        Dim logOnInfo As New TableLogOnInfo()
        Dim i As Integer
        For i = 0 To VerRelat.Database.Tables.Count - 1
            logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.UserID = ""
            logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
            VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
        Next i

        Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
        T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
        T.Text = "Contas a Receber por Região no Período de : " & My.Forms.ReceberRelat.DataInicial.Text & " a " & My.Forms.ReceberRelat.DataFinal.Text

        Dim SelectFormula As String
        SelectFormula = CrDateBetween("{Receber.Vencimento}", My.Forms.ReceberRelat.DataInicial.Text, My.Forms.ReceberRelat.DataFinal.Text) & " And {Receber.Virtual} = False And {Receber.Baixado} = False and {Receber.Inativo} = False and {Receber.Empresa} = " & CodEmpresa & " and {Receber.ContaPerdida} = False And {Receber.CartaoCredito} = False and {Regiao.IdRegiao} = " & My.Forms.ReceberRelat.Regiao.SelectedValue
        Visualizador.SelectionFormula = SelectFormula

        Me.Visualizador.ReportSource = VerRelat
        Me.Cursor = Cursors.Default

    End Sub
#End Region


#Region "RelReceberClienteAgrupado"
    Public Sub RelReceberClienteAgrupado()
        Me.Cursor = Cursors.WaitCursor

        Dim VerRelat As New ReportDocument()
        VerRelat.Load(DirRelat & "RelReceberClienteAgrupado.rpt")

        Dim logOnInfo As New TableLogOnInfo()
        Dim i As Integer
        For i = 0 To VerRelat.Database.Tables.Count - 1
            logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.UserID = ""
            logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
            VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
        Next i

        Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
        T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
        T.Text = "Contas a Receber no Período de : " & My.Forms.ReceberRelat.DataInicial.Text & " a " & My.Forms.ReceberRelat.DataFinal.Text

        Dim SelectFormula As String
        SelectFormula = CrDateBetween("{Receber.Vencimento}", My.Forms.ReceberRelat.DataInicial.Text, My.Forms.ReceberRelat.DataFinal.Text) & " And {Receber.Virtual} = False and {Receber.Baixado} = False and {Receber.Inativo} = False and {Receber.Empresa} = " & CodEmpresa & " and {Receber.ContaPerdida} = False and {Receber.CartaoCredito} = False"
        Visualizador.SelectionFormula = SelectFormula

        Me.Visualizador.ReportSource = VerRelat
        Me.Cursor = Cursors.Default

    End Sub
#End Region

#Region "RelReceberPerdida" 'usuado pelo Up
    Private Sub RelReceberPerdida()
        Me.Cursor = Cursors.WaitCursor

        Dim VerRelat As New ReportDocument()
        VerRelat.Load(DirRelat & "RelReceber.rpt")

        Dim logOnInfo As New TableLogOnInfo()
        Dim i As Integer
        For i = 0 To VerRelat.Database.Tables.Count - 1
            logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.UserID = ""
            logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
            VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
        Next i

        Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
        T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
        T.Text = "Contas a Receber Perdida no Período de : " & My.Forms.ReceberRelat.DataInicial.Text & " a " & My.Forms.ReceberRelat.DataFinal.Text

        Dim SelectFormula As String
        SelectFormula = CrDateBetween("{Receber.Vencimento}", My.Forms.ReceberRelat.DataInicial.Text, My.Forms.ReceberRelat.DataFinal.Text) & " and {Receber.Baixado} = False And {Receber.CartaoCredito} = False and {Receber.Inativo} = False and {Receber.Empresa} = " & CodEmpresa & " and {Receber.ContaPerdida} = True"
        Visualizador.SelectionFormula = SelectFormula

        Me.Visualizador.ReportSource = VerRelat
        Me.Cursor = Cursors.Default

    End Sub

#End Region

#Region "RelHistoricoClientePedidoReceber" 'Usado pelo Up
    Private Sub RelHistoricoClientePedidoReceber()
        Me.Cursor = Cursors.WaitCursor

        Dim VerRelat As New ReportDocument()
        VerRelat.Load(DirRelat & "RelHistoricoClientePedidoReceber.rpt")

        Dim logOnInfo As New TableLogOnInfo()
        Dim i As Integer
        For i = 0 To VerRelat.Database.Tables.Count - 1
            logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.UserID = ""
            logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
            VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
        Next i

        Dim SelectFormula As String
        SelectFormula = "{Clientes.Codigo} = " & My.Forms.ReceberRelat.Cliente.Text

        Visualizador.SelectionFormula = SelectFormula

        Me.Visualizador.ReportSource = VerRelat
        Me.Cursor = Cursors.Default

    End Sub
#End Region

#Region "RelReceberCliente"
    Private Sub RelReceberCliente()
        Me.Cursor = Cursors.WaitCursor

        Dim VerRelat As New ReportDocument()
        VerRelat.Load(DirRelat & "RelReceber.rpt")

        Dim logOnInfo As New TableLogOnInfo()
        Dim i As Integer
        For i = 0 To VerRelat.Database.Tables.Count - 1
            logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.UserID = ""
            logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
            VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
        Next i

        Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
        T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
        T.Text = "Contas a Receber por Cliente"

        Dim SelectFormula As String
        If My.Forms.ReceberRelat.DataInicial.Text = "" Then
            SelectFormula = "{Receber.CodCliente} = " & My.Forms.ReceberRelat.Cliente.Text & " And {Receber.Virtual} = False and {Receber.Baixado} = False and {Receber.Inativo} = False and {Receber.CartaoCredito} = False and {Receber.Empresa} = " & CodEmpresa
        Else
            SelectFormula = CrDateBetween("{Receber.Vencimento}", My.Forms.ReceberRelat.DataInicial.Text, My.Forms.ReceberRelat.DataFinal.Text) & " and {Receber.CodCliente} = " & My.Forms.ReceberRelat.Cliente.Text & " And {Receber.Virtual} = False and {Receber.Baixado} = False and {Receber.Inativo} = False And {Receber.CartaoCredito} = False and {Receber.Empresa} = " & CodEmpresa
        End If
        Visualizador.SelectionFormula = SelectFormula

        Me.Visualizador.ReportSource = VerRelat
        Me.Cursor = Cursors.Default

    End Sub
#End Region

#Region "RelPlanoContas"
    Private Sub RelPlanoContas()
        Me.Cursor = Cursors.WaitCursor

        Dim VerRelat As New ReportDocument()
        VerRelat.Load(DirRelat & "RelPlanoContas.rpt")

        Dim logOnInfo As New TableLogOnInfo()
        Dim i As Integer
        For i = 0 To VerRelat.Database.Tables.Count - 1
            logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.UserID = ""
            logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
            VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
        Next i

        Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
        T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
        T.Text = "Plano de Contas"

        Dim SelectFormula As String
        SelectFormula = "{PlanoContas.Empresa} = " & CodEmpresa
        Visualizador.SelectionFormula = SelectFormula


        Me.Visualizador.ReportSource = VerRelat
        Me.Cursor = Cursors.Default
    End Sub

#End Region

#Region "RelCaixa"



#End Region

#Region "Fluxo Caixa"
    Private Sub RelFluxoCaixa()


        Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim DS As New DataSet()
        Dim Sql As String = String.Empty


        Try

            Sql = "SELECT LancamentoBanco.Tipo, Sum(LancamentoBanco.ValorDocumento) AS SomaDeValorDocumento FROM(LancamentoBanco) WHERE(((LancamentoBanco.CaiuBanco) = 'S') And ((LancamentoBanco.Inativo) = False) And ((LancamentoBanco.Empresa) = " & CodEmpresa & ")) GROUP BY LancamentoBanco.Tipo HAVING (((LancamentoBanco.Tipo)='BANCO'));"
            Dim DABancos As New OleDb.OleDbDataAdapter(Sql, Cnn)
            DABancos.Fill(DS, "Bancos")

            Sql = "SELECT TOP 1 CaixaDia.DataCaixaDia, Sum(CaixaDia.SaldoDia) AS SomaDeSaldoDia FROM(CaixaDia) WHERE(((CaixaDia.Fechado) = True) And ((CaixaDia.Empresa) = " & CodEmpresa & ")) GROUP BY CaixaDia.DataCaixaDia ORDER BY CaixaDia.DataCaixaDia DESC;"
            Dim DASaldoAtualCaixa As New OleDb.OleDbDataAdapter(Sql, Cnn)
            DASaldoAtualCaixa.Fill(DS, "AtualCaixa")


            Sql = "SELECT Receber.Vencimento, Sum(Receber.ValorDocumento) AS Receber, Sum(0) AS Pagar FROM(Receber) WHERE(((Receber.Empresa) = " & CodEmpresa & ") And ((Receber.Baixado) = False) And ((Receber.Inativo) = False)) GROUP BY Receber.Vencimento HAVING (((Receber.Vencimento) Between #" & Format(CDate(My.Forms.CaixaRelat.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(My.Forms.CaixaRelat.DataFinal.Text), "MM/dd/yyyy") & "#)) ORDER BY Receber.Vencimento;"
            Dim DA As New OleDb.OleDbDataAdapter(Sql, Cnn)
            DA.Fill(DS, "FluxoCaixa")

            Sql = "SELECT Pagar.Vencimento, Sum(0) AS Receber, Sum([ValorDocumento]*-1) AS Pagar FROM(Pagar) WHERE(((Pagar.Empresa) = " & CodEmpresa & ") And ((Pagar.Baixado) = False) And ((Pagar.Inativo) = False)) GROUP BY Pagar.Vencimento HAVING (((Pagar.Vencimento) Between #" & Format(CDate(My.Forms.CaixaRelat.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(My.Forms.CaixaRelat.DataFinal.Text), "MM/dd/yyyy") & "#));"
            Dim DAPagar As New OleDb.OleDbDataAdapter(Sql, Cnn)
            DAPagar.Fill(DS, "Pagar")


            Dim Linha As DataRow
            For Each Linha In DS.Tables("Pagar").Rows
                Dim DrLinha() As DataRow
                DrLinha = DS.Tables("FluxoCaixa").Select("Vencimento = #" & Format(CDate(Linha("Vencimento").ToString), "MM/dd/yyyy") & "#")

                If DrLinha.Length = 0 Then

                    Dim DRnovo As DataRow

                    DRnovo = DS.Tables("FluxoCaixa").NewRow
                    DRnovo("Vencimento") = CDate(Linha("Vencimento").ToString)
                    DRnovo("Receber") = 0
                    DRnovo("Pagar") = Linha("Pagar").ToString
                    DS.Tables("FluxoCaixa").Rows.Add(DRnovo)
                Else
                    DrLinha(0).BeginEdit()
                    DrLinha(0)("Pagar") = Linha("Pagar").ToString
                    DrLinha(0).EndEdit()
                End If
            Next



            Sql = "Select * From Empresa Where CódigoEmpresa = " & CodEmpresa
            Dim daEmpresa As New OleDb.OleDbDataAdapter(Sql, Cnn)
            daEmpresa.Fill(DS, "Empresa")

            Dim NomeEmpresa = DS.Tables("Empresa").Rows(0).Item("RazãoSocial").ToString


            Dim Relat As New ReportDocument()
            Relat.Load(DirRelat & "RelFluxoCaixa.rpt")

            Dim SaldoBanco As String
            If DS.Tables("Bancos").Rows.Count = 0 Then
                SaldoBanco = FormatNumber(0, 2)
            Else
                SaldoBanco = FormatNumber(NzZero(DS.Tables("Bancos").Rows(0)("SomaDeValorDocumento").ToString), 2)
            End If

            Relat.DataDefinition.FormulaFields.Item("xSaldoBancos").Text = "'" + SaldoBanco + "'"
            Relat.DataDefinition.FormulaFields.Item("xSaldoCaixa").Text = "'" + FormatNumber(DS.Tables("AtualCaixa").Rows(0)("SomaDeSaldoDia").ToString, 2) + "'"
            Relat.DataDefinition.FormulaFields.Item("Empresa").Text = "'" & NomeEmpresa & "'"
            Relat.DataDefinition.FormulaFields.Item("Titulo").Text = "'Fluxo de caixa no Período de " & My.Forms.CaixaRelat.DataInicial.Text & " a " & My.Forms.CaixaRelat.DataFinal.Text & "'"

            Relat.SetDataSource(DS)

            Me.Visualizador.ReportSource = Relat
        Catch Ex As Exception
            MsgBox(Ex.Message)
            MessageBox.Show("Dados Inexistente para gerar o relatório, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try







        'Me.Cursor = Cursors.WaitCursor

        'Dim VerRelat As New ReportDocument()
        'VerRelat.Load(DirRelat & "RelFluxoCaixa.rpt")

        'Dim logOnInfo As New TableLogOnInfo()
        'Dim i As Integer
        'For i = 0 To VerRelat.Database.Tables.Count - 1
        '    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
        '    'logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
        '    logOnInfo.ConnectionInfo.UserID = ""
        '    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
        '    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
        'Next i

        'Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
        'T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
        'T.Text = "Fluxo de Caixa"

        'Dim SelectFormula As String
        'SelectFormula = "{saldosbancos.Empresa} = " & CodEmpresa
        'Visualizador.SelectionFormula = SelectFormula
        'Me.Visualizador.DisplayGroupTree = False
        'Me.Visualizador.ReportSource = VerRelat
        'Me.Cursor = Cursors.Default

    End Sub
#End Region

#Region "CaixaSintetico"
    Private Sub CaixaSintetico()

        Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim DS As New DataSet()
        Dim Sql As String = String.Empty




        Try
            Sql = "SELECT '0-Saldo Inicial  Bancos' AS IDD, 'Saldo Anterior dos Bancos' AS LocalPgto, Sum(IIf([TipoLancamento]='D',[ValorDocumento],[ValorDocumento]*-1)) AS Credito, 0 AS Debito FROM LancamentoBanco INNER JOIN Banco ON LancamentoBanco.ContaCorrente = Banco.Codigo WHERE (((LancamentoBanco.DataLancamento)<#" & Format(CDate(My.Forms.CaixaRelat.DataInicial.Text), "MM/dd/yyyy") & "#) AND ((LancamentoBanco.CaiuBanco)='S') AND ((LancamentoBanco.Empresa)=" & CodEmpresa & ") AND ((Banco.AgruparFluxoCaixa)=True)) Group by '0-Saldo Inicial  Bancos', 'Saldo Anterior dos Bancos', 0;"
            Dim DASaldoBanco As New OleDb.OleDbDataAdapter(Sql, Cnn)
            DASaldoBanco.Fill(DS, "SaldoInicialBanco")

            Sql = "SELECT TOP 1 First(CaixaCriados.DataCaixaDia) AS PrimeiroDeDataCaixaDia, CaixaCriados.SaldoDia, CaixaCriados.Empresa FROM(CaixaCriados) GROUP BY CaixaCriados.SaldoDia, CaixaCriados.Empresa HAVING(((First(CaixaCriados.DataCaixaDia)) < #" & Format(CDate(My.Forms.CaixaRelat.DataInicial.Text), "MM/dd/yyyy") & "#) And ((CaixaCriados.Empresa) = " & CodEmpresa & ")) ORDER BY First(CaixaCriados.DataCaixaDia) DESC;"
            Dim DASaldoCaixa As New OleDb.OleDbDataAdapter(Sql, Cnn)
            DASaldoCaixa.Fill(DS, "SaldoInicialCaixa")


            Sql = "SELECT '1.0-Recebimento' AS IDD, Receber.LocalPgto, Sum(Receber.ValorLiquido) AS Credito, Sum(0) AS Debito FROM Receber WHERE (((Receber.Recebimento) Between #" & Format(CDate(My.Forms.CaixaRelat.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(My.Forms.CaixaRelat.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Receber.Baixado)=True) AND ((Receber.Inativo)=False) AND ((Receber.Empresa)=" & CodEmpresa & ")) GROUP BY '1.0-Recebimento', Receber.LocalPgto HAVING (((Receber.LocalPgto)<>'CHEQUE PRE-DATADO')) UNION SELECT '1.1-Recebimento Alternado Para:' AS IDD, Receber.LocalPgto, Sum(Receber.ValorLiquido) AS Credito, Sum(0) AS Debito FROM Receber WHERE (((Receber.Recebimento) Between #" & Format(CDate(My.Forms.CaixaRelat.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(My.Forms.CaixaRelat.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Receber.Baixado)=True) AND ((Receber.Inativo)=False) AND ((Receber.Empresa)=" & CodEmpresa & ")) GROUP BY '1.1-Recebimento Alternado Para:', Receber.LocalPgto HAVING (((Receber.LocalPgto)='CHEQUE PRE-DATADO')) UNION SELECT '1.2-Recebimento' AS IDD, 'CHEQUE PRE-DATADO BAIXADO' AS LocalPgto, Sum(ArquivoCheque.ValorCh) AS Credito, Sum(0) AS Debito FROM ArquivoCheque WHERE (((ArquivoCheque.DataBaixa) Between #" & Format(CDate(My.Forms.CaixaRelat.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(My.Forms.CaixaRelat.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((ArquivoCheque.Empresa)=" & CodEmpresa & ")) GROUP BY '1.2-Recebimento', 'CHEQUE PRE-DATADO BAIXADO' UNION SELECT '2.0-Pagamento' AS IDD, Pagar.LocalPgto, Sum(0) AS Credito, Sum(Pagar.ValorLiquido) AS Debito FROM(Pagar) WHERE (((Pagar.Pagamento) Between #" & Format(CDate(My.Forms.CaixaRelat.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(My.Forms.CaixaRelat.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Pagar.Baixado)=True) AND ((Pagar.Inativo)=False) AND ((Pagar.Empresa)=" & CodEmpresa & ")) GROUP BY '2.0-Pagamento', Pagar.LocalPgto UNION SELECT Last('3.0-Caixa') AS IDD, Last('Caixa dia ' & [DataCaixaDia]) AS LocalPgto, Last(CaixaCriados.SaldoDia) AS Credito, Last(0) AS Debito FROM(CaixaCriados) WHERE (((CaixaCriados.DataCaixaDia) Between #" & Format(CDate(My.Forms.CaixaRelat.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(My.Forms.CaixaRelat.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((CaixaCriados.Empresa)=" & CodEmpresa & ")) UNION SELECT '4.0-Bancos' AS IDD, [NomeBanco] & ' - ' & [Banco].[ContaCorrente] AS LocalPgto, Sum(IIf([TipoLancamento]='D',[ValorDocumento],[ValorDocumento]*-1)) AS Credito, 0 AS Debito FROM LancamentoBanco INNER JOIN Banco ON LancamentoBanco.ContaCorrente = Banco.Codigo WHERE (((LancamentoBanco.DataLancamento)<=#" & Format(CDate(My.Forms.CaixaRelat.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((LancamentoBanco.CaiuBanco)='S') AND ((LancamentoBanco.Empresa)=" & CodEmpresa & ") AND ((Banco.AgruparFluxoCaixa)=True)) GROUP BY '4.0-Bancos', [NomeBanco] & ' - ' & [Banco].[ContaCorrente], 0"

            Dim DA As New OleDb.OleDbDataAdapter(Sql, Cnn)
            DA.Fill(DS, "CaixaSintetico")

            Sql = "Select * From Empresa Where CódigoEmpresa = " & CodEmpresa
            Dim daEmpresa As New OleDb.OleDbDataAdapter(Sql, Cnn)
            daEmpresa.Fill(DS, "Empresa")

            Dim NomeEmpresa = DS.Tables("Empresa").Rows(0).Item("RazãoSocial").ToString


            Dim Relat As New ReportDocument()
            Relat.Load(DirRelat & "CaixaSintetico.rpt")

            Relat.DataDefinition.FormulaFields.Item("SaldoAnteriorBanco").Text = "'" + FormatNumber(DS.Tables("SaldoInicialBanco").Rows(0)("Credito").ToString, 2) + "'"
            Relat.DataDefinition.FormulaFields.Item("SaldoAnteriorCaixa").Text = "'" + FormatNumber(DS.Tables("SaldoInicialCaixa").Rows(0)("SaldoDia").ToString, 2) + "'"
            Relat.DataDefinition.FormulaFields.Item("Empresa").Text = "'" & NomeEmpresa & "'"
            Relat.DataDefinition.FormulaFields.Item("Titulo").Text = "'Movimento Financeiro no Período de " & My.Forms.CaixaRelat.DataInicial.Text & " a " & My.Forms.CaixaRelat.DataFinal.Text & "'"

            Relat.SetDataSource(DS)

            Me.Visualizador.ReportSource = Relat
        Catch Ex As Exception
            MessageBox.Show("Dados Inexistente para gerar o relatório, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try


    End Sub

#End Region


#Region "RelOrdemCompra"
    'Gera relatório agrupado por mês e gera Gráficos
    Private Sub RelOrdemCompra()

        Try
            Me.Cursor = Cursors.WaitCursor

            Dim VerRelat As New ReportDocument()
            VerRelat.Load(DirRelat & "RelOrdemCompra.rpt")

            Dim logOnInfo As New TableLogOnInfo()
            Dim i As Integer
            For i = 0 To VerRelat.Database.Tables.Count - 1
                logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                logOnInfo.ConnectionInfo.UserID = ""
                logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
            Next i


            Dim SelectFormula As String
            SelectFormula = "{CompraCtrlPedido.ID} = " & My.Forms.CompraCtrPedido.Id.Text & " and {CompraCtrlPedido.Empresa} = " & CodEmpresa
            Visualizador.SelectionFormula = SelectFormula

            Me.Visualizador.ReportSource = VerRelat
            Me.Cursor = Cursors.Default


            'Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            'Cnn.Open()

            'Dim DS As New DataSet()
            'Dim Sql As String = String.Empty

            'Try
            '    Sql = "SELECT  * From CompraCtrlPedido WHERE Id = " & My.Forms.CompraCtrPedido.Id.Text
            '    Dim DAOrdemCompra As New OleDb.OleDbDataAdapter(Sql, Cnn)
            '    DAOrdemCompra.Fill(DS, "CompraCtrlPedido")


            '    Sql = "SELECT CompraCtrlPedidoItens.Codigo, CompraCtrlPedidoItens.IdPedido, CompraCtrlPedidoItens.Produto, Produtos.Descrição, CompraCtrlPedidoItens.Qtd, CompraCtrlPedidoItens.ValorUnitario, CompraCtrlPedidoItens.ValorTotal FROM CompraCtrlPedidoItens INNER JOIN Produtos ON CompraCtrlPedidoItens.Produto = Produtos.CodigoProduto WHERE (((CompraCtrlPedidoItens.IdPedido)=" & My.Forms.CompraCtrPedido.Id.Text & "));"
            '    Dim DAOrdemCompraItens As New OleDb.OleDbDataAdapter(Sql, Cnn)
            '    DAOrdemCompraItens.Fill(DS, "CompraCtrlPedidoItens")


            '    Dim Relat As New ReportDocument()
            '    'Relat.Load(DirRelat & "RelOrdemCompra.rpt")
            '    Relat.Load(DirRelat & "RelOrdemCompra.rpt")

            '    Relat.SetDataSource(DS)
            '    Me.Visualizador.ReportSource = Relat

        Catch Ex As Exception
            MessageBox.Show("Dados Inexistente para gerar o relatório, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
#End Region

#Region "RelClientes"
    Private Sub Clientes()
        Me.Cursor = Cursors.WaitCursor
        Dim VerRelat As New ReportDocument()
        VerRelat.Load(DirRelat & "RelClientes.rpt")

        Dim logOnInfo As New TableLogOnInfo()
        Dim i As Integer
        For i = 0 To VerRelat.Database.Tables.Count - 1
            logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.UserID = ""
            logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
            VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
        Next i

        Dim vCriterio() As String = Split(My.Forms.ClientesRalatorios.Filter, "-")

        Dim ss As Integer = vCriterio.Length

        Select Case ss
            Case 1

                VerRelat.DataDefinition.RecordSelectionFormula = vCriterio(0)
            Case 2
                VerRelat.DataDefinition.RecordSelectionFormula = vCriterio(0) & " And " & vCriterio(1)
            Case 3
                VerRelat.DataDefinition.RecordSelectionFormula = vCriterio(0) & " And " & vCriterio(1) & " And " & vCriterio(2)
            Case 4
                VerRelat.DataDefinition.RecordSelectionFormula = vCriterio(0) & " And " & vCriterio(1) & " And " & vCriterio(2) & " And " & vCriterio(3)
        End Select

        Select Case My.Forms.ClientesRalatorios.optValue
            Case "1"
                VerRelat.DataDefinition.FormulaFields.Item("xx").Text = "'" & "1" & "'"
            Case "2"
                VerRelat.DataDefinition.FormulaFields.Item("xx").Text = "'" & "2" & "'"
            Case "3"
                VerRelat.DataDefinition.FormulaFields.Item("xx").Text = "'" & "3" & "'"
        End Select


        If My.Forms.ClientesRalatorios.NomeMunic.Checked = True Then

        End If


        Me.Visualizador.ReportSource = VerRelat
        Me.Cursor = Cursors.Default
    End Sub
#End Region

#Region "RelFornecedor"
    'Função para classicar o relatorio por ordem alfa ou numerica Crescente ou Decrescente.
    Private Sub UpdateSortField(ByVal myReportDocument As ReportDocument, ByVal tableName As String, ByVal fieldName As String)
        Dim myDatabaseFieldDefinition As DatabaseFieldDefinition

        myDatabaseFieldDefinition = myReportDocument.Database.Tables.Item(tableName).Fields.Item(fieldName)

        Dim mySortField As SortField = myReportDocument.DataDefinition.SortFields.Item(0)
        mySortField.Field = myDatabaseFieldDefinition

        If My.Forms.FornecedorRelatorio.opt1.Checked = True Then
            mySortField.SortDirection = SortDirection.AscendingOrder
        Else
            mySortField.SortDirection = SortDirection.AscendingOrder
        End If
    End Sub

    Private Sub Fornecedor()
        Me.Cursor = Cursors.WaitCursor
        Dim VerRelat As New ReportDocument()
        VerRelat.Load(DirRelat & "RelFornecedor.rpt")

        Dim logOnInfo As New TableLogOnInfo()
        Dim i As Integer
        For i = 0 To VerRelat.Database.Tables.Count - 1
            logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.UserID = ""
            logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
            VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)

        Next i
        'Verifica qual opção foi definida
        If My.Forms.FornecedorRelatorio.opt1.Checked = True Then
            UpdateSortField(VerRelat, "command", "RazãoSocial")
        Else
            UpdateSortField(VerRelat, "command", "CódigoFornecedor")
        End If


        Me.Visualizador.ReportSource = VerRelat
        Me.Cursor = Cursors.Default
    End Sub
#End Region

#Region "ImpressNP"
    Private Sub ImpressNP()
        Me.Cursor = Cursors.WaitCursor

        Dim VerRelat As New ReportDocument()
        VerRelat.Load(DirRelat & "RelNotaPromissoria.rpt")

        Dim logOnInfo As New TableLogOnInfo()
        Dim i As Integer
        For i = 0 To VerRelat.Database.Tables.Count - 1
            logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.UserID = ""
            logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
            VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
        Next i

        Dim SelectFormula As String = String.Empty
        If My.Forms.PedidoVendaConfirmarOS.Visible = True Then SelectFormula = "{Receber.PedidoProdutos} =" & My.Forms.PedidoOS.PedidoSequencia.Text & " and isnull({Receber.Recebimento})"
        If My.Forms.PedidoVendaConfirmar.Visible = True Then SelectFormula = "{Receber.PedidoProdutos} =" & My.Forms.PedidoVenda.PedidoSequencia.Text & " and isnull({Receber.Recebimento})"
        If My.Forms.ImprimirDuplicataNP.Visible = True Then SelectFormula = "{Receber.PedidoProdutos} =" & My.Forms.ImprimirDuplicataNP.PedidoSequencia.Text & " and isnull({Receber.Recebimento})"
        If My.Forms.SellShoesFinalizar.Visible = True Then SelectFormula = "{Receber.PedidoProdutos} =" & My.Forms.SellShoes.Venda.Text & " and isnull({Receber.Recebimento})"

        Visualizador.SelectionFormula = SelectFormula

        Me.Visualizador.ReportSource = VerRelat
        Me.Cursor = Cursors.Default

    End Sub
#End Region

#Region "ImpressDP"
    Private Sub ImpressDP()
        Me.Cursor = Cursors.WaitCursor

        Dim VerRelat As New ReportDocument()
        VerRelat.Load(DirRelat & "RelDuplicatas.rpt")

        Dim logOnInfo As New TableLogOnInfo()
        Dim i As Integer
        For i = 0 To VerRelat.Database.Tables.Count - 1
            logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
            logOnInfo.ConnectionInfo.UserID = ""
            logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
            VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
        Next i

        Dim SelectFormula As String = String.Empty
        If My.Forms.PedidoVendaConfirmarOS.Visible = True Then SelectFormula = "{Receber.PedidoProdutos} =" & My.Forms.PedidoOS.PedidoSequencia.Text & " and isnull({Receber.Recebimento})"
        If My.Forms.PedidoVendaConfirmar.Visible = True Then SelectFormula = "{Receber.PedidoProdutos} =" & My.Forms.PedidoVenda.PedidoSequencia.Text & " and isnull({Receber.Recebimento})"
        If My.Forms.ImprimirDuplicataNP.Visible = True Then SelectFormula = "{Receber.PedidoProdutos} =" & My.Forms.ImprimirDuplicataNP.PedidoSequencia.Text & " and isnull({Receber.Recebimento})"

        Visualizador.SelectionFormula = SelectFormula

        Me.Visualizador.ReportSource = VerRelat
        Me.Cursor = Cursors.Default

    End Sub
#End Region


#Region "CurvaABC"
    Private Sub RelCurvaABC()


        Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim DS As New DataSet()
        Dim Sql As String = String.Empty


        Try

            Dim DataInicial As Date = CDate(My.Forms.ProdutoRelat.DataInicial.Text)
            Dim DataFinal As Date = CDate(My.Forms.ProdutoRelat.DataFinal.Text)

            'Sql = "SELECT EstoqueUP.CodigoProduto, Produtos.Descrição, Produtos.ValorCompra, Sum([Qtd]*-1) AS Consumo, [ValorCompra]*[Consumo] AS ValorConsumo, cdbl('1.11111') AS Percentual, 0 AS Classificacao, '-' AS CurvaABC, EstoqueUP.Tipo, Produtos.CódigoGrupo, Grupos.Descrição AS DescGrupo, Produtos.SubGrupo, SubGrupo.SubGrupoDesc, Produtos.TipoGrupo, TipoGrupo.TipoGrupoDesc FROM (((EstoqueUP INNER JOIN Produtos ON EstoqueUP.CodigoProduto = Produtos.CodigoProduto) LEFT JOIN Grupos ON Produtos.CódigoGrupo = Grupos.CódigoGrupo) LEFT JOIN SubGrupo ON Produtos.SubGrupo = SubGrupo.Codigo) LEFT JOIN TipoGrupo ON Produtos.TipoGrupo = TipoGrupo.Codigo WHERE (((EstoqueUP.DataLancamento) Between #" & Format(CDate(DataInicial), "MM/dd/yyyy") & "# And #" & Format(CDate(DataFinal), "MM/dd/yyyy") & "#)) GROUP BY EstoqueUP.CodigoProduto, Produtos.Descrição, Produtos.ValorCompra, '-', EstoqueUP.Tipo, Produtos.CódigoGrupo, Grupos.Descrição, Produtos.SubGrupo, SubGrupo.SubGrupoDesc, Produtos.TipoGrupo, TipoGrupo.TipoGrupoDesc HAVING   (((Produtos.ValorCompra)>0) AND ((Sum([Qtd]*-1))>0) AND ((EstoqueUP.Tipo)='S')) order by ([ValorCompra] * Sum([Qtd]*-1)) DESC;"
            Sql = "SELECT EstoqueUP.CodigoProduto, Produtos.Descrição, Produtos.QuantidadeEstoque AS EstoqueAtual, Produtos.ValorCompra, Sum([Qtd]*-1) AS Consumo, [ValorCompra]*[Consumo] AS ValorConsumo, CDbl('1.11111') AS Percentual, 0 AS Classificacao, '-' AS CurvaABC, EstoqueUP.Tipo, Produtos.CódigoGrupo, Grupos.Descrição AS DescGrupo, Produtos.SubGrupo, SubGrupo.SubGrupoDesc, Produtos.TipoGrupo, TipoGrupo.TipoGrupoDesc FROM (((EstoqueUP INNER JOIN Produtos ON EstoqueUP.CodigoProduto = Produtos.CodigoProduto) LEFT JOIN Grupos ON Produtos.CódigoGrupo = Grupos.CódigoGrupo) LEFT JOIN SubGrupo ON Produtos.SubGrupo = SubGrupo.Codigo) LEFT JOIN TipoGrupo ON Produtos.TipoGrupo = TipoGrupo.Codigo WHERE (((EstoqueUP.DataLancamento) Between #" & Format(CDate(DataInicial), "MM/dd/yyyy") & "# And #" & Format(CDate(DataFinal), "MM/dd/yyyy") & "#)) GROUP BY EstoqueUP.CodigoProduto, Produtos.Descrição, Produtos.QuantidadeEstoque, Produtos.ValorCompra, '-', EstoqueUP.Tipo, Produtos.CódigoGrupo, Grupos.Descrição, Produtos.SubGrupo, SubGrupo.SubGrupoDesc, Produtos.TipoGrupo, TipoGrupo.TipoGrupoDesc HAVING (((Produtos.ValorCompra)>0) AND ((Sum([Qtd]*-1))>0) AND ((EstoqueUP.Tipo)='S')) ORDER BY ([ValorCompra]*Sum([Qtd]*-1)) DESC;"

            Dim DACurvaABC As New OleDb.OleDbDataAdapter(Sql, Cnn)
            DACurvaABC.Fill(DS, "CurvaABC")


            DS.Tables("CurvaABC").DefaultView.Sort = DS.Tables("CurvaABC").Columns(2).ColumnName & " DESC"

            Dim VlrConsumoACUMULADO = FormatNumber(NzZero(DS.Tables("CurvaABC").Compute("sum(ValorConsumo)", "")), 3)
            Dim TotREGISTROS As Double = FormatNumber(NzZero(DS.Tables("CurvaABC").Compute("count(CodigoProduto)", "")))

            Dim A As Double = 20
            Dim B As Double = 30
            Dim C As Double = 50

            Dim TitemA As Integer = TotREGISTROS * A / 100
            Dim TitemB As Integer = TotREGISTROS * B / 100
            Dim TitemC As Integer = TotREGISTROS * C / 100

            Dim VarABC As String = String.Empty

            Dim Seq As Double = 1
            Dim Linha As DataRow
            For Each Linha In DS.Tables("CurvaABC").Rows

                If Not IsDBNull(Linha) Then
                    Linha.BeginEdit()
                    Linha("Percentual") = FormatNumber((NzZero(Linha("ValorConsumo").ToString) / NzZero(VlrConsumoACUMULADO)) * 100, 5)
                    Linha("Classificacao") = CInt(Seq)

                    If TitemA > -1 Then
                        Linha("CurvaABC") = "A"
                        TitemA -= 1
                    End If

                    If TitemA = -1 Then
                        If TitemB > -1 Then
                            Linha("CurvaABC") = "B"
                            TitemB -= 1
                        End If
                    End If

                    If TitemB = -1 Then
                        If TitemC > 0 Then
                            Linha("CurvaABC") = "C"
                            TitemC -= 1
                        End If
                    End If

                    Linha.EndEdit()
                    Seq += 1
                End If
            Next


            Sql = "Select * From Empresa Where CódigoEmpresa = " & CodEmpresa
            Dim daEmpresa As New OleDb.OleDbDataAdapter(Sql, Cnn)
            daEmpresa.Fill(DS, "Empresa")

            Dim NomeEmpresa = DS.Tables("Empresa").Rows(0).Item("RazãoSocial").ToString


            Dim Relat As New ReportDocument()
            Relat.Load(DirRelat & "RelCurvaABC.rpt")

            Relat.DataDefinition.FormulaFields.Item("xEmpresa").Text = "'" & NomeEmpresa & "'"
            Relat.DataDefinition.FormulaFields.Item("xTitulo").Text = "'Curva ABC no Período de " & My.Forms.ProdutoRelat.DataInicial.Text & " a " & My.Forms.ProdutoRelat.DataFinal.Text & "'"

            Relat.DataDefinition.FormulaFields.Item("DataInicial").Text = "'" & My.Forms.ProdutoRelat.DataInicial.Text & "'"
            Relat.DataDefinition.FormulaFields.Item("DataFinal").Text = "'" & My.Forms.ProdutoRelat.DataFinal.Text & "'"

            Relat.SetDataSource(DS)

            Me.Visualizador.ReportSource = Relat
        Catch Ex As Exception
            MsgBox(Ex.Message)
            MessageBox.Show("Dados Inexistente para gerar o relatório, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub
#End Region

#Region "RelContaResultadoPerido"
    Private Sub RelContaResultadoPerido()
        Dim VerRelat As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        VerRelat.Load(DirRelat & "RelContaResultadoPerido.rpt")
        VerRelat.DataSourceConnections.Item(0).SetConnection("", LocalBD & Nome_BD, False)
        VerRelat.DataSourceConnections.Item(0).SetLogon("", Crypto.clsCrypto(SenhaBancoDados, False))


        Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
        T = VerRelat.ReportDefinition.ReportObjects.Item("xPeriodo")
        T.Text = "Contas de Resultados no periodo de " + My.Forms.BalanceteOrcamentarioRelat.DataInicial.Text + " a " + My.Forms.BalanceteOrcamentarioRelat.DataFinal.Text

        Me.Visualizador.SelectionFormula = CrDateBetween("{BalanceteLanc.DataLancamento}", My.Forms.BalanceteOrcamentarioRelat.DataInicial.Text, My.Forms.BalanceteOrcamentarioRelat.DataFinal.Text)
        'VerRelat.RecordSelectionFormula = CrDateBetween("{BalanceteLanc.DataLancamento}", My.Forms.BalanceteOrcamentarioRelat.DataInicial.Text, My.Forms.BalanceteOrcamentarioRelat.DataFinal.Text)
        Me.Visualizador.ReportSource = VerRelat

    End Sub
#End Region


#Region "RelBalancetePeriodo"
    Private Sub RelBalancetePeriodo()


        Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim DS As New DataSet()
        Dim Sql As String = String.Empty


        Try

            Dim DataInicial As Date = CDate(My.Forms.BalanceteOrcamentarioRelat.DataInicial.Text)
            Dim DataFinal As Date = CDate(My.Forms.BalanceteOrcamentarioRelat.DataFinal.Text)

            'Sql = "SELECT ContasG1.DescContaGrupo1, ContasG2.DescContaGrupo2, LancamentoBanco.ContaBalancete, ContasG3.DescContaGrupo3, Sum(LancamentoBanco.ValorDocumento) AS SomaDeValorDocumento FROM (ContasG1 INNER JOIN ContasG2 ON ContasG1.ContaGrupo1 = ContasG2.ContaGrupo1) INNER JOIN (ContasG3 INNER JOIN LancamentoBanco ON ContasG3.ContaGrupo3 = LancamentoBanco.ContaBalancete) ON (ContasG2.ContaGrupo2 = ContasG3.ContaGrupo2) AND (ContasG2.ContaGrupo1 = ContasG3.ContaGrupo1) WHERE (((LancamentoBanco.DataLancamento) Between #" & Format(CDate(DataInicial), "MM/dd/yyyy") & "# And #" & Format(CDate(DataFinal), "MM/dd/yyyy") & "#)) GROUP BY ContasG1.DescContaGrupo1, ContasG2.DescContaGrupo2, LancamentoBanco.ContaBalancete, ContasG3.DescContaGrupo3;"
            Sql = "SELECT ContasG1.DescContaGrupo1, ContasG2.DescContaGrupo2, BalanceteLanc.ContaBalancete, ContasG3.DescContaGrupo3, Sum(BalanceteLanc.ValorDocumento) AS SomaDeValorDocumento FROM BalanceteLanc INNER JOIN ((ContasG1 INNER JOIN ContasG2 ON ContasG1.ContaGrupo1 = ContasG2.ContaGrupo1) INNER JOIN ContasG3 ON (ContasG2.ContaGrupo2 = ContasG3.ContaGrupo2) AND (ContasG2.ContaGrupo1 = ContasG3.ContaGrupo1)) ON BalanceteLanc.ContaBalancete = ContasG3.ContaGrupo3 WHERE (((BalanceteLanc.DataLancamento) Between #" & Format(CDate(DataInicial), "MM/dd/yyyy") & "# And #" & Format(CDate(DataFinal), "MM/dd/yyyy") & "#)) GROUP BY ContasG1.DescContaGrupo1, ContasG2.DescContaGrupo2, BalanceteLanc.ContaBalancete, ContasG3.DescContaGrupo3;"
            Dim DABalancetePeriodo As New OleDb.OleDbDataAdapter(Sql, Cnn)
            DABalancetePeriodo.Fill(DS, "BalancetePeriodo")


            Sql = "Select * From Empresa Where CódigoEmpresa = " & CodEmpresa
            Dim daEmpresa As New OleDb.OleDbDataAdapter(Sql, Cnn)
            daEmpresa.Fill(DS, "Empresa")

            Dim NomeEmpresa = DS.Tables("Empresa").Rows(0).Item("RazãoSocial").ToString


            Dim Relat As New ReportDocument()
            Relat.Load(DirRelat & "RelBalancetePeriodo.rpt")

            Relat.DataDefinition.FormulaFields.Item("xEmpresa").Text = "'" & NomeEmpresa & "'"
            Relat.DataDefinition.FormulaFields.Item("xTitulo").Text = "'Balancete no Período de " & DataInicial & " a " & DataFinal & "'"


            Relat.SetDataSource(DS)

            Me.Visualizador.ReportSource = Relat
        Catch Ex As Exception
            MsgBox(Ex.Message)
            MessageBox.Show("Dados Inexistente para gerar o relatório, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try







    End Sub
#End Region

#Region "Visualizador"

    Private Sub VisualizadorRelatorio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

    End Sub
    Private Sub VisualizadorRelatorio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Select Case RelatorioCarregar
            Case "RelContaResultadoPerido"
                RelContaResultadoPerido()
            Case "RelBalancetePeriodo"
                RelBalancetePeriodo()
            Case "RelCurvaABC"
                RelCurvaABC() 'usado pelo up

            Case "RelCatalogo"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelCatalogo.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim SelectFormula As String
                SelectFormula = "{Produtos.Inativo} = False and {Produtos.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelOrdemProducao"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelOrdemProducao.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim SelectFormula As String
                SelectFormula = "{Producao.OrdemProducao} = " & My.Forms.Producao.OrdemProducao.Text
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelOrdemEntregaPendentes"
                Me.Cursor = Cursors.WaitCursor
                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelOrdemEntregaPendentes.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                VerRelat.DataDefinition.RecordSelectionFormula = "{Pedido.DataPedido}>=Date (" & Format(CDate(My.Forms.PedidoRelat.DataInicial.Text), "yyyy,MM,dd") & ") and {Pedido.DataPedido}<=date(" & Format(CDate(My.Forms.PedidoRelat.DataFinal.Text), "yyyy,MM,dd") & ") AND {Pedido.StatusAndamentos} <>'FINALIZADO'"

                'VerRelat.DataDefinition.FormulaFields.Item("xEstoqueAnterior").Text = "'" & FormatNumber(My.Forms.ProdutoSaldoEstoque.vEstoqueAterior, 2) & "'"
                'VerRelat.DataDefinition.FormulaFields.Item("xPeriodo").Text = "'" & "Período: " & My.Forms.ProdutoSaldoEstoque.DataInicial.Text & " à " & My.Forms.ProdutoSaldoEstoque.DataFinal.Text & "'"


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelSaldoProduto"
                Me.Cursor = Cursors.WaitCursor
                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelSaldoProduto.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                VerRelat.DataDefinition.RecordSelectionFormula = "{EstoqueUP.DataLancamento}>=Date (" & Format(CDate(My.Forms.ProdutoSaldoEstoque.DataInicial.Text), "yyyy,MM,dd") & ") and {EstoqueUP.DataLancamento}<=date(" & Format(CDate(My.Forms.ProdutoSaldoEstoque.DataFinal.Text), "yyyy,MM,dd") & ") and {EstoqueUp.CodigoProduto}=" & My.Forms.ProdutoSaldoEstoque.Produto.Text & "  and {Produtos.Empresa}=" & CodEmpresa


                VerRelat.DataDefinition.FormulaFields.Item("xEstoqueAnterior").Text = "'" & FormatNumber(My.Forms.ProdutoSaldoEstoque.vEstoqueAterior, 2) & "'"
                VerRelat.DataDefinition.FormulaFields.Item("xPeriodo").Text = "'" & "Período: " & My.Forms.ProdutoSaldoEstoque.DataInicial.Text & " à " & My.Forms.ProdutoSaldoEstoque.DataFinal.Text & "'"


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default
            Case "RelCompras"
                Me.Cursor = Cursors.WaitCursor
                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelCompras.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i


                VerRelat.DataDefinition.RecordSelectionFormula = "{Compra.CompraInterno}=" & My.Forms.Compra.CompraInterno.Text


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelSellShoesCompra"
                Me.Cursor = Cursors.WaitCursor
                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelSellShoesCompra.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i


                VerRelat.DataDefinition.RecordSelectionFormula = "{Compra.CompraInterno}=" & SellShoesCompra.CompraInterno.Text


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "Fornecedor"
                Fornecedor() 'usado pelo up
            Case "Clientes" 'Usado pelo Up
                Clientes()
            Case "CaixaSintetico"
                CaixaSintetico()
            Case "RelGrupos" 'Usado pelo Up
                RelCadGerais("RelGrupos")
            Case "RelSubGrupos" 'Usado pelo Up
                RelCadGerais("RelSubGrupos")
            Case "RelTipoGrupos" 'Usado pelo Up
                RelCadGerais("RelTipoGrupos")
            Case "RelMarcas" 'Usado pelo Up
                RelCadGerais("RelMarcas")
            Case "RelCor" 'Usado pelo Up
                RelCadGerais("RelCor")
            Case "RelFotoPropriedade"
                RelFotoPropriedade()
            Case "RelReceberPeriodo"
                'Relatóro de contas a receber no período.
                RelReceberPeriodo()
            Case "RelReceberClienteAgrupado"
                'Relatório de contas a receber do cliente agrupado.
                RelReceberClienteAgrupado()
            Case "ImpressNP"
                ImpressNP() 'usado pelo up
            Case "ImpressDP"
                ImpressDP() 'usado pelo up

            Case "RelReceberPeriodoRegiao"
                RelReceberPeriodoRegiao()

            Case "RelReceberPerdida"
                'Relatório de contas a receber perdida.
                RelReceberPerdida()

            Case "RelHistoricoClientePedidoReceber"
                RelHistoricoClientePedidoReceber()

            Case "RelReceberCliente"
                RelReceberCliente()


            Case "ProdutoAlfa"
                Me.Cursor = Cursors.WaitCursor
                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelProdutoAlfa.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim SelectFormula As String
                SelectFormula = "{Produtos.Inativo} = False and {Produtos.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelProdutoLocalizacao"
                Me.Cursor = Cursors.WaitCursor
                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "Relprodutolocalizacao.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                VerRelat.DataDefinition.RecordSelectionFormula = "{Produtos.Inativo}= False And {ProdutoLocal.SetorLocal} = '" & My.Forms.ProdutoRelat.Local.SelectedValue & "'"


                'VerRelat.DataDefinition.FormulaFields.Item("xEstoqueAnterior").Text = "'" & FormatNumber(My.Forms.ProdutoSaldoEstoque.vEstoqueAterior, 2) & "'"
                'VerRelat.DataDefinition.FormulaFields.Item("xPeriodo").Text = "'" & "Período: " & My.Forms.ProdutoSaldoEstoque.DataInicial.Text & " à " & My.Forms.ProdutoSaldoEstoque.DataFinal.Text & "'"


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default


            Case "RelProdutoCod"

                Me.Cursor = Cursors.WaitCursor
                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelProdutoCod.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim SelectFormula As String
                SelectFormula = "{Produtos.Inativo} = False and {Produtos.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelListaPreco"
                Me.Cursor = Cursors.WaitCursor
                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelListaPreco.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim SelectFormula As String = String.Empty
                If My.Forms.ProdutoRelat.ListaPrecoSelect.Text = "Itens que pertence a Lista de Preço" Then
                    SelectFormula = "{Produtos.Inativo} = False and {Produtos.Empresa} = " & CodEmpresa & " and {Produtos.MostrarListaPreco} = 'S'"
                ElseIf My.Forms.ProdutoRelat.ListaPrecoSelect.Text = "Itens que estão Fora da Lista de Preço" Then
                    SelectFormula = "{Produtos.Inativo} = False and {Produtos.Empresa} = " & CodEmpresa & " and {Produtos.MostrarListaPreco} = 'N'"
                ElseIf My.Forms.ProdutoRelat.ListaPrecoSelect.Text = "Todos os Itens" Then
                    SelectFormula = "{Produtos.Inativo} = False and {Produtos.Empresa} = " & CodEmpresa
                End If

                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelListaPrecoAtacado"
                Me.Cursor = Cursors.WaitCursor
                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelListaPrecoAtacado.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim SelectFormula As String = String.Empty
                SelectFormula = "{Produtos.Inativo} = False and {Produtos.Empresa} = " & CodEmpresa

                Visualizador.SelectionFormula = SelectFormula
                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default


            Case "RelListaPrecoMarca"
                Try
                    Me.Cursor = Cursors.WaitCursor
                    Dim VerRelat As New ReportDocument()
                    VerRelat.Load(DirRelat & "RelListaPrecoMarca.rpt")

                    Dim logOnInfo As New TableLogOnInfo()
                    Dim i As Integer
                    For i = 0 To VerRelat.Database.Tables.Count - 1
                        logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                        logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                        logOnInfo.ConnectionInfo.UserID = ""
                        logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                        VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                    Next i

                    Dim SelectFormula As String
                    SelectFormula = "{Produtos.Inativo} = False and {Produtos.Empresa} = " & CodEmpresa & " and {Produtos.MostrarListaPreco} = 'S' "
                    Visualizador.SelectionFormula = SelectFormula


                    Me.Visualizador.ReportSource = VerRelat
                    Me.Cursor = Cursors.Default
                Catch ex As Exception
                    MsgBox("Houve um erro ao abrir o relatório", 48, "Validação de dados")

                End Try
               

            Case "OrdemCompraPeriodo"
                Me.Cursor = Cursors.WaitCursor
                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "OrdemCompraPeriodo.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                If My.Forms.OrdemCompraRelat.A1.Checked = True Then
                    VerRelat.DataDefinition.RecordSelectionFormula = "{CompraCtrlPedido.DataPedido}>=Date (" & Format(CDate(My.Forms.OrdemCompraRelat.DataInicial.Text), "yyyy,MM,dd") & ") and {CompraCtrlPedido.DataPedido}<=date(" & Format(CDate(My.Forms.OrdemCompraRelat.DataFinal.Text), "yyyy,MM,dd") & ") and {CompraCtrlPedido.confirmado}=false "
                Else
                    VerRelat.DataDefinition.RecordSelectionFormula = "{CompraCtrlPedido.DataPedido}>=Date (" & Format(CDate(My.Forms.OrdemCompraRelat.DataInicial.Text), "yyyy,MM,dd") & ") and {CompraCtrlPedido.DataPedido}<=date(" & Format(CDate(My.Forms.OrdemCompraRelat.DataFinal.Text), "yyyy,MM,dd") & ") and {CompraCtrlPedido.confirmado}=true and {CompraCtrlPedido.Empresa}=" & CodEmpresa
                End If

                VerRelat.DataDefinition.FormulaFields.Item("xUser").Text = "'" & "Usuário: " & UserAtivo & "'"
                VerRelat.DataDefinition.FormulaFields.Item("xPeriodo").Text = "'" & "Período: " & My.Forms.OrdemCompraRelat.DataInicial.Text & " à " & My.Forms.OrdemCompraRelat.DataFinal.Text & "'"


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelReceberProrrogadasGeral" 'Usado pelo Up
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelReceberProrrogada.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Contas a Receber Prorrogadas"

                Dim SelectFormula As String
                SelectFormula = "{Receber.Baixado} = False and {Receber.Inativo} = False and {Receber.CartaoCredito} = False and {Receber.Prorrogada} = True and {Receber.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default


            Case "RelReceberLocal" 'usado pelo up
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelReceberLocal.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Contas a Receber por local no Período de : " & My.Forms.ReceberRelat.DataInicial.Text & " a " & My.Forms.ReceberRelat.DataFinal.Text

                Dim SelectFormula As String
                SelectFormula = CrDateBetween("{Receber.Vencimento}", My.Forms.ReceberRelat.DataInicial.Text, My.Forms.ReceberRelat.DataFinal.Text) & " and {Receber.Baixado} = False and {Receber.Inativo} = False And {Receber.CartaoCredito} = False and {Receber.Prorrogada} = False and {Receber.Empresa} = " & CodEmpresa & " and {Receber.LocalPgto} = '" & My.Forms.ReceberRelat.Local.Text & "'"
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default


            Case "RelReceberCidade" 'Usado pelo up
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelReceberLocal.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Contas a Receber por Cidade no Período de : " & My.Forms.ReceberRelat.DataInicial.Text & " a " & My.Forms.ReceberRelat.DataFinal.Text

                Dim SelectFormula As String
                SelectFormula = CrDateBetween("{Receber.Vencimento}", My.Forms.ReceberRelat.DataInicial.Text, My.Forms.ReceberRelat.DataFinal.Text) & " and {Receber.Baixado} = False and {Receber.Inativo} = False And {Receber.CartaoCredito} = False and {Receber.Prorrogada} = False and {Receber.Empresa} = " & CodEmpresa & " and {Clientes.Cidade} = '" & My.Forms.ReceberRelat.Cidade.Text & "'"
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelRecebidaPeriodo" ' Usado pelo Up
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelRecebido.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Conta Recebidas no Período de : " & My.Forms.ReceberRelat.DataInicial.Text & " a " & My.Forms.ReceberRelat.DataFinal.Text

                Dim SelectFormula As String
                SelectFormula = CrDateBetween("{Receber.Recebimento}", My.Forms.ReceberRelat.DataInicial.Text, My.Forms.ReceberRelat.DataFinal.Text) & " and {Receber.Baixado} = true And {Receber.CartaoCredito} = False and {Receber.Empresa} = " & CodEmpresa
                VerRelat.DataDefinition.FormulaFields.Item("xUser").Text = "'" & "Usuário: " & UserAtivo & "'"

                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelRecebidaCliente"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelRecebido.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Contas Recebida por Cliente"

                Dim SelectFormula As String

                If My.Forms.ReceberRelat.DataInicial.Text = "" Then
                    SelectFormula = "{Receber.CodCliente} = " & My.Forms.ReceberRelat.Cliente.Text & " and {Receber.Baixado} = True And {Receber.CartaoCredito} = False and {Receber.Empresa} = " & CodEmpresa
                Else
                    SelectFormula = CrDateBetween("{Receber.Recebimento}", My.Forms.ReceberRelat.DataInicial.Text, My.Forms.ReceberRelat.DataFinal.Text) & " and {Receber.CodCliente} = " & My.Forms.ReceberRelat.Cliente.Text & " and {Receber.Baixado} = True And {Receber.CartaoCredito} = False and {Receber.Empresa} = " & CodEmpresa
                End If

                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelReceberVencidasCliente" 'Usado pelo Up
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelReceberVencida.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Contas Vencidas por Cliente"

                Dim SelectFormula As String
                Dim vDate As DateTime = Today
                ' VerRelat.DataDefinition.RecordSelectionFormula = "{CompraCtrlPedido.DataPedido}>=Date (" & Format(CDate(My.Forms.OrdemCompraRelat.DataInicial.Text), "yyyy,MM,dd") & ") and {CompraCtrlPedido.DataPedido}<=date(" & Format(CDate(My.Forms.OrdemCompraRelat.DataFinal.Text), "yyyy,MM,dd") & ") and {CompraCtrlPedido.confirmado}=true and {CompraCtrlPedido.Empresa}=" & CodEmpresa

                SelectFormula = "{ReceberVencidas.Vencimento} <date (" & Format(CDate(vDate), "yyyy,MM,dd") & ") And {ReceberVencidas.CodCliente} = " & My.Forms.ReceberRelat.Cliente.Text & " and {ReceberVencidas.Empresa} = " & CodEmpresa & " and {ReceberVencidas.Baixado} = False And {ReceberVencida.CartaoCredito} = False and {ReceberVencidas.ContaPerdida} = False and {ReceberVencidas.Inativo} = False and {Recebervencidas.Prorrogada} = False"
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelReceberVencidasGeral" ' Usado pelo Up
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelReceberVencida.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Contas Vencidas (Todas)"

                Dim SelectFormula As String
                SelectFormula = "{recebervencidas.Vencimento} <= DateTime (" & Year(DataDia) & "," & Month(DataDia) & "," & Microsoft.VisualBasic.Day(DataDia) & ", 00, 00, 00)" & " and {recebervencidas.Empresa} = " & CodEmpresa & " and {recebervencidas.Baixado} = False And {receberVencidas.CartaoCredito} = False and {recebervencidas.ContaPerdida} = False and {recebervencidas.Inativo} = False and {recebervencidas.Prorrogada} = False"
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelReceberPeriodoValor" 'Usado pelo UP
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelReceberPeriodoValor.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Conta a Receber no Período de : " & My.Forms.ReceberRelatPeriodoValor.DataInicial.Text & " a " & My.Forms.ReceberRelatPeriodoValor.DataFinal.Text

                Dim SelectFormula As String = ""

                If My.Forms.ReceberRelatPeriodoValor.A1.Checked = True Then
                    SelectFormula = CrDateBetween("{Receber.Vencimento}", My.Forms.ReceberRelatPeriodoValor.DataInicial.Text, My.Forms.ReceberRelatPeriodoValor.DataFinal.Text) & " and {Receber.Baixado} = False And {Receber.CartaoCredito} = False and {Receber.Empresa} = " & CodEmpresa & " and {Receber.ValorDocumento} = " & CDbl(My.Forms.ReceberRelatPeriodoValor.Vlr1.Text)
                ElseIf My.Forms.ReceberRelatPeriodoValor.A2.Checked = True Then
                    SelectFormula = CrDateBetween("{Receber.Vencimento}", My.Forms.ReceberRelatPeriodoValor.DataInicial.Text, My.Forms.ReceberRelatPeriodoValor.DataFinal.Text) & " and {Receber.Baixado} = False And {Receber.CartaoCredito} = False and {Receber.Empresa} = " & CodEmpresa & " and {Receber.ValorDocumento} > " & CDbl(My.Forms.ReceberRelatPeriodoValor.Vlr1.Text)
                ElseIf My.Forms.ReceberRelatPeriodoValor.A3.Checked = True Then
                    SelectFormula = CrDateBetween("{Receber.Vencimento}", My.Forms.ReceberRelatPeriodoValor.DataInicial.Text, My.Forms.ReceberRelatPeriodoValor.DataFinal.Text) & " and {Receber.Baixado} = False And {Receber.CartaoCredito} = False and {Receber.Empresa} = " & CodEmpresa & " and {Receber.ValorDocumento} < " & CDbl(My.Forms.ReceberRelatPeriodoValor.Vlr1.Text)
                ElseIf My.Forms.ReceberRelatPeriodoValor.A4.Checked = True Then
                    SelectFormula = CrDateBetween("{Receber.Vencimento}", My.Forms.ReceberRelatPeriodoValor.DataInicial.Text, My.Forms.ReceberRelatPeriodoValor.DataFinal.Text) & " and {Receber.Baixado} = False And {Receber.CartaoCredito} = False and {Receber.Empresa} = " & CodEmpresa & " and {Receber.ValorDocumento} in " & CDbl(My.Forms.ReceberRelatPeriodoValor.Vlr1.Text) & " to " & CDbl(My.Forms.ReceberRelatPeriodoValor.Vlr2.Text)
                End If

                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

                '*******************************************************
                'Tratar Relatórios de contas a pagar

            Case "RelPagarPeriodo" 'Usado Pelo Up
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelPagar.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Contas a Pagar no Período de : " & My.Forms.PagarRelat.DataInicial.Text & " a " & My.Forms.PagarRelat.DataFinal.Text
                VerRelat.DataDefinition.FormulaFields.Item("xUser").Text = "'" & "Usuário: " & UserAtivo & "'"

                Dim SelectFormula As String
                SelectFormula = CrDateBetween("{Pagar.Vencimento}", My.Forms.PagarRelat.DataInicial.Text, My.Forms.PagarRelat.DataFinal.Text) & " and {Pagar.Baixado} = False and {Pagar.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default



            Case "RelPagarAgrupadoPorData"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelPagarAgrupadoPorData.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Contas a Pagar no Período de : " & My.Forms.PagarRelat.DataInicial.Text & " a " & My.Forms.PagarRelat.DataFinal.Text
                VerRelat.DataDefinition.FormulaFields.Item("xUser").Text = "'" & "Usuário: " & UserAtivo & "'"

                Dim SelectFormula As String
                SelectFormula = CrDateBetween("{Pagar.Vencimento}", My.Forms.PagarRelat.DataInicial.Text, My.Forms.PagarRelat.DataFinal.Text) & " and {Pagar.Baixado} = False and {Pagar.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default


            Case "RelPagarPeriodoLocal" 'Usado Pelo Up
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelPagarPeriodoLocal.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Contas a Pagar no Período de : " & My.Forms.PagarRelat.DataInicial.Text & " a " & My.Forms.PagarRelat.DataFinal.Text

                Dim SelectFormula As String
                SelectFormula = CrDateBetween("{Pagar.Vencimento}", My.Forms.PagarRelat.DataInicial.Text, My.Forms.PagarRelat.DataFinal.Text) & " and {Pagar.Baixado} = False and {Pagar.Empresa} = " & CodEmpresa & " And {Pagar.LocalPgto} = '" & My.Forms.PagarRelat.Local.Text & "'"
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default



            Case "RelPagarFornecedor" 'Usado pelo up
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelPagar.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Contas a Pagar por Fornecedor"

                VerRelat.DataDefinition.FormulaFields.Item("xUser").Text = "'" & "Usuário: " & UserAtivo & "'"


                Dim SelectFormula As String = String.Empty

                If My.Forms.PagarRelat.DataInicial.Text = "" Then
                    SelectFormula = "{Pagar.CodFornecedor} = " & My.Forms.PagarRelat.Fornecedor.Text & " and {Pagar.Baixado} = False and {Pagar.Empresa} = " & CodEmpresa
                Else
                    SelectFormula = CrDateBetween("{Pagar.Vencimento}", My.Forms.PagarRelat.DataInicial.Text, My.Forms.PagarRelat.DataFinal.Text) & " and {Pagar.CodFornecedor} = " & My.Forms.PagarRelat.Fornecedor.Text & " and {Pagar.Baixado} = False and {Pagar.Empresa} = " & CodEmpresa
                End If
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default


            Case "RelPagarVencidasFornecedor" 'Usado pelo Up
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelPagarVencidas.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Contas a Pagar Vencidas por Fornecedor"


                Dim SelectFormula As String
                SelectFormula = "{pagarVencidas.Vencimento} <= DateTime (" & Year(DataDia) & "," & Month(DataDia) & "," & Microsoft.VisualBasic.Day(DataDia) & ", 00, 00, 00)" & " and {pagarvencidas.CodFornecedor} = " & My.Forms.PagarRelat.Fornecedor.Text & " and {pagarvencidas.Baixado} = False and {pagarvencidas.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelPagarVencidasGeral" 'usada pelo Up
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelPagarVencidas.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Contas a Pagar Vencidas (Geral)"


                Dim SelectFormula As String
                SelectFormula = "{pagarVencidas.Vencimento} <= DateTime (" & Year(DataDia) & "," & Month(DataDia) & "," & Microsoft.VisualBasic.Day(DataDia) & ", 00, 00, 00)" & "  and {pagarvencidas.Baixado} = False And {pagarvencidas.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelPagasPeriodo" 'Usado pelo Up
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelPagas.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Contas Pagas no Período de : " & My.Forms.PagarRelat.DataInicial.Text & " a " & My.Forms.PagarRelat.DataFinal.Text


                Dim SelectFormula As String
                SelectFormula = CrDateBetween("{Pagar.Pagamento}", My.Forms.PagarRelat.DataInicial.Text, My.Forms.PagarRelat.DataFinal.Text) & " and {Pagar.Baixado} = True and {Pagar.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelPagasFornecedor"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelPagas.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Contas Pagas por Fornecedores"


                Dim SelectFormula As String
                SelectFormula = CrDateBetween("{Pagar.Pagamento}", My.Forms.PagarRelat.DataInicial.Text, My.Forms.PagarRelat.DataFinal.Text) & " and {Pagar.CodFornecedor} = " & My.Forms.PagarRelat.Fornecedor.Text & " and {Pagar.Baixado} = True and {Pagar.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default


            Case "RelPagasCheque" 'Usado pelo Up
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelPagasCheque.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Pagamento de Contas por Cheque"


                Dim SelectFormula As String
                SelectFormula = "{Pagar.PagoComChequeNumero} = '" & My.Forms.PagarRelat.Cheque.Text & "' and {Pagar.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelHistoricoFornecedor"


                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelHistoricoFornecedor.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                'Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                'T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                'T.Text = "Contas Pagas por Fornecedores"

                Dim SelectFormula As String
                SelectFormula = "{Fornecedor.CódigoFornecedor} = " & vFornecedor & " and {fornecedor.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default




                'Fim do tratamento de contas a pagar.
                '*****************************************************************

            Case "RelPedidoImpress"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelPedidoReImpress.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim SelectFormula As String
                SelectFormula = "{Pedido.PedidoSequencia} = " & My.Forms.PedidoVenda.PedidoSequencia.Text & " and {Pedido.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelPedidoReImpress"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelPedidoReImpress.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim SelectFormula As String
                SelectFormula = "{Pedido.PedidoSequencia} = " & My.Forms.PedidoReImpress.Pedido.Text & " and {Pedido.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelPedidoImpressCopia"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelPedidoReImpressCopia.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim SelectFormula As String
                SelectFormula = "{Pedido.PedidoSequencia} = " & My.Forms.PedidoVenda.PedidoSequencia.Text & " and {Pedido.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelPedidoReImpressEspelho"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelPedidoReImpressEspelho.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim SelectFormula As String
                SelectFormula = "{Pedido.PedidoSequencia} = " & My.Forms.PedidoReImpress.Pedido.Text & " and {Pedido.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelProdutosCustoProdução"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelProdutosCustoProdução.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Produtos/Custos de Produção"

                Dim SelectFormula As String
                SelectFormula = "{CustosProducaoFolhaPgto.Inativo} = False and {CustosProducaoFolhaPgto.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelFuncionaiosFoto"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelFuncionariosFoto.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Funcionários Geral (Foto)"

                Dim SelectFormula As String
                SelectFormula = "{Funcionários.Inativo} = False and {Funcionários.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelFuncionariosHistorico"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelFuncionariosHistorico.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Histórico de Funcionário"

                Dim SelectFormula As String
                SelectFormula = "{Funcionários.CódigoFuncionário} = " & My.Forms.FuncionariosRelat.Func.Text & " and {Funcionários.Inativo} = False and {Funcionários.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default


            Case "RelFuncionarioAtivos"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelFuncionarioAtivos.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Funcionários Ativos Geral"

                Dim SelectFormula As String
                SelectFormula = "{funcativos.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default


            Case "RelFuncionariosDepartamento"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelFuncionariosDepartamento.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Funcionário por Departamento Geral"

                Dim SelectFormula As String
                SelectFormula = "{funcionariodepartamento.Inativo} = False and {funcionariodepartamento.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelFuncionariosDataAdmissãoPeriodo"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelFuncionariosDataAdmissãoPeriodo.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")

                Dim SelectFormula As String

                If My.Forms.FuncionariosRelat.DataInicial.Text = "" Then
                    T.Text = "Funcionário por Data Admissão (GERAL)"
                Else
                    T.Text = "Funcionário por Data Admissão no Perído de: " & CDate(My.Forms.FuncionariosRelat.DataInicial.Text) & " a " & My.Forms.FuncionariosRelat.DataFinal.Text
                    SelectFormula = CrDateBetween("{FuncionariodataadmissãoPeriodo.DataAdmissão}", My.Forms.FuncionariosRelat.DataInicial.Text, My.Forms.FuncionariosRelat.DataFinal.Text)
                    Visualizador.SelectionFormula = SelectFormula
                End If


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelFuncionariosDepartamentoSeleção"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelFuncionariosDepartamento.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Funcionário por Departamento"

                Dim SelectFormula As String
                SelectFormula = "{funcionariodepartamento.Departamento} = '" & My.Forms.FuncionariosRelat.DepartamentoDesc.Text & "' and {funcionariodepartamento.Inativo} = False and {funcionariodepartamento.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelDepartamentos"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelDepartamentos.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Departamentos"

                Dim SelectFormula As String
                SelectFormula = "{Departamentos.Inativo} = False and {Departamentos.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelProfissão"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelProfissão.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Profissão"

                Dim SelectFormula As String
                SelectFormula = "{Profissao.Inativo} = False and {Profissao.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelOrdemEmbarqueVisualizador"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelOrdemEntrega.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim SelectFormula As String
                SelectFormula = "{ordementrega.Ordem} = " & My.Forms.OrdemEntregaVisualizador.Ordem.Text
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelOrdemEntrega" 'Usado Pelo up
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelOrdemEntrega.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim SelectFormula As String
                SelectFormula = "{ordementrega.Ordem} = " & My.Forms.OrdemEntrega.Ordem.Text
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelProdutoFoto"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelProdutoFoto.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim SelectFormula As String
                SelectFormula = "{ProdutosFoto.CodigoProduto} = " & My.Forms.Produtos.CodigoProduto.Text
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelTipos"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelTipos.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Tipos de Matéria Prima"


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelIndustriaMateriaPrima"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelIndustriaMateriaPrima.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Matéria Prima da Industria"


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default



            Case "RelComposiçãoResumida"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelComposiçãoResumida.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim SelectFormula As String
                SelectFormula = "{ProdutoComposicao.Produto} = " & My.Forms.Produtos.CodigoProduto.Text
                Visualizador.SelectionFormula = SelectFormula


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default


            Case "RelComposiçãoDetalhada"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelComposiçãoDetalhada.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim SelectFormula As String
                SelectFormula = "{ProdutoComposicao.Produto} = " & My.Forms.Produtos.CodigoProduto.Text
                Visualizador.SelectionFormula = SelectFormula


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelCaixa" 'Usado Pelo Up

                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelCaixa.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim SelectFormula As String
                'SelectFormula = CrDateBetween("{LancamentoBanco.DataLancamento}", CDate(My.Forms.Caixa.DataCaixa.Text), CDate(My.Forms.Caixa.DataCaixa.Text)) & " And {LancamentoBanco.ContaCorrente} = '" & My.Forms.Caixa.CaixaCod.Text & "' And {LancamentoBanco.Tipo} = 'CAIXA'"
                SelectFormula = CrDateBetween("{CaixaDia.DataCaixaDia}", CDate(My.Forms.Caixa.DataCaixa.Text), CDate(My.Forms.Caixa.DataCaixa.Text)) & " And {CaixaDia.CaixaCod} = '" & My.Forms.Caixa.CaixaCod.Text & "'"
                Visualizador.SelectionFormula = SelectFormula

                Visualizador.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelExtratoBancario" 'Usado pelo Up
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                If My.Forms.BancoExtrato.opt1.Checked = True Then
                    VerRelat.Load(DirRelat & "RelExtratoBancario.rpt")
                Else
                    VerRelat.Load(DirRelat & "RelExtratoBancarioContabil.rpt")

                End If

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Extrato Bancário no Período de : " & My.Forms.BancoExtrato.DataInicial.Text & " a " & My.Forms.BancoExtrato.DataFinal.Text
                VerRelat.DataDefinition.FormulaFields.Item("xUser").Text = "'" & UserAtivo & "'"
                Dim SelectFormula As String
                SelectFormula = CrDateBetween("{Extrato.DataLancamento}", My.Forms.BancoExtrato.DataInicial.Text, My.Forms.BancoExtrato.DataFinal.Text) & " and {Extrato.Empresa} = " & CodEmpresa & " And {extrato.Tipo} = 'BANCO' And {extrato.ContaCorrente} = '" & My.Forms.BancoVisualizador.Codigo.Text & "'"
                Visualizador.SelectionFormula = SelectFormula


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            
            Case "RelEtiquetaNatal"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelEtiquetaNatal.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default


            Case "RelReciboVendaVista" 'usado pelo up
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelReciboVendaVista.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim SelectFormula As String = ""
                If PedidoOS.Visible = True Then SelectFormula = "{Pedido.PedidoSequencia} = " & My.Forms.PedidoOS.PedidoSequencia.Text
                If PedidoVenda.Visible = True Then SelectFormula = "{Pedido.PedidoSequencia} = " & My.Forms.PedidoVenda.PedidoSequencia.Text

                Visualizador.SelectionFormula = SelectFormula


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelReciboAvulso" 'Usado pelo up
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelReciboAvulso.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim SelectFormula As String
                SelectFormula = "{ReciboAvulso.Recibo} = '" & My.Forms.ReciboAvulso.Recibo.Text & "'"
                Visualizador.SelectionFormula = SelectFormula

                Dim extenso As New ActiveIT.cExtenso()
                VerRelat.DataDefinition.FormulaFields.Item("ImportanciaDe").Text = "'" & extenso.Executar(CDec(My.Forms.ReciboAvulso.ValorDocumento.Text)) & "'"



                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelReciboReceber"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelReciboReceber.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim SelectFormula As String = String.Empty
                If My.Forms.ReceberBaixa.Visible = True Then
                    SelectFormula = "{Receber.Id} = " & My.Forms.ReceberBaixa.Id.Text

                ElseIf My.Forms.ReimpressaoReciboPagarReceber.Visible = True Then
                    SelectFormula = "{Receber.Id} = " & My.Forms.ReimpressaoReciboPagarReceber.vId
                End If
                Visualizador.SelectionFormula = SelectFormula


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "PedidosFaturados"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelPedidosFaturados.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As String

                T = "Pedidos faturados no Período de : " & My.Forms.PedidoRelat.DataInicial.Text & " a " & My.Forms.PedidoRelat.DataFinal.Text
                VerRelat.DataDefinition.FormulaFields.Item("Titulo").Text = "'" & T & "'"

                Dim CB As CrystalDecisions.CrystalReports.Engine.TextObject
                CB = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                CB.Text = T & " - " & My.Forms.PedidoRelat.cboFiltros.Text

                Dim SelectFormula As String

                If My.Forms.PedidoRelat.cboFiltros.Text = "Todos" Then
                    SelectFormula = CrDateBetween("{Pedido.DataFechamento}", My.Forms.PedidoRelat.DataInicial.Text, My.Forms.PedidoRelat.DataFinal.Text) & " and {Pedido.Empresa} = " & CodEmpresa
                Else
                    SelectFormula = CrDateBetween("{Pedido.DataFechamento}", My.Forms.PedidoRelat.DataInicial.Text, My.Forms.PedidoRelat.DataFinal.Text) & " and {Clientes.TpComercio} Like '" & My.Forms.PedidoRelat.cboFiltros.Text & "' and {Pedido.Empresa} = " & CodEmpresa
                End If
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "PedidosFaturadosTP"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelPedidosFaturadosTP.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As String

                T = "Pedidos faturados no Período de : " & My.Forms.PedidoRelat.DataInicial.Text & " a " & My.Forms.PedidoRelat.DataFinal.Text
                VerRelat.DataDefinition.FormulaFields.Item("Titulo").Text = "'" & T & "'"

                Dim CB As CrystalDecisions.CrystalReports.Engine.TextObject
                CB = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                CB.Text = T & " - " & My.Forms.PedidoRelat.cboFiltros.Text

                Dim SelectFormula As String

                If My.Forms.PedidoRelat.cboFiltros.Text = "Todos" Then
                    SelectFormula = CrDateBetween("{Pedido.DataFechamento}", My.Forms.PedidoRelat.DataInicial.Text, My.Forms.PedidoRelat.DataFinal.Text) & " and {Pedido.Empresa} = " & CodEmpresa
                Else
                    SelectFormula = CrDateBetween("{Pedido.DataFechamento}", My.Forms.PedidoRelat.DataInicial.Text, My.Forms.PedidoRelat.DataFinal.Text) & " and {Clientes.TpComercio} Like '" & My.Forms.PedidoRelat.cboFiltros.Text & "' and {Pedido.Empresa} = " & CodEmpresa
                End If
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "PedidosOSFaturados"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelPedidosOSFaturados.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As String

                T = "Pedidos/OS faturados no Período de : " & My.Forms.OsRelat.DataInicial.Text & " a " & My.Forms.OsRelat.DataFinal.Text
                VerRelat.DataDefinition.FormulaFields.Item("Titulo").Text = "'" & T & "'"

                Dim CB As CrystalDecisions.CrystalReports.Engine.TextObject
                CB = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                CB.Text = T & " - " & My.Forms.OsRelat.cboFiltros.Text

                Dim SelectFormula As String
                If My.Forms.OsRelat.cboFiltros.Text = "Todos" Then
                    SelectFormula = CrDateBetween("{Pedido.DataFechamento}", My.Forms.OsRelat.DataInicial.Text, My.Forms.OsRelat.DataFinal.Text) & " and {Pedido.Empresa} = " & CodEmpresa
                Else
                    SelectFormula = CrDateBetween("{Pedido.DataFechamento}", My.Forms.OsRelat.DataInicial.Text, My.Forms.OsRelat.DataFinal.Text) & " and {Clientes.TpComercio} Like '" & My.Forms.OsRelat.cboFiltros.Text & "' and {Pedido.Empresa} = " & CodEmpresa
                End If
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "PedidosFaturadosCliente"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelPedidosFaturados.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As String

                T = "Pedidos faturados no Período de : " & My.Forms.PedidoRelat.DataInicial.Text & " a " & My.Forms.PedidoRelat.DataFinal.Text
                VerRelat.DataDefinition.FormulaFields.Item("Titulo").Text = "'" & T & "'"

                Dim CB As CrystalDecisions.CrystalReports.Engine.TextObject
                CB = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                CB.Text = T & " - " & My.Forms.PedidoRelat.ClienteDesc.Text

                Dim SelectFormula As String
                SelectFormula = CrDateBetween("{Pedido.DataFechamento}", My.Forms.PedidoRelat.DataInicial.Text, My.Forms.PedidoRelat.DataFinal.Text) & " and {Pedido.CódigoCliente} = " & My.Forms.PedidoRelat.Cliente.Text & " and {Pedido.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "PedidosOSFaturadosCliente"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelPedidosOSFaturados.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As String

                T = "Pedidos faturados no Período de : " & My.Forms.OsRelat.DataInicial.Text & " a " & My.Forms.OsRelat.DataFinal.Text
                VerRelat.DataDefinition.FormulaFields.Item("Titulo").Text = "'" & T & "'"


                Dim CB As CrystalDecisions.CrystalReports.Engine.TextObject
                CB = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                CB.Text = T & " - " & My.Forms.OsRelat.ClienteDesc.Text

                Dim SelectFormula As String
                SelectFormula = CrDateBetween("{Pedido.DataFechamento}", My.Forms.OsRelat.DataInicial.Text, My.Forms.OsRelat.DataFinal.Text) & " and {Pedido.CódigoCliente} = " & My.Forms.OsRelat.Cliente.Text & " and {Pedido.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "PedidosPorVendedor"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelPedidosFaturados.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As String

                T = "Pedidos faturados no Período de : " & My.Forms.PedidoRelat.DataInicial.Text & " a " & My.Forms.PedidoRelat.DataFinal.Text
                VerRelat.DataDefinition.FormulaFields.Item("Titulo").Text = "'" & T & "'"

                Dim CB As CrystalDecisions.CrystalReports.Engine.TextObject
                CB = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                CB.Text = T & " - " & My.Forms.PedidoRelat.cboFiltros.Text

                Dim SelectFormula As String
                If Len(My.Forms.PedidoRelat.Vendedor.Text) = 0 Then
                    SelectFormula = CrDateBetween("{Pedido.DataFechamento}", My.Forms.PedidoRelat.DataInicial.Text, My.Forms.PedidoRelat.DataFinal.Text) & " and  {Pedido.Empresa} = " & CodEmpresa
                Else
                    If My.Forms.PedidoRelat.cboFiltros.Text = "Todos" Then
                        SelectFormula = CrDateBetween("{Pedido.DataFechamento}", My.Forms.PedidoRelat.DataInicial.Text, My.Forms.PedidoRelat.DataFinal.Text) & " and {Pedido.CódigoFuncionário} = " & My.Forms.PedidoRelat.Vendedor.Text & "  and {Pedido.Empresa} = " & CodEmpresa
                    Else
                        SelectFormula = CrDateBetween("{Pedido.DataFechamento}", My.Forms.PedidoRelat.DataInicial.Text, My.Forms.PedidoRelat.DataFinal.Text) & " and {Pedido.CódigoFuncionário} = " & My.Forms.PedidoRelat.Vendedor.Text & " and {Clientes.TpComercio} Like '" & My.Forms.PedidoRelat.cboFiltros.Text & "' and {Pedido.Empresa} = " & CodEmpresa
                    End If
                End If
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "PedidosOsPorVendedor"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelPedidosOSFaturados.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                ' VerRelat.DataDefinition.RecordSelectionFormula =

                Dim T As String

                T = "Pedidos faturados no Período de : " & My.Forms.OsRelat.DataInicial.Text & " a " & My.Forms.OsRelat.DataFinal.Text
                VerRelat.DataDefinition.FormulaFields.Item("Titulo").Text = "'" & T & "'"

                Dim CB As CrystalDecisions.CrystalReports.Engine.TextObject
                CB = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                CB.Text = T & " - " & My.Forms.OsRelat.cboFiltros.Text


                If Len(My.Forms.OsRelat.Vendedor.Text) = 0 Then
                    VerRelat.DataDefinition.RecordSelectionFormula = CrDateBetween("{Pedido.DataFechamento}", My.Forms.OsRelat.DataInicial.Text, My.Forms.OsRelat.DataFinal.Text) & " and  {Pedido.Empresa} = " & CodEmpresa
                Else
                    If My.Forms.OsRelat.cboFiltros.Text = "Todos" Then
                        VerRelat.DataDefinition.RecordSelectionFormula = CrDateBetween("{Pedido.DataFechamento}", My.Forms.OsRelat.DataInicial.Text, My.Forms.OsRelat.DataFinal.Text) & " and {Pedido.CódigoFuncionário} = " & My.Forms.OsRelat.Vendedor.Text & " and {Pedido.Empresa} = " & CodEmpresa
                    Else
                        VerRelat.DataDefinition.RecordSelectionFormula = CrDateBetween("{Pedido.DataFechamento}", My.Forms.OsRelat.DataInicial.Text, My.Forms.OsRelat.DataFinal.Text) & " and {Pedido.CódigoFuncionário} = " & My.Forms.OsRelat.Vendedor.Text & " and {Clientes.TpComercio} Like '" & My.Forms.OsRelat.cboFiltros.Text & "'  and {Pedido.Empresa} = " & CodEmpresa
                    End If
                End If
                ' Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelOrçamento"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelOrçamento.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim SelectFormula As String
                SelectFormula = "{Orcamento.Orcamento} = " & My.Forms.Orçamento.CodOrçamento.Text & " and {Orcamento.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelNfCFOP"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelNfCFOP.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Notas Fiscais emitida no Período de: " & My.Forms.NFRelat.DataInicial.Text & " a " & My.Forms.NFRelat.DataFinal.Text

                Dim SelectFormula As String
                SelectFormula = CrDateBetween("{NotaFiscal.DataEmissao}", My.Forms.NFRelat.DataInicial.Text, My.Forms.NFRelat.DataFinal.Text) & " and {NotaFiscal.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelProdutoGrupo"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelProdutoGrupo.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i




                VerRelat.DataDefinition.FormulaFields.Item("Titulo").Text = "'" & "Produtos por Grupo" & "'"

                Dim SelectFormula As String
                If My.Forms.ProdutoRelat.Grupo.Text = "" Then
                    SelectFormula = "{Produtos.Inativo} = False and {Produtos.Empresa} = " & CodEmpresa & " And {Produtos.Tipo} = 1"
                Else
                    SelectFormula = "{Produtos.CódigoGrupo} = " & My.Forms.ProdutoRelat.Grupo.Text & " and {Produtos.Inativo} = False and {Produtos.Empresa} = " & CodEmpresa & " And {Produtos.Tipo} = 1"
                End If
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelAnaliseCompraVendaProduto"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelAnaliseCompraVendaProduto.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i


                VerRelat.DataDefinition.FormulaFields.Item("Titulo").Text = "'" & "Analise de Compra e Venda por Produto" & "'"
                Dim SelectFormula As String
                SelectFormula = "{EstoqueUP.CodigoProduto} = " & My.Forms.ProdutoRelat.Produto.Text
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelAnaliseCompraVendaProdutoPeriodo"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelAnaliseCompraVendaProduto.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As String

                T = "Analise de Compra e Venda por Produto no Periodo : " & My.Forms.ProdutoRelat.DataInicial.Text & " e " & My.Forms.ProdutoRelat.DataFinal.Text
                VerRelat.DataDefinition.FormulaFields.Item("Titulo").Text = "'" & T & "'"

                Dim SelectFormula As String
                SelectFormula = CrDateBetween("{EstoqueUP.DataLancamento}", My.Forms.ProdutoRelat.DataInicial.Text, My.Forms.ProdutoRelat.DataFinal.Text) & " and {EstoqueUP.CodigoProduto} = " & My.Forms.ProdutoRelat.Produto.Text
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelReceberJurosCalculado" 'Usado pelo Up
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelReceberJurosCalculado.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    'logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Contas a Receber com Juros Calculado"

                Dim SelectFormula As String
                SelectFormula = CrDateBetween("{Receber.Vencimento}", My.Forms.ReceberRelat.DataInicial.Text, My.Forms.ReceberRelat.DataFinal.Text) & " and {Receber.CodCliente} = " & My.Forms.ReceberRelat.Cliente.Text & " and {Receber.Baixado} = False and {Receber.Inativo} = False and {Receber.CartaoCredito} = False and {Receber.Empresa} = " & CodEmpresa
                VerRelat.DataDefinition.FormulaFields.Item("xJuros").Text = "'" & CDbl(My.Forms.ReceberRelat.Juros.Text) & "'"

                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default


            Case "RelComprasPeriodo"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelCompras.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    'logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")

                Dim SelectFormula As String = String.Empty
                If My.Forms.ComprasRelat.A1.Checked = True Then
                    T.Text = "Compras no Período de: " & My.Forms.ComprasRelat.DataInicial.Text & " e " & My.Forms.ComprasRelat.DataFinal.Text
                    SelectFormula = CrDateBetween("{Compra.DataLançamento}", My.Forms.ComprasRelat.DataInicial.Text, My.Forms.ComprasRelat.DataFinal.Text) & " and {Compra.Inativo} = False and {Compra.Confirmado} = True and {Compra.Empresa} = " & CodEmpresa
                ElseIf My.Forms.ComprasRelat.A4.Checked = True Then
                    T.Text = "Compras no Período para conferência de: " & My.Forms.ComprasRelat.DataInicial.Text & " e " & My.Forms.ComprasRelat.DataFinal.Text

                    SelectFormula = CrDateBetween("{Compra.DataLançamento}", My.Forms.ComprasRelat.DataInicial.Text, My.Forms.ComprasRelat.DataFinal.Text) & " and {Compra.Inativo} = False and {Compra.Confirmado} = false and {Compra.Empresa} = " & CodEmpresa
                End If

                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default


            Case "RelComprasPeriodoFornecedor"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelCompras.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    'logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Compras por Fornecedor no Período de: " & My.Forms.ComprasRelat.DataInicial.Text & " e " & My.Forms.ComprasRelat.DataFinal.Text

                Dim SelectFormula As String
                SelectFormula = CrDateBetween("{Compra.DataLançamento}", My.Forms.ComprasRelat.DataInicial.Text, My.Forms.ComprasRelat.DataFinal.Text) & " and {Compra.Inativo} = False and {Compra.Confirmado} = True and {Compra.Empresa} = " & CodEmpresa & " And {Compra.CodigoFornecedor} = " & My.Forms.ComprasRelat.Fornecedor.Text
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default


            Case "RelChequePrePeriodo"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelChequePre.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    'logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Cheques Pré no Período de: " & My.Forms.ChequePreRelat.DataInicial.Text & " e " & My.Forms.ChequePreRelat.DataFinal.Text

                Dim SelectFormula As String
                SelectFormula = CrDateBetween("{ArquivoCheque.Vencimento}", My.Forms.ChequePreRelat.DataInicial.Text, My.Forms.ChequePreRelat.DataFinal.Text) & " and {ArquivoCheque.Historico} <> 'Baixado' and {ArquivoCheque.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelChequePreGeral"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelChequePre.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    'logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Cheques Pré (Todos)"

                Dim SelectFormula As String
                SelectFormula = "{ArquivoCheque.Historico} <> 'Baixado' and {ArquivoCheque.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelChequePreEntreguePor"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelChequePre.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    'logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Cheques Pré Entregue Por: " & My.Forms.ChequePreRelat.EntreguePor.Text

                Dim SelectFormula As String
                SelectFormula = "{ArquivoCheque.Historico} <> 'Baixado' and {ArquivoCheque.Empresa} = " & CodEmpresa & " and {ArquivoCheque.EntreguePor} = '" & My.Forms.ChequePreRelat.EntreguePor.Text & "'"
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelChequePreBaixadoPeriodo"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelChequePre.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    'logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Cheques Pré Baixado no Período de: " & My.Forms.ChequePreRelat.DataInicial.Text & " e " & My.Forms.ChequePreRelat.DataFinal.Text

                Dim SelectFormula As String
                SelectFormula = CrDateBetween("{ArquivoCheque.DataBaixa}", My.Forms.ChequePreRelat.DataInicial.Text, My.Forms.ChequePreRelat.DataFinal.Text) & " and {ArquivoCheque.Historico} = 'Baixado' and {ArquivoCheque.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default


            Case "RelFluxoCaixa"
                RelFluxoCaixa()

            Case "RelFluxoCaixaPeriodo"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelFluxoCaixa.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    'logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Fluxo de Caixa no Período de : " & My.Forms.CaixaRelat.DataInicial.Text & " a " & My.Forms.CaixaRelat.DataFinal.Text

                Dim SelectFormula As String
                SelectFormula = "{saldosBancos.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelPagarReceberPeriodo" 'Usado pelo up
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelPagarReceberPeriodo.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                VerRelat.DataDefinition.FormulaFields.Item("Titulo").Text = "'" & "Pagar e Receber no Período de : " & My.Forms.CaixaRelat.DataInicial.Text & " a " & My.Forms.CaixaRelat.DataFinal.Text & "'"

                Dim SelectFormula As String
                SelectFormula = CrDateBetween("{PagarReceberPeriodo.Vencimento}", My.Forms.CaixaRelat.DataInicial.Text, My.Forms.CaixaRelat.DataFinal.Text) & " and {PagarReceberPeriodo.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelReciboCaixa"  ' Usado pelo Up
                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelReciboCaixa.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                'Adiciona dados nos Recibos

                Dim extenso As New ActiveIT.cExtenso()
                VerRelat.DataDefinition.FormulaFields.Item("ExtensoValor").Text = "'" & extenso.Executar(CDec(My.Forms.CaixaLançamentos.Valor.Text)) & "'"

                Dim SelectFormula As String
                SelectFormula = "{LancamentoBanco.Id} = " & My.Forms.CaixaLançamentos.Id.Text
                Visualizador.SelectionFormula = SelectFormula


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default




            Case "RelCompraIten"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelCompraItem.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Compras de Itens no Período de : " & My.Forms.ComprasRelat.DataInicial.Text & " a " & My.Forms.ComprasRelat.DataFinal.Text

                Dim SelectFormula As String
                SelectFormula = CrDateBetween("{compraiten.DataLançamento}", My.Forms.ComprasRelat.DataInicial.Text, My.Forms.ComprasRelat.DataFinal.Text) & " and {compraiten.Empresa} = " & CodEmpresa & " and {compraiten.CodigoProduto} = " & My.Forms.ComprasRelat.Produto.Text
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default


            Case "RelNfsPorCliente"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelNfsPorCliente.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Notas Fiscais emitida para Cliente"

                Dim SelectFormula As String
                SelectFormula = "{NotaFiscal.Cliente} = " & My.Forms.NFRelat.Cliente.Text & " and {NotaFiscal.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelNfsPorPedido"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelNfsPorPedido.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Notas Fiscais emitida por Pedido"

                Dim SelectFormula As String
                SelectFormula = "{NotaFiscal.Pedido} = " & My.Forms.NFRelat.Pedido.Text & " and {NotaFiscal.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelEntradasConfAnalitico"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelEntradasConfAnalitico.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Pedidos de compras no Periodo de : " & My.Forms.ComprasRelat.DataInicial.Text & " a " & My.Forms.ComprasRelat.DataFinal.Text

                Dim SelectFormula As String
                SelectFormula = CrDateBetween("{CompraCtrlPedido.DataLançamento}", My.Forms.ComprasRelat.DataInicial.Text, My.Forms.ComprasRelat.DataFinal.Text) & " and {CompraCtrlPedido.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelEntradasConfAnaliticoFornecedor"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelEntradasConfAnalitico.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Pedidos de compras por fornecedor no Periodo de : " & My.Forms.ComprasRelat.DataInicial.Text & " a " & My.Forms.ComprasRelat.DataFinal.Text

                Dim SelectFormula As String
                SelectFormula = CrDateBetween("{CompraCtrlPedido.DataLançamento}", My.Forms.ComprasRelat.DataInicial.Text, My.Forms.ComprasRelat.DataFinal.Text) & " and {CompraCtrlPedido.Fornecedor} = " & My.Forms.ComprasRelat.Fornecedor.Text & " and {CompraCtrlPedido.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default


            Case "RelFolhaPgtoValeFuncionario"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelFolhaPgtoValeFuncionario.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Funcionarios com Vale Quinzenal"


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default


            Case "RelFolhaPgtoPIS"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelFolhaPgtoPIS.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Pagamentos de PIS"


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelEstoqueFabrica"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelEstoqueFabrica.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "BalanceteContas"

                Me.Cursor = Cursors.WaitCursor
                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "BalanceteContas.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelPedidoCidadePeriodo"

                Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
                Cnn.Open()

                Dim DS As New DataSet()
                Dim Sql As String = String.Empty

                Try


                    If My.Forms.PedidoRelat.A4.Checked = True Then
                        Sql = "SELECT DISTINCTROW Pedido.PedidoSequencia, Pedido.DataFechamento, Pedido.TotalPedido, Pedido.CódigoCliente, Clientes.Nome, Clientes.Cidade, Pedido.Empresa, Empresa.RazãoSocial FROM (Clientes INNER JOIN Pedido ON Clientes.Codigo = Pedido.CódigoCliente) LEFT JOIN Empresa ON Pedido.Empresa = Empresa.CódigoEmpresa WHERE (((Pedido.DataFechamento) Between #" & Format(CDate(My.Forms.PedidoRelat.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(My.Forms.PedidoRelat.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Pedido.Empresa)=" & CodEmpresa & "));"
                    End If

                    If My.Forms.PedidoRelat.A5.Checked = True Then
                        Sql = "SELECT DISTINCTROW Pedido.PedidoSequencia, Pedido.DataFechamento, Pedido.TotalPedido, Pedido.CódigoCliente, Clientes.Nome, Clientes.Cidade, Pedido.Empresa, Empresa.RazãoSocial FROM (Clientes INNER JOIN Pedido ON Clientes.Codigo = Pedido.CódigoCliente) LEFT JOIN Empresa ON Pedido.Empresa = Empresa.CódigoEmpresa WHERE (((Clientes.Cidade)='" & My.Forms.PedidoRelat.Cidade.Text & "') AND ((Pedido.Empresa)=" & CodEmpresa & "));"
                    End If

                    Dim DAPedidoCidadePerido As New OleDb.OleDbDataAdapter(Sql, Cnn)
                    DAPedidoCidadePerido.Fill(DS, "PedidoPorCidade")

                    Dim VerRelat As New ReportDocument()
                    VerRelat.Load(DirRelat & "RelPedidoCidade.rpt")

                    Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                    T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                    If My.Forms.PedidoRelat.A4.Checked = True Then T.Text = "Pedidos Faturados por Cidade no Periodo de " & My.Forms.PedidoRelat.DataInicial.Text & " a " & My.Forms.PedidoRelat.DataFinal.Text
                    If My.Forms.PedidoRelat.A5.Checked = True Then T.Text = "Pedidos Faturados na Cidade de " & My.Forms.PedidoRelat.Cidade.Text

                    VerRelat.SetDataSource(DS)

                    Me.Visualizador.ReportSource = VerRelat

                Catch Ex As Exception
                    MessageBox.Show("Dados Inexistente para gerar o relatório, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try

            Case "RelPedidoAcompanhamento"
                Me.Cursor = Cursors.WaitCursor
                Dim Dir As String = Environment.CurrentDirectory

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(Dir & "\Relatorios\RelPedidoAcompanhamento.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    'logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim SelectFormula As String
                SelectFormula = "{PedidoAcompanhamento.Pedido} = " & My.Forms.PedidoAcompanhamento.Pedido.Text & " and {PedidoAcompanhamento.Empresa} = " & CodEmpresa
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelOrdemCompra"
                RelOrdemCompra()

            Case "EntradaDocumento"
                Try
                    Me.Cursor = Cursors.WaitCursor

                    Dim VerRelat As New ReportDocument()
                    VerRelat.Load(DirRelat & "EntradaDocumento.rpt")

                    Dim logOnInfo As New TableLogOnInfo()
                    Dim i As Integer
                    For i = 0 To VerRelat.Database.Tables.Count - 1
                        logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                        logOnInfo.ConnectionInfo.UserID = ""
                        logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                        VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                    Next i


                    Dim SelectFormula As String
                    SelectFormula = "{CompraCtrlPedido.ID} = " & My.Forms.DocumentoEntrada.Id.Text


                    Visualizador.SelectionFormula = SelectFormula

                    Me.Visualizador.ReportSource = VerRelat
                    Me.Cursor = Cursors.Default

                Catch Ex As Exception
                    MessageBox.Show("Dados Inexistente para gerar o relatório, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try

            Case "Clientes"
                Try
                    Me.Cursor = Cursors.WaitCursor

                    Dim VerRelat As New ReportDocument()
                    VerRelat.Load(DirRelat & "Clientes.rpt")

                    Dim logOnInfo As New TableLogOnInfo()
                    Dim i As Integer
                    For i = 0 To VerRelat.Database.Tables.Count - 1
                        logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                        logOnInfo.ConnectionInfo.UserID = ""
                        logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                        VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                    Next i


                    'Dim SelectFormula As String
                    'SelectFormula = "{Clientes.Empresa} = " & CodEmpresa
                    VerRelat.DataDefinition.FormulaFields.Item("xUser").Text = "'" & "Usuário: " & UserAtivo & "'"

                    'Visualizador.SelectionFormula = SelectFormula

                    Me.Visualizador.ReportSource = VerRelat
                    Me.Cursor = Cursors.Default

                Catch Ex As Exception
                    MessageBox.Show("Dados Inexistente para gerar o relatório, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try

            Case "RelPedidoStatusSintetico"
                Try
                    Me.Cursor = Cursors.WaitCursor

                    Dim VerRelat As New ReportDocument()
                    VerRelat.Load(DirRelat & "RelPedidoStatusSintetico.rpt")

                    Dim logOnInfo As New TableLogOnInfo()
                    Dim i As Integer
                    For i = 0 To VerRelat.Database.Tables.Count - 1
                        logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                        logOnInfo.ConnectionInfo.UserID = ""
                        logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                        VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                    Next i

                    VerRelat.DataDefinition.FormulaFields.Item("xUser").Text = "'" & "Usuário: " & UserAtivo & "'"

                    Dim SelectFormula As String = String.Empty
                    Dim Status As String = String.Empty

                    If My.Forms.PedidoStatusAndamento.O1.Checked Then Status = "'INICIAL'"
                    If My.Forms.PedidoStatusAndamento.O2.Checked Then Status = "'EM ANDAMENTO'"
                    If My.Forms.PedidoStatusAndamento.O3.Checked Then Status = "'FINALIZADO'"

                    If My.Forms.PedidoStatusAndamento.A1.Checked = True Then
                        VerRelat.DataDefinition.FormulaFields.Item("Titulo").Text = "'Acompanhamento de Pedido'"
                        SelectFormula = "{Pedido.StatusAndamentos} = " & Status
                    End If

                    If My.Forms.PedidoStatusAndamento.A2.Checked = True Then
                        VerRelat.DataDefinition.FormulaFields.Item("Titulo").Text = "'Acompanhamento de Pedido no Período de " & My.Forms.PedidoStatusAndamento.DataA.Text & " a " & My.Forms.PedidoStatusAndamento.DataB.Text & "'"
                        SelectFormula = "{Pedido.StatusAndamentos} = " & Status & " And " & CrDateBetween("{Pedido.DataPedido}", My.Forms.PedidoStatusAndamento.DataA.Text, My.Forms.PedidoStatusAndamento.DataB.Text)
                    End If

                    If My.Forms.PedidoStatusAndamento.A3.Checked = True Then
                        VerRelat.DataDefinition.FormulaFields.Item("Titulo").Text = "'Acompanhamento de Pedido'"
                        SelectFormula = "{Pedido.PedidoSequencia} = " & My.Forms.PedidoStatusAndamento.DataA.Text
                    End If

                    Visualizador.SelectionFormula = SelectFormula


                    Me.Visualizador.ReportSource = VerRelat
                    Me.Cursor = Cursors.Default

                Catch Ex As Exception
                    MessageBox.Show("Dados Inexistente para gerar o relatório, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try


            Case "RelPedidoStatusAnalitico"
                Try
                    Me.Cursor = Cursors.WaitCursor

                    Dim VerRelat As New ReportDocument()
                    VerRelat.Load(DirRelat & "RelPedidoStatusAnalitico.rpt")

                    Dim logOnInfo As New TableLogOnInfo()
                    Dim i As Integer
                    For i = 0 To VerRelat.Database.Tables.Count - 1
                        logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                        logOnInfo.ConnectionInfo.UserID = ""
                        logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                        VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                    Next i

                    VerRelat.DataDefinition.FormulaFields.Item("xUser").Text = "'" & "Usuário: " & UserAtivo & "'"

                    Dim SelectFormula As String = String.Empty
                    Dim Status As String = String.Empty

                    If My.Forms.PedidoStatusAndamento.O1.Checked Then Status = "'INICIAL'"
                    If My.Forms.PedidoStatusAndamento.O2.Checked Then Status = "'EM ANDAMENTO'"
                    If My.Forms.PedidoStatusAndamento.O3.Checked Then Status = "'FINALIZADO'"

                    If My.Forms.PedidoStatusAndamento.A1.Checked = True Then
                        VerRelat.DataDefinition.FormulaFields.Item("Titulo").Text = "'Acompanhamento de Pedido'"
                        SelectFormula = "{Pedido.StatusAndamentos} = " & Status
                    End If

                    If My.Forms.PedidoStatusAndamento.A2.Checked = True Then
                        VerRelat.DataDefinition.FormulaFields.Item("Titulo").Text = "'Acompanhamento de Pedido no Período de " & My.Forms.PedidoStatusAndamento.DataA.Text & " a " & My.Forms.PedidoStatusAndamento.DataB.Text & "'"
                        SelectFormula = "{Pedido.StatusAndamentos} = " & Status & " And " & CrDateBetween("{Pedido.DataPedido}", My.Forms.PedidoStatusAndamento.DataA.Text, My.Forms.PedidoStatusAndamento.DataB.Text)
                    End If

                    If My.Forms.PedidoStatusAndamento.A3.Checked = True Then
                        VerRelat.DataDefinition.FormulaFields.Item("Titulo").Text = "'Acompanhamento de Pedido'"
                        SelectFormula = "{Pedido.PedidoSequencia} = " & My.Forms.PedidoStatusAndamento.DataA.Text
                    End If

                    Visualizador.SelectionFormula = SelectFormula


                    Me.Visualizador.ReportSource = VerRelat
                    Me.Cursor = Cursors.Default

                Catch Ex As Exception
                    MessageBox.Show("Dados Inexistente para gerar o relatório, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try

            Case "RelPedidosFaturadoVendaInterna"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "relpedidosfaturadosVendaInterna.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                ' T.Left = 500
                T.Text = "Pedidos Vendas Internas no Período de : " & My.Forms.PedidoRelat.DataInicial.Text & " a " & My.Forms.PedidoRelat.DataFinal.Text
                VerRelat.DataDefinition.FormulaFields.Item("xUser").Text = "'" & "Usuário: " & UserAtivo & "'"
                Dim SelectFormula As String
                SelectFormula = CrDateBetween("{Pedido.DataPedido}", My.Forms.PedidoRelat.DataInicial.Text, My.Forms.PedidoRelat.DataFinal.Text) & " and {Pedido.Empresa} = " & CodEmpresa & " and not ({Pedido.PedidoTipo} like ['VENDA', 'VENDAVENDA'])"
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelPedidosAbertoVendaInterna"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelPedidosAbertoVendaInterna.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                ' T.Left = 500
                T.Text = "Pedidos Vendas Internas em Aberto"
                VerRelat.DataDefinition.FormulaFields.Item("xUser").Text = "'" & "Usuário: " & UserAtivo & "'"
                Dim SelectFormula As String
                SelectFormula = "not {Pedido.Confirmado} and not {Pedido.Inativo} and {Pedido.Empresa} = " & CodEmpresa & " and not ({Pedido.PedidoTipo} like ['VENDA', 'VENDAVENDA'])"
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default


            Case "RelReceberEmAbertoRegiao"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelReceberEmAbertoRegiao.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Titulos em Abertos por Região de Venda"

                VerRelat.DataDefinition.FormulaFields.Item("Juros").Text = "'" & CDbl(My.Forms.ReceberRelat.Juros.Text) & "'"
                VerRelat.DataDefinition.FormulaFields.Item("Multa").Text = "'" & CDbl(My.Forms.ReceberRelat.Multa.Text) & "'"

                Dim SelectFormula As String
                If My.Forms.ReceberRelat.Regiao.Text = "" Then
                    SelectFormula = "{Receber.Baixado} = false And {Receber.Inativo} = False and {Receber.Empresa} = " & CodEmpresa
                Else
                    SelectFormula = "{Clientes.IdRegiao} = " & My.Forms.ReceberRelat.Regiao.SelectedValue & " and {Receber.Baixado} = false And {Receber.Inativo} = False and {Receber.CartaoCredito} = False and {Receber.Empresa} = " & CodEmpresa
                End If

                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default


            Case "RelReceberEmAbertoVendedor"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelReceberEmAbertoRegiao.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                T.Text = "Titulos em Abertos por Vendedor"

                VerRelat.DataDefinition.FormulaFields.Item("Juros").Text = "'" & CDbl(My.Forms.ReceberRelat.Juros.Text) & "'"
                VerRelat.DataDefinition.FormulaFields.Item("Multa").Text = "'" & CDbl(My.Forms.ReceberRelat.Multa.Text) & "'"

                Dim SelectFormula As String

                SelectFormula = "{Receber.Vendedor} = " & My.Forms.ReceberRelat.Vendedor.SelectedValue & " and {Receber.Baixado} = false And {Receber.Inativo} = False And {Receber.CartaoCredito} = False and {Receber.Empresa} = " & CodEmpresa


                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default




            Case "RelEstoqueMinimo"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelEstoqueMinimo.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")



                Dim SelectFormula As String = String.Empty
                If My.Forms.ProdutoRelat.A20.Checked = True Then
                    T.Text = "Produtos em Estoque Mínimo"
                    SelectFormula = "{Produtos.Empresa} = " & CodEmpresa & " and {Produtos.Inativo} = False and {Produtos.QuantidadeEstoque} < {Produtos.EstoqueMinimo}"
                End If
                If My.Forms.ProdutoRelat.A21.Checked = True Then
                    T.Text = "Produto em Estoque Mínimo"
                    SelectFormula = "{Produtos.CodigoProduto} = " & My.Forms.ProdutoRelat.Produto.Text & " And {Produtos.Empresa} = " & CodEmpresa & " and {Produtos.Inativo} = False and {Produtos.QuantidadeEstoque} < {Produtos.EstoqueMinimo}"
                End If
                If My.Forms.ProdutoRelat.A22.Checked = True Then
                    T.Text = "Produtos em Estoque Mínimo por Grupo"
                    SelectFormula = "{Produtos.CódigoGrupo} = " & My.Forms.ProdutoRelat.Grupo.Text & " And {Produtos.Empresa} = " & CodEmpresa & " and {Produtos.Inativo} = False and {Produtos.QuantidadeEstoque} < {Produtos.EstoqueMinimo}"
                End If


                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

                'inserido pelo jose roberto
            Case "Iventario"
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "Iventario.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
                T = VerRelat.ReportDefinition.ReportObjects.Item("subT")

                Dim SelectFormula As String = String.Empty

                T.Text = "Inventário de produtos no período de " + My.Forms.Iventario.DataInicial.Text + " a " + My.Forms.Iventario.DataFinal.Text
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default


            Case "Etiqueta3C"  'Etiquetas3C. para o corno do juliano. rotina inserida por jose roberto
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "Etiqueta3C.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i
                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "Etiqueta3CR"  'Etiquetas3CR roupa. para o corno do juliano. rotina inserida por jose roberto
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "Etiqueta3CR.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i
                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default


            Case "Carne"  'Carne. para o corno do juliano. rotina inserida por jose roberto
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "Carne.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i
                Dim SelectFormula As String = String.Empty
                SelectFormula = "{Receber.Baixado} = false And {Receber.PedidoProdutos} = " & CInt(My.Forms.SellShoes.Venda.Text)
                Visualizador.SelectionFormula = SelectFormula
                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelProcuracao"  'Procuração para o cliente. rotina inserida por jose roberto
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelProcuracao.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i
                Dim SelectFormula As String = String.Empty
                SelectFormula = "{Clientes.Codigo} = " & My.Forms.Clientes.Codigo.Text
                Visualizador.SelectionFormula = SelectFormula
                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default


            Case "RelPedidosFaturadosVendedorTP" 'relatorio criado pelo beto '

                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelPedidosFaturadosVendedorTP.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                Dim T As String

                T = "Pedidos faturados no Período de : " & My.Forms.PedidoRelat.DataInicial.Text & " a " & My.Forms.PedidoRelat.DataFinal.Text
                VerRelat.DataDefinition.FormulaFields.Item("Titulo").Text = "'" & T & "'"

                Dim CB As CrystalDecisions.CrystalReports.Engine.TextObject
                CB = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
                CB.Text = T & " - " & My.Forms.PedidoRelat.cboFiltros.Text

                Dim SelectFormula As String
                If Len(My.Forms.PedidoRelat.Vendedor.Text) = 0 Then
                    CB.Text = T & " - " & My.Forms.PedidoRelat.cboFiltros.Text
                    SelectFormula = CrDateBetween("{Pedido.DataFechamento}", My.Forms.PedidoRelat.DataInicial.Text, My.Forms.PedidoRelat.DataFinal.Text) & " and  {Pedido.Empresa} = " & CodEmpresa
                Else
                    If My.Forms.PedidoRelat.cboFiltros.Text = "Todos" Then
                        CB.Text = T & " - " & My.Forms.PedidoRelat.VendedorDesc.Text
                        SelectFormula = CrDateBetween("{Pedido.DataFechamento}", My.Forms.PedidoRelat.DataInicial.Text, My.Forms.PedidoRelat.DataFinal.Text) & " and {Pedido.CódigoFuncionário} = " & My.Forms.PedidoRelat.Vendedor.Text & "  and {Pedido.Empresa} = " & CodEmpresa
                    Else
                        SelectFormula = CrDateBetween("{Pedido.DataFechamento}", My.Forms.PedidoRelat.DataInicial.Text, My.Forms.PedidoRelat.DataFinal.Text) & " and {Pedido.CódigoFuncionário} = " & My.Forms.PedidoRelat.Vendedor.Text & " and {Clientes.TpComercio} Like '" & My.Forms.PedidoRelat.cboFiltros.Text & "' and {Pedido.Empresa} = " & CodEmpresa
                    End If
                End If
                Visualizador.SelectionFormula = SelectFormula

                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "ContasResultados"  'Procuração para o cliente. rotina inserida por jose roberto
                Me.Cursor = Cursors.WaitCursor

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "ContasResultado.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i
               
                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "RelComissaoDiario"

                Dim mes As DateTime = DataDia
                Dim primeirodia As DateTime = Convert.ToDateTime("01/" + mes.ToString("MM/yyyy"))
                Dim A As String = String.Format("{0:t}", primeirodia.ToShortDateString)
                Dim B As String = mes.AddDays(-1)

                Dim dif As TimeSpan = mes.Subtract(primeirodia)
                Dim dias As Integer = dif.Days

                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "RelComissaoDiario.rpt")

                Dim TT As CrystalDecisions.CrystalReports.Engine.TextObject
                TT = VerRelat.ReportDefinition.ReportObjects.Item("Text1")
                TT.Text = "Relatório de vendas Diário " & DataDia
                TT = VerRelat.ReportDefinition.ReportObjects.Item("Text3")
                TT.Text = "Valor Acumulado" & Chr(13) & "do mês até " & DataDia.AddDays(-1)

                Dim tmpDT As DataTable = gerarVendasDiario()
                Me.Cursor = Cursors.WaitCursor
                VerRelat.SetDataSource(tmpDT)
                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

            Case "Prod_VndMarcaGrupo"
                Dim strGrp As String

                Me.Cursor = Cursors.WaitCursor
                Dim VerRelat As New ReportDocument()
                VerRelat.Load(DirRelat & "Prod_VndMarcaGrupo.rpt")

                Dim logOnInfo As New TableLogOnInfo()
                Dim i As Integer
                For i = 0 To VerRelat.Database.Tables.Count - 1
                    logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                    logOnInfo.ConnectionInfo.UserID = ""
                    logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                    VerRelat.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                Next i

                If My.Forms.ProdutoRelat.A40.Checked Then
                    strGrp = "Marcas"
                Else
                    strGrp = "Grupos"

                End If

                VerRelat.DataDefinition.RecordSelectionFormula = "{Pedido.DataFechamento}>=Date (" & Format(CDate(My.Forms.ProdutoRelat.DataInicial.Text), "yyyy,MM,dd") & ") and {Pedido.DataFechamento}<=date(" & Format(CDate(My.Forms.ProdutoRelat.DataFinal.Text), "yyyy,MM,dd") & ") and {Pedido.Empresa}=" & CodEmpresa
                Dim TT As CrystalDecisions.CrystalReports.Engine.TextObject
                TT = VerRelat.ReportDefinition.ReportObjects.Item("txtTitulo")
                TT.Text = "Relatório de Produtos vendidos por " & strGrp
                TT = VerRelat.ReportDefinition.ReportObjects.Item("txtPeriodo")
                TT.Text = "Período: " & My.Forms.ProdutoRelat.DataInicial.Text & " a " & My.Forms.ProdutoRelat.DataFinal.Text

                VerRelat.DataDefinition.FormulaFields.Item("cGrupoName").Text = "'" & strGrp & "'"
                'VerRelat.DataDefinition.FormulaFields.Item("xEstoqueAnterior").Text = "'" & FormatNumber(My.Forms.ProdutoSaldoEstoque.vEstoqueAterior, 2) & "'"
                'VerRelat.DataDefinition.FormulaFields.Item("xPeriodo").Text = "'" & "Período: " & My.Forms.ProdutoSaldoEstoque.DataInicial.Text & " à " & My.Forms.ProdutoSaldoEstoque.DataFinal.Text & "'"


                Me.Visualizador.ReportSource = VerRelat
                Me.Cursor = Cursors.Default

        End Select



    End Sub
#End Region


    Public Function CrDateBetween(ByVal CampoFiltro As String, ByVal DataInicial As String, ByVal DataFinal As String) As String
        Dim DInicial As Date, DFinal As Date
        DInicial = CDate(DataInicial)
        DFinal = CDate(DataFinal)
        Return CampoFiltro & " in DateTime (" & Year(DInicial) & "," & Month(DInicial) & "," & Microsoft.VisualBasic.Day(DInicial) & ", 0, 0, 0) to DateTime (" & Year(DFinal) & "," & Month(DFinal) & "," & Microsoft.VisualBasic.Day(DFinal) & ", 0, 0, 0)"
    End Function




    Private Sub FecharToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
        Dispose()
    End Sub

    Public Function gerarVendasDiario() As DataTable
        Dim mes As DateTime = DataDia
        Dim primeirodia As DateTime = Convert.ToDateTime("01/" + mes.ToString("MM/yyyy"))
        Dim A As String = String.Format("{0:t}", primeirodia.ToShortDateString)
        Dim B As String = mes.AddDays(-1)

        Dim Cn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cn.Open()

        'acumulado do mes.
        Dim oDA As New OleDb.OleDbDataAdapter("SELECT Pedido.CódigoFuncionário, Sum(Pedido.TotalPedido) AS SomaDeTotalPedido  FROM(Pedido) WHERE (((Pedido.DataFechamento) Between #" & Format(CDate(A), "MM/dd/yyyy") & "# And #" & Format(CDate(B), "MM/dd/yyyy") & "#)) GROUP BY Pedido.CódigoFuncionário;", Cn)

        'venda dos dia
        Dim oDA1 As New OleDb.OleDbDataAdapter("SELECT Pedido.CódigoFuncionário, Sum(Pedido.TotalPedido) AS SomaDeTotalPedido FROM(Pedido) WHERE(((Pedido.DataFechamento) = #" & Format(CDate(DataDia), "MM/dd/yyyy") & "#)) GROUP BY Pedido.CódigoFuncionário;", Cn)



        Dim dr As OleDbDataReader
        Dim cmd As New OleDbCommand("SELECT Funcionários.CódigoFuncionário, Funcionários.Nome FROM(Funcionários) WHERE (((Funcionários.AdicionarEmVendas)=True));", Cn)
        dr = cmd.ExecuteReader



        'cria o datatable
        Dim tabela As New DataTable()
        tabela.Columns.Add("codigo", GetType(Integer))
        tabela.Columns.Add("NomeVendedor", GetType(String))
        tabela.Columns.Add("TotalAcumulado", GetType(Double))
        tabela.Columns.Add("TotalDia", GetType(Double))
        tabela.TableName = "comissao"
        Dim row As DataRow


        While dr.Read
            row = tabela.NewRow
            row(0) = dr.Item(0)
            row(1) = dr.Item(1)
            row(2) = 0
            row(3) = 0

            tabela.Rows.Add(row)
        End While

        Dim ds As New DataSet
        oDA.Fill(ds, "Acum_Mes")
        oDA1.Fill(ds, "Venda_Dia")


        Dim i As Integer
        For i = 0 To tabela.Rows.Count - 1
            Dim oRow() As DataRow
            oRow = ds.Tables("Acum_Mes").Select("CódigoFuncionário =" & tabela.Rows(i).Item("codigo"))
            If oRow.Length > 0 Then
                tabela.Rows(i).Item("TotalAcumulado") = oRow(0)(1)
            End If

            oRow = ds.Tables("Venda_Dia").Select("CódigoFuncionário =" & tabela.Rows(i).Item("codigo"))
            If oRow.Length > 0 Then
                tabela.Rows(i).Item("TotalDia") = oRow(0)(1)
            End If
        Next
        Return tabela
    End Function


End Class