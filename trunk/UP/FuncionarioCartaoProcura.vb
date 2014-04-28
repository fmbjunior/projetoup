Public Class FuncionarioCartaoProcura

   

    Private Sub Buscar()
        If Me.TxtProcura.Text = "" Then
            Exit Sub
        End If

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT FuncionarioCartao.idCartao, FuncionarioCartao.DataCadastro, FuncionarioCartao.DataExpiracao, FuncionarioCartao.Inativo, Funcionários.Nome FROM Funcionários INNER JOIN FuncionarioCartao ON Funcionários.CódigoFuncionário = FuncionarioCartao.Funcionario WHERE Funcionários.Nome like '%" & Me.TxtProcura.Text & "%'"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Lista.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        Cnn.Close()
        Me.TxtProcura.Clear()

    End Sub

    Private Sub TxtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProcura.Leave
        If String.CompareOrdinal(Me.TxtProcura.Text, Me.TxtProcura.TextoAntigo) Then
            Buscar()
        End If
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Lista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellDoubleClick

        If My.Forms.FuncionarioCartao.Visible = True Then My.Forms.FuncionarioCartao.idCartao.Text = Me.Lista.CurrentRow.Cells(0).Value

        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub FuncionarioCartaoProcura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class