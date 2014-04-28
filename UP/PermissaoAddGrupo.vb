Public Class PermissaoAddGrupo

    Public Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub CadTelaPermissaoAddEdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Tela.Text = My.Forms.Permissoes.TelaSelect
        Me.DescricaoTela.Text = My.Forms.Permissoes.TelaDescri
        EncheListaUsuario()

        Me.Exclui.Checked = False
        Me.Adiciona.Checked = False
        Me.Altera.Checked = False
        Me.Consultar.Checked = False
        Me.Inativo.Checked = False

    End Sub


       Public Sub EncheListaUsuario()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT LoginUser.Login FROM(LoginUser) WHERE(((LoginUser.Inativo) = False)) ORDER BY LoginUser.Login;"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Login.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        Cnn.Close()

    End Sub


    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        'Area destinada para as validacoes
        If Me.Tela.Text = "" Then
            MsgBox("O Nome da tela não foi carregado, feche e inicie Novamento.", 64, "Validação de Dados")
            Exit Sub
        ElseIf Me.DescricaoTela.Text = "" Then
            MsgBox("A  descrição da Tela não foi carregada feche e inicie novamente.", 64, "Validação de Dados")
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim ds As New DataSet()

        Dim Sql As String = String.Empty
       
        Dim vTela As String = Me.Tela.Text
        Dim vDescTela As String = Me.DescricaoTela.Text

        Sql = "SELECT LoginUserPermissao.* FROM LoginUserPermissao WHERE LoginUserPermissao.Tela = '" & vTela & "'"
        Dim DATela As New OleDb.OleDbDataAdapter(Sql, CNN)
        DATela.Fill(ds, "Telas")



        For Each LinhaGrid As DataGridViewRow In Me.Login.Rows

            If LinhaGrid.Cells("Selecao").Value = True Then
                Dim Linha() As DataRow
                Linha = ds.Tables("Telas").Select("Login = '" & LinhaGrid.Cells("User").Value & "'")

                Dim TBL As DataTable
                TBL = ds.Tables("Telas")

                If Linha.Length = 0 Then
                    Dim DRnovo As DataRow
                    DRnovo = TBL.NewRow()
                    DRnovo("Login") = LinhaGrid.Cells("User").Value
                    DRnovo("Tela") = vTela
                    DRnovo("DescricaoTela") = vDescTela
                    DRnovo("Exclui") = Me.Exclui.Checked
                    DRnovo("Adiciona") = Me.Adiciona.Checked
                    DRnovo("Altera") = Me.Altera.Checked
                    DRnovo("Consultar") = Me.Consultar.Checked
                    DRnovo("Inativo") = Me.Inativo.Checked
                    TBL.Rows.Add(DRnovo)
                Else
                    Linha(0).BeginEdit()

                    Linha(0)("Login") = LinhaGrid.Cells("User").Value
                    Linha(0)("Tela") = vTela
                    Linha(0)("DescricaoTela") = vDescTela
                    Linha(0)("Exclui") = Me.Exclui.Checked
                    Linha(0)("Adiciona") = Me.Adiciona.Checked
                    Linha(0)("Altera") = Me.Altera.Checked
                    Linha(0)("Consultar") = Me.Consultar.Checked
                    Linha(0)("Inativo") = Me.Inativo.Checked

                    Linha(0).EndEdit()

                End If


            End If

        Next

        Try
            Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DATela)
            DATela.Update(ds, "Telas")
            MessageBox.Show("Permissões incluidas com sucesso.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GerarLog(Me.Text, AçãoTP.Adicionou, Me.Tela.Text)
            CNN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            CNN.Close()
            Exit Sub
        End Try

    End Sub

    
End Class