Imports System.Data.OleDb
Public Class ReceberAgruparLocalizar

    Private Sub btFechar_Click(sender As Object, e As EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub ReceberAgruparLocalizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub BuscarAgrupamentos(ByVal Opt As String)

        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Select Case Opt
            Case 1
                Sql = "SELECT ReceberAgrupar.IdAgrupar, ReceberAgrupar.DataLancamento, Clientes.Nome, ReceberAgrupar.ValorAgrupado, ReceberAgrupar.Confirmado FROM ReceberAgrupar INNER JOIN Clientes ON ReceberAgrupar.Cliente = Clientes.Codigo WHERE (((ReceberAgrupar.IdAgrupar)=" & Me.TxtProcura.Text & ") AND ((ReceberAgrupar.Confirmado)=True) AND ((ReceberAgrupar.Inativo)=False));"
            Case 2
                Sql = "SELECT ReceberAgrupar.IdAgrupar, ReceberAgrupar.DataLancamento, Clientes.Nome, ReceberAgrupar.ValorAgrupado, ReceberAgrupar.Confirmado FROM ReceberAgrupar INNER JOIN Clientes ON ReceberAgrupar.Cliente = Clientes.Codigo WHERE (((ReceberAgrupar.DataLancamento)=#" & Format(CDate(Me.TxtProcura.Text), "MM/dd/yyy") & "#) AND ((ReceberAgrupar.Confirmado)=True) AND ((ReceberAgrupar.Inativo)=False));"
            Case 3
                Sql = "SELECT ReceberAgrupar.IdAgrupar, ReceberAgrupar.DataLancamento, Clientes.Nome, ReceberAgrupar.ValorAgrupado, ReceberAgrupar.Confirmado FROM ReceberAgrupar INNER JOIN Clientes ON ReceberAgrupar.Cliente = Clientes.Codigo WHERE (((Clientes.Nome) Like '%" & Me.TxtProcura.Text & "%') AND ((ReceberAgrupar.Confirmado)=True) AND ((ReceberAgrupar.Inativo)=False));"
        End Select

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Lista.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub TxtProcura_Leave(sender As Object, e As EventArgs) Handles TxtProcura.Leave
        If Me.TxtProcura.Text = "" Then
            Exit Sub
        End If

        If Me.A1.Checked = True Then BuscarAgrupamentos(1)
        If Me.A2.Checked = True Then BuscarAgrupamentos(2)
        If Me.A3.Checked = True Then BuscarAgrupamentos(3)
        Me.Lista.Focus()
    End Sub

    Private Sub A1_CheckedChanged(sender As Object, e As EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged
        If Me.A1.Checked = True Then
            Me.TxtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
            Me.TxtProcura.Focus()
        End If
        If Me.A2.Checked = True Then
            Me.TxtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
            Me.TxtProcura.Focus()
        End If
        If Me.A3.Checked = True Then
            Me.TxtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
            Me.TxtProcura.Focus()
        End If
    End Sub

    Private Sub Lista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellDoubleClick
        Dim vID As Integer
        vID = CInt(Me.Lista.CurrentRow.Cells("cId").Value)

        If My.Forms.ReceberAgrupar.Visible = True Then My.Forms.ReceberAgrupar.IdAgrupar.Text = vID


        Me.Close()
        Me.Dispose()
    End Sub

End Class