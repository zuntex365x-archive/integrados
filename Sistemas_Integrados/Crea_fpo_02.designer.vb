<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crea_fpo_02
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Crea_fpo_02))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.colores = New System.Windows.Forms.Label()
        Me.mq = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bt = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.graba = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowMergingFixed = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(12, 44)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(1259, 179)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Color: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colores
        '
        Me.colores.BackColor = System.Drawing.Color.White
        Me.colores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.colores.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colores.Location = New System.Drawing.Point(106, 9)
        Me.colores.Name = "colores"
        Me.colores.Size = New System.Drawing.Size(726, 33)
        Me.colores.TabIndex = 2
        Me.colores.Text = "Color: "
        Me.colores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mq
        '
        Me.mq.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.mq.AllowMergingFixed = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.mq.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.mq.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.mq.ColumnInfo = resources.GetString("mq.ColumnInfo")
        Me.mq.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.mq.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.mq.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.mq.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.mq.Location = New System.Drawing.Point(12, 240)
        Me.mq.Name = "mq"
        Me.mq.Rows.Count = 4
        Me.mq.Rows.DefaultSize = 21
        Me.mq.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.mq.Size = New System.Drawing.Size(1123, 126)
        Me.mq.StyleInfo = resources.GetString("mq.StyleInfo")
        Me.mq.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.mq.TabIndex = 4
        '
        'bt
        '
        Me.bt.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.bt.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Nodes
        Me.bt.AllowMergingFixed = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.bt.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.bt.ColumnInfo = resources.GetString("bt.ColumnInfo")
        Me.bt.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.bt.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.bt.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.bt.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.bt.Location = New System.Drawing.Point(12, 384)
        Me.bt.Name = "bt"
        Me.bt.Rows.DefaultSize = 21
        Me.bt.Rows.Fixed = 2
        Me.bt.Size = New System.Drawing.Size(1530, 346)
        Me.bt.StyleInfo = resources.GetString("bt.StyleInfo")
        Me.bt.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.bt.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1155, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 22)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "FPO No. :"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1254, 251)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(213, 26)
        Me.TextBox1.TabIndex = 8
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(1482, 247)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(60, 40)
        Me.graba.TabIndex = 19
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.graba.UseVisualStyleBackColor = False
        '
        'Crea_fpo_02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1554, 742)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.graba)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bt)
        Me.Controls.Add(Me.mq)
        Me.Controls.Add(Me.colores)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Crea_fpo_02"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga Space"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents colores As System.Windows.Forms.Label
    Friend WithEvents mq As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents bt As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents graba As System.Windows.Forms.Button
End Class
