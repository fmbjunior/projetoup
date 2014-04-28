Public Class ServicoFuncionarioAdd

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Private Sub txtProcura_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProcura.Leave
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim sql As String = "SELECT CódigoFuncionário, Nome FROM funcionários WHERE Nome like '%" & Me.txtProcura.Text & "%'"

        Dim CMD As New OleDb.OleDbCommand(sql, CNN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet
        Da.Fill(ds, "Table")

        Me.DgvItem.DataSource = ds.Tables("Table").DefaultView

        Da.Dispose()
        CNN.Close()

    End Sub
    Dim xFunc As Integer
    Private Sub AdicionarFuncionarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarFuncionarioToolStripMenuItem.Click
        xFunc = Me.DgvItem.CurrentRow.Cells(0).Value

        If noRecord() = True Then
            MsgBox("Este funcionário já foi adicionado", 48, "Atenção")
            Exit Sub
        Else
            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "INSERT INTO FuncionarioServico (fs_codigoFuncionario) VALUES (?)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("codigofuncionario", xFunc))
            Try
                cmd.ExecuteNonQuery()

                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                My.Forms.ServicoFuncionario.MostrarTree()
                My.Forms.ServicoFuncionario.TreeView1.Nodes(0).Expand()
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            CNN.Close()

        End If
    End Sub

    Public Function noRecord()


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim Sql As String = "SELECT fs_codigoFuncionario from FuncionarioServico WHERE fs_codigoFuncionario=" & xFunc


        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            'achou registro
            Return True
        Else
            Return False
        End If

        DR.Close()

    End Function

    Private Sub DgvItem_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellClick
        xFunc = Me.DgvItem.CurrentRow.Cells(0).Value
    End Sub

    Private Sub ServicoFuncionarioAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class