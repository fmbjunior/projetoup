Public Class NfiscalEditaItens

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        If Me.Produto.Text = "" Then
            MsgBox("O usuário deve informar o Produto, verifique.", 64, "Validação de Dados")
            Me.Produto.Focus()
            Exit Sub
        ElseIf Me.Qtd.Text = "" Then
            MsgBox("O usuário deve informar a quantidade do Produto, verifique.", 64, "Validação de Dados")
            Me.Qtd.Focus()
            Exit Sub
        ElseIf Me.Unitario.Text = "" Then
            MsgBox("O usuário deve informar o valor unitário Produto, verifique.", 64, "Validação de Dados")
            Me.Produto.Focus()
            Exit Sub
        ElseIf Me.ValorDesconto.Text = "" Then
            Me.ValorDesconto.Text = FormatNumber(0, 2)
        ElseIf Me.Ipi.Text = "" Then
            Me.Ipi.Text = 0
        ElseIf Me.ValorIpi.Text = "" Then
            Me.ValorIpi.Text = FormatNumber(0, 2)
        ElseIf Me.Icms.Text = "" Then
            Me.Icms.Text = 0
        ElseIf Me.CF.Text = "" Then
            MsgBox("O usuário deve informar a Classificação Fiscal Produto, verifique o cadastro do Produto.", 64, "Validação de Dados")
            Me.Produto.Focus()
            Exit Sub
        ElseIf Me.CST.Text = "" Then
            MsgBox("O usuário deve informar o Código da Situação Tributaria do Produto, verifique o cadastro do Produto.", 64, "Validação de Dados")
            Me.Produto.Focus()
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = UPD Then

            CNN.Open()

            Dim Sql As String = "Update NotaFiscalItens set NotaFiscal = @1 , Produto = @2, Descricao = @3, Qtd = @4, Unitario = @5, ValorDesconto = @6, ValorTotal = @7, Icms = @8, ValorIcms = @9, Ipi = @10, ValorIpi = @11, Cst = @12, Cf = @13, SeqNf = @14 Where Id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            Dim VlrIcms As Double = (CDbl(Me.ValorTotal.Text) * CDbl(Me.Icms.Text)) / 100
            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(My.Forms.NFiscal.NotaFiscal.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Produto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.ProdutoDesc.Text, 2)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Qtd.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Unitario.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.ValorDesconto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.ValorTotal.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Icms.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", VlrIcms))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.Ipi.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.ValorIpi.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.CST.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.CF.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.SeqNf.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                Operation = UPD
                CNN.Close()
                Me.Close()
                Me.Dispose()
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, False)
            CNN.Close()
        End If

    End Sub

    Private Sub NfiscalEditaItens_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Operation = UPD


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from NotaFiscalItens where Id = " & My.Forms.NFiscal.IdProduto.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows = True Then
            Me.Produto.Text = DR.Item("Produto")
            Me.ProdutoDesc.Text = DR.Item("Descricao") & ""
            Me.Qtd.Text = FormatNumber(Nz(DR.Item("Qtd"), 3), 4)
            Me.Unitario.Text = FormatNumber(Nz(DR.Item("Unitario"), 3), 2)
            Me.ValorDesconto.Text = FormatNumber(Nz(DR.Item("ValorDesconto"), 3), 2)
            Me.ValorTotal.Text = FormatNumber(Nz(DR.Item("ValorTotal"), 3), 2)
            Me.Ipi.Text = DR.Item("Ipi") & ""
            Me.ValorIpi.Text = FormatNumber(Nz(DR.Item("ValorIpi"), 3), 2)
            Me.Icms.Text = DR.Item("Icms") & ""
            Me.CST.Text = DR.Item("Cst") & ""
            Me.CF.Text = DR.Item("CF") & ""
            Me.SeqNf.Text = DR.Item("SeqNf") & ""
            Me.Id.Text = DR.Item("Id") & ""
        Else
            MsgBox("Item não encontrado, verifique....", 64, "Validação de Dados")
            Ação.Desbloquear_Controle(Me, False)
            Me.btSalvar.Enabled = False
            Exit Sub
        End If
        DR.Close()

    End Sub

    Private Sub Qtd_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Qtd.Leave
        If Me.Qtd.Text = "" Or Me.Qtd.Text = 0 Then Me.Produto.Focus()

        Me.Qtd.Text = FormatNumber(Me.Qtd.Text, 4)
    End Sub

    Private Sub ValorDesconto_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorDesconto.Enter
        If DescontoEmLinha = True Then
            Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
            If Me.ValorDesconto.Text = "" Then Me.ValorDesconto.Text = FormatNumber(0, 2)
        Else
            Me.ValorDesconto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
            If Me.ValorDesconto.Text = "" Then Me.ValorDesconto.Text = FormatNumber(0, 2)
        End If
    End Sub

    Private Sub ValorTotal_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorTotal.Enter
        If Me.Qtd.Text = "" Then
            Me.Produto.Focus()
            Exit Sub
        ElseIf Me.Unitario.Text = "" Then
            Me.Qtd.Focus()
            Exit Sub
        ElseIf Me.ValorDesconto.Text = "" Then
            Me.ValorDesconto.Focus()
            Exit Sub
        ElseIf Me.Qtd.Text = 0 Then
            MsgBox("A quantidade não pode ser valores zero ou nulos, verifique.", 64, "Validação de Dados")
            Me.Qtd.Focus()
            Exit Sub
        End If

        Me.ValorTotal.Text = FormatCurrency((CDbl(Me.Unitario.Text) * CDbl(Me.Qtd.Text)) - CDbl(Me.ValorDesconto.Text), 2)
    End Sub

    Private Sub Ipi_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Ipi.Enter
        If Me.Ipi.Text = "" Then Me.Ipi.Text = 0
    End Sub

    Private Sub ValorIpi_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorIpi.Enter
        If Me.Ipi.Text = "" Then Me.Ipi.Text = 0

        If Me.Ipi.Text > 0 Then
            Me.ValorIpi.Text = FormatCurrency((CDbl(Me.ValorTotal.Text) * CDbl(Me.Ipi.Text)) / 100, 2)
        Else
            Me.ValorIpi.Text = FormatNumber(0, 2)
        End If
    End Sub

    Private Sub btExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExcluir.Click

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        CNN.Open()

        Dim Sql As String = "Delete * from NotaFiscalItens Where Id = " & Me.Id.Text
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("O Registro selecionado foi excluido.", 64, "Validação de Dados")
            CNN.Close()
            Me.Close()
            Me.Dispose()
        Catch x As Exception
            MsgBox(x.Message)
            Exit Sub
        End Try

    End Sub

    
    Private Sub Unitario_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Unitario.Leave
        Me.Unitario.Text = FormatCurrency(Me.Unitario.Text, 2)
    End Sub

    Private Sub ValorDesconto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorDesconto.Leave
        Me.ValorDesconto.Text = FormatCurrency(Me.ValorDesconto.Text, 2)
    End Sub

    Private Sub ValorIpi_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorIpi.Leave
        Me.ValorIpi.Text = FormatCurrency(Me.ValorIpi.Text, 2)
    End Sub

    Private Sub ValorTotal_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorTotal.Leave
        Me.ValorTotal.Text = FormatCurrency(Me.ValorTotal.Text, 2)
    End Sub
End Class