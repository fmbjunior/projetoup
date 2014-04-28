Public Class OrdemEmbarque

    Dim Finalizou As Boolean = True

    Dim Ação As New TrfGerais()

    Private OperationIten As Byte
    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Public Sub CorBotao(ByVal Bt As Control, ByVal Action As Integer)
        If Action = 1 Then
            Bt.BackColor = Color.LemonChiffon
        Else
            Bt.BackColor = Color.PowderBlue
        End If
    End Sub

    Private Sub BTOrdem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTOrdem.MouseLeave
        CorBotao(Me.BTOrdem, 2)
    End Sub

    Private Sub BTOrdem_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BTOrdem.MouseMove
        CorBotao(Me.BTOrdem, 1)
    End Sub

    Private Sub BtItens_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtItens.MouseLeave
        CorBotao(Me.BtItens, 2)
    End Sub

    Private Sub BtItens_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtItens.MouseMove
        CorBotao(Me.BtItens, 1)
    End Sub

    Private Sub OrdemEmbarque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()
        Me.Ordem.ReadOnly = True
        Me.Pedido.ReadOnly = True
        Me.CódigoCliente.ReadOnly = True
        Me.NomeCliente.ReadOnly = True
        Me.DataEmissao.ReadOnly = True
        Me.DataSaida.ReadOnly = True
    End Sub

    Private Sub BTOrdem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOrdem.Click
        Me.Ordem.ReadOnly = False
        Me.Pedido.ReadOnly = False
        Me.CódigoCliente.ReadOnly = False
        Me.NomeCliente.ReadOnly = False
        Me.DataEmissao.ReadOnly = False
        Me.DataSaida.ReadOnly = False

        Operation = INS
        Me.Ordem.Text = "0000"
        Me.Ordem.Focus()
        Me.BTOrdem.Enabled = False
    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        If Finalizou = False Then
            MsgBox("O usuário iniciou uma ordem não pode fechar antes de finalizar.", 64, TituloMsgbox)
            Exit Sub
        End If
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BtItens_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtItens.Click
        If Me.Ordem.Text = "" Then
            MsgBox("Antes de Lançar Itens o usuário deve informar o Nº da ordem.", 64, TituloMsgbox)
            Me.Ordem.Focus()
            Exit Sub
        ElseIf Me.Pedido.Text = "" Then
            MsgBox("Antes de Lançar Itens o usuário deve informar o Nº do Pedido.", 64, TituloMsgbox)
            Me.Pedido.Focus()
            Exit Sub
        ElseIf Me.CódigoCliente.Text = "" Then
            MsgBox("Antes de Lançar Itens o usuário deve informar o Cliente da Ordem.", 64, TituloMsgbox)
            Me.CódigoCliente.Focus()
            Exit Sub
        ElseIf Me.NomeCliente.Text = "" Then
            MsgBox("Antes de Lançar Itens o usuário deve informar o Cliente da Ordem.", 64, TituloMsgbox)
            Me.NomeCliente.Focus()
            Exit Sub
        ElseIf Me.DataEmissao.Text = "" Then
            MsgBox("Antes de Lançar Itens o usuário deve informar a data de emissão da Ordem.", 64, TituloMsgbox)
            Me.DataEmissao.Focus()
            Exit Sub
        ElseIf Me.DataSaida.Text = "" Then
            MsgBox("Antes de Lançar Itens o usuário deve informar a data de saida da Ordem.", 64, TituloMsgbox)
            Me.DataEmissao.Focus()
            Exit Sub
        End If

        Me.Ordem.ReadOnly = True
        Me.Pedido.ReadOnly = True
        Me.CódigoCliente.ReadOnly = True
        Me.NomeCliente.ReadOnly = True
        Me.DataEmissao.ReadOnly = True
        Me.DataSaida.ReadOnly = True

        'AtQtdRetirada()
        EncheListaImportar()
        EncheLista()
    End Sub


    Private Sub DataSaida_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataSaida.Enter
        If Me.DataSaida.Text = "" Then
            Me.DataSaida.Text = Today
        End If
    End Sub

    Private Sub DataSaida_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataSaida.Leave
        If Me.Ordem.Text = "" Then
            MsgBox("Favor informar o Nº da ordem.", 64, TituloMsgbox)
            Me.Ordem.Focus()
            Exit Sub
        ElseIf Me.Pedido.Text = "" Then
            MsgBox("Favor informar o Nº do Pedido.", 64, TituloMsgbox)
            Me.Pedido.Focus()
            Exit Sub
        ElseIf Me.CódigoCliente.Text = "" Then
            MsgBox("Favor informar o Cliente da Ordem.", 64, TituloMsgbox)
            Me.CódigoCliente.Focus()
            Exit Sub
        ElseIf Me.NomeCliente.Text = "" Then
            MsgBox("Favor informar o Cliente da Ordem.", 64, TituloMsgbox)
            Me.NomeCliente.Focus()
            Exit Sub
        ElseIf Me.DataEmissao.Text = "" Then
            MsgBox("Favor informar a data de emissão da Ordem.", 64, TituloMsgbox)
            Me.DataEmissao.Focus()
            Exit Sub
        ElseIf Me.DataSaida.Text = "" Then
            MsgBox("Favor informar a data de saida da Ordem.", 64, TituloMsgbox)
            Me.DataEmissao.Focus()
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then

            UltimoReg()
            Me.Ordem.Text = Me.OrdemTemp.Text

            CNN.Open()

            Dim Sql As String = "INSERT INTO OrdemImbarque (Ordem, Pedido, Cliente, DataEmissao, DataSaida, Empresa, Confirmado, Observação) VALUES (@1, @2, @3, @4, @5, @6, @7, @8)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Ordem.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Pedido.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.CódigoCliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataEmissao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.DataSaida.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", "N"))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Observação.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                CriaLog(UserAtivo, "OrdemEmbarque", "Adicionou: " & Me.Ordem.Text & " Clientes" & Me.CódigoCliente.Text)
                Operation = UPD
                Finalizou = False
            Catch ex As Exception
                MsgBox(ex.Message, 64, TituloMsgbox)
            End Try
            CNN.Close()

        ElseIf Operation = UPD Then
            CNN.Open()

            Dim Sql As String = "Update OrdemImbarque set Pedido = @2, Cliente = @3, DataEmissao = @4, DataSaida = @5, Empresa = @6, Confirmado = @7, Observação = @8 Where Ordem = " & Me.Ordem.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Pedido.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.CódigoCliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataEmissao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.DataSaida.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", "N"))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Observação.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                Operation = UPD
                Finalizou = False
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            CNN.Close()
        End If

    End Sub

    Public Sub UltimoReg()
        'Inserir ultimo registro
        Dim Cnn As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer
        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select max(Ordem) from OrdemImbarque"
            .CommandType = CommandType.Text
        End With
        Try
            Cnn.Open()
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    'Achou o iten procurado o iten as caixas serão preenchida
                    Ult = DataReader.Item(0)
                End If
            End While
            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()

        Dim strNumero As String = (Ult + 1)
        Me.OrdemTemp.Text = strNumero
        'fim inserir ultimo registro

    End Sub


    Private Sub Pedido_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pedido.Enter
        If Me.Pedido.Text = "" Then
            Me.Pedido.Text = My.Forms.PedidoVenda.PedidoSequencia.Text
        End If
    End Sub

    Private Sub CódigoCliente_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles CódigoCliente.Enter
        If Me.CódigoCliente.Text = "" Then
            Me.CódigoCliente.Text = My.Forms.PedidoVenda.CódigoCliente.Text
            Me.NomeCliente.Text = My.Forms.PedidoVenda.NomeCliente.Text
        End If
    End Sub

    Private Sub DataEmissao_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataEmissao.Enter
        If Me.DataEmissao.Text = "" Then
            Me.DataEmissao.Text = Today
        End If
    End Sub

    Public Sub EncheLista()
        If Me.Ordem.Text = "" Then
            Exit Sub
        End If

        MyLista.Items.Clear()

        Dim Cnn As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        Cnn.Open()

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM OrdemImbarqueItens WHERE Ordem = " & Me.Ordem.Text
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            Dim Zebrar As Boolean = False
            While DR.Read
                If Not IsDBNull(DR.Item("Id")) Then
                    Dim AA As String = DR.Item("Id")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("Produto") & "")
                    It.SubItems.Add(DR.Item("Descricao") & "")
                    It.SubItems.Add(FormatNumber(DR.Item("Qtd"), CsDecimais))
                    It.SubItems.Add(DR.Item("IdItem") & "")

                    MyLista.Items.AddRange(New ListViewItem() {It})

                    If Zebrar = False Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.PowderBlue
                        Zebrar = True
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    End If

                End If
            End While
            DR.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()

    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        Dim I As Integer = 0

        Dim IdTemp As Integer = 0
        Dim IdtITem As Integer = 0
        Dim QtdTemp As Double = 0
        Dim Prod As String = ""

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then IdTemp = MyLista.Items(I).Text.Substring(0)
            If MyLista.Items(I).Selected = True Then Prod = MyLista.Items(I).SubItems(1).Text.Substring(0)
            If MyLista.Items(I).Selected = True Then QtdTemp = MyLista.Items(I).SubItems(3).Text.Substring(0)
            If MyLista.Items(I).Selected = True Then IdtITem = MyLista.Items(I).SubItems(4).Text.Substring(0)
        Next

        If MsgBox("Deseja realmente excluir o item selecionado.", 36, TituloMsgbox) = 6 Then

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "DELETE * From OrdemImbarqueItens WHERE Id = " & IdTemp
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                'AtEstoqueSaida("Exc", 0, 0, IdTemp, Me.DataEmissao.Text, Me.Pedido.Text)
                AtQtdRetirada(IdtITem, QtdTemp, "-")
                EncheListaImportar()
                EncheLista()
                CriaLog(UserAtivo, "OrdemEmbarque", "Extornou o Produto: " & Prod & " Qtd " & QtdTemp)
            Catch ex As Exception
                MsgBox(ex.Message, 64, TituloMsgbox)
                CNN.Close()
            End Try
        End If

    End Sub

    Public Sub EncheListaImportar()
        If Me.Ordem.Text = "" Then
            Exit Sub
        End If

        MyLista1.Items.Clear()

        Dim Cnn As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        Cnn.Open()

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT ItensPedido.Id, ItensPedido.PedidoSequencia, ItensPedido.CodigoProduto, Produtos.Descrição, Produtos.CustoMedio, ItensPedido.Qtd, ItensPedido.QtdRetirada FROM ItensPedido INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto WHERE ItensPedido.PedidoSequencia = " & Me.Pedido.Text

            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            Dim Zebrar As Boolean = False
            While DR.Read
                If Not IsDBNull(DR.Item("Id")) Then
                    Dim AA As String = DR.Item("Id")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("CodigoProduto") & "")
                    It.SubItems.Add(DR.Item("Descrição") & "")
                    It.SubItems.Add(FormatNumber(CDbl(DR.Item("Qtd")), CsDecimais))
                    It.SubItems.Add(FormatNumber(CDbl(DR.Item("QtdRetirada")), CsDecimais))
                    It.SubItems.Add(FormatNumber(CDbl(DR.Item("Qtd")) - CDbl(DR.Item("QtdRetirada")), CsDecimais))
                    It.SubItems.Add(FormatNumber(CDbl(NzZero(DR.Item("CustoMedio"))), CsDecimais))

                    MyLista1.Items.AddRange(New ListViewItem() {It})

                    If Zebrar = False Then
                        MyLista1.Items.Item(MyLista1.Items.Count() - 1).BackColor = Color.PowderBlue
                        Zebrar = True
                    Else
                        MyLista1.Items.Item(MyLista1.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    End If

                End If
            End While
            DR.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()
    End Sub


    Public Sub AtQtdRetirada(ByVal IdItem As Integer, ByVal QtdRetirada As Double, ByVal Calculo As String)
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = ""
        Dim VlrStr As String = ""
        If Calculo = "+" Then
            VlrStr = QtdRetirada
            VlrStr = VlrStr.Replace(".", "")
            VlrStr = VlrStr.Replace(",", ".")
            Sql = "UPDATE ItensPedido SET ItensPedido.QtdRetirada = ([QtdRetirada]+ " & (VlrStr) & ") WHERE (((ItensPedido.Id)= " & IdItem & "));"
        Else
            VlrStr = QtdRetirada
            VlrStr = VlrStr.Replace(".", "")
            VlrStr = VlrStr.Replace(",", ".")
            Sql = "UPDATE ItensPedido SET ItensPedido.QtdRetirada = ([QtdRetirada]- " & (VlrStr) & ") WHERE (((ItensPedido.Id)= " & IdItem & "));"
        End If

        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        Try
            cmd.ExecuteNonQuery()
            CNN.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 64, TituloMsgbox)
            CNN.Close()
        End Try
    End Sub

    Private Sub MyLista1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista1.DoubleClick
        Dim I As Integer = 0

        Dim IdItenEstoque As Integer = 0
        Dim Produto As Integer = 0
        Dim ProdDesc As String = ""
        Dim QtdRest As Double = 0
        Dim QtdInformada As Double = 0
        Dim CcustoItem As Double = 0

        For I = 0 To MyLista1.Items.Count - 1
            If MyLista1.Items(I).Selected = True Then IdItenEstoque = MyLista1.Items(I).Text.Substring(0)
            If MyLista1.Items(I).Selected = True Then Produto = MyLista1.Items(I).SubItems(1).Text.Substring(0)
            If MyLista1.Items(I).Selected = True Then ProdDesc = MyLista1.Items(I).SubItems(2).Text.Substring(0)
            If MyLista1.Items(I).Selected = True Then QtdRest = MyLista1.Items(I).SubItems(5).Text.Substring(0)
            If MyLista1.Items(I).Selected = True Then CcustoItem = MyLista1.Items(I).SubItems(6).Text.Substring(0)
        Next

        If QtdRest = 0 Then
            MsgBox("Não existe quantidade disponivel deste produto, favor escolher outro.", 64, TituloMsgbox)
            Exit Sub
        End If

        QtdInformada = InputBox("Favor Informar a Quantidade do Produto.", TituloMsgbox, QtdRest)

        If QtdInformada > QtdRest Then
            MsgBox("A quantidade informada é maior que a quantidade permitida para a ordem.", 64, TituloMsgbox)
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        CNN.Open()

        UltimoRegItens()
        Dim Sql As String = "INSERT INTO OrdemImbarqueItens (Ordem, Pedido, Produto, Descricao, Qtd, IdItem, Id, CustoItem, CustoTotal) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9)"
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Ordem.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Pedido.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Produto))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@4", ProdDesc))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@5", QtdInformada))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@6", IdItenEstoque))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.IdTEMP.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(CDbl(CcustoItem), 3)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(CDbl(CcustoItem) * CDbl(QtdInformada), 3)))

        Try
            cmd.ExecuteNonQuery()
            OperationIten = INS
            CNN.Close()
            EncheLista()
            AtQtdRetirada(IdItenEstoque, QtdInformada, "+")
            EncheListaImportar()
            CriaLog(UserAtivo, "OrdemEmbarque", "Adicionou o Produto: " & Produto & " Qtd " & QtdInformada)
        Catch ex As Exception
            MsgBox(ex.Message, 64, TituloMsgbox)
        End Try

    End Sub

    Public Sub UltimoRegItens()
        'Inserir ultimo registro
        Dim Cnn As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer
        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select max(Id) from OrdemImbarqueItens"
            .CommandType = CommandType.Text
        End With
        Try
            Cnn.Open()
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    'Achou o iten procurado o iten as caixas serão preenchida
                    Ult = DataReader.Item(0)
                End If
            End While
            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()

        Me.IdTEMP.Text = Ult + 1
        'fim inserir ultimo registro

    End Sub

    Private Sub SalvarImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarImprimir.Click
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        CNN.Open()

        Dim Sql As String
        Sql = "Update OrdemImbarque set Pedido = @2, Cliente = @3, DataEmissao = @4, DataSaida = @5, Empresa = @6, Confirmado = @7, Observação = @8 Where Ordem = " & Me.Ordem.Text

        Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)
        cmd.Transaction = Transacao

        Try
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Pedido.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.CódigoCliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataEmissao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.DataSaida.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", "S"))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Observação.Text, 1)))

            cmd.ExecuteNonQuery()



            Transacao.Commit()

            Operation = UPD
            Finalizou = True
            'Imprimir Ordem


            'Adicionar Item de centro de custo


            Dim DS As New DataSet()
            Dim da As OleDb.OleDbDataAdapter
            Dim daLancamento As OleDb.OleDbDataAdapter
            Dim TBLcc As DataTable


            Sql = "SELECT OrdemImbarqueItens.Ordem, Sum(OrdemImbarqueItens.CustoTotal) AS SomaDeCustoTotal, Pedido.pCCG3, Produtos.CentroContaLanc FROM (OrdemImbarqueItens INNER JOIN Produtos ON OrdemImbarqueItens.Produto = Produtos.CodigoProduto) INNER JOIN Pedido ON OrdemImbarqueItens.Pedido = Pedido.PedidoSequencia GROUP BY OrdemImbarqueItens.Ordem, Pedido.pCCG3, Produtos.CentroContaLanc HAVING (((OrdemImbarqueItens.Ordem)=" & Me.Ordem.Text & "));"
            da = New OleDb.OleDbDataAdapter(Sql, CNN)
            da.Fill(DS, "ItenLancar")

            Sql = "Select * From CentroCustoLancamento Where IdLanc = '-1'"
            daLancamento = New OleDb.OleDbDataAdapter(Sql, CNN)
            daLancamento.Fill(DS, "CentroCustoLancamento")
            TBLcc = DS.Tables("CentroCustoLancamento")


            If CodEmpresa <> 10 Then
                Dim DrLinha As DataRow
                For Each DrLinha In DS.Tables("ItenLancar").Rows
                    If Not IsDBNull(DrLinha("pCCG3")) Then
                        If Not IsDBNull(DrLinha("CentroContaLanc")) Then
                            Dim Ult As String
                            Ult = CalcIdLancamento()

                            Dim DRnovo As DataRow
                            DRnovo = TBLcc.NewRow()
                            DRnovo("G3") = DrLinha("pCCG3")
                            Dim ss As String = DrLinha("pCCG3")
                            DRnovo("IdLanc") = Ult
                            DRnovo("ContaLanc") = DrLinha("CentroContaLanc")
                            DRnovo("DataLanc") = DataDia
                            DRnovo("VlrDebito") = CDbl(DrLinha("SomaDeCustoTotal"))
                            DRnovo("Historico") = "LANÇ. ORDEM EMBARQUE: " & Me.Ordem.Text
                            DRnovo("Relacionamento") = Me.Ordem.Text
                            DRnovo("OrigemLanc") = "OrdEmbarque"
                            DRnovo("Empresa") = CodEmpresa
                            DRnovo("HorasLanc") = Format(DateTime.Now, "hh:mm")
                            DRnovo("Usuario") = UserAtivo
                            TBLcc.Rows.Add(DRnovo)
                        End If
                    End If
                Next
            Else
                Dim DrLinha As DataRow
                For Each DrLinha In DS.Tables("ItenLancar").Rows
                    Dim Ult As String
                    Ult = CalcIdLancamento()

                    Dim DRnovo As DataRow
                    DRnovo = TBLcc.NewRow()
                    DRnovo("G3") = "000040"
                    DRnovo("IdLanc") = Ult
                    DRnovo("ContaLanc") = DrLinha("CentroContaLanc")
                    DRnovo("DataLanc") = DataDia
                    DRnovo("VlrDebito") = CDbl(DrLinha("SomaDeCustoTotal"))
                    DRnovo("Historico") = "LANÇ. ORDEM EMBARQUE: " & Me.Ordem.Text
                    DRnovo("Relacionamento") = Me.Ordem.Text
                    DRnovo("OrigemLanc") = "OrdEmbarque"
                    DRnovo("Empresa") = CodEmpresa
                    DRnovo("HorasLanc") = Format(DateTime.Now, "hh:mm")
                    DRnovo("Usuario") = UserAtivo
                    TBLcc.Rows.Add(DRnovo)
                Next
            End If



            Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(daLancamento)
            daLancamento.Update(DS, "CentroCustoLancamento")


            'Fim

            AtStatusPedido() 'Atualiza o status do Pedido
            My.Forms.PedidoVenda.EncheListaItens()

            RelatorioCarregar = "RelOrdemEmbarque"
            My.Forms.VisualizadorRelatorio.ShowDialog()
            CNN.Close()
            Me.Close()
            Me.Dispose()

        Catch x As Exception
            Transacao.Rollback()
            CNN.Close()
            MsgBox(x.Message, 64, TituloMsgbox)
            MsgBox("Erro ao confirmar a Ordem de Embarque, tente confirmar novamente ou consulte o administrador.", 64, TituloMsgbox)
            Exit Sub
        End Try

    End Sub

    Public Sub AtEstoqueSaida(ByVal TipoOperação As String, ByVal CodProd As Integer, ByVal QtdSaida As Double, ByVal IdLanç As Integer, ByVal DataOrdem As Date, ByVal Pedido As Integer)
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = ""

        If TipoOperação = "Add" Then
            Sql = "INSERT INTO EstoqueReal (CodigoProduto, Qtd, QtdEntrada, Tipo, IdLancamento, DataLancamento, Npedido) VALUES (@1, @2, @3, @4, @5, @6, @7)"
        Else
            Sql = "Delete * From EstoqueReal WHERE Tipo ='S' and IdLancamento = " & IdLanç
        End If

        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        If TipoOperação = "Add" Then
            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", CodProd))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", QtdSaida))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", 0))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", "S"))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", IdLanç))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", DataOrdem))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Pedido))
        End If

        Try
            cmd.ExecuteNonQuery()
            CNN.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 64, TituloMsgbox)
            CNN.Close()
        End Try
    End Sub

    Private Sub AddItens_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddItens.Click

        If Me.Ordem.Text = "" Then
            MsgBox("Não pode adicionar item, a ordem não foi criada.", 64, TituloMsgbox)
            Exit Sub
        End If

        If Me.Ordem.Text = "0000" Then
            MsgBox("Não pode adicionar item, a ordem não foi criada.", 64, TituloMsgbox)
            Exit Sub
        End If

        If Me.Pedido.Text = "" Then
            MsgBox("Não pode adicionar todos os item a ordem, a ordem não possui pedido.", 64, TituloMsgbox)
            Exit Sub
        End If


        Dim I As Integer = 0

        Dim IdItenEstoque As Integer = 0
        Dim Produto As Integer = 0
        Dim ProdDesc As String = ""
        Dim QtdRest As Double = 0
        Dim QtdInformada As Double = 0
        Dim CcustoItem As Double = 0



        For I = 0 To MyLista1.Items.Count - 1
            IdItenEstoque = MyLista1.Items(I).Text.Substring(0)
            Produto = MyLista1.Items(I).SubItems(1).Text.Substring(0)
            ProdDesc = MyLista1.Items(I).SubItems(2).Text.Substring(0)
            QtdRest = MyLista1.Items(I).SubItems(5).Text.Substring(0)
            CcustoItem = MyLista1.Items(I).SubItems(6).Text.Substring(0)


            QtdInformada = MyLista1.Items(I).SubItems(5).Text.Substring(0)

            If QtdInformada > QtdRest Then
                MsgBox("A quantidade informada é maior que a quantidade permitida para a ordem.", 64, TituloMsgbox)
            Else
                If QtdRest = 0 Then
                    MsgBox("Não existe quantidade disponivel do produto: " & Produto & "-" & ProdDesc & ", favor escolher outro.", 64, TituloMsgbox)
                Else

                    Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
                    CNN.Open()

                    UltimoRegItens()
                    Dim Sql As String = "INSERT INTO OrdemImbarqueItens (Ordem, Pedido, Produto, Descricao, Qtd, IdItem, Id, CustoItem, CustoTotal) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9)"
                    Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

                    cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Ordem.Text, 1)))
                    cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Pedido.Text, 1)))
                    cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Produto))
                    cmd.Parameters.Add(New OleDb.OleDbParameter("@4", ProdDesc))
                    cmd.Parameters.Add(New OleDb.OleDbParameter("@5", QtdInformada))
                    cmd.Parameters.Add(New OleDb.OleDbParameter("@6", IdItenEstoque))
                    cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.IdTEMP.Text, 1)))
                    cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(CDbl(CcustoItem), 3)))
                    cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(CDbl(CcustoItem) * CDbl(QtdInformada), 3)))

                    Try
                        cmd.ExecuteNonQuery()
                        CriaLog(UserAtivo, "OrdemEmbarque", "Adicionou o Produto: " & Produto & " Qtd " & QtdInformada)
                        OperationIten = INS
                        CNN.Close()
                        AtQtdRetirada(IdItenEstoque, QtdInformada, "+")
                        EncheLista()
                        EncheListaImportar()
                        System.Threading.Thread.Sleep(40)

                    Catch ex As Exception
                        MsgBox(ex.Message, 64, TituloMsgbox)
                    End Try

                End If

            End If
        Next




    End Sub

    Private Sub Degrade()
        Try
            Dim CCor() As String
            Dim corTemp As String

            corTemp = Cor1TelaSecundaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))

            corTemp = Cor2TelaSecundaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))
        Catch ex As Exception
        End Try
    End Sub


    Private Sub AtStatusPedido()
        Me.Cursor = Cursors.WaitCursor

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim ds As New DataSet()

        Dim Sql As String = String.Empty

        Sql = "SELECT Pedido.PedidoSequencia, Pedido.StatusAndamentos FROM(Pedido) WHERE (((Pedido.PedidoSequencia)=" & Me.Pedido.Text & ") AND ((Pedido.StatusAndamentos)<>'FINALIZADO' Or (Pedido.StatusAndamentos) Is Null));"

        Dim DAPedidos As New OleDb.OleDbDataAdapter(Sql, CNN)
        DAPedidos.Fill(ds, "Pedidos")

        Sql = "SELECT Pedido.StatusAndamentos, ItensPedido.PedidoSequencia, Sum(ItensPedido.Qtd) AS SomaDeQtd, Sum(ItensPedido.QtdRetirada) AS SomaDeQtdRetirada FROM Pedido INNER JOIN ItensPedido ON Pedido.PedidoSequencia = ItensPedido.PedidoSequencia GROUP BY Pedido.StatusAndamentos, ItensPedido.PedidoSequencia HAVING (((Pedido.StatusAndamentos)<>'FINALIZADO' Or (Pedido.StatusAndamentos) Is Null) AND ((ItensPedido.PedidoSequencia)=" & Me.Pedido.Text & "));"
        Dim DAItens As New OleDb.OleDbDataAdapter(Sql, CNN)
        DAItens.Fill(ds, "ItensPedidos")


        Dim Status As String = String.Empty

        Dim DrItem As DataRow
        For Each DrItem In ds.Tables("ItensPedidos").Rows
            Dim DrPedido() As DataRow
            DrPedido = ds.Tables("Pedidos").Select("PedidoSequencia = " & DrItem("PedidoSequencia").ToString)

            Dim TBL As DataTable
            TBL = ds.Tables("Pedidos")

            If DrItem("SomaDeQtdRetirada") = 0 Then Status = "INICIAL"
            If DrItem("SomaDeQtdRetirada") > 0 And DrItem("SomaDeQtdRetirada") < DrItem("SomaDeQtd") Then Status = "EM ANDAMENTO"
            If DrItem("SomaDeQtdRetirada") = DrItem("SomaDeQtd") Then Status = "FINALIZADO"

            If DrPedido.Length <> 0 Then
                DrPedido(0).BeginEdit()
                DrPedido(0)("StatusAndamentos") = Status
                DrPedido(0).EndEdit()
            End If
        Next

        Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAPedidos)
        DAPedidos.Update(ds, "Pedidos")

        DAPedidos.Dispose()
        ds.Dispose()
        CNN.Close()

        Me.Cursor = Cursors.Default

    End Sub
End Class