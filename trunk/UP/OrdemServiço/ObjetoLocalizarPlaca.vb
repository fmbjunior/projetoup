Public Class ObjetoLocalizarPlaca
    Dim erro As Integer
    Dim bs As BindingSource
    Dim ds As New DataSet
    Private Sub ObjetoLocalizar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.txtprocura.Clear()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim sql As String
        sql = "SELECT ObjetosCad.CodObjeto, ObjetosCad.codigoCliente, Clientes.Nome, ObjetosCad.Veiculo, ObjetosCad.Placa, ObjetosCad.DataCadastro FROM ObjetosCad INNER JOIN Clientes ON ObjetosCad.codigoCliente = Clientes.Codigo;"

        Dim CMD As New OleDb.OleDbCommand(sql, CNN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet
        Da.Fill(ds, "Table")

        'Crio um BindingSource
        bs = New BindingSource()
        'Conecto meu BindinSource com meu DataSet
        bs.DataSource = ds.Tables(0).DefaultView

        'Preencho meu DataGridView com meu BindinSource
        Me.DgvItem.DataSource = bs
        Da.Dispose()
        CNN.Close()






        'If My.Forms.PedidoOS.Visible = True Then
        '    Me.txtprocura.ReadOnly = True
        '    LocalizaDados()
        'Else
        '    Me.txtprocura.ReadOnly = False
        '    Me.txtprocura.Focus()
        'End If
    End Sub
    ' CSEH: <Try Catch>
    Public Sub LocalizaDados()
        Try

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

            CNN.Open()

            Dim sql As String

            sql = "SELECT ObjetosCad.CodObjeto, ObjetosCad.codigoCliente, Clientes.Nome, ObjetosCad.Veiculo, ObjetosCad.Placa, ObjetosCad.DataCadastro FROM ObjetosCad INNER JOIN Clientes ON ObjetosCad.codigoCliente = Clientes.Codigo WHERE (((ObjetosCad.Placa) Like '%" & Me.txtprocura.Text & "%'));"



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
                    MsgBox("Registro não encontrada ou não há informações que atendam ao critério de pesquisa", MsgBoxStyle.Critical, "Atenção")
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
                If My.Forms.PedidoOS.Visible = False Then
                    With My.Forms.ObjetosCad
                        .CodObjeto.Text = DR.Item("CodObjeto")
                        .Veiculo.Text = DR.Item("Veiculo") & ""
                        .placa.Text = DR.Item("placa") & ""
                        .km.Text = DR.Item("km") & ""
                        .cor.Text = DR.Item("cor") & ""
                        .obs.Text = DR.Item("obs") & ""
                        .DataCadastro.Text = DR.Item("Datacadastro") & ""
                        .renavan.Text = DR.Item("Renavan") & ""
                        .CódigoCliente.Text = Me.DgvItem.CurrentRow.Cells("idCliente").Value
                        .NomeCliente.Text = Me.DgvItem.CurrentRow.Cells("Nome").Value
                    End With
                Else
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


    Private Sub txtprocura_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprocura.Leave
        LocalizaDados()
    End Sub

    Private Sub txtprocura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprocura.TextChanged
        bs.Filter = "Placa like '%" & txtprocura.Text & "%'"
        If Len(txtprocura.Text) > 0 Then
            Me.DgvItem.DataSource = bs
        Else
            bs.Filter = "Placa like ''"
        End If

    End Sub
End Class