Public Class CaixaRepasseCheque

    Dim Selecionado As Boolean = False

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub CaixaRepasseCheque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EncheListaCaixaRepassar()
        CarregaCheques()
        Me.ListaCheque.Enabled = False
    End Sub

    Private Sub CarregaCheques()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = String.Empty

        Sql = "SELECT ArquivoCheque.Cheque, ArquivoCheque.CC, Clientes.Nome, ArquivoCheque.Titular, ArquivoCheque.ValorCh, ArquivoCheque.Vencimento FROM ArquivoCheque LEFT JOIN Clientes ON ArquivoCheque.Cliente = Clientes.Codigo WHERE ArquivoCheque.CaixaCheque = '" & My.Forms.Caixa.CaixaCod.Text & "' And Historico <> 'BAIXADO'"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.ListaCheque.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        Cnn.Close()

    End Sub


    Private Sub EncheListaCaixaRepassar()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT CaixaCadastro.CodigoCaixa, [CodigoCaixa] & ' - ' & [CaixaNome] AS Nome, CaixaCadastro.Inativo, CaixaCadastro.Empresa FROM(CaixaCadastro) WHERE(((CaixaCadastro.Inativo) = False) And ((CaixaCadastro.Empresa) = " & CodEmpresa & ")) and CaixaCadastro.CodigoCaixa <> '" & My.Forms.Caixa.CaixaCod.Text & "' and CaixaCadastro.Retaguarda = True ORDER BY CaixaCadastro.CodigoCaixa;"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.CaixaRepassar.DataSource = ds.Tables("Table").DefaultView
        Me.CaixaRepassar.DisplayMember = "Nome"
        Me.CaixaRepassar.ValueMember = "CodigoCaixa"
        Me.CaixaRepassar.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub CaixaRepassar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaixaRepassar.SelectedIndexChanged
        If Me.CaixaRepassar.Text <> "" Then
            Me.ListaCheque.Enabled = True
        Else
            Me.ListaCheque.Enabled = False
        End If
    End Sub

    Private Sub ListaCheque_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListaCheque.CellContentClick
        If Me.ListaCheque.CurrentCell.ColumnIndex = 1 Then
            If Me.ListaCheque.CurrentRow.Cells("Repassar").Value = False Then
                Me.TotalRepassar.Text += Me.ListaCheque.CurrentRow.Cells("xValor").Value
                Me.TotalRepassar.Text = FormatNumber(CDbl(Me.TotalRepassar.Text), 2)
                System.Windows.Forms.SendKeys.Send("{Tab}")
            Else
                Me.TotalRepassar.Text -= Me.ListaCheque.CurrentRow.Cells("xValor").Value
                Me.TotalRepassar.Text = FormatNumber(CDbl(Me.TotalRepassar.Text), 2)
                System.Windows.Forms.SendKeys.Send("{Tab}")
            End If
        End If
    End Sub

    Private Sub btFazerRepasse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFazerRepasse.Click

        Me.btFazerRepasse.Enabled = False
        If MsgBox("Deseja fazer o repasse dos cheques selecionado para o Caixa: " & Me.CaixaRepassar.SelectedValue, 36, "Validação de Dados") = 6 Then



            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Ds As New DataSet


            Dim SqlItem As String = "Select * From ArquivoChequeRepasse  Where CodRepasse = '-1'"
            Dim DaRepasse As New OleDb.OleDbDataAdapter(SqlItem, CNN)
            DaRepasse.Fill(Ds, "Repasse")

            Dim Sql As String = "SELECT * FROM ArquivoCheque WHERE ArquivoCheque.CaixaCheque = '" & My.Forms.Caixa.CaixaCod.Text & "'"
            Dim DaCheque As New OleDb.OleDbDataAdapter(Sql, CNN)
            DaCheque.Fill(Ds, "Cheques")


            Dim Cod As String
            Cod = DataDia.Day & DataDia.Month & DataDia.Year & DateTime.Now.Hour & DateTime.Now.Minute & DateTime.Now.Second

            Try
                For Each Linha As DataGridViewRow In Me.ListaCheque.Rows
                    If Linha.Cells("Repassar").Value = True Then
                        Dim TBL As DataTable
                        TBL = Ds.Tables("Repasse")

                        Dim DRnovo As DataRow
                        DRnovo = TBL.NewRow()

                        DRnovo("CodRepasse") = Cod
                        DRnovo("Cheque") = Linha.Cells("xCheque").Value
                        DRnovo("CC") = Linha.Cells("xCC").Value
                        DRnovo("DataRepasse") = DataDia
                        DRnovo("CaixaOrigem") = My.Forms.Caixa.CaixaCod.Text
                        DRnovo("CaixaDestino") = Me.CaixaRepassar.SelectedValue
                        DRnovo("ValorCh") = Linha.Cells("xValor").Value
                        TBL.Rows.Add(DRnovo)

                        Dim DrLinha() As DataRow
                        DrLinha = Ds.Tables("Cheques").Select("Cheque = '" & Linha.Cells("xCheque").Value & "' And CC = '" & Linha.Cells("xCC").Value & "'")

                        DrLinha(0).BeginEdit()
                        DrLinha(0)("CaixaCheque") = Me.CaixaRepassar.SelectedValue
                        DrLinha(0).EndEdit()
                    End If

                Next

                Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DaRepasse)
                DaRepasse.Update(Ds, "Repasse")

                Dim objCommandBuilder1 As New OleDb.OleDbCommandBuilder(DaCheque)
                DaCheque.Update(Ds, "Cheques")

                CNN.Close()
                Me.Refresh()

                MessageBox.Show("Repasse realizado com sucesso.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ErroLivre = "Repasse realizado com sucesso " & Me.CaixaRepassar.Text
                GerarLog(Me.Text, AçãoTP.Livre, Me.TotalRepassar.Text)


                'Fazer a Impressao do Repasse
                Me.Cursor = Cursors.WaitCursor
                Dim Conect As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
                Conect.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)

                Conect.SQL = "SELECT ArquivoChequeRepasse.CodRepasse, ArquivoChequeRepasse.Cheque, ArquivoChequeRepasse.ValorCh,ArquivoChequeRepasse.CC, ArquivoChequeRepasse.DataRepasse, ArquivoChequeRepasse.CaixaOrigem, CaixaCadastro.CaixaNome, ArquivoChequeRepasse.CaixaDestino, CaixaCadastro_1.CaixaNome FROM (ArquivoChequeRepasse INNER JOIN CaixaCadastro ON ArquivoChequeRepasse.CaixaOrigem = CaixaCadastro.CodigoCaixa) INNER JOIN CaixaCadastro AS CaixaCadastro_1 ON ArquivoChequeRepasse.CaixaDestino = CaixaCadastro_1.CodigoCaixa WHERE (((ArquivoChequeRepasse.CodRepasse)='" & Cod & "'));"

                Dim Rel As New RelRepasseCheque
                Rel.DataSource = Conect

                My.Forms.ViewReport.VerRelat.Document = Rel.Document
                My.Forms.ViewReport.VerRelat.Document.Name = "RelRepasseCheque"
                Rel.Run()

                My.Forms.ViewReport.ShowDialog()
                Me.Cursor = Cursors.Default
                'Fim da Impressão




            Catch ex As Exception
                MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.btFazerRepasse.Enabled = False
                Me.Cursor = Cursors.Default
                Exit Sub
            End Try


        End If

    End Sub
End Class