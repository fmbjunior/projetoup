Imports System.Data.OleDb

Public Class CentroCustoNewLocalizar

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
    Private con As OleDbConnection

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

        con = New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

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
        sql = "SELECT Cc1.ContaGrupo1, Cc1.DescContaGrupo1, Cc2.ContaGrupo2, Cc2.DescContaGrupo2, Cc3.ContaGrupo3, Cc3.DescContaGrupo3, Cc1.Empresa FROM (Cc1 LEFT JOIN Cc2 ON Cc1.ContaGrupo1 = Cc2.ContaGrupo1) LEFT JOIN Cc3 ON (Cc2.ContaGrupo2 = Cc3.ContaGrupo2) AND (Cc2.ContaGrupo1 = Cc3.ContaGrupo1) WHERE(((Cc1.Empresa) = " & CodEmpresa & ")) ORDER BY Cc1.ContaGrupo1, Cc2.ContaGrupo2, Cc3.ContaGrupo3;"
        Dim cmd As New OleDbCommand(sql, con)
        'Esta é a variável que armazenará o objeto OleDbDataReader
        Dim dr As OleDbDataReader
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
        Raiz.Text = "Contas Centro Custo"
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
        con = New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        Dim Cmd As New OleDbCommand() 'Cria o  objeto command
        Dim DataReader As OleDbDataReader 'Cria o objeto DataReader 



        With Cmd
            .Connection = con
            .CommandTimeout = 0
            If strTag = "G1" Then
                .CommandText = "SELECT * from Cc1 Where ContaGrupo1 like '" & strNodeG1 & "'"
            Else
                If strTag = "G3" Then
                    .CommandText = "SELECT * from Cc3 Where ContaGrupo3 like '" & Mid(strNodeG1, 11, 6) & "'"
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

                    Else
                        If strTag = "G3" Then


                        End If
                    End If
                End If
            End While

            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
        End Try
    End Sub


    Public Sub pesquisarTree()
        Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        ' Abre a conexao com o banco de dados
        con = New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

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
                    sql = "SELECT Cc1.ContaGrupo1, Cc1.DescContaGrupo1, Cc2.ContaGrupo2, Cc2.DescContaGrupo2, Cc3.ContaGrupo3, Cc3.DescContaGrupo3, Cc3.Empresa FROM (Cc1 INNER JOIN Cc2 ON Cc1.ContaGrupo1 = Cc2.ContaGrupo1) INNER JOIN Cc3 ON (Cc1.ContaGrupo1 = Cc3.ContaGrupo1) AND (Cc2.ContaGrupo2 = Cc3.ContaGrupo2) AND (Cc2.ContaGrupo1 = Cc3.ContaGrupo1) WHERE (((Cc1.DescContaGrupo1) Like '%" & Me.txtPesquisa.Text & "%')) And (((Cc3.Empresa)=" & CodEmpresa & "));"
                Case 2
                    sql = "SELECT Cc1.ContaGrupo1, Cc1.DescContaGrupo1, Cc2.ContaGrupo2, Cc2.DescContaGrupo2, Cc3.ContaGrupo3, Cc3.DescContaGrupo3, Cc3.Empresa FROM (Cc1 INNER JOIN Cc2 ON Cc1.ContaGrupo1 = Cc2.ContaGrupo1) INNER JOIN Cc3 ON (Cc1.ContaGrupo1 = Cc3.ContaGrupo1) AND (Cc2.ContaGrupo2 = Cc3.ContaGrupo2) AND (Cc2.ContaGrupo1 = Cc3.ContaGrupo1) WHERE (((Cc2.DescContaGrupo2) Like '%" & Me.txtPesquisa.Text & "%')) And (((Cc3.Empresa)=" & CodEmpresa & "));"
                Case 3
                    sql = "SELECT Cc1.ContaGrupo1, Cc1.DescContaGrupo1, Cc2.ContaGrupo2, Cc2.DescContaGrupo2, Cc3.ContaGrupo3, Cc3.DescContaGrupo3, Cc3.Empresa FROM (Cc1 INNER JOIN Cc2 ON Cc1.ContaGrupo1 = Cc2.ContaGrupo1) INNER JOIN Cc3 ON (Cc1.ContaGrupo1 = Cc3.ContaGrupo1) AND (Cc2.ContaGrupo2 = Cc3.ContaGrupo2) AND (Cc2.ContaGrupo1 = Cc3.ContaGrupo1) WHERE (((Cc3.DescContaGrupo3) Like '%" & Me.txtPesquisa.Text & "%')) And (((Cc3.Empresa)=" & CodEmpresa & "));"

            End Select

            Dim cmd As New OleDbCommand(sql, con)
            'Esta é a variável que armazenará o objeto OleDbDataReader
            Dim dr As OleDbDataReader
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

    Private Sub treeView1_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles treeView1.NodeMouseClick

        NameNode = e.Node.Name
        strTag = e.Node.Tag

        Select Case e.Node.Tag
            'Case "G1"
            '    NomeStr = Mid(NameNode, 1, NameNode.IndexOf("/"))
            '    NodeDescricao = Mid(e.Node.Text, 6)

            '    strNodeG1 = NomeStr

            'Case "G2"
            '    NomeStr = Mid(NameNode, 1, NameNode.IndexOf("/"))
            '    strNodeG1 = NomeStr
            '    NodeDescricao = Mid(e.Node.Text, 6)
            Case "G3"
                NomeStr = Mid(NameNode, 1, NameNode.IndexOf("/"))
                NomeStr = Mid(NomeStr, 11)
                strNodeG1 = NomeStr
                NodeDescricao = Mid(e.Node.Text, 8)

        End Select

    End Sub

    Private Sub treeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles treeView1.NodeMouseDoubleClick
        NameNode = e.Node.Name
        strTag = e.Node.Tag

        'Verifica se o form produtos está aberto e adiciona o codigo do centro de custos da tabela G7.
        Select Case e.Node.Tag
            Case "G3"
                NomeStr = Mid(NameNode, 1, NameNode.IndexOf("/"))
                NomeStr = Mid(NomeStr, 11)
                strNodeG1 = NomeStr
                NodeDescricao = Mid(e.Node.Text, 8)

                If My.Forms.DocumentoEntrada.Visible = True Then
                    My.Forms.DocumentoEntrada.varPegaConta = strNodeG1
                    Me.Close()
                    Me.Dispose()
                End If

                If My.Forms.Compra.Visible = True Then
                    My.Forms.Compra.varPegaConta = strNodeG1
                    Me.Close()
                    Me.Dispose()
                End If

                If My.Forms.PagarAgrupar.Visible = True Then
                    My.Forms.PagarAgrupar.varPegaConta = strNodeG1
                    Me.Close()
                    Me.Dispose()
                End If

                If My.Forms.PedCompraFinanceiro.Visible = True Then
                    My.Forms.PedCompraFinanceiro.ContaLancamento.Text = strNodeG1
                    Me.Close()
                    Me.Dispose()
                End If

                
                If My.Forms.CaixaLançamentos.Visible = True Then
                    My.Forms.CaixaLançamentos.ContaCC.Text = strNodeG1
                    Me.Close()
                    Me.Dispose()
                End If

                If My.Forms.BancoLançamento.Visible = True Then
                    My.Forms.BancoLançamento.CentroCusto.Text = strNodeG1
                    Me.Close()
                    Me.Dispose()
                End If

                If My.Forms.BalanceteAlterarLancamento.Visible = True Then
                    My.Forms.BalanceteAlterarLancamento.BalanceteAlterar = strNodeG1
                    Me.Close()
                    Me.Dispose()
                End If

                If My.Forms.EmpresaConfiguracao.Visible = True Then
                    Select Case My.Forms.EmpresaConfiguracao.IdContaLanc
                        Case "ContaCCJuros"
                            My.Forms.EmpresaConfiguracao.ContaCCJuros.Text = strNodeG1
                        Case "ContaCCMulta"
                            My.Forms.EmpresaConfiguracao.ContaCCMulta.Text = strNodeG1
                        Case "ContaCCDescConcedido"
                            My.Forms.EmpresaConfiguracao.ContaCCDescConcedido.Text = strNodeG1
                    End Select
                    Me.Close()
                    Me.Dispose()
                End If

                If My.Forms.PagarBaixa.Visible = True Then
                    Select Case My.Forms.PagarBaixa.IdContaLanc
                        Case "ContaCC1"
                            My.Forms.PagarBaixa.Conta1.Text = strNodeG1
                        Case "ContaCC2"
                            My.Forms.PagarBaixa.Conta2.Text = strNodeG1
                        Case "ContaCC3"
                            My.Forms.PagarBaixa.Conta3.Text = strNodeG1
                        Case "ContaCC4"
                            My.Forms.PagarBaixa.Conta4.Text = strNodeG1
                        Case "ContaCC5"
                            My.Forms.PagarBaixa.Conta5.Text = strNodeG1
                        Case "ContaCC6"
                            My.Forms.PagarBaixa.Conta6.Text = strNodeG1
                    End Select
                    Me.Close()
                    Me.Dispose()
                End If



        End Select


        'Fim.

    End Sub

    
End Class