Imports DevComponents.DotNetBar.Schedule
Imports DevComponents.Schedule.Model
Imports System.Data

Public Class AgendaServico



    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Function AddAGENDA(ByVal startDate As DateTime, ByVal endDate As DateTime, ByVal CliDesc As String, ByVal Status As String, ByVal Compromisso As String, ByVal IdRegistro As Integer) As Appointment


        Dim appointment As New Appointment()

        appointment.StartTime = startDate 'Format(startDate, "dd/MM/yyyy")
        appointment.EndTime = endDate 'Format(endDate, "dd/MM/yyyy")

        appointment.Subject = CliDesc

        appointment.Description = Status
        appointment.Tooltip = Compromisso
        appointment.Tag = IdRegistro
        appointment.Locked = True

        If Status = "AGENDADO" Then
            appointment.CategoryColor = appointment.CategoryYellow
        End If
        If Status = "CANCELADO" Then
            appointment.CategoryColor = appointment.CategoryRed
        End If
        If Status = "EM ANDAMENTO" Then
            appointment.CategoryColor = appointment.CategoryGreen
        End If
        If Status = "EM ATRASO" Then
            appointment.CategoryColor = appointment.CategoryOrange
        End If


        ' Add appointment to the model

        CalendarView1.CalendarModel.Appointments.Add(appointment)

        Return (appointment)
    End Function

    Public Sub EncheAgenda()

        Dim Cnn As New OleDb.OleDbConnection(New Conectar().ConectarBD(LocalBD & "upAgendaDados.Mdb"))
        Dim Cmd As New OleDb.OleDbCommand()
        Dim DR As OleDb.OleDbDataReader

        Cnn.Open()

        With Cmd
            .Connection = Cnn
            .CommandTimeout = 0
            .CommandText = "SELECT * FROM(AgendaServico) WHERE (((AgendaServico.[Status])<>'CANCELADO' And (AgendaServico.[Status])<>'FINALIZADO'));"
            .CommandType = CommandType.Text
        End With

        Try

            DR = Cmd.ExecuteReader

            Dim Dh As String
            Dim AmPM As String
            While DR.Read
                If Not IsDBNull(DR.Item("Id")) Then

                    Dim hs As String = IIf(IsDBNull(DR.Item("HorasCompromisso")), "12:00:00", DR.Item("HorasCompromisso"))


                    If hs >= "12:00:00" Then
                        AmPM = "PM"
                    Else
                        AmPM = "AM"
                    End If

                    Dh = CDate(DR.Item("DataAgenda") & " " & DR.Item("HorasCompromisso") & AmPM)
                    AddAGENDA(Dh, Dh, DR.Item("ClienteDesc"), DR.Item("Status"), DR.Item("Compromisso"), DR.Item("Id"))
                End If
            End While
            DR.Close()


        Catch Merror As System.Exception
            MsgBox(Merror.ToString)
            If ConnectionState.Open Then
                Cnn.Close()
                Exit Sub
            End If
        End Try
        Cnn.Close()

    End Sub

    Private Sub AgendaServico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EncheAgenda()
    End Sub

#Region "AddHoliday"
    Private Sub AddFeriado()
        AddHoliday("New Years Day", 1, 1)
        AddHoliday("Martin Luther King Jr Day", 1, eRelativeDayInMonth.Third, DayOfWeek.Monday)
        AddHoliday("Groundhog Day", 2, 2)
        AddHoliday("Valentines Day", 2, 14)
        AddHoliday("Presidents Day", 2, eRelativeDayInMonth.Third, DayOfWeek.Monday)
        AddHoliday("St. Patricks Day", 3, 17)
        AddHoliday("April Fools Day", 4, 1)
        AddHoliday("Earth Day", 4, 22)
        AddHoliday("Cinco de Mayo", 5, 5)
        AddHoliday("Mothers Day", 5, eRelativeDayInMonth.Second, DayOfWeek.Saturday)
        AddHoliday("Memorial Day", 5, eRelativeDayInMonth.Last, DayOfWeek.Monday)
        AddHoliday("Flag Day", 6, 14)
        AddHoliday("Fathers Day", 6, eRelativeDayInMonth.Third, DayOfWeek.Sunday)
        AddHoliday("Independence Day", 7, 4)
        AddHoliday("Labor Day", 9, eRelativeDayInMonth.First, DayOfWeek.Monday)
        AddHoliday("Columbus Day", 10, eRelativeDayInMonth.Second, DayOfWeek.Monday)
        AddHoliday("Halloween", 10, 31)
        AddHoliday("Veterans Day", 11, 11)
        AddHoliday("Thanksgiving", 11, eRelativeDayInMonth.Fourth, DayOfWeek.Thursday)
        AddHoliday("Christmas", 12, 25)
        AddHoliday("New Years Eve", 12, 31)

        ' Add Easter

        'AddEaster()
    End Sub

    Private Sub AddHoliday(ByVal title As String, ByVal month As Integer, ByVal day As Integer)
        Dim appointment As Appointment = NewHoliday(title, New DateTime(2010, month, day))

        appointment.Recurrence.Yearly.RepeatOnMonth = month
        appointment.Recurrence.Yearly.RepeatOnDayOfMonth = day

        ' Add appointment to the model

        CalendarView1.CalendarModel.Appointments.Add(appointment)
    End Sub

    Private Sub AddHoliday(ByVal title As String, ByVal month As Integer, ByVal relDim As eRelativeDayInMonth, ByVal dow As DayOfWeek)
        Dim appointment As Appointment = NewHoliday(title, RelativeDate(month, relDim, dow))

        appointment.Recurrence.Yearly.RepeatOnMonth = month
        appointment.Recurrence.Yearly.RelativeDayOfWeek = dow
        appointment.Recurrence.Yearly.RepeatOnRelativeDayInMonth = relDim
        appointment.Recurrence.Yearly.RepeatOnDayOfMonth = 0

        ' Add appointment to the model

        CalendarView1.CalendarModel.Appointments.Add(appointment)
    End Sub

    Private Function RelativeDate(ByVal month As Integer, ByVal relDim As eRelativeDayInMonth, ByVal dow As DayOfWeek) As DateTime
        Dim relDate As New DateTime(2010, month, 1)

        While relDate.DayOfWeek <> dow
            relDate = relDate.AddDays(1)
        End While

        Select Case relDim
            Case eRelativeDayInMonth.First
                Return (relDate)

            Case eRelativeDayInMonth.Second
                Return (relDate.AddDays(7))

            Case eRelativeDayInMonth.Third
                Return (relDate.AddDays(14))

            Case eRelativeDayInMonth.Fourth
                Return (relDate.AddDays(21))
        End Select

        Return (relDate)
    End Function
#End Region

    Private Function NewHoliday(ByVal title As String, ByVal startTime As DateTime) As Appointment
        ' Allocate a new Appointment

        Dim appointment As New Appointment()

        appointment.Subject = title
        appointment.Tooltip = title
        appointment.CategoryColor = appointment.CategoryRed
        appointment.TimeMarkedAs = Appointment.TimerMarkerFree
        appointment.Locked = True

        appointment.StartTime = startTime
        appointment.EndTime = startTime.AddDays(1)

        ' Allocate a new AppointmentRecurrence

        appointment.Recurrence = New AppointmentRecurrence()

        appointment.Recurrence.RecurrenceType = eRecurrencePatternType.Yearly
        appointment.Recurrence.RangeLimitType = eRecurrenceRangeLimitType.RangeEndDate
        appointment.Recurrence.RangeEndDate = DateTime.Today.AddYears(10)

        Return (appointment)
    End Function

    Private Sub MêsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MêsToolStripMenuItem.Click
        CalendarView1.SelectedView = eCalendarView.Month
    End Sub

    Private Sub LinhaDeTempoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinhaDeTempoToolStripMenuItem.Click
        CalendarView1.SelectedView = eCalendarView.Day
    End Sub

    Private Sub btAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdicionar.Click
        My.Forms.AgendaServicoAdd.ShowDialog()
        CalendarView1.CalendarModel.Appointments.Clear()
        EncheAgenda()
    End Sub


    Private Sub calendarView1_ItemDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles CalendarView1.ItemDoubleClick
        Dim item As AppointmentView = TryCast(sender, AppointmentView)

        If item IsNot Nothing Then
            Dim ap As Appointment = item.Appointment
            Dim Id As Integer = ap.Tag

            My.Forms.AgendaServicoAdd.Procurar = Id
            My.Forms.AgendaServicoAdd.ShowDialog()
            CalendarView1.CalendarModel.Appointments.Clear()
            EncheAgenda()

        End If
    End Sub

    Private Sub btRelatorios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRelatorios.Click
        My.Forms.AgendaRelat.ShowDialog()
    End Sub

    Private Sub CalendarView1_ItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalendarView1.ItemClick

    End Sub
End Class