Imports System.Data.OleDb
Public Class TelaProcura

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
            Exit Sub
        End If

        MyLista.Items.Clear()

        Dim CampoFilter As String = ""
        If Me.CampoChave.Checked = True Then
            CampoFilter = CpFind
        Else
            CampoFilter = CpReturn
        End If


        Dim Cmd As New OleDbCommand()
        Dim DataReader As OleDbDataReader

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            If MultiEmpresa = False Then
                .CommandText = "SELECT * FROM " & TableProcura & " WHERE Inativo = False and " & CampoFilter & " Like '%" & Me.TxtProcura.Text & "' & '%' order by " & CampoFilter
            Else
                .CommandText = "SELECT * FROM " & TableProcura & " WHERE Empresa = " & CodEmpresa & " AND Inativo = False and " & CampoFilter & " Like '%" & Me.TxtProcura.Text & "' & '%' order by " & CampoFilter
            End If
            If TableProcura = "ConfNfSystem" Then .CommandText = "SELECT * FROM " & TableProcura & " WHERE CodEmpresa = " & CodEmpresa & " AND Inativo = False and " & CampoFilter & " Like '%" & Me.TxtProcura.Text & "' & '%' order by " & CampoFilter

            If TableProcura = "FolhaPgtoEventos" Then
                If SomenteEvento <> "" Then
                    .CommandText = "SELECT * FROM " & TableProcura & " WHERE Empresa = " & CodEmpresa & " AND Inativo = False and SomenteEvento = '" & SomenteEvento & "' and " & CampoFilter & " Like '%" & Me.TxtProcura.Text & "' & '%' order by " & CampoFilter
                End If
            End If

            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(CpFind)) Then
                    Dim AA As String = DataReader.Item(CpFind)
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item(CpReturn) & "")
                    If CpColuna3 <> "" Then
                        item1.SubItems.Add(DataReader.Item(CpColuna3) & "")
                    End If
                    MyLista.Items.AddRange(New ListViewItem() {item1})

                End If
            End While

            DataReader.Close()
            Me.MyLista.Focus()
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try

    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAtualizar.Click
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
        btAtualizar_Click(sender, e)
    End Sub

    Private Sub TelaProcura_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.TxtProcura.Focus()
    End Sub

    

    Private Sub TelaProcura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

    Private Sub MostraTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostraTodos.CheckedChanged

        MyLista.Items.Clear()
        Me.Cursor = Cursors.WaitCursor
        Dim Cmd As New OleDbCommand()
        Dim DataReader As OleDbDataReader

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            If MultiEmpresa = False Then
                .CommandText = "SELECT * FROM " & TableProcura & " WHERE Inativo = False order by " & CpReturn
            Else
                .CommandText = "SELECT * FROM " & TableProcura & " WHERE Empresa = " & CodEmpresa & " AND Inativo = False order by " & CpReturn
            End If
            If TableProcura = "ConfNfSystem" Then .CommandText = "SELECT * FROM " & TableProcura & " WHERE CodEmpresa = " & CodEmpresa & " AND Inativo = False order by " & CpReturn
            If TableProcura = "FolhaPgtoEventos" Then
                If SomenteEvento <> "" Then
                    .CommandText = "SELECT * FROM " & TableProcura & " WHERE Empresa = " & CodEmpresa & " AND Inativo = False And SomenteEvento = '" & SomenteEvento & "' order by " & CpReturn
                End If
            End If

            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(CpFind)) Then
                    Dim AA As String = DataReader.Item(CpFind)
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item(CpReturn) & "")
                    If CpColuna3 <> "" Then
                        item1.SubItems.Add(DataReader.Item(CpColuna3) & "")
                    End If

                    MyLista.Items.AddRange(New ListViewItem() {item1})

                End If
            End While
            DataReader.Close()
            Me.MyLista.Focus()
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MyLista_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyLista.KeyDown
        If e.KeyCode = Keys.Enter Then
            btAtualizar_Click(sender, e)
        End If
    End Sub
End Class