Imports System.Data.OleDb

Public Class clsDuplicataAvulso
    Private nCodigoCliente As Integer
    Private nNumeroDocumento As String
    Private nNotaFiscal As String
    Private nControle As String
    Private nDataEmissao As Date
    Private nParcelas As Single
    Private nVenc1 As String
    Private nVenc2 As String
    Private nVenc3 As String
    Private nVenc4 As String
    Private nValor1 As Double
    Private nValor2 As Double
    Private nValor3 As Double
    Private nValor4 As Double
    Public UltimoRegistro As Integer
    Public Property CodigoCliente() As Integer
        Get
            Return nCodigoCliente
        End Get
        Set(ByVal value As Integer)
            nCodigoCliente = value
        End Set
    End Property

    Public Property NumeroDocumento() As String
        Get
            Return nNumeroDocumento
        End Get
        Set(ByVal value As String)
            nNumeroDocumento = value
        End Set
    End Property

    Public Property NotaFiscal() As String
        Get
            Return nNotaFiscal
        End Get
        Set(ByVal value As String)
            nNotaFiscal = value
        End Set
    End Property

    Public Property Controle() As String
        Get
            Return nControle
        End Get
        Set(ByVal value As String)
            nControle = value
        End Set
    End Property

    Public Property DataEmissao() As Date
        Get
            Return nDataEmissao
        End Get
        Set(ByVal value As Date)
            nDataEmissao = value
        End Set
    End Property

    Public Property Parcelas() As Single
        Get
            Return nParcelas
        End Get
        Set(ByVal value As Single)
            nParcelas = value
        End Set
    End Property

    Public Property Venc1() As String
        Get
            Return nVenc1
        End Get
        Set(ByVal value As String)
            nVenc1 = value
        End Set
    End Property

    Public Property Venc2() As String
        Get
            Return nVenc2
        End Get
        Set(ByVal value As String)
            nVenc2 = value
        End Set
    End Property

    Public Property Venc3() As String
        Get
            Return nVenc3
        End Get
        Set(ByVal value As String)
            nVenc3 = value
        End Set
    End Property

    Public Property Venc4() As String
        Get
            Return nVenc4
        End Get
        Set(ByVal value As String)
            nVenc4 = value
        End Set
    End Property

    Public Property Valor1() As Double
        Get
            Return nValor1
        End Get
        Set(ByVal value As Double)
            nValor1 = value
        End Set
    End Property

    Public Property Valor2() As Double
        Get
            Return nValor2
        End Get
        Set(ByVal value As Double)
            nValor2 = value
        End Set
    End Property

    Public Property Valor3() As Double
        Get
            Return nValor3
        End Get
        Set(ByVal value As Double)
            nValor3 = value
        End Set
    End Property

    Public Property Valor4() As Double
        Get
            Return nValor4
        End Get
        Set(ByVal value As Double)
            nValor4 = value
        End Set
    End Property
    Public Sub Gravar()

        Dim Sql As String = "INSERT INTO DuplicataAvulso (DCodigoCliente, DNumeroDocumento,DNF,DDataEmissao,DParcelas,DVenc1,DVenc2,DVenc3,DVenc4,DValor1,DValor2,DValor3,DValor4) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?)"

        Dim conn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Try
            conn.Open()
            Dim cmd As New OleDbCommand(sql, conn)
            With cmd.Parameters
                .Add(New OleDb.OleDbParameter("@1", CodigoCliente))
                .Add(New OleDb.OleDbParameter("@2", NumeroDocumento))
                .Add(New OleDb.OleDbParameter("@3", NotaFiscal))
                .Add(New OleDb.OleDbParameter("@4", DataEmissao))
                .Add(New OleDb.OleDbParameter("@5", Parcelas))
                .Add(New OleDb.OleDbParameter("@6", Nz(Venc1, 1)))
                .Add(New OleDb.OleDbParameter("@7", Nz(Venc2, 1)))
                .Add(New OleDb.OleDbParameter("@8", Nz(Venc3, 1)))
                .Add(New OleDb.OleDbParameter("@9", Nz(Venc4, 1)))
                .Add(New OleDb.OleDbParameter("@10", Valor1))
                .Add(New OleDb.OleDbParameter("@11", Valor2))
                .Add(New OleDb.OleDbParameter("@12", Valor3))
                .Add(New OleDb.OleDbParameter("@13", Valor4))

            End With
            cmd.ExecuteNonQuery()

            cmd.CommandText = "SELECT @@IDENTITY"
            UltimoRegistro = cmd.ExecuteScalar.ToString


        Catch ex As Exception
            Throw ex
        Finally
            conn.Close()
        End Try


    End Sub
    Public Sub Editar(ByVal xID As Integer)



        Dim Sql As String = "UPDATE DuplicataAvulso SET DCodigoCliente=?, DNumeroDocumento=?,DNF=?,DDataEmissao=?,DParcelas=?,DVenc1=?,DVenc2=?,DVenc3=?,DVenc4=?,DValor1=?,DValor2=?,DValor3=?,DValor4=? WHERE Dcodigo=" & xID
        Dim conn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Try
            conn.Open()
            Dim cmd As New OleDbCommand(sql, conn)
            With cmd.Parameters
                .Add(New OleDb.OleDbParameter("@1", CodigoCliente))
                .Add(New OleDb.OleDbParameter("@2", NumeroDocumento))
                .Add(New OleDb.OleDbParameter("@3", NotaFiscal))
                .Add(New OleDb.OleDbParameter("@4", DataEmissao))
                .Add(New OleDb.OleDbParameter("@5", Parcelas))
                .Add(New OleDb.OleDbParameter("@6", Nz(Venc1, 1)))
                .Add(New OleDb.OleDbParameter("@7", Nz(Venc2, 1)))
                .Add(New OleDb.OleDbParameter("@8", Nz(Venc3, 1)))
                .Add(New OleDb.OleDbParameter("@9", Nz(Venc4, 1)))
                .Add(New OleDb.OleDbParameter("@10", Valor1))
                .Add(New OleDb.OleDbParameter("@11", Valor2))
                .Add(New OleDb.OleDbParameter("@12", Valor3))
                .Add(New OleDb.OleDbParameter("@13", Valor4))
            End With
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            conn.Close()
        End Try


    End Sub
    Public Sub Localizar(ByVal xID As Integer)
        Dim conn As New OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        Dim sql As String

        sql = "Select * from DuplicataAvulso where Dcodigo=" & xID
        Dim DR As OleDbDataReader
        Try
            conn.Open()
            Dim cmd As New OleDbCommand(sql, conn)
            DR = cmd.ExecuteReader
            DR.Read()

            DuplicataAvulso.txtCodigo.Text = DR.Item("DCodigo")
            DuplicataAvulso.txtDocumento.Text = DR.Item("DNumeroDocumento")
            DuplicataAvulso.txtNotaFiscal.Text = DR.Item("DNF")
            DuplicataAvulso.txtDataEmissao.Text = DR.Item("DDataEmissao")
            DuplicataAvulso.txtParcelas.Text = DR.Item("DParcelas")
            DuplicataAvulso.txtVenc1.Text = DR.Item("DVenc1") & ""
            DuplicataAvulso.txtVenc2.Text = DR.Item("DVenc2") & ""
            DuplicataAvulso.txtVenc3.Text = DR.Item("DVenc3") & ""
            DuplicataAvulso.txtVenc4.Text = DR.Item("DVenc4") & ""
            DuplicataAvulso.txtValor1.Text = DR.Item("DValor1") & ""
            DuplicataAvulso.txtValor2.Text = DR.Item("DValor2") & ""
            DuplicataAvulso.txtValor3.Text = DR.Item("DValor3") & ""
            DuplicataAvulso.txtValor4.Text = DR.Item("DValor4") & ""


        Catch ex As Exception
            Throw ex
        Finally
            conn.Close()
        End Try

    End Sub
End Class
