Imports System.Data.OleDb
Imports System.IO.Ports
Public Class ProdutoComposicaoAdd

    Dim Ação As New TrfGerais

    Public OperationItens As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub

    Private Sub ProdComposicao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ProdComposicao.KeyDown
        
        If e.KeyCode = Keys.F5 Then
            If Me.ProdComposicao.Text = "" Then
                My.Forms.PedidoVendaProcurarProduto.ShowDialog()
                LocalizaProduto()
            End If
        End If

    End Sub

    Private Sub ProdComposicao_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProdComposicao.Validated
        If OperationItens = INS Then
            If Me.ProdComposicao.Text <> "" Then
                LocalizaProduto()
            End If
        End If
    End Sub

    Private Sub EditaIten()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT ProdutoComposicao.Produto, ProdutoComposicao.ProdComposicao, Produtos.Descrição, ProdutoComposicao.QtdUsar FROM Produtos INNER JOIN ProdutoComposicao ON Produtos.CodigoProduto = ProdutoComposicao.ProdComposicao WHERE ProdutoComposicao.ProdComposicao = " & RetornoProcura & " And ProdutoComposicao.Produto = " & My.Forms.Produtos.CodigoProduto.Text


        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.ProdComposicao.Text = DR.Item("ProdComposicao") & ""
            Me.ProdComposicaoDesc.Text = DR.Item("Descrição") & ""
            Me.QtdUsar.Text = FormatNumber(NzZero(DR.Item("QtdUsar")), 4)
        End If

        DR.Close()

        Me.ProdComposicao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.ProdComposicaoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.QtdUsar.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não

        Me.ProdComposicao.Focus()

    End Sub

    Private Sub AddItemPedido_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If OperationItens = UPD Then
            Dim PosX As Double = My.Forms.Produtos.Location.X
            Dim PosY As Double = (My.Forms.Produtos.Location.Y + 390) - Me.Height

            Me.Location = New Point(PosX, PosY)
            EditaIten()
            Me.ProdComposicao.Focus()

        Else
            Ação.LimpaTextBox(Me)

            Dim PosX As Double = My.Forms.Produtos.Location.X
            Dim PosY As Double = (My.Forms.Produtos.Location.Y + 390) - Me.Height

            Me.Location = New Point(PosX, PosY)

            Me.ProdComposicao.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.ProdComposicaoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.QtdUsar.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não

            Me.ProdComposicao.Focus()
        End If
    End Sub
    Private Sub btAdItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdItem.Click

        'Area destinada para as validacoes

        If Me.ProdComposicao.Text = "" Then
            MsgBox("O Produto não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.ProdComposicao.Focus()
            Exit Sub
        ElseIf Me.QtdUsar.Text = "" Then
            MsgBox("A Quantidade não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.QtdUsar.Focus()
            Exit Sub
        End If

        If NzZero(Me.QtdUsar.Text) = 0 Then
            MessageBox.Show("O usuário não pode adicionar um item com quantidade ZERO", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.QtdUsar.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If OperationItens = INS Then
            CNN.Open()
            Dim Sql As String = "INSERT INTO ProdutoComposicao (Produto, ProdComposicao, QtdUsar, Empresa) VALUES (@1, @2, @3, @4)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", My.Forms.Produtos.CodigoProduto.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.ProdComposicao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", NzZero(Me.QtdUsar.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", CodEmpresa))

            Try
                cmd.ExecuteNonQuery()
                OperationItens = INS
                CNN.Close()
                My.Forms.Produtos.EncheListaComposicao()
                Me.ProdComposicao.Focus()
                Ação.LimpaTextBox(Me)


            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
                CNN.Close()
            End Try

        ElseIf OperationItens = UPD Then
            CNN.Open()
            Dim Sql As String = "Update ProdutoComposicao set Produto = @1, ProdComposicao = @2, QtdUsar = @3 Where Produto = " & My.Forms.Produtos.CodigoProduto.Text & " and ProdComposicao = " & Me.ProdComposicao.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", My.Forms.Produtos.CodigoProduto.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.ProdComposicao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", NzZero(Me.QtdUsar.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", CodEmpresa))

            Try
                cmd.ExecuteNonQuery()
                OperationItens = INS
                CNN.Close()
                My.Forms.Produtos.EncheListaComposicao()
                Me.ProdComposicao.Focus()
                Ação.LimpaTextBox(Me)

            Catch x As Exception
                CNN.Close()
                MsgBox(x.Message)
                Exit Sub
            End Try
        End If

        Ação.LimpaTextBox(Me)
        Me.ProdComposicao.Focus()

    End Sub

    Private Sub Qtd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles QtdUsar.Leave
        If Me.QtdUsar.Text = "" Or Me.QtdUsar.Text = 0 Then Me.ProdComposicao.Focus()
    End Sub



    Private Sub CodigoProduto_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ProdComposicao.Validating
        If Me.ProdComposicao.Text <> "" Then
            LocalizaProduto()
        End If
    End Sub


    Private Sub ProdutoComposicaoAdd_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        Dim PosX As Double = My.Forms.Produtos.Location.X
        Dim PosY As Double = (My.Forms.Produtos.Location.Y + 390) - Me.Height

        Me.Location = New Point(PosX, PosY)

    End Sub

    Private Sub PedidoAddItem_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.ProdComposicao.Focus()
    End Sub


    Public Sub LocalizaProduto()
        If Me.ProdComposicao.Text = "" Then
            Exit Sub
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Produtos where CodigoProduto = " & Me.ProdComposicao.Text & "  And Inativo = False and Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows = True Then
            If DR.Item("Tipo") = "5" Then
                MessageBox.Show("Este produto não pode ser adcionado por não ser uma Matéria Prima/Produto, verifique com o Administrador de produção.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Ação.LimpaTextBox(Me)
                Me.ProdComposicao.Focus()
                Exit Sub
            End If
            Me.ProdComposicaoDesc.Text = DR.Item("Descrição") & ""
        Else
            MsgBox("Item não encontrado, verifique....", 64, "Validação de Dados")
            Me.ProdComposicao.Focus()
            CNN.Close()
            Exit Sub
        End If
        CNN.Close()


    End Sub


    Private Sub btProdutoFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btProdutoFind.Click
        If Me.ProdComposicao.Text = "" Then
            My.Forms.PedidoVendaProcurarProduto.ShowDialog()
            LocalizaProduto()
        End If
    End Sub

    Private Sub ProdComposicao_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdComposicao.Leave
        If Me.ProdComposicao.Text = My.Forms.Produtos.CodigoProduto.Text Then
            MessageBox.Show(" Este produto não pode ser usado para ser um item da composição", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Ação.LimpaTextBox(Me)
            Me.ProdComposicao.Focus()
            Exit Sub
        End If
    End Sub
End Class