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

        Sql = "Select Funcion�rios.C�digoFuncion�rio, Funcion�rios.Nome From Funcion�rios  Where Funcion�rios.Empresa = " & CodEmpresa & " And Funcion�rios.AdicionarEmVendas = True Order by Funcion�rios.Nome"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Dim DRnovo As DataRow
        DRnovo = ds.Tables("Table").NewRow()
        DRnovo("C�digoFuncion�rio") = 0
        DRnovo("Nome") = "TODOS"
        ds.Tables("Table").Rows.Add(DRnovo)


        Me.Funcionario.DataSource = ds.Tables("Table").DefaultView
        Me.Funcionario.DisplayMember = "Nome"
        Me.Funcionario.ValueMember = "C�digoFuncion�rio"
        Me.Funcionario.SelectedValue = -1

        da.Dispose()
        Cnn.Close()


    End Sub


    Private Sub btVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVisualizar.Click
        If Me.A1.Checked = True Then

            If Me.Funcionario.Text = "" Then
                MessageBox.Show("Favor informar o Funcion�rio", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Funcionario.Focus()
                Exit Sub
            End If
            If Me.DataInicial.Text = "" Then
                MsgBox("O usu�rio deve informar a data inicial para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usu�rio deve informar a data Final para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            Dim Conect As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
            Conect.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)

            If Me.Funcionario.SelectedValue = 0 Then
                Conect.SQL = "SELECT FuncionarioComissao.Funcionario, Funcion�rios.Nome, FuncionarioComissao.ComissaoFaturamento, FuncionarioComissao.DataLancamento, FuncionarioComissao.DataDocumento, FuncionarioComissao.Documento, FuncionarioComissao.PedidoVenda, FuncionarioComissao.Percentual, FuncionarioComissao.ValorDocumento, FuncionarioComissao.ValorComissao, FuncionarioComissao.Pago, FuncionarioComissao.OndeVeio, FuncionarioComissao.DescComissao, Empresa.Raz�oSocial, Funcion�rios.Empresa FROM (FuncionarioComissao INNER JOIN Funcion�rios ON FuncionarioComissao.Funcionario = Funcion�rios.C�digoFuncion�rio) INNER JOIN Empresa ON Funcion�rios.Empresa = Empresa.C�digoEmpresa WHERE (((FuncionarioComissao.DataLancamento) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Funcion�rios.Empresa)=" & CodEmpresa & ")) ORDER BY Funcion�rios.Nome, FuncionarioComissao.ComissaoFaturamento, FuncionarioComissao.DataLancamento;"
            Else
                Conect.SQL = "SELECT FuncionarioComissao.Funcionario, Funcion�rios.Nome, FuncionarioComissao.ComissaoFaturamento, FuncionarioComissao.DataLancamento, FuncionarioComissao.DataDocumento, FuncionarioComissao.Documento, FuncionarioComissao.PedidoVenda, FuncionarioComissao.Percentual, FuncionarioComissao.ValorDocumento, FuncionarioComissao.ValorComissao, FuncionarioComissao.Pago, FuncionarioComissao.OndeVeio, FuncionarioComissao.DescComissao, Empresa.Raz�oSocial, Funcion�rios.Empresa FROM (FuncionarioComissao INNER JOIN Funcion�rios ON FuncionarioComissao.Funcionario = Funcion�rios.C�digoFuncion�rio) INNER JOIN Empresa ON Funcion�rios.Empresa = Empresa.C�digoEmpresa WHERE (((FuncionarioComissao.Funcionario)=" & Me.Funcionario.SelectedValue & ") AND ((FuncionarioComissao.DataLancamento) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Funcion�rios.Empresa)=" & CodEmpresa & ")) ORDER BY Funcion�rios.Nome, FuncionarioComissao.ComissaoFaturamento, FuncionarioComissao.DataLancamento;"
            End If

            Dim Rel As New RelComissaoFaixa
            Rel.Titulo.Text = "Comiss�o de Vendedores no Per�odo de : " & Me.DataInicial.Text & " a " & Me.DataFinal.Text
            Rel.DataSource = Conect

            My.Forms.ViewReport.VerRelat.Document = Rel.Document
            My.Forms.ViewReport.VerRelat.Document.Name = "RelComissaoFaixa"
            Rel.Run()

            My.Forms.ViewReport.ShowDialog()

        End If
    End Sub
End Class