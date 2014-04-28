Public Class RelLocaoCilindro
    Dim rel As New RelCilindro
    Dim cilA As New CilindroA
    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Visualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Visualizar.Click

        If A1.Checked = True Then


            cilA.lblempresa.Text = NomEmpresa
            ViewReport.VerRelat.Document = cilA.Document
            cilA.Run()

        ElseIf A2.Checked = True Then

            rel.isRel = True

            rel.lblempresa.Text = NomEmpresa
            ViewReport.VerRelat.Document = rel.Document
            rel.Run()

        End If
        ViewReport.ShowDialog()



    End Sub
End Class