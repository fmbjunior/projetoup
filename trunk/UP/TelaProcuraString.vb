Imports System.Data.OleDb
Public Class TelaProcuraString

    Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

    Private Sub TxtProcura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtProcura.KeyPress
        Dim Tecla As Short = Asc(e.KeyChar)

        If Tecla = 13 Then
            System.Windows.Forms.SendKeys.Send("{Tab}")
            Tecla = 0
        End If
    End Sub

    Private Sub TxtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProcura.Leave
        If Me.TxtProcura.Text = "" Then
            Me.TxtProcura.Focus()
            Exit Sub
        End If

        MyLista.Items.Clear()

       


        Dim Cmd As New OleDbCommand()
        Dim DataReader As OleDbDataReader

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = TableProcura
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(CpReturn)) Then
                    Dim AA As String = DataReader.Item(CpReturn)
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item(CpFind) & "")
                    If CpColuna3 <> "" Then
                        Select Case DataReader.Item(CpColuna3)
                            Case "1"
                                item1.SubItems.Add("Em Andamento")
                            Case "2"

                            Case "3"

                        End Select

                    End If
                    MyLista.Items.AddRange(New ListViewItem() {item1})

                End If
            End While

            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try

    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Atualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Atualizar.Click
        RetornoProcura = ""
        Dim I As Integer = 0

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then RetornoProcura = (MyLista.Items(I).Text.Substring(0))
        Next

        If RetornoProcura = "" Then
            MsgBox("O usuário deve informar um iten da lista de procura.", 64, "Validação de Dados")
            Me.MyLista.Focus()
            Exit Sub
        End If
        Cnn.Close()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        Atualizar_Click(sender, e)
    End Sub

    Private Sub TelaProcura_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.TxtProcura.Focus()
    End Sub

    Private Sub TelaProcura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F11 Then
            Fechar_Click(sender, e)
        End If

        If e.KeyCode = Keys.F5 Then
            Me.TxtProcura.Clear()
            Me.TxtProcura.Focus()
        End If

    End Sub

    Private Sub TelaProcura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()

        Cnn.Open()
        Me.AlfaNumerica.Checked = True
        Me.Col1.Text = Coluna1
        Me.Col2.Text = Coluna2
        Me.Col3.Text = Coluna3
        Me.TxtProcura.Focus()
    End Sub

    Private Sub AlfaNumerica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlfaNumerica.Click
        Me.TxtProcura.Focus()
    End Sub

    Private Sub CampoChave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CampoChave.Click
        Me.TxtProcura.Focus()
    End Sub

    Private Sub MyLista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyLista.KeyDown
        If e.KeyCode = Keys.Enter Then
            Atualizar_Click(sender, e)
        End If
    End Sub

    Private Sub MostraTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostraTodos.CheckedChanged

        MyLista.Items.Clear()
        Me.Cursor = Cursors.WaitCursor
        Dim Cmd As New OleDbCommand()
        Dim DataReader As OleDbDataReader

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = TableProcura
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(CpReturn)) Then
                    Dim AA As String = DataReader.Item(CpReturn)
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item(CpFind) & "")
                    If CpColuna3 <> "" Then
                        item1.SubItems.Add(DataReader.Item(CpColuna3) & "")
                    End If

                    MyLista.Items.AddRange(New ListViewItem() {item1})

                End If
            End While
            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Degrade()
        Try
            Dim CCor() As String
            Dim corTemp As String

            corTemp = Cor1TelaSecundaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))

            corTemp = Cor2TelaSecundaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxtProcura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtProcura.TextChanged

    End Sub
End Class