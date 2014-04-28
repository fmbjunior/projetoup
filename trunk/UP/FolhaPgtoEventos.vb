Public Class FolhaPgtoEventos

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2
    Private Sub NovoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click
        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)
        Me.CodigoEvento.Text = "0000"
        Me.SalarioFamilia.Checked = False
        Me.Inss.Checked = False
        Me.SalarioRegistro.Checked = False
        Me.SalarioDiferenca.Checked = False
        Me.CodigoEvento.Focus()
        Operation = INS
    End Sub

    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub EditarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBT.Click
        If Me.CodigoEvento.Text = "" Then
            MsgBox("Não existe Evento para ser editado.", 64, "Validação de Dados")
            Exit Sub
        End If
        Operation = UPD
        Ação.Desbloquear_Controle(Me, True)
        Me.CodigoEvento.Focus()
    End Sub

    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click
        'Area destinada para as validacoes
        If Me.Descrição.Text = "" Then
            MsgBox("A Descrição não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Descrição.Focus()
            Exit Sub
        ElseIf Me.Indicador.Text = "" Then
            MsgBox("O Indicador não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Indicador.Focus()
            Exit Sub
        ElseIf Me.Debito.Text = "" Then
            MsgBox("A conta de Débito não foi informado,ou Informar zero, favor verificar.", 64, "Validação de Dados")
            Me.Debito.Focus()
            Exit Sub
        ElseIf Me.Credito.Text = "" Then
            MsgBox("A conta de Crédito não foi informado,ou Informar zero, favor verificar.", 64, "Validação de Dados")
            Me.Credito.Focus()
            Exit Sub
        End If
        If Me.SomenteEvento.Text = "" Then
            MsgBox("O usuário deve informar o campo somente evento, S-Sim N-Não", 64, "Validação de Dados")
            Me.SomenteEvento.Focus()
        End If

        If Me.SomenteEvento.Text = "N" Then
            If Me.CalculoSobre.Text = "" Then
                MsgBox("O usuário deve definir sobre qual valor o calculo será efetuado.", 64, "Validação de Dados")
                Exit Sub
            End If
        End If

        If Len(Me.Debito.Text) < 14 Then
            MsgBox("A conta de Débito deve possuir 14 digitos")
            Me.Debito.Focus()
            Exit Sub
        End If
        If Len(Me.Credito.Text) < 14 Then
            MsgBox("A conta de Crédito deve possuir 14 digitos")
            Me.Credito.Focus()
            Exit Sub
        End If

        If Me.SomenteEvento.Text = "N" Then
            If Me.Debito.Text = Me.Credito.Text Then
                MsgBox("A conta de Débito não pode ser igual a conta de Crédito, Verifique.", 64, "Validação de Dados")
                Me.Debito.Focus()
                Exit Sub
            End If
        End If

        If Me.Debito.Text <> "00000000000000" Then
            If Direita(Me.Debito.Text, 6) = "000000" Then
                MsgBox("Conta de Débito não permitida para lançamento", 64, "Validação de Dados")
                Me.Debito.Clear()
                Me.Debito.Focus()
                Exit Sub
            End If
        End If

        If Me.Credito.Text <> "00000000000000" Then
            If Direita(Me.Credito.Text, 6) = "000000" Then
                MsgBox("Conta de Crédito não permitida para lançamento", 64, "Validação de Dados")
                Me.Credito.Clear()
                Me.Credito.Focus()
                Exit Sub
            End If
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            UltimoReg()
            Dim Sql As String = "INSERT INTO FolhaPgtoEventos (CodigoEvento, Descrição, Indicador, Inss, SalarioFamilia, Perc_Valor, VlrBase, Debito, Credito, Empresa, CalculoSobre, SomenteEvento) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)


            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CodigoEvento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Descrição.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Indicador.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Me.Inss.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Me.SalarioFamilia.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Perc_Valor.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.VlrBase.Text, 1)))

            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Debito.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Credito.Text, 1)))

            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.CalculoSobre.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.SomenteEvento.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            Ação.Desbloquear_Controle(Me, False)
            CNN.Close()

        ElseIf Operation = UPD Then
            CNN.Open()

            Dim Sql As String = "Update FolhaPgtoEventos set CodigoEvento = @1, Descrição = @2, Indicador = @3, Inss = @4, SalarioFamilia = @5, Perc_Valor = @6, VlrBase = @7, Debito = @8, Credito = @9, Empresa = @10, CalculoSobre = @11, SomenteEvento = @12 Where CodigoEvento = " & Me.CodigoEvento.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.CodigoEvento.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Descrição.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Indicador.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Me.Inss.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Me.SalarioFamilia.Checked))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Perc_Valor.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.VlrBase.Text, 1)))

            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.Debito.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Credito.Text, 1)))

            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.CalculoSobre.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.SomenteEvento.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            Ação.Desbloquear_Controle(Me, False)
            CNN.Close()
        End If

    End Sub

    Private Sub FolhaPgtoEventos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()
        Ação.Desbloquear_Controle(Me, False)
    End Sub

    Private Sub LocalizarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizarBT.Click
        Ação.Desbloquear_Controle(Me, False)
        ChamaTelaProcura("Codigo", "Descricão", "", "FolhaPgtoEventos", "CodigoEvento", "Descrição", "", True)

        Me.CodigoEvento.Text = RetornoProcura
        If Me.CodigoEvento.Text <> "" Then
            LocalizaDados()
            Me.CodigoEvento.Focus()
        End If

    End Sub

    Public Sub LocalizaDados()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from FolhaPgtoEventos where CodigoEvento = " & Me.CodigoEvento.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.CodigoEvento.Text = DR.Item("CodigoEvento") & ""
            Me.Descrição.Text = DR.Item("Descrição") & ""
            Me.Indicador.Text = DR.Item("Indicador") & ""
            Me.Inss.Checked = DR.Item("INSS")
            Me.SalarioFamilia.Checked = DR.Item("SalarioFamilia")
            Me.Perc_Valor.Text = DR.Item("Perc_Valor") & ""
            Me.VlrBase.Text = DR.Item("VlrBase") & ""
            Me.Debito.Text = DR.Item("Debito") & ""
            Me.Credito.Text = DR.Item("Credito") & ""
            Me.SomenteEvento.Text = DR.Item("SomenteEvento") & ""

            Operation = UPD
        End If
        DR.Close()

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
            .CommandText = "Select max(CodigoEvento) from FolhaPgtoEventos"
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

        Me.CodigoEvento.Text = Ult + 1
        Me.Descrição.Focus()
        'fim inserir ultimo registro

    End Sub

  

    Private Sub SalarioRegistro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalarioRegistro.CheckedChanged, SalarioDiferenca.CheckedChanged
        If Me.SalarioRegistro.Checked = True Then
            Me.CalculoSobre.Text = "REG"
        End If
        If Me.SalarioDiferenca.Checked = True Then
            Me.CalculoSobre.Text = "DIF"
        End If
    End Sub

    Private Sub Inss_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Inss.CheckedChanged, SalarioFamilia.CheckedChanged
        Me.CalculoSobre.Text = "REG"
        Me.SalarioRegistro.Checked = True
    End Sub

    Private Sub SomenteEvento_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles SomenteEvento.Validated
        If Me.SomenteEvento.Text = "S" Then
            Me.SalarioFamilia.Checked = False
            Me.Inss.Checked = False
            Me.SalarioRegistro.Checked = False
            Me.SalarioDiferenca.Checked = False

            Me.SalarioFamilia.Enabled = False
            Me.Inss.Enabled = False
            Me.SalarioRegistro.Enabled = False
            Me.SalarioDiferenca.Enabled = False
            Me.Indicador.Enabled = False
            Me.Indicador.Text = "D"
            Me.Perc_Valor.Enabled = False
            Me.Perc_Valor.Text = "P"
            Me.VlrBase.Enabled = False
            Me.VlrBase.Text = 100
        Else
            Me.SalarioFamilia.Enabled = True
            Me.Inss.Enabled = True
            Me.SalarioRegistro.Enabled = True
            Me.SalarioDiferenca.Enabled = True
            Me.Indicador.Enabled = True
            Me.Perc_Valor.Enabled = True
            Me.VlrBase.Enabled = True
        End If
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