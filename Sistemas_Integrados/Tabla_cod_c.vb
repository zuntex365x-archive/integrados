Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Imports System.IO

Public Class Tabla_cod_c
    Inherits System.Windows.Forms.Form
    Dim ok As Boolean
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim strSQl As String
    Dim lineas As Integer
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Tabla_cod_c))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "8,1,0,0,0,85,Columns:0{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1{TextAli" & _
        "gn:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{TextAlign:LeftCenter;TextAlignFixed:" & _
        "LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{TextAlign:Left" & _
        "Center;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{TextAlign:LeftCenter;TextAlignFixed:LeftCen" & _
        "ter;}" & Microsoft.VisualBasic.ChrW(9) & "6{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{TextAlign:LeftCenter;" & _
        "TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(24, 16)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 17
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(976, 664)
        Me.fg.StyleInfo = "Normal{Font:Microsoft Sans Serif, 8.25pt;BackColor:White;ForeColor:Black;TextAlig" & _
        "n:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{Font:Microsoft Sans Serif, 8.25" & _
        "pt, style=Bold;BackColor:85, 240, 186;ForeColor:Black;Border:Flat,1,ControlDark," & _
        "Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:218, 215, 247;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{BackColor:218, " & _
        "215, 247;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Editor{BackColor:218, 215, 247;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Sear" & _
        "ch{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow" & _
        "{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTo" & _
        "tal{Font:Microsoft Sans Serif, 9pt, style=Bold;BackColor:Black;ForeColor:White;}" & _
        "" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{Font:Microsoft Sans Serif, 9pt, style=Bold;BackColor:Black;ForeColor:" & _
        "White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{Font:Microsoft Sans Serif, 11.25pt, style=Bold;BackColor:186, " & _
        "196, 228;ForeColor:Black;ImageAlign:RightTop;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDa" & _
        "rk;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subto" & _
        "tal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDark" & _
        "Dark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "c1{Font:Microsoft Sans Serif, 9.75pt;BackColor:129, 192, " & _
        "239;Border:None,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "amarillo{BackColor:248, 250, 177;Border:Inset,1,B" & _
        "lack,Both;}" & Microsoft.VisualBasic.ChrW(9) & "verde{BackColor:173, 233, 215;}" & Microsoft.VisualBasic.ChrW(9) & "rojo{BackColor:PaleGoldenrod;Border:" & _
        "Raised,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "c2{BackColor:129, 192, 239;Border:Inset,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "c3{" & _
        "BackColor:209, 223, 241;Border:None,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9) & "c4{BackColor:209, 223, 241;Bo" & _
        "rder:Inset,1,Black,Both;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.TabIndex = 63
        Me.ToolTip1.SetToolTip(Me.fg, "Si desea eliminar presione la tecla (Del)  o  (Supr)")
        '
        'Tabla_cod_c
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.fg})
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tabla_cod_c"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tabla de Codigos"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub ESTADO_cPO(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        def_sql(cnn)
        setea_fg()
        llena_fg()
    End Sub

    Private Sub setea_fg()
        Dim index As Integer
        fg.Clear()
        fg.Rows.Count = 1
        fg.Rows.Fixed = 1
        fg.Cols.Fixed = 1
        fg.Cols.Count = 7
        fg.Cols(0).Width = 0
        fg.Rows(0).Height = 30
        fg.Cols(1).Name = "COD."
        fg.Cols(2).Name = "FABRIC"
        fg.Cols(3).Name = "WEIGHT"
        fg.Cols(4).Name = "CONTENID"
        fg.Cols(5).Name = "FIBER"
        fg.Cols(6).Visible = False
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 220
            fg(0, index) = fg.Cols(index).Name
        Next
        fg.Cols(1).Width = 70
        fg.Cols(1).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(1).TextAlignFixed = TextAlignEnum.CenterCenter
    End Sub

    Private Sub llena_fg()
        Dim dr As DataRow
        Dim i As Integer
        strSQl = "SELECT * FROM MAESTRO_TELA ORDER BY ORDEN"
        llena_tablas(dt, strSQl, cnn)
        i = dt.Rows.Count
        fg.Rows.Count = i + 1
        i = 1
        For Each dr In dt.Rows
            fg(i, 1) = CStr(Format(i, "00"))
            fg(i, 2) = dr("FABRIC")
            fg(i, 3) = dr("WEIGHT")
            fg(i, 4) = dr("CONTENID")
            fg(i, 5) = dr("FIBER")
            i = i + 1
        Next
    End Sub

End Class



