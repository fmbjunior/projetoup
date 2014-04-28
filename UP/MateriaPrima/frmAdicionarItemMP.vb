Public Class frmAdicionarItemMP

    Dim db As New clsBancoDados
    Dim Item As New clsItemMP

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub



    Private Sub Qtde_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qtde.Leave
        Try
            If (CDbl(Me.Qtde.Text)) < 0 Or String.IsNullOrEmpty(Me.Qtde.Text) Then
                MessageBox.Show("A Quantidade não pode ser negativo ou nulo", "Validação de dados", MessageBoxButtons.OK)
                Me.Qtde.Text = FormatNumber(0, 3)
                Exit Sub
            End If
            TotalItem.Text = Qtde.Text * CDbl(ValorVenda.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ValorVenda_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValorVenda.Validated
        If NzZero(Me.ValorVenda.Text) > 0 Then
            Me.TotalItem.Text = FormatCurrency(Me.Qtde.Text * Me.ValorVenda.Text, 2)
        End If
    End Sub

    Private Sub Qtde_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qtde.Validated
        If Me.Qtde.Text = "" Then
            Me.Qtde.Text = "0,00"
        End If
        If NzZero(Me.Qtde.Text) > 0 And NzZero(Me.ValorVenda.Text) > 0 Then
            Me.TotalItem.Text = FormatCurrency(Me.Qtde.Text * Me.ValorVenda.Text, 2)
        Else
            Me.TotalItem.Text = "0,00"
        End If
    End Sub

    Private Sub btnAdicionarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionarItem.Click
        If String.IsNullOrEmpty(Me.Descricao.Text) Then
            MessageBox.Show("A descrição não pode ser nula")
            Me.Descricao.Focus()
            Return
        ElseIf String.IsNullOrEmpty(Me.Qtde.Text) Or CDbl(Me.Qtde.Text) = 0 Then
            MessageBox.Show("A quantidade não pode ser zero ou nula")
            Me.Qtde.Focus()
            Return
        ElseIf String.IsNullOrEmpty(Me.ValorVenda.Text) Or CDbl(Me.ValorVenda.Text) = 0 Then
            MessageBox.Show("O valor de venda não pode ser zero ou nula")
            Me.Qtde.Focus()
            Return
        ElseIf String.IsNullOrEmpty(Me.cboTam.Text) Then
            MessageBox.Show("O tamanho não pode ser nulo")
            Me.cboTam.Focus()
            Return
        End If

        With Item
            .NumeroPedido = frmPedidoMP.NumeroPedido.Text
            .Descricao = Me.Descricao.Text
            .Qtd = Me.Qtde.Text
            .ValorUnitario = Me.ValorVenda.Text
            .ValorTotal = Me.TotalItem.Text
            .Tamanho = Me.cboTam.Text
            .Modelo = frmPedidoMP.ModeloVenda.Text.Substring(0, 1)
        End With

        If vEnum = Operacao.inclusao Then
            Item.Gravar()
            Item.AtGrade(Item.NumeroPedido)
            MessageBox.Show("Registro gravado com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf vEnum = Operacao.alteracao Then
            Item.Editar(Item.ID)
            Item.AtGrade(Item.NumeroPedido)
            MessageBox.Show("Registro gravado com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Me.Descricao.Clear()
        Me.txtIdLinha.Clear()
        Me.cboTam.SelectedIndex = -1
        Me.Qtde.Text = "0,00"
        Me.ValorVenda.Text = "0,00"
        Me.TotalItem.Text = "0,00"
        Me.Descricao.Focus()




    End Sub
    Private Sub frmAdicionarItemMP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If vEnum = Operacao.alteracao Then
            Item.Localizar(Retorno)
            With Item
                Me.txtIdLinha.Text = .ID
                Me.Descricao.Text = .Descricao
                Me.Qtde.Text = FormatNumber(.Qtd, 2)
                Me.cboTam.Text = .Tamanho
                Me.ValorVenda.Text = FormatCurrency(.ValorUnitario, 2)
                Me.TotalItem.Text = FormatCurrency(.ValorTotal, 2)
            End With
        End If
    End Sub

    Private Sub Descricao_KeyDown(sender As Object, e As KeyEventArgs) Handles Descricao.KeyDown
        Dim isControlPressed As Boolean = (Control.ModifierKeys And Keys.Control) <> 0
        If isControlPressed = True Then

        Else

            If e.KeyCode = Keys.Enter Then
                SendKeys.Send("{TAB}")
            End If
        End If

    End Sub

    Private Sub ValorVenda_Leave(sender As Object, e As EventArgs) Handles ValorVenda.Leave
        Try
            If (CDbl(Me.ValorVenda.Text)) < 0 Or String.IsNullOrEmpty(Me.ValorVenda.Text) Then
                MessageBox.Show("A ValorVenda não pode ser negativo", "Validação de dados", MessageBoxButtons.OK)
                Me.ValorVenda.Text = FormatNumber(0, 2)
                Exit Sub
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class