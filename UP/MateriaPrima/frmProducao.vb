Public Class frmProducao
    'Classe da ordem de produçao
    Dim ORDEM As New clsProducao
    'Classe do Pedido
    Dim PED As New clsPedidoMP
    'Classe da Matéria Prima
    Dim MP As ClassMP '
    Dim vValorUnitario As Double = 0
    Dim VTotal As Double = 0
    Dim iItem As Integer = 0 'selecionar o item do produto
    Public vOrdem As String
    Public vPedido As String



    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Dispose()
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click, btnImprimir.Click
        My.Forms.frmBuscarOrdem.ShowDialog()
        If Not String.IsNullOrEmpty(vOrdem) Then
            PED.MostrarPedido(vPedido, "P")
            Me.CodigoCliente.Text = PED.CodigoCliente
            Me.NomeCliente.Text = PED.nomeCliente
            Me.CodigoVendedor.Text = PED.CodigoFuncionario
            Me.NomeVendedor.Text = PED.NomeVendedor
            Me.DataPedido.Text = PED.DataPedido
            Me.DataPrazo.Text = PED.DataPrazoEntrega
            Me.Contato.Text = PED.Contato
            ORDEM.Buscar(vOrdem)
            Me.DataProducao.Text = ORDEM.Dataordem
            Me.NumeroOrdem.Text = vOrdem
            Me.NumeroPedido.Text = vPedido
            MP = New ClassMP
            Dim ds As New DataSet
            MP.AtGrade(ds, vPedido)
            Me.dgvMP.DataSource = ds.Tables(0).DefaultView
            Me.Panel1.Enabled = True
        End If

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Retorno = Nothing
        'Chama o form para criar o ordem

        Me.CodigoCliente.Clear()
        Me.NomeCliente.Clear()
        Me.CodigoVendedor.Clear()
        Me.NomeVendedor.Clear()
        Me.Contato.Clear()
        Me.DataPedido.Clear()
        Me.DataPrazo.Clear()
        Me.DataProducao.Clear()
        Me.NumeroPedido.Clear()
        Me.NumeroOrdem.Clear()
        Dim ds As New DataSet
        MP = New ClassMP
        MP.AtGrade(ds, 0)
        Me.dgvMP.DataSource = ds.Tables(0).DefaultView
        Me.Panel1.Enabled = False
        My.Forms.frmProducaoAdd1.ShowDialog()
        'Se todos os passos forem correntos vai retornar o numero da ordem criada na vareavel Retorno
        If Not String.IsNullOrEmpty(Retorno) Then
            ORDEM.Buscar(Retorno)
            Me.NumeroOrdem.Text = ORDEM.NumeroOrdem
            Me.NumeroPedido.Text = ORDEM.Numeropedido
            Me.DataProducao.Text = ORDEM.Dataordem
            PED.MostrarPedido(ORDEM.Numeropedido, "p")
            Me.CodigoCliente.Text = PED.CodigoCliente
            Me.NomeCliente.Text = PED.nomeCliente
            Me.CodigoVendedor.Text = PED.CodigoFuncionario
            Me.NomeVendedor.Text = PED.NomeVendedor
            Me.DataPrazo.Text = Me.PED.DataPrazoEntrega
            Me.DataPedido.Text = PED.DataPedido
            Me.Contato.Text = PED.Contato
            Me.Panel1.Enabled = True
            Me.txtCodigoProduto.Focus()

        End If

    End Sub

    Private Sub btnAddMP_Click(sender As Object, e As EventArgs) Handles btnAddMP.Click
        If (String.IsNullOrEmpty(Retorno)) Then
            Exit Sub
        End If

        If (String.IsNullOrEmpty(Me.txtQuantidade.Text) Or String.IsNullOrEmpty(Me.txtCodigoProduto.Text)) Then
            MessageBox.Show("Codigo do Produto ou quantidade não podem ser nulos.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtCodigoProduto.Focus()
            Exit Sub
        End If

        MP = New ClassMP
        MP.numeropedido = Me.NumeroPedido.Text
        MP.codigomateriaprima = Me.txtCodigoProduto.Text
        MP.qtd = Me.txtQuantidade.Text
        MP.valorunitario = vValorUnitario
        MP.valortotal = (vValorUnitario * MP.qtd)

        MP.Gravar()

        Dim ds As New DataSet
        MP.AtGrade(ds, NumeroPedido.Text)
        dgvMP.DataSource = ds.Tables("Table").DefaultView
        MP = Nothing
        Me.txtCodigoProduto.Clear()
        Me.txtDescricao.Clear()
        Me.txtQuantidade.Clear()
        Me.txtCodigoProduto.Focus()
    End Sub

    Private Sub txtCodigoProduto_Leave(sender As Object, e As EventArgs) Handles txtCodigoProduto.Leave
        MP = New ClassMP
        'se o codigo do produto não for nulo
        If Not String.IsNullOrEmpty(Me.txtCodigoProduto.Text) Then
            'usa a classe mp para buscar o produto
            MP.Buscar(txtCodigoProduto.Text)
            'se a classe nao retornar erro ok produto existe
            If Not (MP.ErroRetorno) Then
                Me.txtDescricao.Text = MP.Descricao
                vValorUnitario = MP.valorunitario

                'Senão da a mensagem para o usuario

            Else
                MessageBox.Show("Produto não cadastrado", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.txtCodigoProduto.Clear()
                Me.txtDescricao.Clear()
                Me.txtQuantidade.Clear()
            End If
            MP = Nothing
        End If
    End Sub

    Private Sub txtCodigoProduto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoProduto.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(OnlyNumber(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmProducao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Retorno = Nothing
    End Sub

    Private Sub dgvMP_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMP.CellClick
        Try
            iItem = Me.dgvMP.CurrentRow.Cells("gId").Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvMP_SelectionChanged(sender As Object, e As EventArgs) Handles dgvMP.SelectionChanged
        Try
            iItem = dgvMP.CurrentRow.Cells("gId").Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        MP = New ClassMP
        MP.delType = ClassMP.eDel.One
        MP.Excluir(iItem)
        Dim ds As New DataSet
        MP.AtGrade(ds, Me.NumeroPedido.Text)
        dgvMP.DataSource = ds.Tables(0).DefaultView
    End Sub
End Class