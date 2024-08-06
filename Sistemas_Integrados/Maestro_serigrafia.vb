Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Maestro_serigrafia
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Private WithEvents tm As C1.Win.C1Command.C1DockingTab
    Private WithEvents d1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents supervisor As System.Windows.Forms.TextBox
    Friend WithEvents activa As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents facturar As System.Windows.Forms.ComboBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents meta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents regresa As System.Windows.Forms.Button
    Friend WithEvents graba As System.Windows.Forms.Button
    Friend WithEvents serigra As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents d2 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents d3 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents meta2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Elimina_2 As System.Windows.Forms.Button
    Friend WithEvents fecha_final As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents fecha_inicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents seri As System.Windows.Forms.ComboBox
    Friend WithEvents fg2 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents r2 As System.Windows.Forms.Button
    Friend WithEvents graba_2 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Elimina3 As System.Windows.Forms.Button
    Friend WithEvents fecha_fin3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents fecha_ini3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents seri3 As System.Windows.Forms.ComboBox
    Friend WithEvents fg3 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents r3 As System.Windows.Forms.Button
    Friend WithEvents graba3 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Dim dr As DataRow
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Maestro_serigrafia))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.activa = New System.Windows.Forms.ComboBox()
        Me.facturar = New System.Windows.Forms.ComboBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.meta = New System.Windows.Forms.TextBox()
        Me.regresa = New System.Windows.Forms.Button()
        Me.graba = New System.Windows.Forms.Button()
        Me.serigra = New System.Windows.Forms.TextBox()
        Me.supervisor = New System.Windows.Forms.TextBox()
        Me.Elimina_2 = New System.Windows.Forms.Button()
        Me.seri = New System.Windows.Forms.ComboBox()
        Me.fg2 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.r2 = New System.Windows.Forms.Button()
        Me.graba_2 = New System.Windows.Forms.Button()
        Me.Elimina3 = New System.Windows.Forms.Button()
        Me.seri3 = New System.Windows.Forms.ComboBox()
        Me.fg3 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.r3 = New System.Windows.Forms.Button()
        Me.graba3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tm = New C1.Win.C1Command.C1DockingTab()
        Me.d1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.d2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.meta2 = New C1.Win.C1Input.C1TextBox()
        Me.fecha_final = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.fecha_inicial = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.d3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.fecha_fin3 = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.fecha_ini3 = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tm.SuspendLayout()
        Me.d1.SuspendLayout()
        Me.d2.SuspendLayout()
        CType(Me.meta2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.d3.SuspendLayout()
        Me.SuspendLayout()
        '
        'activa
        '
        Me.activa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.activa.ItemHeight = 20
        Me.activa.Items.AddRange(New Object() {"S", "N"})
        Me.activa.Location = New System.Drawing.Point(148, 109)
        Me.activa.Name = "activa"
        Me.activa.Size = New System.Drawing.Size(48, 28)
        Me.activa.TabIndex = 91
        Me.ToolTip1.SetToolTip(Me.activa, "El registro está activo?")
        '
        'facturar
        '
        Me.facturar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.facturar.ItemHeight = 20
        Me.facturar.Items.AddRange(New Object() {"S", "N"})
        Me.facturar.Location = New System.Drawing.Point(148, 85)
        Me.facturar.Name = "facturar"
        Me.facturar.Size = New System.Drawing.Size(48, 28)
        Me.facturar.TabIndex = 89
        Me.ToolTip1.SetToolTip(Me.facturar, "Facturar por medio de Texsun?")
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
        Me.fg.Location = New System.Drawing.Point(4, 141)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 25
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1000, 533)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 88
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'meta
        '
        Me.meta.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.meta.Location = New System.Drawing.Point(148, 61)
        Me.meta.MaxLength = 10
        Me.meta.Name = "meta"
        Me.meta.Size = New System.Drawing.Size(152, 24)
        Me.meta.TabIndex = 82
        Me.meta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.meta, "Prendas por día.")
        '
        'regresa
        '
        Me.regresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresa.ForeColor = System.Drawing.Color.Black
        Me.regresa.Image = CType(resources.GetObject("regresa.Image"), System.Drawing.Image)
        Me.regresa.Location = New System.Drawing.Point(932, 2)
        Me.regresa.Name = "regresa"
        Me.regresa.Size = New System.Drawing.Size(60, 40)
        Me.regresa.TabIndex = 84
        Me.regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.regresa, "Limpia datos sin Grabar ni Eliminar.")
        Me.regresa.UseVisualStyleBackColor = False
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(866, 2)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(60, 40)
        Me.graba.TabIndex = 83
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.graba, "Graba y Actualiza registros.")
        Me.graba.UseVisualStyleBackColor = False
        '
        'serigra
        '
        Me.serigra.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serigra.Location = New System.Drawing.Point(148, 13)
        Me.serigra.MaxLength = 15
        Me.serigra.Name = "serigra"
        Me.serigra.Size = New System.Drawing.Size(231, 24)
        Me.serigra.TabIndex = 80
        Me.ToolTip1.SetToolTip(Me.serigra, "Sección")
        '
        'supervisor
        '
        Me.supervisor.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supervisor.Location = New System.Drawing.Point(148, 38)
        Me.supervisor.MaxLength = 30
        Me.supervisor.Name = "supervisor"
        Me.supervisor.Size = New System.Drawing.Size(520, 24)
        Me.supervisor.TabIndex = 92
        Me.ToolTip1.SetToolTip(Me.supervisor, "Nombre del Supervisor")
        '
        'Elimina_2
        '
        Me.Elimina_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Elimina_2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Elimina_2.ForeColor = System.Drawing.Color.Black
        Me.Elimina_2.Image = CType(resources.GetObject("Elimina_2.Image"), System.Drawing.Image)
        Me.Elimina_2.Location = New System.Drawing.Point(800, 17)
        Me.Elimina_2.Name = "Elimina_2"
        Me.Elimina_2.Size = New System.Drawing.Size(60, 40)
        Me.Elimina_2.TabIndex = 107
        Me.Elimina_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Elimina_2, "Elimina Registros")
        Me.Elimina_2.UseVisualStyleBackColor = False
        '
        'seri
        '
        Me.seri.ItemHeight = 20
        Me.seri.Location = New System.Drawing.Point(172, 17)
        Me.seri.Name = "seri"
        Me.seri.Size = New System.Drawing.Size(194, 28)
        Me.seri.TabIndex = 95
        Me.ToolTip1.SetToolTip(Me.seri, "Facturar por medio de Texsun?")
        '
        'fg2
        '
        Me.fg2.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg2.AllowEditing = False
        Me.fg2.AutoGenerateColumns = False
        Me.fg2.BackColor = System.Drawing.Color.White
        Me.fg2.ColumnInfo = resources.GetString("fg2.ColumnInfo")
        Me.fg2.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg2.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.fg2.ForeColor = System.Drawing.Color.Black
        Me.fg2.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg2.Location = New System.Drawing.Point(4, 140)
        Me.fg2.Name = "fg2"
        Me.fg2.Rows.Count = 1
        Me.fg2.Rows.DefaultSize = 25
        Me.fg2.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg2.Size = New System.Drawing.Size(1000, 533)
        Me.fg2.StyleInfo = resources.GetString("fg2.StyleInfo")
        Me.fg2.TabIndex = 105
        Me.ToolTip1.SetToolTip(Me.fg2, "Area de Datos.")
        '
        'r2
        '
        Me.r2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.r2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r2.ForeColor = System.Drawing.Color.Black
        Me.r2.Image = CType(resources.GetObject("r2.Image"), System.Drawing.Image)
        Me.r2.Location = New System.Drawing.Point(932, 17)
        Me.r2.Name = "r2"
        Me.r2.Size = New System.Drawing.Size(60, 40)
        Me.r2.TabIndex = 101
        Me.r2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.r2, "Limpia datos sin Grabar ni Eliminar.")
        Me.r2.UseVisualStyleBackColor = False
        '
        'graba_2
        '
        Me.graba_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba_2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba_2.ForeColor = System.Drawing.Color.Black
        Me.graba_2.Image = CType(resources.GetObject("graba_2.Image"), System.Drawing.Image)
        Me.graba_2.Location = New System.Drawing.Point(866, 17)
        Me.graba_2.Name = "graba_2"
        Me.graba_2.Size = New System.Drawing.Size(60, 40)
        Me.graba_2.TabIndex = 100
        Me.graba_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.graba_2, "Graba y Actualiza registros.")
        Me.graba_2.UseVisualStyleBackColor = False
        '
        'Elimina3
        '
        Me.Elimina3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Elimina3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Elimina3.ForeColor = System.Drawing.Color.Black
        Me.Elimina3.Image = CType(resources.GetObject("Elimina3.Image"), System.Drawing.Image)
        Me.Elimina3.Location = New System.Drawing.Point(800, 17)
        Me.Elimina3.Name = "Elimina3"
        Me.Elimina3.Size = New System.Drawing.Size(60, 40)
        Me.Elimina3.TabIndex = 106
        Me.Elimina3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Elimina3, "Elimina Registros")
        Me.Elimina3.UseVisualStyleBackColor = False
        '
        'seri3
        '
        Me.seri3.ItemHeight = 20
        Me.seri3.Location = New System.Drawing.Point(172, 17)
        Me.seri3.Name = "seri3"
        Me.seri3.Size = New System.Drawing.Size(194, 28)
        Me.seri3.TabIndex = 96
        Me.ToolTip1.SetToolTip(Me.seri3, "Facturar por medio de Texsun?")
        '
        'fg3
        '
        Me.fg3.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg3.AllowEditing = False
        Me.fg3.BackColor = System.Drawing.Color.White
        Me.fg3.ColumnInfo = resources.GetString("fg3.ColumnInfo")
        Me.fg3.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg3.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.fg3.ForeColor = System.Drawing.Color.Black
        Me.fg3.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg3.Location = New System.Drawing.Point(4, 102)
        Me.fg3.Name = "fg3"
        Me.fg3.Rows.Count = 1
        Me.fg3.Rows.DefaultSize = 25
        Me.fg3.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg3.Size = New System.Drawing.Size(1000, 571)
        Me.fg3.StyleInfo = resources.GetString("fg3.StyleInfo")
        Me.fg3.TabIndex = 104
        Me.ToolTip1.SetToolTip(Me.fg3, "Area de Datos.")
        '
        'r3
        '
        Me.r3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.r3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r3.ForeColor = System.Drawing.Color.Black
        Me.r3.Image = CType(resources.GetObject("r3.Image"), System.Drawing.Image)
        Me.r3.Location = New System.Drawing.Point(932, 17)
        Me.r3.Name = "r3"
        Me.r3.Size = New System.Drawing.Size(60, 40)
        Me.r3.TabIndex = 101
        Me.r3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.r3, "Limpia datos sin Grabar ni Eliminar.")
        Me.r3.UseVisualStyleBackColor = False
        '
        'graba3
        '
        Me.graba3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba3.ForeColor = System.Drawing.Color.Black
        Me.graba3.Image = CType(resources.GetObject("graba3.Image"), System.Drawing.Image)
        Me.graba3.Location = New System.Drawing.Point(866, 17)
        Me.graba3.Name = "graba3"
        Me.graba3.Size = New System.Drawing.Size(60, 40)
        Me.graba3.TabIndex = 100
        Me.graba3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.graba3, "Graba y Actualiza registros.")
        Me.graba3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 682)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(416, 16)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Para Seleccionar un Registro  presione doble click en el Mouse."
        '
        'tm
        '
        Me.tm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tm.CanCloseTabs = True
        Me.tm.CanMoveTabs = True
        Me.tm.Controls.Add(Me.d1)
        Me.tm.Controls.Add(Me.d2)
        Me.tm.Controls.Add(Me.d3)
        Me.tm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tm.ItemSize = New System.Drawing.Size(0, 30)
        Me.tm.Location = New System.Drawing.Point(0, 12)
        Me.tm.Name = "tm"
        Me.tm.Size = New System.Drawing.Size(1010, 749)
        Me.tm.TabIndex = 80
        Me.tm.TabsSpacing = -1
        Me.tm.TabStyle = C1.Win.C1Command.TabStyleEnum.Rounded
        Me.tm.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        '
        'd1
        '
        Me.d1.Controls.Add(Me.Label1)
        Me.d1.Controls.Add(Me.supervisor)
        Me.d1.Controls.Add(Me.activa)
        Me.d1.Controls.Add(Me.Label6)
        Me.d1.Controls.Add(Me.facturar)
        Me.d1.Controls.Add(Me.fg)
        Me.d1.Controls.Add(Me.meta)
        Me.d1.Controls.Add(Me.Label5)
        Me.d1.Controls.Add(Me.Label4)
        Me.d1.Controls.Add(Me.Label3)
        Me.d1.Controls.Add(Me.regresa)
        Me.d1.Controls.Add(Me.graba)
        Me.d1.Controls.Add(Me.serigra)
        Me.d1.Controls.Add(Me.Label2)
        Me.d1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d1.Location = New System.Drawing.Point(1, 33)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(1008, 715)
        Me.d1.TabBackColor = System.Drawing.Color.Yellow
        Me.d1.TabBackColorSelected = System.Drawing.Color.White
        Me.d1.TabForeColor = System.Drawing.Color.Black
        Me.d1.TabForeColorSelected = System.Drawing.Color.Black
        Me.d1.TabIndex = 0
        Me.d1.Text = "Serigrafías"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 24)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Activa:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 24)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Facturar:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 24)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Meta:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 24)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Supervisor:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 24)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Serigrafía:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'd2
        '
        Me.d2.Controls.Add(Me.meta2)
        Me.d2.Controls.Add(Me.Elimina_2)
        Me.d2.Controls.Add(Me.fecha_final)
        Me.d2.Controls.Add(Me.Label7)
        Me.d2.Controls.Add(Me.fecha_inicial)
        Me.d2.Controls.Add(Me.seri)
        Me.d2.Controls.Add(Me.fg2)
        Me.d2.Controls.Add(Me.Label8)
        Me.d2.Controls.Add(Me.Label9)
        Me.d2.Controls.Add(Me.Label10)
        Me.d2.Controls.Add(Me.r2)
        Me.d2.Controls.Add(Me.graba_2)
        Me.d2.Controls.Add(Me.Label11)
        Me.d2.ForeColor = System.Drawing.Color.Black
        Me.d2.Location = New System.Drawing.Point(1, 33)
        Me.d2.Name = "d2"
        Me.d2.Size = New System.Drawing.Size(1008, 715)
        Me.d2.TabBackColor = System.Drawing.Color.DeepSkyBlue
        Me.d2.TabBackColorSelected = System.Drawing.Color.White
        Me.d2.TabIndex = 1
        Me.d2.Text = "Metas"
        '
        'meta2
        '
        Me.meta2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.meta2.CustomFormat = "##,##0"
        Me.meta2.DataType = GetType(Decimal)
        Me.meta2.DisplayFormat.CustomFormat = "####0"
        Me.meta2.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.meta2.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.meta2.DisplayFormat.NullText = "0"
        Me.meta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.meta2.Location = New System.Drawing.Point(172, 100)
        Me.meta2.MaxLength = 5
        Me.meta2.Name = "meta2"
        Me.meta2.NumericInputKeys = CType((C1.Win.C1Input.NumericInputKeyFlags.[Decimal] Or C1.Win.C1Input.NumericInputKeyFlags.X), C1.Win.C1Input.NumericInputKeyFlags)
        Me.meta2.ParseInfo.CustomFormat = "####0"
        Me.meta2.ParseInfo.ErrorMessage = "Por favor Ingrese un Valor numérico."
        Me.meta2.ParseInfo.Inherit = CType((((((C1.Win.C1Input.ParseInfoInheritFlags.CaseSensitive Or C1.Win.C1Input.ParseInfoInheritFlags.FormatType) _
            Or C1.Win.C1Input.ParseInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.ParseInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.ParseInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.ParseInfoInheritFlags.TrimEnd), C1.Win.C1Input.ParseInfoInheritFlags)
        Me.meta2.PostValidation.ErrorMessage = "Por favor ingrese un valor entre 100 y 99,999"
        Me.meta2.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.meta2.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {100, 0, 0, 0}), New Decimal(New Integer() {99999, 0, 0, 0}), True, True)})
        Me.meta2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.meta2.Size = New System.Drawing.Size(171, 22)
        Me.meta2.TabIndex = 99
        Me.meta2.Tag = Nothing
        Me.meta2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.meta2.TrimStart = True
        Me.meta2.Value = New Decimal(New Integer() {800, 0, 0, 0})
        Me.meta2.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'fecha_final
        '
        Me.fecha_final.CustomFormat = "dd/MM/yyyy"
        Me.fecha_final.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha_final.Location = New System.Drawing.Point(172, 74)
        Me.fecha_final.Name = "fecha_final"
        Me.fecha_final.Size = New System.Drawing.Size(171, 26)
        Me.fecha_final.TabIndex = 98
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 24)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Fecha Final:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fecha_inicial
        '
        Me.fecha_inicial.CustomFormat = "dd/MM/yyyy"
        Me.fecha_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha_inicial.Location = New System.Drawing.Point(172, 47)
        Me.fecha_inicial.Name = "fecha_inicial"
        Me.fecha_inicial.Size = New System.Drawing.Size(171, 26)
        Me.fecha_inicial.TabIndex = 97
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(12, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 24)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Meta:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(12, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 24)
        Me.Label9.TabIndex = 103
        Me.Label9.Text = "Fecha Inicial:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(4, 681)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(416, 16)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "Para Seleccionar un Registro  presione doble click en el Mouse."
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(12, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 24)
        Me.Label11.TabIndex = 96
        Me.Label11.Text = "Serigrafía:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'd3
        '
        Me.d3.Controls.Add(Me.Elimina3)
        Me.d3.Controls.Add(Me.fecha_fin3)
        Me.d3.Controls.Add(Me.Label12)
        Me.d3.Controls.Add(Me.fecha_ini3)
        Me.d3.Controls.Add(Me.seri3)
        Me.d3.Controls.Add(Me.fg3)
        Me.d3.Controls.Add(Me.Label13)
        Me.d3.Controls.Add(Me.Label14)
        Me.d3.Controls.Add(Me.r3)
        Me.d3.Controls.Add(Me.graba3)
        Me.d3.Controls.Add(Me.Label15)
        Me.d3.ForeColor = System.Drawing.Color.Black
        Me.d3.Location = New System.Drawing.Point(1, 33)
        Me.d3.Name = "d3"
        Me.d3.Size = New System.Drawing.Size(1008, 715)
        Me.d3.TabBackColor = System.Drawing.Color.SandyBrown
        Me.d3.TabBackColorSelected = System.Drawing.Color.White
        Me.d3.TabForeColor = System.Drawing.Color.Black
        Me.d3.TabForeColorSelected = System.Drawing.Color.Black
        Me.d3.TabIndex = 2
        Me.d3.Text = "Vacaciones"
        '
        'fecha_fin3
        '
        Me.fecha_fin3.CustomFormat = "dd/MM/yyyy"
        Me.fecha_fin3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha_fin3.Location = New System.Drawing.Point(172, 74)
        Me.fecha_fin3.Name = "fecha_fin3"
        Me.fecha_fin3.Size = New System.Drawing.Size(171, 26)
        Me.fecha_fin3.TabIndex = 99
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(12, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(159, 24)
        Me.Label12.TabIndex = 105
        Me.Label12.Text = "Fecha Final:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fecha_ini3
        '
        Me.fecha_ini3.CustomFormat = "dd/MM/yyyy"
        Me.fecha_ini3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha_ini3.Location = New System.Drawing.Point(172, 47)
        Me.fecha_ini3.Name = "fecha_ini3"
        Me.fecha_ini3.Size = New System.Drawing.Size(171, 26)
        Me.fecha_ini3.TabIndex = 98
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(12, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(159, 24)
        Me.Label13.TabIndex = 103
        Me.Label13.Text = "Fecha Inicial:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(4, 681)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(416, 16)
        Me.Label14.TabIndex = 102
        Me.Label14.Text = "Para Seleccionar un Registro  presione doble click en el Mouse."
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Courier New", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(12, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(136, 24)
        Me.Label15.TabIndex = 97
        Me.Label15.Text = "Sección:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Maestro_serigrafia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 761)
        Me.Controls.Add(Me.tm)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Maestro_serigrafia"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro de Serigrafías"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tm.ResumeLayout(False)
        Me.d1.ResumeLayout(False)
        Me.d1.PerformLayout()
        Me.d2.ResumeLayout(False)
        CType(Me.meta2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.d3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Tipos_cobro(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler serigra.KeyPress, AddressOf keypressed1
        AddHandler supervisor.KeyPress, AddressOf keypressed2
        AddHandler meta.KeyPress, AddressOf keypressed3
        AddHandler facturar.KeyPress, AddressOf keypressed4
        AddHandler activa.KeyPress, AddressOf keypressed5

        AddHandler seri.KeyPress, AddressOf keypressed11
        AddHandler fecha_inicial.KeyPress, AddressOf keypressed12
        AddHandler fecha_final.KeyPress, AddressOf keypressed13
        AddHandler meta2.KeyPress, AddressOf keypressed14

        AddHandler seri3.KeyPress, AddressOf keypressed31
        AddHandler fecha_ini3.KeyPress, AddressOf keypressed32
        AddHandler fecha_fin3.KeyPress, AddressOf keypressed33
        setea_fg_1()
    End Sub
    Private Sub T1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm.SelectedIndexChanged
        Select Case tm.SelectedIndex
            Case 0
                serigra.Focus()
            Case 1

                llena_combos(seri, "SELECT SERIGRAFIA FROM SERIGRAFIAS WHERE ACTIVA = 'S'", "SERIGRAFIA")
                Try
                    seri.SelectedIndex = 0
                Catch ex As Exception
                End Try
                setea_fg_2()
                Try
                    seri.SelectedIndex = 0
                Catch
                End Try

                seri.Focus()

            Case 2
                llena_combos(seri3, "SELECT SERIGRAFIA FROM SERIGRAFIAS WHERE ACTIVA = 'S'", "SERIGRAFIA")
                Try
                    seri3.SelectedIndex = 0
                Catch ex As Exception
                End Try
                setea_fg3()

        End Select
    End Sub

    Private Sub limpia_variables_1()
        serigra.Text = ""
        supervisor.Text = ""
        meta.Text = "2000"
        facturar.SelectedIndex = 0
        activa.SelectedIndex = 0
        serigra.Enabled = True
        supervisor.Enabled = False
        meta.Enabled = False
        facturar.Enabled = False
        activa.Enabled = False
        graba.Visible = False
        serigra.Focus()
    End Sub

    Private Sub setea_fg_1()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        limpia_variables_1()
        llena_fg_1()
    End Sub
    Private Sub llena_fg_1()
        Dim l As Integer
        llena_tablas(dt, "SELECT * FROM SERIGRAFIAS ORDER BY SERIGRAFIA", cnn)
        l = 1
        fg.Rows.Count = dt.Rows.Count + 1
        For Each Me.dr In dt.Rows
            fg(l, 1) = dr("SERIGRAFIA")
            fg(l, 2) = dr("SUPERVISOR")
            fg(l, 3) = dr("META")
            fg(l, 4) = dr("FACTURAR")
            fg(l, 5) = dr("ACTIVA")
            l = l + 1
        Next
    End Sub
    Private Sub fg_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        selecciona_registro_1()
    End Sub
    Private Sub selecciona_registro_1()
        Dim i As Integer = fg.RowSel
        Dim ok As Boolean
        serigra.Text = fg(i, 1)
        busca_serigrafia_1(ok)
        habilita_1()
    End Sub

    Private Sub busca_serigrafia_1(ByRef ok As Boolean)
        Dim dt As New DataTable()
        Dim dr As DataRow
        llena_tablas(dt, "SELECT * FROM SERIGRAFIAS WHERE SERIGRAFIA = '" & serigra.Text & "'", cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            supervisor.Text = dr("SUPERVISOR")
            meta.Text = dr("META")
            facturar.SelectedItem = dr("FACTURAR")
            activa.SelectedItem = dr("ACTIVA")
            ok = True
        Else
            ok = False
        End If
    End Sub
    Private Sub habilita_1()
        serigra.Enabled = False
        supervisor.Enabled = True
        meta.Enabled = True
        facturar.Enabled = True
        activa.Enabled = True
        graba.Visible = True
        regresa.Visible = True
        supervisor.Focus()
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim ok As Boolean = False
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(serigra.Text) <> "" Then
                busca_serigrafia_1(ok)
                habilita_1()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(supervisor.Text) <> "" Then
                meta.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(meta.Text) <> "" Then
                facturar.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(facturar.Text) <> "" Then
                activa.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(activa.Text) <> "" Then
                graba.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub revisa_datos(ByRef ok As Boolean)
        Dim sal As Decimal
        If (Trim(supervisor.Text) = "") Or (Trim(meta.Text) = "") Then
            ok = False
            MsgBox("Antes de Grabar debe ingresar todos los datos solicitados", MsgBoxStyle.Critical, "Por favor revise !!!!")
        Else
            ok = True
        End If
        Try
            sal = CDec(meta.Text)
        Catch
        End Try
        If sal = 0 Then
            ok = False
            MsgBox("Antes de Grabar debe ingresar una meta válida.", MsgBoxStyle.Critical, "Por favor revise !!!!")
        End If
        serigra.Text = UCase(serigra.Text)
        supervisor.Text = UCase(supervisor.Text)
        Me.Refresh()
    End Sub

    Private Sub graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba.Click
        Dim ok As Boolean
        revisa_datos(ok)
        If ok Then
            graba_datos()
            setea_fg_1()
        End If
    End Sub


    '=================================================================================
    '                        GRABA DATOS
    '=================================================================================
    Private Sub graba_datos()
        Dim strsql As String
        Dim afectados As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "UPDATE SERIGRAFIAS SET SUPERVISOR = '" & supervisor.Text & "', " & _
                                          "META = '" & meta.Text & "', " & _
                                          "FACTURAR = '" & facturar.Text & "', " & _
                                          "ACTIVA = '" & activa.Text & "' WHERE SERIGRAFIA = '" & serigra.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            If afectados = 0 Then
                strsql = "INSERT INTO SERIGRAFIAS (SERIGRAFIA,FACTURAR,SUPERVISOR,META,ACTIVA) VALUES ('" & _
                                                    serigra.Text & "','" & _
                                                    facturar.Text & "','" & _
                                                    supervisor.Text & "','" &
                                                    meta.Text & "','" & _
                                                    facturar.Text & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("La actualización de Datos falló.", MsgBoxStyle.Critical, "Por favor revise !!!!")
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

    Private Sub regresa_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regresa.Click
        setea_fg_1()
    End Sub
    ' ================================================= METAS ================================================

    Private Sub limpia_variables_2()
        meta.Enabled = True
        meta.Text = "1000"
        fecha_inicial.Value = Today
        fecha_final.Value = Today
        seri.Enabled = True
        fecha_inicial.Enabled = True
        fecha_final.Enabled = False
        meta.Enabled = False
        Elimina_2.Visible = False
        graba_2.Visible = False
        seri.Focus()
    End Sub

    Private Sub setea_fg_2()
        fg2.Rows(0).Height = 30
        limpia_variables_2()
        llena_fg_2()
    End Sub
    Private Sub llena_fg_2()
        llena_tablas(dt, "SELECT * FROM SERIGRAFIAS_META WHERE SERIGRAFIA = '" & seri.Text & "'", cnn)
        fg2.DataSource = dt
    End Sub
    Private Sub fg_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg2.Click
        selecciona_registro_2()
    End Sub
    Private Sub fg_canbia_linea_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg2.KeyPress
        selecciona_registro_2()
    End Sub
    Private Sub selecciona_registro_2()
        Dim i As Integer = fg2.RowSel
        Dim ok As Boolean
        If i > 0 Then
            seri.Text = fg2(i, 1)
            fecha_inicial.Value = fg2(i, 2)
            busca_seccion_2(ok)
            habilita_2()
        End If
    End Sub

    Private Sub busca_seccion_2(ByRef ok As Boolean)
        Dim dt As New DataTable()
        Dim dr As DataRow
        llena_tablas(dt, "SELECT * FROM SERIGRAFIAS_META WHERE SERIGRAFIA = '" & seri.Text & "' AND FECHA_INICIAL = '" & Format(fecha_inicial.Value, "yyyy-MM-dd") & "'", cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            fecha_final.Value = dr("FECHA_FINAL")
            meta2.Enabled = True
            meta2.Text = dr("META")
            ok = True
            Elimina_2.Visible = True
        Else
            ok = False
        End If
    End Sub
    Private Sub habilita_2()
        seri.Enabled = False
        fecha_inicial.Enabled = False
        fecha_final.Enabled = True
        meta.Enabled = True
        graba_2.Visible = True
        r2.Visible = True
    End Sub

    Private Sub keypressed11(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(seri.Text) <> "" Then
                fecha_inicial.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed12(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim ok As Boolean = False
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(fecha_inicial.Text) <> "" Then
                busca_seccion_2(ok)
                habilita_2()
                fecha_final.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed13(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(fecha_final.Text) <> "" Then
                meta2.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed14(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(meta2.Text) <> "" Then
                graba_2.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub revisa_datos_2(ByRef ok As Boolean)
        ok = True
        Dim sal As Integer
        If Format(fecha_final.Value, "yyyy-MM-dd") < Format(fecha_inicial.Value, "yyyy-MM-dd") Then
            MsgBox("La Fecha Final no puede ser mayor a la Fecha Inicial válida.", MsgBoxStyle.Critical, "Error en Fechas !!!!")
            ok = False
            Exit Sub
        End If
        Try
            sal = CDec(meta.Text)
        Catch
            meta.Text = "0"
        End Try
        'If sal = 0 Then
        '    ok = False
        '    MsgBox("Antes de Grabar debe ingresar una meta válida.", MsgBoxStyle.Critical, "Por favor revise !!!!")
        'End If
        Me.Refresh()
    End Sub

    Private Sub graba_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba_2.Click
        Dim ok As Boolean
        revisa_datos_2(ok)
        If ok Then
            graba_datos_2()
            setea_fg_2()
        End If
    End Sub


    '=================================================================================
    '                        GRABA DATOS
    '=================================================================================
    Private Sub graba_datos_2()
        Dim strsql As String
        Dim afectados As Integer
        Dim finicial As String = Format(fecha_inicial.Value, "yyyy-MM-dd")
        Dim ffinal As String = Format(fecha_final.Value, "yyyy-MM-dd")

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "UPDATE SERIGRAFIAS_META SET FECHA_FINAL = '" & ffinal & "', " & _
                                                     "META = '" & meta2.Text & "' " & _
                                           " WHERE SERIGRAFIA = '" & seri.Text & "' AND FECHA_INICIAL = '" & finicial & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            If afectados = 0 Then
                strsql = "INSERT INTO SERIGRAFIAS_META (SERIGRAFIA,FECHA_INICIAL,FECHA_FINAL,META) VALUES ('" & _
                                                       seri.Text & "','" & _
                                                       finicial & "','" & _
                                                       ffinal & "','" &
                                                       meta2.Text & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("La actualización de Datos falló.", MsgBoxStyle.Critical, "Por favor revise !!!!")
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

    Private Sub regresa_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r2.Click
        setea_fg_2()
        seri.Focus()
    End Sub

    Private Sub seccion_KeyPress2(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles seri.KeyPress
        AutoCompletar(seri, e)
    End Sub

    Private Sub seccion_SelectedIndexChanged2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seri.SelectedIndexChanged
        llena_fg_2()
    End Sub

    Private Sub Elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Elimina_2.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_datos()
        End If
        setea_fg_2()
    End Sub


    '=================================================================================
    '                        ELIMINA DATOS
    '=================================================================================
    Private Sub elimina_datos()
        Dim strsql As String
        Dim afectados As Integer
        Dim finicial As String = Format(fecha_inicial.Value, "yyyy-MM-dd")
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE SERIGRAFIAS_META WHERE SERIGRAFIA = '" & seri.Text & "' AND FECHA_INICIAL = '" & finicial & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("Eliminación del Registro falló. ", MsgBoxStyle.Critical, "Por favor revise !!!!")
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

    ' ============================================== SERIGRAFIAS ASUETOS ==========================================

 
    Private Sub limpia_variables3()
        seri3.SelectedIndex = 0
        fecha_ini3.Value = Today
        fecha_fin3.Value = Today
        seri3.Enabled = True
        fecha_ini3.Enabled = True
        fecha_fin3.Enabled = False
        Elimina3.Visible = False
        graba3.Visible = False
        seri3.Focus()
    End Sub

    Private Sub setea_fg3()
        fg3.Rows.Count = 1
        fg3.Rows(0).Height = 30
        limpia_variables3()
        llena_fg3()
    End Sub
    Private Sub llena_fg3()
        Dim l As Integer
        llena_tablas(dt, "SELECT * FROM SERIGRAFIAS_VAC WHERE SERIGRAFIA = '" & seri3.Text & "'", cnn)
        l = 1
        fg3.Rows.Count = dt.Rows.Count + 1
        For Each Me.dr In dt.Rows
            fg3(l, 1) = dr("SERIGRAFIA")
            fg3(l, 2) = dr("FECHA_INICIAL")
            fg3(l, 3) = dr("FECHA_FINAL")
            l = l + 1
        Next
    End Sub
    Private Sub fg_Click_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg3.Click
        selecciona_registro3()
    End Sub
    Private Sub selecciona_registro3()
        Dim i As Integer = fg3.RowSel
        Dim ok As Boolean
        seri3.Text = fg3(i, 1)
        fecha_ini3.Value = fg3(i, 2)
        busca_seccion3(ok)
        habilita3()
    End Sub

    Private Sub busca_seccion3(ByRef ok As Boolean)
        Dim dt As New DataTable()
        Dim dr As DataRow
        llena_tablas(dt, "SELECT * FROM SERIGRAFIAS_VAC WHERE SERIGRAFIA = '" & seri3.Text & "' AND FECHA_INICIAL = '" & Format(fecha_ini3.Value, "yyyy-MM-dd") & "'", cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            fecha_fin3.Value = dr("FECHA_FINAL")
            ok = True
            Elimina3.Visible = True
        Else
            ok = False
        End If
    End Sub
    Private Sub habilita3()
        seri3.Enabled = False
        fecha_ini3.Enabled = False
        fecha_fin3.Enabled = True
        graba3.Visible = True
        r3.Visible = True
        fecha_fin3.Focus()
    End Sub

    Private Sub keypressed31(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(seri3.Text) <> "" Then
                fecha_ini3.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed32(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim ok As Boolean = False
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(fecha_ini3.Text) <> "" Then
                busca_seccion3(ok)
                habilita3()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed33(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(fecha_fin3.Text) <> "" Then
                graba3.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub revisa_datos3(ByRef ok As Boolean)
        ok = True
        If Format(fecha_fin3.Value, "yyyy-MM-dd") < Format(fecha_ini3.Value, "yyyy-MM-dd") Then
            MsgBox("La Fecha Final no puede ser menor a la Fecha Inicial.", MsgBoxStyle.Critical, "Error en Fechas !!!!")
            ok = False
            Exit Sub
        End If
        revisa_periodos3(ok)
        If Not ok Then
            Exit Sub
        End If
        Me.Refresh()
    End Sub

    Private Sub graba_Click3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba3.Click
        Dim ok As Boolean
        revisa_datos3(ok)
        If ok Then
            graba_datos3()
            setea_fg3()
        End If
    End Sub

    Private Sub revisa_periodos3(ByRef ok As Boolean)
        Dim i As Integer
        For i = 1 To fg3.Rows.Count - 1
            If (fecha_ini3.Value <= fg(i, 3)) And (fecha_ini3.Value >= fg(i, 2)) Then
                MsgBox("El período Vacacional se encuentra dentro de otro período ya definido anteriormente !!!!", MsgBoxStyle.Critical, "Revisar Fecchas.")
                ok = False
            End If
        Next
    End Sub

    '=================================================================================
    '                        GRABA DATOS
    '=================================================================================
    Private Sub graba_datos3()
        Dim strsql As String
        Dim afectados As Integer
        Dim finicial As String = Format(fecha_ini3.Value, "yyyy-MM-dd")
        Dim ffinal As String = Format(fecha_fin3.Value, "yyyy-MM-dd")

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "UPDATE SERIGRAFIAS_VAC SET FECHA_FINAL = '" & ffinal & "' " & _
                                               " WHERE SERIGRAFIA = '" & seri3.Text & "' AND FECHA_INICIAL = '" & finicial & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            If afectados = 0 Then
                strsql = "INSERT INTO SERIGRAFIAS_VAC (SERIGRAFIA,FECHA_INICIAL,FECHA_FINAL) VALUES ('" & _
                                                    seri3.Text & "','" & _
                                                    finicial & "','" & _
                                                    ffinal & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("La actualización de Datos falló.", MsgBoxStyle.Critical, "Por favor revise !!!!")
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

    Private Sub regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regresa.Click
        setea_fg3()
    End Sub

    Private Sub seccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles seri3.KeyPress
        AutoCompletar(seri3, e)
    End Sub

    Private Sub seccion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seri3.SelectedIndexChanged
        llena_fg3()
    End Sub

    '=================================================================================
    '                        ELIMINA DATOS
    '=================================================================================
    Private Sub elimina_datos3()
        Dim strsql As String
        Dim afectados As Integer
        Dim finicial As String = Format(fecha_ini3.Value, "yyyy-MM-dd")
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE SERIGRAFIAS_VAC WHERE SERIGRAFIA = '" & seri3.Text & "' AND FECHA_INICIAL = '" & finicial & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("Eliminación del Registro falló. ", MsgBoxStyle.Critical, "Por favor revise !!!!")
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

    Private Sub Elimina_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Elimina3.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_datos3()
        End If
        setea_fg3()
    End Sub
End Class



