Public Class SellShoesDescontoGerencia

    Dim Var_Individual As Boolean = True
    Public Property Individual As Boolean 'Propriedade para definir se o desconto é indiviual ou para todos
        Get
            Return Var_Individual
        End Get
        Set(ByVal Value As Boolean)
            Var_Individual = Value
        End Set
    End Property

    Dim Var_ID As Integer = 0
    Public Property idITEM As Integer 'Propriedade para definir o item a ser descontado
        Get
            Return Var_ID
        End Get
        Set(ByVal Value As Integer)
            Var_ID = Value
        End Set
    End Property





    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConfirmar.Click

        If NzZero(Me.DescontoValor.Text) < 0 Then
            MessageBox.Show("O Valor de Desconto não pode ser negativo.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DescontoValor.Clear()
            Me.DescontoEspecial.Clear()
            Me.DescontoEspecial.Focus()
            Exit Sub
        End If

        If Individual = True Then
            DescontoIndividual(idITEM)
        Else
            DescontoTodos()
        End If

        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub DescontoIndividual(ByVal ITEM As Integer)

        Dim DescG As Double = NzZero(Me.DescontoEspecial.Text)
        If CDbl(DescG) > CDbl(DescontoGerencia) Then

            Dim Crpt As New ClCrypto

            Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            Cnn.Open()

            Dim Sql As String = "SELECT FuncionarioCartao.*, Funcionários.Nome FROM Funcionários INNER JOIN FuncionarioCartao ON Funcionários.CódigoFuncionário = FuncionarioCartao.Funcionario WHERE (((Funcionários.Inativo)=False) AND ((FuncionarioCartao.Inativo)=False) AND ((FuncionarioCartao.idCartao)='" & DeCriptografa(Me.Senha.Text) & "'));"

            Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
            Dim DR As OleDb.OleDbDataReader

            DR = CMD.ExecuteReader
            DR.Read()

            If DR.HasRows Then
                Dim DTExpirar As Date = CDate(DR.Item("DataExpiracao"))
                If CDate(DataDia) > CDate(DTExpirar) Then
                    MessageBox.Show("Este cartão esta com a data expirada, verifique com o Administrador.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If DR.Item("PermissaoMaster") = False Then
                    MessageBox.Show("Este cartão não tem permissão para a operação, verifique com o Administrador.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                Dim Ccompra As Double = NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Rows(ITEM)("CustoMercadoriaVendida")) * NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Rows(ITEM)("Qtd"))
                Dim ValorItem As Double = NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Rows(ITEM)("ValorUnitario")) * NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Rows(ITEM)("Qtd"))
                Dim ValorAcre As Double = NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Rows(ITEM)("vAcrecimoVenda"))
                Dim ValorDesc As Double = NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Rows(ITEM)("ValorDesconto"))
                Dim DescE As Double = FormatNumber(NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Rows(idITEM)("vDescontoEspecial")), 2)

                ValorItem += ValorAcre
                ValorItem -= ValorDesc
                Dim VDescEspecial As Double = NzZero(Me.DescontoValor.Text) + DescE

                If CDbl(Ccompra) > CDbl(ValorItem - NzZero(VDescEspecial)) Then
                    MessageBox.Show("O valor de Desconto ultrapassa o valor de compra, verifique...", "Validação de Dados", MessageBoxButtons.OK)
                    Exit Sub
                End If


                My.Forms.SellShoes.DsItens.Tables("Itens").Rows(ITEM).BeginEdit()
                My.Forms.SellShoes.DsItens.Tables("Itens").Rows(ITEM)("pDescontoEspecial") = NzZero(Me.DescontoEspecial.Text)
                My.Forms.SellShoes.DsItens.Tables("Itens").Rows(ITEM)("vDescontoEspecial") = NzZero(VDescEspecial)
                My.Forms.SellShoes.DsItens.Tables("Itens").Rows(ITEM).EndEdit()

            Else
                MessageBox.Show("Senha informada é inválida.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

        Else
            Dim Ccompra As Double = NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Rows(ITEM)("CustoMercadoriaVendida")) * NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Rows(ITEM)("Qtd"))
            Dim ValorItem As Double = NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Rows(ITEM)("ValorUnitario")) * NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Rows(ITEM)("Qtd"))
            Dim ValorAcre As Double = NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Rows(ITEM)("vAcrecimoVenda"))
            Dim ValorDesc As Double = NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Rows(ITEM)("ValorDesconto"))
            Dim DescE As Double = FormatNumber(NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Rows(idITEM)("vDescontoEspecial")), 2)

            ValorItem += ValorAcre
            ValorItem -= ValorDesc
            Dim VDescEspecial As Double = NzZero(Me.DescontoValor.Text) + DescE

            If CDbl(Ccompra) > CDbl(ValorItem - NzZero(VDescEspecial)) Then
                MessageBox.Show("O valor de Desconto ultrapassa o valor de compra, verifique...", "Validação de Dados", MessageBoxButtons.OK)
                Exit Sub
            End If

            My.Forms.SellShoes.DsItens.Tables("Itens").Rows(ITEM).BeginEdit()
            My.Forms.SellShoes.DsItens.Tables("Itens").Rows(ITEM)("pDescontoEspecial") = NzZero(Me.DescontoEspecial.Text)
            My.Forms.SellShoes.DsItens.Tables("Itens").Rows(ITEM)("vDescontoEspecial") = NzZero(VDescEspecial)
            My.Forms.SellShoes.DsItens.Tables("Itens").Rows(ITEM).EndEdit()
        End If
    End Sub

    Private Sub DescontoTodos()

        Dim DescG As Double = Me.DescontoEspecial.Text
        If CDbl(DescG) > CDbl(DescontoGerencia) Then

            Dim Crpt As New ClCrypto

            Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            Cnn.Open()

            Dim Sql As String = "SELECT FuncionarioCartao.*, Funcionários.Nome FROM Funcionários INNER JOIN FuncionarioCartao ON Funcionários.CódigoFuncionário = FuncionarioCartao.Funcionario WHERE (((Funcionários.Inativo)=False) AND ((FuncionarioCartao.Inativo)=False) AND ((FuncionarioCartao.idCartao)='" & DeCriptografa(Me.Senha.Text) & "'));"

            Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
            Dim DR As OleDb.OleDbDataReader

            DR = CMD.ExecuteReader
            DR.Read()

            If DR.HasRows Then
                Dim DTExpirar As Date = CDate(DR.Item("DataExpiracao"))
                If CDate(DataDia) > CDate(DTExpirar) Then
                    MessageBox.Show("Este cartão esta com a data expirada, verifique com o Administrador.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If DR.Item("PermissaoMaster") = False Then
                    MessageBox.Show("Este cartão não tem permissão para a operação, verifique com o Administrador.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If


                If My.Forms.SellShoes.DsItens.Tables("Itens").Rows.Count > 0 Then
                    Dim drlinha As DataRow
                    For Each drlinha In My.Forms.SellShoes.DsItens.Tables("Itens").Rows

                        drlinha.BeginEdit()

                        Dim ValorItem As Double = FormatNumber(NzZero(drlinha("ValorUnitario")) * NzZero(drlinha("Qtd")), 2)
                        Dim ValorAcre As Double = FormatNumber(NzZero(drlinha("vAcrecimoVenda")), 2)
                        Dim ValorDesc As Double = FormatNumber(NzZero(drlinha("ValorDesconto")), 2)

                        ValorItem += ValorAcre
                        ValorItem -= ValorDesc
                        Dim VDescEspecial As Double = FormatNumber((CDbl(ValorItem) * CDbl(NzZero(Me.DescontoEspecial.Text))) / 100, 2)

                        drlinha("pDescontoEspecial") = NzZero(Me.DescontoEspecial.Text)
                        drlinha("vDescontoEspecial") = NzZero(VDescEspecial)

                        drlinha.EndEdit()

                    Next


                    My.Forms.SellShoes.ValorProduto.Text = FormatNumber(NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Compute("sum(TotalProduto)", "")), 2)
                    My.Forms.SellShoes.Acrecimo.Text = FormatNumber(NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Compute("sum(vAcrecimoVenda)", "")), 2)

                    Dim DescEspecial As Double = NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Compute("sum(vDescontoEspecial)", ""))
                    Dim DescNormal As Double = NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Compute("sum(ValorDesconto)", ""))
                    My.Forms.SellShoes.TotalDesconto.Text = FormatNumber(NzZero(DescNormal) + NzZero(DescEspecial), 2)

                    My.Forms.SellShoes.TotalPedido.Text = FormatNumber(CDbl(NzZero(My.Forms.SellShoes.ValorProduto.Text)) + CDbl(NzZero(My.Forms.SellShoes.Acrecimo.Text)) - CDbl(NzZero(My.Forms.SellShoes.TotalDesconto.Text)), 2)
                    My.Forms.SellShoes.Lista.Refresh()



                End If

            Else
                MessageBox.Show("Senha informada é inválida.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

        Else

            If My.Forms.SellShoes.DsItens.Tables("Itens").Rows.Count > 0 Then
                Dim drlinha As DataRow
                For Each drlinha In My.Forms.SellShoes.DsItens.Tables("Itens").Rows

                    drlinha.BeginEdit()

                    Dim ValorItem As Double = FormatNumber(NzZero(drlinha("ValorUnitario")) * NzZero(drlinha("Qtd")), 2)
                    Dim ValorAcre As Double = FormatNumber(NzZero(drlinha("vAcrecimoVenda")), 2)
                    Dim ValorDesc As Double = FormatNumber(NzZero(drlinha("ValorDesconto")), 2)

                    ValorItem += ValorAcre
                    ValorItem -= ValorDesc
                    Dim VDescEspecial As Double = FormatNumber((CDbl(ValorItem) * CDbl(NzZero(Me.DescontoEspecial.Text))) / 100, 2)


                    drlinha("pDescontoEspecial") = NzZero(Me.DescontoEspecial.Text)
                    drlinha("vDescontoEspecial") = NzZero(VDescEspecial)

                    drlinha.EndEdit()

                Next

                My.Forms.SellShoes.ValorProduto.Text = FormatNumber(NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Compute("sum(TotalProduto)", "")), 2)
                My.Forms.SellShoes.Acrecimo.Text = FormatNumber(NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Compute("sum(vAcrecimoVenda)", "")), 2)

                Dim DescEspecial As Double = NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Compute("sum(vDescontoEspecial)", ""))
                Dim DescNormal As Double = NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Compute("sum(ValorDesconto)", ""))
                My.Forms.SellShoes.TotalDesconto.Text = FormatNumber(NzZero(DescNormal) + NzZero(DescEspecial), 2)

                My.Forms.SellShoes.TotalPedido.Text = FormatNumber(CDbl(NzZero(My.Forms.SellShoes.ValorProduto.Text)) + CDbl(NzZero(My.Forms.SellShoes.Acrecimo.Text)) - CDbl(NzZero(My.Forms.SellShoes.TotalDesconto.Text)), 2)
                My.Forms.SellShoes.Lista.Refresh()

            End If

        End If

    End Sub

    Private Sub DescontoEspecial_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescontoEspecial.Validated

        If Individual = False Then
            Dim DescG As Double = NzZero(Me.DescontoEspecial.Text)
            If CDbl(DescG) < CDbl(DescontoGerencia) Then
                Me.Senha.Enabled = False
                Me.btConfirmar.Focus()
            Else
                Me.labelSenha.Visible = True
                Me.Senha.Visible = True
                Me.Senha.Enabled = True
                Me.Senha.Focus()
            End If
        Else
            Dim ValorItem As Double = NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Rows(idITEM)("ValorUnitario")) * NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Rows(idITEM)("Qtd"))
            Me.DescontoValor.Text = FormatNumber(NzZero(ValorItem) * NzZero(Me.DescontoEspecial.Text) / 100, 2)
        End If

    End Sub

    Private Sub SellShoesDescontoGerencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Individual = True Then
            Me.DescontoValor.Visible = True
        Else
            Me.DescontoValor.Visible = False
        End If
    End Sub

    Private Sub DescontoValor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DescontoValor.Leave

        If NzZero(Me.DescontoValor.Text) < 0 Then
            MessageBox.Show("O Valor de Desconto não pode ser negativo.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DescontoValor.Clear()
            Me.DescontoEspecial.Clear()
            Me.DescontoEspecial.Focus()
            Exit Sub
        End If

        Dim ValorItem As Double = NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Rows(idITEM)("ValorUnitario")) * NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Rows(idITEM)("Qtd"))
        Dim DescE As Double = FormatNumber(NzZero(My.Forms.SellShoes.DsItens.Tables("Itens").Rows(idITEM)("vDescontoEspecial")), 2)

        Dim Desc As Double = (CDbl(NzZero(Me.DescontoValor.Text) + DescE) / NzZero(ValorItem)) * 100
        Me.DescontoEspecial.Text = FormatNumber(NzZero(Desc), 2)

        Dim DescG As Double = NzZero(Me.DescontoEspecial.Text)
        If CDbl(DescG) < CDbl(DescontoGerencia) Then
            Me.Senha.Enabled = False
            Me.btConfirmar.Focus()
        Else
            Me.labelSenha.Visible = True
            Me.Senha.Visible = True
            Me.Senha.Enabled = True
            Me.Senha.Focus()
        End If

    End Sub

    Private Sub TimerTeclado_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTeclado.Tick
        Me.Senha.Clear()
        Me.TimerTeclado.Enabled = False
    End Sub

    Private Sub Senha_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Senha.KeyPress
        Me.TimerTeclado.Enabled = True
    End Sub

    Private Sub Senha_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Senha.KeyDown
        If e.KeyCode = Keys.Enter Then
            btConfirmar_Click(sender, e)
            e.Handled = False
        End If
    End Sub
End Class