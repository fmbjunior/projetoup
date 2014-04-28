Imports System.Data.OleDb
Public Class TelaProcuraDocumento



    Private Sub TxtProcura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtProcura.KeyPress
        Dim Tecla As Short = Asc(e.KeyChar)

        If Tecla = 13 Then
            System.Windows.Forms.SendKeys.Send("{Tab}")
            Tecla = 0
        End If
    End Sub

    Private Sub TxtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProcura.Leave
        If Me.TxtProcura.Text = "" Then
            Me.TxtProcura.Focus()
            Exit Sub
        End If

        If Me.CampoChave.Checked = True Then CarregaLista(1)
        If Me.AlfaNumerica.Checked = True Then CarregaLista(2)
        If Me.DocumentoFornecedor.Checked = True Then CarregaLista(3)

    End Sub


    Private Sub TelaProcura_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.TxtProcura.Focus()
    End Sub

    Private Sub TelaProcuraDocumento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AlfaNumerica.Checked = True
        Me.TxtProcura.Focus()
    End Sub

    Private Sub AlfaNumerica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlfaNumerica.Click
        Me.TxtProcura.Focus()
    End Sub

    Private Sub CampoChave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CampoChave.Click
        Me.TxtProcura.Focus()
    End Sub

    Private Sub MostraTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostraTodos.CheckedChanged
        If Me.MostraTodos.Checked Then CarregaLista(4)
        Me.Lista.Focus()
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub CarregaLista(ByVal Opt As Integer)
        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Select Case Opt
            Case 1
                Sql = "SELECT Id, FornecedorDesc, NotaFiscal, ValorPedido, Tipo, DataLançamento, Inativo, Confirmado, Destino FROM CompraCtrlPedido WHERE CompraCtrlPedido.Empresa = " & CodEmpresa & " And Id = " & Me.TxtProcura.Text & " order by  CompraCtrlPedido.Id"
            Case 2
                Sql = "SELECT Id, FornecedorDesc, NotaFiscal, ValorPedido, Tipo, DataLançamento, Inativo, Confirmado, Destino FROM CompraCtrlPedido WHERE CompraCtrlPedido.Empresa = " & CodEmpresa & " And FornecedorDesc Like '%" & Me.TxtProcura.Text & "' & '%' order by CompraCtrlPedido.FornecedorDesc"
            Case 3
                Sql = "SELECT Id, FornecedorDesc, NotaFiscal, ValorPedido, Tipo, Datalançamento, Inativo, Confirmado, Destino FROM CompraCtrlPedido WHERE CompraCtrlPedido.Empresa = " & CodEmpresa & " And NotaFiscal = '" & Me.TxtProcura.Text & "' order by CompraCtrlPedido.NotaFiscal"
            Case 4
                Sql = "SELECT Id, FornecedorDesc, NotaFiscal, ValorPedido, Tipo, Datalançamento, Inativo, Confirmado, Destino FROM CompraCtrlPedido WHERE CompraCtrlPedido.Empresa = " & CodEmpresa & " order by CompraCtrlPedido.Id"
        End Select

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Lista.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        Cnn.Close()
    End Sub

    Private Sub Lista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellDoubleClick
        Dim vID As Integer
        vID = CInt(Me.Lista.CurrentRow.Cells(0).Value)
        My.Forms.DocumentoEntrada.Id.Text = vID
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Lista_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lista.SelectionChanged
        Try
            Me.lblDestino.Text = Me.Lista.CurrentRow.Cells("gDestino").Value
        Catch ex As Exception
        End Try
    End Sub

End Class