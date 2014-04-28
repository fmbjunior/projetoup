Imports System.Data.OleDb
Imports System.IO.Ports

Public Class PedidoAddItemOS

    Dim Ação As New TrfGerais
    Dim xx As New PedidoOS

    Dim comp As String
    Dim DescontoMaximo As Double = 0
    Dim DescontoVarejo As Double = 0
    Dim DescontoAtacado As Double = 0

    Dim TipoVenda As String = ""
    Dim EstoqueEstaNegativo As Boolean
    Dim v_ValorUnitario As Double

    Dim QtdEstoqueTela As Double
    Dim QtdEstoqueEdição As Double

    Dim CrtlEstIten As String = "N"
    Dim QtdEstoqueTemp As Double

    Dim TipoItem As Integer

    Public OperationItens As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2
    Dim Desc As Double = 0

    Public Sub LimparItens()

        If DescontoEmLinha = True Then
            Me.Desconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Else
            Me.Desconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        End If

    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub CodigoProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoProduto.KeyDown
        If e.KeyCode = Keys.F5 Then
            If Me.CodigoProduto.Text = "" Then
                My.Forms.ProcuraProduto.ShowDialog()
                LocalizaProduto()
            End If
        End If

    End Sub
    Private Sub EditaIten()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT ItensPedido.*, Grupos.Descrição FROM ItensPedido LEFT JOIN Grupos ON ItensPedido.Grupo = Grupos.CódigoGrupo WHERE Id=" & RetornoProcura & ""
        '"Select * from ItensPedido where Id = " & RetornoProcura
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        Me.Id.Text = DR.Item("Id") & ""
        Me.CodigoProduto.Text = DR.Item("CodigoProduto") & ""
        Me.Qtd.Text = FormatNumber(Nz(DR.Item("Qtd"), 3), 2)
        Me.ValorUnitario.Text = FormatNumber(Nz(DR.Item("ValorUnitario"), 3), 2)
        Me.Desconto.Text = FormatNumber(Nz(DR.Item("Desconto"), 3), 2)
        Me.ValorDesconto.Text = FormatNumber(Nz(DR.Item("ValorDesconto"), 3), 2)
        Me.TotalProduto.Text = FormatNumber(Nz(DR.Item("TotalProduto"), 3), 2)
        Me.Ipi.Text = FormatNumber(Nz(DR.Item("Ipi"), 3), 2)
        Me.ValorIpi.Text = FormatNumber(Nz(DR.Item("ValorIpi"), 3), 2)


        Me.CustoMercadoriaVendida.Text = FormatNumber(NzZero(DR.Item("CustoMercadoriaVendida")), 2)

        Me.Grupo_Preencher(Me.Grupo)
        Try

            Me.Grupo.SelectedIndex = Me.Grupo.FindStringExact(DR.Item("Descrição") & "")
        Catch ex As Exception
        End Try
        Me.Grupo_Preencher(Me.Grupo)

        Me.LocalizaProduto() 'para poder complementar os dados como a descrição 

        DR.Close()

        Me.CodigoProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ProdutoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Qtd.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorUnitario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não

        Me.Desconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        If DescontoEmLinha = True Then
            Me.Desconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Else
            Me.Desconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        End If

        Me.TotalProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Ipi.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorIpi.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Grupo.Enabled = True

        Me.CodigoProduto.Focus()

    End Sub

    Public Sub LocalizaProduto()
        If Me.ValorUnitario.Text = "" Then Me.ValorUnitario.Text = FormatNumber(0, 2)
        If Me.CodigoProduto.Text = "" Then
            Exit Sub
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Produtos where CodigoProduto = " & Me.CodigoProduto.Text & " And Inativo = False and Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows = True Then

            If DR.Item("ControlaEstoque") = "NÃO" Then
                If MessageBox.Show("Produto selecionado não controla estoque, deseja continuar.", "Validação de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                    Me.CodigoProduto.Clear()
                    Me.CodigoProduto.Focus()
                    Exit Sub
                End If
            End If

            Me.ProdutoDesc.Text = DR.Item("Descrição") & ""
            DescontoVarejo = NzZero(DR.Item("DescVarejo"))
            DescontoAtacado = NzZero(DR.Item("DescAtacado"))

            If Me.Ipi.Text = "" Then Me.Ipi.Text = DR.Item("ipi") & ""

            ''Me.ValorUnitario.Text = NzZero(DR.Item("ValorVenda"))

            If My.Forms.PedidoOS.TpComercio.Text = "ATACADO" Then
                If Me.ValorUnitario.Text = 0 Then Me.ValorUnitario.Text = FormatNumber(Nz(DR.Item("ValorVendaAtacado"), 3), 2)
                v_ValorUnitario = NzZero(DR.Item("ValorVendaAtacado"))
                Me.ValorUnitario.Text = FormatCurrency(v_ValorUnitario, 4)
            Else
                If Me.ValorUnitario.Text = 0 Then Me.ValorUnitario.Text = FormatNumber(Nz(DR.Item("ValorVenda"), 3), 2)
                v_ValorUnitario = NzZero(DR.Item("ValorVenda"))
                Me.ValorUnitario.Text = FormatCurrency(v_ValorUnitario, 4)
            End If

            Me.CustoMercadoriaVendidaUnitario.Text = NzZero(DR.Item("ValorCompra"))

            CrtlEstIten = DR.Item("ControlaEstoque") & ""

            'If Me.ValorUnitario.Text = 0 Then Me.ValorUnitario.Text = FormatNumber(Nz(DR.Item("ValorVenda"), 3), 2)
            DescontoMaximo = Nz(DR.Item("DescontoMaximo"), 3)
            If NzZero(Me.Multiplos.Text) = 0 Then Me.Multiplos.Text = NzZero(DR.Item("Multiplos"))

            If NzZero(DR.Item("QuantidadeEstoque")) <= 0 Then
                EstoqueEstaNegativo = True
                QtdEstoqueTemp = NzZero(DR.Item("QuantidadeEstoque"))
            Else
                EstoqueEstaNegativo = False
                QtdEstoqueTemp = NzZero(DR.Item("QuantidadeEstoque"))
            End If

            TipoItem = NzZero(DR.Item("Tipo"))

            If DR.Item("Tipo") = 99 Then 'veririca se o cadastro do produto é do tipo serviço
                Me.Ipi.Enabled = False
                Me.ValorIpi.Enabled = False
                Me.Ipi.Text = FormatNumber(0, 2)
                Me.ValorIpi.Text = FormatNumber(0, 2)
            End If

        Else
            MsgBox("Item não encontrado, verifique....", 64, "Validação de Dados")
            Me.CodigoProduto.Focus()
            CNN.Close()
            Exit Sub
        End If
        CNN.Close()
        'DR.Close()

    End Sub

    Private Sub AddItemPedido_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If OperationItens = UPD Then

            EditaIten()
            Grupo_Preencher(Grupo)
            Me.CodigoProduto.Focus()

        Else
            Ação.LimpaTextBox(Me)

            Grupo_Preencher(Me.Grupo)

            Me.CodigoProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.ProdutoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.Qtd.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.ValorUnitario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não

            Me.Desconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            If DescontoEmLinha = True Then
                Me.Desconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Else
                Me.Desconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            End If

            Me.TotalProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.Ipi.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.ValorIpi.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.Grupo.Enabled = True
            Me.CodigoProduto.Focus()
        End If
    End Sub

    Private Sub btAdItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdItem.Click

        'Area destinada para as validacoes

        If Me.CodigoProduto.Text = "" Then
            MsgBox("O Produto não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.CodigoProduto.Focus()
            Exit Sub
        ElseIf Me.Qtd.Text = "" Then
            MsgBox("A Quantidade não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Qtd.Focus()
            Exit Sub
        ElseIf Me.ValorUnitario.Text = "" Then
            MsgBox("O Valor Unitário não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.ValorUnitario.Focus()
            Exit Sub
        ElseIf Me.TotalProduto.Text = "" Then
            MsgBox("O total do produto não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.TotalProduto.Focus()
            Exit Sub
        ElseIf Me.Desconto.Text = "" Then
            Me.Desconto.Text = 0
            Exit Sub
        ElseIf Me.ValorDesconto.Text = "" Then
            Me.ValorDesconto.Text = FormatCurrency(0, 2)
            Exit Sub
        ElseIf Me.Ipi.Text = "" Then
            Me.Ipi.Text = "0"
        ElseIf Me.ValorIpi.Text = "" Then
            Me.ValorIpi.Text = FormatCurrency(0, 2)

        End If

        If NzZero(Me.ValorUnitario.Text) = 0 Then
            MessageBox.Show("O Valor Unitário do Produto não pode ser [00,00], Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ValorUnitario.Focus()
            Exit Sub
        End If

        'If Me.Multiplos.Text = 0 Then
        '    MessageBox.Show("Este produto não tem a quantidade multiplos de venda, Verifique o Cadastro do Produto.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        Me.CustoMercadoriaVendida.Text = CDbl(NzZero(Me.CustoMercadoriaVendidaUnitario.Text)) * CDbl(NzZero(Me.Qtd.Text))
        'Fim da Area destinada para as validacoes

        'Validação de saida de Estoque
        Dim est As Double = FormatNumber(CDbl(QtdEstoqueTemp), 4)
        Dim ven As Double = FormatNumber(CDbl(Me.Qtd.Text), 4)

        If VenderEstoqueNegativo = False Then
            If CrtlEstIten = "SIM" Then
                If ven > est Then
                    MsgBox("Estoque Atual   : " & FormatNumber(CDbl(Me.QtdEstoqueTemp), 4) & Chr(13) & "Sendo Vendido : " & FormatNumber(CDbl(Me.Qtd.Text), 4) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & "O Usuário não pode verder estoque negativo deste produto.", 64, "Validação de Dados")
                    Me.CodigoProduto.Focus()
                    Exit Sub
                End If
            End If
        End If
        'Finaliza Aqui


        If My.Forms.PedidoOS.UsarLimite.Checked = True Then
            Dim DiferencaLimite As Double = NzZero(My.Forms.PedidoOS.SaldoLimiteCredito.Text) - NzZero(My.Forms.PedidoOS.TotalPedido.Text)
            If Me.TotalProduto.Text > DiferencaLimite Then
                MessageBox.Show("Este Produto ultrapassa o valor do Limite do cliente, favor escolher outro ou diminua a quantidade", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Ação.LimpaTextBox(Me)
                Me.CodigoProduto.Focus()
                Exit Sub
            End If
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If OperationItens = INS Then
            CNN.Open()
            Dim Sql As String = "INSERT INTO ItensPedido ( CodigoProduto, Qtd, ValorUnitario, Desconto,ValorDesconto, TotalProduto, Ipi, ValorIpi, Grupo, PedidoSequencia, PedidoInterno, CustoMercadoriaVendida, UserSenhaDesconto, Multiplos, Numero) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CodigoProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Qtd.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.ValorUnitario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Desconto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.ValorDesconto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.TotalProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Ipi.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", NzZero(Me.ValorIpi.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzVlr(PegaVlrCombo(Me.Grupo, TpRetornoCBO.Não))))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", NzVlr(My.Forms.PedidoOS.PedidoSequencia.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", NzVlr(My.Forms.PedidoOS.PedidoInterno)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", NzVlr(Me.CustoMercadoriaVendida.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", NzVlr(Me.UserSenhaDesconto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", NzZero(Me.Multiplos.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", "0000000000"))


            Try
                cmd.ExecuteNonQuery()

                OperationItens = INS
                CNN.Close()
                Me.CodigoProduto.Focus()
                Ação.LimpaTextBox(Me)
                My.Forms.PedidoOS.EncheListaItens()
                LimparItens()
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Adicionou, Me.CodigoProduto.Text)
                CNN.Close()
            End Try

        ElseIf OperationItens = UPD Then
            CNN.Open()
            Dim Sql As String = "Update ItensPedido set CodigoProduto = @1, Qtd = @2, ValorUnitario = @3, Desconto = @4, ValorDesconto = @5, TotalProduto = @6, Ipi = @7, ValorIpi = @8, Grupo = @9, PedidoSequencia = @10, PedidoInterno = @11, CustoMercadoriaVendida = @12, UserSenhaDesconto = @13, Multiplos = @14, Numero = @15 Where Id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CodigoProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Qtd.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.ValorUnitario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Desconto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.ValorDesconto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.TotalProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Ipi.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.ValorIpi.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzVlr(PegaVlrCombo(Me.Grupo, TpRetornoCBO.Não))))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", NzVlr(My.Forms.PedidoOS.PedidoSequencia.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", NzVlr(My.Forms.PedidoOS.PedidoInterno)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", NzVlr(Me.CustoMercadoriaVendida.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", NzVlr(Me.UserSenhaDesconto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", NzZero(Me.Multiplos.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", "0000000000"))

            Try
                cmd.ExecuteNonQuery()
                OperationItens = INS
                CNN.Close()
                My.Forms.PedidoOS.EncheListaItens()
                Me.CodigoProduto.Focus()
                Ação.LimpaTextBox(Me)
                LimparItens()
            Catch x As Exception
                CNN.Close()
                MsgBox(x.Message)
                GerarLog(Me.Text, AçãoTP.Editou, Me.CodigoProduto.Text)
                Exit Sub
            End Try
        End If

        Ação.LimpaTextBox(Me)
        Me.Grupo.Text = ""
        Me.ValorUnitario.Text = "0,00"
        Me.CodigoProduto.Focus()
    End Sub

    Private Sub TotalProduto_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TotalProduto.Enter
        If Me.Qtd.Text = "" Then
            Me.Qtd.Focus()
            Exit Sub
        End If

        If Me.ValorUnitario.Text = "" Then Me.ValorUnitario.Focus()
        If Me.Desconto.Text = "" Then Me.Desconto.Text = FormatNumber(0, 2)
        ' Me.ValorDesconto.Text = FormatCurrency(CDbl(Me.ValorUnitario.Text) * CDbl(Me.Qtd.Text) * CDbl(Me.Desconto.Text) / 100, 2)

        Me.TotalProduto.Text = FormatNumber((CDbl(NzZero(Me.ValorUnitario.Text)) * CDbl(NzZero(Me.Qtd.Text))), 3)
        Me.ValorIpi.Text = FormatCurrency(CDbl(NzZero(Me.Ipi.Text)) * CDbl(NzZero(Me.TotalProduto.Text) - NzZero(Me.ValorDesconto.Text)) / 100)


        Me.Liquido.Text = FormatCurrency(NzZero(Me.TotalProduto.Text) - NzZero(Me.ValorDesconto.Text) + NzZero(Me.ValorIpi.Text), 4)

    End Sub



#Region "Ação para as combos"
    Private Enum TpRetornoCBO
        Não = 0
        Sim = 1
    End Enum

    Private Function PegaVlrCombo(ByVal Cbo As CBOAutoCompleteFocus.CboFocus, ByVal Retorna_Descrição As TpRetornoCBO)

        Dim Retorno As String = ""
        If Cbo.Text = "" Then
            Retorno = ""

        Else
            Cbo.SelectedIndex = Cbo.FindStringExact(Cbo.Text & "")
            If Retorna_Descrição = TpRetornoCBO.Não Then
                Retorno = CType(Cbo.SelectedItem, cboItemData).ItemData
            Else
                Retorno = CType(Cbo.SelectedItem, cboItemData).Name
            End If
        End If
        Return Retorno




    End Function
    Public Sub Grupo_Preencher(ByVal Controle As CBOAutoCompleteFocus.CboFocus)

        Controle.Items.Clear()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "SELECT * FROM Grupos where Empresa = " & CodEmpresa & " order by Descrição"
        Dim Cmd As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        Try
            DR = Cmd.ExecuteReader
            While DR.Read
                Controle.Items.Add(New cboItemData(DR.Item("CódigoGrupo"), DR.Item("Descrição")))
            End While
            DR.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()

    End Sub
#End Region



    Private Sub Qtd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Qtd.Leave
        If Me.Qtd.Text = "" Or Me.Qtd.Text = 0 Then Me.CodigoProduto.Focus()

        If My.Forms.PedidoOS.TpVenda.Text <> "DEVOLUÇÃO" Then
            If (Me.Multiplos.Text) <> 0 Then
                If AchaMultiplos(NzZero(Me.Qtd.Text), Me.Multiplos.Text) = False Then
                    MessageBox.Show("A quantidade informada não é valida para o multiplo deste produto que é [" & Me.Multiplos.Text & "]", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Qtd.Focus()
                    Exit Sub
                End If
            End If
        End If



        If QtdEstoqueTela < Me.Qtd.Text Then
            QtdEstoqueEdição = CDbl(Me.Qtd.Text) - CDbl(QtdEstoqueTela)
        ElseIf QtdEstoqueTela > Me.Qtd.Text Then
            QtdEstoqueEdição = CDbl(Me.Qtd.Text) - CDbl(QtdEstoqueTela)
        ElseIf QtdEstoqueTela = Me.Qtd.Text Then
            QtdEstoqueEdição = 0
        End If

    End Sub

    Private Sub Desconto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Desconto.KeyDown
        If e.KeyCode = Keys.Insert Then
            My.Forms.PedidoVendaSenhaItem.ShowDialog()
        End If
    End Sub

    Private Sub Desconto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Desconto.Leave

        If Me.Desconto.Text = "" Then Me.Desconto.Text = FormatNumber(0, 4)
        Me.ValorDesconto.Text = FormatCurrency((CDbl(Me.ValorUnitario.Text) * CDbl(Me.Qtd.Text)) * FormatNumber(CDbl(Me.Desconto.Text), 2) / 100, 2)

        If TipoItem <> 99 Then 'verifica se o tipo de produto não é de serviço

            If My.Forms.PedidoOS.TpComercio.Text = "VAREJO" Then
                If CDbl(Me.Desconto.Text) > CDbl(DescontoVarejo) Then
                    If Me.UserSenhaDesconto.Text = "" Then
                        MsgBox("O desconto maximo permitido para este produto foi excedido. Verifique.", 64, "Validador de Dados")
                        Me.Desconto.Text = 0
                        Me.ValorDesconto.Text = "0,00"
                        Me.Desconto.Focus()
                    Else
                        If CDbl(Me.Desconto.Text) <= CDbl(DescontoMaximo) Then
                            If Me.UserSenhaDesconto.Text = "" Then
                                MsgBox("O desconto maximo permitido para este produto foi excedido. Verifique.", 64, "Validador de Dados")
                                Me.Desconto.Text = 0
                                Me.ValorDesconto.Text = "0,00"
                                Me.Desconto.Focus()
                            End If
                        Else
                            MsgBox("O desconto maximo permitido para este produto foi excedido. Verifique.", 64, "Validador de Dados")
                            Me.Desconto.Text = 0
                            Me.ValorDesconto.Text = "0,00"
                            Me.Desconto.Focus()
                        End If
                        ' Me.UserSenhaDesconto.Clear()
                    End If
                End If
            End If

            If My.Forms.PedidoOS.TpComercio.Text = "ATACADO" Then
                If Me.Desconto.Text > DescontoAtacado Then
                    If Me.UserSenhaDesconto.Text = "" Then
                        MsgBox("O desconto maximo permitido para este produto foi excedido. Verifique.", 64, "Validador de Dados")
                        Me.Desconto.Text = 0
                        Me.ValorDesconto.Text = "0,00"
                        Me.Desconto.Focus()
                    Else
                        If Me.Desconto.Text <= DescontoMaximo Then
                            If Me.UserSenhaDesconto.Text = "" Then
                                MsgBox("O desconto maximo permitido para este produto foi excedido. Verifique.", 64, "Validador de Dados")
                                Me.Desconto.Text = 0
                                Me.ValorDesconto.Text = "0,00"
                                Me.Desconto.Focus()
                            End If
                        Else
                            MsgBox("O desconto maximo permitido para este produto foi excedido. Verifique.", 64, "Validador de Dados")
                            Me.Desconto.Text = 0
                            Me.ValorDesconto.Text = "0,00"
                            Me.Desconto.Focus()
                        End If
                    End If
                Else
                    If CDbl(Me.Desconto.Text) > DescontoMaximo Then
                        If Me.UserSenhaDesconto.Text = "" Then
                            MsgBox("O desconto maximo permitido para este produto foi excedido. Verifique.", 64, "Validador de Dados")
                            Me.Desconto.Text = 0
                            Me.ValorDesconto.Text = "0,00"
                            Me.Desconto.Focus()
                        End If

                    End If

                End If
            End If
        End If


        If Me.Desconto.Text > 0 Then
            Me.Ipi.Focus()
        End If
    End Sub

    Private Sub ValorUnitario_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorUnitario.Validated
        If Me.ValorUnitario.Text = "" Then
            Me.ValorUnitario.Text = FormatCurrency(0, 2)
        Else
            If CDbl(Me.ValorUnitario.Text) < v_ValorUnitario Then
                Me.ValorUnitario.Text = v_ValorUnitario
            End If
            Me.ValorUnitario.Text = FormatCurrency(Me.ValorUnitario.Text, 2)
        End If
    End Sub

    Private Sub ValorDesconto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorDesconto.Leave

        If DescontoEmLinha = True Then

            If CDbl(NzZero(Me.ValorUnitario.Text)) = 0 Then
                Exit Sub
            End If

            Desc = (CDbl(Me.ValorDesconto.Text) / (CDbl(Me.ValorUnitario.Text) * CDbl(Me.Qtd.Text))) * 100
            'Desc = FormatNumber(Desc, 4)
            Me.Desconto.Text = FormatNumber(NzZero(Desc), 2)
            Me.ValorDesconto.Text = FormatCurrency(Me.ValorDesconto.Text, 2)

            If TipoItem <> 99 Then

                If My.Forms.PedidoOS.TpComercio.Text = "VAREJO" Then
                    If CDbl(Me.Desconto.Text) > CDbl(DescontoVarejo) Then
                        If Me.UserSenhaDesconto.Text = "" Then
                            MsgBox("O desconto maximo permitido para este produto foi excedido. Verifique.", 64, "Validador de Dados")
                            Me.Desconto.Text = 0
                            Me.ValorDesconto.Text = "0,00"
                            Me.Desconto.Focus()
                        Else
                            If CDbl(Me.Desconto.Text) <= CDbl(DescontoMaximo) Then
                                If Me.UserSenhaDesconto.Text = "" Then
                                    MsgBox("O desconto maximo permitido para este produto foi excedido. Verifique.", 64, "Validador de Dados")
                                    Me.Desconto.Text = 0
                                    Me.ValorDesconto.Text = "0,00"
                                    Me.Desconto.Focus()
                                End If
                            Else
                                MsgBox("O desconto maximo permitido para este produto foi excedido. Verifique.", 64, "Validador de Dados")
                                Me.Desconto.Text = 0
                                Me.ValorDesconto.Text = "0,00"
                                Me.Desconto.Focus()
                            End If
                            ' Me.UserSenhaDesconto.Clear()
                        End If
                    End If
                End If

                If My.Forms.PedidoOS.TpComercio.Text = "ATACADO" Then
                    If Me.Desconto.Text > DescontoAtacado Then
                        If Me.UserSenhaDesconto.Text = "" Then
                            MsgBox("O desconto maximo permitido para este produto foi excedido. Verifique.", 64, "Validador de Dados")
                            Me.Desconto.Text = 0
                            Me.ValorDesconto.Text = "0,00"
                            Me.Desconto.Focus()
                        Else
                            If Me.Desconto.Text <= DescontoMaximo Then
                                If Me.UserSenhaDesconto.Text = "" Then
                                    MsgBox("O desconto maximo permitido para este produto foi excedido. Verifique.", 64, "Validador de Dados")
                                    Me.Desconto.Text = 0
                                    Me.ValorDesconto.Text = "0,00"
                                    Me.Desconto.Focus()
                                End If
                            Else
                                MsgBox("O desconto maximo permitido para este produto foi excedido. Verifique.", 64, "Validador de Dados")
                                Me.Desconto.Text = 0
                                Me.ValorDesconto.Text = "0,00"
                                Me.Desconto.Focus()
                            End If
                        End If
                    Else
                        If CDbl(Me.Desconto.Text) > DescontoMaximo Then
                            If Me.UserSenhaDesconto.Text = "" Then
                                MsgBox("O desconto maximo permitido para este produto foi excedido. Verifique.", 64, "Validador de Dados")
                                Me.Desconto.Text = 0
                                Me.ValorDesconto.Text = "0,00"
                                Me.Desconto.Focus()
                            End If

                        End If

                    End If
                End If
            End If


            If My.Forms.PedidoOS.TpVenda.Text = "DEVOLUÇÃO" Then
                Me.ValorDesconto.Text = NzZero(Me.ValorDesconto.Text) * -1
            End If

        End If
        'Desconto_Leave(sender, e)

    End Sub

    Private Sub Grupo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grupo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btAdItem.Focus()
        End If
    End Sub

    Private Sub Ipi_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Ipi.Leave
        TotalProduto_Enter(sender, e)
    End Sub

    Private Sub PedidoAddItem_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'Me.CodigoProduto.Focus()
    End Sub


    Private Sub btProdutoFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btProdutoFind.Click
        If Me.CodigoProduto.Text = "" Then
            Dim f As New ProcuraProduto
            f.ShowDialog()

            LocalizaProduto()
        End If
    End Sub

    Private Sub Qtd_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Qtd.Validating
        If NzZero(Me.Qtd.Text) = 0 Then
            Me.Qtd.Text = FormatNumber(1, 4)
        End If

        If My.Forms.PedidoOS.TpVenda.Text = "DEVOLUÇÃO" Then
            Me.Qtd.Text = Me.Qtd.Text * -1
        End If

    End Sub

    Private Sub CodigoProduto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoProduto.Leave
        If OperationItens = INS Then
            If Me.CodigoProduto.Text <> "" Then
                LocalizaProduto()
                If NzZero(Me.Qtd.Text) = 0 Then
                    Me.Qtd.Text = FormatNumber(1, 4)
                End If
            End If
        End If

    End Sub
End Class