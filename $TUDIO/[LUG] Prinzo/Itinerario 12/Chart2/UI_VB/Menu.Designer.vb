<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ChartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TablaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XmlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Chart2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarimportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChartToolStripMenuItem, Me.Chart2ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(924, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ChartToolStripMenuItem
        '
        Me.ChartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VectoresToolStripMenuItem, Me.DataviewToolStripMenuItem, Me.TablaToolStripMenuItem, Me.ListasToolStripMenuItem, Me.XmlToolStripMenuItem})
        Me.ChartToolStripMenuItem.Name = "ChartToolStripMenuItem"
        Me.ChartToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ChartToolStripMenuItem.Text = "Chart"
        '
        'VectoresToolStripMenuItem
        '
        Me.VectoresToolStripMenuItem.Name = "VectoresToolStripMenuItem"
        Me.VectoresToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VectoresToolStripMenuItem.Text = "vectores"
        '
        'DataviewToolStripMenuItem
        '
        Me.DataviewToolStripMenuItem.Name = "DataviewToolStripMenuItem"
        Me.DataviewToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataviewToolStripMenuItem.Text = "Dataview"
        '
        'TablaToolStripMenuItem
        '
        Me.TablaToolStripMenuItem.Name = "TablaToolStripMenuItem"
        Me.TablaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TablaToolStripMenuItem.Text = "Tabla"
        '
        'XmlToolStripMenuItem
        '
        Me.XmlToolStripMenuItem.Name = "XmlToolStripMenuItem"
        Me.XmlToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.XmlToolStripMenuItem.Text = "Xml"
        '
        'Chart2ToolStripMenuItem
        '
        Me.Chart2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportarimportarToolStripMenuItem})
        Me.Chart2ToolStripMenuItem.Name = "Chart2ToolStripMenuItem"
        Me.Chart2ToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.Chart2ToolStripMenuItem.Text = "chart2"
        '
        'ExportarimportarToolStripMenuItem
        '
        Me.ExportarimportarToolStripMenuItem.Name = "ExportarimportarToolStripMenuItem"
        Me.ExportarimportarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExportarimportarToolStripMenuItem.Text = "Exportar/Importar"
        '
        'ListasToolStripMenuItem
        '
        Me.ListasToolStripMenuItem.Name = "ListasToolStripMenuItem"
        Me.ListasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ListasToolStripMenuItem.Text = "Listas"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 543)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ChartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VectoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TablaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XmlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Chart2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportarimportarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListasToolStripMenuItem As ToolStripMenuItem
End Class
