Public Class ChequePreClientes

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged, A4.CheckedChanged, A5.CheckedChanged, A6.CheckedChanged
        If Me.A1.Checked = True Then
            Me.TxtProcurar.Clear()
            Me.TxtProcurar.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
            Me.TxtProcurar.MaxLength = 50
            Me.TxtProcurar.Focus()
        End If
        If Me.A2.Checked = True Then
            Me.TxtProcurar.Clear()
            Me.TxtProcurar.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
            Me.TxtProcurar.MaxLength = 50
            Me.TxtProcurar.Focus()
        End If
        If Me.A3.Checked = True Then
            Me.TxtProcurar.Clear()
            Me.TxtProcurar.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
            Me.TxtProcurar.MaxLength = 50
            Me.TxtProcurar.Focus()
        End If
        If Me.A4.Checked = True Then
            Me.TxtProcurar.Clear()
            Me.TxtProcurar.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
            Me.TxtProcurar.Focus()
        End If
        If Me.A5.Checked = True Then
            Me.TxtProcurar.Clear()
            Me.TxtProcurar.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
            Me.TxtProcurar.MaxLength = 50
            Me.TxtProcurar.Focus()
        End If
        If Me.A6.Checked = True Then
            AtFiltro()
        End If
    End Sub

    Private Sub TxtProcurar_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProcurar.Leave
        ProcuraTexto()
    End Sub

    Public Function AtFiltro() As Integer

        Me.TxtProcurar.Text = ""
        Me.Cursor = Cursors.WaitCursor
        MyLista.Items.Clear()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        Cnn.Open()

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT ArquivoCheque.Cheque, ArquivoCheque.CC, ArquivoCheque.Titular, ArquivoCheque.ValorCh, ArquivoCheque.Vencimento, ArquivoCheque.DataBaixa, ArquivoCheque.EntreguePor, ArquivoCheque.Pedido, ArquivoCheque.Historico, ArquivoCheque.DataEnvioFinanceira, ArquivoCheque.Financeira FROM ArquivoCheque WHERE ArquivoCheque.DataBaixa Is Null and Empresa = " & CodEmpresa & " and CaixaCheque = '" & Me.CaixaUser.Text & "'"
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            Dim Zebrar As Boolean = True
            While DR.Read
                If Not IsDBNull(DR.Item("Cheque")) Then
                    Dim AA As String = DR.Item("Cheque")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("CC") & "")
                    It.SubItems.Add(DR.Item("Titular") & "")
                    It.SubItems.Add(DR.Item("EntreguePor") & "")
                    It.SubItems.Add(FormatNumber(Nz(DR.Item("ValorCh"), 3), 2))
                    It.SubItems.Add(DR.Item("Vencimento") & "")
                    It.SubItems.Add(DR.Item("Pedido") & "")
                    It.SubItems.Add(DR.Item("Historico") & "")
                    It.SubItems.Add(DR.Item("DataEnvioFinanceira") & "")
                    It.SubItems.Add(DR.Item("Financeira") & "")

                    MyLista.Items.AddRange(New ListViewItem() {It})

                    If DR.Item("Vencimento") < CDate(DataDia) Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.OrangeRed
                    Else
                        If Zebrar = True Then
                            MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                            Zebrar = False
                        Else
                            MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.LightGray
                            Zebrar = True
                        End If
                    End If
                End If
            End While

            DR.Close()
            Me.Cursor = Cursors.Default

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Function
            End If
        End Try

    End Function

    Public Function ProcuraTexto() As Integer
        Me.Cursor = Cursors.WaitCursor
        MyLista.Items.Clear()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        Cnn.Open()

        Dim CampoFilter As String = ""
        If Me.A1.Checked = True Then CampoFilter = "Cheque"
        If Me.A2.Checked = True Then CampoFilter = "Titular"
        If Me.A3.Checked = True Then CampoFilter = "EntreguePor"
        If Me.A4.Checked = True Then CampoFilter = "Vencimento"
        If Me.A5.Checked = True Then CampoFilter = "ValorCh"

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT ArquivoCheque.Cheque, ArquivoCheque.CC, ArquivoCheque.Titular, ArquivoCheque.ValorCh, ArquivoCheque.Vencimento, ArquivoCheque.DataBaixa, ArquivoCheque.EntreguePor, ArquivoCheque.Pedido, ArquivoCheque.Historico, DataEnvioFinanceira, Financeira FROM ArquivoCheque WHERE ArquivoCheque.DataBaixa Is Null and Empresa = " & CodEmpresa & " And " & CampoFilter & " Like '%" & Me.TxtProcurar.Text & "' & '%' and CaixaCheque = '" & Me.CaixaUser.Text & "'"
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            Dim Zebrar As Boolean = True
            While DR.Read
                If Not IsDBNull(DR.Item("Cheque")) Then
                    Dim AA As String = DR.Item("Cheque")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("CC") & "")
                    It.SubItems.Add(DR.Item("Titular") & "")
                    It.SubItems.Add(DR.Item("EntreguePor") & "")
                    It.SubItems.Add(FormatNumber(Nz(DR.Item("ValorCh"), 3), 2))
                    It.SubItems.Add(DR.Item("Vencimento") & "")
                    It.SubItems.Add(DR.Item("Pedido") & "")
                    It.SubItems.Add(DR.Item("Historico") & "")
                    It.SubItems.Add(DR.Item("DataEnvioFinanceira") & "")
                    It.SubItems.Add(DR.Item("Financeira") & "")

                    MyLista.Items.AddRange(New ListViewItem() {It})

                    If DR.Item("Vencimento") < CDate(DataDia) Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.OrangeRed
                    Else
                        If Zebrar = True Then
                            MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                            Zebrar = False
                        Else
                            MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.LightGray
                            Zebrar = True
                        End If
                    End If
                End If
            End While

            DR.Close()
            Me.Cursor = Cursors.Default

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Function
            End If
        End Try

    End Function

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        Dim I As Integer = 0
        RetornoProcura = ""
        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then Me.NCheque.Text = (MyLista.Items(I).Text.Substring(0))
            If MyLista.Items(I).Selected = True Then Me.CC.Text = (MyLista.Items(I).SubItems(1).Text.Substring(0))
        Next
        My.Forms.ChequePreClientesBaixa.ShowDialog()
    End Sub

    Private Sub btNovoLancamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovoLancamento.Click
        My.Forms.ChequePreLancarAvulso.ShowDialog()
    End Sub

    Private Sub ExcluirChequeSelecionadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirChequeSelecionadoToolStripMenuItem.Click

        Dim HH As DateTime = Now
        Dim CodSegurança As String = InputBox("Favor informar o Código de Segurança.", "Validação de Dados", 0)

        If VerificaCodigoSegurança(CodSegurança) = False Then
            MsgBox("Código de Segurança inválido, Verifique.", 64, "Validação de Dados")
            Exit Sub
        End If

        RetornoProcura = ""
        Dim I As Integer = 0
        Dim LinhaExcluir As Integer

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then Me.NCheque.Text = (MyLista.Items(I).Text.Substring(0))
            If MyLista.Items(I).Selected = True Then Me.CC.Text = (MyLista.Items(I).SubItems(1).Text.Substring(0))
            If MyLista.Items(I).Selected = True Then LinhaExcluir = I
        Next

        If Me.NCheque.Text = "" Then
            MsgBox("O usuário deve selecionar um item da lista.", 64, "Validação de Dados")
            Exit Sub
        End If

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "Delete * from ArquivoCheque Where Cheque = '" & Me.NCheque.Text & "' And CC = '" & Me.CC.Text & "'"
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Close()

        MyLista.Items.Item(LinhaExcluir).Remove()
        MyLista.Refresh()

    End Sub

    Private Sub ChequePreClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Len(CaixaAtivo) = 4 Then Me.CaixaUser.Text = CaixaAtivo

    End Sub

    Private Sub EnviarParaFinanceiraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarParaFinanceiraToolStripMenuItem.Click
        Dim I As Integer = 0
        RetornoProcura = ""
        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then Me.NCheque.Text = (MyLista.Items(I).Text.Substring(0))
            If MyLista.Items(I).Selected = True Then Me.CC.Text = (MyLista.Items(I).SubItems(1).Text.Substring(0))
        Next
        My.Forms.ChequePreEnviarFinanceira.ShowDialog()

        If Me.TxtProcurar.Text = "" Then
            AtFiltro()
        Else
            ProcuraTexto()
        End If
    End Sub

   
    Private Sub MyLista_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles MyLista.ColumnClick

        If Me.MyLista.Sorting = SortOrder.Ascending Then
            Me.MyLista.Sorting = SortOrder.Descending
        Else
            Me.MyLista.Sorting = SortOrder.Ascending
        End If
        Me.MyLista.ListViewItemSorter = New CLOrdenaLista(e.Column, Me.MyLista.Sorting)

    End Sub

    Private Sub ChequePreClientes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F10 Then
            My.Forms.CaixaAtivarDesativar.ShowDialog()
            'Me.DisplayCaixa.Text = "Caixa Ativo: " & CaixaAtivo
            Me.CaixaUser.Text = CaixaAtivo
        End If
    End Sub
End Class