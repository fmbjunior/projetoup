Public Class SellShoesPendentes

    Private Sub SellShoesPendentes_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.VendaNumero.Clear()
        Me.VendaNumero.Focus()
    End Sub

    Private Sub SellShoesPendentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EncherListaPendente()

        If Len(CaixaAtivo) <> 4 Then
            Me.btAtivarCaixa.Visible = True
        Else
            Me.btAtivarCaixa.Visible = False
        End If
    End Sub


    Public Sub EncherListaPendente()

        Dim Ds As New DataSet

        Dim CN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CN.Open()

        Dim Sql As String = "SELECT Pedido.PedidoSequencia, [CódigoCliente] & ' - ' & [Nome] AS Cliente, Pedido.DataPedido, Pedido.StatusAndamentos, Pedido.TotalPedido, Pedido.PedidoTipo  FROM Pedido INNER JOIN Clientes ON Pedido.CódigoCliente = Clientes.Codigo WHERE (((Pedido.StatusAndamentos)='ENV. CAIXA') AND ((Pedido.Empresa)=" & CodEmpresa & ") AND ((Pedido.Inativo)=False)) Order by Pedido.PedidoSequencia;"

        Dim CMD As New OleDb.OleDbCommand(Sql, CN)
        Dim DaPendentes As New OleDb.OleDbDataAdapter(CMD)

        DaPendentes.Fill(Ds, "Pendentes")
        Me.Lista.DataSource = Ds.Tables("Pendentes").DefaultView


    End Sub

    Private Sub btAtulizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAtulizar.Click
        EncherListaPendente()
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub VendaNumero_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VendaNumero.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.VendaNumero.Text <> "" Then
                My.Forms.SellShoes.AcharVenda = True
                My.Forms.SellShoes.StrVenda = Me.VendaNumero.Text
                My.Forms.SellShoes.ShowDialog()
            End If
        End If
    End Sub

    Private Sub Lista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellDoubleClick
        Dim vID As Integer
        vID = CInt(Me.Lista.CurrentRow.Cells("cPedidoSequencia").Value)

        Me.VendaNumero.Text = vID

        If Me.VendaNumero.Text <> "" Then
            My.Forms.SellShoes.AcharVenda = True
            My.Forms.SellShoes.StrVenda = Me.VendaNumero.Text
            My.Forms.SellShoes.ShowDialog()
        End If
        Me.VendaNumero.Focus()

    End Sub

    Private Sub btAtivarCaixa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAtivarCaixa.Click
        If Len(CaixaAtivo) <> 4 Then
            If MsgBox("Deseja Ativar o caixa agora", 36, "Validação de Dados") = 6 Then
                TRVDados(UserAtivo, "CaixaAtivarDesativar")
                If Ina = True Then
                    MsgBox("O usuário não esta autorizado a usar esta opção do sistema.", 64, "Validação de Dados")
                    Exit Sub
                Else
                    My.Forms.CaixaAtivarDesativar.ShowDialog()
                    If Len(CaixaAtivo) = 4 Then
                        Me.btAtivarCaixa.Visible = False
                    End If
                End If
            End If
        End If
    End Sub
End Class