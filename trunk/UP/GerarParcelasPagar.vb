Public Class GerarParcelasPagar

    Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Gerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gerar.Click
        If Me.Parcela.Text = "" Then
            MsgBox("O usuário deve informar a quantidade de Parcelas.", 64, "Validação de Dados")
            Me.Parcela.Focus()
            Exit Sub
        End If
        If Me.Vencimento.Text = "" Then
            MsgBox("O usuário deve informar a data de vencimento da primeira Parcelas.", 64, "Validação de Dados")
            Me.Vencimento.Focus()
            Exit Sub
        End If
        If Me.ValorDocumento.Text = "" Then
            MsgBox("O usuário deve informar o valor do Documento para as Parcelas.", 64, "Validação de Dados")
            Me.ValorDocumento.Focus()
            Exit Sub
        End If
        If Me.LocalPgto.Text = "" Then
            MsgBox("O usuário deve informar o local de pagamento para as Parcelas.", 64, "Validação de Dados")
            Me.LocalPgto.Focus()
            Exit Sub
        End If


        CNN.Open()

        Dim ds As New DataSet()


        Dim Sql As String = String.Empty
        Sql = "SELECT * from Pagar Where Id = -1"

        Dim DAPagar As New OleDb.OleDbDataAdapter(Sql, CNN)
        DAPagar.Fill(ds, "Pagar")

        Dim Venc As DateTime = CDate(Me.Vencimento.Text)


        Dim I As Integer = 0
        For I = 1 To Me.Parcela.Text

            Dim TBL As DataTable
            TBL = ds.Tables("Pagar")

            Dim DRnovo As DataRow
            DRnovo = TBL.NewRow()
            DRnovo("Id") = AchaNovoId()
            DRnovo("Documento") = My.Forms.PagarLancamentos.Documento.Text & "-" & I
            DRnovo("NotaFiscal") = Nz(My.Forms.PagarLancamentos.NotaFiscal.Text, 1)
            DRnovo("CodFornecedor") = Nz(My.Forms.PagarLancamentos.CodFornecedor.Text, 1)
            DRnovo("Fornecedor") = Nz(My.Forms.PagarLancamentos.Fornecedor.Text, 1)
            DRnovo("DataDocumento") = CDate(My.Forms.PagarLancamentos.DataDocumento.Text)
            DRnovo("Vencimento") = CDate(Venc)
            DRnovo("ValorDocumento") = FormatNumber(CDbl(Me.ValorDocumento.Text), 2)
            DRnovo("LocalPgto") = Nz(Me.LocalPgto.Text, 1)
            DRnovo("Empresa") = CodEmpresa
            If My.Forms.DocumentoEntrada.Visible = True Then
                DRnovo("IdCompraCtrlPedido") = Nz(My.Forms.DocumentoEntrada.Id.Text, 1)
            Else
                DRnovo("IdCompraCtrlPedido") = Nz(My.Forms.CompraCtrPedido.Id.Text, 1)
            End If
            DRnovo("IdCompraCtrlPedido") = Nz(My.Forms.CompraCtrPedido.Id.Text, 1)
            DRnovo("Destino") = Nz(Me.Destino.Text, 1) & " Par " & I & "-" & Me.Parcela.Text
            DRnovo("Juros") = CDbl(0)
            DRnovo("Multa") = CDbl(0)
            DRnovo("Desconto") = CDbl(0)
            DRnovo("ValorLiquido") = CDbl(0)
            DRnovo("Banco") = CDbl(0)

            TBL.Rows.Add(DRnovo)

            Venc = Venc.AddMonths(1)

        Next I

        Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAPagar)
        DAPagar.Update(ds, "Pagar")

        ds.Dispose()
        CNN.Close()
        MsgBox("Parcelas Geradas com sucesso.", 64, "Validação de Dados")
        My.Forms.PagarLancamentos.EncheLista()
        Me.Close()
        Me.Dispose()

    End Sub


    Public Function AchaNovoId()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer
        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select max(Id) from Pagar"
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    'Achou o iten procurado o iten as caixas serão preenchida
                    Ult = DataReader.Item(0)
                End If
            End While
            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Return 1
            If ConnectionState.Open Then
                Exit Function
            End If
        End Try

        Return Ult + 1

    End Function

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub GerarParcelasPagar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class