Imports System.IO

Public Class VerificaLicenca

    Public Function IsValida() As Boolean
        Dim ArquiviLicenca As String = Environment.CurrentDirectory.ToString & "\Lcfg.Lis"

        If ArquiviLicenca = "" Then
            Return False
            Exit Function
        End If

        Dim arq As New System.IO.FileInfo(ArquiviLicenca)
        If Not arq.Exists Then
            MessageBox.Show("Arquivo de Licença não Encontrado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End If

        Dim Crypto As New ClCrypto


        Dim Linha As String = String.Empty
        Dim LTemp As String = String.Empty
        Dim reader As New IO.StreamReader(ArquiviLicenca)

        Try
            While Not reader.EndOfStream
                LTemp = reader.ReadLine
                Linha = Crypto.clsCrypto(LTemp, False)
            End While
        Catch ex As Exception
            MessageBox.Show("Erro na Leitura do arquivo de Licença ou o arquivo foi danificado", "Validador de Licença", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Exit Function
        End Try

        If Linha = "" Then
            Return False
            Exit Function
        End If

        If Linha = "Expirado" Then
            Return False
            Exit Function
        End If

        If Linha = "Sem Expiracao" Then
            Return True
            Exit Function
        End If

        Dim DataAgora As String = Format(CDate(Today.Date), "dd/MM/yyyy")
        If CDate(DataAgora) > CDate(Linha) Then

            reader.Close()

            Dim SW As IO.StreamWriter
            Dim ArquivoSaida As String = ArquiviLicenca
            SW = File.CreateText(ArquivoSaida)
            SW.WriteLine(Crypto.clsCrypto("Expirado", True))
            SW.Close()
            Return False
            Exit Function

        Else
            Return True
            Exit Function
        End If

    End Function

End Class
