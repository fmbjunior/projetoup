Public Class PagarRelat
    Dim A��o As New TrfGerais

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged, A4.CheckedChanged, A5.CheckedChanged, A11.CheckedChanged, A12.CheckedChanged, A13.CheckedChanged, A14.CheckedChanged, A6.CheckedChanged

        'Fazer compara�oes para verificar qual RadioButton foi clicado.
        Select Case DirectCast(sender, RadioButton).Name
            'Pagar no per�do.
            Case "A1"
                Me.PainelCheque.Visible = False
                Me.PainelPeriodo.Visible = True
                Me.PainelForncedor.Visible = False
                Me.PainelLocal.Visible = False
                Me.DataInicial.Focus()

                'Pagar por fornecedor
            Case "A2"
                Me.PainelCheque.Visible = False
                Me.PainelPeriodo.Visible = True
                Me.PainelForncedor.Visible = True
                Me.Label3.Visible = True
                Me.PainelLocal.Visible = False
                Me.DataInicial.Focus()

                'Pagar vencidas por fornecedor
            Case "A3"
                Me.PainelCheque.Visible = False
                Me.PainelPeriodo.Visible = False
                Me.PainelForncedor.Visible = True
                Me.Label3.Visible = False
                Me.PainelLocal.Visible = False
                Me.DataInicial.Focus()

                'Pagar Vencidas geral.
            Case "A4"
                Me.PainelCheque.Visible = False
                Me.PainelPeriodo.Visible = False
                Me.PainelLocal.Visible = False
                Me.PainelForncedor.Visible = False

                'A pagar por local de pagamento
            Case "A5"
                Me.PainelCheque.Visible = False
                Me.PainelPeriodo.Visible = True
                Me.PainelLocal.Visible = True
                Me.PainelForncedor.Visible = False
                Me.DataInicial.Focus()

                'Pagar no per�do por vencimento.
            Case "A6"
                Me.PainelCheque.Visible = False
                Me.PainelPeriodo.Visible = True
                Me.PainelForncedor.Visible = False
                Me.PainelLocal.Visible = False
                Me.DataInicial.Focus()

                'Contas pagas no per�odo
            Case "A11"
                Me.PainelCheque.Visible = False
                Me.PainelPeriodo.Visible = True
                Me.PainelForncedor.Visible = False
                Me.PainelLocal.Visible = False
                Me.DataInicial.Focus()

                'Contas a pagar por fornecedor.
            Case "A12"
                Me.PainelCheque.Visible = False
                Me.PainelPeriodo.Visible = True
                Me.PainelForncedor.Visible = True
                Me.Label3.Visible = True
                Me.PainelLocal.Visible = False
                Me.DataInicial.Focus()

                'Contas pagas por cheque
            Case "A13"
                Me.PainelCheque.Visible = True
                Me.PainelPeriodo.Visible = False
                Me.PainelForncedor.Visible = False
                Me.PainelLocal.Visible = False
                Me.DataInicial.Focus()

                'Hist�rico de fornecedor
            Case "A14"
                Me.PainelCheque.Visible = False
                Me.PainelPeriodo.Visible = False
                Me.PainelForncedor.Visible = True
                Me.Label3.Visible = False
                Me.PainelLocal.Visible = False
                Me.Fornecedor.Focus()

        End Select

    End Sub

    Private Sub btVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVisualizar.Click
        Dim f As New VisualizadorRelatorio
        If Me.A1.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usu�rio deve informar a data inicial para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usu�rio deve informar a data Final para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelPagarPeriodo"
            f.ShowDialog()
        End If

        If Me.A2.Checked = True Then
            If Me.Fornecedor.Text = "" Then
                MsgBox("O usu�rio deve informar o Fornecedor para o relat�rio.", 64, "Valida��o de Dados")
                Me.Fornecedor.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelPagarFornecedor"
            f.ShowDialog()
        End If


        If Me.A3.Checked = True Then
            If Me.Fornecedor.Text = "" Then
                MsgBox("O usu�rio deve informar o Fornecedor para o relat�rio.", 64, "Valida��o de Dados")
                Me.Fornecedor.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelPagarVencidasFornecedor"
            f.ShowDialog()
        End If

        If Me.A4.Checked = True Then
            RelatorioCarregar = "RelPagarVencidasGeral"
            f.ShowDialog()
        End If


        If Me.A5.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usu�rio deve informar a data inicial para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usu�rio deve informar a data Final para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            ElseIf Me.Local.Text = "" Then
                MsgBox("O usu�rio deve informar o local de pagamento para gerar o relat�rio.", 64, "Valida��o de Dados")
                Me.Local.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelPagarPeriodoLocal"
            f.ShowDialog()
        End If

        If Me.A6.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usu�rio deve informar a data inicial para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usu�rio deve informar a data Final para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelPagarAgrupadoPorData"
            f.ShowDialog()
        End If




        If Me.A11.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usu�rio deve informar a data inicial para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usu�rio deve informar a data Final para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelPagasPeriodo"
            f.ShowDialog()
        End If

        If Me.A12.Checked = True Then
            If Me.DataInicial.Text = "" Then
                MsgBox("O usu�rio deve informar a data inicial para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("O usu�rio deve informar a data Final para o relat�rio.", 64, "Valida��o de Dados")
                Me.DataFinal.Focus()
                Exit Sub
            End If
            If Me.Fornecedor.Text = "" Then
                MsgBox("O usu�rio deve informar o Fornecedor para o relat�rio.", 64, "Valida��o de Dados")
                Me.Fornecedor.Focus()
                Exit Sub
            End If

            RelatorioCarregar = "RelPagasFornecedor"
            f.ShowDialog()
        End If

        If Me.A13.Checked = True Then
            If Me.Cheque.Text = "" Then
                MsgBox("O usu�rio deve informar o numero do cheque antes de iniciar o relat�rio.", 64, "Valida��o de Dados")
                Me.Cheque.Focus()
                Exit Sub
            End If
            RelatorioCarregar = "RelPagasCheque"
            f.ShowDialog()
        End If

        If Me.A14.Checked = True Then
            If Me.Fornecedor.Text = "" Then
                MsgBox("O usu�rio deve informar o Fornecedor para o relat�rio.", 64, "Valida��o de Dados")
                Me.Fornecedor.Focus()
                Exit Sub
            End If
            f.vFornecedor = Fornecedor.Text
            RelatorioCarregar = "RelHistoricoFornecedor"
            f.ShowDialog()

        End If


    End Sub

    Private Sub Fornecedor_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fornecedor.Enter
        Me.Bal�oAjuda.Show("Pressione F5 para Localizar o Fornecedor.", Me.Fornecedor, 2000)
    End Sub

    Private Sub Fornecedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Fornecedor.KeyDown
        If e.KeyCode = Keys.F5 Then
            ChamaTelaProcura("Codigo", "Raz�o Social", "", "Fornecedor", "C�digoFornecedor", "Raz�oSocial", "", True)
            Me.Fornecedor.Text = RetornoProcura
            If Me.Fornecedor.Text <> "" Then
                A��o.Descri��o_ItenRegistro(Me.Fornecedor, Me.FornecedorDesc, "Fornecedor", "C�digoFornecedor", Me.Fornecedor.Text, "Raz�oSocial", TrfGerais.TipoDados.Num�rico, True)
            End If
        End If
    End Sub

    Private Sub Fornecedor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fornecedor.Leave
        A��o.Descri��o_ItenRegistro(Me.Fornecedor, Me.FornecedorDesc, "Fornecedor", "C�digoFornecedor", Me.Fornecedor.Text, "Raz�oSocial", TrfGerais.TipoDados.Num�rico, True)
    End Sub

    
 
    Private Sub Fundo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fundo.Click

    End Sub
End Class