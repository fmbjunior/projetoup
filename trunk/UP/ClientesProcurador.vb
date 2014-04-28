Public Class ClientesProcurador

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub


    Public Sub LocalizaDados()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT * FROM ClientesProcurador WHERE Cliente = " & My.Forms.Clientes.Codigo.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.NomeProcurador.Text = DR.Item("NomeProcurador") & ""
            Me.CpfProcurador.Text = DR.Item("CpfProcurador") & ""
            Me.RgProcurador.Text = DR.Item("RgProcurador") & ""
            Me.EndProcurador.Text = DR.Item("EndProcurador") & ""
            Me.NumeroEndProcurador.Text = DR.Item("NumeroEndProcurador") & ""

            Me.BairroProcurador.Text = DR.Item("BairroProcurador") & ""
            Me.CidadeProcurador.Text = DR.Item("CidadeProcurador") & ""
            Me.CepProcurador.Text = DR.Item("CepProcurador") & ""
            Me.UFProcurador.Text = DR.Item("UFProcurador") & ""
            Me.EstadoCivilProcurador.Text = DR.Item("EstadoCivilProcurador") & ""

            Operation = UPD
        Else
            Operation = INS
        End If
        DR.Close()
        CNN.Close()
    End Sub

    Private Sub ClientesProcurador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LocalizaDados()
    End Sub

    Private Sub Salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salvar.Click
        'Area destinada para as validacoes
        If Me.NomeProcurador.Text = "" Then
            MsgBox("O nome do Cliente não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.NomeProcurador.Focus()
            Exit Sub
        ElseIf Me.CpfProcurador.Text = "" Then
            MsgBox("O Cpf do Cliente não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.CpfProcurador.Focus()
            Exit Sub
        ElseIf Me.RgProcurador.Text = "" Then
            MsgBox("O Rg do Cliente não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.RgProcurador.Focus()
            Exit Sub
        ElseIf Me.EndProcurador.Text = "" Then
            MsgBox("O Endereço do Cliente não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.EndProcurador.Focus()
            Exit Sub
        ElseIf Me.NumeroEndProcurador.Text = "" Then
            MsgBox("O número de endereço do Cliente não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.NumeroEndProcurador.Focus()
            Exit Sub
        ElseIf Me.BairroProcurador.Text = "" Then
            MsgBox("O bairro não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.BairroProcurador.Focus()
            Exit Sub
        ElseIf Me.CidadeProcurador.Text = "" Then
            MsgBox("A cidade não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.CidadeProcurador.Focus()
            Exit Sub
        ElseIf Me.CepProcurador.Text = "" Then
            MsgBox("O cep do endereço do Cliente não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.CepProcurador.Focus()
            Exit Sub
        ElseIf Me.UFProcurador.Text = "" Then
            MsgBox("O estado do endereço do Cliente não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.UFProcurador.Focus()
            Exit Sub
        ElseIf Me.EstadoCivilProcurador.Text = "" Then
            MsgBox("O estado civil do Cliente não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.EstadoCivilProcurador.Focus()
            Exit Sub
        End If

        'Fim da Area destinada para as validacoes


        If Operation = INS Then

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "INSERT INTO ClientesProcurador (Cliente, NomeProcurador, CpfProcurador, RgProcurador, EndProcurador, NumeroEndProcurador, BairroProcurador, CepProcurador, CidadeProcurador, UFProcurador, EstadoCivilProcurador) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(My.Forms.Clientes.Codigo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.NomeProcurador.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.CpfProcurador.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.RgProcurador.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.EndProcurador.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.NumeroEndProcurador.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.BairroProcurador.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.CepProcurador.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.CidadeProcurador.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.UFProcurador.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.EstadoCivilProcurador.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Adicionou, My.Forms.Clientes.Codigo.Text)
                Operation = UPD
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try

        ElseIf Operation = UPD Then

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "Update ClientesProcurador set NomeProcurador = @2, CpfProcurador = @3, RgProcurador = @4, EndProcurador = @5, NumeroEndProcurador = @6, BairroProcurador = @7, CepProcurador = @8, CidadeProcurador = @9, UFProcurador = @10, EstadoCivilProcurador = @11 Where Cliente = " & My.Forms.Clientes.Codigo.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.NomeProcurador.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.CpfProcurador.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.RgProcurador.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.EndProcurador.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.NumeroEndProcurador.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.BairroProcurador.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.CepProcurador.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.CidadeProcurador.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.UFProcurador.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.EstadoCivilProcurador.Text, 1)))


            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Editou, My.Forms.Clientes.Codigo.Text)
                Operation = UPD
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try

        End If

    End Sub

    Private Sub PrintProcuração_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintProcuração.Click
        Dim f As New VisualizadorRelatorio
        RelatorioCarregar = "RelProcuracao"
        f.ShowDialog()

    End Sub
End Class