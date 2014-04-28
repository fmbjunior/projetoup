Public Class ClienteRegiaoAchar

    Private Sub ClienteRegiaoAchar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregaRegiao()
    End Sub

    Private Sub CarregaRegiao()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT Regiao.IdRegiao, Regiao.RegiaoDesc FROM (Municipio INNER JOIN RegiaoCidade ON Municipio.CodMunicipio = RegiaoCidade.CodCidade) INNER JOIN Regiao ON RegiaoCidade.IdRegiao = Regiao.IdRegiao WHERE (((Municipio.CodMunicipio)='" & PegaVlrCombo(My.Forms.Clientes.cMun, TpRetornoCBO.Não) & "'));"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Lista.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        Cnn.Close()
        Me.Lista.Focus()

    End Sub

    Private Enum TpRetornoCBO
        Não = 0
        Sim = 1
    End Enum
    Private Function PegaVlrCombo(ByVal Cbo As CBOAutoCompleteFocus.CboFocus, ByVal Retorna_Descrição As TpRetornoCBO)

        Dim Retorno As String = ""
        If Cbo.Text = "" Then
            Retorno = ""

        Else
            Cbo.SelectedIndex = Cbo.FindStringExact(Cbo.Text & "")
            If Retorna_Descrição = TpRetornoCBO.Não Then
                Retorno = CType(Cbo.SelectedItem, cboItemData).ItemData
            Else
                Retorno = CType(Cbo.SelectedItem, cboItemData).Name
            End If
        End If
        Return Retorno

    End Function

    Private Sub Lista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellDoubleClick
        Dim vID As Integer
        vID = CInt(Me.Lista.CurrentRow.Cells(0).Value)

        If My.Forms.Clientes.Visible = True Then My.Forms.Clientes.IdRegiao.Text = vID

        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Lista_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Lista.KeyDown

        If e.KeyCode = Keys.Enter Then

            Try

                Dim vID As Integer
                vID = CInt(Me.Lista.CurrentRow.Cells(0).Value)

                If My.Forms.Clientes.Visible = True Then My.Forms.Clientes.IdRegiao.Text = vID

                Me.Close()
                Me.Dispose()

            Catch ex As Exception
                Select Case Err.Number
                    Case 91
                        MessageBox.Show("Região não encontrada ou a lista esta vazia", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Case Else
                        MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select
                Me.Close()
                Me.Dispose()
            End Try

        End If
    End Sub

End Class