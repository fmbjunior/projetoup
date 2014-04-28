Public Class ValeDesconto

    Dim Ação As New TrfGerais

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Private Sub ValeDesconto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click
        'Area destinada para as validacoes
        If Me.IdValeDesconto.Text = "" Then
            MsgBox("O código do Vale desconto não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.IdValeDesconto.Focus()
            Exit Sub
        ElseIf Me.Cliente.Text = "" Then
            MsgBox("O Cliente não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Cliente.Focus()
            Exit Sub
        ElseIf Me.ValorVale.Text = "" Then
            MsgBox("O Valor do Vale não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.ValorVale.Focus()
            Exit Sub
        ElseIf Me.DataLancamento.Text = "" Then
            MsgBox("A data de Lançamento do vale não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.DataLancamento.Focus()
            Exit Sub
        ElseIf Me.DataValidade.Text = "" Then
            MsgBox("A data de Validade do vale não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.DataValidade.Focus()
            Exit Sub
        ElseIf Me.MotivoVale.Text = "" Then
            MsgBox("O motivo que foi dado o vale não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.MotivoVale.Focus()
            Exit Sub
        ElseIf Me.LoginAutorizou.Text = "" Then
            MsgBox("O login de quem autorizou o vale não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.LoginAutorizou.Focus()
            Exit Sub
        End If

        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        If Operation = INS Then

            Dim Sql As String = "INSERT INTO ValeDesconto (IdValeDesconto, Cliente, NomeCliente, ValorVale, DataLancamento, DataValidade, MotivoVale, LoginAutorizou, Utilizado, Empresa) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.IdValeDesconto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Cliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.NomeCliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ValorVale.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.DataLancamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.DataValidade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.MotivoVale.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.MotivoVale.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Me.Utilizado.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                Ação.Desbloquear_Controle(Me, False)
                CNN.Close()
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            Ação.Desbloquear_Controle(Me, False)
            CNN.Close()

        ElseIf Operation = UPD Then

            Dim Sql As String = "Update ValeDesconto set IdValeDesconto = @1, Cliente = @2, NomeCliente = @3, ValorVale = @4, DataLancamento = @5, DataValidade = @6, MotivoVale = @7, LoginAutorizou = @8, Utilizado = @9, Empresa = @10 Where IdValeDesconto = '" & Me.IdValeDesconto.Text & "'"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.IdValeDesconto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Cliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.NomeCliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ValorVale.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.DataLancamento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.DataValidade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.MotivoVale.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.MotivoVale.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Me.Utilizado.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))


            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                Ação.Desbloquear_Controle(Me, False)
                CNN.Close()
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try

        End If

    End Sub
End Class