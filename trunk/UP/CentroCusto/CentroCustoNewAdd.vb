Imports System.Data.OleDb

Public Class CentroCustoNewAdd

    Private con As OleDbConnection
    Public strCR As String
    Dim strContaG3 As String


    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConfirmar.Click

        If Me.Descricao.Text = "" Then
            MsgBox("A Descrição da conta não foi informada, Favor verificar.", 64, "Validação de Dados")
            Me.Descricao.Focus()
            Exit Sub
        End If



        ' Abre a conexao com o banco de dados
        con = New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        con.Open()
        Dim Cmd As New OleDbCommand()

        'Verifica qual a opção escolhida para pode utilizar
        'Verifica qual Ação foi acinado.
        Select Case My.Forms.CentroCustoNew.Acao
            Case 1, 0 'Inserte
                UltimoReg()
                ContaG3()
                'ContaRed()
                With Cmd
                    .Connection = con
                    .CommandTimeout = 0

                    Select Case My.Forms.CentroCustoNew.strTag
                        Case "Raiz" 'Insere na raiz no grupo 1
                            .CommandText = "INSERT INTO Cc1 (ContaGrupo1, Empresa, DescContaGrupo1) values (@1, @2, @3)"
                            .CommandType = CommandType.Text
                        Case "G1" 'Insere no grupo 1 o grupo 2

                            .CommandText = "INSERT INTO Cc2 (ContaGrupo1, ContaGrupo2, Empresa, DescContaGrupo2) values (@1, @2, @3, @4)"
                            .CommandType = CommandType.Text

                        Case "G2" 'Insere no grupo 2 o grupo 3
                            .CommandText = "INSERT INTO Cc3 (ContaGrupo1, ContaGrupo2, ContaGrupo3, Empresa, DescContaGrupo3) values (@1, @2, @3, @4, @5)"
                            .CommandType = CommandType.Text
                    End Select

                End With

                Dim strCCG As String = My.Forms.CentroCustoNew.strNodeG1
                Dim strAr(3) As String
                If IsNothing(strCCG) = False Then
                    strAr = strCCG.Split("-")
                End If
                Select Case My.Forms.CentroCustoNew.strTag
                    Case "Raiz" 'Insere na raiz no grupo 1
                        'Tabela CCG1
                        Cmd.Parameters.Add(New OleDbParameter("@1", Me.Conta.Text)) 'ccg1
                        Cmd.Parameters.Add(New OleDbParameter("@2", CodEmpresa)) 'Código da empresa usado no login pelo usuario
                        Cmd.Parameters.Add(New OleDbParameter("@3", Me.Descricao.Text)) ' descricao
                    Case "G1" 'Insere no grupo 1 o grupo 2
                        'Tabela CCG2
                        Cmd.Parameters.Add(New OleDbParameter("@1", strAr(0).ToString)) 'ccg1
                        Cmd.Parameters.Add(New OleDbParameter("@2", Me.Conta.Text)) 'ccg2
                        Cmd.Parameters.Add(New OleDbParameter("@3", CodEmpresa)) 'Código da empresa usado no login pelo usuario
                        Cmd.Parameters.Add(New OleDbParameter("@4", Me.Descricao.Text)) 'descricao
                    Case "G2" 'Insere no grupo 2 o grupo 3
                        'Tabela CCG3
                        Cmd.Parameters.Add(New OleDbParameter("@1", strAr(0).ToString)) 'ccg1
                        Cmd.Parameters.Add(New OleDbParameter("@2", strAr(1).ToString)) 'ccg2
                        Cmd.Parameters.Add(New OleDbParameter("@3", Me.Conta.Text)) 'ccg3
                        Cmd.Parameters.Add(New OleDbParameter("@4", CodEmpresa)) 'Código da empresa usado no login pelo usuario
                        Cmd.Parameters.Add(New OleDbParameter("@5", Me.Descricao.Text)) ' descricao
                End Select

                Try
                    If (ConnectionState.Open = ConnectionState.Closed) Then
                        con.Open()
                        Cmd.ExecuteNonQuery()
                    Else

                        Cmd.ExecuteNonQuery()
                        MsgBox("Registro Adicionado com sucesso", 64, "Atenção")

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, 64)
                End Try

                Me.Conta.Text = ""
                Me.Descricao.Text = ""
                Me.Descricao.Focus()
                My.Forms.CentroCustoNew.btMostrarArvore_Click(sender, e)
                con.Close()

            Case 2 'Uptade
                Dim strCCG As String = My.Forms.CentroCustoNew.strNodeG1
                Dim strAr(4) As String
                If IsNothing(strCCG) = False Then
                    strAr = strCCG.Split("-")
                End If
                With Cmd
                    .Connection = con
                    .CommandTimeout = 0

                    Select Case My.Forms.CentroCustoNew.strTag
                        Case "G1" 'Insere na raiz no grupo 1
                            .CommandText = "UPDATE Cc1 SET Cc1.DescContaGrupo1 = @1 WHERE Cc1.ContaGrupo1 ='" & strAr(0) & "' AND Empresa=" & CodEmpresa & ""
                            .CommandType = CommandType.Text

                            Cmd.Parameters.Add(New OleDbParameter("@1", Me.Descricao.Text & "")) ' descricao

                        Case "G2" 'Insere no grupo 1 o grupo 2
                            .CommandText = "UPDATE Cc2 SET DescContaGrupo2 = @1 WHERE ContaGrupo1 ='" & strAr(0) & "' AND ContaGrupo2 = '" & strAr(1) & "' AND Empresa=" & CodEmpresa & ""
                            .CommandType = CommandType.Text

                            Cmd.Parameters.Add(New OleDbParameter("@1", Me.Descricao.Text & "")) ' descricao

                        Case "G3" 'Insere no grupo 2 o grupo 3
                            .CommandText = "UPDATE Cc3 SET DescContaGrupo3 = @1 WHERE ContaGrupo3 like '" & strAr(2) & "' AND Empresa=" & CodEmpresa & ""
                            .CommandType = CommandType.Text


                            Cmd.Parameters.Add(New OleDbParameter("@1", Me.Descricao.Text & "")) ' descricao

                            'Case "G4" 'Insere no grupo 3 o grupo 4
                            '    .CommandText = "UPDATE CCG4 SET Descg4 = @1 WHERE CONTAREDUZIDA = '" & strAr(3) & "' AND Empresa=" & CodEmpresa & ""
                            '    .CommandType = CommandType.Text

                    End Select

                End With




                Try
                    'con.Open()
                    Cmd.ExecuteNonQuery()
                    MsgBox("Registro autalizado com sucesso", 64, "Atencao")
                Catch ex As Exception
                    MsgBox(ex.Message, 64)
                End Try

                Me.Conta.Text = ""
                Me.Descricao.Text = ""
                Me.Descricao.Focus()
                My.Forms.CentroCustoNew.btMostrarArvore_Click(sender, e)
                Me.Close()
                con.Close()


        End Select


    End Sub


    Private Sub ContaRed()

        ' Abre a conexao com o banco de dados
        con = New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        Dim Cmd As New OleDbCommand() 'Cria o  objeto command
        Dim DataReader As OleDbDataReader 'Cria o objeto DataReader 
        Dim Ult As String = String.Empty 'Cria variavel para o ultimo registro  
        Dim i As Integer = 0
        Dim tp As String = "000000"

        With Cmd
            .Connection = con
            .CommandTimeout = 0
            Dim strAr As String()
            Dim strRes As String = My.Forms.BalanceteCadastro.NomeStr
            If IsNothing(strRes) = False Then
                strAr = strRes.Split("-")
            End If


        End With
        Try
            con.Open()
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    'Achou o iten procurado o iten as caixas serão preemenchida
                    Ult = DataReader.Item(0)
                End If
            End While

            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                con.Close()
                Exit Sub
            End If
        End Try
        con.Close() 'Fecha a conexao.

        i = NzZero(Ult) + 1  'Aqui pega o ultimo registro e acrescenta +1.
        strCR = Format(i, tp.ToString) 'Faz uma formatação condicional.
    End Sub
    Private Sub ContaG3()
        ' Abre a conexao com o banco de dados
        con = New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        Dim Cmd As New OleDbCommand() 'Cria o  objeto command
        Dim DataReader As OleDbDataReader 'Cria o objeto DataReader 
        Dim Ult As String = String.Empty 'Cria variavel para o ultimo registro  
        Dim i As Integer = 0


        With Cmd
            .Connection = con
            .CommandTimeout = 0
            Dim strAr As String()
            Dim strRes As String = My.Forms.CentroCustoNew.NomeStr
            If IsNothing(strRes) = False Then
                strAr = strRes.Split("-")
            End If

            .CommandText = "SELECT Max(Cc3.ContaGrupo3) AS MáxDeContaGrupo3, Cc3.Empresa FROM Cc3 GROUP BY Cc3.Empresa HAVING (((Cc3.Empresa)=" & CodEmpresa & "))"
            .CommandType = CommandType.Text

        End With
        Try
            If con.State = 1 Then

                DataReader = Cmd.ExecuteReader
            Else
                con.Open()
                DataReader = Cmd.ExecuteReader
            End If


            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    'Achou o iten procurado 
                    Ult = DataReader.Item(0)
                Else
                    Ult = "500000"
                End If
            End While

            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                con.Close()
                Exit Sub
            End If
        End Try
        'con.Close() 'Fecha a conexao.

        i = NzZero(Ult) + 1  'Aqui pega o ultimo registro e acrescenta +1.
        strContaG3 = Format(i, "000000") 'Faz uma formatação condicional.
    End Sub
    Private Sub UltimoReg()


        ' Abre a conexao com o banco de dados
        con = New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        Dim Cmd As New OleDbCommand()
        Dim DataReader As OleDbDataReader
        Dim Ult As String = String.Empty
        Dim i As Integer = 0
        Dim tp As String = String.Empty

        With Cmd
            .Connection = con
            .CommandTimeout = 0
            Dim strAr(3) As String
            Dim strRes As String = My.Forms.CentroCustoNew.NomeStr
            If IsNothing(strRes) = False Then
                strAr = strRes.Split("-")
            End If
            Select Case My.Forms.CentroCustoNew.strTag
                Case "Raiz"
                    .CommandText = "SELECT Max(Cc1.ContaGrupo1) AS MáxDeContaGrupo1 FROM Cc1 WHERE Empresa=" & CodEmpresa & ""
                    tp = "0000"

                Case "G1"
                    .CommandText = "SELECT Max(Cc2.ContaGrupo2) AS MáxDeContaGrupo2, Cc2.ContaGrupo1  FROM Cc2 WHERE(((Cc2.Empresa) = " & CodEmpresa & ")) GROUP BY Cc2.ContaGrupo1 HAVING (((Cc2.ContaGrupo1)='" & strAr(0) & "'));"
                    tp = "0000"
                Case "G2"
                    tp = "000000"
                    .CommandText = "SELECT Max(Cc3.ContaGrupo3)AS MáxDeContaGrupo3 FROM  Cc3 WHERE Cc3.Empresa = " & CodEmpresa

            End Select

            .CommandType = CommandType.Text
        End With
        Try
            con.Open()
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    'Achou o iten procurado o iten as caixas serão preemenchida

                    Ult = DataReader.Item(0)

                End If

            End While

            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                con.Close()
                Exit Sub
            End If
        End Try
        con.Close()
        i = NzZero(Ult) + 1
        Me.Conta.Text = Format(i, tp.ToString)


    End Sub
    Public Function NzZero(ByVal Vlr As Object)

        Dim Ret As Object = 0

        Try

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


    Private Sub BalanceteCadastroAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case My.Forms.BalanceteCadastro.Acao
            Case 1
                If My.Forms.BalanceteCadastro.strTag = "G1" Then
                End If

                If My.Forms.BalanceteCadastro.strTag = "G2" Then
                End If

                If My.Forms.BalanceteCadastro.strTag = "Raiz" Then
                End If

            Case 2
                If My.Forms.BalanceteCadastro.strTag = "G3" Then

                Else
                    If My.Forms.BalanceteCadastro.strTag = "G2" Then
                    Else
                        If My.Forms.BalanceteCadastro.strTag = "G1" Then
                          
                        End If
                    End If
                End If



        End Select

    End Sub
End Class