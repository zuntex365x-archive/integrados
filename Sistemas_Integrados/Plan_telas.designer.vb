<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Plan_telas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Plan_telas))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.go = New System.Windows.Forms.Button()
        Me.to_excel = New System.Windows.Forms.Button()
        Me.cliente = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.R1 = New System.Windows.Forms.Button()
        Me.jg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.buscador = New System.Windows.Forms.Button()
        Me.to_excel1 = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jg, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.fg.Location = New System.Drawing.Point(12, 49)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(1094, 708)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 0
        '
        'go
        '
        Me.go.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.go.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.go.Location = New System.Drawing.Point(437, 3)
        Me.go.Name = "go"
        Me.go.Size = New System.Drawing.Size(118, 40)
        Me.go.TabIndex = 1
        Me.go.Text = "Procesar"
        Me.go.UseVisualStyleBackColor = False
        '
        'to_excel
        '
        Me.to_excel.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.to_excel.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.to_excel.ForeColor = System.Drawing.Color.Black
        Me.to_excel.Image = CType(resources.GetObject("to_excel.Image"), System.Drawing.Image)
        Me.to_excel.Location = New System.Drawing.Point(693, 3)
        Me.to_excel.Name = "to_excel"
        Me.to_excel.Size = New System.Drawing.Size(60, 40)
        Me.to_excel.TabIndex = 51
        Me.to_excel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.to_excel.UseVisualStyleBackColor = False
        Me.to_excel.Visible = False
        '
        'cliente
        '
        Me.cliente.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.IntegralHeight = False
        Me.cliente.Location = New System.Drawing.Point(132, 14)
        Me.cliente.MaxLength = 10
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(299, 24)
        Me.cliente.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Cliente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(561, 3)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(60, 40)
        Me.R1.TabIndex = 56
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.R1.UseVisualStyleBackColor = False
        '
        'jg
        '
        Me.jg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.jg.AllowEditing = False
        Me.jg.AllowFiltering = True
        Me.jg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.jg.AllowMergingFixed = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.jg.ColumnInfo = resources.GetString("jg.ColumnInfo")
        Me.jg.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.jg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.jg.Location = New System.Drawing.Point(12, 49)
        Me.jg.Name = "jg"
        Me.jg.Rows.DefaultSize = 19
        Me.jg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.jg.Size = New System.Drawing.Size(1094, 370)
        Me.jg.StyleInfo = resources.GetString("jg.StyleInfo")
        Me.jg.TabIndex = 57
        '
        'buscador
        '
        Me.buscador.BackColor = System.Drawing.Color.White
        Me.buscador.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscador.ForeColor = System.Drawing.Color.Black
        Me.buscador.Image = CType(resources.GetObject("buscador.Image"), System.Drawing.Image)
        Me.buscador.Location = New System.Drawing.Point(627, 3)
        Me.buscador.Name = "buscador"
        Me.buscador.Size = New System.Drawing.Size(60, 40)
        Me.buscador.TabIndex = 69
        Me.buscador.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.buscador.UseVisualStyleBackColor = False
        Me.buscador.Visible = False
        '
        'to_excel1
        '
        Me.to_excel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.to_excel1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.to_excel1.ForeColor = System.Drawing.Color.Black
        Me.to_excel1.Image = CType(resources.GetObject("to_excel1.Image"), System.Drawing.Image)
        Me.to_excel1.Location = New System.Drawing.Point(692, 3)
        Me.to_excel1.Name = "to_excel1"
        Me.to_excel1.Size = New System.Drawing.Size(60, 40)
        Me.to_excel1.TabIndex = 70
        Me.to_excel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.to_excel1.UseVisualStyleBackColor = False
        Me.to_excel1.Visible = False
        '
        'Plan_telas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1118, 742)
        Me.Controls.Add(Me.buscador)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.to_excel)
        Me.Controls.Add(Me.go)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.jg)
        Me.Controls.Add(Me.to_excel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Plan_telas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plan_Telas"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents go As System.Windows.Forms.Button
    Friend WithEvents to_excel As System.Windows.Forms.Button
    Friend WithEvents cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents jg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents buscador As System.Windows.Forms.Button
    Friend WithEvents to_excel1 As System.Windows.Forms.Button
End Class
