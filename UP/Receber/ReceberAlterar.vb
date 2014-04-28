Imports System.Data.OleDb
Public Class ReceberAlterar

    Dim AtivarCp As Control
    Public Property CampoAtivar() As Control
        Get
            Return AtivarCp
        End Get
        Set(ByVal Value As Control)
            AtivarCp = Value
        End Set
    End Property

    Dim DS As New DataSet()

    Dim Ação As New TrfGerais()


    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub


    Public Sub AchaRegistro(ByVal Id As String)

        CarregaComboBox()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        Cnn.Open()

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT Receber.* FROM Receber LEFT JOIN Clientes ON Receber.CodCliente = Clientes.Codigo WHERE Receber.ID = " & Id
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            DR.Read()

            Me.CodCliente.Text = DR.Item("CodCliente")
            Me.Cliente.Text = DR.Item("Cliente")
            Me.Id.Text = DR.Item("Id")
            Me.Pedido.Text = DR.Item("PedidoProdutos") & ""
            Me.Documento.Text = DR.Item("Documento") & ""
            Me.DataDocumento.Text = DR.Item("DataDocumento")
            Me.Vencimento.Text = DR.Item("Vencimento")
            Me.ValorDocumento.Text = FormatCurrency(NzZero(DR.Item("ValorDocumento")), 2)
            Me.LocalPgto.Text = UCase(DR.Item("LocalPgto") & "")
            Me.Baixado.Checked = DR.Item("Baixado")
            Me.NotaFiscal.Text = DR.Item("NotaFiscal") & ""
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()

    End Sub


    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click

        If Me.Baixado.Checked = True Then
            MsgBox("O documento já foi baixado, escolha outro", 64, "Validação de Dados")
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Transacao As OleDbTransaction = CNN.BeginTransaction()

        Dim CmdBaixa As OleDbCommand = CNN.CreateCommand

        CmdBaixa.Transaction = Transacao

        Try

            CmdBaixa.CommandText = "Update Receber set Documento = @3, DataDocumento = @4, Vencimento = @5,  ValorDocumento = @6, LocalPgto = @7 Where Id = " & Me.Id.Text

            CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Documento.Text, 1)))
            CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.DataDocumento.Text, 1)))
            CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Vencimento.Text, 1)))
            CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.ValorDocumento.Text, 1)))
            CmdBaixa.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.LocalPgto.Text, 1)))
         
            CmdBaixa.ExecuteNonQuery()

            Transacao.Commit()

            MsgBox("Documento alterado com sucesso.", 64, "Validação de Dados")
            GerarLog(Me.Text, AçãoTP.Editou, Me.Id.Text)
            CNN.Close()

            Me.Close()
            Me.Dispose()

        Catch ex As Exception
            Transacao.Rollback()
            MsgBox(ex.Message, 64, "Validação de Dados")
            CNN.Close()
        End Try

    End Sub

    Private Sub CarregaComboBox()

        Dim Cnn As OleDb.OleDbConnection = New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "Select * From LocalPagamento Where Empresa = " & CodEmpresa
        Dim daLocalPgto As OleDb.OleDbDataAdapter

        daLocalPgto = New OleDb.OleDbDataAdapter(Sql, Cnn)
        daLocalPgto.Fill(DS, "LocalPgto")

        Me.LocalPgto.DataSource = DS.Tables("LocalPgto")
        Me.LocalPgto.ValueMember = "LocalPgto"
        Me.LocalPgto.DisplayMember = "LocalPgto"
        Cnn.Close()

    End Sub

    Private Sub ReceberAlterar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtivarCp.Enabled = True
    End Sub
End Class