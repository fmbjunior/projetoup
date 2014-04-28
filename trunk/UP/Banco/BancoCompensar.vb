Public Class BancoCompensar
    Dim DocMarcado As Integer = 0

    Dim SaldoAnterior As Double = 0

    Public Sub EncheLista()

        MyLista.Items.Clear()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        Cnn.Open()

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM LancamentoBanco WHERE CaiuBanco = 'N' And Tipo = 'BANCO' And ContaCorrente = '" & My.Forms.BancoVisualizador.Codigo.Text & "' and Empresa = " & CodEmpresa & " order by Documento"
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            Dim Zebrar As Boolean = True
            While DR.Read
                If Not IsDBNull(DR.Item("Id")) Then
                    Dim AA As String = DR.Item("Id")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("DataLancamento") & "")
                    It.SubItems.Add(DR.Item("Documento") & "")
                    It.SubItems.Add(FormatNumber(Nz(DR.Item("ValorDocumento"), 3), 2))
                    It.SubItems.Add(DR.Item("Historico") & "")
                    It.SubItems.Add("")

                    If DR.Item("PreDatado") = True Then
                        It.SubItems.Add("SIM")
                    Else
                        It.SubItems.Add("NÃO")

                    End If
                    It.SubItems.Add(DR.Item("DataPreDatado") & "")

                    MyLista.Items.AddRange(New ListViewItem() {It})

                    If Zebrar = True Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.LightGray
                        Zebrar = True
                    End If

                End If
            End While
            DR.Close()
            Me.MyLista.Refresh()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()

    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        If DocMarcado > 0 Then
            MsgBox("O usuário tem documentos que foi marcado para dar a compensação, utilize a opção compensar antes de sair." & Chr(13) & "Total de Documentos : " & DocMarcado, 64, "Validação de Dados")
            Exit Sub
        End If

        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub BancoCompensar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EncheLista()
    End Sub

    Private Sub MyLista_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles MyLista.ColumnClick
        Me.MyLista.Sorting = SortOrder.Ascending
        Me.MyLista.ListViewItemSorter = New CLOrdenaLista(e.Column)
    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick

        Dim I As Integer = 0

        Dim VlrAchado As String = ""
        Dim NLinha As Integer = 0
        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then VlrAchado = (MyLista.Items(I).Text.Substring(0))
            If MyLista.Items(I).Selected = True Then NLinha = I
        Next

        If MyLista.Items.Item(NLinha).BackColor = Color.Green Then
            If MsgBox("Deseja desmarcar o ítem selecionado.", 36, "Validação de Dados") = 6 Then
                MyLista.Items.Item(NLinha).BackColor = Color.White
                DocMarcado -= 1
                SomarLista()
                Exit Sub
            End If
        Else
            If MsgBox("Deseja marcar o item selecionado.", 36, "Validação de Dados") = 6 Then
                Me.PainelData.Visible = True
                Me.MyLista.Enabled = False
                Me.Fechar.Enabled = False
                Me.Compensar.Enabled = False
                Me.DataBaixa.Focus()
            End If
        End If


    End Sub


    Private Sub SomarLista()

        Dim Vlr As Double
        For Each item As ListViewItem In Me.MyLista.Items
            If item.BackColor = Color.Green Then
                Vlr += CDbl(item.SubItems(3).Text)
            End If

        Next
        Me.Tselecionado.Text = FormatCurrency(Vlr, 2)
    End Sub

    Private Sub Compensar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Compensar.Click


        Dim I As Integer = 0

        Dim VlrAchado As String = ""
        Dim DataCompensar As Date


        Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim DS As New DataSet()
        Dim daCompensar As OleDb.OleDbDataAdapter

        Dim Sql As String = "SELECT * FROM LancamentoBanco WHERE CaiuBanco = 'N' And Tipo = 'BANCO' And ContaCorrente = '" & My.Forms.BancoVisualizador.Codigo.Text & "' and Empresa = " & CodEmpresa & " order by Documento"
        daCompensar = New OleDb.OleDbDataAdapter(Sql, Cnn)
        daCompensar.Fill(DS, "TableCompensar")


        For I = 0 To MyLista.Items.Count - 1

            If MyLista.Items.Item(I).BackColor = Color.Green Then
                VlrAchado = (MyLista.Items(I).Text.Substring(0))


                DataCompensar = CDate((MyLista.Items(I).SubItems(8).Text.Substring(0)))

                Dim drACHAR() As DataRow
                drACHAR = DS.Tables("TableCompensar").Select("Id = " & VlrAchado)

                If drACHAR.Length > 0 Then
                    drACHAR(0).BeginEdit()
                    drACHAR(0)("DataLancamento") = Format(CDate(DataCompensar), "dd/MM/yyyy")
                    drACHAR(0)("CaiuBanco") = "S"
                    drACHAR(0).EndEdit()
                End If
            End If
        Next


        Dim objCommandBuilder1 As New OleDb.OleDbCommandBuilder(daCompensar)
        daCompensar.Update(DS, "TableCompensar")

        DS.Dispose()
        Cnn.Close()
        DocMarcado = 0

        EncheLista()
        GerarLog(Me.Text, AçãoTP.Editou, Me.DataBaixa.Text)

        MessageBox.Show("Documentos compensado com sucesso.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Private Sub PainelOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PainelOk.Click

        Dim I As Integer = 0

        Dim VlrAchado As String = ""
        Dim NLinha As Integer = 0
        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then VlrAchado = (MyLista.Items(I).Text.Substring(0))
            If MyLista.Items(I).Selected = True Then NLinha = I
        Next

        If MyLista.Items.Item(NLinha).BackColor = Color.Green Then
            MyLista.Items.Item(NLinha).BackColor = Color.White
            DocMarcado -= 1
            Exit Sub
        End If


        MyLista.Items.Item(NLinha).BackColor = Color.Green
        MyLista.Items(NLinha).SubItems.Add(Me.DataBaixa.Text)

        DocMarcado += 1

        Me.MyLista.Enabled = True
        Me.Fechar.Enabled = True
        Me.Compensar.Enabled = True
        Me.MyLista.Focus()
        Me.PainelData.Visible = False

        SomarLista()

    End Sub

    Private Sub PainelCancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PainelCancela.Click
        Me.MyLista.Enabled = True
        Me.Fechar.Enabled = True
        Me.Compensar.Enabled = True
        Me.MyLista.Focus()
        Me.PainelData.Visible = False
    End Sub
   
    Private Sub DataBaixa_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataBaixa.Enter
        If Me.DataBaixa.Text = "" Then Me.DataBaixa.Text = DataDia
    End Sub
End Class