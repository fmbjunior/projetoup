Public Class CepLocalizar

    Dim strConn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & LocalBD & "Cep.mdb" '& ";User ID=Administrador;Password=jeova"

    Dim CNN As New OleDb.OleDbConnection(strConn)

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btAchar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAchar.Click


        MyLista.Items.Clear()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader


        With Cmd
            .Connection = CNN
            .CommandTimeout = 0
            .CommandText = "SELECT tblLogradouros.UF, tblLogradouros.CodigoCidade, tblCidades.Descricao, tblCidades.UF, tblLogradouros.CodigoBairro, tblBairros.Descricao, tblLogradouros.CEP, tblLogradouros.DescricaoSemAcento, tblLogradouros.LOG_COMPLEMENTO, tblLogradouros.LOG_TIPO_LOGRADOURO FROM tblCidades INNER JOIN (tblBairros INNER JOIN tblLogradouros ON tblBairros.Codigo = tblLogradouros.CodigoBairro) ON tblCidades.Codigo = tblBairros.CodigoCidade WHERE (((tblCidades.Descricao)='" & Me.Cidade.Text & "') AND ((tblCidades.UF)='" & Me.UF.Text & "') AND ((tblLogradouros.DescricaoSemAcento) Like '%' & '" & Me.Logradouro.Text & "' & '%'));"
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            Dim Zebrar As Boolean = False
            While DR.Read
                If Not IsDBNull(DR.Item("DescricaoSemAcento")) Then
                    Dim AA As String = DR.Item("DescricaoSemAcento")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("tblBairros.Descricao") & "")
                    It.SubItems.Add(DR.Item("Cep") & "")
                    It.SubItems.Add(DR.Item("LOG_COMPLEMENTO") & "")

                    MyLista.Items.AddRange(New ListViewItem() {It})

                    If Zebrar = False Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.MistyRose
                        Zebrar = True
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    End If

                End If
            End While

            DR.Close()

            Me.MyLista.Focus()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub CepLocalizar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CNN.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

   
End Class