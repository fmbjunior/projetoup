Public Class FolhaPgtoDefinirCompetencia

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Definir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Definir.Click
        If Me.MesAno.Text = "" Then
            MsgBox("O usuário deve informar o mês e o ano de competência de trabalho.", 65, "Validação de Dados")
            Exit Sub
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from FolhaPgtoTributos where Competencia = '" & Me.MesAno.Text & "'"
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If Not DR.HasRows = True Then
            If MsgBox("Tributos para o Mês e Ano de Competência não cadastrado, deseja cadastrar.", 36, "Validação de Dados") = 6 Then
                My.Forms.FolhaPgtoTributos.ShowDialog()
                Exit Sub
            Else
                Me.MesAno.Clear()
                Me.MesAno.Focus()
            End If
        Else
            MesAnoCompetencia = Me.MesAno.Text
            Me.Close()
            Me.Dispose()
        End If
        DR.Close()

    End Sub

    Private Sub FolhaPgtoDefinirCompetencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()
    End Sub

    Private Sub Degrade()
        Try
            Dim CCor() As String
            Dim corTemp As String

            corTemp = Cor1TelaPrimaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))

            corTemp = Cor2TelaPrimaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))
        Catch ex As Exception
        End Try
    End Sub
End Class