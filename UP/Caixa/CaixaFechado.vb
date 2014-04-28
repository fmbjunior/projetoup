Public Class CaixaFechado

    Public Sub CaixaEstaFechado()

        Dim Cn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cn.Open()

        Dim CM As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        'Verifica a data de Entrada

        If CaixaAtivo = Nothing Then
            '            CaixaAtivo = "0001"
            If Len(CaixaAtivo) <> 4 Then
                MessageBox.Show("O usuario deve selecionar um caixa antes de Confirmar o Pedido. Verifique", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If MsgBox("Deseja Ativar o caixa agora", 36, "Validação de Dados") = 6 Then
                    TRVDados(UserAtivo, "CaixaAtivarDesativar")
                    If Ina = True Then
                        MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
                        Exit Sub
                    Else
                        My.Forms.CaixaAtivarDesativar.ShowDialog()
                        ' Confirmar_Click(sender, e)
                    End If
                End If
                Exit Sub
            End If
        End If


        With CM
            .Connection = Cn
            .CommandTimeout = 0
            .CommandText = "SELECT * From CaixaDia Where DataCaixaDia = #" & Format(CDate(DataDia), "MM/dd/yyyy") & "# and CaixaCod = '" & CaixaAtivo & "' and Empresa = " & CodEmpresa
            .CommandType = CommandType.Text
        End With

        DR = CM.ExecuteReader

        If DR.HasRows = True Then
            While DR.Read
                If DR.Item("Fechado") = False Then
                    Exit Sub
                    Cn.Close()
                Else
                    MessageBox.Show("O caixa deste dia esta fechado, Lançamento não pode ser realizado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Cn.Close()
                    End
                End If
                Cn.Close()
                Exit Sub
            End While
        Else
            MessageBox.Show("O caixa deste dia esta fechado ou não existe, Lançamento não pode ser realizado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cn.Close()
            End
        End If
        DR.Close()
        Cn.Close()

    End Sub
End Class
