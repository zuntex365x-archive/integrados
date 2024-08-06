Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Bal_Tela_Det_c
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Co As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Pe As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Ta As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents colors As System.Windows.Forms.Label
    Friend WithEvents desc_tela As System.Windows.Forms.Label
    Friend WithEvents Codi As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Bal_Tela_Det_c))
        Me.Ta = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Co = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Pe = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.desc_tela = New System.Windows.Forms.Label()
        Me.colors = New System.Windows.Forms.Label()
        Me.Codi = New System.Windows.Forms.Label()
        CType(Me.Ta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Co, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ta
        '
        Me.Ta.AllowEditing = False
        Me.Ta.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Ta.BackColor = System.Drawing.Color.FromArgb(CType(251, Byte), CType(210, Byte), CType(222, Byte))
        Me.Ta.ColumnInfo = "10,1,0,0,0,85,Columns:0{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1{TextAl" & _
        "ign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{TextAlign:LeftCenter;TextAlignFixed" & _
        ":LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{TextAlign:Lef" & _
        "tCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{TextAlign:LeftCenter;TextAlignFixed:LeftCe" & _
        "nter;}" & Microsoft.VisualBasic.ChrW(9) & "6{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{TextAlign:LeftCenter" & _
        ";TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & _
        "9{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.Ta.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Ta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ta.ForeColor = System.Drawing.Color.Black
        Me.Ta.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Ta.Location = New System.Drawing.Point(8, 272)
        Me.Ta.Name = "Ta"
        Me.Ta.Rows.DefaultSize = 17
        Me.Ta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Ta.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Ta.Size = New System.Drawing.Size(1288, 280)
        Me.Ta.StyleInfo = "Normal{Font:Microsoft Sans Serif, 8.25pt;BackColor:251, 210, 222;ForeColor:Black;" & _
        "TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:251, 210, 222;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:95, 1" & _
        "56, 239;ForeColor:Black;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:Bla" & _
        "ck;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor:Highl" & _
        "ightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Bo" & _
        "rder:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & _
        "Subtotal0{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:Black;ForeColo" & _
        "r:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:186," & _
        " 196, 228;ForeColor:Black;ImageAlign:RightTop;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkD" & _
        "ark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subt" & _
        "otal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDar" & _
        "kDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "rojo{BackColor:Red;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9)
        Me.Ta.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Ta.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.Ta, "Celdas resaltadas indican que la Tela del inventario está asignada a CPO's  no Ac" & _
        "tivos.")
        '
        'Co
        '
        Me.Co.AllowEditing = False
        Me.Co.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Co.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Co.BackColor = System.Drawing.Color.FromArgb(CType(183, Byte), CType(244, Byte), CType(221, Byte))
        Me.Co.ColumnInfo = "10,1,0,0,0,85,Columns:0{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1{TextAl" & _
        "ign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{TextAlign:LeftCenter;TextAlignFixed" & _
        ":LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{TextAlign:Lef" & _
        "tCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{TextAlign:LeftCenter;TextAlignFixed:LeftCe" & _
        "nter;}" & Microsoft.VisualBasic.ChrW(9) & "6{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{TextAlign:LeftCenter" & _
        ";TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & _
        "9{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.Co.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Co.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Co.ForeColor = System.Drawing.Color.Black
        Me.Co.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Co.Location = New System.Drawing.Point(8, 592)
        Me.Co.Name = "Co"
        Me.Co.Rows.DefaultSize = 17
        Me.Co.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Co.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Co.Size = New System.Drawing.Size(1288, 176)
        Me.Co.StyleInfo = "Normal{Font:Microsoft Sans Serif, 8.25pt;BackColor:183, 244, 221;ForeColor:Black;" & _
        "TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:183, 244, 221;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:95, 1" & _
        "56, 239;ForeColor:Black;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:Bla" & _
        "ck;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor:Highl" & _
        "ightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Bo" & _
        "rder:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & _
        "Subtotal0{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:Black;ForeColo" & _
        "r:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:186," & _
        " 196, 228;ForeColor:Black;ImageAlign:RightTop;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkD" & _
        "ark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subt" & _
        "otal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDar" & _
        "kDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "verde{BackColor:Olive;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9)
        Me.Co.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Co.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.Co, "Celdas resaltadas indican que la Tela fue pedida para CPO's no Acitvas.")
        '
        'Pe
        '
        Me.Pe.AllowEditing = False
        Me.Pe.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Pe.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Pe.BackColor = System.Drawing.Color.FromArgb(CType(253, Byte), CType(249, Byte), CType(198, Byte))
        Me.Pe.ColumnInfo = "11,1,0,0,0,85,Columns:0{Width:10;AllowEditing:False;DataType:System.String;TextAl" & _
        "ign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1{Width:140;Caption:""CPO"";AllowEditin" & _
        "g:False;DataType:System.String;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & _
        "2{Width:140;Caption:""ESTILO"";AllowEditing:False;DataType:System.String;TextAlign" & _
        ":LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:135;Caption:""COLOR"";AllowEditing" & _
        ":False;DataType:System.String;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4" & _
        "{Width:85;Caption:""CONSUMO"";AllowEditing:False;DataType:System.Decimal;Format:""#" & _
        "#,##0.00"";TextAlign:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{Width:85;Caption:" & _
        """X CORTAR"";AllowEditing:False;DataType:System.Decimal;Format:""##,##0"";TextAlign:" & _
        "RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "6{Width:85;Caption:""LBS.NECE."";AllowEdi" & _
        "ting:False;DataType:System.Decimal;Format:""##,##0.00"";TextAlign:RightCenter;Text" & _
        "AlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{Width:85;Caption:""LBS.ASIG"";DataType:System.Decimal;F" & _
        "ormat:""##,##0.00"";TextAlign:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{Width:85;" & _
        "Caption:""FPOS"";AllowEditing:False;DataType:System.Decimal;Format:""##,##0.00"";Tex" & _
        "tAlign:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "9{Width:85;Caption:""BALANCE"";All" & _
        "owEditing:False;DataType:System.Decimal;Format:""##,##0.00"";TextAlign:RightCenter" & _
        ";TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "10{Width:85;Caption:""F.EXP"";AllowEditing:False;Dat" & _
        "aType:System.DateTime;Format:""yyyy-MM-dd"";TextAlign:CenterCenter;TextAlignFixed:" & _
        "CenterCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.Pe.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Pe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pe.ForeColor = System.Drawing.Color.Black
        Me.Pe.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.Pe.Location = New System.Drawing.Point(8, 88)
        Me.Pe.Name = "Pe"
        Me.Pe.Rows.DefaultSize = 17
        Me.Pe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Pe.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Pe.Size = New System.Drawing.Size(1040, 160)
        Me.Pe.StyleInfo = "Normal{Font:Microsoft Sans Serif, 8.25pt;BackColor:253, 249, 198;ForeColor:Black;" & _
        "TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:253, 249, 198;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:95, 1" & _
        "56, 239;ForeColor:Black;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:Bla" & _
        "ck;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor:Highl" & _
        "ightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Bo" & _
        "rder:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & _
        "Subtotal0{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:Black;ForeColo" & _
        "r:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:186," & _
        " 196, 228;ForeColor:Black;ImageAlign:RightTop;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkD" & _
        "ark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subt" & _
        "otal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDar" & _
        "kDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "rojo{BackColor:Yellow;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9)
        Me.Pe.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Pe.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.Pe, "Celdas resaltadas representan faltante de tela para el CPO.")
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 16)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Tela en Inventario"
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
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 16)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Prendas por Cortar"
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
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 22)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Necesaria:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(8, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 22)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Utilizable:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(8, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 22)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Pedidos:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(8, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 24)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Balance:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(136, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 22)
        Me.Label10.TabIndex = 65
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(136, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 22)
        Me.Label11.TabIndex = 66
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(136, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 22)
        Me.Label12.TabIndex = 67
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(136, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 24)
        Me.Label13.TabIndex = 68
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label4, Me.Label10, Me.Label8, Me.Label11, Me.Label12, Me.Label5, Me.Label9, Me.Label13})
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(1048, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 136)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resumen Tela:"
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
        'Bal_Tela_Det_c
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(1306, 792)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Codi, Me.colors, Me.desc_tela, Me.GroupBox1, Me.Label1, Me.Label7, Me.Pe, Me.Label6, Me.Label3, Me.Co, Me.Label2, Me.Ta})
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Bal_Tela_Det_c"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance de Tela"
        CType(Me.Ta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Co, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Overloads Sub Bal_tela_Det(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Estado_Tela(cnn, estados)
        Codi.Text = codigo
        desc_tela.Text = descripcion
        colors.Text = colores
        setea_pe()
        llena_pe()
        setea_ta()
        llena_ta()
        setea_co()
        llena_co()
        resumen()
        Cursor = Cursors.Default
    End Sub

    Private Sub resumen()
        Dim i As Integer
        Label10.Text = Format(necesario, h$)
        Label11.Text = Format(inventar, h$)
        Label12.Text = Format(pedido, h$)
        Label13.Text = Format(balance, h$)
        For i = 1 To Pe.Rows.Count - 1
            If Pe(i, 9) < 0 Then
                Pe.SetCellStyle(i, 9, Pe.Styles("rojo"))
            End If
        Next
    End Sub

    Private Sub setea_pe()
        Pe.Rows.Count = 1
        Pe.Cols(0).Width = 5
        Pe.Rows(0).Height = 30
    End Sub

    Private Sub llena_pe()
        Dim dt As New DataTable()
        Dim wp As New DataTable()
        Dim cortar As Integer
        Dim pedido As Integer
        Dim cortado As Integer
        Dim proceso As Integer
        Dim busca As Integer
        Dim fgs As String
        Dim pproc As Object
        Dim dd As DataRow()
        Dim dw As DataRow
        Dim fec As Date
        Dim strSQL As String = "SELECT CPO,ESTILO,COLOR,TOTAL,F_ENTREGA,(SELECT SUM(TOTAL) FROM CORTES WHERE CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR AND ESTADO = 'A') AS CORTADO, (SELECT SUM(TOTAL) FROM CORTES_S WHERE CORTES_S.CPO = CPO_D.CPO AND CORTES_S.ESTILO = CPO_D.ESTILO AND CORTES_S.COLOR = CPO_D.COLOR AND ESTADO = 'A') AS PROCESO FROM CPO_D WHERE ESTADO = 'A' AND ESTILO + COLOR IN (SELECT ESTILO_CPO + COLOR_CPO FROM CONSUMO_TELA WHERE CODIGO = '" & codigo & "' AND COLOR_TELA = '" & colors.Text & "')"
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn)
        strSQL = "SELECT * FROM WIP0 WHERE ESTILO + COLOR IN (SELECT ESTILO_CPO + COLOR_CPO FROM CONSUMO_TELA WHERE CODIGO = '" & codigo & "' AND COLOR_TELA = '" & colors.Text & "')"
        llena_tablas(wp, strSQL, cnn)
        For Each dr In dt.Rows
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
            If cortar > 0 Then
                lineas = Pe.Rows.Count
                Pe.Rows.Count = lineas + 1
                Pe(lineas, 1) = Trim(dr("CPO"))
                Pe(lineas, 2) = dr("ESTILO")
                Pe(lineas, 3) = dr("COLOR")
                Pe(lineas, 4) = 0
                Pe(lineas, 5) = cortar
                Pe(lineas, 6) = 0
                Pe(lineas, 7) = 0
                Pe(lineas, 8) = 0
                Pe(lineas, 9) = 0
                fgs = fg(1, 8)
                fgs = Trim(Pe(lineas, 2)) + Trim(Pe(lineas, 3)) + Trim(codigo) + Trim(colors.Text)
                busca = fg.FindRow(fgs, 1, 8, True)
                If busca > 0 Then
                    Pe(lineas, 4) = fg(busca, 5)
                    fgs = fg(busca, 5)
                    Pe(lineas, 6) = Pe(lineas, 4) * Pe(lineas, 5)
                    Pe(lineas, 9) = Pe(lineas, 7) + Pe(lineas, 8) - Pe(lineas, 6)
                End If
                dd = wp.Select("CPO = '" & dr("CPO") & "' AND ESTILO = '" & dr("ESTILO") & "' AND COLOR = '" & dr("COLOR") & "'")
                If dd.Length > 0 Then
                    dw = dd(0)
                    fec = dw("EXP_REV")
                    If Year(fec) = "1900" Then
                        Pe(lineas, 10) = dr("F_ENTREGA")
                    Else
                        Pe(lineas, 10) = fec
                    End If
                Else
                    Pe(lineas, 10) = dr("F_ENTREGA")
                End If
            End If
        Next
    End Sub

    '=============================================== Inventario ================================================
    Private Sub setea_ta()
        Dim index As Integer
        Ta.Clear()
        Ta.Rows.Count = 1
        Ta.Cols.Count = 9
        Ta.Cols(0).Width = 5
        Ta.Rows(0).Height = 30
        Dim c As Column = Ta.Cols(1)
        Ta.Cols(1).Name = "BATCH"
        Ta.Cols(2).Name = "ROLLO"
        Ta.Cols(3).Name = "FPO"
        Ta.Cols(4).Name = "CPO"
        Ta.Cols(5).Name = "CLIENTE"
        Ta.Cols(6).Name = "YARDAS"
        Ta.Cols(7).Name = "LIBRAS"
        Ta.Cols(8).Name = "ESTADO"
        For index = 1 To Ta.Cols.Count - 1
            Ta.Cols(index).Width = 250
            Ta(0, index) = Ta.Cols(index).Name
            If index > 5 And index < 8 Then
                Ta.Cols(index).DataType = GetType(Decimal)
                Ta.Cols(index).Format = "######0.00"
                Ta.Cols(index).Width = 90
                Ta.Cols(index).TextAlign = TextAlignEnum.RightCenter
                Ta.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
        Ta.Cols(1).AllowMerging = True
        Ta.Cols(1).Width = 90
        Ta.Cols(2).Width = 60
    End Sub

    Private Sub llena_ta()
        Dim dt As New DataTable()
        Dim b As Integer
        Dim libras As Decimal
        Dim strSQL As String = "SELECT BATCH,ROLLO,FPO,CPO,CLIENTE,YARDAS,((ROLLOS.PESO/ROLLOS.YARDAS_I) * ROLLOS.YARDAS) AS LIBRAS, ACTIVO FROM ROLLOS WHERE CODIGO = '" & codigo & "' AND COLOR = '" & colores & "' AND ACTIVO IN ('S','0','5') AND YARDAS > 0 AND TIPO = 'TELA' AND CLIENTE = '" & cliente & "'"
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn)
        lineas = dt.Rows.Count
        Ta.Rows.Count = lineas + 1
        lineas = 1
        For Each dr In dt.Rows
            libras = dr("LIBRAS")
            If libras > 0 Then
                Ta(lineas, 1) = dr("BATCH")
                Ta(lineas, 2) = dr("ROLLO")
                Ta(lineas, 3) = dr("FPO")
                Ta(lineas, 4) = Trim(dr("CPO"))
                Ta(lineas, 5) = dr("CLIENTE")
                Ta(lineas, 6) = dr("YARDAS")
                Ta(lineas, 7) = libras
                Ta(lineas, 8) = dr("ACTIVO")
                If Ta(lineas, 8) = "S" Then
                    Ta(lineas, 8) = 0
                End If
                Ta(lineas, 8) = estados.Items.Item(Ta(lineas, 8))
                b = Pe.FindRow(Ta(lineas, 4), 1, 1, True)
                If b > 0 Then
                    Pe(b, 7) = Pe(b, 7) + libras
                    Pe(b, 9) = Pe(b, 7) + Pe(b, 8) - Pe(b, 6)
                Else
                    Ta.SetCellStyle(lineas, 4, Ta.Styles("rojo"))
                End If
                lineas = lineas + 1
            End If
        Next
    End Sub

    '=============================================== TELA PEDIDA   ================================================
    Private Sub setea_co()
        Dim index As Integer
        Co.Clear()
        Co.Rows.Count = 1
        Co.Cols.Count = 8
        Co.Cols(0).Width = 5
        Co.Rows(0).Height = 30
        Dim c As Column = Co.Cols(1)
        Co.Cols(1).Name = "FPO"
        Co.Cols(2).Name = "LOTE"
        Co.Cols(3).Name = "CLIENTE"
        Co.Cols(4).Name = "CPO"
        Co.Cols(5).Name = "LIBRAS"
        Co.Cols(6).Name = "F.REQUERIDA"
        Co.Cols(7).Name = "F.OFRECIDA"
        For index = 1 To Co.Cols.Count - 1
            Co.Cols(index).Width = 150
            Co(0, index) = Co.Cols(index).Name
            If index = 5 Then
                Co.Cols(index).DataType = GetType(Integer)
                Co.Cols(index).Format = "######0"
                Co.Cols(index).Width = 80
                Co.Cols(index).TextAlign = TextAlignEnum.RightCenter
                Co.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
        Co.Cols(6).TextAlign = TextAlignEnum.CenterCenter
        Co.Cols(6).TextAlignFixed = TextAlignEnum.CenterCenter
        Co.Cols(7).TextAlign = TextAlignEnum.CenterCenter
        Co.Cols(7).TextAlignFixed = TextAlignEnum.CenterCenter
        Co.Cols(1).AllowMerging = True
        Co.Cols(2).AllowMerging = True
    End Sub

    Private Sub llena_co()
        Dim dt As New DataTable()
        Dim pedidos As Decimal
        Dim b As Integer
        Dim strSQL As String = "SELECT FPO,LOTE,CLIENTE,CPO,LIBRAS,RFECHA,(LIBRAS - RECIBIDAS) AS PEDIDO, OFECHA FROM FPO WHERE CODIGO = '" & codigo & "' AND COLOR = '" & colores & "' AND TIPO = 'TELA' AND STATUS = 'ABIERTO' AND CLIENTE = '" & cliente & "' AND RECIBIDAS = 0"
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn)
        lineas = dt.Rows.Count
        Co.Rows.Count = lineas + 1
        lineas = 1
        For Each dr In dt.Rows
            pedidos = dr("PEDIDO")
            Co(lineas, 1) = dr("FPO")
            Co(lineas, 2) = dr("LOTE")
            Co(lineas, 3) = dr("CLIENTE")
            Co(lineas, 4) = Trim(dr("CPO"))
            Co(lineas, 5) = pedidos
            Co(lineas, 6) = dr("RFECHA")
            Co(lineas, 7) = dr("OFECHA")
            b = Pe.FindRow(Co(lineas, 4), 1, 1, True)
            If b > 0 Then
                Pe(b, 8) = Pe(b, 8) + pedidos
                Pe(b, 9) = Pe(b, 7) + Pe(b, 8) - Pe(b, 6)
            Else
                Co.SetCellStyle(lineas, 4, Co.Styles("verde"))
            End If
            lineas = lineas + 1
        Next
    End Sub

    Private Sub subtotales()
        With Ta
            Dim libras As Integer = Ta.Cols("LIBRAS").Index
            Ta.Subtotal(AggregateEnum.Sum, 0, 0, libras, "Gran Total -->")
            'change backcolor of subtotals
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.Black
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.White
        End With
    End Sub


    Private Sub subtotales1()
        With Co
            Dim libras As Integer = Co.Cols("LIBRAS").Index
            Co.Subtotal(AggregateEnum.Sum, 0, 0, libras, "Gran Total -->")
            'change backcolor of subtotals
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.Black
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.White
        End With
    End Sub

    Private Sub Pe_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pe.Click
        Dim forma As New Prendas_x_cortar()
        Dim linea As Integer
        linea = Pe.RowSel
        Cursor = Cursors.WaitCursor
        forma.Cpo.Text = Pe(linea, 1)
        forma.Estilo.Text = Pe(linea, 2)
        forma.Colo.Text = Pe(linea, 3)
        forma.ShowDialog()
        Cursor = Cursors.Default
    End Sub


End Class



