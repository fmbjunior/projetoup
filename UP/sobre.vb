Imports Microsoft.Win32
Public Class Sobre

    Private Sub Sobre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.BackColor = Color.FromArgb(0, Me.BackColor)

        Me.Local.Text = LocalBD
        Me.BDPrincipal.Text = "Banco de Dados Principal : (" & Nome_BD & ")"
        Me.User.Text = "Usu�rio Ativo na Maquina : (" & UserAtivo & ")"
        'Acha a Vers�o Atual
        Dim ArquivoExiste As String = Dir(Application.StartupPath & "\Ver.Txt", FileAttribute.Archive)
        Dim VerAtual As String = ""

        If ArquivoExiste <> "" Then
            FileOpen(1, Application.StartupPath & "\Ver.Txt", OpenMode.Input)
            Do While Not EOF(1)
                Input(1, VerAtual)
            Loop
            FileClose(1)
        Else
            Exit Sub
        End If
        Me.Vers�o.Text = "Vers�o do Sistema : " & VerAtual
        'fim de achar a vers�o

    End Sub
End Class