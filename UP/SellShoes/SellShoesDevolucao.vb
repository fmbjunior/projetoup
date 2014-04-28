Public Class SellShoesDevolucao

    Dim DsItens As DataSet

    Public Q_Devolver As Double = 0

   
    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub EncheListaPedido(ByVal Opc As Integer)

        If Opc = 0 Then Exit Sub

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim SqlItens As String = String.Empty
        Dim Sql As String = String.Empty

        If Opc = 1 Then 'Por Pedido
            Sql = "SELECT Pedido.PedidoSequencia, Pedido.C�digoCliente, Clientes.Nome, Pedido.DataPedido, Pedido.TotalPedido, Pedido.PedidoTipo, Pedido.DevNumero,Funcion�rios.Nome AS Vendedor FROM (Pedido INNER JOIN Clientes ON Pedido.C�digoCliente = Clientes.Codigo) INNER JOIN Funcion�rios ON Pedido.C�digoFuncion�rio = Funcion�rios.C�digoFuncion�rio WHERE (((Pedido.PedidoSequencia)=" & Me.txtProcura.Text & ") AND ((Pedido.Empresa)=" & CodEmpresa & ") AND ((Pedido.Inativo)=False) AND ((Pedido.Confirmado)=True));"
            SqlItens = "SELECT ItensPedido.Id, ItensPedido.PedidoSequencia, ItensPedido.CodigoProduto, ItensPedido.Numero, Produtos.Descri��o, ItensPedido.Qtd, ItensPedido.ValorUnitario, ItensPedido.Desconto, ItensPedido.ValorDesconto, ItensPedido.TotalProduto, ItensPedido.CustoMercadoriaVendida, ItensPedido.Promocao, ItensPedido.DevolvidoId, ItensPedido.Devolvido, ItensPedido.QtdDevolvido, ItensPedido.pAcrecimoVenda, ItensPedido.vAcrecimoVenda, ItensPedido.pDescontoEspecial, ItensPedido.vDescontoEspecial  FROM (Pedido INNER JOIN ItensPedido ON Pedido.PedidoSequencia = ItensPedido.PedidoSequencia) INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto WHERE (((Pedido.PedidoSequencia)=" & Me.txtProcura.Text & ") AND ((Pedido.Empresa)=" & CodEmpresa & ") AND ((Pedido.Inativo)=False) AND ((Pedido.Confirmado)=True));"
        End If
        If Opc = 2 Then 'Por Cliente
            Sql = "SELECT Pedido.PedidoSequencia, Pedido.C�digoCliente,  Clientes.Nome, Pedido.DataPedido, Pedido.TotalPedido, Pedido.PedidoTipo, Pedido.DevNumero, Funcion�rios.Nome AS Vendedor FROM (Pedido INNER JOIN Clientes ON Pedido.C�digoCliente = Clientes.Codigo) INNER JOIN Funcion�rios ON Pedido.C�digoFuncion�rio = Funcion�rios.C�digoFuncion�rio WHERE (((Clientes.Nome) Like '%" & Me.txtProcura.Text & "%') AND ((Pedido.Empresa)=" & CodEmpresa & ") AND ((Pedido.Inativo)=False) AND ((Pedido.Confirmado)=True));"
            SqlItens = "SELECT ItensPedido.Id, ItensPedido.PedidoSequencia, ItensPedido.CodigoProduto, ItensPedido.Numero, Produtos.Descri��o, ItensPedido.Qtd, ItensPedido.ValorUnitario, ItensPedido.Desconto, ItensPedido.ValorDesconto, ItensPedido.TotalProduto, ItensPedido.CustoMercadoriaVendida, ItensPedido.Promocao, ItensPedido.DevolvidoId, ItensPedido.Devolvido, ItensPedido.QtdDevolvido, ItensPedido.pAcrecimoVenda, ItensPedido.vAcrecimoVenda, ItensPedido.pDescontoEspecial, ItensPedido.vDescontoEspecial  FROM ((Pedido INNER JOIN Clientes ON Pedido.C�digoCliente = Clientes.Codigo) INNER JOIN ItensPedido ON Pedido.PedidoSequencia = ItensPedido.PedidoSequencia) INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto WHERE (((Clientes.Nome) Like '%" & Me.txtProcura.Text & "%') AND ((Pedido.Empresa)=" & CodEmpresa & ") AND ((Pedido.Inativo)=False) AND ((Pedido.Confirmado)=True));"
        End If
        If Opc = 3 Then 'Por Periodo
            Sql = "SELECT Pedido.PedidoSequencia,  Pedido.C�digoCliente, Clientes.Nome, Pedido.DataPedido, Pedido.TotalPedido, Pedido.PedidoTipo, Pedido.DevNumero, Funcion�rios.Nome AS Vendedor FROM (Pedido INNER JOIN Clientes ON Pedido.C�digoCliente = Clientes.Codigo) INNER JOIN Funcion�rios ON Pedido.C�digoFuncion�rio = Funcion�rios.C�digoFuncion�rio WHERE (((Pedido.DataPedido) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Pedido.Empresa)=" & CodEmpresa & ") AND ((Pedido.Inativo)=False) AND ((Pedido.Confirmado)=True));"
            SqlItens = "SELECT ItensPedido.Id, ItensPedido.PedidoSequencia, ItensPedido.CodigoProduto, ItensPedido.Numero, Produtos.Descri��o, ItensPedido.Qtd, ItensPedido.ValorUnitario, ItensPedido.Desconto, ItensPedido.ValorDesconto, ItensPedido.TotalProduto, ItensPedido.CustoMercadoriaVendida, ItensPedido.Promocao, ItensPedido.DevolvidoId, ItensPedido.Devolvido, ItensPedido.QtdDevolvido, ItensPedido.pAcrecimoVenda, ItensPedido.vAcrecimoVenda, ItensPedido.pDescontoEspecial, ItensPedido.vDescontoEspecial FROM (Pedido INNER JOIN ItensPedido ON Pedido.PedidoSequencia = ItensPedido.PedidoSequencia) INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto WHERE (((Pedido.DataPedido) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Pedido.Empresa)=" & CodEmpresa & ") AND ((Pedido.Inativo)=False) AND ((Pedido.Confirmado)=True));"
        End If

      
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet
        Da.Fill(ds, "Pedidos")


        'Carrega os Itens
        Dim CmdItens As New OleDb.OleDbCommand(SqlItens, CNN)
        Dim DaItens As New OleDb.OleDbDataAdapter(CmdItens)

        DsItens = New DataSet
        DaItens.Fill(DsItens, "Itens")


        Me.ListaPedido.DataSource = ds.Tables("Pedidos").DefaultView
        Da.Dispose()

        CNN.Close()

    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged
        If Me.A1.Checked = True Then
            Me.PainelPeriodo.Visible = False
            Me.txtProcura.Visible = True
            Me.txtProcura.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
            Me.txtProcura.TextAlign = HorizontalAlignment.Left
            Me.txtProcura.CasasDecimais = 0
            Me.txtProcura.Clear()
            Me.txtProcura.Focus()
        End If
        If Me.A2.Checked = True Then
            Me.PainelPeriodo.Visible = False
            Me.txtProcura.Visible = True
            Me.txtProcura.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
            Me.txtProcura.TextAlign = HorizontalAlignment.Left
            Me.txtProcura.CasasDecimais = 0
            Me.txtProcura.Clear()
            Me.txtProcura.Focus()
        End If
        If Me.A3.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.txtProcura.Visible = False
            Me.DataInicial.Clear()
            Me.DataFinal.Clear()
            Me.DataInicial.Focus()
        End If
    End Sub

    Private Sub ListaPedido_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListaPedido.SelectionChanged

        Try

            Dim Tbl As New DataView(DsItens.Tables("Itens").Copy)
            Tbl.RowFilter = "PedidoSequencia = " & Me.ListaPedido.CurrentRow.Cells("cPedidoSequencia").Value
            Me.ListaItens.DataSource = Tbl.ToTable()


            Dim FRiscada As New Font("Comic Sans MS", 8, FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point)
            Dim FLimpa As New Font("Comic Sans MS", 8, System.Drawing.GraphicsUnit.Point)

            Dim Index As Integer = 0
            For Each Linha As DataGridViewRow In Me.ListaItens.Rows
                If Linha.Cells("cDevolvido").Value = True Then
                    Me.ListaItens.Rows(Index).DefaultCellStyle.Font = FRiscada
                Else
                    Me.ListaItens.Rows(Index).DefaultCellStyle.Font = FLimpa
                End If
                Index += 1
            Next

        Catch ex As Exception
        End Try

    End Sub

    Private Sub txtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProcura.Leave
        If Me.txtProcura.Text = "" Then
            Exit Sub
        End If

        If Me.A1.Checked = True Then
            EncheListaPedido(1)
        End If
        If Me.A2.Checked = True Then
            EncheListaPedido(2)
        End If
    End Sub

    Private Sub DataFinal_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataFinal.Leave
        If Me.DataInicial.Text = "" Then
            Exit Sub
        End If
        If Me.DataFinal.Text = "" Then
            Exit Sub
        End If

        If Me.A3.Checked = True Then
            EncheListaPedido(3)
        End If
    End Sub

        Private Sub ListaItens_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListaItens.CellClick
        If e.ColumnIndex = 0 Then
            System.Windows.Forms.SendKeys.Send("{Tab}")
        End If
    End Sub


    Private Sub btDevolu��o_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDevolu��o.Click


        If NzZero(Me.ListaPedido.CurrentRow.Cells("cCodigoCliente").Value) = 0 Then
            Exit Sub
        End If

        If Me.ListaPedido.CurrentRow.Cells("cTipoPedido").Value = "DEVOLU��O" Then
            MessageBox.Show("O usu�rio n�o pode fazer uma Devolu��o de uma Devolu��o", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        Dim TSelecionado As Integer = 0
        For Each Linha As DataGridViewRow In Me.ListaItens.Rows
            If Linha.Cells("Selecionado").Value = True Then
                TSelecionado += 1
            End If
        Next

        If TSelecionado = 0 Then
            MessageBox.Show("O usu�rio deve selecionar um item para fazer a Devolu��o", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If



        My.Forms.SellShoesAutenticacao.IdCliente = Me.ListaPedido.CurrentRow.Cells("cCodigoCliente").Value
        My.Forms.SellShoesAutenticacao.PedidoDevolucao = Me.ListaPedido.CurrentRow.Cells("cPedidoSequencia").Value
        My.Forms.SellShoesAutenticacao.OpcDevolu�ao.Checked = True
        My.Forms.SellShoesAutenticacao.OpcDevolu�ao.Enabled = False
        My.Forms.SellShoesAutenticacao.OpcVenda.Enabled = False

        My.Forms.SellShoesAutenticacao.ShowDialog()

        Me.Close()
        Me.Dispose()

    End Sub

  
    Private Sub ListaItens_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListaItens.CellEndEdit


        Dim Index As Integer = 0
        For Each Linha As DataGridViewRow In Me.ListaItens.Rows

            If Linha.Selected = True Then

                If Linha.Cells("cDevolvido").Value = True And Linha.Cells("Selecionado").Value = True Then
                    Me.ListaItens.Rows(Index).Cells("Selecionado").Value = False
                    MessageBox.Show("O Produto que foi selecionado ja foi devolvido, escolha outro.", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                If Me.ListaPedido.CurrentRow.Cells("cTipoPedido").Value = "DEVOLU��O" Then
                    MessageBox.Show("O usu�rio n�o pode fazer uma Devolu��o de uma Devolu��o", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.ListaItens.Rows(Index).Cells("Selecionado").Value = False
                    Exit Sub
                End If

                Index += 1

                If Linha.Cells("Selecionado").Value = True Then
                    If CDbl(NzZero(Linha.Cells("cQtdDevolvido").Value)) < CDbl(NzZero(Linha.Cells("cQtd").Value)) Then
                        My.Forms.SellShoesDevolucaoQtd.ShowDialog()
                        If Q_Devolver > 0 Then
                            If CDbl(NzZero(Linha.Cells("cQtdDevolvido").Value)) + Q_Devolver > CDbl(NzZero(Linha.Cells("cQtd").Value)) Then
                                MessageBox.Show("A Quantidade informada � maior que a disponivel para devolu��o.", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Linha.Cells("cQDevolver").Value = 0
                                Linha.Cells("Selecionado").Value = False
                                Exit Sub
                            End If

                            Linha.Cells("cQDevolver").Value = Q_Devolver
                        Else
                            Linha.Cells("Selecionado").Value = False
                        End If
                    End If
                End If
            End If

        Next

    End Sub

End Class