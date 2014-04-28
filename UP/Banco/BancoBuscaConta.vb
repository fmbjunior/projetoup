Public Class BancoBuscaConta

    Private Sub BancoBuscaConta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

            CNN.Open()

            Dim sql As String

            sql = "Select Codigo, Nomebanco, contacorrente from Banco Where Banco.Inativo = False"

            Dim CMD As New OleDb.OleDbCommand(sql, CNN)
            Dim Da As New OleDb.OleDbDataAdapter(CMD)

            Dim ds As New DataSet
            Da.Fill(ds, "Table")

            Me.DgvItem.DataSource = ds.Tables("Table").DefaultView

            Da.Dispose()
            CNN.Close()


        Catch oE As System.Exception
            Select Case Err.Number
                Case 5
                    MsgBox(oE.Message)
                Case Else
                    MsgBox(oE.Message)
            End Select
        End Try
    End Sub

    Private Sub DgvItem_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DgvItem.KeyDown
        If e.KeyCode = Keys.Return Then
            If Me.DgvItem.RowCount > 0 Then
                RetornoProcura = (Me.DgvItem.CurrentRow.Cells("gCodigo").Value)
            End If
            Me.Close()
            Me.Dispose()
        End If
    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub DgvItem_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellDoubleClick

        If Me.DgvItem.RowCount > 0 Then
            RetornoProcura = (Me.DgvItem.CurrentRow.Cells("gCodigo").Value)
        End If
        Me.Close()
        Me.Dispose()
    End Sub
End Class