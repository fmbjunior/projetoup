Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Export
Imports DataDynamics.ActiveReports.Export.Html
Imports DataDynamics.ActiveReports.Export.Xls

Public Class ViewReport


    Private Sub btExportPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExportPDF.Click
        Dim ArquivoPDF As String = String.Empty

        Dim SaveFilePDF As New SaveFileDialog()
        SaveFilePDF.Title = "Exportação de Relatório"
        SaveFilePDF.InitialDirectory = "C:\Temp\"
        SaveFilePDF.AddExtension = True
        SaveFilePDF.DefaultExt = "pdf"
        SaveFilePDF.Filter = "Arquivos PDF (*.pdf)|*.pdf"

        If SaveFilePDF.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ArquivoPDF = SaveFilePDF.FileName
        Else
            MessageBox.Show("Operação cancelada pelo usuário.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If SaveFilePDF.FileName = "" Then
            MessageBox.Show("Não foi informado o nome do arquivo para salvar.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Dim Export As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
            Export.Export(Me.VerRelat.Document, ArquivoPDF)
            MessageBox.Show("Exportação realizada com sucesso.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Erro ao exportar o arquivo PDF, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub

    Private Sub btEnviarEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnviarEmail.Click
        'My.Forms.EmailEnviar.ShowDialog()
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btExportHTML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExportHTML.Click
        Dim ArquivoHTML As String = String.Empty

        Dim SaveFileHTM As New SaveFileDialog()
        SaveFileHTM.Title = "Exportação de Relatório"
        SaveFileHTM.InitialDirectory = "C:\Temp\"
        SaveFileHTM.AddExtension = True
        SaveFileHTM.DefaultExt = "html"
        SaveFileHTM.Filter = "Arquivos htm (*.htm)|*.html"

        If SaveFileHTM.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ArquivoHTML = SaveFileHTM.FileName
        Else
            MessageBox.Show("Operação cancelada pelo usuário.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If SaveFileHTM.FileName = "" Then
            MessageBox.Show("Não foi informado o nome do arquivo para salvar.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            'Dim Export As New DataDynamics.ActiveReports.Export.Html.HtmlOutputInfoArgs 'DataDynamics.ActiveReports.Export.Html.HtmlExport
            'Export.Export(Me.VerRelat.Document, ArquivoHTML)
            'MessageBox.Show("Exportação realizada com sucesso.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Erro ao exportar o arquivo Html, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim ArquivoExel As String = String.Empty

        Dim SaveFileExel As New SaveFileDialog()

        SaveFileExel.Title = "Exportação de Relatório"
        SaveFileExel.InitialDirectory = "C:\Temp\"
        SaveFileExel.AddExtension = True
        SaveFileExel.DefaultExt = "xls"
        SaveFileExel.Filter = "Arquivos xls (*.xls)|*.xls"

        If SaveFileExel.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ArquivoExel = SaveFileExel.FileName
        Else
            MessageBox.Show("Operação cancelada pelo usuário.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If SaveFileExel.FileName = "" Then
            MessageBox.Show("Não foi informado o nome do arquivo para salvar.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Dim Export As New DataDynamics.ActiveReports.Export.Xls.XlsExport
            Export.Export(Me.VerRelat.Document, ArquivoExel)
            MessageBox.Show("Exportação realizada com sucesso.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Erro ao exportar o arquivo Html, Verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

End Class