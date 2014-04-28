Public Class ProdutoSaldoEstoque
    Public vEstoqueAterior As Double = 0
    Private Sub Produto_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Produto.Validated
        If String.CompareOrdinal(Me.Produto.Text, Me.Produto.TextoAntigo) Then
            LocalizaProduto()
        End If

    End Sub
    Public Sub LocalizaProduto()
        If Me.Produto.Text = "" Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT  Produtos.CodigoProduto, Produtos.Descrição From Produtos Where Produtos.CodigoProduto=" & Me.Produto.Text

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()


        If DR.HasRows Then
            Me.Descrição.Text = DR.Item("Descrição") & ""
            DR.Close()
        Else
            MsgBox("Não existe movimentação de estoque deste produto, Verifique.", 64, "Validação de Dados")
            DR.Close()
            Me.Produto.Clear()
            Me.Descrição.Clear()
            Me.Produto.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub btFindProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindProduto.Click
        My.Forms.ProcuraProduto.Show()
        LocalizaProduto()
    End Sub
    Private Sub PegarEstoqueAnterior(ByVal vid As Integer)

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Cmd As OleDb.OleDbCommand = Cnn.CreateCommand
        Dim DataReader As OleDb.OleDbDataReader


        Try
            Dim sql = "SELECT Sum(EstoqueUP.Qtd) AS SomaDeQtd, EstoqueUP.CodigoProduto FROM(EstoqueUP) WHERE(((EstoqueUP.DataLancamento) < #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "#)) GROUP BY EstoqueUP.CodigoProduto HAVING (((EstoqueUP.CodigoProduto)=" & vid & "));"

            With Cmd
                .Connection = Cnn
                .CommandTimeout = 0
                .CommandText = sql
                .CommandType = CommandType.Text
            End With

            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    'Achou o iten procurado o iten as caixas serão preenchida
                    vEstoqueAterior = DataReader.Item("SomaDeQtd")
                    DataReader.Close()
                    Exit Sub
                Else
                    vEstoqueAterior = 0
                End If
            End While
            vEstoqueAterior = 0
            DataReader.Close()

        Catch ex As Exception

            Cnn.Close()
            MessageBox.Show("Aconteceram erros ao atualizar o estoque do cadastro de Produto, favor fazer atualização geral do estoque", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try


    End Sub
    Private Sub Visualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Visualizar.Click
        If Me.DataFinal.Text = "" Then
            MsgBox("A data inicial não foi digitada", 48, "Validação de Dados")
            Exit Sub
        End If
        PegarEstoqueAnterior(Me.Produto.Text)
        RelatorioCarregar = "RelSaldoProduto"
        My.Forms.VisualizadorRelatorio.ShowDialog()
    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    
    Private Sub Produto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Produto.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ProcuraProduto.Show()
            LocalizaProduto()
        End If
    End Sub
End Class