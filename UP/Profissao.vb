Public Class Profissao
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
        Me.Codigo.Enabled = False
        Me.Codigo.Text = "0000"
        Me.Descrição.Focus()
        Operation = INS
    End Sub


    Private Sub EditarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBT.Click
        If Me.Codigo.Text = "" Then
            MsgBox("Não existe Profissão para ser editado.", 64, "Validação de Dados")
            Exit Sub
        End If
        Operation = UPD
        Ação.Desbloquear_Controle(Me, True)
        Me.Codigo.Enabled = False
        Me.Descrição.Focus()
    End Sub


    Public Sub UltimoReg()
        'Inserir ultimo registro
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer = 0
        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select max(Codigo) from Profissao"
            .CommandType = CommandType.Text
        End With
        Try
            Cnn.Open()
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    Ult = NzZero(DataReader.Item(0))
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

        If Ult = 0 Then
            Me.Codigo.Text = 1
        Else
            Me.Codigo.Text = Ult + 1
        End If
        Me.Codigo.Refresh()
        Me.Descrição.Focus()
        'fim inserir ultimo registro

    End Sub

    Private Sub Profissao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ação.Desbloquear_Controle(Me, False)
    End Sub

    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click
        'Area destinada para as validacoes
        If Me.Codigo.Text = "" Then
            MsgBox("O Código da Profissão não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Codigo.Focus()
            Exit Sub
        ElseIf Me.Descrição.Text = "" Then
            MsgBox("A  Descrição da Profissão não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Descrição.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            UltimoReg()
            Dim Sql As String = "INSERT INTO Profissao (Codigo, Descrição, Empresa) VALUES (@1, @2, @3)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Codigo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Descrição.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", CodEmpresa))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Confirmou, Me.Codigo.Text)
                Operation = UPD
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            Ação.Desbloquear_Controle(Me, False)
            CNN.Close()

        ElseIf Operation = UPD Then
            CNN.Open()

            Dim Sql As String = "Update Profissao set Descrição = @2, Empresa = @3 Where Codigo = " & Me.Codigo.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Descrição.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", CodEmpresa))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Editou, Me.Codigo.Text)
                Operation = UPD
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, False)
            CNN.Close()
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
                Sql = "Select Profissao.Codigo, Profissao.Descrição From Profissao Where Profissao.Empresa = " & CodEmpresa & " And Codigo = " & Me.TxtProcura.Text & " Order by Profissao.Descrição"
            Case 2
                Sql = "Select Profissao.Codigo, Profissao.Descrição From Profissao Where Profissao.Empresa = " & CodEmpresa & "  And Profissao.Descrição like '%" & Me.TxtProcura.Text & "%' Order by Profissao.Descrição"
            Case 3
                Sql = "Select Profissao.Codigo, Profissao.Descrição From Profissao Where Profissao.Empresa = " & CodEmpresa & " Order by Profissao.Descrição"
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

        Me.Codigo.Text = Me.Lista.CurrentRow.Cells(0).Value
        Me.Descrição.Text = Me.Lista.CurrentRow.Cells(1).Value
        Me.Codigo.Enabled = False
        Me.Descrição.Enabled = False
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

    Private Sub Codigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Codigo.TextChanged

    End Sub
End Class