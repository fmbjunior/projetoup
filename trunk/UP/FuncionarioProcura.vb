Imports System.Data.OleDb
Public Class FuncionarioProcura


    Private Sub TxtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProcura.Leave
        If Me.TxtProcura.Text = "" Then
            Exit Sub
        End If

        If Me.A1.Checked = True Then BuscarFuncionario(1)
        If Me.A2.Checked = True Then BuscarFuncionario(2)
        If Me.A3.Checked = True Then BuscarFuncionario(3)

        Me.Lista.Focus()

    End Sub


    Private Sub BuscarFuncionario(ByVal Opt As String)

        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Select Case Opt
            Case 1
                Sql = "SELECT Funcionários.CódigoFuncionário, Funcionários.Nome, Profissao.Descrição FROM Funcionários LEFT JOIN Profissao ON Funcionários.Profissão = Profissao.Codigo WHERE (((Funcionários.CódigoFuncionário)=" & Me.TxtProcura.Text & ")) and Funcionários.Empresa =" & CodEmpresa & " Order by Funcionários.Nome"
            Case 2
                Sql = "SELECT Funcionários.CódigoFuncionário, Funcionários.Nome, Profissao.Descrição FROM Funcionários LEFT JOIN Profissao ON Funcionários.Profissão = Profissao.Codigo WHERE (((Funcionários.Nome) like '%" & Me.TxtProcura.Text & "%')) and Funcionários.Empresa =" & CodEmpresa & " Order by Funcionários.Nome"
            Case 3
                Sql = "SELECT Funcionários.CódigoFuncionário, Funcionários.Nome, Profissao.Descrição, Funcionários.Empresa FROM Funcionários LEFT JOIN Profissao ON Funcionários.Profissão = Profissao.Codigo WHERE (((Funcionários.Empresa)=" & CodEmpresa & "));"
        End Select

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Lista.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub FuncionarioProcura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TxtProcura.Focus()
        Me.A2.Checked = True
    End Sub

    Private Sub CampoChave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles A1.Click, A2.Click
        Me.TxtProcura.Focus()
    End Sub

    Private Sub Lista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellDoubleClick
        Dim vID As Integer
        vID = CInt(Me.Lista.CurrentRow.Cells(0).Value)

        If My.Forms.Funcionarios.Visible = True Then My.Forms.Funcionarios.CódigoFuncionário.Text = vID

        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged
        If Me.A1.Checked = True Then
            Me.TxtProcura.Clear()
            Me.TxtProcura.Focus()
        End If
        If Me.A2.Checked = True Then
            Me.TxtProcura.Clear()
            Me.TxtProcura.Focus()
        End If
    End Sub

    Private Sub A3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A3.CheckedChanged
        BuscarFuncionario(3)
    End Sub


    Private Sub Lista_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Lista.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim vID As Integer
            vID = CInt(NzZero(Me.Lista.CurrentRow.Cells(0).Value))

            If My.Forms.Funcionarios.Visible = True Then My.Forms.Funcionarios.CódigoFuncionário.Text = vID

            Me.Close()
            Me.Dispose()
        End If
    End Sub
End Class