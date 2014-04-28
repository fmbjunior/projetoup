Public Class GrupoServico

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Dim Autorizado As Boolean

    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub NovoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click
        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)
        Me.TxtProcura.Enabled = True
        Me.CódigoGrupoServico.Enabled = False
        Me.CódigoGrupoServico.Text = "0000"
        Me.Descricao.Focus()
        Operation = INS
    End Sub

    Private Sub EditarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBT.Click
        If Me.CódigoGrupoServico.Text = "" Then
            MsgBox("Não existe Grupo para ser editado.", 64, "Validação de Dados")
            Exit Sub
        End If
        Operation = UPD
        Ação.Desbloquear_Controle(Me, True)
        Me.TxtProcura.Enabled = True
        Me.CódigoGrupoServico.Enabled = False
        Me.Descricao.Focus()
    End Sub

    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click
        'Area destinada para as validacoes
        If Me.CódigoGrupoServico.Text = "" Then
            MsgBox("O Código do Grupo não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.CódigoGrupoServico.Focus()
            Exit Sub
        ElseIf Me.Descricao.Text = "" Then
            MsgBox("A  descrição do Grupo não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Descricao.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            UltimoReg()
            Dim Sql As String = "INSERT INTO GrupoServico (gID, gDescricao) VALUES (@1, @2)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CódigoGrupoServico.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Descricao.Text, 1)))


            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Adicionou, Me.CódigoGrupoServico.Text)
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            Ação.Desbloquear_Controle(Me, False)
            CNN.Close()

        ElseIf Operation = UPD Then
            CNN.Open()

            Dim Sql As String = "Update GrupoServico set gDescricao = @2 Where gID = " & Me.CódigoGrupoServico.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Descricao.Text, 1)))


            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Editou, Me.CódigoGrupoServico.Text)
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, False)
            Me.TxtProcura.Enabled = True
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
            .CommandText = "Select max(gID) from GrupoServico"
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

        Me.CódigoGrupoServico.Text = Ult + 1
        Me.CódigoGrupoServico.Refresh()
        Me.Descricao.Focus()
        'fim inserir ultimo registro

    End Sub

    Private Sub GrupoServico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ação.Desbloquear_Controle(Me, False)
        Me.TxtProcura.Enabled = True
    End Sub


    Private Sub ExcluirBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirBT.Click

        If Me.CódigoGrupoServico.Text = "" Then Exit Sub

        'Autorizado = PedirPermissao(Me.Text, Me.CódigoGrupoServico.Text)
        'If Autorizado = False Then
        '    Exit Sub
        'End If

        Dim Autorizado As Boolean = PedirPermissao(Me.Text, Me.CódigoGrupoServico.Text)
        Autorizado = varAutorizado
        If Autorizado = False Then
            Exit Sub
        End If

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim SQL As String = "Select * From Servicos Where gruposervico = " & Me.CódigoGrupoServico.Text
        Dim Cmd As New OleDb.OleDbCommand(SQL, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = Cmd.ExecuteReader
        DR.Read()

        If DR.HasRows = True Then
            MessageBox.Show("Este Grupo não pode ser excluido, existe dependência em Serviços.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DR.Close()
            Cnn.Close()
            Exit Sub
        Else
            If MsgBox("Deseja realmente excluir este grupo ?", 36, "Validação de Dados") = 6 Then
                SQL = "Delete * From GrupoServico Where gid = " & Me.CódigoGrupoServico.Text
                Dim cmdEXC As New OleDb.OleDbCommand(SQL, Cnn)
                cmdEXC.ExecuteNonQuery()
                MessageBox.Show("Registro excluido com sucesso.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GerarLog(Me.Text, AçãoTP.Excluiu, Me.CódigoGrupoServico.Text)
                Buscar(4)
                NovoBT_Click(sender, e)
                Cnn.Close()
                Exit Sub
            End If
        End If
        DR.Close()

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
                Sql = "Select gID, gDescricao From GrupoServico Where gID = " & Me.TxtProcura.Text & " Order by gDescricao"
            Case 2
                Sql = "Select gID, gDescricao From GrupoServico Where gDescricao like '%" & Me.TxtProcura.Text & "%' Order by gDescricao"
            Case 3
                Sql = "Select gID, gDescricao From GrupoServico Order by gDescricao"
            Case 4
                Sql = "Select gID, gDescricao From GrupoServico Where gID =-1"
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

        Me.CódigoGrupoServico.Text = CInt(Me.Lista.CurrentRow.Cells(0).Value)
        Me.Descricao.Text = Me.Lista.CurrentRow.Cells(1).Value
        Me.CódigoGrupoServico.Enabled = False
        Me.Descricao.Enabled = False
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


   
End Class