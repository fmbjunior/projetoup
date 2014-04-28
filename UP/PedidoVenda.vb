Public Class PedidoVenda


    Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

    Dim Ação As New TrfGerais()
    Dim opt As String
    Public ConversorPc As Double = 0
    Dim TipoProduto As Integer = 1
    Dim EstaNosItens As Boolean = False
    Dim JaFoiGeradoReceber As Boolean = False
    Dim PedidoEmAndamento As Boolean = False
    Public PedidoInterno As Double = 0
    Dim DescontoMaximo As Double = 0
    Dim TipoVenda As String = ""
    Dim EstoqueEstaNegativo As Boolean

    Dim QtdEstoqueTela As Double
    Dim QtdEstoqueEdição As Double

    Dim CrtlEstIten As String = "N"
    Dim QtdEstoqueTemp As Double

    Public PVendedorEstaCheia As Boolean = False

    Public SomaTotalProdutos As Double
    Public SomaTotalServicos As Double
    Public SomaDesconto As Double
    Public SomaIpi As Double
    Public SomaDosParcelamentos As Double = 0

    Dim VarTemEntrada As Boolean = False

    Private Operation As Byte
    Private OperationItens As Byte

    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2
    Const VAZ As Byte = 5
    Dim strCombo1 As String
    Dim strCombo2 As String
    Dim xLinha As Integer
    Dim ds As New DataSet

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        If PedidoEmAndamento = True Then
            If MsgBox("O usuário não finalizou este pedido, deseja fechar a tela de pedido mesmo assim ?", 36, "Validação de Dados") = 6 Then
                Me.Close()
                Me.Dispose()
            Else
                Exit Sub
            End If
        Else
            If NzZero(Me.PedidoSequencia.Text) > 0 And Me.Confirmado.Checked = False Then
                UpdatePED()
            End If
            CNN.Close()
            Me.Close()
            Me.Dispose()
        End If
    End Sub
    Sub UpdatePED()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        If Operation = UPD Then

            Dim Sql As String = "Update Pedido  Set CódigoCliente = @1, Propriedade = @2, DataPedido = @3, ObsCab = @4, ObsRod = @5, Empresa = @6, ValorProduto = @7, TotalPedido = @8, ValorAVista = @9, ValorOutros = @10, ValorAFaturar = @11, VlrDescProduto = @12, ValorIpiPedido = @13, DiasParcelamento = @14, CódigoFuncionário = @15, PedidoTipo = @16, StatusAndamentos = @17, FormaPgto = @18, TipoEntrega = @19, PercDesconto = @20, ValorServicos = @21, requisicao = @22, TotalPropostoPedido = @23, MediaDesconto = @24 Where Pedido.PedidoSequencia = " & Me.PedidoSequencia.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CódigoCliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Propriedade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataPedido.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ObsCab.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.ObsRod.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", NzZero(Me.ValorProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", NzZero(Me.TPedido.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzZero(Me.ValorAVista.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", NzZero(Me.ValorOutros.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", NzZero(Me.ValorAFaturar.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", NzZero(Me.VlrDescProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", NzZero(Me.ValorIpiPedido.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", NzZero(Me.DiasParcelamento.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.CódigoFuncionário.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.TpVenda.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.StatusAndamentos.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Nz(Me.ParcelamentoFixo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@19", Nz(Me.TipoEntrega.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@20", NzZero(Me.PercDesconto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@21", NzZero(Me.ValorServicos.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@22", Nz(Me.NumeroControle.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@23", NzZero(Me.TotalPropostoPedido.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@24", NzZero(Me.MediaDesconto.Text)))


            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                Operation = UPD
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
        End If
    End Sub
    Private Sub Novo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Novo.Click
        'Limpar a Tela
        JaFoiGeradoReceber = False

        Me.TabPedido.SelectedTab = Me.TabCliente
        Me.NumeroControle.Clear()
        Me.PedidoSequencia.Clear()
        Me.CódigoCliente.Clear()
        Me.NomeCliente.Clear()
        Me.CpfCgc.Clear()
        Me.LimiteCredito.Clear()
        Me.EmDebito.Clear()
        Me.SaldoLimiteCredito.Clear()

        Me.Insc.Clear()
        Me.Endereço.Clear()
        Me.Cidade.Clear()
        Me.Cep.Clear()
        Me.Estado.Clear()
        Me.ObsCab.Clear()
        Me.ObsRod.Clear()
        Me.Propriedade.Text = ""
        Me.PropriedadeEstado.Clear()
        Me.PropriedadeIncrição.Clear()
        Me.DataPedido.Clear()
        Me.Confirmado.Checked = False
        Me.Inativo.Checked = False
        Me.btAddNumeroControle.Visible = False

        Me.MyLista.Items.Clear()

        Me.ValorProduto.Clear()
        Me.VlrDescProduto.Clear()
        Me.TotalPedido.Clear()
        Me.TPedido.Clear()
        Me.TotalPropostoPedido.Clear()

        Me.CódigoFuncionário.Text = ""
        Me.FuncionarioDesc.Clear()
        Me.ValorAVista.Clear()
        Me.ValorOutros.Clear()
        Me.ValorAFaturar.Clear()
        Me.DiasParcelamento.Clear()
        Me.ParcelamentoFixo.Clear()
        Me.ParcelamentoFixoDesc.Clear()
        Me.TotalParcelamento.Clear()
        Me.MyLista1.Items.Clear()

        Me.PainelParcelamentoFixo.Enabled = True
        Me.DiasParcelamento.Enabled = True

        Me.ConfImg.Visible = False

        If Me.Confirmado.Checked = False Then
            Me.ConfImg.Visible = False
        Else
            Me.ConfImg.Visible = True
        End If


        Dim CX As Boolean = CaixaMovimentoEstaFechado()
        If CX = True Then
            MessageBox.Show("O Caixa de Movimento ja foi finalizado ou não foi iniciado, favor reiniciar o sistema.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
            Exit Sub
        End If

        AchaUltimoPedido()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
        Dim Cmd As OleDb.OleDbCommand = CNN.CreateCommand

        Cmd.Transaction = Transacao

        Try

            Dim Sql As String = "INSERT INTO Pedido (PedidoSequencia, DataPedido, Empresa, ValorProduto, TotalPedido, ValorAVista, ValorOutros, ValorAFaturar, LimiteCredito, PedidoTipo, TipoEntrega, requisicao) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @requisicao)"
            Cmd.CommandText = Sql

            Cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.PedidoSequencia.Text, 1)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataPedido.Text, 1)))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", CodEmpresa))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", 0))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", 0))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", 0))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", 0))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", 0))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", 0))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Me.TpVenda.Text))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Me.TipoEntrega.Text))
            Cmd.Parameters.Add(New OleDb.OleDbParameter("@requisicao", Nz(Me.NumeroControle.Text, 1)))

            Cmd.ExecuteNonQuery()

            Transacao.Commit()
            CNN.Close()
        Catch ex As Exception
            Transacao.Rollback()
            CNN.Close()
            MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.PedidoSequencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CódigoCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.NomeCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CpfCgc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Insc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Endereço.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Cidade.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Cep.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Estado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ObsCab.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ObsRod.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.Propriedade.Enabled = True
        Me.Propriedade.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.PropriedadeEstado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.PropriedadeIncrição.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DataPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.TpVenda.Enabled = True
        Me.TpVenda.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
        Me.TipoEntrega.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não

        Me.CódigoFuncionário.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorAVista.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorOutros.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.ValorAFaturar.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não

        If ParcFixo = True Then
            Me.PainelParcelamentoFixo.Visible = True
            Me.ParcelamentoFixo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.DiasParcelamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Else
            Me.PainelParcelamentoFixo.Visible = False
            Me.ParcelamentoFixo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.DiasParcelamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        End If

        If DescontoEmLinha = False Then
            Me.PainelDesconto.Visible = True
            Me.PercDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.VlrDescProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.TotalPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Else
            Me.PainelDesconto.Visible = False
            Me.PercDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.VlrDescProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.TotalPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        End If

        CNN.Close()
        Operation = UPD
        Me.PedidoSequencia.Focus()

    End Sub

    Private Sub AchaUltimoPedido()

        Dim CnnNew As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CnnNew.Open()

        Dim Sql As String = "Select max(PedidoSequencia) from Pedido"
        Dim Cmd As New OleDb.OleDbCommand(Sql, CnnNew)
        Dim DR As OleDb.OleDbDataReader
        Dim Ult As Integer

        Try
            DR = Cmd.ExecuteReader
            DR.Read()
            If DR.HasRows = True Then
                If Not IsDBNull(DR.Item(0)) Then
                    Ult = DR.Item(0)
                Else
                    Ult = 0
                End If
            Else
                Ult = 0
            End If
            DR.Close()

        Catch EX As System.Exception
            MsgBox(EX.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try

        Me.PedidoSequencia.Text = Ult + 1
        Me.DataPedido.Text = DataDia
        Me.TipoEntrega.Text = "IMEDIATA"
        Me.TpVenda.Text = "VENDA"

    End Sub

    Public Sub LocalizaPedidoNovo()
        If Me.PedidoSequencia.Text = "" Then
            MsgBox("O usuário deve iniciar um novo pedido.", 64, "Validação de Dados")
            Exit Sub
        End If


        Dim Sql As String = "SELECT Pedido.*, Clientes.CpfCgc, Clientes.Insc, Clientes.Nome, Clientes.Endereço, Clientes.Cidade, Clientes.Cep, Clientes.Estado, Pedido.PedidoSequencia, Pedido.StatusAndamentos FROM Pedido INNER JOIN Clientes ON Pedido.CódigoCliente = Clientes.Codigo WHERE (((Pedido.PedidoSequencia) = " & Me.PedidoSequencia.Text & "));"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.CódigoCliente.Text = DR.Item("CódigoCliente") & ""
            PedidoInterno = DR.Item("PedidoInterno")
            Me.DataPedido.Text = DR.Item("DataPedido") & ""
            Me.ObsCab.Text = DR.Item("ObsCab") & ""
            Me.ObsRod.Text = DR.Item("ObsRod") & ""
            Me.Confirmado.Checked = DR.Item("Confirmado")

            Me.CpfCgc.Text = DR.Item("CpfCgc") & ""
            Me.Insc.Text = DR.Item("Insc") & ""
            Me.NomeCliente.Text = DR.Item("Nome") & ""
            Me.Endereço.Text = DR.Item("Endereço") & ""
            Me.Cidade.Text = DR.Item("Cidade") & ""
            Me.Cep.Text = DR.Item("Cep") & ""
            Me.Estado.Text = DR.Item("Estado") & ""
            Me.StatusAndamentos.Text = DR.Item("StatusAndamentos") & ""
        End If

        If Me.Confirmado.Checked = False Then
            Me.ConfImg.Visible = False
        Else
            Me.ConfImg.Visible = True
        End If

        DR.Close()
        Operation = UPD
        Me.PedidoSequencia.Focus()

        'CNN.Close()

    End Sub


    Public Sub EncheListaItens()

        If Me.PedidoSequencia.Text = "" Then Exit Sub

        MyLista.Items.Clear()
        Dim CNN1 As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN1.Open()

        Dim Sql As String = "SELECT Produtos.Descrição, Produtos.Tipo, * FROM ItensPedido INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto WHERE ItensPedido.PedidoSequencia = " & Me.PedidoSequencia.Text & " Order by Produtos.Tipo"

        Dim Cmd As New OleDb.OleDbCommand(Sql, CNN1)
        Dim DataReader As OleDb.OleDbDataReader

        Try
            DataReader = Cmd.ExecuteReader

            SomaTotalProdutos = 0
            SomaTotalServicos = 0
            SomaDesconto = 0
            SomaIpi = 0
            Dim AddLinhaWhite As Boolean = False
            Dim Zebrar As Boolean = False

            While DataReader.Read
                If Not IsDBNull(DataReader.Item("Id")) Then

                    If AddLinhaWhite = False Then
                        If DataReader.Item("Tipo") = 99 Then
                            Dim LinhaBranco As New ListViewItem("", 0)
                            Dim LinhaBranco2 As New ListViewItem("", 0)
                            MyLista.Items.AddRange(New ListViewItem() {LinhaBranco})

                            LinhaBranco2.SubItems.Add("SERVIÇOS")
                            MyLista.Items.AddRange(New ListViewItem() {LinhaBranco2})
                            MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.DarkOrange
                            AddLinhaWhite = True
                        End If
                    End If


                    Dim AA As String = DataReader.Item("Id")
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("ItensPedido.CodigoProduto") & "")
                    item1.SubItems.Add(DataReader.Item("Descrição") & "")
                    item1.SubItems.Add(FormatNumber(DataReader.Item("Qtd"), 4))
                    item1.SubItems.Add(FormatNumber((Nz(DataReader.Item("Qtd"), 3) - Nz(DataReader.Item("QtdRetirada"), 3)), 4))
                    item1.SubItems.Add(FormatNumber(DataReader.Item("ValorUnitario"), 2))
                    item1.SubItems.Add(FormatNumber(DataReader.Item("ValorDesconto"), 2))
                    item1.SubItems.Add(FormatNumber(DataReader.Item("TotalProduto"), 2))

                    MyLista.Items.AddRange(New ListViewItem() {item1})

                    If DataReader.Item("Tipo") <> 99 Then
                        If Zebrar = True Then
                            MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                            Zebrar = False
                        Else
                            MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.MediumOrchid
                            Zebrar = True
                        End If
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.SandyBrown
                    End If

                    If DataReader.Item("Tipo") = 99 Then
                        SomaTotalServicos += CDbl(DataReader.Item("TotalProduto"))
                    Else
                        SomaTotalProdutos += CDbl(DataReader.Item("TotalProduto"))
                    End If

                    SomaDesconto += CDbl(DataReader.Item("ValorDesconto"))
                    SomaIpi += CDbl(DataReader.Item("ValorIpi"))

                End If

            End While

            If Me.VlrDescProduto.Text = "" Then Me.VlrDescProduto.Text = FormatNumber(0, 2)
            If DescontoEmLinha = False Then
                Me.ValorProduto.Text = FormatNumber(SomaTotalProdutos, 2)
                Me.ValorServicos.Text = FormatNumber(SomaTotalServicos, 2)
                'Me.VlrDescProduto.Text = FormatNumber(SomaDesconto, 2)
                Me.ValorIpiPedido.Text = FormatNumber(SomaIpi, 2)
                Me.TotalPedido.Text = FormatNumber((SomaTotalProdutos + SomaTotalServicos + SomaIpi) - NzZero(Me.VlrDescProduto.Text), 2)
                Me.TPedido.Text = FormatNumber((SomaTotalProdutos + SomaTotalServicos + SomaIpi) - NzZero(Me.VlrDescProduto.Text), 2)
            Else
                Me.ValorProduto.Text = FormatNumber(SomaTotalProdutos, 2)
                Me.ValorServicos.Text = FormatNumber(SomaTotalServicos, 2)
                Me.VlrDescProduto.Text = FormatNumber(SomaDesconto, 2)
                Me.ValorIpiPedido.Text = FormatNumber(SomaIpi, 2)
                Me.TotalPedido.Text = FormatNumber((SomaTotalProdutos + SomaTotalServicos + SomaIpi) - NzZero(Me.VlrDescProduto.Text), 2)
                Me.TPedido.Text = FormatNumber((SomaTotalProdutos + SomaTotalServicos + SomaIpi) - NzZero(Me.VlrDescProduto.Text), 2)
            End If


            Dim VarMediaDesconto As Double = 0
            If NzZero(Me.TPedido.Text) <> 0 Then
                VarMediaDesconto = (CDbl(NzZero(Me.VlrDescProduto.Text)) / (CDbl(NzZero(Me.TPedido.Text)) + CDbl(NzZero(Me.VlrDescProduto.Text)))) * 100
            End If
            Me.MediaDesconto.Text = FormatNumber(NzZero(VarMediaDesconto), 2)


            DataReader.Close()
            CNN1.Close()
            Me.MyLista.Refresh()
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                'Cnn.Close()
                Exit Sub
            End If
        End Try
        'Cnn.Close()

    End Sub

    Private Sub AchaFormaPgto()
        If Me.ParcelamentoFixo.Text = "" Then
            VarTemEntrada = False
            Exit Sub
        Else

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "Select * from FormaPgto Where CodFormaPgto = " & Me.ParcelamentoFixo.Text
            Dim Cmd As New OleDb.OleDbCommand(Sql, CNN)
            Dim DR As OleDb.OleDbDataReader

            Try
                DR = Cmd.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    Me.ParcelamentoFixoDesc.Text = DR.Item("Descrição") & ""
                    Me.DiasParcelamento.Text = DR.Item("DiasParcelamento") & ""
                    If DR.Item("TemEntrada") = True Then
                        VarTemEntrada = True
                    Else
                        VarTemEntrada = False
                    End If
                Else
                    Me.ParcelamentoFixoDesc.Text = ""
                    Me.DiasParcelamento.Text = ""
                    VarTemEntrada = False
                End If
                DR.Close()
                CNN.Close()

            Catch Merror As System.Exception
                MsgBox(Merror.ToString)
            End Try
        End If
    End Sub

    Public Sub ZebraLista()
        Dim II As Integer
        Dim Zebrar As Boolean = True
        For II = 0 To MyLista.Items.Count - 1
            If Zebrar = True Then
                MyLista.Items.Item(II).BackColor = Color.White
                Zebrar = False
            Else
                MyLista.Items.Item(II).BackColor = Color.MediumOrchid
                Zebrar = True
            End If
        Next
    End Sub

    Private Sub BloquearCabecalho()

        If Me.MyLista.Items.Count <> 0 Then
            Me.NumeroControle.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.TpVenda.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Sim
            Me.TipoEntrega.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Sim
            Me.CódigoCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Else
            Me.NumeroControle.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.TpVenda.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
            Me.TipoEntrega.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
            Me.CódigoCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        End If
    End Sub

    Private Sub PedidoVenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PainelProcuraPedido.Expanded = False
        Me.TabPedido.SelectedTab = Me.TabCliente
        Me.ConfImg.Visible = False


        If ParcFixo = True Then
            Me.PainelParcelamentoFixo.Visible = True
        Else
            Me.PainelParcelamentoFixo.Visible = False
        End If

        CNN.Open() ' Abre Banco de dados

        If EntrarAchandoPedido = True Then
            EncheTPpedido()
            LocalizaDadosPedido()
            EncheListaItens()
            EncheListaReceber()
            Me.PedidoSequencia.Focus()
            Operation = UPD
        Else
            Operation = VAZ
        End If

        'Bloquear as caixa de entradas habilitando somente o botao novo
        Me.PedidoSequencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CódigoCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.NomeCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CpfCgc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Insc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Endereço.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Cidade.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Cep.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Estado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ObsCab.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ObsRod.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Propriedade.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.PropriedadeEstado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.PropriedadeIncrição.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DataPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim


        Me.ValorProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.VlrDescProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.TotalPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim

        Me.CódigoFuncionário.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorAVista.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorOutros.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ValorAFaturar.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DiasParcelamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.TpVenda.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.TipoEntrega.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim

        If DescontoEmLinha = False Then
            Me.PainelDesconto.Visible = True
        Else
            Me.PainelDesconto.Visible = False
        End If

        'Fim dos controles bloqueados
        If EntrarAchandoPedido = False Then
            EncheTPpedido()
        End If
    End Sub

    Public Sub EncheCaixas(ByVal ControleRetorno As Control, ByVal Tabela As String, ByVal CampoOrdenar As String, ByVal ItemDisplay As String, ByVal ItemCodigo As String, ByVal AgrupaItemDisplay As Boolean)

        Dim ItemCombo As New ArrayList

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        With Cmd
            .Connection = CNN
            .CommandTimeout = 0
            .CommandText = "Select * from " & Tabela & " where Empresa = " & CodEmpresa & " order by " & CampoOrdenar
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            If DataReader.HasRows = True Then
                With ItemCombo
                    While DataReader.Read
                        If Not IsDBNull(DataReader.Item(0)) Then
                            If AgrupaItemDisplay = True Then
                                .Add(New ItemData(DataReader.Item(ItemCodigo) & "-" & DataReader.Item(ItemDisplay), DataReader.Item(ItemCodigo), DataReader.Item(ItemCodigo)))
                            Else
                                .Add(New ItemData(DataReader.Item(ItemDisplay), DataReader.Item(ItemCodigo), DataReader.Item(ItemCodigo)))
                            End If
                        End If
                    End While
                End With
            End If
            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try

        With CType(ControleRetorno, ComboBox)
            .DataSource = ItemCombo
            .DisplayMember = "GetDescrição"
            .ValueMember = "GetidentificadorString"
        End With
        CType(ControleRetorno, ComboBox).SelectedIndex = -1
        'fim inserir ultimo registro

    End Sub

    Public Sub EncheTPpedido()

        Dim ItemCombo As New ArrayList

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        With Cmd
            .Connection = CNN
            .CommandTimeout = 0
            .CommandText = "Select * from PedidoTipo"
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            If DataReader.HasRows = True Then
                With ItemCombo
                    While DataReader.Read
                        If Not IsDBNull(DataReader.Item(0)) Then
                            .Add(DataReader.Item("PedidoTipo"))
                        End If
                    End While
                End With
            End If
            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try

        Me.TpVenda.Items.Clear()
        With CType(Me.TpVenda, ComboBox)
            .DataSource = ItemCombo
        End With
        CType(Me.TpVenda, ComboBox).SelectedIndex = -1
        'fim inserir ultimo registro

    End Sub


    Private Sub CodigoProduto_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        'Me.BalãoAjuda.Show("Pressione enter sem codigo para localizar um produto.", Me.CodigoProduto, 2000)

        If Me.PedidoSequencia.Text = "" Then
            MsgBox("Para lançar Itens o usuário deve selecionar um pedido.", 64, "Validação de Dados")
            Me.PedidoSequencia.Focus()
            Exit Sub
        End If
    End Sub

    Public Sub LocalizaDadosPedido()

        If RetornoProcura = "" Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT Pedido.PedidoInterno, Pedido.PedidoSequencia, Pedido.PedidoTipo, Pedido.TipoEntrega, Pedido.Requisicao, Pedido.LimiteCredito, Pedido.CódigoFuncionário, Pedido.CódigoCliente, Pedido.Propriedade, Pedido.DataPedido, Pedido.PercDesconto, Pedido.VlrDescProduto, Pedido.ValorProduto, Pedido.TotalPedido, Pedido.TotalPropostoPedido, Pedido.ValorAVista, Pedido.ValorOutros, Pedido.ValorAFaturar, Pedido.DataFechamento, Pedido.NatOperação, Pedido.Empresa, Pedido.Inativo, Pedido.Confirmado, Pedido.ObsCab, Pedido.ObsRod, Pedido.FormaPgto, FormaPgto.Descrição, Pedido.DiasParcelamento, Pedido.ImpressoPedido, Pedido.ValorIpiPedido, Pedido.InfBloqueio, Pedido.StatusAndamentos, Funcionários.Nome, Propriedades.NomePropriedade, Propriedades.Estado, Propriedades.Inscricao, CFOP.Descrição, Clientes.CpfCgc, Clientes.Insc, Clientes.UsarLimite, Clientes.Nome, Clientes.tpComercio,Clientes.Endereço, Clientes.Cidade, Clientes.Cep, Clientes.Estado FROM ((((Pedido LEFT JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário) LEFT JOIN Propriedades ON Pedido.Propriedade = Propriedades.Id) LEFT JOIN CFOP ON Pedido.NatOperação = CFOP.CFOP) LEFT JOIN Clientes ON Pedido.CódigoCliente = Clientes.Codigo) LEFT JOIN FormaPgto ON Pedido.FormaPgto = FormaPgto.CodFormaPgto WHERE (((Pedido.PedidoSequencia)=" & RetornoProcura & "));"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows = True Then
            Me.PedidoSequencia.Text = DR.Item("PedidoSequencia") & ""
            PedidoInterno = DR.Item("PedidoInterno")
            Me.NumeroControle.Text = DR.Item("Requisicao") & ""
            Me.CódigoCliente.Text = DR.Item("CódigoCliente") & ""
            Me.DataPedido.Text = DR.Item("DataPedido") & ""
            Me.DataFechamento.Text = DR.Item("DataFechamento") & ""
            Me.ObsCab.Text = DR.Item("ObsCab") & ""
            Me.ObsRod.Text = DR.Item("ObsRod") & ""
            Me.Confirmado.Checked = DR.Item("Confirmado")
            Me.TpVenda.SelectedIndex = Me.TpVenda.FindStringExact(DR.Item("PedidoTipo") & "")
            Me.TipoEntrega.SelectedIndex = Me.TipoEntrega.FindStringExact(DR.Item("TipoEntrega") & "")

            Me.ValorProduto.Text = FormatCurrency(Nz(DR.Item("ValorProduto"), 3), 2)
            Me.TotalPedido.Text = FormatCurrency(Nz(DR.Item("TotalPedido"), 3), 2)
            Me.TotalPropostoPedido.Text = FormatCurrency(Nz(DR.Item("TotalPropostoPedido"), 3), 2)
            Me.ValorAVista.Text = FormatCurrency(Nz(DR.Item("ValorAVista"), 3), 2)
            Me.ValorOutros.Text = FormatCurrency(Nz(DR.Item("ValorOutros"), 3), 2)
            Me.ValorAFaturar.Text = FormatCurrency(Nz(DR.Item("ValorAFaturar"), 3), 2)
            Me.PercDesconto.Text = FormatCurrency(NzZero(DR.Item("PercDesconto")), 3)
            Me.VlrDescProduto.Text = FormatCurrency(NzZero(DR.Item("VlrDescProduto")), 2)
            Me.ParcelamentoFixo.Text = DR.Item("FormaPgto") & ""
            Me.ParcelamentoFixoDesc.Text = DR.Item("FormaPgto.Descrição") & ""
            Me.DiasParcelamento.Text = DR.Item("DiasParcelamento") & ""
            Me.CódigoFuncionário.Text = DR.Item("CódigoFuncionário") & ""
            Me.FuncionarioDesc.Text = DR.Item("Funcionários.Nome") & ""

            Me.Propriedade.Text = DR.Item("Propriedade") & ""
            Me.PropriedadeDesc.Text = DR.Item("NomePropriedade") & ""
            Me.PropriedadeEstado.Text = DR.Item("Propriedades.Estado") & ""
            Me.PropriedadeIncrição.Text = DR.Item("Inscricao") & ""


            ' TipoVenda = DR.Item("TipoVenda") & ""

            Me.CpfCgc.Text = DR.Item("CpfCgc") & ""
            Me.Insc.Text = DR.Item("Insc") & ""
            Me.NomeCliente.Text = DR.Item("Clientes.Nome") & ""
            Me.tpComercio.Text = DR.Item("tpComercio") & ""
            Me.Endereço.Text = DR.Item("Endereço") & ""
            Me.Cidade.Text = DR.Item("Cidade") & ""
            Me.Cep.Text = DR.Item("Cep") & ""
            Me.Estado.Text = DR.Item("Clientes.Estado") & ""
            Me.LimiteCredito.Text = FormatNumber(Nz(DR.Item("LimiteCredito"), 3), 2)
            ' Me.UsarLimite.Checked = DR.Item("UsarLimite")
            Me.StatusAndamentos.Text = Trim(DR.Item("StatusAndamentos") & "")
            Me.Inativo.Checked = DR.Item("Inativo")

            If Me.Confirmado.Checked = False Then
                Me.ConfImg.Visible = False
                Me.ConfImg.Text = "Pedido Confirmado"
            Else
                Me.ConfImg.Visible = True
            End If

            If Me.Inativo.Checked = True Then
                Me.ConfImg.Visible = True
                Me.ConfImg.Text = "Pedido Cancelado"
            End If

            If Me.NumeroControle.Text = "" Then
                If Me.Confirmado.Checked = True Then
                    Me.btAddNumeroControle.Visible = True
                End If
            End If

        End If
        DR.Close()
        CNN.Close()


        If Me.Inativo.Checked = False Then

            If Me.Confirmado.Checked = False Then
                Me.PedidoSequencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.CódigoCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                Me.NomeCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.CpfCgc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.Insc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.Endereço.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.Cidade.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.Cep.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.Estado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.ObsCab.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                Me.ObsRod.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                Me.Propriedade.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                Me.PropriedadeEstado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.PropriedadeIncrição.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.DataPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                Me.TpVenda.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
                Me.TipoEntrega.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
                Me.VlrDescProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.TotalPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim

                If ParcFixo = True Then
                    Me.PainelParcelamentoFixo.Visible = True
                    Me.ParcelamentoFixo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                    Me.ParcelamentoFixoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                    Me.DiasParcelamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Else
                    Me.PainelParcelamentoFixo.Visible = False
                    Me.DiasParcelamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                End If

                Me.CódigoFuncionário.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                Me.ValorAVista.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                Me.ValorOutros.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                Me.ValorAFaturar.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                Me.btGerarParcelas.Enabled = True


                Operation = UPD
                Me.PedidoSequencia.Focus()

            End If
        End If

        DR.Close()

        VerificaSaldoCreditoAtualizado()

    End Sub

    Private Sub Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar.Click

        If Me.Inativo.Checked = True Then
            MessageBox.Show("Este pedido foi cancelado, somente pode ser visualizado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.Confirmado.Checked = True Then
            MessageBox.Show("Este pedido ja foi confirmado, somente pode ser visualizado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Me.NumeroControle.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.PedidoSequencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.CódigoCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.NomeCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.CpfCgc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.Insc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.Endereço.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.Cidade.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.Cep.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.Estado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.ObsCab.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.ObsRod.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.Propriedade.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.PropriedadeEstado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.PropriedadeIncrição.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.DataPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.TpVenda.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
            Me.TipoEntrega.BloquearCx = CBOAutoCompleteFocus.CboFocus.Bloquear.Não
            Me.TotalPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim

            If ParcFixo = True Then
                Me.PainelParcelamentoFixo.Visible = True
                Me.ParcelamentoFixo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                Me.ParcelamentoFixoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.DiasParcelamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Else
                Me.PainelParcelamentoFixo.Visible = False
                Me.DiasParcelamento.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            End If

            If DescontoEmLinha = False Then
                Me.PainelDesconto.Visible = True
                Me.PercDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                Me.VlrDescProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                Me.TotalPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Else
                Me.PainelDesconto.Visible = False
                Me.PercDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.VlrDescProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.TotalPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            End If

            Me.CódigoFuncionário.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.ValorAVista.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.ValorOutros.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.ValorAFaturar.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.btGerarParcelas.Enabled = True


            Operation = UPD
            Me.PedidoSequencia.Focus()
        End If
    End Sub


    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        EditaItemToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub Ipi_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        'If Me.Ipi.Text = "" Then Me.Ipi.Text = FormatNumber(0, 2)
    End Sub

    Private Sub ValorIpi_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        'If Me.Ipi.Text = "" Then Me.Ipi.Text = FormatNumber(0, 2)
        'Me.ValorIpi.Text = FormatNumber(CDbl(Me.TotalProduto.Text) * CDbl(Me.Ipi.Text) / 100, 2)
    End Sub

    Private Sub ExcluirItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirItemToolStripMenuItem.Click
        If Me.Confirmado.Checked = True Then
            MsgBox("Este pedido já foi confirmado, não pode ser alterado.", 64, "Validação de Dados")
            Exit Sub
        End If

        If Me.Inativo.Checked = True Then
            MsgBox("Este pedido já foi cancelado, não pode ser alterado.", 64, "Validação de Dados")
            Exit Sub
        End If

        If JaFoiGeradoReceber = True Then
            MsgBox("Neste pedido não pode ser Excluido produto, pois ja foi gerado o contas a receber, exclua o contas receber para incluir novos produtos.", 64, "Validação de Dados")
            Exit Sub
        End If

        RetornoProcura = ""
        Dim I As Integer = 0
        Dim Prod As String = ""

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then RetornoProcura = (MyLista.Items(I).Text.Substring(0))
            If MyLista.Items(I).Selected = True Then Prod = MyLista.Items(I).SubItems(1).Text.Substring(0)
        Next

        If RetornoProcura = "" Then
            MsgBox("O usuário deve selecionar um item da lista.", 64, "Validação de Dados")
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Delete * from ItensPedido where Id = " & RetornoProcura
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader

        DR.Close()
        CNN.Close()

        OperationItens = INS


        EncheListaItens()


    End Sub

    Private Sub EditaItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditaItemToolStripMenuItem.Click
        If Me.Confirmado.Checked = True Then
            MsgBox("Este pedido já foi confirmado, não pode ser alterado.", 64, "Validação de Dados")
            Exit Sub
        End If

        If JaFoiGeradoReceber = True Then
            MsgBox("Neste pedido não pode ser Editado produto, pois ja foi gerado o contas a receber, exclua o contas receber para incluir novos produtos.", 64, "Validação de Dados")
            Exit Sub
        End If

        RetornoProcura = ""
        Dim I As Integer = 0

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then RetornoProcura = (MyLista.Items(I).Text.Substring(0))
        Next

        If RetornoProcura = "" Then
            MsgBox("O usuário deve selecionar um item da lista.", 64, "Validação de Dados")
            Exit Sub
        End If

        My.Forms.PedidoAddItem.OperationItens = UPD
        PedidoAddItem.ShowDialog()

    End Sub

    Private Sub NovoItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoItemToolStripMenuItem.Click
        btNovoItem_Click(sender, e)
        'If Me.Confirmado.Checked = True Then
        '    MsgBox("Este pedido já foi confirmado, não pode ser alterado.", 64, "Validação de Dados")
        '    Exit Sub
        'End If

        'If JaFoiGeradoReceber = True Then
        '    MsgBox("Neste pedido não pode ser incluido produto, pois ja foi gerado o contas a receber, exclua o contas receber para incluir novos produtos.", 64, "Validação de Dados")
        '    Exit Sub
        'End If

        'OperationItens = INS

        'LimparItens()
        'Me.CodigoProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        'Me.CodigoProduto.Focus()
    End Sub

    Private Sub AVista_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorAVista.Enter
        If Me.ValorAVista.Text = "" Then Me.ValorAVista.Text = FormatCurrency(0, 2)
    End Sub

    Private Sub AVista_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorAVista.Leave
        Me.ValorAVista.Text = FormatCurrency(Me.ValorAVista.Text, 2)
    End Sub

    Private Sub ValorOutros_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorOutros.Enter
        If Me.ValorOutros.Text = "" Then Me.ValorOutros.Text = FormatCurrency(0, 2)
    End Sub

    Private Sub ValorOutros_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorOutros.Leave
        Me.ValorOutros.Text = FormatCurrency(Me.ValorOutros.Text, 2)
    End Sub

    Private Sub ValorAFaturar_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorAFaturar.Enter
        If Me.ValorAFaturar.Text = "" Then Me.ValorAFaturar.Text = FormatCurrency(CDbl(NzZero(Me.TPedido.Text)) - CDbl(NzZero(Me.ValorAVista.Text)) - CDbl(NzZero(Me.ValorOutros.Text)), 2)
    End Sub

    Private Sub ValorAFaturar_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorAFaturar.Leave
        Me.ValorAFaturar.Text = FormatCurrency(CDbl(NzZero(Me.TotalPedido.Text)) - CDbl(NzZero(Me.ValorAVista.Text)) - CDbl(NzZero(Me.ValorOutros.Text)), 2)
        Me.ValorAFaturar.Text = FormatCurrency(NzZero(Me.ValorAFaturar.Text), 2)

        If NzZero(Me.ValorAFaturar.Text) = 0 Then
            Me.PainelParcelamentoFixo.Enabled = False
            Me.DiasParcelamento.Enabled = False
            Me.ParcelamentoFixo.Text = 0
        Else
            Me.PainelParcelamentoFixo.Enabled = True
            Me.DiasParcelamento.Enabled = True
            Me.ParcelamentoFixo.Text = 0
            Me.ParcelamentoFixo.Focus()
        End If
    End Sub

    Private Sub Salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salvar.Click

        If Me.TotalParcelamento.Text = "" Then FormatNumber(0, 2)

        If Me.Confirmado.Checked = True Then
            MsgBox("Este Pedido/Venda já foi confirmado não pode ser alterado.", 64, "Validação de Dados")
            Exit Sub
        End If


        If DescontoEmLinha = True Then
            Me.VlrDescProduto.Text = FormatCurrency(SomaDesconto, 2)
            Me.TotalPedido.Text = FormatCurrency(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.ValorIpiPedido.Text)) - CDbl(NzZero(Me.VlrDescProduto.Text)), 2)

            'Me.TotalPedido.Text = FormatCurrency(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.ValorIpiPedido.Text)))
        Else
            Me.TotalPedido.Text = FormatCurrency(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.ValorIpiPedido.Text)) - CDbl(NzZero(Me.VlrDescProduto.Text)), 2)
        End If

        If Me.ValorIpiPedido.Text = "" Then Me.ValorIpiPedido.Text = FormatCurrency(SomaIpi, 2)
        If Me.VlrDescProduto.Text = "" Then Me.VlrDescProduto.Text = FormatCurrency(0, 2)
        If Me.ValorProduto.Text = "" Then Me.ValorProduto.Text = FormatCurrency(SomaTotalProdutos, 2)


        If Me.ValorAVista.Text = "" Then Me.ValorAVista.Text = FormatCurrency(0, 2)
        If Me.ValorOutros.Text = "" Then Me.ValorOutros.Text = FormatCurrency(0, 2)
        If Me.ValorAFaturar.Text = "" Then Me.ValorAFaturar.Text = FormatCurrency(0, 2)
        If Me.Propriedade.Text = "" Then Me.Propriedade.Text = 0


        If Me.TpVenda.Text <> "CONSIGNAÇÃO" Then
            If Me.CódigoFuncionário.Text = "" Then
                MsgBox("O usuário deve selecionar um vendedor para o Pedido.", 64, "Validação de Dados")
                Me.CódigoFuncionário.Focus()
                Exit Sub
            End If
        End If

        If CDbl(NzZero(Me.ValorAFaturar.Text)) <> 0 Then
            If Me.DiasParcelamento.Text = "" Then
                MsgBox("O usuário deve criar o parcelamento para o valor a ser faturado.", 64, "Validação de Dados")
                Me.DiasParcelamento.Focus()
                Exit Sub
            End If
        End If

        If Me.UsarLimite.Checked = True Then
            Dim VlrFaturar As Double = FormatNumber(NzZero(Me.ValorAFaturar.Text), 2)
            Dim VlrLimite As Double = FormatNumber(Me.LimiteCredito.Text, 2)
            If VlrFaturar > VlrLimite Then
                MsgBox("Este Cliente esta sendo controlado por limite de Crédito, Limite ultrapassado, Verifique.", 64, "Validação de Dados")
                Exit Sub
            End If
        End If

        If Me.TpVenda.Text = "" Then
            MsgBox("O usuário deve informar qual o tipo de venda.", 64, "Validação de Dados")
            Me.TpVenda.Focus()
            Exit Sub
        End If

        If Me.StatusAndamentos.Text = "" Then Me.StatusAndamentos.Text = "INICIAL"

        If Me.TotalPropostoPedido.Text = "" Then Me.TotalPropostoPedido.Text = FormatNumber(0, 2)

        If NzZero(Me.TotalPropostoPedido.Text) = 0 Then
            Me.TotalPropostoPedido.Text = FormatNumber(NzZero(Me.TPedido.Text), 2)
        End If

        If CDbl(NzZero(Me.TotalPropostoPedido.Text)) < CDbl(NzZero(Me.TPedido.Text)) Then
            Me.TotalPropostoPedido.Text = FormatNumber(NzZero(Me.TPedido.Text), 2)
        End If

        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        If Operation = UPD Then

            Dim Sql As String = "Update Pedido  Set CódigoCliente = @1, Propriedade = @2, DataPedido = @3, ObsCab = @4, ObsRod = @5, Empresa = @6, ValorProduto = @7, TotalPedido = @8, ValorAVista = @9, ValorOutros = @10, ValorAFaturar = @11, VlrDescProduto = @12, ValorIpiPedido = @13, DiasParcelamento = @14, CódigoFuncionário = @15, PedidoTipo = @16, StatusAndamentos = @17, FormaPgto = @18, TipoEntrega = @19, PercDesconto = @20, ValorServicos = @21, requisicao = @22, TotalPropostoPedido = @23, MediaDesconto = @24 Where Pedido.PedidoSequencia = " & Me.PedidoSequencia.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CódigoCliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Propriedade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataPedido.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ObsCab.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.ObsRod.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", NzZero(Me.ValorProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", NzZero(Me.TotalPedido.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzZero(Me.ValorAVista.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", NzZero(Me.ValorOutros.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", NzZero(Me.ValorAFaturar.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", NzZero(Me.VlrDescProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", NzZero(Me.ValorIpiPedido.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", NzZero(Me.DiasParcelamento.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.CódigoFuncionário.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.TpVenda.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.StatusAndamentos.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Nz(Me.ParcelamentoFixo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@19", Nz(Me.TipoEntrega.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@20", NzZero(Me.PercDesconto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@21", NzZero(Me.ValorServicos.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@22", Nz(Me.NumeroControle.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@23", NzZero(Me.TotalPropostoPedido.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@24", NzZero(Me.MediaDesconto.Text)))

            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Editou, Me.PedidoSequencia.Text)
                Operation = UPD
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
        End If

    End Sub

    Private Sub Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Imprimir.Click

        If Me.TpVenda.Text = "" Then
            MsgBox("O usuário deve informar qual o tipo de venda.", 64, "Validação de Dados")
            Me.TpVenda.Focus()
            Exit Sub
        End If

        'se Diferente de consignaçao testa alguns campos obrigatorios
        If Me.TpVenda.Text <> "CONSIGNAÇÃO" Then

            If NzZero(Me.CódigoFuncionário.Text) = 0 Then
                MsgBox("O usuário deve selecionar um vendedor para o Pedido.", 64, "Validação de Dados")
                Me.CódigoFuncionário.Focus()
                Exit Sub
            End If

            If Me.TotalParcelamento.Text = "" Then Me.TotalParcelamento.Text = FormatCurrency(0, 2)

            If Me.TotalParcelamento.Text <> Me.ValorAFaturar.Text Then
                MsgBox("VERIFIQUE....O valor do parcelamento esta diferente do valor a faturar.", 64, "Validação de Dados")
                Me.ValorAFaturar.Focus()
                Exit Sub
            End If

            Dim SomaValores As Double = 0
            SomaValores = CDbl(Me.ValorAVista.Text) + CDbl(Me.ValorOutros.Text) + CDbl(Me.ValorAFaturar.Text)
            If FormatNumber(CDbl(SomaValores), 2) <> FormatNumber(CDbl(Me.TPedido.Text), 2) Then
                MsgBox("VERIFIQUE....O valor do Pedido esta diferente dos valores faturado.", 64, "Validação de Dados")
                Me.ValorAVista.Focus()
                Exit Sub
            End If
        End If
        'Fim das validaçoes se diferente de consignaçao

        If Me.ValorIpiPedido.Text = "" Then Me.ValorIpiPedido.Text = FormatCurrency(SomaIpi, 2)
        If Me.VlrDescProduto.Text = "" Then Me.VlrDescProduto.Text = FormatCurrency(0, 2)
        If Me.ValorProduto.Text = "" Then Me.ValorProduto.Text = FormatCurrency(SomaTotalProdutos, 2)

        If DescontoEmLinha = True Then
            Me.VlrDescProduto.Text = FormatCurrency(SomaDesconto, 2)
            Me.TotalPedido.Text = FormatCurrency(CDbl(Me.ValorProduto.Text) + CDbl(Me.ValorIpiPedido.Text) - CDbl(Me.VlrDescProduto.Text), 2)

        Else
            Me.TotalPedido.Text = FormatCurrency(CDbl(Me.ValorProduto.Text) + CDbl(Me.ValorIpiPedido.Text) - CDbl(Me.VlrDescProduto.Text), 2)
        End If


        If Me.ValorAVista.Text = "" Then Me.ValorAVista.Text = FormatCurrency(0, 2)
        If Me.ValorOutros.Text = "" Then Me.ValorOutros.Text = FormatCurrency(0, 2)
        If Me.ValorAFaturar.Text = "" Then Me.ValorAFaturar.Text = FormatCurrency(0, 2)
        If Me.Propriedade.Text = "" Then Me.Propriedade.Text = 0


        If Me.ValorAFaturar.Text <> 0 Then
            If Me.DiasParcelamento.Text = "" Then
                MsgBox("O usuário deve criar o parcelamento para o valor a ser faturado.", 64, "Validação de Dados")
                Me.DiasParcelamento.Focus()
                Exit Sub
            End If
        End If

        If Me.TipoEntrega.Text = "" Then
            MessageBox.Show("O usuário deve selecionar o tipo de entrega", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.TpVenda.Text = "" Then
            MessageBox.Show("O usuário deve selecionar o tipo de venda", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        'Fim da Area destinada para as validacoes
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        If Operation = UPD Then

            Dim Sql As String = "Update Pedido  Set CódigoCliente = @1, Propriedade = @2, DataPedido = @3, ObsCab = @4, ObsRod = @5, Empresa = @6, ValorProduto = @7, TotalPedido = @8, ValorAVista = @9, ValorOutros = @10, ValorAFaturar = @11, VlrDescProduto = @12, ValorIpiPedido = @13, DiasParcelamento = @14, CódigoFuncionário = @15, PedidoTipo = @16, StatusAndamentos = @17, FormaPgto = @18, TipoEntrega = @19, PercDesconto = @20, ValorServicos = @21, TotalPropostoPedido = @22 Where Pedido.PedidoSequencia = " & Me.PedidoSequencia.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CódigoCliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Propriedade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataPedido.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ObsCab.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.ObsRod.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", NzZero(Me.ValorProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", NzZero(Me.TotalPedido.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzZero(Me.ValorAVista.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", NzZero(Me.ValorOutros.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", NzZero(Me.ValorAFaturar.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", NzZero(Me.VlrDescProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", NzZero(Me.ValorIpiPedido.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", NzZero(Me.DiasParcelamento.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.CódigoFuncionário.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.TpVenda.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.StatusAndamentos.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Nz(Me.ParcelamentoFixo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@19", Nz(Me.TipoEntrega.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@20", NzZero(Me.PercDesconto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@21", NzZero(Me.ValorServicos.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@22", NzZero(Me.TotalPropostoPedido.Text)))


            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                Operation = UPD
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
        End If


        RelatorioCarregar = "RelPedidoImpress"
        My.Forms.VisualizadorRelatorio.ShowDialog()
        PedidoEmAndamento = False
    End Sub

    Public Sub GerarParcelamentos()

        CNN.Close()

        Dim ComissaoFaixaExecutar As Double = 0
        If TipoComissaoVenda = "porFAIXA" Then
            Dim CNNComissao As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNNComissao.Open()

            Dim SqlEMPRESA As String = "Select * From EmpresaComissaoFaixa Where Empresa = " & CodEmpresa
            Dim CmdEmpresaComissao As New OleDb.OleDbCommand(SqlEMPRESA, CNNComissao)

            Dim DrEmpresaComissao As OleDb.OleDbDataReader

            DrEmpresaComissao = CmdEmpresaComissao.ExecuteReader
            DrEmpresaComissao.Read()

            Dim media_DESCONTO As Double = FormatNumber(CDbl(Me.MediaDesconto.Text), 2)
            If DrEmpresaComissao.HasRows = True Then
                If media_DESCONTO <= DrEmpresaComissao.Item("pFaixa1") Then ComissaoFaixaExecutar = DrEmpresaComissao.Item("cFaixa1")
                If media_DESCONTO > DrEmpresaComissao.Item("pFaixa1") And Me.MediaDesconto.Text <= DrEmpresaComissao.Item("pFaixa2") Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa2")))
                If media_DESCONTO > DrEmpresaComissao.Item("pFaixa2") And Me.MediaDesconto.Text <= DrEmpresaComissao.Item("pFaixa3") Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa3")))
                If media_DESCONTO > DrEmpresaComissao.Item("pFaixa3") And Me.MediaDesconto.Text <= DrEmpresaComissao.Item("pFaixa4") Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa4")))
                If media_DESCONTO > DrEmpresaComissao.Item("pFaixa4") And Me.MediaDesconto.Text <= DrEmpresaComissao.Item("pFaixa5") Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa5")))
                If media_DESCONTO > DrEmpresaComissao.Item("pFaixa5") And Me.MediaDesconto.Text <= DrEmpresaComissao.Item("pFaixa6") Then ComissaoFaixaExecutar = CDbl(NzZero(DrEmpresaComissao.Item("cFaixa6")))
            End If
            CNNComissao.Close()
        End If





        If Me.ValorAFaturar.Text = "" Or Me.ValorAFaturar.Text = 0 Then
            Exit Sub
        End If

        If Me.DiasParcelamento.Text = "" Then
            Exit Sub
        End If

        'Pegar o total de Parcelamentos
        Dim Parcelas() As String = Split(Me.DiasParcelamento.Text, "-")
        Dim Contar As Integer
        Dim Dividido As Decimal


        Dim CNNReceber As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNNReceber.Open()

        Dim Ds As New DataSet

        Dim Sql As String = "SELECT * from Receber Where Id = -1"

        Dim DAReceber As New OleDb.OleDbDataAdapter(Sql, CNNReceber)
        DAReceber.Fill(ds, "Receber")



        Dim VlrFat As Double = FormatNumber(Me.ValorAFaturar.Text, 2)
        If VlrMinFat > VlrFat Then
            If Parcelas.Length > 1 Then
                MessageBox.Show("O Valor a faturar não atingiu o valor mínimo de faturamento, o Pedido deve ser Parcelado em 1 vez ou ser a vista.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.ValorAVista.Focus()
                CNNReceber.Open()
                Exit Sub
            End If
        End If

        Dividido = Me.ValorAFaturar.Text / Parcelas.Length

        For Contar = 1 To Parcelas.Length
            Dim DrNew As DataRow
            DrNew = Ds.Tables("Receber").NewRow

            Dim Parc As String = Me.PedidoSequencia.Text & "-" & Contar & "/" & Parcelas.Length
            If Me.TpVenda.Text = "DEVOLUÇÃO" Then Parc = "D" & Parc
            DrNew("Documento") = Parc
            DrNew("DataDocumento") = Me.DataPedido.Text
            DrNew("ValorDocumento") = Dividido
            DrNew("LocalPgto") = "CARTEIRA"
            DrNew("PedidoProdutos") = Me.PedidoSequencia.Text
            DrNew("CodCliente") = Me.CódigoCliente.Text
            DrNew("Cliente") = Me.NomeCliente.Text
            DrNew("Empresa") = CodEmpresa
            DrNew("OriginalParcial") = "O"
            DrNew("Vendedor") = Me.CódigoFuncionário.Text
            DrNew("Vencimento") = CDate(Me.DataPedido.Text).AddDays(CInt(Parcelas(Contar - 1)))
            DrNew("MediaDescontoPedido") = Me.MediaDesconto.Text
            DrNew("PercentComissao") = ComissaoFaixaExecutar
            DrNew("ControlePedido") = Nz(Me.NumeroControle.Text, 1)
            If Me.TpVenda.Text = "DEVOLUÇÃO" Then DrNew("Referencia") = "DEVOLUÇÃO REALIZADA NO DIA " & DataDia & " USUÁRIO " & UserAtivo
            DrNew("ContaValorBaixado") = Nz(CodLancamentoReceber, 1)
            DrNew("ContaCR") = Nz(VAR_ContaCrVenda, 1)
            DrNew("Virtual") = True
            Ds.Tables("Receber").Rows.Add(DrNew)

        Next

        Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAReceber)
        DAReceber.Update(Ds, "Receber")

        System.Threading.Thread.Sleep(1000)
        EncheListaReceber()

    End Sub

    Public Sub EncheListaReceber()
        If Me.PedidoSequencia.Text = "" Then Exit Sub

        JaFoiGeradoReceber = False
        MyLista1.Items.Clear()

        Dim CNNListaReceber As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNNListaReceber.Open()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        With Cmd
            .Connection = CNNListaReceber
            .CommandTimeout = 0
            .CommandText = "SELECT  * FROM Receber WHERE Receber.Documento <> '" & Me.PedidoSequencia.Text & "-AVISTA' And Receber.Documento <> 'CHEQUE' AND Receber.PedidoProdutos = " & Me.PedidoSequencia.Text & " AND Receber.OriginalParcial = 'O' ORDER BY Receber.Vencimento"
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            SomaDosParcelamentos = 0

            Dim Zebrar As Boolean = True

            While DataReader.Read
                If Not IsDBNull(DataReader.Item("Id")) Then
                    Dim AA As String = DataReader.Item("Id")
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("Documento") & "")
                    item1.SubItems.Add(FormatNumber(DataReader.Item("ValorDocumento"), 2))
                    item1.SubItems.Add(DataReader.Item("Vencimento"))
                    item1.SubItems.Add(DataReader.Item("LocalPgto") & "")
                    item1.SubItems.Add(DataReader.Item("CodCliente") & "")


                    MyLista1.Items.AddRange(New ListViewItem() {item1})

                    SomaDosParcelamentos += CDbl(DataReader.Item("ValorDocumento"))

                    If Zebrar = True Then
                        MyLista1.Items.Item(MyLista1.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    Else
                        MyLista1.Items.Item(MyLista1.Items.Count() - 1).BackColor = Color.MediumOrchid
                        Zebrar = True
                    End If
                    JaFoiGeradoReceber = True
                End If
            End While
            Me.TotalParcelamento.Text = FormatCurrency(SomaDosParcelamentos, 2)
            DataReader.Close()
            CNNListaReceber.Close()
            Me.MyLista1.Refresh()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                CNNListaReceber.Close()
                Exit Sub
            End If
        End Try
    End Sub

    Private Sub VlrDescProduto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles VlrDescProduto.Leave
        If Me.VlrDescProduto.Text = "" Then Me.VlrDescProduto.Text = FormatCurrency(0, 2)
        If Me.PercDesconto.Text = "" Then Me.PercDesconto.Text = FormatNumber(0, 3)
        If DescontoEmLinha = True Then
            Me.PercDesconto.Text = FormatNumber(0, 3)
            Me.VlrDescProduto.Text = FormatCurrency(SomaDesconto, 2)
            Me.TotalPedido.Text = FormatCurrency(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.ValorIpiPedido.Text)) - NzZero(Me.VlrDescProduto.Text))
            Me.TPedido.Text = FormatCurrency(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.ValorIpiPedido.Text)) - NzZero(Me.VlrDescProduto.Text))
        Else
            If Me.VlrDescProduto.Text <> 0 Then Me.PercDesconto.Text = FormatNumber(CDbl(NzZero(Me.VlrDescProduto.Text)) / (CDbl(NzZero(Me.ValorProduto.Text))) * 100, 3)
            Me.TotalPedido.Text = FormatCurrency(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.ValorIpiPedido.Text)) - CDbl(NzZero(Me.VlrDescProduto.Text)), 2)
            Me.TPedido.Text = FormatCurrency(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.ValorIpiPedido.Text)) - CDbl(NzZero(Me.VlrDescProduto.Text)), 2)
        End If

    End Sub

    Private Sub btGerarParcelas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGerarParcelas.Click

        If UsarLimite.Checked = True Then
            VerDebitoCliente()
            Me.SaldoLimiteCredito.Text = FormatNumber(NzZero(Me.LimiteCredito.Text) - NzZero(Me.EmDebito.Text), 2)

            Dim PercentualGasto As Double = (NzZero(Me.SaldoLimiteCredito.Text) / NzZero(Me.LimiteCredito.Text)) * 100

            If PercentualGasto > 70 Then Me.SaldoLimiteCredito.ForeColor = Color.Green
            If PercentualGasto < 70 And PercentualGasto > 35 Then Me.SaldoLimiteCredito.ForeColor = Color.Blue
            If PercentualGasto < 35 Then Me.SaldoLimiteCredito.ForeColor = Color.Red

            If FormatNumber(Me.SaldoLimiteCredito.Text, 2) <= FormatNumber(0, 2) Then
                MessageBox.Show("Este cliente esta com limite de compra insuficiente para uma operação.", "Validador de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.CódigoCliente.Clear()
                Me.NomeCliente.Clear()
                Me.CpfCgc.Clear()
                Me.Insc.Clear()
                Me.Endereço.Clear()
                Me.Cidade.Clear()
                Me.Estado.Clear()
                Me.Cep.Clear()
                Me.UsarLimite.Checked = False
                Me.ClienteBloqueado.Checked = False
                Me.LimiteCredito.Text = FormatNumber(0, 2)
                Me.EmDebito.Text = FormatNumber(0, 2)
                Me.SaldoLimiteCredito.Text = FormatNumber(0, 2)
                Me.CódigoCliente.Focus()
            End If

        Else
            Me.SaldoLimiteCredito.Text = FormatNumber(NzZero(0), 2)
        End If


        If Me.ValorAFaturar.Text = 0 Then
            Exit Sub
        End If

        If VarTemEntrada = True And NzZero(Me.ValorAVista.Text) = 0 Then
            MessageBox.Show("Esta condição de Pagamento necessita de uma entrada, favor verificar...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ValorAVista.Focus()
            Exit Sub
        End If

        If Me.TpVenda.Text = "" Then
            MsgBox("O usuário deve informar qual o tipo de venda.", 64, "Validação de Dados")
            Me.TpVenda.Focus()
            Exit Sub
        End If

        If Me.Confirmado.Checked = True Then
            MsgBox("Este Pedido/Venda já foi confirmado não pode ser alterado as parcelas", 64, "Validação de Dados")
            Exit Sub
        End If

        If Me.CódigoFuncionário.Text = "" Then
            MsgBox("O usuário deve informar qual o vendedor.", 64, "Validação de Dados")
            Me.CódigoFuncionário.Focus()
            Exit Sub
        End If

        If JaFoiGeradoReceber = True Then
            MsgBox("Para este pedido o parcelamento ja foi gerado. Verifique...", 64, "Validação de Dados")
            Me.DiasParcelamento.Focus()
            Exit Sub
        End If

        Dim TpedidoVAR As Double = Me.TotalPedido.Text
        Dim Tconfer As Double = Nz(CDbl(Me.ValorAFaturar.Text), 3) + Nz(CDbl(Me.ValorAVista.Text), 3) + Nz(CDbl(Me.ValorOutros.Text), 3)
        If TpedidoVAR <> FormatNumber(Tconfer, 2) Then
            MsgBox("Os Valores de faturamento não batem com o total do pedido, passe por todos os campos ou contacte o Administrador.", 64, "Validação de Dados")
            Exit Sub
        End If

        If Me.ValorAFaturar.Text <> 0 Then
            If Me.DiasParcelamento.Text = "" Then
                MsgBox("O usuário deve criar o parcelamento para o valor a ser faturado.", 64, "Validação de Dados")
                Me.DiasParcelamento.Focus()
                Exit Sub
            End If
        End If

        If Me.Confirmado.Checked = True Then
            MsgBox("Este Pedido/Venda já foi confirmado não pode ser alterado.", 64, "Validação de Dados")
            Exit Sub
        End If

        If Me.ValorIpiPedido.Text = "" Then Me.ValorIpiPedido.Text = FormatCurrency(SomaIpi, 2)
        If Me.VlrDescProduto.Text = "" Then Me.VlrDescProduto.Text = FormatCurrency(0, 2)
        If Me.ValorProduto.Text = "" Then Me.ValorProduto.Text = FormatCurrency(SomaTotalProdutos, 2)

        'If DescontoEmLinha = True Then
        '    Me.VlrDescProduto.Text = FormatCurrency(SomaDesconto, 2)
        '    Me.TotalPedido.Text = FormatCurrency(CDbl(Me.ValorProduto.Text) + CDbl(Me.ValorIpiPedido.Text))
        'Else
        '    Me.TotalPedido.Text = FormatCurrency(CDbl(Me.ValorProduto.Text) + CDbl(Me.ValorIpiPedido.Text) - CDbl(Me.VlrDescProduto.Text), 2)
        'End If


        If Me.CódigoFuncionário.Text = "" Then
            MsgBox("O usuário deve selecionar um vendedor para o Pedido.", 64, "Validação de Dados")
            Me.CódigoFuncionário.Focus()
            Exit Sub
        ElseIf Me.ValorAVista.Text = "" Then
            Me.ValorAVista.Text = FormatCurrency(0, 2)
        ElseIf Me.ValorOutros.Text = "" Then
            Me.ValorOutros.Text = FormatCurrency(0, 2)
        ElseIf Me.ValorAFaturar.Text = "" Then
            Me.ValorAFaturar.Text = FormatCurrency(0, 2)
        ElseIf Me.Propriedade.Text = "" Then
            Me.Propriedade.Text = 0
        ElseIf Me.Propriedade.Text = "" Then
            Me.Propriedade.Text = 0
        End If

        If Me.CódigoFuncionário.Text = 0 Then
            MsgBox("O usuário deve selecionar um vendedor para o Pedido.", 64, "Validação de Dados")
            Me.CódigoFuncionário.Focus()
            Exit Sub
        End If

        If Me.ValorAFaturar.Text <> 0 Then
            If Me.DiasParcelamento.Text = "" Then
                MsgBox("O usuário deve criar o parcelamento para o valor a ser faturado.", 64, "Validação de Dados")
                Me.DiasParcelamento.Focus()
                Exit Sub
            End If
        End If

        If Me.TotalPropostoPedido.Text = "" Then
            Me.TotalPropostoPedido.Text = FormatNumber(Me.TPedido.Text, 2)
        End If

        'Fim da Area destinada para as validacoes
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        If Operation = UPD Then

            Dim Sql As String = "Update Pedido  set CódigoCliente = @1, Propriedade = @2, DataPedido = @3, ObsCab = @4, ObsRod = @5, Empresa = @6, ValorProduto = @7, TotalPedido = @8, ValorAVista = @9, ValorOutros = @10, ValorAFaturar = @11, VlrDescProduto = @12, ValorIpiPedido = @13, DiasParcelamento = @14, CódigoFuncionário = @15, PedidoTipo = @16, TipoEntrega = @17, TotalPropostoPedido = @18, MediaDesconto = @19 Where PedidoSequencia = " & Me.PedidoSequencia.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CódigoCliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Propriedade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataPedido.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ObsCab.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.ObsRod.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.ValorProduto.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.TotalPedido.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.ValorAVista.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.ValorOutros.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.ValorAFaturar.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.VlrDescProduto.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.ValorIpiPedido.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.DiasParcelamento.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.CódigoFuncionário.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.TpVenda.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.TipoEntrega.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@18", NzZero(Me.TotalPropostoPedido.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@19", NzZero(Me.MediaDesconto.Text)))

            Try
                cmd.ExecuteNonQuery()
                Operation = UPD
                GerarParcelamentos()
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
        End If

    End Sub

    Private Sub ExcluirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirToolStripMenuItem.Click
        If Me.Confirmado.Checked = True Then
            MsgBox("Este pedido já foi confirmado, não pode ser alterado.", 64, "Validação de Dados")
            Exit Sub
        End If

        RetornoProcura = ""
        Dim I As Integer = 0

        For I = 0 To MyLista1.Items.Count - 1
            If MyLista1.Items(I).Selected = True Then RetornoProcura = (MyLista1.Items(I).Text.Substring(0))
        Next

        If RetornoProcura = "" Then
            MsgBox("O usuário deve selecionar um item da lista.", 64, "Validação de Dados")
            Exit Sub
        End If

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "Delete * from Receber where Id = " & RetornoProcura
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader

        DR.Close()
        Cnn.Close()
        EncheListaReceber()
        Me.Salvar.Focus()

    End Sub

    Private Sub Confirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Confirmar.Click

        If Operation = INS Then
            MessageBox.Show("Este pedido ainda não foi adicionado os dados, verifique.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Len(CaixaAtivo) <> 4 Then
            MessageBox.Show("O usuario deve selecionar um caixa antes de Confirmar o Pedido. Verifique", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If MsgBox("Deseja Ativar o caixa agora", 36, "Validação de Dados") = 6 Then
                TRVDados(UserAtivo, "CaixaAtivarDesativar")
                If Ina = True Then
                    MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
                    Exit Sub
                Else
                    My.Forms.CaixaAtivarDesativar.ShowDialog()
                    Confirmar_Click(sender, e)
                End If
            End If
            Exit Sub
        End If


        If NzZero(Me.TotalParcelamento.Text) = 0 Then FormatNumber(0, 2)

        If Me.PedidoSequencia.Text = "" Then
            MsgBox("Não foi informado nenhum Pedido/Venda.", 64, "Validação de Dados")
            Exit Sub
        End If

        If Me.Confirmado.Checked = True Then
            MsgBox("Este Pedido/Venda já foi confirmado.", 64, "Validação de Dados")
            Exit Sub
        End If

        If Me.DataPedido.Text = "" Then
            MsgBox("A data do Pedido não foi informada, favor verificar...", 64, "Validação de Dados")
            Exit Sub
        End If

        If Me.TpVenda.Text = "" Then
            MsgBox("O usuário deve informar qual o tipo de venda.", 64, "Validação de Dados")
            Me.TpVenda.Focus()
            Exit Sub
        End If


        'Inicio dos teste se diferente de consignaçao
        If Me.TpVenda.Text <> "CONSIGNAÇÃO" Then

            If NzZero(Me.CódigoFuncionário.Text) = 0 Then
                MsgBox("O usuário deve selecionar um Funcionário para o Pedido.", 64, "Validação de Dados")
                Me.CódigoFuncionário.Focus()
                Exit Sub
            End If

            If Me.ValorAVista.Text = "" Then
                MsgBox("o Valor a vista não pode ser vazio, se não há faturamento a Vista coloque zero.", 64, "Validação de Dados")
                Me.ValorAVista.Focus()
                Exit Sub
            ElseIf Me.ValorOutros.Text = "" Then
                MsgBox("o Valor Ch/Outros não pode ser vazio, se não há faturamento Ch/Outros coloque zero.", 64, "Validação de Dados")
                Me.ValorOutros.Focus()
                Exit Sub
            ElseIf Me.ValorAFaturar.Text = "" Then
                MsgBox("o Valor a faturar não pode ser vazio, se não há faturamento a Prazo coloque zero.", 64, "Validação de Dados")
                Me.ValorAFaturar.Focus()
                Exit Sub
            End If

            If Me.ValorAFaturar.Text <> Me.TotalParcelamento.Text Then
                MsgBox("Verifique o total de parcelamento, pois esta diferente do valor a faturar", 64, "Validação de Dados")
                Exit Sub
            End If

            If Me.UsarLimite.Checked = True Then
                Dim VlrFaturar As Double = FormatNumber(Me.ValorAFaturar.Text, 2)
                Dim VlrLimite As Double = FormatNumber(Me.LimiteCredito.Text, 2)
                If VlrFaturar > VlrLimite Then
                    MsgBox("Este Cliente esta sendo controlado por limite de Crédito, Limite ultrapassado, Verifique.", 64, "Validação de Dados")
                    Exit Sub
                End If
            End If


            Dim VlrPedido As Double = FormatNumber(Me.TPedido.Text, 2)
            Dim VlrGeral As Double = FormatNumber(CDbl(Me.ValorAVista.Text) + CDbl(Me.ValorOutros.Text) + CDbl(Me.ValorAFaturar.Text), 2)

            If VlrPedido <> VlrGeral Then
                MsgBox("Verifique...O valor do pedido esta diferente dos valores de faturamento A Vista/Outros/Parcelado.", 64, "Validação de Dados")
                Exit Sub
            End If


            'Verifica se a parcela foi gerada para o cliente correto
            RetornoProcura = ""
            Dim I As Integer = 0

            For I = 0 To MyLista1.Items.Count - 1
                RetornoProcura = MyLista1.Items(I).SubItems(5).Text.Substring(0)
                If Me.CódigoCliente.Text <> RetornoProcura Then
                    MsgBox("O Cliente que foi gerado parcela esta diferente do cliente do Pedido, favor verificar.", 64, "Validação de Dados")
                    Exit Sub
                End If
            Next
            'fim

        End If
        'fim

        If NzZero(Me.TotalPropostoPedido.Text) = 0 Then
            Me.TotalPropostoPedido.Text = FormatNumber(Me.TPedido.Text, 2)
        End If

        If CDbl(NzZero(Me.TotalPropostoPedido.Text)) < CDbl(NzZero(Me.TPedido.Text)) Then
            Me.TotalPropostoPedido.Text = FormatNumber(Me.TPedido.Text, 2)
        End If

        'Salvar dados do Pedido
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Update Pedido  Set CódigoCliente = @1, Propriedade = @2, DataPedido = @3, ObsCab = @4, ObsRod = @5, Empresa = @6, ValorProduto = @7, TotalPedido = @8, ValorAVista = @9, ValorOutros = @10, ValorAFaturar = @11, VlrDescProduto = @12, ValorIpiPedido = @13, DiasParcelamento = @14, CódigoFuncionário = @15, PedidoTipo = @16, StatusAndamentos = @17, FormaPgto = @18, TipoEntrega = @19, PercDesconto = @20, ValorServicos = @21, TotalPropostoPedido = @22, MediaDesconto = @23 Where Pedido.PedidoSequencia = " & Me.PedidoSequencia.Text
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CódigoCliente.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Propriedade.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataPedido.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ObsCab.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.ObsRod.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@6", CodEmpresa))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@7", NzZero(Me.ValorProduto.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@8", NzZero(Me.TotalPedido.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzZero(Me.ValorAVista.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@10", NzZero(Me.ValorOutros.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@11", NzZero(Me.ValorAFaturar.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@12", NzZero(Me.VlrDescProduto.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@13", NzZero(Me.ValorIpiPedido.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@14", NzZero(Me.DiasParcelamento.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.CódigoFuncionário.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.TpVenda.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.StatusAndamentos.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Nz(Me.ParcelamentoFixo.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@19", Nz(Me.TipoEntrega.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@20", NzZero(Me.PercDesconto.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@21", NzZero(Me.ValorServicos.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@22", NzZero(Me.TotalPropostoPedido.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@23", NzZero(Me.MediaDesconto.Text)))



        Try
            cmd.ExecuteNonQuery()
            CNN.Close()
            Operation = UPD
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try
        '

        If Me.TpVenda.Text <> "CONSIGNAÇÃO" Then
            My.Forms.PedidoVendaConfirmar.ShowDialog()
        Else
            My.Forms.PedidoVendaConfirmarOutros.ShowDialog()
        End If

    End Sub

    Private Sub MyLista1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista1.DoubleClick
        If Me.Confirmado.Checked = True Then
            MsgBox("Este Pedido/Venda já foi confirmado não pode ser alterado as parcelas", 64, "Validação de Dados")
            Exit Sub
        End If

        RetornoProcura = ""
        Dim I As Integer = 0

        For I = 0 To MyLista1.Items.Count - 1
            If MyLista1.Items(I).Selected = True Then RetornoProcura = (MyLista1.Items(I).Text.Substring(0))
        Next

        If RetornoProcura = "" Then
            Exit Sub
        End If

        My.Forms.PedidoVendaEditReceber.ShowDialog()
        EncheListaReceber()
    End Sub

    Private Sub Propriedade_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Propriedade.KeyDown

        If e.KeyCode = Keys.F5 Then
            If Operation = VAZ Then
                MessageBox.Show("O usuário não inicializou um Pedido para procurar o cliente, Verifique", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Me.PropriedadeDesc.Clear()
            Me.PropriedadeEstado.Clear()
            Me.PropriedadeIncrição.Clear()

            My.Forms.ProcuraPropriedades.ShowDialog()
            AchaPropriedade()
            Me.Propriedade.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            Me.TabPedido.SelectedTab = Me.TabItemPedido
            Me.VlrDescProduto.Focus()
        End If

    End Sub

    Private Sub AchaPropriedade()
        If Me.Propriedade.Text = "" Then
            Me.PropriedadeDesc.Clear()
            Me.PropriedadeEstado.Clear()
            Me.PropriedadeIncrição.Clear()
            Exit Sub
        Else
            Dim Cmd As New OleDb.OleDbCommand()
            Dim DR As OleDb.OleDbDataReader

            With Cmd
                .Connection = CNN
                .CommandTimeout = 0
                .CommandText = "Select * from Propriedades Where Id = " & Me.Propriedade.Text
                .CommandType = CommandType.Text
            End With

            Try
                DR = Cmd.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    Me.PropriedadeDesc.Text = DR.Item("NomePropriedade") & ""
                    Me.PropriedadeEstado.Text = DR.Item("Estado") & ""
                    Me.PropriedadeIncrição.Text = DR.Item("Inscricao") & ""
                Else
                    Me.PropriedadeDesc.Clear()
                    Me.PropriedadeEstado.Clear()
                    Me.PropriedadeIncrição.Clear()
                End If
                DR.Close()

            Catch Merror As System.Exception
                MsgBox(Merror.ToString)
            End Try
        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        MsgBox("Selecione um item da Lista com duplo Click para entrar editando o item.", 64, "Validação de Dados")
        Exit Sub
    End Sub

    Private Sub CódigoFuncionário_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CódigoFuncionário.KeyDown

        If e.KeyCode = Keys.F5 Then
            If Operation = VAZ Then
                MessageBox.Show("O usuário não inicializou um Pedido para procurar um vendedor, Verifique", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If Operation = UPD Then
                My.Forms.PedidoVendaFindVendedores.ShowDialog()
                Me.CódigoFuncionário.Focus()
                AchaFuncionario()
            End If
        End If


    End Sub

    Private Sub CódigoFuncionário_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CódigoFuncionário.Leave
        If String.CompareOrdinal(Me.CódigoFuncionário.Text, Me.CódigoFuncionário.TextoAntigo) Then
            AchaFuncionario()
        End If
    End Sub

    Private Sub AchaFuncionario()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader
        If CNN.State = ConnectionState.Closed Then
            CNN.Open()
        End If
        With Cmd
            .Connection = CNN
            .CommandTimeout = 0
            .CommandText = "Select * From Funcionários Where CódigoFuncionário = " & Me.CódigoFuncionário.Text
            .CommandType = CommandType.Text
        End With

        Try
            DR = Cmd.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                If DR.Item("AdicionarEmVendas") = True Then
                    Me.FuncionarioDesc.Text = DR.Item("Nome") & ""
                Else
                    MessageBox.Show("Este funcionário não pode ser usado como vendedor, favor informar outro", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.CódigoFuncionário.Clear()
                    Me.FuncionarioDesc.Clear()
                    Me.CódigoFuncionário.Focus()
                    Exit Sub
                End If
            End If
            DR.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
        End Try

    End Sub





    Private Sub TotalPedido_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TotalPedido.Validated
        If Me.VlrDescProduto.Text = "" Then Me.VlrDescProduto.Text = FormatCurrency(CDbl(0), 2)

        If DescontoEmLinha = False Then
            Me.VlrDescProduto.Text = FormatCurrency((CDbl(Me.ValorProduto.Text) + CDbl(Me.ValorIpiPedido.Text) - CDbl(Me.TotalPedido.Text)), 2)
        End If

    End Sub

    Private Sub Propriedade_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Propriedade.Validated
        If String.CompareOrdinal(Me.Propriedade.Text, Me.Propriedade.TextoAntigo) Then
            AchaPropriedade()
            Me.PropriedadeEstado.Focus()
        End If
    End Sub


#Region "Tela de Procura"

    Private Sub VoltarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoltarPedido.Click
        Me.PainelProcuraPedido.Expanded = False
    End Sub

    Private Sub TxtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProcura.Leave
        EncheGrid()
    End Sub

    Private Sub PainelProcuraPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PainelProcuraPedido.Click
        If Me.Pedido.Checked = False And Me.Cliente.Checked = False Then
            Me.Cliente.Checked = True
            Me.TxtProcura.Focus()
        End If
        Me.PainelProcuraPedido.Expanded = True
        Me.TotalParcelamento.Clear()
        RetornoProcura = ""
    End Sub

    Private Sub PainelProcuraPedido_ExpandedChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.ExpandedChangeEventArgs) Handles PainelProcuraPedido.ExpandedChanged
        If Me.PainelProcuraPedido.Expanded = True Then
            If Me.Pedido.Checked = False And Me.Cliente.Checked = False Then
                Me.Cliente.Checked = True
                Me.TxtProcura.Focus()
            End If
            Me.PainelProcuraPedido.Expanded = True
            If Me.Confirmado.Checked = False Then
                Me.ConfImg.Visible = False
            Else
                Me.ConfImg.Visible = True
            End If
            Me.TotalParcelamento.Clear()
            RetornoProcura = ""
        End If
    End Sub

#End Region

    Private Sub Clientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clientes.Click
        My.Forms.Clientes.ShowDialog()
    End Sub


    Private Sub Pedido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pedido.CheckedChanged, Cliente.CheckedChanged, controle.CheckedChanged, Data.CheckedChanged
        opt = DirectCast(sender, RadioButton).Name
        If opt = "Data" Then
            Me.TxtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Else
            Me.TxtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        End If
        Me.TxtProcura.Focus()
    End Sub


    Private Sub btNovoItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovoItem.Click
        If JaFoiGeradoReceber = True Then
            MsgBox("Neste pedido não pode ser incluido produto, pois ja foi gerado o contas a receber, exclua o contas receber para incluir novos produtos.", 64, "Validação de Dados")
            Exit Sub
        End If

        If JaFoiGeradoReceber = True Then
            MsgBox("Para este pedido o parcelamento ja foi gerado. Verifique...", 64, "Validação de Dados")
            Exit Sub
        End If



        If Me.Confirmado.Checked = True Then
            MsgBox("Este Pedido/Venda já foi confirmado não pode ser alterado.", 64, "Validação de Dados")
            Exit Sub
        End If

        If Me.PedidoSequencia.Text = "" Then
            MsgBox("O usuário deve antes de lançar os itens inicializar um pedido.", 64, "Validação de Dados")
            Me.PedidoSequencia.Focus()
            Exit Sub
        ElseIf Me.CódigoCliente.Text = "" Then
            MsgBox("O usuário deve antes selecionar um cliente para lançar os itens.", 64, "Validação de Dados")
            Me.CódigoCliente.Focus()
            Exit Sub
        End If

        EstaNosItens = True

        Me.PedidoSequencia.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CódigoCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.NomeCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CpfCgc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Insc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Endereço.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Cidade.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Cep.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Estado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Propriedade.Enabled = False
        Me.PropriedadeEstado.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.PropriedadeIncrição.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DataPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim

        Me.MyLista.Enabled = True
        CNN.Close()

        My.Forms.PedidoAddItem.OperationItens = INS
        My.Forms.PedidoAddItem.ShowDialog()
        Me.TabPedido.SelectedTab = Me.TabParcelamento
        Me.TotalPropostoPedido.Focus()
        CNN.Open()

    End Sub


    Private Sub IrParaOParcelamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IrParaOParcelamentoToolStripMenuItem.Click
        Me.TabPedido.SelectedTab = Me.TabParcelamento
        Me.ValorProduto.Focus()
    End Sub

    Private Sub btClienteFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClienteFind.Click
        If Operation = VAZ Then
            MessageBox.Show("O usuário não inicializou um Pedido para procurar o cliente, Verifique", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If Operation = UPD Then

            Me.NomeCliente.Clear()
            Me.CpfCgc.Clear()
            Me.Insc.Clear()
            Me.Endereço.Clear()
            Me.Cidade.Clear()
            Me.Estado.Clear()
            Me.Cep.Clear()
            Me.UsarLimite.Checked = False
            Me.ClienteBloqueado.Checked = False
            Me.LimiteCredito.Text = FormatNumber(0, 2)

            My.Forms.ClientesProcura.ShowDialog()
            LocalizaDadosCliente()
            Me.CódigoCliente.Focus()
        End If
    End Sub


    Public Sub LocalizaDadosCliente()

        If Me.CódigoCliente.Text = "" Then
            Exit Sub
        End If
        Me.SaldoLimiteCredito.ForeColor = Color.Black

        Dim CnnFind As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CnnFind.Open()

        Dim Sql As String = "Select * from Clientes where Codigo = " & Me.CódigoCliente.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CnnFind)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then

            If DR.Item("Bloqueado") = True Then
                MessageBox.Show("Este cliente esta bloqueado, Favor verificar", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.CódigoCliente.Clear()
                Me.NomeCliente.Clear()
                Me.CpfCgc.Clear()
                Me.Insc.Clear()
                Me.Endereço.Clear()
                Me.Cidade.Clear()
                Me.Estado.Clear()
                Me.Cep.Clear()
                Me.UsarLimite.Checked = False
                Me.ClienteBloqueado.Checked = False
                Me.LimiteCredito.Text = FormatNumber(0, 2)
                Me.EmDebito.Text = FormatNumber(0, 2)
                Me.SaldoLimiteCredito.Text = FormatNumber(0, 2)
                Me.CódigoCliente.Focus()
                Exit Sub
            End If
            If IsDBNull(DR.Item("tpComercio")) Then
                MessageBox.Show("Este cliente esta sem o tipo de Comércio, Favor verificar", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.CódigoCliente.Clear()
                Me.NomeCliente.Clear()
                Me.CpfCgc.Clear()
                Me.Insc.Clear()
                Me.Endereço.Clear()
                Me.Cidade.Clear()
                Me.Estado.Clear()
                Me.Cep.Clear()
                Me.UsarLimite.Checked = False
                Me.ClienteBloqueado.Checked = False
                Me.LimiteCredito.Text = FormatNumber(0, 2)
                Me.EmDebito.Text = FormatNumber(0, 2)
                Me.SaldoLimiteCredito.Text = FormatNumber(0, 2)
                Me.CódigoCliente.Focus()
                Exit Sub
            End If

            Me.NomeCliente.Text = DR.Item("Nome") & ""
            Me.CpfCgc.Text = DR.Item("CpfCgc") & ""
            Me.Insc.Text = DR.Item("Insc") & ""
            Me.tpComercio.Text = DR.Item("tpComercio") & ""
            Me.Endereço.Text = DR.Item("Endereço") & ""
            Me.Cidade.Text = DR.Item("Cidade") & ""
            Me.Estado.Text = DR.Item("Estado") & ""
            Me.Cep.Text = DR.Item("Cep") & ""
            Me.UsarLimite.Checked = DR.Item("UsarLimite")
            Me.ClienteBloqueado.Checked = DR.Item("Bloqueado")
            Me.LimiteCredito.Text = FormatNumber(Nz(DR.Item("LimiteMensal"), 3), 2)
            If Me.CódigoFuncionário.Text = "" Then
                Me.CódigoFuncionário.Text = DR.Item("Vendedor") & ""
                AchaFuncionario()
            End If
        Else
            MessageBox.Show("Cliente não localizado, Verifique.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.CódigoCliente.Clear()
            Me.NomeCliente.Clear()
            Me.CpfCgc.Clear()
            Me.Insc.Clear()
            Me.Endereço.Clear()
            Me.Cidade.Clear()
            Me.Estado.Clear()
            Me.Cep.Clear()
            Me.UsarLimite.Checked = False
            Me.ClienteBloqueado.Checked = False
            Me.LimiteCredito.Text = FormatNumber(0, 2)
            Me.EmDebito.Text = FormatNumber(0, 2)
            Me.SaldoLimiteCredito.Text = FormatNumber(0, 2)
            Me.CódigoCliente.Focus()
        End If

        DR.Close()
        CnnFind.Close()

        If UsarLimite.Checked = True Then
            VerDebitoCliente()
            Me.SaldoLimiteCredito.Text = FormatNumber(NzZero(Me.LimiteCredito.Text) - NzZero(Me.EmDebito.Text), 2)

            Dim PercentualGasto As Double = (NzZero(Me.SaldoLimiteCredito.Text) / NzZero(Me.LimiteCredito.Text)) * 100

            If PercentualGasto > 70 Then Me.SaldoLimiteCredito.ForeColor = Color.Green
            If PercentualGasto < 70 And PercentualGasto > 35 Then Me.SaldoLimiteCredito.ForeColor = Color.Blue
            If PercentualGasto < 35 Then Me.SaldoLimiteCredito.ForeColor = Color.Red

            If FormatNumber(Me.SaldoLimiteCredito.Text, 2) <= FormatNumber(0, 2) Then
                MessageBox.Show("Este cliente esta com limite de compra insuficiente para uma operação.", "Validador de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.CódigoCliente.Clear()
                Me.NomeCliente.Clear()
                Me.CpfCgc.Clear()
                Me.Insc.Clear()
                Me.Endereço.Clear()
                Me.Cidade.Clear()
                Me.Estado.Clear()
                Me.Cep.Clear()
                Me.UsarLimite.Checked = False
                Me.ClienteBloqueado.Checked = False
                Me.LimiteCredito.Text = FormatNumber(0, 2)
                Me.EmDebito.Text = FormatNumber(0, 2)
                Me.SaldoLimiteCredito.Text = FormatNumber(0, 2)
                Me.CódigoCliente.Focus()
            End If

        Else
            Me.SaldoLimiteCredito.Text = FormatNumber(NzZero(0), 2)
        End If
    End Sub

    Private Sub VerificaSaldoCreditoAtualizado()


        If Me.CódigoCliente.Text = "" Then
            Exit Sub
        End If
        Me.SaldoLimiteCredito.ForeColor = Color.Black

        Dim CnnFind As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CnnFind.Open()

        Dim Sql As String = "Select * from Clientes where Codigo = " & Me.CódigoCliente.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CnnFind)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.UsarLimite.Checked = DR.Item("UsarLimite")
            Me.LimiteCredito.Text = FormatNumber(NzZero(DR.Item("LimiteMensal")), 2)
            If DR.Item("Bloqueado") = True Then
                MessageBox.Show("Este cliente esta bloqueado, Favor verificar", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.CódigoCliente.Clear()
                Me.NomeCliente.Clear()
                Me.CpfCgc.Clear()
                Me.Insc.Clear()
                Me.Endereço.Clear()
                Me.Cidade.Clear()
                Me.Estado.Clear()
                Me.Cep.Clear()
                Me.UsarLimite.Checked = False
                Me.ClienteBloqueado.Checked = False
                Me.LimiteCredito.Text = FormatNumber(0, 2)
                Me.EmDebito.Text = FormatNumber(0, 2)
                Me.SaldoLimiteCredito.Text = FormatNumber(0, 2)
                Me.CódigoCliente.Focus()
                Exit Sub
            End If

        Else
            MessageBox.Show("Cliente não localizado, Verifique.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.CódigoCliente.Clear()
            Me.NomeCliente.Clear()
            Me.CpfCgc.Clear()
            Me.Insc.Clear()
            Me.Endereço.Clear()
            Me.Cidade.Clear()
            Me.Estado.Clear()
            Me.Cep.Clear()
            Me.UsarLimite.Checked = False
            Me.ClienteBloqueado.Checked = False
            Me.LimiteCredito.Text = FormatNumber(0, 2)
            Me.EmDebito.Text = FormatNumber(0, 2)
            Me.SaldoLimiteCredito.Text = FormatNumber(0, 2)
            Me.CódigoCliente.Focus()
        End If

        DR.Close()
        CnnFind.Close()

        If UsarLimite.Checked = True Then
            VerDebitoCliente()
            Me.SaldoLimiteCredito.Text = FormatNumber(NzZero(Me.LimiteCredito.Text) - NzZero(Me.EmDebito.Text), 2)

            Dim PercentualGasto As Double = (NzZero(Me.SaldoLimiteCredito.Text) / NzZero(Me.LimiteCredito.Text)) * 100

            If PercentualGasto > 70 Then Me.SaldoLimiteCredito.ForeColor = Color.Green
            If PercentualGasto < 70 And PercentualGasto > 35 Then Me.SaldoLimiteCredito.ForeColor = Color.Blue
            If PercentualGasto < 35 Then Me.SaldoLimiteCredito.ForeColor = Color.Red

            If FormatNumber(Me.SaldoLimiteCredito.Text, 2) <= FormatNumber(0, 2) Then
                MessageBox.Show("Este cliente esta com limite de compra insuficiente para uma operação.", "Validador de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.CódigoCliente.Clear()
                Me.NomeCliente.Clear()
                Me.CpfCgc.Clear()
                Me.Insc.Clear()
                Me.Endereço.Clear()
                Me.Cidade.Clear()
                Me.Estado.Clear()
                Me.Cep.Clear()
                Me.UsarLimite.Checked = False
                Me.ClienteBloqueado.Checked = False
                Me.LimiteCredito.Text = FormatNumber(0, 2)
                Me.EmDebito.Text = FormatNumber(0, 2)
                Me.SaldoLimiteCredito.Text = FormatNumber(0, 2)
                Me.CódigoCliente.Focus()
            End If

        Else
            Me.SaldoLimiteCredito.Text = FormatNumber(NzZero(0), 2)
        End If

    End Sub

    Private Sub VerDebitoCliente()
        If Me.CódigoCliente.Text = "" Then
            Exit Sub
        End If

        Dim CnnFind As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CnnFind.Open()

        Dim Sql As String = "SELECT Receber.CodCliente AS Cliente, Sum(Receber.ValorDocumento) AS Total FROM Receber WHERE (((Receber.Recebimento) Is Null) AND ((Receber.Baixado)=False) AND ((Receber.Empresa)=" & CodEmpresa & ")) GROUP BY Receber.CodCliente HAVING (((Receber.CodCliente)=" & Me.CódigoCliente.Text & ")); UNION SELECT ArquivoCheque.Cliente, Sum(ArquivoCheque.ValorCh) AS Total FROM ArquivoCheque WHERE (((ArquivoCheque.DataBaixa) Is Null) AND ((ArquivoCheque.Empresa)=" & CodEmpresa & ")) GROUP BY ArquivoCheque.Cliente HAVING (((ArquivoCheque.Cliente)=" & Me.CódigoCliente.Text & "));"
        Dim CMD As New OleDb.OleDbCommand(Sql, CnnFind)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        Dim VlrDebito As Double = 0

        While DR.Read
            VlrDebito += NzZero(DR.Item("Total"))
        End While

        Me.EmDebito.Text = FormatNumber(NzZero(VlrDebito), 2)

        DR.Close()
        CnnFind.Close()
    End Sub

    Private Sub CódigoCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CódigoCliente.KeyDown
        If Operation = VAZ Then
            MessageBox.Show("O usuário não inicializou um Pedido para procurar o cliente, Verifique", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If e.KeyCode = Keys.F5 Then
            If Operation = UPD Then

                Me.NomeCliente.Clear()
                Me.CpfCgc.Clear()
                Me.Insc.Clear()
                Me.Endereço.Clear()
                Me.Cidade.Clear()
                Me.Estado.Clear()
                Me.Cep.Clear()
                Me.UsarLimite.Checked = False
                Me.ClienteBloqueado.Checked = False
                Me.LimiteCredito.Text = FormatNumber(0, 2)

                My.Forms.ClientesProcura.ShowDialog()
                LocalizaDadosCliente()
                Me.CódigoCliente.Focus()
            End If
        End If

        If e.KeyCode = Keys.Enter Then
            If Me.PedidoSequencia.Text <> "" Then
                If Me.CódigoCliente.Text = "" Then
                    MessageBox.Show("O usuário deve informar o cliente para o pedido.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.CódigoCliente.Focus()
                    Exit Sub
                End If
            End If
        End If

    End Sub

    Private Sub TipoEntrega_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TipoEntrega.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim tab As DevComponents.DotNetBar.TabItem = Me.TabCliente
            Me.TabPedido.SelectedTab = tab


            'Me.CódigoCliente.Focus()
        End If
    End Sub

    Private Sub btPropriedadeFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPropriedadeFind.Click
        If Operation = VAZ Then
            MessageBox.Show("O usuário não inicializou um Pedido para procurar o cliente, Verifique", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Me.PropriedadeDesc.Clear()
        Me.PropriedadeEstado.Clear()
        Me.PropriedadeIncrição.Clear()

        My.Forms.ProcuraPropriedades.ShowDialog()
        AchaPropriedade()
        Me.Propriedade.Focus()
    End Sub

    Private Sub PropriedadeEstado_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PropriedadeEstado.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TabPedido.SelectedTab = Me.TabObs
        End If
    End Sub

   

    Private Sub btFindVendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindVendedor.Click
        If Operation = VAZ Then
            MessageBox.Show("O usuário não inicializou um Pedido para procurar um vendedor, Verifique", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Operation = UPD Then
            My.Forms.PedidoVendaFindVendedores.ShowDialog()
            Me.CódigoFuncionário.Focus()
            AchaFuncionario()
        End If

    End Sub

    Private Sub CódigoCliente_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CódigoCliente.Leave
        If String.CompareOrdinal(Me.CódigoCliente.Text, Me.CódigoCliente.TextoAntigo) Then
            LocalizaDadosCliente()
        End If
    End Sub

    
    Private Sub PedidoVenda_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F7 Then
            btNovoItem_Click(sender, e)
        End If
        If e.KeyCode = Keys.F8 Then
            Me.TabPedido.SelectedTab = Me.TabParcelamento
            Me.CódigoFuncionário.Focus()
        End If

        If Me.PainelProcuraPedido.Expanded = True Then

            Select Case e.KeyCode
                Case Keys.F2
                    Me.Pedido.Checked = True
                    Me.TxtProcura.Focus()
                Case Keys.F3
                    Me.Cliente.Checked = True
                    Me.TxtProcura.Focus()
                Case Keys.F4
                    Me.controle.Checked = True
                    Me.TxtProcura.Focus()
                Case Keys.F5
                    Me.Data.Checked = True
                    Me.TxtProcura.Focus()
                Case Keys.F6
                    Me.EmAberto.Checked = True
                    Me.TxtProcura.Focus()
                Case Keys.F7
                    Me.MostrarTodos.Checked = True
                    Me.TxtProcura.Focus()
            End Select

        End If


    End Sub

    Private Sub ParcelamentoFixo_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParcelamentoFixo.Validated
        If String.CompareOrdinal(Me.ParcelamentoFixo.Text, Me.ParcelamentoFixo.TextoAntigo) Then
            AchaFormaPgto()
        End If
    End Sub

  
    Private Sub TabParcelamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabParcelamento.Click
        Me.CódigoFuncionário.Focus()
    End Sub

    Private Sub btParcelamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btParcelamento.Click
        Me.TabPedido.SelectedTab = Me.TabParcelamento

        Me.TotalPropostoPedido.Focus()
    End Sub

    Private Sub ParcelamentoFixo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ParcelamentoFixo.KeyDown
        If e.KeyCode = Keys.F5 Then
            If Operation = UPD Then
                My.Forms.ProcuraFormaPgto.ShowDialog()
            End If
        End If

        If e.KeyCode = Keys.Enter Then
            If Me.ParcelamentoFixo.Text = "" Then
                Me.ParcelamentoFixo.Clear()
                Me.ParcelamentoFixoDesc.Clear()
                Me.DiasParcelamento.Clear()
            End If
        End If
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        If Me.Confirmado.Checked = False Then
            MessageBox.Show("O usuário não pode emitir Ordem de Entrega para pedido não Confirmado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.TipoEntrega.Text = "IMEDIATA" Then
            MessageBox.Show("A Entrega deste pedido está como IMEDIATA, não pode gerar Ordem de Entrega para este pedido.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.StatusAndamentos.Text = "FINALIZADO" Then
            MessageBox.Show("A Entrega deste pedido está como finalizado, não pode gerar nova ordem de entrega para este pedido.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        TRVDados(UserAtivo, "OrdemEntrega")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.OrdemEntrega.ShowDialog()
        End If
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        TRVDados(UserAtivo, "OrdemEntregaVisualizador")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.OrdemEntregaVisualizador.ShowDialog()
        End If
    End Sub


    Private Sub btFindParcelamentoFixo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindParcelamentoFixo.Click
        If Operation = UPD Then
            My.Forms.ProcuraFormaPgto.ShowDialog()
            AchaFormaPgto()
            'Me.CódigoFuncionário.Focus()
            Me.ParcelamentoFixo.Focus()
        End If
    End Sub

    Private Sub PercDesconto_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PercDesconto.Enter
        If DescontoEmLinha = False Then
            Me.PercDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.VlrDescProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.TotalPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Else
            Me.PercDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.VlrDescProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.TotalPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        End If
    End Sub


    Private Sub VlrDescProduto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VlrDescProduto.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TotalPedido.Focus()
        End If
    End Sub

    Private Sub PercDesconto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PercDesconto.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.VlrDescProduto.Focus()
        End If
    End Sub

    Private Sub PercDesconto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PercDesconto.Leave
        If DescontoEmLinha = False Then
            Me.VlrDescProduto.Text = FormatCurrency((CDbl(NzZero(Me.ValorProduto.Text))) * FormatNumber(CDbl(NzZero(Me.PercDesconto.Text)), 3) / 100, 2)
            Me.TotalPedido.Text = FormatCurrency(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.ValorIpiPedido.Text)) - CDbl(NzZero(Me.VlrDescProduto.Text)), 2)
            Me.TPedido.Text = FormatCurrency(CDbl(NzZero(Me.ValorProduto.Text)) + CDbl(NzZero(Me.ValorIpiPedido.Text)) - CDbl(NzZero(Me.VlrDescProduto.Text)), 2)
            Me.VlrDescProduto.Focus()
        End If
    End Sub

    Private Sub MostrarTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarTodos.CheckedChanged
        If Me.MostrarTodos.Checked = True Then
            EncheGrid()
        End If
    End Sub

    Private Sub Lista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellDoubleClick
        Dim vID As Integer
        vID = CInt(Me.Lista.CurrentRow.Cells("cPedido").Value)
        xLinha = Me.Lista.CurrentRow.Index
        RetornoProcura = vID

        If RetornoProcura = "" Then
            MsgBox("O usuário deve informar um iten da lista de procura.", 64, "Validação de Dados")
            Exit Sub
        Else
            LocalizaDadosPedido()
            EncheListaItens()
            EncheListaReceber()
            'ds.Tables(0).Clear()
            Me.PainelProcuraPedido.Expanded = False

            Me.PedidoSequencia.Focus()
            Operation = UPD
        End If


    End Sub

    Public Sub EncheGrid()


        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Dim DsProcura As New DataSet

        If Me.MostrarTodos.Checked = True Then
            Sql = "SELECT Pedido.PedidoSequencia, Pedido.Requisicao, Pedido.PedidoTipo, Funcionários.Nome AS NomeFunc, Clientes.Nome, Clientes.Cidade, Pedido.TotalPedido, Pedido.Empresa, Pedido.Inativo, Pedido.DataPedido, Pedido.Confirmado FROM (Pedido LEFT JOIN Clientes ON Pedido.CódigoCliente = Clientes.Codigo) LEFT JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário WHERE(((Pedido.Empresa) = " & CodEmpresa & ")) ORDER BY Pedido.PedidoSequencia DESC;"
        ElseIf Me.EmAberto.Checked = True Then
            Sql = "SELECT Pedido.PedidoSequencia, Pedido.Requisicao, Pedido.PedidoTipo, Funcionários.Nome AS NomeFunc, Clientes.Nome, Clientes.Cidade, Pedido.TotalPedido, Pedido.Empresa, Pedido.Inativo, Pedido.DataPedido, Pedido.Confirmado FROM (Pedido LEFT JOIN Clientes ON Pedido.CódigoCliente = Clientes.Codigo) LEFT JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário WHERE(((Pedido.Empresa) = " & CodEmpresa & ")) And Pedido.Confirmado = False And Pedido.Inativo = False ORDER BY Pedido.PedidoSequencia DESC;"
        Else

            Dim CampoFilter As String = ""
            Select Case opt
                Case "Pedido"
                    CampoFilter = "PedidoSequencia" & " Like '%" & Me.TxtProcura.Text & "%'"
                Case "Cliente"
                    CampoFilter = "Clientes.Nome" & " Like '%" & Me.TxtProcura.Text & "%'"
                Case "controle"
                    CampoFilter = "Requisicao" & " Like '%" & Me.TxtProcura.Text & "%'"
                Case "Data"
                    CampoFilter = "DataPedido" & "=#" & Format(CDate(Me.TxtProcura.Text), "MM/dd/yyyy") & "#"

            End Select
            'Sql = "SELECT Pedido.PedidoSequencia,Pedido.Requisicao, Pedido.PedidoTipo, Clientes.Nome, Clientes.Cidade, Pedido.TotalPedido, Pedido.Empresa, Pedido.Inativo, Pedido.DataPedido, Pedido.Confirmado FROM Pedido LEFT JOIN Clientes ON Pedido.CódigoCliente = Clientes.Codigo WHERE " & CampoFilter & " And Pedido.Empresa = " & CodEmpresa & " ORDER BY Pedido.PedidoSequencia DESC"
            Sql = "SELECT Pedido.PedidoSequencia, Pedido.Requisicao, Pedido.PedidoTipo, Funcionários.Nome AS NomeFunc, Clientes.Nome, Clientes.Cidade, Pedido.TotalPedido, Pedido.Empresa, Pedido.Inativo, Pedido.DataPedido, Pedido.Confirmado FROM (Pedido LEFT JOIN Clientes ON Pedido.CódigoCliente = Clientes.Codigo) LEFT JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário WHERE " & CampoFilter & " AND Pedido.Empresa = " & CodEmpresa & " ORDER BY Pedido.PedidoSequencia DESC;"

        End If


        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)

        da.Fill(DsProcura, "Table")

        Me.Lista.DataSource = DsProcura.Tables("Table").DefaultView

        da.Dispose()
        DsProcura.Dispose()
        Cnn.Close()

        For Each Linha As DataGridViewRow In Me.Lista.Rows
            If Linha.Cells("cConfirmado").Value = True Then
                Linha.Cells("Img").Value = Linha.Cells("ImgConf").Value
            End If
            If Linha.Cells("cConfirmado").Value = False Then
                Linha.Cells("Img").Value = Linha.Cells("ImgEdd").Value
            End If
            If Linha.Cells("cInativo").Value = True Then
                Linha.Cells("Img").Value = Linha.Cells("ImgCanc").Value
            End If
        Next

    End Sub


    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        If Me.PedidoSequencia.Text = "" Then
            MsgBox("Favor informar um Pedido/Venda para emissão de Nota Fiscal.", 64, "Validação de Dados")
            Exit Sub
        End If

        TRVDados(UserAtivo, "NFiscal")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            NotaFiscalAvulsa = False
            My.Forms.NFiscal.ShowDialog()
        End If

    End Sub

    Private Sub ButtonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem4.Click
        If Me.PedidoSequencia.Text = "NFVisualizador" Then
            MsgBox("O usuário deve selecionar um pedido antes.", 64, "Validação de Dados")
            Exit Sub
        End If
        My.Forms.NFVisualizador.ShowDialog()
    End Sub

    Private Sub CódigoCliente_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CódigoCliente.Validating
        If Len(Me.CódigoCliente.Text) = 0 Then
            Exit Sub
        End If
    End Sub


    Private Sub TpVenda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TpVenda.SelectedIndexChanged
        If Me.MyLista.Items.Count <> 0 Then
            Me.TpVenda.Text = strCombo2
            Exit Sub
        End If


        If Me.TpVenda.Text = "CONSIGNAÇÃO" Then
            Me.CódigoFuncionário.Enabled = False
            Me.FuncionarioDesc.Enabled = False
            Me.btFindVendedor.Enabled = False
            Me.ValorAVista.Enabled = False
            Me.ValorOutros.Enabled = False
            Me.ValorAFaturar.Enabled = False
            Me.ParcelamentoFixo.Enabled = False
            Me.ParcelamentoFixoDesc.Enabled = False
            Me.btFindParcelamentoFixo.Enabled = False
            Me.DiasParcelamento.Enabled = False
            Me.btGerarParcelas.Enabled = False
        Else
            Me.CódigoFuncionário.Enabled = True
            Me.FuncionarioDesc.Enabled = True
            Me.btFindVendedor.Enabled = True
            Me.ValorAVista.Enabled = True
            Me.ValorOutros.Enabled = True
            Me.ValorAFaturar.Enabled = True
            Me.ParcelamentoFixo.Enabled = True
            Me.ParcelamentoFixoDesc.Enabled = True
            Me.btFindParcelamentoFixo.Enabled = True
            Me.DiasParcelamento.Enabled = True
            Me.btGerarParcelas.Enabled = True
        End If

        If Me.TpVenda.Text = "DEVOLUÇÃO" Then
            Me.ValorAVista.Enabled = False
            Me.ValorOutros.Enabled = False
            Me.ParcelamentoFixo.Enabled = False
            Me.ParcelamentoFixoDesc.Enabled = False
            Me.btFindParcelamentoFixo.Enabled = False
            Me.DiasParcelamento.Enabled = False
            Me.DiasParcelamento.Text = "005"
            Me.TipoEntrega.SelectedValue = "IMEDIATA"
            Me.TipoEntrega.Enabled = False
            Me.ValorAVista.Text = FormatNumber(0, 2)
            Me.ValorOutros.Text = FormatNumber(0, 2)
        Else
            Me.ValorAVista.Enabled = True
            Me.ValorOutros.Enabled = True
            Me.ParcelamentoFixo.Enabled = True
            Me.ParcelamentoFixoDesc.Enabled = True
            Me.btFindParcelamentoFixo.Enabled = True
            Me.DiasParcelamento.Enabled = True
            Me.DiasParcelamento.Clear()
            Me.TipoEntrega.Enabled = True
        End If

    End Sub

    Private Sub TotalPropostoPedido_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalPropostoPedido.Enter
        If Me.TotalPropostoPedido.Text = "" Then
            Me.TotalPropostoPedido.Text = FormatNumber(NzZero(Me.TPedido.Text), 2)
        End If
    End Sub

    Private Sub NumeroControle_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumeroControle.Enter
        BloquearCabecalho()
    End Sub

    Private Sub TpVenda_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TpVenda.Enter
        strCombo2 = TpVenda.Text
        BloquearCabecalho()
    End Sub

    Private Sub TipoEntrega_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoEntrega.Enter
        strCombo1 = Me.TipoEntrega.SelectedItem
        BloquearCabecalho()
    End Sub

    Private Sub ExcluirTodasParcelasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirTodasParcelasToolStripMenuItem.Click
        If Me.Confirmado.Checked = True Then
            MsgBox("Este pedido já foi confirmado, não pode ser alterado.", 64, "Validação de Dados")
            Exit Sub
        End If


        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "Delete * from Receber where PedidoProdutos = " & Me.PedidoSequencia.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader

        DR.Close()
        Cnn.Close()
        EncheListaReceber()
        Me.Salvar.Focus()

    End Sub

    Private Sub Lista_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lista.Sorted
        For Each Linha As DataGridViewRow In Me.Lista.Rows
            If Linha.Cells("cConfirmado").Value = True Then
                Linha.Cells("Img").Value = Linha.Cells("ImgConf").Value
            End If
            If Linha.Cells("cConfirmado").Value = False Then
                Linha.Cells("Img").Value = Linha.Cells("ImgEdd").Value
            End If
            If Linha.Cells("cInativo").Value = True Then
                Linha.Cells("Img").Value = Linha.Cells("ImgCanc").Value
            End If
        Next
    End Sub

    Private Sub btCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelar.Click
        If Me.PedidoSequencia.Text = "" Then
            MessageBox.Show("O usuário deve selecionar um pedido para cancelar.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        TRVDados(UserAtivo, "PedidoCancelamento")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.PedidoCancelamentoOS.ShowDialog()
        End If
    End Sub

    Private Sub btAddNumeroControle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddNumeroControle.Click
        If Me.PedidoSequencia.Text = "" Then
            Exit Sub
        End If
        If Me.NumeroControle.Text <> "" Then
            MessageBox.Show("Já foi adicionado um número de Controle, operação será cancelada.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        My.Forms.PedidoVendaAddNumeroControle.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

        RelatorioCarregar = "RelPedidoImpressCopia"
        My.Forms.VisualizadorRelatorio.ShowDialog()

    End Sub

    Private Sub ExcluirTodosOsItensToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirTodosOsItensToolStripMenuItem.Click
        If Me.Confirmado.Checked = True Then
            MsgBox("Este pedido já foi confirmado, não pode ser alterado.", 64, "Validação de Dados")
            Exit Sub
        End If

        If Me.Inativo.Checked = True Then
            MsgBox("Este pedido já foi cancelado, não pode ser alterado.", 64, "Validação de Dados")
            Exit Sub
        End If

        If JaFoiGeradoReceber = True Then
            MsgBox("Neste pedido não pode ser Excluido produto, pois ja foi gerado o contas a receber, exclua o contas receber para incluir novos produtos.", 64, "Validação de Dados")
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Delete * from ItensPedido where PedidoSequencia = " & Me.PedidoSequencia.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader

        DR.Close()
        CNN.Close()

        OperationItens = INS


        EncheListaItens()


    End Sub

    Private Sub TpVenda_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TpVenda.SelectedValueChanged
        If Me.MyLista.Items.Count <> 0 Then
            Me.TpVenda.Text = strCombo2
        End If
    End Sub

    Private Sub TipoEntrega_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoEntrega.SelectedValueChanged
        If Me.MyLista.Items.Count <> 0 Then
            Me.TipoEntrega.Text = strCombo1
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If Me.Confirmado.Checked = False Then
            Me.ContextMenuStrip1.Enabled = False
        Else
            Me.ContextMenuStrip1.Enabled = True
        End If
    End Sub

    Private Sub CódigoCliente_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CódigoCliente.Enter
        If NzZero(Me.TotalPedido.Text) > 0 Then
            Me.CódigoCliente.ReadOnly = True
        Else
            Me.CódigoCliente.ReadOnly = False
        End If
    End Sub

    Private Sub EmAberto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmAberto.CheckedChanged
        If Me.EmAberto.Checked = True Then
            EncheGrid()
        End If
    End Sub
End Class