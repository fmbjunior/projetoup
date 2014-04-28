Public Class PedidoCompraImportar
    Private Sub AceitaSomenteNumeros_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim nonNumberEntered As Boolean
        nonNumberEntered = True
        If (e.KeyChar >= Convert.ToChar(48) AndAlso e.KeyChar <= Convert.ToChar(57)) OrElse e.KeyChar = Convert.ToChar(8) OrElse e.KeyChar = Convert.ToChar(44) Then
            nonNumberEntered = False
        End If
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control
            ' since it is non-numerical. 
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        'Trata o evento quando for prescionado a tecla enter.

        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
            If Me.dgv.CurrentCell.ColumnIndex <> 6 Then
                SendKeys.Send("{Tab}")
                Return True
            End If

        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub PedidoCompraImportar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Aqui definimos as nossa datagridview.
        Dim tbc As DataGridViewTextBoxColumn 'Importa a coluna textbox


        'Definir alguma propriedades da coluna TextBox
        tbc = New DataGridViewTextBoxColumn() '0
        tbc.HeaderText = "ID"
        tbc.Name = "ID"
        tbc.Width = 70
        tbc.Visible = False
        Me.dgv.Columns.Add(tbc)

        tbc = New DataGridViewTextBoxColumn() '1
        tbc.HeaderText = "CodigoCompra"
        tbc.Name = "CodigoCompra"
        tbc.Width = 70
        tbc.Visible = False
        Me.dgv.Columns.Add(tbc)

        tbc = New DataGridViewTextBoxColumn() '2
        tbc.HeaderText = "Codigo"
        tbc.Name = "CodigoProduto"
        tbc.Width = 70
        Me.dgv.Columns.Add(tbc)

        tbc = New DataGridViewTextBoxColumn() '3
        tbc.HeaderText = "Tam"
        tbc.Name = "tam"
        tbc.Width = 70
        Me.dgv.Columns.Add(tbc)

        tbc = New DataGridViewTextBoxColumn() '4
        tbc.HeaderText = "Descrição"
        tbc.Name = "descricao"
        tbc.Width = 300
        Me.dgv.Columns.Add(tbc)

        tbc = New DataGridViewTextBoxColumn() '5
        tbc.HeaderText = "Qtd Resta"
        tbc.Name = "qtdpedida"
        tbc.Width = 70
        tbc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgv.Columns.Add(tbc)

        tbc = New DataGridViewTextBoxColumn() '6
        tbc.HeaderText = "Qtd Entregue"
        tbc.Name = "qtdentregue"
        tbc.Width = 90
        tbc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgv.Columns.Add(tbc)

        tbc = New DataGridViewTextBoxColumn() '7
        tbc.HeaderText = ""
        tbc.Name = "vunit"
        tbc.Width = 70
        tbc.Visible = False
        Me.dgv.Columns.Add(tbc)

        tbc = New DataGridViewTextBoxColumn() '8
        tbc.HeaderText = ""
        tbc.Name = "vtotal"
        tbc.Width = 70
        tbc.Visible = False
        Me.dgv.Columns.Add(tbc)

        tbc = New DataGridViewTextBoxColumn() '9
        tbc.HeaderText = ""
        tbc.Name = "vcfop"
        tbc.Width = 70
        tbc.Visible = False
        Me.dgv.Columns.Add(tbc)

        tbc = New DataGridViewTextBoxColumn() '10
        tbc.HeaderText = ""
        tbc.Name = "qtdentregue"
        tbc.Width = 70
        tbc.Visible = False
        Me.dgv.Columns.Add(tbc)

       
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim sql As String = "SELECT PedidoCompraItem.Id, PedidoCompraItem.CompraInterno, PedidoCompraItem.CodigoProduto, PedidoCompraItem.Tamanho, Produtos.Descrição, [qtd]-[qtdentregue] AS QtdResta, PedidoCompraItem.Qtd, PedidoCompraItem.QtdEntregue, PedidoCompraItem.ValorUnitario, PedidoCompraItem.TotalProduto, PedidoCompraItem.CFOP, PedidoCompraItem.SeqNf FROM PedidoCompraItem INNER JOIN Produtos ON PedidoCompraItem.CodigoProduto = Produtos.CodigoProduto WHERE (((PedidoCompraItem.CompraInterno)=" & RetornoProcura & ") AND (([qtd]-[qtdentregue])>0));"
        Dim ocmd As New OleDb.OleDbCommand(sql, CNN)

        Dim odr As OleDb.OleDbDataReader
        odr = ocmd.ExecuteReader

        Dim row As New DataGridViewRow
        Dim cVlr As Double = 0
        While odr.Read()
            'preenche o grid com alguns dados
            Dim row0 As String() = {odr.Item("id"), odr.Item("comprainterno"), odr.Item("CodigoProduto"), odr.Item("tamanho"), odr.Item("Descrição"), FormatNumber(odr.Item("qtdResta"), 3), "0,000", odr.Item("ValorUnitario"), odr.Item("TotalProduto"), odr.Item("CFOP"), odr.Item("qtdentregue")}
            'adiciona as linhas
            With Me.dgv.Rows
                .Add(row0)
            End With
        End While

        If Me.dgv.RowCount = 0 Then
            Me.ButtonX1.Enabled = False
        Else
            Me.ButtonX1.Enabled = True
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim v_id As Integer
        Dim v_CodigoProduto As Integer
        Dim v_CodigoCompra As Integer
        Dim v_Tam As String
        Dim v_Qtd As Double
        Dim v_QtdEnt As Double
        Dim v_ValorUnit As Double
        Dim v_Total As Double
        Dim v_cfop As String

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim MyTrans As OleDb.OleDbTransaction = CNN.BeginTransaction
        Dim cmd As OleDb.OleDbCommand
        Dim cmd1 As OleDb.OleDbCommand
        Dim sSql As String
        Dim sUpd As String


        Try
            For rowIndex As Integer = 0 To dgv.Rows.Count - 1 Step 1
                If dgv.Item(6, rowIndex).Value > 0 Then
                    v_id = dgv.Item(0, rowIndex).Value
                    v_CodigoProduto = dgv.Item(2, rowIndex).Value
                    v_CodigoCompra = My.Forms.SellShoesCompra.CompraInterno.Text
                    v_Tam = dgv.Item(3, rowIndex).Value
                    v_Qtd = dgv.Item(6, rowIndex).Value
                    v_ValorUnit = dgv.Item(7, rowIndex).Value
                    v_Total = v_Qtd * v_ValorUnit
                    v_cfop = dgv.Item(9, rowIndex).Value
                    v_QtdEnt = dgv.Item(10, rowIndex).Value
                    v_QtdEnt += v_Qtd



                    sSql = "INSERT INTO ItensCompra (CompraInterno,CodigoProduto,Qtd,ValorUnitario,TotalProduto,cfop,Tamanho,IdItemPedidoCompra) VALUES ('" & v_CodigoCompra & "', '" & v_CodigoProduto & "','" & v_Qtd & "','" & v_ValorUnit & "','" & v_Total & "' ," & v_cfop & ",'" & v_Tam & "','" & v_id & "')"
                    sUpd = "Update PedidoCompraItem SET  QtdEntregue = '" & v_QtdEnt & "' where id=" & v_id
                    cmd = New OleDb.OleDbCommand(sSql, CNN, MyTrans)
                    cmd1 = New OleDb.OleDbCommand(sUpd, CNN, MyTrans)
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()
                End If
            Next rowIndex

            MyTrans.Commit()
            MsgBox("Importação feita com sucesso!", 48, "Atenção")
            My.Forms.SellShoesCompra.AtGrade()
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Houve um erro na importação, tente novamente", 48, "Erro na Importação")
            MyTrans.Rollback()
        Finally
            CNN.Close()
        End Try


    End Sub
    Private Sub dgv_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        'Quando terminar de editar faço a formatação da celula
        Try
            Me.dgv(6, e.RowIndex).Value = String.Format("{0:N3}", Convert.ToDouble(Me.dgv(6, e.RowIndex).Value))

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEnter
        If Me.dgv.CurrentCell.ColumnIndex = 6 Then
            Me.dgv.BeginEdit(True)
        End If
    End Sub
    Private Sub dgv_CellParsing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellParsingEventArgs) Handles dgv.CellParsing
        If dgv.CurrentCell.IsInEditMode Then
            Me.dgv.BeginEdit(True)
        End If
    End Sub
    Private Sub dgv_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgv.CellValidating
        'Validadndo a entrada na celula
        Dim celValorResta As Double
        Dim celTotal As Double
        'Dim c As String

        'Aqui valido a coluna QtdEntregue.
        If dgv.Columns(e.ColumnIndex).Name = "qtdentregue" Then
            celValorResta = Double.Parse(dgv.CurrentRow.Cells("qtdpedida").Value)
            celTotal = celValorResta - Double.Parse(NzZero(e.FormattedValue.ToString))
            If celTotal < 0 Then 'se 'caso contrario mensagem de advertencia sobre a data
                MsgBox("ATENÇÃO!!! O valor não pode ser maior que [QTD RESTA]", 48, "Validação de dados")
                e.Cancel = True
                'SendKeys.Send("{ESC}")

            End If
        End If
    End Sub
    Private Sub dgv_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgv.EditingControlShowing
        'As declarações AddHandler e RemoveHandler permitem que você iniciar
        'e parar o tratamento de eventos para um evento específico a qualquer 
        'momento durante a execução do programa.
        RemoveHandler e.Control.KeyPress, AddressOf AceitaSomenteNumeros_KeyPress

        If CInt((DirectCast((sender), System.Windows.Forms.DataGridView).CurrentCell.ColumnIndex)) = 6 Then
            AddHandler e.Control.KeyPress, AddressOf AceitaSomenteNumeros_KeyPress
        End If
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class