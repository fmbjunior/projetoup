Public Class AuditoriaFiltro

    Dim PrimeiraParte As String
    Dim SegundaParte As String

    Private Sub Filtro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Filtro.TextChanged
        My.Forms.Auditor.Filtro.Text = PrimeiraParte & Me.Filtro.Text & "%'"
        My.Application.DoEvents()
    End Sub

    Private Sub AuditoriaFiltro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Forms.Auditor.Filtro.Text = "" Then
            PrimeiraParte = "" & My.Forms.Auditor.ColunaProcurar & " like '%"
        Else
            PrimeiraParte = My.Forms.Auditor.Filtro.Text
        End If
        If My.Forms.Auditor.Filtro.Text <> "" Then
            SegundaParte = PrimeiraParte & " And " & "" & My.Forms.Auditor.ColunaProcurar & " like '%"
            PrimeiraParte = SegundaParte
        End If

    End Sub

    Private Sub btOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOK.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class