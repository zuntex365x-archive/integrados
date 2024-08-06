Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Bal_tela_prod_d
    Inherits System.Windows.Forms.Form
    Public codigo As String
    Public descripcion As String
    Public colores As String
    Public necesario As Decimal
    Public inventar As Decimal
    Public pedido As Decimal
    Public balance As Decimal
    Public cliente As String
    Public WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Dim h As String = "#######"
    Dim ok As Boolean
    Dim si As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim estados As New ComboBox()
    Public tsd As New DataTable()
    Dim hoy As Date = Today
    Dim dis As Integer = hoy.DayOfWeek
    Dim pd As Date
    Dim fei As Date
    Dim con As DataTable
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Pe As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents colors As System.Windows.Forms.Label
    Friend WithEvents desc_tela As System.Windows.Forms.Label
    Friend WithEvents Codi As System.Windows.Forms.Label
    Friend WithEvents ct As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fo As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Bal_tela_prod_d))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Pe = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ct = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.fo = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.desc_tela = New System.Windows.Forms.Label()
        Me.colors = New System.Windows.Forms.Label()
        Me.Codi = New System.Windows.Forms.Label()
        CType(Me.Pe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pe
        '
        Me.Pe.AllowEditing = False
        Me.Pe.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Pe.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Pe.BackColor = System.Drawing.Color.White
        Me.Pe.ColumnInfo = "16,1,0,0,0,85,Columns:0{Width:0;AllowEditing:False;DataType:System.String;TextAli" & _
        "gn:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1{Width:130;DataType:System.String;Tex" & _
        "tAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:90;Caption:""22-abr-2012"";A" & _
        "llowEditing:False;DataType:System.Decimal;Format:""####,##0"";TextAlign:RightCente" & _
        "r;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:90;Name:""1"";DataType:System.Decimal;Form" & _
        "at:""####,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{Width:90;Nam" & _
        "e:""2"";DataType:System.Decimal;Format:""####,##0"";TextAlign:RightCenter;TextAlignF" & _
        "ixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{Width:90;Name:""3"";DataType:System.Decimal;Format:""####,##0" & _
        """;TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "6{Width:90;Name:""4"";DataTy" & _
        "pe:System.Decimal;Format:""####,##0"";TextAlign:RightCenter;TextAlignFixed:CenterC" & _
        "enter;}" & Microsoft.VisualBasic.ChrW(9) & "7{Width:90;Name:""5"";DataType:System.Decimal;Format:""####,##0"";TextAlign:" & _
        "RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{Width:90;Name:""6"";DataType:System.De" & _
        "cimal;Format:""####,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "9{Wi" & _
        "dth:90;Name:""7"";DataType:System.Decimal;Format:""####,##0"";TextAlign:RightCenter;" & _
        "TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "10{Width:90;Name:""8"";DataType:System.Decimal;Forma" & _
        "t:""####,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "11{Width:90;Nam" & _
        "e:""9"";DataType:System.Decimal;Format:""####,##0"";TextAlign:RightCenter;TextAlignF" & _
        "ixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "12{Width:90;Name:""10"";DataType:System.Decimal;Format:""####,#" & _
        "#0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "13{Width:90;Name:""11"";Da" & _
        "taType:System.Decimal;Format:""####,##0"";TextAlign:RightCenter;TextAlignFixed:Cen" & _
        "terCenter;}" & Microsoft.VisualBasic.ChrW(9) & "14{Width:100;Name:""12"";DataType:System.Decimal;Format:""####,##0"";Tex" & _
        "tAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "15{Width:90;Name:""13"";DataType:" & _
        "System.Decimal;Format:""####,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCent" & _
        "er;}" & Microsoft.VisualBasic.ChrW(9)
        Me.Pe.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Pe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pe.ForeColor = System.Drawing.Color.Black
        Me.Pe.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Pe.Location = New System.Drawing.Point(8, 64)
        Me.Pe.Name = "Pe"
        Me.Pe.Rows.DefaultSize = 17
        Me.Pe.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Pe.Size = New System.Drawing.Size(1424, 208)
        Me.Pe.StyleInfo = "Normal{Font:Microsoft Sans Serif, 8.25pt;BackColor:White;ForeColor:Black;TextAlig" & _
        "n:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:8, 111, 171;ForeColor" & _
        ":White;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:Black;ForeColor:Whit" & _
        "e;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen" & _
        "{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Border:Flat,1,Contr" & _
        "olDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{Font:Mi" & _
        "crosoft Sans Serif, 8.25pt, style=Bold;BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtota" & _
        "l1{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:186, 196, 228;ForeCol" & _
        "or:Black;ImageAlign:RightTop;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor:Whi" & _
        "te;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:C" & _
        "ontrolDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "rojo{BackColor:Red;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "verde{BackColor:135, 214, 101;}" & Microsoft.VisualBasic.ChrW(9) & "amar" & _
        "illo{BackColor:218, 232, 94;}" & Microsoft.VisualBasic.ChrW(9)
        Me.Pe.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Pe.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.Pe, "Celdas en Rojo muestran Faltante en tela.")
        '
        'ct
        '
        Me.ct.AllowEditing = False
        Me.ct.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.ct.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.ct.BackColor = System.Drawing.Color.FromArgb(CType(243, Byte), CType(193, Byte), CType(137, Byte))
        Me.ct.ColumnInfo = "16,1,0,0,0,85,Columns:0{Width:0;AllowEditing:False;DataType:System.String;TextAli" & _
        "gn:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1{Width:130;DataType:System.String;Tex" & _
        "tAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:90;Caption:""22-abr-2012"";A" & _
        "llowEditing:False;DataType:System.Decimal;Format:""####,##0"";TextAlign:RightCente" & _
        "r;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:90;Name:""1"";DataType:System.Decimal;Form" & _
        "at:""####,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{Width:90;Nam" & _
        "e:""2"";DataType:System.Decimal;Format:""####,##0"";TextAlign:RightCenter;TextAlignF" & _
        "ixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{Width:90;Name:""3"";DataType:System.Decimal;Format:""####,##0" & _
        """;TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "6{Width:90;Name:""4"";DataTy" & _
        "pe:System.Decimal;Format:""####,##0"";TextAlign:RightCenter;TextAlignFixed:CenterC" & _
        "enter;}" & Microsoft.VisualBasic.ChrW(9) & "7{Width:90;Name:""5"";DataType:System.Decimal;Format:""####,##0"";TextAlign:" & _
        "RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{Width:90;Name:""6"";DataType:System.De" & _
        "cimal;Format:""####,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "9{Wi" & _
        "dth:90;Name:""7"";DataType:System.Decimal;Format:""####,##0"";TextAlign:RightCenter;" & _
        "TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "10{Width:90;Name:""8"";DataType:System.Decimal;Forma" & _
        "t:""####,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "11{Width:90;Nam" & _
        "e:""9"";DataType:System.Decimal;Format:""####,##0"";TextAlign:RightCenter;TextAlignF" & _
        "ixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "12{Width:90;Name:""10"";DataType:System.Decimal;Format:""####,#" & _
        "#0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "13{Width:90;Name:""11"";Da" & _
        "taType:System.Decimal;Format:""####,##0"";TextAlign:RightCenter;TextAlignFixed:Cen" & _
        "terCenter;}" & Microsoft.VisualBasic.ChrW(9) & "14{Width:100;Name:""12"";DataType:System.Decimal;Format:""####,##0"";Tex" & _
        "tAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "15{Width:90;Name:""13"";DataType:" & _
        "System.Decimal;Format:""####,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCent" & _
        "er;}" & Microsoft.VisualBasic.ChrW(9)
        Me.ct.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ct.ForeColor = System.Drawing.Color.Black
        Me.ct.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.ct.Location = New System.Drawing.Point(8, 304)
        Me.ct.Name = "ct"
        Me.ct.Rows.DefaultSize = 17
        Me.ct.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.ct.Size = New System.Drawing.Size(1424, 248)
        Me.ct.StyleInfo = "Normal{Font:Microsoft Sans Serif, 8.25pt;BackColor:243, 193, 137;ForeColor:Black;" & _
        "TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:243, 193, 137;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:8, 11" & _
        "1, 171;ForeColor:White;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:237," & _
        " 164, 82;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor" & _
        ":HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorksp" & _
        "ace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:Wh" & _
        "ite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:Black;Fo" & _
        "reColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColo" & _
        "r:186, 196, 228;ForeColor:Black;ImageAlign:RightTop;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:Contro" & _
        "lDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;" & _
        "}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:Cont" & _
        "rolDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "rojo{BackColor:Yellow;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9)
        Me.ct.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.ct.TabIndex = 73
        '
        'fo
        '
        Me.fo.AllowEditing = False
        Me.fo.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fo.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fo.BackColor = System.Drawing.Color.FromArgb(CType(166, Byte), CType(177, Byte), CType(240, Byte))
        Me.fo.ColumnInfo = "16,1,0,0,0,85,Columns:0{Width:0;AllowEditing:False;DataType:System.String;TextAli" & _
        "gn:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1{Width:130;DataType:System.String;Tex" & _
        "tAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:90;Caption:""22-abr-2012"";A" & _
        "llowEditing:False;DataType:System.Decimal;Format:""####,##0"";TextAlign:RightCente" & _
        "r;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:90;Name:""1"";DataType:System.Decimal;Form" & _
        "at:""####,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{Width:90;Nam" & _
        "e:""2"";DataType:System.Decimal;Format:""####,##0"";TextAlign:RightCenter;TextAlignF" & _
        "ixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{Width:90;Name:""3"";DataType:System.Decimal;Format:""####,##0" & _
        """;TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "6{Width:90;Name:""4"";DataTy" & _
        "pe:System.Decimal;Format:""####,##0"";TextAlign:RightCenter;TextAlignFixed:CenterC" & _
        "enter;}" & Microsoft.VisualBasic.ChrW(9) & "7{Width:90;Name:""5"";DataType:System.Decimal;Format:""####,##0"";TextAlign:" & _
        "RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{Width:90;Name:""6"";DataType:System.De" & _
        "cimal;Format:""####,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "9{Wi" & _
        "dth:90;Name:""7"";DataType:System.Decimal;Format:""####,##0"";TextAlign:RightCenter;" & _
        "TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "10{Width:90;Name:""8"";DataType:System.Decimal;Forma" & _
        "t:""####,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "11{Width:90;Nam" & _
        "e:""9"";DataType:System.Decimal;Format:""####,##0"";TextAlign:RightCenter;TextAlignF" & _
        "ixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "12{Width:90;Name:""10"";DataType:System.Decimal;Format:""####,#" & _
        "#0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "13{Width:90;Name:""11"";Da" & _
        "taType:System.Decimal;Format:""####,##0"";TextAlign:RightCenter;TextAlignFixed:Cen" & _
        "terCenter;}" & Microsoft.VisualBasic.ChrW(9) & "14{Width:100;Name:""12"";DataType:System.Decimal;Format:""####,##0"";Tex" & _
        "tAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "15{Width:90;Name:""13"";DataType:" & _
        "System.Decimal;Format:""####,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCent" & _
        "er;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fo.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fo.ForeColor = System.Drawing.Color.Black
        Me.fo.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fo.Location = New System.Drawing.Point(8, 592)
        Me.fo.Name = "fo"
        Me.fo.Rows.DefaultSize = 17
        Me.fo.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fo.Size = New System.Drawing.Size(1424, 176)
        Me.fo.StyleInfo = "Normal{Font:Microsoft Sans Serif, 8.25pt;BackColor:166, 177, 240;ForeColor:Black;" & _
        "TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:166, 177, 240;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:8, 11" & _
        "1, 171;ForeColor:White;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:135," & _
        " 150, 235;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColo" & _
        "r:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:Black;F" & _
        "oreColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackCol" & _
        "or:186, 196, 228;ForeColor:Black;ImageAlign:RightTop;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:Contr" & _
        "olDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White" & _
        ";}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:Con" & _
        "trolDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "rojo{BackColor:Yellow;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fo.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fo.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 16)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Prendas por Cortar"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 576)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Tela Pedida"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 24)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Tela:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Color:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'desc_tela
        '
        Me.desc_tela.BackColor = System.Drawing.Color.White
        Me.desc_tela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.desc_tela.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desc_tela.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.desc_tela.Location = New System.Drawing.Point(176, 8)
        Me.desc_tela.Name = "desc_tela"
        Me.desc_tela.Size = New System.Drawing.Size(648, 24)
        Me.desc_tela.TabIndex = 70
        Me.desc_tela.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colors
        '
        Me.colors.BackColor = System.Drawing.Color.White
        Me.colors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.colors.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.colors.Location = New System.Drawing.Point(72, 32)
        Me.colors.Name = "colors"
        Me.colors.Size = New System.Drawing.Size(752, 24)
        Me.colors.TabIndex = 71
        Me.colors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Codi
        '
        Me.Codi.BackColor = System.Drawing.Color.White
        Me.Codi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Codi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codi.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Codi.Location = New System.Drawing.Point(72, 8)
        Me.Codi.Name = "Codi"
        Me.Codi.Size = New System.Drawing.Size(96, 24)
        Me.Codi.TabIndex = 72
        Me.Codi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Bal_tela_prod_d
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(1434, 792)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.fo, Me.ct, Me.Codi, Me.colors, Me.desc_tela, Me.Label1, Me.Pe, Me.Label6, Me.Label3, Me.Label2})
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Bal_tela_prod_d"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance de Tela por Fecha de Produccion"
        CType(Me.Pe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Overloads Sub Bal_tela_Det(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Codi.Text = codigo
        desc_tela.Text = descripcion
        colors.Text = colores
        setea_grids()
        inventario_inicial()
        llena_pe()
        llena_fo()
        acumula_valores()
        'Cursor = Cursors.Default
    End Sub

    Private Sub resumen()
        Dim i As Integer
        For i = 1 To Pe.Rows.Count - 1
            If Pe(i, 9) < 0 Then
                Pe.SetCellStyle(i, 9, Pe.Styles("rojo"))
            End If
        Next
    End Sub

    Private Sub setea_grids()
        Dim i As Integer
        Dim su(0, 7, 6, 5, 4, 3, 2, 1) As Integer
        Pe.Rows.Count = 1
        fo.Rows.Count = 1
        ct.Rows.Count = 1
        Pe.Cols(0).Width = 5
        ct.Rows(0).Height = 30
        fo.Rows(0).Height = 30
        Pe.Rows(0).Height = 30
        Pe.Rows.Count = 7
        pd = hoy.AddDays(-dis)
        Pe(0, 2) = UCase(Format(pd, "dd-MMM-yyyy"))
        ct(0, 2) = UCase(Format(pd, "dd-MMM-yyyy"))
        fo(0, 2) = UCase(Format(pd, "dd-MMM-yyyy"))
        fei = pd
        For i = 1 To 12
            pd = pd.AddDays(7)
            Pe(0, i + 2) = UCase(Format(pd, "dd-MMM-yyyy"))
            ct(0, i + 2) = UCase(Format(pd, "dd-MMM-yyyy"))
            fo(0, i + 2) = UCase(Format(pd, "dd-MMM-yyyy"))
        Next
        Pe(0, 15) = "> " & Pe(0, 14)
        ct(0, 15) = "> " & ct(0, 14)
        fo(0, 15) = "> " & fo(0, 14)
        Pe(1, 1) = "Costura"
        Pe(2, 1) = "Necesidad Tela"
        Pe(3, 1) = "FPO'S"
        Pe(4, 1) = "Acumulado nec."
        Pe(5, 1) = "Acumulado Tela"
        Pe(6, 1) = "Inventario"
        fo(0, 1) = "FPO"
        ct(0, 1) = "CPO"
        llena_tablas(con, "SELECT * FROM CONSUMO_TELA LEFT JOIN ESTILOS ON ESTILOS.ESTILO = CONSUMO_TELA.ESTILO_CPO WHERE CODIGO = '" & codigo & "' AND COLOR_TELA = '" & colores & "'", cnn)
        Pe.Rows(1).Style = Pe.Styles("amarillo")
        Pe.Rows(6).Style = Pe.Styles("verde")
    End Sub

    Private Sub llena_pe()
        Dim dt As New DataTable()
        Dim wp As New DataTable()
        Dim cortar As Integer
        Dim pedido As Integer
        Dim cortado As Integer
        Dim proceso As Integer
        Dim pproc As Object
        Dim dd As DataRow()
        Dim dw As DataRow
        Dim fec As Date
        Dim col As Integer
        Dim nec As Decimal
        Dim co As Decimal
        Dim l As Integer = 1
        Dim dias As Integer
        Dim fect As Date
        Dim strSQL As String = "SELECT CPO_D.CPO,ESTILO,COLOR,TOTAL,CPO_D.F_ENTREGA,(SELECT SUM(TOTAL) FROM CORTES WHERE CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR AND ESTADO = 'A') AS CORTADO, (SELECT SUM(TOTAL) FROM CORTES_S WHERE CORTES_S.CPO = CPO_D.CPO AND CORTES_S.ESTILO = CPO_D.ESTILO AND CORTES_S.COLOR = CPO_D.COLOR AND ESTADO = 'A') AS PROCESO FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE CLIENTE = '" & cliente & "' AND ESTADO = 'A' AND ESTILO + COLOR IN (SELECT ESTILO_CPO + COLOR_CPO FROM CONSUMO_TELA WHERE CODIGO = '" & codigo & "' AND COLOR_TELA = '" & colors.Text & "')"
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn)
        strSQL = "SELECT * FROM WIP0 WHERE ESTILO + COLOR IN (SELECT ESTILO_CPO + COLOR_CPO FROM CONSUMO_TELA WHERE CODIGO = '" & codigo & "' AND COLOR_TELA = '" & colors.Text & "')"
        llena_tablas(wp, strSQL, cnn)
        For Each dr In dt.Rows
            dias = 28
            Try
                pedido = dr("TOTAL")
            Catch
                pedido = 0
            End Try
            Try
                cortado = dr("CORTADO")
            Catch
                cortado = 0
            End Try
            Try
                proceso = dr("PROCESO")
            Catch
                proceso = 0
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
            cortar = pedido - cortado - proceso
            nec = 0
            If cortar > 0 Then
                l = ct.Rows.Count
                ct.Rows.Count = l + 1
                dd = con.Select("ESTILO_CPO = '" & dr("ESTILO") & "'")
                If dd.Length > 0 Then
                    dw = dd(0)
                    co = dw("LIBRAS")
                    nec = co * cortar
                    Try
                        If dw("O2") = True Then
                            dias = 21
                        End If

                        If (dw("O2") = False) And (dw("O3") = False) Then
                            dias = 14
                        End If
                    Catch
                    End Try
                End If
                dd = wp.Select("CPO = '" & dr("CPO") & "' AND ESTILO = '" & dr("ESTILO") & "' AND COLOR = '" & dr("COLOR") & "'")
                fec = fei
                If dd.Length > 0 Then
                    dw = dd(0)
                    fec = dw("SEW_PLAN")
                    fect = fec.AddDays(-dias)
                    If Year(fec) = "1900" Then
                        fec = fei
                        fect = fec
                    End If
                End If
                determina_columna(fec, col)
                Pe(1, col) = Pe(1, col) + cortar
                ct(l, 1) = dr("CPO")
                ct(l, col) = ct(l, col) + cortar
                determina_columna(fect, col)
                Pe(2, col) = Pe(2, col) + nec
            End If
        Next
    End Sub

    Private Sub determina_columna(ByVal fecha As Date, ByRef col As Integer)
        Dim si As Integer
        Dim res As Integer
        si = DateDiff(DateInterval.Day, fei, fecha)
        res = si Mod 7
        col = Fix(si / 7) + 2
        If res > 0 Then
            col = col + 1
        End If
        If col > 15 Then
            col = 15
        End If
        If col < 2 Then
            col = 2
        End If
    End Sub

    Private Sub acumula_valores()
        Dim i As Integer
        Pe(4, 2) = Pe(2, 2)
        Pe(5, 2) = Pe(5, 2) + Pe(3, 2)
        Pe(6, 2) = Pe(5, 2) - Pe(4, 2)
        If Pe(6, 2) < 0 Then
            Pe.SetCellStyle(6, 2, Pe.Styles("rojo"))
        End If
        For i = 3 To 15
            Pe(4, i) = Pe(4, i - 1) + Pe(2, i)
            Pe(5, i) = Pe(5, i - 1) + Pe(3, i)
            Pe(6, i) = Pe(5, i) - Pe(4, i)
            If Pe(6, i) < 0 Then
                Pe.SetCellStyle(6, i, Pe.Styles("rojo"))
            End If
        Next
    End Sub

    '=============================================== Inventario ================================================
    Private Sub inventario_inicial()
        Dim dt As New DataTable()
        Dim libras As Decimal
        Dim strSQL As String = "SELECT SUM((ROLLOS.PESO/ROLLOS.YARDAS_I) * ROLLOS.YARDAS) AS LIBRAS FROM ROLLOS WHERE CODIGO = '" & codigo & "' AND COLOR = '" & colores & "' AND YARDAS > 0 AND CLIENTE = '" & cliente & "' AND ACTIVO IN ('S','0','5')"
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            libras = 0
            Try
                libras = dr("LIBRAS")
            Catch
            End Try
            Pe(5, 2) = libras
        Next
    End Sub

    '=============================================== TELA PEDIDA   ================================================
    Private Sub llena_fo()
        Dim dt As New DataTable()
        Dim pedidos As Decimal
        Dim c As Integer
        Dim strSQL As String = "SELECT FPO,CLIENTE,OFECHA,SUM(LIBRAS - RECIBIDAS) AS PEDIDO FROM FPO WHERE CODIGO = '" & codigo & "' AND COLOR = '" & colores & "' AND TIPO = 'TELA' AND STATUS = 'ABIERTO' AND CLIENTE = '" & cliente & "' AND RECIBIDAS = 0 GROUP BY FPO,CLIENTE,OFECHA"
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn)
        lineas = dt.Rows.Count
        fo.Rows.Count = lineas + 1
        lineas = 1
        For Each dr In dt.Rows
            pedidos = dr("PEDIDO")
            determina_columna(dr("OFECHA"), c)
            fo(lineas, 1) = dr("FPO")
            fo(lineas, c) = fo(lineas, c) + pedidos
            Pe(3, c) = Pe(3, c) + pedidos
            lineas = lineas + 1
        Next
    End Sub

    Private Sub Pe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pe.DoubleClick
        Dim forma As New Bal_tela_prod_dd1()
        forma.codigo = Codi.Text
        forma.descripcion = desc_tela.Text
        forma.colores = colors.Text
        forma.cliente = cliente
        forma.tsd = tsd
        forma.ShowDialog()
    End Sub
End Class



