Public Class EstoqueFindProdutoFabrica

    Private Sub TxtProcura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtProcura.KeyDown
        If e.KeyCode = Keys.F11 Then
            Fechar_Click(sender, e)
        End If
    End Sub
    Private Sub TxtProcura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtProcura.KeyPress
        Dim Tecla As Short = Asc(e.KeyChar)

        If Tecla = 13 Then
            System.Windows.Forms.SendKeys.Send("{Tab}")
            Tecla = 0
        End If

    End Sub

    Private Sub TxtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProcura.Leave
        If Me.TxtProcura.Text = "" Then
            Me.TxtProcura.Focus()
            Exit Sub
        End If

        MyLista.Items.Clear()


        Dim Cnn As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        Cnn.Open()

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM Produtos WHERE Empresa = " & CodEmpresa & " and  Inativo = false and ProdutoIndustria = True And Descrição Like '%" & Me.TxtProcura.Text & "' & '%'"
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item("CodigoProduto")) Then
                    Dim AA As String = DataReader.Item("CodigoProduto")
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("Descrição") & "")

                    MyLista.Items.AddRange(New ListViewItem() {item1})

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

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        RetornoProcura = ""
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Atualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Atualizar.Click
        RetornoProcura = ""
        Dim I As Integer = 0

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then RetornoProcura = (MyLista.Items(I).Text.Substring(0))
        Next

        If RetornoProcura = "" Then
            MsgBox("O usuário deve informar um iten da lista de procura.", 64, TituloMsgbox)
            Me.MyLista.Focus()
            Exit Sub
        End If
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        Atualizar_Click(sender, e)
    End Sub

    Private Sub ProcurarProdutoDetalhado_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.TxtProcura.Focus()
    End Sub

    Private Sub TelaProcura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TxtProcura.Focus()
    End Sub

    Private Sub ProdutoEmpresa_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.TxtProcura.Focus()
    End Sub

    Private Sub MyLista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyLista.KeyDown
        If e.KeyCode = Keys.Enter Then
            Atualizar_Click(sender, e)
        End If
    End Sub
End Class