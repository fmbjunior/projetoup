Public Class TipoSolicitação

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))


    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Novo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Novo.Click
        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)
        Me.TipoSolicitaçao.Focus()
        Operation = INS
    End Sub

    Private Sub TipoSolicitação_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ação.Desbloquear_Controle(Me, False)
        Me.MyLista.Enabled = True
        CNN.Open()
        EncheLista()
    End Sub

    Private Sub Salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salvar.Click
        'Area destinada para as validacoes
        If Me.TipoSolicitaçao.Text = "" Then
            MsgBox("O Tipo de Solicitação não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.TipoSolicitaçao.Focus()
            Exit Sub
        ElseIf Me.DiasMinimo.Text = "" Then
            MsgBox("A quantidade de dias Mínimo não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.DiasMinimo.Focus()
            Exit Sub
        ElseIf Me.DiasMaximo.Text = "" Then
            MsgBox("A quantidade de dias Máximo não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.DiasMaximo.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes


        If Operation = INS Then

            Dim Sql As String = "INSERT INTO TPSolicitaçao (TipoSolicitaçao, DiasMinimo, DiasMaximo, Empresa) VALUES (@1, @2, @3, @4)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.TipoSolicitaçao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DiasMinimo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DiasMaximo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", CodEmpresa))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                Operation = UPD
                EncheLista()
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            Ação.Desbloquear_Controle(Me, False)

        ElseIf Operation = UPD Then

            Dim Sql As String = "Update TPSolicitaçao set TipoSolicitaçao = @1, DiasMinimo = @2, DiasMaximo = @3, Empresa = @4  Where TipoSolicitaçao = '" & Me.TipoSolicitaçao.Text & "'"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.TipoSolicitaçao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DiasMinimo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DiasMaximo.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", CodEmpresa))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                Operation = UPD
                EncheLista()
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, False)
        End If

    End Sub

    Public Sub EncheLista()

        MyLista.Items.Clear()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader


        With Cmd
            .Connection = CNN
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM TPSolicitaçao WHERE Empresa = " & CodEmpresa & " and Inativo = False"
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            Dim Zebrar As Boolean = False
            While DR.Read
                If Not IsDBNull(DR.Item("TipoSolicitaçao")) Then
                    Dim AA As String = DR.Item("TipoSolicitaçao")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("DiasMinimo") & "")
                    It.SubItems.Add(DR.Item("DiasMaximo") & "")

                    MyLista.Items.AddRange(New ListViewItem() {It})

                    If Zebrar = True Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.Orange
                        Zebrar = True
                    End If

                End If
            End While

            DR.Close()
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Exit Sub
        End Try

    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        Dim I As Integer = 0
        RetornoProcura = ""
        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then Me.TipoSolicitaçao.Text = (MyLista.Items(I).Text.Substring(0))
            If MyLista.Items(I).Selected = True Then Me.DiasMinimo.Text = MyLista.Items(I).SubItems(1).Text.Substring(0)
            If MyLista.Items(I).Selected = True Then Me.DiasMaximo.Text = MyLista.Items(I).SubItems(1).Text.Substring(0)
        Next
        Operation = UPD
        Ação.Desbloquear_Controle(Me, True)
        Me.TipoSolicitaçao.Focus()
    End Sub

    Private Sub Excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Excluir.Click
        MsgBox("Esta opção não esta disponivel.", 64, "Validação de Dados")
        Exit Sub
    End Sub
End Class