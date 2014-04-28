Imports Microsoft.Win32
Public Class ExportaProSoft

   

  

    Private Sub NomeArquivo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles NomeArquivo.Enter
        If Me.A3.Checked = True Then
            Me.NomeArquivo.Text = "Saida." & Me.EmpProSoft.Text
        End If
        If Me.A4.Checked = True Then
            Me.NomeArquivo.Text = "Item_Sai." & Me.EmpProSoft.Text
        End If
        If Me.A5.Checked = True Then
            Me.NomeArquivo.Text = "Entrada." & Me.EmpProSoft.Text
        End If
        If Me.A6.Checked = True Then
            Me.NomeArquivo.Text = "Item_Ent." & Me.EmpProSoft.Text
        End If
        If Me.A7.Checked = True Then
            Me.NomeArquivo.Text = "Produtos." & Me.EmpProSoft.Text
        End If

    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A3.CheckedChanged, A4.CheckedChanged, A5.CheckedChanged, A6.CheckedChanged
        Me.Local.Focus()
    End Sub

    Private Sub ExportaProSoft_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()
        Me.Local.Text = "C:\Temp\"
    End Sub


#Region "Funções de Exportação"

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
        FileOpen(1, Me.Local.Text & Me.NomeArquivo.Text, OpenMode.Output)
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

    Public Sub ExFor()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        Cnn.Open()

        'Captura Qtd de Registro para definir a Barra 
        Dim CmdTotalLinhas As New OleDb.OleDbCommand("SELECT Count(*) FROM Fornecedor where RazãoSocial is not null and Inativo = false and CgcCpf is not null", Cnn)
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
            .CommandText = "SELECT * from Fornecedor where RazãoSocial is not null and Inativo = false and CgcCpf is not null"
            .CommandType = CommandType.Text
        End With

        DataReader = Cmd.ExecuteReader

        Dim Linha As String
        FileOpen(1, Me.Local.Text & Me.NomeArquivo.Text, OpenMode.Output)
        While DataReader.Read
            Try
                Dim C As String = RChr(DataReader.Item("CgcCpf"), 14, "0", "E", True)
                Dim DG As String = RChr(Mid(C, Len(C) - 1, 2), 2, " ", "D", False)

                C = Mid(C, 1, 12)

                Linha = C & DG
                Linha = Linha & RChr(DataReader.Item("RazãoSocial"), 38, " ", "D", False)
                Linha = Linha & RChr(DataReader.Item("Endereço"), 30, " ", "D", False)
                Linha = Linha & RChr(" ", 15, " ", "D", False)
                Linha = Linha & RChr(DataReader.Item("Cep"), 8, " ", "D", True)
                Linha = Linha & RChr(DataReader.Item("Cidade"), 15, " ", "D", False)
                Linha = Linha & RChr(DataReader.Item("Estado"), 2, " ", "D", False)
                Linha = Linha & RChr(DataReader.Item("Telefone1"), 15, " ", "D", True)
                Linha = Linha & RChr(DataReader.Item("IncriçãoEstadual"), 14, " ", "D", False)
                Linha = Linha & RChr(" ", 14, " ", "D", False)
                Linha = Linha & RChr("00.00", 5, " ", "D", False)
                Linha = Linha & RChr("   ", 3, " ", "D", False)
                Linha = Linha & RChr("      ", 6, " ", "D", False)
                Linha = Linha & RChr("000000", 6, " ", "D", False)
                Linha = Linha & RChr("          ", 10, " ", "D", False)
                Linha = Linha & RChr("  ", 2, " ", "D", False)

                If RChr(DataReader.Item("TipoFornecedor"), 1, "", "D", False) = "J" Then
                    Linha = Linha & RChr("0", 1, " ", "D", False)
                Else
                    Linha = Linha & RChr("1", 1, " ", "D", False)
                End If

                Linha = Linha & RChr("         ", 9, " ", "D", False)
                Linha = Linha & RChr("S", 1, " ", "D", False)
                Linha = Linha & RChr("0000", 4, " ", "D", False)
                PrintLine(1, Linha)
            Catch XP As System.Exception
                MsgBox(XP.ToString)
                MsgBox("Verique o Fornecedor : " & DataReader.Item("RazãoSocial"))
            End Try
            MyBarra.PerformStep()
        End While
        FileClose(1)

        DataReader.Close()
        Cnn.Close()

        MsgBox("Exportação Concluida", 64, "Validação de Dados")
        Me.MyBarra.Visible = False
    End Sub

    Public Sub ExNfSaida()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        Cnn.Open()

        'Captura Qtd de Registro para definir a Barra 
        Dim CmdTotalLinhas As New OleDb.OleDbCommand("SELECT Count(*) FROM NotaFiscal WHERE DataEmissao Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "# And  NotaFiscal.Cliente is not null", Cnn)
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

        Dim SQLTXT As String = "SELECT  * From NotaFiscal WHERE DataEmissao Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "# And  NotaFiscal.Cliente is not null"
        With Cmd
            .Connection = Cnn
            .CommandText = SQLTXT
            .CommandType = CommandType.Text
        End With

        DR = Cmd.ExecuteReader

        Dim Linha As String = ""
        FileOpen(1, Me.Local.Text & Me.NomeArquivo.Text, OpenMode.Output)
        While DR.Read
            Try
                Linha = Linha & RChr("NF", 3, " ", "D", False) 'cp 1
                Linha = Linha & RChr(" ", 3, " ", "D", False) 'cp 2
                Linha = Linha & RChr(DR.Item("NotaFiscal"), 6, 0, "E", False) 'cp 3
                Linha = Linha & RChr("0", 6, 0, "E", False) 'cp 4
                Linha = Linha & RChr("0", 1, " ", "D", False) 'cp 5
                Linha = Linha & RChr(Format(CDate(DR.Item("DataEmissao")), "dd/MM/yy"), 6, " ", "D", True)  'cp 6
                Linha = Linha & RChr("00000", 5, " ", "D", False) 'cp 7

                If Len(Trim$(DR.Item("NatOperação"))) = 3 Then
                    Linha = Linha & RChr(DR.Item("NatOperação"), 3, " ", "D", False) 'cp 8
                Else
                    Linha = Linha & RChr("000", 3, " ", "D", False) 'cp 8
                End If
                Linha = Linha & SChr(FormatNumber(NzNULL(DR.Item("TotalNota"), 0), 2), 14, 0, "E", True)  'cp 9
                Linha = Linha & SChr(FormatNumber(NzNULL(DR.Item("TotalProdutos"), 0), 2), 14, 0, "E", True) 'cp 10
                Linha = Linha & SChr(FormatNumber(NzNULL(DR.Item("BaseCalcIcms"), 0), 2), 14, 0, "E", True) 'cp 11
                Linha = Linha & SChr(FormatNumber(NzNULL(DR.Item("ValorIcms"), 0), 2), 14, 0, "E", True) 'cp 12
                Linha = Linha & SChr(FormatNumber(NzNULL(DR.Item("IsentoIcms"), 0), 2), 14, 0, "E", True) 'cp 13
                Linha = Linha & SChr(FormatNumber(NzNULL(DR.Item("ValorOutrosIcms"), 0), 2), 14, 0, "E", True) 'cp 14
                Linha = Linha & SChr(FormatNumber(NzNULL(DR.Item("BaseCalcIpi"), 0), 2), 14, 0, "E", True) 'cp 15
                Linha = Linha & SChr(FormatNumber(NzNULL(DR.Item("TotalIpi"), 0), 2), 14, 0, "E", True) 'cp 16
                Linha = Linha & SChr(FormatNumber(NzNULL(DR.Item("IsentoIpi"), 0), 2), 14, 0, "E", True) 'cp 17
                Linha = Linha & SChr(FormatNumber(NzNULL(DR.Item("ValorOutrosIpi"), 0), 2), 14, 0, "E", True)  'cp 18
                Linha = Linha & SChr(FormatNumber("0.00", 2), 14, 0, "E", True) 'cp 19
                Linha = Linha & RChr(DR.Item("Icms"), 5, 0, "E", False) 'cp 20
                Linha = Linha & RChr(DR.Item("FormaPagamento"), 2, 0, "E", False) 'cp 21
                Linha = Linha & RChr("000", 3, 0, "E", False) 'cp 22
                Linha = Linha & SChr(FormatNumber("0.00", 2), 14, 0, "E", True) 'cp 23
                Linha = Linha & SChr(FormatNumber("0.00", 2), 14, 0, "E", True) 'cp 24
                Linha = Linha & SChr(FormatNumber("0.00", 2), 14, 0, "E", True) 'cp 25
                Linha = Linha & SChr(FormatNumber("0.00", 2), 14, 0, "E", True) 'cp 26
                Linha = Linha & RChr(Trim$(NzNULL(DR.Item("Cnpj"), "*")), 14, 0, "E", True)  'cp 27
                Linha = Linha & RChr("00000", 5, 0, "E", False) 'cp 28
                Linha = Linha & RChr(DR.Item("Uf"), 2, " ", "D", False) 'cp 29
                Linha = Linha & RChr(" ", 10, " ", "D", False) 'cp 30
                Linha = Linha & RChr(" ", 110, " ", "D", False) 'cp 31
                Linha = Linha & RChr(" ", 1, " ", "D", False) 'cp 32
                Linha = Linha & RChr(" ", 14, " ", "E", False) 'cp 33
                Linha = Linha & RChr(" ", 18, " ", "D", False) 'cp 34
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 35
                Linha = Linha & RChr(" ", 34, " ", "D", False) 'cp 36
                Linha = Linha & RChr(" ", 14, " ", "D", False) 'cp 37
                Linha = Linha & RChr(" ", 18, " ", "D", False) 'cp 38
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 39
                Linha = Linha & RChr(" ", 34, " ", "D", False) 'cp 40
                Linha = Linha & RChr(" ", 1, " ", "D", False)  'cp 41
                Linha = Linha & RChr(" ", 6, " ", "E", False) 'cp 42
                Linha = Linha & RChr(" ", 3, " ", "D", False) 'cp 43
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 44
                Linha = Linha & RChr(" ", 3, " ", "D", False) 'cp 45
                Linha = Linha & RChr(" ", 6, " ", "D", False) 'cp 46
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 47
                Linha = Linha & RChr(" ", 14, " ", "E", True)  'cp 48
                Linha = Linha & RChr(DR.Item("FormaPagamento"), 1, 0, "E", False) 'cp 49
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 50
                Linha = Linha & RChr(" ", 6, " ", "D", False) 'cp 51
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 52
                Linha = Linha & RChr(" ", 6, " ", "D", False) 'cp 53
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 54
                Linha = Linha & RChr(" ", 6, " ", "D", False) 'cp 55
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 56
                Linha = Linha & RChr(" ", 6, " ", "D", False) 'cp 57
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 58
                Linha = Linha & RChr(" ", 6, " ", "D", False) 'cp 59
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 60
                Linha = Linha & RChr(" ", 6, " ", "D", False) 'cp 61
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 62
                Linha = Linha & RChr(" ", 1, " ", "D", False) 'cp 63
                Linha = Linha & RChr(" ", 6, " ", "D", False) 'cp 64
                Linha = Linha & RChr(" ", 11, " ", "D", False) 'cp 65
                Linha = Linha & RChr(" ", 1, " ", "D", False) 'cp 66
                Linha = Linha & RChr(" ", 3, " ", "D", False) 'cp 67
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 68
                Linha = Linha & RChr(" ", 6, " ", "D", False) 'cp 69
                Linha = Linha & RChr(Trim$(DR.Item("NatOperação")), 4, " ", "D", True)   'cp 70
                Linha = Linha & RChr("0", 3, 0, "E", False) 'cp 71
                Linha = Linha & RChr("0", 3, 0, "E", False) 'cp 72
                Linha = Linha & RChr(" ", 14, " ", "D", False) 'cp 73
                Linha = Linha & RChr(" ", 18, " ", "D", False) 'cp 74
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 75
                Linha = Linha & RChr(" ", 14, " ", "D", False) 'cp 76
                Linha = Linha & RChr(" ", 18, " ", "D", False) 'cp 77
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 78
                Linha = Linha & RChr(" ", 14, " ", "D", False) 'cp 79
                Linha = Linha & RChr(" ", 18, " ", "D", False) 'cp 80
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 81
                Linha = Linha & RChr(" ", 1, " ", "D", False) 'cp 82
                Linha = Linha & RChr(" ", 7, " ", "D", False) 'cp 83
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 84
                Linha = Linha & RChr(" ", 7, " ", "D", False) 'cp 85
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 86
                Linha = Linha & RChr(" ", 7, " ", "D", False) 'cp 87
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 88

                Linha = Linha & RChr(" ", 1, " ", "D", False) 'cp 89
                Linha = Linha & RChr(" ", 1, " ", "D", False) 'cp 90
                Linha = Linha & RChr(" ", 4, " ", "D", False) 'cp 91
                Linha = Linha & RChr(DR.Item("FormaPagamento"), 4, "0", "E", False) 'cp 92
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 93
                Linha = Linha & RChr(" ", 10, " ", "D", False) 'cp 94

                Linha = Linha & RChr(" ", 14, " ", "D", False) 'cp 95
                Linha = Linha & RChr(" ", 14, " ", "D", False) 'cp 96
                Linha = Linha & RChr(" ", 6, " ", "D", False) 'cp 97

                If DR.Item("Situaçao") = "E" Then
                    Linha = Linha & RChr("0", 6, "0", "D", False) 'cp 98
                Else
                    Linha = Linha & RChr("1", 6, "1", "D", False) 'cp 98
                End If

                PrintLine(1, Linha)
                Linha = ""
            Catch XP As System.Exception
                MsgBox(XP.ToString)
                MsgBox("Verique a Nf : " & DR.Item("NotaFiscal"))
            End Try

            MyBarra.PerformStep()
        End While
        FileClose(1)

        DR.Close()
        Cnn.Close()

        MsgBox("Exportação Concluida", 64, "Validação de Dados")
        Me.MyBarra.Visible = False
    End Sub

    Public Sub ExNfEntrada()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        'Captura Qtd de Registro para definir a Barra 
        Dim CmdTotalLinhas As New OleDb.OleDbCommand("SELECT Count(*) FROM Compra WHERE DataLançamento Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "# AND Confirmado = True And Empresa = " & Me.EmpFocus.Text & " And Inativo = False And  Tipo = 'Escrita Fiscal'", Cnn)
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

        Dim SQLTXT As String = "SELECT Compra.CompraInterno, ItensCompra.cfop, Compra.CódigoFuncionário, Compra.CódigoFornecedor, Compra.Cnpj, Compra.Inscrição, Compra.Uf, Compra.NotaFiscal, Compra.Modelo, Compra.Serie, Compra.DataCompra, Compra.DataEntrada, Compra.DataLançamento, Compra.Desdobrar, Compra.ItensDesdobramento, Compra.TipoItens, Compra.ValorDesconto, Compra.TotalProdutos, Compra.ValorIssqnRetido, Compra.ValorCompra, Compra.Icms, Compra.BaseCalcIcms, Compra.ValorIcms, Compra.IsentoIcms, Compra.ValorOutrosIcms, Compra.BaseCalcIpi, Compra.Ipi, Compra.TotalIpi, Compra.ValorOutrosIpi, Compra.IsentoIpi, Compra.Confirmado, Compra.Inativo, Compra.Empresa, Compra.ClassContabil, Compra.Tipo, Compra.PlanoContaCredito, Compra.PlanoContaDebito, Compra.FormaPagamento, Compra.Banco, Compra.DocPgtobBanco, Compra.Obs, Compra.DataLancamentoPLC, Compra.LançadoPLC, Compra.ValorFrete, Compra.LancaItens, Compra.controle FROM Compra INNER JOIN ItensCompra ON Compra.CompraInterno = ItensCompra.CompraInterno GROUP BY Compra.CompraInterno, ItensCompra.cfop, Compra.CódigoFuncionário, Compra.CódigoFornecedor, Compra.Cnpj, Compra.Inscrição, Compra.Uf, Compra.NotaFiscal, Compra.Modelo, Compra.Serie, Compra.DataCompra, Compra.DataEntrada, Compra.DataLançamento, Compra.Desdobrar, Compra.ItensDesdobramento, Compra.TipoItens, Compra.ValorDesconto, Compra.TotalProdutos, Compra.ValorIssqnRetido, Compra.ValorCompra, Compra.Icms, Compra.BaseCalcIcms, Compra.ValorIcms, Compra.IsentoIcms, Compra.ValorOutrosIcms, Compra.BaseCalcIpi, Compra.Ipi, Compra.TotalIpi, Compra.ValorOutrosIpi, Compra.IsentoIpi, Compra.Confirmado, Compra.Inativo, Compra.Empresa, Compra.ClassContabil, Compra.Tipo, Compra.PlanoContaCredito, Compra.PlanoContaDebito, Compra.FormaPagamento, Compra.Banco, Compra.DocPgtobBanco, Compra.Obs, Compra.DataLancamentoPLC, Compra.LançadoPLC, Compra.ValorFrete, Compra.LancaItens, Compra.controle HAVING (((Compra.DataLançamento) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Compra.Confirmado)=True) AND ((Compra.Inativo)=False) AND ((Compra.Empresa)=" & Me.EmpFocus.Text & ") AND ((Compra.Tipo)='Escrita Fiscal'));"
        'Dim SQLTXT As String = "SELECT  * From Compra WHERE DataLançamento Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "# AND Confirmado = True And Empresa = " & Me.EmpFocus.Text & " And Inativo = False And  Tipo = 'Escrita Fiscal'"
        With Cmd
            .Connection = Cnn
            .CommandText = SQLTXT
            .CommandType = CommandType.Text
        End With

        Cnn.Open()
        DR = Cmd.ExecuteReader
        Dim AvistaPrazo As String
        Dim Linha As String = ""
        FileOpen(1, Me.Local.Text & Me.NomeArquivo.Text, OpenMode.Output)
        While DR.Read
            Try
                Linha = Linha & RChr(" ", 4, " ", "D", False) 'cp 1
                Linha = Linha & RChr(DR.Item("Cnpj"), 14, 0, "E", True) 'cp 2
                Linha = Linha & RChr(Format(CDate(DR.Item("DataEntrada")), "dd/MM/yy"), 6, 0, "E", True) 'cp 3
                Linha = Linha & RChr(Format(CDate(DR.Item("DataCompra")), "dd/MM/yy"), 6, 0, "E", True)  'cp 4
                Linha = Linha & RChr(DR.Item("NotaFiscal"), 6, 0, "E", False) 'cp 5
                Linha = Linha & RChr("NF", 3, " ", "D", True)  'cp 6
                Linha = Linha & RChr("  ", 3, " ", "D", False) 'cp 7
                Linha = Linha & RChr("0", 1, " ", "D", False) 'cp 8
                Linha = Linha & SChr("00000", 5, 0, "E", True) 'cp 9
                Linha = Linha & SChr("000", 3, 0, "E", True) 'cp 10
                Linha = Linha & SChr(FormatNumber(Nz(DR.Item("TotalProdutos"), 3), 2), 14, 0, "E", True) 'cp 11
                Linha = Linha & SChr(FormatNumber(Nz(DR.Item("BaseCalcIcms"), 3), 2), 14, 0, "E", True) 'cp 12
                Linha = Linha & SChr(FormatNumber(Nz(DR.Item("ValorIcms"), 3), 2), 14, 0, "E", True)  'cp 13
                Linha = Linha & SChr(FormatNumber(Nz(DR.Item("IsentoIcms"), 3), 2), 14, 0, "E", True)  'cp 14
                Linha = Linha & SChr(FormatNumber(Nz(DR.Item("ValorOutrosIcms"), 3), 2), 14, 0, "E", True) 'cp 15
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 16
                Linha = Linha & SChr(FormatNumber(Nz(DR.Item("Icms"), 3), 2), 5, 0, "E", True)  'cp 17
                Linha = Linha & SChr(FormatNumber(Nz(DR.Item("BaseCalcIpi"), 3), 2), 14, 0, "E", True) 'cp 18
                Linha = Linha & SChr(FormatNumber(Nz(DR.Item("TotalIpi"), 3), 2), 14, 0, "E", True) 'cp 19
                Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True)  'cp 20
                Linha = Linha & SChr(FormatNumber(Nz(DR.Item("IsentoIpi"), 3), 2), 14, 0, "E", True) 'cp 21
                Linha = Linha & SChr(FormatNumber(Nz(DR.Item("ValorOutrosIpi"), 3), 2), 14, 0, "E", True) 'cp 22
                Linha = Linha & SChr(FormatNumber(Nz(DR.Item("ValorCompra"), 3), 2), 14, 0, "E", True) 'cp 23

                If DR.Item("FormaPagamento") = "2" Then
                    AvistaPrazo = "1"
                Else
                    AvistaPrazo = "0"
                End If

                Linha = Linha & RChr(AvistaPrazo, 1, 0, "E", False) 'cp 24
                Linha = Linha & SChr(AvistaPrazo, 2, 0, "E", True)  'cp 25

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
                Linha = Linha & RChr(DR.Item("Inscrição"), 18, " ", "D", False)  'cp 44
                Linha = Linha & RChr(DR.Item("Uf"), 2, " ", "D", False)  'cp 45
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
                Linha = Linha & RChr(DR.Item("Cfop"), 4, " ", "D", True)   'cp 60
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
                Linha = Linha & RChr(Nz(DR.Item("ClassContabil"), 3), 4, "0", "E", False)  'cp 79
                Linha = Linha & RChr(" ", 2, " ", "D", False)  'cp 80
                Linha = Linha & RChr("0", 14, " ", "D", False) 'cp 81
                Linha = Linha & RChr("0", 14, " ", "D", False)  'cp 82

                PrintLine(1, Linha)
                Linha = ""
            Catch XP As System.Exception
                MsgBox(XP.ToString)
                MsgBox("Verique a Nf : " & DR.Item("NotaFiscal"))
            End Try

            MyBarra.PerformStep()
        End While
        Me.MyBarra.Visible = False
        DR.Close()


        'Tabela de outras entradas devera ser inativada


        'Captura Qtd de Registro para definir a Barra 
        CmdTotalLinhas = New OleDb.OleDbCommand("SELECT Count(*) FROM OutrasEntradas WHERE DataCompra Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "# AND Confirmado = True And Empresa = " & Me.EmpFocus.Text & " And Inativo = False And  Tipo = 'Escrita Fiscal'", Cnn)
        TotalLinhas = 0
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

        Dim SQLStr As String = "SELECT  * From OutrasEntradas WHERE DataCompra Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "# AND Confirmado = True And Empresa = " & Me.EmpFocus.Text & " And Inativo = False And  Tipo = 'Escrita Fiscal'"
        With Cmd
            .Connection = Cnn
            .CommandText = SQLStr
            .CommandType = CommandType.Text
        End With

        DR = Cmd.ExecuteReader

        While DR.Read

            Linha = Linha & RChr(" ", 4, " ", "D", False) 'cp 1
            Linha = Linha & RChr(DR.Item("Cnpj"), 14, 0, "E", True) 'cp 2
            Linha = Linha & RChr(Format(CDate(DR.Item("DataCompra")), "dd/MM/yy"), 6, 0, "E", True) 'cp 3
            Linha = Linha & RChr(Format(CDate(DR.Item("DataCompra")), "dd/MM/yy"), 6, 0, "E", True)  'cp 4
            Linha = Linha & RChr(DR.Item("NotaFiscal"), 6, 0, "E", False) 'cp 5
            Linha = Linha & RChr("NF", 3, " ", "D", True)  'cp 6
            Linha = Linha & RChr("UN", 3, " ", "D", False) 'cp 7
            Linha = Linha & RChr("0", 1, " ", "D", False) 'cp 8
            Linha = Linha & SChr("00000", 5, 0, "E", True) 'cp 9
            Linha = Linha & SChr("000", 3, 0, "E", True) 'cp 10
            Linha = Linha & SChr(FormatNumber(DR.Item("TotalProdutos"), 2), 14, 0, "E", True) 'cp 11
            Linha = Linha & SChr(FormatNumber(DR.Item("BaseCalcIcms"), 2), 14, 0, "E", True) 'cp 12
            Linha = Linha & SChr(FormatNumber(DR.Item("ValorIcms"), 2), 14, 0, "E", True)  'cp 13
            Linha = Linha & SChr(FormatNumber(DR.Item("IsentoIcms"), 2), 14, 0, "E", True)  'cp 14
            Linha = Linha & SChr(FormatNumber(DR.Item("ValorOutrosIcms"), 2), 14, 0, "E", True) 'cp 15
            Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 16
            Linha = Linha & SChr(FormatNumber(DR.Item("Icms"), 2), 5, 0, "E", True) 'cp 17
            Linha = Linha & SChr(FormatNumber(DR.Item("BaseCalcIpi"), 2), 14, 0, "E", True)  'cp 18
            Linha = Linha & SChr(FormatNumber(DR.Item("TotalIpi"), 2), 14, 0, "E", True) 'cp 19
            Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True)  'cp 20
            Linha = Linha & SChr(FormatNumber(DR.Item("IsentoIpi"), 2), 14, 0, "E", True) 'cp 21
            Linha = Linha & SChr(FormatNumber(DR.Item("ValorOutrosIpi"), 2), 14, 0, "E", True) 'cp 22
            Linha = Linha & SChr(FormatNumber(DR.Item("ValorCompra"), 2), 14, 0, "E", True) 'cp 23
            Linha = Linha & RChr("0", 1, 0, "E", False) 'cp 24
            Linha = Linha & SChr("0", 2, 0, "E", True) 'cp 25
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
            Linha = Linha & RChr(DR.Item("Inscrição"), 18, " ", "D", False)  'cp 44
            Linha = Linha & RChr(DR.Item("Uf"), 2, " ", "D", False)  'cp 45
            Linha = Linha & RChr(" ", 1, " ", "D", False)  'cp 46
            Linha = Linha & RChr(" ", 5, 0, "E", False) 'cp 47
            Linha = Linha & SChr(FormatNumber("00.00", 2), 14, 0, "E", True) 'cp 48
            Linha = Linha & RChr(DR.Item("FormaPagamento"), 1, " ", "D", False)  'cp 49
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
            Linha = Linha & RChr(DR.Item("Cfop"), 4, " ", "D", True)   'cp 60
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
            Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 77

            PrintLine(1, Linha)
            Linha = ""
            MyBarra.PerformStep()
        End While

        FileClose(1)

        DR.Close()
        Cnn.Close()

        MsgBox("Exportação Concluida", 64, "Validação de Dados")
        Me.MyBarra.Visible = False
    End Sub

    Public Sub ExItEntrada()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader
        Cnn.Open()

        'Captura Qtd de Registro para definir a Barra 
        Dim CmdTotalLinhas As New OleDb.OleDbCommand("SELECT Count(ItensCompra.CodigoProduto) AS ContarDeCodigoProduto FROM Produtos INNER JOIN (Compra INNER JOIN ItensCompra ON Compra.CompraInterno = ItensCompra.CompraInterno) ON Produtos.CodigoProduto = ItensCompra.CodigoProduto WHERE (((Compra.DataLançamento) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Compra.Confirmado)=True) AND ((Compra.CódigoFornecedor) Is Not Null) AND ((Compra.Tipo)='Escrita Fiscal'));", Cnn)
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


        Dim Sqltxt As String = "SELECT Produtos.Cst, Produtos.Ipi, Produtos.Icms, Produtos.CF, Produtos.Descrição, Produtos.UnidadeMedida, Compra.Cfop, Compra.Serie, Compra.DataCompra, Compra.Confirmado, Compra.CódigoFornecedor, Compra.NotaFiscal, Compra.Uf, Compra.Cnpj, Compra.Inscrição, Compra.Tipo, Compra.DataLançamento, Compra.DataEntrada, ItensCompra.Id, ItensCompra.CompraInterno, ItensCompra.CodigoProduto, ItensCompra.Qtd, ItensCompra.ValorUnitario, ItensCompra.TotalProduto, Compra.Icms, Compra.ValorIcms, ItensCompra.Ipi, ItensCompra.ValorIpi, ItensCompra.Cst, ItensCompra.Cf, ItensCompra.SeqNf, ItensCompra.ValorDesconto FROM Produtos INNER JOIN (Compra INNER JOIN ItensCompra ON Compra.CompraInterno = ItensCompra.CompraInterno) ON Produtos.CodigoProduto = ItensCompra.CodigoProduto WHERE (((Compra.DataLançamento) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Compra.Confirmado)= True ) AND ((Compra.CódigoFornecedor) Is Not Null) AND ((Compra.Tipo)= 'Escrita Fiscal'));"
        With Cmd
            .Connection = Cnn
            .CommandText = Sqltxt
            .CommandType = CommandType.Text
        End With

        DR = Cmd.ExecuteReader

        Dim Linha As String = ""
        FileOpen(1, Me.Local.Text & Me.NomeArquivo.Text, OpenMode.Output)
        While DR.Read
            Try
                Linha = Linha & RChr(DR.Item("Cnpj"), 14, " ", "D", True) 'cp 1
                Linha = Linha & RChr(Format(CDate(DR.Item("DataEntrada")), "yyyy/MM/dd"), 8, " ", "D", True)   'cp 2
                Linha = Linha & RChr(DR.Item("NotaFiscal"), 6, "0", "E", False) 'cp 3
                Linha = Linha & RChr(" ", 3, " ", "D", False) 'cp 4
                Linha = Linha & RChr("0", 1, 0, "E", False) 'cp 5
                Linha = Linha & RChr(DR.Item("SeqNf"), 2, "0", "E", False) 'cp 6
                Linha = Linha & RChr(DR.Item("CodigoProduto"), 20, " ", "D", False) 'cp 7
                Linha = Linha & RChr(DR.Item("Cfop"), 4, " ", "D", True) 'cp 8
                'Linha = Linha & RChr(" ", 1, " ", "D", False) 'cp 9 Campo retirado por estar imbutido no campo 8
                Linha = Linha & RChr(DR.Item("UnidadeMedida"), 3, " ", "D", False) 'cp 10
                Linha = Linha & RChr(DR.Item("Produtos.Cst"), 3, "0", "E", False) 'cp 11
                Linha = Linha & SChr(FormatNumber(NzZero(DR.Item("Qtd")), 3), 14, 0, "E", True) 'cp 12
                Linha = Linha & SChr(FormatNumber(NzZero(DR.Item("ValorUnitario")), 4), 14, 0, "E", True) 'cp 13
                Linha = Linha & SChr(FormatNumber(NzZero(DR.Item("ValorDesconto")), 2), 14, 0, "E", True) 'cp 14
                Linha = Linha & SChr(FormatNumber(NzZero(DR.Item("TotalProduto")), 2), 14, 0, "E", True)  'cp 15
                Linha = Linha & SChr(FormatNumber(NzZero(DR.Item("ItensCompra.Ipi")), 2), 5, 0, "E", True)  'cp 16
                Linha = Linha & SChr(FormatNumber(NzZero(DR.Item("ValorIpi")), 2), 14, 0, "E", True)  'cp 17

                If DR.Item("Compra.Icms") > 0 Then
                    Linha = Linha & SChr(FormatNumber(DR.Item("TotalProduto"), 2), 14, 0, "E", True)  'cp 18
                Else
                    Linha = Linha & SChr("0", 14, 0, "E", True)  'cp 18
                End If

                Linha = Linha & SChr(FormatNumber(0, 2), 14, 0, "E", True) 'cp 19

                Linha = Linha & RChr(DR.Item("Descrição"), 80, " ", "D", False) 'cp 20
                Linha = Linha & RChr("0", 2, "0", "E", False) 'cp 21
                Linha = Linha & RChr(DR.Item("Produtos.CF"), 10, " ", "D", False) 'cp 22
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 23
                Linha = Linha & SChr(FormatNumber(0, 2), 5, 0, "E", True)  'cp 24
                Linha = Linha & SChr(FormatNumber(0, 2), 5, 0, "E", True)  'cp 25
                Linha = Linha & SChr(FormatNumber(0, 2), 14, 0, "E", True)  'cp 26
                Linha = Linha & SChr(FormatNumber(Nz(DR.Item("Produtos.Ipi"), 3), 2), 5, 0, "E", True)  'cp 27
                Linha = Linha & SChr("0", 2, 0, "E", True)  'cp 28
                Linha = Linha & SChr(DR.Item("Produtos.Cst"), 3, 0, "E", True)  'cp 29
                Linha = Linha & SChr(Mid(DR.Item("Descrição"), 1, 30), 30, " ", "E", True)  'cp 30
                Linha = Linha & SChr(" ", 3, " ", "E", True)  'cp 31
                Linha = Linha & SChr("S", 1, " ", "E", True)  'cp 32
                Linha = Linha & SChr(FormatNumber(0, 2), 14, "0", "E", True)  'cp 33 usado para base de calculo do Ipi

                Linha = Linha & SChr("O", 1, " ", "E", True)  'cp 34
                Linha = Linha & SChr(FormatNumber(DR.Item("Compra.Icms"), 2), 5, 0, "E", True)  'cp 35
                Linha = Linha & SChr(FormatNumber(DR.Item("ValorIcms"), 2), 14, 0, "E", True)  'cp 36
                Linha = Linha & SChr("O", 1, " ", "E", True)  'cp 37
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  'cp 38
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  'cp 39
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  'cp 40
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  'cp 41
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  'cp 42
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  'cp 43
                Linha = Linha & RChr("0", 3, "0", "E", False) 'cp 44
                Linha = Linha & RChr(" ", 2, " ", "E", False) 'cp 45
                Linha = Linha & RChr(" ", 2, " ", "E", False) 'cp 46
                Linha = Linha & RChr(" ", 96, " ", "D", False) 'cp 47
                Linha = Linha & RChr(" ", 10, " ", "E", False) 'cp 48
                Linha = Linha & RChr(" ", 8, " ", "E", False) 'cp 49
                Linha = Linha & RChr(" ", 1, " ", "E", False) 'cp 50
                Linha = Linha & RChr(FormatNumber(0, 2), 14, "0", "E", False) 'cp 51
                Linha = Linha & RChr(" ", 2, " ", "E", False) 'cp 52
                Linha = Linha & RChr("1", 1, " ", "E", False) 'cp 53
                Linha = Linha & RChr(FormatNumber(0, 2), 14, "0", "E", False) 'cp 54
                Linha = Linha & RChr(FormatNumber(0, 2), 14, "0", "E", False) 'cp 55
                Linha = Linha & RChr(FormatNumber(0, 2), 14, "0", "E", False) 'cp 56
                Linha = Linha & RChr(FormatNumber(0, 2), 14, "0", "E", False) 'cp 57
                Linha = Linha & RChr("0000", 4, "0", "E", False) 'cp 58
                Linha = Linha & RChr(" ", 3, " ", "E", False) 'cp 59
                Linha = Linha & RChr(" ", 2, " ", "E", False) 'cp 60
                Linha = Linha & RChr("0", 10, "0", "E", False) 'cp 61
                Linha = Linha & RChr(FormatNumber(0, 2), 14, "0", "E", False) 'cp 62
                Linha = Linha & RChr(DR.Item("Inscrição"), 18, " ", "E", True) 'cp 63
                Linha = Linha & RChr(DR.Item("UF"), 2, " ", "E", False) 'cp 64

                PrintLine(1, Linha)
                Linha = ""
            Catch XP As System.Exception
                MsgBox(XP.Message)
                MsgBox("Verique o Item com Id : " & DR.Item("Id"))
            End Try

            MyBarra.PerformStep()
        End While

        Me.MyBarra.Visible = False
        DR.Close()

        'Aqui deve ser inserido os itens 2

        'Captura Qtd de Registro para definir a Barra 
        CmdTotalLinhas = New OleDb.OleDbCommand("SELECT Count(ItensCompraMateriaPrima.CodigoMateriaPrima) AS ContarDeCodigoMateriaPrima FROM MateriaPrima INNER JOIN (ItensCompraMateriaPrima INNER JOIN Compra ON ItensCompraMateriaPrima.CompraInterno = Compra.CompraInterno) ON MateriaPrima.Codigo = ItensCompraMateriaPrima.CodigoMateriaPrima WHERE (((Compra.DataLançamento) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Compra.Confirmado)=True) AND ((Compra.CódigoFornecedor) Is Not Null) AND ((Compra.Tipo)='Escrita Fiscal'));", Cnn)
        TotalLinhas = 0
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
            .CommandText = "SELECT MateriaPrima.Cst, MateriaPrima.CF, MateriaPrima.MateriaPrima, MateriaPrima.UnidadeMedida, Compra.Cfop, Compra.Serie, Compra.DataCompra, Compra.Confirmado, Compra.CódigoFornecedor, Compra.NotaFiscal, Compra.Cnpj, Compra.Tipo, ItensCompraMateriaPrima.Id, ItensCompraMateriaPrima.CompraInterno, ItensCompraMateriaPrima.CodigoMateriaPrima, ItensCompraMateriaPrima.Qtd, ItensCompraMateriaPrima.ValorUnitario, ItensCompraMateriaPrima.TotalProduto, Compra.Icms, Compra.ValorIcms, ItensCompraMateriaPrima.Ipi, ItensCompraMateriaPrima.ValorIpi, ItensCompraMateriaPrima.Cst, ItensCompraMateriaPrima.Cf, ItensCompraMateriaPrima.SeqNf, ItensCompraMateriaPrima.ValorDesconto FROM MateriaPrima INNER JOIN (ItensCompraMateriaPrima INNER JOIN Compra ON ItensCompraMateriaPrima.CompraInterno = Compra.CompraInterno) ON MateriaPrima.Codigo = ItensCompraMateriaPrima.CodigoMateriaPrima WHERE (((Compra.DataLançamento) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((Compra.Confirmado)=True) AND ((Compra.CódigoFornecedor) Is Not Null) AND ((Compra.Tipo)='Escrita Fiscal'));"
            .CommandType = CommandType.Text
        End With

        Try
            DR = Cmd.ExecuteReader
        Catch a As Exception
            MsgBox(a.Message)
        End Try

        While DR.Read
            Try
                Linha = Linha & RChr(DR.Item("Cnpj"), 14, " ", "D", True) 'cp 1
                Linha = Linha & RChr(Format(CDate(DR.Item("DataCompra")), "yyyy/MM/dd"), 8, " ", "D", True)   'cp 2
                Linha = Linha & RChr(DR.Item("NotaFiscal"), 6, "0", "E", False) 'cp 3
                Linha = Linha & RChr(DR.Item("Serie"), 3, " ", "D", False) 'cp 4
                Linha = Linha & RChr("0", 1, 0, "E", False) 'cp 5
                Linha = Linha & RChr(DR.Item("SeqNf"), 2, "0", "E", False) 'cp 6
                Linha = Linha & RChr(DR.Item("CodigoMateriaPrima"), 20, " ", "D", False) 'cp 7
                Linha = Linha & RChr(DR.Item("Cfop"), 4, " ", "D", True) 'cp 8
                'Linha = Linha & RChr(" ", 1, " ", "D", False) 'cp 9 Campo retirado por estar imbutido no campo 8
                Linha = Linha & RChr(DR.Item("UnidadeMedida"), 3, " ", "D", False) 'cp 10
                Linha = Linha & RChr(DR.Item("MateriaPrima.Cst"), 3, "0", "D", False) 'cp 11
                Linha = Linha & SChr(FormatNumber(DR.Item("Qtd"), 3), 14, 0, "E", True) 'cp 12
                Linha = Linha & SChr(FormatNumber(DR.Item("ValorUnitario"), 3), 14, 0, "E", True) 'cp 13
                Linha = Linha & SChr(FormatNumber(DR.Item("ValorDesconto"), 2), 14, 0, "E", True) 'cp 14
                Linha = Linha & SChr(FormatNumber(DR.Item("TotalProduto"), 2), 14, 0, "E", True)  'cp 15
                Linha = Linha & SChr(FormatNumber(DR.Item("Ipi"), 2), 5, 0, "E", True)  'cp 16
                Linha = Linha & SChr(FormatNumber(DR.Item("ValorIpi"), 2), 14, 0, "E", True) 'cp 17
                If DR.Item("Icms") > 0 Then
                    Linha = Linha & SChr(FormatNumber(DR.Item("TotalProduto"), 2), 14, 0, "E", True) 'cp 18
                Else
                    Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True) 'cp 18
                End If
                Linha = Linha & SChr(FormatNumber(0, 2), 14, 0, "E", True) 'cp 19

                Linha = Linha & RChr(DR.Item("MateriaPrima"), 80, " ", "D", False) 'cp 20
                Linha = Linha & RChr("0", 2, "0", "E", False) 'cp 21
                Linha = Linha & RChr(DR.Item("MateriaPrima.CF"), 10, " ", "D", False) 'cp 22
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 23
                Linha = Linha & SChr(FormatNumber(0, 2), 5, 0, "E", True)  'cp 24
                Linha = Linha & SChr(FormatNumber(0, 2), 5, 0, "E", True)  'cp 25
                Linha = Linha & SChr(FormatNumber(0, 2), 14, 0, "E", True)  'cp 26
                Linha = Linha & SChr(FormatNumber(DR.Item("Ipi"), 2), 5, 0, "E", True)  'cp 27
                Linha = Linha & SChr("0", 2, 0, "E", True)  'cp 28
                Linha = Linha & SChr(DR.Item("MateriaPrima.Cst"), 3, 0, "E", True)  'cp 29
                Linha = Linha & SChr(" ", 30, " ", "E", True)  'cp 30
                Linha = Linha & SChr(" ", 3, " ", "E", True)  'cp 31
                Linha = Linha & SChr(" ", 1, " ", "E", True)  'cp 32
                Linha = Linha & SChr(FormatNumber(0, 2), 14, "0", "E", True)  'cp 33
                Linha = Linha & SChr("T", 1, " ", "E", True)  'cp 34
                Linha = Linha & SChr(FormatNumber(DR.Item("Icms"), 2), 5, 0, "E", True)  'cp 35
                Linha = Linha & SChr(FormatNumber(DR.Item("ValorIcms"), 2), 14, 0, "E", True)  'cp 36
                Linha = Linha & SChr("T", 1, " ", "E", True)  'cp 37
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  'cp 38
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  'cp 39
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  'cp 40
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  'cp 41
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  'cp 42
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  'cp 43
                Linha = Linha & RChr("0", 3, "0", "E", False) 'cp 44
                Linha = Linha & RChr(" ", 100, " ", "E", False) 'cp 45
                Linha = Linha & RChr(" ", 10, " ", "E", False) 'cp 46
                Linha = Linha & RChr(" ", 8, " ", "E", False) 'cp 47
                Linha = Linha & RChr(" ", 1, " ", "E", False) 'cp 48
                Linha = Linha & RChr(" ", 14, " ", "E", False) 'cp 49

                PrintLine(1, Linha)
                Linha = ""
            Catch XP As System.Exception
                MsgBox(XP.ToString)
                MsgBox("Verique a Nf : " & DR.Item("NotaFiscal"))
            End Try

            MyBarra.PerformStep()
        End While

        FileClose(1)

        DR.Close()
        Cnn.Close()

        MsgBox("Exportação Concluida", 64, "Validação de Dados")
        Me.MyBarra.Visible = False
    End Sub

    Public Sub ExItSaida()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader
        Cnn.Open()

        'Captura Qtd de Registro para definir a Barra 
        Dim CmdTotalLinhas As New OleDb.OleDbCommand("SELECT Count(NotaFiscalItens.Produto) AS ContarDeProduto FROM Produtos INNER JOIN (NotaFiscal INNER JOIN NotaFiscalItens ON NotaFiscal.NotaFiscal = NotaFiscalItens.NotaFiscal) ON Produtos.CodigoProduto = NotaFiscalItens.Produto WHERE (((NotaFiscal.DataEmissao) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((NotaFiscal.Situaçao)='E') AND ((NotaFiscal.Cliente) Is Not Null));", Cnn)
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

        Dim Sqltxt As String = "SELECT Produtos.Cst, Produtos.Ipi, Produtos.Icms, Produtos.CF, Produtos.Descrição, Produtos.UnidadeMedida, NotaFiscal.NatOperação, NotaFiscal.Serie, NotaFiscal.DataEmissao, NotaFiscal.Situaçao, NotaFiscal.Icms,NotaFiscal.Cliente, NotaFiscalItens.Id, NotaFiscalItens.NotaFiscal, NotaFiscalItens.Pedido, NotaFiscalItens.Produto, NotaFiscalItens.Descricao, NotaFiscalItens.Qtd, NotaFiscalItens.Unitario, NotaFiscalItens.ValorTotal, NotaFiscalItens.Icms, NotaFiscalItens.ValorIcms, NotaFiscalItens.Ipi, NotaFiscalItens.ValorIpi, NotaFiscalItens.Cst, NotaFiscalItens.Cf, NotaFiscalItens.SeqNf, NotaFiscalItens.ValorDesconto FROM Produtos INNER JOIN (NotaFiscal INNER JOIN NotaFiscalItens ON NotaFiscal.NotaFiscal = NotaFiscalItens.NotaFiscal) ON Produtos.CodigoProduto = NotaFiscalItens.Produto WHERE (((NotaFiscal.DataEmissao) Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "#) AND ((NotaFiscal.Situaçao)='E') AND ((NotaFiscal.Cliente) Is Not Null));"
        With Cmd
            .Connection = Cnn
            .CommandText = Sqltxt
            .CommandType = CommandType.Text
        End With

        DR = Cmd.ExecuteReader

        Dim Linha As String = ""
        FileOpen(1, Me.Local.Text & Me.NomeArquivo.Text, OpenMode.Output)
        While DR.Read
            Try
                Linha = Linha & RChr(" ", 14, " ", "E", False) 'cp 1
                Linha = Linha & RChr(Format(CDate(DR.Item("DataEmissao")), "yyyy/MM/dd"), 8, " ", "D", True)   'cp 2
                Linha = Linha & RChr(DR.Item("NotaFiscal"), 6, "0", "E", False) 'cp 3
                Linha = Linha & RChr(" ", 3, " ", "D", False) 'cp 4
                Linha = Linha & RChr("0", 1, 0, "E", False) 'cp 5
                Linha = Linha & RChr(DR.Item("SeqNf"), 2, "0", "E", False) 'cp 6
                Linha = Linha & RChr(DR.Item("Produto"), 20, " ", "D", False) 'cp 7
                Linha = Linha & RChr(DR.Item("NatOperação"), 4, " ", "D", True) 'cp 8
                'Linha = Linha & RChr(" ", 1, " ", "D", False) 'cp 9 Campo retirado por estar imbutido no campo 8
                Linha = Linha & RChr(DR.Item("UnidadeMedida"), 3, " ", "D", False) 'cp 10
                Linha = Linha & RChr(DR.Item("Produtos.Cst"), 3, "0", "E", False) 'cp 11
                Linha = Linha & SChr(FormatNumber(NzNULL(DR.Item("Qtd"), 0), 3), 14, 0, "E", True) 'cp 12
                Linha = Linha & SChr(FormatNumber(NzNULL(DR.Item("Unitario"), 0), 2), 14, 0, "E", True) 'cp 13
                Linha = Linha & SChr(FormatNumber(NzNULL(DR.Item("ValorDesconto"), 0), 2), 14, 0, "E", True) 'cp 14
                Linha = Linha & SChr(FormatNumber(NzNULL(DR.Item("ValorTotal"), 0), 2), 14, 0, "E", True) 'cp 15
                Linha = Linha & SChr(FormatNumber(NzNULL(DR.Item("NotaFiscalItens.Ipi"), 0), 2), 5, 0, "E", True) 'cp 16
                Linha = Linha & SChr(FormatNumber(NzNULL(DR.Item("ValorIpi"), 0), 2), 14, 0, "E", True) 'cp 17

                If DR.Item("NotaFiscal.Icms") > 0 Then
                    Linha = Linha & SChr(FormatNumber(NzNULL(DR.Item("ValorTotal"), 0), 2), 14, 0, "E", True) 'cp 18
                Else
                    Linha = Linha & SChr(FormatNumber(NzNULL("0", 0), 2), 14, 0, "E", True) 'cp 18
                End If

                Linha = Linha & SChr(FormatNumber(0, 2), 14, 0, "E", True) 'cp 19

                Linha = Linha & RChr(DR.Item("Descrição"), 80, " ", "D", False) 'cp 20
                Linha = Linha & RChr("0", 2, "0", "E", False) 'cp 21
                Linha = Linha & RChr(DR.Item("Produtos.CF"), 10, " ", "D", False) 'cp 22
                Linha = Linha & RChr(" ", 2, " ", "D", False) 'cp 23
                Linha = Linha & SChr(FormatNumber(0, 2), 5, 0, "E", True)  'cp 24
                Linha = Linha & SChr(FormatNumber(0, 2), 5, 0, "E", True)  'cp 25
                Linha = Linha & SChr(FormatNumber(0, 2), 14, 0, "E", True)  'cp 26
                Linha = Linha & SChr(FormatNumber(NzNULL(DR.Item("Produtos.Ipi"), 0), 2), 5, 0, "E", True)  'cp 27
                Linha = Linha & SChr("0", 2, 0, "E", True)  'cp 28
                Linha = Linha & SChr(DR.Item("Produtos.Cst"), 3, 0, "E", True)  'cp 29
                Linha = Linha & SChr(" ", 30, " ", "E", True)  'cp 30
                Linha = Linha & SChr(" ", 3, " ", "E", True)  'cp 31
                Linha = Linha & SChr(" ", 1, " ", "E", True)  'cp 32
                Linha = Linha & SChr(FormatNumber(0, 2), 14, "0", "E", True)  'cp 33
                Linha = Linha & SChr("T", 1, " ", "E", True)  'cp 34

                Linha = Linha & SChr(FormatNumber(NzNULL(DR.Item("NotaFiscal.Icms"), 0), 2), 5, 0, "E", True)  'cp 35

                Linha = Linha & SChr(FormatNumber(NzNULL(DR.Item("ValorIcms"), 0), 2), 14, 0, "E", True) 'cp 36
                Linha = Linha & SChr("T", 1, " ", "E", True)  'cp 37
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  'cp 38
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  'cp 39
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  'cp 40
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  'cp 41
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  'cp 42
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  'cp 43
                Linha = Linha & RChr("0", 3, "0", "E", False) 'cp 44

                Linha = Linha & RChr("0", 2, "0", "E", False) 'cp 45
                Linha = Linha & RChr("0", 2, "0", "E", False) 'cp 46
                Linha = Linha & RChr("0", 56, "0", "E", False) 'cp 47
                Linha = Linha & RChr(" ", 14, " ", "E", False) 'cp 48
                Linha = Linha & RChr(" ", 10, " ", "E", False) 'cp 49
                Linha = Linha & RChr("0", 2, "0", "E", False) 'cp 50
                Linha = Linha & RChr("1", 1, "0", "E", False) 'cp 51

                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  'cp 52
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  'cp 53
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  'cp 54
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  'cp 55

                Linha = Linha & RChr("0", 4, "0", "E", False) 'cp 56
                Linha = Linha & RChr(" ", 3, " ", "E", False) 'cp 57
                Linha = Linha & RChr(" ", 2, " ", "E", False) 'cp 58
                Linha = Linha & RChr("0", 10, "0", "E", False) 'cp 59
                Linha = Linha & SChr(FormatNumber("0", 2), 14, 0, "E", True)  'cp 60

                PrintLine(1, Linha)
                Linha = ""

                MyBarra.PerformStep()
            Catch XP As System.Exception
                MsgBox(XP.ToString)
                MsgBox("Verique a Nf : " & DR.Item("NotaFiscal"))
            End Try
        End While
        FileClose(1)

        DR.Close()
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
        FileOpen(1, Me.Local.Text & Me.NomeArquivo.Text, OpenMode.Output)
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
                Linha = Linha & RChr(FormatNumber(0, 4), 8, "0", "E", False) ' Campo 38

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

    Public Function NzNULL(ByVal Vlr As Object, ByVal ValorIfNullo As Object)
        If Vlr Is Nothing Or Vlr Is System.DBNull.Value Then
            Vlr = ValorIfNullo
        End If
        Return Vlr
    End Function

#End Region

    Private Sub EmpProSoft_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles EmpProSoft.Leave
        Me.EmpProSoft.Text = SChr(Me.EmpProSoft.Text, 3, "0", "E", True)
    End Sub


    Private Sub Degrade()
        Try

            Dim Key As RegistryKey = Registry.LocalMachine
            Dim PegaKeyPadrão As RegistryKey = Key.OpenSubKey("Software\\UPTema\\Tema")

            Cor1TelaPrimaria = PegaKeyPadrão.GetValue("Cor1TelaPrimaria", " ")
            Cor2TelaPrimaria = PegaKeyPadrão.GetValue("Cor2TelaPrimaria", " ")

            Cor1TelaSecundaria = PegaKeyPadrão.GetValue("Cor1TelaSecundaria", " ")
            Cor2TelaSecundaria = PegaKeyPadrão.GetValue("Cor2TelaSecundaria", " ")


            Dim CCor() As String
            Dim corTemp As String

            corTemp = Cor1TelaPrimaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))

            corTemp = Cor2TelaPrimaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btGerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGerar.Click
        If Me.A1.Checked = True Then
            If Me.Local.Text = "" Then
                MsgBox("Favor informar o drive e local a ser gravado o arquivo.", 64, "Exportação")
                Me.Local.Focus()
                Exit Sub
            ElseIf Me.EmpFocus.Text = "" Then
                MsgBox("Favor informar o Código da empresa no FOCUS.", 64, "Exportação")
                Me.EmpFocus.Focus()
                Exit Sub
            ElseIf Me.EmpProSoft.Text = "" Then
                MsgBox("Favor informar o Código da empresa no ProSoft.", 64, "Exportação")
                Me.EmpProSoft.Focus()
                Exit Sub
            ElseIf Me.NomeArquivo.Text = "" Then
                MsgBox("Favor informar o Nome do arquivo a ser gravado.", 64, "Exportação")
                Me.NomeArquivo.Focus()
                Exit Sub
            End If
            ExTerceiros()
        End If

        If Me.A3.Checked = True Then
            If Me.Local.Text = "" Then
                MsgBox("Favor informar o drive e local a ser gravado o arquivo.", 64, "Exportação")
                Me.Local.Focus()
                Exit Sub
            ElseIf Me.EmpFocus.Text = "" Then
                MsgBox("Favor informar o Código da empresa no FOCUS.", 64, "Exportação")
                Me.EmpFocus.Focus()
                Exit Sub
            ElseIf Me.EmpProSoft.Text = "" Then
                MsgBox("Favor informar o Código da empresa no ProSoft.", 64, "Exportação")
                Me.EmpProSoft.Focus()
                Exit Sub
            ElseIf Me.NomeArquivo.Text = "" Then
                MsgBox("Favor informar o Nome do arquivo a ser gravado.", 64, "Exportação")
                Me.NomeArquivo.Focus()
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
            ExNfSaida()
        End If

        If Me.A4.Checked = True Then
            If Me.Local.Text = "" Then
                MsgBox("Favor informar o drive e local a ser gravado o arquivo.", 64, "Exportação")
                Me.Local.Focus()
                Exit Sub
            ElseIf Me.EmpFocus.Text = "" Then
                MsgBox("Favor informar o Código da empresa no FOCUS.", 64, "Exportação")
                Me.EmpFocus.Focus()
                Exit Sub
            ElseIf Me.EmpProSoft.Text = "" Then
                MsgBox("Favor informar o Código da empresa no ProSoft.", 64, "Exportação")
                Me.EmpProSoft.Focus()
                Exit Sub
            ElseIf Me.NomeArquivo.Text = "" Then
                MsgBox("Favor informar o Nome do arquivo a ser gravado.", 64, "Exportação")
                Me.NomeArquivo.Focus()
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
            ExItSaida()
        End If

        If Me.A5.Checked = True Then
            If Me.Local.Text = "" Then
                MsgBox("Favor informar o drive e local a ser gravado o arquivo.", 64, "Exportação")
                Me.Local.Focus()
                Exit Sub
            ElseIf Me.EmpFocus.Text = "" Then
                MsgBox("Favor informar o Código da empresa no FOCUS.", 64, "Exportação")
                Me.EmpFocus.Focus()
                Exit Sub
            ElseIf Me.EmpProSoft.Text = "" Then
                MsgBox("Favor informar o Código da empresa no ProSoft.", 64, "Exportação")
                Me.EmpProSoft.Focus()
                Exit Sub
            ElseIf Me.NomeArquivo.Text = "" Then
                MsgBox("Favor informar o Nome do arquivo a ser gravado.", 64, "Exportação")
                Me.NomeArquivo.Focus()
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
            ExNfEntrada()
        End If

        If Me.A6.Checked = True Then
            If Me.Local.Text = "" Then
                MsgBox("Favor informar o drive e local a ser gravado o arquivo.", 64, "Exportação")
                Me.Local.Focus()
                Exit Sub
            ElseIf Me.EmpFocus.Text = "" Then
                MsgBox("Favor informar o Código da empresa no FOCUS.", 64, "Exportação")
                Me.EmpFocus.Focus()
                Exit Sub
            ElseIf Me.EmpProSoft.Text = "" Then
                MsgBox("Favor informar o Código da empresa no ProSoft.", 64, "Exportação")
                Me.EmpProSoft.Focus()
                Exit Sub
            ElseIf Me.NomeArquivo.Text = "" Then
                MsgBox("Favor informar o Nome do arquivo a ser gravado.", 64, "Exportação")
                Me.NomeArquivo.Focus()
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
            ExItEntrada()
        End If


        If Me.A7.Checked = True Then
            If Me.Local.Text = "" Then
                MsgBox("Favor informar o drive e local a ser gravado o arquivo.", 64, "Exportação")
                Me.Local.Focus()
                Exit Sub
            ElseIf Me.EmpFocus.Text = "" Then
                MsgBox("Favor informar o Código da empresa no FOCUS.", 64, "Exportação")
                Me.EmpFocus.Focus()
                Exit Sub
            ElseIf Me.EmpProSoft.Text = "" Then
                MsgBox("Favor informar o Código da empresa no ProSoft.", 64, "Exportação")
                Me.EmpProSoft.Focus()
                Exit Sub
            ElseIf Me.NomeArquivo.Text = "" Then
                MsgBox("Favor informar o Nome do arquivo a ser gravado.", 64, "Exportação")
                Me.NomeArquivo.Focus()
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
            ExProdutos()
        End If

    End Sub
End Class