Public Class BalanceteCadastro

    Public strTag As String
    Public strNodeG1 As String
    Public strNodeG2 As String
    Public strNodeG3 As String
    Public NomeStr As String
    Public indexNode As Integer
    Public NameNode As String
    Public NodeDescricao As String
    Public pTipo As String

    Public nodeG1 As TreeNode = New TreeNode
    Public nodeG2 As TreeNode = New TreeNode
    Public nodeG3 As TreeNode = New TreeNode
    Public nodeG4 As TreeNode = New TreeNode

    Public Acao As Byte  '0 sem acao, 1 insert, 2 update, 3 delete

    Dim Arq_DB As String
    ' a conexao com o banco de dados
    Private con As OleDb.OleDbConnection

    Private NomeTabela As String

    Dim Ação As New TrfGerais
    Dim pGrupo As String

    Enum Operacao
        INS = 0
        UPD = 1
        DEL = 2
    End Enum

    Public Sub MostrarTreeGrupo()

        Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        ' Abre a conexao com o banco de dados
       
        con = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
       
        Me.treeView1.Nodes.Clear()

        Try
            con.Open()
        Catch exConnection As System.Exception
            MessageBox.Show(exConnection.GetBaseException.ToString, "Erro ao Conectar com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Invocamos o método BeginUpdate para iniciarmos a atualização do controle TreeView
        'este método permite que todas as modificações no controle sejam feitas e somente
        'sejam atualizadas na tela após invocarmos o método EndUpdate.

        Me.treeView1.BeginUpdate()

        Dim sql As String
        'sql = "SELECT ContasG1.ContaGrupo1, ContasG1.DescContaGrupo1, ContasG2.ContaGrupo2, ContasG2.DescContaGrupo2, ContasG3.ContaGrupo3, ContasG3.DescContaGrupo3, ContasG3.TipoLanc, ContasG1.Empresa FROM (ContasG1 LEFT JOIN ContasG2 ON ContasG1.ContaGrupo1 = ContasG2.ContaGrupo1) LEFT JOIN ContasG3 ON (ContasG2.ContaGrupo2 = ContasG3.ContaGrupo2) AND (ContasG2.ContaGrupo1 = ContasG3.ContaGrupo1) WHERE (((ContasG1.Empresa)=" & CodEmpresa & ")) order by  ContasG1.ContaGrupo1;"
        sql = "SELECT ContasG1.ContaGrupo1, ContasG1.DescContaGrupo1, ContasG2.ContaGrupo2, ContasG2.DescContaGrupo2, ContasG3.ContaGrupo3, ContasG3.DescContaGrupo3, ContasG3.TipoLanc, ContasG1.Empresa FROM (ContasG1 LEFT JOIN ContasG2 ON ContasG1.ContaGrupo1 = ContasG2.ContaGrupo1) LEFT JOIN ContasG3 ON (ContasG2.ContaGrupo2 = ContasG3.ContaGrupo2) AND (ContasG2.ContaGrupo1 = ContasG3.ContaGrupo1) WHERE(((ContasG1.Empresa) = " & CodEmpresa & ")) ORDER BY ContasG1.ContaGrupo1, ContasG2.ContaGrupo2, ContasG3.ContaGrupo3;"
        Dim cmd As New OleDb.OleDbCommand(sql, con)
        'Esta é a variável que armazenará o objeto OleDbDataReader
        Dim dr As OleDb.OleDbDataReader
        'Carregaremos o objeto OleDbDataReader com os registros retornados pelo objeto 'OleDbCommand. Para isso será necessário invocarmos o método ExecuteReader() do 'objeto OleDbCommand.
        dr = cmd.ExecuteReader()

        'Variáveis utilizadas para criação dos "nós" do TreeView
        Dim nodeG1 As TreeNode = New TreeNode
        Dim nodeG2 As TreeNode = New TreeNode
        Dim nodeG3 As TreeNode = New TreeNode
        Dim nodeG4 As TreeNode = New TreeNode

        Dim strG1Atual As String = ""
        Dim strG2Atual As String = ""
        Dim strG3Atual As String = ""
        Dim strG4Atual As String = ""

        Dim strNodeG1 As String = ""
        Dim strNodeG2 As String = ""
        Dim strNodeG3 As String = ""
        Dim strNodeG4 As String = ""

        Dim nodeAtual As String = ""
        Dim nodeAtual1 As String = ""
        Dim nodeAtual2 As String = ""
        Dim nodeAtual3 As String = ""

        'TreeView - define o No Raíz
        Dim Raiz As TreeNode
        Raiz = New TreeNode()
        Raiz.Tag = "Raiz"
        Raiz.Text = "Contas"
        Me.treeView1.Nodes.Add(Raiz)

        Dim Ind1 As Integer = 0
        Dim Ind2 As Integer = 0
        Dim Ind3 As Integer = 0
        Dim Ind4 As Integer = 0

        'Iniciamos o loop através dos registros contidos no OleDbDataReader

        While dr.Read()
            strNodeG1 = dr("ContaGrupo1")
            'Verificamos se o registro corresponde ao G1 ATUAL.
            If Not nodeAtual = strNodeG1 Then

                nodeG1 = New TreeNode()
                With nodeG1
                    .ImageIndex = 0
                    .Tag = "G1"
                    .Text = dr("ContaGrupo1") & "-" & dr("DescContaGrupo1")
                End With

                'Depois de criado o novo "nó" - adicionaremos-o ao controle TreeView
                treeView1.Nodes(0).Nodes.Add(nodeG1)

                'Adiciona no objeto name do node o codigo e um index.
                nodeG1.Name = dr("ContaGrupo1") & "/" & nodeG1.Index

                'Atualizamos a variável com o código do g1 atual
                nodeAtual = dr("ContaGrupo1")
            End If

            'Aqui iniciamos a criação dos "nós" que exibirão os g2 de cada g1.

            strNodeG2 = strNodeG1 & ";" & dr("ContaGrupo2") 'monta um string juntando  o codigo do G1 e o codigo G2.

            If Not nodeAtual1 = strNodeG2 Then 'Verifica se o NodeAtual é igual o node do G2.

                If IsDBNull(dr("DescContaGrupo2")) Then
                Else
                    nodeG2 = New TreeNode()
                    With nodeG2
                        .ImageIndex = 1
                        .Tag = "G2"
                        .Text = dr("ContaGrupo2") & "-" & dr("DescContaGrupo2") & ""
                    End With

                    'Adicionamos o "nó" do g2 para o g1 atual.
                    treeView1.Nodes(0).Nodes(nodeG1.Index).Nodes.Add(nodeG2)

                    'Adiciona no objeto name do node o codigo e um index.
                    nodeG2.Name = dr("ContaGrupo1") & "-" & dr("ContaGrupo2") & "/" & nodeG1.Index & ";" & nodeG2.Index

                    'Atualizamos a variável para indicar qual é o g2 atual.
                    nodeAtual1 = strNodeG1 & ";" & dr("ContaGrupo2")
                End If
            End If

            'Aqui iniciamos a criação dos "nós" que exibirão os G3.

            strNodeG3 = strNodeG2 & ";" & dr("ContaGrupo3")
            If Not nodeAtual2 = strNodeG3 Then
                If IsDBNull(dr("DescContaGrupo3")) Then
                Else
                    nodeG3 = New TreeNode()
                    With nodeG3
                        .ImageIndex = 1
                        .Tag = "G3"
                        .Text = dr("ContaGrupo3") & "-" & dr("DescContaGrupo3") & ""
                    End With

                    'Adicionamos o "nó" do G3 para o g2 atual.
                    treeView1.Nodes(0).Nodes(nodeG1.Index).Nodes(nodeG2.Index).Nodes.Add(nodeG3)

                    'Adiciona no objeto name do node o codigo e um index.
                    nodeG3.Name = dr("ContaGrupo1") & "-" & dr("ContaGrupo2").ToString & "-" & dr("ContaGrupo3") & "/" & nodeG1.Index & ";" & nodeG2.Index & ";" & nodeG3.Index

                    'atualizamos a variável para indicar qual é o g2 atual.
                    nodeAtual2 = strNodeG2 & ";" & dr("ContaGrupo3")
                End If
            End If
        End While

        'fechamos o objeto OleDbDataReader
        dr.Close()

        'fechamos a conexão com o banco de dados
        con.Close()

        'restauramos o cursor 
        Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        'invocamos o método EndUpdate do controle TreeView para que as atualizações sejam
        'apresentadas ao usuário.
        Me.treeView1.EndUpdate()
        expNode()
    End Sub

    Public Sub btMostrarArvore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMostrarArvore.Click
        MostrarTreeGrupo()
    End Sub

    Private Sub treeView1_AfterCollapse(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeView1.AfterCollapse
        'este é o código para restaurar os ícones quando o usuário colapsar os "nós"

        Select Case e.Node.Tag
            Case "Raiz"
                e.Node.ImageIndex = 0
            Case "G1"
                e.Node.ImageIndex = 0
            Case "G2"
                e.Node.ImageIndex = 0
            Case "G3"
                e.Node.ImageIndex = 0
        End Select
    End Sub

    Private Sub treeView1_AfterExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeView1.AfterExpand
        'este é o código para alterarmos os ícones quando o usuário expande os "nós"

        Select Case e.Node.Tag
            Case "Raiz"
                e.Node.ImageIndex = 1
            Case "G1"
                e.Node.ImageIndex = 1
            Case "G2"
                e.Node.ImageIndex = 1
            Case "G3"
                e.Node.ImageIndex = 1
        End Select
    End Sub

    Private Sub treeView1_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles treeView1.NodeMouseClick

        NameNode = e.Node.Name
        strTag = e.Node.Tag


        Select Case e.Node.Tag
            Case "G1"
                NomeStr = Mid(NameNode, 1, NameNode.IndexOf("/"))
                NodeDescricao = Mid(e.Node.Text, 6)

                Me.NovaContaToolStripMenuItem.Enabled = True
                strNodeG1 = NomeStr

            Case "G2"
                NomeStr = Mid(NameNode, 1, NameNode.IndexOf("/"))
                Me.NovaContaToolStripMenuItem.Enabled = True
                strNodeG1 = NomeStr
                NodeDescricao = Mid(e.Node.Text, 6)
            Case "G3"
                NomeStr = Mid(NameNode, 1, NameNode.IndexOf("/"))
                Me.NovaContaToolStripMenuItem.Enabled = True
                strNodeG1 = NomeStr
                NodeDescricao = Mid(e.Node.Text, 8)
        End Select
    End Sub

    Private Sub NovaContaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovaContaToolStripMenuItem.Click

        If strTag = Nothing Then
            MessageBox.Show("Favor selecionar um nivel para fazer o cadastro", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If strTag = "G3" Then
            MsgBox("Você está tentando adicionar no último nível!, Use um nível acima", 48, "ATENÇÃO")
            Exit Sub
        Else
            Me.Acao = 1
            My.Forms.BalanceteCadastroAdd.ShowDialog()
            My.Forms.BalanceteCadastroAdd.Conta.Text = "0000"
        End If

    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
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
                    Me.treeView1.Nodes(0).Expand()
                Case "G2"
                    A1 = idNode(0)
                    A2 = idNode(1)
                    Me.treeView1.Nodes(0).Expand()
                    Me.treeView1.Nodes(0).Nodes(A1).Expand()
                Case "G3"
                    A1 = idNode(0)
                    A2 = idNode(1)
                    A3 = idNode(2)
                    Me.treeView1.Nodes(0).Expand()
                    Me.treeView1.Nodes(0).Nodes(A1).Expand()
                    Me.treeView1.Nodes(0).Nodes(A1).Nodes(A2).Expand()
                Case Else
                    Me.treeView1.Nodes(0).Expand()
            End Select
            Acao = 0 'sem acao
        Catch ex As Exception

        End Try

    End Sub
    Private Sub AchaRaiz()
        ' Abre a conexao com o banco de dados
        con = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        Dim Cmd As New OleDb.OleDbCommand() 'Cria o  objeto command
        Dim DataReader As OleDb.OleDbDataReader 'Cria o objeto DataReader 



        With Cmd
            .Connection = con
            .CommandTimeout = 0
            If strTag = "G1" Then
                .CommandText = "SELECT * from ContasG1 Where ContaGrupo1 like '" & strNodeG1 & "'"
            Else
                If strTag = "G3" Then
                    .CommandText = "SELECT * from ContasG3 Where ContaGrupo3 like '" & Mid(strNodeG1, 11, 6) & "'"
                End If
            End If
            .CommandType = CommandType.Text

        End With
        Try
            
                con.Open()
                DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    If strTag = "G1" Then
                        pTipo = DataReader.Item("Tipo").ToString
                    Else
                        If strTag = "G3" Then
                            pTipo = DataReader.Item("cIntegracao").ToString

                        End If
                    End If
                End If
            End While

            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
        End Try
    End Sub



    Private Sub EditarContaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarContaToolStripMenuItem.Click

        If strTag = Nothing Then
            MessageBox.Show("Favor selecionar um nivel para fazer a edição", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Acao = 2 'update

        If strTag = "G1" Then
            AchaRaiz()
            If pTipo = "C" Then
                pTipo = "CREDITO"
            Else
                pTipo = "DEBITO"
            End If
            My.Forms.BalanceteCadastroAdd.cTIPO.Text = pTipo
        Else
            If strTag = "G3" Then
                AchaRaiz()
                My.Forms.BalanceteCadastroAdd.cIntegracao.Text = pTipo

            End If
        End If

        My.Forms.BalanceteCadastroAdd.Descricao.Text = NodeDescricao

        My.Forms.BalanceteCadastroAdd.ShowDialog()
    End Sub

    Private Sub btImpressao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImpressao.Click
        RelatorioCarregar = "BalanceteContas"
        My.Forms.VisualizadorRelatorio.Show()
    End Sub

    Public Sub pesquisarTree()
        Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        ' Abre a conexao com o banco de dados
        con = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        Me.treeView1.Nodes.Clear()

        Try
            con.Open()

            'Invocamos o método BeginUpdate para iniciarmos a atualização do controle TreeView
            'este método permite que todas as modificações no controle sejam feitas e somente
            'sejam atualizadas na tela após invocarmos o método EndUpdate.

            Me.treeView1.BeginUpdate()
            Dim sql As String = String.Empty

            Select Case pGrupo
                Case 1
                    sql = "SELECT ContasG1.ContaGrupo1, ContasG1.DescContaGrupo1, ContasG2.ContaGrupo2, ContasG2.DescContaGrupo2, ContasG3.ContaGrupo3, ContasG3.DescContaGrupo3, ContasG3.Empresa FROM (ContasG1 INNER JOIN ContasG2 ON ContasG1.ContaGrupo1 = ContasG2.ContaGrupo1) INNER JOIN ContasG3 ON (ContasG1.ContaGrupo1 = ContasG3.ContaGrupo1) AND (ContasG2.ContaGrupo2 = ContasG3.ContaGrupo2) AND (ContasG2.ContaGrupo1 = ContasG3.ContaGrupo1) WHERE (((ContasG1.DescContaGrupo1) Like '%" & Me.txtPesquisa.Text & "%')) And (((ContasG3.Empresa)=" & CodEmpresa & "));"
                Case 2
                    sql = "SELECT ContasG1.ContaGrupo1, ContasG1.DescContaGrupo1, ContasG2.ContaGrupo2, ContasG2.DescContaGrupo2, ContasG3.ContaGrupo3, ContasG3.DescContaGrupo3, ContasG3.Empresa FROM (ContasG1 INNER JOIN ContasG2 ON ContasG1.ContaGrupo1 = ContasG2.ContaGrupo1) INNER JOIN ContasG3 ON (ContasG1.ContaGrupo1 = ContasG3.ContaGrupo1) AND (ContasG2.ContaGrupo2 = ContasG3.ContaGrupo2) AND (ContasG2.ContaGrupo1 = ContasG3.ContaGrupo1) WHERE (((ContasG2.DescContaGrupo2) Like '%" & Me.txtPesquisa.Text & "%')) And (((ContasG3.Empresa)=" & CodEmpresa & "));"
                Case 3
                    sql = "SELECT ContasG1.ContaGrupo1, ContasG1.DescContaGrupo1, ContasG2.ContaGrupo2, ContasG2.DescContaGrupo2, ContasG3.ContaGrupo3, ContasG3.DescContaGrupo3, ContasG3.Empresa FROM (ContasG1 INNER JOIN ContasG2 ON ContasG1.ContaGrupo1 = ContasG2.ContaGrupo1) INNER JOIN ContasG3 ON (ContasG1.ContaGrupo1 = ContasG3.ContaGrupo1) AND (ContasG2.ContaGrupo2 = ContasG3.ContaGrupo2) AND (ContasG2.ContaGrupo1 = ContasG3.ContaGrupo1) WHERE (((ContasG3.DescContaGrupo3) Like '%" & Me.txtPesquisa.Text & "%')) And (((ContasG3.Empresa)=" & CodEmpresa & "));"

            End Select

            Dim cmd As New OleDb.OleDbCommand(sql, con)
            'Esta é a variável que armazenará o objeto OleDbDataReader
            Dim dr As OleDb.OleDbDataReader
            'Carregaremos o objeto OleDbDataReader com os registros retornados pelo objeto 'OleDbCommand. Para isso será necessário invocarmos o método ExecuteReader() do 'objeto OleDbCommand.
            dr = cmd.ExecuteReader()

            'Variáveis utilizadas para criação dos "nós" do TreeView
            Dim nodeG1 As TreeNode = New TreeNode
            Dim nodeG2 As TreeNode = New TreeNode
            Dim nodeG3 As TreeNode = New TreeNode
            Dim nodeG4 As TreeNode = New TreeNode

            Dim strG1Atual As String = ""
            Dim strG2Atual As String = ""
            Dim strG3Atual As String = ""
            Dim strG4Atual As String = ""

            Dim strNodeG1 As String = ""
            Dim strNodeG2 As String = ""
            Dim strNodeG3 As String = ""
            Dim strNodeG4 As String = ""

            Dim nodeAtual As String = ""
            Dim nodeAtual1 As String = ""
            Dim nodeAtual2 As String = ""
            Dim nodeAtual3 As String = ""

            'TreeView - define o No Raíz
            Dim Raiz As TreeNode
            Raiz = New TreeNode()
            Raiz.Tag = "Raiz"
            Raiz.Text = "Contas"
            Me.treeView1.Nodes.Add(Raiz)

            Dim Ind1 As Integer = 0
            Dim Ind2 As Integer = 0
            Dim Ind3 As Integer = 0
            Dim Ind4 As Integer = 0

            'Iniciamos o loop através dos registros contidos no OleDbDataReader
            While dr.Read()
                strNodeG1 = dr("ContaGrupo1")
                'Verificamos se o registro corresponde ao G1 ATUAL.
                If Not nodeAtual = strNodeG1 Then

                    nodeG1 = New TreeNode()
                    With nodeG1
                        .ImageIndex = 0
                        .Tag = "G1"
                        .Text = dr("ContaGrupo1") & "-" & dr("DescContaGrupo1")
                    End With

                    'Depois de criado o novo "nó" - adicionaremos-o ao controle TreeView
                    treeView1.Nodes(0).Nodes.Add(nodeG1)

                    'Adiciona no objeto name do node o codigo e um index.
                    nodeG1.Name = dr("ContaGrupo1") & "/" & nodeG1.Index

                    'Atualizamos a variável com o código do g1 atual
                    nodeAtual = dr("ContaGrupo1")

                End If

                'Aqui iniciamos a criação dos "nós" que exibirão os g2 de cada g1.

                strNodeG2 = strNodeG1 & ";" & dr("ContaGrupo2") 'monta um string juntando  o codigo do G1 e o codigo G2.

                If Not nodeAtual1 = strNodeG2 Then 'Verifica se o NodeAtual é igual o node do G2.

                    If IsDBNull(dr("DescContaGrupo2")) Then
                    Else
                        nodeG2 = New TreeNode()
                        With nodeG2
                            .ImageIndex = 1
                            .Tag = "G2"
                            .Text = dr("ContaGrupo2") & "-" & dr("DescContaGrupo2") & ""
                        End With

                        'Adicionamos o "nó" do g2 para o g1 atual.
                        treeView1.Nodes(0).Nodes(nodeG1.Index).Nodes.Add(nodeG2)

                        'Adiciona no objeto name do node o codigo e um index.
                        nodeG2.Name = dr("ContaGrupo1") & "-" & dr("ContaGrupo2") & "/" & nodeG1.Index & ";" & nodeG2.Index

                        'Atualizamos a variável para indicar qual é o g2 atual.
                        nodeAtual1 = strNodeG1 & ";" & dr("ContaGrupo2")
                    End If
                End If

                'Aqui iniciamos a criação dos "nós" que exibirão os G3.

                strNodeG3 = strNodeG2 & ";" & dr("ContaGrupo3")

                If Not nodeAtual2 = strNodeG3 Then
                    If IsDBNull(dr("DescContaGrupo3")) Then
                    Else
                        nodeG3 = New TreeNode()
                        With nodeG3
                            .ImageIndex = 1
                            .Tag = "G3"
                            .Text = dr("ContaGrupo3") & "-" & dr("DescContaGrupo3") & ""
                        End With

                        'Adicionamos o "nó" do G3 para o g2 atual.
                        treeView1.Nodes(0).Nodes(nodeG1.Index).Nodes(nodeG2.Index).Nodes.Add(nodeG3)

                        'Adiciona no objeto name do node o codigo e um index.
                        nodeG3.Name = dr("ContaGrupo1") & "-" & dr("ContaGrupo2").ToString & "-" & dr("ContaGrupo3") & "/" & nodeG1.Index & ";" & nodeG2.Index & ";" & nodeG3.Index

                        'atualizamos a variável para indicar qual é o g2 atual.
                        nodeAtual2 = strNodeG2 & ";" & dr("ContaGrupo3")
                    End If
                End If
            End While

            'fechamos o objeto OleDbDataReader
            dr.Close()

            'fechamos a conexão com o banco de dados
            con.Close()

            'invocamos o método EndUpdate do controle TreeView para que as atualizações sejam
            'apresentadas ao usuário.
            Me.treeView1.EndUpdate()

            'Expandimos todos os nós da árvore para mostrar.
            Me.treeView1.ExpandAll()

            'restauramos o cursor 
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Catch exConnection As System.Exception
            MessageBox.Show(exConnection.GetBaseException.ToString, "Erro ao Conectar com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPesquisar.Click

        If pGrupo = Nothing Then
            MessageBox.Show("Não foi escolhido nenhuma opção para filtrar", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Me.txtPesquisa.Text = "" Or Me.txtPesquisa.Text = " " Then
            MessageBox.Show("Não foi digitado um texto para filtrar", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        pesquisarTree()

    End Sub

    Private Sub opt1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt1.CheckedChanged, opt2.CheckedChanged, opt3.CheckedChanged
        Select Case DirectCast(sender, RadioButton).Name
            Case "opt1"
                pGrupo = 1
            Case "opt2"
                pGrupo = 2
            Case "opt3"
                pGrupo = 3
        End Select
    End Sub

    Private Sub ExcluirContaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirContaToolStripMenuItem.Click

        If strTag = Nothing Then
            MessageBox.Show("Favor selecionar um nivel para fazer a Exclusão", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim strCCG As String = strNodeG1
        Dim strAr(4) As String
        If IsNothing(strCCG) = False Then
            strAr = strCCG.Split("-")
        End If


        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "SELECT Count(BalanceteLanc.Id) AS ContarDeId, BalanceteLanc.ContaBalancete FROM(BalanceteLanc) GROUP BY BalanceteLanc.ContaBalancete HAVING (((BalanceteLanc.ContaBalancete)='" & strAr(2) & "'));"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            MessageBox.Show("Esta conta contém lançamentos e não pode ser excluída", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        DR.Close()

        Try

            If strAr.Length = 3 Then
                Sql = "SELECT ContasG3.ContaGrupo1, ContasG3.ContaGrupo2, ContasG3.ContaGrupo3, ContasG3.DescContaGrupo3, ContasG3.Protegido FROM(ContasG3) WHERE (((ContasG3.ContaGrupo3)='" & strAr(2) & "'));"
                CMD.CommandText = Sql
                DR = CMD.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    If DR.Item("Protegido") = True Then
                        MessageBox.Show("Esta conta esta protegida pelo sistema não pode ser excluida", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                End If
                DR.Close()
            End If


            'Sql = "SELECT ContasG3.ContaGrupo1, ContasG3.ContaGrupo2, ContasG3.ContaGrupo3, ContasG3.DescContaGrupo3, ContasG3.Protegido FROM(ContasG3) WHERE (((ContasG3.ContaGrupo3)='" & strAr(2) & "'));"

            If strAr.Length = 1 Then
                Sql = "DELETE ContasG1.ContaGrupo1 FROM(ContasG1) WHERE (((ContasG1.ContaGrupo1)='" & strAr(0) & "'));"
            ElseIf strAr.Length = 2 Then
                Sql = "DELETE ContasG2.ContaGrupo2 FROM(ContasG2) WHERE (((ContasG2.ContaGrupo2)='" & strAr(1) & "'));"
            ElseIf strAr.Length = 3 Then
                Sql = "DELETE ContasG3.ContaGrupo3 FROM(ContasG3) WHERE (((ContasG3.ContaGrupo3)='" & strAr(2) & "'));"
            End If
            CMD.CommandText = Sql
            CMD.ExecuteNonQuery()
            MessageBox.Show("Conta excluida com sucesso", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cnn.Close()
            MostrarTreeGrupo()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cnn.Close()
        End Try

    End Sub

    Private Sub BalanceteCadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class