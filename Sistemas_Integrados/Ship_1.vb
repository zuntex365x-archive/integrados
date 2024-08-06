Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized
Imports C1.C1Excel

Public Class Ship_1
    Inherits System.Windows.Forms.Form
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
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents co As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents cpo As System.Windows.Forms.ComboBox
    Friend WithEvents sigue As System.Windows.Forms.Button
    Friend WithEvents G1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tallas As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Ship_1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.sigue = New System.Windows.Forms.Button()
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.cpo = New System.Windows.Forms.ComboBox()
        Me.G1 = New System.Windows.Forms.Button()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.co = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tallas = New System.Windows.Forms.ComboBox()
        CType(Me.co, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sigue
        '
        Me.sigue.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.sigue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sigue.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sigue.ForeColor = System.Drawing.Color.Black
        Me.sigue.Image = CType(resources.GetObject("sigue.Image"), System.Drawing.Bitmap)
        Me.sigue.Location = New System.Drawing.Point(888, 0)
        Me.sigue.Name = "sigue"
        Me.sigue.Size = New System.Drawing.Size(35, 35)
        Me.sigue.TabIndex = 6
        Me.sigue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.sigue, "Presione este Boton para Desplegar la Consulta.")
        Me.sigue.Visible = False
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.CANCELA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CANCELA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCELA.ForeColor = System.Drawing.Color.Black
        Me.CANCELA.Image = CType(resources.GetObject("CANCELA.Image"), System.Drawing.Bitmap)
        Me.CANCELA.Location = New System.Drawing.Point(928, 0)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(35, 35)
        Me.CANCELA.TabIndex = 69
        Me.CANCELA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.CANCELA, "Otro Pedido")
        '
        'cpo
        '
        Me.cpo.BackColor = System.Drawing.Color.White
        Me.cpo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpo.Location = New System.Drawing.Point(232, 8)
        Me.cpo.Name = "cpo"
        Me.cpo.Size = New System.Drawing.Size(160, 24)
        Me.cpo.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.cpo, "Cpo")
        '
        'G1
        '
        Me.G1.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.G1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.G1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G1.ForeColor = System.Drawing.Color.Black
        Me.G1.Image = CType(resources.GetObject("G1.Image"), System.Drawing.Bitmap)
        Me.G1.Location = New System.Drawing.Point(968, 0)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(35, 35)
        Me.G1.TabIndex = 81
        Me.G1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.G1, "Presione este Boton para Grabar o Actualizar los Datos del  Corte")
        Me.G1.Visible = False
        '
        'fecha
        '
        Me.fecha.CalendarForeColor = System.Drawing.SystemColors.Highlight
        Me.fecha.CustomFormat = "dd/MM/yyyy"
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha.Location = New System.Drawing.Point(64, 8)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(104, 22)
        Me.fecha.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.fecha, "Fecha del Embarque")
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(184, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 26)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Cpo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'co
        '
        Me.co.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.co.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.co.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.co.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.co.ColumnInfo = "20,1,0,0,0,95,Columns:0{Width:5;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & _
        "1{Width:95;Name:""CPO"";Caption:""CPO"";AllowEditing:False;DataType:System.String;Te" & _
        "xtAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:90;Name:""ESTILO"";Caption:" & _
        """ESTILO"";AllowEditing:False;DataType:System.String;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Widt" & _
        "h:140;Name:""COLOR"";Caption:""COLOR"";AllowEditing:False;DataType:System.String;Tex" & _
        "tAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{Width:60;Name:""CORTE"";Caption:""CORTE"";AllowEditing:False;D" & _
        "ataType:System.String;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{Width:45;Name:""TIPO"";Caption:""TIP" & _
        "O"";AllowEditing:False;DataType:System.String;TextAlign:CenterCenter;TextAlignFix" & _
        "ed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "6{Width:45;Name:""XS"";Caption:""XS"";DataType:System.Decimal;Form" & _
        "at:""##,##0"";TextAlign:CenterCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{Width:45;Name" & _
        ":""S"";Caption:""S"";DataType:System.Decimal;Format:""##,##0"";TextAlign:CenterCenter;" & _
        "TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{Width:45;Name:""M"";Caption:""M"";DataType:System.De" & _
        "cimal;Format:""##,##0"";TextAlign:CenterCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "9{Wid" & _
        "th:45;Name:""L"";Caption:""L"";DataType:System.Decimal;Format:""##,##0"";TextAlign:Cen" & _
        "terCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "10{Width:45;Name:""XL"";Caption:""XL"";DataT" & _
        "ype:System.Decimal;Format:""##,##0"";TextAlign:CenterCenter;TextAlignFixed:CenterC" & _
        "enter;}" & Microsoft.VisualBasic.ChrW(9) & "11{Width:45;Name:""2XL"";Caption:""2XL"";DataType:System.Decimal;Format:""##," & _
        "##0"";TextAlign:CenterCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "12{Width:45;Name:""3XL""" & _
        ";Caption:""3XL"";DataType:System.Decimal;TextAlign:CenterCenter;TextAlignFixed:Cen" & _
        "terCenter;ImageAlign:CenterCenter;ImageAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "13{Width:50;Nam" & _
        "e:""4XL"";Caption:""4XL"";DataType:System.Decimal;Format:""##,##0"";TextAlign:CenterCe" & _
        "nter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "14{Width:50;Name:""5XL"";Caption:""5XL"";DataType" & _
        ":System.Decimal;Format:""##,##0"";TextAlign:CenterCenter;TextAlignFixed:CenterCent" & _
        "er;}" & Microsoft.VisualBasic.ChrW(9) & "15{Width:50;Name:""6XL"";Caption:""6XL"";DataType:System.Decimal;Format:""##,##0" & _
        """;TextAlign:CenterCenter;TextAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "16{Width:50;Name:""TOTAL"";" & _
        "Caption:""TOTAL"";DataType:System.Decimal;Format:""##,##0"";TextAlign:CenterCenter;T" & _
        "extAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "17{Width:35;Name:""EXP"";Caption:""EXP"";DataType:Syste" & _
        "m.Boolean;TextAlign:CenterCenter;TextAlignFixed:CenterCenter;ImageAlign:CenterCe" & _
        "nter;}" & Microsoft.VisualBasic.ChrW(9) & "18{Name:""LOTE"";Caption:""LOTE"";Visible:False;DataType:System.String;TextAl" & _
        "ign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "19{Name:""CLIENTE"";Caption:""CLIENTE"";Visible:False;DataType:Syst" & _
        "em.String;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.co.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.co.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.co.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.co.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.co.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.co.Location = New System.Drawing.Point(8, 288)
        Me.co.Name = "co"
        Me.co.Rows.Count = 1
        Me.co.Rows.DefaultSize = 19
        Me.co.Size = New System.Drawing.Size(1008, 400)
        Me.co.StyleInfo = "Normal{Font:Tahoma, 9.75pt;Border:Flat,1,LightGray,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackC" & _
        "olor:130, 223, 153;ForeColor:ControlText;Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{Ba" & _
        "ckColor:186, 237, 199;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highli" & _
        "ght;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackCo" & _
        "lor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black" & _
        ";ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{Font:Tahoma, 12pt;BackColor:Black;ForeColor:White;}" & _
        "" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:Contr" & _
        "olDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White" & _
        ";}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:Con" & _
        "trolDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "ctotal{Font:Tahoma, 11.25pt, style=Bold;BackColor" & _
        ":Gold;}" & Microsoft.VisualBasic.ChrW(9) & "abajo{Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9)
        Me.co.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.co.TabIndex = 75
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 26)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Fecha:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = "7,1,0,0,0,95,Columns:0{Width:3;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1" & _
        "{Width:223;Name:""CLIENTE"";Caption:""CLIENTE"";AllowEditing:False;DataType:System.S" & _
        "tring;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:203;Name:""CPO"";Caption:""CPO"";AllowEditing:F" & _
        "alse;DataType:System.String;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:203;Name:""ESTILO"";Cap" & _
        "tion:""ESTILO"";AllowEditing:False;DataType:System.String;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4" & _
        "{Width:274;Name:""COLOR"";Caption:""COLOR"";AllowEditing:False;DataType:System.Strin" & _
        "g;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{Width:80;Name:""INCLUIR"";Cap" & _
        "tion:""INCLUIR"";DataType:System.Boolean;TextAlign:CenterCenter;TextAlignFixed:Cen" & _
        "terCenter;ImageAlign:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "6{Name:""DESTINO"";Caption:""DESTINO"";Visible:F" & _
        "alse;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 40)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(1008, 240)
        Me.fg.StyleInfo = "Normal{Font:Tahoma, 9.75pt;Border:Flat,1,LightGray,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackC" & _
        "olor:255, 167, 79;ForeColor:ControlText;Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{Bac" & _
        "kColor:255, 192, 128;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlig" & _
        "ht;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackCol" & _
        "or:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;" & _
        "ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{Font:Tahoma, 12pt;BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & _
        "Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:Contro" & _
        "lDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;" & _
        "}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:Cont" & _
        "rolDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "ctotal{Font:Tahoma, 11.25pt, style=Bold;BackColor:" & _
        "Gold;}" & Microsoft.VisualBasic.ChrW(9) & "abajo{Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 82
        '
        'tallas
        '
        Me.tallas.BackColor = System.Drawing.Color.White
        Me.tallas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tallas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tallas.Items.AddRange(New Object() {"XS", "S", "M", "L", "XL", "2XL", "3XL", "4XL", "5XL", "6XL"})
        Me.tallas.Location = New System.Drawing.Point(528, 656)
        Me.tallas.Name = "tallas"
        Me.tallas.Size = New System.Drawing.Size(120, 24)
        Me.tallas.TabIndex = 83
        Me.tallas.Visible = False
        '
        'Ship_1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(1022, 692)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.fg, Me.G1, Me.cpo, Me.Label2, Me.sigue, Me.CANCELA, Me.fecha, Me.Label4, Me.co, Me.tallas})
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ship_1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shipping Schedule"
        CType(Me.co, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim pla As New DataTable()
    Dim cnn As New SqlClient.SqlConnection()
    Dim dr As DataRow
    Dim pe As DataTable
    Dim pc(9) As String

    Private Sub Prod_diaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler fecha.KeyPress, AddressOf keypressed1
        AddHandler cpo.KeyPress, AddressOf keypressed2
        llena_cpos()
        deshabilita()
    End Sub

    Private Sub deshabilita()
        setea_grid(True)
        fecha.Enabled = True
        cpo.Enabled = False
        sigue.Visible = False
        G1.Visible = False
    End Sub

    Private Sub habilita()
        cpo.Enabled = True
        sigue.Visible = True
        G1.Visible = True
    End Sub

    Private Sub setea_grid(ByVal si As Boolean)
        Dim i As Integer
        If si Then
            fg.Rows.Count = 1
        End If
        co.Rows.Count = 1

        fg.Rows(0).Height = 40
        co.Rows(0).Height = 40

        co.Cols(16).AllowEditing = False

        For i = 1 To 4
            co.Cols(i).AllowMerging = True
        Next
    End Sub

    Private Sub llena_fg()
        Dim fechas As String = Format(CDate(fecha.Text), "yyyy-MM-dd")
        Dim dt As New DataTable()
        Dim dd As New DataTable()
        Dim l As Integer = 1
        Dim i As Integer
        Dim dr As DataRow = Nothing
        Dim strsql As String = "SELECT * FROM SHIP_EE WHERE FECHA = '" & fechas & "' ORDER BY CPO,ESTILO,COLOR"
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each Me.dr In dt.Rows
            fg(l, 1) = dr("CLIENTE")
            fg(l, 2) = dr("CPO")
            fg(l, 3) = dr("ESTILO")
            fg(l, 4) = dr("COLOR")
            fg(l, 5) = True
            fg(l, 0) = fg(l, 2) + fg(l, 3) + fg(l, 4)
            fecha.Text = dr("FECHA")
            l = l + 1
        Next
        strsql = "SELECT * FROM SHIP_ED WHERE FECHA = '" & fechas & "' ORDER BY CPO,ESTILO,COLOR"
        llena_tablas(dd, strsql, cnn)
        co.Rows.Count = dd.Rows.Count + 1
        l = 1
        For Each Me.dr In dd.Rows
            co(l, 1) = dr("CPO")
            co(l, 2) = dr("ESTILO")
            co(l, 3) = dr("COLOR")
            co(l, 4) = dr("CORTE")
            co(l, 5) = "Pri"
            For i = 0 To 10
                co(l, i + 6) = dr(i + 6)
            Next
            co(l, 17) = True
            co(l, 19) = dr("CLIENTE")
            co(l, 0) = co(l, 1) + co(l, 2) + co(l, 3)
            l = l + 1
        Next
        habilita()
        If dt.Rows.Count > 0 Then
            fecha.Enabled = False
        Else
            fecha.Enabled = True
        End If
        cpo.Focus()
    End Sub

    Private Sub llena_cpos_embarque()
        Dim p As Integer
        Dim dt As New DataTable()
        Dim l As Integer = fg.Rows.Count
        Dim strsql As String = "SELECT CPO_D.*, CLIENTE FROM CPO_D LEFT JOIN CPO ON CPO.CPO = CPO_D.CPO WHERE CPO_D.CPO = '" & cpo.Text & "' AND ESTADO = 'A' "
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = l + dt.Rows.Count
        For Each Me.dr In dt.Rows
            p = fg.FindRow(dr("CPO") + dr("ESTILO") + dr("COLOR"), 1, 0, False)
            If p < 0 Then
                fg(l, 1) = dr("CLIENTE")
                fg(l, 2) = dr("CPO")
                fg(l, 3) = dr("ESTILO")
                fg(l, 4) = dr("COLOR")
                fg(l, 5) = False
                fg(l, 0) = fg(l, 2) + fg(l, 3) + fg(l, 4)
                l = l + 1
            End If
        Next
    End Sub

    Private Sub fg_quita(ByVal sender As Object, ByVal e As RowColEventArgs) Handles fg.AfterEdit
        Dim i As Integer = e.Row
        If fg(i, 5) = True Then
            llena_cortes(i)
        Else
            quita_cortes(i)
        End If
    End Sub


    '================================================================
    '=                HANDLERS
    '================================================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(fecha.Text) <> "" Then
                llena_fg()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cpo.Text) <> "" Then
                sigue.Focus()
            End If
        End If
    End Sub


    Private Sub llena_cortes(ByVal f As Integer)
        Dim dt As New DataTable()
        Dim cpos As String = fg(f, 2)
        Dim estilo As String = fg(f, 3)
        Dim col As String = fg(f, 4)
        Dim corte As String
        Dim l As Integer
        Dim i As Integer
        Dim pr As Integer
        Dim ex As Integer
        Dim fin As Integer
        Dim strsql As String = "SELECT * FROM CORTES LEFT JOIN CORTES_P ON CORTES.CORTE = CORTES_P.CORTE LEFT JOIN CORTES_E ON CORTES.CORTE = CORTES_E.CORTE WHERE CPO = '" & cpos & "' AND ESTILO = '" & estilo & "' AND COLOR = '" & col & "'"
        l = co.FindRow(cpos + estilo + col, 1, 0, True)
        If l < 0 Then
            llena_tablas(dt, strsql, cnn)
            For Each Me.dr In dt.Rows
                corte = dr(0)
                l = fg.Rows.Count
                co.Rows.Count = co.Rows.Count + l
                co(l, 1) = cpos
                co(l, 2) = estilo
                co(l, 3) = col
                co(l, 4) = corte
                co(l, 5) = "Pri"
                co(l, 17) = False
                co(l, 19) = fg(f, 1)
                fin = 0
                For i = 0 To 9
                    Try
                        pr = dr(i + 6)
                    Catch
                        pr = 0
                    End Try
                    Try
                        ex = dr(i + 44)
                    Catch
                        ex = 0
                    End Try
                    co(l, i + 6) = pr - ex
                    Try
                        pr = dr(i + 33)
                    Catch
                        pr = 0
                    End Try
                    Try
                        ex = dr(i + 54)
                    Catch
                        ex = 0
                    End Try
                    co(l, 18) = dr("BATCH")
                Next i
                co(l, 16) = 0
                For i = 6 To 15
                    co(l, 16) = co(l, 16) + co(l, i)
                Next
                'quita_stock(corte, l)
            Next
            'llena_stock(f)
            'For i = 1 To co.Rows.Count - 1
            '    If co(i, 16) = 0 Then
            '        co(i, 0) = "adios"
            '    Else
            '        co(i, 0) = co(i, 1) + co(i, 2) + co(i, 3)
            '    End If
            'Next

            ' ====== Quita líneas con total 0 =====
            i = 1
            While i > 0
                i = co.FindRow("adios", 1, 0, True)
                If i > 0 Then
                    Try
                        co.Rows.Remove(i)
                    Catch
                    End Try
                End If
            End While
        End If

    End Sub

    Private Sub quita_stock(ByVal corte As String, ByVal l As Integer)
        Dim dt As New DataTable()
        Dim p As Integer
        Dim prendas As Decimal
        llena_tablas(dt, "SELECT * FROM E_STOCK WHERE CORTE = '" & corte & "'", cnn)
        For Each Me.dr In dt.Rows
            prendas = dr("PRENDAS")
            p = tallas.Items.IndexOf(dr("TALLA"))
            If p > -1 Then
                If dr("TIPO") = "00" Then
                    co(l, p + 6) = co(l, p + 6) - prendas
                    co(l, 16) = co(l, 16) - prendas
                End If
            End If
        Next

    End Sub

    Private Sub llena_stock(ByVal f As Integer)
        Dim l As Integer
        Dim p As Integer
        Dim prenda As Integer
        Dim colo As String = fg(f, 4)
        Dim estilo As String = fg(f, 3)
        Dim dt As New DataTable()
        Dim cpos As String = fg(f, 2)
        Dim TALLASN As String
        Dim strsql As String = "SELECT * FROM STOCK WHERE ESTILO = '" & estilo & "' AND COLOR = '" & colo & "'"
        llena_tablas(dt, strsql, cnn)
        l = co.Rows.Count
        co.Rows.Count = co.Rows.Count + 1
        co(l, 1) = cpos
        co(l, 2) = estilo
        co(l, 3) = colo
        co(l, 4) = "STOCK"
        co(l, 5) = "Pri"
        co(l, 17) = False
        co(l, 19) = fg(f, 1)
        For p = 6 To 16
            co(l, p) = 0
        Next

        For Each Me.dr In dt.Rows
            TALLASN = dr("TALLA")
            p = tallas.Items.IndexOf(Trim(TALLASN))
            prenda = dr("UNIDADES")
            If dr("TIPO") = "00" Then
                co(l, p + 6) = co(l, p + 6) + prenda
                co(l, 16) = co(l, 16) + prenda
            End If
        Next
    End Sub

    Private Sub quita_cortes(ByVal f As Integer)
        Dim cpos As String = fg(f, 2)
        Dim estilo As String = fg(f, 3)
        Dim col As String = fg(f, 4)
        Dim i As Integer = 1
        Dim busca As String
        While i > 0
            i = co.FindRow(cpos + estilo + col, 1, 0, False)
            If i > 0 Then
                Try
                    busca = co(i, 0)
                    co.Rows.Remove(i)
                Catch
                End Try
            End If
        End While
    End Sub

    Private Sub procesa()
        llena_cpos_embarque()
    End Sub

    Private Sub llena_cpos()
        Dim dt As New DataTable()
        Dim strsql As String = "SELECT DISTINCT CPO_D.CPO FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE ESTADO = 'A' ORDER BY CPO_D.CPO"
        cpo.Items.Clear()
        llena_tablas(dt, strsql, cnn)
        For Each Me.dr In dt.Rows
            cpo.Items.Add(dr("CPO"))
        Next
        Try
            cpo.SelectedIndex = 0
        Catch
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sigue.Click
        procesa()
        fecha.Enabled = False
        G1.Visible = True
    End Sub

    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELA.Click
        setea_grid(True)
        deshabilita()
    End Sub


    Private Sub co_ValidateEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.ValidateEditEventArgs) Handles co.ValidateEdit
        If e.Col < 16 Then
            Try
                Dim dec As Decimal = Decimal.Parse(co.Editor.Text())
                If dec > co(e.Row, e.Col) Then
                    MessageBox.Show("No puede ingresar una exportación mayor a la existencia.")
                    e.Cancel = True
                End If
            Catch
                MessageBox.Show("Por favor ingrese valores numéricos")
                e.Cancel = True
            End Try
        End If
    End Sub

    Private Sub RowColEventHandler(ByVal sender As Object, ByVal e As RowColEventArgs) Handles co.AfterEdit
        Dim i As Integer
        Dim l As Integer = e.Row
        co(l, 16) = 0
        For i = 6 To 15
            co(l, 16) = co(l, 16) + co(l, i)
        Next
    End Sub

    Private Sub G1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G1.Click
        Dim seguro As MsgBoxResult
        Dim ok As Boolean = False
        seguro = MsgBox("Seguro de grabar esta información?  ", MsgBoxStyle.YesNo, "Grabando Shipping Schedule !!!")
        If seguro = MsgBoxResult.Yes Then
            revisa_datos(ok)
            If ok Then
                graba_datos()
                otra_fecha()
            End If
        End If
    End Sub

    Private Sub revisa_datos(ByRef ok As Boolean)
        elimina_basura()
        'If fg.Rows.Count = 1 Then
        '    MsgBox("No puede Grabar aún. No ha elegido ningún corte !!!!!", MsgBoxStyle.Critical, "Por favor revise !!!")
        '    ok = False
        'Else
        '    ok = True
        'End If
    End Sub

    Private Sub elimina_basura()
        Dim i As Integer
        Dim l As Integer = 1
        Dim busca As String
        co.Sort(SortFlags.Ascending, 17)
        While l > 0
            Try
                l = co.FindRow(False, 1, 17, False)
                If l > 0 Then
                    co.Rows.Remove(l)
                End If
            Catch
            End Try
        End While
        For i = 1 To fg.Rows.Count - 1
            busca = fg(i, 2) + fg(i, 3) + fg(i, 4)
            l = co.FindRow(busca, 1, 0, False)
            If l < 0 Then
                fg(i, 0) = "quitar"
            End If
        Next
        l = 1
        While l > 0
            Try
                l = fg.FindRow("quitar", 1, 0, False)
                fg.Rows.Remove(l)
            Catch
            End Try
        End While
    End Sub

    Private Sub otra_fecha()
        setea_grid(True)
        deshabilita()
        fecha.Focus()
    End Sub

    '=================================================================================
    '                        GRABA DATOS
    '=================================================================================
    Private Sub graba_datos()
        Dim i As Integer
        Dim strsql As String
        Dim afectados As Integer
        Dim fechas As String = Format(CDate(fecha.Text), "yyyy-MM-dd")


        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try

            strsql = "DELETE SHIP_ED WHERE FECHA = '" & fechas & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "DELETE SHIP_EE WHERE FECHA = '" & fechas & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            For i = 1 To fg.Rows.Count - 1
                strsql = "INSERT INTO SHIP_EE (FECHA,CPO,ESTILO,COLOR,CLIENTE)" & _
                                     "VALUES ('" & fechas & "','" & _
                                                   fg(i, 2) & "','" & _
                                                   fg(i, 3) & "','" & _
                                                   fg(i, 4) & "','" & _
                                                   fg(i, 1) & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()

            Next i

            For i = 1 To co.Rows.Count - 1
                strsql = "INSERT INTO SHIP_ED (FECHA,CPO,ESTILO,COLOR,CORTE,CLIENTE,XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6,TOTAL)" & _
                                     "VALUES ('" & fechas & "','" & _
                                                   co(i, 1) & "','" & _
                                                   co(i, 2) & "','" & _
                                                   co(i, 3) & "','" & _
                                                   co(i, 4) & "','" & _
                                                   co(i, 19) & "','" & _
                                                   co(i, 6) & "','" & _
                                                   co(i, 7) & "','" & _
                                                   co(i, 8) & "','" & _
                                                   co(i, 9) & "','" & _
                                                   co(i, 10) & "','" & _
                                                   co(i, 11) & "','" & _
                                                   co(i, 12) & "','" & _
                                                   co(i, 13) & "','" & _
                                                   co(i, 14) & "','" & _
                                                   co(i, 15) & "','" & _
                                                   co(i, 16) & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
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

End Class
