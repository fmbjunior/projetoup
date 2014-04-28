Imports System.IO
Imports CrystalDecisions
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine


Public Class ReciboAvulso

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2
    Const VAZ As Byte = 5

    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        Me.Close()
        Me.Dispose()
    End Sub

  
   
    Private Sub NovoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click
        If Len(CaixaAtivo) <> 4 Then
            MessageBox.Show("O usuario deve selecionar um caixa antes de criar um novo recibo. Verifique", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)
        Me.recibo.Text = "0000"
        Me.DataRecibo.Text = DataDia
        Me.CaixaEmitiu.Text = CaixaAtivo
        Me.DataRecibo.Focus()
        Operation = INS

    End Sub

    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click
        'Area destinada para as validacoes
        If Me.DataRecibo.Text = "" Then
            MsgBox("A Data do recibo não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.DataRecibo.Focus()
            Exit Sub
        ElseIf Me.RecebiDe.Text = "" Then
            MsgBox("O campo recebi de não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.RecebiDe.Focus()
            Exit Sub
        ElseIf Me.ValorDocumento.Text = "" Then
            MsgBox("O campo importância não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.ValorDocumento.Focus()
            Exit Sub
        ElseIf Me.Correspondente.Text = "" Then
            MsgBox("O campo Correspondente não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Correspondente.Focus()
            Exit Sub
        ElseIf Me.Emitente.Text = "" Then
            MsgBox("O campo Emitente não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.ValorDocumento.Focus()
            Exit Sub


        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        If Operation = INS Then
            UltimoReg()
            Dim Sql As String = "INSERT INTO ReciboAvulso (Recibo, DataRecibo, RecebiDe, ValorDocumento, Correspondente, Emitente, EndereçoEmitente, CpfCnpj, CaixaEmitiu) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            Try

                cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Recibo.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.DataRecibo.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.RecebiDe.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ValorDocumento.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Correspondente.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Emitente.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.EndereçoEmitente.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.CpfCnpj.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@9", CaixaAtivo))
                cmd.ExecuteNonQuery()

                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Confirmou, Me.Recibo.Text)
                CNN.Close()

                If MsgBox("Deseja imprimir o recibo agora ?", 36, "Validação de Dados") = MsgBoxResult.Yes Then
                    RelatorioCarregar = "RelReciboAvulso"
                    My.Forms.VisualizadorRelatorio.ShowDialog()
                End If

            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            Ação.Desbloquear_Controle(Me, False)
        End If

    End Sub


    Public Sub UltimoReg()
        'Inserir ultimo registro
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "SELECT Max(ReciboAvulso.Recibo) AS MáxDeRecibo FROM ReciboAvulso"
        Dim Cmd As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader
        Dim Ult As Integer

        Try
            DR = Cmd.ExecuteReader
            DR.Read()
            If DR.HasRows = True Then
                Ult = NzZero(DR.Item(0))
            Else
                Ult = 1
            End If

            DR.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()

        Me.Recibo.Text = Format(Ult + 1, "000000")
        'fim inserir ultimo registro

    End Sub

    Private Sub CaixaEmitiu_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaixaEmitiu.Enter
        If Me.CaixaEmitiu.Text = "" Then Me.CaixaEmitiu.Text = CaixaAtivo
    End Sub

    Private Sub ReciboAvulso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Operation = VAZ
        Ação.Desbloquear_Controle(Me, False)
    End Sub

    Private Sub ImprimirBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirBT.Click
        RelatorioCarregar = "RelReciboAvulso"
        My.Forms.VisualizadorRelatorio.ShowDialog()
    End Sub

    Private Sub LocalizarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizarBT.Click
        Me.Recibo.Enabled = True
        Me.Recibo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.DataRecibo.Enabled = True
        Me.DataRecibo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Operation = VAZ
        Me.Recibo.Focus()
    End Sub

    Public Sub LocalizaRecibo()
        If Me.Recibo.Text = "" Then
            Exit Sub
        End If

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "SELECT * From ReciboAvulso WHERE Recibo = '" & Me.Recibo.Text & "'"

        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.Recibo.Text = DR.Item("Recibo") & ""
            Me.DataRecibo.Text = DR.Item("DataRecibo") & ""
            Me.RecebiDe.Text = DR.Item("RecebiDe") & ""
            Me.ValorDocumento.Text = DR.Item("ValorDocumento") & ""
            Me.Correspondente.Text = DR.Item("Correspondente") & ""
            Me.Emitente.Text = DR.Item("Emitente") & ""
            Me.EndereçoEmitente.Text = DR.Item("EndereçoEmitente") & ""
            Me.CpfCnpj.Text = DR.Item("CpfCnpj") & ""
        End If
        DR.Close()
        Cnn.Close()
    End Sub

    Private Sub Recibo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Recibo.Leave
        If String.CompareOrdinal(Me.Recibo.Text, Me.Recibo.TextoAntigo) Then
            LocalizaRecibo()
        End If
    End Sub

    Private Sub Recibo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Recibo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.CompareOrdinal(Me.Recibo.Text, Me.Recibo.TextoAntigo) Then
                LocalizaRecibo()
            End If
        End If
    End Sub

    Public Sub LocalizaDadosEmpresa()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Empresa where CódigoEmpresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows = True Then
            Me.Emitente.Text = DR.Item("RazãoSocial") & ""
            Me.EndereçoEmitente.Text = DR.Item("Endereço") & ", " & DR.Item("Numero")
            Me.CpfCnpj.Text = DR.Item("Cgc") & ""
        End If
        DR.Close()
        CNN.Close()

    End Sub

    Private Sub btLocalizaEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLocalizaEmpresa.Click
        LocalizaDadosEmpresa()
    End Sub

    Private Sub ValorDocumento_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValorDocumento.Leave
        If Me.ValorDocumento.Text <> "" Then
            Dim extenso As New ActiveIT.cExtenso()
            Me.ValorExtenso.Text = extenso.Executar(CDec(Me.ValorDocumento.Text))
        End If
    End Sub

    Private Sub Recibo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Recibo.TextChanged

    End Sub
End Class