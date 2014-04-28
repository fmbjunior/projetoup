Public Class OrdemFabricaçãoItens
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

    Private Sub Salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salvar.Click
        'Area destinada para as validacoes
        If Me.Produto.Text = "" Then
            MsgBox("O Código da Matéria Prima para o item da Sub Composição não foi informado, favor verificar.", 64, TituloMsgbox)
            Me.Produto.Focus()
            Exit Sub
        ElseIf Me.Qtd.Text = "" Then
            MsgBox("A Quantidade de Matéria Prima para o item da Sub Composição não foi informado, favor verificar.", 64, TituloMsgbox)
            Me.Qtd.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            Dim Sql As String = "INSERT INTO OrdemFabricaçãoItens (NumeroOF, Produto, Qtd, Produzido) VALUES (@1, @2, @3, @4)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", My.Forms.OrdemFabricação.NumeroOF.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Produto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Qtd.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", 0))

            Try
                cmd.ExecuteNonQuery()
                CriaLog(UserAtivo, "OrdemFabricacaoItens", "Adicionou: na Ordem " & My.Forms.OrdemFabricação.NumeroOF.Text & " o produto " & Me.Produto.Text & "-" & Me.Descrição.Text)
                Ação.Desbloquear_Controle(Me, False)
                CNN.Close()
                My.Forms.OrdemFabricação.EncheListaItens()
            Catch ex As Exception
                MsgBox(ex.Message, 64, TituloMsgbox)
            End Try

        ElseIf Operation = UPD Then

            CNN.Open()

            Dim Sql As String = "Update OrdemFabricaçãoItens set NumeroOF = @1, Produto = @2, Qtd = @3 Where NumeroOF = " & My.Forms.OrdemFabricação.NumeroOF.Text & " And Produto = " & Me.Produto.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", My.Forms.OrdemFabricação.NumeroOF.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Produto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Qtd.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                CriaLog(UserAtivo, "OrdemFabricacaoItens", "Editou: na Ordem " & My.Forms.OrdemFabricação.NumeroOF.Text & " o produto " & Me.Produto.Text & "-" & Me.Descrição.Text)
                Ação.Desbloquear_Controle(Me, False)
                CNN.Close()
                My.Forms.OrdemFabricação.EncheListaItens()
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try

        End If

    End Sub


    Private Sub OrdemFabricaçãoItens_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(My.Forms.OrdemFabricação.Location.X, My.Forms.OrdemFabricação.Location.Y)
        VerificarEdição()
    End Sub

    Private Sub OrdemFabricaçãoItens_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        Me.Location = New Point(My.Forms.OrdemFabricação.Location.X, My.Forms.OrdemFabricação.Location.Y)
    End Sub

    Private Sub Novo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Novo.Click
        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)
        Me.Produto.Focus()
        Operation = INS
    End Sub

    Private Sub Produto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Produto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.Produto.Text = "" Then
                RetornoProcura = ""
                ChamaTelaProcura("Codigo", "Descrição", "", "Produtos", "CodigoProduto", "Descrição", "", True)
                If RetornoProcura <> "" Then
                    Me.Produto.Text = RetornoProcura
                End If
            End If
        End If
    End Sub

    Public Sub LocalizaProduto()
        If Me.Produto.Text = "" Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Produtos where CodigoProduto = " & Me.Produto.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.Descrição.Text = DR.Item("Descrição") & ""
            DR.Close()
        Else
            MsgBox("Produto não cadastrado, Verifique.", 64, TituloMsgbox)
            DR.Close()
            Me.Produto.Clear()
            Me.Produto.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub CodigoMateriaPrima_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Produto.Leave
        LocalizaProduto()
    End Sub

    Public Sub VerificarEdição()
        If RetornoProcura = "" Then
            Operation = INS
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from OrdemFabricaçãoItens where NumeroOF = " & My.Forms.OrdemFabricação.NumeroOF.Text & " And Produto = " & RetornoProcura
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.Produto.Text = DR.Item("Produto") & ""
            Me.Qtd.Text = FormatNumber(DR.Item("Qtd"), 4)
            DR.Close()
            LocalizaProduto()
            Operation = UPD
            Me.Produto.Focus()
        Else
            MsgBox("Item de Ordem de Fabricação não cadastrado, Verifique.", 64, TituloMsgbox)
            DR.Close()
            Me.Produto.Clear()
            Me.Descrição.Clear()
            Me.Qtd.Clear()
            Me.Produto.Focus()
            Operation = INS
            Exit Sub
        End If

    End Sub

End Class