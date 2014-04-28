Public Class FolhaPgtoDecimoTerceiro

    Public Editando As Boolean = False

    Public QualParcela As Integer = 0

    Private Sub Visualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Visualizar.Click
        If Me.AnoAtual.Text = "" Then
            MsgBox("O usuário deve informar o ano para gerar o Décimo Terceiro.", 64, "Validação de Dados")
            Exit Sub
        End If
        
        Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim DS As New DataSet()

        Dim Sql As String = String.Empty


        Sql = "SELECT * FROM FolhaPgtoDecimoTerceiroCab WHERE Empresa = " & CodEmpresa & " AND AnoAtual = '" & Me.AnoAtual.Text & "'"
        Dim DADecimoCab As New OleDb.OleDbDataAdapter(Sql, Cnn)
        DADecimoCab.Fill(DS, "FolhaPgtoDecimoTerceiroCab")

        Dim LinhasGerado As Integer = DS.Tables("FolhaPgtoDecimoTerceiroCab").Rows.Count

        If LinhasGerado = 1 Then
            Dim Linha() As DataRow
            Linha = DS.Tables("FolhaPgtoDecimoTerceiroCab").Select("AnoAtual = '" & Me.AnoAtual.Text & "'")

            Me.AnoAtual.Text = Linha(0)("AnoAtual")
            Me.Descrição.Text = Linha(0)("Descrição")
            Me.Gerado1Parcela.Checked = Linha(0)("Gerado1Parcela")
            Me.Gerado2Parcela.Checked = Linha(0)("Gerado2Parcela")
        End If


        Sql = "SELECT FolhaPgtoDecimoTerceiro.*, Funcionários.Nome, FolhaPgtoDecimoTerceiro.AnoAtual, FolhaPgtoDecimoTerceiro.Empresa FROM FolhaPgtoDecimoTerceiro INNER JOIN Funcionários ON FolhaPgtoDecimoTerceiro.Funcionario = Funcionários.CódigoFuncionário WHERE (((FolhaPgtoDecimoTerceiro.AnoAtual) = '" & Me.AnoAtual.Text & "') AND ((FolhaPgtoDecimoTerceiro.Empresa) = " & CodEmpresa & "));"
        Dim DADecimoT As New OleDb.OleDbDataAdapter(Sql, Cnn)
        DADecimoT.Fill(DS, "FolhaPgtoDecimoTerceiro")

        MyLista.Items.Clear()
        Dim Zebrar As Boolean = False

        Dim DrDecimoT As DataRow
        For Each DrDecimoT In DS.Tables("FolhaPgtoDecimoTerceiro").Rows

            Dim AA As String = DrDecimoT("Funcionario")
            Dim It As New ListViewItem(AA, 0)

            It.SubItems.Add(DrDecimoT("Nome"))
            It.SubItems.Add(DrDecimoT("Meses"))
            It.SubItems.Add(FormatNumber(DrDecimoT("SalarioRegistro"), 2))
            It.SubItems.Add(FormatNumber(DrDecimoT("SalarioDif"), 2))
            It.SubItems.Add(FormatNumber(DrDecimoT("OutrosVlrs"), 2))
            It.SubItems.Add(FormatNumber(DrDecimoT("Total"), 2))
            It.SubItems.Add(FormatNumber(DrDecimoT("VlrDecimo"), 2))
            It.SubItems.Add(FormatNumber(DrDecimoT("Inss"), 2))
            It.SubItems.Add(FormatNumber(DrDecimoT("Desc1Pa"), 2))
            It.SubItems.Add(FormatNumber(DrDecimoT("1Parcela"), 2))
            It.SubItems.Add(FormatNumber(DrDecimoT("Desc2Pa"), 2))
            It.SubItems.Add(FormatNumber(DrDecimoT("2Parcela"), 2))
            MyLista.Items.AddRange(New ListViewItem() {It})

            If Zebrar = True Then
                MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                Zebrar = False
            Else
                MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.MistyRose
                Zebrar = True
            End If
        Next

    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick

        Dim I As Integer = 0

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then
                My.Forms.FolhaPgtoDecimoTerceiroADD.Funcionario.Text = MyLista.Items(I).Text.Substring(0)
                My.Forms.FolhaPgtoDecimoTerceiroADD.FuncionarioDesc.Text = MyLista.Items(I).SubItems(1).Text.Substring(0)
                My.Forms.FolhaPgtoDecimoTerceiroADD.Meses.Text = MyLista.Items(I).SubItems(2).Text.Substring(0)
                My.Forms.FolhaPgtoDecimoTerceiroADD.SalarioRegistro.Text = MyLista.Items(I).SubItems(3).Text.Substring(0)
                My.Forms.FolhaPgtoDecimoTerceiroADD.SalarioDif.Text = MyLista.Items(I).SubItems(4).Text.Substring(0)
                My.Forms.FolhaPgtoDecimoTerceiroADD.OutrosVlrs.Text = MyLista.Items(I).SubItems(5).Text.Substring(0)
                My.Forms.FolhaPgtoDecimoTerceiroADD.Total.Text = MyLista.Items(I).SubItems(6).Text.Substring(0)
                My.Forms.FolhaPgtoDecimoTerceiroADD.VlrDecimo.Text = MyLista.Items(I).SubItems(7).Text.Substring(0)
                My.Forms.FolhaPgtoDecimoTerceiroADD.Inss.Text = MyLista.Items(I).SubItems(8).Text.Substring(0)
                My.Forms.FolhaPgtoDecimoTerceiroADD.Desc1Pa.Text = MyLista.Items(I).SubItems(9).Text.Substring(0)
                My.Forms.FolhaPgtoDecimoTerceiroADD.Parcela1.Text = MyLista.Items(I).SubItems(10).Text.Substring(0)
                My.Forms.FolhaPgtoDecimoTerceiroADD.Desc2Pa.Text = MyLista.Items(I).SubItems(11).Text.Substring(0)
                My.Forms.FolhaPgtoDecimoTerceiroADD.Parcela2.Text = MyLista.Items(I).SubItems(12).Text.Substring(0)
            End If
        Next

        Editando = True
        My.Forms.FolhaPgtoDecimoTerceiroADD.ShowDialog()
        Visualizar_Click(sender, e)
    End Sub

   
    Private Sub Novo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Novo.Click
        Editando = False
        My.Forms.FolhaPgtoDecimoTerceiroADD.ShowDialog()
        Visualizar_Click(sender, e)
    End Sub

    Private Sub FolhaPgtoDecimoTerceiro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()
    End Sub

    Private Sub Degrade()
        Try
            Dim CCor() As String
            Dim corTemp As String

            corTemp = Cor1TelaPrimaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))

            corTemp = Cor2TelaPrimaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Parcela1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Parcela1.Click
        QualParcela = 1
        My.Forms.FolhaPgtoDecimoTerceiroGerarLancamentos.ShowDialog()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        QualParcela = 2
        My.Forms.FolhaPgtoDecimoTerceiroGerarLancamentos.ShowDialog()
    End Sub

    Private Sub Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Imprimir.Click
        RelatorioCarregar = "RelFolhaPgtoDecimoTerceiro"
        My.Forms.VisualizadorRelatorio.ShowDialog()
    End Sub
End Class