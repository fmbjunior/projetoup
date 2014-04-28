Public Class FolhaPgtoFeriasAddEdd

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Periodo2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Periodo2.Enter
        If Me.Periodo1.Text <> "" Then
            Me.Periodo2.Text = Microsoft.VisualBasic.Day(Me.Periodo1.Text) & "/" & Month(Me.Periodo1.Text) & "/" & (Year(Me.Periodo1.Text) + 1)
            Me.DiasTotal.Text = 30
        End If
    End Sub

    Private Sub FolhaPgtoFeriasAddEdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()
        If My.Forms.FolhaPgtoFeriasVisualizador.Edição = False Then
            Operation = INS
        Else
            Operation = UPD

            Dim I As Integer = 0

            For I = 0 To My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items.Count - 1
                If My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).Selected = True Then Me.Id.Text = My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).Text.Substring(0)
                If My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).Selected = True Then Me.Periodo1.Text = My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).SubItems(1).Text.Substring(0)
                If My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).Selected = True Then Me.Periodo2.Text = My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).SubItems(2).Text.Substring(0)
                If My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).Selected = True Then Me.DiasTotal.Text = My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).SubItems(3).Text.Substring(0)
                If My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).Selected = True Then Me.DiasGozo.Text = My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).SubItems(4).Text.Substring(0)
                If My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).Selected = True Then Me.DataInicial.Text = My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).SubItems(5).Text.Substring(0)
                If My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).Selected = True Then Me.DataFinal.Text = My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).SubItems(6).Text.Substring(0)
                If My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).Selected = True Then Me.SalarioReg.Text = My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).SubItems(7).Text.Substring(0)
                If My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).Selected = True Then Me.SalarioDif.Text = My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).SubItems(8).Text.Substring(0)
                If My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).Selected = True Then Me.Variaveis.Text = My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).SubItems(9).Text.Substring(0)
                If My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).Selected = True Then Me.ValorFerias.Text = My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).SubItems(10).Text.Substring(0)
                If My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).Selected = True Then Me.ValorInss.Text = My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).SubItems(11).Text.Substring(0)
                If My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).Selected = True Then Me.ValorLiquido.Text = My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).SubItems(12).Text.Substring(0)
                If My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).Selected = True Then Me.txtVale.Text = My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).SubItems(13).Text.Substring(0)
                If My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).Selected = True Then Me.Pago.Text = My.Forms.FolhaPgtoFeriasVisualizador.MyLista.Items(I).SubItems(14).Text.Substring(0)
            Next

        End If
    End Sub

    Private Sub Salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salvar.Click
        If Me.Pago.Text <> "Sim" Then

            If Me.DiasGozo.Text = "" Then Me.DiasGozo.Text = 0
            If Me.SalarioReg.Text = "" Then Me.SalarioReg.Text = FormatNumber(0, 2)
            If Me.SalarioDif.Text = "" Then Me.SalarioDif.Text = FormatNumber(0, 2)
            If Me.Variaveis.Text = "" Then Me.Variaveis.Text = FormatNumber(0, 2)
            If Me.ValorFerias.Text = "" Then Me.ValorFerias.Text = FormatNumber(0, 2)
            If Me.ValorInss.Text = "" Then Me.ValorInss.Text = FormatNumber(0, 2)
            If Me.txtVale.Text = "" Then Me.txtVale.Text = FormatNumber(0, 2)


            If Me.DiasGozo.Text = 0 Then
                Me.Pago.Text = "NÃO"
            End If

            If Me.DiasGozo.Text > 0 Then
                Me.SalarioReg.Text = FormatNumber(My.Forms.FolhaPgtoFeriasVisualizador.SalarioReg.Text, 2)
                Me.SalarioDif.Text = FormatNumber(My.Forms.FolhaPgtoFeriasVisualizador.SalarioDif.Text, 2)

                Dim TotalCalc As Double
                Dim Total_Dia As Double

                TotalCalc = CDbl(Me.Variaveis.Text) + CDbl(Me.SalarioReg.Text) + CDbl(Me.SalarioDif.Text)
                Total_Dia = TotalCalc / 30
                Me.ValorFerias.Text = FormatNumber(CDbl((Total_Dia * Me.DiasGozo.Text)) + CDbl(((Total_Dia * Me.DiasGozo.Text) / 3)), 2)
                Me.Pago.Text = "PMR"
                CalculaInss()

                If Me.DataInicial.Text = "" Then
                    MsgBox("O usuário esta definindo Férias para este Funcionário, é necessario infomar a data inicial das Férias.", 64, "Validação de Dados")
                    Me.DataInicial.Focus()
                    Exit Sub
                End If

                If Me.DataFinal.Text = "" Then
                    MsgBox("O usuário esta definindo Férias para este Funcionário, é necessario infomar a data final das Férias.", 64, "Validação de Dados")
                    Me.DataInicial.Focus()
                    Exit Sub
                End If

            End If


            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

            If Operation = INS Then
                CNN.Open()

                UltimoReg()
                Dim Sql As String = "INSERT INTO FolhaPgtoFerias (Id, Funcionario, Periodo1, Periodo2, DiasTotal, DiasGozo, DataInicial, DataFinal, SalarioReg, SalarioDif, Variaveis, ValorFerias, ValorInss, Pago, Empresa, ValorLiquido, Vale) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17)"
                Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Id.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(My.Forms.FolhaPgtoFeriasVisualizador.Funcionario.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Periodo1.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Periodo2.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.DiasTotal.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.DiasGozo.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.DataInicial.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.DataFinal.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.SalarioReg.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.SalarioDif.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Variaveis.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.ValorFerias.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.ValorInss.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.Pago.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@15", CodEmpresa))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.ValorLiquido.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.txtVale.Text, 1)))
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                    CNN.Close()

                    Ação.Desbloquear_Controle(Me, False)
                Catch ex As Exception
                    MsgBox(ex.Message, 64, "Validação de Dados")
                    CNN.Close()
                End Try




            ElseIf Operation = UPD Then
                CNN.Open()

                Dim Sql As String = "Update FolhaPgtoFerias set Id = @1, Funcionario = @2, Periodo1 = @3, Periodo2 = @4, DiasTotal = @5, DiasGozo = @6, DataInicial = @7, DataFinal = @8, SalarioReg = @9, SalarioDif = @10, Variaveis = @11, ValorFerias = @12, ValorInss = @13, Pago = @14, Empresa = @15, ValorLiquido = @16, Vale = @17 Where Id = " & Me.Id.Text
                Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Id.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(My.Forms.FolhaPgtoFeriasVisualizador.Funcionario.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Periodo1.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.Periodo2.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.DiasTotal.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.DiasGozo.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.DataInicial.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.DataFinal.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.SalarioReg.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.SalarioDif.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Me.Variaveis.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.ValorFerias.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.ValorInss.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.Pago.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@15", CodEmpresa))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.ValorLiquido.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.txtVale.Text, 1)))

                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                    CNN.Close()
                    My.Forms.FolhaPgtoFeriasVisualizador.EncheLista()
                    Ação.Desbloquear_Controle(Me, False)
                Catch x As Exception
                    MsgBox(x.Message)
                    CNN.Close()

                End Try


            End If

            My.Forms.FolhaPgtoFeriasVisualizador.EncheLista()
            Me.Close()
            Me.Dispose()
        End If
       
    End Sub

    Private Sub DiasGozo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DiasGozo.Leave
        If Me.Pago.Text <> "Sim" Then
            If Me.DiasGozo.Text > 0 Then
                Me.SalarioReg.Text = FormatNumber(My.Forms.FolhaPgtoFeriasVisualizador.SalarioReg.Text, 2)
                Me.SalarioDif.Text = FormatNumber(My.Forms.FolhaPgtoFeriasVisualizador.SalarioDif.Text, 2)
            End If
            If Me.DiasGozo.Text = 0 Then
                Me.Pago.Text = "NÃO"
            End If
        End If


    End Sub

    Private Sub Variaveis_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Variaveis.Enter
        If Me.Variaveis.Text = "" Then Me.Variaveis.Text = FormatNumber(0, 2)
    End Sub

    Private Sub Variaveis_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Variaveis.Leave

        If Me.Pago.Text <> "Sim" Then
            If Me.DiasGozo.Text > 0 Then
                Dim TotalCalc As Double
                Dim Total_Dia As Double

                TotalCalc = CDbl(Me.Variaveis.Text) + CDbl(Me.SalarioReg.Text) + CDbl(Me.SalarioDif.Text)
                Total_Dia = TotalCalc / 30
                Me.ValorFerias.Text = FormatNumber(CDbl((Total_Dia * Me.DiasGozo.Text)) + CDbl(((Total_Dia * Me.DiasGozo.Text) / 3)), 2)
                Me.Pago.Text = "PMR"
                CalculaInss()

            End If
        End If

    End Sub

    Public Sub CalculaInss()

        If Me.DiasGozo.Text = 0 Then Exit Sub

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "Select * from FolhaPgtoTributos where Competencia = '" & MesAnoCompetencia & "'"
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Dim SalarioREG1Terço As Double = (Me.SalarioReg.Text / 30)
            SalarioREG1Terço = (SalarioREG1Terço * Me.DiasGozo.Text)

            If SalarioREG1Terço <= DR.Item("ValorFaixa1") Then
                Me.ValorInss.Text = FormatNumber(((((Me.SalarioReg.Text / 30) * Me.DiasGozo.Text) + (((Me.SalarioReg.Text / 30) * Me.DiasGozo.Text) / 3)) * DR.Item("PercFaixa1")) / 100, 2)
            End If

            If SalarioREG1Terço > DR.Item("ValorFaixa1") And SalarioREG1Terço <= DR.Item("ValorFaixa2") Then
                Me.ValorInss.Text = FormatNumber(((((Me.SalarioReg.Text / 30) * Me.DiasGozo.Text) + (((Me.SalarioReg.Text / 30) * Me.DiasGozo.Text) / 3)) * DR.Item("PercFaixa2")) / 100, 2)
            End If

            If SalarioREG1Terço > DR.Item("ValorFaixa2") And SalarioREG1Terço <= DR.Item("ValorFaixa3") Then
                Me.ValorInss.Text = FormatNumber(((((Me.SalarioReg.Text / 30) * Me.DiasGozo.Text) + (((Me.SalarioReg.Text / 30) * Me.DiasGozo.Text) / 3)) * DR.Item("PercFaixa3")) / 100, 2)
            End If

            If SalarioREG1Terço > DR.Item("ValorFaixa3") And SalarioREG1Terço <= DR.Item("ValorFaixa4") Then
                Me.ValorInss.Text = FormatNumber(((((Me.SalarioReg.Text / 30) * Me.DiasGozo.Text) + (((Me.SalarioReg.Text / 30) * Me.DiasGozo.Text) / 3)) * DR.Item("PercFaixa4")) / 100, 2)
            End If

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
            .CommandText = "Select max(Id) from FolhaPgtoFerias"
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
        'fim inserir ultimo registro

    End Sub

    Private Sub DataInicial_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataInicial.Leave
        If Me.DataInicial.Text <> "" Then
            Dim DtFinal As Date = CDate(Me.DataInicial.Text)
            Me.DataFinal.Text = DtFinal.AddDays(Me.DiasGozo.Text)
        End If
    End Sub

    Private Sub Degrade()
        Try
            Dim CCor() As String
            Dim corTemp As String

            corTemp = Cor1TelaSecundaria
            CCor = corTemp.Split(";")
            Me.Vale.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))

            corTemp = Cor2TelaSecundaria
            CCor = corTemp.Split(";")
            Me.Vale.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ValorLiquido_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorLiquido.Enter
        If Me.ValorLiquido.Text = "" Then Me.ValorLiquido.Text = FormatNumber(0, 2)

        Me.ValorLiquido.Text = FormatNumber(CDbl((Me.ValorFerias.Text)) - CDbl(Me.ValorInss.Text) - CDbl(Me.txtVale.Text), 2)

    End Sub



    Private Sub txtVale_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVale.Enter
        If Me.txtVale.Text = "" Then Me.txtVale.Text = FormatNumber(0, 2)

    End Sub


End Class