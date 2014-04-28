Public Class PagarEditar

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2


    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        'Area destinada para as validacoes
        If Me.Documento.Text = "" Then
            MsgBox("O Documento não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Documento.Focus()
            Exit Sub
        ElseIf Me.LabelNotaFiscal.Text = "" Then
            MsgBox("A  Nº da Nota Fiscal não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.LabelNotaFiscal.Focus()
            Exit Sub
        ElseIf Me.CodFornecedor.Text = "" Then
            MsgBox("O Código do Fornecedor não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.CodFornecedor.Focus()
            Exit Sub
        ElseIf Me.Fornecedor.Text = "" Then
            MsgBox("O nome do Fornecedor não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.CodFornecedor.Focus()
            Exit Sub
        ElseIf Me.DataDocumento.Text = "" Then
            MsgBox("A data do documento não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.DataDocumento.Focus()
            Exit Sub
        ElseIf Me.Vencimento.Text = "" Then
            MsgBox("A data de Vencimento não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Vencimento.Focus()
            Exit Sub
        ElseIf Me.ValorDocumento.Text = "" Then
            MsgBox("O Valor do Documento não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.ValorDocumento.Focus()
            Exit Sub
        ElseIf Me.LocalPgto.Text = "" Then
            MsgBox("O local de pagamento do documento não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.LocalPgto.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = UPD Then
            CNN.Open()

            Dim Sql As String = "Update Pagar set Documento = @2, NotaFiscal = @3, CodFornecedor = @4, Fornecedor = @5, DataDocumento = @6, Vencimento = @7, ValorDocumento = @8, LocalPgto = @9, Empresa = @10 Where Id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Documento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.NotaFiscal.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.CodFornecedor.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Fornecedor.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.DataDocumento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Vencimento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.ValorDocumento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.LocalPgto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Editou, Me.Documento.Text)
                Operation = UPD
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, False)
            Me.LocalPgto.Enabled = False
            CNN.Close()
        End If
    End Sub


    Public Sub EditaContaPagar()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        Cnn.Open()

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM Pagar WHERE Id = " & My.Forms.Pagar.IdSelecionado.Text
            .CommandType = CommandType.Text
        End With

        Try
            DR = Cmd.ExecuteReader
            DR.Read()

            If DR.HasRows Then
                Me.Id.Text = DR.Item("Id")
                Me.Documento.Text = DR.Item("Documento") & ""
                Me.NotaFiscal.Text = DR.Item("NotaFiscal") & ""
                Me.CodFornecedor.Text = DR.Item("CodFornecedor")
                Me.Fornecedor.Text = DR.Item("Fornecedor")
                Me.DataDocumento.Text = DR.Item("DataDocumento")
                Me.Vencimento.Text = DR.Item("Vencimento")
                Me.ValorDocumento.Text = FormatCurrency(DR.Item("ValorDocumento"), 2)
                Me.LocalPgto.Text = DR.Item("LocalPgto") & ""

                Me.Id.Enabled = False
                Me.NotaFiscal.Enabled = False
                Me.CodFornecedor.Enabled = False
                Me.Fornecedor.Enabled = False
                Operation = UPD
            End If

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()

    End Sub

    Private Sub PagarEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EditaContaPagar()
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class