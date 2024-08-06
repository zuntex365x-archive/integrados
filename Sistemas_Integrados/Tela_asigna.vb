Imports C1.Win.C1FlexGrid

Public Class Tela_asigna
    Inherits System.Windows.Forms.Form

    Dim cnn1 As SqlClient.SqlConnection
    Dim lineas As Integer
    Public dentro As String
    Public nodentro As String
    Public cliente As String
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Cpo As System.Windows.Forms.Label
    Friend WithEvents Estilo As System.Windows.Forms.Label
    Friend WithEvents Colo As System.Windows.Forms.Label
    Friend WithEvents fp As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Tela_asigna))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cpo = New System.Windows.Forms.Label()
        Me.Estilo = New System.Windows.Forms.Label()
        Me.Colo = New System.Windows.Forms.Label()
        Me.fp = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.FromArgb(CType(253, Byte), CType(249, Byte), CType(198, Byte))
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1{TextAl" & _
        "ign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{TextAlign:LeftCenter;TextAlignFixed" & _
        ":LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{TextAlign:Lef" & _
        "tCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{TextAlign:LeftCenter;TextAlignFixed:LeftCe" & _
        "nter;}" & Microsoft.VisualBasic.ChrW(9) & "6{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{TextAlign:LeftCenter" & _
        ";TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & _
        "9{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 80)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(944, 336)
        Me.fg.StyleInfo = "Normal{Font:Microsoft Sans Serif, 8.25pt;BackColor:253, 249, 198;ForeColor:Black;" & _
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
        "kDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "pedido{}" & Microsoft.VisualBasic.ChrW(9) & "proceso{BackColor:Aquamarine;}" & Microsoft.VisualBasic.ChrW(9) & "cortado{BackColo" & _
        "r:AntiqueWhite;}" & Microsoft.VisualBasic.ChrW(9) & "total{BackColor:95, 156, 239;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Estilo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "CPO:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(552, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Color:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cpo
        '
        Me.cpo.BackColor = System.Drawing.Color.White
        Me.cpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpo.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.cpo.Location = New System.Drawing.Point(112, 8)
        Me.cpo.Name = "Cpo"
        Me.cpo.Size = New System.Drawing.Size(160, 20)
        Me.cpo.TabIndex = 71
        Me.cpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Estilo
        '
        Me.Estilo.BackColor = System.Drawing.Color.White
        Me.Estilo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Estilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Estilo.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Estilo.Location = New System.Drawing.Point(112, 32)
        Me.Estilo.Name = "Estilo"
        Me.Estilo.Size = New System.Drawing.Size(296, 20)
        Me.Estilo.TabIndex = 72
        Me.Estilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Colo
        '
        Me.Colo.BackColor = System.Drawing.Color.White
        Me.Colo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Colo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colo.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Colo.Location = New System.Drawing.Point(624, 32)
        Me.Colo.Name = "Colo"
        Me.Colo.Size = New System.Drawing.Size(312, 20)
        Me.Colo.TabIndex = 73
        Me.Colo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fp
        '
        Me.fp.AllowEditing = False
        Me.fp.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fp.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fp.BackColor = System.Drawing.Color.AntiqueWhite
        Me.fp.ColumnInfo = "10,1,0,0,0,85,Columns:0{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1{TextAl" & _
        "ign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{TextAlign:LeftCenter;TextAlignFixed" & _
        ":LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{TextAlign:Lef" & _
        "tCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{TextAlign:LeftCenter;TextAlignFixed:LeftCe" & _
        "nter;}" & Microsoft.VisualBasic.ChrW(9) & "6{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{TextAlign:LeftCenter" & _
        ";TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & _
        "9{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fp.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fp.ForeColor = System.Drawing.Color.Black
        Me.fp.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fp.Location = New System.Drawing.Point(8, 440)
        Me.fp.Name = "fp"
        Me.fp.Rows.DefaultSize = 17
        Me.fp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fp.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fp.Size = New System.Drawing.Size(944, 248)
        Me.fp.StyleInfo = "Normal{Font:Microsoft Sans Serif, 8.25pt;BackColor:AntiqueWhite;ForeColor:Black;T" & _
        "extAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:AntiqueWhite;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:95, 156" & _
        ", 239;ForeColor:Black;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:Black" & _
        ";ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor:Highlig" & _
        "htText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Bord" & _
        "er:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Su" & _
        "btotal0{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:Black;ForeColor:" & _
        "White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:186, 1" & _
        "96, 228;ForeColor:Black;ImageAlign:RightTop;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDar" & _
        "k;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtot" & _
        "al4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkD" & _
        "ark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "pedido{}" & Microsoft.VisualBasic.ChrW(9) & "proceso{BackColor:Aquamarine;}" & Microsoft.VisualBasic.ChrW(9) & "cortado{BackColor:" & _
        "AntiqueWhite;}" & Microsoft.VisualBasic.ChrW(9) & "total{BackColor:95, 156, 239;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fp.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fp.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 16)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Tela Asignada al Cpo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.cpo, Me.Label2, Me.Label1, Me.Estilo, Me.Label3, Me.Colo})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(944, 56)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 424)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 16)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Tela otros Cpo's"
        '
        'Tela_asigna
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(958, 692)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label5, Me.GroupBox1, Me.Label4, Me.fp, Me.fg})
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tela_asigna"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Tela Asignada al  CPO - Estilo - Color"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Bal_Tela_Det1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        def_sql(cnn1)
        setea_fg()
        setea_fp()
        llena_asignadas()
        llena_no_asignadas()
        subtotales()
    End Sub

    Private Sub setea_fg()
        Dim index As Integer
        fg.Clear()
        fg.Rows.Count = 1
        fg.Cols.Count = 9
        fg.Cols(0).Width = 5
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Name = "TELA"
        fg.Cols(2).Name = "COLOR"
        fg.Cols(3).Name = "BATCH"
        fg.Cols(4).Name = "ROLLO"
        fg.Cols(5).Name = "FPO"
        fg.Cols(6).Name = "CPO"
        fg.Cols(7).Name = "LIBRAS"
        fg.Cols(8).Name = "YARDAS"
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 90
            fg(0, index) = fg.Cols(index).Name
            If index > 6 Then
                fg.Cols(index).DataType = GetType(Decimal)
                fg.Cols(index).Format = "######0.00"
                fg.Cols(index).Width = 80
                fg.Cols(index).TextAlign = TextAlignEnum.RightCenter
                fg.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
        fg.Cols(1).Width = 250
        fg.Cols(2).Width = 160
        fg.Cols(4).Width = 60
        fg.Cols(4).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(4).TextAlignFixed = TextAlignEnum.CenterCenter
    End Sub

    Private Sub setea_fp()
        Dim index As Integer
        fp.Clear()
        fp.Rows.Count = 1
        fp.Cols.Count = 9
        fp.Cols(0).Width = 5
        fp.Rows(0).Height = 30
        Dim c As Column = fp.Cols(1)
        fp.Cols(1).Name = "TELA"
        fp.Cols(2).Name = "COLOR"
        fp.Cols(3).Name = "BATCH"
        fp.Cols(4).Name = "ROLLO"
        fp.Cols(5).Name = "FPO"
        fp.Cols(6).Name = "CPO"
        fp.Cols(7).Name = "LIBRAS"
        fp.Cols(8).Name = "YARDAS"
        For index = 1 To fp.Cols.Count - 1
            fp.Cols(index).Width = 90
            fp(0, index) = fp.Cols(index).Name
            If index > 6 Then
                fp.Cols(index).DataType = GetType(Decimal)
                fp.Cols(index).Format = "######0.00"
                fp.Cols(index).Width = 80
                fp.Cols(index).TextAlign = TextAlignEnum.RightCenter
                fp.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
        fp.Cols(1).Width = 250
        fp.Cols(2).Width = 160
        fp.Cols(4).Width = 60
        fp.Cols(4).TextAlign = TextAlignEnum.CenterCenter
        fp.Cols(4).TextAlignFixed = TextAlignEnum.CenterCenter
    End Sub


    Private Sub llena_asignadas()
        Dim dt As New DataTable()
        'Dim strSQL As String = "SELECT ROLLOS.*, DESCRIPCION, ((PESO/YARDAS_I)*YARDAS) AS LIBRAS FROM ROLLOS LEFT JOIN CODIGO_TELA ON CODIGO_TELA.CODIGO = ROLLOS.CODIGO WHERE ROLLOS.CODIGO+COLOR IN " & dentro & " AND YARDAS >0 AND TIPO = 'TELA' AND ACTIVO IN ('S','0','5') and CPO = '" & Cpo.Text & "'"
        Dim strSQL As String = "SELECT ROLLOS.*, ((PESO/YARDAS_I)*YARDAS) AS LIBRAS FROM ROLLOS WHERE ROLLOS.CPO+ROLLOS.COLOR IN " & dentro & " AND YARDAS >0 AND TIPO = 'TELA' AND ACTIVO IN ('S','0','5') "
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn1)
        For Each dr In dt.Rows
            lineas = fg.Rows.Count
            fg.Rows.Count = lineas + 1
            fg(lineas, 1) = dr("KNIT")
            fg(lineas, 2) = dr("COLOR")
            fg(lineas, 3) = dr("BATCH")
            fg(lineas, 4) = dr("ROLLO")
            fg(lineas, 5) = dr("FPO")
            fg(lineas, 6) = dr("CPO")
            fg(lineas, 7) = dr("LIBRAS")
            fg(lineas, 8) = dr("YARDAS")
        Next
        fg.Sort(SortFlags.Ascending, 1)
    End Sub

    Private Sub llena_no_asignadas()
        Dim dt As New DataTable()
        Dim strSQL As String = "SELECT ROLLOS.*, ((PESO/YARDAS_I)*YARDAS) AS LIBRAS FROM ROLLOS WHERE ROLLOS.CPO+ROLLOS.COLOR NOT IN " & dentro & " AND YARDAS >0 AND TIPO = 'TELA' AND ACTIVO IN ('S','0','5') AND CLIENTE = '" & cliente & "' AND COLOR = '" & Colo.Text & "'"
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn1)
        For Each dr In dt.Rows
            lineas = fp.Rows.Count
            fp.Rows.Count = lineas + 1
            fp(lineas, 1) = dr("KNIT")
            fp(lineas, 2) = dr("COLOR")
            fp(lineas, 3) = dr("BATCH")
            fp(lineas, 4) = dr("ROLLO")
            fp(lineas, 5) = dr("FPO")
            fp(lineas, 6) = dr("CPO")
            fp(lineas, 7) = dr("LIBRAS")
            fp(lineas, 8) = dr("YARDAS")
        Next
        fp.Sort(SortFlags.Ascending, 1)
    End Sub

    Private Sub subtotales()
        fg.Subtotal(AggregateEnum.Sum, -1, -1, 7, "Gran Total")
        fg.Subtotal(AggregateEnum.Sum, -1, -1, 8, "Gran Total")
        fp.Subtotal(AggregateEnum.Sum, -1, -1, 7, "Gran Total")
        fp.Subtotal(AggregateEnum.Sum, -1, -1, 8, "Gran Total")
    End Sub

End Class
