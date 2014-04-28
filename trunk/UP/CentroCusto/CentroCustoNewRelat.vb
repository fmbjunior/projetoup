Imports System.Data.OleDb
Public Class CentroCustoNewRelat

    Private Sub btFechar_Click(sender As Object, e As EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub A1_CheckedChanged(sender As Object, e As EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged
        If Me.A1.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelContaReceitaDespesa.Visible = False
            Me.DataInicial.Focus()
        End If
        If Me.A2.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelContaReceitaDespesa.Visible = True
            Me.DataInicial.Focus()
        End If

    End Sub

    Private Sub btVisualizar_Click(sender As Object, e As EventArgs) Handles btVisualizar.Click
        'Dim Relat As New Reports

        'If Me.A1.Checked = True Then
        '    If Me.DataInicial.Text = "" Then
        '        MsgBox("O usuário deve informar a data inicial para o relatório.", 64, "Validação de Dados")
        '        Me.DataInicial.Focus()
        '        Exit Sub
        '    ElseIf Me.DataFinal.Text = "" Then
        '        MsgBox("O usuário deve informar a data Final para o relatório.", 64, "Validação de Dados")
        '        Me.DataFinal.Focus()
        '        Exit Sub
        '    End If

        '    Relat.RelCentroCustoPeriodo()
        'End If

        'If Me.A2.Checked = True Then
        '    If Me.DataInicial.Text = "" Then
        '        MsgBox("O usuário deve informar a data inicial para o relatório.", 64, "Validação de Dados")
        '        Me.DataInicial.Focus()
        '        Exit Sub
        '    ElseIf Me.DataFinal.Text = "" Then
        '        MsgBox("O usuário deve informar a data Final para o relatório.", 64, "Validação de Dados")
        '        Me.DataFinal.Focus()
        '        Exit Sub
        '    ElseIf Me.ContaCC.Text = "" Then
        '        MsgBox("O usuário deve informar a Conta para o relatório.", 64, "Validação de Dados")
        '        Me.ContaCC.Focus()
        '        Exit Sub
        '    End If

        '    Relat.RelCentroCustoPeriodoConta()
        'End If


    End Sub

    Private Sub btFindCC_Click(sender As Object, e As EventArgs) Handles btFindCC.Click
        My.Forms.CentroCustoNewLocalizar.ShowDialog()
        AchaContaCentroCusto(Me.ContaCC.Text, Me.ContaCCDesc)
        Me.ContaCC.Focus()
    End Sub


    Private Sub ContaCC_Validated(sender As Object, e As EventArgs) Handles ContaCC.Validated
        AchaContaCentroCusto(Me.ContaCC.Text, Me.ContaCCDesc)
    End Sub

    Private Sub ContaCC_KeyDown(sender As Object, e As KeyEventArgs) Handles ContaCC.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.CentroCustoNewLocalizar.ShowDialog()
            AchaContaCentroCusto(Me.ContaCC.Text, Me.ContaCCDesc)
        End If
    End Sub

    Public Sub AchaContaCentroCusto(ByVal ContaCC As String, ByVal CampoParaRetornar As Control)

        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "Select * from Cc3 where ContaGrupo3 = '" & ContaCC & "' And Empresa = " & CodEmpresa
        Dim CMD As New OleDbCommand(Sql, Cnn)
        Dim DR As OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            CampoParaRetornar.Text = DR.Item("DescContaGrupo3") & ""
        End If
        Cnn.Close()

    End Sub

   
End Class