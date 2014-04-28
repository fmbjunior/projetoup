Imports System.Math
Public Class PedidoVendaEditReceber

    Dim RestaValorGeral As Double
    Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
    Dim Ds As New DataSet()

    Dim CmdAPrazo As New OleDb.OleDbCommand
    Dim DAFaturar As OleDb.OleDbDataAdapter
    Dim DateLinha As Date

    Private Sub PedidoVendaEditReceber_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If My.Forms.PedidoVenda.Visible = True Then
            Me.IdLancamento.Text = My.Forms.PedidoVenda.PedidoSequencia.Text
            Me.tParcelado.Text = FormatNumber(CDbl(NzZero(My.Forms.PedidoVenda.ValorAFaturar.Text)), 2)
        End If
        If My.Forms.PedidoOS.Visible = True Then
            Me.IdLancamento.Text = My.Forms.PedidoOS.PedidoSequencia.Text
            Me.tParcelado.Text = FormatNumber(CDbl(NzZero(My.Forms.PedidoOS.ValorAFaturar.Text)), 2)
        End If


        If CDbl(NzZero(Me.tParcelado.Text)) <> 0 Then

            CarregaLocalPgto()

            Dim Sql As String = String.Empty
            Sql = "SELECT * from Receber Where PedidoProdutos  = " & CInt(Me.IdLancamento.Text)

            CmdAPrazo.Connection = Cnn
            CmdAPrazo.CommandText = Sql

            DAFaturar = New OleDb.OleDbDataAdapter(CmdAPrazo)
            DAFaturar.Fill(Ds, "Receber")


            Me.Parcelado.Text = NzZero(Ds.Tables("Receber").Compute("sum(ValorDocumento)", ""))
            RestaValorGeral = NzZero(Ds.Tables("Receber").Compute("sum(ValorDocumento)", ""))
            Dim Tbl As New DataView(Ds.Tables("Receber").Copy)
            Me.ListaReceber.DataSource = Tbl.ToTable("Table", True, "Documento", "ValorDocumento", "Vencimento", "LocalPgto", "VencimentoOriginal")

        Else
            Me.Parcelado.Text = FormatNumber(0, 2)
        End If


    End Sub


    Private Sub CarregaLocalPgto()

        Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "SELECT * FROM(LocalPagamento) WHERE (((LocalPagamento.Empresa)=" & CodEmpresa & ") AND ((LocalPagamento.LocalPgto)<>'CHEQUE PRE-DATADO'));"
        Dim daLocalPgto As OleDb.OleDbDataAdapter

        daLocalPgto = New OleDb.OleDbDataAdapter(Sql, Cnn)
        daLocalPgto.Fill(Ds, "LocalPgto")

        Me.txtLocalPgto.DataSource = Ds.Tables("LocalPgto")
        Me.txtLocalPgto.ValueMember = "LocalPgto"
        Me.txtLocalPgto.DisplayMember = "LocalPgto"
        Me.txtLocalPgto.SelectedIndex = -1
        Cnn.Close()

    End Sub


    Private Sub btFecharTela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFecharTela.Click
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub ListaReceber_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListaReceber.CellDoubleClick

        Me.txtDocumento.Text = Me.ListaReceber.CurrentRow.Cells("cDoc").Value
        Me.txtVencimento.Text = Me.ListaReceber.CurrentRow.Cells("cVenc").Value
        Me.txtValor.Text = Me.ListaReceber.CurrentRow.Cells("cValorDoc").Value
        Me.txtLocalPgto.Text = Me.ListaReceber.CurrentRow.Cells("cLocalPagamento").Value
        Me.VencimentoOriginal.Text = Me.ListaReceber.CurrentRow.Cells("cVencimentoOriginal").Value & ""
        DateLinha = Me.ListaReceber.CurrentRow.Cells("cVenc").Value & ""
        If e.RowIndex = (Me.ListaReceber.Rows.Count - 1) Then
            MessageBox.Show("O usuário não pode alterar o valor da ultima parcela, o valor sera bloqueado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtValor.Enabled = False
        Else
            Me.txtValor.Enabled = True
        End If
        Me.txtDocumento.Focus()

    End Sub

    Private Sub btMudarParcela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMudarParcela.Click
        Dim d1 As Date = CDate(txtVencimento.Text)
        Dim d2 As Date = DateLinha
        Dim dias As Integer
        dias = ((d1.Date - d2.Date).TotalDays)

        If (dias > 10) Then
            MessageBox.Show("A data do vencimento ultrapassou a quantidade de " & Chr(13) & "dias que pode ser acrecida a data original. " & Chr(13) & "Acrescente apenas 10 dias", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtVencimento.Focus()
            Exit Sub
        End If

        If (dias <= -10) Then
            MessageBox.Show("A data do vencimento ultrapassou a quantidade de " & Chr(13) & "dias que pode ser acrecida a data original. " & Chr(13) & "Acrescente apenas 10 dias", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtVencimento.Focus()
            Exit Sub
        End If

        'If CDate(Me.txtVencimento.Text) < DateLinha Then
        '    MessageBox.Show("A data do vencimento não pode menor que a data original. ", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Me.txtVencimento.Focus()
        '    Exit Sub
        'End If



        If Me.txtDocumento.Text = "" Then
            MessageBox.Show("O Documento não pode ser Nulo", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtDocumento.Focus()
            Exit Sub
        End If
        If Me.txtVencimento.Text = "" Then
            MessageBox.Show("O Vencimento do Documento não pode ser Nulo", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtVencimento.Focus()
            Exit Sub
        End If
        If Me.txtValor.Text = "" Then
            MessageBox.Show("O Valor do Documento não pode ser Nulo", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtValor.Focus()
            Exit Sub
        End If
        If Me.txtLocalPgto.Text = "" Then
            MessageBox.Show("O Local de Pagamento do Documento não pode ser Nulo", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtLocalPgto.Focus()
            Exit Sub
        End If

        Dim QtdRow As Integer = Ds.Tables("Receber").Rows.Count
        Dim QtdRowTemp As Integer
        Dim RowAlterada As Integer

        Dim SomaValor As Double = 0
        Dim RestaValor As Double = 0

        Dim Linha As DataRow
        For Each Linha In Ds.Tables("Receber").Rows

            QtdRowTemp += 1
            If Linha("Documento") = Me.txtDocumento.Text Then

                Linha.BeginEdit()
                Linha("Vencimento") = Me.txtVencimento.Text
                Linha("ValorDocumento") = Me.txtValor.Text
                Linha("LocalPgto") = Me.txtLocalPgto.Text
                Linha.EndEdit()
                RowAlterada = QtdRowTemp
                SomaValor += FormatNumber(Linha("ValorDocumento"), 2)
                Exit For
            End If
            SomaValor += Linha("ValorDocumento")

            'If QtdRowTemp <= RowAlterada Then
            '    SomaValor += Linha("ValorDocumento")
            'End If

        Next

        RestaValor = FormatNumber(CDbl(NzZero(Me.tParcelado.Text)) - SomaValor, 2)

        RestaValorGeral = RestaValor

        Dim dividido As Double
        dividido = FormatNumber((RestaValor), 2) / (Ds.Tables("Receber").Rows.Count - RowAlterada)

        dividido = Round(dividido, 2)

        Dim TestaValor As Double = dividido * (Ds.Tables("Receber").Rows.Count - RowAlterada)
        Dim ValorSobra As Double = Round(RestaValor - TestaValor, 2)


        QtdRowTemp = 0

        'Reajusta as parcelas abaixo da alterada o valor

        For Each Linha In Ds.Tables("Receber").Rows
            QtdRowTemp += 1
            If QtdRowTemp > RowAlterada Then
                Linha.BeginEdit()
                If QtdRowTemp = Ds.Tables("Receber").Rows.Count Then
                    Linha("ValorDocumento") = dividido + ValorSobra
                Else
                    Linha("ValorDocumento") = dividido
                End If

                Linha.EndEdit()
            End If
        Next

        Me.Parcelado.Text = NzZero(Ds.Tables("Receber").Compute("sum(ValorDocumento)", ""))
        Dim Tbl As New DataView(Ds.Tables("Receber").Copy)
        Me.ListaReceber.DataSource = Tbl.ToTable("Table", True, "Documento", "ValorDocumento", "Vencimento", "LocalPgto", "VencimentoOriginal")



        Dim ObjFaturar As New OleDb.OleDbCommandBuilder(DAFaturar)
        DAFaturar.Update(Ds, "Receber")

        'Limpar as Caixas
        Me.txtDocumento.Clear()
        Me.txtVencimento.Clear()
        Me.txtValor.Clear()
        Me.txtLocalPgto.SelectedIndex = -1
    End Sub
End Class