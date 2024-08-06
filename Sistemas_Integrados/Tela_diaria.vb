Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Tela_diaria
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
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ex As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Estado As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Tela_diaria))
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Estado = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ex = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fecha
        '
        Me.fecha.CustomFormat = "dd/MM/yyyy"
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.fecha.Location = New System.Drawing.Point(88, 8)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(112, 26)
        Me.fecha.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.fecha, "Fecha de la cual se desea Consultar o Imprimir el Reporte de Tela Recibida.")
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 32)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fecha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1{TextAl" & _
        "ign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{TextAlign:LeftCenter;TextAlignFixed" & _
        ":LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{TextAlign:Lef" & _
        "tCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{TextAlign:LeftCenter;TextAlignFixed:LeftCe" & _
        "nter;}" & Microsoft.VisualBasic.ChrW(9) & "6{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{TextAlign:LeftCenter" & _
        ";TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & _
        "9{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 56)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.Size = New System.Drawing.Size(992, 624)
        Me.fg.StyleInfo = "Normal{Font:Microsoft Sans Serif, 8.25pt;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:95, 156, 239;ForeColor:Black;Border:Flat,1,ControlDar" & _
        "k,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{" & _
        "}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:PaleGold" & _
        "enrod;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark," & _
        "Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlD" & _
        "arkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & _
        "Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:Contro" & _
        "lDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:White;" & _
        "}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.TabIndex = 23
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Bitmap)
        Me.Button2.Location = New System.Drawing.Point(560, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 45
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Bitmap)
        Me.Button1.Location = New System.Drawing.Point(504, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 46
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para iniciar la Busqueda de Tela Recibida en la fecha Selecci" & _
        "onada.")
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Bitmap)
        Me.Button3.Location = New System.Drawing.Point(616, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 49
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button3.Visible = False
        '
        'Estado
        '
        Me.Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Estado.Items.AddRange(New Object() {"TODOS", "TELA", "CUELLOS Y PUÑOS"})
        Me.Estado.Location = New System.Drawing.Point(304, 8)
        Me.Estado.Name = "Estado"
        Me.Estado.Size = New System.Drawing.Size(144, 24)
        Me.Estado.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.Estado, "Elija el Tipo a Consultar")
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Bitmap)
        Me.Button4.Location = New System.Drawing.Point(504, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 35)
        Me.Button4.TabIndex = 54
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button4, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        '
        'ex
        '
        Me.ex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.ex.ForeColor = System.Drawing.Color.Black
        Me.ex.Location = New System.Drawing.Point(16, 528)
        Me.ex.Name = "ex"
        Me.ex.Rows.DefaultSize = 17
        Me.ex.Size = New System.Drawing.Size(288, 120)
        Me.ex.StyleInfo = "Normal{Font:Microsoft Sans Serif, 8.25pt;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{Back" & _
        "Color:95, 156, 239;ForeColor:Black;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{Ba" & _
        "ckColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Hi" & _
        "ghlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{Ba" & _
        "ckColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:B" & _
        "lack;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Sub" & _
        "total1{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDa" & _
        "rkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "S" & _
        "ubtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:Control" & _
        "DarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9)
        Me.ex.TabIndex = 50
        Me.ex.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 24)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Tipo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tela_diaria
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(1006, 684)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Estado, Me.Label1, Me.ex, Me.fg, Me.Button3, Me.Button1, Me.Button2, Me.fecha, Me.Label2, Me.Button4})
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tela_diaria"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Diario de Tela / Cuellos y Puños  Recibidos"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim h As String = "#######0.00"
    Dim g As String = "######0"
    Dim r As String = "00000000"
    Dim x As String = "MM/dd/yyyy"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn1 As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim strSQL As String
    Dim FECHAS As String
    Dim path As String = "c:\reportes\diaria.xls"

    Private Sub Tela_diaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        Estado.SelectedIndex = 0
        setea_grid()
    End Sub

    Private Sub setea_grid()
        Try
            Dim index As Integer
            fg.Rows.Count = 1
            fg.Cols.Count = 16
            fg.Cols(0).Width = 0
            fg.Rows(0).Height = 30
            Dim c As Column = fg.Cols(1)
            fg.Cols(1).Name = "BATCH"
            fg.Cols(2).Name = "CLIENTE"
            fg.Cols(3).Name = "FPO"
            fg.Cols(4).Name = "COLOR"
            fg.Cols(5).Name = "CPO"
            fg.Cols(6).Name = "DESCRIPCION DE LA TELA"
            fg.Cols(7).Name = "KNIT"
            fg.Cols(8).Name = "ANCHO"
            fg.Cols(9).Name = "YFIBER"
            fg.Cols(10).Name = "YFINISH"
            fg.Cols(11).Name = "LOTE"
            fg.Cols(12).Name = "TEXTILERA"
            fg.Cols(13).Name = "ROLLO"
            fg.Cols(14).Name = "YARDAS"
            fg.Cols(15).Name = "LIBRAS"
            fg.Cols(8).TextAlign = TextAlignEnum.CenterCenter
            fg.Cols(8).TextAlignFixed = TextAlignEnum.CenterCenter
            fg.Cols(5).TextAlign = TextAlignEnum.CenterCenter
            fg.Cols(5).TextAlignFixed = TextAlignEnum.CenterCenter
            fg.Cols(11).DataType = GetType(Decimal)
            fg.Cols(11).Format = g
            fg.Cols(11).TextAlign = TextAlignEnum.CenterCenter
            fg.Cols(11).TextAlignFixed = TextAlignEnum.CenterCenter
            fg.Cols(14).DataType = GetType(Decimal)
            fg.Cols(14).Format = h
            fg.Cols(14).TextAlign = TextAlignEnum.RightCenter
            fg.Cols(14).TextAlignFixed = TextAlignEnum.RightCenter
            fg.Cols(15).DataType = GetType(Decimal)
            fg.Cols(15).Format = h
            fg.Cols(15).TextAlign = TextAlignEnum.RightCenter
            fg.Cols(15).TextAlignFixed = TextAlignEnum.RightCenter
            fg.Cols(13).TextAlign = TextAlignEnum.CenterCenter
            fg.Cols(13).TextAlignFixed = TextAlignEnum.CenterCenter
            For index = 1 To fg.Cols.Count - 1
                fg.Cols(index).Width = 120
                fg(0, index) = fg.Cols(index).Name
            Next
            fg.Cols(1).Width = 90
            fg.Cols(2).Width = 80
            fg.Cols(3).Width = 70
            fg.Cols(4).Width = 150
            fg.Cols(5).Width = 70
            fg.Cols(6).Width = 260
            fg.Cols(7).Width = 150
            fg.Cols(8).Width = 60
            fg.Cols(9).Width = 150
            fg.Cols(10).Width = 150
            fg.Cols(11).Width = 50
            fg.Cols(13).Width = 50
            fg.Cols(14).Width = 60
            fg.Cols(15).Width = 60
            fg.Cols(12).Width = 150
        Catch
        End Try
    End Sub

    Private Sub busca_tela()
        Dim dt As New DataTable()
        Dim dr As DataRow
        fg.ScrollBars = ScrollBars.None
        llena_tablas(dt, strSQL, cnn1)
        lineas = dt.Rows.Count
        fg.Rows.Count = lineas + 1
        lineas = 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("BATCH")
            fg(lineas, 2) = dr("CLIENTE")
            fg(lineas, 3) = dr("FPO")
            fg(lineas, 4) = dr("COLOR")
            fg(lineas, 5) = dr("CPO")
            fg(lineas, 6) = dr("DESCRIPCION")
            fg(lineas, 7) = dr("KNIT")
            fg(lineas, 8) = dr("ANCHO")
            fg(lineas, 9) = dr("YFIBER")
            fg(lineas, 10) = dr("YFINISH")
            fg(lineas, 11) = dr("LOTE")
            fg(lineas, 12) = dr("TEXTILERA")
            fg(lineas, 13) = dr("ROLLO")
            fg(lineas, 14) = dr("YARDAS")
            fg(lineas, 15) = dr("LIBRAS")
            lineas = lineas + 1
        Next
    End Sub


    Private Sub subtotales()
        fg.Cols(1).AllowMerging = True
        fg.Cols(2).AllowMerging = True
        fg.Cols(3).AllowMerging = True
        fg.Cols(4).AllowMerging = True
        fg.Cols(5).AllowMerging = True
        fg.Cols(6).AllowMerging = True
        fg.Cols(7).AllowMerging = True
        fg.Cols(8).AllowMerging = True
        fg.Cols(9).AllowMerging = True
        fg.Cols(10).AllowMerging = True
        fg.Cols(11).AllowMerging = True
        fg.Cols(12).AllowMerging = True
        fg.ScrollBars = ScrollBars.Both
        With fg
            .Redraw = False
            ' set the tree on column 0
            .Tree.Column = 1
            .Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.Simple

            Dim totalya As Integer = fg.Cols("YARDAS").Index
            fg.Subtotal(AggregateEnum.Sum, 1, 12, totalya)
            Dim totalib As Integer = fg.Cols("LIBRAS").Index
            fg.Subtotal(AggregateEnum.Sum, 1, 12, totalib)
            fg.Subtotal(AggregateEnum.Sum, 0, 0, totalya, "Gran Total -->")
            fg.Subtotal(AggregateEnum.Sum, 0, 0, totalib, "Gran Total -->")
            'change backcolor of subtotals
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).BackColor = Color.Black
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal0).ForeColor = Color.White
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).BackColor = Color.White
            .Styles(C1.Win.C1FlexGrid.CellStyleEnum.Subtotal1).ForeColor = Color.Black
            .Redraw = True
            fg.Tree.Show(1)
        End With
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        llena_Grid()
        subtotales()
        fg.ScrollBars = ScrollBars.Both
        Button1.Visible = False
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        fecha.Enabled = False
        Estado.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print_fg()
    End Sub

    Private Sub setea_busqueda()
        FECHAS = Format(CDate(fecha.Text), "yyyy-MM-dd")
        strSQL = "SELECT DMOVTO.FECHA AS FECHA, DMOVTO.BATCH AS BATCH , DMOVTO.ROLLO AS ROLLO, ROLLOS.COLOR, ROLLOS.COLOR as COLOR, ROLLOS.YARDAS_I AS YARDAS, ROLLOS.PESO AS LIBRAS,ROLLOS.CLIENTE, ROLLOS.FPO AS FPO, ROLLOS.CPO AS CPO, ROLLOS.FPO AS FPO, ROLLOS.CLIENTE AS CLIENTE, ROLLOS.YFIBER AS YFIBER , ROLLOS.YFINISH AS YFINISH, ROLLOS.KNIT AS KNIT , ANCHO, LOTE ,DESCRIPCION ,(SELECT DISTINCT TEXTILERA FROM FPO WHERE DMOVTO.FPO = FPO.FPO) AS TEXTILERA FROM DMOVTO INNER JOIN ROLLOS ON DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO LEFT JOIN CODIGO_TELA ON CODIGO_TELA.CODIGO = ROLLOS.CODIGO WHERE FECHA = '" & FECHAS & "' AND TMOVTO = '1' ORDER BY ROLLOS.BATCH, ROLLOS.COLOR"
        If Estado.SelectedIndex = 1 Then
            strSQL = "SELECT DMOVTO.FECHA AS FECHA, DMOVTO.BATCH AS BATCH , DMOVTO.ROLLO AS ROLLO, ROLLOS.COLOR, ROLLOS.COLOR as COLOR, ROLLOS.YARDAS_I AS YARDAS, ROLLOS.PESO AS LIBRAS,ROLLOS.CLIENTE, ROLLOS.FPO AS FPO, ROLLOS.CPO AS CPO, ROLLOS.FPO AS FPO, ROLLOS.CLIENTE AS CLIENTE, ROLLOS.YFIBER AS YFIBER , ROLLOS.YFINISH AS YFINISH, ROLLOS.KNIT AS KNIT , ANCHO, LOTE ,DESCRIPCION ,(SELECT DISTINCT TEXTILERA FROM FPO WHERE DMOVTO.FPO = FPO.FPO) AS TEXTILERA FROM DMOVTO INNER JOIN ROLLOS ON DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO LEFT JOIN CODIGO_TELA ON CODIGO_TELA.CODIGO = ROLLOS.CODIGO WHERE FECHA = '" & FECHAS & "' AND TMOVTO = '1' AND ROLLOS.TIPO =  'TELA' ORDER BY ROLLOS.BATCH, ROLLOS.COLOR"
        Else
            If Estado.SelectedIndex = 2 Then
                strSQL = "SELECT DMOVTO.FECHA AS FECHA, DMOVTO.BATCH AS BATCH , DMOVTO.ROLLO AS ROLLO, ROLLOS.COLOR, ROLLOS.COLOR as COLOR, ROLLOS.YARDAS_I AS YARDAS, ROLLOS.PESO AS LIBRAS,ROLLOS.CLIENTE, ROLLOS.FPO AS FPO, ROLLOS.CPO AS CPO, ROLLOS.FPO AS FPO, ROLLOS.CLIENTE AS CLIENTE, ROLLOS.YFIBER AS YFIBER , ROLLOS.YFINISH AS YFINISH, ROLLOS.KNIT AS KNIT , ANCHO, LOTE ,DESCRIPCION ,(SELECT DISTINCT TEXTILERA FROM FPO WHERE DMOVTO.FPO = FPO.FPO) AS TEXTILERA FROM DMOVTO INNER JOIN ROLLOS ON DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO LEFT JOIN CODIGO_TELA ON CODIGO_TELA.CODIGO = ROLLOS.CODIGO WHERE FECHA = '" & FECHAS & "' AND TMOVTO = '1' AND ROLLOS.TIPO <> 'TELA' ORDER BY ROLLOS.BATCH, ROLLOS.COLOR"
            End If
        End If
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
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
        fg.PrintGrid("Telas", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, "Reporte de Tela Recibida el dia : " + fecha.Text + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim si As Boolean
        datos_excel(si)
        If si Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio: " & Path, MsgBoxStyle.OKOnly, "TRASLADO DE DATOS ")
            Close()
        Else
        End If
    End Sub

    Private Sub llena_Grid()
        setea_grid()
        setea_busqueda()
        busca_tela()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        setea_grid()
        Button1.Visible = True
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        fecha.Enabled = True
        Estado.Enabled = True
    End Sub


    Private Sub datos_excel(ByRef si As Boolean)
        setea_ex()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim FECHAS As String
        FECHAS = Format(CDate(fecha.Text), "yyyy-MM-dd")
        Dim strSQL As String = "SELECT DMOVTO.FECHA AS FECHA, ROLLOS.BATCH AS BATCH, ROLLOS.COLOR AS COLOR, ROLLOS.CLIENTE AS CLIENTE, ROLLOS.FPO AS FPO, ROLLOS.CPO AS CPO, ROLLOS.KNIT AS KNIT, ROLLOS.YFIBER AS YFIBER , SUM(ROLLOS.YARDAS_I) AS YARDAS , SUM(PESO) AS LIBRAS, COUNT(ROLLOS.ROLLO) AS ROLLO, ANCHO, LOTE,(SELECT DISTINCT TEXTILERA FROM FPO WHERE ROLLOS.FPO = FPO.FPO AND FPO.LOTE = ROLLOS.LOTE) AS TEXTILERA, DESCRIPCION  FROM ROLLOS,DMOVTO,CODIGO_TELA WHERE DMOVTO.FECHA = '" & FECHAS & "' AND DMOVTO.TMOVTO = '1'  AND DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO AND ROLLOS.CODIGO = CODIGO_TELA.CODIGO GROUP BY ROLLOS.BATCH, ROLLOS.KNIT, ROLLOS.COLOR, ROLLOS.CLIENTE, ROLLOS.FPO, ROLLOS.CPO, ROLLOS.YFIBER ,ANCHO, DMOVTO.FECHA, LOTE, DESCRIPCION ORDER BY ROLLOS.BATCH, ROLLOS.COLOR"
        llena_tablas(dt, strSQL, cnn1)
        lineas = dt.Rows.Count
        ex.Rows.Count = lineas + 1
        lineas = 1
        For Each dr In dt.Rows
            ex(lineas, 0) = dr("FECHA")
            ex(lineas, 1) = dr("BATCH")
            ex(lineas, 2) = dr("CLIENTE")
            ex(lineas, 3) = dr("FPO")
            ex(lineas, 4) = dr("COLOR")
            ex(lineas, 5) = dr("CPO")
            ex(lineas, 6) = dr("DESCRIPCION")
            ex(lineas, 7) = dr("KNIT")
            ex(lineas, 8) = dr("YFIBER")
            ex(lineas, 9) = dr("ANCHO")
            ex(lineas, 10) = dr("LOTE")
            ex(lineas, 11) = dr("ROLLO")
            ex(lineas, 12) = dr("YARDAS")
            ex(lineas, 13) = dr("LIBRAS")
            ex(lineas, 14) = dr("TEXTILERA")
            lineas = lineas + 1
        Next
        Dim path As String = "c:\reportes\diaria.xls"
        Try
            If File.Exists(path) Then
                File.Delete(path)
            End If
            ex.SaveGrid(path, FileFormatEnum.Excel, FileFlags.IncludeFixedCells)
            System.Diagnostics.Process.Start(path)
            si = True
        Catch
            MsgBox("Por favor cierre todas sus Hojas de Excel y vuelva a tratar. Gracias", MsgBoxStyle.OKOnly, "Atencion ")
            si = False
        End Try
    End Sub

    Private Sub setea_ex()
        Dim index As Integer
        ex.Rows(0).Height = 30
        ex.Cols.Fixed = 0
        ex.Rows.Count = 1
        ex.Cols.Count = 15
        ex.Cols(0).Name = "FECHA"
        ex.Cols(1).Name = "BATCH"
        ex.Cols(2).Name = "CLIENTE"
        ex.Cols(3).Name = "FPO"
        ex.Cols(4).Name = "COLOR"
        ex.Cols(5).Name = "CPO"
        ex.Cols(6).Name = "DESCRIPCION DE LA TELA"
        ex.Cols(7).Name = "KNIT"
        ex.Cols(8).Name = "YARN FIBER"
        ex.Cols(9).Name = "ANCHO"
        ex.Cols(10).Name = "LOTE"
        ex.Cols(11).Name = "ROLLOS"
        ex.Cols(12).Name = "YARDAS"
        ex.Cols(13).Name = "LIBRAS"
        ex.Cols(14).Name = "TEXTILERA"
        ex.Cols(0).DataType = GetType(Date)
        ex.Cols(0).Format = "dd-MM-yyyy"
        ex.Cols(11).DataType = GetType(Decimal)
        ex.Cols(11).Format = g
        ex.Cols(11).TextAlign = TextAlignEnum.CenterCenter
        ex.Cols(11).TextAlignFixed = TextAlignEnum.CenterCenter
        ex.Cols(12).DataType = GetType(Decimal)
        ex.Cols(12).Format = h
        ex.Cols(12).TextAlign = TextAlignEnum.RightCenter
        ex.Cols(12).TextAlignFixed = TextAlignEnum.RightCenter
        ex.Cols(13).DataType = GetType(Decimal)
        ex.Cols(13).Format = h
        ex.Cols(13).TextAlign = TextAlignEnum.RightCenter
        ex.Cols(13).TextAlignFixed = TextAlignEnum.RightCenter
        For index = 0 To ex.Cols.Count - 1
            ex.Cols(index).Width = 120
            ex(0, index) = ex.Cols(index).Name
        Next
    End Sub

End Class
