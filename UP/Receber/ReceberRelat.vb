Public Class ReceberRelat
    Dim Ação As New TrfGerais


    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged, A4.CheckedChanged, A5.CheckedChanged, A6.CheckedChanged, A7.CheckedChanged, A8.CheckedChanged, A9.CheckedChanged, A10.CheckedChanged, A11.CheckedChanged, A12.CheckedChanged, A13.CheckedChanged, A14.CheckedChanged, A20.CheckedChanged, A21.CheckedChanged
        If Me.A1.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelCliente.Visible = False
            Me.PainelLocal.Visible = False
            Me.PainelCidade.Visible = False
            Me.PanelJuros.Visible = False
            Me.PainelRegiao.Visible = False
            Me.PainelMulta.Visible = False
            Me.PainelVendedor.Visible = False
            Me.DataInicial.Focus()
        End If
        If Me.A2.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelCliente.Visible = True
            Me.PainelLocal.Visible = False
            Me.PainelCidade.Visible = False
            Me.PanelJuros.Visible = False
            Me.PainelRegiao.Visible = False
            Me.PainelMulta.Visible = False
            Me.PainelVendedor.Visible = False
            Me.DataInicial.Focus()
        End If
        If Me.A3.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelCliente.Visible = False
            Me.PainelLocal.Visible = True
            Me.PainelCidade.Visible = False
            Me.PanelJuros.Visible = False
            Me.PainelRegiao.Visible = False
            Me.PainelMulta.Visible = False
            Me.PainelVendedor.Visible = False
            Me.DataInicial.Focus()
        End If
        If Me.A4.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelCliente.Visible = False
            Me.PainelLocal.Visible = False
            Me.PainelCidade.Visible = True
            Me.PanelJuros.Visible = False
            Me.PainelRegiao.Visible = False
            Me.PainelMulta.Visible = False
            Me.PainelVendedor.Visible = False
            Me.DataInicial.Focus()
        End If

        If Me.A5.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelCliente.Visible = False
            Me.PainelLocal.Visible = False
            Me.PainelCidade.Visible = False
            Me.PanelJuros.Visible = False
            Me.PainelRegiao.Visible = False
            Me.PainelMulta.Visible = False
            Me.PainelVendedor.Visible = False
            Me.DataInicial.Focus()
        End If

        If Me.A6.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelCliente.Visible = True
            Me.PainelLocal.Visible = False
            Me.PainelCidade.Visible = False
            Me.PanelJuros.Visible = True
            Me.PainelRegiao.Visible = False
            Me.PainelMulta.Visible = False
            Me.PainelVendedor.Visible = False
            Me.DataInicial.Focus()
        End If

        If Me.A7.Checked = True Then
            Me.PainelPeriodo.Visible = False
            Me.PainelCliente.Visible = True
            Me.PainelLocal.Visible = False
            Me.PainelCidade.Visible = False
            Me.PanelJuros.Visible = False
            Me.PainelRegiao.Visible = False
            Me.PainelMulta.Visible = False
            Me.PainelVendedor.Visible = False
            Me.PanelJuros.Location = New System.Drawing.Point(12, 237)
            Me.Cliente.Focus()
        End If

        If Me.A8.Checked = True Then
            Me.PainelPeriodo.Visible = False
            Me.PainelCliente.Visible = False
            Me.PainelLocal.Visible = False
            Me.PainelCidade.Visible = False
            Me.PanelJuros.Visible = False
            Me.PainelRegiao.Visible = False
            Me.PainelMulta.Visible = False
            Me.PainelVendedor.Visible = False
            Me.PanelJuros.Location = New System.Drawing.Point(12, 237)
        End If

        If Me.A9.Checked = True Then
            Me.PainelPeriodo.Visible = False
            Me.PainelCliente.Visible = False
            Me.PainelLocal.Visible = False
            Me.PainelCidade.Visible = False
            Me.PanelJuros.Visible = False
            Me.PainelRegiao.Visible = False
            Me.PainelMulta.Visible = False
            Me.PainelVendedor.Visible = False
            Me.PanelJuros.Location = New System.Drawing.Point(12, 237)
        End If

        If Me.A10.Checked = True Then
            Me.PainelPeriodo.Visible = False
            Me.PainelCliente.Visible = True
            Me.PainelLocal.Visible = False
            Me.PainelCidade.Visible = False
            Me.PanelJuros.Visible = False
            Me.PainelRegiao.Visible = False
            Me.PainelMulta.Visible = False
            Me.PainelVendedor.Visible = False
            Me.PanelJuros.Location = New System.Drawing.Point(12, 237)
            Me.Cliente.Focus()
        End If

        If Me.A11.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelCliente.Visible = False
            Me.PainelLocal.Visible = False
            Me.PainelCidade.Visible = False
            Me.PanelJuros.Visible = False
            Me.PainelRegiao.Visible = False
            Me.PainelMulta.Visible = False
            Me.PainelVendedor.Visible = False
            Me.DataInicial.Focus()
        End If

        If Me.A12.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelCliente.Visible = False
            Me.PainelLocal.Visible = False
            Me.PainelCidade.Visible = False
            Me.PanelJuros.Visible = False
            Me.PainelRegiao.Visible = True
            Me.PainelMulta.Visible = False
            Me.PainelVendedor.Visible = False
            Me.DataInicial.Focus()
        End If

        If Me.A13.Checked = True Then
            Me.PainelPeriodo.Visible = False
            Me.PainelCliente.Visible = False
            Me.PainelLocal.Visible = False
            Me.PainelCidade.Visible = False
            Me.PanelJuros.Visible = True
            Me.PainelRegiao.Visible = True
            Me.PainelMulta.Visible = True
            Me.PainelVendedor.Visible = False
            Me.Juros.Focus()
        End If

        If Me.A14.Checked = True Then
            Me.PainelPeriodo.Visible = False
            Me.PainelCliente.Visible = False
            Me.PainelLocal.Visible = False
            Me.PainelCidade.Visible = False
            Me.PanelJuros.Visible = True
            Me.PainelRegiao.Visible = False
            Me.PainelMulta.Visible = True
            Me.PainelVendedor.Visible = True
            Me.Juros.Focus()
        End If

        If Me.A20.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelCliente.Visible = False
            Me.PainelLocal.Visible = False
            Me.PainelCidade.Visible = False
            Me.PanelJuros.Visible = False
            Me.PainelRegiao.Visible = False
            Me.PainelMulta.Visible = False
            Me.PainelVendedor.Visible = False
            Me.DataInicial.Focus()
        End If
        If Me.A21.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelCliente.Visible = True
            Me.PainelLocal.Visible = False
            Me.PainelCidade.Visible = False
            Me.PanelJuros.Visible = False
            Me.PainelRegiao.Visible = False
            Me.PainelMulta.Visible = False
            Me.PainelVendedor.Visible = False
            Me.DataInicial.Focus()
        End If

    End Sub

    Private Sub Visualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Visualizar.Click

        If Me.A1.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usuário deve informar a data inicial para o relatório.", 64, "Validação de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usuário deve informar a data Final para o relatório.", 64, "Validação de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelReceberPeriodo"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A2.Checked = True Then
            If Me.Cliente.Text = "" Then
                MsgBox("O usuário deve informar o cliente para o relatório.", 64, "Validação de Dados")
                Me.Cliente.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelReceberCliente"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A3.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usuário deve informar a data inicial para o relatório.", 64, "Validação de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usuário deve informar a data Final para o relatório.", 64, "Validação de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            ElseIf Me.Local.Text = "" Then
                MsgBox("O usuário deve informar o local de pagamento para o relatório.", 64, "Validação de Dados")
                Me.Local.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelReceberLocal"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A4.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usuário deve informar a data inicial para o relatório.", 64, "Validação de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usuário deve informar a data Final para o relatório.", 64, "Validação de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            ElseIf Me.Cidade.Text = "" Then
                MsgBox("O usuário deve informar a Cidade para o relatório.", 64, "Validação de Dados")
                Me.Cidade.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelReceberCidade"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A5.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usuário deve informar a data inicial para o relatório.", 64, "Validação de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usuário deve informar a data Final para o relatório.", 64, "Validação de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelReceberPerdida"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A6.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usuário deve informar a data inicial para o relatório.", 64, "Validação de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usuário deve informar a data Final para o relatório.", 64, "Validação de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            ElseIf Me.Juros.Text = "" Then
                MsgBox("O usuário deve informar o percentual de Juros.", 64, "Validação de Dados")
                Me.Juros.Focus()
                Exit Sub
            ElseIf Me.Cliente.Text = "" Then
                MsgBox("O usuário deve informar o Cliente", 64, "Validação de Dados")
                Me.Cliente.Focus()
                Exit Sub
            End If


            RelatorioCarregar = "RelReceberJurosCalculado"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A7.Checked = True Then
            If Me.Cliente.Text = "" Then
                MsgBox("O usuário deve informar o cliente para o relatório.", 64, "Validação de Dados")
                Me.Cliente.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelReceberVencidasCliente"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A8.Checked = True Then
            RelatorioCarregar = "RelReceberVencidasGeral"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A9.Checked = True Then
            RelatorioCarregar = "RelReceberProrrogadasGeral"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A10.Checked = True Then
            If Me.Cliente.Text = "" Then
                MsgBox("O usuário deve informar o cliente para o relatório.", 64, "Validação de Dados")
                Me.Cliente.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelHistoricoClientePedidoReceber"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A11.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usuário deve informar a data inicial para o relatório.", 64, "Validação de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usuário deve informar a data Final para o relatório.", 64, "Validação de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelReceberClienteAgrupado"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A12.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usuário deve informar a data inicial para o relatório.", 64, "Validação de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usuário deve informar a data Final para o relatório.", 64, "Validação de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            If Me.Regiao.Text = "" Then
                MsgBox("O usuário deve informar a Região.", 64, "Validação de Dados")
                Me.Regiao.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelReceberPeriodoRegiao"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If


        If Me.A13.Checked = True Then
            
            If Me.Juros.Text = "" Then
                MsgBox("O usuário deve informar o percentual de Juros.", 64, "Validação de Dados")
                Me.Juros.Focus()
                Exit Sub
            ElseIf Me.Multa.Text = "" Then
                MsgBox("O usuário deve informar a Multa", 64, "Validação de Dados")
                Me.Regiao.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelReceberEmAbertoRegiao"
            My.Forms.VisualizadorRelatorio.ShowDialog()

        End If

        If Me.A14.Checked = True Then

            If Me.Juros.Text = "" Then
                MsgBox("O usuário deve informar o percentual de Juros.", 64, "Validação de Dados")
                Me.Juros.Focus()
                Exit Sub
            ElseIf Me.Multa.Text = "" Then
                MsgBox("O usuário deve informar a Multa", 64, "Validação de Dados")
                Me.Vendedor.Focus()
                Exit Sub

            ElseIf Me.Vendedor.Text = "" Then
                MsgBox("O usuário deve informar a vendedor", 64, "Validação de Dados")
                Me.Vendedor.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelReceberEmAbertoVendedor"
            My.Forms.VisualizadorRelatorio.ShowDialog()

        End If




        If Me.A20.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usuário deve informar a data inicial para o relatório.", 64, "Validação de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usuário deve informar a data Final para o relatório.", 64, "Validação de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelRecebidaPeriodo"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

        If Me.A21.Checked = True Then
            If Me.Cliente.Text = "" Then
                MsgBox("O usuário deve informar o cliente para o relatório.", 64, "Validação de Dados")
                Me.Cliente.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelRecebidaCliente"
            My.Forms.VisualizadorRelatorio.ShowDialog()
        End If

    End Sub

    Private Sub Cliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cliente.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ClientesProcura.ShowDialog()
        End If
    End Sub

    Private Sub Cliente_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cliente.Leave
        If String.CompareOrdinal(Me.Cliente.Text, Me.Cliente.TextoAntigo) Then
            LocalizaDadosCliente()
        End If
    End Sub

    Public Sub LocalizaDadosCliente()

        If Me.Cliente.Text = "" Then
            Exit Sub
        End If
        'String para filtragem de clientes na base de dados
        Dim Sql As String = "SELECT * FROM Clientes  WHERE Clientes.Empresa =" & CodEmpresa & " AND Clientes.Codigo = " & Me.Cliente.Text

        Dim DBOPEN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        DBOPEN.Open()

        Dim CMD As New OleDb.OleDbCommand(Sql, DBOPEN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.ClienteDesc.Text = DR.Item("Nome") & ""
        End If
        DR.Close()
        DBOPEN.Close()

    End Sub



    Public Sub AddEditaParametros()

        Dim DBOPEN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        DBOPEN.Open()
        Dim Sql As String = "Select * from Parametros where Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, DBOPEN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()


        If DR.HasRows Then

            Dim SqlEdição As String = "Update Parametros set Juros = @1 Where Empresa = " & CodEmpresa
            CMD = New OleDb.OleDbCommand(SqlEdição, DBOPEN)

            CMD.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Juros.Text, 1)))

            Try
                CMD.ExecuteNonQuery()
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try


        Else

            Dim SqlAdição As String = "INSERT INTO Parametros (Empresa, Juros) VALUES (@1, @2)"
            CMD = New OleDb.OleDbCommand(SqlAdição, DBOPEN)

            CMD.Parameters.Add(New OleDb.OleDbParameter("@1", CodEmpresa))
            CMD.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Juros.Text, 1)))
            Try
                CMD.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try

        End If

        DR.Close()
        DBOPEN.Close()
    End Sub

   
    Private Sub ReceberRelat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregaComboBoxLocal()
        CarregaComboBoxRegiao()
        CarregaComboBoxVendedor()
    End Sub

    Private Sub CarregaComboBoxVendedor()

        Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()
        Dim DS As New DataSet()

        Dim Sql As String = "Select * From Funcionários Where Empresa = " & CodEmpresa & " and AdicionarEmVendas = true"
        Dim daVendedor As OleDb.OleDbDataAdapter

        daVendedor = New OleDb.OleDbDataAdapter(Sql, Cnn)
        daVendedor.Fill(DS, "Vendedor")

        Me.Vendedor.DataSource = DS.Tables("Vendedor")
        Me.Vendedor.ValueMember = "CódigoFuncionário"
        Me.Vendedor.DisplayMember = "Nome"
        Cnn.Close()

    End Sub


    Private Sub CarregaComboBoxLocal()

        Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()
        Dim DS As New DataSet()

        Dim Sql As String = "Select * From LocalPagamento Where Empresa = " & CodEmpresa
        Dim daLocalPgto As OleDb.OleDbDataAdapter

        daLocalPgto = New OleDb.OleDbDataAdapter(Sql, Cnn)
        daLocalPgto.Fill(DS, "LocalPgto")

        Me.Local.DataSource = DS.Tables("LocalPgto")
        Me.Local.ValueMember = "LocalPgto"
        Me.Local.DisplayMember = "LocalPgto"
        Cnn.Close()

    End Sub

    Private Sub CarregaComboBoxRegiao()

        Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()
        Dim DS As New DataSet()

        Dim Sql As String = "Select * From Regiao"
        Dim daLocalPgto As OleDb.OleDbDataAdapter

        daLocalPgto = New OleDb.OleDbDataAdapter(Sql, Cnn)
        daLocalPgto.Fill(DS, "Regiao")

        Me.Regiao.DataSource = DS.Tables("Regiao")
        Me.Regiao.ValueMember = "IdRegiao"
        Me.Regiao.DisplayMember = "RegiaoDesc"
        Me.Regiao.SelectedIndex = -1
        Cnn.Close()

    End Sub

    Private Sub btFindClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindClientes.Click
        My.Forms.ClientesProcura.ShowDialog()
        Me.Cliente.Focus()
    End Sub
End Class