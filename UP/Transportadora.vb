Public Class Transportadora
    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ação.Desbloquear_Controle(Me, False)
    End Sub

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)
        Me.Codigo.Enabled = False
        Me.Codigo.Text = "0000"
        Me.TipoPessoa.Focus()
        Operation = INS
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        'Area destinada para as validacoes
        If Me.Codigo.Text = "" Then
            MsgBox("O Código do Transportador não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Codigo.Focus()
            Exit Sub
        ElseIf Me.RazãoTransportadora.Text = "" Then
            MsgBox("Razão Social do transportador não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.RazãoTransportadora.Focus()
            Exit Sub
        ElseIf Me.TipoPessoa.Text = "" Then
            MsgBox("O Tipo do transportador não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.TipoPessoa.Focus()
            Exit Sub
        ElseIf Me.CgcCpf.Text = "" Then
            MsgBox("O Cpf/Cnpj do transportador não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.CgcCpf.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            UltimoReg()

            Dim Sql As String = "INSERT INTO Transportadora (Codigo, TipoPessoa, CgcCpf, Incricao, RazãoTransportadora, Endereço, Cidade, Uf, Cep , Telefone, Contato, Email, Observação, Empresa ) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Codigo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.TipoPessoa.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.CgcCpf.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Incricao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.RazãoTransportadora.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Endereço.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Cidade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Uf.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Cep.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.Telefone.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Contato.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.Email.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.Observação.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", CodEmpresa))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Confirmou, Me.Codigo.Text)
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            Ação.Desbloquear_Controle(Me, False)
            CNN.Close()

        ElseIf Operation = UPD Then
            CNN.Open()

            Dim Sql As String = "Update Transportadora set TipoPessoa = @2, CgcCpf = @3, Incricao = @4, RazãoTransportadora = @5, Endereço = @6, Cidade = @7, Uf = @8, Cep = @9, Telefone = @10, Contato = @11, Email = @12, Observação = @13, Empresa = @14 Where Codigo = " & Me.Codigo.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.TipoPessoa.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.CgcCpf.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Incricao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.RazãoTransportadora.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Endereço.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Cidade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Uf.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Cep.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.Telefone.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Contato.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.Email.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.Observação.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", CodEmpresa))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Editou, Me.Codigo.Text)
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, False)
            CNN.Close()
        End If

    End Sub

    Private Sub btEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEditar.Click
        If Me.Codigo.Text = "" Then
            MsgBox("No existe Transportador para ser editado.", 64, "Validação de Dados")
            GerarLog(Me.Text, AçãoTP.Erro, Me.Codigo.Text)
            Exit Sub
        End If
        Operation = UPD
        Ação.Desbloquear_Controle(Me, True)
        Me.Codigo.Enabled = False
        Me.TipoPessoa.Focus()
    End Sub

    Private Sub btLocalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLocalizar.Click
        Ação.Desbloquear_Controle(Me, False)
        ChamaTelaProcura("Codigo", "Razão Social", "", "Transportadora", "Codigo", "RazãoTransportadora", "", True)
        Me.Codigo.Text = RetornoProcura
        If Me.Codigo.Text <> "" Then
            LocalizaDados()
            Me.Codigo.Enabled = False
            Me.TipoPessoa.Focus()
        End If
    End Sub

    Public Sub LocalizaDados()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Transportadora where Codigo = " & Me.Codigo.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        Me.Codigo.Text = DR.Item("Codigo") & ""
        Me.TipoPessoa.Text = DR.Item("TipoPessoa") & ""
        Me.CgcCpf.Text = DR.Item("CgcCpf") & ""
        Me.Incricao.Text = DR.Item("Incricao") & ""
        Me.RazãoTransportadora.Text = DR.Item("RazãoTransportadora") & ""
        Me.Endereço.Text = DR.Item("Endereço") & ""
        Me.Cidade.Text = DR.Item("Cidade") & ""
        Me.Uf.Text = DR.Item("UF") & ""
        Me.Cep.Text = DR.Item("Cep") & ""
        Me.Telefone.Text = DR.Item("Telefone") & ""
        Me.Contato.Text = DR.Item("Contato") & ""
        Me.Email.Text = DR.Item("Email") & ""
        Me.Observação.Text = DR.Item("Observação") & ""

        Operation = UPD
        DR.Close()
    End Sub

    Private Sub CgcCpf_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles CgcCpf.Enter
        If Me.TipoPessoa.Text = "F" Then
            Me.CgcCpf.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Cpf
        Else
            Me.CgcCpf.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Cnpj
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
            .CommandText = "Select max(Codigo) from Transportadora"
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

        Me.Codigo.Text = Ult + 1
        Me.Codigo.Refresh()
        Me.TipoPessoa.Focus()
        'fim inserir ultimo registro

    End Sub

    
End Class