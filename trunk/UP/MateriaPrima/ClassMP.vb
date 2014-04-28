Imports System.Data.OleDb
Public Class ClassMP

    Private m_valortotal As Double
    Private m_valorunitario As Double
    Private m_qtd As Double
    Private m_codigomateriaprima As Integer
    Private m_numeropedido As Integer
    Private m_unidadeMedida As String
    Private m_descricao As String
    Private m_erroRetorno As Boolean

    Dim db As New clsBancoDados
    Enum eDel
        All = 1
        One = 0
    End Enum
    Public delType As eDel
    Public Sub Buscar(ByVal vValor As String)
        Dim cnn As New OleDbConnection

        Dim Sql As String = "SELECT CodigoProduto, Tipo, Descrição, UnidadeMedida, ValorVenda  FROM Produtos WHERE Tipo=2 AND CodigoProduto=" & vValor

        Dim DR As OleDb.OleDbDataReader
        Try
            cnn = db.AbreBanco
            Dim cmd As New OleDbCommand(Sql, cnn)
            DR = cmd.ExecuteReader
            DR.Read()
            If DR.HasRows Then 'Encotrou materia prima
                codigomateriaprima = DR.Item("CodigoProduto")
                Descricao = DR.Item("Descrição")
                UnidadeMedida = DR.Item("UnidadeMedida")
                valorunitario = DR.Item("ValorVenda")
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
    Public Function AtGrade(ByVal ds As DataSet, ByVal vPed As Integer)
        Dim sql As String = "SELECT ItensMP.Id, ItensMP.CodigoMP, Produtos.Descrição, Produtos.UnidadeMedida, ItensMP.Quantidade, ItensMP.ValorUnitario, ItensMP.ValorTotal FROM ItensMP INNER JOIN Produtos ON ItensMP.CodigoMP = Produtos.CodigoProduto WHERE ItensMP.NumeroPedidoMP=" & vPed
        Dim cnn As New OleDbConnection

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
    Public Sub Gravar()
        Dim sql As String
        sql = "INSERT INTO ItensMP (NumeroPedidoMP,CodigoMP,Quantidade,ValorUnitario,Valortotal)" _
                             & " Values (@1,@2,@3,@4,@5)"

        Dim cnn As New OleDbConnection
        cnn = db.AbreBanco
        Try
            Dim cmd As New OleDbCommand(sql, cnn)
            With cmd.Parameters
                .Add(New OleDb.OleDbParameter("@1", NumeroPedido))
                .Add(New OleDb.OleDbParameter("@2", codigomateriaprima))
                .Add(New OleDb.OleDbParameter("@3", NzZero(qtd)))
                .Add(New OleDb.OleDbParameter("@4", NzZero(valorunitario)))
                .Add(New OleDb.OleDbParameter("@5", NzZero(valortotal)))
            End With
            cmd.ExecuteNonQuery()
            ErroRetorno = False
        Catch ex As Exception

            MessageBox.Show("Houve erro ao gravar o item", "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ErroRetorno = True
        Finally
            db.fechabanco(cnn)
        End Try
    End Sub
    Public Sub Editar(ByVal xID As Integer)

        Dim sql As String

        sql = "Update ItensMP Set CodigoMP=@2, Quantidade=@3,ValorUnitario=@4,Valortotal=@5 where id=" & xID
        Dim cnn As New OleDbConnection

        Try
            cnn = db.AbreBanco
            Dim cmd As New OleDbCommand(sql, CNN)
            With cmd.Parameters
                .Add(New OleDb.OleDbParameter("@2", codigomateriaprima))
                .Add(New OleDb.OleDbParameter("@3", NzZero(qtd)))
                .Add(New OleDb.OleDbParameter("@4", NzZero(valorunitario)))
                .Add(New OleDb.OleDbParameter("@5", NzZero(valortotal)))
            End With
            cmd.ExecuteNonQuery()

        Catch ex As Exception

            Throw ex
        Finally
            db.fechabanco(cnn)
        End Try


    End Sub
    Public Sub Excluir(ByVal xID As Integer)

        Dim sql As String = String.Empty
        Dim cnn As New OleDbConnection
        Select Case delType
            Case eDel.One
                sql = "Delete * from ItensMP where id=" & xID
            Case eDel.All
                sql = "Delete * from ItensMP where NumeroPedidoMP=" & xID
        End Select


        Try
            cnn = db.AbreBanco
            Dim cmd As New OleDbCommand(sql, CNN)
            cmd.ExecuteNonQuery()
            ErroRetorno = False
        Catch ex As Exception
            MessageBox.Show("Houve erro ao Excluir o item", "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ErroRetorno = True
        Finally
            db.fechabanco(cnn)
        End Try
    End Sub
    Public Sub ExcluirPar(ByVal xID As Integer)
        Dim sql As String = String.Empty
        Dim cnn As New OleDbConnection
        Select Case delType
            Case eDel.All
                sql = "Delete * from Receber where PedidoMP=" & xID
        End Select
        Try
            cnn = db.AbreBanco
            Dim cmd As New OleDbCommand(sql, cnn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            db.fechabanco(cnn)
        End Try
    End Sub
    Public Property codigomateriaprima() As Integer
        Get
            Return m_codigomateriaprima
        End Get
        Set(ByVal value As Integer)
            m_codigomateriaprima = value
        End Set
    End Property

    Private m_id As Integer

    Public Property id() As Integer
        Get
            Return m_id
        End Get
        Set(ByVal value As Integer)
            m_id = value
        End Set
    End Property

    Public Property numeropedido() As Integer
        Get
            Return m_numeropedido
        End Get
        Set(ByVal value As Integer)
            m_numeropedido = value
        End Set
    End Property

    Public Property qtd() As Double
        Get
            Return m_qtd
        End Get
        Set(ByVal value As Double)
            m_qtd = value
        End Set
    End Property

    Public Property valorunitario() As Double
        Get
            Return m_valorunitario
        End Get
        Set(ByVal value As Double)
            m_valorunitario = value
        End Set
    End Property

    Public Property valortotal() As Double
        Get
            Return m_valortotal
        End Get
        Set(ByVal value As Double)
            m_valortotal = value
        End Set
    End Property

    Public Property UnidadeMedida() As String
        Get
            Return m_unidadeMedida
        End Get
        Set(ByVal value As String)
            m_unidadeMedida = value
        End Set
    End Property

    Public Property Descricao() As String
        Get
            Return m_descricao
        End Get
        Set(ByVal value As String)
            m_descricao = value
        End Set
    End Property

    Public Property ErroRetorno() As Boolean
        Get
            Return m_erroRetorno
        End Get
        Set(ByVal value As Boolean)
            m_erroRetorno = value
        End Set
    End Property

End Class