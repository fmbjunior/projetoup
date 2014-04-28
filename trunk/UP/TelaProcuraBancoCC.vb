Imports System.Data.OleDb
Public Class TelaProcuraBancoCC

    
    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub TelaProcuraBancoCC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TxtProcura.Focus()
        Me.A2.Checked = True
    End Sub



#Region "Rotina de Procura"

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged
        If Me.A1.Checked = True Then
            Me.TxtProcura.Enabled = True
            Me.TxtProcura.Focus()
        End If
        If Me.A2.Checked = True Then
            Me.TxtProcura.Enabled = True
            Me.TxtProcura.Focus()
        End If
        If Me.A3.Checked = True Then
            Buscar(3)
        End If
    End Sub

    Private Sub Buscar(ByVal Opt As Integer)

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Select Case Opt
            Case 1
                Sql = "Select Banco.Codigo, Banco.ContaCorrente, Banco.NomeBanco From Banco Where Banco.Empresa = " & CodEmpresa & " And Codigo = " & Me.TxtProcura.Text & " And Inativo = False Order by Banco.ContaCorrente"
            Case 2
                Sql = "Select Banco.Codigo, Banco.ContaCorrente, Banco.NomeBanco From Banco Where Banco.Empresa = " & CodEmpresa & "  And Banco.ContaCorrente like '%" & Me.TxtProcura.Text & "%' And Inativo = False Order by Banco.ContaCorrente"
            Case 3
                Sql = "Select Banco.Codigo, Banco.ContaCorrente, Banco.NomeBanco From Banco Where Banco.Empresa = " & CodEmpresa & " And Inativo = False  Order by Banco.ContaCorrente"
        End Select

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Lista.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        Cnn.Close()
        Me.TxtProcura.Clear()

    End Sub

    Private Sub Lista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellDoubleClick
        If My.Forms.ChequePreClientesBaixa.Visible = True Then
            My.Forms.ChequePreClientesBaixa.Banco.Text = Me.Lista.CurrentRow.Cells("cCodigo").Value
            Me.Close()
            Me.Dispose()
        End If

        If My.Forms.BancoLançamento.Visible = True Then
            My.Forms.BancoLançamento.ContaCorrenteTranferencia.Text = Me.Lista.CurrentRow.Cells("cCodigo").Value
            Me.Close()
            Me.Dispose()
            Exit Sub
        End If

        If My.Forms.BancoVisualizador.Visible = True Then
            My.Forms.BancoVisualizador.Codigo.Text = Me.Lista.CurrentRow.Cells("cCodigo").Value
            Me.Close()
            Me.Dispose()
        End If
    End Sub

    Private Sub TxtProcura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtProcura.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.A1.Checked = True Then
                Buscar(1)
            End If
            If Me.A2.Checked = True Then
                Buscar(2)
            End If
        End If
    End Sub

#End Region
End Class