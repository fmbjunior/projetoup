Public Class CompraProcurarDevolucao
    Private Sub TxtProcura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtProcura.KeyPress
        Dim Tecla As Short = Asc(e.KeyChar)

        If Tecla = 13 Then
            System.Windows.Forms.SendKeys.Send("{Tab}")
            Tecla = 0
        End If
    End Sub

    Private Sub TxtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProcura.Leave

        MyLista.Items.Clear()

        Dim Sql As String = String.Empty

        Dim CampoFilter As String = ""

        If Me.NotaFiscal.Checked = True Then
            If Me.TxtProcura.Text = "" Then
                Exit Sub
            End If

            CampoFilter = "NotaFiscal"
            Sql = "SELECT Compra.CompraInterno, Compra.Confirmado, Compra.Tipo, Compra.NotaFiscal, Compra.DataCompra, Compra.ValorCompra, Fornecedor.RazãoSocial, Compra.Empresa FROM Compra INNER JOIN Fornecedor ON Compra.CodigoFornecedor = Fornecedor.CódigoFornecedor WHERE Compra.Empresa = " & CodEmpresa & " and " & CampoFilter & " Like '%" & Me.TxtProcura.Text & "' & '%'"
        End If

        If Me.Fornecedor.Checked = True Then
            If Me.TxtProcura.Text = "" Then
                Exit Sub
            End If

            CampoFilter = "RazãoSocial"
            Sql = "SELECT Compra.CompraInterno, Compra.Confirmado, Compra.Tipo, Compra.NotaFiscal, Compra.DataCompra, Compra.ValorCompra, Fornecedor.RazãoSocial, Compra.Empresa FROM Compra INNER JOIN Fornecedor ON Compra.CodigoFornecedor = Fornecedor.CódigoFornecedor WHERE Compra.Empresa = " & CodEmpresa & " and " & CampoFilter & " Like '%" & Me.TxtProcura.Text & "' & '%'"
        End If

        If Me.MostrarTodos.Checked = True Then
            Sql = "SELECT Compra.CompraInterno, Compra.Confirmado, Compra.Tipo, Compra.NotaFiscal, Compra.DataCompra, Compra.ValorCompra, Fornecedor.RazãoSocial, Compra.Empresa FROM Compra INNER JOIN Fornecedor ON Compra.CodigoFornecedor = Fornecedor.CódigoFornecedor WHERE Compra.Empresa = " & CodEmpresa
        End If

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Cmd As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DataReader As OleDb.OleDbDataReader


        Try
            DataReader = Cmd.ExecuteReader


            While DataReader.Read
                If Not IsDBNull(DataReader.Item("CompraInterno")) Then
                    Dim AA As String = DataReader.Item("CompraInterno")
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("NotaFiscal") & "")
                    item1.SubItems.Add(FormatNumber(Nz(DataReader.Item("ValorCompra"), 3), 2))
                    item1.SubItems.Add(DataReader.Item("RazãoSocial") & "")
                    item1.SubItems.Add(DataReader.Item("Tipo") & "")
                    item1.SubItems.Add(DataReader.Item("DataCompra") & "")

                    If DataReader.Item("Confirmado") = True Then
                        item1.SubItems.Add("SIM")
                    Else
                        item1.SubItems.Add("NÃO")
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
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        RetornoProcura = ""
        Dim I As Integer = 0

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then RetornoProcura = (MyLista.Items(I).Text.Substring(0))
        Next

        If RetornoProcura <> "" Then

            If My.Forms.Compra.Visible = True Then My.Forms.Compra.IdNFdevMae.Text = RetornoProcura
            If SellShoesCompra.Visible = True Then SellShoesCompra.IdNFdevMae.Text = RetornoProcura


        End If
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub TelaProcura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Fornecedor.Checked = True
        Me.TxtProcura.Focus()
    End Sub

    Private Sub Fornecedor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fornecedor.Click
        Me.TxtProcura.Focus()
    End Sub

    Private Sub NotaFiscal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotaFiscal.Click
        Me.TxtProcura.Focus()
    End Sub



    Private Sub MostrarTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarTodos.CheckedChanged
        TxtProcura_Leave(sender, e)
    End Sub

   
End Class