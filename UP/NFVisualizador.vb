Public Class NFVisualizador

    Private Sub NFVisualizador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Forms.PedidoVenda.PedidoSequencia.Text = "" Then
            Exit Sub
        End If

        Me.MyLista.Items.Clear()


        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        Cnn.Open()

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT NotaFiscal.NotaFiscal, NotaFiscal.Pedido, Clientes.Nome, NotaFiscal.DataEmissao, NotaFiscal.TotalNota, NotaFiscal.Situaçao FROM Clientes INNER JOIN NotaFiscal ON Clientes.Codigo = NotaFiscal.Cliente WHERE NotaFiscal.Pedido = " & My.Forms.PedidoVenda.PedidoSequencia.Text
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader
            Dim Zebrar As Boolean = False
            While DataReader.Read
                If Not IsDBNull(DataReader.Item("NotaFiscal")) Then
                    Dim AA As String = DataReader.Item("NotaFiscal")
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("Nome") & "")
                    item1.SubItems.Add(DataReader.Item("DataEmissao") & "")
                    item1.SubItems.Add(FormatNumber(DataReader.Item("TotalNota"), 2))
                    item1.SubItems.Add(DataReader.Item("Situaçao") & "")
                    MyLista.Items.AddRange(New ListViewItem() {item1})

                    If Zebrar = False Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.PowderBlue
                        Zebrar = True
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    End If
                End If
            End While

            DataReader.Close()
            Cnn.Close()
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try

    End Sub
End Class