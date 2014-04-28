Public Class CompraXmlProdutoImportar


    Public CnpjEmitenteVar As String
    Public Property CnpjEmitente() As String
        Get
            Return CnpjEmitenteVar
        End Get
        Set(ByVal Value As String)
            CnpjEmitenteVar = Value
        End Set
    End Property

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click

        Dim QtdLinhas As Integer = 0

        For i As Integer = 0 To ListaItens.Rows.Count - 1
            If IsDBNull(ListaItens.Rows(i).Cells("cProdERP").Value) Then
                QtdLinhas += 1
            End If
        Next

        If QtdLinhas > 0 Then
            MessageBox.Show("Existe produtos que não foi criado relação com os produtos do ERP, os itens serão cancelados", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            My.Forms.Compra.ItensErrado = QtdLinhas
        End If

        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub CompraXmlProdutoImportar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Forms.Compra.TbIT.DefaultView.Sort = Nothing
        Me.ListaItens.DataSource = My.Forms.Compra.TbIT.DefaultView


        Dim i As Integer

        For i = 0 To ListaItens.ColumnCount - 1

            If ListaItens.Columns(i).Name = "ccProd" Or ListaItens.Columns(i).Name = "cxProd" Or _
                ListaItens.Columns(i).Name = "cuCom" Or ListaItens.Columns(i).Name = "cqCom" Or ListaItens.Columns(i).Name = "cvProd" Or _
                ListaItens.Columns(i).Name = "cvUnCom" Or ListaItens.Columns(i).Name = "cDetalhe" Or ListaItens.Columns(i).Name = "cCFOP" _
                Or ListaItens.Columns(i).Name = "cCFOPe" Or ListaItens.Columns(i).Name = "cCTB" Or ListaItens.Columns(i).Name = "cProdERP" _
                Or ListaItens.Columns(i).Name = "cdet" Then

                ListaItens.Columns(i).Visible = True
            Else
                ListaItens.Columns(i).Visible = False
            End If

        Next

    End Sub

    Private Sub btSalvarCodERP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvarCodERP.Click

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = String.Empty
        Dim cmd As OleDb.OleDbCommand
        Dim Dr As OleDb.OleDbDataReader



        Dim Add As Boolean = False

        Try
            For Each row As DataGridViewRow In Me.ListaItens.Rows


                Dim CodProd As String = Aplic(row.Cells("ccProd").Value)


                Sql = "Select * from prodEmit Where CNPJemit = '" & CnpjEmitenteVar & "' And ProdEmit = " & CodProd
                cmd = New OleDb.OleDbCommand(Sql, CNN)
                Dr = cmd.ExecuteReader
                Dr.Read()
                If Dr.HasRows Then
                    Add = False
                Else
                    Add = True
                End If
                Dr.Close()

                If Add = True Then
                    Sql = "Insert Into prodEmit (CNPJemit, ProdEmit, ProdErp) Values (@CNPJemit, @ProdEmit, @ProdErp)"
                    cmd = New OleDb.OleDbCommand(Sql, CNN)

                    cmd.Parameters.Add(New OleDb.OleDbParameter("@CNPJemit", CnpjEmitenteVar))
                    cmd.Parameters.Add(New OleDb.OleDbParameter("@ProdEmit", Nz(row.Cells("ccProd").Value, 1)))
                    cmd.Parameters.Add(New OleDb.OleDbParameter("@ProdErp", Nz(row.Cells("cProdErp").Value, 1)))
                    cmd.ExecuteNonQuery()
                Else
                    Sql = "Update prodEmit set ProdErp = @ProdErp Where CNPJemit = '" & CnpjEmitenteVar & "' And ProdEmit = " & CodProd
                    cmd = New OleDb.OleDbCommand(Sql, CNN)

                    cmd.Parameters.Add(New OleDb.OleDbParameter("@ProdErp", Nz(row.Cells("cProdErp").Value, 1)))
                    cmd.ExecuteNonQuery()
                End If

            Next row
            MessageBox.Show("Registros Atualizado.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CNN.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    'faz a tratativa com aspas simples no meio do texto, criada pelo beto
    Public Function Aplic(ByVal strTexto As String) As String
        If InStr(strTexto, Chr(39)) Then
            Aplic = Chr(39) & Replace(strTexto, Chr(39), Chr(39) & Chr(39)) &
                    Chr(39)
        Else
            Aplic = Chr(39) & strTexto & Chr(39)
        End If
    End Function
End Class