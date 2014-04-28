Public Class RecebidaVoltar

    Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

    Dim DocIdRelacionado As Integer = 0

    Private Sub RecebidaVoltar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.Open()
        Me.DataMovimento.Text = DataDia
        DocsBaixadoDia()
    End Sub

    Private Sub DocsBaixadoDia()

        MyLista.Items.Clear()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM Receber WHERE Recebimento = #" & Format(CDate(Me.DataMovimento.Text), "MM/dd/yyyy") & "# and Baixado = true and Empresa = " & CodEmpresa & " and Inativo = False And CaixaBaixado = '" & CaixaAtivo & "'"
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            Dim Zebrar As Boolean = False

            While DR.Read
                If Not IsDBNull(DR.Item("Id")) Then
                    Dim AA As String = DR.Item("Id")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("Documento") & "")
                    It.SubItems.Add(DR.Item("ValorLiquido") & "")
                    It.SubItems.Add(DR.Item("Recebimento") & "")
                    It.SubItems.Add(DR.Item("Cliente") & "")

                    MyLista.Items.AddRange(New ListViewItem() {It})

                    If Zebrar = True Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.MediumPurple
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
    
    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Cnn.Close()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick

        DocIdRelacionado = 0

        Dim I As Integer = 0

        Me.Cursor = Cursors.WaitCursor
        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then Me.Id.Text = MyLista.Items(I).Text.Substring(0)
            If MyLista.Items(I).Selected = True Then Me.Documento.Text = MyLista.Items(I).SubItems(1).Text.Substring(0)
            If MyLista.Items(I).Selected = True Then Me.Valor.Text = FormatNumber(MyLista.Items(I).SubItems(2).Text.Substring(0), 2)
            If MyLista.Items(I).Selected = True Then Me.Recebimento.Text = MyLista.Items(I).SubItems(3).Text.Substring(0)
            If MyLista.Items(I).Selected = True Then Me.Cliente.Text = MyLista.Items(I).SubItems(4).Text.Substring(0)
        Next
        Me.Refresh()
        If Me.Id.Text = "" Then
            Exit Sub
        End If

        DocRelacionado()
        LancamentoCaixa()
        Me.Refresh()
        Me.Refresh()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DocRelacionado()

        Me.ListaDocParcial.Items.Clear()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM Receber WHERE VinculoBXPARCIAL = " & Me.Id.Text
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            Dim Zebrar As Boolean = False

            While DR.Read
                If Not IsDBNull(DR.Item("Id")) Then
                    Dim AA As String = DR.Item("Id")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("Documento") & "")
                    It.SubItems.Add(FormatNumber(DR.Item("ValorDocumento"), 2))
                    It.SubItems.Add(DR.Item("Vencimento") & "")

                    ListaDocParcial.Items.AddRange(New ListViewItem() {It})

                    DocIdRelacionado = DR.Item("VinculoBXPARCIAL")

                    If Zebrar = True Then
                        ListaDocParcial.Items.Item(ListaDocParcial.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    Else
                        ListaDocParcial.Items.Item(ListaDocParcial.Items.Count() - 1).BackColor = Color.Aquamarine
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

    Private Sub LancamentoCaixa()

        Me.ListaCaixa.Items.Clear()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM LancamentoBanco WHERE IdLancamento = 'RECEBER' and IdProcura = " & Me.Id.Text
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            Dim Zebrar As Boolean = False

            While DR.Read
                If Not IsDBNull(DR.Item("Id")) Then
                    Dim AA As String = DR.Item("Id")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("Documento") & "")
                    It.SubItems.Add(DR.Item("DataLancamento") & "")
                    It.SubItems.Add(FormatNumber(DR.Item("ValorDocumento"), 2))
                    It.SubItems.Add(DR.Item("ContaCorrente"))
                    Me.Tipo.Text = DR.Item("Tipo")
                    ListaCaixa.Items.AddRange(New ListViewItem() {It})

                    If Zebrar = True Then
                        ListaCaixa.Items.Item(ListaCaixa.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    Else
                        ListaCaixa.Items.Item(ListaCaixa.Items.Count() - 1).BackColor = Color.MediumOrchid
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

    Private Sub btVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVoltar.Click

        If Me.Tipo.Text <> "BANCO" Then
            If CDate(Me.DataMovimento.Text) <> CDate(DataDia) Then
                MessageBox.Show("Este movimento pertence a um caixa fechado não pode ser alterado.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        Dim Sql As String = ""
        Dim Cmd As OleDb.OleDbCommand = Cnn.CreateCommand
        Dim CmdComissao As OleDb.OleDbCommand = Cnn.CreateCommand

        Dim DR As OleDb.OleDbDataReader

        'Verifica se existe documento relacionado ao doc parcial
        If DocIdRelacionado <> 0 Then
            Sql = "SELECT * FROM Receber WHERE VinculoBXPARCIAL = " & DocIdRelacionado
            Cmd.CommandText = Sql

            Try

                DR = Cmd.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    If DR.Item("Baixado") = True Then
                        MsgBox("Este documento não pode ser voltado pois já existe uma nova baixa parcial da identificação nº " & DR.Item("id"), 64, "Validação de Dados")
                        DR.Close()
                        Exit Sub
                    End If
                End If
                DR.Close()

            Catch Merror As System.Exception
                MsgBox(Merror.ToString)
                Exit Sub
            End Try
        End If
        'fim

        'Apagar registros nescessario e fazer os extornos

        Dim Autorizado As Boolean = PedirPermissao(Me.Text, Me.Documento.Text)
        Autorizado = varAutorizado
        If Autorizado = False Then
            Exit Sub
        End If

        Dim Transacao As OleDb.OleDbTransaction = Cnn.BeginTransaction()
        Cmd.Transaction = Transacao
        CmdComissao.Transaction = Transacao
        Try
            Sql = "Delete * FROM LancamentoBanco WHERE IdLancamento = 'RECEBER' and IdProcura = " & Me.Id.Text
            Cmd.CommandText = Sql
            Cmd.ExecuteNonQuery()

            Dim IdPrg As String = String.Empty
            If Mid(Me.Documento.Text, 1, 2) = "CX" Then IdPrg = "CAIXALANC" Else IdPrg = "RECEBER"


            Sql = "Delete * FROM Receber WHERE VinculoBXPARCIAL = " & Me.Id.Text
            Cmd.CommandText = Sql
            Cmd.ExecuteNonQuery()

            Sql = "Delete * FROM ArquivoCheque WHERE IdReceber = " & Me.Id.Text
            Cmd.CommandText = Sql
            Cmd.ExecuteNonQuery()


            Sql = "UPDATE Receber SET Receber.ValorLiquido = 0, Receber.Recebimento = Null, Receber.Baixado = False WHERE (((Receber.ID)=" & Me.Id.Text & "));"
            Cmd.CommandText = Sql
            Cmd.ExecuteNonQuery()

            'Extornar Comissao
            Sql = "INSERT INTO FuncionarioComissao ( DataLancamento, DataDocumento, Funcionario, Documento, PedidoVenda, Produto, Percentual, ValorDocumento, ValorComissao, TipoComissao, ComissaoFaturamento, OndeVeio, IdOrigem, DescComissao ) SELECT #" & Format(CDate(DataDia), "MM/dd/yyyy") & "# AS DataLanc, FuncionarioComissao.DataDocumento, FuncionarioComissao.Funcionario, FuncionarioComissao.Documento, FuncionarioComissao.PedidoVenda, FuncionarioComissao.Produto, FuncionarioComissao.Percentual, FuncionarioComissao.ValorDocumento *-1, [ValorComissao]*-1 AS ComissaoEXT, FuncionarioComissao.TipoComissao, FuncionarioComissao.ComissaoFaturamento, FuncionarioComissao.OndeVeio, FuncionarioComissao.IdOrigem, 'EXTORNO ' & [DescComissao] AS DescComissaoEXT FROM(FuncionarioComissao) WHERE (((FuncionarioComissao.OndeVeio)='RECEBER') AND ((FuncionarioComissao.IdOrigem)=" & Me.Id.Text & "));"
            CmdComissao.CommandText = Sql
            CmdComissao.ExecuteNonQuery()
            'Fim

            If CStr(Me.Documento.Text).IndexOf("CX-") <> -1 Then
                Sql = "Delete * FROM Receber WHERE Id = " & Me.Id.Text
                Cmd.CommandText = Sql
                Cmd.ExecuteNonQuery()
            End If


            Transacao.Commit()
            MsgBox("Recebimento estornado com sucesso, verifique valore no contas a receber e no caixa.", 64, "Validação de Dados")
            GerarLog(Me.Text, AçãoTP.Confirmou, Me.Documento.Text)

            DocsBaixadoDia()
            Me.ListaDocParcial.Items.Clear()
            Me.ListaCaixa.Items.Clear()
            Me.Id.Clear()
            Me.Documento.Clear()
            Me.Valor.Clear()
            Me.Recebimento.Clear()
            Me.Cliente.Clear()

        Catch ex As Exception
            Transacao.Rollback()
            Cnn.Close()
            MsgBox(ex.Message, 64, "Validação de Dados")
            MsgBox("Erro ao estornar o documento de recebimento, tente estornar novamente ou consulte o administrador.", 64, "Validação de Dados")
            GerarLog(Me.Text, AçãoTP.Erro, Me.Documento.Text)
            Exit Sub
        End Try
    End Sub

    Private Sub DataMovimento_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataMovimento.Leave
        DocsBaixadoDia()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
End Class