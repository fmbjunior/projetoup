Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Text
Public Class ExportaPAF3

    Private Sub btnFindFolder_Click(sender As Object, e As EventArgs) Handles btnFindFolder.Click
        Dim OpenFolder As New FolderBrowserDialog

        OpenFolder.ShowDialog()

        If OpenFolder.SelectedPath <> "" Then
            Me.txtPath.Text = OpenFolder.SelectedPath & "\"
        End If

        If Me.opt1.Checked = True Then
            Me.txtPath.Text = Me.txtPath.Text
        ElseIf Me.opt2.Checked = True Then
            Me.txtPath.Text = Me.txtPath.Text
        End If
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        If Me.opt1.Checked = True Then
            ExportCliente()
        ElseIf Me.opt2.Checked = True Then
            ExportProduto()

        End If
    End Sub
    Sub ExportCliente()
        If Me.txtPath.Text = "" Then
            MessageBox.Show("Local do Arquivo não foi selecionado", "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim oPAF As New ExporPAFCliente
        Dim conexao As OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim DR As OleDb.OleDbDataReader

        Dim fluxoTexto As StreamWriter
        Dim linhaTexto As String = ""



        Dim scon As String = New Conectar().ConectarBD(LocalBD & Nome_BD)
        conexao = New OleDbConnection(scon)
        conexao.Open()


        With cmd
            .Connection = conexao
            .CommandTimeout = 0
            .CommandText = "SELECT Clientes.Codigo,Clientes.tipoPessoa, Clientes.CpfCgc, Clientes.Nome, Clientes.RG, Clientes.Insc, Clientes.Email, Clientes.Telefone,Clientes.Telefone1, Clientes.Celular, Clientes.LimiteMensal, UF.NomeUF, Municipio.NomeMunic, Clientes.Endereço, Clientes.Nro, Clientes.Bairro, Clientes.xCpl, Clientes.Cep FROM (Clientes INNER JOIN Municipio ON Clientes.cMun = Municipio.CodMunicipio) INNER JOIN UF ON Clientes.cUF = UF.CodigoUF Where Clientes.Atualizado=True order by clientes.codigo;"
            .CommandType = CommandType.Text
        End With
        Try
            DR = cmd.ExecuteReader
            Dim contar As Integer = 1

            'faz a leitura dos dados do clientes
            While DR.Read
                If Not IsDBNull(DR.Item(0)) Then
                    oPAF.codigo = Format(DR.Item("Codigo"), "00000")
                    Dim str As String
                    str = "C" & Format(DR.Item("Codigo"), "00000") & ".txt"

                    'cria o arquivo
                    fluxoTexto = New StreamWriter(Me.txtPath.Text & str, False, Encoding.Default)


                    fluxoTexto.WriteLine(oPAF.codigo)
                    fluxoTexto.WriteLine(DR.Item("nome"))
                    If DR.Item("tipopessoa").Equals("J") Then
                        fluxoTexto.WriteLine(DR.Item("cpfcgc"))
                        fluxoTexto.WriteLine("Null")
                    Else
                        fluxoTexto.WriteLine("Null")
                        fluxoTexto.WriteLine(DR.Item("cpfcgc"))
                    End If
                    fluxoTexto.WriteLine(IIf(IsDBNull(DR.Item("insc")), "Null", DR.Item("insc")))
                    fluxoTexto.WriteLine(IIf(IsDBNull(DR.Item("RG")), "Null", DR.Item("rg")))
                    fluxoTexto.WriteLine(IIf(IsDBNull(DR.Item("nomeuf")), "Null", DR.Item("nomeuf")))
                    fluxoTexto.WriteLine(IIf(IsDBNull(DR.Item("telefone")), "Null", DR.Item("telefone")))
                    fluxoTexto.WriteLine(IIf(IsDBNull(DR.Item("tipopessoa")), "Null", DR.Item("tipopessoa")))
                    fluxoTexto.WriteLine("C")
                    fluxoTexto.WriteLine("0")
                    fluxoTexto.WriteLine("Null")
                    fluxoTexto.WriteLine("0")
                    fluxoTexto.WriteLine("0")
                    fluxoTexto.WriteLine("0")
                    fluxoTexto.WriteLine("0")
                    fluxoTexto.WriteLine(IIf(IsDBNull(DR.Item("endereço")), "Null", DR.Item("endereço")))
                    fluxoTexto.WriteLine(IIf(IsDBNull(DR.Item("bairro")), "Null", DR.Item("bairro")))
                    fluxoTexto.WriteLine(IIf(IsDBNull(DR.Item("cep")), "Null", DR.Item("cep")))
                    fluxoTexto.WriteLine(IIf(IsDBNull(DR.Item("nomemunic")), "Null", DR.Item("nomemunic")))

                    contar += 1
                    fluxoTexto.Close()
                End If


            End While
            DR.Close()

            cmd.CommandText = "UPDATE Clientes SET Clientes.Atualizado = False where clientes.Atualizado=true;"
            cmd.ExecuteNonQuery()


            MessageBox.Show("Exportação feita com sucesso", "Exportação", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

        Dim oPAF As New ExporPAFProduto
        Dim conexao As OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim DR As OleDb.OleDbDataReader
        Dim fluxoTexto As StreamWriter = Nothing

        Dim linhaTexto As String = ""

        Dim scon As String = New Conectar().ConectarBD(LocalBD & Nome_BD)
        conexao = New OleDbConnection(scon)
        conexao.Open()


        With cmd
            .Connection = conexao
            .CommandTimeout = 0
            .CommandText = "SELECT Produtos.CodigoProduto, Produtos.CodigoBarra, Produtos.Descrição, Produtos.CF, Produtos.cstcofins, Produtos.UnidadeMedida, Produtos.Icms, IcmsCST.CSTicms, Produtos.CstPis, Produtos.ValorVenda2, Produtos.ppis, Produtos.pcofins, Produtos.origemicms, Produtos.Inativo, Produtos.cst FROM Produtos INNER JOIN IcmsCST ON Produtos.Cst = IcmsCST.CSTicms WHERE (((Produtos.Inativo)=False) AND ((Produtos.Atualizado)=True));"
            .CommandType = CommandType.Text
        End With
        Try

            DR = cmd.ExecuteReader

            While DR.Read
                If Not IsDBNull(DR.Item(0)) Then

                    Try

                        Dim str As String
                        str = "E" & Format(DR.Item("CodigoProduto"), "00000000") & ".txt"

                        'cria o arquivo
                        fluxoTexto = New StreamWriter(Me.txtPath.Text & str, False, Encoding.Default)

                        fluxoTexto.WriteLine(Format(DR.Item("CodigoProduto"), "00000000")) '1 cosigo produto
                        fluxoTexto.WriteLine(DR.Item("CodigoBarra")) '2 codigo de barras
                        fluxoTexto.WriteLine("Outro") '3 padrao do codigo de barras
                        fluxoTexto.WriteLine("NULL") '4 fonte deo condigo de barras
                        fluxoTexto.WriteLine(DR.Item("Descrição")) '5 nome do produto
                        fluxoTexto.WriteLine(DR.Item("UnidadeMedida")) '6 unidade mendida
                        fluxoTexto.WriteLine("NULO") '7 fator conversao
                        fluxoTexto.WriteLine("NULL") '8 grupo de produto
                        fluxoTexto.WriteLine("0") '9 utiliza grade
                        fluxoTexto.WriteLine("NULL") '10    coluna da grade
                        fluxoTexto.WriteLine("NULL") '11     linhas da grade
                        fluxoTexto.WriteLine("NULL") '12    grade com quantidade
                        fluxoTexto.WriteLine("0") '13   quantidade
                        fluxoTexto.WriteLine("0,000") '14   preço de custo
                        fluxoTexto.WriteLine(FormatNumber(DR.Item("ValorVenda2")), 3) '15    preço de venda
                        fluxoTexto.WriteLine("0") '16 utiliza indexador de preço
                        fluxoTexto.WriteLine("NULL") '17    nome do arquivo da foto
                        '18 //situação tributaria normal, subistituiçao tributaria, isenção, não incidencia  
                        Dim ss As String = DR.Item("cst").ToString
                        Select Case DR.Item("cst").ToString
                            Case "00", "20", "101", "102"
                                fluxoTexto.WriteLine("Normal")
                            Case "10", "30", "60", "70", "90", "202", "500", "900"
                                fluxoTexto.WriteLine("Substituição tributária")
                            Case "40", "103", "400"
                                fluxoTexto.WriteLine("Isenção")
                            Case "41", "50", "51", "300"
                                fluxoTexto.WriteLine("Não incidênica")
                        End Select
                        'fim do item 18
                        fluxoTexto.WriteLine(DR.Item("icms")) '19 percentual de icms
                        fluxoTexto.WriteLine("0") '20   usa controle de nome de série
                        fluxoTexto.WriteLine(DR.Item("CstPis")) '21 sit trib pis
                        fluxoTexto.WriteLine("0,00") '22 bc pis
                        fluxoTexto.WriteLine(DR.Item("ppis")) '23 percentual pis
                        fluxoTexto.WriteLine("0,00") '24 bc pis subst. trib.
                        fluxoTexto.WriteLine("0,00") '25   percentual pis subst. trib.
                        fluxoTexto.WriteLine(DR.Item("cstcofins")) '26 sit. trib. cofins
                        fluxoTexto.WriteLine("0,00") '27   bc cofins
                        fluxoTexto.WriteLine(FormatNumber(DR.Item("pcofins")), 2) '28     percentual cofins
                        fluxoTexto.WriteLine("0,00") '29   bc cofins subst. trib
                        fluxoTexto.WriteLine("0,00") '30   percentrual cofins subt. trib
                        fluxoTexto.WriteLine(DR.Item("CF")) '31 ncmd

                        Select Case DR.Item("cst").ToString
                            Case "101", "102", "202", "300", "400", "500", "900"
                                fluxoTexto.WriteLine(DR.Item("origemicms") & "00") '32 'origem e cst
                            Case "103"
                                fluxoTexto.WriteLine(DR.Item("origemicms") & "40") '32 'origem e cst

                            Case Else
                                fluxoTexto.WriteLine(DR.Item("origemicms") & DR.Item("cst")) '32 'origem e cst
                        End Select

                        fluxoTexto.WriteLine("0") '33 tipo de proudto 0 normal ou 1 componente
                        fluxoTexto.Close()

                    Catch ex As Exception
                        fluxoTexto.Close()
                    End Try

                End If
     

            End While
        DR.Close()
        cmd.CommandText = "UPDATE Produtos SET Produtos.Atualizado = False where Produtos.Atualizado=true;"
        cmd.ExecuteNonQuery()
        MessageBox.Show("Exportação feita com sucesso", "Exportação", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class