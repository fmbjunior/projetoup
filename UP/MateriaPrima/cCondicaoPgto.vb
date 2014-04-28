Imports System.Data.OleDb
Public Class cCondicaoPgto
    Private mcodformapgto As Integer
    Private mdescricao As String
    Private mdiasparcelamento As String
    Private minativo As Boolean
    Private mtementrada As Boolean
    Private mqtdparcelas As String()

    Dim db As New clsBancoDados
    Public pReturnErro As Boolean = False
    Public Sub Localizar(ByVal xID As Integer)

        Dim sql As String

        sql = "Select * from FormaPgto where CodFormaPgto=" & xID
        Dim conn As New OleDbConnection
        Dim DR As OleDbDataReader
        Try
            conn = db.AbreBanco()
            Dim cmd As New OleDbCommand(sql, conn)
            DR = cmd.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                mcodformapgto = xID
                mdescricao = DR.Item("Descrição") & ""
                mdiasparcelamento = DR.Item("DiasParcelamento") & ""
                mqtdparcelas = mdiasparcelamento.Split(New Char() {"-"c})
                minativo = DR.Item("Inativo")
                mtementrada = DR.Item("TemEntrada")
                pReturnErro = False
            Else
                MessageBox.Show("Não foi encontrado essa condição de pagamento", "Validação de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                pReturnErro = True
            End If
        Catch ex As Exception
            pReturnErro = True
            Throw ex
        Finally
            db.fechabanco(conn)
        End Try

    End Sub
    Public Property CodigoPagamento() As Integer
        Get
            Return mcodformapgto
        End Get
        Set(ByVal value As Integer)
            mcodformapgto = value
        End Set
    End Property

    Public Property Descricao() As String
        Get
            Return mdescricao
        End Get
        Set(ByVal value As String)
            mdescricao = value
        End Set
    End Property

    Public Property Inativo As Boolean
        Get
            Return minativo
        End Get
        Set(ByVal value As Boolean)
            minativo = value
        End Set
    End Property

    Public Property DiasParcelamento As String
        Get
            Return mdiasparcelamento
        End Get
        Set(ByVal value As String)
            mdiasparcelamento = value
        End Set
    End Property

    Public Property TemEntrada As Boolean
        Get
            Return mtementrada
        End Get
        Set(ByVal value As Boolean)
            mtementrada = value
        End Set
    End Property



    Public Property Qtdparcelas() As String()
        Get
            Return mqtdparcelas
        End Get
        Set(ByVal value As String())
            mqtdparcelas = value
        End Set
    End Property

End Class
