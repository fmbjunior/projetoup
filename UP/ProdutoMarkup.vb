Public Class ProdutoMarkup

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ProdutoMarkup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Forms.Produtos.Visible = True Then
            Me.CodigoProduto.Text = My.Forms.Produtos.CodigoProduto.Text
            Me.ValorCompra.Text = FormatCurrency(My.Forms.Produtos.ValorCompra.Text, 2)
            DadosMarkup()
        End If
    End Sub

    Private Sub DadosMarkup()

        If Me.CodigoProduto.Text = "" Then
            Exit Sub
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT * FROM Produtos WHERE Produtos.CodigoProduto = " & Me.CodigoProduto.Text

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.FreteEntrada.Text = NzZero(DR.Item("FreteEntrada"))
            Me.IcmsEntrada.Text = NzZero(DR.Item("IcmsEntrada"))
            Me.PisEntrada.Text = NzZero(DR.Item("PisEntrada"))
            Me.CofinsEntrada.Text = NzZero(DR.Item("CofinsEntrada"))
            Me.IpiEntrada.Text = NzZero(DR.Item("IpiEntrada"))
            Me.mkPisVenda.Text = NzZero(DR.Item("mkPisVenda"))
            Me.mkCofinsVenda.Text = NzZero(DR.Item("mkCofinsVenda"))
            Me.mkIcmsVenda.Text = NzZero(DR.Item("mkIcmsVenda"))
            Me.mkIpiVenda.Text = NzZero(DR.Item("mkIpiVenda"))
            Me.mkComissaoVenda.Text = NzZero(DR.Item("mkComissaoVenda"))
            Me.mkOutrosVenda.Text = NzZero(DR.Item("mkOutrosVenda"))
            Me.mkMargemLucroVenda.Text = NzZero(DR.Item("mkMargemLucroVenda"))
            Me.mkOperador.Text = NzZero(DR.Item("mkOperador"))
        End If
        DR.Close()

    End Sub

    'Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
    '    If Me.PisEntrada.Text = "" Then Me.PisEntrada.Text = 0
    '    If Me.CofinsEntrada.Text = "" Then Me.CofinsEntrada.Text = 0
    '    If Me.IcmsEntrada.Text = "" Then Me.IcmsEntrada.Text = 0
    '    If Me.mkIcmsVenda.Text = "" Then Me.mkIcmsVenda.Text = 0
    '    If Me.IpiEntrada.Text = "" Then Me.IpiEntrada.Text = 0
    '    If Me.FreteEntrada.Text = "" Then Me.FreteEntrada.Text = 0
    '    If Me.mkComissaoVenda.Text = "" Then Me.mkComissaoVenda.Text = 0
    '    If Me.mkOutrosVenda.Text = "" Then Me.mkOutrosVenda.Text = 0
    '    If Me.mkMargemLucroVenda.Text = "" Then Me.mkMargemLucroVenda.Text = 0
    '    If Me.mkOperador.Text = "" Then Me.mkOperador.Text = 0
    '    If Me.mkPisVenda.Text = "" Then Me.mkPisVenda.Text = 0
    '    If Me.mkCofinsVenda.Text = "" Then Me.mkCofinsVenda.Text = 0
    '    If Me.mkIpiVenda.Text = "" Then Me.mkIpiVenda.Text = 0

    '    'achar o operador do calculo do markup
    '    Dim varMKcusto As Double = CDbl(NzZero(Me.mkPis.Text)) + CDbl(NzZero(Me.mkCofins.Text)) + CDbl(NzZero(Me.mkIpi.Text)) + CDbl(NzZero(Me.mkFrete.Text)) + CDbl(NzZero(Me.mkOutros.Text)) + CDbl(NzZero(Me.mkComissaoVenda.Text)) + (CDbl(NzZero(Me.mkIcmsVenda.Text)) - CDbl(NzZero(Me.mkIcmsEntrada.Text)))
    '    Dim VarMkOperadorCusto As Double = (100 - varMKcusto)
    '    VarMkOperadorCusto = FormatNumber(VarMkOperadorCusto / 100, 3)
    '    VarMkOperadorCusto = FormatNumber((1 / VarMkOperadorCusto), 3)
    '    Me.mkOperadorCusto.Text = FormatNumber(VarMkOperadorCusto, 3)


    '    Dim varMK As Double = CDbl(NzZero(Me.mkPis.Text)) + CDbl(NzZero(Me.mkCofins.Text)) + CDbl(NzZero(Me.mkIpi.Text)) + CDbl(NzZero(Me.mkFrete.Text)) + CDbl(NzZero(Me.mkOutros.Text)) + CDbl(NzZero(Me.MargemLucro.Text)) + CDbl(NzZero(Me.mkComissaoVenda.Text)) + (CDbl(NzZero(Me.mkIcmsVenda.Text)) - CDbl(NzZero(Me.mkIcmsEntrada.Text)))
    '    Dim VarMkOperador As Double = (100 - varMK)
    '    VarMkOperador = FormatNumber(VarMkOperador / 100, 3)
    '    VarMkOperador = FormatNumber((1 / VarMkOperador), 3)
    '    Me.mkOperador.Text = FormatNumber(VarMkOperador, 3)

    '    Me.ValorVenda.Text = FormatCurrency(Me.ValorCompra.Text * Me.mkOperador.Text, 2)
    '    Me.mkCustoFinal.Text = FormatCurrency(Me.ValorCompra.Text * Me.mkOperadorCusto.Text, 2)

    '    'Atualizar os dados do produto

    '    Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

    '    If Edi = False Then
    '        MsgBox("O Usuário não tem permissão para editar o registro, verifique com o Administrador.", 64, "Validação de Dados")
    '        Exit Sub
    '    End If

    '    CNN.Open()

    '    Dim Sql As String = "UPDATE Produtos SET  mkPis = @1, mkCofins = @2, mkIcmsEntrada = @3, mkIcmsVenda = @4, mkIpi = @5, mkFrete = @6, mkComissaoVenda = @7, mkOutros = @8, MargemLucro = @9, mkOperador = @10, ValorCompra = @11, ValorVenda = @12, mkCustoFinal = @13, mkOperadorCusto = @14  Where CodigoProduto = " & Me.CodigoProduto.Text
    '    Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@1", NzZero(Me.mkPis.Text)))
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@2", NzZero(Me.mkCofins.Text)))
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@3", NzZero(Me.mkIcmsEntrada.Text)))
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@4", NzZero(Me.mkIcmsVenda.Text)))
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@5", NzZero(Me.mkIpi.Text)))
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@6", NzZero(Me.mkFrete.Text)))
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@7", NzZero(Me.mkComissaoVenda.Text)))
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@8", NzZero(Me.mkOutros.Text)))
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzZero(Me.MargemLucro.Text)))
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@10", NzZero(Me.mkOperador.Text)))
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@11", NzZero(Me.ValorCompra.Text)))
    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@12", NzZero(Me.ValorVenda.Text)))


    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@13", NzZero(Me.mkCustoFinal.Text)))

    '    cmd.Parameters.Add(New OleDb.OleDbParameter("@14", NzZero(Me.mkOperadorCusto.Text)))

    '    Try
    '        cmd.ExecuteNonQuery()
    '        CNN.Close()

    '        If My.Forms.Produtos.Visible = True Then
    '            My.Forms.Produtos.ValorVenda.Text = Me.ValorVenda.Text
    '        End If

    '        MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
    '    Catch x As Exception
    '        MsgBox(x.Message)
    '        Exit Sub
    '    End Try



    'End Sub

    Private Sub AlterarOperadorMarkup()
        Dim varMK As Double = FormatNumber(CDbl(NzZero(Me.mkOutrosVenda.Text)) + CDbl(NzZero(Me.mkMargemLucroVenda.Text)) + CDbl(NzZero(Me.mkComissaoVenda.Text)) + CDbl(NzZero(Me.mkIcmsVenda.Text)) + CDbl(NzZero(Me.mkCofinsVenda.Text)) + CDbl(NzZero(Me.mkPisVenda.Text)), 2)
        Dim VarMkOperador As Double = FormatNumber((100 - varMK), 2)
        VarMkOperador = FormatNumber(VarMkOperador / 100, 3)
        VarMkOperador = FormatNumber((1 / VarMkOperador), 2)
        Me.mkOperador.Text = FormatNumber(VarMkOperador, 2)
    End Sub



    Private Sub btAcharMakup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAcharMakup.Click
        My.Forms.MarkupProcura.ShowDialog()
        AcharMarkupCadastro(RetornoProcura)
    End Sub

    Private Sub AcharMarkupCadastro(ByVal StrProcura As String)


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT * FROM Markup WHERE DescMarkup = '" & RetornoProcura & "'"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then

            Me.FreteEntrada.Text = NzZero(DR.Item("FreteEntrada"))
            Me.IcmsEntrada.Text = NzZero(DR.Item("IcmsEntrada"))
            Me.PisEntrada.Text = NzZero(DR.Item("PisEntrada"))
            Me.CofinsEntrada.Text = NzZero(DR.Item("CofinsEntrada"))
            Me.IpiEntrada.Text = NzZero(DR.Item("IpiEntrada"))
            Me.mkPisVenda.Text = NzZero(DR.Item("mkPisVenda"))
            Me.mkCofinsVenda.Text = NzZero(DR.Item("mkCofinsVenda"))
            Me.mkIcmsVenda.Text = NzZero(DR.Item("mkIcmsVenda"))
            Me.mkIpiVenda.Text = NzZero(DR.Item("mkIpiVenda"))
            Me.mkComissaoVenda.Text = NzZero(DR.Item("mkComissaoVenda"))
            Me.mkOutrosVenda.Text = NzZero(DR.Item("mkOutrosVenda"))
            Me.mkMargemLucroVenda.Text = NzZero(DR.Item("mkMargemLucroVenda"))
            Me.mkOperador.Text = NzZero(DR.Item("mkOperador"))


        End If
        DR.Close()

    End Sub

    Private Sub mkOperador_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mkOperador.Leave, PisEntrada.Leave, CofinsEntrada.Leave, IcmsEntrada.Leave, FreteEntrada.Leave, IpiEntrada.Leave, mkIcmsVenda.Leave, mkIpiVenda.Leave, mkPisVenda.Leave, mkCofinsVenda.Leave, mkComissaoVenda.Leave, mkOutrosVenda.Leave, mkMargemLucroVenda.Leave
        If Me.TipoCalculo.Text = "MARKUP" Then

            AlterarOperadorMarkup()

            Dim VlrPIS As Double = (NzZero(Me.ValorCompra.Text) * NzZero(Me.PisEntrada.Text)) / 100
            Dim VlrCOFINS As Double = (NzZero(Me.ValorCompra.Text) * NzZero(Me.CofinsEntrada.Text)) / 100
            Dim VlrICMS As Double = (NzZero(Me.ValorCompra.Text) * NzZero(Me.IcmsEntrada.Text)) / 100
            Dim VlrFRETE As Double = (NzZero(Me.ValorCompra.Text) * NzZero(Me.FreteEntrada.Text)) / 100
            Dim VlrIPI As Double = (NzZero(Me.ValorCompra.Text) * NzZero(Me.IpiEntrada.Text)) / 100
            Me.mkCustoCompra.Text = NzZero(Me.ValorCompra.Text) - VlrPIS - VlrCOFINS - VlrICMS - VlrIPI + VlrFRETE
            Me.ValorVenda.Text = NzZero(Me.mkCustoCompra.Text) * NzZero(Me.mkOperador.Text)
        End If
    End Sub

   
    Private Sub TipoCalculo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoCalculo.Leave
        If Me.TipoCalculo.Text = "DIRETO" Then
            Me.FreteEntrada.Enabled = False : Me.IcmsEntrada.Enabled = False : Me.PisEntrada.Enabled = False
            Me.CofinsEntrada.Enabled = False : Me.IpiEntrada.Enabled = False : Me.mkPisVenda.Enabled = False
            Me.mkCofinsVenda.Enabled = False : Me.mkIcmsVenda.Enabled = False : Me.mkIpiVenda.Enabled = False
            Me.mkComissaoVenda.Enabled = False : Me.mkOutrosVenda.Enabled = False : Me.mkMargemLucroVenda.Enabled = True
            Me.mkOperador.Enabled = False

            Me.btAcharMakup.Visible = False
            Me.mkMargemLucroVenda.Focus()
        End If
        If Me.TipoCalculo.Text = "MARKUP" Then
            Me.FreteEntrada.Enabled = True : Me.IcmsEntrada.Enabled = True : Me.PisEntrada.Enabled = True
            Me.CofinsEntrada.Enabled = True : Me.IpiEntrada.Enabled = True : Me.mkPisVenda.Enabled = True
            Me.mkCofinsVenda.Enabled = True : Me.mkIcmsVenda.Enabled = True : Me.mkIpiVenda.Enabled = True
            Me.mkComissaoVenda.Enabled = True : Me.mkOutrosVenda.Enabled = True : Me.mkMargemLucroVenda.Enabled = True
            Me.mkOperador.Enabled = True

            Me.btAcharMakup.Visible = True
            Me.PisEntrada.Focus()
        End If
    End Sub

    Private Sub mkMargemLucroVenda_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mkMargemLucroVenda.Leave
        If Me.TipoCalculo.Text = "DIRETO" Then
            Me.mkCustoCompra.Text = FormatNumber(NzZero(Me.ValorCompra.Text), 2)
            Me.ValorVenda.Text = FormatNumber(((NzZero(Me.ValorCompra.Text) * NzZero(Me.mkMargemLucroVenda.Text)) / 100) + NzZero(Me.ValorCompra.Text), 2)
        End If
    End Sub

End Class