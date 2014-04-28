Public Class ComprasRelat

    Dim A��o As New TrfGerais

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A20.CheckedChanged, A21.CheckedChanged, A3.CheckedChanged, A4.CheckedChanged, A5.CheckedChanged
        If A1.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelFornecedor.Visible = False
            Me.PainelProdutos.Visible = False
            Me.DataInicial.Focus()
        End If

        If A2.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelFornecedor.Visible = True
            Me.PainelProdutos.Visible = False
            Me.DataInicial.Focus()
        End If

        If A3.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelFornecedor.Visible = False
            Me.PainelProdutos.Visible = True
            Me.DataInicial.Focus()
        End If

        If A4.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelFornecedor.Visible = False
            Me.PainelProdutos.Visible = False
            Me.DataInicial.Focus()
        End If
        If A5.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelFornecedor.Visible = False
            Me.PainelProdutos.Visible = False
            Me.DataInicial.Focus()
        End If


        If A20.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelFornecedor.Visible = False
            Me.PainelProdutos.Visible = False
            Me.DataInicial.Focus()
        End If

        If A21.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelFornecedor.Visible = True
            Me.PainelProdutos.Visible = False
            Me.DataInicial.Focus()
        End If


    End Sub

    Private Sub Visualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Visualizar.Click
        If Me.A1.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usu�rio deve informar a data inicial para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usu�rio deve informar a data Final para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelComprasPeriodo"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A2.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usu�rio deve informar a data inicial para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usu�rio deve informar a data Final para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            If Me.Fornecedor.Text = "" Then
                MsgBox("O usu�rio deve informar o Fornecedor para o relat�rio.", 64, "Valida��o de Dados")
                Me.Fornecedor.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelComprasPeriodoFornecedor"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If


        If Me.A3.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usu�rio deve informar a data inicial para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usu�rio deve informar a data Final para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            If Me.Produto.Text = "" Then
                MsgBox("O usu�rio deve informar o c�digo do produto para o relat�rio.", 64, "Valida��o de Dados")
                Me.Produto.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelCompraIten"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A4.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usu�rio deve informar a data inicial para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usu�rio deve informar a data Final para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelComprasPeriodo"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A5.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usu�rio deve informar a data inicial para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usu�rio deve informar a data Final para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If
            'faz a chamada do relatorio
            Dim rel As New RelCompraSintetico
            rel.periodo.Text = "Relat�rio de Nota Fiscais no Per�odo de " + Me.DataInicial.Text + " a " + Me.DataFinal.Text

            My.Forms.ViewReport.VerRelat.Document = rel.Document
            rel.Run(True)
            My.Forms.ViewReport.ShowDialog()

        End If


        If Me.A20.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usu�rio deve informar a data inicial para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usu�rio deve informar a data Final para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelEntradasConfAnalitico"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A21.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usu�rio deve informar a data inicial para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usu�rio deve informar a data Final para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            If Me.Fornecedor.Text = "" Then
                MsgBox("O usu�rio deve informar o Fornecedor para o relat�rio.", 64, "Valida��o de Dados")
                Me.Fornecedor.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelEntradasConfAnaliticoFornecedor"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

    End Sub

    Private Sub Fornecedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fornecedor.KeyDown
        If e.KeyCode = Keys.F5 Then
            'ChamaTelaProcura("Codigo", "Raz�o Social", "", "Fornecedor", "C�digoFornecedor", "Raz�oSocial", "", True)
            'Me.Fornecedor.Text = RetornoProcura
            'If Me.Fornecedor.Text <> "" Then
            '    A��o.Descri��o_ItenRegistro(Me.Fornecedor, Me.FornecedorDesc, "Fornecedor", "C�digoFornecedor", Me.Fornecedor.Text, "Raz�oSocial", TrfGerais.TipoDados.Num�rico, True)
            'End If
            My.Forms.TelaProcuraFor.ShowDialog()
        End If
    End Sub

    Private Sub Fornecedor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fornecedor.Leave
        A��o.Descri��o_ItenRegistro(Me.Fornecedor, Me.FornecedorDesc, "Fornecedor", "C�digoFornecedor", Me.Fornecedor.Text, "Raz�oSocial", TrfGerais.TipoDados.Num�rico, True)
    End Sub

    Private Sub Produto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Produto.KeyDown
        If e.KeyCode = Keys.F5 Then
            Me.Produto.Clear()
            Me.ProdutoDesc.Clear()
            My.Forms.ProcuraProduto.ShowDialog()
        End If
    End Sub

    Private Sub Produto_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Produto.Validated
        If Me.Produto.Text <> "" Then
            A��o.Descri��o_ItenRegistro(Me.Produto, Me.ProdutoDesc, "Produtos", "CodigoProduto", Me.Produto.Text, "Descri��o", TrfGerais.TipoDados.Num�rico, True)
        End If
    End Sub

    Private Sub ComprasRelat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class