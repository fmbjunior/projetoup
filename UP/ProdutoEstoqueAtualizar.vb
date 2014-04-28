Public Class ProdutoEstoqueAtualizar

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged
        If Me.A1.Checked = True Then
            Me.PainelProdutos.Visible = True
            Me.Produto.Focus()
        End If
        If Me.A2.Checked = True Then
            Me.PainelProdutos.Visible = False
        End If
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

  

    Public Sub LocalizaDadosProduto()

        If Me.Produto.Text = "" Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT * From Produtos Where CodigoProduto = " & Me.Produto.Text

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.ProdutoDesc.Text = DR.Item("Descrição") & ""
        End If
        DR.Close()
        CNN.Close()

    End Sub

    Private Sub Produto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Produto.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ProcuraProduto.ShowDialog()
            LocalizaDadosProduto()
            Me.Produto.Focus()
        End If
    End Sub

    Private Sub btAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAtualizar.Click
        If Me.A1.Checked = True And Me.Produto.Text = "" Then
            MessageBox.Show("O usuário deve informar um produto.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        'Zerar Quantidade
        Dim SqlZerar As String = String.Empty
        If A1.Checked = True Then
            SqlZerar = "UPDATE Produtos SET Produtos.QuantidadeEstoque = 0, Produtos.EstoqueFiscal = 0 WHERE (((Produtos.CodigoProduto)=" & Me.Produto.Text & "));"
        End If
        If A2.Checked = True Then
            SqlZerar = "UPDATE Produtos SET Produtos.QuantidadeEstoque = 0, Produtos.EstoqueFiscal = 0;"
        End If
        Dim CmdZerar As New OleDb.OleDbCommand(SqlZerar, CNN)
        CmdZerar.ExecuteNonQuery()
        'Fim


        Dim Ds As New DataSet()
        Dim Sql As String = String.Empty

        If A1.Checked = True Then
            Sql = "SELECT EstoqueUP.CodigoProduto, Sum(EstoqueUP.Qtd) AS SomaDeQtd, Sum(EstoqueUP.QtdF) AS SomaDeQtdF FROM(EstoqueUP) GROUP BY EstoqueUP.CodigoProduto HAVING (((EstoqueUP.CodigoProduto)=" & Me.Produto.Text & "));"
        End If

        If A2.Checked = True Then
            Sql = "SELECT EstoqueUP.CodigoProduto, Sum(EstoqueUP.Qtd) AS SomaDeQtd, Sum(EstoqueUP.QtdF) AS SomaDeQtdF FROM(EstoqueUP) GROUP BY EstoqueUP.CodigoProduto;"
        End If

        Dim DAEstoqueUP As New OleDb.OleDbDataAdapter(Sql, CNN)
        DAEstoqueUP.Fill(Ds, "EstoqueUP")

        Sql = "SELECT CodigoProduto,QuantidadeEstoque,EstoqueFiscal From Produtos"
        Dim DAProdutos As New OleDb.OleDbDataAdapter(Sql, CNN)
        DAProdutos.Fill(Ds, "Produtos")

        Dim TotalLinhas As Integer = Ds.Tables("EstoqueUP").Rows.Count
        If TotalLinhas = 0 Then TotalLinhas = 1
        MyBarra.Visible = True
        MyBarra.Minimum = 1
        MyBarra.Maximum = TotalLinhas
        MyBarra.Value = 1
        MyBarra.Step = 1

        Dim DrEstoque As DataRow
        For Each DrEstoque In Ds.Tables("EstoqueUP").Rows
            Dim DrProdutos() As DataRow
            DrProdutos = Ds.Tables("Produtos").Select("CodigoProduto = " & DrEstoque("CodigoProduto").ToString)

            If DrProdutos.Length <> 0 Then

                DrProdutos(0).BeginEdit()
                DrProdutos(0)("QuantidadeEstoque") = DrEstoque("SomaDeQtd")
                DrProdutos(0)("EstoqueFiscal") = DrEstoque("SomaDeQtdF")
                DrProdutos(0).EndEdit()
            End If

            MyBarra.PerformStep()
            MyBarra.Refresh()
        Next

        Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAProdutos)
        DAProdutos.Update(Ds, "Produtos")

        Ds.Dispose()
        CNN.Close()
        Me.MyBarra.Visible = False
        MessageBox.Show("Estoque de Produtos atualizado com sucesso", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        GerarLog(Me.Text, AçãoTP.Confirmou, Me.Produto.Text)
        Me.Close()
        Me.Dispose()



    End Sub

    Private Sub btFindProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindProduto.Click
        My.Forms.ProcuraProduto.ShowDialog()
        LocalizaDadosProduto()
        Me.Produto.Focus()
    End Sub

    Private Sub Produto_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Produto.Validated
        If String.CompareOrdinal(Me.Produto.Text, Me.Produto.TextoAntigo) Then
            LocalizaDadosProduto()
        End If
    End Sub
End Class