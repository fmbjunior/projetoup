Public Class NfiscalLancaItens

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Dim TipoProduto As Integer = 1
    Dim VlrUnitario As Double = 0

    Private Sub NfiscalLancaItens_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Produto.Focus()
    End Sub

    Private Sub NfiscalLancaItens_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim PosX As Double = My.Forms.NFiscal.Location.X
        'Dim PosY As Double = (My.Forms.NFiscal.Location.Y + My.Forms.NFiscal.Height) - Me.Height
        'Me.Location = New Point(PosX, PosY)
        EncheListaItensImportar()
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Qtd_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Qtd.Enter
        If Me.ProdutoDesc.Text = "" Then
            Me.Produto.Focus()
        End If

        If Me.Qtd.Text = "" Then
            Me.Qtd.Text = FormatNumber(0, 4)
        End If
    End Sub

    Public Sub LocalizaProduto()
        If Me.Produto.Text = "" Then
            Exit Sub
        End If

        Dim CNNItens As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNNItens.Open()
        Dim Sql As String = "Select * from Produtos where CodigoProduto = " & Me.Produto.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNNItens)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows = True Then
            Me.ProdutoDesc.Text = DR.Item("Descrição") & ""
            VlrUnitario = FormatNumber(Nz(DR.Item("ValorVenda"), 3), 2)
            If Me.CST.Text = "" Then Me.CST.Text = DR.Item("Cst") & ""
            If Me.CF.Text = "" Then Me.CF.Text = DR.Item("CF") & ""
        Else
            MsgBox("Item não encontrado, verifique....", 64, "Validação de Dados")
            Me.Produto.Focus()
            Exit Sub
        End If
        DR.Close()
        CNNItens.Close()
    End Sub

    Private Sub Qtd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Qtd.Leave
        If Me.Qtd.Text = "" Or Me.Qtd.Text = 0 Then
            Me.Produto.Focus()
            Exit Sub
        End If

        Me.Qtd.Text = FormatNumber(Me.Qtd.Text, 4)
    End Sub

    Private Sub ValorDesconto_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorDesconto.Enter
        If DescontoEmLinha = True Then
            Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            If Me.ValorDesconto.Text = "" Then Me.ValorDesconto.Text = FormatNumber(0, 2)
        Else
            Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            If Me.ValorDesconto.Text = "" Then Me.ValorDesconto.Text = FormatNumber(0, 2)
        End If
    End Sub

    Private Sub ValorTotal_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorTotal.Enter
        If Me.Qtd.Text = "" Then
            Me.Produto.Focus()
            Exit Sub
        ElseIf Me.Unitario.Text = "" Then
            Me.Qtd.Focus()
            Exit Sub
        ElseIf Me.ValorDesconto.Text = "" Then
            Me.ValorDesconto.Focus()
            Exit Sub
        ElseIf Me.Qtd.Text = 0 Then
            MsgBox("A quantidade não pode ser valores zero ou nulos, verifique.", 64, "Validação de Dados")
            Me.Qtd.Focus()
            Exit Sub
        End If

        Me.ValorTotal.Text = FormatCurrency((CDbl(Me.Unitario.Text) * CDbl(Me.Qtd.Text)) - CDbl(Me.ValorDesconto.Text), 2)
    End Sub

    Private Sub Ipi_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Ipi.Enter
        If Me.Ipi.Text = "" Then Me.Ipi.Text = 0
    End Sub

    Private Sub ValorIpi_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorIpi.Enter
        If Me.Ipi.Text = "" Then Me.Ipi.Text = 0

        If Me.Ipi.Text > 0 Then
            Me.ValorIpi.Text = FormatNumber((CDbl(Me.ValorTotal.Text) * CDbl(Me.Ipi.Text)) / 100, 2)
        Else
            Me.ValorIpi.Text = FormatNumber(0, 2)
        End If
    End Sub

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        'Limpar contoles
        Me.Produto.Clear()
        Me.ProdutoDesc.Text = ""
        Me.Qtd.Clear()
        Me.Unitario.Clear()
        Me.ValorDesconto.Clear()
        Me.ValorTotal.Clear()
        Me.Ipi.Clear()
        Me.ValorIpi.Clear()
        Me.Icms.Clear()
        Me.CST.Clear()
        Me.CF.Clear()
        Me.SeqNf.Clear()

        Me.Produto.Focus()
    End Sub

    Public Sub AchaUltimaSequencia()
        'Inserir ultimo registro
        Dim CNNItens As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNNItens.Open()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer

        With Cmd
            .Connection = CNNItens
            .CommandTimeout = 0
            .CommandText = "Select max(SeqNf) from NotaFiscalItens Where NotaFiscal = " & My.Forms.NFiscal.NotaFiscal.Text
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    'Achou o iten procurado o iten as caixas serão preenchida
                    Ult = DataReader.Item(0)
                End If
            End While
            DataReader.Close()
            CNNItens.Close()
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                CNNItens.Close()
                Exit Sub
            End If
        End Try

        Me.SeqNf.Text = Ult + 1
        'fim inserir ultimo registro
    End Sub

    Private Sub SeqNf_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles SeqNf.Enter
        If Me.Produto.Text = "" Then
            Me.Produto.Focus()
            Exit Sub
        End If

        If Me.SeqNf.Text = "" Then
            AchaUltimaSequencia()
        End If
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click

        If Me.Produto.Text = "" Then
            MsgBox("O usuário deve informar o Produto, verifique.", 64, "Validação de Dados")
            Me.Produto.Focus()
            Exit Sub
        End If

        If Me.Qtd.Text = "" Then
            MsgBox("O usuário deve informar a quantidade do Produto, verifique.", 64, "Validação de Dados")
            Me.Qtd.Focus()
            Exit Sub
        End If

        If Me.Unitario.Text = "" Then
            MsgBox("O usuário deve informar o valor unitário Produto, verifique.", 64, "Validação de Dados")
            Me.Produto.Focus()
            Exit Sub
        End If

        If Me.ValorDesconto.Text = "" Then
            Me.ValorDesconto.Text = FormatNumber(0, 2)
        End If

        If Me.Ipi.Text = "" Then
            Me.Ipi.Text = 0
        End If

        If Me.ValorIpi.Text = "" Then
            Me.ValorIpi.Text = FormatNumber(0, 2)
        End If

        If Me.Icms.Text = "" Then
            Me.Icms.Text = 0
        End If

        If Me.CF.Text = "" Then
            MsgBox("O usuário deve informar a Classificação Fiscal Produto, verifique o cadastro do Produto.", 64, "Validação de Dados")
            Me.Produto.Focus()
            Exit Sub
        End If

        If Me.CST.Text = "" Then
            MsgBox("O usuário deve informar o Código da Situação Tributaria do Produto, verifique o cadastro do Produto.", 64, "Validação de Dados")
            Me.Produto.Focus()
            Exit Sub
        End If

        If Me.SeqNf.Text = "" Then
            MsgBox("O usuário deve informar a sequencia do Iten na Nota Fiscal.", 64, "Validação de Dados")
            Me.Produto.Focus()
            Exit Sub
        End If


        If Operation = INS Then
            Dim CNNItens As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNNItens.Open()

            Dim Sql As String = "INSERT INTO NotaFiscalItens (NotaFiscal, Produto, Descricao, Qtd, Unitario, ValorDesconto, ValorTotal, Icms, ValorIcms, Ipi, ValorIpi, Cst, Cf, SeqNf) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNNItens)

            Dim VlrIcms As Double = (CDbl(NzZero(Me.ValorTotal.Text)) * CDbl(NzZero(Me.Icms.Text))) / 100
            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(My.Forms.NFiscal.NotaFiscal.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Produto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.ProdutoDesc.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Qtd.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Unitario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.ValorDesconto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.ValorTotal.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Icms.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", VlrIcms))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.Ipi.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.ValorIpi.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.CST.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.CF.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.SeqNf.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                CNNItens.Close()
                Operation = INS
                My.Forms.NFiscal.AtualizaListaItens()
                My.Forms.NFiscal.MyLista.Refresh()

                Me.Produto.Clear()
                Me.ProdutoDesc.Text = ""
                Me.Qtd.Clear()
                Me.Unitario.Clear()
                Me.ValorDesconto.Clear()
                Me.ValorTotal.Clear()
                Me.Ipi.Clear()
                Me.ValorIpi.Clear()
                Me.Icms.Clear()
                Me.CST.Clear()
                Me.CF.Clear()
                Me.SeqNf.Clear()
                Me.Produto.Focus()

            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
                Exit Sub
            End Try

        ElseIf Operation = UPD Then
            Dim CNNItens As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNNItens.Open()

            Dim Sql As String = "Update NotaFiscalItens set NotaFiscal = @1 , Produto = @2, Descrição = @3, Qtd = @4, Unitario = @5, ValorDesconto = @6, ValorTotal = @7, Icms = @8, ValorIcms = @9, Ipi = @10, ValorIpi = @11, Cst = @12, Cf = @13, SeqNf = @14 Where NotaFiscal = " & My.Forms.NFiscal.NotaFiscal.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNNItens)

            Dim VlrIcms As Double = (CDbl(Me.ValorTotal.Text) * CDbl(Me.Icms.Text)) / 100
            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(My.Forms.NFiscal.NotaFiscal.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Produto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.ProdutoDesc.Text, 2)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Qtd.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Unitario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.ValorDesconto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.ValorTotal.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Icms.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", VlrIcms))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.Ipi.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.ValorIpi.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.CST.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.CF.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.SeqNf.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                CNNItens.Close()
                Operation = UPD
                My.Forms.NFiscal.AtualizaListaItens()
                My.Forms.NFiscal.MyLista.Refresh()
                Me.Produto.Focus()

            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, False)
        End If


    End Sub

    Private Sub Unitario_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Unitario.Enter
        If Me.Unitario.Text = "" Then Me.Unitario.Text = FormatNumber(VlrUnitario, 2)
    End Sub

    Public Sub EncheListaItensImportar()

        If My.Forms.NFiscal.Pedido.Text = "" Then
            Exit Sub
        End If

        Me.MyLista.Items.Clear()

        Dim CNNItens As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNNItens.Open()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        With Cmd
            .Connection = CNNItens
            .CommandTimeout = 0
            .CommandText = "SELECT Produtos.Descrição, * FROM ItensPedido INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto WHERE ItensPedido.PedidoSequencia = " & My.Forms.NFiscal.Pedido.Text & " Order by ItensPedido.Id"
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            Dim Zebrar As Boolean = False
            While DataReader.Read
                If Not IsDBNull(DataReader.Item("ItensPedido.CodigoProduto")) Then
                    Dim AA As String = DataReader.Item("ItensPedido.CodigoProduto")
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("Descrição") & "")
                    item1.SubItems.Add(FormatNumber(DataReader.Item("Qtd"), 4))
                    item1.SubItems.Add(FormatNumber(DataReader.Item("ValorUnitario"), 2))
                    item1.SubItems.Add(FormatNumber(DataReader.Item("ValorDesconto"), 2))
                    item1.SubItems.Add(FormatNumber(DataReader.Item("TotalProduto"), 2))

                    MyLista.Items.AddRange(New ListViewItem() {item1})

                    If Zebrar = True Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.MistyRose
                        Zebrar = True
                    End If

                End If
            End While

            DataReader.Close()
            CNNItens.Close()
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                CNNItens.Close()
                Exit Sub
            End If
        End Try

    End Sub

    Private Sub Icms_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Icms.Enter
        If Me.Icms.Text = "" Then Me.Icms.Text = "17"
    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        Dim I As Integer = 0

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then Me.Produto.Text = (MyLista.Items(I).Text.Substring(0))
            If MyLista.Items(I).Selected = True Then Me.ProdutoDesc.Text = (MyLista.Items(I).SubItems(1).Text.Substring(0))
            If MyLista.Items(I).Selected = True Then Me.Qtd.Text = FormatNumber((MyLista.Items(I).SubItems(2).Text.Substring(0)), 4)
            If MyLista.Items(I).Selected = True Then Me.Unitario.Text = FormatNumber((MyLista.Items(I).SubItems(3).Text.Substring(0)), 2)
            If MyLista.Items(I).Selected = True Then Me.ValorDesconto.Text = FormatNumber((MyLista.Items(I).SubItems(4).Text.Substring(0)), 2)

            If MyLista.Items(I).Selected = True Then
                MyLista.Items.Item(I).BackColor = Color.Green
            End If
        Next
        Me.Produto.Focus()
    End Sub

    Private Sub Produto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Produto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.Produto.Text = "" Then
                RetornoProcura = ""
                TipoItensProcurar = 1
                My.Forms.ProcuraProduto.ShowDialog()
                If RetornoProcura <> "" Then
                    Me.Produto.Text = RetornoProcura
                End If
            End If
        End If

        If e.KeyCode = Keys.F5 Then
            If Me.Produto.Text = "" Then
                RetornoProcura = ""
                TipoItensProcurar = 1
                My.Forms.ProcuraProduto.ShowDialog()
                If RetornoProcura <> "" Then
                    Me.Produto.Text = RetornoProcura
                End If
            End If
        End If
    End Sub

    Private Sub Produto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Produto.Leave
        If Me.Produto.Text <> "" Then
            LocalizaProduto()
        End If
    End Sub

    Private Sub ImportarTodosOsItensDaListaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportarTodosOsItensDaListaToolStripMenuItem.Click

        Dim IcmsResposta As Double

        Try
            IcmsResposta = InputBox("Favor Informar a Aliquota do Icms para os produtos.", "Validação de Dados", 0)
        Catch err As Exception
            MsgBox(err.Message, 64, "Validação de Dados")
            Exit Sub
        End Try

        'Dim DBEngine As New dao.DBEngine()
        'Dim Banco As dao.Database
        'Dim Reg As dao.Recordset
        'Dim RegTodos As dao.Recordset

        'Banco = DBEngine.OpenDatabase(LocalBD & Nome_BD)
        'Reg = Banco.OpenRecordset("SELECT Produtos.Descrição, Produtos.Cst, Produtos.CF, * FROM ItensPedido INNER JOIN Produtos ON ItensPedido.CodigoProduto = Produtos.CodigoProduto WHERE ItensPedido.PedidoSequencia = " & My.Forms.NFiscal.Pedido.Text)
        'RegTodos = Banco.OpenRecordset("NotaFiscalItens")

        'Dim Contador As Integer = 1
        'While Not Reg.EOF

        '    RegTodos.AddNew()
        '    RegTodos.Fields("NotaFiscal").Value = My.Forms.NFiscal.NotaFiscal.Text
        '    RegTodos.Fields("Produto").Value = Reg.Fields("ItensPedido.CodigoProduto").Value
        '    RegTodos.Fields("Descricao").Value = Reg.Fields("Descrição").Value
        '    RegTodos.Fields("Qtd").Value = Reg.Fields("Qtd").Value
        '    RegTodos.Fields("Unitario").Value = Reg.Fields("ValorUnitario").Value
        '    RegTodos.Fields("ValorDesconto").Value = Reg.Fields("ValorDesconto").Value
        '    RegTodos.Fields("ValorTotal").Value = Reg.Fields("TotalProduto").Value
        '    RegTodos.Fields("Icms").Value = IcmsResposta
        '    RegTodos.Fields("ValorIcms").Value = CDbl(((Reg.Fields("TotalProduto").Value * IcmsResposta) / 100))
        '    RegTodos.Fields("Ipi").Value = Reg.Fields("ItensPedido.Ipi").Value
        '    RegTodos.Fields("ValorIpi").Value = Reg.Fields("ValorIpi").Value
        '    RegTodos.Fields("Cst").Value = Reg.Fields("Cst").Value
        '    RegTodos.Fields("Cf").Value = Reg.Fields("CF").Value
        '    RegTodos.Fields("SeqNf").Value = Contador
        '    RegTodos.Update()

        '    Reg.MoveNext()
        '    Contador += 1
        'End While
        'Reg.Close()
        'RegTodos.Close()
        'Banco.Close()
        My.Forms.NFiscal.AtualizaListaItens()
    End Sub

    Private Sub Unitario_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Unitario.Leave
        Me.Unitario.Text = FormatNumber(Me.Unitario.Text, 2)
    End Sub

    Private Sub ValorDesconto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorDesconto.Leave
        Me.ValorDesconto.Text = FormatNumber(Me.ValorDesconto.Text, 2)
    End Sub

    Private Sub ValorTotal_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorTotal.Leave
        Me.ValorTotal.Text = FormatNumber(Me.ValorTotal.Text, 2)
    End Sub

    Private Sub ValorIpi_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorIpi.Leave
        Me.ValorIpi.Text = FormatNumber(Me.ValorIpi.Text, 2)
    End Sub
End Class