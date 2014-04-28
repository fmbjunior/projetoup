Public Class EstoqueAptoFabricaTransf

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Private OperationItens As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2


    Private Sub EstoqueAptoFabricaTransf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()
        Ação.Desbloquear_Controle(Me, False)
    End Sub

    Private Sub NovoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click
        Ação.Desbloquear_Controle(Me, True)
        Ação.LimpaTextBox(Me)
        Me.ID.Text = "0000"
        Me.Confirmado.Checked = False
        Operation = INS
    End Sub

    Private Sub EditarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBT.Click
        Ação.Desbloquear_Controle(Me, True)
        Operation = UPD
        Me.ID.Focus()
    End Sub

    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ProdutoOrigem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ProdutoOrigem.KeyDown
        If e.KeyCode = Keys.F5 Then
            RetornoProcura = ""
            My.Forms.EstoqueFindProdutoFabrica.ShowDialog()
            Me.ProdutoOrigem.Text = RetornoProcura
        End If
    End Sub

    Private Sub ProdutoDestino_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ProdutoDestino.KeyDown
        If e.KeyCode = Keys.F5 Then
            RetornoProcura = ""
            My.Forms.EstoqueFindProdutoFabrica.ShowDialog()
            Me.ProdutoDestino.Text = RetornoProcura
        End If
    End Sub

    Private Sub LocalizaProduto(ByVal CampoProcurar As Control, ByVal DestinoRetorno As Control)
        If CampoProcurar.Text = "" Then
            Exit Sub
        End If

        Dim Cnn As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        Cnn.Open()

        Dim Cmd As OleDb.OleDbCommand = Cnn.CreateCommand
        Dim DR As OleDb.OleDbDataReader

        Cmd.CommandText = "Select * from Produtos Where CodigoProduto = " & CampoProcurar.Text & " And Empresa = " & CodEmpresa & " And ProdutoIndustria = True"

        DR = Cmd.ExecuteReader
        DR.Read()

        If DR.HasRows = True Then
            DestinoRetorno.Text = DR.Item("Descrição") & ""
        Else
            MsgBox("Este produto não foi encontrado ou não é um produto da Industria.", 64, TituloMsgbox)
            CampoProcurar.Text = ""
            CampoProcurar.Focus()
        End If
        Cnn.Close()

    End Sub

    Private Sub ProdutoOrigem_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProdutoOrigem.Validated
        LocalizaProduto(Me.ProdutoOrigem, Me.ProdutoOrigemDesc)
    End Sub

    Private Sub ProdutoDestino_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProdutoDestino.Validated
        LocalizaProduto(Me.ProdutoDestino, Me.ProdutoDestinoDesc)
    End Sub

    Private Sub Usuario_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Usuario.Enter
        If Me.Usuario.Text = "" Then Me.Usuario.Text = UserAtivo
    End Sub

    Private Sub DataLancamento_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataLancamento.Enter
        If Me.DataLancamento.Text = "" Then Me.DataLancamento.Text = DataDia
    End Sub

    Private Sub DescTransferencia_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DescTransferencia.Enter
        If Me.DescTransferencia.Text = "" Then
            Me.DescTransferencia.Text = "Transf. Prod " & Me.ProdutoOrigem.Text & " para " & Me.ProdutoDestino.Text & " feita no dia : " & Me.DataLancamento.Text
        End If
    End Sub

    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click
        'Area destinada para as validacoes
        If Me.DataLancamento.Text = "" Then
            Me.DataLancamento.Text = DataDia
        ElseIf Me.ProdutoOrigem.Text = "" Then
            MsgBox("Não foi informado o produto de origem, favor verificar.", 64, TituloMsgbox)
            Me.ProdutoOrigem.Focus()
            Exit Sub
        ElseIf Me.ProdutoDestino.Text = "" Then
            MsgBox("Não foi informado o produto de destino, favor verificar.", 64, TituloMsgbox)
            Me.ProdutoDestino.Focus()
            Exit Sub
        ElseIf Me.Qtd.Text = "" Then
            MsgBox("Não foi informada a Quantidade, favor verificar.", 64, TituloMsgbox)
            Me.Qtd.Focus()
            Exit Sub
        ElseIf Me.DescTransferencia.Text = "" Then
            MsgBox("Não foi informada a descrição, favor verificar.", 64, TituloMsgbox)
            Me.DescTransferencia.Focus()
            Exit Sub
        ElseIf Me.Usuario.Text = "" Then
            MsgBox("Não foi informado o usuário, favor verificar.", 64, TituloMsgbox)
            Me.Usuario.Focus()
            Exit Sub
        End If

        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            UltimoReg()
            Dim Sql As String = "INSERT INTO EstoqueAptoFabricaTransferencia (Id, DataLancamento, ProdutoOrigem, ProdutoDestino, Usuario, DescTransferencia, Empresa, Qtd) VALUES (@1, @2, @3, @4, @5, @6, @7, @8)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.ID.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataLancamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.ProdutoOrigem.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ProdutoDestino.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Usuario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.DescTransferencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Qtd.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, TituloMsgbox)
                Operation = UPD
            Catch ex As Exception
                MsgBox(ex.Message, 64, TituloMsgbox)
            End Try
            CNN.Close()

        ElseIf Operation = UPD Then
            CNN.Open()

            Dim Sql As String = "Update EstoqueAptoFabricaTransferencia Set DataLancamento = @2, ProdutoOrigem = @3, ProdutoDestino = @4, Usuario = @5, DescTransferencia = @6, Empresa = @7, Qtd = @8 Where Id = " & Me.ID.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            'cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.ID.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataLancamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.ProdutoOrigem.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ProdutoDestino.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Usuario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.DescTransferencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Qtd.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, TituloMsgbox)
                Operation = UPD
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

        Cmd.CommandText = "Select max(Id) from EstoqueAptoFabricaTransferencia"

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

        Me.ID.Text = Ult + 1

    End Sub

    Private Sub LocalizarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizarBT.Click
        ChamaTelaProcura("Codigo", "Descrição", "", "EstoqueAptoFabricaTransferencia", "Id", "DescTransferencia", "", True)

        Me.ID.Text = RetornoProcura
        If Me.ID.Text <> "" Then
            LocalizaDados()
            Me.DataLancamento.Focus()
        End If
    End Sub

    Public Sub LocalizaDados()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT EstoqueAptoFabricaTransferencia.*, Produtos.Descrição, Produtos_1.Descrição, EstoqueAptoFabricaTransferencia.Id FROM (EstoqueAptoFabricaTransferencia LEFT JOIN Produtos ON EstoqueAptoFabricaTransferencia.ProdutoOrigem = Produtos.CodigoProduto) LEFT JOIN Produtos AS Produtos_1 ON EstoqueAptoFabricaTransferencia.ProdutoDestino = Produtos_1.CodigoProduto WHERE (((EstoqueAptoFabricaTransferencia.Id)=" & Me.ID.Text & "));"
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        Me.DataLancamento.Text = DR.Item("DataLancamento") & ""
        Me.ProdutoOrigem.Text = DR.Item("ProdutoOrigem") & ""
        Me.ProdutoOrigemDesc.Text = DR.Item("Produtos.Descrição") & ""
        Me.ProdutoDestino.Text = DR.Item("ProdutoDestino") & ""
        Me.ProdutoDestinoDesc.Text = DR.Item("Produtos_1.Descrição") & ""
        Me.Usuario.Text = DR.Item("Usuario") & ""
        Me.DescTransferencia.Text = DR.Item("DescTransferencia") & ""
        Me.Confirmado.Checked = DR.Item("Confirmado")
        Me.Qtd.Text = FormatNumber(Nz(DR.Item("Qtd"), 3), 3)

        If Me.Confirmado.Checked = True Then
            Me.ConfImg.Visible = True
        Else
            Me.ConfImg.Visible = False
        End If


        Operation = UPD
        DR.Close()
    End Sub

    Private Sub ConfirmarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmarBT.Click
        If Me.ID.Text = "" Then
            MsgBox("Não existe transf. para confirmar, favor verificar.", 64, TituloMsgbox)
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
            Sql = "UPDATE EstoqueAptoFabricaTransferencia SET EstoqueAptoFabricaTransferencia.Confirmado = True WHERE (((EstoqueAptoFabricaTransferencia.Id)=" & Me.ID.Text & "));"
            cmd.CommandText = Sql
            cmd.ExecuteNonQuery()

            Sql = "INSERT INTO EstoqueEFocusFabrica ( CodigoProduto, EstPatio, EstEmpresa, IdLancamento, Prg, DataLancamento ) SELECT EstoqueAptoFabricaTransferencia.ProdutoOrigem, [Qtd]*-1 AS EstPatio, [Qtd]*-1 AS EstEmpresa, EstoqueAptoFabricaTransferencia.Id, 'TRANF' AS Prg, EstoqueAptoFabricaTransferencia.DataLancamento FROM Produtos INNER JOIN EstoqueAptoFabricaTransferencia ON Produtos.CodigoProduto = EstoqueAptoFabricaTransferencia.ProdutoOrigem WHERE (((EstoqueAptoFabricaTransferencia.Id)=" & Me.ID.Text & ") AND ((Produtos.ProdutoIndustria)=True));"
            cmd.CommandText = Sql
            cmd.ExecuteNonQuery()

            Sql = "INSERT INTO EstoqueEFocusFabrica ( CodigoProduto, EstPatio, EstEmpresa, IdLancamento, Prg, DataLancamento ) SELECT EstoqueAptoFabricaTransferencia.ProdutoDestino, EstoqueAptoFabricaTransferencia.Qtd AS EstPatio, EstoqueAptoFabricaTransferencia.Qtd AS EstEmpresa, EstoqueAptoFabricaTransferencia.Id, 'TRANF' AS Prg, EstoqueAptoFabricaTransferencia.DataLancamento FROM EstoqueAptoFabricaTransferencia INNER JOIN Produtos ON EstoqueAptoFabricaTransferencia.ProdutoDestino = Produtos.CodigoProduto WHERE (((EstoqueAptoFabricaTransferencia.Id)=" & Me.ID.Text & ") AND ((Produtos.ProdutoIndustria)=True));"
            cmd.CommandText = Sql
            cmd.ExecuteNonQuery()

            Sql = "UPDATE Produtos INNER JOIN EstoqueAptoFabricaTransferencia ON Produtos.CodigoProduto = EstoqueAptoFabricaTransferencia.ProdutoOrigem SET Produtos.EstPatio = [EstPatio]-[Qtd], Produtos.EstEmpresa = [EstEmpresa]-[Qtd] WHERE (((EstoqueAptoFabricaTransferencia.Id)=" & Me.ID.Text & ") AND ((Produtos.ProdutoIndustria)=True));"
            cmd.CommandText = Sql
            cmd.ExecuteNonQuery()

            Sql = "UPDATE Produtos INNER JOIN EstoqueAptoFabricaTransferencia ON Produtos.CodigoProduto = EstoqueAptoFabricaTransferencia.ProdutoDestino SET Produtos.EstPatio = [EstPatio]+[Qtd], Produtos.EstEmpresa = [EstEmpresa]+[Qtd] WHERE (((EstoqueAptoFabricaTransferencia.Id)=" & Me.ID.Text & ") AND ((Produtos.ProdutoIndustria)=True));"
            cmd.CommandText = Sql
            cmd.ExecuteNonQuery()


            Transacao.Commit()
            Me.Confirmado.Checked = True
            Me.ConfImg.Visible = True
            MsgBox("Transferência Confirmado com Sucesso.", 64, TituloMsgbox)
            CNN.Close()


        Catch ex As Exception
            Transacao.Rollback()
            CNN.Close()
            MsgBox(ex.Message, 64, TituloMsgbox)
            MsgBox("Erro ao confirmar o Apontamento, tente confirmar novamente ou consulte o administrador.", 64, TituloMsgbox)
            Exit Sub
        End Try


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