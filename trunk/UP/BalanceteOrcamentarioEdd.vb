Public Class BalanceteOrcamentarioEdd

    Public Sub New(ByVal vConta As String, ByVal vAno As String)
        InitializeComponent()
        Me.Conta.Text = vConta
        Me.Ano.Text = vAno
        AchaConta()
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()



        Dim Sql As String = "Update BalanceteOrcamentario set ControlaDespesas = @1, JanPrevisto = @2, FevPrevisto = @3, MarPrevisto = @4, AbrPrevisto = @5, MaiPrevisto = @6, JunPrevisto = @7, JulPrevisto = @8, AgoPrevisto = @9, SetPrevisto = @10, OutPrevisto = @11, NovPrevisto = @12, DezPrevisto = @13 Where AnoOrcFin = '" & Me.Ano.Text & "' and Conta = '" & Me.Conta.Text & "'"
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Me.ControlaDespesas.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Me.JanPrevisto.Text))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Me.FevPrevisto.Text))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Me.MarPrevisto.Text))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Me.AbrPrevisto.Text))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.MaiPrevisto.Text))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Me.JunPrevisto.Text))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Me.JulPrevisto.Text))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Me.AgoPrevisto.Text))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Me.SetPrevisto.Text))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Me.OutPrevisto.Text))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Me.NovPrevisto.Text))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Me.DezPrevisto.Text))

        Try
            cmd.ExecuteNonQuery()
            CNN.Close()
            My.Forms.BalanceteOrcamentario.MostraBalancete()
            Me.Close()
            Me.Dispose()
        Catch x As Exception
            'MsgBox(x.Message)
            'Exit Sub
        End Try


    End Sub


    Private Sub AchaConta()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * From BalanceteOrcamentario Where AnoOrcFin = '" & Me.Ano.Text & "' and Conta = '" & Me.Conta.Text & "'"
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)
        Dim Dr As OleDb.OleDbDataReader

        Dr = cmd.ExecuteReader

        Dr.Read()

        If Dr.HasRows = True Then

            Me.ControlaDespesas.Checked = Dr.Item("ControlaDespesas")
            Me.JanPrevisto.Text = FormatNumber(Dr.Item("JanPrevisto"), 2)
            Me.FevPrevisto.Text = FormatNumber(Dr.Item("FevPrevisto"), 2)
            Me.MarPrevisto.Text = FormatNumber(Dr.Item("MarPrevisto"), 2)
            Me.AbrPrevisto.Text = FormatNumber(Dr.Item("AbrPrevisto"), 2)
            Me.MaiPrevisto.Text = FormatNumber(Dr.Item("MaiPrevisto"), 2)
            Me.JunPrevisto.Text = FormatNumber(Dr.Item("JunPrevisto"), 2)
            Me.JulPrevisto.Text = FormatNumber(Dr.Item("JulPrevisto"), 2)
            Me.AgoPrevisto.Text = FormatNumber(Dr.Item("AgoPrevisto"), 2)
            Me.SetPrevisto.Text = FormatNumber(Dr.Item("SetPrevisto"), 2)
            Me.OutPrevisto.Text = FormatNumber(Dr.Item("OutPrevisto"), 2)
            Me.NovPrevisto.Text = FormatNumber(Dr.Item("NovPrevisto"), 2)
            Me.DezPrevisto.Text = FormatNumber(Dr.Item("DezPrevisto"), 2)

        End If
        Dr.Close()
        CNN.Close()


    End Sub

    Private Sub BalanceteOrcamentarioEdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class