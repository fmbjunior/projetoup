Public Class Receber
    Dim Ação As New TrfGerais()

    Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
    Dim Doc As String = ""
    Dim strVirtual As String = String.Empty
    Dim DsProcura As DataSet

    Dim Autorizado As Boolean

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Cnn.Close()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Cliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.Cliente.Text = "" Then
                RetornoProcura = ""
                My.Forms.ReceberCliProcura.ShowDialog()
                If Me.Cliente.Text <> "" Then
                    Ação.Descrição_ItenRegistro(Me.Cliente, Me.ClienteDesc, "Clientes", "Codigo", Me.Cliente.Text, "Nome", TrfGerais.TipoDados.Numérico, True)

                    EncheGrid()
                End If
            End If
        End If


        If e.KeyCode = Keys.F5 Then
            Me.Cliente.Clear()
            Me.ClienteDesc.Clear()

            My.Forms.ReceberCliProcura.ShowDialog()
            If Me.Cliente.Text <> "" Then
                Ação.Descrição_ItenRegistro(Me.Cliente, Me.ClienteDesc, "Clientes", "Codigo", Me.Cliente.Text, "Nome", TrfGerais.TipoDados.Numérico, True)

                EncheGrid()
            End If
        End If
    End Sub

    Private Sub Cliente_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cliente.Leave
        If NzZero(Me.Cliente.Text) <> 0 Then
            LocalizaDadosCliente()
            EncheGrid()
        End If
    End Sub
    Public Sub LocalizaDadosCliente()
        If Me.Cliente.Text = "" Then
            Exit Sub
        End If
        'String para filtragem de clientes na base de dados
        Dim Sql As String = "SELECT * From Clientes WHERE Codigo = " & Me.Cliente.Text

        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.ClienteDesc.Text = DR.Item("Nome") & ""
        End If
        DR.Close()

    End Sub
    'Faz a população do data gridview
    Sub EncheGrid()
        Dim i As Integer = 0
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty
        Cnn.Open()
        DsProcura = New DataSet

        Sql = "SELECT id,documento,notafiscal,controlepedido,cliente,datadocumento,vencimento,valordocumento,prorrogada,virtual,ContaPerdida,Origem, IdAgrupamento FROM Receber WHERE CodCliente = " & Me.Cliente.Text & " and Baixado = False and Empresa = " & CodEmpresa & " and Inativo = False and CartaoCredito = False order by Vencimento"
        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)

        da.Fill(DsProcura, "Receber")

        dgvItem.DataSource = DsProcura.Tables("Receber")

        da.Dispose()
        DsProcura.Dispose()
        Cnn.Close()
        ObtemSomaColunas()

        For Each Linha As DataGridViewRow In Me.dgvItem.Rows
            Dim chk As Boolean = Linha.Cells("g_perdida").Value
            If chk = True Then
                Linha.DefaultCellStyle.BackColor = Color.Yellow
            Else
                If Linha.Cells("g_vencimento").Value < CDate(DataDia) Then
                    Linha.DefaultCellStyle.BackColor = Color.Red
                End If
            End If
        Next
        dgvItem.ClearSelection()

    End Sub
    'ROTINA PARA OBTER A SOMA DE UMA DETERMINADA COLUNA
    Sub ObtemSomaColunas()
        Dim SomaColuna As Double
        Try

            'Se o valor for nulo...
            If DsProcura.Tables(0).Compute("SUM(valordocumento)", "") Is DBNull.Value Then

                SomaColuna = "0"

            Else

                'Utilizo o compute para somar os valores da coluna...

                SomaColuna = DsProcura.Tables(0).Compute("SUM(valordocumento)", "")

            End If
            Total.Text = String.Format("{0:R$ #,##0.00}", SomaColuna)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Receber_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.Open()
    End Sub


    Private Sub MostrarContasProToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarContasProToolStripMenuItem.Click

        'MOSTRA AS CONTAS PRORROGADAS NO DIA ATUAL.

        Me.Cliente.Clear()
        Me.ClienteDesc.Clear()

        '   .CommandText = "SELECT * FROM Receber WHERE Vencimento <= #" & DataDia & "# and Baixado = False and Empresa = " & CodEmpresa & " and Inativo = False and Prorrogada = True order by Vencimento"


        Dim i As Integer = 0
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty
        Cnn.Open()
        DsProcura = New DataSet

        Sql = "SELECT id,documento,notafiscal,controlepedido,cliente,datadocumento,vencimento,valordocumento,prorrogada,virtual,ContaPerdida,Origem,IdAgrupamento FROM Receber WHERE Vencimento <= #" & DataDia & "#  and Baixado = False and Empresa = " & CodEmpresa & " and Inativo = False  and prorrogada=true and CartaoCredito = false order by Vencimento"
        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)

        da.Fill(DsProcura, "Receber")

        dgvItem.DataSource = DsProcura.Tables("Receber")

        da.Dispose()
        DsProcura.Dispose()
        Cnn.Close()
        ObtemSomaColunas()

        For Each Linha As DataGridViewRow In Me.dgvItem.Rows
            Dim chk As Boolean = Linha.Cells("g_perdida").Value
            If chk = True Then
                Linha.DefaultCellStyle.BackColor = Color.Yellow
            Else
                If Linha.Cells("g_vencimento").Value < CDate(DataDia) Then
                    Linha.DefaultCellStyle.BackColor = Color.Red
                End If
            End If
        Next
        dgvItem.ClearSelection()
        Try

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Exit Sub
        End Try

    End Sub
    Private Sub ColoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColoToolStripMenuItem.Click

        Doc = dgvItem.CurrentRow.Cells("g_documento").Value 'pega o valor do coluna documento
        strVirtual = dgvItem.CurrentRow.Cells("g_virtual").Value 'pega o valor da coluna virtual


        If Me.IdSelecionado.Text = "" Then 'está vazio a caixa de texto
            Exit Sub ' então finalize
        End If

        If strVirtual = "Sim" Then 'o valor e true
            'mostra a mensagem
            MessageBox.Show("Esta conta esta como Virtual não pode ser adicionada ocorrência.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub 'sai da rotina
        Else
            'senão execute os codigo abaixo
            Me.PainelOcorrencia.Visible = True
            Me.Ocorrencia.Focus()
        End If
    End Sub

    Private Sub BtCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelar.Click
        'faz o tratamento para os campos de OCORRENCIAS
        Me.Ocorrencia.Clear()
        Me.Cliente.Focus()
        Me.PainelOcorrencia.Visible = False
    End Sub

    Private Sub BtAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        'USADO PARA ADICIONARA AS OCRRENCIAS.
        Dim IdSequencia As Integer = UltimoReg()
        Dim Sql As String = "INSERT INTO ClientesCR (Id, Cliente, DataOcorrencia, Ocorrencia, IdProcura, Prg, Documento) VALUES (@1, @2, @3, @4, @5, @6, @7)"
        Dim cmd As New OleDb.OleDbCommand(Sql, Cnn)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(IdSequencia, 3)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Cliente.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@3", DataDia))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Me.Ocorrencia.Text))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.IdSelecionado.Text, 3)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz("Receber", 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Doc, 1)))


        cmd.ExecuteNonQuery()
        EncheGrid()
        MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
        Me.Ocorrencia.Clear()
        Me.Cliente.Focus()
        Me.PainelOcorrencia.Visible = False
    End Sub


    Public Function UltimoReg() As Integer
        'Inserir ultimo registro

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer
        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select max(Id) from ClientesCR"
            .CommandType = CommandType.Text
        End With
        Try
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
                Exit Function
            End If
        End Try

        Return Ult + 1

    End Function

    Private Sub btOcorrencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOcorrencia.Click
        If Me.Cliente.Text = "" Then
            Exit Sub
        End If
        RetornoProcura = Me.Cliente.Text
        My.Forms.ClienteCr.ShowDialog()
    End Sub

    Private Sub btFindClintes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindClintes.Click
        Me.Cliente.Text = ""
        If Me.Cliente.Text = "" Then
            RetornoProcura = ""
            My.Forms.ReceberCliProcura.ShowDialog()
            If Me.Cliente.Text <> "" Then
                Ação.Descrição_ItenRegistro(Me.Cliente, Me.ClienteDesc, "Clientes", "Codigo", Me.Cliente.Text, "Nome", TrfGerais.TipoDados.Numérico, True)
                EncheGrid()
            End If
        End If
    End Sub

    Private Sub dgvItem_Sorted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvItem.Sorted

        For Each Linha As DataGridViewRow In Me.dgvItem.Rows
            If Linha.Cells("g_vencimento").Value < CDate(DataDia) Then
                Linha.DefaultCellStyle.BackColor = Color.Red
            End If
        Next
    End Sub

   
    Private Sub AtivaEDesativarComoContaPerdiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtivaEDesativarComoContaPerdiaToolStripMenuItem.Click

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()
        Dim SqlPagar As String = "Update Receber set ContaPerdida = @1 Where Id = " & Me.IdSelecionado.Text
        Dim CmdPagar As New OleDb.OleDbCommand(SqlPagar, CNN)

        If dgvItem.CurrentRow.Cells("g_perdida").Value = True Then
            CmdPagar.Parameters.Add(New OleDb.OleDbParameter("@1", False))
            dgvItem.CurrentRow.DefaultCellStyle.BackColor = Color.White
        Else
            CmdPagar.Parameters.Add(New OleDb.OleDbParameter("@1", True))
            dgvItem.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow
        End If

        Try
            CmdPagar.ExecuteNonQuery()
            CNN.Close()
            EncheGrid()
        Catch Ex As Exception
            MsgBox("Erro de Atualização: Ao marcar a conta como perdida.", 64, "Validação de Dados")
            Exit Sub
        End Try
      
    End Sub

    Private Sub dgvItem_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvItem.CellClick
        Me.IdSelecionado.Text = dgvItem.CurrentRow.Cells("g_id").Value
        strVirtual = dgvItem.CurrentRow.Cells("g_virtual").Value
    End Sub


    Private Sub dgvItem_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvItem.SelectionChanged
        Try
            Me.IdSelecionado.Text = dgvItem.CurrentRow.Cells("g_id").Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvItem_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvItem.CellDoubleClick

        Dim cxFechado As New CaixaFechado
        cxFechado.CaixaEstaFechado()


        Dim I As Integer = 0

        If strVirtual = True Then
            MessageBox.Show("Esta conta esta como Virtual não pode ser Baixada", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Len(CaixaAtivo) <> 4 Then
            MessageBox.Show("O usuário deve selecionar um caixa antes de baixar o documento", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If MsgBox("Deseja Ativar o caixa agora", 36, "Validação de Dados") = 6 Then
                TRVDados(UserAtivo, "CaixaAtivarDesativar")
                If Ina = True Then
                    MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
                    Exit Sub
                Else
                    My.Forms.CaixaAtivarDesativar.ShowDialog()
                    dgvItem_CellDoubleClick(sender, e)
                End If
            End If
            Exit Sub
        End If

        My.Forms.ReceberBaixa.AchaRegistro(Me.IdSelecionado.Text)
        My.Forms.ReceberBaixa.ShowDialog()
        EncheGrid()
    End Sub

    Private Sub ExcluirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirToolStripMenuItem.Click

        If Me.IdSelecionado.Text = "" Then Exit Sub

        Autorizado = PedirPermissao(Me.Text, Me.IdSelecionado.Text)
        Autorizado = varAutorizado
        If Autorizado = False Then
            Exit Sub
        End If

        If MessageBox.Show("Deseja realmente excluir o recebimento avulso selecionado.", "Validação de Dados", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim ds As New DataSet
            Dim Sql As String = String.Empty

            Sql = "Select * from Receber Where Id = " & Me.IdSelecionado.Text
            Dim DAReceber As New OleDb.OleDbDataAdapter(Sql, CNN)
            DAReceber.Fill(ds, "Receber")

            Try
                If ds.Tables("Receber").Rows.Count = 1 Then

                    Dim Verificar As String = Mid(ds.Tables("Receber").Rows(0)("Documento"), 1, 2)
                    If Verificar = "AV" Then
                        ds.Tables("Receber").Rows(0).Delete()
                    Else
                        MessageBox.Show("Este Recebimento não é um recebimento avulso, não pode ser excluido", "Validação de Dados", MessageBoxButtons.OK)
                        ds.Dispose()
                        CNN.Close()
                        Exit Sub
                    End If

                End If

                Dim objBuilder As New OleDb.OleDbCommandBuilder(DAReceber)
                DAReceber.Update(ds, "Receber")
                MessageBox.Show("Registro Excluido com sucesso", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CNN.Close()
                EncheGrid()

            Catch ex As Exception
                MsgBox(ex.Message)
                CNN.Close()
                Exit Sub
            End Try

        End If


    End Sub

    Private Sub ProrrogarContaSelecionadaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProrrogarContaSelecionadaToolStripMenuItem.Click
        'CONTROLA A PRORROGAÇÃO DA CONTA - COMANDO PARA PRORROGAR

        strVirtual = dgvItem.CurrentRow.Cells("g_virtual").Value

        If Me.IdSelecionado.Text = "" Then
            Exit Sub
        End If

        If strVirtual = "Sim" Then
            MessageBox.Show("Esta conta esta como Virtual não pode ser prorrogada", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        TRVDados(UserAtivo, "ReceberProrrogação")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ReceberProrrogação.ShowDialog()
        End If
    End Sub

    Private Sub AlterarLocalDePagamentoDaContaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlterarLocalDePagamentoDaContaToolStripMenuItem.Click
        TRVDados(UserAtivo, "ReceberAlterarLocalPagamento")

        Autorizado = PedirPermissao(Me.Text, Me.IdSelecionado.Text)
        Autorizado = varAutorizado
        If Autorizado = False Then
            Exit Sub
        End If

        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ReceberAlterar.CampoAtivar = My.Forms.ReceberAlterar.LocalPgto
            My.Forms.ReceberAlterar.AchaRegistro(Me.IdSelecionado.Text)
            My.Forms.ReceberAlterar.ShowDialog()
            EncheGrid()
        End If
    End Sub

    Private Sub AlterarDataDeVencimentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlterarDataDeVencimentoToolStripMenuItem.Click
        TRVDados(UserAtivo, "ReceberAlterarVencimento")

        Autorizado = PedirPermissao(Me.Text, Me.IdSelecionado.Text)
        Autorizado = varAutorizado
        If Autorizado = False Then
            Exit Sub
        End If

        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else
            My.Forms.ReceberAlterar.CampoAtivar = My.Forms.ReceberAlterar.Vencimento
            My.Forms.ReceberAlterar.AchaRegistro(Me.IdSelecionado.Text)
            My.Forms.ReceberAlterar.ShowDialog()
            EncheGrid()
        End If
    End Sub

    Private Sub VisualizarVinculoDeAgrupamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarVinculoDeAgrupamentoToolStripMenuItem.Click

        Dim cDoc As String = dgvItem.CurrentRow.Cells("g_documento").Value 'pega o valor do coluna documento
        Dim cId As Integer = dgvItem.CurrentRow.Cells("g_id").Value
        Dim cIdAG As Integer = NzZero(dgvItem.CurrentRow.Cells("cIdAgrupamento").Value)

        If cDoc.ToString.IndexOf("AG") <> -1 Then
            My.Forms.ReceberAgrupar.Visualizador = True
            My.Forms.ReceberAgrupar.IDVisualizador = cIdAG
            My.Forms.ReceberAgrupar.ShowDialog()
        Else
            MessageBox.Show("O documento selecionado não contem agrupamento de contas", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class