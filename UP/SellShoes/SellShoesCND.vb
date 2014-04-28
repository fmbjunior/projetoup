Public Class SellShoesCND

    Public AcharCND As Double = False
    Public StrVenda As Integer
    Dim VarTemEntrada As Boolean = False

    Dim IT As Integer = 0

    Dim LinhaSelecionada As Integer

    'Variaveis que servem para passar informaçoes

    Dim DsItens As New DataSet

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub SellShoesCND_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If AcharCND = False Then
            HabilitarItens(False)

            Me.CodCliente.Focus()

            'Carrega a Tabela para a Memoria
            Dim CN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CN.Open()

            Dim Sql As String = "SELECT PedidoCNDitens.PedidoCND, PedidoCNDitens.Produto, PedidoCNDitens.Numero, Produtos.Descrição, PedidoCNDitens.Qtd, PedidoCNDitens.Unitario, PedidoCNDitens.TotalProduto, PedidoCNDitens.Vendido FROM Produtos INNER JOIN PedidoCNDitens ON Produtos.CodigoProduto = PedidoCNDitens.PedidoCND WHERE (((PedidoCNDitens.PedidoCND)=-1));"


            Dim CMD As New OleDb.OleDbCommand(Sql, CN)
            Dim DaItem As New OleDb.OleDbDataAdapter(CMD)

            DaItem.Fill(DsItens, "Itens")

            Me.Lista.DataSource = DsItens.Tables("Itens").DefaultView

            CN.Close()

            Me.ConfImg.Visible = False
            Me.DataCND.Text = DataDia
            Me.Status.Text = "INICIAL"
            Me.btEnviarCaixa.Enabled = True
            Me.btConcluirCnd.Enabled = False

        End If


        If AcharCND = True Then
            Me.PainelCliente.Enabled = False
            Me.PainelItens.Enabled = False
            Me.PainelTotal.Enabled = False
            Me.btEnviarCaixa.Enabled = False
            Me.btConcluirCnd.Enabled = True

            LocalizarVenda(StrVenda)

        End If

    End Sub

    Private Sub ItensDevolução()

        Dim TBL As DataTable
        TBL = DsItens.Tables("Itens")

        For Each Linha As DataGridViewRow In My.Forms.SellShoesDevolucao.ListaItens.Rows
            If Linha.Cells("Selecionado").Value = True Then
                Dim DRnovo As DataRow
                DRnovo = TBL.NewRow()
                IT += 1
                DRnovo("Linha") = IT
                DRnovo("CodigoProduto") = Linha.Cells("cCodigoProduto").Value
                DRnovo("Descrição") = Linha.Cells("cDescrição").Value
                DRnovo("Numero") = Linha.Cells("cNumero").Value
                DRnovo("Qtd") = Linha.Cells("cQtd").Value
                DRnovo("ValorUnitario") = Linha.Cells("cValorUnitario").Value
                DRnovo("Desconto") = Linha.Cells("cDesconto").Value
                DRnovo("ValorDesconto") = Linha.Cells("cValorDesconto").Value
                DRnovo("TotalProduto") = Linha.Cells("cTotalProduto").Value
                DRnovo("CustoMercadoriaVendida") = CDbl(Linha.Cells("cCustoMercadoriaVendida").Value) * -1
                DRnovo("DevolvidoId") = CDbl(Linha.Cells("cId").Value)
                TBL.Rows.Add(DRnovo)
            End If

        Next

        Me.TotalCND.Text = FormatNumber(NzZero(DsItens.Tables("Itens").Compute("sum(TotalProduto)", "")), 2)
        Me.Lista.Refresh()
        Me.CodBarra.Enabled = False

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
                Me.CodCliente.Clear()
                Me.CodCliente.Focus()
                Exit Sub
            End If

            Me.CodCliente.Text = DR.Item("Codigo") & ""
            Me.xNome.Text = DR.Item("Nome") & ""
            Me.xCpfCnpj.Text = DR.Item("CpfCgc") & ""
            Me.xEndereco.Text = DR.Item("Endereço") & ""
            Me.xBairro.Text = DR.Item("Bairro") & ""
            Me.xCidadeEstado.Text = DR.Item("Cidade") & "-" & DR.Item("NomeUF")


            If DR.Item("Bloqueado") = True Then
                MessageBox.Show("Este cliente foi bloqueado, verifique com o Administrador ou venda somente a vista", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            MessageBox.Show("Este cliente não consta no cadastro, verifique...", "Validação de Daados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CodCliente.Clear()
            Me.CodCliente.Focus()
            Exit Sub
        End If
        DR.Close()

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


        If DR.HasRows Then
            Me.CodProduto.Text = DR.Item("CodigoProduto") & ""
            Me.Descricao.Text = DR.Item("Descrição") & ""
            Me.Numero.Text = DR.Item("Numero") & ""
            Me.Qtd.Text = FormatNumber(1, 4)

            Me.Unitario.Text = FormatNumber(NzZero(DR.Item("ValorVenda")), 2)
            Me.Desconto.Text = FormatNumber(0, 2)
            Me.ValorDesconto.Text = FormatNumber(0, 2)
            Me.Total.Text = NzZero(Me.Unitario.Text) * NzZero(Me.Qtd.Text)
            AddItem()
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
    End Sub

    Private Sub btFindCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindCliente.Click
        My.Forms.ClientesProcura.ShowDialog()

        If String.CompareOrdinal(Me.CodCliente.Text, Me.CodCliente.TextLength) Then
            If Me.CodCliente.Text = "" Then Exit Sub
            LocalizaCliente(Me.CodCliente.Text)
        End If
    End Sub

    Private Sub xCodCliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodCliente.KeyDown

        If e.KeyCode = Keys.F5 Then
            My.Forms.ClientesProcura.ShowDialog()

            If String.CompareOrdinal(Me.CodCliente.Text, Me.CodCliente.TextLength) Then
                If Me.CodCliente.Text = "" Then Exit Sub
                LocalizaCliente(Me.CodCliente.Text)
            End If
        End If
    End Sub

    Private Sub CodCliente_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CodCliente.Validating
        Try
            If AcharCND = False Then
                If Me.CodCliente.Text = "" Then Exit Sub
                LocalizaCliente(Me.CodCliente.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub SellShoes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F3 Then
            If Me.CodCliente.Text = "" Then
                MessageBox.Show("Primeiro o usuário deve definir o Cliente, para lançar os Produtos", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.CodCliente.Focus()
                Exit Sub
            End If
            HabilitarItens(False)
            Me.CodBarra.Enabled = True
            Me.CodBarra.Focus()
        End If

        If e.KeyCode = Keys.F2 Then
            If Me.CodCliente.Text = "" Then
                MessageBox.Show("Primeiro o usuário deve definir o Cliente, para lançar os Produtos", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.CodCliente.Focus()
                Exit Sub
            End If
            HabilitarItens(True)
            Me.CodBarra.Enabled = False
            Me.CodProduto.Focus()
        End If
    End Sub

    Private Sub CodBarra_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodBarra.Enter
        If Me.CodCliente.Text = "" Then
            Me.CodCliente.Focus()
            Exit Sub
        End If
        HabilitarItens(False)
    End Sub

    Private Sub AddItem()

        Dim TBL As DataTable
        TBL = DsItens.Tables("Itens")

        Dim DRnovo As DataRow
        DRnovo = TBL.NewRow()
        IT += 1
        DRnovo("Linha") = IT
        DRnovo("CodigoProduto") = Me.CodProduto.Text
        DRnovo("Descrição") = Me.Descricao.Text
        DRnovo("Numero") = Me.Numero.Text
        DRnovo("Qtd") = Me.Qtd.Text
        DRnovo("ValorUnitario") = Me.Unitario.Text
        DRnovo("Desconto") = Me.Desconto.Text
        DRnovo("ValorDesconto") = Me.ValorDesconto.Text
        DRnovo("TotalProduto") = Me.Total.Text
        TBL.Rows.Add(DRnovo)

        Me.TotalCND.Text = FormatNumber(NzZero(DsItens.Tables("Itens").Compute("sum(TotalProduto)", "")), 2)
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

    Private Sub btSalvarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvarItem.Click
        AddItem()
    End Sub

    Private Sub CodBarra_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CodBarra.Leave


        If Me.CodBarra.Text = "" Then
            If Me.Lista.RowCount > 0 Then
                Me.btConcluirCnd.Focus()
            End If
        End If

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
        Me.CodBarra.Clear()
        Me.CodBarra.Focus()

    End Sub

    Private Sub CodProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodProduto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.CodProduto.Text = "" Then
                If Me.Lista.RowCount > 0 Then
                    HabilitarItens(False)
                    Me.btConcluirCnd.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub btEnviarCaixa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnviarCaixa.Click
        'Validaçoes de dados
        Me.btEnviarCaixa.Enabled = False
        Me.Cursor = Cursors.WaitCursor

        'If Me.Venda.Text = "000000" Then
        '    Exit Sub
        'End If

        If Me.CodCliente.Text = "" Then
            MessageBox.Show("Não foi informado o cliente para a venda.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btEnviarCaixa.Enabled = True
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        If Me.Funcionario.Text = "" Then
            MessageBox.Show("Não foi informado o vendedor para a venda.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btEnviarCaixa.Enabled = True
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        If CDbl(NzZero(Me.TotalCND.Text)) = 0 Then
            MessageBox.Show("Não pode finalizar um Condicional com valor [0,00].", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btEnviarCaixa.Enabled = True
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        'Fim das Validaçoes


        'Salvar o Registro Principal

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
        Dim Cmd As OleDb.OleDbCommand = CNN.CreateCommand
        Dim CmdUlt As OleDb.OleDbCommand = CNN.CreateCommand

        Cmd.Transaction = Transacao
        CmdUlt.Transaction = Transacao


        Dim Num As New Random
        Dim Tempo As Integer = 0

        Tempo = Num.Next(1, 999)
        System.Threading.Thread.Sleep(Tempo)
        Try
            'Rotina para Buscar o ultimo Registro
            CmdUlt.CommandText = "Select max(PedidoCND) + 1 from PedidoCND"
            Dim UltimoReg As Integer = NzZero(CmdUlt.ExecuteScalar)
            If NzZero(UltimoReg) = 0 Then UltimoReg = 1
            Me.PedidoCND.Text = UltimoReg.ToString.PadLeft(6, "0")
            'Rotina para Buscar o ultimo Registro Termina aqui


            Dim Sql As String = "INSERT INTO PedidoCND (PedidoCND, Funcionario, CodCliente, DataCND, VencimentoCND, TotalCND, DataFechamento, PercentualVendido, Empresa, Inativo, Status) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11)"
            Cmd.CommandText = Sql

            Cmd.Parameters.Add(New OleDb.OleDbParameter("@1", CInt(NzZero(Me.PedidoCND.Text))))
            Dim Func() As String = CType(Me.Funcionario.Text, String).Split("-")
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Func(0)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", NzZero(Me.CodCliente.Text)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataCND.Text, 1)))
            'Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.VencimentoCND.Text, 1)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", NzZero(Me.TotalCND.Text)))
            'Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.DataFechamento.Text, 1)))
            'Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", NzZero(Me.PercentualVendido.Text)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", CodEmpresa))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", False))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", "INICIAL"))


            Me.Status.Text = "INICIAL"

            Cmd.ExecuteNonQuery()
            Transacao.Commit()

        Catch ex As Exception
            Transacao.Rollback()
            CNN.Close()
            MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.btEnviarCaixa.Enabled = True
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        'Dados do cabeçalho Ok começa a Salvar os itens

        Dim DsIT As New DataSet


        Dim SqlItem As String = "Select * From PedidoCNDitens  Where PedidoCND = " & CInt(Me.PedidoCND.Text)

        Dim DaIT As New OleDb.OleDbDataAdapter(SqlItem, CNN)
        DaIT.Fill(DsIT, "ItensCND")

        Dim DrLinha As DataRow

        Try
            For Each DrLinha In DsItens.Tables("ItensCND").Rows

                Dim TBL As DataTable
                TBL = DsIT.Tables("ItensVenda")

                Dim DRnovo As DataRow
                DRnovo = TBL.NewRow()

                DRnovo("PedidoSequencia") = Nz(Me.PedidoCND.Text, 1)
                DRnovo("PedidoInterno") = 0
                DRnovo("CodigoProduto") = Nz(DrLinha("CodigoProduto").ToString, 1)
                DRnovo("Numero") = Nz(DrLinha("Numero").ToString, 1)
                DRnovo("Multiplos") = 0
                DRnovo("Qtd") = Nz(DrLinha("Qtd").ToString, 1)
                DRnovo("ValorUnitario") = Nz(DrLinha("ValorUnitario").ToString, 1)
                DRnovo("Desconto") = Nz(DrLinha("Desconto").ToString, 1)
                DRnovo("ValorDesconto") = Nz(DrLinha("ValorDesconto").ToString, 1)
                DRnovo("CustoMercadoriaVendida") = Nz(DrLinha("CustoMercadoriaVendida").ToString, 1)
                DRnovo("TotalProduto") = Nz(DrLinha("TotalProduto").ToString, 1)
                DRnovo("tpComissao") = "P"
                DRnovo("Comissao") = 0
                DRnovo("ValorComissao") = 0
                DRnovo("QtdRetirada") = 0
                DRnovo("Grupo") = 0
                DRnovo("Ipi") = 0
                DRnovo("ValorIpi") = 0
                DRnovo("QtdPc") = 0
                DRnovo("UserSenhaDesconto") = System.DBNull.Value
                DRnovo("Icms") = 0
                DRnovo("VlrBCicms") = 0
                DRnovo("VlrIcms") = 0
                DRnovo("CFOP") = System.DBNull.Value
                DRnovo("DevolvidoId") = Nz(DrLinha("DevolvidoId").ToString, 1)
                TBL.Rows.Add(DRnovo)

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


        'Definir Impressão da Venda

        'Try
        '    Dim Conect As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        '    Conect.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)

        '    Conect.SQL = "SELECT Pedido.PedidoSequencia, Pedido.PedidoTipo, Pedido.DataPedido, Empresa.RazãoSocial, Pedido.CódigoCliente, Clientes.Nome, Funcionários.Nome, Pedido.PercDesconto, Pedido.VlrDescProduto, Pedido.ValorProduto, Pedido.TotalPedido, Pedido.FormaPgto, Pedido.DiasParcelamento, ItensPedido.CodigoProduto, ItensPedido.Numero, Produtos.Descrição, ItensPedido.Qtd, ItensPedido.ValorUnitario, ItensPedido.TotalProduto FROM (((Empresa INNER JOIN (Pedido INNER JOIN ItensPedido ON Pedido.PedidoSequencia = ItensPedido.PedidoSequencia) ON Empresa.CódigoEmpresa = Pedido.Empresa) INNER JOIN Clientes ON Pedido.CódigoCliente = Clientes.Codigo) INNER JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário) INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto WHERE (((Pedido.PedidoSequencia)=" & CInt(Me.PedidoCND.Text) & "));"

        '    Dim Rel As New RelSellShoes
        '    Rel.DataSource = Conect

        '    My.Forms.ViewReport.VerRelat.Document = Rel.Document
        '    My.Forms.ViewReport.VerRelat.Document.Name = "RelSellShoes"
        '    Rel.Run()
        '    My.Forms.ViewReport.ShowDialog()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Me.btEnviarCaixa.Enabled = True
        '    Me.Cursor = Cursors.Default
        '    Exit Sub
        'End Try

        'Fim
        MessageBox.Show("Venda efetuada com sucesso e Enviada para o caixa.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Cursor = Cursors.Default


    End Sub


    Private Sub btConcluirVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConcluirCnd.Click

        If Len(CaixaAtivo) <> 4 Then
            MessageBox.Show("O usuario deve selecionar um caixa antes de Confirmar o Pedido. Verifique", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If MsgBox("Deseja Ativar o caixa agora", 36, "Validação de Dados") = 6 Then
                TRVDados(UserAtivo, "CaixaAtivarDesativar")
                If Ina = True Then
                    MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
                    Exit Sub
                Else
                    My.Forms.CaixaAtivarDesativar.ShowDialog()
                    My.Forms.SellShoesFinalizar.ShowDialog()
                End If
            End If
            Exit Sub
        Else
            My.Forms.SellShoesFinalizar.ShowDialog()
        End If


    End Sub


    Private Sub LocalizarVenda(ByVal CodVenda As String)

        Dim dsV As New DataSet

        Dim CN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CN.Open()

        Dim Sql As String = String.Empty

        'Sql = "SELECT Pedido.*, Clientes.*, Clientes.Empresa, Municipio.NomeMunic, UF.NomeUF, Funcionários.Nome FROM (Pedido INNER JOIN ((Clientes LEFT JOIN UF ON Clientes.cUF = UF.CodigoUF) LEFT JOIN Municipio ON Clientes.cMun = Municipio.CodMunicipio) ON Pedido.CódigoCliente = Clientes.Codigo) INNER JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário WHERE (((Pedido.PedidoSequencia)=" & CodVenda & ") AND ((Pedido.Confirmado)=False) AND ((Pedido.Inativo)=False) AND ((Pedido.Empresa)=" & CodEmpresa & ") AND ((Pedido.StatusAndamentos)='ENV. CAIXA'));"
        Sql = "SELECT Pedido.*, Clientes.*, Municipio.NomeMunic, UF.NomeUF, Funcionários.Nome, FormaPgto.Descrição FROM ((Pedido INNER JOIN ((Clientes LEFT JOIN UF ON Clientes.cUF = UF.CodigoUF) LEFT JOIN Municipio ON Clientes.cMun = Municipio.CodMunicipio) ON Pedido.CódigoCliente = Clientes.Codigo) INNER JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário) LEFT JOIN FormaPgto ON Pedido.FormaPgto = FormaPgto.CodFormaPgto WHERE (((Pedido.PedidoSequencia)=" & CodVenda & ") AND ((Pedido.Inativo)=False) AND ((Pedido.Empresa)=" & CodEmpresa & "));"
        Dim DaVenda As New OleDb.OleDbDataAdapter(Sql, CN)

        Sql = "SELECT 0 AS Linha, ItensPedido.CodigoProduto, Produtos.Descrição, ItensPedido.numero, ItensPedido.Qtd, ItensPedido.ValorUnitario, ItensPedido.Desconto, ItensPedido.ValorDesconto, ItensPedido.TotalProduto, ItensPedido.CustoMercadoriaVendida, ItensPedido.DevolvidoId FROM ItensPedido INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto WHERE (((ItensPedido.PedidoSequencia)=" & CodVenda & "));"
        Dim DaItem As New OleDb.OleDbDataAdapter(Sql, CN)

        DaVenda.Fill(dsV, "Venda")
        DaItem.Fill(dsV, "Itens")


        If dsV.Tables("Venda").Rows.Count > 0 Then
            Me.PedidoCND.Text = dsV.Tables("Venda").Rows(0)("PedidoSequencia").ToString
            Me.CodCliente.Text = dsV.Tables("Venda").Rows(0)("Codigo").ToString
            Me.xNome.Text = dsV.Tables("Venda").Rows(0)("Clientes.Nome").ToString
            Me.xCpfCnpj.Text = dsV.Tables("Venda").Rows(0)("CpfCgc").ToString
            Me.xEndereco.Text = dsV.Tables("Venda").Rows(0)("Endereço").ToString
            Me.xBairro.Text = dsV.Tables("Venda").Rows(0)("Bairro").ToString
            Me.xCidadeEstado.Text = dsV.Tables("Venda").Rows(0)("Cidade").ToString & "-" & dsV.Tables("Venda").Rows(0)("NomeUF").ToString
            Me.DataCND.Text = dsV.Tables("Venda").Rows(0)("DataPedido").ToString
            Me.Status.Text = dsV.Tables("Venda").Rows(0)("StatusAndamentos").ToString
            Me.Funcionario.Text = dsV.Tables("Venda").Rows(0)("CódigoFuncionário").ToString & "-" & dsV.Tables("Venda").Rows(0)("Funcionários.Nome").ToString
            Me.TotalCND.Text = FormatNumber(NzZero(dsV.Tables("Venda").Rows(0)("TotalPedido").ToString), 2)
           End If

        Me.Lista.DataSource = dsV.Tables("Itens").DefaultView


        If Me.Status.Text = "ENV. CAIXA" Then
            Me.btEnviarCaixa.Enabled = False
        End If

        CN.Close()

    End Sub


    Private Sub ExcluirOItemSelecionadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirOItemSelecionadoToolStripMenuItem.Click

        If Me.Status.Text = "ENV. CAIXA" Then
            MessageBox.Show("Este pedido ja foi enviado para o caixa e não pode mais ser alterado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("Deseja Excluir o item selecionado", "Validação de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            DsItens.Tables("Itens").Rows(LinhaSelecionada).Delete()
            Me.TotalCND.Text = FormatNumber(NzZero(DsItens.Tables("Itens").Compute("sum(TotalProduto)", "")), 2)
            Me.CodBarra.Focus()
            Me.Lista.Refresh()
        End If

    End Sub

    Private Sub Lista_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellContentClick
        LinhaSelecionada = e.RowIndex
    End Sub


End Class