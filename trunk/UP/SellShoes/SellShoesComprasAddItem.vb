Public Class SellShoesComprasAddItem

    Dim PercentualFrete As Double = 0

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2
    Dim oDT As New DataTable
    Dim objDS As DataSet
    Dim objDA As OleDb.OleDbDataAdapter
    Dim objRow As Data.DataRow

    Private Sub codigoproduto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoProduto.KeyDown
        If e.KeyCode = Keys.F5 Then
            SellShoesProdutoProcura.ShowDialog()
            LocalizaProduto()
        End If
    End Sub

    Private Sub codigoproduto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoProduto.Leave
        LocalizaProduto()
    End Sub

    Public Sub LocalizaProduto()
        If Me.CodigoProduto.Text = "" Then
            Exit Sub
            End
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Produtos where CodigoProduto = " & Me.CodigoProduto.Text '& " and tipo = " & TipoItensProcurar
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.DescProduto.Text = DR.Item("Descrição") & ""
            If Me.ValorUnitario.Text = "" Then Me.ValorUnitario.Text = FormatCurrency(Nz(0, 3), 2)
            Me.IcmsProduto.Text = FormatNumber(NzZero(DR.Item("icms")), 2)
            Me.IpiProduto.Text = FormatNumber(NzZero(DR.Item("ipi")), 2)
            Me.PisProduto.Text = FormatNumber(NzZero(DR.Item("pPIS")), 2)
            Me.CofinsProduto.Text = FormatNumber(NzZero(DR.Item("pCofins")), 2)
            Me.ConversorQtd.Text = FormatNumber(NzZero(DR.Item("Multiplos")), 2)
            EncheComboNum()
        Else
            Me.CodigoProduto.Clear()
            Me.DescProduto.Clear()
        End If

        DR.Close()
        CNN.Close()

    End Sub

    Private Sub Qtd_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qtd.Enter
        If Me.Qtd.Text = "" Then
            Me.Qtd.Text = FormatNumber(0, 2)
        End If
    End Sub

    Private Sub Qtd_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Qtd.Leave
        Me.Qtd.Text = FormatNumber(Nz(Me.Qtd.Text, 3), 4)
        Me.Total.Text = FormatCurrency(CDbl(Me.ValorUnitario.Text) * Me.Qtd.Text, 2)

    End Sub


    Sub CalcularImpostos()
        Me.ValorFreteProduto.Text = CDbl(NzZero(Me.Total.Text)) * CDbl(NzZero(Me.FreteProduto.Text)) / 100
        Me.ValorCofinsProduto.Text = CDbl(NzZero(Me.Total.Text)) * CDbl(NzZero(Me.CofinsProduto.Text)) / 100
        Me.ValorPisProduto.Text = CDbl(NzZero(Me.Total.Text)) * CDbl(NzZero(Me.PisProduto.Text)) / 100
        If Me.IpiProduto.Text = "" Then
            Me.IpiProduto.Text = 0
            Me.ValorIpiProduto.Text = FormatCurrency(0, 2)
        Else
            Me.ValorIpiProduto.Text = FormatCurrency(CDbl(Me.Total.Text) * CDbl(Me.IpiProduto.Text) / 100, 2)
        End If
        Me.ValorIcmsProduto.Text = CDbl(NzZero(Me.Total.Text)) * CDbl(NzZero(Me.IcmsProduto.Text)) / 100

    End Sub
    Private Sub SalvarItens_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarItens.Click
        If Me.CodigoProduto.Text = "" Then
            MsgBox("Não foi localizado um produto válido", 48, "Validador de Dados")
            Exit Sub
        End If


        If Me.CFOP.Text = "" Then
            MsgBox("Não foi informado o CFOP do produto.", 48, "Validador de Dados")
            Exit Sub
        End If

        If NzZero(Me.Qtd.Text) = 0 Then
            MessageBox.Show("O usuário não pode adicionar item com quantidade ZERO, favor verificar.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Qtd.Focus()
            Exit Sub
        End If

        If NzZero(Me.ValorUnitario.Text) = 0 Then
            MessageBox.Show("O usuário não pode adicionar um item com valor unitario ZERO.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ValorUnitario.Focus()
            Exit Sub
        End If


        If Me.cTamanho.Text = "" Then
            MessageBox.Show("O usuário não pode adicionar um item sem Tamanho.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.cTamanho.Focus()
            Exit Sub

        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        If Operation = INS Then
            CalcularImpostos()

            Dim Sql As String = "INSERT INTO ItensCompra (CodigoProduto, Qtd, ValorUnitario, TotalProduto, Ipi, ValorIpi, CompraInterno, IcmsProduto, ValorIcmsProduto, PisProduto, ValorPisProduto, CofinsProduto, ValorCofinsProduto, FreteProduto, ValorFreteProduto, ConversorQtd, CFOP, ValorP, tamanho) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18,@19)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", CInt(Me.CodigoProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", CDbl(Me.Qtd.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", CDbl(Me.ValorUnitario.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", CDbl(Me.Total.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", CDbl(NzZero(Me.IpiProduto.Text))))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", CDbl(NzZero(Me.ValorIpiProduto.Text))))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", CInt(My.Forms.SellShoesCompra.CompraInterno.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", NzZero(Me.IcmsProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzZero(Me.ValorIcmsProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", NzZero(Me.PisProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", NzZero(Me.ValorPisProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", NzZero(Me.CofinsProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", NzZero(Me.ValorCofinsProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", NzZero(Me.FreteProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", NzZero(Me.ValorFreteProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", NzZero(Me.ConversorQtd.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@17", NzZero(Me.CFOP.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@18", NzZero(Me.ValorP.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@19", NzZero(Me.cTamanho.Text)))

            Try
                cmd.ExecuteNonQuery()
                CNN.Close()

                MsgBox("Registro adicionado com sucesso", 64, "Validador de Dados")
                My.Forms.SellShoesCompra.AtGrade()

            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validador de Dados")
            End Try
        ElseIf Operation = UPD Then
            CalcularImpostos()

            Dim Sql As String = "Update ItensCompra set CodigoProduto = @1, Qtd = @2, ValorUnitario = @3, TotalProduto = @4, Ipi = @5, ValorIpi = @6, CompraInterno = @7, IcmsProduto = @8, ValorIcmsProduto = @9, PisProduto = @10, ValorPisProduto = @11, CofinsProduto = @12, ValorCofinsProduto = @13, FreteProduto = @14, ValorFreteProduto = @15, ConversorQtd = @16, CFOP = @17, ValorP = @18 Where Id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", CInt(Me.CodigoProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", CDbl(Me.Qtd.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", CDbl(Me.ValorUnitario.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", CDbl(Me.Total.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", CDbl(Me.IpiProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", CDbl(Me.ValorIpiProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", CInt(My.Forms.SellShoesCompra.CompraInterno.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", NzZero(Me.IcmsProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzZero(Me.ValorIcmsProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", NzZero(Me.PisProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", NzZero(Me.ValorPisProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", NzZero(Me.CofinsProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", NzZero(Me.ValorCofinsProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", NzZero(Me.FreteProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", NzZero(Me.ValorFreteProduto.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", NzZero(Me.ConversorQtd.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@17", NzZero(Me.CFOP.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@18", NzZero(Me.ValorP.Text)))

            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                My.Forms.SellShoesCompra.EncheListaItens()

                MsgBox("Registro Atualizado com sucesso", 64, "Validador de Dados")
                My.Forms.SellShoesCompra.AtGrade()
                Me.Close()
                Me.Dispose()
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
        End If

        Operation = INS

        Me.cTamanho.SelectedIndex = -1
        Me.Qtd.Clear()
        Me.cTamanho.Focus()
        Me.Total.Clear()


    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        My.Forms.SellShoesCompra.TabGeral.SelectedTab = My.Forms.SellShoesCompra.TabItem1

        Me.Close()

        Me.Dispose()
    End Sub

    Public Sub LocalizaItens()
        If Me.Id.Text = "" Then
            Exit Sub
            End
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT ItensCompra.*, Produtos.Descrição, CFOP.Descrição, ItensCompra.Id FROM (ItensCompra INNER JOIN Produtos ON ItensCompra.CodigoProduto = Produtos.CodigoProduto) LEFT JOIN CFOP ON ItensCompra.CFOP = CFOP.CFOP WHERE (((ItensCompra.Id)=" & Me.Id.Text & "));"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then

            Me.CodigoProduto.Text = DR.Item("CodigoProduto")
            Me.DescProduto.Text = DR.Item("Produtos.Descrição") & ""
            Me.CFOP.Text = DR.Item("CFOP") & ""
            Me.CFOPDesc.Text = DR.Item("CFOP.Descrição") & ""
            EncheComboNum()
            Me.Qtd.Text = FormatNumber(DR.Item("Qtd"), 4)
            Me.ConversorQtd.Text = FormatNumber(NzZero(DR.Item("ConversorQtd")), 4)
            Me.ValorUnitario.Text = FormatCurrency(NzZero(DR.Item("ValorUnitario")), 5)
            Me.ValorP.Text = FormatCurrency(NzZero(DR.Item("ValorP")), 5)
            Me.Total.Text = FormatCurrency(NzZero(DR.Item("TotalProduto")), 2)
            Me.cTamanho.Text = DR.Item("Tamanho") & ""
            Me.IcmsProduto.Text = FormatNumber(NzZero(DR.Item("IcmsProduto")), 2)
            Me.ValorIcmsProduto.Text = FormatCurrency(NzZero(DR.Item("ValorIcmsProduto")), 2)
            Me.IpiProduto.Text = FormatNumber(NzZero(DR.Item("Ipi")), 2)
            Me.ValorIpiProduto.Text = FormatCurrency(NzZero(DR.Item("ValorIpi")), 2)
            Me.PisProduto.Text = FormatNumber(NzZero(DR.Item("PisProduto")), 2)
            Me.ValorPisProduto.Text = FormatCurrency(NzZero(DR.Item("ValorPisProduto")), 2)
            Me.CofinsProduto.Text = FormatNumber(NzZero(DR.Item("CofinsProduto")), 2)
            Me.ValorCofinsProduto.Text = FormatCurrency(NzZero(DR.Item("ValorCofinsProduto")), 2)
            Me.FreteProduto.Text = FormatNumber(NzZero(DR.Item("FreteProduto")), 2)
            Me.ValorFreteProduto.Text = FormatCurrency(NzZero(DR.Item("ValorFreteProduto")), 2)

            Operation = UPD
        Else
            MessageBox.Show("Esta identificação do Produto não foi encontrada.", "Validador de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Operation = INS
            Me.CodigoProduto.Clear()
            Me.Qtd.Clear()
            Me.ValorUnitario.Clear()
            Me.ValorP.Clear()
            Me.Total.Clear()
            Me.FreteProduto.Clear()
            Me.ValorFreteProduto.Clear()
            Me.IcmsProduto.Clear()
            Me.ValorIcmsProduto.Clear()
            Me.IpiProduto.Clear()
            Me.ValorIpiProduto.Clear()
            Me.PisProduto.Clear()
            Me.ValorPisProduto.Clear()
            Me.CofinsProduto.Clear()
            Me.ValorCofinsProduto.Clear()
            Me.CodigoProduto.Focus()
        End If

        DR.Close()
        CNN.Close()

    End Sub
    Private Sub EncheComboNum()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "Select ProdutoGrade.Numero, ProdutoGrade.Sequencia From ProdutoGrade  Where Produto =" & Me.CodigoProduto.Text

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")


        Me.cTamanho.DataSource = ds.Tables("Table").DefaultView
        Me.cTamanho.DisplayMember = "Numero"
        Me.cTamanho.ValueMember = "Sequencia"
        Me.cTamanho.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

    End Sub
    Private Sub ComprasAddItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'ao carregar tela verifica o percentual do frete
        If My.Forms.SellShoesCompra.Visible = True Then
            If My.Forms.SellShoesCompra.ValorFrete.Text > 0 Then
                PercentualFrete = (NzZero(CDbl(My.Forms.SellShoesCompra.ValorFrete.Text)) / NzZero(CDbl(My.Forms.SellShoesCompra.ValorCompra.Text))) * 100
            End If
        End If
    End Sub

    Private Sub FreteProduto_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FreteProduto.Enter
        If NzZero(Me.FreteProduto.Text) = 0 Then
            Me.FreteProduto.Text = FormatNumber(PercentualFrete, 2)
        End If
    End Sub

    Private Sub AcharCFOP()
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
            Me.CFOPDesc.Text = DR.Item("Descrição") & ""
        Else
            Me.CFOP.Clear()
            Me.CFOPDesc.Clear()
            Me.CFOP.Focus()
        End If
        DR.Close()
        CNNBanco.Close()
    End Sub

    Private Sub CFOP_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CFOP.Validated
        If String.CompareOrdinal(Me.CFOP.Text, Me.CFOP.TextoAntigo) Then
            AcharCFOP()
        End If
    End Sub

    Private Sub btFindProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindProduto.Click
        SellShoesProdutoProcura.ShowDialog()
        LocalizaProduto()
    End Sub

    Private Sub btFindCFOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindCFOP.Click
        My.Forms.CFOPProcura.ShowDialog()
        AcharCFOP()
    End Sub

    Private Sub CFOP_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CFOP.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.CFOPProcura.ShowDialog()
            AcharCFOP()
        End If
    End Sub

    Private Sub ValorP_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorP.Enter
        If CDbl(NzZero(Me.ValorP)) = 0 Then
            Me.ValorP.Text = Me.ValorUnitario.Text
        End If

    End Sub


    Private Sub GroupNumeracao_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupNumeracao.Enter
        TravaCampos()
    End Sub
    Sub TravaCampos()
        Me.GroupImpostos.Enabled = False
        Me.CodigoProduto.Enabled = False
        Me.CFOP.Enabled = False
        Me.ValorUnitario.Enabled = False
        Me.ValorP.Enabled = False
        Me.btFindCFOP.Enabled = False
        Me.btFindProduto.Enabled = False
        Me.DescProduto.Enabled = False
        Me.CFOPDesc.Enabled = False
    End Sub
    Sub DestravaCampos()
        Me.GroupImpostos.Enabled = True
        Me.CodigoProduto.Enabled = True
        Me.CFOP.Enabled = True
        Me.ValorUnitario.Enabled = True
        Me.ValorP.Enabled = True
        Me.btFindCFOP.Enabled = True
        Me.btFindProduto.Enabled = True
        Me.DescProduto.Enabled = True
        Me.CFOPDesc.Enabled = True

    End Sub

    Private Sub butNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butNovo.Click
        DestravaCampos()
        Me.CodigoProduto.Clear()
        Me.DescProduto.Clear()
        Me.Qtd.Clear()
        Me.ValorUnitario.Clear()
        Me.Total.Clear()
        Me.FreteProduto.Clear()
        Me.ValorFreteProduto.Clear()
        Me.IcmsProduto.Clear()
        Me.ValorIcmsProduto.Clear()
        Me.IpiProduto.Clear()
        Me.ValorIpiProduto.Clear()
        Me.PisProduto.Clear()
        Me.ValorPisProduto.Clear()
        Me.CofinsProduto.Clear()
        Me.ValorCofinsProduto.Clear()
        Me.ConversorQtd.Clear()
        Me.ValorP.Clear()

        Me.CFOP.Clear()
        Me.CFOPDesc.Clear()

        Me.CodigoProduto.Focus()
        Me.cTamanho.SelectedIndex = -1

    End Sub
    Private Sub cTamanho_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cTamanho.Leave
        If Me.cTamanho.Text = "" Then
            Me.butNovo.Focus()
        End If
    End Sub
End Class