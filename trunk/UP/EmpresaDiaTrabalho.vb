Public Class EmpresaDiaTrabalho

   
    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub EmpresaDiaTrabalho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LocalizaDadosEmpresa()
    End Sub

    Public Sub LocalizaDadosEmpresa()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Empresa where CódigoEmpresa = " & My.Forms.Empresa.CódigoEmpresa.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then

            Me.Segunda.Checked = DR.Item("Segunda")
            Me.Terca.Checked = DR.Item("Terca")
            Me.Quarta.Checked = DR.Item("Quarta")
            Me.Quinta.Checked = DR.Item("Quinta")
            Me.Sexta.Checked = DR.Item("Sexta")
            Me.Sabado.Checked = DR.Item("Sabado")
            Me.Domingo.Checked = DR.Item("Domingo")
           
        End If

        DR.Close()
        CNN.Close()

    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Update Empresa set  Segunda = @Segunda, Terca = @Terca, Quarta = @Quarta, Quinta = @Quinta, Sexta = @Sexta, Sabado = @Sabado, Domingo = @Domingo Where CódigoEmpresa = " & My.Forms.Empresa.CódigoEmpresa.Text
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@Segunda", Me.Segunda.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@Terca", Me.Terca.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@Quarta", Me.Quarta.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@Quinta", Me.Quinta.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@Sexta", Me.Sexta.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@Sabado", Me.Sabado.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@Domingo", Me.Domingo.Checked))

        Try
            cmd.ExecuteNonQuery()
            CNN.Close()
            MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
            GerarLog(Me.Text, AçãoTP.Editou, My.Forms.Empresa.CódigoEmpresa.Text)
        Catch x As Exception
            MsgBox(x.Message)
            Exit Sub
        End Try
    End Sub
End Class