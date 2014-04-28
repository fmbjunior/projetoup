Imports System.Data.OleDb
Public Class ContratoProcura


    Private Sub TxtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProcura.Leave
        If Me.TxtProcura.Text = "" Then
            Exit Sub
        End If

        If Me.A1.Checked = True Then
            Dim var As String = Me.TxtProcura.Text
            Me.TxtProcura.Text = var.PadLeft(6, "0")
            BuscarCliente(1)
        End If
        If Me.A2.Checked = True Then BuscarCliente(2)
        Me.Lista.Focus()

    End Sub


    Private Sub BuscarCliente(ByVal Opt As String)

        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty
        Try
            Select Case Opt
                Case 1
                    Sql = "SELECT Contratos.CodContrato, Contratos.ValorContrato, Clientes.Nome, Contratos.Finalizado FROM Clientes RIGHT JOIN Contratos ON Clientes.Codigo = Contratos.Cliente WHERE (((Contratos.CodContrato)='" & Me.TxtProcura.Text & "'));"

                Case 2
                    Sql = "SELECT Contratos.CodContrato, Contratos.ValorContrato, Clientes.Nome, Contratos.Finalizado FROM Clientes RIGHT JOIN Contratos ON Clientes.Codigo = Contratos.Cliente WHERE (((Clientes.Nome) Like '%" & Me.TxtProcura.Text & "%'));"
                Case 3
                    Sql = "SELECT Contratos.CodContrato, Contratos.ValorContrato, Clientes.Nome,Contratos.Finalizado FROM Clientes RIGHT JOIN Contratos ON Clientes.Codigo = Contratos.Cliente WHERE (((Contratos.Finalizado) ='N'));"
            End Select

            Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
            Dim ds As New DataSet
            da.Fill(ds, "Table")

            Me.Lista.DataSource = ds.Tables("Table").DefaultView

            da.Dispose()
            Cnn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub TelaProcura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TxtProcura.Focus()
        Me.A2.Checked = True
    End Sub

    Private Sub CampoChave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles A1.Click, A2.Click
        Me.TxtProcura.Focus()
    End Sub

    Private Sub Lista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellDoubleClick
        Dim vID As String
        vID = NzZero(Me.Lista.CurrentRow.Cells(0).Value)

        If My.Forms.Contrato.Visible = True Then My.Forms.Contrato.CodContrato.Text = vID


        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged
        If Me.A1.Checked = True Then
            Me.TxtProcura.Focus()
        End If
        If Me.A2.Checked = True Then
            Me.TxtProcura.Focus()
        End If
       
    End Sub

   
 

    Private Sub Lista_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Lista.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim vID As String
                vID = Me.Lista.CurrentRow.Cells(0).Value

                If My.Forms.Contrato.Visible = True Then My.Forms.Contrato.CodContrato.Text = vID


                Me.Close()
                Me.Dispose()
            Catch
            End Try
        End If
    End Sub

    Private Sub A3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A3.CheckedChanged
        BuscarCliente(3)
    End Sub

    Private Sub Lista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Lista.CellContentClick

    End Sub
End Class