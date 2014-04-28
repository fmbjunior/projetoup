Public Class CFOPse

    Dim Ação As New TrfGerais()

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub CFOPse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EncheLista()
    End Sub

    Private Sub EncheLista()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim ds As New DataSet()
        Dim Sql As String = "SELECT * from CFOPsaientra Where Empresa = " & CodEmpresa
        Dim daCFOPes As New OleDb.OleDbDataAdapter(Sql, CNN)
        daCFOPes.Fill(ds, "CFOP")

        Me.Lista.DataSource = ds.Tables("CFOP").DefaultView
    End Sub

    Private Sub Lista_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lista.CellDoubleClick

        Ação.LimpaTextBox(Me)

        Me.Empresa.Text = Me.Lista.CurrentRow.Cells("cEmpresa").Value
        Me.cfopS.Text = Me.Lista.CurrentRow.Cells("cCfopS").Value
        Me.cfopE.Text = Me.Lista.CurrentRow.Cells("cCfopE").Value
        Me.ctb.Text = Me.Lista.CurrentRow.Cells("cCtb").Value

        Me.Empresa.Enabled = False
        Me.cfopS.Enabled = False
        Me.cfopE.Focus()

    End Sub

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        Ação.LimpaTextBox(Me)
        Me.Empresa.Text = CodEmpresa
        Me.Empresa.Enabled = False
        Me.cfopS.Enabled = True
        Me.cfopS.Focus()
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        'Area destinada para as validacoes

        If ValidaDados(Me.Empresa, "Favor informar o CNPJ da Empresa") = False Then Exit Sub
        If ValidaDados(Me.cfopE, "Favor informar o CFOP de Entrada") = False Then Exit Sub
        If ValidaDados(Me.cfopS, "Favor informar o CFOP de Saída") = False Then Exit Sub
        If ValidaDados(Me.ctb, "Favor informar o código CTB") = False Then Exit Sub

        'Fim da Area destinada para as validacoes


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim ds As New DataSet
        Dim Sql As String = String.Empty

        Sql = "SELECT * from CFOPsaientra Where Empresa = " & Me.Empresa.Text & " and cfopS = '" & Me.cfopS.Text & "'"
        Dim DACFOP As New OleDb.OleDbDataAdapter(Sql, CNN)
        DACFOP.Fill(ds, "CFOP")

        Try
            If ds.Tables("CFOP").Rows.Count = 0 Then
                Dim DRnovo As DataRow
                DRnovo = ds.Tables("CFOP").NewRow

                DRnovo("Empresa") = Nz(Me.Empresa.Text, 1)
                DRnovo("cfopS") = Nz(Me.cfopS.Text, 1)
                DRnovo("cfopE") = Nz(Me.cfopE.Text, 1)
                DRnovo("ctb") = Nz(Me.ctb.Text, 1)
                ds.Tables("CFOP").Rows.Add(DRnovo)

            Else
                ds.Tables("CFOP").Rows(0).BeginEdit()
                ds.Tables("CFOP").Rows(0)("Empresa") = Nz(Me.Empresa.Text, 1)
                ds.Tables("CFOP").Rows(0)("cfopS") = Nz(Me.cfopS.Text, 1)
                ds.Tables("CFOP").Rows(0)("cfopE") = Nz(Me.cfopE.Text, 1)
                ds.Tables("CFOP").Rows(0)("ctb") = Nz(Me.ctb.Text, 1)
                ds.Tables("CFOP").Rows(0).EndEdit()

            End If


            Dim objBuilder As New OleDb.OleDbCommandBuilder(DACFOP)
            DACFOP.Update(ds, "CFOP")
            MessageBox.Show("Registro salvo com sucesso", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CNN.Close()
            EncheLista()

        Catch ex As Exception
            MsgBox(ex.Message)
            CNN.Close()
            Exit Sub
        End Try

    End Sub

    Private Sub btExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExcluir.Click

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim ds As New DataSet
        Dim Sql As String = String.Empty


        Sql = "SELECT CFOPsaientra.Empresa, CFOPsaientra.CFOPs FROM CFOPsaientra WHERE (((CFOPsaientra.Empresa)=" & Me.Empresa.Text & ") AND ((CFOPsaientra.CFOPs)='" & Me.cfopS.Text & "'))"

        Dim DACFOP As New OleDb.OleDbDataAdapter(Sql, CNN)
        DACFOP.Fill(ds, "CFOP")

        Try
            If ds.Tables("CFOP").Rows.Count = 1 Then
                ds.Tables("CFOP").Rows(0).Delete()
            End If


            Dim objBuilder As New OleDb.OleDbCommandBuilder(DACFOP)
            DACFOP.Update(ds, "CFOP")
            MessageBox.Show("Registro Excluido com sucesso", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CNN.Close()
            EncheLista()

        Catch ex As Exception
            MsgBox(ex.Message)
            CNN.Close()
            Exit Sub
        End Try

    End Sub

End Class