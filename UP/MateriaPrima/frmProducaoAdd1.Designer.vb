<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducaoAdd1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProducaoAdd1))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumeroPedido = New TexBoxFocusNet.TextBoxFocusNet()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.btnFechar = New DevComponents.DotNetBar.ButtonX()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnSeguir = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 28)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Código do Pedido>>"
        '
        'txtNumeroPedido
        '
        Me.txtNumeroPedido.AceitaColarTexto = True
        Me.txtNumeroPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtNumeroPedido.CasasDecimais = 3
        Me.txtNumeroPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroPedido.CPObrigatorio = False
        Me.txtNumeroPedido.CPObrigatorioMsg = Nothing
        Me.txtNumeroPedido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtNumeroPedido.FlatBorder = False
        Me.txtNumeroPedido.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtNumeroPedido.FocusColor = System.Drawing.Color.Empty
        Me.txtNumeroPedido.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtNumeroPedido.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroPedido.HighlightBorderOnEnter = False
        Me.txtNumeroPedido.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtNumeroPedido.Location = New System.Drawing.Point(208, 28)
        Me.txtNumeroPedido.MaxLength = 15
        Me.txtNumeroPedido.Name = "txtNumeroPedido"
        Me.txtNumeroPedido.PreencherZeroEsqueda = False
        Me.txtNumeroPedido.RegraValidação = Nothing
        Me.txtNumeroPedido.RegraValidaçãoMensagem = Nothing
        Me.txtNumeroPedido.Size = New System.Drawing.Size(132, 30)
        Me.txtNumeroPedido.TabIndex = 32
        Me.txtNumeroPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNumeroPedido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.NumerosInteiros
        Me.txtNumeroPedido.ValorPadrao = Nothing
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(18, 69)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(119, 13)
        Me.lbl1.TabIndex = 34
        Me.lbl1.Text = "[ESC] - Fecha esta tela."
        '
        'btnFechar
        '
        Me.btnFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnFechar.Location = New System.Drawing.Point(371, 120)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(100, 33)
        Me.btnFechar.TabIndex = 35
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Vista (315).png")
        '
        'btnSeguir
        '
        Me.btnSeguir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSeguir.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnSeguir.Image = CType(resources.GetObject("btnSeguir.Image"), System.Drawing.Image)
        Me.btnSeguir.Location = New System.Drawing.Point(345, 27)
        Me.btnSeguir.Name = "btnSeguir"
        Me.btnSeguir.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btnSeguir.Size = New System.Drawing.Size(32, 31)
        Me.btnSeguir.TabIndex = 33
        '
        'frmProducaoAdd1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnFechar
        Me.ClientSize = New System.Drawing.Size(410, 102)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnSeguir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumeroPedido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmProducaoAdd1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Escolher Pedido para Produção.."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroPedido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents btnSeguir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents btnFechar As DevComponents.DotNetBar.ButtonX
    Private WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
