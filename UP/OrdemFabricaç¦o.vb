Public Class OrdemFabricação

    Dim Ação As New TrfGerais()

    Dim Exclusão As Boolean = False

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Novo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Novo.Click
        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)
        Me.MyLista.Items.Clear()
        Me.NumeroOF.Text = "0000"
        Me.NumeroOF.Focus()
        Operation = INS
    End Sub

    Private Sub Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar.Click
        If Me.NumeroOF.Text = "" Then
            MsgBox("Não existe Ordem de Fabricação para ser editado.", 64, TituloMsgbox)
            Exit Sub
        End If
        Operation = UPD
        Ação.Desbloquear_Controle(Me, True)
        Me.NumeroOF.Focus()
    End Sub

    Private Sub Salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salvar.Click
        'Area destinada para as validacoes
        If Me.NumeroOF.Text = "" Then
            MsgBox("O Código da Ordem de Fabricação não foi informado, favor verificar.", 64, TituloMsgbox)
            Me.NumeroOF.Focus()
            Exit Sub
        ElseIf Me.NumeroPedido.Text = "" Then
            Me.NumeroPedido.Text = 0

        ElseIf Me.DataEmissão.Text = "" Then
            MsgBox("A Data de emissão da ordem de favricação não foi informado, favor verificar.", 64, TituloMsgbox)
            Me.DataEmissão.Focus()
            Exit Sub
        ElseIf Me.AutorizadoPor.Text = "" Then
            MsgBox("A Ordem de Fabricação tem que ser autorizado por alguem responsavel da Lista, favor verificar.", 64, TituloMsgbox)
            Me.AutorizadoPor.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            UltimoReg()
            Dim Sql As String = "INSERT INTO OrdemFabricação (NumeroOf, NumeroPedido, NomeCliente, DataEmissão, DataEntrega, AutorizadoPor, Confirmada, Empresa) VALUES (@1, @2, @3, @4, @5, @6, @7, @8)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.NumeroOF.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.NumeroPedido.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.NomeCliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataEmissão.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.DataEntrega.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.AutorizadoPor.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", "N"))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", CodEmpresa))

            Try
                cmd.ExecuteNonQuery()
                CriaLog(UserAtivo, "OrdemFabricacao", "Adicionou: a Ordem " & Me.NumeroOF.Text & " para o Cliente " & Me.NomeCliente.Text)
                MsgBox("Registro adicionado com sucesso", 64, TituloMsgbox)
                Operation = UPD
            Catch ex As Exception
                MsgBox(ex.Message, 64, TituloMsgbox)
            End Try
            Ação.Desbloquear_Controle(Me, False)
            CNN.Close()

        ElseIf Operation = UPD Then
            CNN.Open()

            Dim Sql As String = "Update OrdemFabricação set NumeroPedido = @2, NomeCliente = @3, DataEmissão = @4, DataEntrega = @5, AutorizadoPor = @6, Confirmada = @7, Empresa = @8 Where NumeroOF = " & Me.NumeroOF.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.NumeroPedido.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.NomeCliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataEmissão.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.DataEntrega.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.AutorizadoPor.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", "N"))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", CodEmpresa))

            Try
                cmd.ExecuteNonQuery()
                CriaLog(UserAtivo, "OrdemFabricacao", "Editou: a Ordem " & Me.NumeroOF.Text & " para o Cliente " & Me.NomeCliente.Text)
                MsgBox("Registro Atualizado com sucesso", 64, TituloMsgbox)
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, False)
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
            .CommandText = "Select max(NumeroOF) from OrdemFabricação"
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

        Me.NumeroOF.Text = Ult + 1
        Me.NumeroPedido.Focus()
        'fim inserir ultimo registro

    End Sub

    Private Sub Localizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Localizar.Click
        RetornoProcura = ""
        ChamaTelaProcura("Nº Ordem", "Cliente", "", "OrdemFabricação", "NumeroOF", "NomeCliente", "", True)

        Me.NumeroOF.Text = RetornoProcura
        If Me.NumeroOF.Text <> "" Then
            LocalizaDados()
            Me.NumeroPedido.Focus()
        End If
    End Sub

    Public Sub LocalizaDados()
        If Me.NumeroOF.Text = "" Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from OrdemFabricação where NumeroOF = " & Me.NumeroOF.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.NumeroOF.Text = DR.Item("NumeroOF") & ""
            Me.NumeroPedido.Text = DR.Item("NumeroPedido") & ""
            Me.NomeCliente.Text = DR.Item("NomeCliente") & ""
            Me.DataEmissão.Text = DR.Item("DataEmissão") & ""
            Me.DataEntrega.Text = DR.Item("DataEntrega") & ""
            Me.AutorizadoPor.Text = DR.Item("AutorizadoPor") & ""
            Me.Confirmada.Text = DR.Item("Confirmada") & ""

            DR.Close()
            EncheListaItens()
            Ação.Desbloquear_Controle(Me, True)
            Operation = UPD
        Else
            MsgBox("Ordem de Fabricação não cadastrado, Verifique.", 64, TituloMsgbox)
            DR.Close()
            Me.NumeroOF.Text = "0000"
            Me.NumeroOF.Focus()
            Operation = INS
            Exit Sub
        End If
    End Sub

    Private Sub OrdemFabricação_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F11 Then
            Fechar_Click(sender, e)
        End If

        If e.KeyCode = Keys.F10 Then
            Salvar_Click(sender, e)
        End If

        If e.KeyCode = Keys.F9 Then
            Novo_Click(sender, e)
        End If

        If e.KeyCode = Keys.F8 Then
            Editar_Click(sender, e)
        End If

        If e.KeyCode = Keys.F4 Then
            Localizar_Click(sender, e)
        End If

        If e.KeyCode = Keys.F6 Then
            If F6 = False Then
                MsgBox("Este Usuário não tem permissão para recurso adicionais, consulte o Administrador.", 64, TituloMsgbox)
                Exit Sub
            Else
                MsgBox("Este Usuário tem permissão para recurso adicionais, recurso Liberado", 64, TituloMsgbox)
                Exclusão = True
            End If
        End If

        If e.KeyCode = Keys.F2 Then
            'colocar aqui recurso para excluir o item
            MsgBox("O Recurso de Exclusão não esta disponivel nesta versão")
            Exit Sub
        End If

    End Sub

    Private Sub NumeroOF_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumeroOF.Leave
        If Me.NumeroOF.Text = "0000" Then
            Exit Sub
        Else
            LocalizaDados()
        End If
    End Sub

    Private Sub OrdemFabricação_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Ação.Desbloquear_Controle(Me, False)
    End Sub

    Public Sub EncheListaItens()

        If Me.NumeroOF.Text = "" Then Exit Sub

        MyLista.Items.Clear()

        Dim Cnn As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        Cnn.Open()

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT OrdemFabricaçãoItens.*, OrdemFabricaçãoItens.NumeroOF, Produtos.Descrição FROM Produtos INNER JOIN OrdemFabricaçãoItens ON Produtos.CodigoProduto = OrdemFabricaçãoItens.Produto WHERE OrdemFabricaçãoItens.NumeroOF = " & Me.NumeroOF.Text
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            Dim Zebrar As Boolean = True
            Dim AProduzir As Double = 0
            While DataReader.Read
                If Not IsDBNull(DataReader.Item("Produto")) Then
                    Dim AA As String = DataReader.Item("Produto")
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("Descrição") & "")
                    item1.SubItems.Add(FormatNumber(DataReader.Item("Qtd"), 2))
                    item1.SubItems.Add(FormatNumber(DataReader.Item("Produzido"), 2))
                    AProduzir = CDbl(DataReader.Item("Qtd")) - CDbl(DataReader.Item("Produzido"))
                    item1.SubItems.Add(FormatNumber(AProduzir, 2))
                    item1.SubItems.Add(DataReader.Item("OrdemFabricaçãoItens.NumeroOF") & "")

                    MyLista.Items.AddRange(New ListViewItem() {item1})

                    If Zebrar = True Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.MistyRose
                        Zebrar = True
                    End If
                End If
            End While

            DataReader.Close()
            Cnn.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
    End Sub


    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        If Me.NumeroOF.Text = "" Then
            MsgBox("O usuário deve selecionar primeiro uma Ordem de Fabricação para editar os seus itens.", 64, TituloMsgbox)
            Exit Sub
        End If

        Dim I As Integer = 0
        RetornoProcura = ""
        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then RetornoProcura = (MyLista.Items(I).Text.Substring(0))
        Next
        If RetornoProcura = "" Then
            Exit Sub
        Else
            My.Forms.OrdemFabricaçãoItens.ShowDialog()
        End If

    End Sub

    Private Sub LançarItensNaOFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LançarItensNaOFToolStripMenuItem.Click
        If Me.NumeroOF.Text = "" Then
            MsgBox("O usuário deve selecionar uma orderm de fabricação antes de lançar os itens.", 64, TituloMsgbox)
            Exit Sub
        End If

        If Operation = INS Then
            MsgBox("O usuário deve salvar a ordem de fabricação antes de adicionar os itens.", 64, TituloMsgbox)
        Else
            RetornoProcura = ""
            My.Forms.OrdemFabricaçãoItens.ShowDialog()
        End If
    End Sub

    Private Sub ImportarItensDoPedidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportarItensDoPedidoToolStripMenuItem.Click
        If Me.NumeroOF.Text = "" Then
            MsgBox("O usuário deve selecionar uma orderm de fabricação antes de lançar os itens.", 64, TituloMsgbox)
            Exit Sub
        End If
        If Me.NumeroPedido.Text = "" Then
            MsgBox("Esta Ordem de Fabricação não foi informado um numero de Pedido, verifique.", 64, TituloMsgbox)
            Exit Sub
        End If

        If Operation = INS Then
            MsgBox("O usuário deve salvar a ordem de fabricação antes de adicionar os itens.", 64, TituloMsgbox)
            Exit Sub
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Pedido where PedidoSequencia = " & Me.NumeroPedido.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            DR.Close()
            ImportaItens()
            EncheListaItens()
        Else
            MsgBox("Pedido não encontrado, Verifique.", 64, TituloMsgbox)
            DR.Close()
            Exit Sub
        End If


    End Sub

    Public Sub ImportaItens()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "INSERT INTO OrdemFabricaçãoItens ( NumeroOF, Produto, Qtd, Produzido ) SELECT " & Me.NumeroOF.Text & " AS [OF], ItensPedido.CodigoProduto, Sum(ItensPedido.Qtd) AS SomaDeQtd, 0 AS Zero FROM(ItensPedido) GROUP BY ItensPedido.PedidoSequencia, " & Me.NumeroOF.Text & ", ItensPedido.CodigoProduto, 0 HAVING (((ItensPedido.PedidoSequencia)=" & Me.NumeroPedido.Text & "));"
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)

        Try
            If MsgBox("Deseja realmente importar os dados do pedido.", 36, TituloMsgbox) = 6 Then
                CMD.ExecuteNonQuery()
                CriaLog(UserAtivo, "OrdemFabricacao", "Importacao: dos Itens do Pedido " & Me.NumeroPedido.Text)
                CNN.Close()
            End If
            CNN.Close()
        Catch ex As Exception
            MsgBox("Erro na importação dos Itens, verifique.", 64, TituloMsgbox)
            CNN.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub ExcluirItenSelecionadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirItenSelecionadoToolStripMenuItem.Click
        If Me.Confirmada.Text = "S" Then
            MsgBox("Esta ordem de Fabricação já foi confirmada e impressa, não pode ser alterada.", 64, TituloMsgbox)
            Exit Sub
        Else

            Dim I As Integer = 0
            RetornoProcura = ""
            For I = 0 To MyLista.Items.Count - 1
                If MyLista.Items(I).Selected = True Then RetornoProcura = (MyLista.Items(I).Text.Substring(0))
            Next
            If RetornoProcura = "" Then
                Exit Sub
            Else

                Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
                CNN.Open()

                Dim Sql As String = "Delete * from OrdemFabricaçãoItens Where NumeroOF = " & Me.NumeroOF.Text & " and Produto = " & RetornoProcura
                Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

                Try
                    cmd.ExecuteNonQuery()
                    CriaLog(UserAtivo, "OrdemFabricacao", "Excluiu: da Ordem o Produto " & RetornoProcura)
                    CNN.Close()
                    EncheListaItens()
                Catch ex As Exception
                    MsgBox(ex.Message, 64, TituloMsgbox)
                End Try

            End If
        End If
    End Sub

    Private Sub ImprimirOFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirOFToolStripMenuItem.Click
        If Me.Confirmada.Text <> "S" Then
            MsgBox("Para Imprimir a Ordem de Fabricação o usuário deve primeiro confirmar.", 64, TituloMsgbox)
            Exit Sub
        End If
        RelatorioCarregar = "RelOrdemFabricação"
        My.Forms.VisualizadorRelatorio.ShowDialog()
    End Sub

    Private Sub ConfirmarOFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmarOFToolStripMenuItem.Click
        'Area destinada para as validacoes
        If Me.NumeroOF.Text = "" Then
            MsgBox("O Código da Ordem de Fabricação não foi informado, favor verificar.", 64, TituloMsgbox)
            Me.NumeroOF.Focus()
            Exit Sub
        ElseIf Me.NumeroPedido.Text = "" Then
            Me.NumeroPedido.Text = 0

        ElseIf Me.DataEmissão.Text = "" Then
            MsgBox("A Data de emissão da ordem de favricação não foi informado, favor verificar.", 64, TituloMsgbox)
            Me.DataEmissão.Focus()
            Exit Sub
        ElseIf Me.AutorizadoPor.Text = "" Then
            MsgBox("A Ordem de Fabricação tem que ser autorizado por alguem responsavel da Lista, favor verificar.", 64, TituloMsgbox)
            Me.AutorizadoPor.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        CNN.Open()

        Dim Sql As String = "Update OrdemFabricação set NumeroPedido = @2, NomeCliente = @3, DataEmissão = @4, DataEntrega = @5, AutorizadoPor = @6, Confirmada = @7, Empresa = @8 Where NumeroOF = " & Me.NumeroOF.Text
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.NumeroPedido.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.NomeCliente.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataEmissão.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.DataEntrega.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.AutorizadoPor.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@7", "S"))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@8", CodEmpresa))

        Try
            cmd.ExecuteNonQuery()
            Me.Confirmada.Text = "S"
            MsgBox("Odem de Fabricação Atualizado e Confirmada com sucesso", 64, TituloMsgbox)
            CNN.Close()
        Catch x As Exception
            MsgBox(x.Message)
            Exit Sub
        End Try
        Ação.Desbloquear_Controle(Me, False)
        CNN.Close()

    End Sub
End Class