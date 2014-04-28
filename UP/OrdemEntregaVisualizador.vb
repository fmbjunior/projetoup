Public Class OrdemEntregaVisualizador

    Private Sub OrdemEmbarqueVisualizador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            .CommandText = "SELECT OrdemEntrega.*, Clientes.Nome, OrdemEntrega.Pedido FROM Clientes INNER JOIN OrdemEntrega ON Clientes.Codigo = OrdemEntrega.Cliente WHERE OrdemEntrega.Pedido = " & My.Forms.PedidoVenda.PedidoSequencia.Text
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            Dim Zebrar As Boolean = False
            Dim Img As Integer = 0
            While DataReader.Read
                If Not IsDBNull(DataReader.Item("Ordem")) Then

                    If DataReader.Item("Cancelada") = True Then
                        Img = 1
                    Else
                        Img = 0
                    End If

                    Dim AA As String = DataReader.Item("Ordem")
                    Dim item1 As New ListViewItem(AA, Img)

                    item1.SubItems.Add(DataReader.Item("Nome") & "")
                    item1.SubItems.Add(DataReader.Item("DataEmissao") & "")
                    item1.SubItems.Add(DataReader.Item("DataSaida") & "")

                    If DataReader.Item("Cancelada") = True Then
                        item1.SubItems.Add("C")
                    Else
                        item1.SubItems.Add("E")
                    End If

                    MyLista.Items.AddRange(New ListViewItem() {item1})

                    If Zebrar = False Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.MediumOrchid
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



    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        Dim I As Integer = 0

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then Me.Ordem.Text = MyLista.Items(I).Text.Substring(0)
        Next

        RelatorioCarregar = "RelOrdemEmbarqueVisualizador"
        My.Forms.VisualizadorRelatorio.ShowDialog()
    End Sub

    


   
End Class