Imports System.Data.OleDb
Public Class SellShoesClientesProcura

    Dim Ds As New DataSet
    Dim bs As BindingSource

    Private Sub TxtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProcura.Leave
        If Me.TxtProcura.Text = "" Then
            Exit Sub
        End If

        Me.Lista.Focus()

    End Sub


    Private Sub CarregaTodosClientes()
        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty


        Sql = "SELECT Clientes.Codigo, Clientes.Nome, [Endereço] & ', ' & [Nro] AS [End], Clientes.NomeFantasia, Clientes.CpfCgc, Clientes.Cidade, Clientes.VendaVista, Clientes.VendaCheque, Clientes.VendaCrediario, Clientes.MotivoBloqueado, Clientes.Bloqueado, Clientes.Telefone, Clientes.Celular, Clientes.PessoaContato, Clientes.Endereço FROM(Clientes) WHERE(((Clientes.Empresa) = " & CodEmpresa & ") And ((Clientes.[Inativo]) = False)) ORDER BY Clientes.Nome;"
        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        da.Fill(Ds, "Table")

        bs = New BindingSource
        bs.DataSource = Ds.Tables("Table").DefaultView

        Me.Lista.DataSource = bs

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub SellShoesClientesProcura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregaTodosClientes()
        Me.TxtProcura.Focus()
        Me.A2.Checked = True
    End Sub

    Private Sub CampoChave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles A1.Click, A2.Click, A3.Click
        Me.TxtProcura.Focus()
    End Sub

    Private Sub Lista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellDoubleClick
        btIniciarVenda_Click(sender, e)
    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged, A5.CheckedChanged
        If Me.A1.Checked = True Then
            Me.TxtProcura.Clear()
            Me.TxtProcura.Focus()
        End If
        If Me.A2.Checked = True Then
            Me.TxtProcura.Clear()
            Me.TxtProcura.Focus()
        End If
        If Me.A3.Checked = True Then
            Me.TxtProcura.Clear()
            Me.TxtProcura.Focus()
        End If
        If Me.A5.Checked = True Then
            Me.TxtProcura.Clear()
            Me.TxtProcura.Focus()
        End If
    End Sub

    Private Sub A4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A4.CheckedChanged
        bs.Filter = Nothing
    End Sub

    Private Sub Lista_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lista.SelectionChanged
        Try
            'Todas a vez que for retornar um valor da celula no datagriview deverá ser feita a devida conversão.
            Me.xCliente.Text = Me.Lista.CurrentRow.Cells("cCodigo").Value & "-" & Me.Lista.CurrentRow.Cells("cNome").Value
            Me.xEndereço.Text = Me.Lista.CurrentRow.Cells("cEndereco").Value
            Me.xCpfCnpj.Text = Me.Lista.CurrentRow.Cells("cCpfCnpj").Value
            Me.xCidade.Text = Me.Lista.CurrentRow.Cells("cCidade").Value
            Me.xVendaVista.Checked = Me.Lista.CurrentRow.Cells("cVendaVista").Value
            Me.xVendaCheque.Checked = Me.Lista.CurrentRow.Cells("cVendaCheque").Value
            Me.xVendaCrediario.Checked = Me.Lista.CurrentRow.Cells("cVendaCrediario").Value
            Me.xTelefone.Text = Convert.ToString(Me.Lista.CurrentRow.Cells("gTelefone").Value)
            Me.xCelular.Text = Convert.ToString(Me.Lista.CurrentRow.Cells("gCelular").Value)
            Me.xContato.Text = Convert.ToString(Me.Lista.CurrentRow.Cells("gContato").Value)
            'Me.xMotivoBloqueado.Text = Me.Lista.CurrentRow.Cells("cMotivoBloqueado").Value & ""
            Me.xBloqueado.Checked = Me.Lista.CurrentRow.Cells("cBloqueado").Value

            If Me.xBloqueado.Checked = True Then
                Me.xMotivoBloqueado.Text = "Favor conduzir o Cliente para o setor de Crédito"
            Else
                Me.xMotivoBloqueado.Text = ""
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btIniciarVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btIniciarVenda.Click

        If NzZero(Me.Lista.CurrentRow.Cells("cCodigo").Value) = 0 Then
            Exit Sub
        End If

        My.Forms.SellShoesAutenticacao.IdCliente = Me.Lista.CurrentRow.Cells("cCodigo").Value
        My.Forms.SellShoesAutenticacao.ShowDialog()
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub Lista_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Lista.KeyDown
        If e.KeyCode = Keys.Enter Then
            btIniciarVenda_Click(sender, e)
        End If
    End Sub

    Private Sub TxtProcura_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProcura.TextChanged

        If Me.A1.Checked = True Then
            If Me.TxtProcura.Text = "" Then Exit Sub
            bs.Filter = "Codigo = " & Me.TxtProcura.Text
        End If
        If Me.A2.Checked = True Then
            bs.Filter = "Nome like '%" & Me.TxtProcura.Text & "%'"
        End If
        If Me.A3.Checked = True Then
            bs.Filter = "xProd CpfCgc '%" & Me.TxtProcura.Text & "%'"
        End If
        If Me.A5.Checked = True Then
            bs.Filter = "NomeFantasia like '%" & Me.TxtProcura.Text & "%'"
        End If

    End Sub

    Dim TelaCr As System.Windows.Forms.Form

    Private Sub btVerUltVendas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVerUltVendas.Click


        TRVDados(UserAtivo, "RelSellShoesPedidosTop")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else

            Dim Tel As New Form() ' Create a new instance of the form.

            TelaCr = Tel
            Dim Vz As New CrystalDecisions.Windows.Forms.CrystalReportViewer

            Dim F As New Font("Comic Sans MS", 8, System.Drawing.GraphicsUnit.Point)

            Tel.Text = "Visualizador de Relatório"
            Tel.Size = New Size(576, 352)
            Tel.HelpButton = False
            Tel.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Tel.MaximizeBox = True
            Tel.MinimizeBox = True
            Tel.ControlBox = True
            Tel.Font = F
            Tel.StartPosition = FormStartPosition.CenterScreen
            Tel.ShowInTaskbar = True
            Tel.WindowState = FormWindowState.Maximized

            Vz.Dock = DockStyle.Fill


            Dim Crypto As New ClCrypto 'Para descriptografar a senha do banco de dados
            'Carrega o relatorio
            Dim VerRelat As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            VerRelat.Load(DirRelat & "RelSellShoesPedidosTop.rpt")
            VerRelat.DataSourceConnections.Item(0).SetConnection("", LocalBD & Nome_BD, False)
            VerRelat.DataSourceConnections.Item(0).SetLogon("", Crypto.clsCrypto(SenhaBancoDados, False))
            VerRelat.DataDefinition.RecordSelectionFormula = "{Pedido.CódigoCliente} = " & Me.Lista.CurrentRow.Cells("cCodigo").Value


            Vz.ReportSource = VerRelat

            Tel.Controls.Add(Vz)

            Tel.ShowDialog()

        End If
    End Sub

    Private Sub btVerDebitos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVerDebitos.Click
        TRVDados(UserAtivo, "RelSellShoesPendenciaCliente")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Exit Sub
        Else

            Dim Tel As New Form() ' Create a new instance of the form.

            TelaCr = Tel
            Dim Vz As New CrystalDecisions.Windows.Forms.CrystalReportViewer

            Dim F As New Font("Comic Sans MS", 8, System.Drawing.GraphicsUnit.Point)

            Tel.Text = "Visualizador de Relatório"
            Tel.Size = New Size(576, 352)
            Tel.HelpButton = False
            Tel.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Tel.MaximizeBox = True
            Tel.MinimizeBox = True
            Tel.ControlBox = True
            Tel.Font = F
            Tel.StartPosition = FormStartPosition.CenterScreen
            Tel.ShowInTaskbar = True
            Tel.WindowState = FormWindowState.Maximized

            Vz.Dock = DockStyle.Fill


            Dim Crypto As New ClCrypto 'Para descriptografar a senha do banco de dados
            'Carrega o relatorio
            Dim VerRelat As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            VerRelat.Load(DirRelat & "RelSellShoesPendenciaCliente.rpt")
            VerRelat.DataSourceConnections.Item(0).SetConnection("", LocalBD & Nome_BD, False)
            VerRelat.DataSourceConnections.Item(0).SetLogon("", Crypto.clsCrypto(SenhaBancoDados, False))
            VerRelat.DataDefinition.RecordSelectionFormula = "{Receber.CodCliente} = " & Me.Lista.CurrentRow.Cells("cCodigo").Value & " and {Receber.Baixado} = False"

            Vz.ReportSource = VerRelat

            Tel.Controls.Add(Vz)

            Tel.ShowDialog()

        End If

    End Sub

    Private Sub Lista_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellContentClick

    End Sub

    Private Sub SellShoesClientesProcura_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F3
                Me.A1.Checked = True
                Me.TxtProcura.Focus()
            Case Keys.F4
                Me.A2.Checked = True
                Me.TxtProcura.Focus()
            Case Keys.F5
                Me.A5.Checked = True
                Me.TxtProcura.Focus()
            Case Keys.F6
                Me.A3.Checked = True
                Me.TxtProcura.Focus()
            Case Keys.F7
                Me.A4.Checked = True
                Me.TxtProcura.Focus()
        End Select
    End Sub
End Class