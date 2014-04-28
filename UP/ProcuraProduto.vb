Public Class ProcuraProduto

    Dim opt As Integer

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub MarcarLinha()
        For i As Integer = 0 To DgvItem.Rows.Count - 1

            Dim SS As String
            SS = NzZero(DgvItem.Rows(i).Cells("estoque").Value.ToString)
            If Int(SS) <= 0 Then
                Me.DgvItem.Rows(i).Cells("estoque").Style.ForeColor = Color.Red
                'DgvItem.Rows(i).Cells("img").Value = DgvItem.Rows(i).Cells("imgVermelho").Value
                'DgvItem.Rows(i).Cells("img").Value = DgvItem.Rows(i).Cells("imgAzul").Value
                'Me.DgvItem.CurrentRow.Cells("Sel").Value = True
            End If
        Next
    End Sub

    Private Sub ProcuraProduto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtProcura.Focus()
    End Sub

    Private Sub txtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProcura.Leave

        If Me.A3.Checked = True Then
            Me.DgvItem.Focus()
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = ""
        If Me.A1.Checked = True Then
            Sql = "SELECT Produtos.CodigoProduto, Produtos.CodigoOriginal, Produtos.CodigoFabrica, Produtos.Descrição, Produtos.UnidadeMedida, IIf([Tipo]=1,'PRODUTO',IIf([Tipo]=2,'MATERIA PRIMA',IIf([Tipo]=3,'ALMOXARIFADO',IIf([Tipo]=4,'IMOBILIZADO',IIf([Tipo]=5,'PROD. INDUST'))))) AS TP, ProdutoLocal.SetorLocalDesc, Produtos.QuantidadeEstoque, Produtos.EstDeposito, Produtos.ValorVenda, Marcas.Marca, Produtos.Referencia, Produtos.CodigoBarra, Produtos.ValorVendaAtacado FROM (Produtos LEFT JOIN ProdutoLocal ON Produtos.Localização = ProdutoLocal.SetorLocal) LEFT JOIN Marcas ON Produtos.Marca = Marcas.Codigo WHERE (((Produtos.CodigoProduto)=" & Me.txtProcura.Text & ") AND ((Produtos.Tipo)<>99) AND ((Produtos.Empresa)=" & CodEmpresa & ") AND ((Produtos.Inativo)=False));"
        End If
        If Me.A2.Checked = True Then
            Sql = "SELECT Produtos.CodigoProduto, Produtos.CodigoOriginal, Produtos.CodigoFabrica, Produtos.Descrição, Produtos.UnidadeMedida, IIf([Tipo]=1,'PRODUTO',IIf([Tipo]=2,'MATERIA PRIMA',IIf([Tipo]=3,'ALMOXARIFADO',IIf([Tipo]=4,'IMOBILIZADO',IIf([Tipo]=5,'PROD. INDUST'))))) AS TP, ProdutoLocal.SetorLocalDesc, Produtos.QuantidadeEstoque, Produtos.EstDeposito, Produtos.ValorVenda, Marcas.Marca, Produtos.Referencia, Produtos.CodigoBarra, Produtos.ValorVendaAtacado FROM (Produtos LEFT JOIN ProdutoLocal ON Produtos.Localização = ProdutoLocal.SetorLocal) LEFT JOIN Marcas ON Produtos.Marca = Marcas.Codigo WHERE (((Produtos.Descrição) Like '%" & Me.txtProcura.Text & "%') AND ((Produtos.Tipo)<>99) AND ((Produtos.Empresa)=" & CodEmpresa & ") AND ((Produtos.Inativo)=False));"
        End If
        If Me.A4.Checked = True Then
            Sql = "SELECT Produtos.CodigoProduto, Produtos.CodigoOriginal, Produtos.CodigoFabrica, Produtos.Descrição, Produtos.UnidadeMedida, IIf([Tipo]=1,'PRODUTO',IIf([Tipo]=2,'MATERIA PRIMA',IIf([Tipo]=3,'ALMOXARIFADO',IIf([Tipo]=4,'IMOBILIZADO',IIf([Tipo]=5,'PROD. INDUST'))))) AS TP, ProdutoLocal.SetorLocalDesc, Produtos.QuantidadeEstoque, Produtos.EstDeposito, Produtos.ValorVenda, Marcas.Marca, Produtos.Referencia, Produtos.CodigoBarra, Produtos.ValorVendaAtacado FROM (Produtos LEFT JOIN ProdutoLocal ON Produtos.Localização = ProdutoLocal.SetorLocal) LEFT JOIN Marcas ON Produtos.Marca = Marcas.Codigo WHERE (((Produtos.CodigoOriginal) Like '%" & Me.txtProcura.Text & "%') AND ((Produtos.Tipo)<>99) AND ((Produtos.Empresa)=" & CodEmpresa & ") AND ((Produtos.Inativo)=False));"
        End If

        If Me.A5.Checked = True Then
            Sql = "SELECT Produtos.CodigoProduto, Produtos.CodigoOriginal, Produtos.CodigoFabrica, Produtos.Descrição, Produtos.UnidadeMedida, IIf([Tipo]=1,'PRODUTO',IIf([Tipo]=2,'MATERIA PRIMA',IIf([Tipo]=3,'ALMOXARIFADO',IIf([Tipo]=4,'IMOBILIZADO',IIf([Tipo]=5,'PROD. INDUST'))))) AS TP, ProdutoLocal.SetorLocalDesc, Produtos.QuantidadeEstoque, Produtos.EstDeposito, Produtos.ValorVenda, Marcas.Marca, Produtos.Referencia, Produtos.CodigoBarra, Produtos.ValorVendaAtacado FROM (Produtos LEFT JOIN ProdutoLocal ON Produtos.Localização = ProdutoLocal.SetorLocal) LEFT JOIN Marcas ON Produtos.Marca = Marcas.Codigo WHERE (((Produtos.CodigoFabrica)='" & Me.txtProcura.Text & "') AND ((Produtos.Tipo)<>99) AND ((Produtos.Empresa)=" & CodEmpresa & ") AND ((Produtos.Inativo)=False));"
        End If

        If Me.A6.Checked = True Then
            Sql = "SELECT Produtos.CodigoProduto, Produtos.CodigoOriginal, Produtos.CodigoFabrica, Produtos.Descrição, Produtos.UnidadeMedida, IIf([Tipo]=1,'PRODUTO',IIf([Tipo]=2,'MATERIA PRIMA',IIf([Tipo]=3,'ALMOXARIFADO',IIf([Tipo]=4,'IMOBILIZADO',IIf([Tipo]=5,'PROD. INDUST'))))) AS TP, ProdutoLocal.SetorLocalDesc, Produtos.QuantidadeEstoque, Produtos.EstDeposito, Produtos.ValorVenda, Marcas.Marca, Produtos.Referencia, Produtos.CodigoBarra, Produtos.ValorVendaAtacado FROM (Produtos LEFT JOIN ProdutoLocal ON Produtos.Localização = ProdutoLocal.SetorLocal) LEFT JOIN Marcas ON Produtos.Marca = Marcas.Codigo WHERE (((Marcas.Marca) Like '%" & Me.txtProcura.Text & "%') AND ((Produtos.Tipo)<>99) AND ((Produtos.Empresa)=" & CodEmpresa & ") AND ((Produtos.Inativo)=False));"
        End If


        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet
        Da.Fill(ds, "Table")

        Me.DgvItem.DataSource = ds.Tables("Table").DefaultView
        MarcarLinha()

        Da.Dispose()
        CNN.Close()

        If Me.DgvItem.RowCount > 0 Then
            Me.DgvItem.Focus()
        Else
            Me.txtProcura.Focus()
        End If
    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A4.CheckedChanged, A5.CheckedChanged

        If Me.A1.Checked = True Then
            Me.txtProcura.Clear()
            Me.txtProcura.Focus()
        End If
        If Me.A2.Checked = True Then
            Me.txtProcura.Clear()
            Me.txtProcura.Focus()
        End If

        If Me.A4.Checked = True Then
            Me.txtProcura.Clear()
            Me.txtProcura.Focus()
        End If

        If Me.A5.Checked = True Then
            Me.txtProcura.Clear()
            Me.txtProcura.Focus()
        End If

        If Me.A6.Checked = True Then
            Me.txtProcura.Clear()
            Me.txtProcura.Focus()
        End If

    End Sub

    Private Sub MostraTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A3.CheckedChanged
        If Me.A3.Checked = True Then
            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()


            Dim Sql As String = "SELECT Produtos.CodigoProduto, Produtos.CodigoOriginal, Produtos.CodigoFabrica, Produtos.Descrição, Produtos.UnidadeMedida, IIf([Tipo]=1,'PRODUTO',IIf([Tipo]=2,'MATERIA PRIMA',IIf([Tipo]=3,'ALMOXARIFADO',IIf([Tipo]=4,'IMOBILIZADO',IIf([Tipo]=5,'PROD. INDUST'))))) AS TP, ProdutoLocal.SetorLocalDesc, Produtos.QuantidadeEstoque, Produtos.EstDeposito, Produtos.ValorVenda, Marcas.Marca, Produtos.Referencia, Produtos.CodigoBarra, Produtos.ValorVendaAtacado FROM (Produtos LEFT JOIN ProdutoLocal ON Produtos.Localização = ProdutoLocal.SetorLocal) LEFT JOIN Marcas ON Produtos.Marca = Marcas.Codigo WHERE (((Produtos.Tipo)<>99) AND ((Produtos.Empresa)=" & CodEmpresa & ") AND ((Produtos.Inativo)=False));"
            Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
            Dim Da As New OleDb.OleDbDataAdapter(CMD)

            Dim ds As New DataSet
            Da.Fill(ds, "Table")

            Me.DgvItem.DataSource = ds.Tables("Table").DefaultView
            MarcarLinha()

            Da.Dispose()
            CNN.Close()
        End If
    End Sub

    Private Sub DgvItem_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellDoubleClick
        'Vai para o pedido de venda OS
        If PedidoAddItemOS.Visible Then
            My.Forms.PedidoAddItemOS.CodigoProduto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
            Me.Close()
            Me.Dispose()
        End If

        'Vai para o Pedido de Venda
        If PedidoAddItem.Visible Then
            PedidoAddItem.CodigoProduto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
            Me.Close()
            Me.Dispose()
        End If
        'vai para tela de orcamentoitens
        If OrçamentoItens.Visible Then
            OrçamentoItens.CodigoProduto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
            Me.Close()
            Me.Dispose()
        End If

        'Vai para tela de OSorcamentoitens
        If OSorçamentoItens.Visible Then
            OSorçamentoItens.CodigoProduto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
            Me.Close()
            Me.Dispose()
        End If

        'Vai para a tela de Cadastro de Produtos
        If My.Forms.Produtos.Visible = True Then
            My.Forms.Produtos.CodigoProduto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
            My.Forms.Produtos.LocalizaDados()
            Me.Close()
            Me.Dispose()
        End If


        If My.Forms.ProdutoEstoqueConsulta.Visible = True Then
            My.Forms.ProdutoEstoqueConsulta.Produto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
            Me.Close()
            Me.Dispose()
        End If

        If My.Forms.ProducaoAddItem.Visible = True Then
            My.Forms.ProducaoAddItem.Produto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
            Me.Close()
            Me.Dispose()
        End If

        If My.Forms.ProdutoEstoqueAtualizar.Visible = True Then
            My.Forms.ProdutoEstoqueAtualizar.Produto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
            Me.Close()
            Me.Dispose()
        End If

        If My.Forms.ProdutoSaldoEstoque.Visible = True Then
            My.Forms.ProdutoSaldoEstoque.Produto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
            Me.Close()
            Me.Dispose()
        End If

        If My.Forms.ComprasAddItem.Visible = True Then
            My.Forms.ComprasAddItem.CodigoProduto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
            Me.Close()
            Me.Dispose()
        End If

        If My.Forms.ProdutoEtiquetas.Visible = True Then
            My.Forms.ProdutoEtiquetas.Produto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
            Me.Close()
            Me.Dispose()
        End If

        If My.Forms.ComprasRelat.Visible = True Then
            My.Forms.ComprasRelat.Produto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
            Me.Close()
            Me.Dispose()
            Return
        End If

        If My.Forms.NfiscalLancaItens.Visible = True Then
            My.Forms.NfiscalLancaItens.Produto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
            Me.Close()
            Me.Dispose()
            Return
        End If

        If My.Forms.ProdutoRelat.Visible = True Then
            My.Forms.ProdutoRelat.Produto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
            Me.Close()
            Me.Dispose()
            Return
        End If

        If My.Forms.ProdutoEstoqueAjuste.Visible = True Then
            My.Forms.ProdutoEstoqueAjuste.Produto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
            Me.Close()
            Me.Dispose()
            Return
        End If

        If My.Forms.EstoqueTransferencia.Visible = True Then
            My.Forms.EstoqueTransferencia.CodigoProduto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
            Me.Close()
            Me.Dispose()
            Return
        End If

        If My.Forms.SellShoes.Visible = True Then
            If UsarGrade = False Then
                My.Forms.SellShoes.CodBarra.Text = Me.DgvItem.CurrentRow.Cells("CodBarra").Value
            End If
            Me.Close()
            Me.Dispose()
            Return
        End If

        If My.Forms.SellShoesOrcamento.Visible = True Then
            If UsarGrade = False Then
                My.Forms.SellShoesOrcamento.CodBarra.Text = Me.DgvItem.CurrentRow.Cells("CodBarra").Value
            End If
            Me.Close()
            Me.Dispose()
            Return
        End If

        If My.Forms.LocacaoCilindro.Visible = True Then
            My.Forms.LocacaoCilindro.txtCodigoProduto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
            Me.Close()
            Me.Dispose()
            Return
        End If

        If My.Forms.ProdutoGradeEstoqueAjuste.Visible = True Then
            My.Forms.ProdutoGradeEstoqueAjuste.Produto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
            Me.Close()
            Me.Dispose()
            Return
        End If

    End Sub

    Private Sub ProcuraProduto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F3
                Me.A1.Checked = True
                Me.txtProcura.Focus()
            Case Keys.F4
                Me.A2.Checked = True
                Me.txtProcura.Focus()
            Case Keys.F5
                Me.A4.Checked = True
                Me.txtProcura.Focus()
            Case Keys.F6
                Me.A5.Checked = True
                Me.txtProcura.Focus()
            Case Keys.F7
                Me.A6.Checked = True
                Me.txtProcura.Focus()
            Case Keys.F8
                Me.A3.Checked = True
                Me.DgvItem.Focus()
        End Select
    End Sub

    Private Sub DgvItem_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DgvItem.KeyDown
        If e.KeyCode = Keys.Enter Then

            'usado para a tela de pedido venda OS
            If PedidoAddItemOS.Visible Then
                My.Forms.PedidoAddItemOS.CodigoProduto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
                Me.Close()
                Me.Dispose()
            End If
            'usado para a tela de pedido venda
            If PedidoAddItem.Visible Then
                My.Forms.PedidoAddItem.CodigoProduto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
                Me.Close()
                Me.Dispose()
            End If

            'vai para tela de orcamentoitens
            If OrçamentoItens.Visible Then
                OrçamentoItens.CodigoProduto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
                Me.Close()
                Me.Dispose()
            End If

            'Vai para tela de OSorcamentoitens
            If OSorçamentoItens.Visible Then
                OSorçamentoItens.CodigoProduto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
                Me.Close()
                Me.Dispose()
            End If

            If My.Forms.Produtos.Visible = True Then
                My.Forms.Produtos.CodigoProduto.Text = Me.DgvItem.CurrentRow.Cells(0).Value
                My.Forms.Produtos.LocalizaDados()
                Me.Close()
                Me.Dispose()
            End If

            If My.Forms.ProdutoEstoqueConsulta.Visible = True Then
                My.Forms.ProdutoEstoqueConsulta.Produto.Text = Me.DgvItem.CurrentRow.Cells(0).Value
                Me.Close()
                Me.Dispose()
            End If

            If My.Forms.ProducaoAddItem.Visible = True Then
                My.Forms.ProducaoAddItem.Produto.Text = Me.DgvItem.CurrentRow.Cells(0).Value
                Me.Close()
                Me.Dispose()
            End If

            If My.Forms.ProdutoEstoqueAtualizar.Visible = True Then
                My.Forms.ProdutoEstoqueAtualizar.Produto.Text = Me.DgvItem.CurrentRow.Cells(0).Value
                Me.Close()
                Me.Dispose()
            End If

            If My.Forms.ProdutoSaldoEstoque.Visible = True Then
                My.Forms.ProdutoSaldoEstoque.Produto.Text = Me.DgvItem.CurrentRow.Cells(0).Value
                Me.Close()
                Me.Dispose()
            End If

            If My.Forms.ComprasAddItem.Visible = True Then
                My.Forms.ComprasAddItem.CodigoProduto.Text = Me.DgvItem.CurrentRow.Cells(0).Value
                Me.Close()
                Me.Dispose()
            End If

            If My.Forms.ProdutoEtiquetas.Visible = True Then
                My.Forms.ProdutoEtiquetas.Produto.Text = Me.DgvItem.CurrentRow.Cells(0).Value
                Me.Close()
                Me.Dispose()
            End If

            If My.Forms.ComprasRelat.Visible = True Then
                My.Forms.ComprasRelat.Produto.Text = Me.DgvItem.CurrentRow.Cells(0).Value
                Me.Close()
                Me.Dispose()
            End If

            If My.Forms.NfiscalLancaItens.Visible = True Then
                My.Forms.NfiscalLancaItens.Produto.Text = Me.DgvItem.CurrentRow.Cells(0).Value
                Me.Close()
                Me.Dispose()
            End If

            If My.Forms.ProdutoRelat.Visible = True Then
                My.Forms.ProdutoRelat.Produto.Text = Me.DgvItem.CurrentRow.Cells(0).Value
                Me.Close()
                Me.Dispose()
            End If

            If My.Forms.ProdutoEstoqueAjuste.Visible = True Then
                My.Forms.ProdutoEstoqueAjuste.Produto.Text = Me.DgvItem.CurrentRow.Cells(0).Value
                Me.Close()
                Me.Dispose()
            End If

            If My.Forms.EstoqueTransferencia.Visible = True Then
                My.Forms.EstoqueTransferencia.CodigoProduto.Text = Me.DgvItem.CurrentRow.Cells(0).Value
                Me.Close()
                Me.Dispose()
            End If

            If My.Forms.SellShoes.Visible = True Then
                If UsarGrade = False Then
                    My.Forms.SellShoes.CodBarra.Text = Me.DgvItem.CurrentRow.Cells("CodBarra").Value
                End If
                Me.Close()
                Me.Dispose()
                Return
            End If

            If My.Forms.SellShoesOrcamento.Visible = True Then
                If UsarGrade = False Then
                    My.Forms.SellShoesOrcamento.CodBarra.Text = Me.DgvItem.CurrentRow.Cells("CodBarra").Value
                End If
                Me.Close()
                Me.Dispose()
            End If

            If My.Forms.ProdutoGradeEstoqueAjuste.Visible = True Then
                My.Forms.ProdutoGradeEstoqueAjuste.Produto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
                Me.Close()
                Me.Dispose()
                Return
            End If

        End If
    End Sub

    Private Sub DgvItem_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DgvItem.SelectionChanged
        Try
            Me.lblMensagem.Text = Convert.ToString(Me.DgvItem.CurrentRow.Cells("greferencia").Value)
            Me.lbldescProd.Text = Convert.ToString(Me.DgvItem.CurrentRow.Cells("Desc").Value)
        Catch ex As Exception
            Me.lblMensagem.Text = ""
            Me.lbldescProd.Text = ""
        End Try
    End Sub
End Class