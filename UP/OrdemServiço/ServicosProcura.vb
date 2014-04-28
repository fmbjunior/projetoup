Public Class ServicosProcura

    Dim opt As Integer

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ServicosProcura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Forms.ServicoFuncionario.Visible = True Then
            Me.LabelX1.Visible = True
        Else
            Me.LabelX1.Visible = False
        End If
        Me.A2.Checked = True
        Me.txtProcura.Focus()
    End Sub

    ' CSEH: <Try Catch>
    Private Sub txtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProcura.Leave
        Try
            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))


            CNN.Open()


            Dim Sql As String = ""
            If Me.A1.Checked = True Then
                Sql = "SELECT Serv_Codigo,Serv_Descricao,Serv_valorservico FROM Servicos WHERE Serv_Codigo=" & Me.txtProcura.Text & " AND Empresa=" & CodEmpresa
            End If
            If Me.A2.Checked = True Then
                Sql = "SELECT Serv_Codigo,Serv_Descricao,Serv_valorservico FROM Servicos WHERE Serv_Descricao Like '%" & Me.txtProcura.Text & "%' AND Empresa = " & CodEmpresa
            End If

            Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
            Dim Da As New OleDb.OleDbDataAdapter(CMD)

            Dim ds As New DataSet
            Da.Fill(ds, "Table")

            Me.DgvItem.DataSource = ds.Tables("Table").DefaultView


            Da.Dispose()
            CNN.Close()
        Catch oE As System.Exception
            Select Case Err.Number
                Case 5
                    MsgBox("Registro não encontrado ou critério incorreto para a consulta", 48, "Atenção")
                Case Else
                    MsgBox(oE.Message)
            End Select
        End Try
    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged

        If Me.A1.Checked = True Then
            Me.txtProcura.Clear()
            Me.txtProcura.Focus()
        End If
        If Me.A2.Checked = True Then
            Me.txtProcura.Clear()
            Me.txtProcura.Focus()
        End If

    End Sub

    Private Sub MostraTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A3.CheckedChanged
        If Me.A3.Checked = True Then
            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()


            Dim sql As String = "SELECT Serv_Codigo,Serv_Descricao,Serv_valorservico FROM Servicos WHERE Empresa=" & CodEmpresa

            Dim CMD As New OleDb.OleDbCommand(sql, CNN)
            Dim Da As New OleDb.OleDbDataAdapter(CMD)

            Dim ds As New DataSet
            Da.Fill(ds, "Table")

            Me.DgvItem.DataSource = ds.Tables("Table").DefaultView

            Da.Dispose()
            CNN.Close()
        End If
    End Sub


    Private Sub DgvItem_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellDoubleClick

        If My.Forms.Servicos.Visible = True Then
            My.Forms.Servicos.codigoServico.Text = Me.DgvItem.CurrentRow.Cells(0).Value
            My.Forms.Servicos.LocalizaDados()
            Me.Close()
            Me.Dispose()
        End If

        If My.Forms.ServicoFuncionario.Visible = True Then
            If noRecord() = False Then
                My.Forms.ServicoFuncionario.sv.Codigoservico = Me.DgvItem.CurrentRow.Cells(0).Value
                My.Forms.ServicoComissao.ShowDialog()
                My.Forms.ServicoFuncionario.AddItemServico()
                Me.Close()
                Me.Dispose()
            Else
                MsgBox("Este serviço já foi adicionado para este funcionário", 48, "Atenção")
                Exit Sub
            End If
        End If
    End Sub
    Public Function noRecord()
        Dim x As Integer = Me.DgvItem.CurrentRow.Cells(0).Value

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim Sql As String
        Sql = "SELECT Sv_CodigoFuncionario, Sv_CodigoServico FROM FuncionarioServicoDetalhe WHERE Sv_CodigoFuncionario=" & My.Forms.ServicoFuncionario.sv.Codigofuncionario & " AND Sv_CodigoServico=" & x
        'Sql = "SELECT FuncionarioServicoDetalhe.Sv_CodigoFuncionario, FuncionarioServicoDetalhe.Sv_CodigoServico FROM FuncionarioServicoDetalhe WHERE (((FuncionarioServicoDetalhe.Sv_CodigoFuncionario)=" & My.Forms.ServicoFuncionario.sv.Codigofuncionario & " ) AND ((FuncionarioServicoDetalhe.Sv_CodigoServico)=" & x & "));"


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
    Private Sub DgvItem_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellContentClick

    End Sub

    Private Sub DgvItem_MultiSelectChanged(sender As Object, e As EventArgs) Handles DgvItem.MultiSelectChanged
        For Each row As DataGridViewRow In DgvItem.SelectedRows
            MessageBox.Show(row.Index.ToString)
        Next
    End Sub
End Class