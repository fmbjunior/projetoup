Public Class Auditor

    Dim Ds As New DataSet
    Dim Log As New DataTable("tbLOG")
    Dim bs As BindingSource

    Public ColunaProcurar As String

    Private Sub BTNomeBd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNomeBd.Click

        Dim LocalEXE As String = My.Application.Info.DirectoryPath & "\Log"

        Dim OpenFileDialog1 As New OpenFileDialog()
        OpenFileDialog1.Filter = "(Banco de Dados) *.Txt | *.txt"
        OpenFileDialog1.Title = "Selecione um arquivo TXT para inserir no campo Nome do banco de Dados"
        OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.FileName <> "" Then
            Me.ArqVer.Text = OpenFileDialog1.FileName
            Me.ArqVer.Focus()
        End If
    End Sub

    Private Sub ArqVer_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArqVer.Validated
        Dim sr As System.IO.StreamReader = Nothing

        Dim linhaAtual As String

        If (System.IO.File.Exists(Me.ArqVer.Text) <> True) Then
            Throw (New System.IO.FileNotFoundException("Não foi Possível Localizar o Arquivo Especificado"))
        End If

        Try
            sr = New System.IO.StreamReader(Me.ArqVer.Text)

            While (Not sr.EndOfStream)

                linhaAtual = sr.ReadLine()
                ' Processar a Linha AQUI!!!


                Dim NovaLinha As DataRow = Log.NewRow()
                NovaLinha("User") = Trim(Mid(linhaAtual, 1, 15))
                NovaLinha("Tela") = Trim(Mid(linhaAtual, 16, 50))
                NovaLinha("Ação") = Trim(Mid(linhaAtual, 65, 15))
                NovaLinha("ID") = Trim(Mid(linhaAtual, 80, 20))
                NovaLinha("Data_Hora") = Trim(Mid(linhaAtual, 100, 20))
                NovaLinha("DescAuxiliar") = Trim(Mid(linhaAtual, 120, 300))
                Log.Rows.Add(NovaLinha)

            End While


            bs = New BindingSource
            bs.DataSource = Ds.Tables("tbLOG").DefaultView
            Me.Lista.DataSource = bs

        Finally
            If (Not sr Is Nothing) Then
                sr.Dispose()
            End If
        End Try
    End Sub

    Private Sub Auditor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Log.Dispose()
        Ds.Dispose()
        Me.Dispose()
    End Sub

    Private Sub Auditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Log.Columns.Add("User")
        Log.Columns.Add("Tela")
        Log.Columns.Add("Ação")
        Log.Columns.Add("ID")
        Log.Columns.Add("Data_Hora")
        Log.Columns.Add("DescAuxiliar")
        Ds.Tables.Add(Log)
    End Sub


    Private Sub Lista_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Lista.CellMouseDoubleClick

        Select Case e.ColumnIndex
            Case 0
                ColunaProcurar = "User"
                My.Forms.AuditoriaFiltro.ShowDialog()
            Case 1
                ColunaProcurar = "Tela"
                My.Forms.AuditoriaFiltro.ShowDialog()
            Case 2
                ColunaProcurar = "Ação"
                My.Forms.AuditoriaFiltro.ShowDialog()
            Case 3
                ColunaProcurar = "ID"
                My.Forms.AuditoriaFiltro.ShowDialog()
            Case 4
                ColunaProcurar = "Data_Hora"
                My.Forms.AuditoriaFiltro.ShowDialog()
            Case 4
                ColunaProcurar = "DescAuxiliar"
                My.Forms.AuditoriaFiltro.ShowDialog()
        End Select


    End Sub



    Private Sub FiltrarDados()
        Try
            bs.Filter = Filtro.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Filtro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Filtro.TextChanged
        FiltrarDados()
        My.Application.DoEvents()
    End Sub

    Private Sub btRemoveFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRemoveFiltro.Click
        Me.Filtro.Text = ""
        FiltrarDados()
        My.Application.DoEvents()
    End Sub
End Class