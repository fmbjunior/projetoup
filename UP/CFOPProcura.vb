Public Class CFOPProcura


    Dim Cp As String = String.Empty
    Public Property CampoNome() As String
        Get
            Return Cp
        End Get
        Set(ByVal value As String)
            Cp = value
        End Set
    End Property




    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Dim DBOpen As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))


   
    Private Sub CFOPProcura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DBOpen.Open()
        Ação.Desbloquear_Controle(Me, False)
        Me.TxtProcura.Enabled = True
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
                Sql = "Select CFOP.CFOP, CFOP.Descrição From CFOP Where CFOP = '" & Me.TxtProcura.Text & "' Order by CFOP.Descrição"
            Case 2
                Sql = "Select CFOP.CFOP, CFOP.Descrição From CFOP Where CFOP.Descrição like '%" & Me.TxtProcura.Text & "%' Order by CFOP.Descrição"
            Case 3
                Sql = "Select CFOP.CFOP, CFOP.Descrição From CFOP Order by CFOP.Descrição"
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

        If My.Forms.NFiscal.Visible = True Then
            My.Forms.NFiscal.CFOP.Text = Me.Lista.CurrentRow.Cells(0).Value
            Me.Close()
            Me.Dispose()
        End If

        If My.Forms.ComprasAddItem.Visible = True Then
            If Cp = "CFOPent" Then
                My.Forms.ComprasAddItem.CFOPent.Text = Me.Lista.CurrentRow.Cells(0).Value
            Else
                My.Forms.ComprasAddItem.CFOP.Text = Me.Lista.CurrentRow.Cells(0).Value
            End If

            Me.Close()
            Me.Dispose()
        End If


        'Rotina para verifcar se SellShoesCompraAddItem está ativo.
        If SellShoesComprasAddItem.Visible = True Then
            SellShoesComprasAddItem.CFOP.Text = Me.Lista.CurrentRow.Cells(0).Value
            Me.Close()
            Me.Dispose()
        End If

        'Rotina para verifcar se SellShoesPedidoCompraAddItem está ativo.
        If My.Forms.SellShoesPedidoCompraAddItem.Visible = True Then
            My.Forms.SellShoesPedidoCompraAddItem.CFOP.Text = Me.Lista.CurrentRow.Cells(0).Value
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


    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

   
    Private Sub Lista_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Lista.KeyDown
        If e.KeyCode = Keys.Enter Then
            If My.Forms.NFiscal.Visible = True Then
                My.Forms.NFiscal.CFOP.Text = Me.Lista.CurrentRow.Cells(0).Value
                Me.Close()
                Me.Dispose()
            End If

            If My.Forms.ComprasAddItem.Visible = True Then

                If Cp = "CFOPent" Then
                    My.Forms.ComprasAddItem.CFOPent.Text = Me.Lista.CurrentRow.Cells(0).Value
                Else
                    My.Forms.ComprasAddItem.CFOP.Text = Me.Lista.CurrentRow.Cells(0).Value
                End If

                Me.Close()
                Me.Dispose()
            End If

            'Rotina para verifcar se SellShoesCompraAddItem está ativo.
            If SellShoesComprasAddItem.Visible = True Then
                SellShoesComprasAddItem.CFOP.Text = Me.Lista.CurrentRow.Cells(0).Value
                Me.Close()
                Me.Dispose()
            End If
        End If
    End Sub
End Class