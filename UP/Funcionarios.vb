Imports System.Data.OleDb
Imports System.IO
Public Class Funcionarios

    Dim CaminhoImagem As String = ""
    Public CadDependenteAdd As Double = False

    Dim A��o As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Dim Autorizado As Boolean

    Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))


    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        Cnn.Close()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Funcionarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cnn.Open()
        A��o.Desbloquear_Controle(Me, False)
        EncheCaixas(Me.Profiss�o, "Profissao", "Descri��o", "Descri��o", "Codigo", False)
        EncheCaixas(Me.Departamento, "Departamentos", "Departamento", "Departamento", "Codigo", False)


        Dim tab As DevComponents.DotNetBar.TabItem = Me.TabItem1
        Me.TabControl2.SelectedTab = tab
    End Sub

    Public Sub EncheCaixas(ByVal ControleRetorno As Control, ByVal Tabela As String, ByVal CampoOrdenar As String, ByVal ItemDisplay As String, ByVal ItemCodigo As String, ByVal AgrupaItemDisplay As Boolean)

        Dim ItemCombo As New ArrayList

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select * from " & Tabela & " where Empresa = " & CodEmpresa & " order by " & CampoOrdenar
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            If DataReader.HasRows = True Then
                With ItemCombo
                    While DataReader.Read
                        If Not IsDBNull(DataReader.Item(0)) Then
                            If AgrupaItemDisplay = True Then
                                .Add(New ItemData(DataReader.Item(ItemCodigo) & "-" & DataReader.Item(ItemDisplay), DataReader.Item(ItemCodigo), DataReader.Item(ItemCodigo)))
                            Else
                                .Add(New ItemData(DataReader.Item(ItemDisplay), DataReader.Item(ItemCodigo), DataReader.Item(ItemCodigo)))
                            End If
                        End If
                    End While
                End With
            End If
            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try

        Try
            With CType(ControleRetorno, ComboBox)
                .DataSource = ItemCombo
                .DisplayMember = "GetDescri��o"
                .ValueMember = "GetidentificadorString"
            End With
            CType(ControleRetorno, ComboBox).SelectedIndex = -1
            'fim inserir ultimo registro
        Catch ex As Exception
        End Try

    End Sub

    Public Sub LocalizaDados()
        If Me.C�digoFuncion�rio.Text = "0000" Then Exit Sub

        Dim Sql As String = "Select * from Funcion�rios where C�digoFuncion�rio = " & Me.C�digoFuncion�rio.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        Me.C�digoFuncion�rio.Text = DR.Item("C�digoFuncion�rio") & ""
        Me.Cpf.Text = DR.Item("Cpf") & ""
        Me.Rg.Text = DR.Item("Rg") & ""
        Me.Nome.Text = DR.Item("Nome") & ""
        Me.Endere�o.Text = DR.Item("Endere�o") & ""
        Me.Bairro.Text = DR.Item("Bairro") & ""
        Me.Cidade.Text = DR.Item("Cidade") & ""
        Me.Cep.Text = DR.Item("Cep") & ""
        Me.Estado.Text = DR.Item("Estado") & ""
        Me.Telefone.Text = DR.Item("Telefone") & ""
        Me.CarteiraTrabalho.Text = DR.Item("CarteiraTrabalho") & ""
        Me.Pis.Text = DR.Item("Pis") & ""

        Dim Depart As String = DR.Item("Departamento") & ""
        Dim Profis As String = DR.Item("Profiss�o") & ""

        Me.DataAdmiss�o.Text = DR.Item("DataAdmiss�o") & ""
        Me.DataRegistro.Text = DR.Item("DataRegistro") & ""
        Me.DataRecisao.Text = DR.Item("DataRecisao") & ""
        Me.MotivoRecisao.Text = DR.Item("MotivoRecisao") & ""

        Me.CartaoBanco.Text = DR.Item("CartaoBanco") & ""
        Me.GeraPagamentoCart�o.Checked = DR.Item("GeraPagamentoCart�o")
        Me.AdicionarEmVendas.Checked = DR.Item("AdicionarEmVendas")

        Me.Salario.Text = FormatNumber(Nz(DR.Item("Salario"), 3), 2)
        Me.SalarioRegistro.Text = FormatNumber(Nz(DR.Item("SalarioRegistro"), 3), 2)
        Me.ValorVale.Text = FormatNumber(Nz(DR.Item("ValorVale"), 3), 2)
        Me.DataNascimento.Text = DR.Item("DataNascimento") & ""

        Me.Cal�adoTamanho.Text = DR.Item("Cal�adoTamanho") & ""
        Me.UniformeTamanho.Text = DR.Item("UniformeTamanho") & ""

        Me.SerieCarteiraTrabalho.Text = DR.Item("SerieCarteiraTrabalho") & ""
        Me.QtdDependentesSalarioFamilia.Text = DR.Item("QtdDependentesSalarioFamilia") & ""
        Me.TipoPagamentoMensal.Text = DR.Item("TipoPagamentoMensal") & ""

        A��o.Descri��o_ItenRegistro(Me.Departamento, Me.Departamento, "Departamentos", "Codigo", Depart, "Departamento", TrfGerais.TipoDados.Num�rico, True)
        A��o.Descri��o_ItenRegistro(Me.Profiss�o, Me.Profiss�o, "Profissao", "Codigo", Profis, "Descri��o", TrfGerais.TipoDados.Num�rico, True)

        Me.Observa��o.Text = DR.Item("Observa��o") & ""
        Me.ValorPis.Text = FormatNumber(Nz(DR.Item("ValorPis"), 3), 2)
        Me.GeraMovimentoFolha.Text = DR.Item("GeraMovimentoFolha") & ""
        Me.ComissaoVenda.Text = FormatNumber(NzZero(DR.Item("ComissaoVenda")), 2)


        If Not IsDBNull(DR.Item("Foto")) Then
            Dim ByteData() As Byte = DR.Item("Foto") 'stream em mem�ria recebe a imagem
            Dim ImgVer As New MemoryStream(ByteData)
            Me.Display.Visible = True
            Me.Display.Image = Image.FromStream(ImgVer)
        Else

            Me.Display.Image = Me.SemFoto.Image
        End If

        Me.Inativo.Checked = DR.Item("Inativo")

        If Me.Inativo.Checked = True Then
            MessageBox.Show("Este funcion�rio esta inativo o usu�rio n�o pode alterar os dados.", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            A��o.Desbloquear_Controle(Me, False)
        End If

        Operation = UPD
        DR.Close()

    End Sub

    Private Sub LocalizarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizarBT.Click
        A��o.Desbloquear_Controle(Me, False)
        My.Forms.FuncionarioProcura.ShowDialog()

        If Me.C�digoFuncion�rio.Text <> "" Then
            LocalizaDados()
            CarregaDependentes()
            Me.C�digoFuncion�rio.Enabled = False
            Me.Cpf.Focus()
        End If
    End Sub

   

    Private Sub EditarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBT.Click
        If Me.C�digoFuncion�rio.Text = "" Then
            MsgBox("No existe �Funcion�rio para ser editado.", 64, "Valida��o de Dados")
            Exit Sub
        End If
        If Me.C�digoFuncion�rio.Text = "0000" Then
            MsgBox("No existe �Funcion�rio para ser editado.", 64, "Valida��o de Dados")
            Exit Sub
        End If
        If Me.Inativo.Checked = True Then Exit Sub

        Operation = UPD
        A��o.Desbloquear_Controle(Me, True)
        Me.C�digoFuncion�rio.Enabled = False
        Me.Cpf.Focus()
    End Sub

    Private Sub NovoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click
        A��o.LimpaTextBox(Me)
        A��o.Desbloquear_Controle(Me, True)
        Me.MyListaDependente.Items.Clear()
        Me.Display.Image = Me.SemFoto.Image
        Me.C�digoFuncion�rio.Enabled = False
        Me.C�digoFuncion�rio.Text = "0000"
        Operation = INS
        Me.Cpf.Focus()
    End Sub

    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click
        'Area destinada para as validacoes
        If Me.C�digoFuncion�rio.Text = "" Then
            MsgBox("O C�digo do funcion�rio n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.C�digoFuncion�rio.Focus()
            Exit Sub
        ElseIf Me.Nome.Text = "" Then
            MsgBox("O Nome do funcion�rio n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Nome.Focus()
            Exit Sub
        ElseIf Me.Cpf.Text = "" Then
            MsgBox("O Cpf do Funcion�rio n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Cpf.Focus()
            Exit Sub
        ElseIf Me.Departamento.Text = "" Then
            MsgBox("O Departamento de trabalho do Funcion�rio n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Departamento.Focus()
            Exit Sub
        ElseIf Me.Profiss�o.Text = "" Then
            MsgBox("A Profiss�o do Funcion�rio n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Profiss�o.Focus()
            Exit Sub
        ElseIf Me.DataAdmiss�o.Text = "" Then
            MsgBox("A data de Admiss�o do Funcion�rio n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Dim tab As DevComponents.DotNetBar.TabItem = Me.TabItem2
            Me.TabControl2.SelectedTab = tab
            Me.DataAdmiss�o.Focus()
            Exit Sub
        ElseIf Me.GeraMovimentoFolha.Text = "" Then
            MsgBox("O usu�rio deve informar se vai gerar movimento na folha ou n�o, favor verificar.", 64, "Valida��o de Dados")
            Dim tab As DevComponents.DotNetBar.TabItem = Me.TabItem1
            Me.TabControl2.SelectedTab = tab
            Me.GeraMovimentoFolha.Focus()
            Exit Sub
        End If

        If Me.TipoPagamentoMensal.Text = "CART�O" Then
            If Me.CartaoBanco.Text = "" Then
                MsgBox("O usu�rio deve informar numero do Cart�o para pagamento mensal.", 64, "Valida��o de Dados")
                Dim tab As DevComponents.DotNetBar.TabItem = Me.TabItem1
                Me.TabControl2.SelectedTab = tab
                Me.TipoPagamentoMensal.Focus()
                Exit Sub
            End If
        End If

        If Me.Salario.Text = "" Then Me.Salario.Text = FormatNumber(0, 2)
        If Me.SalarioRegistro.Text = "" Then Me.SalarioRegistro.Text = FormatNumber(0, 2)
        If Me.ValorVale.Text = "" Then Me.ValorVale.Text = FormatNumber(0, 2)
        If Me.ValorPis.Text = "" Then Me.ValorPis.Text = FormatNumber(0, 2)
        If Me.Cal�adoTamanho.Text = "" Then Me.Cal�adoTamanho.Text = 0
        If Me.QtdDependentesSalarioFamilia.Text = "" Then Me.QtdDependentesSalarioFamilia.Text = 0

        'Fim da Area destinada para as validacoes

        If Operation = INS Then

            UltimoReg()

            Dim Sql As String = "INSERT INTO Funcion�rios (C�digoFuncion�rio, Cpf, Rg, Nome, Endere�o, Bairro, Cidade, Cep, Estado, Telefone, CarteiraTrabalho, Pis, Departamento, Profiss�o, DataAdmiss�o, DataRegistro, DataRecisao, MotivoRecisao, CartaoBanco, GeraPagamentoCart�o, AdicionarEmVendas, Salario, SalarioRegistro, ValorVale, DataNascimento, Empresa, Cal�adoTamanho, UniformeTamanho, QtdDependentesSalarioFamilia, SerieCarteiraTrabalho, TipoPagamentoMensal, Observa��o, ValorPis, GeraMovimentoFolha, ComissaoVenda) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22, @23, @24, @25, @26, @27, @28, @29, @30, @31, @32, @33, @34, @35)"
            Dim cmd As New OleDb.OleDbCommand(Sql, Cnn)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.C�digoFuncion�rio.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Cpf.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Rg.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Nome.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Endere�o.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Bairro.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Cidade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Cep.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Estado.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.Telefone.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.CarteiraTrabalho.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.Pis.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.Departamento.SelectedValue.ToString, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.Profiss�o.SelectedValue.ToString, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.DataAdmiss�o.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.DataRegistro.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.DataRecisao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Nz(Me.MotivoRecisao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@19", Nz(Me.CartaoBanco.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@20", Me.GeraPagamentoCart�o.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@21", Me.AdicionarEmVendas.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@22", Nz(Me.Salario.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@23", Nz(Me.SalarioRegistro.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@24", Nz(Me.ValorVale.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@25", Nz(Me.DataNascimento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@26", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@27", Nz(Me.Cal�adoTamanho.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@28", Nz(Me.UniformeTamanho.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@29", Nz(Me.QtdDependentesSalarioFamilia.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@30", Nz(Me.SerieCarteiraTrabalho.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@31", Nz(Me.TipoPagamentoMensal.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@32", Nz(Me.Observa��o.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@33", Nz(Me.ValorPis.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@34", Nz(Me.GeraMovimentoFolha.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@35", NzZero(Me.ComissaoVenda.Text)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Valida��o de Dados")
                GerarLog(Me.Text, A��oTP.Adicionou, Me.C�digoFuncion�rio.Text)
                Operation = UPD
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Valida��o de Dados")
            End Try
            A��o.Desbloquear_Controle(Me, False)

        ElseIf Operation = UPD Then

            Dim Sql As String = "Update Funcion�rios set Cpf = @1, Rg = @2, Nome = @3, Endere�o = @4, Bairro = @5, Cidade = @6, Cep = @7, Estado = @8, Telefone = @9, CarteiraTrabalho = @10, Pis = @11, Departamento = @12, Profiss�o = @13, DataAdmiss�o = @14, DataRegistro = @15, DataRecisao = @16, MotivoRecisao = @17, CartaoBanco = @18, GeraPagamentoCart�o = @19, AdicionarEmVendas = @20, Salario = @21, SalarioRegistro = @22, ValorVale = @23, DataNascimento = @24, Empresa = @25, Cal�adoTamanho = @26, UniformeTamanho = @27, QtdDependentesSalarioFamilia = @28, SerieCarteiraTrabalho = @29, TipoPagamentoMensal = @30, Observa��o = @31, ValorPis = @32, GeraMovimentoFolha = @33, ComissaoVenda = @34 Where C�digoFuncion�rio = " & Me.C�digoFuncion�rio.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, Cnn)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Cpf.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Rg.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Nome.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Endere�o.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Bairro.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Cidade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Cep.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Estado.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Telefone.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.CarteiraTrabalho.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Pis.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.Departamento.SelectedValue.ToString, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.Profiss�o.SelectedValue.ToString, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.DataAdmiss�o.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.DataRegistro.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.DataRecisao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.MotivoRecisao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Nz(Me.CartaoBanco.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@19", Me.GeraPagamentoCart�o.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@20", Me.AdicionarEmVendas.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@21", Nz(Me.Salario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@22", Nz(Me.SalarioRegistro.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@23", Nz(Me.ValorVale.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@24", Nz(Me.DataNascimento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@25", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@26", Nz(Me.Cal�adoTamanho.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@27", Nz(Me.UniformeTamanho.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@28", Nz(Me.QtdDependentesSalarioFamilia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@29", Nz(Me.SerieCarteiraTrabalho.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@30", Nz(Me.TipoPagamentoMensal.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@31", Nz(Me.Observa��o.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@32", Nz(Me.ValorPis.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@33", Nz(Me.GeraMovimentoFolha.Text, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@34", NzZero(Me.ComissaoVenda.Text)))


            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Valida��o de Dados")
                GerarLog(Me.Text, A��oTP.Editou, Me.C�digoFuncion�rio.Text)
                Operation = UPD
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            A��o.Desbloquear_Controle(Me, False)
        End If

    End Sub

    Private Sub btSalvarFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvarFoto.Click
        If Me.C�digoFuncion�rio.Text = "" Then
            MsgBox("O usu�rio deve selecionar uma Funcion�rio primeiro.", 64, "Valida��o de Dados")
            Exit Sub
        End If

        Dim OpenFileDialog1 As New OpenFileDialog()
        OpenFileDialog1.Filter = "(Jpeg Files) *.jpg | *.jpg"
        OpenFileDialog1.Title = "Selecione um arquivo JPG para inserir no campo Foto"
        OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.FileName <> "" Then
            CaminhoImagem = OpenFileDialog1.FileName
            Me.Display.Image = New Bitmap(CaminhoImagem)


            Dim arqImg As FileStream
            Dim rImg As StreamReader

            If Len(CaminhoImagem) <> 0 Then
                arqImg = New FileStream(CaminhoImagem, FileMode.Open, FileAccess.Read, FileShare.Read)
                rImg = New StreamReader(arqImg)
            Else
                MsgBox("Defina uma foto para inserir no Banco de dados.", 64, "Valida��o de Dados")
                Exit Sub
            End If

            Dim Cmd As New OleDbCommand("Update Funcion�rios set Foto = ? Where C�digoFuncion�rio = " & Me.C�digoFuncion�rio.Text, Cnn)

            Try
                'declaramos um vetor de bytes para armazenar o conte�do da imagem a ser salva 
                Dim arqByteArray(arqImg.Length - 1) As Byte
                arqImg.Read(arqByteArray, 0, arqImg.Length)

                Cmd.Parameters.Add("@Foto", OleDbType.Binary, arqImg.Length).Value = arqByteArray

                'Cmd.Connection.Open()
                Cmd.ExecuteNonQuery()
                'Cmd.Connection.Close()
                Me.Display.Image = New Bitmap(CaminhoImagem)
                MsgBox("Imagem incluida com sucesso !", 64, "Valida��o de Dados")

            Catch Ex As Exception
                MsgBox(Ex.Message, 64, "Valida��o de Dados")
            End Try

            Exit Sub
        End If

    End Sub


    Private Sub HistoricoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoricoBT.Click
        If Me.C�digoFuncion�rio.Text = "" Then
            MsgBox("O usu�rio deve selecionar um funcion�rio antes de adicionar um hist�rico.", 64, "Valida��o de Dados")
            Exit Sub
        End If

        TRVDados(UserAtivo, "FuncionariosHistorico")
        If Ina = True Then
            MsgBox("O usu�rio n�o esta autorizado a usar esta op��o do sistema.", 64, "Valida��o de Dados")
            Exit Sub
        Else
            My.Forms.FuncionariosHistorico.ShowDialog()
        End If

    End Sub

    Private Sub DependentesBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DependentesBT.Click
        If Me.C�digoFuncion�rio.Text = "" Then
            MsgBox("O usu�rio deve selecionar um funcion�rio antes de adicionar um Dependente.", 64, "Valida��o de Dados")
            Exit Sub
        End If
        CadDependenteAdd = True
        My.Forms.FuncionariosDependente.ShowDialog()
        CarregaDependentes()
    End Sub

    Public Sub CarregaDependentes()
        MyListaDependente.Items.Clear()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader


        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * From Dependentes WHERE Funcionario = " & Me.C�digoFuncion�rio.Text & " order by DataNascimento"
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            Dim Zebrar As Boolean = False
            While DR.Read
                If Not IsDBNull(DR.Item("Id")) Then
                    Dim AA As String = DR.Item("Id")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("Funcionario"))
                    It.SubItems.Add(DR.Item("Dependente"))
                    It.SubItems.Add(DR.Item("Parentesco"))
                    It.SubItems.Add(DR.Item("DataNascimento"))

                    MyListaDependente.Items.AddRange(New ListViewItem() {It})

                    If Zebrar = True Then
                        MyListaDependente.Items.Item(MyListaDependente.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    Else
                        MyListaDependente.Items.Item(MyListaDependente.Items.Count() - 1).BackColor = Color.Aquamarine
                        Zebrar = True
                    End If

                End If
            End While

            DR.Close()
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Exit Sub
        End Try

    End Sub

    Private Sub MyListaDependente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyListaDependente.DoubleClick
        Dim I As Integer = 0

        For I = 0 To MyListaDependente.Items.Count - 1
            If MyListaDependente.Items(I).Selected = True Then Me.IdSelecionado.Text = (MyListaDependente.Items(I).Text.Substring(0))
        Next
        CadDependenteAdd = False
        My.Forms.FuncionariosDependente.ShowDialog()
    End Sub

    Private Sub TipoPagamentoMensal_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TipoPagamentoMensal.Enter
        Dim X As New Point(138, 0)
        Me.MenuTpPagamento.Show(Me.TipoPagamentoMensal, X)
    End Sub

    Private Sub TipoPagamentoMensal_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TipoPagamentoMensal.Leave
        If Me.TipoPagamentoMensal.Text = "CART�O" Then
            Me.CartaoBanco.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
            Me.CartaoBanco.Focus()
        Else
            Me.CartaoBanco.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.CartaoBanco.Clear()
        End If
    End Sub

    Private Sub CartaoBanco_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles CartaoBanco.Enter
        If Me.TipoPagamentoMensal.Text = "CART�O" Then
            Me.CartaoBanco.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Else
            Me.CartaoBanco.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.CartaoBanco.Clear()
        End If
    End Sub

    Private Sub CART�OToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CART�OToolStripMenuItem.Click, CHEQUEToolStripMenuItem.Click, DINHEIROToolStripMenuItem.Click
        Me.TipoPagamentoMensal.Text = sender.ToString
    End Sub

    Private Sub CartaoBanco_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CartaoBanco.Leave
        If Me.TipoPagamentoMensal.Text = "CART�O" Then
            If Me.CartaoBanco.Text = "" Then
                MsgBox("O usu�rio deve informar numero do Cart�o para pagamento mensal.", 64, "Valida��o de Dados")
                Me.TipoPagamentoMensal.Focus()
            End If
        End If
    End Sub

    Public Sub UltimoReg()
        'Inserir ultimo registro
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer
        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select max(C�digoFuncion�rio) from Funcion�rios"
            .CommandType = CommandType.Text
        End With
        Try
            Cnn.Open()
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    'Achou o iten procurado o iten as caixas ser�o preenchida
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

        Me.C�digoFuncion�rio.Text = Ult + 1
        'fim inserir ultimo registro

    End Sub


    Private Sub btInativar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btInativar.Click

        If Me.C�digoFuncion�rio.Text = "" Then Exit Sub

        Autorizado = PedirPermissao(Me.Text, Me.C�digoFuncion�rio.Text)
        Autorizado = varAutorizado
        If Autorizado = False Then
            Exit Sub
        End If


        
        Dim Sql As String = "Update Funcion�rios set Inativo = @1 Where C�digoFuncion�rio = " & Me.C�digoFuncion�rio.Text
        Dim cmd As New OleDb.OleDbCommand(Sql, Cnn)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", True))

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Registro Inativado com sucesso", 64, "Valida��o de Dados")
            GerarLog(Me.Text, A��oTP.Inativou, Me.C�digoFuncion�rio.Text)

            A��o.LimpaTextBox(Me)
            A��o.Desbloquear_Controle(Me, True)
            Me.MyListaDependente.Items.Clear()
            Me.Display.Image = Me.SemFoto.Image
            Me.C�digoFuncion�rio.Enabled = False
            Me.C�digoFuncion�rio.Text = "0000"
            Operation = INS
            Me.Cpf.Focus()

        Catch x As Exception
            MsgBox(x.Message)
            Exit Sub
        End Try


    End Sub
End Class