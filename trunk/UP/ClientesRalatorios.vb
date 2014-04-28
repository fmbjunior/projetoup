Public Class ClientesRalatorios

    Public optValue As String
    Public checkValue(4) As String
    Public Filter As String
    Dim i As Integer = 0
    Private Sub Visualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Visualizar.Click
        RelatorioCarregar = "Clientes"
        Filter = String.Empty
        RadioB(Me)
        If Filter = "" Then
        Else

            Filter = Filter.Remove(0, 1)
        End If
        If i = 0 Then
            Filter = String.Empty
        End If

        My.Forms.VisualizadorRelatorio.ShowDialog()
    End Sub


    Private Sub Cidade_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NomeMunic.CheckedChanged, Endereço.CheckedChanged, NomeUF.CheckedChanged, Nome.CheckedChanged
        Select Case DirectCast(sender, DevComponents.DotNetBar.Controls.CheckBoxX).Name

            Case "Cidade"
                If DirectCast(sender, DevComponents.DotNetBar.Controls.CheckBoxX).Checked = True Then
                    checkValue(0) = "1"
                End If
            Case "Uf"
                checkValue(1) = "2"
            Case "Vendedor"
                checkValue(2) = "3"
            Case "Endereco"
                checkValue(3) = "4"
        End Select

    End Sub

    Private Sub RadioB(ByRef root As Control)

        For Each ctrl As Control In root.Controls
            RadioB(ctrl)
            If TypeOf ctrl Is DevComponents.DotNetBar.Controls.CheckBoxX Then
                Dim ss As New DevComponents.DotNetBar.Controls.CheckBoxX
                ss = ctrl
                If ss.Checked = True Then
                    i += 1
                    If ss.Name = "NomeMunic" Then
                        Filter = Filter & "-" & "{command.NomeMunic} Like '*" & Me.txtCidade.Text & "*'"
                    ElseIf ss.Name = "NomeUF" Then
                        Filter = Filter & "-" & "{command.NomeUF} Like '*" & Me.txtUF.Text & "*'"
                    ElseIf ss.Name = "Endereço" Then
                        Filter = Filter & "-" & "{command.Endereço} Like '*" & Me.txtEndereco.Text & "*'"
                    ElseIf ss.Name = "Nome" Then
                        Filter = Filter & "-" & "{Funcionários.Nome} Like '*" & Me.txtVendedor.Text & "*'"
                    End If
                    'Filter = "{       Filter & " - " & ss.Name"
                End If
            End If
        Next (ctrl)

    End Sub
    Private Sub RelClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub optCidade_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCidade.CheckedChanged, optUF.CheckedChanged, optVendedor.CheckedChanged
        Select Case DirectCast(sender, RadioButton).Name

            Case "optCidade"
                optValue = "1"
            Case "optUF"
                optValue = "2"
            Case "optVendedor"
                optValue = "3"
        End Select
    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Endereço_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Endereço.Click, Nome.Click, NomeUF.Click, NomeMunic.Click


        Select Case DirectCast(sender, DevComponents.DotNetBar.Controls.CheckBoxX).Name
            Case "Endereço"

                If Me.Endereço.Checked = False Then
                    Me.txtEndereco.Enabled = True
                    Me.txtEndereco.Focus()
                Else
                    Me.txtEndereco.Enabled = False
                    Me.txtEndereco.Clear()
                End If
            Case "NomeUF"
                If Me.NomeUF.Checked = False Then
                    Me.txtUF.Enabled = True
                    Me.txtUF.Focus()
                Else
                    Me.txtUF.Enabled = False
                    Me.txtUF.Clear()
                End If
            Case "NomeMunic"
                If Me.NomeMunic.Checked = False Then
                    Me.txtCidade.Enabled = True
                    Me.txtCidade.Focus()
                Else
                    Me.txtCidade.Enabled = False
                    Me.txtCidade.Clear()
                End If
            Case "Nome"
                If Me.Nome.Checked = False Then
                    Me.txtVendedor.Enabled = True
                    Me.txtVendedor.Focus()
                Else
                    Me.txtVendedor.Enabled = False
                    Me.txtEndereco.Clear()
                End If

        End Select

    End Sub
End Class