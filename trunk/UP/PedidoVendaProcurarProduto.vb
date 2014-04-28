Public Class PedidoVendaProcurarProduto


    Private Sub TxtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProcura.Leave
        If Me.TxtProcura.Text = "" Then
            Me.TxtProcura.Focus()
            Exit Sub
        End If

        MyLista.Items.Clear()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "SELECT * FROM Produtos WHERE Empresa = " & CodEmpresa & " and  Inativo = false and Descrição Like '%" & Me.TxtProcura.Text & "' & '%' Order by Produtos.Tipo"

        Dim Cmd As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DataReader As OleDb.OleDbDataReader

        Try
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item("CodigoProduto")) Then
                    Dim AA As String = DataReader.Item("CodigoProduto")
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("Descrição") & "")
                    If DataReader.Item("Tipo") <> 99 Then item1.SubItems.Add(FormatNumber(Nz(DataReader.Item("QuantidadeEstoque"), 3), 4))
                    item1.SubItems.Add(DataReader.Item("Referencia") & "")

                    MyLista.Items.AddRange(New ListViewItem() {item1})

                    If DataReader.Item("Tipo") = 99 Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.SandyBrown
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

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        Dim I As Integer = 0
        Dim Id As String = String.Empty

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then Id = (MyLista.Items(I).Text.Substring(0))
        Next

        If My.Forms.PedidoAddItem.Visible = True Then My.Forms.PedidoAddItem.CodigoProduto.Text = Id
        If My.Forms.ProdutoComposicaoAdd.Visible = True Then My.Forms.ProdutoComposicaoAdd.ProdComposicao.Text = Id
        If My.Forms.OrçamentoItens.Visible = True Then My.Forms.OrçamentoItens.CodigoProduto.Text = Id
        If My.Forms.OSorçamentoItens.Visible = True Then My.Forms.OSorçamentoItens.CodigoProduto.Text = Id
        If My.Forms.PedidoAddItemOS.Visible = True Then My.Forms.PedidoAddItemOS.CodigoProduto.Text = Id
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub PedidoVendaProcurarProduto_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.TxtProcura.Focus()
    End Sub

    Private Sub TelaProcura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TxtProcura.Focus()
    End Sub


    Private Sub MyLista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyLista.KeyDown
        If e.KeyCode = Keys.Enter Then
            MyLista_DoubleClick(sender, e)
        End If
    End Sub



    Private Sub TxtProcura_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtProcura.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.TxtProcura.Text = "" Then
                Me.btFechar.Focus()
            Else
                Me.MyLista.Focus()
            End If
        End If
    End Sub

    Private Sub btMostrarTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMostrarTodos.Click

        MyLista.Items.Clear()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "SELECT * FROM Produtos WHERE Empresa = " & CodEmpresa & " and  Inativo = false Order by Produtos.Tipo"

        Dim Cmd As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DataReader As OleDb.OleDbDataReader

        Try
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item("CodigoProduto")) Then
                    Dim AA As String = DataReader.Item("CodigoProduto")
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("Descrição") & "")
                    If DataReader.Item("Tipo") <> 99 Then item1.SubItems.Add(FormatNumber(Nz(DataReader.Item("QuantidadeEstoque"), 3), 4))
                    item1.SubItems.Add(DataReader.Item("Referencia") & "")

                    MyLista.Items.AddRange(New ListViewItem() {item1})

                    If DataReader.Item("Tipo") = 99 Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.SandyBrown
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

    Private Sub MyLista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyLista.SelectedIndexChanged
        Dim I As Integer = 0
        Dim Id As String = String.Empty

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then Me.Referencia.Text = (MyLista.Items(I).SubItems(3).Text.Substring(0))
        Next
    End Sub
End Class