Module FormIsLoad
    Public Function EstaCarregado(ByVal strNomeDoForm As String) As Boolean
        ' Retorna True se o formulário especificado está aberto

        Dim valnome As String

        Dim X As System.Windows.Forms.Form
        For Each X In My.Application.OpenForms
            If X.Name = strNomeDoForm Then
                valnome = strNomeDoForm
                EstaCarregado = True
                Exit For
            Else

            End If

        Next X
    End Function
End Module
