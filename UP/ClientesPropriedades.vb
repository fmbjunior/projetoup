Imports System.IO
Imports System.Data.OleDb

Public Class ClientesPropriedades
    Dim Ação As New TrfGerais()

    Dim CaminhoImagem As String = ""

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

#Region "Ação para combos "

    Private Sub CarregaUF(ByVal Controle As CBOAutoCompleteFocus.CboFocus)
        Dim i As Integer
        For i = 0 To UFArray.Count - 1
            Controle.Items.Add(New cboItemData(UFArray(i).Valor, UFArray(i).Descrição))
        Next
    End Sub

    Private Enum TpRetornoCBO
        Não = 0
        Sim = 1
    End Enum
    Private Function PegaVlrCombo(ByVal Cbo As CBOAutoCompleteFocus.CboFocus, ByVal Retorna_Descrição As TpRetornoCBO)

        Dim Retorno As String = ""
        If Cbo.Text = "" Then
            Retorno = ""

        Else
            Cbo.SelectedIndex = Cbo.FindStringExact(Cbo.Text & "")
            If Retorna_Descrição = TpRetornoCBO.Não Then
                Retorno = CType(Cbo.SelectedItem, cboItemData).ItemData
            Else
                Retorno = CType(Cbo.SelectedItem, cboItemData).Name
            End If
        End If
        Return Retorno




    End Function
    Private Sub MUNICIPIO_Preencher(ByVal ControleUF As CBOAutoCompleteFocus.CboFocus, ByVal ControleMunicipio As CBOAutoCompleteFocus.CboFocus)
        If ControleUF.Text = "" Then
            ControleMunicipio.Items.Clear()
            Exit Sub
        End If

        ControleMunicipio.Items.Clear()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "SELECT * FROM Municipio where UF = '" & CType(ControleUF.SelectedItem, cboItemData).ItemData & "' order by NomeMunic"
        Dim Cmd As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        Try
            DR = Cmd.ExecuteReader
            While DR.Read
                ControleMunicipio.Items.Add(New cboItemData(DR.Item("CodMunicipio"), DR.Item("NomeMunic")))
            End While
            DR.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()

    End Sub
#End Region

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        '' Ação.LimpaTextBox(Me, Me.NomePropriedade)
        Me.NomePropriedade.Clear()
        Me.Endereço.Clear()
        Me.Cidade.Clear()
        Me.Cep.Clear()
        Me.Fone.Clear()
        Me.Inscricao.Clear()
        Me.Obs.Clear()
        Me.Roteiro.Clear()
        Me.cUF.SelectedIndex = -1
        Me.cMun.SelectedIndex = -1
        Ação.Desbloquear_Controle(Me, True)
        Operation = INS
        UltimoReg()
    End Sub

    Public Sub UltimoReg()
        'Inserir ultimo registro
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer
        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select max(Id) from Propriedades"
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
                Exit Sub
            End If
        End Try
        Cnn.Close()

        Me.Id.Text = Ult + 1
        Me.NomePropriedade.Focus()
        'fim inserir ultimo registro

    End Sub

    Private Sub ClientesPropriedades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ação.Desbloquear_Controle(Me, False)
        EncherLista()
        CarregaUF(Me.cUF)
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        'Area destinada para as validacoes
        If Me.Id.Text = "" Then
            MsgBox("O Código da propriedade do Cliente não foi informado, favor verificar.", 64, "Validação de Dados")
            Exit Sub
        ElseIf Me.Cliente.Text = "" Then
            MsgBox("O Código do Cliente não foi informado, favor verificar.", 64, "Validação de Dados")
            Exit Sub
        ElseIf Me.NomePropriedade.Text = "" Then
            MsgBox("O Nome da propriedade do Cliente não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.NomePropriedade.Focus()
            Exit Sub

        ElseIf Me.Endereço.Text = "" Then
            MsgBox("O endereço da propriedade  não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Endereço.Focus()
            Exit Sub

        ElseIf Me.cUF.Text = "" Then
            MsgBox("O estado da propriedade do Cliente não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.cUF.Focus()
            Exit Sub

        ElseIf Me.cMun.Text = "" Then
            MsgBox("O Nome da Cidade da propriedade do Cliente não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.cMun.Focus()
            Exit Sub
        ElseIf Me.Nro.Text = "" Then
            MsgBox("Por favor o número não pode ser nulo. O sistema colocará 'S/N'", 64, "Validação de Dados")
            Me.Nro.Text = "S/N"

            Me.Nro.Focus()
            Exit Sub

        ElseIf Me.Inscricao.Text = "" Then
            MsgBox("A incrição da propriedade do Cliente não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Inscricao.Focus()
            Exit Sub
        End If

        If ChecaInscrE(Me.cUF.Text, Me.Inscricao.Text) = False Then
            MsgBox("A Inscrição Estadual informada não é válida !!!", vbCritical, "Validação de Dados")
            Me.cUF.Focus()
            Exit Sub
        End If

        'Fim da Area destinada para as validacoes.

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            Dim Sql As String = "INSERT INTO Propriedades (Id, NomePropriedade, Endereco, Cidade, cUf, Cep, Fone, Inscricao, Obs, Cliente, cMun, Nro, Estado,Roteiro) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Id.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.NomePropriedade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Endereço.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Cidade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", PegaVlrCombo(Me.cUF, TpRetornoCBO.Não)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Cep.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Fone.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Inscricao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Obs.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.Cliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", PegaVlrCombo(Me.cMun, TpRetornoCBO.Não)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.Nro.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", PegaVlrCombo(Me.cUF, TpRetornoCBO.Sim)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.Roteiro.Text, 1)))
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Adicionou, Me.Id.Text)
                Ação.Desbloquear_Controle(Me, False)
                Operation = UPD

            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            CNN.Close()
            EncherLista()

        ElseIf Operation = UPD Then
            CNN.Open()

            Dim Sql As String = "Update Propriedades set NomePropriedade = @2, Endereco = @3, Cidade = @4, cUf = @5, Cep = @6, Fone = @7, Inscricao = @8, Obs = @9, Cliente = @10, cMun = @11, Nro = @12, Estado = @13, Roteiro = @14 Where id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            'cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Id.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.NomePropriedade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Endereço.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Cidade.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", PegaVlrCombo(Me.cUF, TpRetornoCBO.Não)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Cep.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Fone.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Inscricao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Obs.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.Cliente.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", PegaVlrCombo(Me.cMun, TpRetornoCBO.Não)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.Nro.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", PegaVlrCombo(Me.cUF, TpRetornoCBO.Sim)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.Roteiro.Text, 1)))
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Editou, Me.Id.Text)
                Ação.Desbloquear_Controle(Me, False)
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            CNN.Close()
            EncherLista()
        End If

    End Sub

    Public Sub EncherLista()

        MyLista.Items.Clear()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        Cnn.Open()


        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM Propriedades WHERE Cliente = " & Me.Cliente.Text & " and Inativo = False"
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader


            While DataReader.Read
                If Not IsDBNull(DataReader.Item("id")) Then
                    Dim AA As String = DataReader.Item("id")
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("NomePropriedade") & "")
                    item1.SubItems.Add(DataReader.Item("Fone") & "")
                    item1.SubItems.Add(DataReader.Item("Inscricao") & "")

                    Me.MyLista.Items.AddRange(New ListViewItem() {item1})
                End If
            End While

            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub MyLista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyLista.DoubleClick
        Me.cMun.SelectedIndex = -1
        Me.cUF.SelectedIndex = -1

        
        Dim VLRprocura As String = ""
        Dim I As Integer
        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then VLRprocura = MyLista.Items(I).Text.Substring(0)
        Next

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        'Cria uma sql para selecionar todas as propriedades do cliente, filtradas pela vareável VLRprocura.
        Dim Sql As String = "SELECT Propriedades.*, UF.NomeUF, Municipio.NomeMunic, Propriedades.Id AS cod" _
& " FROM (Propriedades LEFT JOIN Municipio ON Propriedades.cMun = Municipio.CodMunicipio) LEFT JOIN UF ON Propriedades.cUf = UF.CodigoUF" _
& " WHERE (((Propriedades.Id)=" & VLRprocura & "))"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        Me.Id.Text = DR.Item("Cod") & ""
        Me.NomePropriedade.Text = DR.Item("NomePropriedade") & ""
        Me.Endereço.Text = DR.Item("Endereco") & ""
        Me.Cidade.Text = DR.Item("Cidade")
        Me.cUF.SelectedIndex = Me.cUF.FindStringExact(DR.Item("NomeUf") & "")
        MUNICIPIO_Preencher(Me.cUF, Me.cMun)
        Me.cMun.SelectedIndex = Me.cMun.FindStringExact(DR.Item("NomeMunic") & "")
        Me.Cep.Text = DR.Item("Cep") & ""
        Me.Fone.Text = DR.Item("Fone") & ""
        Me.Inscricao.Text = DR.Item("Inscricao") & ""
        Me.Obs.Text = DR.Item("Obs") & ""
        Me.Nro.Text = DR.Item("Nro") & ""
        Me.Roteiro.Text = DR.Item("Roteiro") & ""


        Operation = UPD
        Ação.Desbloquear_Controle(Me, True)
        DR.Close()

    End Sub


    Private Sub btInativar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btInativar.Click
        If Me.Id.Text = "" Then
            Exit Sub
        End If

        If MsgBox("Deseja realmente inativar esta propriedade", 36, "Validação de Dados") = 6 Then

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

            CNN.Open()

            Dim Sql As String = "Update Propriedades set Inativo = @1 Where id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", True))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro inativado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Inativou, Me.Id.Text)
                Ação.Desbloquear_Controle(Me, False)

            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            CNN.Close()
            EncherLista()
        End If

    End Sub

    Private Sub cUF_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cUF.Leave
        If String.CompareOrdinal(cUF.OldValue, cUF.Text) = 1 Then
            cMun.Text = ""
            MUNICIPIO_Preencher(Me.cUF, Me.cMun)
        Else
            MUNICIPIO_Preencher(Me.cUF, Me.cMun)
        End If
    End Sub

    Private Sub cMun_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cMun.Enter
        If String.CompareOrdinal(cMun.Text, cMun.OldValue) Then
            Me.cMun.Text = ""
        Else
            MUNICIPIO_Preencher(Me.cUF, Me.cMun)
        End If
    End Sub

    Private Sub cMun_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cMun.Leave
        If Me.Cidade.Text = String.Empty Then
            Me.Cidade.Text = Me.cMun.Text
        Else
            Me.Cidade.Text = Me.cMun.Text
        End If
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
End Class