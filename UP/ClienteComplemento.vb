Public Class ClienteComplemento
    Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))

    Dim Ação As New TrfGerais()

    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2
    Dim vTipoResidencia As String
    Dim vEstadoCivil As String


    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        CNN.Close()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ClienteComplemento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Degrade()
        CNN.Open()
        Operation = UPD
        AcharCliente()
    End Sub

    Public Sub nEstadoCivil(ByVal x2 As String)
        Select Case x2
            Case "1"
                vEstadoCivil = "1-Solteiro"
            Case "2"
                vEstadoCivil = "2-Casada"
            Case "3"
                vEstadoCivil = "3-Saparado"
            Case "4"
                vEstadoCivil = "4-Divorciado"
            Case "5"
                vEstadoCivil = "5-Viúvo"
            Case "6"
                vEstadoCivil = "6-Outros"
        End Select

    End Sub

    Public Sub nTipoResidencia(ByVal x1 As String)
        Select Case x1
            Case "1"
                vTipoResidencia = "1-Própria"
            Case "2"
                vTipoResidencia = "2-Alugada"
            Case "3"
                vTipoResidencia = "3-Com Parentes"
            Case "4"
                vTipoResidencia = "4-Divorciado"
            Case "5"
                vTipoResidencia = "5-Funcional"
            Case "6"
                vTipoResidencia = "6-Outros"
        End Select

    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click

        Dim Sql As String = "Update Clientes set LocalTrabalho = @1, EndereçoTrabalho = @2, BairroTrabalho = @3, CidadeTrabalho = @4, CepTrabalho = @5, EstadoTrabalho = @6, FoneTrabalho = @7," _
        & " TempoTrabalho = @8, Profissão = @9, Salário = @10, EstadoCivil = @11, NomeConjuge = @12, DataNascimentoConjuge = @13, ProfissãoConjuge = @14, RgConjuge = @15, LocalTrabalhoConjuge = @16," _
        & " EndereçoTrabalhoConjuge = @17, CidadeTrabalhoConjuge = @18, FoneTrabalhoConjuge = @19, ReferenciaComercial1 = @20, ReferenciaComercial2 = @21, ReferenciaComercial3 = @22," _
        & " TelefoneRefComercial1 = @24, TelefoneRefComercial2 = @25, TelefoneRefComercial3 = @26,NomeReferencia=@27,Nomereferencia1=@28,TelefoneReferencia=@29,TelefoneReferencia1=@30," _
        & " Pai=@31,Mae=@32,ReferenciaBancária=@33,NAgencia=@34,NContaCorrente=@35,ChequeEspecial=@36,MesAnoConta=@37," _
        & " ContatoRefBancaria=@38, DataConsultaSCPC=@39,TipoResidencia=@40,ConsultaSCPC=@41,DocRenda=@42,DocRes=@43,DocCPF=@44,DocRG=@45,Outros=@46, SalarioConjuge = @47 Where Codigo = " & My.Forms.Clientes.Codigo.Text

        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.LocalTrabalho.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.EndereçoTrabalho.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.BairroTrabalho.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.CidadeTrabalho.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.CepTrabalho.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Nz(Me.EstadoTrabalho.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Me.FoneTrabalho.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Nz(Me.TempoTrabalho.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Nz(Me.Profissão.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Nz(Me.Salário.Text, 1)))
        'conjuge
        cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Nz(Mid(Me.cEstadoCivil.Text, 1, 1), 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Nz(Me.NomeConjuge.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(Me.DataNascimentoConjuge.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Nz(Me.ProfissãoConjuge.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@15", Nz(Me.RgConjuge.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@16", Nz(Me.LocalTrabalhoConjuge.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@17", Nz(Me.EndereçoTrabalhoConjuge.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@18", Nz(Me.CidadeTrabalhoConjuge.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@19", Nz(Me.FoneTrabalhoConjuge.Text, 1)))
        'Referencias
        cmd.Parameters.Add(New OleDb.OleDbParameter("@20", Nz(Me.ReferenciaComercial1.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@21", Nz(Me.ReferenciaComercial2.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@22", Nz(Me.ReferenciaComercial3.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@24", Nz(Me.TelRefCom1.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@25", Nz(Me.TelRefCom2.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@26", Nz(Me.TelRefCom3.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@27", Nz(Me.NomeReferencia.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@28", Nz(Me.NomeReferencia1.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@29", Nz(Me.TelefoneReferencia.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@30", Nz(Me.TelefoneReferencia1.Text, 1)))
        'Filiacao
        cmd.Parameters.Add(New OleDb.OleDbParameter("@31", Nz(Me.NomePai.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@32", Nz(Me.NomeMae.Text, 1)))
        'Informacaoe Bancarias.
        cmd.Parameters.Add(New OleDb.OleDbParameter("@33", Nz(Me.ReferenciaBancaria.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@34", Nz(Me.NAgencia.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@35", Nz(Me.NContaCorrente.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@36", Nz(Me.cChequeEspecial.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@37", Nz(Me.MesAnoConta.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@38", Nz(Me.ContatoRefBancaria.Text, 1)))
        ' Outras Informa'coes.
        cmd.Parameters.Add(New OleDb.OleDbParameter("@39", Nz(Me.DataConsultaSCPC.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@40", Nz(Mid(Me.cTipoResidencia.Text, 1, 1), 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@41", Nz(Me.ConsultaSCPC.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@42", Me.chkRenda.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@43", Me.chkResidencia.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@44", Me.chkCPF.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@45", Me.chkRG.Checked))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@46", Nz(Me.Outros.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@47", Nz(Me.SalarioConjuge.Text, 1)))


        Try
            cmd.ExecuteNonQuery()
            MsgBox("Registro Atualizado com sucesso", 64, "Validação de Dados")
            Operation = UPD
        Catch x As Exception
            MsgBox(x.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub AcharCliente()

        Dim Sql As String = "SELECT Clientes.*, Clientes.Empresa FROM Clientes WHERE Clientes.Codigo = " & My.Forms.Clientes.Codigo.Text & " AND Clientes.Empresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then

            Me.LocalTrabalho.Text = DR.Item("LocalTrabalho") & ""
            Me.EndereçoTrabalho.Text = DR.Item("EndereçoTrabalho") & ""
            Me.BairroTrabalho.Text = DR.Item("BairroTrabalho") & ""
            Me.CidadeTrabalho.Text = DR.Item("CidadeTrabalho") & ""
            Me.CepTrabalho.Text = DR.Item("CepTrabalho") & ""
            Me.EstadoTrabalho.Text = DR.Item("EstadoTrabalho") & ""
            Me.FoneTrabalho.Text = DR.Item("FoneTrabalho") & ""
            Me.TempoTrabalho.Text = DR.Item("TempoTrabalho") & ""
            Me.Profissão.Text = DR.Item("Profissão") & ""
            Me.Salário.Text = DR.Item("Salário") & ""
            'conjuge
            vEstadoCivil = DR.Item("EstadoCivil") & ""
            nEstadoCivil(vEstadoCivil)
            Me.cEstadoCivil.Text = vEstadoCivil
            Me.NomeConjuge.Text = DR.Item("NomeConjuge") & ""
            Me.DataNascimentoConjuge.Text = DR.Item("DataNascimentoConjuge") & ""
            Me.ProfissãoConjuge.Text = DR.Item("ProfissãoConjuge") & ""
            Me.RgConjuge.Text = DR.Item("RgConjuge") & ""
            Me.LocalTrabalhoConjuge.Text = DR.Item("LocalTrabalhoConjuge") & ""
            Me.EndereçoTrabalhoConjuge.Text = DR.Item("EndereçoTrabalhoConjuge") & ""
            Me.CidadeTrabalhoConjuge.Text = DR.Item("CidadeTrabalhoConjuge") & ""
            Me.FoneTrabalhoConjuge.Text = DR.Item("FoneTrabalhoConjuge") & ""
            Me.SalarioConjuge.Text = DR.Item("SalarioConjuge") & ""
            'Referencias
            Me.ReferenciaComercial1.Text = DR.Item("ReferenciaComercial1") & ""
            Me.ReferenciaComercial2.Text = DR.Item("ReferenciaComercial2") & ""
            Me.ReferenciaComercial3.Text = DR.Item("ReferenciaComercial3") & ""
            Me.TelRefCom1.Text = DR.Item("TelefoneRefComercial1") & ""
            Me.TelRefCom2.Text = DR.Item("TelefoneRefComercial2") & ""
            Me.TelRefCom3.Text = DR.Item("TelefoneRefComercial3") & ""
            Me.NomeReferencia.Text = DR.Item("NomeReferencia") & ""
            Me.NomeReferencia1.Text = DR.Item("NomeReferencia1") & ""
            Me.TelefoneReferencia.Text = DR.Item("TelefoneReferencia") & ""
            Me.TelefoneReferencia1.Text = DR.Item("TelefoneReferencia1") & ""
            'Filiacao
            Me.NomePai.Text = DR.Item("Pai") & ""
            Me.NomeMae.Text = DR.Item("Mae") & ""
            'Informacaoe Bancarias.
            Me.ReferenciaBancaria.Text = DR.Item("Referenciabancária") & ""
            Me.NAgencia.Text = DR.Item("NAgencia") & ""
            Me.NContaCorrente.Text = DR.Item("NContacorrente") & ""
            Me.cChequeEspecial.Text = DR.Item("ChequeEspecial") & ""
            Me.MesAnoConta.Text = DR.Item("MesAnoconta") & ""
            Me.ContatoRefBancaria.Text = DR.Item("ContatoRefBancaria") & ""
            ' Outras Informa'coes.
            Me.DataConsultaSCPC.Text = DR.Item("DataConsultaSCPC") & ""
            vTipoResidencia = DR.Item("TipoResidencia") & ""
            nTipoResidencia(vTipoResidencia)
            Me.cTipoResidencia.Text = vTipoResidencia
            Me.ConsultaSCPC.Text = DR.Item("ConsultaSCPC") & ""
            Me.chkRenda.Checked = DR.Item("DocRenda")
            Me.chkResidencia.Checked = DR.Item("DocRes")
            Me.chkCPF.Checked = DR.Item("DocCPF")
            Me.chkRG.Checked = DR.Item("DocRG")
            Me.Outros.Text = DR.Item("Outros") & ""
        End If



        Operation = UPD
        DR.Close()

    End Sub

    Private Sub Degrade()
        Try
            Dim CCor() As String
            Dim corTemp As String

            corTemp = Cor1TelaSecundaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))

            corTemp = Cor2TelaSecundaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))
        Catch ex As Exception
        End Try
    End Sub


End Class