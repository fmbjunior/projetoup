Public Class ChequePreDevolver

    Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

    Private Sub ChequePreDevolver_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Insert Then
            TRVDados(UserAtivo, "CodigoSegurança")
            If Ina = True Then
                MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
                Exit Sub
            Else
                My.Forms.CodigoSegurança.ShowDialog()
            End If
        End If
    End Sub


    Private Sub ChequePreDevolver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.Open()

        Me.CaixaCod.Text = CaixaAtivo

    End Sub

    Private Sub DocsBaixadoPeriodo()

        If Me.DataMovimentoInicial.Text = "" Then
            Exit Sub
        End If

        MyLista.Items.Clear()

        Dim Sql As String = "SELECT * FROM ArquivoCheque WHERE DataBaixa Between #" & Format(CDate(Me.DataMovimentoInicial.Text), "MM/dd/yyyy") & "# and #" & Format(CDate(Me.DataMovimentoFinal.Text), "MM/dd/yyyy") & "# and Historico = 'Baixado' and Empresa = " & CodEmpresa & " And CaixaBaixado = '" & Me.CaixaCod.Text & "'"
        Dim Cmd As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        Try
            DR = Cmd.ExecuteReader
            Dim Zebrar As Boolean = False

            While DR.Read
                If Not IsDBNull(DR.Item("IdCodigo")) Then
                    Dim AA As String = DR.Item("IdCodigo")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("Cheque") & "")
                    It.SubItems.Add(DR.Item("CC") & "")
                    It.SubItems.Add(FormatNumber(NzZero(DR.Item("ValorCh")), 2))
                    It.SubItems.Add(DR.Item("DataBaixa") & "")
                    It.SubItems.Add(DR.Item("EntreguePor") & "")
                    It.SubItems.Add(DR.Item("Historico") & "")
                    It.SubItems.Add(DR.Item("Banco") & "")
                    It.SubItems.Add(FormatNumber(NzZero(DR.Item("ValorCh")), 2))
                    It.SubItems.Add(DR.Item("LocalPgto") & "")
                    It.SubItems.Add(DR.Item("Pedido") & "")
                    It.SubItems.Add(DR.Item("Historico") & "")
                    It.SubItems.Add(DR.Item("ContaBalancete") & "")


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


    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Cnn.Close()
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub Filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Filtrar.Click
        DocsBaixadoPeriodo()
    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick


        Dim StrCheque As String = String.Empty
        Dim StrCC As String = String.Empty
        Dim BxBanco As Boolean = False
        Dim CodBanco As Integer = 0
        Dim ValorCh As Double
        Dim StrContaBalancete As String = String.Empty

        Dim strLocalPgto As String = String.Empty
        Dim IdOrigem As Integer

        Dim I As Integer = 0

        Me.Cursor = Cursors.WaitCursor
        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then IdOrigem = MyLista.Items(I).Text.Substring(0)
            If MyLista.Items(I).Selected = True Then StrCheque = MyLista.Items(I).SubItems(1).Text.Substring(0)
            If MyLista.Items(I).Selected = True Then StrCC = MyLista.Items(I).SubItems(2).Text.Substring(0)

            If MyLista.Items(I).Selected = True Then CodBanco = MyLista.Items(I).SubItems(7).Text.Substring(0)
            If MyLista.Items(I).Selected = True Then ValorCh = MyLista.Items(I).SubItems(8).Text.Substring(0)
            If MyLista.Items(I).Selected = True Then strLocalPgto = MyLista.Items(I).SubItems(9).Text.Substring(0)
            If MyLista.Items(I).Selected = True Then StrContaBalancete = MyLista.Items(I).SubItems(12).Text.Substring(0)


        Next

        If strLocalPgto = "CARTEIRA" Then
            MessageBox.Show("Este documento foi baixado para um caixa e não pode ser extornado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Fazer o extorno dos lançamento do caixa e retornar o documento.

        Dim Autorizado As Boolean = PedirPermissao(Me.Text, StrCheque)
        Autorizado = varAutorizado
        If Autorizado = False Then
            Exit Sub
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String
        Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()

        Dim CmdCheque As OleDb.OleDbCommand = CNN.CreateCommand
        Dim CmdBANCO As OleDb.OleDbCommand = CNN.CreateCommand
        Dim CmdComissao As OleDb.OleDbCommand = CNN.CreateCommand

        CmdCheque.Transaction = Transacao
        CmdBANCO.Transaction = Transacao
        CmdComissao.Transaction = Transacao

        Try
            'Volta o cheque que foi devolvido
            Sql = "UPDATE ArquivoCheque SET ArquivoCheque.Historico = 'DEVOLVIDO', ArquivoCheque.DataBaixa = Null, ArquivoCheque.Banco = 0 WHERE ArquivoCheque.Cheque = '" & StrCheque & "' AND ArquivoCheque.CC = '" & StrCC & "'"
            CmdCheque.CommandText = Sql
            CmdCheque.ExecuteNonQuery()

            'Se foi baixado no banco fazer o extorno
            If strLocalPgto = "BANCO" Then
                Sql = "INSERT INTO LancamentoBanco (DataLancamento, PreDatado, Documento, DataDocumento, TipoLancamento, ContaCorrente, Favorecido, Historico, CaiuBanco, ConfirmadoLancamento, Empresa, ValorDocumento, EmitirCheque, DocumentoExterno, CaixaBaixado, IdLancamento, IdProcura, Tipo, ContaBalancete) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19)"
                CmdBANCO.CommandText = Sql

                CmdBANCO.Parameters.Add(New OleDb.OleDbParameter("@1", DataDia)) 'DataLançamento
                CmdBANCO.Parameters.Add(New OleDb.OleDbParameter("@2", False)) 'Pre-Datado
                CmdBANCO.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(StrCheque, 1))) 'Documento
                CmdBANCO.Parameters.Add(New OleDb.OleDbParameter("@4", DataDia)) 'DataDocumento/DataVencimento
                CmdBANCO.Parameters.Add(New OleDb.OleDbParameter("@5", "D")) 'TipoLancamento
                CmdBANCO.Parameters.Add(New OleDb.OleDbParameter("@6", NzZero(CodBanco))) 'ContaCorrente
                CmdBANCO.Parameters.Add(New OleDb.OleDbParameter("@7", "EXTORNO CHEQUE")) 'Favorecido
                CmdBANCO.Parameters.Add(New OleDb.OleDbParameter("@8", "EXTORNO. CH. " & StrCheque)) 'Historico
                CmdBANCO.Parameters.Add(New OleDb.OleDbParameter("@9", "N")) 'CaiuBanco
                CmdBANCO.Parameters.Add(New OleDb.OleDbParameter("@10", True)) 'ConfirmadoLancamento 
                CmdBANCO.Parameters.Add(New OleDb.OleDbParameter("@11", CodEmpresa)) 'Empresa
                CmdBANCO.Parameters.Add(New OleDb.OleDbParameter("@12", NzZero((CDbl(ValorCh) * -1)))) 'ValorDocumento
                CmdBANCO.Parameters.Add(New OleDb.OleDbParameter("@13", "N")) 'Emitir Cheque
                CmdBANCO.Parameters.Add(New OleDb.OleDbParameter("@14", True)) 'DocumentoExterno
                CmdBANCO.Parameters.Add(New OleDb.OleDbParameter("@15", CaixaAtivo)) 'Caixa Ativo
                CmdBANCO.Parameters.Add(New OleDb.OleDbParameter("@17", "CHEQUE-PRE")) 'IdLancamento
                CmdBANCO.Parameters.Add(New OleDb.OleDbParameter("@17", IdOrigem)) 'IdOrigem
                CmdBANCO.Parameters.Add(New OleDb.OleDbParameter("@18", "BANCO")) 'IdOrigem
                CmdBANCO.Parameters.Add(New OleDb.OleDbParameter("@19", Nz(StrContaBalancete, 1))) 'Conta de Balancete

                CmdBANCO.ExecuteNonQuery()
            End If

            'Fazer o extorno das comissoes referente ao Cheque
            Sql = "INSERT INTO FuncionarioComissao ( DataLancamento, DataDocumento, Funcionario, Documento, PedidoVenda, Produto, Percentual, ValorDocumento, ValorComissao, TipoComissao, ComissaoFaturamento, OndeVeio, IdOrigem, DescComissao ) SELECT #" & Format(CDate(DataDia), "MM/dd/yyyy") & "# AS DataLanc, FuncionarioComissao.DataDocumento, FuncionarioComissao.Funcionario, FuncionarioComissao.Documento, FuncionarioComissao.PedidoVenda, FuncionarioComissao.Produto, FuncionarioComissao.Percentual, FuncionarioComissao.ValorDocumento, [ValorComissao]*-1 AS ComissaoEXT, FuncionarioComissao.TipoComissao, FuncionarioComissao.ComissaoFaturamento, FuncionarioComissao.OndeVeio, FuncionarioComissao.IdOrigem, 'EXTORNO ' & [DescComissao] AS DescComissaoEXT FROM(FuncionarioComissao) WHERE (((FuncionarioComissao.OndeVeio)='CH-PRE') AND ((FuncionarioComissao.IdOrigem)=" & IdOrigem & "));"
            CmdComissao.CommandText = Sql
            CmdComissao.ExecuteNonQuery()
            'Fim

            Transacao.Commit()
            MsgBox("Cheque Devolvido com Sucesso.", 64, "Validação de Dados")
            ErroLivre = "Cheque Devolvido com Sucesso"
            GerarLog(Me.Text, AçãoTP.Livre, Me.ColCheque.Text)

            CNN.Close()
            DocsBaixadoPeriodo()
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Transacao.Rollback()
            CNN.Close()
            MsgBox(ex.Message, 64, "Validação de Dados")
            MsgBox("Erro ao retornar o cheque, tente retornar novamente ou consulte o administrador.", 64, "Validação de Dados")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

    End Sub

End Class