Imports System.Data.OleDb

Public Class FornecedorCotacao
    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2
    Dim vConfirmado As Boolean
    Dim ds As New DataSet
    Dim vID As Integer = 0

    Private Sub FornecedorCotacao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        atgrid()



    End Sub
    Public Sub atgrid()
        If ds.Tables.Count <> 0 Then
            ds.Clear()
        End If


        Dim CNN As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)

        CNN.Open()

        Dim Sql As String = "SELECT FornecedorApOrdem.ID, FornecedorApOrdem.CodigoFornecedor, Fornecedor.RazãoSocial, FornecedorApOrdem.Valor, FornecedorApOrdem.Condicaopagamento, FornecedorApOrdem.Ap FROM FornecedorApOrdem INNER JOIN Fornecedor ON FornecedorApOrdem.CodigoFornecedor = Fornecedor.CódigoFornecedor WHERE FornecedorApOrdem.Empresa=" & CodEmpresa & " and CodigoOrdComp=" & My.Forms.CompraCtrPedido.Id.Text

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)


        Da.Fill(ds, "Table")

        Me.dgitem.DataSource = ds.Tables("Table").DefaultView

        Da.Dispose()
        CNN.Close()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        If Me.CodigoFornecedor.Text = "" Then
            Me.CodigoFornecedor.Focus()
            Exit Sub
        End If

        Dim Con As New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        Dim sql As String
        Con.Open()

        sql = "INSERT INTO FornecedorApOrdem (CodigoOrdComp, CodigoFornecedor, Valor, Condicaopagamento, Empresa) VALUES (@1, @2, @3, @4, @5)"
        Dim cmd As New OleDb.OleDbCommand(sql, Con)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", My.Forms.CompraCtrPedido.Id.Text))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.CodigoFornecedor.Text, 1)))
        cmd.Parameters.Add(New OleDbParameter("@3", NzZero(Me.Valor.Text)))
        cmd.Parameters.Add(New OleDbParameter("@4", Nz(Me.Condicaopagamento.Text, 1)))
        cmd.Parameters.Add(New OleDbParameter("@5", CodEmpresa))

        Try
            If ConnectionState.Open Then
                cmd.ExecuteNonQuery()
                Con.Close()
            Else
                Con.Open()
                cmd.ExecuteNonQuery()
                Con.Close()
            End If

            atgrid()
            Me.CodigoFornecedor.Clear()
            Me.DescricaoFornecedor.Clear()
            Me.Valor.Clear()
            Me.Condicaopagamento.Clear()
            Me.CodigoFornecedor.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, 64, TituloMsgbox)
        End Try

    End Sub

    Private Sub CodigoFornecedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoFornecedor.KeyDown
        If e.KeyCode = Keys.F5 Then
            RetornoProcura = String.Empty
            My.Forms.TelaProcuraForCtrlPedido.ShowDialog()
            Me.CodigoFornecedor.Text = RetornoProcura
            Me.CodigoFornecedor.Focus()
        End If
    End Sub

    Private Sub CodigoFornecedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoFornecedor.TextChanged

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If vID <> 0 Then
            Dim CNN As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
            CNN.Open()


            Dim CMD As New OleDb.OleDbCommand

            Try
                CMD.Connection = CNN
                CMD.CommandText = "UPDATE FornecedorApOrdem SET FornecedorApOrdem.Ap = FALSE WHERE (((FornecedorApOrdem.CodigoOrdComp)=" & My.Forms.CompraCtrPedido.Id.Text & ") AND ((FornecedorApOrdem.Empresa)=" & CodEmpresa & "));"
                CMD.ExecuteNonQuery()

                CMD.CommandText = "UPDATE FornecedorApOrdem SET FornecedorApOrdem.Ap = True WHERE (((FornecedorApOrdem.ID)=" & vID & ") AND ((FornecedorApOrdem.Empresa)=" & CodEmpresa & "));"
                CMD.ExecuteNonQuery()



            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try




        End If


        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub AtivarApontar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtivarApontar.Click
        Me.dgitem.CurrentRow.Cells("Aprovar").Value = True
    End Sub

    Private Sub CodigoFornecedor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CodigoFornecedor.Validated
        If String.CompareOrdinal(Me.CodigoFornecedor.Text, Me.CodigoFornecedor.TextoAntigo) Then
            achaFor()
        End If
    End Sub
    Private Sub achaFor()
        If Me.CodigoFornecedor.Text = "" Then
            Me.DescricaoFornecedor.Text = ""
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        CNN.Open()

        Dim Sql As String = "Select CódigoFornecedor,RazãoSocial,Empresa from Fornecedor where CódigoFornecedor = " & Me.CodigoFornecedor.Text & " And Empresa=" & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.DescricaoFornecedor.Text = DR.Item("RazãoSocial") & ""

        Else
            MsgBox("Verifique os dados do fornecedor, ou fornecedor não existe no cadastro.", 64, TituloMsgbox)
            CNN.Close()
            Exit Sub
        End If
        DR.Close()
        CNN.Close()
    End Sub

    Private Sub dgitem_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgitem.CellClick
        Dim ss As Integer
        Dim iLine As Integer
        ss = Me.dgitem.CurrentCell.ColumnIndex
        iLine = Me.dgitem.CurrentRow.Index
      


        If Me.dgitem.CurrentCell.ColumnIndex = 5 Then
            Me.dgitem.CurrentRow.Cells(ss).Value = True
            vID = Me.dgitem.CurrentRow.Cells("ID").Value
        Else
        End If

        If Me.dgitem.CurrentCell.ColumnIndex = 5 Then
            For i As Integer = 0 To dgitem.Rows.Count - 1
                If dgitem.Rows(i).Index <> iLine Then
                    dgitem.Rows(i).Cells(5).Value = False
                Else
                    My.Forms.CompraCtrPedido.Fornecedor.Text = Me.dgitem.CurrentRow.Cells(1).Value
                    My.Forms.CompraCtrPedido.FornecedorDesc.Text = Me.dgitem.CurrentRow.Cells(2).Value
                    My.Forms.CompraCtrPedido.ValorPedido.Text = Me.dgitem.CurrentRow.Cells(3).Value
                End If
            Next
        End If
        'My.Forms.Apontamento.AtGrid()



    End Sub

    Private Sub dgitem_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
End Class