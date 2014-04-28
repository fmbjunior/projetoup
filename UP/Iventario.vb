Public Class Iventario

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Visualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Visualizar.Click
        'Testar os campos
        If String.IsNullOrEmpty(Me.DataInicial.Text) Or String.IsNullOrEmpty(Me.DataFinal.Text) Then
            MsgBox("Atenção! Datas incorretas, digite corretamente a data inicial e data final para gerar o relatório", 48, "Validação de dados")
            DataInicial.Focus()
            Return
        End If




        'conexao com db gestor
        Dim conn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        conn.Open()

        'conexao com db nfe
        Dim conNFe As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & LocalDBNFe & "NFe" & Me.Ano.Text & ".mdb")

        Try
            conNFe.Open()
        Catch ex As Exception
            If Err.Number = 5 Then
                MessageBox.Show("Banco de Dados da NFe não encontrado, Favor Verificar.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try




        Dim cmd As OleDb.OleDbCommand
        Dim DR As OleDb.OleDbDataReader
        Dim DRnfe As OleDb.OleDbDataReader
        Dim oDA As OleDb.OleDbDataAdapter
        Dim DS As New DataSet
        Try
            Me.Cursor = Cursors.WaitCursor

            oDA = New OleDb.OleDbDataAdapter("Select * from iventario", conn)
            oDA.Fill(DS, "Iventario")

            'gerar os dados para a tabela iventario entra.
            'cmd = New OleDb.OleDbCommand("SELECT Compra.Tipo, ItensCompra.CodigoProduto, Sum(ItensCompra.Qtd) AS SomaDeQtd FROM Compra INNER JOIN ItensCompra ON Compra.CompraInterno = ItensCompra.CompraInterno WHERE (((Compra.DataLançamento) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#)) GROUP BY Compra.Tipo, ItensCompra.CodigoProduto HAVING (((Compra.Tipo)='NF'))", conn)
            'cmd = New OleDb.OleDbCommand("SELECT Compra.Tipo, Sum(ItensCompra.Qtd) AS SomaDeQtd, Produtos.CodigoNFE FROM (Compra INNER JOIN ItensCompra ON Compra.CompraInterno = ItensCompra.CompraInterno) INNER JOIN Produtos ON ItensCompra.CodigoProduto = Produtos.CodigoProduto WHERE (((Compra.DataLançamento) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#)) GROUP BY Compra.Tipo, Produtos.CodigoNFE HAVING (((Compra.Tipo)='NF'))", conn)
            cmd = New OleDb.OleDbCommand("SELECT Compra.Tipo, Produtos.CodigoNFE, Sum(ItensCompra.Qtd) AS SomaDeQtd, Produtos.CodigoProduto FROM (Compra INNER JOIN ItensCompra ON Compra.CompraInterno = ItensCompra.CompraInterno) INNER JOIN Produtos ON ItensCompra.CodigoProduto = Produtos.CodigoProduto WHERE (((Compra.DataLançamento) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#)) GROUP BY Compra.Tipo, Produtos.CodigoNFE, Produtos.CodigoProduto HAVING (((Compra.Tipo)='NF'))", conn)
            DR = cmd.ExecuteReader

            Dim tb As DataTable
            tb = DS.Tables("Iventario")
            Dim linha As DataRow

            'insere ods dados do DR no dataTable Tb=Iventario

            While DR.Read()
                linha = tb.NewRow
                linha("CodigoNfe") = DR.Item(1)
                linha("Qtde") = DR.Item(2)
                linha("CodigoProduto") = DR.Item(3)
                tb.Rows.Add(linha)
            End While

            'cmd = New OleDb.OleDbCommand("SELECT NFeItens.Cprod AS Produto, Sum([qCom]*-1) AS Qtd FROM NFe INNER JOIN NFeItens ON NFe.chaveAcesso = NFeItens.ChaveAcesso WHERE (((NFe.dEmi) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((NFe.natOp)='VENDA')) GROUP BY NFeItens.Cprod", conNFe)
            cmd = New OleDb.OleDbCommand("SELECT NFeItens.Cprod AS Produto, Sum([qCom]*-1) AS Qtd, Produtos.CodigoERP FROM Produtos INNER JOIN (NFe INNER JOIN NFeItens ON NFe.chaveAcesso = NFeItens.ChaveAcesso) ON Produtos.Cprod = NFeItens.Cprod WHERE (((NFe.dEmi) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((NFe.natOp)='VENDA')) GROUP BY NFeItens.Cprod, Produtos.CodigoERP HAVING ((Not (Produtos.CodigoERP) Is Null));", conNFe)
            DRnfe = cmd.ExecuteReader

            While DRnfe.Read()
                linha = tb.NewRow
                linha("CodigoNfe") = DRnfe.Item("Produto")
                linha("Qtde") = DRnfe.Item("Qtd")
                linha("CodigoProduto") = DRnfe.Item("CodigoERP")
                tb.Rows.Add(linha)
            End While



            Dim oCmdBder As New OleDb.OleDbCommandBuilder(oDA)
            oDA.Update(DS, "Iventario")




            'mostrar o relatorio.


            RelatorioCarregar = "Iventario"
            Me.Cursor = Cursors.Default
            My.Forms.VisualizadorRelatorio.ShowDialog()

            Dim cmdExclui As New OleDb.OleDbCommand("Delete * from Iventario", conn)
            cmdExclui.ExecuteNonQuery()
            cmdExclui.Dispose()
            conn.Close()
            conNFe.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Cursor = Cursors.Default
        End Try


    End Sub

    Private Sub Ano_Leave(sender As Object, e As EventArgs) Handles Ano.Leave
        Me.DataInicial.Text = "01/01/" & Me.Ano.Text
        Me.DataFinal.Text = "31/12/" & Me.Ano.Text

    End Sub
End Class