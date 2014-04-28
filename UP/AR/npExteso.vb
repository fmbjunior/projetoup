Public Class npExteso 
    Public Function xExtenso(ByVal DT As String)
        Dim D As String
        Dim M As String
        Dim A As String


        D = Mid(DT, 1, 2)
        M = Mid(DT, 4, 2)
        A = Mid(DT, 7, 4)

        Dim strmes As String = ""
        Dim strDia As String = "" '
        Dim strano As String = ""
        Dim dezena10 As String = ""
        Dim dezena20 As String = ""
        Dim dezena30 As String = ""

        dezena10 = "décimo"
        dezena20 = "vigésimo"
        dezena30 = "trigésimo"

        Dim MesExt As String

        Dim dia1 As String
        Dim dia2 As String
        Dim dia3 As String
        Dim dia4 As String
        Dim dia5 As String
        Dim dia6 As String
        Dim dia7 As String
        Dim dia8 As String
        Dim dia9 As String

        dia1 = "primeiro"
        dia2 = "sengundo"
        dia3 = "terceiro"
        dia4 = "quarto"
        dia5 = "quito"
        dia6 = "sexto"
        dia7 = "sétimo"
        dia8 = "oitavo"
        dia9 = "nono"



        Select Case D
            Case "01"
                strDia = dia1
            Case "02"
                strDia = dia2
            Case "03"
                strDia = dia3
            Case "04"
                strDia = dia4
            Case "05"
                strDia = dia5
            Case "06"
                strDia = dia6
            Case "07"
                strDia = dia7
            Case "08"
                strDia = dia8
            Case "09"
                strDia = dia9
            Case "10"
                strDia = dezena10
            Case "11"
                strDia = dezena10 & " " & dia1
            Case "12"
                strDia = dezena10 & " " & dia2
            Case "13"
                strDia = dezena10 & " " & dia3
            Case "14"
                strDia = dezena10 & " " & dia4
            Case "15"
                strDia = dezena10 & " " & dia5
            Case "16"
                strDia = dezena10 & " " & dia6
            Case "17"
                strDia = dezena10 & " " & dia7
            Case "18"
                strDia = dezena10 & " " & dia8
            Case "19"
                strDia = dezena10 & " " & dia9
            Case "20"
                strDia = dezena20
            Case "21"
                strDia = dezena20 & " " & dia1
            Case "22"
                strDia = dezena20 & " " & dia2
            Case "23"
                strDia = dezena20 & " " & dia3
            Case "24"
                strDia = dezena20 & " " & dia4
            Case "25"
                strDia = dezena20 & " " & dia5
            Case "26"
                strDia = dezena20 & " " & dia6
            Case "27"
                strDia = dezena20 & " " & dia7
            Case "28"
                strDia = dezena20 & " " & dia8
            Case "29"
                strDia = dezena20 & " " & dia9
            Case "30"
                strDia = dezena30
            Case "31"
                strDia = dezena30 & " " & dia1
        End Select

        Select Case M
            Case "01"
                strmes = "janeiro"
            Case "02"
                strmes = "fevereiro"
            Case "03"
                strmes = "março"
            Case "04"
                strmes = "abril"
            Case "05"
                strmes = "maio"
            Case "06"
                strmes = "junho"
            Case "07"
                strmes = "julho"
            Case "08"
                strmes = "agosto"
            Case "09"
                strmes = "setembro"
            Case "10"
                strmes = "outubro"
            Case "11"
                strmes = "novembro"
            Case "12"
                strmes = "dezembro"
        End Select

        Select Case A
            Case "01"
                strano = "dois mil e um"

            Case "1999"
                strano = "Hum mil novecentos e noventa e nove"
            Case "2000"
                strano = "dois mil"
            Case "2001"
                strano = "dois mil e um"
            Case "2002"
                strano = "dois mil e dois"
            Case "2003"
                strano = "dois mil e três"
            Case "2004"
                strano = "dois mil e quatro"
            Case "2005"
                strano = "dois mil e cinco"
            Case "2006"
                strano = "dois mil e seis"
            Case "2007"
                strano = "dois mil e sete"
            Case "2008"
                strano = "dois mil e oito"
            Case "2009"
                strano = "dois mil e nove"
            Case "2010"
                strano = "dois mil e dez"
            Case "2011"
                strano = "dois mil e onze"
            Case "2012"
                strano = "dois mil e dose"
            Case "2013"
                strano = "dois mil e treze"
            Case "2014"
                strano = "dois mil e quatorze"
            Case "2015"
                strano = "dois mil e quinze"
            Case "2016"
                strano = "dois mil e desesseis"

        End Select
        MesExt = strDia

        xExtenso = MesExt & " dia do mês de " & strmes & " do ano de " & strano
    End Function
   
End Class
