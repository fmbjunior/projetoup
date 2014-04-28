Public Class ProdutosGrade

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2
    Const VAZ As Byte = 5

    Dim UltimoSeq As Boolean = False


    Private Sub EncheGrade()
        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = String.Empty

        Sql = "Select * From ProdutoGrade Where Produto = " & My.Forms.Produtos.CodigoProduto.Text & " Order by Sequencia"


        Dim da = New OleDb.OleDbDataAdapter(Sql, Cnn)
        Dim ds As New DataSet
        da.Fill(ds, "Grade")

        Me.GradeLista.DataSource = ds.Tables("Grade").DefaultView

        da.Dispose()
        Cnn.Close()

    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        If Me.Numero.Text = "" Then
            MsgBox("O Numero do produto não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.Numero.Focus()
            Exit Sub
        End If

        If Me.Sequencia.Text = "" Then
            MessageBox.Show("A sequência não pode ser nulo.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Sequencia.Focus()
            Exit Sub
        End If

        If Me.QtdEst.Text = "" Then Me.QtdEst.Text = FormatNumber(0, 2)

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        If Operation = INS Then

            Dim Sql As String = "INSERT INTO ProdutoGrade (Produto, Numero, QtdEst, Sequencia) VALUES (@1, @2, @3, @4)"

            Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

            cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(My.Forms.Produtos.CodigoProduto.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.Numero.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.QtdEst.Text, 1)))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.Sequencia.Text, 1)))

            Try
                cmd.ExecuteNonQuery()
                CNN.Close()
                EncheGrade()
                MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")

                ErroLivre = "Grade Adicionada com sucesso"
                GerarLog(Me.Text, AçãoTP.Livre, Me.Numero.Text)


                Me.Numero.Clear()
                Me.QtdEst.Clear()
                Me.Sequencia.Clear()
                Me.Numero.Focus()
            Catch ex As Exception
                If Err.Number = 5 Then
                    MessageBox.Show("O usuário esta tentado adicionar um registro duplicado, verifique...", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MsgBox(ex.Message, 64, "Validação de Dados")
                End If
            End Try


        End If

    End Sub

    Private Sub QtdEst_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QtdEst.Enter
        If Me.QtdEst.Text = "" Then
            Me.QtdEst.Text = FormatNumber(0, 4)
        End If
    End Sub

    Private Sub Sequencia_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sequencia.Enter
        If Me.Sequencia.Text = "" Then
            AchaUltimaSequencia()

            If Me.Sequencia.Text = 15 Then
                UltimoSeq = True
            End If

            If Me.Sequencia.Text > 15 Then
                Me.Numero.Clear()
                Me.QtdEst.Clear()
                Me.Sequencia.Clear()

                Me.Numero.Enabled = False
                Me.QtdEst.Enabled = False
                Me.Sequencia.Enabled = False
            End If
        End If
    End Sub

    Public Sub AchaUltimaSequencia()
        'Inserir ultimo registro
        Dim CNNSeq As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNNSeq.Open()

        Dim Cmd As New OleDb.OleDbCommand()
        Dim DataReader As OleDb.OleDbDataReader
        Dim Ult As Integer

        With Cmd
            .Connection = CNNSeq
            .CommandTimeout = 0
            .CommandText = "Select max(Sequencia) from ProdutoGrade Where Produto = " & My.Forms.Produtos.CodigoProduto.Text
            .CommandType = CommandType.Text
        End With

        Try
            DataReader = Cmd.ExecuteReader

            While DataReader.Read
                If Not IsDBNull(DataReader.Item(0)) Then
                    'Achou o iten procurado o iten as caixas serão preenchida
                    Ult = NzZero(DataReader.Item(0))
                End If
            End While
            DataReader.Close()
            CNNSeq.Close()
        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                CNNSeq.Close()
                Exit Sub
            End If
        End Try

        Me.Sequencia.Text = Ult + 1
        'fim inserir ultimo registro
    End Sub


    Private Sub ProdutosGrade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EncheGrade()
    End Sub

    Private Sub GradeLista_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GradeLista.KeyDown

        If e.KeyCode = Keys.Delete Then

            Dim vProd As String = String.Empty
            Dim vNum As String = String.Empty
            vProd = Me.GradeLista.CurrentRow.Cells("cProduto").Value
            vNum = Me.GradeLista.CurrentRow.Cells("cNumero").Value

            If vProd = "" Then
                MessageBox.Show("O usuário deve selecionar um numero", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


            Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            CNN.Open()

            Dim sql As String = "Select * from ItensPedido Where Numero = '" & vNum & "' and CodigoProduto = " & vProd
            Dim Cmd As New OleDb.OleDbCommand(sql, CNN)
            Dim DR As OleDb.OleDbDataReader

            DR = Cmd.ExecuteReader

            If Not DR.HasRows Then
                'Deleta o registo
                DR.Close()

                sql = "Delete * from ProdutoGrade Where Produto = " & vProd & " and Numero  = '" & vNum & "'"
                Cmd = New OleDb.OleDbCommand(sql, CNN)
                Try
                    If MessageBox.Show("Deseja Excluir a numeração", "Validação de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        Cmd.ExecuteNonQuery()
                        CNN.Close()
                        MessageBox.Show("Numeração excluida com sucesso.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        'GerarLog(Me.Text, AçãoTP.Excluiu, Me.cProduto.Text)
                        EncheGrade()
                    End If
                    Exit Sub
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            Else
                MessageBox.Show("Existe movimento para esta Numeração, operação cancelada.", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CNN.Close()
                Exit Sub


            End If

        End If

    End Sub
End Class