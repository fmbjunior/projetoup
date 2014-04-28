Public Class RegiaoCidade

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2



#Region "Rotina de Grid"

    Private Sub EncheUF()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = String.Empty

        Sql = "Select * From UF  order by NomeUF Desc"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.cUF.DataSource = ds.Tables("Table").DefaultView
        Me.cUF.ValueMember = "CodigoUF"
        Me.cUF.DisplayMember = "NomeUF"

        Me.cUF.SelectedIndex = -1

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub EncheCidade()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = String.Empty

        Sql = "Select CodMunicipio, NomeMunic From Municipio Where Municipio.UF = '" & Me.cUF.SelectedValue & "' order by NomeMunic"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.cMun.DataSource = ds.Tables("Table").DefaultView
        Me.cMun.ValueMember = "CodMunicipio"
        Me.cMun.DisplayMember = "NomeMunic"

        Me.cMun.SelectedIndex = -1

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub EncheGrid()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = String.Empty


        Sql = "Select RegiaoCidade.CodCidade, RegiaoCidade.CidadeDesc From RegiaoCidade Where RegiaoCidade.IdRegiao = " & My.Forms.Regiao.IdRegiao.Text

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Lista.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub Lista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellDoubleClick

        If MsgBox("Deseja realmente excluir a Cidade.", 36, "Validação de Dados") = 6 Then
            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()


            Dim Sql As String = "Delete * From RegiaoCidade  Where CodCidade = '" & Me.Lista.CurrentRow.Cells(0).Value & "'"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.ExecuteNonQuery()
            CNN.Close()
            EncheGrid()
            MsgBox("Registro Excluido com sucesso", 64, "Validação de Dados")
        End If

    End Sub



#End Region


    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        'Area destinada para as validacoes
        If Me.cMun.Text = "" Then
            MsgBox("A Cidade não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.cMun.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim Sql As String = "INSERT INTO RegiaoCidade (CodCidade, CidadeDesc, IdRegiao) VALUES (@1, @2, @3)"
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.cMun.SelectedValue, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.cMun.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@3", NzZero(My.Forms.Regiao.IdRegiao.Text)))

        Try
            cmd.ExecuteNonQuery()
            CNN.Close()
            EncheGrid()
            MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
            ErroLivre = "Cidade adicionada com sucesso"
            GerarLog(Me.Text, AçãoTP.Livre, Me.cMun.Text)


        Catch ex As Exception
            If Err.Number = 5 Then
                MsgBox("Esta cidade esta cadastrada nesta região, Verifique", 64, "Validação de Dados")
            Else
                MsgBox(ex.Message, 64, "Validação de Dados")
            End If
        End Try
        Me.cMun.SelectedIndex = -1
        Me.cMun.Focus()

    End Sub

    Private Sub cMun_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cMun.Enter
        If Me.cUF.Text = "" Then
            MessageBox.Show("O usuário deve informar o estado antes.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.cUF.Focus()
            Exit Sub
        End If

        EncheCidade()

    End Sub

    Private Sub RegiaoCidade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EncheUF()
        EncheGrid()
    End Sub


    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    
    Private Sub btAddAllEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddAllEstado.Click
        'Area destinada para as validacoes
        If Me.cUF.Text = "" Then
            MsgBox("A UF não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.cUF.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim Sql As String = "INSERT INTO RegiaoCidade ( CodCidade, CidadeDesc, IdRegiao ) SELECT Municipio.CodMunicipio, Municipio.NomeMunic, " & NzZero(My.Forms.Regiao.IdRegiao.Text) & " AS Regiao FROM(Municipio) WHERE (((Municipio.UF)='" & Me.cUF.SelectedValue & "'));"
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        
        Try
            cmd.ExecuteNonQuery()
            CNN.Close()
            EncheGrid()
            MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
        Catch ex As Exception
            If Err.Number = 5 Then
                MsgBox("Esta cidade esta cadastrada nesta região, Verifique", 64, "Validação de Dados")
            Else
                MsgBox(ex.Message, 64, "Validação de Dados")
            End If
        End Try
       
    End Sub
End Class