Public Class FormaPgto

    Dim A��o As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Private Sub EditarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBT.Click
        If Me.CodFormaPgto.Text = "" Then
            MsgBox("N�o existe Forma de Pagamento para ser editado.", 64, "Valida��o de Dados")
            Exit Sub
        End If
        Operation = UPD
        A��o.Desbloquear_Controle(Me, True)
        Me.TxtProcura.Enabled = True
        Me.CodFormaPgto.Enabled = False
        Me.TemEntrada.Enabled = True
        Me.Descri��o.Focus()
    End Sub

    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click
        'Area destinada para as validacoes
        If Me.CodFormaPgto.Text = "" Then
            MsgBox("O C�digo da Forma de Pagamento n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.CodFormaPgto.Focus()
            Exit Sub
        ElseIf Me.Descri��o.Text = "" Then
            MsgBox("A descri��o da Forma de Pagamento n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Descri��o.Focus()
            Exit Sub
        ElseIf Me.DiasParcelamento.Text = "" Then
            MsgBox("Os dias de Parcelamento da Forma de Pagamento n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.DiasParcelamento.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim VarParcelamento As Integer = CInt(Mid(Me.DiasParcelamento.Text, 1, 3))
        If CInt(VarParcelamento) = 0 Then
            MessageBox.Show("O parcelamento Inicial n�o pode ser [000] dias, Verifique...", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DiasParcelamento.Clear()
            Me.DiasParcelamento.Focus()
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            UltimoReg()
            Dim Sql As String = "INSERT INTO FormaPgto (CodFormaPgto, Descri��o, DiasParcelamento, TemEntrada) VALUES (@1, @2, @3, @4)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CodFormaPgto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Descri��o.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Me.DiasParcelamento.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Me.TemEntrada.Checked))


            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Valida��o de Dados")
                GerarLog(Me.Text, A��oTP.Adicionou, Me.CodFormaPgto.Text)
                CNN.Close()
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Valida��o de Dados")
            End Try
            A��o.Desbloquear_Controle(Me, False)
            Me.TxtProcura.Enabled = True

        ElseIf Operation = UPD Then
            CNN.Open()

            Dim Sql As String = "Update FormaPgto set Descri��o = @2, DiasParcelamento = @3, TemEntrada = @4 Where CodFormaPgto = " & Me.CodFormaPgto.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Descri��o.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Me.DiasParcelamento.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Me.TemEntrada.Checked))
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Valida��o de Dados")
                GerarLog(Me.Text, A��oTP.Editou, Me.CodFormaPgto.Text)
                CNN.Close()
            Catch x As Exception
                'MsgBox(x.Message)
                'Exit Sub
            End Try
            A��o.Desbloquear_Controle(Me, False)
            Me.TxtProcura.Enabled = True
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
            .CommandText = "Select max(CodFormaPgto) from FormaPgto"
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

        Me.CodFormaPgto.Text = Ult + 1
        Me.CodFormaPgto.Refresh()
        Me.Descri��o.Focus()
        'fim inserir ultimo registro

    End Sub

    Private Sub FormaPgto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        A��o.Desbloquear_Controle(Me, False)
        Me.TxtProcura.Enabled = True
    End Sub

    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub NovoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click
        A��o.LimpaTextBox(Me)
        A��o.Desbloquear_Controle(Me, True)
        Me.TxtProcura.Enabled = True
        Me.CodFormaPgto.Enabled = False
        Me.CodFormaPgto.Text = "0000"
        Me.TemEntrada.Enabled = True
        Me.Descri��o.Focus()
        Operation = INS
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
                Sql = "Select FormaPgto.CodFormaPgto, FormaPgto.Descri��o, FormaPgto.DiasParcelamento, FormaPgto.TemEntrada From FormaPgto Where CodFormaPgto = " & Me.TxtProcura.Text & " Order by FormaPgto.Descri��o"
            Case 2
                Sql = "Select FormaPgto.CodFormaPgto, FormaPgto.Descri��o, FormaPgto.DiasParcelamento, FormaPgto.TemEntrada From FormaPgto Where FormaPgto.Descri��o like '%" & Me.TxtProcura.Text & "%' Order by FormaPgto.Descri��o"
            Case 3
                Sql = "Select FormaPgto.CodFormaPgto, FormaPgto.Descri��o, FormaPgto.DiasParcelamento, FormaPgto.TemEntrada From FormaPgto Order by FormaPgto.Descri��o"
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

        Me.CodFormaPgto.Text = Me.Lista.CurrentRow.Cells(0).Value
        Me.Descri��o.Text = Me.Lista.CurrentRow.Cells(1).Value
        Me.DiasParcelamento.Text = Me.Lista.CurrentRow.Cells(2).Value
        Me.TemEntrada.Checked = Me.Lista.CurrentRow.Cells(3).Value
        Me.CodFormaPgto.Enabled = False
        Me.Descri��o.Enabled = False
        Me.TemEntrada.Enabled = False
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