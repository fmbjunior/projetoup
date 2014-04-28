Public Class ProcuraProdutoIndustria

    Dim opt As Integer

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ProcuraProdutoIndustria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.A2.Checked = True
        Me.txtProcura.Focus()
    End Sub

    Private Sub txtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProcura.Leave

        If Me.A3.Checked = True Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim Sql As String = ""
        If Me.A1.Checked = True Then
            Sql = "SELECT Produtos.CodigoProduto, Produtos.Descrição, IIf([Tipo]=1,'PRODUTO',IIf([Tipo]=2,'MATERIA PRIMA',IIf([Tipo]=3,'ALMOXARIFADO',IIf([Tipo]=4,'IMOBILIZADO',IIf([Tipo]=5,'PROD. INDUST'))))) AS TP, Produtos.QuantidadeEstoque, Produtos.CodigoOriginal, Produtos.CodigoFabrica   FROM(Produtos) WHERE Tipo = 5 And (((Produtos.CodigoProduto)=" & Me.txtProcura.Text & ") AND ((Produtos.Empresa)=" & CodEmpresa & "));"
        End If
        If Me.A2.Checked = True Then
            Sql = "SELECT Produtos.CodigoProduto, Produtos.Descrição, IIf([Tipo]=1,'PRODUTO',IIf([Tipo]=2,'MATERIA PRIMA',IIf([Tipo]=3,'ALMOXARIFADO',IIf([Tipo]=4,'IMOBILIZADO',IIf([Tipo]=5,'PROD. INDUST'))))) AS TP, Produtos.QuantidadeEstoque, Produtos.CodigoOriginal, Produtos.CodigoFabrica   FROM(Produtos) WHERE Tipo = 5 And Produtos.Descrição Like '%" & Me.txtProcura.Text & "%' AND Produtos.Empresa = " & CodEmpresa
        End If

        If Me.A4.Checked = True Then
            Sql = "SELECT Produtos.CodigoProduto, Produtos.Descrição, IIf([Tipo]=1,'PRODUTO',IIf([Tipo]=2,'MATERIA PRIMA',IIf([Tipo]=3,'ALMOXARIFADO',IIf([Tipo]=4,'IMOBILIZADO',IIf([Tipo]=5,'PROD. INDUST'))))) AS TP, Produtos.QuantidadeEstoque, Produtos.CodigoOriginal, Produtos.CodigoFabrica, Produtos.ValorVenda   FROM(Produtos) WHERE Tipo = 5 And Produtos.CodigoOriginal Like '%" & Me.txtProcura.Text & "%' AND Produtos.Empresa = " & CodEmpresa
        End If

        If Me.A5.Checked = True Then
            Sql = "SELECT Produtos.CodigoProduto, Produtos.Descrição, IIf([Tipo]=1,'PRODUTO',IIf([Tipo]=2,'MATERIA PRIMA',IIf([Tipo]=3,'ALMOXARIFADO',IIf([Tipo]=4,'IMOBILIZADO',IIf([Tipo]=5,'PROD. INDUST'))))) AS TP, Produtos.QuantidadeEstoque, Produtos.CodigoOriginal, Produtos.CodigoFabrica, Produtos.ValorVenda   FROM(Produtos) WHERE Tipo = 5 And Produtos.CodigoFabrica Like '%" & Me.txtProcura.Text & "%' AND Produtos.Empresa = " & CodEmpresa
        End If



        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet
        Da.Fill(ds, "Table")

        Me.DgvItem.DataSource = ds.Tables("Table").DefaultView


        Da.Dispose()
        CNN.Close()
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


            Dim Sql As String = "SELECT Produtos.CodigoProduto, Produtos.Descrição, IIf([Tipo]=1,'PRODUTO',IIf([Tipo]=2,'MATERIA PRIMA',IIf([Tipo]=3,'ALMOXARIFADO',IIf([Tipo]=4,'IMOBILIZADO',IIf([Tipo]=5,'PROD. INDUST'))))) AS TP, Produtos.QuantidadeEstoque, Produtos.CodigoOriginal, Produtos.CodigoFabrica, Produtos.ValorVenda   FROM(Produtos) WHERE Tipo = 5 And Produtos.Empresa =" & CodEmpresa

            Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
            Dim Da As New OleDb.OleDbDataAdapter(CMD)

            Dim ds As New DataSet
            Da.Fill(ds, "Table")

            Me.DgvItem.DataSource = ds.Tables("Table").DefaultView


            Da.Dispose()
            CNN.Close()
        End If
    End Sub



    Private Sub DgvItem_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellDoubleClick

        If My.Forms.ProducaoAddItem.Visible = True Then
            My.Forms.ProducaoAddItem.Produto.Text = Me.DgvItem.CurrentRow.Cells(0).Value
            My.Forms.ProducaoAddItem.LocalizaProduto()
            Me.Close()
            Me.Dispose()
        End If

    End Sub


End Class