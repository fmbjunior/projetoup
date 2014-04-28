Public Class ProducaoAddItem

    Dim Ação As New TrfGerais()

    Private OperationIten As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        'Area destinada para as validacoes
        If Me.Produto.Text = "" Then
            MsgBox("O Código da produto não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Produto.Focus()
            Exit Sub
        ElseIf Me.Qtd.Text = "" Then
            MsgBox("A quantidade do produto não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Qtd.Focus()
            Exit Sub
        End If

        If NzZero(Me.Qtd.Text) = 0 Then
            MessageBox.Show("O usuário não pode adicionar um item com Quantidade ZERO.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Qtd.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        If OperationIten = INS Then

            Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
            Dim Cmd As OleDb.OleDbCommand = CNN.CreateCommand
            Dim CmdProducao As OleDb.OleDbCommand = CNN.CreateCommand

            Cmd.Transaction = Transacao
            CmdProducao.Transaction = Transacao

            Try
                Dim Ult As Integer = UltimoReg()

                Dim Sql As String = "INSERT INTO ProducaoItem (Id, OrdemProducao, Produto, Qtd, ValorUnitarioComissao, ValorTotalComissao) VALUES (@1, @2, @3, @4, @5, @6)"
                Cmd.CommandText = Sql

                Cmd.Parameters.Add(New OleDb.OleDbParameter("@1", NzZero(Ult)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", NzZero(My.Forms.Producao.OrdemProducao.Text)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", NzZero(Me.Produto.Text)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", NzZero(Me.Qtd.Text)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", NzZero(Me.ValorUnitarioComissao.Text)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", NzZero((NzZero(Me.ValorUnitarioComissao.Text) * NzZero(Me.Qtd.Text)))))

                Cmd.ExecuteNonQuery()

                Sql = "INSERT INTO ProducaoItemSub (IdItem, OrdemProducao, Produto, Qtd, Unitario, Total ) SELECT " & Ult & " AS IdItem, " & NzZero(My.Forms.Producao.OrdemProducao.Text) & " AS Ordem, ProdutoComposicao.ProdComposicao, [QtdUsar]* " & NzZero(CInt(Me.Qtd.Text)) & " AS QtdIndicada, Produtos.ValorCompra, [ValorCompra]*([QtdUsar]* " & NzZero(CInt(Me.Qtd.Text)) & ") AS Total FROM ProdutoComposicao INNER JOIN Produtos ON ProdutoComposicao.ProdComposicao = Produtos.CodigoProduto WHERE (((ProdutoComposicao.Produto)=" & Me.Produto.Text & "));"
                CmdProducao.CommandText = Sql
                CmdProducao.ExecuteNonQuery()

                Transacao.Commit()

                CNN.Close()
                My.Forms.Producao.EncheLista()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                NovoItem()
            Catch ex As Exception
                Transacao.Rollback()
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
        End If

    End Sub

    Private Function UltimoReg()
        'Inserir ultimo registro
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "Select max(Id) from ProducaoItem"
        Dim Cmd As New OleDb.OleDbCommand(Sql, Cnn)

        Dim DR As OleDb.OleDbDataReader
        Dim Ult As Integer

        Try
            DR = Cmd.ExecuteReader
            DR.Read()

            If DR.HasRows = True Then
                Ult = NzZero(DR.Item(0))
            Else
                Ult = 1
            End If

            DR.Close()
            Cnn.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Return 1
                Exit Function
            End If
        End Try

        Return Ult + 1

    End Function

    Private Sub NovoItem()
        Ação.LimpaTextBox(Me)
        Me.Produto.Focus()
        OperationIten = INS
    End Sub

    Public Sub LocalizaProduto()
        If Me.Produto.Text = "" Then
            Exit Sub
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Produtos where CodigoProduto = " & Me.Produto.Text & " And Produtos.Tipo = 5 And Inativo = False and Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows = True Then
            If DR.Item("Tipo") <> "5" Then
                MessageBox.Show("Este tipo de Produto não pode ser usado para produção", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Produto.Clear()
                Me.Produto.Focus()
                Exit Sub
            End If
            Me.ProdutoDesc.Text = DR.Item("Descrição") & ""
            Me.ValorUnitarioComissao.Text = NzZero(DR.Item("ValorPagoProducao"))
        Else
            MsgBox("Item não encontrado, verifique....", 64, "Validação de Dados")
            Me.Produto.Focus()
            CNN.Close()
            Exit Sub
        End If
        DR.Close()
        CNN.Close()


    End Sub

    Private Sub Produto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Produto.Leave
        If String.CompareOrdinal(Me.Produto.Text, Me.Produto.TextoAntigo) Then
            LocalizaProduto()
        End If
    End Sub

    Private Sub ProducaoAddItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim PosX As Double = My.Forms.Producao.Location.X
        Dim PosY As Double = (My.Forms.Producao.Location.Y + 160) - Me.Height

        Me.Location = New Point(PosX, PosY)

    End Sub

    Private Sub btProdutoFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btProdutoFind.Click
        My.Forms.ProcuraProdutoIndustria.ShowDialog()
        Me.Produto.Focus()
    End Sub

    Private Sub Produto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Produto.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ProcuraProdutoIndustria.ShowDialog()
            Me.Produto.Focus()
        End If
    End Sub





End Class