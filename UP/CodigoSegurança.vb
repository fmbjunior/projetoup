Public Class CodigoSegurança

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub CodigoSegurança_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim Num As New Random
        Dim Tempo As Integer = 0

        Tempo = Num.Next(1, 99999)

        Dim HH As DateTime = Now

        Me.Msg.Text = "O Código de Segurança é:"
        Me.Cod.Text = CInt(CInt((CDate(DataDia).Day * CDate(DataDia).Month) * CDate(DataDia).Year) / CInt(HH.Hour)) + CInt(Tempo)
    End Sub

    
    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click

        Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim DS As New DataSet()
        Dim Sql As String = String.Empty
        Dim daCodSeg As OleDb.OleDbDataAdapter
        Dim TBL As DataTable

        Sql = "Select * From CodigosSegurança Where CodSeg = '" & Me.Cod.Text & "'"
        daCodSeg = New OleDb.OleDbDataAdapter(Sql, Cnn)
        daCodSeg.Fill(DS, "CodigosSegurança")
        TBL = DS.Tables("CodigosSegurança")

        If TBL.Rows.Count = 0 Then
            Dim DRnovo As DataRow
            DRnovo = TBL.NewRow()
            DRnovo("CodSeg") = Me.Cod.Text
            TBL.Rows.Add(DRnovo)

            Dim OBJ As New OleDb.OleDbCommandBuilder(daCodSeg)
            daCodSeg.Update(DS, "CodigosSegurança")
            Clipboard.SetDataObject(Me.Cod.Text)
            MessageBox.Show("Código de Segurança salvo com sucesso.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            daCodSeg.Dispose()
            TBL.Dispose()
            DS.Dispose()
            Cnn.Close()
        Else
            MessageBox.Show("Este código ja foi gerado para ser usado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            daCodSeg.Dispose()
            TBL.Dispose()
            DS.Dispose()
            Cnn.Close()
            Exit Sub
        End If

    End Sub
End Class