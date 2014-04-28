Public Class Markup

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2


    Private Sub mkOperador_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles mkOperador.Enter, mkIcmsVenda.Leave, mkIpiVenda.Leave, mkPisVenda.Leave, mkCofinsVenda.Leave, mkComissaoVenda.Leave, mkOutrosVenda.Leave, mkMargemLucroVenda.Leave
        Dim varMK As Double = FormatNumber(CDbl(NzZero(Me.mkOutrosVenda.Text)) + CDbl(NzZero(Me.mkMargemLucroVenda.Text)) + CDbl(NzZero(Me.mkComissaoVenda.Text)) + CDbl(NzZero(Me.mkIcmsVenda.Text)) + CDbl(NzZero(Me.mkCofinsVenda.Text)) + CDbl(NzZero(Me.mkPisVenda.Text)) + CDbl(NzZero(Me.mkIpiVenda.Text)), 2)
        Dim VarMkOperador As Double = FormatNumber((100 - varMK), 3)
        VarMkOperador = FormatNumber(VarMkOperador / 100, 3)
        VarMkOperador = FormatNumber((1 / VarMkOperador), 3)
        Me.mkOperador.Text = FormatNumber(VarMkOperador, 3)
    End Sub

    Private Sub FecharBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharBT.Click
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub NovoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoBT.Click
        If Adi = False Then
            MsgBox("O Usuário não tem permissão para Adicionar o registro, verifique com o Administrador.", 64, "Validação de Dados")
            Ação.Desbloquear_Controle(Me, False)
            Exit Sub
        End If

        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)

        Me.DescMarkup.Focus()
        Operation = INS

    End Sub

    Private Sub EditarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBT.Click
        If Me.DescMarkup.Text = "" Then
            MsgBox("Não existe Markup para ser editado.", 64, "Validação de Dados")
            Exit Sub
        End If
        If Edi = False Then
            MsgBox("O Usuário não tem permissão para editar o registro, verifique com o Administrador.", 64, "Validação de Dados")
            Ação.Desbloquear_Controle(Me, False)
            Exit Sub
        End If
        Operation = UPD
        Ação.Desbloquear_Controle(Me, True)

        Me.DescMarkup.Focus()
    End Sub

    Private Sub LocalizarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizarBT.Click
        If Con = False Then
            MsgBox("O Usuário não tem permissão para Consultar registro, verifique com o Administrador.", 64, "Validação de Dados")
            Ação.Desbloquear_Controle(Me, False)
            Exit Sub
        End If

        Ação.Desbloquear_Controle(Me, False)
        My.Forms.MarkupProcura.ShowDialog()
        Me.DescMarkup.Text = RetornoProcura

        If Me.DescMarkup.Text <> "" Then
            AcharMarkup()
            Me.DescMarkup.Focus()
        End If
    End Sub

    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click
        If Me.PisEntrada.Text = "" Then Me.PisEntrada.Text = 0
        If Me.CofinsEntrada.Text = "" Then Me.CofinsEntrada.Text = 0
        If Me.IcmsEntrada.Text = "" Then Me.IcmsEntrada.Text = 0
        If Me.mkIcmsVenda.Text = "" Then Me.mkIcmsVenda.Text = 0
        If Me.IpiEntrada.Text = "" Then Me.IpiEntrada.Text = 0
        If Me.FreteEntrada.Text = "" Then Me.FreteEntrada.Text = 0
        If Me.mkComissaoVenda.Text = "" Then Me.mkComissaoVenda.Text = 0
        If Me.mkOutrosVenda.Text = "" Then Me.mkOutrosVenda.Text = 0
        If Me.mkMargemLucroVenda.Text = "" Then Me.mkMargemLucroVenda.Text = 0
        If Me.mkOperador.Text = "" Then Me.mkOperador.Text = 0
        If Me.mkPisVenda.Text = "" Then Me.mkPisVenda.Text = 0
        If Me.mkCofinsVenda.Text = "" Then Me.mkCofinsVenda.Text = 0
        If Me.mkIpiVenda.Text = "" Then Me.mkIpiVenda.Text = 0


        'achar o operador do calculo do markup
        Dim varMK As Double = FormatNumber(CDbl(NzZero(Me.mkOutrosVenda.Text)) + CDbl(NzZero(Me.mkMargemLucroVenda.Text)) + CDbl(NzZero(Me.mkComissaoVenda.Text)) + CDbl(NzZero(Me.mkIcmsVenda.Text)) + CDbl(NzZero(Me.mkCofinsVenda.Text)) + CDbl(NzZero(Me.mkPisVenda.Text)), 2)
        Dim VarMkOperador As Double = FormatNumber((100 - varMK), 2)
        VarMkOperador = FormatNumber(VarMkOperador / 100, 3)
        VarMkOperador = FormatNumber((1 / VarMkOperador), 2)
        Me.mkOperador.Text = FormatNumber(VarMkOperador, 2)

        'Atualizar os dados do produto

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Edi = False Then
            MsgBox("O Usuário não tem permissão para editar o registro, verifique com o Administrador.", 64, "Validação de Dados")
            Exit Sub
        End If

        If Operation = INS Then

            CNN.Open()

            Dim Sql As String = "INSERT INTO Markup (DescMarkup, FreteEntrada, IcmsEntrada, PisEntrada, CofinsEntrada, IpiEntrada, mkPisVenda, mkCofinsVenda, mkIcmsVenda, mkIpiVenda, mkComissaoVenda, mkOutrosVenda, mkMargemLucroVenda, mkOperador) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.DescMarkup.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", NzZero(Me.FreteEntrada.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", NzZero(Me.IcmsEntrada.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", NzZero(Me.PisEntrada.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", NzZero(Me.CofinsEntrada.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", NzZero(Me.IpiEntrada.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", NzZero(Me.mkPisVenda.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", NzZero(Me.mkCofinsVenda.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzZero(Me.mkIcmsVenda.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", NzZero(Me.mkIpiVenda.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", NzZero(Me.mkComissaoVenda.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", NzZero(Me.mkOutrosVenda.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", NzZero(Me.mkMargemLucroVenda.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", NzZero(Me.mkOperador.Text)))


            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                NovoBT_Click(sender, e)
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            CNN.Close()

        ElseIf Operation = UPD Then

            CNN.Open()
            Dim Sql As String = "UPDATE Markup SET  DescMarkup = @1, FreteEntrada = @2, IcmsEntrada = @3, PisEntrada = @4, CofinsEntrada = @5, IpiEntrada = @6, mkPisVenda = @7, mkCofinsVenda = @8, mkIcmsVenda = @9, mkIpiVenda = @10, mkComissaoVenda = @11, mkOutrosVenda = @12, mkMargemLucroVenda = @13, mkOperador = @14 Where DescMarkup = '" & Me.DescMarkup.Text & "'"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.DescMarkup.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", NzZero(Me.FreteEntrada.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", NzZero(Me.IcmsEntrada.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", NzZero(Me.PisEntrada.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", NzZero(Me.CofinsEntrada.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", NzZero(Me.IpiEntrada.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", NzZero(Me.mkPisVenda.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", NzZero(Me.mkCofinsVenda.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzZero(Me.mkIcmsVenda.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", NzZero(Me.mkIpiVenda.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", NzZero(Me.mkComissaoVenda.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@12", NzZero(Me.mkOutrosVenda.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@13", NzZero(Me.mkMargemLucroVenda.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@14", NzZero(Me.mkOperador.Text)))


            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                CNN.Close()

            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
        End If


    End Sub

    Private Sub AcharMarkup()
        If Me.DescMarkup.Text = "" Then
            Exit Sub
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT * FROM Markup WHERE DescMarkup = '" & Me.DescMarkup.Text & "'"

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.DescMarkup.Text = NzZero(DR.Item("DescMarkup"))
            Me.FreteEntrada.Text = NzZero(DR.Item("FreteEntrada"))
            Me.IcmsEntrada.Text = NzZero(DR.Item("IcmsEntrada"))
            Me.PisEntrada.Text = NzZero(DR.Item("PisEntrada"))
            Me.CofinsEntrada.Text = NzZero(DR.Item("CofinsEntrada"))
            Me.IpiEntrada.Text = NzZero(DR.Item("IpiEntrada"))
            Me.mkPisVenda.Text = NzZero(DR.Item("mkPisVenda"))
            Me.mkCofinsVenda.Text = NzZero(DR.Item("mkCofinsVenda"))
            Me.mkIcmsVenda.Text = NzZero(DR.Item("mkIcmsVenda"))
            Me.mkIpiVenda.Text = NzZero(DR.Item("mkIpiVenda"))
            Me.mkComissaoVenda.Text = NzZero(DR.Item("mkComissaoVenda"))
            Me.mkOutrosVenda.Text = NzZero(DR.Item("mkOutrosVenda"))
            Me.mkMargemLucroVenda.Text = NzZero(DR.Item("mkMargemLucroVenda"))
            Me.mkOperador.Text = NzZero(DR.Item("mkOperador"))

        End If
        DR.Close()

    End Sub

    Private Sub Markup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ação.Desbloquear_Controle(Me, False)
    End Sub

End Class
