Imports System.Data
Imports System.Data.OleDb
Imports System.io
Imports UpExportaPAF

Public Class ExportPAF2

    Dim vNomeArquivo As String
    Dim vCgcEmpresa As String
    Dim vCodempresa As Byte
    Dim local As String = New Conectar().ConectarBD(LocalBD & Nome_BD)
    Dim ret As Boolean = False
    Sub Empresa()
        Dim conexao As OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim DR As OleDb.OleDbDataReader
        Dim scon As String = New Conectar().ConectarBD(LocalBD & Nome_BD)
        conexao = New OleDbConnection(scon)
        conexao.Open()


        With cmd
            .Connection = conexao
            .CommandTimeout = 0
            .CommandText = "SELECT CódigoEmpresa,Cgc From Empresa"
            .CommandType = CommandType.Text
        End With
        Try
            DR = cmd.ExecuteReader

            While DR.Read
                If Not IsDBNull(DR.Item(0)) Then
                    'Achou o iten procurado o iten as caixas serão preenchida
                    vCodempresa = DR.Item(0)
                    vCgcEmpresa = DR.Item(1)
                End If
            End While
            DR.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click



        Dim upExport As New UpExportaPAF.ExportarDados
        upExport.StrinCnn = local
        upExport.Pathfile = Me.txtPath.Text
        upExport.Codempresa = vCodempresa
        upExport.Exporta(ret)

        If ret = True Then
            MessageBox.Show("O arquivo foi exportado com sucesso.", "Exportação", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Houve um erro ao tentar fazer a exportação. Tente novamente." _
                & Microsoft.VisualBasic.ControlChars.CrLf & "Qualquer dúvida contate o suporte." _
                & Microsoft.VisualBasic.ControlChars.CrLf & "", "Erro na exportação", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End If

    End Sub


    Private Sub btnFindFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindFolder.Click
        Dim OpenFolder As New FolderBrowserDialog

        OpenFolder.ShowDialog()

        Me.txtPath.Text = OpenFolder.SelectedPath & ""
        Me.txtPath.Text = Me.txtPath.Text & "importa.txt"

      
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ExportPAF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Empresa()
    End Sub
End Class