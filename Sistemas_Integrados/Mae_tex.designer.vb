<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mae_tex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mae_tex))
        Me.db = New C1.Win.C1Command.C1DockingTab()
        Me.d1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.tela = New System.Windows.Forms.ComboBox()
        Me.c0 = New System.Windows.Forms.Label()
        Me.e0 = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.g0 = New System.Windows.Forms.Button()
        Me.r0 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.d0 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.h1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.w1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.e1 = New System.Windows.Forms.Button()
        Me.wf = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.g1 = New System.Windows.Forms.Button()
        Me.r1 = New System.Windows.Forms.Button()
        Me.d3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.d2 = New System.Windows.Forms.TextBox()
        Me.t2 = New System.Windows.Forms.ComboBox()
        Me.c2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.e2 = New System.Windows.Forms.Button()
        Me.nf = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.g2 = New System.Windows.Forms.Button()
        Me.r2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.d1.Controls.Add(Me.tela)
        Me.d1.Controls.Add(Me.c0)
        Me.d1.Controls.Add(Me.e0)
        Me.d1.Controls.Add(Me.fg)
        Me.d1.Controls.Add(Me.g0)
        Me.d1.Controls.Add(Me.r0)
        Me.d1.Controls.Add(Me.Label4)
        Me.d1.Controls.Add(Me.d0)
        Me.d1.Controls.Add(Me.Label5)
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
        'tela
        '
        Me.tela.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tela.Location = New System.Drawing.Point(144, 2)
        Me.tela.MaxLength = 20
        Me.tela.Name = "tela"
        Me.tela.Size = New System.Drawing.Size(80, 24)
        Me.tela.TabIndex = 94
        '
        'c0
        '
        Me.c0.BackColor = System.Drawing.Color.White
        Me.c0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.c0.Location = New System.Drawing.Point(230, 0)
        Me.c0.Name = "c0"
        Me.c0.Size = New System.Drawing.Size(586, 26)
        Me.c0.TabIndex = 93
        Me.c0.Text = "Label3"
        Me.c0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'e0
        '
        Me.e0.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.e0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.e0.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e0.ForeColor = System.Drawing.Color.Black
        Me.e0.Image = CType(resources.GetObject("e0.Image"), System.Drawing.Image)
        Me.e0.Location = New System.Drawing.Point(843, 11)
        Me.e0.Name = "e0"
        Me.e0.Size = New System.Drawing.Size(35, 36)
        Me.e0.TabIndex = 5
        Me.e0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.e0.UseVisualStyleBackColor = False
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(7, 60)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 25
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(994, 541)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 92
        '
        'g0
        '
        Me.g0.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.g0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.g0.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g0.ForeColor = System.Drawing.Color.Black
        Me.g0.Image = CType(resources.GetObject("g0.Image"), System.Drawing.Image)
        Me.g0.Location = New System.Drawing.Point(884, 11)
        Me.g0.Name = "g0"
        Me.g0.Size = New System.Drawing.Size(35, 36)
        Me.g0.TabIndex = 3
        Me.g0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.g0.UseVisualStyleBackColor = False
        '
        'r0
        '
        Me.r0.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.r0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.r0.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r0.ForeColor = System.Drawing.Color.Black
        Me.r0.Image = CType(resources.GetObject("r0.Image"), System.Drawing.Image)
        Me.r0.Location = New System.Drawing.Point(924, 11)
        Me.r0.Name = "r0"
        Me.r0.Size = New System.Drawing.Size(35, 36)
        Me.r0.TabIndex = 4
        Me.r0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.r0.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 30)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Tela:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'd0
        '
        Me.d0.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d0.Location = New System.Drawing.Point(144, 30)
        Me.d0.MaxLength = 30
        Me.d0.Name = "d0"
        Me.d0.Size = New System.Drawing.Size(80, 24)
        Me.d0.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(3, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 24)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Porcentaje:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'h1
        '
        Me.h1.CaptionText = "Weight"
        Me.h1.Controls.Add(Me.w1)
        Me.h1.Controls.Add(Me.Label6)
        Me.h1.Controls.Add(Me.e1)
        Me.h1.Controls.Add(Me.wf)
        Me.h1.Controls.Add(Me.g1)
        Me.h1.Controls.Add(Me.r1)
        Me.h1.Location = New System.Drawing.Point(1, 30)
        Me.h1.Name = "h1"
        Me.h1.Size = New System.Drawing.Size(1004, 604)
        Me.h1.TabBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.h1.TabForeColor = System.Drawing.Color.Black
        Me.h1.TabIndex = 1
        Me.h1.Text = "Capacidad Máquinas"
        '
        'w1
        '
        Me.w1.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.w1.Location = New System.Drawing.Point(122, 12)
        Me.w1.MaxLength = 30
        Me.w1.Name = "w1"
        Me.w1.Size = New System.Drawing.Size(80, 24)
        Me.w1.TabIndex = 104
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(3, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 30)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Capacidad:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'e1
        '
        Me.e1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.e1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.e1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e1.ForeColor = System.Drawing.Color.Black
        Me.e1.Image = CType(resources.GetObject("e1.Image"), System.Drawing.Image)
        Me.e1.Location = New System.Drawing.Point(843, 12)
        Me.e1.Name = "e1"
        Me.e1.Size = New System.Drawing.Size(35, 36)
        Me.e1.TabIndex = 97
        Me.e1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.e1.UseVisualStyleBackColor = False
        '
        'wf
        '
        Me.wf.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.wf.AllowEditing = False
        Me.wf.BackColor = System.Drawing.Color.White
        Me.wf.ColumnInfo = resources.GetString("wf.ColumnInfo")
        Me.wf.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.wf.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.wf.ForeColor = System.Drawing.Color.Black
        Me.wf.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.wf.Location = New System.Drawing.Point(7, 61)
        Me.wf.Name = "wf"
        Me.wf.Rows.Count = 1
        Me.wf.Rows.DefaultSize = 25
        Me.wf.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.wf.Size = New System.Drawing.Size(994, 540)
        Me.wf.StyleInfo = resources.GetString("wf.StyleInfo")
        Me.wf.TabIndex = 99
        '
        'g1
        '
        Me.g1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.g1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.g1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g1.ForeColor = System.Drawing.Color.Black
        Me.g1.Image = CType(resources.GetObject("g1.Image"), System.Drawing.Image)
        Me.g1.Location = New System.Drawing.Point(884, 12)
        Me.g1.Name = "g1"
        Me.g1.Size = New System.Drawing.Size(35, 36)
        Me.g1.TabIndex = 95
        Me.g1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.g1.UseVisualStyleBackColor = False
        '
        'r1
        '
        Me.r1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.r1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.r1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r1.ForeColor = System.Drawing.Color.Black
        Me.r1.Image = CType(resources.GetObject("r1.Image"), System.Drawing.Image)
        Me.r1.Location = New System.Drawing.Point(924, 12)
        Me.r1.Name = "r1"
        Me.r1.Size = New System.Drawing.Size(35, 36)
        Me.r1.TabIndex = 96
        Me.r1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.r1.UseVisualStyleBackColor = False
        '
        'd3
        '
        Me.d3.CaptionText = "Batches"
        Me.d3.Controls.Add(Me.d2)
        Me.d3.Controls.Add(Me.t2)
        Me.d3.Controls.Add(Me.c2)
        Me.d3.Controls.Add(Me.Label7)
        Me.d3.Controls.Add(Me.e2)
        Me.d3.Controls.Add(Me.nf)
        Me.d3.Controls.Add(Me.g2)
        Me.d3.Controls.Add(Me.r2)
        Me.d3.Controls.Add(Me.Label2)
        Me.d3.Location = New System.Drawing.Point(1, 30)
        Me.d3.Name = "d3"
        Me.d3.Size = New System.Drawing.Size(1004, 604)
        Me.d3.TabBackColor = System.Drawing.Color.CornflowerBlue
        Me.d3.TabForeColor = System.Drawing.Color.Black
        Me.d3.TabIndex = 2
        Me.d3.Text = "Lbs.x.Batch"
        '
        'd2
        '
        Me.d2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d2.Location = New System.Drawing.Point(145, 31)
        Me.d2.MaxLength = 30
        Me.d2.Name = "d2"
        Me.d2.Size = New System.Drawing.Size(80, 24)
        Me.d2.TabIndex = 103
        '
        't2
        '
        Me.t2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t2.Location = New System.Drawing.Point(145, 5)
        Me.t2.MaxLength = 20
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(80, 24)
        Me.t2.TabIndex = 102
        '
        'c2
        '
        Me.c2.BackColor = System.Drawing.Color.White
        Me.c2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.c2.Location = New System.Drawing.Point(231, 3)
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(586, 26)
        Me.c2.TabIndex = 101
        Me.c2.Text = "Label3"
        Me.c2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(3, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 30)
        Me.Label7.TabIndex = 100
        Me.Label7.Text = "Tela:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'e2
        '
        Me.e2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.e2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.e2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e2.ForeColor = System.Drawing.Color.Black
        Me.e2.Image = CType(resources.GetObject("e2.Image"), System.Drawing.Image)
        Me.e2.Location = New System.Drawing.Point(843, 12)
        Me.e2.Name = "e2"
        Me.e2.Size = New System.Drawing.Size(35, 36)
        Me.e2.TabIndex = 97
        Me.e2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.e2.UseVisualStyleBackColor = False
        '
        'nf
        '
        Me.nf.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.nf.AllowEditing = False
        Me.nf.BackColor = System.Drawing.Color.White
        Me.nf.ColumnInfo = resources.GetString("nf.ColumnInfo")
        Me.nf.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.nf.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.nf.ForeColor = System.Drawing.Color.Black
        Me.nf.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.nf.Location = New System.Drawing.Point(7, 61)
        Me.nf.Name = "nf"
        Me.nf.Rows.Count = 1
        Me.nf.Rows.DefaultSize = 25
        Me.nf.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.nf.Size = New System.Drawing.Size(994, 540)
        Me.nf.StyleInfo = resources.GetString("nf.StyleInfo")
        Me.nf.TabIndex = 99
        '
        'g2
        '
        Me.g2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.g2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.g2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.g2.ForeColor = System.Drawing.Color.Black
        Me.g2.Image = CType(resources.GetObject("g2.Image"), System.Drawing.Image)
        Me.g2.Location = New System.Drawing.Point(884, 12)
        Me.g2.Name = "g2"
        Me.g2.Size = New System.Drawing.Size(35, 36)
        Me.g2.TabIndex = 95
        Me.g2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.g2.UseVisualStyleBackColor = False
        '
        'r2
        '
        Me.r2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.r2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.r2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r2.ForeColor = System.Drawing.Color.Black
        Me.r2.Image = CType(resources.GetObject("r2.Image"), System.Drawing.Image)
        Me.r2.Location = New System.Drawing.Point(924, 12)
        Me.r2.Name = "r2"
        Me.r2.Size = New System.Drawing.Size(35, 36)
        Me.r2.TabIndex = 96
        Me.r2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.r2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 24)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Lbs.x.Batch:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Mae_tex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 635)
        Me.Controls.Add(Me.db)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Mae_tex"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro de Texpasa"
        CType(Me.db, System.ComponentModel.ISupportInitialize).EndInit()
        Me.db.ResumeLayout(False)
        Me.d1.ResumeLayout(False)
        Me.d1.PerformLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.h1.ResumeLayout(False)
        Me.h1.PerformLayout()
        CType(Me.wf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.d3.ResumeLayout(False)
        Me.d3.PerformLayout()
        CType(Me.nf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents db As C1.Win.C1Command.C1DockingTab
    Friend WithEvents d1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents h1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents d3 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents g0 As System.Windows.Forms.Button
    Friend WithEvents d0 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents r0 As System.Windows.Forms.Button
    Friend WithEvents e0 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents e1 As System.Windows.Forms.Button
    Friend WithEvents wf As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents g1 As System.Windows.Forms.Button
    Friend WithEvents r1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents e2 As System.Windows.Forms.Button
    Friend WithEvents nf As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents g2 As System.Windows.Forms.Button
    Friend WithEvents r2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents c0 As System.Windows.Forms.Label
    Friend WithEvents tela As System.Windows.Forms.ComboBox
    Friend WithEvents t2 As System.Windows.Forms.ComboBox
    Friend WithEvents c2 As System.Windows.Forms.Label
    Friend WithEvents d2 As System.Windows.Forms.TextBox
    Friend WithEvents w1 As System.Windows.Forms.TextBox
End Class
