Public Class ProdutoGradeEstoqueAjuste

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
            Grade()
        End If
    End Sub

    Private Sub Grade()
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        Dim Sql As String = "Select * from ProdutoGrade  Where Produto = " & Me.Produto.Text
        
        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Lista.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        Cnn.Close()
    End Sub
    

    'Private Sub btAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAtualizar.Click

    

    '    Dim Ação As New TrfGerais
    '    If MsgBox("Deseja realmente atualizar o estoque para as informações digitadas.", 36, "Validação de Dados") = 6 Then

    '        Me.Cursor = Cursors.WaitCursor
    '        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
    '        CNN.Open()

    '        Dim Sql As String

    '        Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
    '        Dim cmd As OleDb.OleDbCommand = CNN.CreateCommand
    '        cmd.Transaction = Transacao

    '        Try


    '            Sql = "INSERT INTO EstoqueUP ( CodigoProduto, Qtd, QtdF, Tipo, IdLancamento, DataLancamento, PedidoOrdem, Prg, NFDoc, ClienteFornecedor ) Values (" & Me.Produto.Text & ", '" & Me.EstGeralDif.Text & "', '" & Me.EstNFDif.Text & "', 'A', 0, #" & Format(CDate(DataDia), "MM/dd/yyyy") & "#, 0, 'AJUSTE', 0 , 'AJUSTE DE ESTOQUE')"
    '            cmd.CommandText = Sql
    '            cmd.ExecuteNonQuery()

    '            Transacao.Commit()
    '            CNN.Close()
    '            AtProduto()

    '            MsgBox("Atualização Confirmado com Sucesso.", 64, "Validação de Dados")
    '            GerarLog(Me.Text, AçãoTP.Confirmou, Me.Produto.Text)
    '            Ação.LimpaTextBox(Me)
    '            Me.Produto.Focus()

    '            Me.Cursor = Cursors.Default

    '        Catch ex As Exception
    '            Transacao.Rollback()
    '            CNN.Close()
    '            MsgBox(ex.Message, 64, "Validação de Dados")
    '            MsgBox("Erro ao confirmar a Atualização, tente confirmar novamente ou consulte o administrador.", 64, "Validação de Dados")
    '            Exit Sub
    '        End Try

    '    Else
    '        MessageBox.Show("Operação cancelada pelo usuário", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Ação.LimpaTextBox(Me)
    '        Me.Produto.Focus()
    '        Exit Sub
    '    End If

    'End Sub


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
        Grade()
        Me.Produto.Focus()
    End Sub

   
    Private Sub Lista_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles Lista.CellFormatting

        If Me.Lista.Columns(e.ColumnIndex).Name = "cEstAtual" Then
            If e.Value IsNot Nothing Then

                Dim Valor As Double = CType(e.Value, Double)
                e.Value = FormatNumber(Valor, 2)

            End If


            Dim v As Decimal

            For Each col As DataGridViewRow In Lista.Rows
                v += col.Cells("cEstAtual").Value
            Next

            Me.EstoqueNew.Text = FormatNumber(v, 2)

        End If

    End Sub

    Private Sub btAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAtualizar.Click

        If Me.Produto.Text = "" Then
            MessageBox.Show("O usuário deve informar antes o produto para atualizar", "Validação de Dados", MessageBoxButtons.OK)
            Exit Sub
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        If MessageBox.Show("Deseja Fazer a Atualização de Estoque.", "Validação de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

            Try

                
                Dim ds As New DataSet
                Dim Sql As String = String.Empty

                Sql = "SELECT EstoqueUP.CodigoProduto, EstoqueUP.Numero, Sum(EstoqueUP.Qtd) AS SomaDeQtd FROM(EstoqueUP) GROUP BY EstoqueUP.CodigoProduto, EstoqueUP.Numero HAVING (((EstoqueUP.CodigoProduto)=" & Me.Produto.Text & "));"
                Dim daEstAgrupado As New OleDb.OleDbDataAdapter(Sql, CNN)
                daEstAgrupado.Fill(ds, "EstoqueAgrupado")




                For Each row As DataGridViewRow In Me.Lista.Rows
                    If Not row.IsNewRow Then
                        'teste = Grid.Columns(0).HeaderText
                        Dim Linha() As DataRow
                        Linha = ds.Tables("EstoqueAgrupado").Select("CodigoProduto = " & row.Cells("cProduto").Value & " and Numero = '" & row.Cells("cNumero").Value & "'")

                        Dim Diferenca As Double
                        If Linha.Length > 0 Then
                            Diferenca = NzZero(row.Cells("cEstAtual").Value) - NzZero(Linha(0)("SomaDeQtd"))
                        Else
                            Diferenca = NzZero(row.Cells("cEstAtual").Value) - 0
                        End If


                        If Diferenca <> 0 Then

                            Dim cmd As New OleDb.OleDbCommand

                            cmd.Connection = CNN
                            Sql = "INSERT INTO EstoqueUP (CodigoProduto, Qtd, QtdF, Tipo, IdLancamento, DataLancamento, PedidoOrdem, Prg, NFDoc, ClienteFornecedor, Numero ) Values (" & Me.Produto.Text & ", '" & Diferenca & "', '" & 0 & "', 'A', 0, #" & Format(CDate(DataDia), "MM/dd/yyyy") & "#, 0, 'AJUSTE', 0 , 'AJUSTE DE ESTOQUE', " & row.Cells("cNumero").Value & ")"
                            cmd.CommandText = Sql
                            cmd.ExecuteNonQuery()

                            Sql = "Update ProdutoGrade Set QtdEst = " & NzZero(row.Cells("cEstAtual").Value) & " Where Produto = " & row.Cells("cProduto").Value & " And Numero = '" & row.Cells("cNumero").Value & "'"
                            cmd.CommandText = Sql
                            cmd.ExecuteNonQuery()

                        End If

                    End If
                Next

                Dim cmd1 As New OleDb.OleDbCommand

                cmd1.Connection = CNN
                Sql = "Update Produtos Set QuantidadeEstoque = '" & NzZero(Me.EstoqueNew.Text) & "' Where CodigoProduto = " & Me.Produto.Text
                cmd1.CommandText = Sql
                cmd1.ExecuteNonQuery()

                CNN.Close()
                Me.Produto.Clear()
                Me.ProdutoDesc.Clear()
                Me.EstoqueNew.Clear()

                Dim I As Integer
                For I = 0 To Me.Lista.Rows.Count - 1
                    Me.Lista.Rows.RemoveAt(0)
                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        Else
            CNN.Close()
        End If




    End Sub

End Class