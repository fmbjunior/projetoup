Public Class FolhaPgtoGerador

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub TipoGeradorBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoGeradorBT.Click
        Dim X As New Point(27, 0)
        Me.MenuTipoGerador.Show(Me.TipoGeradorBT, X)
    End Sub

    Private Sub MensalDiaristaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MensalDiaristaToolStripMenuItem.Click, DécimoTerceiroToolStripMenuItem.Click, FériasToolStripMenuItem.Click, PgtoPISToolStripMenuItem.Click, RecisãoToolStripMenuItem.Click, PISToolStripMenuItem.Click, ValeQuinzenalToolStripMenuItem.Click
        Me.Modulo.Text = sender.ToString
    End Sub

    Private Sub Funcionario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Funcionario.KeyDown
        If e.KeyCode = Keys.F5 Then
            ChamaTelaProcura("Codigo", "Nome", "", "Funcionários", "CódigoFuncionário", "Nome", "", True)
            Me.Funcionario.Text = RetornoProcura
        End If
    End Sub

    Public Sub LocalizaDadosFuncionario()
        If Me.Funcionario.Text = "" Then Exit Sub

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "Select * from Funcionários where CódigoFuncionário = " & Me.Funcionario.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then

            Me.FuncionarioDesc.Text = DR.Item("Nome") & ""

            If Not IsDBNull(DR.Item("Foto")) Then
                Dim ByteData() As Byte = DR.Item("Foto") 'stream em memória recebe a imagem
                Dim ImgVer As New IO.MemoryStream(ByteData)
                Me.Display.Visible = True
                Me.Display.Image = Image.FromStream(ImgVer)
            Else
                Me.Display.Image = Me.SemFoto.Image
            End If
        End If

        DR.Close()
        Cnn.Close()

    End Sub

    Private Sub Individual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Individual.CheckedChanged
        Me.PainelFuncionario.Visible = True
        Me.Funcionario.Focus()
    End Sub

    Private Sub Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Todos.CheckedChanged
        Me.PainelFuncionario.Visible = False
        Me.Funcionario.Focus()
    End Sub

    Private Sub Funcionario_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Funcionario.Validated
        If Me.Funcionario.Text <> "" Then
            LocalizaDadosFuncionario()
            Me.Funcionario.Focus()
        End If
    End Sub

#Region "Geradores da Folha de Pagamento"

    Private Sub GerarMensalistas()

        If Me.Modulo.Text = "" Then
            MsgBox("O usuário deve escolher o modulo para gerar a folha", 64, "Validação de Dados")
            Exit Sub
        End If
        If Me.MensalCompetencia.Text = "" Then
            MsgBox("O usuário deve informar o mês e ano de competência para gerar a folha.", 64, "Validação de Dados")
        End If

        AtDepententesSalarioFamilia()
        AcharValesFuncionarios()
        Dim UltimoReg As Integer = UltimoRegistro()

        Dim Sql As String = ""
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        If Me.Individual.Checked = False Then
            Sql = "SELECT Funcionários.*, Funcionários.Nome, Funcionários.DataRecisao, Funcionários.Inativo, Funcionários.Empresa FROM Funcionários WHERE Funcionários.Nome Is Not Null AND Funcionários.DataRecisao Is Null AND Funcionários.Inativo = False And GeraMovimentoFolha = 'S' AND Funcionários.Empresa = " & CodEmpresa
        Else
            Sql = "SELECT Funcionários.*, Funcionários.Nome, Funcionários.DataRecisao, Funcionários.Inativo, Funcionários.Empresa FROM Funcionários WHERE Funcionários.Nome Is Not Null AND Funcionários.DataRecisao Is Null AND Funcionários.Inativo = False And GeraMovimentoFolha = 'S' AND Funcionários.Empresa = " & CodEmpresa & " and CódigoFuncionário = " & Me.Funcionario.Text
        End If
        Dim DAFuncionarios As New OleDb.OleDbDataAdapter(Sql, CNN)

        Sql = "SELECT FolhaPgtoModulosEventos.ID, FolhaPgtoModulosEventos.Modulo, FolhaPgtoModulosEventos.CodigoEvento FROM(FolhaPgtoModulosEventos) WHERE (((FolhaPgtoModulosEventos.Modulo)= '" & Me.Modulo.Text & "'));"
        Dim DAEventosModulo As New OleDb.OleDbDataAdapter(Sql, CNN)

        Sql = "Select * from FolhaPgto where Competencia = '" & Me.MensalCompetencia.Text & "' and Modulo = '" & Me.Modulo.Text & "'"
        Dim DAFolhaPgto As New OleDb.OleDbDataAdapter(Sql, CNN)

        Sql = "Select * from FolhaPgtoEventos"
        Dim DAEventos As New OleDb.OleDbDataAdapter(Sql, CNN)

        Sql = "Select * from FolhaPgtoTributos Where Competencia = '" & Me.MensalCompetencia.Text & "'"
        Dim DATributos As New OleDb.OleDbDataAdapter(Sql, CNN)

        Sql = "Select * from FolhaPgtoGerado Where Competencia = '" & Me.MensalCompetencia.Text & "' and Modulo = '" & Me.Modulo.Text & "'"
        Dim DAJaFoiGerado As New OleDb.OleDbDataAdapter(Sql, CNN)

        Dim DS As New DataSet

        DAFuncionarios.Fill(DS, "Funcionarios")
        DAEventosModulo.Fill(DS, "EventosNoModulo")
        DAFolhaPgto.Fill(DS, "FolhaPgto")
        DAEventos.Fill(DS, "Eventos")
        DATributos.Fill(DS, "Tributos")
        DAJaFoiGerado.Fill(DS, "Gerado")

        'Verifica se ja foi gerado ou nao 

        Dim LinhasGerado As Integer = DS.Tables("Gerado").Rows.Count
        If LinhasGerado = 1 Then
            MsgBox("Ja foi gerado o Vale Quinzenal na Folha de Pagamento na competência informada.", 64, "Validação de Dados")
            DS.Dispose()
            CNN.Close()
            Me.Close()
            Me.Dispose()
            Exit Sub
        End If
        'fim

        'seleciona o tributo
        Dim TributoLinha() As DataRow
        TributoLinha = DS.Tables("Tributos").Select("Competencia = '" & Me.MensalCompetencia.Text & "'")


        Dim TotalLinhas As Integer = DS.Tables("Funcionarios").Rows.Count
        'Atualiza a barra de Progresso
        If TotalLinhas = 0 Then TotalLinhas = 1
        MyBarra.Visible = True
        MyBarra.Minimum = 1
        MyBarra.Maximum = TotalLinhas
        MyBarra.Value = 1
        MyBarra.Step = 1
        Me.Msg.Visible = True
        Me.Msg.Text = "Gerando Folha de Pagamento de Funcionário"
        Me.Msg.Refresh()


        Dim DrFuncionarios As DataRow
        For Each DrFuncionarios In DS.Tables("Funcionarios").Rows
            If Not IsDBNull(DrFuncionarios("Foto")) Then
                Dim ByteData() As Byte = DrFuncionarios("Foto")
                Dim ImgVer As New IO.MemoryStream(ByteData)
                Me.Display.Visible = True
                Me.Display.Image = Image.FromStream(ImgVer)
            Else
                Me.Display.Image = Me.SemFoto.Image
            End If
            Me.FuncionarioDesc.Text = (DrFuncionarios("Funcionários.Nome").ToString())
            Me.Display.Refresh()
            Me.FuncionarioDesc.Refresh()

            System.Threading.Thread.Sleep(200)

            Dim drEventosNoModulo As DataRow
            For Each drEventosNoModulo In DS.Tables("EventosNoModulo").Rows


                Dim EventoLinha() As DataRow
                EventoLinha = DS.Tables("Eventos").Select("CodigoEvento = " & drEventosNoModulo("CodigoEvento").ToString)

                Dim TBLfolhaPgto As DataTable
                TBLfolhaPgto = DS.Tables("FolhaPgto")
                ' Obtem um novo objeto DataRow do DataTable
                Dim DRnovo As DataRow
                DRnovo = TBLfolhaPgto.NewRow()
                DRnovo("Id") = UltimoReg
                DRnovo("Competencia") = Me.MensalCompetencia.Text
                DRnovo("Modulo") = Me.Modulo.Text
                DRnovo("Funcionario") = DrFuncionarios("CódigoFuncionário").ToString()
                DRnovo("Evento") = EventoLinha(0)("CodigoEvento")
                DRnovo("Historico") = EventoLinha(0)(1)
                DRnovo("Referencia") = 1
                DRnovo("Empresa") = CodEmpresa
                DRnovo("Confirmado") = False
                DRnovo("Usuario") = UserAtivo
                DRnovo("Protegido") = "N"

                If EventoLinha(0)("Debito") = "00000000000000" Then
                    DRnovo("ContaDebito") = NzVlr(DrFuncionarios("CodPlanoContas").ToString())
                Else
                    DRnovo("ContaDebito") = NzVlr(EventoLinha(0)("Debito"))
                End If

                If EventoLinha(0)("Credito") = "00000000000000" Then
                    DRnovo("ContaCredito") = NzVlr(DrFuncionarios("CodPlanoContas").ToString())
                Else
                    DRnovo("ContaCredito") = NzVlr(EventoLinha(0)("Credito"))
                End If

                Dim VarTpCalc As String = EventoLinha(0)("CalculoSobre") & "+" & EventoLinha(0)("Perc_Valor") & "+" & EventoLinha(0)("Indicador")
                '(REG+V+C - REG+V+D) (REG+P+C - REG+P+D) (DIF+V+C - DIF+V+D) (DIF+P+C - DIF+P+D)
                If EventoLinha(0)("SalarioFamilia") = True Then VarTpCalc = "SalarioFamilia"
                If EventoLinha(0)("Inss") = True Then VarTpCalc = "Inss"

                If VarTpCalc = "SalarioFamilia" Then
                    DRnovo("Referencia") = CDbl(NzVlr(DrFuncionarios("QtdDependentesSalarioFamilia").ToString()))
                    DRnovo("VlrDebito") = 0
                    If CDbl(NzVlr(DrFuncionarios("SalarioRegistro").ToString())) <= CDbl(NzVlr(TributoLinha(0)("SalarioFamiliaMaior"))) Then
                        DRnovo("VlrCredito") = CDbl(TributoLinha(0)("ValorSalarioFamiliaMaior")) * CDbl(NzVlr(DrFuncionarios("QtdDependentesSalarioFamilia").ToString()))
                    End If

                    If CDbl(NzVlr(DrFuncionarios("SalarioRegistro").ToString())) > CDbl(NzVlr(TributoLinha(0)("SalarioFamiliaMaior"))) And CDbl(NzVlr(DrFuncionarios("SalarioRegistro").ToString())) <= CDbl(NzVlr(TributoLinha(0)("SalarioFamiliaMenor"))) Then
                        DRnovo("VlrCredito") = CDbl(NzVlr(TributoLinha(0)("ValorSalarioFamiliaMenor"))) * CDbl(NzVlr(DrFuncionarios("QtdDependentesSalarioFamilia").ToString()))
                    End If
                End If


                If VarTpCalc = "Inss" Then
                    If CDbl(NzVlr(DrFuncionarios("SalarioRegistro").ToString())) <= CDbl(NzVlr(TributoLinha(0)("ValorFaixa1"))) Then
                        DRnovo("Referencia") = 1
                        DRnovo("VlrDebito") = (CDbl(NzVlr(DrFuncionarios("SalarioRegistro").ToString()))) * CDbl(TributoLinha(0)("PercFaixa1")) / 100
                        DRnovo("VlrCredito") = 0
                    End If

                    If CDbl(NzVlr(DrFuncionarios("SalarioRegistro").ToString())) > CDbl(NzVlr(TributoLinha(0)("ValorFaixa1"))) And CDbl(NzVlr(DrFuncionarios("SalarioRegistro").ToString())) <= CDbl(NzVlr(TributoLinha(0)("ValorFaixa2"))) Then
                        DRnovo("Referencia") = 1
                        DRnovo("VlrDebito") = (CDbl(NzVlr(DrFuncionarios("SalarioRegistro").ToString())) * CDbl(TributoLinha(0)("PercFaixa2"))) / 100
                        DRnovo("VlrCredito") = 0
                    End If

                    If CDbl(NzVlr(DrFuncionarios("SalarioRegistro").ToString())) > CDbl(NzVlr(TributoLinha(0)("ValorFaixa2"))) And CDbl(NzVlr(DrFuncionarios("SalarioRegistro").ToString())) <= CDbl(NzVlr(TributoLinha(0)("ValorFaixa3"))) Then
                        DRnovo("Referencia") = 1
                        DRnovo("VlrDebito") = (CDbl(NzVlr(DrFuncionarios("SalarioRegistro").ToString())) * CDbl(TributoLinha(0)("PercFaixa3"))) / 100
                        DRnovo("VlrCredito") = 0
                    End If

                    If CDbl(NzVlr(DrFuncionarios("SalarioRegistro").ToString())) > CDbl(NzVlr(TributoLinha(0)("ValorFaixa3"))) And CDbl(NzVlr(DrFuncionarios("SalarioRegistro").ToString())) <= CDbl(NzVlr(TributoLinha(0)("ValorFaixa4"))) Then
                        DRnovo("Referencia") = 1
                        DRnovo("VlrDebito") = (CDbl(NzVlr(DrFuncionarios("SalarioRegistro").ToString())) * CDbl(TributoLinha(0)("PercFaixa4"))) / 100
                        DRnovo("VlrCredito") = 0
                    End If
                End If

                If VarTpCalc = "REG+V+C" Then
                    DRnovo("VlrDebito") = 0
                    DRnovo("VlrCredito") = NzVlr(EventoLinha(0)("VlrBase"))
                End If
                If VarTpCalc = "REG+V+D" Then
                    DRnovo("VlrDebito") = NzVlr(EventoLinha(0)("VlrBase"))
                    DRnovo("VlrCredito") = 0
                End If

                If VarTpCalc = "REG+P+C" Then
                    DRnovo("VlrDebito") = 0
                    DRnovo("VlrCredito") = CDbl(NzVlr(DrFuncionarios("SalarioRegistro").ToString())) * CDbl(EventoLinha(0)("VlrBase")) / 100
                End If
                If VarTpCalc = "REG+P+D" Then
                    DRnovo("VlrDebito") = CDbl(NzVlr(DrFuncionarios("SalarioRegistro").ToString())) * CDbl(EventoLinha(0)("VlrBase")) / 100
                    DRnovo("VlrCredito") = 0
                End If

                If VarTpCalc = "DIF+V+C" Then
                    DRnovo("VlrDebito") = 0
                    DRnovo("VlrCredito") = EventoLinha(0)("VlrBase")
                End If
                If VarTpCalc = "DIF+V+D" Then
                    DRnovo("VlrDebito") = EventoLinha(0)("VlrBase")
                    DRnovo("VlrCredito") = 0
                End If

                If VarTpCalc = "DIF+P+C" Then
                    DRnovo("VlrDebito") = 0
                    If (NzVlr(DrFuncionarios("Salario").ToString())) = 0 Then
                        DRnovo("VlrCredito") = 0
                    Else
                        DRnovo("VlrCredito") = CDbl(NzVlr(DrFuncionarios("Salario").ToString())) * CDbl(NzVlr(EventoLinha(0)("VlrBase"))) / 100
                    End If

                End If
                If VarTpCalc = "DIF+P+D" Then
                    If (NzVlr(DrFuncionarios("Salario").ToString())) = 0 Then
                        DRnovo("VlrDebito") = 0
                    Else
                        DRnovo("VlrDebito") = CDbl(Nz(DrFuncionarios("Salario").ToString(), 3)) * CDbl(Nz(EventoLinha(0)("VlrBase"), 3)) / 100
                    End If
                    DRnovo("VlrCredito") = 0
                End If

                TBLfolhaPgto.Rows.Add(DRnovo)
                UltimoReg += 1

                If CDbl(NzZero(DRnovo("VlrCredito"))) = CDbl(0) And CDbl(NzZero(DRnovo("VlrDebito"))) = CDbl(0) Then
                    TBLfolhaPgto.Rows.Remove(DRnovo)
                    UltimoReg -= 1
                End If
                'If EventoLinha(0)("SalarioFamilia") = True And CDbl(NzVlr(DrFuncionarios("QtdDependentesSalarioFamilia").ToString(), 0)) = 0 Then
                '    TBLfolhaPgto.Rows.Remove(DRnovo)
                'End If

            Next drEventosNoModulo
            MyBarra.PerformStep()
        Next DrFuncionarios

        Try
            Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAFolhaPgto)
            DAFolhaPgto.Update(DS, "FolhaPgto")

            Dim TBLGerado As DataTable
            TBLGerado = DS.Tables("Gerado")
            Dim DRnovo As DataRow
            DRnovo = TBLGerado.NewRow()
            DRnovo("Competencia") = Me.MensalCompetencia.Text
            DRnovo("Modulo") = Me.Modulo.Text
            DRnovo("Gerada") = True
            DRnovo("Empresa") = CodEmpresa
            TBLGerado.Rows.Add(DRnovo)
            Dim objCommandBuilder1 As New OleDb.OleDbCommandBuilder(DAJaFoiGerado)
            DAJaFoiGerado.Update(DS, "Gerado")

            CNN.Close()
            MsgBox("Folha de Pagamento gerada com sucesso.", 64, "Validação de Dados")
        Catch ex As Exception
            MsgBox("Ocorreram erros na geração da folha, o processo foi cancelado, verifique.", 64, "Validação de Dados")
            CNN.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub GerarFerias()

    End Sub

    Private Sub GerarRecisao()

    End Sub

    Private Sub GerarPgtoPis()

        If Me.Modulo.Text = "" Then
            MsgBox("O usuário deve escolher o modulo para gerar a folha", 64, "Validação de Dados")
            Exit Sub
        End If
        If Me.MensalCompetencia.Text = "" Then
            MsgBox("O usuário deve informar o mês e ano de competência para gerar a Pis.", 64, "Validação de Dados")
        End If

        AcharValesFuncionariosPis()
        Dim UltimoReg As Integer = UltimoRegistro()

        Dim Sql As String = ""
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        If Me.Individual.Checked = False Then
            Sql = "SELECT Funcionários.*, Funcionários.Nome, Funcionários.DataRecisao, Funcionários.Inativo, Funcionários.Empresa FROM Funcionários WHERE Funcionários.Nome Is Not Null AND Funcionários.DataRecisao Is Null AND Funcionários.Inativo = False And GeraMovimentoFolha = 'S' And ValorPis > 0 AND Funcionários.Empresa = " & CodEmpresa
        Else
            Sql = "SELECT Funcionários.*, Funcionários.Nome, Funcionários.DataRecisao, Funcionários.Inativo, Funcionários.Empresa FROM Funcionários WHERE Funcionários.Nome Is Not Null AND Funcionários.DataRecisao Is Null AND Funcionários.Inativo = False And GeraMovimentoFolha = 'S' And ValorPis > 0 AND Funcionários.Empresa = " & CodEmpresa & " and CódigoFuncionário = " & Me.Funcionario.Text
        End If
        Dim DAFuncionarios As New OleDb.OleDbDataAdapter(Sql, CNN)

        Sql = "SELECT FolhaPgtoModulosEventos.ID, FolhaPgtoModulosEventos.Modulo, FolhaPgtoModulosEventos.CodigoEvento FROM(FolhaPgtoModulosEventos) WHERE (((FolhaPgtoModulosEventos.Modulo)= '" & Me.Modulo.Text & "'));"
        Dim DAEventosModulo As New OleDb.OleDbDataAdapter(Sql, CNN)

        Sql = "Select * from FolhaPgto where Competencia = '" & Me.MensalCompetencia.Text & "' and Modulo = '" & Me.Modulo.Text & "'"
        Dim DAFolhaPgto As New OleDb.OleDbDataAdapter(Sql, CNN)

        Sql = "Select * from FolhaPgtoEventos"
        Dim DAEventos As New OleDb.OleDbDataAdapter(Sql, CNN)

        Sql = "Select * from FolhaPgtoTributos Where Competencia = '" & Me.MensalCompetencia.Text & "'"
        Dim DATributos As New OleDb.OleDbDataAdapter(Sql, CNN)

        Sql = "Select * from FolhaPgtoGerado Where Competencia = '" & Me.MensalCompetencia.Text & "' and Modulo = '" & Me.Modulo.Text & "'"
        Dim DAJaFoiGerado As New OleDb.OleDbDataAdapter(Sql, CNN)


        Dim DS As New DataSet

        DAFuncionarios.Fill(DS, "Funcionarios")
        DAEventosModulo.Fill(DS, "EventosNoModulo")
        DAFolhaPgto.Fill(DS, "FolhaPgto")
        DAEventos.Fill(DS, "Eventos")
        DATributos.Fill(DS, "Tributos")
        DAJaFoiGerado.Fill(DS, "Gerado")

        'Verifica se ja foi gerado ou nao 

        Dim LinhasGerado As Integer = DS.Tables("Gerado").Rows.Count
        If LinhasGerado = 1 Then
            MsgBox("Ja foi gerado o Pagamento do PIS na Folha de Pagamento na competência informada.", 64, "Validação de Dados")
            DS.Dispose()
            CNN.Close()
            Me.Close()
            Me.Dispose()
            Exit Sub
        End If
        'fim


        'seleciona o tributo
        Dim TributoLinha() As DataRow
        TributoLinha = DS.Tables("Tributos").Select("Competencia = '" & Me.MensalCompetencia.Text & "'")


        Dim TotalLinhas As Integer = DS.Tables("Funcionarios").Rows.Count
        'Atualiza a barra de Progresso
        If TotalLinhas = 0 Then TotalLinhas = 1
        MyBarra.Visible = True
        MyBarra.Minimum = 1
        MyBarra.Maximum = TotalLinhas
        MyBarra.Value = 1
        MyBarra.Step = 1
        Me.Msg.Visible = True
        Me.Msg.Text = "Gerando Pagamento de PIS"
        Me.Msg.Refresh()


        Dim DrFuncionarios As DataRow
        For Each DrFuncionarios In DS.Tables("Funcionarios").Rows
            If NzVlr(DrFuncionarios("ValorPis")) > 0 Then
                If Not IsDBNull(DrFuncionarios("Foto")) Then
                    Dim ByteData() As Byte = DrFuncionarios("Foto")
                    Dim ImgVer As New IO.MemoryStream(ByteData)
                    Me.Display.Visible = True
                    Me.Display.Image = Image.FromStream(ImgVer)
                Else
                    Me.Display.Image = Me.SemFoto.Image
                End If
                Me.FuncionarioDesc.Text = (DrFuncionarios("Funcionários.Nome").ToString())
                Me.Display.Refresh()
                Me.FuncionarioDesc.Refresh()

                System.Threading.Thread.Sleep(200)

                Dim drEventosNoModulo As DataRow
                For Each drEventosNoModulo In DS.Tables("EventosNoModulo").Rows


                    Dim EventoLinha() As DataRow
                    EventoLinha = DS.Tables("Eventos").Select("CodigoEvento = " & drEventosNoModulo("CodigoEvento").ToString)

                    Dim TBLfolhaPgto As DataTable
                    TBLfolhaPgto = DS.Tables("FolhaPgto")
                    ' Obtem um novo objeto DataRow do DataTable
                    Dim DRnovo As DataRow
                    DRnovo = TBLfolhaPgto.NewRow()
                    DRnovo("Id") = UltimoReg
                    DRnovo("Competencia") = Me.MensalCompetencia.Text
                    DRnovo("Modulo") = Me.Modulo.Text
                    DRnovo("Funcionario") = DrFuncionarios("CódigoFuncionário").ToString()
                    DRnovo("Evento") = EventoLinha(0)("CodigoEvento")
                    DRnovo("Historico") = EventoLinha(0)(1)
                    DRnovo("Referencia") = 1
                    DRnovo("Empresa") = CodEmpresa
                    DRnovo("Confirmado") = False
                    DRnovo("Usuario") = UserAtivo
                    DRnovo("Protegido") = "N"

                    If EventoLinha(0)("Debito") = "00000000000000" Then
                        DRnovo("ContaDebito") = NzVlr(DrFuncionarios("CodPlanoContas").ToString())
                    Else
                        DRnovo("ContaDebito") = NzVlr(EventoLinha(0)("Debito"))
                    End If

                    If EventoLinha(0)("Credito") = "00000000000000" Then
                        DRnovo("ContaCredito") = NzVlr(DrFuncionarios("CodPlanoContas").ToString())
                    Else
                        DRnovo("ContaCredito") = NzVlr(EventoLinha(0)("Credito"))
                    End If


                    DRnovo("VlrDebito") = 0
                    DRnovo("VlrCredito") = CDbl(NzVlr(DrFuncionarios("ValorPis").ToString()))


                    TBLfolhaPgto.Rows.Add(DRnovo)
                    UltimoReg += 1

                    If CDbl(NzVlr(DRnovo("VlrCredito"))) = CDbl(0) And CDbl(NzVlr(DRnovo("VlrDebito"))) = CDbl(0) Then
                        TBLfolhaPgto.Rows.Remove(DRnovo)
                        UltimoReg -= 1
                    End If

                Next drEventosNoModulo
            End If
            MyBarra.PerformStep()
        Next DrFuncionarios

        Try
            Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAFolhaPgto)
            DAFolhaPgto.Update(DS, "FolhaPgto")

            Dim TBLGerado As DataTable
            TBLGerado = DS.Tables("Gerado")
            Dim DRnovo As DataRow
            DRnovo = TBLGerado.NewRow()
            DRnovo("Competencia") = Me.MensalCompetencia.Text
            DRnovo("Modulo") = Me.Modulo.Text
            DRnovo("Gerada") = True
            DRnovo("Empresa") = CodEmpresa
            TBLGerado.Rows.Add(DRnovo)
            Dim objCommandBuilder1 As New OleDb.OleDbCommandBuilder(DAJaFoiGerado)
            DAJaFoiGerado.Update(DS, "Gerado")

            CNN.Close()
            MsgBox("Pagamento de PIS gerado com sucesso.", 64, "Validação de Dados")
        Catch ex As Exception
            MsgBox("Ocorreram erros na geração do Pagamento do PIS, o processo foi cancelado, verifique.", 64, "Validação de Dados")
            CNN.Close()
            Exit Sub
        End Try


    End Sub

    Private Sub GerarValeQuinzenal()
        If Me.Modulo.Text = "" Then
            MsgBox("O usuário deve escolher o modulo para gerar a folha", 64, "Validação de Dados")
            Exit Sub
        End If
        If Me.MensalCompetencia.Text = "" Then
            MsgBox("O usuário deve informar o mês e ano de competência para gerar a folha.", 64, "Validação de Dados")
        End If

        Dim UltimoReg As Integer = UltimoRegistro()

        Dim Sql As String = ""
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        If Me.Individual.Checked = False Then
            Sql = "SELECT Funcionários.*, Funcionários.Nome, Funcionários.DataRecisao, Funcionários.Inativo, Funcionários.Empresa FROM Funcionários WHERE Funcionários.Nome Is Not Null AND Funcionários.DataRecisao Is Null AND Funcionários.Inativo = False And GeraMovimentoFolha = 'S' And ValorVale is not null AND Funcionários.Empresa = " & CodEmpresa
        Else
            Sql = "SELECT Funcionários.*, Funcionários.Nome, Funcionários.DataRecisao, Funcionários.Inativo, Funcionários.Empresa FROM Funcionários WHERE Funcionários.Nome Is Not Null AND Funcionários.DataRecisao Is Null AND Funcionários.Inativo = False And GeraMovimentoFolha = 'S' And ValorVale is not null AND Funcionários.Empresa = " & CodEmpresa & " and CódigoFuncionário = " & Me.Funcionario.Text
        End If
        Dim DAFuncionarios As New OleDb.OleDbDataAdapter(Sql, CNN)

        Sql = "SELECT FolhaPgtoModulosEventos.ID, FolhaPgtoModulosEventos.Modulo, FolhaPgtoModulosEventos.CodigoEvento FROM(FolhaPgtoModulosEventos) WHERE (((FolhaPgtoModulosEventos.Modulo)= '" & Me.Modulo.Text & "'));"
        Dim DAEventosModulo As New OleDb.OleDbDataAdapter(Sql, CNN)

        Sql = "Select * from FolhaPgto where Competencia = '" & Me.MensalCompetencia.Text & "' and Modulo = '" & Me.Modulo.Text & "'"
        Dim DAFolhaPgto As New OleDb.OleDbDataAdapter(Sql, CNN)

        Sql = "Select * from FolhaPgtoEventos"
        Dim DAEventos As New OleDb.OleDbDataAdapter(Sql, CNN)

        Sql = "Select * from FolhaPgtoTributos Where Competencia = '" & Me.MensalCompetencia.Text & "'"
        Dim DATributos As New OleDb.OleDbDataAdapter(Sql, CNN)

        Sql = "Select * from FolhaPgtoGerado Where Competencia = '" & Me.MensalCompetencia.Text & "' and Modulo = '" & Me.Modulo.Text & "'"
        Dim DAJaFoiGerado As New OleDb.OleDbDataAdapter(Sql, CNN)


        Dim DS As New DataSet

        DAFuncionarios.Fill(DS, "Funcionarios")
        DAEventosModulo.Fill(DS, "EventosNoModulo")
        DAFolhaPgto.Fill(DS, "FolhaPgto")
        DAEventos.Fill(DS, "Eventos")
        DATributos.Fill(DS, "Tributos")
        DAJaFoiGerado.Fill(DS, "Gerado")

        'Verifica se ja foi gerado ou nao 

        Dim LinhasGerado As Integer = DS.Tables("Gerado").Rows.Count
        If LinhasGerado = 1 Then
            MsgBox("Ja foi gerado o Vale Quinzenal na Folha de Pagamento na competência informada.", 64, "Validação de Dados")
            DS.Dispose()
            CNN.Close()
            Me.Close()
            Me.Dispose()
            Exit Sub
        End If
        'fim


        'seleciona o tributo
        Dim TributoLinha() As DataRow
        TributoLinha = DS.Tables("Tributos").Select("Competencia = '" & Me.MensalCompetencia.Text & "'")


        Dim TotalLinhas As Integer = DS.Tables("Funcionarios").Rows.Count
        'Atualiza a barra de Progresso
        If TotalLinhas = 0 Then TotalLinhas = 1
        MyBarra.Visible = True
        MyBarra.Minimum = 1
        MyBarra.Maximum = TotalLinhas
        MyBarra.Value = 1
        MyBarra.Step = 1
        Me.Msg.Visible = True
        Me.Msg.Text = "Gerando Vale Quinzenal"
        Me.Msg.Refresh()


        Dim DrFuncionarios As DataRow
        For Each DrFuncionarios In DS.Tables("Funcionarios").Rows
            If NzVlr(DrFuncionarios("ValorVale")) > 0 Then
                If Not IsDBNull(DrFuncionarios("Foto")) Then
                    Dim ByteData() As Byte = DrFuncionarios("Foto")
                    Dim ImgVer As New IO.MemoryStream(ByteData)
                    Me.Display.Visible = True
                    Me.Display.Image = Image.FromStream(ImgVer)
                Else
                    Me.Display.Image = Me.SemFoto.Image
                End If
                Me.FuncionarioDesc.Text = (DrFuncionarios("Funcionários.Nome").ToString())
                Me.Display.Refresh()
                Me.FuncionarioDesc.Refresh()

                System.Threading.Thread.Sleep(200)

                Dim drEventosNoModulo As DataRow
                For Each drEventosNoModulo In DS.Tables("EventosNoModulo").Rows


                    Dim EventoLinha() As DataRow
                    EventoLinha = DS.Tables("Eventos").Select("CodigoEvento = " & drEventosNoModulo("CodigoEvento").ToString)

                    Dim TBLfolhaPgto As DataTable
                    TBLfolhaPgto = DS.Tables("FolhaPgto")
                    ' Obtem um novo objeto DataRow do DataTable
                    Dim DRnovo As DataRow
                    DRnovo = TBLfolhaPgto.NewRow()
                    DRnovo("Id") = UltimoReg
                    DRnovo("Competencia") = Me.MensalCompetencia.Text
                    DRnovo("Modulo") = Me.Modulo.Text
                    DRnovo("Funcionario") = DrFuncionarios("CódigoFuncionário").ToString()
                    DRnovo("Evento") = EventoLinha(0)("CodigoEvento")
                    DRnovo("Historico") = EventoLinha(0)(1)
                    DRnovo("Referencia") = 1
                    DRnovo("Empresa") = CodEmpresa
                    DRnovo("Confirmado") = False
                    DRnovo("Usuario") = UserAtivo
                    DRnovo("Protegido") = "N"

                    If EventoLinha(0)("Debito") = "00000000000000" Then
                        DRnovo("ContaDebito") = NzVlr(DrFuncionarios("CodPlanoContas").ToString())
                    Else
                        DRnovo("ContaDebito") = NzVlr(EventoLinha(0)("Debito"))
                    End If

                    If EventoLinha(0)("Credito") = "00000000000000" Then
                        DRnovo("ContaCredito") = NzVlr(DrFuncionarios("CodPlanoContas").ToString())
                    Else
                        DRnovo("ContaCredito") = NzVlr(EventoLinha(0)("Credito"))
                    End If


                    DRnovo("VlrDebito") = CDbl(NzVlr(DrFuncionarios("ValorVale").ToString()))
                    DRnovo("VlrCredito") = 0


                    TBLfolhaPgto.Rows.Add(DRnovo)
                    UltimoReg += 1

                    If CDbl(NzVlr(DRnovo("VlrCredito"))) = CDbl(0) And CDbl(NzVlr(DRnovo("VlrDebito"))) = CDbl(0) Then
                        TBLfolhaPgto.Rows.Remove(DRnovo)
                        UltimoReg -= 1
                    End If

                Next drEventosNoModulo
            End If
            MyBarra.PerformStep()
        Next DrFuncionarios

        Try
            Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAFolhaPgto)
            DAFolhaPgto.Update(DS, "FolhaPgto")

            Dim TBLGerado As DataTable
            TBLGerado = DS.Tables("Gerado")
            Dim DRnovo As DataRow
            DRnovo = TBLGerado.NewRow()
            DRnovo("Competencia") = Me.MensalCompetencia.Text
            DRnovo("Modulo") = Me.Modulo.Text
            DRnovo("Gerada") = True
            DRnovo("Empresa") = CodEmpresa
            TBLGerado.Rows.Add(DRnovo)
            Dim objCommandBuilder1 As New OleDb.OleDbCommandBuilder(DAJaFoiGerado)
            DAJaFoiGerado.Update(DS, "Gerado")

            CNN.Close()
            MsgBox("Vale Quinzenal gerado com sucesso.", 64, "Validação de Dados")
        Catch ex As Exception
            MsgBox("Ocorreram erros na geração do Vale, o processo foi cancelado, verifique.", 64, "Validação de Dados")
            CNN.Close()
            Exit Sub
        End Try
    End Sub

#End Region

    Private Sub Gerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gerar.Click

        If Me.Individual.Checked = False And Me.Todos.Checked = False Then Exit Sub

        If Me.Modulo.Text = "Mensalistas" Then
            GerarMensalistas()
        End If

        If Me.Modulo.Text = "Vale Quinzenal" Then
            GerarValeQuinzenal()
        End If

        If Me.Modulo.Text = "Pgto PIS" Then
            GerarPgtoPis()
        End If


    End Sub

    Private Sub AtDepententesSalarioFamilia()
        Dim Sql As String = ""
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        If Me.Individual.Checked = False Then
            Sql = "SELECT Funcionários.*, Funcionários.Nome, Funcionários.DataRecisao, Funcionários.Inativo, Funcionários.Empresa FROM(Funcionários) WHERE (((Funcionários.Nome) Is Not Null) AND ((Funcionários.DataRecisao) Is Null) AND ((Funcionários.Inativo)=False) AND ((Funcionários.Empresa)=" & CodEmpresa & "));"
        Else
            Sql = "SELECT Funcionários.*, Funcionários.Nome, Funcionários.DataRecisao, Funcionários.Inativo, Funcionários.Empresa FROM Funcionários WHERE Funcionários.Nome Is Not Null AND Funcionários.DataRecisao Is Null AND Funcionários.Inativo = False AND Funcionários.Empresa = " & CodEmpresa & " and CódigoFuncionário = " & Me.Funcionario.Text
        End If
        Dim DAFuncionarios As New OleDb.OleDbDataAdapter(Sql, CNN)

        Sql = "SELECT Dependentes.Id, Dependentes.Funcionario, Dependentes.Dependente, Dependentes.Parentesco, Dependentes.DataNascimento, Funcionários.DataRecisao FROM Funcionários INNER JOIN Dependentes ON Funcionários.CódigoFuncionário = Dependentes.Funcionario WHERE Dependentes.Dependente Is Not Null And Dependentes.Parentesco = 'FILHO(A)' AND Funcionários.DataRecisao Is Null"
        Dim DADepententes As New OleDb.OleDbDataAdapter(Sql, CNN)

        Dim DS As New DataSet

        DAFuncionarios.Fill(DS, "Funcionarios")
        DADepententes.Fill(DS, "Dependentes")


        Dim TotalLinhas As Integer = DS.Tables("Funcionarios").Rows.Count
        'Atualiza a barra de Progresso
        If TotalLinhas = 0 Then TotalLinhas = 1
        MyBarra.Visible = True
        MyBarra.Minimum = 1
        MyBarra.Maximum = TotalLinhas
        MyBarra.Value = 1
        MyBarra.Step = 1
        Me.Msg.Visible = True
        Me.Msg.Text = "Atualizando Cadastro de Funcionário"
        Me.Msg.Refresh()

        Dim DrFuncionarios As DataRow
        For Each DrFuncionarios In DS.Tables("Funcionarios").Rows
            DrFuncionarios.BeginEdit()
            If CDbl(NzZero(DrFuncionarios("QtdDependentesSalarioFamilia"))) = 0 Then
                System.Threading.Thread.Sleep(100)


                Dim DepFunc() As DataRow
                DepFunc = DS.Tables("Dependentes").Select("Funcionario = " & DrFuncionarios("CódigoFuncionário").ToString)

                Dim QtdDepFunc As Integer = 0
                Dim i As Integer
                For i = 0 To DepFunc.GetUpperBound(0)
                    If Age(CDate(DepFunc(i)("DataNascimento"))) < 14 Then
                        QtdDepFunc += 1
                    End If
                Next i

                DrFuncionarios("QtdDependentesSalarioFamilia") = QtdDepFunc
            End If
            DrFuncionarios.EndEdit()
            Me.MyBarra.PerformStep()
        Next DrFuncionarios

        Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAFuncionarios)
        DAFuncionarios.Update(DS, "Funcionarios")
        CNN.Close()
    End Sub

    Private Function Age(ByVal DTNascimento As DateTime)
        Dim Idade As Long
        Dim Nasc As Date = CDate(DTNascimento)
        Try
            Idade = DateDiff(DateInterval.Year, Nasc, Today)
            If DateSerial(Year(DataDia), Month(Nasc), Microsoft.VisualBasic.Day(Nasc)) > DataDia Then
                Idade = Idade - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return Idade
    End Function

    Private Sub FolhaPgtoGerador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()
        Me.MensalCompetencia.Text = MesAnoCompetencia
    End Sub

    Public Function UltimoRegistro()
        'Inserir ultimo registro
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer = 0
        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select max(Id) from FolhaPgto"
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
                Return 1
                Cnn.Close()
                Exit Function
            End If
        End Try
        Cnn.Close()

        Return Ult + 1

    End Function

    Private Sub AcharValesFuncionarios()

        Dim UltimoReg As Integer = UltimoRegistro()

        Dim Sql As String = ""
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Sql = "SELECT * from FolhaPgtoValeFuncionarios WHERE Confirmado = True and LancadoFolha = 'N'"
        Dim DAVale As New OleDb.OleDbDataAdapter(Sql, CNN)

        Sql = "Select * from FolhaPgto where Competencia = '" & Me.MensalCompetencia.Text & "' and Modulo = '" & Me.Modulo.Text & "'"
        Dim DAFolhaPgto As New OleDb.OleDbDataAdapter(Sql, CNN)


        Dim DS As New DataSet

        DAVale.Fill(DS, "Vale")
        DAFolhaPgto.Fill(DS, "FolhaPgto")

        Dim TotalLinhas As Integer = DS.Tables("Vale").Rows.Count
        If TotalLinhas = 0 Then
            Exit Sub
        End If

        'Atualiza a barra de Progresso
        If TotalLinhas = 0 Then TotalLinhas = 1
        MyBarra.Visible = True
        MyBarra.Minimum = 1
        MyBarra.Maximum = TotalLinhas
        MyBarra.Value = 1
        MyBarra.Step = 1
        Me.Msg.Visible = True
        Me.Msg.Text = "Verificando se existe vale para os Funcionários."
        Me.Msg.Refresh()


        Dim DrVale As DataRow
        For Each DrVale In DS.Tables("Vale").Rows
            System.Threading.Thread.Sleep(200)
            If DrVale("ModuloDescontar") = Me.Modulo.Text Then
                If DrVale("ModuloDescontar") = "Mensalistas" And DrVale("CompetenciaDesconto") = Me.MensalCompetencia.Text Then
                    Dim TBLfolhaPgto As DataTable
                    TBLfolhaPgto = DS.Tables("FolhaPgto")
                    ' Obtem um novo objeto DataRow do DataTable
                    Dim DRnovo As DataRow
                    DRnovo = TBLfolhaPgto.NewRow()
                    DRnovo("Id") = UltimoReg
                    DRnovo("Competencia") = Me.MensalCompetencia.Text
                    DRnovo("Modulo") = Me.Modulo.Text
                    DRnovo("Funcionario") = DrVale("Funcionario")
                    DRnovo("Evento") = DrVale("Evento")
                    DRnovo("Historico") = DrVale("EventoDesc")
                    DRnovo("Referencia") = 1
                    DRnovo("Empresa") = CodEmpresa
                    DRnovo("Confirmado") = True
                    DRnovo("Usuario") = DrVale("Usuario")
                    DRnovo("Protegido") = "S"

                    DRnovo("ContaDebito") = NzVlr(DrVale("Debito"))
                    DRnovo("ContaCredito") = NzVlr(DrVale("Credito"))
                    DRnovo("VlrDebito") = CDbl(NzVlr(DrVale("ValorLancamento")))
                    DRnovo("VlrCredito") = 0


                    TBLfolhaPgto.Rows.Add(DRnovo)
                    UltimoReg += 1

                    If CDbl(NzVlr(DRnovo("VlrCredito"))) = CDbl(0) And CDbl(NzVlr(DRnovo("VlrDebito"))) = CDbl(0) Then
                        TBLfolhaPgto.Rows.Remove(DRnovo)
                        UltimoReg -= 1
                    End If

                    DrVale.BeginEdit()
                    DrVale("LancadoFolha") = "S"
                    DrVale.EndEdit()
                End If

                If DrVale("ModuloDescontar") <> "Mensalistas" Then
                    If DrVale("ModuloDescontar") = Me.Modulo.Text Then
                        Dim TBLfolhaPgto As DataTable
                        TBLfolhaPgto = DS.Tables("FolhaPgto")
                        ' Obtem um novo objeto DataRow do DataTable
                        Dim DRnovo As DataRow
                        DRnovo = TBLfolhaPgto.NewRow()
                        DRnovo("Id") = UltimoReg
                        DRnovo("Competencia") = Me.MensalCompetencia.Text
                        DRnovo("Modulo") = Me.Modulo.Text
                        DRnovo("Funcionario") = DrVale("Funcionario")
                        DRnovo("Evento") = DrVale("Evento")
                        DRnovo("Historico") = DrVale("EventoDesc")
                        DRnovo("Referencia") = 1
                        DRnovo("Empresa") = CodEmpresa
                        DRnovo("Confirmado") = True
                        DRnovo("Usuario") = DrVale("Usuario")
                        DRnovo("Protegido") = "S"

                        DRnovo("ContaDebito") = NzVlr(DrVale("Debito"))
                        DRnovo("ContaCredito") = NzVlr(DrVale("Credito"))
                        DRnovo("VlrDebito") = CDbl(NzVlr(DrVale("ValorLancamento")))
                        DRnovo("VlrCredito") = 0


                        TBLfolhaPgto.Rows.Add(DRnovo)
                        UltimoReg += 1

                        If CDbl(NzVlr(DRnovo("VlrCredito"))) = CDbl(0) And CDbl(NzVlr(DRnovo("VlrDebito"))) = CDbl(0) Then
                            TBLfolhaPgto.Rows.Remove(DRnovo)
                            UltimoReg -= 1
                        End If

                        DrVale.BeginEdit()
                        DrVale("LancadoFolha") = "S"
                        DrVale.EndEdit()

                    End If
                End If
            End If
            MyBarra.PerformStep()
        Next DrVale

        Try
            Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAFolhaPgto)
            DAFolhaPgto.Update(DS, "FolhaPgto")

            Dim objcommandbuilder1 As New OleDb.OleDbCommandBuilder(DAVale)
            DAVale.Update(DS, "Vale")

            CNN.Close()

        Catch ex As Exception
            MsgBox("Ocorreram erros na geração dos Vales de funcionários, o processo foi cancelado, verifique.", 64, "Validação de Dados")
            MsgBox(ex.Message)
            CNN.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub AcharValesFuncionariosPis()

        Dim UltimoReg As Integer = UltimoRegistro()

        Dim Sql As String = ""
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Sql = "SELECT * from FolhaPgtoValeFuncionarios WHERE Confirmado = True and LancadoFolha = 'N'"
        Dim DAVale As New OleDb.OleDbDataAdapter(Sql, CNN)

        Sql = "Select * from FolhaPgto where Competencia = '" & Me.MensalCompetencia.Text & "' and Modulo = '" & Me.Modulo.Text & "'"
        Dim DAFolhaPgto As New OleDb.OleDbDataAdapter(Sql, CNN)


        Dim DS As New DataSet

        DAVale.Fill(DS, "Vale")
        DAFolhaPgto.Fill(DS, "FolhaPgto")

        Dim TotalLinhas As Integer = DS.Tables("Vale").Rows.Count
        If TotalLinhas = 0 Then
            Exit Sub
        End If

        'Atualiza a barra de Progresso
        If TotalLinhas = 0 Then TotalLinhas = 1
        MyBarra.Visible = True
        MyBarra.Minimum = 1
        MyBarra.Maximum = TotalLinhas
        MyBarra.Value = 1
        MyBarra.Step = 1
        Me.Msg.Visible = True
        Me.Msg.Text = "Verificando se existe vale para os Funcionários."
        Me.Msg.Refresh()


        Dim DrVale As DataRow
        For Each DrVale In DS.Tables("Vale").Rows
            System.Threading.Thread.Sleep(200)
            If DrVale("ModuloDescontar") = Me.Modulo.Text Then
                If Me.Modulo.Text = "Pgto Pis" Then

                    Dim TBLfolhaPgto As DataTable
                    TBLfolhaPgto = DS.Tables("FolhaPgto")
                    ' Obtem um novo objeto DataRow do DataTable
                    Dim DRnovo As DataRow
                    DRnovo = TBLfolhaPgto.NewRow()
                    DRnovo("Id") = UltimoReg
                    DRnovo("Competencia") = Me.MensalCompetencia.Text
                    DRnovo("Modulo") = Me.Modulo.Text
                    DRnovo("Funcionario") = DrVale("Funcionario")
                    DRnovo("Evento") = DrVale("Evento")
                    DRnovo("Historico") = DrVale("EventoDesc")
                    DRnovo("Referencia") = 1
                    DRnovo("Empresa") = CodEmpresa
                    DRnovo("Confirmado") = True
                    DRnovo("Usuario") = DrVale("Usuario")
                    DRnovo("Protegido") = "S"

                    DRnovo("ContaDebito") = NzVlr(DrVale("Debito"))
                    DRnovo("ContaCredito") = NzVlr(DrVale("Credito"))
                    DRnovo("VlrDebito") = CDbl(NzVlr(DrVale("ValorLancamento")))
                    DRnovo("VlrCredito") = 0


                    TBLfolhaPgto.Rows.Add(DRnovo)
                    UltimoReg += 1

                    If CDbl(NzVlr(DRnovo("VlrCredito"))) = CDbl(0) And CDbl(NzVlr(DRnovo("VlrDebito"))) = CDbl(0) Then
                        TBLfolhaPgto.Rows.Remove(DRnovo)
                        UltimoReg -= 1
                    End If

                    DrVale.BeginEdit()
                    DrVale("LancadoFolha") = "S"
                    DrVale.EndEdit()
                End If

                If DrVale("ModuloDescontar") <> "Mensalistas" Then
                    If DrVale("ModuloDescontar") = Me.Modulo.Text Then
                        Dim TBLfolhaPgto As DataTable
                        TBLfolhaPgto = DS.Tables("FolhaPgto")
                        ' Obtem um novo objeto DataRow do DataTable
                        Dim DRnovo As DataRow
                        DRnovo = TBLfolhaPgto.NewRow()
                        DRnovo("Id") = UltimoReg
                        DRnovo("Competencia") = Me.MensalCompetencia.Text
                        DRnovo("Modulo") = Me.Modulo.Text
                        DRnovo("Funcionario") = DrVale("Funcionario")
                        DRnovo("Evento") = DrVale("Evento")
                        DRnovo("Historico") = DrVale("EventoDesc")
                        DRnovo("Referencia") = 1
                        DRnovo("Empresa") = CodEmpresa
                        DRnovo("Confirmado") = True
                        DRnovo("Usuario") = DrVale("Usuario")
                        DRnovo("Protegido") = "S"

                        DRnovo("ContaDebito") = NzVlr(DrVale("Debito"))
                        DRnovo("ContaCredito") = NzVlr(DrVale("Credito"))
                        DRnovo("VlrDebito") = CDbl(NzVlr(DrVale("ValorLancamento")))
                        DRnovo("VlrCredito") = 0


                        TBLfolhaPgto.Rows.Add(DRnovo)
                        UltimoReg += 1

                        If CDbl(NzVlr(DRnovo("VlrCredito"))) = CDbl(0) And CDbl(NzVlr(DRnovo("VlrDebito"))) = CDbl(0) Then
                            TBLfolhaPgto.Rows.Remove(DRnovo)
                            UltimoReg -= 1
                        End If

                        DrVale.BeginEdit()
                        DrVale("LancadoFolha") = "S"
                        DrVale.EndEdit()

                    End If
                End If
            End If
            MyBarra.PerformStep()
        Next DrVale

        Try
            Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(DAFolhaPgto)
            DAFolhaPgto.Update(DS, "FolhaPgto")

            Dim objcommandbuilder1 As New OleDb.OleDbCommandBuilder(DAVale)
            DAVale.Update(DS, "Vale")

            CNN.Close()

        Catch ex As Exception
            MsgBox("Ocorreram erros na geração dos Vales de funcionários, o processo foi cancelado, verifique.", 64, "Validação de Dados")
            MsgBox(ex.Message)
            CNN.Close()
            Exit Sub
        End Try

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