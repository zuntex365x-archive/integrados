<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Carga_open
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Carga_open))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.go = New System.Windows.Forms.Button()
        Me.R1 = New System.Windows.Forms.Button()
        Me.abrear = New System.Windows.Forms.OpenFileDialog()
        Me.G1 = New System.Windows.Forms.Button()
        Me.regs = New System.Windows.Forms.Label()
        Me.fj = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowMergingFixed = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(12, 73)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(1094, 684)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 0
        '
        'go
        '
        Me.go.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.go.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.go.Location = New System.Drawing.Point(284, 12)
        Me.go.Name = "go"
        Me.go.Size = New System.Drawing.Size(107, 40)
        Me.go.TabIndex = 1
        Me.go.Text = "Procesar"
        Me.go.UseVisualStyleBackColor = False
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(396, 12)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(60, 40)
        Me.R1.TabIndex = 56
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.R1.UseVisualStyleBackColor = False
        '
        'abrear
        '
        Me.abrear.FileName = "OpenFileDialog1"
        '
        'G1
        '
        Me.G1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.G1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G1.ForeColor = System.Drawing.Color.Black
        Me.G1.Image = CType(resources.GetObject("G1.Image"), System.Drawing.Image)
        Me.G1.Location = New System.Drawing.Point(330, 12)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(60, 40)
        Me.G1.TabIndex = 82
        Me.G1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.G1.UseVisualStyleBackColor = False
        Me.G1.Visible = False
        '
        'regs
        '
        Me.regs.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.regs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regs.Location = New System.Drawing.Point(517, 12)
        Me.regs.Name = "regs"
        Me.regs.Size = New System.Drawing.Size(273, 39)
        Me.regs.TabIndex = 83
        Me.regs.Text = " "
        Me.regs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.regs.Visible = False
        '
        'fj
        '
        Me.fj.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fj.AllowEditing = False
        Me.fj.AllowFiltering = True
        Me.fj.AllowMergingFixed = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.fj.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fj.ColumnInfo = resources.GetString("fj.ColumnInfo")
        Me.fj.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.fj.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fj.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fj.Location = New System.Drawing.Point(12, 72)
        Me.fj.Name = "fj"
        Me.fj.Rows.DefaultSize = 19
        Me.fj.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fj.Size = New System.Drawing.Size(1094, 684)
        Me.fj.StyleInfo = resources.GetString("fj.StyleInfo")
        Me.fj.TabIndex = 84
        Me.fj.Visible = False
        '
        'Carga_open
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1118, 742)
        Me.Controls.Add(Me.regs)
        Me.Controls.Add(Me.G1)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.go)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.fj)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Carga_open"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga Open Orders"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents go As System.Windows.Forms.Button
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents abrear As System.Windows.Forms.OpenFileDialog
    Friend WithEvents G1 As System.Windows.Forms.Button
    Friend WithEvents regs As System.Windows.Forms.Label
    Friend WithEvents fj As C1.Win.C1FlexGrid.C1FlexGrid
End Class
