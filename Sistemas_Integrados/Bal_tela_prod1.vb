Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Bal_tela_prod1
    Inherits System.Windows.Forms.Form
    Dim dt As New DataTable()
    Dim inv As New DataTable()
    Dim fpos As New DataTable()
    Dim con As New DataTable()
    Dim wip As New DataTable()
    Dim strsql As String
    Dim pd As Date
    Dim fec As Date
    Dim fei As Date
    Dim hoy As Date = Today
    Dim dis As Integer = hoy.DayOfWeek

    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim tsd As New DataTable()
    Dim obj As New empresas()
    Dim path As String = "c:\reportes\balance.xls"
    Dim a As Integer = Screen.PrimaryScreen.Bounds.Height - 30
    Dim l As Integer = Screen.PrimaryScreen.Bounds.Width - 5
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents si As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Cliente As System.Windows.Forms.ComboBox
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents Impri As System.Windows.Forms.Button
    Friend WithEvents Ex As System.Windows.Forms.Button
    Friend WithEvents nc As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Te As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Bal_tela_prod1))
        Me.Cliente = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.si = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.R1 = New System.Windows.Forms.Button()
        Me.Impri = New System.Windows.Forms.Button()
        Me.Ex = New System.Windows.Forms.Button()
        Me.Te = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.nc = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.Te, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cliente
        '
        Me.Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cliente.Location = New System.Drawing.Point(112, 8)
        Me.Cliente.MaxLength = 20
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(256, 28)
        Me.Cliente.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Cliente, "Lista de Clientes")
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 24)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Cliente:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'si
        '
        Me.si.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.si.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.si.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.si.ForeColor = System.Drawing.Color.Black
        Me.si.Image = CType(resources.GetObject("si.Image"), System.Drawing.Bitmap)
        Me.si.Location = New System.Drawing.Point(400, 8)
        Me.si.Name = "si"
        Me.si.Size = New System.Drawing.Size(35, 35)
        Me.si.TabIndex = 53
        Me.si.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.si, "Presione este icono para buscar efectuar el Balance de Tela")
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.R1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Bitmap)
        Me.R1.Location = New System.Drawing.Point(400, 8)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(35, 35)
        Me.R1.TabIndex = 55
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R1.Visible = False
        '
        'Impri
        '
        Me.Impri.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Impri.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Impri.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Impri.ForeColor = System.Drawing.Color.Black
        Me.Impri.Image = CType(resources.GetObject("Impri.Image"), System.Drawing.Bitmap)
        Me.Impri.Location = New System.Drawing.Point(448, 8)
        Me.Impri.Name = "Impri"
        Me.Impri.Size = New System.Drawing.Size(35, 35)
        Me.Impri.TabIndex = 58
        Me.Impri.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Impri, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Impri.Visible = False
        '
        'Ex
        '
        Me.Ex.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Ex.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Ex.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ex.ForeColor = System.Drawing.Color.Black
        Me.Ex.Image = CType(resources.GetObject("Ex.Image"), System.Drawing.Bitmap)
        Me.Ex.Location = New System.Drawing.Point(496, 8)
        Me.Ex.Name = "Ex"
        Me.Ex.Size = New System.Drawing.Size(35, 35)
        Me.Ex.TabIndex = 59
        Me.Ex.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Ex, "Presione este Boton si Desea  convertir a Excel los datos del  Inventario.")
        Me.Ex.Visible = False
        '
        'Te
        '
        Me.Te.AllowEditing = False
        Me.Te.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Te.BackColor = System.Drawing.Color.White
        Me.Te.ColumnInfo = "18,1,0,0,0,85,Columns:0{Width:0;AllowEditing:False;DataType:System.String;TextAli" & _
        "gn:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1{Width:450;Caption:""DESCRIPCION DE LA" & _
        " TELA"";DataType:System.String;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2" & _
        "{Width:250;Caption:""COLOR DE LA TELA"";TextAlign:LeftCenter;TextAlignFixed:LeftCe" & _
        "nter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:90;Caption:""22-abr-2012"";AllowEditing:False;DataType:System.Decim" & _
        "al;Format:""####,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{Width" & _
        ":90;Name:""1"";DataType:System.Decimal;Format:""####,##0"";TextAlign:RightCenter;Tex" & _
        "tAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{Width:90;Name:""2"";DataType:System.Decimal;Format:""#" & _
        "###,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "6{Width:90;Name:""3""" & _
        ";DataType:System.Decimal;Format:""####,##0"";TextAlign:RightCenter;TextAlignFixed:" & _
        "CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{Width:90;Name:""4"";DataType:System.Decimal;Format:""####,##0"";Tex" & _
        "tAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{Width:90;Name:""5"";DataType:Sy" & _
        "stem.Decimal;Format:""####,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter" & _
        ";}" & Microsoft.VisualBasic.ChrW(9) & "9{Width:90;Name:""6"";DataType:System.Decimal;Format:""####,##0"";TextAlign:Right" & _
        "Center;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "10{Width:90;Name:""7"";DataType:System.Decima" & _
        "l;Format:""####,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "11{Width" & _
        ":90;Name:""8"";DataType:System.Decimal;Format:""####,##0"";TextAlign:RightCenter;Tex" & _
        "tAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "12{Width:90;Name:""9"";DataType:System.Decimal;Format:""" & _
        "####,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "13{Width:90;Name:""" & _
        "10"";DataType:System.Decimal;Format:""####,##0"";TextAlign:RightCenter;TextAlignFix" & _
        "ed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "14{Width:90;Name:""11"";DataType:System.Decimal;Format:""####,##0" & _
        """;TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "15{Width:100;Name:""12"";Dat" & _
        "aType:System.Decimal;Format:""####,##0"";TextAlign:RightCenter;TextAlignFixed:Cent" & _
        "erCenter;}" & Microsoft.VisualBasic.ChrW(9) & "16{Width:90;Name:""13"";DataType:System.Decimal;Format:""####,##0"";TextA" & _
        "lign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "17{Caption:""codigo"";Visible:False" & _
        ";DataType:System.String;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.Te.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Te.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Te.ForeColor = System.Drawing.Color.Black
        Me.Te.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.Te.Location = New System.Drawing.Point(8, 48)
        Me.Te.Name = "Te"
        Me.Te.Rows.DefaultSize = 17
        Me.Te.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Te.Size = New System.Drawing.Size(1424, 552)
        Me.Te.StyleInfo = "Normal{Font:Courier New, 8.25pt;BackColor:White;ForeColor:Black;TextAlign:LeftCen" & _
        "ter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:8, 111, 171;ForeColor:White;Bo" & _
        "rder:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Focus" & _
        "{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColo" & _
        "r:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDar" & _
        "k,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{Font:Microsoft S" & _
        "ans Serif, 8.25pt, style=Bold;BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{Font:M" & _
        "icrosoft Sans Serif, 8.25pt, style=Bold;BackColor:186, 196, 228;ForeColor:Black;" & _
        "ImageAlign:RightTop;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subt" & _
        "otal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDar" & _
        "kDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "ro" & _
        "jo{BackColor:Red;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "verde{BackColor:135, 214, 101;}" & Microsoft.VisualBasic.ChrW(9) & "amarillo{Back" & _
        "Color:218, 232, 94;}" & Microsoft.VisualBasic.ChrW(9)
        Me.Te.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Te.TabIndex = 60
        Me.ToolTip1.SetToolTip(Me.Te, "Celdas en Rojo muestran Faltante en tela.")
        '
        'nc
        '
        Me.nc.AllowEditing = False
        Me.nc.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.nc.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.nc.BackColor = System.Drawing.Color.White
        Me.nc.ColumnInfo = "10,1,0,0,0,95,Columns:0{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1{TextAl" & _
        "ign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{TextAlign:LeftCenter;TextAlignFixed" & _
        ":LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{TextAlign:Lef" & _
        "tCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{TextAlign:LeftCenter;TextAlignFixed:LeftCe" & _
        "nter;}" & Microsoft.VisualBasic.ChrW(9) & "6{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{TextAlign:LeftCenter" & _
        ";TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & _
        "9{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.nc.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.nc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nc.ForeColor = System.Drawing.Color.Black
        Me.nc.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.nc.Location = New System.Drawing.Point(8, 48)
        Me.nc.Name = "nc"
        Me.nc.Rows.Count = 1
        Me.nc.Rows.DefaultSize = 19
        Me.nc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.nc.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.nc.Size = New System.Drawing.Size(664, 608)
        Me.nc.StyleInfo = "Normal{Font:Microsoft Sans Serif, 9.75pt;BackColor:White;ForeColor:Black;TextAlig" & _
        "n:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:95, 156, 239;ForeColo" & _
        "r:Black;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:Black;ForeColor:Whi" & _
        "te;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Froze" & _
        "n{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Border:Flat,1,Cont" & _
        "rolDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackCo" & _
        "lor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{Font:Microsoft Sans Serif, 9.75p" & _
        "t, style=Bold;BackColor:MediumTurquoise;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:Co" & _
        "ntrolDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:Wh" & _
        "ite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:" & _
        "ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9)
        Me.nc.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.nc.TabIndex = 56
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "10,1,0,0,0,95,Columns:0{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1{TextAl" & _
        "ign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{TextAlign:LeftCenter;TextAlignFixed" & _
        ":LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{TextAlign:Lef" & _
        "tCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{TextAlign:LeftCenter;TextAlignFixed:LeftCe" & _
        "nter;}" & Microsoft.VisualBasic.ChrW(9) & "6{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{TextAlign:LeftCenter" & _
        ";TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & _
        "9{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(16, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
        Me.fg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(944, 368)
        Me.fg.StyleInfo = "Normal{Font:Microsoft Sans Serif, 9.75pt;BackColor:White;ForeColor:Black;TextAlig" & _
        "n:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:95, 156, 239;ForeColo" & _
        "r:Black;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:Black;ForeColor:Whi" & _
        "te;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Froze" & _
        "n{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Border:Flat,1,Cont" & _
        "rolDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackCo" & _
        "lor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{Font:Microsoft Sans Serif, 9.75p" & _
        "t, style=Bold;BackColor:MediumTurquoise;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:Co" & _
        "ntrolDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:Wh" & _
        "ite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:" & _
        "ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 23
        Me.fg.Visible = False
        '
        'Bal_tela_prod1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(998, 692)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Te, Me.Ex, Me.Impri, Me.si, Me.Label4, Me.Cliente, Me.R1, Me.fg, Me.nc})
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Bal_tela_prod1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance Semanal de Tela según Fecha de Producción."
        CType(Me.Te, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub consulta_cortes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Cliente.KeyPress, AddressOf keypressed1
        nc.Width = l - 20
        nc.Height = a - 85
        Te.Width = l - 20
        Te.Height = a - 85
        setea_grids()
        llena_combos(Cliente, "SELECT DISTINCT CLIENTE FROM CPO_D LEFT JOIN CPO ON CPO.CPO = CPO_D.CPO WHERE ESTADO = 'A' ORDER BY CLIENTE", "CLIENTE")
    End Sub

    Private Sub llena_todas_las_tablas()
        dt = New DataTable()
        fpos = New DataTable()
        inv = New DataTable()
        con = New DataTable()
        strsql = "SELECT CPO_D.CPO,CPO_D.ESTILO,CPO_D.COLOR,TOTAL,CPO_D.F_ENTREGA,(SELECT SUM(TOTAL) FROM CORTES WHERE CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR AND ESTADO = 'A') AS CORTADO, (SELECT SUM(TOTAL)FROM CORTES_S WHERE CORTES_S.CPO = CPO_D.CPO AND CORTES_S.ESTILO = CPO_D.ESTILO AND CORTES_S.COLOR = CPO_D.COLOR AND ESTADO = 'A') AS PROCESO,O2,O3 FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO  LEFT JOIN ESTILOS ON CPO_D.ESTILO = ESTILOS.ESTILO AND CPO.CLIENTE = ESTILOS.CLIENTE WHERE CPO.CLIENTE = '" & Cliente.Text & "' AND ESTADO = 'A' ORDER BY CPO_D.ESTILO ,CPO_D.COLOR"
        llena_tablas(dt, strsql, cnn)
        strsql = "SELECT CODIGO,COLOR,OFECHA,SUM((LIBRAS -RECIBIDAS)) AS PEDIDAS FROM FPO WHERE RECIBIDAS = 0  AND STATUS = 'ABIERTO' AND CLIENTE = '" & Cliente.Text & "' GROUP BY CODIGO,COLOR,OFECHA"
        llena_tablas(fpos, strsql, cnn)
        strsql = "SELECT CODIGO,COLOR ,SUM((ROLLOS.PESO/ROLLOS.YARDAS_I) * ROLLOS.YARDAS) AS LIBRAS FROM ROLLOS WHERE YARDAS > 0 AND CLIENTE = '" & Cliente.Text & "' AND ACTIVO IN ('S','0','5') GROUP BY CODIGO,COLOR"
        llena_tablas(inv, strsql, cnn)
        strsql = "SELECT CONSUMO_TELA.*,DESCRIPCION FROM CONSUMO_TELA LEFT JOIN CODIGO_TELA ON CODIGO_TELA.CODIGO = CONSUMO_TELA.CODIGO WHERE ESTILO_CPO + COLOR_CPO IN (SELECT DISTINCT ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A') AND CONSUMO_TELA.CLIENTE = '" & Cliente.Text & "'"
        llena_tablas(con, strsql, cnn)
        strsql = "SELECT * FROM WIP0 WHERE CPO+ESTILO+COLOR IN (SELECT DISTINCT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A')"
        llena_tablas(wip, strsql, cnn)
    End Sub

    Private Sub setea_grids()
        Dim i As Integer
        Dim pd As Date
        Dim su(0, 7, 6, 5, 4, 3, 2, 1) As Integer
        Te.Rows.Count = 1
        Te.Rows(0).Height = 30
        pd = hoy.AddDays(-dis)
        Te(0, 3) = UCase(Format(pd, "dd-MMM-yyyy"))
        fei = pd
        For i = 1 To 12
            pd = pd.AddDays(7)
            Te(0, i + 3) = UCase(Format(pd, "dd-MMM-yyyy"))
        Next
        Te(0, 16) = "> " & Te(0, 15)
    End Sub

    Private Sub llena_principal()
        Dim i As Integer
        Dim busca As String
        Dim cortar As Integer
        Dim l As Integer
        Dim dr As DataRow
        Dim dw As DataRow
        Dim dd As DataRow()
        Dim fect As Date
        Dim pproc As Object
        Dim nec As Decimal
        Dim co As Decimal
        Dim col As Integer
        Dim dias As Integer = 28
        Dim proceso As Integer
        Dim total As Integer
        Dim cortado As Integer
        Dim estilo As String
        Dim colores As String
        Dim ww As DataRow()
        Dim wj As DataRow
        For Each dr In dt.Rows
            estilo = dr("ESTILO")
            COLORES = dr("COLOR")
            Try
                proceso = dr("PROCESO")
            Catch
                proceso = 0
            End Try
            Try
                total = dr("TOTAL")
            Catch
                total = 0
            End Try
            Try
                cortado = dr("CORTADO")
            Catch
                cortado = 0
            End Try
            If proceso > 0 Then
                Try
                    pproc = tsd.Compute("SUM(TOTAL)", "ESTILO = '" & dr("ESTILO") & "' AND COLOR = '" & dr("COLOR") & "' AND CPO = '" & dr("CPO") & "' AND DESPACHO IS NULL")
                    If pproc > 0 And proceso >= pproc Then
                        proceso = proceso - pproc
                    End If
                Catch
                End Try
            End If
            cortar = total - cortado - proceso
            If cortar > 0 Then
                dd = con.Select("ESTILO_CPO = '" & estilo & "' AND COLOR_CPO = '" & colores & "'")
                dias = 21
                'Try
                '    If dr("O2") = True Then
                '        dias = 21
                '    End If

                '    If (dr("O2") = False) And (dr("O3") = False) Then
                '        dias = 14
                '    End If
                'Catch
                'End Try
                For Each dw In dd
                    co = dw("LIBRAS")
                    nec = co * cortar
                    busca = Trim(dw("CODIGO")) + Trim(dw("COLOR_TELA"))
                    l = Te.FindRow(busca, 1, 0, False)
                    If l = -1 Then
                        l = Te.Rows.Count
                        Te.Rows.Count = l + 1
                        Te(l, 1) = dw("DESCRIPCION")
                        Te(l, 2) = dw("COLOR_TELA")
                        Te(l, 17) = dw("CODIGO")
                        Te(l, 0) = busca
                    End If
                    ww = wip.Select("CPO = '" & dr("CPO") & "' AND ESTILO = '" & estilo & "' AND COLOR = '" & colores & "'")
                    If ww.Length > 0 Then
                        wj = ww(0)
                        Try
                            fec = wj("SEW_PLAN")
                        Catch
                            fec = Today  '"01-01-1900"
                        End Try
                        fect = fec.AddDays(-dias)
                        If Year(fec) = "1900" Then
                            fec = fei
                            fect = fec
                        End If
                    End If
                    determina_columna_tela(fei, fect, 3, 16, col)
                    Te(l, col) = Te(l, col) - nec
                Next
            End If
        Next
        For i = 1 To Te.Rows.Count - 1
            inventarios(i, Te(i, 17), Te(i, 2), co)
        Next
        Te.Sort(SortFlags.Ascending, 2)
        For l = 1 To Te.Rows.Count - 1
            If Te(l, 3) < 0 Then
                Te.SetCellStyle(l, 3, Te.Styles("rojo"))
            End If
            For i = 4 To 16
                Te(l, i) = Te(l, i) + Te(l, i - 1)
                If Te(l, i) < 0 Then
                    Te.SetCellStyle(l, i, Te.Styles("rojo"))
                End If
            Next
        Next
    End Sub

   


    Private Sub inventarios(ByVal l As Integer, ByVal codigo As String, ByVal colores As String, ByRef inve As Decimal)
        Dim dr As DataRow
        Dim dd As DataRow()
        Dim c As Integer
        inve = 0
        dd = inv.Select("CODIGO = '" & codigo & "' AND COLOR = '" & colores & "'")
        For Each dr In dd
            inve = inve + dr("LIBRAS")
        Next
        Te(l, 3) = Te(l, 3) + inve
        ' ========================= PEDIDOS
        dd = fpos.Select("CODIGO = '" & codigo & "' AND COLOR  = '" & colores & "'")
        For Each dr In dd
            determina_columna_tela(fei, dr("OFECHA"), 3, 16, c)
            Te(l, c) = Te(l, c) + dr("PEDIDAS")
        Next

    End Sub

    Private Sub si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles si.Click
        Cursor = Cursors.WaitCursor
        si.Visible = False
        R1.Visible = True
        Impri.Visible = True
        Ex.Visible = True
        Cliente.Enabled = False
        revisa_consumo(ok)
        Te.Visible = True
        llena_todas_las_tablas()
        llena_principal()
        Cursor = Cursors.Default
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        si.Visible = True
        R1.Visible = False
        Impri.Visible = False
        Ex.Visible = False
        Cliente.Enabled = True
        Te.Rows.Count = 1
    End Sub

    Private Sub limpia_flex()
        Te.Visible = True
    End Sub

    ' ===================================================================================
    '
    ' Revisa si todos los Estilos Colores tienen consumo
    '
    ' ===================================================================================
    Private Sub setea_nc()
        fg.Visible = False
        nc.Visible = True
        nc.Clear()
        nc.Rows.Count = 1
        nc.Cols.Count = 4
        nc.Cols(0).Width = 5
        nc.Rows(0).Height = 30
        Dim c As Column = nc.Cols(1)
        nc.Cols(1).Name = "ESTILO"
        nc.Cols(2).Name = "COLOR"
        nc.Cols(3).Name = "ESTADO"
        nc.Cols(1).Width = 200
        nc.Cols(2).Width = 300
        nc.Cols(3).Width = 450
    End Sub

    Private Sub revisa_consumo(ByRef ok As Boolean)
        Dim dt As New DataTable()
        obj = New empresas()
        Dim seguro As MsgBoxResult
        nc.Visible = True
        Te.Visible = False
        ok = True
        Dim strSQL As String = "SELECT DISTINCT ESTILO,COLOR FROM CPO_D, CPO WHERE ESTADO = 'A' AND CLIENTE = '" & Cliente.Text & "' AND  CPO.CPO = CPO_D.CPO AND (ESTILO + COLOR NOT IN (SELECT DISTINCT ESTILO_CPO+COLOR_CPO FROM CONSUMO_TELA))"
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn)
        lineas = dt.Rows.Count
        If lineas > 0 Then
            ok = False
            setea_nc()
            nc.Rows.Count = lineas + 1
            lineas = 1
            For Each dr In dt.Rows
                nc(lineas, 1) = dr("ESTILO")
                nc(lineas, 2) = dr("COLOR")
                nc(lineas, 3) = "NO TIENE CONSUMO"
                lineas = lineas + 1
            Next
            seguro = MsgBox("Antes de efectuar este proceso por favor ingrese los consumos. Desea Imprimir?  ", MsgBoxStyle.YesNo, "Faltan consumos !!!")
            If seguro = MsgBoxResult.Yes Then
                nc.PrintGrid("S/consumo", PrintGridFlags.FitToPageWidth, "Empresa: " + Trim(obj.nombre) + " Cliente: " + Trim(Cliente.Text) + "  Estilos Sin Consumo al " & Today, "")
            End If
        End If
    End Sub

    Private Sub Impri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Impri.Click
        Print_te()
    End Sub

    Private Sub Print_te()
        Dim pd As PrintDocument
        Dim fecha As String
        Dim mal As String = ""
        fecha = Format(Today, "dd/MM/yyy")
        pd = Te.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = False
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With
        Te.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        Te.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        Te.PrintGrid("Telas", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPrintDialog, Trim(Cliente.Text) + "    Balance de tela Al : " + fecha + "    " + MAL + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Ex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ex.Click
        a_excel(Te, path, ok)
    End Sub

    Private Sub tela_sin_despachar()
        Dim strsql As String = "SELECT CORTE,ESTILO,COLOR,CPO,TOTAL,(SELECT SUM(YARDAS) FROM DMOVTO WHERE DMOVTO.CORTE = CORTES_S.CORTE AND TMOVTO = '4') AS DESPACHO  FROM CORTES_S WHERE ESTADO = 'A'  AND CLIENTE = '" & Cliente.Text & "' ORDER BY ESTILO,COLOR,CPO"
        llena_tablas(tsd, strsql, cnn)
    End Sub

    Private Sub ordena_te()
        Dim i As Integer
        For i = 1 To Te.Rows.Count - 1
            Te(i, 9) = Te(i, 1)
            Te(i, 1) = Te(i, 8)
        Next
    End Sub

    Private Sub Cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cliente.Leave
        If Cliente.Items.IndexOf(Cliente.Text) = -1 Then
            Cliente.Focus()
        End If
    End Sub

    Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cliente.KeyPress
        AutoCompletar(Cliente, e)
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Cliente.Text) <> "" Then
                si.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub Te_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Te.DoubleClick
        Dim linea As Integer = Te.RowSel
        Dim codigo As String = Te(linea, 9)
        Dim forma As New Bal_tela_prod_d()
        forma.codigo = Te(linea, 17)
        forma.descripcion = Te(linea, 1)
        forma.colores = Te(linea, 2)
        forma.cliente = Cliente.Text
        forma.ShowDialog()
    End Sub
End Class
