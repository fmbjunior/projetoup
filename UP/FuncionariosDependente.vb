Public Class FuncionariosDependente

    Dim A��o As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2


    Private Sub FuncionariosDependente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        TeclasAtalho(sender, e)
    End Sub

    Private Sub FuncionariosDependente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()

        A��o.Desbloquear_Controle(Me, False)

        If My.Forms.Funcionarios.CadDependenteAdd = False Then
            EditaDependente()
        End If
    End Sub

    Private Sub EditaDependente()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Dependentes where Id = " & My.Forms.Funcionarios.IdSelecionado.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        Me.Id.Text = DR.Item("id") & ""
        Me.Dependente.Text = DR.Item("Dependente") & ""
        Me.DataNascimento.Text = DR.Item("DataNascimento") & ""
        Me.Parentesco.Text = DR.Item("Parentesco") & ""

        Operation = UPD
        DR.Close()

    End Sub

    Private Sub TeclasAtalho(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub EditarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBT.Click
        If Me.Id.Text = "" Then
            MsgBox("N�o existe Dependente para ser editado.", 64, "Valida��o de Dados")
            Exit Sub
        End If
        Operation = UPD
        A��o.Desbloquear_Controle(Me, True)
        Me.Id.Focus()
    End Sub

    Private Sub NovoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click
        A��o.LimpaTextBox(Me)
        A��o.Desbloquear_Controle(Me, True)
        Me.Id.Text = "0000"
        Me.Dependente.Focus()
        Operation = INS
    End Sub

    Private Sub ExcluirBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirBT.Click
        If MsgBox("Deseja realmente excluir o dependente selecionado.", 36, "Valida��o de Dados") = 6 Then
            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "Delete * from Dependentes where Id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.ExecuteNonQuery()
            MsgBox("Dependente excluido com sucesso.", 64, "Valida��o de Dados")
        End If
    End Sub

    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click
        'Area destinada para as validacoes
        If Me.Dependente.Text = "" Then
            MsgBox("O Nome do Dependente n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Dependente.Focus()
            Exit Sub
        ElseIf Me.Parentesco.Text = "" Then
            MsgBox("O Grau de Parentesco do Dependente n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Parentesco.Focus()
            Exit Sub
        ElseIf Me.DataNascimento.Text = "" Then
            MsgBox("A data de Nascimento n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.DataNascimento.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            UltimoReg()
            Dim Sql As String = "INSERT INTO Dependentes (Id, Funcionario, Dependente, Parentesco, DataNascimento) VALUES (@1, @2, @3, @4, @5)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Id.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(My.Forms.Funcionarios.C�digoFuncion�rio.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Dependente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Parentesco.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.DataNascimento.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                My.Forms.Funcionarios.CarregaDependentes()
                MsgBox("Registro adicionado com sucesso", 64, "Valida��o de Dados")
                GerarLog(Me.Text, A��oTP.Adicionou, My.Forms.Funcionarios.C�digoFuncion�rio.Text)
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Valida��o de Dados")
            End Try
            A��o.Desbloquear_Controle(Me, False)
            CNN.Close()

        ElseIf Operation = UPD Then
            CNN.Open()

            Dim Sql As String = "Update Dependentes set Dependente = @2, Parentesco = @3, DataNascimento = @4 Where Id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Dependente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Parentesco.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataNascimento.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                My.Forms.Funcionarios.CarregaDependentes()
                MsgBox("Registro Atualizado com sucesso", 64, "Valida��o de Dados")
                GerarLog(Me.Text, A��oTP.Editou, My.Forms.Funcionarios.C�digoFuncion�rio.Text)
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            A��o.Desbloquear_Controle(Me, False)
            CNN.Close()
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
            .CommandText = "Select max(Id) from Dependentes"
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

        Me.Id.Text = Ult + 1
        Me.Dependente.Focus()
        'fim inserir ultimo registro

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

End Class