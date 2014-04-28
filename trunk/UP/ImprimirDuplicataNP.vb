Public Class ImprimirDuplicataNP


    Private Sub Visualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Visualizar.Click


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select pedidosequencia,confirmado from pedido where pedidosequencia=" & Me.PedidoSequencia.Text & " And Confirmado=True"

        Dim Cmd As New OleDb.OleDbCommand(Sql, CNN)
        Dim DataReader As OleDb.OleDbDataReader


        Try
            DataReader = Cmd.ExecuteReader
            DataReader.Read()

            If DataReader.HasRows = True Then
                If EmitirDpPedido = True Then
                    If MsgBox("Deseja imprimir a(s) Duplicata(s)/Nota Promissoria(s)", 36, "Validação de Dados") = 6 Then
                        If ModeloDuplicata = "DUPLICATA" Then
                            RelatorioCarregar = "ImpressDP"
                            My.Forms.VisualizadorRelatorio.ShowDialog()
                        End If
                        If ModeloDuplicata = "NOTA PROMISSORIA" Then
                            RelatorioCarregar = "ImpressNP"
                            My.Forms.VisualizadorRelatorio.ShowDialog()
                        End If
                    End If
                End If
            Else
                MessageBox.Show("Pedido não encontrado ou não foi confirmado, Verifique.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try

     


    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class