Public Class CompraProcurar
    Private Sub TxtProcura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtProcura.KeyPress
        Dim Tecla As Short = Asc(e.KeyChar)

        If Tecla = 13 Then
            System.Windows.Forms.SendKeys.Send("{Tab}")
            Tecla = 0
        End If
    End Sub

    Private Sub TxtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProcura.Leave
        If Me.TxtProcura.Text = "" Then
            Exit Sub
        End If
        BuscarCompra()
    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub CompraProcurar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Fornecedor.Checked = True
        Me.TxtProcura.Focus()
    End Sub

    Private Sub Fornecedor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fornecedor.Click
        Me.TxtProcura.Focus()
    End Sub

    Private Sub NotaFiscal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotaFiscal.Click
        Me.TxtProcura.Focus()
    End Sub


    Private Sub NotaFiscal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotaFiscal.CheckedChanged

    End Sub

    Private Sub MostrarTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarTodos.CheckedChanged
        BuscarCompra()
    End Sub


    Private Sub BuscarCompra()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Dim CampoFilter As String = ""

        If Me.NotaFiscal.Checked = True Then
            If Me.TxtProcura.Text = "" Then
                Exit Sub
            End If
            CampoFilter = "NotaFiscal"
            Sql = "SELECT Compra.CompraInterno, Compra.Confirmado, Compra.Inativo, Compra.Tipo, Compra.NotaFiscal, Compra.DataCompra, Compra.ValorCompra, Fornecedor.RazãoSocial, Compra.Empresa FROM Compra INNER JOIN Fornecedor ON Compra.CodigoFornecedor = Fornecedor.CódigoFornecedor WHERE Compra.Empresa = " & CodEmpresa & " and " & CampoFilter & " Like '%" & Me.TxtProcura.Text & "' & '%'"
        End If

        If Me.Fornecedor.Checked = True Then
            If Me.TxtProcura.Text = "" Then
                Exit Sub
            End If
            CampoFilter = "RazãoSocial"
            Sql = "SELECT Compra.CompraInterno, Compra.Confirmado,  Compra.Inativo, Compra.Tipo, Compra.NotaFiscal, Compra.DataCompra, Compra.ValorCompra, Fornecedor.RazãoSocial, Compra.Empresa FROM Compra INNER JOIN Fornecedor ON Compra.CodigoFornecedor = Fornecedor.CódigoFornecedor WHERE Compra.Empresa = " & CodEmpresa & " and " & CampoFilter & " Like '%" & Me.TxtProcura.Text & "' & '%'"
        End If

        If Me.MostrarTodos.Checked = True Then
            Sql = "SELECT Compra.CompraInterno, Compra.Confirmado,  Compra.Inativo, Compra.Tipo, Compra.NotaFiscal, Compra.DataCompra, Compra.ValorCompra, Fornecedor.RazãoSocial, Compra.Empresa FROM Compra INNER JOIN Fornecedor ON Compra.CodigoFornecedor = Fornecedor.CódigoFornecedor WHERE Compra.Empresa = " & CodEmpresa
        End If

        If Me.TodasDia.Checked = True Then
            Sql = "SELECT Compra.CompraInterno, Compra.Confirmado,  Compra.Inativo, Compra.Tipo, Compra.NotaFiscal, Compra.DataCompra, Compra.ValorCompra, Fornecedor.RazãoSocial, Compra.Empresa FROM Compra INNER JOIN Fornecedor ON Compra.CodigoFornecedor = Fornecedor.CódigoFornecedor WHERE Compra.Empresa = " & CodEmpresa & " And Compra.DataLançamento=#" & Format(CDate(DataDia), "MM/dd/yyyy") & "#"
        End If

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Lista.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        Cnn.Close()


        For Each Linha As DataGridViewRow In Me.Lista.Rows
            If Linha.Cells("Confirmado").Value = True Then
                Linha.Cells("Img").Value = Linha.Cells("ImgConf").Value
            End If
            If Linha.Cells("Confirmado").Value = False Then
                Linha.Cells("Img").Value = Linha.Cells("ImgEdd").Value
            End If
            If Linha.Cells("Inativo").Value = True Then
                Linha.Cells("Img").Value = Linha.Cells("ImgCanc").Value
            End If
        Next

    End Sub

    Private Sub Lista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellDoubleClick
        Dim vID As Integer
        vID = CInt(Me.Lista.CurrentRow.Cells(4).Value)

        RetornoProcura = vID


        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Lista_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Lista.Paint
        For Each Linha As DataGridViewRow In Me.Lista.Rows
            If Linha.Cells("Confirmado").Value = True Then
                Linha.Cells("Img").Value = Linha.Cells("ImgConf").Value
            End If
            If Linha.Cells("Confirmado").Value = False Then
                Linha.Cells("Img").Value = Linha.Cells("ImgEdd").Value
            End If
            If Linha.Cells("Inativo").Value = True Then
                Linha.Cells("Img").Value = Linha.Cells("ImgCanc").Value
            End If
        Next
    End Sub

    Private Sub TodasDia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodasDia.CheckedChanged
        BuscarCompra()
    End Sub
End Class