Public Class VerLimiteCreditoCliente

    Private Sub btClienteFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClienteFind.Click
        Me.NomeCliente.Clear()
        Me.LimiteCredito.Text = FormatNumber(0, 2)

        My.Forms.ClientesProcura.ShowDialog()
        LocalizaDadosCliente()
        Me.CódigoCliente.Focus()
    End Sub

    Private Sub CódigoCliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CódigoCliente.KeyDown
        If e.KeyCode = Keys.F5 Then
            Me.NomeCliente.Clear()
            Me.LimiteCredito.Text = FormatNumber(0, 2)

            My.Forms.ClientesProcura.ShowDialog()
            LocalizaDadosCliente()
            Me.CódigoCliente.Focus()
        End If
    End Sub

    Public Sub LocalizaDadosCliente()

        If Me.CódigoCliente.Text = "" Then
            Exit Sub
        End If
        Me.SaldoLimiteCredito.ForeColor = Color.Black

        Dim CnnFind As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CnnFind.Open()

        Dim Sql As String = "Select * from Clientes where Codigo = " & Me.CódigoCliente.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CnnFind)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then

            Me.NomeCliente.Text = DR.Item("Nome") & ""
            Me.UsarLimite.Checked = DR.Item("UsarLimite")
            Me.LimiteCredito.Text = FormatNumber(Nz(DR.Item("LimiteMensal"), 3), 2)

        Else
            MessageBox.Show("Cliente não localizado, Verifique.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.CódigoCliente.Clear()
            Me.NomeCliente.Clear()
            Me.UsarLimite.Checked = False
            Me.LimiteCredito.Text = FormatNumber(0, 2)
            Me.EmDebito.Text = FormatNumber(0, 2)
            Me.SaldoLimiteCredito.Text = FormatNumber(0, 2)
            Me.CódigoCliente.Focus()
        End If

        DR.Close()
        CnnFind.Close()

        If UsarLimite.Checked = True Then
            VerDebitoCliente()
            Me.SaldoLimiteCredito.Text = FormatNumber(NzZero(Me.LimiteCredito.Text) - NzZero(Me.EmDebito.Text), 2)

            Dim PercentualGasto As Double = (NzZero(Me.SaldoLimiteCredito.Text) / NzZero(Me.LimiteCredito.Text)) * 100

            If PercentualGasto > 70 Then Me.SaldoLimiteCredito.ForeColor = Color.Green
            If PercentualGasto < 70 And PercentualGasto > 35 Then Me.SaldoLimiteCredito.ForeColor = Color.Blue
            If PercentualGasto < 35 Then Me.SaldoLimiteCredito.ForeColor = Color.Red

        Else
            Me.SaldoLimiteCredito.Text = FormatNumber(NzZero(0), 2)
        End If
    End Sub

    Private Sub VerDebitoCliente()
        If Me.CódigoCliente.Text = "" Then
            Exit Sub
        End If

        Dim CnnFind As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CnnFind.Open()

        Dim Sql As String = "SELECT Receber.CodCliente AS Cliente, Sum(Receber.ValorDocumento) AS Total FROM Receber WHERE (((Receber.Recebimento) Is Null) AND ((Receber.Baixado)=False) AND ((Receber.Empresa)=" & CodEmpresa & ")) GROUP BY Receber.CodCliente HAVING (((Receber.CodCliente)=" & Me.CódigoCliente.Text & ")); UNION SELECT ArquivoCheque.Cliente, Sum(ArquivoCheque.ValorCh) AS Total FROM ArquivoCheque WHERE (((ArquivoCheque.DataBaixa) Is Null) AND ((ArquivoCheque.Empresa)=" & CodEmpresa & ")) GROUP BY ArquivoCheque.Cliente HAVING (((ArquivoCheque.Cliente)=" & Me.CódigoCliente.Text & "));"
        Dim CMD As New OleDb.OleDbCommand(Sql, CnnFind)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        Dim VlrDebito As Double = 0

        While DR.Read
            VlrDebito += NzZero(DR.Item("Total"))
        End While

        Me.EmDebito.Text = FormatNumber(NzZero(VlrDebito), 2)

        DR.Close()
        CnnFind.Close()
    End Sub

    
    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        Me.UsarLimite.Checked = False
        Me.CódigoCliente.Clear()
        Me.NomeCliente.Clear()
        Me.LimiteCredito.Clear()
        Me.EmDebito.Clear()
        Me.SaldoLimiteCredito.Clear()
        Me.CódigoCliente.Focus()
    End Sub

    Private Sub CódigoCliente_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CódigoCliente.Validating
        If String.CompareOrdinal(Me.CódigoCliente.Text, Me.CódigoCliente.TextoAntigo) Then
            LocalizaDadosCliente()
        End If
    End Sub
End Class