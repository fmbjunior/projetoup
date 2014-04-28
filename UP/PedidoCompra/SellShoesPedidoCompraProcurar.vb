Public Class SellShoesPedidoCompraProcurar
    Private Sub TxtProcura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtProcura.KeyPress
        Dim Tecla As Short = Asc(e.KeyChar)

        If Tecla = 13 Then
            System.Windows.Forms.SendKeys.Send("{Tab}")
            Tecla = 0
        End If
    End Sub

    Private Sub TxtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProcura.Leave
        If Me.TxtProcura.Text = "" Then
            Exit Sub
        End If
        BuscarCompra()
    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub CompraProcurar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Fornecedor.Checked = True
        Me.TxtProcura.Focus()
    End Sub

    Private Sub Fornecedor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fornecedor.Click
        Me.TxtProcura.Focus()
    End Sub


    Private Sub MostrarTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarTodos.CheckedChanged
        BuscarCompra()
    End Sub


    Private Sub BuscarCompra()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Dim CampoFilter As String = ""

        If Me.PedidoCompra.Checked = True Then
            If Me.TxtProcura.Text = "" Then
                Exit Sub
            End If
            CampoFilter = "CodigoPedidoCompra"
            Sql = "SELECT PedidoCompra.CodigoPedidoCompra, PedidoCompra.DataLancamento, PedidoCompra.DataPrevistaEntrega, PedidoCompra.TotalPedidoCompra,PedidoCompra.Confirmado,PedidoCompra.Inativo,PedidoCompra.Status, Fornecedor.RazãoSocial FROM PedidoCompra INNER JOIN Fornecedor ON PedidoCompra.CodigoFornecedor = Fornecedor.CódigoFornecedor WHERE " & CampoFilter & " Like '" & Me.TxtProcura.Text & "' & ''"
        End If

        If Me.Fornecedor.Checked = True Then
            If Me.TxtProcura.Text = "" Then
                Exit Sub
            End If
            CampoFilter = "Fornecedor.RazãoSocial"
            Sql = "SELECT PedidoCompra.CodigoPedidoCompra,PedidoCompra.DataLancamento, PedidoCompra.DataPrevistaEntrega, PedidoCompra.TotalPedidoCompra,PedidoCompra.Confirmado,PedidoCompra.Inativo,PedidoCompra.Status, Fornecedor.RazãoSocial FROM PedidoCompra INNER JOIN Fornecedor ON PedidoCompra.CodigoFornecedor = Fornecedor.CódigoFornecedor WHERE " & CampoFilter & " Like '%" & Me.TxtProcura.Text & "%'"
        End If

        If Me.MostrarTodos.Checked = True Then
            Sql = "SELECT PedidoCompra.CodigoPedidoCompra, PedidoCompra.DataLancamento, PedidoCompra.DataPrevistaEntrega, PedidoCompra.TotalPedidoCompra,PedidoCompra.Confirmado,PedidoCompra.Inativo,PedidoCompra.Status, Fornecedor.RazãoSocial FROM PedidoCompra INNER JOIN Fornecedor ON PedidoCompra.CodigoFornecedor = Fornecedor.CódigoFornecedor"
        End If

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Lista.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub Lista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles lista.CellDoubleClick
        Dim vID As Integer
        vID = CInt(Me.lista.CurrentRow.Cells("IDp").Value)

        RetornoProcura = vID


        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub PedidoCompra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PedidoCompra.CheckedChanged, Fornecedor.CheckedChanged
        If Me.PedidoCompra.Checked = True Then
            Me.TxtProcura.Focus()
        ElseIf Me.Fornecedor.Checked = True Then
            Me.TxtProcura.Focus()
        End If
    End Sub

    Private Sub lista_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles lista.CellFormatting


        If Me.lista.Item("gConfirmado", e.RowIndex).Value = True And Me.lista.Item("gcancelado", e.RowIndex).Value = False Then
            Me.lista.Item("gStatus", e.RowIndex).Value = "CONFIRMADO"
            Me.lista.Item("gStatus", e.RowIndex).Style.ForeColor = Color.Blue
        ElseIf Me.lista.Item("gConfirmado", e.RowIndex).Value = True And Me.lista.Item("gcancelado", e.RowIndex).Value = True Then
            Me.lista.Item("gStatus", e.RowIndex).Value = "CANCELADO"
            Me.lista.Item("gStatus", e.RowIndex).Style.ForeColor = Color.Red
        ElseIf Me.lista.Item("gConfirmado", e.RowIndex).Value = False Then
            Me.lista.Item("gStatus", e.RowIndex).Value = "EM ABERTO"
            Me.lista.Item("gStatus", e.RowIndex).Style.ForeColor = Color.Green
        End If
    End Sub

    Private Sub lista_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles lista.CellPainting
       
    End Sub


    Private Sub lista_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles lista.Paint
        
    End Sub
End Class