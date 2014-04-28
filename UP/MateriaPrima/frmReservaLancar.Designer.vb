<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservaLancar
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReservaLancar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDisponivel = New System.Windows.Forms.Label()
        Me.lblReservado = New System.Windows.Forms.Label()
        Me.lblEstoqueFisico = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQtd = New TexBoxFocusNet.TextBoxFocusNet()
        Me.txtProduto = New TexBoxFocusNet.TextBoxFocusNet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAdicionarItem = New DevComponents.DotNetBar.ButtonX()
        Me.btnFechar = New DevComponents.DotNetBar.ButtonX()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblDisponivel)
        Me.Panel1.Controls.Add(Me.lblReservado)
        Me.Panel1.Controls.Add(Me.lblEstoqueFisico)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(11, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(272, 119)
        Me.Panel1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Estoque Disponível"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Qtde Reservado"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisponivel
        '
        Me.lblDisponivel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDisponivel.BackColor = System.Drawing.Color.White
        Me.lblDisponivel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisponivel.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisponivel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDisponivel.Location = New System.Drawing.Point(114, 72)
        Me.lblDisponivel.Name = "lblDisponivel"
        Me.lblDisponivel.Size = New System.Drawing.Size(149, 24)
        Me.lblDisponivel.TabIndex = 5
        Me.lblDisponivel.Text = "0,00000"
        Me.lblDisponivel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReservado
        '
        Me.lblReservado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblReservado.BackColor = System.Drawing.Color.White
        Me.lblReservado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReservado.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservado.ForeColor = System.Drawing.Color.Red
        Me.lblReservado.Location = New System.Drawing.Point(114, 41)
        Me.lblReservado.Name = "lblReservado"
        Me.lblReservado.Size = New System.Drawing.Size(149, 24)
        Me.lblReservado.TabIndex = 3
        Me.lblReservado.Text = "0,00000"
        Me.lblReservado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEstoqueFisico
        '
        Me.lblEstoqueFisico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstoqueFisico.BackColor = System.Drawing.Color.White
        Me.lblEstoqueFisico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEstoqueFisico.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstoqueFisico.ForeColor = System.Drawing.Color.Green
        Me.lblEstoqueFisico.Location = New System.Drawing.Point(114, 8)
        Me.lblEstoqueFisico.Name = "lblEstoqueFisico"
        Me.lblEstoqueFisico.Size = New System.Drawing.Size(149, 24)
        Me.lblEstoqueFisico.TabIndex = 1
        Me.lblEstoqueFisico.Text = "0,00000"
        Me.lblEstoqueFisico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Estoque Físico"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtQtd
        '
        Me.txtQtd.AceitaColarTexto = True
        Me.txtQtd.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtQtd.CasasDecimais = 3
        Me.txtQtd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQtd.CPObrigatorio = False
        Me.txtQtd.CPObrigatorioMsg = Nothing
        Me.txtQtd.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtQtd.FlatBorder = False
        Me.txtQtd.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtQtd.FocusColor = System.Drawing.Color.Empty
        Me.txtQtd.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtQtd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtd.HighlightBorderOnEnter = False
        Me.txtQtd.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtQtd.Location = New System.Drawing.Point(127, 34)
        Me.txtQtd.MaxLength = 15
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.PreencherZeroEsqueda = False
        Me.txtQtd.RegraValidação = Nothing
        Me.txtQtd.RegraValidaçãoMensagem = Nothing
        Me.txtQtd.Size = New System.Drawing.Size(123, 23)
        Me.txtQtd.TabIndex = 11
        Me.txtQtd.Text = "0,000"
        Me.txtQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtd.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Numeros
        Me.txtQtd.ValorPadrao = Nothing
        '
        'txtProduto
        '
        Me.txtProduto.AceitaColarTexto = True
        Me.txtProduto.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.txtProduto.CasasDecimais = 3
        Me.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProduto.CPObrigatorio = False
        Me.txtProduto.CPObrigatorioMsg = Nothing
        Me.txtProduto.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Não
        Me.txtProduto.FlatBorder = False
        Me.txtProduto.FlatBorderColor = System.Drawing.Color.DimGray
        Me.txtProduto.FocusColor = System.Drawing.Color.Empty
        Me.txtProduto.FocusColorEnd = System.Drawing.Color.Empty
        Me.txtProduto.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduto.HighlightBorderOnEnter = False
        Me.txtProduto.HighlightBorderOnEnterColor = System.Drawing.Color.DimGray
        Me.txtProduto.Location = New System.Drawing.Point(127, 5)
        Me.txtProduto.MaxLength = 15
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.PreencherZeroEsqueda = False
        Me.txtProduto.RegraValidação = Nothing
        Me.txtProduto.RegraValidaçãoMensagem = Nothing
        Me.txtProduto.Size = New System.Drawing.Size(123, 23)
        Me.txtProduto.TabIndex = 9
        Me.txtProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtProduto.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.txtProduto.ValorPadrao = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 14)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Quantide"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 14)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Codigo Produto"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(256, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 17)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'btnAdicionarItem
        '
        Me.btnAdicionarItem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdicionarItem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnAdicionarItem.Image = CType(resources.GetObject("btnAdicionarItem.Image"), System.Drawing.Image)
        Me.btnAdicionarItem.Location = New System.Drawing.Point(11, 187)
        Me.btnAdicionarItem.Name = "btnAdicionarItem"
        Me.btnAdicionarItem.Size = New System.Drawing.Size(113, 33)
        Me.btnAdicionarItem.TabIndex = 14
        Me.btnAdicionarItem.Text = "Salvar"
        '
        'btnFechar
        '
        Me.btnFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.Location = New System.Drawing.Point(173, 187)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(110, 33)
        Me.btnFechar.TabIndex = 15
        Me.btnFechar.Text = "Fechar"
        '
        'frmReservaLancar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnFechar
        Me.ClientSize = New System.Drawing.Size(294, 229)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnAdicionarItem)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtQtd)
        Me.Controls.Add(Me.txtProduto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Name = "frmReservaLancar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lançar Reserva"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDisponivel As System.Windows.Forms.Label
    Friend WithEvents lblReservado As System.Windows.Forms.Label
    Friend WithEvents lblEstoqueFisico As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtQtd As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents txtProduto As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAdicionarItem As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnFechar As DevComponents.DotNetBar.ButtonX
End Class
