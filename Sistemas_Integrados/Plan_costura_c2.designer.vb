<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Plan_costura_c2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Plan_costura_c2))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.to_excel = New System.Windows.Forms.Button()
        Me.imprime = New System.Windows.Forms.Button()
        Me.C1SuperTooltip1 = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        Me.fj = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.cierre = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.R1 = New System.Windows.Forms.Button()
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
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(12, 49)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(1094, 708)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 0
        '
        'to_excel
        '
        Me.to_excel.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.to_excel.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.to_excel.ForeColor = System.Drawing.Color.Black
        Me.to_excel.Image = CType(resources.GetObject("to_excel.Image"), System.Drawing.Image)
        Me.to_excel.Location = New System.Drawing.Point(980, 3)
        Me.to_excel.Name = "to_excel"
        Me.to_excel.Size = New System.Drawing.Size(60, 40)
        Me.to_excel.TabIndex = 51
        Me.to_excel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.C1SuperTooltip1.SetToolTip(Me.to_excel, resources.GetString("to_excel.ToolTip"))
        Me.to_excel.UseVisualStyleBackColor = False
        Me.to_excel.Visible = False
        '
        'imprime
        '
        Me.imprime.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.imprime.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imprime.ForeColor = System.Drawing.Color.Black
        Me.imprime.Image = CType(resources.GetObject("imprime.Image"), System.Drawing.Image)
        Me.imprime.Location = New System.Drawing.Point(914, 3)
        Me.imprime.Name = "imprime"
        Me.imprime.Size = New System.Drawing.Size(60, 40)
        Me.imprime.TabIndex = 52
        Me.imprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.C1SuperTooltip1.SetToolTip(Me.imprime, resources.GetString("imprime.ToolTip"))
        Me.imprime.UseVisualStyleBackColor = False
        Me.imprime.Visible = False
        '
        'C1SuperTooltip1
        '
        Me.C1SuperTooltip1.AutomaticDelay = 5000
        Me.C1SuperTooltip1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.C1SuperTooltip1.InitialDelay = 2000
        '
        'fj
        '
        Me.fj.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fj.AllowEditing = False
        Me.fj.AllowFiltering = True
        Me.fj.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fj.BackColor = System.Drawing.Color.White
        Me.fj.ColumnInfo = resources.GetString("fj.ColumnInfo")
        Me.fj.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fj.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.fj.ForeColor = System.Drawing.Color.Black
        Me.fj.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fj.Location = New System.Drawing.Point(15, 49)
        Me.fj.Name = "fj"
        Me.fj.Rows.DefaultSize = 19
        Me.fj.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fj.Size = New System.Drawing.Size(1424, 552)
        Me.fj.StyleInfo = resources.GetString("fj.StyleInfo")
        Me.fj.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fj.TabIndex = 61
        '
        'cierre
        '
        Me.cierre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cierre.Location = New System.Drawing.Point(106, 19)
        Me.cierre.Name = "cierre"
        Me.cierre.Size = New System.Drawing.Size(176, 24)
        Me.cierre.TabIndex = 64
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 24)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Semana:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(850, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 40)
        Me.Button1.TabIndex = 65
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(850, 3)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(60, 40)
        Me.R1.TabIndex = 66
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.R1.UseVisualStyleBackColor = False
        Me.R1.Visible = False
        '
        'Plan_costura_c2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1118, 742)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cierre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.fj)
        Me.Controls.Add(Me.imprime)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.to_excel)
        Me.Controls.Add(Me.R1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Plan_costura_c2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Plan_costura"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents to_excel As System.Windows.Forms.Button
    Friend WithEvents imprime As System.Windows.Forms.Button
    Private WithEvents C1SuperTooltip1 As C1.Win.C1SuperTooltip.C1SuperTooltip
    Friend WithEvents fj As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents cierre As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents R1 As System.Windows.Forms.Button
End Class
