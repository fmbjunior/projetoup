Public Class TelaProcuraMP

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPesquisar.Click

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT Produtos.CodigoProduto, Produtos.Descrição, Produtos.QuantidadeEstoque, Produtos.CustoMedio FROM Produtos WHERE Produtos.Descrição Like '%" & Me.txtProcura.Text & "%' AND Produtos.Tipo = 2 AND Produtos.Empresa =" & CodEmpresa & " Order by Produtos.Descrição"


        Dim da = New OleDb.OleDbDataAdapter(Sql, CNN)
        da.SelectCommand.CommandType = CommandType.Text
        Dim ds As New DataSet
        da.Fill(ds, "Mp")

        Me.MyLista.DataSource = ds.Tables("Mp").DefaultView

        da.Dispose()
        CNN.Close()
    End Sub

    Private Sub MyLista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MyLista.CellDoubleClick
        RetornoProcura = String.Empty

        Dim vID As Integer
        vID = CInt(Me.MyLista.CurrentRow.Cells(0).Value)
        RetornoProcura = vID
        Me.Close()
        Me.Dispose()
    End Sub

    
    Private Sub txtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProcura.Leave
        btPesquisar_Click(sender, e)
    End Sub
End Class