Imports System.Data.OleDb
Public Class BancosContaCorrente
    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Dim DBOpen As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub NovoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click
        If Adi = False Then
            MsgBox("O Usuário não tem permissão para adicionar o registro, verifique com o Administrador.", 64, "Validação de Dados")
            Exit Sub
        End If

        Ação.Desbloquear_Controle(Me, True)
        Ação.LimpaTextBox(Me)
        Me.TxtProcura.Enabled = True
        Me.Codigo.Text = "0000"
        Me.NomeBanco.Focus()
        Operation = INS
    End Sub

    Private Sub EditarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBT.Click
        If Edi = False Then
            MsgBox("O Usuário não tem permissão para Editar registro, verifique com o Administrador.", 64, "Validação de Dados")
            Exit Sub
        End If

        If Me.Codigo.Text = "" Then
            MsgBox("No existe Conta Corrente/Banco para ser editado.", 64, "Validação de Dados")
            Exit Sub
        End If
        Ação.Desbloquear_Controle(Me, True)
        Me.TxtProcura.Enabled = True
        Operation = UPD
        Me.NomeBanco.Focus()
    End Sub

    Private Sub BancosContaCorrente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DBOpen.Open()
        Ação.Desbloquear_Controle(Me, False)
        Me.TxtProcura.Enabled = True
    End Sub

    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click
        'Area destinada para as validacoes
        If Me.Codigo.Text = "" Then
            MsgBox("O código não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Codigo.Focus()
            Exit Sub
        ElseIf Me.NomeBanco.Text = "" Then
            MsgBox("O nome do banco não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.NomeBanco.Focus()
            Exit Sub
        ElseIf Me.ContaCorrente.Text = "" Then
            MsgBox("O numero da Conta corrente não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.ContaCorrente.Focus()
            Exit Sub
        ElseIf Me.Agencia.Text = "" Then
            MsgBox("O numero da agencia não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Agencia.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            If Adi = False Then
                MsgBox("O Usuário não tem permissão para adicionar o registro, verifique com o Administrador.", 64, "Validação de Dados")
                Exit Sub
            End If

            CNN.Open()

            UltimoReg()

            Dim Sql As String = "INSERT INTO Banco (Codigo, NomeBanco, ContaCorrente, Agencia, Telefone, Empresa, AgruparFluxoCaixa) VALUES (@1, @2, @3, @4, @5, @6, @7)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Codigo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.NomeBanco.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.ContaCorrente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Agencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Telefone.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Me.AgruparFluxoCaixa.Checked))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Adicionou, Me.Codigo.Text)
                CNN.Close()
                Operation = UPD
                Ação.Desbloquear_Controle(Me, False)
                Me.TxtProcura.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try

        ElseIf Operation = UPD Then
            If Edi = False Then
                MsgBox("O Usuário não tem permissão para adicionar o registro, verifique com o Administrador.", 64, "Validação de Dados")
                Exit Sub
            End If

            CNN.Open()

            Dim Sql As String = "Update Banco set NomeBanco = @2, ContaCorrente = @3, Agencia = @4, Telefone = @5, Empresa = @6, AgruparFluxoCaixa = @7 Where Codigo = '" & Me.Codigo.Text & "'"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            'cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Codigo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.NomeBanco.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.ContaCorrente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Agencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Telefone.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Me.AgruparFluxoCaixa.Checked))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Editou, Me.Codigo.Text)
                CNN.Close()
                Operation = UPD
                Ação.Desbloquear_Controle(Me, False)
                Me.TxtProcura.Enabled = True
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
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
            .CommandText = "Select max(Codigo) from Banco"
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

        'fim inserir ultimo registro

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
                Sql = "Select Banco.Codigo, Banco.ContaCorrente, Banco.NomeBanco From Banco Where Banco.Empresa = " & CodEmpresa & " And Codigo = '" & Me.TxtProcura.Text & "' Order by Banco.ContaCorrente"
            Case 2
                Sql = "Select Banco.Codigo, Banco.ContaCorrente, Banco.NomeBanco From Banco Where Banco.Empresa = " & CodEmpresa & "  And Banco.ContaCorrente like '%" & Me.TxtProcura.Text & "%' Order by Banco.ContaCorrente"
            Case 3
                Sql = "Select Banco.Codigo, Banco.ContaCorrente, Banco.NomeBanco From Banco Where Banco.Empresa = " & CodEmpresa & " Order by Banco.ContaCorrente"
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
        LocalizaDados()
        Ação.Desbloquear_Controle(Me, False)
        Me.TxtProcura.Enabled = True
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

    Public Sub LocalizaDados()
        If Me.Codigo.Text = "" Then Exit Sub

        Dim Sql As String = "Select * from Banco where Codigo = '" & Me.Codigo.Text & "' and Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, DBOpen)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.Codigo.Text = DR.Item("Codigo") & ""
            Me.NomeBanco.Text = DR.Item("NomeBanco") & ""
            Me.ContaCorrente.Text = DR.Item("ContaCorrente") & ""
            Me.Agencia.Text = DR.Item("Agencia") & ""
            Me.Telefone.Text = DR.Item("Telefone") & ""
            Me.AgruparFluxoCaixa.Checked = DR.Item("AgruparFluxoCaixa")
        End If
        DR.Close()
        Operation = UPD
    End Sub


End Class