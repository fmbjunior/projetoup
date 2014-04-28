Public Class PagarLancamentos

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Dim ContaLancamento As String

    Public EmEdiçao As Boolean = False


    Private Sub Novo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Novo.Click
        Me.Id.Clear()
        Me.Vencimento.Clear()
        Me.Vencimento.Enabled = True
        'Me.Parcela.Text += 1
        Operation = INS
        Me.Parcela.Focus()
    End Sub

    Private Sub PagarLancamentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If EstaCarregado("CompraCtrPedido") = True Then

            Me.NotaFiscal.Text = My.Forms.CompraCtrPedido.NotaFiscal.Text & ""
            Me.CodFornecedor.Text = My.Forms.CompraCtrPedido.Fornecedor.Text
            Me.Fornecedor.Text = My.Forms.CompraCtrPedido.FornecedorDesc.Text
            Me.Documento.Text = My.Forms.CompraCtrPedido.Documento.Text
            Me.DataDocumento.Text = My.Forms.CompraCtrPedido.DataPedido.Text
            Me.Parcelar.Text = FormatNumber(My.Forms.CompraCtrPedido.ValorPedido.Text, 2)
            ContaLancamento = ""
        End If
        If EstaCarregado("DocumentoEntrada") = True Then
            Me.NotaFiscal.Text = My.Forms.DocumentoEntrada.NotaFiscal.Text & ""
            Me.CodFornecedor.Text = My.Forms.DocumentoEntrada.Fornecedor.Text
            Me.Fornecedor.Text = My.Forms.DocumentoEntrada.FornecedorDesc.Text
            Me.Documento.Text = My.Forms.DocumentoEntrada.NotaFiscal.Text
            Me.DataDocumento.Text = My.Forms.DocumentoEntrada.DataPedido.Text
            Me.Destino.Text = Mid(My.Forms.DocumentoEntrada.Destino.Text, 1, 150)
            Me.Parcelar.Text = FormatNumber(My.Forms.DocumentoEntrada.ValorPedido.Text, 2)
            Me.vValorDoc.Text = FormatNumber(My.Forms.DocumentoEntrada.ValorPedido.Text, 2)
            ContaLancamento = My.Forms.DocumentoEntrada.ContaDespesa.Text
        End If

        If EstaCarregado("Compra") = True Then
            Me.NotaFiscal.Text = My.Forms.Compra.NotaFiscal.Text & ""
            Me.CodFornecedor.Text = My.Forms.Compra.CodigoFornecedor.Text
            Me.Fornecedor.Text = My.Forms.Compra.RazaoSocial.Text
            Me.Documento.Text = My.Forms.Compra.NotaFiscal.Text
            Me.DataDocumento.Text = My.Forms.Compra.DataLancamento.Text
            ContaLancamento = My.Forms.Compra.ContaDespesa.Text

            If My.Forms.Compra.TpEntrada.Text = "ENTRADA" Then
                Me.Parcelar.Text = FormatNumber(My.Forms.Compra.ValorCompra.Text, 2)
                Me.vValorDoc.Text = FormatNumber(My.Forms.Compra.ValorCompra.Text, 2)
            Else
                Me.Parcelar.Text = FormatNumber((My.Forms.Compra.ValorCompra.Text * -1), 2)
                Me.vValorDoc.Text = FormatNumber((My.Forms.Compra.ValorCompra.Text * -1), 2)
            End If
        End If


        If EstaCarregado("SellShoesCompra") = True Then

            Me.NotaFiscal.Text = SellShoesCompra.NotaFiscal.Text & ""
            Me.CodFornecedor.Text = SellShoesCompra.CodigoFornecedor.Text
            Me.Fornecedor.Text = SellShoesCompra.RazaoSocial.Text
            Me.Documento.Text = SellShoesCompra.NotaFiscal.Text
            Me.DataDocumento.Text = SellShoesCompra.DataLancamento.Text
            ' ContaLancamento = SellShoesCompra.ContaLancamento.Text

            If SellShoesCompra.TpEntrada.Text = "ENTRADA" Then
                Me.Parcelar.Text = FormatNumber(SellShoesCompra.ValorCompra.Text, 2)
                Me.vValorDoc.Text = FormatNumber(SellShoesCompra.ValorCompra.Text, 2)
            Else
                Me.Parcelar.Text = FormatNumber((SellShoesCompra.ValorCompra.Text * -1), 2)
                Me.vValorDoc.Text = FormatNumber((SellShoesCompra.ValorCompra.Text * -1), 2)
            End If

        End If
        Me.Parcela.Text = 1



        Me.CodFornecedor.Enabled = False
        Me.Fornecedor.Enabled = False
        Me.NotaFiscal.Enabled = False
        Me.LocalPgto.Enabled = True

        EncheLista()
        Novo_Click(sender, e)
    End Sub
    Public Function AchaNovoId()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

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
            CNN.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Return 1
            If ConnectionState.Open Then
                Exit Function
            End If
        End Try

        Return Ult + 1

    End Function
    Private Sub Salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salvar.Click

        If Me.MyLista.Items.Count > 0 Then
            MsgBox("Já foi gerado parcelas para este documento, você deverá excluir a parcela atual para gerar uma nova.", 64, "Validação de Dados")
            Exit Sub
        End If


        If Me.Parcela.Text = "" Or Me.Parcela.Text = 0 Then
            MsgBox("Quantidade de parcelas não é válido, O usuário deve informar uma quantidade válida.", 64, "Validação de Dados")
            Me.Parcela.Focus()
            Exit Sub
        End If
        If Me.Vencimento.Text = "" Then
            MsgBox("O usuário deve informar a data de vencimento da primeira Parcelas.", 64, "Validação de Dados")
            Me.Vencimento.Focus()
            Exit Sub
        End If
        If Me.LocalPgto.Text = "" Then
            MsgBox("O usuário deve informar o local de pagamento para as Parcelas.", 64, "Validação de Dados")
            Me.LocalPgto.Focus()
            Exit Sub
        End If

        If CDate(Me.Vencimento.Text) < CDate(Me.DataDocumento.Text) Then
            MessageBox.Show("A primeira data de vencimento não pode ser menor que a data do documento, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Vencimento.Focus()
            Exit Sub
        End If

        'conexão com o banco de dados
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim ds As New DataSet()

        'faz um select sem dados
        Dim Sql As String = String.Empty
        Sql = "SELECT * from Pagar Where Id = -1"

        'cria um data adapter  para iniserir os dados na table pagar usando a string sql anterior
        Dim DAPagar As New OleDb.OleDbDataAdapter(Sql, CNN)
        DAPagar.Fill(ds, "Pagar")

        Dim Venc As DateTime = CDate(Me.Vencimento.Text)
        Dim vValorParcelado As Double = 0
        vValorParcelado = CDbl(Me.Parcelar.Text) / Me.Parcela.Text
        Dim I As Integer = 0

        'conta quantas parcelas 
        For I = 1 To Me.Parcela.Text

            'cria um datatable em memoria da table pagar e insere os dados
            Dim TBL As DataTable
            TBL = ds.Tables("Pagar")

            Dim DRnovo As DataRow
            DRnovo = TBL.NewRow()
            DRnovo("Id") = AchaNovoId()
            DRnovo("Documento") = Me.Documento.Text & "-" & I
            DRnovo("NotaFiscal") = Nz(Me.NotaFiscal.Text, 1)
            DRnovo("CodFornecedor") = Nz(Me.CodFornecedor.Text, 1)
            DRnovo("Fornecedor") = Nz(Me.Fornecedor.Text, 1)
            DRnovo("DataDocumento") = CDate(Me.DataDocumento.Text)
            DRnovo("Vencimento") = CDate(Venc)
            DRnovo("ValorDocumento") = FormatNumber(CDbl(vValorParcelado), 2)
            DRnovo("LocalPgto") = Nz(Me.LocalPgto.Text, 1)
            DRnovo("Empresa") = CodEmpresa

            If My.Forms.DocumentoEntrada.Visible = True Then
                DRnovo("IdCompraCtrlPedido") = Nz(My.Forms.DocumentoEntrada.Id.Text, 1)
            ElseIf My.Forms.Compra.Visible = True Then
                DRnovo("IdCompra") = Nz(My.Forms.Compra.CompraInterno.Text, 1)
            ElseIf SellShoesCompra.Visible = True Then
                DRnovo("IdCompra") = Nz(SellShoesCompra.CompraInterno.Text, 1)
            End If

            DRnovo("Destino") = Nz(Me.Destino.Text, 1)
            DRnovo("Juros") = CDbl(0)
            DRnovo("Multa") = CDbl(0)
            DRnovo("Desconto") = CDbl(0)
            DRnovo("ValorLiquido") = CDbl(0)
            DRnovo("Banco") = CDbl(0)
            DRnovo("ContaValorBaixado") = Nz(ContaLancamento, 1)

            'verificas e o form documento de entrada esta ativo
            If My.Forms.DocumentoEntrada.Visible = True Then

                '  DRnovo("ContaCr") = IIf(My.Forms.DocumentoEntrada.ContaCR.Text <> "", My.Forms.DocumentoEntrada.ContaCR.Text, System.DBNull.Value)

                DRnovo("Conta1") = IIf(My.Forms.DocumentoEntrada.Conta1.Text <> "", My.Forms.DocumentoEntrada.Conta1.Text, System.DBNull.Value)
                DRnovo("Conta2") = IIf(My.Forms.DocumentoEntrada.Conta2.Text <> "", My.Forms.DocumentoEntrada.Conta2.Text, System.DBNull.Value)
                DRnovo("Conta3") = IIf(My.Forms.DocumentoEntrada.Conta3.Text <> "", My.Forms.DocumentoEntrada.Conta3.Text, System.DBNull.Value)
                DRnovo("Conta4") = IIf(My.Forms.DocumentoEntrada.Conta4.Text <> "", My.Forms.DocumentoEntrada.Conta4.Text, System.DBNull.Value)
                DRnovo("Conta5") = IIf(My.Forms.DocumentoEntrada.Conta5.Text <> "", My.Forms.DocumentoEntrada.Conta5.Text, System.DBNull.Value)
                DRnovo("Conta6") = IIf(My.Forms.DocumentoEntrada.Conta6.Text <> "", My.Forms.DocumentoEntrada.Conta6.Text, System.DBNull.Value)

                DRnovo("Vlr1") = IIf(NzZero(My.Forms.DocumentoEntrada.Vlr1.Text) > 0, My.Forms.DocumentoEntrada.Vlr1.Text, System.DBNull.Value)
                DRnovo("Vlr2") = IIf(NzZero(My.Forms.DocumentoEntrada.Vlr2.Text) > 0, My.Forms.DocumentoEntrada.Vlr2.Text, System.DBNull.Value)
                DRnovo("Vlr3") = IIf(NzZero(My.Forms.DocumentoEntrada.Vlr3.Text) > 0, My.Forms.DocumentoEntrada.Vlr3.Text, System.DBNull.Value)
                DRnovo("Vlr4") = IIf(NzZero(My.Forms.DocumentoEntrada.Vlr4.Text) > 0, My.Forms.DocumentoEntrada.Vlr4.Text, System.DBNull.Value)
                DRnovo("Vlr5") = IIf(NzZero(My.Forms.DocumentoEntrada.Vlr5.Text) > 0, My.Forms.DocumentoEntrada.Vlr5.Text, System.DBNull.Value)
                DRnovo("Vlr6") = IIf(NzZero(My.Forms.DocumentoEntrada.Vlr6.Text) > 0, My.Forms.DocumentoEntrada.Vlr6.Text, System.DBNull.Value)

                DRnovo("Percent1") = IIf(NzZero(My.Forms.DocumentoEntrada.Vlr1.Text) > 0, CDbl(NzZero(My.Forms.DocumentoEntrada.Vlr1.Text)) / (CDbl(My.Forms.DocumentoEntrada.ValorPedido.Text)) * 100, System.DBNull.Value)
                DRnovo("Percent2") = IIf(NzZero(My.Forms.DocumentoEntrada.Vlr2.Text) > 0, CDbl(NzZero(My.Forms.DocumentoEntrada.Vlr2.Text)) / (CDbl(My.Forms.DocumentoEntrada.ValorPedido.Text)) * 100, System.DBNull.Value)
                DRnovo("Percent3") = IIf(NzZero(My.Forms.DocumentoEntrada.Vlr3.Text) > 0, CDbl(NzZero(My.Forms.DocumentoEntrada.Vlr3.Text)) / (CDbl(My.Forms.DocumentoEntrada.ValorPedido.Text)) * 100, System.DBNull.Value)
                DRnovo("Percent4") = IIf(NzZero(My.Forms.DocumentoEntrada.Vlr4.Text) > 0, CDbl(NzZero(My.Forms.DocumentoEntrada.Vlr4.Text)) / (CDbl(My.Forms.DocumentoEntrada.ValorPedido.Text)) * 100, System.DBNull.Value)
                DRnovo("Percent5") = IIf(NzZero(My.Forms.DocumentoEntrada.Vlr5.Text) > 0, CDbl(NzZero(My.Forms.DocumentoEntrada.Vlr5.Text)) / (CDbl(My.Forms.DocumentoEntrada.ValorPedido.Text)) * 100, System.DBNull.Value)
                DRnovo("Percent6") = IIf(NzZero(My.Forms.DocumentoEntrada.Vlr6.Text) > 0, CDbl(NzZero(My.Forms.DocumentoEntrada.Vlr6.Text)) / (CDbl(My.Forms.DocumentoEntrada.ValorPedido.Text)) * 100, System.DBNull.Value)

            End If
            'verifica se o form compra esta ativo
            If My.Forms.Compra.Visible = True Then

                'DRnovo("ContaCr") = IIf(My.Forms.Compra.ContaCR.Text <> "", My.Forms.Compra.ContaCR.Text, System.DBNull.Value)

                DRnovo("Conta1") = IIf(My.Forms.Compra.Conta1.Text <> "", My.Forms.Compra.Conta1.Text, System.DBNull.Value)
                DRnovo("Conta2") = IIf(My.Forms.Compra.Conta2.Text <> "", My.Forms.Compra.Conta2.Text, System.DBNull.Value)
                DRnovo("Conta3") = IIf(My.Forms.Compra.Conta3.Text <> "", My.Forms.Compra.Conta3.Text, System.DBNull.Value)
                DRnovo("Conta4") = IIf(My.Forms.Compra.Conta4.Text <> "", My.Forms.Compra.Conta4.Text, System.DBNull.Value)
                DRnovo("Conta5") = IIf(My.Forms.Compra.Conta5.Text <> "", My.Forms.Compra.Conta5.Text, System.DBNull.Value)
                DRnovo("Conta6") = IIf(My.Forms.Compra.Conta6.Text <> "", My.Forms.Compra.Conta6.Text, System.DBNull.Value)

                DRnovo("Vlr1") = IIf(NzZero(My.Forms.Compra.Vlr1.Text) > 0, My.Forms.Compra.Vlr1.Text, System.DBNull.Value)
                DRnovo("Vlr2") = IIf(NzZero(My.Forms.Compra.Vlr2.Text) > 0, My.Forms.Compra.Vlr2.Text, System.DBNull.Value)
                DRnovo("Vlr3") = IIf(NzZero(My.Forms.Compra.Vlr3.Text) > 0, My.Forms.Compra.Vlr3.Text, System.DBNull.Value)
                DRnovo("Vlr4") = IIf(NzZero(My.Forms.Compra.Vlr4.Text) > 0, My.Forms.Compra.Vlr4.Text, System.DBNull.Value)
                DRnovo("Vlr5") = IIf(NzZero(My.Forms.Compra.Vlr5.Text) > 0, My.Forms.Compra.Vlr5.Text, System.DBNull.Value)
                DRnovo("Vlr6") = IIf(NzZero(My.Forms.Compra.Vlr6.Text) > 0, My.Forms.Compra.Vlr6.Text, System.DBNull.Value)

                DRnovo("Percent1") = IIf(NzZero(My.Forms.Compra.Vlr1.Text) > 0, CDbl(NzZero(My.Forms.Compra.Vlr1.Text)) / (CDbl(My.Forms.Compra.ValorCompra.Text)) * 100, System.DBNull.Value)
                DRnovo("Percent2") = IIf(NzZero(My.Forms.Compra.Vlr2.Text) > 0, CDbl(NzZero(My.Forms.Compra.Vlr2.Text)) / (CDbl(My.Forms.Compra.ValorCompra.Text)) * 100, System.DBNull.Value)
                DRnovo("Percent3") = IIf(NzZero(My.Forms.Compra.Vlr3.Text) > 0, CDbl(NzZero(My.Forms.Compra.Vlr3.Text)) / (CDbl(My.Forms.Compra.ValorCompra.Text)) * 100, System.DBNull.Value)
                DRnovo("Percent4") = IIf(NzZero(My.Forms.Compra.Vlr4.Text) > 0, CDbl(NzZero(My.Forms.Compra.Vlr4.Text)) / (CDbl(My.Forms.Compra.ValorCompra.Text)) * 100, System.DBNull.Value)
                DRnovo("Percent5") = IIf(NzZero(My.Forms.Compra.Vlr5.Text) > 0, CDbl(NzZero(My.Forms.Compra.Vlr5.Text)) / (CDbl(My.Forms.Compra.ValorCompra.Text)) * 100, System.DBNull.Value)
                DRnovo("Percent6") = IIf(NzZero(My.Forms.Compra.Vlr6.Text) > 0, CDbl(NzZero(My.Forms.Compra.Vlr6.Text)) / (CDbl(My.Forms.Compra.ValorCompra.Text)) * 100, System.DBNull.Value)

            End If


            TBL.Rows.Add(DRnovo)

            Venc = Venc.AddMonths(1)

        Next I

        'aqui faz a atualização do dados inseridos em memoria
        Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAPagar)
        DAPagar.Update(ds, "Pagar")
        ds.Dispose()

        MsgBox("Parcelas Geradas com sucesso.", 64, "Validação de Dados")
        GerarLog(Me.Text, AçãoTP.Confirmou, Me.Documento.Text)
        CNN.Close()
        System.Threading.Thread.Sleep(100)
        Me.EncheLista()
    End Sub

    Public Sub EncheLista()

        MyLista.Items.Clear()


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            If My.Forms.Compra.Visible = True Then
                .CommandText = "SELECT * FROM Pagar WHERE IdCompra = " & My.Forms.Compra.CompraInterno.Text & " and Baixado = False and Empresa = " & CodEmpresa & " and Inativo = False"
            ElseIf My.Forms.DocumentoEntrada.Visible = True Then
                .CommandText = "SELECT * FROM Pagar WHERE IdCompraCtrlPedido = " & My.Forms.DocumentoEntrada.Id.Text & " and Baixado = False and Empresa = " & CodEmpresa & " and Inativo = False"
            ElseIf SellShoesCompra.Visible = True Then
                .CommandText = "SELECT * FROM Pagar WHERE IdCompra = " & SellShoesCompra.CompraInterno.Text & " and Baixado = False and Empresa = " & CodEmpresa & " and Inativo = False"
            End If
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            Dim Tparcelado As Double = 0
            While DR.Read
                If Not IsDBNull(DR.Item("Id")) Then
                    Dim AA As String = DR.Item("Id")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("NotaFiscal") & "")
                    It.SubItems.Add(DR.Item("Documento") & "")
                    It.SubItems.Add(DR.Item("Fornecedor") & "")
                    It.SubItems.Add(DR.Item("Vencimento") & "")
                    It.SubItems.Add(FormatNumber(Nz(DR.Item("ValorDocumento"), 3), 2))

                    MyLista.Items.AddRange(New ListViewItem() {It})
                    Tparcelado += FormatNumber(Nz(DR.Item("ValorDocumento"), 3), 2)
                End If
            End While

            Me.Parcelado.Text = FormatNumber(Tparcelado, 2)

            DR.Close()
            CNN.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try

    End Sub


    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        'Dim I As Integer = 0
        'Dim IdPagar As Integer

        'For I = 0 To MyLista.Items.Count - 1
        '    If MyLista.Items(I).Selected = True Then IdPagar = (MyLista.Items(I).Text.Substring(0))
        'Next

        'EditaContaPagar(IdPagar)
        'Operation = UPD

        My.Forms.PagarEditParcelas.ShowDialog()
        EncheLista()
    End Sub

    Public Sub EditaContaPagar(ByVal IdConta As Integer)

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Close()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        With Cmd
            .Connection = CNN
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM Pagar WHERE Id = " & IdConta
            .CommandType = CommandType.Text
        End With

        Try
            DR = Cmd.ExecuteReader
            DR.Read()

            Me.Id.Text = DR.Item("Id")
            Me.Documento.Text = DR.Item("Documento") & ""
            Me.LabelNotaFiscal.Text = DR.Item("NotaFiscal") & ""
            Me.CodFornecedor.Text = DR.Item("CodFornecedor")
            Me.Fornecedor.Text = DR.Item("Fornecedor")
            Me.DataDocumento.Text = DR.Item("DataDocumento")
            Me.Vencimento.Text = DR.Item("Vencimento")
            Me.LocalPgto.Text = DR.Item("LocalPgto") & ""
            Me.Destino.Text = DR.Item("Destino") & ""

            Me.Vencimento.Enabled = True
            Me.LocalPgto.Enabled = True
            Me.Destino.Enabled = True


        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try

        CNN.Close()

    End Sub


    Public Sub LocalizaDadosFornecedor()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Close()

        Dim Sql As String = "Select * from Fornecedor where CódigoFornecedor = " & Me.CodFornecedor.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.CodFornecedor.Text = DR.Item("CódigoFornecedor") & ""
            Me.Fornecedor.Text = DR.Item("RazãoSocial") & ""
        End If

        DR.Close()
        CNN.Close()

    End Sub

    Private Sub CodFornecedor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CodFornecedor.Validated
        If Me.CodFornecedor.Text = "" Then
            Me.CodFornecedor.Focus() : Exit Sub
        Else
            LocalizaDadosFornecedor()
        End If
    End Sub



    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click

        If My.Forms.Compra.Visible = True Then
            If CDbl(NzZero(Me.Parcelado.Text)) <> CDbl(NzZero(Me.Parcelar.Text)) Then
                If Me.MyLista.Items.Count = 0 Then
                    My.Forms.Compra.CancelouPagar = True
                    Me.Close()
                    Me.Dispose()
                Else
                    MessageBox.Show("O usuário iniciou o parcelamento do documento, exclua os as contas para sair", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Else
                My.Forms.Compra.CancelouPagar = False
                Me.Close()
                Me.Dispose()
            End If
        End If

        If SellShoesCompra.Visible = True Then
            If CDbl(NzZero(Me.Parcelado.Text)) <> CDbl(NzZero(Me.Parcelar.Text)) Then
                If Me.MyLista.Items.Count = 0 Then
                    SellShoesCompra.CancelouPagar = True
                    Me.Close()
                    Me.Dispose()
                Else
                    MessageBox.Show("O usuário iniciou o parcelamento do documento, exclua os as contas para sair", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Else
                SellShoesCompra.CancelouPagar = False
                Me.Close()
                Me.Dispose()
            End If
        End If

        If My.Forms.DocumentoEntrada.Visible = True Then
            If CDbl(NzZero(Me.Parcelado.Text)) <> CDbl(NzZero(Me.Parcelar.Text)) Then
                If Me.MyLista.Items.Count = 0 Then
                    My.Forms.DocumentoEntrada.CancelouPagar = True
                    Me.Close()
                    Me.Dispose()
                Else
                    MessageBox.Show("O usuário iniciou o parcelamento do documento, exclua os as contas para sair", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Else
                My.Forms.DocumentoEntrada.CancelouPagar = False
                Me.Close()
                Me.Dispose()
            End If
        End If

    End Sub


    Private Sub ExcluirParcelaSelecionadaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirParcelaSelecionadaToolStripMenuItem.Click

        RetornoProcura = ""
        Dim I As Integer = 0

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then RetornoProcura = MyLista.Items(I).Text.Substring(0)
        Next

        If RetornoProcura = "" Then
            MsgBox("O usuário deve selecionar um item da lista.", 64, "Validação de Dados")
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Delete * from Pagar where Id = " & RetornoProcura & " and Baixado = False"
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader

        DR.Close()
        CNN.Close()

        EncheLista()
    End Sub

    Private Sub ExcluirTodasAsParcelasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirTodasAsParcelasToolStripMenuItem.Click
        'MsgBox("Esta opção esta inativa no sistema.", 64, "Validação de Dados")

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Id_Doc As String = String.Empty
        Dim Sql As String = String.Empty

        If My.Forms.Compra.Visible Then
            Id_Doc = My.Forms.Compra.CompraInterno.Text
            Sql = "Delete * from Pagar where IdCompra = " & Id_Doc & " and Baixado = False"
        End If

        If SellShoesCompra.Visible Then
            Id_Doc = SellShoesCompra.CompraInterno.Text
            Sql = "Delete * from Pagar where IdCompra = " & Id_Doc & " and Baixado = False"
        End If

        If My.Forms.DocumentoEntrada.Visible Then
            Id_Doc = My.Forms.DocumentoEntrada.Id.Text
            Sql = "Delete * from Pagar where IdCompraCtrlPedido = " & Id_Doc & " and Baixado = False"
        End If


        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader

        DR.Close()
        CNN.Close()

        EncheLista()

    End Sub


   
    Private Sub Vencimento_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Vencimento.Validating
        If Me.Vencimento.Text = "" Then Exit Sub
        If CDate(Me.Vencimento.Text) < CDate(Me.DataDocumento.Text) Then
            MessageBox.Show("A data de vencimento não pode ser menor que a data do documento, verifique...", "Validaçào de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Vencimento.Clear()
            Me.Vencimento.Focus()
            Exit Sub
        End If
    End Sub
End Class