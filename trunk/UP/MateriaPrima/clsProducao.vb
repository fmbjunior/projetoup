Imports System.Data.OleDb
Public Class clsProducao
    Private _cRetorno As String
    Dim db As New clsBancoDados

    Private _numeropedido As String
    Private _codigocliente As String
    Private _numeroOrdem As String
    Private _empresa As String
    Private _dataordem As String
    Private _obs As String
    Private _erroRetorno As Boolean

    Public Property Numeropedido() As String
        Get
            Return _numeropedido
        End Get
        Set(ByVal value As String)
            _numeropedido = value
        End Set
    End Property

    Public Property Codigocliente() As String
        Get
            Return _codigocliente
        End Get
        Set(ByVal value As String)
            _codigocliente = value
        End Set
    End Property

    Public Property Empresa() As String
        Get
            Return _empresa
        End Get
        Set(ByVal value As String)
            _empresa = value
        End Set
    End Property

    Public Property Dataordem() As String
        Get
            Return _dataordem
        End Get
        Set(ByVal value As String)
            _dataordem = value
        End Set
    End Property

    Public Property Obs() As String
        Get
            Return _obs
        End Get
        Set(ByVal value As String)
            _obs = value
        End Set
    End Property

    Public Sub Gravar()
        Dim sql As String
        sql = "INSERT INTO ORDEMPRODUCAOMP (NumeroPedido, CodigoCliente, Observacao, Empresa, DataProducao) Values (@1,@2,@3,@4,@5)"

        Dim conn As New OleDbConnection
        Try
            conn = db.AbreBanco

            Dim cmd As OleDbCommand

            cmd = New OleDbCommand(sql, conn)
            With cmd.Parameters
                .Add(New OleDb.OleDbParameter("@1", _numeropedido))
                .Add(New OleDb.OleDbParameter("@2", Nz(_codigocliente, 1)))
                .Add(New OleDb.OleDbParameter("@3", Nz(_obs, 1)))
                .Add(New OleDb.OleDbParameter("@4", Nz(_empresa, 1)))
                .Add(New OleDb.OleDbParameter("@5", Nz(_dataordem, 1)))

            End With
            'Dim ss As Object = System.DBNull.Value
            'Dim tt As String = NzVlr(ss)
            cmd.ExecuteNonQuery()
            cmd.CommandText = "SELECT @@IDENTITY"
            cRetorno = cmd.ExecuteScalar.ToString

            ErroRetorno = False

        Catch ex As Exception

            ErroRetorno = True
        Finally
            conn.Close()
        End Try
    End Sub
    Public Function BuscarGrid(ByRef ds As DataSet)
        Dim cnn As New OleDbConnection

        Dim Sql As String = "SELECT OrdemProducaoMP.NumeroOrdem, OrdemProducaoMP.NumeroPedido, PedidoMateriaPrima.NomeCliente, OrdemProducaoMP.DataProducao FROM PedidoMateriaPrima INNER JOIN OrdemProducaoMP ON PedidoMateriaPrima.NumeroPedido = OrdemProducaoMP.NumeroPedido WHERE (((PedidoMateriaPrima.Modelo)='P'));"

        cnn = db.AbreBanco
        Dim CMD As New OleDb.OleDbCommand(sql, cnn)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Try
            Da.Fill(ds, "Table")
            Da.Dispose()
            cnn.Close()
            Return ds
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return ds
        Finally
            cnn.Close()
        End Try

    End Function
    Public Sub Buscar(ByVal vValor As String)
        Dim cnn As New OleDbConnection

        Dim Sql As String = "Select * FROM OrdemProducaoMP WHERE NumeroOrdem=" & vValor

        Dim DR As OleDb.OleDbDataReader
        Try
            cnn = db.AbreBanco

            Dim cmd As New OleDbCommand(Sql, cnn)
            DR = cmd.ExecuteReader
            DR.Read()

            If DR.HasRows Then 'tem pedido na ordem
                Numeropedido = String.Format("{0:000000}", DR.Item("NumeroPedido"))
                NumeroOrdem = String.Format("{0:000000}", DR.Item("NumeroOrdem"))
                Dataordem = DR.Item("DataProducao")
                ErroRetorno = False

            Else
                ErroRetorno = True
            End If
        Catch ex As Exception
            Throw ex
        Finally
            cnn.Close()
        End Try
    End Sub
    Public Function TemOP(ByVal xID As Integer) As Boolean
        Dim cnn As New OleDbConnection

        Dim Sql As String = "Select * FROM OrdemProducaoMP WHERE NumeroPedido=" & xID

        Dim DR As OleDb.OleDbDataReader
        Try
            cnn = db.AbreBanco

            Dim cmd As New OleDbCommand(Sql, cnn)
            DR = cmd.ExecuteReader
            DR.Read()

            If DR.HasRows Then 'tem pedido na ordem
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Throw ex
        Finally
            cnn.Close()
        End Try

    End Function


    Public Property ErroRetorno() As Boolean
        Get
            Return _erroRetorno
        End Get
        Set(ByVal value As Boolean)
            _erroRetorno = value
        End Set
    End Property

    Public Property CRetorno() As String
        Get
            Return _cRetorno
        End Get
        Set(ByVal value As String)
            _cRetorno = value
        End Set
    End Property

    Public Property NumeroOrdem() As String
        Get
            Return _numeroOrdem
        End Get
        Set(ByVal value As String)
            _numeroOrdem = value
        End Set
    End Property

End Class
