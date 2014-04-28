<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolhaPgtoModulos
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FolhaPgtoModulos))
        Me.Fechar = New System.Windows.Forms.Button
        Me.MyLista = New System.Windows.Forms.ListView
        Me.ColModulo = New System.Windows.Forms.ColumnHeader
        Me.ListaEventos = New System.Windows.Forms.ListView
        Me.ColId = New System.Windows.Forms.ColumnHeader
        Me.ColModulos = New System.Windows.Forms.ColumnHeader
        Me.ColEvento = New System.Windows.Forms.ColumnHeader
        Me.ColDescrição = New System.Windows.Forms.ColumnHeader
        Me.MenuEventosSelecionado = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AdicionarEventosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExcluirEventosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.PainelCadEventos = New System.Windows.Forms.Panel
        Me.Vortar = New System.Windows.Forms.Button
        Me.AddBt = New System.Windows.Forms.Button
        Me.EventoDesc = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.EventoID = New TexBoxFocusNet.TextBoxFocusNet
        Me.Fundo = New DevComponents.DotNetBar.PanelEx
        Me.MenuEventosSelecionado.SuspendLayout()
        Me.PainelCadEventos.SuspendLayout()
        Me.Fundo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fechar
        '
        Me.Fechar.Image = CType(resources.GetObject("Fechar.Image"), System.Drawing.Image)
        Me.Fechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Fechar.Location = New System.Drawing.Point(309, 285)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(112, 54)
        Me.Fechar.TabIndex = 0
        Me.Fechar.Text = "Fechar"
        Me.Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Fechar.UseVisualStyleBackColor = True
        '
        'MyLista
        '
        Me.MyLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColModulo})
        Me.MyLista.FullRowSelect = True
        Me.MyLista.GridLines = True
        Me.MyLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MyLista.Location = New System.Drawing.Point(12, 3)
        Me.MyLista.MultiSelect = False
        Me.MyLista.Name = "MyLista"
        Me.MyLista.Size = New System.Drawing.Size(195, 276)
        Me.MyLista.TabIndex = 5
        Me.MyLista.UseCompatibleStateImageBehavior = False
        Me.MyLista.View = System.Windows.Forms.View.Details
        '
        'ColModulo
        '
        Me.ColModulo.Text = "Modulos"
        Me.ColModulo.Width = 174
        '
        'ListaEventos
        '
        Me.ListaEventos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColId, Me.ColModulos, Me.ColEvento, Me.ColDescrição})
        Me.ListaEventos.ContextMenuStrip = Me.MenuEventosSelecionado
        Me.ListaEventos.FullRowSelect = True
        Me.ListaEventos.GridLines = True
        Me.ListaEventos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListaEventos.Location = New System.Drawing.Point(226, 3)
        Me.ListaEventos.MultiSelect = False
        Me.ListaEventos.Name = "ListaEventos"
        Me.ListaEventos.Size = New System.Drawing.Size(195, 276)
        Me.ListaEventos.TabIndex = 6
        Me.ListaEventos.UseCompatibleStateImageBehavior = False
        Me.ListaEventos.View = System.Windows.Forms.View.Details
        '
        'ColId
        '
        Me.ColId.Text = "Id"
        Me.ColId.Width = 0
        '
        'ColModulos
        '
        Me.ColModulos.Text = "Modulos"
        Me.ColModulos.Width = 0
        '
        'ColEvento
        '
        Me.ColEvento.Text = "Evento"
        Me.ColEvento.Width = 0
        '
        'ColDescrição
        '
        Me.ColDescrição.Text = "Evento Descrição"
        Me.ColDescrição.Width = 174
        '
        'MenuEventosSelecionado
        '
        Me.MenuEventosSelecionado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarEventosToolStripMenuItem, Me.ExcluirEventosToolStripMenuItem})
        Me.MenuEventosSelecionado.Name = "MenuEventosSelecionado"
        Me.MenuEventosSelecionado.Size = New System.Drawing.Size(170, 48)
        '
        'AdicionarEventosToolStripMenuItem
        '
        Me.AdicionarEventosToolStripMenuItem.Name = "AdicionarEventosToolStripMenuItem"
        Me.AdicionarEventosToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AdicionarEventosToolStripMenuItem.Text = "Adicionar Eventos"
        '
        'ExcluirEventosToolStripMenuItem
        '
        Me.ExcluirEventosToolStripMenuItem.Name = "ExcluirEventosToolStripMenuItem"
        Me.ExcluirEventosToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ExcluirEventosToolStripMenuItem.Text = "Excluir Eventos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(205, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "<->"
        '
        'PainelCadEventos
        '
        Me.PainelCadEventos.BackColor = System.Drawing.Color.Transparent
        Me.PainelCadEventos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PainelCadEventos.Controls.Add(Me.Vortar)
        Me.PainelCadEventos.Controls.Add(Me.AddBt)
        Me.PainelCadEventos.Controls.Add(Me.EventoDesc)
        Me.PainelCadEventos.Controls.Add(Me.Label2)
        Me.PainelCadEventos.Controls.Add(Me.EventoID)
        Me.PainelCadEventos.Location = New System.Drawing.Point(12, 285)
        Me.PainelCadEventos.Name = "PainelCadEventos"
        Me.PainelCadEventos.Size = New System.Drawing.Size(291, 54)
        Me.PainelCadEventos.TabIndex = 9
        Me.PainelCadEventos.Visible = False
        '
        'Vortar
        '
        Me.Vortar.Location = New System.Drawing.Point(187, 3)
        Me.Vortar.Name = "Vortar"
        Me.Vortar.Size = New System.Drawing.Size(47, 23)
        Me.Vortar.TabIndex = 8
        Me.Vortar.Text = "Voltar"
        Me.Vortar.UseVisualStyleBackColor = True
        '
        'AddBt
        '
        Me.AddBt.Location = New System.Drawing.Point(129, 3)
        Me.AddBt.Name = "AddBt"
        Me.AddBt.Size = New System.Drawing.Size(52, 23)
        Me.AddBt.TabIndex = 7
        Me.AddBt.Text = "Add"
        Me.AddBt.UseVisualStyleBackColor = True
        '
        'EventoDesc
        '
        Me.EventoDesc.BackColor = System.Drawing.Color.Transparent
        Me.EventoDesc.ForeColor = System.Drawing.Color.Black
        Me.EventoDesc.Location = New System.Drawing.Point(66, 26)
        Me.EventoDesc.Name = "EventoDesc"
        Me.EventoDesc.Size = New System.Drawing.Size(222, 22)
        Me.EventoDesc.TabIndex = 6
        Me.EventoDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Evento"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EventoID
        '
        Me.EventoID.BloquearCx = TexBoxFocusNet.TextBoxFocusNet.Bloquear.Não
        Me.EventoID.CasasDecimais = 0
        Me.EventoID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EventoID.EntrouCaixa = TexBoxFocusNet.TextBoxFocusNet.CaixaEntrou.Sim
        Me.EventoID.FocusColor = System.Drawing.Color.Empty
        Me.EventoID.FocusColorEnd = System.Drawing.Color.Empty
        Me.EventoID.Location = New System.Drawing.Point(66, 4)
        Me.EventoID.MaxLength = 7
        Me.EventoID.Name = "EventoID"
        Me.EventoID.RegraValidação = Nothing
        Me.EventoID.Size = New System.Drawing.Size(57, 20)
        Me.EventoID.TabIndex = 5
        Me.EventoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.EventoID.TpFormatação = TexBoxFocusNet.TextBoxFocusNet.TpCaixa.Normal
        Me.EventoID.ValorPadrao = Nothing
        '
        'Fundo
        '
        Me.Fundo.CanvasColor = System.Drawing.SystemColors.Control
        Me.Fundo.Controls.Add(Me.MyLista)
        Me.Fundo.Controls.Add(Me.ListaEventos)
        Me.Fundo.Controls.Add(Me.Fechar)
        Me.Fundo.Controls.Add(Me.PainelCadEventos)
        Me.Fundo.Controls.Add(Me.Label1)
        Me.Fundo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fundo.Location = New System.Drawing.Point(0, 0)
        Me.Fundo.Name = "Fundo"
        Me.Fundo.Size = New System.Drawing.Size(432, 351)
        Me.Fundo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Fundo.Style.BackColor1.Color = System.Drawing.Color.SlateGray
        Me.Fundo.Style.BackColor2.Color = System.Drawing.Color.AliceBlue
        Me.Fundo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Fundo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Fundo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Fundo.Style.GradientAngle = 90
        Me.Fundo.TabIndex = 10
        '
        'FolhaPgtoModulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 351)
        Me.ControlBox = False
        Me.Controls.Add(Me.Fundo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FolhaPgtoModulos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modulos da Folha de Pagamento"
        Me.MenuEventosSelecionado.ResumeLayout(False)
        Me.PainelCadEventos.ResumeLayout(False)
        Me.PainelCadEventos.PerformLayout()
        Me.Fundo.ResumeLayout(False)
        Me.Fundo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fechar As System.Windows.Forms.Button
    Friend WithEvents MyLista As System.Windows.Forms.ListView
    Friend WithEvents ColModulo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListaEventos As System.Windows.Forms.ListView
    Friend WithEvents ColModulos As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColEvento As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColDescrição As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuEventosSelecionado As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AdicionarEventosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcluirEventosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColId As System.Windows.Forms.ColumnHeader
    Friend WithEvents PainelCadEventos As System.Windows.Forms.Panel
    Friend WithEvents Vortar As System.Windows.Forms.Button
    Friend WithEvents AddBt As System.Windows.Forms.Button
    Friend WithEvents EventoDesc As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EventoID As TexBoxFocusNet.TextBoxFocusNet
    Friend WithEvents Fundo As DevComponents.DotNetBar.PanelEx
End Class
