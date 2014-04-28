Imports System.Data.OleDb

Public Class HistoricoOsPedido

    Dim Ação As New TrfGerais

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Cliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cliente.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ClientesProcura.ShowDialog()
            If Me.Cliente.Text <> "" Then
                Ação.Descrição_ItenRegistro(Me.Cliente, Me.ClienteDesc, "Clientes", "Codigo", Me.Cliente.Text, "Nome", TrfGerais.TipoDados.Numérico, True)
                'EncheListaPedido()
            End If
        End If
    End Sub

    Private Sub Cliente_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cliente.Leave
        If String.IsNullOrEmpty(Me.Cliente.Text) Then
            Me.ClienteDesc.Clear()
            Exit Sub
        End If
        Ação.Descrição_ItenRegistro(Me.Cliente, Me.ClienteDesc, "Clientes", "Codigo", Me.Cliente.Text, "Nome", TrfGerais.TipoDados.Numérico, True)
        EncheListaPedido()
    End Sub

    Private Sub btFindClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindClientes.Click
        My.Forms.ClientesProcura.ShowDialog()
        If Me.Cliente.Text <> "" Then
            Ação.Descrição_ItenRegistro(Me.Cliente, Me.ClienteDesc, "Clientes", "Codigo", Me.Cliente.Text, "Nome", TrfGerais.TipoDados.Numérico, True)
            EncheListaPedido() 'lelo
        End If
    End Sub


    Private Sub EncheListaPedido()

        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty


        Sql = "Select Pedido.PedidoSequencia, Pedido.DataPedido, Pedido.ObsCab from Pedido  Where Pedido.Empresa = " & CodEmpresa & " And Pedido.CódigoCliente = " & Me.Cliente.Text & " Order by Pedido.PedidoSequencia DESC"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.ListaPedido.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub EncheServiço(ByVal pedido As Integer)

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim sql As String

        sql = "SELECT ItemServico.Id, ItemServico.PedidoSequencia, ItemServico.CodigoServico, Servicos.Serv_Descricao, Funcionários.Nome, ItemServico.Qtd, ItemServico.ValorUnitario, ItemServico.ValorDesconto, ItemServico.TotalServico, ItemServico.ValorISSQN FROM (ItemServico INNER JOIN Servicos ON ItemServico.CodigoServico = Servicos.Serv_Codigo) INNER JOIN Funcionários ON ItemServico.Funcionario = Funcionários.CódigoFuncionário WHERE ItemServico.PedidoSequencia=" & NzZero(pedido)


        Dim CMD As New OleDb.OleDbCommand(sql, CNN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet


        Da.Fill(ds, "Table")

        Me.DgvItem.DataSource = ds.Tables("Table").DefaultView

        'Me.ValorServicos.Text = FormatCurrency(NzZero(ds.Tables("Table").Compute("SUM(totalservico)", "")), 2)
        'Me.Issqn.Text = FormatCurrency(NzZero(ds.Tables("Table").Compute("SUM(ValorISSQN)", "")), 2)
        'SomaTotalServico = Me.ValorServicos.Text

        Da.Dispose()
        CNN.Close()

        'If Me.DgvItem.Rows.Count > 0 Then
        '    Me.CódigoCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        '    Me.btClienteFind.Enabled = False
        'Else
        '    Me.CódigoCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        '    Me.btClienteFind.Enabled = True
        'End If

    End Sub

    Public Sub EncheProdutos(ByVal pedido As Integer)


        Dim CNN1 As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN1.Open()

        Dim Sql As String = "SELECT Produtos.Descrição, ItensPedido.CodigoProduto, ItensPedido.Qtd, ItensPedido.ValorUnitario, ItensPedido.ValorDesconto, ItensPedido.TotalProduto FROM ItensPedido INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto WHERE ItensPedido.PedidoSequencia = " & pedido & " Order by Produtos.Tipo"


        Dim CMD As New OleDb.OleDbCommand(Sql, CNN1)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet


        Da.Fill(ds, "Table")

        Me.ListaProduto.DataSource = ds.Tables("Table").DefaultView

        Da.Dispose()
        CNN1.Close()


    End Sub


    Private Sub ListaPedido_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaPedido.SelectionChanged
        Try
            Me.DescPedido.Text = Me.ListaPedido.CurrentRow.Cells("cObsCab").Value & ""
            EncheServiço(Me.ListaPedido.CurrentRow.Cells("cPedido").Value)
            EncheProdutos(Me.ListaPedido.CurrentRow.Cells("cPedido").Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub HistoricoOsPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class