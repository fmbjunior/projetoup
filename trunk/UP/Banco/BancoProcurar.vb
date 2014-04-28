Public Class BancoProcurar

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2


    Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Cnn.Close()
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged
        Me.TxtProcurar.Clear()
        Me.TxtProcurar.Focus()
    End Sub

    Private Sub BancoProcurar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Insert Then
            TRVDados(UserAtivo, "CodigoSegurança")
            If Ina = True Then
                MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
                Exit Sub
            Else
                My.Forms.CodigoSegurança.ShowDialog()
            End If
        End If
    End Sub

    Private Sub BancoProcurar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.Open()
        Me.A1.Checked = True
        Me.TxtProcurar.Focus()
    End Sub

    Private Sub TxtProcurar_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProcurar.Leave
        If Me.TxtProcurar.Text = "" Then
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        MyLista.Items.Clear()

        Dim CampoFilter As String = ""

        If Me.A1.Checked = True Then
            CampoFilter = "Documento"
        ElseIf Me.A2.Checked = True Then
            CampoFilter = "ValorDocumento"
        ElseIf Me.A3.Checked = True Then
            CampoFilter = "Historico"
        End If

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM LancamentoBanco WHERE Empresa =" & CodEmpresa & " And " & CampoFilter & " Like '%" & Me.TxtProcurar.Text & "' & '%' and  ContaCorrente = '" & My.Forms.BancoVisualizador.Codigo.Text & "' order by Id"
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            Dim Zebrar As Boolean = False
            While DataReader.Read
                If Not IsDBNull(DataReader.Item("Id")) Then
                    Dim AA As String = DataReader.Item("Id")
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("Documento") & "")
                    item1.SubItems.Add(FormatNumber(Nz(DataReader.Item("ValorDocumento"), 3), 2))
                    item1.SubItems.Add(DataReader.Item("Historico") & "")

                    MyLista.Items.AddRange(New ListViewItem() {item1})

                    If Zebrar = True Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.MediumOrchid
                        Zebrar = True
                    End If

                End If
            End While

            DataReader.Close()
            Me.Cursor = Cursors.Default

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try

    End Sub


    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
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


        Dim Sql As String = "SELECT LancamentoBanco.* FROM LancamentoBanco WHERE LancamentoBanco.Id = " & RetornoProcura


        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then

            Me.Id.Text = DR.Item("Id")
            Me.DataLancamento.Text = DR.Item("DataLancamento") & ""
            Me.PreDatado.Checked = DR.Item("PreDatado")
            Me.DataPreDatado.Text = DR.Item("DataPreDatado") & ""
            Me.Documento.Text = DR.Item("Documento") & ""
            Me.DataDocumento.Text = DR.Item("DataDocumento")
            Me.TipoLancamento.Text = DR.Item("TipoLancamento") & ""
            Me.ContaCorrenteTranferencia.Text = DR.Item("ContaCorrenteTranferencia") & ""
            Me.Favorecido.Text = DR.Item("Favorecido") & ""
            Me.Historico.Text = DR.Item("Historico") & ""
            Me.CaiuBanco.Text = DR.Item("CaiuBanco") & ""
            Me.ValorDocumento.Text = DR.Item("ValorDocumento")
            'My.Forms.BancoVisualizador.Codigo.Text = DR.Item("")
            Operation = UPD
            Me.DataLancamento.Focus()
        End If
        DR.Close()

    End Sub


    Private Sub btNaoCompensar_Click(sender As Object, e As EventArgs) Handles btNaoCompensar.Click


        If MessageBox.Show("Deseja realmente voltar o documento.", "Validação de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

            Dim Sql As String = "Update LancamentoBanco Set CaiuBanco = 'N' Where LancamentoBanco.Id = " & RetornoProcura
            Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
            CMD.ExecuteNonQuery()

            Me.CaiuBanco.Text = "N"

            MessageBox.Show("Documento retornado com sucesso.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


    End Sub
End Class