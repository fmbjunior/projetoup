Public Class NFAchar

    Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        CNN.Close()
        Me.Close()
        Me.Dispose()
    End Sub


    Public Sub LocalizaDados(ByVal Campo As String, ByVal Vlr As String)

        Me.MyLista.Items.Clear()

        Dim Sql As String = "SELECT NotaFiscal.NotaFiscal, NotaFiscal.Pedido, NotaFiscal.Cliente, Clientes.Nome, NotaFiscal.DataEmissao, NotaFiscal.TotalNota, NotaFiscal.Situaçao FROM Clientes INNER JOIN NotaFiscal ON Clientes.Codigo = NotaFiscal.Cliente WHERE (((" & Campo & ")= " & Vlr & ")) Order by NotaFiscal.DataEmissao DESC"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        Try

            DR = CMD.ExecuteReader
            Dim Zebrar As Boolean = False
            While DR.Read
                If Not IsDBNull(DR.Item("NotaFiscal")) Then
                    Dim AA As String = Format(DR.Item("Cliente"), "00000") & "-" & DR.Item("Nome")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("NotaFiscal") & "")
                    It.SubItems.Add(DR.Item("Pedido") & "")
                    It.SubItems.Add(DR.Item("DataEmissao") & "")
                    It.SubItems.Add(FormatNumber(Nz(DR.Item("TotalNota"), 3), 2))
                    It.SubItems.Add(DR.Item("Situaçao") & "")

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

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Exit Sub
        End Try

    End Sub

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        Me.NotaFiscal.Clear()
        Me.Cliente.Clear()
        Me.ClienteDesc.Clear()
        Me.MyLista.Items.Clear()
        Me.NotaFiscal.Focus()
    End Sub

    Private Sub btAchaPorNf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAchaPorNf.Click
        If Me.NotaFiscal.Text = "" Then
            Exit Sub
        End If
        LocalizaDados("NotaFiscal", Me.NotaFiscal.Text)
    End Sub

    Private Sub btAchaPorCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAchaPorCliente.Click
        If Me.Cliente.Text = "" Then
            Exit Sub
        End If
        LocalizaDados("Cliente", Me.Cliente.Text)
    End Sub

    Private Sub Cliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cliente.KeyDown

        If e.KeyCode = Keys.F5 Then
            My.Forms.ClientesProcura.ShowDialog()
        End If
    End Sub

    Private Sub NFAchar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CNN.Open()
    End Sub

    Private Sub Cliente_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cliente.Validated
        If Me.Cliente.Text = "" Then
            Exit Sub
        End If

        Dim Sql As String = "SELECT Clientes.*, Clientes.Empresa FROM Clientes WHERE (((Clientes.Codigo)=" & Me.Cliente.Text & ") AND ((Clientes.Empresa)=" & CodEmpresa & "));"
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.ClienteDesc.Text = DR.Item("Nome") & ""
        End If

        DR.Close()
    End Sub



    Private Sub cmdMostrarTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMostrarTodos.Click
        Me.MyLista.Items.Clear()

        Dim Sql As String = "SELECT NotaFiscal.NotaFiscal, NotaFiscal.Pedido, NotaFiscal.Cliente, Clientes.Nome, NotaFiscal.DataEmissao, NotaFiscal.TotalNota, NotaFiscal.Situaçao FROM Clientes INNER JOIN NotaFiscal ON Clientes.Codigo = NotaFiscal.Cliente Order by NotaFiscal.DataEmissao DESC"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        Try

            DR = CMD.ExecuteReader
            Dim Zebrar As Boolean = False
            While DR.Read
                If Not IsDBNull(DR.Item("NotaFiscal")) Then
                    Dim AA As String = Format(DR.Item("Cliente"), "00000") & "-" & DR.Item("Nome")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("NotaFiscal") & "")
                    It.SubItems.Add(DR.Item("Pedido") & "")
                    It.SubItems.Add(DR.Item("DataEmissao") & "")
                    It.SubItems.Add(FormatNumber(Nz(DR.Item("TotalNota"), 3), 2))
                    It.SubItems.Add(DR.Item("Situaçao") & "")

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

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub NotaFiscal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotaFiscal.TextChanged

    End Sub

    Private Sub NotaFiscal_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles NotaFiscal.Validating
        If Me.NotaFiscal.Text = "" Then
            Exit Sub
        End If
        LocalizaDados("NotaFiscal", Me.NotaFiscal.Text)
    End Sub
End Class