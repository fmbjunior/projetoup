Public Class PedidoAcompanhamentoProcura


    Private Sub TxtProcura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtProcura.KeyPress
        Dim Tecla As Short = Asc(e.KeyChar)

        If Tecla = 13 Then
            System.Windows.Forms.SendKeys.Send("{Tab}")
            Tecla = 0
        End If
    End Sub

    Private Sub TxtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProcura.Leave
        If Me.TxtProcura.Text = "" Then
            Exit Sub
        End If

        MyLista.Items.Clear()

        Dim CampoFilter As String = ""
        If Me.Pedido.Checked = True Then
            CampoFilter = "Pedido"
        Else
            CampoFilter = "Nome"
        End If

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        Cnn.Open()

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            '.CommandText = "SELECT PedidoAcompanhamento.Pedido, Clientes.Nome, Clientes.Cidade, PedidoAcompanhamento.Empresa, Pedido.Inativo, Pedido.DataPedido FROM Pedido INNER JOIN Clientes ON Pedido.CódigoCliente = Clientes.Codigo WHERE Pedido.Inativo = False and Pedido.Empresa = " & CodEmpresa & " and " & CampoFilter & " Like '%" & Me.TxtProcura.Text & "' & '%' order by PedidoSequencia DESC"
            .CommandText = "SELECT PedidoAcompanhamento.Pedido, PedidoAcompanhamento.Cliente, Clientes.Nome, PedidoAcompanhamento.Empresa, PedidoAcompanhamento.Status, PedidoAcompanhamento.Inativo FROM PedidoAcompanhamento INNER JOIN Clientes ON PedidoAcompanhamento.Cliente = Clientes.Codigo WHERE " & CampoFilter & " Like '%" & Me.TxtProcura.Text & "' & '%' AND PedidoAcompanhamento.Empresa = " & CodEmpresa & " AND PedidoAcompanhamento.Inativo = False"
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader


            While DataReader.Read
                If Not IsDBNull(DataReader.Item("Pedido")) Then
                    Dim AA As String = DataReader.Item("Pedido")
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("Nome") & "")
                    item1.SubItems.Add(DataReader.Item("Status") & "")
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

    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub AtualizarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarBT.Click

        Dim I As Integer = 0
        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then My.Forms.PedidoAcompanhamento.Pedido.Text = (MyLista.Items(I).Text.Substring(0))
        Next

        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        AtualizarBT_Click(sender, e)
    End Sub

    Private Sub PedidoVendaProcura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            Me.TxtProcura.Clear()
            Me.TxtProcura.Focus()
        End If
    End Sub

    Private Sub TelaProcura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()
        Me.Cliente.Checked = True
        Me.TxtProcura.Focus()
    End Sub

    Private Sub Fornecedor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cliente.Click
        Me.TxtProcura.Focus()
    End Sub

    Private Sub NotaFiscal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pedido.Click
        Me.TxtProcura.Focus()
    End Sub

    Private Sub MyLista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyLista.KeyDown
        If e.KeyCode = Keys.Enter Then
            AtualizarBT_Click(sender, e)
        End If
    End Sub

    Private Sub Degrade()
        Try
            Dim CCor() As String
            Dim corTemp As String

            corTemp = Cor1TelaSecundaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))

            corTemp = Cor2TelaSecundaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))
        Catch ex As Exception
        End Try
    End Sub
End Class