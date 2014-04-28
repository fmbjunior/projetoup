Public Class frmProducaoAdd2
    Dim PED As New clsPedidoMP
    Dim ORDEM As New clsProducao
    Dim strpedido As String
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Public Sub New(ByVal value As String)
        InitializeComponent()
        PED.MostrarPedido(value, "P")
        Me.CodigoCliente.Text = PED.CodigoCliente
        Me.NomeCliente.Text = PED.nomeCliente
        Me.CodigoVendedor.Text = PED.CodigoFuncionario
        Me.NomeVendedor.Text = PED.NomeVendedor
        Me.DataPedido.Text = PED.DataPedido
        Me.DataPrazo.Text = PED.DataPrazoEntrega
        With ORDEM
            .Numeropedido = value
            .Codigocliente = Me.CodigoCliente.Text
            .Empresa = PED.Empresa
            .Dataordem = DataDia
        End With

    End Sub
    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        ORDEM.Gravar()
        If Not ORDEM.ErroRetorno Then
            Retorno = ORDEM.CRetorno
            My.Forms.frmProducaoAdd1.Dispose()
            Me.Dispose()
        End If

    End Sub
End Class