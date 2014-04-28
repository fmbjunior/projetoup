Public Class AdministradorPW
    Dim svalue As String
    Private Sub TextBoxFocusNet1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pw.TextChanged



    End Sub

    Private Sub pw_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles pw.Validating



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ok.Click
        svalue = "estouaqui"
        If Me.pw.Text <> svalue Then
            MessageBox.Show("Senha incorreta", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            AchaTable()

            Me.Close()
            Me.Dispose()

            'My.Forms.DefinirAnoCompetencia.Dispose()


        End If
    End Sub
    Public Sub AchaTable()


        Dim Con As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)

        Con.Open()


        Dim dbSchema As DataTable = Con.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, My.Forms.DefinirAnoCompetencia.AnoComp.Text, "TABLE"})

        Con.Close()

        If dbSchema.Rows.Count > 0 Then
            ' ... Se a table existir 
            Exit Sub
        Else
            Try
                ' ... se a Table não exists
                MsgBox("Tabela para o Ano de Competência não existe, o sistema irá cria-la", 48, "ATENÇÃO")

                ' eg create a table
                Dim sSql As String

                sSql = "CREATE TABLE " & AnoContabel & "(Id COUNTER, DataLancamento DATETIME, PlanoContas TEXT(20), ContraPartida TEXT(20),Documento TEXT(15),DataDocumento DATETIME, ValorDebito CURRENCY, ValorCredito CURRENCY, Historico MEMO, Empresa INTEGER, IdLancamento TEXT(15),IdProcura TEXT(22), IdOrigem INTEGER, NotaFiscal DOUBLE, Constraint PrimaryKey PRIMARY KEY(ID))"

                Dim cmd As New OleDb.OleDbCommand(sSql, Con)

                Con.Open()


                cmd.ExecuteNonQuery()

                sSql = "CREATE INDEX DataLancamento ON " & AnoContabel & " (DataLancamento)"

                cmd.CommandText = sSql
                cmd.ExecuteNonQuery()
            Catch exc As Exception
                MessageBox.Show("Ocorreu um erro! Não foi possível cria a tabela", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Con.Close()

            End Try
            Con.Close()
        End If
    End Sub

End Class