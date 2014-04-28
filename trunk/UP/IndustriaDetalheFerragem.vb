Imports System.IO
Public Class IndustriaDetalheFerragem

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Private Sub IndustriaDetalheFerragem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregaGrid()
    End Sub

    Private Sub CarregaGrid()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim Sql As String = String.Empty

        Sql = "SELECT * from IndustriaDetalheFerragem WHERE CodigoSubComposição = " & My.Forms.IndustriaSubComposição.CodigoSubComposição.Text & " Order by Posicao"


        Dim da = New OleDb.OleDbDataAdapter(Sql, CNN)
        da.SelectCommand.CommandType = CommandType.Text
        Dim ds As New DataSet
        da.Fill(ds, "DetalheFerragem")

        Me.TComprimento.Text = "Com. Total" & Chr(13) & FormatNumber(NzZero(ds.Tables("DetalheFerragem").Compute("Sum(CompTotal)", String.Empty).ToString), 2)
        Me.Tpeso.Text = "Peso Total" & Chr(13) & FormatNumber(NzZero(ds.Tables("DetalheFerragem").Compute("Sum(PesoTotal)", String.Empty).ToString), 2)

        Me.MyLista.DataSource = ds.Tables("DetalheFerragem").DefaultView

        da.Dispose()
        CNN.Close()


    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        If Me.MyLista.RowCount <> 0 Then

            Me.Cursor = Cursors.WaitCursor

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim ds As New DataSet()

            Dim Sql As String = String.Empty

            Sql = "SELECT IndustriaDetalheFerragem.CodigoSubComposição, IndustriaDetalheFerragem.Prod, Sum(IndustriaDetalheFerragem.PesoTotal) AS PesoSomado, Produtos.CustoMedio FROM IndustriaDetalheFerragem INNER JOIN Produtos ON IndustriaDetalheFerragem.Prod = Produtos.CodigoProduto GROUP BY IndustriaDetalheFerragem.CodigoSubComposição, IndustriaDetalheFerragem.Prod, Produtos.CustoMedio HAVING IndustriaDetalheFerragem.CodigoSubComposição = " & My.Forms.IndustriaSubComposição.CodigoSubComposição.Text
            Dim daDetalhe As New OleDb.OleDbDataAdapter(Sql, CNN)
            daDetalhe.Fill(ds, "Detalhe")

            Sql = "SELECT IndustriaSubComposiçãoItens.Id, IndustriaSubComposiçãoItens.SubComposição, IndustriaSubComposiçãoItens.CodigoMateriaPrima, IndustriaSubComposiçãoItens.Qtd, IndustriaSubComposiçãoItens.Unitario, IndustriaSubComposiçãoItens.Total FROM IndustriaSubComposiçãoItens WHERE IndustriaSubComposiçãoItens.SubComposição = " & My.Forms.IndustriaSubComposição.CodigoSubComposição.Text
            Dim daITENS As New OleDb.OleDbDataAdapter(Sql, CNN)
            daITENS.Fill(ds, "Itens")


            Dim DrDetalhe As DataRow
            For Each DrDetalhe In ds.Tables("Detalhe").Rows
                Dim DrItens() As DataRow
                DrItens = ds.Tables("Itens").Select("CodigoMateriaPrima = " & DrDetalhe("Prod").ToString)

                Dim TBL As DataTable
                TBL = ds.Tables("Itens")

                If DrItens.Length = 0 Then

                    Dim DRnovo As DataRow
                    DRnovo = TBL.NewRow()
                    'DRnovo("Id") = ""
                    DRnovo("SubComposição") = My.Forms.IndustriaSubComposição.CodigoSubComposição.Text
                    DRnovo("CodigoMateriaPrima") = DrDetalhe("Prod")
                    DRnovo("Qtd") = DrDetalhe("PesoSomado")
                    DRnovo("Unitario") = DrDetalhe("CustoMedio")
                    DRnovo("Total") = DrDetalhe("PesoSomado") * DrDetalhe("CustoMedio")
                    TBL.Rows.Add(DRnovo)

                Else
                    DrItens(0).BeginEdit()
                    DrItens(0)("Qtd") = DrDetalhe("PesoSomado")
                    DrItens(0)("Unitario") = DrDetalhe("CustoMedio")
                    DrItens(0)("Total") = DrDetalhe("PesoSomado") * DrDetalhe("CustoMedio")
                    DrItens(0).EndEdit()
                End If

            Next

            Dim objCommandBuilder As New OleDb.OleDbCommandBuilder(daITENS)
            daITENS.Update(ds, "Itens")

            daITENS.Dispose()
            ds.Dispose()
            CNN.Close()

            Me.Cursor = Cursors.Default
        End If


        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub NovoAdd()
        Operation = INS
        Me.Id.Clear()
        Me.Prod.Clear()
        Me.ProdDesc.Clear()
        Me.Posicao.Clear()
        Me.Bitola.Clear()
        Me.Qtd.Clear()
        Me.CompUnitario.Clear()
        Me.PesoMetro.Clear()
        Me.CompTotal.Clear()
        Me.PesoTotal.Clear()
        Me.Prod.Focus()
    End Sub



    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        'Area destinada para as validacoes
        If Me.Prod.Text = "" Then
            MsgBox("O Código da Matéria prima não foi informado, favor verificar.", 64, TituloMsgbox)
            Me.Prod.Focus()
            Exit Sub
        ElseIf Me.ProdDesc.Text = "" Then
            MsgBox("A Descrição da Matéria Prima não foi informado, favor verificar.", 64, TituloMsgbox)
            Me.ProdDesc.Focus()
            Exit Sub
        ElseIf Me.Posicao.Text = "" Then
            MsgBox("A Posição não foi informado, favor verificar.", 64, TituloMsgbox)
            Me.Posicao.Focus()
            Exit Sub
        ElseIf Me.Bitola.Text = "" Then
            MsgBox("A bitola não foi informado, favor verificar.", 64, TituloMsgbox)
            Me.Bitola.Focus()
            Exit Sub
        ElseIf Me.Qtd.Text = "" Then
            MsgBox("A Quantidade não foi informado, favor verificar.", 64, TituloMsgbox)
            Me.Qtd.Focus()
            Exit Sub
        ElseIf Me.CompUnitario.Text = "" Then
            MsgBox("O Comprimento Unitário não foi informado, favor verificar.", 64, TituloMsgbox)
            Me.CompUnitario.Focus()
            Exit Sub
        ElseIf Me.PesoMetro.Text = "" Then
            MsgBox("O peso não foi informado, favor verificar.", 64, TituloMsgbox)
            Me.PesoMetro.Focus()
            Exit Sub
        ElseIf Me.CompTotal.Text = "" Then
            MsgBox("O Comprimento Total não foi informado, favor verificar.", 64, TituloMsgbox)
            Me.CompTotal.Focus()
            Exit Sub
        End If
        'Fim da Area destinada para as validacoes

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

        If Operation = INS Then
            CNN.Open()

            UltimoReg()
            Dim Sql As String = "INSERT INTO IndustriaDetalheFerragem (Id, CodigoSubComposição, Prod, ProdDesc, Posicao, Bitola, Qtd, CompUnitario, PesoMetro, CompTotal, PesoTotal) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11)"
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Id.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(My.Forms.IndustriaSubComposição.CodigoSubComposição.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.Prod.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.ProdDesc.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.Posicao.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.Bitola.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Qtd.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", NzZero(Me.CompUnitario.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzZero(Me.PesoMetro.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", NzZero(Me.CompTotal.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", NzZero(Me.PesoTotal.Text)))


            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                CarregaGrid()
                Operation = INS
                NovoAdd()
            Catch ex As Exception
                CNN.Close()
                MsgBox(ex.Message, 64, TituloMsgbox)
            End Try


        ElseIf Operation = UPD Then
            CNN.Open()

            Dim Sql As String = "Update IndustriaDetalheFerragem set CodigoSubComposição = @2, Prod = @3, ProdDesc = @4, Posicao = @5, Bitola = @6, Qtd = @7, CompUnitario = @8, PesoMetro = @9, CompTotal = @10, PesoTotal = @11 Where Id = " & Me.Id.Text
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", My.Forms.IndustriaSubComposição.CodigoSubComposição.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Me.Prod.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Me.ProdDesc.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Me.Posicao.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Me.Bitola.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Me.Qtd.Text))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@8", NzZero(Me.CompUnitario.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@9", NzZero(Me.PesoMetro.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@10", NzZero(Me.CompTotal.Text)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@11", NzZero(Me.PesoTotal.Text)))


            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                CarregaGrid()
                NovoAdd()
            Catch x As Exception
                CNN.Close()
                MsgBox(x.Message)
                Exit Sub
            End Try

        End If

    End Sub


    Public Sub UltimoReg()
        'Inserir ultimo registro
        Dim Cnn As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer
        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "Select max(Id) from IndustriaDetalheFerragem"
            .CommandType = CommandType.Text
        End With
        Try
            Cnn.Open()
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
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

        Me.Id.Text = Ult + 1

    End Sub



    Private Sub Prod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Prod.KeyDown
        If e.KeyCode = Keys.F5 Then
            RetornoProcura = ""
            My.Forms.TelaProcuraMP.ShowDialog()
            If RetornoProcura <> "" Then
                Me.Prod.Text = RetornoProcura
            End If
        End If
    End Sub


    Public Sub LocalizaMateriaPrima()
        If Me.Prod.Text = "" Then
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from Produtos where CodigoProduto = " & Me.Prod.Text & " and Empresa = " & CodEmpresa & " and Tipo = 2"
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        Dim TextoSeparar As String = String.Empty
        Dim Palavras() As String

        If DR.HasRows Then
            TextoSeparar = DR.Item("Descrição")
            Palavras = TextoSeparar.Split(" ")

            Me.ProdDesc.Text = Palavras(0).ToString
            Me.Bitola.Text = Palavras(1).ToString
            Me.PesoMetro.Text = DR.Item("Peso") & ""

            DR.Close()
        Else
            MsgBox("Matéria Prima não cadastrado, Verifique.", 64, TituloMsgbox)
            DR.Close()
            Me.PesoMetro.Clear()
            Me.ProdDesc.Clear()
            Me.Prod.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub Prod_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Prod.Leave
        If String.CompareOrdinal(Me.Prod.Text, Me.Prod.TextoAntigo) Then
            LocalizaMateriaPrima()
        End If
    End Sub

    Private Sub CompInitario_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompUnitario.Leave
        Me.CompTotal.Text = NzZero(Me.CompUnitario.Text) * NzZero(Me.Qtd.Text)
        Me.PesoTotal.Text = (NzZero(Me.PesoMetro.Text) * NzZero(Me.CompTotal.Text)) / 100
    End Sub

    Private Sub MyLista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MyLista.CellDoubleClick
        RetornoProcura = String.Empty

        Dim vID As Integer
        vID = CInt(Me.MyLista.CurrentRow.Cells(0).Value)
        RetornoProcura = vID


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Select * from IndustriaDetalheFerragem where Id = " & vID
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then

            Me.Id.Text = DR.Item("Id") & ""
            Me.Prod.Text = DR.Item("Prod") & ""
            Me.ProdDesc.Text = DR.Item("ProdDesc") & ""
            Me.Posicao.Text = DR.Item("Posicao") & ""
            Me.Bitola.Text = DR.Item("Bitola") & ""
            Me.Qtd.Text = DR.Item("Qtd") & ""
            Me.CompUnitario.Text = DR.Item("CompUnitario")
            Me.CompTotal.Text = DR.Item("CompTotal")
            Me.PesoMetro.Text = FormatNumber(DR.Item("PesoMetro"), 4)
            Me.PesoTotal.Text = FormatNumber(DR.Item("PesoTotal"), 4)

            Me.Prod.Focus()

            DR.Close()
            Operation = UPD
        Else
            MsgBox("Matéria Prima não cadastrado, Verifique.", 64, TituloMsgbox)
            DR.Close()
            Me.Prod.Focus()
            Exit Sub
        End If


    End Sub

    Private Sub MyLista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyLista.KeyDown
        RetornoProcura = String.Empty

        If e.KeyCode = Keys.Delete Then
            Dim vID As Integer
            vID = CInt(Me.MyLista.CurrentRow.Cells(0).Value)
            RetornoProcura = vID

            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim Sql As String = "Delete * From IndustriaDetalheFerragem Where Id = " & vID
            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Registro excluido com sucesso.", TituloMsgbox, MessageBoxButtons.OK, MessageBoxIcon.Information)
            CNN.Close()
            CarregaGrid()
        End If
    End Sub

End Class