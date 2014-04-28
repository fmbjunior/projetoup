Imports System.Data.OleDb
Public Class TipoFormaPgtoAnexar

    Public Operation As Byte
    Public Const INS As Byte = 0
    Public Const UPD As Byte = 1
    Public Const DEL As Byte = 2
    Dim Tp As String
    Dim ds As New DataSet
    Sub EncheCombos()
        Dim conn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        Dim sql As String
        sql = "Select * From FormaPgto"




        Try
            Conn.Open()
            Dim oDA As New OleDbDataAdapter(sql, conn)

            oDA.Fill(ds, "Pgto")

        Catch ex As Exception

            Throw ex
        Finally
            Conn.Close()
        End Try

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        'Area destinada para as validacoes
        If Me.CboFormaPagamento.Text = "" Then
            MsgBox("O tipo da Forma de Pagamento não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.CboFormaPagamento.Focus()
            Exit Sub
        End If


        Dim Conn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        Select Case Operation
            Case INS
                Conn.Open()


                Dim Sql As String = "INSERT INTO AnexarForma (Tp_Codigo,Fp_Codigo,Desconto,Acrescimo) VALUES (?,?,?,?)"
                Dim cmd As New OleDb.OleDbCommand(Sql, Conn)

                cmd.Parameters.Add(New OleDb.OleDbParameter("?", CInt(Me.codigoTipo.Text)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("?", CInt(Me.CboFormaPagamento.SelectedValue)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("?", CDbl(NzZero(Me.Desconto.Text))))
                cmd.Parameters.Add(New OleDb.OleDbParameter("?", CDbl(NzZero(Me.Acrescimo.Text))))


                Try
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "SELECT @@IDENTITY"
                    Me.CodigoAnexo.Text = cmd.ExecuteScalar.ToString

                    MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                    GerarLog(Me.Text, AçãoTP.Confirmou, Me.CboFormaPagamento.Text)
                    Conn.Close()
                    Me.Close()
                    Me.Dispose()

                Catch ex As Exception
                    Select Case Err.Number
                        Case 5
                            MsgBox("Essa Condição de Pagamento já foi cadastrado para o Tipo de Pagamento de Nº " & Me.codigoTipo.Text, 48, "Atenção")
                    End Select
                End Try
                Conn.Close()
            Case UPD
                Conn.Open()

                Dim Sql As String = "UPDATE AnexarForma SET  Acrescimo = ?, Desconto = ? Where CodigoAnexo = " & Me.CodigoAnexo.Text
                Dim cmd As New OleDb.OleDbCommand(Sql, Conn)

                cmd.Parameters.Add(New OleDb.OleDbParameter("?", Nz(Me.Acrescimo.Text, 1)))
                cmd.Parameters.Add(New OleDb.OleDbParameter("?", Nz(Me.Desconto.Text, 1)))
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                    GerarLog(Me.Text, AçãoTP.Editou, Me.CboFormaPagamento.Text)
                    Operation = UPD
                Catch x As Exception
                    MsgBox(x.Message)
                    Exit Sub
                End Try
                Conn.Close()
        End Select

     
    End Sub
    Sub localizar()
        Dim Conn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Conn.Open()
        Dim Sql As String = "SELECT AnexarForma.CodigoAnexo, AnexarForma.Desconto, AnexarForma.Acrescimo, FormaPgto.Descrição FROM AnexarForma INNER JOIN FormaPgto ON AnexarForma.Fp_Codigo = FormaPgto.CodFormaPgto WHERE CodigoAnexo=" & Me.CodigoAnexo.Text & " order by FormaPgto.Descrição"

        Dim ocmd As New OleDb.OleDbCommand(Sql, Conn)
        Dim odr As OleDb.OleDbDataReader

        odr = ocmd.ExecuteReader
        odr.Read()
        If odr.HasRows Then
            Me.CboFormaPagamento.Text = odr("Descrição")
            Me.Desconto.Text = FormatNumber(odr("desconto"), 2)
            Me.Acrescimo.Text = FormatNumber(odr("acrescimo"), 2)

        End If
        Conn.Close()

    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Operation = UPD Then
            Me.CodigoAnexo.Text = My.Forms.TipoFormaPgto.mySel
            localizar()
            Me.CboFormaPagamento.Enabled = False
            Exit Sub
        End If

        Me.codigoTipo.Text = TipoFormaPgto.NomeStr
        EncheCombos()
        Me.CboFormaPagamento.DataSource = ds.Tables("Pgto")
        Me.CboFormaPagamento.DisplayMember = "Descrição"
        Me.CboFormaPagamento.ValueMember = "CodFormaPgto"
        Me.CboFormaPagamento.SelectedValue = -1
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class