Imports C1.Win.C1FlexGrid

Public Class Ingreso_P_Cortadas
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents c As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents p As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents pd1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents c1r As C1.C1Report.C1Report
    Dim lineas As Integer
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents F_corte As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cpos As System.Windows.Forms.TextBox
    Friend WithEvents Fpos As System.Windows.Forms.TextBox
    Friend WithEvents Cortes As System.Windows.Forms.TextBox
    Friend WithEvents Clientes As System.Windows.Forms.TextBox
    Friend WithEvents Estilos As System.Windows.Forms.TextBox
    Friend WithEvents Colores As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingreso_P_Cortadas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Cortes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.p = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.c = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Cpos = New System.Windows.Forms.TextBox()
        Me.Fpos = New System.Windows.Forms.TextBox()
        Me.F_corte = New System.Windows.Forms.DateTimePicker()
        Me.Clientes = New System.Windows.Forms.TextBox()
        Me.Estilos = New System.Windows.Forms.TextBox()
        Me.Colores = New System.Windows.Forms.TextBox()
        Me.pd1 = New System.Drawing.Printing.PrintDocument()
        Me.c1r = New C1.C1Report.C1Report()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.p, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1r, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(16, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Corte"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.Location = New System.Drawing.Point(8, 216)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.ShowButtons = C1.Win.C1FlexGrid.ShowButtonsEnum.Always
        Me.fg.Size = New System.Drawing.Size(944, 432)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(872, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 20
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(336, 49)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(112, 16)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "FPO"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(768, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "F.Corte"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(584, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(176, 16)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Color"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Cortes
        '
        Me.Cortes.BackColor = System.Drawing.Color.White
        Me.Cortes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cortes.ForeColor = System.Drawing.Color.Black
        Me.Cortes.Location = New System.Drawing.Point(16, 23)
        Me.Cortes.MaxLength = 10
        Me.Cortes.Name = "Cortes"
        Me.Cortes.ReadOnly = True
        Me.Cortes.Size = New System.Drawing.Size(112, 24)
        Me.Cortes.TabIndex = 30
        Me.Cortes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(16, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(192, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "CPO"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(456, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Estilo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label43)
        Me.GroupBox1.Controls.Add(Me.Label42)
        Me.GroupBox1.Controls.Add(Me.p)
        Me.GroupBox1.Controls.Add(Me.c)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(944, 130)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tallas"
        '
        'Label43
        '
        Me.Label43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label43.Location = New System.Drawing.Point(830, 68)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(99, 37)
        Me.Label43.TabIndex = 65
        Me.Label43.Text = "Piezas Presupuesto"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label42
        '
        Me.Label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label42.Location = New System.Drawing.Point(830, 16)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(99, 36)
        Me.Label42.TabIndex = 64
        Me.Label42.Text = "Piezas Cortadas"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'p
        '
        Me.p.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.p.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.p.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.p.ColumnInfo = resources.GetString("p.ColumnInfo")
        Me.p.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.p.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.p.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.p.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.p.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.p.Location = New System.Drawing.Point(2, 66)
        Me.p.Name = "p"
        Me.p.Rows.Count = 2
        Me.p.Rows.DefaultSize = 19
        Me.p.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.p.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.p.Size = New System.Drawing.Size(822, 42)
        Me.p.StyleInfo = resources.GetString("p.StyleInfo")
        Me.p.TabIndex = 67
        '
        'c
        '
        Me.c.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.c.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.c.ColumnInfo = resources.GetString("c.ColumnInfo")
        Me.c.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.c.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.c.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.c.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.c.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.c.Location = New System.Drawing.Point(5, 13)
        Me.c.Name = "c"
        Me.c.Rows.Count = 2
        Me.c.Rows.DefaultSize = 19
        Me.c.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.c.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.c.Size = New System.Drawing.Size(817, 42)
        Me.c.StyleInfo = resources.GetString("c.StyleInfo")
        Me.c.TabIndex = 66
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(8, 664)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(536, 16)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Para Seleccionar una Fila en especial  Presione Double_Click."
        '
        'Cpos
        '
        Me.Cpos.BackColor = System.Drawing.Color.White
        Me.Cpos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cpos.Location = New System.Drawing.Point(192, 65)
        Me.Cpos.MaxLength = 15
        Me.Cpos.Name = "Cpos"
        Me.Cpos.ReadOnly = True
        Me.Cpos.Size = New System.Drawing.Size(136, 20)
        Me.Cpos.TabIndex = 48
        Me.Cpos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Fpos
        '
        Me.Fpos.BackColor = System.Drawing.Color.White
        Me.Fpos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fpos.Location = New System.Drawing.Point(336, 65)
        Me.Fpos.MaxLength = 10
        Me.Fpos.Name = "Fpos"
        Me.Fpos.ReadOnly = True
        Me.Fpos.Size = New System.Drawing.Size(112, 20)
        Me.Fpos.TabIndex = 49
        Me.Fpos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F_corte
        '
        Me.F_corte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.F_corte.Location = New System.Drawing.Point(768, 65)
        Me.F_corte.Name = "F_corte"
        Me.F_corte.Size = New System.Drawing.Size(136, 20)
        Me.F_corte.TabIndex = 8
        '
        'Clientes
        '
        Me.Clientes.BackColor = System.Drawing.Color.White
        Me.Clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clientes.Location = New System.Drawing.Point(16, 65)
        Me.Clientes.MaxLength = 15
        Me.Clientes.Name = "Clientes"
        Me.Clientes.ReadOnly = True
        Me.Clientes.Size = New System.Drawing.Size(168, 20)
        Me.Clientes.TabIndex = 47
        Me.Clientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Estilos
        '
        Me.Estilos.BackColor = System.Drawing.Color.White
        Me.Estilos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Estilos.Location = New System.Drawing.Point(456, 65)
        Me.Estilos.MaxLength = 15
        Me.Estilos.Name = "Estilos"
        Me.Estilos.ReadOnly = True
        Me.Estilos.Size = New System.Drawing.Size(120, 20)
        Me.Estilos.TabIndex = 50
        Me.Estilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Colores
        '
        Me.Colores.BackColor = System.Drawing.Color.White
        Me.Colores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colores.Location = New System.Drawing.Point(584, 65)
        Me.Colores.MaxLength = 15
        Me.Colores.Name = "Colores"
        Me.Colores.ReadOnly = True
        Me.Colores.Size = New System.Drawing.Size(176, 20)
        Me.Colores.TabIndex = 51
        Me.Colores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'c1r
        '
        Me.c1r.ReportDefinition = resources.GetString("c1r.ReportDefinition")
        '
        'Ingreso_P_Cortadas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(970, 696)
        Me.Controls.Add(Me.Colores)
        Me.Controls.Add(Me.Estilos)
        Me.Controls.Add(Me.Clientes)
        Me.Controls.Add(Me.Fpos)
        Me.Controls.Add(Me.Cpos)
        Me.Controls.Add(Me.F_corte)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cortes)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ingreso_P_Cortadas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Prendas Cortadas"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.p, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1r, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Ingreso_cortes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setea_grid()
        If fg.Rows.Count > 0 Then
            seleccion(1)
        End If
        fg.Focus()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        llena_grid()
    End Sub

    Private Sub llena_grid()
        ok = False
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String = "SELECT CORTES.*, CORTES_S.*  FROM CORTES LEFT JOIN CORTES_S ON CORTES.CORTE = CORTES_S.CORTE WHERE EXPORTADO <> 'S' AND (SELECT COUNT(PRENDAS) FROM PROD_DIARIA WHERE PROD_DIARIA.CORTE = CORTES.CORTE) = 0 AND (SELECT COUNT(CAJA) FROM CAJAS01 WHERE CAJAS01.CORTE = CORTES.CORTE) = 0 AND LEFT(CORTES.CORTE,4) <> '200-' AND CORTES.TOTAL = 0  ORDER BY CORTES.CORTE DESC "
        'SELECT CORTES.*, CORTES_S.*  FROM CORTES LEFT JOIN CORTES_S ON CORTES.CORTE = CORTES_S.CORTE WHERE EXPORTADO <> 'S' AND (SELECT COUNT(PRENDAS) FROM PROD_DIARIA WHERE PROD_DIARIA.CORTE = CORTES.CORTE) = 0 AND (SELECT COUNT(CAJA) FROM CAJAS01 WHERE CAJAS01.CORTE = CORTES.CORTE) = 0 AND LEFT(CORTES.CORTE,4) <> '200-' AND DATEDIFF(DAY,F_ICORTE,GETDATE()) < 20 ORDER BY CORTES.CORTE DESC "
        'SELECT CORTES.*, CORTES_S.* FROM CORTES LEFT JOIN REQUI ON CORTES.CORTE = REQUI.CORTE LEFT JOIN CORTES_S ON CORTES.CORTE = CORTES_S.CORTE WHERE REQUI IS NULL AND EXPORTADO <> 'S' AND LEFT(CORTES.CORTE,4) <> '200-' ORDER BY CORTES.CORTE DESC "
        llena_tablas(dt, strSQL, cnn)
        lineas = dt.Rows.Count
        fg.Rows.Count = lineas + 1
        lineas = 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("CORTE")
            fg(lineas, 2) = dr("CLIENTE")
            fg(lineas, 3) = dr("CPO")
            fg(lineas, 4) = dr("FPO")
            fg(lineas, 5) = dr("ESTILO")
            fg(lineas, 6) = dr("COLOR")
            fg(lineas, 7) = dr("FCORTE")
            fg(lineas, 8) = dr("TOTAL")
            lineas = lineas + 1
        Next
    End Sub

    Private Sub lee_registro(ByRef ok As Boolean)
        Dim i As Integer
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String = "SELECT CORTES.*, CORTES_S.* , ESCALA FROM CORTES LEFT JOIN CORTES_S ON CORTES.CORTE = CORTES_S.CORTE LEFT JOIN CPO_D ON CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR WHERE EXPORTADO <> 'S' AND LEFT(CORTES.CORTE,4) <> '200-' AND CORTES.CORTE = '" & Cortes.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        If dt.Rows.Count = 0 Then
            For i = 1 To 10
                c.Rows(1).AllowEditing = False
            Next
        Else
            For Each dr In dt.Rows
                ok = True
                llena_Variables(dr)
            Next
        End If
    End Sub

    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OKOnly, var + " NO VALIDO !!!! ")
    End Sub

    Private Sub llena_Variables(ByVal dr As DataRow)
        Dim i As Integer
        Cortes.Text = dr("CORTE")
        Clientes.Text = dr("CLIENTE")
        Cpos.Text = dr("CPO")
        Fpos.Text = dr("FPO")
        Estilos.Text = (dr("ESTILO"))
        Colores.Text = (dr("COLOR"))
        F_corte.Text = CDate(dr("FCORTE"))
        c(1, 1) = dr("XS")
        c(1, 2) = dr("S")
        c(1, 3) = dr("M")
        c(1, 4) = dr("L")
        c(1, 5) = dr("XL")
        c(1, 6) = dr("XL2")
        c(1, 7) = dr("XL3")
        c(1, 8) = dr("XL4")
        c(1, 9) = dr("XL5")
        c(1, 10) = dr("XL6")
        c(1, 11) = dr("TOTAL")
        p(1, 1) = dr(28)
        p(1, 2) = dr(29)
        p(1, 3) = dr(30)
        p(1, 4) = dr(31)
        p(1, 5) = dr(32)
        p(1, 6) = dr(33)
        p(1, 7) = dr(34)
        p(1, 8) = dr(35)
        p(1, 9) = dr(36)
        p(1, 10) = dr(37)
        p(1, 11) = dr(38)
        For i = 1 To 10
            If p(1, i) > 0 Then
                c.Cols(i).AllowEditing = True
            Else
                c.Cols(i).AllowEditing = False
            End If
        Next
        tallas_cortes(Cpos.Text, Estilos.Text, Colores.Text, c, 0, 1)
        tallas_cortes(Cpos.Text, Estilos.Text, Colores.Text, p, 0, 1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        revisa_requi(ok)
        ' ok = True
        If ok Then
            revisa_detalle(ok)
        End If
        If ok Then
            graba_datos()
        End If
    End Sub

    Private Sub revisa_requi(ByRef ok As Boolean)
        Dim dt As New DataTable()
        '  Dim dr As DataRow
        ok = False
        llena_tablas(dt, "SELECT SUM(DESPACHADO) AS DESPACHADO FROM REQUI_D WHERE CORTE = '" & Cortes.Text & "'", cnn)
        ' dr = dt.Rows(0)
        'Try
        '    If dr("DESPACHADO") > 0 Then
        '        ok = False
        '        MsgBox("No se puede cambiar los datos de este Corte.", MsgBoxStyle.Critical, "Corte ya tiene Requisición")
        '    Else
        '        ok = True
        '    End If
        'Catch
        'End Try
        ok = True
    End Sub

    Private Sub revisa_detalle(ByRef ok As Boolean)
        Dim i As Integer
        ok = True
        For i = 1 To 10
            If p(1, i) = 0 And c(1, i) <> 0 Then
                ok = False
            End If
        Next
        If Not ok Then
            MsgBox("Algunas tallas no concuerdan con lo presupuestado !!!", MsgBoxStyle.Critical, "Error en cantidades")
            Exit Sub
        End If
    End Sub

    Private Sub seleccion(ByVal fil As Integer)
        c.Rows.Count = 1
        p.Rows.Count = 1
        c.Rows.Count = 2
        p.Rows.Count = 2
        If fil > 0 And fil < fg.Rows.Count Then
            Cortes.Text = fg(fil, 1)
            lee_registro(EXISTE)
            If Not EXISTE Then
                habilita(False)
            Else
                habilita(True)
            End If
        End If
    End Sub

    Private Sub habilita(ByVal si As Boolean)
        Dim i As Integer
        For i = 1 To 10
            c.Cols(i).AllowEditing = si
        Next
        c.Cols(11).AllowEditing = False
    End Sub

    Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles fg.KeyDown
        If e.KeyCode = Keys.Up Then
            seleccion(fg.Row - 1)
        End If

        If e.KeyCode = Keys.Down Then
            seleccion(fg.Row + 1)
        End If
    End Sub

    Private Sub totales()
        Dim i As Integer
        Dim total As Decimal = 0
        Try
            For i = 1 To 10
                total = total + c(1, i)
            Next
            c(1, 11) = total
        Catch
        End Try
    End Sub
    Private Sub fg_Click_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        fila = fg.RowSel
        seleccion(fila)
    End Sub


    '=================================================================================
    '                        GRABA DATOS
    '=================================================================================
    Private Sub graba_datos()
        Dim strsql As String
        Dim afectados As Integer
        Dim fechac As String = Format(CDate(F_corte.Text), "yyyy-MM-dd")
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            '==================== DIARIO =========================================
            strsql = "UPDATE CORTES SET XS = " & "'" & c(1, 1) & "'" & _
                               " , S = " & "'" & c(1, 2) & "'" & _
                               " , M = " & "'" & c(1, 3) & "'" & _
                               " , L = " & "'" & c(1, 4) & "'" & _
                               " , XL = " & "'" & c(1, 5) & "'" & _
                               " , XL2 = " & "'" & c(1, 6) & "'" & _
                               " , XL3 = " & "'" & c(1, 7) & "'" & _
                               " , XL4 = " & "'" & c(1, 8) & " '" & _
                               " , XL5 = " & "'" & c(1, 9) & "'" & _
                               " , XL6 = " & "'" & c(1, 10) & "'" & _
                               " , TOTAL = " & "'" & c(1, 11) & "'" & _
                               " , FCORTE = " & "'" & fechac & "'" & _
                               " WHERE CORTE = '" & Cortes.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "UPDATE CORTES_S SET ESTADO = 'C' WHERE CORTE = '" & Cortes.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()
            impresion()
            setea_grid()
            seleccion(1)
        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() & _
                                      " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub c_Click(sender As System.Object, e As System.EventArgs) Handles c.AfterRowColChange
        totales()
    End Sub

    '========================== IMPRESION CORTE INGRESADO ======================
    Private Sub impresion()
        Dim constr As String
        Dim empresa As String
        Dim strsql As String = "SELECT CORTES.*,CPO_D.ESCALA,T1,T2,T3,T4,T5,T6,T7,T8,T9,T0 FROM CORTES LEFT JOIN CPO_D ON CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR LEFT JOIN E_TALLAS ON CPO_D.ESCALA = E_TALLAS.ESCALA  WHERE CORTE = '" & Cortes.Text & "'"
        Dim obj As Object
        Try
            obj = New empresas()
            constr = obj.constr
            empresa = obj.nombre
            Cursor = Cursors.WaitCursor
            ' load report
            c1r.Load("C:\TELAS\rep.xml", "CORTE_E")
            c1r.DataSource.ConnectionString = obj.conole
            c1r.DataSource.RecordSource = strsql
            c1r.Fields("Empresa").Text = empresa
            c1r.Render()
        Catch
        Finally
            Cursor = Cursors.Default
        End Try
        pd1 = c1r.Document
        pd1.PrinterSettings.Copies = 1
        pd1.Print()
    End Sub
End Class
