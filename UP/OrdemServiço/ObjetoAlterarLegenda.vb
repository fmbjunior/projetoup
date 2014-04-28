Public Class ObjetoAlterarLegenda


    Private fControl As Control
    Public Property OwnerControl() As Control
        Get
            Return fControl
        End Get
        Set(ByVal value As Control)
            Me.fControl = value
        End Set
    End Property

    Dim LgAlter As String = String.Empty
    Public Property LegendaAlterar() As String
        Get
            Return LgAlter
        End Get
        Set(ByVal value As String)
            LgAlter = value
        End Set
    End Property

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Update ObjetosConf set " & LgAlter & " = @1 Where NomeConf = 'NOME-OBJETOS'"
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.NovoTexto.Text, 1)))

        Try
            cmd.ExecuteNonQuery()
        Catch x As Exception
            MsgBox(x.Message)
            Exit Sub
        End Try
        CNN.Close()
        Me.Close()
        Me.Dispose()


    End Sub

    Private Sub ObjetoAlterarLegenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim pt As Point
            Dim scrPt As Point
            pt = New Point(fControl.Left + fControl.Width, fControl.Top + fControl.Height)
            scrPt = New Point(fControl.FindForm().Left + pt.X + 5, fControl.FindForm().Top + pt.Y + 3)
            CenterToScreen()
            Me.Location = scrPt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        VerificarDados()
    End Sub


    Private Sub VerificarDados()
       
        Try
            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()


            Dim ds As New DataSet
            Dim Sql As String = String.Empty

            Sql = "SELECT * from ObjetosConf Where NomeConf = 'NOME-OBJETOS'"
            Dim DAObj As New OleDb.OleDbDataAdapter(Sql, CNN)
            DAObj.Fill(ds, "Objetos")


            If ds.Tables("Objetos").Rows.Count = 0 Then
                Dim DRnovo As DataRow
                DRnovo = ds.Tables("Objetos").NewRow

                DRnovo("NomeConf") = "NOME-OBJETOS"
                DRnovo("CP1") = "Veiculo"
                DRnovo("CP2") = "Placa"
                DRnovo("CP3") = "Km"
                DRnovo("CP4") = "Renavan"
                DRnovo("CP5") = "Cor"
                DRnovo("CP6") = System.DBNull.Value
                ds.Tables("Objetos").Rows.Add(DRnovo)

                Dim objBuilder As New OleDb.OleDbCommandBuilder(DAObj)
                DAObj.Update(ds, "Objetos")
                ds.Dispose()
                CNN.Close()
            Else
                ds.Dispose()
                CNN.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    
End Class