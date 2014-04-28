Imports System.Data.OleDb
Public Class PedidoMPBusca
    Dim bs As BindingSource
    Dim db As New clsBancoDados
    Dim fieldFilter As String
    Dim Ped As New clsPedidoMP

    Private Sub txtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProcura.Leave

        If rdbcliente.Checked Then
            fieldFilter = "Cliente like " & "'%" & txtProcura.Text & "%'"
        ElseIf Me.rdbvendedor.Checked Then
            fieldFilter = "Vendedor like" & "'%" & txtProcura.Text & "%'"
        ElseIf Me.rdbcodigovenda.Checked Then
            fieldFilter = "NumeroPedido=" & txtProcura.Text
        ElseIf Me.rdbData.Checked Then
            fieldFilter = "DataPedido=#" & Format(CDate(Me.txtProcura.Text), "MM/dd/yyyy") & "#"
        End If

        Try


            Dim ds As New DataSet
            Ped.EncheGrid(ds, sTipoBusca)
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
    Private Sub DgvItem_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellDoubleClick
        Retorno = Me.DgvItem.CurrentRow.Cells("gcodigo").Value
        butFechar_Click(sender, e)
    End Sub
    Private Sub PedidoMPBusca_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                rdbcliente.Checked = True
                txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
                txtProcura.Focus()
            Case Keys.F3
                Me.rdbvendedor.Checked = True
                txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
                txtProcura.Focus()
            Case Keys.F4
                Me.rdbcodigovenda.Checked = True
                txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
                txtProcura.Focus()
            Case Keys.F5
                Me.rdbData.Checked = True
                txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
                txtProcura.Focus()
        End Select
    End Sub
    Private Sub PedidoMPBusca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fieldFilter = "Cliente "
    End Sub
    Private Sub butFechar_Click(sender As Object, e As EventArgs) Handles butFechar.Click
        Me.Dispose()
    End Sub
    Private Sub txtProcura_Enter(sender As Object, e As EventArgs) Handles txtProcura.Enter
        txtProcura.Clear()
        If Me.rdbData.Checked Then
            txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Else
            txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        End If
    End Sub

    Private Sub rdbcliente_CheckedChanged(sender As Object, e As EventArgs) Handles rdbcliente.CheckedChanged, rdbcodigovenda.CheckedChanged, rdbvendedor.CheckedChanged, rdbData.CheckedChanged
        If rdbcliente.Checked Or rdbcodigovenda.Checked Or rdbData.Checked Or rdbvendedor.Checked Then
            Me.txtProcura.Focus()
        End If
    End Sub
End Class