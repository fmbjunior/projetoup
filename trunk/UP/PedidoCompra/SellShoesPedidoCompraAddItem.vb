Public Class SellShoesPedidoCompraAddItem

    Dim cAddItem As New clsAddItemPedidoCompra
    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1

    Private Sub codigoproduto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoProduto.KeyDown
        If e.KeyCode = Keys.F5 Then
            SellShoesProdutoProcura.ShowDialog()
            LocalizaProduto()
        End If
    End Sub

    Private Sub codigoproduto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoProduto.Leave
        LocalizaProduto()
    End Sub

    Public Sub LocalizaProduto()
        If Me.CodigoProduto.Text = "" Then
            Exit Sub
            End
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Produtos where CodigoProduto = " & Me.CodigoProduto.Text '& " and tipo = " & TipoItensProcurar
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.DescProduto.Text = DR.Item("Descrição") & ""
            If Me.ValorUnitario.Text = "" Then Me.ValorUnitario.Text = FormatCurrency(Nz(0, 3), 2)
            EncheComboNum()
        Else
            Me.CodigoProduto.Clear()
            Me.DescProduto.Clear()
        End If

        DR.Close()
        CNN.Close()

    End Sub

    Private Sub Qtd_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qtd.Enter
        If Me.Qtd.Text = "" Then
            Me.Qtd.Text = FormatNumber(0, 2)
        End If
    End Sub

    Private Sub Qtd_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qtd.Leave
        Me.Qtd.Text = FormatNumber(Nz(Me.Qtd.Text, 3), 4)
        Me.Total.Text = FormatCurrency(CDbl(Me.ValorUnitario.Text) * Me.Qtd.Text, 2)

    End Sub

    Private Sub SalvarItens_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarItens.Click
        If Me.CodigoProduto.Text = "" Then
            MsgBox("Não foi localizado um produto válido", 48, "Validador de Dados")
            DestravaCampos()
            Me.CodigoProduto.Focus()
            Exit Sub
        End If


        If Me.CFOP.Text = "" Then
            MsgBox("Não foi informado o CFOP do produto.", 48, "Validador de Dados")
            DestravaCampos()
            Me.CFOP.Focus()
            Exit Sub
        End If

        If NzZero(Me.Qtd.Text) = 0 Then
            MessageBox.Show("O usuário não pode adicionar item com quantidade ZERO, favor verificar.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DestravaCampos()
            Me.Qtd.Focus()
            Exit Sub
        End If

        If NzZero(Me.ValorUnitario.Text) = 0 Then
            MessageBox.Show("O usuário não pode adicionar um item com valor unitario ZERO.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DestravaCampos()
            Me.ValorUnitario.Focus()
            Exit Sub
        End If


        If Me.cTamanho.Text = "" Then
            MessageBox.Show("O usuário não pode adicionar um item sem Tamanho.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.cTamanho.Focus()
            Exit Sub

        End If





        With cAddItem
            .Comprainterno = SellShoesPedidoCompra.CodigoPedidoCompra.Text
            .Codigoproduto = Me.CodigoProduto.Text
            .Qtd = Me.Qtd.Text
            .Valorunitario = Me.ValorUnitario.Text
            .Totalproduto = Me.Total.Text
            .Cfop = Me.CFOP.Text
            .Tamanho = Me.cTamanho.Text
            .QtdEntregue = 0
        End With
        If Operation = INS Then
            cAddItem.Gravar()
            Operation = INS
            cAddItem.DgvCustom = My.Forms.SellShoesPedidoCompra.dgv
            cAddItem.AtGrade(cAddItem.Comprainterno)
        ElseIf Operation = UPD Then

            cAddItem.Editar(Me.Id.Text)
            cAddItem.DgvCustom = My.Forms.SellShoesPedidoCompra.dgv
            cAddItem.AtGrade(cAddItem.Comprainterno)
            Me.Close()
            Me.Dispose()
        End If
        MessageBox.Show("Registro gravado com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Operation = INS

        Me.cTamanho.SelectedIndex = -1
        Me.Qtd.Clear()
        Me.cTamanho.Focus()
        Me.Total.Clear()


    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        My.Forms.SellShoesCompra.TabGeral.SelectedTab = My.Forms.SellShoesCompra.TabItem1

        Me.Close()

        Me.Dispose()
    End Sub

    Public Sub LocalizaItens()
        If Me.Id.Text = "" Then
            Exit Sub
            End
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT PedidoCompraItem.*, Produtos.Descrição, CFOP.Descrição, PedidoCompraItem.Id FROM (PedidoCompraItem INNER JOIN Produtos ON PedidoCompraItem.CodigoProduto = Produtos.CodigoProduto) LEFT JOIN CFOP ON PedidoCompraItem.CFOP = CFOP.CFOP WHERE (((PedidoCompraItem.Id)=" & Me.Id.Text & "));"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then

            Me.CodigoProduto.Text = DR.Item("CodigoProduto")
            Me.DescProduto.Text = DR.Item("Produtos.Descrição") & ""
            Me.CFOP.Text = DR.Item("CFOP") & ""
            Me.CFOPDesc.Text = DR.Item("CFOP.Descrição") & ""
            EncheComboNum()
            Me.Qtd.Text = FormatNumber(DR.Item("Qtd"), 4)
            Me.ValorUnitario.Text = FormatCurrency(NzZero(DR.Item("ValorUnitario")), 5)
            Me.ValorP.Text = FormatCurrency(NzZero(DR.Item("ValorP")), 5)
            Me.Total.Text = FormatCurrency(NzZero(DR.Item("TotalProduto")), 2)
            Me.cTamanho.Text = DR.Item("Tamanho") & ""
   
            Operation = UPD
        Else
            MessageBox.Show("Esta identificação do Produto não foi encontrada.", "Validador de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Operation = INS
            Me.CodigoProduto.Clear()
            Me.Qtd.Clear()
            Me.ValorUnitario.Clear()
            Me.ValorP.Clear()
            Me.Total.Clear()
            Me.CodigoProduto.Focus()
        End If

        DR.Close()
        CNN.Close()

    End Sub
    Private Sub EncheComboNum()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "Select ProdutoGrade.Numero, ProdutoGrade.Sequencia From ProdutoGrade  Where Produto =" & Me.CodigoProduto.Text

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")


        Me.cTamanho.DataSource = ds.Tables("Table").DefaultView
        Me.cTamanho.DisplayMember = "Numero"
        Me.cTamanho.ValueMember = "Sequencia"
        Me.cTamanho.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub AcharCFOP()
        If Me.CFOP.Text = "" Then Exit Sub

        Dim DR As OleDb.OleDbDataReader

        Dim CNNBanco As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNNBanco.Open()

        Dim Sql As String = "Select * from CFOP where CFOP = '" & Me.CFOP.Text & "' And inativo = False"
        Dim CMD As New OleDb.OleDbCommand(Sql, CNNBanco)

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows = True Then
            Me.CFOP.Text = DR.Item("CFOP") & ""
            Me.CFOPDesc.Text = DR.Item("Descrição") & ""
        Else
            Me.CFOP.Clear()
            Me.CFOPDesc.Clear()
            Me.CFOP.Focus()
        End If
        DR.Close()
        CNNBanco.Close()
    End Sub

    Private Sub CFOP_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CFOP.Validated
        If String.CompareOrdinal(Me.CFOP.Text, Me.CFOP.TextoAntigo) Then
            AcharCFOP()
        End If
    End Sub

    Private Sub btFindProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindProduto.Click
        SellShoesProdutoProcura.ShowDialog()
        LocalizaProduto()
    End Sub

    Private Sub btFindCFOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindCFOP.Click
        My.Forms.CFOPProcura.ShowDialog()
        AcharCFOP()
    End Sub

    Private Sub CFOP_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CFOP.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.CFOPProcura.ShowDialog()
            AcharCFOP()
        End If
    End Sub

    Private Sub ValorP_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorP.Enter
        If CDbl(NzZero(Me.ValorP)) = 0 Then
            Me.ValorP.Text = Me.ValorUnitario.Text
        End If

    End Sub


    Private Sub GroupNumeracao_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupNumeracao.Enter
        TravaCampos()
    End Sub
    Sub TravaCampos()
        Me.CodigoProduto.Enabled = False
        Me.CFOP.Enabled = False
        Me.ValorUnitario.Enabled = False
        Me.ValorP.Enabled = False
        Me.btFindCFOP.Enabled = False
        Me.btFindProduto.Enabled = False
        Me.DescProduto.Enabled = False
        Me.CFOPDesc.Enabled = False
    End Sub
    Sub DestravaCampos()
        Me.CodigoProduto.Enabled = True
        Me.CFOP.Enabled = True
        Me.ValorUnitario.Enabled = True
        Me.ValorP.Enabled = True
        Me.btFindCFOP.Enabled = True
        Me.btFindProduto.Enabled = True
        Me.DescProduto.Enabled = True
        Me.CFOPDesc.Enabled = True

    End Sub

    Private Sub butNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butNovo.Click
        DestravaCampos()
        Me.CodigoProduto.Clear()
        Me.DescProduto.Clear()
        Me.Qtd.Clear()
        Me.ValorUnitario.Clear()
        Me.Total.Clear()
        Me.ValorP.Clear()

        Me.CFOP.Clear()
        Me.CFOPDesc.Clear()

        Me.CodigoProduto.Focus()
        Me.cTamanho.SelectedIndex = -1

    End Sub
    Private Sub cTamanho_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cTamanho.Leave
        If Me.cTamanho.Text = "" Then
            Me.butNovo.Focus()
        End If
    End Sub

End Class