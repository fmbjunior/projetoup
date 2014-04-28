Imports System.Data.OleDb

Public Class BalanceteEdit

    Private Sub btFechar_Click(sender As Object, e As EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btFiltrar_Click(sender As Object, e As EventArgs) Handles btFiltrar.Click
        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty



        Sql = "SELECT Id, DataLancamento,Documento,Historico,ValorDocumento,ContaBalancete,Tipo,ContaCorrente FROM LancamentoBanco WHERE LancamentoBanco.DataLancamento Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyy") & "#"
        
        Dim da = New OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Pagar")

        Me.DG.DataSource = ds.Tables("Pagar").DefaultView

        da.Dispose()
        Cnn.Close()

        Me.DG.Focus()

    End Sub

    Private Sub DG_SelectionChanged(sender As Object, e As EventArgs) Handles DG.SelectionChanged
        Try
            Dim vID As Integer
            vID = CInt(NzZero(Me.DG.CurrentRow.Cells("cId").Value))

            Me.Id.Text = Me.DG.CurrentRow.Cells("cid").Value
            Me.DataLancamento.Text = Me.DG.CurrentRow.Cells("cDataLancamento").Value
            Me.Documento.Text = Me.DG.CurrentRow.Cells("cDocumento").Value & ""
            Me.Historico.Text = Me.DG.CurrentRow.Cells("cHistorico").Value & ""
            Me.ValorDocumento.Text = Me.DG.CurrentRow.Cells("cValorDocumento").Value
            Me.ContaRC.Text = Me.DG.CurrentRow.Cells("cContaRC").Value & ""
            Me.Tipo.Text = Me.DG.CurrentRow.Cells("cTipo").Value & ""
            Me.ContaCorrente.Text = Me.DG.CurrentRow.Cells("cContaCorrente").Value & ""



            'If CDbl(Me.ValorDocumento.Text) < 0 Then
            CarregaListaCentroCusto()
            'End If


        Catch ex As Exception
        End Try
    End Sub

    
    Private Sub btFindConta_Click(sender As Object, e As EventArgs) Handles btFindConta.Click
        If CDbl(Me.ValorDocumento.Text) > 0 Then
            My.Forms.BalanceteContasProcura.TipoConta = "C"
            My.Forms.BalanceteContasProcura.ShowDialog()
            Me.ContaRC.Focus()
        Else
            My.Forms.BalanceteContasProcura.TipoConta = "D"
            My.Forms.BalanceteContasProcura.ShowDialog()
            Me.ContaRC.Focus()
        End If
    End Sub

    Private Sub btSalvarDados_Click(sender As Object, e As EventArgs) Handles btSalvarDados.Click


        Dim Sql As String = String.Empty
        Dim CNN As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Transacao As OleDbTransaction = CNN.BeginTransaction()
        Dim CmdBanco As OleDbCommand = CNN.CreateCommand
        
        CmdBanco.Transaction = Transacao
        
        Try
            Sql = "Update LancamentoBanco set  ContaRC = @ContaRC Where Id = " & Me.Id.Text
            CmdBanco.CommandText = Sql

            CmdBanco.Parameters.Add(New OleDbParameter("@ContaRC", nzNUL(Me.ContaRC.Text)))
            CmdBanco.ExecuteNonQuery()
            


            Transacao.Commit()
            CNN.Close()
            MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")

        Catch ex As Exception
            Transacao.Rollback()
            CNN.Close()
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try
    End Sub

    Private Sub CarregaListaCentroCusto()
        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT CcLanc.ContaCC, Cc3.DescContaGrupo3, CcLanc.DataLanc, CcLanc.ValorLanc,Cclanc.Id FROM CcLanc INNER JOIN Cc3 ON CcLanc.ContaCC = Cc3.ContaGrupo3 WHERE (CcLanc.IdCaixaBanco = " & Me.Id.Text & ")"

        Dim da = New OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Lista.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        ds.Dispose()
        Cnn.Close()

        Dim Vlr As Double = 0
        For Each dr As DataGridViewRow In Me.Lista.Rows
            Vlr += Me.Lista.Rows(dr.Index).Cells("cValorLanc").Value
        Next dr
        Me.TotCentroCusto.Text = FormatNumber(Vlr, 2)

    End Sub

    Private Sub btAddCC_Click(sender As Object, e As EventArgs) Handles btAddCC.Click
        If Me.Id.Text = "" Then
            MessageBox.Show("Favor selecionar um lancamento do caixa/banco.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        My.Forms.BalanceteEditLancCC.ShowDialog()

    End Sub

    Private Sub Lista_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Lista.CellDoubleClick
        Dim vID As Integer
        vID = CInt(Me.Lista.CurrentRow.Cells("cIdLanc").Value)

        My.Forms.BalanceteEditLancCC.IdAchar = vID
        My.Forms.BalanceteEditLancCC.ShowDialog()

    End Sub

  
End Class