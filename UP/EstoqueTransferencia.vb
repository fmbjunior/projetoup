Public Class EstoqueTransferencia

    Dim Ação As New TrfGerais

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, False)
        Me.A1.Checked = False
        Me.A2.Checked = False
        Me.A1.Enabled = True
        Me.A2.Enabled = True
        Me.Confirmado.Checked = False
    End Sub

    Private Sub EstoqueTransferencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ação.Desbloquear_Controle(Me, False)
        Me.A1.Enabled = False
        Me.A2.Enabled = False
    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged
        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)
        Me.Id.Text = "0000"
        Me.Id.Enabled = False
        Me.CodigoProduto.Focus()
    End Sub


    Private Sub AcharProduto()

        If Me.CodigoProduto.Text = "" Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim Sql As String = "SELECT * FROM Produtos WHERE Produtos.CodigoProduto = " & Me.CodigoProduto.Text


        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            'Me.CodigoProduto.Text = DR.Item("CodigoProduto") & ""
            Me.ProdutoDesc.Text = DR.Item("Descrição") & ""
            Me.EstVenda.Text = FormatNumber(Nz(DR.Item("QuantidadeEstoque"), 3), 4)
            Me.EstDeposito.Text = FormatNumber(Nz(DR.Item("EstDeposito"), 3), 4)
        End If
        DR.Close()
        CNN.Close()
    End Sub

    Private Sub CodigoProduto_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CodigoProduto.Validating
        If String.CompareOrdinal(Me.CodigoProduto.Text, Me.CodigoProduto.TextoAntigo) Then
            AcharProduto()
        End If
    End Sub

    Private Sub btFindJuros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindJuros.Click
        Me.CodigoProduto.Clear()
        Me.ProdutoDesc.Clear()
        Me.EstDeposito.Clear()
        Me.EstVenda.Clear()

        Me.CodigoProduto.Focus()

        My.Forms.ProcuraProduto.ShowDialog()
    End Sub

    Private Sub CodigoProduto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoProduto.KeyDown
        If e.KeyCode = Keys.F5 Then
            Me.CodigoProduto.Clear()
            Me.ProdutoDesc.Clear()
            Me.EstDeposito.Clear()
            Me.EstVenda.Clear()

            Me.CodigoProduto.Focus()

            My.Forms.ProcuraProduto.ShowDialog()
        End If
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        If Me.CodigoProduto.Text = "" Then
            MessageBox.Show("O código do Produto não foi Informado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CodigoProduto.Focus()
            Exit Sub
        End If

        If Me.QtdTransf.Text = "" Then
            MessageBox.Show("A Quantidade a ser tranferida não foi informada", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.QtdTransf.Focus()
            Exit Sub
        End If

        If Me.DataLancamento.Text = "" Then
            MessageBox.Show("A data de Tranferência não foi informada.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DataLancamento.Focus()
            Exit Sub
        End If

        If Me.DescTransf.Text = "" Then
            MessageBox.Show("Não foi informada nenhuma descrição para a tranferência.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DescTransf.Focus()
            Exit Sub
        End If

        If Me.Usuario.Text = "" Then
            Me.Usuario.Focus()
            MessageBox.Show("O usuário não foi informado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.QtdTransf.Text = 0 Then
            MessageBox.Show("A Quantidade a ser tranferida não não pode ser igual a [0,00]", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.QtdTransf.Focus()
            Exit Sub
        End If

        If A1.Checked = True Then 'Tranferência (Estoque Venda) para (Estoque Depósito)
            If CDbl(NzZero(Me.EstVenda.Text)) < CDbl(NzZero(Me.QtdTransf.Text)) Then
                MessageBox.Show("A quantidade de estoque de venda é insuficiente para a tranferência.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.QtdTransf.Clear()
                Me.QtdTransf.Focus()
                Exit Sub
            End If
        End If

        If A2.Checked = True Then 'Tranferência (Estoque Depósito) para (Estoque Venda)
            If CDbl(NzZero(Me.QtdTransf.Text)) > CDbl(NzZero(Me.EstDeposito.Text)) Then
                MessageBox.Show("A quantidade de estoque no depósito é insuficiente para a tranferência.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.QtdTransf.Clear()
                Me.QtdTransf.Focus()
                Exit Sub
            End If
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        If MessageBox.Show("Deseja realmente fazer a tranferência de estoque." & Chr(13) & Chr(13) & "Esta ação não pode ser desfeita fica restrita a um novo lançamento de Extorno.", "Validação de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


            Me.Confirmado.Checked = True
            UltimoReg()

            If Me.Id.Text = "0000" Then
                MessageBox.Show("Nao foi criado o [ID] do registro.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CNN.Close()
                Exit Sub
            End If

            Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
            Dim cmd As OleDb.OleDbCommand = CNN.CreateCommand
            Dim cmdEstVenda As OleDb.OleDbCommand = CNN.CreateCommand
            Dim cmdEstDeposito As OleDb.OleDbCommand = CNN.CreateCommand

            cmd.Transaction = Transacao
            cmdEstVenda.Transaction = Transacao
            cmdEstDeposito.Transaction = Transacao

            Try

                cmd.CommandText = "INSERT INTO EstoqueTranf (Id, CodigoProduto, QtdTransf, EstVenda, EstDeposito, DataLancamento, DescTransf, Confirmado, Usuario, Empresa, VendaDeposito, DepositoVenda) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12)"

                cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Id.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.CodigoProduto.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.QtdTransf.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.EstVenda.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.EstDeposito.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.DataLancamento.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.DescTransf.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Me.Confirmado.Checked))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Me.Usuario.Text))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Me.A1.Checked))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Me.A2.Checked))
                cmd.ExecuteNonQuery()


                cmdEstVenda.CommandText = "INSERT INTO EstoqueUP (CodigoProduto, Qtd, Tipo, IdLancamento, DataLancamento, PedidoOrdem, Prg, ClienteFornecedor, NFDoc) Values(@1, @2, @3, @4, @5, @6, @7, @8, @9)"
                cmdEstVenda.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CodigoProduto.Text, 1)))
                Dim QtdTemp As Double = 0
                Dim Tp As String = String.Empty
                Dim Hist As String = String.Empty
                If A1.Checked = True Then
                    Tp = "S"
                    QtdTemp = (Nz(Me.QtdTransf.Text, 1) * -1)
                    Hist = "TRANSF. EST. VENDA PARA EST. DEPOSITO"
                Else
                    Tp = "E"
                    QtdTemp = Nz(Me.QtdTransf.Text, 1)
                    Hist = "TRANSF. EST. DEPOSITO PARA EST. VENDA"
                End If
                cmdEstVenda.Parameters.Add(New OleDb.OleDbParameter("@2", CDbl(QtdTemp)))
                cmdEstVenda.Parameters.Add(New OleDb.OleDbParameter("@3", Tp))
                cmdEstVenda.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Id.Text, 1)))
                cmdEstVenda.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.DataLancamento.Text, 1)))
                cmdEstVenda.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Id.Text, 1)))
                cmdEstVenda.Parameters.Add(New OleDb.OleDbParameter("@7", "TRANF-EST"))
                cmdEstVenda.Parameters.Add(New OleDb.OleDbParameter("@8", Hist))
                cmdEstVenda.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Id.Text, 1)))
                cmdEstVenda.ExecuteNonQuery()

                cmdEstDeposito.CommandText = "INSERT INTO EstoqueUPDeposito (CodigoProduto, Qtd, Tipo, DataLancamento, IdLancamento, Prg) Values( @1, @2, @3, @4, @5, @6)"
                cmdEstDeposito.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CodigoProduto.Text, 1)))
                Dim QtdTemp1 As Double = 0
                Dim Tp1 As String = String.Empty
                If A1.Checked = True Then
                    Tp1 = "E"
                    QtdTemp1 = Nz(Me.QtdTransf.Text, 1)
                Else
                    Tp1 = "S"
                    QtdTemp1 = (Nz(Me.QtdTransf.Text, 1) * -1)
                End If
                cmdEstDeposito.Parameters.Add(New OleDb.OleDbParameter("@2", CDbl(QtdTemp1)))
                cmdEstDeposito.Parameters.Add(New OleDb.OleDbParameter("@3", Tp1))
                cmdEstDeposito.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataLancamento.Text, 1)))
                cmdEstDeposito.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Id.Text, 1)))
                cmdEstDeposito.Parameters.Add(New OleDb.OleDbParameter("@6", "TRANF-EST"))
                cmdEstDeposito.ExecuteNonQuery()

                Transacao.Commit()
                CNN.Close()

                System.Threading.Thread.Sleep(2000)

                'Fazer atualizaçao do Estoque Geral do Produto

                CNN.Open()

                Dim dsEstGeral As New DataSet()

                Try

                    Dim sql = "SELECT EstoqueUP.CodigoProduto, Sum(EstoqueUP.Qtd) AS SomaDeQtd, Sum(EstoqueUP.QtdF) AS SomaDeQtdF FROM(EstoqueUP) GROUP BY EstoqueUP.CodigoProduto HAVING (((EstoqueUP.CodigoProduto)=" & Me.CodigoProduto.Text & "));"
                    Dim daEstoque As New OleDb.OleDbDataAdapter(sql, CNN)
                    daEstoque.Fill(dsEstGeral, "Estoque")

                    sql = "SELECT * FROM Produtos Where CodigoProduto = " & Me.CodigoProduto.Text
                    Dim daProduto As New OleDb.OleDbDataAdapter(sql, CNN)
                    daProduto.Fill(dsEstGeral, "Produtos")

                    sql = "SELECT EstoqueUpDeposito.CodigoProduto, Sum(EstoqueUpDeposito.Qtd) AS SomaDeQtd FROM(EstoqueUpDeposito) GROUP BY EstoqueUpDeposito.CodigoProduto HAVING (((EstoqueUpDeposito.CodigoProduto)=" & Me.CodigoProduto.Text & "));"
                    Dim daIT As New OleDb.OleDbDataAdapter(sql, CNN)
                    daIT.Fill(dsEstGeral, "EstoqueDeposito")




                    If dsEstGeral.Tables("Produtos").Rows.Count = 1 Then

                        dsEstGeral.Tables("Produtos").Rows(0).BeginEdit()
                        dsEstGeral.Tables("Produtos").Rows(0)("QuantidadeEstoque") = NzZero(dsEstGeral.Tables("Estoque").Rows(0)("SomaDeQtd"))
                        dsEstGeral.Tables("Produtos").Rows(0)("EstoqueFiscal") = NzZero(dsEstGeral.Tables("Estoque").Rows(0)("SomaDeQtdF"))
                        dsEstGeral.Tables("Produtos").Rows(0)("EstDeposito") = NzZero(dsEstGeral.Tables("EstoqueDeposito").Rows(0)("SomaDeQtd"))
                        dsEstGeral.Tables("Produtos").Rows(0).EndEdit()

                    End If

                    Dim objProduto As New OleDb.OleDbCommandBuilder(daProduto)
                    daProduto.Update(dsEstGeral, "Produtos")

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK)
                    MessageBox.Show("Aconteceram erros ao atualizar o estoque de Numeração do Produto, favor fazer atualização geral do estoque", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End Try


                MsgBox("Registro adicionado e confirmado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Adicionou, Me.CodigoProduto.Text)
                Ação.Desbloquear_Controle(Me, False)

            Catch ex As Exception
                Transacao.Rollback()
                CNN.Close()
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try

            CNN.Close()

        End If

    End Sub


    Public Sub UltimoReg()
        'Inserir ultimo registro
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer
        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select max(Id) from EstoqueTranf"
            .CommandType = CommandType.Text
        End With
        Try
            Cnn.Open()
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    'Achou o iten procurado o iten as caixas serão preenchida
                    Ult = DataReader.Item(0)
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

        Me.Id.Text = Ult + 1
        'fim inserir ultimo registro

    End Sub


    Private Sub Usuario_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Usuario.Enter
        If Me.Usuario.Text = "" Then
            Me.Usuario.Text = UserAtivo
        End If
    End Sub

    Private Sub DataLancamento_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataLancamento.Enter
        Me.DataLancamento.Text = DataDia
    End Sub
End Class