
Public Class MostrarContasInativas
    Dim bs As BindingSource
    Dim ds As New DataSet
    Private con As OleDb.OleDbConnection
    Private Sub MostrarContasInativas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtProcura.Clear()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim sql As String

        sql = "SELECT ContasCR1.CR1 , ContasCR1.DescCR1 , ContasCR2.CR2 , ContasCR2.DescCR2  FROM ContasCR1 LEFT JOIN ContasCR2 ON ContasCR1.CR1 = ContasCR2.CR1 WHERE (((ContasCR1.Empresa)=" & CodEmpresa & ") AND ((ContasCR2.Inativo)=True));"

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

    Private Sub MostrarContasInativas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            Me.txtProcura.Focus()
        End If
    End Sub

    Private Sub txtProcura_TextChanged(sender As Object, e As EventArgs) Handles txtProcura.TextChanged
        bs.Filter = "Nome_Sub_Conta like '%" & txtProcura.Text & "%'"
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub AtivarContaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtivarContaToolStripMenuItem.Click
        ' Abre a conexao com o banco de dados

        Try
            con = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            con.Open()
            Dim Cmd As New OleDb.OleDbCommand()

            Cmd.CommandText = "UPDATE ContasCR2 SET Inativo=@2 WHERE CR1 ='" & Me.DgvItem.CurrentRow.Cells("gContaPrincipal").Value & "' AND CR2 = '" & Me.DgvItem.CurrentRow.Cells("gSubConta").Value & "' AND Empresa=" & CodEmpresa & ""
            Cmd.CommandType = CommandType.Text
            Cmd.Connection = con
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", False))
            Cmd.ExecuteNonQuery()
            con.Close()
            MostrarContasInativas_Load(sender, e)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class