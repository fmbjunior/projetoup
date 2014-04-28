Imports System.Data.OleDb
Public Class TelaProcuraFor

    Private Sub TxtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProcura.Leave
        If Me.TxtProcura.Text = "" Then
            Exit Sub
        End If

        If Me.A1.Checked = True Then BuscarFor(1)
        If Me.A2.Checked = True Then BuscarFor(2)
        If Me.A3.Checked = True Then BuscarFor(3)
        If Me.A5.Checked = True Then BuscarFor(5)
        If Me.A6.Checked = True Then BuscarFor(6)
        If Me.A7.Checked = True Then BuscarFor(7)



        Me.Lista.Focus()

    End Sub


    Private Sub BuscarFor(ByVal Opt As String)

        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Select Case Opt
            Case 1
                Sql = "Select Fornecedor.CódigoFornecedor, Fornecedor.RazãoSocial, Fornecedor.NomeFantasia, Fornecedor.CgcCpf from Fornecedor  Where CódigoFornecedor = " & Me.TxtProcura.Text & " and and Fornecedor.Inativo = False And Fornecedor.Empresa = " & CodEmpresa
            Case 2
                Sql = "Select Fornecedor.CódigoFornecedor, Fornecedor.RazãoSocial, Fornecedor.NomeFantasia, Fornecedor.CgcCpf from Fornecedor  Where Fornecedor.Empresa = " & CodEmpresa & " And RazãoSocial like '%" & Me.TxtProcura.Text & "%' and Fornecedor.Inativo = False Order by Fornecedor.RazãoSocial"
            Case 3
                Sql = "Select Fornecedor.CódigoFornecedor, Fornecedor.RazãoSocial, Fornecedor.NomeFantasia, Fornecedor.CgcCpf from Fornecedor  Where Fornecedor.Empresa = " & CodEmpresa & " And NomeFantasia like '%" & Me.TxtProcura.Text & "%' and Fornecedor.Inativo = False Order by Fornecedor.RazãoSocial"
            Case 4
                Sql = "Select Fornecedor.CódigoFornecedor, Fornecedor.RazãoSocial, Fornecedor.NomeFantasia, Fornecedor.CgcCpf from Fornecedor  Where Fornecedor.Empresa = " & CodEmpresa & " and Fornecedor.Inativo = False Order by Fornecedor.RazãoSocial"
            Case 5
                Sql = "Select Fornecedor.CódigoFornecedor, Fornecedor.RazãoSocial, Fornecedor.NomeFantasia, Fornecedor.CgcCpf from Fornecedor  Where Fornecedor.Empresa = " & CodEmpresa & " And CpfCgc like '%" & Me.TxtProcura.Text & "%'  and Fornecedor.Inativo = False Order by Fornecedor.RazãoSocial"
            Case 6
                Sql = "Select Fornecedor.CódigoFornecedor, Fornecedor.RazãoSocial, Fornecedor.NomeFantasia, Fornecedor.CgcCpf from Fornecedor  Where Fornecedor.Empresa = " & CodEmpresa & " And CpfCgc like '%" & Me.TxtProcura.Text & "%'  and Fornecedor.Inativo = False Order by Fornecedor.RazãoSocial"
            Case 7
                Sql = "Select Fornecedor.CódigoFornecedor, Fornecedor.RazãoSocial, Fornecedor.NomeFantasia, Fornecedor.CgcCpf from Fornecedor  Where Fornecedor.Empresa = " & CodEmpresa & " And RazãoSocial like '%" & Me.TxtProcura.Text & "%' and Inativo=True Order by Fornecedor.RazãoSocial"

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

    Private Sub TelaProcura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TxtProcura.Focus()
        Me.A2.Checked = True
    End Sub

    Private Sub CampoChave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles A1.Click, A2.Click, A3.Click
        Me.TxtProcura.Focus()
    End Sub

    Private Sub Lista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellDoubleClick
        Dim vID As Integer
        vID = CInt(Me.Lista.CurrentRow.Cells(0).Value)

        If My.Forms.Fornecedor.Visible = True Then My.Forms.Fornecedor.CódigoFornecedor.Text = vID
        If My.Forms.CaixaLançamentos.Visible = True Then My.Forms.CaixaLançamentos.CliFor.Text = vID
        If My.Forms.Pagar.Visible = True Then My.Forms.Pagar.Fornecedor.Text = vID
        If My.Forms.ComprasRelat.Visible = True Then My.Forms.ComprasRelat.Fornecedor.Text = vID
        If My.Forms.Compra.Visible = True Then My.Forms.Compra.CodigoFornecedor.Text = vID
        If My.Forms.SellShoesPedidoCompra.Visible = True Then My.Forms.SellShoesPedidoCompra.txtCodigoFornecedor.Text = vID

        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged, A4.CheckedChanged, A5.CheckedChanged, A6.CheckedChanged, A7.CheckedChanged
        If Me.A1.Checked Or A2.Checked Or A3.Checked Or A7.Checked Then
            Me.TxtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
            Me.TxtProcura.Clear()
            Me.TxtProcura.Focus()
        End If
        If Me.A4.Checked = True Then
            Me.TxtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
            If Me.A4.Checked = True Then BuscarFor(4)
        End If

        If Me.A5.Checked Then
            Me.TxtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Cnpj
            Me.TxtProcura.Clear()
            Me.TxtProcura.Focus()
        End If
        If Me.A6.Checked Then
            Me.TxtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Cpf
            Me.TxtProcura.Clear()
            Me.TxtProcura.Focus()
        End If

    End Sub

    Private Sub Lista_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Lista.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim vID As Integer
            vID = CInt(Me.Lista.CurrentRow.Cells(0).Value)

            If My.Forms.Fornecedor.Visible = True Then My.Forms.Fornecedor.CódigoFornecedor.Text = vID
            If My.Forms.CaixaLançamentos.Visible = True Then My.Forms.CaixaLançamentos.CliFor.Text = vID
            If My.Forms.Pagar.Visible = True Then My.Forms.Pagar.Fornecedor.Text = vID
            If My.Forms.ComprasRelat.Visible = True Then My.Forms.ComprasRelat.Fornecedor.Text = vID
            If My.Forms.Compra.Visible = True Then My.Forms.Compra.CodigoFornecedor.Text = vID
            If My.Forms.SellShoesPedidoCompra.Visible = True Then My.Forms.SellShoesPedidoCompra.txtCodigoFornecedor.Text = vID
            Me.Close()
            Me.Dispose()
        End If
    End Sub
End Class