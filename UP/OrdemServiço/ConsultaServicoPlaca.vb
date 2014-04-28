Public Class ConsultaServicoPlaca
    Dim bs As BindingSource
    Dim ds As New DataSet
    Private Sub ConsultaServicoPlaca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtProcura.Clear()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim sql As String
        sql = "SELECT Pedido.PedidoSequencia, Pedido.DataPedido, ItemServico.Codigoservico, servicos.serv_descricao, ItemServico.qtd, ItemServico.Valorunitario, ItemServico.ValorDesconto, ItemServico.Totalservico, objetoscad.placa FROM ((Pedido INNER JOIN ItemServico ON Pedido.PedidoSequencia = ItemServico.PedidoSequencia) INNER JOIN servicos ON ItemServico.Codigoservico = servicos.serv_codigo) INNER JOIN objetoscad ON Pedido.codobjeto = objetoscad.codobjeto ORDER BY Pedido.PedidoSequencia"

        Dim CMD As New OleDb.OleDbCommand(sql, CNN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet
        Da.Fill(ds, "Table")

        'Crio um BindingSource
        bs = New BindingSource()
        'Conecto meu BindinSource com meu DataSet
        bs.DataSource = ds.Tables(0).DefaultView
        If Len(txtProcura.Text) > 0 Then
            Me.DgvItem.DataSource = bs
        Else
            bs.Filter = "Placa like ''"
        End If
       
        Da.Dispose()
        CNN.Close()



    End Sub

    Private Sub txtProcura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProcura.TextChanged
        bs.Filter = "placa like '%" & txtProcura.Text & "%'"
        If Len(txtProcura.Text) > 0 Then
            Me.DgvItem.DataSource = bs
        Else
            bs.Filter = "Placa like ''"
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
        Me.Dispose()
    End Sub

  
End Class