<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Plan_telas_1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Plan_telas_1))
        Me.tm = New C1.Win.C1Command.C1DockingTab()
        Me.d1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.jg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.d2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cli = New System.Windows.Forms.Label()
        Me.cod = New System.Windows.Forms.Label()
        Me.des = New System.Windows.Forms.Label()
        Me.col = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.tm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tm.SuspendLayout()
        Me.d1.SuspendLayout()
        CType(Me.jg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.d2.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tm
        '
        Me.tm.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tm.CanCloseTabs = True
        Me.tm.CanMoveTabs = True
        Me.tm.Controls.Add(Me.d1)
        Me.tm.Controls.Add(Me.d2)
        Me.tm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tm.ItemSize = New System.Drawing.Size(0, 30)
        Me.tm.Location = New System.Drawing.Point(8, 107)
        Me.tm.Name = "tm"
        Me.tm.Size = New System.Drawing.Size(1143, 522)
        Me.tm.TabIndex = 6
        Me.tm.TabsSpacing = -1
        Me.tm.TabStyle = C1.Win.C1Command.TabStyleEnum.Rounded
        '
        'd1
        '
        Me.d1.Controls.Add(Me.jg)
        Me.d1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d1.Location = New System.Drawing.Point(1, 33)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(1141, 488)
        Me.d1.TabBackColor = System.Drawing.Color.Yellow
        Me.d1.TabBackColorSelected = System.Drawing.Color.White
        Me.d1.TabForeColor = System.Drawing.Color.Black
        Me.d1.TabForeColorSelected = System.Drawing.Color.Black
        Me.d1.TabIndex = 0
        Me.d1.Text = "Consumo"
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
        Me.jg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.jg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.jg.Location = New System.Drawing.Point(3, 3)
        Me.jg.Name = "jg"
        Me.jg.Rows.DefaultSize = 19
        Me.jg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.jg.Size = New System.Drawing.Size(1135, 482)
        Me.jg.StyleInfo = resources.GetString("jg.StyleInfo")
        Me.jg.TabIndex = 58
        '
        'd2
        '
        Me.d2.Controls.Add(Me.fg)
        Me.d2.Location = New System.Drawing.Point(1, 33)
        Me.d2.Name = "d2"
        Me.d2.Size = New System.Drawing.Size(1141, 488)
        Me.d2.TabBackColor = System.Drawing.Color.LimeGreen
        Me.d2.TabBackColorSelected = System.Drawing.Color.White
        Me.d2.TabIndex = 1
        Me.d2.Text = "FPOS"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cliente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Codigo Tela:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Color Tela:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cli
        '
        Me.cli.BackColor = System.Drawing.Color.White
        Me.cli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cli.Location = New System.Drawing.Point(147, 18)
        Me.cli.Name = "cli"
        Me.cli.Size = New System.Drawing.Size(251, 24)
        Me.cli.TabIndex = 10
        Me.cli.Text = "Label4"
        Me.cli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cod
        '
        Me.cod.BackColor = System.Drawing.Color.White
        Me.cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod.Location = New System.Drawing.Point(147, 44)
        Me.cod.Name = "cod"
        Me.cod.Size = New System.Drawing.Size(105, 24)
        Me.cod.TabIndex = 11
        Me.cod.Text = "Label5"
        Me.cod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'des
        '
        Me.des.BackColor = System.Drawing.Color.White
        Me.des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.des.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.des.Location = New System.Drawing.Point(258, 44)
        Me.des.Name = "des"
        Me.des.Size = New System.Drawing.Size(649, 24)
        Me.des.TabIndex = 12
        Me.des.Text = "Label6"
        Me.des.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'col
        '
        Me.col.BackColor = System.Drawing.Color.White
        Me.col.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.col.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col.Location = New System.Drawing.Point(147, 70)
        Me.col.Name = "col"
        Me.col.Size = New System.Drawing.Size(251, 24)
        Me.col.TabIndex = 13
        Me.col.Text = "Label7"
        Me.col.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowMergingFixed = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(3, 3)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(1135, 482)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 59
        '
        'Plan_telas_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1152, 629)
        Me.Controls.Add(Me.col)
        Me.Controls.Add(Me.des)
        Me.Controls.Add(Me.cod)
        Me.Controls.Add(Me.cli)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tm)
        Me.Name = "Plan_telas_1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plan de Telas (Detalle)"
        CType(Me.tm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tm.ResumeLayout(False)
        Me.d1.ResumeLayout(False)
        CType(Me.jg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.d2.ResumeLayout(False)
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents tm As C1.Win.C1Command.C1DockingTab
    Private WithEvents d1 As C1.Win.C1Command.C1DockingTabPage
    Private WithEvents d2 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cli As System.Windows.Forms.Label
    Friend WithEvents cod As System.Windows.Forms.Label
    Friend WithEvents des As System.Windows.Forms.Label
    Friend WithEvents col As System.Windows.Forms.Label
    Friend WithEvents jg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid

End Class
