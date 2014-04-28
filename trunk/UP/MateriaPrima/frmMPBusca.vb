Imports System.Data.OleDb
Public Class frmMPBusca
    Dim bs As BindingSource
    Dim db As New clsBancoDados
    'Dim clsMP As New clsProdutoMP

    Private Sub ProdutosBusca_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            Me.optDesc.Checked = True
            Me.txtProcura.Clear()
            Me.txtProcura.Focus()
        ElseIf e.KeyCode = Keys.F3 Then
            Me.optCodigo.Checked = True
            Me.txtProcura.Clear()
            Me.txtProcura.Focus()
        End If
    End Sub
    Private Sub ProdutosBusca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As New OleDbConnection()

        conn = db.AbreBanco

        Dim sql As String

        sql = "SELECT CodigoProduto,Descrição, QuantidadeEstoque From Produtos Where Tipo=2 And Inativo=False"

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
    Private Sub txtProcura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProcura.TextChanged
        If optDesc.Checked = True Then
            bs.Filter = "Descrição like '%" & txtProcura.Text & "%'"
        ElseIf Me.optCodigo.Checked = True Then
            bs.Filter = "CodigoProduto =    '" & NzZero(txtProcura.Text) & "'"
        End If
        'Preencho meu DataGridView com meu BindinSource
        If Len(txtProcura.Text) > 0 Then
            Me.DgvItem.DataSource = bs
        Else
            bs.Filter = "Descrição like ''"
        End If
    End Sub

    Private Sub butFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub DgvItem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DgvItem.KeyDown
        If e.KeyCode = Keys.Return Then
            Retorno = Me.DgvItem.CurrentRow.Cells("codigo").Value
            Me.Close()
            Me.Dispose()
        End If
    End Sub

    Private Sub DgvItem_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvItem.CellClick
        Retorno = Me.DgvItem.CurrentRow.Cells("codigo").Value
        Me.Close()
        Me.Dispose()
    End Sub
End Class