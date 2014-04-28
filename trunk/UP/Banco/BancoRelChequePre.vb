Public Class BancoRelChequePre

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Dim TelaCr As System.Windows.Forms.Form
    Private Sub Visualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Visualizar.Click
        If Me.DataInicial.Text = "" Then
            MsgBox("O usuário deve informar a data inicial para o relatório.", 64, "Validação de Dados")
            Me.DataInicial.Focus()
            Exit Sub
        ElseIf Me.DataFinal.Text = "" Then
            MsgBox("O usuário deve informar a data Final para o relatório.", 64, "Validação de Dados")
            Me.DataFinal.Focus()
            Exit Sub
        End If

        Dim Tel As New Form() ' Create a new instance of the form.

        TelaCr = Tel
        Dim Vz As New CrystalDecisions.Windows.Forms.CrystalReportViewer

        Dim F As New Font("Comic Sans MS", 8, System.Drawing.GraphicsUnit.Point)

        Tel.Text = "Visualizador de Relatório"
        Tel.Size = New Size(576, 352)
        Tel.HelpButton = False
        Tel.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        Tel.MaximizeBox = True
        Tel.MinimizeBox = True
        Tel.ControlBox = True
        Tel.Font = F
        Tel.StartPosition = FormStartPosition.CenterScreen
        Tel.ShowInTaskbar = False
        Tel.WindowState = FormWindowState.Maximized

        Vz.Dock = DockStyle.Fill


        Dim Crypto As New ClCrypto 'Para descriptografar a senha do banco de dados
        'Carrega o relatorio
        Dim VerRelat As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        VerRelat.Load(DirRelat & "RelBancoChequePre.rpt")
        VerRelat.DataSourceConnections.Item(0).SetConnection("", LocalBD & Nome_BD, False)
        VerRelat.DataSourceConnections.Item(0).SetLogon("", Crypto.clsCrypto(SenhaBancoDados, False))

        VerRelat.DataDefinition.FormulaFields.Item("Titulo").Text = "'" & "Cheques-Pré no Período: " & Me.DataInicial.Text & " a " & Me.DataFinal.Text & "'"
        VerRelat.RecordSelectionFormula = CrDateBetween("{LancamentoBanco.DataPreDatado}", Me.DataInicial.Text, Me.DataFinal.Text) & " and {LancamentoBanco.Inativo} = False And {LancamentoBanco.Empresa} = " & CodEmpresa & " and {LancamentoBanco.ContaCorrente} = '" & My.Forms.BancoVisualizador.Codigo.Text & "' and {LancamentoBanco.CaiuBanco} = 'N'"


        Vz.ReportSource = VerRelat

        Tel.Controls.Add(Vz)

        Tel.ShowDialog()


    End Sub


End Class