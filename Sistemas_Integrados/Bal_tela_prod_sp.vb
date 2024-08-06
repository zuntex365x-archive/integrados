Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Bal_tela_prod_sp
    Inherits System.Windows.Forms.Form
    Dim dt As New DataTable()
    Dim inv As New DataTable()
    Dim fpos As New DataTable()
    Dim con As New DataTable()
    Dim wip As New DataTable()
    Dim fex As New DataTable
    Dim strsql As String
    Dim pd As Date
    Dim fec As Date
    Dim fei As Date
    Dim hoy As Date = Today
    Dim dis As Integer = hoy.DayOfWeek

    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim tsd As New DataTable()
    Dim obj As New empresas()
    Dim path As String = "c:\reportes\balance.xls"
    Dim a As Integer = Screen.PrimaryScreen.Bounds.Height - 30
    Friend WithEvents co As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents semana As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Dim l As Integer = Screen.PrimaryScreen.Bounds.Width - 5
    Dim f_ini As Date
    Friend WithEvents tipo As System.Windows.Forms.ComboBox
    Dim f_fin As Date
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents si As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Cliente As System.Windows.Forms.ComboBox
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents Impri As System.Windows.Forms.Button
    Friend WithEvents Ex As System.Windows.Forms.Button
    Friend WithEvents nc As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Te As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bal_tela_prod_sp))
        Me.Cliente = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.si = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.R1 = New System.Windows.Forms.Button()
        Me.Impri = New System.Windows.Forms.Button()
        Me.Ex = New System.Windows.Forms.Button()
        Me.Te = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.semana = New System.Windows.Forms.ComboBox()
        Me.tipo = New System.Windows.Forms.ComboBox()
        Me.nc = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.co = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Te, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.co, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cliente
        '
        Me.Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cliente.Location = New System.Drawing.Point(112, 8)
        Me.Cliente.MaxLength = 20
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(256, 28)
        Me.Cliente.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Cliente, "Lista de Clientes")
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 24)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Cliente:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'si
        '
        Me.si.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.si.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.si.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.si.ForeColor = System.Drawing.Color.Black
        Me.si.Image = CType(resources.GetObject("si.Image"), System.Drawing.Image)
        Me.si.Location = New System.Drawing.Point(668, 8)
        Me.si.Name = "si"
        Me.si.Size = New System.Drawing.Size(35, 35)
        Me.si.TabIndex = 53
        Me.si.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.si, "Presione este icono para buscar efectuar el Balance de Tela")
        Me.si.UseVisualStyleBackColor = False
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(668, 8)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(35, 35)
        Me.R1.TabIndex = 55
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R1.UseVisualStyleBackColor = False
        Me.R1.Visible = False
        '
        'Impri
        '
        Me.Impri.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Impri.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Impri.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Impri.ForeColor = System.Drawing.Color.Black
        Me.Impri.Image = CType(resources.GetObject("Impri.Image"), System.Drawing.Image)
        Me.Impri.Location = New System.Drawing.Point(716, 8)
        Me.Impri.Name = "Impri"
        Me.Impri.Size = New System.Drawing.Size(35, 35)
        Me.Impri.TabIndex = 58
        Me.Impri.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Impri, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Impri.UseVisualStyleBackColor = False
        Me.Impri.Visible = False
        '
        'Ex
        '
        Me.Ex.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Ex.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Ex.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ex.ForeColor = System.Drawing.Color.Black
        Me.Ex.Image = CType(resources.GetObject("Ex.Image"), System.Drawing.Image)
        Me.Ex.Location = New System.Drawing.Point(764, 8)
        Me.Ex.Name = "Ex"
        Me.Ex.Size = New System.Drawing.Size(35, 35)
        Me.Ex.TabIndex = 59
        Me.Ex.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Ex, "Presione este Boton si Desea  convertir a Excel los datos del  Inventario.")
        Me.Ex.UseVisualStyleBackColor = False
        Me.Ex.Visible = False
        '
        'Te
        '
        Me.Te.AllowEditing = False
        Me.Te.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Te.BackColor = System.Drawing.Color.White
        Me.Te.ColumnInfo = resources.GetString("Te.ColumnInfo")
        Me.Te.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Te.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.Te.ForeColor = System.Drawing.Color.Black
        Me.Te.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.Te.Location = New System.Drawing.Point(8, 230)
        Me.Te.Name = "Te"
        Me.Te.Rows.DefaultSize = 19
        Me.Te.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Te.Size = New System.Drawing.Size(1018, 450)
        Me.Te.StyleInfo = resources.GetString("Te.StyleInfo")
        Me.Te.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Te.TabIndex = 60
        Me.ToolTip1.SetToolTip(Me.Te, "Celdas en Rojo muestran Faltante en tela.")
        '
        'semana
        '
        Me.semana.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.semana.Location = New System.Drawing.Point(112, 42)
        Me.semana.MaxLength = 20
        Me.semana.Name = "semana"
        Me.semana.Size = New System.Drawing.Size(256, 28)
        Me.semana.TabIndex = 62
        Me.ToolTip1.SetToolTip(Me.semana, "Lista de Clientes")
        '
        'tipo
        '
        Me.tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipo.Items.AddRange(New Object() {"Datos Globales", "Datos por CPO - Estilo - Color"})
        Me.tipo.Location = New System.Drawing.Point(386, 7)
        Me.tipo.MaxLength = 20
        Me.tipo.Name = "tipo"
        Me.tipo.Size = New System.Drawing.Size(256, 28)
        Me.tipo.TabIndex = 64
        Me.ToolTip1.SetToolTip(Me.tipo, "Lista de Clientes")
        '
        'nc
        '
        Me.nc.AllowEditing = False
        Me.nc.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.nc.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.nc.BackColor = System.Drawing.Color.White
        Me.nc.ColumnInfo = resources.GetString("nc.ColumnInfo")
        Me.nc.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.nc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.nc.ForeColor = System.Drawing.Color.Black
        Me.nc.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.nc.Location = New System.Drawing.Point(8, 113)
        Me.nc.Name = "nc"
        Me.nc.Rows.Count = 1
        Me.nc.Rows.DefaultSize = 21
        Me.nc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.nc.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.nc.Size = New System.Drawing.Size(664, 543)
        Me.nc.StyleInfo = resources.GetString("nc.StyleInfo")
        Me.nc.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.nc.TabIndex = 56
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(16, 236)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 21
        Me.fg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(944, 180)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 23
        Me.fg.Visible = False
        '
        'co
        '
        Me.co.AllowEditing = False
        Me.co.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.co.BackColor = System.Drawing.Color.White
        Me.co.ColumnInfo = resources.GetString("co.ColumnInfo")
        Me.co.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.co.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.co.ForeColor = System.Drawing.Color.Black
        Me.co.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.co.Location = New System.Drawing.Point(8, 76)
        Me.co.Name = "co"
        Me.co.Rows.DefaultSize = 19
        Me.co.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.co.Size = New System.Drawing.Size(1253, 154)
        Me.co.StyleInfo = resources.GetString("co.StyleInfo")
        Me.co.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.co.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 24)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Semana:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Bal_tela_prod_sp
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1290, 692)
        Me.Controls.Add(Me.tipo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.semana)
        Me.Controls.Add(Me.co)
        Me.Controls.Add(Me.Te)
        Me.Controls.Add(Me.Ex)
        Me.Controls.Add(Me.Impri)
        Me.Controls.Add(Me.si)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.nc)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Bal_tela_prod_sp"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance Semanal de Tela según Fecha de Producción."
        CType(Me.Te, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.co, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub consulta_cortes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Cliente.KeyPress, AddressOf keypressed1
        fg.Width = Me.Width - 100
        fg.Height = Me.Height - 150
        Te.Width = l - 20
        Te.Height = a - 285
        semana.Items.Clear()
        setea_grids()
        llena_combos(Cliente, "SELECT DISTINCT CLIENTE FROM CPO_D LEFT JOIN CPO ON CPO.CPO = CPO_D.CPO WHERE ESTADO = 'A' ORDER BY CLIENTE", "CLIENTE")
        semana.Enabled = False
    End Sub

    Private Sub llena_todas_las_tablas()
        dt = New DataTable()
        fpos = New DataTable()
        inv = New DataTable()
        con = New DataTable()
        strsql = "SELECT CODIGO,COLOR,OFECHA,SUM((LIBRAS -RECIBIDAS)) AS PEDIDAS FROM FPO WHERE RECIBIDAS = 0  AND STATUS = 'ABIERTO' AND CLIENTE = '" & Cliente.Text & "' GROUP BY CODIGO,COLOR,OFECHA"
        llena_tablas(fpos, strsql, cnn)
        strsql = "SELECT CODIGO,COLOR ,SUM((ROLLOS.PESO/ROLLOS.YARDAS_I) * ROLLOS.YARDAS) AS LIBRAS FROM ROLLOS WHERE YARDAS > 0 AND CLIENTE = '" & Cliente.Text & "' AND ACTIVO IN ('S','0','5') GROUP BY CODIGO,COLOR"
        llena_tablas(inv, strsql, cnn)
        strsql = "SELECT * FROM CONSUMO_TELA WHERE CLIENTE = '" & Cliente.Text & "'"
        llena_tablas(con, strsql, cnn)
    End Sub

    Private Sub setea_grids()
        Dim i As Integer
        Dim pd As Date
        Dim su(0, 7, 6, 5, 4, 3, 2, 1) As Integer
        Te.Rows.Count = 1
        Te.Rows(0).Height = 30
        pd = hoy.AddDays(-dis)
        Te(0, 3) = UCase(Format(pd, "dd-MMM-yyyy"))
        fei = pd
        For i = 1 To 20
            pd = pd.AddDays(7)
            Te(0, i + 3) = UCase(Format(pd, "dd-MMM-yyyy"))
            semana.Items.Add(Format(pd, "yyyy-MM-dd"))
        Next
        Te(0, 24) = "> " & Te(0, 23)
        co.Rows.Count = 1
        co.Rows(0).Height = 30
        tipo.SelectedIndex = 0
        tipo.Enabled = False
    End Sub

    Private Sub llena_principal()
        Dim i As Integer
        Dim busca As String
        Dim l As Integer
        Dim dr As DataRow
        Dim fect As Date
        Dim nec As Decimal
        Dim co As Decimal
        Dim col As Integer
        Dim dias As Integer = 21
        Dim estilo As String
        Dim colores As String
        calcula_tela_codigo(Cliente.Text, dt)
        For Each dr In dt.Rows
            estilo = dr("ESTILO")
            colores = dr("COLOR")
            nec = dr("NECESARIO")
            fect = dr("F_NEC")
            busca = Trim(dr("CODIGO")) + Trim(dr("COLORT"))
            l = Te.FindRow(busca, 1, 0, False)
            If l = -1 Then
                l = Te.Rows.Count
                Te.Rows.Count = l + 1
                Te(l, 1) = dr("DESCRIPCION")
                Te(l, 2) = dr("COLORT")
                Te(l, 25) = dr("CODIGO")
                Te(l, 0) = busca
            End If
            determina_columna_tela(fei, fect, 3, 24, col)
            Te(l, col) = Te(l, col) - nec
        Next
        For i = 1 To Te.Rows.Count - 1
            inventarios(i, Te(i, 25), Te(i, 2), co)
        Next
        Te.Sort(SortFlags.Ascending, 2)
        For l = 1 To Te.Rows.Count - 1
            If Te(l, 3) < 0 Then
                Te.SetCellStyle(l, 3, Te.Styles("rojo"))
            End If
            For i = 4 To 24
                Te(l, i) = Te(l, i) + Te(l, i - 1)
                If Te(l, i) < 0 Then
                    Te.SetCellStyle(l, i, Te.Styles("rojo"))
                End If
            Next
        Next
    End Sub

    Private Sub inventarios(ByVal l As Integer, ByVal codigo As String, ByVal colores As String, ByRef inve As Decimal)
        Dim dr As DataRow
        Dim dd As DataRow()
        Dim c As Integer
        inve = 0
        dd = inv.Select("CODIGO = '" & codigo & "' AND COLOR = '" & colores & "'")
        For Each dr In dd
            inve = inve + dr("LIBRAS")
        Next
        Te(l, 3) = Te(l, 3) + inve
        ' ========================= PEDIDOS
        dd = fpos.Select("CODIGO = '" & codigo & "' AND COLOR  = '" & colores & "'")
        For Each dr In dd
            determina_columna_tela(fei, dr("OFECHA"), 3, 24, c)
            Te(l, c) = Te(l, c) + dr("PEDIDAS")
        Next
    End Sub

    Private Sub si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles si.Click
        Cursor = Cursors.WaitCursor
        si.Visible = False
        R1.Visible = True
        Impri.Visible = True
        Ex.Visible = True
        Cliente.Enabled = False
        revisa_consumo(ok)
        Te.Visible = True
        llena_todas_las_tablas()
        llena_principal()
        visibles(False)
        Cursor = Cursors.Default
        tipo.Enabled = True
        tipo.SelectedIndex = 0
        semana.Enabled = True
        semana.SelectedIndex = 1
        llena_semana()
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        si.Visible = True
        R1.Visible = False
        Impri.Visible = False
        Ex.Visible = False
        Cliente.Enabled = True
        semana.Enabled = False
        tipo.Enabled = False
        co.Rows.Count = 1
        Te.Rows.Count = 1
    End Sub

    Private Sub limpia_flex(ByRef si As Boolean)
        Te.Visible = si
    End Sub

    ' ===================================================================================
    '
    ' Revisa si todos los Estilos Colores tienen consumo
    '
    ' ===================================================================================
    Private Sub setea_nc()
        fg.Visible = False
        nc.Visible = True
        nc.Clear()
        nc.Rows.Count = 1
        nc.Cols.Count = 4
        nc.Cols(0).Width = 5
        nc.Rows(0).Height = 30
        Dim c As Column = nc.Cols(1)
        nc.Cols(1).Name = "ESTILO"
        nc.Cols(2).Name = "COLOR"
        nc.Cols(3).Name = "ESTADO"
        nc.Cols(1).Width = 200
        nc.Cols(2).Width = 300
        nc.Cols(3).Width = 450
    End Sub

    Private Sub revisa_consumo(ByRef ok As Boolean)
        Dim dt As New DataTable()
        ok = True
        Dim strSQL As String = "SELECT DISTINCT ESTILO,COLOR FROM CPO_D, CPO WHERE ESTADO = 'A' AND CLIENTE = '" & Cliente.Text & "' AND  CPO.CPO = CPO_D.CPO AND (ESTILO + COLOR NOT IN (SELECT DISTINCT ESTILO_CPO+COLOR_CPO FROM CONSUMO_TELA))"
        llena_tablas(dt, strSQL, cnn)
        lineas = dt.Rows.Count
        If lineas > 0 Then
            MsgBox("Existen Estilos - Colores sin Consumo,  Esto puede afectar en la veracidad de los Datos ", MsgBoxStyle.Critical, "Ingresar Consumos.")
        End If
    End Sub

    Private Sub Impri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Impri.Click
        Print_te()
    End Sub

    Private Sub Print_te()
        Dim pd As PrintDocument
        Dim fecha As String
        Dim mal As String = ""
        fecha = Format(Today, "dd/MM/yyy")
        pd = Te.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = False
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With
        Te.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        Te.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        Te.PrintGrid("Telas", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPrintDialog, Trim(Cliente.Text) + "    Balance de tela Al : " + fecha + "    " + mal + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Ex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ex.Click
        a_excel(Te, path, ok)
    End Sub

    Private Sub tela_sin_despachar()
        Dim strsql As String = "SELECT CORTE,ESTILO,COLOR,CPO,TOTAL,(SELECT SUM(YARDAS) FROM DMOVTO WHERE DMOVTO.CORTE = CORTES_S.CORTE AND TMOVTO = '4') AS DESPACHO  FROM CORTES_S WHERE ESTADO = 'A'  AND CLIENTE = '" & Cliente.Text & "' ORDER BY ESTILO,COLOR,CPO"
        llena_tablas(tsd, strsql, cnn)
    End Sub

    Private Sub ordena_te()
        Dim i As Integer
        For i = 1 To Te.Rows.Count - 1
            Te(i, 9) = Te(i, 1)
            Te(i, 1) = Te(i, 8)
        Next
    End Sub

    Private Sub Cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cliente.Leave
        If Cliente.Items.IndexOf(Cliente.Text) = -1 Then
            Cliente.Focus()
        End If
    End Sub

    Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cliente.KeyPress
        AutoCompletar(Cliente, e)
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Cliente.Text) <> "" Then
                si.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub Te_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Te.DoubleClick
        Dim linea As Integer = Te.RowSel
        Dim codigo As String = Te(linea, 25)
        Dim forma As New Bal_tela_prod_s1()
        Dim dd As DataRow()
        dd = dt.Select("CODIGO = '" & codigo & "' AND COLORT = '" & Te(linea, 2) & "'")
        forma.codigo = Te(linea, 25)
        forma.descripcion = Te(linea, 1)
        forma.colores = Te(linea, 2)
        forma.cliente = Cliente.Text
        forma.ss = dd
        forma.ShowDialog()
    End Sub

    Private Sub semana_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles semana.SelectedIndexChanged
        llena_semana()
    End Sub
    Private Sub llena_fex()
        Dim strsql As String = "SELECT CPO_D.CPO,ESTILO,COLOR,CPO_D.F_ENTREGA,(SELECT TOP 1 EXP_REV FROM WIP0 WHERE WIP0.CPO = CPO_D.CPO AND WIP0.ESTILO = CPO_D.ESTILO AND WIP0.COLOR = CPO_D.COLOR) AS EXP FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE ESTADO = 'A' AND CLIENTE = '" & Cliente.Text & "'"
        fex = New DataTable
        llena_tablas(fex, strsql, cnn)
    End Sub
    Private Sub busca_fex(ByVal cpo As String, ByVal estilo As String, ByVal color As String, ByRef fexp As Date)
        Dim dd As DataRow()
        Dim dr As DataRow
        dd = fex.Select("CPO = '" & cpo & "' AND  ESTILO = '" & estilo & "' AND COLOR = '" & color & "'")
        If dd.Length > 0 Then
            dr = dd(0)
            fexp = dr("F_ENTREGA")
            If IsDBNull(dr("EXP")) = False Then
                If dr("EXP") > CDate("1900-01-01") Then
                    fexp = dr("EXP")
                End If
            End If
        End If
    End Sub

    Private Sub llena_co()
        Dim dd As DataRow()
        Dim dj As DataRow
        Dim i As Integer = 1
        Dim dat As New DataTable
        Dim dr As DataRow
        visibles(False)
        llena_fex()
        Dim strsql As String = "select PLAN_COSTURA_T.*, DATEADD(DAY, -14, F_PROD) AS F_CORTE , DATEADD(DAY,-21,F_PROD) AS F_TELA , SECCION FROM PLAN_COSTURA_T WHERE SUBSTRING(CORTE,1,1) = 'P' AND SECCION <> 'SALDOS' AND DATEADD(DAY,-14,F_PROD) < = '" & Format(f_fin, "yyyy-MM-dd") & "' AND CLIENTE = '" & Cliente.Text & "' ORDER BY F_PROD"
        llena_tablas(dat, strsql, cnn)
        co.Rows.Count = dat.Rows.Count + 1
        For Each dr In dat.Rows
            dd = dt.Select("CPO = '" & dr("CPO") & "' AND ESTILO = '" & dr("ESTILO") & "' AND COLOR = '" & dr("COLOR") & "'")
            If dd.Length > 0 Then
                dj = dd(0)
                co(i, 1) = dj("F_COR")
                co(i, 2) = dj("F_NEC")
            End If
            co(i, 3) = dr("CPO")
            co(i, 4) = dr("ESTILO")
            co(i, 5) = dr("COLOR")
            co(i, 6) = dr("SECCION")
            co(i, 7) = dr("PRENDAS")
            busca_fex(dr("CPO"), dr("ESTILO"), dr("COLOR"), co(i, 8))
            i = i + 1
        Next
    End Sub
    Private Sub llena_global()
        Dim dd As DataRow()
        Dim dj As DataRow
        Dim i As Integer
        Dim busca As String
        For i = 1 To co.Rows.Count - 1
            dd = con.Select("ESTILO_CPO = '" & co(i, 4) & "' AND COLOR_CPO = '" & co(i, 5) & "'")
            If dd.Length > 0 Then
                For Each dj In dd
                    busca = Trim(dj("CODIGO")) + Trim(dj("COLOR_TELA"))
                    l = Te.FindRow(busca, 1, 0, False)
                    If l > 0 Then
                        Te.Rows(l).Visible = True
                    Else
                        l = 0
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub visibles(ByRef si As Boolean)
        Dim i As Integer
        For i = 1 To Te.Rows.Count - 1
            Te.Rows(i).Visible = si
        Next
    End Sub

    Private Sub llena_semana()
        Try
            f_fin = CDate(semana.Text)
            f_ini = f_fin.AddDays(-6)
            llena_co()
            If tipo.SelectedIndex = 0 Then
                llena_global()
            Else
                llena_selecto()
            End If
        Catch
        End Try
    End Sub
    Private Sub co_Click(sender As System.Object, e As System.EventArgs) Handles co.RowColChange
        If tipo.SelectedIndex > 0 Then
            llena_selecto()
        End If
    End Sub

    Private Sub llena_selecto()
        Dim dd As DataRow()
        Dim dj As DataRow
        Dim busca As String
        Dim f As Integer = co.RowSel
        visibles(False)
        Try
            dd = con.Select("ESTILO_CPO = '" & co(f, 4) & "' AND COLOR_CPO = '" & co(f, 5) & "'")
            If dd.Length > 0 Then
                For Each dj In dd
                    busca = Trim(dj("CODIGO")) + Trim(dj("COLOR_TELA"))
                    l = Te.FindRow(busca, 1, 0, False)
                    If l > 0 Then
                        Te.Rows(l).Visible = True
                    Else
                        l = 0
                    End If
                Next
            End If
        Catch
        End Try
    End Sub

    Private Sub tipo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles tipo.SelectedIndexChanged
        If tipo.SelectedIndex = 0 Then
            co.HighLight = HighLightEnum.Never
            llena_semana()
            Try
                semana.SelectedIndex = 1
            Catch
            End Try
        Else

            Try
                co.Row = 1
                co.RowSel = 1
                llena_selecto()
                co.Refresh()
                co.Focus()
            Catch
            End Try
            co.HighLight = HighLightEnum.Always
        End If
    End Sub
End Class
