Imports System.Data.OleDb
Public Class clsItemMP
    Private m_NumeroPedido As Integer
    Private m_ID As Integer
    Private m_Descricao As String
    Private m_Tamanho As String
    Private m_Qtd As Double
    Private m_ValorUnitario As Double
    Private m_ValorTotal As Double
    Private m_QtdReserva As Double
    Private m_LancamentoNaReserva As Boolean
    Private m_modelo As String
    Private m_item As Integer
    Dim db As New clsBancoDados

    Public Sub AtGrade(ByVal xID As Integer)
        Dim sql As String = "Select Id, NumeroPedidoMP,Descricao,tamanho,Qtd,ValorUnitario,ValorTotal From ItensPedidoMPConfec WHERE Modelo='" & Modelo & "' And NumeroPedidoMP=" & xID
        Dim cnn As New OleDbConnection


        cnn = db.AbreBanco
        Dim CMD As New OleDb.OleDbCommand(sql, cnn)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet

        Try

            Da.Fill(ds, "Table")
            frmPedidoMP.dgvItemGeral.DataSource = ds.Tables("Table").DefaultView
            frmPedidoMP.TotalDosItem.Text = FormatCurrency(NzZero(ds.Tables(0).Compute("SUM(ValorTotal)", "")), 2)
            frmPedidoMP.TotalLiquido.Text = FormatCurrency(NzZero(ds.Tables(0).Compute("SUM(ValorTotal)", "")) - CDbl(frmPedidoMP.ValorDesconto.Text), 2)
            frmPedidoMP.txtPecas.Text = FormatNumber(NzZero(ds.Tables(0).Compute("SUM(qtd)", "")), 2)
            Da.Dispose()
            cnn.Close()


        Catch ex As Exception
            Da.Dispose()
            cnn.Close()
        Finally
            cnn.Close()
        End Try
    End Sub
    Public Sub Gravar()

        Dim sql As String
        sql = "INSERT INTO ItensPedidoMPConfec (NumeroPedidoMP,Descricao,Tamanho,Qtd,ValorUnitario,ValorTotal,Modelo)" _
                             & " Values (@1,@2,@3,@4,@5,@6,@7)"


        Dim cnn As New OleDbConnection
        cnn = db.AbreBanco
        Try

            Dim cmd As New OleDbCommand(sql, cnn)
            With cmd.Parameters
                .Add(New OleDb.OleDbParameter("@1", NumeroPedido))
                .Add(New OleDb.OleDbParameter("@2", Descricao))
                .Add(New OleDb.OleDbParameter("@3", Tamanho))
                .Add(New OleDb.OleDbParameter("@4", NzZero(Qtd)))
                .Add(New OleDb.OleDbParameter("@5", NzZero(ValorUnitario)))
                .Add(New OleDb.OleDbParameter("@6", NzZero(ValorTotal)))
                .Add(New OleDb.OleDbParameter("@7", Modelo))

            End With
            cmd.ExecuteNonQuery()


        Catch ex As Exception

            Throw ex
        Finally
            db.fechabanco(cnn)
        End Try


    End Sub
    Public Sub Editar(ByVal xID As Integer)

        Dim sql As String

        sql = "Update ItensPedidoMPConfec Set Descricao=@2, Tamanho=@3,qtd=@4,valorunitario=@5,ValorTotal=@6 where  id=" & xID
        Dim cnn As New OleDbConnection

        Try
            cnn = db.AbreBanco
            Dim cmd As New OleDbCommand(sql, CNN)
            With cmd.Parameters
                .Add(New OleDb.OleDbParameter("@2", Descricao))
                .Add(New OleDb.OleDbParameter("@3", Tamanho))
                .Add(New OleDb.OleDbParameter("@4", NzZero(Qtd)))
                .Add(New OleDb.OleDbParameter("@5", NzZero(ValorUnitario)))
                .Add(New OleDb.OleDbParameter("@6", NzZero(ValorTotal)))
            End With
            cmd.ExecuteNonQuery()

        Catch ex As Exception

            Throw ex
        Finally
            db.fechabanco(cnn)
        End Try


    End Sub
    ''' <summary>
    ''' Usando para Excluir os itens de Pedido MP
    ''' </summary>
    ''' <param name="xID">codigoLinha</param>
    ''' <remarks></remarks>
    Public Sub Excluir(ByVal xID As Integer)
        Dim sql As String
        Dim cnn As New OleDbConnection

        sql = "Delete id from ItensPedidoMPConfec where id=" & xID

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
    ''' <summary>
    ''' Usando para Excluir os itens de Pedido MP
    ''' </summary>
    ''' <param name="xID">CodigoPedido</param>
    ''' <param name="opc">P OU O</param>
    Public Sub Excluir(ByVal xID As Integer, ByVal opc As String)
        Dim sql As String
        Dim cnn As New OleDbConnection
        sql = "Delete * from ItensPedidoMPConfec where NumeroPedidoMP=" & xID & " AND Modelo='" & opc & "'"

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

    Public Sub Localizar(ByVal xID As Integer)

        Dim sql As String

        sql = "Select * from ItensPedidoMPConfec WHERE id=" & xID
        Dim conn As New OleDbConnection
        Dim DR As OleDbDataReader
        Try
            conn = db.AbreBanco()
            Dim cmd As New OleDbCommand(sql, conn)
            DR = cmd.ExecuteReader
            DR.Read()

            ID = DR.Item("id")
            Descricao = DR.Item("descricao")
            Tamanho = DR.Item("tamanho")
            Qtd = DR.Item("qtd")
            ValorUnitario = DR.Item("valorunitario")
            ValorTotal = DR.Item("valortotal")



        Catch ex As Exception
            Throw ex
        Finally
            db.fechabanco(conn)
        End Try

    End Sub

    Public Property NumeroPedido() As Integer
        Get
            Return m_NumeroPedido
        End Get
        Set(ByVal value As Integer)
            m_NumeroPedido = value
        End Set
    End Property

    Public Property Descricao() As String
        Get
            Return m_Descricao
        End Get
        Set(ByVal value As String)
            m_Descricao = value
        End Set
    End Property

    Public Property Tamanho() As String
        Get
            Return m_Tamanho
        End Get
        Set(ByVal value As String)
            m_Tamanho = value
        End Set
    End Property

    Public Property Qtd() As Double
        Get
            Return m_Qtd
        End Get
        Set(ByVal value As Double)
            m_Qtd = value
        End Set
    End Property

    Public Property ValorUnitario() As Double
        Get
            Return m_ValorUnitario
        End Get
        Set(ByVal value As Double)
            m_ValorUnitario = value
        End Set
    End Property

    Public Property ValorTotal() As Double
        Get
            Return m_ValorTotal
        End Get
        Set(ByVal value As Double)
            m_ValorTotal = value
        End Set
    End Property

    Public Property QtdReserva() As Double
        Get
            Return m_QtdReserva
        End Get
        Set(ByVal value As Double)
            m_QtdReserva = value
        End Set
    End Property

    Public Property LancamentoNaReserva() As Boolean
        Get
            Return m_LancamentoNaReserva
        End Get
        Set(ByVal value As Boolean)
            m_LancamentoNaReserva = value
        End Set
    End Property

    Public Property ID() As Integer
        Get
            Return m_ID
        End Get
        Set(ByVal value As Integer)
            m_ID = value
        End Set
    End Property

    Public Property Modelo() As String
        Get
            Return m_modelo
        End Get
        Set(ByVal value As String)
            m_modelo = value
        End Set
    End Property

    Public Property Item() As String
        Get
            Return m_item
        End Get
        Set(ByVal value As String)
            m_item = value
        End Set
    End Property

End Class
