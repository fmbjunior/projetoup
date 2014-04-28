Public Class OSorçamentoItens
    Dim TipoItem As Integer = 0
    Dim DescontoMaximo As Double = 0
    Dim DescontoVarejo As Double = 0
    Dim DescontoAtacado As Double = 0
    Dim Desc As Double = 0

    Public OperationItens As Byte
    Public IdLinha As Integer
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Dim v_ValorUnitario As Double

    Dim CNNITEM As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

    Private Sub CodigoProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoProduto.KeyDown

        If e.KeyCode = Keys.F5 Then

            If OperationItens = INS Then
                My.Forms.ProcuraProduto.ShowDialog()
                LocalizaProduto()
            End If

            'If Me.CodigoProduto.Text = "" Then
            '    RetornoProcura = ""
            '    TipoItensProcurar = 1
            '    My.Forms.ProcurarProdutoDetalhado.ShowDialog()
            '    If RetornoProcura <> "" Then
            '        Me.CodigoProduto.Text = RetornoProcura
            '    End If
            'End If
        End If

    End Sub


    Public Sub LocalizaProduto()
        Me.UserSenhaDesconto.Text = ""
        If Me.ValorUnitario.Text = "" Then Me.ValorUnitario.Text = FormatNumber(0, 2)
        If Me.CodigoProduto.Text = "" Then
            Exit Sub
        End If



        If CNNITEM.State = ConnectionState.Closed Then
            CNNITEM.Open()
        End If



        Dim Sql As String = "Select * from Produtos where CodigoProduto = " & Me.CodigoProduto.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNNITEM)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows = True Then
            Me.ProdutoDesc.Text = DR.Item("Descrição") & ""
            v_ValorUnitario = DR.Item("ValorVenda")
            If Me.ValorUnitario.Text = 0 Then Me.ValorUnitario.Text = FormatNumber(Nz(DR.Item("ValorVenda"), 3), 2)
            DescontoMaximo = Nz(DR.Item("DescontoMaximo"), 3)
            DescontoVarejo = Nz(DR.Item("DescVarejo"), 3)
            DescontoAtacado = Nz(DR.Item("DescAtacado"), 3)

            TipoItem = NzZero(DR.Item("Tipo"))

            If My.Forms.OSorçamento.TpComercio.Text = "ATACADO" Then
                If Me.ValorUnitario.Text = 0 Then Me.ValorUnitario.Text = FormatNumber(Nz(DR.Item("ValorVendaAtacado"), 3), 2)
                v_ValorUnitario = NzZero(DR.Item("ValorVendaAtacado"))
            Else
                If Me.ValorUnitario.Text = 0 Then Me.ValorUnitario.Text = FormatNumber(Nz(DR.Item("ValorVenda"), 3), 2)
                v_ValorUnitario = NzZero(DR.Item("ValorVenda"))
            End If


        Else
            MsgBox("Item não encontrado, verifique....", 64, "Validação de Dados")
            Me.CodigoProduto.Focus()
            Exit Sub
        End If
        DR.Close()
    End Sub

    Private Sub TotalProduto_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TotalProduto.Enter
        Try
            Me.TotalProduto.Text = FormatCurrency(CDbl(Me.ValorUnitario.Text) * CDbl(Me.Qtd.Text) - CDbl(Me.ValorDesconto.Text), 2)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        'Area destinada para as validacoes
        If Me.CodigoProduto.Text = "" Then
            MsgBox("O Código do Produto não foi informado, favor verificar.", 64, "Validação de Dados")
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
        End If

        If DescontoEmLinha = False Then
            Me.ValorDesconto.Text = FormatNumber(0, 2)
            Me.Desconto.Text = 0
        End If

        'Fim da Area destinada para as validacoes.

        If OperationItens = INS Then

            Dim Sql As String = "INSERT INTO OrcamentoItensProduto (Orcamento, CodigoProduto, Qtd, ValorUnitario, TotalProduto, Desconto, ValorDesconto) VALUES (@1, @2, @3, @4, @5, @6, @7)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNNITEM)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(My.Forms.OSorçamento.CodOrçamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.CodigoProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Qtd.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ValorUnitario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.TotalProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Desconto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.ValorDesconto.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                CNNITEM.Close()
                Me.CodigoProduto.Clear()
                Me.ProdutoDesc.Clear()
                Me.Qtd.Clear()
                Me.ValorUnitario.Clear()
                Me.TotalProduto.Clear()
                Me.CodigoProduto.Focus()
                Me.Desconto.Clear()
                Me.ValorDesconto.Clear()
                My.Forms.OSorçamento.atGridProduto()

                OperationItens = INS
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")

            End Try

        ElseIf OperationItens = UPD Then

            Dim Sql As String = "Update OrcamentoItensProduto set Orcamento = @1, CodigoProduto = @2, Qtd = @3, ValorUnitario = @4, TotalProduto = @5, Desconto = @6, ValorDesconto = @7 Where Id = " & Me.IdItem.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNNITEM)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(My.Forms.OSorçamento.CodOrçamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.CodigoProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Qtd.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ValorUnitario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.TotalProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Desconto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.ValorDesconto.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                CNNITEM.Close()
                Me.CodigoProduto.Clear()
                Me.ProdutoDesc.Clear()
                Me.Qtd.Clear()
                Me.ValorUnitario.Clear()
                Me.TotalProduto.Clear()
                Me.CodigoProduto.Focus()
                Me.Desconto.Clear()
                Me.ValorDesconto.Clear()
                My.Forms.OSorçamento.atGridProduto()

                OperationItens = INS

            Catch x As Exception
                MsgBox(x.Message)

                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click

        Me.Close()
        Me.Dispose()
        OSorçamento.VlrDescProduto.Focus()
    End Sub

    Private Sub OrçamentoItens_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If CNNITEM.State = ConnectionState.Closed Then
            CNNITEM.Open()
        End If
        If DescontoEmLinha = False Then
            Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.Desconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.Desconto.Text = 0
            Me.ValorDesconto.Text = FormatNumber(0, 2)
        Else
            Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.Desconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        End If

        If OperationItens = UPD Then
            VerificaEdição()
        End If


    End Sub

    Private Sub CodigoProduto_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CodigoProduto.Validated
        LocalizaProduto()
    End Sub

    Private Sub Desconto_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Desconto.Validated
        Try
            If Me.Desconto.Text = "" Then Me.Desconto.Text = 0
            Me.ValorDesconto.Text = FormatCurrency(CDbl(Me.ValorUnitario.Text) * CDbl(Me.Qtd.Text) * CDbl(Me.Desconto.Text) / 100, 2)
        Catch ex As Exception
        End Try

    End Sub



    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        Me.CodigoProduto.Clear()
        Me.ProdutoDesc.Clear()
        Me.Qtd.Clear()
        Me.ValorUnitario.Clear()
        Me.TotalProduto.Clear()
        Me.CodigoProduto.Focus()
        Me.Desconto.Clear()
        Me.ValorDesconto.Clear()
        OperationItens = INS
    End Sub

    Public Sub VerificaEdição()
        'If RetornoProcura = "" Then
        '    OperationItens = INS
        '    Exit Sub
        'End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from OrcamentoItensProduto where Id = " & IdLinha
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.IdItem.Text = IdLinha
            Me.CodigoProduto.Text = DR.Item("CodigoProduto")
            Me.ProdutoDesc.Text = OSorçamento.dgvItemP.CurrentRow.Cells("DescricaoP").Value
            Me.Qtd.Text = FormatNumber(DR.Item("Qtd"), 4)
            Me.ValorUnitario.Text = FormatNumber(DR.Item("ValorUnitario"), 2)
            Me.TotalProduto.Text = FormatNumber(DR.Item("TotalProduto"), 2)
            Me.Desconto.Text = DR.Item("Desconto")
            Me.ValorDesconto.Text = FormatNumber(DR.Item("ValorDesconto"), 2)
            OperationItens = UPD
        Else
            MsgBox("Item não encontrado, Verifique.", 64, "Validação de Dados")
            DR.Close()
            OperationItens = INS
            Exit Sub
        End If

    End Sub

    Private Sub ValorUnitario_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValorUnitario.Validated
        If CDbl(Me.ValorUnitario.Text) < v_ValorUnitario Then
            Me.ValorUnitario.Text = v_ValorUnitario
        End If
    End Sub

    Private Sub Desconto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Desconto.Leave
        If Me.Desconto.Text = "" Then Me.Desconto.Text = FormatNumber(0, 4)
        Me.ValorDesconto.Text = FormatCurrency((CDbl(Me.ValorUnitario.Text) * CDbl(Me.Qtd.Text)) * FormatNumber(CDbl(Me.Desconto.Text), 2) / 100, 2)

        If TipoItem <> 99 Then 'verifica se o tipo de produto não é serviço

            If CDbl(Me.Desconto.Text) > CDbl(DescontoVarejo) Then  'é varejo!, verifca se o desconto utrapassou o permitido do varejo
                If Me.UserSenhaDesconto.Text = "" Then             'caso positivo, pede uma senha e verifica se foi digitada.
                    MsgBox("O desconto maximo permitido para este produto foi excedido. Verifique.", 64, "Validador de Dados")
                    Me.Desconto.Text = 0
                    ValorDesconto.Text = ""

                    Me.Desconto.Focus()
                Else                                                'existe senha.
                    If CDbl(Me.Desconto.Text) <= CDbl(DescontoMaximo) Then   'entao é condicionado ao desconto maxido permitido e nao pode ser ultrapassado
                        If Me.UserSenhaDesconto.Text = "" Then
                            MsgBox("O desconto maximo permitido para este produto foi excedido. Verifique.", 64, "Validador de Dados")
                            Me.Desconto.Text = 0

                            Me.Desconto.Focus()
                        End If
                    Else
                        MsgBox("O desconto maximo permitido para este produto foi excedido. Verifique.", 64, "Validador de Dados")
                        Me.Desconto.Text = 0
                        Me.Desconto.Focus()
                    End If
                    ' Me.UserSenhaDesconto.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub ValorDesconto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValorDesconto.Leave
        If DescontoEmLinha = True Then

            If CDbl(NzZero(Me.ValorUnitario.Text)) = 0 Then
                Return
            End If

            Desc = (CDbl(Me.ValorDesconto.Text) / (CDbl(Me.ValorUnitario.Text) * CDbl(Me.Qtd.Text))) * 100
            'Desc = FormatNumber(Desc, 4)
            Me.Desconto.Text = FormatNumber(NzZero(Desc), 2)
            Me.ValorDesconto.Text = FormatCurrency(Me.ValorDesconto.Text, 2)

            If TipoItem <> 99 Then
                If CDbl(Me.Desconto.Text) > CDbl(DescontoVarejo) Then
                    If Me.UserSenhaDesconto.Text = "" Then
                        MsgBox("O desconto maximo permitido para este produto foi excedido. Verifique.", 64, "Validador de Dados")
                        Me.Desconto.Text = 0
                        ValorDesconto.Text = "0,00"
                        Me.Desconto.Focus()
                    Else
                        If CDbl(Me.Desconto.Text) <= CDbl(DescontoMaximo) Then
                            If Me.UserSenhaDesconto.Text = "" Then
                                MsgBox("O desconto maximo permitido para este produto foi excedido. Verifique.", 64, "Validador de Dados")
                                Me.Desconto.Text = 0
                                Me.Desconto.Focus()
                            End If
                        Else
                            MsgBox("O desconto maximo permitido para este produto foi excedido. Verifique.", 64, "Validador de Dados")
                            Me.Desconto.Text = 0
                            Me.Desconto.Focus()
                        End If

                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Desconto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Desconto.KeyDown
        If e.KeyCode = Keys.Insert Then
            My.Forms.PedidoVendaSenhaItem.ShowDialog()
        End If
    End Sub
End Class