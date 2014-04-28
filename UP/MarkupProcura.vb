Public Class MarkupProcura

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub MarkupProcura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MyLista.Items.Clear()


        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        Cnn.Open()

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * From Markup order by DescMarkup"
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader
            Dim Zebrar As Boolean = False

            While DataReader.Read
                If Not IsDBNull(DataReader.Item("DescMarkup")) Then
                    Dim AA As String = DataReader.Item("DescMarkup")
                    Dim item1 As New ListViewItem(AA, 0)

                    MyLista.Items.AddRange(New ListViewItem() {item1})

                    If Zebrar = True Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.MediumOrchid
                        Zebrar = True
                    End If

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

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        RetornoProcura = ""
        Dim I As Integer = 0

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then RetornoProcura = (MyLista.Items(I).Text.Substring(0))
        Next

        If RetornoProcura = "" Then
            MsgBox("O usuário deve informar um iten da lista de procura.", 64, "Validação de Dados")
            Me.MyLista.Focus()
            Exit Sub
        End If
        Me.Close()
        Me.Dispose()
    End Sub
End Class