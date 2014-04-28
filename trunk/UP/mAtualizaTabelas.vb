Imports System.IO

Module mAtualizaTabelas


    Public Sub AtualizaTabelas()
        '*******************Rotina Criada por Douglas*******************************
        '* Mesmo que a rotina seja executada varias vezes os erros serao somente   *
        '* erros dizendo que o o objeto ja existe portanto a rotina pode ser       *
        '* executada ate o final, a cada alteraçao tera que ser criada uma nova    *
        '* linha para execuçao dos dados necessarios.                              * 
        '* Ex:                                                                     *
        '* ALTER TABLE empregados ADD cpf TEXT(20),rg TEXT(15)                     *
        '* ALTER TABLE empregados ALTER COLUMN sexo TEXT(30)                       *
        '* ALTER TABLE empregados DROP COLUMN sexo                                 *
        '*                                                                         *
        '* COUNTER = AutoNumeraçao                                                 *
        '* TEXT    = Texto                                                         *
        '* IINTEGER= iNTEIRO                                                       *
        '* DATETIME= Data/Hora                                                     *
        '* CURRENCY= Moeda                                                         *
        '* MEMO= Memo                                                              *
        '* DOUBLE= Duplo                                                           *
        '* Sim/Não= YesNo                                                          *
        '***************************************************************************
        '*********************Rotina de Criação de Tabela Feita Pelo: Lelo e Beto***
        'CREATE TABLE NomeTabela (campo1 TEXT(10), campo2 TEXT(20), Constraint NomeTabela_PK Primary Key(Campo1))
        '********************************************************************************************************

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = CNN


        'Deste ponto para cima nao mexer

        'Empresa Alteraçoes de Tabelas

        Try
            cmd.CommandText = "Alter Table Empresa ADD UsarGradeProdutos YesNo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table Empresa ADD ComFaixa YesNo, SemFaixa YesNo, NaoValidaCpfCnpj YesNo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table Empresa ADD ValidadeOrcamento INTEGER "
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'LoginUser

        Try
            cmd.CommandText = "Alter Table LoginUser ADD MenuCarregar TEXT(20)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Clientes

        Try
            cmd.CommandText = "Alter Table Clientes ADD VendaVista YesNo, VendaCheque YesNo, VendaCrediario YesNo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'ItensPedido

        Try
            cmd.CommandText = "Alter Table ItensPedido ADD  Numero TEXT(10)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'ReceberLancamentoavulso

        Try
            cmd.CommandText = "Alter Table Receberlancamentoavulso ADD  ContaLancamento TEXT(6)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'ContasG3

        Try
            cmd.CommandText = "Alter Table ContasG3 ADD  cIntegracao TEXT(6)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'CompraCtrlPedido

        Try
            cmd.CommandText = "Alter Table CompraCtrlPedido ADD  ContaLancamento TEXT(6)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Compra

        Try
            cmd.CommandText = "Alter Table Compra ADD  IdNFdevMae INTERGER"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table Compra ADD  NFdevMae TEXT(15)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table Compra ADD  NFdevMaeValor CURRENCY"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table Compra ADD  ContaLancamento TEXT(6)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'ArquivoCheque

        Try
            cmd.CommandText = "Alter Table ArquivoCheque ADD Vendedor INTEGER "
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table ArquivoCheque ADD MediaDescontoPedido DOUBLE "
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table ArquivoCheque ADD PercentComissao DOUBLE "
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'FuncionarioComissao

        Try
            cmd.CommandText = "Alter Table FuncionarioComissao ADD Documento TEXT(6) "
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table FuncionarioComissao ADD ComissaoFaturamento YesNo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table FuncionarioComissao ADD OndeVeio TEXT(15)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table FuncionarioComissao ADD IdOrigem Interger"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        Try
            cmd.CommandText = "Alter Table FuncionarioComissao ADD DescComissao TEXT (40)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'Pedido

        Try
            cmd.CommandText = "Alter Table Pedido ADD MediaDesconto DOUBLE"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table pedido ADD codobjeto integer, totalservico currency"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'Receber

        Try
            cmd.CommandText = "Alter Table Receber ADD MediaDescontoPedido DOUBLE"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table Receber ADD ControlePedido TEXT (15)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table Receber ADD PercentComissao DOUBLE"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Inclusão de Tabela Nova e seus campos
        'itensservicos

        Try
            cmd.CommandText = "CREATE TABLE ItemServico (Id COUNTER, PedidoSequencia INTEGER,Codigoservico integer, Funcionario Integer, qtd double, Valorunitario CURRENCY, Desconto Double, ValorDesconto Currency, Totalservico Currency, Comissao double, ValorComissao Currency, Constraint itemservico_PK Primary Key(Id))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        Try
            cmd.CommandText = "CREATE TABLE Funcionarioservico (fs_Id COUNTER, fs_codigofuncionario INTEGER, Constraint funcionarioservico_PK Primary Key(fs_Id))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        Try
            cmd.CommandText = "CREATE TABLE Funcionarioservicodetalhe (sv_Id COUNTER, fs_codigo INTEGER, sv_codigofuncionario INTEGER, sv_codigoservico INTEGER, sv_comissão Double,  Constraint Funcionarioservicodetalhe_pk Primary Key(sv_codigofuncionario, sv_codigoservico))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "CREATE TABLE objetoscad (codobjeto COUNTER, veiculo text(50), placa text(7), km text(8), Renavan text(15), Cor text(20), Obs Text(100), Datacadastro DATETIME, codigocliente integer,   Constraint obejetoscad_pk Primary Key(codobjeto))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "CREATE TABLE servicos (serv_codigo COUNTER, serv_descricao text(75), serv_valorservico currency, serv_referencia text(150), empresa integer,   Constraint servicos_pk Primary Key(serv_codigo))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        Try
            cmd.CommandText = "Alter Table ArquivoCheque ADD CaixaCheque TEXT(6), DataLancamento DATETIME"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 13/08/2010 - Douglas Machado
        Try
            cmd.CommandText = "Alter Table CaixaCadastro ADD Retaguarda YesNo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        'Adicionado data 14/08/2010 - Douglas Machado
        Try
            cmd.CommandText = "Alter Table Clientes ADD InscricaoMunicipal TEXT(16), CaixaPostal TEXT(10)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 16/08/2010 - Douglas Machado
        Try
            cmd.CommandText = "CREATE TABLE ArquivoChequeRepasse (Id COUNTER, CodRepasse TEXT(14), Cheque TEXT(15), CC TEXT(15), DataRepasse DATETIME, CaixaOrigem TEXT(6), CaixaDestino TEXT(6), Constraint PrimaryKey PRIMARY KEY(ID))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 17/08/2010 - Douglas Machado
        Try
            cmd.CommandText = "Alter Table ArquivoChequeRepasse ADD ValorCh CURRENCY"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 18/08/2010 - José Roberto
        Try
            cmd.CommandText = "CREATE TABLE OrcamentoItemServico (Id COUNTER, CodigoOrcamento INTEGER,Codigoservico integer, Funcionario Integer, qtd double, Valorunitario CURRENCY, Desconto Double, ValorDesconto Currency, Totalservico Currency, Comissao double, ValorComissao Currency, Constraint itemservico_PK Primary Key(Id))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 03/09/2010 - José Roberto
        Try
            cmd.CommandText = "CREATE TABLE DuplicataAvulso (Dcodigo COUNTER, DCodigoCliente INTEGER, DNumeroDocumento text(15), DNf Text(10), DControle Text(10), DDataEmissao Date, DParcelas Integer, Dvenc1 Date, Dvenc2 Date, Dvenc3 Date, Dvenc4 Date, DValor1 Currency, DValor2 Currency, DValor3 Currency,DValor4 Currency, Constraint Dcodigo_PK Primary Key(Dcodigo))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 03/09/2010 - Douglas Machado
        Try
            cmd.CommandText = "Alter Table FuncionarioCartao ADD Empresa Integer"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 08/09/2010 - Douglas Machado
        Try
            cmd.CommandText = "Alter Table Pedido ADD DevNumero Integer"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 11/09/2010 - Douglas Machado
        Try
            cmd.CommandText = "Alter Table EstoqueUP ADD Numero TEXT(10)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 11/09/2010 - Douglas Machado
        Try
            cmd.CommandText = "Alter Table ItensPedido ADD Promocao YesNo, DevolvidoId Integer, Devolvido YesNo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 11/09/2010 - Douglas Machado
        Try
            cmd.CommandText = "Alter Table Empresa ADD UsarServico YesNo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 13/09/2010 - Jose Roberto
        Try
            cmd.CommandText = "Alter Table ItensCompra ADD Tamanho Text(10)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 19/09/2010 - Douglas Machado
        Try
            cmd.CommandText = "Alter Table FuncionarioComissao ALTER COLUMN DescComissao TEXT(100)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'Adicionado data 22/09/2010 - Jose Roberto
        Try
            cmd.CommandText = "Alter Table Pedido ADD ObsObjeto Text(200)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 22/09/2010 - Jose Roberto
        Try
            cmd.CommandText = "Alter Table Pedido ADD kmObjeto Text(15)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        ' Rotina Inserida 29/09/2010 por Jose Roberto
        Try
            cmd.CommandText = "CREATE TABLE PedidoCompra (CodigoPedidoCompra COUNTER, CodigoFornecedor INTEGER, CodigoFuncionario INTEGER, DataLancamento DATETIME, DataPrevistaEntrega DATETIME, TotalPedidoCompra CURRENCY, Parcelas INTEGER, Inativo YESNO, Confirmado YESNO, DataPrimeiroVencimento DATETIME, Obs TEXT(200), CONSTRAINT CodigoPedidoCompra_pk PRIMARY KEY(CodigoPedidoCompra))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "CREATE TABLE PedidoCompraItem (Id COUNTER, CompraInterno INTEGER, CodigoProduto INTEGER, Qtd DOUBLE, ConversorQtd DOUBLE, ValorUnitario CURRENCY, Desconto DOUBLE, ValorDesconto CURRENCY, Ipi DOUBLE, ValorIpi CURRENCY, TotalProduto CURRENCY, Cst TEXT(3), Cf TEXT(12), SeqNf INTEGER, CFOP TEXT(4), IcmsProduto DOUBLE, ValorIcmsProduto CURRENCY, PisProduto DOUBLE, ValorPisProduto CURRENCY, CofinsProduto DOUBLE, ValorCofinsProduto CURRENCY, FreteProduto DOUBLE, ValorFreteProduto CURRENCY, ClassContabilProduto TEXT(4), ValorP CURRENCY, Tamanho TEXT(10), CONSTRAINT ID_pk PRIMARY KEY(ID))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "CREATE TABLE PedidoCompraParcelamento (idParcelamento COUNTER, Documento TEXT(20), CodigoPedidoCompra INTEGER, CodigoFornecedor INTEGER, ValorDocumento CURRENCY, Vencimento DATETIME, Datalancamento DATETIME, CONSTRAIT IDPARCELAMENTO_PK PRIMARY KEY(IDPARCELAMENTO))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        ' ************************************************

        ' Rotina Inserida 06/10/2010 por Jose Roberto
        Try
            cmd.CommandText = "CREATE TABLE GrupoServico (gID COUNTER, gDescricao TEXT(50), CONSTRAINT ID_PK PRIMARY KEY(gID))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 06/10/2010 por Jose Roberto
        Try
            cmd.CommandText = "ALTER TABLE Servicos Add GrupoServico Integer"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 21/10/2010 - Douglas Machado
        Try
            cmd.CommandText = "CREATE TABLE PedidoCND (PedidoCND integer, Funcionario INTEGER, CodCliente integer, DataCND DATETIME, VencimentoCND DATETIME, TotalCND CURRENCY, DataFechamento DATETIME, PercentualVendido Double, Empresa Integer, Inativo YesNo, Status TEXT(10), Constraint PrimaryKey Primary Key(PedidoCND))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            cmd.CommandText = "CREATE TABLE PedidoCNDitens (Id COUNTER, PedidoCND INTEGER, Produto INTEGER, Numero TEXT(10), Qtd Double, Unitario CURRENCY, TotalProduto CURRENCY, Vendido YesNo, Constraint PrimaryKey Primary Key(Id))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'Rotina Inserida 06/10/2010 por Jose Roberto
        Try
            cmd.CommandText = "ALTER TABLE Produtos Add ValorVenda1 Currency,ValorVenda2 Currency,CompraAnterior Currency"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'Rotina Inserida 06/10/2010 por Jose Roberto
        Try
            cmd.CommandText = "ALTER TABLE Servicos Add Serv_DescontoMaximo Double"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 19/11/2010 por Douglas
        Try
            cmd.CommandText = "ALTER TABLE Receber Add Virtual YesNo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 20/11/2010 - Douglas Machado
        Try
            cmd.CommandText = "CREATE TABLE ContasCR1 (CR1 TEXT(4), DescCR1 TEXT(50), Empresa INTEGER, Constraint PrimaryKey Primary Key(CR1))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "CREATE TABLE ContasCR2 (CR1 TEXT(4), CR2 TEXT(6),DescCR2 TEXT(50), Inativo YesNo,Empresa INTEGER, Constraint PrimaryKey Primary Key(CR2))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 19/11/2010 por Jose Roberto
        Try
            cmd.CommandText = "ALTER TABLE Clientes ADD EstadoCivil Text(1), TelefoneRefComercial1 Text(15),TelefoneRefComercial2 Text(15),TelefoneRefComercial3 Text(15),Pai text(50),Mae text(50),TipoResidencia Text(1),NomeReferencia1 Text(50),TelefoneReferencia1 Text(15),MesAnoConta Text(7),ChequeEspecial Text(3),ContatoRefBancaria Text(50), ConsultaSCPC Text(100),DataConsultaSCPC DateTime, DocCPF YesNo,DocRG YesNo, DocRES YesNo,DocRENDA YesNo, Outros Text(50), DataEmissaoRG DateTime"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 19/11/2010 por Jose Roberto
        Try
            cmd.CommandText = "ALTER TABLE Clientes DROP COLUMN CasadoSolteiro"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'Rotina Inserida 11/12/2010 por Douglas
        Try
            cmd.CommandText = "ALTER TABLE Clientes ADD IdRegiao Integer"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 14/11/2010 por Douglas
        Try
            cmd.CommandText = "ALTER TABLE RegiaoCidade drop CONSTRAINT PrimaryKey"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "ALTER TABLE RegiaoCidade Add  CONSTRAINT PrimaryKey Primary Key(CodCidade, IdRegiao)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try



        'Adicionado data 17/12/2010 - Douglas Machado
        Try
            cmd.CommandText = "CREATE TABLE EstoqueUpDeposito (Id Counter, CodigoProduto Integer, Qtd Double, Tipo TEXT(1), DataLancamento DateTime, IdLancamento Integer, Prg TEXT(20), Constraint PrimaryKey Primary Key(Id))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "CREATE TABLE EstoqueTranf (Id Counter, CodigoProduto Integer, QtdTransf Double, EstVenda Double, EstDeposito Double, Tipo TEXT(1), DataLancamento DateTime, DescTransf Text(250), Confirmado YesNo, Usuario TEXT(15), Empresa Integer, VendaDeposito YesNo, DepositoVenda YesNo, Constraint PrimaryKey Primary Key(Id))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "ALTER TABLE Produtos Add EstDeposito Double"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 03/01/2011 por Jose Roberto  
        Try
            cmd.CommandText = "ALTER TABLE ItensCompra ADD AlterarCusto YesNo,cCompraAnterior CURRENCY,cAcrescimo DOUBLE,cIpi DOUBLE,cCofins DOUBLE,cPis DOUBLE,cFrete DOUBLE,cCusto CURRENCY,cIcmsCreditado INTEGER,cIcmsDebitado INTEGER,cDiferencaIcms DOUBLE, cOutros DOUBLE,cMargem DOUBLE, cCusto2 CURRENCY,cValorVenda CURRENCY"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 03/01/2011 por Jose Roberto  
        Try
            cmd.CommandText = "ALTER TABLE Produtos ADD Acrescimo DOUBLE,IcmsCreditado INTEGER,IcmsDebitado INTEGER,DiferencaIcms DOUBLE, Custo2 CURRENCY, PercentualAgregado DOUBLE"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'Rotina Inserida 17/01/2011 por Douglas Machado 
        Try
            cmd.CommandText = "ALTER TABLE Compra ADD BaseCalcIcmsST CURRENCY, ValorIcmsST CURRENCY"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 18/01/2011 por JOSE ROBERTO.
        Try
            cmd.CommandText = "CREATE TABLE TipoPgto (CodigoTipoPgto COUNTER, DescricaoTipoPgto text(50),  Constraint CodigoTipoPgto_pk Primary Key(CodigoTipoPgto))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 18/01/2011 por Jose Roberto.
        Try
            cmd.CommandText = "CREATE TABLE AnexarForma (CodigoAnexo COUNTER, Tp_Codigo INTEGER,Fp_Codigo INTEGER, Desconto DOUBLE, Acrescimo DOUBLE, Constraint Tp_Codigo_pk Primary Key(Tp_Codigo, Fp_Codigo))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'Adicionado data 20/01/2011 - Douglas Machado
        Try
            cmd.CommandText = "ALTER TABLE CompraCtrlPedido Add Conta1 TEXT(6), Conta2 TEXT(6), Conta3 TEXT(6), Conta4 TEXT(6), Conta5 TEXT(6), Conta6 TEXT(6), Vlr1 Double, Vlr2 Double, Vlr3 Double, Vlr4 Double, Vlr5 Double, Vlr6 Double, ContaCR TEXT(6)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "CREATE TABLE BalanceteLanc (Id Counter, ContaBalancete TEXT(6), ContaCR TEXT(6), DataLancamento DATETIME, Documento TEXT(15), ValorDocumento Double, Historico TEXT(200), Empresa Integer, PrgLancamento Text(15), IdProcura Integer, Constraint PrimaryKey Primary Key(Id))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "ALTER TABLE Pagar Add Conta1 TEXT(6), Conta2 TEXT(6), Conta3 TEXT(6), Conta4 TEXT(6), Conta5 TEXT(6), Conta6 TEXT(6), Vlr1 Double, Vlr2 Double, Vlr3 Double, Vlr4 Double, Vlr5 Double, Vlr6 Double, Percent1 Double, Percent2 Double, Percent3 Double, Percent4 Double, Percent5 Double, Percent6 Double, ContaCR TEXT(6)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "ALTER TABLE Receber Add ContaCR TEXT(6)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "ALTER TABLE ReceberLancamentoAvulso Add ContaCR TEXT(6)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'Adicionado data 02/02/2011 - Douglas Machado
        Try
            cmd.CommandText = "ALTER TABLE Pedido Add TipoPgto Integer, CodPgto Integer"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 03/02/2011 - Douglas Machado
        Try
            cmd.CommandText = "ALTER TABLE Empresa Add DescontoGerencia Double"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 07/02/2011 - Douglas Machado
        Try
            cmd.CommandText = "ALTER TABLE Pedido Add SenhaGerencia TEXT(15)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 08/02/2011 - Douglas Machado
        Try
            cmd.CommandText = "ALTER TABLE Empresa Add EnterCodBarra YesNo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 09/02/2011 - Douglas Machado
        Try
            cmd.CommandText = "ALTER TABLE objetoscad Alter Obs memo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "ALTER TABLE objetoscad Alter veiculo TEXT(100)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'Adicionado data 22/02/2011 - Douglas Machado

        Try
            cmd.CommandText = "CREATE TABLE Contratos (CodContrato TEXT(10), Cliente Integer, ValorContrato Currency, DataContrato DATETIME, Finalizado TEXT(1), ContaCR TEXT(6), OBS Memo, Empresa Integer, Constraint PrimaryKey Primary Key(CodContrato))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "ALTER TABLE Pedido Add Contrato TEXT(10), ContaCR TEXT(6)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "ALTER TABLE Empresa Add ContaCRVenda TEXT(6)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'Adicionado data 14/03/2011 - Douglas Machado
        Try
            cmd.CommandText = "Alter Table Pagar ADD PagoComPreDatado YesNo, DataPreDatado DATETIME"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table Receber ADD MultaP Integer"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 30/03/2011 - Douglas Machado
        Try
            cmd.CommandText = "ALTER TABLE Compra Add Conta1 TEXT(6), Conta2 TEXT(6), Conta3 TEXT(6), Conta4 TEXT(6), Conta5 TEXT(6), Conta6 TEXT(6), Vlr1 Double, Vlr2 Double, Vlr3 Double, Vlr4 Double, Vlr5 Double, Vlr6 Double, ContaCR TEXT(6)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 02/04/2011 - Jose Roberto

        Try
            cmd.CommandText = "Alter Table ContasCR2 ADD Inativo YesNo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 23/04/2011 - Douglas Machado
        Try
            cmd.CommandText = "ALTER TABLE LancamentoBanco Add ContaCR TEXT(6)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 16/05/2011 - Douglas Machado
        Try
            cmd.CommandText = "ALTER TABLE FormaPgto Alter Column DiasParcelamento TEXT(250)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 09/06/2011 por Douglas
        Try
            cmd.CommandText = "ALTER TABLE Clientes ADD SalarioConjuge Double"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'Rotina Inserida 16/06/2011 por Jose Roberto
        Try
            cmd.CommandText = "ALTER TABLE Pedido ADD ReterImposto YesNo, Issqn currency"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 16/06/2011 por Jose Roberto
        Try
            cmd.CommandText = "ALTER TABLE ItemServico ADD ValorISSQN Currency"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 26/06/2011 por Jose Roberto
        Try
            cmd.CommandText = "ALTER TABLE Empresa ADD ISSQN Double"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try



        'Rotina Inserida 14/08/2011 por Douglas
        Try
            cmd.CommandText = "CREATE TABLE Orc (OrcSequencia  Integer, CódigoFuncionário Integer, CódigoCliente Integer, DataOrc DateTime, PercDesconto Double, VlrDescProduto Double, ValorProduto Double, TotalOrc Double, ValorAVista Double, ValorOutros Double, ValorAFaturar Double, DataFechamento DateTime, Empresa Integer, Inativo YesNo, Confirmado YesNo, FormaPgto Integer, DiasParcelamento TEXT(90), ImpressoOrc YesNo, InfBloqueio TEXT(60), TipoPgto Integer, CodPgto Integer, SenhaGerencia TEXT(15), Contrato TEXT(10),  Constraint PrimaryKey Primary Key(OrcSequencia))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Create Table OrcITEM (Id Counter, OrcSequencia Integer, CodigoProduto Integer, EmitidoNf yesNo, Multiplos Double, Qtd Double, ValorUnitario Double, Desconto Double, ValorDesconto Double, CustoMercadoriaVendida Double, TotalProduto Double, QtdPc Double, UserSenhaDesconto Text(30), Numero Text(10),  Constraint PrimaryKey Primary Key(ID))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "ALTER TABLE Empresa Add VendedorFechaPedido YesNo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 15/08/2011 por Jose Roberto
        Try
            cmd.CommandText = "ALTER TABLE Compra Add PedidoCompra Integer"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            cmd.CommandText = "ALTER TABLE ItensCompra Add IDItemPedidoCompra Integer"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            cmd.CommandText = "ALTER TABLE Pagar Add IDPedidoCompra Integer"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 03/09/2011 por Douglas
        Try
            cmd.CommandText = "ALTER TABLE Clientes ADD tpComercio TEXT(7)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "ALTER TABLE Empresa ADD Segunda YesNo, Terca YesNo, Quarta YesNo, Quinta YesNo, Sexta YesNo, Sabado YesNo, Domingo YesNo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "ALTER TABLE Pagar Add Virtual YesNo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "DROP TABLE BalanceteOrcamentario"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "ALTER TABLE PedidoCompra Add Status  TEXT(12)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "ALTER TABLE PedidoCompraItem Add QtdEntregue  Double"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 08/10/2011 por Douglas
        Try
            cmd.CommandText = "ALTER TABLE ItensPedido ADD QtdDevolvido Double"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "ALTER TABLE TipoPgto ADD SomenteContrato YesNo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "ALTER TABLE FuncionarioCartao ADD Login TEXT(10)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "ALTER TABLE Pedido Add acrecimo  Double"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rontina inserida 25/10/2011
        Try
            cmd.CommandText = "ALTER TABLE ArquivoCheque Add DataEnvioFinanceira DATETIME, Financeira TEXT(20)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 26/10/2011 por Douglas

        Try
            cmd.CommandText = "ALTER TABLE Produtos ADD DescVarejo Double, DescAtacado Double"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 05/11/2011 por Douglas
        Try
            cmd.CommandText = "ALTER TABLE Orc Add Acrecimo  Double"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 10/11/2011 por Douglas

        Try
            cmd.CommandText = "ALTER TABLE Produtos ADD MostrarListaPreco TEXT(1)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "ALTER TABLE Contratos ADD ContaBalancete TEXT(6)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "UPDATE Produtos SET Produtos.MostrarListaPreco = 'S' WHERE (((Produtos.MostrarListaPreco) Is Null))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "ALTER TABLE Pagar ALTER COLUMN Destino TEXT(150)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "ALTER TABLE Empresa ADD UsarPedidoSellShoes YesNo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "ALTER TABLE Produtos ADD CodigoNFE TEXT(20)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 30/11/2011 por Douglas
        Try
            cmd.CommandText = "Alter Table Compra ADD IsentoIcms Double, ValorOutrosIcms Double, Ipi Double, IsentoIpi Double, ValorOutrosIpi Double, ValorIssqnRetido Double"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table Compra ADD Serie TEXT(3), Modelo TEXT(3)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table Compra ADD FormaPagamento TEXT(1)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "ALTER TABLE Compra ALTER COLUMN CFOP TEXT(4)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'inserida por jose roberto 01/12/2011
        Try
            cmd.CommandText = "ALTER TABLE Produtos ADD SubstituicaoICMSEstado TEXT(1)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            cmd.CommandText = "ALTER TABLE Produtos ADD IsentoICMSEstado TEXT(1)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "UPDATE Produtos SET SubstituicaoICMSEstado = 'N' WHERE SubstituicaoICMSEstado Is Null"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            cmd.CommandText = "UPDATE Produtos SET IsentoICMSEstado = 'N' WHERE IsentoICMSEstado Is Null"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            cmd.CommandText = "ALTER TABLE Produtos ADD NaoTributadoIcmsEstado TEXT(1)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            cmd.CommandText = "UPDATE Produtos SET NaoTributadoIcmsEstado = 'N' WHERE NaoTributadoIcmsEstado Is Null"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'Rotina Inserida 12/12/2011 por Douglas
        Try
            cmd.CommandText = "Alter Table ItensCompra ADD IsentoIpi Double, ValorOutrosIpi Double"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table ItensCompra ADD IsentoIcms Double, ValorOutrosIcms Double"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'Rotina Inserida 16/12/2011 por Douglas

        Try
            cmd.CommandText = "Alter Table Compra ADD SubSerie TEXT(2), EspecieDocumento TEXT(3)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table ItensCompra ADD BaseCalcST Double, AliquotaIcmsST Double, ValorIcmsST Double, Serie TEXT(3), SubSerie TEXT(2)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 04/01/2012 por beto

        Try
            cmd.CommandText = "Alter Table Pedido ADD PedOperador Integer"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            cmd.CommandText = "Alter Table Orc ADD OrcOperador Integer"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "ALTER TABLE Pagar ALTER COLUMN NotaFiscal TEXT(20)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            cmd.CommandText = "ALTER TABLE Pagar ALTER COLUMN Documento TEXT(20)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            cmd.CommandText = "ALTER TABLE LancamentoBanco ALTER COLUMN Documento TEXT(20)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            cmd.CommandText = "ALTER TABLE BalanceteLanc ALTER COLUMN Documento TEXT(20)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 11/01/2012 por lelo

        Try
            cmd.CommandText = "ALTER TABLE Compra ALTER COLUMN EspecieDocumento TEXT(5)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'Rotina Inserida 14/01/2012 por Douglas
        Try
            cmd.CommandText = "ALTER TABLE Pedido ADD EnderecoEntrega Text(250)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 26/01/2012 por Douglas
        Try
            cmd.CommandText = "Alter Table ItensCompra ADD BaseCalcIcms Double, BaseCalcIpi Double"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 01/02/2012 por JOSE ROBERTO
        Try
            cmd.CommandText = "ALTER TABLE Clientes ADD Atualizado YesNo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 01/02/2012 por JOSE ROBERTO
        Try
            cmd.CommandText = "ALTER TABLE Produtos ADD Atualizado YesNo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 13/01/2012 por Douglas
        Try
            cmd.CommandText = "ALTER TABLE Fornecedor Add nro TEXT(8), xCpl TEXT(60), cMun TEXT(7), cPais TEXT(4), xPais TEXT(60)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'Rotina Inserida 23/02/2012 por Beto
        Try
            cmd.CommandText = "ALTER TABLE Receber Add Origem TEXT(20)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 23/02/2012 por Beto
        Try
            cmd.CommandText = "UPDATE Receber SET Receber.Origem = 'AVULSO' WHERE (((Receber.Origem) Is Null) AND ((Receber.Documento) Like 'AV*'));"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try



        'Rotina Inserida 14/04/2012 por Lelo
        Try
            cmd.CommandText = "CREATE TABLE Iventario (CodigoProduto  integer, Qtde Double)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        Try
            cmd.CommandText = "CREATE TABLE LocCilindro (LocID  COUNTER, LocCodigoCliente integer, LocCodigoProduto integer, LocQtde integer, LocData datetime,LocControle integer, Constraint LocCilindro_PK Primary Key(Locid))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 19/04/2012 por Douglas

        Try
            cmd.CommandText = "Alter Table ItensCompra ADD ctb TEXT(10), vSeg Double, vOutro Double, CSTICMS TEXT(3), cEnq TEXT(3), CSTIPI TEXT(3), CSTpis TEXT(3), vBCpis Double, CSTcofins TEXT(2), vBCcofins Double"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table ItensCompra ADD MensagemErro Text(20)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'cria a tabela EtiquetaTemp
        Try
            cmd.CommandText = "CREATE TABLE EtiquetaTemp (Id COUNTER, DataCompra Text(10), CodigoProduto Text(10), Descricao Text(150), ValorPrazo Double, Tamanho Text(10))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 08/05/2012 por Douglas
        Try
            cmd.CommandText = "ALTER TABLE Receber ADD CartaoCredito YesNo, Cartao Text(4), DocNSU Text(10), codAutenticacao Text(10), DataAutenticacao DateTime"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "ALTER TABLE Orc ADD ImpressoOrcamento Text(1)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Rotina Inserida 18/05/2012 por Douglas
        Try
            cmd.CommandText = "ALTER TABLE Fornecedor ADD cUF Text(2)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "ALTER TABLE Empresa ADD EsquemaTS yesNO"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'Rotina Inserida 21/05/2012 por Douglas
        Try
            cmd.CommandText = "ALTER TABLE Pagar ADD VencimentoOriginal DateTime"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 21/06/2012 - Douglas Machado
        Try
            cmd.CommandText = "Alter Table Empresa ADD CaixaMovimento Text(4)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try



        'Adicionado data 28/06/2012 - Douglas Machado
        Try
            cmd.CommandText = "CREATE TABLE getAutorizacao (Id COUNTER, Tela Text(50), Usuario Text(15), IdRegistro Text(20), Motivo Text(150), DataHora Text(20), Status Text(15), StatusModificadoPor Text(15), Utilizada YesNo, Constraint PrimaryKey Primary Key(Id))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 04/07/2012 - jose roberto
        Try
            cmd.CommandText = "Alter Table Orc ADD EnderecoEntrega Text(250)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'Adicionado data 10/08/2012 - Douglas 
        Try
            cmd.CommandText = "Alter Table Compra ADD ChaveNFe TEXT(44);"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'Adicionado data 05/09/2012 - Douglas Machado
        Try
            cmd.CommandText = "Alter Table ItensPedido ADD pAcrecimoVenda Double, vAcrecimoVenda Double, pDescontoEspecial Double, vDescontoEspecial Double"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table OrcITEM ADD pAcrecimoVenda Double, vAcrecimoVenda Double, pDescontoEspecial Double, vDescontoEspecial Double"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Adicionado data 17/09/2012 - Marcos Aurélio
        Try
            cmd.CommandText = "Alter Table Clientes Alter RG TEXT(25)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table Fornecedor Alter Endereço TEXT(100)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'Adicionado data 24/09/2012 - Douglas - Alterado a rotina 
        Try
            cmd.CommandText = "Alter Table objetoscad ALTER COLUMN veiculo TEXT(100)"
            cmd.ExecuteNonQuery()

            cmd.CommandText = "Alter Table objetoscad ALTER COLUMN placa TEXT(100)"
            cmd.ExecuteNonQuery()

            cmd.CommandText = "Alter Table objetoscad ALTER COLUMN km TEXT(100)"
            cmd.ExecuteNonQuery()

            cmd.CommandText = "Alter Table objetoscad ALTER COLUMN Renavan TEXT(100)"
            cmd.ExecuteNonQuery()

            cmd.CommandText = "Alter Table objetoscad ALTER COLUMN Cor TEXT(100)"
            cmd.ExecuteNonQuery()

        Catch ex As Exception
        End Try

        'Adicionado data 25/10/2012 - Douglas - Alterado a rotina 
        Try
            cmd.CommandText = "Alter Table Empresa ADD UserAlertaAgendaServico Text(20)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Comentado por douglas - Rotinas para separar o contas a pagar e criar credito ao cliente

        ''Adicionado data 10/10/2012 - Douglas
        'Try
        '    cmd.CommandText = "CREATE TABLE PagarDOC (IdDOC COUNTER, DataLancamento DateTime, ValorTotal Double, Confirmado YesNo, Constraint PrimaryKey Primary Key(IdDoc))"
        '    cmd.ExecuteNonQuery()
        'Catch ex As Exception
        'End Try

        'Try
        '    cmd.CommandText = "CREATE TABLE PagarNF (IdNF COUNTER, IdDOC Double, NF Double, CPFCNPJ TEXT(14),ValorNF Double, Constraint PrimaryKey Primary Key(IdNF))"
        '    cmd.ExecuteNonQuery()
        'Catch ex As Exception
        'End Try

        'Try
        '    cmd.CommandText = "Alter Table Pagar ADD IdDoc Double"
        '    cmd.ExecuteNonQuery()
        'Catch ex As Exception
        'End Try

        'Adicionado data 06/12/2012 - Marcos Aurélio Soares
        Try
            cmd.CommandText = "Alter Table Pagar ALTER COLUMN Referencia Text(200)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'Adicionado data 28/01/2013 - Douglas Machado
        Try
            cmd.CommandText = "Alter Table Produtos Add ValorVendaAtacado Double"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'Adicionado data 25/02/2013 - Douglas Machado
        Try
            cmd.CommandText = "Alter Table Empresa Add ClienteConsumidor Integer"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table Pedido Add ClienteCredito Double"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Douglas 02/04/2013

        Try
            cmd.CommandText = "Alter Table Produtos Add icmsCSTEntr Text(3), cstIPIentr Text(2), cstPISentr text(2), cstCOFINSentr Text(2), CFOPentrEstadual Text(4), CFOPsaidaEstadual Text(4), CFOPentrInterestadual Text(4), CFOPsaidaInterestadual Text(4)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Douglas **/**/2013
        Try
            cmd.CommandText = "Alter Table Produtos Add CodCTBEntrada Text(10)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "CREATE TABLE ProdEmit (CNPJemit Text(20), ProdEmit TEXT(30), ProdErp Text(30), Constraint PrimaryKey Primary Key(CNPJemit, ProdEmit))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table Compra Add Desmenbramento Integer"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table Empresa Add EntradaDesmenbrarNF YesNo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table ItensCompra ADD CSTICMSent TEXT(3), CSTIPIent TEXT(3), CSTPISent TEXT(3), CSTCOFINSent TEXT(3), CFOPent Text(4)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "CREATE TABLE CFOPsaientra (Empresa Integer, CFOPs TEXT(4), CFOPe  TEXT(4), ctb TEXT(10), Constraint PrimaryKey Primary Key(Empresa, CFOPs))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Douglas 17/05/2013
        Try
            cmd.CommandText = "Alter Table Compra ADD CRTfornecedor TEXT(1)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table DuplicataAvulso ALTER COLUMN DNumeroDocumento Text(35)"
            cmd.ExecuteNonQuery()

            cmd.CommandText = "Alter Table DuplicataAvulso ALTER COLUMN  DNf Text(35)"
            cmd.ExecuteNonQuery()

        Catch ex As Exception
        End Try

        'jose roberto 14/06/13
        Try
            cmd.CommandText = "Alter Table ItemServico ADD  ValorCusto Currency"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            cmd.CommandText = "UPDATE ItemServico SET ValorCusto=0 WHERE ItemServico.ValorCusto Is Null"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try


        'Add Douglas 02/07/2013
        Try
            cmd.CommandText = "Alter Table Receber ADD  IdAgrupamento Integer"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table Receber ADD  Agrupada YesNo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "CREATE TABLE ReceberAgrupar (IdAgrupar COUNTER, DataLancamento datetime, Descricao TEXT(100), Cliente Integer, ValorAgrupado  Double, DiasParcelamento Text(90), Confirmado YesNo, Empresa integer, Extornado YesNo, Constraint PrimaryKey Primary Key(IdAgrupar))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'jose roberto 15/07/2013
        Try
            cmd.CommandText = "Alter Table Pedido ADD  NfePecas TEXT(15), NfeServico TEXT(15)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        'jose roberto 23/08/2013
        Try
            cmd.CommandText = "Alter Table Receber ADD  NotaFiscalServico TEXT(15)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            'lelo 05/04/2013
            cmd.CommandText = "Alter Table Receber ALTER COLUMN NotaFiscal TEXT(15)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table ReceberAgrupar ADD Inativo YesNo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            'Jose roberto 26/09/2013
            cmd.CommandText = "Alter Table Receber ADD CodigoContrato Text(6)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            'Jose roberto 02/10/2013
            cmd.CommandText = "Alter Table ClienteCred ADD Pedido INTEGER"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            'Jose roberto 02/12/2013
            cmd.CommandText = "Alter Table Empresa ADD DiaFechamentoMensal INTEGER"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            'Jose roberto 19/02/2014
            cmd.CommandText = "Alter Table Iventario ADD CodigoNfe Text(30)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        'Douglas 20/02/2014
        Try
            cmd.CommandText = "Alter Table Pagar ADD IdAgrupamento INTEGER, Agrupada YesNo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "CREATE TABLE PagarAgrupar (IdAgrupar COUNTER, DataLancamento datetime, Descricao TEXT(100), Fornecedor Integer, ValorAgrupado  Double, DiasParcelamento Text(90), Confirmado YesNo, Empresa integer, Extornado YesNo, Constraint PrimaryKey Primary Key(IdAgrupar))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "Alter Table PagarAgrupar ADD Inativo YesNo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        '----------------------------------------------------------------------------
        ' ROTINAS INSERIDAS POR JOSE ROBERTO 11-03-2014
        '============================================================================
        Try 'Cria a tabela PedidoMateriaPrima.
            cmd.CommandText = "CREATE TABLE PedidoMateriaPrima (NumeroPedido Integer, Modelo Text(1), NomeCliente Text(100), CodigoCliente INTEGER, Observacao Memo, Telefone Text(15), Email Text(50), DataPedido DATETIME, DataFechamento DATETIME, DataPrazoEntrega DATETIME, CodigoFuncionario INTEGER, TotalBruto CURRENCY, TotalDesconto CURRENCY, TotalLiquido CURRENCY, CodigoPagamento INTEGER, Fechado YesNo, Inativo YesNo, ValorBordado Currency, ValorSerigrafia currency, ValorMp Currency, Status Text(10), Contato Text(50), Propriedades INTEGER, ValorAVista DOUBLE, ValorOutros DOUBLE, ValorAFaturar DOUBLE, Empresa INTEGER, DataValidade DATETIME, GeradoPedido YesNo, OrcForPed Integer, Constraint PedidoMateriaPrima_PK Primary Key (NumeroPedido, Modelo))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try 'Cria ReservaMP
            cmd.CommandText = "CREATE TABLE ReservaMP (ResId Counter, ResCodigoMP Integer, ResCodigoPedido INTEGER, ResQtd DOUBLE, Constraint ReservaMP_PK Primary Key (ResId) )"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try 'Cria ItensPedidoMPConfec
            cmd.CommandText = "CREATE TABLE ItensPedidoMPConfec (Id Counter,NumeroPedidoMP Integer, Modelo Text(1), Descricao TExt(200), Tamanho Text(4),Qtd DOUBLE, ValorUnitario DOUBLE, Valortotal DOUBLE, CodigoGrupo Integer, CodigoProdutoMP Integer, QtdReserva Double, LancamentoNaReserva YesNo,  Constraint ItensPedidoMPConfec_PK Primary Key (Id) )"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try 'Cria ItensMP
            cmd.CommandText = "CREATE TABLE ItensMP (Id Counter, Item Integer, NumeroPedidoMP Integer, CodigoMP Integer, Quantidade DOUBLE, ValorUnitario DOUBLE, Valortotal DOUBLE,  Constraint ItensMP_PK Primary Key (Id) )"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try 'Cria OrdemProducaoMP
            cmd.CommandText = "CREATE TABLE OrdemProducaoMP (NumeroOrdem Counter, NumeroPedido Integer, CodigoCliente Integer, Observacao MEMO, Fechado YesNo, Inativo YesNo, Empresa Integer, DataProducao DATETIME,  Constraint OrdemProducaoMP_PK Primary Key (NumeroOrdem) )"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try 'Cria OrdemProducaoMP,
            cmd.CommandText = "CREATE INDEX NumeroPedido ON OrdemProducaoMP (NumeroPedido,CodigoCliente)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            'Jose roberto 11-03-2014
            cmd.CommandText = "Alter Table Produtos ADD Reserva DOUBLE"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            'Jose roberto 11-03-2014
            cmd.CommandText = "Alter Table Receber ADD PedidoMP Integer"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            'Jose roberto 11-03-2014
            cmd.CommandText = "Alter Table ArquivoCheque ADD PedidoMP Integer"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            'Jose roberto 11-03-2014
            cmd.CommandText = "UPDATE Produtos SET Reserva=0 WHERE Reserva Is Null"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            'Jose roberto 11/03/2014
            cmd.CommandText = "Alter Table Empresa ADD UsaMateriaPrima YesNo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            'Jose roberto 11-03-2014
            cmd.CommandText = "Alter Table Empresa ADD Leitor YesNo, Manual YesNo"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            'Jose roberto 11-03-2014
            cmd.CommandText = "UPDATE Empresa SET Leitor=True where Leitor=false And Manual=false"
            cmd.ExecuteNonQuery()

        Catch ex As Exception
        End Try

        Try
            'lelo 22/03/2013
            cmd.CommandText = "Alter Table Produtos ALTER COLUMN CodCTBEntrada TEXT(30)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            'lelo 22/03/2013
            cmd.CommandText = "Alter Table CFOPsaientra ALTER COLUMN Ctb TEXT(30)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            'lelo 22/03/2013
            cmd.CommandText = "Alter Table ItensCompra ALTER COLUMN Ctb TEXT(30)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try



        'Criação do novo  centro de custo Feito por Douglas 18/04/2014
        Try
            cmd.CommandText = "CREATE TABLE Cc1 (ContaGrupo1 Text(4) NOT NULL, DescContaGrupo1 Text(50) NULL,Empresa integer NULL, CONSTRAINT Cc1_PK PRIMARY KEY (ContaGrupo1))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "CREATE TABLE Cc2 (ContaGrupo1 Text(4) NOT NULL,ContaGrupo2 Text(4) NOT NULL,DescContaGrupo2 Text(50) NULL,Empresa integer NULL , CONSTRAINT Cc2_PK PRIMARY KEY (ContaGrupo1,ContaGrupo2), Foreign Key(ContaGrupo1) References Cc1 (ContaGrupo1))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmd.CommandText = "CREATE TABLE Cc3 (ContaGrupo1 Text(4) NOT NULL,ContaGrupo2 Text(4) NOT NULL,ContaGrupo3 Text(6) NOT NULL,DescContaGrupo3 Text(50) NULL,Empresa integer NULL,Protegido bit NOT NULL, CONSTRAINT Cc3_PK PRIMARY KEY (ContaGrupo1,ContaGrupo2,ContaGrupo3), Foreign Key(ContaGrupo1,ContaGrupo2) References Cc2 (ContaGrupo1,ContaGrupo2))"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try



        Try 'Cria TABLE CentroCustoLancameno alterado por Douglas
            cmd.CommandText = "CREATE TABLE CCLanc (ID COUNTER, IdCaixaBanco INTEGER, ContaCC TEXT(6), DataLanc DATETIME, ValorLanc DOUBLE, Empresa INTEGER,  Constraint CCLanc_PK Primary Key (ID), FOREIGN KEY (IdCaixaBanco) REFERENCES LancamentoBanco (Id) ON DELETE CASCADE ON UPDATE CASCADE)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try 'Cria UM indice na tablea CentroCustoLancamento, alterado por Douglas
            cmd.CommandText = "CREATE INDEX ID_INDEX ON CCLanc (IDLancCaixa,ContaCC)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try 'Criado por Douglas
            cmd.CommandText = "Alter Table Empresa ADD ContaCCJuros Text(6), ContaCCMulta Text(6), ContaCCDescConcedido Text(6)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try 'Criado por Douglas
            cmd.CommandText = "Alter Table PagarAgrupar ADD Conta1 Text(6), Conta2 Text(6), Conta3 Text(6), Conta4 Text(6), Conta5 Text(6), Conta6 Text(6), Vlr1 Double, Vlr2 Double, Vlr3 Double, Vlr4 Double, Vlr5 Double, Vlr6 Double, ContaDespesa Text(6)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try '27/04/2014
            cmd.CommandText = "Alter Table CompraCtrlPedido ADD Contrato Text(10)"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        CNN.Close()
        CreateAccessDatabase(LocalBD, "upAgendaDados.Mdb")



        End

    End Sub



    Public Function CreateAccessDatabase(ByVal DatabaseFullPath As String, ByVal DBname As String) As Boolean

        Dim bAns As Boolean
        Dim cat As New ADOX.Catalog()

        Try

            'Verifica se a pasta existe
            If Not IO.Directory.Exists(DatabaseFullPath) Then
                IO.Directory.CreateDirectory(DatabaseFullPath)
            End If

            If Not IO.File.Exists(DatabaseFullPath & DBname) Then

                Dim sCreateString As String
                sCreateString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DatabaseFullPath & DBname
                cat.Create(sCreateString)

                bAns = True
                cat = Nothing

            End If

        Catch Excep As System.Runtime.InteropServices.COMException
            bAns = False
            'do whatever else you need to do here, log, 
            'msgbox etc.
        Finally
            cat = Nothing
        End Try



        Dim CNNAgendaServico As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & DBname))
        CNNAgendaServico.Open()

        Dim cmdAgendaServico As New OleDb.OleDbCommand
        cmdAgendaServico.Connection = CNNAgendaServico


        Try
            cmdAgendaServico.CommandText = "CREATE TABLE AgendaServico (Id Counter, Cliente Double, ClienteDesc Text(50), DataLancamento DateTime, Compromisso Memo, DataAgenda DateTime, DiasAntecipadoAvisar Integer, HorasCompromisso Text(8),Status Text(15), Constraint PrimaryKey Primary Key(Id))"
            cmdAgendaServico.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            cmdAgendaServico.CommandText = "Alter Table AgendaServico ADD Usuario TEXT(15)"
            cmdAgendaServico.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        Try
            'lelo 05/04/2013
            cmdAgendaServico.CommandText = "Alter Table AgendaServico ALTER COLUMN ClienteDesc TEXT(70)"
            cmdAgendaServico.ExecuteNonQuery()
        Catch ex As Exception
        End Try

       



        

        CNNAgendaServico.Close()


        Return bAns



    End Function



End Module
