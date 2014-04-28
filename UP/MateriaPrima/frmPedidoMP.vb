Imports System.Data.OleDb
Imports System.IO

Public Class frmPedidoMP
    Enum TagType
        eEditar = 1
        eSalvar = 2
        eLoc = 3
        eNone = 0
    End Enum
    Dim Ação As New TrfGerais()
    Dim cr As DevComponents.DotNetBar.SuperTabControl
    Dim iteRes As New ReservaMP
    Dim iteMP As New ClassMP
    Dim bs As BindingSource
    Dim db As New clsBancoDados
    Dim item As New clsItemMP
    Dim loadPed As New ClassMostraPedido
    Dim PMP As New clsPedidoMP
    Dim cls As New cCondicaoPgto
    ''' <summary>'''usando para indicar o status do botao   ''' </summary>
    Public Value As TagType = TagType.eNone
    Dim valorParcelamento As Double
    Private Sub btnAdicionarItem_Click(sender As Object, e As EventArgs) Handles btnAdicionarItem.Click

        If String.IsNullOrEmpty(Me.ModeloVenda.Text) Or String.IsNullOrEmpty(CodigoVendedor.Text) Or String.IsNullOrEmpty(NomeCliente.Text) Or String.IsNullOrEmpty(Me.DataPrazo.Text) Or String.IsNullOrEmpty(Contato.Text) Then
            MessageBox.Show("Existem campos não preenchidos no cabeçalho.Verifique e tente novamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If Me.chkConfirmado.Checked = True Then
            Return
        End If
        If NzZero(Me.NumeroPedido.Text) = 0 Then
            With PMP
                .CodigoCliente = NzZero(Me.CodigoCliente.Text)
                .nomeCliente = Me.NomeCliente.Text
                .Telefone = Me.txttelefone.Text
                .Email = Me.txtEmail.Text
                .DataPedido = Me.DataPedido.Text
                .DataPrazoEntrega = Me.DataPrazo.Text
                .Contato = Me.Contato.Text
                .CodigoFuncionario = Me.CodigoVendedor.Text
                .Status = Me.status.Text
                .Observacao = Me.Obs.Text
                .DataFechamento = Me.DataFechamento.Text
                .ValorBordado = Me.ValorBordado.Text
                .ValorSerigrafia = Me.ValorSerigrafia.Text
                .TotalBruto = Me.TotalBruto.Text
                .TotalLiquido = Me.TotalLiquido.Text
                .Modelo = Me.ModeloVenda.Text.Substring(0, 1)
                .Empresa = CodEmpresa
                .Datavalidade = DataValidade.Text
            End With
            PMP.Gravar()
            Dim var As String
            var = Retorno
            Me.NumeroPedido.Text = var.PadLeft(6, "0")
            Me.btnSalvaEditar.Enabled = True
            Value = TagType.eSalvar
            Me.ModeloVenda.Enabled = False

        End If
        vEnum = Operacao.inclusao
        My.Forms.frmAdicionarItemMP.ShowDialog()

        'se inseriu dados nos item o cabeçalho do cliente é bloqueado, caso contrario é liberado
        If CDbl(Me.txtPecas.Text) > 1 Then
            Me.cabCliente.Enabled = False
            Me.btnGerarPedidos.Enabled = True
        Else
            Me.cabCliente.Enabled = True
            Me.btnGerarPedidos.Enabled = False
        End If
        Retorno = Nothing
    End Sub
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        If String.IsNullOrEmpty(Me.NumeroPedido.Text) Then
            Me.Dispose()
            Exit Sub
        End If

        If Value = TagType.eEditar Or Value = TagType.eNone Then
            Retorno = 0
            Me.Close()
            Me.Dispose()
        Else
            MessageBox.Show("Você prescisa salvar o registro primeiro", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        If Value = TagType.eSalvar Then
            MessageBox.Show("O registro atual foi editado, Clique no botão salvar para processiguir", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Ação.LimpaTextBox(Me)
        Me.grpCab.Enabled = True
        Me.grpReservaMP.Enabled = True
        Me.stcMP.Enabled = True
        Me.DataPedido.Text = DataDia
        Me.TotalBruto.Text = FormatCurrency(0, 2)
        Me.TotalLiquido.Text = FormatCurrency(0, 2)
        Me.ValorSerigrafia.Text = FormatCurrency(0, 2)
        Me.ValorBordado.Text = FormatCurrency(0, 2)
        Me.TotalDosItem.Text = FormatCurrency(0, 2)
        Me.txtPecas.Text = FormatNumber(0, 2)
        Me.chkConfirmado.Checked = False
        Me.status.Text = "ABERTO"
        Me.status.ForeColor = Color.Green
        Me.btnConfirmar.Enabled = True
        Me.ValorDesconto.Enabled = True
        Me.ValorSerigrafia.Enabled = True
        Me.ValorBordado.Enabled = True
        Me.CodigoPagamento.Enabled = True
        Me.ValorAVista.Enabled = True
        Me.ValorOutros.Enabled = True
        Me.ValorAFaturar.Enabled = True
        Me.btnSalvaEditar.Enabled = True
        Me.lblGeradoPedido.Visible = False
        Me.chkGeradoPedido.Checked = False
        btnGerarPedidos.Enabled = False

        item.AtGrade(0)
        iteRes.AtGrade(0)
        'iteMP.AtGrade(0)
        Me.dgvParcelamento.Rows.Clear()
        If Me.NumeroPedido.Text = "00000" Or String.IsNullOrEmpty(Me.NumeroPedido.Text) Then Me.ModeloVenda.Enabled = True
        Me.ModeloVenda.SelectedIndex = -1
        Me.ModeloVenda.Focus()
        Me.btnSalvaEditar.Text = "Salvar"
        Value = TagType.eNone

    End Sub
    Private Sub CodigoCliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoCliente.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ClientesProcura.ShowDialog()
            If Not String.IsNullOrEmpty(Retorno) Then
                Me.CodigoCliente.Text = Retorno
                LocalizarCliente()
            End If
        End If
    End Sub
    Private Sub CodigoCliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CodigoCliente.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(OnlyNumber(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub CodigoCliente_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoCliente.Leave
        LocalizarCliente()
        Me.Contato.Focus()
    End Sub
    Private Sub CodigoVendedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoVendedor.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.PedidoVendaFindVendedores.ShowDialog()
        End If
        'If Not IsNumeric(Chr(e.KeyCode)) And e.KeyCode <> 8 Then
        '    e.SuppressKeyPress = True
        'End If
    End Sub
    Private Sub CodigoVendedor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CodigoVendedor.KeyPress
        Dim KeyAscii As Byte = Convert.ToByte(e.KeyChar)
        If KeyAscii = 13 Then Exit Sub
        If (KeyAscii < 48 Or KeyAscii > 58) And KeyAscii <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub CodigoVendedor_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoVendedor.Leave
        Localizar(Me.CodigoVendedor.Text)
    End Sub
    Private Sub DataPrazo_KeyDown(sender As Object, e As KeyEventArgs) Handles DataPrazo.KeyDown
        If e.KeyCode = Keys.Return Then
            Me.stcMP.SelectedTab = Me.ItemPedidoGeral
            Me.btnAdicionarItem.Focus()
        End If
    End Sub
    Private Sub frmPedidoMP_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F4
                btnReservaMP_Click(sender, e) 'chama o frmReservaLancar
            Case Keys.F6
                If Value = TagType.eEditar Then
                    MessageBox.Show("Clique no botão editar", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                btnAdicionarItem_Click(sender, e) 'chama o frmAdicionarItemMP
            Case Keys.F7
                Me.stcMP.SelectedTab = Me.ItemFechamento
                Me.DataFechamento.Focus()
                Me.DataFechamento.Text = DataDia
                Me.TotalBruto.Text = FormatCurrency(Me.TotalDosItem.Text, 2)
        End Select
    End Sub
    Private Sub frmPedidoMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cr = Me.stcMP
        cr.SelectedTabIndex = 0
        Me.grpCab.Enabled = False
        Me.grpReservaMP.Enabled = False
        Me.stcMP.Enabled = False
    End Sub
    Public Sub Localizar(ByVal xID As Integer)
        Dim sql As String
        sql = "Select códigofuncionário,nome from funcionários where AdicionarEmVendas=true and códigofuncionário=" & xID
        Dim conn As New OleDbConnection
        Dim DR As OleDbDataReader
        Try
            conn = db.AbreBanco
            Dim cmd As New OleDbCommand(sql, conn)
            DR = cmd.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Me.CodigoVendedor.Text = DR.Item("códigofuncionário")
                Me.NomeVendedor.Text = DR.Item("nome") & ""
            Else
                MessageBox.Show("Código não existe para esse vendedor", "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.CodigoVendedor.Clear()
            End If

        Catch ex As Exception
            Throw ex
        Finally
            db.fechabanco(conn)
        End Try

    End Sub
    Private Sub LocalizarCliente()
        Dim conn As New OleDbConnection
        conn = db.AbreBanco
        Dim Sql As String = "Select * from Clientes where Codigo = " & Me.CodigoCliente.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, conn)
        Dim DR As OleDb.OleDbDataReader
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            If DR.Item("Bloqueado") = True Then
                MessageBox.Show("Este cliente esta bloqueado, Favor verificar", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.CodigoCliente.Clear()
                Me.NomeCliente.Clear()
                Exit Sub
            End If
            If IsDBNull(DR.Item("TpComercio")) Then
                MessageBox.Show("Este cliente esta sem o tipo de comércio, Favor verificar", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.CodigoCliente.Clear()
                Me.NomeCliente.Clear()
                Exit Sub
            End If
            Me.NomeCliente.Text = DR.Item("Nome").ToString
            Me.txttelefone.Text = DR.Item("Telefone").ToString
            Me.txtEmail.Text = DR.Item("email").ToString
        Else
            MessageBox.Show("Cliente não localizado, Favor verificar", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.CodigoCliente.Clear()
            Me.NomeCliente.Clear()
            Exit Sub
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If String.IsNullOrEmpty(Me.ModeloVenda.Text) Or String.IsNullOrEmpty(CodigoVendedor.Text) Then
            MessageBox.Show("Falta informações no cabeçalho verifique os seguinte campos: [Modelo], [Tipo de Venda], [Vendedor]." _
                & Microsoft.VisualBasic.ControlChars.CrLf & "Todos esses campos devem ser preenchidos.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If dgvParcelamento.RowCount > 0 Then
            MessageBox.Show("Já foram gerados parcelamentos ou inseridos itens para esse pedido." _
               & Microsoft.VisualBasic.ControlChars.CrLf & "Não será possível editá-los.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        'Me.CodigoCliente.Clear()
        'Me.NomeCliente.Clear()
        'Me.txttelefone.Clear()
        'Me.txtEmail.Clear()
        My.Forms.ClientesProcura.ShowDialog()
        Me.NomeCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.txtEmail.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.txttelefone.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim

        If Not String.IsNullOrEmpty(CodigoCliente.Text) And CodigoCliente.Text <> 0 Then
            LocalizarCliente()
        End If

    End Sub
    Private Sub DataPrazo_Leave(sender As Object, e As EventArgs) Handles DataPrazo.Leave
        If Not String.IsNullOrEmpty(Me.DataPedido.Text) Then
            If DateDiff(DateInterval.Day, CDate(Me.DataPedido.Text), CDate(Me.DataPrazo.Text)) < 0 Then
                MessageBox.Show("A data do  prazo não pode ser menor que a data do pedido.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.DataPrazo.Clear()
                Exit Sub
            End If
        End If
    End Sub
    Private Sub btnReservaMP_Click(sender As Object, e As EventArgs) Handles btnReservaMP.Click
        If String.IsNullOrEmpty(Me.ModeloVenda.Text) Or String.IsNullOrEmpty(CodigoVendedor.Text) Or String.IsNullOrEmpty(NomeCliente.Text) Then
            MessageBox.Show("Existem campos não preenchidos no cabeçalho.Verifique e tente novamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'verifica se o pedido não foi confirmado
        If Not Me.chkConfirmado.Checked Then
            My.Forms.frmReservaLancar.ShowDialog()
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles imgBuscaCondicao.Click
        My.Forms.CondicaoPagamentoBuscaMP.ShowDialog()
    End Sub
    Private Sub CodigoPagamento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CodigoPagamento.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(OnlyNumber(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub CodigoPagamento_KeyDown(sender As Object, e As KeyEventArgs) Handles CodigoPagamento.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.CondicaoPagamentoBuscaMP.ShowDialog()
        End If
    End Sub
    Private Sub btnGerarParcelas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarParcelas.Click

        If String.IsNullOrEmpty(Me.CodigoPagamento.Text) Then
            MessageBox.Show("Não foi selecionado o pagamento para este pedido." & Microsoft.VisualBasic.ControlChars.CrLf & "Para gerar novos parcelamentos, Escolha uma forma de Pagamento.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If dgvParcelamento.RowCount > 0 Then
            MessageBox.Show("Já foi gerado parcelamento para este pedido." & Microsoft.VisualBasic.ControlChars.CrLf & "Para gerar novos parcelamentos, exclua  as parcelas existentes.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Try
            Me.TotalLiquido.Text = FormatCurrency(CDbl(Me.TotalBruto.Text) - CDbl(Me.ValorDesconto.Text), 2)
        Catch ex As Exception
            MessageBox.Show("Houve um erro de violação, digite o valor novamente", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try


        If dgvParcelamento.RowCount > 0 Then
            MessageBox.Show("Já foram geradas parcelas. Para gerar novamente exclua as existentes." _
                & Microsoft.VisualBasic.ControlChars.CrLf & "--------------------------------------------------------------------------" _
                & Microsoft.VisualBasic.ControlChars.CrLf & "Qualquer duvida contacte o suporte.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If Me.chkConfirmado.Checked = True Then
            Return
        End If
        If Me.DataFechamento.Text = "" Then
            Me.DataFechamento.Text = DataDia
        End If

        cls.Localizar(Me.CodigoPagamento.Text)

        If cls.TemEntrada = True And NzZero(Me.ValorAVista.Text) = 0 Then
            MessageBox.Show("Esta condição de pagamento necessita de uma entrada." & Microsoft.VisualBasic.ControlChars.CrLf & "Digite um Valor no campo ""A vista"".", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.ValorAVista.Focus()
            Exit Sub
        End If

        'Pegar o total de Parcelamentos
        Dim Parcelas() As String = Split(cls.DiasParcelamento, "-")
        Dim Contar As Integer
        Dim Dividido As Decimal

        Dim conn As New OleDbConnection
        conn = db.AbreBanco

        Dim Ds As New DataSet

        Dim Sql As String = "SELECT * from Receber Where Id = -1"

        Dim DAReceber As New OleDb.OleDbDataAdapter(Sql, conn)
        DAReceber.Fill(Ds, "Receber")


        If Me.DescricaoPagamento.Text = "MENSAL" Then   'Gerar valor mensal
            Dim DrNew As DataRow
            DrNew = Ds.Tables("Receber").NewRow
            Dim Parc As String = Me.NumeroPedido.Text & "-" & 1 & "/" & 1
            DrNew("Documento") = Parc
            DrNew("DataDocumento") = Me.DataPedido.Text
            DrNew("ValorDocumento") = CDbl(Me.ValorAFaturar.Text)
            DrNew("LocalPgto") = "CARTEIRA"
            DrNew("PedidoMP") = Me.NumeroPedido.Text
            DrNew("CodCliente") = Me.CodigoCliente.Text
            DrNew("Cliente") = Me.NomeCliente.Text
            DrNew("Empresa") = CodEmpresa
            DrNew("OriginalParcial") = "O"
            DrNew("Vendedor") = Me.CodigoVendedor.Text
            DrNew("Vencimento") = DateSerial(Year(DataDia), Month(DataDia) + 1, DiaFechamentoMensal) 'gera o vencimento  para o dia 10 de cada mês.
            DrNew("MediaDescontoPedido") = 0
            DrNew("PercentComissao") = 0
            DrNew("ContaValorBaixado") = Nz(CodLancamentoReceber, 1)
            DrNew("ContaCR") = Nz(VAR_ContaCrVenda, 1)
            DrNew("Virtual") = True
            Ds.Tables("Receber").Rows.Add(DrNew)

        Else 'caso contrário usa outro parcelamento
            Dividido = Me.ValorAFaturar.Text / Parcelas.Length
            For Contar = 1 To Parcelas.Length
                Dim DrNew As DataRow
                DrNew = Ds.Tables("Receber").NewRow
                Dim Parc As String = Me.NumeroPedido.Text & "MP-" & Contar & "/" & Parcelas.Length
                DrNew("Documento") = Parc
                DrNew("DataDocumento") = Me.DataPedido.Text
                DrNew("ValorDocumento") = Dividido
                DrNew("LocalPgto") = "CARTEIRA"
                DrNew("PedidoMP") = Me.NumeroPedido.Text
                DrNew("CodCliente") = Me.CodigoCliente.Text
                DrNew("Cliente") = Me.NomeCliente.Text
                DrNew("Empresa") = CodEmpresa
                DrNew("OriginalParcial") = "O"
                DrNew("Vendedor") = Me.CodigoVendedor.Text
                DrNew("Vencimento") = DataDia.AddDays(CInt(Parcelas(Contar - 1)))
                DrNew("MediaDescontoPedido") = 0
                DrNew("PercentComissao") = 0
                DrNew("ContaValorBaixado") = Nz(CodLancamentoReceber, 1)
                DrNew("ContaCR") = Nz(VAR_ContaCrVenda, 1)
                DrNew("Virtual") = True
                Ds.Tables("Receber").Rows.Add(DrNew)
            Next
        End If

        Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAReceber) 'Usa a classe commandbuilder para criar os comandos de update,insert, delete
        DAReceber.Update(Ds, "Receber") 'faz uma Insert na tabela receber usando o commandbuilder.
        System.Threading.Thread.Sleep(1000) 'retarda 1s para a próxima execução
        atGridParcelas() 'atualiza o grid de recebimentos
        btnSalvaEditar_Click(sender, e)

    End Sub
    Private Sub atGridParcelas()
        Dim conn As New OleDbConnection
        conn = db.AbreBanco
        Dim Sql As String = "SELECT *  FROM Receber Where Receber.Documento <> '" & Me.NumeroPedido.Text & "-AVISTA-MP' And Receber.Documento <> 'CHEQUE' AND PedidoMP=" & CInt(Me.NumeroPedido.Text) & " Order By id"
        Dim ocmd As New OleDb.OleDbCommand(Sql, conn)
        Dim odr As OleDb.OleDbDataReader
        odr = ocmd.ExecuteReader
        Dim i As Integer
        Dim row As New DataGridViewRow
        Dim cVlr As Double = 0
        Me.dgvParcelamento.Rows.Clear()
        While odr.Read()
            i += 1
            'preenche o grid com alguns dados
            Dim row0 As String() = {odr.Item("Id"), odr.Item("Documento"), odr.Item("NotaFiscal").ToString, odr.Item("Vencimento"), FormatCurrency(odr.Item("valorDocumento"), 2), odr.Item("LocalPgto")}
            'adiciona as linhas
            With Me.dgvParcelamento.Rows
                .Add(row0)
            End With
            cVlr += odr.Item("valorDocumento")
            ' Me.txtTotal.Text = FormatCurrency(cVlr, 2)
        End While
        valorParcelamento = cVlr
    End Sub
    Private Sub CodigoPagamento_Leave(sender As Object, e As EventArgs) Handles CodigoPagamento.Leave
        cls.Localizar(Me.CodigoPagamento.Text)
        If Not cls.pReturnErro Then
            Me.DescricaoPagamento.Text = cls.Descricao
        End If
        btnGerarParcelas.Focus()
        Me.CodigoPagamento.Enabled = False
        Me.DescricaoPagamento.Enabled = False
    End Sub
    Private Sub ValorDesconto_Leave(sender As Object, e As EventArgs) Handles ValorDesconto.Leave
        Try

            If CDbl(Me.ValorDesconto.Text) < 0 Or String.IsNullOrEmpty(Me.ValorDesconto.Text) Then
                MessageBox.Show("O valor não pode ser negativo ou nulo", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.ValorDesconto.Text = FormatNumber(0, 2)
                Exit Sub
            End If

            Me.TotalLiquido.Text = FormatCurrency(CDbl(Me.TotalBruto.Text) - CDbl(Me.ValorDesconto.Text), 2)
        Catch ex As Exception
            MessageBox.Show("Houve um erro de violação, digite o valor novamente", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub btnEditarParcelas_Click(sender As Object, e As EventArgs) Handles btnEditarParcelas.Click
        If dgvParcelamento.RowCount = 0 Then
            MessageBox.Show("Não foi gerado parcelamento para este pedido.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If Me.chkConfirmado.Checked Then
            MessageBox.Show("Este pedido já foi confirmando, não é possível editar as parcelas.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        My.Forms.EditParcelaMP.Total.Text = Me.ValorAFaturar.Text
        My.Forms.EditParcelaMP.ShowDialog()
        atGridParcelas()
    End Sub
    Private Sub ValorAvista_Enter(sender As Object, e As EventArgs) Handles ValorAVista.Enter


        'verifica se o valor a vista esta vazio entao coloca zero
        'verifi se tem parcelamento ja feito or se o pedido esta confirmado entao bloqueia o valor a vista e outros
        If Me.ValorAVista.Text = "" Then Me.ValorAVista.Text = FormatCurrency(0, 2)
        If Me.dgvParcelamento.Rows.Count > 0 Or Me.chkConfirmado.Checked = True Then
            Me.ValorAVista.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.ValorOutros.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Else
            Me.ValorAVista.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.ValorOutros.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.CodigoPagamento.Clear()
            Me.DescricaoPagamento.Clear()
        End If
    End Sub
    Private Sub ValorAvista_Leave(sender As Object, e As EventArgs) Handles ValorAVista.Leave
        If CDbl(Me.ValorAVista.Text) > 0 Then
            Me.ValorOutros.Text = FormatCurrency(0, 2)
            Me.ValorAFaturar.Text = FormatCurrency(0, 2)
        End If
        Me.ValorAFaturar.Text = FormatCurrency(CDbl(NzZero(Me.TotalLiquido.Text)) - CDbl(NzZero(Me.ValorAVista.Text)) - CDbl(NzZero(Me.ValorOutros.Text)), 2)
        Me.ValorAVista.Text = FormatCurrency(Me.ValorAVista.Text, 2)

        If CDbl(Me.ValorAVista.Text) = CDbl(Me.TotalLiquido.Text) Then
            Me.Panel1.Enabled = False
        End If
    End Sub
    Private Sub ValorOutros_Enter(sender As Object, e As EventArgs) Handles ValorOutros.Enter
        If Me.dgvParcelamento.Rows.Count = 0 Then
            If CDbl(Me.ValorAVista.Text) = CDbl(Me.TotalLiquido.Text) Then
                Me.ValorOutros.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Exit Sub
            End If
            Me.ValorOutros.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Else
            Me.ValorOutros.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        End If
        If Me.ValorOutros.Text = "" Then Me.ValorOutros.Text = FormatCurrency(0, 2)
    End Sub
    Private Sub ValorOutros_Leave(sender As Object, e As EventArgs) Handles ValorOutros.Leave
        Me.ValorAFaturar.Text = FormatCurrency(CDbl(NzZero(Me.TotalLiquido.Text)) - CDbl(NzZero(Me.ValorAVista.Text)) - CDbl(NzZero(Me.ValorOutros.Text)), 2)

        If CDbl(Me.ValorAFaturar.Text) = 0 Then
            Me.Panel1.Enabled = False
        Else
            Me.Panel1.Enabled = True
            Me.CodigoPagamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        End If

        If CDbl(Me.ValorAFaturar.Text) < 0 Then
            MessageBox.Show("O Valor do Cheque está utrapassado o valor total do pedido. Corrija este valor.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.ValorOutros.Clear()
            Me.ValorOutros.Text = FormatCurrency(0, 2)
            Me.ValorOutros.Focus()
            Me.ValorAFaturar.Text = FormatCurrency(CDbl(NzZero(Me.TotalLiquido.Text)) - CDbl(NzZero(Me.ValorAVista.Text)) - CDbl(NzZero(Me.ValorOutros.Text)), 2)

            Exit Sub
        End If

        Me.ValorOutros.Text = FormatCurrency(Me.ValorOutros.Text, 2)
        Me.CodigoPagamento.Focus()
        Me.btnConfirmar.Enabled = True
    End Sub
    Private Sub ValorAvista_Validated(sender As Object, e As EventArgs) Handles ValorAVista.Validated
        If CDbl(Me.ValorAVista.Text) > CDbl(Me.TotalLiquido.Text) Then
            MessageBox.Show("O Valor não pode ser maior que o total liquido do pedido", "Validadação de dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.ValorAVista.Text = FormatCurrency(0, 2)
            Me.ValorAFaturar.Text = FormatCurrency(CDbl(NzZero(Me.TotalLiquido.Text)) - CDbl(NzZero(Me.ValorAVista.Text)) - CDbl(NzZero(Me.ValorOutros.Text)), 2)

            Exit Sub
        End If
    End Sub
    Private Sub TotalBruto_Enter(sender As Object, e As EventArgs) Handles TotalBruto.Enter
        Me.TotalBruto.Text = FormatCurrency(Me.TotalDosItem.Text, 2)
    End Sub
    Private Sub ModeloVenda_Leave(sender As Object, e As EventArgs) Handles ModeloVenda.Leave
        If String.IsNullOrEmpty(ModeloVenda.Text) Then
            MessageBox.Show("Escolha {PEDIDO}  ou {ORÇAMENTO} para prosseguir.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.ModeloVenda.Focus()
            Exit Sub
        Else
            If Me.ModeloVenda.Text = "ORCAMENTO" Then

                Me.ItemFechamento.Visible = False
                Me.grpReservaMP.Enabled = False
                Me.btEditarCliente.Enabled = True
                Me.txtEmail.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                Me.txttelefone.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                Me.NomeCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                Me.cabCliente.Enabled = True
                Me.DataValidade.Text = DataDia.AddDays(10)
                Me.ModeloVenda.Enabled = False
            Else

                Me.ItemFechamento.Visible = True
                Me.grpReservaMP.Enabled = True
                Me.btEditarCliente.Enabled = True
                Me.btEditarCliente.Enabled = False
                Me.txtEmail.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.txttelefone.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.NomeCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.DataPrazo.Enabled = True
                Me.cabCliente.Enabled = True
                Me.btnReservaMP.Enabled = True
                Me.ModeloVenda.Enabled = False

            End If
            Me.btnAdicionarItem.Enabled = True
        End If
    End Sub
    Private Sub btEditarCliente_Click(sender As Object, e As EventArgs) Handles btEditarCliente.Click

        If String.IsNullOrEmpty(Me.ModeloVenda.Text) Or String.IsNullOrEmpty(CodigoVendedor.Text) Then
            MessageBox.Show("Falta informações no cabeçalho verifique os seguinte campos: [Modelo], [Tipo de Venda], [Vendedor]." _
                & Microsoft.VisualBasic.ControlChars.CrLf & "Todos esses campos devem ser preenchidos.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Me.NomeCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtEmail.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txttelefone.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CodigoCliente.Text = 0
        Me.NomeCliente.Clear()
        Me.txtEmail.Clear()
        Me.txttelefone.Clear()
        Me.CodigoCliente.Text = 0
        Me.NomeCliente.Focus()
    End Sub
    Private Sub btnSalvaEditar_Click(sender As Object, e As EventArgs) Handles btnSalvaEditar.Click

        If String.IsNullOrEmpty(Me.NumeroPedido.Text) Then
            Exit Sub
        End If

        If Value = TagType.eEditar Then
            'Libera os campos para ser editados e muda o lengenda do botão para salvar

            If Me.chkGeradoPedido.Checked Then
                MessageBox.Show("Este Orçamento já foi gerado um pedido", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            grpCab.Enabled = True
            Me.stcMP.Enabled = True

            Me.btnSalvaEditar.Text = "Salvar"
            Me.btnAdicionarItem.Enabled = True
            Value = TagType.eSalvar

            If Me.ModeloVenda.Text = "ORCAMENTO" Then
                Me.ModeloVenda.Enabled = False
                Me.ItemFechamento.Visible = False
                Me.grpReservaMP.Enabled = False
                Me.btEditarCliente.Enabled = True
                Me.txtEmail.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                Me.txttelefone.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                Me.NomeCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                Me.cabCliente.Enabled = True
            Else
                Me.ModeloVenda.Enabled = False
                Me.ItemFechamento.Visible = True
                Me.grpReservaMP.Enabled = True
                Me.btEditarCliente.Enabled = True
                Me.btEditarCliente.Enabled = False
                Me.txtEmail.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.txttelefone.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.NomeCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.DataPrazo.Enabled = True
                Me.cabCliente.Enabled = True
                Me.btnAdicionarItem.Enabled = True
                Me.btnReservaMP.Enabled = True
            End If

        ElseIf Value = TagType.eSalvar Then
            With PMP
                .CodigoCliente = NzZero(Me.CodigoCliente.Text)
                .DataPedido = Me.DataPedido.Text
                .DataPrazoEntrega = Me.DataPrazo.Text
                .Contato = Me.Contato.Text
                .CodigoFuncionario = Me.CodigoVendedor.Text
                .Status = Me.status.Text
                .Observacao = Me.Obs.Text
                .DataFechamento = Me.DataFechamento.Text
                .ValorBordado = Me.ValorBordado.Text
                .ValorSerigrafia = Me.ValorSerigrafia.Text
                .TotalBruto = Me.TotalBruto.Text
                .TotalLiquido = Me.TotalLiquido.Text
                .TotalDesconto = NzZero(Me.ValorDesconto.Text)
                '.ValorMP = Me.TotalMP.Text
                .CodigoPagamento = Nz(Me.CodigoPagamento.Text, 2)
                .nomeCliente = Me.NomeCliente.Text
                .Telefone = Me.txttelefone.Text
                .Email = Me.txtEmail.Text
                .Valorfaturar = CDbl(NzZero(Me.ValorAFaturar.Text))
                .Valorvista = CDbl(NzZero(ValorAVista.Text))
                .Valorcheque = CDbl(NzZero(ValorOutros.Text))
                .Modelo = Me.ModeloVenda.Text.Substring(0, 1)
                .Datavalidade = Me.DataValidade.Text
                .Gerado_pedido = Me.chkGeradoPedido.Checked
                .Observacao = Me.Obs.Text

            End With
            PMP.Editar(Me.NumeroPedido.Text)
            Me.btnSalvaEditar.Enabled = True
            Value = TagType.eEditar
            'Salva o registro e muda a lengenda do botão para editar
            Me.btnSalvaEditar.Text = "Editar"
            Value = TagType.eEditar

            Me.grpCab.Enabled = False
            Me.btnAdicionarItem.Enabled = False
            Me.btnReservaMP.Enabled = False

        End If
    End Sub
    Private Sub ButtonItem2_Click(sender As Object, e As EventArgs) Handles ButtonItem2.Click

        sTipoBusca = "P"
        BuscaPedido()

        Me.ItemFechamento.Visible = True

        If Me.dgvParcelamento.RowCount > 0 Then
            Me.CodigoPagamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.ValorAVista.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.ValorOutros.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Else
            Me.CodigoPagamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.ValorAVista.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.ValorOutros.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        End If

    End Sub
    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles ButtonItem1.Click
        sTipoBusca = "O"
        BuscaPedido()
        Me.ItemFechamento.Visible = False
    End Sub
    Private Sub BuscaPedido()
        Me.grpCab.Enabled = False
        Me.grpReservaMP.Enabled = False
        Me.stcMP.Enabled = False

        Retorno = String.Empty
        My.Forms.PedidoMPBusca.ShowDialog()
        If Not String.IsNullOrEmpty(Retorno) Then
            PMP.MostrarPedido(Retorno, sTipoBusca)
            With PMP
                Me.NumeroPedido.Text = .NumeroPedido
                Me.DataPedido.Text = .DataPedido
                Me.CodigoVendedor.Text = .CodigoFuncionario
                Me.NomeVendedor.Text = .NomeVendedor
                Me.CodigoCliente.Text = .CodigoCliente
                Me.NomeCliente.Text = .nomeCliente
                Me.DataPrazo.Text = .DataPrazoEntrega
                Me.Contato.Text = .Contato
                Me.Obs.Text = .Observacao
                Me.chkConfirmado.Checked = .Fechado
                Me.TotalLiquido.Text = FormatCurrency(.TotalLiquido, 2)
                Me.TotalBruto.Text = FormatCurrency(.TotalBruto, 2)
                Me.ValorBordado.Text = FormatCurrency(.ValorBordado, 2)
                Me.ValorSerigrafia.Text = FormatCurrency(.ValorSerigrafia, 2)
                Me.ValorDesconto.Text = FormatCurrency(.TotalDesconto, 2)
                Me.CodigoPagamento.Text = .CodigoPagamento
                Me.DescricaoPagamento.Text = .Codigopagamentodesc
                Me.DataFechamento.Text = .DataFechamento
                Me.ValorAVista.Text = FormatCurrency(.Valorvista, 2)
                Me.ValorAFaturar.Text = FormatCurrency(.Valorfaturar, 2)
                Me.ValorOutros.Text = FormatCurrency(.Valorcheque, 2)
                Me.ModeloVenda.Text = .Modelo
                Me.txttelefone.Text = .Telefone
                Me.txtEmail.Text = .Email

                Me.chkGeradoPedido.Checked = .Gerado_pedido
                Me.chkConfirmado.Checked = .Fechado
                item.Modelo = .Modelo.Substring(0, 1)
                item.AtGrade(.NumeroPedido)
                If ModeloVenda.Text = "PEDIDO" Then
                    btnGerarPedidos.Enabled = False
                    If Me.chkConfirmado.Checked = True Then
                        Me.status.Text = "FECHADO"
                        Me.status.ForeColor = Color.Red
                        Me.btnConfirmar.Enabled = False
                        Me.btnSalvaEditar.Enabled = False
                        Me.stcMP.Enabled = True
                        Me.DataFechamento.Enabled = False
                        Me.TotalBruto.Enabled = False
                        Me.ValorBordado.Enabled = False
                        Me.ValorSerigrafia.Enabled = False
                        Me.ValorDesconto.Enabled = False
                        Me.CodigoPagamento.Enabled = False
                        Me.ValorAVista.Enabled = False
                        Me.ValorOutros.Enabled = False
                        Me.imgBuscaCondicao.Enabled = False
                        Me.Obs.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                        Me.DataValidade.Clear()
                    Else
                        Me.status.Text = "ABERTO"
                        Me.status.ForeColor = Color.Green
                        Me.btnConfirmar.Enabled = True
                        Me.DataFechamento.Enabled = True
                        Me.TotalBruto.Enabled = True
                        Me.ValorBordado.Enabled = True
                        Me.ValorSerigrafia.Enabled = True
                        Me.ValorDesconto.Enabled = True
                        Me.CodigoPagamento.Enabled = True
                        Me.ValorAVista.Enabled = True
                        Me.ValorOutros.Enabled = True
                        Me.imgBuscaCondicao.Enabled = True
                        Me.btnSalvaEditar.Enabled = True
                        Me.Obs.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                        Me.Panel1.Enabled = False
                        Me.lblGeradoPedido.Visible = False
                        Me.DataValidade.Clear()
                        Value = TagType.eEditar

                    End If
                    iteRes.AtGrade(.NumeroPedido)
                    'iteMP.AtGrade(.NumeroPedido)
                    atGridParcelas()
                Else
                    iteRes.AtGrade(0)
                    Me.DataValidade.Text = .Datavalidade
                    Me.status.Text = "ABERTO"
                    Me.status.ForeColor = Color.Green
                    Me.btnSalvaEditar.Enabled = True
                    If Me.chkGeradoPedido.Checked Then
                        Me.lblGeradoPedido.Visible = True
                        Me.lblGeradoPedido.Text = "Orçamento gerado Pedido N. " & String.Format("{0:000000}", Convert.ToInt16(.OrcForPed))
                        btnGerarPedidos.Enabled = False
                    Else
                        Me.lblGeradoPedido.Visible = False
                        If Me.dgvItemGeral.RowCount > 0 Then
                            btnGerarPedidos.Enabled = True
                        End If

                    End If


                End If
                'muda a lengenda do botão para editar
                Me.btnSalvaEditar.Text = "Editar"
                Value = TagType.eEditar
            End With
        End If
        Retorno = Nothing
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        If Value = TagType.eEditar Or Value = TagType.eNone Then
            Retorno = 0
        Else
            MessageBox.Show("Você prescisa salvar o registro primeiro", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        cr = Me.stcMP
        cr.SelectedTabIndex = 0

        Me.grpCab.Enabled = False
        Me.grpReservaMP.Enabled = False
        Me.stcMP.Enabled = False
    End Sub
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

        If CDbl(Me.ValorAVista.Text) + CDbl(Me.ValorOutros.Text) + CDbl(Me.ValorAFaturar.Text) <> CDbl(Me.TotalLiquido.Text) Then
            MessageBox.Show("Os valores não conferem.", "VALIDAÇÃO DE DADOS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        'se o modo de venda for orcamento anula a operação.
        If ModeloVenda.Text = "ORCAMENTO" Then
            MessageBox.Show("Esta opção só válida para Pedidos.", "VALIDAÇÃO DE DADOS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'verifica se os valores estão batendo
        If valorParcelamento <> CDbl(Me.ValorAFaturar.Text) Then
            MessageBox.Show("Os valores do parcelamento não corresponde com o Valor a Faturar.", "VALIDAÇÃO DE DADOS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim cxFechado As New CaixaFechado

        'Verifica se o caixa está ativo
        cxFechado.CaixaEstaFechado()

        'Soma os valores das parcelas
        valorParcelamento = 0
        For Each row As DataGridViewRow In Me.dgvParcelamento.Rows
            valorParcelamento += row.Cells("gValor").Value
        Next row

        If Len(CaixaAtivo) <> 4 Then
            MessageBox.Show("O usuario deve selecionar um caixa antes de Confirmar o Pedido. Verifique", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If MsgBox("Deseja Ativar o caixa agora", 36, "Validação de Dados") = 6 Then
                TRVDados(UserAtivo, "CaixaAtivarDesativar")
                If Ina = True Then
                    MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
                    Exit Sub
                Else
                    My.Forms.CaixaAtivarDesativar.ShowDialog()
                End If
            End If
        End If
        If String.IsNullOrEmpty(CaixaAtivo) Then
            Exit Sub
        End If

        'abre a tela de confirmação do pedido
        My.Forms.PedidoVendaConfirmarOS.ShowDialog()

    End Sub
    Private Sub ValorDesconto_Enter(sender As Object, e As EventArgs) Handles ValorDesconto.Enter
        If Me.dgvParcelamento.RowCount > 0 Then
            Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Else
            Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        End If
    End Sub

    Private Sub EditarItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarItemToolStripMenuItem.Click
        If Value = TagType.eEditar Or Value = TagType.eNone Then
            MessageBox.Show("Você prescisa editar  o registro primeiro", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        vEnum = Operacao.alteracao
        'verifica se foi confirmado desvia caso seja psositvo.
        If Me.status.Text = "FECHADO" Then
            MessageBox.Show("Este iten não pode mais ser editado, pois o pedido já foi confirmado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        'Identifica se tem item seleciono atraves da vareavel IDItem., caso seja negativo desvia a rotina e não executa nada.
        If Retorno = 0 Then
            MsgBox("Selecione um produto para editá-lo", 48, "Validação de dados")
            Exit Sub
        End If
        'Satifez todos os critérios acima executa as linhas abaixo.
        vEnum = Operacao.alteracao
        My.Forms.frmAdicionarItemMP.ShowDialog()
    End Sub

    Private Sub ExcluirItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcluirItemToolStripMenuItem.Click
        If Me.chkConfirmado.Checked Then
            MessageBox.Show("O pedido já foi confirmado", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Value = TagType.eEditar Or Value = TagType.eNone Then
            MessageBox.Show("Você prescisa editar  o registro primeiro", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Retorno = Me.dgvItemGeral.CurrentRow.Cells("gID").Value

        If (MessageBox.Show("Deseja excluir o item: " & dgvItemGeral.CurrentRow.Cells("gItem").Value & "?", "Validação de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = Windows.Forms.DialogResult.Yes Then
            item.Excluir(Retorno)
            item.Modelo = ModeloVenda.Text.Substring(0, 1)
            item.AtGrade(Me.NumeroPedido.Text)
        End If
        Retorno = Nothing
    End Sub

    Private Sub ExcluirTodosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExcluirTodosToolStripMenuItem1.Click
        If Value = TagType.eEditar Or Value = TagType.eNone Then
            MessageBox.Show("Você prescisa editar  o registro primeiro", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        item.Excluir(Me.NumeroPedido.Text, Me.ModeloVenda.Text.Substring(0, 1))
        item.AtGrade(Me.NumeroPedido.Text)
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim vvalue As Integer = Me.dgvReserva.CurrentRow.Cells("Codigo").Value
        Dim clR As New ReservaMP
        Retorno = Me.dgvReserva.CurrentRow.Cells(0).Value
        clR.delType = ReservaMP.eDel.One
        clR.Exluir(Retorno)
        clR.AtGrade(Me.NumeroPedido.Text)
        clR.AtSaldoReserva(vvalue)
        Retorno = 0
    End Sub
    Private Sub dgvReserva_SelectionChanged(sender As Object, e As EventArgs) Handles dgvReserva.SelectionChanged
        Try
            Retorno = Me.dgvReserva.CurrentRow.Cells(0).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Dim clR As New ReservaMP
        clR.delType = ReservaMP.eDel.All
        clR.cloneTb()
        clR.Exluir(Me.NumeroPedido.Text)
        clR.AtSaldoReservaAll()
        clR.AtGrade(Me.NumeroPedido.Text)
        Retorno = 0
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click

        If Not Me.chkConfirmado.Checked Then
            Dim cl As New ClassMP
            Retorno = Me.NumeroPedido.Text
            cl.delType = ClassMP.eDel.All
            cl.ExcluirPar(Retorno)
            atGridParcelas()
            Retorno = 0
            Me.CodigoPagamento.Enabled = True
            Me.DescricaoPagamento.Enabled = True
            Me.imgBuscaCondicao.Enabled = True
            Me.CodigoPagamento.Clear()
            Me.DescricaoPagamento.Clear()
            Value = TagType.eSalvar
            btnSalvaEditar_Click(sender, e)
        Else
            MessageBox.Show("Não é possível excluir as parcelas, este pedido já foi confirmado.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub
    Private Sub dgvParcelamento_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvParcelamento.DataError
        Try
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dgvItemGeral_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemGeral.CellClick
        Try
            Retorno = Me.dgvItemGeral.CurrentRow.Cells("gId").Value
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CodigoCliente_Enter(sender As Object, e As EventArgs) Handles CodigoCliente.Enter
        If Me.dgvItemGeral.Rows.Count > 0 Then
            Me.CodigoCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Else
            Me.CodigoCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        End If
    End Sub
    Private Sub ItemFechamento_Click(sender As Object, e As EventArgs) Handles ItemFechamento.Click
        Me.stcMP.SelectedTab = Me.ItemFechamento
        Me.DataFechamento.Focus()
        Me.DataFechamento.Text = DataDia
        Me.TotalBruto.Text = FormatCurrency(Me.TotalDosItem.Text, 2)
    End Sub
    Private Sub btnGerarPedidos_Click(sender As Object, e As EventArgs) Handles btnGerarPedidos.Click

        If Not (Me.ModeloVenda.Text) = "ORCAMENTO" Then
            MessageBox.Show("Esta função só poderá ser executado se o modelo de venda for ORÇAMENTO.", "VALIDAÇÃO DE DADOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If Me.chkGeradoPedido.Checked Then
            MessageBox.Show("Este Orçamento já foi gerado Pedido. Tente um outro orçamento.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrEmpty(CodigoCliente.Text) Or CodigoCliente.Text = "0" Then
            MessageBox.Show("O Cliente não pode ser nulo. Escolha um cliente cadastrado para processeguir.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If String.IsNullOrEmpty(Me.DataPrazo.Text) Then
            MessageBox.Show("A data de Prazo não pode ser nulo.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrEmpty(Me.Contato.Text) Then
            MessageBox.Show("O contanto não pode ser nulo.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If Me.dgvItemGeral.RowCount = 0 Then
            MessageBox.Show("Não é possível gerar um pedido deste orçamento. Está faltando itens.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If Value = TagType.eSalvar Then
            MessageBox.Show("O orçamento foi editado clique no botão salvar para processguir.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'grava um novo pedido baseado no orcamento atual
        With PMP
            .CodigoCliente = Me.CodigoCliente.Text
            .nomeCliente = Me.NomeCliente.Text
            .Telefone = Me.txttelefone.Text
            .Email = Me.txtEmail.Text
            .DataPedido = Me.DataPedido.Text
            .DataPrazoEntrega = Me.DataPrazo.Text
            .Contato = Me.Contato.Text
            .CodigoFuncionario = Me.CodigoVendedor.Text
            .Status = Me.status.Text
            .Observacao = Me.Obs.Text
            .DataFechamento = Me.DataFechamento.Text
            .ValorBordado = Me.ValorBordado.Text
            .ValorSerigrafia = Me.ValorSerigrafia.Text
            .TotalBruto = Me.TotalBruto.Text
            .TotalLiquido = Me.TotalLiquido.Text
            .Modelo = "P"
            .Empresa = CodEmpresa
            .Datavalidade = Me.DataValidade.Text
            .Gerado_pedido = Me.chkGeradoPedido.Checked
        End With
        PMP.Gravar() 'grava as alterações
        Dim var As String
        var = Retorno
        'sava os itens 
        PMP.SaveItensPedido(Me.NumeroPedido.Text)
        Value = TagType.eSalvar
        'Mostra o pedido Gerado
        PMP.OrcForPed = var
        Me.chkGeradoPedido.Checked = True


        'salva as alteraçoes 
        btnSalvaEditar_Click(sender, e)
        Value = TagType.eEditar
        'carrega o pedido gerado
        Retorno = Nothing

        lblGeradoPedido.Text = "Orçamento gerado Pedido N. " & FormatNumber(var, "000000")
        Me.lblGeradoPedido.Visible = True

    End Sub
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        RelatorioCarregar = "PedidoMP.rpt"
        Dim filtro As String = "{PedidoMateriaPrima.NumeroPedido} =" & CInt(Me.NumeroPedido.Text) & " and {PedidoMateriaPrima.Modelo} ='" & Me.ModeloVenda.Text.Substring(0, 1) & "'"
        Dim f As New ClassView.cView
        f.frm(DirRelat & RelatorioCarregar, LocalBD & Nome_BD, SenhaBancoDados, "", filtro)

    End Sub
    Private Sub dgvItemGeral_SelectionChanged(sender As Object, e As EventArgs) Handles dgvItemGeral.SelectionChanged
        Try
            Retorno = dgvItemGeral.CurrentRow.Cells("gid").Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ValorAVista_Layout(sender As Object, e As LayoutEventArgs) Handles ValorAVista.Layout

    End Sub

    Private Sub CodigoPagamento_Enter(sender As Object, e As EventArgs) Handles CodigoPagamento.Enter

    End Sub

    Private Sub btnOrdemProducao_Click(sender As Object, e As EventArgs) Handles btnOrdemProducao.Click

        If Value = TagType.eNone Or Me.dgvItemGeral.RowCount = 0 Then
            Exit Sub
        End If

        RelatorioCarregar = "OrdemProducao.rpt"
        Dim filtro As String = "{PedidoMateriaPrima.NumeroPedido} =" & CInt(Me.NumeroPedido.Text) & " and {PedidoMateriaPrima.Modelo} ='" & Me.ModeloVenda.Text.Substring(0, 1) & "'"
        Dim f As New ClassView.cView
        f.frm(DirRelat & RelatorioCarregar, LocalBD & Nome_BD, SenhaBancoDados, "", filtro)

    End Sub
End Class
