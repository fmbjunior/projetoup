Imports System.Data.OleDb

Public Class ObjetoLocalizar
    Dim erro As Integer
    Private Sub ObjetoLocalizar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Forms.PedidoOS.Visible = True Then
            Me.txtProcura.ReadOnly = True
            Me.txtProcura.Visible = False
            ' LocalizaDados()
        Else
            Me.txtProcura.Visible = True
            Me.txtProcura.ReadOnly = False
            Me.txtProcura.Focus()
        End If

        EncheLabelObjeto(Me)
    End Sub
    Public Sub LocalizaDados(IdCliente As Integer)
        Try

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

            CNN.Open()

            Dim sql As String

            If My.Forms.PedidoOS.Visible = True Then
                'sql = "SELECT ObjetosCad.CodObjeto, ObjetosCad.codigoCliente, Clientes.Nome, ObjetosCad.Veiculo, ObjetosCad.Placa, ObjetosCad.DataCadastro FROM ObjetosCad INNER JOIN Clientes ON ObjetosCad.codigoCliente = Clientes.Codigo WHERE (((ObjetosCad.codigoCliente) =" & PedidoOS.CódigoCliente.Text & "));"
                sql = "SELECT ObjetosCad.CodObjeto, ObjetosCad.Veiculo, ObjetosCad.Placa, ObjetosCad.codigoCliente, Clientes.Nome, ObjetosCad.DataCadastro FROM ObjetosCad INNER JOIN Clientes ON ObjetosCad.codigoCliente = Clientes.Codigo WHERE (((ObjetosCad.codigoCliente) =" & PedidoOS.CódigoCliente.Text & "));"
            Else
                'sql = "SELECT ObjetosCad.CodObjeto, ObjetosCad.codigoCliente, Clientes.Nome, ObjetosCad.Veiculo, ObjetosCad.Placa, ObjetosCad.DataCadastro FROM ObjetosCad INNER JOIN Clientes ON ObjetosCad.codigoCliente = Clientes.Codigo WHERE (((Clientes.Nome) Like '%" & Me.txtprocura.Text & "%'));"
                sql = "SELECT ObjetosCad.CodObjeto, ObjetosCad.Veiculo, ObjetosCad.Placa, ObjetosCad.codigoCliente, Clientes.Nome,ObjetosCad.DataCadastro FROM ObjetosCad INNER JOIN Clientes ON ObjetosCad.codigoCliente = Clientes.Codigo WHERE (((ObjetosCad.codigoCliente) =" & IdCliente & "));"
            End If


            Dim CMD As New OleDb.OleDbCommand(sql, CNN)
            Dim Da As New OleDb.OleDbDataAdapter(CMD)

            Dim ds As New DataSet
            Da.Fill(ds, "Table")

            Me.DgvItem.DataSource = ds.Tables("Table").DefaultView

            Da.Dispose()
            CNN.Close()


        Catch oE As System.Exception
            Select Case Err.Number
                Case 5
                    MsgBox("Veículo não cadastrado no sistema", MsgBoxStyle.Critical, "Atenção")
                Case Else
                    MsgBox(oE.Message)
            End Select
        End Try
    End Sub


    Private Sub DgvItem_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvItem.CellDoubleClick
        Dim xRet
        xRet = Me.DgvItem.CurrentRow.Cells(0).Value

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String

        Sql = "SELECT *  From ObjetosCad Where CodObjeto =" & xRet


        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader
        Try
            CNN.Open()
            DR = CMD.ExecuteReader
            DR.Read()

            If DR.HasRows Then
                If My.Forms.PedidoOS.Visible = False Then
                    With My.Forms.ObjetosCad
                        .CodObjeto.Text = DR.Item("CodObjeto")
                        .Veiculo.Text = DR.Item("Veiculo") & ""
                        .placa.Text = DR.Item("placa") & ""
                        .km.Text = DR.Item("km") & ""
                        .cor.Text = DR.Item("cor") & ""
                        .obs.Text = DR.Item("obs") & ""
                        .DataCadastro.Text = DR.Item("Datacadastro") & ""
                        .renavan.Text = DR.Item("Renavan") & ""
                        .CódigoCliente.Text = Me.DgvItem.CurrentRow.Cells("idCliente").Value
                        .NomeCliente.Text = Me.DgvItem.CurrentRow.Cells("Nome").Value
                    End With
                Else
                    With My.Forms.PedidoOS
                        .codigoObjeto.Text = DR.Item("CodObjeto")
                        .Veiculo.Text = DR.Item("Veiculo") & ""
                        .Placa.Text = DR.Item("placa") & ""
                        .km.Text = DR.Item("km") & ""
                        .obs.Text = DR.Item("obs") & ""
                    End With
                End If
            End If

            DR.Close()
            CNN.Close()
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            Throw ex
        Finally
            CNN.Close()
        End Try
    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub placa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Private Sub txtprocura_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    LocalizaDados()
    'End Sub


    Private Sub TxtProcura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProcura.Leave
    End Sub


    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged, A3a.CheckedChanged, A5.CheckedChanged
        If Me.A1.Checked = True Then
            Me.txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
            Me.txtProcura.Clear()
            Me.txtProcura.Focus()
        End If
        If Me.A2.Checked = True Then
            Me.txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
            Me.txtProcura.Clear()
            Me.txtProcura.Focus()
        End If
        If Me.A3.Checked = True Then
            Me.txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Cpf
            Me.txtProcura.Clear()
            Me.txtProcura.Focus()
        End If
        If Me.A3a.Checked = True Then
            Me.txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Cnpj
            Me.txtProcura.Clear()
            Me.txtProcura.Focus()
        End If
        If Me.A5.Checked = True Then
            Me.txtProcura.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
            Me.txtProcura.Clear()
            Me.txtProcura.Focus()
        End If
    End Sub



    Private Sub BuscarCliente(ByVal Opt As String)

        Dim Cnn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Select Case Opt
            Case 1
                Sql = "Select Clientes.Codigo, Clientes.Nome, Clientes.NomeFantasia, Clientes.CpfCgc, Clientes.Cidade,Clientes.Endereço,Clientes.PessoaContato,Clientes.Celular,Clientes.Telefone,Clientes.MotivoBloqueado,Clientes.Bloqueado,Clientes.VendaCrediario,Clientes.VendaCheque,Clientes.VendaVista from Clientes  Where Clientes.Empresa = " & CodEmpresa & " And Codigo = " & Me.txtProcura.Text & " and Clientes.Inativo = False Order by Clientes.Nome"
            Case 2
                Sql = "Select Clientes.Codigo, Clientes.Nome, Clientes.NomeFantasia, Clientes.CpfCgc, Clientes.Cidade,Clientes.Endereço,Clientes.PessoaContato,Clientes.Celular,Clientes.Telefone,Clientes.MotivoBloqueado,Clientes.Bloqueado,Clientes.VendaCrediario,Clientes.VendaCheque,Clientes.VendaVista from Clientes  Where Clientes.Empresa = " & CodEmpresa & " And Nome like '%" & Me.txtProcura.Text & "%'  and Clientes.Inativo = False Order by Clientes.Nome"
            Case 3
                Sql = "Select Clientes.Codigo, Clientes.Nome, Clientes.NomeFantasia, Clientes.CpfCgc, Clientes.Cidade from Clientes  Where Clientes.Empresa = " & CodEmpresa & " And CpfCgc like '%" & Me.txtProcura.Text & "%'  and Clientes.Inativo = False Order by Clientes.Nome"
            Case 4
                Sql = "Select Clientes.Codigo, Clientes.Nome, Clientes.NomeFantasia, Clientes.CpfCgc, Clientes.Cidade from Clientes  Where Clientes.Empresa = " & CodEmpresa & " And Inativo = False Order by Clientes.Nome"
            Case 5
                Sql = "Select Clientes.Codigo, Clientes.Nome, Clientes.NomeFantasia, Clientes.CpfCgc, Clientes.Cidade from Clientes  Where Clientes.Empresa = " & CodEmpresa & " And NomeFantasia like '%" & Me.txtProcura.Text & "%'  and Clientes.Inativo = False Order by Clientes.NomeFantasia"
        End Select

        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Table")

        Me.Lista.DataSource = ds.Tables("Table").DefaultView

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub txtProcura_TextChanged(sender As Object, e As EventArgs) Handles txtProcura.TextChanged
        If Me.txtProcura.Text = "" Then
            Exit Sub
        End If

        If Me.A1.Checked = True Then BuscarCliente(1)
        If Me.A2.Checked = True Then BuscarCliente(2)
        If Me.A3.Checked = True Then BuscarCliente(3)
        If Me.A3a.Checked = True Then BuscarCliente(3)
        If Me.A5.Checked = True Then BuscarCliente(5)

    End Sub

    Private Sub A4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A4.CheckedChanged
        BuscarCliente(4)
    End Sub



    Private Sub Lista_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lista.SelectionChanged
        Try
            Dim vID As Integer
            vID = CInt(NzZero(Me.Lista.CurrentRow.Cells("cCodigo").Value))

            LocalizaDados(vID)



        Catch ex As Exception
        End Try
    End Sub

    Private Sub Lista_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Lista.CellDoubleClick
        MessageBox.Show("Favor selecionar um objeto", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Exit Sub
    End Sub
End Class