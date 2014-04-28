Public Class ProcuraPropriedades
    Dim bs As BindingSource
    Dim xRet(4)
    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub DgvItem_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DgvItem.KeyDown

        If e.KeyCode = Keys.Return Then
            If (DgvItem.RowCount > 0) Then

                xRet(0) = Me.DgvItem.CurrentRow.Cells("gCodigo").Value
                xRet(1) = Me.DgvItem.CurrentRow.Cells("gDescricao").Value
                xRet(2) = Me.DgvItem.CurrentRow.Cells("gUF").Value
                xRet(3) = Me.DgvItem.CurrentRow.Cells("gInscricao").Value


                If PedidoOS.Visible Then
                    PedidoOS.Propriedade.Text = xRet(0)
                    PedidoOS.PropriedadeDesc.Text = xRet(1)
                    PedidoOS.propUF.Text = xRet(2)
                    PedidoOS.PropriedadeIncrição.Text = xRet(3)

                    Me.Close()
                    Me.Dispose()
                End If
            End If
        End If
    End Sub
    Private Sub ProcuraPropriedades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        Cnn.Open()

        Dim CMD As New OleDb.OleDbCommand()
        With CMD
            .Connection = Cnn
            .CommandTimeout = 0
            If My.Forms.NFiscalServiço.Visible = True Then
                .CommandText = "SELECT id,nomepropriedade,estado,inscricao FROM Propriedades WHERE Cliente = " & My.Forms.NFiscalServiço.Cliente.Text
            ElseIf My.Forms.PedidoVenda.Visible = True Then
                .CommandText = "SELECT id,nomepropriedade,estado,inscricao From Propriedades WHERE Cliente = " & My.Forms.PedidoVenda.CódigoCliente.Text
            ElseIf PedidoOS.Visible = True Then
                .CommandText = "SELECT id,nomepropriedade,estado,inscricao FROM Propriedades WHERE Cliente = " & PedidoOS.CódigoCliente.Text
            End If
            .CommandType = CommandType.Text
        End With

        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet
        Da.Fill(ds, "Table")

        'Crio um BindingSource
        bs = New BindingSource()
        'Conecto meu BindinSource com meu DataSet
        bs.DataSource = ds.Tables(0).DefaultView
        Me.DgvItem.DataSource = bs
        Da.Dispose()
        Cnn.Close()

        DgvItem.Focus()

    End Sub

    Private Sub DgvItem_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvItem.CellDoubleClick
        If (DgvItem.RowCount > 0) Then

            xRet(0) = Me.DgvItem.CurrentRow.Cells("gCodigo").Value
            xRet(1) = Me.DgvItem.CurrentRow.Cells("gDescricao").Value
            xRet(2) = Me.DgvItem.CurrentRow.Cells("gUF").Value
            xRet(3) = Me.DgvItem.CurrentRow.Cells("gInscricao").Value


            If PedidoOS.Visible Then
                PedidoOS.Propriedade.Text = xRet(0)
                PedidoOS.PropriedadeDesc.Text = xRet(1)
                PedidoOS.propUF.Text = xRet(2)
                PedidoOS.PropriedadeIncrição.Text = xRet(3)

                Me.Close()
                Me.Dispose()
            End If

        End If
    End Sub

    Private Sub DgvItem_SelectionChanged(sender As Object, e As EventArgs) Handles DgvItem.SelectionChanged
        Try
            xRet(0) = Me.DgvItem.CurrentRow.Cells("gCodigo").Value
            xRet(1) = Me.DgvItem.CurrentRow.Cells("gDescricao").Value
            xRet(2) = Me.DgvItem.CurrentRow.Cells("gUF").Value
            xRet(3) = Me.DgvItem.CurrentRow.Cells("gInscricao").Value

        Catch ex As Exception

        End Try
    End Sub
End Class