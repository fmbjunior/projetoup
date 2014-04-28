Imports System.Data.OleDb
Public Class TipoFormaPgto
    Public strTag As String
    Public strNodeG1 As String
    Public strNodeG2 As String
    Public strNodeG3 As String
    Public NomeStr As String
    Public indexNode As Integer
    Public NameNode As String
    Public NomeG2 As String
    Public NodeDescricao As String


    Public nodeG1 As TreeNode = New TreeNode
    Public nodeG2 As TreeNode = New TreeNode
    Public nodeG3 As TreeNode = New TreeNode
    Public nodeG4 As TreeNode = New TreeNode
    Public idLinha() As String
    Public mySel As String
   

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AtualizarTree()
    End Sub
    Public Sub AtualizarTree()
        Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor


        ' Abre a conexao com o banco de dados
        Dim Conn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        Conn.Open()

        tw.Nodes.Clear()

        'Invocamos o m�todo BeginUpdate para iniciarmos a atualiza��o do controle TreeView
        'este m�todo permite que todas as modifica��es no controle sejam feitas e somente
        'sejam atualizadas na tela ap�s invocarmos o m�todo EndUpdate.

        tw.BeginUpdate()

        Dim sql As String

        sql = "SELECT AnexarForma.CodigoAnexo, TipoPgto.CodigoTipoPgto, TipoPgto.DescricaoTipoPgto, FormaPgto.CodFormaPgto, FormaPgto.Descri��o FROM (AnexarForma RIGHT JOIN TipoPgto ON AnexarForma.Tp_Codigo = TipoPgto.CodigoTipoPgto) LEFT JOIN FormaPgto ON AnexarForma.Fp_Codigo = FormaPgto.CodFormaPgto;"




        Dim cmd As New OleDb.OleDbCommand(sql, Conn)
        'Esta � a vari�vel que armazenar� o objeto OleDbDataReader
        Dim dr As OleDb.OleDbDataReader
        'Carregaremos o objeto OleDbDataReader com os registros retornados pelo objeto 'OleDbCommand. Para isso ser� necess�rio invocarmos o m�todo ExecuteReader() do 'objeto OleDbCommand.
        dr = cmd.ExecuteReader()

        'Vari�veis utilizadas para cria��o dos "n�s" do TreeView
        Dim nodeG1 As TreeNode = New TreeNode
        Dim nodeG2 As TreeNode = New TreeNode
        Dim nodeG3 As TreeNode = New TreeNode
        Dim nodeG4 As TreeNode = New TreeNode


        '
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


        'TreeView - define o No Ra�z
        Dim Raiz As TreeNode
        Raiz = New TreeNode()
        Raiz.Tag = "Raiz"
        Raiz.Text = "Listagem de Forma e Tipo de Pgto"
        tw.Nodes.Add(Raiz)


        Dim Ind1 As Integer = 0
        Dim Ind2 As Integer = 0
        Dim Ind3 As Integer = 0
        Dim Ind4 As Integer = 0

        'Iniciamos o loop atrav�s dos registros contidos no OleDbDataReader

        While dr.Read()
            strNodeG1 = dr("CodigoTipoPgto")
            'Verificamos se o registro corresponde ao G1 ATUAL.
            If Not nodeAtual = strNodeG1 Then

                nodeG1 = New TreeNode()
                With nodeG1
                    .ImageIndex = 0
                    .Tag = "G1"
                    .Text = Format(dr("CodigoTipoPgto"), "00") & " - " & dr("DescricaoTipoPgto")


                End With

                'Depois de criado o novo "n�" - adicionaremos-o ao controle TreeView
                tw.Nodes(0).Nodes.Add(nodeG1)

                'Adiciona no objeto name do node o codigo e um index.
                nodeG1.Name = dr("CodigoTipoPgto") & "/" & nodeG1.Index & "\" & dr("codigoanexo")


                'Atualizamos a vari�vel com o c�digo do g1 atual
                nodeAtual = dr("CodigoTipoPgto")

            End If

            'Aqui iniciamos a cria��o dos "n�s" que exibir�o os g2 de cada g1.

            strNodeG2 = strNodeG1 & ";" & dr("CodFormaPgto") 'monta um string juntando  o codigo do G1 e o codigo G2.

            If Not nodeAtual1 = strNodeG2 Then 'Verifica se o NodeAtual � igual o node do G2.
                If IsDBNull(dr("Descri��o")) Then
                Else
                    nodeG2 = New TreeNode()
                    With nodeG2
                        .ImageIndex = 1
                        .Tag = "G2"
                        .Text = Format(dr("CodFormaPgto"), "000") & " - " & dr("Descri��o") & ""

                    End With

                    'Adicionamos o "n�" do g2 para o g1 atual.
                    tw.Nodes(0).Nodes(nodeG1.Index).Nodes.Add(nodeG2)

                    'Adiciona no objeto name do node o codigo e um index.
                    nodeG2.Name = dr("CodigoTipoPgto") & "-" & dr("CodFormaPgto") & "/" & nodeG1.Index & ";" & nodeG2.Index & "\" & dr("codigoanexo")

                    'Adicionamos o "n�" do g2 para o g1 atual.
                    nodeAtual1 = strNodeG1 & ";" & dr("CodFormaPgto")
                End If

            End If


        End While


        'fechamos o objeto OleDbDataReader
        dr.Close()

        'fechamos a conex�o com o banco de dados
        Conn.Close()

        'restauramos o cursor 
        Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        'invocamos o m�todo EndUpdate do controle TreeView para que as atualiza��es sejam
        'apresentadas ao usu�rio.
        Me.tw.EndUpdate()

        'Identificar qual node est� selecionado e expandi-lo
        Dim idNode() As String
        Dim A1 As Integer
        Dim A2 As Integer
        If NameNode = Nothing Then
        Else
            If (NameNode.IndexOf("\") <> -1) Then
                NameNode = Mid(NameNode, 1, NameNode.IndexOf("\"))
            End If

            idNode = NameNode.Split("/")
            A1 = idNode(0)
            A2 = idNode(1)
        End If

        Select Case strTag
            Case Nothing
                tw.Nodes(0).Expand()
            Case "G1"
                tw.Nodes(0).Expand()
                tw.Nodes(0).Nodes(A2).Expand()
                tw.SelectedNode = tw.Nodes(0).Nodes(A2)
                Me.tw.Focus()
                'n = tw.Nodes(0).Nodes(A2)
                'n.BackColor = Color.Silver
                'n = tw.SelectedNode

            Case "G2"
                tw.Nodes(0).Expand()
                tw.Nodes(0).Nodes(A2).Expand()
                tw.SelectedNode = tw.Nodes(0).Nodes(A2)
                Me.tw.Focus()
        End Select

    End Sub
    Private Sub tw_NodeMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tw.NodeMouseClick
        strTag = e.Node.Tag


        Select Case e.Node.Tag
            Case "G1"

                NameNode = e.Node.Name

                mySel = Mid(NameNode, NameNode.IndexOf("*") + 2)
                NomeStr = Mid(NameNode, 1, NameNode.IndexOf("/"))
                'NodeDescricao = Mid(e.Node.Text, 2)
                strNodeG1 = NomeStr
                MenuItem1.Enabled = True
                MenuItem2.Enabled = False
                EditarToolStripMenuItem.Enabled = False


            Case "G2"
                NomeG2 = e.Node.Name
                mySel = Mid(NomeG2, NomeG2.IndexOf("\") + 2)
                NomeStr = Mid(NomeG2, 1, NomeG2.IndexOf("/"))
                MenuItem1.Enabled = False
                MenuItem2.Enabled = True
                EditarToolStripMenuItem.Enabled = True
                idLinha = NomeStr.Split("-")


        End Select
    End Sub

    Private Sub AnexarCondi��oPgtoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        TipoFormaPgtoAnexar.ShowDialog()
        AtualizarTree()
    End Sub

    Private Sub bFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If strTag = Nothing Or strTag = "Raiz" Then
            Me.MenuItem1.Enabled = False
            Me.MenuItem2.Enabled = False

        End If
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim Conn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        Conn.Open()

        Dim sql As String = "DELETE * FROM AnexarForma WHERE AnexarForma.Tp_Codigo=" & idLinha(0) & " AND AnexarForma.Fp_Codigo=" & idLinha(1)
        Dim cmd As New OleDbCommand(sql, Conn)
        cmd.ExecuteNonQuery()
        Conn.Close()
        AtualizarTree()
    End Sub

    Private Sub bImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bImprimir.Click
        Dim Conect As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
        Conect.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)

        Conect.SQL = "SELECT TipoPgto.CodigoTipoPgto, TipoPgto.DescricaoTipoPgto, FormaPgto.CodFormaPgto, FormaPgto.Descri��o, AnexarForma.Desconto, AnexarForma.Acrescimo FROM (AnexarForma RIGHT JOIN TipoPgto ON AnexarForma.Tp_Codigo = TipoPgto.CodigoTipoPgto) LEFT JOIN FormaPgto ON AnexarForma.Fp_Codigo = FormaPgto.CodFormaPgto;"


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()
        Dim oDA As New OleDb.OleDbDataAdapter("Select * from empresa", CNN)
        Dim oDs As New DataSet
        oDA.Fill(oDs, "T1")

        Dim rpt As New RelTipoFormaPgto
        rpt.DataSource = Conect
        rpt.T1.Text = oDs.Tables(0).Rows(0).Item("raz�osocial")

        ViewReport.VerRelat.Document = rpt.Document
        rpt.Run()
        ViewReport.ShowDialog()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        My.Forms.TipoFormaPgtoAnexar.Operation = TipoFormaPgtoAnexar.UPD
        TipoFormaPgtoAnexar.ShowDialog()
        AtualizarTree()
    End Sub
End Class
