Imports System.Data.OleDb
Public Class ClientesCredProcura


    Private Sub TxtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProcura.Leave
        If Me.TxtProcura.Text = "" Then
            Exit Sub
        End If

        If Me.A1.Checked = True Then BuscarCliente(1)
        If Me.A2.Checked = True Then BuscarCliente(2)
        Me.Lista.Focus()

    End Sub


    Private Sub BuscarCliente(ByVal Opt As String)

        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Select Case Opt
            Case 1

                Sql = "SELECT ClienteCred.Id, ClienteCred.Cliente, Clientes.Nome, ClienteCred.DescCred, ClienteCred.DataCred, ClienteCred.VencimentoCred, ClienteCred.ValorCred, ClienteCred.Confirmado FROM ClienteCred INNER JOIN Clientes ON ClienteCred.Cliente = Clientes.Codigo WHERE (((ClienteCred.Id) = " & Me.TxtProcura.Text & ") AND ((ClienteCred.Empresa)=" & CodEmpresa & "));"
            Case 2
                Sql = "SELECT ClienteCred.Id, ClienteCred.Cliente, Clientes.Nome, ClienteCred.DescCred, ClienteCred.DataCred, ClienteCred.VencimentoCred, ClienteCred.ValorCred, ClienteCred.Confirmado FROM ClienteCred INNER JOIN Clientes ON ClienteCred.Cliente = Clientes.Codigo WHERE (((Clientes.Nome) Like '%" & Me.TxtProcura.Text & "%') AND ((ClienteCred.Empresa)=" & CodEmpresa & "));"
            Case 4
                Sql = "SELECT ClienteCred.Id, ClienteCred.Cliente, Clientes.Nome, ClienteCred.DescCred, ClienteCred.DataCred, ClienteCred.VencimentoCred, ClienteCred.ValorCred, ClienteCred.Confirmado FROM ClienteCred INNER JOIN Clientes ON ClienteCred.Cliente = Clientes.Codigo WHERE ClienteCred.Empresa = " & CodEmpresa & ";"
        End Select

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Lista.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        cnn.Close()

    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub TelaProcura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TxtProcura.Focus()
        Me.A2.Checked = True
    End Sub

    Private Sub CampoChave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles A1.Click, A2.Click
        Me.TxtProcura.Focus()
    End Sub

    Private Sub Lista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellDoubleClick
        Dim vID As Integer
        vID = CInt(Me.Lista.CurrentRow.Cells(0).Value)

        If My.Forms.ClientesCred.Visible = True Then My.Forms.ClientesCred.Id.Text = vID

        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged
        If Me.A1.Checked = True Then
            Me.TxtProcura.Focus()
        End If
        If Me.A2.Checked = True Then
            Me.TxtProcura.Focus()
        End If
    End Sub

    Private Sub A4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A3.CheckedChanged
        BuscarCliente(4)
    End Sub


    Private Sub Lista_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Lista.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim vID As Integer
            vID = CInt(Me.Lista.CurrentRow.Cells(0).Value)

            If My.Forms.ClientesCred.Visible = True Then
                My.Forms.ClientesCred.Id.Text = vID
            End If
            Me.Close()
            Me.Dispose()
        End If
    End Sub
End Class