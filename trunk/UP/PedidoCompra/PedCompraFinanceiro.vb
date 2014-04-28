Imports Grid.DBL.DataGridViewCustomColumn
Imports System.Text
Imports System.Math

Public Class PedCompraFinanceiro
    Public varPegaConta As String = String.Empty
    Dim clsPC As New clsPedidoCompra


    Dim vValorAnterior As Double = 0
    Dim i As Integer = 0
    Dim vpar As Double = 0
    Dim cp As Integer = 0 'total de parcelas
    Dim CodFornecedor As Integer = 0 'Armazena o codigo do fornecedor
    Dim dResta As Double = 0 'Armazena o valor que resta.
    Dim idLinha As Integer

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        'Trata o evento quando for prescionado a tecla enter.
        'If Me.ListaPagar.Focused = True Then
        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
            'If Me.DataGridView1.CurrentCell.ColumnIndex <> 4 Then
            SendKeys.Send("{Tab}")
            Return True
            'End If
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
        ' End If
    End Function
    Private Sub ExcluirTodasAsParcelasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirTodasAsParcelasToolStripMenuItem.Click
        'Verifica se existem parcelamentos, caso positivo encerra a rotina.
        If ListaPagar.RowCount > 0 Then
            'MsgBox("Esta opção esta inativa no sistema.", 64, "Validação de Dados")

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()
            Dim myTrans As OleDb.OleDbTransaction = CNN.BeginTransaction

            Dim Sql As String
            Sql = "Delete * from Pagar where Virtual=False and IDPedidoCompra=" & Me.txtPedido.Text

            Dim cmd As New OleDb.OleDbCommand(Sql, CNN, myTrans)
            Try
                cmd.ExecuteNonQuery()
                myTrans.Commit()
                MsgBox("Parcelas excluídas com sucesso", 48, "Validação de dados")

                If Me.ListaPagar.RowCount > 0 Then
                    ListaPagar.Rows.Clear()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                myTrans.Rollback()
            Finally
                CNN.Close()
            End Try
        End If
    End Sub
    Sub CreateCol()
        'Aqui definimos as nossa datagridview.
        Dim col As DataGridViewTextBoxColumn 'Importa a coluna textbox
        Dim ColM As MaskedTextBoxColumn  'importa a coluna maskedtext

        'Definir alguma propriedades da coluna TextBox
        col = New DataGridViewTextBoxColumn()
        col.HeaderText = "id"
        col.Name = "id"
        col.Width = 70
        col.Visible = False
        Me.ListaPagar.Columns.Add(col)

        col = New DataGridViewTextBoxColumn()
        col.HeaderText = "PP"
        col.Name = "P"
        col.Width = 70
        col.Visible = False
        Me.ListaPagar.Columns.Add(col)

        col = New DataGridViewTextBoxColumn()
        col.HeaderText = "Documento"
        col.Name = "documento"
        col.Width = 110
        col.ReadOnly = True
        Me.ListaPagar.Columns.Add(col)

        ColM = New MaskedTextBoxColumn()
        ColM.HeaderText = "Vencimento"
        ColM.Name = "vencimento"
        ColM.Mask = "00/00/0000"
        ColM.Width = 75
        ColM.ReadOnly = False
        Me.ListaPagar.Columns.Add(ColM)      '

        col = New DataGridViewTextBoxColumn()
        col.HeaderText = "Valor"
        col.Name = "valor"
        col.Width = 90
        col.DefaultCellStyle.Format = FormatCurrency(0, 2)
        Me.ListaPagar.Columns.Add(col)
    End Sub
    Private Sub EncheGrid()

        If Me.ListaPagar.RowCount > 0 Then
            ListaPagar.Rows.Clear()
        End If
        If ListaPagar.Columns.Count = 0 Then
            CreateCol()
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT *  FROM Pagar Where Virtual=False And IdPedidoCompra=" & Me.txtPedido.Text & " And NotaFiscal ='" & Me.txtNotaFiscal.Text & "' Order By id"

        Dim ocmd As New OleDb.OleDbCommand(Sql, CNN)

        Dim odr As OleDb.OleDbDataReader
        odr = ocmd.ExecuteReader

        Dim row As New DataGridViewRow
        Dim cVlr As Double = 0
        While odr.Read()
            i += 1
            'preenche o grid com alguns dados
            Dim row0 As String() = {odr.Item("Id"), i, odr.Item("Documento"), odr.Item("Vencimento"), FormatCurrency(odr.Item("valorDocumento"), 2)}
            'adiciona as linhas
            With Me.ListaPagar.Rows
                .Add(row0)
            End With
            cVlr += odr.Item("valorDocumento")
            Me.txtTotal.Text = FormatCurrency(cVlr, 2)
        End While
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        If Me.ListaPagar.RowCount > 0 Then
            MsgBox("Existem Parcelas gerarada. Exclua as parcela para cancelar o fechamento", 48, "Validação de dados")
            Return
        End If
        Me.Close()
        Me.Dispose()
    End Sub
    Public Sub AchaContaBalancete(ByVal ContaBalancete As String, ByVal CampoParaRetornar As Control, ByVal retErro As Boolean)

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()
        Dim Sql As String = "Select * from ContasG3 where ContaGrupo3 = '" & ContaBalancete & "' And Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            CampoParaRetornar.Text = DR.Item("DescContaGrupo3") & ""
        Else
            If retErro = True Then
                MessageBox.Show("Conta Inexistente, Favor verificar...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CType(CampoParaRetornar, TextBox).Clear()
                If CType(CampoParaRetornar, TextBox).Name = "DescConta1" Then Me.Conta1.Focus()
                If CType(CampoParaRetornar, TextBox).Name = "DescConta2" Then Me.Conta2.Focus()
                If CType(CampoParaRetornar, TextBox).Name = "DescConta3" Then Me.Conta3.Focus()
                If CType(CampoParaRetornar, TextBox).Name = "DescConta4" Then Me.Conta4.Focus()
                If CType(CampoParaRetornar, TextBox).Name = "DescConta5" Then Me.Conta5.Focus()
                If CType(CampoParaRetornar, TextBox).Name = "DescConta6" Then Me.Conta6.Focus()
                Exit Sub
            End If
        End If
        Cnn.Close()
    End Sub

    '============================================================================
    ' Aqui começa a implementação das contas
    '===========================================================================
#Region "Códigos para o Lançamento de Contas"

    Private Sub Find1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find1.Click
        varPegaConta = String.Empty
        My.Forms.BalanceteContasProcura.TipoConta = "D"
        My.Forms.BalanceteContasProcura.ShowDialog()
        Me.Conta1.Text = varPegaConta
        AchaContaBalancete(Me.Conta1.Text, Me.DescConta1, True)
        Me.Conta1.Focus()
    End Sub

    Private Sub Find2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find2.Click
        varPegaConta = String.Empty
        My.Forms.BalanceteContasProcura.TipoConta = "D"
        My.Forms.BalanceteContasProcura.ShowDialog()
        Me.Conta2.Text = varPegaConta
        AchaContaBalancete(Me.Conta2.Text, Me.DescConta2, True)
        Me.Conta2.Focus()

    End Sub

    Private Sub Find3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find3.Click
        varPegaConta = String.Empty
        My.Forms.BalanceteContasProcura.TipoConta = "D"
        My.Forms.BalanceteContasProcura.ShowDialog()
        Me.Conta3.Text = varPegaConta
        AchaContaBalancete(Me.Conta3.Text, Me.DescConta3, True)
        Me.Conta3.Focus()

    End Sub

    Private Sub Find4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find4.Click
        varPegaConta = String.Empty
        My.Forms.BalanceteContasProcura.TipoConta = "D"
        My.Forms.BalanceteContasProcura.ShowDialog()
        Me.Conta4.Text = varPegaConta
        AchaContaBalancete(Me.Conta4.Text, Me.DescConta4, True)
        Me.Conta4.Focus()

    End Sub

    Private Sub Find5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find5.Click
        varPegaConta = String.Empty
        My.Forms.BalanceteContasProcura.TipoConta = "D"
        My.Forms.BalanceteContasProcura.ShowDialog()
        Me.Conta5.Text = varPegaConta
        AchaContaBalancete(Me.Conta5.Text, Me.DescConta5, True)
        Me.Conta5.Focus()

    End Sub

    Private Sub Find6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find6.Click
        varPegaConta = String.Empty
        My.Forms.BalanceteContasProcura.TipoConta = "D"
        My.Forms.BalanceteContasProcura.ShowDialog()
        Me.Conta6.Text = varPegaConta
        AchaContaBalancete(Me.Conta6.Text, Me.DescConta6, True)
        Me.Conta6.Focus()

    End Sub

    Private Sub Conta1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Conta1.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.BalanceteContasProcura.TipoConta = "D"
            My.Forms.BalanceteContasProcura.ShowDialog()
            Me.Conta1.Text = varPegaConta
            Me.Conta1.Focus()
        End If
    End Sub

    Private Sub Conta2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Conta2.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.BalanceteContasProcura.TipoConta = "D"
            My.Forms.BalanceteContasProcura.ShowDialog()
            Me.Conta2.Text = varPegaConta
            Me.Conta2.Focus()
        End If
    End Sub

    Private Sub Conta3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Conta3.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.BalanceteContasProcura.TipoConta = "D"
            My.Forms.BalanceteContasProcura.ShowDialog()
            Me.Conta3.Text = varPegaConta
            Me.Conta3.Focus()
        End If
    End Sub

    Private Sub Conta4_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Conta4.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.BalanceteContasProcura.TipoConta = "D"
            My.Forms.BalanceteContasProcura.ShowDialog()
            Me.Conta4.Text = varPegaConta
            Me.Conta4.Focus()
        End If
    End Sub

    Private Sub Conta5_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Conta5.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.BalanceteContasProcura.TipoConta = "D"
            My.Forms.BalanceteContasProcura.ShowDialog()
            Me.Conta5.Text = varPegaConta
            Me.Conta5.Focus()
        End If
    End Sub

    Private Sub Conta6_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Conta6.KeyDown
        If e.KeyCode = Keys.F5 Then
            varPegaConta = String.Empty
            My.Forms.BalanceteContasProcura.TipoConta = "D"
            My.Forms.BalanceteContasProcura.ShowDialog()
            Me.Conta6.Text = varPegaConta
            Me.Conta6.Focus()
        End If
    End Sub

    Private Sub Conta1_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Conta1.Validating, Conta2.Validating, Conta3.Validating, Conta4.Validating, Conta5.Validating, Conta6.Validating
        Select Case CType(sender, TextBox).Name
            Case "Conta1"
                If String.CompareOrdinal(Me.Conta1.Text, Me.Conta1.TextoAntigo) Then
                    AchaContaBalancete(Me.Conta1.Text, Me.DescConta1, True)
                End If
            Case "Conta2"
                If String.CompareOrdinal(Me.Conta2.Text, Me.Conta2.TextoAntigo) Then
                    AchaContaBalancete(Me.Conta2.Text, Me.DescConta2, True)
                End If
            Case "Conta3"
                If String.CompareOrdinal(Me.Conta3.Text, Me.Conta3.TextoAntigo) Then
                    AchaContaBalancete(Me.Conta3.Text, Me.DescConta3, True)
                End If
            Case "Conta4"
                If String.CompareOrdinal(Me.Conta4.Text, Me.Conta4.TextoAntigo) Then
                    AchaContaBalancete(Me.Conta4.Text, Me.DescConta4, True)
                End If
            Case "Conta5"
                If String.CompareOrdinal(Me.Conta5.Text, Me.Conta5.TextoAntigo) Then
                    AchaContaBalancete(Me.Conta5.Text, Me.DescConta5, True)
                End If
            Case "Conta6"
                If String.CompareOrdinal(Me.Conta6.Text, Me.Conta6.TextoAntigo) Then
                    AchaContaBalancete(Me.Conta6.Text, Me.DescConta6, True)
                End If
        End Select
    End Sub

    Private Sub LiberarConta1()
        Me.Conta1.Enabled = True
        Me.Conta2.Enabled = False
        Me.Conta3.Enabled = False
        Me.Conta4.Enabled = False
        Me.Conta5.Enabled = False
        Me.Conta6.Enabled = False

        Me.Find1.Enabled = True
        Me.Find2.Enabled = False
        Me.Find3.Enabled = False
        Me.Find4.Enabled = False
        Me.Find5.Enabled = False
        Me.Find6.Enabled = False

        Me.DescConta1.Enabled = True
        Me.DescConta2.Enabled = False
        Me.DescConta3.Enabled = False
        Me.DescConta4.Enabled = False
        Me.DescConta5.Enabled = False
        Me.DescConta6.Enabled = False

        Me.Vlr1.Enabled = True
        Me.Vlr2.Enabled = False
        Me.Vlr3.Enabled = False
        Me.Vlr4.Enabled = False
        Me.Vlr5.Enabled = False
        Me.Vlr6.Enabled = False
    End Sub

    Private Sub Vlr1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vlr1.Leave, Vlr2.Leave, Vlr3.Leave, Vlr4.Leave, Vlr5.Leave, Vlr6.Leave

        Select Case CType(sender, TextBox).Name

            Case "Vlr1"

                If String.CompareOrdinal(Me.Vlr1.Text, Me.Vlr1.TextoAntigo) Then
                    If CDbl(NzZero(Me.Vlr1.Text)) > 0 Then
                        Dim Resta As Double = CDbl(NzZero(Me.tValorPedidoCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text))
                        If Resta <> 0 Then
                            If CDbl(NzZero(Me.tValorPedidoCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) < 0 Then
                                MessageBox.Show("A Soma dos Valores de Lançamento é maio que a do Pedido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Me.Vlr1.Focus()
                                Exit Sub
                            End If

                            Me.Conta2.Enabled = True : Me.DescConta2.Enabled = True : Me.Find2.Enabled = True : Me.Vlr2.Enabled = True
                            Me.Vlr2.Text = CDbl(NzZero(Me.tValorPedidoCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text))
                            Me.Vlr3.Text = FormatNumber(0, 2)
                            Me.Vlr4.Text = FormatNumber(0, 2)
                            Me.Vlr5.Text = FormatNumber(0, 2)
                            Me.Vlr6.Text = FormatNumber(0, 2)
                            Me.Conta2.Focus()
                        Else
                            Me.Conta2.Enabled = False : Me.DescConta2.Enabled = False : Me.Find2.Enabled = False : Me.Vlr2.Enabled = False
                            Me.LocalPgto.Focus()
                        End If
                    End If
                End If

            Case "Vlr2"
                If String.CompareOrdinal(Me.Vlr2.Text, Me.Vlr2.TextoAntigo) Then
                    If CDbl(NzZero(Me.Vlr2.Text)) > 0 Then
                        Dim Resta As Double = CDbl(NzZero(Me.tValorPedidoCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text))
                        If Resta <> 0 Then
                            If (CDbl(NzZero(Me.tValorPedidoCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text))) < 0 Then
                                MessageBox.Show("A Soma dos Valores de Lançamento é maio que a do Pedido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Me.Vlr2.Focus()
                                Exit Sub
                            End If

                            Me.Conta3.Enabled = True : Me.DescConta3.Enabled = True : Me.Find3.Enabled = True : Me.Vlr3.Enabled = True
                            Me.Vlr3.Text = CDbl(NzZero(Me.tValorPedidoCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text))
                            Me.Vlr4.Text = FormatNumber(0, 2)
                            Me.Vlr5.Text = FormatNumber(0, 2)
                            Me.Vlr6.Text = FormatNumber(0, 2)
                            Me.Conta3.Focus()
                        Else
                            Me.Conta3.Enabled = False : Me.DescConta3.Enabled = False : Me.Find3.Enabled = False : Me.Vlr3.Enabled = False
                            Me.LocalPgto.Focus()
                        End If
                    End If
                End If
            Case "Vlr3"
                If String.CompareOrdinal(Me.Vlr3.Text, Me.Vlr3.TextoAntigo) Then
                    If CDbl(NzZero(Me.Vlr3.Text)) > 0 Then
                        Dim Resta As Double = CDbl(NzZero(Me.tValorPedidoCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text))
                        If Resta <> 0 Then
                            If (CDbl(NzZero(Me.tValorPedidoCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text))) < 0 Then
                                MessageBox.Show("A Soma dos Valores de Lançamento é maio que a do Pedido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Me.Vlr3.Focus()
                                Exit Sub
                            End If

                            Me.Conta4.Enabled = True : Me.DescConta4.Enabled = True : Me.Find4.Enabled = True : Me.Vlr4.Enabled = True
                            Me.Vlr4.Text = CDbl(NzZero(Me.tValorPedidoCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text))
                            Me.Vlr5.Text = FormatNumber(0, 2)
                            Me.Vlr6.Text = FormatNumber(0, 2)
                            Me.Conta4.Focus()
                        Else
                            Me.Conta4.Enabled = False : Me.DescConta4.Enabled = False : Me.Find4.Enabled = False : Me.Vlr4.Enabled = False
                            Me.LocalPgto.Focus()
                        End If
                    End If
                End If
            Case "Vlr4"
                If String.CompareOrdinal(Me.Vlr4.Text, Me.Vlr4.TextoAntigo) Then
                    If CDbl(NzZero(Me.Vlr4.Text)) > 0 Then
                        Dim Resta As Double = CDbl(NzZero(Me.tValorPedidoCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text))
                        If Resta <> 0 Then
                            If (CDbl(NzZero(Me.tValorPedidoCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text))) < 0 Then
                                MessageBox.Show("A Soma dos Valores de Lançamento é maio que a do Pedido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Me.Vlr4.Focus()
                                Exit Sub
                            End If

                            Me.Conta5.Enabled = True : Me.DescConta5.Enabled = True : Me.Find5.Enabled = True : Me.Vlr5.Enabled = True
                            Me.Vlr5.Text = CDbl(NzZero(Me.tValorPedidoCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text))
                            Me.Vlr6.Text = FormatNumber(0, 2)
                            Me.Conta5.Focus()
                        Else
                            Me.Conta5.Enabled = False : Me.DescConta5.Enabled = False : Me.Find5.Enabled = False : Me.Vlr5.Enabled = False
                            Me.LocalPgto.Focus()
                        End If
                    End If
                End If
            Case "Vlr5"
                If String.CompareOrdinal(Me.Vlr5.Text, Me.Vlr5.TextoAntigo) Then
                    If CDbl(NzZero(Me.Vlr5.Text)) > 0 Then
                        Dim Resta As Double = CDbl(NzZero(Me.tValorPedidoCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text)) - CDbl(NzZero(Me.Vlr5.Text))
                        If Resta <> 0 Then
                            If (CDbl(NzZero(Me.tValorPedidoCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text)) - CDbl(NzZero(Me.Vlr5.Text))) < 0 Then
                                MessageBox.Show("A Soma dos Valores de Lançamento é maio que a do Pedido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Me.Vlr5.Focus()
                                Exit Sub
                            End If

                            Me.Conta6.Enabled = True : Me.DescConta6.Enabled = True : Me.Find6.Enabled = True : Me.Vlr6.Enabled = True
                            Me.Vlr6.Text = CDbl(NzZero(Me.tValorPedidoCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text)) - CDbl(NzZero(Me.Vlr5.Text))
                            Me.Conta6.Focus()
                        Else
                            Me.Conta6.Enabled = False : Me.DescConta6.Enabled = False : Me.Find6.Enabled = False : Me.Vlr6.Enabled = False
                            Me.LocalPgto.Focus()
                        End If
                    End If
                End If
            Case "Vlr6"
                If (CDbl(NzZero(Me.tValorPedidoCompra.Text)) - CDbl(NzZero(Me.Vlr1.Text)) - CDbl(NzZero(Me.Vlr2.Text)) - CDbl(NzZero(Me.Vlr3.Text)) - CDbl(NzZero(Me.Vlr4.Text)) - CDbl(NzZero(Me.Vlr5.Text)) - CDbl(NzZero(Me.Vlr6.Text))) < 0 Then
                    MessageBox.Show("A Soma dos Valores de Lançamento é maio que a do Pedido.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Vlr6.Focus()
                    Exit Sub
                End If

        End Select


        If CDbl(NzZero(Me.tValorPedidoCompra.Text)) < (CDbl(NzZero(Me.Vlr1.Text)) + CDbl(NzZero(Me.Vlr2.Text)) + CDbl(NzZero(Me.Vlr3.Text)) + CDbl(NzZero(Me.Vlr4.Text)) + CDbl(NzZero(Me.Vlr5.Text)) + CDbl(NzZero(Me.Vlr6.Text))) Then
            MessageBox.Show("O Valor dos Lançamentos esta maior que o valor do Pedido, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CType(sender, TextBox).Focus()
            Exit Sub
        End If
    End Sub

#End Region


    Private Sub ContaLancamento_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContaLancamento.Leave
        If String.CompareOrdinal(Me.ContaLancamento.Text, Me.ContaLancamento.TextoAntigo) Then
            AchaContaCR(Me.ContaLancamento.Text, Me.ContaLancamentoDesc)
        End If
    End Sub

    Private Sub ContaLancamento_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ContaLancamento.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.CentroCustoNewLocalizar.ShowDialog()
            AchaContaCR(Me.ContaLancamento.Text, Me.ContaLancamentoDesc)
            Me.ContaLancamento.Focus()

            'My.Forms.BalanceteContasProcura.TipoConta = "D"
            'My.Forms.BalanceteContasProcura.ShowDialog()
        End If
    End Sub
    Public Sub AchaContaCR(ByVal Conta As String, ByVal CampoParaRetornar As Control)

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()
        Dim Sql As String = "Select * from ContasCR2 where CR2 = '" & Conta & "' And Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            CampoParaRetornar.Text = DR.Item("DescCr2") & ""
        Else
            MessageBox.Show("Conta não encontrada, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ContaLancamento.Clear()
            CampoParaRetornar.Text = ""
            Me.ContaLancamento.Focus()
            Exit Sub
        End If
        Cnn.Close()
    End Sub

    Private Sub btFindValor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindValor.Click
        My.Forms.CentroCustoNewLocalizar.ShowDialog()
        AchaContaCR(Me.ContaLancamento.Text, Me.ContaLancamentoDesc)
        Me.ContaLancamento.Focus()
    End Sub

    Private Sub butConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butConfirmar.Click

        If Me.ContaLancamento.Text = "" Then
            MsgBox("A conta de Balançete não pode ser nula", 48, "Validação de dados")
            Me.ContaLancamento.Focus()
            Return
        ElseIf Me.Conta1.Text = "" Then
            MsgBox("O Lançamento de contas não pode ser nula", 48, "Validação de dados")
            Me.Conta1.Focus()
            Return
        ElseIf Me.LocalPgto.Text = "" Then
            MsgBox("O Local de pagamento não pode ser nula", 48, "Validação de dados")
            Me.LocalPgto.Focus()
            Return
        End If


        If ListaPagar.RowCount > 0 Then
            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()
            Dim myTrans As OleDb.OleDbTransaction = CNN.BeginTransaction
            Try

                Dim linha As Integer
                Dim v_Valor As Double = 0
                Dim v_Data As String

                Dim sql As String
                Dim cmd As OleDb.OleDbCommand

                For rowIndex As Integer = 0 To ListaPagar.Rows.Count - 1 Step 1
                    linha = ListaPagar.Item(0, rowIndex).Value
                    v_Valor = ListaPagar.Item(4, rowIndex).Value
                    v_Data = ListaPagar.Item(3, rowIndex).Value
                    sql = "Update Pagar Set ValorDocumento='" & v_Valor & "', Vencimento='" & v_Data & "' where id=" & linha
                    cmd = New OleDb.OleDbCommand(sql, CNN, myTrans)
                    cmd.ExecuteNonQuery()
                Next rowIndex

                Dim sb As StringBuilder = New StringBuilder()

                sb.Append("INSERT INTO Pagar ( Documento, NotaFiscal, CodFornecedor, Fornecedor, DataDocumento, ValorDocumento, Juros, Multa, Desconto, ValorLiquido, Vencimento, Referencia, LocalPgto, Empresa, DataLancamento, Inativo, Destino, IDPedidoCompra, Virtual ) ")
                sb.Append("SELECT Pagar.Documento, Pagar.NotaFiscal, Pagar.CodFornecedor, Pagar.Fornecedor, Pagar.DataDocumento, '" & dResta & "', Pagar.Juros, Pagar.Multa, Pagar.Desconto, Pagar.ValorLiquido, Pagar.Vencimento, Pagar.Referencia, Pagar.LocalPgto, Pagar.Empresa, Pagar.DataLancamento, Pagar.Inativo, Pagar.Destino, Pagar.IDPedidoCompra, Pagar.Virtual ")
                sb.Append("FROM(Pagar) ")
                sb.Append("WHERE (((Pagar.IDPedidoCompra)=" & Me.txtPedido.Text & ") AND ((Pagar.Virtual)=True))")



                Dim sql1 As String = sb.ToString
                Dim cmd1 As New OleDb.OleDbCommand(sql1, CNN, myTrans)


                Dim cmd2 As New OleDb.OleDbCommand("Delete * From Pagar Where id=" & idLinha, CNN, myTrans)
                cmd1.ExecuteNonQuery()
                cmd2.ExecuteNonQuery()

                myTrans.Commit()

                Me.Close()
                Me.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
                myTrans.Rollback()
            Finally
                CNN.Close()
            End Try
        Else
            MsgBox("ATENÇÃO!! O usuário prescisa gerar o paracelamento para prosseguir", 48, "Validação de dados")
            Return
        End If


    End Sub

    Private Sub Vlr1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vlr1.Enter
        Me.Vlr1.Text = Me.tValorPedidoCompra.Text
    End Sub

    Private Sub AceitaSomenteNumeros_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim nonNumberEntered As Boolean
        nonNumberEntered = True
        If (e.KeyChar >= Convert.ToChar(48) AndAlso e.KeyChar <= Convert.ToChar(57)) OrElse e.KeyChar = Convert.ToChar(8) OrElse e.KeyChar = Convert.ToChar(44) Then
            nonNumberEntered = False
        End If
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control
            ' since it is non-numerical. 
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Shared Sub ShortFormDateFormat(ByVal formatting As DataGridViewCellFormattingEventArgs)
        'Aqui define a formatação na hora de criar o controle.
        If formatting.Value IsNot Nothing Then
            Try
                'Dim dateString As System.Text.StringBuilder = New System.Text.StringBuilder()
                Dim theDate As Date = DateTime.Parse(formatting.Value.ToString())

                formatting.Value = theDate.ToShortDateString
                formatting.FormattingApplied = True
            Catch notInDateFormat As FormatException
                'Definido como false no caso de existirem outros manipuladores interessados tentando
                'formatar este exemplo DataGridViewCellFormattingEventArgs.
                formatting.FormattingApplied = False
            End Try
        End If
    End Sub

    Private Sub ListaPagar_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListaPagar.CellEndEdit
        Dim cv As Double = 0
        Dim vValue As String = CDbl(Me.ListaPagar(4, e.RowIndex).Value)
        Try
            'Formata a coluna valor
            Me.ListaPagar(4, e.RowIndex).Value = String.Format("{0:c}", Convert.ToDouble(vValue))
            Dim sobra As Double = 0
            vpar = ListaPagar.CurrentRow.Cells(4).Value
            cp = ListaPagar.CurrentRow.Cells(1).Value 'Passa o valor da coluna P. o numero da parcela

            For rowIndex As Integer = 0 To cp - 1 Step 1 'Conta quantas linha sobraram apartir da linha que está sendo editada.
                sobra += ListaPagar.Item(4, rowIndex).Value 'passa o valor que sobra
            Next

            Me.txtResto.Text = Me.txtTotal.Text - sobra 'total do documento menos a sobra é igual ao resto para dividir
            Dim sP As Integer = i - cp ' total de parcela menos a linha atual é igual ao tanto de parcelas que restam
            cv = FormatNumber((Me.txtResto.Text / sP), 3) 'faz uma formatação de valores

            Dim xx As Double = 0 'usado para resomar as linhas que restam
            For rowIndex As Integer = 0 To ListaPagar.Rows.Count - 1 Step 1
                If rowIndex >= cp Then
                    ListaPagar.Item(4, rowIndex).Value = FormatCurrency(cv, 2)
                End If
                xx += ListaPagar.Item(4, rowIndex).Value
            Next rowIndex

            Dim ii As Byte
            Dim res As Double
            Dim par As Double
            ii = ListaPagar.Rows.Count - 1
            res = xx - CDbl(Me.txtTotal.Text)
            res = FormatNumber(res, 2)
            par = ListaPagar.Item(4, ii).Value - res
            ListaPagar.Item(4, ii).Value = FormatCurrency(par, 2)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ListaPagar_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListaPagar.CellEnter
        Try
            If Me.ListaPagar.CurrentCell.ColumnIndex = 4 Or Me.ListaPagar.CurrentCell.ColumnIndex = 3 Then
                Me.ListaPagar.BeginEdit(True)
            End If
            cp = ListaPagar.CurrentRow.Cells("P").Value
            Dim x As Short = i - cp
            Try

                If x = 0 Then
                    ListaPagar.CurrentRow.Cells("valor").ReadOnly = True

                Else
                    ListaPagar.CurrentRow.Cells("valor").ReadOnly = False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ListaPagar_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles ListaPagar.CellFormatting
        'Evento usado para testar a formatação da coluna 
        If ListaPagar.Columns(e.ColumnIndex).Name = "vencimento" Then
            ShortFormDateFormat(e)
        End If
    End Sub

    Private Sub ListaPagar_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles ListaPagar.CellValidating
        'Validadndo a entrada na celula
        Dim vValue As String 'pegar o valor da celula

        'Aqui valido a coluna vencimento.
        If ListaPagar.Columns(e.ColumnIndex).Name = "vencimento" Then
            vValue = e.FormattedValue.ToString()
            If IsDate(vValue) Then 'Foi uma data; formatação ok!
                ListaPagar.CurrentRow.Cells("vencimento").Value = vValue
            Else 'caso contrario mensagem de advertencia sobre a data
                MsgBox("Data inválida", 48, "Erro na data")
                e.Cancel = True
                SendKeys.Send("{ESC}")
            End If
        End If

        'Valida o entrada de valores em R$ , não permitindo valores em branco.
        Dim x As Integer
        Dim x1 As Integer

        If ListaPagar.Columns(e.ColumnIndex).Name = "valor" Then


            Me.txtResto.Text = ListaPagar.CurrentRow.Cells("valor").Value
            Me.vValorAnterior = e.FormattedValue.ToString()
            x1 = cp - 1 'subtrai do total de parcelas criadas

            If i = ListaPagar.CurrentRow.Cells("P").Value Then 'Verifica se o valor da coluna P é igual a vareavel i
                ListaPagar.Item(4, e.RowIndex).ReadOnly = True 'se for igual não deixa iditar a ultima linha.
            End If

            For rowIndex As Integer = 0 To cp - 1 Step 1  'Loop na coleção rows do dgv 
                If rowIndex = x1 Then
                    x += vValorAnterior
                Else
                    x += ListaPagar.Item(4, rowIndex).Value
                End If
            Next

            Dim sobra As Double
            sobra = Me.txtTotal.Text - x

            If sobra <= 0 Then
                'e.Cancel = True
            End If
        End If
    End Sub

    Private Sub ListaPagar_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles ListaPagar.EditingControlShowing
        'As declarações AddHandler e RemoveHandler permitem que você iniciar
        'e parar o tratamento de eventos para um evento específico a qualquer 
        'momento durante a execução do programa.
        RemoveHandler e.Control.KeyPress, AddressOf AceitaSomenteNumeros_KeyPress

        If CInt((DirectCast((sender), System.Windows.Forms.DataGridView).CurrentCell.ColumnIndex)) = 4 Then
            AddHandler e.Control.KeyPress, AddressOf AceitaSomenteNumeros_KeyPress
        End If
    End Sub


    Private Sub btnGerarParcelas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarParcelas.Click
        Try
            If Me.ListaPagar.RowCount > 0 Then
                MsgBox("Já foi gerado parcelas para este documento, você deverá excluir a parcela atual para gerar uma nova.", 48, "Validação de Dados")
                Exit Sub
            End If


            If Me.parcelas.Text = "" Or Me.parcelas.Text = 0 Then
                MsgBox("Quantidade de parcelas não é válido, O usuário deve informar uma quantidade válida.", 48, "Validação de Dados")
                Me.parcelas.Focus()
                Exit Sub
            End If
            If Me.DataPrimeiroVencimento.Text = "" Then
                MsgBox("O usuário deve informar a data de vencimento da primeira Parcela.", 48, "Validação de Dados")
                Me.DataPrimeiroVencimento.Focus()
                Exit Sub
            End If
            If Me.LocalPgto.Text = "" Then
                MsgBox("O usuário deve informar o local de pagamento para as Parcelas.", 64, "Validação de Dados")
                Me.LocalPgto.Focus()
                Exit Sub
            End If

            If CDate(Me.DataPrimeiroVencimento.Text) < CDate(Me.txtDataLancamento.Text) Then
                MessageBox.Show("A primeira data de vencimento não pode ser menor que a data do documento, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DataPrimeiroVencimento.Focus()
                Exit Sub
            End If

            If String.IsNullOrEmpty(Me.Vlr1.Text) Then
                MessageBox.Show("O valor da conta não pode ser nulo", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            'Dim vValorC As Double = CDbl(nzzero(Me.Vlr1.Text)) + CDbl(nzzero(Me.Vlr2.Text)) + CDbl(nzzero(Me.Vlr3.Text)) + CDbl(nzzero(Me.Vlr4.Text)) + CDbl(nzzero(me.Vlr5.Text) + CDbl(nzzero(Me.Vlr6.Text))



            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim ds As New DataSet()


            Dim Sql As String = String.Empty
            Sql = "SELECT * from Pagar Where Id = -1"

            Dim DAPagar As New OleDb.OleDbDataAdapter(Sql, CNN)
            DAPagar.Fill(ds, "Pagar")

            Dim Venc As DateTime = CDate(Me.DataPrimeiroVencimento.Text)
            Dim vValorParcelado As Double = 0

            Dim vp As Double = 0
            Dim vtemp As Double = 0

            vValorParcelado = FormatNumber((CDbl(Me.tValorPedidoCompra.Text) / Me.parcelas.Text), 2)
            Dim I As Integer = 0

          
            For I = 1 To Me.parcelas.Text

                Dim TBL As DataTable
                TBL = ds.Tables("Pagar")

                Dim DRnovo As DataRow
                DRnovo = TBL.NewRow()
                DRnovo("Documento") = Me.txtPedido.Text & "PC-" & I
                DRnovo("CodFornecedor") = CodFornecedor
                DRnovo("Fornecedor") = Me.lblNomeFornecedor.Text
                DRnovo("DataDocumento") = CDate(Me.txtDataLancamento.Text)
                DRnovo("Vencimento") = CDate(Venc)
                DRnovo("NotaFiscal") = Nz(Me.txtNotaFiscal.Text, 1)

                If Me.parcelas.Text = 1 Then

                    DRnovo("ValorDocumento") = FormatNumber(CDbl(vValorParcelado), 2)
                Else
                    If I = Me.parcelas.Text Then
                        vtemp = FormatNumber((Me.tValorPedidoCompra.Text - vp), 2)

                        DRnovo("ValorDocumento") = FormatNumber(CDbl(vtemp), 2)

                    Else
                        vValorParcelado = Round(vValorParcelado)
                        vp += FormatNumber(vValorParcelado, 2)
                        DRnovo("ValorDocumento") = FormatNumber(CDbl(vValorParcelado), 2)
                    End If

                End If
                DRnovo("LocalPgto") = Nz(Me.LocalPgto.Text, 1)
                DRnovo("Empresa") = CodEmpresa
                DRnovo("IdPedidoCompra") = Me.txtPedido.Text
                DRnovo("Destino") = Nz(Me.Destino.Text, 1)
                DRnovo("Juros") = CDbl(0)
                DRnovo("Multa") = CDbl(0)
                DRnovo("Desconto") = CDbl(0)
                DRnovo("ValorLiquido") = CDbl(0)
                DRnovo("Banco") = CDbl(0)
                DRnovo("ContaValorBaixado") = Nz(Me.ContaLancamento.Text, 1)
                DRnovo("ContaCr") = IIf(ContaLancamento.Text <> "", ContaLancamento.Text, System.DBNull.Value)
                DRnovo("Conta1") = IIf(Conta1.Text <> "", Conta1.Text, System.DBNull.Value)
                DRnovo("Conta2") = IIf(Conta2.Text <> "", Conta2.Text, System.DBNull.Value)
                DRnovo("Conta3") = IIf(Conta3.Text <> "", Conta3.Text, System.DBNull.Value)
                DRnovo("Conta4") = IIf(Conta4.Text <> "", Conta4.Text, System.DBNull.Value)
                DRnovo("Conta5") = IIf(Conta5.Text <> "", Conta5.Text, System.DBNull.Value)
                DRnovo("Conta6") = IIf(Conta6.Text <> "", Conta6.Text, System.DBNull.Value)
                DRnovo("Vlr1") = IIf(NzZero(Vlr1.Text) > 0, Vlr1.Text, System.DBNull.Value)
                DRnovo("Vlr2") = IIf(NzZero(Vlr2.Text) > 0, Vlr2.Text, System.DBNull.Value)
                DRnovo("Vlr3") = IIf(NzZero(Vlr3.Text) > 0, Vlr3.Text, System.DBNull.Value)
                DRnovo("Vlr4") = IIf(NzZero(Vlr4.Text) > 0, Vlr4.Text, System.DBNull.Value)
                DRnovo("Vlr5") = IIf(NzZero(Vlr5.Text) > 0, Vlr5.Text, System.DBNull.Value)
                DRnovo("Vlr6") = IIf(NzZero(Vlr6.Text) > 0, Vlr6.Text, System.DBNull.Value)
                DRnovo("Percent1") = IIf(NzZero(Vlr1.Text) > 0, CDbl(NzZero(Vlr1.Text)) / (CDbl(Me.tValorPedidoCompra.Text)) * 100, System.DBNull.Value)
                DRnovo("Percent2") = IIf(NzZero(Vlr2.Text) > 0, CDbl(NzZero(Vlr2.Text)) / (CDbl(tValorPedidoCompra.Text)) * 100, System.DBNull.Value)
                DRnovo("Percent3") = IIf(NzZero(Vlr3.Text) > 0, CDbl(NzZero(Vlr3.Text)) / (CDbl(tValorPedidoCompra.Text)) * 100, System.DBNull.Value)
                DRnovo("Percent4") = IIf(NzZero(Vlr4.Text) > 0, CDbl(NzZero(Vlr4.Text)) / (CDbl(tValorPedidoCompra.Text)) * 100, System.DBNull.Value)
                DRnovo("Percent5") = IIf(NzZero(Vlr5.Text) > 0, CDbl(NzZero(Vlr5.Text)) / (CDbl(tValorPedidoCompra.Text)) * 100, System.DBNull.Value)
                DRnovo("Percent6") = IIf(NzZero(Vlr6.Text) > 0, CDbl(NzZero(Vlr6.Text)) / (CDbl(tValorPedidoCompra.Text)) * 100, System.DBNull.Value)
                TBL.Rows.Add(DRnovo)
                Venc = Venc.AddMonths(1)
            Next I
            Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAPagar)
            DAPagar.Update(ds, "Pagar")
            ds.Dispose()

            CNN.Close()
            System.Threading.Thread.Sleep(100)
            Me.EncheGrid()
            MsgBox("Parcelas Geradas com sucesso.", 64, "Validação de Dados")
            Me.ListaPagar.Focus()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub parcelas_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parcelas.Validated
        If NzZero(Me.parcelas.Text) > 6 Then
            MsgBox("A quantidade de parcela não pode ser maior que 6", 48, "Validação de dados")
            Me.parcelas.Text = 6
            Return
        End If
    End Sub

    Private Sub txtPedido_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPedido.Leave

        'Faz a verificação na tabela pagar, se tem registro relacionado com o pedido de compra.
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = "SELECT * From Pagar where Virtual=True AND idPedidoCompra=" & Me.txtPedido.Text
        Dim DR As OleDb.OleDbDataReader
        Try
            CNN.Open()
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)
            DR = cmd.ExecuteReader
            DR.Read()

            If DR.HasRows Then
                'Encontrei registro.
                CodFornecedor = DR.Item("CodFornecedor").ToString
                Me.lblNomeFornecedor.Text = DR.Item("Fornecedor").ToString
                Me.txtValorPendente.Text = FormatCurrency(DR.Item("ValorDocumento").ToString, 2)
                Me.txtDataLancamento.Text = DR.Item("dataDocumento").ToString
                idLinha = DR.Item("id").ToString
                Me.GroupPanel1.Enabled = True
                Me.GroupPanel2.Enabled = True
                Me.GroupPanel3.Enabled = True
            Else
                'Não encontrei registro  pedido de compra
                MessageBox.Show("Registro não encontrado", "Informação de busca", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.GroupPanel1.Enabled = False
                Me.GroupPanel2.Enabled = False
                Me.GroupPanel3.Enabled = False
                Me.txtPedido.Clear()
                Me.txtPedido.Focus()
                idLinha = 0
                CodFornecedor = 0
                Me.lblNomeFornecedor.Text = ""
                Me.txtValorPendente.Clear()
            End If

        Catch ex As Exception
            Throw ex
        Finally
            CNN.Close()
        End Try
    End Sub

    Private Sub txtPedido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPedido.KeyPress
        'usa a função onlyNumber para digitar somente numeros.
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(clsPC.OnlyNumber(KeyAscii)) 'Função encontra-se na classe clsPedidoCompra.
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub tValorPedidoCompra_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tValorPedidoCompra.Leave
        Try
            If CDbl(Me.tValorPedidoCompra.Text) > CDbl(Me.txtValorPendente.Text) Or CDbl(Me.tValorPedidoCompra.Text) <= 0 Then
                MessageBox.Show("Os valores não coincidem", "Erro nos valores", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.tValorPedidoCompra.Clear()
                Me.tValorPedidoCompra.Focus()
                Return
            Else
                dResta = CDbl(Me.txtValorPendente.Text) - CDbl(Me.tValorPedidoCompra.Text)
                Me.Conta1.Clear()
                Me.Conta2.Clear()
                Me.Conta3.Clear()
                Me.Conta4.Clear()
                Me.Conta5.Clear()
                Me.Conta6.Clear()
                Me.DescConta1.Clear()
                Me.DescConta2.Clear()
                Me.DescConta3.Clear()
                Me.DescConta4.Clear()
                Me.DescConta5.Clear()
                Me.DescConta6.Clear()

                Me.Vlr1.Clear()
                Me.Vlr2.Clear()
                Me.Vlr3.Clear()
                Me.Vlr4.Clear()
                Me.Vlr5.Clear()
                Me.Vlr6.Clear()


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PedCompraFinanceiro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class