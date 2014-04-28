Public Class ReimpressaoReciboPagarReceber
    Dim bs As BindingSource
    Dim opt As Integer = 1
    Dim ds As DataSet
    Public vId As Integer
    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
        Me.Dispose()

    End Sub
    Public Sub AtGrid()
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        Cnn.Open()
        Dim filter As String = ""
        Dim sql As String = String.Empty

        If Me.PorDocumento.Checked = True Then
            filter = "Documento like '%" & txtProcurar.Text & "%'"
            Select Case opt
                Case 1
                    sql = "SELECT Pagar.ID, Pagar.Documento AS Doc, Pagar.Fornecedor AS FornecedorCliente, Pagar.Pagamento AS DataMov, Pagar.ValorLiquido AS ValorL FROM Pagar INNER JOIN Fornecedor ON Pagar.CodFornecedor = Fornecedor.CódigoFornecedor WHERE Pagar.baixado = True And " & filter & " ORDER BY Pagar.Pagamento"
                Case 2
                    sql = "SELECT Receber.ID, Receber.Documento AS Doc, Clientes.NomeFantasia AS FornecedorCliente, Receber.Recebimento AS DataMov , Receber.ValorLiquido AS ValorL FROM Receber INNER JOIN Clientes ON Receber.CodCliente = Clientes.Codigo WHERE Receber.baixado = True And Receber.PedidoProdutos=" & Me.txtProcurar.Text & " ORDER BY Receber.Vencimento"
            End Select
        End If

        If Me.PorPeriodo.Checked = True Then
            Select Case opt
                Case 1
                    sql = "SELECT Pagar.ID, Pagar.Documento AS Doc, Pagar.Fornecedor AS FornecedorCliente, Pagar.Pagamento AS DataMov, Pagar.ValorLiquido AS ValorL FROM Pagar INNER JOIN Fornecedor ON Pagar.CodFornecedor = Fornecedor.CódigoFornecedor WHERE Pagar.baixado = True And Pagar.Pagamento Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyy") & "# ORDER BY Pagar.Pagamento"
                Case 2
                    sql = "SELECT Receber.ID, Receber.Documento AS Doc, Clientes.NomeFantasia AS FornecedorCliente, Receber.Recebimento AS DataMov , Receber.ValorLiquido AS ValorL FROM Receber INNER JOIN Clientes ON Receber.CodCliente = Clientes.Codigo WHERE Receber.baixado = True And Receber.Recebimento Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyy") & "# ORDER BY Receber.Vencimento"
            End Select
        End If

        Dim CMD As New OleDb.OleDbCommand(sql, Cnn)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        ds = New DataSet
        Da.Fill(ds, "Table")


        dgvItem.DataSource = ds.Tables(0).DefaultView



        Da.Dispose()
        Cnn.Close()
    End Sub

    Private Sub rdbB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbB.CheckedChanged, rdbA.CheckedChanged
        If rdbA.Checked = True Then
            opt = 1
            If dgvItem.RowCount > 0 Then
                ds.Clear()
            End If

            'dgvItem.DataSource = ds.Tables(0).DefaultView
            Me.txtProcurar.Focus()
        ElseIf rdbB.Checked = True Then
            opt = 2
            If dgvItem.RowCount > 0 Then
                ds.Clear()
            End If
            Me.txtProcurar.Focus()
        End If
    End Sub

    Private Sub txtProcurar_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProcurar.Leave
        Try
            AtGrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvItem_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvItem.CellDoubleClick
        Try
            vId = Me.dgvItem.CurrentRow.Cells(0).Value

            Select Case opt
                Case 1 'Pagar
                    Dim rlt As New ReciboPagar
                    rlt.i = vId
                    My.Forms.ViewReport.VerRelat.Document = rlt.Document
                    rlt.Run()
                    My.Forms.ViewReport.ShowDialog()
                Case 2 ' Receber
                    RelatorioCarregar = "RelReciboReceber"
                    My.Forms.VisualizadorRelatorio.ShowDialog()
            End Select

        Catch ex As Exception

        End Try
    End Sub

    Private Sub LabelX2_Click(sender As Object, e As EventArgs) Handles LabelX2.Click

    End Sub

    Private Sub PorPeriodo_CheckedChanged(sender As Object, e As EventArgs) Handles PorPeriodo.CheckedChanged, PorDocumento.CheckedChanged
        If Me.PorPeriodo.Checked = True Then
            Me.PainelDocumento.Visible = False
            Me.PainelPeriodo.Visible = True
            Me.DataInicial.Focus()
        End If
        If Me.PorDocumento.Checked = True Then
            Me.PainelDocumento.Visible = True
            Me.PainelPeriodo.Visible = False
            Me.txtProcurar.Focus()
        End If
    End Sub

    Private Sub DataFinal_Leave(sender As Object, e As EventArgs) Handles DataFinal.Leave

        If Me.DataInicial.Text = "" Then
            MessageBox.Show("Favor informar a data inicial.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If Me.DataFinal.Text = "" Then
            MessageBox.Show("Favor informar a data Final    .", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Try
            AtGrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class