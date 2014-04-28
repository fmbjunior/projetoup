Public Class Permissoes

    Public TelaSelect As String = String.Empty
    Public TelaDescri As String = String.Empty

    Private Sub ListaPermissao_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles ListaPermissao.NodeMouseClick
        If UCase(e.Node.Tag) = "S" Then
            TelaSelect = e.Node.Name
            TelaDescri = e.Node.ToolTipText.ToString
        Else
            TelaSelect = ""
            TelaDescri = ""
        End If
    End Sub

    Private Sub ListaPermissao_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles ListaPermissao.NodeMouseDoubleClick
        If UCase(e.Node.Tag) = "S" Then
            TelaSelect = e.Node.Name
            TelaDescri = e.Node.ToolTipText.ToString
            My.Forms.PermissaoAddEdd.ShowDialog()
        Else
            TelaSelect = ""
            TelaDescri = ""
        End If
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Permissoes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ListaPermissao.Nodes("Permissao").Expand()
    End Sub

    Private Sub AddPermissãoGrupoDeUsuárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPermissãoGrupoDeUsuárioToolStripMenuItem.Click
        If TelaSelect = "" Then
            MessageBox.Show("O usuário deve selecionar o item para adicionar permissão.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        My.Forms.PermissaoAddGrupo.ShowDialog()
    End Sub

    Private Sub btCopiarDe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCopiarDe.Click
        My.Forms.PermissoesCopiarDe.ShowDialog()
    End Sub

    Private Sub ListaPermissao_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles ListaPermissao.AfterSelect

    End Sub
End Class