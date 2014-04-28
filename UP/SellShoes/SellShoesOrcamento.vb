Imports System.Math
Public Class SellShoesOrcamento
    Dim flag As Boolean = False
    Private CalculosOK As Boolean = False
    Public AcharOrc As Double = False
    Public StrOrc As Integer
    Dim VarTemEntrada As Boolean = False

    Dim IT As Integer = 0

    Dim LinhaSelecionada As Integer

    'Variaveis que servem para passar informaçoes
    Dim varCustoMercadoriaVendia As Double = 0

    Public DsItens As New DataSet

    Dim RestaValorGeral As Double

    Dim P_Desc As Double
    Dim P_Acre As Double

    Dim DsTemp As New DataSet
    'Dim bs As New BindingSource
    'Dim DAReceber As OleDb.OleDbDataAdapter

    Dim VarDesconto As Double = 0 'usado para receber o percentual que ira ser descontado na linha
    Dim VarAcrecimo As Double = 0 'usado para receber o percentual que ira ser Acrecentado na linha


    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click

        If Me.OrcSequencia.Text = "000000" And Me.xCodCliente.Text <> "" Then
            If MessageBox.Show("Deseja sair do Orçamento sem salvar", "Validação de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub SellShoesOrcamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        EncheListaTipoPgto()

        If AcharOrc = False Then
            HabilitarItens(False)


            If Len(CaixaAtivo) <> 4 Then
                Me.PainelCredito.Visible = False
            Else
                Me.PainelCredito.Visible = True
                Me.PainelFaturamento.Enabled = True
            End If

            Me.xCodCliente.Focus()

            'Carrega a Tabela para a Memoria
            Dim CN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CN.Open()

            Dim Sql As String = "SELECT 0 AS Linha, OrcITEM.CodigoProduto, Produtos.Descrição, OrcITEM.Numero, OrcITEM.Qtd, OrcITEM.ValorUnitario, OrcITEM.vAcrecimoVenda, OrcITEM.Desconto, OrcITEM.ValorDesconto, OrcITEM.vDescontoEspecial, OrcITEM.TotalProduto, OrcITEM.CustoMercadoriaVendida, OrcITEM.pAcrecimoVenda, OrcITEM.pDescontoEspecial FROM OrcITEM INNER JOIN Produtos ON OrcITEM.CodigoProduto = Produtos.CodigoProduto WHERE (((OrcITEM.OrcSequencia)=-1));"


            Dim CMD As New OleDb.OleDbCommand(Sql, CN)
            Dim DaItem As New OleDb.OleDbDataAdapter(CMD)

            DaItem.Fill(DsItens, "Itens")

            Me.Lista.DataSource = DsItens.Tables("Itens").DefaultView

            CN.Close()

            Me.ConfImg.Visible = False
            Me.ImpressoOrcamento.Text = "N"
            Me.DataOrc.Text = DataDia
            Me.StatusAndamento.Text = "INICIAL"
            Me.btEnviarCaixa.Enabled = True
            Me.btCriarVenda.Enabled = False

        End If

        If AcharOrc = True Then
            Me.PainelCliente.Enabled = False
            Me.PainelItens.Enabled = False
            Me.PainelTotal.Enabled = False
            Me.PainelFaturamento.Enabled = False
            Me.btEnviarCaixa.Enabled = False
            Me.btCriarVenda.Enabled = True
            Me.CodPgto.Enabled = False
            Me.TipoPgto.Enabled = False

            'Desvia para a função e localiza o orçamento
            LocalizarOrc(StrOrc)

            'Dim CN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            'CN.Open()

            'Dim Sql As String = "SELECT 0 AS Linha, OrcITEM.CodigoProduto, Produtos.Descrição, OrcITEM.Numero, OrcITEM.Qtd, OrcITEM.ValorUnitario, OrcITEM.Desconto, OrcITEM.ValorDesconto, OrcITEM.TotalProduto, OrcITEM.CustoMercadoriaVendida FROM OrcITEM INNER JOIN Produtos ON OrcITEM.CodigoProduto = Produtos.CodigoProduto WHERE (((OrcITEM.OrcSequencia)=" & StrOrc & "));"

            'Dim CMD As New OleDb.OleDbCommand(Sql, CN)
            'Dim DaItem As New OleDb.OleDbDataAdapter(CMD)

            'DaItem.Fill(DsItens, "Itens")
            'Me.Lista.DataSource = DsItens.Tables("Itens").DefaultView
            'CN.Close()


            If Len(CaixaAtivo) <> 4 Then
                Me.PainelCredito.Visible = False
            Else
                Me.PainelCredito.Visible = True
            End If

        End If

    End Sub

#Region "Rotinas de Find"

    Public Sub LocalizaCliente(ByVal CodCliente As Integer)

        If CodCliente = 0 Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT Clientes.*, Clientes.Empresa, Municipio.NomeMunic, UF.NomeUF FROM (Clientes LEFT JOIN UF ON Clientes.cUF = UF.CodigoUF) LEFT JOIN Municipio ON Clientes.cMun = Municipio.CodMunicipio WHERE (((Clientes.Empresa)=" & CodEmpresa & ") AND ((Clientes.Codigo)=" & CodCliente & "));"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then

            If DR.Item("Inativo") = True Then
                MessageBox.Show("Este cliente foi Inativado, não é permitido nenhum tipo de venda para ele, verifique com o Administrador", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.xCodCliente.Clear()
                Me.xCodCliente.Focus()
                Exit Sub
            End If

            Me.xCodCliente.Text = DR.Item("Codigo") & ""
            Me.xNome.Text = DR.Item("Nome") & ""
            Me.xCpfCnpj.Text = DR.Item("CpfCgc") & ""
            Me.xEndereco.Text = DR.Item("Endereço") & ""
            Me.xBairro.Text = DR.Item("Bairro") & ""
            Me.xCidadeEstado.Text = DR.Item("Cidade") & "-" & DR.Item("NomeUF")
            Me.xLimiteCredito.Text = FormatNumber(DR.Item("LimiteMensal"), 2)
            Me.VendaVista.Checked = DR.Item("VendaVista")
            Me.VendaCheque.Checked = DR.Item("VendaCheque")
            Me.VendaCrediario.Checked = DR.Item("VendaCrediario")

            If Me.VendaCheque.Checked = False Then
                Me.ValorCheque.Text = FormatNumber(0, 2)
                Me.ValorCheque.Enabled = False
            Else
                Me.ValorCheque.Text = FormatNumber(0, 2)
                Me.ValorCheque.Enabled = False
            End If

            If Me.VendaCrediario.Checked = False Then
                Me.ValorFaturar.Text = FormatNumber(0, 2)
                Me.ValorFaturar.Enabled = False
                Me.FormaPgto.Enabled = False
            Else
                Me.ValorFaturar.Text = FormatNumber(0, 2)
                Me.ValorFaturar.Enabled = True
                Me.FormaPgto.Enabled = True

            End If

            If DR.Item("Bloqueado") = True Then
                flag = True
                MessageBox.Show("Este cliente foi bloqueado, verifique com o Administrador ou venda somente a vista", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.ValorCheque.Text = FormatNumber(0, 2)
                Me.ValorCheque.Enabled = False
                Me.ValorFaturar.Text = FormatNumber(0, 2)
                Me.ValorFaturar.Enabled = False
                Me.FormaPgto.Enabled = False
            Else
                flag = False
            End If

            VerificaLimiteCredito()
            EncheListaContrato()
        Else
            flag = False
            MessageBox.Show("Este cliente não consta no cadastro, verifique...", "Validação de Daados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.xCodCliente.Clear()
            Me.xCodCliente.Focus()
            Exit Sub
        End If
        DR.Close()

    End Sub

    Private Sub VerificaLimiteCredito()
        VerDebitoCliente()
        Me.xLimiteSaldo.Text = FormatNumber(CDbl(NzZero(Me.xLimiteCredito.Text)) - CDbl(NzZero(Me.xLimiteUtilizado.Text)), 2)
    End Sub

    Private Sub LocalizaProdutoCodBarra(ByVal IdProduto As Integer, ByVal IdNumero As String)

        If NzZero(IdProduto) = 0 Then Exit Sub : If IdNumero = "" Then Exit Sub

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT Produtos.*, ProdutoGrade.Numero, ProdutoGrade.QtdEst FROM Produtos INNER JOIN ProdutoGrade ON Produtos.CodigoProduto = ProdutoGrade.Produto WHERE Produtos.CodigoProduto = " & IdProduto & "  AND ProdutoGrade.Numero ='" & IdNumero & "'"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        varCustoMercadoriaVendia = 0

        If DR.HasRows Then
            Me.CodProduto.Text = DR.Item("CodigoProduto") & ""
            Me.Descricao.Text = DR.Item("Descrição") & ""
            Me.Numero.Text = DR.Item("Numero") & ""
            Me.Qtd.Text = FormatNumber(1, 4)

            If VenderEstoqueNegativo = False Then
                If DR.Item("ControlaEstoque") = "SIM" Then
                    If Me.PedidoTipo.Text = "VENDA" Then
                        If CDbl(NzZero(DR.Item("QtdEst"))) < CDbl(NzZero(Me.Qtd.Text)) Then
                            MessageBox.Show(" Este Produto não possui quantidade suficiente para venda, favor verificar", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            CNN.Close()
                            Me.CodBarra.Clear()
                            Me.CodBarra.Focus()
                            Exit Sub
                        End If
                    End If
                End If
            End If

            Me.Unitario.Text = FormatNumber(NzZero(DR.Item("ValorVenda")), 2)
            Me.Desconto.Text = FormatNumber(NzZero(VarDesconto), 2)
            Me.Especial.Text = FormatNumber(NzZero(0), 2)
            Me.itAcrecimo.Text = (NzZero(Me.Unitario.Text * NzZero(Me.Qtd.Text)) * VarAcrecimo) / 100
            Me.ValorDesconto.Text = (NzZero(Me.Unitario.Text * NzZero(Me.Qtd.Text)) * VarDesconto) / 100
            Dim tTotal As Double = (NzZero(Me.Unitario.Text) * NzZero(Me.Qtd.Text)) + NzZero(Me.itAcrecimo.Text) - NzZero(Me.ValorDesconto.Text)
            Me.Total.Text = FormatNumber(tTotal, 2)

            varCustoMercadoriaVendia = FormatNumber(NzZero(DR.Item("ValorCompra")), 2)


            If Var_EnterCodBarra = True Then
                AddItem()
                Me.CodBarra.Clear()
                Me.CodBarra.Focus()
            Else
                Me.Qtd.Enabled = True
                Me.Unitario.Enabled = True
                Me.btSalvarItem.Enabled = True
                DR.Close()
                CNN.Close()
                Me.Qtd.Focus()
            End If

            DR.Close()
            CNN.Close()

        Else
            DR.Close()
            CNN.Close()
            MessageBox.Show("Produto não encontrado, Verifique ou selecione outro", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CodProduto.Clear()
            Me.Descricao.Clear()
            Me.Numero.Clear()
            Me.Qtd.Clear()
            Me.Unitario.Clear()
            Me.Desconto.Clear()
            Me.ValorDesconto.Clear()
            Me.Total.Clear()
            Me.CodBarra.Clear()
            Me.CodBarra.Focus()
        End If
    End Sub

    Private Sub LocalizaProdutoCodBarraSemNumeros(ByVal IdProduto As Integer)

        If NzZero(IdProduto) = 0 Then Exit Sub

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT Produtos.* FROM Produtos WHERE Produtos.Inativo=False And Produtos.CodigoBarra = '" & IdProduto & "'"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        varCustoMercadoriaVendia = 0

        Dim AchouItem As Boolean = False
        If DR.HasRows Then
            AchouItem = True
            Me.CodProduto.Text = DR.Item("CodigoProduto") & ""
            Me.Descricao.Text = DR.Item("Descrição") & ""
            Me.Numero.Text = 0
            Me.Qtd.Text = FormatNumber(1, 4)

            If VenderEstoqueNegativo = False Then
                If DR.Item("ControlaEstoque") = "SIM" Then
                    If Me.PedidoTipo.Text = "VENDA" Then
                        If CDbl(NzZero(DR.Item("QuantidadeEstoque"))) < CDbl(NzZero(Me.Qtd.Text)) Then
                            MessageBox.Show(" Este Produto não possui quantidade suficiente para venda, favor verificar", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            CNN.Close()
                            Me.CodBarra.Clear()
                            Me.CodBarra.Focus()
                            Exit Sub
                        End If
                    End If
                End If
            End If

            Me.Unitario.Text = FormatNumber(NzZero(DR.Item("ValorVenda")), 2)
            Me.Desconto.Text = FormatNumber(NzZero(VarDesconto), 2)
            Me.Especial.Text = FormatNumber(NzZero(0), 2)
            Me.itAcrecimo.Text = (NzZero(Me.Unitario.Text * NzZero(Me.Qtd.Text)) * VarAcrecimo) / 100
            Me.ValorDesconto.Text = (NzZero(Me.Unitario.Text * NzZero(Me.Qtd.Text)) * VarDesconto) / 100
            Dim tTotal As Double = (NzZero(Me.Unitario.Text) * NzZero(Me.Qtd.Text)) + NzZero(Me.itAcrecimo.Text) - NzZero(Me.ValorDesconto.Text)
            Me.Total.Text = FormatNumber(tTotal, 2)

            varCustoMercadoriaVendia = FormatNumber(NzZero(DR.Item("ValorCompra")), 2)

            If Var_EnterCodBarra = True Then
                AddItem()
            Else
                Me.Qtd.Enabled = True
                Me.Unitario.Enabled = True
                Me.btSalvarItem.Enabled = True
                DR.Close()
                CNN.Close()

                If AchouItem = True Then
                    Me.Qtd.Focus()
                End If

            End If

            DR.Close()
            CNN.Close()

        Else
            DR.Close()
            CNN.Close()
            MessageBox.Show("Produto não encontrado, Verifique ou selecione outro", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CodProduto.Clear()
            Me.Descricao.Clear()
            Me.Numero.Clear()
            Me.Qtd.Clear()
            Me.Unitario.Clear()
            Me.Desconto.Clear()
            Me.ValorDesconto.Clear()
            Me.Total.Clear()
            Me.CodBarra.Clear()
            Me.CodBarra.Focus()
        End If
    End Sub

#End Region

    Private Sub HabilitarItens(ByVal SimNao As Boolean)
        Me.CodProduto.Enabled = SimNao
        Me.Descricao.Enabled = SimNao
        Me.Numero.Enabled = SimNao
        Me.Qtd.Enabled = SimNao
        Me.Unitario.Enabled = SimNao
        Me.Desconto.Enabled = SimNao
        Me.ValorDesconto.Enabled = SimNao
        Me.Total.Enabled = SimNao
        Me.btSalvarItem.Enabled = SimNao
        Me.btImprimir.Enabled = SimNao
    End Sub

    Private Sub btFindCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindCliente.Click
        My.Forms.ClientesProcura.ShowDialog()

        If String.CompareOrdinal(Me.xCodCliente.Text, Me.xCodCliente.TextLength) Then
            If Me.xCodCliente.Text = "" Then Exit Sub
            LocalizaCliente(Me.xCodCliente.Text)
        End If
    End Sub

    Private Sub xCodCliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles xCodCliente.KeyDown

        If e.KeyCode = Keys.F5 Then
            My.Forms.ClientesProcura.ShowDialog()

            If String.CompareOrdinal(Me.xCodCliente.Text, Me.xCodCliente.TextLength) Then
                If Me.xCodCliente.Text = "" Then Exit Sub
                LocalizaCliente(Me.xCodCliente.Text)
            End If
        End If
    End Sub

    Private Sub xCodCliente_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xCodCliente.Validating
        Try
            If AcharOrc = False Then
                If Me.xCodCliente.Text = "" Then Exit Sub
                LocalizaCliente(Me.xCodCliente.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SellShoesSellShoesOrcamento_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F3 Then
            If Me.xCodCliente.Text = "" Then
                MessageBox.Show("Primeiro o usuário deve definir o Cliente, para lançar os Produtos", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.xCodCliente.Focus()
                Exit Sub
            End If
            HabilitarItens(False)
            Me.CodBarra.Enabled = True
            Me.CodBarra.Focus()
        End If

        If e.KeyCode = Keys.F2 Then
            If Me.xCodCliente.Text = "" Then
                MessageBox.Show("Primeiro o usuário deve definir o Cliente, para lançar os Produtos", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.xCodCliente.Focus()
                Exit Sub
            End If
            HabilitarItens(True)
            Me.CodBarra.Enabled = False
            Me.CodProduto.Focus()
        End If

        If e.KeyCode = Keys.F7 Then
            ButtonX1_Click(sender, e)
        End If


        Dim isControlPressed As Boolean = (Control.ModifierKeys And Keys.Control) <> 0
        If isControlPressed = True Then
            If Me.Lista.RowCount > 0 Then
                If e.KeyCode = Keys.D Then
                    e.Handled = True

                    Dim frmDesconto As New SellShoesDescontoGerenciaOrcamento
                    frmDesconto.Individual = False
                    frmDesconto.ShowDialog()
                    Me.TotalOrc.Focus()
                End If
            End If
        End If


    End Sub

    Private Sub CodBarra_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodBarra.Enter
        If Me.xCodCliente.Text = "" Then
            Me.xCodCliente.Focus()
            Exit Sub
        Else
            Me.CodProduto.Clear()
            Me.Descricao.Clear()
            Me.Numero.Clear()
            Me.Qtd.Clear()
            Me.Unitario.Clear()
            Me.itAcrecimo.Clear()
            Me.ValorDesconto.Clear()
            Me.Especial.Clear()
            Me.Total.Clear()
        End If
    End Sub

    Private Sub AddItem()

        If Me.CodProduto.Text = "" Then
            Me.CodBarra.Focus()
            Exit Sub

        End If


        Dim DrFindProduto() As DataRow
        DrFindProduto = DsItens.Tables("Itens").Select("CodigoProduto = '" & Me.CodProduto.Text & "'")

        If DrFindProduto.Length = 0 Then

            Dim TBL As DataTable
            TBL = DsItens.Tables("Itens")

            Dim DRnovo As DataRow
            DRnovo = TBL.NewRow()
            IT += 1
            DRnovo("Linha") = IT
            DRnovo("CodigoProduto") = Me.CodProduto.Text
            DRnovo("Descrição") = Me.Descricao.Text
            DRnovo("Numero") = Me.Numero.Text
            DRnovo("Qtd") = FormatNumber(Me.Qtd.Text, 2)
            DRnovo("ValorUnitario") = FormatNumber(Me.Unitario.Text, 2)

            DRnovo("vAcrecimoVenda") = FormatNumber(Me.itAcrecimo.Text, 2)
            DRnovo("vDescontoEspecial") = FormatNumber(Me.Especial.Text, 2)

            DRnovo("Desconto") = FormatNumber(Me.Desconto.Text, 2)
            DRnovo("ValorDesconto") = FormatNumber(Me.ValorDesconto.Text, 2)
            DRnovo("TotalProduto") = FormatNumber(Me.Total.Text, 2)
            DRnovo("CustoMercadoriaVendida") = FormatNumber(varCustoMercadoriaVendia, 2)
            TBL.Rows.Add(DRnovo)
        Else

            DrFindProduto(0).BeginEdit()
            DrFindProduto(0)("Qtd") += NzZero(Me.Qtd.Text)
            DrFindProduto(0)("ValorUnitario") = FormatNumber(Me.Unitario.Text, 2)
            DrFindProduto(0)("vAcrecimoVenda") = FormatNumber(((CDbl(NzZero(DrFindProduto(0)("Qtd"))) * CDbl(NzZero(DrFindProduto(0)("ValorUnitario")))) * VarAcrecimo) / 100, 2)
            DrFindProduto(0)("ValorDesconto") = FormatNumber(((CDbl(NzZero(DrFindProduto(0)("Qtd"))) * CDbl(NzZero(DrFindProduto(0)("ValorUnitario")))) * VarDesconto) / 100, 2)
            DrFindProduto(0)("TotalProduto") = FormatNumber(CDbl(NzZero(DrFindProduto(0)("Qtd"))) * CDbl(NzZero(DrFindProduto(0)("ValorUnitario"))), 2)

            DrFindProduto(0)("Desconto") = FormatNumber(NzZero(VarDesconto), 2)
            DrFindProduto(0)("pAcrecimoVenda") = FormatNumber(NzZero(VarAcrecimo), 2)
            DrFindProduto(0)("pDescontoEspecial") = FormatNumber(0, 2)
            DrFindProduto(0)("vDescontoEspecial") = FormatNumber(0, 2)

            DrFindProduto(0).EndEdit()
        End If


        Me.Acrecimo.Text = FormatNumber(NzZero(DsItens.Tables("Itens").Compute("sum(vAcrecimoVenda)", "")), 2)
        'Dim DescEspecial As Double = NzZero(DsItens.Tables("Itens").Compute("sum(vDescontoEspecial)", ""))
        'Dim DescNormal As Double = NzZero(DsItens.Tables("Itens").Compute("sum(ValorDesconto)", ""))
        'Me.TotalDesconto.Text = FormatNumber(NzZero(DescNormal) + NzZero(DescEspecial), 2)
        'Me.ValorProduto.Text = FormatNumber(NzZero(DsItens.Tables("Itens").Compute("sum(TotalProduto)", "")), 2)




        Me.ValorProduto.Text = SomaColuna("cTotalProduto")
        Me.Acrecimo.Text = SomaColuna("cAcrecimo")

        Dim DescEspecial As Double = SomaColuna("cEspecial")
        Dim DescNormal As Double = SomaColuna("cValorDesconto")
        Me.TotalDesconto.Text = FormatNumber(NzZero(DescNormal) + NzZero(DescEspecial), 2)

        Me.TotalOrc.Text = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.Acrecimo.Text)) - CDbl(NzZero(Me.TotalDesconto.Text)), 2)

        Me.Lista.Refresh()



        'Limpa Caixas para um novo Item
        Me.CodProduto.Clear()
        Me.Descricao.Clear()
        Me.Numero.Clear()
        Me.Qtd.Clear()
        Me.Unitario.Clear()
        Me.Desconto.Clear()
        Me.ValorDesconto.Clear()
        Me.Total.Clear()
        Me.CodBarra.Clear()
        Me.CodBarra.Focus()

        'Fim

    End Sub

    Public Function SomaColuna(ByVal Coluna As String)
        Dim vlr As Decimal

        For Each col As DataGridViewRow In Me.Lista.Rows
            vlr += col.Cells(Coluna).Value
        Next
        Return FormatNumber(NzZero(vlr), 2)
    End Function

    Private Sub btSalvarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvarItem.Click
        AddItem()
    End Sub

    Private Sub CodBarra_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CodBarra.Leave

        If Me.CodBarra.Text = "" Then
            If Me.Lista.RowCount > 0 Then
                Me.TotalDesconto.Focus()
            End If
        End If
        Try
            If UsarGrade = True Then
                Dim VarCod As String = Me.CodBarra.Text
                Dim VarCodSplit() As String

                If VarCod.IndexOf("-") = -1 Then
                    MessageBox.Show("Não existe indexador de numero para este codigo de Produto, ação sera cancelada.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.CodBarra.Clear()
                    Me.CodBarra.Focus()
                    Exit Sub
                End If

                VarCodSplit = VarCod.Split("-")

                LocalizaProdutoCodBarra(VarCodSplit(0), VarCodSplit(1))
            Else
                LocalizaProdutoCodBarraSemNumeros(CInt(Me.CodBarra.Text))
            End If

        Catch ex As Exception
            Select Case Err.Number
                Case 13
                    MsgBox("Erro de conversão, era esperado o código do produto", MsgBoxStyle.Critical, "Erro")

            End Select
            Me.CodBarra.Clear()
            Me.CodBarra.Focus()
        End Try

    End Sub

    Private Sub CodProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodProduto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.CodProduto.Text = "" Then
                If Me.Lista.RowCount > 0 Then
                    HabilitarItens(False)
                    Me.DescPercentual.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub DescPercentual_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DescPercentual.Enter
        If NzZero(Me.ValorProduto.Text) = 0 Then
            MessageBox.Show("O Total do Orçamento não pode ser [00,00], para informar desconto", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CodBarra.Focus()
            Exit Sub
        End If
        If Me.DescPercentual.Text = "" Then
            Me.DescPercentual.Text = FormatNumber(0, 4)
        End If
    End Sub


    Private Sub ValorVista_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValorVista.Enter
        'Verificação dos Calculos do total da venda
        Me.TotalOrc.Text = FormatNumber(NzZero(Me.ValorProduto.Text) - NzZero(Me.TotalDesconto.Text), 2)

        If NzZero(Me.TotalOrc.Text) = 0 Then
            MessageBox.Show("Não existe valor para Orçamento, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            'If NzZero(Me.ValorVista.Text) = 0 Then
            Me.ValorVista.Text = FormatNumber(NzZero(Me.TotalOrc.Text) - NzZero(Me.ValorCheque.Text) - NzZero(Me.ValorFaturar.Text), 2)
            'End If
        End If
    End Sub

    Private Sub ValorCheque_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorCheque.Enter
        If NzZero(Me.TotalOrc.Text) = 0 Then
            MessageBox.Show("Não existe valor para Orçamento, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.ValorCheque.Text = FormatNumber(NzZero(Me.TotalOrc.Text) - NzZero(Me.ValorVista.Text) - NzZero(Me.ValorFaturar.Text), 2)

    End Sub

    Private Sub ValorFaturar_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorFaturar.Enter
        If NzZero(Me.TotalOrc.Text) = 0 Then
            MessageBox.Show("Não existe valor para Orçamento, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Me.ValorFaturar.Text = FormatNumber(NzZero(Me.TotalOrc.Text) - NzZero(Me.ValorCheque.Text) - NzZero(Me.ValorVista.Text), 2)
        If Me.VendaCrediario.Checked = False And NzZero(Me.ValorFaturar.Text) > 0 Then
            MessageBox.Show("Este Cliente não tem permissão para fazer Orçamento no crediário, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ValorFaturar.Text = FormatNumber(0, 2)
            Me.ValorVista.Focus()
        End If

        If Me.xNome.Text <> "CONSUMIDOR" Then
            If Me.VendaCrediario.Checked = True And NzZero(Me.ValorFaturar.Text) > CDbl(NzZero(Me.xLimiteSaldo.Text)) Then
                MessageBox.Show("Este Cliente não tem Saldo suficiente para o Orçamento no crediário, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.ValorFaturar.Text = FormatNumber(0, 2)
                Me.ValorVista.Focus()
            End If
        End If

        If Me.ValorVista.Enabled = True And Me.ValorVista.Text = 0 Then
            MessageBox.Show("A Forma de Pagamento selecionada necessita de um valor de Entrada, Verifique...", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.ValorVista.Focus()
            Exit Sub
        End If

    End Sub

    Private Sub ValorFaturar_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorFaturar.Leave

        Dim ConferirValores As Double = FormatNumber(CDbl(NzZero(Me.ValorVista.Text)) + CDbl(NzZero(Me.ValorCheque.Text)) + CDbl(NzZero(Me.ValorFaturar.Text)), 2)

        If NzZero(ConferirValores) <> NzZero(Me.TotalOrc.Text) Then
            MessageBox.Show("Os Valores indicado estão diferente do Valor do Orçamento, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ValorVista.Focus()
            Exit Sub
        End If

        If NzZero(Me.ValorFaturar.Text) = 0 Then
            Me.FormaPgto.Enabled = False
        Else
            Me.FormaPgto.Enabled = True
        End If


        If NzZero(Me.ValorFaturar.Text) <> 0 Then

            If Me.TipoPgto.Text = "" Then
                MessageBox.Show("Para o Orçamento o usuário deve selecionar um tipo de pagamento.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.TipoPgto.Focus()
                Exit Sub
            End If

            If Me.CodPgto.Text = "" Then
                MessageBox.Show("Para o Orçamento o usuário deve selecionar a condição de pagamento.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.CodPgto.Focus()
                Exit Sub
            End If

        End If

    End Sub


    Private Sub CarregaLocalPgto()

        Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "SELECT * FROM(LocalPagamento) WHERE (((LocalPagamento.Empresa)=" & CodEmpresa & ") AND ((LocalPagamento.LocalPgto)<>'CHEQUE PRE-DATADO'));"
        Dim daLocalPgto As OleDb.OleDbDataAdapter

        daLocalPgto = New OleDb.OleDbDataAdapter(Sql, Cnn)
        daLocalPgto.Fill(DsTemp, "LocalPgto")

        Cnn.Close()

    End Sub

    Private Sub DescValor_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If NzZero(Me.ValorProduto.Text) = 0 Then
            MessageBox.Show("O Total do Orçamento não pode ser [00,00], para informar desconto", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CodBarra.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub btEnviarCaixa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnviarCaixa.Click

        'Validaçoes de dados
        If CalculosOK = False Then
            MessageBox.Show("O usuario deve passar por todos os campos de calculo", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.TipoPgto.Focus()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        If Me.xCodCliente.Text = "" Then
            MessageBox.Show("Não foi informado o cliente para o Orçamento.", "Validação de Orçamento", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btEnviarCaixa.Enabled = True
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        If Me.PedidoTipo.Text = "" Then
            MessageBox.Show("Não foi informado o Tipo do Orçamento.", "Validação de Orçamento", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btEnviarCaixa.Enabled = True
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        If Me.Vendedor.Text = "" Then
            MessageBox.Show("Não foi informado o vendedor para o Orçamento.", "Validação de Orçamento", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btEnviarCaixa.Enabled = True
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        Me.TotalOrc.Text = FormatNumber(NzZero(Me.ValorProduto.Text) - NzZero(Me.TotalDesconto.Text), 2)
        If CDbl(NzZero(Me.TotalOrc.Text)) = 0 Then
            MessageBox.Show("Não pode finalizar um Orçamento com valor [0,00].", "Validação de Orçamento", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btEnviarCaixa.Enabled = True
            Me.Cursor = Cursors.Default
            Exit Sub
        End If



        Dim vAVISTA As Double = NzZero(Me.ValorVista.Text)
        Dim vCHEQUE As Double = NzZero(Me.ValorCheque.Text)
        Dim vCREDIA As Double = NzZero(Me.ValorFaturar.Text)
        Dim vTotal As Double = FormatNumber(vAVISTA + vCHEQUE + vCREDIA, 2)

        If CDbl(NzZero(vTotal)) <> CDbl(NzZero(Me.TotalOrc.Text)) Then
            MessageBox.Show("O total dos pagamentos estão diferente do Total do Orçamento, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ValorVista.Focus()
            Me.btEnviarCaixa.Enabled = True
            Me.Cursor = Cursors.Default
            Exit Sub
        End If


        If Me.CodPgto.Text = "" Then
            MessageBox.Show("O usuário deve selecionar uma Condição de Pagamento.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CodPgto.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        'Fim das Validaçoes


        'Salvar o Registro Principal
        Me.btEnviarCaixa.Enabled = False

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
        Dim Cmd As OleDb.OleDbCommand = CNN.CreateCommand
        Dim CmdUlt As OleDb.OleDbCommand = CNN.CreateCommand

        Cmd.Transaction = Transacao
        CmdUlt.Transaction = Transacao


        Dim Num As New Random
        Dim Tempo As Integer = 0

        Tempo = Num.Next(1, 7000)
        System.Threading.Thread.Sleep(Tempo)
        Try
            Dim Sql As String = String.Empty

            If Me.OrcSequencia.Text = "000000" Then
                'Rotina para Buscar o ultimo Registro
                CmdUlt.CommandText = "Select max(OrcSequencia) + 1 from Orc"
                Dim UltimoReg As Integer = NzZero(CmdUlt.ExecuteScalar)
                If NzZero(UltimoReg) = 0 Then UltimoReg = 1
                Me.OrcSequencia.Text = UltimoReg.ToString.PadLeft(6, "0")
                'Rotina para Buscar o ultimo Registro Termina aqui

                Sql = "INSERT INTO Orc (OrcSequencia, CódigoFuncionário, CódigoCliente, DataOrc, PercDesconto, VlrDescProduto, ValorProduto, TotalOrc, ValorAVista, ValorOutros, ValorAFaturar, Empresa, FormaPgto, DiasParcelamento, TipoPgto, CodPgto, SenhaGerencia, Contrato, Acrecimo,OrcOperador, ImpressoOrcamento, EnderecoEntrega) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19,@20, @21,@22)"
                Cmd.CommandText = Sql

                Cmd.Parameters.Add(New OleDb.OleDbParameter("@1", CInt(NzZero(Me.OrcSequencia.Text))))
                Dim Func() As String = CType(Me.Vendedor.Text, String).Split("-")
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Func(0)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.xCodCliente.Text, 1)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataOrc.Text, 1)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", NzZero(Me.DescPercentual.Text)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", NzZero(Me.TotalDesconto.Text)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", NzZero(Me.ValorProduto.Text)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", NzZero(Me.TotalOrc.Text)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzZero(Me.ValorVista.Text)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", NzZero(Me.ValorCheque.Text)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", NzZero(Me.ValorFaturar.Text)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@12", CodEmpresa))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.FormaPgto.Text, 1)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.DiasParcelamento.Text, 1)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Me.TipoPgto.SelectedValue))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Me.CodPgto.SelectedValue))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.SenhaGerencia.Text, 1)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Me.Contrato.SelectedValue & ""))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@19", Nz(Me.Acrecimo.Text, 1)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@20", Nz(Me.lblOperador.Text, 1)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@21", Nz(Me.ImpressoOrcamento.Text, 1)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@22", Nz(Me.EnderecoEntrega.Text, 1)))


                Me.StatusAndamento.Text = ""

                Cmd.ExecuteNonQuery()
                Transacao.Commit()
                CNN.Close()
                Me.btCriarVenda.Enabled = True
                Me.btImprimir.Enabled = True
                Me.btImprimir.Focus()


            Else
                Sql = "Update Orc set CódigoCliente = @1, DataOrc = @2, PercDesconto = @3, VlrDescProduto = @4, ValorProduto = @5, TotalOrc = @6, ValorAVista = @7, ValorOutros = @8, ValorAFaturar = @9, Empresa = @10, FormaPgto = @11, DiasParcelamento = @12, TipoPgto = @13, CodPgto = @14, SenhaGerencia = @15, Contrato = @16, Acrecimo = @17, ImpressoOrcamento = @18, EnderecoEntrega=@19 Where Orc.OrcSequencia = " & Me.OrcSequencia.Text
                ', OrcOperador = @20

                Cmd.CommandText = Sql

                Cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.xCodCliente.Text, 1)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataOrc.Text, 1)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", NzZero(Me.DescPercentual.Text)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", NzZero(Me.TotalDesconto.Text)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", NzZero(Me.ValorProduto.Text)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", NzZero(Me.TotalOrc.Text)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", NzZero(Me.ValorVista.Text)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", NzZero(Me.ValorCheque.Text)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzZero(Me.ValorFaturar.Text)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.FormaPgto.Text, 1)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.DiasParcelamento.Text, 1)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Me.TipoPgto.SelectedValue))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Me.CodPgto.SelectedValue))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.SenhaGerencia.Text, 1)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Me.Contrato.SelectedValue & ""))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.Acrecimo.Text, 1)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Nz(Me.ImpressoOrcamento.Text, 1)))
                Cmd.Parameters.Add(New OleDb.OleDbParameter("@19", Nz(Me.EnderecoEntrega.Text, 1)))

                Me.StatusAndamento.Text = ""

                Cmd.ExecuteNonQuery()
                Transacao.Commit()
                CNN.Close()
                Me.btCriarVenda.Enabled = True
                Me.btImprimir.Enabled = True
                Me.btImprimir.Focus()

            End If

        Catch ex As Exception
            Transacao.Rollback()
            CNN.Close()
            MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btEnviarCaixa.Enabled = True
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        'Dados do cabeçalho Ok começa a Salvar os itens

        CNN.Open()
        Dim DsIT As New DataSet


        Dim SqlItem As String = "Select * From OrcITEM  Where OrcSequencia = " & CInt(Me.OrcSequencia.Text)

        Dim DaIT As New OleDb.OleDbDataAdapter(SqlItem, CNN)
        DaIT.Fill(DsIT, "ItensVenda")

        Dim DrLinha As DataRow

        Try

            For Each DrLinha In DsItens.Tables("Itens").Rows

                Dim LinhaFind() As DataRow
                LinhaFind = DsIT.Tables("ItensVenda").Select("CodigoProduto = " & DrLinha("CodigoProduto").ToString)

                If LinhaFind.Length = 0 Then
                    Dim TBL As DataTable
                    TBL = DsIT.Tables("ItensVenda")

                    Dim DRnovo As DataRow
                    DRnovo = TBL.NewRow()

                    DRnovo("OrcSequencia") = Nz(Me.OrcSequencia.Text, 1)
                    DRnovo("CodigoProduto") = Nz(DrLinha("CodigoProduto").ToString, 1)
                    DRnovo("Numero") = Nz(DrLinha("Numero").ToString, 1)
                    DRnovo("Multiplos") = 0
                    DRnovo("Qtd") = Nz(DrLinha("Qtd").ToString, 1)
                    DRnovo("ValorUnitario") = Nz(DrLinha("ValorUnitario").ToString, 1)
                    DRnovo("Desconto") = Nz(DrLinha("Desconto").ToString, 1)
                    DRnovo("ValorDesconto") = Nz(DrLinha("ValorDesconto").ToString, 1)
                    DRnovo("CustoMercadoriaVendida") = Nz(DrLinha("CustoMercadoriaVendida").ToString, 1)
                    DRnovo("TotalProduto") = Nz(DrLinha("TotalProduto").ToString, 1)
                    DRnovo("QtdPc") = 0
                    DRnovo("UserSenhaDesconto") = System.DBNull.Value
                    DRnovo("pAcrecimoVenda") = Nz(DrLinha("pAcrecimoVenda").ToString, 1)
                    DRnovo("vAcrecimoVenda") = Nz(DrLinha("vAcrecimoVenda").ToString, 1)
                    DRnovo("pDescontoEspecial") = Nz(DrLinha("pDescontoEspecial").ToString, 1)
                    DRnovo("vDescontoEspecial") = Nz(DrLinha("vDescontoEspecial").ToString, 1)

                    TBL.Rows.Add(DRnovo)
                Else
                    LinhaFind(0).BeginEdit()
                    LinhaFind(0)("OrcSequencia") = Nz(Me.OrcSequencia.Text, 1)
                    LinhaFind(0)("CodigoProduto") = Nz(DrLinha("CodigoProduto").ToString, 1)
                    LinhaFind(0)("Numero") = Nz(DrLinha("Numero").ToString, 1)
                    LinhaFind(0)("Multiplos") = 0
                    LinhaFind(0)("Qtd") = Nz(DrLinha("Qtd").ToString, 1)
                    LinhaFind(0)("ValorUnitario") = Nz(DrLinha("ValorUnitario").ToString, 1)
                    LinhaFind(0)("Desconto") = Nz(DrLinha("Desconto").ToString, 1)
                    LinhaFind(0)("ValorDesconto") = Nz(DrLinha("ValorDesconto").ToString, 1)
                    LinhaFind(0)("CustoMercadoriaVendida") = Nz(DrLinha("CustoMercadoriaVendida").ToString, 1)
                    LinhaFind(0)("TotalProduto") = Nz(DrLinha("TotalProduto").ToString, 1)
                    LinhaFind(0)("QtdPc") = 0
                    LinhaFind(0)("UserSenhaDesconto") = System.DBNull.Value
                    LinhaFind(0)("pAcrecimoVenda") = Nz(DrLinha("pAcrecimoVenda").ToString, 1)
                    LinhaFind(0)("vAcrecimoVenda") = Nz(DrLinha("vAcrecimoVenda").ToString, 1)
                    LinhaFind(0)("pDescontoEspecial") = Nz(DrLinha("pDescontoEspecial").ToString, 1)
                    LinhaFind(0)("vDescontoEspecial") = Nz(DrLinha("vDescontoEspecial").ToString, 1)


                    LinhaFind(0).EndEdit()

                End If
            Next

            Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DaIT)
            DaIT.Update(DsIT, "ItensVenda")

            CNN.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btEnviarCaixa.Enabled = True
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try


        MessageBox.Show("Orçamento efetuado com sucesso.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Cursor = Cursors.Default
        Me.CodBarra.Enabled = False
        Me.btSalvarItem.Enabled = False
        Me.xCodCliente.Enabled = False

        'Me.Close()
        'Me.Dispose()

    End Sub


    Private Sub LocalizarOrc(ByVal CodOrc As String)

        Dim dsV As New DataSet

        Dim CN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CN.Open()

        Dim Sql As String = String.Empty

        Sql = "SELECT Orc.*, Clientes.*, Municipio.NomeMunic, UF.NomeUF, Funcionários.Nome, FormaPgto.Descrição FROM ((Orc INNER JOIN ((Clientes LEFT JOIN UF ON Clientes.cUF = UF.CodigoUF) LEFT JOIN Municipio ON Clientes.cMun = Municipio.CodMunicipio) ON Orc.CódigoCliente = Clientes.Codigo) INNER JOIN Funcionários ON Orc.CódigoFuncionário = Funcionários.CódigoFuncionário) LEFT JOIN FormaPgto ON Orc.FormaPgto = FormaPgto.CodFormaPgto WHERE (((Orc.OrcSequencia)=" & CodOrc & ") AND ((Orc.Inativo)=False) AND ((Orc.Empresa)=" & CodEmpresa & "));"
        Dim DaVenda As New OleDb.OleDbDataAdapter(Sql, CN)

        'Sql = "SELECT 0 AS Linha, OrcITEM.CodigoProduto, Produtos.Descrição, OrcITEM.numero, OrcITEM.Qtd, OrcITEM.ValorUnitario, OrcITEM.vAcrecimoVenda, OrcITEM.Desconto, OrcITEM.ValorDesconto, OrcITEM.vDescontoEspecial, OrcITEM.TotalProduto, OrcITEM.CustoMercadoriaVendida FROM OrcITEM INNER JOIN Produtos ON OrcITEM.CodigoProduto = Produtos.CodigoProduto WHERE (((OrcITEM.OrcSequencia)=" & CodOrc & "));"
        Sql = "SELECT 0 AS Linha, OrcITEM.CodigoProduto, Produtos.Descrição, OrcITEM.Numero, OrcITEM.Qtd, OrcITEM.ValorUnitario, OrcITEM.vAcrecimoVenda, OrcITEM.Desconto, OrcITEM.ValorDesconto, OrcITEM.vDescontoEspecial, OrcITEM.TotalProduto, OrcITEM.CustoMercadoriaVendida, OrcITEM.pAcrecimoVenda, OrcITEM.pDescontoEspecial FROM OrcITEM INNER JOIN Produtos ON OrcITEM.CodigoProduto = Produtos.CodigoProduto WHERE (((OrcITEM.OrcSequencia)=" & CodOrc & "));"
        ', OrcITEM.vDescontoEspecial, OrcITEM.pAcrecimoVenda, OrcITEM.pDescontoEspecial

        Dim DaItem As New OleDb.OleDbDataAdapter(Sql, CN)

        DaVenda.Fill(dsV, "Orc")
        DaItem.Fill(DsItens, "Itens")


        If dsV.Tables("Orc").Rows.Count > 0 Then
            Me.OrcSequencia.Text = dsV.Tables("Orc").Rows(0)("OrcSequencia").ToString
            Me.xCodCliente.Text = dsV.Tables("Orc").Rows(0)("Codigo").ToString
            Me.xNome.Text = dsV.Tables("Orc").Rows(0)("Clientes.Nome").ToString
            Me.xCpfCnpj.Text = dsV.Tables("Orc").Rows(0)("CpfCgc").ToString
            Me.xEndereco.Text = dsV.Tables("Orc").Rows(0)("Endereço").ToString
            Me.xBairro.Text = dsV.Tables("Orc").Rows(0)("Bairro").ToString
            Me.xCidadeEstado.Text = dsV.Tables("Orc").Rows(0)("Cidade").ToString & "-" & dsV.Tables("Orc").Rows(0)("NomeUF").ToString
            Me.xLimiteCredito.Text = FormatNumber(NzZero(dsV.Tables("Orc").Rows(0)("LimiteMensal").ToString), 2)
            Me.VendaVista.Checked = dsV.Tables("Orc").Rows(0)("VendaVista").ToString
            Me.VendaCheque.Checked = dsV.Tables("Orc").Rows(0)("VendaCheque").ToString
            Me.VendaCrediario.Checked = dsV.Tables("Orc").Rows(0)("VendaCrediario").ToString
            Me.DataOrc.Text = dsV.Tables("Orc").Rows(0)("DataOrc").ToString
            Me.Vendedor.Text = dsV.Tables("Orc").Rows(0)("CódigoFuncionário").ToString & "-" & dsV.Tables("Orc").Rows(0)("Funcionários.Nome").ToString
            Me.DescPercentual.Text = NzZero(dsV.Tables("Orc").Rows(0)("PercDesconto").ToString)
            Me.TotalDesconto.Text = FormatNumber(NzZero(dsV.Tables("Orc").Rows(0)("VlrDescProduto").ToString), 2)
            Me.Acrecimo.Text = FormatNumber(NzZero(dsV.Tables("Orc").Rows(0)("Acrecimo").ToString), 2)
            Me.ValorProduto.Text = FormatNumber(NzZero(dsV.Tables("Orc").Rows(0)("ValorProduto").ToString), 2)
            Me.TotalOrc.Text = FormatNumber(NzZero(dsV.Tables("Orc").Rows(0)("TotalOrc").ToString), 2)
            Me.ValorVista.Text = FormatNumber(NzZero(dsV.Tables("Orc").Rows(0)("ValorAVista").ToString), 2)
            Me.ValorCheque.Text = FormatNumber(NzZero(dsV.Tables("Orc").Rows(0)("ValorOutros").ToString), 2)
            Me.ValorFaturar.Text = FormatNumber(NzZero(dsV.Tables("Orc").Rows(0)("ValorAFaturar").ToString), 2)
            Me.FormaPgto.Text = dsV.Tables("Orc").Rows(0)("FormaPgto").ToString
            Me.DiasParcelamento.Text = dsV.Tables("Orc").Rows(0)("DiasParcelamento").ToString
            Me.Confirmado.Checked = dsV.Tables("Orc").Rows(0)("Confirmado").ToString
            Me.ImpressoOrcamento.Text = dsV.Tables("Orc").Rows(0)("ImpressoOrcamento").ToString
            Me.EnderecoEntrega.Text = dsV.Tables("Orc").Rows(0)("EnderecoEntrega").ToString

            Me.TipoPgto.SelectedValue = dsV.Tables("Orc").Rows(0)("TipoPgto").ToString
            EncheCodPgto()
            Me.CodPgto.SelectedValue = dsV.Tables("Orc").Rows(0)("CodPgto").ToString


            'Me.PainelFaturamento.Enabled = False
        End If

        Me.Lista.DataSource = DsItens.Tables("Itens")


        CarregaLocalPgto()

        'Fim do Carregamento do recebimento

        If Me.Confirmado.Checked = True Then
            Me.ConfImg.Visible = True
            Me.btEnviarCaixa.Enabled = False
            Me.btCriarVenda.Enabled = False
            MessageBox.Show("Esta Orçamento ja foi confirmado e não pode mais ser Alterado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.ConfImg.Visible = False
            Me.btEnviarCaixa.Enabled = False
            Me.btCriarVenda.Enabled = True
        End If

        VerificaLimiteCredito()
        EncheListaContrato()
        Me.Contrato.SelectedValue = dsV.Tables("Orc").Rows(0)("Contrato").ToString & ""

        CN.Close()

    End Sub

    Private Sub FormaPgto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FormaPgto.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ProcuraFormaPgto.ShowDialog()
        End If
    End Sub

    Private Sub AchaFormaPgto()
        If Me.FormaPgto.Text = "" Then
            VarTemEntrada = False
            Exit Sub
        Else

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "Select * from FormaPgto Where CodFormaPgto = " & Me.FormaPgto.Text
            Dim Cmd As New OleDb.OleDbCommand(Sql, CNN)
            Dim DR As OleDb.OleDbDataReader

            Try
                DR = Cmd.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    Me.DiasParcelamento.Text = DR.Item("DiasParcelamento") & ""
                    If DR.Item("TemEntrada") = True Then
                        VarTemEntrada = True
                    Else
                        VarTemEntrada = False
                    End If
                Else
                    Me.DiasParcelamento.Text = ""
                    VarTemEntrada = False
                End If
                DR.Close()
                CNN.Close()

            Catch Merror As System.Exception
                MsgBox(Merror.ToString)
            End Try
        End If
    End Sub

    Private Sub FormaPgto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormaPgto.Leave
        If String.CompareOrdinal(Me.FormaPgto.Text, Me.FormaPgto.TextoAntigo) Then
            AchaFormaPgto()
        End If
    End Sub


    Private Sub Lista_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellClick
        LinhaSelecionada = e.RowIndex

        If e.ColumnIndex = Me.btExcluirItem.Index AndAlso e.RowIndex >= 0 Then
           
            If LinhaSelecionada < 0 Then Exit Sub

            If Me.ImpressoOrcamento.Text = "S" Then
                MessageBox.Show("Este pedido ja foi Impresso e não pode mais ser alterado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If MessageBox.Show("Deseja Excluir o item selecionado", "Validação de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
                CNN.Open()

                Dim DsIT As New DataSet

                Dim SqlItem As String = "Select * From OrcITEM  Where OrcSequencia = " & CInt(Me.OrcSequencia.Text)
                Dim DaIT As New OleDb.OleDbDataAdapter(SqlItem, CNN)
                DaIT.Fill(DsIT, "ItensVenda")

                Dim RowExc() As DataRow
                RowExc = DsIT.Tables("ItensVenda").Select("CodigoProduto = " & Me.Lista.CurrentRow.Cells("cCodigoProduto").Value)
                If RowExc.Length > 0 Then
                    RowExc(0).Delete()
                    Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DaIT)
                    DaIT.Update(DsIT, "ItensVenda")
                End If


                DsItens.Tables("Itens").Rows(LinhaSelecionada).Delete()
                DsItens.Tables("Itens").AcceptChanges()


                'Me.Acrecimo.Text = FormatNumber(NzZero(DsItens.Tables("Itens").Compute("sum(vAcrecimoVenda)", "")), 2)
                'Dim DescEspecial As Double = NzZero(DsItens.Tables("Itens").Compute("sum(vDescontoEspecial)", ""))
                'Dim DescNormal As Double = NzZero(DsItens.Tables("Itens").Compute("sum(ValorDesconto)", ""))
                'Me.TotalDesconto.Text = FormatNumber(NzZero(DescNormal) + NzZero(DescEspecial), 2)

                'Me.ValorProduto.Text = FormatNumber(NzZero(DsItens.Tables("Itens").Compute("sum(TotalProduto)", "")), 2)
                ' Me.TotalOrc.Text = FormatNumber(NzZero(Me.ValorProduto.Text) - NzZero(Me.TotalDesconto.Text) + NzZero(Me.Acrecimo.Text), 2)



                Me.ValorProduto.Text = SomaColuna("cTotalProduto")
                Me.Acrecimo.Text = SomaColuna("cAcrecimo")

                Dim DescEspecial As Double = SomaColuna("cEspecial")
                Dim DescNormal As Double = SomaColuna("cValorDesconto")
                Me.TotalDesconto.Text = FormatNumber(NzZero(DescNormal) + NzZero(DescEspecial), 2)

                Me.TotalOrc.Text = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.Acrecimo.Text)) - CDbl(NzZero(Me.TotalDesconto.Text)), 2)


                Me.ValorCheque.Text = FormatNumber(0, 2)
                Me.ValorFaturar.Text = FormatNumber(0, 2)
                Me.ValorVista.Text = FormatNumber(0, 2)
                Me.CodBarra.Focus()
                Me.Lista.Refresh()
                LinhaSelecionada = -1

                CNN.Close()
            End If
        End If



        LinhaSelecionada = e.RowIndex


        If e.ColumnIndex = Me.cBtDescontoEspecial.Index AndAlso e.RowIndex >= 0 Then
            Dim frmDesconto As New SellShoesDescontoGerenciaOrcamento
            frmDesconto.Individual = True
            frmDesconto.idITEM = LinhaSelecionada
            frmDesconto.ShowDialog()

            Me.ValorProduto.Text = FormatNumber(NzZero(DsItens.Tables("Itens").Compute("sum(TotalProduto)", "")), 2)
            Me.Acrecimo.Text = FormatNumber(NzZero(DsItens.Tables("Itens").Compute("sum(vAcrecimoVenda)", "")), 2)

            Dim DescEspecial As Double = NzZero(DsItens.Tables("Itens").Compute("sum(vDescontoEspecial)", ""))
            Dim DescNormal As Double = NzZero(DsItens.Tables("Itens").Compute("sum(ValorDesconto)", ""))
            Me.TotalDesconto.Text = FormatNumber(NzZero(DescNormal) + NzZero(DescEspecial), 2)

            Me.TotalOrc.Text = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.Acrecimo.Text)) - CDbl(NzZero(Me.TotalDesconto.Text)), 2)

            Me.Lista.Refresh()
            Me.TotalOrc.Focus()
        End If




    End Sub

    Private Sub SalvarDadosPedidoCaixa()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Update Pedido  Set ValorAVista = @1, ValorOutros = @2, ValorAFaturar = @3, DiasParcelamento = @4, FormaPgto = @5 Where Pedido.PedidoSequencia = " & Me.OrcSequencia.Text
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", NzZero(Me.ValorVista.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", NzZero(Me.ValorCheque.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@3", NzZero(Me.ValorFaturar.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@4", NzZero(Me.DiasParcelamento.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@5", NzZero(Me.FormaPgto.Text)))

        Try
            cmd.ExecuteNonQuery()
            CNN.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try

    End Sub

    Private Sub VerDebitoCliente()
        If Me.xCodCliente.Text = "" Then
            Exit Sub
        End If

        Dim CnnFind As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CnnFind.Open()

        Dim Sql As String = "SELECT Receber.CodCliente AS Cliente, Sum(Receber.ValorDocumento) AS Total FROM Receber WHERE (((Receber.Recebimento) Is Null) AND ((Receber.Baixado)=False) AND ((Receber.Empresa)=" & CodEmpresa & ")) GROUP BY Receber.CodCliente HAVING (((Receber.CodCliente)=" & Me.xCodCliente.Text & ")); UNION SELECT ArquivoCheque.Cliente, Sum(ArquivoCheque.ValorCh) AS Total FROM ArquivoCheque WHERE (((ArquivoCheque.DataBaixa) Is Null) AND ((ArquivoCheque.Empresa)=" & CodEmpresa & ")) GROUP BY ArquivoCheque.Cliente HAVING (((ArquivoCheque.Cliente)=" & Me.xCodCliente.Text & "));"
        Dim CMD As New OleDb.OleDbCommand(Sql, CnnFind)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        Dim VlrDebito As Double = 0

        While DR.Read
            VlrDebito += NzZero(DR.Item("Total"))
        End While

        Me.xLimiteUtilizado.Text = FormatNumber(NzZero(VlrDebito), 2)

        DR.Close()
        CnnFind.Close()
    End Sub

    Private Sub EncheListaTipoPgto()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        'Sql = "Select TipoPgto.CodigoTipoPgto, TipoPgto.DescricaoTipoPgto From TipoPgto order by TipoPgto.DescricaoTipoPgto"

        If Me.Contrato.Text = "" Then
            Sql = "Select TipoPgto.CodigoTipoPgto, TipoPgto.DescricaoTipoPgto From TipoPgto Where TipoPgto.SomenteContrato = False order by TipoPgto.DescricaoTipoPgto"
        Else
            Sql = "Select TipoPgto.CodigoTipoPgto, TipoPgto.DescricaoTipoPgto From TipoPgto Where TipoPgto.SomenteContrato = True order by TipoPgto.DescricaoTipoPgto"
        End If


        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.TipoPgto.DataSource = ds.Tables("Table").DefaultView
        Me.TipoPgto.DisplayMember = "DescricaoTipoPgto"
        Me.TipoPgto.ValueMember = "CodigoTipoPgto"
        Me.TipoPgto.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub EncheCodPgto()

        If Me.TipoPgto.Text = "" Then
            Me.TipoPgto.Focus()
            Exit Sub
        End If

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT AnexarForma.Fp_Codigo, [Fp_Codigo] & ' - ' & '(' & [Descrição] & ')' AS [Desc] FROM AnexarForma INNER JOIN FormaPgto ON AnexarForma.Fp_Codigo = FormaPgto.CodFormaPgto WHERE (((AnexarForma.Tp_Codigo)=" & Me.TipoPgto.SelectedValue & "));"


        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.CodPgto.DataSource = ds.Tables("Table").DefaultView
        Me.CodPgto.DisplayMember = "Desc"
        Me.CodPgto.ValueMember = "Fp_Codigo"
        Me.CodPgto.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

    End Sub

    Public Sub EncheListaContrato()


        If Me.xCodCliente.Text = 0 Then
            Exit Sub
        End If


        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = "SELECT Contratos.Cliente, Contratos.Finalizado, * FROM(Contratos) WHERE (((Contratos.Cliente)=" & Me.xCodCliente.Text & ") AND ((Contratos.Finalizado)='N'));"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Contrato.DataSource = ds.Tables("Table").DefaultView
        Me.Contrato.DisplayMember = "CodContrato"
        Me.Contrato.ValueMember = "CodContrato"
        Me.Contrato.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

        If Me.Contrato.Items.Count > 0 Then
            Me.LabelContrato.Visible = True
            Me.Contrato.Visible = True
            Me.Contrato.Focus()
        Else
            Me.LabelContrato.Visible = False
            Me.Contrato.Visible = False
            Me.ContaCR.Text = VAR_ContaCrVenda
        End If


    End Sub

    Private Sub CodPgto_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodPgto.Enter
        CalculosOK = False
        Me.DescPercentual.Clear()
        Me.Desconto.Clear()
        Me.Acrecimo.Clear()
        EncheCodPgto()
    End Sub

    Private Sub AchaCodPgtoSelecionado()

        Me.TotalDesconto.Text = FormatNumber(0, 2)
        Me.Acrecimo.Text = FormatNumber(0, 2)

        If Me.CodPgto.Text = "" Then Exit Sub

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = String.Empty
        'Sql = "SELECT AnexarForma.Tp_Codigo, AnexarForma.Fp_Codigo, AnexarForma.Desconto, AnexarForma.Acrescimo FROM(AnexarForma) WHERE (((AnexarForma.Tp_Codigo)=" & Me.TipoPgto.SelectedValue & ") AND ((AnexarForma.Fp_Codigo)= " & Me.CodPgto.SelectedValue & "));"
        Sql = "SELECT AnexarForma.Tp_Codigo, AnexarForma.Fp_Codigo, FormaPgto.Descrição, FormaPgto.TemEntrada, AnexarForma.Desconto, AnexarForma.Acrescimo FROM AnexarForma INNER JOIN FormaPgto ON AnexarForma.Fp_Codigo = FormaPgto.CodFormaPgto WHERE (((AnexarForma.Tp_Codigo)=" & Me.TipoPgto.SelectedValue & ") AND ((AnexarForma.Fp_Codigo)=" & Me.CodPgto.SelectedValue & "));"
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()


        If DR.HasRows Then

            VarDesconto = NzZero(DR.Item("Desconto"))
            VarAcrecimo = NzZero(DR.Item("Acrescimo"))

            'If CDbl(VarDesconto) > 0 Then
            '    'Me.DescPercentual.Text = VarDesconto
            '    'Me.TotalDesconto.Text = FormatNumber((CDbl(NzZero(Me.ValorProduto.Text)) * CDbl(NzZero(Me.DescPercentual.Text)) / 100), 2)
            '    'Me.Acrecimo.Text = FormatNumber(0, 2)
            'Else
            '    'Me.DescPercentual.Text = 0
            '    'Me.TotalDesconto.Text = FormatNumber(0, 2)
            '    'Me.Acrecimo.Text = FormatNumber(0, 2)
            'End If

            'If CDbl(VarAcrecimo) > 0 Then
            '    Me.DescPercentual.Text = 0
            '    Me.Acrecimo.Text = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)) * CDbl(NzZero(VarAcrecimo)) / 100, 2)
            '    Me.TotalDesconto.Text = FormatNumber(0, 2)
            'Else
            '    Me.Acrecimo.Text = FormatNumber(0, 2)
            'End If


            If DR.Item("TemEntrada") = False Then
                Me.ValorVista.Text = FormatNumber(0, 2)
                Me.ValorVista.Enabled = False
            Else
                Me.ValorVista.Enabled = True
            End If

            If DR.Item("Descrição") = "A VISTA" Then
                Me.ValorFaturar.Text = FormatNumber(0, 2)
                Me.ValorFaturar.Enabled = False
            Else
                Me.ValorFaturar.Enabled = True
            End If

            'If Me.PedidoTipo.Text = "DEVOLUÇÃO" And Me.Contrato.Text <> "" Then
            '    Me.ValorVista.Enabled = True
            '    Me.ValorCheque.Enabled = False
            '    Me.ValorFaturar.Text = FormatNumber(0, 2)
            '    Me.ValorFaturar.Enabled = False
            'End If

            'P_Acre = DR.Item("Acrescimo")
        End If


        Cnn.Close()

    End Sub



    Private Sub TotalDesconto_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TotalDesconto.Validating
        Me.TotalOrc.Text = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.Acrecimo.Text)) - CDbl(NzZero(Me.TotalDesconto.Text)), 2)
        If Me.PedidoTipo.Text = "DEVOLUÇÃO" Then Me.TotalOrc.Text = NzZero(Me.TotalOrc.Text) * -1
    End Sub

    Private Sub TotalPedido_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TotalOrc.Validating


        If CDbl(NzZero(Me.TotalOrc.Text)) < 0 Then
            MessageBox.Show("O valor para o Orçamento não pode ser negativo", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.TotalOrc.Clear()
            Me.CodPgto.Focus()
            Exit Sub
        End If

        Dim Var_TPedido As Double = FormatNumber(CDbl(NzZero(Me.TotalOrc.Text)))
        Dim Var_VlrDesconto As Double = FormatNumber(CDbl(NzZero(Me.TotalDesconto.Text)))
        Dim Var_VlrDiferenca As Double = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.Acrecimo.Text)) - CDbl(NzZero(Me.TotalOrc.Text)))
        Var_VlrDiferenca -= Var_VlrDesconto


        Me.TotalDesconto.Text = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.Acrecimo.Text)) - CDbl(NzZero(Me.TotalOrc.Text)))

        Me.TotalOrc.Text = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)) - CDbl(NzZero(Me.TotalDesconto.Text)), 2)

        Me.DescPercentual.Text = FormatNumber(CDbl(NzZero(Me.TotalDesconto.Text)) / CDbl(NzZero(Me.ValorProduto.Text)) / 100, 4)

        CalculosOK = True

    End Sub

    Private Sub Contrato_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Contrato.Leave
        If Me.Contrato.Text = "" Then Exit Sub

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = "SELECT Contratos.CodContrato, Contratos.ContaCR FROM Contratos WHERE Contratos.CodContrato = '" & Me.Contrato.SelectedValue & "'"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        If ds.Tables("Table").Rows.Count > 0 Then
            Me.ContaCR.Text = ds.Tables("Table").Rows(0)("ContaCr")
        End If

        ds.Dispose()
        Cnn.Close()

        EncheListaTipoPgto()

    End Sub

    Private Sub CodBarra_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodBarra.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.CodBarra.Text.Length = 0 Then
                Me.TotalDesconto.Focus()
            End If
        End If

        If e.KeyCode = Keys.F5 Then
            If Me.CodBarra.Text.Length = 0 Then
                If UsarGrade = True Then
                    My.Forms.SellShoesProdutoProcura.ShowDialog()
                Else
                    My.Forms.ProcuraProduto.ShowDialog()
                    CodBarra_Leave(sender, e)
                End If
            End If
        End If

    End Sub

    Private Sub Qtd_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qtd.Leave

        If Me.Qtd.Text = "" Then FormatNumber(0, 2)

        If NzZero(Me.Qtd.Text) <= 0 Then
            MessageBox.Show("O valor  do item não pode ser negativo ou zero", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Qtd.Text = 1
            Me.Qtd.Focus()
            Exit Sub
        End If

        If Me.Qtd.Text > 0 Then
            Me.ValorDesconto.Text = (NzZero(Me.Unitario.Text * NzZero(Me.Qtd.Text)) * VarDesconto) / 100
            Me.itAcrecimo.Text = (NzZero(Me.Unitario.Text * NzZero(Me.Qtd.Text)) * VarAcrecimo) / 100

            Dim tTotal As Double = (NzZero(Me.Unitario.Text) * NzZero(Me.Qtd.Text))
            Me.Total.Text = FormatNumber(tTotal, 2)

        End If
    End Sub

    Dim VlrUnitarioTemp As Double
    Private Sub Unitario_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Unitario.Enter
        VlrUnitarioTemp = NzZero(Me.Unitario.Text)
    End Sub

    Private Sub Unitario_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Unitario.Leave
        If CDbl(NzZero(Me.Unitario.Text)) < CDbl(NzZero(VlrUnitarioTemp)) Then
            MessageBox.Show("O valor do produto não pode ser menor que o valor do cadastro.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Unitario.Text = VlrUnitarioTemp
            Exit Sub
        End If

        If Me.Qtd.Text = "" Then FormatNumber(0, 2)
        If Me.Qtd.Text > 0 Then
            Me.Total.Text = FormatNumber(NzZero(Me.Unitario.Text) * NzZero(Me.Qtd.Text), 2)
        End If
    End Sub


    Private Sub Qtd_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Qtd.KeyDown
        Dim isControlPressed As Boolean = (Control.ModifierKeys And Keys.Control) <> 0
        If isControlPressed = True Then
            If e.KeyCode = Keys.Insert Then
                Me.Unitario.Enabled = True
                Me.Unitario.Focus()
            End If
        End If
    End Sub

    Private Sub Qtd_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qtd.Enter
        Me.Unitario.Enabled = False
    End Sub

    Private Sub btCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCheque.Click

        If Me.VendaCheque.Checked = False Then
            Me.ValorCheque.Text = FormatNumber(0, 2)
            Me.ValorCheque.Enabled = False
            MessageBox.Show("Este Cliente não pode usar esta modalidade de pagamento", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Me.ValorCheque.Text = FormatNumber(0, 2)
            Me.ValorCheque.Enabled = True
            Me.ValorCheque.Focus()
        End If

    End Sub

    Private Sub btCriarVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCriarVenda.Click
        If Me.OrcSequencia.Text = "0000" Then Exit Sub

        LocalizaCliente(Me.xCodCliente.Text)
        'se flag for verdadeiro aborta a rotina
        If flag Then Exit Sub



        Dim DiasOrcamento As Integer = DateDiff(DateInterval.Day, CDate(Me.DataOrc.Text), CDate(DataDia))


        If DiasOrcamento > 10 Then
            MessageBox.Show("Orçamento com mais de 10 dia, favor refazer o orçamento.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        My.Forms.SellShoes.OrcNumber = Me.OrcSequencia.Text
        My.Forms.SellShoes.ImportsOrc = True
        My.Forms.SellShoes.ShowDialog()

        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub btImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImprimir.Click

        Try
            Dim Conect As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
            Conect.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)

            Conect.SQL = "SELECT Empresa.RazãoSocial, Empresa.Endereço AS EnderecoEmpresa, Empresa.Numero, Empresa.Telefone AS FoneEmpresa, Empresa.Cidade AS CidadeEmpresa, Empresa.Estado AS EstadoEmpresa, Empresa.Cep, Funcionários.Nome AS NomeFuncionario, Funcionários.Telefone AS FoneFuncionario, Orc.OrcSequencia, Orc.Contrato, Orc.DataOrc, Orc.ValorProduto AS OrcValorProdutos, Orc.VlrDescProduto AS OrcVlrDescProduto, Orc.TotalOrc, Clientes.Nome, Clientes.Endereço, Clientes.Nro, Clientes.Cidade, Clientes.Bairro, Clientes.Estado, Clientes.Telefone, Clientes.Celular,Clientes.Codigo, OrcITEM.CodigoProduto, Produtos.Descrição AS ProdutoDescricao, Produtos.UnidadeMedida, OrcITEM.Qtd, OrcITEM.ValorUnitario, OrcITEM.ValorDesconto, OrcITEM.TotalProduto, Orc.FormaPgto, FormaPgto.Descrição, Orc.TipoPgto, TipoPgto.DescricaoTipoPgto FROM TipoPgto INNER JOIN ((((Clientes INNER JOIN (Empresa INNER JOIN (Orc INNER JOIN OrcITEM ON Orc.OrcSequencia = OrcITEM.OrcSequencia) ON Empresa.CódigoEmpresa = Orc.Empresa) ON Clientes.Codigo = Orc.CódigoCliente) INNER JOIN Funcionários ON Orc.CódigoFuncionário = Funcionários.CódigoFuncionário) INNER JOIN Produtos ON OrcITEM.CodigoProduto = Produtos.CodigoProduto) INNER JOIN FormaPgto ON Orc.FormaPgto = FormaPgto.CodFormaPgto) ON TipoPgto.CodigoTipoPgto = Orc.TipoPgto WHERE(((Orc.OrcSequencia) = " & Me.OrcSequencia.Text & ")) ORDER BY OrcITEM.Id;"

            Dim Rel As New RelOrcamentoSellShoes
            Rel.DataSource = Conect

            My.Forms.ViewReport.VerRelat.Document = Rel.Document
            My.Forms.ViewReport.VerRelat.Document.Name = "RelOrcamentoSellShoes"
            Rel.Run()
            My.Forms.ViewReport.ShowDialog()



            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "Update Orc set ImpressoOrcamento = 'S' Where  Orc.OrcSequencia = " & Me.OrcSequencia.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.ExecuteNonQuery()
            CNN.Close()

            Me.Close()
            Me.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btEnviarCaixa.Enabled = True
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

    End Sub

    Private Sub xCodCliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles xCodCliente.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(OnlyNumber(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TipoPgto_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoPgto.Enter
        Me.CodPgto.Text = Nothing
        Me.DescPercentual.Clear()
        Me.ValorDesconto.Clear()
        Me.Acrecimo.Clear()

        Me.ValorCheque.Text = FormatNumber(0, 2)
        Me.ValorFaturar.Text = FormatNumber(0, 2)
        Me.ValorVista.Text = FormatNumber(0, 2)
    End Sub

    Private Sub btEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEditar.Click

        If Me.ImpressoOrcamento.Text = "S" Then
            MessageBox.Show("Orçamento ja foi impresso e não pode ser mais alterado favor cria outro, o forms do Orçamento sera fechado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Me.Dispose()
        End If

        Dim DiasOrcamento As Integer = DateDiff(DateInterval.Day, CDate(Me.DataOrc.Text), CDate(DataDia))
        If DiasOrcamento > 10 Then
            MessageBox.Show("Orçamento com mais de 10 dia, favor refazer o orçamento.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.PainelCliente.Enabled = True
        Me.PainelItens.Enabled = True
        Me.PainelTotal.Enabled = True
        Me.PainelFaturamento.Enabled = True
        Me.btEnviarCaixa.Enabled = True
        Me.btCriarVenda.Enabled = True
        Me.CodPgto.Enabled = True
        Me.TipoPgto.Enabled = True
        Me.CodBarra.Enabled = True

        Me.TipoPgto.Focus()

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        My.Forms.SellShoesEnderecoEntrega.ShowDialog()
    End Sub

    Private Sub CodPgto_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodPgto.Validated
        AchaCodPgtoSelecionado()
        Me.FormaPgto.Text = Me.CodPgto.SelectedValue
        AchaFormaPgto()


        'Refaz os valores na lista de Produto caso o usuario altera o plano de recebimento
        If DsItens.Tables("Itens").Rows.Count > 0 Then
            Dim drlinha As DataRow
            For Each drlinha In DsItens.Tables("Itens").Rows


                'MsgBox(drlinha("vAcrecimoVenda"))

                drlinha.BeginEdit()
                drlinha("vAcrecimoVenda") = FormatNumber(((CDbl(NzZero(drlinha("Qtd"))) * CDbl(NzZero(drlinha("ValorUnitario")))) * VarAcrecimo) / 100, 2)
                drlinha("ValorDesconto") = FormatNumber(((CDbl(NzZero(drlinha("Qtd"))) * CDbl(NzZero(drlinha("ValorUnitario")))) * VarDesconto) / 100, 2)
                drlinha("TotalProduto") = FormatNumber(CDbl(NzZero(drlinha("Qtd"))) * CDbl(NzZero(drlinha("ValorUnitario"))), 2)

                drlinha("Desconto") = NzZero(VarDesconto)
                drlinha("pAcrecimoVenda") = NzZero(VarAcrecimo)
                drlinha("pDescontoEspecial") = 0
                drlinha("vDescontoEspecial") = 0
                drlinha.EndEdit()

            Next

            Me.ValorProduto.Text = FormatNumber(NzZero(DsItens.Tables("Itens").Compute("sum(TotalProduto)", "")), 2)
            Me.Acrecimo.Text = FormatNumber(NzZero(DsItens.Tables("Itens").Compute("sum(vAcrecimoVenda)", "")), 2)

            Dim DescEspecial As Double = NzZero(DsItens.Tables("Itens").Compute("sum(vDescontoEspecial)", ""))
            Dim DescNormal As Double = NzZero(DsItens.Tables("Itens").Compute("sum(ValorDesconto)", ""))
            Me.TotalDesconto.Text = FormatNumber(NzZero(DescNormal) + NzZero(DescEspecial), 2)

            Me.TotalOrc.Text = FormatNumber(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.Acrecimo.Text)) - CDbl(NzZero(Me.TotalDesconto.Text)), 2)
            Me.Lista.Refresh()

        End If
        'fim
    End Sub

    Private Sub Unitario_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Unitario.Validated
        If CDbl(NzZero(Me.Unitario.Text)) < CDbl(NzZero(VlrUnitarioTemp)) Then
            MessageBox.Show("O valor do produto não pode ser menor que o valor do cadastro.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Unitario.Text = VlrUnitarioTemp
            Exit Sub
        End If

        If Me.Qtd.Text = "" Then FormatNumber(0, 2)
        If Me.Qtd.Text > 0 Then

            Me.ValorDesconto.Text = (NzZero(Me.Unitario.Text * NzZero(Me.Qtd.Text)) * VarDesconto) / 100
            Me.itAcrecimo.Text = (NzZero(Me.Unitario.Text * NzZero(Me.Qtd.Text)) * VarAcrecimo) / 100

            Dim tTotal As Double = (NzZero(Me.Unitario.Text) * NzZero(Me.Qtd.Text))
            Me.Total.Text = FormatNumber(tTotal, 2)
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.xCodCliente.Text = "" Then
            Me.xCodCliente.Focus()
            Me.Timer1.Enabled = False
        End If
    End Sub
End Class