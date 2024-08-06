Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized
Imports C1.C1Excel

Public Class Hoja_Resumen2
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dr As DataRow
    Dim path As String
    Dim fechat As Date
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cancela As System.Windows.Forms.Button
    Friend WithEvents S1 As System.Windows.Forms.Button
    Friend WithEvents cliente As System.Windows.Forms.ComboBox
    Friend WithEvents mt As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ma As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Ex As System.Windows.Forms.Button
    Friend WithEvents imprime As System.Windows.Forms.Button
    Friend WithEvents _book As C1.C1Excel.C1XLBook
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Hoja_Resumen2))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Cancela = New System.Windows.Forms.Button()
        Me.S1 = New System.Windows.Forms.Button()
        Me.cliente = New System.Windows.Forms.ComboBox()
        Me.mt = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ma = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Ex = New System.Windows.Forms.Button()
        Me.imprime = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me._book = New C1.C1Excel.C1XLBook()
        CType(Me.mt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancela
        '
        Me.Cancela.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Cancela.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cancela.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancela.ForeColor = System.Drawing.Color.Black
        Me.Cancela.Image = CType(resources.GetObject("Cancela.Image"), System.Drawing.Bitmap)
        Me.Cancela.Location = New System.Drawing.Point(464, 8)
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
        Me.S1.Location = New System.Drawing.Point(424, 8)
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
        Me.cliente.Location = New System.Drawing.Point(136, 8)
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
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = "16,1,0,0,0,85,Columns:0{Width:4;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & _
        "1{Width:150;Name:""AREA"";Caption:""AREA"";AllowEditing:False;DataType:System.String" & _
        ";Format:"" "";TextAlign:LeftCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:350;Name:" & _
        """TEMA"";Caption:""TEMA"";AllowEditing:False;TextAlign:LeftCenter;TextAlignFixed:Lef" & _
        "tCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:100;Name:""VALOR"";DataType:System.Decimal;Format:""###,##0"";Text" & _
        "Align:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{Width:100;DataType:System.Decim" & _
        "al;Format:""###,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{Width:" & _
        "100;DataType:System.Decimal;Format:""###,##0"";TextAlign:RightCenter;TextAlignFixe" & _
        "d:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "6{Width:100;DataType:System.Decimal;Format:""###,##0"";TextAlign:" & _
        "RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{Width:100;DataType:System.Decimal;Fo" & _
        "rmat:""###,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{Width:100;D" & _
        "ataType:System.Decimal;Format:""###,##0"";TextAlign:RightCenter;TextAlignFixed:Cen" & _
        "terCenter;}" & Microsoft.VisualBasic.ChrW(9) & "9{Width:100;DataType:System.Decimal;Format:""###,##0"";TextAlign:Right" & _
        "Center;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "10{Width:100;DataType:System.Decimal;Format" & _
        ":""###,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "11{Width:90;Capti" & _
        "on:""- 1 -"";DataType:System.Decimal;Format:""###,##0"";TextAlign:RightCenter;TextAl" & _
        "ignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "12{Width:90;Caption:""- 2 -"";DataType:System.Decimal;Form" & _
        "at:""###,##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "13{Width:90;Cap" & _
        "tion:""- 3 -"";DataType:System.Decimal;Format:""###,##0"";TextAlign:RightCenter;Text" & _
        "AlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "14{Caption:""- 4 -"";DataType:System.Decimal;Format:""###" & _
        ",##0"";TextAlign:RightCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "15{Width:90;Caption:""-" & _
        " 5 -"";DataType:System.Decimal;Format:""###,##0"";TextAlign:RightCenter;TextAlignFi" & _
        "xed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveDown
        Me.fg.Location = New System.Drawing.Point(8, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 24
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(992, 640)
        Me.fg.StyleInfo = "Normal{Font:Courier New, 9.75pt;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:White;" & _
        "}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:231, 154, 84;ForeColor:Black;Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highli" & _
        "ght{BackColor:Transparent;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{BackColor:233, 163, 99;ForeCol" & _
        "or:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{" & _
        "BackColor:PaleGoldenrod;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Border:Flat," & _
        "1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{" & _
        "BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor:Gainsboro;ForeColor:64, 64" & _
        ", 64;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "estilo1{BackColor" & _
        ":248, 225, 205;Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "estilo2{Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "jap" & _
        "{Format:""##0.00"";TextAlign:RightCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.fg, "Area de datos.")
        '
        'Ex
        '
        Me.Ex.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Ex.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Ex.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ex.ForeColor = System.Drawing.Color.Black
        Me.Ex.Image = CType(resources.GetObject("Ex.Image"), System.Drawing.Bitmap)
        Me.Ex.Location = New System.Drawing.Point(504, 8)
        Me.Ex.Name = "Ex"
        Me.Ex.Size = New System.Drawing.Size(35, 35)
        Me.Ex.TabIndex = 78
        Me.Ex.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Ex, "Presione este Boton si Desea  convertir a Excel los datos del  Inventario.")
        Me.Ex.Visible = False
        '
        'imprime
        '
        Me.imprime.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.imprime.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.imprime.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imprime.ForeColor = System.Drawing.Color.Black
        Me.imprime.Image = CType(resources.GetObject("imprime.Image"), System.Drawing.Bitmap)
        Me.imprime.Location = New System.Drawing.Point(544, 8)
        Me.imprime.Name = "imprime"
        Me.imprime.Size = New System.Drawing.Size(35, 35)
        Me.imprime.TabIndex = 79
        Me.imprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.imprime, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.imprime.Visible = False
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
        'Hoja_Resumen2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(1006, 699)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.imprime, Me.Ex, Me.fg, Me.ma, Me.mt, Me.S1, Me.cliente, Me.Label3, Me.Cancela})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Hoja_Resumen2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Indicadores"
        CType(Me.mt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Hoja_resumen2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        fg.Rows.Count = 31
        cpos()
        produccion()
        inventarios()
        segundas()
        performance()
        proy_exportacion()
        llena_matriz()
        plan_tela()
        plan_produccion()
        proyeccion_exportacion()
        consumo_estilos()
    End Sub

    Private Sub S1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S1.Click
        Cursor = Cursors.WaitCursor
        procesa_datos()
        deshabilita()
        Cursor = Cursors.Default
    End Sub

    Private Sub deshabilita()
        S1.Visible = False
        Ex.Visible = True
        Cancela.Visible = True
        imprime.Visible = True
        cliente.Enabled = False
    End Sub

    '============================== PROCESOS =========================================
    Private Sub cpos()
        agrega_linea(1, 2, "CPO'S", "estilo2")
        fg(1, 2) = "CPO'S ABIERTAS  (Unidades)"
        fg(2, 2) = "CPO'S RECIBIDAS EN LA SEMANA  (Unidades)"
    End Sub

    Private Sub produccion()
        agrega_linea(3, 11, "PRODUCCION", "estilo1")
        fg(3, 2) = "COSTURA  PLAN (Unidades)"
        fg(4, 2) = "COSTURA  REAL (Unidades)"
        fg(5, 2) = "COSTURA  DIFERENCIA  (Unidades)"
        fg(6, 2) = "CORTADO EN LA SEMANA (Unidades)"
        fg(7, 2) = "SERIGRAFIA  (Unidades)"
        fg(8, 2) = "TELA  FPO'S ABIERTOS  (lbs)"
        fg(9, 2) = "TELA  PLAN DE ENTREGAS  (lbs)"
        fg(10, 2) = "TELA  INV.BUEN ESTADO  (lbs)"
        fg(11, 2) = "TELA  PRENDAS CORTADAS  (Unidades)"
        fg(12, 2) = "TELA  INGRESOS A BODEGA  (lbs)"
        fg(13, 2) = "TELA  SALIDAS DE BODEGA  (lbs)"
    End Sub

    Private Sub inventarios()
        agrega_linea(14, 8, "INVENTARIOS", "estilo2")
        fg(14, 2) = "TELAS  STOCK  (lbs)"
        fg(15, 2) = "TELAS  ASIGNADA (lbs)"
        fg(16, 2) = "TELAS  REMANENTE (lbs)"
        fg(17, 2) = "MATERIALES STOCK  ($)"
        fg(18, 2) = "MATERIALES ASIGNADOS  ($)"
        fg(19, 2) = "PRENDAS POR EXPORTAR  (Unidades)"
        fg(20, 2) = "INV. STOCK PRIMERAS  (Unidades)"
        fg(21, 2) = "INV. STOCK SEGUNDAS  (Unidades)"
    End Sub

    Private Sub segundas()
        agrega_linea(22, 3, "SEGUNDAS", "estilo1")
        fg(22, 2) = "SEGUNDAS  (Unidades)"
        fg(23, 2) = "SEGUNDAS  % ESTA SEMANA"
        fg(24, 2) = "SEGUNDAS  % PROM 4 SEMANAS"
    End Sub

    '===================================== PERFORMANCE  ==========================================
    Private Sub performance()
        agrega_linea(25, 4, "PERFORMANCE", "estilo2")
        fg(25, 2) = "EMBARQUE  A TIEMPO %"
        fg(26, 2) = "EMBARQUE  A TIEMPO (Unidades)"
        fg(27, 2) = "EMBARQUE  ATRAZO 1-2 SEMANAS (Unidades)"
        fg(28, 2) = "EMBARQUE  ATRAZO 3-4 SEMANAS (Unidades)"
        fg(29, 2) = "EMBARQUE  ATRAZO MAS DE 4 SEMANAS (Unidades)"
    End Sub

    '===================================== PROYECCION EXPORT  ==========================================
    Private Sub proy_exportacion()
        agrega_linea(30, 0, "PROY. EXPORTAC.", "estilo1")
        fg(30, 2) = "PROYECCION EXPORTACION (Unidades)"
    End Sub

    Private Sub agrega_linea(ByVal l As Integer, ByVal i As Integer, ByVal area As String, ByVal estilo As String)
        Dim r As Integer
        For r = l To l + i
            fg(r, 1) = area
            fg.Rows(r).Style = fg.Styles(estilo)
        Next
    End Sub

    Private Sub Cancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancela.Click
        habilita()
    End Sub

    Private Sub habilita()
        cliente.Enabled = True
        S1.Visible = True
        Cancela.Visible = False
        Ex.Visible = False
        imprime.Visible = False
        setea_fg()
        ma.Rows.Count = 1
        mt.Rows.Count = 1
    End Sub

    Private Sub llena_matriz()
        Dim i As Integer
        Dim j As Integer = 10
        Dim dt As New DataTable()
        llena_tablas(dt, "SELECT TOP 8 * FROM INDICADOR WHERE CLIENTE = '" & cliente.Text & "' ORDER BY FECHA DESC", cnn)
        For Each Me.dr In dt.Rows
            fg(0, j) = Format(dr("FECHA"), "dd-MMM-yyyy")
            If j = 10 Then
                fechat = dr("FECHA")
            End If
            For i = 1 To 29
                fg(i, j) = dr(i + 1)
            Next
            j = j - 1
        Next
    End Sub

    Private Sub plan_tela()
        Dim dj As New DataTable()
        Dim fecha_tela As String = Format(fechat, "yyyy-MM-dd")
        Dim l As Integer
        fg(9, 10) = 0
        llena_tablas(dj, "SELECT OFECHA, SUM(LIBRAS) AS TLIBRAS FROM FPO WHERE CLIENTE = '" & cliente.Text & "' AND STATUS = 'ABIERTO' AND RECIBIDAS = 0 AND TIPO = 'TELA' AND OFECHA > = '" & fecha_tela & "' GROUP BY OFECHA", cnn)
        For Each Me.dr In dj.Rows
            l = DateDiff(DateInterval.Day, fechat, dr("OFECHA"))
            If l < 7 Then
                l = 0
            Else
                l = Int(l / 7)
            End If
            If l < 6 Then
                fg(9, l + 10) = fg(9, l + 10) + dr("TLIBRAS")
            End If
        Next
    End Sub

    Private Sub plan_produccion()
        Dim i As Integer
        For i = 11 To 15
            fg(3, i) = fg(3, 10)
        Next
    End Sub

    Private Sub proyeccion_exportacion()
        Dim dj As New DataTable()
        Dim fecha_tela As String = Format(fechat, "yyyy-MM-dd")
        Dim l As Integer
        fg(30, 10) = 0
        llena_tablas(dj, "SELECT EXP_REV, SUM(TOTAL) AS PRENDAS  FROM WIP0 LEFT JOIN CPO ON WIP0.CPO = CPO.CPO LEFT JOIN CPO_D ON (WIP0.CPO+WIP0.ESTILO+WIP0.COLOR) = (CPO_D.CPO+CPO_D.ESTILO+CPO_D.COLOR)  WHERE ESTADO ='A' AND CLIENTE = '" & cliente.Text & "' AND EXP_REV > = '" & fecha_tela & "' GROUP BY EXP_REV ORDER BY EXP_REV", cnn)
        For Each Me.dr In dj.Rows
            l = DateDiff(DateInterval.Day, fechat, dr("EXP_REV"))
            If l < 7 Then
                l = 0
            Else
                l = Int(l / 7)
            End If
            If l < 6 Then
                fg(30, l + 10) = fg(30, l + 10) + dr("PRENDAS")
            End If
        Next
    End Sub
    '============================== CONSUMO ESTILOS =====================================
    Private Sub consumo_estilos()
        Dim ind1 As New DataTable()
        Dim ind2 As New DataTable()
        Dim fecha As String = ""
        Dim l As Integer = fg.Cols.Count - 1
        Dim c As Integer
        Dim estilo As String
        Dim fec As String
        Dim R As String = "                         "
        busca_final(fecha)
        llena_tablas(ind1, "SELECT DISTINCT ESTILO, C_PRES FROM INDICADOR_1 WHERE FECHA > = '" & fecha & "' AND CLIENTE = '" & cliente.Text & "' ORDER BY ESTILO", cnn)
        l = ind1.Rows.Count
        fg.Rows.Count = 31 + l + 1
        agrega_linea(31, l, "CONSUMO TELA", "estilo2")
        l = 31
        For Each Me.dr In ind1.Rows
            fg(l, 0) = dr("ESTILO")
            estilo = dr("ESTILO") + R
            estilo = Mid(estilo, 1, 18) + "STD " + Format(dr("C_PRES"), "##0.00") + "  Lbs."
            fg(l, 2) = estilo
            l = l + 1
        Next
        llena_tablas(ind1, "SELECT * FROM INDICADOR_1 WHERE FECHA > = '" & fecha & "' AND CLIENTE = '" & cliente.Text & "' ORDER BY ESTILO", cnn)
        For Each Me.dr In ind1.Rows
            estilo = dr("ESTILO")
            fec = Format(dr("FECHA"), "dd-MMM-yyyy")
            l = fg.FindRow(estilo, 31, 0, False)
            busca_col(c, fec)
            If l > 0 And c > 0 Then
                fg.SetCellStyle(l, c, "jap")
                fg(l, c) = Format(dr("C_REAL"), "##0.00")
            End If
        Next
    End Sub

    Private Sub busca_col(ByRef col As Integer, ByVal fec As String)
        Dim i As Integer
        col = -1
        For i = 3 To 10
            If fec = fg(0, i) Then
                col = i
                Exit Sub
            End If
        Next
    End Sub

    Private Sub busca_final(ByRef fecha As String)
        Dim i As Integer
        For i = 3 To 10
            If fg(0, i) <> Nothing Then
                fecha = Format(CDate(fg(0, i)), "yyyy-MM-dd")
                Exit Sub
            End If
        Next
    End Sub

    Private Sub Ex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ex.Click
        Dim ok As Boolean
        a_exceles(ok)
        If ok Then
            Close()
        End If
    End Sub

    Private Sub imprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imprime.Click
        print_fg()
    End Sub

    Private Sub print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        Dim mal As String = ""
        fecha = Format(Today, "dd/MMM/yyy")
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = True
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("Indicadores", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, cliente.Text + "  Indicadores al " + fecha + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub a_exceles(ByRef ok As Boolean)
        path = "c:\reportes\" + cliente.Text + "_Indicadores" + ".xls"
        Try
            If File.Exists(path) Then
                File.Delete(path)
            End If
        Catch
        End Try

        Try
            _book.Clear()
            _book.Sheets.Clear()
            Dim sheet As XLSheet = _book.Sheets.Add("Indicadores")
            SaveSheet(_book, fg, sheet, True)
            _book.Sheets.SelectedIndex = 0
            _book.Save(path)
            ok = True
            System.Diagnostics.Process.Start(path)
            MsgBox("Sus datos fueron trasladados a Excel en el directorio: " + path, MsgBoxStyle.OKOnly, "TRASLADO DE DATOS ")
        Catch
            MsgBox("Por favor cierre todas sus Hojas de Excel y vuelva a tratar. Gracias", MsgBoxStyle.OKOnly, "Atencion ")
            ok = False
        End Try
    End Sub

End Class
