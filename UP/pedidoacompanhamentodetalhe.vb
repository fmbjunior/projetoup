Public Class PedidoAcompanhamentoDetalhe

    Dim Ação As New TrfGerais
    Dim CNNItens As OleDb.OleDbConnection

    Private OperationItens As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        CNNItens.Close()
        My.Forms.PedidoAcompanhamento.EncheLista()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub PedidoAcompanhamentoDetalhe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()

        Dim PosX As Double = My.Forms.PedidoAcompanhamento.Location.X + 10
        Dim PosY As Double = (My.Forms.PedidoAcompanhamento.Location.Y + 30) ' + My.Forms.PedidoAcompanhamento.Height) - Me.Height
        Me.Location = New Point(PosX, PosY)

        CNNItens = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNNItens.Open()

        'Inserir informações se for um novo registro
        If My.Forms.PedidoAcompanhamento.IdItem.Text = "" Then
            'Em adição
            Me.Pedido.Text = My.Forms.PedidoAcompanhamento.Pedido.Text
            UltimoReg()
            Me.Usuario.Text = UserAtivo
            Me.DataLancamento.Text = CDate(DataDia)
            OperationItens = INS
        Else
            'em Edição
            Dim I As Integer = 0
            For I = 0 To My.Forms.PedidoAcompanhamento.MyLista.Items.Count - 1
                If My.Forms.PedidoAcompanhamento.MyLista.Items(I).Selected = True Then Me.Pedido.Text = (My.Forms.PedidoAcompanhamento.MyLista.Items(I).Text.Substring(0))
                If My.Forms.PedidoAcompanhamento.MyLista.Items(I).Selected = True Then Me.Sequencia.Text = (My.Forms.PedidoAcompanhamento.MyLista.Items(I).SubItems(1).Text.Substring(0))
                If My.Forms.PedidoAcompanhamento.MyLista.Items(I).Selected = True Then Me.DataLancamento.Text = (My.Forms.PedidoAcompanhamento.MyLista.Items(I).SubItems(2).Text.Substring(0))
                If My.Forms.PedidoAcompanhamento.MyLista.Items(I).Selected = True Then Me.Usuario.Text = (My.Forms.PedidoAcompanhamento.MyLista.Items(I).SubItems(3).Text.Substring(0))
                If My.Forms.PedidoAcompanhamento.MyLista.Items(I).Selected = True Then Me.Historico.Text = (My.Forms.PedidoAcompanhamento.MyLista.Items(I).SubItems(4).Text.Substring(0))
                If My.Forms.PedidoAcompanhamento.MyLista.Items(I).Selected = True Then Me.LancInterno.Checked = (My.Forms.PedidoAcompanhamento.MyLista.Items(I).SubItems(5).Text.Substring(0))
            Next
            OperationItens = UPD
        End If
        'fim

    End Sub

    Private Sub PedidoAcompanhamentoDetalhe_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        Dim PosX As Double = My.Forms.PedidoAcompanhamento.Location.X + 10
        Dim PosY As Double = (My.Forms.PedidoAcompanhamento.Location.Y + 30) ' + My.Forms.PedidoAcompanhamento.Height) - Me.Height
        Me.Location = New Point(PosX, PosY)
    End Sub

    Private Sub Salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salvar.Click
        'Area destinada para as validacoes
        If Me.Pedido.Text = "" Then
            MsgBox("O Código do Pedido não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Pedido.Focus()
            Exit Sub
        ElseIf Me.Sequencia.Text = "" Then
            UltimoReg()
        ElseIf Me.DataLancamento.Text = "" Then
            Me.DataLancamento.Text = DataDia
        ElseIf Me.Usuario.Text = "" Then
            Me.Usuario.Text = UserAtivo
        ElseIf Me.Historico.Text = "" Then
            MsgBox("Favor informar o histórico de lançamento.", 64, "Validação de Dados")
            Me.Historico.Focus()
            Exit Sub
        End If

        'Fim da Area destinada para as validacoes



        If OperationItens = INS Then


            Dim Sql As String = "INSERT INTO PedidoAcompanhamentoDetalhe (Pedido, Sequencia, DataLancamento, Usuario, Historico, LancInterno) VALUES (@1, @2, @3, @4, @5, @6)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNNItens)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Pedido.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Sequencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataLancamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Usuario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Historico.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.LancInterno.Checked))

            Try
                cmd.ExecuteNonQuery()
                AddRowLista()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            Ação.Desbloquear_Controle(Me, False)

        ElseIf OperationItens = UPD Then

            Dim Sql As String = "Update PedidoAcompanhamentoDetalhe set Pedido = @1, Sequencia = @2, DataLancamento = @3, Usuario = @4, Historico = @5, LancInterno = @6 Where Pedido = " & Me.Pedido.Text & " and Sequencia = " & Me.Sequencia.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNNItens)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Pedido.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Sequencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataLancamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Usuario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Historico.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.LancInterno.Checked))

            Try
                cmd.ExecuteNonQuery()
                My.Forms.PedidoAcompanhamento.EncheLista()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, False)

        End If

    End Sub

    Private Sub DataLancamento_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataLancamento.Enter
        If Me.DataLancamento.Text = "" Then Me.DataLancamento.Text = CDate(DataDia)
    End Sub

    Private Sub Usuario_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Usuario.Enter
        If Me.Usuario.Text = "" Then Me.Usuario.Text = UserAtivo
    End Sub

    Public Sub UltimoReg()
        'Inserir ultimo registro

        Dim sql As String = "Select max(Sequencia) from PedidoAcompanhamentoDetalhe Where Pedido = " & Me.Pedido.Text
        Dim Cmd As New OleDb.OleDbCommand(sql, CNNItens)
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
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try

        Me.Sequencia.Text = Ult + 1
        'fim inserir ultimo registro
    End Sub

    Private Sub Novo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Novo.Click
        Ação.LimpaTextBox(Me)
        Me.Pedido.Text = My.Forms.PedidoAcompanhamento.Pedido.Text
        UltimoReg()
        Me.Usuario.Text = UserAtivo
        Me.DataLancamento.Text = CDate(DataDia)
        Ação.Desbloquear_Controle(Me, True)
        OperationItens = INS
        Me.LancInterno.Enabled = False
        Me.Pedido.Focus()
    End Sub

    Private Sub AddRowLista()
        Dim It As New ListViewItem(Me.Pedido.Text)

        It.SubItems.Add(Me.Sequencia.Text)
        It.SubItems.Add(Me.DataLancamento.Text)
        It.SubItems.Add(Me.Usuario.Text)
        It.SubItems.Add(Me.Historico.Text)
        It.SubItems.Add(Me.LancInterno.Checked)

        My.Forms.PedidoAcompanhamento.MyLista.Items.AddRange(New ListViewItem() {It})

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
End Class