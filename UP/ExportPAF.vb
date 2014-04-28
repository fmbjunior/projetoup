Imports System.Data
Imports System.Data.OleDb
Imports System.io

Public Class ExportPAF
    Dim vNomeArquivo As String
    Dim vCgcEmpresa
    Sub Empresa()
        Dim conexao As OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim DR As OleDb.OleDbDataReader
        Dim scon As String = New Conectar().ConectarBD(LocalBD & Nome_BD)
        conexao = New OleDbConnection(scon)
        conexao.Open()


        With cmd
            .Connection = conexao
            .CommandTimeout = 0
            .CommandText = "SELECT Cgc From Empresa"
            .CommandType = CommandType.Text
        End With
        Try
            DR = cmd.ExecuteReader

            While DR.Read
                If Not IsDBNull(DR.Item(0)) Then
                    'Achou o iten procurado o iten as caixas serão preenchida
                    vCgcEmpresa = DR.Item(0)
                End If
            End While
            DR.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try
    End Sub
    Sub ExportProduto()
        If Me.txtPath.Text = "" Then
            MessageBox.Show("Local do Arquivo não foi selecionado", "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Me.mybarra.Value = 0
        Me.mybarra.Visible = True

        Dim oPAF As New ExporPAFProduto
        Dim conexao As OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim DR As OleDb.OleDbDataReader

        Dim fluxoTexto As StreamWriter
        Dim linhaTexto As String = ""


        fluxoTexto = New StreamWriter(Me.txtPath.Text, False)
        fluxoTexto.WriteLine("H" & "|" & vCgcEmpresa & "|")



        Dim scon As String = New Conectar().ConectarBD(LocalBD & Nome_BD)
        conexao = New OleDbConnection(scon)
        conexao.Open()


        With cmd
            .Connection = conexao
            .CommandTimeout = 0
            .CommandText = "SELECT Produtos.CodigoProduto, Produtos.Descrição, Produtos.UnidadeMedida, Grupos.Descrição AS GRUPO, SubGrupo.SubGrupoDesc AS SUBGRUPO, Marcas.Marca, Produtos.Icms, IcmsCST.CSTicms, Produtos.ComissaoVenda, Produtos.Referencia, Produtos.ValorVenda, Produtos.ValorCompra, Produtos.EstoqueMinimo, Produtos.QuantidadeEstoque, ProdutoLocal.SetorLocalDesc AS Localizacao, Produtos.CodigoOriginal, Produtos.CodigoFabrica, Produtos.Inativo FROM ((((Grupos INNER JOIN Produtos ON Grupos.CódigoGrupo = Produtos.CódigoGrupo) INNER JOIN Marcas ON Produtos.Marca = Marcas.Codigo) INNER JOIN ProdutoLocal ON Produtos.Localização = ProdutoLocal.SetorLocal) INNER JOIN SubGrupo ON Produtos.SubGrupo = SubGrupo.Codigo) INNER JOIN IcmsCST ON Produtos.Cst = IcmsCST.CSTicms WHERE (((Produtos.Inativo)=False));"
            .CommandType = CommandType.Text
        End With
        Try
            DR = cmd.ExecuteReader
            Dim contar As Integer = 1
            While DR.Read
                If Not IsDBNull(DR.Item(0)) Then
                    Dim SS As String
                    SS = "F01"
                    With oPAF
                        .CodigoBarra = Format(DR.Item("CodigoProduto"), "0000000000000")
                        .DescricaoResumida = DR.Item("Descrição")
                        .DescricaoCompleta = DR.Item("Descrição")
                        .UnidadeMedida = DR.Item("UnidadeMedida") & ""
                        .Unidade = DR.Item("UnidadeMedida") & ""
                        .Grupo = DR.Item("GRUPO") & ""
                        .SubGrupo = DR.Item("SUBGRUPO") & ""
                        .Laboratorio = ""
                        .Marca = DR.Item("Marca") & ""
                        .TipoTributo = "1"
                        .Aliquota = DR.Item("icms")
                        .ST = DR.Item("CSTicms")
                        .QtdPorEmbalagem = "00000000"
                        .Comissao = FormatNumber(DR.Item("ComissaoVenda"), 2)
                        .Fatoracao = "00000"
                        .Aplicacao = DR.Item("Referencia") & ""
                        .PrecoVenda = FormatNumber(DR.Item("ValorVenda"), 2)
                        .PrecoCusto = FormatNumber(DR.Item("ValorCompra"), 2)
                        .EstoqueMinimo = DR.Item("estoqueminimo") & ""
                        .EstoqueAtual = DR.Item("QuantidadeEstoque") & ""
                        .Localizacao = DR.Item("Localizacao") & ""
                        .NumeroOP = DR.Item("CodigoOriginal") & ""
                        .NumeroPeca = DR.Item("CodigoFabrica") & ""
                    End With



                    'Achou o iten procurado o iten as caixas serão preenchida
                    'fluxoTexto.WriteLine(SS & "|" & DR.Item(0) & "|" & (DR.Item(1) & espacos) & "|" & DR.Item(2) & "|" & DR.Item(3) & "|")

                    fluxoTexto.WriteLine(SS & "|" & oPAF.CodigoBarra & "|" & _
                                        (oPAF.DescricaoResumida & Space(100)).Substring(0, 100) & "|" & _
                                        (oPAF.DescricaoCompleta & Space(200)).Substring(0, 200) & "|" & _
                                        (oPAF.UnidadeMedida & Space(50)).Substring(0, 50) & "|" & _
                                        (oPAF.Unidade & Space(3)).Substring(0, 3) & "|" & _
                                        (oPAF.Grupo & Space(100)).Substring(0, 100) & "|" & _
                                        (oPAF.SubGrupo & Space(100)).Substring(0, 100) & "|" & _
                                        (oPAF.Laboratorio & Space(100)).Substring(0, 100) & "|" & _
                                        (oPAF.Marca & Space(100)).Substring(0, 100) & "|" & _
                                        (oPAF.TipoTributo & Space(1)).Substring(0, 1) & "|" & _
                                        (oPAF.Aliquota & Space(5)).Substring(0, 5) & "|" & _
                                        (oPAF.ST & Space(3)).Substring(0, 3) & "|" & _
                                        (oPAF.QtdPorEmbalagem & Space(8)).Substring(0, 8) & "|" & _
                                        (oPAF.Comissao & Space(5)).Substring(0, 5) & "|" & _
                                        (oPAF.Fatoracao & Space(5)).Substring(0, 5) & "|" & _
                                        (oPAF.Aplicacao & Space(100)).Substring(0, 100) & "|" & _
                                        (oPAF.PrecoVenda & Space(11)).Substring(0, 11) & "|" & _
                                        (oPAF.PrecoCusto & Space(11)).Substring(0, 11) & "|" & _
                                        (oPAF.EstoqueMinimo & Space(11)).Substring(0, 11) & "|" & _
                                        (oPAF.EstoqueAtual & Space(11)).Substring(0, 11) & "|" & _
                                        (oPAF.Localizacao & Space(100)).Substring(0, 100) & "|" & _
                                        (oPAF.NumeroOP & Space(20)).Substring(0, 20) & "|" & _
                                        (oPAF.NumeroPeca & Space(20)).Substring(0, 20) & "|")

                    
                End If
                mybarra.PerformStep()
            End While
            DR.Close()
            fluxoTexto.Close()
            MessageBox.Show("Exportação feita com sucesso", "Exportação", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try
    End Sub
    Sub ExportCliente()
        If Me.txtPath.Text = "" Then
            MessageBox.Show("Local do Arquivo não foi selecionado", "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Me.mybarra.Value = 0
        Me.mybarra.Visible = True

        Dim oPAF As New ExporPAFCliente
        Dim conexao As OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim DR As OleDb.OleDbDataReader

        Dim fluxoTexto As StreamWriter
        Dim linhaTexto As String = ""


        fluxoTexto = New StreamWriter(Me.txtPath.Text, False)
        fluxoTexto.WriteLine("H" & "|" & vCgcEmpresa & "|")



        Dim scon As String = New Conectar().ConectarBD(LocalBD & Nome_BD)
        conexao = New OleDbConnection(scon)
        conexao.Open()


        With cmd
            .Connection = conexao
            .CommandTimeout = 0
            .CommandText = "SELECT Clientes.Codigo, Clientes.CpfCgc, Clientes.Nome, Clientes.RG, Clientes.Insc, Clientes.Email, Clientes.Telefone,Clientes.Telefone1, Clientes.Celular, Clientes.LimiteMensal, UF.NomeUF, Municipio.NomeMunic, Clientes.Endereço, Clientes.Nro, Clientes.Bairro, Clientes.xCpl, Clientes.Cep FROM (Clientes INNER JOIN Municipio ON Clientes.cMun = Municipio.CodMunicipio) INNER JOIN UF ON Clientes.cUF = UF.CodigoUF;"
            .CommandType = CommandType.Text
        End With
        Try
            DR = cmd.ExecuteReader
            Dim contar As Integer = 1
            While DR.Read
                If Not IsDBNull(DR.Item(0)) Then
                    Dim SS As String
                    SS = "C01"
                    With oPAF
                        .codigo = Format(DR.Item("Codigo"), "00000")
                        .CPFCGC = DR.Item("cpfcgc")
                        .Nome = DR.Item("nome")
                        .RG = DR.Item("rg") & ""
                        .IE = DR.Item("insc") & ""
                        .IM = ""
                        .Email = DR.Item("email") & ""
                        .TelResidencial = DR.Item("telefone") & ""
                        .TelComercial = DR.Item("telefone1") & ""
                        .TelObs = ""
                        .LimiteCredito = FormatNumber(DR.Item("limitemensal"), 2)
                        .CRM = ""
                        .UF = DR.Item("NOMEUF")
                        .Cidade = DR.Item("NOMEMUNIC")
                        .TipoLogradouro = "RUA"
                        .Logradouro = DR.Item("ENDEREÇO") & ""
                        .Numero = DR.Item("NRO") & ""
                        .TipoBairro = "BAIRRO"
                        .Bairro = DR.Item("BAIRRO") & ""
                        .Complemento = DR.Item("XCPL") & ""
                        .Cep = DR.Item("CEP") & ""
                    End With



                    'Achou o iten procurado o iten as caixas serão preenchida
                    'fluxoTexto.WriteLine(SS & "|" & DR.Item(0) & "|" & (DR.Item(1) & espacos) & "|" & DR.Item(2) & "|" & DR.Item(3) & "|")
                    fluxoTexto.WriteLine(SS & "|" & oPAF.codigo & "|" & _
                                        (oPAF.CPFCGC & Space(14)).Substring(0, 14) & "|" & _
                                        (oPAF.Nome & Space(100)).Substring(0, 100) & "|" & _
                                        (oPAF.RG & Space(20)).Substring(0, 20) & "|" & _
                                        (oPAF.IE & Space(20)).Substring(0, 20) & "|" & _
                                        (oPAF.IM & Space(20)).Substring(0, 20) & "|" & _
                                        (oPAF.Email & Space(100)).Substring(0, 100) & "|" & _
                                        (oPAF.TelResidencial & Space(10)).Substring(0, 10) & "|" & _
                                        (oPAF.TelComercial & Space(10)).Substring(0, 10) & "|" & _
                                        (oPAF.TelCelular & Space(10)).Substring(0, 10) & "|" & _
                                        (oPAF.TelObs & Space(10)).Substring(0, 10) & "|" & _
                                        (oPAF.LimiteCredito & Space(11)).Substring(0, 11) & "|" & _
                                        (oPAF.CRM & Space(20)).Substring(0, 20) & "|" & _
                                        (oPAF.UF & Space(2)).Substring(0, 2) & "|" & _
                                        (oPAF.Cidade & Space(100)).Substring(0, 100) & "|" & _
                                        (oPAF.TipoLogradouro & Space(50)).Substring(0, 50) & "|" & _
                                        (oPAF.Logradouro & Space(100)).Substring(0, 100) & "|" & _
                                        (oPAF.Numero & Space(8)).Substring(0, 8) & "|" & _
                                        (oPAF.TipoBairro & Space(50)).Substring(0, 50) & "|" & _
                                        (oPAF.Bairro & Space(100)).Substring(0, 100) & "|" & _
                                        (oPAF.Complemento & Space(60)).Substring(0, 60) & "|" & _
                                        (oPAF.Cep & Space(8)).Substring(0, 8) & "|")

                    contar += 1
                End If
                mybarra.PerformStep()
            End While
            DR.Close()
            fluxoTexto.Close()
            MessageBox.Show("Exportação feita com sucesso", "Exportação", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try
    End Sub
    Sub ExportPedido()
        If Me.txtPath.Text = "" Then
            MessageBox.Show("Local do Arquivo não foi selecionado", "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Me.mybarra.Value = 0
        Me.mybarra.Visible = True

        Dim oPAF As New ExporPAFPedido 'Cabeçalho do pedido
        Dim oPAFi As New ExportPAFItemVenda 'Item da venda

        Dim conexao As OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim DR As OleDb.OleDbDataReader

        Dim fluxoTexto As StreamWriter
        Dim linhaTexto As String = ""


        fluxoTexto = New StreamWriter(Me.txtPath.Text, False)
        fluxoTexto.WriteLine("H" & "|" & vCgcEmpresa & "|")
                    
        Dim scon As String = New Conectar().ConectarBD(LocalBD & Nome_BD)
        conexao = New OleDbConnection(scon)
        conexao.Open()

        Dim sqlPedido As String = "SELECT Pedido.PedidoSequencia, Pedido.DataPedido, Clientes.CpfCgc AS CPFCLI, Funcionários.Cpf AS CPFVEND, Pedido.ValorProduto, Pedido.TotalPedido, Pedido.VlrDescProduto, Pedido.Confirmado FROM (Clientes INNER JOIN Pedido ON Clientes.Codigo = Pedido.CódigoCliente) INNER JOIN Funcionários ON Pedido.CódigoFuncionário = Funcionários.CódigoFuncionário WHERE (((Pedido.PedidoSequencia)=" & Me.txtNumeroPedido.Text & ") AND ((Pedido.Confirmado)=True));"

        Dim sqlItem As String = "SELECT ItensPedido.PedidoSequencia, ItensPedido.CodigoProduto, ItensPedido.Qtd, ItensPedido.ValorUnitario, ItensPedido.ValorDesconto, ItensPedido.TotalProduto, ItensPedido.Icms  FROM ItensPedido WHERE (((ItensPedido.PedidoSequencia)=" & Me.txtNumeroPedido.Text & "));"

        With cmd
            .Connection = conexao
            .CommandTimeout = 0
            .CommandText = sqlPedido
            .CommandType = CommandType.Text
        End With
        Try
            DR = cmd.ExecuteReader

            While DR.Read
                If Not IsDBNull(DR.Item(0)) Then
                    Dim SS As String
                    SS = "V01"
                    With oPAF
                        .TipoRegistro = "E"
                        .NumeroDocumento = DR.Item("PedidoSequencia") & ""
                        .DataEmissao = DR.Item("DataPedido") & ""
                        .CPFVendedor = DR.Item("cpfvend") & ""
                        .CPFCliente = DR.Item("cpfcli")
                        .TotalVenda = FormatNumber(DR.Item("ValorProduto"), 2)
                        .ValorAcrescimo = "0"
                        .ValorDesconto = FormatNumber(DR.Item("VlrDescProduto"), 2)
                        .TotalPagar = FormatNumber(DR.Item("TotalPedido"), 2)
                        .ValorComissao = "0"
                        .FormaPagamento = "Dinheiro"
                        .TipoPagamento = "01"
                        .DescricaoPagamento = "A vista"
                        .NumeroParcelas = "01"
                        .PagamentoVista = "S"
                    End With



                    'Achou o iten procurado o iten as caixas serão preenchida
                    'fluxoTexto.WriteLine(SS & "|" & DR.Item(0) & "|" & (DR.Item(1) & espacos) & "|" & DR.Item(2) & "|" & DR.Item(3) & "|")
                    fluxoTexto.WriteLine(SS & "|" & oPAF.TipoRegistro & "|" & _
                                        (oPAF.NumeroDocumento & Space(10)).Substring(0, 10) & "|" & _
                                        (oPAF.DataEmissao & Space(8)).Substring(0, 8) & "|" & _
                                        (oPAF.CPFVendedor & Space(14)).Substring(0, 14) & "|" & _
                                        (oPAF.CPFCliente & Space(14)).Substring(0, 14) & "|" & _
                                        (oPAF.TotalVenda & Space(11)).Substring(0, 11) & "|" & _
                                        (oPAF.ValorAcrescimo & Space(11)).Substring(0, 11) & "|" & _
                                        (oPAF.ValorDesconto & Space(11)).Substring(0, 11) & "|" & _
                                        (oPAF.TotalPagar & Space(11)).Substring(0, 11) & "|" & _
                                        (oPAF.ValorComissao & Space(11)).Substring(0, 11) & "|" & _
                                        (oPAF.FormaPagamento & Space(60)).Substring(0, 60) & "|" & _
                                        (oPAF.TipoPagamento & Space(2)).Substring(0, 2) & "|" & _
                                        (oPAF.DescricaoPagamento & Space(100)).Substring(0, 100) & "|" & _
                                        (oPAF.NumeroParcelas & Space(2)).Substring(0, 2) & "|" & _
                                        (oPAF.PagamentoVista & Space(1)).Substring(0, 1) & "|")
                End If
                mybarra.PerformStep()
            End While
            DR.Close()

            'Adicionar Item no Arquivo
            cmd.CommandText = sqlitem
            DR = cmd.ExecuteReader
            Dim contar As Integer = 1
            While DR.Read
                If Not IsDBNull(DR.Item(0)) Then
                    Dim SS As String
                    SS = "V02"
                    With oPAFi
                        .SequencialItem = contar
                        .CodigoBarra = DR.Item("codigoproduto") & ""
                        .Quantidade = FormatNumber(DR.Item("qtd"), 2)
                        .ValorUnitario = FormatNumber(DR.Item("valorunitario"), 2)
                        .ValorDesconto = FormatNumber(DR.Item("valordesconto"), 2)
                        .ValorAcrescimo = "0"
                        .TotalPagar = FormatNumber(DR.Item("TotalProduto"), 2)
                        .TipoTributo = "01"
                        .ValorAliquota = FormatNumber(DR.Item("icms"), 2)
                        .ValorLiquido = FormatNumber(DR.Item("TotalProduto"), 2)
                    End With



                    'Achou o iten procurado o iten as caixas serão preenchida
                    'fluxoTexto.WriteLine(SS & "|" & DR.Item(0) & "|" & (DR.Item(1) & espacos) & "|" & DR.Item(2) & "|" & DR.Item(3) & "|")
                    fluxoTexto.WriteLine(SS & "|" & oPAFi.SequencialItem & "|" & _
                                        (oPAFi.CodigoBarra & Space(13)).Substring(0, 13) & "|" & _
                                        (oPAFi.Quantidade & Space(10)).Substring(0, 10) & "|" & _
                                        (oPAFi.ValorUnitario & Space(11)).Substring(0, 11) & "|" & _
                                        (oPAFi.ValorDesconto & Space(11)).Substring(0, 11) & "|" & _
                                        (oPAFi.ValorAcrescimo & Space(11)).Substring(0, 11) & "|" & _
                                        (oPAFi.TotalPagar & Space(11)).Substring(0, 11) & "|" & _
                                        (oPAFi.TipoTributo & Space(2)).Substring(0, 2) & "|" & _
                                        (oPAFi.ValorAliquota & Space(5)).Substring(0, 5) & "|" & _
                                        (oPAFi.ValorLiquido & Space(11)).Substring(0, 11) & "|")
                    contar += 1
                End If
                mybarra.PerformStep()
            End While




            fluxoTexto.Close()
            MessageBox.Show("Exportação feita com sucesso", "Exportação", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        If Me.opt1.Checked = True Then
            ExportCliente()
        ElseIf Me.opt2.Checked = True Then
            ExportProduto()
        ElseIf Me.opt3.Checked = True Then
            ExportPedido()
        End If
    End Sub


    Private Sub btnFindFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindFolder.Click
        Dim OpenFolder As New FolderBrowserDialog

        OpenFolder.ShowDialog()

        If OpenFolder.SelectedPath <> "" Then
            Me.txtPath.Text = OpenFolder.SelectedPath & "\"
        End If

        If Me.opt1.Checked = True Then
            Me.txtPath.Text = Me.txtPath.Text & "ClientePAF.txt"
        ElseIf Me.opt2.Checked = True Then
            Me.txtPath.Text = Me.txtPath.Text & "ProdutoPAF.txt"
        ElseIf Me.opt3.Checked = True Then
            Me.txtPath.Text = Me.txtPath.Text & "PedidoPAF.txt"
        End If
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub opt1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt1.CheckedChanged
        If Me.opt1.Checked = True Then
            Me.txtPath.Text = ""
            Me.Panel1.Visible = False
        End If
    End Sub

    Private Sub opt2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt2.CheckedChanged
        If Me.opt2.Checked = True Then
            Me.txtPath.Text = ""
            Me.Panel1.Visible = False
        End If
    End Sub

    Private Sub opt3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt3.CheckedChanged
        If Me.opt3.Checked = True Then
            Me.txtPath.Text = ""
            Me.Panel1.Visible = True
        End If
    End Sub

    Private Sub ExportPAF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Empresa()
    End Sub
End Class