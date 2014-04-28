Public Class ClienteCr

    Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

    Dim Ação As New TrfGerais()
    Dim NovoReg As Boolean = False

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Private Sub BtSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSalvar.Click

        Dim CodCliente As Integer
        Dim IdProcura As Double
        Dim Prg As String = ""

        CodCliente = RetornoProcura


        If Operation = INS Then

            UltimoReg()

            Dim Sql As String = "INSERT INTO ClientesCR (Id, Cliente, DataOcorrencia, Ocorrencia, IdProcura, Prg, Documento) VALUES (@1, @2, @3, @4, @5, @6, @7)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Id.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", CodCliente))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.DataOcorrencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Me.Ocorrencia.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(IdProcura, 3)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Prg, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Documento.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                EncheLista()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                Operation = INS
                Me.DataOcorrencia.Clear()
                Me.Ocorrencia.Clear()
                Me.DataOcorrencia.Focus()
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try

        ElseIf Operation = UPD Then

            Dim Sql As String = "Update ClientesCr set DataOcorrencia = @2, Ocorrencia = @3, Documento = @4 Where Id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataOcorrencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Me.Ocorrencia.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Documento.Text, 1)))
            Try
                cmd.ExecuteNonQuery()
                EncheLista()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                Operation = INS
                Me.DataOcorrencia.Clear()
                Me.Ocorrencia.Clear()
                Me.DataOcorrencia.Focus()

            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
        End If

    End Sub

    Public Sub UltimoReg()
        'Inserir ultimo registro

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer
        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select max(Id) from ClientesCR"
            .CommandType = CommandType.Text
        End With
        Try
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
                Exit Sub
            End If
        End Try

        Me.Id.Text = Ult + 1
        
    End Sub

    Private Sub ClienteCr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()
        CNN.Open()
        Operation = INS
        EncheLista()
    End Sub


    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub EncheLista()

        MyLista.Items.Clear()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM ClientesCR WHERE Cliente = " & RetornoProcura
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader
            Dim Zebrar As Boolean = False
            While DR.Read
                If Not IsDBNull(DR.Item("Id")) Then
                    Dim AA As String = DR.Item("Id")
                    Dim It As New ListViewItem(AA, 0)

                    It.SubItems.Add(DR.Item("Cliente") & "")
                    It.SubItems.Add(DR.Item("DataOcorrencia") & "")
                    It.SubItems.Add(DR.Item("Documento") & "")
                    It.SubItems.Add(DR.Item("Ocorrencia") & "")

                    MyLista.Items.AddRange(New ListViewItem() {It})

                    If Zebrar = False Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.PowderBlue
                        Zebrar = True
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    End If

                End If
            End While
            DR.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
        End Try

    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        Dim I As Integer = 0

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then Me.Id.Text = (MyLista.Items(I).Text.Substring(0))
            If MyLista.Items(I).Selected = True Then Me.DataOcorrencia.Text = (MyLista.Items(I).SubItems(2).Text.Substring(0))
            If MyLista.Items(I).Selected = True Then Me.Documento.Text = MyLista.Items(I).SubItems(3).Text.Substring(0)
            If MyLista.Items(I).Selected = True Then Me.Ocorrencia.Text = MyLista.Items(I).SubItems(4).Text.Substring(0)

        Next
        Operation = UPD
        Me.DataOcorrencia.Focus()

    End Sub

    Private Sub Degrade()
        Try
            Dim CCor() As String
            Dim corTemp As String

            corTemp = Cor1TelaSecundaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))

            corTemp = Cor2TelaSecundaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))
        Catch ex As Exception
        End Try
    End Sub

End Class