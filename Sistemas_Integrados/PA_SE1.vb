Imports C1.Win.C1FlexGrid
Public Class PA_SE1
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim fila As Integer
    Dim strsql As String
    Public corte As String
    Public proceso As String
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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents jg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PA_SE1))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.jg = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = "10,1,0,0,0,95,Columns:0{Width:3;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & _
        "1{Width:78;Name:""CORTE"";Caption:""CORTE"";AllowEditing:False;DataType:System.Strin" & _
        "g;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:107;Name:""TIPO"";Capti" & _
        "on:""TIPO"";}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:112;Name:""FECHA"";Caption:""FECHA"";DataType:System.DateTime;Fo" & _
        "rmat:""dd-MMM-yyyy"";TextAlign:CenterCenter;TextAlignFixed:CenterCenter;ImageAlign" & _
        ":CenterCenter;ImageAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{Width:100;Name:""DOCTO"";Caption:""D" & _
        "OCTO"";AllowEditing:False;DataType:System.String;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{Width:2" & _
        "15;Name:""ENVIADO A"";Caption:""ENVIADO A"";AllowEditing:False;DataType:System.Strin" & _
        "g;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "6{Width:190;Name:""RECIBIDO POR"";Caption:""RECIBIDO POR"";" & _
        "AllowEditing:False;DataType:System.String;TextAlign:LeftCenter;TextAlignFixed:Le" & _
        "ftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{Width:86;Name:""PRENDAS"";Caption:""PRENDAS"";AllowEditing:False;DataTy" & _
        "pe:System.Decimal;Format:""####,##0"";TextAlign:RightCenter;TextAlignFixed:RightCe" & _
        "nter;ImageAlign:RightCenter;ImageAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{Width:88;Name:""SALDO" & _
        """;Caption:""SALDO"";DataType:System.Decimal;Format:""####,##0"";TextAlign:RightCente" & _
        "r;TextAlignFixed:RightCenter;ImageAlign:RightCenter;ImageAlignFixed:RightCenter;" & _
        "}" & Microsoft.VisualBasic.ChrW(9) & "9{Name:""LOTE"";Caption:""LOTE"";Visible:False;DataType:System.String;TextAlign:Le" & _
        "ftCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(8, 16)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1000, 496)
        Me.fg.StyleInfo = "Normal{Font:Tahoma, 9.75pt;Border:Flat,1,LightGray,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackC" & _
        "olor:202, 240, 123;ForeColor:ControlText;Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{Ba" & _
        "ckColor:143, 158, 243;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highli" & _
        "ght;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackCo" & _
        "lor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black" & _
        ";ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{Font:Tahoma, 12pt;BackColor:Black;ForeColor:White;}" & _
        "" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:Contr" & _
        "olDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White" & _
        ";}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:Con" & _
        "trolDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "ctotal{Font:Tahoma, 11.25pt, style=Bold;BackColor" & _
        ":Gold;}" & Microsoft.VisualBasic.ChrW(9) & "abajo{Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 76
        '
        'jg
        '
        Me.jg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.jg.AllowEditing = False
        Me.jg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.jg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.jg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.jg.ColumnInfo = "14,1,0,0,0,95,Columns:0{Width:3;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & _
        "1{Width:115;Name:""TIPO"";Caption:""TIPO"";AllowEditing:False;DataType:System.String" & _
        ";TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:60;Name:""XS"";Caption:""" & _
        "XS"";AllowEditing:False;DataType:System.Decimal;Format:""####,##0"";TextAlign:Right" & _
        "Center;TextAlignFixed:RightCenter;ImageAlign:RightCenter;ImageAlignFixed:RightCe" & _
        "nter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:60;Name:""S"";Caption:""S"";DataType:System.Decimal;Format:""####,##0""" & _
        ";TextAlign:RightCenter;TextAlignFixed:RightCenter;ImageAlign:RightCenter;ImageAl" & _
        "ignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{Width:60;Name:""M"";Caption:""M"";DataType:System.Decimal;F" & _
        "ormat:""####,##0"";TextAlign:RightCenter;TextAlignFixed:RightCenter;ImageAlign:Rig" & _
        "htCenter;ImageAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{Width:60;Name:""L"";Caption:""L"";DataType:" & _
        "System.Decimal;Format:""####,##0"";TextAlign:RightCenter;TextAlignFixed:RightCente" & _
        "r;ImageAlign:RightCenter;ImageAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "6{Width:60;Name:""XL"";Capt" & _
        "ion:""XL"";DataType:System.Decimal;Format:""####,##0"";TextAlign:RightCenter;TextAli" & _
        "gnFixed:RightCenter;ImageAlign:RightCenter;ImageAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{Width" & _
        ":60;Caption:""2XL"";DataType:System.Decimal;Format:""####,##0"";TextAlign:RightCente" & _
        "r;TextAlignFixed:RightCenter;ImageAlign:RightCenter;ImageAlignFixed:RightCenter;" & _
        "}" & Microsoft.VisualBasic.ChrW(9) & "8{Width:60;Name:""3XL"";Caption:""3XL"";DataType:System.Decimal;Format:""####,##0"";" & _
        "TextAlign:RightCenter;TextAlignFixed:RightCenter;ImageAlign:RightCenter;ImageAli" & _
        "gnFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "9{Width:60;Name:""4XL"";Caption:""4XL"";DataType:System.Decima" & _
        "l;Format:""####,##0"";TextAlign:RightCenter;TextAlignFixed:RightCenter;ImageAlign:" & _
        "RightCenter;ImageAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "10{Width:60;Caption:""5XL"";DataType:Sys" & _
        "tem.Decimal;EditMask:""####,##0"";TextAlign:RightCenter;TextAlignFixed:RightCenter" & _
        ";ImageAlign:RightCenter;ImageAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "11{Width:60;Name:""6XL"";Cap" & _
        "tion:""6XL"";DataType:System.Decimal;Format:""####,##0"";TextAlign:RightCenter;TextA" & _
        "lignFixed:RightCenter;ImageAlign:RightCenter;ImageAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "12{Wi" & _
        "dth:60;Name:""TOTAL"";Caption:""TOTAL"";DataType:System.Decimal;Format:""####,##0"";Te" & _
        "xtAlign:RightCenter;TextAlignFixed:RightCenter;ImageAlign:RightCenter;ImageAlign" & _
        "Fixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "13{Name:""LOTE"";Caption:""LOTE"";Visible:False;DataType:System." & _
        "String;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.jg.Enabled = False
        Me.jg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.jg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.jg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.jg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.jg.Location = New System.Drawing.Point(104, 528)
        Me.jg.Name = "jg"
        Me.jg.Rows.Count = 1
        Me.jg.Rows.DefaultSize = 19
        Me.jg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.jg.Size = New System.Drawing.Size(808, 152)
        Me.jg.StyleInfo = "Normal{Font:Tahoma, 9.75pt;Border:Flat,1,LightGray,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackC" & _
        "olor:230, 183, 125;ForeColor:ControlText;Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{Ba" & _
        "ckColor:143, 158, 243;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highli" & _
        "ght;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackCo" & _
        "lor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black" & _
        ";ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{Font:Tahoma, 12pt;BackColor:Black;ForeColor:White;}" & _
        "" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:Contr" & _
        "olDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White" & _
        ";}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:Con" & _
        "trolDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "ctotal{Font:Tahoma, 11.25pt, style=Bold;BackColor" & _
        ":Gold;}" & Microsoft.VisualBasic.ChrW(9) & "abajo{Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9)
        Me.jg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.jg.TabIndex = 77
        '
        'PA_SE1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(1014, 692)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.jg, Me.fg})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PA_SE1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Procesos Adicionales"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub PA_SE1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Rows(0).Height = 30
        llena_grid()
        If fg.Rows.Count > 1 Then
            fila = 1
            despliegue(fila)
        End If
    End Sub


    Private Sub llena_grid()
        dt = New DataTable()
        Dim dr As DataRow
        Dim prendas As Integer
        Dim saldo As Integer = 0
        Dim l As Integer = 1
        Dim strsql As String = "SELECT * FROM CORTES_PAR WHERE CORTE = '" & corte & "' AND PROCESO = '" & proceso & "'"
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = corte
            fg(l, 2) = dr("TIPO")
            fg(l, 3) = dr("FECHA")
            fg(l, 4) = dr("DOCTO")
            fg(l, 5) = dr("LUGAR")
            fg(l, 6) = dr("RECIBIO")
            prendas = (dr("P0") + dr("P1") + dr("P2") + dr("P3") + dr("P4") + dr("P5") + dr("P6") + dr("P7") + dr("P8") + dr("P9") + dr("S0") + dr("S1") + dr("S2") + dr("S3") + dr("S4") + dr("S5") + dr("S6") + dr("S7") + dr("S8") + dr("S9"))
            If fg(l, 2) <> "Envio" Then
                prendas = (prendas * -1)
            End If
            saldo = saldo + prendas
            fg(l, 7) = prendas
            fg(l, 8) = saldo
            l = l + 1
        Next
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        fila = fg.RowSel
        despliegue(fila)
    End Sub

    Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles fg.KeyDown
        If e.KeyCode = Keys.Up Then
            fila = fg.RowSel - 1
            despliegue(fila)
        End If

        If e.KeyCode = Keys.Down Then
            fila = fg.RowSel + 1
            despliegue(fila)
        End If
    End Sub

    Private Sub despliegue(ByVal fila As Integer)
        Dim dd As DataRow()
        Dim dr As DataRow
        Dim i As Integer
        jg.Rows.Count = 3
        jg(1, 1) = "Primeras"
        jg(2, 1) = "Segundas"
        jg(1, 12) = 0
        jg(2, 12) = 0
        If fila > 0 And fila < fg.Rows.Count Then
            dd = dt.Select("DOCTO = '" & fg(fila, 4) & "'")
            If dd.Length > 0 Then
                dr = dd(0)
                For i = 0 To 9
                    jg(1, i + 2) = dr(i + 8)
                    jg(2, i + 2) = dr(i + 18)
                    jg(1, 12) = jg(1, 12) + dr(i + 8)
                    jg(2, 12) = jg(2, 12) + dr(i + 18)
                Next
                For i = 2 To 12
                    jg.Subtotal(AggregateEnum.Sum, 0, 0, i, "Gran Total -->")
                Next
            End If
        End If
    End Sub
End Class
