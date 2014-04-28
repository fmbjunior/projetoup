Imports System.IO
Public Class Empresa

    Dim CaminhoImagem As String = ""

    Dim A��o As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        CNN.Close()
        Me.Close()
        Me.Dispose()
    End Sub

    
    Private Sub NovoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click
        A��o.LimpaTextBox(Me)
        A��o.Desbloquear_Controle(Me, True)
        Me.C�digoEmpresa.Enabled = False
        Me.C�digoEmpresa.Text = "0000"
        Me.Raz�oSocial.Focus()
        Operation = INS
    End Sub

    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click
        'Area destinada para as validacoes
        If Me.C�digoEmpresa.Text = "" Then
            MsgBox("O C�digo da Empresa n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.C�digoEmpresa.Focus()
            Exit Sub
        ElseIf Me.Raz�oSocial.Text = "" Then
            MsgBox("A Raz�o Social da empresa n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Raz�oSocial.Focus()
            Exit Sub
        ElseIf Me.NomeFantasia.Text = "" Then
            MsgBox("O Nome Fantasia da Empresa n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.NomeFantasia.Focus()
            Exit Sub
        ElseIf Me.In�ri��oEstadual.Text = "" Then
            MsgBox("A Inscri��o estadual da empresa n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.In�ri��oEstadual.Focus()
            Exit Sub
        ElseIf Me.Cgc.Text = "" Then
            MsgBox("O Cnpj da Empresa n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Cgc.Focus()
            Exit Sub
        ElseIf Me.Estado.Text = "" Then
            MsgBox("A UF da Empresa n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Estado.Focus()
            Exit Sub
        End If


        'Fim da Area destinada para as validacoes

        If Operation = INS Then

            UltimoReg()

            Dim Sql As String = "INSERT INTO Empresa (C�digoEmpresa, Cgc, In�ri��oEstadual, Raz�oSocial, NomeFantasia, Endere�o, Cidade, Estado, Telefone, Mensagem, EsquemaTS, Cep) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.C�digoEmpresa.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Cgc.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.In�ri��oEstadual.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Raz�oSocial.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.NomeFantasia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Endere�o.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Cidade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Estado.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Telefone.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.Mensagem.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Me.EsquemaTS.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.CEP.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Valida��o de Dados")
                GerarLog(Me.Text, A��oTP.Adicionou, Me.C�digoEmpresa.Text)
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Valida��o de Dados")
            End Try
            A��o.Desbloquear_Controle(Me, False)

        ElseIf Operation = UPD Then

            Dim Sql As String = "Update Empresa set Cgc = @2, In�ri��oEstadual = @3, Raz�oSocial = @4, NomeFantasia = @5, Endere�o = @6, Cidade = @7, Estado = @8, Telefone = @9, Mensagem = @10, EsquemaTS = @11, Cep = @12 Where C�digoEmpresa = " & Me.C�digoEmpresa.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Cgc.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.In�ri��oEstadual.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Raz�oSocial.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.NomeFantasia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Endere�o.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Cidade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Estado.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Telefone.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.Mensagem.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Me.EsquemaTS.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.CEP.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Valida��o de Dados")
                GerarLog(Me.Text, A��oTP.Editou, Me.C�digoEmpresa.Text)
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            A��o.Desbloquear_Controle(Me, False)

        End If

    End Sub

    Private Sub EditarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBT.Click
        If Me.C�digoEmpresa.Text = "" Then
            MsgBox("No existe Empresa para ser editado.", 64, "Valida��o de Dados")
            Exit Sub
        End If
        Operation = UPD
        A��o.Desbloquear_Controle(Me, True)
        Me.C�digoEmpresa.Enabled = False
        Me.Raz�oSocial.Focus()
    End Sub

    Private Sub LocalizarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizarBT.Click
        A��o.Desbloquear_Controle(Me, False)
        ChamaTelaProcura("Codigo", "Raz�o Social", "", "Empresa", "C�digoEmpresa", "Raz�oSocial", "", False)
        Me.C�digoEmpresa.Text = RetornoProcura
        If Me.C�digoEmpresa.Text <> "" Then
            LocalizaDados()
            Me.C�digoEmpresa.Enabled = False
            Me.Raz�oSocial.Focus()
        End If
    End Sub

    Public Sub LocalizaDados()

        Dim Sql As String = "Select * from Empresa where C�digoEmpresa = " & Me.C�digoEmpresa.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.C�digoEmpresa.Text = DR.Item("C�digoEmpresa") & ""
            Me.Cgc.Text = DR.Item("Cgc") & ""
            Me.In�ri��oEstadual.Text = DR.Item("In�ri��oEstadual") & ""
            Me.Raz�oSocial.Text = DR.Item("Raz�oSocial") & ""
            Me.NomeFantasia.Text = DR.Item("NomeFantasia") & ""
            Me.Endere�o.Text = DR.Item("Endere�o") & ""
            Me.Cidade.Text = DR.Item("Cidade") & ""
            Me.Estado.Text = DR.Item("Estado") & ""
            Me.Telefone.Text = DR.Item("Telefone") & ""
            Me.Mensagem.Text = DR.Item("Mensagem") & ""
            Me.EsquemaTS.Checked = DR.Item("EsquemaTS") & ""
            Me.CEP.Text = DR.Item("Cep") & ""

        End If

        Operation = UPD
        DR.Close()
        VisualizaFoto()
    End Sub

    Public Sub UltimoReg()
        'Inserir ultimo registro
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer
        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select max(C�digoEmpresa) from Empresa"
            .CommandType = CommandType.Text
        End With
        Try
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
                Exit Sub
            End If
        End Try
        Cnn.Close()

        Me.C�digoEmpresa.Text = Ult + 1
        Me.C�digoEmpresa.Refresh()
        Me.Raz�oSocial.Focus()
        'fim inserir ultimo registro

    End Sub

    Private Sub CapSalvaImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapSalvaImg.Click
        Dim OpenFileDialog1 As New OpenFileDialog()
        OpenFileDialog1.Filter = "(Jpeg Files) *.jpg | *.jpg"
        OpenFileDialog1.Title = "Selecione um arquivo JPG para inserir no campo Foto"
        OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.FileName <> "" Then
            CaminhoImagem = OpenFileDialog1.FileName
            SalvaFoto()
            VisualizaFoto()
            'MsgBox("A imagem foi capturada, utilize o bot�o salvar para armazenar no banco de dados", 64, "Valida��o de Dados")
            Exit Sub
        End If

    End Sub

    Public Sub SalvaFoto()
        If Me.C�digoEmpresa.Text = "" Then
            MsgBox("N�o pode selecionar uma foto sem uma empresa pr�-Salva.", 64, "Valida��o de Dados")
            Exit Sub
        End If

        Dim arqImg As FileStream
        Dim rImg As StreamReader

        If Len(CaminhoImagem) <> 0 Then
            arqImg = New FileStream(CaminhoImagem, FileMode.Open, FileAccess.Read, FileShare.Read)
            rImg = New StreamReader(arqImg)
        Else
            MsgBox("Defina uma foto para inserir no Banco de dados.", 64, "Valida��o de Dados")
            Exit Sub
        End If

        Dim Cmd As New OleDb.OleDbCommand("Update Empresa Set Foto = ? where C�digoEmpresa = " & Me.C�digoEmpresa.Text, CNN)

        Try
            'declaramos um vetor de bytes para armazenar o conte�do da imagem a ser salva 
            Dim arqByteArray(arqImg.Length - 1) As Byte
            arqImg.Read(arqByteArray, 0, arqImg.Length)

            Cmd.Parameters.Add("@Foto", OleDb.OleDbType.Binary, arqImg.Length).Value = arqByteArray

            'Cmd.Connection.Open()
            Cmd.ExecuteNonQuery()

            MsgBox("Imagem incluida com sucesso !", 64, "Valida��o de Dados")

        Catch Ex As Exception
            MsgBox(Ex.Message, 64, "Valida��o de Dados")
        End Try

    End Sub


    Public Sub VisualizaFoto()
        
        Try
            'command para pegar os dados 
            Dim Cmd As New OleDb.OleDbCommand("SELECT * From Empresa where C�digoEmpresa = " & Me.C�digoEmpresa.Text, CNN)
            'dataadapter para fazer a liga��o dos dados
            Dim Da As New OleDb.OleDbDataAdapter(Cmd)
            'dataset para guardar em mem�ria os dados
            Dim Ds As New DataSet()
            'preenche dataset com a tabela "ProdutosFotos"
            Da.Fill(Ds, "Empresa")
            'variavel para recebe a quantidade de linhas da tabela retornada
            Dim c As Integer = Ds.Tables(0).Rows.Count
            If c > 0 Then
                'array recebe a �ltima linha do dataset, a imagem
                Dim ByteData() As Byte = Ds.Tables(0).Rows(c - 1).Item("Foto")
                'stream em mem�ria recebe a imagem
                Dim ImgVer As New MemoryStream(ByteData)
                'a picturebox recebe imagem que usa o m�todo FromStream para "ler" a stream que cont�m a imagem

                'Compara tamanhos para fazer ajustes no quadro de visualiza��o
                Me.Display.Visible = True
                Me.Display.Image = Image.FromStream(ImgVer)
            End If
        Catch err As Exception
            Me.Display.Visible = False
        Finally
            'fecha a conex�o
        End Try

    End Sub

    Private Sub Empresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        A��o.Desbloquear_Controle(Me, False)
        CNN.Open()
    End Sub

    Private Sub ConfBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfBT.Click
        If Me.C�digoEmpresa.Text = "" Then
            MessageBox.Show("N�o existe empresa para definir as configura��es.", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        My.Forms.EmpresaConfiguracao.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If Me.C�digoEmpresa.Text = "" Then
            MessageBox.Show("N�o existe empresa para definir as configura��es.", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        My.Forms.EmpresaDiaTrabalho.ShowDialog()
    End Sub
End Class