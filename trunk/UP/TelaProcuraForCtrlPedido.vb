Imports System.Data.OleDb
Public Class TelaProcuraForCtrlPedido

    Dim Cnn As OleDbConnection

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
            CampoFilter = "CódigoFornecedor"
        End If

        If Me.RazãoSocial.Checked = True Then
            CampoFilter = "RazãoSocial"
        End If

        If Me.Fantasia.Checked = True Then
            CampoFilter = "NomeFantasia"
        End If


        Dim Cmd As New OleDbCommand()
        Dim DataReader As OleDbDataReader

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            If EstaCarregado("DocumentoEntrada") = True Then
                .CommandText = "SELECT * FROM Fornecedor WHERE Empresa = " & CodEmpresa & " AND Inativo = False and " & CampoFilter & " Like '%" & Me.TxtProcura.Text & "' & '%' order by " & CampoFilter
            Else
                .CommandText = "SELECT * FROM Fornecedor WHERE Empresa = " & CodEmpresa & " AND Inativo = False and " & CampoFilter & " Like '%" & Me.TxtProcura.Text & "' & '%' order by " & CampoFilter
            End If
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item("CódigoFornecedor")) Then
                    Dim AA As String = DataReader.Item("CódigoFornecedor")
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("RazãoSocial") & "")
                    item1.SubItems.Add(DataReader.Item("NomeFantasia") & "")
                    item1.SubItems.Add(DataReader.Item("CgcCpf") & "")

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

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        Dim I As Integer = 0
        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then RetornoProcura = (MyLista.Items(I).Text.Substring(0))
        Next

        If RetornoProcura = "" Then
            MsgBox("O usuário deve informar um iten da lista de procura.", 64, "Validação de Dados")
            Me.MyLista.Focus()
            Exit Sub
        End If

        'My.Forms.CompraCtrPedido.Fornecedor.Text = RetornoProcura
        Cnn.Close()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub TelaProcura_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.TxtProcura.Focus()
    End Sub

    Private Sub TelaProcura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            Me.TxtProcura.Clear()
            Me.TxtProcura.Focus()
        End If

    End Sub

    Private Sub TelaProcura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Degrade()

        Me.RazãoSocial.Checked = True
        Me.TxtProcura.Focus()
    End Sub

    Private Sub CampoChave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CampoChave.Click, RazãoSocial.Click, Fantasia.Click
        Me.TxtProcura.Clear()
        Me.TxtProcura.Focus()
    End Sub

 

    Private Sub MostraTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostraTodos.CheckedChanged

        MyLista.Items.Clear()

        Dim Cmd As New OleDbCommand()
        Dim DataReader As OleDbDataReader

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM Fornecedor WHERE Empresa = " & CodEmpresa & " AND Inativo = False order by RazãoSocial"
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader
            While DataReader.Read
                If Not IsDBNull(DataReader.Item("CódigoFornecedor")) Then
                    Dim AA As String = DataReader.Item("CódigoFornecedor")
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("RazãoSocial") & "")
                    item1.SubItems.Add(DataReader.Item("NomeFantasia") & "")
                    item1.SubItems.Add(DataReader.Item("CgcCpf") & "")

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

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Cnn.Close()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub MyLista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyLista.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim I As Integer = 0
            For I = 0 To MyLista.Items.Count - 1
                If MyLista.Items(I).Selected = True Then RetornoProcura = (MyLista.Items(I).Text.Substring(0))
            Next

            If RetornoProcura = "" Then
                MsgBox("O usuário deve informar um iten da lista de procura.", 64, "Validação de Dados")
                Me.MyLista.Focus()
                Exit Sub
            End If

            'My.Forms.CompraCtrPedido.Fornecedor.Text = RetornoProcura
            Cnn.Close()
            Me.Close()
            Me.Dispose()
        End If
    End Sub

End Class