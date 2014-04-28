Public Class EstoqueFabrica

    Dim Cnn As New OleDb.OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)

    Private Sub EncheListaProdutos()
        MyLista.Items.Clear()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM Produtos WHERE Empresa = " & CodEmpresa & " and  Inativo = false and ProdutoIndustria = True"
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader
            Dim Zebrar As Boolean = True

            While DataReader.Read
                If Not IsDBNull(DataReader.Item("CodigoProduto")) Then
                    Dim AA As String = DataReader.Item("CodigoProduto")
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("Descrição") & "")
                    item1.SubItems.Add(Nz(DataReader.Item("EstPatio"), 3))
                    item1.SubItems.Add(Nz(DataReader.Item("EstEmpresa"), 3))
                    item1.SubItems.Add(Nz(DataReader.Item("EstEmpresaControlada"), 3))

                    MyLista.Items.AddRange(New ListViewItem() {item1})

                    If Zebrar = True Then
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    Else
                        MyLista.Items.Item(MyLista.Items.Count() - 1).BackColor = Color.MistyRose
                        Zebrar = True
                    End If
                End If
            End While

            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
        End Try


    End Sub

   
    Private Sub EstoqueFabrica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()

        Cnn.Open()
        EncheListaProdutos()
    End Sub

    
    Private Sub MyLista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyLista.SelectedIndexChanged
        Dim I As Integer = 0

        For I = 0 To MyLista.Items.Count - 1
            If MyLista.Items(I).Selected = True Then
                Me.Id.Text = MyLista.Items(I).Text.Substring(0)
                Me.Patio.Text = FormatNumber(MyLista.Items(I).SubItems(2).Text.Substring(0), 3)
                Me.Empresa.Text = FormatNumber(MyLista.Items(I).SubItems(3).Text.Substring(0), 3)
                Me.Controlada.Text = FormatNumber(MyLista.Items(I).SubItems(4).Text.Substring(0), 3)
            End If
        Next
        EncheListaCura()

    End Sub

    Private Sub EncheListaCura()

        Me.MyListaCura.Items.Clear()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT EstoqueEFocusFabrica.CodigoProduto, Sum(EstoqueEFocusFabrica.EstPatio) AS SomaDeEstPatio, EstoqueEFocusFabrica.DataProducao, -(Date()-[DataProducao]-16) AS [Dias Restantes] FROM(EstoqueEFocusFabrica) GROUP BY EstoqueEFocusFabrica.CodigoProduto, EstoqueEFocusFabrica.DataProducao, -(Date()-[DataProducao]-16) HAVING (((EstoqueEFocusFabrica.CodigoProduto)=" & Me.Id.Text & ") AND ((EstoqueEFocusFabrica.DataProducao) Is Not Null) AND ((-(Date()-[DataProducao]-16))>0));"
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader
            Dim Zebrar As Boolean = False
            Dim SomaQtd As Double
            While DataReader.Read
                If Not IsDBNull(DataReader.Item("CodigoProduto")) Then
                    Dim AA As String = FormatNumber(DataReader.Item("SomaDeEstPatio"), 3)
                    Dim item1 As New ListViewItem(AA, 0)

                    item1.SubItems.Add(DataReader.Item("DataProducao") & "")
                    item1.SubItems.Add(Nz(DataReader.Item("Dias Restantes"), 3))
                    MyListaCura.Items.AddRange(New ListViewItem() {item1})

                    If Zebrar = True Then
                        MyListaCura.Items.Item(MyListaCura.Items.Count() - 1).BackColor = Color.White
                        Zebrar = False
                    Else
                        MyListaCura.Items.Item(MyListaCura.Items.Count() - 1).BackColor = Color.Gold
                        Zebrar = True
                    End If

                    SomaQtd += Nz(DataReader.Item("SomaDeEstPatio"), 3)
                End If
            End While
            Me.Curando.Text = FormatNumber(SomaQtd, 3)
            DataReader.Close()

        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
        End Try


    End Sub

    Private Sub Degrade()
        Try
            Dim CCor() As String
            Dim corTemp As String

            corTemp = Cor1TelaPrimaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))

            corTemp = Cor2TelaPrimaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Cnn.Close()
        Me.Close()
        Me.Dispose()
    End Sub
End Class