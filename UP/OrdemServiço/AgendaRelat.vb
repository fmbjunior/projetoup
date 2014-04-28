Public Class AgendaRelat

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub A1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.CheckedChanged, A2.CheckedChanged, A3.CheckedChanged
        If A1.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelCliente.Visible = False
            Me.DataInicial.Clear()
            Me.DataFinal.Clear()
            Me.DataInicial.Focus()
        End If
        If A2.Checked = True Then
            Me.PainelPeriodo.Visible = True
            Me.PainelCliente.Visible = False
            Me.DataInicial.Clear()
            Me.DataFinal.Clear()
            Me.DataInicial.Focus()
        End If
        If A3.Checked = True Then
            Me.PainelPeriodo.Visible = False
            Me.PainelCliente.Visible = True
            Me.DataInicial.Clear()
            Me.DataFinal.Clear()
            Me.Cliente.Focus()
        End If
    End Sub



    Private Sub AgendadoPeriodo()
        Dim Tel As New Form() ' Create a new instance of the form.

        Dim Vz As New CrystalDecisions.Windows.Forms.CrystalReportViewer

        Dim F As New Font("Comic Sans MS", 8, System.Drawing.GraphicsUnit.Point)

        Tel.Text = "Visualizador de Relatório"
        Tel.Size = New Size(576, 352)
        Tel.HelpButton = False
        Tel.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        Tel.MaximizeBox = True
        Tel.MinimizeBox = True
        Tel.ControlBox = True
        Tel.Font = F
        Tel.StartPosition = FormStartPosition.CenterScreen
        Tel.ShowInTaskbar = True
        Tel.WindowState = FormWindowState.Maximized

        Vz.Dock = DockStyle.Fill

        Dim VerRelat As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        VerRelat.Load(DirRelat & "AgendaPeriodo.rpt")
        VerRelat.DataSourceConnections.Item(0).SetConnection("", LocalBD & "upAgendaDados.Mdb", False)
        VerRelat.DataSourceConnections.Item(0).SetLogon("", "")
        VerRelat.DataDefinition.RecordSelectionFormula = "{AgendaServico.DataAgenda}>=Date (" & Format(CDate(Me.DataInicial.Text), "yyyy,MM,dd") & ") and {AgendaServico.DataAgenda}<=date(" & Format(CDate(Me.DataFinal.Text), "yyyy,MM,dd") & ") And {AgendaServico.Status} <> 'CANCELADO' And {AgendaServico.Status} <> 'FINALIZADO'"

        Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
        T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
        T.Text = "Período de : " & Me.DataInicial.Text & " a " & Me.DataFinal.Text


        Vz.ReportSource = VerRelat
        Tel.Controls.Add(Vz)
        Tel.ShowDialog()
    End Sub

    Private Sub AgendadoCliente()
        Dim Tel As New Form() ' Create a new instance of the form.

        Dim Vz As New CrystalDecisions.Windows.Forms.CrystalReportViewer

        Dim F As New Font("Comic Sans MS", 8, System.Drawing.GraphicsUnit.Point)

        Tel.Text = "Visualizador de Relatório"
        Tel.Size = New Size(576, 352)
        Tel.HelpButton = False
        Tel.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        Tel.MaximizeBox = True
        Tel.MinimizeBox = True
        Tel.ControlBox = True
        Tel.Font = F
        Tel.StartPosition = FormStartPosition.CenterScreen
        Tel.ShowInTaskbar = True
        Tel.WindowState = FormWindowState.Maximized

        Vz.Dock = DockStyle.Fill



        Dim VerRelat As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        VerRelat.Load(DirRelat & "AgendaPeriodo.rpt")
        VerRelat.DataSourceConnections.Item(0).SetConnection("", LocalBD & "upAgendaDados.Mdb", False)
        VerRelat.DataSourceConnections.Item(0).SetLogon("", "")
        VerRelat.DataDefinition.RecordSelectionFormula = "{AgendaServico.Status} <> 'CANCELADO' And {AgendaServico.Status} <> 'FINALIZADO' And {AgendaServico.Cliente} = " & Me.Cliente.Text

        Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
        T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
        T.Text = "Compromisso agendado para o Cliente"


        Vz.ReportSource = VerRelat
        Tel.Controls.Add(Vz)
        Tel.ShowDialog()
    End Sub

    Private Sub FinalizadoPeriodo()
        Dim Tel As New Form() ' Create a new instance of the form.

        Dim Vz As New CrystalDecisions.Windows.Forms.CrystalReportViewer

        Dim F As New Font("Comic Sans MS", 8, System.Drawing.GraphicsUnit.Point)

        Tel.Text = "Visualizador de Relatório"
        Tel.Size = New Size(576, 352)
        Tel.HelpButton = False
        Tel.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        Tel.MaximizeBox = True
        Tel.MinimizeBox = True
        Tel.ControlBox = True
        Tel.Font = F
        Tel.StartPosition = FormStartPosition.CenterScreen
        Tel.ShowInTaskbar = True
        Tel.WindowState = FormWindowState.Maximized

        Vz.Dock = DockStyle.Fill



        Dim VerRelat As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        VerRelat.Load(DirRelat & "AgendaPeriodo.rpt")
        VerRelat.DataSourceConnections.Item(0).SetConnection("", LocalBD & "upAgendaDados.Mdb", False)
        VerRelat.DataSourceConnections.Item(0).SetLogon("", "")
        VerRelat.DataDefinition.RecordSelectionFormula = "{AgendaServico.Status} = 'FINALIZADO'"

        Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
        T = VerRelat.ReportDefinition.ReportObjects.Item("Titulo")
        T.Text = "Período de : " & Me.DataInicial.Text & " a " & Me.DataFinal.Text

        Vz.ReportSource = VerRelat
        Tel.Controls.Add(Vz)
        Tel.ShowDialog()
    End Sub

    Private Sub btVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVisualizar.Click
        If Me.A1.Checked = True Then
            AgendadoPeriodo()
        End If
        If Me.A2.Checked = True Then
            FinalizadoPeriodo()
        End If
        If Me.A3.Checked = True Then
            AgendadoCliente()
        End If
    End Sub

    Private Sub btFindClintes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFindClintes.Click
        My.Forms.ClientesProcura.ShowDialog()
        If Me.Cliente.Text <> "" Then
            LocalizaDadosCliente()
            Me.Cliente.Focus()
        End If
    End Sub

    Private Sub Cliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cliente.KeyDown
        If e.KeyCode = Keys.F5 Then
            My.Forms.ClientesProcura.ShowDialog()
            If Me.Cliente.Text <> "" Then
                LocalizaDadosCliente()
                Me.Cliente.Focus()
            End If
        End If
    End Sub

    Private Sub Cliente_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cliente.Validated
        If String.CompareOrdinal(Me.Cliente.Text, Me.Cliente.TextoAntigo) Then
            LocalizaDadosCliente()
        End If
    End Sub

    Private Sub LocalizaDadosCliente()

        If Me.Cliente.Text = "" Then
            Exit Sub
        End If
        'String para filtragem de clientes na base de dados
        Dim CNN As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & Nome_BD))
        CNN.Open()

        Dim Sql As String = "SELECT Clientes.* FROM Clientes WHERE Clientes.Empresa =" & CodEmpresa & " and Clientes.Inativo = False AND Clientes.Codigo = " & Me.Cliente.Text


        Dim CMD As New OleDb.OleDbCommand(Sql, CNN)
        Dim DR As OleDb.OleDbDataReader

        DR = CMD.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            Me.ClienteDesc.Text = DR.Item("Nome") & ""
        End If

        DR.Close()
        CNN.Close()

    End Sub

End Class