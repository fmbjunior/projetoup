Public Class ClientesVerSaldoCredito

    Private Sub btFindClintes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindClintes.Click
        RetornoProcura = ""
        My.Forms.ClientesProcura.ShowDialog()
        If Me.Cliente.Text <> "" Then
            LocalizaDados()
        End If
    End Sub


    Public Sub LocalizaDados()
        If Me.Cliente.Text = "" Then
            Exit Sub
        End If
        'String para filtragem de clientes na base de dados

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT * from clientes WHERE Clientes.Empresa = " & CodEmpresa & " AND Clientes.Codigo = " & Me.Cliente.Text


        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()


        If DR.HasRows Then
            Me.ClienteDesc.Text = DR.Item("Nome")
            Me.UsarLimite.Checked = DR.Item("UsarLimite")
            Me.LimiteMensal.Text = FormatNumber(DR.Item("LimiteMensal"), 2)
            Me.VendaVista.Checked = DR.Item("VendaVista")
            Me.VendaCheque.Checked = DR.Item("VendaCheque")
            Me.VendaCrediario.Checked = DR.Item("VendaCrediario")
        End If

        DR.Close()
        CNN.Close()

        VerDebitoCliente()

    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ClientesVerSaldoCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cliente.Focus()
    End Sub

    Private Sub VerDebitoCliente()
        If Me.Cliente.Text = "" Then
            Exit Sub
        End If

        Dim CnnFind As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CnnFind.Open()

        Dim Sql As String = "SELECT Receber.CodCliente AS Cliente, Sum(Receber.ValorDocumento) AS Total FROM Receber WHERE (((Receber.Recebimento) Is Null) AND ((Receber.Baixado)=False) And ((Receber.Inativo)=False) AND ((Receber.Empresa)=" & CodEmpresa & ")) GROUP BY Receber.CodCliente HAVING (((Receber.CodCliente)=" & Me.Cliente.Text & ")); UNION SELECT ArquivoCheque.Cliente, Sum(ArquivoCheque.ValorCh) AS Total FROM ArquivoCheque WHERE (((ArquivoCheque.DataBaixa) Is Null) AND ((ArquivoCheque.Empresa)=" & CodEmpresa & ")) GROUP BY ArquivoCheque.Cliente HAVING (((ArquivoCheque.Cliente)=" & Me.Cliente.Text & "));"
        Dim CMD As New OleDb.OleDbCommand(Sql, CnnFind)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        Dim VlrDebito As Double = 0

        While DR.Read
            VlrDebito = NzZero(DR.Item("Total"))
        End While

        Me.EmDebito.Text = FormatNumber(NzZero(VlrDebito), 2)
        Me.Saldo.Text = FormatNumber(NzZero(Me.LimiteMensal.Text) - NzZero(VlrDebito), 2)

        DR.Close()
        CnnFind.Close()
    End Sub

    Private Sub Cliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cliente.KeyDown
        If e.KeyCode = Keys.F5 Then
            RetornoProcura = ""
            My.Forms.ClientesProcura.ShowDialog()
            If Me.Cliente.Text <> "" Then
                LocalizaDados()
            End If
        End If
    End Sub

    Private Sub Cliente_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cliente.Validated
        If String.CompareOrdinal(Me.Cliente.Text, Me.Cliente.TextoAntigo) Then
            LocalizaDados()
        End If
    End Sub
End Class