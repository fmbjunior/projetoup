Public Class ProducaoEstoqueConfirmar

    Private Sub ProducaoEstoqueConfirmar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregaListaPendente()
    End Sub

    Private Sub CarregaListaPendente()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT Producao.OrdemProducao, Producao.Solicitante, Producao.DataOrdem, Producao.Confirmado, Producao.GeradoEstoque FROM(Producao) WHERE (((Producao.Confirmado)=True) AND ((Producao.GeradoEstoque)=False));"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Lista.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Lista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellDoubleClick

        Dim IdItem As String
        IdItem = CInt(Me.Lista.CurrentRow.Cells(0).Value)
        LocalizarDadosOrdem(IdItem)

    End Sub



    Public Sub LocalizarDadosOrdem(ByVal OrdemId As String)
        If OrdemId = "" Then Exit Sub

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim Sql As String = "Select * From Producao  where OrdemProducao = " & OrdemId
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)
        Dim Dr As OleDb.OleDbDataReader

        Dr = cmd.ExecuteReader
        Dr.Read()

        If Dr.HasRows = True Then
            Me.OrdemProducao.Text = Dr.Item("OrdemProducao")
            Me.DataOrdem.Text = Dr.Item("DataOrdem")
            Me.Solicitante.Text = Dr.Item("Solicitante") & ""
            Me.Motivo.Text = Dr.Item("Motivo") & ""
            Me.Confirmado.Checked = Dr.Item("Confirmado")
            Me.GeradoEstoque.Checked = Dr.Item("GeradoEstoque")

            Dr.Close()
            CNN.Close()
            EncheListaItemOrdem()
        Else
            Dr.Close()
            CNN.Close()
        End If


    End Sub

    Public Sub EncheListaItemOrdem()

        If Me.OrdemProducao.Text = "" Then
            Exit Sub
        End If

        MyLista.Items.Clear()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT ProducaoItem.Id, ProducaoItem.OrdemProducao, ProducaoItem.Produto, Produtos.Descrição, ProducaoItem.Qtd, ProducaoItem.ValorUnitarioComissao FROM ProducaoItem INNER JOIN Produtos ON ProducaoItem.Produto = Produtos.CodigoProduto WHERE ProducaoItem.OrdemProducao = " & Me.OrdemProducao.Text

        Dim Cmd As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        Try
            DR = Cmd.ExecuteReader
            Dim Zebrar As Boolean = False

            While DR.Read
                If Not IsDBNull(DR.Item("Id")) Then
                    Dim AA As String = DR.Item("Id")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("OrdemProducao") & "")
                    It.SubItems.Add(DR.Item("Produto") & "")
                    It.SubItems.Add(DR.Item("Descrição") & "")
                    It.SubItems.Add(FormatNumber(NzZero(DR.Item("Qtd")), 4))


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
            CNN.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Exit Sub
        End Try

    End Sub


    Private Sub btConfiormarEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConfirmarEstoque.Click
        If Me.OrdemProducao.Text = "" Then
            MessageBox.Show("Selecione uma Ordem antes de confirmar.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.GeradoEstoque.Checked = True Then
            MessageBox.Show("Esta Ordem de produção já foi gerada em estoque.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
        Dim CmdEst1 As OleDb.OleDbCommand = CNN.CreateCommand
        Dim CmdEst2 As OleDb.OleDbCommand = CNN.CreateCommand
        Dim CmdEst3 As OleDb.OleDbCommand = CNN.CreateCommand

        CmdEst1.Transaction = Transacao
        CmdEst2.Transaction = Transacao
        CmdEst3.Transaction = Transacao

        Try

            Dim Sql As String = "INSERT INTO EstoqueUP ( PedidoOrdem, CodigoProduto, Qtd, QtdF, Tipo, IdLancamento, DataLancamento, Prg, NFDoc, ClienteFornecedor ) SELECT ProducaoItem.OrdemProducao, ProducaoItem.Produto, ProducaoItem.Qtd, 0 AS QtdF, 'E' AS Tipo, 0 AS IdLancamento, #" & Format(CDate(DataDia), "MM/dd/yyyy") & "# AS DataLancamento, 'ORDPRODUCAO' AS Prg, Producao.OrdemProducao, 'SOLICITANTE ' & Producao.Solicitante FROM ProducaoItem INNER JOIN Producao ON ProducaoItem.OrdemProducao = Producao.OrdemProducao WHERE (((ProducaoItem.OrdemProducao)=" & Me.OrdemProducao.Text & "));"
            CmdEst1.CommandText = Sql
            CmdEst1.ExecuteNonQuery()


            Sql = "INSERT INTO EstoqueUP ( PedidoOrdem, CodigoProduto, Qtd, QtdF, Tipo, IdLancamento, DataLancamento, Prg, NFDoc, ClienteFornecedor ) SELECT ProducaoItemSub.OrdemProducao, ProducaoItemSub.Produto, ProducaoItemSub.Qtd * -1, 0 AS QtdF, 'E' AS TipoES, 0 AS IdLancamento, #" & Format(CDate(DataDia), "MM/dd/yyyy") & "# AS DataLancamento, 'ORDPRODUCAO' AS Prg, Producao.OrdemProducao, 'SOLICITANTE ' & Producao.Solicitante FROM (Producao INNER JOIN ProducaoItemSub ON Producao.OrdemProducao = ProducaoItemSub.OrdemProducao) INNER JOIN Produtos ON ProducaoItemSub.Produto = Produtos.CodigoProduto WHERE (((ProducaoItemSub.OrdemProducao)=" & Me.OrdemProducao.Text & ") AND ((Produtos.Tipo)<>99));"
            CmdEst2.CommandText = Sql
            CmdEst2.ExecuteNonQuery()


            Sql = "UPDATE Producao SET Producao.GeradoEstoque = True WHERE (((Producao.OrdemProducao)=" & Me.OrdemProducao.Text & "));"
            CmdEst3.CommandText = Sql
            CmdEst3.ExecuteNonQuery()

            Transacao.Commit()
            Me.GeradoEstoque.Checked = True
            CNN.Close()


            System.Threading.Thread.Sleep(2000)
            Dim EstoqueGeral As New EstoqueAtualizar
            EstoqueGeral.Run_AtualizadorEstoqueOrdemProducao(Me.OrdemProducao.Text)

            CarregaListaPendente()

            MsgBox("Registro Confirmado em Estoque com sucesso", 64, "Validação de Dados")
            GerarLog(Me.Text, AçãoTP.Confirmou, Me.OrdemProducao.Text)

        Catch ex As Exception
            Transacao.Rollback()
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try


    End Sub
End Class