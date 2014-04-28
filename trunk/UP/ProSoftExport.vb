Public Class ProSoftExport

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btEscolherPasta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEscolherPasta.Click

        Dim fbd1 As New FolderBrowserDialog
        Dim myLocal As String = String.Empty


        fbd1.Description = "Selecione uma pasta para Salvar"
        fbd1.RootFolder = Environment.SpecialFolder.MyComputer
        fbd1.ShowNewFolderButton = True


        If fbd1.ShowDialog = Windows.Forms.DialogResult.OK Then
            myLocal = fbd1.SelectedPath
        End If
        Me.Local.Text = myLocal
        Me.Local.Focus()
    End Sub

    Private Sub EmpProSoft_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpProSoft.Leave
        Dim EmpresaProsoft As String = Me.EmpProSoft.Text
        Me.EmpProSoft.Text = EmpresaProsoft.PadLeft(3, "0")
    End Sub

    Private Sub btGerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGerar.Click
        If Me.A1.Checked = True Then
            If Me.Local.Text = "" Then
                MsgBox("Favor informar o drive e local a ser gravado o arquivo.", 64, "Exportação")
                Me.Local.Focus()


                Exit Sub
            ElseIf Me.EmpUP.Text = "" Then
                MsgBox("Favor informar o Código da empresa no FOCUS.", 64, "Exportação")
                Me.EmpUP.Focus()
                Exit Sub
            ElseIf Me.EmpProSoft.Text = "" Then
                MsgBox("Favor informar o Código da empresa no ProSoft.", 64, "Exportação")
                Me.EmpProSoft.Focus()
                Exit Sub
            End If
            ExTerceiros()
        End If

        If Me.A2.Checked = True Then
            If Me.Local.Text = "" Then
                MsgBox("Favor informar o drive e local a ser gravado o arquivo.", 64, "Exportação")
                Me.Local.Focus()
                Exit Sub
            ElseIf Me.EmpUP.Text = "" Then
                MsgBox("Favor informar o Código da empresa no FOCUS.", 64, "Exportação")
                Me.EmpUP.Focus()
                Exit Sub
            ElseIf Me.EmpProSoft.Text = "" Then
                MsgBox("Favor informar o Código da empresa no ProSoft.", 64, "Exportação")
                Me.EmpProSoft.Focus()
                Exit Sub
            End If
            ExProdutos()
        End If

        If Me.A3.Checked = True Then
            If Me.Local.Text = "" Then
                MsgBox("Favor informar o drive e local a ser gravado o arquivo.", 64, "Exportação")
                Me.Local.Focus()
                Exit Sub
            ElseIf Me.EmpUP.Text = "" Then
                MsgBox("Favor informar o Código da empresa no FOCUS.", 64, "Exportação")
                Me.EmpUP.Focus()
                Exit Sub
            ElseIf Me.EmpProSoft.Text = "" Then
                MsgBox("Favor informar o Código da empresa no ProSoft.", 64, "Exportação")
                Me.EmpProSoft.Focus()
                Exit Sub
            ElseIf Me.DataInicial.Text = "" Then
                MsgBox("Favor informar a data inicial.", 64, "Exportação")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("Favor informar a Data Final.", 64, "Exportação")
                Me.DataFinal.Focus()
                Exit Sub
            End If
            ExportaEntradas()
        End If

        If Me.A4.Checked = True Then
            If Me.Local.Text = "" Then
                MsgBox("Favor informar o drive e local a ser gravado o arquivo.", 64, "Exportação")
                Me.Local.Focus()
                Exit Sub
            ElseIf Me.EmpUP.Text = "" Then
                MsgBox("Favor informar o Código da empresa no FOCUS.", 64, "Exportação")
                Me.EmpUP.Focus()
                Exit Sub
            ElseIf Me.EmpProSoft.Text = "" Then
                MsgBox("Favor informar o Código da empresa no ProSoft.", 64, "Exportação")
                Me.EmpProSoft.Focus()
                Exit Sub
            ElseIf Me.DataInicial.Text = "" Then
                MsgBox("Favor informar a data inicial.", 64, "Exportação")
                Me.DataInicial.Focus()
                Exit Sub
            ElseIf Me.DataFinal.Text = "" Then
                MsgBox("Favor informar a Data Final.", 64, "Exportação")
                Me.DataFinal.Focus()
                Exit Sub
            ElseIf Me.AnoInventario.Text = "" Then
                MsgBox("Favor informar o Ano.", 64, "Exportação")
                Me.AnoInventario.Focus()
                Exit Sub
            End If
            ExportaInventario()
        End If

    End Sub

    Public Sub ExportaInventario()


        If String.IsNullOrEmpty(Me.DataInicial.Text) Or String.IsNullOrEmpty(Me.DataFinal.Text) Then
            MsgBox("Atenção! Datas incorretas, digite corretamente a data inicial e data final para gerar o relatório", 48, "Validação de dados")
            DataInicial.Focus()
            Return
        End If

        'conexao com db gestor
        Dim conn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        conn.Open()

        'conexao com db nfe
        Dim conNFe As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & LocalDBNFe & "NFe" & Me.AnoInventario.Text & ".mdb")

        Try
            conNFe.Open()
        Catch ex As Exception
            If Err.Number = 5 Then
                MessageBox.Show("Banco de Dados da NFe não encontrado, Favor Verificar.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try


        Dim cmdInventario As OleDb.OleDbCommand
        Dim DR As OleDb.OleDbDataReader
        Dim DRnfe As OleDb.OleDbDataReader
        Dim oDA As OleDb.OleDbDataAdapter
        Dim DS As New DataSet
        Try
            Me.Cursor = Cursors.WaitCursor

            oDA = New OleDb.OleDbDataAdapter("Select * from iventario", conn)
            oDA.Fill(DS, "Iventario")

            'gerar os dados para a tabela iventario entra.
            cmdInventario = New OleDb.OleDbCommand("SELECT Compra.Tipo, Produtos.CodigoNFE, Sum(ItensCompra.Qtd) AS SomaDeQtd, Produtos.CodigoProduto FROM (Compra INNER JOIN ItensCompra ON Compra.CompraInterno = ItensCompra.CompraInterno) INNER JOIN Produtos ON ItensCompra.CodigoProduto = Produtos.CodigoProduto WHERE (((Compra.DataLançamento) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#)) GROUP BY Compra.Tipo, Produtos.CodigoNFE, Produtos.CodigoProduto HAVING (((Compra.Tipo)='NF'))", conn)
            DR = cmdInventario.ExecuteReader

            Dim tb As DataTable
            tb = DS.Tables("Iventario")
            Dim linhaNew As DataRow


            While DR.Read()
                linhaNew = tb.NewRow
                linhaNew("CodigoNfe") = DR.Item(1)
                linhaNew("Qtde") = DR.Item(2)
                linhaNew("CodigoProduto") = DR.Item(3)
                tb.Rows.Add(linhaNew)
            End While
            ' cmdInventario = New OleDb.OleDbCommand("SELECT NFeItens.Cprod AS Produto, Sum([qCom]*-1) AS Qtd FROM NFe INNER JOIN NFeItens ON NFe.chaveAcesso = NFeItens.ChaveAcesso WHERE (((NFe.dEmi) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((NFe.natOp)='VENDA')) GROUP BY NFeItens.Cprod", conNFe)
            cmdInventario = New OleDb.OleDbCommand("SELECT NFeItens.Cprod AS Produto, Sum([qCom]*-1) AS Qtd, Produtos.CodigoERP FROM Produtos INNER JOIN (NFe INNER JOIN NFeItens ON NFe.chaveAcesso = NFeItens.ChaveAcesso) ON Produtos.Cprod = NFeItens.Cprod WHERE (((NFe.dEmi) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((NFe.natOp)='VENDA')) GROUP BY NFeItens.Cprod, Produtos.CodigoERP HAVING ((Not (Produtos.CodigoERP) Is Null));", conNFe)
            DRnfe = cmdInventario.ExecuteReader

            While DRnfe.Read()
                linhaNew = tb.NewRow
                linhaNew("CodigoNfe") = DRnfe.Item("Produto")
                linhaNew("CodigoProduto") = DRnfe.Item("CodigoERP")
                linhaNew("Qtde") = DRnfe.Item("Qtd")
                tb.Rows.Add(linhaNew)
            End While

            Dim oCmdBder As New OleDb.OleDbCommandBuilder(oDA)
            oDA.Update(DS, "Iventario")

            'Dim cmdExclui As New OleDb.OleDbCommand("Delete * from Iventario", conn)
            'cmdExclui.ExecuteNonQuery()
            'cmdExclui.Dispose()
            'conn.Close()
            'conNFe.Close()

        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try




        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        Cnn.Open()


        With Cmd
            .Connection = Cnn
            '.CommandText = "SELECT Iventario.CodigoProduto, Iventario.Qtde, Produtos.ValorCompra, [ValorCompra]*[QTDE] AS ValorTotal, Produtos.Descrição, Produtos.CódigoGrupo, Produtos.CF, Produtos.UnidadeMedida, Grupos.Descrição AS DescGrupo FROM (Iventario INNER JOIN Produtos ON Iventario.CodigoProduto = Produtos.CodigoProduto) INNER JOIN Grupos ON Produtos.CódigoGrupo = Grupos.CódigoGrupo;"
            .CommandText = "SELECT Iventario.CodigoProduto, Sum(Iventario.Qtde) AS SomaDeQtde, Produtos.ValorCompra, Sum([ValorCompra]*[QTDE]) AS ValorTotal, Produtos.Descrição, Produtos.CódigoGrupo, Produtos.CF, Produtos.UnidadeMedida, Grupos.Descrição AS DescGrupo FROM (Iventario INNER JOIN Produtos ON Iventario.CodigoProduto = Produtos.CodigoProduto) INNER JOIN Grupos ON Produtos.CódigoGrupo = Grupos.CódigoGrupo GROUP BY Iventario.CodigoProduto, Produtos.ValorCompra, Produtos.Descrição, Produtos.CódigoGrupo, Produtos.CF, Produtos.UnidadeMedida, Grupos.Descrição;"
            .CommandType = CommandType.Text
        End With

        DataReader = Cmd.ExecuteReader

        Dim Linha As String = ""
        FileOpen(1, Me.Local.Text & "\INVENTARIO." & Me.EmpProSoft.Text, OpenMode.Output)
        While DataReader.Read
            Try
                Linha = Linha & RChr(Me.DataFinal.Text, 8, "", "E", True) '1
                Linha = Linha & RChr(CDate(Me.DataInicial.Text).Month & Mid(CDate(Me.DataInicial.Text).Year, 3), 4, 0, "E", True) '9
                Linha = Linha & RChr(CDate(Me.DataFinal.Text).Month & Mid(CDate(Me.DataFinal.Text).Year, 3), 4, 0, "E", True) '13
                Linha = Linha & RChr(DataReader.Item("CodigoProduto"), 20, " ", "D", False) '17
                Linha = Linha & RChr("1", 1, "", "D", False) '37
                Linha = Linha & RChr("00000000000000", 14, "", "D", False) '38
                Linha = Linha & RChr("", 20, " ", "D", False) '52
                Linha = Linha & RChr("", 2, " ", "D", False) '72
                Linha = Linha & RChr("", 5, " ", "D", False) '74
                Linha = Linha & SChr(FormatNumber(NzZero(DataReader.Item("SomaDeQtde")), 6), 16, "0", "E", True) '79
                Linha = Linha & SChr(FormatNumber(NzZero(DataReader.Item("ValorCompra")), 4), 17, "0", "E", True) '95
                Linha = Linha & SChr(FormatNumber(NzZero(DataReader.Item("ValorTotal")), 2), 17, "0", "E", True) '112
                Linha = Linha & SChr(FormatNumber(NzZero(0), 2), 17, "0", "E", True) '129
                Linha = Linha & RChr("", 60, " ", "D", False) '146
                Linha = Linha & RChr(DataReader.Item("Descrição"), 80, " ", "D", False) '206
                Linha = Linha & RChr(DataReader.Item("CódigoGrupo"), 4, " ", "D", False) '286
                Linha = Linha & RChr(DataReader.Item("CF"), 10, " ", "D", False) '290
                Linha = Linha & RChr("", 30, " ", "D", False) '300
                Linha = Linha & RChr(DataReader.Item("UnidadeMedida"), 3, " ", "D", False) '330
                Linha = Linha & RChr(DataReader.Item("DescGrupo"), 30, " ", "D", False) '333
                
                PrintLine(1, Linha)
                Linha = ""
            Catch XP As System.Exception
                MsgBox(XP.ToString)
                MsgBox("Verique o Cliente : " & DataReader.Item("Nome"))
            End Try
            MyBarra.PerformStep()
        End While
        FileClose(1)

        DataReader.Close()

        Dim cmdExclui As New OleDb.OleDbCommand("Delete * from Iventario", conn)
        cmdExclui.ExecuteNonQuery()
        cmdExclui.Dispose()

        Cnn.Close()
        conn.Close()
        conNFe.Close()
        Me.Cursor = Cursors.Default
        MsgBox("Exportação Concluida", 64, "Validação de Dados")
        Me.MyBarra.Visible = False
    End Sub







    Public Sub ExTerceiros()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        Cnn.Open()


        With Cmd
            .Connection = Cnn
            .CommandText = "SELECT Clientes.CpfCgc, Clientes.Nome, Clientes.NomeFantasia, Clientes.Endereço, Clientes.Cidade, Clientes.Bairro, Clientes.Cep, Clientes.Estado, Clientes.Telefone, Clientes.Insc, Clientes.Inativo, Clientes.Empresa, Clientes.TipoPessoa AS FJ ,'Cliente' AS TP FROM(Clientes) WHERE Clientes.Inativo = False  AND Clientes.Empresa =" & CodEmpresa & " and Clientes.CpfCgc is not null  UNION SELECT Fornecedor.CgcCpf AS CpfCgc, Fornecedor.RazãoSocial AS Nome, Fornecedor.NomeFantasia, Fornecedor.Endereço, Fornecedor.Cidade, '' AS Bairro, Fornecedor.Cep, Fornecedor.Estado, Fornecedor.Telefone1 AS Telefone, Fornecedor.IncriçãoEstadual AS Insc, Fornecedor.Inativo, Fornecedor.Empresa, Fornecedor.TipoFornecedor AS FJ, 'Fornecedor' AS TP FROM(Fornecedor) WHERE Fornecedor.Inativo=False AND Fornecedor.Empresa = " & CodEmpresa & " and Fornecedor.CgcCpf is not null;"
            .CommandType = CommandType.Text
        End With

        DataReader = Cmd.ExecuteReader

        Dim Linha As String = ""
        FileOpen(1, Me.Local.Text & "\TERCEIROS." & Me.EmpProSoft.Text, OpenMode.Output)
        While DataReader.Read
            Try
                Linha = Linha & "TRC" 'Cp1
                Linha = Linha & "     " 'cp2
                Linha = Linha & "  " 'Cp3

                Dim Personalidade As String = "2"

                Try
                    If DataReader.Item("FJ") = "F" Then
                        Personalidade = "1"
                    End If

                    If DataReader.Item("FJ") = "J" Then
                        Personalidade = "0"
                    End If
                Catch ex As Exception
                    Personalidade = "1"
                End Try
                Linha = Linha & Personalidade 'cp4

                Dim C As String = RChr(Trim(DataReader.Item("CpfCgc")), 14, "0", "E", True)

                Linha = Linha & C  'cp5
                Linha = Linha & RChr(DataReader.Item("Nome"), 60, " ", "D", False) 'cp6
                Linha = Linha & RChr(DataReader.Item("NomeFantasia"), 20, " ", "D", False) 'cp7
                Linha = Linha & RChr("", 10, " ", "D", False) 'cp8 tipo de logradouro
                Linha = Linha & RChr(DataReader.Item("Endereço"), 60, " ", "D", False) 'cp9
                Linha = Linha & RChr("", 10, " ", "D", False) 'cp10
                Linha = Linha & RChr("", 20, " ", "D", False) 'cp11
                Linha = Linha & RChr(DataReader.Item("Cep"), 9, " ", "D", False) 'cp12
                Linha = Linha & RChr(DataReader.Item("Bairro"), 30, " ", "D", False) 'cp13
                Linha = Linha & RChr(DataReader.Item("Cidade"), 30, " ", "D", False) 'cp14
                Linha = Linha & RChr(DataReader.Item("Estado"), 2, " ", "D", False) 'cp15
                Linha = Linha & RChr(Format(CDate(Today), "yyyyMMdd"), 8, " ", "D", False) 'cp16 data de cadastro
                Linha = Linha & RChr("", 5, " ", "D", False) 'cp17 Telefone ddd
                Linha = Linha & RChr("", 10, " ", "D", False) 'cp18 telefone numero
                Linha = Linha & RChr("", 5, " ", "D", False) 'cp19 telefax ddd
                Linha = Linha & RChr("", 10, " ", "D", False) 'cp20 telefax numero
                Linha = Linha & RChr("", 50, " ", "D", False) 'cp21 email
                Linha = Linha & RChr("", 60, " ", "D", False) 'cp22 Home page
                Linha = Linha & RChr(DataReader.Item("Insc"), 20, " ", "D", False) 'cp23 inscricao estadual
                Linha = Linha & RChr("", 20, " ", "D", False) 'cp24 inscricao municipal
                Linha = Linha & RChr("", 10, " ", "D", False) 'cp25 cod ativ. economica
                Linha = Linha & RChr("", 18, " ", "D", False) 'cp26 rg numero pessoa fisica
                Linha = Linha & RChr("", 5, " ", "D", False) 'cp27 rg orgao emissor pessoa fisica
                Linha = Linha & RChr("", 2, " ", "D", False) 'cp28 rg estado emissor
                Linha = Linha & RChr("", 8, " ", "D", False) 'cp29 rg data da emissão
                Linha = Linha & RChr("", 1, " ", "D", False) 'cp30 sexo
                Linha = Linha & RChr("", 4, " ", "D", False) 'cp31 codigo do pais
                Linha = Linha & RChr("", 5, " ", "D", False) 'cp32 codigo do ibge
                Linha = Linha & RChr("", 86, " ", "D", False) 'cp33 filer em branco

                PrintLine(1, Linha)
                Linha = ""
            Catch XP As System.Exception
                MsgBox(XP.ToString)
                MsgBox("Verique o Cliente : " & DataReader.Item("Nome"))
            End Try
            MyBarra.PerformStep()
        End While
        FileClose(1)

        DataReader.Close()
        Cnn.Close()

        MsgBox("Exportação Concluida", 64, "Validação de Dados")
        Me.MyBarra.Visible = False
    End Sub

    Public Sub ExProdutos()
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        Cnn.Open()

        'Captura Qtd de Registro para definir a Barra 
        Dim CmdTotalLinhas As New OleDb.OleDbCommand("SELECT Count(*) FROM Produtos WHERE Inativo = False and Descrição is not null", Cnn)
        Dim TotalLinhas As Long = 0
        Try
            TotalLinhas = CInt(CmdTotalLinhas.ExecuteScalar())
        Catch
            TotalLinhas = 0
        End Try
        'Atualiza a barra de Progresso
        If TotalLinhas = 0 Then TotalLinhas = 1
        MyBarra.Visible = True
        MyBarra.Minimum = 1
        MyBarra.Maximum = TotalLinhas
        MyBarra.Value = 1
        MyBarra.Step = 1
        MyBarra.Visible = True
        'Fim dos dados da Barra de Progresso
        'fim

        With Cmd
            .Connection = Cnn
            .CommandText = "SELECT * from Produtos where Descrição is not null and Inativo = false"
            .CommandType = CommandType.Text
        End With

        DataReader = Cmd.ExecuteReader

        Dim Linha As String = ""
        FileOpen(1, Me.Local.Text & "\PRODUTOS." & Me.EmpProSoft.Text, OpenMode.Output)
        While DataReader.Read
            Try
                Linha = Linha & RChr(DataReader.Item("CodigoProduto"), 20, " ", "D", False) ' Campo 1
                Linha = Linha & RChr(UCase(DataReader.Item("Descrição")), 80, " ", "D", False) ' Campo 2
                Linha = Linha & RChr("00", 2, " ", "D", False) ' Campo 3
                Linha = Linha & RChr(DataReader.Item("UnidadeMedida"), 3, " ", "D", False) ' Campo 4
                Linha = Linha & RChr(DataReader.Item("CF"), 10, " ", "E", False) ' Campo 5
                Linha = Linha & RChr(" ", 2, " ", "D", False) ' Campo 6
                Linha = Linha & RChr(FormatNumber(Nz(DataReader.Item("Icms"), 3), 2), 5, "0", "E", False) ' Campo 7
                Linha = Linha & RChr(FormatNumber(0, 2), 5, "0", "E", False) ' Campo 8
                Linha = Linha & RChr(FormatNumber(0, 2), 14, "0", "E", False) ' Campo 9
                Linha = Linha & RChr(DataReader.Item("Ipi"), 5, "0", "E", False) ' Campo 10
                Linha = Linha & RChr("0", 2, "0", "E", False) ' Campo 11
                Linha = Linha & RChr(DataReader.Item("Cst"), 3, "0", "E", False) ' Campo 12
                Linha = Linha & RChr("11", 2, " ", "D", False) ' Campo 13
                Linha = Linha & RChr(FormatNumber(0, 3), 14, "0", "E", False) ' Campo 14
                Linha = Linha & RChr(" ", 14, " ", "D", False) ' Campo 15
                Linha = Linha & RChr(" ", 7, " ", "D", False) ' Campo 16
                Linha = Linha & RChr(" ", 1, " ", "D", False) ' Campo 17
                Linha = Linha & RChr(" ", 5, " ", "D", False) ' Campo 18
                Linha = Linha & RChr(" ", 1, " ", "D", False) ' Campo 19
                Linha = Linha & RChr(" ", 4, " ", "D", False) ' Campo 20
                Linha = Linha & RChr(" ", 2, " ", "D", False) ' Campo 21
                Linha = Linha & RChr("0", 3, "0", "D", False) ' Campo 22
                Linha = Linha & RChr("0", 5, "0", "D", False) ' Campo 23
                Linha = Linha & RChr(FormatNumber(0, 3), 7, " ", "E", False) ' Campo 24
                Linha = Linha & RChr("0", 3, "0", "D", False) ' Campo 25
                Linha = Linha & RChr("0", 4, "0", "D", False) ' Campo 26
                Linha = Linha & RChr("0", 3, "0", "D", False) ' Campo 27
                Linha = Linha & RChr(FormatNumber(0, 2), 5, "0", "E", False) ' Campo 28
                Linha = Linha & RChr(FormatNumber(0, 2), 5, "0", "E", False) ' Campo 29
                Linha = Linha & RChr("0", 2, "0", "D", False) ' Campo 30
                Linha = Linha & RChr("0", 2, "0", "D", False) ' Campo 31
                Linha = Linha & RChr("0", 6, "0", "D", False) ' Campo 32
                Linha = Linha & RChr(" ", 30, " ", "D", False) ' Campo 33
                Linha = Linha & RChr(" ", 30, " ", "D", False) ' Campo 34
                Linha = Linha & RChr(" ", 4, " ", "D", False) ' Campo 35
                Linha = Linha & RChr("0", 4, "0", "D", False) ' Campo 36
                Linha = Linha & RChr(" ", 5, " ", "D", False) ' Campo 37
                Linha = Linha & RChr(FormatNumber(0, 4), 8, "0", "E", False) ' Pos 320
                Linha = Linha & RChr("N", 1, " ", "E", False) ' pos 328
                Linha = Linha & RChr("00", 2, " ", "E", False) ' pos 328
                Linha = Linha & RChr(" ", 84, " ", "D", False) ' campos vazios 
                Linha = Linha & RChr(DataReader.Item("CodCTBEntrada"), 60, " ", "E", False) ' pos 415

                Linha = Linha & RChr(" ", 4, " ", "D", False) ' campos vazios 

                Linha = Linha & RChr(DataReader.Item("cstpis"), 2, " ", "D", False) ' posicao 479
                Linha = Linha & RChr(DataReader.Item("cstcofins"), 2, " ", "D", False) ' posicao 481

                PrintLine(1, Linha)
                Linha = ""
            Catch XP As System.Exception
                MsgBox(XP.ToString)
                MsgBox("Verique o Cliente : " & DataReader.Item("Nome"))
            End Try
            MyBarra.PerformStep()
        End While
        FileClose(1)

        DataReader.Close()
        Cnn.Close()

        MsgBox("Exportação Concluida", 64, "Validação de Dados")
        Me.MyBarra.Visible = False

    End Sub

    Public Sub ExportaEntradas()
        Dim ds As New DataSet

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT Compra.*, Fornecedor.CgcCpf, Fornecedor.IncriçãoEstadual, Fornecedor.Estado, ItensCompra.*, ItensCompra.BaseCalcIcms as ItBaseCalcIcms,Produtos.*, 0 AS ItemDesdobramento FROM ((Compra INNER JOIN ItensCompra ON Compra.CompraInterno = ItensCompra.CompraInterno) INNER JOIN Fornecedor ON Compra.CodigoFornecedor = Fornecedor.CódigoFornecedor) INNER JOIN Produtos ON ItensCompra.CodigoProduto = Produtos.CodigoProduto WHERE (((Compra.DataLançamento) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Compra.Confirmado)=True) AND ((Compra.Inativo)=False) AND ((Compra.Empresa)=" & Me.EmpUP.Text & ") AND ((Compra.Tipo)='NF') AND ((Compra.TpEntrada)='ENTRADA' Or (Compra.TpEntrada)='ENT BRINDE')) ORDER BY Compra.NotaFiscal, ItensCompra.CFOPent;"

        Dim daExport As New OleDb.OleDbDataAdapter(Sql, Cnn)
        daExport.Fill(ds, "TB")


        Sql = "SELECT Compra.NotaFiscal, ItensCompra.CFOPent FROM Compra INNER JOIN ItensCompra ON Compra.CompraInterno = ItensCompra.CompraInterno WHERE (((Compra.DataLançamento) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Compra.Confirmado)=True) AND ((Compra.Inativo)=False) AND ((Compra.Empresa)=" & CodEmpresa & ") AND ((Compra.Tipo)='NF') AND ((Compra.TpEntrada)='ENTRADA' Or (Compra.TpEntrada)='ENT BRINDE')) GROUP BY Compra.NotaFiscal, ItensCompra.CFOPent ORDER BY Compra.NotaFiscal, ItensCompra.CFOPent;"
        Dim daQtdCfop As New OleDb.OleDbDataAdapter(Sql, Cnn)
        daQtdCfop.Fill(ds, "QtdCFOP")

        Dim NF As String = String.Empty
        Dim NFtemp As String = String.Empty
        Dim CFOP As String = String.Empty
        Dim CFOPTemp As String = String.Empty
        Dim It As Integer = 0

        'adiciona o item do desmembramento
        Dim Dv As DataView 'Cria o dataview para filtragem de dados e verificar se tem mais de um cfop

        Dim L As Integer = 0
        For L = 0 To ds.Tables("TB").Rows.Count - 1
            NFtemp = ds.Tables("TB").Rows(L)("NotaFiscal")

            If NF = NFtemp Then
                CFOPTemp = ds.Tables("TB").Rows(L)("CFOPent")
                If CFOP = CFOPTemp Then
                    ds.Tables("TB").Rows(L).BeginEdit()
                    ds.Tables("TB").Rows(L)("ItemDesdobramento") = It
                    ds.Tables("TB").Rows(L).EndEdit()
                    NF = ds.Tables("TB").Rows(L)("NotaFiscal")
                    CFOP = ds.Tables("TB").Rows(L)("CFOPent")
                Else
                    It += 1
                    ds.Tables("TB").Rows(L).BeginEdit()
                    ds.Tables("TB").Rows(L)("ItemDesdobramento") = It
                    ds.Tables("TB").Rows(L).EndEdit()
                    NF = ds.Tables("TB").Rows(L)("NotaFiscal")
                    CFOP = ds.Tables("TB").Rows(L)("CFOPent")
                End If
            Else

                Dv = New DataView(ds.Tables("QtdCFOP"), "NotaFiscal = '" & NFtemp & "'", "NotaFiscal ASC", DataViewRowState.OriginalRows)

                If Dv.Count = 1 Then
                    It = 0
                ElseIf Dv.Count > 1 Then
                    It = 1
                End If

                CFOPTemp = ds.Tables("TB").Rows(L)("CFOPent") & ""

                ds.Tables("TB").Rows(L).BeginEdit()
                ds.Tables("TB").Rows(L)("ItemDesdobramento") = It
                ds.Tables("TB").Rows(L).EndEdit()
                NF = ds.Tables("TB").Rows(L)("NotaFiscal")
                CFOP = ds.Tables("TB").Rows(L)("CFOPent") & ""
            End If

        Next L
        'Fim

        'Criar Cabeçalho parsa os desdobramentos

        Sql = "SELECT Compra.CFOP, Compra.ChaveNFe, Compra.EspecieDocumento, Fornecedor.CódigoFornecedor, Fornecedor.CgcCpf, Fornecedor.IncriçãoEstadual, Fornecedor.Estado, '' AS ItemDesdobramento, Compra.NotaFiscal, Compra.Modelo, Compra.Serie, Compra.Subserie, Compra.DataCompra, Compra.DataEntrada, Compra.DataLançamento, Compra.ValorDesconto, Compra.TotalProdutos, Compra.ValorIssqnRetido, Compra.ValorCompra, Compra.Icms, Compra.BaseCalcIcms, Compra.ValorIcms, Compra.IsentoIcms, Compra.ValorOutrosIcms, Compra.BaseCalcIpi, Compra.Ipi, Compra.ValorIpi, Compra.ValorOutrosIpi, Compra.IsentoIpi, Compra.Confirmado, Compra.Inativo, Compra.Empresa, Compra.Tipo, Compra.FormaPagamento, Compra.Obs, Compra.ValorFrete, Compra.LancaItens, Compra.TpEntrada FROM Compra INNER JOIN Fornecedor ON Compra.CodigoFornecedor = Fornecedor.CódigoFornecedor WHERE (((Compra.TpEntrada)='Vazio'));"

        Dim daExportCab As New OleDb.OleDbDataAdapter(Sql, Cnn)
        daExportCab.Fill(ds, "TBCAB")

        For Each row As DataRow In ds.Tables("TB").Rows
            Dim DrNF() As DataRow
            DrNF = ds.Tables("TBCAB").Select("NotaFiscal = '" & row("NotaFiscal").ToString & "' and ItemDesdobramento = '" & row("ItemDesdobramento").ToString & "'")

            Dim VlrItemAgregados As Double
            If DrNF.Length = 0 Then

                VlrItemAgregados = CDbl(NzZero(row("ItensCompra.ValorIcmsST"))) + CDbl(NzZero(row("ValorFreteProduto"))) + CDbl(NzZero(row("vSeg"))) + CDbl(NzZero(row("vOutro"))) + CDbl(NzZero(row("ItensCompra.ValorIpi")))


                Dim DRnovo As DataRow
                DRnovo = ds.Tables("TBCAB").NewRow()
                'DRnovo("CFOP") = row("ItensCompra.CFOP") correção lelo referente cfop de entrada
                DRnovo("CFOP") = row("CFOPENT")
                DRnovo("CódigoFornecedor") = row("CodigoFornecedor")
                DRnovo("CgcCpf") = row("CgcCpf")
                DRnovo("IncriçãoEstadual") = row("IncriçãoEstadual")
                DRnovo("Estado") = row("Estado")
                DRnovo("ItemDesdobramento") = row("ItemDesdobramento")
                DRnovo("NotaFiscal") = row("NotaFiscal")
                DRnovo("ChaveNFe") = row("ChaveNFe")
                DRnovo("EspecieDocumento") = row("EspecieDocumento")
                DRnovo("Modelo") = row("Modelo")
                DRnovo("Serie") = row("Compra.Serie")
                DRnovo("SubSerie") = row("Compra.SubSerie")
                DRnovo("DataCompra") = row("DataCompra")
                DRnovo("DataEntrada") = row("DataEntrada")
                DRnovo("DataLançamento") = row("DataLançamento")
                DRnovo("ValorDesconto") = row("ItensCompra.ValorDesconto")
                DRnovo("TotalProdutos") = row("TotalProduto")
                DRnovo("ValorCompra") = row("TotalProduto") + VlrItemAgregados
                DRnovo("Icms") = row("IcmsProduto")
                If row("IcmsProduto") > 0 Then DRnovo("BaseCalcIcms") = row("ItBaseCalcIcms") + VlrItemAgregados 'row("TotalProduto") + VlrItemAgregados
                DRnovo("ValorIcms") = row("ValorIcmsProduto")
                DRnovo("IsentoIcms") = row("ItensCompra.IsentoIcms")
                DRnovo("ValorOutrosIcms") = row("ItensCompra.ValorOutrosIcms")

                If row("ItensCompra.Ipi") > 0 Then DRnovo("BaseCalcIpi") = row("TotalProduto") Else DRnovo("BaseCalcIpi") = 0
                DRnovo("ValorIpi") = row("ItensCompra.ValorIpi")
                DRnovo("ValorOutrosIpi") = row("ItensCompra.ValorOutrosIpi")
                DRnovo("IsentoIpi") = row("ItensCompra.IsentoIpi")
                DRnovo("FormaPagamento") = row("FormaPagamento")

                ds.Tables("TBCAB").Rows.Add(DRnovo)

            Else

                DrNF(0).BeginEdit()

                VlrItemAgregados = CDbl(NzZero(row("ItensCompra.ValorIcmsST"))) + CDbl(NzZero(row("ValorFreteProduto"))) + CDbl(NzZero(row("vSeg"))) + CDbl(NzZero(row("vOutro"))) + CDbl(NzZero(row("ItensCompra.ValorIpi")))


                DrNF(0)("ValorDesconto") += row("ItensCompra.ValorDesconto")
                DrNF(0)("TotalProdutos") += row("TotalProduto")
                DrNF(0)("ValorCompra") += row("TotalProduto") + VlrItemAgregados

                If row("IcmsProduto") > 0 Then DrNF(0)("BaseCalcIcms") = NzZero(DrNF(0)("BaseCalcIcms")) + NzZero(row("ItBaseCalcIcms")) + NzZero(VlrItemAgregados) ' CDbl(NzZero(DrNF(0)("BaseCalcIcms"))) + CDbl(NzZero(row("TotalProduto"))) + VlrItemAgregados
                DrNF(0)("ValorIcms") += row("ValorIcmsProduto")
                DrNF(0)("IsentoIcms") += row("ItensCompra.IsentoIcms")
                DrNF(0)("ValorOutrosIcms") += row("ItensCompra.ValorOutrosIcms")

                If row("ItensCompra.Ipi") > 0 Then DrNF(0)("BaseCalcIpi") += row("TotalProduto") Else DrNF(0)("BaseCalcIpi") += 0
                DrNF(0)("ValorIpi") += row("ItensCompra.ValorIpi")
                DrNF(0)("ValorOutrosIpi") += NzZero(row("ItensCompra.ValorOutrosIpi"))
                DrNF(0)("IsentoIpi") += row("ItensCompra.IsentoIpi")


                DrNF(0).EndEdit()

            End If

        Next


        Dim Linha As String = ""
        FileOpen(1, Me.Local.Text & "\ENTRADA." & Me.EmpProSoft.Text, OpenMode.Output)

        For Each row As DataRow In ds.Tables("TBCAB").Rows

            Try
                Linha = Linha & RChr(" ", 4, " ", "D", False) 'cp 1
                Linha = Linha & RChr(row("CgcCpf"), 14, 0, "E", True) 'cp 2
                Linha = Linha & RChr(Format(CDate(row("DataEntrada")), "dd/MM/yy"), 6, 0, "E", True) 'cp 3
                Linha = Linha & RChr(Format(CDate(row("DataCompra")), "dd/MM/yy"), 6, 0, "E", True)  'cp 4
                Linha = Linha & RChr(row("NotaFiscal"), 6, 0, "E", False) 'cp 5
                Linha = Linha & RChr(" ", 3, " ", "D", True)  'cp 6
                Linha = Linha & RChr("   ", 3, " ", "D", False) 'cp 7
                Linha = Linha & RChr(row("ItemDesdobramento"), 1, " ", "D", False) 'cp 8
                Linha = Linha & SChr("00000", 5, 0, "E", True) 'cp 9
                Linha = Linha & SChr("000", 3, 0, "E", True) 'cp 10
                Linha = Linha & SChr(FormatNumber(Nz(row("Valorcompra"), 3), 2), 14, 0, "E", True) 'cp 11
                Linha = Linha & SChr(FormatNumber(Nz(row("BaseCalcIcms"), 3), 2), 14, 0, "E", True) 'cp 12
                Linha = Linha & SChr(FormatNumber(Nz(row("ValorIcms"), 3), 2), 14, 0, "E", True)  'cp 13
                Linha = Linha & SChr(FormatNumber(Nz(row("IsentoIcms"), 3), 2), 14, 0, "E", True)  'cp 14
                Linha = Linha & SChr(FormatNumber(Nz(row("ValorOutrosIcms"), 3), 2), 14, 0, "E", True) 'cp 15
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 16
                Linha = Linha & SChr(FormatNumber(Nz(row("Icms"), 3), 2), 5, 0, "E", True)  'cp 17
                Linha = Linha & SChr(FormatNumber(Nz(row("BaseCalcIpi"), 3), 2), 14, 0, "E", True) 'cp 18
                Linha = Linha & SChr(FormatNumber(Nz(row("ValorIpi"), 3), 2), 14, 0, "E", True) 'cp 19
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True)  'cp 20
                Linha = Linha & SChr(FormatNumber(Nz(row("IsentoIpi"), 3), 2), 14, 0, "E", True) 'cp 21
                Linha = Linha & SChr(FormatNumber(Nz(row("ValorOutrosIpi"), 3), 2), 14, 0, "E", True) 'cp 22
                Dim VlrLiquido As Double = NzZero(row("Valorcompra")) - NzZero(row("ValorDesconto"))
                Linha = Linha & SChr(FormatNumber(Nz(VlrLiquido, 3), 2), 14, 0, "E", True) 'cp 23   

                Linha = Linha & RChr(row("FormaPagamento"), 1, 0, "E", False) 'cp 24
                Linha = Linha & SChr(row("FormaPagamento"), 2, 0, "E", True)  'cp 25

                Linha = Linha & SChr("0", 3, 0, "E", True) 'cp 26
                Linha = Linha & SChr(FormatNumber("0.00", 2), 12, 0, "E", True) 'cp 27
                Linha = Linha & SChr(FormatNumber("0.00", 2), 12, 0, "E", True) 'cp 28
                Linha = Linha & SChr(FormatNumber("0.00", 2), 12, 0, "E", True) 'cp 29
                Linha = Linha & SChr(FormatNumber("0.00", 2), 12, 0, "E", True) 'cp 30
                Linha = Linha & RChr(" ", 100, " ", "D", False) 'cp 31
                Linha = Linha & RChr(" ", 6, " ", "D", False) 'cp 32
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 33
                Linha = Linha & RChr(" ", 6, " ", "D", False) 'cp 34
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 35
                Linha = Linha & RChr(" ", 6, " ", "D", False) 'cp 36
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 37
                Linha = Linha & RChr(" ", 6, " ", "D", False) 'cp 38
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 39
                Linha = Linha & RChr(" ", 6, " ", "D", False) 'cp 40
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 41
                Linha = Linha & RChr(" ", 6, " ", "D", False) 'cp 42
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 43
                Linha = Linha & RChr(row("IncriçãoEstadual"), 18, " ", "D", False)  'cp 44
                Linha = Linha & RChr(row("Estado"), 2, " ", "D", False)  'cp 45
                Linha = Linha & RChr(" ", 1, " ", "D", False)  'cp 46
                Linha = Linha & RChr(" ", 5, 0, "E", False) 'cp 47
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 48
                Linha = Linha & RChr(" ", 1, " ", "D", False)  'cp 49
                Linha = Linha & RChr(" ", 5, 0, "E", False) 'cp 50
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 51
                Linha = Linha & RChr(" ", 5, 0, "E", False) 'cp 52
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 53
                Linha = Linha & RChr(" ", 5, 0, "E", False) 'cp 54
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 55
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 56
                Linha = Linha & RChr(" ", 3, " ", "D", False) 'cp 57
                Linha = Linha & RChr(" ", 4, " ", "D", False) 'cp 58
                Linha = Linha & RChr(" ", 6, " ", "D", False) 'cp 59
                Linha = Linha & RChr(row("Cfop"), 4, " ", "D", True)   'cp 60
                Linha = Linha & RChr(" ", 10, " ", "D", False) 'cp 61
                Linha = Linha & RChr(" ", 14, " ", "D", False) 'cp 62
                Linha = Linha & RChr(" ", 18, " ", "D", False) 'cp 63
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 64
                Linha = Linha & RChr(" ", 14, " ", "D", False) 'cp 65
                Linha = Linha & RChr(" ", 18, " ", "D", False) 'cp 66
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 67
                Linha = Linha & RChr(" ", 14, " ", "D", False) 'cp 68
                Linha = Linha & RChr(" ", 18, " ", "D", False) 'cp 69
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 70
                Linha = Linha & RChr(" ", 1, " ", "D", False) 'cp 71
                Linha = Linha & RChr(" ", 7, " ", "D", False) 'cp 72
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 73
                Linha = Linha & RChr(" ", 7, " ", "D", False) 'cp 74
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 75
                Linha = Linha & RChr(" ", 7, " ", "D", False) 'cp 76
                Linha = Linha & RChr(" ", 2, " ", "D", False)  'cp 77

                Linha = Linha & RChr(" ", 1, " ", "D", False)  'cp 78
                Linha = Linha & RChr(Nz(0, 3), 4, "0", "E", False)  'cp 79
                Linha = Linha & RChr(" ", 2, " ", "D", False)  'cp 80
                Linha = Linha & RChr("0", 14, " ", "D", False) 'cp 81
                Linha = Linha & RChr("0", 14, " ", "D", False)  'cp 82

                Linha = Linha & RChr(" ", 6, " ", "D", False)  'cp 83
                Linha = Linha & RChr("0", 1, "", "D", False)  'cp 84
                Linha = Linha & RChr(" ", 6, " ", "D", False)  'cp 85
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 86
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 87
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 88
                Linha = Linha & RChr(row("EspecieDocumento"), 5, " ", "D", False)  'cp 89
                Linha = Linha & RChr(" ", 1, " ", "D", False)  'cp 90
                Linha = Linha & RChr(row("Serie"), 3, " ", "D", False)  '864
                Linha = Linha & RChr(row("SubSerie"), 2, " ", "D", False)  '867
                Linha = Linha & RChr(" ", 104, " ", "D", False)  'Brancos
                Linha = Linha & RChr(row("ChaveNFe"), 44, " ", "D", False)  '973
                Linha = Linha & RChr(" ", 109, " ", "D", False)  'Branco
                Linha = Linha & SChr(FormatNumber(NzZero(row("ValorDesconto")), 2), 14, "0", "E", True)  '1126


                PrintLine(1, Linha)
                Linha = ""
            Catch XP As System.Exception
                MsgBox(XP.ToString)
            End Try
        Next

        'Notas sem Itens.....O arquivo de texto continua aberto para adição

        Sql = "SELECT Compra.*, Fornecedor.* FROM (Compra LEFT JOIN ItensCompra ON Compra.CompraInterno = ItensCompra.CompraInterno) INNER JOIN Fornecedor ON Compra.CodigoFornecedor = Fornecedor.CódigoFornecedor WHERE (((ItensCompra.CompraInterno) Is Null) AND ((Compra.DataLançamento) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Compra.Confirmado)=True) AND ((Compra.Inativo)=False) AND ((Compra.Empresa)=" & CodEmpresa & ") AND ((Compra.Tipo)='NF') AND ((Compra.TpEntrada)='ENTRADA'));"
        Dim daNF1 As New OleDb.OleDbDataAdapter(Sql, Cnn)
        daNF1.Fill(ds, "NF1")

        For Each row As DataRow In ds.Tables("NF1").Rows
            Try

                Linha = Linha & RChr(" ", 4, " ", "D", False) 'cp 1
                Linha = Linha & RChr(row("CgcCpf"), 14, 0, "E", True) 'cp 2
                Linha = Linha & RChr(Format(CDate(row("DataEntrada")), "dd/MM/yy"), 6, 0, "E", True) 'cp 3
                Linha = Linha & RChr(Format(CDate(row("DataCompra")), "dd/MM/yy"), 6, 0, "E", True)  'cp 4
                Linha = Linha & RChr(row("NotaFiscal"), 6, 0, "E", False) 'cp 5
                Linha = Linha & RChr(" ", 3, " ", "D", True)  'cp 6
                Linha = Linha & RChr("   ", 3, " ", "D", False) 'cp 7
                Linha = Linha & RChr("0", 1, " ", "D", False) 'cp 8
                Linha = Linha & SChr("00000", 5, 0, "E", True) 'cp 9
                Linha = Linha & SChr("000", 3, 0, "E", True) 'cp 10
                Linha = Linha & SChr(FormatNumber(Nz(row("TotalProdutos"), 3), 2), 14, 0, "E", True) 'cp 11
                Linha = Linha & SChr(FormatNumber(Nz(row("BaseCalcIcms"), 3), 2), 14, 0, "E", True) 'cp 12
                Linha = Linha & SChr(FormatNumber(Nz(row("ValorIcms"), 3), 2), 14, 0, "E", True)  'cp 13
                Linha = Linha & SChr(FormatNumber(Nz(row("IsentoIcms"), 3), 2), 14, 0, "E", True)  'cp 14
                Linha = Linha & SChr(FormatNumber(Nz(row("ValorOutrosIcms"), 3), 2), 14, 0, "E", True) 'cp 15
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 16
                Linha = Linha & SChr(FormatNumber(Nz(row("Icms"), 3), 2), 5, 0, "E", True)  'cp 17
                Linha = Linha & SChr(FormatNumber(Nz(row("BaseCalcIpi"), 3), 2), 14, 0, "E", True) 'cp 18
                Linha = Linha & SChr(FormatNumber(Nz(row("ValorIpi"), 3), 2), 14, 0, "E", True) 'cp 19
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True)  'cp 20
                Linha = Linha & SChr(FormatNumber(Nz(row("IsentoIpi"), 3), 2), 14, 0, "E", True) 'cp 21
                Linha = Linha & SChr(FormatNumber(Nz(row("ValorOutrosIpi"), 3), 2), 14, 0, "E", True) 'cp 22
                Linha = Linha & SChr(FormatNumber(Nz(row("ValorCompra"), 3), 2), 14, 0, "E", True) 'cp 23

                Linha = Linha & RChr(row("FormaPagamento"), 1, 0, "E", False) 'cp 24
                Linha = Linha & SChr(row("FormaPagamento"), 2, 0, "E", True)  'cp 25

                Linha = Linha & SChr("0", 3, 0, "E", True) 'cp 26
                Linha = Linha & SChr(FormatNumber("0.00", 2), 12, 0, "E", True) 'cp 27
                Linha = Linha & SChr(FormatNumber("0.00", 2), 12, 0, "E", True) 'cp 28
                Linha = Linha & SChr(FormatNumber("0.00", 2), 12, 0, "E", True) 'cp 29
                Linha = Linha & SChr(FormatNumber("0.00", 2), 12, 0, "E", True) 'cp 30
                Linha = Linha & RChr(" ", 100, " ", "D", False) 'cp 31
                Linha = Linha & RChr(" ", 6, " ", "D", False) 'cp 32
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 33
                Linha = Linha & RChr(" ", 6, " ", "D", False) 'cp 34
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 35
                Linha = Linha & RChr(" ", 6, " ", "D", False) 'cp 36
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 37
                Linha = Linha & RChr(" ", 6, " ", "D", False) 'cp 38
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 39
                Linha = Linha & RChr(" ", 6, " ", "D", False) 'cp 40
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 41
                Linha = Linha & RChr(" ", 6, " ", "D", False) 'cp 42
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 43
                Linha = Linha & RChr(row("IncriçãoEstadual"), 18, " ", "D", False)  'cp 44
                Linha = Linha & RChr(row("Estado"), 2, " ", "D", False)  'cp 45
                Linha = Linha & RChr(" ", 1, " ", "D", False)  'cp 46
                Linha = Linha & RChr(" ", 5, 0, "E", False) 'cp 47
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 48
                Linha = Linha & RChr(" ", 1, " ", "D", False)  'cp 49
                Linha = Linha & RChr(" ", 5, 0, "E", False) 'cp 50
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 51
                Linha = Linha & RChr(" ", 5, 0, "E", False) 'cp 52
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 53
                Linha = Linha & RChr(" ", 5, 0, "E", False) 'cp 54
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 55
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 56
                Linha = Linha & RChr(" ", 3, " ", "D", False) 'cp 57
                Linha = Linha & RChr(" ", 4, " ", "D", False) 'cp 58
                Linha = Linha & RChr(" ", 6, " ", "D", False) 'cp 59
                Linha = Linha & RChr(row("Cfop"), 4, " ", "D", True)   'cp 60
                Linha = Linha & RChr(" ", 10, " ", "D", False) 'cp 61
                Linha = Linha & RChr(" ", 14, " ", "D", False) 'cp 62
                Linha = Linha & RChr(" ", 18, " ", "D", False) 'cp 63
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 64
                Linha = Linha & RChr(" ", 14, " ", "D", False) 'cp 65
                Linha = Linha & RChr(" ", 18, " ", "D", False) 'cp 66
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 67
                Linha = Linha & RChr(" ", 14, " ", "D", False) 'cp 68
                Linha = Linha & RChr(" ", 18, " ", "D", False) 'cp 69
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 70
                Linha = Linha & RChr(" ", 1, " ", "D", False) 'cp 71
                Linha = Linha & RChr(" ", 7, " ", "D", False) 'cp 72
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 73
                Linha = Linha & RChr(" ", 7, " ", "D", False) 'cp 74
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 75
                Linha = Linha & RChr(" ", 7, " ", "D", False) 'cp 76
                Linha = Linha & RChr(" ", 2, " ", "D", False)  'cp 77

                Linha = Linha & RChr(" ", 1, " ", "D", False)  'cp 78
                Linha = Linha & RChr(Nz(0, 3), 4, "0", "E", False)  'cp 79
                Linha = Linha & RChr(" ", 2, " ", "D", False)  'cp 80
                Linha = Linha & RChr("0", 14, " ", "D", False) 'cp 81
                Linha = Linha & RChr("0", 14, " ", "D", False)  'cp 82

                Linha = Linha & RChr(" ", 6, " ", "D", False)  'cp 83
                Linha = Linha & RChr("0", 1, "", "D", False)  'cp 84
                Linha = Linha & RChr(" ", 6, " ", "D", False)  'cp 85
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 86
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 87
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 88
                Linha = Linha & RChr(row("EspecieDocumento"), 5, " ", "D", False)  'cp 89
                Linha = Linha & RChr(" ", 1, " ", "D", False)  'cp 90
                Linha = Linha & RChr(row("Serie"), 3, " ", "D", False)  'cp 91
                Linha = Linha & RChr(row("SubSerie"), 2, " ", "D", False)  'cp 92
                Linha = Linha & RChr(" ", 104, " ", "D", False)  'Brancos
                Linha = Linha & RChr(row("ChaveNFe"), 44, " ", "D", False)  'Chave da NFe
                Linha = Linha & RChr(" ", 109, " ", "D", False)  'Branco
                Linha = Linha & SChr(FormatNumber(NzZero(row("ValorDesconto")), 2), 14, "0", "E", True)  '1126


                PrintLine(1, Linha)
                Linha = ""
            Catch XP As System.Exception
                MsgBox(XP.ToString)
            End Try
        Next



        FileClose(1)

        'Começa a exportaçao dos itens

        Dim Agregados As Double
        Dim VlrDiv As Double

        Linha = ""
        FileOpen(1, Me.Local.Text & "\ITEM_ENT." & Me.EmpProSoft.Text, OpenMode.Output)

        For Each row As DataRow In ds.Tables("TB").Rows
            Try
                'ValorIcmsST,ValorFreteProduto
                Agregados = CDbl(NzZero(row("ItensCompra.ValorIcmsST"))) + CDbl(NzZero(row("ValorFreteProduto"))) + CDbl(NzZero(row("vSeg"))) + CDbl(NzZero(row("vOutro"))) + NzZero(row("ItensCompra.ValorIpi"))
                VlrDiv = (Agregados / NzZero(row("Qtd")))

                Linha = Linha & RChr(row("CgcCpf"), 14, " ", "D", True) '1
                Linha = Linha & RChr(Format(CDate(row("DataEntrada")), "yyyy/MM/dd"), 8, " ", "D", True)   '15
                Linha = Linha & RChr(row("NotaFiscal"), 6, "0", "E", False) '23
                Linha = Linha & RChr("   ", 3, " ", "D", False) '29
                Linha = Linha & RChr(row("ItemDesdobramento"), 1, 0, "E", False) '32
                Linha = Linha & RChr(row("SeqNf"), 2, "0", "E", False) '33
                Linha = Linha & RChr(row("ItensCompra.CodigoProduto"), 20, " ", "D", False) '35
                Linha = Linha & RChr(row("CFOPent") & "", 4, " ", "D", True) '55
                Linha = Linha & RChr(row("UnidadeMedida"), 3, " ", "D", False) '59
                Linha = Linha & RChr(row("Produtos.Cst"), 3, "0", "E", False) '62
                Linha = Linha & SChr(FormatNumber(NzZero(row("Qtd")), 3), 14, 0, "E", True) '65
                Linha = Linha & SChr(FormatNumber(NzZero(row("ValorUnitario")) + VlrDiv, 4), 14, 0, "E", True) '79

                Dim T As Double = (NzZero(row("ValorUnitario")) + VlrDiv) * NzZero(row("Qtd")) - NzZero(row("ItensCompra.ValorDesconto")) 'Foi adicionado o desconto por causa do contador do fernando
                Linha = Linha & SChr(FormatNumber(NzZero(row("ItensCompra.ValorDesconto")), 2), 14, 0, "E", True) '93 
                Linha = Linha & SChr(FormatNumber(NzZero(T), 2), 14, 0, "E", True)  '107
                Linha = Linha & SChr(FormatNumber(0, 2), 5, 0, "E", True)  '121 NzZero(row("ItensCompra.Ipi"))
                Linha = Linha & SChr(FormatNumber(0, 2), 14, 0, "E", True)  '126 NzZero(row("ItensCompra.ValorIpi"))

                If NzZero(row("IcmsProduto")) > 0 Then
                    Linha = Linha & SChr(FormatNumber(row("ItensCompra.BaseCalcIcms"), 2), 14, 0, "E", True)  '140
                Else
                    Linha = Linha & SChr("0", 14, 0, "E", True)  '140
                End If

                Linha = Linha & SChr(FormatNumber(0, 2), 14, 0, "E", True) '154

                Linha = Linha & RChr(row("Descrição"), 80, " ", "D", False) '168
                Linha = Linha & RChr("0", 2, "0", "E", False) '248
                Linha = Linha & RChr(row("Produtos.CF"), 10, " ", "D", False) '250
                Linha = Linha & RChr(" ", 2, " ", "D", False) '260
                Linha = Linha & SChr(FormatNumber(0, 2), 5, 0, "E", True)  '262
                Linha = Linha & SChr(FormatNumber(0, 2), 5, 0, "E", True)  '267
                Linha = Linha & SChr(FormatNumber(0, 2), 14, 0, "E", True)  '272
                Linha = Linha & SChr(FormatNumber(Nz(row("Produtos.Ipi"), 3), 2), 5, 0, "E", True)  '286
                Linha = Linha & SChr("0", 2, 0, "E", True)  '291
                Linha = Linha & SChr(row("Produtos.Cst"), 3, 0, "E", True)  '293
                Linha = Linha & SChr(Mid(row("Descrição"), 1, 30), 30, " ", "E", True)  '296
                Linha = Linha & SChr(" ", 3, " ", "E", True)  '326
                Linha = Linha & SChr("S", 1, " ", "E", True)  '329
                Linha = Linha & SChr(FormatNumber(0, 2), 14, "0", "E", True)  '330

                Linha = Linha & SChr("O", 1, " ", "E", True)  '344
                Linha = Linha & SChr(FormatNumber(NzZero(row("IcmsProduto")), 2), 5, 0, "E", True)  '345
                Linha = Linha & SChr(FormatNumber(row("ValorIcmsProduto"), 2), 14, 0, "E", True)  '350
                Linha = Linha & SChr("O", 1, " ", "E", True)  '364
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  '365
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  '379
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  '393
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  '407
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  '421
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  '435
                Linha = Linha & RChr("0", 3, "0", "E", False) '449
                Linha = Linha & RChr(" ", 2, " ", "E", False) '452
                Linha = Linha & RChr(" ", 2, " ", "E", False) '454
                Linha = Linha & RChr(" ", 96, " ", "D", False) '456
                Linha = Linha & RChr(" ", 10, " ", "E", False) '552
                Linha = Linha & RChr(" ", 8, " ", "E", False) '562
                Linha = Linha & RChr(" ", 1, " ", "E", False) '570
                Linha = Linha & SChr(FormatNumber(0, 2), 14, "0", "E", True) '571
                Linha = Linha & RChr(" ", 2, " ", "E", False) '585
                Linha = Linha & RChr("1", 1, " ", "E", False) '587
                Linha = Linha & SChr(FormatNumber(0, 2), 14, "0", "E", True) '588
                Linha = Linha & SChr(FormatNumber(row("ItensCompra.ValorOutrosIcms"), 2), 14, "0", "E", True) '602
                Linha = Linha & SChr(FormatNumber(0, 2), 14, "0", "E", True) '616
                Linha = Linha & SChr(FormatNumber(0, 2), 14, "0", "E", True) '630
                Linha = Linha & RChr("0000", 4, "0", "E", False) '644
                Linha = Linha & RChr(row("ItensCompra.Serie"), 3, " ", "D", False) '648
                Linha = Linha & RChr(row("ItensCompra.SubSerie"), 2, " ", "D", False) '651
                Linha = Linha & RChr("0", 10, "0", "E", False) '653
                Linha = Linha & SChr(FormatNumber(0, 2), 14, "0", "E", True) '663
                Linha = Linha & RChr(row("IncriçãoEstadual"), 18, " ", "E", True) '677
                Linha = Linha & RChr(row("Estado"), 2, " ", "E", False) '695
                Linha = Linha & RChr(row("CSTIPIent"), 2, " ", "E", False) '697
                Linha = Linha & RChr(row("CSTPISent"), 2, " ", "E", False) '699
                Linha = Linha & RChr(row("CSTCOFINSent"), 2, " ", "E", False) '701



                Dim Brancos As String = RChr(" ", 575, " ", "D", False)
                Linha = Linha & Brancos

                Linha = Linha & SChr(FormatNumber(NzZero(row("vBCpis")), 2), 14, "0", "E", True) '1278
                Linha = Linha & SChr(FormatNumber(NzZero(row("PisProduto")), 4), 8, "0", "E", True) '1292
                Linha = Linha & SChr(FormatNumber(NzZero(row("CofinsProduto")), 4), 8, "0", "E", True) '1300
                Linha = Linha & RChr(" ", 30, " ", "E", False)
                Linha = Linha & SChr(FormatNumber(NzZero(row("ValorPisProduto")), 2), 14, "0", "E", True) '1338
                Linha = Linha & SChr(FormatNumber(NzZero(row("ValorCofinsProduto")), 2), 14, "0", "E", True) '1352
                Linha = Linha & RChr(" ", 48, " ", "E", False)

                Linha = Linha & RChr(row("CTB"), 12, " ", "E", False) '1414
                Linha = Linha & RChr(row("cstPISentr"), 2, " ", "E", False) '1426
                Linha = Linha & RChr(row("cstCOFINSentr"), 2, " ", "E", False) '1428


                PrintLine(1, Linha)
                Linha = ""
            Catch XP As System.Exception
                MsgBox(XP.Message)
            End Try
        Next
        FileClose(1)


        MsgBox("Exportação Concluida", 64, "Validação de Dados")

        daExport.Dispose()
        Cnn.Close()

    End Sub

    Public Function SChr(ByVal Vlr As Object, ByVal Tamanho As Integer, ByVal StrInserir As String, ByVal DE As String, ByVal ReplaceCh As Boolean)
        Dim StrCerta As String
        Dim StrTemp As String

        Dim L As Integer  'Variavel definida para o loop do for

        If IsDBNull(Vlr) Then
            Vlr = ""
        End If
        StrTemp = Vlr

        If ReplaceCh = True Then
            StrTemp = StrTemp.Replace(".", "")
            StrTemp = StrTemp.Replace(",", ".")
        End If

        StrCerta = Mid(StrTemp, 1, Tamanho)

        If Len(StrCerta) < Tamanho Then
            For L = 1 To (Tamanho - (Len(StrCerta)))
                If DE = "D" Then
                    StrCerta = StrCerta.Insert(Len(StrCerta), StrInserir)
                Else
                    StrCerta = StrCerta.Insert(0, StrInserir)
                End If
            Next
        End If
        Return UCase(StrCerta)
    End Function

    Public Function RChr(ByVal Vlr As Object, ByVal Tamanho As Integer, ByVal StrInserir As String, ByVal DE As String, ByVal RetiraCh As Boolean)
        Dim StrCerta As String
        Dim StrTemp As String

        Dim L As Integer  'Variavel definida para o loop do for

        If IsDBNull(Vlr) Then
            Vlr = ""
        End If

        StrTemp = Vlr

        If RetiraCh = True Then
            StrTemp = StrTemp.Replace("-", "")
            StrTemp = StrTemp.Replace("x", "")
            StrTemp = StrTemp.Replace(".", "")
            StrTemp = StrTemp.Replace("/", "")
        End If

        StrCerta = Mid(StrTemp, 1, Tamanho)

        If Len(StrCerta) < Tamanho Then
            For L = 1 To (Tamanho - (Len(StrCerta)))
                If DE = "D" Then
                    StrCerta = StrCerta.Insert(Len(StrCerta), StrInserir)
                Else
                    StrCerta = StrCerta.Insert(0, StrInserir)
                End If
            Next
        End If
        Return UCase(StrCerta)
    End Function

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged
        Me.Local.Focus()
    End Sub

    Private Sub EmpUP_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpUP.Enter
        If Me.EmpUP.Text = "" Then Me.EmpUP.Text = CodEmpresa
    End Sub

   
    Private Sub ProSoftExport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AnoInventario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AnoInventario.Validating
        If A4.Checked = True Then
            If Me.AnoInventario.Text <> "" Then
                Me.DataInicial.Text = "01/01/" & Me.AnoInventario.Text
                Me.DataFinal.Text = "31/12/" & Me.AnoInventario.Text
            End If
        End If
    End Sub
End Class