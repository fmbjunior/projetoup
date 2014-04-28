Public Class Cor

    Dim A��o As New TrfGerais()

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
        A��o.LimpaTextBox(Me)
        A��o.Desbloquear_Controle(Me, True)
        Me.Codigo.Enabled = False
        Me.TxtProcura.Enabled = True
        Me.Codigo.Text = "0000"
        Me.CorDesc.Focus()
        Operation = INS
    End Sub

    Private Sub EditarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBT.Click
        If Me.Codigo.Text = "" Then
            MsgBox("N�o existe C�digo de Cor para ser editado.", 64, "Valida��o de Dados")
            Exit Sub
        End If
        Operation = UPD
        A��o.Desbloquear_Controle(Me, True)
        Me.TxtProcura.Enabled = True
        Me.Codigo.Enabled = False
        Me.CorDesc.Focus()
    End Sub

    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click
        'Area destinada para as validacoes
        If Me.Codigo.Text = "" Then
            MsgBox("O C�digo da Cor n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Codigo.Focus()
            Exit Sub
        ElseIf Me.CorDesc.Text = "" Then
            MsgBox("A  Descri��o da Cor n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.CorDesc.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            UltimoReg()
            Dim Sql As String = "INSERT INTO Cor (Codigo, CorDesc, Empresa) VALUES (@1, @2, @3)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Codigo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.CorDesc.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", CodEmpresa))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Valida��o de Dados")
                GerarLog(Me.Text, A��oTP.Adicionou, Me.Codigo.Text)
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Valida��o de Dados")
            End Try
            A��o.Desbloquear_Controle(Me, False)
            Me.TxtProcura.Enabled = True
            CNN.Close()

        ElseIf Operation = UPD Then
            CNN.Open()

            Dim Sql As String = "Update Cor set CorDesc = @2, Empresa = @3 Where Codigo = " & Me.Codigo.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.CorDesc.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", CodEmpresa))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Valida��o de Dados")
                GerarLog(Me.Text, A��oTP.Editou, Me.Codigo.Text)
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            A��o.Desbloquear_Controle(Me, False)
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
            .CommandText = "Select max(Codigo) from Cor"
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

        Me.Codigo.Text = Ult + 1
        Me.Codigo.Refresh()
        Me.CorDesc.Focus()
        'fim inserir ultimo registro

    End Sub


    Private Sub Cor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        A��o.Desbloquear_Controle(Me, False)
        Me.TxtProcura.Enabled = True
        Me.CorDesc.Focus()
    End Sub


    Private Sub ExcluirBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirBT.Click
        If Me.Codigo.Text = "" Then Exit Sub

        Autorizado = PedirPermissao(Me.Text, Me.Codigo.Text)
        If Autorizado = False Then
            Exit Sub
        End If


        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim SQL As String = "Select * From Produtos Where Cor = " & Me.Codigo.Text
        Dim Cmd As New OleDb.OleDbCommand(SQL, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = Cmd.ExecuteReader
        DR.Read()

        If DR.HasRows = True Then
            MessageBox.Show("Este item n�o pode ser excluido, existe dependencia em Produtos.", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DR.Close()
            Cnn.Close()
            Exit Sub
        Else
            If MsgBox("Deseja realmente excluir este Item ?", 36, "Valida��o de Dados") = 6 Then
                SQL = "Delete * From Cor Where Codigo = " & Me.Codigo.Text
                Dim cmdEXC As New OleDb.OleDbCommand(SQL, Cnn)
                cmdEXC.ExecuteNonQuery()
                MessageBox.Show("Registro excluido com sucesso.", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GerarLog(Me.Text, A��oTP.Excluiu, Me.Codigo.Text)
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
                Sql = "Select Cor.Codigo, Cor.CorDesc From Cor Where Cor.Empresa = " & CodEmpresa & " And Codigo = " & Me.TxtProcura.Text & " Order by Cor.CorDesc"
            Case 2
                Sql = "Select Cor.Codigo, Cor.CorDesc From Cor Where Cor.Empresa = " & CodEmpresa & "  And Cor.CorDesc like '%" & Me.TxtProcura.Text & "%' Order by Cor.CorDesc"
            Case 3
                Sql = "Select Cor.Codigo, Cor.CorDesc From Cor Where Cor.Empresa = " & CodEmpresa & " Order by Cor.CorDesc"
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

        Me.Codigo.Text = CInt(Me.Lista.CurrentRow.Cells(0).Value)
        Me.CorDesc.Text = Me.Lista.CurrentRow.Cells(1).Value
        Me.Codigo.Enabled = False
        Me.CorDesc.Enabled = False
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