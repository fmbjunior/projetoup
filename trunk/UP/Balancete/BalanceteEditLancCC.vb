Imports System.Data.OleDb
Public Class BalanceteEditLancCC

    Public IdAchar As Integer
    Public Property EditarID As Integer
        Get
            Return IdAchar
        End Get
        Set(ByVal Value As Integer)
            IdAchar = Value
        End Set
    End Property

    Private Sub btFechar_Click(sender As Object, e As EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        Me.Id.Clear()
        Me.DataLanc.Clear()
        Me.ValorLanc.Clear()
        Me.ContaCC.Clear()
        Me.ContaCCDesc.Clear()
        Me.Id.Text = "AUTO"
        Me.DataLanc.Focus()
    End Sub


    Private Sub btFindContaCC_Click(sender As Object, e As EventArgs) Handles btFindContaCC.Click
        My.Forms.CentroCustoNewLocalizar.ShowDialog()
        AchaContaCentroCusto(Me.ContaCC.Text, Me.ContaCCDesc)
        Me.ContaCC.Focus()
    End Sub

    Public Sub AchaContaCentroCusto(ByVal ContaCC As String, ByVal CampoParaRetornar As Control)

        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "Select * from Cc3 where ContaGrupo3 = '" & ContaCC & "' And Empresa = " & CodEmpresa
        Dim CMD As New OleDbCommand(Sql, Cnn)
        Dim DR As OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            CampoParaRetornar.Text = DR.Item("DescContaGrupo3") & ""
        End If
        Cnn.Close()

    End Sub

    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click

        If Me.IdCaixaBanco.Text = "" Then
            MessageBox.Show("Não foi informado a relação com o caixa/banco, favor verificar.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            Me.DataLanc.Focus()
        End If

        If Me.DataLanc.Text = "" Then
            MessageBox.Show("Não foi informado a data de lançamento, favor verificar.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            Me.DataLanc.Focus()
        End If

        If Me.ValorLanc.Text = "" Then
            MessageBox.Show("Não foi informado o valor do lançamento, favor verificar.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            Me.DataLanc.Focus()
        End If

        If Me.ContaCC.Text = "" Then
            MessageBox.Show("Não foi informado a conta de centro de custo, favor verificar.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            Me.DataLanc.Focus()
        End If


        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Ds As New DataSet

        Dim Var_Id As Double
        If Me.Id.Text = "AUTO" Then Var_Id = -1 Else Var_Id = Me.Id.Text


        Dim Transacao As OleDbTransaction = Cnn.BeginTransaction()
        Dim Cmd As OleDbCommand = Cnn.CreateCommand
        
        Cmd.Transaction = Transacao


        Cmd.CommandText = "Select * from CcLanc Where Id = " & Var_Id
        Dim da As New OleDbDataAdapter(Cmd)
        da.Fill(Ds, "CCLanc")

        If Ds.Tables("CCLanc").Rows.Count = 0 Then
            Dim DRnovo As DataRow
            DRnovo = Ds.Tables("CCLanc").NewRow

            DRnovo("IdCaixaBanco") = nzINT(Me.IdCaixaBanco.Text)
            DRnovo("ContaCC") = nzNUL(Me.ContaCC.Text)
            DRnovo("DataLanc") = nzDAT(Me.DataLanc.Text)
            DRnovo("ValorLanc") = nzNUM(Me.ValorLanc.Text)

            Ds.Tables("CCLanc").Rows.Add(DRnovo)

            Dim obj As New OleDbCommandBuilder(da)
            da.Update(Ds, "CCLanc")

            Cmd.CommandText = "SELECT @@IDENTITY"
            Me.Id.Text = Cmd.ExecuteScalar.ToString

            Cnn.Close()

            MessageBox.Show("Registro Salvo com sucesso.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            Ds.Tables("CCLanc").Rows(0).BeginEdit()
            Ds.Tables("CCLanc").Rows(0)("IdCaixaBanco") = nzINT(Me.IdCaixaBanco.Text)
            Ds.Tables("CCLanc").Rows(0)("ContaCC") = nzNUL(Me.ContaCC.Text)
            Ds.Tables("CCLanc").Rows(0)("DataLanc") = nzDAT(Me.DataLanc.Text)
            Ds.Tables("CCLanc").Rows(0)("ValorLanc") = nzNUM(Me.ValorLanc.Text)
            Ds.Tables("CCLanc").Rows(0).EndEdit()

            Dim obj As New OleDbCommandBuilder(da)
            da.Update(Ds, "CCLanc")

            Cnn.Close()
            MessageBox.Show("Registro Salvo com sucesso.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub BalanceteEditLancCC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IdAchar <> 0 Then
            AcharRegistroLancamento(IdAchar)
        Else
            Me.IdCaixaBanco.Text = My.Forms.BalanceteEdit.Id.Text
            Me.Id.Text = "AUTO"
        End If
    End Sub


    Private Sub AcharRegistroLancamento(id As Integer)

        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Ds As New DataSet

        Dim Transacao As OleDbTransaction = Cnn.BeginTransaction()
        Dim Cmd As OleDbCommand = Cnn.CreateCommand

        Cmd.Transaction = Transacao


        Cmd.CommandText = "Select * from CcLanc Where Id = " & id
        Dim da As New OleDbDataAdapter(Cmd)
        da.Fill(Ds, "CCLanc")

        If Ds.Tables("CCLanc").Rows.Count <> 0 Then

            Me.Id.Text = Ds.Tables("CCLanc").Rows(0)("Id")
            Me.IdCaixaBanco.Text = Ds.Tables("CCLanc").Rows(0)("IdCaixaBanco")
            Me.ContaCC.Text = Ds.Tables("CCLanc").Rows(0)("ContaCC")
            Me.DataLanc.Text = Ds.Tables("CCLanc").Rows(0)("DataLanc")
            Me.ValorLanc.Text = Ds.Tables("CCLanc").Rows(0)("ValorLanc")

            Cnn.Close()
            AchaContaCentroCusto(Me.ContaCC.Text, Me.ContaCCDesc)
        End If
    End Sub

End Class