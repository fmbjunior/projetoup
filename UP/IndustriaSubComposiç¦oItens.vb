Public Class IndustriaSubComposiçãoItens
    Dim Ação As New TrfGerais()

    Dim Exclusão As Boolean = False

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        'Area destinada para as validacoes
        If Me.CodigoMateriaPrima.Text = "" Then
            MsgBox("O Código da Matéria Prima para o item da Sub Composição não foi informado, favor verificar.", 64, TituloMsgbox)
            Me.CodigoMateriaPrima.Focus()
            Exit Sub
        ElseIf Me.Qtd.Text = "" Then
            MsgBox("A Quantidade de Matéria Prima para o item da Sub Composição não foi informado, favor verificar.", 64, TituloMsgbox)
            Me.Qtd.Focus()
            Exit Sub
        ElseIf Me.Unitario.Text = "" Then
            Me.Unitario.Text = FormatNumber(0, 4)
        ElseIf Me.Total.Text = "" Then
            Me.Total.Text = FormatNumber(0, 4)
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            AchaUltimo()
            Dim Sql As String = "INSERT INTO IndustriaSubComposiçãoItens (Id, SubComposição, CodigoMateriaPrima, Qtd, Unitario, Total) VALUES (@1, @2, @3, @4, @5, @6)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Id.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", My.Forms.IndustriaSubComposição.CodigoSubComposição.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.CodigoMateriaPrima.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Qtd.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Unitario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Total.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Matéria prima adicionada com sucesso", TituloMsgbox, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Ação.Desbloquear_Controle(Me, False)
                CNN.Close()
                My.Forms.IndustriaSubComposição.EncheListaItens()
            Catch ex As Exception
                MsgBox(ex.Message, 64, TituloMsgbox)
            End Try

        ElseIf Operation = UPD Then

            CNN.Open()

            Dim Sql As String = "Update IndustriaSubComposiçãoItens set SubComposição = @2, CodigoMateriaPrima = @3, Qtd = @4, Unitario = @5, Total = @6 Where Id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", My.Forms.IndustriaSubComposição.CodigoSubComposição.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.CodigoMateriaPrima.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Qtd.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Unitario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Total.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Matéria prima atualizada com sucesso", TituloMsgbox, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Ação.Desbloquear_Controle(Me, False)
                CNN.Close()
                My.Forms.IndustriaSubComposição.EncheListaItens()
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try

        End If

    End Sub

    Private Sub IndustriaSubComposiçãoItens_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.CodigoMateriaPrima.Focus()
    End Sub

    Private Sub IndustriaSubComposiçãoItens_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(My.Forms.IndustriaSubComposição.Location.X, My.Forms.IndustriaSubComposição.Location.Y)
        VerificarEdição()
    End Sub

    Private Sub IndustriaSubComposiçãoItens_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        Me.Location = New Point(My.Forms.IndustriaSubComposição.Location.X, My.Forms.IndustriaSubComposição.Location.Y)
    End Sub

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)
        Me.CodigoMateriaPrima.Focus()
        Operation = INS
    End Sub

    Private Sub CodigoMateriaPrima_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoMateriaPrima.KeyDown
        If e.KeyCode = Keys.F5 Then
            RetornoProcura = ""
            My.Forms.TelaProcuraMP.ShowDialog()
            If RetornoProcura <> "" Then
                Me.CodigoMateriaPrima.Text = RetornoProcura
            End If
        End If
    End Sub

    Public Sub LocalizaMateriaPrima()
        If Me.CodigoMateriaPrima.Text = "" Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Produtos where CodigoProduto = " & Me.CodigoMateriaPrima.Text & " and Empresa = " & CodEmpresa & " and Tipo = 2"
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.DescriçãoMP.Text = DR.Item("Descrição") & ""
            Me.UnidadeMedida.Text = DR.Item("UnidadeMedida") & ""
            If Me.Unitario.Text = "" Then Me.Unitario.Text = FormatCurrency(NzZero(DR.Item("CustoMedio")), 4)
            DR.Close()
        Else
            MsgBox("Matéria Prima não cadastrado, Verifique.", 64, TituloMsgbox)
            DR.Close()
            Me.CodigoMateriaPrima.Clear()
            Me.CodigoMateriaPrima.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub CodigoMateriaPrima_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CodigoMateriaPrima.Leave
        LocalizaMateriaPrima()
    End Sub

    Public Sub VerificarEdição()
        If RetornoProcura = "" Then
            Operation = INS
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT IndustriaSubComposiçãoItens.Id, IndustriaSubComposiçãoItens.SubComposição, IndustriaSubComposiçãoItens.CodigoMateriaPrima, Produtos.Descrição, Produtos.UnidadeMedida, IndustriaSubComposiçãoItens.Qtd, IndustriaSubComposiçãoItens.Unitario, IndustriaSubComposiçãoItens.Total FROM IndustriaSubComposiçãoItens INNER JOIN Produtos ON IndustriaSubComposiçãoItens.CodigoMateriaPrima = Produtos.CodigoProduto WHERE (((IndustriaSubComposiçãoItens.Id)=" & RetornoProcura & "));"
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.Id.Text = DR.Item("ID") & ""
            Me.CodigoMateriaPrima.Text = DR.Item("CodigoMateriaPrima") & ""
            Me.DescriçãoMP.Text = DR.Item("Descrição") & ""
            Me.UnidadeMedida.Text = DR.Item("UnidadeMedida") & ""
            Me.Qtd.Text = FormatNumber(DR.Item("Qtd"), 4)
            Me.Unitario.Text = FormatCurrency(DR.Item("Unitario"), 4)
            Me.Total.Text = FormatCurrency(DR.Item("Total"), 4)
            DR.Close()
            Operation = UPD
            Me.CodigoMateriaPrima.Focus()
        Else
            MsgBox("Item de Sub-Composição não cadastrado, Verifique.", 64, TituloMsgbox)
            DR.Close()
            Me.CodigoMateriaPrima.Clear()
            Me.DescriçãoMP.Clear()
            Me.Qtd.Clear()
            Me.Unitario.Clear()
            Me.Total.Clear()
            Me.CodigoMateriaPrima.Focus()
            Operation = INS
            Exit Sub
        End If

    End Sub

  
    Private Sub Unitario_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Unitario.Leave
        If Me.Unitario.Text = "" Then
            Me.Unitario.Text = FormatCurrency(0, 4)
        Else
            Me.Unitario.Text = FormatCurrency(Me.Unitario.Text, 4)
        End If
        Me.Total.Text = FormatCurrency(CDbl(Me.Unitario.Text) * CDbl(Me.Qtd.Text), 4)
End Sub

    Private Sub Total_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Total.Leave
        If Me.Total.Text = "" Then
            Me.Total.Text = FormatCurrency(0, 4)
        Else
            Me.Total.Text = FormatCurrency(Me.Total.Text, 4)
        End If
    End Sub

    



    Private Sub AchaUltimo()

        Dim Cnn As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer
        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select max(Id) from IndustriaSubComposiçãoItens"
            .CommandType = CommandType.Text
        End With
        Try
            Cnn.Open()
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    Ult = DataReader.Item(0)
                End If
            End While
            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Ult = 1
            Me.Id.Text = Ult
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()
        Me.Id.Text = Ult + 1
    End Sub
    
    Private Sub btExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExcluir.Click
        If Me.Id.Text = "" Then
            MessageBox.Show("O usuário deve selecionar um item para excluir.", TituloMsgbox, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        CNN.Open()

        Dim Sql As String = "Delete * from IndustriaSubComposiçãoItens Where Id = " & Me.Id.Text
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.ExecuteNonQuery()
        MessageBox.Show("Matéria prima excluida com sucesso", TituloMsgbox, MessageBoxButtons.OK, MessageBoxIcon.Information)
        My.Forms.IndustriaSubComposição.EncheListaItens()
        CNN.Close()
        btNovo_Click(sender, e)

    End Sub
End Class