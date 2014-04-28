Public Class OSor�amentoProcura
    Dim DsProcura As DataSet
    Dim vField As String
    Private Sub TxtProcura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtProcura.KeyPress
        Dim Tecla As Short = Asc(e.KeyChar)

        If Tecla = 13 Then
            System.Windows.Forms.SendKeys.Send("{Tab}")
            Tecla = 0
        End If
    End Sub

    Private Sub TxtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProcura.Leave
        Dim Conn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Conn.Open()
        Dim filter As String = ""

        If Cliente.Checked Then
            vField = "Orcamento.NomeCliente"
            filter = vField & " like '%" & TxtProcura.Text & "%'"
        ElseIf Pedido.Checked Then
            vField = "Orcamento"
            filter = vField & " like '%" & TxtProcura.Text & "%'"
        ElseIf Todos.Checked Then
            vField = "Orcamento.NomeCliente"
            filter = vField & " like '%'"
        End If

        Dim sql As String


        sql = "SELECT Orcamento.Orcamento, Orcamento.NomeCliente, Clientes.Cidade, Orcamento.TotalOrcamento, Orcamento.DataOrcamento, Orcamento.ObsServico, IIf([GeradoPedido]=True,'CONFIRMADO','ANDAMENTO') AS St FROM Clientes RIGHT JOIN Orcamento ON Clientes.Codigo = Orcamento.C�digoCliente WHERE " & filter & " And Orcamento.Empresa = " & CodEmpresa & " And Orcamento.Inativo = False ORDER BY Orcamento.Orcamento DESC"
        Dim CMD As New OleDb.OleDbCommand(sql, Conn)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet
        Da.Fill(ds, "Table")

        Dim i As Integer
        i = ds.Tables(0).Rows.Count

        Me.dgvItem.DataSource = ds.Tables(0).DefaultView
        Da.Dispose()
        Conn.Close()

    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAtualizar.Click
        RetornoProcura = ""



        RetornoProcura = Me.dgvItem.CurrentRow.Cells("g_orcamento").Value


        If RetornoProcura = "" Then
            MsgBox("O usu�rio deve informar um iten da lista de procura.", 64, "Valida��o de Dados")
            Me.dgvItem.Focus()
            Exit Sub
        End If
        Me.Close()
        Me.Dispose()
    End Sub
    
    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        btAtualizar_Click(sender, e)
    End Sub

    Private Sub Or�amentoProcura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            Me.TxtProcura.Clear()
            Me.TxtProcura.Focus()
        End If
    End Sub

    Private Sub TelaProcura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cliente.Checked = True
        Me.TxtProcura.Focus()
    End Sub

    Private Sub Cliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cliente.Click
        Me.TxtProcura.Focus()
    End Sub

    Private Sub NotaFiscal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pedido.Click
        Me.TxtProcura.Focus()
    End Sub

    Private Sub MyLista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btAtualizar_Click(sender, e)
        End If
    End Sub

    Private Sub Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Todos.CheckedChanged
        TxtProcura_Leave(sender, e)
    End Sub


    Private Sub dgvItem_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvItem.SelectionChanged
        Try

            Obs.Text = Me.dgvItem.CurrentRow.Cells("g_obs").Value

        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvItem_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvItem.CellDoubleClick
        btAtualizar_Click(sender, e)
    End Sub

    Private Sub dgvItem_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvItem.KeyDown
        If e.KeyCode = Keys.Enter Then
            btAtualizar_Click(sender, e)
        End If
    End Sub
End Class