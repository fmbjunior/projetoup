Public Class TipoPgto
    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2
    Dim Tp As String
    

    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub NovoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click
        
        Ação.LimpaTextBox(Me)
        DesbloquearTextBox(Me, True)
        Me.codigo.Text = "0000"
        Me.descricao.Focus()
        Operation = INS
    End Sub

    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click
        'Area destinada para as validacoes

        
        If Me.descricao.Text = "" Then
            MsgBox("A descrição da Forma de Pagamento não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.descricao.Focus()
            Exit Sub
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            
            CNN.Open()


            Dim Sql As String = "INSERT INTO TipoPgto (DescricaoTipoPgto, SomenteContrato) VALUES (@Desc,@SomenteContrato)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@Desc", Nz(Me.descricao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@SomenteContrato", Me.SomenteContrato.Checked))
           

            Try
                cmd.ExecuteNonQuery()
                cmd.CommandText = "SELECT @@IDENTITY"
                Me.codigo.Text = cmd.ExecuteScalar.ToString

                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Confirmou, Me.codigo.Text)
                DesbloquearTextBox(Me, False)
                Operation = UPD
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            CNN.Close()

        ElseIf Operation = UPD Then

            CNN.Open()

            Dim Sql As String = "UPDATE TipoPgto SET  DescricaoTipoPgto = @Desc, SomenteContrato = @SomenteContrato Where CodigoTipoPgto = " & Me.codigo.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)


            cmd.Parameters.Add(New OleDb.OleDbParameter("@Desc", Nz(Me.descricao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@SomenteContrato", Me.SomenteContrato.Checked))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Editou, Me.codigo.Text)
                Operation = UPD
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            ' Ação.Desbloquear_Controle(Me, False)
            DesbloquearTextBox(Me, False)
            CNN.Close()
        End If
    End Sub

    Private Sub EditarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBT.Click
        If Me.codigo.Text = "" Then
            MsgBox("Não pode ser editado.", 64, "Validação de Dados")
            GerarLog(Me.Text, AçãoTP.Erro, Me.codigo.Text)
            Exit Sub
        End If
       
        Operation = UPD
        Ação.Desbloquear_Controle(Me, True)
        Me.descricao.Focus()
    End Sub

    Private Sub ExcluirBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirBT.Click

        If MessageBox.Show("Deseja excluir o Item.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            Dim sql As String

            sql = "Delete * from TipoPgto where CodigoTipoPgto=" & Me.codigo.Text
            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()
            Dim cmd As New OleDb.OleDbCommand(sql, CNN)
            Try


                cmd.ExecuteNonQuery()
                Operation = INS
                Ação.Desbloquear_Controle(Me, False)
                Ação.LimpaTextBox(Me)
            Catch ex As Exception
                Throw ex
            Finally
                CNN.Close()
            End Try
        End If

    End Sub

    Private Sub LocalizarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizarBT.Click
        Operation = UPD
        My.Forms.TipoPgtoLocalizar.ShowDialog()
    End Sub

    Private Sub TipoPgto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ação.Desbloquear_Controle(Me, False)
    End Sub
End Class