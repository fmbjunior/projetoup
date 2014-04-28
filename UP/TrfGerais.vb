Imports System.Data.OleDb
Public Class TrfGerais

    Public DadosINCONSISTENTE As Boolean = False

    Public Enum TipoDados
        AlfaNumérico = 0
        Numérico = 1
    End Enum

    Public Sub LimpaTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            LimpaTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next (ctrl)
    End Sub

    Public Sub ValidaDados(ByVal Root As Control)
        For Each ctrl As Control In Root.Controls
            ValidaDados(ctrl)
            If TypeOf ctrl Is TexBoxFocusNet.TextBoxFocusNet Then
                If CType(ctrl, TexBoxFocusNet.TextBoxFocusNet).CPObrigatorio = True Then
                    If CType(ctrl, TexBoxFocusNet.TextBoxFocusNet).Text = "" Then
                        MessageBox.Show(CType(ctrl, TexBoxFocusNet.TextBoxFocusNet).CPObrigatorioMsg, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DadosINCONSISTENTE = True
                        CType(ctrl, TexBoxFocusNet.TextBoxFocusNet).Focus()
                        Exit For
                    End If
                End If
            End If

            '    If TypeOf ctrl Is TxtboxSe.TxtSE Then
            '        If CType(ctrl, TxtboxSe.TxtSE).CPObrigatorio = True Then
            '            If CType(ctrl, TxtboxSe.TxtSE).Text = "" Then
            '                MessageBox.Show(CType(ctrl, TxtboxSe.TxtSE).CPObrigatorioMsg, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '                DadosINCONSISTENTE = True
            '                CType(ctrl, TxtboxSe.TxtSE).Focus()
            '                Exit For
            '            End If
            '        End If
            '    End If
        Next (ctrl)
    End Sub

    Public Sub Desbloquear_Controle(ByVal root As Control, ByVal YesNo As Boolean)
        For Each ctrl As Control In root.Controls
            Desbloquear_Controle(ctrl, YesNo)
            If TypeOf ctrl Is TextBox Then CType(ctrl, TextBox).Enabled = YesNo
            If TypeOf ctrl Is ComboBox Then CType(ctrl, ComboBox).Enabled = YesNo
            If TypeOf ctrl Is CheckBox Then CType(ctrl, CheckBox).Enabled = YesNo
        Next (ctrl)
    End Sub


    Public Sub Ultimo_Registro(ByRef F As System.Windows.Forms.Form, ByVal ControleReceptorDados As Control, ByVal Table As String, ByVal CampoProcura As String)

        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDbCommand()
        Dim DataReader As OleDbDataReader
        Dim Ult As Integer
        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select max(" & CampoProcura & ") from " & Table
            .CommandType = CommandType.Text
        End With
        Try
            Cnn.Open()
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    'Achou o iten procurado o iten as caixas serão preenchida
                    Ult = DataReader.Item(0)
                End If
            End While
            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()

        Dim Controle As System.Windows.Forms.Control
        For Each Controle In F.Controls
            If Controle.Name = ControleReceptorDados.Name Then
                Controle.Text = Ult + 1
            End If
        Next Controle
        ControleReceptorDados.Focus()
    End Sub

    Public Function Ultimo_RegistroParaVariavel(ByVal Table As String, ByVal CampoProcura As String) As Integer

        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDbCommand()
        Dim DataReader As OleDbDataReader
        Dim Ult As Integer
        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select max(" & CampoProcura & ") from " & Table
            .CommandType = CommandType.Text
        End With
        Try
            Cnn.Open()
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    'Achou o iten procurado o iten as caixas serão preenchida
                    Ult = DataReader.Item(0)
                End If
            End While
            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Function
            End If
        End Try
        Cnn.Close()

        Return (Ult + 1)

    End Function

    Public Sub Descrição_ItenRegistro(ByVal ControleErro As Control, ByVal ControleReceberRetorno As Control, ByVal Table As String, ByVal CampoProcura As String, ByVal ValorProcurar As String, ByVal CampoRetornar As String, ByVal tpdados As TipoDados, ByVal MEmpresa As Boolean)

        If IsDBNull(ValorProcurar) = True Then
            ControleReceberRetorno.Text = ""
            Exit Sub
        End If

        If ValorProcurar = "" Then Exit Sub

        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDbCommand()
        Dim DataReader As OleDbDataReader
        Dim EmEdição As Boolean = False

        Dim SqlProcura As String
        If tpdados = TipoDados.AlfaNumérico Then
            If MEmpresa = True Then
                SqlProcura = "Select * from " & Table & " where " & CampoProcura & " = '" & ValorProcurar & "' and Inativo = False and Empresa = " & CodEmpresa
            Else
                SqlProcura = "Select * from " & Table & " where " & CampoProcura & " = '" & ValorProcurar & "' and Inativo = False "
            End If
        Else
            If MEmpresa = True Then
                SqlProcura = "Select * from " & Table & " where " & CampoProcura & " = " & ValorProcurar & " and Inativo = False and Empresa = " & CodEmpresa
            Else
                SqlProcura = "Select * from " & Table & " where " & CampoProcura & " = " & ValorProcurar & " and Inativo = False"
            End If
        End If

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = SqlProcura
            .CommandType = CommandType.Text
        End With
        Try
            Cnn.Open()
            DataReader = Cmd.ExecuteReader

            If DataReader.HasRows Then
                While DataReader.Read
                    If Not IsDBNull(DataReader.Item(CampoProcura)) Then
                        'Achou o iten procurado a caixa de retorno sera preenchida
                        ControleReceberRetorno.Text = DataReader.Item(CampoRetornar) & ""
                    End If
                End While
            Else
                MsgBox("Verifique o registro: Inexistente, tente outro", 64, "Localizar Registro")
                ControleErro.Text = ""
                ControleErro.Focus()
                Cnn.Close()
                Exit Sub
            End If

            DataReader.Close()
            Cnn.Close()
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()
    End Sub

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

    Public Sub PlanoContaAchaAnalitica(ByVal Cp_Erro As Control, ByVal Cp_Ret_ContaAnalitica As Control, ByVal Cp_Ret_Descrição As Control, ByVal ContaReduzidaAchar As String, ByVal Empresa As Integer)

        If ContaReduzidaAchar = "" Then Exit Sub

        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim SqlProcura As String = "Select * from PlanoContas Where ContaReduzida = '" & ContaReduzidaAchar & "' and Empresa = " & Empresa

        Dim Cmd As New OleDbCommand(SqlProcura, Cnn)
        Dim DR As OleDbDataReader

        Try
            DR = Cmd.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Cp_Ret_ContaAnalitica.Text = DR.Item("IdContas") & ""
                Cp_Ret_Descrição.Text = DR.Item("Descrição") & ""
            Else
                MsgBox("Verifique o registro: Inexistente, tente outro", 64, "Validação de Dados")
                Cp_Erro.Text = ""
                Cp_Erro.Focus()
                Cnn.Close()
                Exit Sub
            End If

            DR.Close()
            Cnn.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try

    End Sub

    Public Sub PlanoContaAchaReduzida(ByVal ContaReduzida As Control, ByVal ValorAcharCtAnalitica As String, ByVal Cp_Ret_Descrição As Control, ByVal Empresa As Integer)

        If ValorAcharCtAnalitica = "" Then Exit Sub

        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim SqlProcura As String = "Select * from PlanoContas Where IdContas = '" & ValorAcharCtAnalitica & "' and Empresa = " & Empresa

        Dim Cmd As New OleDbCommand(SqlProcura, Cnn)
        Dim DR As OleDbDataReader

        Try
            DR = Cmd.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                ContaReduzida.Text = DR.Item("ContaReduzida") & ""
                Cp_Ret_Descrição.Text = DR.Item("Descrição") & ""
            Else
                MsgBox("Verifique o registro: Inexistente, tente outro", 64, "Validação de Dados")
                ContaReduzida.Text = ""
                ContaReduzida.Focus()
                Cnn.Close()
                Exit Sub
            End If

            DR.Close()
            Cnn.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try

    End Sub

    Public Function VerAnoCont(ByRef vYear As String, ByRef vEmp As Integer) As Boolean

        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDbCommand()
        Dim DataReader As OleDbDataReader

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select * From FechAnoContabil Where AnoContabil='" & Mid(vYear, 2) & "' and Empresa=" & vEmp
            .CommandType = CommandType.Text
        End With
        Try
            Cnn.Open()
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                'If Not IsDBNull(DataReader.Item(0)) Then
                'Achou o iten procurado o iten as caixas serão preenchida
                VerAnoCont = True
                'Else
                'VerAnoCont = False
                'End If
            End While
            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Function
            End If
        End Try
        Cnn.Close()

    End Function

    Public Function FormatSTR_EFOCUS(ByVal Vlr As Object, ByVal Tamanho As Integer, ByVal StrInserir As String, ByVal DE As String)
        Dim StrCerta As String
        Dim StrTemp As String

        Dim L As Integer  'Variavel definida para o loop do for

        If IsDBNull(Vlr) Then
            Vlr = ""
        End If
        StrTemp = Vlr

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

    Public Function RChr(ByVal Vlr As Object, ByVal RetiraCh As Boolean, ByVal TextoRETIRAR As String)
        Dim StrTemp As String

        If IsDBNull(Vlr) Then
            Vlr = ""
        End If

        StrTemp = Vlr

        If RetiraCh = True Then
            StrTemp = StrTemp.Replace(TextoRETIRAR, "")
        End If

        Return UCase(StrTemp)
    End Function

    Public Function RetornaGruposContaAnalitica(ByVal Conta_Analitica As String) As String
        Dim CC As String = ""
        CC = Conta_Analitica
        If Mid(Conta_Analitica, 9, 6) = "000000" Then CC = Mid(CC, 1, 8)

        If Mid(Conta_Analitica, 7, 2) = "00" Then CC = Mid(CC, 1, 6)

        If Mid(Conta_Analitica, 5, 2) = "00" Then CC = Mid(CC, 1, 4)

        If Mid(Conta_Analitica, 3, 2) = "00" Then CC = Mid(CC, 1, 2)

        If Mid(Conta_Analitica, 1, 2) = "00" Then CC = Mid(CC, 1, 2)
        Return CC
    End Function

    Public Sub CriaLog(ByVal User As String, ByVal TelForms As String, ByVal TxT As String, ByVal CaminhoLog As String, ByVal DataDia As Date)
        Dim ArquivoCaminho As String = (CaminhoLog & "Log" & Format(Month(CDate(DataDia)), "00") & "-" & Year(CDate(DataDia)) & ".Txt")

        FileOpen(1, ArquivoCaminho, OpenMode.Append)
        WriteLine(1, User, TelForms, TxT, "Horas: " & FormatDateTime(DateTime.Now, DateFormat.LongTime), Format(CDate(DataDia), "dd/MM/yyyy"))
        FileClose(1)

    End Sub



End Class
