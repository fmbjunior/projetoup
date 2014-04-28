Public Class CompraProcuraClassContabil
    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub EncherLista()

        MyLista.Items.Clear()

        Dim Cnn As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        Cnn.Open()

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM ClassificadorContabil WHERE Cfop = '" & My.Forms.GerenciarOrdem.CFOP.Text & "'"
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item("Classificador")) Then
                    Dim AA As String = DataReader.Item("Classificador")
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("DescClassificador") & "")
                    Me.MyLista.Items.AddRange(New ListViewItem() {item1})
                End If
            End While

            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()
    End Sub

    Private Sub ProcuraPropriedades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EncherLista()
    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick

        Dim I As Integer
        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then My.Forms.GerenciarOrdem.ClassContabilProduto.Text = MyLista.Items(I).Text.Substring(0)
        Next

        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub MyLista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyLista.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim I As Integer
            For I = 0 To MyLista.Items.Count - 1
                If MyLista.Items(I).Selected = True Then My.Forms.GerenciarOrdem.ClassContabilProduto.Text = MyLista.Items(I).Text.Substring(0)
            Next

            Me.Close()
            Me.Dispose()
        End If
    End Sub
End Class