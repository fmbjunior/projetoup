Imports System.Data.OleDb
Public Class CondicaoPagamentoBuscaMP
    Dim bs As BindingSource
    Dim db As New clsBancoDados
    Private Sub CondicaoPagamentoBusca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New OleDbConnection()

        conn = db.AbreBanco

        Dim sql As String

        If CDbl(My.Forms.frmPedidoMP.ValorAFaturar.Text) > 0 And CDbl(My.Forms.frmPedidoMP.ValorAVista.Text) = 0 Then
            sql = "Select CodFormaPgto, Descrição, DiasParcelamento from FormaPgto where TemEntrada=false"
        Else
            sql = "Select CodFormaPgto, Descrição, DiasParcelamento from FormaPgto where TemEntrada=true"
        End If



        Dim CMD As New OleDb.OleDbCommand(sql, conn)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet
        Da.Fill(ds, "Table")

        'Crio um BindingSource
        bs = New BindingSource()
        'Conecto meu BindinSource com meu DataSet
        bs.DataSource = ds.Tables(0).DefaultView
        Da.Dispose()
        conn.Close()
    End Sub
    Private Sub butFechar_Click(sender As Object, e As EventArgs) Handles butFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub txtProcura_TextChanged(sender As Object, e As EventArgs) Handles txtProcura.TextChanged
        bs.Filter = "Descrição like '%" & txtProcura.Text & "%'"
        'Preencho meu DataGridView com meu BindinSource
        If Len(txtProcura.Text) > 0 Then
            Me.DgvItem.DataSource = bs
        Else
            bs.Filter = "Descrição like ''"
        End If
    End Sub
    Private Sub DgvItem_KeyDown(sender As Object, e As KeyEventArgs) Handles DgvItem.KeyDown
        If e.KeyCode = Keys.Return Then

            My.Forms.frmPedidoMP.CodigoPagamento.Text = Me.DgvItem.CurrentRow.Cells("gCodigo").Value
            My.Forms.frmPedidoMP.DescricaoPagamento.Text = Me.DgvItem.CurrentRow.Cells("gDescricao").Value

            Me.Close()
            Me.Dispose()
        End If
    End Sub
    Private Sub A3_CheckedChanged(sender As Object, e As EventArgs) Handles A3.CheckedChanged
        If A3.Checked Then
            bs.Filter = "Descrição like '%'"
            'Preencho meu DataGridView com meu BindinSource
            Me.DgvItem.DataSource = bs
        End If
    End Sub

    Private Sub DgvItem_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvItem.CellClick
        My.Forms.frmPedidoMP.CodigoPagamento.Text = Me.DgvItem.CurrentRow.Cells("gCodigo").Value
        My.Forms.frmPedidoMP.DescricaoPagamento.Text = Me.DgvItem.CurrentRow.Cells("gDescricao").Value
        Me.Close()
        Me.Dispose()
    End Sub
End Class