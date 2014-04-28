Public Class CaixaCadastro
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
        Me.TxtProcura.Enabled = True
        Me.CodigoCaixa.Enabled = False
        Me.CodigoCaixa.Text = "0000"
        Me.CaixaNome.Focus()
        Operation = INS
    End Sub

    Private Sub EditarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBT.Click
        If Me.CodigoCaixa.Text = "" Then
            MsgBox("Não existe Caixa para ser editado.", 64, "Validação de Dados")
            Exit Sub
        End If
        Operation = UPD
        Ação.Desbloquear_Controle(Me, True)
        Me.TxtProcura.Enabled = True
        Me.CodigoCaixa.Enabled = False
        Me.CaixaNome.Focus()
    End Sub

    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click
        'Area destinada para as validacoes
        If Me.CodigoCaixa.Text = "" Then
            MsgBox("O Código do caixa não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.CodigoCaixa.Focus()
            Exit Sub
        ElseIf Me.CaixaNome.Text = "" Then
            MsgBox("A  descrição do caixa não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.CaixaNome.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then

            UltimoReg()

            CNN.Open()

            Dim Sql As String = "INSERT INTO CaixaCadastro (CodigoCaixa, CaixaNome, Responsavel, Senha, Empresa, Inativo, Retaguarda) VALUES (@1, @2, @3, @4, @5, @6, @7)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CodigoCaixa.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.CaixaNome.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Responsavel.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Senha.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", False))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Me.Retaguarda.Checked))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Adicionou, Me.CodigoCaixa.Text)

            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            Ação.Desbloquear_Controle(Me, False)
            CNN.Close()

        ElseIf Operation = UPD Then
            CNN.Open()

            Dim Sql As String = "Update CaixaCadastro set CodigoCaixa = @1, CaixaNome = @2, Responsavel = @3, Senha = @4, Empresa = @5, Inativo = @6, Retaguarda = @7 Where CodigoCaixa = '" & Me.CodigoCaixa.Text & "'"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CodigoCaixa.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.CaixaNome.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Responsavel.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Senha.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", False))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Me.Retaguarda.Checked))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Editou, Me.CodigoCaixa.Text)

            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, False)
            Me.TxtProcura.Enabled = True
            CNN.Close()
        End If

    End Sub

    Public Sub AchaCaixa()
        'Inserir ultimo registro
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "Select * from CaixaCadastro Where CodigoCaixa = '" & Me.CodigoCaixa.Text & "'"

        Dim Cmd As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        Try

            DR = Cmd.ExecuteReader
            DR.Read()

            If DR.HasRows = True Then
                Me.CodigoCaixa.Text = DR.Item("CodigoCaixa")
                Me.CaixaNome.Text = DR.Item("CaixaNome")
                Me.Responsavel.Text = DR.Item("Responsavel")
                Me.Senha.Text = DR.Item("Senha")
                Me.Retaguarda.Checked = DR.Item("Retaguarda")
                Operation = UPD
            Else
                Operation = INS
            End If

            DR.Close()
            Cnn.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try

    End Sub

    Private Sub CaixaCadastro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ação.Desbloquear_Controle(Me, False)
        Me.TxtProcura.Enabled = True
    End Sub


    Private Sub InativarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InativarBT.Click

        Dim CodSegurança As String = InformaCodigoSeguranca()

        If VerificaCodigoSegurança(CodSegurança) = False Then
            MsgBox("Código de Segurança inválido, Verifique.", 64, "Validação de Dados")
            Exit Sub
        Else

            Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            Cnn.Open()

            If MsgBox("Deseja realmente Inativar este Caixa ?", 36, "Validação de Dados") = 6 Then
                Dim SQL As String = "Update CaixaCadastro set Inativo = true Where CodigoCaixa = " & Me.CodigoCaixa.Text
                Dim cmd As New OleDb.OleDbCommand(SQL, Cnn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Registro Inativo com sucesso.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                NovoBT_Click(sender, e)
                Cnn.Close()
                Exit Sub
            End If
        End If

    End Sub

#Region "Rotina de Procura"

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged
        If Me.A1.Checked = True Then
            Me.TxtProcura.Enabled = True
            Me.TxtProcura.Focus()
        End If
        If Me.A2.Checked = True Then
            Me.TxtProcura.Enabled = True
            Me.TxtProcura.Focus()
        End If
        If Me.A3.Checked = True Then
            Buscar(3)
        End If
    End Sub

    Private Sub Buscar(ByVal Opt As Integer)

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Select Case Opt
            Case 1
                Sql = "Select CaixaCadastro.CodigoCaixa, CaixaCadastro.CaixaNome From CaixaCadastro Where CaixaCadastro.Empresa = " & CodEmpresa & " And CodigoCaixa = " & Me.TxtProcura.Text & " Order by CaixaCadastro.Descrição"
            Case 2
                Sql = "Select CaixaCadastro.CodigoCaixa, CaixaCadastro.CaixaNome From CaixaCadastro Where CaixaCadastro.Empresa = " & CodEmpresa & "  And CaixaCadastro.CaixaNome like '%" & Me.TxtProcura.Text & "%' Order by CaixaCadastro.CaixaNome"
            Case 3
                Sql = "Select CaixaCadastro.CodigoCaixa, CaixaCadastro.CaixaNome From CaixaCadastro Where CaixaCadastro.Empresa = " & CodEmpresa & " Order by CaixaCadastro.CaixaNome"
        End Select

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Lista.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        Cnn.Close()
        Me.TxtProcura.Clear()

    End Sub

    Private Sub Lista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellDoubleClick

        Me.CodigoCaixa.Text = Me.Lista.CurrentRow.Cells(0).Value
        AchaCaixa()
        Me.CodigoCaixa.Enabled = False
        Me.CaixaNome.Enabled = False
        Operation = UPD

    End Sub

    Private Sub TxtProcura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtProcura.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.A1.Checked = True Then
                Buscar(1)
            End If
            If Me.A2.Checked = True Then
                Buscar(2)
            End If
        End If
    End Sub

#End Region


    Private Sub CodigoCaixa_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoCaixa.Leave
        If String.CompareOrdinal(Me.CodigoCaixa.Text, Me.CodigoCaixa.TextoAntigo) Then
            AchaCaixa()
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
            .CommandText = "Select max(CodigoCaixa) from CaixaCadastro"
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

        Me.CodigoCaixa.Text = Format(CInt(Ult + 1), "0000")


        'fim inserir ultimo registro

    End Sub

End Class