Imports System.IO
Imports System.Drawing.Printing
Imports System.Data.OleDb
Imports Microsoft.Win32

Public Class NFiscalServiço

    Private WithEvents PDoc As New PrintDocument()

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Dim Cn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
        Cn.Close()
    End Sub

#Region "Dados da Empresa"
    Public Sub VisualizaFoto()

        Try
            Dim Cmd As New OleDb.OleDbCommand("SELECT * From Empresa where CódigoEmpresa = " & CodEmpresa, Cn)

            Dim Da As New OleDb.OleDbDataAdapter(Cmd)
            Dim Ds As New DataSet()

            Da.Fill(Ds, "Empresa")

            Dim c As Integer = Ds.Tables(0).Rows.Count
            If c > 0 Then

                Dim ByteData() As Byte = Ds.Tables(0).Rows(c - 1).Item("Foto")

                Dim ImgVer As New MemoryStream(ByteData)


                Me.Display.Visible = True
                Me.Display.Image = Image.FromStream(ImgVer)
            End If

        Catch err As Exception
            Me.Display.Visible = False
        Finally
            'fecha a conexão
        End Try

    End Sub
#End Region

    Private Sub NFiscalServiço_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cn.Open()
        Ação.Desbloquear_Controle(Me, False)
        Me.NNota.Enabled = True
        VisualizaFoto()
    End Sub

    Private Sub Novo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Novo.Click
        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)
        Operation = INS
        Me.NNota.Focus()
    End Sub

    Private Sub Cliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cliente.KeyDown
        If e.KeyCode = Keys.F5 Then
            ChamaTelaProcura("Codigo", "Nome", "", "Clientes", "Codigo", "Nome", "", True)
            Me.Cliente.Text = RetornoProcura
        End If
    End Sub

    Private Sub Cliente_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cliente.Validated

        If Me.Cliente.Text <> "" Then

            Dim Sql As String = "Select * from Clientes where Codigo = " & Me.Cliente.Text
            Dim CMD As New OleDb.OleDbCommand(Sql, Cn)
            Dim DR As OleDb.OleDbDataReader

            DR = CMD.ExecuteReader
            DR.Read()

            Me.CnpjCpf.Text = DR.Item("CpfCgc") & ""
            Me.InscEstadual.Text = DR.Item("Insc") & ""
            Me.ClienteNome.Text = DR.Item("Nome") & ""
            Me.Endereço.Text = DR.Item("Endereço") & ""
            Me.Cidade.Text = DR.Item("Cidade") & ""
            Me.Bairro.Text = DR.Item("Bairro") & ""
            Me.Cep.Text = DR.Item("Cep") & ""
            Me.UF.Text = DR.Item("Estado") & ""
            Me.Fone.Text = DR.Item("Telefone") & ""
            DR.Close()

        End If

    End Sub

    Private Sub Salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salvar.Click
        If Me.NNota.Text = "" Then
            MsgBox("A nota fiscal não pode ser nulo", 64, "Validação de Dados")
            Me.NNota.Focus()
            Exit Sub
        ElseIf Me.Cliente.Text = "" Then
            MsgBox("O Cliente não pode ser nulo", 64, "Validação de Dados")
            Me.Cliente.Focus()
            Exit Sub
        ElseIf Me.Pedido.Text = "" Then
            MsgBox("O Pedido não pode ser nulo", 64, "Validação de Dados")
            Me.Pedido.Focus()
            Exit Sub
        End If

        If Operation = INS Then

            Dim Sql As String = "INSERT INTO NotaFiscalServiço (NNota, DataEmissão, NatOperação, Cliente, ClienteNome, Propriedade, Endereço, Bairro, Cidade, UF, Fone, Cep, InscEstadual, CnpjCpf, InscMunicipal, Qtd1, Desc1, Unitario1,  Total1, Qtd2, Desc2, Unitario2, Total2, Qtd3, Desc3, Unitario3, Total3, Qtd4, Desc4, Unitario4, Total4, Qtd5, Desc5, Unitario5, Total5, Qtd6, Desc6, Unitario6, Total6, Qtd7, Desc7, Unitario7, Total7, Qtd8, Desc8, Unitario8, Total8, Qtd9, Desc9, Unitario9, Total9, Qtd10, Desc10, Unitario10, Total10, BaseCalcIsqn, ValorIsqnSubstituição, ValorIsqn, TotalNota, Status, Empresa, Pedido) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22, @23, @24, @25, @26, @27, @28, @29, @30, @31, @32, @33, @34, @35, @36, @37, @38, @39, @40, @41, @42, @43, @44, @45, @46, @47, @48, @49, @50, @51, @52, @53, @54, @55, @56, @57, @58, @59, @60, @61, @62)"
            Dim cmd As New OleDb.OleDbCommand(Sql, Cn)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.NNota.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataEmissão.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.NatOperação.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Cliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.ClienteNome.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Propriedade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Endereço.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Bairro.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Cidade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.UF.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Fone.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.Cep.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.InscEstadual.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.CnpjCpf.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.InscMunicipal.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.Qtd1.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.Desc1.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Nz(Me.Unitario1.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@19", Nz(Me.Total1.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@20", Nz(Me.Qtd2.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@21", Nz(Me.Desc2.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@22", Nz(Me.Unitario2.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@23", Nz(Me.Total2.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@24", Nz(Me.Qtd3.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@25", Nz(Me.Desc3.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@26", Nz(Me.Unitario3.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@27", Nz(Me.Total3.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@28", Nz(Me.Qtd4.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@29", Nz(Me.Desc4.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@30", Nz(Me.Unitario4.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@31", Nz(Me.Total4.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@32", Nz(Me.Qtd5.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@33", Nz(Me.Desc5.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@34", Nz(Me.Unitario5.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@35", Nz(Me.Total5.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@36", Nz(Me.Qtd6.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@37", Nz(Me.Desc6.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@38", Nz(Me.Unitario6.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@39", Nz(Me.Total6.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@40", Nz(Me.Qtd7.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@41", Nz(Me.Desc7.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@42", Nz(Me.Unitario7.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@43", Nz(Me.Total7.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@44", Nz(Me.Qtd8.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@45", Nz(Me.Desc8.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@46", Nz(Me.Unitario8.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@47", Nz(Me.Total8.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@48", Nz(Me.Qtd9.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@49", Nz(Me.Desc9.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@50", Nz(Me.Unitario9.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@51", Nz(Me.Total9.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@52", Nz(Me.Qtd10.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@53", Nz(Me.Desc10.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@54", Nz(Me.Unitario10.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@55", Nz(Me.Total10.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@56", Nz(Me.BaseCalcIsqn.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@57", Nz(Me.ValorIsqnSubstituição.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@58", Nz(Me.ValorIsqn.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@59", Nz(Me.TotalNota.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@60", Nz(Me.Status.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@61", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@62", Nz(Me.Pedido.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Nota Fiscal adicionada com sucesso", 64, "Validação de Dados")
                Operation = UPD
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            Ação.Desbloquear_Controle(Me, False)

        ElseIf Operation = UPD Then

            Dim Sql As String = "Update NotaFiscalServiço set NNota = @1, DataEmissão = @2, NatOperação = @3, Cliente = @4, ClienteNome = @5, Propriedade = @6, Endereço = @7, Bairro = @8, Cidade = @9, UF = @10, Fone = @11, Cep = @12, InscEstadual = @13, CnpjCpf = @14, InscMunicipal = @15, Qtd1 = @16, Desc1 = @17, Unitario1 = @18,  Total1 = @19, Qtd2 = @20, Desc2 = @21, Unitario2 = @22, Total2 = @23, Qtd3 = @24, Desc3 = @25, Unitario3 = @26, Total3 = @27, Qtd4 = @28, Desc4 = @29, Unitario4 = @30, Total4 = @31, Qtd5 = @32, Desc5 = @33, Unitario5 = @34, Total5 = @35, Qtd6 = @36, Desc6 = @37, Unitario6 = @38, Total6 = @39, Qtd7 = @40, Desc7 = @41, Unitario7 = @42, Total7 = @43, Qtd8 = @44, Desc8 = @45, Unitario8 = @46, Total8 = @47, Qtd9 = @48, Desc9 = @49, Unitario9 = @50, Total9 = @51, Qtd10 = @52, Desc10 = @53, Unitario10 = @54, Total10 = @55, BaseCalcIsqn = @56, ValorIsqnSubstituição = @57, ValorIsqn = @58, TotalNota = @59, Status = @60, Empresa = @61, Pedido = @62 Where Nnota = " & Me.NNota.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, Cn)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.NNota.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataEmissão.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.NatOperação.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Cliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.ClienteNome.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Propriedade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Endereço.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Bairro.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Cidade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.UF.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Fone.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.Cep.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.InscEstadual.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.CnpjCpf.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.InscMunicipal.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.Qtd1.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.Desc1.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Nz(Me.Unitario1.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@19", Nz(Me.Total1.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@20", Nz(Me.Qtd2.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@21", Nz(Me.Desc2.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@22", Nz(Me.Unitario2.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@23", Nz(Me.Total2.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@24", Nz(Me.Qtd3.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@25", Nz(Me.Desc3.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@26", Nz(Me.Unitario3.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@27", Nz(Me.Total3.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@28", Nz(Me.Qtd4.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@29", Nz(Me.Desc4.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@30", Nz(Me.Unitario4.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@31", Nz(Me.Total4.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@32", Nz(Me.Qtd5.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@33", Nz(Me.Desc5.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@34", Nz(Me.Unitario5.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@35", Nz(Me.Total5.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@36", Nz(Me.Qtd6.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@37", Nz(Me.Desc6.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@38", Nz(Me.Unitario6.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@39", Nz(Me.Total6.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@40", Nz(Me.Qtd7.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@41", Nz(Me.Desc7.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@42", Nz(Me.Unitario7.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@43", Nz(Me.Total7.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@44", Nz(Me.Qtd8.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@45", Nz(Me.Desc8.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@46", Nz(Me.Unitario8.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@47", Nz(Me.Total8.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@48", Nz(Me.Qtd9.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@49", Nz(Me.Desc9.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@50", Nz(Me.Unitario9.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@51", Nz(Me.Total9.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@52", Nz(Me.Qtd10.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@53", Nz(Me.Desc10.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@54", Nz(Me.Unitario10.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@55", Nz(Me.Total10.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@56", Nz(Me.BaseCalcIsqn.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@57", Nz(Me.ValorIsqnSubstituição.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@58", Nz(Me.ValorIsqn.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@59", Nz(Me.TotalNota.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@60", Nz(Me.Status.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@61", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@62", Nz(Me.Pedido.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Nota Fiscal Atualizada com sucesso", 64, "Validação de Dados")
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, False)
        End If

    End Sub

    Private Sub Propriedade_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Propriedade.KeyDown
        If e.KeyCode = Keys.F5 Then
            If Me.Cliente.Text = "" Then
                MsgBox("Não existe cliente definido para procura de propriedades.", 64, "Validação de Dados")
                Exit Sub
            End If
            RetornoProcura = ""
            My.Forms.ProcuraPropriedades.ShowDialog()
            Me.Propriedade.Text = RetornoProcura
        End If
    End Sub

    Private Sub Propriedade_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Propriedade.Validated
        If Me.Propriedade.Text <> "" Then

            Dim Sql As String = "Select * from Propriedades where Id = " & Me.Propriedade.Text
            Dim CMD As New OleDb.OleDbCommand(Sql, Cn)
            Dim DR As OleDb.OleDbDataReader

            DR = CMD.ExecuteReader
            DR.Read()

            If DR.HasRows = True Then
                If DR.Item("Cliente") <> Me.Cliente.Text Then
                    MsgBox("Esta Propriedade não pertence a este Cliente, favor verificar.", 64, "Validação de Dados")
                    Me.Propriedade.Text = ""
                    Me.PropriedadeNome.Text = ""
                    Me.Cliente.Focus()
                    Exit Sub
                End If
                Me.InscEstadual.Text = DR.Item("Inscricao") & ""
                Me.PropriedadeNome.Text = DR.Item("NomePropriedade") & ""
                Me.Endereço.Text = DR.Item("Endereco") & ""
                Me.Cep.Text = DR.Item("Cep") & ""
                Me.UF.Text = DR.Item("Estado") & ""
                Me.Cidade.Text = DR.Item("Cidade") & ""
                Me.Fone.Text = DR.Item("Fone") & ""
                Me.Bairro.Text = ""
            End If
            DR.Close()

        End If
    End Sub

    Private Sub NNota_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles NNota.Validated
        If Me.NNota.Text = "" Then
            MsgBox("O usuário deve informar o numero da nota fiscal.", 64, "Validação de Dados")
            Me.NNota.Focus()
            Exit Sub
        End If


        Dim Sql As String = "Select * from NotaFiscalServiço where NNota = " & Me.NNota.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, Cn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows = True Then

            Me.NNota.Text = DR.Item("NNota") & ""
            Me.DataEmissão.Text = DR.Item("DataEmissão") & ""
            Me.NatOperação.Text = DR.Item("NatOperação") & ""
            Me.Cliente.Text = DR.Item("Cliente") & ""
            Me.ClienteNome.Text = DR.Item("ClienteNome") & ""
            Me.Propriedade.Text = DR.Item("Propriedade") & ""
            Me.Endereço.Text = DR.Item("Endereço") & ""
            Me.Bairro.Text = DR.Item("Bairro") & ""
            Me.Cidade.Text = DR.Item("Cidade") & ""
            Me.UF.Text = DR.Item("UF") & ""
            Me.Fone.Text = DR.Item("Fone") & ""
            Me.Cep.Text = DR.Item("Cep") & ""
            Me.InscEstadual.Text = DR.Item("InscEstadual") & ""
            Me.CnpjCpf.Text = DR.Item("CnpjCpf") & ""
            Me.InscMunicipal.Text = DR.Item("InscMunicipal") & ""
            Me.Qtd1.Text = DR.Item("Qtd1") & ""
            Me.Desc1.Text = DR.Item("Desc1") & ""
            Me.Unitario1.Text = FormatCurrency(NzZero(DR.Item("Unitario1")), 2)
            Me.Total1.Text = FormatCurrency(NzZero(DR.Item("Total1")), 2)
            Me.Qtd2.Text = DR.Item("Qtd2") & ""
            Me.Desc2.Text = DR.Item("Desc2") & ""
            Me.Unitario2.Text = FormatCurrency(NzZero(DR.Item("Unitario2")), 2)
            Me.Total2.Text = FormatCurrency(NzZero(DR.Item("Total2")), 2)
            Me.Qtd3.Text = DR.Item("Qtd3") & ""
            Me.Desc3.Text = DR.Item("Desc3") & ""
            Me.Unitario3.Text = FormatCurrency(NzZero(DR.Item("Unitario3")), 2)
            Me.Total3.Text = FormatCurrency(NzZero(DR.Item("Total3")), 2)
            Me.Qtd4.Text = DR.Item("Qtd4") & ""
            Me.Desc4.Text = DR.Item("Desc4") & ""
            Me.Unitario4.Text = FormatCurrency(NzZero(DR.Item("Unitario4")), 2)
            Me.Total4.Text = FormatCurrency(NzZero(DR.Item("Total4")), 2)
            Me.Qtd5.Text = DR.Item("Qtd5") & ""
            Me.Desc5.Text = DR.Item("Desc5") & ""
            Me.Unitario5.Text = FormatCurrency(NzZero(DR.Item("Unitario5")), 2)
            Me.Total5.Text = FormatCurrency(NzZero(DR.Item("Total5")), 2)
            Me.Qtd6.Text = DR.Item("Qtd6") & ""
            Me.Desc6.Text = DR.Item("Desc6") & ""
            Me.Unitario6.Text = FormatCurrency(NzZero(DR.Item("Unitario6")), 2)
            Me.Total6.Text = FormatCurrency(NzZero(DR.Item("Total6")), 2)
            Me.Qtd7.Text = DR.Item("Qtd7") & ""
            Me.Desc7.Text = DR.Item("Desc7") & ""
            Me.Unitario7.Text = FormatCurrency(NzZero(DR.Item("Unitario7")), 2)
            Me.Total7.Text = FormatCurrency(NzZero(DR.Item("Total7")), 2)
            Me.Qtd8.Text = DR.Item("Qtd8") & ""
            Me.Desc8.Text = DR.Item("Desc8") & ""
            Me.Unitario8.Text = FormatCurrency(NzZero(DR.Item("Unitario8")), 2)
            Me.Total8.Text = FormatCurrency(NzZero(DR.Item("Total8")), 2)
            Me.Qtd9.Text = DR.Item("Qtd9") & ""
            Me.Desc9.Text = DR.Item("Desc9") & ""
            Me.Unitario9.Text = FormatCurrency(NzZero(DR.Item("Unitario9")), 2)
            Me.Total9.Text = FormatCurrency(NzZero(DR.Item("Total9")), 2)
            Me.Qtd10.Text = DR.Item("Qtd10") & ""
            Me.Desc10.Text = DR.Item("Desc10") & ""
            Me.Unitario10.Text = FormatCurrency(NzZero(DR.Item("Unitario10")), 2)
            Me.Total10.Text = FormatCurrency(NzZero(DR.Item("Total10")), 2)
            Me.BaseCalcIsqn.Text = FormatCurrency(NzZero(DR.Item("BaseCalcIsqn")), 2)
            Me.ValorIsqnSubstituição.Text = FormatCurrency(NzZero(DR.Item("ValorIsqnSubstituição")), 2)
            Me.ValorIsqn.Text = FormatCurrency(NzZero(DR.Item("ValorIsqn")), 2)
            Me.TotalNota.Text = FormatCurrency(NzZero(DR.Item("TotalNota")), 2)
            Me.Status.Text = DR.Item("Status") & ""
            Me.Pedido.Text = DR.Item("Pedido") & ""
            If Me.Status.Text = "E" Then
                Operation = INS
                Ação.Desbloquear_Controle(Me, False)
            Else
                Operation = UPD
            End If
        End If
        DR.Close()
    End Sub


#Region "Impressão da Nota Fiscal"

    Public Sub ImprimirNf()


        Dim Key As RegistryKey = Registry.LocalMachine
        Dim PegaKey As RegistryKey = Key.OpenSubKey("Software\\E-FocusNF\\Conf")

        Try
            NomeFormulario = PegaKey.GetValue("FormPadraoServiço", ".")
            ImpressPadrão = PegaKey.GetValue("ImpressNf", 0)

            If NomeFormulario = "." Then
                MsgBox("Não existe formulario padrão, favor definir.", 64, "Validação de Dados")
                Exit Sub
            End If
        Catch
            MsgBox("Não existe configuração definida, favor verificar", 64, "Exportação de Dados")
            Exit Sub
        End Try

        ' Dim ppd As New PrintPreviewDialog()

        Try
            'ppd.Document = PDoc

            With PDoc.DefaultPageSettings
                .Landscape = False
                .Margins.Bottom = 0
                .Margins.Left = 0
                .Margins.Right = 0
                .Margins.Top = 0
            End With

            'ppd.WindowState = FormWindowState.Maximized
            'ppd.PrintPreviewControl.Zoom = 1
            'ppd.Text = "Impressão de Nota Fiscal"

            'ppd.ShowDialog()

            PDoc.PrinterSettings.PrinterName = ImpressPadrão

            If PDoc.PrinterSettings.IsValid Then
                PDoc.Print()
            Else
                MsgBox("Impressora invalida")
            End If

        Catch exp As Exception
            MsgBox("Erro ao carregar a impressão", 64, "Impressão de Nota Fiscal")
        End Try

    End Sub

    Private Sub PDoc_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PDoc.PrintPage
        'Environment.CommandLine 
        'Abertura de Banco de Dados para fazer o posicionamento das informações

        ' If CmdLine = "" Then
        ' MsgBox("O usuário deve definir primeiro o numero da nota fiscal a ser impresso.", 64, "Impressão de Nf")
        ' Exit Sub
        ' End If

        'dados da Nf
        Dim Sql As String = "Select * from NotaFiscalServiço where NNota = " & Me.NNota.Text
        Dim CMD As New OleDbCommand(Sql, Cn)
        Dim DR As OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        Dim STRNF As String = DR.Item("NNota") & ""
        Dim StrEmissao As String = DR.Item("DataEmissão") & ""
        Dim STRNatOperação As String = DR.Item("NatOperação") & ""
        Dim STRCliente As String = DR.Item("Cliente") & ""
        Dim STRClienteNome As String = DR.Item("ClienteNome") & ""
        Dim STREndereço As String = DR.Item("Endereço") & ""
        Dim STRBairro As String = DR.Item("Bairro") & ""
        Dim STRCidade As String = DR.Item("Cidade") & ""
        Dim StrUF As String = DR.Item("UF") & ""
        Dim StrFone As String = DR.Item("Fone") & ""
        Dim StrCep As String = DR.Item("Cep") & ""
        Dim StrInscEstadual As String = DR.Item("InscEstadual") & ""
        Dim StrCnpjCpf As String = DR.Item("CnpjCpf") & ""
        Dim StrInscMunicipal As String = DR.Item("InscMunicipal") & ""

        Dim StrQtd1 As String = DR.Item("Qtd1") & ""
        Dim StrDesc1 As String = DR.Item("Desc1") & ""
        Dim StrUnitario1 As String = FormatNumber(Nz(DR.Item("Unitario1"), 3), 2)
        Dim StrTotal1 As String = FormatNumber(Nz(DR.Item("Total1"), 3), 2)

        Dim StrQtd2 As String = DR.Item("Qtd2") & ""
        Dim StrDesc2 As String = DR.Item("Desc2") & ""
        Dim StrUnitario2 As String = FormatNumber(Nz(DR.Item("Unitario2"), 3), 2)
        Dim StrTotal2 As String = FormatNumber(Nz(DR.Item("Total2"), 3), 2)

        Dim StrQtd3 As String = DR.Item("Qtd3") & ""
        Dim StrDesc3 As String = DR.Item("Desc3") & ""
        Dim StrUnitario3 As String = FormatNumber(Nz(DR.Item("Unitario3"), 3), 2)
        Dim StrTotal3 As String = FormatNumber(Nz(DR.Item("Total3"), 3), 2)

        Dim StrQtd4 As String = DR.Item("Qtd4") & ""
        Dim StrDesc4 As String = DR.Item("Desc4") & ""
        Dim StrUnitario4 As String = FormatNumber(Nz(DR.Item("Unitario4"), 3), 2)
        Dim StrTotal4 As String = FormatNumber(Nz(DR.Item("Total4"), 3), 2)

        Dim StrQtd5 As String = DR.Item("Qtd5") & ""
        Dim StrDesc5 As String = DR.Item("Desc5") & ""
        Dim StrUnitario5 As String = FormatNumber(Nz(DR.Item("Unitario5"), 3), 2)
        Dim StrTotal5 As String = FormatNumber(Nz(DR.Item("Total5"), 3), 2)

        Dim StrQtd6 As String = DR.Item("Qtd6") & ""
        Dim StrDesc6 As String = DR.Item("Desc6") & ""
        Dim StrUnitario6 As String = FormatNumber(Nz(DR.Item("Unitario6"), 3), 2)
        Dim StrTotal6 As String = FormatNumber(Nz(DR.Item("Total6"), 3), 2)

        Dim StrQtd7 As String = DR.Item("Qtd7") & ""
        Dim StrDesc7 As String = DR.Item("Desc7") & ""
        Dim StrUnitario7 As String = FormatNumber(Nz(DR.Item("Unitario7"), 3), 2)
        Dim StrTotal7 As String = FormatNumber(Nz(DR.Item("Total7"), 3), 2)

        Dim StrQtd8 As String = DR.Item("Qtd8") & ""
        Dim StrDesc8 As String = DR.Item("Desc8") & ""
        Dim StrUnitario8 As String = FormatNumber(Nz(DR.Item("Unitario8"), 3), 2)
        Dim StrTotal8 As String = FormatNumber(Nz(DR.Item("Total8"), 3), 2)

        Dim StrQtd9 As String = DR.Item("Qtd9") & ""
        Dim StrDesc9 As String = DR.Item("Desc9") & ""
        Dim StrUnitario9 As String = FormatNumber(Nz(DR.Item("Unitario9"), 3), 2)
        Dim StrTotal9 As String = FormatNumber(Nz(DR.Item("Total9"), 3), 2)

        Dim StrQtd10 As String = DR.Item("Qtd10") & ""
        Dim StrDesc10 As String = DR.Item("Desc10") & ""
        Dim StrUnitario10 As String = FormatNumber(Nz(DR.Item("Unitario10"), 3), 2)
        Dim StrTotal10 As String = FormatNumber(Nz(DR.Item("Total10"), 3), 2)


        Dim StrBaseCalcIsqn As String = FormatNumber(Nz(DR.Item("BaseCalcIsqn"), 3), 2)
        Dim StrValorIsqnSubstituição As String = FormatNumber(Nz(DR.Item("ValorIsqnSubstituição"), 3), 2)
        Dim StrValorIsqn As String = FormatNumber(Nz(DR.Item("ValorIsqn"), 3), 2)
        Dim StrTotalNota As String = FormatNumber(Nz(DR.Item("TotalNota"), 3), 2)

        DR.Close()


        'Dados de posições da Nota 
        Sql = "Select * from ConfNfServiço where NomeConfiguração = '" & NomeFormulario & "'"
        CMD.CommandText = Sql
        Try
            DR = CMD.ExecuteReader
            DR.Read()

        Catch px As Exception
            MsgBox("Não foi possiver ler o banco de dados de posições", 64, "Validação de Dados")
            Exit Sub
        End Try

        'INICIO DA VARIAVEIS DE POSIÇÃO
        Dim EmissaoX As Integer = DR.Item("EmissaoX") & ""
        Dim EmissaoY As Integer = DR.Item("EmissaoY") & ""
        Dim NtOperaçãoX As Integer = DR.Item("NtOperaçãoX") & ""
        Dim NtOperaçãoY As Integer = DR.Item("NtOperaçãoY") & ""
        Dim ClienteX As Integer = DR.Item("ClienteX") & ""
        Dim ClienteY As Integer = DR.Item("ClienteY") & ""
        Dim EndereçoX As Integer = DR.Item("EndereçoX") & ""
        Dim EndereçoY As Integer = DR.Item("EndereçoY") & ""
        Dim BairroX As Integer = DR.Item("BairroX") & ""
        Dim BairroY As Integer = DR.Item("BairroY") & ""
        Dim CidadeX As Integer = DR.Item("CidadeX") & ""
        Dim CidadeY As Integer = DR.Item("CidadeY") & ""
        Dim UFX As Integer = DR.Item("UFX") & ""
        Dim UFY As Integer = DR.Item("UFY") & ""
        Dim FoneX As Integer = DR.Item("FoneX") & ""
        Dim FoneY As Integer = DR.Item("FoneY") & ""
        Dim CepX As Integer = DR.Item("CepX") & ""
        Dim CepY As Integer = DR.Item("CepY") & ""
        Dim InscEstadualX As Integer = DR.Item("InscEstadualX") & ""
        Dim InscEstadualY As Integer = DR.Item("InscEstadualY") & ""
        Dim CnpjX As Integer = DR.Item("CnpjX") & ""
        Dim CnpjY As Integer = DR.Item("CnpjY") & ""
        Dim InscMunicipalX As Integer = DR.Item("InscMunicipalX") & ""
        Dim InscMunicipalY As Integer = DR.Item("InscMunicipalY") & ""
        Dim QtdX As Integer = DR.Item("QtdX") & ""
        Dim QtdY As Integer = DR.Item("QtdY") & ""
        Dim DescriçãoServX As Integer = DR.Item("DescriçãoServX") & ""
        Dim DescriçãoServY As Integer = DR.Item("DescriçãoServY") & ""
        Dim UnitarioX As Integer = DR.Item("UnitarioX") & ""
        Dim UnitarioY As Integer = DR.Item("UnitarioY") & ""
        Dim TotalX As Integer = DR.Item("TotalX") & ""
        Dim TotalY As Integer = DR.Item("TotalY") & ""
        Dim AliquotaX As Integer = DR.Item("AliquotaX") & ""
        Dim AliquotaY As Integer = DR.Item("AliquotaY") & ""
        Dim BaseCalcIsqnX As Integer = DR.Item("BaseCalcIsqnX") & ""
        Dim BaseCalcIsqnY As Integer = DR.Item("BaseCalcIsqnY") & ""
        Dim ValorIsqnSubstituiçãoX As Integer = DR.Item("ValorIsqnSubstituiçãoX") & ""
        Dim ValorIsqnSubstituiçãoY As Integer = DR.Item("ValorIsqnSubstituiçãoY") & ""
        Dim ValorIssqnX As Integer = DR.Item("ValorIssqnX") & ""
        Dim ValorIssqnY As Integer = DR.Item("ValorIssqnY") & ""
        Dim TotalNotaX As Integer = DR.Item("TotalNotaX") & ""
        Dim TotalNotaY As Integer = DR.Item("TotalNotaY") & ""

        Dim AlturaLinhaNoCorpo As Integer = DR.Item("AlturaLinhaNoCorpo") & ""
        Dim TotalLinhaNoCorpo As Integer = DR.Item("TotalLinhaNoCorpo") & ""
        Dim NomeFonte As String = DR.Item("NomeFonte") & ""
        Dim TamanhoFonte As Integer = DR.Item("TamanhoFonte") & ""
        'FIM DA VARIAVEIS DE POSIÇÕES
        DR.Close()


        Dim PosVertical As Single = 0
        Dim Contador As Integer = 0
        Dim LinhasPorPagina As Single = 0
        Dim LinhaAtual As Integer = 0
        Dim CanetaDaImpressora As Pen = New Pen(Color.Black, 1)

        Dim G As Graphics = e.Graphics
        Dim F As New Font(NomeFonte, TamanhoFonte, System.Drawing.GraphicsUnit.Point)





        'Data Emissão 
        Dim FF As New Font(NomeFonte, 9, System.Drawing.GraphicsUnit.Point)
        G.DrawString(StrEmissao, FF, Brushes.Black, EmissaoX, EmissaoY, New StringFormat())
        'Fim

        'Natureza da Operação 
        G.DrawString(STRNatOperação, F, Brushes.Black, NtOperaçãoX, NtOperaçãoY, New StringFormat())
        'Fim

        'Nome do Cliente 
        G.DrawString(STRClienteNome, F, Brushes.Black, ClienteX, ClienteY, New StringFormat())
        'Fim

        'Endereço 
        G.DrawString(STREndereço, F, Brushes.Black, EndereçoX, EndereçoY, New StringFormat())
        'Fim

        'Bairro 
        G.DrawString(STRBairro, F, Brushes.Black, BairroX, BairroY, New StringFormat())
        'Fim

        'Cidade 
        G.DrawString(STRCidade, F, Brushes.Black, CidadeX, CidadeY, New StringFormat())
        'Fim

        'Estado 
        G.DrawString(StrUF, F, Brushes.Black, UFX, UFY, New StringFormat())
        'Fim

        'Telefone 
        G.DrawString(StrFone, F, Brushes.Black, FoneX, FoneY, New StringFormat())
        'Fim

        'Cep 
        G.DrawString(StrCep, F, Brushes.Black, CepX, CepY, New StringFormat())
        'Fim

        'Inscrição Estadual 
        G.DrawString(StrInscEstadual, F, Brushes.Black, InscEstadualX, InscEstadualY, New StringFormat())
        'Fim

        'Cnpj/cpf 
        G.DrawString(StrCnpjCpf, F, Brushes.Black, CnpjX, CnpjY, New StringFormat())
        'Fim

        'Inscrição Municipal 
        G.DrawString(StrInscMunicipal, F, Brushes.Black, InscMunicipalX, InscMunicipalY, New StringFormat())
        'Fim

        'Começa aqui os Itens
        G.DrawString(StrQtd1, F, Brushes.Black, QtdX, QtdY, New StringFormat())
        G.DrawString(StrDesc1, F, Brushes.Black, DescriçãoServX, DescriçãoServY, New StringFormat())
        G.DrawString(TZeros(StrUnitario1), F, Brushes.Black, UnitarioX, UnitarioY, New StringFormat())
        G.DrawString(TZeros(StrTotal1), F, Brushes.Black, TotalX, TotalY, New StringFormat())
        G.DrawString("", F, Brushes.Black, AliquotaX, AliquotaY, New StringFormat()) 'Servira para Aliquota

        Dim AlturaTemp As Integer = 0
        AlturaTemp = QtdY + AlturaLinhaNoCorpo

        G.DrawString(StrQtd2, F, Brushes.Black, QtdX, AlturaTemp, New StringFormat())
        G.DrawString(StrDesc2, F, Brushes.Black, DescriçãoServX, AlturaTemp, New StringFormat())
        G.DrawString(TZeros(StrUnitario2), F, Brushes.Black, UnitarioX, AlturaTemp, New StringFormat())
        G.DrawString(TZeros(StrTotal2), F, Brushes.Black, TotalX, AlturaTemp, New StringFormat())
        G.DrawString("", F, Brushes.Black, AliquotaX, AlturaTemp, New StringFormat()) 'Servira para Aliquota

        AlturaTemp += AlturaLinhaNoCorpo

        G.DrawString(StrQtd3, F, Brushes.Black, QtdX, AlturaTemp, New StringFormat())
        G.DrawString(StrDesc3, F, Brushes.Black, DescriçãoServX, AlturaTemp, New StringFormat())
        G.DrawString(TZeros(StrUnitario3), F, Brushes.Black, UnitarioX, AlturaTemp, New StringFormat())
        G.DrawString(TZeros(StrTotal3), F, Brushes.Black, TotalX, AlturaTemp, New StringFormat())
        G.DrawString("", F, Brushes.Black, AliquotaX, AlturaTemp, New StringFormat()) 'Servira para Aliquota

        AlturaTemp += AlturaLinhaNoCorpo

        G.DrawString(StrQtd4, F, Brushes.Black, QtdX, AlturaTemp, New StringFormat())
        G.DrawString(StrDesc4, F, Brushes.Black, DescriçãoServX, AlturaTemp, New StringFormat())
        G.DrawString(TZeros(StrUnitario4), F, Brushes.Black, UnitarioX, AlturaTemp, New StringFormat())
        G.DrawString(TZeros(StrTotal4), F, Brushes.Black, TotalX, AlturaTemp, New StringFormat())
        G.DrawString("", F, Brushes.Black, AliquotaX, AlturaTemp, New StringFormat()) 'Servira para Aliquota

        AlturaTemp += AlturaLinhaNoCorpo

        G.DrawString(StrQtd5, F, Brushes.Black, QtdX, AlturaTemp, New StringFormat())
        G.DrawString(StrDesc5, F, Brushes.Black, DescriçãoServX, AlturaTemp, New StringFormat())
        G.DrawString(TZeros(StrUnitario5), F, Brushes.Black, UnitarioX, AlturaTemp, New StringFormat())
        G.DrawString(TZeros(StrTotal5), F, Brushes.Black, TotalX, AlturaTemp, New StringFormat())
        G.DrawString("", F, Brushes.Black, AliquotaX, AlturaTemp, New StringFormat()) 'Servira para Aliquota

        AlturaTemp += AlturaLinhaNoCorpo

        G.DrawString(StrQtd6, F, Brushes.Black, QtdX, AlturaTemp, New StringFormat())
        G.DrawString(StrDesc6, F, Brushes.Black, DescriçãoServX, AlturaTemp, New StringFormat())
        G.DrawString(TZeros(StrUnitario6), F, Brushes.Black, UnitarioX, AlturaTemp, New StringFormat())
        G.DrawString(TZeros(StrTotal6), F, Brushes.Black, TotalX, AlturaTemp, New StringFormat())
        G.DrawString("", F, Brushes.Black, AliquotaX, AlturaTemp, New StringFormat()) 'Servira para Aliquota

        AlturaTemp += AlturaLinhaNoCorpo

        G.DrawString(StrQtd7, F, Brushes.Black, QtdX, AlturaTemp, New StringFormat())
        G.DrawString(StrDesc7, F, Brushes.Black, DescriçãoServX, AlturaTemp, New StringFormat())
        G.DrawString(TZeros(StrUnitario7), F, Brushes.Black, UnitarioX, AlturaTemp, New StringFormat())
        G.DrawString(TZeros(StrTotal7), F, Brushes.Black, TotalX, AlturaTemp, New StringFormat())
        G.DrawString("", F, Brushes.Black, AliquotaX, AlturaTemp, New StringFormat()) 'Servira para Aliquota

        AlturaTemp += AlturaLinhaNoCorpo

        G.DrawString(StrQtd8, F, Brushes.Black, QtdX, AlturaTemp, New StringFormat())
        G.DrawString(StrDesc8, F, Brushes.Black, DescriçãoServX, AlturaTemp, New StringFormat())
        G.DrawString(TZeros(StrUnitario8), F, Brushes.Black, UnitarioX, AlturaTemp, New StringFormat())
        G.DrawString(TZeros(StrTotal8), F, Brushes.Black, TotalX, AlturaTemp, New StringFormat())
        G.DrawString("", F, Brushes.Black, AliquotaX, AlturaTemp, New StringFormat()) 'Servira para Aliquota

        AlturaTemp += AlturaLinhaNoCorpo

        G.DrawString(StrQtd9, F, Brushes.Black, QtdX, AlturaTemp, New StringFormat())
        G.DrawString(StrDesc9, F, Brushes.Black, DescriçãoServX, AlturaTemp, New StringFormat())
        G.DrawString(TZeros(StrUnitario9), F, Brushes.Black, UnitarioX, AlturaTemp, New StringFormat())
        G.DrawString(TZeros(StrTotal9), F, Brushes.Black, TotalX, AlturaTemp, New StringFormat())
        G.DrawString("", F, Brushes.Black, AliquotaX, AlturaTemp, New StringFormat()) 'Servira para Aliquota

        AlturaTemp += AlturaLinhaNoCorpo

        G.DrawString(StrQtd10, F, Brushes.Black, QtdX, AlturaTemp, New StringFormat())
        G.DrawString(StrDesc10, F, Brushes.Black, DescriçãoServX, AlturaTemp, New StringFormat())
        G.DrawString(TZeros(StrUnitario10), F, Brushes.Black, UnitarioX, AlturaTemp, New StringFormat())
        G.DrawString(TZeros(StrTotal10), F, Brushes.Black, TotalX, AlturaTemp, New StringFormat())
        G.DrawString("", F, Brushes.Black, AliquotaX, AlturaTemp, New StringFormat()) 'Servira para Aliquota

        'Fim dos Itens


        'StrBaseCalcIsqn 
        G.DrawString(StrBaseCalcIsqn, F, Brushes.Black, BaseCalcIsqnX, BaseCalcIsqnY, New StringFormat())
        'Fim

        'StrValorIsqnSubstituição
        G.DrawString(StrValorIsqnSubstituição, F, Brushes.Black, ValorIsqnSubstituiçãoX, ValorIsqnSubstituiçãoY, New StringFormat())
        'Fim

        'StrValorIsqn
        G.DrawString(StrValorIsqn, F, Brushes.Black, ValorIssqnX, ValorIssqnY, New StringFormat())
        'Fim

        'StrTotalNota
        G.DrawString(StrTotalNota, F, Brushes.Black, TotalNotaX, TotalNotaY, New StringFormat())
        'Fim



    End Sub

    Public Function TZeros(ByVal Txt As Double) As String
        If Txt = 0 Then
            Return ""
        Else
            Return FormatCurrency(Txt, 2)
        End If
    End Function


    Private Sub VisualizarNF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisualizarNF.Click
        If Me.Status.Text = "E" Then
            MsgBox("Esta nota fiscal já foi emitida verifique a impressão.", 64, "Validação de Dados")
        End If

        Dim ppd As New PrintPreviewDialog()

        Dim Key As RegistryKey = Registry.LocalMachine
        Dim PegaKey As RegistryKey = Key.OpenSubKey("Software\\E-FocusNF\\Conf")

        Try
            NomeFormulario = PegaKey.GetValue("FormPadraoServiço", ".")
            ImpressPadrão = PegaKey.GetValue("ImpressNf", 0)

            If NomeFormulario = "." Then
                MsgBox("Não existe formulario padrão, favor definir.", 64, "Validação de Dados")
                Exit Sub
            End If
        Catch
            MsgBox("Não existe configuração definida, favor verificar", 64, "Exportação de Dados")
            Exit Sub
        End Try


        'Dim L As Integer = 23 * 38
        'Dim C As Integer = 27 * 38

        'Dim Papel As New PaperSize("Custom Paper Size", 900, 1000)


        Try
            ppd.Document = PDoc

            With PDoc.DefaultPageSettings
                .Landscape = False
                '.PaperSize = Papel
                .Margins.Bottom = 0
                .Margins.Left = 0
                .Margins.Right = 0
                .Margins.Top = 0
            End With

            ppd.WindowState = FormWindowState.Maximized
            ppd.PrintPreviewControl.Zoom = 1
            ppd.Text = "Impressão de Nota Fiscal Serviço"

            PDoc.PrinterSettings.PrinterName = ImpressPadrão

            If PDoc.PrinterSettings.IsValid Then
                ppd.ShowDialog()
                If Me.Status.Text <> "E" Then
                    If MsgBox("Deseja mudar a nota para emitida.", 36, "Validação de Dados") = 6 Then
                        Operation = UPD
                        Me.Status.Text = "E"
                        Salvar_Click(sender, e)
                    End If
                End If
            Else
                MsgBox("Impressora invalida")
            End If

        Catch exp As Exception
            MsgBox("Erro ao carregar a impressão", 64, "Impressão de Nota Fiscal")
        End Try

    End Sub
#End Region
End Class