Public Class PedidoAcompanhamento

    Dim Ação As New TrfGerais

    Dim CNN As OleDb.OleDbConnection

    Private mMenuCFG As New System.Windows.Forms.ContextMenu()

    Dim AcpN As Integer

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Private Sub AcpNumber()
        If Me.Status.Text = "INICIADO" Then AcpN = 0
        If Me.Status.Text = "EM PRODUÇÃO" Then AcpN = 1
        If Me.Status.Text = "FABRICADO" Then AcpN = 2
        If Me.Status.Text = "EXECUÇÃO" Then AcpN = 3
        If Me.Status.Text = "FINALIZADO" Then AcpN = 4
        If Me.Status.Text = "FATURADO" Then AcpN = 5

    End Sub

    Private Sub CriaMenuContexto()
        'Criar Menus de Configuração
        Me.Acompanhamento.ContextMenu = mMenuCFG

        mMenuCFG.MenuItems.Add("INICIADO", New EventHandler(AddressOf MenuCFG_Click))
        mMenuCFG.MenuItems.Add("EM PRODUÇÃO", New EventHandler(AddressOf MenuCFG_Click))
        mMenuCFG.MenuItems.Add("FABRICADO", New EventHandler(AddressOf MenuCFG_Click))
        mMenuCFG.MenuItems.Add("EXECUÇÃO", New EventHandler(AddressOf MenuCFG_Click))
        mMenuCFG.MenuItems.Add("FINALIZADO", New EventHandler(AddressOf MenuCFG_Click))
        mMenuCFG.MenuItems.Add("FATURADO", New EventHandler(AddressOf MenuCFG_Click))

        'Fim Criar menus de Configuração
    End Sub

    Private Sub MenuCFG_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim Acp_N_Atual As Integer
        If CType(sender, MenuItem).Text = "INICIADO" Then Acp_N_Atual = 0
        If CType(sender, MenuItem).Text = "EM PRODUÇÃO" Then Acp_N_Atual = 1
        If CType(sender, MenuItem).Text = "FABRICADO" Then Acp_N_Atual = 2
        If CType(sender, MenuItem).Text = "EXECUÇÃO" Then Acp_N_Atual = 3
        If CType(sender, MenuItem).Text = "FINALIZADO" Then Acp_N_Atual = 4
        If CType(sender, MenuItem).Text = "FATURADO" Then Acp_N_Atual = 5

        If Acp_N_Atual < AcpN Then
            MsgBox("O usuário não pode definir para um status menor do que o atual, verifique...", 64, "Validação de Dados")
            Exit Sub
        End If

        If Acp_N_Atual = AcpN Then
            MsgBox("O status ja foi definido para este pedido", 64, "Validação de Dados")
            Exit Sub
        End If

        If MsgBox("Deseja realmente alterar o status do pedido.", 36, "Validação de Dados") = 6 Then

            Me.Status.Text = CType(sender, MenuItem).Text
            Me.Acompanhamento.Text = Me.Status.Text

            'Adicionar Historico de Mudança de Status
            Dim Sql As String = "INSERT INTO PedidoAcompanhamentoDetalhe (Pedido, Sequencia, DataLancamento, Usuario, Historico, LancInterno) VALUES (@1, @2, @3, @4, @5, @6)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Pedido.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", UltimoRegItens))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", DataDia))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", UserAtivo))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", "MUDANÇA DE STATUS PARA " & CType(sender, MenuItem).Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", True))

            Try
                cmd.ExecuteNonQuery()
                SalvarBT_Click(sender, e)
                EncheLista()
                AcpNumber()
                MsgBox("Status do Pedido alterado com sucesso", 64, "Validação de Dados")
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try

            'Fim do Historico e mudança de status
        End If
    End Sub

    Public Function UltimoRegItens()
        'Inserir ultimo registro

        Dim sql As String = "Select max(Sequencia) from PedidoAcompanhamentoDetalhe Where Pedido = " & Me.Pedido.Text
        Dim Cmd As New OleDb.OleDbCommand(sql, CNN)
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer

        Try
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
            Return 1
            Exit Function
        End Try

        Return Ult + 1
        'fim inserir ultimo registro
    End Function

    Private Sub PedidoAcompanhamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        TeclasAtalho(sender, e)
    End Sub

    Private Sub PedidoAcompanhamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()
        CNN = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        CriaMenuContexto()
        Me.Acompanhamento.Text = "Acp Pedido"
    End Sub

    Public Sub EncheLista()

        If Me.Pedido.Text = "" Then Exit Sub

        MyLista.Items.Clear()

        Dim Sql As String = "SELECT * FROM PedidoAcompanhamentoDetalhe WHERE Pedido = " & Me.Pedido.Text & " Order by Sequencia"
        Dim Cmd As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        Try
            DR = Cmd.ExecuteReader
            Dim Zebrar As Boolean = True
            While DR.Read
                If Not IsDBNull(DR.Item("Pedido")) Then
                    Dim AA As String = DR.Item("Pedido")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("Sequencia") & "")
                    It.SubItems.Add(DR.Item("DataLancamento") & "")
                    It.SubItems.Add(DR.Item("Usuario") & "")
                    It.SubItems.Add(DR.Item("Historico") & "")
                    It.SubItems.Add(DR.Item("LancInterno"))

                    MyLista.Items.AddRange(New ListViewItem() {It})
                End If

                If Zebrar = True Then
                    MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                    Zebrar = False
                Else
                    MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.MistyRose
                    Zebrar = True
                End If

            End While

            DR.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Exit Sub
        End Try

    End Sub

    Private Sub AddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddItem.Click

        If Me.Pedido.Text = "" Then
            Exit Sub
        End If

        If Me.Status.Text = "Finalizado" Then
            MsgBox("Não pode editar o pedido finalizado, selecione outro.", 64, "Validação de Dados")
            Exit Sub
        End If

        MultiEmpresa = True
        My.Forms.PedidoAcompanhamentoDetalhe.ShowDialog()
    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick

        If Me.Status.Text = "Finalizado" Then
            MsgBox("Não pode editar o pedido finalizado, selecione outro.", 64, "Validação de Dados")
            Exit Sub
        End If


        Dim I As Integer = 0

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then Me.IdItem.Text = (MyLista.Items(I).SubItems(1).Text.Substring(0))
        Next

        My.Forms.PedidoAcompanhamentoDetalhe.ShowDialog()

    End Sub

    Private Sub NovoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click
        Ação.LimpaTextBox(Me)
        MyLista.Items.Clear()

        Dim PedidoStr As Integer
        Try
            PedidoStr = InputBox("Favor informar o PEDIDO para criar o acompanhamento.", "Validação de Dados", 0)
        Catch ex As Exception
            Exit Sub
        End Try

        If PedidoStr = 0 Then
            MsgBox("O pedido informado foi o Zero, não pode criar acompanhamento.", 64, "Validação de Dados")
            Exit Sub
        End If

        Dim JaCadastrado As Boolean
        Me.Pedido.Text = PedidoStr
        JaCadastrado = TemValor("Pedido", "PedidoAcompanhamento", Me.Pedido.Text, False, True)

        If JaCadastrado = True Then
            MsgBox("Este pedido ja foi cadastrado, não pode cria um novo.", 64, "Validação de Dados")
            Me.Pedido.Clear()
            Exit Sub
        End If

        Dim Sql As String = "SELECT Pedido.PedidoSequencia, Pedido.CódigoCliente, Clientes.Nome, Clientes.CpfCgc, Clientes.Insc, Clientes.Cidade, Clientes.Estado, Clientes.Telefone, Pedido.Empresa, Pedido.Inativo, Pedido.Confirmado FROM Pedido INNER JOIN Clientes ON Pedido.CódigoCliente = Clientes.Codigo WHERE (((Pedido.PedidoSequencia)= " & PedidoStr & ") AND ((Pedido.Empresa)= " & CodEmpresa & ") AND ((Pedido.Inativo)=False) AND ((Pedido.Confirmado)=True));"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.Pedido.Text = DR.Item("PedidoSequencia") & ""
            Me.Cliente.Text = DR.Item("CódigoCliente") & ""
            Me.ClienteNome.Text = DR.Item("Nome") & ""
            Me.Cnpj.Text = DR.Item("CpfCgc") & ""
            Me.Ie.Text = DR.Item("Insc") & ""
            Me.CidadeEstado.Text = DR.Item("Cidade") & "-" & DR.Item("Estado")
            Me.Telefone.Text = DR.Item("Telefone") & ""
            Me.Status.Text = "INICIADO"
            Me.Acompanhamento.Text = Me.Status.Text
        Else
            MsgBox("O Pedido Informado não foi localizado, ou não foi confirmado, verifique....", 64, "Validação de Dados")
        End If
        DR.Close()

        Operation = INS

        SalvarBT_Click(sender, e)
        AcpNumber()

    End Sub

    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click
        'Area destinada para as validacoes
        If Me.Pedido.Text = "" Then
            MsgBox("O Código do Pedido não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Pedido.Focus()
            Exit Sub
        ElseIf Me.Cliente.Text = "" Then
            MsgBox("O Cliente não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Cliente.Focus()
            Exit Sub
        End If

        If Me.Status.Text = "" Then
            Me.Status.Text = "Em Produção"
            Me.Acompanhamento.Text = "Em Produção"
        End If
        'Fim da Area destinada para as validacoes

        If Operation = INS Then

            Dim Sql As String = "INSERT INTO PedidoAcompanhamento (Pedido, Cliente, Status, Empresa) VALUES (@1, @2, @3, @4)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Pedido.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Cliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Status.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", CodEmpresa))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            Ação.Desbloquear_Controle(Me, False)

        ElseIf Operation = UPD Then

            Dim Sql As String = "Update PedidoAcompanhamento set Pedido = @1, Cliente = @2, Status = @3, Empresa = @4 Where Pedido = " & Me.Pedido.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Pedido.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Cliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Status.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", CodEmpresa))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, False)
        End If

    End Sub

    Private Sub LocalizarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizarBT.Click
        MultiEmpresa = True
        My.Forms.PedidoAcompanhamentoProcura.ShowDialog()

        If Me.Pedido.Text = "" Then
            Exit Sub
        End If

        Operation = UPD

        Dim Sql As String = "SELECT PedidoAcompanhamento.Pedido, PedidoAcompanhamento.Cliente, Clientes.Nome, Clientes.CpfCgc, Clientes.Insc, Clientes.Cidade, Clientes.Estado, Clientes.Telefone, PedidoAcompanhamento.Status, PedidoAcompanhamento.Empresa, PedidoAcompanhamento.Inativo FROM PedidoAcompanhamento INNER JOIN Clientes ON PedidoAcompanhamento.Cliente = Clientes.Codigo WHERE (((PedidoAcompanhamento.Pedido)=" & Me.Pedido.Text & ") AND ((PedidoAcompanhamento.Empresa)=" & CodEmpresa & ") AND ((PedidoAcompanhamento.Inativo)=False));"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.Pedido.Text = DR.Item("Pedido") & ""
            Me.Cliente.Text = DR.Item("Cliente") & ""
            Me.ClienteNome.Text = DR.Item("Nome") & ""
            Me.Cnpj.Text = DR.Item("CpfCgc") & ""
            Me.Ie.Text = DR.Item("Insc") & ""
            Me.CidadeEstado.Text = DR.Item("Cidade") & "-" & DR.Item("Estado")
            Me.Telefone.Text = DR.Item("Telefone") & ""
            Me.Status.Text = DR.Item("Status") & ""
            Me.Acompanhamento.Text = Me.Status.Text
        End If
        DR.Close()
        EncheLista()
        AcpNumber()
    End Sub

    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        CNN.Close()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ImprimirBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirBT.Click
        If Me.Pedido.Text = "" Then
            Exit Sub
        End If

        RelatorioCarregar = "RelPedidoAcompanhamento"
        My.Forms.VisualizadorRelatorio.ShowDialog()
    End Sub

    
    Private Sub ExcluirBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirBT.Click
        MsgBox("Opção indisponivel, verifique com o administrador.", 64, "Validação de Dados")
    End Sub

    Private Sub TeclasAtalho(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.F7 Then
            LocalizarBT_Click(sender, e)
        End If

        If e.KeyCode = Keys.F8 Then
            ExcluirBT_Click(sender, e)
        End If

        If e.KeyCode = Keys.F9 Then
            NovoBT_Click(sender, e)
        End If

        If e.KeyCode = Keys.F10 Then
            SalvarBT_Click(sender, e)
        End If

        If e.KeyCode = Keys.F11 Then
            EditarBT_Click(sender, e)
        End If

        If e.KeyCode = Keys.F12 Then
            FecharBT_Click(sender, e)
        End If

    End Sub

    Private Sub EditarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBT.Click
        MsgBox("Opção indisponivel, verifique com o Administrador.", 64, "Validação de Dados")
        Exit Sub
    End Sub

    Private Sub Degrade()
        Try
            Dim CCor() As String
            Dim corTemp As String

            corTemp = Cor1TelaPrimaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))

            corTemp = Cor2TelaPrimaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))
        Catch ex As Exception
        End Try
    End Sub
End Class