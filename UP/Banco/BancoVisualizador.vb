Public Class BancoVisualizador
 
    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Codigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Codigo.KeyDown
        If e.KeyCode = Keys.F5 Then
            If Con = False Then
                MsgBox("O Usuário não tem permissão para consultar o registro, verifique com o Administrador.", 64, "Validação de Dados")
                Exit Sub
            End If

            My.Forms.TelaProcuraBancoCC.ShowDialog()
            Me.Codigo.Focus()


        End If
    End Sub

    Public Sub LocalizaDados()
        If Con = False Then
            MsgBox("O Usuário não tem permissão para consultar o registro, verifique com o Administrador.", 64, "Validação de Dados")
            Me.Codigo.Clear()
            Me.Codigo.Focus()
            Exit Sub
        End If

        If Me.Codigo.Text = "" Then Exit Sub

        Dim DBOpen As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        DBOpen.Open()

        Dim Sql As String = "Select * from Banco where Codigo = '" & Me.Codigo.Text & "' and Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, DBOpen)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.Codigo.Text = DR.Item("Codigo") & ""
            Me.ContaCorrente.Text = DR.Item("ContaCorrente") & ""
            Me.Agencia.Text = DR.Item("Agencia") & ""
            Me.Banco.Text = DR.Item("NomeBanco") & ""

        Else
            MsgBox("Verique...Conta inexistente.", 64, "Validação de Dados")
            Me.Codigo.Clear()
            Me.Codigo.Focus()
            Exit Sub
        End If
        DR.Close()
    End Sub

    Private Sub Codigo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Codigo.Validated
        If Me.Codigo.Text = "" Or Me.Codigo.Text = 0 Then Exit Sub
        LocalizaDados()
    End Sub


    Private Sub BTCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTCC.Click

        Dim cxFechado As New CaixaFechado
        cxFechado.CaixaEstaFechado()

        TRVDados(UserAtivo, "BancosContaCorrente")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.BancosContaCorrente.ShowDialog()
        End If
    End Sub

    Private Sub Lançamentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lançamentos.Click
        TRVDados(UserAtivo, "BancoLançamento")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            If nzINT(Me.Codigo.Text) = 0 Then
                MessageBox.Show("Favor informar a conta para fazer o lançamento", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            My.Forms.BancoLançamento.ShowDialog()
        End If
    End Sub

    Private Sub Compensar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Compensar.Click
        If Me.Codigo.Text = "" Then
            Exit Sub
        End If
        TRVDados(UserAtivo, "BancoCompensar")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.BancoCompensar.ShowDialog()
        End If
    End Sub

    Private Sub Extrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Extrato.Click
        If Me.Codigo.Text = "" Then
            Exit Sub
        End If
        TRVDados(UserAtivo, "BancoExtrato")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.BancoExtrato.ShowDialog()
        End If

    End Sub

    Private Sub Localizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Localizar.Click
        If Me.Codigo.Text = "" Then Exit Sub
        My.Forms.BancoProcurar.ShowDialog()
    End Sub

    Private Sub btFindCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindCC.Click
        If Con = False Then
            MsgBox("O Usuário não tem permissão para consultar o registro, verifique com o Administrador.", 64, "Validação de Dados")
            Exit Sub
        End If

        My.Forms.TelaProcuraBancoCC.ShowDialog()
        Me.Codigo.Focus()

    End Sub

    Private Sub VerMovimento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerMovimento.Click



        If Me.DataInicial.Text = "" Then
            MsgBox("O usuário deve informar a data inicial para o relatório.", 64, "Validação de Dados")
            Me.DataInicial.Focus()
            Exit Sub
        ElseIf Me.DataFinal.Text = "" Then
            MsgBox("O usuário deve informar a data Final para o relatório.", 64, "Validação de Dados")
            Me.DataFinal.Focus()
            Exit Sub
        End If


        'Salvar saldo Anterior
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()
        Dim Sql As String = "SELECT Sum(LancamentoBanco.ValorDocumento) AS SaldoAnterior FROM(LancamentoBanco) WHERE (((LancamentoBanco.ContaCorrente)= '" & Me.Codigo.Text & "') And ((LancamentoBanco.Tipo)= 'BANCO')  AND ((LancamentoBanco.DataLancamento)<#" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "#) AND ((LancamentoBanco.CaiuBanco)='S') AND ((LancamentoBanco.Empresa)=" & CodEmpresa & "));"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader

        Dim SaldoAnterior As Double = 0

        'If DR.HasRows Then
        While DR.Read
            SaldoAnterior = NzZero(DR.Item("SaldoAnterior"))
        End While
        'End If

        DR.Close()

        Sql = "Update Banco set Saldo = @1 Where Codigo = '" & Me.Codigo.Text & "'"
        CMD = New OleDb.OleDbCommand(Sql, CNN)

        CMD.Parameters.Add(New OleDb.OleDbParameter("@1", FormatNumber(SaldoAnterior, 2)))
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try

        'fim
        CNN.Close()
        CNN.Dispose()
        System.Threading.Thread.Sleep(3000)

        Dim Crypto As New ClCrypto 'Para descriptografar a senha do banco de dados
        Dim VerRelat As New CrystalDecisions.CrystalReports.Engine.ReportDocument()

        VerRelat.Load(DirRelat & "RelExtratoBancario.rpt")
        VerRelat.DataSourceConnections.Item(0).SetConnection("", LocalBD & Nome_BD, False)
        VerRelat.DataSourceConnections.Item(0).SetLogon("", Crypto.clsCrypto(SenhaBancoDados, False))
        VerRelat.DataDefinition.RecordSelectionFormula = "{Extrato.DataLancamento}>=Date (" & Format(CDate(Me.DataInicial.Text), "yyyy,MM,dd") & ") and {Extrato.DataLancamento}<=date(" & Format(CDate(Me.DataFinal.Text), "yyyy,MM,dd") & ") and {Extrato.Empresa} = " & CodEmpresa & " And {extrato.Tipo} = 'BANCO' And {extrato.ContaCorrente} = '" & Me.Codigo.Text & "'"


        Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
        T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
        T.Text = "Extrato Bancário no Período de : " & Me.DataInicial.Text & " a " & Me.DataFinal.Text
        VerRelat.DataDefinition.FormulaFields.Item("xUser").Text = "'" & UserAtivo & "'"
      

        Me.Visualizador.ReportSource = VerRelat


    End Sub

    Private Sub BancoVisualizador_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    
    Private Sub btChequePre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btChequePre.Click
        If Me.Codigo.Text = "" Then
            MessageBox.Show("O usuário deve selecionar uma conta antes de emitir o relatório.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        My.Forms.BancoRelChequePre.ShowDialog()
    End Sub
End Class