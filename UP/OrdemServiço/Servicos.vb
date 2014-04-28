Imports System.Drawing.Printing
Imports System.Drawing.Printing.PrinterSettings
Imports Microsoft.Win32
Imports System.IO
Imports System.Data.OleDb
Public Class Servicos


    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2
    Dim Tp As String

    Private Enum TpRetornoCBO
        Não = 0
        Sim = 1
    End Enum
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



        DesbloquearTextBox(Me, True)
        Me.cGrupoServico.SelectedValue = -1
        Me.codigoServico.Text = "0000"
        Me.descricao.Focus()
        Operation = INS



    End Sub

    Private Sub LocalizarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalizarBT.Click
        If Con = False Then
            MsgBox("O Usuário não tem permissão para Consultar registro, verifique com o Administrador.", 64, "Validação de Dados")
            Ação.Desbloquear_Controle(Me, False)
            Exit Sub
        End If


        My.Forms.ServicosProcura.ShowDialog()

    End Sub

    Public Sub LocalizaDados()

        If Con = False Then
            MsgBox("O Usuário não tem permissão para Consultar registro, verifique com o Administrador.", 64, "Validação de Dados")
            Ação.Desbloquear_Controle(Me, False)
            Exit Sub
        End If

        If Me.codigoServico.Text = "" Then
            Exit Sub
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim Sql As String = "SELECT * from Servicos WHERE Serv_Codigo=" & Me.codigoServico.Text


        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.codigoServico.Text = DR.Item("Serv_Codigo") & ""
            Me.descricao.Text = DR.Item("Serv_Descricao") & ""
            Me.ValorServico.Text = FormatCurrency(Nz(DR.Item("Serv_ValorServico"), 3), 2)
            Me.DescontoMaximo.Text = FormatNumber(NzZero(DR.Item("Serv_DescontoMaximo")), 2)
            Me.Referencia.Text = DR.Item("Serv_Referencia") & ""
            If NzZero(DR.Item("gruposervico")) = 0 Then
                Me.cGrupoServico.SelectedValue = -1
            Else
                Me.cGrupoServico.SelectedValue = NzZero(DR.Item("gruposervico"))
            End If
            DR.Close()
            Operation = UPD
        End If

    End Sub


    Private Sub EditarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBT.Click
        If Me.codigoServico.Text = "" Then
            MsgBox("Não existe Produto para ser editado.", 64, "Validação de Dados")
            Exit Sub
        End If
        If Edi = False Then
            MsgBox("O Usuário não tem permissão para editar o registro, verifique com o Administrador.", 64, "Validação de Dados")
            Ação.Desbloquear_Controle(Me, False)
            Exit Sub
        End If
        Operation = UPD
        Ação.Desbloquear_Controle(Me, True)
        Me.descricao.Focus()
    End Sub



    Private Sub ValorVenda_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ValorServico.Leave, DescontoMaximo.Leave
        If Me.ValorServico.Text <> "" Then Me.ValorServico.Text = FormatCurrency(Me.ValorServico.Text, 2)
    End Sub


    Private Sub SalvarBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvarBT.Click
        'Area destinada para as validacoes

        If Me.codigoServico.Text = "" Then
            MsgBox("O Código do produto não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.codigoServico.Focus()
            Exit Sub
        ElseIf Me.descricao.Text = "" Then
            MsgBox("A descrição do produto não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.descricao.Focus()
            Exit Sub
        ElseIf Me.cGrupoServico.SelectedValue = 0 Then
            MsgBox("O grupo do Serviço não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.descricao.Focus()
            Exit Sub
        End If


        If Me.ValorServico.Text = "" Then
            MsgBox("O valor de venda do produto não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.ValorServico.Focus()
            Exit Sub
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            If Adi = False Then
                MsgBox("O Usuário não tem permissão para adicionar o registro, verifique com o Administrador.", 64, "Validação de Dados")
                Exit Sub
            End If
            CNN.Open()


            Dim Sql As String = "INSERT INTO Servicos (Serv_Descricao, Serv_ValorServico,Serv_Referencia,empresa, GrupoServico, Serv_DescontoMaximo) VALUES (?,?,?,?,?,?)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("descricao", Nz(Me.descricao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("ValorServico", NzZero(Me.ValorServico.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("Referencia", Nz(Me.Referencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("empresa", CodEmpresa))
            cmd.Parameters.Add(New OleDb.OleDbParameter("Grupo", Me.cGrupoServico.SelectedValue))
            cmd.Parameters.Add(New OleDb.OleDbParameter("DescontoMaximo", NzZero(Me.DescontoMaximo.Text)))

            Try
                cmd.ExecuteNonQuery()
                cmd.CommandText = "SELECT @@IDENTITY"
                Me.codigoServico.Text = cmd.ExecuteScalar.ToString

                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Adicionou, Me.codigoServico.Text)

                DesbloquearTextBox(Me, False)
                Operation = UPD
            Catch ex As Exception
                MsgBox(ex.Message, 64, "Validação de Dados")
            End Try
            CNN.Close()

        ElseIf Operation = UPD Then
            If Edi = False Then
                MsgBox("O Usuário não tem permissão para editar o registro, verifique com o Administrador.", 64, "Validação de Dados")
                Exit Sub
            End If

            CNN.Open()

            Dim Sql As String = "UPDATE Servicos SET  Serv_Descricao = ?, Serv_ValorServico=?, Serv_Referencia=?, gruposervico=?,Serv_DescontoMaximo=? Where Serv_Codigo = " & Me.codigoServico.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)


            cmd.Parameters.Add(New OleDb.OleDbParameter("Descricao", Nz(Me.descricao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("valorservico", NzZero(Me.ValorServico.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("referencia", Nz(Me.Referencia.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("grupo", Me.cGrupoServico.SelectedValue))
            cmd.Parameters.Add(New OleDb.OleDbParameter("DescontoMaximo", NzZero(Me.DescontoMaximo.Text)))
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
                GerarLog(Me.Text, AçãoTP.Editou, Me.codigoServico.Text)
                Operation = UPD
            Catch x As Exception
                MsgBox(x.Message)
                Exit Sub
            End Try
            ' Ação.Desbloquear_Controle(Me, False)
            DesbloquearTextBox(Me, False)
            CNN.Close()
        End If

    End Sub


    Private Sub CodigoProduto_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles codigoServico.Validating
        If Me.codigoServico.Text <> "0000" Then
            LocalizaDados()
        End If
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
            .CommandText = "SELECT Max(Produtos.CodigoProduto) AS MáxDeCodigoProduto FROM(Produtos)"
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

        Me.codigoServico.Text = Ult + 1
        'fim inserir ultimo registro

    End Sub
    Private Sub Servicos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        EncheCombo()
    End Sub
    Private Sub EncheCombo()
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim sqlG As String
        Dim ds As New DataSet
      
        sqlG = "Select * From GrupoServico"
        Try
            Cnn.Open()
            Dim daG As New OleDbDataAdapter(sqlG, Cnn)

            daG.Fill(ds, "gServico")
            Me.cGrupoServico.DataSource = ds.Tables("gServico")
            Me.cGrupoServico.DisplayMember = "gDescricao"
            Me.cGrupoServico.ValueMember = "gID"
            Me.cGrupoServico.SelectedValue = -1
        Catch ex As Exception
            Throw ex
        Finally
            Cnn.Close()
        End Try

    End Sub

    Private Function PegaVlrCombo(ByVal Cbo As CBOAutoCompleteFocus.CboFocus, ByVal Retorna_Descrição As TpRetornoCBO)

        Dim Retorno As String = ""
        If Cbo.Text = "" Then
            Retorno = ""
        Else
            Cbo.SelectedIndex = Cbo.FindStringExact(Cbo.Text & "")
            If Retorna_Descrição = TpRetornoCBO.Não Then
                Retorno = CType(Cbo.SelectedItem, cboItemData).ItemData
            Else
                Retorno = CType(Cbo.SelectedItem, cboItemData).Name
            End If
        End If
        Return Retorno

    End Function
  
    Private Sub Referencia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Referencia.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            Me.ValorServico.Focus()
        End If

    End Sub

    Private Sub ExcluirBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirBT.Click
        '    Dim sql As String

        '    sql = "Select Sv_CodigoServico from FuncionarioServicoDetalhe where ProdID=" & xID
        '    Dim conn As New OleDbConnection
        '    Dim DR As OleDbDataReader
        '    Try
        '        conn = db.AbreBanco()
        '        Dim cmd As New OleDbCommand(sql, conn)
        '        DR = cmd.ExecuteReader
        '        DR.Read()

        '        My.Forms.Produto.txtCodigo.Text = DR.Item("Prodid")
        '        My.Forms.Produto.txtCodigoFabrica.Text = DR.Item("prodcodigofabrica") & ""
        '        My.Forms.Produto.txtCodigoOriginal.Text = DR.Item("prodcodigooriginal") & ""
        '        My.Forms.Produto.txtLocal.Text = DR.Item("prodlocal") & ""
        '        My.Forms.Produto.txtDescricao.Text = DR.Item("proddescricao") & ""
        '        My.Forms.Produto.txtUnidade.Text = NzNull(DR.Item("ProdUnidade"))
        '        My.Forms.Produto.txtValorCompra.Text = FormatNumber(DR.Item("prodvalorcompra"), 2)
        '        My.Forms.Produto.txtValorVenda.Text = FormatNumber(DR.Item("prodValorvenda"), 2)
        '        My.Forms.Produto.txtEstoque.Text = FormatNumber(DR.Item("prodqtdestoque"), 4)
        '        My.Forms.Produto.txtDataUltimaVenda.Text = DR.Item("prodDataUltimaVenda") & ""
        '        My.Forms.Produto.txtDataUltimaCompra.Text = DR.Item("prodDataUltimacompra") & ""
        '        My.Forms.Produto.ativo.Checked = DR.Item("prodativo")
        '    Catch ex As Exception
        '        Throw ex
        '    Finally
        '        db.fechabanco(conn)
        '    End Try

    End Sub
End Class