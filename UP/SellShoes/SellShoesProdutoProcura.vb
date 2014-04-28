Public Class SellShoesProdutoProcura

    Dim opt As Integer

    Dim DsGrade As DataSet
    Dim bs As BindingSource



    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub MarcarLinha()
        For i As Integer = 0 To Lista.Rows.Count - 1

            Dim SS As String
            SS = NzZero(Lista.Rows(i).Cells("estoque").Value.ToString)
            If Int(SS) <= 0 Then
                Me.Lista.Rows(i).Cells("estoque").Style.ForeColor = Color.Red
            End If
        Next
    End Sub

    Private Sub SellShoesProdutoProcura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim trd As Threading.Thread

        'trd = New Threading.Thread(AddressOf CarregaNumeracao)
        'trd.IsBackground = True
        'trd.Start()

        CarregaNumeracao()

        Me.txtProcura.Focus()

    End Sub

    Private Sub txtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProcura.Leave

        If Me.A3.Checked = True Then
            Me.Lista.Focus()
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim Sql As String = ""
        If Me.A1.Checked = True Then
            Sql = "SELECT Produtos.CodigoProduto, Produtos.CodigoOriginal, Produtos.CodigoFabrica, Produtos.Descrição, Produtos.UnidadeMedida, IIf([Tipo]=1,'PRODUTO',IIf([Tipo]=2,'MATERIA PRIMA',IIf([Tipo]=3,'ALMOXARIFADO',IIf([Tipo]=4,'IMOBILIZADO',IIf([Tipo]=5,'PROD. INDUST'))))) AS TP, ProdutoLocal.SetorLocalDesc, Produtos.QuantidadeEstoque, Produtos.ValorVenda, Cor.CorDesc FROM (Produtos LEFT JOIN ProdutoLocal ON Produtos.Localização = ProdutoLocal.SetorLocal) LEFT JOIN Cor ON Produtos.Cor = Cor.Codigo WHERE (((Produtos.CodigoProduto) =" & Me.txtProcura.Text & ") AND ((Produtos.Tipo)<>99) AND ((Produtos.Empresa)=" & CodEmpresa & ")) and Produtos.Inativo = false"
            Me.Lista.Focus()
        End If
        If Me.A2.Checked = True Then
            Sql = "SELECT Produtos.CodigoProduto, Produtos.CodigoOriginal, Produtos.CodigoFabrica, Produtos.Descrição, Produtos.UnidadeMedida, IIf([Tipo]=1,'PRODUTO',IIf([Tipo]=2,'MATERIA PRIMA',IIf([Tipo]=3,'ALMOXARIFADO',IIf([Tipo]=4,'IMOBILIZADO',IIf([Tipo]=5,'PROD. INDUST'))))) AS TP, ProdutoLocal.SetorLocalDesc, Produtos.QuantidadeEstoque, Produtos.ValorVenda, Cor.CorDesc FROM (Produtos LEFT JOIN ProdutoLocal ON Produtos.Localização = ProdutoLocal.SetorLocal) LEFT JOIN Cor ON Produtos.Cor = Cor.Codigo WHERE (((Produtos.Descrição) Like '%" & Me.txtProcura.Text & "%') AND ((Produtos.Tipo)<>99) AND ((Produtos.Empresa)=" & CodEmpresa & ")) and Produtos.Inativo = false"
            Me.Lista.Focus()
        End If

        If Me.A4.Checked = True Then
            Sql = "SELECT Produtos.CodigoProduto, Produtos.CodigoOriginal, Produtos.CodigoFabrica, Produtos.Descrição, Produtos.UnidadeMedida, IIf([Tipo]=1,'PRODUTO',IIf([Tipo]=2,'MATERIA PRIMA',IIf([Tipo]=3,'ALMOXARIFADO',IIf([Tipo]=4,'IMOBILIZADO',IIf([Tipo]=5,'PROD. INDUST'))))) AS TP, ProdutoLocal.SetorLocalDesc, Produtos.QuantidadeEstoque, Produtos.ValorVenda, Cor.CorDesc FROM (Produtos LEFT JOIN ProdutoLocal ON Produtos.Localização = ProdutoLocal.SetorLocal) LEFT JOIN Cor ON Produtos.Cor = Cor.Codigo WHERE (((Produtos.CodigoOriginal) Like '%" & Me.txtProcura.Text & "%') AND ((Produtos.Tipo)<>99) AND ((Produtos.Empresa)=" & CodEmpresa & ")) and Produtos.Inativo = false"
            Me.Lista.Focus()
        End If

        If Me.A5.Checked = True Then
            Sql = "SELECT Produtos.CodigoProduto, Produtos.CodigoOriginal, Produtos.CodigoFabrica, Produtos.Descrição, Produtos.UnidadeMedida, IIf([Tipo]=1,'PRODUTO',IIf([Tipo]=2,'MATERIA PRIMA',IIf([Tipo]=3,'ALMOXARIFADO',IIf([Tipo]=4,'IMOBILIZADO',IIf([Tipo]=5,'PROD. INDUST'))))) AS TP, ProdutoLocal.SetorLocalDesc, Produtos.QuantidadeEstoque, Produtos.ValorVenda, Cor.CorDesc FROM (Produtos LEFT JOIN ProdutoLocal ON Produtos.Localização = ProdutoLocal.SetorLocal) LEFT JOIN Cor ON Produtos.Cor = Cor.Codigo WHERE (((Produtos.CodigoFabrica) Like '%" & Me.txtProcura.Text & "%') AND ((Produtos.Tipo)<>99) AND ((Produtos.Empresa)=" & CodEmpresa & ")) and Produtos.Inativo = false"
            Me.Lista.Focus()
        End If



        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet
        Da.Fill(ds, "Table")

        If ds.Tables("Table").Rows.Count = 0 Then
            Da.Dispose()
            CNN.Close()
            Me.Lista.Focus()
            Exit Sub
        End If


        Me.Lista.DataSource = ds.Tables("Table").DefaultView
        MarcarLinha()

        bs = New BindingSource
        bs.DataSource = DsGrade.Tables("Grade").DefaultView

        Me.ListaGrade.DataSource = bs

        Try
            bs.Filter = "Produto = " & Me.Lista.CurrentRow.Cells("codigo").Value
        Catch ex As Exception
            MessageBox.Show("Conteudo de procura inexistente.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try


        Da.Dispose()
        CNN.Close()

        Me.Lista.Focus()

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


    End Sub

    Private Sub MostraTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A3.CheckedChanged
        If Me.A3.Checked = True Then
            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()


            Dim Sql As String = "SELECT Produtos.CodigoProduto, Produtos.CodigoOriginal, Produtos.CodigoFabrica, Produtos.Descrição, Produtos.UnidadeMedida, IIf([Tipo]=1,'PRODUTO',IIf([Tipo]=2,'MATERIA PRIMA',IIf([Tipo]=3,'ALMOXARIFADO',IIf([Tipo]=4,'IMOBILIZADO',IIf([Tipo]=5,'PROD. INDUST'))))) AS TP, ProdutoLocal.SetorLocalDesc, Produtos.QuantidadeEstoque, Produtos.ValorVenda, Cor.CorDesc  FROM (Produtos LEFT JOIN ProdutoLocal ON Produtos.Localização = ProdutoLocal.SetorLocal) LEFT JOIN Cor ON Produtos.Cor = Cor.Codigo WHERE (((Produtos.Tipo)<>99) AND ((Produtos.Empresa)=" & CodEmpresa & ")) and Produtos.Inativo = false"

            Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
            Dim Da As New OleDb.OleDbDataAdapter(CMD)

            Dim ds As New DataSet
            Da.Fill(ds, "Table")

            Me.Lista.DataSource = ds.Tables("Table").DefaultView
            MarcarLinha()

            bs = New BindingSource
            bs.DataSource = DsGrade.Tables("Grade").DefaultView

            Me.ListaGrade.DataSource = bs

            bs.Filter = "Produto = " & Me.Lista.CurrentRow.Cells(0).Value

            Da.Dispose()
            CNN.Close()

            Me.Lista.Focus()
        End If
    End Sub



    Private Sub DgvItem_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellDoubleClick

        If My.Forms.SellShoesPedidoCompraAddItem.Visible = True Then
            SellShoesPedidoCompraAddItem.CodigoProduto.Text = Me.Lista.CurrentRow.Cells(0).Value
            Me.Close()
            Me.Dispose()
        End If

        If My.Forms.Produtos.Visible = True Then
            My.Forms.Produtos.CodigoProduto.Text = Me.Lista.CurrentRow.Cells(0).Value
            My.Forms.Produtos.LocalizaDados()
            Me.Close()
            Me.Dispose()
        End If

        If My.Forms.ProdutoEstoqueConsulta.Visible = True Then
            My.Forms.ProdutoEstoqueConsulta.Produto.Text = Me.Lista.CurrentRow.Cells(0).Value
            Me.Close()
            Me.Dispose()
        End If

        If My.Forms.ProducaoAddItem.Visible = True Then
            My.Forms.ProducaoAddItem.Produto.Text = Me.Lista.CurrentRow.Cells(0).Value
            Me.Close()
            Me.Dispose()
        End If

        If My.Forms.ProdutoEstoqueAtualizar.Visible = True Then
            My.Forms.ProdutoEstoqueAtualizar.Produto.Text = Me.Lista.CurrentRow.Cells(0).Value
            Me.Close()
            Me.Dispose()
        End If

        If My.Forms.ProdutoSaldoEstoque.Visible = True Then
            My.Forms.ProdutoSaldoEstoque.Produto.Text = Me.Lista.CurrentRow.Cells(0).Value
            Me.Close()
            Me.Dispose()
        End If

        'Para o lançamento de compra dos produtos .
        If SellShoesComprasAddItem.Visible = True Then
            SellShoesComprasAddItem.CodigoProduto.Text = Me.Lista.CurrentRow.Cells(0).Value
            Me.Close()
            Me.Dispose()
        End If

        If My.Forms.ProdutoEtiquetas.Visible = True Then
            My.Forms.ProdutoEtiquetas.Produto.Text = Me.Lista.CurrentRow.Cells(0).Value
            Me.Close()
            Me.Dispose()
        End If

        If My.Forms.ComprasRelat.Visible = True Then
            My.Forms.ComprasRelat.Produto.Text = Me.Lista.CurrentRow.Cells(0).Value
            Me.Close()
            Me.Dispose()
        End If

        If My.Forms.NfiscalLancaItens.Visible = True Then
            My.Forms.NfiscalLancaItens.Produto.Text = Me.Lista.CurrentRow.Cells(0).Value
            Me.Close()
            Me.Dispose()
        End If

        If My.Forms.ProdutoRelat.Visible = True Then
            My.Forms.ProdutoRelat.Produto.Text = Me.Lista.CurrentRow.Cells(0).Value
            Me.Close()
            Me.Dispose()
        End If

        If My.Forms.ProdutoEstoqueAjuste.Visible = True Then
            My.Forms.ProdutoEstoqueAjuste.Produto.Text = Me.Lista.CurrentRow.Cells(0).Value
            Me.Close()
            Me.Dispose()
        End If

        If My.Forms.SellShoes.Visible = True Then
            My.Forms.SellShoes.CodBarra.Text = Me.Lista.CurrentRow.Cells(0).Value
            Me.Close()
            Me.Dispose()
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
                Me.A3.Checked = True
                Me.Lista.Focus()
        End Select
    End Sub


#Region "Carrega Numeracao em Tread"

    Private Sub CarregaNumeracao()

        Dim CNNNumeros As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNNNumeros.Open()


        Dim Sql As String = "SELECT ProdutoGrade.Produto, ProdutoGrade.Numero, ProdutoGrade.QtdEst, ProdutoGrade.Sequencia FROM ProdutoGrade INNER JOIN Produtos ON ProdutoGrade.Produto = Produtos.CodigoProduto WHERE (((Produtos.Inativo)=False));"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNNNumeros)
        Dim DaNumero As New OleDb.OleDbDataAdapter(CMD)

        DsGrade = New DataSet
        DaNumero.Fill(DsGrade, "Grade")


    End Sub

#End Region

    Private Sub Lista_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lista.SelectionChanged

        Try
            bs.Filter = "Produto = " & Me.Lista.CurrentRow.Cells(0).Value
        Catch ex As Exception
        End Try
        


    End Sub


    Private Sub ListaGrade_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListaGrade.CellDoubleClick


        If My.Forms.SellShoes.Visible = True Then
            My.Forms.SellShoes.CodBarra.Text = Me.Lista.CurrentRow.Cells(0).Value & "-" & Me.ListaGrade.CurrentRow.Cells(1).Value
            Me.Close()
            Me.Dispose()
        End If
    End Sub

End Class