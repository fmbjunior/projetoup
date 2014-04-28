Public Class BancoExtrato

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Visualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Visualizar.Click
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
        Dim Sql As String = "SELECT Sum(LancamentoBanco.ValorDocumento) AS SaldoAnterior FROM(LancamentoBanco) WHERE (((LancamentoBanco.ContaCorrente)= '" & My.Forms.BancoVisualizador.Codigo.Text & "') And ((LancamentoBanco.Tipo)= 'BANCO')  AND ((LancamentoBanco.DataLancamento)<#" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "#) AND ((LancamentoBanco.CaiuBanco)='S') AND ((LancamentoBanco.Empresa)=" & CodEmpresa & "));"

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

        Sql = "Update Banco set Saldo = @1 Where Codigo = '" & My.Forms.BancoVisualizador.Codigo.Text & "'"
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

        RelatorioCarregar = "RelExtratoBancario"
        My.Forms.VisualizadorRelatorio.ShowDialog()

    End Sub

   
    Private Sub BancoExtrato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DataFinal.Text = DataDia
        Me.DataInicial.Text = DataDia.AddDays(-15)
    End Sub

End Class