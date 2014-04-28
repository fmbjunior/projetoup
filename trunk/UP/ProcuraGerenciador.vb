Public Class ProcuraGerenciador

    Dim opt As Integer

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub TelaProcuraApontamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Fornecedor.Checked = True
        Me.txtfornecedor.focus()
    End Sub

    Private Sub txtFornecedor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFornecedor.Leave
        Dim CNN As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        CNN.Open()


        Dim Sql As String = ""
        Select Case opt
            Case 1
                Sql = "SELECT GerenciadorDoc.ID, GerenciadorDoc.Empresa, GerenciadorDoc.Fornecedor, Fornecedor.RazãoSocial, GerenciadorDoc.Total, GerenciadorDoc.DataLancamento FROM GerenciadorDoc INNER JOIN Fornecedor ON GerenciadorDoc.Fornecedor = Fornecedor.CódigoFornecedor WHERE (((GerenciadorDoc.ID)=" & Me.txtFornecedor.Text & ") AND ((GerenciadorDoc.Empresa)=" & CodEmpresa & "))"

            Case 2
                Sql = "SELECT GerenciadorDoc.ID, Fornecedor.RazãoSocial, GerenciadorDoc.Total, GerenciadorDoc.DataLancamento FROM GerenciadorDoc INNER JOIN Fornecedor ON GerenciadorDoc.Fornecedor = Fornecedor.CódigoFornecedor WHERE (((GerenciadorDoc.Empresa)=" & CodEmpresa & ") AND ((Fornecedor.RazãoSocial) Like '" & Me.txtFornecedor.Text & "'))"


        End Select



        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet
        Da.Fill(ds, "Table")

        Me.DgvItem.DataSource = ds.Tables("Table").DefaultView


        Da.Dispose()
        CNN.Close()
    End Sub



    Private Sub CampoChave_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CampoChave.CheckedChanged, Fornecedor.CheckedChanged

        Select Case DirectCast(sender, RadioButton).Name
            Case "CampoChave"
                opt = 1
            Case "Fornecedor"
                opt = 2
            Case "MostrarTodos"
                opt = 3
        End Select
    End Sub

    Private Sub MostraTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostraTodos.CheckedChanged
        If Me.MostraTodos.Checked = True Then
            Dim CNN As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
            CNN.Open()


            Dim Sql As String = ""

            Sql = "SELECT GerenciadorDoc.ID, Fornecedor.RazãoSocial, GerenciadorDoc.Total, GerenciadorDoc.DataLancamento FROM GerenciadorDoc INNER JOIN Fornecedor ON GerenciadorDoc.Fornecedor = Fornecedor.CódigoFornecedor WHERE GerenciadorDoc.Empresa=" & CodEmpresa



            Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
            Dim Da As New OleDb.OleDbDataAdapter(CMD)

            Dim ds As New DataSet
            Da.Fill(ds, "Table")

            Me.DgvItem.DataSource = ds.Tables("Table").DefaultView


            Da.Dispose()
            CNN.Close()
        End If
    End Sub



    Private Sub DgvItem_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellDoubleClick
        My.Forms.GerenciarOrdem.Id.Text = Me.DgvItem.CurrentRow.Cells(0).Value
        My.Forms.GerenciarOrdem.LocalizaDados()
        My.Forms.GerenciarOrdem.ViewDOC()
        My.Forms.GerenciarOrdem.ViewNF()
        My.Forms.GerenciarOrdem.AtGrid()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub DgvItem_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellContentClick

    End Sub
End Class