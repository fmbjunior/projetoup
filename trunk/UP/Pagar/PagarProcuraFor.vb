Imports System.Data.OleDb
Public Class PagarProcuraFor

    Private Sub TxtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProcura.Leave
        If Me.TxtProcura.Text = "" Then
            Exit Sub
        End If

        If Me.A1.Checked = True Then BuscarFor(1)
        If Me.A2.Checked = True Then BuscarFor(2)
        If Me.A3.Checked = True Then BuscarFor(3)

    End Sub


    Private Sub BuscarFor(ByVal Opt As String)

        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Select Case Opt
            Case 1
                Sql = "SELECT Fornecedor.CódigoFornecedor, Fornecedor.RazãoSocial, Fornecedor.NomeFantasia, Fornecedor.CgcCpf FROM Fornecedor INNER JOIN Pagar ON Fornecedor.CódigoFornecedor = Pagar.CodFornecedor GROUP BY Fornecedor.CódigoFornecedor, Fornecedor.RazãoSocial, Fornecedor.NomeFantasia, Fornecedor.CgcCpf, Fornecedor.Empresa, Pagar.Baixado HAVING (((Fornecedor.CódigoFornecedor)=" & Me.TxtProcura.Text & ") AND ((Fornecedor.Empresa)=" & CodEmpresa & ") AND ((Pagar.Baixado)=False));"
            Case 2
                Sql = "SELECT Fornecedor.CódigoFornecedor, Fornecedor.RazãoSocial, Fornecedor.NomeFantasia, Fornecedor.CgcCpf FROM Fornecedor INNER JOIN Pagar ON Fornecedor.CódigoFornecedor = Pagar.CodFornecedor WHERE (((Fornecedor.Empresa)=" & CodEmpresa & ") AND ((Fornecedor.RazãoSocial) Like '%" & Me.TxtProcura.Text & "%')) GROUP BY Fornecedor.CódigoFornecedor, Fornecedor.RazãoSocial, Fornecedor.NomeFantasia, Fornecedor.CgcCpf, Pagar.Baixado HAVING(((Pagar.Baixado) = False)) ORDER BY Fornecedor.RazãoSocial;"
            Case 3
                Sql = "SELECT Fornecedor.CódigoFornecedor, Fornecedor.RazãoSocial, Fornecedor.NomeFantasia, Fornecedor.CgcCpf FROM Fornecedor INNER JOIN Pagar ON Fornecedor.CódigoFornecedor = Pagar.CodFornecedor WHERE (((Fornecedor.Empresa)=" & CodEmpresa & ") AND ((Fornecedor.NomeFantasia) Like '%" & Me.TxtProcura.Text & "%')) GROUP BY Fornecedor.CódigoFornecedor, Fornecedor.RazãoSocial, Fornecedor.NomeFantasia, Fornecedor.CgcCpf, Pagar.Baixado HAVING(((Pagar.Baixado) = False)) ORDER BY Fornecedor.RazãoSocial;"
            Case 4
                Sql = "SELECT Fornecedor.CódigoFornecedor, Fornecedor.RazãoSocial, Fornecedor.NomeFantasia, Fornecedor.CgcCpf FROM Fornecedor INNER JOIN Pagar ON Fornecedor.CódigoFornecedor = Pagar.CodFornecedor WHERE(((Fornecedor.Empresa) = " & CodEmpresa & ")) GROUP BY Fornecedor.CódigoFornecedor, Fornecedor.RazãoSocial, Fornecedor.NomeFantasia, Fornecedor.CgcCpf, Pagar.Baixado HAVING(((Pagar.Baixado) = False)) ORDER BY Fornecedor.RazãoSocial;"
        End Select

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Lista.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub PagarProcuraFor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TxtProcura.Focus()
        Me.A2.Checked = True
    End Sub

    Private Sub CampoChave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles A1.Click, A2.Click, A3.Click
        Me.TxtProcura.Focus()
    End Sub

    Private Sub Lista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellDoubleClick
        Dim vID As Integer
        vID = Me.Lista.CurrentRow.Cells(0).Value

        If My.Forms.Fornecedor.Visible = True Then My.Forms.Fornecedor.CódigoFornecedor.Text = vID
        If My.Forms.CaixaLançamentos.Visible = True Then My.Forms.CaixaLançamentos.CliFor.Text = vID
        If My.Forms.Pagar.Visible = True Then My.Forms.Pagar.Fornecedor.Text = vID
        If My.Forms.ComprasRelat.Visible = True Then My.Forms.ComprasRelat.Fornecedor.Text = vID
        If My.Forms.PagarAgrupar.Visible = True Then My.Forms.PagarAgrupar.Fornecedor.Text = vID

        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged, A4.CheckedChanged
        Me.TxtProcura.Clear()
        If Me.A1.Checked = True Then
            Me.TxtProcura.Focus()
        End If
        If Me.A2.Checked = True Then
            Me.TxtProcura.Focus()
        End If
        If Me.A3.Checked = True Then
            Me.TxtProcura.Focus()
        End If
        If Me.A4.Checked = True Then
            If Me.A4.Checked = True Then BuscarFor(4)
        End If

    End Sub
End Class