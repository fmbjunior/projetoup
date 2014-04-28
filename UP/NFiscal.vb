Public Class NFiscal
    Dim Ação As New TrfGerais()

    Dim Complementar As Boolean = False

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Dim InscPropriedade As String = ""
    Dim InscCliente As String = ""
    Dim CnpjCliente As String = ""
    Dim UFCliente As String = ""
    Dim UFPropriedade As String = ""


    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btItens_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btItens.Click

        If Me.Comfirmado.Checked = True Then
            MsgBox("Esta nota fiscal já foi confirmada, não pode ser alterada.", 64, "Validação de Dados")
            Exit Sub
        End If

        If Me.NotaFiscal.Text = "" Then
            MsgBox("Não foi informado o Nº da Nota Fiscal, verifique.", 64, "Validação de Dados")
            Exit Sub
        ElseIf Me.Pedido.Text = "" Then
            Me.Pedido.Text = 0
        ElseIf Me.Cliente.Text = "" Then
            MsgBox("Não foi informado o Cliente da Nota Fiscal, verifique.", 64, "Validação de Dados")
            Me.Cliente.Focus()
            Exit Sub
        ElseIf Me.Cnpj.Text = "" Then
            MsgBox("Não foi informado o Cnpj/Cpf do Cliente, verifique.", 64, "Validação de Dados")
            Me.Cnpj.Focus()
            Exit Sub
        ElseIf Me.Incrição.Text = "" Then
            MsgBox("Não foi informado a Incrição do Cliente/Propriedade, verifique.", 64, "Validação de Dados")
            Me.Cnpj.Focus()
            Exit Sub
        ElseIf Me.CFOP.Text = "" Then
            MsgBox("Não foi informado o CFOP da Nota Fiscal, verifique.", 64, "Validação de Dados")
            Me.CFOP.Focus()
            Exit Sub
        ElseIf Me.Serie.Text = "" Then
            MsgBox("Não foi informado a série da Nota Fiscal, verifique.", 64, "Validação de Dados")
            Me.Serie.Focus()
            Exit Sub
        ElseIf Me.Modelo.Text = "" Then
            MsgBox("Não foi informado o modelo da Nota Fiscal, verifique.", 64, "Validação de Dados")
            Me.Modelo.Focus()
            Exit Sub
        ElseIf Me.DataEmissao.Text = "" Then
            MsgBox("Não foi informado a data e emissão da Nota Fiscal, verifique.", 64, "Validação de Dados")
            Me.DataEmissao.Focus()
            Exit Sub
        ElseIf Me.UF.Text = "" Then
            MsgBox("Não foi informado o Estado para o faturamento da Nota Fiscal, verifique.", 64, "Validação de Dados")
            Me.UF.Focus()
            Exit Sub
        End If


        '  If Me.UF.Text <> "MS" And Mid(Me.CFOP.Text, 1, 1) <> 6 Then
        'MsgBox("Esta Cfop não pode ser utilizada para este estado", 64, "Validação de Dados")
        'Me.CFOP.Focus()
        'Exit Sub
        '' End If

        'If Me.UF.Text = "MS" And Mid(Me.CFOP.Text, 1, 1) <> 5 Then
        'MsgBox("Esta Cfop não pode ser utilizada para este estado", 64, "Validação de Dados")
        'Me.CFOP.Focus()
        'Exit Sub
        'End If

        ''If ChecaInscrE(Me.UF.Text, Me.Incrição.Text) = False Then
        ''      MsgBox("A Inscrição Estadual informada não é válida !!!", vbCritical, "Validação de Dados")
        ''Me.UF.Focus()
        ''Exit Sub
        ''End If

        If Operation = INS Then

            Dim CNNBanco As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNNBanco.Open()

            Dim Sql As String = "INSERT INTO NotaFiscal (NotaFiscal, Pedido, CFOP, Cliente, Propriedade, Cnpj, Incrição, DataEmissao, DataSaida, Modelo, Serie, Empresa, Uf) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNNBanco)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.NotaFiscal.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Pedido.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.CFOP.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Me.Cliente.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", RetornaValorComboBox(Me.Propriedade)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Cnpj.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Incrição.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.DataEmissao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.DataSaida.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.Modelo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Serie.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.UF.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                Operation = UPD

                'Salvar o numero da nota na empresa

                CNNBanco.Close()

                'trava controles
                Me.Pedido.Enabled = False
                Me.CFOP.Enabled = False
                Me.Cliente.Enabled = False
                Me.ClienteDesc.Enabled = False
                Me.Propriedade.Enabled = False
                Me.Cnpj.Enabled = False
                Me.Incrição.Enabled = False
                Me.UF.Enabled = False
                Me.DataEmissao.Enabled = False
                Me.DataSaida.Enabled = False
                Me.Modelo.Enabled = False
                Me.Serie.Enabled = False
                'Fim

            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
                Exit Sub
            End Try

        ElseIf Operation = UPD Then

            Dim CNNBanco As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNNBanco.Open()

            Dim Sql As String = "Update NotaFiscal set NotaFiscal = @1, Pedido = @2, CFOP = @3, Cliente = @4, Propriedade = @5, Cnpj = @6, Incrição = @7, DataEmissao = @8, DataSaida = @9, Modelo = @10, Serie = @11, Empresa = @12, Uf = @13 Where NotaFiscal = " & Me.NotaFiscal.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNNBanco)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.NotaFiscal.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Pedido.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.CFOP.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Me.Cliente.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", RetornaValorComboBox(Me.Propriedade)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Cnpj.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Incrição.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.DataEmissao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.DataSaida.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.Modelo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Serie.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.UF.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                Operation = UPD
                CNNBanco.Close()
                'trava controles
                Me.Pedido.Enabled = False
                Me.CFOP.Enabled = False
                Me.Cliente.Enabled = False
                Me.ClienteDesc.Enabled = False
                Me.Propriedade.Enabled = False
                Me.Cnpj.Enabled = False
                Me.Incrição.Enabled = False
                Me.UF.Enabled = False
                Me.DataEmissao.Enabled = False
                Me.DataSaida.Enabled = False
                Me.Modelo.Enabled = False
                Me.Serie.Enabled = False
                'Fim

            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, True)
        End If

        My.Forms.NfiscalLancaItens.ShowDialog()
        AtualizaListaItens()

        Me.ValorIss.Text = FormatNumber(0, 2)
        Me.AliquotaIss.Text = 0

        Me.TotalProdutos.Focus()
    End Sub

    Private Sub NFiscal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Operation = INS
    End Sub

#Region "Rotinas Auxiliares da Nota Fiscal"


    Public Sub EncheCaixas(ByVal ControleRetorno As Control, ByVal Tabela As String, ByVal CampoOrdenar As String, ByVal ItemDisplay As String, ByVal ItemCodigo As String, ByVal AgrupaItemDisplay As Boolean)

        Dim ItemCombo As New ArrayList

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select * from " & Tabela & " where Empresa = " & CodEmpresa & " order by " & CampoOrdenar
            .CommandType = CommandType.Text
        End With

        Try
            Cnn.Open()
            DataReader = Cmd.ExecuteReader

            If DataReader.HasRows = True Then
                With ItemCombo
                    While DataReader.Read
                        If Not IsDBNull(DataReader.Item(0)) Then
                            If AgrupaItemDisplay = True Then
                                .Add(New ItemData(DataReader.Item(ItemCodigo) & "-" & DataReader.Item(ItemDisplay), DataReader.Item(ItemCodigo), DataReader.Item(ItemCodigo)))
                            Else
                                .Add(New ItemData(DataReader.Item(ItemDisplay), DataReader.Item(ItemCodigo), DataReader.Item(ItemCodigo)))
                            End If
                        End If
                    End While
                End With
            End If
            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()

        With CType(ControleRetorno, ComboBox)
            .DataSource = ItemCombo
            .DisplayMember = "GetDescrição"
            .ValueMember = "GetidentificadorString"
        End With
        CType(ControleRetorno, ComboBox).SelectedIndex = -1
        'fim inserir ultimo registro

    End Sub

    Public Sub EncheListaPropriedade()
        If Me.Cliente.Text = "" Then
            Exit Sub
        End If

        Dim ItemCombo As New ArrayList

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader


        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select * from Propriedades Where Cliente = " & Me.Cliente.Text
            .CommandType = CommandType.Text
        End With

        Try
            Cnn.Open()
            DataReader = Cmd.ExecuteReader

            If DataReader.HasRows = True Then
                With ItemCombo
                    While DataReader.Read
                        If Not IsDBNull(DataReader.Item(0)) Then
                            .Add(New ItemData(DataReader.Item("NomePropriedade"), DataReader.Item("Id"), DataReader.Item("Id")))
                        End If
                    End While
                End With
            End If
            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()

        Try
            With CType(Me.Propriedade, ComboBox)
                .DataSource = ItemCombo
                .DisplayMember = "GetDescrição"
                .ValueMember = "Getidentificador"
            End With
            Me.Propriedade.SelectedIndex = -1
        Catch
            Exit Sub
        End Try

        'fim inserir ultimo registro

    End Sub

    Public Sub PropriedadeDadosComplementos()
        If Me.Propriedade.Text = "" Then
            Exit Sub
        Else

            Dim CNNBanco As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNNBanco.Open()

            Dim Cmd As New OleDb.OleDbCommand()
            Dim DataReader As OleDb.OleDbDataReader


            With Cmd
                .Connection = CNNBanco
                .CommandTimeout = 0
                .CommandText = "Select * from Propriedades Where Id = " & NzZero(Me.Propriedade.SelectedValue)
                .CommandType = CommandType.Text
            End With

            Try

                DataReader = Cmd.ExecuteReader

                If DataReader.HasRows = True Then
                    While DataReader.Read
                        If Not IsDBNull(DataReader.Item(0)) Then
                            InscPropriedade = DataReader.Item("Inscricao") & ""
                            UFPropriedade = DataReader.Item("Estado") & ""
                        End If
                    End While
                End If
                DataReader.Close()

            Catch Merror As System.Exception
                MsgBox(Merror.ToString)
                If ConnectionState.Open Then
                    Exit Sub
                End If
            End Try

        End If

    End Sub

    Public Sub ClienteDadosComplementos()
        If Me.Cliente.Text = "" Then
            Exit Sub
        Else
            Dim CNNBanco As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNNBanco.Open()

            Dim Cmd As New OleDb.OleDbCommand()
            Dim DataReader As OleDb.OleDbDataReader


            With Cmd
                .Connection = CNNBanco
                .CommandTimeout = 0
                .CommandText = "Select * from Clientes Where Codigo = " & Me.Cliente.Text
                .CommandType = CommandType.Text
            End With

            Try
                DataReader = Cmd.ExecuteReader

                If DataReader.HasRows = True Then
                    While DataReader.Read
                        If Not IsDBNull(DataReader.Item(0)) Then
                            CnpjCliente = DataReader.Item("CpfCgc") & ""
                            InscCliente = DataReader.Item("Insc") & ""
                            UFCliente = DataReader.Item("Estado") & ""
                            Me.ControlarEstoque.Checked = DataReader.Item("ControlarEstoque")
                        End If
                    End While
                End If
                DataReader.Close()

            Catch Merror As System.Exception
                MsgBox(Merror.ToString)
                If ConnectionState.Open Then
                    Exit Sub
                End If
            End Try

        End If
    End Sub
#End Region

    Private Sub Pedido_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pedido.Enter
        If NotaFiscalAvulsa = False Then
            If Me.Pedido.Text = "" Then
                Me.Pedido.Text = My.Forms.PedidoVenda.PedidoSequencia.Text
            End If
        End If
    End Sub

    Private Sub Cliente_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cliente.Enter
        If NotaFiscalAvulsa = False Then
            If Me.Cliente.Text = "" Then
                Me.Cliente.Text = My.Forms.PedidoVenda.CódigoCliente.Text
                Ação.Descrição_ItenRegistro(Me.Cliente, Me.ClienteDesc, "Clientes", "Codigo", Me.Cliente.Text, "Nome", TrfGerais.TipoDados.Numérico, True)
            End If
        End If
    End Sub

    Private Sub Propriedade_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Propriedade.Enter
        If Me.Propriedade.Text = "" Then
            EncheListaPropriedade()
        End If
    End Sub

    Private Sub Cnpj_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cnpj.Enter
        PropriedadeDadosComplementos()
        ClienteDadosComplementos()
        If Me.Propriedade.Text <> "" Then
            Me.Cnpj.Text = CnpjCliente
            Me.Incrição.Text = InscPropriedade
            Me.UF.Text = UFPropriedade
        Else
            Me.Cnpj.Text = CnpjCliente
            Me.Incrição.Text = InscCliente
            Me.UF.Text = UFCliente
        End If
    End Sub

    Private Sub DataEmissao_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataEmissao.Enter
        If Me.DataEmissao.Text = "" Then
            Me.DataEmissao.Text = DataDia
        End If
    End Sub

    Private Sub DataSaida_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataSaida.Enter
        If Me.DataSaida.Text = "" Then
            Me.DataSaida.Text = DataDia
        End If
    End Sub

    Private Sub Modelo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Modelo.Enter
        If Me.Modelo.Text = "" Then
            Me.Modelo.Text = "01"
        End If
    End Sub

    Private Sub Serie_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Serie.Enter
        If Me.Serie.Text = "" Then
            Me.Serie.Text = "U"
        End If
    End Sub

    Private Sub Cliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cliente.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ClientesProcura.ShowDialog()
            If Me.Cliente.Text <> "" Then
                Ação.Descrição_ItenRegistro(Me.Cliente, Me.ClienteDesc, "Clientes", "Codigo", Me.Cliente.Text, "Nome", TrfGerais.TipoDados.Numérico, True)
                Me.Cliente.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Cliente_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cliente.Leave
        If Me.Cliente.Text <> "" Then
            Ação.Descrição_ItenRegistro(Me.Cliente, Me.ClienteDesc, "Clientes", "Codigo", Me.Cliente.Text, "Nome", TrfGerais.TipoDados.Numérico, True)
        End If
    End Sub

    Private Sub BtClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClientes.Click
        My.Forms.Clientes.ShowDialog()
    End Sub

    Private Sub Propriedade_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Propriedade.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Propriedade.SelectedItem = Me.Propriedade.Text
            Me.Cnpj.Focus()
        End If
    End Sub


    Public Sub AtualizaListaItens()

        If Me.NotaFiscal.Text = "" Then
            Exit Sub
        End If

        Me.MyLista.Items.Clear()

        Dim CNNBanco As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNNBanco.Open()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader


        With Cmd
            .Connection = CNNBanco
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM NotaFiscalItens WHERE NotaFiscal = " & Me.NotaFiscal.Text & " Order by NotaFiscalItens.Seqnf"
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            Dim TotProdutos As Double = 0
            Dim TotDesconto As Double = 0
            Dim TotIpi As Double = 0

            Dim Zebrar As Boolean = False
            While DataReader.Read
                If Not IsDBNull(DataReader.Item("Produto")) Then
                    Dim AA As String = DataReader.Item("Produto")
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("Descricao") & "")
                    item1.SubItems.Add(FormatNumber(DataReader.Item("Qtd"), 4))
                    item1.SubItems.Add(DataReader.Item("Cst") & "")
                    item1.SubItems.Add(DataReader.Item("Cf") & "")
                    item1.SubItems.Add(FormatNumber(NzZero(DataReader.Item("Unitario")), 2))
                    item1.SubItems.Add(FormatNumber(NzZero(DataReader.Item("ValorDesconto")), 2))
                    item1.SubItems.Add(FormatNumber(NzZero(DataReader.Item("ValorTotal")), 2))
                    item1.SubItems.Add(DataReader.Item("Icms") & "")
                    item1.SubItems.Add(DataReader.Item("Ipi") & "")
                    item1.SubItems.Add(FormatNumber(NzZero(DataReader.Item("ValorIpi")), 2))
                    item1.SubItems.Add(DataReader.Item("SeqNf") & "")
                    item1.SubItems.Add(DataReader.Item("Id"))

                    MyLista.Items.AddRange(New ListViewItem() {item1})

                    TotProdutos += CDbl(DataReader.Item("ValorTotal"))
                    TotDesconto += CDbl(DataReader.Item("ValorDesconto"))
                    TotIpi += CDbl(DataReader.Item("ValorIpi"))

                    If Zebrar = True Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.MistyRose
                        Zebrar = True
                    End If

                End If
            End While

            Me.TotalProdutos.Text = FormatNumber(TotProdutos, 2)
            Me.Desconto.Text = FormatNumber(TotDesconto, 2)
            Me.TTIPI.Text = FormatNumber(TotIpi, 2)

            Me.MyLista.Refresh()
            DataReader.Close()
            CNNBanco.Close()
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                CNNBanco.Close()
                Exit Sub
            End If
        End Try


    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        If Me.Comfirmado.Checked = True Then
            MsgBox("Esta nota fiscal já foi confirmada, não pode ser alterada.", 64, "Validação de Dados")
            Exit Sub
        End If

        Dim I As Integer = 0
        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then Me.IdProduto.Text = (MyLista.Items(I).SubItems(12).Text.Substring(0))
        Next

        If Me.IdProduto.Text = "" Then
            MsgBox("Não foi selecionado nenhum item para ser editado, verifique...", 64, "Validação de Dados")
            Exit Sub
        End If
        My.Forms.NfiscalEditaItens.ShowDialog()
        AtualizaListaItens()

    End Sub

    Private Sub TotalNota_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TotalNota.Enter
        If Me.ValorServiço.Text = "" Then Me.ValorServiço.Text = FormatNumber(0, 2)
        If Me.TotalProdutos.Text = "" Then Me.TotalProdutos.Text = FormatNumber(0, 2)
        If Me.Desconto.Text = "" Then Me.Desconto.Text = FormatNumber(0, 2)
        If Me.TTIPI.Text = "" Then Me.TTIPI.Text = FormatCurrency(0, 2)

        If Complementar = False Then

            If DescontoEmLinha = False Then
                If Me.ReterImpostosServiço.Text = "N" Then
                    Me.TotalNota.Text = FormatNumber(CDbl(Me.ValorServiço.Text) + CDbl(Me.TotalProdutos.Text) - CDbl(Me.Desconto.Text) + CDbl(Me.TTIPI.Text) - CDbl(Me.ValorIss.Text) - CDbl(Me.ValorInss.Text), 2)
                Else
                    Me.TotalNota.Text = FormatNumber(CDbl(Me.ValorServiço.Text) + CDbl(Me.TotalProdutos.Text) - CDbl(Me.Desconto.Text) + CDbl(Me.TTIPI.Text), 2)
                End If
            Else
                If Me.ReterImpostosServiço.Text = "N" Then
                    Me.TotalNota.Text = FormatNumber(CDbl(Me.ValorServiço.Text) + CDbl(Me.TotalProdutos.Text) + CDbl(Me.TTIPI.Text) - CDbl(Me.ValorIss.Text) - CDbl(Me.ValorInss.Text), 2)
                Else
                    Me.TotalNota.Text = FormatNumber(CDbl(Me.ValorServiço.Text) + CDbl(Me.TotalProdutos.Text) + CDbl(Me.TTIPI.Text), 2)
                End If
            End If
        End If
    End Sub

    Private Sub ValorIss_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorIss.Enter
        If Me.AliquotaIss.Text = "" Then Me.AliquotaIss.Text = 0
        If Me.ValorServiço.Text = "" Then Me.ValorServiço.Text = FormatNumber(0, 2)

        Me.ValorIss.Text = FormatNumber((CDbl(Me.ValorServiço.Text) * CDbl(Me.AliquotaIss.Text)) / 100, 2)
    End Sub

    Private Sub btConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConfirmar.Click

        If Me.Comfirmado.Checked = True Then
            MsgBox("Esta nota fiscal já foi confirmada, não pode ser alterada.", 64, "Validação de Dados")
            Exit Sub
        End If


        If Operation = INS Then
            MsgBox("O usuário ainda não salvou a nota fiscal, navegue até os istens para salvar.", 64, "Validação de Dados")
            Exit Sub
        End If
        If Me.NotaFiscal.Text = "" Then
            MsgBox("O usuário deve selecionar uma nota fiscal.", 64, "Validação de Dados")
            Exit Sub
        End If

        If Me.ValorServiço.Text = "" Then
            Me.ValorServiço.Text = FormatNumber(0, 2)
        ElseIf Me.AliquotaIss.Text = "" Then
            Me.AliquotaIss.Text = 0
        ElseIf Me.ValorServiço.Text = "" Then
            Me.ValorServiço.Text = FormatNumber(0, 2)
        ElseIf Me.ValorIss.Text = "" Then
            Me.ValorIss.Text = FormatNumber(0, 2)
        ElseIf Me.TotalProdutos.Text = "" Then
            Me.TotalProdutos.Text = FormatNumber(0, 2)
        ElseIf Me.Desconto.Text = "" Then
            Me.Desconto.Text = FormatNumber(0, 2)
        ElseIf Me.TotalNota.Text = "" Then
            Me.TotalNota.Text = FormatNumber(0, 2)
        ElseIf Me.CFOP.Text = "" Then
            MsgBox("O usuário deve selecionar um CFOP para proseguir.", 64, "Validação de Dados")
            Me.CFOP.Focus()
            Exit Sub
        End If

        If Complementar = False Then
            Me.ValorIss.Text = FormatNumber((NzZero(CDbl(Me.ValorServiço.Text)) * CDbl(NzZero(Me.AliquotaIss.Text))) / 100, 2)

            If DescontoEmLinha = False Then
                If Me.ReterImpostosServiço.Text = "N" Then
                    Me.TotalNota.Text = FormatNumber(CDbl(Me.ValorServiço.Text) + CDbl(Me.TotalProdutos.Text) - CDbl(Me.Desconto.Text) + CDbl(Me.TTIPI.Text) - CDbl(Me.ValorIss.Text) - CDbl(Me.ValorInss.Text), 2)
                Else
                    Me.TotalNota.Text = FormatNumber(CDbl(Me.ValorServiço.Text) + CDbl(Me.TotalProdutos.Text) - CDbl(Me.Desconto.Text) + CDbl(Me.TTIPI.Text), 2)
                End If
            Else
                If Me.ReterImpostosServiço.Text = "N" Then
                    Me.TotalNota.Text = FormatNumber(CDbl(Me.ValorServiço.Text) + CDbl(Me.TotalProdutos.Text) + CDbl(Me.TTIPI.Text) - CDbl(Me.ValorIss.Text) - CDbl(Me.ValorInss.Text), 2)
                Else
                    Me.TotalNota.Text = FormatNumber(CDbl(Me.ValorServiço.Text) + CDbl(Me.TotalProdutos.Text) + CDbl(Me.TTIPI.Text), 2)
                End If
            End If
        End If

        My.Forms.NFConfirmar.ShowDialog()

        If Me.Comfirmado.Checked = True Then
            Me.DescriçãoServiço.Enabled = False
            Me.ValorServiço.Enabled = False
            Me.AliquotaIss.Enabled = False
            Me.ValorIss.Enabled = False
            Me.TotalProdutos.Enabled = False
            Me.Desconto.Enabled = False
            Me.TotalNota.Enabled = False
        Else
            Me.DescriçãoServiço.Enabled = True
            Me.ValorServiço.Enabled = True
            Me.AliquotaIss.Enabled = True
            Me.ValorIss.Enabled = True
            Me.TotalProdutos.Enabled = True
            Me.Desconto.Enabled = True
            Me.TotalNota.Enabled = True
        End If
    End Sub

    Private Sub Desconto_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Desconto.Enter

        If Me.Desconto.Text = "" Then FormatCurrency(0, 2)

        If DescontoEmLinha = True Then
            Me.Desconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Else
            Me.Desconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        End If
    End Sub

    Private Sub ValorInss_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorInss.Enter
        If Me.ValorInss.Text = "" Then Me.ValorInss.Text = FormatCurrency(0, 2)
    End Sub

    Private Sub ValorInss_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorInss.Leave
        If Me.ValorInss.Text = "" Then Me.ValorInss.Text = FormatCurrency(0, 2)
    End Sub

    Private Sub ReterImpostosServiço_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReterImpostosServiço.Enter
        If Me.ReterImpostosServiço.Text = "" Then Me.ReterImpostosServiço.Text = "S"
    End Sub

    Private Sub ReterImpostosServiço_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReterImpostosServiço.Leave
        If Me.ReterImpostosServiço.Text = "" Then Me.ReterImpostosServiço.Text = "S"
    End Sub

    Private Sub NatOperação_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CFOP.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.CFOPProcura.ShowDialog()
        End If
    End Sub

    Private Sub CFOP_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CFOP.Validated

        If Me.CFOP.Text = "" Then Exit Sub

        Dim DR As OleDb.OleDbDataReader

        Dim CNNBanco As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNNBanco.Open()

        Dim Sql As String = "Select * from CFOP where CFOP = '" & Me.CFOP.Text & "' And inativo = False"
        Dim CMD As New OleDb.OleDbCommand(Sql, CNNBanco)

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows = True Then
            Me.CFOP.Text = DR.Item("CFOP") & ""
            Me.NatOperaçãoDesc.Text = DR.Item("Descrição") & ""
        End If
        DR.Close()

    End Sub

    Private Sub DestravarCamposParaNFComplementarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DestravarCamposParaNFComplementarToolStripMenuItem.Click
        Complementar = True
        Me.TotalNota.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.TotalProdutos.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
    End Sub



   
    Private Sub NotaFiscal_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotaFiscal.Validated
        If String.CompareOrdinal(Me.NotaFiscal.Text, Me.NotaFiscal.TextoAntigo) Then
            AcharNF()
        End If
    End Sub

    Private Sub AcharNF()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        CNN.Open()

        'dados da Nf
        Dim Sql As String = "SELECT Clientes.Nome, CFOP.Descrição, * FROM (NotaFiscal LEFT JOIN CFOP ON NotaFiscal.CFOP = CFOP.CFOP) LEFT JOIN Clientes ON NotaFiscal.Cliente = Clientes.Codigo WHERE (((NotaFiscal.NotaFiscal)=" & Me.NotaFiscal.Text & "));"
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        Dim PropriedadeVar As String = String.Empty

        If DR.HasRows = True Then

            Me.CFOP.Text = DR.Item("NotaFiscal.Cfop") & ""
            Me.NatOperaçãoDesc.Text = DR.Item("Descrição") & ""

            Me.Cliente.Text = DR.Item("Cliente") & ""
            Me.ClienteDesc.Text = DR.Item("Nome") & ""
            Me.Cnpj.Text = DR.Item("Cnpj") & ""
            Me.Incrição.Text = DR.Item("Incrição") & ""
            Me.UF.Text = DR.Item("UF") & ""

            Me.DataEmissao.Text = DR.Item("DataEmissao") & ""
            Me.DataSaida.Text = DR.Item("DataSaida") & ""
            Me.Modelo.Text = DR.Item("Modelo") & ""
            Me.Serie.Text = DR.Item("Serie") & ""

            Me.TotalProdutos.Text = FormatNumber(Nz(DR.Item("TotalProdutos"), 3), 2)

            Me.TotalNota.Text = FormatNumber(Nz(DR.Item("TotalNota"), 3), 2)
            PropriedadeVar = DR.Item("Propriedade")

            Me.Pedido.Text = DR.Item("Pedido")
            Me.Comfirmado.Checked = DR.Item("Comfirmado")

            DR.Close()
            CNN.Close()

            EncheListaPropriedade()
            Me.Propriedade.SelectedItem = PropriedadeVar

            AtualizaListaItens()
            If Me.Comfirmado.Checked = True Then
                Me.Ação.Desbloquear_Controle(Me, False)
            End If
            Me.NotaFiscal.Enabled = True
            Me.NotaFiscal.Focus()
            Operation = UPD

        Else
            Dim NFTemp As String = Me.NotaFiscal.Text
            CNN.Close()
            Me.Ação.Desbloquear_Controle(Me, True)
            Me.Ação.LimpaTextBox(Me)
            Me.MyLista.Items.Clear()
            Me.Comfirmado.Checked = False
            Me.NotaFiscal.Text = NFTemp
            Me.Pedido.Focus()

        End If



    End Sub

    Private Sub Novo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Novo.Click

        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)
        Operation = INS
        Me.MyLista.Items.Clear()
        Me.NotaFiscal.Focus()
    End Sub
End Class