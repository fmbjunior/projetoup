Imports Microsoft.Win32

Public Class NFCFGServiço
    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Dim Cn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Cn.Close()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Novo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Novo.Click
        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)
        Me.NomeConfiguração.Focus()
        Operation = INS
    End Sub

    Private Sub NFCFGServiço_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ação.Desbloquear_Controle(Me, False)
        Cn.Open()
    End Sub

    Private Sub Salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salvar.Click
        If Me.NomeConfiguração.Text = "" Then
            MsgBox("O Nome da Configuração não pode ser nulo", 64, "Validação de Dados")
            Me.NomeConfiguração.Focus()
            Exit Sub
        End If

        If Operation = INS Then

            Dim Sql As String = "INSERT INTO ConfNfServiço (NomeConfiguração, EmissaoX, EmissaoY, NtOperaçãoX, NtOperaçãoY, ClienteX, ClienteY, EndereçoX, EndereçoY, BairroX, BairroY, CidadeX, CidadeY, UFX, UFY, FoneX, FoneY, CepX, CepY, InscEstadualX, InscEstadualY, CnpjX, CnpjY, InscMunicipalX, InscMunicipalY, QtdX, QtdY, DescriçãoServX, DescriçãoServY, UnitarioX, UnitarioY, TotalX, TotalY, AliquotaX, AliquotaY, AlturaLinhaNoCorpo, TotalLinhaNoCorpo, BaseCalcIsqnX, BaseCalcIsqnY, ValorIsqnSubstituiçãoX, ValorIsqnSubstituiçãoY, ValorIssqnX, ValorIssqnY, TotalNotaX, TotalNotaY,Empresa, NomeFonte, TamanhoFonte) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22, @23, @24, @25, @26, @27, @28, @29, @30, @31, @32, @33, @34, @35, @36, @37, @38, @39, @40, @41, @42, @43, @44, @45, @46, @47, @48)"
            Dim cmd As New OleDb.OleDbCommand(Sql, Cn)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.NomeConfiguração.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.EmissaoX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.EmissaoY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.NtOperaçãoX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.NtOperaçãoY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.ClienteX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.ClienteY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.EndereçoX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.EndereçoY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.BairroX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.BairroY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.CidadeX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.CidadeY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.UFX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.UFY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.FoneX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.FoneY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Nz(Me.CepX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@19", Nz(Me.CepY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@20", Nz(Me.InscEstadualX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@21", Nz(Me.InscEstadualY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@22", Nz(Me.CnpjX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@23", Nz(Me.CnpjY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@24", Nz(Me.InscMunicipalX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@25", Nz(Me.InscMunicipalY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@26", Nz(Me.QtdX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@27", Nz(Me.QtdY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@28", Nz(Me.DescriçãoServX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@29", Nz(Me.DescriçãoServY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@30", Nz(Me.UnitarioX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@31", Nz(Me.UnitarioY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@32", Nz(Me.TotalX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@33", Nz(Me.TotalY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@34", Nz(Me.AliquotaX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@35", Nz(Me.AliquotaY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@36", Nz(Me.AlturaLinhaNoCorpo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@37", Nz(Me.TotalLinhaNoCorpo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@38", Nz(Me.BaseCalcIsqnX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@39", Nz(Me.BaseCalcIsqnY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@40", Nz(Me.ValorIsqnSubstituiçãoX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@41", Nz(Me.ValorIsqnSubstituiçãoY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@42", Nz(Me.ValorIssqnX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@43", Nz(Me.ValorIssqnY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@44", Nz(Me.TotalNotaX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@45", Nz(Me.TotalNotaY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@46", Nz(Me.Empresa.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@47", Nz(Me.NomeFonte.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@48", Nz(Me.TamanhoFonte.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Configuração adicionada com sucesso", 64, "Validação de Dados")
                Operation = UPD
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            Ação.Desbloquear_Controle(Me, False)

        ElseIf Operation = UPD Then

            Dim Sql As String = "Update ConfNfServiço set NomeConfiguração = @1, EmissaoX = @2, EmissaoY = @3, NtOperaçãoX = @4, NtOperaçãoY = @5, ClienteX = @6, ClienteY = @7, EndereçoX = @8, EndereçoY = @9, BairroX = @10, BairroY = @11, CidadeX = @12, CidadeY = @13, UFX = @14, UFY = @15, FoneX = = @16, FoneY = @17, CepX = @18, CepY = @19, InscEstadualX = @20, InscEstadualY = @21, CnpjX = @22, CnpjY = @23, InscMunicipalX = @24, InscMunicipalY = @25, QtdX = @26, QtdY = @27, DescriçãoServX = @28, DescriçãoServY = @29, UnitarioX = @30, UnitarioY = @31, TotalX = @32, TotalY = @33, AliquotaX = @34, AliquotaY = @35, AlturaLinhaNoCorpo = @36, TotalLinhaNoCorpo = @37, BaseCalcIsqnX = @38, BaseCalcIsqnY = @39, ValorIsqnSubstituiçãoX = @40, ValorIsqnSubstituiçãoY = @41, ValorIssqnX = @42, ValorIssqnY = @43, TotalNotaX = @44, TotalNotaY = @45, Empresa = @46, NomeFonte = @47, TamanhoFonte = @48 Where NomeConfiguração = '" & Me.NomeConfiguração.Text & "'"
            Dim cmd As New OleDb.OleDbCommand(Sql, Cn)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.NomeConfiguração.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.EmissaoX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.EmissaoY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.NtOperaçãoX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.NtOperaçãoY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.ClienteX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.ClienteY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.EndereçoX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.EndereçoY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.BairroX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.BairroY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.CidadeX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.CidadeY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.UFX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.UFY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.FoneX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.FoneY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Nz(Me.CepX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@19", Nz(Me.CepY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@20", Nz(Me.InscEstadualX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@21", Nz(Me.InscEstadualY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@22", Nz(Me.CnpjX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@23", Nz(Me.CnpjY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@24", Nz(Me.InscMunicipalX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@25", Nz(Me.InscMunicipalY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@26", Nz(Me.QtdX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@27", Nz(Me.QtdY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@28", Nz(Me.DescriçãoServX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@29", Nz(Me.DescriçãoServY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@30", Nz(Me.UnitarioX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@31", Nz(Me.UnitarioY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@32", Nz(Me.TotalX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@33", Nz(Me.TotalY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@34", Nz(Me.AliquotaX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@35", Nz(Me.AliquotaY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@36", Nz(Me.AlturaLinhaNoCorpo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@37", Nz(Me.TotalLinhaNoCorpo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@38", Nz(Me.BaseCalcIsqnX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@39", Nz(Me.BaseCalcIsqnY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@40", Nz(Me.ValorIsqnSubstituiçãoX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@41", Nz(Me.ValorIsqnSubstituiçãoY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@42", Nz(Me.ValorIssqnX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@43", Nz(Me.ValorIssqnY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@44", Nz(Me.TotalNotaX.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@45", Nz(Me.TotalNotaY.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@46", Nz(Me.Empresa.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@47", Nz(Me.NomeFonte.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@48", Nz(Me.TamanhoFonte.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Configuração Atualizada com sucesso", 64, "Validação de Dados")
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, False)
        End If

    End Sub

    Private Sub Localizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Localizar.Click
        Ação.Desbloquear_Controle(Me, False)

        ChamaTelaProcura("Codigo", "Descrição", "", "ConfNfServiço", "NomeConfiguração", "NomeConfiguração", "", False)
        Me.NomeConfiguração.Text = RetornoProcura
        If Me.NomeConfiguração.Text <> "" Then
            LocalizaDados()
        End If
    End Sub

    Public Sub LocalizaDados()

        Dim Sql As String = "Select * from ConfNfServiço where NomeConfiguração = '" & NomeConfiguração.Text & "'"
        Dim CMD As New OleDb.OleDbCommand(Sql, Cn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.NomeConfiguração.Text = DR.Item("NomeConfiguração") & ""
            Me.EmissaoX.Text = DR.Item("EmissaoX") & ""
            Me.EmissaoY.Text = DR.Item("EmissaoY") & ""
            Me.NtOperaçãoX.Text = DR.Item("NtOperaçãoX") & ""
            Me.NtOperaçãoY.Text = DR.Item("NtOperaçãoY") & ""
            Me.ClienteX.Text = DR.Item("ClienteX") & ""
            Me.ClienteY.Text = DR.Item("ClienteY") & ""
            Me.EndereçoX.Text = DR.Item("EndereçoX") & ""
            Me.EndereçoY.Text = DR.Item("EndereçoY") & ""
            Me.BairroX.Text = DR.Item("BairroX") & ""
            Me.BairroY.Text = DR.Item("BairroY") & ""
            Me.CidadeX.Text = DR.Item("CidadeX") & ""
            Me.CidadeY.Text = DR.Item("CidadeY") & ""
            Me.UFX.Text = DR.Item("UFX") & ""
            Me.UFY.Text = DR.Item("UFY") & ""
            Me.FoneX.Text = DR.Item("FoneX") & ""
            Me.FoneY.Text = DR.Item("FoneY") & ""
            Me.CepX.Text = DR.Item("CepX") & ""
            Me.CepY.Text = DR.Item("CepY") & ""
            Me.InscEstadualX.Text = DR.Item("InscEstadualX") & ""
            Me.InscEstadualY.Text = DR.Item("InscEstadualY") & ""
            Me.CnpjX.Text = DR.Item("CnpjX") & ""
            Me.CnpjY.Text = DR.Item("CnpjY") & ""
            Me.InscMunicipalX.Text = DR.Item("InscMunicipalX") & ""
            Me.InscMunicipalY.Text = DR.Item("InscMunicipalY") & ""
            Me.QtdX.Text = DR.Item("QtdX") & ""
            Me.QtdY.Text = DR.Item("QtdY") & ""
            Me.DescriçãoServX.Text = DR.Item("DescriçãoServX") & ""
            Me.DescriçãoServY.Text = DR.Item("DescriçãoServY") & ""
            Me.UnitarioX.Text = DR.Item("UnitarioX") & ""
            Me.UnitarioY.Text = DR.Item("UnitarioY") & ""
            Me.TotalX.Text = DR.Item("TotalX") & ""
            Me.TotalY.Text = DR.Item("TotalY") & ""
            Me.AliquotaX.Text = DR.Item("AliquotaX") & ""
            Me.AliquotaY.Text = DR.Item("AliquotaY") & ""
            Me.AlturaLinhaNoCorpo.Text = DR.Item("AlturaLinhaNoCorpo") & ""
            Me.TotalLinhaNoCorpo.Text = DR.Item("TotalLinhaNoCorpo") & ""
            Me.BaseCalcIsqnX.Text = DR.Item("BaseCalcIsqnX") & ""
            Me.BaseCalcIsqnY.Text = DR.Item("BaseCalcIsqnY") & ""
            Me.ValorIsqnSubstituiçãoX.Text = DR.Item("ValorIsqnSubstituiçãoX") & ""
            Me.ValorIsqnSubstituiçãoY.Text = DR.Item("ValorIsqnSubstituiçãoY") & ""
            Me.ValorIssqnX.Text = DR.Item("ValorIssqnX") & ""
            Me.ValorIssqnY.Text = DR.Item("ValorIssqnY") & ""
            Me.TotalNotaX.Text = DR.Item("TotalNotaX") & ""
            Me.TotalNotaY.Text = DR.Item("TotalNotaY") & ""
            Me.NomeFonte.Text = DR.Item("NomeFonte") & ""
            Me.TamanhoFonte.Text = DR.Item("TamanhoFonte") & ""
            Me.Empresa.Text = DR.Item("Empresa") & ""
        End If
        Operation = UPD
        DR.Close()
    End Sub

    Private Sub Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar.Click
        Operation = UPD
        Ação.Desbloquear_Controle(Me, True)
        Me.NomeConfiguração.Focus()
    End Sub

    Private Sub FormPadrão_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormPadrão.Click
        Dim KeyReg As RegistryKey = Registry.LocalMachine.OpenSubKey("Software", True)
        Dim Key As RegistryKey = KeyReg.CreateSubKey("E-FocusNF")
        Dim PKey As RegistryKey = Key.CreateSubKey("Conf")


        PKey.SetValue("FormPadraoServiço", Me.NomeConfiguração.Text)
        MsgBox("Formulario de Serviço Padrão definido", 64, "Validação de Dados")

    End Sub
End Class