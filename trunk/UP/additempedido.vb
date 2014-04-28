Imports System.Data.OleDb
Imports System.IO.Ports
Public Class AddItemPedido
    Dim Ação As New TrfGerais
    Dim xx As New PedidoVenda


    Public ConversorPc As Double = 0
    Dim TipoProduto As Integer = 1
    Dim EstaNosItens As Boolean = False
    Dim JaFoiGeradoReceber As Boolean = False
    Dim PedidoEmAndamento As Boolean = False

    Dim DescontoMaximo As Double = 0
    Dim TipoVenda As String = ""
    Dim EstoqueEstaNegativo As Boolean

    Dim QtdEstoqueTela As Double
    Dim QtdEstoqueEdição As Double

    Dim CrtlEstIten As String = "N"
    Dim QtdEstoqueTemp As Double

    Public PVendedorEstaCheia As Boolean = False

    Public SomaTotalProdutos As Double
    Public SomaDesconto As Double
    Public SomaIpi As Double
    Public SomaDosParcelamentos As Double = 0

    Private Operation As Byte
    Public OperationItens As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2
    Public Sub LimparItens()


        If DescontoEmLinha = True Then
            Me.Desconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Else
            Me.Desconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        End If

    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click

        Me.Close()
    End Sub

    Private Sub CodigoProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodigoProduto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.CodigoProduto.Text = "" Then
                RetornoProcura = ""
                TipoItensProcurar = 1
                My.Forms.ProcurarProdutoDetalhado.ShowDialog()
                If RetornoProcura <> "" Then
                    Me.CodigoProduto.Text = RetornoProcura
                    LocalizaProduto()
                End If
            End If
        End If


        If e.KeyCode = Keys.F2 Then

            Dim Banco As DAO.Database
            Dim BancoFilizola As DAO.Database
            Dim Reg As DAO.Recordset
            Dim RegFilizola As DAO.Recordset
            Dim DBEngine As New DAO.DBEngine()

            Banco = DBEngine.OpenDatabase(LocalBD & Nome_BD)
            BancoFilizola = DBEngine.OpenDatabase("G:\CtrlFilizola.mdb")

            Reg = Banco.OpenRecordset("ItensPedido")
            RegFilizola = BancoFilizola.OpenRecordset("Select * from Filizola where CodigoPedido = " & My.Forms.PedidoVenda.PedidoSequencia.Text)

            If RegFilizola.EOF = True Then
                MsgBox("Pedido não contem itens a ser importado. Verifique.", 64, TituloMsgbox)
                Reg.Close()
                RegFilizola.Close()
                BancoFilizola.Close()
                Banco.Close()
                Exit Sub
            End If

            While Not RegFilizola.EOF
                Reg.AddNew()
                Reg.Fields("CodigoProduto").Value = RegFilizola.Fields("CodProd")
                Reg.Fields("Qtd").Value = RegFilizola.Fields("PLiquido")
                Reg.Fields("QtdPc").Value = 0
                Reg.Fields("ValorUnitario").Value = 0
                Reg.Fields("Desconto").Value = 0
                Reg.Fields("TotalProduto").Value = 0
                Reg.Fields("Ipi").Value = 0
                Reg.Fields("ValorIpi").Value = 0
                Reg.Fields("PedidoSequencia").Value = My.Forms.PedidoVenda.PedidoSequencia.Text
                Reg.Fields("PedidoInterno").Value = My.Forms.PedidoVenda.PedidoInterno
                Reg.Update()
                RegFilizola.MoveNext()
            End While

            Reg.Close()
            RegFilizola.Close()
            BancoFilizola.Close()
            Banco.Close()
            My.Forms.PedidoVenda.EncheListaItens()
            MsgBox("Itens importados.", 64, TituloMsgbox)

        End If
    End Sub

    Private Sub CodigoProduto_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CodigoProduto.Validated

        If Me.CodigoProduto.Text <> "" Then
            LocalizaProduto()
        End If
    End Sub
    Public Sub LocalizaProduto()
        If Me.ValorUnitario.Text = "" Then Me.ValorUnitario.Text = FormatNumber(0, 2)
        If Me.CodigoProduto.Text = "" Then
            Exit Sub
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Produtos where CodigoProduto = " & Me.CodigoProduto.Text & " And Inativo = False and Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows = True Then
            Me.ProdutoDesc.Text = DR.Item("Descrição") & ""
            Me.Ipi.Text = DR.Item("ipi") & ""
            Me.AliqIcms.Text = DR.Item("Icms") & ""
            Me.ValorUnitario.Text = NzZero(DR.Item("ValorVenda"))

            CrtlEstIten = DR.Item("ControlaEstoque") & ""

            If Me.ValorUnitario.Text = 0 Then Me.ValorUnitario.Text = FormatNumber(Nz(DR.Item("ValorVenda"), 3), 2)
            ConversorPc = Nz(DR.Item("ConversorPc"), 3)
            DescontoMaximo = Nz(DR.Item("DescontoMaximo"), 3)

            If DR.Item("QuantidadeEstoque") <= 0 Then
                EstoqueEstaNegativo = True
                QtdEstoqueTemp = DR.Item("QuantidadeEstoque")
            Else
                EstoqueEstaNegativo = False
                QtdEstoqueTemp = DR.Item("QuantidadeEstoque")
            End If


            Select Case DR.Item("TipoVenda")
                Case "V"
                    Me.cfop.Text = 5101
                Case "R"
                    Me.cfop.Text = 5403
            End Select


        Else
            MsgBox("Item não encontrado, verifique....", 64, TituloMsgbox)
            Me.CodigoProduto.Focus()
            CNN.Close()
            Exit Sub
        End If
        CNN.Close()
        'DR.Close()

    End Sub

    Private Sub AddItemPedido_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.OperationItens = UPD Then
            Dim PosX As Double = My.Forms.PedidoVenda.Location.X
            Dim PosY As Double = (My.Forms.PedidoVenda.Location.Y + 320) - Me.Height

            Me.Location = New Point(PosX, PosY)

            Grupo_Preencher(Grupo)

        Else
            Ação.Limpa_Controle(Me, Me.CodigoProduto)


            Dim PosX As Double = My.Forms.PedidoVenda.Location.X
            Dim PosY As Double = (My.Forms.PedidoVenda.Location.Y + 320) - Me.Height

            Me.Location = New Point(PosX, PosY)

            Grupo_Preencher(Me.Grupo)

            Me.CodigoProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.ProdutoDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.Qtd.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.QtdPc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.ValorUnitario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não

            Me.Desconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            If DescontoEmLinha = True Then
                Me.Desconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
                Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Else
                Me.Desconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
                Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            End If

            Me.TotalProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.Ipi.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.ValorIpi.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            Me.Grupo.Enabled = True
            Me.CodigoProduto.Focus()
        End If
    End Sub
    Private Sub AdItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdItem.Click

        'Area destinada para as validacoes

        If Me.cfop.Text = String.Empty Or Me.cfop.Text = "" Then
            MsgBox("O CFOP não foi informado, favor verificar.", 64, TituloMsgbox)
            Me.cfop.Focus()
            Exit Sub
        End If

        If Me.CodigoProduto.Text = "" Then
            MsgBox("O Produto não foi informado, favor verificar.", 64, TituloMsgbox)
            Me.CodigoProduto.Focus()
            Exit Sub
        ElseIf Me.Qtd.Text = "" Then
            MsgBox("A Quantidade não foi informado, favor verificar.", 64, TituloMsgbox)
            Me.Qtd.Focus()
            Exit Sub
        ElseIf Me.QtdPc.Text = "" Then
            MsgBox("O Campo QtdPc não pode ser sequência nula, favor verificar.", 64, TituloMsgbox)
            Me.QtdPc.Focus()
            Exit Sub
        ElseIf Me.ValorUnitario.Text = "" Then
            MsgBox("O Valor Unitário não foi informado, favor verificar.", 64, TituloMsgbox)
            Me.ValorUnitario.Focus()
            Exit Sub
        ElseIf Me.TotalProduto.Text = "" Then
            MsgBox("O total do produto não foi informado, favor verificar.", 64, TituloMsgbox)
            Me.TotalProduto.Focus()
            Exit Sub
        ElseIf Me.Desconto.Text = "" Then
            Me.Desconto.Text = 0
            Exit Sub
        ElseIf Me.ValorDesconto.Text = "" Then
            Me.ValorDesconto.Text = FormatCurrency(0, CsDecimais)
            Exit Sub
        ElseIf Me.Ipi.Text = "" Then
            Me.Ipi.Text = "0"
        ElseIf Me.ValorIpi.Text = "" Then
            Me.ValorIpi.Text = FormatCurrency(0, CsDecimais)

        End If
        'Fim da Area destinada para as validacoes

        'Validação de saida de Estoque
        Dim est As Double = FormatNumber(CDbl(QtdEstoqueTemp), 4)
        Dim ven As Double = FormatNumber(CDbl(Me.Qtd.Text), 4)
        If CrtlEstIten = "S" Then
            If ven > est Then
                MsgBox("Estoque Atual   : " & FormatNumber(CDbl(Me.QtdEstoqueTemp), 4) & Chr(13) & "Sendo Vendido : " & FormatNumber(CDbl(Me.Qtd.Text), 4) & Chr(13) & Chr(13) & Chr(13) & Chr(13) & "O Usuário não pode verder estoque negativo deste produto.", 64, TituloMsgbox)
                Me.CodigoProduto.Focus()
                Exit Sub
            End If
        End If
        'Finaliza Aqui

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If OperationItens = INS Then
            CNN.Open()
            Dim Sql As String = "INSERT INTO ItensPedido ( CodigoProduto, Qtd, QtdPc, ValorUnitario, Desconto,ValorDesconto, TotalProduto, Ipi, ValorIpi, Grupo, PedidoSequencia, PedidoInterno,icms,VlrBCicms,VlrIcms,cfop) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12,@13,@14,@15,@16)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CodigoProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Qtd.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.QtdPc.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ValorUnitario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Desconto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.ValorDesconto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.TotalProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Ipi.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.ValorIpi.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", NzVlr(PegaVlrCombo(Me.Grupo, TpRetornoCBO.Não))))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", NzVlr(My.Forms.PedidoVenda.PedidoSequencia.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", NzVlr(My.Forms.PedidoVenda.PedidoInterno)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", NzVlr(Me.AliqIcms.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", NzVlr(Me.BcIcms.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", NzVlr(Me.ValorIcms.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", NzVlr(Me.cfop.Text)))

            Try
                cmd.ExecuteNonQuery()
                CriaLog(UserAtivo, "Pedido", "Add Item Pedido: " & PedidoVenda.PedidoSequencia.Text & "Produto : " & Me.CodigoProduto.Text & " Pedido " & PedidoVenda.PedidoSequencia.Text)

                OperationItens = INS
                CNN.Close()
                Me.CodigoProduto.Focus()
                Ação.Limpa_Controle(Me, Me.CodigoProduto)
                My.Forms.PedidoVenda.EncheListaItens()
                LimparItens()
            Catch ex As Exception
                MsgBox(ex.Message, 64, TituloMsgbox)
                CNN.Close()
            End Try

        ElseIf OperationItens = UPD Then
            CNN.Open()
            Dim Sql As String = "Update ItensPedido set CodigoProduto = @1, Qtd = @2, QtdPc = @3, ValorUnitario = @4, Desconto = @5, ValorDesconto = @6, TotalProduto = @7, Ipi = @8, ValorIpi = @9, Grupo = @10, PedidoSequencia = @11, PedidoInterno = @12, icms = @13, VlrBCicms = @14, VlrIcms = @15 , cfop = @16 Where Id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CodigoProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Qtd.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.QtdPc.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ValorUnitario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Desconto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.ValorDesconto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.TotalProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Ipi.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.ValorIpi.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", NzVlr(PegaVlrCombo(Me.Grupo, TpRetornoCBO.Não))))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", NzVlr(My.Forms.PedidoVenda.PedidoSequencia.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", NzVlr(My.Forms.PedidoVenda.PedidoInterno)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", NzVlr(Me.AliqIcms.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", NzVlr(Me.BcIcms.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@15", NzVlr(Me.ValorIcms.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@16", NzVlr(Me.cfop.Text)))

            Try
                cmd.ExecuteNonQuery()
                OperationItens = INS
                CNN.Close()
                My.Forms.PedidoVenda.EncheListaItens()
                Me.CodigoProduto.Focus()
                Ação.Limpa_Controle(Me, Me.CodigoProduto)
                LimparItens()
            Catch x As Exception
                CNN.Close()
                MsgBox(x.Message)
                Exit Sub
            End Try
        End If

        Ação.Limpa_Controle(Me, Me.CodigoProduto)
        Me.Grupo.Text = ""
        Me.ValorUnitario.Text = "0,00"
        Me.CodigoProduto.Focus()
    End Sub

    Private Sub TotalProduto_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TotalProduto.Enter
        If Me.Qtd.Text = "" Then Me.Qtd.Focus()
        If Me.ValorUnitario.Text = "" Then Me.ValorUnitario.Focus()
        If Me.Desconto.Text = "" Then Me.Desconto.Text = FormatNumber(0, 3)
        Me.ValorDesconto.Text = FormatCurrency((CDbl(Me.ValorUnitario.Text) * CDbl(Me.Qtd.Text)) * CDbl(Me.Desconto.Text) / 100, CsDecimais)

        Me.TotalProduto.Text = FormatNumber((CDbl(Me.ValorUnitario.Text) * CDbl(Me.Qtd.Text)) - CDbl(Me.ValorDesconto.Text), 3)
        Me.BcIcms.Text = TotalProduto.Text
        Me.ValorIcms.Text = FormatCurrency(CDbl(Me.BcIcms.Text) * CDbl(Me.AliqIcms.Text) / 100)
        Me.ValorIpi.Text = FormatCurrency(CDbl(Me.Ipi.Text) * CDbl(Me.TotalProduto.Text) / 100)
    End Sub

    Private Sub ValorUnitario_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorUnitario.Enter
        If F6 = False Then
            Me.ValorUnitario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Else
            Me.ValorUnitario.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        End If
    End Sub

    Private Sub ValorUnitario_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorUnitario.Leave
        'Me.ValorDesconto.Text = FormatCurrency((CDbl(Me.ValorUnitario.Text) * CDbl(Me.Qtd.Text)) * CDbl(Me.Desconto.Text) / 100, CsDecimais)

        'Me.TotalProduto.Text = FormatCurrency((CDbl(Me.ValorUnitario.Text) * CDbl(Me.Qtd.Text)) - CDbl(Me.ValorDesconto.Text), CsDecimais)

    End Sub
#Region "Ação para as combos"
    Private Enum TpRetornoCBO
        Não = 0
        Sim = 1
    End Enum

    Private Function PegaVlrCombo(ByVal Cbo As CBOAutoCompleteFocus.CboFocus, ByVal Retorna_Descrição As TpRetornoCBO)

        Dim Retorno As String = ""
        If Cbo.Text = "" Then
            Retorno = ""

        Else
            Cbo.SelectedIndex = Cbo.FindStringExact(Cbo.Text & "")
            If Retorna_Descrição = TpRetornoCBO.Não Then
                Retorno = CType(Cbo.SelectedItem, cboItemData).ItemData
            Else
                Retorno = CType(Cbo.SelectedItem, cboItemData).Name
            End If
        End If
        Return Retorno




    End Function
    Public Sub Grupo_Preencher(ByVal Controle As CBOAutoCompleteFocus.CboFocus)

        Controle.Items.Clear()

        Dim Cnn As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        Cnn.Open()

        Dim Sql As String = "SELECT * FROM Grupos where Empresa = " & CodEmpresa & " order by Descrição"
        Dim Cmd As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        Try
            DR = Cmd.ExecuteReader
            While DR.Read
                Controle.Items.Add(New cboItemData(DR.Item("CódigoGrupo"), DR.Item("Descrição")))
            End While
            DR.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()

    End Sub
#End Region
    Private Sub QtdPc_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles QtdPc.Enter
        If Me.QtdPc.Text = "" Then
            Me.QtdPc.Text = 0
        End If
    End Sub

    Private Sub Qtd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Qtd.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            My.Forms.PedidoConversãoIten.ShowDialog()
        End If
    End Sub

    Private Sub Qtd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Qtd.Leave
        If Me.Qtd.Text = "" Or Me.Qtd.Text = 0 Then Me.CodigoProduto.Focus()

        If ConversorPc = 0.0 Then
            ConversorPc = 1
            Me.QtdPc.Text = FormatNumber(Me.Qtd.Text / ConversorPc, CsDecimais)
        Else
            Me.QtdPc.Text = FormatNumber(Me.Qtd.Text / ConversorPc, 2)
        End If

        If QtdEstoqueTela < Me.Qtd.Text Then
            QtdEstoqueEdição = CDbl(Me.Qtd.Text) - CDbl(QtdEstoqueTela)
        ElseIf QtdEstoqueTela > Me.Qtd.Text Then
            QtdEstoqueEdição = CDbl(Me.Qtd.Text) - CDbl(QtdEstoqueTela)
        ElseIf QtdEstoqueTela = Me.Qtd.Text Then
            QtdEstoqueEdição = 0
        End If

    End Sub

    Private Sub Desconto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Desconto.KeyDown
        If e.KeyCode = Keys.Insert Then
            My.Forms.PedidoVendaSenhaItem.ShowDialog()
        End If
    End Sub

    Private Sub Desconto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Desconto.Leave
        If Me.Desconto.Text = "" Then Me.Desconto.Text = FormatNumber(0, 3)
        Me.ValorDesconto.Text = FormatCurrency((CDbl(Me.ValorUnitario.Text) * CDbl(Me.Qtd.Text)) * FormatNumber(CDbl(Me.Desconto.Text), CsDecimais) / 100, CsDecimais)

        If Me.Desconto.Text > DescontoMaximo Then
            If Me.UserSenhaDesconto.Text = "" Then
                MsgBox("O desconto maximo permitido para este produto foi excedido. Verifique.", 64, TituloMsgbox)
                Me.Desconto.Text = 0
                Me.Desconto.Focus()
            End If
        End If
    End Sub

    Private Sub CodigoProduto_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CodigoProduto.Validating
        If Me.CodigoProduto.Text <> "" Then
            LocalizaProduto()
        End If
        If EstaNosItens = True Then Me.Qtd.Focus()
    End Sub

    Private Sub ValorUnitario_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorUnitario.Validated
        If Me.ValorUnitario.Text = "" Then
            Me.ValorUnitario.Text = FormatCurrency(0, CsDecimais)
        Else
            Me.ValorUnitario.Text = FormatCurrency(Me.ValorUnitario.Text, CsDecimais)
        End If
    End Sub

    Private Sub ValorDesconto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorDesconto.Leave
        Me.Desconto.Text = CDbl(Me.ValorDesconto.Text) / (CDbl(Me.ValorUnitario.Text) * CDbl(Me.Qtd.Text)) * 100
        Me.ValorDesconto.Text = FormatCurrency(Me.ValorDesconto.Text, 2)

        If Me.Desconto.Text > DescontoMaximo Then
            If Me.UserSenhaDesconto.Text = "" Then
                MsgBox("O desconto maximo permitido para este produto foi excedido. Verifique.", 64, TituloMsgbox)
                Me.Desconto.Text = 0
                Me.Desconto.Focus()
            End If
        End If
    End Sub

    Private Sub AddItemPedido_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        Dim PosX As Double = My.Forms.PedidoVenda.Location.X
        Dim PosY As Double = (My.Forms.PedidoVenda.Location.Y + 320) - Me.Height

        Me.Location = New Point(PosX, PosY)

    End Sub

    Private Sub CodigoProduto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoProduto.TextChanged

    End Sub

    Private Sub cfop_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cfop.TextChanged

    End Sub
End Class