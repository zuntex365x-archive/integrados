Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized


Public Class Hoja_Resumen1
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim fecha_i As String
    Dim fecha_f As String
    Dim fecha_m As String
    Dim dr As DataRow
    Dim maximo As Decimal = 1.05
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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cancela As System.Windows.Forms.Button
    Friend WithEvents S1 As System.Windows.Forms.Button
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cliente As System.Windows.Forms.ComboBox
    Friend WithEvents mt As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ma As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents graba As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents prod As System.Windows.Forms.TextBox
    Friend WithEvents tela As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Hoja_Resumen1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.Cancela = New System.Windows.Forms.Button()
        Me.S1 = New System.Windows.Forms.Button()
        Me.cliente = New System.Windows.Forms.ComboBox()
        Me.mt = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ma = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.graba = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.prod = New System.Windows.Forms.TextBox()
        Me.tela = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.mt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fecha
        '
        Me.fecha.CustomFormat = "dd/MM/yyyy"
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.fecha.Location = New System.Drawing.Point(256, 40)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(136, 26)
        Me.fecha.TabIndex = 71
        Me.ToolTip1.SetToolTip(Me.fecha, "Fecha que comienza la semana a consultar.")
        '
        'Cancela
        '
        Me.Cancela.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Cancela.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cancela.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancela.ForeColor = System.Drawing.Color.Black
        Me.Cancela.Image = CType(resources.GetObject("Cancela.Image"), System.Drawing.Bitmap)
        Me.Cancela.Location = New System.Drawing.Point(912, 8)
        Me.Cancela.Name = "Cancela"
        Me.Cancela.Size = New System.Drawing.Size(35, 35)
        Me.Cancela.TabIndex = 72
        Me.Cancela.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cancela, "Cancela datos sin grabar.")
        Me.Cancela.Visible = False
        '
        'S1
        '
        Me.S1.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.S1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.S1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S1.ForeColor = System.Drawing.Color.Black
        Me.S1.Image = CType(resources.GetObject("S1.Image"), System.Drawing.Bitmap)
        Me.S1.Location = New System.Drawing.Point(872, 8)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(35, 35)
        Me.S1.TabIndex = 67
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.S1, "Calcula datos")
        '
        'cliente
        '
        Me.cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.Location = New System.Drawing.Point(256, 8)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(248, 24)
        Me.cliente.TabIndex = 75
        Me.ToolTip1.SetToolTip(Me.cliente, "Cliente")
        '
        'mt
        '
        Me.mt.AllowEditing = False
        Me.mt.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.mt.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.mt.BackColor = System.Drawing.Color.White
        Me.mt.ColumnInfo = "15,1,0,0,0,85,Columns:0{Width:1;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & _
        "1{Width:145;Caption:""cpo"";DataType:System.String;TextAlign:LeftCenter;TextAlignF" & _
        "ixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:104;Caption:""estilo"";DataType:System.String;TextAlign:" & _
        "LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:118;Caption:""color"";DataType:Syst" & _
        "em.String;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{Width:50;Caption:""X" & _
        "S"";DataType:System.Decimal;Format:""###,##0"";TextAlign:RightCenter;TextAlignFixed" & _
        ":CenterCenter;ImageAlign:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{Width:50;Caption:""S"";DataType:System.D" & _
        "ecimal;Format:""###,##0"";TextAlign:CenterCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "6{W" & _
        "idth:50;Caption:""M"";DataType:System.Decimal;Format:""###,##0"";TextAlign:CenterCen" & _
        "ter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{Width:50;Caption:""L"";DataType:System.Decimal" & _
        ";Format:""###,##0"";TextAlign:CenterCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{Width:5" & _
        "0;Caption:""XL"";Format:""###,##0"";TextAlign:CenterCenter;TextAlignFixed:CenterCent" & _
        "er;}" & Microsoft.VisualBasic.ChrW(9) & "9{Width:50;Caption:""2XL"";DataType:System.Decimal;Format:""###,##0"";TextAlign" & _
        ":CenterCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "10{Width:50;Caption:""3XL"";DataType:S" & _
        "ystem.Decimal;Format:""###,##0"";TextAlign:CenterCenter;TextAlignFixed:CenterCente" & _
        "r;}" & Microsoft.VisualBasic.ChrW(9) & "11{Width:50;Caption:""4XL"";DataType:System.Decimal;Format:""###,##0"";TextAlign" & _
        ":CenterCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "12{Width:50;Caption:""5XL"";DataType:S" & _
        "ystem.Decimal;Format:""###,##0"";TextAlign:CenterCenter;TextAlignFixed:CenterCente" & _
        "r;}" & Microsoft.VisualBasic.ChrW(9) & "13{Width:50;Caption:""6XL"";DataType:System.Decimal;Format:""###,##0"";TextAlign" & _
        ":CenterCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "14{Width:70;Caption:""TOTALES"";DataTy" & _
        "pe:System.Decimal;Format:""###,##0"";TextAlign:CenterCenter;TextAlignFixed:CenterC" & _
        "enter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.mt.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.mt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mt.ForeColor = System.Drawing.Color.Black
        Me.mt.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.mt.Location = New System.Drawing.Point(16, 448)
        Me.mt.Name = "mt"
        Me.mt.Rows.Count = 1
        Me.mt.Rows.DefaultSize = 17
        Me.mt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.mt.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.mt.Size = New System.Drawing.Size(512, 248)
        Me.mt.StyleInfo = "Normal{Font:Microsoft Sans Serif, 8.25pt;BackColor:White;ForeColor:Black;TextAlig" & _
        "n:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:120, 87, 153;ForeColo" & _
        "r:Black;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:Black;ForeColor:Whi" & _
        "te;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Froze" & _
        "n{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Border:Flat,1,Cont" & _
        "rolDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{Font:M" & _
        "icrosoft Sans Serif, 8.25pt, style=Bold;BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtot" & _
        "al1{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:186, 196, 228;ForeCo" & _
        "lor:Black;ImageAlign:RightTop;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor:Wh" & _
        "ite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:" & _
        "ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeColor:" & _
        "White;}" & Microsoft.VisualBasic.ChrW(9)
        Me.mt.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.mt.TabIndex = 76
        Me.ToolTip1.SetToolTip(Me.mt, "Area de Datos.")
        Me.mt.Visible = False
        '
        'ma
        '
        Me.ma.AllowEditing = False
        Me.ma.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.ma.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.ma.BackColor = System.Drawing.Color.White
        Me.ma.ColumnInfo = "5,1,0,0,0,85,Columns:0{Width:1;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1" & _
        "{Width:94;Caption:""codigo"";DataType:System.String;TextAlign:LeftCenter;TextAlign" & _
        "Fixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:104;Caption:""costo"";DataType:System.Decimal;Format:""#" & _
        "####.0000"";TextAlign:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:93;Caption" & _
        ":""existencia"";DataType:System.Decimal;Format:""######0.00"";TextAlign:RightCenter;" & _
        "TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{Width:67;Caption:""asignado"";DataType:System.Decim" & _
        "al;Format:""###,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;ImageAlign" & _
        ":CenterCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.ma.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.ma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ma.ForeColor = System.Drawing.Color.Black
        Me.ma.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.ma.Location = New System.Drawing.Point(520, 448)
        Me.ma.Name = "ma"
        Me.ma.Rows.Count = 1
        Me.ma.Rows.DefaultSize = 17
        Me.ma.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ma.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.ma.Size = New System.Drawing.Size(472, 248)
        Me.ma.StyleInfo = "Normal{Font:Microsoft Sans Serif, 8.25pt;BackColor:White;ForeColor:Black;TextAlig" & _
        "n:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:120, 87, 153;ForeColo" & _
        "r:Black;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:Black;ForeColor:Whi" & _
        "te;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Froze" & _
        "n{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Border:Flat,1,Cont" & _
        "rolDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{Font:M" & _
        "icrosoft Sans Serif, 8.25pt, style=Bold;BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtot" & _
        "al1{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:186, 196, 228;ForeCo" & _
        "lor:Black;ImageAlign:RightTop;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor:Wh" & _
        "ite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:" & _
        "ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeColor:" & _
        "White;}" & Microsoft.VisualBasic.ChrW(9)
        Me.ma.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.ma.TabIndex = 77
        Me.ToolTip1.SetToolTip(Me.ma, "Area de Datos.")
        Me.ma.Visible = False
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.graba.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Bitmap)
        Me.graba.Location = New System.Drawing.Point(952, 8)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(35, 35)
        Me.graba.TabIndex = 78
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.graba, "Graba datos.")
        Me.graba.Visible = False
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = "4,1,0,0,0,85,Columns:0{Width:4;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1" & _
        "{Width:227;Name:""AREA"";Caption:""AREA"";AllowEditing:False;DataType:System.String;" & _
        "Format:"" "";TextAlign:LeftCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:528;Name:""" & _
        "TEMA"";Caption:""TEMA"";AllowEditing:False;TextAlign:LeftCenter;TextAlignFixed:Left" & _
        "Center;}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:200;Name:""VALOR"";Caption:""VALOR"";DataType:System.Decimal;Format" & _
        ":""###,##0"";TextAlign:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveDown
        Me.fg.Location = New System.Drawing.Point(8, 96)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 24
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(992, 592)
        Me.fg.StyleInfo = "Normal{Font:Microsoft Sans Serif, 9.75pt;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:231, 154, 84;ForeColor:Black;Border:Flat,1,Black,Both" & _
        ";}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:172, 190, 251;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{BackColor:233, 163," & _
        " 99;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor:HighlightTex" & _
        "t;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:PaleGoldenrod;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;B" & _
        "order:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:White;}" & _
        "" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor:Gainsboro;ForeC" & _
        "olor:64, 64, 64;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal" & _
        "3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDar" & _
        "k;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "estilo" & _
        "1{BackColor:243, 205, 171;Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "estilo2{Border:Flat,1,Black" & _
        ",Both;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.fg, "Area de datos.")
        '
        'prod
        '
        Me.prod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prod.Location = New System.Drawing.Point(256, 72)
        Me.prod.MaxLength = 6
        Me.prod.Name = "prod"
        Me.prod.Size = New System.Drawing.Size(88, 22)
        Me.prod.TabIndex = 80
        Me.prod.Text = "0"
        Me.prod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.prod, "Prendas planeadas por producir.")
        '
        'tela
        '
        Me.tela.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.tela.AllowEditing = False
        Me.tela.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.tela.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.tela.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.tela.ColumnInfo = "5,1,0,0,0,85,Columns:0{Width:4;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1" & _
        "{Width:180;Name:""AREA"";Caption:""ESTILO"";AllowEditing:False;DataType:System.Strin" & _
        "g;Format:"" "";TextAlign:LeftCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:122;Name" & _
        ":""TEMA"";Caption:""PRENDAS"";AllowEditing:False;DataType:System.Decimal;Format:""###" & _
        ",##0"";TextAlign:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:128;Name:""VALOR" & _
        """;Caption:""CONSUMO T."";DataType:System.Decimal;Format:""###,##0.00"";TextAlign:Rig" & _
        "htCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{Width:111;Caption:""CONSUMO R"";DataType:S" & _
        "ystem.Decimal;Format:""####,##0.00"";TextAlign:RightCenter;TextAlignFixed:RightCen" & _
        "ter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.tela.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.tela.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tela.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.tela.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveDown
        Me.tela.Location = New System.Drawing.Point(160, 104)
        Me.tela.Name = "tela"
        Me.tela.Rows.DefaultSize = 24
        Me.tela.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.tela.Size = New System.Drawing.Size(576, 360)
        Me.tela.StyleInfo = "Normal{Font:Microsoft Sans Serif, 9.75pt;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:231, 154, 84;ForeColor:Black;Border:Flat,1,Black,Both" & _
        ";}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:172, 190, 251;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{BackColor:233, 163," & _
        " 99;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor:HighlightTex" & _
        "t;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:PaleGoldenrod;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;B" & _
        "order:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:White;}" & _
        "" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor:Gainsboro;ForeC" & _
        "olor:64, 64, 64;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal" & _
        "3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDar" & _
        "k;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "estilo" & _
        "1{BackColor:243, 205, 171;Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "estilo2{Border:Flat,1,Black" & _
        ",Both;}" & Microsoft.VisualBasic.ChrW(9)
        Me.tela.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.tela.TabIndex = 81
        Me.ToolTip1.SetToolTip(Me.tela, "Area de datos.")
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 32)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Principio de la Semana:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 32)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Cliente:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 24)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Costura Plan:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Hoja_Resumen1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(1006, 699)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.prod, Me.Label1, Me.graba, Me.fg, Me.ma, Me.mt, Me.S1, Me.cliente, Me.fecha, Me.Label2, Me.Label3, Me.Cancela, Me.tela})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Hoja_Resumen1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Indicadores"
        CType(Me.mt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Hoja_resumen1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        llena_combos(cliente, "SELECT DISTINCT CLIENTE FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE ESTADO = 'A' ORDER BY CLIENTE  ", "CLIENTE")
        setea_fg()
    End Sub

    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 38
        fg.Cols(1).AllowMerging = True
    End Sub

    Private Sub procesa_datos()
        cpos()
        produccion()
        inventarios()
        segundas()
        performance()
        Dim i As Integer
        For i = 1 To fg.Rows.Count - 1
            If CDec(fg(i, 3)) = 0 Then
                fg(i, 3) = 0
            End If
        Next
        consumo_tela()
    End Sub

    Private Sub S1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S1.Click
        Dim ok As Boolean
        verifica_fecha(ok)
        If ok Then
            Cursor = Cursors.WaitCursor
            procesa_datos()
            deshabilita()
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub deshabilita()
        S1.Visible = False
        GRABA.VISIBLE = True
        Cancela.Visible = True
        cliente.Enabled = False
        fecha.Enabled = False
        prod.Enabled = False
    End Sub

    Private Sub verifica_fecha(ByRef ok As Boolean)
        Dim fechav As Date
        Dim dia As Integer
        Dim hoy As Date = Today
        fechav = fecha.Value
        dia = fechav.DayOfWeek
        If dia <> 1 Then
            MsgBox("la Fecha  elegida no corresponde a un inicio de Semana", MsgBoxStyle.Critical, "Por favor revise !!!!!")
            ok = False
        Else
            If CDate(Format(fechav.AddDays(7), "yyyy-MM-dd")) > hoy Then
                MsgBox("Aún no ha terminado la semana elegida", MsgBoxStyle.Critical, "Por favor revise !!!!!")
                ok = False
            Else
                ok = True
                fecha_i = Format(fechav, "yyyy-MM-dd")
                fechav = fechav.AddDays(6)
                fecha_f = Format(fechav, "yyyy-MM-dd")
                fechav = fechav.AddDays(-28)
                fecha_m = Format(fechav, "yyyy-MM-dd")
            End If
        End If
    End Sub


    '============================== PROCESOS =========================================
    Private Sub cpos()
        Dim l As Integer = fg.Rows.Count
        Dim cp As New DataTable()
        agrega_linea(2, "CPO'S", "estilo2")
        fg(l, 2) = "CPO'S ABIERTAS"
        llena_tablas(cp, "SELECT  SUM(TOTAL) AS PRENDAS FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO =CPO.CPO WHERE ESTADO = 'A'  AND CLIENTE = '" & cliente.Text & "'", cnn)
        If cp.Rows.Count > 0 Then
            dr = cp.Rows(0)
            fg(l, 3) = dr("PRENDAS")
        End If
        l = l + 1
        fg(l, 2) = "CPO'S RECIBIDAS EN LA SEMANA"
        llena_tablas(cp, "SELECT SUM(TOTAL) AS PRENDAS  FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO =CPO.CPO WHERE ESTADO = 'A'  AND CLIENTE = '" & cliente.Text & "' AND F_PEDIDO BETWEEN '" & fecha_i & "' AND '" & fecha_f & "'", cnn)
        If cp.Rows.Count > 0 Then
            dr = cp.Rows(0)
            fg(l, 3) = dr("PRENDAS")
        End If
    End Sub

    Private Sub produccion()
        Dim l As Integer = fg.Rows.Count
        Dim cp As New DataTable()
        agrega_linea(11, "PRODUCCION", "estilo1")
        fg(l, 2) = "COSTURA  PLAN"
        fg(l, 3) = CDec(prod.Text)
        l = l + 1
        fg(l, 2) = "COSTURA  REAL"
        llena_tablas(cp, "SELECT SUM(PRENDAS) AS PRENDAS FROM PROD_DIARIA LEFT JOIN CORTES ON PROD_DIARIA.CORTE = CORTES.CORTE WHERE CLIENTE = '" & cliente.Text & "' AND FECHA BETWEEN '" & fecha_i & "' AND '" & fecha_f & "'", cnn)
        If cp.Rows.Count > 0 Then
            dr = cp.Rows(0)
            fg(l, 3) = dr("PRENDAS")
        End If
        l = l + 1
        fg(l, 2) = "COSTURA  DIFERENCIA"
        fg(l, 3) = fg(3, 3) - fg(4, 3)
        l = l + 1
        fg(l, 2) = "CORTE"
        llena_tablas(cp, "SELECT SUM(TOTAL) AS PRENDAS FROM CORTES WHERE CLIENTE = '" & cliente.Text & "' AND FCORTE BETWEEN '" & fecha_i & "' AND '" & fecha_f & "'", cnn)
        If cp.Rows.Count > 0 Then
            dr = cp.Rows(0)
            fg(l, 3) = dr("PRENDAS")
        End If
        l = l + 1
        fg(l, 2) = "SERIGRAFIA"
        llena_tablas(cp, "SELECT SUM(P0+P1+P2+P3+P4+P5+P6+P7+P8+P9+S0+S1+S2+S3+S4+S5+S6+S7+S8+S9) AS PRENDAS FROM CORTES_PAR LEFT JOIN CORTES ON CORTES_PAR.CORTE = CORTES.CORTE WHERE CLIENTE = '" & cliente.Text & "' AND PROCESO = 'Serigrafía' and TIPO = 'Recepcion' AND FECHA BETWEEN '" & fecha_i & "' AND '" & fecha_f & "'", cnn)
        If cp.Rows.Count > 0 Then
            dr = cp.Rows(0)
            fg(l, 3) = dr("PRENDAS")
        End If
        l = l + 1
        fg(l, 2) = "TELA  FPO'S ABIERTOS"
        llena_tablas(cp, "select SUM(LIBRAS - RECIBIDAS) AS LIBRAS FROM FPO WHERE CLIENTE = '" & cliente.Text & "' AND STATUS = 'ABIERTO' AND TIPO = 'TELA'", cnn)
        If cp.Rows.Count > 0 Then
            dr = cp.Rows(0)
            fg(l, 3) = dr("LIBRAS")
        End If
        l = l + 1
        fg(l, 2) = "TELA  PLAN DE ENTREGAS"
        llena_tablas(cp, "SELECT SUM(LIBRAS - RECIBIDAS) AS LIBRAS FROM FPO WHERE CLIENTE = '" & cliente.Text & "' AND STATUS = 'ABIERTO' AND TIPO = 'TELA' AND OFECHA BETWEEN '" & fecha_i & "' AND '" & fecha_f & "'", cnn)
        If cp.Rows.Count > 0 Then
            dr = cp.Rows(0)
            fg(l, 3) = dr("LIBRAS")
        End If
        l = l + 1
        fg(l, 2) = "TELA  INV.BUEN ESTADO"
        llena_tablas(cp, "SELECT (SUM(ROLLOS.PESO)/SUM(ROLLOS.YARDAS_I) * SUM(ROLLOS.YARDAS)) AS LIBRAS FROM ROLLOS WHERE CLIENTE = '" & cliente.Text & "' AND TIPO = 'TELA' AND YARDAS > 0 AND ACTIVO IN ('S','0')", cnn)
        If cp.Rows.Count > 0 Then
            dr = cp.Rows(0)
            fg(l, 3) = dr("LIBRAS")
        End If
        l = l + 1
        fg(l, 2) = "TELA  PRENDAS CORTADAS  (prendas)"
        llena_tablas(cp, "SELECT SUM(TOTAL) AS TOTAL FROM CORTES WHERE EXPORTADO = 'N' AND CORTE NOT IN (SELECT DISTINCT CORTE FROM PROD_DIARIA) AND CLIENTE = '" & cliente.Text & "'", cnn)
        If cp.Rows.Count > 0 Then
            dr = cp.Rows(0)
            fg(l, 3) = dr("TOTAL")
        End If
        l = l + 1
        fg(l, 2) = "TELA  INGRESOS A BODEGA"
        llena_tablas(cp, "SELECT SUM(LIBRAS) AS LIBRAS FROM DMOVTO WHERE CLIENTE = '" & cliente.Text & "' AND TMOVTO = '1' AND FECHA BETWEEN '" & fecha_i & "' AND '" & fecha_f & "'", cnn)
        If cp.Rows.Count > 0 Then
            dr = cp.Rows(0)
            fg(l, 3) = dr("LIBRAS")
        End If
        l = l + 1
        fg(l, 2) = "TELA  SALIDAS DE BODEGA"
        llena_tablas(cp, "SELECT SUM(LIBRAS) AS LIBRAS FROM DMOVTO WHERE CLIENTE = '" & cliente.Text & "' AND TMOVTO = '4' AND FECHA BETWEEN '" & fecha_i & "' AND '" & fecha_f & "'", cnn)
        If cp.Rows.Count > 0 Then
            dr = cp.Rows(0)
            fg(l, 3) = dr("LIBRAS")
        End If
        l = l + 1
    End Sub

    Private Sub inventarios()
        Dim l As Integer = fg.Rows.Count
        Dim cp As New DataTable()
        Dim pr As Integer
        Dim b(7) As Integer
        Dim S(3) As Integer
        Dim dr As DataRow
        agrega_linea(8, "INVENTARIOS", "estilo2")
        fg(l, 2) = "TELAS  STOCK"
        llena_tablas(cp, "SELECT (SUM(ROLLOS.PESO)/SUM(ROLLOS.YARDAS_I) * SUM(ROLLOS.YARDAS)) AS LIBRAS FROM ROLLOS WHERE CLIENTE = '" & cliente.Text & "' AND TIPO = 'TELA' AND YARDAS > 0 AND CPO = 'Stock'", cnn)
        If cp.Rows.Count > 0 Then
            dr = cp.Rows(0)
            fg(l, 3) = dr("LIBRAS")
        End If
        l = l + 1
        fg(l, 2) = "TELAS  ASIGNADA  (lbs)"
        llena_tablas(cp, "SELECT (SUM(ROLLOS.PESO)/SUM(ROLLOS.YARDAS_I) * SUM(ROLLOS.YARDAS)) AS LIBRAS FROM ROLLOS WHERE CLIENTE = '" & cliente.Text & "' AND TIPO = 'TELA' AND YARDAS > 0 AND CPO <> 'Stock'", cnn)
        If cp.Rows.Count > 0 Then
            dr = cp.Rows(0)
            fg(l, 3) = dr("LIBRAS")
        End If
        l = l + 1

        llena_tablas(cp, "SELECT ACTIVO,(SUM(ROLLOS.PESO)/SUM(ROLLOS.YARDAS_I) * SUM(ROLLOS.YARDAS)) AS LIBRAS FROM ROLLOS WHERE CLIENTE = '" & cliente.Text & "' AND TIPO = 'TELA' AND YARDAS > 0 AND ACTIVO <> 'S' GROUP BY ACTIVO", cnn)
        For Each dr In cp.Rows
            Try
                b(dr("ACTIVO")) = dr("LIBRAS")
            Catch
            End Try
        Next

        fg(l, 2) = "TELAS  SEGUNDAS"
        fg(l, 3) = b(1) + b(2) + b(3) + b(4) + b(5) + b(6) + b(7)
        l = l + 1
        materiales()
        Dim w As Integer
        Dim stock As Decimal
        Dim asignado As Decimal
        Dim dif As Decimal
        For w = 1 To ma.Rows.Count - 1
            If ma(w, 4) >= ma(w, 3) Then
                asignado = asignado + (ma(w, 2) * ma(w, 3))
            Else
                dif = ma(w, 3) - ma(w, 4)
                asignado = asignado + (ma(w, 2) * ma(w, 4))
                stock = stock + (ma(w, 2) * dif)
            End If
        Next
        fg(l, 2) = "MATERIALES STOCK  ($)"
        fg(l, 3) = stock
        l = l + 1
        fg(l, 2) = "MATERIALES ASIGNADOS"
        fg(l, 3) = asignado
        l = l + 1
        por_exportar(pr)
        fg(l, 2) = "PRENDAS POR EXPORTAR"
        fg(l, 3) = pr
        l = l + 1
        llena_tablas(cp, "SELECT TIPO,SUM(UNIDADES)AS UNIDADES FROM STOCK WHERE CLIENTE = '" & cliente.Text & "' GROUP BY TIPO", cnn)
        For Each dr In cp.Rows
            S(dr("TIPO")) = dr("UNIDADES")
        Next
        fg(l, 2) = "INV. STOCK PRIMERAS"
        fg(l, 3) = S(0)
        l = l + 1
        fg(l, 2) = "INV. STOCK SEGUNDAS"
        fg(l, 3) = S(1)
        l = l + 1
    End Sub

    Private Sub segundas()
        Dim l As Integer = fg.Rows.Count
        Dim cp As New DataTable()
        Dim tt As Decimal
        Dim se As Decimal
        Dim pr As Decimal
        Dim dr As DataRow
        agrega_linea(3, "SEGUNDAS", "estilo1")
        fg(l, 2) = "SEGUNDAS  UNIDADES"
        llena_tablas(cp, "SELECT TIPO ,SUM(PRENDAS) AS UNIDADES FROM PROD_DIARIA LEFT JOIN CORTES ON PROD_DIARIA.CORTE = CORTES.CORTE WHERE CLIENTE = '" & cliente.Text & "' AND FECHA BETWEEN '" & fecha_i & "' AND '" & fecha_f & "' GROUP BY TIPO", cnn)
        Try
            For Each dr In cp.Rows
                If dr("TIPO") > 0 Then
                    se = se + dr("UNIDADES")
                End If
                tt = tt + dr("UNIDADES")
            Next
        Catch
        End Try
        fg(l, 3) = se
        l = l + 1
        fg(l, 2) = "SEGUNDAS  % ESTA SEMANA"
        Try
            pr = (se * 100) / tt
        Catch
        End Try
        fg(l, 3) = pr
        l = l + 1
        fg(l, 2) = "SEGUNDAS  % PROM 4 SEMANAS"
        se = 0
        tt = 0
        llena_tablas(cp, "SELECT TIPO ,SUM(PRENDAS) AS UNIDADES FROM PROD_DIARIA LEFT JOIN CORTES ON PROD_DIARIA.CORTE = CORTES.CORTE WHERE CLIENTE = '" & cliente.Text & "' AND FECHA BETWEEN '" & fecha_m & "' AND '" & fecha_f & "' GROUP BY TIPO", cnn)
        Try
            For Each dr In cp.Rows
                If dr("TIPO") > 0 Then
                    se = se + dr("UNIDADES")
                End If
                tt = tt + dr("UNIDADES")
            Next
        Catch
        End Try
        Try
            pr = (se * 100) / tt
        Catch
        End Try
        fg(l, 3) = pr
        l = l + 1
    End Sub

    Private Sub agrega_linea(ByVal i As Integer, ByVal area As String, ByVal estilo As String)
        Dim c As Integer = fg.Rows.Count
        Dim l As Integer
        Dim r As Integer
        l = c + i
        fg.Rows.Count = l
        For r = c To c + i - 1
            fg(r, 1) = area
            fg.Rows(r).Style = fg.Styles(estilo)
        Next
    End Sub

    Private Sub Cancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancela.Click
        habilita()
    End Sub

    Private Sub habilita()
        cliente.Enabled = True
        fecha.Enabled = True
        prod.Enabled = True
        S1.Visible = True
        Cancela.Visible = False
        graba.Visible = False
        setea_fg()
        ma.Rows.Count = 1
        mt.Rows.Count = 1
    End Sub

    '===================================== MATERIALES  ==========================================
    Private Sub materiales()
        Dim dr As DataRow
        Dim dt As New DataTable()
        Dim l As Integer = 1
        Dim strsql As String = "SELECT CODIGO,COSTO,EXISTENCIA FROM MATERIALES WHERE CLIENTE = '" & cliente.Text & "' AND EXISTENCIA > 0"
        llena_tablas(dt, strsql, cnn)
        ma.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            ma(l, 1) = dr("CODIGO")
            ma(l, 2) = dr("COSTO")
            ma(l, 3) = dr("EXISTENCIA")
            l = l + 1
        Next
        cpos_unidades()
    End Sub

    Private Sub cpos_unidades()
        Dim dt As New DataTable()
        Dim l As Integer = 1
        Dim p As Integer
        Dim busca As String
        Dim dr As DataRow
        Dim strsql As String = "SELECT CPO_D.*, CLIENTE FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO  WHERE ESTADO = 'A' AND CLIENTE = '" & cliente.Text & "' ORDER BY CPO_D.CPO"
        llena_tablas(dt, strsql, cnn)
        mt.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            mt(l, 1) = dr("CPO")
            mt(l, 2) = dr("ESTILO")
            mt(l, 3) = dr("COLOR")
            mt(l, 4) = dr("XS")
            mt(l, 5) = dr("S")
            mt(l, 6) = dr("M")
            mt(l, 7) = dr("L")
            mt(l, 8) = dr("XL")
            mt(l, 9) = dr("XL2")
            mt(l, 10) = dr("XL3")
            mt(l, 11) = dr("XL4")
            mt(l, 12) = dr("XL5")
            mt(l, 13) = dr("XL6")
            mt(l, 14) = 0
            mt(l, 0) = mt(l, 1) + mt(l, 2) + mt(l, 3)
            l = l + 1
        Next
        strsql = "SELECT CPO,ESTILO,COLOR,SUM(XS) AS XS, SUM(S) AS S, SUM (M) AS M, SUM(L) AS L, SUM(XL) AS XL , SUM(XL2) AS XL2, SUM(XL3) AS XL3, SUM(XL4) AS XL4 ,SUM(XL5) AS XL5, SUM(XL6) AS XL6 FROM CORTES WHERE CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A' AND CLIENTE = '" & cliente.Text & "') AND CORTE IN (SELECT DISTINCT CORTE FROM D_MATERIAL WHERE T_MOVTO = '4') GROUP BY CPO, ESTILO,COLOR ORDER BY CORTES.CPO"
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            busca = dr("CPO") + dr("ESTILO") + dr("COLOR")
            l = mt.FindRow(busca, 1, 0, False)
            If l > 0 Then
                mt(l, 4) = mt(l, 4) - dr("XS")
                mt(l, 5) = mt(l, 5) - dr("S")
                mt(l, 6) = mt(l, 6) - dr("M")
                mt(l, 7) = mt(l, 7) - dr("L")
                mt(l, 8) = mt(l, 8) - dr("XL")
                mt(l, 9) = mt(l, 9) - dr("XL2")
                mt(l, 10) = mt(l, 10) - dr("XL3")
                mt(l, 11) = mt(l, 11) - dr("XL4")
                mt(l, 12) = mt(l, 12) - dr("XL5")
                mt(l, 13) = mt(l, 13) - dr("XL6")
            End If
        Next
        For l = 1 To mt.Rows.Count - 1
            For p = 4 To 13
                If mt(l, p) < 0 Then
                    mt(l, p) = 0
                End If
                mt(l, 14) = mt(l, 14) + mt(l, p)
            Next
            If mt(l, 14) > 0 Then
                Crea_detalle_requisicion(mt(l, 2), mt(l, 3), l)
            End If
        Next
    End Sub

    Private Sub Crea_detalle_requisicion(ByVal estilo As String, ByVal color As String, ByVal l As Integer)
        Dim strSQL As String
        Dim codigo As String
        Dim unidad As Decimal
        Dim dr As DataRow
        Dim re As New DataTable()
        Dim lma As Integer
        strSQL = "SELECT MAT_EST_COL.* FROM MAT_EST_COL WHERE ESTILO = '" & estilo & "' AND COLOR = '" & color & "'"
        llena_tablas(re, strSQL, cnn)
        For Each dr In re.Rows
            codigo = dr("CODIGO")
            unidad = dr("UNIDAD")
            If Mid(codigo, 9, 2) = "00" Then
                lma = ma.FindRow(codigo, 1, 1, False)
                If lma > 0 Then
                    simple(codigo, unidad, l, lma)
                End If
            Else
                otros(codigo, unidad, l)
            End If
        Next
    End Sub

    Private Sub simple(ByVal codigo As String, ByVal unidad As Decimal, ByVal li As Integer, ByVal lma As Integer)
        Dim pres As Decimal
        pres = unidad * mt(li, 14) * maximo
        pres = Format(pres, "#######0")
        ma(lma, 4) = ma(lma, 4) + pres
    End Sub

    Private Sub otros(ByVal codigo As String, ByVal unidad As Decimal, ByVal li As Integer)
        Dim i As Integer
        Dim pres As Decimal
        Dim prendas As Decimal
        Dim lma As Integer
        If Mid(codigo, 9, 2) < "11" Then
            For i = 1 To 10
                prendas = mt(li, i + 3)
                If prendas > 0 Then
                    pres = unidad * prendas * maximo
                    pres = Format(pres, "#######0")
                    codigo = Mid(codigo, 1, 8) + Format(i, "00")
                    lma = ma.FindRow(codigo, 1, 1, False)
                    If lma > 0 Then
                        ma(lma, 4) = ma(lma, 4) + pres
                    End If
                End If
            Next i
        End If
    End Sub
    '===================================== PRENDAS  ==========================================

    Private Sub por_exportar(ByRef pp As Integer)
        Dim dt As New DataTable()
        Dim corte As String
        Dim prod As Integer
        Dim exp As Integer
        Dim dr As DataRow
        Dim strsql As String = "SELECT * FROM CORTES_P LEFT JOIN CORTES_E ON CORTES_P.CORTE = CORTES_E.CORTE WHERE CORTES_P.CORTE IN (SELECT CORTE FROM CORTES WHERE CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM CPO_D WHERE CLIENTE = '" & cliente.Text & "' AND ESTADO ='A')) "
        llena_tablas(dt, strsql, cnn)
        pp = 0
        For Each dr In dt.Rows
            prod = (dr(1) + dr(2) + dr(3) + dr(4) + dr(5) + dr(6) + dr(7) + dr(8) + dr(9) + dr(10))
            Try
                corte = dr(21)
                exp = (dr(22) + dr(23) + dr(24) + dr(25) + dr(26) + dr(27) + dr(28) + dr(29) + dr(30) + dr(31))
            Catch
                exp = 0
            End Try
            pp = pp + (prod - exp)
        Next
    End Sub

    '===================================== PERFORMANCE  ==========================================
    Private Sub performance()
        Dim l As Integer = fg.Rows.Count
        Dim cp As New DataTable()
        Dim s(4) As Integer
        Dim tt As Integer
        Dim fei As Date
        Dim fef As Date = CDate(fecha_f)
        Dim se As Decimal
        Dim prendas As Integer
        Dim pr As Decimal
        Dim dr As DataRow
        agrega_linea(5, "PERFORMANCE", "estilo2")
        llena_tablas(cp, "SELECT CORTES.CPO,CORTES.ESTILO,CORTES.COLOR, F_ENTREGA,SUM(PRENDAS) AS PRENDAS FROM EMBARQUES LEFT JOIN CORTES ON CORTES.CORTE = EMBARQUES.CORTE LEFT JOIN CPO_D ON CORTES.CPO+CORTES.ESTILO+CORTES.COLOR = CPO_D.CPO+CPO_D.ESTILO+ CPO_D.COLOR WHERE FECHA BETWEEN '" & fecha_i & "' AND '" & fecha_f & "' AND TIPO = 0 AND CLIENTE = '" & cliente.Text & "' GROUP BY CORTES.CPO,CORTES.ESTILO,CORTES.COLOR,F_ENTREGA", cnn)
        For Each dr In cp.Rows
            Try
                fei = dr("F_ENTREGA")
            Catch
                fei = fef
            End Try
            prendas = dr("PRENDAS")
            tt = tt + prendas
            se = DateDiff(DateInterval.Day, fei, fef)
            se = se / 7
            If se < 1 Then
                s(0) = s(0) + prendas
            ElseIf se < 3 Then
                s(1) = s(1) + prendas
            ElseIf se < 5 Then
                s(2) = s(2) + prendas
            Else
                s(3) = s(3) + prendas
            End If
        Next
        Try
            pr = (s(0) * 100) / tt
        Catch
        End Try
        fg(l, 2) = "EMBARQUE  A TIEMPO %"
        fg(l, 3) = pr
        l = l + 1
        fg(l, 2) = "EMBARQUE  A TIEMPO (piezas)"
        fg(l, 3) = s(0)
        l = l + 1
        fg(l, 2) = "EMBARQUE  ATRAZO 1-2 SEMANAS (piezas)"
        fg(l, 3) = s(1)
        l = l + 1
        fg(l, 2) = "EMBARQUE  ATRAZO 3-4 SEMANAS (piezas)"
        fg(l, 3) = s(2)
        l = l + 1
        fg(l, 2) = "EMBARQUE  ATRAZO MAS DE 4 SEMANAS (piezas)"
        fg(l, 3) = s(3)
        l = l + 1
    End Sub

    '===================================== CONSUMO TELA ===================================
    Private Sub consumo_tela()
        Dim con As New DataTable()
        Dim cor As New DataTable()
        Dim pes As New DataTable()
        Dim fean As String
        Dim l As Integer = 1
        Dim dj As DataRow
        Dim dd As DataRow()
        Dim suma As Object
        Dim libras As Decimal
        Dim lineas As Integer
        Dim prendas As Decimal
        Dim dr As DataRow
        fean = Format(DateAdd(DateInterval.DayOfYear, -84, fecha.Value), "yyyy-MM-dd")
        llena_tablas(con, "SELECT ESTILO_CPO,COLOR_CPO,SUM(LIBRAS) AS LIBRAS FROM CONSUMO_TELA WHERE CLIENTE = '" & cliente.Text & "' GROUP BY ESTILO_CPO,COLOR_CPO", cnn)
        llena_tablas(cor, "SELECT ESTILO, SUM(TOTAL) AS PRENDAS FROM CORTES WHERE  CLIENTE = '" & cliente.Text & "' AND FCORTE BETWEEN  '" & fecha_i & "' AND '" & fecha_f & "' GROUP BY ESTILO", cnn)
        llena_tablas(pes, "SELECT TMOVTO,ESTILO,SUM(LIBRAS)AS LIBRAS FROM DMOVTO LEFT JOIN CORTES ON DMOVTO.CORTE = CORTES.CORTE LEFT JOIN ROLLOS ON DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO WHERE TMOVTO IN ('4','2') AND DMOVTO.CORTE IN (SELECT CORTES.CORTE FROM CORTES WHERE CORTES.CLIENTE = '" & cliente.Text & "' AND FCORTE BETWEEN  '" & fecha_i & "' AND '" & fecha_f & "') AND ROLLOS.TIPO = 'TELA' GROUP BY TMOVTO,ESTILO ORDER BY TMOVTO,ESTILO", cnn)
        tela.Rows.Count = cor.Rows.Count + 1
        For Each dr In cor.Rows
            tela(l, 1) = dr("ESTILO")
            tela(l, 2) = dr("PRENDAS")
            prendas = dr("PRENDAS")
            suma = con.Compute("SUM(LIBRAS)", "ESTILO_CPO = '" & dr("ESTILO") & "'")
            Try
                libras = CDec(suma)
            Catch
                libras = 0
            End Try
            suma = con.Compute("COUNT(ESTILO_CPO)", "ESTILO_CPO = '" & dr("ESTILO") & "'")
            Try
                lineas = CDec(suma)
            Catch
                lineas = 0
            End Try
            Try
                tela(l, 3) = Format(libras / lineas, "#######0.00")
            Catch
                tela(l, 3) = 0
            End Try
            dd = pes.Select("ESTILO = '" & dr("ESTILO") & "'")
            libras = 0
            For Each dj In dd
                If dj("TMOVTO") = 4 Then
                    libras = libras + dj("LIBRAS")
                Else
                    libras = libras - dj("LIBRAS")
                End If
            Next


            Try
                tela(l, 4) = Format(libras / dr("PRENDAS"), "#######0.00")

            Catch
                tela(l, 4) = 0
            End Try
            prendas = tela(l, 4)
            l = l + 1
        Next
    End Sub




    Private Sub graba_registros()
        Dim afectados As Integer
        Dim strSQL As String
        Dim fechap As String
        Dim i As Integer
        fechap = Format(CDate(fecha.Text), "yyyy-MM-dd")

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try

            strSQL = "UPDATE INDICADOR SET CPO1 = " & fg(1, 3) & _
                                 " , CPO2 = " & fg(2, 3) & _
                                 " , PROD1 = " & fg(3, 3) & _
                                 " , PROD2 = " & fg(4, 3) & _
                                 " , PROD3 = " & fg(5, 3) & _
                                 " , PROD4 = " & fg(6, 3) & _
                                 " , PROD5 = " & fg(7, 3) & _
                                 " , PROD6 = " & fg(8, 3) & _
                                 " , PROD7 = " & fg(9, 3) & _
                                 " , PROD8 = " & fg(10, 3) & _
                                 " , PROD9 = " & fg(11, 3) & _
                                 " , PROD10 = " & fg(12, 3) & _
                                 " , PROD11 = " & fg(13, 3) & _
                                 " , INV01 = " & fg(14, 3) & _
                                 " , INV02 = " & fg(15, 3) & _
                                 " , INV03 = " & fg(16, 3) & _
                                 " , INV04 = " & fg(17, 3) & _
                                 " , INV05 = " & fg(18, 3) & _
                                 " , INV06 = " & fg(19, 3) & _
                                 " , INV07 = " & fg(20, 3) & _
                                 " , INV08 = " & fg(21, 3) & _
                                 " , SEG01 = " & fg(22, 3) & _
                                 " , SEG02 = " & fg(23, 3) & _
                                 " , SEG03 = " & fg(24, 3) & _
                                 " , PER01 = " & fg(25, 3) & _
                                 " , PER02 = " & fg(26, 3) & _
                                 " , PER03 = " & fg(27, 3) & _
                                 " , PER04 = " & fg(28, 3) & _
                                 " , PER05 = " & fg(29, 3) & _
                                 " WHERE CLIENTE = '" & cliente.Text & "' AND FECHA = '" & fechap & "'"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

            If afectados = 0 Then
                strSQL = "INSERT INTO INDICADOR (CLIENTE,FECHA,CPO1,CPO2,PROD1,PROD2,PROD3,PROD4,PROD5,PROD6,PROD7,PROD8,PROD9,PROD10,PROD11,INV01,INV02,INV03,INV04,INV05,INV06,INV07,INV08,SEG01,SEG02,SEG03,PER01,PER02,PER03,PER04,PER05) " & _
                         "VALUES ( '" & cliente.Text & "','" & _
                                        fechap & "','" & _
                                        fg(1, 3) & "','" & _
                                        fg(2, 3) & "','" & _
                                        fg(3, 3) & "','" & _
                                        fg(4, 3) & "','" & _
                                        fg(5, 3) & "','" & _
                                        fg(6, 3) & "','" & _
                                        fg(7, 3) & "','" & _
                                        fg(8, 3) & "','" & _
                                        fg(9, 3) & "','" & _
                                        fg(10, 3) & "','" & _
                                        fg(11, 3) & "','" & _
                                        fg(12, 3) & "','" & _
                                        fg(13, 3) & "','" & _
                                        fg(14, 3) & "','" & _
                                        fg(15, 3) & "','" & _
                                        fg(16, 3) & "','" & _
                                        fg(17, 3) & "','" & _
                                        fg(18, 3) & "','" & _
                                        fg(19, 3) & "','" & _
                                        fg(20, 3) & "','" & _
                                        fg(21, 3) & "','" & _
                                        fg(22, 3) & "','" & _
                                        fg(23, 3) & "','" & _
                                        fg(24, 3) & "','" & _
                                        fg(25, 3) & "','" & _
                                        fg(26, 3) & "','" & _
                                        fg(27, 3) & "','" & _
                                        fg(28, 3) & "','" & _
                                        fg(28, 3) & "')"
                comando.CommandText = strSQL
                afectados = comando.ExecuteNonQuery()
            End If

            For i = 1 To tela.Rows.Count - 1
                strSQL = "UPDATE INDICADOR_1 SET C_PRES = '" & tela(i, 3) & "' , C_REAL = '" & tela(i, 4) & "' WHERE CLIENTE = '" & _
                                         cliente.Text & "' AND FECHA = '" & fechap & "' AND ESTILO = '" & tela(i, 1) & "'"
                comando.CommandText = strSQL
                afectados = comando.ExecuteNonQuery()

                If afectados = 0 Then
                    strSQL = "INSERT INTO INDICADOR_1 (CLIENTE,FECHA,ESTILO,C_PRES,C_REAL)" & _
                                           "VALUES ( '" & cliente.Text & "','" & _
                                                       fechap & "','" & _
                                                       tela(i, 1) & "','" & _
                                                       tela(i, 3) & "','" & _
                                                       tela(i, 4) & "')"
                    comando.CommandText = strSQL
                    afectados = comando.ExecuteNonQuery()
                End If
            Next


            transaccion.Commit()

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba.Click
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        seguro = MsgBox("Seguro de Querer Grabar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            graba_registros()
            Close()
        End If
    End Sub

    Private Sub prod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prod.Leave
        Dim pd As Decimal
        Try
            pd = CDec(prod.Text)
        Catch
            prod.Text = 0
            prod.Focus()
        End Try
    End Sub


End Class
