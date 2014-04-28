Imports System.Data.OleDb
Public Class TelaProcuraCtrlPedido

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
            CampoFilter = "Id"
        End If

        If Me.AlfaNumerica.Checked = True Then
            CampoFilter = "FornecedorDesc"
        End If

        If Me.DocumentoFornecedor.Checked = True Then
            CampoFilter = "Documento"
        End If


        If Me.rdbSolicitacao.Checked = True Then
            CampoFilter = "Solicitacao"
        End If

        Dim Cmd As New OleDbCommand()
        Dim DataReader As OleDbDataReader

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            If MultiEmpresa = False Then
                .CommandText = "SELECT * FROM CompraCtrlPedido WHERE Empresa = " & CodEmpresa & " Inativo = False and " & CampoFilter & " Like '%" & Me.TxtProcura.Text & "' & '%' And Solicitacao <> 0 order by " & CampoFilter
            Else
                .CommandText = "SELECT * FROM CompraCtrlPedido WHERE Empresa = " & CodEmpresa & " and Inativo = False and " & CampoFilter & " Like '%" & Me.TxtProcura.Text & "%' And Solicitacao <> 0 Order by " & CampoFilter
            End If
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader
            'Dim ss As Integer = DataReader.Item
            While DataReader.Read
                If Not IsDBNull(DataReader.Item("Id")) Then
                    Dim AA As String = DataReader.Item("Id")
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("FornecedorDesc") & "")
                    item1.SubItems.Add(DataReader.Item("Documento") & "")
                    item1.SubItems.Add(FormatNumber(DataReader.Item("ValorPedido"), 2))
                    item1.SubItems.Add(DataReader("Solicitacao"))
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

    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        Cnn.Close()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub AtualizarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarBT.Click

        Dim RetornoProcura As String = ""
        Dim I As Integer = 0
        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then RetornoProcura = (MyLista.Items(I).Text.Substring(0))
        Next

        If RetornoProcura = "" Then
            MsgBox("O usuário deve informar um iten da lista de procura.", 64, "Validação de Dados")
            Me.MyLista.Focus()
            Exit Sub
        End If
        If My.Forms.CompraCtrPedido.Visible = True Then
            My.Forms.CompraCtrPedido.Id.Text = RetornoProcura
        End If
        Cnn.Close()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        AtualizarBT_Click(sender, e)
    End Sub

    Private Sub TelaProcura_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.TxtProcura.Focus()
    End Sub

    Private Sub TelaProcura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F11 Then
            FecharBT_Click(sender, e)
        End If

        If e.KeyCode = Keys.F5 Then
            Me.TxtProcura.Clear()
            Me.TxtProcura.Focus()
        End If

    End Sub

    Private Sub TelaProcura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Degrade()

        Me.AlfaNumerica.Checked = True
        Me.TxtProcura.Focus()
    End Sub

    Private Sub AlfaNumerica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlfaNumerica.Click
        Me.TxtProcura.Focus()
    End Sub

    Private Sub CampoChave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CampoChave.Click, rdbSolicitacao.Click
        Me.TxtProcura.Focus()
    End Sub

    Private Sub MyLista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyLista.KeyDown
        If e.KeyCode = Keys.Enter Then
            AtualizarBT_Click(sender, e)
        End If
    End Sub

    Private Sub MostraTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostraTodos.CheckedChanged

        MyLista.Items.Clear()

        Dim Cmd As New OleDbCommand()
        Dim DataReader As OleDbDataReader

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            If MultiEmpresa = False Then
                .CommandText = "SELECT * FROM CompraCtrlPedido WHERE Inativo = False And Solicitacao <> 0 order by Id"
            Else
                .CommandText = "SELECT * FROM CompraCtrlPedido WHERE Empresa = " & CodEmpresa & " AND Inativo = False And Solicitacao <> 0 order by Id"
            End If
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader
            While DataReader.Read
                If Not IsDBNull(DataReader.Item("Id")) Then
                    Dim AA As String = DataReader.Item("Id")
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("FornecedorDesc") & "")
                    item1.SubItems.Add(DataReader.Item("Documento") & "")
                    item1.SubItems.Add(Format(NzZero(DataReader.Item("ValorPedido")), "#,##0.00"))
                    item1.SubItems.Add(DataReader.Item("Solicitacao") & "")
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

    Private Sub TxtProcura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class