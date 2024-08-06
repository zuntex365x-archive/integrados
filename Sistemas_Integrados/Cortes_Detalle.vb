Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Cortes_Detalle
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim si As Integer
    Dim csq As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim te(9) As String
    Dim tp(9) As String
    Private WithEvents tm As C1.Win.C1Command.C1DockingTab
    Private WithEvents d1 As C1.Win.C1Command.C1DockingTabPage
    Private WithEvents d2 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents tl As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents d3 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents mt As C1.Win.C1FlexGrid.C1FlexGrid
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
    Friend WithEvents d4 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents tprod As System.Windows.Forms.Label
    Friend WithEvents sp As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tcortado As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents se1 As System.Windows.Forms.Label
    Friend WithEvents co1 As System.Windows.Forms.Label
    Friend WithEvents es1 As System.Windows.Forms.Label
    Friend WithEvents cp1 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Dim da(9) As Integer
    Dim tpr As New DataTable
    Dim cnn As New SqlClient.SqlConnection
    Dim cor As New DataTable
    Dim ta As String = "|XS|S|M|L|XL|XL2|XL3|XL4|XL5|XL6"
    Dim ts(10) As String
    Friend WithEvents d5 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents cj As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents d6 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents d6_ccolor As System.Windows.Forms.Label
    Friend WithEvents d6_cestilo As System.Windows.Forms.Label
    Friend WithEvents d6_color As System.Windows.Forms.Label
    Friend WithEvents d6_estilo As System.Windows.Forms.Label
    Friend WithEvents d6_cliente As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents pd As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents hoja As Button
    Friend WithEvents exm As Button
    Friend WithEvents Panel1 As Panel
    Dim pp As New DataTable

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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents S1 As System.Windows.Forms.Button
    Friend WithEvents corte As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cortes_Detalle))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.R1 = New System.Windows.Forms.Button()
        Me.S1 = New System.Windows.Forms.Button()
        Me.pd = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.hoja = New System.Windows.Forms.Button()
        Me.exm = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.corte = New System.Windows.Forms.ComboBox()
        Me.tm = New C1.Win.C1Command.C1DockingTab()
        Me.d1 = New C1.Win.C1Command.C1DockingTabPage()
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
        Me.d2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.tl = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.d3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.mt = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.d4 = New C1.Win.C1Command.C1DockingTabPage()
        Me.tprod = New System.Windows.Forms.Label()
        Me.sp = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tcortado = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.se1 = New System.Windows.Forms.Label()
        Me.co1 = New System.Windows.Forms.Label()
        Me.es1 = New System.Windows.Forms.Label()
        Me.cp1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.d5 = New C1.Win.C1Command.C1DockingTabPage()
        Me.cj = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.d6 = New C1.Win.C1Command.C1DockingTabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.d6_ccolor = New System.Windows.Forms.Label()
        Me.d6_cestilo = New System.Windows.Forms.Label()
        Me.d6_color = New System.Windows.Forms.Label()
        Me.d6_estilo = New System.Windows.Forms.Label()
        Me.d6_cliente = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.pd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tm.SuspendLayout()
        Me.d1.SuspendLayout()
        CType(Me.va, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Ex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Co, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.d2.SuspendLayout()
        CType(Me.tl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.d3.SuspendLayout()
        CType(Me.mt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.d4.SuspendLayout()
        CType(Me.sp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.d5.SuspendLayout()
        CType(Me.cj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.d6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(399, 3)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(41, 33)
        Me.R1.TabIndex = 55
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R1.UseVisualStyleBackColor = False
        Me.R1.Visible = False
        '
        'S1
        '
        Me.S1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.S1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.S1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S1.ForeColor = System.Drawing.Color.Black
        Me.S1.Image = CType(resources.GetObject("S1.Image"), System.Drawing.Image)
        Me.S1.Location = New System.Drawing.Point(399, 4)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(41, 32)
        Me.S1.TabIndex = 57
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.S1, "Chequeo de Datos")
        Me.S1.UseVisualStyleBackColor = False
        '
        'pd
        '
        Me.pd.AllowEditing = False
        Me.pd.ColumnInfo = resources.GetString("pd.ColumnInfo")
        Me.pd.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.pd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.pd.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.pd.Location = New System.Drawing.Point(6, 265)
        Me.pd.Name = "pd"
        Me.pd.Rows.DefaultSize = 18
        Me.pd.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.pd.Size = New System.Drawing.Size(1090, 190)
        Me.pd.StyleInfo = resources.GetString("pd.StyleInfo")
        Me.pd.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.pd, "Area de Datos.")
        '
        'hoja
        '
        Me.hoja.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.hoja.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.hoja.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hoja.ForeColor = System.Drawing.Color.Black
        Me.hoja.Image = CType(resources.GetObject("hoja.Image"), System.Drawing.Image)
        Me.hoja.Location = New System.Drawing.Point(1105, 33)
        Me.hoja.Name = "hoja"
        Me.hoja.Size = New System.Drawing.Size(69, 51)
        Me.hoja.TabIndex = 56
        Me.hoja.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.hoja, "Presione este Boton si Desea enviar a Excel  los Datos mostrados en la Pantalla.")
        Me.hoja.UseVisualStyleBackColor = False
        '
        'exm
        '
        Me.exm.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.exm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.exm.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exm.ForeColor = System.Drawing.Color.Black
        Me.exm.Image = CType(resources.GetObject("exm.Image"), System.Drawing.Image)
        Me.exm.Location = New System.Drawing.Point(1110, 30)
        Me.exm.Name = "exm"
        Me.exm.Size = New System.Drawing.Size(68, 51)
        Me.exm.TabIndex = 57
        Me.exm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.exm, "Presione este Boton si Desea enviar a Excel  los Datos mostrados en la Pantalla.")
        Me.exm.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(38, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 31)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Corte"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'corte
        '
        Me.corte.BackColor = System.Drawing.Color.White
        Me.corte.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.corte.ForeColor = System.Drawing.Color.Black
        Me.corte.Location = New System.Drawing.Point(136, 6)
        Me.corte.Name = "corte"
        Me.corte.Size = New System.Drawing.Size(165, 26)
        Me.corte.TabIndex = 0
        '
        'tm
        '
        Me.tm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tm.Controls.Add(Me.d1)
        Me.tm.Controls.Add(Me.d2)
        Me.tm.Controls.Add(Me.d3)
        Me.tm.Controls.Add(Me.d4)
        Me.tm.Controls.Add(Me.d5)
        Me.tm.Controls.Add(Me.d6)
        Me.tm.Dock = System.Windows.Forms.DockStyle.Top
        Me.tm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tm.ItemSize = New System.Drawing.Size(0, 30)
        Me.tm.Location = New System.Drawing.Point(0, 36)
        Me.tm.Name = "tm"
        Me.tm.SelectedIndex = 5
        Me.tm.SelectedTabBold = True
        Me.tm.Size = New System.Drawing.Size(1200, 680)
        Me.tm.TabIndex = 58
        Me.tm.TabsSpacing = -1
        Me.tm.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.tm.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'd1
        '
        Me.d1.Controls.Add(Me.Label15)
        Me.d1.Controls.Add(Me.va)
        Me.d1.Controls.Add(Me.fx)
        Me.d1.Controls.Add(Me.GroupBox1)
        Me.d1.Controls.Add(Me.Label5)
        Me.d1.Controls.Add(Me.Ex)
        Me.d1.Controls.Add(Me.Label4)
        Me.d1.Controls.Add(Me.Pr)
        Me.d1.Controls.Add(Me.Co)
        Me.d1.Controls.Add(Me.Label3)
        Me.d1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d1.ForeColor = System.Drawing.Color.Black
        Me.d1.Location = New System.Drawing.Point(1, 33)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(1198, 646)
        Me.d1.TabBackColor = System.Drawing.Color.Yellow
        Me.d1.TabBackColorSelected = System.Drawing.Color.Yellow
        Me.d1.TabForeColor = System.Drawing.Color.Black
        Me.d1.TabForeColorSelected = System.Drawing.Color.Black
        Me.d1.TabIndex = 0
        Me.d1.Text = "Producción"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(11, 363)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 20)
        Me.Label15.TabIndex = 93
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
        Me.va.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.va.ForeColor = System.Drawing.Color.Black
        Me.va.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.va.Location = New System.Drawing.Point(14, 377)
        Me.va.Name = "va"
        Me.va.Rows.DefaultSize = 19
        Me.va.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.va.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.va.Size = New System.Drawing.Size(1077, 86)
        Me.va.StyleInfo = resources.GetString("va.StyleInfo")
        Me.va.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.va.TabIndex = 92
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
        Me.fx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fx.ForeColor = System.Drawing.Color.Black
        Me.fx.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fx.Location = New System.Drawing.Point(14, 572)
        Me.fx.Name = "fx"
        Me.fx.Rows.DefaultSize = 19
        Me.fx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fx.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fx.Size = New System.Drawing.Size(522, 81)
        Me.fx.StyleInfo = resources.GetString("fx.StyleInfo")
        Me.fx.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fx.TabIndex = 91
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
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(14, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1074, 139)
        Me.GroupBox1.TabIndex = 90
        Me.GroupBox1.TabStop = False
        '
        'Sala
        '
        Me.Sala.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Sala.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Sala.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sala.ForeColor = System.Drawing.Color.Black
        Me.Sala.Location = New System.Drawing.Point(660, 116)
        Me.Sala.Name = "Sala"
        Me.Sala.Size = New System.Drawing.Size(343, 16)
        Me.Sala.TabIndex = 77
        Me.Sala.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.SteelBlue
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(565, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 18)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "Sala:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Batch
        '
        Me.Batch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Batch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Batch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Batch.ForeColor = System.Drawing.Color.Black
        Me.Batch.Location = New System.Drawing.Point(102, 114)
        Me.Batch.Name = "Batch"
        Me.Batch.Size = New System.Drawing.Size(407, 16)
        Me.Batch.TabIndex = 75
        Me.Batch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.SteelBlue
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(6, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 18)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Batch:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Fcorte
        '
        Me.Fcorte.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Fcorte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Fcorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fcorte.ForeColor = System.Drawing.Color.Black
        Me.Fcorte.Location = New System.Drawing.Point(660, 74)
        Me.Fcorte.Name = "Fcorte"
        Me.Fcorte.Size = New System.Drawing.Size(151, 17)
        Me.Fcorte.TabIndex = 72
        Me.Fcorte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Fprod
        '
        Me.Fprod.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Fprod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Fprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fprod.ForeColor = System.Drawing.Color.Black
        Me.Fprod.Location = New System.Drawing.Point(660, 95)
        Me.Fprod.Name = "Fprod"
        Me.Fprod.Size = New System.Drawing.Size(151, 16)
        Me.Fprod.TabIndex = 73
        Me.Fprod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.SteelBlue
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(565, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 19)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "F.Corte:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.SteelBlue
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(565, 95)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 18)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "F.Prod:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.SteelBlue
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(6, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 18)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Estilo:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cliente
        '
        Me.cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.ForeColor = System.Drawing.Color.Black
        Me.cliente.Location = New System.Drawing.Point(102, 66)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(215, 17)
        Me.cliente.TabIndex = 66
        Me.cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fpo
        '
        Me.fpo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.fpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fpo.ForeColor = System.Drawing.Color.Black
        Me.fpo.Location = New System.Drawing.Point(102, 39)
        Me.fpo.Name = "fpo"
        Me.fpo.Size = New System.Drawing.Size(215, 16)
        Me.fpo.TabIndex = 65
        Me.fpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colores
        '
        Me.colores.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.colores.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colores.ForeColor = System.Drawing.Color.Black
        Me.colores.Location = New System.Drawing.Point(660, 11)
        Me.colores.Name = "colores"
        Me.colores.Size = New System.Drawing.Size(343, 17)
        Me.colores.TabIndex = 68
        Me.colores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'seccion
        '
        Me.seccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.seccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.seccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seccion.ForeColor = System.Drawing.Color.Black
        Me.seccion.Location = New System.Drawing.Point(660, 44)
        Me.seccion.Name = "seccion"
        Me.seccion.Size = New System.Drawing.Size(343, 16)
        Me.seccion.TabIndex = 69
        Me.seccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.SteelBlue
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(565, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 19)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Color:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'estilo
        '
        Me.estilo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.estilo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.estilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estilo.ForeColor = System.Drawing.Color.Black
        Me.estilo.Location = New System.Drawing.Point(102, 95)
        Me.estilo.Name = "estilo"
        Me.estilo.Size = New System.Drawing.Size(215, 16)
        Me.estilo.TabIndex = 67
        Me.estilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(6, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 19)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Cliente"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 18)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Fpo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.SteelBlue
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(565, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 18)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Sección:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cpo
        '
        Me.cpo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpo.ForeColor = System.Drawing.Color.Black
        Me.cpo.Location = New System.Drawing.Point(102, 13)
        Me.cpo.Name = "cpo"
        Me.cpo.Size = New System.Drawing.Size(215, 17)
        Me.cpo.TabIndex = 64
        Me.cpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Cpo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(11, 466)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 20)
        Me.Label5.TabIndex = 89
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
        Me.Ex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Ex.ForeColor = System.Drawing.Color.Black
        Me.Ex.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Ex.Location = New System.Drawing.Point(14, 489)
        Me.Ex.Name = "Ex"
        Me.Ex.Rows.DefaultSize = 19
        Me.Ex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Ex.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Ex.Size = New System.Drawing.Size(1077, 87)
        Me.Ex.StyleInfo = resources.GetString("Ex.StyleInfo")
        Me.Ex.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Ex.TabIndex = 88
        Me.Ex.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(11, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 20)
        Me.Label4.TabIndex = 87
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
        Me.Pr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Pr.ForeColor = System.Drawing.Color.Black
        Me.Pr.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Pr.Location = New System.Drawing.Point(14, 256)
        Me.Pr.Name = "Pr"
        Me.Pr.Rows.DefaultSize = 19
        Me.Pr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Pr.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Pr.Size = New System.Drawing.Size(1077, 104)
        Me.Pr.StyleInfo = resources.GetString("Pr.StyleInfo")
        Me.Pr.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Pr.TabIndex = 86
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
        Me.Co.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Co.ForeColor = System.Drawing.Color.Black
        Me.Co.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Co.Location = New System.Drawing.Point(14, 174)
        Me.Co.Name = "Co"
        Me.Co.Rows.DefaultSize = 19
        Me.Co.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Co.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Co.Size = New System.Drawing.Size(1077, 56)
        Me.Co.StyleInfo = resources.GetString("Co.StyleInfo")
        Me.Co.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Co.TabIndex = 84
        Me.Co.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(11, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Cortado"
        '
        'd2
        '
        Me.d2.Controls.Add(Me.hoja)
        Me.d2.Controls.Add(Me.tl)
        Me.d2.Location = New System.Drawing.Point(1, 33)
        Me.d2.Name = "d2"
        Me.d2.Size = New System.Drawing.Size(1198, 646)
        Me.d2.TabBackColor = System.Drawing.Color.DeepSkyBlue
        Me.d2.TabBackColorSelected = System.Drawing.Color.DeepSkyBlue
        Me.d2.TabForeColor = System.Drawing.Color.Black
        Me.d2.TabForeColorSelected = System.Drawing.Color.Black
        Me.d2.TabIndex = 1
        Me.d2.Text = "Tela"
        '
        'tl
        '
        Me.tl.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.tl.AllowEditing = False
        Me.tl.AllowFiltering = True
        Me.tl.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.tl.BackColor = System.Drawing.Color.White
        Me.tl.ColumnInfo = resources.GetString("tl.ColumnInfo")
        Me.tl.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.tl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.tl.ForeColor = System.Drawing.Color.Black
        Me.tl.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.tl.Location = New System.Drawing.Point(0, 4)
        Me.tl.Name = "tl"
        Me.tl.Rows.Count = 1
        Me.tl.Rows.DefaultSize = 19
        Me.tl.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.tl.Size = New System.Drawing.Size(1098, 871)
        Me.tl.StyleInfo = resources.GetString("tl.StyleInfo")
        Me.tl.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.tl.TabIndex = 47
        '
        'd3
        '
        Me.d3.Controls.Add(Me.exm)
        Me.d3.Controls.Add(Me.mt)
        Me.d3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d3.Location = New System.Drawing.Point(1, 33)
        Me.d3.Name = "d3"
        Me.d3.Size = New System.Drawing.Size(1198, 646)
        Me.d3.TabBackColor = System.Drawing.Color.SandyBrown
        Me.d3.TabBackColorSelected = System.Drawing.Color.SandyBrown
        Me.d3.TabForeColor = System.Drawing.Color.Black
        Me.d3.TabForeColorSelected = System.Drawing.Color.Black
        Me.d3.TabIndex = 2
        Me.d3.Text = "Materiales"
        '
        'mt
        '
        Me.mt.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.mt.AllowEditing = False
        Me.mt.AllowFiltering = True
        Me.mt.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.mt.BackColor = System.Drawing.Color.White
        Me.mt.ColumnInfo = resources.GetString("mt.ColumnInfo")
        Me.mt.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.mt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.mt.ForeColor = System.Drawing.Color.Black
        Me.mt.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.mt.Location = New System.Drawing.Point(0, 0)
        Me.mt.Name = "mt"
        Me.mt.Rows.Count = 1
        Me.mt.Rows.DefaultSize = 19
        Me.mt.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.mt.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.mt.Size = New System.Drawing.Size(1096, 885)
        Me.mt.StyleInfo = resources.GetString("mt.StyleInfo")
        Me.mt.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.mt.TabIndex = 48
        '
        'd4
        '
        Me.d4.Controls.Add(Me.tprod)
        Me.d4.Controls.Add(Me.sp)
        Me.d4.Controls.Add(Me.tcortado)
        Me.d4.Controls.Add(Me.fg)
        Me.d4.Controls.Add(Me.se1)
        Me.d4.Controls.Add(Me.co1)
        Me.d4.Controls.Add(Me.es1)
        Me.d4.Controls.Add(Me.cp1)
        Me.d4.Controls.Add(Me.Label19)
        Me.d4.Controls.Add(Me.Label20)
        Me.d4.Controls.Add(Me.Label21)
        Me.d4.Controls.Add(Me.Label22)
        Me.d4.ForeColor = System.Drawing.Color.Black
        Me.d4.Location = New System.Drawing.Point(1, 33)
        Me.d4.Name = "d4"
        Me.d4.Size = New System.Drawing.Size(1198, 646)
        Me.d4.TabBackColor = System.Drawing.Color.GreenYellow
        Me.d4.TabBackColorSelected = System.Drawing.Color.GreenYellow
        Me.d4.TabForeColor = System.Drawing.Color.Black
        Me.d4.TabForeColorSelected = System.Drawing.Color.Black
        Me.d4.TabIndex = 3
        Me.d4.Text = "Scan & Pack"
        '
        'tprod
        '
        Me.tprod.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tprod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tprod.Location = New System.Drawing.Point(848, 584)
        Me.tprod.Name = "tprod"
        Me.tprod.Size = New System.Drawing.Size(215, 31)
        Me.tprod.TabIndex = 126
        Me.tprod.Text = " "
        Me.tprod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'sp
        '
        Me.sp.AllowEditing = False
        Me.sp.AllowFiltering = True
        Me.sp.BackColor = System.Drawing.Color.White
        Me.sp.ColumnInfo = resources.GetString("sp.ColumnInfo")
        Me.sp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.sp.ForeColor = System.Drawing.Color.Black
        Me.sp.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.sp.Location = New System.Drawing.Point(11, 274)
        Me.sp.Name = "sp"
        Me.sp.Rows.DefaultSize = 19
        Me.sp.Size = New System.Drawing.Size(1078, 307)
        Me.sp.StyleInfo = resources.GetString("sp.StyleInfo")
        Me.sp.TabIndex = 125
        '
        'tcortado
        '
        Me.tcortado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tcortado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tcortado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tcortado.Location = New System.Drawing.Point(848, 240)
        Me.tcortado.Name = "tcortado"
        Me.tcortado.Size = New System.Drawing.Size(215, 31)
        Me.tcortado.TabIndex = 124
        Me.tcortado.Text = " "
        Me.tcortado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(11, 140)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(1078, 97)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 123
        '
        'se1
        '
        Me.se1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.se1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.se1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.se1.Location = New System.Drawing.Point(848, 25)
        Me.se1.Name = "se1"
        Me.se1.Size = New System.Drawing.Size(241, 25)
        Me.se1.TabIndex = 122
        Me.se1.Text = " "
        Me.se1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'co1
        '
        Me.co1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.co1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.co1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.co1.Location = New System.Drawing.Point(209, 101)
        Me.co1.Name = "co1"
        Me.co1.Size = New System.Drawing.Size(334, 23)
        Me.co1.TabIndex = 121
        Me.co1.Text = " "
        Me.co1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'es1
        '
        Me.es1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.es1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.es1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.es1.Location = New System.Drawing.Point(209, 64)
        Me.es1.Name = "es1"
        Me.es1.Size = New System.Drawing.Size(334, 26)
        Me.es1.TabIndex = 120
        Me.es1.Text = " "
        Me.es1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cp1
        '
        Me.cp1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cp1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cp1.Location = New System.Drawing.Point(209, 25)
        Me.cp1.Name = "cp1"
        Me.cp1.Size = New System.Drawing.Size(334, 25)
        Me.cp1.TabIndex = 119
        Me.cp1.Text = " "
        Me.cp1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.SteelBlue
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(627, 25)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(198, 25)
        Me.Label19.TabIndex = 118
        Me.Label19.Text = "Seccion:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.SteelBlue
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(17, 101)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(167, 23)
        Me.Label20.TabIndex = 117
        Me.Label20.Text = "Color:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.SteelBlue
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(17, 64)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(167, 26)
        Me.Label21.TabIndex = 116
        Me.Label21.Text = "Estilo:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.SteelBlue
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(17, 25)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(167, 25)
        Me.Label22.TabIndex = 115
        Me.Label22.Text = "CPO:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'd5
        '
        Me.d5.Controls.Add(Me.cj)
        Me.d5.Location = New System.Drawing.Point(1, 33)
        Me.d5.Name = "d5"
        Me.d5.Size = New System.Drawing.Size(1198, 646)
        Me.d5.TabBackColor = System.Drawing.Color.Khaki
        Me.d5.TabBackColorSelected = System.Drawing.Color.Khaki
        Me.d5.TabForeColor = System.Drawing.Color.Black
        Me.d5.TabForeColorSelected = System.Drawing.Color.Black
        Me.d5.TabIndex = 4
        Me.d5.Text = "Cajas"
        '
        'cj
        '
        Me.cj.AllowEditing = False
        Me.cj.AllowFiltering = True
        Me.cj.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cj.ColumnInfo = resources.GetString("cj.ColumnInfo")
        Me.cj.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cj.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.cj.Location = New System.Drawing.Point(15, 23)
        Me.cj.Name = "cj"
        Me.cj.Rows.DefaultSize = 19
        Me.cj.Size = New System.Drawing.Size(1177, 445)
        Me.cj.StyleInfo = resources.GetString("cj.StyleInfo")
        Me.cj.TabIndex = 126
        '
        'd6
        '
        Me.d6.BackColor = System.Drawing.SystemColors.Control
        Me.d6.Controls.Add(Me.pd)
        Me.d6.Controls.Add(Me.GroupBox2)
        Me.d6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d6.ForeColor = System.Drawing.Color.Black
        Me.d6.Location = New System.Drawing.Point(1, 33)
        Me.d6.Name = "d6"
        Me.d6.Size = New System.Drawing.Size(1198, 646)
        Me.d6.TabBackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.d6.TabBackColorSelected = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.d6.TabForeColor = System.Drawing.Color.Black
        Me.d6.TabForeColorSelected = System.Drawing.Color.Black
        Me.d6.TabIndex = 5
        Me.d6.Text = "Detalle Estilo"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.d6_ccolor)
        Me.GroupBox2.Controls.Add(Me.d6_cestilo)
        Me.GroupBox2.Controls.Add(Me.d6_color)
        Me.GroupBox2.Controls.Add(Me.d6_estilo)
        Me.GroupBox2.Controls.Add(Me.d6_cliente)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1082, 253)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        '
        'd6_ccolor
        '
        Me.d6_ccolor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.d6_ccolor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.d6_ccolor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.d6_ccolor.Location = New System.Drawing.Point(197, 199)
        Me.d6_ccolor.Name = "d6_ccolor"
        Me.d6_ccolor.Size = New System.Drawing.Size(388, 35)
        Me.d6_ccolor.TabIndex = 124
        Me.d6_ccolor.Text = " "
        Me.d6_ccolor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'd6_cestilo
        '
        Me.d6_cestilo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.d6_cestilo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.d6_cestilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.d6_cestilo.Location = New System.Drawing.Point(197, 160)
        Me.d6_cestilo.Name = "d6_cestilo"
        Me.d6_cestilo.Size = New System.Drawing.Size(388, 35)
        Me.d6_cestilo.TabIndex = 123
        Me.d6_cestilo.Text = " "
        Me.d6_cestilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'd6_color
        '
        Me.d6_color.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.d6_color.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.d6_color.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.d6_color.Location = New System.Drawing.Point(197, 92)
        Me.d6_color.Name = "d6_color"
        Me.d6_color.Size = New System.Drawing.Size(388, 36)
        Me.d6_color.TabIndex = 122
        Me.d6_color.Text = " "
        Me.d6_color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'd6_estilo
        '
        Me.d6_estilo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.d6_estilo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.d6_estilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.d6_estilo.Location = New System.Drawing.Point(197, 56)
        Me.d6_estilo.Name = "d6_estilo"
        Me.d6_estilo.Size = New System.Drawing.Size(388, 35)
        Me.d6_estilo.TabIndex = 121
        Me.d6_estilo.Text = " "
        Me.d6_estilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'd6_cliente
        '
        Me.d6_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.d6_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.d6_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.d6_cliente.Location = New System.Drawing.Point(197, 18)
        Me.d6_cliente.Name = "d6_cliente"
        Me.d6_cliente.Size = New System.Drawing.Size(388, 36)
        Me.d6_cliente.TabIndex = 120
        Me.d6_cliente.Text = " "
        Me.d6_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(18, 161)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(172, 35)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Estilo Cliente:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.SteelBlue
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(18, 199)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(172, 35)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "Color Cliente:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.SteelBlue
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(18, 20)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(172, 36)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "Cliente:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.SteelBlue
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(18, 56)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(172, 35)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "Estilo:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.SteelBlue
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(18, 92)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(172, 36)
        Me.Label25.TabIndex = 47
        Me.Label25.Text = "Color:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.corte)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.S1)
        Me.Panel1.Controls.Add(Me.R1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 36)
        Me.Panel1.TabIndex = 59
        '
        'Cortes_Detalle
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 738)
        Me.Controls.Add(Me.tm)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cortes_Detalle"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Datos del Corte"
        CType(Me.pd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tm.ResumeLayout(False)
        Me.d1.ResumeLayout(False)
        CType(Me.va, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Ex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Co, System.ComponentModel.ISupportInitialize).EndInit()
        Me.d2.ResumeLayout(False)
        CType(Me.tl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.d3.ResumeLayout(False)
        CType(Me.mt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.d4.ResumeLayout(False)
        CType(Me.sp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.d5.ResumeLayout(False)
        CType(Me.cj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.d6.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub ESTADO_cPO(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler corte.KeyPress, AddressOf keypressed1
        Dim fecha As Date = Today
        fecha = DateAdd(DateInterval.Year, -4, Today)
        te = Split("XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6", ","c)
        tp = Split("P0,P1,P2,P3,P4,P5,P6,P7,P8,P9", ","c)
        llena_combos(corte, "SELECT * FROM CORTES WHERE FCORTE > '" & Format(fecha, "yyyy-MM-dd") & "' ORDER BY CORTE", "CORTE")
        limpia_variables()
    End Sub

    Private Sub S1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S1.Click
        If corte.Text <> "" Then
            ok = True
            llena_co(ok)
            If ok Then
                tm.SelectedIndex = 0
                procesa()
                S1.Visible = False
                R1.Visible = True
                tm.Enabled = True
            Else
                MsgBox("CORTE no Existe !!!!", MsgBoxStyle.Critical, "Por favor Verifique !!!")
                limpia_variables()
            End If
        End If
    End Sub

    Private Sub procesa()
        deshabilita()
        llena_pr()
        llena_va()
        llena_EX()
        llena_fx()
        subtotales()
    End Sub
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(corte.Text) <> "" Then
                S1.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub deshabilita()
        corte.Enabled = False
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        limpia_variables()
    End Sub

    Private Sub limpia_variables()
        corte.Enabled = True
        cpo.Text = ""
        fpo.Text = ""
        cliente.Text = ""
        estilo.Text = ""
        colores.Text = ""
        seccion.Text = ""
        Fcorte.Text = ""
        Fprod.Text = ""
        Batch.Text = ""
        Sala.Text = ""
        S1.Visible = True
        R1.Visible = False
        setea_co()
        setea_pr()
        setea_va()
        setea_EX()
        setea_fx()
        mt.Rows.Count = 1
        tl.Rows.Count = 1
        tm.SelectedIndex = 0
        tm.Enabled = False


        corte.Focus()
    End Sub

    '=============================================== CORTE ================================================
    Private Sub setea_co()
        Dim index As Integer
        Co.Clear()
        Co.Rows.Count = 1
        Co.Cols.Count = 13
        Co.Cols(0).Width = 0
        Co.Rows(0).Height = 19
        Dim c As Column = Co.Cols(1)
        Co.Cols(1).Name = "F.CORTE"
        Co.Cols(2).Name = "XS"
        Co.Cols(3).Name = "S"
        Co.Cols(4).Name = "M"
        Co.Cols(5).Name = "L"
        Co.Cols(6).Name = "XL"
        Co.Cols(7).Name = "2XL"
        Co.Cols(8).Name = "3XL"
        Co.Cols(9).Name = "4XL"
        Co.Cols(10).Name = "5XL"
        Co.Cols(11).Name = "6XL"
        Co.Cols(12).Name = "TOT."
        For index = 1 To Co.Cols.Count - 1
            Co.Cols(index).Width = 120
            Co(0, index) = Co.Cols(index).Name
            If index > 1 Then
                Co.Cols(index).DataType = GetType(Integer)
                Co.Cols(index).Format = "######0"
                Co.Cols(index).Width = 70
                Co.Cols(index).TextAlign = TextAlignEnum.RightCenter
                Co.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
    End Sub

    Private Sub llena_co(ByRef OK As Boolean)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim i As Integer
        Dim dato As String
        Dim total As Integer
        Dim strSQL As String = "SELECT CORTES.*, SALA FROM CORTES LEFT JOIN CORTES_S ON CORTES.CORTE = CORTES_S.CORTE WHERE CORTES.CORTE = '" & corte.Text & "' ORDER BY FCORTE"
        OK = False
        llena_tablas(dt, strSQL, csq)
        For Each dr In dt.Rows
            OK = True
            lineas = Co.Rows.Count
            Co.Rows.Count = Co.Rows.Count + 1
            total = 0
            cpo.Text = dr("CPO")
            fpo.Text = dr("FPO")
            cliente.Text = dr("CLIENTE")
            estilo.Text = dr("ESTILO")
            colores.Text = dr("COLOR")
            seccion.Text = dr("SECCION")
            Try
                Batch.Text = dr("BATCH")
            Catch
            End Try
            Co(lineas, 1) = dr("FCORTE")
            For i = 0 To 9
                dato = te(i)
                Co(lineas, i + 2) = dr(dato)
                total = total + Co(lineas, i + 2)
            Next
            Co(lineas, 12) = total
            Fcorte.Text = Format(dr("FCORTE"), "dd/MMM/yyyy")
            Fprod.Text = Format(dr("FPROD"), "dd/MMM/yyyy")
            Try
                Sala.Text = dr("SALA")
            Catch
                Sala.Text = ""
            End Try
        Next
        tallas_cortes(cpo.Text, estilo.Text, colores.Text, Co, 0, 2)
        tallas_cortes(cpo.Text, estilo.Text, colores.Text, va, 0, 2)
        tallas_cortes(cpo.Text, estilo.Text, colores.Text, Pr, 0, 2)
        tallas_cortes(cpo.Text, estilo.Text, colores.Text, Ex, 0, 2)
    End Sub
    '=============================================== PRODUCCION  ================================================

    Private Sub setea_pr()
        Dim index As Integer
        Pr.Clear()
        Pr.Rows.Count = 1
        Pr.Cols.Count = 13
        Pr.Cols(0).Width = 0
        Pr.Rows(0).Height = 19
        Dim c As Column = Co.Cols(1)
        Pr.Cols(1).Name = "TIPO"
        Pr.Cols(2).Name = "XS"
        Pr.Cols(3).Name = "S"
        Pr.Cols(4).Name = "M"
        Pr.Cols(5).Name = "L"
        Pr.Cols(6).Name = "XL"
        Pr.Cols(7).Name = "2XL"
        Pr.Cols(8).Name = "3XL"
        Pr.Cols(9).Name = "4XL"
        Pr.Cols(10).Name = "5XL"
        Pr.Cols(11).Name = "6XL"
        Pr.Cols(12).Name = "TOT."
        For index = 1 To Pr.Cols.Count - 1
            Pr.Cols(index).Width = 120
            Pr(0, index) = Pr.Cols(index).Name
            If index > 1 Then
                Pr.Cols(index).DataType = GetType(Integer)
                Pr.Cols(index).Format = "######0"
                Pr.Cols(index).Width = 70
                Pr.Cols(index).TextAlign = TextAlignEnum.RightCenter
                Pr.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
        Pr.Cols(1).Width = 120
    End Sub

    Private Sub llena_pr()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim i As Integer
        Dim dato As String
        Dim strSQL As String = "SELECT * FROM CORTES_P WHERE CORTE = '" & corte.Text & "'"
        llena_tablas(dt, strSQL, csq)
        For Each dr In dt.Rows
            lineas = Pr.Rows.Count
            Pr.Rows.Count = Pr.Rows.Count + 2
            Pr(1, 1) = "PRIMERAS"
            Pr(2, 1) = "SEGUNDAS"
            For i = 0 To 9
                dato = "P" + CStr(i)
                Pr(lineas, i + 2) = Pr(lineas, i + 2) + dr(dato)
                Pr(lineas, 12) = Pr(lineas, 12) + Pr(lineas, i + 2)
                dato = "S" + CStr(i)
                Pr(lineas + 1, i + 2) = Pr(lineas + 1, i + 2) + dr(dato)
                Pr(lineas + 1, 12) = Pr(lineas + 1, 12) + Pr(lineas + 1, i + 2)
            Next
        Next
        If dt.Rows.Count = 0 Then
            Fprod.Text = ""
        End If
    End Sub

    '=============================================== VALES  ================================================

    Private Sub setea_va()
        Dim index As Integer
        va.Clear()
        va.Rows.Count = 1
        va.Cols.Count = 13
        va.Cols(0).Width = 0
        'va.Rows(0).Height = 19
        Dim c As Column = Co.Cols(1)
        va.Cols(1).Name = "TIPO"
        va.Cols(2).Name = "XS"
        va.Cols(3).Name = "S"
        va.Cols(4).Name = "M"
        va.Cols(5).Name = "L"
        va.Cols(6).Name = "XL"
        va.Cols(7).Name = "2XL"
        va.Cols(8).Name = "3XL"
        va.Cols(9).Name = "4XL"
        va.Cols(10).Name = "5XL"
        va.Cols(11).Name = "6XL"
        va.Cols(12).Name = "TOT."
        For index = 1 To va.Cols.Count - 1
            va.Cols(index).Width = 120
            va(0, index) = va.Cols(index).Name
            If index > 1 Then
                va.Cols(index).DataType = GetType(Integer)
                va.Cols(index).Format = "######0"
                va.Cols(index).Width = 70
                va.Cols(index).TextAlign = TextAlignEnum.RightCenter
                va.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
        va.Cols(1).Width = 120
    End Sub

    Private Sub llena_va()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim i As Integer
        Dim dato As String
        Dim strSQL As String = "SELECT * FROM CORTES_V WHERE CORTE = '" & corte.Text & "'"
        llena_tablas(dt, strSQL, csq)
        lineas = va.Rows.Count
        va.Rows.Count = va.Rows.Count + 2
        va(1, 1) = "PRIMERAS"
        va(2, 1) = "SEGUNDAS"
        For Each dr In dt.Rows
            For i = 0 To 9
                dato = "P" + CStr(i)
                va(lineas, i + 2) = va(lineas, i + 2) + dr(dato)
                va(lineas, 12) = va(lineas, 12) + va(lineas, i + 2)
                dato = "S" + CStr(i)
                va(lineas + 1, i + 2) = va(lineas + 1, i + 2) + dr(dato)
                va(lineas + 1, 12) = va(lineas + 1, 12) + va(lineas + 1, i + 2)
            Next
        Next

    End Sub


    '=============================================== EXPORTACION  ================================================

    Private Sub setea_EX()
        Dim index As Integer
        Ex.Clear()
        Ex.Rows.Count = 1
        Ex.Cols.Count = 13
        Ex.Cols(0).Width = 0
        Ex.Rows(0).Height = 19
        Dim c As Column = Co.Cols(1)
        Ex.Cols(1).Name = "TIPO"
        Ex.Cols(2).Name = "XS"
        Ex.Cols(3).Name = "S"
        Ex.Cols(4).Name = "M"
        Ex.Cols(5).Name = "L"
        Ex.Cols(6).Name = "XL"
        Ex.Cols(7).Name = "2XL"
        Ex.Cols(8).Name = "3XL"
        Ex.Cols(9).Name = "4XL"
        Ex.Cols(10).Name = "5XL"
        Ex.Cols(11).Name = "6XL"
        Ex.Cols(12).Name = "TOT."
        For index = 1 To Ex.Cols.Count - 1
            Ex.Cols(index).Width = 120
            Ex(0, index) = Ex.Cols(index).Name
            If index > 1 Then
                Ex.Cols(index).DataType = GetType(Integer)
                Ex.Cols(index).Format = "######0"
                Ex.Cols(index).Width = 70
                Ex.Cols(index).TextAlign = TextAlignEnum.RightCenter
                Ex.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
    End Sub

    Private Sub llena_EX()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim i As Integer
        Dim dato As String
        lineas = 1
        Dim strSQL As String = "SELECT * FROM CORTES_E  WHERE CORTE IN ('" & corte.Text & "','ST-" & corte.Text & "')"
        llena_tablas(dt, strSQL, csq)
        For Each dr In dt.Rows
            Ex.Rows.Count = 3
            Ex(1, 1) = "PRIMERAS"
            Ex(2, 1) = "SEGUNDAS"
            For i = 0 To 9
                dato = "P" + CStr(i)
                Ex(lineas, i + 2) = Ex(lineas, i + 2) + dr(dato)
                Ex(lineas, 12) = Ex(lineas, 12) + dr(dato)
                dato = "S" + CStr(i)
                Ex(lineas + 1, i + 2) = Ex(lineas + 1, i + 2) + dr(dato)
                Ex(lineas + 1, 12) = Ex(lineas + 1, 12) + dr(dato)
            Next
        Next
    End Sub

    Private Sub subtotales()
        Dim i As Integer
        For i = 2 To 12
            Pr.Subtotal(AggregateEnum.Sum, 0, 0, i, "Gran Total -->")
            va.Subtotal(AggregateEnum.Sum, 0, 0, i, "Gran Total -->")
            Ex.Subtotal(AggregateEnum.Sum, 0, 0, i, "Gran Total -->")
        Next
    End Sub

    Private Sub setea_fx()
        Dim index As Integer
        fx.Clear()
        fx.Rows.Count = 1
        fx.Cols.Count = 4
        fx.Cols(0).Width = 0
        fx.Rows(0).Height = 19
        Dim c As Column = Co.Cols(1)
        fx.Cols(1).Name = "FECHA"
        fx.Cols(2).Name = "EMBARQUE"
        fx.Cols(3).Name = "PRENDAS"
        For index = 1 To fx.Cols.Count - 1
            fx.Cols(index).Width = 120
            fx(0, index) = fx.Cols(index).Name
            If index > 2 Then
                fx.Cols(index).DataType = GetType(Integer)
                fx.Cols(index).Format = "######0"
                fx.Cols(index).Width = 70
                fx.Cols(index).TextAlign = TextAlignEnum.RightCenter
                fx.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
    End Sub

    Private Sub llena_fx()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String = "SELECT EMBARQUE,SUM(PRENDAS) AS PRENDAS ,FECHA FROM EMBARQUES WHERE CORTE IN ('" & corte.Text & "','ST-" & corte.Text & "') GROUP BY EMBARQUE,FECHA ORDER BY FECHA"
        llena_tablas(dt, strSQL, csq)
        For Each dr In dt.Rows
            lineas = fx.Rows.Count
            fx.Rows.Count = fx.Rows.Count + 1
            fx(lineas, 1) = dr("FECHA")
            fx(lineas, 2) = dr("EMBARQUE")
            fx(lineas, 3) = dr("PRENDAS")
        Next
    End Sub
    Private Sub corte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles corte.KeyPress
        AutoCompletar(corte, e)
    End Sub


    Private Sub T1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm.SelectedIndexChanged
        Select Case tm.SelectedIndex
            Case 0
                costura()
            Case 1
                telas()
            Case 2
                materiales()
            Case 3
                limpia_variables_sc()
            Case 4
                setea_grid_cj()
            Case 5
                setea_grid_pd()
        End Select
    End Sub
    Private Sub costura()
        'ok = True
        'llena_co(ok)
    End Sub

    Private Sub telas()
        Dim f As Integer
        Dim l As Integer = 1
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim strsql As String = "SELECT * FROM DMOVTO LEFT JOIN ROLLOS ON DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO WHERE CORTE = '" & corte.Text & "' ORDER BY FECHA"
        llena_tablas(dt, strsql, csq)
        tl.Rows.Count = dt.Rows.Count + 1
        tl.Rows(0).Height = 19
        For Each dr In dt.Rows
            tl(l, 1) = dr("FECHA")
            If dr("TMOVTO") > 3 Then
                tl(l, 2) = "SALIDA"
                f = 1
            Else
                tl(l, 2) = "ENTRADA"
                f = -1
            End If
            tl(l, 3) = dr("BATCH")
            tl(l, 4) = dr("ROLLO")
            tl(l, 5) = dr("KNIT")
            tl(l, 6) = dr("COLOR")
            tl(l, 7) = dr("YARDAS") * f
            tl(l, 8) = dr("LIBRAS") * f
            l = l + 1
        Next
        subtotal_tl()
    End Sub

    Private Sub materiales()
        Dim l As Integer = 1
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim f As Integer = -1
        Dim strsql As String = "SELECT * FROM D_MATERIAL LEFT JOIN MATERIALES ON D_MATERIAL.CODIGO = MATERIALES.CODIGO WHERE CORTE = '" & corte.Text & "' ORDER BY FECHA"
        llena_tablas(dt, strsql, csq)
        mt.Rows.Count = dt.Rows.Count + 1
        mt.Rows(0).Height = 19
        For Each dr In dt.Rows
            mt(l, 1) = dr("FECHA")
            If dr("T_MOVTO") > 3 Then
                mt(l, 2) = "SALIDA"
            Else
                mt(l, 2) = "ENTRADA"
            End If
            mt(l, 3) = dr("CODIGO")
            mt(l, 4) = dr("DESCRIPCION")
            mt(l, 5) = dr("UNIDADES") * f
            l = l + 1
        Next
        subtotal_mt()
    End Sub

    Private Sub tl_Click(sender As System.Object, e As System.EventArgs) Handles tl.AfterFilter
        subtotal_tl()
    End Sub

    Private Sub mt_Click(sender As System.Object, e As System.EventArgs) Handles mt.AfterFilter
        subtotal_mt()
    End Sub

    Private Sub subtotal_tl()
        tl.Subtotal(AggregateEnum.Sum, 0, 0, 7, "Gran Total -->")
        tl.Subtotal(AggregateEnum.Sum, 0, 0, 8, "Gran Total -->")
    End Sub

    Private Sub subtotal_mt()
        mt.Subtotal(AggregateEnum.Sum, 0, 0, 5, "Gran Total -->")
    End Sub

    ' =========================================================================================
    ' ===
    ' ===              SCAN & PACK
    ' ===
    ' =========================================================================================

    Private Sub limpia_variables_sc()
        tpr = New DataTable
        cnn = New SqlClient.SqlConnection
        ts = ta.Split("|")
        llena_tablas(tpr, "SELECT * FROM TIPOS_PRENDA", cnn)
        setea_grid_sc()
        cp1.Text = ""
        es1.Text = ""
        co1.Text = ""
        ' seccion.Text = ""
        tcortado.Text = "0"
        tprod.Text = "0"
        llena_corte_sp()
        llena_produccion_sp()
    End Sub
    Private Sub setea_grid_sc()
        Dim I As Integer
        Dim dr As DataRow
        Dim l As Integer = 1
        fg.Rows.Count = 2
        fg.Rows.Fixed = 1
        fg.Rows(0).Height = 19
        fg.Rows(1).Height = 19
        sp.Rows.Count = 1
        sp.Rows(0).Height = 19
        sp.Rows.Count = tpr.Rows.Count + 2
        For I = 0 To tpr.Rows.Count - 1
            dr = tpr.Rows(I)
            sp(I + 1, 0) = dr("CODIGO")
            sp(I + 1, 1) = dr("TIPO_PRENDA")
            l = l + 1
        Next
        sp(l, 1) = "Vales"
    End Sub
    Private Sub llena_corte_sp()
        Dim i As Integer
        Dim dr As DataRow
        Dim dj As DataRow = Nothing
        Dim escala As String = ""
        llena_tablas(cor, "SELECT CORTES.*,CPO_D.ESCALA, E_TALLAS.* FROM CORTES LEFT JOIN CPO_D ON CPO_D.CPO = CORTES.CPO AND CPO_D.ESTILO = CORTES.ESTILO AND CPO_D.COLOR = CORTES.COLOR LEFT JOIN E_TALLAS ON CPO_D.ESCALA = E_TALLAS.ESCALA WHERE CORTE = '" & corte.Text & "'", cnn)
        If Co.Rows.Count > 0 Then
            dr = cor.Rows(0)
            dj = dr
            cp1.Text = dr("CPO")
            es1.Text = dr("ESTILO")
            co1.Text = dr("COLOR")
            se1.Text = dr("SECCION")
            tcortado.Text = dr("TOTAL")
            escala = dr("ESCALA")
            fg(1, 1) = "Cortado"
        End If
        For i = 1 To 10
            If escala = "00" Then
                dj(i + 24) = ts(i)
            End If
            fg(0, i + 1) = dj(i + 24)
            fg(1, i + 1) = dj(i + 5)
            sp(0, i + 1) = dj(i + 24)
        Next
    End Sub

    Private Sub llena_produccion_sp()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim t As Integer = 0
        Dim f As Integer = 0
        Dim c As Integer
        Dim u As Integer
        Dim strsql As String = "SELECT * FROM CAJAS01 WHERE  ESTADO != 'L' AND CORTE = '" & corte.Text & "' AND CAJA IN (SELECT CAJA FROM CAJAS04 WHERE CORTE = '" & corte.Text & "')"
        llena_tablas(pp, strsql, cnn)
        For Each dr In pp.Rows
            f = dr("TIPO_SEG") + 1
            c = dr("ORDEN") + 2
            u = dr("UNIDADES")
            sp(f, c) = sp(f, c) + u
            t = t + u
        Next
        f = tpr.Rows.Count + 1
        strsql = "SELECT * FROM CAJAS05 WHERE CORTE = '" & corte.Text & "'"
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            c = dr("ORDEN") + 2
            u = dr("UNIDADES")
            sp(f, c) = sp(f, c) + u
            t = t + u
        Next
        tprod.Text = t
    End Sub



    ' =========================================================================================
    ' ===
    ' ===              CAJAS
    ' ===
    ' =========================================================================================
    Private Sub setea_grid_cj()
        cj.Rows.Count = 1
        cj.Rows(0).Height = 19
        llena_produccion_cj()
    End Sub

    Private Sub llena_produccion_cj()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim strsql As String = "SELECT CAJAS01.*,(SELECT  TOP 1 CONVERT (date,CAJAS04.FECHA)FROM CAJAS04 WHERE CAJAS04.CAJA = CAJAS01.CAJA) AS FECHAP FROM CAJAS01 WHERE CORTE = '" & corte.Text & "' AND CAJA IN (SELECT CAJA FROM CAJAS04 WHERE CORTE = '" & corte.Text & "')"
        llena_tablas(dt, strsql, cnn)
        cj.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            cj(l, 1) = dr("FECHAP")
            cj(l, 2) = dr("CAJA")
            cj(l, 3) = dr("TALLA")
            cj(l, 4) = dr("TIPO")
            cj(l, 5) = dr("UNIDADES")
            l = l + 1
        Next
        cj.Sort(SortFlags.Ascending, 1)
        cj.Subtotal(AggregateEnum.Sum, 1, 1, 5, "Gran Total -->")
        cj.Subtotal(AggregateEnum.Sum, -1, -1, 5, "Gran Total -->")
    End Sub

    ' =========================================================================================
    ' ===
    ' ===              DETALLE ESTILO
    ' ===
    ' =========================================================================================
    Private Sub setea_grid_pd()
        pd.Rows.Count = 1
        pd.Rows(0).Height = 19
        llena_detalle_est()
    End Sub

    Private Sub llena_detalle_est()
        Dim l As Integer = 1
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim strsql As String = "SELECT * FROM CLI_EST_COL_1 WHERE CLIENTE = '" & cliente.Text & "'  AND ESTILO = '" & estilo.Text & "' AND COLOR = '" & colores.Text & "'"
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            d6_cestilo.Text = dr("ESTILO_CLIENTE")
            d6_ccolor.Text = dr("COLOR_CLIENTE")
        Next
        d6_cliente.Text = cliente.Text
        d6_estilo.Text = estilo.Text
        d6_color.Text = colores.Text
        strsql = "SELECT * FROM CLI_EST_COL_P WHERE CLIENTE = '" & cliente.Text & "'  AND ESTILO = '" & estilo.Text & "' AND COLOR = '" & colores.Text & "'"
        llena_tablas(dt, strsql, cnn)
        pd.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            pd(l, 1) = dr("PROCESO")
            pd(l, 2) = dr("DETALLE")
            pd(l, 3) = dr("COMENTARIOS")
            l = l + 1
        Next
    End Sub
    Private Sub hoja_Click(sender As Object, e As EventArgs) Handles hoja.Click
        Dim si As Boolean
        Dim ct As String = "Tela corte " + corte.Text
        datos_excel(tl, ct, si)
    End Sub
    Private Sub datos_excel(ByVal fg As C1.Win.C1FlexGrid.C1FlexGrid, ByVal nombre As String, ByRef si As Boolean)
        Dim path As String = "c:\Reportes\" + nombre + ".xls"
        a_excel(fg, path, si)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles exm.Click
        Dim si As Boolean
        Dim ct As String = "Materiales corte " + corte.Text
        datos_excel(mt, ct, si)
    End Sub

    Private Sub D6_Click(sender As Object, e As EventArgs) Handles d6.Click

    End Sub

    Private Sub D1_Click(sender As Object, e As EventArgs) Handles d1.Click

    End Sub

    Private Sub Pr_Click(sender As Object, e As EventArgs) Handles Pr.Click

    End Sub

    Private Sub sp_Click(sender As Object, e As EventArgs) Handles sp.Click

    End Sub
End Class



