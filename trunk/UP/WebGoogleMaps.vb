Public Class WebGoogleMaps

    Public Dest As String = String.Empty

    Private Sub btVerRota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Response.Redirect(url)
    End Sub

    Private Sub WebGoogleMaps_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




        Me.txtFrom.Text = DadosEmpresa()
        Me.TxtTo.Text = Dest

        Dim url As String = String.Format("http://maps.google.com/maps?f=d&source=s_d&saddr={0}&daddr={1}", txtFrom.Text, TxtTo.Text)
        Me.WebBrowser1.Url = New System.Uri(url)

    End Sub



    Public Function DadosEmpresa() As String

        Dim Cn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cn.Open()

        Dim CM As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        'Verifica a data de Entrada
        With CM
            .Connection = Cn
            .CommandTimeout = 0
            .CommandText = "SELECT * From Empresa Where CódigoEmpresa = " & CodEmpresa
            .CommandType = CommandType.Text
        End With

        DR = CM.ExecuteReader
        DR.Read()

        Dim var As String = String.Empty
        If DR.HasRows = True Then
            var = DR.Item("Endereço") & ", " & DR.Item("Bairro") & ", " & DR.Item("Cidade") & ", " & DR.Item("Estado")
        End If
        DR.Close()

        Return var
    End Function





    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class