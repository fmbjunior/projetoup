Imports Microsoft.Win32
Public Class CompraCtrPedidoEndEntrega


    Public EditaItens As Boolean = False
    Dim Ação As New TrfGerais()
    Private Operation As Byte
    Const INS As Byte = 0
    Const UPD As Byte = 1
    Const DEL As Byte = 2

    Dim SalvoDoc As Boolean = False
    Dim ExistDoc As Boolean = False


    Public Sub LocalizaDados()

        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT * FROM CompraCtrlPedido WHERE Id = " & My.Forms.CompraCtrPedido.Id.Text

        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.Entregalocal.Text = DR.Item("Entregalocal") & ""
            Me.EntregaEnd.Text = DR.Item("EntregaEnd") & ""
            Me.EntregaCidade.Text = DR.Item("EntregaCidade") & ""
            Me.EntregaUF.Text = DR.Item("EntregaUF") & ""
            Me.EntregaCep.Text = DR.Item("EntregaCep") & ""
        Else
            MsgBox("Controle de Compra não Identificado, favor verificar.", 64, "Validação de Dados")
            CNN.Close()
            Exit Sub
        End If
        Operation = UPD
        DR.Close()
    End Sub

    Private Sub Degrade()
        Try

            Dim Key As RegistryKey = Registry.LocalMachine
            Dim PegaKeyPadrão As RegistryKey = Key.OpenSubKey("Software\\UPTema\\Tema")

            Cor1TelaPrimaria = PegaKeyPadrão.GetValue("Cor1TelaPrimaria", " ")
            Cor2TelaPrimaria = PegaKeyPadrão.GetValue("Cor2TelaPrimaria", " ")

            Cor1TelaSecundaria = PegaKeyPadrão.GetValue("Cor1TelaSecundaria", " ")
            Cor2TelaSecundaria = PegaKeyPadrão.GetValue("Cor2TelaSecundaria", " ")


            Dim CCor() As String
            Dim corTemp As String

            corTemp = Cor1TelaPrimaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))

            corTemp = Cor2TelaPrimaria
            CCor = corTemp.Split(";")
            Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(CCor(0), Byte), Integer), CType(CType(CCor(1), Byte), Integer), CType(CType(CCor(2), Byte), Integer), CType(CType(CCor(3), Byte), Integer))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AtualizarDados()
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "Update CompraCtrlPedido set Entregalocal = @1, EntregaEnd = @2, EntregaCidade = @3, EntregaUF = @4, EntregaCep = @5 Where Id = " & My.Forms.CompraCtrPedido.Id.Text
        Dim cmd As New OleDb.OleDbCommand(Sql, CNN)

        cmd.Parameters.Add(New OleDb.OleDbParameter("@1", Nz(Me.Entregalocal.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@2", Nz(Me.EntregaEnd.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@3", Nz(Me.EntregaCidade.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@4", Nz(Me.EntregaUF.Text, 1)))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@5", Nz(Me.EntregaCep.Text, 1)))

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Registro salvo com sucesso.", "Validação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CNN.Close()
            Operation = UPD
        Catch x As Exception
            MsgBox(x.Message)
            CNN.Close()
            Exit Sub
        End Try
    End Sub


    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        AtualizarDados()
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub CompraCtrPedidoEndEntrega_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LocalizaDados()
    End Sub
End Class