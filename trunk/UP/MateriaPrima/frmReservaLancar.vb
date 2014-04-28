Imports System.Data.OleDb
Public Class frmReservaLancar
    Dim db As New clsBancoDados
    Dim clReserva As New ReservaMP
    Dim dEst As Double = 0
    Dim dRes As Double = 0
    Dim dDisp As Double = 0
    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BuscaProduto(ByVal xId As Integer)
        Dim conn As New OleDbConnection
        conn = db.AbreBanco

        Dim Sql As String = "Select CodigoProduto,QuantidadeEstoque,Reserva from Produtos where Inativo=false And Tipo=2 And CodigoProduto = " & xId
        Dim CMD As OleDb.OleDbCommand = New OleDb.OleDbCommand(Sql, conn)
        Dim Dr As OleDb.OleDbDataReader
        Try
            Dr = CMD.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                dEst = Dr.Item("QuantidadeEstoque")
                dRes = Dr.Item("Reserva")
                dDisp = dEst - dRes
                Me.lblEstoqueFisico.Text = FormatNumber(dEst, 5)
                Me.lblReservado.Text = FormatNumber(dRes, 5)
                Me.lblDisponivel.Text = FormatNumber(dDisp, 5)
            Else
                MessageBox.Show("Produto não cadastrado no sistema", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.lblEstoqueFisico.Text = FormatNumber(0, 5)
                Me.lblReservado.Text = FormatNumber(0, 5)
                Me.lblDisponivel.Text = FormatNumber(0, 5)
                Me.txtProduto.Clear()
                Me.txtQtd.Clear()
                Me.txtProduto.Focus()
                Dr.Close()
                conn.Close()
                Exit Sub
            End If
            Dr.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.lblEstoqueFisico.Text = FormatNumber(0, 5)
            Me.lblReservado.Text = FormatNumber(0, 5)
            Me.lblDisponivel.Text = FormatNumber(0, 5)
            Me.txtProduto.Clear()
            Me.txtQtd.Clear()
        End Try
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        My.Forms.frmMPBusca.ShowDialog()
        If Not String.IsNullOrEmpty(Retorno) Then
            Me.txtProduto.Text = Retorno
            BuscaProduto(Retorno)
        End If
    End Sub
    Private Sub btnAdicionarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionarItem.Click
        If String.IsNullOrEmpty(Me.txtProduto.Text) Then
            Return
        ElseIf String.IsNullOrEmpty(Me.txtQtd.Text) Or Me.txtQtd.Text = "" Or Double.Parse(Me.txtQtd.Text) = 0 Then
            Return
        End If

        If CDbl(Me.txtQtd.Text) > CDbl(Me.lblDisponivel.Text) Then
            MessageBox.Show("A quantidade não pode ser maior que o Estoque Disponível", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtQtd.Focus()
            Return
        End If

        With clReserva
            .ResCodigoMP = Me.txtProduto.Text
            .ResCodigoPedido = My.Forms.frmPedidoMP.NumeroPedido.Text
            .ResQtd = Me.txtQtd.Text
            .gravar()
            .AtGrade(.ResCodigoPedido)
            .AtSaldoReserva(.ResCodigoMP)
        End With
        Me.txtQtd.Clear()
        Me.txtProduto.Clear()
        Me.lblEstoqueFisico.Text = "0,00000"
        Me.lblReservado.Text = "0,00000"
        Me.lblDisponivel.Text = "0,00000"
        Me.txtProduto.Focus()
    End Sub

    Private Sub txtProduto_Leave(sender As Object, e As EventArgs) Handles txtProduto.Leave
        If Not String.IsNullOrEmpty(Me.txtProduto.Text) Then
            BuscaProduto(Me.txtProduto.Text)
        End If
        Retorno = Nothing
    End Sub

    Private Sub txtProduto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProduto.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.frmMPBusca.ShowDialog()
            If Not String.IsNullOrEmpty(Retorno) Then
                Me.txtProduto.Text = Retorno
                BuscaProduto(Me.txtProduto.Text)
            End If
        End If
    End Sub
End Class