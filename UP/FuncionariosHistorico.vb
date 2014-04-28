Public Class FuncionariosHistorico

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Novo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Novo.Click
        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)
        Me.Id.Text = "0000"
        Me.Id.Enabled = False
        Operation = INS
        Me.DataHistorico.Focus()
    End Sub

    Private Sub Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar.Click
        If Me.Id.Text = "" Then
            MsgBox("No existe Hitórico para ser editado.", 64, "Validação de Dados")
            Exit Sub
        End If
        Operation = UPD
        Ação.Desbloquear_Controle(Me, True)
        Me.Id.Enabled = False
        Me.DataHistorico.Focus()
    End Sub

    Private Sub Salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salvar.Click
        'Area destinada para as validacoes

        If Me.DataHistorico.Text = "" Then
            MsgBox("A data do Histórico não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.DataHistorico.Focus()
            Exit Sub
        ElseIf Me.Historico.Text = "" Then
            MsgBox("O Histórico do funcionário não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Historico.Focus()
            Exit Sub
        ElseIf Me.Id.Text = "" Then
            MsgBox("O Sistema não conseguiu definir o Id do Histórico, favor verificar.", 64, "Validação de Dados")
            Exit Sub
        End If

        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then

            Ação.Ultimo_Registro(Me, Me.Id, "FuncionárioHistorico", "Id")
            If Me.Id.Text = "" Then
                MsgBox("O Sistema não conseguiu definir o Id do Histórico, favor verificar.", 64, "Validação de Dados")
                Exit Sub
            End If

            CNN.Open()

            Dim Sql As String = "INSERT INTO FuncionárioHistorico (Id, Funcionario, DataHistorico, Historico) VALUES (@1, @2, @3, @4)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Id.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(My.Forms.Funcionarios.CódigoFuncionário.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataHistorico.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Historico.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                Operation = UPD
                CNN.Close()
                EncheLista()
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            Ação.Desbloquear_Controle(Me, False)

        ElseIf Operation = UPD Then
            CNN.Open()


            Dim Sql As String = "Update FuncionárioHistorico set Funcionario = @2, DataHistorico = @3, Historico = @4 Where Id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            'cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Id.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(My.Forms.Funcionarios.CódigoFuncionário.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataHistorico.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Historico.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                Operation = UPD
                CNN.Close()
                EncheLista()
            Catch x As Exception
                'MsgBox(x.Message)
                'Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, False)
        End If

    End Sub




    Public Sub EncheLista()

        MyLista.Items.Clear()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        Cnn.Open()

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM FuncionárioHistorico WHERE Funcionario = " & My.Forms.Funcionarios.CódigoFuncionário.Text
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            Dim Zebrar As Boolean = True
            While DataReader.Read
                If Not IsDBNull(DataReader.Item("Id")) Then
                    Dim AA As String = DataReader.Item("Id")
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("DataHistorico") & "")
                    item1.SubItems.Add(DataReader.Item("Historico") & "")
                    MyLista.Items.AddRange(New ListViewItem() {item1})

                    If Zebrar = True Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.LemonChiffon
                        Zebrar = False
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.Azure
                        Zebrar = True
                    End If

                End If
            End While
            DataReader.Close()
            Cnn.Close()
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
    End Sub

    Private Sub FuncionariosHistorico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ação.Desbloquear_Controle(Me, False)
        EncheLista()
    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        Dim I As Integer = 0

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then Me.Id.Text = (MyLista.Items(I).Text.Substring(0))
            If MyLista.Items(I).Selected = True Then Me.DataHistorico.Text = MyLista.Items(I).SubItems(1).Text.Substring(0)
            If MyLista.Items(I).Selected = True Then Me.Historico.Text = MyLista.Items(I).SubItems(2).Text.Substring(0)
        Next
        Operation = UPD
    End Sub
End Class