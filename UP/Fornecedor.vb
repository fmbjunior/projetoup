Imports Microsoft.Win32

Public Class Fornecedor

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2
    Const VAZ As Byte = 5

    Dim CNN As OleDb.OleDbConnection

    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        CNN.Close()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Fornecedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        TeclasAtalho(sender, e)
    End Sub

    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EncheListaPais()
        EncheListaUF()

        CNN = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Degrade()
        Ação.Desbloquear_Controle(Me, False)
        CNN.Open()
        Me.Inativo.Enabled = False
    End Sub

    Private Sub NovoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click
        Ação.LimpaTextBox(Me)
        Me.cMun.SelectedIndex = -1
        Me.cUF.SelectedIndex = -1
        Me.cPais.SelectedIndex = -1

        Ação.Desbloquear_Controle(Me, True)
        Me.CódigoFornecedor.Enabled = False
        Me.CódigoFornecedor.Text = "0000"

        My.Forms.FornecedorCPFCNPJ.ShowDialog()
        AchaCPFCNPJ()

        Me.TipoFornecedor.Focus()
        Operation = INS
        Me.Inativo.Enabled = False
    End Sub

    Private Sub EncheListaPais()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT * FROM Paises order by DescPais"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.cPais.DataSource = ds.Tables("Table").DefaultView
        Me.cPais.DisplayMember = "DescPais"
        Me.cPais.ValueMember = "CodPais"
        Me.cPais.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub EncheListaUF()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT * FROM UF order by NomeUF"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.cUF.DataSource = ds.Tables("Table").DefaultView
        Me.cUF.DisplayMember = "NomeUF"
        Me.cUF.ValueMember = "CodigoUF"
        Me.cUF.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub EncheListaMunicipio()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT * FROM Municipio where UF = '" & Me.cUF.SelectedValue & "' order by NomeMunic"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.cMun.DataSource = ds.Tables("Table").DefaultView
        Me.cMun.DisplayMember = "NomeMunic"
        Me.cMun.ValueMember = "CodMunicipio"
        Me.cMun.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click
        If Adi = False Then
            MsgBox("O usuário não tem permissão para esta operação. Verifique.", 64, "Validação de Dados")
            Exit Sub
        End If
        'Area destinada para as validacoes
        If Me.CódigoFornecedor.Text = "" Then
            MsgBox("O Código do fornecedor não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.CódigoFornecedor.Focus()
            Exit Sub
        ElseIf Me.RazãoSocial.Text = "" Then
            MsgBox("O Nome do fornecedor não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.RazãoSocial.Focus()
            Exit Sub
        ElseIf Me.NomeFantasia.Text = "" Then
            MsgBox("O Nome Fantasia do fornecedor não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.NomeFantasia.Focus()
            Exit Sub
        ElseIf Me.TipoFornecedor.Text = "" Then
            MsgBox("O Tipo do fornecedor não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.TipoFornecedor.Focus()
            Exit Sub
        ElseIf Me.CgcCpf.Text = "" Then
            MsgBox("O Cpf/Cnpj do Cliente não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.CgcCpf.Focus()
            Exit Sub
        End If

        If Me.cUF.Text = "" Then
            MsgBox("Favor informar a UF do endereço do fornecedor.", 64, "Validação de Dados")
            Me.cUF.Focus()
            Exit Sub
        End If
        If Me.Nro.Text = "" Then
            MsgBox("Favor informar o numero do endereço do fornecedor.", 64, "Validação de Dados")
            Me.Nro.Focus()
            Exit Sub
        End If
        If Me.cMun.Text = "" Then
            MsgBox("Favor informar o municipio do endereço do fornecedor.", 64, "Validação de Dados")
            Me.cMun.Focus()
            Exit Sub
        End If
        If Me.Nro.Text = "" Then
            MsgBox("Favor informar o Pais do endereço do fornecedor.", 64, "Validação de Dados")
            Me.cPais.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        'If Ação.ChecaInscrE(Me.Estado.Text, Me.IncriçãoEstadual.Text) = False Then
        ' MsgBox("A Inscrição Estadual informada não é válida !!!", vbCritical, "Validação de Dados")
        ' Me.Estado.Focus()
        ' Exit Sub
        ' End If


        Me.Cidade.Text = Me.cMun.Text

        If Operation = INS Then

            UltimoReg()

            Dim Sql As String = "INSERT INTO Fornecedor (CódigoFornecedor, TipoFornecedor, CgcCpf, IncriçãoEstadual, RazãoSocial, NomeFantasia, Endereço, Cidade, Estado, Cep , Telefone1, Telefone2, Fone0800, Fax, Contato, Email, CartaoNatal, Empresa, Inativo, Bairro, Observação, EndCorrespondencia, CidCorrespondencia, UFCorrespondencia, BairroCorrespondencia, CepCorrespondencia, Banco, ContaCorrente, AgenciaBancaria, nro, xCpl, cMun, cPais, xPais, cUF) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22, @23, @24, @25, @26, @27, @28, @29, @30, @31, @32, @33, @34, @35)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CódigoFornecedor.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.TipoFornecedor.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.CgcCpf.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.IncriçãoEstadual.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.RazãoSocial.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.NomeFantasia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Endereço.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Cidade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Estado.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.Cep.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Telefone1.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.Telefone2.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.Fone0800.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.Fax.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.Contato.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.Email.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Me.CartaoNatal.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@18", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@19", Me.Inativo.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@20", Nz(Me.Bairro.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@21", Nz(Me.Observação.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@22", Nz(Me.EndCorrespondencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@23", Nz(Me.CidCorrespondencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@24", Nz(Me.UFCorrespondencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@25", Nz(Me.BairroCorrespondencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@26", Nz(Me.CepCorrespondencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@27", Nz(Me.Banco.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@28", Nz(Me.ContaCorrente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@29", Nz(Me.AgenciaBancaria.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@30", Nz(Me.Nro.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@31", Nz(Me.xCpl.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@32", Nz(Me.cMun.SelectedValue, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@33", Nz(Me.cPais.SelectedValue, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@34", Nz(Me.cPais.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@35", Nz(Me.cUF.SelectedValue, 1)))

            Try
                cmd.ExecuteNonQuery()
                Operation = VAZ
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Adicionou, Me.CódigoFornecedor.Text)
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            Ação.Desbloquear_Controle(Me, False)

        ElseIf Operation = UPD Then


            Dim Sql As String = "Update Fornecedor set TipoFornecedor = @3, CgcCpf = @4, IncriçãoEstadual = @5, RazãoSocial = @6, NomeFantasia = @7, Endereço = @8, Cidade = @9, Estado = @10, Cep = @11, Telefone1 = @12, Telefone2 = @13, Fone0800 = @14, Fax = @15, Contato = @16, Email = @17, CartaoNatal = @18, Empresa = @19, Inativo = @20, Bairro = @21, Observação = @22, EndCorrespondencia = @23, CidCorrespondencia = @24, UFCorrespondencia = @25, BairroCorrespondencia = @26, CepCorrespondencia = @27, Banco = @28, ContaCorrente = @29, AgenciaBancaria = @30, nro = @31, xCpl = @32, cMun = @33, cPais = @34, xPais = @35, cUF = @36 Where CódigoFornecedor = " & Me.CódigoFornecedor.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.TipoFornecedor.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.CgcCpf.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.IncriçãoEstadual.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.RazãoSocial.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.NomeFantasia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Endereço.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Cidade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.Estado.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Cep.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.Telefone1.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.Telefone2.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.Fone0800.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.Fax.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.Contato.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.Email.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Me.CartaoNatal.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@19", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@20", Me.Inativo.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@21", Nz(Me.Bairro.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@22", Nz(Me.Observação.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@23", Nz(Me.EndCorrespondencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@24", Nz(Me.CidCorrespondencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@25", Nz(Me.UFCorrespondencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@26", Nz(Me.BairroCorrespondencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@27", Nz(Me.CepCorrespondencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@28", Nz(Me.Banco.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@29", Nz(Me.ContaCorrente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@30", Nz(Me.AgenciaBancaria.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@31", Nz(Me.Nro.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@32", Nz(Me.xCpl.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@33", Nz(Me.cMun.SelectedValue, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@34", Nz(Me.cPais.SelectedValue, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@35", Nz(Me.cPais.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@36", Nz(Me.cUF.SelectedValue, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Editou, Me.CódigoFornecedor.Text)
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, False)
        End If

    End Sub

    Private Sub EditarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBT.Click
        If Edi = False Then
            MsgBox("O usuário não tem permissão para esta operação. Verifique.", 64, "Validação de Dados")
            Exit Sub
        End If

        If Me.CódigoFornecedor.Text = "" Then
            MsgBox("No existe Fornecedor para ser editado.", 64, "Validação de Dados")
            Exit Sub
        End If
        Operation = UPD
        Ação.Desbloquear_Controle(Me, True)
        Me.CódigoFornecedor.Enabled = False
        Me.TipoFornecedor.Focus()
        Me.Inativo.Enabled = False
    End Sub

    Private Sub LocalizarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizarBT.Click
        If Con = False Then
            MsgBox("O usuário não tem permissão para esta operação. Verifique.", 64, "Validação de Dados")
            Exit Sub
        End If

        Ação.Desbloquear_Controle(Me, False)
        My.Forms.TelaProcuraFor.ShowDialog()

        If Me.CódigoFornecedor.Text <> "" Then
            LocalizaDados()
            Me.CódigoFornecedor.Enabled = False
            Me.TipoFornecedor.Focus()
            Me.Inativo.Enabled = False
        End If
    End Sub

    Public Sub LocalizaDados()
        Me.cMun.SelectedIndex = -1
        Me.cUF.SelectedIndex = -1
        Me.cPais.SelectedIndex = -1

        Dim Sql As String = "Select * from Fornecedor where CódigoFornecedor = " & Me.CódigoFornecedor.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.CódigoFornecedor.Text = DR.Item("CódigoFornecedor") & ""
            Me.TipoFornecedor.Text = DR.Item("TipoFornecedor") & ""
            Me.CgcCpf.Text = DR.Item("CgcCpf") & ""
            Me.IncriçãoEstadual.Text = DR.Item("IncriçãoEstadual") & ""
            Me.RazãoSocial.Text = DR.Item("RazãoSocial") & ""
            Me.NomeFantasia.Text = DR.Item("NomeFantasia") & ""
            Me.Endereço.Text = DR.Item("Endereço") & ""
            Me.Cidade.Text = DR.Item("Cidade") & ""
            Me.Estado.Text = DR.Item("Estado") & ""
            Me.Cep.Text = DR.Item("Cep") & ""
            Me.Telefone1.Text = DR.Item("Telefone1") & ""
            Me.Telefone2.Text = DR.Item("Telefone2") & ""
            Me.Fone0800.Text = DR.Item("Fone0800") & ""
            Me.Fax.Text = DR.Item("Fax") & ""
            Me.Contato.Text = DR.Item("Contato") & ""
            Me.Email.Text = DR.Item("Email") & ""
            Me.CartaoNatal.Checked = DR.Item("CartaoNatal")
            Me.Inativo.Checked = DR.Item("Inativo")

            Me.Bairro.Text = DR.Item("Bairro") & ""
            Me.Observação.Text = DR.Item("Observação") & ""

            Me.EndCorrespondencia.Text = DR.Item("EndCorrespondencia") & ""
            Me.CidCorrespondencia.Text = DR.Item("CidCorrespondencia") & ""
            Me.UFCorrespondencia.Text = DR.Item("UFCorrespondencia") & ""
            Me.BairroCorrespondencia.Text = DR.Item("BairroCorrespondencia") & ""
            Me.CepCorrespondencia.Text = DR.Item("CepCorrespondencia") & ""

            Me.Banco.Text = DR.Item("Banco") & ""
            Me.ContaCorrente.Text = DR.Item("ContaCorrente") & ""
            Me.AgenciaBancaria.Text = DR.Item("AgenciaBancaria") & ""

            Me.Nro.Text = DR.Item("Nro") & ""
            Me.xCpl.Text = DR.Item("xCpl") & ""
            Me.cUF.SelectedValue = DR.Item("cUF") & ""
            Me.cPais.SelectedValue = DR.Item("cPais") & ""
            EncheListaMunicipio()
            Me.cMun.SelectedValue = DR.Item("cMun") & ""

            Operation = UPD
        End If
    End Sub

    Private Sub CgcCpf_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles CgcCpf.Enter
        If Me.TipoFornecedor.Text = "" Then
            Me.TipoFornecedor.Focus()
            Exit Sub
        End If


        If Me.TipoFornecedor.Text = "F" Then
            Me.CgcCpf.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Cpf
        End If

        If Me.TipoFornecedor.Text = "J" Then
            Me.CgcCpf.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Cnpj
        End If

        If Me.TipoFornecedor.Text = "G" Then
            Me.CgcCpf.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Cnpj
            Me.CgcCpf.Text = "00.000.000/0000-00"
        End If

    End Sub

    Public Sub UltimoReg()
        'Inserir ultimo registro

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer
        With Cmd
            .Connection = CNN
            .CommandTimeout = 0
            .CommandText = "Select max(CódigoFornecedor) from Fornecedor"
            .CommandType = CommandType.Text
        End With
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

        Me.CódigoFornecedor.Text = Ult + 1
        Me.CódigoFornecedor.Refresh()
        Me.TipoFornecedor.Focus()
        'fim inserir ultimo registro

    End Sub

    Private Sub ExcluirBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirBT.Click
        MsgBox("Esta opção não esta disponivel nesta versão do sistema.", 64, "Validação de Dados")
        Exit Sub
    End Sub

    Public Sub AchaCPFCNPJ()

        Me.cUF.SelectedIndex = -1

        Dim Sql As String = "Select * from Fornecedor where CgcCpf = '" & Me.CgcCpf.Text & "' and Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            MsgBox("Existe um Fornecedor com este CPF/CNPJ o sistema ira preencher os dados.", 64, "Validação de Dados")
            Me.CódigoFornecedor.Text = DR.Item("CódigoFornecedor") & ""
            Me.TipoFornecedor.Text = DR.Item("TipoFornecedor") & ""
            Me.CgcCpf.Text = DR.Item("CgcCpf") & ""
            Me.IncriçãoEstadual.Text = DR.Item("IncriçãoEstadual") & ""
            Me.RazãoSocial.Text = DR.Item("RazãoSocial") & ""
            Me.NomeFantasia.Text = DR.Item("NomeFantasia") & ""
            Me.Endereço.Text = DR.Item("Endereço") & ""
            Me.Cidade.Text = DR.Item("Cidade") & ""
            Me.Estado.Text = DR.Item("Estado") & ""
            Me.Cep.Text = DR.Item("Cep") & ""
            Me.Telefone1.Text = DR.Item("Telefone1") & ""
            Me.Telefone2.Text = DR.Item("Telefone2") & ""
            Me.Fone0800.Text = DR.Item("Fone0800") & ""
            Me.Fax.Text = DR.Item("Fax") & ""
            Me.Contato.Text = DR.Item("Contato") & ""
            Me.Email.Text = DR.Item("Email") & ""
            Me.CartaoNatal.Checked = DR.Item("CartaoNatal")

            Me.Bairro.Text = DR.Item("Bairro") & ""
            Me.Observação.Text = DR.Item("Observação") & ""

            Me.EndCorrespondencia.Text = DR.Item("EndCorrespondencia") & ""
            Me.CidCorrespondencia.Text = DR.Item("CidCorrespondencia") & ""
            Me.UFCorrespondencia.Text = DR.Item("UFCorrespondencia") & ""
            Me.BairroCorrespondencia.Text = DR.Item("BairroCorrespondencia") & ""
            Me.CepCorrespondencia.Text = DR.Item("CepCorrespondencia") & ""

            Me.Banco.Text = DR.Item("Banco") & ""
            Me.ContaCorrente.Text = DR.Item("ContaCorrente") & ""
            Me.AgenciaBancaria.Text = DR.Item("AgenciaBancaria") & ""

            Me.cUF.SelectedValue = DR.Item("cUF") & ""

            Operation = UPD
        Else
            Operation = INS
        End If
    End Sub

    Private Sub TeclasAtalho(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.F7 Then
            LocalizarBT_Click(sender, e)
        End If

        If e.KeyCode = Keys.F8 Then
            ExcluirBT_Click(sender, e)
        End If

        If e.KeyCode = Keys.F9 Then
            NovoBT_Click(sender, e)
        End If

        If e.KeyCode = Keys.F10 Then
            SalvarBT_Click(sender, e)
        End If

        If e.KeyCode = Keys.F11 Then
            EditarBT_Click(sender, e)
        End If

        If e.KeyCode = Keys.F12 Then
            FecharBT_Click(sender, e)
        End If

    End Sub

    Private Sub InativarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InativarBT.Click
        If Exc = False Then
            MsgBox("O usuário não tem permissão para esta operação. Verifique.", 64, "Validação de Dados")
            Exit Sub
        End If

        Dim HH As DateTime = Now
        'Dim CodSegurança As String = InputBox("Favor informar o Código de Segurança.", "Validação de Dados", 0)

        Dim Autorizado As Boolean = PedirPermissao(Me.Text, Me.CódigoFornecedor.Text)
        Autorizado = varAutorizado
        If Autorizado = False Then
            Exit Sub

            'If VerificaCodigoSegurança(CodSegurança) = False Then
            '    MsgBox("Código de Segurança inválido, Verifique.", 64, "Validação de Dados")
            '    Exit Sub
        Else
            Me.Inativo.Checked = True
            SalvarBT_Click(sender, e)
        End If

    End Sub

    Private Sub Degrade()
        Try

            Dim Key As RegistryKey = Registry.LocalMachine
            Dim PegaKeyPadrão As RegistryKey = Key.OpenSubKey("Software\\UPTema\\Tema")

            Cor1TelaPrimaria = PegaKeyPadrão.GetValue("Cor1TelaPrimaria", " ")
            Cor2TelaPrimaria = PegaKeyPadrão.GetValue("Cor2TelaPrimaria", " ")

            Cor1TelaSecundaria = PegaKeyPadrão.GetValue("Cor1TelaSecundaria", " ")
            Cor2TelaSecundaria = PegaKeyPadrão.GetValue("Cor2TelaSecundaria", " ")


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

    Private Sub IncriçãoEstadual_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncriçãoEstadual.Enter
        If Me.TipoFornecedor.Text = "F" Then
            Me.IncriçãoEstadual.Text = "ISENTO"
        End If
    End Sub

    Private Sub NomeFantasia_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NomeFantasia.Enter
        If Me.NomeFantasia.Text = "" Then
            Me.NomeFantasia.Text = Me.RazãoSocial.Text
        End If
    End Sub

    

    Private Sub cMun_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cMun.Enter
        If Me.cUF.Text = "" Then
            MessageBox.Show("O usuário deve informar a Uf do endereço, favor verificar...", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.cMun.Focus()
            Exit Sub
        End If

        If String.CompareOrdinal(cMun.Text, cMun.OldValue) Then
            Me.cMun.Text = ""
            EncheListaMunicipio()
        Else
            'EncheListaMunicipio()
        End If


    End Sub

    Private Sub cUF_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cUF.Validated
        If String.CompareOrdinal(cUF.OldValue, cUF.Text) = 1 Then
            cMun.Text = ""
            EncheListaMunicipio()
        Else
            cMun.Text = ""
            EncheListaMunicipio()
        End If

    End Sub

    Private Sub btForCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btForCli.Click
        If Me.CgcCpf.Text = "" Then
            MessageBox.Show("Para transformar um Fornecedor em Cliente é necessario Cpf/Cnpj.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.TipoFornecedor.Text = "F" Then
            If Len(Me.CgcCpf.Text) <> 14 Then
                MessageBox.Show("Quantidade de caracteres invalido.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            If Len(Me.CgcCpf.Text) <> 18 Then
                MessageBox.Show("Quantidade de caracteres invalido.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If


        Dim CNNCli As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNNCli.Open()


        Dim Sql As String = "Select * from Clientes where CpfCgc = '" & Me.CgcCpf.Text & "'"
        Dim CMD As New OleDb.OleDbCommand(Sql, CNNCli)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            MessageBox.Show("Este Fornecedor já esta cadastrado como Cliente.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        DR.Close()



        Sql = "INSERT INTO Clientes (TipoPessoa, CpfCgc, Insc, Nome, NomeFantasia, Endereço, Cidade, Bairro, Cep, cUF, Telefone, PessoaContato, Email, Observação, DataCadastro, Empresa, Nro, xCpl, cMun, Pais, Estado) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21)"
        Dim cmdCli As New OleDb.OleDbCommand(Sql, CNNCli)

        cmdCli.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.TipoFornecedor.Text, 1)))
        cmdCli.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.CgcCpf.Text, 1)))
        cmdCli.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.IncriçãoEstadual.Text, 1)))
        cmdCli.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.RazãoSocial.Text, 1)))
        cmdCli.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.NomeFantasia.Text, 1)))
        cmdCli.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Endereço.Text, 1)))
        cmdCli.Parameters.Add(New OleDb.OleDbParameter("@7", Me.cMun.Text))
        cmdCli.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Bairro.Text, 1)))
        cmdCli.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Cep.Text, 1)))
        cmdCli.Parameters.Add(New OleDb.OleDbParameter("@10", Me.cUF.SelectedValue))
        cmdCli.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Telefone1.Text, 1)))
        cmdCli.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.Contato.Text, 1)))
        cmdCli.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.Email.Text, 1)))
        cmdCli.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.Observação.Text, 1)))
        cmdCli.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(CStr(DataDia), 1)))
        cmdCli.Parameters.Add(New OleDb.OleDbParameter("@16", CodEmpresa))
        cmdCli.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.Nro.Text, 1)))
        cmdCli.Parameters.Add(New OleDb.OleDbParameter("@18", Nz(Me.xCpl.Text, 1)))
        cmdCli.Parameters.Add(New OleDb.OleDbParameter("@19", Me.cMun.SelectedValue))
        cmdCli.Parameters.Add(New OleDb.OleDbParameter("@20", Me.cPais.Text))
        cmdCli.Parameters.Add(New OleDb.OleDbParameter("@21", Me.cUF.SelectedValue))

        Try
            cmdCli.ExecuteNonQuery()
            MsgBox("Fornecedor transformado em Cliente com sucesso", 64, "Validação de Dados")
            GerarLog(Me.Text, AçãoTP.Adicionou, Me.CgcCpf.Text)
            CNNCli.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try



    End Sub
End Class