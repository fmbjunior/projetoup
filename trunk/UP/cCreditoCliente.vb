Imports System.Data

Public Class cCreditoCliente
    'atributos
    Private a_id As String
    Private a_cliente As String
    Private a_nomecliente As String
    Private a_desc_credito As String
    Private a_data_credito As String
    Private a_vencimento_credito As String
    Private a_valor_credito As Double
    Private a_codigoempresa As Short
    Private a_confirmado As Boolean
    Private a_isError As Boolean
    Private a_contaCR As String
    Private a_conta_balancete As String
    Private a_soma_valor_credito As Double

    'propriedades
    ''' <summary>
    ''' Insere o codigo automatico 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Id() As String
        Get
            Return a_id
        End Get
        Set(ByVal value As String)
            a_id = value
        End Set
    End Property

    Public Property Cliente() As String
        Get
            Return a_cliente
        End Get
        Set(ByVal value As String)
            a_cliente = value
        End Set
    End Property
    Public Property Nomecliente() As String
        Get
            Return a_nomecliente
        End Get
        Set(ByVal value As String)
            a_nomecliente = value
        End Set
    End Property
    Public Property Desc_credito() As String
        Get
            Return a_desc_credito
        End Get
        Set(ByVal value As String)
            a_desc_credito = value
        End Set
    End Property

    Public Property Data_credito() As String
        Get
            Return a_data_credito
        End Get
        Set(ByVal value As String)
            a_data_credito = value
        End Set
    End Property

    Public Property Vencimento_credito() As String
        Get
            Return a_vencimento_credito
        End Get
        Set(ByVal value As String)
            a_vencimento_credito = value
        End Set
    End Property

    Public Property Valor_credito() As Double
        Get
            Return a_valor_credito
        End Get
        Set(ByVal value As Double)
            a_valor_credito = value
        End Set
    End Property

    Public Property Codigoempresa() As Short
        Get
            Return a_codigoempresa
        End Get
        Set(ByVal value As Short)
            a_codigoempresa = value
        End Set
    End Property

    Public Property Confirmado() As Boolean
        Get
            Return a_confirmado
        End Get
        Set(ByVal value As Boolean)
            a_confirmado = value
        End Set
    End Property

    Public Property IsError() As Boolean
        Get
            Return a_isError
        End Get
        Set(ByVal value As Boolean)
            a_isError = value
        End Set
    End Property
    Public Property ContaCR() As String
        Get
            Return a_contaCR
        End Get
        Set(ByVal value As String)
            a_contaCR = value
        End Set
    End Property

    Public Property Conta_Balancete() As String
        Get
            Return a_conta_balancete
        End Get
        Set(ByVal value As String)
            a_conta_balancete = value
        End Set
    End Property

    Public Property Soma_Valor_Credito() As Double
        Get
            Return a_soma_valor_credito
        End Get
        Set(ByVal value As Double)
            a_soma_valor_credito = value
        End Set
    End Property


    'Métodos
    Public Sub gravar()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Transacao As OleDb.OleDbTransaction = CNN.BeginTransaction()

        Dim CmdCred As OleDb.OleDbCommand = CNN.CreateCommand
        Dim CmdReceber As OleDb.OleDbCommand = CNN.CreateCommand
        Dim cmd_Caixa As OleDb.OleDbCommand = CNN.CreateCommand
        Dim cmd_balancete As OleDb.OleDbCommand = CNN.CreateCommand

        LocBalancete()


        Try
            CmdCred.Transaction = Transacao

            CmdCred.CommandText = "Select max(Id) from ClienteCred"

            Id = CmdCred.ExecuteScalar.ToString()
            If String.IsNullOrEmpty(Id) Then
                Id = 1
            Else
                Id = Id + 1
            End If

            'inserir o credito
            Dim Sql As String = "INSERT INTO ClienteCred (Id, Cliente, DescCred, DataCred, VencimentoCred, ValorCred, Empresa, Confirmado) VALUES (@1, @2, @3, @4, @5, @6, @7, @8)"
            CmdCred.CommandText = Sql

            CmdCred.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(a_id, 1)))
            CmdCred.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(a_cliente, 1)))
            CmdCred.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(a_desc_credito, 1)))
            CmdCred.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(a_data_credito, 1)))
            CmdCred.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(a_vencimento_credito, 1)))
            CmdCred.Parameters.Add(New OleDb.OleDbParameter("@6", a_valor_credito))
            CmdCred.Parameters.Add(New OleDb.OleDbParameter("@7", a_codigoempresa))
            CmdCred.Parameters.Add(New OleDb.OleDbParameter("@8", a_confirmado))
            CmdCred.ExecuteNonQuery()

            'Inserir o credito no caixa
            cmd_Caixa.CommandText = "INSERT INTO LancamentoBanco (DataLancamento, PreDatado, DataPreDatado, Documento, DataDocumento, TipoLancamento, Favorecido, Historico, CaiuBanco, ConfirmadoLancamento, Empresa, ValorDocumento, ContaCorrente, EmitirCheque, ContaBalancete, Tipo, IdLancamento, IdProcura) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18)"
            cmd_Caixa.Transaction = Transacao
         

            cmd_Caixa.Parameters.Add(New OleDb.OleDbParameter("@1", DataDia))
            cmd_Caixa.Parameters.Add(New OleDb.OleDbParameter("@2", False))
            cmd_Caixa.Parameters.Add(New OleDb.OleDbParameter("@3", System.DBNull.Value))
            cmd_Caixa.Parameters.Add(New OleDb.OleDbParameter("@4", Nz("CRED-" & Id, 1)))
            cmd_Caixa.Parameters.Add(New OleDb.OleDbParameter("@5", DataDia))
            cmd_Caixa.Parameters.Add(New OleDb.OleDbParameter("@6", Nz("C", 1)))
            cmd_Caixa.Parameters.Add(New OleDb.OleDbParameter("@7", Nz(Nomecliente, 1)))
            cmd_Caixa.Parameters.Add(New OleDb.OleDbParameter("@8", Nz("RECEB. CREDITO N. " & Id, 1)))
            cmd_Caixa.Parameters.Add(New OleDb.OleDbParameter("@9", Nz("S", 1)))
            cmd_Caixa.Parameters.Add(New OleDb.OleDbParameter("@10", True)) 'Confirmado Lancamento como true
            cmd_Caixa.Parameters.Add(New OleDb.OleDbParameter("@11", CodEmpresa))
            cmd_Caixa.Parameters.Add(New OleDb.OleDbParameter("@12", Valor_credito))
            cmd_Caixa.Parameters.Add(New OleDb.OleDbParameter("@13", Nz(CaixaAtivo, 1)))
            cmd_Caixa.Parameters.Add(New OleDb.OleDbParameter("@14", "N"))
            cmd_Caixa.Parameters.Add(New OleDb.OleDbParameter("@15", Conta_Balancete))
            cmd_Caixa.Parameters.Add(New OleDb.OleDbParameter("@16", "CAIXA"))
            cmd_Caixa.Parameters.Add(New OleDb.OleDbParameter("@17", "CLIENTESCRED"))
            cmd_Caixa.Parameters.Add(New OleDb.OleDbParameter("@18", Id))
            cmd_Caixa.ExecuteNonQuery()

            'inserir o credito no contas a receber
            CmdReceber.Transaction = Transacao
            CmdReceber.CommandText = "INSERT INTO Receber (Documento,DataDocumento,ValorDocumento,ValorLiquido,LocalPgto,CodCliente,Cliente,Empresa,OriginalParcial,Vencimento,Recebimento,Baixado,ContaValorBaixado,Virtual) values (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14)"


            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@1", "CRED-" & Id))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@2", Data_credito))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@3", Valor_credito))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@4", Valor_credito))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@5", "CARTEIRA"))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@6", Cliente))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@7", Nomecliente))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@8", CodEmpresa))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@9", "O"))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@10", Data_credito))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@11", Data_credito))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@12", True))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@13", Conta_Balancete))
            CmdReceber.Parameters.Add(New OleDb.OleDbParameter("@14", False))
            CmdReceber.ExecuteNonQuery()

            ''inserir o credito no balancete
            cmd_balancete.Transaction = Transacao
            cmd_balancete.CommandText = "INSERT INTO BALANCETELANC (CONTABALANCETE,CONTACR,DATALANCAMENTO,DOCUMENTO,VALORDOCUMENTO,HISTORICO,EMPRESA,PRGLANCAMENTO,IDPROCURA) VALUES (@1,@2,@3,@4,@5,@6,@7,@8,@9)"

            cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@1", Conta_Balancete))
            cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@2", ContaCR))
            cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@3", DataDia))
            cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@4", "CRED-" & Id))
            cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@5", Valor_credito))
            cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@6", "RECEB. CRED. " & Id))
            cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@7", CodEmpresa))
            cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@8", "CLIENTESCRED"))
            cmd_balancete.Parameters.Add(New OleDb.OleDbParameter("@9", Id))

            cmd_balancete.ExecuteNonQuery()

            Transacao.Commit()
            CNN.Close()
            MsgBox("Registro adicionado com sucesso", 64, "Validação de Dados")
            GerarLog("Lançamentos de Créditos para Clientes - T079", AçãoTP.Adicionou, a_id)
            IsError = False
        Catch ex As Exception
            MsgBox("Erro no Lançamento do Crédito.", 64, "Validação de Dados")
            Transacao.Rollback()
            MsgBox(ex.Message, 64, "Validação de Dados")
            CNN.Close()
            IsError = True
        End Try


    End Sub
    Public Sub LocBalancete()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "Select * from Empresa where CódigoEmpresa = " & CodEmpresa
        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Conta_Balancete = DR.Item("ContaBalanceteVendaAvista") & ""
            ContaCR = DR.Item("ContaCRVenda") & ""
        End If
        DR.Close()

    End Sub
    Public Sub LocalizaDadosCliente(xcli As String)
        If String.IsNullOrEmpty(xcli) Then
            Exit Sub
        End If


        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT * FROM Clientes WHERE Clientes.Empresa = " & CodEmpresa & " AND Clientes.Codigo =" & xcli

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            a_nomecliente = DR.Item("Nome") & ""
            IsError = False
        Else
            MessageBox.Show("Cliente não encontrado", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            IsError = True
        End If

        DR.Close()

    End Sub

    Public Sub Busca_Credito(xcli As String)

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Cnn.Open()

        Dim Sql As String = "SELECT Sum(ClienteCred.ValorCred) AS SomaDeValorCred FROM ClienteCred GROUP BY ClienteCred.Cliente HAVING Cliente=" & xcli

        Dim CMD As New OleDb.OleDbCommand(Sql, Cnn)
        a_soma_valor_credito = CMD.ExecuteScalar()
       
        LocalizaDadosCliente(xcli)

    End Sub



End Class
