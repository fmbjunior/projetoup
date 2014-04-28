Public Class CaixaEditaItemLancCtb

    Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
    Dim DS As New DataSet()
    Dim Sql As String = String.Empty
    Dim daLancaCTB As OleDb.OleDbDataAdapter
    Dim TBL As DataTable

    Dim VarIdLancamento As String
    Dim VarIdProcura As String
    Dim VarIdOrigem As String

    Dim CampoRetornar As String 'Serve somente para dar o nome do campo para servir de retorno na tela
    Dim RetornoCampo As String

    Private Sub CaixaEditaItemLancCtbl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        VarIdProcura = My.Forms.CaixaEditaItens.IdProcura.Text
        VarIdOrigem = My.Forms.CaixaEditaItens.IdOrigem.Text
        VarIdLancamento = My.Forms.CaixaEditaItens.IdLancamento.Text
        PreencherDados()
        Me.SerLancado.Text = FormatNumber(My.Forms.CaixaEditaItens.Tdebito.Text, 2)
        CarregaLista()
    End Sub

    Public Sub PreencherDados()
        Sql = "Select * From " & AnoContabel & " Where IdProcura = '" & VarIdProcura & "'"
        daLancaCTB = New OleDb.OleDbDataAdapter(Sql, Cnn)
        daLancaCTB.Fill(DS, AnoContabel)
        TBL = DS.Tables(AnoContabel)
    End Sub

    Private Sub btAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click
        AddReg()
    End Sub

    Private Sub AddReg()
        If Me.DataLancamento.Text = "" Then
            MessageBox.Show("Não foi informado a data de lançamento. Verifique", TituloMsgbox, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DataLancamento.Focus()
            Exit Sub
        End If
        If Me.Reduzida.Text = "" Then
            MessageBox.Show("Não foi informado a Conta de Lançamento. Verifique", TituloMsgbox, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Reduzida.Focus()
            Exit Sub
        End If
        If Me.Documento.Text = "" Then
            MessageBox.Show("Não foi informado o documento de Lançamento. Verifique", TituloMsgbox, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Documento.Focus()
            Exit Sub
        End If
        If Me.Historico.Text = "" Then
            MessageBox.Show("Não foi informado o Historico do Lançamento. Verifique", TituloMsgbox, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Historico.Focus()
            Exit Sub
        End If
        If Me.Debito.Checked = False And Me.Credito.Checked = False Then
            MessageBox.Show("Não foi informado uma Opção de Valor. Verifique", TituloMsgbox, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ValorLancamento.Focus()
            Exit Sub
        End If
        If Me.ValorLancamento.Text = "" Then
            MessageBox.Show("Não foi informado o Valor de Lançamento. Verifique", TituloMsgbox, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ValorLancamento.Focus()
            Exit Sub
        End If

        Dim drPROCURA() As DataRow
        drPROCURA = TBL.Select("Id = " & Me.Id.Text)

        If drPROCURA.Length = 0 Then
            Dim DRnovo As DataRow
            DRnovo = TBL.NewRow()
            DRnovo("DataLancamento") = Me.DataLancamento.Text
            DRnovo("PlanoContas") = Me.PlanoContas.Text
            DRnovo("Documento") = Me.Documento.Text
            If Me.Debito.Checked = True Then
                DRnovo("ValorDebito") = CDbl(Me.ValorLancamento.Text)
                DRnovo("ValorCredito") = CDbl(0)
            End If
            If Me.Credito.Checked = True Then
                DRnovo("ValorDebito") = CDbl(0)
                DRnovo("ValorCredito") = CDbl(Me.ValorLancamento.Text)
            End If
            DRnovo("Historico") = Me.Historico.Text
            DRnovo("Empresa") = CodEmpresa
            DRnovo("IdLancamento") = VarIdLancamento
            DRnovo("IdProcura") = VarIdProcura
            DRnovo("IdOrigem") = VarIdOrigem

            TBL.Rows.Add(DRnovo)
            CriaLog(UserAtivo, "CaixaEditaItemLancCtb", "Data Lanç: " & Me.DataLancamento.Text & " Lançamento Doc : " & Me.Documento.Text & " Conta Debito : " & Me.PlanoContas.Text & " no valor de " & Me.ValorLancamento.Text)
        Else
            drPROCURA(0).BeginEdit()
            drPROCURA(0)("DataLancamento") = Me.DataLancamento.Text
            drPROCURA(0)("PlanoContas") = Me.PlanoContas.Text
            drPROCURA(0)("Documento") = Me.Documento.Text
            If Me.Debito.Checked = True Then
                drPROCURA(0)("ValorDebito") = CDbl(Me.ValorLancamento.Text)
                drPROCURA(0)("ValorCredito") = CDbl(0)
            End If
            If Me.Credito.Checked = True Then
                drPROCURA(0)("ValorDebito") = CDbl(0)
                drPROCURA(0)("ValorCredito") = CDbl(Me.ValorLancamento.Text)
            End If
            drPROCURA(0)("Historico") = Me.Historico.Text
            drPROCURA(0).EndEdit()
            CriaLog(UserAtivo, "CaixaEditaItemLancCtb", "Data Lanç: " & Me.DataLancamento.Text & " Lançamento Doc : " & Me.Documento.Text & " Conta Debito : " & Me.PlanoContas.Text & " no valor de " & Me.ValorLancamento.Text)

        End If

        Me.DataLancamento.Clear() : Me.PlanoContas.Clear() : Me.Reduzida.Clear() : Me.ReduzidaDesc.Clear() : Me.Documento.Clear()
        Me.ValorLancamento.Clear() : Me.Debito.Checked = False : Me.Credito.Checked = False : Me.Historico.Clear() : Me.Id.Clear()
        CarregaLista()

        Me.Reduzida.Focus()

    End Sub

    Private Sub CarregaLista()
        MyLista.Items.Clear()
        Me.SaldoCredito.Text = FormatNumber(0, 2)
        Me.SaldoDebito.Text = FormatNumber(0, 2)
        Me.SaldoDiferenca.Text = FormatNumber(0, 2)

        Try
            Dim Zebrar As Boolean = False
            Dim DrLista As DataRow
            For Each DrLista In TBL.Rows

                Dim AA As String = DrLista("Id")
                Dim It As New ListViewItem(AA, 0)

                It.SubItems.Add(DrLista("PlanoContas") & "")
                It.SubItems.Add(DrLista("DataLancamento") & "")
                It.SubItems.Add(DrLista("Documento") & "")
                It.SubItems.Add(FormatNumber(DrLista("ValorDebito"), 2))
                It.SubItems.Add(FormatNumber(DrLista("ValorCredito"), 2))
                It.SubItems.Add(DrLista("Historico") & "")
                It.SubItems.Add(DrLista("IdOrigem") & "")
                It.SubItems.Add(DrLista("IdLancamento") & "")
                It.SubItems.Add(DrLista("IdProcura") & "")

                MyLista.Items.AddRange(New ListViewItem() {It})

                If Zebrar = True Then
                    MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                    Zebrar = False
                Else
                    MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.MistyRose
                    Zebrar = True
                End If

                Me.SaldoCredito.Text += DrLista("ValorCredito")
                Me.SaldoDebito.Text += CDbl(DrLista("ValorDebito"))
                Me.SaldoDiferenca.Text = CDbl(Me.SaldoDebito.Text) - CDbl(Me.SaldoCredito.Text)
            Next

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Exit Sub
        End Try

    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        Dim I As Integer = 0

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then
                Me.Id.Text = MyLista.Items(I).Text.Substring(0)
                Me.PlanoContas.Text = MyLista.Items(I).SubItems(1).Text.Substring(0)
                Me.DataLancamento.Text = MyLista.Items(I).SubItems(2).Text.Substring(0)
                Me.Documento.Text = MyLista.Items(I).SubItems(3).Text.Substring(0)
                If CDbl(NzZero(MyLista.Items(I).SubItems(4).Text.Substring(0))) > 0 Then
                    Me.Debito.Checked = True
                    Me.ValorLancamento.Text = FormatNumber(NzZero(MyLista.Items(I).SubItems(4).Text.Substring(0)))
                End If

                If CDbl(NzZero(MyLista.Items(I).SubItems(5).Text.Substring(0))) > 0 Then
                    Me.Credito.Checked = True
                    Me.ValorLancamento.Text = FormatNumber(NzZero(MyLista.Items(I).SubItems(5).Text.Substring(0)))
                End If
                Me.Historico.Text = MyLista.Items(I).SubItems(6).Text.Substring(0)
            End If
        Next
        AchaContaAnalitica()

    End Sub

    Private Sub MyLista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyLista.KeyDown
        'Dim IdDeletar As String = String.Empty
        'If e.KeyCode = Keys.Delete Then

        '    Dim I As Integer = 0
        '    For I = 0 To MyLista.Items.Count - 1
        '        If MyLista.Items(I).Selected = True Then IdDeletar = MyLista.Items(I).Text.Substring(0)
        '    Next


        '    Dim drLista() As DataRow = TBL.Select("PlanoContas = '" & IdDeletar & "'")

        '    If MessageBox.Show("Deseja realmente excluir o item da lista.", TituloMsgbox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        '        TBL.Rows.Remove(drLista(0))
        '        CarregaLista()
        '    End If
        'End If
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub DataLancamento_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataLancamento.Enter
        If Me.DataLancamento.Text = "" Then Me.DataLancamento.Text = CDate(DataDia)
    End Sub


    Private Sub AchaContaReduzida()

        If Me.Reduzida.Text = "" Then
            Exit Sub
        End If
        'String para filtragem de clientes na base de dados
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT * FROM PlanoContas WHERE ContaReduzida = '" & Me.Reduzida.Text & "' and Empresa = " & CodEmpresa

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()


        If DR.HasRows Then
            Me.ReduzidaDesc.Text = DR.Item("Descrição") & ""
            Me.PlanoContas.Text = DR.Item("IdContas") & ""
        Else
            MessageBox.Show("Esta conta não existe. Verifique...", TituloMsgbox, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Reduzida.Clear()
            Me.PlanoContas.Clear()
            Me.ReduzidaDesc.Clear()
            Me.Reduzida.Focus()
        End If
        DR.Close()
        CNN.Close()

    End Sub

    Private Sub AchaContaAnalitica()

        If Me.PlanoContas.Text = "" Then
            Exit Sub
        End If
        'String para filtragem de clientes na base de dados
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT * FROM PlanoContas WHERE IdContas = '" & Me.PlanoContas.Text & "' and Empresa = " & CodEmpresa

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()


        If DR.HasRows Then
            Me.ReduzidaDesc.Text = DR.Item("Descrição") & ""
            Me.Reduzida.Text = DR.Item("ContaReduzida") & ""
        Else
            MessageBox.Show("Esta conta não existe. Verifique...", TituloMsgbox, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Reduzida.Clear()
            Me.PlanoContas.Clear()
            Me.ReduzidaDesc.Clear()
            Me.Reduzida.Focus()
        End If
        DR.Close()
        CNN.Close()

    End Sub

    
    Private Sub Reduzida_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Reduzida.Leave
        If String.CompareOrdinal(Me.Reduzida.Text, Me.Reduzida.TextoAntigo) Then
            AchaContaReduzida()
        End If
    End Sub

    Private Sub btSalvarDados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvarDados.Click
        If Me.SaldoDebito.Text <> Me.SerLancado.Text Then
            MessageBox.Show("Os valores de lançamentos não batem, os dados não foi salvo, verifique...", TituloMsgbox, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Me.SaldoCredito.Text <> Me.SerLancado.Text Then
            MessageBox.Show("Os valores de lançamentos não batem, os dados não foi salvo, verifique...", TituloMsgbox, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Try
            Dim objLancCTB As New OleDb.OleDbCommandBuilder(daLancaCTB)
            daLancaCTB.Update(DS, AnoContabel)
            MessageBox.Show("Lançamentos salvos com sucesso.", TituloMsgbox, MessageBoxButtons.OK, MessageBoxIcon.Information)
            daLancaCTB.Dispose()
            TBL.Dispose()
            DS.Dispose()
            Cnn.Close()
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Ocorreram erros ao salvar os lançamento do Centro de Custo. Verifique..." & Chr(13) & ex.Message, 64, TituloMsgbox)
            Exit Sub
        End Try
    End Sub


    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        Me.DataLancamento.Clear() : Me.PlanoContas.Clear() : Me.Reduzida.Clear() : Me.ReduzidaDesc.Clear() : Me.Documento.Clear()
        Me.ValorLancamento.Clear() : Me.Debito.Checked = False : Me.Credito.Checked = False : Me.Historico.Clear() : Me.Id.Clear()
        Me.Reduzida.Focus()
    End Sub

    Private Sub btExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExcluir.Click
        Dim HH As DateTime = Now
        Dim CodSegurança As String = InputBox("Favor informar o Código de Segurança.", TituloMsgbox, 0)

        If VerificaCodigoSegurança(CodSegurança) = False Then
            MsgBox("Código de Segurança inválido, Verifique.", 64, TituloMsgbox)
            Exit Sub
        Else

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "Delete * From " & AnoContabel & " Where IdProcura = '" & VarIdProcura & "'"

            Dim CMD As New OleDb.OleDbCommand(Sql, CNN)

            Try
                CMD.ExecuteNonQuery()
                MsgBox("Lançamentos excluido com sucesso.", TituloMsgbox)
                CNN.Close()
                PreencherDados()
            Catch
            End Try

        End If

    End Sub
End Class