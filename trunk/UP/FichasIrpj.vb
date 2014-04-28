Public Class FichasIrpj

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    
    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged, A4.CheckedChanged
        Me.DataInicial.Focus()
    End Sub

    Private Sub Visualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Visualizar.Click

        If Me.DataInicial.Text = "" Then
            MsgBox("O usuário deve informar a data inicial para o relatório.", 64, "Validação de Dados")
            Me.DataInicial.Focus()
            Exit Sub
        ElseIf Me.DataFinal.Text = "" Then
            MsgBox("O usuário deve informar a data Final para o relatório.", 64, "Validação de Dados")
            Me.DataFinal.Focus()
            Exit Sub
        End If


        If Me.A1.Checked = True Then
            Me.Cursor = Cursors.WaitCursor

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "Delete * from Ficha23"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)
            cmd.ExecuteNonQuery()

            Sql = "INSERT INTO Ficha23 ( CgcCpf, RazãoSocial, ValorCompra, TotalIpi, DataEntrada ) SELECT Fornecedor.CgcCpf, Fornecedor.RazãoSocial, Compra.ValorCompra, Compra.TotalIpi, Compra.DataEntrada FROM Compra INNER JOIN Fornecedor ON Compra.CódigoFornecedor = Fornecedor.CódigoFornecedor WHERE (((Compra.DataEntrada) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "# AND (Compra.Tipo)='Escrita Fiscal'));"
            cmd = New OleDb.OleDbCommand(Sql, CNN)
            cmd.ExecuteNonQuery()

            Sql = "INSERT INTO Ficha23 ( CgcCpf, RazãoSocial, ValorCompra, TotalIpi, DataEntrada ) SELECT Fornecedor.CgcCpf, Fornecedor.RazãoSocial, OutrasEntradas.ValorCompra, OutrasEntradas.TotalIpi, OutrasEntradas.DataEntrada FROM Fornecedor INNER JOIN OutrasEntradas ON Fornecedor.CódigoFornecedor = OutrasEntradas.CódigoFornecedor WHERE (((OutrasEntradas.DataEntrada) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "# AND (OutrasEntradas.Tipo)='Escrita Fiscal'));"
            cmd = New OleDb.OleDbCommand(Sql, CNN)
            cmd.ExecuteNonQuery()

            RelatorioCarregar = "RelFicha23"
            Try
                My.Forms.VisualizadorRelatorio.ShowDialog()
            Catch ex As Exception
                MsgBox("Já existe uma tarefa de relatório sendo executado, verifique.", 64, "Validação de Dados")
                Me.Cursor = Cursors.Default
                Exit Sub
            End Try
            Me.Cursor = Cursors.Default
        End If

        If Me.A2.Checked = True Then
            Me.Cursor = Cursors.WaitCursor

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "Delete * from Ficha24"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)
            cmd.ExecuteNonQuery()

            Sql = "INSERT INTO Ficha24 ( CF, NomeProduto, ValorContabil, ValorIpi ) SELECT Produtos.CF, Produtos.Descrição, ItensCompra.TotalProduto, ItensCompra.ValorIpi FROM Produtos INNER JOIN (Compra INNER JOIN ItensCompra ON Compra.CompraInterno = ItensCompra.CompraInterno) ON Produtos.CodigoProduto = ItensCompra.CodigoProduto WHERE (((Compra.DataEntrada) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) and Compra.Tipo = 'Escrita Fiscal' and Compra.Inativo = False and Compra.Confirmado = True);"
            cmd = New OleDb.OleDbCommand(Sql, CNN)
            cmd.ExecuteNonQuery()

            Sql = "INSERT INTO Ficha24 ( CF, NomeProduto, ValorContabil, ValorIpi ) SELECT MateriaPrima.CF, MateriaPrima.MateriaPrima, ItensCompraMateriaPrima.TotalProduto, ItensCompraMateriaPrima.ValorIpi FROM MateriaPrima INNER JOIN (Compra INNER JOIN ItensCompraMateriaPrima ON Compra.CompraInterno = ItensCompraMateriaPrima.CompraInterno) ON MateriaPrima.Codigo = ItensCompraMateriaPrima.CodigoMateriaPrima WHERE (((Compra.DataEntrada) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) and Compra.Tipo = 'Escrita Fiscal' and Compra.Inativo = False and Compra.Confirmado = True);"
            cmd = New OleDb.OleDbCommand(Sql, CNN)
            cmd.ExecuteNonQuery()
            CNN.Close()

            RelatorioCarregar = "RelFicha24"
            Try
                My.Forms.VisualizadorRelatorio.ShowDialog()
            Catch ex As Exception
                MsgBox("Já existe uma tarefa de relatório sendo executado, verifique.", 64, "Validação de Dados")
                Me.Cursor = Cursors.Default
                Exit Sub
            End Try
            Me.Cursor = Cursors.Default
        End If

        If Me.A3.Checked = True Then
            Me.Cursor = Cursors.WaitCursor

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "Delete * from Ficha25"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)
            cmd.ExecuteNonQuery()

            Sql = "INSERT INTO Ficha25 ( CgcCpf, RazãoSocial, ValorSaida, DataSaida ) SELECT Clientes.CpfCgc, Clientes.Nome, NotaFiscal.TotalNota, NotaFiscal.DataEmissao FROM Clientes INNER JOIN NotaFiscal ON Clientes.Codigo = NotaFiscal.Cliente WHERE (((NotaFiscal.DataEmissao) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((NotaFiscal.Situaçao)='E'));"
            cmd = New OleDb.OleDbCommand(Sql, CNN)
            cmd.ExecuteNonQuery()

            RelatorioCarregar = "RelFicha25"
            Try
                My.Forms.VisualizadorRelatorio.Show()
            Catch ex As Exception
                MsgBox("Já existe uma tarefa de relatório sendo executado, verifique.", 64, "Validação de Dados")
                Me.Cursor = Cursors.Default
                Exit Sub
            End Try
            Me.Cursor = Cursors.Default
        End If

        If Me.A4.Checked = True Then
            Me.Cursor = Cursors.WaitCursor

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "Delete * from Ficha26"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)
            cmd.ExecuteNonQuery()

            Sql = "INSERT INTO Ficha26 ( CF, NomeProduto, ValorContabil, ValorIpi ) SELECT Produtos.CF, Produtos.Descrição, NotaFiscalItens.ValorTotal, NotaFiscalItens.ValorIpi FROM Produtos INNER JOIN (NotaFiscal INNER JOIN NotaFiscalItens ON NotaFiscal.NotaFiscal = NotaFiscalItens.NotaFiscal) ON Produtos.CodigoProduto = NotaFiscalItens.Produto WHERE (((NotaFiscal.DataEmissao) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((NotaFiscal.Situaçao)='E')  );"
            cmd = New OleDb.OleDbCommand(Sql, CNN)
            cmd.ExecuteNonQuery()

            RelatorioCarregar = "RelFicha26"
            Try
                My.Forms.VisualizadorRelatorio.ShowDialog()
            Catch ex As Exception
                MsgBox("Já existe uma tarefa de relatório sendo executado, verifique.", 64, "Validação de Dados")
                Me.Cursor = Cursors.Default
                Exit Sub
            End Try
            Me.Cursor = Cursors.Default
        End If


    End Sub
End Class