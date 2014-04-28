Public Class ProducaoProcura

    Dim opt As Integer

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ProcuraProduto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.A2.Checked = True
        Me.txtProcura.Focus()
    End Sub

    Private Sub txtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProcura.Leave
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim Sql As String = ""
        If Me.A1.Checked = True Then
            Sql = "SELECT Producao.OrdemProducao, Producao.DataOrdem, Producao.Solicitante, Producao.Motivo, Producao.Confirmado FROM Producao WHERE Producao.OrdemProducao = " & Me.txtProcura.Text & " And Empresa = " & CodEmpresa
        End If
        If Me.A2.Checked = True Then
            Sql = "SELECT Producao.OrdemProducao, Producao.DataOrdem, Producao.Solicitante, Producao.Motivo, Producao.Confirmado FROM Producao WHERE Producao.Solicitante Like '%" & Me.txtProcura.Text & "%' And Empresa = " & CodEmpresa
        End If
        If Me.A3.Checked = True Then
            Sql = "SELECT Producao.OrdemProducao, Producao.DataOrdem, Producao.Solicitante, Producao.Motivo, Producao.Confirmado FROM Producao WHERE Producao.Motivo Like '%" & Me.txtProcura.Text & "%' And Empresa = " & CodEmpresa
        End If


        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet
        Da.Fill(ds, "Table")

        Me.DgvItem.DataSource = ds.Tables("Table").DefaultView


        Da.Dispose()
        CNN.Close()
    End Sub



    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged

        If Me.A1.Checked = True Then
            Me.txtProcura.Clear()
            Me.txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
            Me.txtProcura.Focus()
        End If
        If Me.A2.Checked = True Then
            Me.txtProcura.Clear()
            Me.txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
            Me.txtProcura.Focus()
        End If
        If Me.A3.Checked = True Then
            Me.txtProcura.Clear()
            Me.txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
            Me.txtProcura.Focus()
        End If

    End Sub

    Private Sub MostraTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A4.CheckedChanged
        If Me.A4.Checked = True Then
            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()


            Dim Sql As String = "SELECT Producao.OrdemProducao, Producao.DataOrdem, Producao.Solicitante, Producao.Motivo, Producao.Confirmado FROM Producao WHERE Producao.Empresa = " & CodEmpresa


            Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
            Dim Da As New OleDb.OleDbDataAdapter(CMD)

            Dim ds As New DataSet
            Da.Fill(ds, "Table")

            Me.DgvItem.DataSource = ds.Tables("Table").DefaultView


            Da.Dispose()
            CNN.Close()
        End If
    End Sub



    Private Sub DgvItem_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellDoubleClick

        If My.Forms.Producao.Visible = True Then
            My.Forms.Producao.OrdemProducao.Text = Me.DgvItem.CurrentRow.Cells(0).Value
            My.Forms.Producao.LocalizarDados()
            Me.Close()
            Me.Dispose()
        End If

    End Sub


End Class