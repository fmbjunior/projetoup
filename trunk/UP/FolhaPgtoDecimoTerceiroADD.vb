Public Class FolhaPgtoDecimoTerceiroADD

    Dim Ação As New TrfGerais()


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
        If Me.Funcionario.Text = "" Then
            MsgBox("O Funcionário não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Funcionario.Focus()
            Exit Sub
        ElseIf Me.Meses.Text = "" Then
            MsgBox("A referência do Décimo terceiro não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Meses.Focus()
            Exit Sub
        ElseIf Me.SalarioRegistro.Text = "" Then
            Me.SalarioRegistro.Text = FormatNumber(0, 2)
        ElseIf Me.SalarioDif.Text = "" Then
            Me.SalarioDif.Text = FormatNumber(0, 2)
        ElseIf Me.OutrosVlrs.Text = "" Then
            Me.OutrosVlrs.Text = FormatNumber(0)
        ElseIf Me.Total.Text = "" Then
            Me.Total.Text = FormatNumber(0)
        ElseIf Me.VlrDecimo.Text = "" Then
            Me.VlrDecimo.Text = FormatNumber(0)
        ElseIf Me.Inss.Text = "" Then
            Me.Inss.Text = FormatNumber(0)
        ElseIf Me.Parcela1.Text = "" Then
            Me.Parcela1.Text = FormatNumber(0)
        ElseIf Me.Parcela2.Text = "" Then
            Me.Parcela2.Text = FormatNumber(0)
        End If

        'Fim da Area destinada para as validacoes


        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then

            Cnn.Open()
            Dim Sql As String = "INSERT INTO FolhaPgtoDecimoTerceiro (AnoAtual, Funcionario, SalarioRegistro, SalarioDif, OutrosVlrs, Total, Meses, VlrDecimo, Inss, 1Parcela, 2Parcela, Empresa, Desc1Pa, Desc2Pa) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
            Dim cmd As New OleDb.OleDbCommand(Sql, Cnn)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(My.Forms.FolhaPgtoDecimoTerceiro.AnoAtual.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Funcionario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.SalarioRegistro.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.SalarioDif.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.OutrosVlrs.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Total.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Meses.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.VlrDecimo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Inss.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.Parcela1.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Parcela2.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.Desc1Pa.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.Desc2Pa.Text, 1)))
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                Operation = UPD
                Cnn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try

        ElseIf Operation = UPD Then

            Cnn.Open()
            Dim Sql As String = "Update FolhaPgtoDecimoTerceiro set AnoAtual = @1, Funcionario = @2, SalarioRegistro = @3, SalarioDif = @4, OutrosVlrs = @5, Total = @6, Meses = @7, VlrDecimo = @8, Inss = @9, 1Parcela = @10, 2Parcela = @11, Empresa = @12, Desc1Pa = @13, Desc2Pa = @14 Where Funcionario = " & Me.Funcionario.Text & " And AnoAtual = '" & My.Forms.FolhaPgtoDecimoTerceiro.AnoAtual.Text & "'"
            Dim cmd As New OleDb.OleDbCommand(Sql, Cnn)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(My.Forms.FolhaPgtoDecimoTerceiro.AnoAtual.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Funcionario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.SalarioRegistro.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.SalarioDif.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.OutrosVlrs.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Total.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Meses.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.VlrDecimo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Inss.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.Parcela1.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Parcela2.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.Desc1Pa.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.Desc2Pa.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                Operation = UPD
                Cnn.Close()
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try

        End If

    End Sub

    Private Sub FolhaPgtoDecimoTerceiroADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()
        If My.Forms.FolhaPgtoDecimoTerceiro.Editando = False Then
            Operation = INS
        Else
            Operation = UPD
        End If
    End Sub

    Private Sub Total_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Total.Enter
        If Me.SalarioRegistro.Text = "" Then Me.SalarioRegistro.Text = FormatNumber(0, 2)
        If Me.SalarioDif.Text = "" Then Me.SalarioDif.Text = FormatNumber(0, 2)
        If Me.OutrosVlrs.Text = "" Then Me.OutrosVlrs.Text = FormatNumber(0, 2)

        Me.Total.Text = FormatNumber(CDbl(Me.SalarioRegistro.Text) + CDbl(Me.SalarioDif.Text) + CDbl(Me.OutrosVlrs.Text), 2)

    End Sub

    Private Sub VlrDecimo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles VlrDecimo.Enter
        If Me.Meses.Text = "" Then Me.Meses.Text = 1

        Me.VlrDecimo.Text = FormatNumber((CDbl(Me.Total.Text) / 12) * Me.Meses.Text, 2)
    End Sub

    Private Sub Inss_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Inss.Enter
        If Me.Inss.Text = "" Then Me.Inss.Text = FormatNumber(0, 2)
    End Sub


    Private Sub Novo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Novo.Click
        Ação.LimpaTextBox(Me)
        Me.Funcionario.Focus()
        Operation = INS
    End Sub

    Private Sub Excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Excluir.Click
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))


        Cnn.Open()
        Dim Sql As String = "Delete * From FolhaPgtoDecimoTerceiro Where Funcionario = " & Me.Funcionario.Text & " And AnoAtual = '" & My.Forms.FolhaPgtoDecimoTerceiro.AnoAtual.Text & "'"
        Dim cmd As New OleDb.OleDbCommand(Sql, Cnn)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Registro excluido com sucesso", 64, "Validação de Dados")
            Operation = INS
            Ação.LimpaTextBox(Me)
            Me.Funcionario.Focus()
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try

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

    Private Sub Parcela1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Parcela1.Enter
        Me.Parcela1.Text = FormatNumber((CDbl(Me.VlrDecimo.Text) / 2) - CDbl(NzZero(Me.Desc1Pa.Text)), 2)
    End Sub

    Private Sub Parcela2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Parcela2.Enter
        Me.Parcela2.Text = FormatNumber(CDbl(Me.VlrDecimo.Text) - CDbl(Me.Inss.Text) - CDbl(Me.Parcela1.Text) - CDbl(NzZero(Me.Desc2Pa.Text)) - CDbl(NzZero(Me.Desc1Pa.Text)), 2)
    End Sub

    Private Sub Desc1Pa_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Desc1Pa.Leave
        If Me.Desc1Pa.Text = "" Then Me.Desc1Pa.Text = FormatNumber(0, 2)
    End Sub

    Private Sub Desc2Pa_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Desc2Pa.Leave
        If Me.Desc2Pa.Text = "" Then Me.Desc2Pa.Text = FormatNumber(0, 2)
    End Sub
End Class