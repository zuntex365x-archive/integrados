Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Bal_tela_prod_dd1
    Inherits System.Windows.Forms.Form
    Public codigo As String
    Public descripcion As String
    Public colores As String
    Public necesario As Decimal
    Public inventar As Decimal
    Public pedido As Decimal
    Public balance As Decimal
    Public cliente As String
    Public ss As DataRow()
    Public WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Dim h As String = "#######"
    Dim ok As Boolean
    Dim si As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim estados As New ComboBox()
    Public tsd As New DataTable()
    Dim hoy As Date = Today
    Dim dis As Integer = hoy.DayOfWeek
    Dim pd As Date
    Dim fei As Date
    Dim con As DataTable
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents colors As System.Windows.Forms.Label
    Friend WithEvents desc_tela As System.Windows.Forms.Label
    Friend WithEvents Codi As System.Windows.Forms.Label
    Friend WithEvents ct As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fo As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bal_tela_prod_dd1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.desc_tela = New System.Windows.Forms.Label()
        Me.colors = New System.Windows.Forms.Label()
        Me.Codi = New System.Windows.Forms.Label()
        Me.ct = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.fo = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.ct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'desc_tela
        '
        Me.desc_tela.BackColor = System.Drawing.Color.White
        Me.desc_tela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.desc_tela.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desc_tela.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.colors.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.Codi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Codi.Location = New System.Drawing.Point(72, 8)
        Me.Codi.Name = "Codi"
        Me.Codi.Size = New System.Drawing.Size(96, 24)
        Me.Codi.TabIndex = 72
        Me.Codi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ct
        '
        Me.ct.AllowEditing = False
        Me.ct.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.ct.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.ct.ColumnInfo = resources.GetString("ct.ColumnInfo")
        Me.ct.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ct.ForeColor = System.Drawing.Color.Black
        Me.ct.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.ct.Location = New System.Drawing.Point(8, 72)
        Me.ct.Name = "ct"
        Me.ct.Rows.DefaultSize = 19
        Me.ct.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.ct.Size = New System.Drawing.Size(1150, 376)
        Me.ct.StyleInfo = resources.GetString("ct.StyleInfo")
        Me.ct.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.ct.TabIndex = 74
        '
        'fo
        '
        Me.fo.AllowEditing = False
        Me.fo.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fo.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.fo.ColumnInfo = resources.GetString("fo.ColumnInfo")
        Me.fo.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fo.ForeColor = System.Drawing.Color.Black
        Me.fo.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fo.Location = New System.Drawing.Point(8, 456)
        Me.fo.Name = "fo"
        Me.fo.Rows.DefaultSize = 19
        Me.fo.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fo.Size = New System.Drawing.Size(603, 328)
        Me.fo.StyleInfo = resources.GetString("fo.StyleInfo")
        Me.fo.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fo.TabIndex = 75
        '
        'Bal_tela_prod_dd1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1186, 792)
        Me.Controls.Add(Me.fo)
        Me.Controls.Add(Me.ct)
        Me.Controls.Add(Me.Codi)
        Me.Controls.Add(Me.colors)
        Me.Controls.Add(Me.desc_tela)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Bal_tela_prod_dd1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Prendas x Cortar Y Tela por Recibir"
        CType(Me.ct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Overloads Sub Bal_tela_Det(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Codi.Text = codigo
        desc_tela.Text = descripcion
        colors.Text = colores
        setea_grids()
        llena_pe()
        llena_fo()
        ct.Sort(SortFlags.Ascending, 7)
        'Cursor = Cursors.Default
    End Sub

    Private Sub setea_grids()
        ct.Rows.Count = 1
        fo.Rows.Count = 1
        ct.Rows(0).Height = 30
        fo.Rows(0).Height = 30
        llena_tablas(con, "SELECT * FROM CONSUMO_TELA LEFT JOIN ESTILOS ON ESTILOS.ESTILO = CONSUMO_TELA.ESTILO_CPO WHERE CODIGO = '" & codigo & "' AND COLOR_TELA = '" & colores & "'", cnn)
    End Sub

    Private Sub llena_pe()
        Dim l As Integer = 1
        Dim dd As DataRow() = ss
        Dim dr As DataRow
        dd = ss
        ct.Rows.Count = dd.Length + 1
        For Each dr In dd
            ct(l, 1) = dr("CPO")
            ct(l, 2) = dr("ESTILO")
            ct(l, 3) = dr("COLOR")
            ct(l, 4) = dr("PRENDAS")
            ct(l, 5) = dr("NECESARIO")
            ct(l, 6) = dr("F_PROD")
            ct(l, 7) = dr("F_COR")
            ct(l, 8) = dr("F_NEC")
            l = l + 1
        Next
    End Sub

    Private Sub determina_columna(ByVal fecha As Date, ByRef col As Integer)
        Dim si As Integer
        Dim res As Integer
        si = DateDiff(DateInterval.Day, fei, fecha)
        res = si Mod 7
        col = Fix(si / 7) + 2
        If res > 0 Then
            col = col + 1
        End If
        If col > 15 Then
            col = 15
        End If
        If col < 2 Then
            col = 2
        End If
    End Sub


    '=============================================== TELA PEDIDA   ================================================
    Private Sub llena_fo()
        Dim dt As New DataTable()
        Dim strSQL As String = "SELECT FPO,LOTE,CLIENTE,OFECHA,LIBRAS FROM FPO WHERE CODIGO = '" & codigo & "' AND COLOR = '" & colores & "' AND TIPO = 'TELA' AND STATUS = 'ABIERTO' AND CLIENTE = '" & cliente & "' AND RECIBIDAS = 0 "
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn)
        lineas = dt.Rows.Count
        fo.Rows.Count = lineas + 1
        lineas = 1
        For Each dr In dt.Rows
            fo(lineas, 1) = dr("FPO")
            fo(lineas, 2) = dr("LOTE")
            fo(lineas, 3) = dr("LIBRAS")
            fo(lineas, 4) = dr("OFECHA")
            lineas = lineas + 1
        Next
    End Sub

End Class



