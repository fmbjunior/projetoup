Public Class FechamentoAnual

    Dim Ação As New TrfGerais

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub FechamentoAnual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Empresa.Text = CodEmpresa
        DadosEmpresa()

    End Sub

    Public Sub DadosEmpresa()
        Dim Cn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cn.Open()

        Dim CM As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        'Verifica a data de Entrada
        With CM
            .Connection = Cn
            .CommandTimeout = 0
            .CommandText = "SELECT * From Empresa Where CódigoEmpresa = " & CodEmpresa
            .CommandType = CommandType.Text
        End With

        DR = CM.ExecuteReader
        DR.Read()
        If DR.HasRows = True Then
            Me.EmpresaDesc.Text = DR.Item("RazãoSocial")
        End If
        DR.Close()
        Cn.Close()
        Cn.Dispose()
    End Sub

    Private Sub FechamentoAno()

        If Me.DiaFinalAno.Text = "" Then
            MsgBox("O usuário deve informar o Ano de Fechamento", 64, "Validação de Dados")
            Exit Sub
        End If

        If Me.DiaInicalNovoAno.Text = "" Then
            MsgBox("O usuário deve informar o novo Ano de trabalho", 64, "Validação de Dados")
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim Ano_Fechar As String = "L" & Me.AnoFechar.Text
        Dim Ano_Transferir As String = "L" & Me.AnoTransferir.Text

        AchaTable(Ano_Transferir)

        Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim DS As New DataSet()
        Dim Sql As String = String.Empty


        Sql = "SELECT " & Ano_Fechar & ".PlanoContas, PlanoContas.Descrição, Sum(" & Ano_Fechar & ".ValorDebito) AS SomaDeValorDebito, Sum(" & Ano_Fechar & ".ValorCredito) AS SomaDeValorCredito, Sum([ValorDebito])-Sum([ValorCredito]) AS Saldo, " & Ano_Fechar & ".Empresa FROM " & Ano_Fechar & " LEFT JOIN PlanoContas ON (" & Ano_Fechar & ".PlanoContas = PlanoContas.IdContas) AND (" & Ano_Fechar & ".Empresa = PlanoContas.Empresa) WHERE(((Year([DataLancamento])) = " & Me.AnoFechar.Text & ")) GROUP BY " & Ano_Fechar & ".PlanoContas, PlanoContas.Descrição, " & Ano_Fechar & ".Empresa HAVING (((" & Ano_Fechar & ".PlanoContas) Like '01%' Or (" & Ano_Fechar & ".PlanoContas) Like '02%') AND ((" & Ano_Fechar & ".Empresa)=" & CodEmpresa & "));"
        Dim DASaldoTransferir As New OleDb.OleDbDataAdapter(Sql, Cnn)
        DASaldoTransferir.Fill(DS, "SaldosTransferir")

        Sql = "Select * From " & Ano_Transferir
        Dim DAAnoNovo As New OleDb.OleDbDataAdapter(Sql, Cnn)
        DAAnoNovo.Fill(DS, Ano_Transferir)

        'Rotina para tranferir os saldos das contas do ativo e do passivo para o novo ano
        Dim ContReg As Integer = 0

        Dim TotalLinhas As Integer = DS.Tables("SaldosTransferir").Rows.Count
        'Atualiza a barra de Progresso
        If TotalLinhas = 0 Then TotalLinhas = 1
        MyBarra.Visible = True
        MyBarra.Minimum = 1
        MyBarra.Maximum = TotalLinhas
        MyBarra.Value = 1
        MyBarra.Step = 1
        MyBarra.Text = ""



        Dim DrSaldoAtivoPassivo As DataRow
        For Each DrSaldoAtivoPassivo In DS.Tables("SaldosTransferir").Rows

            Dim Ult As String
            Ult = CalcIdLancamento()

            Dim TBLAnoNovo As DataTable
            TBLAnoNovo = DS.Tables(Ano_Transferir)

            ContReg += 1
            Me.MyBarra.Text = "Gerando Saldo Conta : " & DrSaldoAtivoPassivo("PlanoContas") & "     Registro : " & ContReg & " de " & TotalLinhas
            ' Adicionar a Partida do Lancamento
            Dim DRnovo As DataRow
            DRnovo = TBLAnoNovo.NewRow()
            DRnovo("DataLancamento") = Me.DiaInicalNovoAno.Text
            DRnovo("PlanoContas") = DrSaldoAtivoPassivo("PlanoContas")
            DRnovo("ContraPartida") = DrSaldoAtivoPassivo("PlanoContas")
            DRnovo("Documento") = "S" & Microsoft.VisualBasic.Day(Me.DiaInicalNovoAno.Text) & Month(Me.DiaInicalNovoAno.Text) & Year((Me.DiaInicalNovoAno.Text))
            DRnovo("DataDocumento") = Me.DiaInicalNovoAno.Text

            If FormatNumber(DrSaldoAtivoPassivo("Saldo"), 2) >= FormatNumber(0, 2) Then
                DRnovo("ValorDebito") = FormatNumber(DrSaldoAtivoPassivo("Saldo"), 2)
                DRnovo("ValorCredito") = 0
            Else
                DRnovo("ValorDebito") = 0
                DRnovo("ValorCredito") = (FormatNumber(DrSaldoAtivoPassivo("Saldo"), 2) * -1)
            End If

            DRnovo("Historico") = "Saldo Anterior do ano : " & Me.AnoFechar.Text
            DRnovo("Empresa") = CodEmpresa
            DRnovo("IdLancamento") = "FimAno"
            DRnovo("IdProcura") = Ult
            DRnovo("IdOrigem") = "0"
            DRnovo("NotaFiscal") = "0"

            TBLAnoNovo.Rows.Add(DRnovo)

            ' Adicionar a ContraPartida do Lancamento
            Dim DRnovoCP As DataRow
            DRnovoCP = TBLAnoNovo.NewRow()
            DRnovoCP("DataLancamento") = Me.DiaInicalNovoAno.Text
            DRnovoCP("PlanoContas") = DrSaldoAtivoPassivo("PlanoContas")
            DRnovoCP("ContraPartida") = DrSaldoAtivoPassivo("PlanoContas")
            DRnovoCP("Documento") = "S" & Microsoft.VisualBasic.Day(Me.DiaInicalNovoAno.Text) & Month(Me.DiaInicalNovoAno.Text) & Year((Me.DiaInicalNovoAno.Text))
            DRnovoCP("DataDocumento") = Me.DiaInicalNovoAno.Text
            DRnovoCP("ValorDebito") = 0
            DRnovoCP("ValorCredito") = 0
            DRnovoCP("Historico") = "Saldo Anterior do ano : " & Me.AnoFechar.Text
            DRnovoCP("Empresa") = CodEmpresa
            DRnovoCP("IdLancamento") = "FimAno"
            DRnovoCP("IdProcura") = Ult
            DRnovoCP("IdOrigem") = "0"
            DRnovoCP("NotaFiscal") = "0"

            TBLAnoNovo.Rows.Add(DRnovoCP)
            Me.MyBarra.PerformStep()
        Next DrSaldoAtivoPassivo


        'Rotina para gerar saldos do dre nas contas de receitas e despezas
        Sql = "SELECT " & Ano_Fechar & ".PlanoContas, PlanoContas.Descrição, Sum(" & Ano_Fechar & ".ValorDebito) AS SomaDeValorDebito, Sum(" & Ano_Fechar & ".ValorCredito) AS SomaDeValorCredito, Sum([ValorCredito])-Sum([ValorDebito]) AS Saldo, " & Ano_Fechar & ".Empresa FROM " & Ano_Fechar & " LEFT JOIN PlanoContas ON (" & Ano_Fechar & ".PlanoContas = PlanoContas.IdContas) AND (" & Ano_Fechar & ".Empresa = PlanoContas.Empresa) WHERE(((Year([DataLancamento])) = " & Me.AnoFechar.Text & ")) GROUP BY " & Ano_Fechar & ".PlanoContas, PlanoContas.Descrição, " & Ano_Fechar & ".Empresa HAVING (((" & Ano_Fechar & ".PlanoContas) Like '03%' Or (" & Ano_Fechar & ".PlanoContas) Like '04%') AND ((" & Ano_Fechar & ".Empresa) = " & CodEmpresa & "));"
        Dim DADre As New OleDb.OleDbDataAdapter(Sql, Cnn)
        DADre.Fill(DS, "Dre")


        Sql = "Select * From " & Ano_Fechar & " Where Id = 0"
        Dim DAAnoVelho As New OleDb.OleDbDataAdapter(Sql, Cnn)
        DAAnoVelho.Fill(DS, Ano_Fechar)



        TotalLinhas = DS.Tables("Dre").Rows.Count
        'Atualiza a barra de Progresso
        If TotalLinhas = 0 Then TotalLinhas = 1
        MyBarra.Visible = True
        MyBarra.Minimum = 1
        MyBarra.Maximum = TotalLinhas
        MyBarra.Value = 1
        MyBarra.Step = 1
        MyBarra.Text = ""

        ContReg = 0
        Dim DrDRE As DataRow
        For Each DrDRE In DS.Tables("Dre").Rows
            Dim Ult As String
            Ult = CalcIdLancamento()

            Dim TBLAnoVelho As DataTable
            TBLAnoVelho = DS.Tables(Ano_Fechar)


            ContReg += 1
            Me.MyBarra.Text = "Gerando DRE Conta : " & DrDRE("PlanoContas") & "     Registro : " & ContReg & " de " & TotalLinhas


            Dim DRnovo As DataRow
            DRnovo = TBLAnoVelho.NewRow()
            DRnovo("DataLancamento") = Me.DiaFinalAno.Text
            DRnovo("PlanoContas") = DrDRE("PlanoContas")
            DRnovo("ContraPartida") = Me.ContaSaldoDre.Text
            DRnovo("Documento") = "S" & Microsoft.VisualBasic.Day(Me.DiaFinalAno.Text) & Month(Me.DiaFinalAno.Text) & Year((Me.DiaFinalAno.Text))
            DRnovo("DataDocumento") = Me.DiaInicalNovoAno.Text

            If Mid(DrDRE("PlanoContas"), 1, 2) = "03" Then
                If FormatNumber(DrDRE("Saldo"), 2) > FormatNumber(0, 2) Then
                    DRnovo("ValorDebito") = FormatNumber(DrDRE("Saldo"), 2)
                    DRnovo("ValorCredito") = 0
                Else
                    DRnovo("ValorDebito") = 0
                    DRnovo("ValorCredito") = (FormatNumber(DrDRE("Saldo"), 2) * -1)
                End If
            End If

            If Mid(DrDRE("PlanoContas"), 1, 2) = "04" Then
                If FormatNumber(DrDRE("Saldo"), 2) > FormatNumber(0, 2) Then
                    DRnovo("ValorDebito") = FormatNumber(DrDRE("Saldo"), 2)
                    DRnovo("ValorCredito") = 0
                Else
                    DRnovo("ValorDebito") = 0
                    DRnovo("ValorCredito") = (FormatNumber(DrDRE("Saldo"), 2) * -1)
                End If
            End If


            DRnovo("Historico") = "Saldo : " & DrDRE("Descrição")
            DRnovo("Empresa") = CodEmpresa
            DRnovo("IdLancamento") = "FimAno"
            DRnovo("IdProcura") = Ult
            DRnovo("IdOrigem") = "0"
            DRnovo("NotaFiscal") = "0"

            TBLAnoVelho.Rows.Add(DRnovo)

            'Contra partida

            Dim DRnovoCP As DataRow
            DRnovoCP = TBLAnoVelho.NewRow()
            DRnovoCP("DataLancamento") = Me.DiaFinalAno.Text
            DRnovoCP("PlanoContas") = Me.ContaSaldoDre.Text
            DRnovoCP("ContraPartida") = DrDRE("PlanoContas")
            DRnovoCP("Documento") = "S" & Microsoft.VisualBasic.Day(Me.DiaFinalAno.Text) & Month(Me.DiaFinalAno.Text) & Year((Me.DiaFinalAno.Text))
            DRnovoCP("DataDocumento") = Me.DiaInicalNovoAno.Text

            If Mid(DrDRE("PlanoContas"), 1, 2) = "03" Then
                If FormatNumber(DrDRE("Saldo"), 2) > FormatNumber(0, 2) Then
                    DRnovoCP("ValorDebito") = 0
                    DRnovoCP("ValorCredito") = FormatNumber(DrDRE("Saldo"), 2)
                Else
                    DRnovoCP("ValorDebito") = (FormatNumber(DrDRE("Saldo"), 2) * -1)
                    DRnovoCP("ValorCredito") = 0
                End If
            End If

            If Mid(DrDRE("PlanoContas"), 1, 2) = "04" Then
                If FormatNumber(DrDRE("Saldo"), 2) > FormatNumber(0, 2) Then
                    DRnovoCP("ValorDebito") = 0
                    DRnovoCP("ValorCredito") = FormatNumber(DrDRE("Saldo"), 2)
                Else
                    DRnovoCP("ValorDebito") = (FormatNumber(DrDRE("Saldo"), 2) * -1)
                    DRnovoCP("ValorCredito") = 0
                End If
            End If


            DRnovoCP("Historico") = "Saldo : " & DrDRE("Descrição")
            DRnovoCP("Empresa") = CodEmpresa
            DRnovoCP("IdLancamento") = "FimAno"
            DRnovoCP("IdProcura") = Ult
            DRnovoCP("IdOrigem") = "0"
            DRnovoCP("NotaFiscal") = "0"

            TBLAnoVelho.Rows.Add(DRnovoCP)

            Me.MyBarra.PerformStep()
        Next DrDRE


        Try
            Me.MyBarra.Text = "Aguarde Salvando os Lançamentos de Saldos."
            Dim objCommandBuilderNovoAno As New OleDb.OleDbCommandBuilder(DAAnoNovo)
            DAAnoNovo.Update(DS, Ano_Transferir)
        Catch ex As Exception
            MsgBox("Ocorreram erros ao salvar os lançamento de saldos" & Chr(13) & ex.Message, 64, "Validação de Dados")
            Exit Sub
        End Try


        Try
            Me.MyBarra.Text = "Aguarde Salvando os Lançamentos do Dre."
            Dim objCommandBuilderDRE As New OleDb.OleDbCommandBuilder(DAAnoVelho)
            DAAnoVelho.Update(DS, Ano_Fechar)
        Catch ex As Exception
            MsgBox("Ocorreram erros ao salvar os lançamentos do DRE" & Chr(13) & ex.Message, 64, "Validação de Dados")
            Exit Sub
        End Try

        ' Se tudo ocorrer bem Fecha o ano contabil

        Dim Sql1 As String = "INSERT INTO FechAnoContabil (AnoContabil, Empresa, Descricao) VALUES (@1, @2, @3)"

        Dim cmd As New OleDb.OleDbCommand(Sql1, Cnn)
        Try
            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.AnoFechar.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", "Fechado por " & UserAtivo & " no Dia " & DataDia & " horas " & FormatDateTime(DateTime.Now, DateFormat.LongTime)))
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Ocorreram erros ao salvar o Fechamento do Ano." & Chr(13) & ex.Message, 64, "Validação de Dados")
            Exit Sub
        End Try

        DS.Dispose()
        Cnn.Close()

        MsgBox("Fechamento Finalizado", 64, "Validação de Dados")
        Me.Close()
        Me.Dispose()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub btFechamentoAnual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechamentoAnual.Click
        FechamentoAno()
    End Sub

    Private Sub AnoFechar_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles AnoFechar.Leave
        If Me.AnoFechar.Text <> "" Then
            Me.DiaFinalAno.Text = "31/12/" & Me.AnoFechar.Text
        End If
    End Sub

    Private Sub AnoTransferir_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles AnoTransferir.Leave
        If Me.AnoTransferir.Text <> "" Then
            Me.DiaInicalNovoAno.Text = "01/01/" & Me.AnoTransferir.Text
        End If
    End Sub


    Private Sub ContaSaldoDre_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContaSaldoDre.Validated
        LocalizaDadosPlanoContas()
    End Sub



    Public Sub LocalizaDadosPlanoContas()

        If Me.ContaSaldoDre.Text = "" Then
            Exit Sub
        End If

        Dim Sql As String = "Select * from PlanoContas Where IdContas = '" & Me.ContaSaldoDre.Text & "' and Empresa = " & CodEmpresa

        Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.ContaSaldoDreDesc.Text = DR.Item("Descrição") & ""
        End If
        DR.Close()

    End Sub


    Public Sub AchaTable(ByVal TabelaNova As String)


        Dim Con As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Con.Open()


        Dim dbSchema As DataTable = Con.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, TabelaNova, "TABLE"})

        Con.Close()

        If dbSchema.Rows.Count > 0 Then
            ' ... Se a table existir 
            Exit Sub
        Else

            ' ... se a Table não exists
            Dim sSql As String
            sSql = "CREATE TABLE " & TabelaNova & "(Id COUNTER, DataLancamento DATETIME, PlanoContas TEXT(20), ContraPartida TEXT(20),Documento TEXT(15),DataDocumento DATETIME, ValorDebito CURRENCY, ValorCredito CURRENCY, Historico MEMO, Empresa INTEGER, IdLancamento TEXT(15),IdProcura TEXT(22), IdOrigem INTEGER, NotaFiscal DOUBLE, Constraint PrimaryKey PRIMARY KEY(ID))"

            Dim cmd As New OleDb.OleDbCommand(sSql, Con)
            Con.Open()

            cmd.ExecuteNonQuery()

            sSql = "CREATE INDEX DataLancamento ON " & TabelaNova & " (DataLancamento)"

            cmd.CommandText = sSql
            cmd.ExecuteNonQuery()

            Con.Close()
        End If

    End Sub

 
End Class