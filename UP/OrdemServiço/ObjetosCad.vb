Public Class ObjetosCad
    Dim UltimoRegistro As Integer
    Dim A��o As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Dim Autorizado As Boolean

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ObejtosCad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        A��o.Desbloquear_Controle(Me, False)
        EncheLabelObjeto(Me)
    End Sub



    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click

        If Me.Veiculo.Text = "" Then
            MsgBox("N�o foi informado o ve�culo", 48, "Aten��o")
            Exit Sub
        ElseIf Me.placa.Text = "" Then
            MsgBox("N�o foi informado a placa do ve�culo", 48, "Aten��o")
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        Dim sql As String

        If Operation = INS Then
            sql = "INSERT INTO ObjetosCad ( Veiculo, Placa, Km, Renavan, Cor, Obs, DataCadastro,codigoCliente ) VALUES(?,?,?,?,?,?,?,?)"

            Try
                CNN.Open()
                Dim cmd As New OleDb.OleDbCommand(sql, CNN)
                With cmd.Parameters
                    .Add(New OleDb.OleDbParameter("veiculo", NzVlr(Me.Veiculo.Text)))
                    .Add(New OleDb.OleDbParameter("placa", NzVlr(Me.placa.Text)))
                    .Add(New OleDb.OleDbParameter("km", NzVlr(Me.km.Text)))
                    .Add(New OleDb.OleDbParameter("renavan", NzVlr(Me.renavan.Text)))
                    .Add(New OleDb.OleDbParameter("cor", NzVlr(Me.cor.Text)))
                    .Add(New OleDb.OleDbParameter("obs", NzVlr(Me.obs.Text)))
                    .Add(New OleDb.OleDbParameter("DataCadastro", NzVlr(Me.DataCadastro.Text)))
                    .Add(New OleDb.OleDbParameter("codigoCliente", NzVlr(Me.C�digoCliente.Text)))
                End With
                cmd.ExecuteNonQuery()
                cmd.CommandText = "SELECT @@IDENTITY"
                UltimoRegistro = cmd.ExecuteScalar.ToString
                Me.CodObjeto.Text = UltimoRegistro
                CNN.Close()
                MsgBox("Registro Atualizado com sucesso", 48, "Aten��o")
                GerarLog(Me.Text, A��oTP.Adicionou, Me.Veiculo.Text)
                A��o.Desbloquear_Controle(Me, False)
                Operation = UPD
            Catch ex As Exception
                Throw ex
            Finally
                CNN.Close()
            End Try
        ElseIf Operation = UPD Then
            sql = "UPDATE ObjetosCad SET Veiculo=?, Placa=?, Km=?, Renavan=?, Cor=?, Obs=?, DataCadastro=?,codigoCliente=? where CodObjeto=" & Me.CodObjeto.Text

            Try
                CNN.Open()
                Dim cmd As New OleDb.OleDbCommand(sql, CNN)
                With cmd.Parameters
                    .Add(New OleDb.OleDbParameter("veiculo", NzVlr(Me.Veiculo.Text)))
                    .Add(New OleDb.OleDbParameter("placa", NzVlr(Me.placa.Text)))
                    .Add(New OleDb.OleDbParameter("km", NzVlr(Me.km.Text)))
                    .Add(New OleDb.OleDbParameter("renavan", NzVlr(Me.renavan.Text)))
                    .Add(New OleDb.OleDbParameter("cor", NzVlr(Me.cor.Text)))
                    .Add(New OleDb.OleDbParameter("obs", NzVlr(Me.obs.Text)))
                    .Add(New OleDb.OleDbParameter("DataCadastro", NzVlr(Me.DataCadastro.Text)))
                    .Add(New OleDb.OleDbParameter("codigoCliente", NzVlr(Me.C�digoCliente.Text)))
                End With
                cmd.ExecuteNonQuery()
                cmd.CommandText = "SELECT @@IDENTITY"
                CNN.Close()
                MsgBox("Registro Atualizado com sucesso", 48, "Aten��o")
                GerarLog(Me.Text, A��oTP.Editou, Me.Veiculo.Text)
                A��o.Desbloquear_Controle(Me, False)
                Operation = UPD
            Catch ex As Exception
                Throw ex
            Finally
                CNN.Close()
            End Try

        End If

    End Sub
    
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        A��o.LimpaTextBox(Me)
        A��o.Desbloquear_Controle(Me, True)
        Me.DataCadastro.Text = Date.Today
        Operation = INS
        Me.C�digoCliente.Focus()
        Me.NomeCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        If Me.CodObjeto.Text = "" Then
            Exit Sub
        End If
        A��o.Desbloquear_Controle(Me, True)
        Operation = UPD
        Me.C�digoCliente.Focus()

    End Sub
    Private Sub btClienteFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClienteFind.Click
        My.Forms.ClientesProcura.ShowDialog()
        LocalizaDadosCliente()
        Me.C�digoCliente.Focus()
    End Sub

    Private Sub C�digoCliente_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C�digoCliente.Leave
        If String.CompareOrdinal(Me.C�digoCliente.Text, Me.C�digoCliente.TextoAntigo) Then
            LocalizaDadosCliente()
        End If
    End Sub
    Public Sub LocalizaDadosCliente()

        If Me.C�digoCliente.Text = "" Then
            Exit Sub
        End If

        Dim CnnFind As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CnnFind.Open()

        Dim Sql As String = "Select Nome from Clientes where Codigo = " & Me.C�digoCliente.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CnnFind)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.NomeCliente.Text = DR.Item("Nome") & ""
        End If

        DR.Close()
        CnnFind.Close()
    End Sub

    Private Sub C�digoCliente_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles C�digoCliente.Validating
        'If Len(Me.C�digoCliente.Text) = 0 Then
        '    Me.C�digoCliente.Focus()
        '    Exit Sub
        'End If
    End Sub


    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        My.Forms.ObjetoLocalizar.ShowDialog()
    End Sub

    Private Sub C�digoCliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C�digoCliente.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ClientesProcura.ShowDialog()
            LocalizaDadosCliente()
            Me.C�digoCliente.Focus()
        End If
    End Sub

    'Private Sub EncheLabel()

    '    Dim CnnFind As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
    '    CnnFind.Open()

    '    Dim Sql As String = "Select * From ObjetosConf  Where NomeConf = 'NOME-OBJETOS'"
    '    Dim CMD As New OleDb.OleDbCommand(Sql, CnnFind)
    '    Dim DR As OleDb.OleDbDataReader

    '    DR = CMD.ExecuteReader
    '    DR.Read()

    '    If DR.HasRows Then
    '        Me.Cp1.Text = DR.Item("Cp1") & ""
    '        Me.Cp2.Text = DR.Item("Cp2") & ""
    '        Me.Cp3.Text = DR.Item("Cp3") & ""
    '        Me.Cp4.Text = DR.Item("Cp4") & ""
    '        Me.Cp5.Text = DR.Item("Cp5") & ""
    '    End If

    '    DR.Close()
    '    CnnFind.Close()
    'End Sub

    Private Sub CP1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CP1.Click, CP2.Click, CP3.Click, CP4.Click, CP5.Click

        Dim frm As New ObjetoAlterarLegenda
        frm.OwnerControl = sender
        frm.LegendaAlterar = CType(sender, Label).Name
        frm.ShowDialog()
        EncheLabelObjeto(Me)
    End Sub

    Private Sub btExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExcluir.Click


        If Me.CodObjeto.Text = "" Then Exit Sub

        Autorizado = PedirPermissao(Me.Text, Me.CodObjeto.Text)
        If Autorizado = False Then
            Exit Sub
        End If

        If MessageBox.Show("Deseja realmente excluir o OBJETO selecionado.", "Valida��o de Dados", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim ds As New DataSet
            Dim Sql As String = String.Empty

            Sql = "Select * from objetoscad Where codobjeto = " & Me.CodObjeto.Text
            Dim DAObjeto As New OleDb.OleDbDataAdapter(Sql, CNN)
            DAObjeto.Fill(ds, "Objeto")

            Sql = "Select * from Pedido Where codobjeto = " & Me.CodObjeto.Text
            Dim DAPedidoOS As New OleDb.OleDbDataAdapter(Sql, CNN)
            DAPedidoOS.Fill(ds, "PedidoOS")


            Try
                If ds.Tables("PedidoOS").Rows.Count = 0 Then 'Se nao existir pedido com contrto entra e faz as exclusoes
                    If ds.Tables("Objeto").Rows.Count = 1 Then
                        ds.Tables("Objeto").Rows(0).Delete()
                    End If

                    Dim objBuilder As New OleDb.OleDbCommandBuilder(DAObjeto)
                    DAObjeto.Update(ds, "Objeto")
                    MessageBox.Show("Registro Excluido com sucesso", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    A��o.LimpaTextBox(Me)
                    A��o.Desbloquear_Controle(Me, True)
                    Me.DataCadastro.Text = Date.Today
                    Operation = INS
                    Me.C�digoCliente.Focus()
                    Me.NomeCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim

                    CNN.Close()
                Else
                    MessageBox.Show("Existe pedido feito para este Objeto, o Objeto n�o pode ser excluido", "Valida��o de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ds.Dispose()
                    CNN.Close()
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                CNN.Close()
                Exit Sub
            End Try

        End If


    End Sub
End Class