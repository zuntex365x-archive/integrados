<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mae_tex_c
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mae_tex_c))
        Me.db = New C1.Win.C1Command.C1DockingTab()
        Me.d1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.h1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.wf = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.d3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.nf = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.db, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.db.SuspendLayout()
        Me.d1.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.h1.SuspendLayout()
        CType(Me.wf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.d3.SuspendLayout()
        CType(Me.nf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'db
        '
        Me.db.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.db.Controls.Add(Me.d1)
        Me.db.Controls.Add(Me.h1)
        Me.db.Controls.Add(Me.d3)
        Me.db.Dock = System.Windows.Forms.DockStyle.Fill
        Me.db.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.db.Location = New System.Drawing.Point(0, 0)
        Me.db.Name = "db"
        Me.db.Size = New System.Drawing.Size(1006, 635)
        Me.db.TabIndex = 1
        Me.db.TabsSpacing = -1
        Me.db.TabStyle = C1.Win.C1Command.TabStyleEnum.Rounded
        Me.db.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.db.VisualStyleBase = C1.Win.C1Command.VisualStyle.Classic
        '
        'd1
        '
        Me.d1.Controls.Add(Me.fg)
        Me.d1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d1.Location = New System.Drawing.Point(1, 30)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(1004, 604)
        Me.d1.TabBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.d1.TabBackColorSelected = System.Drawing.Color.Transparent
        Me.d1.TabForeColor = System.Drawing.Color.Black
        Me.d1.TabIndex = 0
        Me.d1.Text = "Greige"
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(7, 16)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 25
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(994, 585)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 92
        '
        'h1
        '
        Me.h1.CaptionText = "Weight"
        Me.h1.Controls.Add(Me.wf)
        Me.h1.Location = New System.Drawing.Point(1, 30)
        Me.h1.Name = "h1"
        Me.h1.Size = New System.Drawing.Size(1004, 604)
        Me.h1.TabBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.h1.TabForeColor = System.Drawing.Color.Black
        Me.h1.TabIndex = 1
        Me.h1.Text = "Capacidad Máquinas"
        '
        'wf
        '
        Me.wf.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.wf.AllowEditing = False
        Me.wf.AllowFiltering = True
        Me.wf.BackColor = System.Drawing.Color.White
        Me.wf.ColumnInfo = resources.GetString("wf.ColumnInfo")
        Me.wf.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.wf.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.wf.ForeColor = System.Drawing.Color.Black
        Me.wf.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.wf.Location = New System.Drawing.Point(7, 12)
        Me.wf.Name = "wf"
        Me.wf.Rows.Count = 1
        Me.wf.Rows.DefaultSize = 25
        Me.wf.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.wf.Size = New System.Drawing.Size(994, 589)
        Me.wf.StyleInfo = resources.GetString("wf.StyleInfo")
        Me.wf.TabIndex = 99
        '
        'd3
        '
        Me.d3.CaptionText = "Batches"
        Me.d3.Controls.Add(Me.nf)
        Me.d3.Location = New System.Drawing.Point(1, 30)
        Me.d3.Name = "d3"
        Me.d3.Size = New System.Drawing.Size(1004, 604)
        Me.d3.TabBackColor = System.Drawing.Color.CornflowerBlue
        Me.d3.TabForeColor = System.Drawing.Color.Black
        Me.d3.TabIndex = 2
        Me.d3.Text = "Lbs.x.Batch"
        '
        'nf
        '
        Me.nf.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.nf.AllowEditing = False
        Me.nf.AllowFiltering = True
        Me.nf.BackColor = System.Drawing.Color.White
        Me.nf.ColumnInfo = resources.GetString("nf.ColumnInfo")
        Me.nf.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.nf.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.nf.ForeColor = System.Drawing.Color.Black
        Me.nf.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.nf.Location = New System.Drawing.Point(7, 14)
        Me.nf.Name = "nf"
        Me.nf.Rows.Count = 1
        Me.nf.Rows.DefaultSize = 25
        Me.nf.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.nf.Size = New System.Drawing.Size(994, 587)
        Me.nf.StyleInfo = resources.GetString("nf.StyleInfo")
        Me.nf.TabIndex = 99
        '
        'Mae_tex_c
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 635)
        Me.Controls.Add(Me.db)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Mae_tex_c"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro de Texpasa"
        CType(Me.db, System.ComponentModel.ISupportInitialize).EndInit()
        Me.db.ResumeLayout(False)
        Me.d1.ResumeLayout(False)
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.h1.ResumeLayout(False)
        CType(Me.wf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.d3.ResumeLayout(False)
        CType(Me.nf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents db As C1.Win.C1Command.C1DockingTab
    Friend WithEvents d1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents h1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents d3 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents wf As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents nf As C1.Win.C1FlexGrid.C1FlexGrid
End Class
