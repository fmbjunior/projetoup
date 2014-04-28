Public Class ProdutoEstoqueConsulta

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Produto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Produto.KeyDown
       
        If e.KeyCode = Keys.F5 Then
            Me.Produto.Clear()
            Me.Descrição.Clear()
            Me.QtdDisponivel.Clear()
            Me.EstDeposito.Clear()
            Me.EstoqueMedio.Clear()
            Me.ValorVenda.Clear()
            If Me.Produto.Text = "" Then
                My.Forms.ProcuraProduto.ShowDialog()
                LocalizaProduto()
            End If
        End If
    End Sub

    Public Sub LocalizaProduto()
        If Me.Produto.Text = "" Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT  Produtos.CodigoProduto, Produtos.Descrição, Produtos.ValorVenda, Produtos.EstDeposito, Sum(EstoqueUP.Qtd) AS SomaDeQtd, Sum(EstoqueUP.QtdF) AS SomaDeQtdF FROM Produtos INNER JOIN EstoqueUP ON Produtos.CodigoProduto = EstoqueUP.CodigoProduto GROUP BY Produtos.CodigoProduto, Produtos.Descrição, Produtos.ValorVenda, Produtos.EstDeposito HAVING (((Produtos.CodigoProduto)=" & Me.Produto.Text & "));"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        Dim Conv As Double = 0
        If DR.HasRows Then
            Me.Descrição.Text = DR.Item("Descrição") & ""
            Me.QtdDisponivel.Text = FormatNumber(Nz(DR.Item("SomaDeQtd"), 3), 4)
            Me.EstDeposito.Text = FormatNumber(Nz(DR.Item("EstDeposito"), 3), 4)
            Me.EstoqueMedio.Text = FormatNumber(Nz(DR.Item("SomaDeQtdF"), 3), 4)
            Me.ValorVenda.Text = FormatCurrency(Nz(DR.Item("ValorVenda"), 3), 2)
            DR.Close()
        Else
            MsgBox("Não existe movimentação de estoque deste produto, Verifique.", 64, "Validação de Dados")
            DR.Close()
            Me.Produto.Clear()
            Me.Produto.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub Produto_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Produto.Validated
        If String.CompareOrdinal(Me.Produto.Text, Me.Produto.TextoAntigo) Then
            LocalizaProduto()
        End If
    End Sub

   
    Private Sub btFindProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindProduto.Click
        Me.Produto.Clear()
        Me.Descrição.Clear()
        Me.QtdDisponivel.Clear()
        Me.EstDeposito.Clear()
        Me.EstoqueMedio.Clear()
        Me.ValorVenda.Clear()
        If Me.Produto.Text = "" Then
            If Me.Produto.Text = "" Then
                My.Forms.ProcuraProduto.ShowDialog()
                LocalizaProduto()
            End If
        End If
    End Sub


   
End Class