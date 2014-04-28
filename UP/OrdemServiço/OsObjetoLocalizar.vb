Imports System.Data.OleDb

Public Class OsObjetoLocalizar
    Dim erro As Integer
    Private Sub ObjetoLocalizar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LocalizaDados()
        EncheLabelObjeto(Me)

    End Sub
    Public Sub LocalizaDados()
        Try

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

            CNN.Open()

            Dim sql As String

            sql = "SELECT ObjetosCad.CodObjeto, ObjetosCad.Veiculo, ObjetosCad.Placa, ObjetosCad.codigoCliente, Clientes.Nome, ObjetosCad.DataCadastro FROM ObjetosCad INNER JOIN Clientes ON ObjetosCad.codigoCliente = Clientes.Codigo WHERE (((ObjetosCad.codigoCliente) =" & PedidoOS.CódigoCliente.Text & "));"

            Dim CMD As New OleDb.OleDbCommand(sql, CNN)
            Dim Da As New OleDb.OleDbDataAdapter(CMD)

            Dim ds As New DataSet
            Da.Fill(ds, "Table")

            Me.DgvItem.DataSource = ds.Tables("Table").DefaultView

            Da.Dispose()
            CNN.Close()


        Catch oE As System.Exception
            Select Case Err.Number
                Case 5
                    MsgBox("Veículo não cadastrado no sistema", MsgBoxStyle.Critical, "Atenção")
                Case Else
                    MsgBox(oE.Message)
            End Select
        End Try
    End Sub


    Private Sub DgvItem_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellDoubleClick
        Dim xRet
        xRet = Me.DgvItem.CurrentRow.Cells(0).Value

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String

        Sql = "SELECT *  From ObjetosCad Where CodObjeto =" & xRet


        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader
        Try
            CNN.Open()
            DR = CMD.ExecuteReader
            DR.Read()

            If DR.HasRows Then
                If My.Forms.PedidoOS.Visible = True Then
                    With My.Forms.PedidoOS
                        .codigoObjeto.Text = DR.Item("CodObjeto")
                        .Veiculo.Text = DR.Item("Veiculo") & ""
                        .Placa.Text = DR.Item("placa") & ""
                        .km.Text = DR.Item("km") & ""
                        .obs.Text = DR.Item("obs") & ""
                    End With
                End If
            End If

            DR.Close()
            CNN.Close()
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            Throw ex
        Finally
            CNN.Close()
        End Try
    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Dim VarIdColuna As Integer
    Private Sub Achar()

        Dim texto As String = Nothing

        If txtProcura.Text <> String.Empty Then
            For Each linha As DataGridViewRow In DgvItem.Rows
                For Each celula As DataGridViewCell In DgvItem.Rows(linha.Index).Cells
                    If celula.ColumnIndex = VarIdColuna Then
                        texto = celula.Value.ToString.ToLower
                        If texto.Contains(txtProcura.Text.ToLower) Then
                            Me.DgvItem.Rows(celula.RowIndex).Selected = True

                            Dim Row As Integer = Me.DgvItem.Rows(celula.RowIndex).Index
                            Me.DgvItem.FirstDisplayedScrollingRowIndex = Row

                            Exit Sub
                        End If
                    End If
                Next
            Next
        End If
    End Sub


    Private Sub txtProcura_Leave(sender As Object, e As EventArgs) Handles txtProcura.Leave
        Achar()
    End Sub

    Private Sub DgvItem_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvItem.ColumnHeaderMouseClick
        VarIdColuna = e.ColumnIndex
    End Sub
End Class