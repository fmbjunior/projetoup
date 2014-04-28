Imports System.Data.OleDb
Public Class ClientesProcura


    Private Sub TxtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProcura.Leave
        If Me.TxtProcura.Text = "" Then
            Exit Sub
        End If

        If Me.A1.Checked = True Then BuscarCliente(1)
        If Me.A2.Checked = True Then BuscarCliente(2)
        If Me.A3.Checked = True Then BuscarCliente(3)
        If Me.A3a.Checked = True Then BuscarCliente(3)
        If Me.A5.Checked = True Then BuscarCliente(5)
        If Me.A9.Checked = True Then BuscarCliente(9)
        Me.Lista.Focus()

    End Sub


    Private Sub BuscarCliente(ByVal Opt As String)

        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Select Case Opt
            Case 1
                Sql = "Select Clientes.Codigo, Clientes.Nome, Clientes.NomeFantasia, Clientes.CpfCgc, Clientes.Cidade,Clientes.Endereço,Clientes.PessoaContato,Clientes.Celular,Clientes.Telefone,Clientes.MotivoBloqueado,Clientes.Bloqueado,Clientes.VendaCrediario,Clientes.VendaCheque,Clientes.VendaVista from Clientes  Where Clientes.Empresa = " & CodEmpresa & " And Codigo = " & Me.TxtProcura.Text & " and Clientes.Inativo = False Order by Clientes.Nome"
            Case 2
                Sql = "Select Clientes.Codigo, Clientes.Nome, Clientes.NomeFantasia, Clientes.CpfCgc, Clientes.Cidade,Clientes.Endereço,Clientes.PessoaContato,Clientes.Celular,Clientes.Telefone,Clientes.MotivoBloqueado,Clientes.Bloqueado,Clientes.VendaCrediario,Clientes.VendaCheque,Clientes.VendaVista from Clientes  Where Clientes.Empresa = " & CodEmpresa & " And Nome like '%" & Me.TxtProcura.Text & "%'  and Clientes.Inativo = False Order by Clientes.Nome"
            Case 3
                Sql = "Select Clientes.Codigo, Clientes.Nome, Clientes.NomeFantasia, Clientes.CpfCgc, Clientes.Cidade from Clientes  Where Clientes.Empresa = " & CodEmpresa & " And CpfCgc like '%" & Me.TxtProcura.Text & "%'  and Clientes.Inativo = False Order by Clientes.Nome"
            Case 4
                Sql = "Select Clientes.Codigo, Clientes.Nome, Clientes.NomeFantasia, Clientes.CpfCgc, Clientes.Cidade from Clientes  Where Clientes.Empresa = " & CodEmpresa & " And Inativo = False Order by Clientes.Nome"
            Case 5
                Sql = "Select Clientes.Codigo, Clientes.Nome, Clientes.NomeFantasia, Clientes.CpfCgc, Clientes.Cidade from Clientes  Where Clientes.Empresa = " & CodEmpresa & " And NomeFantasia like '%" & Me.TxtProcura.Text & "%'  and Clientes.Inativo = False Order by Clientes.NomeFantasia"
            Case 9
                Sql = "Select Clientes.Codigo, Clientes.Nome, Clientes.NomeFantasia, Clientes.CpfCgc, Clientes.Cidade from Clientes  Where Clientes.Empresa = " & CodEmpresa & " And NomeFantasia like '%" & Me.TxtProcura.Text & "%'  and Clientes.Inativo = true Order by Clientes.NomeFantasia"

        End Select

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Lista.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        cnn.Close()

    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub TelaProcura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TxtProcura.Focus()
        Me.A2.Checked = True
        If My.Forms.Clientes.Visible Then
            A9.Visible = True
        End If
    End Sub

    Private Sub CampoChave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles A1.Click, A2.Click, A3.Click
        Me.TxtProcura.Focus()
    End Sub

    Private Sub Lista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellDoubleClick
        Dim vID As Integer
        vID = CInt(Me.Lista.CurrentRow.Cells("cCodigo").Value)

        If My.Forms.Receber.Visible = True Then My.Forms.Receber.Cliente.Text = vID
        If My.Forms.ReceberRelat.Visible = True Then My.Forms.ReceberRelat.Cliente.Text = vID
        If My.Forms.Clientes.Visible = True Then My.Forms.Clientes.Codigo.Text = vID
        If My.Forms.CaixaLançamentos.Visible = True Then My.Forms.CaixaLançamentos.CliFor.Text = vID
        If My.Forms.ChequePreLancarAvulso.Visible = True Then My.Forms.ChequePreLancarAvulso.Cliente.Text = vID
        If My.Forms.PedidoVenda.Visible = True Then My.Forms.PedidoVenda.CódigoCliente.Text = vID
        If My.Forms.NFiscal.Visible = True Then My.Forms.NFiscal.Cliente.Text = vID
        If My.Forms.PedidoRelat.Visible = True Then My.Forms.PedidoRelat.Cliente.Text = vID
        If My.Forms.NFAchar.Visible = True Then My.Forms.NFAchar.Cliente.Text = vID
        If My.Forms.Orçamento.Visible = True Then My.Forms.Orçamento.CódigoCliente.Text = vID
        If My.Forms.ReceberAvulso.Visible = True Then My.Forms.ReceberAvulso.Cliente.Text = vID
        If My.Forms.SellShoes.Visible = True Then My.Forms.SellShoes.xCodCliente.Text = vID
        If My.Forms.PedidoOS.Visible = True Then My.Forms.PedidoOS.CódigoCliente.Text = vID
        If OSorçamento.Visible = True Then OSorçamento.CódigoCliente.Text = vID
        If ObjetosCad.Visible = True Then
            ObjetosCad.CódigoCliente.Text = vID
            ObjetosCad.NomeCliente.Text = Me.Lista.CurrentRow.Cells(1).Value
        End If

        If My.Forms.DuplicataAvulso.Visible = True Then My.Forms.DuplicataAvulso.txtCodigoCliente.Text = vID
        If My.Forms.Contrato.Visible = True Then My.Forms.Contrato.Cliente.Text = vID
        If My.Forms.SellShoesOrcamento.Visible = True Then My.Forms.SellShoesOrcamento.xCodCliente.Text = vID
        If My.Forms.SellShoesOrcamentoProcura.Visible = True Then My.Forms.SellShoesOrcamentoProcura.CodCli.Text = vID

        If My.Forms.LocacaoCilindro.Visible = True Then
            My.Forms.LocacaoCilindro.txtCodigoCliente.Text = vID
            My.Forms.LocacaoCilindro.txtRazaoSocial.Text = Me.Lista.CurrentRow.Cells("cNome").Value
        End If

        If My.Forms.CartaoCreditoMenu.Visible = True Then My.Forms.CartaoCreditoMenu.Cliente.Text = vID
        If My.Forms.HistoricoOsPedido.Visible = True Then My.Forms.HistoricoOsPedido.Cliente.Text = vID
        If My.Forms.AgendaServicoAdd.Visible = True Then My.Forms.AgendaServicoAdd.Cliente.Text = vID
        If My.Forms.AgendaRelat.Visible = True Then My.Forms.AgendaRelat.Cliente.Text = vID
        If My.Forms.OsRelat.Visible = True Then My.Forms.OsRelat.Cliente.Text = vID
        If My.Forms.ClientesCred.Visible = True Then My.Forms.ClientesCred.Cliente.Text = vID
        If My.Forms.ClientesCredBaixar.Visible = True Then My.Forms.ClientesCredBaixar.Cliente.Text = vID
        If My.Forms.frmPedidoMP.Visible Then My.Forms.frmPedidoMP.CodigoCliente.Text = vID


        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged, A3a.CheckedChanged, A5.CheckedChanged, A9.CheckedChanged
        'codigo alterado pelo beto 31-10-2012:0954
        If Me.A1.Checked Then
            Me.TxtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
            Me.TxtProcura.Clear()
            Me.TxtProcura.Focus()
        End If
        If Me.A3.Checked Then
            Me.TxtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Cpf
            Me.TxtProcura.Clear()
            Me.TxtProcura.Focus()
        End If
        If Me.A3a.Checked = True Then
            Me.TxtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Cnpj
            Me.TxtProcura.Clear()
            Me.TxtProcura.Focus()
        End If
        If Me.A5.Checked Or A2.Checked Or A9.Checked Then
            Me.TxtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
            Me.TxtProcura.Clear()
            Me.TxtProcura.Focus()
        End If
       
    End Sub

    Private Sub A4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A4.CheckedChanged
        BuscarCliente(4)
    End Sub


    Private Sub Lista_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Lista.KeyDown
        If e.KeyCode = Keys.Enter Then
            If (Lista.RowCount > 0) Then
                Dim vID As Integer
                vID = CInt(Me.Lista.CurrentRow.Cells("cCodigo").Value)
                Retorno = vID
                If My.Forms.Receber.Visible = True Then My.Forms.Receber.Cliente.Text = vID
                If My.Forms.ReceberRelat.Visible = True Then My.Forms.ReceberRelat.Cliente.Text = vID
                If My.Forms.Clientes.Visible = True Then My.Forms.Clientes.Codigo.Text = vID
                If My.Forms.CaixaLançamentos.Visible = True Then My.Forms.CaixaLançamentos.CliFor.Text = vID
                If My.Forms.ChequePreLancarAvulso.Visible = True Then My.Forms.ChequePreLancarAvulso.Cliente.Text = vID
                If My.Forms.PedidoVenda.Visible = True Then My.Forms.PedidoVenda.CódigoCliente.Text = vID
                If My.Forms.NFiscal.Visible = True Then My.Forms.NFiscal.Cliente.Text = vID
                If My.Forms.PedidoRelat.Visible = True Then My.Forms.PedidoRelat.Cliente.Text = vID
                If My.Forms.NFAchar.Visible = True Then My.Forms.NFAchar.Cliente.Text = vID
                If My.Forms.Orçamento.Visible = True Then My.Forms.Orçamento.CódigoCliente.Text = vID
                If My.Forms.ReceberAvulso.Visible = True Then My.Forms.ReceberAvulso.Cliente.Text = vID
                If My.Forms.SellShoes.Visible = True Then My.Forms.SellShoes.xCodCliente.Text = vID
                If My.Forms.PedidoOS.Visible = True Then My.Forms.PedidoOS.CódigoCliente.Text = vID
                If My.Forms.OsRelat.Visible = True Then OsRelat.Cliente.Text = vID
                If OSorçamento.Visible = True Then OSorçamento.CódigoCliente.Text = vID
                If ObjetosCad.Visible = True Then
                    ObjetosCad.CódigoCliente.Text = vID
                    ObjetosCad.NomeCliente.Text = Me.Lista.CurrentRow.Cells(1).Value
                End If

                If My.Forms.LocacaoCilindro.Visible = True Then
                    My.Forms.LocacaoCilindro.txtCodigoCliente.Text = vID
                    My.Forms.LocacaoCilindro.txtRazaoSocial.Text = Me.Lista.CurrentRow.Cells("cNome").Value
                End If

                If My.Forms.DuplicataAvulso.Visible = True Then My.Forms.DuplicataAvulso.txtCodigoCliente.Text = vID
                If My.Forms.SellShoesOrcamento.Visible = True Then My.Forms.SellShoesOrcamento.xCodCliente.Text = vID
                If My.Forms.Contrato.Visible = True Then My.Forms.Contrato.Cliente.Text = vID
                If My.Forms.CartaoCreditoMenu.Visible = True Then My.Forms.CartaoCreditoMenu.Cliente.Text = vID
                If My.Forms.HistoricoOsPedido.Visible = True Then My.Forms.HistoricoOsPedido.Cliente.Text = vID
                If My.Forms.AgendaServicoAdd.Visible = True Then My.Forms.AgendaServicoAdd.Cliente.Text = vID
                If My.Forms.AgendaRelat.Visible = True Then My.Forms.AgendaRelat.Cliente.Text = vID
                If My.Forms.OsRelat.Visible = True Then My.Forms.OsRelat.Cliente.Text = vID
                If My.Forms.ClientesCred.Visible = True Then My.Forms.ClientesCred.Cliente.Text = vID
                If My.Forms.ClientesCredBaixar.Visible = True Then My.Forms.ClientesCredBaixar.Cliente.Text = vID
                If My.Forms.frmPedidoMP.Visible Then My.Forms.frmPedidoMP.CodigoCliente.Text = Retorno
                Me.Close()
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub Lista_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lista.SelectionChanged
        Try
            Dim vID As Integer
            vID = CInt(NzZero(Me.Lista.CurrentRow.Cells(0).Value))
            'Todas a vez que for retornar um valor da celula no datagriview deverá ser feita a devida conversão.
            Me.xCliente.Text = Me.Lista.CurrentRow.Cells("cCodigo").Value & "-" & Me.Lista.CurrentRow.Cells("cNome").Value
            Me.xEndereço.Text = Me.Lista.CurrentRow.Cells("cEndereco").Value
            Me.xCpfCnpj.Text = Me.Lista.CurrentRow.Cells("cCpfCnpj").Value
            Me.xCidade.Text = Me.Lista.CurrentRow.Cells("cCidade").Value
            Me.xVendaVista.Checked = Me.Lista.CurrentRow.Cells("cAVista").Value
            Me.xVendaCheque.Checked = Me.Lista.CurrentRow.Cells("cCheque").Value
            Me.xVendaCrediario.Checked = Me.Lista.CurrentRow.Cells("cCrediario").Value
            Me.xTelefone.Text = Convert.ToString(Me.Lista.CurrentRow.Cells("cTelefone").Value)
            Me.xCelular.Text = Convert.ToString(Me.Lista.CurrentRow.Cells("cCelular").Value)
            Me.xContato.Text = Convert.ToString(Me.Lista.CurrentRow.Cells("cContato").Value)
            'Me.xMotivoBloqueado.Text = Me.Lista.CurrentRow.Cells("cMotivoBloqueado").Value & ""
            Me.xBloqueado.Checked = Me.Lista.CurrentRow.Cells("cBloqueado").Value

            If Me.xBloqueado.Checked = True Then
                Me.xMotivoBloqueado.Text = "Favor conduzir o Cliente para o setor de Crédito"
            Else
                Me.xMotivoBloqueado.Text = ""
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub ClientesProcura_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F3
                Me.A1.Checked = True
                Me.TxtProcura.Focus()
            Case Keys.F4
                Me.A2.Checked = True
                Me.TxtProcura.Focus()
            Case Keys.F5
                Me.A5.Checked = True
                Me.TxtProcura.Focus()
            Case Keys.F6
                Me.A3.Checked = True
                Me.TxtProcura.Focus()
            Case Keys.F7
                Me.A3a.Checked = True
                Me.TxtProcura.Focus()
            Case Keys.F8
                Me.A4.Checked = True
                Me.TxtProcura.Focus()
        End Select
    End Sub
End Class