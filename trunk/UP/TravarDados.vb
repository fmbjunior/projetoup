Imports System.Data.OleDb
Module TravarDados

#Region "Variaveis de Travamento de Dados"
    Public Edi As Boolean = False
    Public Adi As Boolean = False
    Public Exc As Boolean = False
    Public Con As Boolean = False
    Public Ina As Boolean = True
    Public UsaTravamentoDados As Boolean = False
#End Region


    Public Sub TRVDados(ByVal Usuário As String, ByVal Tela As String)

        If Usuário = "ADMIN" Then
            Edi = True
            Adi = True
            Exc = True
            Con = True
            Ina = False
            Exit Sub
        End If

        Dim EmEdição As Boolean = False

        Try

            Edi = False
            Adi = False
            Exc = False
            Con = False
            Ina = True

            Tela = UCase(Tela)

            Dim i As Integer
            For i = 0 To SnhArray.Count - 1
                If SnhArray(i).login = Usuário Then
                    If SnhArray(i).Tela = Tela Then
                        Edi = SnhArray(i).Altera
                        Adi = SnhArray(i).Adiciona
                        Exc = SnhArray(i).Exclui
                        Con = SnhArray(i).Consultar
                        Ina = SnhArray(i).Inativo
                        Exit For
                    Else
                        Edi = False
                        Adi = False
                        Exc = False
                        Con = False
                        Ina = True
                    End If
                End If
            Next

        Catch Merror As System.Exception
            MsgBox("Verifique se existe a tabela ou o usuário cadastrado todas as operações serão canceladas: verifique com o administrador.", 64, "Bloqueio de Dados")
            Exit Sub
        End Try
    End Sub

End Module
