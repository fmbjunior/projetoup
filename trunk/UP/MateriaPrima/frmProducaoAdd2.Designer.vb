<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducaoAdd2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProducaoAdd2))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CodigoCliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.NomeCliente = New TexBoxFocusNet.TextBoxFocusNet()
        Me.DataPrazo = New TexBoxFocusNet.TextBoxFocusNet()
        Me.DataPedido = New TexBoxFocusNet.TextBoxFocusNet()
        Me.NomeVendedor = New TexBoxFocusNet.TextBoxFocusNet()
        Me.CodigoVendedor = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.btnFinalizar = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cód. Cliente"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CodigoCliente
        '
        Me.CodigoCliente.AceitaColarTexto = True
        Me.CodigoCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.CodigoCliente.CasasDecimais = 2
        Me.CodigoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodigoCliente.CPObrigatorio = False
        Me.CodigoCliente.CPObrigatorioMsg = Nothing
        Me.CodigoCliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CodigoCliente.FlatBorder = True
        Me.CodigoCliente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CodigoCliente.FocusColor = System.Drawing.Color.Empty
        Me.CodigoCliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodigoCliente.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoCliente.HighlightBorderOnEnter = False
        Me.CodigoCliente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CodigoCliente.Location = New System.Drawing.Point(22, 31)
        Me.CodigoCliente.Name = "CodigoCliente"
        Me.CodigoCliente.PreencherZeroEsqueda = False
        Me.CodigoCliente.RegraValidação = Nothing
        Me.CodigoCliente.RegraValidaçãoMensagem = Nothing
        Me.CodigoCliente.Size = New System.Drawing.Size(76, 23)
        Me.CodigoCliente.TabIndex = 8
        Me.CodigoCliente.TabStop = False
        Me.CodigoCliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodigoCliente.ValorPadrao = Nothing
        '
        'NomeCliente
        '
        Me.NomeCliente.AceitaColarTexto = True
        Me.NomeCliente.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.NomeCliente.CasasDecimais = 2
        Me.NomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NomeCliente.CPObrigatorio = False
        Me.NomeCliente.CPObrigatorioMsg = Nothing
        Me.NomeCliente.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NomeCliente.FlatBorder = True
        Me.NomeCliente.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NomeCliente.FocusColor = System.Drawing.Color.Empty
        Me.NomeCliente.FocusColorEnd = System.Drawing.Color.Empty
        Me.NomeCliente.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeCliente.HighlightBorderOnEnter = False
        Me.NomeCliente.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NomeCliente.Location = New System.Drawing.Point(104, 31)
        Me.NomeCliente.MaxLength = 100
        Me.NomeCliente.Name = "NomeCliente"
        Me.NomeCliente.PreencherZeroEsqueda = False
        Me.NomeCliente.RegraValidação = Nothing
        Me.NomeCliente.RegraValidaçãoMensagem = Nothing
        Me.NomeCliente.Size = New System.Drawing.Size(406, 23)
        Me.NomeCliente.TabIndex = 9
        Me.NomeCliente.TabStop = False
        Me.NomeCliente.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NomeCliente.ValorPadrao = Nothing
        '
        'DataPrazo
        '
        Me.DataPrazo.AceitaColarTexto = True
        Me.DataPrazo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DataPrazo.CasasDecimais = 2
        Me.DataPrazo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataPrazo.CPObrigatorio = False
        Me.DataPrazo.CPObrigatorioMsg = Nothing
        Me.DataPrazo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataPrazo.FlatBorder = True
        Me.DataPrazo.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataPrazo.FocusColor = System.Drawing.Color.Empty
        Me.DataPrazo.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataPrazo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataPrazo.HighlightBorderOnEnter = False
        Me.DataPrazo.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataPrazo.Location = New System.Drawing.Point(147, 129)
        Me.DataPrazo.MaxLength = 10
        Me.DataPrazo.Name = "DataPrazo"
        Me.DataPrazo.PreencherZeroEsqueda = False
        Me.DataPrazo.RegraValidação = Nothing
        Me.DataPrazo.RegraValidaçãoMensagem = Nothing
        Me.DataPrazo.Size = New System.Drawing.Size(119, 23)
        Me.DataPrazo.TabIndex = 11
        Me.DataPrazo.TabStop = False
        Me.DataPrazo.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataPrazo.ValorPadrao = Nothing
        '
        'DataPedido
        '
        Me.DataPedido.AceitaColarTexto = True
        Me.DataPedido.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DataPedido.CasasDecimais = 2
        Me.DataPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataPedido.CPObrigatorio = False
        Me.DataPedido.CPObrigatorioMsg = Nothing
        Me.DataPedido.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.DataPedido.FlatBorder = True
        Me.DataPedido.FlatBorderColor = System.Drawing.Color.DimGray
        Me.DataPedido.FocusColor = System.Drawing.Color.Empty
        Me.DataPedido.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataPedido.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataPedido.HighlightBorderOnEnter = False
        Me.DataPedido.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.DataPedido.Location = New System.Drawing.Point(22, 129)
        Me.DataPedido.Name = "DataPedido"
        Me.DataPedido.PreencherZeroEsqueda = False
        Me.DataPedido.RegraValidação = Nothing
        Me.DataPedido.RegraValidaçãoMensagem = Nothing
        Me.DataPedido.Size = New System.Drawing.Size(119, 23)
        Me.DataPedido.TabIndex = 10
        Me.DataPedido.TabStop = False
        Me.DataPedido.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.DataPedido.ValorPadrao = Nothing
        '
        'NomeVendedor
        '
        Me.NomeVendedor.AceitaColarTexto = True
        Me.NomeVendedor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.NomeVendedor.CasasDecimais = 2
        Me.NomeVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NomeVendedor.CPObrigatorio = False
        Me.NomeVendedor.CPObrigatorioMsg = Nothing
        Me.NomeVendedor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.NomeVendedor.FlatBorder = False
        Me.NomeVendedor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.NomeVendedor.FocusColor = System.Drawing.Color.Empty
        Me.NomeVendedor.FocusColorEnd = System.Drawing.Color.Empty
        Me.NomeVendedor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeVendedor.HighlightBorderOnEnter = False
        Me.NomeVendedor.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.NomeVendedor.Location = New System.Drawing.Point(104, 81)
        Me.NomeVendedor.Name = "NomeVendedor"
        Me.NomeVendedor.PreencherZeroEsqueda = False
        Me.NomeVendedor.RegraValidação = Nothing
        Me.NomeVendedor.RegraValidaçãoMensagem = Nothing
        Me.NomeVendedor.Size = New System.Drawing.Size(406, 23)
        Me.NomeVendedor.TabIndex = 13
        Me.NomeVendedor.TabStop = False
        Me.NomeVendedor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NomeVendedor.ValorPadrao = Nothing
        '
        'CodigoVendedor
        '
        Me.CodigoVendedor.AceitaColarTexto = True
        Me.CodigoVendedor.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.CodigoVendedor.CasasDecimais = 2
        Me.CodigoVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodigoVendedor.CPObrigatorio = False
        Me.CodigoVendedor.CPObrigatorioMsg = Nothing
        Me.CodigoVendedor.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.CodigoVendedor.FlatBorder = False
        Me.CodigoVendedor.FlatBorderColor = System.Drawing.Color.DimGray
        Me.CodigoVendedor.FocusColor = System.Drawing.Color.Empty
        Me.CodigoVendedor.FocusColorEnd = System.Drawing.Color.Empty
        Me.CodigoVendedor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoVendedor.HighlightBorderOnEnter = False
        Me.CodigoVendedor.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.CodigoVendedor.Location = New System.Drawing.Point(22, 81)
        Me.CodigoVendedor.MaxLength = 5
        Me.CodigoVendedor.Name = "CodigoVendedor"
        Me.CodigoVendedor.PreencherZeroEsqueda = False
        Me.CodigoVendedor.RegraValidação = Nothing
        Me.CodigoVendedor.RegraValidaçãoMensagem = Nothing
        Me.CodigoVendedor.Size = New System.Drawing.Size(76, 23)
        Me.CodigoVendedor.TabIndex = 12
        Me.CodigoVendedor.TabStop = False
        Me.CodigoVendedor.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.CodigoVendedor.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(108, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nome do Cliente"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cód. Vend."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(108, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome do Vendedor"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 14)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Data Pedido"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(150, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 14)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Prazo Entrega"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTextSpacing = 5
        Me.btnCancelar.Location = New System.Drawing.Point(25, 183)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(130, 32)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnFinalizar
        '
        Me.btnFinalizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFinalizar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnFinalizar.Image = CType(resources.GetObject("btnFinalizar.Image"), System.Drawing.Image)
        Me.btnFinalizar.Location = New System.Drawing.Point(161, 183)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(130, 32)
        Me.btnFinalizar.TabIndex = 0
        Me.btnFinalizar.Text = "Finalizar"
        '
        'frmProducaoAdd2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 227)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.NomeVendedor)
        Me.Controls.Add(Me.CodigoVendedor)
        Me.Controls.Add(Me.DataPrazo)
        Me.Controls.Add(Me.DataPedido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CodigoCliente)
        Me.Controls.Add(Me.NomeCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmProducaoAdd2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dados do Pedido"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CodigoCliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents NomeCliente As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DataPrazo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents DataPedido As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents NomeVendedor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents CodigoVendedor As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnFinalizar As DevComponents.DotNetBar.ButtonX
End Class
