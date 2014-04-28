Imports System.Data.OleDb
Public Class ReservaMP
    Private mresid As Integer
    Private mresCodigoPedido As Integer
    Private mresCodigoMP As Integer
    Private mresQtd As Double
    Dim db As New clsBancoDados
    Public delType As eDel
    Dim tb As New DataTable()
    Enum eDel
        All = 1
        One = 0
    End Enum
 
    Public Property Resid() As Integer
        Get
            Return mresid
        End Get
        Set(ByVal value As Integer)
            mresid = value
        End Set
    End Property

    Public Property ResCodigoPedido() As Integer
        Get
            Return mresCodigoPedido
        End Get
        Set(ByVal value As Integer)
            mresCodigoPedido = value
        End Set
    End Property

    Public Property ResCodigoMP() As Integer
        Get
            Return mresCodigoMP
        End Get
        Set(ByVal value As Integer)
            mresCodigoMP = value
        End Set
    End Property

    Public Property ResQtd() As Double
        Get
            Return mresQtd
        End Get
        Set(ByVal value As Double)
            mresQtd = value
        End Set
    End Property

    Public Sub cloneTb()

        tb.Columns.Add("A", GetType(Integer))
        tb.Columns.Add("B", GetType(Double))
        For Each row As DataGridViewRow In My.Forms.frmPedidoMP.dgvReserva.Rows
            tb.Rows.Add(Integer.Parse(row.Cells("Codigo").Value), Double.Parse(row.Cells(2).Value))
        Next row
    End Sub
    Public Sub gravar()
        Dim sql As String
        sql = "INSERT INTO ReservaMP (resCodigoPedido,ResQtd,ResCodigoMP)" _
                             & " Values (@1,@2,@3)"


        Dim cnn As New OleDbConnection
        cnn = db.AbreBanco
        Try

            Dim cmd As New OleDbCommand(sql, cnn)
            With cmd.Parameters
                .Add(New OleDb.OleDbParameter("@1", Me.ResCodigoPedido))
                .Add(New OleDb.OleDbParameter("@2", Me.ResQtd))
                .Add(New OleDb.OleDbParameter("@3", Me.ResCodigoMP))
            End With
            cmd.ExecuteNonQuery()


        Catch ex As Exception

            Throw ex
        Finally
            db.fechabanco(cnn)
        End Try

    End Sub
    Public Sub Exluir(ByVal xID As Integer)
        Dim sql As String = String.Empty
        Dim cnn As New OleDbConnection

        Select Case delType
            Case eDel.All
                sql = "Delete * from ReservaMP where resCodigoPedido=" & xID
            Case eDel.One
                sql = "Delete * from ReservaMP where ResId=" & xID
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
    Public Sub AtSaldoReserva(ByVal xMP As Integer)
        Dim dReserva As Double = 0
        Dim sql As String

        sql = "SELECT RESERVAMP.ResCodigoMP, Sum(RESERVAMP.ResQtd) AS SomaDeResQtd FROM RESERVAMP GROUP BY RESERVAMP.ResCodigoMP HAVING (((RESERVAMP.ResCodigoMP)=" & xMP & "));"
        Dim conn As New OleDbConnection
        Dim DR As OleDbDataReader
        Try
            conn = db.AbreBanco()
            Dim cmd As New OleDbCommand(sql, conn)
            DR = cmd.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                dReserva = DR.Item(1)
            End If

            Dim cmd1 As New OleDbCommand("UPDATE Produtos SET RESERVA='" & dReserva & "' WHERE CodigoProduto=" & xMP, conn)
            cmd1.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            db.fechabanco(conn)
        End Try
    End Sub
    Public Sub AtSaldoReservaAll()
        'tb.Dispose()
        'cloneTb()
        Dim dReserva As Double = 0
        Dim sql As String

        Dim conn As New OleDbConnection
        conn = db.AbreBanco()
        Dim cmd As New OleDbCommand
        Dim DR As OleDbDataReader
        Try

            For Each drw As DataRow In tb.Rows
                sql = "SELECT RESERVAMP.ResCodigoMP, Sum(RESERVAMP.ResQtd) AS SomaDeResQtd FROM RESERVAMP GROUP BY RESERVAMP.ResCodigoMP HAVING (((RESERVAMP.ResCodigoMP)=" & drw.Item(0) & "));"
                cmd.CommandText = sql
                cmd.Connection = conn
                DR = cmd.ExecuteReader
                DR.Read()
                If DR.HasRows Then
                    dReserva = DR.Item(1)
                End If
                Dim cmd1 As New OleDbCommand("UPDATE Produtos SET RESERVA='" & dReserva & "' WHERE CodigoProduto=" & drw.Item(0), conn)
                cmd1.ExecuteNonQuery()
                DR.Close()
            Next
        Catch ex As Exception
            conn.Close()
        Finally
            conn.Close()

        End Try


    End Sub
    Public Sub AtGrade(ByVal xPed As Integer)

        Dim sql As String = "Select ResId, ResCodigoMP,ResQtd From ReservaMP WHERE ResCodigoPedido=" & xPed
        Dim cnn As New OleDbConnection


        cnn = db.AbreBanco
        Dim CMD As New OleDb.OleDbCommand(sql, cnn)
        Dim Da As New OleDb.OleDbDataAdapter(CMD)

        Dim ds As New DataSet

        Try


            Da.Fill(ds, "Table")

            frmPedidoMP.dgvReserva.DataSource = ds.Tables("Table").DefaultView

            Da.Dispose()

            cnn.Close()
        Catch ex As Exception
            Da.Dispose()
            cnn.Close()
        Finally
            cnn.Close()
        End Try
    End Sub


End Class
