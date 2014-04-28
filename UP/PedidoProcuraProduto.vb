Imports System.Data.OleDb

Public Class PedidoProcuraProduto

    Dim Ds As New DataSet
    Dim bs As BindingSource

    Dim Filtro As String = String.Empty

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
        CarregaTodosProdutos()
    End Sub


    Private Sub DgvItem_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellDoubleClick

        If My.Forms.PedidoAddItem.Visible = True Then
            If UsarGrade = False Then
                My.Forms.PedidoAddItem.CodigoProduto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
            End If
            Me.Close()
            Me.Dispose()
            Return
        End If

    End Sub


    Private Sub DgvItem_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DgvItem.KeyDown

        If e.KeyCode = Keys.Enter Then
            If My.Forms.PedidoAddItem.Visible = True Then
                If UsarGrade = False Then
                    My.Forms.PedidoAddItem.CodigoProduto.Text = Me.DgvItem.CurrentRow.Cells("codigo").Value
                End If
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

    Private Sub CarregaTodosProdutos()
        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT Produtos.CodigoProduto, Produtos.CodigoOriginal, Produtos.CodigoFabrica, Produtos.Descrição, Produtos.UnidadeMedida, IIf([Tipo]=1,'PRODUTO',IIf([Tipo]=2,'MATERIA PRIMA',IIf([Tipo]=3,'ALMOXARIFADO',IIf([Tipo]=4,'IMOBILIZADO',IIf([Tipo]=5,'PROD. INDUST'))))) AS TP, ProdutoLocal.SetorLocalDesc, Produtos.QuantidadeEstoque, Produtos.EstDeposito, Produtos.ValorVenda, Marcas.Marca, Produtos.Referencia, Produtos.CodigoBarra FROM (Produtos LEFT JOIN ProdutoLocal ON Produtos.Localização = ProdutoLocal.SetorLocal) LEFT JOIN Marcas ON Produtos.Marca = Marcas.Codigo WHERE (((Produtos.Tipo)<>99) AND ((Produtos.Empresa)=" & CodEmpresa & ") AND ((Produtos.Inativo)=False));"
        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        da.Fill(Ds, "Table")

        bs = New BindingSource
        bs.DataSource = Ds.Tables("Table").DefaultView

        Me.DgvItem.DataSource = bs

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub pMarca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pMarca.TextChanged
        If Me.pMarca.Text <> "" Then
            Me.pDescricao.Clear()
            bs.Filter = "Marca like '%" & Me.pMarca.Text & "%'"
        End If
    End Sub

    Private Sub pDescricao_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pDescricao.TextChanged
        If Me.pDescricao.Text <> "" Then
            If Me.pMarca.Text <> "" Then
                bs.Filter = "Marca like '%" & Me.pMarca.Text & "%' and Descrição like '%" & Me.pDescricao.Text & "%'"
            Else
                bs.Filter = "Descrição like '%" & Me.pDescricao.Text & "%'"
            End If
        End If
    End Sub

    Public ColunaProcurar As Integer
    Private Sub DgvItem_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DgvItem.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bs.Filter = Nothing
            Select Case e.ColumnIndex
                Case 0
                    ColunaProcurar = 0
                    My.Forms.PedidoProcuraProdutoFind.ShowDialog()
                Case 1
                    ColunaProcurar = 1
                    My.Forms.PedidoProcuraProdutoFind.ShowDialog()
                Case 2
                    ColunaProcurar = 2
                    My.Forms.PedidoProcuraProdutoFind.ShowDialog()
                Case 3
                    ColunaProcurar = 3
                    My.Forms.PedidoProcuraProdutoFind.ShowDialog()
                Case 4
                    ColunaProcurar = 4
                    My.Forms.PedidoProcuraProdutoFind.ShowDialog()
            End Select

        End If
    End Sub

    Public Sub AcharPorColuna(ByVal Coluna As Integer, ByVal TextoAchar As String)

        Select Case Coluna
            Case 0
                Try
                    bs.Filter = "CodigoProduto = " & TextoAchar
                Catch ex As Exception
                    bs.Filter = Nothing
                End Try
            Case 1
                Try
                    bs.Filter = "CodigoOriginal = '" & TextoAchar & "'"
                Catch ex As Exception
                    bs.Filter = Nothing
                End Try
            Case 2
                Try
                    bs.Filter = "CodigoFabrica = '" & TextoAchar & "'"
                Catch ex As Exception
                    bs.Filter = Nothing
                End Try
            Case 3
                Try
                    bs.Filter = "Descrição like '%" & TextoAchar & "%'"
                Catch ex As Exception
                    bs.Filter = Nothing
                End Try
        End Select
    End Sub



    Private Sub btLimparFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLimparFiltro.Click
        Me.bs.Filter = Nothing
    End Sub
End Class