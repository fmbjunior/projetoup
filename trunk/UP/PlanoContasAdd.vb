Imports System.Data.OleDb
Public Class PlanoContasAdd

#Region "Variaveis para popular Lista de Procura"

    Private DataLancamento As Date
    Public Property Plc_DataLancamento() As Date
        Get
            Return DataLancamento
        End Get
        Set(ByVal value As Date)
            DataLancamento = value
        End Set
    End Property

    Private PlanoContas As String
    Public Property Plc_PlanoContas() As String
        Get
            Return PlanoContas
        End Get
        Set(ByVal value As String)
            PlanoContas = value
        End Set
    End Property

    Private ContraPartida As String
    Public Property Plc_ContraPartida() As String
        Get
            Return ContraPartida
        End Get
        Set(ByVal value As String)
            ContraPartida = value
        End Set
    End Property

    Private Documento As String
    Public Property Plc_Documento() As String
        Get
            Return Documento
        End Get
        Set(ByVal value As String)
            Documento = value
        End Set
    End Property

    Private DataDocumento As Date
    Public Property Plc_DataDocumento() As Date
        Get
            Return DataDocumento
        End Get
        Set(ByVal value As Date)
            DataDocumento = value
        End Set
    End Property

    Private ValorDebito As Double
    Public Property Plc_ValorDebito() As Double
        Get
            Return ValorDebito
        End Get
        Set(ByVal value As Double)
            ValorDebito = value
        End Set
    End Property

    Private ValorCredito As Double
    Public Property Plc_ValorCredito() As Double
        Get
            Return ValorCredito
        End Get
        Set(ByVal value As Double)
            ValorCredito = value
        End Set
    End Property

    Private Historico As String
    Public Property Plc_Historico() As String
        Get
            Return Historico
        End Get
        Set(ByVal value As String)
            Historico = value
        End Set
    End Property

    Private Empresa As Integer
    Public Property Plc_Empresa() As Integer
        Get
            Return Empresa
        End Get
        Set(ByVal value As Integer)
            Empresa = value
        End Set
    End Property

    Private IdLancamento As String
    Public Property Plc_IdLancamento() As String
        Get
            Return IdLancamento
        End Get
        Set(ByVal value As String)
            IdLancamento = value
        End Set
    End Property

    Private IdOrigem As Integer
    Public Property Plc_IdOrigem() As Integer
        Get
            Return IdOrigem
        End Get
        Set(ByVal value As Integer)
            IdOrigem = value
        End Set
    End Property

    Private NF As Double
    Public Property Plc_NotaFiscal() As Double
        Get
            Return NF
        End Get
        Set(ByVal value As Double)
            NF = value
        End Set
    End Property


#End Region

    Public Sub Plc_FazerLançamento()


        Dim Cnn As New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & LocalBD & Nome_BD)
        Cnn.Open()

        Dim Cmd As New OleDbCommand()
        Dim Ult As String

        Ult = CalcIdLancamento()


        Dim Sql As String = "INSERT INTO " & AnoContabel & " ( DataLancamento, PlanoContas, ContraPartida, Documento, DataDocumento, ValorDebito, ValorCredito, Historico, Empresa, IdLancamento, IdProcura, IdOrigem, NotaFiscal) VALUES ( @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
        Cmd = New OleDb.OleDbCommand(Sql, Cnn)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Plc_DataLancamento))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Plc_PlanoContas))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Plc_ContraPartida))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Plc_Documento))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Plc_DataDocumento))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Plc_ValorDebito))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Plc_ValorCredito))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Plc_Historico))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Plc_Empresa))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Plc_IdLancamento))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Ult))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Plc_IdOrigem))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Plc_NotaFiscal))

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            CriaLogErro(UserAtivo, "Erro ao Adicionar o Registro de Partida na tabela Lançamento de plano de Contas")
            MsgBox(ex.Message, 64, TituloMsgbox)
        End Try

        'Contra Partida

        Sql = "INSERT INTO " & AnoContabel & " ( DataLancamento, PlanoContas, ContraPartida, Documento, DataDocumento, ValorDebito, ValorCredito, Historico, Empresa, IdLancamento, IdProcura, IdOrigem, NotaFiscal) VALUES (@2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
        Cmd = New OleDb.OleDbCommand(Sql, Cnn)

        Cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Plc_DataLancamento))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Plc_ContraPartida))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Plc_PlanoContas))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Plc_Documento))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@6", Plc_DataDocumento))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@7", Plc_ValorCredito))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@8", Plc_ValorDebito))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@9", Plc_Historico))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@10", Plc_Empresa))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@11", Plc_IdLancamento))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@12", Ult))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@13", Plc_IdOrigem))
        Cmd.Parameters.Add(New OleDb.OleDbParameter("@14", Plc_NotaFiscal))

        Try
            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            CriaLogErro(UserAtivo, "Erro ao Adicionar o Registro de Contra Partida na tabela Lançamento de plano de Contas")
            MsgBox(ex.Message, 64, TituloMsgbox)
        End Try

        Cnn.Close()
    End Sub



End Class
