Namespace My

    ' The following events are availble for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        ' Private Sub ChecaStatusRede()
        '    If My.Computer.Network.IsAvailable = True Then
        'Rede esta conectada
        '   Else
        '      MsgBox("Rede Desconectada, verifique cabo ou contacte o Administrador de Rede, o Sistema sera Finalizado.", 64, "Validação de Dados")
        '       End
        ' End If
        ' End Sub

        Private Sub MyApplication_NetworkAvailabilityChanged(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.Devices.NetworkAvailableEventArgs) Handles Me.NetworkAvailabilityChanged
            'ChecaStatusRede()
        End Sub

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            'ChecaStatusRede()
        End Sub
    End Class

End Namespace

