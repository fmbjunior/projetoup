Public Class frmBuscarOrdem
    Dim bs As BindingSource
    Dim db As New clsBancoDados
    Dim fieldFilter As String
    Dim ORDEM As New clsProducao
    Private Sub frmBuscarOrdem_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                rdbcliente.Checked = True
                txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
                txtProcura.Focus()
            Case Keys.F4
                Me.rdbNumeroOrdem.Checked = True
                txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
                txtProcura.Focus()
            Case Keys.F5
                Me.rdbData.Checked = True
                txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
                txtProcura.Focus()
        End Select
    End Sub
    Private Sub txtProcura_Leave(sender As Object, e As EventArgs) Handles txtProcura.Leave
        If rdbcliente.Checked Then
            fieldFilter = "NomeCliente like " & "'%" & txtProcura.Text & "%'"
        ElseIf Me.rdbPedido.Checked Then
            fieldFilter = "NumeroPedido=" & txtProcura.Text
        ElseIf Me.rdbNumeroOrdem.Checked Then
            fieldFilter = "NumeroOrdem=" & txtProcura.Text
        ElseIf Me.rdbData.Checked Then
            fieldFilter = "DataProducao=#" & Format(CDate(Me.txtProcura.Text), "MM/dd/yyyy") & "#"
        End If

        Try
            Dim ds As New DataSet
            ORDEM.BuscarGrid(ds)
            'Crio um BindingSource
            bs = New BindingSource()
            'Conecto meu BindinSource com meu DataSet
            bs.DataSource = ds.Tables(0).DefaultView
            bs.Filter = fieldFilter
            'Preencho meu DataGridView com meu BindinSource
            If Len(txtProcura.Text) > 0 Then
                Me.DgvItem.DataSource = bs
            Else
                bs.Filter = fieldFilter & "like ''"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DgvItem_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvItem.CellDoubleClick
        My.Forms.frmProducao.vOrdem = Me.DgvItem.CurrentRow.Cells("gcodigo").Value
        My.Forms.frmProducao.vPedido = Me.DgvItem.CurrentRow.Cells("gNumeroPedido").Value
        butFechar_Click(sender, e)
    End Sub

    Private Sub butFechar_Click(sender As Object, e As EventArgs) Handles butFechar.Click
        Me.Dispose()
    End Sub
End Class