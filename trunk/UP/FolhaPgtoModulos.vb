Public Class FolhaPgtoModulos

    Dim M_Selecionado As String = ""

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub EncheLista()

        MyLista.Items.Clear()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader


        With Cmd
            .Connection = CNN
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM FolhaPgtoModulos"
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            Dim Zebrar As Boolean = False
            While DR.Read
                If Not IsDBNull(DR.Item("Modulo")) Then
                    Dim AA As String = DR.Item("Modulo")
                    Dim It As New ListViewItem(AA, 0)


                    MyLista.Items.AddRange(New ListViewItem() {It})

                    If Zebrar = True Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.MistyRose
                        Zebrar = True
                    End If

                End If
            End While

            DR.Close()
            CNN.Close()
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Exit Sub
        End Try

    End Sub

    Private Sub FolhaPgtoModulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()
        EncheLista()
    End Sub

    Private Sub MyLista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyLista.SelectedIndexChanged
        Dim I As Integer = 0

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then M_Selecionado = (MyLista.Items(I).Text.Substring(0))
        Next

        EncheListaEventos()
    End Sub

    Private Sub EncheListaEventos()
        Me.ListaEventos.Items.Clear()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader


        With Cmd
            .Connection = CNN
            .CommandTimeout = 0
            .CommandText = "SELECT FolhaPgtoModulosEventos.ID, FolhaPgtoModulosEventos.Modulo, FolhaPgtoModulosEventos.CodigoEvento, FolhaPgtoEventos.Descrição FROM FolhaPgtoEventos INNER JOIN FolhaPgtoModulosEventos ON FolhaPgtoEventos.CodigoEvento = FolhaPgtoModulosEventos.CodigoEvento WHERE (((FolhaPgtoModulosEventos.Modulo) =  '" & M_Selecionado & "'));"
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            Dim Zebrar As Boolean = False
            While DR.Read
                If Not IsDBNull(DR.Item("Id")) Then
                    Dim AA As String = DR.Item("Id")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("Modulo"))
                    It.SubItems.Add(DR.Item("CodigoEvento") & "")
                    It.SubItems.Add(DR.Item("Descrição") & "")
                    ListaEventos.Items.AddRange(New ListViewItem() {It})

                    If Zebrar = True Then
                        ListaEventos.Items.Item(ListaEventos.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    Else
                        ListaEventos.Items.Item(ListaEventos.Items.Count() - 1).BackColor = Color.MistyRose
                        Zebrar = True
                    End If

                End If
            End While

            DR.Close()
            CNN.Close()
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            Exit Sub
        End Try

    End Sub

    Private Sub ExcluirEventosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirEventosToolStripMenuItem.Click

        Dim I As Integer = 0

        Dim ID_id As String = ""
        Dim LogString As String = ""

        For I = 0 To ListaEventos.Items.Count - 1
            If ListaEventos.Items(I).Selected = True Then
                ID_id = ListaEventos.Items(I).Text.Substring(0)
                LogString = "Excluiu o id : " & ID_id & " Modulo : " & ListaEventos.Items(I).SubItems(1).Text.Substring(0) & " Evento : " & ListaEventos.Items(I).SubItems(2).Text.Substring(0)
            End If
        Next


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Delete * from FolhaPgtoModulosEventos Where ID = " & ID_id
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        Try
            cmd.ExecuteNonQuery()
            CNN.Close()
            EncheListaEventos()
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validação de Dados")
        End Try


    End Sub

    Private Sub AdicionarEventosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarEventosToolStripMenuItem.Click

        If M_Selecionado = "" Then
            MsgBox("O usuário deve selecionar um Módulo ante de adicionar eventos.", 64, "Validação de Dados")
            Exit Sub
        End If
        Me.MyLista.Enabled = False
        Me.ListaEventos.Enabled = False
        Me.Fechar.Enabled = False
        Me.PainelCadEventos.Visible = True
        Me.EventoID.Focus()
    End Sub

    Private Sub Vortar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vortar.Click
        Me.MyLista.Enabled = True
        Me.ListaEventos.Enabled = True
        Me.Fechar.Enabled = True
        Me.PainelCadEventos.Visible = False
    End Sub

    Private Sub AddBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBt.Click
        'Area destinada para as validacoes
        If Me.EventoID.Text = "" Then
            MsgBox("O Evento não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.EventoID.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim IdReg As Integer = UltimoReg()
        Dim Sql As String = "INSERT INTO FolhaPgtoModulosEventos (ID, Modulo, CodigoEvento) VALUES (@1, @2, @3)"
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", IdReg))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", M_Selecionado))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Me.EventoID.Text))

        Try
            cmd.ExecuteNonQuery()
            CNN.Close()
            EncheListaEventos()
            Me.EventoID.Clear()
            Me.EventoDesc.Text = ""
            Me.EventoID.Focus()
            MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
        Catch ex As Exception
            MsgBox(ex.Message, 64, "Validação de Dados")
            CNN.Close()
        End Try

    End Sub

    Public Function UltimoReg()
        'Inserir ultimo registro
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer
        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select max(Id) from FolhaPgtoModulosEventos"
            .CommandType = CommandType.Text
        End With
        Try
            Cnn.Open()
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    'Achou o iten procurado o iten as caixas serão preenchida
                    Ult = DataReader.Item(0)
                End If
            End While
            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Return 0
                Exit Function
            End If
        End Try
        Cnn.Close()

        Return (Ult + 1)
        'fim inserir ultimo registro

    End Function

    Private Sub EventoID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles EventoID.KeyDown
        If e.KeyCode = Keys.F5 Then
            SomenteEvento = "N"
            ChamaTelaProcura("Codigo", "Descricão", "", "FolhaPgtoEventos", "CodigoEvento", "Descrição", "", True)
            Me.EventoID.Text = RetornoProcura
            Me.EventoID.Focus()
        End If
    End Sub

    Private Sub EventoID_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles EventoID.Validated
        If Me.EventoID.Text <> "" Then
            LocalizaDados()
        End If
    End Sub

    Public Sub LocalizaDados()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from FolhaPgtoEventos where CodigoEvento = " & Me.EventoID.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.EventoDesc.Text = DR.Item("Descrição") & ""
        End If
        DR.Close()
        CNN.Close()
    End Sub

    Private Sub Degrade()
        Try
            Dim CCor() As String
            Dim corTemp As String

            corTemp = Cor1TelaPrimaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))

            corTemp = Cor2TelaPrimaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))
        Catch ex As Exception
        End Try
    End Sub
End Class