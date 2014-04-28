Public Class ReceberProrrogação

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ReceberProrrogação_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AchaRegistro()
    End Sub

    Public Sub AchaRegistro()

        Dim Cnn As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        Cnn.Open()

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM Receber WHERE Id = " & My.Forms.Receber.IdSelecionado.Text
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Me.Id.Text = My.Forms.Receber.IdSelecionado.Text
                Me.Documento.Text = DR.Item("Documento") & ""
                Me.Vencimento.Text = DR.Item("VencimentoOriginal") & ""
                If Me.Vencimento.Text = "" Then
                    Me.Vencimento.Text = DR.Item("Vencimento") & ""
                End If
                Me.ValorDocumento.Text = FormatCurrency(DR.Item("ValorDocumento"), 2)
                Me.Prorrogada.Checked = DR.Item("Prorrogada")
                Me.DataProrrogação.Text = DR.Item("Vencimento") & ""
                Me.MotivoProrrogação.Text = DR.Item("MotivoProrrogação") & ""
                Me.QuemProrrogou.Text = DR.Item("QuemProrrogou") & ""
            End If

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click

        If Me.Prorrogada.Checked = False Then
            MessageBox.Show("Este documento não foi prorrogado, não é necessário a atualização dos Dados", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Baixar o documento

        Me.QuemProrrogou.Text = UserAtivo

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()
        Dim SqlPagar As String = "Update Receber set Prorrogada = @1, Vencimento = @2, MotivoProrrogação = @3, VencimentoOriginal = @4, QuemProrrogou = @5 Where Id = " & Me.Id.Text
        Dim CmdPagar As New OleDb.OleDbCommand(SqlPagar, CNN)

        CmdPagar.Parameters.Add(New OleDb.OleDbParameter("@1", Me.Prorrogada.Checked))
        CmdPagar.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataProrrogação.Text, 1)))
        CmdPagar.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.MotivoProrrogação.Text, 1)))
        CmdPagar.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Vencimento.Text, 1)))
        CmdPagar.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.QuemProrrogou.Text, 1)))

        Try
            CmdPagar.ExecuteNonQuery()
            CNN.Close()
            MsgBox("Documento Atualizado.", 64, TituloMsgbox)
            Me.Close()
            Me.Dispose()

        Catch ex As Exception
            MsgBox("Erro na atualização do Documento.", 64, TituloMsgbox)
            MsgBox(ex.Message, 64, TituloMsgbox)
            CNN.Close()
        End Try

    End Sub

    Private Sub DataProrrogação_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataProrrogação.Validated
        If Me.DataProrrogação.Text <> "" Then
            Me.QuemProrrogou.Text = UserAtivo
        End If
    End Sub

    Private Sub Prorrogada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prorrogada.CheckedChanged
        If Me.Prorrogada.Checked = True Then
            Me.QuemProrrogou.Text = UserAtivo
            Me.MotivoProrrogação.Focus()
        Else
            Me.QuemProrrogou.Text = ""
        End If
    End Sub
End Class