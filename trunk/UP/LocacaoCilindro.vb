Public Class LocacaoCilindro
    Dim idItem As Integer = 0
    Private Sub butFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click


        If Me.txtCodigoCliente.Text = "" Then
            MsgBox("O codigo do cliente não pode ser nulo")
            Return

        ElseIf Me.txtCodigoProduto.Text = "" Then
            MsgBox("O codigo do produto não pode ser nulo")
            Return

        ElseIf Me.txtQuantidade.Text = "" Then
            MsgBox("A Quantidade do produto não pode ser nulo")
            Return
        ElseIf Me.txtDataMovimentacao.Text = "" Then
            MsgBox("A Data de movimentação do produto não pode ser nulo")
            Return
        ElseIf Me.txtcontrole.Text = "" Then
            MsgBox("O controle do pedido não pode ser nulo")
            Return
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))




        CNN.Open()



        Dim Sql As String = "INSERT INTO LocCilindro (LocCodigoCliente, LocCodigoProduto, LocQtde, LocData, LocControle) VALUES (@1, @2, @3, @4, @5)"
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", (Me.txtCodigoCliente.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", (Me.txtCodigoProduto.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@3", (Me.txtQuantidade.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@4", (Me.txtDataMovimentacao.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@5", (Me.txtcontrole.Text)))

        Try
            cmd.ExecuteNonQuery()
            CNN.Close()

            MsgBox("Registro adicionado com sucesso", 64, "Validador de Dados")
            GerarLog(Me.Text, AçãoTP.Adicionou, Me.txtCodigoCliente.Text)
            AtGrade()

            Me.txtCodigoProduto.Clear()
            Me.txtProduto.Clear()
            Me.txtQuantidade.Clear()
            Me.txtDataMovimentacao.Clear()
            Me.txtcontrole.Clear()
            Me.txtCodigoProduto.Focus()

        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validador de Dados")
        End Try
    End Sub
    Public Sub AtGrade()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim sql As String = "SELECT LocCilindro.locid, loccilindro.loccodigoproduto, loccilindro.locqtde,Produtos.Descrição, loccilindro.locdata, loccilindro.locControle FROM LocCilindro INNER JOIN Produtos ON LocCilindro.Loccodigoproduto = Produtos.CodigoProduto WHERE LocCilindro.LocCodigoCliente=" & NzZero(Me.txtCodigoCliente.Text) & " Order By LocCilindro.LocData DESC"


        Dim CMD As New OleDb.OleDbCommand(sql, CNN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet

        Try


            Da.Fill(ds, "Table")

            Me.dgv.DataSource = ds.Tables("Table").DefaultView
            Da.Dispose()
            CNN.Close()
        Catch ex As Exception
            Da.Dispose()
            CNN.Close()
        End Try
    End Sub

    Private Sub butLocalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butLocalizar.Click
        My.Forms.ClientesProcura.ShowDialog()
        If Not String.IsNullOrEmpty(Me.txtCodigoCliente.Text) Then
            AtGrade()
        End If
        Me.txtCodigoProduto.Focus()
    End Sub

    Private Sub txtCodigoProduto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoProduto.Leave
        LocalizaProduto()
    End Sub
    Public Sub LocalizaProduto()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select CodigoProduto,Descrição from Produtos where CodigoProduto = " & Me.txtCodigoProduto.Text & " And Inativo = False and Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows = True Then

            Me.txtProduto.Text = DR.Item("Descrição") & ""

        Else
            MsgBox("Item não encontrado, verifique....", 64, "Validação de Dados")
            CNN.Close()
            Exit Sub
        End If
        CNN.Close()


    End Sub

    Private Sub txtCodigoProduto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoProduto.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ProcuraProduto.ShowDialog()
        End If
    End Sub

    Private Sub txtCodigoCliente_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoCliente.Leave
        If String.IsNullOrEmpty(Me.txtCodigoCliente.Text) Then
            Me.txtRazaoSocial.Text = ""
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click

        'Faz uma pergunta antes, para que o user tenha certeza da ação.
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))


        If MessageBox.Show("Deseja excluir ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Try
                CNN.Open()

                Dim Sql As String
                Sql = "Delete * from loccilindro where locid=" & idItem

                Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

                cmd.ExecuteNonQuery()
                CNN.Close()
                AtGrade()

            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                CNN.Close()
            End Try
        End If
      
    End Sub

    Private Sub dgv_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellClick
        'Quando for clicado em qualquer celula passa o valor da linha ID atual para a vareavel IDITEM.
        idItem = Me.dgv.CurrentRow.Cells("IDp").Value
    End Sub

    Private Sub dgv_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgv.SelectionChanged
        'toda a vez que existir uma atualização no grid o mesmo é seleciona na primeira linha.
        Try
            idItem = Me.dgv.CurrentRow.Cells("IDp").Value

        Catch ex As Exception

        End Try
    End Sub

    Private Sub butImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butImprimir.Click
        Dim rel As New RelCilindro
        rel.shCod = Me.txtCodigoCliente.Text
        rel.Document.Printer.PrinterName = ""
        rel.lblempresa.Text = NomEmpresa
        ViewReport.VerRelat.Document = rel.Document
        rel.Run()
        ViewReport.ShowDialog()
    End Sub
End Class