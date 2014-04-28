Imports System.Math
Public Class PagarEditParcelas

    Dim RestaValorGeral As Double
    Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
    Dim Ds As New DataSet()
    Dim CmdAPrazo As New OleDb.OleDbCommand
    Dim DAFaturar As OleDb.OleDbDataAdapter




    Private Sub PagarEditParcelas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If My.Forms.Compra.Visible = True Then
            Me.IdLancamento.Text = My.Forms.Compra.CompraInterno.Text
            Me.tParcelado.Text = FormatNumber(CDbl(NzZero(My.Forms.Compra.ValorCompra.Text)), 2)
        End If
        If My.Forms.DocumentoEntrada.Visible = True Then
            Me.IdLancamento.Text = My.Forms.DocumentoEntrada.Id.Text
            Me.tParcelado.Text = FormatNumber(CDbl(NzZero(My.Forms.DocumentoEntrada.ValorPedido.Text)), 2)
        End If
        If My.Forms.SellShoesCompra.Visible = True Then
            Me.IdLancamento.Text = My.Forms.SellShoesCompra.CompraInterno.Text
            Me.tParcelado.Text = FormatNumber(CDbl(NzZero(My.Forms.SellShoesCompra.ValorCompra.Text)), 2)
        End If


        If CDbl(NzZero(Me.tParcelado.Text)) <> 0 Then

            CarregaLocalPgto()

            Dim Sql As String = String.Empty

            If My.Forms.Compra.Visible = True Then
                Sql = "SELECT * FROM Pagar WHERE IdCompra=" & Me.IdLancamento.Text & " order by Id"
            ElseIf SellShoesCompra.Visible = True Then
                Sql = "SELECT * FROM Pagar WHERE IdCompra=" & Me.IdLancamento.Text & " order by Id"
            ElseIf My.Forms.DocumentoEntrada.Visible = True Then
                Sql = "SELECT * FROM Pagar WHERE IdCompraCtrlPedido=" & Me.IdLancamento.Text & " order by Id"
            End If

            CmdAPrazo.Connection = Cnn
            CmdAPrazo.CommandText = Sql

            DAFaturar = New OleDb.OleDbDataAdapter(CmdAPrazo)
            DAFaturar.Fill(Ds, "Pagar")


            Me.Parcelado.Text = NzZero(Ds.Tables("Pagar").Compute("sum(ValorDocumento)", ""))
            RestaValorGeral = NzZero(Ds.Tables("Pagar").Compute("sum(ValorDocumento)", ""))
            Dim Tbl As New DataView(Ds.Tables("Pagar").Copy)
            Me.ListaPagar.DataSource = Tbl.ToTable("Table", True, "Documento", "ValorDocumento", "Vencimento", "LocalPgto", "VencimentoOriginal")

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

    Private Sub ListaReceber_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListaPagar.CellDoubleClick

        Me.txtDocumento.Text = Me.ListaPagar.CurrentRow.Cells("cDoc").Value
        Me.txtVencimento.Text = Me.ListaPagar.CurrentRow.Cells("cVenc").Value
        Me.txtValor.Text = Me.ListaPagar.CurrentRow.Cells("cValorDoc").Value
        Me.txtLocalPgto.Text = Me.ListaPagar.CurrentRow.Cells("cLocalPagamento").Value
        Me.VencimentoOriginal.Text = Me.ListaPagar.CurrentRow.Cells("cVencimentoOriginal").Value & ""

        If e.RowIndex = (Me.ListaPagar.Rows.Count - 1) Then
            MessageBox.Show("O usuário não pode alterar o valor da ultima parcela, o valor sera bloqueado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtValor.Enabled = False
        Else
            Me.txtValor.Enabled = True
        End If
        Me.txtDocumento.Focus()

    End Sub


    Private Sub btMudarParcela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMudarParcela.Click
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

        Dim QtdRow As Integer = Ds.Tables("Pagar").Rows.Count
        Dim QtdRowTemp As Integer
        Dim RowAlterada As Integer

        Dim SomaValor As Double = 0
        Dim RestaValor As Double = 0

        Dim Linha As DataRow
        For Each Linha In Ds.Tables("Pagar").Rows

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
        dividido = FormatNumber((RestaValor), 2) / (Ds.Tables("Pagar").Rows.Count - RowAlterada)

        dividido = Round(dividido, 2)

        Dim TestaValor As Double = dividido * (Ds.Tables("Pagar").Rows.Count - RowAlterada)
        Dim ValorSobra As Double = Round(RestaValor - TestaValor, 2)


        QtdRowTemp = 0

        'Reajusta as parcelas abaixo da alterada o valor

        For Each Linha In Ds.Tables("Pagar").Rows
            QtdRowTemp += 1
            If QtdRowTemp > RowAlterada Then
                Linha.BeginEdit()
                If QtdRowTemp = Ds.Tables("Pagar").Rows.Count Then
                    Linha("ValorDocumento") = dividido + ValorSobra
                Else
                    Linha("ValorDocumento") = dividido
                End If

                Linha.EndEdit()
            End If
        Next

        Me.Parcelado.Text = NzZero(Ds.Tables("Pagar").Compute("sum(ValorDocumento)", ""))
        Dim Tbl As New DataView(Ds.Tables("Pagar").Copy)
        Me.ListaPagar.DataSource = Tbl.ToTable("Table", True, "Documento", "ValorDocumento", "Vencimento", "LocalPgto", "VencimentoOriginal")



        Dim ObjFaturar As New OleDb.OleDbCommandBuilder(DAFaturar)
        DAFaturar.Update(Ds, "Pagar")


        'Limpar as Caixas
        GerarLog(Me.Text, AçãoTP.Editou, Me.txtDocumento.Text)
        Me.txtDocumento.Clear()
        Me.txtVencimento.Clear()
        Me.txtValor.Clear()
        Me.txtLocalPgto.SelectedIndex = -1
    End Sub

End Class