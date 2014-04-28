Public Class SellShoesResumoVenda
    Dim vMes As Byte
    Public vcodigo As Integer
    Public vnome As String
    Private Sub btnfechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub SellShoesResumoVenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mes As DateTime = DataDia
        Dim primeirodia As DateTime = Convert.ToDateTime("01/" + mes.ToString("MM/yyyy"))
        Me.A.Text = String.Format("{0:t}", primeirodia.ToShortDateString)
        Me.B.Text = mes.ToShortDateString

        Dim conn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        conn.Open()

        Dim sql As String = "SELECT Sum(Pedido.TotalPedido) AS SomaDeTotalPedido, Pedido.CódigoFuncionário, Funcionários.Nome FROM Pedido INNER JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário WHERE (((Pedido.DataFechamento) Between #" & Format(CDate(Me.A.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.B.Text), "MM/dd/yyyy") & "#)) GROUP BY Pedido.CódigoFuncionário, Funcionários.Nome HAVING (((Pedido.CódigoFuncionário)=" & vcodigo & "));"
        ' "SELECT Sum(Pedido.TotalPedido) AS SomaDeTotalPedido, Pedido.CódigoFuncionário, Funcionários.Nome FROM Pedido INNER JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário WHERE (((Pedido.DataFechamento) Between #" & Format(CDate(Me.A.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.B.Text), "MM/dd/yyyy") & "#)) GROUP BY Pedido.CódigoFuncionário, Funcionários.Nome HAVING (((Pedido.CódigoFuncionário)=" & vcodigo & "));"
        Dim     sqlHoje As String = "SELECT Sum(Pedido.TotalPedido) AS SomaDeTotalPedido, Pedido.CódigoFuncionário, Funcionários.Nome FROM Pedido INNER JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário WHERE(((Pedido.DataFechamento) = #" & Format(CDate(Me.B.Text), "MM/dd/yyyy") & "#)) GROUP BY Pedido.CódigoFuncionário, Funcionários.Nome HAVING (((Pedido.CódigoFuncionário)=" & vcodigo & "));"

        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        Dim cmd1 As New OleDb.OleDbCommand(sqlHoje, conn)
        Dim     oDA As New OleDb.OleDbDataAdapter(cmd)
        Dim oDA1 As New OleDb.OleDbDataAdapter(cmd1)
        Dim ds As New DataSet
        oDA.Fill(ds, "TB")
        oDA1.Fill(ds, "HOJE")

        'Me.lblVendedor.Text = ds.Tables("TB").Rows(0).Item("Nome").ToString
        If ds.Tables("TB").Rows.Count = 0 Then
            Me.lblTotalVendas.Text = "TOTAL DE VENDAS..: " & FormatCurrency(0, 2)

        Else
            Me.lblTotalVendas.Text = "TOTAL DE VENDAS..: " & FormatCurrency(ds.Tables("TB").Rows(0).Item("SomaDeTotalPedido").ToString, 2)

        End If

        If ds.Tables("HOJE").Rows.Count = 0 Then
            Me.lblVendasHoje.Text = "VENDAS DE HOJE..: " & FormatCurrency(0, 2)
        Else
            Me.lblVendasHoje.Text = "VENDAS DE HOJE..: " & FormatCurrency(ds.Tables("HOJE").Rows(0).Item("SomaDeTotalPedido").ToString, 2)
            End If

    End Sub
End Class