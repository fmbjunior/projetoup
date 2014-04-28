Public Class PermissaoGetPost

    Private Sub PermissaoGetPost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostrarDados()
    End Sub



    Private Sub MostrarDados()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "Select * from getAutorizacao Where getAutorizacao.Status = 'Solicitação'"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Lista.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub Lista_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellClick

        If e.ColumnIndex = Me.cRevogada.Index AndAlso e.RowIndex >= 0 Then
            If MessageBox.Show("Deseja negar o uso desta solicitação.", "Validação de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                Dim vId As String = Me.Lista.CurrentRow.Cells("cID").Value
                NegarAutorizar(vId, "Revogado")
                MostrarDados()
            End If
        End If

        If e.ColumnIndex = Me.cAutorizado.Index AndAlso e.RowIndex >= 0 Then
            If MessageBox.Show("Deseja Autorizar o uso desta solicitação.", "Validação de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                Dim vId As String = Me.Lista.CurrentRow.Cells("cID").Value
                NegarAutorizar(vId, "Autorizado")
                MostrarDados()
            End If
        End If


    End Sub


    Private Sub NegarAutorizar(ByVal Id As Integer, ByVal Ação As String)

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "update getAutorizacao set Status = @1, StatusModificadoPor = @2 where Id = " & Id
        Dim cmdRevogada As New OleDb.OleDbCommand(Sql, CNN)

        cmdRevogada.Parameters.Add(New OleDb.OleDbParameter("@1", Ação))
        cmdRevogada.Parameters.Add(New OleDb.OleDbParameter("@2", UserAtivo))

        Try
            cmdRevogada.ExecuteNonQuery()
            MessageBox.Show("Informação enviada", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CNN.Close()
            MostrarDados()

        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try
    End Sub
End Class