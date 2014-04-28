Public Class Cfop

    Dim A��o As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Dim Autorizado As Boolean

    Dim DBOpen As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))


    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DBOpen.Open()
        A��o.Desbloquear_Controle(Me, False)
        Me.TxtProcura.Enabled = True
    End Sub

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        A��o.LimpaTextBox(Me)
        A��o.Desbloquear_Controle(Me, True)
        Me.TxtProcura.Enabled = True
        Me.Descri��o.Focus()
        Operation = INS
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        'Area destinada para as validacoes
        If Me.CFOPcx.Text = "" Then
            MsgBox("O CFOP n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.CFOPcx.Focus()
            Exit Sub
        ElseIf Me.Descri��o.Text = "" Then
            MsgBox("A descri��o do CFOP n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Descri��o.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            Dim Sql As String = "INSERT INTO CFOP (CFOP, Descri��o) VALUES (@1, @2)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CFOPcx.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Descri��o.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Valida��o de Dados")
                GerarLog(Me.Text, A��oTP.Adicionou, Me.CFOPcx.Text)
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Valida��o de Dados")
            End Try
            A��o.Desbloquear_Controle(Me, False)
            Me.TxtProcura.Enabled = True
            CNN.Close()

        ElseIf Operation = UPD Then
            CNN.Open()

            Dim Sql As String = "Update CFOP set CFOP = @1, Descri��o = @2 Where CFOP = '" & Me.CFOPcx.Text & "'"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CFOPcx.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Descri��o.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Valida��o de Dados")
                GerarLog(Me.Text, A��oTP.Editou, Me.CFOPcx.Text)
            Catch x As Exception
                'MsgBox(x.Message)
                'Exit Sub
            End Try
            A��o.Desbloquear_Controle(Me, False)
            Me.TxtProcura.Enabled = True
            CNN.Close()
        End If
    End Sub

    Private Sub btEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEditar.Click
        If Me.CFOPcx.Text = "" Then
            MsgBox("No existe CFOP para ser editado.", 64, "Valida��o de Dados")
            Exit Sub
        End If
        Operation = UPD
        A��o.Desbloquear_Controle(Me, True)
        Me.TxtProcura.Enabled = True
        Me.CFOPcx.Focus()
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
                Sql = "Select Cfop.Cfop, Cfop.Descri��o From Cfop Where Cfop = '" & Me.TxtProcura.Text & "' Order by Cfop.Descri��o"
            Case 2
                Sql = "Select Cfop.Cfop, Cfop.Descri��o From Cfop Where Cfop.Descri��o like '%" & Me.TxtProcura.Text & "%' Order by Cfop.Descri��o"
            Case 3
                Sql = "Select Cfop.Cfop, Cfop.Descri��o From Cfop Order by Cfop.Descri��o"
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

        Me.CFOPcx.Text = Me.Lista.CurrentRow.Cells(0).Value
        Me.Descri��o.Text = Me.Lista.CurrentRow.Cells(1).Value
        Me.CFOPcx.Enabled = False
        Me.Descri��o.Enabled = False
        Operation = UPD

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

    
    Private Sub btExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExcluir.Click

        If Me.CFOPcx.Text = "" Then Exit Sub

        Autorizado = PedirPermissao(Me.Text, Me.CFOPcx.Text)
        If Autorizado = False Then
            Exit Sub
        End If


        If MessageBox.Show("Deseja realmente excluir o CFOP selecionado.", "Valida��o de Dados", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim ds As New DataSet
            Dim Sql As String = String.Empty

            Sql = "Select * from CFOP Where CFOP = '" & Me.CFOPcx.Text & "'"
            Dim DACFOP As New OleDb.OleDbDataAdapter(Sql, CNN)
            DACFOP.Fill(ds, "CFOP")

            Sql = "Select * from Compra Where CFOP = '" & Me.CFOPcx.Text & "'"
            Dim DACompra As New OleDb.OleDbDataAdapter(Sql, CNN)
            DACompra.Fill(ds, "Compra")

            Sql = "SELECT * From ItensCompra Where CFOP = '" & Me.CFOPcx.Text & "'"
            Dim DAITcompra As New OleDb.OleDbDataAdapter(Sql, CNN)
            DAITcompra.Fill(ds, "ItensCompra")


            Try
                If ds.Tables("Compra").Rows.Count = 0 Then
                    If ds.Tables("ItensCompra").Rows.Count = 0 Then
                        If ds.Tables("CFOP").Rows.Count = 1 Then
                            ds.Tables("CFOP").Rows(0).Delete()
                        End If

                        Dim objBuilder As New OleDb.OleDbCommandBuilder(DACFOP)
                        DACFOP.Update(ds, "CFOP")
                        MessageBox.Show("Registro Excluido com sucesso", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Dim I As Integer
                        For I = 0 To Me.Lista.Rows.Count - 1
                            Me.Lista.Rows.RemoveAt(0)
                        Next

                        A��o.LimpaTextBox(Me)
                        A��o.Desbloquear_Controle(Me, True)
                        Me.TxtProcura.Enabled = True
                        Me.CFOPcx.Focus()
                        Operation = INS

                        CNN.Close()
                    Else
                        MessageBox.Show("Existe Movimento feito para este CFOP, o CFOP n�o pode ser excluido", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ds.Dispose()
                        CNN.Close()
                        Exit Sub
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                CNN.Close()
                Exit Sub
            End Try
        End If


    End Sub
End Class