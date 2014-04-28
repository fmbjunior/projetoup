Public Class OSChequePreLancar

    Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2


    Dim Vendedor As Integer = 0
    Dim MediaDesconto As Double = 0
    Dim PercentComissao As Double = 0

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click

        If Me.MyLista.Items.Count = 0 Then
            CNN.Close()
            Me.Close()
            Me.Dispose()
        End If


        If CDbl(NzZero(Me.VlrLançar.Text)) <> CDbl(NzZero(Me.VlrLançado.Text)) Then
            MsgBox("O valor lançado esta diferente do valor a lançar. Verifique.", 64, "Validação de Dados")
            Exit Sub
        End If
        CNN.Close()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub OSChequePreLancar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CNN.Open()
        If My.Forms.PedidoOS.Visible Then
            If My.Forms.PedidoVendaConfirmarOS.Visible = True Then
                Me.Ped.Text = My.Forms.PedidoOS.PedidoSequencia.Text
                Me.VlrLançar.Text = FormatCurrency(CDbl(My.Forms.PedidoVendaConfirmarOS.ValorOutros.Text), 2)
                Vendedor = My.Forms.PedidoOS.CódigoFuncionário.Text
                MediaDesconto = NzZero(My.Forms.PedidoOS.MediaDesconto.Text)
                PercentComissao = NzZero(My.Forms.PedidoVendaConfirmarOS.PercentComissao.Text)
            End If

        Else
            Me.Ped.Text = My.Forms.frmPedidoMP.NumeroPedido.Text
            Me.VlrLançar.Text = FormatCurrency(CDbl(My.Forms.PedidoVendaConfirmarOS.ValorOutros.Text), 2)
            Vendedor = My.Forms.frmPedidoMP.CodigoVendedor.Text
            MediaDesconto = 0
            PercentComissao = 0
        End If
        CarregaCadBancos()
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        If My.Forms.PedidoVendaConfirmarOS.Visible = True Then SalvarPedido()
    End Sub
    Private Sub SalvarPedido()
        If Me.Cheque.Text = "" Then
            MsgBox("O Cheque não pode ser nulo.", 64, "Validação de Dados")
            Me.Cheque.Focus()
            Exit Sub
        ElseIf Me.CC.Text = "" Then
            MsgBox("A Conta Corrente não pode ser nula", 64, "Validação de Dados")
            Me.CC.Focus()
            Exit Sub
        ElseIf Me.BancoCheque.Text = "" Then
            MsgBox("O Banco do cheque não pode ser nulo", 64, "Validação de Dados")
            Me.BancoCheque.Focus()
            Exit Sub
        ElseIf Me.Titular.Text = "" Then
            MsgBox("O titular do cheque não pode ser nulo", 64, "Validação de Dados")
            Me.Titular.Focus()
            Exit Sub
        ElseIf Me.EntreguePor.Text = "" Then
            MsgBox("Por quem o cheque foi entregue não pode ser nulo", 64, "Validação de Dados")
            Me.EntreguePor.Focus()
            Exit Sub
        ElseIf Me.ValorCh.Text = "" Then
            MsgBox("O Valord do cheque não pode ser nulo", 64, "Validação de Dados")
            Me.ValorCh.Focus()
            Exit Sub
        ElseIf Me.Vencimento.Text = "" Then
            MsgBox("O Vencimento do cheque não pode ser nulo", 64, "Validação de Dados")
            Me.Vencimento.Focus()
            Exit Sub
        End If

        If My.Forms.PedidoOS.Visible Then
            If Operation = INS Then

                UltimoReg()
                Dim Sql As String = "INSERT INTO ArquivoCheque (Cheque, CC, BancoCheque, Titular, EntreguePor, ValorCh, Vencimento, Empresa, Pedido, Historico, Documento, Cliente, Vendedor, MediaDescontoPedido, PercentComissao, IdCodigo, CaixaCheque, DataLancamento, PedidoMP) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16,@17, @18, @19)"
                Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Cheque.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.CC.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.BancoCheque.SelectedValue, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Titular.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.EntreguePor.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.ValorCh.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Vencimento.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@8", CodEmpresa))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Ped.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@10", "CHEQUE-PRE"))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Documento.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(My.Forms.PedidoOS.CódigoCliente.Text, 3)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@13", NzZero(Vendedor)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@14", NzZero(MediaDesconto)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@15", NzZero(PercentComissao)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.IdCodigo.Text, 3)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@17", CaixaAtivo))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@18", CDate(DataDia)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@19", Nz(Me.Ped.Text, 1)))

                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                    GerarLog(Me.Text, AçãoTP.Adicionou, Me.Cheque.Text)
                    EncheLista()
                    NovoReg()
                Catch ex As Exception
                    MsgBox(ex.Message, 64, "Validação de Dados")
                End Try

            ElseIf Operation = UPD Then

                Dim Sql As String = "Update ArquivoCheque set Cheque = @1, CC = @2, BancoCheque = @3, Titular = @4, EntreguePor = @5, ValorCh = @6, Vencimento = @7, Empresa = @8, Pedido = @9, Historico = @10, Documento = @11, Cliente = @12, Vendedor = @13, MediaDescontoPedido = @14, PercentComissao = @15, IdCodigo = @16, CaixaCheque = @17, DataLancamento = @18 , PedidoMP=@19 Where Cheque = '" & Me.Cheque.Text & "' and CC = '" & Me.CC.Text & "'"
                Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Cheque.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.CC.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.BancoCheque.SelectedValue, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Titular.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.EntreguePor.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.ValorCh.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Vencimento.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@8", CodEmpresa))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Ped.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@10", "CHEQUE-PRE"))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Documento.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(My.Forms.PedidoOS.CódigoCliente.Text, 3)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@13", NzZero(Vendedor)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@14", NzZero(MediaDesconto)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@15", NzZero(PercentComissao)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.IdCodigo.Text, 3)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@17", CaixaAtivo))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@18", CDate(DataDia)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@19", Nz(Me.Ped.Text, 1)))

                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                    GerarLog(Me.Text, AçãoTP.Editou, Me.Cheque.Text)
                    EncheLista()
                    NovoReg()
                Catch x As Exception
                    MsgBox(x.Message)
                    Exit Sub
                End Try
            End If

        Else 'desvia para usar pedido materia prima

            If Operation = INS Then

                UltimoReg()
                Dim Sql As String = "INSERT INTO ArquivoCheque (Cheque, CC, BancoCheque, Titular, EntreguePor, ValorCh, Vencimento, Empresa, Historico, Documento, Cliente, Vendedor, MediaDescontoPedido, PercentComissao, IdCodigo, CaixaCheque, DataLancamento, PedidoMP) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @10, @11, @12, @13, @14, @15, @16,@17, @18, @19)"
                Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Cheque.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.CC.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.BancoCheque.SelectedValue, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Titular.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.EntreguePor.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.ValorCh.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Vencimento.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@8", CodEmpresa))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@10", "CHEQUE-PRE"))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Documento.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(My.Forms.frmPedidoMP.CodigoCliente.Text, 3)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@13", NzZero(Vendedor)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@14", NzZero(MediaDesconto)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@15", NzZero(PercentComissao)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.IdCodigo.Text, 3)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@17", CaixaAtivo))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@18", CDate(DataDia)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@19", Nz(Me.Ped.Text, 1)))


                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                    GerarLog(Me.Text, AçãoTP.Adicionou, Me.Cheque.Text)
                    EncheLista()
                    NovoReg()
                Catch ex As Exception
                    MsgBox(ex.Message, 64, "Validação de Dados")
                End Try

            ElseIf Operation = UPD Then

                Dim Sql As String = "Update ArquivoCheque set Cheque = @1, CC = @2, BancoCheque = @3, Titular = @4, EntreguePor = @5, ValorCh = @6, Vencimento = @7, Empresa = @8, Historico = @10, Documento = @11, Cliente = @12, Vendedor = @13, MediaDescontoPedido = @14, PercentComissao = @15, IdCodigo = @16, CaixaCheque = @17, DataLancamento = @18, PedidoMP=@19 Where Cheque = '" & Me.Cheque.Text & "' and CC = '" & Me.CC.Text & "'"
                Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Cheque.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.CC.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.BancoCheque.SelectedValue, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Titular.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.EntreguePor.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.ValorCh.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Vencimento.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@8", CodEmpresa))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@10", "CHEQUE-PRE"))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Documento.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(My.Forms.frmPedidoMP.CodigoCliente.Text, 3)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@13", NzZero(Vendedor)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@14", NzZero(MediaDesconto)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@15", NzZero(PercentComissao)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.IdCodigo.Text, 3)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@17", CaixaAtivo))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@18", CDate(DataDia)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@19", Nz(Me.Ped.Text, 1)))

                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                    GerarLog(Me.Text, AçãoTP.Editou, Me.Cheque.Text)
                    EncheLista()
                    NovoReg()
                Catch x As Exception
                    MsgBox(x.Message)
                    Exit Sub
                End Try
            End If

        End If


    End Sub


    Public Sub UltimoReg()
        'Inserir ultimo registro
        Dim Sql As String = "Select max(IdCodigo) from ArquivoCheque"

        Dim Cmd As New OleDb.OleDbCommand(Sql, CNN)
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer

        Try
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    Ult = NzZero(DataReader.Item(0))
                End If
            End While
            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Exit Sub
            End If
        End Try

        Me.IdCodigo.Text = Ult + 1

    End Sub

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        NovoReg()
    End Sub

    Private Sub NovoReg()
        Me.Cheque.Clear()
        Me.CC.Clear()
        Me.BancoCheque.SelectedValue = 0
        Me.Titular.Clear()
        Me.EntreguePor.Clear()
        Me.ValorCh.Clear()
        Me.Vencimento.Clear()

        Ação.Desbloquear_Controle(Me, True)
        Operation = INS
        Me.Cheque.Focus()
    End Sub

    Public Sub EncheLista()

        MyLista.Items.Clear()

        Dim Sql As String = String.Empty

        If My.Forms.PedidoOS.Visible Then
            Sql = "SELECT * FROM ArquivoCheque WHERE Pedido = " & Me.Ped.Text
        Else
            Sql = "SELECT * FROM ArquivoCheque WHERE PedidoMP = " & Me.Ped.Text
        End If

        Dim Cmd As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        Try

            DR = Cmd.ExecuteReader

            Dim Zebrar As Boolean = False
            Dim TotalLista As Double = 0
            While DR.Read
                If Not IsDBNull(DR.Item("Cheque")) Then
                    Dim AA As String = DR.Item("Cheque")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("CC") & "")
                    It.SubItems.Add(DR.Item("Vencimento") & "")
                    It.SubItems.Add(FormatNumber(Nz(DR.Item("ValorCh"), 3), 3))
                    It.SubItems.Add(DR.Item("BancoCheque") & "")

                    MyLista.Items.AddRange(New ListViewItem() {It})

                    If Zebrar = True Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.MediumOrchid
                        Zebrar = True
                    End If

                    TotalLista += CDbl(DR.Item("ValorCh"))
                End If
            End While

            Me.VlrLançado.Text = FormatCurrency(TotalLista, 3)
            DR.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Exit Sub
        End Try

    End Sub


    Private Sub ValorCh_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorCh.Validated
        If Me.ValorCh.Text = "" Then Me.ValorCh.Text = 0
        Me.ValorCh.Text = FormatCurrency(Me.ValorCh.Text, 3)
    End Sub

    Private Sub AdicionarNovoItemNaListaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarNovoItemNaListaToolStripMenuItem.Click
        btNovo_Click(sender, e)
    End Sub

    Private Sub RecalculaValoresDaListaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecalculaValoresDaListaToolStripMenuItem.Click
        EncheLista()
        MsgBox("Lista atualizada e recalculada com sucesso", 64, "Validação de Dados")
    End Sub

    Private Sub EditaItenDaListaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditaItenDaListaToolStripMenuItem.Click
        Dim I As Integer = 0
        Dim ChequeSelect As String = ""
        Dim CCSelect As String = ""

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then ChequeSelect = (MyLista.Items(I).Text.Substring(0))
            If MyLista.Items(I).Selected = True Then CCSelect = (MyLista.Items(I).SubItems(1).Text.Substring(0))
        Next

        If ChequeSelect = "" Then
            MsgBox("O usuário deve selecionar na lista um cheque para poder editar.", 64, "Validação de Dados")
            Exit Sub
        End If

        If CCSelect = "" Then
            MsgBox("O usuário deve selecionar na lista um cheque para poder editar.", 64, "Validação de Dados")
            Exit Sub
        End If

        Dim Sql As String = "Select * from ArquivoCheque where Cheque = '" & ChequeSelect & "' and CC = '" & CCSelect & "'"
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.Cheque.Text = DR.Item("Cheque") & ""
            Me.CC.Text = DR.Item("CC") & ""
            Me.BancoCheque.SelectedValue = Me.BancoCheque.FindStringExact(DR.Item("BancoCheque") & "")
            Me.Titular.Text = DR.Item("Titular") & ""
            Me.EntreguePor.Text = DR.Item("EntreguePor") & ""
            Me.ValorCh.Text = DR.Item("ValorCh") & ""
            Me.Vencimento.Text = DR.Item("Vencimento") & ""
            Me.IdCodigo.Text = DR.Item("IdCodigo") & ""
            Operation = UPD
            Me.Cheque.Focus()
        End If
        DR.Close()
    End Sub

    Private Sub ExcluirItemDaListaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirItemDaListaToolStripMenuItem.Click
        Dim I As Integer = 0
        Dim ChequeSelect As String = ""
        Dim CCSelect As String = ""

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then ChequeSelect = (MyLista.Items(I).Text.Substring(0))
            If MyLista.Items(I).Selected = True Then CCSelect = (MyLista.Items(I).SubItems(1).Text.Substring(0))
        Next

        Dim Sql As String = "Delete * from ArquivoCheque where Cheque = '" & ChequeSelect & "' and CC = '" & CCSelect & "'"
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)

        Try
            CMD.ExecuteNonQuery()
            MsgBox("Registro excluido com sucesso", 64, "Validação de Dados")
            EncheLista()
            btNovo_Click(sender, e)

        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try
    End Sub


    Private Sub CarregaCadBancos()

        Dim Ds As New DataSet
        Dim Sql As String = String.Empty

        Sql = "SELECT * from CadBancos"
        Dim DACadBancos As New OleDb.OleDbDataAdapter(Sql, CNN)
        DACadBancos.Fill(Ds, "CadBancos")

        Me.BancoCheque.DataSource = Ds.Tables("CadBancos")
        Me.BancoCheque.DisplayMember = "NomeBanco"
        Me.BancoCheque.ValueMember = "NomeBanco"
        Me.BancoCheque.SelectedValue = 0

    End Sub

 

    Private Sub Vencimento_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Vencimento.Validated
        If Me.Vencimento.Text = "" Then Exit Sub
        If Me.Vencimento.Text <= DataDia Then
            MsgBox("Data do vencimento não pode ser menor ou igual a data do Sistema", 48, "Atenção")
            Me.Vencimento.Clear()
            Me.Vencimento.Focus()
            Exit Sub
        End If
    End Sub

 
End Class