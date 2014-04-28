Imports System.IO

Public Class AlternarEmpresa

    Dim DtCaixaAberto As Date

    
    Private Sub Codigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Codigo.KeyDown
        If e.KeyCode = Keys.F5 Then
            ChamaTelaProcura("Codigo", "Razão Social", "", "Empresa", "CódigoEmpresa", "RazãoSocial", "", False)
            Me.Codigo.Text = RetornoProcura
            If Me.Codigo.Text <> "" Then
                LocalizaDados()
            End If

        End If
    End Sub

    Public Sub LocalizaDados()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Empresa where CódigoEmpresa = " & Me.Codigo.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.Empresa.Text = DR.Item("RazãoSocial") & ""
        End If

        DR.Close()


        'Verifica a data de Entrada
        Sql = "SELECT * From CaixaCriados Where Empresa = " & Me.Codigo.Text & " and Fechado = false"
        CMD = New OleDb.OleDbCommand(Sql, CNN)

        DR = CMD.ExecuteReader

        DR.Read()
        If DR.HasRows = True Then
            DtCaixaAberto = DR.Item("DataCaixaDia")
        Else
            MsgBox("Não existe caixa aberto para esta empresa.", 64, "Validação de Dados")
            Exit Sub
        End If
        DR.Close()
        CNN.Close()


    End Sub

    Private Sub Codigo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Codigo.Leave
        If Not Me.Codigo.Text = "" Then
            LocalizaDados()
        End If
    End Sub

    Private Sub Alternar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alternar.Click
        DataDia = DtCaixaAberto
        CodEmpresa = Me.Codigo.Text
        RetornoProcura = ""
        My.Forms.MenuGeral.Text = "Menu Geral - " & CodEmpresa & "-" & "Validação de Dados" & " - Data de Trabalho: " & DataDia

        MsgBox("Empresa Padrão do sistema alternada para trabalho." & Chr(13) & "A data de trabalho foi alterada para : " & DtCaixaAberto, 64, "Validação de Dados")
        Me.Close()
        Me.Dispose()
    End Sub



    

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class