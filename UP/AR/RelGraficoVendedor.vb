Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class RelGraficoVendedor 
    Dim ds As New DataDynamics.ActiveReports.DataSources.OleDBDataSource
    Private Sub RelGraficoVendedor_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format


       

        ''Configura��o do Datapoints na Legenda
        Dim dp As DataDynamics.ActiveReports.Chart.DataPoint
        For Each dp In Chart.Series(0).Points
            dp.DisplayInLegend = New DataDynamics.ActiveReports.Chart.NullableBoolean(True)
            dp.LegendText = dp.XValue.ToString() + " " + String.Format("{0:C}", dp.YValues(0)) + "  "
        Next dp
    End Sub

    Private Sub RelGraficoVendedor_DataInitialize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.DataInitialize
        ds.SQL = "SELECT Funcion�rios.Nome, Sum(Pedido.TotalPedido) AS SomaDeTotalPedido FROM Pedido INNER JOIN Funcion�rios ON Pedido.C�digoFuncion�rio = Funcion�rios.C�digoFuncion�rio WHERE (((Pedido.DataFechamento) Between #" & Format(CDate(My.Forms.PedidoRelat.DataInicial.Text), "MM/dd/yyy") & "# And #" & Format(CDate(My.Forms.PedidoRelat.DataFinal.Text), "MM/dd/yyy") & "#)) GROUP BY Funcion�rios.Nome ORDER BY Sum(Pedido.TotalPedido) DESC;"
        ds.ConnectionString = New Conectar().ConectarBD(LocalBD & Nome_BD)
        Me.Chart.DataSource = ds
        Me.DataSource = ds
    End Sub

    Private Sub RelGraficoVendedor_ReportStart_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart

    End Sub
End Class
