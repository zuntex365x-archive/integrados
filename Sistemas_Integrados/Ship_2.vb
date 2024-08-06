Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Printing
Public Class Ship_2
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim strSQl As String
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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Hoja As System.Windows.Forms.Button
    Friend WithEvents Imprimir As System.Windows.Forms.Button
    Friend WithEvents Regresar As System.Windows.Forms.Button
    Friend WithEvents Fecha As System.Windows.Forms.ComboBox
    Friend WithEvents cliente As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Ship_2))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Fecha = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cliente = New System.Windows.Forms.ComboBox()
        Me.Hoja = New System.Windows.Forms.Button()
        Me.Imprimir = New System.Windows.Forms.Button()
        Me.Regresar = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        '
        'Fecha
        '
        Me.Fecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Location = New System.Drawing.Point(128, 8)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(160, 28)
        Me.Fecha.TabIndex = 78
        Me.ToolTip1.SetToolTip(Me.Fecha, "fecha")
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Bitmap)
        Me.Button2.Location = New System.Drawing.Point(848, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 79
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton para Desplegar la Consulta.")
        '
        'cliente
        '
        Me.cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.Location = New System.Drawing.Point(432, 8)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(208, 28)
        Me.cliente.TabIndex = 81
        Me.ToolTip1.SetToolTip(Me.cliente, "Cliente")
        '
        'Hoja
        '
        Me.Hoja.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Hoja.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Hoja.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hoja.ForeColor = System.Drawing.Color.Black
        Me.Hoja.Image = CType(resources.GetObject("Hoja.Image"), System.Drawing.Bitmap)
        Me.Hoja.Location = New System.Drawing.Point(888, 8)
        Me.Hoja.Name = "Hoja"
        Me.Hoja.Size = New System.Drawing.Size(35, 35)
        Me.Hoja.TabIndex = 82
        Me.Hoja.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Hoja, "Presione este Boton si Desea  convertir a Excel los datos del  Inventario")
        Me.Hoja.Visible = False
        '
        'Imprimir
        '
        Me.Imprimir.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Imprimir.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Imprimir.ForeColor = System.Drawing.Color.Black
        Me.Imprimir.Image = CType(resources.GetObject("Imprimir.Image"), System.Drawing.Bitmap)
        Me.Imprimir.Location = New System.Drawing.Point(928, 8)
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(35, 35)
        Me.Imprimir.TabIndex = 83
        Me.Imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Imprimir, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Imprimir.Visible = False
        '
        'Regresar
        '
        Me.Regresar.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Regresar.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar.ForeColor = System.Drawing.Color.Black
        Me.Regresar.Image = CType(resources.GetObject("Regresar.Image"), System.Drawing.Bitmap)
        Me.Regresar.Location = New System.Drawing.Point(848, 8)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(35, 35)
        Me.Regresar.TabIndex = 84
        Me.Regresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Regresar, "Presione este Boton para Refrescar la pantalla  y volver a solicitar datos de bus" & _
        "queda.")
        Me.Regresar.Visible = False
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "22,1,0,0,0,75,Columns:0{Width:0;TextAlign:LeftCenter;TextAlignFixed:LeftCenter;Im" & _
        "ageAlign:CenterCenter;ImageAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1{Width:121;Name:""CPO"";Capt" & _
        "ion:""CPO"";DataType:System.String;TextAlign:LeftCenter;TextAlignFixed:CenterCente" & _
        "r;ImageAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:210;Name:""COLOR"";Caption:""COLOR"";DataTy" & _
        "pe:System.String;TextAlign:LeftCenter;TextAlignFixed:CenterCenter;ImageAlignFixe" & _
        "d:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:144;Name:""STYLE"";Caption:""STYLE"";DataType:System.String" & _
        ";TextAlign:CenterCenter;TextAlignFixed:CenterCenter;ImageAlign:CenterCenter;Imag" & _
        "eAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{Width:278;Name:""DESTINATION"";Caption:""DESTINATION"";" & _
        "DataType:System.String;TextAlign:LeftCenter;TextAlignFixed:CenterCenter;ImageAli" & _
        "gn:CenterCenter;ImageAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{Width:50;Name:""XS"";Caption:""XS""" & _
        ";Format:""####"";TextAlign:CenterCenter;TextAlignFixed:CenterCenter;ImageAlign:Cen" & _
        "terCenter;ImageAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "6{Width:50;Name:""S"";Caption:""S"";Format:" & _
        """####"";TextAlign:CenterCenter;TextAlignFixed:CenterCenter;ImageAlign:CenterCente" & _
        "r;ImageAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{Width:50;Name:""M"";Caption:""M"";Format:""####"";T" & _
        "extAlign:CenterCenter;TextAlignFixed:CenterCenter;ImageAlign:CenterCenter;ImageA" & _
        "lignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{Width:50;Name:""L"";Caption:""L"";Format:""####"";TextAlign" & _
        ":CenterCenter;TextAlignFixed:CenterCenter;ImageAlign:CenterCenter;ImageAlignFixe" & _
        "d:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "9{Width:50;Name:""XL"";Caption:""XL"";Format:""####"";TextAlignFixed:" & _
        "CenterCenter;ImageAlign:CenterCenter;ImageAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "10{Width:50;" & _
        "Name:""2XL"";Caption:""2XL"";Format:""####"";TextAlignFixed:CenterCenter;ImageAlign:Ce" & _
        "nterCenter;ImageAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "11{Width:50;Name:""3XL"";Caption:""3XL"";F" & _
        "ormat:""####"";TextAlignFixed:CenterCenter;ImageAlign:CenterCenter;ImageAlignFixed" & _
        ":CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "12{Width:50;Name:""4XL"";Caption:""4XL"";Format:""####"";TextAlignFixe" & _
        "d:CenterCenter;ImageAlign:CenterCenter;ImageAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "13{Width:5" & _
        "0;Name:""5XL"";Caption:""5XL"";Format:""####"";TextAlignFixed:CenterCenter;ImageAlign:" & _
        "CenterCenter;ImageAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "14{Width:50;Name:""6XL"";Caption:""6XL""" & _
        ";Format:""####"";TextAlignFixed:CenterCenter;ImageAlign:CenterCenter;ImageAlignFix" & _
        "ed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "15{Width:103;Name:""PCS"";Caption:""PCS/CARTON"";Format:""###0"";Tex" & _
        "tAlign:CenterCenter;TextAlignFixed:CenterCenter;ImageAlign:CenterCenter;ImageAli" & _
        "gnFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "16{Width:74;Name:""TCT"";Caption:""TTL Q'TY"";Format:""#####0""" & _
        ";TextAlignFixed:CenterCenter;ImageAlign:CenterCenter;ImageAlignFixed:CenterCente" & _
        "r;}" & Microsoft.VisualBasic.ChrW(9) & "17{Name:""W"";Caption:""W"";Format:""####.00"";TextAlignFixed:CenterCenter;ImageAl" & _
        "ign:CenterCenter;ImageAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "18{Name:""L"";Caption:""L"";Format:""" & _
        "####.00"";TextAlignFixed:CenterCenter;ImageAlign:CenterCenter;ImageAlignFixed:Cen" & _
        "terCenter;}" & Microsoft.VisualBasic.ChrW(9) & "19{Name:""H"";Caption:""H"";Format:""####.00"";TextAlignFixed:CenterCenter" & _
        ";ImageAlign:CenterCenter;ImageAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "20{Name:""CTQ"";Caption:""C" & _
        "/T Q'TY"";Format:""###,##0.00"";TextAlignFixed:CenterCenter;ImageAlign:CenterCenter" & _
        ";ImageAlignFixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "21{Name:""CBM"";Caption:""CBM"";Format:""###,##0.00"";" & _
        "TextAlignFixed:CenterCenter;ImageAlign:CenterCenter;ImageAlignFixed:CenterCenter" & _
        ";}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 20
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(992, 636)
        Me.fg.StyleInfo = "Normal{Font:Microsoft Sans Serif, 8.25pt;BackColor:White;ForeColor:Black;TextAlig" & _
        "n:CenterCenter;ImageAlign:CenterCenter;Border:Flat,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{Back" & _
        "Color:White;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:Whit" & _
        "e;ForeColor:Black;ImageAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:218, 215, 247;Fore" & _
        "Color:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{BackColor:218, 215, 247;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Editor{BackColor:2" & _
        "18, 215, 247;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor:HighlightTex" & _
        "t;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Border:Fl" & _
        "at,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{Font:Microsoft Sans Serif, 9pt, style=Bol" & _
        "d;BackColor:158, 237, 202;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{Font:Microsoft Sans Serif," & _
        " 9pt, style=Bold;BackColor:158, 237, 202;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{Font:Micros" & _
        "oft Sans Serif, 11.25pt, style=Bold;BackColor:186, 196, 228;ForeColor:Black;Imag" & _
        "eAlign:RightTop;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal" & _
        "3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDar" & _
        "k;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "cabeza" & _
        "{BackColor:158, 237, 202;}" & Microsoft.VisualBasic.ChrW(9) & "nada{Font:Microsoft Sans Serif, 11.25pt, style=Bold;B" & _
        "order:None,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "abajo{Border:Flat,1,Black,Horizontal;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(24, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 26)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Fecha:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(352, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 26)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Cliente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ship_2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Imprimir, Me.Hoja, Me.cliente, Me.Label1, Me.Button2, Me.Fecha, Me.Label3, Me.fg, Me.Regresar})
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ship_2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shipping Schedule"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Ship_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Rows(0).Visible = False
        llena_fechas()
        Try
            Fecha.SelectedIndex = 0
        Catch
        End Try
        fg.Rows.Count = 1
    End Sub


    Private Sub fecha_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fecha.SelectedIndexChanged
        llena_combos(cliente, "SELECT DISTINCT FECHA, CLIENTE FROM SHIP_EE ORDER BY FECHA DESC", "CLIENTE")
    End Sub


    Private Sub proceso()
        Dim dt As New DataTable()
        Dim l As Integer = 7
        Dim i As Integer
        Dim fechas As String = Format(CDate(Fecha.Text), "MM-dd-yyyy")
        strSQl = "SELECT SHIP_ED.CPO,SHIP_ED.ESTILO,SHIP_ED.COLOR,SUM(SHIP_ED.XS) AS XS, SUM(SHIP_ED.S) AS S, SUM(SHIP_ED.M) AS M, SUM(SHIP_ED.L) AS L, SUM(SHIP_ED.XL) AS XL, SUM(SHIP_ED.XL2) AS XL2, SUM(SHIP_ED.XL3) AS XL3, SUM(SHIP_ED.XL4) AS XL4, SUM(SHIP_ED.XL5) AS XL5, SUM(SHIP_ED.XL6) AS XL6, SUM(SHIP_ED.TOTAL) AS TOTAL , ESTILO_EMP.L AS CAJA,ANCHO, LARGO,ALTO, DESTINO FROM SHIP_ED LEFT JOIN ESTILO_EMP ON SHIP_ED.ESTILO = ESTILO_EMP.ESTILO LEFT JOIN CPO_D ON (SHIP_ED.CPO = CPO_D.CPO AND SHIP_ED.ESTILO = CPO_D.ESTILO AND SHIP_ED.COLOR = CPO_D.COLOR) WHERE FECHA = '" & fechas & "' AND CLIENTE = '" & cliente.Text & "' GROUP BY SHIP_ED.CPO,SHIP_ED.ESTILO,SHIP_ED.COLOR,ESTILO_EMP.L,ESTILO_EMP.LARGO,ESTILO_EMP.ALTO,ESTILO_EMP.ANCHO,DESTINO "
        llena_tablas(dt, strSQl, cnn)
        fg.Rows.Count = 7 + dt.Rows.Count
        For Each Me.dr In dt.Rows
            Try
                fg(l, 1) = dr("CPO")
                fg(l, 2) = dr("COLOR")
                fg(l, 3) = dr("ESTILO")
                fg(l, 4) = dr("DESTINO")
                For i = 0 To 9
                    fg(l, i + 5) = dr(i + 3)
                Next
                fg(l, 15) = dr("CAJA")
                fg(l, 16) = dr("TOTAL")
                fg(l, 17) = dr("ANCHO")
                fg(l, 18) = dr("LARGO")
                fg(l, 19) = dr("ALTO")
                fg(l, 20) = fg(l, 16) / fg(l, 15)
                fg(l, 21) = (fg(l, 17) * fg(l, 18) * fg(l, 19)) / 1728 * 0.0283 * fg(l, 20)
                l = l + 1
            Catch
            End Try
        Next

        For i = 5 To 21
            If i < 17 Or i > 19 Then
                fg.Subtotal(AggregateEnum.Sum, 0, 0, i, "Gran Total -->")
            End If
        Next
    End Sub


    Private Sub encabezado()
        Dim i As Integer
        Dim rgn As CellRange
        Dim l As Integer = l

        fg.Rows.Count = fg.Rows.Count + 7
        For i = 1 To 5
            fg.Rows(i).Height = 30
        Next

        rgn = fg.GetCellRange(1, 1, 5, 21)
        rgn.Style = fg.Styles("nada")

        rgn = fg.GetCellRange(1, 1, 1, 1)
        rgn.Data = "FACTORY:"

        rgn = fg.GetCellRange(1, 2, 1, 2)
        rgn.Data = "TEXSUN"

        rgn = fg.GetCellRange(2, 1, 2, 1)
        rgn.Data = "SHIP DATE:"

        rgn = fg.GetCellRange(2, 2, 2, 2)
        rgn.Data = Format(CDate(Fecha.Text), "MM-dd-yyyy")

        rgn = fg.GetCellRange(3, 1, 3, 1)
        rgn.Data = "CUSTOMER:"

        rgn = fg.GetCellRange(3, 2, 3, 2)
        rgn.Data = cliente.Text

        rgn = fg.GetCellRange(4, 1, 4, 1)
        rgn.Data = "DATE:"

        rgn = fg.GetCellRange(4, 2, 4, 2)
        rgn.Data = Format(Today, "MM-dd-yyyy")

        rgn = fg.GetCellRange(5, 1, 5, 21)
        rgn.Style = fg.Styles("abajo")

        l = 6
        fg.Rows(6).Height = 35
        rgn = fg.GetCellRange(6, 1, 6, 21)
        rgn.Style = fg.Styles("cabeza")
        fg(l, 1) = "CPO"
        fg(l, 2) = "COLOR"
        fg(l, 3) = "STYLE"
        fg(l, 4) = "DESTINATION"
        fg(l, 5) = "XS"
        fg(l, 6) = "S"
        fg(l, 7) = "M"
        fg(l, 8) = "L"
        fg(l, 9) = "XL"
        fg(l, 10) = "2XL"
        fg(l, 11) = "3XL"
        fg(l, 12) = "4XL"
        fg(l, 13) = "5XL"
        fg(l, 14) = "6XL"
        fg(l, 15) = "PCS/CARTON"
        fg(l, 16) = "TTL Q'TY"
        fg(l, 17) = "W"
        fg(l, 18) = "L"
        fg(l, 19) = "H"
        fg(l, 20) = "C/T Q'TY"
        fg(l, 21) = "CBM"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Hoja.Visible = True
        Imprimir.Visible = True
        Button2.Visible = False
        Fecha.Enabled = False
        cliente.Enabled = False
        Regresar.Visible = True
        encabezado()
        proceso()
    End Sub

    Private Sub Hoja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hoja.Click
        Dim ok As Boolean
        Dim path As String = "c:\reportes\ship.xls"
        a_excel(fg, path, ok)
        If ok Then
            Close()
        End If
    End Sub

    Private Sub Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Imprimir.Click
        Print_fg()
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fechas As String
        fechas = Format(Today, "dd/MM/yyy")
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
        fg.PrintGrid("Shipping Schedule", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, Chr(9) + "Shipping Schedule " + Chr(9) + "Page {0}", "Date: " + Fecha.Text)
    End Sub

    Private Sub Regresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Regresar.Click
        fg.Rows.Count = 1
        fg.Rows(0).Visible = False
        Hoja.Visible = False
        Imprimir.Visible = False
        Button2.Visible = True
        Fecha.Enabled = True
        cliente.Enabled = True
        Regresar.Visible = False
    End Sub

    Public Sub llena_fechas()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim fechas As String
        strSQl = "SELECT DISTINCT FECHA, CLIENTE FROM SHIP_EE ORDER BY FECHA DESC"
        llena_tablas(dt, strSQl, cnn)
        Fecha.Items.Clear()
        For Each dr In dt.Rows
            fechas = Format(dr("FECHA"), "yyyy-MM-dd")
            Fecha.Items.Add(fechas)
        Next
        If Fecha.Items.Count > 0 Then
            Fecha.SelectedIndex = 0
        End If
    End Sub
End Class