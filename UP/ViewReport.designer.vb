<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewReport))
        Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.btExportHTML = New DevComponents.DotNetBar.ButtonX
        Me.btFechar = New DevComponents.DotNetBar.ButtonX
        Me.btEnviarEmail = New DevComponents.DotNetBar.ButtonX
        Me.btExportPDF = New DevComponents.DotNetBar.ButtonX
        Me.VerRelat = New DataDynamics.ActiveReports.Viewer.Viewer
        Me.ExpandablePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExpandablePanel1
        '
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft
        Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ExpandablePanel1.Controls.Add(Me.ButtonX1)
        Me.ExpandablePanel1.Controls.Add(Me.btExportHTML)
        Me.ExpandablePanel1.Controls.Add(Me.btFechar)
        Me.ExpandablePanel1.Controls.Add(Me.btEnviarEmail)
        Me.ExpandablePanel1.Controls.Add(Me.btExportPDF)
        Me.ExpandablePanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ExpandablePanel1.Location = New System.Drawing.Point(717, 0)
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.Size = New System.Drawing.Size(150, 486)
        Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TabIndex = 1
        Me.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel1.TitleText = "Ferramentas"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(4, 146)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(142, 33)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 3
        Me.ButtonX1.Text = "Exportar em Excel"
        '
        'btExportHTML
        '
        Me.btExportHTML.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btExportHTML.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btExportHTML.Image = CType(resources.GetObject("btExportHTML.Image"), System.Drawing.Image)
        Me.btExportHTML.Location = New System.Drawing.Point(5, 109)
        Me.btExportHTML.Name = "btExportHTML"
        Me.btExportHTML.Size = New System.Drawing.Size(142, 33)
        Me.btExportHTML.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btExportHTML.TabIndex = 2
        Me.btExportHTML.Text = "Exportar em HTML"
        '
        'btFechar
        '
        Me.btFechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btFechar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btFechar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btFechar.Location = New System.Drawing.Point(0, 453)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(150, 33)
        Me.btFechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btFechar.TabIndex = 4
        Me.btFechar.Text = "Fechar Visualizador"
        '
        'btEnviarEmail
        '
        Me.btEnviarEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btEnviarEmail.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btEnviarEmail.Enabled = False
        Me.btEnviarEmail.Image = CType(resources.GetObject("btEnviarEmail.Image"), System.Drawing.Image)
        Me.btEnviarEmail.Location = New System.Drawing.Point(6, 70)
        Me.btEnviarEmail.Name = "btEnviarEmail"
        Me.btEnviarEmail.Size = New System.Drawing.Size(142, 33)
        Me.btEnviarEmail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btEnviarEmail.TabIndex = 1
        Me.btEnviarEmail.Text = "Enviar Email em PDF"
        '
        'btExportPDF
        '
        Me.btExportPDF.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btExportPDF.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btExportPDF.Image = CType(resources.GetObject("btExportPDF.Image"), System.Drawing.Image)
        Me.btExportPDF.Location = New System.Drawing.Point(5, 31)
        Me.btExportPDF.Name = "btExportPDF"
        Me.btExportPDF.Size = New System.Drawing.Size(142, 33)
        Me.btExportPDF.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btExportPDF.TabIndex = 0
        Me.btExportPDF.Text = "Exportar em PDF"
        '
        'VerRelat
        '
        Me.VerRelat.BackColor = System.Drawing.SystemColors.Control
        Me.VerRelat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VerRelat.Document = New DataDynamics.ActiveReports.Document.Document("ARNet Document")
        Me.VerRelat.Location = New System.Drawing.Point(0, 0)
        Me.VerRelat.Name = "VerRelat"
        Me.VerRelat.ReportViewer.CurrentPage = 0
        Me.VerRelat.ReportViewer.MultiplePageCols = 3
        Me.VerRelat.ReportViewer.MultiplePageRows = 2
        Me.VerRelat.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal
        Me.VerRelat.Size = New System.Drawing.Size(717, 486)
        Me.VerRelat.TabIndex = 0
        Me.VerRelat.TableOfContents.Text = "Table Of Contents"
        Me.VerRelat.TableOfContents.Width = 200
        Me.VerRelat.TabTitleLength = 35
        Me.VerRelat.Toolbar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ViewReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btFechar
        Me.ClientSize = New System.Drawing.Size(867, 486)
        Me.Controls.Add(Me.VerRelat)
        Me.Controls.Add(Me.ExpandablePanel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ViewReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ExpandablePanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents VerRelat As DataDynamics.ActiveReports.Viewer.Viewer
    Friend WithEvents btExportPDF As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btEnviarEmail As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btFechar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btExportHTML As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class
