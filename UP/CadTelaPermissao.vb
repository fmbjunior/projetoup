Imports System.Data.OleDb

Public Class CadTelaPermissao

    Dim DsPermissao As DataSet
    Dim TelSelect As String

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2


    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEditar.Click
        If Me.Tela.Text = "" Then
            MsgBox("No existe Tela do sistema para ser editado.", 64, "Validação de Dados")
            Exit Sub
        End If
        Operation = UPD
        Ação.Desbloquear_Controle(Me, True)
        Me.Tela.Focus()
    End Sub

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        Ação.Desbloquear_Controle(Me, True)
        Ação.LimpaTextBox(Me)
        Operation = INS
    End Sub

    Public Sub LocalizaDados()
        Dim CNN As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from TelasSistema where Tela = '" & Tela.Text & "'"
        Dim CMD As New OleDbCommand(Sql, CNN)
        Dim DR As OleDbDataReader

        DR = CMD.ExecuteReader
        If Not DR.Read() Then
            Exit Sub
        Else
            Me.Tela.Text = DR.Item("Tela") & ""
            Me.DescricaoTela.Text = DR.Item("DescricaoTela") & ""
        End If

        Operation = UPD
        DR.Close()
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click

        'Area destinada para as validacoes

        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            Dim Sql As String = "INSERT INTO TelasSistema (Tela, DescricaoTela) VALUES (@1, @2)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Tela.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DescricaoTela.Text, 1)))

            cmd.ExecuteNonQuery()
            MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
            Ação.Desbloquear_Controle(Me, False)
            CNN.Close()

        ElseIf Operation = UPD Then
            CNN.Open()

            Dim Sql As String = "Update TelasSistema set DescricaoTela = @2 Where Tela = '" & Me.Tela.Text & "'"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            'cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Tela.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DescricaoTela.Text, 1)))
            cmd.ExecuteNonQuery()
            MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
            Ação.Desbloquear_Controle(Me, False)
            CNN.Close()
        End If

    End Sub

    Private Sub Tela_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tela.Leave
        LocalizaDados()
    End Sub

    Private Sub btExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExcluir.Click
        If Me.Tela.Text = "" Then
            Exit Sub
        End If

        If MsgBox("Deseja excluir a tela e todas as suas dependências de Permissão.", 36, "Validação de Dados") = 6 Then

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()
            Dim CmdTela As OleDb.OleDbCommand = CNN.CreateCommand
            Dim CmdPermissao As OleDb.OleDbCommand = CNN.CreateCommand

            CmdTela.Transaction = Transacao
            CmdPermissao.Transaction = Transacao

            Try

                Dim SqlPermissao As String = "Delete * From LoginUserPermissao Where Tela = '" & Me.Tela.Text & "'"
                CmdPermissao.CommandText = SqlPermissao
                CmdPermissao.ExecuteNonQuery()

                Dim Sql As String = "Delete * From TelasSistema Where Tela = '" & Me.Tela.Text & "'"
                CmdTela.CommandText = Sql
                CmdTela.ExecuteNonQuery()

                Transacao.Commit()
                CNN.Close()

                Me.Tela.Clear()
                Me.DescricaoTela.Clear()
                Buscar(2)

                MessageBox.Show("Exclusão da tela e de todas as suas permissões feita com sucesso", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                Transacao.Rollback()
                CNN.Close()
                MsgBox(ex.Message, 64, "Validação de Dados")
                CNN.Close()
            End Try
        End If

    End Sub



#Region "Rotina de Procura"

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged
        If Me.A1.Checked = True Then
            Me.TxtProcura.Enabled = True
            Me.TxtProcura.Focus()
        End If
        If Me.A2.Checked = True Then
            Buscar(2)
        End If
    End Sub

    Private Sub Buscar(ByVal Opt As Integer)

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Select Case Opt
            Case 1
                Sql = "Select TelasSistema.Tela, TelasSistema.DescricaoTela From TelasSistema Where TelasSistema.DescricaoTela like '%" & Me.TxtProcura.Text & "%' Order by TelasSistema.DescricaoTela"
            Case 2
                Sql = "Select TelasSistema.Tela, TelasSistema.DescricaoTela From TelasSistema Order by TelasSistema.DescricaoTela"
        End Select

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Lista.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        Cnn.Close()
        Me.TxtProcura.Clear()

    End Sub

    Private Sub Lista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellDoubleClick

        Me.Tela.Text = Me.Lista.CurrentRow.Cells(0).Value
        Me.DescricaoTela.Text = Me.Lista.CurrentRow.Cells(1).Value
        Operation = UPD

    End Sub

    Private Sub TxtProcura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtProcura.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.A1.Checked = True Then
                Buscar(1)
            End If
        End If
    End Sub

#End Region


    Private Sub CadTelaPermissao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregaListaPermissao()
    End Sub

    Private Sub CarregaListaPermissao()
        Dim CNNPermissao As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNNPermissao.Open()


        Dim Sql As String = "SELECT LoginUserPermissao.Id, LoginUserPermissao.Login, LoginUserPermissao.Tela, LoginUserPermissao.Senha, LoginUserPermissao.DescricaoTela, LoginUserPermissao.Exclui, LoginUserPermissao.Adiciona, LoginUserPermissao.Altera, LoginUserPermissao.Consultar, LoginUserPermissao.Inativo FROM LoginUserPermissao;"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNNPermissao)
        Dim DaPermissao As New OleDb.OleDbDataAdapter(CMD)

        DsPermissao = New DataSet
        DaPermissao.Fill(DsPermissao, "Permissao")


    End Sub

    Public Sub AlteracoesCadastro()

        CarregaListaPermissao()

        Dim Tbl As New DataView(DsPermissao.Tables("Permissao").Copy)
        Tbl.RowFilter = "Tela = '" & Me.Lista.CurrentRow.Cells("cTela").Value & "'"
        Me.ListaPermissao.DataSource = Tbl.ToTable()
    End Sub

    Private Sub Lista_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lista.SelectionChanged
        Dim Tbl As New DataView(DsPermissao.Tables("Permissao").Copy)
        Tbl.RowFilter = "Tela = '" & Me.Lista.CurrentRow.Cells("cTela").Value & "'"
        Me.ListaPermissao.DataSource = Tbl.ToTable()
        TelSelect = Me.Lista.CurrentRow.Cells("cTela").Value
    End Sub


    'Private Sub AdicionarPermissãoDaTelaSelecionadaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarPermissãoDaTelaSelecionadaToolStripMenuItem.Click

    '    Dim vTela As String = Me.Lista.CurrentRow.Cells("cTela").Value
    '    Dim vDescTela As String = Me.Lista.CurrentRow.Cells("cDesc").Value

    '    My.Forms.CadTelaPermissaoAddEdd.Operation = INS
    '    My.Forms.CadTelaPermissaoAddEdd.Tela.Text = vTela
    '    My.Forms.CadTelaPermissaoAddEdd.DescricaoTela.Text = vDescTela
    '    My.Forms.CadTelaPermissaoAddEdd.ShowDialog()
    'End Sub

    Private Sub btEditarSelecionado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEditarSelecionado.Click

        Try
            Dim vLogin As String = Me.ListaPermissao.CurrentRow.Cells("Clogin").Value
            Dim vTela As String = Me.ListaPermissao.CurrentRow.Cells("ccTela").Value

            My.Forms.CadTelaPermissaoAddEdd.Operation = UPD
            My.Forms.CadTelaPermissaoAddEdd.EncheListaUsuario()
            My.Forms.CadTelaPermissaoAddEdd.AcharLogin(vTela, vLogin)
            My.Forms.CadTelaPermissaoAddEdd.ShowDialog()
        Catch ex As Exception

            Select Case Err.Number
                Case 91
                    MessageBox.Show("Não foi selecionado nenhum item da lista de Permissão ou adicione uma nova permissão", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
            End Select
            MessageBox.Show(ex.Message, "Validação de Dado", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btSalvarTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvarTodos.Click

        If Me.ListaPermissao.RowCount = 0 Then
            MessageBox.Show("A lista de Permissão não contem nenhuma informação para salvar", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "SELECT * from LoginUserPermissao where Tela = '" & TelSelect & "'"

        Dim Ds As New DataSet()
        Dim CmdPermissao As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DAPermissao As New OleDb.OleDbDataAdapter(CmdPermissao)

        DAPermissao.Fill(Ds, "Permissao")


        For Each Linha As DataGridViewRow In Me.ListaPermissao.Rows

            Dim DrEDD() As DataRow
            DrEDD = Ds.Tables("Permissao").Select("Login = '" & Linha.Cells("cLogin").Value & "'")

            If DrEDD.Length = 1 Then
                DrEDD(0).BeginEdit()
                DrEDD(0)("Adiciona") = Linha.Cells("cAdiciona").Value
                DrEDD(0)("Altera") = Linha.Cells("cAltera").Value
                DrEDD(0)("Exclui") = Linha.Cells("cExclui").Value
                DrEDD(0)("Consultar") = Linha.Cells("cConsultar").Value
                DrEDD(0)("Inativo") = Linha.Cells("cInativo").Value
                DrEDD(0).EndEdit()
            End If

        Next

        Try
            Dim objPermissao As New OleDbCommandBuilder(DAPermissao)
            DAPermissao.Update(Ds, "Permissao")
            DAPermissao.Dispose()
            Cnn.Close()
            MessageBox.Show("Permissões salvas com sucesso", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AlteracoesCadastro()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub

    Private Sub Lista_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellContentClick

    End Sub

    Private Sub AdicionarPermissãoParaUsuárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarPermissãoParaUsuárioToolStripMenuItem.Click
        Dim vTela As String = Me.Lista.CurrentRow.Cells("cTela").Value
        Dim vDescTela As String = Me.Lista.CurrentRow.Cells("cDesc").Value

        My.Forms.CadTelaPermissaoAddEdd.Operation = INS
        My.Forms.CadTelaPermissaoAddEdd.Tela.Text = vTela
        My.Forms.CadTelaPermissaoAddEdd.DescricaoTela.Text = vDescTela
        My.Forms.CadTelaPermissaoAddEdd.ShowDialog()
    End Sub

    Private Sub ListaPermissao_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ListaPermissao.CellContentClick
        If Me.ListaPermissao.CurrentCell.ColumnIndex = 1 Then
            System.Windows.Forms.SendKeys.Send("{Tab}")
        Else
            System.Windows.Forms.SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub AdicionarPermissãoParaTodosOsUsuáriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarPermissãoParaTodosOsUsuáriosToolStripMenuItem.Click

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim ds As New DataSet()
       
        Dim Sql As String = String.Empty
        Sql = "SELECT LoginUser.Login, LoginUser.NomeUser, LoginUser.Inativo FROM(LoginUser)WHERE (((LoginUser.Inativo)=False));"

        Dim DALogin As New OleDb.OleDbDataAdapter(Sql, CNN)
        DALogin.Fill(ds, "Login")

        Dim vTela As String = Me.Lista.CurrentRow.Cells("cTela").Value
        Dim vDescTela As String = Me.Lista.CurrentRow.Cells("cDesc").Value
        Sql = "SELECT LoginUserPermissao.* FROM(LoginUserPermissao) WHERE (((LoginUserPermissao.Tela)='" & vTela & "'));"
        Dim DATela As New OleDb.OleDbDataAdapter(Sql, CNN)
        DATela.Fill(ds, "Telas")

        Dim DrLogin As DataRow
        For Each DrLogin In ds.Tables("Login").Rows
            Dim Linha() As DataRow
            Linha = ds.Tables("Telas").Select("Login = '" & DrLogin("Login").ToString & "'")


            Dim TBL As DataTable
            TBL = ds.Tables("Telas")


            If Linha.Length = 0 Then
                Dim DRnovo As DataRow
                DRnovo = TBL.NewRow()
                DRnovo("Login") = DrLogin("Login").ToString
                DRnovo("Tela") = vTela
                DRnovo("DescricaoTela") = vDescTela
                DRnovo("Exclui") = False
                DRnovo("Adiciona") = False
                DRnovo("Altera") = False
                DRnovo("Consultar") = False
                DRnovo("Inativo") = True
                TBL.Rows.Add(DRnovo)
            End If

        Next

        Try
            Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DATela)
            DATela.Update(ds, "Telas")
            MessageBox.Show("Permissões incluidas com sucesso.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CNN.Close()

            AlteracoesCadastro()
        Catch ex As Exception
            MsgBox(ex.Message)
            CNN.Close()
            Exit Sub
        End Try

    End Sub

End Class