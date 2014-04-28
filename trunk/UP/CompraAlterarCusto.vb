
Public Class CompraAlterarCusto
    Dim v_ValorAgregado As Double
    Dim v_PercentualAgregado As Double

    Dim CcyDebitoIcm As Double
    Dim CcyCreditoIcm As Double
    Dim CcyValorAgregado As Double
    Dim CcyDiferencaIcm As Double
    Dim CcyPrecoVenda As Double
    Dim CcyPrecoSugerido As Double
    Private Sub CompraAlterarCusto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ComprasAddItem.Visible = True Then
            Me.Agregado.Enabled = False
            AchaProduto(ComprasAddItem.CodigoProduto.Text)
            Calculo()
        ElseIf Produtos.Visible = True Then
            AchaProduto(Produtos.CodigoProduto.Text)
            Calculo()
        End If

    End Sub
    Public Sub AchaProduto(ByVal xID As Integer)
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT CodigoProduto, ValorCompra, Custo, ValorVenda, Ipi, pPIS, FreteEntrada, pCofins, MargemLucro, OutrosIncargos, CompraAnterior, Acrescimo, IcmsCreditado, IcmsDebitado, DiferencaIcms, Custo2, PercentualAgregado FROM Produtos Where codigoproduto=" & xID

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.codigoProduto.Text = xID
            If ComprasAddItem.Visible = True Then
                Me.compra.Text = FormatCurrency(NzZero(ComprasAddItem.ValorUnitario.Text), 4)
                Me.compraanterior.Text = FormatCurrency(NzZero(DR.Item("ValorCompra")), 4)
            Else
                Me.compraanterior.Text = FormatCurrency(NzZero(DR.Item("CompraAnterior")), 4)
                Me.compra.Text = FormatCurrency(NzZero(DR.Item("ValorCompra")), 4)
            End If

            Me.Acrescimo.Text = FormatNumber(NzZero(DR.Item("acrescimo")), 4)
            Me.Ipi.Text = FormatNumber(NzZero(DR.Item("ipi")), 4)
            Me.Cofins.Text = FormatNumber(NzZero(DR.Item("pCofins")), 4)
            Me.Pis.Text = FormatNumber(NzZero(DR.Item("pPIS")), 4)
            Me.Frete.Text = FormatNumber(NzZero(DR.Item("FreteEntrada")), 4)
            Me.Custo.Text = FormatCurrency(NzZero(DR.Item("Custo")), 4)
            Me.icmsCreditado.Text = FormatNumber(NzZero(DR.Item("IcmsCreditado")), 4)
            Me.icmsDebitado.Text = FormatNumber(NzZero(DR.Item("IcmsDebitado")), 4)
            Me.DiferencaIcms.Text = FormatNumber(NzZero(DR.Item("DiferencaIcms")), 4)
            Me.OutrosIncargos.Text = FormatNumber(NzZero(DR.Item("OutrosIncargos")), 4)
            Me.margem.Text = FormatNumber(NzZero(DR.Item("MargemLucro")), 4)
            Me.ValorVenda.Text = FormatNumber(NzZero(DR.Item("ValorVenda")), 4)
            Me.Custo2.Text = FormatCurrency(NzZero(DR.Item("Custo2")), 4)
            Me.Agregado.Text = FormatNumber(NzZero(DR.Item("PercentualAgregado")), 4)
        End If
        DR.Close()
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click

        If Me.ValorVenda.Text = 0 Then
            MsgBox("O valor de venda não foi informado, o sistema vai atualizar para o valor sugerido", 48, "Atenção")
            Me.ValorVenda.Text = FormatCurrency(ValorSugerido.Text, 4)
            Exit Sub
        End If

        'Calculo()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))


        CNN.Open()

        If Produtos.Visible = True Then



            Dim Sql1 As String = "UPDATE Produtos SET ValorCompra=@1, Custo=@2, ValorVenda=@3, FreteEntrada=@4, MargemLucro=@5, OutrosIncargos=@6, CompraAnterior=@7, Acrescimo=@8, IcmsCreditado=@9, IcmsDebitado=@10, DiferencaIcms=@11, Custo2=@12,PercentualAgregado=@13, Atualizado=@14 Where codigoproduto=" & codigoProduto.Text
            Dim cmd1 As New OleDb.OleDbCommand(Sql1, CNN)

            cmd1.Parameters.Add(New OleDb.OleDbParameter("@1", NzZero(Me.compra.Text)))
            cmd1.Parameters.Add(New OleDb.OleDbParameter("@2", NzZero(Me.Custo.Text)))
            cmd1.Parameters.Add(New OleDb.OleDbParameter("@3", NzZero(Me.ValorVenda.Text)))
            cmd1.Parameters.Add(New OleDb.OleDbParameter("@4", NzZero(Me.Frete.Text)))
            cmd1.Parameters.Add(New OleDb.OleDbParameter("@5", NzZero(Me.margem.Text)))
            cmd1.Parameters.Add(New OleDb.OleDbParameter("@6", NzZero(Me.OutrosIncargos.Text)))
            cmd1.Parameters.Add(New OleDb.OleDbParameter("@7", NzZero(Me.compraanterior.Text)))
            cmd1.Parameters.Add(New OleDb.OleDbParameter("@8", NzZero(Me.Acrescimo.Text)))
            cmd1.Parameters.Add(New OleDb.OleDbParameter("@9", NzZero(Me.icmsCreditado.Text)))
            cmd1.Parameters.Add(New OleDb.OleDbParameter("@10", NzZero(Me.icmsDebitado.Text)))
            cmd1.Parameters.Add(New OleDb.OleDbParameter("@11", NzZero(Me.DiferencaIcms.Text)))
            cmd1.Parameters.Add(New OleDb.OleDbParameter("@12", NzZero(Me.Custo2.Text)))
            cmd1.Parameters.Add(New OleDb.OleDbParameter("@13", NzZero(Me.Agregado.Text)))
            cmd1.Parameters.Add(New OleDb.OleDbParameter("@14", True))

            Try
                cmd1.ExecuteNonQuery()
                CNN.Close()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Editou, Me.codigoProduto.Text)
                Me.Close()
                Me.Dispose()
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try

            Exit Sub
        End If

        Dim Sql As String = "Update ItensCompra set cCompraAnterior=?,cAcrescimo=?,cFrete=?,cCusto=?,cIcmsCreditado=?,cIcmsDebitado=?,cDiferencaIcms=?,cOutros=?,cMargem=?,cCusto2=?,cValorVenda=?,AlterarCusto=?  Where Id = " & ComprasAddItem.vIDlinha
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("?", CDbl(Me.compraanterior.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("?", CDbl(Me.Acrescimo.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("?", CDbl(Me.Frete.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("?", CDbl(Me.Custo.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("?", NzZero(Me.icmsCreditado.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("?", NzZero(Me.icmsDebitado.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("?", NzZero(Me.DiferencaIcms.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("?", NzZero(Me.OutrosIncargos.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("?", NzZero(Me.margem.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("?", NzZero(Me.Custo2.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("?", NzZero(Me.ValorVenda.Text)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("?", True))
        Try
            cmd.ExecuteNonQuery()
            CNN.Close()
            MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
            Me.Close()
            Me.Dispose()
        Catch x As Exception
            MsgBox(x.Message)
            Exit Sub
        End Try

    End Sub
    Public Sub Calculo()
        CcyValorAgregado = 0
        CcyDiferencaIcm = 0
        CcyPrecoVenda = 0
        Try
            Me.Custo.Text = FormatCurrency(Me.compra.Text, 4)
            Me.Custo.Text = FormatCurrency((Me.Frete.Text) * (Me.Custo.Text) / 100 + (Me.Custo.Text), 4)
            'Me.Custo.Text = FormatCurrency((Me.Acrescimo.Text * Me.Custo.Text) / 100 + (Me.Custo.Text), 4)
            Me.Custo.Text = FormatCurrency((Me.Ipi.Text) * (Me.Custo.Text) / 100 + (Me.Custo.Text), 4)
            Me.Custo.Text = FormatCurrency((Me.Pis.Text) * (Me.Custo.Text) / 100 + (Me.Custo.Text), 4)
            Me.Custo.Text = FormatCurrency((Me.Cofins.Text) * (Me.Custo.Text) / 100 + (Me.Custo.Text), 4)
            CcyValorAgregado = CDbl((Me.Custo.Text) * NzZero(Me.Agregado.Text) / 100 + CDbl(Me.Custo.Text))
            CcyDebitoIcm = (Me.icmsDebitado.Text * CcyValorAgregado) / 100
            CcyCreditoIcm = (Me.icmsCreditado.Text * Me.Custo.Text) / 100
            CcyDiferencaIcm = (CcyDebitoIcm - CcyCreditoIcm)
            If Me.icmsCreditado.Text = 0 Then
                Me.DiferencaIcms.Text = Me.icmsDebitado.Text
            Else
                Me.DiferencaIcms.Text = (CcyDiferencaIcm / Me.Custo.Text) * 100
            End If
            CcyPrecoVenda = (Me.Custo.Text * Me.DiferencaIcms.Text) / 100 + (Me.Custo.Text)
            CcyPrecoVenda = (Me.OutrosIncargos.Text * CcyPrecoVenda) / 100 + (CcyPrecoVenda)
            Me.Custo2.Text = FormatCurrency(Custo.Text + CcyDiferencaIcm, 4)
            'CcyPrecoSugerido = (Me.margem.Text * CcyPrecoVenda) / 100 + (CcyPrecoVenda)
            Me.ValorSugerido.Text = (Me.margem.Text * CcyPrecoVenda) / 100 + (CcyPrecoVenda)
            'Me.ValorSugerido.Text = FormatCurrency(ValorSugerido, 4)
            Me.ValorVenda.Text = FormatCurrency(CDbl(ValorSugerido.Text) * CDbl(Me.Acrescimo.Text) / 100 + CDbl(Me.ValorSugerido.Text), 4)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       

    End Sub
    Private Sub compra_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles compra.Validated, Acrescimo.Validated, Ipi.Validated, Cofins.Validated, Pis.Validated, Frete.Validated, icmsDebitado.Validated, icmsCreditado.Validated, DiferencaIcms.Validated, OutrosIncargos.Validated, margem.Validated, Agregado.Validated
        If compra.Text = "" Then
            Me.compra.Text = 0
        ElseIf Acrescimo.Text = "" Then
            Me.Acrescimo.Text = 0
        ElseIf Ipi.Text = "" Then
            Me.Ipi.Text = 0
        ElseIf Frete.Text = "" Then
            Me.Frete.Text = 0
        ElseIf Pis.Text = "" Then
            Me.Pis.Text = 0
        ElseIf Cofins.Text = "" Then
            Me.Cofins.Text = 0
        ElseIf icmsDebitado.Text = "" Then
            Me.icmsDebitado.Text = 0
        ElseIf icmsCreditado.Text = "" Then
            Me.icmsCreditado.Text = 0
        ElseIf DiferencaIcms.Text = "" Then
            Me.DiferencaIcms.Text = 0
        ElseIf OutrosIncargos.Text = "" Then
            Me.OutrosIncargos.Text = 0
        ElseIf margem.Text = "" Then
            Me.margem.Text = 0
        ElseIf ValorSugerido.Text = "" Then
            Me.ValorSugerido.Text = 0
        ElseIf ValorVenda.Text = "" Then
            Me.ValorVenda.Text = 0
        End If
        Calculo()
    End Sub

    
End Class