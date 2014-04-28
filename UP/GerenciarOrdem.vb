Public Class GerenciarOrdem
    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
    Dim Sql As String = String.Empty
    Dim oDa As OleDb.OleDbDataAdapter
    Dim oTb As DataTable
    Dim ds As New DataSet
    Dim ods As New DataSet

    Dim Ação As New TrfGerais
    Dim ValorIpiLancamentos As Double
    Dim AliquotaFrete As Double

    Public tbProdutos As New DataTable
    Dim rowNew As DataRow
    Public DsProdutos As New DataSet
    Dim quantity As Decimal
    Dim chvNF As Integer
    Dim IdProd As String = String.Empty
    Dim vQ As String
    Dim AddDel As String = "Add"
    Dim EncontrouReg As Boolean = False
    Public sTipo As String = String.Empty
    Public salvouReg As Boolean = True
    Public Retorno As Integer
    Dim odts As New DataSet


    Public Sub MarcarLInha(ByVal dgw As DataGridView)

        Dim vQtdAp As Decimal = 0
        Dim vQtdSol As Decimal = 0
        Dim res As Decimal = 0

        For i As Integer = 0 To dgw.Rows.Count - 1



            'If dgw.Rows(i).Selected Then
            vQtdAp = Me.DgvItem.Rows(i).Cells("gQtde").Value
            vQtdSol = Me.DgvItem.Rows(i).Cells("glanc").Value
            res = vQtdAp - vQtdSol
            Me.DgvItem.Rows(i).Cells("col7").Value = res


            'End If
            'If dgw.Rows(i).Cells("Qtd").Value = dgw.Rows(i).Cells("Estoque").Value Then
            '    dgw.Rows(i).Cells("Qtd").Style.BackColor = Color.Red
            '    dgw.Rows(i).Cells("Estoque").Style.BackColor = Color.Red
            'End If
        Next
    End Sub


       Public Sub AtGrid()
        ds.Clear()
        If Me.DataGridView1.RowCount > 0 Then
            Retorno = Me.DataGridView1.CurrentRow.Cells(0).Value
        Else
            Exit Sub
        End If
        Dim CNN As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        CNN.Open()

        Dim Sql As String = "SELECT CompraCtrlPedidoItens.Codigo, CompraCtrlPedidoItens.Produto, CompraCtrlPedidoItens.qtd, CompraCtrlPedidoItens.QtdLancEstoque, CompraCtrlPedidoItens.ValorUnitario, CompraCtrlPedidoItens.ValorTotal, CompraCtrlPedidoItens.QtdAlancar, Produtos.Descrição FROM CompraCtrlPedidoItens LEFT JOIN Produtos ON CompraCtrlPedidoItens.Produto = Produtos.CodigoProduto WHERE (((CompraCtrlPedidoItens.IdPedido)=" & Retorno & "));"

        '"SELECT CompraCtrlPedidoItens.*, CompraCtrlPedidoItens.IdPedido, Produtos.Descrição FROM CompraCtrlPedidoItens LEFT JOIN Produtos ON CompraCtrlPedidoItens.Produto = Produtos.CodigoProduto WHERE (((CompraCtrlPedidoItens.IdPedido)=" & Me.Id.Text & "));"


        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)


        Da.Fill(ds, "Table")


        Me.DgvItem.DataSource = ds.Tables("Table").DefaultView

        If Me.DgvItem.RowCount > 0 Then
            Me.ValorGerenciador.Text = Me.ds.Tables("Table").Compute("SUM(ValorTotal)", "")



            MarcarLInha(DgvItem)
            Me.LancaItens.Checked = True
            sTipo = "ORDEM"
            Me.LblTipoDoc.Text = "Ordem de Compra"
        Else
            Me.LancaItens.Checked = False
            sTipo = "DOC"
            Me.LblTipoDoc.Text = "DOCUMENTO DE ENTRADA"
        End If

        Da.Dispose()
        CNN.Close()

    End Sub
    Public Sub BuscaEmpresa()
        'Localizar uma ordem já lançada para poder gerar uma notafiscal de entra.

        Dim CNN As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        CNN.Open()

        Dim Sql As String = "SELECT CódigoEmpresa,RazãoSocial From Empresa WHERE CódigoEmpresa=" & CodEmpresa

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows = True Then
            EncontrouReg = True
            Me.EmpresaDesc.Text = DR.Item("RazãoSocial")

            DR.Close()
        Else


            DR.Close()
            EncontrouReg = False
            Exit Sub
        End If
        CNN.Close()
    End Sub

    Public Sub LocalizaDados()

        'Localizar uma ordem já lançada para poder gerar uma notafiscal de entra.

        Dim CNN As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        CNN.Open()

        Dim Sql As String = "SELECT GerenciadorDoc.*, Fornecedor.RazãoSocial FROM GerenciadorDoc INNER JOIN Fornecedor ON GerenciadorDoc.Fornecedor = Fornecedor.CódigoFornecedor WHERE (((GerenciadorDoc.ID)=" & Me.Id.Text & ") AND ((GerenciadorDoc.Empresa)=" & CodEmpresa & "));"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows = True Then
            EncontrouReg = True

            Me.Fornecedor.Text = DR.Item("Fornecedor") & ""
            Me.FornecedorDesc.Text = DR.Item("RazãoSocial") & ""
            Me.DataLancamento.Text = DR.Item("Datalancamento") & ""
            Me.TotalProduto.Text = FormatCurrency(Nz(DR.Item("Total"), 3), 2)
            Me.ValorGerenciador.Text = FormatCurrency(Nz(DR.Item("Total"), 3), 2)
            Me.PlanoContasFornecedor.Text = DR.Item("CodPlanoConta") & ""
            Me.Finalizado.Checked = DR.Item("Finalizado")
            Me.Empresa.Text = DR.Item("Empresa")
            Me.LancaItens.Checked = DR.Item("LancaItens")
            Me.nfdevolução.Checked = DR.Item("devolucao")
            sTipo = DR.Item("TipoPedido") & ""
            BuscaEmpresa()
            Operation = UPD

        Else
            Me.LblTipoDoc.Text = ""

            DR.Close()
            EncontrouReg = False
            Exit Sub
        End If



        If sTipo = "DOC" Then
           
            Me.LblTipoDoc.Text = "DOCUMENTO DE ENTRADA"
            Me.GroupBox3.Enabled = True
            Me.codigoproduto.Focus()
        Else
            Me.LblTipoDoc.Text = "Ordem de Compra"
        End If


        DR.Close()


    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Me.Dispose()

    End Sub


    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    '*****************************************************************************************************************************************
    'Adiciona item no  data set.
    'data: 18/06/09
    'Criado por: Beto
    '***************************************** ************************************************************************************************
    Private Sub AddItem()

        

        rowNew = DsProdutos.Tables(0).NewRow            'Set o DataRow do DataSet para criar uma nova linha.
        
        rowNew("CodigoProduto") = Me.codigoproduto.Text
        rowNew("Descricao") = Me.DescProduto.Text & ""
        rowNew("qtd") = Me.Qtd.Text & ""
        rowNew("valorunitario") = CDbl(Me.ValorUnitario.Text)
        rowNew("totalproduto") = CDbl(Me.Total.Text)
        rowNew("ipi") = Me.IpiProduto.Text
        rowNew("valoripi") = CDbl(Me.ValorIpiProduto.Text)
        rowNew("seqnf") = Nz(Me.SeqNf.Text, 1)
        rowNew("cst") = Nz(Me.Cst.Text, 1)
        rowNew("cf") = Nz(Me.CF.Text, 1)
        rowNew("cfop") = Nz(Me.CFOP.Text, 1)
        rowNew("icmsproduto") = Me.IcmsProduto.Text
        rowNew("valoricmsproduto") = CDbl(Me.ValorIcmsProduto.Text)
        rowNew("PisProduto") = Me.PisProduto.Text & ""
        rowNew("ValorPisProduto") = CDbl(Me.ValorPisProduto.Text)
        rowNew("CofinsProduto") = Me.CofinsProduto.Text & ""
        rowNew("ValorConfisProduto") = CDbl(Me.ValorCofinsProduto.Text)
        rowNew("FreteProduto") = Me.FreteProduto.Text & ""
        rowNew("ValorFreteProduto") = CDbl(Me.ValorFreteProduto.Text)
        rowNew("ClassContabilProduto") = Nz(Me.ClassContabilProduto.Text, 1)


        DsProdutos.Tables(0).Rows.Add(rowNew)           'Insere uma nova linha no dataSet no objeto datatable.
        DsProdutos.AcceptChanges()                      'Atualiza o datatable.

        If sTipo = "DOC" Then
        Else
            Me.DgvItem.CurrentRow.Cells("gLanc").Value += Me.Qtd.Text
        End If


        Me.codigoproduto.Text = ""
        Me.DescProduto.Text = ""
        Me.Qtd.Clear()
        Me.ValorUnitario.Clear()
        Me.Total.Clear()
        Me.IpiProduto.Clear()
        Me.ValorIpiProduto.Clear()
        Me.SeqNf.Clear()
        Me.Cst.Clear()
        Me.CF.Clear()
        Me.CFOP.Clear()
        Me.IcmsProduto.Clear()
        Me.ValorIcmsProduto.Clear()
        Me.PisProduto.Clear()
        Me.ValorPisProduto.Clear()
        Me.CofinsProduto.Clear()
        Me.ValorCofinsProduto.Clear()
        Me.FreteProduto.Clear()
        Me.ValorFreteProduto.Clear()
        Me.ClassContabilProduto.Clear()






    End Sub


    Private Sub CarregaLista()






        MyLista.Items.Clear()

        Try


            Dim Zebrar As Boolean = False
            Dim sValue As Double = 0



            Dim DrLista As DataRow
            For Each DrLista In tbProdutos.Rows

                Dim AA As String = DrLista("item")
                Dim It As New ListViewItem(AA, 0)
                It.SubItems.Add(DrLista("CodigoProduto"))
                It.SubItems.Add(DrLista("Descricao"))
                It.SubItems.Add(Format(DrLista("qtd"), "#,###0.000"))
                It.SubItems.Add(Nz(DrLista("seqnf"), 2))

                If AddDel = "Add" Then
                    sValue += DrLista("totalProduto")
                Else
                    sValue += DrLista("totalProduto")
                End If
                Me.Label5.Text = sValue
                Me.Label5.Text = FormatNumber(Me.Label5.Text, 2)

                'It.SubItems.Add(DrLista("Historico"))

                MyLista.Items.AddRange(New ListViewItem() {It})

                If Zebrar = True Then
                    MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                    Zebrar = False
                Else
                    MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.MistyRose
                    Zebrar = True
                End If

            Next

            'Dim i As Integer
            'For i = 0 To Me.MyLista.Items.Count - 1
            '    Me.Label5.Text += Me.MyLista.SelectedItems.Item(i).SubItems(4).Text

            'Next



            If tbProdutos.Rows.Count = 0 Then
                Me.Label5.Text = "0,00"
            End If

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Exit Sub
        End Try

    End Sub

    Private Sub GerenciarOrdem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ação.Desbloquear_Controle(Me, False) 'Define todos os controle bloqueados.
        If Cnn.State = ConnectionState.Closed Then
            Cnn.Open()
        End If
        DsProdutos.Tables.Add(tbProdutos)
        DsProdutos.Tables(0).Columns.Add("Item", GetType(Integer))
        DsProdutos.Tables(0).Columns(0).AutoIncrement = True      'Auto incrementada .
        DsProdutos.Tables(0).Columns(0).AutoIncrementSeed = 1     'De um em 1.
        DsProdutos.Tables(0).Columns(0).AutoIncrementStep = 1     '
        DsProdutos.Tables(0).Columns(0).Unique = True             'Seja Chave unica .


        DsProdutos.Tables(0).Columns.Add("CodigoProduto", GetType(String))
        DsProdutos.Tables(0).Columns.Add("Descricao", GetType(String))
        DsProdutos.Tables(0).Columns.Add("qtd", GetType(Decimal))
        DsProdutos.Tables(0).Columns.Add("valorunitario", GetType(Decimal))
        DsProdutos.Tables(0).Columns.Add("totalproduto", GetType(Decimal))
        DsProdutos.Tables(0).Columns.Add("ipi", GetType(Decimal))
        DsProdutos.Tables(0).Columns.Add("valoripi", GetType(Decimal))
        DsProdutos.Tables(0).Columns.Add("seqnf", GetType(Integer))
        DsProdutos.Tables(0).Columns.Add("cst", GetType(String))
        DsProdutos.Tables(0).Columns.Add("cf", GetType(String))
        DsProdutos.Tables(0).Columns.Add("cfop", GetType(String))
        DsProdutos.Tables(0).Columns.Add("icmsproduto", GetType(Decimal))
        DsProdutos.Tables(0).Columns.Add("valoricmsproduto", GetType(Decimal))
        DsProdutos.Tables(0).Columns.Add("PisProduto", GetType(Decimal))
        DsProdutos.Tables(0).Columns.Add("ValorPisProduto", GetType(Decimal))
        DsProdutos.Tables(0).Columns.Add("CofinsProduto", GetType(Decimal))
        DsProdutos.Tables(0).Columns.Add("ValorConfisProduto", GetType(Decimal))
        DsProdutos.Tables(0).Columns.Add("FreteProduto", GetType(Decimal))
        DsProdutos.Tables(0).Columns.Add("ValorFreteProduto", GetType(Decimal))
        DsProdutos.Tables(0).Columns.Add("ClassContabilProduto", GetType(String))
    End Sub
    Public Sub LocalizaProduto()
        If Me.codigoproduto.Text = "" Then
            Exit Sub
        End If

        Dim Sql As String = "Select * from Produtos where CodigoProduto = " & Me.codigoproduto.Text '& " and tipo = " & TipoItensProcurar
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.DescProduto.Text = DR.Item("Descrição") & ""
            Me.ValorUnitario.Text = FormatCurrency(Nz(DR.Item("ValorVenda"), 3), 2)
            Me.Cst.Text = DR.Item("Cst") & ""
            Me.CF.Text = DR.Item("Cf") & ""
            Me.PisProduto.Text = FormatNumber(NzZero(DR.Item("pPIS")), 2)
            Me.CofinsProduto.Text = FormatNumber(NzZero(DR.Item("pCofins")), 2)
        End If

        DR.Close()

    End Sub

    Private Sub DgvItem_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellDoubleClick
        Dim cRes As Decimal = 0
        cRes = Me.DgvItem.CurrentRow.Cells("Col7").Value

        If cRes = 0 Then
            MsgBox("Não é possível lançar este item, Toda a Quantidade já foi lançada", 48, TituloMsgbox)
            Exit Sub
        End If

        Me.codigoproduto.Text = Me.DgvItem.CurrentRow.Cells("gProduto").Value
        Me.DescProduto.Text = Me.DgvItem.CurrentRow.Cells("gDescricao").Value
        Me.Cst.Focus()
        LocalizaProduto()

        Me.ValorUnitario.Text = FormatCurrency(Nz(Me.DgvItem.CurrentRow.Cells("gUnitario").Value, 3), 4)
        Me.Qtd.Text = FormatNumber(cRes, 3)
    End Sub

    Private Sub Qtd_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Qtd.Enter
        If Me.Qtd.Text = "" Then
            Me.Qtd.Text = FormatNumber(0, 2)
        End If
    End Sub

    Private Sub Qtd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Qtd.Leave
        Me.Qtd.Text = FormatNumber(Nz(Me.Qtd.Text, 3), 4)
    End Sub

    Private Sub ValorUnitario_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorUnitario.Leave
        Me.Total.Text = FormatCurrency(CDbl(Me.ValorUnitario.Text) * Me.Qtd.Text, 4)
    End Sub
    Private Sub IpiProduto_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles IpiProduto.Enter
        If Me.IpiProduto.Text = "" Then Me.IpiProduto.Text = FormatNumber(0, 2)
    End Sub

    Private Sub IpiProduto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IpiProduto.Leave
        If Me.IpiProduto.Text = "" Then
            Me.IpiProduto.Text = 0
            Me.ValorIpiProduto.Text = FormatCurrency(0, 2)
        Else
            Me.ValorIpiProduto.Text = FormatCurrency(CDbl(Me.Total.Text) * CDbl(Me.IpiProduto.Text) / 100, 2)
        End If
    End Sub

    Private Sub IcmsProduto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IcmsProduto.Leave
        Me.ValorIcmsProduto.Text = CDbl(NzZero(Me.Total.Text)) * CDbl(NzZero(Me.IcmsProduto.Text)) / 100
    End Sub

    Private Sub PisProduto_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PisProduto.Enter
        If Me.PisProduto.Text = "" Then Me.PisProduto.Text = FormatNumber(0, 2)
    End Sub

    Private Sub PisProduto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PisProduto.Leave
        Me.ValorPisProduto.Text = CDbl(NzZero(Me.Total.Text)) * CDbl(NzZero(Me.PisProduto.Text)) / 100
    End Sub


    Private Sub CofinsProduto_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles CofinsProduto.Enter
        If Me.CofinsProduto.Text = "" Then Me.CofinsProduto.Text = FormatNumber(0, 2)
    End Sub

    Private Sub CofinsProduto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CofinsProduto.Leave
        Me.ValorCofinsProduto.Text = CDbl(NzZero(Me.Total.Text)) * CDbl(NzZero(Me.CofinsProduto.Text)) / 100
    End Sub


    Private Sub FreteProduto_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles FreteProduto.Enter
        If Me.FreteProduto.Text = "" Then Me.FreteProduto.Text = FormatNumber(0, 2)
        'If Me.ValorFrete.Text = "" Then Me.ValorFrete.Text = FormatNumber(0, 2)
        'If Me.ValorFrete.Text <> FormatNumber(0, 2) Then
        '    AliquotaFrete = (CDbl(Me.ValorFrete.Text) / CDbl(Me.ValorCompra.Text)) * 100
        '    Me.FreteProduto.Text = FormatNumber(AliquotaFrete)
        'Else
        '    Me.FreteProduto.Text = FormatNumber(0, 2)
        'End If
    End Sub

    Private Sub FreteProduto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles FreteProduto.Leave
        Me.ValorFreteProduto.Text = CDbl(NzZero(Me.Total.Text)) * CDbl(NzZero(Me.FreteProduto.Text)) / 100
    End Sub

    Private Sub ClassContabilProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ClassContabilProduto.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.CompraProcuraClassContabil.ShowDialog()
        End If
    End Sub

 

    Private Sub ClassContabilProduto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClassContabilProduto.Leave
        Me.ClassContabilProduto.Text = Ação.FormatSTR_EFOCUS(Me.ClassContabilProduto.Text, 4, 0, "E")

        If String.CompareOrdinal(Me.ClassContabilProduto.Text, Me.ClassContabilProduto.TextoAntigo) Then
            AchaClassContabil()
        End If

    End Sub
    Private Sub AchaClassContabil()

        If Me.CFOP.Text = "" Then
            Me.CFOP.Focus()
            Exit Sub
        End If

        If Me.ClassContabilProduto.Text = "" Then
            Me.ClassContabilProduto.Focus()
            Exit Sub
        End If

        Dim Sql As String = "SELECT * from ClassificadorContabil WHERE Cfop = '" & Me.CFOP.Text & "' and Classificador = '" & Me.ClassContabilProduto.Text & "'"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.ClassContabilProdutoDesc.Text = DR.Item("DescClassificador") & ""
        Else
            MsgBox("Classificador contábil não encontrado, verifique....", 64, TituloMsgbox)
            Me.ClassContabilProduto.Clear()
            Me.ClassContabilProdutoDesc.Clear()
            Me.ClassContabilProduto.Focus()
            Exit Sub
        End If
        DR.Close()

    End Sub

    Private Sub CFOP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CFOP.KeyDown
        If e.KeyCode = Keys.F5 Then
            ChamaTelaProcura("Codigo", "Descrição", "", "NatOperação", "NatOperação", "Descrição", "", True)
            CFOP.Text = RetornoProcura
        End If
    End Sub


    Private Sub SalvarItens_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarItens.Click
        Try
            If Me.LancaItens.Checked = False Then
                sTipo = "DOC"
            End If

            If sTipo = "DOC" Then
                If CDbl(Me.TotalProduto.Text) >= CDbl(Me.Total.Text) Then
                    AddItem()
                    CarregaLista()
                Else
                    MsgBox("O valor do produto está maior que o valor do documento. Verifique", 48, TituloMsgbox)
                    Exit Sub
                End If
            Else
                AdicionarItem()
            End If
        Catch EX As Exception

            MsgBox(Err.Description)
        End Try
    End Sub
    Public Sub AdicionarItem()
        AddDel = "Add"

        If CDbl(Me.TotalProduto.Text) > CDbl(Me.Label5.Text) Then
            Dim cTotIte As Decimal = 0
            Dim cTot As Decimal

            cTotIte = Me.DgvItem.CurrentRow.Cells("Col7").Value - Me.Qtd.Text

            If cTotIte >= 0 Then
            Else
                MsgBox("Quantidade digita é maior que a quantidade a ser lançada", 48, TituloMsgbox)
                Me.Qtd.Focus()
                Exit Sub
            End If

            cTot = CDbl(Me.Label5.Text) + CDbl(Me.Total.Text)

            If cTot <= Me.TotalProduto.Text Then



                AddItem()
                CarregaLista()
                MarcarLInha(DgvItem)

            Else
                MsgBox("O valor Lançado é maior que o Valor Total da Nota. Verifique", 48, TituloMsgbox)
                Exit Sub
            End If
        Else
            MsgBox("O total da nota está completo. Não é possível adicionar mais itens", 48, TituloMsgbox)
            Exit Sub
        End If
    End Sub
    Private Sub ExcluirItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirItem.Click
        AddDel = "Del"


        Dim id As String = String.Empty
        Dim I As Integer = 0
        Try
            If MessageBox.Show("Deseja realmente excluir o item da lista.", TituloMsgbox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                For I = 0 To MyLista.Items.Count - 1
                    If MyLista.Items(I).Selected = True Then
                        id = MyLista.Items(I).Text.Substring(0)

                        vQ = MyLista.Items(I).SubItems.Item(3).Text
                        IdProd = MyLista.Items(I).SubItems.Item(1).Text
                    End If

                Next
                Dim drLista() As DataRow = DsProdutos.Tables(0).Select("Item = '" & id & "'")
                DsProdutos.Tables(0).Rows.Remove(drLista(0))
                CarregaLista()
                Linha(Me.DgvItem)
                MarcarLInha(Me.DgvItem)
            End If

        Catch EX As Exception
            MsgBox(Err.Description)
        End Try


    End Sub
    Public Sub Linha(ByVal dgw As DataGridView)
        Dim cQtd As Decimal = 0
        For i As Integer = 0 To dgw.Rows.Count - 1
            If dgw.Rows(i).Cells("gProduto").Value = IdProd Then
                Me.DgvItem.Rows(i).Cells("gLanc").Value -= vQ
                Exit Sub
            End If

        Next
    End Sub

    Public Sub ViewNF()

        Dim CNN As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        CNN.Open()
        If odts.Tables.Count > 0 Then
            odts.Tables(0).Clear()
        End If


        Dim Sql As String = "SELECT COMPRA.CompraInterno, COMPRA.NotaFiscal, COMPRA.DataLançamento, COMPRA.ValorCompra, IIf([confirmado]=False,'Não','Sim') AS Expr1, COMPRA.Empresa, COMPRA.Inativo FROM(Compra) WHERE (((COMPRA.controle)=" & CInt(Me.Id.Text) & ") AND ((COMPRA.Empresa)=" & CodEmpresa & ") AND ((COMPRA.Inativo)=False));"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Da.Fill(odts, "Table")

        Me.dgvNF.DataSource = odts.Tables("Table").DefaultView
        If dgvNF.RowCount > 0 Then
            Me.totalselecionado.Text = Convert.ToDecimal(odts.Tables("Table").Compute("SUM(valorcompra)", "")).ToString("c")
            Me.VlrLancar.Text = FormatCurrency(CDbl(Me.TotalProduto.Text) - CDbl(Me.totalselecionado.Text), 2)
            If Me.VlrLancar.Text = 0 Then
                atFinalizado()
            End If
        Else
            Me.totalselecionado.Text = "0,00"
            Me.VlrLancar.Text = FormatCurrency(CDbl(Me.TotalProduto.Text) - CDbl(Me.totalselecionado.Text), 2)
        End If

        Da.Dispose()
        CNN.Close()
    End Sub
    Public Sub atFinalizado()
        Dim CNN As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        CNN.Open()

        Dim Cmd As New OleDb.OleDbCommand()
        With Cmd
            .Connection = CNN
            .CommandTimeout = 0
            .CommandText = "UPDATE GerenciadorDoc SET Finalizado = True WHERE ID=" & Me.Id.Text
            .CommandType = CommandType.Text
        End With
        Try

            Cmd.ExecuteNonQuery()
            Me.Finalizado.Checked = True
            CNN.Close()
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                CNN.Close()
                Exit Sub
            End If
        End Try
    End Sub

    Public Sub ViewDOC()

        If ods.Tables.Count > 0 Then
            ods.Tables("TableDoc").Clear()
        End If


        Dim CNN As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        CNN.Open()

        Dim Sql As String = "SELECT CompraCtrlPedido.Id, CompraCtrlPedido.ValorPedido  FROM (CompraCtrlPedido) WHERE (((CompraCtrlPedido.CodigoGerenciador)=" & Me.Id.Text & ") AND ((CompraCtrlPedido.Empresa)=" & CodEmpresa & ") AND ((CompraCtrlPedido.inativo)=false))"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)


        Da.Fill(ods, "TableDoc")

        Me.DataGridView1.DataSource = ods.Tables("TableDoc").DefaultView
        'If DataGridView1.RowCount > 0 Then
        '    Me.Label5.Text = Convert.ToDecimal(ods.Tables("TableDoc").Compute("SUM(valorcompra)", "")).ToString("c")
        'Else
        '    Me.Label5.Text = "0,00"
        'End If
        Da.Dispose()
        CNN.Close()
    End Sub
    Private Sub dgvNF_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvNF.CellDoubleClick

        chvNF = dgvNF.CurrentRow.Cells(0).Value
        RetornoProcura = chvNF
        My.Forms.Compra.LocalizaDados()
        My.Forms.Compra.EncheListaItens()
        My.Forms.Compra.ShowDialog()

    End Sub

    Public Sub AtValoresDoGrid()

        Try


            Dim Sql As String = String.Empty
            Sql = "SELECT * from CompraCtrlPedidoItens where idPedido=" & Retorno

            Dim oDA As New OleDb.OleDbDataAdapter(Sql, Cnn)
            Dim oDS As New DataSet
            oDA.Fill(oDS, "Itens")




            Dim DrLista As DataRow

            For Each DrLista In oDS.Tables("Itens").Rows
                ' Define os novos valores de DataRow

                DrLista.BeginEdit()
                For i As Integer = 0 To Me.DgvItem.Rows.Count - 1
                    If DgvItem.Rows(i).Cells("Column2").Value = DrLista.Item("Codigo") Then
                        DrLista.Item("QtdLancEstoque") = DgvItem.Rows(i).Cells("glanc").Value
                        DrLista.Item("QtdAlancar") = DgvItem.Rows(i).Cells("col7").Value
                        Exit For
                    End If

                Next
                
                DrLista.EndEdit()


            Next

            'Atualiza o 
            Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(oDA)

            oDA.Update(oDS, "Itens")
        Catch x As Exception
            MsgBox(x.Message)

        End Try
    End Sub

   

    Private Sub Id_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Id.Leave
        'If String.CompareOrdinal(Me.Id.Text, Me.Id.TextoAntigo) <> 0 Then
        '    If Me.Id.Text = "0000" Or Me.Id.Text = "" Then Exit Sub

        '    LocalizaDados()

        '    If EncontrouReg = True Then

        '        AtGrid()
        '        ViewNF()
        '        Me.MyLista.Items.Clear()
        '        Me.Fornecedor.Focus()
        '    Else
        '        AtGrid()
        '        ViewNF()
        '        Me.MyLista.Items.Clear()
        '        Ação.LimpaTextBox(Me)

        '        MsgBox("Não foi possível encontrar este Documento. Verifique se já foi confirmado", 48, TituloMsgbox)

        '    End If
        '    If Me.LblTipoDoc.Text = "Ordem de Compra" Then
        '        Me.codigoproduto.Enabled = False
        '    Else
        '        Me.codigoproduto.Enabled = True
        '    End If
        'End If
    End Sub

    Private Sub codigoproduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles codigoproduto.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ProcurarProdutoDetalhado.ShowDialog()
            Me.codigoproduto.Text = RetornoProcura
            LocalizaProduto()
        End If
    End Sub

  

    Private Sub codigoproduto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles codigoproduto.Leave
        LocalizaProduto()
    End Sub

    Private Sub BuscarDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Forms.BuscarDocOrdem.ShowDialog()

    End Sub

 
    Private Sub ButtonX2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ButtonX1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If Me.VlrLancar.Text = 0 Then
            MsgBox("Não é possível gerar NF, o total já foi completado", 48, TituloMsgbox)
            Exit Sub
        End If

        If salvouReg = False Then
            MsgBox("O registro ainda não foi salvo", 48, TituloMsgbox)
            Exit Sub
        End If

        If Me.DataGridView1.RowCount = 0 Then
            MsgBox("Não existem documentos selecionados para gerar uma nota fiscal", 48, TituloMsgbox)
            Exit Sub
        End If

        If Me.nfdevolução.Checked = True Then
            If Me.MyLista.Items.Count = 0 Then
                MsgBox("O documento é uma devolução, mas no entando não há itens lançados para ser devolvidos. Verifique", 48, TituloMsgbox)
                Exit Sub
            End If
        End If



        'Dim valor As Double = 0
        'If Me.dgvNF.RowCount > 0 Then

        '    For Each col As DataGridViewRow In Me.dgvNF.Rows
        '        valor += col.Cells("valor").Value
        '    Next
        'End If

        'If Valor = CDbl(Me.Label5.Text) Then
        '    MsgBox("O total da nota está completo. Não é possível gerar mais nota para o Documento selecionado", 48, TituloMsgbox)
        '    Exit Sub
        'Else
        If CDbl(Me.Label5.Text) <= CDbl(Me.TotalProduto.Text) Then


            My.Forms.Compra.NovoBt_Click(sender, e)
            My.Forms.Compra.controle.Text = Me.Id.Text
            My.Forms.Compra.Serie.Text = "U"

            My.Forms.Compra.CódigoFornecedor.Text = Me.Fornecedor.Text
            My.Forms.Compra.RazãoSocial.Text = Me.FornecedorDesc.Text
            My.Forms.Compra.CódigoFuncionário.Text = VarCodFunc
            My.Forms.Compra.FuncionarioDesc.Text = VarNomFunc
            My.Forms.Compra.LocalizaFornecedor()
            My.Forms.Compra.ShowDialog()
        Else
            MsgBox("O total da nota está completo. Não é possível gerar mais nota para o Documento selecionado", 48, TituloMsgbox)
            Exit Sub
        End If
        'End If
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        If Me.Id.Text = "" Then
            MsgBox("Ainda não foi salvo por favor salve o Gerenciador primeiro", 48, TituloMsgbox)
            Exit Sub
        End If

        Dim valor As Double = 0
        If Me.dgvNF.RowCount > 0 Then
            For Each col As DataGridViewRow In Me.dgvNF.Rows
                valor += col.Cells("valor").Value
            Next
            MsgBox("Já existe NF lançada, você não pode escolher documentos para serem adicionados a este Gerenciador", 48, TituloMsgbox)
            Exit Sub
        End If

        If valor = 0 Then
        Else
            If valor = CDbl(Me.Label5.Text) Then
                MsgBox("O total da nota está completo. Não é possível gerar mais nota para o Documento selecionado", 48, TituloMsgbox)
                Exit Sub
            End If
        End If

        My.Forms.BuscarDocOrdem.ShowDialog()
    End Sub
    Public Sub SumDgview()
        Dim valor As Double = 0
        If Me.DataGridView1.RowCount > 0 Then

            For Each col As DataGridViewRow In Me.DataGridView1.Rows
                valor += col.Cells("cvalor").Value
            Next
        End If

        If valor = 0 Then
        Else
            Me.TotalProduto.Text = FormatCurrency(valor, 2)
            Me.ValorGerenciador.Text = Me.TotalProduto.Text
        End If
    End Sub
    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.Click

        Ação.Desbloquear_Controle(Me, True) 'Define todos os controles com ativados.
        Ação.LimpaTextBox(Me)
        Me.Id.Enabled = False
        Me.Solicitacao.Enabled = False
        'define dados da empresa padrão
        Me.Empresa.Text = CodEmpresa
        Me.Empresa.Enabled = False
        Me.EmpresaDesc.Enabled = False
        Dim AchaEmpresa As New TrfGerais
        AchaEmpresa.Descrição_ItenRegistro(Me.Empresa, Me.EmpresaDesc, "Empresa", "CódigoEmpresa", Me.Empresa.Text, "RazãoSocial", TrfGerais.TipoDados.Numérico, False)
        Me.Fornecedor.Focus()
        Me.DataLancamento.Text = DataDia
        Me.MyLista.Items.Clear()
        Me.LblTipoDoc.Text = ""
        Me.TotalProduto.Text = "0,00"
        Me.Label5.Text = "0,00"
        Me.VlrLancar.Text = "0,00"
        me.totalselecionado.Text="0,00"
        Me.GroupBox3.Enabled = False
        Me.LancaItens.Enabled = False
        Me.nfdevolução.Enabled = False
        Me.Finalizado.Checked = False

        If odts.Tables.Count <> 0 Then
            odts.Tables(0).Clear()
            ' ods.Tables(1).Clear()
            'Me.dgvNF.Refresh()
            'Me.DataGridView1.Refresh()
        End If

        If ods.Tables.Count <> 0 Then
            ods.Tables(0).Clear()
        End If

        salvouReg = False
        Operation = INS
    End Sub

    Private Sub Fornecedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fornecedor.KeyDown
        If e.KeyCode = Keys.F5 Then
            If Me.Empresa.Text = "" Then
                MessageBox.Show("Não foi informado a empresa para procura", TituloMsgbox, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            RetornoProcura = String.Empty
            My.Forms.TelaProcuraForCtrlPedido.ShowDialog()
            Me.Fornecedor.Text = RetornoProcura
            Me.Fornecedor.Focus()
        End If
    End Sub

    Private Sub Fornecedor_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fornecedor.Validated
        If Me.Fornecedor.Text <> "" Then
            If IsNumeric(Me.Fornecedor.Text) = False Then
                MsgBox("Código errado", 48, TituloMsgbox)
                Me.Fornecedor.Text = ""
                Me.Fornecedor.Focus()
                Exit Sub
            End If
        End If
        If ConnectionState.Closed Then
            Exit Sub
        End If

        If Me.Fornecedor.Text = "" Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        CNN.Open()

        Dim Sql As String = "Select * from Fornecedor where CódigoFornecedor = " & Me.Fornecedor.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.FornecedorDesc.Text = DR.Item("RazãoSocial") & ""
            Me.PlanoContasFornecedor.Text = DR.Item("CodPlanoConta") & ""
        Else
            MsgBox("Verifique os dados do fornecedor, ou fornecedor não existe no cadastro.", 64, TituloMsgbox)
            CNN.Close()
            Exit Sub
        End If
        DR.Close()
        CNN.Close()
    End Sub
    Public Sub UltimoReg()
        'Inserir ultimo registro
        Dim CNN As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        CNN.Open()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader
        Dim Ult As Integer

        With Cmd
            .Connection = CNN
            .CommandTimeout = 0
            .CommandText = "Select max(Id) from GerenciadorDoc"
            .CommandType = CommandType.Text
        End With
        Try

            DR = Cmd.ExecuteReader

            While DR.Read
                If Not IsDBNull(DR.Item(0)) Then
                    'Achou o iten procurado o iten as caixas serão preenchida
                    Ult = DR.Item(0)
                End If
            End While
            DR.Close()
            CNN.Close()
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                CNN.Close()
                Exit Sub
            End If
        End Try

        Me.Id.Text = Ult + 1
        'fim inserir ultimo registro

    End Sub
    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        If NzZero(Me.ValorGerenciador.Text) = 0 Then
            MsgBox("Não foi digitado o valor total", 48, TituloMsgbox)
            Me.ValorGerenciador.Focus()
            Exit Sub
        ElseIf Me.Fornecedor.Text = "" Then
            MsgBox("Não foi digitado o codigo do Fornecedor", 48, TituloMsgbox)
            Me.Fornecedor.Focus()
            Exit Sub
        End If
        If Operation = INS Then

            Dim CNN As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
            CNN.Open()



            UltimoReg()                                     '1     '2         '3          '4          '5       '6       '7           8
            Dim Sql As String = "INSERT INTO GerenciadorDoc (Id, Empresa, Fornecedor, DataLancamento, Total, Usuario, TipoPedido, Devolucao) VALUES (@1, @2, @3, @4, @5, @6, @7, @8)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Id.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", NzZero(Me.Empresa.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Fornecedor.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataLancamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.ValorGerenciador.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", UserAtivo))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(sTipo, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Me.nfdevolução.Checked))

            Try
                cmd.ExecuteNonQuery()
                Grava_no_Log(Me, TipoAção.INSERT)
                Ação.CriaLog(UserAtivo, "GerenciarDoc", "Add: ID " & Me.Id.Text & " - Doc Fornecedor: " & Me.Documento.Text, CaminhoLog, DataDia)
                MsgBox("Registro adicionado com sucesso", 64, TituloMsgbox)
                CNN.Close()
                Operation = UPD
                salvouReg = True
            Catch ex As Exception
                MsgBox(ex.Message, 64, TituloMsgbox)
                Ação.LimpaTextBox(Me)
                Ação.Desbloquear_Controle(Me, True)
                Me.Id.Enabled = False
                Me.Id.Text = "0000"
                Operation = INS
                CNN.Close()
            End Try
            Ação.Desbloquear_Controle(Me, False)

        ElseIf Operation = UPD Then

            Dim CNN As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
            CNN.Open()

            Dim Sql As String = "Update GerenciadorDoc set Fornecedor = @3, DataLancamento = @4, Total = @5, Usuario = @6, Devolucao = @7, LancaItens = @8  Where Id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Fornecedor.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataLancamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.ValorGerenciador.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", UserAtivo))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Me.nfdevolução.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Me.LancaItens.Checked))
            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                Grava_no_Log(Me, TipoAção.UPDATE)
                Ação.CriaLog(UserAtivo, "DocumentoEntrada", "Edd: ID " & Me.Id.Text & " - Doc Fornecedor: " & Me.Documento.Text, CaminhoLog, DataDia)

                MsgBox("Registro Atualizado com sucesso", 64, TituloMsgbox)

                Operation = UPD
                salvouReg = True
            Catch x As Exception
                MsgBox(x.Message)
                CNN.Close()
                Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, False)
        End If
    End Sub

    Private Sub Id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Id.TextChanged

    End Sub

    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click

        If Me.Finalizado.Checked = True Then
            MsgBox("Este Gerenciador já foi finalizado, não é possível editá-lo", 48, TituloMsgbox)
            Exit Sub
        End If

        Ação.Desbloquear_Controle(Me, True) 'Define todos os controles com ativados.
        Me.LancaItens.Enabled = False
        Me.nfdevolução.Enabled = False
        Me.Id.Enabled = False
        Me.Solicitacao.Enabled = False
        'define dados da empresa padrão
        Me.Empresa.Text = CodEmpresa
        Me.Empresa.Enabled = False
        Me.EmpresaDesc.Enabled = False
        Me.GroupBox3.Enabled = True
        Operation = UPD
        salvouReg = False
    End Sub

    Private Sub FindGerenciador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindGerenciador.Click
        My.Forms.ProcuraGerenciador.ShowDialog()
        verValorLancado()
        Me.Label5.Text = "0,00"
    End Sub
    Public Sub verValorLancado()
        Dim valor As Double = 0
        If Me.dgvNF.RowCount > 0 Then

            For Each col As DataGridViewRow In Me.dgvNF.Rows
                valor += col.Cells("valor").Value
            Next
            Me.totalselecionado.Text = FormatCurrency(valor, 2)
            Me.VlrLancar.Text = FormatCurrency(CDbl(Me.TotalProduto.Text) - CDbl(Me.totalselecionado.Text), 2)
        Else
            Me.totalselecionado.Text = FormatCurrency(valor, 2)
            Me.VlrLancar.Text = FormatCurrency(CDbl(Me.TotalProduto.Text) - CDbl(Me.totalselecionado.Text), 2)
        End If
    End Sub
    Private Sub ValorGerenciador_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorGerenciador.Leave
        Me.TotalProduto.Text = FormatCurrency(Me.ValorGerenciador.Text, 2)
    End Sub

    Private Sub ValorGerenciador_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValorGerenciador.TextChanged

    End Sub

    Private Sub ButtonX1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ButtonX1.MouseMove
        If Me.Id.Text = "" Then
            Me.ButtonX1.Enabled = False
        Else
            Me.ButtonX1.Enabled = True
        End If
    End Sub

    Private Sub GerenciarOrdem_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove

        Me.ButtonX1.Enabled = True

    End Sub

    Private Sub SeqNf_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeqNf.Validated
        If Me.SeqNf.Text = "" Then
            MsgBox("Sequência da NF não pode ser nulo, Digite uma sequência válida", 48, TituloMsgbox)
            Me.SeqNf.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub DgvItem_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellContentClick

    End Sub
End Class