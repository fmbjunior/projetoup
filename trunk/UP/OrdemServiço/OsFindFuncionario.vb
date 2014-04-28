Public Class OsFindFuncionario

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub txtProcura_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProcura.Leave
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim sql As String
        Dim x_join(4)

        x_join(0) = "SELECT Funcionários.CódigoFuncionário, Funcionários.Nome"
        x_join(1) = "FROM FuncionarioServico "
        x_join(2) = "INNER JOIN Funcionários ON FuncionarioServico.fs_codigoFuncionario = Funcionários.CódigoFuncionário"
        x_join(3) = "WHERE Funcionários.Nome Like '%" & Me.txtProcura.Text & "%' And Funcionários.Inativo = False ORDER BY Funcionários.Nome"

        sql = Join(x_join)

        Dim CMD As New OleDb.OleDbCommand(sql, CNN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet
        Da.Fill(ds, "Table")

        Me.DgvItem.DataSource = ds.Tables("Table").DefaultView


        Da.Dispose()
        CNN.Close()
    End Sub

    Private Sub DgvItem_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellDoubleClick
        Dim xRet(1)
        xRet(0) = Me.DgvItem.CurrentRow.Cells("CodigoFuncionario").Value
        xRet(1) = Me.DgvItem.CurrentRow.Cells("Nome").Value
        If PedOSServicoAdd.Visible = True Then
            PedOSServicoAdd.CodFuncionario.Text = xRet(0)
            PedOSServicoAdd.NomeFuncionario.Text = xRet(1)
            PedOSServicoAdd.xValorAntigo = xRet(0)
            PedOSServicoAdd.CodigoServico.Focus()
            Me.Close()
        Else
            OSorcamentoItemServicoAdd.CodFuncionario.Text = xRet(0)
            OSorcamentoItemServicoAdd.NomeFuncionario.Text = xRet(1)
            OSorcamentoItemServicoAdd.xValorAntigo = xRet(0)
            OSorcamentoItemServicoAdd.CodigoServico.Focus()
            Me.Close()
        End If
    End Sub

  

    Private Sub DgvItem_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DgvItem.KeyDown
        If e.KeyCode = Keys.Return Then
            Dim xRet(1)
            xRet(0) = Me.DgvItem.CurrentRow.Cells("CodigoFuncionario").Value
            xRet(1) = Me.DgvItem.CurrentRow.Cells("Nome").Value

            If PedOSServicoAdd.Visible = True Then
                PedOSServicoAdd.CodFuncionario.Text = xRet(0)
                PedOSServicoAdd.NomeFuncionario.Text = xRet(1)
                PedOSServicoAdd.xValorAntigo = xRet(0)
                PedOSServicoAdd.CodigoServico.Focus()
                Me.Close()
            Else
                OSorcamentoItemServicoAdd.CodFuncionario.Text = xRet(0)
                OSorcamentoItemServicoAdd.NomeFuncionario.Text = xRet(1)
                OSorcamentoItemServicoAdd.xValorAntigo = xRet(0)
                OSorcamentoItemServicoAdd.CodigoServico.Focus()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub MostrarTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarTodos.Click
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim sql As String
        Dim x_join(3)

        x_join(0) = "SELECT Funcionários.CódigoFuncionário, Funcionários.Nome"
        x_join(1) = "FROM FuncionarioServico "
        x_join(2) = "INNER JOIN Funcionários ON FuncionarioServico.fs_codigoFuncionario = Funcionários.CódigoFuncionário Where Funcionários.Inativo = False"
        x_join(3) = " ORDER BY Funcionários.Nome"

        sql = Join(x_join)

        Dim CMD As New OleDb.OleDbCommand(sql, CNN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet
        Da.Fill(ds, "Table")

        Me.DgvItem.DataSource = ds.Tables("Table").DefaultView


        Da.Dispose()
        CNN.Close()
    End Sub

    Private Sub OsFindFuncionario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class