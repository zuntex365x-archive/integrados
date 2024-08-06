Imports C1.Win.C1FlexGrid

Public Class Tela_pedida
    Inherits System.Windows.Forms.Form

    Dim cnn1 As SqlClient.SqlConnection
    Dim lineas As Integer
    Public dentro As String
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Tela_pedida))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cpo = New System.Windows.Forms.Label()
        Me.Estilo = New System.Windows.Forms.Label()
        Me.Colo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.fg.Location = New System.Drawing.Point(8, 96)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(880, 496)
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
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Estilo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "CPO:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(480, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Color:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cpo
        '
        Me.Cpo.BackColor = System.Drawing.Color.White
        Me.Cpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Cpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cpo.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Cpo.Location = New System.Drawing.Point(112, 16)
        Me.Cpo.Name = "Cpo"
        Me.Cpo.Size = New System.Drawing.Size(160, 20)
        Me.Cpo.TabIndex = 71
        Me.Cpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Estilo
        '
        Me.Estilo.BackColor = System.Drawing.Color.White
        Me.Estilo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Estilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Estilo.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Estilo.Location = New System.Drawing.Point(112, 48)
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
        Me.Colo.Location = New System.Drawing.Point(536, 48)
        Me.Colo.Name = "Colo"
        Me.Colo.Size = New System.Drawing.Size(296, 20)
        Me.Colo.TabIndex = 73
        Me.Colo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Cpo, Me.Label2, Me.Label1, Me.Estilo, Me.Label3, Me.Colo})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(888, 80)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        '
        'Tela_pedida
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(902, 612)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.fg})
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tela_pedida"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Tela Pedida  CPO - Estilo - Color"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Bal_Tela_Det1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        def_sql(cnn1)
        setea_fg()
        llena_pedidas()
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
        fg.Cols(1).Name = "FPO"
        fg.Cols(2).Name = "KNIT"
        fg.Cols(3).Name = "COLOR"
        fg.Cols(4).Name = "LOTE"
        fg.Cols(5).Name = "CPO"
        fg.Cols(6).Name = "ANCHO"
        fg.Cols(7).Name = "F.ENTREGA"
        fg.Cols(8).Name = "LIBRAS"
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 90
            fg(0, index) = fg.Cols(index).Name
            If index > 7 Then
                fg.Cols(index).DataType = GetType(Integer)
                fg.Cols(index).Format = "######0"
                fg.Cols(index).Width = 70
                fg.Cols(index).TextAlign = TextAlignEnum.RightCenter
                fg.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
        fg.Cols(2).Width = 160
        fg.Cols(3).Width = 160
    End Sub

    Private Sub llena_pedidas()
        Dim strSQL As String = "SELECT * FROM FPO WHERE CPO = '" & Cpo.Text & "' AND COLOR IN " & dentro & " AND RECIBIDAS = 0 AND STATUS = 'ABIERTO'"
        Dim dt As New DataTable()
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn1)
        fg.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("FPO")
            fg(lineas, 2) = dr("KNIT")
            fg(lineas, 3) = dr("COLOR")
            fg(lineas, 4) = dr("LOTE")
            fg(lineas, 5) = dr("CPO")
            fg(lineas, 6) = dr("ANCHO")
            fg(lineas, 7) = dr("RFECHA")
            fg(lineas, 8) = dr("LIBRAS")
            lineas = lineas + 1
        Next
    End Sub

    Private Sub subtotales()
        fg.Subtotal(AggregateEnum.Sum, -1, -1, 8, "Gran Total")
    End Sub
End Class
