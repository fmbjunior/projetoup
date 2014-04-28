Public Class ProcuraFormaPgto

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2
    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged
        If Me.A1.Checked = True Then
            Me.TxtProcura.Enabled = True
            Me.TxtProcura.Focus()
        End If
        If Me.A2.Checked = True Then
            Me.TxtProcura.Enabled = True
            Me.TxtProcura.Focus()
        End If
        If Me.A3.Checked = True Then
            Buscar(3)
        End If
    End Sub
    Private Sub Buscar(ByVal Opt As Integer)

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Select Case Opt
            Case 1
                Sql = "Select FormaPgto.CodFormaPgto, FormaPgto.Descrição, FormaPgto.DiasParcelamento From FormaPgto Where CodFormaPgto = " & Me.TxtProcura.Text & " And Inativo = False Order by FormaPgto.Descrição"
            Case 2
                Sql = "Select FormaPgto.CodFormaPgto, FormaPgto.Descrição, FormaPgto.DiasParcelamento From FormaPgto Where FormaPgto.Descrição like '%" & Me.TxtProcura.Text & "%' And Inativo = False Order by FormaPgto.Descrição"
            Case 3
                Sql = "Select FormaPgto.CodFormaPgto, FormaPgto.Descrição, FormaPgto.DiasParcelamento From FormaPgto Where Inativo = False Order by FormaPgto.Descrição"
        End Select

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        'Me.Lista.DataSource = ds.Tables("Table").DefaultView
        DgvItem.DataSource = ds.Tables("Table").DefaultView
        da.Dispose()
        Cnn.Close()
        Me.TxtProcura.Clear()

    End Sub
    Private Sub TxtProcura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtProcura.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.A1.Checked = True Then
                Buscar(1)
                DgvItem.Focus()
            End If
            If Me.A2.Checked = True Then
                Buscar(2)
                DgvItem.Focus()
            End If
        End If
    End Sub
    Private Sub ProcuraFormaPgto_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.TxtProcura.Focus()
    End Sub
    Private Sub DgvItem_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvItem.CellDoubleClick
        If My.Forms.PedidoVenda.Visible = True Then
            My.Forms.PedidoVenda.ParcelamentoFixo.Text = Me.DgvItem.CurrentRow.Cells(0).Value
            Me.Close()
            Me.Dispose()
        End If

        If PedidoOS.Visible = True Then
            PedidoOS.ParcelamentoFixo.Text = Me.DgvItem.CurrentRow.Cells(0).Value
            Me.Close()
            Me.Dispose()
        End If

        If My.Forms.SellShoes.Visible = True Then
            My.Forms.SellShoes.FormaPgto.Text = Me.DgvItem.CurrentRow.Cells(0).Value
            Me.Close()
            Me.Dispose()
        End If
    End Sub

    Private Sub DgvItem_KeyDown(sender As Object, e As KeyEventArgs) Handles DgvItem.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim xRet(4)
            xRet(0) = Me.DgvItem.CurrentRow.Cells("gCodigo").Value
            xRet(1) = Me.DgvItem.CurrentRow.Cells("gDescricao").Value
            xRet(2) = Me.DgvItem.CurrentRow.Cells("gDiasParcelamento").Value

            If My.Forms.PedidoVenda.Visible = True Then
                My.Forms.PedidoVenda.ParcelamentoFixo.Text = xRet(0)

                Me.Close()
                Me.Dispose()
            End If

            If PedidoOS.Visible = True Then
                PedidoOS.ParcelamentoFixo.Text = xRet(0)
                PedidoOS.ParcelamentoFixoDesc.Text = xRet(1)
                Me.Close()
                Me.Dispose()
            End If

            If My.Forms.SellShoes.Visible = True Then
                My.Forms.SellShoes.FormaPgto.Text = xRet(0)
                Me.Close()
                Me.Dispose()
            End If
        End If
    End Sub
End Class