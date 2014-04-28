Public Class EmpresaComissaoFaixa
    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    
    

    Private Sub FolhaPgtoTributos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Empresa.Text = My.Forms.Empresa.CódigoEmpresa.Text
        LocalizaDados()
    End Sub

    

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        'Area destinada para as validacoes
        If Me.Empresa.Text = "" Then
            MsgBox("A Empresa não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Empresa.Focus()
            Exit Sub
        End If

        If Me.pFaixa1.Text = "" Then Me.pFaixa1.Text = FormatNumber(0, 2)
        If Me.pFaixa2.Text = "" Then Me.pFaixa2.Text = FormatNumber(0, 2)
        If Me.pFaixa3.Text = "" Then Me.pFaixa3.Text = FormatNumber(0, 2)
        If Me.pFaixa4.Text = "" Then Me.pFaixa4.Text = FormatNumber(0, 2)
        If Me.pFaixa5.Text = "" Then Me.pFaixa5.Text = FormatNumber(0, 2)
        If Me.pFaixa6.Text = "" Then Me.pFaixa6.Text = FormatNumber(0, 2)

        If Me.cFaixa1.Text = "" Then Me.cFaixa1.Text = FormatNumber(0, 2)
        If Me.cFaixa2.Text = "" Then Me.cFaixa2.Text = FormatNumber(0, 2)
        If Me.cFaixa3.Text = "" Then Me.cFaixa3.Text = FormatNumber(0, 2)
        If Me.cFaixa4.Text = "" Then Me.cFaixa4.Text = FormatNumber(0, 2)
        If Me.cFaixa5.Text = "" Then Me.cFaixa5.Text = FormatNumber(0, 2)
        If Me.cFaixa6.Text = "" Then Me.cFaixa6.Text = FormatNumber(0, 2)

        If Me.cFat.Text = "" Then Me.cFat.Text = FormatNumber(0, 2)

        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            Dim Sql As String = "INSERT INTO EmpresaComissaoFaixa (Empresa, cFat, pFaixa1, cFaixa1, pFaixa2, cFaixa2, pFaixa3, cFaixa3, pFaixa4, cFaixa4, pFaixa5, cFaixa5, pFaixa6, cFaixa6) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Empresa.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.cFat.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.pFaixa1.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.cFaixa1.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.pFaixa2.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.cFaixa2.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.pFaixa3.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.cFaixa3.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.pFaixa4.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.cFaixa4.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.pFaixa5.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.cFaixa5.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.pFaixa6.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.cFaixa6.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Adicionou, Me.Empresa.Text)
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            CNN.Close()

        ElseIf Operation = UPD Then
            CNN.Open()

            Dim Sql As String = "Update EmpresaComissaoFaixa set Empresa = @1, cFat = @2, pFaixa1 = @3, cFaixa1 = @4, pFaixa2 = @5, cFaixa2 = @6, pFaixa3 = @7, cFaixa3 = @8, pFaixa4 = @9, cFaixa4 = @10, pFaixa5 = @11, cFaixa5 = @12, pFaixa6 = @13, cFaixa6 = @14 Where Empresa = " & Me.Empresa.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Empresa.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.cFat.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.pFaixa1.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.cFaixa1.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.pFaixa2.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.cFaixa2.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.pFaixa3.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.cFaixa3.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.pFaixa4.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.cFaixa4.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.pFaixa5.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.cFaixa5.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.pFaixa6.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.cFaixa6.Text, 1)))


            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Editou, Me.Empresa.Text)
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            CNN.Close()
        End If

    End Sub


    Public Sub LocalizaDados()
        
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from EmpresaComissaoFaixa where Empresa = " & Me.Empresa.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows = True Then

            Me.cFat.Text = FormatNumber(DR.Item("cFat"), 2)
            Me.pFaixa1.Text = FormatNumber(DR.Item("pFaixa1"), 2)
            Me.cFaixa1.Text = FormatNumber(DR.Item("cFaixa1"), 2)
            Me.pFaixa2.Text = FormatNumber(DR.Item("pFaixa2"), 2)
            Me.cFaixa2.Text = FormatNumber(DR.Item("cFaixa2"), 2)
            Me.pFaixa3.Text = FormatNumber(DR.Item("pFaixa3"), 2)
            Me.cFaixa3.Text = FormatNumber(DR.Item("cFaixa3"), 2)
            Me.pFaixa4.Text = FormatNumber(DR.Item("pFaixa4"), 2)
            Me.cFaixa4.Text = FormatNumber(DR.Item("cFaixa4"), 2)
            Me.pFaixa5.Text = FormatNumber(DR.Item("pFaixa5"), 2)
            Me.cFaixa5.Text = FormatNumber(DR.Item("cFaixa5"), 2)
            Me.pFaixa6.Text = FormatNumber(DR.Item("pFaixa6"), 2)
            Me.cFaixa6.Text = FormatNumber(DR.Item("cFaixa6"), 2)
            Operation = UPD
        Else
            Operation = INS
        End If
        DR.Close()
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub
   
End Class