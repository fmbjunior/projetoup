Module modMP
    Public Retorno As String = String.Empty

    ''' <summary> Usado para receber se é Pedido ou Orcamento</summary>
    Public strTipoPedido As String = String.Empty

    ''' <summary> Indicar qual é o tipo de busca, Orcamento ou Pedido </summary>
    Public sTipoBusca As String = "P"

    Public vEnum As Operacao

    Public Enum Operacao As Byte
        inclusao = 1
        alteracao = 2
        travar = 3
    End Enum
    Public Sub TravarCtrl(ByVal root As Control, ByVal EnabledTrueFalse As Boolean)
        For Each ctrl As Control In root.Controls
            TravarCtrl(ctrl, EnabledTrueFalse)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Enabled = EnabledTrueFalse
            End If
            If TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).Enabled = EnabledTrueFalse
            End If
            'If TypeOf ctrl Is ComponentFactory.Krypton.Toolkit.KryptonComboBox Then
            '    CType(ctrl, ComponentFactory.Krypton.Toolkit.KryptonComboBox).Enabled = TrueFalse
            'End If
            'If TypeOf ctrl Is ComponentFactory.Krypton.Toolkit.KryptonCheckBox Then
            '    CType(ctrl, ComponentFactory.Krypton.Toolkit.KryptonCheckBox).Enabled = TrueFalse
            'End If
            If TypeOf ctrl Is DevComponents.DotNetBar.Controls.CheckBoxX Then
                CType(ctrl, DevComponents.DotNetBar.Controls.CheckBoxX).Enabled = EnabledTrueFalse
            End If
            'If TypeOf ctrl Is ComponentFactory.Krypton.Toolkit.KryptonTextBox Then
            '    CType(ctrl, ComponentFactory.Krypton.Toolkit.KryptonTextBox).Enabled = TrueFalse
            'End If
            If TypeOf ctrl Is TexBoxFocusNet.TextBoxFocusNet Then
                CType(ctrl, TexBoxFocusNet.TextBoxFocusNet).Enabled = EnabledTrueFalse
            End If
            If TypeOf ctrl Is CBOAutoCompleteFocus.CboFocus Then
                CType(ctrl, CBOAutoCompleteFocus.CboFocus).Enabled = EnabledTrueFalse
            End If
        Next (ctrl)
    End Sub
End Module
