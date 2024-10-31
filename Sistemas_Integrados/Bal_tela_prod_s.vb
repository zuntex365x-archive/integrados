Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Bal_tela_prod_s
    Inherits System.Windows.Forms.Form
    Dim dt As New DataTable()
    Dim inv As New DataTable()
    Dim fpos As New DataTable()
    Dim con As New DataTable()
    Dim wip As New DataTable()
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
    Friend WithEvents C1CheckBox1 As C1.Win.C1Input.C1CheckBox
    Dim l As Integer = Screen.PrimaryScreen.Bounds.Width - 5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bal_tela_prod_s))
        Me.Cliente = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.si = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.R1 = New System.Windows.Forms.Button()
        Me.Impri = New System.Windows.Forms.Button()
        Me.Ex = New System.Windows.Forms.Button()
        Me.Te = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.nc = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1CheckBox1 = New C1.Win.C1Input.C1CheckBox()
        CType(Me.Te, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label4.Location = New System.Drawing.Point(16, 16)
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
        Me.si.Location = New System.Drawing.Point(400, 8)
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
        Me.R1.Location = New System.Drawing.Point(400, 8)
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
        Me.Impri.Location = New System.Drawing.Point(448, 8)
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
        Me.Ex.Location = New System.Drawing.Point(496, 8)
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
        Me.Te.Location = New System.Drawing.Point(8, 48)
        Me.Te.Name = "Te"
        Me.Te.Rows.DefaultSize = 19
        Me.Te.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Te.Size = New System.Drawing.Size(978, 552)
        Me.Te.StyleInfo = resources.GetString("Te.StyleInfo")
        Me.Te.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Te.TabIndex = 60
        Me.ToolTip1.SetToolTip(Me.Te, "Celdas en Rojo muestran Faltante en tela.")
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
        Me.nc.Location = New System.Drawing.Point(8, 48)
        Me.nc.Name = "nc"
        Me.nc.Rows.Count = 1
        Me.nc.Rows.DefaultSize = 21
        Me.nc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.nc.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.nc.Size = New System.Drawing.Size(664, 608)
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
        Me.fg.Location = New System.Drawing.Point(16, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 21
        Me.fg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(944, 368)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 23
        Me.fg.Visible = False
        '
        'C1CheckBox1
        '
        Me.C1CheckBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1CheckBox1.Location = New System.Drawing.Point(553, 12)
        Me.C1CheckBox1.Name = "C1CheckBox1"
        Me.C1CheckBox1.Size = New System.Drawing.Size(104, 24)
        Me.C1CheckBox1.TabIndex = 62
        Me.C1CheckBox1.Text = "TODOS ?"
        Me.C1CheckBox1.UseVisualStyleBackColor = False
        Me.C1CheckBox1.Value = Nothing
        '
        'Bal_tela_prod_s
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 692)
        Me.Controls.Add(Me.C1CheckBox1)
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
        Me.Name = "Bal_tela_prod_s"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance Semanal de Tela según Fecha de Producción."
        CType(Me.Te, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub consulta_cortes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Cliente.KeyPress, AddressOf keypressed1
        fg.Width = Me.Width - 150
        fg.Height = Me.Height - 100
        nc.Width = l - 20
        nc.Height = a - 85
        Te.Width = l - 20
        Te.Height = a - 110
        setea_grids()
        llena_combos(Cliente, "SELECT DISTINCT CLIENTE FROM CPO_D LEFT JOIN CPO ON CPO.CPO = CPO_D.CPO WHERE ESTADO = 'A' ORDER BY CLIENTE", "CLIENTE")
    End Sub

    Private Sub llena_todas_las_tablas()
        dt = New DataTable()
        fpos = New DataTable()
        inv = New DataTable()
        con = New DataTable()

        ' Agrega una columna adicional para el nombre del cliente al final del grid Te
        If Not Te.Cols.Contains("CLIENTE") Then
            Te.Cols.Count += 1
            Te.Cols(Te.Cols.Count - 1).Name = "CLIENTE"
            Te.Cols(Te.Cols.Count - 1).Caption = "CLIENTE"
        End If

        ' Verifica si el checkbox "TODOS" está marcado
        If C1CheckBox1.Checked Then
            ' Si está marcado, selecciona todos los clientes
            strsql = "SELECT CODIGO, COLOR, OFECHA, SUM((LIBRAS - RECIBIDAS)) AS PEDIDAS " &
                 "FROM FPO WHERE RECIBIDAS = 0 AND STATUS = 'ABIERTO' GROUP BY CODIGO, COLOR, OFECHA"
        Else
            ' Si no está marcado, selecciona solo el cliente del ComboBox
            strsql = "SELECT CODIGO, COLOR, OFECHA, SUM((LIBRAS - RECIBIDAS)) AS PEDIDAS " &
                 "FROM FPO WHERE RECIBIDAS = 0 AND STATUS = 'ABIERTO' AND CLIENTE = '" & Cliente.Text & "' " &
                 "GROUP BY CODIGO, COLOR, OFECHA"
        End If

        ' Llena la tabla fpos
        llena_tablas(fpos, strsql, cnn)

        ' Llena la tabla de inventario (inv)
        strsql = "SELECT CODIGO, COLOR, SUM(LIBRAS) AS LIBRAS " &
             "FROM (SELECT CODIGO, COLOR, (ROLLOS.PESO / ROLLOS.YARDAS_I) * ROLLOS.YARDAS AS LIBRAS " &
             "FROM ROLLOS WHERE YARDAS > 0 " &
             "AND ACTIVO IN ('S', '0', '5') " &
             If(Not C1CheckBox1.Checked, "AND CLIENTE = '" & Cliente.Text & "' ", "") &
             "UNION " &
             "SELECT CODIGO, COLOR, (ROLLOS.PESO / ROLLOS.YARDAS_I) * ROLLOS.YARDAS * -1 AS LIBRAS " &
             "FROM ROLLOS INNER JOIN REQ_D ON ROLLOS.BATCH = REQ_D.BATCH AND ROLLOS.ROLLO = REQ_D.ROLLO " &
             "AND DESPACHADO = 'N' WHERE ACTIVO IN ('S', '0', '5') AND ROLLOS.YARDAS > 0 AND TIPO = 'TELA' " &
             If(Not C1CheckBox1.Checked, "AND CLIENTE = '" & Cliente.Text & "' ", "") &
             ") C GROUP BY CODIGO, COLOR"

        llena_tablas(inv, strsql, cnn)

        ' Comprueba si no hay datos para el cliente actual, si no los hay, agregar una fila de "No contiene resultados"
        If inv.Rows.Count = 0 Then
            ' Agrega una fila indicando que no hay resultados para el cliente
            Dim noDataRow As Integer = Te.Rows.Count
            Te.Rows.Count += 1
            Te(noDataRow, 1) = "No contiene resultados"
            Te(noDataRow, 2) = "-"
            Te(noDataRow, 3) = "-"
            Te(noDataRow, Te.Cols.Count - 1) = Cliente.Text ' Cliente que no tiene datos
        Else
            ' Procesa los datos normalmente
            ' ... Código existente para llenar los datos ...
            For Each dr As DataRow In inv.Rows
                Dim row As Integer = Te.Rows.Count
                Te.Rows.Count += 1
                Te(row, 1) = dr("CODIGO")
                Te(row, 2) = dr("COLOR")
                Te(row, 3) = dr("LIBRAS")
                ' Agrega el cliente en la columna adicional
                Te(row, Te.Cols.Count - 1) = Cliente.Text
            Next
        End If
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
        Next
        Te(0, 24) = "> " & Te(0, 23)
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
        '    jg.DataSource = dt
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
        Cursor = Cursors.Default
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        si.Visible = True
        R1.Visible = False
        Impri.Visible = False
        Ex.Visible = False
        Cliente.Enabled = True
        Te.Rows.Count = 1
    End Sub

    Private Sub limpia_flex()
        Te.Visible = True
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
        obj = New empresas()
        Dim seguro As MsgBoxResult
        nc.Visible = True
        Te.Visible = False
        ok = True
        Dim strSQL As String = "SELECT DISTINCT ESTILO,COLOR FROM CPO_D, CPO WHERE ESTADO = 'A' AND CLIENTE = '" & Cliente.Text & "' AND  CPO.CPO = CPO_D.CPO AND NOT EXISTS (SELECT 1  FROM CONSUMO_TELA WHERE ESTILO_CPO = CPO_D.ESTILO AND COLOR_CPO = CPO_D.COLOR)"
        llena_tablas(dt, strSQL, cnn)
        lineas = dt.Rows.Count
        If lineas > 0 Then
            ok = False
            setea_nc()
            nc.Rows.Count = lineas + 1
            lineas = 1
            For Each dr In dt.Rows
                nc(lineas, 1) = dr("ESTILO")
                nc(lineas, 2) = dr("COLOR")
                nc(lineas, 3) = "NO TIENE CONSUMO"
                lineas = lineas + 1
            Next
            seguro = MsgBox("Antes de efectuar este proceso por favor ingrese los consumos. Desea Imprimir?  ", MsgBoxStyle.YesNo, "Faltan consumos !!!")
            If seguro = MsgBoxResult.Yes Then
                nc.PrintGrid("S/consumo", PrintGridFlags.FitToPageWidth, "Empresa: " + Trim(obj.nombre) + " Cliente: " + Trim(Cliente.Text) + "  Estilos Sin Consumo al " & Today, "")
            End If
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

    'Private Sub ordena_te()
    '    Dim i As Integer
    '    For i = 1 To Te.Rows.Count - 1
    '        Te(i, 9) = Te(i, 1)
    '        Te(i, 1) = Te(i, 8)
    '    Next
    'End Sub

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

    Private Sub C1CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles C1CheckBox1.CheckedChanged
        If C1CheckBox1.Checked Then
            ' Deshabilitar la selección de cliente cuando se marcan todos los clientes
            Cliente.SelectedIndex = -1 ' Limpia la selección del ComboBox
            Cliente.Enabled = False
        Else
            ' Habilitar la selección de cliente cuando no están marcados todos
            Cliente.Enabled = True
        End If
    End Sub



End Class
