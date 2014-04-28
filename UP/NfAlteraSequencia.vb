Public Class NfAlteraSequencia
    Dim A��o As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2


    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub NfAlteraSequencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()
        LocalizaDadosEmpresa()
    End Sub

    Public Sub LocalizaDadosEmpresa()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Empresa where C�digoEmpresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.Empresa.Text = DR.Item("C�digoEmpresa") & ""
            Me.EmpresaDesc.Text = DR.Item("Raz�oSocial") & ""
            Me.NumeroNf.Text = DR.Item("UltimaNota") & ""
            Me.Usu�rio.Text = UserAtivo
            Me.DataAltera��o.Text = DataDia
        Else
            MsgBox("Verifique a Empresa. Consulte o Administrador", 64, "Valida��o de Dados")
            Me.Close()
            Me.Dispose()
        End If
        DR.Close()
    End Sub

    Private Sub Salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salvar.Click
        'Area destinada para as validacoes
        If Me.Empresa.Text = "" Then
            MsgBox("O C�digo da Empresa n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Empresa.Focus()
            Exit Sub
        ElseIf Me.NumeroNf.Text = "" Then
            MsgBox("O numero da Nota Fiscal n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.NumeroNf.Focus()
            Exit Sub
        ElseIf Me.NovoNumeroNF.Text = "" Then
            MsgBox("O novo numero da Nota Fiscal n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.NovoNumeroNF.Focus()
            Exit Sub
        ElseIf Me.DataAltera��o.Text = "" Then
            MsgBox("A data da altera��o do numero da Nota Fiscal n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.NumeroNf.Focus()
            Exit Sub
        ElseIf Me.Usu�rio.Text = "" Then
            MsgBox("O Usu�rio que esta alterando o numero Nota Fiscal n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.NumeroNf.Focus()
            Exit Sub
        ElseIf Me.Motivo.Text = "" Then
            MsgBox("O motivo que o usu�rio esta alterando o numero da Nota Fiscal n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Motivo.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            UltimoReg()
            Dim Sql As String = "INSERT INTO Altera��oSequenciaNF (Id, Empresa, NumeroNF, NovoNumeroNF, DataAltera��o, Usuario, Motivo) VALUES (@1, @2, @3, @4, @5, @6, @7)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Id.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.NumeroNf.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.NovoNumeroNF.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.DataAltera��o.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Usu�rio.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Motivo.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                AlteraNF()
                MsgBox("Altera��o de Numero de Nota Fiscal feita com sucesso.", 64, "Valida��o de Dados")
                Me.Close()
                Me.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Valida��o de Dados")
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
            .CommandText = "Select max(Id) from Altera��oSequenciaNF"
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
        'fim inserir ultimo registro

    End Sub


    Public Sub AlteraNF()
        'Salvar o numero da nota na empresa

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Update Empresa set UltimaNota = @1 Where C�digoEmpresa = " & Me.Empresa.Text
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.NovoNumeroNF.Text, 1)))

        Try
            cmd.ExecuteNonQuery()
        Catch x As Exception
            MsgBox(x.Message)
            CNN.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub Degrade()
        Try
            Dim CCor() As String
            Dim corTemp As String

            corTemp = Cor1TelaPrimaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))

            corTemp = Cor2TelaPrimaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))
        Catch ex As Exception
        End Try
    End Sub

End Class