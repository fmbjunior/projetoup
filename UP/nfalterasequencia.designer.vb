<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NfAlteraSequencia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NfAlteraSequencia))
        Me.Fechar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Empresa = New TexBoxFocusNet.TextBoxFocusNet
        Me.EmpresaDesc = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label2 = New System.Windows.Forms.Label
        Me.NumeroNf = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label3 = New System.Windows.Forms.Label
        Me.NovoNumeroNF = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label4 = New System.Windows.Forms.Label
        Me.DataAltera��o = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label5 = New System.Windows.Forms.Label
        Me.Usu�rio = New TexBoxFocusNet.TextBoxFocusNet
        Me.Label6 = New System.Windows.Forms.Label
        Me.Motivo = New TexBoxFocusNet.TextBoxFocusNet
        Me.Salvar = New System.Windows.Forms.Button
        Me.Id = New TexBoxFocusNet.TextBoxFocusNet
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fechar
        '
        Me.Fechar.Image = CType(resources.GetObject("Fechar.Image"), System.Drawing.Image)
        Me.Fechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Fechar.Location = New System.Drawing.Point(394, 170)
        Me.Fechar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(103, 55)
        Me.Fechar.TabIndex = 13
        Me.Fechar.Text = "Fechar"
        Me.Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Fechar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empresa"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Empresa
        '
        Me.Empresa.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Empresa.CasasDecimais = 0
        Me.Empresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Empresa.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.Empresa.FocusColor = System.Drawing.Color.Empty
        Me.Empresa.FocusColorEnd = System.Drawing.Color.Empty
        Me.Empresa.Location = New System.Drawing.Point(111, 13)
        Me.Empresa.Name = "Empresa"
        Me.Empresa.RegraValida��o = Nothing
        Me.Empresa.Size = New System.Drawing.Size(59, 20)
        Me.Empresa.TabIndex = 1
        Me.Empresa.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Empresa.ValorPadrao = Nothing
        '
        'EmpresaDesc
        '
        Me.EmpresaDesc.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.EmpresaDesc.CasasDecimais = 0
        Me.EmpresaDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EmpresaDesc.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.EmpresaDesc.FocusColor = System.Drawing.Color.Empty
        Me.EmpresaDesc.FocusColorEnd = System.Drawing.Color.Empty
        Me.EmpresaDesc.Location = New System.Drawing.Point(176, 13)
        Me.EmpresaDesc.Name = "EmpresaDesc"
        Me.EmpresaDesc.RegraValida��o = Nothing
        Me.EmpresaDesc.Size = New System.Drawing.Size(321, 20)
        Me.EmpresaDesc.TabIndex = 2
        Me.EmpresaDesc.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EmpresaDesc.ValorPadrao = Nothing
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Numero NF"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumeroNf
        '
        Me.NumeroNf.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.NumeroNf.CasasDecimais = 0
        Me.NumeroNf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NumeroNf.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.NumeroNf.FocusColor = System.Drawing.Color.Empty
        Me.NumeroNf.FocusColorEnd = System.Drawing.Color.Empty
        Me.NumeroNf.Location = New System.Drawing.Point(111, 39)
        Me.NumeroNf.Name = "NumeroNf"
        Me.NumeroNf.RegraValida��o = Nothing
        Me.NumeroNf.Size = New System.Drawing.Size(59, 20)
        Me.NumeroNf.TabIndex = 4
        Me.NumeroNf.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NumeroNf.ValorPadrao = Nothing
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Novo Numero NF"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NovoNumeroNF
        '
        Me.NovoNumeroNF.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.NovoNumeroNF.CasasDecimais = 0
        Me.NovoNumeroNF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NovoNumeroNF.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.NovoNumeroNF.FocusColor = System.Drawing.Color.Empty
        Me.NovoNumeroNF.FocusColorEnd = System.Drawing.Color.Empty
        Me.NovoNumeroNF.Location = New System.Drawing.Point(111, 65)
        Me.NovoNumeroNF.Name = "NovoNumeroNF"
        Me.NovoNumeroNF.RegraValida��o = Nothing
        Me.NovoNumeroNF.Size = New System.Drawing.Size(59, 20)
        Me.NovoNumeroNF.TabIndex = 6
        Me.NovoNumeroNF.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.NovoNumeroNF.ValorPadrao = Nothing
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(3, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Data Altera��o"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataAltera��o
        '
        Me.DataAltera��o.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.DataAltera��o.CasasDecimais = 0
        Me.DataAltera��o.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DataAltera��o.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.DataAltera��o.FocusColor = System.Drawing.Color.Empty
        Me.DataAltera��o.FocusColorEnd = System.Drawing.Color.Empty
        Me.DataAltera��o.Location = New System.Drawing.Point(111, 91)
        Me.DataAltera��o.MaxLength = 10
        Me.DataAltera��o.Name = "DataAltera��o"
        Me.DataAltera��o.RegraValida��o = Nothing
        Me.DataAltera��o.Size = New System.Drawing.Size(91, 20)
        Me.DataAltera��o.TabIndex = 8
        Me.DataAltera��o.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Data
        Me.DataAltera��o.ValorPadrao = Nothing
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(3, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Usu�rio"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Usu�rio
        '
        Me.Usu�rio.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Usu�rio.CasasDecimais = 0
        Me.Usu�rio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Usu�rio.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.Usu�rio.FocusColor = System.Drawing.Color.Empty
        Me.Usu�rio.FocusColorEnd = System.Drawing.Color.Empty
        Me.Usu�rio.Location = New System.Drawing.Point(111, 117)
        Me.Usu�rio.Name = "Usu�rio"
        Me.Usu�rio.RegraValida��o = Nothing
        Me.Usu�rio.Size = New System.Drawing.Size(91, 20)
        Me.Usu�rio.TabIndex = 10
        Me.Usu�rio.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Usu�rio.ValorPadrao = Nothing
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(3, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Motivo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Motivo
        '
        Me.Motivo.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.N�o
        Me.Motivo.CasasDecimais = 0
        Me.Motivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Motivo.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.Motivo.FocusColor = System.Drawing.Color.Empty
        Me.Motivo.FocusColorEnd = System.Drawing.Color.Empty
        Me.Motivo.Location = New System.Drawing.Point(111, 143)
        Me.Motivo.Name = "Motivo"
        Me.Motivo.RegraValida��o = Nothing
        Me.Motivo.Size = New System.Drawing.Size(386, 20)
        Me.Motivo.TabIndex = 12
        Me.Motivo.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Motivo.ValorPadrao = Nothing
        '
        'Salvar
        '
        Me.Salvar.Image = CType(resources.GetObject("Salvar.Image"), System.Drawing.Image)
        Me.Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Salvar.Location = New System.Drawing.Point(285, 169)
        Me.Salvar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Salvar.Name = "Salvar"
        Me.Salvar.Size = New System.Drawing.Size(103, 55)
        Me.Salvar.TabIndex = 14
        Me.Salvar.Text = "Salvar"
        Me.Salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Salvar.UseVisualStyleBackColor = True
        '
        'Id
        '
        Me.Id.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Sim
        Me.Id.CasasDecimais = 0
        Me.Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Id.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.N�o
        Me.Id.FocusColor = System.Drawing.Color.Empty
        Me.Id.FocusColorEnd = System.Drawing.Color.Empty
        Me.Id.Location = New System.Drawing.Point(176, 38)
        Me.Id.Name = "Id"
        Me.Id.RegraValida��o = Nothing
        Me.Id.Size = New System.Drawing.Size(59, 20)
        Me.Id.TabIndex = 15
        Me.Id.TpFormata��o = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.Id.ValorPadrao = Nothing
        Me.Id.Visible = False
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Controls.Add(Me.Id)
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Controls.Add(Me.Salvar)
        Me.Fundo.Controls.Add(Me.Empresa)
        Me.Fundo.Controls.Add(Me.Label6)
        Me.Fundo.Controls.Add(Me.EmpresaDesc)
        Me.Fundo.Controls.Add(Me.Motivo)
        Me.Fundo.Controls.Add(Me.NumeroNf)
        Me.Fundo.Controls.Add(Me.Label5)
        Me.Fundo.Controls.Add(Me.Label2)
        Me.Fundo.Controls.Add(Me.Usu�rio)
        Me.Fundo.Controls.Add(Me.NovoNumeroNF)
        Me.Fundo.Controls.Add(Me.Label4)
        Me.Fundo.Controls.Add(Me.Label3)
        Me.Fundo.Controls.Add(Me.DataAltera��o)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(508, 228)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SlateGray
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.AliceBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 16
        '
        'NfAlteraSequencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(508, 228)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "NfAlteraSequencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Altera Sequ�ncia Num�rica da Nota Fiscal"
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fechar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Empresa As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents EmpresaDesc As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumeroNf As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NovoNumeroNF As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataAltera��o As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Usu�rio As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Motivo As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Salvar As System.Windows.Forms.Button
    Friend WithEvents Id As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
End Class
