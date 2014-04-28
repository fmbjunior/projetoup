Public Class FolhaPgtoDecimoTerceiroGerador

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Gerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gerar.Click

        If Me.AnoAtual.Text = "" Then
            MsgBox("O usuário deve informar o ano para gerar o Décimo Terceiro.", 64, "Validação de Dados")
            Exit Sub
        End If
        If Me.CompetenciaBase.Text = "" Then
            MsgBox("O usuário deve informar a competência de base, para gerar o Décimo Terceiro.")
            Exit Sub
        End If


        If Me.ContaDecimoTerceiro.Text = "" Then
            MsgBox("O usuário deve informar a conta do Décimo Terceiro.")
            Me.ContaDecimoTerceiro.Focus()
            Exit Sub
        End If

        If Me.ContaInss.Text = "" Then
            MsgBox("O usuário deve informar a conta do Inss.")
            Me.ContaInss.Focus()
            Exit Sub
        End If


        Me.Cursor = Cursors.WaitCursor

        Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim DS As New DataSet()

        Dim Sql As String = String.Empty


        Sql = "SELECT * FROM FolhaPgtoDecimoTerceiroCab WHERE Empresa = " & CodEmpresa & " AND AnoAtual = '" & Me.AnoAtual.Text & "'"
        Dim DADecimoCab As New OleDb.OleDbDataAdapter(Sql, Cnn)
        DADecimoCab.Fill(DS, "FolhaPgtoDecimoTerceiroCab")

        Dim LinhasGerado As Integer = DS.Tables("FolhaPgtoDecimoTerceiroCab").Rows.Count
        If LinhasGerado = 1 Then
            MsgBox("Ja foi gerado o Décimo Terceiro para este ano base.", 64, "Validação de Dados")
            DS.Dispose()
            Cnn.Close()
            Me.Close()
            Me.Dispose()
            Me.Cursor = Cursors.Default
            Exit Sub
        End If




        Sql = "SELECT * FROM Funcionários WHERE Empresa = " & CodEmpresa & " AND Inativo = False and DataRecisao Is Null and DataAdmissão is not null And GeraMovimentoFolha ='S' order by Nome"
        Dim DAFuncionarios As New OleDb.OleDbDataAdapter(Sql, Cnn)
        DAFuncionarios.Fill(DS, "Funcionários")

        Sql = "SELECT * FROM FolhaPgtoDecimoTerceiro WHERE Empresa = " & CodEmpresa & " AND AnoAtual = '" & Me.AnoAtual.Text & "'"
        Dim DADecimoT As New OleDb.OleDbDataAdapter(Sql, Cnn)
        DADecimoT.Fill(DS, "FolhaPgtoDecimoTerceiro")


        Sql = "SELECT * FROM FolhaPgtoTributos WHERE Empresa = " & CodEmpresa & " AND Competencia = '" & Me.CompetenciaBase.Text & "'"
        Dim DATributos As New OleDb.OleDbDataAdapter(Sql, Cnn)
        DATributos.Fill(DS, "Tributos")

        Dim TributoLinha() As DataRow
        TributoLinha = DS.Tables("Tributos").Select("Competencia = '" & Me.CompetenciaBase.Text & "'")




        Dim TotalLinhas As Integer = DS.Tables("Funcionários").Rows.Count
        'Atualiza a barra de Progresso
        If TotalLinhas = 0 Then TotalLinhas = 1
        MyBarra.Visible = True
        MyBarra.Minimum = 1
        MyBarra.Maximum = TotalLinhas
        MyBarra.Value = 1
        MyBarra.Step = 1

        Dim DrFuncionarios As DataRow
        For Each DrFuncionarios In DS.Tables("Funcionários").Rows

            Dim TBLDecimo As DataTable
            TBLDecimo = DS.Tables("FolhaPgtoDecimoTerceiro")
            ' Obtem um novo objeto DataRow do DataTable
            Dim DRnovo As DataRow
            DRnovo = TBLDecimo.NewRow()
            DRnovo("AnoAtual") = Me.AnoAtual.Text
            DRnovo("Funcionario") = DrFuncionarios("CódigoFuncionário")
            DRnovo("SalarioRegistro") = FormatNumber(NzZero(DrFuncionarios("SalarioRegistro")), 2)
            DRnovo("SalarioDif") = FormatNumber(NzZero(DrFuncionarios("Salario")), 2)
            DRnovo("OutrosVlrs") = FormatNumber(0, 2)
            DRnovo("Total") = FormatNumber(CDbl(NzZero(DrFuncionarios("SalarioRegistro"))) + CDbl(NzZero(DrFuncionarios("Salario"))), 2)
            'Calcula os meses Para o Décimo Terceiro
            Dim DataFin As Date = "31/12/" & Me.AnoAtual.Text
            Dim DataIni As Date = DrFuncionarios("DataAdmissão")
            Dim resultadoDIAS As Integer = DateDiff(DateInterval.Day, DataIni, DataFin)
            Dim MesesPagar As Integer = 0

            If resultadoDIAS > 365 Then
                MesesPagar = 12
            Else
                MesesPagar = resultadoDIAS / 30
            End If
            DRnovo("Meses") = MesesPagar
            DRnovo("VlrDecimo") = FormatNumber(((CDbl(NzZero(DrFuncionarios("SalarioRegistro"))) + CDbl(NzZero(DrFuncionarios("Salario")))) / 12) * MesesPagar, 2)

            'Rotinas para Calcular o Inss
            If CDbl(NzVlr(DrFuncionarios("SalarioRegistro").ToString())) <= CDbl(NzVlr(TributoLinha(0)("ValorFaixa1"))) Then
                DRnovo("Inss") = FormatNumber((((NzZero(DrFuncionarios("SalarioRegistro")) / 12)) * MesesPagar) * CDbl(TributoLinha(0)("PercFaixa1")) / 100, 2)
            End If

            If CDbl(NzVlr(DrFuncionarios("SalarioRegistro").ToString())) > CDbl(NzVlr(TributoLinha(0)("ValorFaixa1"))) And CDbl(NzVlr(DrFuncionarios("SalarioRegistro").ToString())) <= CDbl(NzVlr(TributoLinha(0)("ValorFaixa2"))) Then
                DRnovo("Inss") = FormatNumber((((NzZero(DrFuncionarios("SalarioRegistro")) / 12)) * MesesPagar) * CDbl(TributoLinha(0)("PercFaixa2")) / 100, 2)
            End If

            If CDbl(NzVlr(DrFuncionarios("SalarioRegistro").ToString())) > CDbl(NzVlr(TributoLinha(0)("ValorFaixa2"))) And CDbl(NzVlr(DrFuncionarios("SalarioRegistro").ToString())) <= CDbl(NzVlr(TributoLinha(0)("ValorFaixa3"))) Then
                DRnovo("Inss") = FormatNumber((((NzZero(DrFuncionarios("SalarioRegistro")) / 12)) * MesesPagar) * CDbl(TributoLinha(0)("PercFaixa3")) / 100, 2)
            End If


            If CDbl(NzVlr(DrFuncionarios("SalarioRegistro").ToString())) > CDbl(NzVlr(TributoLinha(0)("ValorFaixa3"))) Then
                DRnovo("Inss") = FormatNumber((((NzZero(TributoLinha(0)("ValorFaixa3")) / 12) * MesesPagar) * NzZero(TributoLinha(0)("PercFaixa3"))) / 100, 2)
            End If


            DRnovo("Desc1Pa") = FormatNumber(0)
            DRnovo("1Parcela") = FormatNumber((DRnovo("VlrDecimo") / 2) - DRnovo("Desc1Pa"), 2)
            DRnovo("Desc2Pa") = FormatNumber(0)
            DRnovo("2Parcela") = CDbl(NzZero(DRnovo("VlrDecimo"))) - CDbl(NzZero(DRnovo("1Parcela"))) - CDbl(NzZero(DRnovo("Inss"))) - DRnovo("Desc2Pa")
            DRnovo("Empresa") = CodEmpresa
            DRnovo("Debito") = Me.ContaDecimoTerceiro.Text
            DRnovo("Credito") = DrFuncionarios("CodPlanoContas")
            DRnovo("ContaInss") = Me.ContaInss.Text

            TBLDecimo.Rows.Add(DRnovo)

            MyBarra.PerformStep()
            Me.Refresh()
        Next DrFuncionarios


        'Gerar Cabeçalho do décimo Terceiro
        Dim TBLDecimoCab As DataTable
        TBLDecimoCab = DS.Tables("FolhaPgtoDecimoTerceiroCab")
        ' Obtem um novo objeto DataRow do DataTable
        Dim DRnovoCab As DataRow
        DRnovoCab = TBLDecimoCab.NewRow()
        DRnovoCab("AnoAtual") = Me.AnoAtual.Text
        DRnovoCab("Descrição") = "Décimo Terceiro Ano: " & Me.AnoAtual.Text
        DRnovoCab("Empresa") = CodEmpresa
        TBLDecimoCab.Rows.Add(DRnovoCab)

        Dim objCommandBuilderCab As New OleDb.OleDbCommandBuilder(DADecimoCab)
        DADecimoCab.Update(DS, "FolhaPgtoDecimoTerceiroCab")

        Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DADecimoT)
        DADecimoT.Update(DS, "FolhaPgtoDecimoTerceiro")

        DS.Dispose()
        Cnn.Close()
        Me.Cursor = Cursors.Default
        MsgBox("Décimo Terceiro gerado com sucesso.", 64, "Validação de Dados")

    End Sub

    Private Sub FolhaPgtoDecimoTerceiroGerador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()
    End Sub

    Private Sub Degrade()
        Try
            Dim CCor() As String
            Dim corTemp As String

            corTemp = Cor1TelaPrimaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))

            corTemp = Cor2TelaPrimaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))
        Catch ex As Exception
        End Try
    End Sub

End Class