Public Class LoteInformarNF


    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Fornecedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fornecedor.KeyDown
        If e.KeyCode = Keys.F5 Then
            MultiEmpresa = True
            My.Forms.TelaProcuraForCtrlPedido.ShowDialog()
            Me.Fornecedor.Text = RetornoProcura
            Me.Fornecedor.Focus()
        End If
    End Sub

   
    Private Sub Fornecedor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fornecedor.Validated

        If ConnectionState.Closed Then
            Exit Sub
        End If

        If Me.Fornecedor.Text = "" Then
            Exit Sub
        End If

        Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "Select * from Fornecedor where CódigoFornecedor = " & Me.Fornecedor.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.FornecedorDesc.Text = DR.Item("RazãoSocial") & ""
        Else
            MsgBox("Verifique os dados do fornecedor, ou fornecedor não existe no cadastro.", 64, "Validação de Dados")
            Exit Sub
        End If
        DR.Close()

        MyLista.Items.Clear()

        Dim DataReader As OleDb.OleDbDataReader

        With CMD
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM CompraCtrlPedido WHERE Empresa = " & CodEmpresa & " AND Inativo = False and Fornecedor = " & Me.Fornecedor.Text & " And NotaFiscal Is Null Order by Documento"
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = CMD.ExecuteReader

            Dim T As Double = 0
            While DataReader.Read
                If Not IsDBNull(DataReader.Item("Id")) Then
                    Dim AA As String = DataReader.Item("Id")
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("FornecedorDesc") & "")
                    item1.SubItems.Add(DataReader.Item("Documento") & "")
                    item1.SubItems.Add(FormatNumber(DataReader.Item("ValorPedido"), 2))
                    MyLista.Items.AddRange(New ListViewItem() {item1})

                    T += FormatNumber(NzZero(DataReader.Item("ValorPedido")), 2)
                End If
            End While

            Me.TDoc.Text = FormatNumber(T, 2)
            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try

    End Sub

    Private Sub LoteInformarNF_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Fornecedor.Focus()
    End Sub

    Private Sub LoteInformarNF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MyLista_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles MyLista.ItemChecked
        Dim VParcial As Double = 0
        Dim I As Integer = 0
        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Checked = True Then VParcial += NzZero(MyLista.Items(I).SubItems(3).Text.Substring(0))
        Next

        Me.TSelecionado.Text = FormatNumber(VParcial, 2)
    End Sub


    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDocSelec.Click
        If Me.NF.Text = "" Then
            MsgBox("Não foi informado o numero da Nota Fiscal para atualizar os documentos selecionados.")
            Me.NF.Focus()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor


        Dim Cnn1 As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn1.Open()

        Dim DS As New DataSet()

        Dim Sql As String = String.Empty
        Sql = "SELECT * FROM CompraCtrlPedido WHERE Empresa = " & CodEmpresa & " AND Inativo = False and Fornecedor = " & Me.Fornecedor.Text & " And NotaFiscal Is null Order by Documento"
        Dim DACompraCtrlPedido As New OleDb.OleDbDataAdapter(Sql, Cnn1)

        Try
            DACompraCtrlPedido.Fill(DS, "CompraCtrlPedido")

            Dim I As Integer = 0
            Dim IDSTR As String = String.Empty

            For I = 0 To MyLista.Items.Count - 1
                If MyLista.Items(I).Checked = True Then
                    IDSTR = NzZero(MyLista.Items(I).Text.Substring(0))

                    Dim DrCompraCtrlPedido As DataRow
                    For Each DrCompraCtrlPedido In DS.Tables("CompraCtrlPedido").Rows
                        Dim DrCompraCtrlPedidoItem() As DataRow
                        DrCompraCtrlPedidoItem = DS.Tables("CompraCtrlPedido").Select("Id = " & IDSTR)

                        If DrCompraCtrlPedidoItem.Length = 0 Then
                            ' aqui nada a fazer pois nao incluiremos nada
                        Else

                            DrCompraCtrlPedidoItem(0).BeginEdit()
                            DrCompraCtrlPedidoItem(0)("NotaFiscal") = Me.NF.Text
                            DrCompraCtrlPedidoItem(0).EndEdit()
                            AtReceberNF(IDSTR)
                        End If
                    Next

                End If
            Next
        Catch AA As Exception
            MsgBox(AA.Message)
            DS.Dispose()
            Cnn1.Close()
            Me.Cursor = Cursors.Default
        End Try

        Try
            Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DACompraCtrlPedido)
            DACompraCtrlPedido.Update(DS, "CompraCtrlPedido")
        Catch ex As Exception
            MsgBox(ex.Message)
            DS.Dispose()
            Cnn1.Close()
            Me.Cursor = Cursors.Default
        End Try

        DS.Dispose()
        Cnn1.Close()

        MsgBox("Atualização realizada com sucesso.", 64, "Validação de Dados")
        Me.MyLista.Items.Clear()
        Me.NF.Clear()
        Me.Fornecedor.Clear()
        Me.FornecedorDesc.Clear()
        Me.Fornecedor.Focus()
        Me.Cursor = Cursors.Default

    End Sub



    Private Sub AtReceberNF(ByVal Idstr As String)

        Dim CNN1 As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN1.Open()

        Dim Sql As String = "UPDATE Pagar INNER JOIN CompraCtrlPedido ON Pagar.IdCompraCtrlPedido = CompraCtrlPedido.Id SET Pagar.NotaFiscal = '" & Me.NF.Text & "' WHERE Pagar.IdCompraCtrlPedido = " & Idstr 'Me.Id.Text
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN1)

        Try
            cmd.ExecuteNonQuery()
            CNN1.Close()
        Catch x As Exception
            MsgBox(x.Message)
            Exit Sub
        End Try
    End Sub

End Class