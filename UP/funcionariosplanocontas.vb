Public Class FuncionariosPlanoContas

    Private Sub FuncionariosPlanoContas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim CodPlanoContaFuncionario As String = ""

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Empresa where C�digoEmpresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            CodPlanoContaFuncionario = DR.Item("PlanoContasCadFuncionarios")
        Else
            MsgBox("N�o existe configura��o para empresa ativa, verifique com administrador", 64, TituloMsgbox)
            Me.Close()
            Me.Dispose()
        End If
        DR.Close()

        Dim ContaCabe�aMeio As String = Mid(CodPlanoContaFuncionario, 1, 8)

        Sql = "SELECT Max(PlanoContas.IdContas) AS M�xDeIdContas FROM(PlanoContas) WHERE (((Mid([IdContas],1,8))='" & ContaCabe�aMeio & "') AND ((PlanoContas.Empresa) = " & CodEmpresa & "));"

        Dim CMD1 As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR1 As OleDb.OleDbDataReader

        DR1 = CMD1.ExecuteReader
        DR1.Read()
        If DR1.HasRows Then
            Me.ContaCabe�a.Text = CodPlanoContaFuncionario
            Me.Analitica.Text = ContaCabe�aMeio & Format(CInt(Mid(DR1.Item("M�xDeIdContas"), 9, 6)) + 1, "000000")
        End If
        DR1.Close()

        Sql = "SELECT Max(PlanoContas.ContaReduzida) AS M�xDeContaReduzida FROM(PlanoContas) WHERE (((Mid([IdContas],1,2))='" & Mid(ContaCabe�aMeio, 1, 2) & "') AND ((PlanoContas.Empresa)= " & CodEmpresa & "));"
        CMD1 = New OleDb.OleDbCommand(Sql, CNN)

        DR1 = CMD1.ExecuteReader
        DR1.Read()
        If DR1.HasRows Then
            Me.Reduzida.Text = CInt(DR1.Item("M�xDeContaReduzida")) + 1
            Me.Desc.Text = My.Forms.Funcionarios.Nome.Text
        End If
        DR1.Close()

    End Sub

    Private Sub Cadastrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cadastrar.Click
        'Area destinada para as validacoes
        If Me.Analitica.Text = "" Then
            MsgBox("A Conta anal�tica n�o foi informado, favor verificar.", 64, TituloMsgbox)
            Me.Analitica.Focus()
            Exit Sub
        ElseIf Me.Reduzida.Text = "" Then
            MsgBox("O Codigo reduzido n�o foi informado, favor verificar.", 64, TituloMsgbox)
            Me.Reduzida.Focus()
            Exit Sub
        ElseIf Me.ContaCabe�a.Text = "" Then
            MsgBox("A Conta cabe�a n�o foi informado, favor verificar.", 64, TituloMsgbox)
            Me.ContaCabe�a.Focus()
            Exit Sub
        ElseIf Me.Desc.Text = "" Then
            MsgBox("A descri��o da Conta n�o foi informado, favor verificar.", 64, TituloMsgbox)
            Me.Desc.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "INSERT INTO PlanoContas (IdContas, Empresa, ContaReduzida, Descri��o) VALUES (@1, @2, @3, @4)"
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Analitica.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", CodEmpresa))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Reduzida.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Desc.Text, 1)))

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, 64, TituloMsgbox)
        End Try
        CNN.Close()

        My.Forms.Funcionarios.CodPlanoContas.Text = Me.Analitica.Text

        Me.Close()
        Me.Dispose()

    End Sub
End Class