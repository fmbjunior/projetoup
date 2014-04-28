Public Class FuncionariosHistorico

    Dim A��o As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Novo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Novo.Click
        A��o.LimpaTextBox(Me)
        A��o.Desbloquear_Controle(Me, True)
        Me.Id.Text = "0000"
        Me.Id.Enabled = False
        Operation = INS
        Me.DataHistorico.Focus()
    End Sub

    Private Sub Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar.Click
        If Me.Id.Text = "" Then
            MsgBox("No existe Hit�rico para ser editado.", 64, "Valida��o de Dados")
            Exit Sub
        End If
        Operation = UPD
        A��o.Desbloquear_Controle(Me, True)
        Me.Id.Enabled = False
        Me.DataHistorico.Focus()
    End Sub

    Private Sub Salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salvar.Click
        'Area destinada para as validacoes

        If Me.DataHistorico.Text = "" Then
            MsgBox("A data do Hist�rico n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.DataHistorico.Focus()
            Exit Sub
        ElseIf Me.Historico.Text = "" Then
            MsgBox("O Hist�rico do funcion�rio n�o foi informado, favor verificar.", 64, "Valida��o de Dados")
            Me.Historico.Focus()
            Exit Sub
        ElseIf Me.Id.Text = "" Then
            MsgBox("O Sistema n�o conseguiu definir o Id do Hist�rico, favor verificar.", 64, "Valida��o de Dados")
            Exit Sub
        End If

        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then

            A��o.Ultimo_Registro(Me, Me.Id, "Funcion�rioHistorico", "Id")
            If Me.Id.Text = "" Then
                MsgBox("O Sistema n�o conseguiu definir o Id do Hist�rico, favor verificar.", 64, "Valida��o de Dados")
                Exit Sub
            End If

            CNN.Open()

            Dim Sql As String = "INSERT INTO Funcion�rioHistorico (Id, Funcionario, DataHistorico, Historico) VALUES (@1, @2, @3, @4)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Id.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(My.Forms.Funcionarios.C�digoFuncion�rio.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataHistorico.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Historico.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Valida��o de Dados")
                Operation = UPD
                CNN.Close()
                EncheLista()
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Valida��o de Dados")
            End Try
            A��o.Desbloquear_Controle(Me, False)

        ElseIf Operation = UPD Then
            CNN.Open()


            Dim Sql As String = "Update Funcion�rioHistorico set Funcionario = @2, DataHistorico = @3, Historico = @4 Where Id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            'cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Id.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(My.Forms.Funcionarios.C�digoFuncion�rio.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataHistorico.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Historico.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Valida��o de Dados")
                Operation = UPD
                CNN.Close()
                EncheLista()
            Catch x As Exception
                'MsgBox(x.Message)
                'Exit Sub
            End Try
            A��o.Desbloquear_Controle(Me, False)
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
            .CommandText = "SELECT * FROM Funcion�rioHistorico WHERE Funcionario = " & My.Forms.Funcionarios.C�digoFuncion�rio.Text
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
        A��o.Desbloquear_Controle(Me, False)
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