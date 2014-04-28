Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class CompraCtrPedidoItens


    Dim Ação As New TrfGerais

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Dim CNNITENS As OleDb.OleDbConnection




    Private Sub ValorUnitario_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorUnitario.Leave
        Me.ValorUnitario.Text = FormatNumber(Me.ValorUnitario.Text, 4)

        Me.ValorTotal.Text = FormatNumber(CDbl(Me.ValorUnitario.Text) * CDbl(Me.Qtd.Text), 4)
    End Sub

    Private Sub Produto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Produto.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ProcurarProdutoCtrlPedido.ShowDialog()
        End If
    End Sub

    Private Sub AcharProduto()

        Dim Sql As String = "SELECT * FROM Produtos WHERE CodigoProduto = " & Me.Produto.Text & " AND Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, CNNITENS)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.ProdutoDesc.Text = DR.Item("Descrição") & ""
        Else
            MsgBox("Produto não Identificado, favor verificar.", 64, "Validação de Dados")
            Me.Produto.Clear()
            Me.ProdutoDesc.Clear()
            Exit Sub
        End If
        DR.Close()

    End Sub

    Private Sub CompraCtrPedidoItens_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim PosX As Double = My.Forms.CompraCtrPedido.Location.X + 9
        Dim PosY As Double = My.Forms.CompraCtrPedido.Location.Y + 180
        Me.Location = New Drawing.Point(PosX, PosY)

        Degrade()

        CNNITENS = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNNITENS.Open()

        Me.IdPedido.Text = My.Forms.CompraCtrPedido.Id.Text

        If My.Forms.CompraCtrPedido.EditaItens = True Then
            EntrarEditandoRegistro()
        End If

    End Sub


    Private Sub EntrarEditandoRegistro()
        Dim Sql As String = "SELECT CompraCtrlPedidoItens.Codigo, CompraCtrlPedidoItens.IdPedido, CompraCtrlPedidoItens.Produto, Produtos.Descrição, CompraCtrlPedidoItens.Qtd, CompraCtrlPedidoItens.ValorUnitario, CompraCtrlPedidoItens.ValorTotal FROM CompraCtrlPedidoItens LEFT JOIN Produtos ON CompraCtrlPedidoItens.Produto = Produtos.CodigoProduto WHERE CompraCtrlPedidoItens.Codigo = " & My.Forms.CompraCtrPedido.Codigo.Text

        Dim CMD As New OleDb.OleDbCommand(Sql, CNNITENS)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.Codigo.Text = DR.Item("Codigo") & ""
            Me.Produto.Text = DR.Item("Produto") & ""
            Me.ProdutoDesc.Text = DR.Item("Descrição") & ""
            Me.Qtd.Text = FormatNumber(Nz(DR.Item("Qtd"), 3), 2)
            Me.ValorUnitario.Text = FormatNumber(Nz(DR.Item("ValorUnitario"), 3), 4)
            Me.ValorTotal.Text = FormatNumber(Nz(DR.Item("ValorTotal"), 3), 4)
            Operation = UPD
        Else
            MsgBox("Registro não Identificado, o sistema ira ativar o modo de adição.", 64, "Validação de Dados")
            Me.Produto.Clear()
            Me.ProdutoDesc.Clear()
            Operation = INS
            Exit Sub
        End If
        DR.Close()
    End Sub


    Private Sub Qtd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Qtd.Leave
        Me.Qtd.Text = FormatNumber(Me.Qtd.Text, 3)
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click

        If Me.Produto.Text = "" Then
            MsgBox("O Produto não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Produto.Focus()
            Exit Sub
        ElseIf Me.Qtd.Text = "" Then
            MsgBox("A Quantidade não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Qtd.Focus()
            Exit Sub

        ElseIf Me.ValorUnitario.Text = "" Then
            MsgBox("O valor unitário não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.ValorUnitario.Focus()
            Exit Sub

        ElseIf Me.ValorTotal.Text = "" Then
            MsgBox("O Valor Total não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Qtd.Focus()
            Exit Sub

        End If
        'Fim da Area destinada para as validacoes

        If Operation = INS Then

            UltimoReg()
            Dim Sql As String = "INSERT INTO CompraCtrlPedidoItens (Codigo, IdPedido, Produto, Qtd, ValorUnitario, ValorTotal) VALUES (@1, @2, @3, @4, @5, @6)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNNITENS)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Codigo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.IdPedido.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Produto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Qtd.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.ValorUnitario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.ValorTotal.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                EncheListaItens()
                Ação.CriaLog(UserAtivo, "CompraCtrPedidoItens", "Add: ID " & Me.Codigo.Text & " - Produto: " & Me.Produto.Text, CaminhoLog, DataDia)
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                Operation = INS
                Me.Produto.Clear()
                Me.ProdutoDesc.Clear()
                Me.Qtd.Clear()
                Me.ValorUnitario.Clear()
                Me.ValorTotal.Clear()
                Me.Codigo.Clear()

            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
                Ação.LimpaTextBox(Me)
            End Try
            Ação.Desbloquear_Controle(Me, False)

        ElseIf Operation = UPD Then

            Dim Sql As String = "Update CompraCtrlPedidoItens Set Codigo = @1, IdPedido = @2, Produto = @3, Qtd = @4, ValorUnitario = @5, ValorTotal = @6 Where Codigo = " & Me.Codigo.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNNITENS)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Codigo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.IdPedido.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Produto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Qtd.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.ValorUnitario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.ValorTotal.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                EncheListaItens()
                Ação.CriaLog(UserAtivo, "CompraCtrPedidoItens", "EDD: ID " & Me.Codigo.Text & " - Produto: " & Me.Produto.Text, CaminhoLog, DataDia)
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                Operation = UPD
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, False)
        End If

    End Sub

    Public Sub UltimoReg()
        'Inserir ultimo registro
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader
        Dim Ult As Integer

        With Cmd
            .Connection = CNNITENS
            .CommandTimeout = 0
            .CommandText = "Select max(Codigo) from CompraCtrlPedidoItens"
            .CommandType = CommandType.Text
        End With
        Try

            DR = Cmd.ExecuteReader

            While DR.Read
                If Not IsDBNull(DR.Item(0)) Then
                    'Achou o iten procurado o iten as caixas serão preenchida
                    Ult = DR.Item(0)
                End If
            End While
            DR.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try

        Me.Codigo.Text = Ult + 1
        'fim inserir ultimo registro

    End Sub


    Public Sub EncheListaItens()

        My.Forms.CompraCtrPedido.MyLista.Items.Clear()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        With Cmd
            .Connection = CNNITENS
            .CommandTimeout = 0
            .CommandText = "SELECT CompraCtrlPedidoItens.*, CompraCtrlPedidoItens.IdPedido, Produtos.Descrição FROM CompraCtrlPedidoItens LEFT JOIN Produtos ON CompraCtrlPedidoItens.Produto = Produtos.CodigoProduto WHERE (((CompraCtrlPedidoItens.IdPedido)=" & My.Forms.CompraCtrPedido.Id.Text & "));"
            .CommandType = CommandType.Text
        End With

        Try
            DR = Cmd.ExecuteReader
            Dim Zebrar As Boolean = True
            Dim TT As Double
            While DR.Read
                If Not IsDBNull(DR.Item("Codigo")) Then
                    Dim AA As String = DR.Item("Codigo")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("CompraCtrlPedidoItens.IdPedido") & "")
                    It.SubItems.Add(DR.Item("Produto") & "")
                    It.SubItems.Add(DR.Item("Descrição") & "")
                    It.SubItems.Add(FormatNumber(Nz(DR.Item("Qtd"), 3), 2))

                    It.SubItems.Add(FormatNumber(Nz(DR.Item("ValorUnitario"), 3), 4))
                    It.SubItems.Add(FormatNumber(Nz(DR.Item("ValorTotal"), 3), 4))
                    My.Forms.CompraCtrPedido.MyLista.Items.AddRange(New ListViewItem() {It})

                    TT += Nz(DR.Item("ValorTotal"), 3)

                    If Zebrar = True Then
                        My.Forms.CompraCtrPedido.MyLista.Items.Item(My.Forms.CompraCtrPedido.MyLista.Items.Count() - 1).BackColor = Color.LightSlateGray
                        Zebrar = False
                    Else
                        My.Forms.CompraCtrPedido.MyLista.Items.Item(My.Forms.CompraCtrPedido.MyLista.Items.Count() - 1).BackColor = Color.White
                        Zebrar = True
                    End If

                End If
            End While
            My.Forms.CompraCtrPedido.TTotal.Text = FormatNumber(TT, 2)
            DR.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Exit Sub
        End Try

    End Sub

    Private Sub Produto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Produto.Leave
        AcharProduto()
    End Sub

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        Operation = INS
        Me.Produto.Clear()
        Me.ProdutoDesc.Clear()
        Me.Qtd.Clear()
        Me.ValorUnitario.Clear()
        Me.ValorTotal.Clear()
        Me.Codigo.Clear()

        Me.Produto.Enabled = True
        Me.ProdutoDesc.Enabled = True
        Me.Qtd.Enabled = True
        Me.ValorUnitario.Enabled = True
        Me.ValorTotal.Enabled = True
        Me.Produto.Focus()
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

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        CNNITENS.Close()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub CompraCtrPedidoItens_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        Dim PosX As Double = My.Forms.CompraCtrPedido.Location.X + 9
        Dim PosY As Double = My.Forms.CompraCtrPedido.Location.Y + 180
        Me.Location = New Drawing.Point(PosX, PosY)
    End Sub
End Class