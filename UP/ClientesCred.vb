Public Class ClientesCred

    Dim Acao As New TrfGerais
    Dim cred As New cCreditoCliente
  
    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        'Area destinada para as validacoes
        If Me.Cliente.Text = "" Then
            MsgBox("O Código do Cliente não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Cliente.Focus()
            Exit Sub
        ElseIf Me.DescCred.Text = "" Then
            MsgBox("Não foi informada nenhuma descrição para o lançamento, favor verificar.", 64, "Validação de Dados")
            Me.DescCred.Focus()
            Exit Sub
        ElseIf Me.DataCred.Text = "" Then
            MsgBox("Não foi informada a data de Lançamento do Crédito, favor verificar.", 64, "Validação de Dados")
            Me.DataCred.Focus()
            Exit Sub

        ElseIf Me.VencimentoCred.Text = "" Then
            MsgBox("Não foi informada o vencimento do Crédito, favor verificar.", 64, "Validação de Dados")
            Me.VencimentoCred.Focus()
            Exit Sub
        ElseIf Me.ValorCred.Text = "" Then
            MsgBox("Não foi informado o valor do Crédito, favor verificar.", 64, "Validação de Dados")
            Me.VencimentoCred.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        If Me.Confirmado.Checked = True Then
            MessageBox.Show("Este crédito já foi confirmado e Salvo, favor fazer um novo lançamento.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Ativar o caixa
        If Len(CaixaAtivo) <> 4 Then
            MessageBox.Show("O usuario deve selecionar um caixa antes de Confirmar o Pedido. Verifique", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If MsgBox("Deseja Ativar o caixa agora", 36, "Validação de Dados") = 6 Then
                TRVDados(UserAtivo, "CaixaAtivarDesativar")
                If Ina = True Then
                    MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
                    Exit Sub
                Else
                    My.Forms.CaixaAtivarDesativar.ShowDialog()
                End If
            End If
        End If
        If String.IsNullOrEmpty(CaixaAtivo) Then 'se o caixa ativo for vaizo, entao sai da rotina.
            Exit Sub
        End If



        'passado os valores para a classe credito
        cred.Cliente = Me.Cliente.Text
        cred.Desc_credito = Me.DescCred.Text
        cred.Data_credito = Me.DataCred.Text
        cred.Vencimento_credito = Me.VencimentoCred.Text
        cred.Valor_credito = Me.ValorCred.Text
        cred.Confirmado = True
        cred.Codigoempresa = CodEmpresa
        cred.gravar()

        If Not cred.IsError Then 'não teve erros
            Me.Id.Text = (cred.Id)
            Acao.Desbloquear_Controle(Me, False)
        End If

        Acao.LimpaTextBox(Me)
        Me.Cliente.Focus()

    End Sub
    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        Acao.Desbloquear_Controle(Me, True)
        Acao.LimpaTextBox(Me)
        Me.Id.Text = "0000"
        Me.Confirmado.Checked = False
        Me.Inativo.Checked = False
        Me.DisplayConfirmado.Visible = False
        Me.DisplayCancelado.Visible = False
        Me.DataCred.Text = DataDia
        Me.Cliente.Focus()
    End Sub

    Private Sub ClientesCred_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Acao.Desbloquear_Controle(Me, False)
    End Sub

    Private Sub btFindClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindClientes.Click
        My.Forms.ClientesProcura.ShowDialog()
        cred.LocalizaDadosCliente(Me.Cliente.Text)
        Me.ClienteDesc.Text = cred.Nomecliente
    End Sub

   

    Public Sub LocalizaDadosCredito()
        If Me.Id.Text = "" Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT ClienteCred.Id, ClienteCred.Cliente, Clientes.Nome, ClienteCred.DescCred, ClienteCred.DataCred, ClienteCred.VencimentoCred, ClienteCred.ValorCred, ClienteCred.Empresa, ClienteCred.Confirmado, ClienteCred.Inativo FROM Clientes INNER JOIN ClienteCred ON Clientes.Codigo = ClienteCred.Cliente WHERE (((ClienteCred.Id)=" & Me.Id.Text & "));"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()


        If DR.HasRows Then
            Me.Cliente.Text = DR.Item("Cliente") & ""
            Me.ClienteDesc.Text = DR.Item("Nome") & ""
            Me.DescCred.Text = DR.Item("DescCred") & ""
            Me.DataCred.Text = DR.Item("DataCred") & ""
            Me.VencimentoCred.Text = DR.Item("VencimentoCred") & ""
            Me.ValorCred.Text = FormatNumber(DR.Item("ValorCred"), 2)
            Me.Confirmado.Checked = DR.Item("Confirmado")
            Me.Inativo.Checked = DR.Item("Inativo")
        End If

        If Me.Confirmado.Checked = True Then
            Me.DisplayConfirmado.Visible = True
        End If

        If Me.Inativo.Checked = True Then
            Me.DisplayCancelado.Visible = True
        End If

        DR.Close()

    End Sub

    Private Sub Cliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cliente.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ClientesProcura.ShowDialog()
            cred.LocalizaDadosCliente(Me.Cliente.Text)
            Me.ClienteDesc.Text = cred.Nomecliente
        End If
    End Sub

    Private Sub Cliente_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cliente.Leave
        If String.CompareOrdinal(Me.Cliente.Text, Me.Cliente.TextoAntigo) Then
            cred.LocalizaDadosCliente(Me.Cliente.Text)
            Me.ClienteDesc.Text = cred.Nomecliente
        End If
    End Sub

    Private Sub btLocalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLocalizar.Click
        My.Forms.ClientesCredProcura.ShowDialog()
        LocalizaDadosCredito()

        If Me.Confirmado.Checked = True Then
            Acao.Desbloquear_Controle(Me, False)
        End If
    End Sub

    Private Sub VencimentoCred_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VencimentoCred.Enter
        If Me.VencimentoCred.Text = "" Then
            Me.VencimentoCred.Text = DataDia.AddDays(365)
        End If
    End Sub

    Private Sub Cliente_Validated(sender As Object, e As EventArgs) Handles Cliente.Validated
        If String.IsNullOrEmpty(Me.Cliente.Text) Then
            Me.ClienteDesc.Clear()
        End If
    End Sub
End Class