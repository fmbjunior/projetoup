Imports System.Data.OleDb

Public Class BalanceteAlterarLancamento

    Dim VarBalancete As String = String.Empty
    Public Property BalanceteAlterar() As String
        Get
            Return VarBalancete
        End Get
        Set(ByVal Value As String)
            VarBalancete = Value
        End Set
    End Property

    Dim DsProcura As New DataSet
    Dim Da As OleDbDataAdapter
    Dim bs As BindingSource


    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
            SendKeys.Send("{Tab}")
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function


    Private Sub Fechar_Click(sender As Object, e As EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub DataFinal_Leave(sender As Object, e As EventArgs) Handles DataFinal.Leave
        If CDate(Me.DataInicial.Text) > CDate(Me.DataFinal.Text) Then
            MessageBox.Show("A data Inicial não pode ser maior que a data final", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DataInicial.Focus()
            Exit Sub
        End If

        EncheGrid()

    End Sub

    Private Sub EncheGrid()

        DsProcura.Clear()

        Dim CNN As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        Dim cmd As New OleDbCommand
        Dim Sql As String = String.Empty

        Sql = "SELECT BalanceteLanc.Id, BalanceteLanc.ContaBalancete, BalanceteLanc.ContaCR, BalanceteLanc.DataLancamento, BalanceteLanc.Documento,BalanceteLanc.ValorDocumento, BalanceteLanc.PrgLancamento, BalanceteLanc.Historico FROM BalanceteLanc WHERE BalanceteLanc.DataLancamento Between #" & Format(CDate(Me.DataInicial.Text), "MM/dd/yyyy") & "# And #" & Format(CDate(Me.DataFinal.Text), "MM/dd/yyyy") & "# ORDER BY BalanceteLanc.Id"

        Da = New OleDbDataAdapter(Sql, CNN)
        Da.SelectCommand.CommandType = CommandType.Text
        Da.Fill(DsProcura, "BalanceteLanc")

        bs = New BindingSource
        bs.DataSource = DsProcura.Tables("BalanceteLanc").DefaultView

        Me.ListaProcura.DataSource = bs

        Me.TotReg.Text = "Total de Registros...: " & Me.ListaProcura.RowCount
        CNN.Close()


    End Sub


  
    Private Sub btAtualizar_Click(sender As Object, e As EventArgs) Handles btAtualizar.Click

        Try
            Dim objBuilder As New OleDbCommandBuilder(Da)
            Da.Update(DsProcura, "BalanceteLanc")
            MessageBox.Show("Dados Atualizado com Sucesso", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        
    End Sub

    Private Sub BalanceteAlterarLancamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListaProcura_KeyDown(sender As Object, e As KeyEventArgs) Handles ListaProcura.KeyDown
        If e.KeyCode = Keys.F5 Then
            If ListaProcura.CurrentCell.ColumnIndex = 1 Then
                'My.Forms.BalanceteContasProcura.TipoConta = "D"
                My.Forms.BalanceteContasProcura.ShowDialog()
                If VarBalancete <> "" Then
                    Me.ListaProcura.CurrentCell.Value = VarBalancete
                End If
            End If

            If ListaProcura.CurrentCell.ColumnIndex = 2 Then
                My.Forms.CentroCustoNewLocalizar.ShowDialog()
                If VarBalancete <> "" Then
                    Me.ListaProcura.CurrentCell.Value = VarBalancete
                End If
            End If

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class