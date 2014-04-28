Public Class SalarioMinimoTabela


    Public SalMinTab As DataSet

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
            SendKeys.Send("{Tab}")
            Return True
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub FolhaPgtoPIS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Degrade()
        Me.Cnn.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)
        Cnn.Open()

        SalMinTab = New DataSet()
        Dim Sql As String = "SELECT * FROM SalarioMinimoTabela order by Periodo1"
        Me.Cmd.CommandText = Sql

        Me.Da.SelectCommand = Me.Cmd
        Da.Fill(SalMinTab, "SalMin")
        Me.DGSalMinimo.DataSource = SalMinTab
        Me.DGSalMinimo.DataMember = "SalMin"

    End Sub

    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub AtualizarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarBT.Click
        Try
            Da.Update(SalMinTab, "SalMin")
            MsgBox("Tabela de Salário Mínimo atualizada com sucesso.", 64, "Validação de Dados")
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try
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