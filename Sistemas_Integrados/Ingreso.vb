Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Ingreso
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim g As String = "######0"
    Dim r As String = "00000000"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Docto As System.Windows.Forms.TextBox
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Observa As System.Windows.Forms.TextBox
    Friend WithEvents Batch As System.Windows.Forms.TextBox
    Friend WithEvents Fpo As System.Windows.Forms.TextBox
    Friend WithEvents TROLLOS As System.Windows.Forms.TextBox
    Friend WithEvents knit As System.Windows.Forms.ComboBox
    Friend WithEvents Tipo As System.Windows.Forms.ComboBox
    Friend WithEvents crear As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Inicio As System.Windows.Forms.TextBox
    Friend WithEvents Colores As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lote As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Ingreso))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Docto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.Observa = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Batch = New System.Windows.Forms.TextBox()
        Me.Fpo = New System.Windows.Forms.TextBox()
        Me.TROLLOS = New System.Windows.Forms.TextBox()
        Me.knit = New System.Windows.Forms.ComboBox()
        Me.Colores = New System.Windows.Forms.ComboBox()
        Me.Tipo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.crear = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Inicio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lote = New System.Windows.Forms.TextBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Documento:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Docto
        '
        Me.Docto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Docto.Location = New System.Drawing.Point(120, 24)
        Me.Docto.MaxLength = 10
        Me.Docto.Name = "Docto"
        Me.Docto.Size = New System.Drawing.Size(112, 20)
        Me.Docto.TabIndex = 2
        Me.Docto.Text = ""
        Me.ToolTip1.SetToolTip(Me.Docto, "Numero de Documento, Lista de Empaque Etc.")
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Factura:"
        '
        'fecha
        '
        Me.fecha.CustomFormat = "dd/MM/yyyy"
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.fecha.Location = New System.Drawing.Point(120, 48)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(112, 20)
        Me.fecha.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.fecha, "Fecha de Recepcion de los Rollos de Tela.")
        '
        'Observa
        '
        Me.Observa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Observa.Location = New System.Drawing.Point(120, 72)
        Me.Observa.MaxLength = 20
        Me.Observa.Name = "Observa"
        Me.Observa.Size = New System.Drawing.Size(216, 20)
        Me.Observa.TabIndex = 6
        Me.Observa.Text = ""
        Me.ToolTip1.SetToolTip(Me.Observa, "Algun comentario del Ingreso de Tela.")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button3, Me.Button1, Me.Observa, Me.fecha, Me.Label2, Me.Label3, Me.Label1, Me.Docto})
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(960, 104)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Documento"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Bitmap)
        Me.Button3.Location = New System.Drawing.Point(880, 40)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 43
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton para Limpiar los valores ingresados SIN  grabar NADA.")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Bitmap)
        Me.Button1.Location = New System.Drawing.Point(824, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 44
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para Grabar toda la Información de la Recepcion de Tela.")
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Batch:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(136, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "FPO:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(264, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Knit"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(416, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Color:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(568, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Item"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(752, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "No. Rollos"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Batch
        '
        Me.Batch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Batch.Location = New System.Drawing.Point(8, 32)
        Me.Batch.MaxLength = 15
        Me.Batch.Name = "Batch"
        Me.Batch.Size = New System.Drawing.Size(120, 20)
        Me.Batch.TabIndex = 14
        Me.Batch.Text = ""
        Me.ToolTip1.SetToolTip(Me.Batch, "Numero de Batch de la Tela.")
        '
        'Fpo
        '
        Me.Fpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fpo.Location = New System.Drawing.Point(136, 32)
        Me.Fpo.MaxLength = 10
        Me.Fpo.Name = "Fpo"
        Me.Fpo.Size = New System.Drawing.Size(120, 20)
        Me.Fpo.TabIndex = 15
        Me.Fpo.Text = ""
        Me.ToolTip1.SetToolTip(Me.Fpo, "Número de FPO.")
        '
        'TROLLOS
        '
        Me.TROLLOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TROLLOS.Location = New System.Drawing.Point(752, 32)
        Me.TROLLOS.MaxLength = 10
        Me.TROLLOS.Name = "TROLLOS"
        Me.TROLLOS.Size = New System.Drawing.Size(72, 20)
        Me.TROLLOS.TabIndex = 16
        Me.TROLLOS.Text = ""
        Me.TROLLOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.TROLLOS, "Número de Rollos del Batch.  Este dato nos servira para Crear tantas lineas de de" & _
        "talle como rollos tenga el Batch.   Luego Modificaremos los Datos de Numero de R" & _
        "ollo, Peso y Yardas.")
        '
        'knit
        '
        Me.knit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.knit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.knit.Location = New System.Drawing.Point(264, 32)
        Me.knit.Name = "knit"
        Me.knit.Size = New System.Drawing.Size(144, 21)
        Me.knit.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.knit, "Tipo de Tejido.")
        '
        'Colores
        '
        Me.Colores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Colores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colores.Location = New System.Drawing.Point(416, 32)
        Me.Colores.Name = "Colores"
        Me.Colores.Size = New System.Drawing.Size(144, 21)
        Me.Colores.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.Colores, "Color del Batch.")
        '
        'Tipo
        '
        Me.Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tipo.Items.AddRange(New Object() {"TELA", "CUELLOS", "PUÑOS"})
        Me.Tipo.Location = New System.Drawing.Point(568, 32)
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Size = New System.Drawing.Size(96, 21)
        Me.Tipo.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.Tipo, "Tipo de Item.  Tela, Cuellos y Puños Etc.")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.Colores, Me.TROLLOS, Me.Label4, Me.Label8, Me.Batch, Me.Label6, Me.knit, Me.Tipo, Me.Label7, Me.Fpo, Me.Label5, Me.Label9, Me.crear, Me.Label10, Me.Inicio, Me.Label11, Me.lote})
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(960, 64)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de los Batch"
        '
        'crear
        '
        Me.crear.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.crear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.crear.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crear.ForeColor = System.Drawing.Color.Black
        Me.crear.Image = CType(resources.GetObject("crear.Image"), System.Drawing.Bitmap)
        Me.crear.Location = New System.Drawing.Point(912, 16)
        Me.crear.Name = "crear"
        Me.crear.Size = New System.Drawing.Size(35, 35)
        Me.crear.TabIndex = 46
        Me.crear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.crear, "Presione este Boton para crear los Registros de los Rollos.")
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(832, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Rollo Inicial"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Inicio
        '
        Me.Inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inicio.Location = New System.Drawing.Point(832, 32)
        Me.Inicio.MaxLength = 4
        Me.Inicio.Name = "Inicio"
        Me.Inicio.Size = New System.Drawing.Size(72, 20)
        Me.Inicio.TabIndex = 25
        Me.Inicio.Text = ""
        Me.Inicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.Inicio, "Número del Rollo en que comienza la secuencia.")
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(672, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 16)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "No. Lote"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lote
        '
        Me.lote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lote.Location = New System.Drawing.Point(672, 32)
        Me.lote.MaxLength = 5
        Me.lote.Name = "lote"
        Me.lote.Size = New System.Drawing.Size(72, 20)
        Me.lote.TabIndex = 25
        Me.lote.Text = ""
        Me.lote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.lote, "Número de Rollos del Batch.  Este dato nos servira para Crear tantas lineas de de" & _
        "talle como rollos tenga el Batch.   Luego Modificaremos los Datos de Numero de R" & _
        "ollo, Peso y Yardas.")
        '
        'fg
        '
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{TextAlign:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1{Text" & _
        "Align:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{TextAlign:RightCenter;TextAlign" & _
        "Fixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{TextAlign:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{TextA" & _
        "lign:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{TextAlign:RightCenter;TextAlignF" & _
        "ixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "6{TextAlign:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{TextAl" & _
        "ign:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{TextAlign:RightCenter;TextAlignFi" & _
        "xed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "9{TextAlign:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 184)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(968, 464)
        Me.fg.StyleInfo = "Normal{Font:Microsoft Sans Serif, 8.25pt;BackColor:White;ForeColor:Black;TextAlig" & _
        "n:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:167, 232, 245;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:95, 156, 239" & _
        ";Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:255, 128, 128;ForeColor:Wh" & _
        "ite;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{BackColor:255, 128, 128;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:" & _
        "Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{" & _
        "BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor" & _
        ":Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:95, 156, 239;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subt" & _
        "otal1{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;Fore" & _
        "Color:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{Ba" & _
        "ckColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;Fo" & _
        "reColor:White;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.fg, "Para Eliminar la fila  Presione  Doble-Click")
        '
        'Ingreso
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(984, 668)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.fg, Me.GroupBox2, Me.GroupBox1})
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ingreso"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Rollos a Bodega"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Ingreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Docto.KeyPress, AddressOf keypressed1
        AddHandler fecha.KeyPress, AddressOf keypressed2
        AddHandler Observa.KeyPress, AddressOf keypressed3
        AddHandler Batch.KeyPress, AddressOf keypressed4
        AddHandler Fpo.KeyPress, AddressOf keypressed5
        AddHandler knit.KeyPress, AddressOf keypressed6
        AddHandler Colores.KeyPress, AddressOf keypressed7
        AddHandler Tipo.KeyPress, AddressOf keypressed8
        AddHandler lote.KeyPress, AddressOf keypressed8a
        AddHandler TROLLOS.KeyPress, AddressOf keypressed9
        AddHandler Inicio.KeyPress, AddressOf keypressed10
        limpia_variables()
    End Sub


    Private Sub setea_grid()
        Dim index As Integer
        fg.Rows.Count = 1
        fg.Cols.Count = 14
        fg.Cols(0).Width = 15
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Name = "BATCH"
        fg.Cols(2).Name = "FPO"
        fg.Cols(3).Name = "CLIENTE"
        fg.Cols(4).Name = "ITEM"
        fg.Cols(5).Name = "F.KNIT"
        fg.Cols(6).Name = "COLOR"
        fg.Cols(7).Name = "LOTE"
        fg.Cols(8).Name = "No.ROLLO"
        fg.Cols(9).Name = "LIBRAS"
        fg.Cols(10).Name = "YARDAS"
        fg.Cols(11).Name = "BARRA"
        fg.Cols(12).Visible = False
        fg.Cols(13).Visible = False
        fg.Cols(8).DataType = GetType(Integer)
        fg.Cols(9).Format = r
        fg.Cols(8).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(8).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(9).DataType = GetType(Decimal)
        fg.Cols(9).Format = "######.0"
        fg.Cols(9).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(10).DataType = GetType(Decimal)
        fg.Cols(10).Format = "######.0"
        fg.Cols(10).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(11).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(10).TextAlignFixed = TextAlignEnum.CenterCenter
        For index = 1 To fg.Cols.Count - 1
            If index < 8 Then
                fg.Cols(index).TextAlign = TextAlignEnum.LeftCenter
                fg.Cols(index).TextAlignFixed = TextAlignEnum.LeftCenter
            End If
            fg.Cols(index).Width = 90
            fg(0, index) = fg.Cols(index).Name
        Next
        fg.Cols(7).Width = 60
        fg.Cols(8).Width = 70
        Dim s As C1.Win.C1FlexGrid.CellStyle
        s = fg.Styles.Add("SELECTO")
        s.ForeColor = Color.Black
        s.BackColor = Color.White
    End Sub

    Private Sub limpia_variables()
        Docto.Text = ""
        Observa.Text = "S/O"
        Batch.Text = ""
        Fpo.Text = ""
        Colores.Text = ""
        Tipo.Text = ""
        lote.Text = "1"
        TROLLOS.Text = "1"
        Inicio.Text = "1"
        setea_grid()
        Docto.Focus()
    End Sub

    Private Sub busca_fpos()
        knit.Items.Clear()
        Colores.Items.Clear()
        Dim knites As String
        Dim colos As String
        Dim i As Integer
        Dim dr As DataRow
        Tipo.SelectedIndex = 0
        Dim strSQL As String = "SELECT * FROM FPO WHERE FPO= '" & Fpo.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            knites = dr("KNIT")
            colos = dr("COLOR")
            i = knit.Items.IndexOf(knites)
            If i = -1 Then
                knit.Items.Add(knites)
            End If
            i = Colores.Items.IndexOf(colos)
            If i = -1 Then
                Colores.Items.Add(colos)
            End If

        Next
        If knit.Items.Count > 0 Then
            knit.SelectedIndex = 0
        End If
        If Colores.Items.Count > 0 Then
            Colores.SelectedIndex = 0
        End If
    End Sub

    Private Sub crear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crear.Click
        Dim bien As Boolean
        revisa_batch(bien)
        If bien Then
            revisa_po_tejido_color(bien)
        End If
        If bien Then
            crea_rollos()
            limpia_batch()
            Batch.Focus()
        End If
    End Sub

    Private Sub revisa_batch(ByRef bien As Boolean)
        bien = True
        If Trim(Batch.Text) = "" Then
            mensaje("No.Batch")
            bien = False
        End If
        If Trim(Fpo.Text) = "" Then
            mensaje("FPO")
            bien = False
        End If
        If Trim(knit.Text) = "" Then
            mensaje("Knit")
            bien = False
        End If
        If Trim(Colores.Text) = "" Then
            mensaje("Color")
            bien = False
        End If
        If IsNumeric(lote.Text) = False Then
            mensaje("Dato de Lote No Numerico")
            bien = False
        Else
            If CInt(lote.Text) = 0 Or CInt(lote.Text) > 999 Then
                mensaje("Error en No. Lote")
                bien = False
            End If
        End If
        If IsNumeric(TROLLOS.Text) = False Then
            mensaje("Dato de Rollos No Numerico")
            bien = False
        Else
            If CInt(TROLLOS.Text) = 0 Or CInt(TROLLOS.Text) > 100 Then
                mensaje("No de Rollos")
                bien = False
            End If
        End If
        If IsNumeric(Inicio.Text) = False Then
            mensaje("Dato de Rollo Inicial No Numerico")
            bien = False
        Else
            If CInt(Inicio.Text) = 0 Or CInt(Inicio.Text) > 9999 Then
                mensaje("Rollo Inicial")
                bien = False
            End If
        End If
    End Sub

    Private Sub crea_rollos()
        Dim i As Integer
        Dim rollos As Integer = CInt(TROLLOS.Text)
        Dim yfiber As String = ""
        Dim cliente As String = ""
        Dim ctela As String = ""
        Dim bien As Boolean
        Dim codigo As String = ""
        busca_datos_fpo(yfiber, cliente, bien, ctela, codigo)
        If Not bien Then
            MsgBox("Por favor revise !!!! ", MsgBoxStyle.OKOnly, "Combinacion Fpo, Knit y Color No existe en FPO !!!! ")
            Exit Sub
        End If
        If ctela = "" Then
            MsgBox("Por favor revise !!!! ", MsgBoxStyle.OKOnly, "Aun no se ha ingresado el Codigo Texpasa en la FPO !!!! ")
            Exit Sub
        End If
        If CInt(codigo) = 0 Then
            MsgBox("Por favor revise !!!! ", MsgBoxStyle.OKOnly, "Aun no se ha ingresado el Codigo de la Tela en el FPO !!!! ")
            Exit Sub
        End If
        lineas = fg.Rows.Count - 1
        fg.Rows.Count = lineas + rollos + 1
        For i = 1 To 8
            fg.Cols(i).AllowEditing = True
        Next
        For i = 1 To rollos
            fg(lineas + i, 0) = ""
            fg(lineas + i, 1) = Batch.Text
            fg(lineas + i, 2) = Fpo.Text
            fg(lineas + i, 3) = cliente
            fg(lineas + i, 4) = Tipo.Text
            fg(lineas + i, 5) = knit.Text
            fg(lineas + i, 6) = Colores.Text
            fg(lineas + i, 7) = lote.Text
            fg(lineas + i, 8) = Format(i + (Inicio.Text - 1), r)
            fg(lineas + i, 9) = 0
            fg(lineas + i, 10) = 0
            fg(lineas + i, 12) = ctela
            fg(lineas + i, 13) = codigo
        Next
        For i = 1 To 8
            fg.Cols(i).AllowEditing = False
        Next

    End Sub

    Private Sub limpia_batch()
        Batch.Text = ""
        Fpo.Text = ""
        TROLLOS.Text = "1"
        Inicio.Text = "1"
        knit.Items.Clear()
        Colores.Items.Clear()
        knit.Text = ""
        Colores.Text = ""
    End Sub

    Private Sub busca_datos_fpo(ByRef YFIBER As String, ByRef cliente As String, ByRef BIEN As Boolean, ByRef Ctela As String, ByRef codigo As String)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String = "SELECT * FROM FPO WHERE FPO= '" & Fpo.Text & "' AND TIPO = '" & Tipo.Text & "' AND KNIT = '" & knit.Text & "' AND COLOR = '" & Colores.Text & "' AND LOTE = '" & lote.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        If dt.Rows.Count > 0 Then
            For Each dr In dt.Rows
                cliente = dr("cliente")
                YFIBER = dr("YFIBER")
                Try
                    Ctela = dr("CODIGO_TELA")
                Catch
                End Try
                Try
                    codigo = dr("CODIGO")
                Catch
                    codigo = "00000000"
                End Try
                BIEN = True
            Next
        Else
            BIEN = False
        End If
    End Sub

    Private Sub fg_ValidateEdit(ByVal sender As Object, ByVal e As ValidateEditEventArgs) Handles fg.ValidateEdit
        If e.Col = 9 Or e.Col = 10 Then
            If IsNumeric(fg(e.Row, e.Col)) = False Then
                fg(e.Row, e.Col) = 0
            End If
        End If
    End Sub

    Private Sub fg_afteredit(ByVal sender As Object, ByVal e As RowColEventArgs) Handles fg.AfterEdit
        subtotales()
    End Sub

    Private Sub subtotales()
        Try
            fg.Subtotal(AggregateEnum.Clear)
            fg.Subtotal(AggregateEnum.Sum, 1, 1, 6, 9, "Totales {0}")
            fg.Subtotal(AggregateEnum.Sum, 1, 1, 6, 10, "Totales {0}")
            fg.Subtotal(AggregateEnum.Sum, 0, 0, 0, 9, "Gran TOTAL ---->")
            fg.Subtotal(AggregateEnum.Sum, 0, 0, 0, 10, "Gran TOTAL ---->")
        Catch
        End Try
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        Dim filasel As Integer
        Dim colsel As Integer
        filasel = fg.RowSel
        colsel = fg.ColSel
        If filasel > 0 And colsel < 9 Then
            If Trim(fg(filasel, 1)) <> "" Then
                fg(filasel, 0) = "-->"
                Dim seguro As MsgBoxResult
                seguro = MsgBox("Atencion: Desea Eliminar Esta Linea?", MsgBoxStyle.YesNo, "Eliminacion de Lineas")
                If seguro = MsgBoxResult.Yes Then
                    elimina_linea(filasel)
                Else
                    fg(filasel, 0) = ""
                End If
            End If
        End If
    End Sub

    Private Sub elimina_linea(ByVal filasel As Integer)
        fg.Rows.Remove(filasel)
        subtotales()
    End Sub
    '================================== HANDLERS ================================

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Docto.Text) <> "" Then
                fecha.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(fecha.Text) <> "" Then
                Observa.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Observa.Text) <> "" Then
                Batch.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Batch.Text) <> "" Then
                Fpo.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Fpo.Text) <> "" Then
                busca_fpos()
                knit.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed6(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(knit.Text) <> "" Then
                Colores.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed7(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Colores.Text) <> "" Then
                Tipo.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed8(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Tipo.Text) <> "" Then
                lote.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed8a(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(lote.Text) <> "" And IsNumeric(lote.Text) = True Then
                TROLLOS.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed9(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(TROLLOS.Text) <> "" And IsNumeric(TROLLOS.Text) = True Then
                Format(CInt(TROLLOS.Text), g)
                Inicio.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed10(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Inicio.Text) <> "" And IsNumeric(Inicio.Text) = True Then
                Format(CInt(Inicio.Text), g)
                crear.Focus()
            End If
        End If
    End Sub

    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OKOnly, var + " NO VALIDO !!!! ")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Atencion: Esta Seguro de Anular todo lo Ingresado en este Documento?", MsgBoxStyle.YesNo, "ANULA DATOS INGRESADOS !!!")
        If seguro = MsgBoxResult.Yes Then
            limpia_variables()
        End If
    End Sub



    ' ========================================== CHEQUEO DE DATOS ============================================
    Private Sub chequeo_documento(ByRef bien As Boolean)
        Dim duplicado As String = " "
        Dim batche As String
        Dim pos As Integer
        Dim i As Integer
        Dim rol As String
        bien = True
        If Trim(Docto.Text) = "" Then
            mensaje("No.Documento")
            bien = False
        End If
        If Trim(Observa.Text) = "" Then
            mensaje("Ingrese No.Factura.")
            bien = False
        End If
        EXISTE = False
        busca_documento(EXISTE)
        If EXISTE Then
            bien = False
            MsgBox("Por favor revise!!!!    Este Documento ya fue captado anteriormente.", MsgBoxStyle.OKOnly, "No. DOCUMENTO DUPLICADO")
            Exit Sub
        End If
        If fg.Rows.Count - 1 = 0 Then
            MsgBox("Por favor revise!!!!    Aun no ha Ingresado Ningun Rollo.", MsgBoxStyle.OKOnly, "No. DOCUMENTO VACIO")
            bien = False
            Exit Sub
        End If
        For i = 1 To fg.Rows.Count - 1
            rol = CStr(Format(CDec(fg(i, 8)), "0000000"))
            batche = CStr(fg(i, 1)) + rol
            If Trim(batche) <> "" Then
                chequea_datos_grid(i, bien)
                If Not bien Then
                    Exit Sub
                End If
                pos = duplicado.IndexOf(batche)
                If pos <> -1 And Trim(batche) <> "" Then
                    MsgBox("Por favor revise!!!!    El Rollo:" + CStr(fg(i, 8)) + " del Batch: " + CStr(fg(i, 1)) + " esta Duplicado ", MsgBoxStyle.OKOnly, "HAY DATOS DUPLICADOS EN LOS ROLLOS")
                    bien = False
                    Exit Sub
                Else
                    duplicado = duplicado + batche + " "
                    EXISTE = False
                    busca_rollo(fg(i, 1), CInt(fg(i, 8)), EXISTE)
                    If EXISTE Then
                        bien = False
                        MsgBox("Por favor revise!!!!    El Rollo: " + CStr(fg(i, 8)) + "  del Batch: " + CStr(fg(i, 1)) + " ya ingreso a Inventario con otro Documento. ", MsgBoxStyle.OKOnly, "HAY DATOS DUPLICADOS EN LOS ROLLOS")
                        Exit Sub
                    End If
                End If
            End If
        Next
        If Trim(duplicado) = "" Then
            MsgBox("Por favor revise!!!!    Aun no ha Ingresado Ningun Rollo.", MsgBoxStyle.OKOnly, "No. DOCUMENTO VACIO")
            bien = False
            Exit Sub
        End If
    End Sub

    Private Sub busca_documento(ByRef existe As Boolean)
        existe = False
        Dim strSQL As String = "SELECT * FROM EMOVTO WHERE DOCTO = '" & Docto.Text & "' AND TMOVTO = '1' "
        llena_tablas(dt, strSQL, cnn)
        If dt.Rows.Count > 0 Then
            existe = True
        End If
    End Sub

    Private Sub busca_rollo(ByVal nobatch As String, ByVal norollo As String, ByRef existe As Boolean)
        existe = False
        Dim strSQL As String = "SELECT * FROM ROLLOS WHERE BATCH = '" & nobatch & "' AND ROLLO = '" & norollo & "'"
        llena_tablas(dt, strSQL, cnn)
        If dt.Rows.Count > 0 Then
            existe = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim bien As Boolean = True
        fg.Subtotal(AggregateEnum.Clear)
        chequeo_documento(bien)
        If bien Then
            graba_documento()
            limpia_variables()
        Else
            subtotales()
        End If
    End Sub

    Private Sub chequea_datos_grid(ByVal j As Integer, ByRef ok As Boolean)
        Dim barra As String = fg(j, 11)
        If fg(j, 8) = 0 Then
            MsgBox("Por favor revise!!!!   Exiten Rollos con Numero 0 ", MsgBoxStyle.OKOnly, "NUMERO DE ROLLO INVALIDO")
            ok = False
            Exit Sub
        End If
        If fg(j, 9) = 0 Then
            MsgBox("Por favor revise!!!!   Exiten Rollos sin Libras ", MsgBoxStyle.OKOnly, "PESO INVALIDO")
            ok = False
            Exit Sub
        End If
        If fg(j, 10) = 0 Then
            MsgBox("Por favor revise!!!!   Exiten Rollos sin Yardaje", MsgBoxStyle.OKOnly, "YARDAJE INVALIDO")
            ok = False
            Exit Sub
        End If
        If barra = "" Then
            MsgBox("Por favor revise!!!!   Exiten Rollos con Codigo de Barras Invalido", MsgBoxStyle.OKOnly, "CODIGO DE BARRAS INVALIDO ")
            ok = False
            Exit Sub
        ElseIf barra.Length < 8 Or barra.Length > 9 Then
            MsgBox("Por favor revise!!!!   Exiten Rollos con Codigo de Barras Invalido", MsgBoxStyle.OKOnly, "CODIGO DE BARRAS INVALIDO ")
            ok = False
            Exit Sub
        End If
    End Sub

    Private Sub graba_documento()
        graba_encabezado()
        graba_Detalle()
    End Sub

    Private Sub graba_encabezado()
        Dim recordsEffected As Integer
        Dim strSQL As String
        Dim fechas As String
        fechas = Format(CDate(fecha.Text), "yyyy-MM-dd")
        strSQL = "INSERT INTO EMOVTO (DOCTO, TMOVTO, FECHA, COMENTARIO ) " & _
                 "VALUES ( '" & Docto.Text & "','1','" & _
                     fechas & "','" & _
                     Observa.Text & "')"
        grabar_sql(strSQL, cnn, recordsEffected)
    End Sub

    Private Sub graba_Detalle()
        Dim i As Integer
        For i = 1 To fg.Rows.Count - 1
            If Trim(fg(i, 1)) <> "" Then
                graba_rollos(i)
            End If
        Next
    End Sub


    Private Sub graba_rollos(ByVal j As Integer)
        Dim recordsEffected As Integer
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim codigo_t As String = ""
        Dim strSQL As String
        Dim BATCH As String
        Dim ROLLO As String
        Dim FPO As String
        Dim CPO As String = ""
        Dim CLIENTES As String = ""
        Dim TIPO As String
        Dim KNITS As String
        Dim COLO As String
        Dim PESO As Decimal
        Dim YARDAS_I As Decimal
        Dim ANCHO As String = ""
        Dim YFIBER As String = ""
        Dim YFINISH As String = ""
        Dim COSTO As Decimal
        Dim CORTE As String = "00000"
        Dim LOT As String
        Dim TELA As String = ""
        Dim BARRA As String
        BATCH = CStr(fg(j, 1))
        ROLLO = CInt(fg(j, 8))
        FPO = CStr(fg(j, 2))
        TIPO = CStr(fg(j, 4))
        KNITS = CStr(fg(j, 5))
        COLO = CStr(fg(j, 6))
        LOT = CStr(fg(j, 7))
        BARRA = CStr(fg(j, 11))
        strSQL = "SELECT * FROM FPO WHERE FPO= '" & FPO & "' AND TIPO = '" & TIPO & "' AND KNIT = '" & KNITS & "' AND COLOR = '" & COLO & "' AND LOTE ='" & LOT & "'"
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            CPO = dr("CPO")
            CLIENTES = dr("CLIENTE")
            PESO = fg(j, 9)
            YARDAS_I = fg(j, 10)
            ANCHO = "00"
            YFIBER = dr("YFIBER")
            YFINISH = dr("YFINISH")
            COSTO = dr("PRECIO")
            TELA = dr("CODIGO_TELA")
            Try
                codigo_t = dr("CODIGO")
            Catch
                codigo_t = "00000000"
            End Try
        Next
        strSQL = "INSERT INTO ROLLOS (BATCH, ROLLO, FPO, CPO, CLIENTE, TIPO, KNIT, COLOR, PESO, YARDAS_I, YARDAS, ANCHO, YFIBER, YFINISH, COSTO, LOTE, ACTIVO,CODIGO_TELA,BARRA,CODIGO ) " & _
                                                 "VALUES ( '" & BATCH & "','" & _
                                                     ROLLO & "','" & _
                                                     FPO & "','" & _
                                                     CPO & "','" & _
                                                     CLIENTES & "','" & _
                                                     TIPO & "','" & _
                                                     KNITS & "','" & _
                                                     COLO & "','" & _
                                                     PESO & "','" & _
                                                     YARDAS_I & "','" & _
                                                     YARDAS_I & "','" & _
                                                     ANCHO & "','" & _
                                                     YFIBER & "','" & _
                                                     YFINISH & "','" & _
                                                     COSTO & "','" & _
                                                     LOT & "','S','" & TELA & "','" & BARRA & "','" & codigo_t & "')"
        grabar_sql(strSQL, cnn, recordsEffected)
        Dim fechas As String
        fechas = Format(CDate(fecha.Text), "yyyy-MM-dd")
        strSQL = "INSERT INTO DMOVTO (DOCTO, TMOVTO, BATCH, ROLLO, FECHA, CLIENTE, FPO, CPO, CORTE, YARDAS, LIBRAS, PRECIO) " & _
                                                 "VALUES ( '" & Docto.Text & "','1','" & _
                                                     BATCH & "','" & _
                                                     ROLLO & "','" & _
                                                     fechas & "','" & _
                                                     CLIENTES & "','" & _
                                                     FPO & "','" & _
                                                     CPO & "','" & _
                                                     CORTE & "','" & _
                                                     YARDAS_I & "','" & _
                                                     PESO & "','" & _
                                                     COSTO & "')"
        grabar_sql(strSQL, cnn, recordsEffected)
        Try
            strSQL = "INSERT INTO AP_TELA (BATCH, CODIGO, ESTADO, FECHA_ING, FECHA, REVISADO, COMENTARIOS, FACTURA) " & _
                                                     "VALUES ( '" & BATCH & "','" & codigo_t & "','PENDIENTE','" & _
                                                         fechas & "','" & fechas & "','','','" & Observa.Text & "')"
            grabar_sql(strSQL, cnn, recordsEffected)
        Catch
        End Try
        strSQL = "UPDATE FPO SET RECIBIDAS = RECIBIDAS + " & PESO & " WHERE FPO = '" & FPO & "' AND TIPO = '" & TIPO & "' AND KNIT = '" & KNITS & "' AND COLOR = '" & COLO & "' AND LOTE = '" & LOT & "'"
        grabar_sql(strSQL, cnn, recordsEffected)
    End Sub

    Private Sub revisa_po_tejido_color(ByRef bien As Boolean)
        bien = False
        Dim dt As New DataTable()
        Dim strSQL As String = "SELECT * FROM FPO WHERE FPO = '" & Fpo.Text & "' AND KNIT = '" & knit.Text & "' AND COLOR = '" & Colores.Text & "' AND TIPO = '" & Tipo.Text & "' AND LOTE = '" & lote.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        If dt.Rows.Count > 0 Then
            bien = True
        Else
            MsgBox("Por favor revise !!!! ", MsgBoxStyle.OKOnly, "Combinacion Fpo, Knit, Color y Lote No existe en FPO !!!! ")
        End If
    End Sub

End Class
