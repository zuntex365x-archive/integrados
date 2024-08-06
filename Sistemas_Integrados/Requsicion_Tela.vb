Imports C1.Win.C1FlexGrid
Imports Microsoft.VisualBasic
Imports System.Drawing.Printing
Imports System.Text

Public Class Requisicion_Tela
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim codigo As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim cnn1 As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim colorese As String
    Dim ok As Boolean
    Dim da As System.Data.SqlClient.SqlDataAdapter
    Dim t(11) As Integer
    Dim co(11) As Integer
    Dim knitr As String
    Dim colorr As String
    Dim mensaje As String
    Dim tl As String = "ST|XS|S|M|L|XL|2XL|3XL|4XL|5XL|6XL|TOTALES"
    Dim tn As String() = tl.Split("|")
    Dim ds As DataSet
    Dim dr As DataRow
    Dim Requi As String
    Dim batch As String
    Dim fpo As String
    Dim fpos As String
    Friend WithEvents c1r As C1.C1Report.C1Report
    Friend WithEvents ta As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents seccion As System.Windows.Forms.Label
    Friend WithEvents ImprimirTela As C1.Win.C1Input.C1CheckBox
    Dim ap As New DataTable()
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Cortes As System.Windows.Forms.TextBox
    Friend WithEvents Colores As System.Windows.Forms.ComboBox
    Friend WithEvents Estilos As System.Windows.Forms.ComboBox
    Friend WithEvents rt As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents salas As System.Windows.Forms.ComboBox
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Clientes As System.Windows.Forms.Label
    Friend WithEvents Regresa As System.Windows.Forms.Button
    Friend WithEvents graba As System.Windows.Forms.Button
    Friend WithEvents sigue As System.Windows.Forms.Button
    Friend WithEvents pd1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents busca As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cpos As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Requisicion_Tela))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.graba = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Regresa = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Cortes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.seccion = New System.Windows.Forms.Label()
        Me.ta = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.busca = New System.Windows.Forms.Button()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.salas = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.sigue = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Colores = New System.Windows.Forms.ComboBox()
        Me.Estilos = New System.Windows.Forms.ComboBox()
        Me.rt = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.cpos = New System.Windows.Forms.ComboBox()
        Me.Clientes = New System.Windows.Forms.Label()
        Me.pd1 = New System.Drawing.Printing.PrintDocument()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.c1r = New C1.C1Report.C1Report()
        Me.ImprimirTela = New C1.Win.C1Input.C1CheckBox()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1r, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImprimirTela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(576, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Corte"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fg
        '
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 288)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1051, 384)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(872, 8)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(35, 35)
        Me.graba.TabIndex = 20
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.graba, "Presione este Boton para Grabar o Actualizar los Datos del  Corte")
        Me.graba.UseVisualStyleBackColor = False
        Me.graba.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(952, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 21
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton para Borrar el Registro Seleccionado.")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Regresa
        '
        Me.Regresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Regresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresa.ForeColor = System.Drawing.Color.Black
        Me.Regresa.Image = CType(resources.GetObject("Regresa.Image"), System.Drawing.Image)
        Me.Regresa.Location = New System.Drawing.Point(912, 8)
        Me.Regresa.Name = "Regresa"
        Me.Regresa.Size = New System.Drawing.Size(35, 35)
        Me.Regresa.TabIndex = 19
        Me.Regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Regresa, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.Regresa.UseVisualStyleBackColor = False
        Me.Regresa.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.SteelBlue
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(392, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(176, 16)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Color"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Cortes
        '
        Me.Cortes.BackColor = System.Drawing.Color.White
        Me.Cortes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cortes.ForeColor = System.Drawing.Color.Black
        Me.Cortes.Location = New System.Drawing.Point(576, 24)
        Me.Cortes.MaxLength = 10
        Me.Cortes.Name = "Cortes"
        Me.Cortes.Size = New System.Drawing.Size(96, 20)
        Me.Cortes.TabIndex = 4
        Me.Cortes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.Cortes, "Numero de Corte")
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(680, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(16, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "CPO"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.SteelBlue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(208, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(176, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Estilo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.seccion)
        Me.GroupBox1.Controls.Add(Me.ta)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.busca)
        Me.GroupBox1.Controls.Add(Me.fecha)
        Me.GroupBox1.Controls.Add(Me.salas)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1051, 112)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tallas"
        '
        'seccion
        '
        Me.seccion.BackColor = System.Drawing.Color.White
        Me.seccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.seccion.Location = New System.Drawing.Point(385, 80)
        Me.seccion.Name = "seccion"
        Me.seccion.Size = New System.Drawing.Size(198, 21)
        Me.seccion.TabIndex = 47
        Me.seccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ta
        '
        Me.ta.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.ta.AllowMergingFixed = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.ta.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.ta.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.ta.BackColor = System.Drawing.Color.White
        Me.ta.ColumnInfo = resources.GetString("ta.ColumnInfo")
        Me.ta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ta.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.ta.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.ta.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.ta.Location = New System.Drawing.Point(8, 15)
        Me.ta.Name = "ta"
        Me.ta.Rows.Count = 2
        Me.ta.Rows.DefaultSize = 19
        Me.ta.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ta.Size = New System.Drawing.Size(827, 46)
        Me.ta.StyleInfo = resources.GetString("ta.StyleInfo")
        Me.ta.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.SteelBlue
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(384, 64)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(200, 16)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "Seccion de Costura"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'busca
        '
        Me.busca.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.busca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.busca.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.busca.ForeColor = System.Drawing.Color.Black
        Me.busca.Image = CType(resources.GetObject("busca.Image"), System.Drawing.Image)
        Me.busca.Location = New System.Drawing.Point(944, 64)
        Me.busca.Name = "busca"
        Me.busca.Size = New System.Drawing.Size(35, 35)
        Me.busca.TabIndex = 44
        Me.busca.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.busca, "Presiones este boton para ver el detalle de lo cortado en el  CPO.")
        Me.busca.UseVisualStyleBackColor = False
        '
        'fecha
        '
        Me.fecha.Checked = False
        Me.fecha.CustomFormat = "dd/MM/yyyy"
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(8, 80)
        Me.fecha.Name = "fecha"
        Me.fecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fecha.Size = New System.Drawing.Size(144, 21)
        Me.fecha.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.fecha, "Issue Date.")
        '
        'salas
        '
        Me.salas.Location = New System.Drawing.Point(160, 80)
        Me.salas.MaxLength = 25
        Me.salas.Name = "salas"
        Me.salas.Size = New System.Drawing.Size(200, 21)
        Me.salas.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.salas, "Color")
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.SteelBlue
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(160, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(200, 16)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Sala de Corte"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 16)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Fecha"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(664, 128)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 16)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "4XL"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sigue
        '
        Me.sigue.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.sigue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sigue.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sigue.ForeColor = System.Drawing.Color.Black
        Me.sigue.Image = CType(resources.GetObject("sigue.Image"), System.Drawing.Image)
        Me.sigue.Location = New System.Drawing.Point(872, 8)
        Me.sigue.Name = "sigue"
        Me.sigue.Size = New System.Drawing.Size(35, 35)
        Me.sigue.TabIndex = 5
        Me.sigue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.sigue, "Presione este Boton para Buscar el Registro Seleccionado.")
        Me.sigue.UseVisualStyleBackColor = False
        '
        'Colores
        '
        Me.Colores.BackColor = System.Drawing.Color.White
        Me.Colores.ForeColor = System.Drawing.Color.Black
        Me.Colores.Location = New System.Drawing.Point(392, 24)
        Me.Colores.MaxLength = 25
        Me.Colores.Name = "Colores"
        Me.Colores.Size = New System.Drawing.Size(176, 21)
        Me.Colores.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Colores, "Color")
        '
        'Estilos
        '
        Me.Estilos.BackColor = System.Drawing.Color.White
        Me.Estilos.ForeColor = System.Drawing.Color.Black
        Me.Estilos.Location = New System.Drawing.Point(208, 24)
        Me.Estilos.MaxLength = 25
        Me.Estilos.Name = "Estilos"
        Me.Estilos.Size = New System.Drawing.Size(176, 21)
        Me.Estilos.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Estilos, "Color")
        '
        'rt
        '
        Me.rt.AllowEditing = False
        Me.rt.ColumnInfo = resources.GetString("rt.ColumnInfo")
        Me.rt.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.rt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rt.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.rt.Location = New System.Drawing.Point(8, 176)
        Me.rt.Name = "rt"
        Me.rt.Rows.DefaultSize = 19
        Me.rt.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.rt.Size = New System.Drawing.Size(1051, 104)
        Me.rt.StyleInfo = resources.GetString("rt.StyleInfo")
        Me.rt.TabIndex = 47
        Me.ToolTip1.SetToolTip(Me.rt, "Area de Datos.")
        '
        'cpos
        '
        Me.cpos.BackColor = System.Drawing.Color.White
        Me.cpos.ForeColor = System.Drawing.Color.Black
        Me.cpos.Location = New System.Drawing.Point(16, 24)
        Me.cpos.MaxLength = 20
        Me.cpos.Name = "cpos"
        Me.cpos.Size = New System.Drawing.Size(184, 21)
        Me.cpos.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cpos, "Color")
        '
        'Clientes
        '
        Me.Clientes.BackColor = System.Drawing.Color.White
        Me.Clientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Clientes.ForeColor = System.Drawing.Color.Black
        Me.Clientes.Location = New System.Drawing.Point(680, 24)
        Me.Clientes.Name = "Clientes"
        Me.Clientes.Size = New System.Drawing.Size(176, 20)
        Me.Clientes.TabIndex = 48
        '
        'Label17
        '
        Me.Label17.Image = CType(resources.GetObject("Label17.Image"), System.Drawing.Image)
        Me.Label17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label17.Location = New System.Drawing.Point(5, 680)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(352, 24)
        Me.Label17.TabIndex = 49
        '
        'c1r
        '
        Me.c1r.ReportDefinition = resources.GetString("c1r.ReportDefinition")
        '
        'ImprimirTela
        '
        Me.ImprimirTela.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ImprimirTela.Checked = True
        Me.ImprimirTela.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ImprimirTela.Location = New System.Drawing.Point(993, 12)
        Me.ImprimirTela.Name = "ImprimirTela"
        Me.ImprimirTela.Size = New System.Drawing.Size(65, 24)
        Me.ImprimirTela.TabIndex = 50
        Me.ImprimirTela.Text = "Telas"
        Me.ImprimirTela.UseVisualStyleBackColor = False
        Me.ImprimirTela.Value = True
        '
        'Requisicion_Tela
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1071, 704)
        Me.Controls.Add(Me.ImprimirTela)
        Me.Controls.Add(Me.Regresa)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Clientes)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.rt)
        Me.Controls.Add(Me.Estilos)
        Me.Controls.Add(Me.Colores)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.sigue)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cortes)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cpos)
        Me.Controls.Add(Me.graba)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Requisicion_Tela"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Requisicion de Tela por Corte"
        Me.ToolTip1.SetToolTip(Me, "Requisicion de Tela por Corte")
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1r, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImprimirTela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Requisicion_tela_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler cpos.KeyPress, AddressOf keypressed1
        AddHandler Estilos.KeyPress, AddressOf keypressed2
        AddHandler Colores.KeyPress, AddressOf keypressed3
        AddHandler Cortes.KeyPress, AddressOf keypressed4
        AddHandler fecha.KeyPress, AddressOf keypressed18
        AddHandler salas.KeyPress, AddressOf keypressed19
        AddHandler seccion.KeyPress, AddressOf keypressed20
        limpia_variables()
        Try
            cpos.SelectedIndex = 0
        Catch
        End Try
    End Sub
    Private Sub llena_los_combos()
        llena_combos(cpos, "SELECT DISTINCT CPO FROM CPO_D WHERE ESTADO ='A' ORDER BY CPO", "CPO", ok)
        llena_combos(salas, "SELECT * FROM SALAS ORDER BY SALA", "SALA", ok)

    End Sub
    Private Sub setea_grid()
        Dim index As Integer
        fg.Clear()
        fg.Rows.Count = 1
        fg.Cols.Count = 14
        fg.Cols(0).Width = 5
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Name = "BATCH"
        fg.Cols(2).Name = "ROLLO"
        fg.Cols(3).Name = "KNIT"
        fg.Cols(4).Name = "COLOR"
        fg.Cols(5).Name = "ANCHO"
        fg.Cols(6).Name = "FPO"
        fg.Cols(7).Name = "LIBRAS"
        fg.Cols(8).Name = "YARDAS"
        fg.Cols(9).Name = "ELEGIR ?"
        fg.Cols(10).Name = "COSTO ?"
        fg.Cols(13).Name = "TONALIDAD"
        fg.Cols(12).Name = "CODIGOF"
        fg.Cols(11).Visible = False
        fg.Cols(12).Visible = False
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 105
            fg(0, index) = fg.Cols(index).Name
            If index > 6 And index < 9 Then
                fg.Cols(index).DataType = GetType(Decimal)
                fg.Cols(index).Format = "######0.00"
                fg.Cols(index).Width = 75
                fg.Cols(index).TextAlign = TextAlignEnum.RightCenter
                fg.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
            If index < 9 Then
                fg.Cols(index).AllowEditing = False
            Else
                fg.Cols(index).AllowEditing = True
            End If
        Next
        fg.Cols(9).DataType = GetType(Boolean)
        fg.Cols(10).DataType = GetType(Boolean)
        fg.Cols(2).Width = 60
        fg.Cols(4).Width = 170
        fg.Cols(9).Width = 75
        fg.Cols(10).Width = 75
        fg.Cols(13).Width = 72
        fg.Cols(2).DataType = GetType(Decimal)
        fg.Cols(2).Format = "######0"
        fg.Cols(2).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(2).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(9).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(9).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(10).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(10).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(11).DataType = GetType(Decimal)
        fg.Cols(13).DataType = GetType(String)
        fg.Cols(13).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(13).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(13).AllowEditing = False
    End Sub

    Private Sub setea_rt()
        Dim index As Integer
        rt.Clear()
        rt.Rows.Count = 1
        rt.Cols.Count = 7
        rt.Cols(0).Width = 5
        rt.Rows(0).Height = 30
        Dim c As Column = rt.Cols(1)
        rt.Cols(1).Name = "DESCRIPCION DE LA TELA"
        rt.Cols(2).Name = "COLOR"
        rt.Cols(3).Name = "CONSUMO U."
        rt.Cols(4).Name = "UNIDADES"
        rt.Cols(5).Name = "CONSUMO T."
        rt.Cols(6).Name = "LIBRAS R."
        For index = 1 To rt.Cols.Count - 1
            rt.Cols(index).Width = 300
            rt(0, index) = rt.Cols(index).Name
            If index > 2 Then
                rt.Cols(index).DataType = GetType(Decimal)
                rt.Cols(index).Format = "######0.00"
                rt.Cols(index).Width = 93
                rt.Cols(index).TextAlign = TextAlignEnum.RightCenter
                rt.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
    End Sub
    Private Sub limpia_ta()
        Dim i As Integer
        For i = 1 To 11
            ta(0, i) = tn(i)
            ta(1, i) = 0
        Next
        ta(0, 11) = "TOTALES"
        ta(1, 11) = 0
        ta.SetCellStyle(1, 11, ta.Styles("amarillo"))
    End Sub

    Private Sub pide_otros_datos()
        cpos.Enabled = False
        Estilos.Enabled = True
        Colores.Enabled = True
        Cortes.Enabled = True
        sigue.Visible = True
        Estilos.Focus()
    End Sub

    Private Sub limpia_variables()
        llena_los_combos()
        cpos.Enabled = True
        Estilos.Enabled = True
        Colores.Enabled = True
        Cortes.Enabled = True
        fecha.Enabled = False
        salas.Enabled = False
        seccion.Enabled = False
        ta.Enabled = False
        sigue.Visible = True
        Button2.Visible = False
        Regresa.Visible = True
        graba.Visible = False
        busca.Visible = False
        Cortes.Text = ""
        Estilos.Items.Clear()
        Colores.Items.Clear()
        limpia_ta()
        batch = ""
        Requi = ""
        fpo = ""
        fpos = ""
        salas.SelectedIndex = salas.Items.IndexOf("TEXSUN")
        setea_grid()
        setea_rt()
        cpos.Focus()
    End Sub

    Private Sub llena_grid()
        Dim dt As New DataTable()
        Dim ap As New DataTable()
        Dim i As Integer
        Dim res As DataRow()
        Dim codigo As String
        Dim dr As DataRow
        Dim strSQL As String = "SELECT ROLLOS.*,(PESO/YARDAS_I)*YARDAS AS LIBRAS, (SELECT DISTINCT PRECIO FROM FPO WHERE FPO.FPO = ROLLOS.FPO AND FPO.KNIT = ROLLOS.KNIT AND FPO.COLOR = ROLLOS.COLOR AND FPO.LOTE = ROLLOS.LOTE) AS COSTOF FROM ROLLOS WHERE CODIGO IN (" & knitr & ") AND COLOR IN (" & colorr & ") AND FPO IN  (" & fpos & ") AND YARDAS > 0 AND BATCH + STR(ROLLO) NOT IN (SELECT BATCH+STR(ROLLO) FROM REQ_D WHERE DESPACHADO = 'N') ORDER BY BATCH, ROLLO"
        llena_tablas(dt, strSQL, cnn)
        agrega_detalle_cpo(dt)
        i = dt.Rows.Count
        fg.Rows.Count = i + 1
        lineas = 1
        revisa_aprobacion(ap)
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("BATCH")
            fg(lineas, 2) = dr("ROLLO")
            fg(lineas, 3) = dr("KNIT")
            fg(lineas, 4) = dr("COLOR")
            fg(lineas, 5) = dr("ANCHO")
            fg(lineas, 6) = dr("FPO")
            fg(lineas, 7) = dr("LIBRAS")
            fg(lineas, 8) = dr("YARDAS")
            fg(lineas, 13) = dr("TONALIDAD")
            codigo = dr("CODIGO")
            fg(lineas, 12) = codigo
            If dr("COSTO") > 0 Then
                fg(lineas, 11) = dr("COSTOF")
            Else
                fg(lineas, 11) = 0
            End If
            res = ap.Select("BATCH = '" & fg(lineas, 1) & "' AND CODIGO = '" & codigo & "' AND ESTADO = 'PENDIENTE'")
            If res.Length > 0 Then
                fg.SetCellStyle(lineas, 1, fg.Styles("amarillo"))
            End If
            res = ap.Select("BATCH = '" & fg(lineas, 1) & "' AND CODIGO = '" & codigo & "' AND ESTADO = 'RECHAZADO'")
            If res.Length > 0 Then
                fg.SetCellStyle(lineas, 1, fg.Styles("rojo"))
            End If
            lineas = lineas + 1
        Next
    End Sub

    Private Sub revisa_aprobacion(ByRef ap As DataTable)
        Dim strsql As String = "SELECT * FROM AP_TELA WHERE BATCH IN (SELECT DISTINCT BATCH FROM ROLLOS WHERE CPO = '" & cpos.Text & "') AND ESTADO <> 'APROBADO'"
        llena_tablas(ap, strsql, cnn1)
    End Sub


    Private Sub sigue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sigue.Click
        Dim reqdup As String = ""
        Try

            If CInt(Cortes.Text) > 0 Then
                revisa_cpo(ok)
                If ok Then
                    lee_corte(ok, reqdup)
                    If ok Then
                        llena_fpos()
                        asigna_seccion()
                        activa_variables()
                    Else
                        MsgBox("ESTA ORDEN DE CORTE YA EXISTE !!", MsgBoxStyle.Critical, "POR FAVOR REVISE !!!!")
                    End If
                Else
                    MsgBox("NO EXISTE ESTILO-COLOR EN LA CPO", MsgBoxStyle.Critical, "POR FAVOR REVISE !!!!")
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub asigna_seccion()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim strsql As String = "SELECT * FROM PLAN_COSTURA_CP WHERE CPO = '" & cpos.Text & "' AND ESTILO = '" & Estilos.Text & "' AND COLOR = '" & Colores.Text & "'"
        llena_tablas(dt, strsql, cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            seccion.Text = dr("SECCION")
        Else
            MsgBox("No pude asignar la Sección", MsgBoxStyle.Critical, "Por favor verifique.")
        End If
    End Sub

    Private Sub revisa_cpo(ByRef ok As Boolean)
        Dim i As Integer
        Dim cp As New DataTable()
        Dim dr As DataRow
        Dim strsql As String = "SELECT * FROM CPO_D WHERE CPO = '" & cpos.Text & "' AND ESTILO = '" & Estilos.Text & "' AND COLOR = '" & Colores.Text & "'"
        llena_tablas(cp, strsql, cnn1)
        ok = False
        For Each dr In cp.Rows
            t(1) = dr("XS")
            t(2) = dr("S")
            t(3) = dr("M")
            t(4) = dr("L")
            t(5) = dr("XL")
            t(6) = dr("XL2")
            t(7) = dr("XL3")
            t(8) = dr("XL4")
            t(9) = dr("XL5")
            t(10) = dr("XL6")
            t(11) = dr("TOTAL")
            For i = 1 To 10
                If t(i) > 0 Then
                    ta.Cols(i).AllowEditing = True
                Else
                    ta.Cols(i).AllowEditing = False
                End If
            Next
            tallas_cortes(cpos.Text, Estilos.Text, Colores.Text, ta, 0, 1)
            ok = True
        Next
    End Sub

    Private Sub activa_variables()
        llena_consumo(ok)
        If ok Then
            llena_variables()
        Else
            MsgBox("El Estilo - Color seleccionado no tiene consumo!!!", MsgBoxStyle.Critical, "Por favor Revise !!!!")
            limpia_variables()
        End If
    End Sub

    Private Sub llena_variables()
        llena_grid()
        Estilos.Enabled = False
        Colores.Enabled = False
        Cortes.Enabled = False
        fecha.Enabled = True
        ta.Enabled = True
        salas.Enabled = True
        seccion.Enabled = True
        sigue.Visible = False
        graba.Visible = True
        busca.Visible = True
        ta.Focus()
    End Sub

    Private Sub llena_consumo(ByRef ok As Boolean)
        Dim dt As New DataTable()
        Dim i As Integer
        Dim dr As DataRow
        Dim Knites As String
        Dim colors As String
        Dim strSQL As String = "SELECT * FROM CONSUMO_TELA LEFT JOIN CODIGO_TELA ON CONSUMO_TELA.CODIGO = CODIGO_TELA.CODIGO WHERE ESTILO_CPO = '" & Estilos.Text & "' AND COLOR_CPO = '" & Colores.Text & "' ORDER BY CONSUMO_TELA.CODIGO, COLOR_TELA"
        llena_tablas(dt, strSQL, cnn1)
        ok = False
        i = dt.Rows.Count
        rt.Rows.Count = i + 1
        lineas = 1
        knitr = ""
        colorr = ""
        For Each dr In dt.Rows
            Knites = dr("CODIGO")
            colors = dr("COLOR_TELA")
            rt(lineas, 1) = dr("DESCRIPCION")
            rt(lineas, 2) = colors
            rt(lineas, 3) = dr("LIBRAS")
            rt(lineas, 4) = 0
            rt(lineas, 5) = 0
            rt(lineas, 6) = 0
            rt(lineas, 0) = Trim(Knites) + Trim(colors)
            ok = True
            If knitr.IndexOf(Knites) < 0 Then
                knitr = knitr + "'" + Knites + "',"
            End If
            If colorr.IndexOf("'" + colors + "'") < 0 Then
                colorr = colorr + "'" + colors + "',"
            End If
            lineas = lineas + 1
        Next
        If knitr.Length > 0 Then
            knitr = Mid(knitr, 1, knitr.Length - 1)
        End If
        If colorr.Length > 0 Then
            colorr = Mid(colorr, 1, colorr.Length - 1)
        End If
    End Sub

    Private Sub lee_corte(ByRef ok As Boolean, ByRef reqd As String)
        reqd = ""
        Dim co As New DataTable()
        Dim strsql As String = "SELECT DISTINCT REQ FROM CORTES LEFT JOIN REQ_D ON CORTES.CORTE = REQ_D.CORTE WHERE CORTES.CORTE = '" & Cortes.Text & "'"
        llena_tablas(co, strsql, cnn1)
        If co.Rows.Count > 0 Then
            ok = False
        Else
            If CInt(Cortes.Text) < 850000 Then
                ok = True
            End If
        End If
    End Sub

    Private Sub ta_rowcolchange(ByVal sender As Object, ByVal e As RowColEventArgs) Handles ta.AfterEdit
        Dim ok As Boolean
        TOTAL(ok)
    End Sub
    Private Sub TOTAL(ByRef SI As Boolean)
        Dim i As Integer
        Try
            ta(1, 11) = ta(1, 1) + ta(1, 2) + ta(1, 3) + ta(1, 4) + ta(1, 5) + ta(1, 6) + ta(1, 7) + ta(1, 8) + ta(1, 9) + ta(1, 10)
            For i = 1 To rt.Rows.Count - 1
                rt(i, 4) = ta(1, 11)
                rt(i, 5) = rt(i, 3) * rt(i, 4)
            Next
        Catch
            MsgBox("Por favor revise las tallas", MsgBoxStyle.OkOnly, "Existen valores no Validos !!!! ")
            SI = False
        End Try
    End Sub

    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cpos.Text) <> "" Then
                Estilos.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Estilos.Text) <> "" Then
                Colores.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Colores.Text) <> "" Then
                Cortes.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            Try
                Cortes.Text = Int(Cortes.Text)
            Catch
            End Try
            If Trim(Cortes.Text) <> "" And Cortes.Text <> "0" Then
                sigue.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed18(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(fecha.Text) <> "" Then
                salas.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed19(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(salas.Text) <> "" Then
                seccion.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub keypressed20(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(seccion.Text) <> "" Then
                graba.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub llena_combos(ByRef c As ComboBox, ByVal tipo As String, ByVal orden As String, ByRef ok As Boolean)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim cnn As New SqlClient.SqlConnection()
        c.Items.Clear()
        ok = True
        llena_tablas(dt, tipo, cnn)
        For Each dr In dt.Rows
            c.Items.Add(dr(orden))
            If orden = "ESTILO" Then
                Try
                    Clientes.Text = dr("CLIENTE")
                Catch
                End Try
            End If
        Next
        If c.Items.Count > 0 Then
            c.SelectedIndex = 0
        Else
            ok = False
        End If
    End Sub

    Private Sub Estilos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Estilos.SelectedIndexChanged
        llena_combos(Colores, "SELECT DISTINCT COLOR FROM CPO_D WHERE CPO = '" & cpos.Text & "' AND ESTILO = '" & Estilos.Text & "' AND ESTADO = 'A' ORDER BY COLOR", "COLOR", ok)
    End Sub

    Private Sub Regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Regresa.Click
        limpia_variables()
    End Sub
    ' ====================================== SUMA Y RESTA TELA =====================
    Private Sub fg_ValidateEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.ValidateEditEventArgs) Handles fg.ValidateEdit
        If e.Col = 9 Then
            If fg(e.Row, e.Col) = True Then
                resta(e.Row)
                fg(e.Row, 10) = False
            Else
                suma(e.Row)
                fg(e.Row, 10) = True
            End If
        End If

        If e.Col = 10 Then
            If fg(e.Row, 9) = True Then
                fg(e.Row, e.Col) = True
            Else
            End If
        End If
    End Sub

    Private Sub fg_afteredit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles fg.AfterEdit
        If e.Col = 10 Then
            If fg(e.Row, 9) = True Then
                fg(e.Row, e.Col) = True
            Else
            End If
        End If
    End Sub

    Private Sub suma(ByVal i As Integer)
        Dim p As Integer
        p = rt.FindRow(Trim(fg(i, 12)) + Trim(fg(i, 4)), 1, 0, True)
        If p > 0 Then
            rt(p, 6) = rt(p, 6) + fg(i, 7)
        End If

    End Sub

    Private Sub resta(ByVal i As Integer)
        Dim p As Integer
        p = rt.FindRow(Trim(fg(i, 12)) + Trim(fg(i, 4)), 1, 0, True)
        rt(p, 6) = rt(p, 6) - fg(i, 7)
    End Sub


    Private Sub graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba.Click
        Dim ok As Boolean = True
        Dim seguro As MsgBoxResult
        revisa_tallas(ok)
        revisa_datos(ok)
        If ok Then
            revisa_tallas_cpo(ok)
            If mensaje <> "" Then
                MsgBox(mensaje, MsgBoxStyle.Critical, "Por favor revise !!!")
            End If
        End If
        If ok Then
            cuenta_cortado("CORTES")
            cuenta_cortado("CORTES_P")
            revisa_cortado()
            If mensaje <> "" Then
                MsgBox(mensaje, MsgBoxStyle.Critical, "Por favor revise !!!")
            End If
            seguro = MsgBox("Seguro de Querer Actualizar?  ", MsgBoxStyle.YesNo, "Actualizando Registro !!!")
            If seguro = MsgBoxResult.Yes Then
                actualizaciones()
            End If
        End If
    End Sub

    '==============================  REVISION DE DATOS ======================
    Private Sub revisa_tallas(ByRef ok As Boolean)
        Dim malo As Boolean = True
        Try
            If CInt(ta(1, 11)) = 0 Then
                malo = False
                ok = False
            End If
        Catch
            malo = False
            ok = False
        End Try
        If Not malo Then
            MsgBox("La suma de las Tallas es igual a 0", MsgBoxStyle.Critical, "Por favor Revise !!!")
        End If
    End Sub

    Private Sub revisa_datos(ByRef ok As Boolean)
        Dim i As Integer
        Dim total As Integer
        Dim tn As Decimal
        Dim consumo As Decimal
        Dim req As Decimal
        Dim por As Decimal
        mensaje = ""
        For i = 1 To rt.Rows.Count - 1
            consumo = rt(i, 5)
            req = rt(i, 6)
            If consumo > req Then
                mensaje = mensaje + "Esta Asignando menos tela que la requerida, tejido: " + rt(i, 1) + vbLf
            End If
            total = total + req
            tn = tn + consumo
        Next
        Try
            por = (total * 100) / tn
        Catch
        End Try

        If por < 60 Then
            ok = False
            MsgBox("Aun no ha asignado Suficiente tela para el corte", MsgBoxStyle.Critical, "Por favor Revise !!!")
        End If
        ok = True
    End Sub

    Private Sub revisa_tallas_cpo(ByRef ok As Boolean)
        Dim i As Integer
        Dim talla As String
        Dim prendas As String
        Dim tal As String
        tal = "ST|" + CStr(ta(1, 1)) + "|" + CStr(ta(1, 2)) + "|" + CStr(ta(1, 3)) + "|" + CStr(ta(1, 4)) + "|" + CStr(ta(1, 5)) + "|" + CStr(ta(1, 6)) + "|" + CStr(ta(1, 7)) + "|" + CStr(ta(1, 8)) + "|" + CStr(ta(1, 9)) + "|" + CStr(ta(1, 10))
        Dim c As String() = tal.Split("|")
        For i = 1 To 10
            talla = tn(i)
            prendas = t(i)
            If c(i) > t(i) Then
                mensaje = mensaje + "Va a cortar mas de lo requerido en talla " + talla + " Req. " + prendas + " " + vbLf
                If t(i) = 0 Then
                    ok = False
                    Exit Sub
                End If
            End If
        Next
    End Sub

    Private Sub cuenta_cortado(ByVal tabla As String)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String = "SELECT CPO,ESTILO,COLOR,SUM(XS) AS XS,SUM(S) AS S, SUM(M) AS M,SUM(L) AS L,SUM(XL) AS XL, SUM(XL2) AS XL2, SUM(XL3) AS XL3, SUM(XL4) AS XL4, SUM(XL5) AS XL5, SUM(XL6) AS XL6, SUM(TOTAL) AS TOTAL FROM CORTES WHERE CPO = '" & cpos.Text & "' AND ESTILO = '" & Estilos.Text & "' AND COLOR = '" & Colores.Text & "' GROUP BY CPO,ESTILO,COLOR"
        llena_tablas(dt, strSQL, cnn1)
        ok = False
        For Each dr In dt.Rows
            co(1) = co(1) + dr("XS")
            co(2) = co(2) + dr("S")
            co(3) = co(3) + dr("M")
            co(4) = co(4) + dr("L")
            co(5) = co(5) + dr("XL")
            co(6) = co(6) + dr("XL2")
            co(7) = co(7) + dr("XL3")
            co(8) = co(8) + dr("XL4")
            co(9) = co(9) + dr("XL5")
            co(10) = co(10) + dr("XL6")
            co(11) = co(11) + dr("TOTAL")
        Next
    End Sub

    Private Sub revisa_cortado()
        Dim i As Integer
        Dim tal As String = "ST|" + CStr(ta(1, 1)) + "|" + CStr(ta(1, 2)) + "|" + CStr(ta(1, 3)) + "|" + CStr(ta(1, 4)) + "|" + CStr(ta(1, 5)) + "|" + CStr(ta(1, 6)) + "|" + CStr(ta(1, 7)) + "|" + CStr(ta(1, 8)) + "|" + CStr(ta(1, 9)) + "|" + CStr(ta(1, 10))
        Dim c As String() = tal.Split("|")
        Dim talla As String
        Dim prendas As Integer
        For i = 1 To 10
            talla = tn(i)
            prendas = (co(i) + c(i)) - t(i)
            If prendas > 0 Then
                mensaje = mensaje + "Ya se han cortado mas prendas de lo necesario en talla " + talla + " Req. " + CStr(t(i)) + " Cortado + este corte " + CStr(co(i) + c(i)) + "  " + vbLf
            End If
        Next
    End Sub

    ' ==================================== ACTUALIZA DATOS ===============================
    Private Sub actualizaciones()
        Dim ok As Boolean
        Suma_correlativo(ok)
        If ok Then
            graba_datos()
            ' Check imprimir tela opcional
            If ImprimirTela.Checked Then
                impresion()
            End If
            impresion_requisicion()
            limpia_variables()
        End If
    End Sub

    Private Sub Suma_correlativo(ByRef ok As Boolean)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim afectados As Integer
        Dim strSQL As String = "UPDATE CORRELATIVO SET REQ_TELA = REQ_TELA + 1"
        grabar_sql(strSQL, cnn, afectados)
        strSQL = "SELECT REQ_TELA FROM CORRELATIVO"
        llena_tablas(dt, strSQL, cnn)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            Requi = Format(CDec(dr("REQ_TELA")), "0000000000")
            ok = True
        Else
            ok = False
            MsgBox("Error al grabar el correlativo !!!!", MsgBoxStyle.Critical, "Comuniquese con Jesús Acosta")
        End If
    End Sub

    Private Sub graba_datos()
        Dim fechas As String = Format(CDate(fecha.Text), "yyyy-MM-dd")
        Dim afectados As Integer
        Dim strSQL As String
        Dim i As Integer
        Dim costo As Decimal
        Dim errorMessages As New StringBuilder()
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            ' =================== Encabezado Requisicion
            strSQL = "INSERT INTO REQ_E(REQ,CORTE,CPO,ESTILO,COLOR,F_REQ)" &
                     " VALUES ( '" & Requi & "','" & Cortes.Text & "','" &
                         cpos.Text & "','" &
                         Estilos.Text & "','" &
                         Colores.Text & "','" &
                         fechas & "')"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

            For i = 1 To fg.Rows.Count - 1
                If fg(i, 9) = True Then
                    fg(i, 7) = CDec(Format(fg(i, 7), h))
                    fg(i, 8) = CDec(Format(fg(i, 8), h))
                    ' =================== Detalle Requisicion
                    strSQL = "INSERT INTO REQ_D(REQ,BATCH,ROLLO,CORTE,PESO,YARDAS,DESPACHADO) " &
                             "VALUES ( '" & Requi & "','" & fg(i, 1) & "','" &
                             fg(i, 2) & "','" & Cortes.Text & "','" &
                             fg(i, 7) & "','" & fg(i, 8) & "','N')"
                    comando.CommandText = strSQL
                    afectados = comando.ExecuteNonQuery()

                    If batch.IndexOf(fg(i, 1)) = -1 Then
                        batch = batch + fg(i, 1) + " "
                    End If
                    If fpo.IndexOf(fg(i, 6)) = -1 Then
                        fpo = fpo + fg(i, 6) + " "
                    End If
                End If

                If fg(i, 10) = True Then
                    ' =================== Costos
                    Try
                        costo = fg(i, 11)
                    Catch ex As Exception
                        fg(i, 11) = 0
                    End Try
                    If fg(i, 11) Is Nothing Then
                        fg(i, 11) = 0
                    End If
                    strSQL = "INSERT INTO COSTO_TELA(CORTE,BATCH,ROLLO,CPO,ESTILO,COLOR,FECHA,COSTO,LIBRAS,YARDAS) " &
                             "VALUES ( '" & Cortes.Text & "','" & fg(i, 1) & "','" &
                                 fg(i, 2) & "','" &
                                 cpos.Text & "','" &
                                 Estilos.Text & "','" &
                                 Colores.Text & "','" &
                                 fechas & "','" &
                                 fg(i, 11) & "','" &
                                 fg(i, 7) & "','" &
                                 fg(i, 8) & "')"
                    comando.CommandText = strSQL
                    afectados = comando.ExecuteNonQuery()
                End If
            Next
            If batch.Length > 200 Then
                batch = Mid(batch, 1, 200)
            End If
            ' =================== Crea Cortes
            strSQL = "INSERT INTO CORTES (CORTE,CLIENTE,FPO,CPO,ESTILO,COLOR,XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6,TOTAL,FCORTE,FPROD,EXPORTADO,SECCION,BATCH) " &
             "VALUES ( '" & Cortes.Text & "','" &
                 Clientes.Text & "','" &
                 fpo & "','" &
                 cpos.Text & "','" &
                 Estilos.Text & "','" &
                 Colores.Text & "',0,0,0,0,0,0,0,0,0,0,0,'" &
                 fechas & "','" &
                 fechas & "','N','" & seccion.Text & "','" &
                 batch & "')"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

            strSQL = "INSERT INTO CORTES_S (CORTE,CLIENTE,FPO,CPO,ESTILO,COLOR,XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6,TOTAL,F_ICORTE,ESTADO,BATCH,SALA) " &
                     "VALUES ( '" & Cortes.Text & "','" &
                         Clientes.Text & "','" &
                         fpo & "','" &
                         cpos.Text & "','" &
                         Estilos.Text & "','" &
                         Colores.Text & "','" &
                         ta(1, 1) & "','" &
                         ta(1, 2) & "','" &
                         ta(1, 3) & "','" &
                         ta(1, 4) & "','" &
                         ta(1, 5) & "','" &
                         ta(1, 6) & "','" &
                         ta(1, 7) & "','" &
                         ta(1, 8) & "','" &
                         ta(1, 9) & "','" &
                         ta(1, 10) & "','" &
                         ta(1, 11) & "','" &
                         fechas & "','A','" &
                         batch & "','" & salas.Text & "')"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()

        Catch e As SqlClient.SqlException
            Try
                MsgBox("Inconsistencia en Datos" + vbLf + e.Message, MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() &
                                      " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try

        Finally
            cnn.Close()
        End Try

    End Sub

    Private Sub mal_correlativo()
        MsgBox("El no pude actualizar el correlativo", MsgBoxStyle.OkOnly, "Error en correlativo!!!")
        End
    End Sub


    '========================== IMPRESION REQUISICION ======================
    Private Sub impresion()
        Dim constr As String
        Dim empresa As String
        Dim strsql As String = "SELECT REQ_D.* ,CORTES.CPO,CORTES.ESTILO,CORTES.COLOR,F_REQ,KNIT ,ROLLOS.COLOR AS COLORK, CORTES.CLIENTE , (SELECT SALA FROM CORTES_S WHERE CORTES_S.CORTE = REQ_D.CORTE) AS SALA, ANCHO,TONALIDAD FROM REQ_D LEFT JOIN REQ_E ON REQ_E.REQ = REQ_D.REQ LEFT JOIN CORTES ON REQ_D.CORTE =CORTES.CORTE LEFT JOIN ROLLOS ON REQ_D.BATCH = ROLLOS.BATCH AND REQ_D.ROLLO = ROLLOS.ROLLO WHERE REQ_E.REQ = REQ_D.REQ AND REQ_D.REQ =  '" & Requi & "' ORDER BY KNIT,REQ_D.BATCH,REQ_D.ROLLO"
        Dim obj As Object
        Try
            obj = New empresas()
            constr = obj.constr
            empresa = obj.nombre
            Cursor = Cursors.WaitCursor
            ' load report
            c1r.Load("C:\TELAS\rep.xml", "REQUI")
            c1r.DataSource.ConnectionString = obj.conole
            c1r.DataSource.RecordSource = strsql
            c1r.Fields("Empresa").Text = empresa
            c1r.Render()
        Catch
        Finally
            Cursor = Cursors.Default
        End Try
        pd1 = c1r.Document
        pd1.PrinterSettings.Copies = 2
        pd1.Print()
    End Sub
    '========================== IMPRESION REQUISICION ======================
    Private Sub impresion_requisicion()
        Dim constr As String
        Dim empresa As String
        Dim strsql As String = "SELECT CORTES_S.*,CPO_D.ESCALA,T1,T2,T3,T4,T5,T6,T7,T8,T9,T0 FROM CORTES_S LEFT JOIN CPO_D ON CORTES_S.CPO = CPO_D.CPO AND CORTES_S.ESTILO = CPO_D.ESTILO AND CORTES_S.COLOR = CPO_D.COLOR LEFT JOIN E_TALLAS ON CPO_D.ESCALA = E_TALLAS.ESCALA  WHERE CORTE = '" & Cortes.Text & "'"
        Dim obj As Object
        Try
            obj = New empresas()
            constr = obj.constr
            empresa = obj.nombre
            Cursor = Cursors.WaitCursor
            ' load report
            c1r.Load("C:\TELAS\rep.xml", "CORTE_S")
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles busca.Click
        Dim forma As New Prendas_x_cortar()
        Cursor = Cursors.WaitCursor
        forma.Cpo.Text = cpos.Text
        forma.Estilo.Text = Estilos.Text
        forma.Colo.Text = Colores.Text
        forma.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub Cortes_sale(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cortes.Leave
        Dim ok As Boolean
        Dim reqd As String = ""
        lee_corte(ok, reqd)
        If Not ok Then
            'MsgBox("ORDEN DE CORTE YA EXISTE!! ", MsgBoxStyle.Critical, "POR FAVOR REVISE !!!!")
            Dim result As DialogResult = MessageBox.Show("Órden de Corte ya existente, ¿Desea reimprimirla?",
                              "Atención",
                              MessageBoxButtons.YesNo)
            If (result = DialogResult.Yes) Then
                impresion_requisicion()
            Else
                'Cortes.Text = ""
                Cortes.Select()
            End If

        End If
    End Sub

    Private Sub cpos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cpos.SelectedIndexChanged
        llena_combos(Estilos, "SELECT DISTINCT ESTILO,CLIENTE FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE CPO_D.CPO = '" & cpos.Text & "' AND ESTADO = 'A' ORDER BY ESTILO", "ESTILO", ok)
    End Sub
    Private Sub cpos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cpos.KeyPress
        AutoCompletar(cpos, e)
    End Sub

    Private Sub estilos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Estilos.KeyPress
        AutoCompletar(Estilos, e)
    End Sub

    Private Sub colores_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Colores.KeyPress
        AutoCompletar(Colores, e)
    End Sub

    Private Sub salas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles salas.KeyPress
        AutoCompletar(salas, e)
    End Sub

    Private Sub llena_fpos()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim strsql As String = "SELECT * FROM FPO_CPO WHERE CPO = '" & cpos.Text & "'"
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            If fpos.IndexOf(dr("FPO")) < 0 Then
                fpos = fpos + "'" + dr("FPO") + "',"
            End If
        Next
        If fpos.Length > 0 Then
            fpos = Mid(fpos, 1, fpos.Length - 1)
        End If
    End Sub

    Private Sub agrega_detalle_cpo(ByRef dt As DataTable)
        Dim dj As New DataTable
        Dim dr As DataRow
        Dim dd As DataRow()
        Dim jj As DataRow
        Dim strSQL As String = "SELECT ROLLOS.*,(PESO/YARDAS_I)*YARDAS AS LIBRAS, (SELECT DISTINCT PRECIO FROM FPO WHERE FPO.FPO = ROLLOS.FPO AND FPO.KNIT = ROLLOS.KNIT AND FPO.COLOR = ROLLOS.COLOR AND FPO.LOTE = ROLLOS.LOTE) AS COSTOF FROM ROLLOS WHERE CODIGO IN (" & knitr & ") AND COLOR IN (" & colorr & ") AND CPO = '" & cpos.Text & "' AND YARDAS > 0 AND BATCH + STR(ROLLO) NOT IN (SELECT BATCH+STR(ROLLO) FROM REQ_D WHERE DESPACHADO = 'N') ORDER BY BATCH, ROLLO"
        llena_tablas(dj, strSQL, cnn)
        For Each dr In dj.Rows
            Try
                dd = dt.Select("BATCH = '" & dr("BATCH") & "' AND ROLLO = '" & dr("ROLLO") & "'")
                For Each jj In dd
                    dj.Rows.Remove(jj)
                Next
            Catch
            End Try
        Next
        dt.Merge(dj)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
