Public Class PedidoVendaFaturamento
    Dim Ação As New TrfGerais

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        EntrarAchandoPedido = False
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub EncheListaPedidos()

        MyLista.Items.Clear()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        Cnn.Open()

        Dim Sql As String = ""
        If Opt2.Checked = True Then
            If Me.A1.Checked = True Then
                Sql = "SELECT Pedido.PedidoInterno, Pedido.Requisicao, Pedido.PedidoTipo, Pedido.PedidoSequencia, Clientes.Nome, Pedido.TotalPedido, Pedido.DataFechamento, Pedido.Confirmado, Pedido.Inativo, Pedido.NatOperação, Pedido.DataPedido FROM Clientes INNER JOIN Pedido ON Clientes.Codigo = Pedido.CódigoCliente WHERE Pedido.DataPedido Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "# and Pedido.PedidoTipo = 'VENDA' ORDER BY Pedido.DataPedido;"
            ElseIf Me.A2.Checked = True Then
                Sql = "SELECT Pedido.PedidoInterno, Pedido.Requisicao, Pedido.PedidoTipo, Pedido.PedidoSequencia, Pedido.CódigoCliente, Clientes.Nome, Pedido.TotalPedido, Pedido.DataFechamento, Pedido.DataPedido, Pedido.Confirmado, Pedido.Inativo, Pedido.NatOperação, Pedido.DataPedido FROM Clientes INNER JOIN Pedido ON Clientes.Codigo = Pedido.CódigoCliente WHERE Pedido.DataPedido Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "# and Pedido.CódigoCliente = " & Me.Cli.Text & " and Pedido.PedidoTipo = 'VENDA' ORDER BY Pedido.DataPedido;"
            ElseIf Me.A3.Checked = True Then
                Sql = "SELECT Pedido.PedidoInterno, Pedido.Requisicao, Pedido.PedidoTipo, Pedido.PedidoSequencia, Clientes.Nome, Pedido.TotalPedido, Pedido.DataFechamento, Pedido.DataPedido, Pedido.Confirmado, Pedido.Inativo, Pedido.NatOperação, Pedido.DataPedido FROM Clientes INNER JOIN Pedido ON Clientes.Codigo = Pedido.CódigoCliente WHERE Pedido.DataPedido = #" & Format(CDate(DataDia), "MM/dd/yyyy") & "# and Pedido.PedidoTipo = 'VENDA' ORDER BY Pedido.DataPedido;"
            ElseIf Me.A4.Checked = True Then
                Sql = "SELECT Pedido.PedidoInterno, Pedido.Requisicao, Pedido.PedidoTipo, Pedido.PedidoSequencia, Clientes.Nome, Pedido.TotalPedido, Pedido.DataFechamento, Pedido.Confirmado, Pedido.Inativo, Pedido.NatOperação, Pedido.DataPedido FROM Clientes INNER JOIN Pedido ON Clientes.Codigo = Pedido.CódigoCliente WHERE Pedido.Confirmado = false and Pedido.Inativo = false and Pedido.PedidoTipo = 'VENDA' ORDER BY Pedido.DataPedido;"
            End If
        Else
            If Me.A1.Checked = True Then
                Sql = "SELECT Pedido.PedidoInterno, Pedido.Requisicao, Pedido.PedidoTipo, Pedido.PedidoSequencia, Clientes.Nome, Pedido.TotalPedido, Pedido.DataFechamento, Pedido.Confirmado, Pedido.Inativo, Pedido.NatOperação, Pedido.DataPedido FROM Clientes INNER JOIN Pedido ON Clientes.Codigo = Pedido.CódigoCliente WHERE Pedido.DataPedido Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "# and Pedido.PedidoTipo = 'VENDA INTERNA' ORDER BY Pedido.DataPedido;"
            ElseIf Me.A2.Checked = True Then
                Sql = "SELECT Pedido.PedidoInterno, Pedido.Requisicao, Pedido.PedidoTipo, Pedido.PedidoSequencia, Pedido.CódigoCliente, Clientes.Nome, Pedido.TotalPedido, Pedido.DataFechamento, Pedido.DataPedido, Pedido.Confirmado, Pedido.Inativo, Pedido.NatOperação, Pedido.DataPedido FROM Clientes INNER JOIN Pedido ON Clientes.Codigo = Pedido.CódigoCliente WHERE Pedido.DataPedido Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "# and Pedido.CódigoCliente = " & Me.Cli.Text & " and Pedido.PedidoTipo = 'VENDA INTERNA' ORDER BY Pedido.DataPedido;"
            ElseIf Me.A3.Checked = True Then
                Sql = "SELECT Pedido.PedidoInterno, Pedido.Requisicao, Pedido.PedidoTipo, Pedido.PedidoSequencia, Clientes.Nome, Pedido.TotalPedido, Pedido.DataFechamento, Pedido.DataPedido, Pedido.Confirmado, Pedido.Inativo, Pedido.NatOperação, Pedido.DataPedido FROM Clientes INNER JOIN Pedido ON Clientes.Codigo = Pedido.CódigoCliente WHERE Pedido.DataPedido = #" & Format(CDate(DataDia), "MM/dd/yyyy") & "# and Pedido.PedidoTipo = 'VENDA INTERNA' ORDER BY Pedido.DataPedido;"
            ElseIf Me.A4.Checked = True Then
                Sql = "SELECT Pedido.PedidoInterno, Pedido.Requisicao, Pedido.PedidoTipo, Pedido.PedidoSequencia, Clientes.Nome, Pedido.TotalPedido, Pedido.DataFechamento, Pedido.Confirmado, Pedido.Inativo, Pedido.NatOperação, Pedido.DataPedido FROM Clientes INNER JOIN Pedido ON Clientes.Codigo = Pedido.CódigoCliente WHERE Pedido.Confirmado = false and Pedido.Inativo = false and Pedido.PedidoTipo = 'VENDA INTERNA' ORDER BY Pedido.DataPedido;"
            End If
        End If



        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = Sql
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            If DataReader.HasRows = False Then
                MsgBox("Vendas não foram localizadas, refaça a pesquisa", 48, "Validação de Dados")

            End If

            Dim Cancelado As String = ""
            Dim Confirmado As String
            Dim SomaValor As Double = 0
            Dim Zebrar As Boolean = True
            Dim IndexImg As Integer = 0
            While DataReader.Read
                If Not IsDBNull(DataReader.Item("PedidoSequencia")) Then

                    If DataReader.Item("Inativo") = True Then
                        IndexImg = 1
                        Cancelado = "SIM"
                    Else
                        IndexImg = 0
                        Cancelado = "NÃO"
                    End If

                    If DataReader.Item("Confirmado") = True Then
                        Confirmado = "SIM"
                    Else
                        Confirmado = "NÃO"
                    End If


                    Dim AA As String = DataReader.Item("PedidoSequencia")
                    Dim item1 As New ListViewItem(AA, IndexImg)
                    item1.SubItems.Add(DataReader.Item("Requisicao") & "")
                    item1.SubItems.Add(DataReader.Item("Nome"))
                    item1.SubItems.Add(FormatNumber(Nz(DataReader.Item("TotalPedido"), 3), 2))
                    item1.SubItems.Add(DataReader.Item("DataPedido") & "")
                    item1.SubItems.Add(Cancelado)
                    item1.SubItems.Add(Confirmado)
                    item1.SubItems.Add(DataReader.Item("PedidoTipo") & "")
                    MyLista.Items.AddRange(New ListViewItem() {item1})

                    SomaValor += Nz(DataReader.Item("TotalPedido"), 3)

                    If Zebrar = True Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.MediumOrchid
                        Zebrar = True
                    End If

                    If Confirmado = "NÃO" Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.RoyalBlue
                    End If

                End If
            End While

            Me.TotalGeral.Text = FormatNumber(SomaValor, 2)
            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()

    End Sub

    Private Sub DataFinal_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataFinal.Leave
        If Me.DataInicial.Text = "" Then
            MsgBox("O usuário deve informar a data Inicial. Verifique...", 64, "Validação de Dados")
            Me.DataInicial.Focus()
            Exit Sub
        ElseIf Me.DataFinal.Text = "" Then
            MsgBox("O usuário deve informar a data Final. Verifique...", 64, "Validação de Dados")
            Me.DataFinal.Focus()
            Exit Sub
        End If

        If Me.A1.Checked = True Then
            EncheListaPedidos()
        End If
    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        Dim I As Integer = 0

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then RetornoProcura = (MyLista.Items(I).Text.Substring(0))
        Next
        EntrarAchandoPedido = True
        TRVDados(UserAtivo, "PedidoVenda")
        My.Forms.PedidoVenda.ShowDialog()

    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged, A4.CheckedChanged

        If Me.A1.Checked = True Then
            MyLista.Items.Clear()
            Me.PainelPeriodo.Visible = True
            Me.PainelCliente.Visible = False
            Me.DataInicial.Focus()
        ElseIf Me.A2.Checked = True Then
            MyLista.Items.Clear()
            Me.PainelPeriodo.Visible = True
            Me.PainelCliente.Visible = True
            Me.DataInicial.Focus()
        ElseIf Me.A3.Checked = True Then
            MyLista.Items.Clear()
            Me.PainelPeriodo.Visible = False
            Me.PainelCliente.Visible = False
            EncheListaPedidos()
        ElseIf Me.A4.Checked = True Then
            MyLista.Items.Clear()
            Me.PainelPeriodo.Visible = False
            Me.PainelCliente.Visible = False
            EncheListaPedidos()
        End If

    End Sub

    
    Private Sub Cli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cli.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ClientesProcura.ShowDialog()
            Me.Cli.Text = RetornoProcura
            If Me.Cli.Text <> "" Then
                Ação.Descrição_ItenRegistro(Me.Cli, Me.CliDesc, "Clientes", "Codigo", Me.Cli.Text, "Nome", TrfGerais.TipoDados.Numérico, True)
            End If
        End If
    End Sub

    Private Sub Cli_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cli.Leave
        If Me.A2.Checked = True Then
            EncheListaPedidos()
        End If
    End Sub

 

    Private Sub Opt2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Opt2.CheckedChanged
        If Opt2.Checked = True Then
            RadioB(Me)
            MyLista.Items.Clear()
        End If
    End Sub
    Private Sub RadioB(ByRef F As System.Windows.Forms.Form)
        Dim Controle As System.Windows.Forms.Control

        For Each Controle In F.Controls
            If TypeOf Controle Is GroupBox Then
                If Controle.Name = "Opc" Then
                    Dim Ctrl As Control
                    For Each Ctrl In Controle.Controls
                        If TypeOf Ctrl Is System.Windows.Forms.RadioButton Then
                            Dim ss As New RadioButton
                            ss = Ctrl
                            ss.Checked = False
                        End If

                    Next
                End If
            End If
        Next Controle
    End Sub

    Private Sub Opt1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Opt1.CheckedChanged
        If Opt1.Checked = True Then
            RadioB(Me)
            MyLista.Items.Clear()
        End If
    End Sub

  
End Class