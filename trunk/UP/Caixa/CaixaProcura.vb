Public Class CaixaProcura

    Private fControl As Control

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub CarregaLista()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        Dim Sql As String = String.Empty
        Sql = "Select CaixaCadastro.CodigoCaixa, CaixaCadastro.CaixaNome From CaixaCadastro Where CaixaCadastro.Empresa = " & CodEmpresa & " And CaixaCadastro.Inativo = false Order by CaixaCadastro.CaixaNome"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Lista.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        Cnn.Close()


    End Sub


   

    Private Sub CaixaProcura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If My.Forms.CaixaAtivarDesativar.Visible = True Then
            fControl = My.Forms.CaixaAtivarDesativar.btFindCaixa
        End If

        Dim pt As Point
        Dim scrPt As Point
        pt = New Point(fControl.Left + fControl.Width, fControl.Top + fControl.Height)
        scrPt = New Point(fControl.FindForm().Left + pt.X + 15, fControl.FindForm().Top + pt.Y + 5)
        CenterToScreen()
        Me.Location = scrPt



        CarregaLista()
    End Sub

    Private Sub Lista_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellDoubleClick
        Dim vID As String = Me.Lista.CurrentRow.Cells("cCodigoCaixa").Value & ""

        If My.Forms.CaixaAtivarDesativar.Visible = True Then My.Forms.CaixaAtivarDesativar.CodigoCaixa.Text = vID



        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub Lista_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Lista.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim vID As String = Me.Lista.CurrentRow.Cells("cCodigoCaixa").Value & ""

            If My.Forms.CaixaAtivarDesativar.Visible = True Then My.Forms.CaixaAtivarDesativar.CodigoCaixa.Text = vID



            Me.Close()
            Me.Dispose()

        End If
    End Sub
End Class