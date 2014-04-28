Public Class DuplicataAvulsoLocalizar

    Dim bs As BindingSource
    Dim ds As New DataSet

    Private Sub DuplicataAvulsoLocalizar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            Me.txtProcura.Focus()
        End If
    End Sub
    Private Sub DuplicataAvulsoLocalizar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim sql As String
        sql = "SELECT [DuplicataAvulso].[DCodigo], [DuplicataAvulso].[DNF], [DuplicataAvulso].[DCodigoCliente], [Clientes].[Nome], [DuplicataAvulso].[DDataEmissao] FROM DuplicataAvulso INNER JOIN Clientes ON [DuplicataAvulso].[DCodigoCliente]=[Clientes].[Codigo];"
        Dim CMD As New OleDb.OleDbCommand(sql, CNN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet
        Da.Fill(ds, "Table")

        'Crio um BindingSource
        bs = New BindingSource()
        'Conecto meu BindinSource com meu DataSet
        bs.DataSource = ds.Tables(0).DefaultView

        'Preencho meu DataGridView com meu BindinSource
        Me.DgvItem.DataSource = bs
        Da.Dispose()
        CNN.Close()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        RetornoProcura = 0
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub DgvItem_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellDoubleClick
        Dim xRet(3)

        xRet(0) = Me.DgvItem.CurrentRow.Cells("ID").Value
        xRet(1) = Me.DgvItem.CurrentRow.Cells("CodCliente").Value
        xRet(2) = Me.DgvItem.CurrentRow.Cells("Nome").Value

        RetornoProcura = xRet(0)
        DuplicataAvulso.txtCodigo.Text = xRet(0)
        DuplicataAvulso.txtCodigoCliente.Text = xRet(1)
        DuplicataAvulso.txtNomeCliente.Text = xRet(2)
        
        Me.Close()
    End Sub

    Private Sub DgvItem_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DgvItem.KeyDown

        If e.KeyCode = Keys.Return Then
            Dim xRet(3)

            xRet(0) = Me.DgvItem.CurrentRow.Cells("ID").Value
            xRet(1) = Me.DgvItem.CurrentRow.Cells("CodCliente").Value
            xRet(2) = Me.DgvItem.CurrentRow.Cells("Nome").Value

            RetornoProcura = xRet(0)
            DuplicataAvulso.txtCodigo.Text = xRet(0)
            DuplicataAvulso.txtCodigoCliente.Text = xRet(1)
            DuplicataAvulso.txtNomeCliente.Text = xRet(2)
            Me.Close()

        End If
    End Sub
   
    Private Sub txtProcura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProcura.TextChanged
        bs.Filter = "nome like '%" & txtProcura.Text & "%'"
    End Sub
End Class