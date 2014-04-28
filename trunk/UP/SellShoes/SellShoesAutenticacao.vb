Public Class SellShoesAutenticacao

    Public IdCliente As Integer = 0
    Public PedidoDevolucao As Integer = 0


    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btConfirmar.Click

        'Dim Crpt As New ClCrypto
        Dim SeCartao As String = ""

        If Leitor = True Then
            If Me.Autenticacao.Text = "" Then
                Exit Sub
            End If

            Try
                SeCartao = DeCriptografa(Me.Autenticacao.Text)
            Catch ex As Exception
                If Err.Number = 13 Then
                    MessageBox.Show("Senha não reconhecida na Criptografia.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Exit Sub
            End Try


            Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            Cnn.Open()

            Dim Sql As String = "SELECT FuncionarioCartao.*, Funcionários.Nome FROM Funcionários INNER JOIN FuncionarioCartao ON Funcionários.CódigoFuncionário = FuncionarioCartao.Funcionario WHERE (((Funcionários.Inativo)=False) AND ((FuncionarioCartao.Inativo)=False) AND ((FuncionarioCartao.idCartao)='" & SeCartao & "'));"

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

                If DR.Item("UsadoParaVenda") = False Then
                    MessageBox.Show("Este cartão não tem permissão para a operação, verifique com o Administrador.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If



                Dim Tp As String = String.Empty
                If Me.OpcVenda.Checked = True Then Tp = "VENDA"
                If Me.OpcDevoluçao.Checked = True Then Tp = "DEVOLUÇÃO"
                If Me.OpcOrcamento.Checked = True Then Tp = "ORÇAMENTO"
                If Me.OpcConsVenda.Checked = True Then Tp = "RESUMOVENDA"

                If Tp = "ORÇAMENTO" Then
                    Me.Visible = False
                    My.Forms.SellShoesOrcamento.PedidoTipo.Text = Tp
                    My.Forms.SellShoesOrcamento.Vendedor.Text = DR.Item("Funcionario") & "-" & DR.Item("Nome")
                    My.Forms.SellShoesOrcamento.lblOperador.Text = DR.Item("Funcionario").ToString()
                    My.Forms.SellShoesOrcamento.ShowDialog()
                    DR.Close()
                    Cnn.Close()
                    Me.Close()
                    Me.Dispose()
                    Exit Sub
                ElseIf Tp = "RESUMOVENDA" Then
                    My.Forms.SellShoesResumoVenda.lblVendedor.Text = DR.Item("Funcionario") & "-" & DR.Item("Nome")
                    My.Forms.SellShoesResumoVenda.vcodigo = DR.Item("Funcionario").ToString()
                    DR.Close()
                    Cnn.Close()
                    My.Forms.SellShoesResumoVenda.ShowDialog()

                    Me.Close()
                    Me.Dispose()

                    Exit Sub
                ElseIf Tp = "VENDA" Then
                    My.Forms.SellShoes.Vendedor.Text = DR.Item("Funcionario") & "-" & DR.Item("Nome")
                    My.Forms.SellShoes.PedidoTipo.Text = Tp
                    My.Forms.SellShoes.lblOperador.Text = DR.Item("Funcionario").ToString()
                End If


                Me.Visible = False

                If IdCliente > 0 Then
                    My.Forms.SellShoes.AcharVenda = False
                    My.Forms.SellShoes.LocalizaCliente(IdCliente)
                End If

                If Tp = "DEVOLUÇÃO" Then
                    If PedidoDevolucao = 0 Then
                        MessageBox.Show("Para fazer devolução é necessario ter a venda de Origem, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Close()
                        Me.Dispose()
                        Exit Sub
                    End If
                    My.Forms.SellShoes.DevNumero.Text = PedidoDevolucao
                    My.Forms.SellShoes.PedidoTipo.Text = Tp
                    My.Forms.SellShoes.lblOperador.Text = DR.Item("Funcionario").ToString()

                End If
                DR.Close()
                Cnn.Close()
                My.Forms.SellShoes.AcharVenda = False
                If My.Forms.SellShoes.Visible = False Then
                    My.Forms.SellShoes.ShowDialog()
                End If
                Me.Close()
                Me.Dispose()
            Else
                MessageBox.Show("Esta Autenticação não pertence a nenhum funcionário, a venda não pode ser iniciada.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
                DR.Close()
                Cnn.Close()
            End If
        Else
            'Sem autenticação

            Dim Tp As String = String.Empty
            If Me.OpcVenda.Checked = True Then Tp = "VENDA"
            If Me.OpcDevoluçao.Checked = True Then Tp = "DEVOLUÇÃO"
            If Me.OpcOrcamento.Checked = True Then Tp = "ORÇAMENTO"
            If Me.OpcConsVenda.Checked = True Then Tp = "RESUMOVENDA"

            If Tp = "ORÇAMENTO" Then
                Me.Visible = False
                My.Forms.SellShoesOrcamento.PedidoTipo.Text = Tp
                My.Forms.SellShoesOrcamento.Vendedor.Text = Me.Vendedor.SelectedValue & "-" & Me.Vendedor.Text
                My.Forms.SellShoesOrcamento.lblOperador.Text = Me.Vendedor.SelectedValue
                My.Forms.SellShoesOrcamento.ShowDialog()
                Me.Close()
                Me.Dispose()
                Exit Sub
            ElseIf Tp = "RESUMOVENDA" Then
                My.Forms.SellShoesResumoVenda.lblVendedor.Text = Me.Vendedor.SelectedValue & "-" & Me.Vendedor.Text
                My.Forms.SellShoesResumoVenda.vcodigo = Me.Vendedor.SelectedValue
                
                My.Forms.SellShoesResumoVenda.ShowDialog()

                Me.Close()
                Me.Dispose()

                Exit Sub
            ElseIf Tp = "VENDA" Then
                My.Forms.SellShoes.Vendedor.Text = Me.Vendedor.SelectedValue & "-" & Me.Vendedor.Text
                My.Forms.SellShoes.PedidoTipo.Text = Tp
                My.Forms.SellShoes.lblOperador.Text = Me.Vendedor.SelectedValue
            End If


            Me.Visible = False

            If IdCliente > 0 Then
                My.Forms.SellShoes.AcharVenda = False
                My.Forms.SellShoes.LocalizaCliente(IdCliente)
            End If

            If Tp = "DEVOLUÇÃO" Then
                If PedidoDevolucao = 0 Then
                    MessageBox.Show("Para fazer devolução é necessario ter a venda de Origem, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    Me.Dispose()
                    Exit Sub
                End If
                My.Forms.SellShoes.DevNumero.Text = PedidoDevolucao
                My.Forms.SellShoes.PedidoTipo.Text = Tp
                My.Forms.SellShoes.lblOperador.Text = Me.Vendedor.SelectedValue

            End If
           
            My.Forms.SellShoes.AcharVenda = False
            If My.Forms.SellShoes.Visible = False Then
                My.Forms.SellShoes.ShowDialog()
            End If
            Me.Close()
            Me.Dispose()
        End If


    End Sub

    Private Sub Autenticacao_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Autenticacao.KeyDown
        If e.KeyCode = Keys.Enter Then
            btConfirmar_Click(sender, e)
            e.Handled = False
        End If
    End Sub

    Private Sub OpcVenda_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpcVenda.CheckedChanged, OpcDevoluçao.CheckedChanged
        Me.Autenticacao.Focus()
    End Sub


    Private Sub TimerTeclado_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTeclado.Tick
        Me.Autenticacao.Clear()
        Me.TimerTeclado.Enabled = False
    End Sub

    Private Sub SellShoesAutenticacao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If UserAtivo <> "ADMIN" Then
            Me.Autenticacao.ShortcutsEnabled = False
        End If

        If Leitor = True Then
            Me.Vendedor.Visible = False
            Me.Autenticacao.Visible = True
            Me.LabelAutenticação.Text = "Favor Informar a Autenticação"
        Else
            Me.Vendedor.Visible = True
            Me.Autenticacao.Visible = False
            Me.LabelAutenticação.Text = "Favor Informar o Vendedor"
            EncheListaFuncionario()
        End If
    End Sub

    Private Sub EncheListaFuncionario()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "Select Funcionários.CódigoFuncionário, Funcionários.Nome From Funcionários  Where Funcionários.Empresa = " & CodEmpresa & " And Funcionários.inativo = False and AdicionarEmVendas = True Order by Funcionários.Nome"

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Vendedor.DataSource = ds.Tables("Table").DefaultView
        Me.Vendedor.DisplayMember = "Nome"
        Me.Vendedor.ValueMember = "CódigoFuncionário"
        Me.Vendedor.SelectedValue = -1

        da.Dispose()
        Cnn.Close()

    End Sub

End Class