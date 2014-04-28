Public Class Producao

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2
    Const VAZ As Byte = 5

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Producao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ação.Desbloquear_Controle(Me, False)
        Operation = VAZ
    End Sub

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)
        Me.Confirmado.Checked = False
        Me.OrdemProducao.Enabled = False
        Me.OrdemProducao.Text = "0000"
        Me.DataOrdem.Text = DataDia
        Me.DataOrdem.Focus()
        Operation = INS
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        'Area destinada para as validacoes
        If Me.DataOrdem.Text = "" Then
            MsgBox("A data da Ordem  não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.DataOrdem.Focus()
            Exit Sub
        ElseIf Me.Solicitante.Text = "" Then
            MsgBox("O Solicitante da Ordem não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Solicitante.Focus()
            Exit Sub
        ElseIf Me.Motivo.Text = "" Then
            MsgBox("O Motivo da Ordem não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Motivo.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            UltimoReg()

            Dim Sql As String = "INSERT INTO Producao (OrdemProducao, DataOrdem, Solicitante, Motivo, Confirmado, GeradoEstoque, Empresa) VALUES (@1, @2, @3, @4, @5, @6, @7)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", NzZero(Me.OrdemProducao.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataOrdem.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Solicitante.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Motivo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Me.Confirmado.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.GeradoEstoque.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", CodEmpresa))

            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                Ação.Desbloquear_Controle(Me, False)
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Adicionou, Me.OrdemProducao.Text)
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try

        ElseIf Operation = UPD Then
            CNN.Open()

            Dim Sql As String = "Update Producao set DataOrdem = @1, Solicitante = @2, Motivo = @3, Confirmado = @4, GeradoEstoque = @5 Where Codigo = " & Me.OrdemProducao.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.DataOrdem.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Solicitante.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Motivo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Me.Confirmado.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Me.GeradoEstoque.Checked))

            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                Ação.Desbloquear_Controle(Me, False)
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Editou, Me.OrdemProducao.Text)
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try

        End If

    End Sub

    Public Sub UltimoReg()
        'Inserir ultimo registro
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim SQL As String = "Select max(OrdemProducao) from Producao"

        Dim Cmd As New OleDb.OleDbCommand(SQL, Cnn)
        Dim DR As OleDb.OleDbDataReader
        Dim Ult As Integer
        
        Try
            DR = Cmd.ExecuteReader
            DR.Read()

            If DR.HasRows = True Then
                Ult = NzZero(DR.Item(0))
            Else
                Ult = 0
            End If
            DR.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()

        Me.OrdemProducao.Text = Ult + 1
        Me.OrdemProducao.Refresh()
    End Sub

    Private Sub btAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddItem.Click
        If Operation = VAZ Then
            MessageBox.Show("Registro Principal não pode ser criado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Operation = INS Then
            RegistroPrincipal()
        End If

        If Me.OrdemProducao.Text = "" Or Me.OrdemProducao.Text = "0000" Then
            Exit Sub
        End If

        If Me.Confirmado.Checked = True Then
            MessageBox.Show("Esta ordem de produção ja foi confirmada, não pode ser alterada", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        My.Forms.ProducaoAddItem.ShowDialog()
    End Sub

    Private Sub RegistroPrincipal()

        If Me.DataOrdem.Text = "" Then
            MsgBox("A data da Ordem  não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.DataOrdem.Focus()
            Exit Sub
        ElseIf Me.Solicitante.Text = "" Then
            MsgBox("O Solicitante da Ordem não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Solicitante.Focus()
            Exit Sub
        ElseIf Me.Motivo.Text = "" Then
            MsgBox("O Motivo da Ordem não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Motivo.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        If Operation = INS Then

            UltimoReg()

            Dim Sql As String = "INSERT INTO Producao (OrdemProducao, DataOrdem, Solicitante, Motivo, Confirmado, GeradoEstoque, Empresa) VALUES (@1, @2, @3, @4, @5, @6, @7)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", NzZero(Me.OrdemProducao.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataOrdem.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Solicitante.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Motivo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Me.Confirmado.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.GeradoEstoque.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", CodEmpresa))

            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                Ação.Desbloquear_Controle(Me, False)
                Operation = UPD
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
        End If

    End Sub

    Private Sub btProcurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btProcurar.Click
        My.Forms.ProducaoProcura.ShowDialog()
    End Sub

    Public Sub LocalizarDados()
        If Me.OrdemProducao.Text = "" Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        
        Dim Sql As String = "Select * From Producao  where OrdemProducao = " & Me.OrdemProducao.Text
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)
        Dim Dr As OleDb.OleDbDataReader

        Dr = cmd.ExecuteReader
        Dr.Read()

        If Dr.HasRows = True Then
            Me.DataOrdem.Text = Dr.Item("DataOrdem")
            Me.Solicitante.Text = Dr.Item("Solicitante") & ""
            Me.Motivo.Text = Dr.Item("Motivo") & ""
            Me.Confirmado.Checked = Dr.Item("Confirmado")
            Me.GeradoEstoque.Checked = Dr.Item("GeradoEstoque")

            Dr.Close()
            CNN.Close()
            EncheLista()
            Operation = UPD
        Else
            Dr.Close()
            CNN.Close()
            Operation = VAZ
        End If
        

    End Sub


    Public Sub EncheLista()

        If Me.OrdemProducao.Text = "" Then
            Exit Sub
        End If

        MyLista.Items.Clear()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT ProducaoItem.Id, ProducaoItem.OrdemProducao, ProducaoItem.Produto, Produtos.Descrição, ProducaoItem.Qtd, ProducaoItem.ValorUnitarioComissao FROM ProducaoItem INNER JOIN Produtos ON ProducaoItem.Produto = Produtos.CodigoProduto WHERE ProducaoItem.OrdemProducao = " & Me.OrdemProducao.Text

        Dim Cmd As New OleDb.OleDbCommand(Sql, Cnn)
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


    Private Sub Motivo_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Motivo.Validated
        If Operation = INS Then
            btSalvar_Click(sender, e)
        End If
    End Sub

    Private Sub btConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConfirmar.Click

        'Area destinada para as validacoes
        If Me.DataOrdem.Text = "" Then
            MsgBox("A data da Ordem  não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.DataOrdem.Focus()
            Exit Sub
        ElseIf Me.Solicitante.Text = "" Then
            MsgBox("O Solicitante da Ordem não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Solicitante.Focus()
            Exit Sub
        ElseIf Me.Motivo.Text = "" Then
            MsgBox("O Motivo da Ordem não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Motivo.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        CNN.Open()

        Dim Sql As String = "Update Producao set DataOrdem = @1, Solicitante = @2, Motivo = @3, Confirmado = @4, GeradoEstoque = @5 Where OrdemProducao = " & Me.OrdemProducao.Text
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        Me.Confirmado.Checked = True

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.DataOrdem.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Solicitante.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Motivo.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Me.Confirmado.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Me.GeradoEstoque.Checked))

        Try
            cmd.ExecuteNonQuery()
            CNN.Close()
            Ação.Desbloquear_Controle(Me, False)

            RelatorioCarregar = "RelOrdemProducao"
            My.Forms.VisualizadorRelatorio.ShowDialog()

            MsgBox("Ordem de Produção Confirmada com sucesso", 64, "Validação de Dados")
            GerarLog(Me.Text, AçãoTP.Confirmou, Me.OrdemProducao.Text)
        Catch x As Exception
            MsgBox(x.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImprimir.Click
        If Me.Confirmado.Checked = False Then
            MessageBox.Show("Esta ordem de Produção não foi confirmada, não pode imprimir.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        RelatorioCarregar = "RelOrdemProducao"
        My.Forms.VisualizadorRelatorio.ShowDialog()

    End Sub

    Private Sub ExcluirItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirItemToolStripMenuItem.Click

        If Me.Confirmado.Checked = True Then
            MessageBox.Show("Esta ordem de Produção já foi confirmada, não pode ser Modificada.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If MsgBox("Deseja realmente excluir o item da Lista", 36, "Validação de Dados") = 6 Then

            Dim I As Integer = 0
            Dim Item As String = String.Empty

            For I = 0 To MyLista.Items.Count - 1
                If MyLista.Items(I).Selected = True Then Item = MyLista.Items(I).Text.Substring(0)
            Next


            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
            Dim Cmd As OleDb.OleDbCommand = CNN.CreateCommand
            Dim CmdProducao As OleDb.OleDbCommand = CNN.CreateCommand

            Cmd.Transaction = Transacao
            CmdProducao.Transaction = Transacao

            Try

                Dim Sql As String = "Delete * From ProducaoItem Where Id = " & Item
                Cmd.CommandText = Sql
                Cmd.ExecuteNonQuery()

                Sql = "Delete * From ProducaoItemSub Where IdItem = " & Item
                CmdProducao.CommandText = Sql
                CmdProducao.ExecuteNonQuery()

                Transacao.Commit()

                CNN.Close()
                EncheLista()
                MsgBox("Registro Excluido com sucesso", 64, "Validação de Dados")

            Catch ex As Exception
                Transacao.Rollback()
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try

        End If


    End Sub
End Class