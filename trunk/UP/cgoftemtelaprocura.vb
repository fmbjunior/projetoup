Imports System.Data.OleDb
Public Class CGOFtemTelaProcura

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

        Dim CampoFilter As String = ""
        If Me.CampoChave.Checked = True Then
            CampoFilter = CpFind
        Else
            CampoFilter = CpReturn
        End If

        Dim Cnn As New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        Dim Cmd As New OleDbCommand()
        Dim DataReader As OleDbDataReader

        Cnn.Open()

        Dim TotalLinhas As Long
        Try
            Dim CmdTotalLinhas As New OleDbCommand("SELECT Count(*) FROM " & TableProcura & " WHERE Inativo = False and " & CpReturn & " Like '%" & Me.TxtProcura.Text & "' & '%'", Cnn)
            TotalLinhas = CInt(CmdTotalLinhas.ExecuteScalar())
        Catch ex As Exception
            Exit Sub
        End Try

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            If MultiEmpresa = False Then
                .CommandText = "SELECT * FROM " & TableProcura & " WHERE Inativo = False and " & CampoFilter & " Like '%" & Me.TxtProcura.Text & "' & '%' order by " & CampoFilter
            Else
                .CommandText = "SELECT * FROM " & TableProcura & " WHERE Empresa = " & CodEmpresa & " AND Inativo = False and " & CampoFilter & " Like '%" & Me.TxtProcura.Text & "' & '%' order by " & CampoFilter
            End If
            If TableProcura = "ConfNfSystem" Then .CommandText = "SELECT * FROM " & TableProcura & " WHERE CodEmpresa = " & CodEmpresa & " AND Inativo = False and " & CampoFilter & " Like '%" & Me.TxtProcura.Text & "' & '%' order by " & CampoFilter
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            'Atualiza a barra de Progresso
            If TotalLinhas = 0 Then TotalLinhas = 1
            MyBarra.Visible = True
            MyBarra.Minimum = 1
            MyBarra.Maximum = TotalLinhas
            MyBarra.Value = 1
            MyBarra.Step = 1
            'Fim dos dados da Barra de Progresso

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(CpFind)) Then
                    Dim AA As String = DataReader.Item(CpFind)
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item(CpReturn) & "")
                    MyLista.Items.AddRange(New ListViewItem() {item1})

                    MyBarra.PerformStep()
                End If
            End While

            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        MyBarra.Visible = False
        Cnn.Close()

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
            MsgBox("O usuário deve informar um iten da lista de procura.", 64, TituloMsgbox)
            Me.MyLista.Focus()
            Exit Sub
        End If
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
        Me.AlfaNumerica.Checked = True
        Me.Col1.Text = Coluna1
        Me.Col2.Text = Coluna2
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
End Class