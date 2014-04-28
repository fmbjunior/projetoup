Public Class IndustriaSubComposição
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

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)
        Me.CodigoSubComposição.Text = "0000"
        Me.CodigoSubComposição.Focus()
        Operation = INS
    End Sub

    Private Sub btEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEditar.Click
        If Me.CodigoSubComposição.Text = "" Then
            MsgBox("Não existe Sub Composição para ser editado.", 64, TituloMsgbox)
            Exit Sub
        End If
        Operation = UPD
        Ação.Desbloquear_Controle(Me, True)
        Me.DescriçãoSubComposição.Focus()
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        'Area destinada para as validacoes
        If Me.CodigoSubComposição.Text = "" Then
            MsgBox("O Código da Sub Composição não foi informado, favor verificar.", 64, TituloMsgbox)
            Me.CodigoSubComposição.Focus()
            Exit Sub
        ElseIf Me.DescriçãoSubComposição.Text = "" Then
            MsgBox("A Descrição da Sub Composição não foi informado, favor verificar.", 64, TituloMsgbox)
            Me.DescriçãoSubComposição.Focus()
            Exit Sub
        ElseIf Me.UM.Text = "" Then
            MsgBox("A Unidade de Medida da Sub Composição não foi informado, favor verificar.", 64, TituloMsgbox)
            Me.UM.Focus()
            Exit Sub
        ElseIf Me.ValorCusto.Text = "" Then
            Me.ValorCusto.Text = FormatNumber(0, 4)
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            UltimoReg()
            Dim Sql As String = "INSERT INTO IndustriaSubComposição (CodigoSubComposição, DescriçãoSubComposição, UM, ValorCusto, Empresa) VALUES (@1, @2, @3, @4, @5)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CodigoSubComposição.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DescriçãoSubComposição.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.UM.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ValorCusto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", CodEmpresa))

            Try
                cmd.ExecuteNonQuery()
                Operation = UPD
                MsgBox("Registro adicionado com sucesso", 64, TituloMsgbox)
            Catch ex As Exception
                MsgBox(ex.Message, 64, TituloMsgbox)
            End Try
            Ação.Desbloquear_Controle(Me, False)
            CNN.Close()

        ElseIf Operation = UPD Then
            CNN.Open()

            Dim Sql As String = "Update IndustriaSubComposição set DescriçãoSubComposição = @2, UM = @3, ValorCusto = @4, Empresa = @5 Where CodigoSubComposição = " & Me.CodigoSubComposição.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DescriçãoSubComposição.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.UM.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ValorCusto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", CodEmpresa))

            Try
                cmd.ExecuteNonQuery()
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
            .CommandText = "Select max(CodigoSubComposição) from IndustriaSubComposição"
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

        Me.CodigoSubComposição.Text = Ult + 1
        Me.DescriçãoSubComposição.Focus()
        'fim inserir ultimo registro

    End Sub

    Private Sub btLocalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLocalizar.Click
        RetornoProcura = ""
        ChamaTelaProcura("Codigo", "Descrição", "", "IndustriaSubComposição", "CodigoSubComposição", "DescriçãoSubComposição", "", True)

        Me.CodigoSubComposição.Text = RetornoProcura
        If Me.CodigoSubComposição.Text <> "" Then
            LocalizaDados()
            Me.DescriçãoSubComposição.Focus()
        End If
    End Sub

    Public Sub LocalizaDados()
        If Me.CodigoSubComposição.Text = "" Then
            Exit Sub
        End If
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from IndustriaSubComposição where CodigoSubComposição = " & Me.CodigoSubComposição.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.CodigoSubComposição.Text = DR.Item("CodigoSubComposição") & ""
            Me.DescriçãoSubComposição.Text = DR.Item("DescriçãoSubComposição") & ""
            Me.UM.Text = DR.Item("UM") & ""
            Me.ValorCusto.Text = FormatCurrency(DR.Item("ValorCusto"), 4)
            DR.Close()
            EncheListaItens()
            Ação.Desbloquear_Controle(Me, False)
            Operation = UPD
        Else
            MsgBox("Sub Composição não cadastrado, Verifique.", 64, TituloMsgbox)
            DR.Close()
            Me.CodigoSubComposição.Text = "0000"
            Me.CodigoSubComposição.Focus()
            Operation = INS
            Exit Sub
        End If
    End Sub

    Private Sub CodigoSubComposição_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CodigoSubComposição.Leave
        If Me.CodigoSubComposição.Text = "0000" Then
            Exit Sub
        Else
            LocalizaDados()
        End If
    End Sub

    Private Sub ValorCusto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorCusto.Leave
        If Not Me.ValorCusto.Text = "" Then
            Me.ValorCusto.Text = FormatCurrency(Me.ValorCusto.Text, 4)
        Else
            Me.ValorCusto.Text = FormatCurrency(0, 4)
        End If
    End Sub

    Private Sub IndustriaSubComposição_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Ação.Desbloquear_Controle(Me, False)
    End Sub

    Public Sub EncheListaItens()

        If Me.CodigoSubComposição.Text = "" Then Exit Sub

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()
        Dim Sql As String = String.Empty

        Sql = "SELECT IndustriaSubComposiçãoItens.Id, IndustriaSubComposiçãoItens.CodigoMateriaPrima, Produtos.Descrição, Produtos.UnidadeMedida, IndustriaSubComposiçãoItens.Qtd, IndustriaSubComposiçãoItens.Unitario, IndustriaSubComposiçãoItens.Total FROM Produtos INNER JOIN IndustriaSubComposiçãoItens ON Produtos.CodigoProduto = IndustriaSubComposiçãoItens.CodigoMateriaPrima WHERE (((IndustriaSubComposiçãoItens.SubComposição)=" & Me.CodigoSubComposição.Text & "));"

        Dim da = New OleDb.OleDbDataAdapter(Sql, CNN)
        da.SelectCommand.CommandType = CommandType.Text
        Dim ds As New DataSet
        da.Fill(ds, "IndComposicao")

        Me.ValorCusto.Text = FormatCurrency(NzZero(ds.Tables("IndComposicao").Compute("Sum(Total)", String.Empty).ToString), 2)
        Me.Ttotal.Text = "Total do Custo:  " & FormatNumber(NzZero(ds.Tables("IndComposicao").Compute("Sum(Total)", String.Empty).ToString), 4)
        Me.Tqtd.Text = "Total de Qtd:  " & FormatNumber(NzZero(ds.Tables("IndComposicao").Compute("Sum(Qtd)", String.Empty).ToString), 4)

        Me.MyLista.DataSource = ds.Tables("IndComposicao").DefaultView


        'Atualizar o Valor do Custo no dados Principal
        Sql = "Update IndustriaSubComposição set ValorCusto = @1 Where CodigoSubComposição = " & Me.CodigoSubComposição.Text
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.ValorCusto.Text, 1)))

        cmd.ExecuteNonQuery()
        'Fim

        da.Dispose()
        CNN.Close()


    End Sub


    Private Sub MyLista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MyLista.CellDoubleClick
        RetornoProcura = String.Empty

        Dim vID As Integer
        vID = CInt(Me.MyLista.CurrentRow.Cells(0).Value)
        RetornoProcura = vID

        If RetornoProcura = "" Then Exit Sub

        My.Forms.IndustriaSubComposiçãoItens.ShowDialog()
    End Sub

    Private Sub btLancaItens_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLancaItens.Click
        If Me.CodigoSubComposição.Text = "" Then
            MsgBox("Para lançar os itens o usuário deve primeiro selecionar uma Sub Composição.", 64, TituloMsgbox)
            Exit Sub
        End If
        RetornoProcura = ""
        My.Forms.IndustriaSubComposiçãoItens.ShowDialog()
    End Sub

    Private Sub btDetalheFerragem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDetalheFerragem.Click
        My.Forms.IndustriaDetalheFerragem.ShowDialog()
        EncheListaItens()
    End Sub

    Private Sub MyLista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyLista.KeyDown
        RetornoProcura = String.Empty

        If e.KeyCode = Keys.Delete Then
            Dim vID As Integer
            vID = CInt(Me.MyLista.CurrentRow.Cells(0).Value)
            RetornoProcura = vID

            If MsgBox("Deseja realmente excluir o Item", 36, TituloMsgbox) = 6 Then
                Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
                CNN.Open()

                Dim Sql As String = "Delete * From IndustriaSubComposiçãoItens Where Id = " & vID
                Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Registro excluido com sucesso.", TituloMsgbox, MessageBoxButtons.OK, MessageBoxIcon.Information)
                CNN.Close()
                EncheListaItens()
            End If
        End If
    End Sub
End Class