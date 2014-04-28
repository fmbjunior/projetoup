Public Class OsFindServico
    Dim bs As BindingSource
    Dim ds As New DataSet

    Private Sub OsFindServico_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            Me.txtProcura.Focus()
        End If
    End Sub
    Private Sub OsFindServico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtProcura.Clear()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim sql As String
        Dim x_join(4)
        If PedOSServicoAdd.Visible = True Then
            x_join(0) = "SELECT Servicos.Serv_Codigo, Servicos.Serv_Descricao, Servicos.Serv_ValorServico, Servicos.Serv_Referencia "
            x_join(1) = "FROM Servicos "
            x_join(2) = "INNER JOIN FuncionarioServicoDetalhe ON Servicos.Serv_Codigo=FuncionarioServicoDetalhe.Sv_CodigoServico"
            x_join(3) = "WHERE FuncionarioServicoDetalhe.Sv_CodigoFuncionario=" & My.Forms.PedOSServicoAdd.CodFuncionario.Text
        Else
            x_join(0) = "SELECT Servicos.Serv_Codigo, Servicos.Serv_Descricao, Servicos.Serv_ValorServico, Servicos.Serv_Referencia "
            x_join(1) = "FROM Servicos "
            x_join(2) = "INNER JOIN FuncionarioServicoDetalhe ON Servicos.Serv_Codigo=FuncionarioServicoDetalhe.Sv_CodigoServico"
            x_join(3) = "WHERE FuncionarioServicoDetalhe.Sv_CodigoFuncionario=" & OSorcamentoItemServicoAdd.CodFuncionario.Text
        End If
        sql = Join(x_join)

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

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub DgvItem_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellClick

    End Sub

 

    Private Sub DgvItem_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellDoubleClick
        Dim xRet(3)

        xRet(0) = Me.DgvItem.CurrentRow.Cells("CodigoServico").Value
        xRet(1) = Me.DgvItem.CurrentRow.Cells("Servico").Value
        xRet(2) = Me.DgvItem.CurrentRow.Cells("ValorServico").Value

        If PedOSServicoAdd.Visible = True Then
            PedOSServicoAdd.CodigoServico.Text = xRet(0)
            PedOSServicoAdd.NomeServico.Text = xRet(1)
            PedOSServicoAdd.ValorUnitario.Text = xRet(2)
            PedOSServicoAdd.xServicoAntigo = xRet(0)
            PedOSServicoAdd.Qtd.Focus()
            Me.Close()
        Else
            OSorcamentoItemServicoAdd.CodigoServico.Text = xRet(0)
            OSorcamentoItemServicoAdd.NomeServico.Text = xRet(1)
            OSorcamentoItemServicoAdd.ValorUnitario.Text = xRet(2)
            OSorcamentoItemServicoAdd.xServicoAntigo = xRet(0)
            OSorcamentoItemServicoAdd.Qtd.Focus()
            Me.Close()
        End If
    End Sub

    Private Sub DgvItem_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DgvItem.KeyDown

        If e.KeyCode = Keys.Return Then
            If (DgvItem.RowCount > 0) Then
                Dim xRet(3)
                xRet(0) = Me.DgvItem.CurrentRow.Cells("CodigoServico").Value
                xRet(1) = Me.DgvItem.CurrentRow.Cells("Servico").Value
                xRet(2) = Me.DgvItem.CurrentRow.Cells("ValorServico").Value

                If PedOSServicoAdd.Visible = True Then
                    PedOSServicoAdd.CodigoServico.Text = xRet(0)
                    PedOSServicoAdd.NomeServico.Text = xRet(1)
                    PedOSServicoAdd.ValorUnitario.Text = xRet(2)
                    PedOSServicoAdd.xServicoAntigo = xRet(0)
                    PedOSServicoAdd.Qtd.Focus()
                    Me.Close()
                    Me.Dispose()
                Else
                    OSorcamentoItemServicoAdd.CodigoServico.Text = xRet(0)
                    OSorcamentoItemServicoAdd.NomeServico.Text = xRet(1)
                    OSorcamentoItemServicoAdd.ValorUnitario.Text = xRet(2)
                    OSorcamentoItemServicoAdd.xServicoAntigo = xRet(0)
                    OSorcamentoItemServicoAdd.Qtd.Focus()
                    Me.Close()
                    Me.Dispose()
                End If
            End If
        End If
    End Sub
    Private Sub DgvItem_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvItem.SelectionChanged
        Try
            Me.lblReferencia.Text = Me.DgvItem.CurrentRow.Cells("Referencia").Value
        Catch ex As Exception
        End Try



    End Sub

    Private Sub txtProcura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProcura.TextChanged
        bs.Filter = "Serv_Descricao like '%" & txtProcura.Text & "%'"
    End Sub

    Private Sub DgvItem_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellContentClick

    End Sub
End Class