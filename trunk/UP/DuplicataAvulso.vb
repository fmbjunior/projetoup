Public Class DuplicataAvulso

    Dim Ação As New TrfGerais()
    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2
    Dim Tp As String
    Dim clsDuplicata As New clsDuplicataAvulso
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub butNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butNovo.Click
        Ação.LimpaTextBox(Me)
        Ação.Desbloquear_Controle(Me, True)
        Me.txtValor1.ReadOnly = True
        Me.txtValor2.ReadOnly = True
        Me.txtValor3.ReadOnly = True
        Me.txtValor4.ReadOnly = True
        Me.txtVenc1.ReadOnly = True
        Me.txtVenc2.ReadOnly = True
        Me.txtVenc3.ReadOnly = True
        Me.txtVenc4.ReadOnly = True
        Me.txtCodigoCliente.Focus()
        Operation = INS
    End Sub

    Private Sub btClienteFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClienteFind.Click
        My.Forms.ClientesProcura.ShowDialog()
        LocalizaDadosCliente()
    End Sub
    Public Sub LocalizaDadosCliente()

        If Me.txtCodigoCliente.Text = "" Then
            Exit Sub
        End If

        Dim CnnFind As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CnnFind.Open()

        Dim Sql As String = "Select * from Clientes where Codigo = " & Me.txtCodigoCliente.Text
        Dim CMD As New OleDb.OleDbCommand(Sql, CnnFind)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then

            Me.txtNomeCliente.Text = DR.Item("Nome") & ""
        Else
            MessageBox.Show("Cliente não localizado, Verifique.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtCodigoCliente.Clear()
            Me.txtNomeCliente.Clear()
            Me.txtCodigoCliente.Focus()
        End If

        DR.Close()
        CnnFind.Close()

    End Sub

    Private Sub butSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSalvar.Click
        'Area destinada para as validacoes

        If Me.txtCodigoCliente.Text = "" Then
            MsgBox("O Código do Cliente não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.txtCodigoCliente.Focus()
            Exit Sub
        ElseIf Me.txtNotaFiscal.Text = "" Then
            MsgBox("A Nota fiscal não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.txtNotaFiscal.Focus()
            Exit Sub
        End If


        If Me.txtParcelas.Text = "" Then
            MsgBox("A Parcela  não foi informado, favor verificar.", 64, "Validação de Dados")
            Me.txtParcelas.Focus()
            Exit Sub
        End If

        With clsDuplicata
            .CodigoCliente = Nz(Me.txtCodigoCliente.Text, 1)
            .NumeroDocumento = Nz(Me.txtDocumento.Text, 1)
            .NotaFiscal = Nz(Me.txtNotaFiscal.Text, 1)
            .DataEmissao = Nz(Me.txtDataEmissao.Text, 1)
            .Parcelas = Nz(Me.txtParcelas.Text, 1)
            .Venc1 = Nz(Me.txtVenc1.Text, 1)
            .Venc2 = Me.txtVenc2.Text & ""
            .Venc3 = Me.txtVenc3.Text & ""
            .Venc4 = Me.txtVenc4.Text & ""
            .Valor1 = NzZero(Me.txtValor1.Text)
            .Valor2 = NzZero(Me.txtValor2.Text)
            .Valor3 = NzZero(Me.txtValor3.Text)
            .Valor4 = NzZero(Me.txtValor4.Text)
        End With

        If Operation = INS Then
            clsDuplicata.Gravar()
            Me.txtCodigo.Text = clsDuplicata.UltimoRegistro
            Operation = UPD
        ElseIf Operation = UPD Then
            clsDuplicata.Editar(Me.txtCodigo.Text)
            Operation = UPD
            DesbloquearTextBox(Me, False)
        End If
        MessageBox.Show("Registro gravado com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        GerarLog(Me.Text, AçãoTP.Adicionou, Me.txtDocumento.Text)
    End Sub

    Private Sub txtParcelas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtParcelas.TextChanged
        If Len(txtParcelas.Text) = 0 Then
            Me.txtValor1.ReadOnly = True
            Me.txtValor2.ReadOnly = True
            Me.txtValor3.ReadOnly = True
            Me.txtValor4.ReadOnly = True
            Me.txtVenc1.ReadOnly = True
            Me.txtVenc2.ReadOnly = True
            Me.txtVenc3.ReadOnly = True
            Me.txtVenc4.ReadOnly = True

            Me.txtValor1.Clear()
            Me.txtValor2.Clear()
            Me.txtValor3.Clear()
            Me.txtValor4.Clear()
            Me.txtVenc1.Clear()
            Me.txtVenc2.Clear()
            Me.txtVenc3.Clear()
            Me.txtVenc4.Clear()
        End If

        If CDbl(NzZero(Me.txtParcelas.Text)) > 4 Then
            MessageBox.Show("O usuário só podera usar ate [4] parcelas.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Select Case txtParcelas.Text
            Case 1
                Me.txtValor1.ReadOnly = False
                Me.txtVenc1.ReadOnly = False
                Me.txtValor2.ReadOnly = True
                Me.txtVenc2.ReadOnly = True
                Me.txtValor3.ReadOnly = True
                Me.txtVenc3.ReadOnly = True
                Me.txtValor4.ReadOnly = True
                Me.txtVenc4.ReadOnly = True
                Me.txtValor2.Clear()
                Me.txtValor3.Clear()
                Me.txtValor4.Clear()
                Me.txtVenc2.Clear()
                Me.txtVenc3.Clear()
                Me.txtVenc4.Clear()
            Case 2
                Me.txtValor1.ReadOnly = False
                Me.txtVenc1.ReadOnly = False
                Me.txtValor2.ReadOnly = False
                Me.txtVenc2.ReadOnly = False
                Me.txtValor3.ReadOnly = True
                Me.txtVenc3.ReadOnly = True
                Me.txtValor4.ReadOnly = True
                Me.txtVenc4.ReadOnly = True
                Me.txtValor3.Clear()
                Me.txtValor4.Clear()
                Me.txtVenc3.Clear()
                Me.txtVenc4.Clear()
            Case 3
                Me.txtValor1.ReadOnly = False
                Me.txtVenc1.ReadOnly = False
                Me.txtValor2.ReadOnly = False
                Me.txtVenc2.ReadOnly = False
                Me.txtValor3.ReadOnly = False
                Me.txtVenc3.ReadOnly = False
                Me.txtValor4.ReadOnly = True
                Me.txtVenc4.ReadOnly = True
                Me.txtValor4.Clear()
                Me.txtVenc4.Clear()
            Case 4
                Me.txtValor1.ReadOnly = False
                Me.txtVenc1.ReadOnly = False
                Me.txtValor2.ReadOnly = False
                Me.txtVenc2.ReadOnly = False
                Me.txtValor3.ReadOnly = False
                Me.txtVenc3.ReadOnly = False
                Me.txtValor4.ReadOnly = False
                Me.txtVenc4.ReadOnly = False
        End Select
    End Sub


    Private Sub txtCodigoCliente_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoCliente.Leave
        LocalizaDadosCliente()
    End Sub
    Sub verificarParcela()
        Select Case txtParcelas.Text
            Case 1
                Me.txtValor1.ReadOnly = False
                Me.txtVenc1.ReadOnly = False
                Me.txtValor2.ReadOnly = True
                Me.txtVenc2.ReadOnly = True
                Me.txtValor3.ReadOnly = True
                Me.txtVenc3.ReadOnly = True
                Me.txtValor4.ReadOnly = True
                Me.txtVenc4.ReadOnly = True
                Me.txtValor2.Clear()
                Me.txtValor3.Clear()
                Me.txtValor4.Clear()
                Me.txtVenc2.Clear()
                Me.txtVenc3.Clear()
                Me.txtVenc4.Clear()
            Case 2
                Me.txtValor1.ReadOnly = False
                Me.txtVenc1.ReadOnly = False
                Me.txtValor2.ReadOnly = False
                Me.txtVenc2.ReadOnly = False
                Me.txtValor3.ReadOnly = True
                Me.txtVenc3.ReadOnly = True
                Me.txtValor4.ReadOnly = True
                Me.txtVenc4.ReadOnly = True
                Me.txtValor3.Clear()
                Me.txtValor4.Clear()
                Me.txtVenc3.Clear()
                Me.txtVenc4.Clear()
            Case 3
                Me.txtValor1.ReadOnly = False
                Me.txtVenc1.ReadOnly = False
                Me.txtValor2.ReadOnly = False
                Me.txtVenc2.ReadOnly = False
                Me.txtValor3.ReadOnly = False
                Me.txtVenc3.ReadOnly = False
                Me.txtValor4.ReadOnly = True
                Me.txtVenc4.ReadOnly = True
                Me.txtValor4.Clear()
                Me.txtVenc4.Clear()
            Case 4
                Me.txtValor1.ReadOnly = False
                Me.txtVenc1.ReadOnly = False
                Me.txtValor2.ReadOnly = False
                Me.txtVenc2.ReadOnly = False
                Me.txtValor3.ReadOnly = False
                Me.txtVenc3.ReadOnly = False
                Me.txtValor4.ReadOnly = False
                Me.txtVenc4.ReadOnly = False
        End Select
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If Me.txtCodigo.Text = "" Then
            MsgBox("Não existe Arquivo para ser editado.", 64, "Validação de Dados")
            Exit Sub
        End If
        Operation = UPD
        Ação.Desbloquear_Controle(Me, True)
        txtCodigoCliente.Focus()
        verificarParcela()
    End Sub

    Private Sub butImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butImprimir.Click

        If Len(Me.txtCodigo.Text) = 0 Then
            MsgBox("Documento ainda não foi salvo", 48, "Atenção")
            Exit Sub
        End If

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))


        ' Uma base de testes...
        Dim dt As New DataTable

        dt.Columns.Add("CodigoCliente", GetType(Integer))
        dt.Columns.Add("NumeroDocumento", GetType(String))
        dt.Columns.Add("NF", GetType(String))
        dt.Columns.Add("DataEmissao", GetType(Date))
        dt.Columns.Add("DataString", GetType(String))
        dt.Columns.Add("Vencimento", GetType(String))
        dt.Columns.Add("Valor", GetType(String))
        dt.Columns.Add("Parcela", GetType(Single))
        dt.Columns.Add("cnpjcpf", GetType(String))
        dt.Columns.Add("inscricao", GetType(String))
        dt.Columns.Add("nome", GetType(String))
        dt.Columns.Add("endereco", GetType(String))
        dt.Columns.Add("Bairro", GetType(String))
        dt.Columns.Add("nro", GetType(String))
        dt.Columns.Add("cidade", GetType(String))
        dt.Columns.Add("estado", GetType(String))
        dt.Columns.Add("Cep", GetType(String))
        dt.Columns.Add("EmpresaRazao", GetType(String))
        dt.Columns.Add("EmpresaCnpj", GetType(String))
        dt.Columns.Add("EmpresaIE", GetType(String))
        dt.Columns.Add("EmpresaEndereco", GetType(String))
        dt.Columns.Add("EmpresaTelefone", GetType(String))
       


        Dim i As Integer
        Dim DS As New DataSet
        DS.Tables.Add(dt)

        Try
            CNN.Open()
            Dim SqlCliente, sqlEmpresa As String
            SqlCliente = "Select * from Clientes where Codigo=" & Me.txtCodigoCliente.Text
            sqlEmpresa = "Select * from Empresa"
            Dim oDA1 As New OleDb.OleDbDataAdapter(SqlCliente, CNN)
            Dim oDA2 As New OleDb.OleDbDataAdapter(sqlEmpresa, CNN)
            oDA1.Fill(DS, "Cliente")
            oDA2.Fill(DS, "Empresa")

            Dim objRow As Data.DataRow
            With DS.Tables("Table1")
                For i = 1 To Me.txtParcelas.Text

                    objRow = DS.Tables("Table1").NewRow
                    objRow("codigoCliente") = Me.txtCodigoCliente.Text
                    objRow("numeroDocumento") = Me.txtDocumento.Text
                    objRow("NF") = Me.txtNotaFiscal.Text
                    objRow("DataEmissao") = CDate(Me.txtDataEmissao.Text)
                    objRow("DataString") = "Dourados/MS, " & Format(CDate(Me.txtDataEmissao.Text), "M") & " de " & Format(CDate(Me.txtDataEmissao.Text), "yyyy")
                    Select Case i
                        Case 1
                            objRow("Vencimento") = Me.txtVenc1.Text
                            objRow("Valor") = Me.txtValor1.Text
                        Case 2
                            objRow("Vencimento") = Me.txtVenc2.Text
                            objRow("Valor") = Me.txtValor2.Text
                        Case 3
                            objRow("Vencimento") = Me.txtVenc3.Text
                            objRow("Valor") = Me.txtValor3.Text
                        Case 4
                            objRow("Vencimento") = Me.txtVenc4.Text
                            objRow("Valor") = Me.txtValor4.Text
                    End Select
                    objRow("Parcela") = i
                    objRow("cnpjcpf") = DS.Tables("Cliente").Rows(0).Item("CpfCgc").ToString
                    objRow("inscricao") = DS.Tables("Cliente").Rows(0).Item("Insc").ToString
                    objRow("nome") = DS.Tables("Cliente").Rows(0).Item("Nome").ToString
                    objRow("endereco") = DS.Tables("Cliente").Rows(0).Item("Endereço").ToString
                    objRow("nro") = DS.Tables("Cliente").Rows(0).Item("nro").ToString
                    objRow("Bairro") = DS.Tables("Cliente").Rows(0).Item("Bairro").ToString
                    objRow("cidade") = DS.Tables("Cliente").Rows(0).Item("cidade").ToString
                    objRow("estado") = DS.Tables("Cliente").Rows(0).Item("estado").ToString
                    objRow("Cep") = DS.Tables("Cliente").Rows(0).Item("Cep").ToString
                    objRow("EmpresaRazao") = DS.Tables("Empresa").Rows(0).Item("RazãoSocial").ToString
                    objRow("EmpresaCnpj") = DS.Tables("Empresa").Rows(0).Item("cgc").ToString
                    objRow("EmpresaIE") = DS.Tables("Empresa").Rows(0).Item("InçriçãoEstadual").ToString
                    objRow("EmpresaEndereco") = DS.Tables("Empresa").Rows(0).Item("Endereço").ToString & ", " & DS.Tables("Empresa").Rows(0).Item("Bairro").ToString & ", Cep.: " & DS.Tables("Empresa").Rows(0).Item("cep").ToString & "-" & DS.Tables("Empresa").Rows(0).Item("Cidade").ToString & "/" & DS.Tables("Empresa").Rows(0).Item("Estado").ToString
                    objRow("EmpresaTelefone") = "Fone / Fax " & DS.Tables("Empresa").Rows(0).Item("Telefone").ToString
                    DS.Tables("Table1").Rows.Add(objRow)
                Next
            End With


            Dim rpt As New RelDuplicataAvulso
            rpt.DataSource = DS.Tables("Table1")
            ViewReport.VerRelat.Document = rpt.Document
            rpt.Run()
            ViewReport.ShowDialog()

        Catch ex As Exception

        End Try




    End Sub

    Private Sub DuplicataAvulso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ação.Desbloquear_Controle(Me, False)
    End Sub

    Private Sub butLacalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butLacalizar.Click
        DuplicataAvulsoLocalizar.ShowDialog()

        If RetornoProcura <> 0 Then
            clsDuplicata.Localizar(RetornoProcura)

        End If
    End Sub
End Class