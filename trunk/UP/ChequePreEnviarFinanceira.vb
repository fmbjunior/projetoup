Public Class ChequePreEnviarFinanceira

    Private Sub ChequePreEnviarFinanceira_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM ArquivoCheque WHERE Cheque = '" & My.Forms.ChequePreClientes.NCheque.Text & "' and CC = '" & My.Forms.ChequePreClientes.CC.Text & "' And Empresa = " & CodEmpresa
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            DR.Read()

            If DR.HasRows = True Then

                Me.Cheque.Text = DR.Item("Cheque") & ""
                Me.CC.Text = DR.Item("CC") & ""
                Me.Titular.Text = DR.Item("Titular") & ""
                Me.EntreguePor.Text = DR.Item("EntreguePor") & ""
                Me.ValorCh.Text = FormatCurrency(Nz(DR.Item("ValorCh"), 3), 2)
                Me.Vencimento.Text = DR.Item("Vencimento") & ""
                Me.Pedido.Text = DR.Item("Pedido") & ""

            End If


        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click

        If String.IsNullOrEmpty(Me.txtDataEnvio.Text) Then
            MsgBox("A data de envio não pode ser nula", 48, "Validação de dados")
            Return

        ElseIf String.IsNullOrEmpty(Me.txtFinanceira.Text) Then
            MsgBox("A descrição da financeira não pode ser nula", 48, "Validação de dados")
            Return
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Try
            CNN.Open()
            Dim cmd As New OleDb.OleDbCommand("Update ArquivoCheque set DataEnvioFinanceira ='" & Me.txtDataEnvio.Text & "', Financeira ='" & Me.txtFinanceira.Text & "' Where Cheque = '" & Me.Cheque.Text & "' and CC = '" & Me.CC.Text & "'", CNN)
            cmd.ExecuteNonQuery()
            CNN.Close()
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class