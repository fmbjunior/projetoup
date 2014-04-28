Public Class FolhaPgtoTributos
    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        Me.Close()
        Me.Dispose()
    End Sub
  
    Private Sub NovoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click
        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)
        Me.Competencia.Focus()
        Operation = INS
    End Sub

    
    Private Sub FolhaPgtoTributos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()
        Ação.Desbloquear_Controle(Me, False)
    End Sub

    Private Sub EditarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBT.Click
        If Me.Competencia.Text = "" Then
            MsgBox("Não existe Competência para ser editado.", 64, "Validação de Dados")
            Exit Sub
        End If
        Operation = UPD
        Ação.Desbloquear_Controle(Me, True)
        Me.Competencia.Focus()
    End Sub

    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click
        'Area destinada para as validacoes
        If Me.Competencia.Text = "" Then
            MsgBox("A competência não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Competencia.Focus()
            Exit Sub
        ElseIf Me.SalarioMinimo.Text = "" Then
            MsgBox("O Salário Mínimo não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.SalarioMinimo.Focus()
            Exit Sub
        End If

        If Me.ValorFaixa1.Text = "" Then Me.ValorFaixa1.Text = FormatCurrency(0, 2)
        If Me.ValorFaixa2.Text = "" Then Me.ValorFaixa2.Text = FormatCurrency(0, 2)
        If Me.ValorFaixa3.Text = "" Then Me.ValorFaixa3.Text = FormatCurrency(0, 2)
        If Me.ValorFaixa4.Text = "" Then Me.ValorFaixa4.Text = FormatCurrency(0, 2)

        If Me.PercFaixa1.Text = "" Then Me.PercFaixa1.Text = FormatNumber(0, 2)
        If Me.PercFaixa2.Text = "" Then Me.PercFaixa2.Text = FormatNumber(0, 2)
        If Me.PercFaixa3.Text = "" Then Me.PercFaixa3.Text = FormatNumber(0, 2)
        If Me.PercFaixa4.Text = "" Then Me.PercFaixa4.Text = FormatNumber(0, 2)

        If Me.SalarioFamiliaMaior.Text = "" Then Me.SalarioFamiliaMaior.Text = FormatCurrency(0, 2)
        If Me.SalarioFamiliaMenor.Text = "" Then Me.SalarioFamiliaMenor.Text = FormatCurrency(0, 2)

        If Me.ValorSalarioFamiliaMaior.Text = "" Then Me.ValorSalarioFamiliaMaior.Text = FormatCurrency(0, 2)
        If Me.ValorSalarioFamiliaMenor.Text = "" Then Me.ValorSalarioFamiliaMenor.Text = FormatCurrency(0, 2)

        If Me.SalarioMinimo.Text = "" Then Me.SalarioMinimo.Text = FormatCurrency(0, 2)

        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            Dim Sql As String = "INSERT INTO FolhaPgtoTributos (Competencia, ValorFaixa1, PercFaixa1, ValorFaixa2, PercFaixa2, ValorFaixa3, PercFaixa3, ValorFaixa4, PercFaixa4, SalarioFamiliaMaior, ValorSalarioFamiliaMaior, SalarioFamiliaMenor, ValorSalarioFamiliaMenor, SalarioMinimo, Empresa) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Competencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.ValorFaixa1.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.PercFaixa1.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ValorFaixa2.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.PercFaixa2.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.ValorFaixa3.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.PercFaixa3.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.ValorFaixa4.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.PercFaixa4.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.SalarioFamiliaMaior.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.ValorSalarioFamiliaMaior.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.SalarioFamiliaMenor.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.ValorSalarioFamiliaMenor.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.SalarioMinimo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", CodEmpresa))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            Ação.Desbloquear_Controle(Me, False)
            CNN.Close()

        ElseIf Operation = UPD Then
            CNN.Open()

            Dim Sql As String = "Update FolhaPgtoTributos set Competencia = @1, ValorFaixa1 = @2, PercFaixa1 = @3, ValorFaixa2 = @4, PercFaixa2 = @5, ValorFaixa3 = @6, PercFaixa3 = @7, ValorFaixa4 = @8, PercFaixa4 = @9, SalarioFamiliaMaior = @10, ValorSalarioFamiliaMaior = @11, SalarioFamiliaMenor = @12, ValorSalarioFamiliaMenor = @13, SalarioMinimo = @14, Empresa = @15 Where Competencia = '" & Me.Competencia.Text & "'"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Competencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.ValorFaixa1.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.PercFaixa1.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ValorFaixa2.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.PercFaixa2.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.ValorFaixa3.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.PercFaixa3.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.ValorFaixa4.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.PercFaixa4.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.SalarioFamiliaMaior.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.ValorSalarioFamiliaMaior.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.SalarioFamiliaMenor.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.ValorSalarioFamiliaMenor.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.SalarioMinimo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", CodEmpresa))


            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, False)
            CNN.Close()
        End If

    End Sub


    Public Sub LocalizaDados(ByVal TXTCompetencia As String)
        If TXTCompetencia = "" Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from FolhaPgtoTributos where Competencia = '" & TXTCompetencia & "'"
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows = True Then
            Me.Competencia.Text = DR.Item("Competencia")
            Me.ValorFaixa1.Text = FormatCurrency(DR.Item("ValorFaixa1"), 2)
            Me.PercFaixa1.Text = FormatNumber(DR.Item("PercFaixa1"), 2)
            Me.ValorFaixa2.Text = FormatCurrency(DR.Item("ValorFaixa2"), 2)
            Me.PercFaixa2.Text = FormatNumber(DR.Item("PercFaixa2"), 2)
            Me.ValorFaixa3.Text = FormatCurrency(DR.Item("ValorFaixa3"), 2)
            Me.PercFaixa3.Text = FormatNumber(DR.Item("PercFaixa3"), 2)
            Me.ValorFaixa4.Text = FormatCurrency(DR.Item("ValorFaixa4"), 2)
            Me.PercFaixa4.Text = FormatNumber(DR.Item("PercFaixa4"), 2)
            Me.SalarioFamiliaMaior.Text = FormatCurrency(DR.Item("SalarioFamiliaMaior"), 2)
            Me.ValorSalarioFamiliaMaior.Text = FormatCurrency(DR.Item("ValorSalarioFamiliaMaior"), 2)
            Me.SalarioFamiliaMenor.Text = FormatCurrency(DR.Item("SalarioFamiliaMenor"), 2)
            Me.ValorSalarioFamiliaMenor.Text = FormatCurrency(DR.Item("ValorSalarioFamiliaMenor"), 2)
            Me.SalarioMinimo.Text = FormatCurrency(DR.Item("SalarioMinimo"), 2)

            Operation = UPD
        Else
            Operation = INS
        End If
        DR.Close()
    End Sub

    Private Sub Competencia_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Competencia.Validated
        LocalizaDados(Me.Competencia.Text)
    End Sub

    Private Sub ImportarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportarBT.Click
        Ação.Desbloquear_Controle(Me, False)
        Me.PainelImport.Visible = True
        Me.PainelImport.Enabled = True
        Me.CompNova.Enabled = True
        Me.CompImportar.Enabled = True
        Me.CompImportar.Focus()
    End Sub

    Private Sub Importar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Importar.Click

        LocalizaDados(Me.CompImportar.Text)
        Me.Refresh()

        If MsgBox("Deseja importar a competência informada.", 36, "Validação de Dados") = 6 Then
            Me.Competencia.Text = Me.CompNova.Text
            Operation = INS
            SalvarBT_Click(sender, e)
            Me.Refresh()
        End If

        Me.CompImportar.Clear()
        Me.CompNova.Clear()
        Me.PainelImport.Visible = False
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