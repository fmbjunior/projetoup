Imports System.IO
Module Geral

    'Cria uma nova data set.
    Public Dst As New DataSet()

    Public TamanhoTela As Rectangle  'Pegar o tamanho da tela
    Public ClienteConsumidor As Integer

    Public pcName As String 'Vareável para armazernar o nome do PC, usando nos rodapés dos relatórios.
    Public FormName As String
    Public DirRelat As String
    Public CmdLine As String
    'Public "Validação de Dados" As String
    Public LocalBD As String
    Public Nome_BD As String
    Public LocalDBNFe As String 'Armazena o local do banco de dados da nfe
    Public SenhaBancoDados As String
    Public CaminhoLog As String
    Public DataDia As Date
    Public CodEmpresa As Integer
    Public NomEmpresa As String
    Public TSesquema As Boolean

    Public DescontoGerencia As Double
    Public Var_EnterCodBarra As Boolean
    Public VAR_ContaCrVenda As String

    Public MesAnoCompetencia As String = ""
    Public CidadeEmpresa As String
    Public RelatorioCarregar As String
    Public TipoItensProcurar As Integer

    Public ReciboAVista As Boolean
    Public VlrMinFat As Double
    Public SomenteEvento As String
    Public UserAtivo As String
    Public VarCodFunc As Integer
    Public VarNomFunc As String
    Public GerarXmlPedido As Boolean
    Public AnoContabel As String
    Public Liberado As Boolean
    Public CaixaAtivo As String
    Public CaixaDeMovimento As String 'Utilizado para saber qual o caixa de movimento 
    Public CaixaNomeVar As String
    Public VarDesmenbrarEntrada As Boolean

    Public VenderEstoqueNegativo As Boolean
    Public ParcFixo As Boolean
    Public RetornoCodSegurança As String 'Usada para retornar o codigo de segurança

    Public EmitirDpPedido As Boolean
    Public ModeloDuplicata As String
    Public ValidadeOrcamento As Integer
    Public NaoValidarDocumento As Boolean
    Public UsarGrade As Boolean
    Public UsarServico As Boolean
    Public mMenuCarregar As String

    ''' <summary>Usado para guardar o valor do percentual do issqn</summary>
    Public vISSQN As Double = 0

    Public Vendedor_Fecha_Pedido As Boolean
    Public UsaSellShoes As Boolean

    ''' <summary>Usado para receber o Dia do Vencimento configurado na Empresa</summary>
    Public DiaFechamentoMensal As Integer = 0

    ''' <summary>Usando para Indicar se a Empresa tem Pedido de MATERIA PRIMA</summary>  ''' <remarks>Retorna um valor boolan  </remarks>
    Public UsaMateriaPrima As Boolean = False

    ''' <summary>Esta variavel recebera o Valor P para comissao Por produto e V para comissao por Vendedor</summary>
    Public TipoComissaoVenda As String ' Usada para verificar o tipo de Comissao de venda
    Public CodLancamentoReceber As String 'Usada para pegar a conta de lancamento para gerar no contas a receber
    ''' <summary>Usado para pegar a versao do sistemas</summary>
    Public verVersao As String

    ''' <summary>Usando para armazenar o tipo de Acesso nas Telas do ShellShoes, Manual ou por Leitor </summary>
    Public Manual As Boolean = False
    Public Leitor As Boolean = False


    'Variavel para contas de Balancete
    Public cbVendaVista As String 'Pega a conta de Balancete a vista no cadastro da empresa
    '***************************************

    Public DiaFechado As Boolean
    Public LocalAtualização As String
    Public EntrarAchandoPedido As Boolean = False
    Public NotaFiscalAvulsa As Boolean = False
    Public IsentaDeIpi As Boolean = False
    Public CaixaFechado As Boolean
    Public CfopPadrão As String
    'Public UsaMenuReceber As String
    Public UsarBarraAviso As String
    'Public ControlaEstoqueNegativo As Boolean

    Public HistoricoDocumentos As String
    Public LegendaHistoricoDocumento As String

    Public DescontoEmLinha As Boolean = False
    Public UserDoCaixa As String = ""
    Public RetornoPlanoContasProcura As Integer = 0 '0-ContaReduzida 1-ContaAnalitica


    'arrays
    Public SnhArray As New ArrayList
    Public MnsArray As New ArrayList

    Public UFArray As New ArrayList
    Public IpiArray As New ArrayList
    Public PisArray As New ArrayList
    Public CofinsCSTArray As New ArrayList
    Public OrigemIcmsArray As New ArrayList
    Public IcmsModalidadeBCArray As New ArrayList
    Public IcmsArray As New ArrayList





    'cores do sistema
    Public Cor1Menu As String
    Public Cor2Menu As String
    Public Cor1TelaPrimaria As String
    Public Cor2TelaPrimaria As String
    Public Cor1TelaSecundaria As String
    Public Cor2TelaSecundaria As String
    'dim das cores

#Region "Variaveis para impressão de Nota Fiscal"
    Public ImpressPadrão As String
    Public NomeFormulario As String
#End Region

#Region "Variaveis para popular Lista de Procura"
    Public Coluna1 As String
    Public Coluna2 As String
    Public Coluna3 As String
    Public TableProcura As String
    Public CpFind As String
    Public CpReturn As String
    Public CpColuna3 As String
    Public RetornoProcura As String
    Public MultiEmpresa As Boolean
#End Region

    Public Sub DesbloquearTextBox(ByVal root As Control, ByVal TrueFalse As Boolean)
        For Each ctrl As Control In root.Controls
            DesbloquearTextBox(ctrl, TrueFalse)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Enabled = TrueFalse
            End If
            If TypeOf ctrl Is CBOAutoCompleteFocus.CboFocus Then
                CType(ctrl, CBOAutoCompleteFocus.CboFocus).Enabled = TrueFalse
            End If

            If TypeOf ctrl Is DevComponents.DotNetBar.Controls.CheckBoxX Then
                CType(ctrl, DevComponents.DotNetBar.Controls.CheckBoxX).Enabled = TrueFalse
            End If

        Next (ctrl)
    End Sub

    Public Function Nz(ByVal Vlr As Object, ByRef UmNullDoisVazioTresZero As Object)
        Dim Ret As Object = ""
        Try
            If UmNullDoisVazioTresZero = 1 Then
                Ret = IIf(IsDBNull(Vlr) Or Vlr = "" Or Vlr = " ", System.DBNull.Value, Vlr)
            End If
            If UmNullDoisVazioTresZero = 2 Then
                Ret = IIf(IsDBNull(Vlr), "", Vlr)
            End If
            If UmNullDoisVazioTresZero = 3 Then
                Ret = IIf(IsDBNull(Vlr), 0, Vlr)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Ret
    End Function

    Public Function CaixaMovimentoEstaFechado() As Boolean
        If CaixaDeMovimento = "" Then
            Return True
            Exit Function
        End If

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "Select * from CaixaDia where CaixaCod = '" & CaixaDeMovimento & "' And DataCaixaDia = #" & Format(CDate(DataDia), "MM/dd/yyyy") & "#"
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            If DR.Item("Fechado") = True Then
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If
        Cnn.Close()

    End Function

    Public Function NzVlr(ByVal Vlr As Object)
        Dim Ret As Object = System.DBNull.Value

        Try
            
            If TypeOf Vlr Is Double Then
                Ret = IIf(IsDBNull(Vlr), CDbl(0), Vlr)
            End If
            If TypeOf Vlr Is Decimal Then
                Ret = IIf(IsDBNull(Vlr), CDec(0), Vlr)
            End If
            If TypeOf Vlr Is String Then
                Ret = IIf(IsDBNull(Vlr) Or Vlr = "" Or Vlr = " ", System.DBNull.Value, Vlr)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Ret
    End Function

    Public Function NzZero(ByVal Vlr As Object)

        Dim Ret As Object = 0

        Try

            If TypeOf Vlr Is Integer Then
                Ret = IIf(IsDBNull(Vlr), CDbl(0), Vlr)
            End If
            If TypeOf Vlr Is Double Then
                Ret = IIf(IsDBNull(Vlr), CDbl(0), Vlr)
            End If
            If TypeOf Vlr Is Decimal Then
                Ret = IIf(IsDBNull(Vlr), CDec(0), Vlr)
            End If
            If TypeOf Vlr Is String Then
                Ret = IIf(IsDBNull(Vlr) Or Vlr = "" Or Vlr = " ", 0, Vlr)
            End If
            If TypeOf Vlr Is DBNull Then
                Ret = 0
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Ret
    End Function

    Public Function Direita(ByVal Txt As String, ByVal Qtd As Integer) As String
        Dim TLetras As Integer

        TLetras = Len(Txt)
        Direita = Mid(Txt, (TLetras - Qtd + 1), Qtd)

        Return Direita
    End Function

    Public Sub ChamaTelaProcura(ByVal Coluna_1 As String, ByVal Coluna_2 As String, ByVal Coluna_3 As String, ByVal Tabela As String, ByVal Cp_Chave As String, ByVal Cp_Procura As String, ByVal Cp_Coluna3 As String, ByVal MEmpresa As Boolean)
        Coluna1 = Coluna_1
        Coluna2 = Coluna_2
        Coluna3 = Coluna_3
        TableProcura = Tabela
        CpFind = Cp_Chave
        CpReturn = Cp_Procura
        CpColuna3 = Cp_Coluna3
        MultiEmpresa = MEmpresa
        My.Forms.TelaProcura.ShowDialog()
    End Sub

    Public Sub ChamaTelaString(ByVal Coluna_1 As String, ByVal Coluna_2 As String, ByVal Coluna_3 As String, ByVal StringTabela As String, ByVal CampoProcura As String, ByVal CampoRetorno As String, ByVal cp_Col3 As String)
        Coluna1 = Coluna_1
        Coluna2 = Coluna_2
        Coluna3 = Coluna_3
        TableProcura = StringTabela
        CpFind = CampoProcura
        CpReturn = CampoRetorno
        CpColuna3 = cp_Col3
        My.Forms.TelaProcuraString.ShowDialog()
    End Sub

    Public Sub AbreTelaHistLançamento(ByVal Legenda As String, ByVal Hist As String)
        LegendaHistoricoDocumento = Legenda
        HistoricoDocumentos = Hist
        My.Forms.HistoricosLançamentos.ShowDialog()
    End Sub

    Public Sub AtualizarSystem()
        Dim ArquivoExiste As String = Dir(Application.StartupPath & "\Ver.Txt", FileAttribute.Archive)
        Dim ArquivoExisteAt As String = Dir(LocalAtualização & "\Ver.Txt", FileAttribute.Archive)

        Dim VerAtualizar As String = ""
        Dim VerAtual As String = ""

        If ArquivoExisteAt <> "" Then
            FileOpen(1, LocalAtualização & "\Ver.Txt", OpenMode.Input)
            Do While Not EOF(1)
                Input(1, VerAtualizar)
            Loop
            FileClose(1)
        Else
            Exit Sub
        End If

        If ArquivoExiste <> "" Then
            FileOpen(1, Application.StartupPath & "\Ver.Txt", OpenMode.Input)
            Do While Not EOF(1)
                Input(1, VerAtual)
            Loop
            FileClose(1)
        Else
            Exit Sub
        End If

        If VerAtual <> VerAtualizar Then
            If MsgBox("Existe uma versão nova do sistema na rede, deseja atualizar ?", 36, "Validação de Dados") = 6 Then
                'Chama rotina de atualização e fecha o sistema
                'E-FocusAtualizar
                Shell(Application.StartupPath & "\E-FocusAtualizar.exe", AppWinStyle.NormalFocus, False)
                End
            Else
                Exit Sub
            End If
        End If

    End Sub

    Public Function RetornaValorComboBox(ByVal Controle As ComboBox) As Object
        If Controle.Text = "" Then
            Return 0
        Else
            Return NzZero(Controle.SelectedValue)
        End If
    End Function

    Function ChecaInscrE(pUF, pInscr)
        ChecaInscrE = False
        Dim strBase
        Dim strBase2
        Dim strOrigem
        Dim strDigito1
        Dim strDigito2
        Dim intPos
        Dim intValor
        Dim intSoma
        Dim intResto
        Dim intNumero
        Dim intPeso
        Dim intDig
        strBase = ""
        strBase2 = ""
        strOrigem = ""

        Dim ds
        Dim d01
        Dim d02
        Dim d03
        Dim d04
        Dim d05
        Dim d06
        Dim d07
        Dim d08
        Dim d09
        Dim d10
        Dim d11
        Dim d12
        Dim d13
        Dim dv01
        Dim dv02
        Dim dfinal

        Dim Aux1
        Dim Aux2
        ' Dim Aux3

        Dim digVerificador
        Dim digverificador1
        Dim digverificador2
        Dim resto_do_calculo

        If Trim(pInscr) = "ISENTO" Or Trim(pInscr) = "EX" Then
            ChecaInscrE = True
            Exit Function
        End If
        For intPos = 1 To Len(Trim(pInscr))
            If Instr(1, "0123456789P", Mid(pInscr, intPos, 1), vbTextCompare) > 0 Then
                strOrigem = strOrigem & Mid(pInscr, intPos, 1)
            End If
        Next
        Select Case pUF
            Case "AC" 'Acre 
                strBase = Left(Trim(strOrigem) & "000000000", 13)
                d01 = CInt(mid(strBase, 1, 1))
                d02 = CInt(mid(strBase, 2, 1))
                d03 = CInt(mid(strBase, 3, 1))
                d04 = CInt(mid(strBase, 4, 1))
                d05 = CInt(mid(strBase, 5, 1))
                d06 = CInt(mid(strBase, 6, 1))
                d07 = CInt(mid(strBase, 7, 1))
                d08 = CInt(mid(strBase, 8, 1))
                d09 = CInt(mid(strBase, 9, 1))
                d10 = CInt(mid(strBase, 10, 1))
                d11 = CInt(mid(strBase, 11, 1))
                dv01 = CInt(mid(strBase, 12, 1))
                dv02 = CInt(mid(strBase, 13, 1))

                If d01 <> 0 Or d02 <> 1 Then
                    ChecaInscrE = False
                    Exit Function
                End If
                ds = 4 * d01 + 3 * d02 + 2 * d03 + 9 * d04 + 8 * d05 + 7 * d06 + 6 * d07 + 5 * d08 + _
                                   4 * d09 + 3 * d10 + 2 * d11
                aux1 = Fix(ds / 11)
                aux1 = aux1 * 11
                aux2 = ds - aux1 ' aux2 é o resto, ou mod
                digverificador1 = 11 - aux2
                If digverificador1 = 10 Or digverificador1 = 11 Then
                    digverificador1 = 0 'primeiro digito
                End If
                ds = 5 * d01 + 4 * d02 + 3 * d03 + 2 * d04 + 9 * d05 + 8 * d06 + 7 * d07 + 6 * d08 + _
                                   5 * d09 + 4 * d10 + 3 * d11 + 2 * digverificador1
                aux1 = Fix(ds / 11)
                aux1 = aux1 * 11
                aux2 = ds - aux1 ' aux2 é o resto, ou mod
                digverificador2 = 11 - aux2
                If digverificador2 = 10 Or digverificador2 = 11 Then
                    digverificador2 = 0 'primeiro digito
                End If
                If digverificador1 = dv01 And digverificador2 = dv02 Then
                    ChecaInscrE = True
                End If
            Case "AL" ' Alagoas 
                strBase = Left(Trim(strOrigem) & "000000000", 9)
                If Left(strBase, 2) = "24" Then
                    intSoma = 0
                    For intPos = 1 To 8
                        intValor = CInt(Mid(strBase, intPos, 1))
                        intValor = intValor * (10 - intPos)
                        intSoma = intSoma + intValor
                    Next
                    intSoma = intSoma * 10
                    intResto = intSoma Mod 11
                    strDigito1 = Right(IIf(intResto = 10, "0", CStr(intResto)), 1)
                    strBase2 = Left(strBase, 8) & strDigito1
                    If strBase2 = strOrigem Then
                        ChecaInscrE = True
                    End If
                End If
            Case "AM" ' Amazonas 
                strBase = Left(Trim(strOrigem) & "000000000", 9)
                intSoma = 0
                For intPos = 1 To 8
                    intValor = CInt(Mid(strBase, intPos, 1))
                    intValor = intValor * (10 - intPos)
                    intSoma = intSoma + intValor
                Next
                If intSoma < 11 Then
                    strDigito1 = Right(CStr(11 - intSoma), 1)
                Else
                    intResto = intSoma Mod 11
                    strDigito1 = Right(IIf(intResto < 2, "0", CStr(11 - intResto)), 1)
                End If
                strBase2 = Left(strBase, 8) & strDigito1
                If strBase2 = strOrigem Then
                    ChecaInscrE = True
                End If
            Case "AP" ' Amapa 
                strBase = Left(Trim(strOrigem) & "000000000", 9)
                intPeso = 0
                intDig = 0
                If Left(strBase, 2) = "03" Then
                    intNumero = Fix(Left(strBase, 8))
                    If intNumero >= 3000001 And intNumero <= 3017000 Then
                        intPeso = 5
                        intDig = 0
                    ElseIf intNumero >= 3017001 And intNumero <= 3019022 Then
                        intPeso = 9
                        intDig = 1
                    ElseIf intNumero >= 3019023 Then
                        intPeso = 0
                        intDig = 0
                    End If
                    intSoma = intPeso
                    For intPos = 1 To 8
                        intValor = CInt(Mid(strBase, intPos, 1))
                        intValor = intValor * (10 - intPos)
                        intSoma = intSoma + intValor
                    Next
                    intResto = intSoma Mod 11
                    intValor = 11 - intResto
                    If intValor = 10 Then
                        intValor = 0
                    ElseIf intValor = 11 Then
                        intValor = intDig
                    End If
                    strDigito1 = Right(CStr(intValor), 1)
                    strBase2 = Left(strBase, 8) & strDigito1
                    If strBase2 = strOrigem Then
                        ChecaInscrE = True
                    End If
                End If
            Case "BA" ' Bahia 
                strBase = Left(Trim(strOrigem) & "00000000", 8)
                If Instr(1, "0123458", Left(strBase, 1), vbTextCompare) > 0 Then
                    intSoma = 0
                    For intPos = 1 To 6
                        intValor = CInt(Mid(strBase, intPos, 1))
                        intValor = intValor * (8 - intPos)
                        intSoma = intSoma + intValor
                    Next
                    intResto = intSoma Mod 10
                    strDigito2 = Right(IIf(intResto = 0, "0", CStr(10 - intResto)), 1)
                    strBase2 = Left(strBase, 6) & strDigito2
                    intSoma = 0
                    For intPos = 1 To 7
                        intValor = CInt(Mid(strBase2, intPos, 1))
                        intValor = intValor * (9 - intPos)
                        intSoma = intSoma + intValor
                    Next
                    intResto = intSoma Mod 10
                    strDigito1 = Right(IIf(intResto = 0, "0", CStr(10 - intResto)), 1)
                Else
                    intSoma = 0
                    For intPos = 1 To 6
                        intValor = CInt(Mid(strBase, intPos, 1))
                        intValor = intValor * (8 - intPos)
                        intSoma = intSoma + intValor
                    Next
                    intResto = intSoma Mod 11
                    strDigito2 = Right(IIf(intResto < 2, "0", CStr(11 - intResto)), 1)
                    strBase2 = Left(strBase, 6) & strDigito2
                    intSoma = 0
                    For intPos = 1 To 7
                        intValor = CInt(Mid(strBase2, intPos, 1))
                        intValor = intValor * (9 - intPos)
                        intSoma = intSoma + intValor
                    Next
                    intResto = intSoma Mod 11
                    strDigito1 = Right(IIf(intResto < 2, "0", CStr(11 - intResto)), 1)
                End If
                strBase2 = Left(strBase, 6) & strDigito1 & strDigito2
                If strBase2 = strOrigem Then
                    ChecaInscrE = True
                End If
            Case "CE" ' Ceara 
                strBase = Left(Trim(strOrigem) & "000000000", 9)
                intSoma = 0
                For intPos = 1 To 8
                    intValor = CInt(Mid(strBase, intPos, 1))
                    intValor = intValor * (10 - intPos)
                    intSoma = intSoma + intValor
                Next
                intResto = intSoma Mod 11
                intValor = 11 - intResto
                If intValor > 9 Then
                    intValor = 0
                End If
                strDigito1 = Right(CStr(intValor), 1)
                strBase2 = Left(strBase, 8) & strDigito1
                If strBase2 = strOrigem Then
                    ChecaInscrE = True
                End If
            Case "DF" ' Distrito Federal 
                strBase = Left(Trim(strOrigem) & "0000000000000", 13)
                If Left(strBase, 3) = "073" Then
                    intSoma = 0
                    intPeso = 2
                    For intPos = 11 To 1 Step -1
                        intValor = CInt(Mid(strBase, intPos, 1))
                        intValor = intValor * intPeso
                        intSoma = intSoma + intValor
                        intPeso = intPeso + 1
                        If intPeso > 9 Then
                            intPeso = 2
                        End If
                    Next
                    intResto = intSoma Mod 11
                    strDigito1 = Right(IIf(intResto < 2, "0", CStr(11 - intResto)), 1)
                    strBase2 = Left(strBase, 11) & strDigito1
                    intSoma = 0
                    intPeso = 2
                    For intPos = 12 To 1 Step -1
                        intValor = CInt(Mid(strBase, intPos, 1))
                        intValor = intValor * intPeso
                        intSoma = intSoma + intValor
                        intPeso = intPeso + 1
                        If intPeso > 9 Then
                            intPeso = 2
                        End If
                    Next
                    intResto = intSoma Mod 11
                    strDigito2 = Right(IIf(intResto < 2, "0", CStr(11 - intResto)), 1)
                    strBase2 = Left(strBase, 12) & strDigito2
                    If strBase2 = strOrigem Then
                        ChecaInscrE = True
                    End If
                End If
            Case "ES" ' Espirito Santo 
                strBase = Left(Trim(strOrigem) & "000000000", 9)
                intSoma = 0
                For intPos = 1 To 8
                    intValor = CInt(Mid(strBase, intPos, 1))
                    intValor = intValor * (10 - intPos)
                    intSoma = intSoma + intValor
                Next
                intResto = intSoma Mod 11
                strDigito1 = Right(IIf(intResto < 2, "0", CStr(11 - intResto)), 1)
                strBase2 = Left(strBase, 8) & strDigito1
                If strBase2 = strOrigem Then
                    ChecaInscrE = True
                End If
            Case "GO" ' Goias 
                strBase = Left(Trim(strOrigem) & "000000000", 9)
                If Instr(1, "10,11,15", Left(strBase, 2), vbTextCompare) > 0 Then
                    intSoma = 0
                    For intPos = 1 To 8
                        intValor = CInt(Mid(strBase, intPos, 1))
                        intValor = intValor * (10 - intPos)
                        intSoma = intSoma + intValor
                    Next
                    intResto = intSoma Mod 11
                    If intResto = 0 Then
                        strDigito1 = "0"
                    ElseIf intResto = 1 Then
                        intNumero = CInt(Left(strBase, 8))
                        strDigito1 = Right(IIf(intNumero >= 10103105 And intNumero <= 10119997, "1", "0"), 1)
                    Else
                        strDigito1 = Right(CStr(11 - intResto), 1)
                    End If
                    strBase2 = Left(strBase, 8) & strDigito1
                    If strBase2 = strOrigem Then
                        ChecaInscrE = True
                    End If
                End If
            Case "MA" ' Maranhão 
                strBase = Left(Trim(strOrigem) & "000000000", 9)
                If Left(strBase, 2) = "12" Then
                    intSoma = 0
                    For intPos = 1 To 8
                        intValor = CInt(Mid(strBase, intPos, 1))
                        intValor = intValor * (10 - intPos)
                        intSoma = intSoma + intValor
                    Next
                    intResto = intSoma Mod 11
                    strDigito1 = Right(IIf(intResto < 2, "0", CStr(11 - intResto)), 1)
                    strBase2 = Left(strBase, 8) & strDigito1
                    If strBase2 = strOrigem Then
                        ChecaInscrE = True
                    End If
                End If
            Case "MT" ' Mato Grosso 
                While len(strOrigem) < 11
                    strOrigem = "0" & strOrigem
                End While
                strBase = Left(Trim(strOrigem) & "000000000", 11)
                d01 = CInt(Mid(strBase, 1, 1))
                d02 = CInt(Mid(strBase, 2, 1))
                d03 = CInt(Mid(strBase, 3, 1))
                d04 = CInt(Mid(strBase, 4, 1))
                d05 = CInt(Mid(strBase, 5, 1))
                d06 = CInt(Mid(strBase, 6, 1))
                d07 = CInt(Mid(strBase, 7, 1))
                d08 = CInt(Mid(strBase, 8, 1))
                d09 = CInt(Mid(strBase, 9, 1))
                d10 = CInt(Mid(strBase, 10, 1))
                dfinal = CInt(Mid(strBase, 11, 1))
                ds = 3 * d01 + 2 * d02 + 9 * d03 + 8 * d04 + 7 * d05 + 6 * d06 + 5 * d07 + 4 * d08 + 3 * d09 + 2 * d10
                aux1 = Fix(ds / 11)
                aux1 = aux1 * 11
                aux2 = ds - aux1
                If aux2 = 0 Or aux2 = 1 Then
                    digVerificador = 0
                Else
                    digVerificador = 11 - aux2
                End If
                If dfinal = digVerificador Then
                    ChecaInscrE = True
                End If
            Case "MS" ' Mato Grosso do Sul 
                strBase = Left(Trim(strOrigem) & "000000000", 9)
                If Left(strBase, 2) = "28" Then
                    intSoma = 0
                    For intPos = 1 To 8
                        intValor = CInt(Mid(strBase, intPos, 1))
                        intValor = intValor * (10 - intPos)
                        intSoma = intSoma + intValor
                    Next
                    intResto = intSoma Mod 11
                    strDigito1 = Right(IIf(intResto < 2, "0", CStr(11 - intResto)), 1)
                    strBase2 = Left(strBase, 8) & strDigito1
                    If strBase2 = strOrigem Then
                        ChecaInscrE = True
                    End If
                End If
            Case "MG" ' Minas Gerais, aki onde tem FormatNumber ante era format 
                intSoma = 0
                strBase = Left(Trim(strOrigem) & "0000000000000", 13)
                strBase2 = Left(strBase, 3) & "0" & Mid(strBase, 4, 8)
                intNumero = 2
                For intPos = 1 To 12
                    intValor = CInt(Mid(strBase2, intPos, 1))
                    intNumero = IIf(intNumero = 2, 1, 2)
                    intValor = intValor * intNumero
                    If intValor > 9 Then
                        strDigito1 = FormatNumber(intValor, "00")
                        intValor = CInt(Left(strDigito1, 1)) + CInt(Right(strDigito1, 1))
                    End If
                    intSoma = intSoma + intValor
                Next
                intValor = intSoma
                While Right(FormatNumber(intValor, "000"), 1) <> "0"
                    intValor = intValor + 1
                End While
                strDigito1 = Right(FormatNumber(intValor - intSoma, "00"), 1)
                strBase2 = Left(strBase, 11) & strDigito1
                intSoma = 0
                intPeso = 2
                For intPos = 12 To 1 Step -1
                    intValor = CInt(Mid(strBase2, intPos, 1))
                    intValor = intValor * intPeso
                    intSoma = intSoma + intValor
                    intPeso = intPeso + 1
                    If intPeso > 11 Then
                        intPeso = 2
                    End If
                Next
                intResto = intSoma Mod 11
                strDigito2 = Right(IIf(intResto < 2, "0", CStr(11 - intResto)), 1)
                strBase2 = strBase2 & strDigito2
                If strBase2 = strOrigem Then
                    ChecaInscrE = True
                End If
            Case "PA" ' Para 
                strBase = Left(Trim(strOrigem) & "000000000", 9)
                If Left(strBase, 2) = "15" Then
                    intSoma = 0
                    For intPos = 1 To 8
                        intValor = CInt(Mid(strBase, intPos, 1))
                        intValor = intValor * (10 - intPos)
                        intSoma = intSoma + intValor
                    Next
                    intResto = intSoma Mod 11
                    strDigito1 = Right(IIf(intResto < 2, "0", CStr(11 - intResto)), 1)
                    strBase2 = Left(strBase, 8) & strDigito1
                    If strBase2 = strOrigem Then
                        ChecaInscrE = True
                    End If
                End If
            Case "PB" ' Paraiba 
                strBase = Left(Trim(strOrigem) & "000000000", 9)
                intSoma = 0
                For intPos = 1 To 8
                    intValor = CInt(Mid(strBase, intPos, 1))
                    intValor = intValor * (10 - intPos)
                    intSoma = intSoma + intValor
                Next
                intResto = intSoma Mod 11
                intValor = 11 - intResto
                If intValor > 9 Then
                    intValor = 0
                End If
                strDigito1 = Right(CStr(intValor), 1)
                strBase2 = Left(strBase, 8) & strDigito1
                If strBase2 = strOrigem Then
                    ChecaInscrE = True
                End If
            Case "PE" ' Pernambuco 
                strBase = Left(Trim(strOrigem) & "00000000000000", 14)
                intSoma = 0
                intPeso = 2
                For intPos = 13 To 1 Step -1
                    intValor = CInt(Mid(strBase, intPos, 1))
                    intValor = intValor * intPeso
                    intSoma = intSoma + intValor
                    intPeso = intPeso + 1
                    If intPeso > 9 Then
                        intPeso = 1
                    End If
                Next
                intResto = intSoma Mod 11
                intValor = 11 - intResto
                If intValor > 9 Then
                    intValor = intValor - 10
                End If
                strDigito1 = Right(CStr(intValor), 1)
                strBase2 = Left(strBase, 13) & strDigito1
                If strBase2 = strOrigem Then
                    ChecaInscrE = True
                End If
            Case "PI" ' Piaui 
                strBase = Left(Trim(strOrigem) & "000000000", 9)
                intSoma = 0
                For intPos = 1 To 8
                    intValor = CInt(Mid(strBase, intPos, 1))
                    intValor = intValor * (10 - intPos)
                    intSoma = intSoma + intValor
                Next
                intResto = intSoma Mod 11
                strDigito1 = Right(IIf(intResto < 2, "0", CStr(11 - intResto)), 1)
                strBase2 = Left(strBase, 8) & strDigito1
                If strBase2 = strOrigem Then
                    ChecaInscrE = True
                End If
            Case "PR" ' Parana 
                strBase = Left(Trim(strOrigem) & "0000000000", 10)
                intSoma = 0
                intPeso = 2
                For intPos = 8 To 1 Step -1
                    intValor = CInt(Mid(strBase, intPos, 1))
                    intValor = intValor * intPeso
                    intSoma = intSoma + intValor
                    intPeso = intPeso + 1
                    If intPeso > 7 Then
                        intPeso = 2
                    End If
                Next
                intResto = intSoma Mod 11
                strDigito1 = Right(IIf(intResto < 2, "0", CStr(11 - intResto)), 1)
                strBase2 = Left(strBase, 8) & strDigito1
                intSoma = 0
                intPeso = 2
                For intPos = 9 To 1 Step -1
                    intValor = CInt(Mid(strBase2, intPos, 1))
                    intValor = intValor * intPeso
                    intSoma = intSoma + intValor
                    intPeso = intPeso + 1
                    If intPeso > 7 Then
                        intPeso = 2
                    End If
                Next
                intResto = intSoma Mod 11
                strDigito2 = Right(IIf(intResto < 2, "0", CStr(11 - intResto)), 1)
                strBase2 = strBase2 & strDigito2
                If strBase2 = strOrigem Then
                    ChecaInscrE = True
                End If
            Case "RJ" ' Rio de Janeiro 
                strBase = Left(Trim(strOrigem) & "00000000", 8)
                intSoma = 0
                intPeso = 2
                For intPos = 7 To 1 Step -1
                    intValor = CInt(Mid(strBase, intPos, 1))
                    intValor = intValor * intPeso
                    intSoma = intSoma + intValor
                    intPeso = intPeso + 1
                    If intPeso > 7 Then
                        intPeso = 2
                    End If
                Next
                intResto = intSoma Mod 11
                strDigito1 = Right(IIf(intResto < 2, "0", CStr(11 - intResto)), 1)
                strBase2 = Left(strBase, 7) & strDigito1
                If strBase2 = strOrigem Then
                    ChecaInscrE = True
                End If
            Case "RN" ' Rio Grande do Norte 
                strBase = Left(Trim(strOrigem) & "000000000", 9)
                If Left(strBase, 2) = "20" Then
                    intSoma = 0
                    For intPos = 1 To 8
                        intValor = CInt(Mid(strBase, intPos, 1))
                        intValor = intValor * (10 - intPos)
                        intSoma = intSoma + intValor
                    Next
                    intSoma = intSoma * 10
                    intResto = intSoma Mod 11
                    strDigito1 = Right(IIf(intResto > 9, "0", CStr(intResto)), 1)
                    strBase2 = Left(strBase, 8) & strDigito1
                    If strBase2 = strOrigem Then
                        ChecaInscrE = True
                    End If
                End If
            Case "RO" ' Rondonia, estado alterado 
                strBase = Left(Trim(strOrigem) & "000000000", 14)
                d01 = CInt(mid(strBase, 1, 1))
                d02 = CInt(mid(strBase, 2, 1))
                d03 = CInt(mid(strBase, 3, 1))
                d04 = CInt(mid(strBase, 4, 1))
                d05 = CInt(mid(strBase, 5, 1))
                d06 = CInt(mid(strBase, 6, 1))
                d07 = CInt(mid(strBase, 7, 1))
                d08 = CInt(mid(strBase, 8, 1))
                d09 = CInt(mid(strBase, 9, 1))
                d10 = CInt(mid(strBase, 10, 1))
                d11 = CInt(mid(strBase, 11, 1))
                d12 = CInt(mid(strBase, 12, 1))
                d13 = CInt(mid(strBase, 13, 1))
                dfinal = CInt(mid(strBase, 14, 1))
                ds = 6 * d01 + 5 * d02 + 4 * d03 + 3 * d04 + 2 * d05 + 9 * d06 + 8 * d07 + 7 * d08 + _
                                   6 * d09 + 5 * d10 + 4 * d11 + 3 * d12 + 2 * d13
                aux1 = Fix(ds / 11)
                aux1 = aux1 * 11
                aux2 = ds - aux1
                digVerificador = 11 - aux2
                If digVerificador > 9 Then
                    resto_do_calculo = digVerificador - 10
                Else
                    resto_do_calculo = digVerificador
                End If
                If dfinal <> resto_do_calculo Then
                    ChecaInscrE = False
                Else
                    ChecaInscrE = True
                End If
            Case "RR" ' Roraima 
                strBase = Left(Trim(strOrigem) & "000000000", 9)
                If Left(strBase, 2) = "24" Then
                    intSoma = 0
                    For intPos = 1 To 8
                        intValor = CInt(Mid(strBase, intPos, 1))
                        intValor = intValor * intPos
                        intSoma = intSoma + intValor
                    Next
                    intResto = intSoma Mod 9
                    strDigito1 = Right(CStr(intResto), 1)
                    strBase2 = Left(strBase, 8) & strDigito1
                    If strBase2 = strOrigem Then
                        ChecaInscrE = True
                    End If
                End If
            Case "RS" ' Rio Grande do Sul 
                strBase = Left(Trim(strOrigem) & "0000000000", 10)
                intNumero = CInt(Left(strBase, 3))
                If intNumero > 0 And intNumero < 468 Then
                    intSoma = 0
                    intPeso = 2
                    For intPos = 9 To 1 Step -1
                        intValor = CInt(Mid(strBase, intPos, 1))
                        intValor = intValor * intPeso
                        intSoma = intSoma + intValor
                        intPeso = intPeso + 1
                        If intPeso > 9 Then
                            intPeso = 2
                        End If
                    Next
                    intResto = intSoma Mod 11
                    intValor = 11 - intResto
                    If intValor > 9 Then
                        intValor = 0
                    End If
                    strDigito1 = Right(CStr(intValor), 1)
                    strBase2 = Left(strBase, 9) & strDigito1
                    If strBase2 = strOrigem Then
                        ChecaInscrE = True
                    End If
                End If
            Case "SC" ' Santa Catarina 
                strBase = Left(Trim(strOrigem) & "000000000", 9)
                intSoma = 0
                For intPos = 1 To 8
                    intValor = CInt(Mid(strBase, intPos, 1))
                    intValor = intValor * (10 - intPos)
                    intSoma = intSoma + intValor
                Next
                intResto = intSoma Mod 11
                strDigito1 = Right(IIf(intResto < 2, "0", CStr(11 - intResto)), 1)
                strBase2 = Left(strBase, 8) & strDigito1
                If strBase2 = strOrigem Then
                    ChecaInscrE = True
                End If
            Case "SE" ' Sergipe 
                strBase = Left(Trim(strOrigem) & "000000000", 9)
                intSoma = 0
                For intPos = 1 To 8
                    intValor = CInt(Mid(strBase, intPos, 1))
                    intValor = intValor * (10 - intPos)
                    intSoma = intSoma + intValor
                Next
                intResto = intSoma Mod 11
                intValor = 11 - intResto
                If intValor > 9 Then
                    intValor = 0
                End If
                strDigito1 = Right(CStr(intValor), 1)
                strBase2 = Left(strBase, 8) & strDigito1
                If strBase2 = strOrigem Then
                    ChecaInscrE = True
                End If
            Case "SP" ' São Paulo 
                If Left(strOrigem, 1) = "P" Then
                    strBase = Left(Trim(strOrigem) & "0000000000000", 13)
                    strBase2 = Mid(strBase, 2, 8)
                    intSoma = 0
                    intPeso = 1
                    For intPos = 1 To 8
                        intValor = CInt(Mid(strBase, intPos, 1))
                        intValor = intValor * intPeso
                        intSoma = intSoma + intValor
                        intPeso = intPeso + 1
                        If intPeso = 2 Then
                            intPeso = 3
                        End If
                        If intPeso = 9 Then
                            intPeso = 10
                        End If
                    Next
                    intResto = intSoma Mod 11
                    strDigito1 = Right(CStr(intResto), 1)
                    strBase2 = Left(strBase, 8) & strDigito1 & Mid(strBase, 11, 3)
                Else
                    strBase = Left(Trim(strOrigem) & "000000000000", 12)
                    intSoma = 0
                    intPeso = 1
                    For intPos = 1 To 8
                        intValor = CInt(Mid(strBase, intPos, 1))
                        intValor = intValor * intPeso
                        intSoma = intSoma + intValor
                        intPeso = intPeso + 1
                        If intPeso = 2 Then
                            intPeso = 3
                        End If
                        If intPeso = 9 Then
                            intPeso = 10
                        End If
                    Next
                    intResto = intSoma Mod 11
                    strDigito1 = Right(CStr(intResto), 1)
                    strBase2 = Left(strBase, 8) & strDigito1 & Mid(strBase, 10, 2)
                    intSoma = 0
                    intPeso = 2
                    For intPos = 11 To 1 Step -1
                        intValor = CInt(Mid(strBase, intPos, 1))
                        intValor = intValor * intPeso
                        intSoma = intSoma + intValor
                        intPeso = intPeso + 1
                        If intPeso > 10 Then
                            intPeso = 2
                        End If
                    Next
                    intResto = intSoma Mod 11
                    strDigito2 = Right(CStr(intResto), 1)
                    strBase2 = strBase2 & strDigito2
                End If
                If strBase2 = strOrigem Then
                    ChecaInscrE = True
                End If
            Case "TO" ' Tocantins 
                strBase = Left(Trim(strOrigem) & "00000000000", 11)
                If Instr(1, "01,02,03,99", Mid(strBase, 3, 2), vbTextCompare) > 0 Then
                    strBase2 = Left(strBase, 2) & Mid(strBase, 5, 6)
                    intSoma = 0
                    For intPos = 1 To 8
                        intValor = CInt(Mid(strBase2, intPos, 1))
                        intValor = intValor * (10 - intPos)
                        intSoma = intSoma + intValor
                    Next
                    intResto = intSoma Mod 11
                    strDigito1 = Right(IIf(intResto < 2, "0", CStr(11 - intResto)), 1)
                    strBase2 = Left(strBase, 10) & strDigito1
                    If strBase2 = strOrigem Then
                        ChecaInscrE = True
                    End If
                End If
        End Select
    End Function
    Public Function DiaSemanaExtenso(ByVal Dt As Date) As String
        Dim DiaExtenso As String = ""
        Select Case CDate(Dt).DayOfWeek
            Case 0
                DiaExtenso = "DOMINGO"
            Case 1
                DiaExtenso = "SEGUNDA"
            Case 2
                DiaExtenso = "TERÇA"
            Case 3
                DiaExtenso = "QUARTA"
            Case 4
                DiaExtenso = "QUINTA"
            Case 5
                DiaExtenso = "SEXTA"
            Case 6
                DiaExtenso = "SABADO"
        End Select
        Return DiaExtenso
    End Function

    Public Function CalcIdLancamento()


        Dim Num As New Random
        Dim Tempo As Integer = 0

        Tempo = Num.Next(1, 999)

        System.Threading.Thread.Sleep(Tempo)

        Dim Calculo As String = String.Empty
        Dim DataCalculo As String = CDbl(CDbl(Format(CDate(DataDia), "dd")) + CDbl(Format(CDate(DataDia), "MM")) + CDbl(Format(CDate(DataDia), "yyyy")))
        Dim HoraCalculo As String = (Format(CDate(DateTime.Now).Hour, "00")) & (Format(CDate(DateTime.Now).Minute, "00")) & (Format(CDate(DateTime.Now).Second, "00")) & (Format(CDate(DateTime.Now).Millisecond, "000"))


        Calculo = (DataCalculo & HoraCalculo & VarCodFunc)
        Return Calculo

    End Function

    Public Function existeTabela(ByVal nomeTabela As String) As Boolean
        Dim Con As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Con.Open()
        Dim dbSchema As DataTable = Con.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, nomeTabela, "TABLE"})
        Con.Close()

        Try
            If dbSchema.Rows.Count > 0 Then
                ' ... Se a table existir 
                Return True
            Else

                ' ... se a Table não exists
                Return False
                MsgBox("Não existe Tabela para essa competência", 48, "ATENÇÃO")
            End If

        Catch ex As Exception
            MessageBox.Show("ERRO " & ex.Message, "Verifica tabela")
            Return False
        End Try
    End Function

    Public Function TemValor(ByVal CampoProcura As String, ByVal Tabela As String, ByVal ValorProcurar As String, ByVal ProcuraÉalfa As Boolean, ByVal MultiEmpresa As Boolean) As Boolean
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = ""
        If ProcuraÉalfa = False Then
            If MultiEmpresa = False Then
                Sql = "Select * from " & Tabela & " where " & CampoProcura & " = " & ValorProcurar
            Else
                Sql = "Select * from " & Tabela & " where " & CampoProcura & " = " & ValorProcurar & " and Empresa = " & CodEmpresa
            End If
        Else
            If MultiEmpresa = False Then
                Sql = "Select * from " & Tabela & " where " & CampoProcura & " = '" & ValorProcurar & "'"
            Else
                Sql = "Select * from " & Tabela & " where " & CampoProcura & " = '" & ValorProcurar & "'" & " and Empresa = " & CodEmpresa
            End If
        End If
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            DR.Close()
            Return True
        Else
            DR.Close()
            Return False
        End If
    End Function

    Public Function VerificaCodigoSegurança(ByVal Codigo As String) As Boolean

        If Codigo = "" Then
            Return False
            Exit Function
        End If


        Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim DS As New DataSet()
        Dim Sql As String = String.Empty
        Dim daCodSeg As OleDb.OleDbDataAdapter
        Dim TBL As DataTable

        Sql = "Select * From CodigosSegurança Where CodSeg = '" & Codigo & "'"
        daCodSeg = New OleDb.OleDbDataAdapter(Sql, Cnn)
        daCodSeg.Fill(DS, "CodigosSegurança")
        TBL = DS.Tables("CodigosSegurança")

        If TBL.Rows.Count = 0 Then
            daCodSeg.Dispose()
            TBL.Dispose()
            DS.Dispose()
            Cnn.Close()
            Return False
        Else

            TBL.Rows.Item(0).Delete()

            Dim OBJ As New OleDb.OleDbCommandBuilder(daCodSeg)
            daCodSeg.Update(DS, "CodigosSegurança")
            daCodSeg.Dispose()
            TBL.Dispose()
            DS.Dispose()
            Cnn.Close()
            Return True
        End If
    End Function

    Public Function InformaCodigoSeguranca() As String
        TRVDados(UserAtivo, "CodigoSegurancaInformar")
        If Ina = True Then
            MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
            Return 0
            Exit Function
        Else
            My.Forms.CodigoSegurancaInformar.ShowDialog()
        End If

        Return RetornoCodSegurança
    End Function

    Public Function AchaMultiplos(ByVal Valor As Double, ByVal Mutiplo As Double) As Boolean
        Dim IsMultiplo As Double = False

        Dim Result As Double = Valor / Mutiplo
        Dim ResultAbs As Integer = Math.Abs(Result)

        Dim Vlr As Double = Result - ResultAbs

        If Vlr <> 0 Then
            IsMultiplo = False
        Else
            IsMultiplo = True
        End If

        Return IsMultiplo

    End Function

    Public Function CrDateBetween(ByVal CampoFiltro As String, ByVal DataInicial As String, ByVal DataFinal As String) As String
        Dim DInicial As Date, DFinal As Date
        DInicial = CDate(DataInicial)
        DFinal = CDate(DataFinal)
        Return CampoFiltro & " in DateTime (" & Year(DInicial) & "," & Month(DInicial) & "," & Microsoft.VisualBasic.Day(DInicial) & ", 0, 0, 0) to DateTime (" & Year(DFinal) & "," & Month(DFinal) & "," & Microsoft.VisualBasic.Day(DFinal) & ", 0, 0, 0)"
    End Function
    'funcao inserida pelo beto 14-01-2010
    'digita apenas numeros.
    Function OnlyNumber(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            OnlyNumber = 0
        Else
            OnlyNumber = Keyascii
        End If
        Select Case Keyascii
            Case 8
                OnlyNumber = Keyascii
            Case 13
                OnlyNumber = Keyascii
            Case 32
                OnlyNumber = Keyascii
        End Select

    End Function

    Function Criptografa(ByVal Texto As String) As String

        Dim Pronto As String = String.Empty
        Dim I As Integer

        For i = 1 To Len(Texto)
            Pronto = Pronto & Asc(Mid(Texto, I, 1)) & "-"
        Next i

        Return Pronto

    End Function

    Function DeCriptografa(ByVal Código As String) As String

        Dim I As Integer
        Dim Pronto As String = String.Empty
        Dim Caract As String = String.Empty

        For i = 1 To Len(Código)
            If Mid(Código, I, 1) = "-" Then
                Pronto = Pronto & Chr(Val(Caract))
                Caract = ""
            Else
                Caract = Caract & Mid(Código, I, 1)
            End If
        Next

        Return Pronto

    End Function

    Public Enum AçãoTP
        Adicionou = 0
        Editou = 1
        Excluiu = 2
        Inativou = 3
        Pequisou = 4
        Confirmou = 5
        Exportacao = 6
        Erro = 7
        Impress = 8
        Livre = 9
    End Enum
    Public ErroLivre As String = String.Empty
    Public Sub GerarLog(ByVal Tela As String, ByVal Ação As AçãoTP, ByVal IDLog As String)
        'usuario = Texto(15)      
        'Tela    = Texto(50)
        'Ação    = Text0(15)
        'IdLog   = Texto(20) 
        'D__H    = Texto(20)   


        Dim LocalEXE As String = My.Application.Info.DirectoryPath & "\Log"

        If Not IO.Directory.Exists(LocalEXE) Then
            IO.Directory.CreateDirectory(LocalEXE)
        End If

        'define o diretório atual
        Directory.SetCurrentDirectory(LocalEXE)

        Dim M As String = "\Log-" & CStr(DataDia.Month).PadLeft(2, "0") & "-" & DataDia.Year

        If Not IO.File.Exists(Directory.GetCurrentDirectory & M & ".Txt") Then
            Dim fs As New FileStream(Directory.GetCurrentDirectory & M, FileMode.Append, FileAccess.Write, FileShare.Write)
            fs.Close()
        End If

        Dim D__H As String = Date.Now

        Dim str_Ação As String = String.Empty
        Select Case Ação
            Case 0
                str_Ação = "Adicionou"
            Case 1
                str_Ação = "Editou"
            Case 2
                str_Ação = "Excluiu"
            Case 3
                str_Ação = "Inativou"
            Case 4
                str_Ação = "Pequisou"
            Case 5
                str_Ação = "Confirmou"
            Case 6
                str_Ação = "Exportacao"
            Case 7
                str_Ação = "Erro"
            Case 8
                str_Ação = "Impress"
            Case 9
                str_Ação = "Livre"

        End Select

        Dim TXT As String = String.Empty
        TXT = Mid(CStr(UserAtivo).PadRight(15, " "), 1, 15)
        TXT = TXT & Mid(CStr(Tela).PadRight(50, " "), 1, 50)
        TXT = TXT & Mid(CStr(str_Ação).PadRight(15, " "), 1, 15)
        TXT = TXT & Mid(CStr(IDLog).PadRight(20, " "), 1, 20)
        TXT = TXT & Mid(CStr(D__H).PadRight(20, " "), 1, 20)
        TXT = TXT & Mid(CStr(ErroLivre).PadRight(150, " "), 1, 150)

        Dim sw As New StreamWriter(Directory.GetCurrentDirectory & M & ".Txt", True, System.Text.Encoding.ASCII)
        Dim NextLine As String = TXT
        sw.WriteLine(NextLine)
        sw.Close()

    End Sub




    Public varAutorizado As Boolean
    Public Function PedirPermissao(ByVal _Tela As String, ByVal _IdRegistro As String) As Boolean

        varAutorizado = False

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from getAutorizacao where Usuario = '" & UserAtivo & "' and IdRegistro = '" & _IdRegistro & "' And Tela = '" & _Tela & "' and Utilizada = False"
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            My.Forms.PermissaoGet.IdRegistro = _IdRegistro
            My.Forms.PermissaoGet.Tela = _Tela

            Dim diagR As DialogResult

            diagR = My.Forms.PermissaoGet.ShowDialog()
            If diagR = DialogResult.Cancel Then
                Return False
            End If
            If diagR = DialogResult.No Then
                Return False
            End If
            If diagR = DialogResult.Yes Then
                Return True
            End If

        Else

            If MessageBox.Show("Deseja pedir autorização para este procedimento.", "Validação de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                My.Forms.PermissaoPost.IdRegistro = _IdRegistro
                My.Forms.PermissaoPost.Tela = _Tela
                My.Forms.PermissaoPost.ShowDialog()
                DR.Close()
                CNN.Close()
                PedirPermissao(_Tela, _IdRegistro)
            End If

        End If
        DR.Close()
        CNN.Close()

    End Function


    Public Sub EncheLabelObjeto(ByVal Root As Control)

        Dim CnnFind As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CnnFind.Open()

        Dim Sql As String = "Select * From ObjetosConf  Where NomeConf = 'NOME-OBJETOS'"
        Dim CMD As New OleDb.OleDbCommand(Sql, CnnFind)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        Dim cp1 As String = String.Empty
        Dim cp2 As String = String.Empty
        Dim cp3 As String = String.Empty
        Dim cp4 As String = String.Empty
        Dim cp5 As String = String.Empty

        If DR.HasRows Then
            cp1 = DR.Item("Cp1") & ""
            cp2 = DR.Item("Cp2") & ""
            cp3 = DR.Item("Cp3") & ""
            cp4 = DR.Item("Cp4") & ""
            cp5 = DR.Item("Cp5") & ""
        End If

        DR.Close()
        CnnFind.Close()

        LabelObjeto(Root, cp1, cp2, cp3, cp4, cp5)

    End Sub

    Public Sub LabelObjeto(ByVal Form_Verificar As Control, ByVal c1 As String, ByVal c2 As String, ByVal c3 As String, ByVal c4 As String, ByVal c5 As String)
        For Each ctrl As Control In Form_Verificar.Controls
            LabelObjeto(ctrl, c1, c2, c3, c4, c5)
            If TypeOf ctrl Is Label Then
                If CType(ctrl, Label).Name = "CP1" Then
                    CType(ctrl, Label).Text = c1
                End If
                If CType(ctrl, Label).Name = "CP2" Then
                    CType(ctrl, Label).Text = c2
                End If
                If CType(ctrl, Label).Name = "CP3" Then
                    CType(ctrl, Label).Text = c3
                End If
                If CType(ctrl, Label).Name = "CP4" Then
                    CType(ctrl, Label).Text = c4
                End If
                If CType(ctrl, Label).Name = "CP5" Then
                    CType(ctrl, Label).Text = c5
                End If
            End If

            If TypeOf ctrl Is DataGridView Then
                LabelDatagridview(ctrl, c1, c2, c3, c4, c5)
            End If
        Next (ctrl)
    End Sub

    Public Sub LabelDatagridview(ByVal Lista As DataGridView, ByVal c1 As String, ByVal c2 As String, ByVal c3 As String, ByVal c4 As String, ByVal c5 As String)
        Dim i As Integer

        For i = 0 To Lista.ColumnCount - 1

            If Lista.Columns(i).Name = "CP1" Then
                Lista.Columns(i).HeaderText = c1
            End If
            If Lista.Columns(i).Name = "CP2" Then
                Lista.Columns(i).HeaderText = c2
            End If
            If Lista.Columns(i).Name = "CP3" Then
                Lista.Columns(i).HeaderText = c3
            End If
            If Lista.Columns(i).Name = "CP4" Then
                Lista.Columns(i).HeaderText = c4
            End If
            If Lista.Columns(i).Name = "CP5" Then
                Lista.Columns(i).HeaderText = c5
            End If
        Next
    End Sub


    Public Function ValidaDados(ByVal ControleValidar As Control, ByVal MsgErro As String) As Boolean
        If ControleValidar.Text = "" Then
            MessageBox.Show(MsgErro, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ControleValidar.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Public Function nzBOL(vlr As Object) As Object
        If IsDBNull(vlr) Then
            Return 0
        Else
            Return vlr
        End If
    End Function

    Public Function nzDAT(vlr As Object) As Object
        If IsDate(vlr) Then
            Return CDate(vlr)
        Else
            Return DBNull.Value
        End If
    End Function

    Public Function nzNUM(vlr As Object) As Object
        If IsNumeric(vlr) Then
            Return CDbl(vlr)
        Else
            Return 0
        End If
    End Function

    Public Function nzINT(vlr As Object) As Object
        If IsNumeric(vlr) Then
            Return CInt(vlr)
        Else
            Return 0
        End If
    End Function

    Public Function nzNUL(vlr As Object) As Object

        If IsDBNull(vlr) Then
            Return System.DBNull.Value
        ElseIf vlr = "" Then
            Return System.DBNull.Value
        End If
        Return vlr
        'Return IIf(IsDBNull(vlr) Or vlr = "" Or vlr = " ", System.DBNull.Value, vlr)
    End Function

End Module
