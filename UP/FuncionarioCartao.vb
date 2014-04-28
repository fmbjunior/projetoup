Public Class FuncionarioCartao

    Dim Ação As New TrfGerais

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click
        'Area destinada para as validacoes
        If Me.idCartao.Text = "" Then
            MsgBox("O código do cartão não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.idCartao.Focus()
            Exit Sub
        ElseIf Me.Funcionario.Text = "" Then
            MsgBox("O Funcionário Responsavel pelo Cartão não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Funcionario.Focus()
            Exit Sub
        ElseIf Me.DataCadastro.Text = "" Then
            MsgBox("A Data de Cadastro do Cartão não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.DataCadastro.Focus()
            Exit Sub
        ElseIf Me.DataExpiracao.Text = "" Then
            MsgBox("A data de Expiração do Cartão não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.DataExpiracao.Focus()
            Exit Sub
        End If

        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        If Operation = INS Then

            Dim Sql As String = "INSERT INTO FuncionarioCartao (idCartao, Funcionario, DataCadastro, DataExpiracao, UsadoParaVenda, PermissaoMaster, Inativo, InativoPorque, Empresa, Login) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.idCartao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Me.Funcionario.SelectedValue))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataCadastro.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataExpiracao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Me.UsadoParaVenda.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.PermissaoMaster.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Me.Inativo.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.InativoPorque.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.Login.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Adicionou, Me.idCartao.Text)
                Ação.Desbloquear_Controle(Me, False)
                CNN.Close()
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            Ação.Desbloquear_Controle(Me, False)
            CNN.Close()

        ElseIf Operation = UPD Then
          
            Dim Sql As String = "Update FuncionarioCartao set idCartao = @1, Funcionario = @2, DataCadastro = @3, DataExpiracao = @4, UsadoParaVenda = @5, PermissaoMaster = @6, Inativo = @7, InativoPorque = @8, Empresa = @9, Login = @10 Where idCartao = '" & Me.idCartao.Text & "'"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.idCartao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Me.Funcionario.SelectedValue))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataCadastro.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataExpiracao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Me.UsadoParaVenda.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.PermissaoMaster.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Me.Inativo.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.InativoPorque.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.Login.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Editou, Me.idCartao.Text)
                Ação.Desbloquear_Controle(Me, False)
                CNN.Close()
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
           
        End If

    End Sub

    Private Sub AcharCartao()

        If Me.idCartao.Text = "" Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT FuncionarioCartao.*, Funcionários.Nome FROM Funcionários INNER JOIN FuncionarioCartao ON Funcionários.CódigoFuncionário = FuncionarioCartao.Funcionario WHERE FuncionarioCartao.idCartao = '" & Me.idCartao.Text & "'"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then

            Me.idCartao.Text = DR.Item("idCartao") & ""
            Me.Funcionario.SelectedValue = DR.Item("Funcionario")
            Me.DataCadastro.Text = DR.Item("DataCadastro") & ""
            Me.DataExpiracao.Text = DR.Item("DataExpiracao") & ""
            Me.UsadoParaVenda.Checked = DR.Item("UsadoParaVenda") & ""
            Me.PermissaoMaster.Checked = DR.Item("PermissaoMaster") & ""
            Me.Inativo.Checked = DR.Item("Inativo") & ""
            Me.InativoPorque.Text = DR.Item("InativoPorque") & ""

            Me.idCartao.Enabled = False
            Me.Funcionario.Enabled = False
            Me.DataCadastro.Enabled = False
            Me.DataExpiracao.Enabled = False
            Me.UsadoParaVenda.Enabled = False
            Me.PermissaoMaster.Enabled = False
            Me.Inativo.Enabled = False
            Me.InativoPorque.Enabled = False

            Operation = UPD
        Else
            Operation = INS
        End If
    End Sub

    Private Sub idCartao_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles idCartao.Validating
        AcharCartao()
    End Sub

    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub FuncionarioCartao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EncheListaFuncionario()

        Me.idCartao.Enabled = False
        Me.Funcionario.Enabled = False
        Me.DataCadastro.Enabled = False
        Me.DataExpiracao.Enabled = False
        Me.UsadoParaVenda.Enabled = False
        Me.PermissaoMaster.Enabled = False
        Me.Inativo.Enabled = False
        Me.InativoPorque.Enabled = False
        Me.Login.Enabled = False
    End Sub

    Private Sub NovoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click
        Me.idCartao.Enabled = True
        Me.Funcionario.Enabled = True
        Me.DataCadastro.Enabled = True
        Me.DataExpiracao.Enabled = True
        Me.UsadoParaVenda.Enabled = True
        Me.PermissaoMaster.Enabled = True
        Me.Inativo.Enabled = True
        Me.InativoPorque.Enabled = True
        Me.Login.Enabled = True

        Me.idCartao.Clear()
        Me.Funcionario.SelectedIndex = -1
        Me.DataCadastro.Clear()
        Me.DataExpiracao.Clear()
        Me.UsadoParaVenda.Checked = False
        Me.PermissaoMaster.Checked = False
        Me.Inativo.Checked = False
        Me.InativoPorque.Clear()
        Me.Login.Clear()



        Dim rnd As New Random
        Dim VNumero As String = rnd.Next(100, 1000)

        Dim VarLetras As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        Dim Letra As String = VarLetras.Substring(rnd.Next(1, Len(VarLetras)), 1)

        Letra = Letra & VNumero
        Me.idCartao.Text = Letra
        AcharCartao()

        Operation = INS
        Me.idCartao.Focus()
    End Sub

    Private Sub EditarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBT.Click
        Me.idCartao.Enabled = True
        Me.Funcionario.Enabled = True
        Me.DataCadastro.Enabled = True
        Me.DataExpiracao.Enabled = True
        Me.UsadoParaVenda.Enabled = True
        Me.PermissaoMaster.Enabled = True
        Me.Login.Enabled = True

        If Me.Inativo.Checked = True Then
            Me.Inativo.Enabled = False
            Me.InativoPorque.Enabled = False
        Else
            Me.Inativo.Enabled = True
            Me.InativoPorque.Enabled = True
        End If
        Me.Funcionario.Focus()
    End Sub

    Private Sub EncheListaFuncionario()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "Select Funcionários.CódigoFuncionário, Funcionários.Nome From Funcionários  Where Funcionários.Empresa = " & CodEmpresa & " And Funcionários.inativo = False Order by Funcionários.Nome"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Funcionario.DataSource = ds.Tables("Table").DefaultView
        Me.Funcionario.DisplayMember = "Nome"
        Me.Funcionario.ValueMember = "CódigoFuncionário"
        Me.Funcionario.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub btLocalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLocalizar.Click
        My.Forms.FuncionarioCartaoProcura.ShowDialog()
        AcharCartao()
    End Sub

    Private Sub btImpress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImpress.Click

        'Dim Crpt As New ClCrypto

        Dim Rel As New RelNumeroCartaoCrypto
        Rel.NumeroCartao.Text = Criptografa(Me.idCartao.Text)
        Rel.CodBarra.Text = Criptografa(Me.idCartao.Text)

        My.Forms.ViewReport.VerRelat.Document = Rel.Document
        My.Forms.ViewReport.VerRelat.Document.Name = "RelNumeroCartaoCrypto"
        Rel.Run()

        My.Forms.ViewReport.ShowDialog()
    End Sub

    Private Sub btNFeFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class