Public Class ComissaoRelat

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged
        If Me.A1.Checked = True Then
            Me.PainelFuncionario.Visible = True
            Me.PainelPeriodo.Visible = True
            Me.Funcionario.Focus()
        End If
    End Sub

    Private Sub ComissaoRelat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EncheListaFuncionario()
    End Sub

    Private Sub EncheListaFuncionario()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "Select Funcionários.CódigoFuncionário, Funcionários.Nome From Funcionários  Where Funcionários.Empresa = " & CodEmpresa & " And Funcionários.AdicionarEmVendas = True Order by Funcionários.Nome"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Dim DRnovo As DataRow
        DRnovo = ds.Tables("Table").NewRow()
        DRnovo("CódigoFuncionário") = 0
        DRnovo("Nome") = "TODOS"
        ds.Tables("Table").Rows.Add(DRnovo)


        Me.Funcionario.DataSource = ds.Tables("Table").DefaultView
        Me.Funcionario.DisplayMember = "Nome"
        Me.Funcionario.ValueMember = "CódigoFuncionário"
        Me.Funcionario.SelectedValue = -1

        da.Dispose()
        Cnn.Close()


    End Sub


    Private Sub btVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVisualizar.Click
        If Me.A1.Checked = True Then

            If Me.Funcionario.Text = "" Then
                MessageBox.Show("Favor informar o Funcionário", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Funcionario.Focus()
                Exit Sub
            End If
            If Me.DataInicial.Text = "" Then
                MsgBox("O usuário deve informar a data inicial para o relatório.", 64, "Validação de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usuário deve informar a data Final para o relatório.", 64, "Validação de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            Dim Conect As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
            Conect.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)

            If Me.Funcionario.SelectedValue = 0 Then
                Conect.SQL = "SELECT FuncionarioComissao.Funcionario, Funcionários.Nome, FuncionarioComissao.ComissaoFaturamento, FuncionarioComissao.DataLancamento, FuncionarioComissao.DataDocumento, FuncionarioComissao.Documento, FuncionarioComissao.PedidoVenda, FuncionarioComissao.Percentual, FuncionarioComissao.ValorDocumento, FuncionarioComissao.ValorComissao, FuncionarioComissao.Pago, FuncionarioComissao.OndeVeio, FuncionarioComissao.DescComissao, Empresa.RazãoSocial, Funcionários.Empresa FROM (FuncionarioComissao INNER JOIN Funcionários ON FuncionarioComissao.Funcionario = Funcionários.CódigoFuncionário) INNER JOIN Empresa ON Funcionários.Empresa = Empresa.CódigoEmpresa WHERE (((FuncionarioComissao.DataLancamento) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Funcionários.Empresa)=" & CodEmpresa & ")) ORDER BY Funcionários.Nome, FuncionarioComissao.ComissaoFaturamento, FuncionarioComissao.DataLancamento;"
            Else
                Conect.SQL = "SELECT FuncionarioComissao.Funcionario, Funcionários.Nome, FuncionarioComissao.ComissaoFaturamento, FuncionarioComissao.DataLancamento, FuncionarioComissao.DataDocumento, FuncionarioComissao.Documento, FuncionarioComissao.PedidoVenda, FuncionarioComissao.Percentual, FuncionarioComissao.ValorDocumento, FuncionarioComissao.ValorComissao, FuncionarioComissao.Pago, FuncionarioComissao.OndeVeio, FuncionarioComissao.DescComissao, Empresa.RazãoSocial, Funcionários.Empresa FROM (FuncionarioComissao INNER JOIN Funcionários ON FuncionarioComissao.Funcionario = Funcionários.CódigoFuncionário) INNER JOIN Empresa ON Funcionários.Empresa = Empresa.CódigoEmpresa WHERE (((FuncionarioComissao.Funcionario)=" & Me.Funcionario.SelectedValue & ") AND ((FuncionarioComissao.DataLancamento) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Funcionários.Empresa)=" & CodEmpresa & ")) ORDER BY Funcionários.Nome, FuncionarioComissao.ComissaoFaturamento, FuncionarioComissao.DataLancamento;"
            End If

            Dim Rel As New RelComissaoFaixa
            Rel.Titulo.Text = "Comissão de Vendedores no Período de : " & Me.DataInicial.Text & " a " & Me.DataFinal.Text
            Rel.DataSource = Conect

            My.Forms.ViewReport.VerRelat.Document = Rel.Document
            My.Forms.ViewReport.VerRelat.Document.Name = "RelComissaoFaixa"
            Rel.Run()

            My.Forms.ViewReport.ShowDialog()

        End If
    End Sub
End Class