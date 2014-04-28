Imports System.Data.OleDb
Public Class ServicoFuncionario
    Public strTag As String
    Public strNodeG1 As String
    Public strNodeG2 As String
    Public strNodeG3 As String
    Public NomeStr As String
    Public indexNode As Integer
    Public NameNode As String
    Public NodeDescricao As String

    Public nodeG1 As TreeNode = New TreeNode
    Public nodeG2 As TreeNode = New TreeNode
    Public nodeG3 As TreeNode = New TreeNode
    Public nodeG4 As TreeNode = New TreeNode

    Public Acao As Byte  '0 sem acao, 1 insert, 2 update, 3 delete

    Dim Arq_DB As String

    Private NomeTabela As String

    Dim Ação As New TrfGerais
    Dim pGrupo As String
    Public sv As New ServicoItem

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Public Sub MostrarTree()

        Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        ' Abre a conexao com o banco de dados
        Dim con As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        'Con = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        Me.TreeView1.Nodes.Clear()

        Try
            Con.Open()
        Catch exConnection As System.Exception
            MessageBox.Show(exConnection.GetBaseException.ToString, "Erro ao Conectar com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Invocamos o método BeginUpdate para iniciarmos a atualização do controle TreeView
        'este método permite que todas as modificações no controle sejam feitas e somente
        'sejam atualizadas na tela após invocarmos o método EndUpdate.

        Me.TreeView1.BeginUpdate()

        Dim sql As String

        Dim MeuArray(4)
        MeuArray(0) = "SELECT FuncionarioServico.fs_ID, FuncionarioServico.fs_codigoFuncionario, Funcionários.Nome"
        MeuArray(1) = "FROM FuncionarioServico "
        MeuArray(2) = "INNER JOIN "
        MeuArray(3) = "Funcionários ON FuncionarioServico.fs_codigoFuncionario = Funcionários.CódigoFuncionário"
        sql = Join(MeuArray)

        Dim cmd As New OleDb.OleDbCommand(sql, con)
        'Esta é a variável que armazenará o objeto OleDbDataReader
        Dim dr As OleDb.OleDbDataReader
        'Carregaremos o objeto OleDbDataReader com os registros retornados pelo objeto 'OleDbCommand. Para isso será necessário invocarmos o método ExecuteReader() do 'objeto OleDbCommand.
        dr = cmd.ExecuteReader()

        'Variáveis utilizadas para criação dos "nós" do TreeView
        Dim nodeG1 As TreeNode = New TreeNode
        Dim nodeG2 As TreeNode = New TreeNode

        Dim strG1Atual As String = ""
        Dim strG2Atual As String = ""

        Dim strNodeG1 As String = ""
        Dim strNodeG2 As String = ""

        Dim nodeAtual As String = ""
        Dim nodeAtual1 As String = ""

        'TreeView - define o No Raíz
        Dim Raiz As TreeNode
        Raiz = New TreeNode()
        Raiz.Tag = "Raiz"
        Raiz.Text = "FUNCIONARIOS"
        Me.TreeView1.Nodes.Add(Raiz)

        Dim Ind1 As Integer = 0
        Dim Ind2 As Integer = 0

        'Iniciamos o loop através dos registros contidos no OleDbDataReader

        While dr.Read()
            strNodeG1 = dr("fs_codigofuncionario")
            'Verificamos se o registro corresponde ao G1 ATUAL.
            If Not nodeAtual = strNodeG1 Then

                nodeG1 = New TreeNode()
                With nodeG1
                    '.ImageIndex = 0
                    .Tag = "G1"
                    .Text = dr("fs_codigofuncionario") & "-" & dr("nome")
                End With

                'Depois de criado o novo "nó" - adicionaremos-o ao controle TreeView
                TreeView1.Nodes(0).Nodes.Add(nodeG1)

                'Adiciona no objeto name do node o codigo e um index.
                nodeG1.Name = dr("fs_codigofuncionario") & "/" & nodeG1.Index

                'Atualizamos a variável com o código do g1 atual
                nodeAtual = dr("fs_codigofuncionario")
            End If


        End While

        'fechamos o objeto OleDbDataReader
        dr.Close()

        'fechamos a conexão com o banco de dados
        Con.Close()

        'restauramos o cursor 
        Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        'invocamos o método EndUpdate do controle TreeView para que as atualizações sejam
        'apresentadas ao usuário.
        Me.TreeView1.EndUpdate()

    End Sub
    Public Sub atGrid()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim sql As String
        Dim myArray(4)
        myArray(0) = "SELECT FuncionarioServicoDetalhe.Sv_Id, Servicos.Serv_Codigo, Servicos.Serv_Descricao, Servicos.Serv_ValorServico, FuncionarioServicoDetalhe.Sv_Comissão "
        myArray(1) = "FROM Servicos "
        myArray(2) = "INNER JOIN "
        myArray(3) = "FuncionarioServicoDetalhe ON Servicos.Serv_Codigo = FuncionarioServicoDetalhe.Sv_CodigoServico"
        myArray(4) = " WHERE (((FuncionarioServicoDetalhe.Sv_CodigoFuncionario)=" & strNodeG1 & "));"
        sql = Join(myArray)

        Dim CMD As New OleDb.OleDbCommand(sql, CNN)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet


        Da.Fill(ds, "Table")

        Me.DgvItem.DataSource = ds.Tables("Table").DefaultView

        Da.Dispose()
        CNN.Close()
    End Sub
    

    Private Sub TreeView1_NodeMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        NameNode = e.Node.Name
        strTag = e.Node.Tag

        Select Case e.Node.Tag
            Case "G1"
                NomeStr = Mid(NameNode, 1, NameNode.IndexOf("/"))
                NodeDescricao = Mid(e.Node.Text, 6)
                'Me.NovaContaToolStripMenuItem.Enabled = True
                strNodeG1 = NomeStr
                atGrid()
                v_codigoLancamento()
                sv.Codigofuncionario = strNodeG1
            Case "Raiz"
                strNodeG1 = 0
                atGrid()
        End Select
    End Sub
    Sub v_codigoLancamento()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim Sql As String = "SELECT  fs_ID, fs_codigoFuncionario from FuncionarioServico WHERE fs_codigoFuncionario=" & CInt(strNodeG1)


        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            'achou registro
            sv.CodigoLancamento = DR.Item("fs_id")
        End If

        DR.Close()
    End Sub
    Private Sub ServicoFuncionario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostrarTree()
        Me.TreeView1.Nodes(0).Expand()
    End Sub

    Private Sub AdicionarUmNovoFuncionárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarUmNovoFuncionárioToolStripMenuItem.Click
        My.Forms.ServicoFuncionarioAdd.ShowDialog()
    End Sub
    
    Private Sub expNode()

        Dim A1 As Integer = 0
        Dim A2 As Integer = 0
        Dim A3 As Integer = 0
        Dim A4 As Integer = 0
        Dim idNode(3) As String

        If NameNode = Nothing Then
        Else
            idNode = NameNode.Split("/")
            idNode = idNode(1).Split(";")
        End If

        Try
            Select Case strTag
                Case "G1"
                    A1 = idNode(0)
                    Me.TreeView1.Nodes(0).Expand()
                Case "G2"
                    A1 = idNode(0)
                    A2 = idNode(1)
                    Me.TreeView1.Nodes(0).Expand()
                    Me.TreeView1.Nodes(0).Nodes(A1).Expand()
                Case "G3"
                    A1 = idNode(0)
                    A2 = idNode(1)
                    A3 = idNode(2)
                    Me.TreeView1.Nodes(0).Expand()
                    Me.TreeView1.Nodes(0).Nodes(A1).Expand()
                    Me.TreeView1.Nodes(0).Nodes(A1).Nodes(A2).Expand()
                Case Else
                    Me.TreeView1.Nodes(0).Expand()
            End Select
            Acao = 0 'sem acao
        Catch ex As Exception

        End Try

    End Sub

    Private Sub AdicionarUmNovoServiçoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarUmNovoServiçoToolStripMenuItem.Click
        If strNodeG1 = Nothing Or strNodeG1 = 0 Then

            Exit Sub
        Else
            My.Forms.ServicosProcura.ShowDialog()
        End If
    End Sub
    Public Sub AddItemServico()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "INSERT INTO FuncionarioServicoDetalhe (fs_Codigo,sv_codigoFuncionario,Sv_CodigoServico,Sv_Comissão) VALUES (?,?,?,?)"
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)
        cmd.Parameters.Add(New OleDb.OleDbParameter("codigolancamento", sv.CodigoLancamento))
        cmd.Parameters.Add(New OleDb.OleDbParameter("codigofuncionario", sv.Codigofuncionario))
        cmd.Parameters.Add(New OleDb.OleDbParameter("codigoservico", sv.Codigoservico))
        cmd.Parameters.Add(New OleDb.OleDbParameter("comissao", sv.Comissao))

        Try
            cmd.ExecuteNonQuery()

            MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try
        CNN.Close()
        atGrid()
    End Sub
    Private Sub AddItemServicoTodos()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String
        Sql = "INSERT INTO FuncionarioServicoDetalhe ( sv_codigoservico, fs_codigo, sv_codigofuncionario, sv_comissão ) SELECT Servicos.serv_codigo," & sv.CodigoLancamento & ", " & sv.Codigofuncionario & ", '" & sv.Comissao & "' FROM Servicos"

        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)
        Try
            cmd.ExecuteNonQuery()

            MsgBox("Registros adicionado com sucesso", 64, "Validação de Dados")
        Catch ex As Exception
            Select Case Err.Number
                Case 5
                    MsgBox("Já foram adicionados serviços para este funcionário." & Chr(13) & "Você não pode adicionar serviços repetidos para o mesmo funcionário", MsgBoxStyle.Critical, "Validação de Dados")
                Case Else
                    MsgBox(ex.Message, 64, "Validação de Dados")
            End Select
        End Try
        CNN.Close()
        atGrid()
    End Sub

    Private Sub ExcluirServiçoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirServiçoToolStripMenuItem.Click

        If strTag = "Raiz" Then

            Exit Sub

        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "DELETE * FROM FuncionarioServicoDetalhe WHERE Sv_id=" & Me.DgvItem.CurrentRow.Cells(0).Value

        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        Try
            cmd.ExecuteNonQuery()

            MsgBox("Registro Excluído  com sucesso", 64, "Validação de Dados")
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try
        CNN.Close()
        atGrid()
    End Sub

    Private Sub ExccluirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExccluirToolStripMenuItem.Click

    End Sub

    Private Sub AdicionarTodosOsServiçosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarTodosOsServiçosToolStripMenuItem.Click
        If strNodeG1 = Nothing Or strNodeG1 = 0 Then

            Exit Sub
        Else
            My.Forms.ServicoComissao.ShowDialog()
        End If



        AddItemServicoTodos()
       

    End Sub

    Private Sub AtualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarToolStripMenuItem.Click

        If strNodeG1 = Nothing Or strNodeG1 = 0 Then

            Exit Sub
        Else
            My.Forms.ServicoComissao.ShowDialog()
        End If






        Dim objDS As New DataSet
        Dim i As Integer = 0
        Dim objRow As Data.DataRow
        Dim result As Integer
        Dim objCB As OleDb.OleDbCommandBuilder


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String
        Sql = "Select * from FuncionarioServicoDetalhe where sv_codigofuncionario=" & sv.Codigofuncionario

        Dim sqlServ As String
        sqlServ = "Select * from Servicos"
        Dim objDA As New OleDb.OleDbDataAdapter(Sql, CNN)
        Dim objDAS As New OleDb.OleDbDataAdapter(sqlServ, CNN)
        objDA.Fill(objDS, "FServico")
        objDAS.Fill(objDS, "Servico")

        objCB = New OleDbCommandBuilder(objDA)
        With objDS.Tables("Servico")
            For i = 0 To .Rows.Count - 1
                result = .Rows(i).Item("serv_codigo").ToString
                Dim Linha As DataRow() = objDS.Tables("FServico").Select("sv_codigoservico=" & result)
                If Linha.Length = 0 Then
                    objRow = objDS.Tables("FServico").NewRow
                    objRow("fs_codigo") = sv.CodigoLancamento
                    objRow("sv_codigofuncionario") = sv.Codigofuncionario
                    objRow("sv_codigoservico") = .Rows(i).Item("serv_codigo").ToString
                    objRow("sv_comissão") = sv.Comissao
                    objDS.Tables("FServico").Rows.Add(objRow)
                    objDA.Update(objDS, "FServico")
                End If
            Next
        End With
        CNN.Close()
        atGrid()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class