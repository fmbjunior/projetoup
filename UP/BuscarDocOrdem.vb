Public Class BuscarDocOrdem
    Dim ação As New TrfGerais

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2
    Const CON As Byte = 3

    Dim bOpt As Boolean = False
    Dim sql As String
    Dim ds As New DataSet
    Dim vID As Integer = 0
    Dim contaDev As Integer
    Dim ContaDoc As Integer
    Dim LinhaAtual As Boolean = False
    Dim LinhaAntiga As Boolean = False
    Dim sDev As Boolean = False
    Dim sSel As Boolean = False
    Dim isDev As Boolean
    Dim isItem As Boolean



    Private Sub BuscarDocOrdem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MostrarTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarTodos.Click
        Dim sdata As String
        sdata = Me.DTPicker.Text
        Try
            If ds.Tables.Count <> 0 Then
                ds.Tables.Clear()
                Me.DgvItem.Refresh()
            End If


            Dim CNN As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
            CNN.Open()


            Dim Sql As String = ""

            Select Case Me.chk.Checked
                Case True
                    Sql = "SELECT id, FornecedorDesc, ValorPedido, LancaItens, IIf([TipoPedido]='DOC','DOC','ORDEM') AS EXPR1, IIf([confirmado]=true,'SIM','NÃO') AS EXPR2, CodigoGerenciador, NotaDevoluçao FROM CompraCtrlPedido where DATAPEDIDO=#" & Format(CDate(sdata), "MM/dd/yyyy") & "# AND Fornecedor=" & My.Forms.GerenciarOrdem.Fornecedor.Text & " and inativo=false"

                Case False
                    Sql = "SELECT id, FornecedorDesc, ValorPedido, LancaItens, IIf([TipoPedido]='DOC','DOC','ORDEM') AS EXPR1, IIf([confirmado]=true,'SIM','NÃO') AS EXPR2, CodigoGerenciador, NotaDevoluçao FROM CompraCtrlPedido WHERE Fornecedor=" & My.Forms.GerenciarOrdem.Fornecedor.Text & " and inativo=false"

            End Select





            Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
            Dim Da As New OleDb.OleDbDataAdapter(CMD)


            Da.Fill(ds, "Table")

            Me.DgvItem.DataSource = ds.Tables("Table").DefaultView

            MarcarLinha()
            Da.Dispose()
            CNN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub MarcarLinha()
        For i As Integer = 0 To DgvItem.Rows.Count - 1
           
            Dim SS As String
            SS = NzZero(DgvItem.Rows(i).Cells("CodG").Value.ToString)
            If Int(SS) > 0 Then
                Me.DgvItem.Rows(i).DefaultCellStyle.BackColor = Color.Red
                DgvItem.Rows(i).Cells("img").Value = DgvItem.Rows(i).Cells("imgVermelho").Value
            Else
                DgvItem.Rows(i).Cells("img").Value = DgvItem.Rows(i).Cells("imgAzul").Value
                'Me.DgvItem.CurrentRow.Cells("Sel").Value = True
            End If
        Next
    End Sub



    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim sdata As String
        sdata = Me.DTPicker.Text
        ds.Tables.Clear()
        Try
            Dim CNN As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
            CNN.Open()


            Dim Sql As String = ""

            Select Case Me.chk.Checked
                Case True
                    If Me.opt1.Checked = True Then
                        Sql = "SELECT id, FornecedorDesc, ValorPedido, LancaItens, IIf([TipoPedido]='DOC','DOC','ORDEM') AS EXPR1, IIf([confirmado]=true,'SIM','NÃO') AS EXPR2, CodigoGerenciador, NotaDevoluçao FROM CompraCtrlPedido WHERE ID like '%" & CInt(Me.txtpesquisar.Text) & "%' AND Fornecedor=" & My.Forms.GerenciarOrdem.Fornecedor.Text & "  AND DATAPEDIDO=#" & Format(CDate(sdata), "MM/dd/yyyy") & "# and inativo=false"
                    End If

                    'If Me.opt2.Checked = True Then
                    '    Sql = "SELECT id, FornecedorDesc, ValorPedido, IIf([TipoPedido]='DOC','DOC','ORDEM') AS EXPR1, IIf([confirmado]=true,'SIM','NÃO') AS EXPR2  FROM CompraCtrlPedido WHERE FornecedorDesc like '%" & Me.txtpesquisar.Text & "%' AND DATAPEDIDO=#" & Format(CDate(sdata), "MM/dd/yyyy") & "#"
                    'End If

                Case False
                    If Me.opt1.Checked = True Then
                        Sql = "SELECT id, FornecedorDesc, ValorPedido, LancaItens, IIf([TipoPedido]='DOC','DOC','ORDEM') AS EXPR1, IIf([confirmado]=true,'SIM','NÃO') AS EXPR2, CodigoGerenciador, NotaDevoluçao FROM CompraCtrlPedido WHERE ID like '%" & CInt(Me.txtpesquisar.Text) & "%' AND Fornecedor=" & My.Forms.GerenciarOrdem.Fornecedor.Text & " and inativo=false"
                    End If

                    'If Me.opt2.Checked = True Then
                    '    Sql = "SELECT id, FornecedorDesc, ValorPedido, IIf([TipoPedido]='DOC','DOC','ORDEM') AS EXPR1, IIf([confirmado]=true,'SIM','NÃO') AS EXPR2  FROM CompraCtrlPedido WHERE FornecedorDesc like '%" & Me.txtpesquisar.Text & "%'"
                    'End If

            End Select





            Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
            Dim Da As New OleDb.OleDbDataAdapter(CMD)


            Da.Fill(ds, "Table")

            Me.DgvItem.DataSource = ds.Tables("Table").DefaultView
            MarcarLinha()
            Da.Dispose()
            CNN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Verificar()

        Dim marcado As Boolean = False
        For i As Integer = 0 To DgvItem.Rows.Count - 1
            If DgvItem.Rows(i).Cells("Sel").Value = True Then
                sSel = True

                Exit For
            Else
                sSel = False
            End If
        Next
    End Sub
    Public Sub VerDev()


        Dim marcado As Boolean = False
        For i As Integer = 0 To DgvItem.Rows.Count - 1
            If DgvItem.Rows(i).Cells("Sel").Value = True And DgvItem.Rows(i).Cells("Dev").Value = True Then
                sDev = True
                Exit For
            Else
                sDev = False
            End If
        Next

    End Sub

    Private Sub DgvItem_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellClick
        
       



    End Sub
    Public Sub MarcarRow()
        Dim tpAtual As String = ""
        Dim tpAntigo As String = ""
        tpAtual = DgvItem.CurrentRow.Cells("COl4").Value.ToString
        Select Case DgvItem.CurrentRow.Cells("Sel").Value
            Case False
                '        If v1 = 4 And sSel = True Then
                '            Exit Sub
                '        End If
                If tpAntigo = "" Then
                    tpAntigo = tpAtual

                    My.Forms.GerenciarOrdem.sTipo = tpAntigo
                    Me.DgvItem.CurrentRow.Cells("Sel").Value = True
                    Me.DgvItem.CurrentRow.DefaultCellStyle.BackColor = Color.Red
                    DgvItem.CurrentRow.Cells.Item("Img").Value = DgvItem.CurrentRow.Cells.Item("imgVerde").Value 'ImageList.Images.Item(0)
                    atVlr()
                    'v2 = v1
                Else
                    If tpAntigo <> tpAtual Then
                        MsgBox("Você não pode selecionar Tipos de Documentos diferentes", 48, TituloMsgbox)

                    Else
                        My.Forms.GerenciarOrdem.sTipo = tpAntigo
                        Me.DgvItem.CurrentRow.Cells("Sel").Value = True
                        Me.DgvItem.CurrentRow.DefaultCellStyle.BackColor = Color.Red
                        atVlr()

                        Exit Sub
                    End If
                End If
            Case True
                If DgvItem.CurrentRow.Cells("Sel").Value = True Then
                    Me.DgvItem.CurrentRow.Cells("Sel").Value = False
                    Me.DgvItem.CurrentRow.DefaultCellStyle.BackColor = Color.White
                    DgvItem.CurrentRow.Cells.Item("Img").Value = DgvItem.CurrentRow.Cells.Item("ImgAzul").Value 'ImageList.Images.Item(0)
                    Me.DgvItem.Refresh()
                    atVlr()
                    'v2 = v1
                End If
        End Select
    End Sub
    Public Sub atVlr()
        Me.Total.Text = 0
        Dim str As Double
        Dim marcado As Boolean = False
        For i As Integer = 0 To DgvItem.Rows.Count - 1
            If DgvItem.Rows(i).Cells("Sel").Value = True Then
                str = CDbl(DgvItem.Rows(i).Cells("col3").Value)
                Me.Total.Text += str
                marcado = True
            End If
        Next

        If marcado = False Then
            Me.Total.Text = "0,00"
        End If
    End Sub


    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Dim CNN As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        CNN.Open()
        Dim Cmd As New OleDb.OleDbCommand()
        Dim ctrl As Integer
        For i As Integer = 0 To DgvItem.Rows.Count - 1
            If DgvItem.Rows(i).Cells("Sel").Value = True Then
                ctrl = DgvItem.Rows(i).Cells("col1").Value
                isDev = DgvItem.Rows(i).Cells("Dev").Value
                isItem = DgvItem.Rows(i).Cells("Itens").Value
                With Cmd
                    .Connection = CNN
                    .CommandTimeout = 0
                    .CommandText = "UPDATE CompraCtrlPedido SET CompraCtrlPedido.CodigoGerenciador =" & My.Forms.GerenciarOrdem.Id.Text & "  WHERE (((CompraCtrlPedido.Id)=" & ctrl & ") AND ((CompraCtrlPedido.Empresa)=" & CodEmpresa & "))"
                    .CommandType = CommandType.Text
                End With

                Cmd.ExecuteNonQuery()
                My.Forms.GerenciarOrdem.salvouReg = False
                My.Forms.GerenciarOrdem.Retorno = ctrl
                My.Forms.GerenciarOrdem.AtGrid()
                'Str = CDbl(DgvItem.Rows(i).Cells(3).Value)
                'Me.Total.Text += Str()
                'marcado = True
            End If
        Next
        CNN.Close()
        My.Forms.GerenciarOrdem.TotalProduto.Text = Me.Total.Text
        My.Forms.GerenciarOrdem.ViewDOC()
        My.Forms.GerenciarOrdem.nfdevolução.Checked = isDev
        My.Forms.GerenciarOrdem.LancaItens.Checked = isItem
        My.Forms.GerenciarOrdem.SumDgview()
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub DgvItem_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellContentClick
        Dim n As Int16
        n = e.RowIndex

        Me.DgvItem.Refresh()
        If NzZero(DgvItem.CurrentRow.Cells("CodG").Value.ToString) = 0 Then
        Else
            MsgBox("Este documento já foi selecionado", 48, "ATENÇÃO")
            'DgvItem.CurrentRow.Cells("Sel").Value = True
            Exit Sub
        End If

        If DgvItem.CurrentRow.Cells("Sel").Value = False And DgvItem.CurrentRow.Cells("itens").Value = True Then
            For i As Integer = 0 To DgvItem.Rows.Count - 1
                If DgvItem.Rows(i).Cells("Sel").Value = True And DgvItem.Rows(i).Cells("itens").Value = True Then
                    sSel = True
                    Exit For
                Else
                    sSel = False
                End If
            Next
        Else
            sSel = False
            If DgvItem.CurrentRow.Cells("Sel").Value = True And DgvItem.CurrentRow.Cells("itens").Value = True Then
                Me.DgvItem.CurrentRow.Cells("Sel").Value = False
                DgvItem.CurrentRow.Cells.Item("Img").Value = DgvItem.CurrentRow.Cells.Item("ImgAzul").Value
                Me.DgvItem.CurrentRow.DefaultCellStyle.BackColor = Color.White
                Exit Sub
            End If
        End If
        If sSel = True Then
            MsgBox("Você só pode selecionar uma Ordem por vez", 48, TituloMsgbox)
            Me.DgvItem.CurrentRow.Cells("Sel").Value = False
            DgvItem.CurrentRow.Cells.Item("Img").Value = DgvItem.CurrentRow.Cells.Item("ImgAzul").Value
            Me.DgvItem.CurrentRow.DefaultCellStyle.BackColor = Color.White
            Exit Sub
        End If


        If DgvItem.CurrentRow.Cells("Sel").Value = False And DgvItem.CurrentRow.Cells("Dev").Value = True Then
            VerDev()
            Verificar()
            If sSel = True And sDev = False Then
                ' MsgBox("Já foi escolhido um documento de devolução", 48, TituloMsgbox)
                Exit Sub
            End If

            If sDev = False And sSel = False Then
                MarcarRow()
                Exit Sub
            End If
            'If sSel = True And sDev = True Then
            '    MsgBox("Já foi escolhido um documento de devolução", 48, TituloMsgbox)
            '    Exit Sub
            'End If
            Exit Sub

        End If

        If DgvItem.CurrentRow.Cells("Sel").Value = True And DgvItem.CurrentRow.Cells("Dev").Value = True Then
            MarcarRow()
            Exit Sub
        End If

        If DgvItem.CurrentRow.Cells("Sel").Value = False And DgvItem.CurrentRow.Cells("Dev").Value = False Then
            VerDev()
            Verificar()
            If sSel = True And sDev = True Then
                ' MsgBox("Já foi escolhido um documento de devolução", 48, TituloMsgbox)
                Exit Sub
            Else
                MarcarRow()
                Exit Sub
            End If

        End If

        If DgvItem.CurrentRow.Cells("Sel").Value = True And DgvItem.CurrentRow.Cells("Dev").Value = False Then
            MarcarRow()
        End If

    End Sub
End Class