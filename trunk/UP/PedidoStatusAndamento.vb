Public Class PedidoStatusAndamento

    Dim Tel As New Form() ' Create a new instance of the form.


    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btAtualizaAndamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAtualizaAndamento.Click


        Me.Cursor = Cursors.WaitCursor

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim ds As New DataSet()

        Dim Sql As String = String.Empty

        Sql = "SELECT Pedido.PedidoSequencia, Pedido.Requisicao, Pedido.StatusAndamentos FROM(Pedido) WHERE (((Pedido.StatusAndamentos)<>'FINALIZADO' Or (Pedido.StatusAndamentos) Is Null));"
        Dim DAPedidos As New OleDb.OleDbDataAdapter(Sql, CNN)
        DAPedidos.Fill(ds, "Pedidos")

        Sql = "SELECT Pedido.StatusAndamentos, ItensPedido.PedidoSequencia, Sum(ItensPedido.Qtd) AS SomaDeQtd, Sum(ItensPedido.QtdRetirada) AS SomaDeQtdRetirada FROM Pedido INNER JOIN ItensPedido ON Pedido.PedidoSequencia = ItensPedido.PedidoSequencia GROUP BY Pedido.StatusAndamentos, ItensPedido.PedidoSequencia HAVING (((Pedido.StatusAndamentos)<>'FINALIZADO' Or (Pedido.StatusAndamentos) Is Null));"
        Dim DAItens As New OleDb.OleDbDataAdapter(Sql, CNN)
        DAItens.Fill(ds, "ItensPedidos")



        Dim TotalLinhas As Integer = ds.Tables("ItensPedidos").Rows.Count
        If TotalLinhas = 0 Then TotalLinhas = 1
        MyBarra.Visible = True
        MyBarra.Minimum = 1
        MyBarra.Maximum = TotalLinhas
        MyBarra.Value = 1
        MyBarra.Step = 1

        Dim Status As String = String.Empty
        Dim ContaRegistro As Integer

        Dim DrItem As DataRow
        For Each DrItem In ds.Tables("ItensPedidos").Rows
            Dim DrPedido() As DataRow
            DrPedido = ds.Tables("Pedidos").Select("PedidoSequencia = " & DrItem("PedidoSequencia").ToString)

            Dim TBL As DataTable
            TBL = ds.Tables("Pedidos")

            If NzZero(DrItem("SomaDeQtdRetirada")) = 0 Then Status = "INICIAL"
            If NzZero(DrItem("SomaDeQtdRetirada")) > 0 And NzZero(DrItem("SomaDeQtdRetirada")) < NzZero(DrItem("SomaDeQtd")) Then Status = "EM ANDAMENTO"
            If NzZero(DrItem("SomaDeQtdRetirada")) = NzZero(DrItem("SomaDeQtd")) Then Status = "FINALIZADO"

            If DrPedido.Length <> 0 Then
                DrPedido(0).BeginEdit()
                DrPedido(0)("StatusAndamentos") = Status
                DrPedido(0).EndEdit()
            End If
            ContaRegistro += 1
            MyBarra.Text = "Total de Registro Lido " & ContaRegistro & " de " & TotalLinhas
            MyBarra.PerformStep()
            Me.Refresh()
        Next

        Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAPedidos)
        DAPedidos.Update(ds, "Pedidos")

        DAPedidos.Dispose()
        ds.Dispose()
        CNN.Close()

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub btGerarVisualizacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGerarVisualizacao.Click

        If Me.O1.Checked = False And Me.O2.Checked = False And Me.O3.Checked = False Then
            MessageBox.Show("O usuário deve selecionar um tipo de STATUS do Pedido", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.A1.Checked = False And Me.A2.Checked = False And Me.A3.Checked = False Then
            MessageBox.Show("O usuário deve selecionar uma Opção de STATUS do Pedido", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.A3.Checked = True And Me.DataA.Text = "" Then
            MessageBox.Show("O usuário deve informar o Pedido", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DataA.Focus()
            Exit Sub
        End If



        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty
        Dim Status As String = String.Empty

        If Me.O1.Checked Then Status = "'INICIAL'"
        If Me.O2.Checked Then Status = "'EM ANDAMENTO'"
        If Me.O3.Checked Then Status = "'FINALIZADO'"

        If Me.A1.Checked = True Then
            Sql = "SELECT Pedido.PedidoSequencia, Pedido.Requisicao, Clientes.Nome, Pedido.TotalPedido, Pedido.DataPedido,Pedido.StatusAndamentos FROM Pedido INNER JOIN Clientes ON Pedido.CódigoCliente = Clientes.Codigo WHERE (((Pedido.StatusAndamentos)=" & Status & "));"
        End If

        If Me.A2.Checked = True Then
            Sql = "SELECT Pedido.PedidoSequencia, Pedido.Requisicao, Clientes.Nome, Pedido.TotalPedido, Pedido.StatusAndamentos, Pedido.DataPedido FROM Pedido INNER JOIN Clientes ON Pedido.CódigoCliente = Clientes.Codigo WHERE (((Pedido.StatusAndamentos)=" & Status & ") AND ((Pedido.DataPedido) Between #" & Format(CDate(Me.DataA.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataB.Text), "MM/dd/yyyy") & "#));"
        End If

        If Me.A3.Checked = True Then
            Sql = "SELECT Pedido.PedidoSequencia, Pedido.Requisicao, Clientes.Nome, Pedido.TotalPedido, Pedido.DataPedido,Pedido.StatusAndamentos FROM Pedido INNER JOIN Clientes ON Pedido.CódigoCliente = Clientes.Codigo WHERE (((Pedido.PedidoSequencia)=" & Me.DataA.Text & "));"
        End If

        Dim da = New OleDb.OleDbDataAdapter(Sql, CNN)
        da.SelectCommand.CommandType = CommandType.Text
        Dim ds As New DataSet
        da.Fill(ds, "Pedidos")

        Me.MyLista.DataSource = ds.Tables("Pedidos").DefaultView

        Me.TotalRegistro.Text = "Total de Registro Filtrado : " & Me.MyLista.RowCount
        da.Dispose()
        CNN.Close()

    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged
        If Me.A1.Checked = True Then
            Me.PainelData.Visible = False
        End If

        If Me.A2.Checked = True Then
            Me.PainelData.Visible = True
            Me.DataA.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
            Me.DataA.TextAlign = HorizontalAlignment.Left
            Me.DataA.CasasDecimais = 0
            Me.Label6.Text = "Dt. Inicial"
            Me.Label1.Visible = True
            Me.DataB.Visible = True
            Me.DataA.Clear()
            Me.DataB.Clear()
            Me.DataA.Focus()
        End If

        If Me.A3.Checked = True Then
            Me.PainelData.Visible = True
            Me.DataA.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
            Me.DataA.CasasDecimais = 0
            Me.Label6.Text = "Pedido"
            Me.Label1.Visible = False
            Me.DataB.Visible = False
            Me.DataA.Clear()
            Me.DataB.Clear()
            Me.DataA.Focus()
        End If

    End Sub


    Private Sub MyLista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MyLista.CellDoubleClick
        Dim vID As Integer
        vID = CInt(Me.MyLista.CurrentRow.Cells(0).Value)

        RetornoProcura = vID
        EntrarAchandoPedido = True
        TRVDados(UserAtivo, "PedidoVenda")
        My.Forms.PedidoVenda.ShowDialog()

    End Sub

    Private Sub btImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImprimir.Click

        'TelaDeZoom = TelFind
        Dim Analítico As New Button()
        Dim Sintético As New Button()
        Dim Fechar As New Button()

        Dim F As New Font("Taoma", 9, System.Drawing.GraphicsUnit.Point)

        Tel.Text = "Opção de Relatório"
        Tel.Size = New Size(424, 206)
        Tel.HelpButton = False
        Tel.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
        Tel.MaximizeBox = False
        Tel.MinimizeBox = False
        Tel.ControlBox = False
        Tel.Font = F
        Tel.StartPosition = FormStartPosition.CenterScreen
        Tel.ShowInTaskbar = False


        Analítico.Text = "Analítico"
        Analítico.Location = New Point(12, 66)
        Analítico.Size = New Size(124, 38)
        Analítico.TabIndex = 0
        Analítico.TabStop = True

        Sintético.Text = "Sintético"
        Sintético.Location = New Point(142, 66)
        Sintético.Size = New Size(124, 38)
        Sintético.TabIndex = 1
        Sintético.TabStop = True

        Fechar.Text = "Fechar"
        Fechar.Location = New Point(272, 66)
        Fechar.Size = New Size(124, 38)
        Fechar.TabIndex = 2
        Fechar.TabStop = True



        Tel.Controls.Add(Analítico)
        Tel.Controls.Add(Sintético)
        Tel.Controls.Add(Fechar)


        'Região usada para adicionar a identificação dos eventos
        AddHandler Analítico.Click, AddressOf btAnalitico
        AddHandler Sintético.Click, AddressOf btSintetico
        AddHandler Fechar.Click, AddressOf btFecharTela

        Tel.ShowDialog()

    End Sub

    Private Sub btAnalitico(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RelatorioCarregar = "RelPedidoStatusAnalitico"
        My.Forms.VisualizadorRelatorio.ShowDialog()
    End Sub

    Private Sub btSintetico(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RelatorioCarregar = "RelPedidoStatusSintetico"
        My.Forms.VisualizadorRelatorio.ShowDialog()
    End Sub

    Private Sub btFecharTela(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Tel.Close()
    End Sub

   
    Private Sub PedidoStatusAndamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class