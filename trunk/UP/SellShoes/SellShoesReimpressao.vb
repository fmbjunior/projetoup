Imports System.Data.OleDb
Public Class SellShoesReimpressao
    Dim sel As Integer
    Private Sub txtProcurar_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProcurar.Leave
        If String.IsNullOrEmpty(Me.txtProcurar.Text) Then
            Return
        End If

        Grid()
    End Sub

    Private Sub Grid()
        Dim Ds As New DataSet

        Dim CN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Try
            CN.Open()

            Dim Sql As String = String.Empty
            'por nome do cliente
            If Me.rdbNome.Checked = True Then
                Sql = "SELECT Pedido.PedidoSequencia, Pedido.PedidoTipo,  Pedido.DataPedido, Clientes.Nome, Funcionários.Nome AS Vendedor, IIf([Pedido].[Inativo]=False,'','CANCELADO') AS Status,Pedido.TotalPedido FROM (Pedido INNER JOIN Clientes ON Pedido.CódigoCliente = Clientes.Codigo) INNER JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário WHERE(((Clientes.Nome) Like '%" & Me.txtProcurar.Text & "%' )) ORDER BY Pedido.PedidoSequencia;"

            End If
            'Por codigo de venda
            If Me.rbnPorcodigo.Checked = True Then
                Sql = "SELECT Pedido.PedidoSequencia, Pedido.PedidoTipo,  Pedido.DataPedido, Clientes.Nome, Funcionários.Nome AS Vendedor, IIf([Pedido].[Inativo]=False,'','CANCELADO') AS Status,Pedido.TotalPedido FROM (Pedido INNER JOIN Clientes ON Pedido.CódigoCliente = Clientes.Codigo) INNER JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário WHERE(((Pedido.PedidoSequencia) = " & Me.txtProcurar.Text & " )) ORDER BY Pedido.PedidoSequencia;"
            End If
            'Por Vendedor
            If Me.rbnVendedor.Checked = True Then
                Sql = "SELECT Pedido.PedidoSequencia, Pedido.PedidoTipo,  Pedido.DataPedido, Clientes.Nome, Funcionários.Nome AS Vendedor, IIf([Pedido].[Inativo]=False,'','CANCELADO') AS Status,Pedido.TotalPedido FROM (Pedido INNER JOIN Clientes ON Pedido.CódigoCliente = Clientes.Codigo) INNER JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário WHERE(((Funcionários.Nome) Like '%" & Me.txtProcurar.Text & "%' )) ORDER BY Pedido.PedidoSequencia;"
            End If
            'Por data
            If Me.rbnData.Checked = True Then
                Sql = "SELECT Pedido.PedidoSequencia, Pedido.PedidoTipo,  Pedido.DataPedido, Clientes.Nome, Funcionários.Nome AS Vendedor, IIf([Pedido].[Inativo]=False,'','CANCELADO') AS Status,Pedido.TotalPedido FROM (Pedido INNER JOIN Clientes ON Pedido.CódigoCliente = Clientes.Codigo) INNER JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário WHERE(((Pedido.DataPedido) = #" & Format(CDate(Me.txtProcurar.Text), "MM/dd/yyyy") & " #)) ORDER BY Pedido.PedidoSequencia;"
            End If

            Dim CMD As New OleDb.OleDbCommand(Sql, CN)
            Dim Da As New OleDb.OleDbDataAdapter(CMD)

            Da.Fill(Ds, "Pedido")
            Me.Dgv.DataSource = Ds.Tables("Pedido").DefaultView
        Catch ex As Exception

        End Try
      
    End Sub

    Private Sub SellShoesReimpressao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub rbnData_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnData.CheckedChanged
        If Me.rbnData.Checked = True Then
            Me.txtProcurar.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
            Me.txtProcurar.Focus()
        Else
            Me.txtProcurar.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
            Me.txtProcurar.Focus()
        End If
    End Sub

    Private Sub SellShoesReimpressao_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F3
                    Me.rdbNome.Checked = True
                    Me.txtProcurar.Focus()

                Case Keys.F4
                    Me.rbnPorcodigo.Checked = True
                    Me.txtProcurar.Focus()

                Case Keys.F5
                    Me.rbnVendedor.Checked = True
                    Me.txtProcurar.Focus()

                Case Keys.F6
                    Me.rbnData.Checked = True
                    Me.txtProcurar.Focus()

            End Select
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnVisualizarimpressao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizarimpressao.Click

        If sel = 0 Or Me.Dgv.Rows.Count = 0 Then
            MessageBox.Show("-------------" _
                & Microsoft.VisualBasic.ControlChars.CrLf & "ATENÇÃO:" _
                & Microsoft.VisualBasic.ControlChars.CrLf & "-------------" _
                & Microsoft.VisualBasic.ControlChars.CrLf & "Não foi selecionado nenhum pedido para a reimpressão.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        'Definir Impressão da Venda
        Dim cl As New cImpressaoPedido 'Cria uma nova instância, nela encontra-se os metodos para impressão do pedido.
        cl.CodigoPedido = sel 'passa o codigo da venda para a classe
        cl.rReimpressao = True
        cl.Impressao(True) 'Faz a impresão

        'Se houve erro retorna um bolean true e cancela.
        If cl.erro = True Then
            MessageBox.Show("Erro ao tentar imprimir o pedido", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        cl = Nothing



        'impressao se for promissoria
        ' If My.Forms.SellShoes.PedidoTipo.Text <> "DEVOLUÇÃO" Then
        '   Dim VarPromissoria As String = My.Forms.SellShoes.TipoPgto.Text
        '   Dim posicao As Integer = VarPromissoria.IndexOf("33 - PROMISSÓRIA")

        '    If posicao = 0 Then
        'Definir Impressão da NP
        Dim clnp As New cImpressNP 'Cria uma nova instância, nela encontra-se os metodos para impressão do NP.
        clnp.CodigoPedido = sel  'passa o codigo da venda para a classe
        clnp.Impressao(True) 'Faz a impresão

        'Se houve erro retorna um bolean true e cancela.
        If clnp.erro = True Then
            MessageBox.Show("Erro ao tentar imprimir a nota promissória", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Cursor = Cursors.Default
        End If

        'RelatorioCarregar = "ImpressNP"
        'My.Forms.VisualizadorRelatorio.ShowDialog()
        ' End If
        '   End If
        'fim




    End Sub

    Private Sub Dgv_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgv.SelectionChanged
        Try
            sel = Me.Dgv.CurrentRow.Cells("gpedido").Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Dgv_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv.CellClick
        Try
            sel = Me.Dgv.CurrentRow.Cells("gpedido").Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rdbNome_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbNome.CheckedChanged, rbnPorcodigo.CheckedChanged, rbnVendedor.CheckedChanged

        If rdbNome.Checked = True Then
            Me.txtProcurar.Focus()
        ElseIf rbnPorcodigo.Checked = True Then
            Me.txtProcurar.Focus()
        ElseIf rbnVendedor.Checked = True Then
            Me.txtProcurar.Focus()
        End If

    End Sub

  
   
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If sel = 0 Or Me.Dgv.Rows.Count = 0 Then
            MessageBox.Show("-------------" _
                & Microsoft.VisualBasic.ControlChars.CrLf & "ATENÇÃO:" _
                & Microsoft.VisualBasic.ControlChars.CrLf & "-------------" _
                & Microsoft.VisualBasic.ControlChars.CrLf & "Não foi selecionado nenhum pedido para a reimpressão.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        'Definir Impressão da Venda
        Dim cl As New cImpressaoPedido 'Cria uma nova instância, nela encontra-se os metodos para impressão do pedido.
        cl.CodigoPedido = sel 'passa o codigo da venda para a classe
        cl.Impressao(False) 'Faz a impresão

        'Se houve erro retorna um bolean true e cancela.
        If cl.erro = True Then
            MessageBox.Show("Erro ao tentar imprimir o pedido", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Me.Cursor = Cursors.Default
            Exit Sub
        End If
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        If sel = 0 Or Me.Dgv.Rows.Count = 0 Then
            MessageBox.Show("-------------" _
                & Microsoft.VisualBasic.ControlChars.CrLf & "ATENÇÃO:" _
                & Microsoft.VisualBasic.ControlChars.CrLf & "-------------" _
                & Microsoft.VisualBasic.ControlChars.CrLf & "Não foi selecionado nenhum pedido para a reimpressão.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        'Definir Impressão da Venda
        Dim cl As New cImpressaoPedido 'Cria uma nova instância, nela encontra-se os metodos para impressão do pedido.
        cl.CodigoPedido = sel 'passa o codigo da venda para a classe
        cl.ImpressaoLiquido(True) 'Faz a impresão

        'Se houve erro retorna um bolean true e cancela.
        If cl.erro = True Then
            MessageBox.Show("Erro ao tentar imprimir o pedido", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Me.Cursor = Cursors.Default
            Exit Sub
        End If
    End Sub
End Class