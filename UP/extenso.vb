Imports System.reflection

Namespace ActiveIT

    Public Class cExtenso

        Private aUnd(10) As String
        Private aDez(10) As String
        Private aDezEsp(10) As String
        Private aCen(10) As String
        Private aCasa(5, 2) As String

        Public Sub New()

            'Inicializa o array de unidades
            aUnd(1) = "UM"
            aUnd(2) = "DOIS"
            aUnd(3) = "TRES"
            aUnd(4) = "QUATRO"
            aUnd(5) = "CINCO"
            aUnd(6) = "SEIS"
            aUnd(7) = "SETE"
            aUnd(8) = "OITO"
            aUnd(9) = "NOVE"

            'Inicializa o array de dezenas
            aDez(1) = "DEZ"
            aDez(2) = "VINTE"
            aDez(3) = "TRINTA"
            aDez(4) = "QUARENTA"
            aDez(5) = "CINQUENTA"
            aDez(6) = "SESSENTA"
            aDez(7) = "SETENTA"
            aDez(8) = "OITENTA"
            aDez(9) = "NOVENTA"

            'Inicializa o array de dezenas especiais
            aDezEsp(1) = "ONZE"
            aDezEsp(2) = "DOZE"
            aDezEsp(3) = "TREZE"
            aDezEsp(4) = "QUATORZE"
            aDezEsp(5) = "QUINZE"
            aDezEsp(6) = "DEZESSEIS"
            aDezEsp(7) = "DEZESSETE"
            aDezEsp(8) = "DEZOITO"
            aDezEsp(9) = "DEZENOVE"

            'Inicializa o array de centenas
            aCen(1) = "CEM"
            aCen(2) = "DUZENTOS"
            aCen(3) = "TREZENTOS"
            aCen(4) = "QUATROCENTOS"
            aCen(5) = "QUINHENTOS"
            aCen(6) = "SEISCENTOS"
            aCen(7) = "SETECENTOS"
            aCen(8) = "OITOCENTOS"
            aCen(9) = "NOVECENTOS"

            'Inicializa o array de casas 

            aCasa(1, 1) = "REAL"
            aCasa(1, 2) = "REAIS"
            aCasa(2, 1) = "MIL"
            aCasa(2, 2) = "MIL"
            aCasa(3, 1) = "MILHÃO"
            aCasa(3, 2) = "MILHÕES"
            aCasa(4, 1) = "BILHÃO"
            aCasa(4, 2) = "BILHÕES"
            aCasa(5, 1) = "TRILHÃO"
            aCasa(5, 2) = "TRILHÕES"

        End Sub

        Public Function Executar(ByVal pvalor As Decimal) As String
            Dim sNum, scen, texto As String
            Dim icen, i As Integer
            Dim fracao As Decimal
            Dim cValor As Collection
            Dim inum As Int64

            fracao = pvalor - Int(pvalor)
            icen = fracao * 100
            scen = Format(icen, "0")
            texto = ""

            cValor = DesmembraValor(pvalor)

            For i = cValor.Count To 1 Step -1

                sNum = cValor(i)
                inum = Int(cValor(i))
                If Len(sNum) = 3 Then
                    texto &= TrataCentena(sNum)
                    texto &= TrataDezena(sNum)
                    texto &= TrataUnidade(sNum)
                    texto &= " " & aCasa(i, 2)
                ElseIf Len(sNum) = 2 Then
                    sNum = Format(Int(inum), "000")
                    texto &= TrataDezena(sNum)
                    texto &= TrataUnidade(sNum)
                    texto &= " " & aCasa(i, 2)
                ElseIf (Len(sNum) = 1) And (sNum <> 0) Then
                    sNum = Format(Int(inum), "000")
                    texto &= TrataUnidade(sNum)
                    If (CInt(sNum) > 1) Then
                        texto &= " " & aCasa(i, 2)
                    Else
                        texto &= " " & aCasa(i, 1)
                    End If
                Else
                    If i = 1 Then

                        If cValor.Count <= 2 Then
                            texto &= " " & aCasa(i, 2)
                        Else
                            texto &= " DE " & aCasa(i, 2)
                        End If

                    End If
                End If

                If (i > 1) Then
                    If (cValor(i - 1) <> "0") Then
                        If cValor(i) = "1" Then
                            texto &= " E "
                        Else
                            texto &= ", "
                        End If
                    End If
                End If


            Next

            'Trata Centavos
            If icen > 0 Then
                texto &= " E "

                If Len(scen) = 2 Then
                    scen = Format(Int(icen), "000")
                    texto &= TrataDezena(scen)
                    texto &= TrataUnidade(scen)
                Else
                    scen = Format(Int(icen), "000")
                    texto &= TrataUnidade(scen)
                End If

                If icen > 1 Then
                    texto &= " CENTAVOS"
                Else
                    texto &= " CENTAVO"
                End If
            End If

            Return texto

        End Function

        Private Function DesmembraValor(ByVal valor As Decimal) As Collection
            Dim tamNum, Ini As Integer
            Dim iNum As Int64
            Dim sNum, pedaco As String
            Dim vals As New Collection()
            Dim cont = 1

            iNum = Int(valor)
            sNum = Format(iNum, "0")
            tamNum = Len(sNum)

            While tamNum > 0
                Ini = tamNum - 2
                If Ini > 0 Then
                    pedaco = CInt(Mid(sNum, Ini, 3))
                    vals.Add(pedaco)
                    tamNum -= 3
                ElseIf Ini = 0 Then
                    pedaco = CInt(Mid(sNum, 1, 2))
                    vals.Add(pedaco)
                    tamNum = 0
                Else
                    pedaco = CInt(Mid(sNum, 1, tamNum))
                    vals.Add(pedaco)
                    tamNum = 0
                End If

            End While

            Return vals

        End Function


        Private Function TrataCentena(ByVal pNum As String) As String
            Dim numero(3) As String
            Dim extenso As String
            numero(0) = Mid(pNum, 1, 1)
            numero(1) = Mid(pNum, 2, 1)
            numero(2) = Mid(pNum, 3, 1)

            extenso = aCen(CInt(numero(0)))
            If (numero(0) = "1") Then
                If (CInt(numero(1)) + CInt(numero(2))) <> 0 Then
                    extenso = "CENTO E "
                End If
            Else
                If (CInt(numero(1)) + CInt(numero(2))) <> 0 Then
                    extenso &= " E "
                End If
            End If

            Return extenso

        End Function

        Private Function TrataDezena(ByVal pNum As String) As String
            Dim numero(3) As String
            Dim extenso As String = ""
            Dim dezesp As String = ""

            numero(0) = Mid(pNum, 2, 1)
            numero(1) = Mid(pNum, 3, 1)
            dezesp = Mid(pNum, 2, 2)

            If (CInt(dezesp) > 10) And (CInt(dezesp) < 20) Then
                extenso = aDezEsp(CInt(numero(1)))
            Else
                If (numero(0) <> "0") And (numero(1) <> "0") Then
                    extenso = aDez(CInt(numero(0))) & " E "
                Else
                    If numero(0) <> "0" Then
                        extenso = aDez(CInt(numero(0)))
                    End If
                End If
            End If

            Return extenso

        End Function

        Private Function TrataUnidade(ByVal pNum As String) As String
            Dim numero(3) As String
            Dim extenso As String = ""
            Dim dezEsp As String
            dezEsp = Mid(pNum, 2, 2)
            numero(0) = Mid(pNum, 3, 1)
            If (CInt(dezEsp) > 10) And (CInt(dezEsp) < 20) Then
                extenso = ""
            Else
                extenso = aUnd(CInt(numero(0)))
                Return extenso
                Exit Function
            End If
            Return extenso
        End Function

        Public Function Justifica_linhas(ByVal pExtenso As String, ByVal pLargura As Integer) As Collection
            Dim sf As String()
            Dim linhas As New Collection()
            Dim i, q As Integer
            Dim texto As String
            'dim textoorg As String
            sf = Split(pExtenso)
            q = sf.Length - 1
            texto = ""
            For i = 0 To q
                If (sf(i).Length + texto.Length) <= pLargura Then
                    texto = texto + sf(i) + " "
                Else
                    texto = Organiza_texto(texto, pLargura)
                    linhas.Add(texto)
                    texto = sf(i) & " "
                End If

            Next
            If texto.Length > 0 Then
                texto = texto.PadRight(pLargura, "*")
                linhas.Add(texto)
            End If

            Return linhas

        End Function

        Private Function Organiza_texto(ByVal pTexto As String, ByVal pLargura As Integer) As String
            Dim tamtexto As Integer
            Dim i, sobra, pos, ini, desloca As Integer
            Dim PosEspaco As New Collection()
            Dim novotexto As String
            pTexto = RTrim(pTexto)
            tamtexto = Len(pTexto)
            sobra = pLargura - tamtexto
            ini = 1
            While sobra > 0
                pos = InStr(ini, pTexto, " ")
                If pos > 0 Then
                    PosEspaco.Add(pos)
                    ini = pos + 1
                    sobra -= 1
                End If
            End While
            novotexto = pTexto
            desloca = 0
            For i = 1 To PosEspaco.Count
                novotexto = novotexto.Insert(PosEspaco(i) + desloca, " ")
                desloca += 1
            Next
            Return novotexto
        End Function

    End Class

End Namespace

