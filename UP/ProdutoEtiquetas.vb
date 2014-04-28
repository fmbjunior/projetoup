Imports System.Drawing.Printing

Public Class ProdutoEtiquetas
    Dim Crypto As New ClCrypto 'Para descriptografar a senha do banco de dados

    Private Sub ProdutoEtiquetas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim pkInstalledPrinters As String
        For Each pkInstalledPrinters In PrinterSettings.InstalledPrinters
            Impressora.Items.Add(pkInstalledPrinters)
        Next
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Produto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Produto.KeyDown
        If e.KeyCode = Keys.F5 Then
            RetornoProcura = ""
            Me.Produto.Clear()
            Me.ProdutoDesc.Clear()
            My.Forms.ProcuraProduto.ShowDialog()
        End If
    End Sub



    Private Sub ProcuraProduto()


        If Me.Produto.Text = "" Then
            Exit Sub
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()


        Dim Sql As String = "SELECT Produtos.* FROM Produtos WHERE Produtos.CodigoProduto = " & Me.Produto.Text


        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.Produto.Text = DR.Item("CodigoProduto") & ""
            Me.ProdutoDesc.Text = DR.Item("Descrição") & ""
            DR.Close()
        End If
        CNN.Close()

    End Sub


    Private Sub Produto_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Produto.Validated
        If String.CompareOrdinal(Me.Produto.Text, Me.Produto.TextoAntigo) Then
            ProcuraProduto()
        End If
    End Sub

    Private Sub btImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImprimir.Click

        If Me.A1.Checked = False And Me.A2.Checked = False Then
            MessageBox.Show("O usuário deve selecionar uma opção de impressão de Etiqueta", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.Impressora.Text = "" Then
            MessageBox.Show("O usuário deve selecionar uma impressora", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.A1.Checked = True Then

            If Me.Produto.Text = "" Then
                MessageBox.Show("Favor informar a Produto a ser impresso", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If NzZero(Me.Qtd.Text) = 0 Then
                MessageBox.Show("Favor informar a Quantidade de Etiquetas a serem impressas", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim MyReports As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            MyReports.Load(DirRelat & "RelEtiqueta3x6Zebra.rpt")

            Dim logOnInfo As New CrystalDecisions.Shared.TableLogOnInfo()
            Dim i As Integer
            For i = 0 To MyReports.Database.Tables.Count - 1
                logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                logOnInfo.ConnectionInfo.UserID = ""
                logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                MyReports.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
            Next i

            MyReports.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
            MyReports.PrintOptions.PrinterName = Me.Impressora.Text

            'Filtrar os dados
            Dim SelectFormula As String
            SelectFormula = "{Produtos.CodigoProduto} = " & Me.Produto.Text
            MyReports.RecordSelectionFormula = SelectFormula
            MyReports.PrintToPrinter(CInt(Me.Qtd.Text), False, 0, 0)

            Me.Produto.Clear()
            Me.ProdutoDesc.Clear()
            Me.Produto.Focus()
        End If

        If Me.A2.Checked = True Then

            If Me.CompraInterno.Text = "" Then
                MessageBox.Show("Favor informar o pedido de Compra.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


            Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
            Cnn.Open()

            Dim Sql As String = "SELECT * FROM ItensCompra WHERE ItensCompra.CompraInterno = " & Me.CompraInterno.Text

            Dim Cmd As New OleDb.OleDbCommand(Sql, Cnn)
            Dim DR As OleDb.OleDbDataReader


            Try

                DR = Cmd.ExecuteReader
                While DR.Read
                    If Not IsDBNull(DR.Item("CompraInterno")) Then



                        Dim MyReports As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
                        MyReports.Load(DirRelat & "RelEtiqueta3x6Zebra.rpt")

                        Dim logOnInfo As New CrystalDecisions.Shared.TableLogOnInfo()
                        Dim i As Integer
                        For i = 0 To MyReports.Database.Tables.Count - 1
                            logOnInfo.ConnectionInfo.ServerName = LocalBD & Nome_BD
                            logOnInfo.ConnectionInfo.DatabaseName = LocalBD & Nome_BD
                            logOnInfo.ConnectionInfo.UserID = ""
                            logOnInfo.ConnectionInfo.Password = Crypto.clsCrypto(SenhaBancoDados, False)
                            MyReports.Database.Tables.Item(i).ApplyLogOnInfo(logOnInfo)
                        Next i

                        MyReports.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Portrait
                        MyReports.PrintOptions.PrinterName = Me.Impressora.Text

                        'Filtrar os dados
                        Dim SelectFormula As String
                        SelectFormula = "{Produtos.CodigoProduto} = " & DR.Item("CodigoProduto")
                        MyReports.RecordSelectionFormula = SelectFormula
                        MyReports.PrintToPrinter(CInt(DR.Item("Qtd")), False, 0, 0)

                    End If
                End While

                DR.Close()
                Me.Cursor = Cursors.Default
                Cnn.Close()
                Me.CompraInterno.Focus()

            Catch Merror As System.Exception
                MsgBox(Merror.ToString)
                If ConnectionState.Open Then
                    Cnn.Close()
                    Exit Sub
                End If
            End Try


        End If


    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged

        If Me.A1.Checked = True Then
            Me.PainelProduto.Visible = True
            Me.PainelCompra.Visible = False
            Me.Impressora.Focus()
        End If

        If Me.A2.Checked = True Then
            Me.PainelProduto.Visible = False
            Me.PainelCompra.Visible = True
            Me.Impressora.Focus()
        End If

    End Sub
End Class