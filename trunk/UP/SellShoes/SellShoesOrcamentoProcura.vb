Public Class SellShoesOrcamentoProcura

    Private Sub SellShoesOrcamentoProcura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CodCli.Focus()
    End Sub


    Public Sub EncherLista()


        Dim Ds As New DataSet

        Dim CN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CN.Open()

        Dim     Sql As String = String.Empty
        If Me.A1.Checked = True Then
            Sql = "SELECT Orc.OrcSequencia, [CódigoCliente] & ' - ' & [Clientes.Nome] AS Cliente, Orc.DataOrc, Orc.TotalOrc, Funcionários.Nome AS Vendedor FROM (Orc INNER JOIN Clientes ON Orc.CódigoCliente = Clientes.Codigo) INNER JOIN Funcionários ON Orc.CódigoFuncionário = Funcionários.CódigoFuncionário WHERE(((Orc.Empresa) = " & CodEmpresa & ") And ((Orc.Inativo) = False)) ORDER BY Orc.OrcSequencia And Clientes.Codigo = " & Me.CodCli.Text
        End If
        If Me.A2.Checked = True Then
            Sql = "SELECT Orc.OrcSequencia, [CódigoCliente] & ' - ' & [Clientes.Nome] AS Cliente, Orc.DataOrc, Orc.TotalOrc, Funcionários.Nome AS Vendedor FROM (Orc INNER JOIN Clientes ON Orc.CódigoCliente = Clientes.Codigo) INNER JOIN Funcionários ON Orc.CódigoFuncionário = Funcionários.CódigoFuncionário WHERE(((Orc.Empresa) = " & CodEmpresa & ") And ((Orc.Inativo) = False)) And Orc.DataOrc = #" & Format(CDate(Me.ProcuraTxt.Text), "MM/dd/yyyy") & "# ORDER BY Orc.OrcSequencia"
        End If

        If Me.A3.Checked = True Then
            Sql = "SELECT Orc.OrcSequencia, [CódigoCliente] & ' - ' & [Clientes.Nome] AS Cliente, Orc.DataOrc, Orc.TotalOrc, Funcionários.Nome AS Vendedor FROM (Orc INNER JOIN Clientes ON Orc.CódigoCliente = Clientes.Codigo) INNER JOIN Funcionários ON Orc.CódigoFuncionário = Funcionários.CódigoFuncionário WHERE(((Orc.Empresa) = " & CodEmpresa & ") And ((Orc.Inativo) = False)) And Orc.CódigoFuncionário = " & Me.ProcuraTxt.Text & " ORDER BY Orc.OrcSequencia"
        End If
        If Me.A4.Checked = True Then
            Sql = "SELECT Orc.OrcSequencia, [CódigoCliente] & ' - ' & [clientes.Nome] AS Cliente, Orc.DataOrc, Orc.TotalOrc, Funcionários.Nome AS Vendedor FROM (Orc INNER JOIN Clientes ON Orc.CódigoCliente = Clientes.Codigo) INNER JOIN Funcionários ON Orc.CódigoFuncionário = Funcionários.CódigoFuncionário WHERE(((Orc.Empresa) = " & CodEmpresa & ") And ((Orc.Inativo) = False)) And Orc.OrcSequencia = " & Me.ProcuraTxt.Text & " ORDER BY Orc.OrcSequencia"
        End If

        Dim CMD As New OleDb.OleDbCommand(Sql, CN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Da.Fill(Ds, "Orc")
        Me.Lista.DataSource = Ds.Tables("Orc").DefaultView

        End Sub

   
    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub Lista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellDoubleClick
        Dim vID As Integer
        vID = CInt(Me.Lista.CurrentRow.Cells("cOrcSequencia").Value)

        If vID <> 0 Then
            My.Forms.SellShoesOrcamento.AcharOrc = True
            My.Forms.SellShoesOrcamento.StrOrc = vID
            My.Forms.SellShoesOrcamento.ShowDialog()
        End If
    End Sub


    Private Sub CodCli_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodCli.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(Me.CodCli.Text) > 0 Then
                If Me.CliDesc.Text = "" Then AcharCliente()
                EncherLista()
            End If
        End If

        If e.KeyCode = Keys.F5 Then
            Me.CodCli.Clear()
            Me.CodCli.Clear()

            My.Forms.ClientesProcura.ShowDialog()

            AcharCliente()
            End If

    End Sub

    Private Sub btFindClintes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindClintes.Click

        Me.CodCli.Clear()
        Me.CodCli.Clear()

        My.Forms.ClientesProcura.ShowDialog()

        AcharCliente()
    End Sub


    Private Sub AcharCliente()
        If Me.CodCli.Text = "" Then Exit Sub

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT Clientes.* FROM Clientes WHERE Clientes.Empresa =" & CodEmpresa & " AND Clientes.Codigo = " & Me.CodCli.Text

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()


        If DR.HasRows Then
            Me.CliDesc.Text = DR.Item("Nome") & ""
        Else
            MessageBox.Show("Cliente não encontrado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        DR.Close()
        CNN.Close()

    End Sub

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        My.Forms.SellShoesAutenticacao.OpcOrcamento.Checked = True
        My.Forms.SellShoesAutenticacao.OpcOrcamento.Enabled = False
        My.Forms.SellShoesAutenticacao.OpcDevoluçao.Enabled = False
        My.Forms.SellShoesAutenticacao.OpcVenda.Enabled = False

        My.Forms.SellShoesAutenticacao.ShowDialog()
    End Sub


    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged, A4.CheckedChanged
        If Me.A1.Checked = True Then
            Me.PainelCliente.Visible = True
            Me.PainelOutros.Visible = False
            Me.CodCli.Clear()
            Me.CodCli.Focus()
        End If

        If Me.A2.Checked = True Then
            Me.PainelCliente.Visible = False
            Me.PainelOutros.Visible = True
            Me.LabelOutros.Text = "Inf. a Data"
            Me.ProcuraTxt.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
            Me.ProcuraTxt.Clear()
            Me.ProcuraTxt.Focus()
        End If

        If Me.A3.Checked = True Then
            Me.PainelCliente.Visible = False
            Me.PainelOutros.Visible = True
            Me.LabelOutros.Text = "Inf. o Vendedor"
            Me.ProcuraTxt.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
            Me.ProcuraTxt.Clear()
            Me.ProcuraTxt.Focus()
        End If

        If Me.A4.Checked = True Then
            Me.PainelCliente.Visible = False
            Me.PainelOutros.Visible = True
            Me.ProcuraTxt.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
            Me.LabelOutros.Text = "Inf. o Orçamento"
            Me.ProcuraTxt.Clear()
            Me.ProcuraTxt.Focus()
        End If


    End Sub

    Private Sub ProcuraTxt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ProcuraTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Len(Me.ProcuraTxt.Text) > 0 Then
                EncherLista()
            End If
        End If
    End Sub
End Class