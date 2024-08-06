Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized
Imports C1.C1Excel

Public Class Inventario_fis
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents C4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ucero As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Ob As System.Windows.Forms.ComboBox
    Friend WithEvents Regresar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Inventario_fis))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.C4 = New System.Windows.Forms.ComboBox()
        Me.Ucero = New System.Windows.Forms.ComboBox()
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Ob = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cliente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = "10,1,0,0,0,95,Columns:0{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1{Width:" & _
        "90;Name:""T_MATERIAL"";Caption:""T.MATERIAL"";TextAlign:LeftCenter;TextAlignFixed:Le" & _
        "ftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:380;Name:""DESCRIPCION"";Caption:""DESCRIPCION"";TextAlign:LeftCe" & _
        "nter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Width:90;Name:""UNIDAD_MEDIDA"";Caption:""U.MEDI" & _
        "DA"";TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{Width:90;Name:""EXISTENCIA" & _
        """;Caption:""UNIDADES"";Format:""###,###.00"";TextAlign:LeftCenter;TextAlignFixed:Lef" & _
        "tCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{Width:90;Name:""COSTO"";Caption:""COSTO U."";EditMask:""###,##0.0000"";Tex" & _
        "tAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "6{Width:100;Name:""TOTAL"";Caption:""" & _
        "COSTO TOT."";Format:""###,###.00"";TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & _
        "" & Microsoft.VisualBasic.ChrW(9) & "7{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{TextAlign:LeftCenter;TextA" & _
        "lignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "9{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(976, 648)
        Me.fg.StyleInfo = "Normal{Font:Microsoft Sans Serif, 9.75pt;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{}" & Microsoft.VisualBasic.ChrW(9) & "Fixed" & _
        "{BackColor:95, 156, 239;ForeColor:Black;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlig" & _
        "ht{Display:Stack;Format:""###,###.00"";BackColor:Highlight;ForeColor:HighlightText" & _
        ";TextAlign:LeftCenter;TextEffect:Flat;ImageAlign:LeftCenter;ImageSpacing:2;Trimm" & _
        "ing:None;WordWrap:False;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor:" & _
        "HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:PaleGoldenrod;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:Ap" & _
        "pWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeC" & _
        "olor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{Bac" & _
        "kColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;For" & _
        "eColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{B" & _
        "ackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;F" & _
        "oreColor:White;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 23
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Bitmap)
        Me.Button2.Location = New System.Drawing.Point(840, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 45
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Bitmap)
        Me.Button1.Location = New System.Drawing.Point(784, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 46
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para Desplegar el  Inventario de Telas. ")
        '
        'C4
        '
        Me.C4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C4.Location = New System.Drawing.Point(88, 16)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(184, 21)
        Me.C4.TabIndex = 47
        Me.ToolTip1.SetToolTip(Me.C4, "Elija el Tipo de Material a Consultar o seleccione ""TODOS"" para una Busqueda Tota" & _
        "l")
        '
        'Ucero
        '
        Me.Ucero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Ucero.Items.AddRange(New Object() {"No", "Si"})
        Me.Ucero.Location = New System.Drawing.Point(448, 16)
        Me.Ucero.Name = "Ucero"
        Me.Ucero.Size = New System.Drawing.Size(56, 21)
        Me.Ucero.TabIndex = 51
        Me.ToolTip1.SetToolTip(Me.Ucero, "Elija el Tipo de Material a Consultar o seleccione ""TODOS"" para una Busqueda Tota" & _
        "l")
        '
        'Regresar
        '
        Me.Regresar.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Regresar.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar.ForeColor = System.Drawing.Color.Black
        Me.Regresar.Image = CType(resources.GetObject("Regresar.Image"), System.Drawing.Bitmap)
        Me.Regresar.Location = New System.Drawing.Point(784, 8)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(35, 35)
        Me.Regresar.TabIndex = 60
        Me.Regresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Regresar, "Presione este Boton para Refrescar la pantalla  y volver a solicitar datos de bus" & _
        "queda.")
        Me.Regresar.Visible = False
        '
        'Ob
        '
        Me.Ob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Ob.Items.AddRange(New Object() {"No", "Si"})
        Me.Ob.Location = New System.Drawing.Point(640, 16)
        Me.Ob.Name = "Ob"
        Me.Ob.Size = New System.Drawing.Size(56, 21)
        Me.Ob.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(312, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 24)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Unidades = 0 ?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(544, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 24)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Obsoletas?"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Inventario_fis
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(990, 700)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Ob, Me.Label3, Me.Ucero, Me.Label1, Me.C4, Me.Button1, Me.Button2, Me.fg, Me.Label2, Me.Regresar})
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Inventario_fis"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte para toma de Inventario Físico"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim h As String = "##,###,##0.00"
    Dim strsql As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim obj As empresas
    Private Sub Inventario_fis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        C4.Items.Add("TODOS")
        llena_combos(C4, "SELECT DISTINCT CLIENTE FROM MATERIALES ORDER BY CLIENTE", "CLIENTE")
        C4.SelectedIndex = 0
        Ucero.SelectedIndex = 0
        Ob.SelectedIndex = 0
        setea_grid()
    End Sub

    Private Sub setea_grid()
        Dim index As Integer
        fg.Rows.Count = 1
        fg.Cols.Count = 8
        fg.Styles.Normal.Border.Style = BorderStyleEnum.Inset
        fg.Cols(0).Width = 0
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Caption = "TIPO"
        fg.Cols(2).Caption = "CODIGO"
        fg.Cols(3).Caption = "CLIENTE"
        fg.Cols(4).Caption = "DESCRIPCION"
        fg.Cols(5).Caption = "U.MEDIDA"
        fg.Cols(6).Caption = "UNIDADES"
        fg.Cols(6).DataType = GetType(Decimal)
        fg.Cols(6).Format = h
        fg.Cols(6).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(6).TextAlignFixed = TextAlignEnum.RightCenter
        fg.Cols(7).Caption = "FISICO"
        fg.Cols(7).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(7).TextAlignFixed = TextAlignEnum.CenterCenter
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 90
        Next
        fg.Cols(7).Width = 100
        fg.Cols(4).Width = 390
    End Sub

    Private Sub llena_grid()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim l As Integer = 1
        Try
            llena_tablas(dt, strsql, cnn)
            fg.Rows.Count = dt.Rows.Count - 1
            For Each dr In dt.Rows
                fg.Rows(l).Height = 25
                fg(l, 3) = dr("CLIENTE")
                fg(l, 1) = dr("T_MATERIAL")
                fg(l, 2) = dr("CODIGO")
                fg(l, 4) = dr("DESCRIPCION")
                fg(l, 5) = dr("UNIDAD_MEDIDA")
                fg(l, 6) = dr("EXISTENCIA")
                fg(l, 7) = ""
                l = l + 1
            Next
        Catch
        End Try
        fg.Sort(SortFlags.Ascending, 1, 2)
        subtotales()
    End Sub

    Private Sub crea_string()
        Dim cli As Boolean = False
        Dim ex As Boolean = False
        strsql = "SELECT CLIENTE,T_MATERIAL,CODIGO,DESCRIPCION,UNIDAD_MEDIDA,EXISTENCIA FROM MATERIALES WHERE T_MATERIAL <> 'THREAD' AND T_MATERIAL <> 'HILO' AND "
        If Trim(C4.Text) <> "TODOS" Then
            strsql = strsql & " CLIENTE = '" & C4.Text & "' "
            cli = True
        End If
        If Ucero.Text = "No" Then
            If cli Then
                strsql = strsql & " AND EXISTENCIA > 0 "
            Else
                strsql = strsql & "EXISTENCIA > 0 "
            End If
            ex = True
        End If
        If Ob.Text = "No" Then
            If cli Or ex Then
                strsql = strsql & " AND T_MATERIAL <> 'OBSOLETO'"
            Else
                strsql = strsql & " AND T_MATERIAL <> 'OBSOLETO'"
            End If
        End If
        strsql = strsql & " ORDER BY CLIENTE,T_MATERIAL,CODIGO "
    End Sub

    Private Sub subtotales()
        fg.Subtotal(AggregateEnum.Sum, 1, 1, 6, "Total")
        fg.Subtotal(AggregateEnum.Sum, -1, -1, 6, "Gran Total")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        setea_grid()
        crea_string()
        llena_grid()
        Button1.Visible = False
        Regresar.Visible = True
        C4.Enabled = False
        Ucero.Enabled = False
        Ob.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print_fg()
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        Dim mal As String
        Dim obj As empresas
        obj = New empresas()
        mal = "(" + obj.nombre + ")  Listado para toma de Inventario físico Materiales "
        fecha = Format(Today, "dd/MM/yyy")
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = False
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 80
            .Margins.Bottom = 80
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("Telas", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, mal + " al  " + fecha + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Regresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Regresar.Click
        Button1.Visible = True
        C4.Enabled = True
        Ucero.Enabled = True
        Ob.Enabled = True
        setea_grid()
    End Sub
End Class
