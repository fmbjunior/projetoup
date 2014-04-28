Public Class EstoqueAptoFabrica

    Dim ITENS As Boolean = False

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Private OperationItens As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2


    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub EstoqueAptoFabrica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()

        TravaItensCab(False)
        Me.PainelItens.Enabled = False
    End Sub

    Private Sub NovoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click
        Ação.LimpaTextBox(Me)
        MyLista.Items.Clear()
        TravaItensCab(True)
        Me.PainelItens.Enabled = False
        ITENS = False
        Me.Confirmado.Checked = False
        Me.ConfImg.Visible = False
        Me.AptoId.Text = "0000"
        Me.DataLancamento.Focus()
        Operation = INS
    End Sub

    Private Sub DataLancamento_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataLancamento.Enter
        If Me.DataLancamento.Text = "" Then
            Me.DataLancamento.Text = DataDia
        End If
    End Sub

    Private Sub DataProducao_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataProducao.Enter
        If Me.DataProducao.Text = "" Then
            Me.DataProducao.Text = DataDia
        End If
    End Sub

    Private Sub Usuario_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Usuario.Enter
        If Me.Usuario.Text = "" Then
            Me.Usuario.Text = UserAtivo
        End If
    End Sub

    Private Sub Descricao_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Descricao.Enter
        If Me.Descricao.Text = "" Then Me.Descricao.Text = "Apontamento do dia : " & Me.DataLancamento.Text
    End Sub


    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click

        'Area destinada para as validacoes
        If Me.AptoId.Text = "" Then
            MsgBox("Não foi inicializado um apontamento, favor verificar.", 64, TituloMsgbox)
            Me.AptoId.Focus()
            Exit Sub
        ElseIf Me.DataLancamento.Text = "" Then
            Me.DataLancamento.Text = DataDia
        ElseIf Me.DataProducao.Text = "" Then
            Me.DataProducao.Text = DataDia
        ElseIf Me.Usuario.Text = "" Then
            MsgBox("Não foi informado o usuário do apontamento, favor verificar.", 64, TituloMsgbox)
            Me.Usuario.Focus()
            Exit Sub
        ElseIf Me.Descricao.Text = "" Then
            MsgBox("Não foi informada a descrição, favor verificar.", 64, TituloMsgbox)
            Me.Descricao.Focus()
            Exit Sub
        End If

        If Me.Descricao.Text = "" Then Me.Descricao.Text = "Apontamento estoque fabrica na data " & Me.DataLancamento.Text

        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            UltimoReg()
            Dim Sql As String = "INSERT INTO EstoqueAptoFabrica (AptoId, DataLancamento, DataProducao, Usuario, Descricao, Empresa, ApontarEmpresaControlada) VALUES (@1, @2, @3, @4, @5, @6, @7)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.AptoId.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataLancamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataProducao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Usuario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Descricao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Me.ApontarEmpresaControlada.Checked))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, TituloMsgbox)
                Operation = UPD
                OperationItens = INS
                LimpaItens()
                TravaItensCab(False)
                Me.PainelItens.Enabled = True
                ITENS = True
                Me.Produto.Focus()
            Catch ex As Exception
                MsgBox(ex.Message, 64, TituloMsgbox)
            End Try
            CNN.Close()

        ElseIf Operation = UPD Then
            CNN.Open()

            Dim Sql As String = "Update EstoqueAptoFabrica Set DataLancamento = @2, DataProducao = @3, Usuario = @4, Descricao = @5, Empresa = @6, ApontarEmpresaControlada = @7 Where AptoId = " & Me.AptoId.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataLancamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataProducao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Usuario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Descricao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Me.ApontarEmpresaControlada.Checked))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, TituloMsgbox)
                Operation = UPD
                OperationItens = INS
                TravaItensCab(False)
                ITENS = True
                LimpaItens()
                Me.PainelItens.Enabled = True
                Me.Produto.Focus()
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
        Cnn.Open()

        Dim Cmd As OleDb.OleDbCommand = Cnn.CreateCommand
        Dim DR As OleDb.OleDbDataReader
        Dim Ult As Integer

        Cmd.CommandText = "Select max(AptoId) from EstoqueAptoFabrica"

        Try

            DR = Cmd.ExecuteReader
            While DR.Read
                If Not IsDBNull(DR.Item(0)) Then
                    Ult = DR.Item(0)
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

        Me.AptoId.Text = Ult + 1

    End Sub


    Public Sub LocalizaDados()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from EstoqueAptoFabrica where AptoId = " & Me.AptoId.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        Me.DataLancamento.Text = DR.Item("DataLancamento") & ""
        Me.DataProducao.Text = DR.Item("DataProducao") & ""
        Me.Usuario.Text = DR.Item("Usuario") & ""
        Me.Descricao.Text = DR.Item("Descricao") & ""
        Me.Confirmado.Checked = DR.Item("Confirmado")
        Me.ApontarEmpresaControlada.Checked = DR.Item("ApontarEmpresaControlada")

        If Me.Confirmado.Checked = True Then
            Me.ConfImg.Visible = True
        Else
            Me.ConfImg.Visible = False
        End If



        Operation = UPD
        DR.Close()
    End Sub


    Private Sub TravaItensCab(ByVal Destrava As Boolean)
        Me.AptoId.Enabled = Destrava
        Me.DataLancamento.Enabled = Destrava
        Me.DataProducao.Enabled = Destrava
        Me.Usuario.Enabled = Destrava
        Me.Descricao.Enabled = Destrava
        Me.ApontarEmpresaControlada.Enabled = Destrava
    End Sub

    Private Sub LimpaItens()
        Me.Produto.Clear()
        Me.ProdutoDesc.Clear()
        Me.QtdEntrada.Clear()
    End Sub


    Private Sub EditarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBT.Click
        If Me.Id.Text = "0000" Then
            MsgBox("Não existe apontamento para ser editado.", 64, TituloMsgbox)
            Exit Sub
        End If
        If Me.Id.Text = "" Then
            MsgBox("Não existe apontamento para ser editado.", 64, TituloMsgbox)
            Exit Sub
        End If

        TravaItensCab(True)
        Me.PainelItens.Enabled = False
        Operation = UPD
        Me.AptoId.Focus()
    End Sub

    Private Sub BTAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTAdd.Click
        'Area destinada para as validacoes
        If Me.Produto.Text = "" Then
            MsgBox("Não foi informado o produto, favor verificar.", 64, TituloMsgbox)
            Me.Produto.Focus()
            Exit Sub
        ElseIf Me.QtdEntrada.Text = "" Then
            MsgBox("Não foi informado a Quantidade de Entrada, favor verificar.", 64, TituloMsgbox)
            Me.QtdEntrada.Focus()
            Exit Sub
        End If

        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If OperationItens = INS Then
            CNN.Open()

            UltimoRegItens()
            Dim Sql As String = "INSERT INTO EstoqueAptoFabricaItens (Id, AptoId, Produto, QtdEntrada) VALUES (@1, @2, @3, @4)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Id.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.AptoId.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Produto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.QtdEntrada.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                EncheLista()
                OperationItens = INS
                LimpaItens()
                Me.Produto.Focus()
            Catch ex As Exception
                MsgBox(ex.Message, 64, TituloMsgbox)
                If ConnectionState.Open Then
                    CNN.Close()
                    Exit Sub
                End If
            End Try


        ElseIf OperationItens = UPD Then
            CNN.Open()

            Dim Sql As String = "Update EstoqueAptoFabricaItens Set Produto = @1, QtdEntrada = @2 Where Id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Produto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.QtdEntrada.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                EncheLista()
                OperationItens = INS
                LimpaItens()
                Me.Produto.Focus()
            Catch x As Exception
                MsgBox(x.Message)
                If ConnectionState.Open Then
                    CNN.Close()
                    Exit Sub
                End If
            End Try

        End If

    End Sub

    Public Sub UltimoRegItens()
        'Inserir ultimo registro
        Dim Cnn As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        Cnn.Open()

        Dim Cmd As OleDb.OleDbCommand = Cnn.CreateCommand
        Dim DR As OleDb.OleDbDataReader
        Dim Ult As Integer

        Cmd.CommandText = "Select max(Id) from EstoqueAptoFabricaItens"

        Try

            DR = Cmd.ExecuteReader
            While DR.Read
                If Not IsDBNull(DR.Item(0)) Then
                    Ult = DR.Item(0)
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

        Me.Id.Text = Ult + 1

    End Sub

    Private Sub QtdEntrada_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles QtdEntrada.Leave
        If Me.QtdEntrada.Text = "" Then Me.QtdEntrada.Text = FormatNumber(0, 3)

    End Sub

    Private Sub Produto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Produto.KeyDown
        If e.KeyCode = Keys.F5 Then
            RetornoProcura = ""
            My.Forms.EstoqueFindProdutoFabrica.ShowDialog()
            Me.Produto.Text = RetornoProcura
        End If
    End Sub

    Private Sub Produto_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Produto.Validated
        LocalizaProduto()
    End Sub

    Private Sub LocalizaProduto()
        If Me.Produto.Text = "" Then
            Exit Sub
        End If
        Dim Cnn As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        Cnn.Open()

        Dim Cmd As OleDb.OleDbCommand = Cnn.CreateCommand
        Dim DR As OleDb.OleDbDataReader

        Cmd.CommandText = "Select * from Produtos Where CodigoProduto = " & Me.Produto.Text & " And Empresa = " & CodEmpresa & " And ProdutoIndustria = True"

        DR = Cmd.ExecuteReader
        DR.Read()

        If DR.HasRows = True Then
            Me.ProdutoDesc.Text = DR.Item("Descrição") & ""
        Else
            MsgBox("Este produto não foi encontrado ou não é um produto da Industria.", 64, TituloMsgbox)
            Me.Produto.Clear()
            Me.Produto.Focus()
        End If
        Cnn.Close()

    End Sub

    Private Sub LocalizarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizarBT.Click
        Ação.LimpaTextBox(Me)
        Me.ApontarEmpresaControlada.Checked = False
        ITENS = False
        TravaItensCab(False)
        Me.PainelItens.Enabled = False
        ChamaTelaProcura("Codigo", "Descrição", "", "EstoqueAptoFabrica", "AptoId", "Descricao", "", True)

        Me.AptoId.Text = RetornoProcura
        If Me.AptoId.Text <> "" Then
            LocalizaDados()
            EncheLista()
            Me.DataLancamento.Focus()
        End If
    End Sub


    Public Sub EncheLista()
        If Me.AptoId.Text = "" Then
            Exit Sub
        End If

        MyLista.Items.Clear()

        Dim Cnn As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        Cnn.Open()

        Dim Cmd As OleDb.OleDbCommand = Cnn.CreateCommand
        Dim DR As OleDb.OleDbDataReader

        Cmd.CommandText = "SELECT EstoqueAptoFabricaItens.Id, EstoqueAptoFabricaItens.AptoId, EstoqueAptoFabricaItens.Produto, EstoqueAptoFabricaItens.QtdEntrada, Produtos.Descrição FROM EstoqueAptoFabricaItens INNER JOIN Produtos ON EstoqueAptoFabricaItens.Produto = Produtos.CodigoProduto WHERE (((EstoqueAptoFabricaItens.AptoId)=" & Me.AptoId.Text & "));"

        Try
            DR = Cmd.ExecuteReader

            Dim Zebrar As Boolean = False
            While DR.Read
                If Not IsDBNull(DR.Item("Id")) Then
                    Dim AA As String = DR.Item("Id")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("AptoId"))
                    It.SubItems.Add(DR.Item("Produto") & "")
                    It.SubItems.Add(DR.Item("Descrição") & "")
                    It.SubItems.Add(FormatNumber(Nz(DR.Item("QtdEntrada"), 3), 2))

                    MyLista.Items.AddRange(New ListViewItem() {It})

                    If Zebrar = True Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.MistyRose
                        Zebrar = True
                    End If
                End If
            End While

            DR.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Exit Sub
        End Try

    End Sub

    Private Sub ConfirmarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmarBT.Click
        If Me.AptoId.Text = "" Then
            MsgBox("Não existe apontamento para ser confirmado.", 64, TituloMsgbox)
            Exit Sub
        End If

        If Me.Confirmado.Checked = True Then
            MsgBox("Este apontamento ja foi confirmado, não pode executar esta operação.", 64, TituloMsgbox)
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String


        Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
        Dim cmd As OleDb.OleDbCommand = CNN.CreateCommand
        cmd.Transaction = Transacao

        Try

            'Confirma o Apontamento
            Sql = "UPDATE EstoqueAptoFabrica SET EstoqueAptoFabrica.Confirmado = True WHERE (((EstoqueAptoFabrica.AptoId)=" & Me.AptoId.Text & "));"
            cmd.CommandText = Sql
            cmd.ExecuteNonQuery()


            If Me.ApontarEmpresaControlada.Checked = False Then
                'Acrecenta Itens ao estoque na Tabela de Estoque da Fabrica
                Sql = "INSERT INTO EstoqueEFocusFabrica ( IdLancamento, CodigoProduto, EstPatio, EstEmpresa, Prg, DataLancamento, DataProducao ) SELECT EstoqueAptoFabrica.AptoId, EstoqueAptoFabricaItens.Produto, EstoqueAptoFabricaItens.QtdEntrada AS NoPatio, EstoqueAptoFabricaItens.QtdEntrada AS NaEmpresa, 'APONTAMENTO' AS PRG, EstoqueAptoFabrica.DataLancamento, EstoqueAptoFabrica.DataProducao FROM (EstoqueAptoFabricaItens INNER JOIN EstoqueAptoFabrica ON EstoqueAptoFabricaItens.AptoId = EstoqueAptoFabrica.AptoId) INNER JOIN Produtos ON EstoqueAptoFabricaItens.Produto = Produtos.CodigoProduto WHERE (((EstoqueAptoFabrica.AptoId)=" & Me.AptoId.Text & ") AND ((Produtos.ProdutoIndustria)=True));"
                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()

                'Acrecenta Itens a Tabela Produto
                Sql = "UPDATE EstoqueAptoFabricaItens INNER JOIN Produtos ON EstoqueAptoFabricaItens.Produto = Produtos.CodigoProduto SET Produtos.EstEmpresa = [EstEmpresa]+[QtdEntrada], Produtos.EstPatio = [EstPatio]+[QtdEntrada] WHERE (((EstoqueAptoFabricaItens.AptoId)=" & Me.AptoId.Text & ") AND ((Produtos.ProdutoIndustria)=True));"
                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()
            Else
                'Acrecenta Itens ao estoque na Tabela de Estoque da Fabrica
                Sql = "INSERT INTO EstoqueEFocusFabrica ( IdLancamento, CodigoProduto, EstEmpresaControlada, EstEmpresa, Prg, DataLancamento, DataProducao ) SELECT EstoqueAptoFabrica.AptoId, EstoqueAptoFabricaItens.Produto, EstoqueAptoFabricaItens.QtdEntrada AS NaControlada, [QtdEntrada]*-1 AS NaEmpresa, 'APONTAMENTO' AS PRG, EstoqueAptoFabrica.DataLancamento, EstoqueAptoFabrica.DataProducao FROM (EstoqueAptoFabricaItens INNER JOIN EstoqueAptoFabrica ON EstoqueAptoFabricaItens.AptoId = EstoqueAptoFabrica.AptoId) INNER JOIN Produtos ON EstoqueAptoFabricaItens.Produto = Produtos.CodigoProduto WHERE (((EstoqueAptoFabrica.AptoId)=" & Me.AptoId.Text & ") AND ((Produtos.ProdutoIndustria)=True));"
                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()

                'Acrecenta Itens a Tabela Produto
                Sql = "UPDATE EstoqueAptoFabricaItens INNER JOIN Produtos ON EstoqueAptoFabricaItens.Produto = Produtos.CodigoProduto SET Produtos.EstEmpresa = [EstEmpresa]-[QtdEntrada], Produtos.EstEmpresaControlada = [EstEmpresaControlada]+[QtdEntrada] WHERE (((EstoqueAptoFabricaItens.AptoId)=" & Me.AptoId.Text & ") AND ((Produtos.ProdutoIndustria)=True));"
                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()
            End If

            Transacao.Commit()
            Me.PainelItens.Enabled = False
            Me.Confirmado.Checked = True
            Me.ConfImg.Visible = True
            MsgBox("Apontamento Confirmado com Sucesso.", 64, TituloMsgbox)
            CNN.Close()


        Catch ex As Exception
            Transacao.Rollback()
            CNN.Close()
            MsgBox(ex.Message, 64, TituloMsgbox)
            MsgBox("Erro ao confirmar o Apontamento, tente confirmar novamente ou consulte o administrador.", 64, TituloMsgbox)
            Exit Sub
        End Try


    End Sub


    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick

        If ITENS = False Then
            MsgBox("O usuário não esta no modo de edição dos itens, salva o registro para editar os itens.", 64, TituloMsgbox)
            Exit Sub
        End If
        Dim I As Integer = 0

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then Me.Id.Text = MyLista.Items(I).Text.Substring(0)
            If MyLista.Items(I).Selected = True Then Me.Produto.Text = MyLista.Items(I).SubItems(2).Text.Substring(0)
            If MyLista.Items(I).Selected = True Then Me.ProdutoDesc.Text = MyLista.Items(I).SubItems(3).Text.Substring(0)
            If MyLista.Items(I).Selected = True Then Me.QtdEntrada.Text = FormatNumber(MyLista.Items(I).SubItems(4).Text.Substring(0), 3)
        Next
        OperationItens = UPD
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

    Private Sub AtEstBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtEstBt.Click
        Dim HH As DateTime = Now
        Dim CodSegurança As String = InputBox("Favor informar o Código de Segurança.", TituloMsgbox, 0)

        If VerificaCodigoSegurança(CodSegurança) = False Then
            MsgBox("Código de Segurança inválido, Verifique.", 64, TituloMsgbox)
            Exit Sub
        Else

            Me.Cursor = Cursors.WaitCursor
            Dim Cnn1 As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
            Cnn1.Open()

            Dim DS As New DataSet()

            Dim Sql As String = String.Empty

            Sql = "SELECT EstoqueEFocusFabrica.CodigoProduto, Sum(EstoqueEFocusFabrica.EstPatio) AS SomaDeEstPatio, Sum(EstoqueEFocusFabrica.EstEmpresa) AS SomaDeEstEmpresa, Sum(EstoqueEFocusFabrica.EstEmpresaControlada) AS SomaDeEstEmpresaControlada FROM(EstoqueEFocusFabrica) GROUP BY EstoqueEFocusFabrica.CodigoProduto;"
            Dim DAEstoqueFabrica As New OleDb.OleDbDataAdapter(Sql, Cnn1)
            DAEstoqueFabrica.Fill(DS, "EstoqueFabrica")


            Sql = "SELECT * From Produtos"
            Dim DAProdutos As New OleDb.OleDbDataAdapter(Sql, Cnn1)
            DAProdutos.Fill(DS, "Produtos")


            Try

                Dim DrItenEstoque As DataRow
                For Each DrItenEstoque In DS.Tables("EstoqueFabrica").Rows
                    Dim DRProduto() As DataRow
                    DRProduto = DS.Tables("Produtos").Select("CodigoProduto = " & DrItenEstoque("CodigoProduto"))

                    If DRProduto.Length = 0 Then
                        ' aqui nada a fazer pois nao incluiremos nada
                    Else

                        DRProduto(0).BeginEdit()
                        DRProduto(0)("EstPatio") = DrItenEstoque("SomaDeEstPatio")
                        DRProduto(0)("EstEmpresa") = DrItenEstoque("SomaDeEstEmpresa")
                        DRProduto(0)("EstEmpresaControlada") = DrItenEstoque("SomaDeEstEmpresaControlada")
                        DRProduto(0).EndEdit()
                    End If
                Next

            Catch AA As Exception
                MsgBox(AA.Message)
                DS.Dispose()
                Cnn1.Close()
                Me.Cursor = Cursors.Default
            End Try

            Try
                Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAProdutos)
                DAProdutos.Update(DS, "Produtos")
            Catch ex As Exception
                MsgBox(ex.Message)
                DS.Dispose()
                Cnn1.Close()
                Me.Cursor = Cursors.Default
            End Try

            DS.Dispose()
            Cnn1.Close()

            MsgBox("Atualização realizada com sucesso.", 64, TituloMsgbox)
            Me.Cursor = Cursors.Default
        End If
    End Sub
End Class