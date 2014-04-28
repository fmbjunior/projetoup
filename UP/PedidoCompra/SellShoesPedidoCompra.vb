Public Class SellShoesPedidoCompra
    Dim IdItem As Integer
    Public Ação As New TrfGerais()           'Trava os campos no form
    Dim clsPC As New clsPedidoCompra         'vareavel para implementação dos dados do pedido de compra
    Dim cls As New clsAddItemPedidoCompra    'vareavel para implementação dos ddos dos itens do pedido de compra
    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Public RetornaFechamento As Boolean 'Retorna um bolean indicado verdadeiro ou falso para o fechamento do pedido de compra
    Dim rowSoma As Double = 0
    Dim bVirtual As Boolean = False
    Dim cellValor As Double = 0
    Enum acao
        virtual = 0
        NaoVirtual = 1
    End Enum
    Private value As acao
    Private Sub butFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butFechar.Click
        'Fecha da tela do pedido de compra.
        Me.Close()
        Me.Dispose()
    End Sub

    
    Private Sub AdicionarItens_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarItens.Click
        'Adicionando item no pedido de compra. 
        If Me.txtCodigoFornecedor.Text = "" Then
            Exit Sub
        End If

        If String.IsNullOrEmpty(Me.CodigoFuncionario.Text) Then
            MsgBox("O codigo do funcionário não pode ser nulo", MsgBoxStyle.Information, "Validação de dados")
            Return
        End If
        'Se o enumerado for INS vai fazer o salvemento do pedido pela 1ª vez
        'para inserir os itens.
        If Operation = INS Then
            'repassa os valores dos campos para a classe
            With clsPC
                .CodigoFornecedor = Me.txtCodigoFornecedor.Text
                .Observacao = Me.Obs.Text
                .CodigoFuncionario = Me.CodigoFuncionario.Text
                .DataLancamento = Me.txtDataLancamento.Text
                .DataPrevista = Me.txtDataPrevista.Text
                .Status = Me.lblStatus.Text
            End With

            clsPC.Gravar() 'grava o pedidos
            Me.CodigoPedidoCompra.Text = clsPC.Retorno.ToString.PadLeft(5, "0")
            Operation = UPD ' muda o enumerados para editar
            Me.butSalvarEditar.Text = "Editar" 'altera o caption do botão salvar
            Ação.Desbloquear_Controle(Me, False) 'bloqueia os campos
            SellShoesPedidoCompraAddItem.ShowDialog()   'chama a tela de adicionar produtos.
        Else
            SellShoesPedidoCompraAddItem.ShowDialog()   'chama a tela de adicionar produtos.
        End If

        If Me.dgv.RowCount = 0 Then
            Me.butIniciarFechamento.Enabled = False
        Else
            Me.butIniciarFechamento.Enabled = True
        End If
        Me.butImprimir.Enabled = True
    End Sub

    Private Sub butNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butNovo.Click
        Ação.Desbloquear_Controle(Me, True)
        Ação.LimpaTextBox(Me)
        cls.AtGrade(0)
        AchaParcelamento(0)
        Me.butSalvarEditar.Text = "Salvar"
        Me.txtCodigoFornecedor.Focus()
        Operation = INS
        Me.txtDataLancamento.Text = DataDia
        Me.AdicionarItens.Enabled = True
        Me.butSalvarEditar.Enabled = True
        Me.butLocalizar.Enabled = True
        Me.Confirmado.Checked = False
        Me.ConfImg.Visible = False
        If Me.dgv2.RowCount > 0 Then
            dgv2.Rows.Clear()
        End If
        Me.lblStatus.Text = "EM ANDAMENTO"
        Me.lblStatus.ForeColor = Color.Green
    End Sub

    Private Sub SellShoesPedidoCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ação.Desbloquear_Controle(Me, False)
        Me.butLocalizar.Enabled = True
    End Sub

    Private Sub txtCodigoFornecedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoFornecedor.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.TelaProcuraFor.ShowDialog()
            Me.Obs.Focus()

        End If
    End Sub
    Public Sub LocalizaFornecedor()
        If Me.txtCodigoFornecedor.Text = "" Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT CódigoFornecedor,RazãoSocial FROM Fornecedor WHERE CódigoFornecedor=" & Me.txtCodigoFornecedor.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        Try
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Me.txtRazaoSocial.Text = DR.Item("RazãoSocial") & ""
            Else
                MsgBox("Verifique os dados do fornecedor, ou fornecedor não existe no cadastro.", 64, "Validador de Dados")
                Me.txtCodigoFornecedor.Clear()
                Me.txtRazaoSocial.Clear()
                Me.txtCodigoFornecedor.Focus()
                Return
            End If
            DR.Close()
            CNN.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try
    End Sub

    Private Sub txtCodigoFornecedor_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoFornecedor.Leave
        LocalizaFornecedor()
    End Sub

    Private Sub CodigoFuncionario_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoFuncionario.KeyDown
        If e.KeyCode = Keys.F5 Then
            ChamaTelaProcura("Codigo", "Nome", "", "Funcionários", "CódigoFuncionário", "Nome", "", False)
            Me.CodigoFuncionario.Text = RetornoProcura
            Ação.Descrição_ItenRegistro(Me.CodigoFuncionario, Me.FuncionarioDesc, "Funcionários", "CódigoFuncionário", Me.CodigoFuncionario.Text, "Nome", TrfGerais.TipoDados.Numérico, False)
        End If
    End Sub

    Private Sub CodigoFuncionario_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CodigoFuncionario.Leave
        If Me.CodigoFuncionario.TextoAntigo <> Me.CodigoFuncionario.Text Then
            Ação.Descrição_ItenRegistro(Me.CodigoFuncionario, Me.FuncionarioDesc, "Funcionários", "CódigoFuncionário", Me.CodigoFuncionario.Text, "Nome", TrfGerais.TipoDados.Numérico, False)
        End If
    End Sub

    Private Sub butSalvarEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSalvarEditar.Click
        If Me.butSalvarEditar.Text = "Editar" Then
            Ação.Desbloquear_Controle(Me, True)
            Operation = UPD
            Me.butSalvarEditar.Text = "Salvar"
            Me.butLocalizar.Enabled = False
            Me.butImprimir.Enabled = False
            Me.butIniciarFechamento.Enabled = True
            Exit Sub
        End If

        If Me.txtCodigoFornecedor.Text = "" Then
            Exit Sub
        End If
        With clsPC
            .CodigoFornecedor = Me.txtCodigoFornecedor.Text
            .Observacao = Me.Obs.Text
            .CodigoFuncionario = Me.CodigoFuncionario.Text
            .DataLancamento = Me.txtDataLancamento.Text
            .DataPrevista = Me.txtDataPrevista.Text
            .TotalPedido = Me.TotalItensLançado.Text
            .Status = Me.lblStatus.Text
        End With
        If Operation = INS Then
            clsPC.Gravar()
            Me.CodigoPedidoCompra.Text = clsPC.Retorno
            Operation = UPD
            Me.butSalvarEditar.Text = "Editar"
            Ação.Desbloquear_Controle(Me, False)
        ElseIf Operation = UPD Then
            clsPC.Editar(Me.CodigoPedidoCompra.Text)
            Ação.Desbloquear_Controle(Me, False)
            Me.butSalvarEditar.Text = "Editar"
            Me.butLocalizar.Enabled = True
            Me.butImprimir.Enabled = False

            If Me.dgv.RowCount > 0 Then
                Me.butIniciarFechamento.Enabled = True
            Else
                Me.butIniciarFechamento.Enabled = False
            End If

        End If
        MessageBox.Show("Registro gravado com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub txtDataPrevista_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDataPrevista.Leave
        'Move o foco para o botão add item n
        Me.AdicionarItens.Focus()
    End Sub

    Private Sub dgv_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellClick
        'Quando for clicado em qualquer celula passa o valor da linha ID atual para a vareavel IDITEM.
        IdItem = Me.dgv.CurrentRow.Cells("IDp").Value
    End Sub

    Private Sub dgv_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgv.SelectionChanged
        'toda a vez que existir uma atualização no grid o mesmo é seleciona na primeira linha.
        Try
            IdItem = Me.dgv.CurrentRow.Cells("IDp").Value

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        'verifica se foi confirmado desvia caso seja psositvo.
        If Me.Confirmado.Checked = True Then
            MessageBox.Show("Este iten não pode mais ser editado, pois o pedido já foi confirmado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        'Identifica se tem item seleciono atraves da vareavel IDItem., caso seja negativo desvia a rotina e não executa nada.
        If IdItem = 0 Then
            MsgBox("Selecione um produto para editá-lo", 48, "Validação de dados")
            Exit Sub
        End If
        'Satifez todos os critérios acima executa as linhas abaixo.
        SellShoesPedidoCompraAddItem.Id.Text = IdItem
        SellShoesPedidoCompraAddItem.LocalizaItens()
        SellShoesPedidoCompraAddItem.butNovo.Enabled = False
        SellShoesPedidoCompraAddItem.ShowDialog()

    End Sub
    Sub CreateCol()
        'Aqui definimos as nossa datagridview.
        Dim col As DataGridViewTextBoxColumn 'Importa a coluna textbox

        'Definir alguma propriedades da coluna TextBox
        col = New DataGridViewTextBoxColumn()
        col.HeaderText = "id"
        col.Name = "id"
        col.Width = 70
        col.Visible = False
        Me.dgv2.Columns.Add(col)

        col = New DataGridViewTextBoxColumn()
        col.HeaderText = "NF"
        col.Name = "nf"
        col.Width = 100
        Me.dgv2.Columns.Add(col)

        col = New DataGridViewTextBoxColumn()
        col.HeaderText = "Data Lanç."
        col.Name = "datalancamento"
        col.Width = 100
        Me.dgv2.Columns.Add(col)

        col = New DataGridViewTextBoxColumn()
        col.HeaderText = "Status"
        col.Name = "status"
        col.Width = 100
        Me.dgv2.Columns.Add(col)

       
    End Sub
    'usado para preencher do datagridvie dgv2 para as notas lançada.
    Private Sub EncheGrid()

        If Me.dgv2.RowCount > 0 Then
            dgv2.Rows.Clear()
        End If
        If dgv2.Columns.Count = 0 Then
            CreateCol()
        End If
        Dim strStatus As String = String.Empty

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT CompraInterno, NotaFiscal, Datalançamento,Confirmado,Inativo  FROM compra Where PedidoCompra=" & Me.CodigoPedidoCompra.Text

        Dim ocmd As New OleDb.OleDbCommand(Sql, CNN)

        Dim odr As OleDb.OleDbDataReader
        odr = ocmd.ExecuteReader

        Dim row As New DataGridViewRow
        Dim cVlr As Double = 0
        While odr.Read()
            If odr.Item("Confirmado") = True And odr.Item("inativo") = False Then
                strStatus = "CONFIRMADO"
            ElseIf odr.Item("inativo") = True Then
                strStatus = "CANCELADO"
            ElseIf odr.Item("Confirmado") = False And odr.Item("inativo") = False Then
                strStatus = "ABERTO"
            End If

            'preenche o grid com alguns dados
            Dim row0 As String() = {odr.Item("CompraInterno"), odr.Item("NotaFiscal"), odr.Item("datalançamento"), strStatus}
            'adiciona as linhas
            With Me.dgv2.Rows
                .Add(row0)
            End With
        End While
    End Sub
    Private Sub butLocalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butLocalizar.Click
        RetornoProcura = 0
        SellShoesPedidoCompraProcurar.ShowDialog()
        Try


            If RetornoProcura > 0 Then
                Operation = UPD
                Ação.Desbloquear_Controle(Me, False)

                clsPC.Localizar(RetornoProcura)
                With clsPC
                    Me.CodigoPedidoCompra.Text = .CodigoPedidoCompra
                    Me.txtCodigoFornecedor.Text = .CodigoFornecedor
                    Me.txtRazaoSocial.Text = .NomeFornecedor
                    Me.Obs.Text = .Observacao
                    Me.txtDataLancamento.Text = .DataLancamento
                    Me.txtDataPrevista.Text = .DataPrevista
                    Me.CodigoFuncionario.Text = .CodigoFuncionario
                    Me.FuncionarioDesc.Text = .NomeFuncionario
                    Me.Confirmado.Checked = .Confirmado
                    Me.Inativo.Checked = .Inativo
                    Me.lblStatus.Text = .Status

                End With
                cls.DgvCustom = Me.dgv
                cls.AtGrade(Me.CodigoPedidoCompra.Text)
                EncheGrid() 'Atualiza o datagrid
                AchaParcelamento(Me.CodigoPedidoCompra.Text) 'Atualiza o grid de parcelamento na Aba "Outras Informações".
                

                If Me.Confirmado.Checked = False Then
                    Me.butSalvarEditar.Text = "Editar"
                    Me.butSalvarEditar.Enabled = True
                    Me.butImprimir.Enabled = True
                    Me.butIniciarFechamento.Enabled = True
                    Me.AdicionarItens.Enabled = True
                    Me.butCancelar.Enabled = True
                    Me.ConfImg.Visible = False
                    Me.lblStatus.ForeColor = Color.Green
                Else
                    Me.ConfImg.Visible = True
                    Me.ConfImg.Text = "Pedido Confirmado"
                    Me.butIniciarFechamento.Enabled = False
                    Me.butSalvarEditar.Enabled = False
                    Me.AdicionarItens.Enabled = False
                    Me.butCancelar.Enabled = True
                    Me.butImprimir.Enabled = True
                    If Me.lblStatus.Text = "FINALIZADO" Then
                        Me.lblStatus.ForeColor = Color.Red
                    Else
                        Me.lblStatus.ForeColor = Color.Green
                    End If
                End If

                If Me.Inativo.Checked = True Then
                    Me.ConfImg.Visible = True
                    Me.ConfImg.Text = "Cancelado"
                    Me.butIniciarFechamento.Enabled = False
                    Me.butSalvarEditar.Enabled = False
                    Me.AdicionarItens.Enabled = False
                    Me.butCancelar.Enabled = False
                    Me.lblStatus.Text = "FINALIZADO"
                    Me.lblStatus.ForeColor = Color.Red

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try
    End Sub

    Private Sub butImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butImprimir.Click

        If Me.dgv.Rows.Count = 0 Then
            Return
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()
        Try
            Dim oDA As New OleDb.OleDbDataAdapter("Select * from Empresa", CNN)
            Dim oDs As New DataSet
            oDA.Fill(oDs, "Empresa")

            Dim rpt As New RelPedidocompra
            rpt.TextBox1.Text = oDs.Tables(0).Rows(0).Item("RazãoSocial")

            ViewReport.VerRelat.Document = rpt.Document
            rpt.Run()
            ViewReport.ShowDialog()

        Catch ex As Exception
            Throw ex

        End Try

    End Sub

    Private Sub ExcluirOItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirOItemToolStripMenuItem.Click

        If Me.ConfImg.Visible = True Then
            MsgBox("O pedido já foi confirmado e não poderá ser editado", 48, "validadção de dados")
            Return
        End If

        'Faz uma pergunta antes, para que o user tenha certeza da ação.
        If MessageBox.Show("Deseja excluir o Item selecionado", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            cls.Excluir(IdItem)
            cls.AtGrade(Me.CodigoPedidoCompra.Text)
            MessageBox.Show("Registro excluído com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butIniciarFechamento.Click

        'Confirma o pedido e lança um valor virtual no contas a pagar.
        If MessageBox.Show("Deseja confirmar o Pedido de Compra agora?", "Confirmação do Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            With clsPC
                .CodigoPedidoCompra = Me.CodigoPedidoCompra.Text
                .CodigoFornecedor = Me.txtCodigoFornecedor.Text
                .NomeFornecedor = Me.txtRazaoSocial.Text
                .Observacao = Me.Obs.Text
                .CodigoFuncionario = Me.CodigoFuncionario.Text
                .DataLancamento = Me.txtDataLancamento.Text
                .DataPrevista = Me.txtDataPrevista.Text
                .TotalPedido = Me.TotalItensLançado.Text
                .Confirmado = True
            End With


            clsPC.ConfirmarPedido(Me.CodigoPedidoCompra.Text)
            If clsPC.RetornaErro = True Then
                MessageBox.Show("Houve um erro e não foi possível confirmar o pedido, contate o suporte", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Me.Ação.Desbloquear_Controle(Me, False)
            Me.ConfImg.Visible = True
            Me.ConfImg.Text = "Lançamento Confirmado"
            Me.Inativo.Checked = True
            Me.butSalvarEditar.Enabled = False
            Me.AdicionarItens.Enabled = False
            Me.butNovo.Focus()
            Me.butIniciarFechamento.Enabled = False
            AchaParcelamento(Me.CodigoPedidoCompra.Text)
        End If

    End Sub

    Private Sub butCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCancelar.Click
        Try

            If clsPC.verStatusNF(Me.CodigoPedidoCompra.Text) = True Then
                MsgBox("Existem notas lançadas para este pedido de compra." & Chr(13) & "------" & Chr(13) & "DICA:" & Chr(13) & "------" & Chr(13) & "Cancele primeiro as notas e depois cancele o pedido de compra.", 48, "Validação de dados")
                Return
            End If


            If Me.Inativo.Checked = True Then
                Return
            End If



            If Me.Confirmado.Checked = True Then

                Dim HH As DateTime = Now
                Dim CodSegurança As String = InformaCodigoSeguranca()

                If VerificaCodigoSegurança(CodSegurança) = False Then
                    MsgBox("Código de Segurança inválido, Verifique.", 64, "Validação de Dados")
                    Exit Sub
                End If

                Dim Motivo As String = ""
                Motivo = InputBox("Informe o motivo para inativar a nota fiscal de compra.", "Validação de Dados")
                If Motivo = "" Then
                    MsgBox("Não foi informado o motivo, o pedido de compra não será cancelado.", 48, "Validação de Dados")
                    Exit Sub
                End If


                'verifica se existe contas a pagar para este documento e se ja existe alguma baixa foram baixadas
                Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
                CNN.Open()
                Dim myTrans As OleDb.OleDbTransaction = CNN.BeginTransaction

                Dim sSql As String = String.Empty

                sSql = "Select Pagar.IdPedidoCompra, Pagar.Baixado From Pagar Where Pagar.IdPedidoCompra = " & Me.CodigoPedidoCompra.Text & " and Pagar.Baixado = True"
                Dim Ccmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sSql, CNN, myTrans)
                Dim oDR As OleDb.OleDbDataReader
                oDR = Ccmd.ExecuteReader

                If oDR.HasRows Then
                    MsgBox("Este documento possui contas relacionada que já foram pagas, o documento não pode ser cancelado.", 48, "Validação de Dados")
                    oDR.Close()
                    Ccmd = Nothing
                    sSql = Nothing
                    myTrans.Rollback()
                    CNN.Close()
                    Return
                End If

                'Deleta contas relacionadas
                sSql = "Delete * From Pagar Where IdPedidoCompra = " & Me.CodigoPedidoCompra.Text
                Ccmd = New OleDb.OleDbCommand(sSql, CNN, myTrans)


                Dim Sql As String = "Update PedidoCompra set Inativo = @1, Obs = @2 Where CodigoPedidoCompra = " & Me.CodigoPedidoCompra.Text
                Dim cmd As New OleDb.OleDbCommand(Sql, CNN, myTrans)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@1", True))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@2", "Inativado por: " & "UserAtivo & Autorizado por: " & Motivo))

                Try
                    Ccmd.ExecuteNonQuery()
                    cmd.ExecuteNonQuery()
                    myTrans.Commit()

                    'Fim do cancelamento da compra

                    MsgBox("Pedido de Compra inativado com sucesso", 64, "Validador de Dados")
                    Ação.Desbloquear_Controle(Me, False)

                    Me.Close()
                    Me.Dispose()

                Catch x As Exception
                    MsgBox(x.Message)
                    myTrans.Rollback()
                Finally
                    CNN.Close()
                End Try
            Else '

                MsgBox("Este Pedido de Compra não precisa ser inativado, pois o mesmo ainda não foi confirmado", 64, "Validador de Dados")

            End If

        Catch vex As Exception
            MsgBox(vex.Message)
        End Try

    End Sub

    Private Sub txtDataPrevista_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDataPrevista.Validated
        If Me.txtDataPrevista.Text = "" Then
            MsgBox("A data prevista não pode ser nula", 48, "Validadção de dados")
            Me.txtDataPrevista.Focus()
            Return
        End If

        Dim data1, data2 As DateTime
        Dim days As Integer
        Dim ts As TimeSpan
        data1 = CDate(Me.txtDataLancamento.Text)
        data2 = CDate(Me.txtDataPrevista.Text)
        ts = data2.Subtract(data1)
        days = ts.Days

        If days < 0 Then
            MsgBox("A data prevista não pode ser menor que a data de lançamento", 48, "Validadção de dados")
            Me.txtDataPrevista.Focus()
            Return
        End If

    End Sub

    Private Sub SellShoesPedidoCompra_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Me.Confirmado.Checked = False Then
            If e.KeyCode = Keys.F7 Then
                If Operation = UPD Then
                    Me.TabGeral.SelectedTab = Me.TabItens
                    AdicionarItens_Click(sender, e)
                    Me.butSalvarEditar.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub AchaParcelamento(ByVal xid As Integer)
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT id,Documento,ValorDocumento,Vencimento,LocalPgto  FROM Pagar Where IdPedidoCompra=" & xid & " Order by id"

        Dim objDA As New OleDb.OleDbDataAdapter(Sql, CNN)
        Dim ds As New DataSet
        objDA.Fill(ds, "Pagar")

        Me.ListaPagar.DataSource = ds.Tables("Pagar")
    End Sub
    Private Sub txtCodigoFornecedor_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoFornecedor.Validated
        If String.IsNullOrEmpty(Me.txtCodigoFornecedor.Text) Then
            Me.txtRazaoSocial.Clear()
        End If
    End Sub
    Private Sub btnEncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncerrar.Click
        If Me.lblStatus.Text = "EM ANDAMENTO" And Me.ConfImg.Visible = False Then
            MessageBox.Show("Este pedido não pode ser FINALIZADO. Confirme o pedido primeiro", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf Me.lblStatus.Text = "FINALIZADO" And Me.Confirmado.Checked = True Then
            MessageBox.Show("Este pedido não pode ser FINALIZADO.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End If



        If MessageBox.Show("Atenção:: O status do pedido de compra mudará para 'FINALIZADO', e não será mais possível fazer Lançamento de Pagamentos e Lançamento de NF." & Chr(13) & "Deseja continular?", "Finalizando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            Dim myTrans As OleDb.OleDbTransaction
            CNN.Open()
            myTrans = CNN.BeginTransaction
            Try

                'execute o código.
                clsPC.UpdStatusPedido(Me.CodigoPedidoCompra.Text, "FINALIZADO")
                Me.lblStatus.Text = "FINALIZADO"



                Dim Sql As String
                Sql = "Delete * from Pagar where Virtual=True And IDPedidoCompra=" & Me.CodigoPedidoCompra.Text

                Dim cmd As New OleDb.OleDbCommand(Sql, CNN, myTrans)

                cmd.ExecuteNonQuery()
                myTrans.Commit()
            Catch ex As Exception
                MsgBox(ex.Message)
                myTrans.Rollback()
            Finally
                CNN.Close()
            End Try
        End If

    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click

        'Faz uma pergunta antes, para que o user tenha certeza da ação.
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Me.lblStatus.Text = "FINALIZADO" And Me.Confirmado.Checked = True Then
            If MessageBox.Show("Deseja excluir o a parcela virutal?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Try
                    CNN.Open()

                    Dim Sql As String
                    Sql = "Delete * from Pagar where Virtual=True And IDPedidoCompra=" & Me.CodigoPedidoCompra.Text

                    Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

                    cmd.ExecuteNonQuery()
                    CNN.Close()
                    AchaParcelamento(Me.CodigoPedidoCompra.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)

                Finally
                    CNN.Close()
                End Try
            End If
        Else
            MessageBox.Show("O Pedido deve estar [CONFIRMADO]; e seu Status [FINALIZADO].", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub ExcluirParcelaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirParcelaToolStripMenuItem.Click
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Try
            CNN.Open()

            Dim cmd As New OleDb.OleDbCommand("Delete * from Pagar where virtual=False and ID=" & CInt(RetornoProcura), CNN)
            Dim rowAff As Integer
            rowAff = cmd.ExecuteNonQuery()
            If rowAff > 0 Then
                Dim cmd1 As New OleDb.OleDbCommand("UPDATE Pagar SET ValorDocumento = [valordocumento]+ '" & cellValor & "' WHERE Virtual=True AND IDPedidoCompra=" & Me.CodigoPedidoCompra.Text, CNN)
                cmd1.ExecuteNonQuery()
            End If
            CNN.Close()
            AchaParcelamento(Me.CodigoPedidoCompra.Text)
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            CNN.Close()
        End Try
    End Sub

    Private Sub ListaPagar_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListaPagar.CellClick
        Try
            RetornoProcura = Me.ListaPagar.CurrentRow.Cells("id").Value
            cellValor = Me.ListaPagar.CurrentRow.Cells("gValor").Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ListaPagar_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaPagar.SelectionChanged
        Try
            RetornoProcura = Me.ListaPagar.CurrentRow.Cells("id").Value
            cellValor = Me.ListaPagar.CurrentRow.Cells("gValor").Value
        Catch ex As Exception

        End Try
    End Sub
End Class