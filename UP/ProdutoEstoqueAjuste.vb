Public Class ProdutoEstoqueAjuste

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

        Dim Sql As String = "SELECT Produtos.CodigoProduto, Produtos.Descrição, Sum(EstoqueUP.Qtd) AS SomaDeQtd, Sum(EstoqueUP.QtdF) AS SomaDeQtdF FROM Produtos LEFT JOIN EstoqueUP ON Produtos.CodigoProduto = EstoqueUP.CodigoProduto GROUP BY Produtos.CodigoProduto, Produtos.Descrição HAVING (((Produtos.CodigoProduto)=" & Me.Produto.Text & " ));"
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.ProdutoDesc.Text = DR.Item("Descrição") & ""
            Me.EstGeral.Text = FormatNumber(NzZero(DR.Item("SomaDeQtd")), 4)
            Me.EstNF.Text = FormatNumber(NzZero(DR.Item("SomaDeQtdF")), 4)

            Me.EstGeralReal.Clear()
            Me.EstNFReal.Clear()

            Me.EstGeralDif.Clear()
            Me.EstNFDif.Clear()

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


    Private Sub Produto_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Produto.Validated
        If String.CompareOrdinal(Me.Produto.Text, Me.Produto.TextoAntigo) Then
            LocalizaDadosProduto()
        End If
    End Sub

    Private Sub EstControladaReal_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstNFReal.Validated
        Me.EstGeralDif.Text = FormatNumber(NzZero(Me.EstGeralReal.Text) - NzZero(Me.EstGeral.Text), 4)

        Me.EstNFDif.Text = FormatNumber(NzZero(Me.EstNFReal.Text) - NzZero(Me.EstNF.Text), 4)
    End Sub

    Private Sub btAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAtualizar.Click

        If Me.Produto.Text = "" Then
            MessageBox.Show("O usuário deve informar antes o produto para atualizar", "Validação de Dados", MessageBoxButtons.OK)
            Exit Sub
        End If

        Dim Ação As New TrfGerais
        If MsgBox("Deseja realmente atualizar o estoque para as informações digitadas.", 36, "Validação de Dados") = 6 Then

            Me.Cursor = Cursors.WaitCursor
            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String

            Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
            Dim cmd As OleDb.OleDbCommand = CNN.CreateCommand
            cmd.Transaction = Transacao

            Try


                Sql = "INSERT INTO EstoqueUP ( CodigoProduto, Qtd, QtdF, Tipo, IdLancamento, DataLancamento, PedidoOrdem, Prg, NFDoc, ClienteFornecedor ) Values (" & Me.Produto.Text & ", '" & Me.EstGeralDif.Text & "', '" & Me.EstNFDif.Text & "', 'A', 0, #" & Format(CDate(DataDia), "MM/dd/yyyy") & "#, 0, 'AJUSTE', 0 , 'AJUSTE DE ESTOQUE')"
                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()

                Transacao.Commit()
                CNN.Close()
                AtProduto()

                MsgBox("Atualização Confirmado com Sucesso.", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Confirmou, Me.Produto.Text)
                Ação.LimpaTextBox(Me)
                Me.Produto.Focus()

                Me.Cursor = Cursors.Default

            Catch ex As Exception
                Transacao.Rollback()
                CNN.Close()
                MsgBox(ex.Message, 64, "Validação de Dados")
                MsgBox("Erro ao confirmar a Atualização, tente confirmar novamente ou consulte o administrador.", 64, "Validação de Dados")
                Exit Sub
            End Try

        Else
            MessageBox.Show("Operação cancelada pelo usuário", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Ação.LimpaTextBox(Me)
            Me.Produto.Focus()
            Exit Sub
        End If

    End Sub


    Private Sub AtProduto()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Ds As New DataSet()

        Dim Sql As String = String.Empty

        Sql = "SELECT EstoqueUP.CodigoProduto, Sum(EstoqueUP.Qtd) AS SomaDeQtd, Sum(EstoqueUP.QtdF) AS SomaDeQtdF FROM(EstoqueUP) GROUP BY EstoqueUP.CodigoProduto HAVING (((EstoqueUP.CodigoProduto)=" & Me.Produto.Text & "));"

        Dim DAEstoqueEFocus As New OleDb.OleDbDataAdapter(Sql, CNN)
        DAEstoqueEFocus.Fill(Ds, "EstoqueUP")

        Sql = "SELECT * From Produtos"
        Dim DAProdutos As New OleDb.OleDbDataAdapter(Sql, CNN)
        DAProdutos.Fill(Ds, "Produtos")

        Dim DrEstoque As DataRow
        For Each DrEstoque In Ds.Tables("EstoqueUP").Rows
            Dim DrProdutos() As DataRow
            DrProdutos = Ds.Tables("Produtos").Select("CodigoProduto = " & DrEstoque("CodigoProduto").ToString)

            If DrProdutos.Length <> 0 Then
                DrProdutos(0).BeginEdit()
                DrProdutos(0)("QuantidadeEstoque") = NzZero(DrEstoque("SomaDeQtd"))
                DrProdutos(0)("EstoqueFiscal") = NzZero(DrEstoque("SomaDeQtdF"))
                DrProdutos(0).EndEdit()
            End If

        Next

        Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAProdutos)
        DAProdutos.Update(Ds, "Produtos")

        Ds.Dispose()
        CNN.Close()
    End Sub


    Private Sub btFindClintes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindClintes.Click
        My.Forms.ProcuraProduto.ShowDialog()
        LocalizaDadosProduto()
        Me.Produto.Focus()
    End Sub
End Class