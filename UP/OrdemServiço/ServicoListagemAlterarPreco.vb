Imports System.Data.OleDb
Imports System.Math

Public Class ServicoListagemAlterarPreco

    Dim i As Integer = 0
    Dim vpar As Double = 0
    Dim cp As Integer = 0
    Dim bs As New BindingSource
    Dim vValorAnterior As Double = 0
    Dim vValueCombo As Integer

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean

        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
            SendKeys.Send("{Tab}")
            Return True
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    
    Private Sub AceitaSomenteValores_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)

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
    Private Sub Dgv_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv.CellEnter
        Try
            Dim ss As Integer = Dgv.Columns(e.ColumnIndex).Index
            Try
                If Dgv.Columns(e.ColumnIndex).Index <> 3 Then
                    Dgv.CurrentRow.Cells("serv_codigo").ReadOnly = True
                    Dgv.CurrentRow.Cells("serv_descricao").ReadOnly = True
                    Dgv.CurrentRow.Cells("serv_referencia").ReadOnly = True
                End If
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Dgv_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Dgv.EditingControlShowing
        RemoveHandler e.Control.KeyPress, AddressOf AceitaSomenteValores_KeyPress 'AceitaSomenteValores

        RemoveHandler e.Control.KeyPress, AddressOf AceitaSomenteNumeros_KeyPress

        If CInt((DirectCast((sender), System.Windows.Forms.DataGridView).CurrentCell.ColumnIndex)) = 4 Then

            AddHandler e.Control.KeyPress, AddressOf AceitaSomenteNumeros_KeyPress
        ElseIf CInt((DirectCast((sender), System.Windows.Forms.DataGridView).CurrentCell.ColumnIndex)) = 3 Then

            AddHandler e.Control.KeyPress, AddressOf AceitaSomenteNumeros_KeyPress
        End If
    End Sub

    Private Sub Dgv_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv.CellEndEdit
        Dim cv As Double = 0
        ' 
        Try
            If Dgv.Columns(e.ColumnIndex).Index = 4 Or Dgv.Columns(e.ColumnIndex).Index = 1 Then

                Exit Sub
            Else
                Me.Dgv(3, e.RowIndex).Value = String.Format("{0:c}", Convert.ToDouble(Me.Dgv(3, e.RowIndex).Value))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salvar.Click
        Dim cod As Integer
        Dim desc As String
        Dim refer As String
        Dim v_Valor As Double


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()
        Dim sql As String
        Dim cmd As OleDbCommand


        Try
            For rowIndex As Integer = 0 To Dgv.Rows.Count - 1 Step 1

                cod = Dgv.Item(0, rowIndex).Value
                desc = Dgv.Item(1, rowIndex).Value
                refer = Dgv.Item(2, rowIndex).Value
                v_Valor = Dgv.Item(3, rowIndex).Value

                sql = "Update servicos Set serv_valorservico='" & v_Valor & "' where serv_codigo=" & cod
                cmd = New OleDbCommand(sql, CNN)
                cmd.ExecuteNonQuery()

            Next rowIndex
            MsgBox("Valores dos serviçcos atualizados com sucesso", 48, "Atenção")
            Dgv.Columns.Clear()
          
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CNN.Close()
        End Try
    End Sub

    Private Sub Filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFiltar.Click
        Dgv.Columns.Clear()
        vValueCombo = cGrupoServico.SelectedValue
        If vValueCombo = 0 Then
            MsgBox("Erro ao tentar  filtrar." & Chr(13) & "Selecione um grupo para depois filtrar.", 48, "Erro...")
            cGrupoServico.Focus()
            Exit Sub

        End If
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT servicos.serv_codigo, servicos.serv_descricao, servicos.serv_referencia, servicos.serv_valorservico FROM servicos WHERE (((servicos.GrupoServico)=" & vValueCombo & ")) ORDER BY servicos.serv_descricao;"


        Dim ocmd As New OleDb.OleDbCommand(Sql, CNN)

        Dim odr As OleDb.OleDbDataReader
        odr = ocmd.ExecuteReader


        Dgv.Columns.Add("serv_codigo", "Codigo")
        Dgv.Columns.Add("serv_descricao", "Serviço")
        Dgv.Columns.Add("serv_referencia", "Referencia")
        Dgv.Columns.Add("serv_valorservico", "Valor")
        Dgv.Columns(0).Width = 50
        Dgv.Columns(0).ReadOnly = True

        Dgv.Columns(1).Width = 300
        Dgv.Columns(1).ReadOnly = True

        Dgv.Columns(2).Width = 300
        Dgv.Columns(2).ReadOnly = True

        Dgv.Columns(3).Width = 100
        Dgv.Columns(3).ReadOnly = False

        Dgv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        Dim row As New DataGridViewRow


        While odr.Read()
            If Not IsDBNull(odr.Item("serv_codigo")) Then
                'preenche o grid com alguns dados
                i += 1
                Dim row0 As String() = {odr.Item("serv_codigo"), odr.Item("serv_descricao"), odr.Item("serv_referencia") & "", FormatCurrency(NzZero(odr.Item("serv_valorservico")), 2)}

                'adiciona as linhas
                With Me.Dgv.Rows
                    .Add(row0)
                End With
            End If
        End While
        Dgv.Focus()
    End Sub

    Private Sub fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub ServicoListagemAlterarPreco_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EncheCombo()
    End Sub
    Private Sub EncheCombo()
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim sqlG As String
        Dim ds As New DataSet

        sqlG = "Select * From GrupoServico"
        Try
            Cnn.Open()
            Dim daG As New OleDbDataAdapter(sqlG, Cnn)

            daG.Fill(ds, "gServico")
            Me.cGrupoServico.DataSource = ds.Tables("gServico")
            Me.cGrupoServico.DisplayMember = "gDescricao"
            Me.cGrupoServico.ValueMember = "gID"
            Me.cGrupoServico.SelectedValue = -1
        Catch ex As Exception
            Throw ex
        Finally
            Cnn.Close()
        End Try

    End Sub

    Private Sub Dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellContentClick

    End Sub
End Class