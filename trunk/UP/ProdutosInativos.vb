Public Class ProdutosInativos

    Dim opt As Integer

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
        Me.Dispose()
    End Sub
    
    Private Sub ProcuraProduto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtProcura.Focus()
    End Sub

    Private Sub txtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProcura.Leave

        If Me.A3.Checked = True Then
            Me.DgvItem.Focus()
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim Sql As String = ""
        If Me.A1.Checked = True Then
            Sql = "SELECT Produtos.CodigoProduto, Produtos.Descrição, Produtos.UnidadeMedida, Produtos.ValorVenda FROM Produtos WHERE (((Produtos.CodigoProduto) Like '%" & Me.txtProcura.Text & "%') AND ((Produtos.Tipo)<>99) AND ((Produtos.Empresa)=" & CodEmpresa & ")) and Produtos.Inativo = true"
            Me.DgvItem.Focus()
        End If
        If Me.A2.Checked = True Then
            Sql = "SELECT Produtos.CodigoProduto, Produtos.Descrição, Produtos.UnidadeMedida, Produtos.ValorVenda FROM Produtos WHERE (((Produtos.Descrição) Like '%" & Me.txtProcura.Text & "%') AND ((Produtos.Tipo)<>99) AND ((Produtos.Empresa)=" & CodEmpresa & ")) and Produtos.Inativo = true"
            Me.DgvItem.Focus()
        End If


        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet
        Da.Fill(ds, "Table")

        Me.DgvItem.DataSource = ds.Tables("Table").DefaultView

        Da.Dispose()
        CNN.Close()
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


            Dim Sql As String = "SELECT Produtos.CodigoProduto, Produtos.Descrição, Produtos.UnidadeMedida, Produtos.ValorVenda FROM Produtos WHERE (((Produtos.Tipo)<>99) AND ((Produtos.Empresa)=" & CodEmpresa & ")) and Produtos.Inativo = true"

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


        If MessageBox.Show("Deseja ativar novamento o produto selecionado.", "Validação de Dados", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            Try
                CNN.Open()

                Dim Sql As String = "UPDATE Produtos SET  Inativo = False Where CodigoProduto = " & Me.DgvItem.CurrentRow.Cells(0).Value
                Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

                cmd.ExecuteNonQuery()
                MsgBox("Registro atualizado com sucesso", 64, "Validação de Dados")


                CNN.Close()

                If Me.A1.Checked = True Or Me.A2.Checked = True Then
                    txtProcura_Leave(sender, e)
                End If

                If Me.A3.Checked = True Then
                    MostraTodos_CheckedChanged(sender, e)
                End If

            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
                CNN.Close()
            End Try
        End If

    End Sub



    Private Sub ProcuraProduto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F3
                Me.A1.Checked = True
                Me.txtProcura.Focus()
            Case Keys.F4
                Me.A2.Checked = True
                Me.txtProcura.Focus()
            Case Keys.F5
                Me.A3.Checked = True
                Me.DgvItem.Focus()
        End Select
    End Sub


    Private Sub DgvItem_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellContentClick

    End Sub
End Class