Public Class ProcurarProdutoDetalhado

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

        Dim CampoFilter As String = ""
        If Me.ProdutoEmpresa.Checked = True Then
            CampoFilter = "1"
        End If

        If Me.MateriaPrima.Checked = True Then
            CampoFilter = "2"
        End If

        If Me.Almoxarifado.Checked = True Then
            CampoFilter = "3"
        End If

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        Cnn.Open()

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM Produtos WHERE Empresa = " & CodEmpresa & " and  Inativo = false and Tipo = " & CampoFilter & " and Descrição Like '%" & Me.TxtProcura.Text & "' & '%'"
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item("CodigoProduto")) Then
                    Dim AA As String = DataReader.Item("CodigoProduto")
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("Descrição") & "")
                    If EstaCarregado("PedidoAddItem") = True Then
                        Me.MyLista.Columns(2).Width = 120
                        item1.SubItems.Add(FormatNumber(Nz(DataReader.Item("QuantidadeEstoque"), 3), 4))
                    Else
                        Me.MyLista.Columns(2).Width = 0
                    End If
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
            MsgBox("O usuário deve informar um iten da lista de procura.", 64, "Validação de Dados")
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
        Select Case TipoItensProcurar
            Case 1
                Me.Almoxarifado.Enabled = True
                Me.ProdutoEmpresa.Enabled = True
                Me.MateriaPrima.Enabled = True
                Me.ProdutoEmpresa.Checked = True
            Case 2
                Me.Almoxarifado.Enabled = True
                Me.ProdutoEmpresa.Enabled = True
                Me.MateriaPrima.Enabled = True
                Me.MateriaPrima.Checked = True
            Case 3
                Me.Almoxarifado.Enabled = True
                Me.ProdutoEmpresa.Enabled = False
                Me.MateriaPrima.Enabled = False
                Me.Almoxarifado.Checked = True
        End Select
    End Sub

    Private Sub ProdutoEmpresa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProdutoEmpresa.Click, MateriaPrima.Click, Almoxarifado.Click
        Me.TxtProcura.Focus()
    End Sub

    Private Sub MyLista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyLista.KeyDown
        If e.KeyCode = Keys.Enter Then
            Atualizar_Click(sender, e)
        End If
    End Sub

    Private Sub TxtProcura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtProcura.TextChanged

    End Sub
End Class