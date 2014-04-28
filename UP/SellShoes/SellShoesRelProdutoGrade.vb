Public Class SellShoesRelProdutoGrade

    Dim Crypto As New ClCrypto 'Para descriptografar a senha do banco de dados


    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVisualizar.Click
        MontaRelatorio("RelProdutosGrade")
    End Sub



    Dim TelaCr As System.Windows.Forms.Form

    Private Sub MontaRelatorio(ByVal RelatorioId As String)
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


        'Carrega o relatorio
        Dim VerRelat As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        Select Case RelatorioId
            Case "RelProdutosGrade"
                VerRelat.Load(DirRelat & "RelProdutosGrade.rpt")
                VerRelat.DataSourceConnections.Item(0).SetConnection("", LocalBD & Nome_BD, False)
                VerRelat.DataSourceConnections.Item(0).SetLogon("", Crypto.clsCrypto(SenhaBancoDados, False))
                'VerRelat.RecordSelectionFormula = "{NFe.chaveacesso} = '" & Me.ChaveAcesso.Text & "'" 

            Case ""
            Case ""

        End Select
        Vz.ReportSource = VerRelat

        Tel.Controls.Add(Vz)

        Tel.ShowDialog()
    End Sub

   
End Class