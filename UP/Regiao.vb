Public Class Regiao

    Dim A��o As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2



    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        A��o.Desbloquear_Controle(Me, False)
        Me.TxtProcura.Enabled = True
    End Sub

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        A��o.LimpaTextBox(Me)
        A��o.Desbloquear_Controle(Me, True)
        Me.TxtProcura.Enabled = True
        Me.IdRegiao.Text = "0000"
        Me.IdRegiao.Enabled = False
        Me.RegiaoDesc.Focus()
        Operation = INS
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        'Area destinada para as validacoes
        If Me.RegiaoDesc.Text = "" Then
            MsgBox("A descri��o da Regi�o n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.RegiaoDesc.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        If Operation = INS Then

            UltimoReg()

            Dim Sql As String = "INSERT INTO Regiao (IdRegiao, RegiaoDesc) VALUES (@1, @2)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.IdRegiao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.RegiaoDesc.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Valida��o de Dados")
                GerarLog(Me.Text, A��oTP.Confirmou, Me.IdRegiao.Text)
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Valida��o de Dados")
            End Try
            A��o.Desbloquear_Controle(Me, False)
            Me.TxtProcura.Enabled = True
            CNN.Close()
            Buscar(3)

        ElseIf Operation = UPD Then


            Dim Sql As String = "Update Regiao set RegiaoDesc = @1 Where IdRegiao = " & Me.IdRegiao.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)


            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.RegiaoDesc.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Valida��o de Dados")
                GerarLog(Me.Text, A��oTP.Editou, Me.IdRegiao.Text)
            Catch x As Exception
                'MsgBox(x.Message)
                'Exit Sub
            End Try
            A��o.Desbloquear_Controle(Me, False)
            Me.TxtProcura.Enabled = True
            CNN.Close()
            Buscar(3)
        End If
    End Sub

    Private Sub btEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEditar.Click
        If Me.IdRegiao.Text = "" Then
            MsgBox("No existe Regi�o para ser editado.", 64, "Valida��o de Dados")
            GerarLog(Me.Text, A��oTP.Erro, Me.IdRegiao.Text)
            Exit Sub
        End If
        Operation = UPD
        A��o.Desbloquear_Controle(Me, True)
        Me.TxtProcura.Enabled = True
        Me.IdRegiao.Focus()
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
        Cnn.Open()

        Dim Sql As String = String.Empty

        Select Case Opt
            Case 1
                Sql = "Select Regiao.IdRegiao, Regiao.RegiaoDesc From Regiao Where IdRegiao = " & Me.TxtProcura.Text & " Order by Regiao.RegiaoDesc"
            Case 2
                Sql = "Select Regiao.IdRegiao, Regiao.RegiaoDesc From Regiao Where Regiao.RegiaoDesc like '%" & Me.TxtProcura.Text & "%' Order by Regiao.RegiaoDesc"
            Case 3
                Sql = "Select Regiao.IdRegiao, Regiao.RegiaoDesc From Regiao Order by Regiao.RegiaoDesc"
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

        Me.IdRegiao.Text = Me.Lista.CurrentRow.Cells(0).Value
        Me.RegiaoDesc.Text = Me.Lista.CurrentRow.Cells(1).Value
        Me.IdRegiao.Enabled = False
        Me.RegiaoDesc.Enabled = False
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


    Private Sub btCidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCidade.Click
        If Me.IdRegiao.Text = "" Then
            MessageBox.Show("O usu�rio deve informar uma regi�o antes da Cidade.", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        My.Forms.RegiaoCidade.ShowDialog()
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
            .CommandText = "Select max(IdRegiao) from Regiao"
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

        Me.IdRegiao.Text = Ult + 1

        'fim inserir ultimo registro

    End Sub


End Class