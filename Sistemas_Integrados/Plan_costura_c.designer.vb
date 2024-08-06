<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Plan_costura_c
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Plan_costura_c))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.go = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.to_excel = New System.Windows.Forms.Button()
        Me.imprime = New System.Windows.Forms.Button()
        Me.C1SuperTooltip1 = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowFiltering = True
        Me.fg.AllowMergingFixed = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(12, 49)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(1094, 708)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 0
        Me.fg.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'go
        '
        Me.go.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.go.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.go.Location = New System.Drawing.Point(12, 9)
        Me.go.Name = "go"
        Me.go.Size = New System.Drawing.Size(118, 34)
        Me.go.TabIndex = 1
        Me.go.Text = "Procesar"
        Me.C1SuperTooltip1.SetToolTip(Me.go, resources.GetString("go.ToolTip"))
        Me.go.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 38)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'to_excel
        '
        Me.to_excel.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.to_excel.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.to_excel.ForeColor = System.Drawing.Color.Black
        Me.to_excel.Image = CType(resources.GetObject("to_excel.Image"), System.Drawing.Image)
        Me.to_excel.Location = New System.Drawing.Point(1046, 8)
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
        Me.imprime.Location = New System.Drawing.Point(980, 9)
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
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 8)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(686, 34)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 53
        Me.ProgressBar1.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(155, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(447, 33)
        Me.Label2.TabIndex = 54
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 36)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Actualizado por:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = False
        '
        'Plan_costura_c
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1118, 742)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.imprime)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.to_excel)
        Me.Controls.Add(Me.go)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Plan_costura_c"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plan_costura"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents go As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents to_excel As System.Windows.Forms.Button
    Friend WithEvents imprime As System.Windows.Forms.Button
    Friend WithEvents C1SuperTooltip1 As C1.Win.C1SuperTooltip.C1SuperTooltip
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
