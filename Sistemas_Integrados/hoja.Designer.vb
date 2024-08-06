<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hoja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(hoja))
        Me.Label15 = New System.Windows.Forms.Label()
        Me.va = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.fx = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Sala = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Batch = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Fcorte = New System.Windows.Forms.Label()
        Me.Fprod = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cliente = New System.Windows.Forms.Label()
        Me.fpo = New System.Windows.Forms.Label()
        Me.colores = New System.Windows.Forms.Label()
        Me.seccion = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.estilo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cpo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Ex = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Pr = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Co = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.va, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Ex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Co, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(67, 409)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 16)
        Me.Label15.TabIndex = 83
        Me.Label15.Text = "Vales"
        '
        'va
        '
        Me.va.AllowEditing = False
        Me.va.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.va.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.va.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.va.ColumnInfo = resources.GetString("va.ColumnInfo")
        Me.va.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.va.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.va.ForeColor = System.Drawing.Color.Black
        Me.va.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.va.Location = New System.Drawing.Point(67, 425)
        Me.va.Name = "va"
        Me.va.Rows.DefaultSize = 17
        Me.va.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.va.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.va.Size = New System.Drawing.Size(936, 88)
        Me.va.StyleInfo = resources.GetString("va.StyleInfo")
        Me.va.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.va.TabIndex = 82
        Me.va.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'fx
        '
        Me.fx.AllowEditing = False
        Me.fx.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fx.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fx.BackColor = System.Drawing.Color.White
        Me.fx.ColumnInfo = resources.GetString("fx.ColumnInfo")
        Me.fx.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fx.ForeColor = System.Drawing.Color.Black
        Me.fx.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fx.Location = New System.Drawing.Point(67, 633)
        Me.fx.Name = "fx"
        Me.fx.Rows.DefaultSize = 17
        Me.fx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fx.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fx.Size = New System.Drawing.Size(336, 80)
        Me.fx.StyleInfo = resources.GetString("fx.StyleInfo")
        Me.fx.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fx.TabIndex = 81
        Me.fx.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Sala)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Batch)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Fcorte)
        Me.GroupBox1.Controls.Add(Me.Fprod)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cliente)
        Me.GroupBox1.Controls.Add(Me.fpo)
        Me.GroupBox1.Controls.Add(Me.colores)
        Me.GroupBox1.Controls.Add(Me.seccion)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.estilo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cpo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(936, 152)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        '
        'Sala
        '
        Me.Sala.BackColor = System.Drawing.Color.White
        Me.Sala.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Sala.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sala.ForeColor = System.Drawing.Color.Black
        Me.Sala.Location = New System.Drawing.Point(584, 120)
        Me.Sala.Name = "Sala"
        Me.Sala.Size = New System.Drawing.Size(312, 20)
        Me.Sala.TabIndex = 77
        Me.Sala.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(496, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 20)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "Sala:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Batch
        '
        Me.Batch.BackColor = System.Drawing.Color.White
        Me.Batch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Batch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Batch.ForeColor = System.Drawing.Color.Black
        Me.Batch.Location = New System.Drawing.Point(112, 120)
        Me.Batch.Name = "Batch"
        Me.Batch.Size = New System.Drawing.Size(368, 20)
        Me.Batch.TabIndex = 75
        Me.Batch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 20)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Batch:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Fcorte
        '
        Me.Fcorte.BackColor = System.Drawing.Color.White
        Me.Fcorte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Fcorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fcorte.ForeColor = System.Drawing.Color.Black
        Me.Fcorte.Location = New System.Drawing.Point(584, 72)
        Me.Fcorte.Name = "Fcorte"
        Me.Fcorte.Size = New System.Drawing.Size(144, 20)
        Me.Fcorte.TabIndex = 72
        Me.Fcorte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fprod
        '
        Me.Fprod.BackColor = System.Drawing.Color.White
        Me.Fprod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Fprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fprod.ForeColor = System.Drawing.Color.Black
        Me.Fprod.Location = New System.Drawing.Point(584, 96)
        Me.Fprod.Name = "Fprod"
        Me.Fprod.Size = New System.Drawing.Size(144, 20)
        Me.Fprod.TabIndex = 73
        Me.Fprod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(496, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 20)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "F.Corte:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(496, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 20)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "F.Prod:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 20)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Estilo:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cliente
        '
        Me.cliente.BackColor = System.Drawing.Color.White
        Me.cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.ForeColor = System.Drawing.Color.Black
        Me.cliente.Location = New System.Drawing.Point(112, 72)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(200, 20)
        Me.cliente.TabIndex = 66
        Me.cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fpo
        '
        Me.fpo.BackColor = System.Drawing.Color.White
        Me.fpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fpo.ForeColor = System.Drawing.Color.Black
        Me.fpo.Location = New System.Drawing.Point(112, 48)
        Me.fpo.Name = "fpo"
        Me.fpo.Size = New System.Drawing.Size(200, 20)
        Me.fpo.TabIndex = 65
        Me.fpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colores
        '
        Me.colores.BackColor = System.Drawing.Color.White
        Me.colores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.colores.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colores.ForeColor = System.Drawing.Color.Black
        Me.colores.Location = New System.Drawing.Point(584, 24)
        Me.colores.Name = "colores"
        Me.colores.Size = New System.Drawing.Size(312, 20)
        Me.colores.TabIndex = 68
        Me.colores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'seccion
        '
        Me.seccion.BackColor = System.Drawing.Color.White
        Me.seccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.seccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seccion.ForeColor = System.Drawing.Color.Black
        Me.seccion.Location = New System.Drawing.Point(584, 48)
        Me.seccion.Name = "seccion"
        Me.seccion.Size = New System.Drawing.Size(312, 20)
        Me.seccion.TabIndex = 69
        Me.seccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(496, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 20)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Color:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'estilo
        '
        Me.estilo.BackColor = System.Drawing.Color.White
        Me.estilo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.estilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estilo.ForeColor = System.Drawing.Color.Black
        Me.estilo.Location = New System.Drawing.Point(112, 96)
        Me.estilo.Name = "estilo"
        Me.estilo.Size = New System.Drawing.Size(200, 20)
        Me.estilo.TabIndex = 67
        Me.estilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Cliente"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Fpo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(496, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 20)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Sección:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cpo
        '
        Me.cpo.BackColor = System.Drawing.Color.White
        Me.cpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpo.ForeColor = System.Drawing.Color.Black
        Me.cpo.Location = New System.Drawing.Point(112, 24)
        Me.cpo.Name = "cpo"
        Me.cpo.Size = New System.Drawing.Size(200, 20)
        Me.cpo.TabIndex = 64
        Me.cpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Cpo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(67, 521)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Exportado"
        '
        'Ex
        '
        Me.Ex.AllowEditing = False
        Me.Ex.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Ex.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Ex.BackColor = System.Drawing.Color.White
        Me.Ex.ColumnInfo = resources.GetString("Ex.ColumnInfo")
        Me.Ex.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Ex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ex.ForeColor = System.Drawing.Color.Black
        Me.Ex.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Ex.Location = New System.Drawing.Point(67, 537)
        Me.Ex.Name = "Ex"
        Me.Ex.Rows.DefaultSize = 17
        Me.Ex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Ex.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Ex.Size = New System.Drawing.Size(936, 88)
        Me.Ex.StyleInfo = resources.GetString("Ex.StyleInfo")
        Me.Ex.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Ex.TabIndex = 78
        Me.Ex.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Producido"
        '
        'Pr
        '
        Me.Pr.AllowEditing = False
        Me.Pr.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Pr.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Pr.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Pr.ColumnInfo = resources.GetString("Pr.ColumnInfo")
        Me.Pr.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Pr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pr.ForeColor = System.Drawing.Color.Black
        Me.Pr.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Pr.Location = New System.Drawing.Point(67, 313)
        Me.Pr.Name = "Pr"
        Me.Pr.Rows.DefaultSize = 17
        Me.Pr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Pr.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Pr.Size = New System.Drawing.Size(936, 88)
        Me.Pr.StyleInfo = resources.GetString("Pr.StyleInfo")
        Me.Pr.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Pr.TabIndex = 76
        Me.Pr.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'Co
        '
        Me.Co.AllowEditing = False
        Me.Co.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Co.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Co.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Co.ColumnInfo = resources.GetString("Co.ColumnInfo")
        Me.Co.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Co.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Co.ForeColor = System.Drawing.Color.Black
        Me.Co.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Co.Location = New System.Drawing.Point(67, 233)
        Me.Co.Name = "Co"
        Me.Co.Rows.DefaultSize = 17
        Me.Co.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Co.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Co.Size = New System.Drawing.Size(936, 56)
        Me.Co.StyleInfo = resources.GetString("Co.StyleInfo")
        Me.Co.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Co.TabIndex = 74
        Me.Co.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Cortado"
        '
        'hoja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 770)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.va)
        Me.Controls.Add(Me.fx)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Ex)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Pr)
        Me.Controls.Add(Me.Co)
        Me.Controls.Add(Me.Label3)
        Me.Name = "hoja"
        Me.Text = "hoja"
        CType(Me.va, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Ex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Co, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents va As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fx As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Sala As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Batch As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Fcorte As System.Windows.Forms.Label
    Friend WithEvents Fprod As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cliente As System.Windows.Forms.Label
    Friend WithEvents fpo As System.Windows.Forms.Label
    Friend WithEvents colores As System.Windows.Forms.Label
    Friend WithEvents seccion As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents estilo As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cpo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Ex As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Pr As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Co As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
