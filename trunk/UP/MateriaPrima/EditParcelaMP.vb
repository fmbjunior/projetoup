Imports Grid.DBL.DataGridViewCustomColumn
Imports System.Text
Imports System.Math
Imports System.Data.OleDb
Public Class EditParcelaMP

    Dim vValorAnterior As Double = 0
    Dim i As Integer = 0
    Dim vpar As Double = 0
    Dim cp As Integer = 0 'total de parcelas
    Dim CodFornecedor As Integer = 0 'Armazena o codigo do fornecedor
    Dim dResta As Double = 0 'Armazena o valor que resta.
    Dim idLinha As Integer
    Dim db As New clsBancoDados
    Dim cVlr As Double = 0
    Dim bs As BindingSource
    Dim Da As OleDb.OleDbDataAdapter
    Dim ds As DataSet
    'Uso o metodo para reescrever o evento keypress
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean

        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
            SendKeys.Send("{Tab}")
            Return True
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    'Metodo para cria as colunas em tempo de execução.
    Sub CreateCol()
        'Aqui definimos as nossa datagridview.
        Dim col As DataGridViewTextBoxColumn 'Importa a coluna textbox
        Dim ColM As MaskedTextBoxColumn  'importa a coluna maskedtext
        Dim colCB As DataGridViewComboBoxColumn 'importa a coluna combobox 


        'Definir alguma propriedades da coluna TextBox
        col = New DataGridViewTextBoxColumn()
        col.HeaderText = "id"
        col.Name = "id"
        col.Width = 70
        col.Visible = False
        Me.Dgv.Columns.Add(col)

        'Coluna para idendificar a linha editável
        col = New DataGridViewTextBoxColumn()
        col.HeaderText = "PP"
        col.Name = "P"
        col.Width = 70
        col.Visible = False
        Me.Dgv.Columns.Add(col)

        'Documento
        col = New DataGridViewTextBoxColumn()
        col.HeaderText = "Documento"
        col.Name = "documento"
        col.Width = 110
        ' col.ReadOnly = True
        Me.Dgv.Columns.Add(col)

        col = New DataGridViewTextBoxColumn()
        col.HeaderText = "NF"
        col.Name = "notafiscal"
        col.Width = 90
        Me.Dgv.Columns.Add(col)

        'Vencimento
        ColM = New MaskedTextBoxColumn()
        ColM.HeaderText = "Vencimento"
        ColM.Name = "vencimento"
        ColM.Mask = "00/00/0000"
        ColM.Width = 75
        ColM.ReadOnly = False
        Me.Dgv.Columns.Add(ColM)      '

        col = New DataGridViewTextBoxColumn()
        col.HeaderText = "Valor"
        col.Name = "valor"
        col.Width = 90
        col.DefaultCellStyle.Format = FormatCurrency(0, 2)
        Me.Dgv.Columns.Add(col)

        colCB = New DataGridViewComboBoxColumn()
        colCB.HeaderText = "Local Pgto"
        colCB.Name = "gLocal"
        colCB.Width = 90
        colCB.Items.Add("CARTEIRA")
        colCB.Items.Add("BANCO")
        Me.Dgv.Columns.Add(colCB)




    End Sub
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
    Private Shared Sub ShortFormDateFormat(ByVal formatting As DataGridViewCellFormattingEventArgs)
        'Aqui define a formatação na hora de criar o controle.
        If formatting.Value IsNot Nothing Then
            Try
                'Dim dateString As System.Text.StringBuilder = New System.Text.StringBuilder()
                Dim theDate As Date = DateTime.Parse(formatting.Value.ToString())

                formatting.Value = theDate.ToShortDateString
                formatting.FormattingApplied = True
            Catch notInDateFormat As FormatException
                'Definido como false no caso de existirem outros manipuladores interessados tentando
                'formatar este exemplo DataGridViewCellFormattingEventArgs.
                formatting.FormattingApplied = False
            End Try
        End If
    End Sub
    Private Sub EditParcelaMP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        atGrid()
    End Sub
    Sub atGrid()
        CreateCol()
        Dim conn As New OleDbConnection()

        conn = db.AbreBanco

        Dim sql As String

        sql = "Select * from Receber Where PedidoMP =" & My.Forms.frmPedidoMP.NumeroPedido.Text & " Order By id"

        Dim CMD As New OleDb.OleDbCommand(sql, conn)

        Dim odr As OleDb.OleDbDataReader
        odr = CMD.ExecuteReader
        Dim nf As String
        Dim row As New DataGridViewRow
        Dim cVlr As Double = 0
        While odr.Read()
            i += 1
            nf = Convert.ToString(odr.Item("NotaFiscal"))
            'preenche o grid com alguns dados
            Dim row0 As String() = {odr.Item("Id"), i, odr.Item("Documento"), Convert.ToString(odr.Item("NotaFiscal")), odr.Item("Vencimento"), FormatCurrency(odr.Item("valorDocumento"), 2), odr.Item("LocalPgto")}
            'adiciona as linhas
            With Me.Dgv.Rows
                .Add(row0)
            End With
        End While

    End Sub

    Private Sub Dgv_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles Dgv.CellFormatting
        'Evento usado para testar a formatação da coluna 
        If Dgv.Columns(e.ColumnIndex).Name = "vencimento" Then
            ShortFormDateFormat(e)
        End If
    End Sub

    Private Sub Dgv_CellValidating(sender As System.Object, e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles Dgv.CellValidating
        'Validadndo a entrada na celula
        Dim vValue As String 'pegar o valor da celula

        'Aqui valido a coluna vencimento.
        If Dgv.Columns(e.ColumnIndex).Name = "vencimento" Then
            vValue = e.FormattedValue.ToString()
            If IsDate(vValue) Then 'Foi uma data; formatação ok!
                Dgv.CurrentRow.Cells("vencimento").Value = vValue
            Else 'caso contrario mensagem de advertencia sobre a data
                MsgBox("Data inválida", 48, "Erro na data")
                e.Cancel = True
                SendKeys.Send("{ESC}")
            End If
        End If
    End Sub

    Private Sub Dgv_EditingControlShowing(sender As System.Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Dgv.EditingControlShowing
        'As declarações AddHandler e RemoveHandler permitem que você iniciar
        'e parar o tratamento de eventos para um evento específico a qualquer 
        'momento durante a execução do programa.
        RemoveHandler e.Control.KeyPress, AddressOf AceitaSomenteNumeros_KeyPress

        If CInt((DirectCast((sender), System.Windows.Forms.DataGridView).CurrentCell.ColumnIndex)) = 4 Then
            AddHandler e.Control.KeyPress, AddressOf AceitaSomenteNumeros_KeyPress
        End If
    End Sub

    Private Sub Dgv_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv.CellEndEdit
        Dim vValue As String = CDbl(Me.Dgv(5, e.RowIndex).Value)

        Me.Dgv(5, e.RowIndex).Value = String.Format("{0:c}", Convert.ToDouble(vValue))
        'Dim par As Double = Dgv.Item(4, e.RowIndex).Value
        'Dgv.Item(4, e.RowIndex).Value = FormatCurrency(par, 2)
    End Sub

    Private Sub salvar_Click(sender As System.Object, e As System.EventArgs) Handles salvar.Click

        Dim cSoma As Double = 0
        For i = 0 To Me.Dgv.RowCount - 1
            cSoma += CDbl(Dgv.Item(5, i).Value)

        Next
        Me.valor2.text = cSoma
        If valor2.Text <> Total.Text Then
            MessageBox.Show("Os valores não confere", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Dgv.RowCount > 0 Then

            Dim conn As New OleDbConnection()
            conn = db.AbreBanco

            Try

                Dim linha As Integer
                Dim v_Valor As Double = 0
                Dim v_Data As String
                Dim v_NF As String = String.Empty
                Dim v_Local As String = String.Empty

                Dim sql As String
                Dim cmd As OleDb.OleDbCommand

                For rowIndex As Integer = 0 To Dgv.Rows.Count - 1 Step 1
                    linha = Dgv.Item(0, rowIndex).Value         'pegar o id da linha do DataGrid
                    v_NF = Dgv.Item(3, rowIndex).Value          'pegar o numero  da nf 
                    v_Data = Dgv.Item(4, rowIndex).Value        'pegar a data do vencimento 
                    v_Valor = Dgv.Item(5, rowIndex).Value       'pegar o valor do documento
                    v_Local = Dgv.Item(6, rowIndex).Value       'pegar o local do pagamento carteiro ou banco

                    sql = "Update Receber Set  ValorDocumento='" & v_Valor & "', Vencimento='" & v_Data & "', NotaFiscal='" & v_NF & "',LocalPgto='" & v_Local & "' where id=" & linha
                    cmd = New OleDb.OleDbCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                Next rowIndex
                MessageBox.Show("Parcelas Atualizadas", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            MsgBox("ATENÇÃO!! O usuário prescisa gerar o paracelamento para prosseguir", 48, "Validação de dados")
            Return
        End If

    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Close()
        Me.Dispose()
    End Sub
End Class