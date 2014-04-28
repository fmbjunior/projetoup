Public Class PedidoVendaFindVendedores

    Private Sub PedidoVendaFindVendedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EncheLista()
    End Sub

    Public Sub EncheLista()

        MyLista.Items.Clear()

        Dim DBOpen As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        DBOpen.Open()
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader


        With Cmd
            .Connection = DBOpen
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM Funcion�rios WHERE DataRecisao Is Null and AdicionarEmVendas = true and inativo=false"
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            Dim Zebrar As Boolean = False
            While DR.Read
                If Not IsDBNull(DR.Item("C�digoFuncion�rio")) Then
                    Dim AA As String = DR.Item("C�digoFuncion�rio")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("Nome"))
                    MyLista.Items.AddRange(New ListViewItem() {It})

                    If Zebrar = True Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.MediumOrchid
                        Zebrar = True
                    End If

                End If
            End While

            DR.Close()
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Exit Sub
        End Try

    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        Dim I As Integer = 0
        Dim str As String = String.Empty

        Dim Ret As String = String.Empty

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then
                Ret = (MyLista.Items(I).Text.Substring(0))
                str = MyLista.Items(I).SubItems.Item(1).Text
            End If

        Next

        If My.Forms.PedidoVenda.Visible = True Then My.Forms.PedidoVenda.C�digoFuncion�rio.Text = Ret
        If My.Forms.Or�amento.Visible = True Then My.Forms.Or�amento.C�digoFuncion�rio.Text = Ret
        If My.Forms.OSor�amento.Visible = True Then
            My.Forms.OSor�amento.C�digoFuncion�rio.Text = Ret
            My.Forms.OSor�amento.FuncionarioDesc.Text = str
        End If
        If My.Forms.PedidoOS.Visible = True Then My.Forms.PedidoOS.C�digoFuncion�rio.Text = Ret
        If My.Forms.frmPedidoMP.Visible Then My.Forms.frmPedidoMP.CodigoVendedor.Text = Ret

        Me.Close()
        Me.Dispose()
    End Sub

   
    Private Sub MyLista_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyLista.KeyDown
        If e.KeyCode = Keys.Return Then
            MyLista_DoubleClick(sender, e)
           
        End If

    End Sub
End Class