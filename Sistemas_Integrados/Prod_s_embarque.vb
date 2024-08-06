Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Prod_s_embarque
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
    Friend WithEvents cierre As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Dim path As String = "c:\reportes\Prod_s_Embarque.xls"

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
    Friend WithEvents Impri As System.Windows.Forms.Button
    Friend WithEvents Ex As System.Windows.Forms.Button
    Friend WithEvents nc As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Te As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prod_s_embarque))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Impri = New System.Windows.Forms.Button()
        Me.Ex = New System.Windows.Forms.Button()
        Me.Te = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.nc = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.cierre = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Te, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Impri
        '
        Me.Impri.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Impri.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Impri.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Impri.ForeColor = System.Drawing.Color.Black
        Me.Impri.Image = CType(resources.GetObject("Impri.Image"), System.Drawing.Image)
        Me.Impri.Location = New System.Drawing.Point(551, 8)
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
        Me.Ex.Location = New System.Drawing.Point(599, 8)
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
        Me.Te.Size = New System.Drawing.Size(1424, 552)
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
        'cierre
        '
        Me.cierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cierre.Location = New System.Drawing.Point(101, 17)
        Me.cierre.Name = "cierre"
        Me.cierre.Size = New System.Drawing.Size(176, 24)
        Me.cierre.TabIndex = 62
        Me.ToolTip1.SetToolTip(Me.cierre, "Elija el Cliente a Consultar .")
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 24)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Semana:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(500, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 63
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para Desplegar la Consulta.")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Prod_s_embarque
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 692)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cierre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Te)
        Me.Controls.Add(Me.Ex)
        Me.Controls.Add(Me.Impri)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.nc)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Prod_s_embarque"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Producción según Fecha de Embarque"
        CType(Me.Te, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub consulta_cortes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  AddHandler cierre.KeyPress, AddressOf keypressed1

    End Sub

    Private Sub llena_todas_las_tablas()
        'dt = New DataTable()
        'fpos = New DataTable()
        'inv = New DataTable()
        'con = New DataTable()
        'strsql = "SELECT CPO_D.CPO,CPO_D.ESTILO,CPO_D.COLOR,TOTAL,CPO_D.F_ENTREGA,(SELECT SUM(TOTAL) FROM CORTES WHERE CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR AND ESTADO = 'A') AS CORTADO, (SELECT SUM(TOTAL)FROM CORTES_S WHERE CORTES_S.CPO = CPO_D.CPO AND CORTES_S.ESTILO = CPO_D.ESTILO AND CORTES_S.COLOR = CPO_D.COLOR AND ESTADO = 'A') AS PROCESO,O2,O3 FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO  LEFT JOIN ESTILOS ON CPO_D.ESTILO = ESTILOS.ESTILO AND CPO.CLIENTE = ESTILOS.CLIENTE WHERE CPO.CLIENTE = '" & Cliente.Text & "' AND ESTADO = 'A' ORDER BY CPO_D.ESTILO ,CPO_D.COLOR"
        'llena_tablas(dt, strsql, cnn)
        'strsql = "SELECT CODIGO,COLOR,OFECHA,SUM((LIBRAS -RECIBIDAS)) AS PEDIDAS FROM FPO WHERE RECIBIDAS = 0  AND STATUS = 'ABIERTO' AND CLIENTE = '" & Cliente.Text & "' GROUP BY CODIGO,COLOR,OFECHA"
        'llena_tablas(fpos, strsql, cnn)
        'strsql = "SELECT CODIGO,COLOR ,SUM((ROLLOS.PESO/ROLLOS.YARDAS_I) * ROLLOS.YARDAS) AS LIBRAS FROM ROLLOS WHERE YARDAS > 0 AND CLIENTE = '" & Cliente.Text & "' AND ACTIVO IN ('S','0','5') GROUP BY CODIGO,COLOR"
        'llena_tablas(inv, strsql, cnn)
        'strsql = "SELECT CONSUMO_TELA.*,DESCRIPCION FROM CONSUMO_TELA LEFT JOIN CODIGO_TELA ON CODIGO_TELA.CODIGO = CONSUMO_TELA.CODIGO WHERE ESTILO_CPO + COLOR_CPO IN (SELECT DISTINCT ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A') AND CONSUMO_TELA.CLIENTE = '" & Cliente.Text & "'"
        'llena_tablas(con, strsql, cnn)
        'strsql = "SELECT * FROM WIP0 WHERE CPO+ESTILO+COLOR IN (SELECT DISTINCT CPO+ESTILO+COLOR FROM CPO_D WHERE ESTADO = 'A')"
        'llena_tablas(wip, strsql, cnn)
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
        For i = 1 To 12
            pd = pd.AddDays(7)
            Te(0, i + 3) = UCase(Format(pd, "dd-MMM-yyyy"))
        Next
        Te(0, 16) = "> " & Te(0, 15)
    End Sub

    Private Sub llena_principal()
        Dim i As Integer
        Dim busca As String
        Dim cortar As Integer
        Dim l As Integer
        Dim dr As DataRow
        Dim dw As DataRow
        Dim dd As DataRow()
        Dim fect As Date
        Dim pproc As Object
        Dim nec As Decimal
        Dim co As Decimal
        Dim col As Integer
        Dim dias As Integer = 28
        Dim proceso As Integer
        Dim total As Integer
        Dim cortado As Integer
        Dim estilo As String
        Dim colores As String
        Dim ww As DataRow()
        Dim wj As DataRow
        For Each dr In dt.Rows
            estilo = dr("ESTILO")
            COLORES = dr("COLOR")
            Try
                proceso = dr("PROCESO")
            Catch
                proceso = 0
            End Try
            Try
                total = dr("TOTAL")
            Catch
                total = 0
            End Try
            Try
                cortado = dr("CORTADO")
            Catch
                cortado = 0
            End Try
            If proceso > 0 Then
                Try
                    pproc = tsd.Compute("SUM(TOTAL)", "ESTILO = '" & dr("ESTILO") & "' AND COLOR = '" & dr("COLOR") & "' AND CPO = '" & dr("CPO") & "' AND DESPACHO IS NULL")
                    If pproc > 0 And proceso >= pproc Then
                        proceso = proceso - pproc
                    End If
                Catch
                End Try
            End If
            cortar = total - cortado - proceso
            If cortar > 0 Then
                dd = con.Select("ESTILO_CPO = '" & estilo & "' AND COLOR_CPO = '" & colores & "'")
                dias = 21
                'Try
                '    If dr("O2") = True Then
                '        dias = 21
                '    End If

                '    If (dr("O2") = False) And (dr("O3") = False) Then
                '        dias = 14
                '    End If
                'Catch
                'End Try
                For Each dw In dd
                    co = dw("LIBRAS")
                    nec = co * cortar
                    busca = Trim(dw("CODIGO")) + Trim(dw("COLOR_TELA"))
                    l = Te.FindRow(busca, 1, 0, False)
                    If l = -1 Then
                        l = Te.Rows.Count
                        Te.Rows.Count = l + 1
                        Te(l, 1) = dw("DESCRIPCION")
                        Te(l, 2) = dw("COLOR_TELA")
                        Te(l, 17) = dw("CODIGO")
                        Te(l, 0) = busca
                    End If
                    ww = wip.Select("CPO = '" & dr("CPO") & "' AND ESTILO = '" & estilo & "' AND COLOR = '" & colores & "'")
                    If ww.Length > 0 Then
                        wj = ww(0)
                        Try
                            fec = wj("SEW_PLAN")
                        Catch
                            fec = Today  '"01-01-1900"
                        End Try
                        fect = fec.AddDays(-dias)
                        If Year(fec) = "1900" Then
                            fec = fei
                            fect = fec
                        End If
                    End If
                    determina_columna_tela(fei, fect, 3, 16, col)
                    Te(l, col) = Te(l, col) - nec
                Next
            End If
        Next
        For i = 1 To Te.Rows.Count - 1
            inventarios(i, Te(i, 17), Te(i, 2), co)
        Next
        Te.Sort(SortFlags.Ascending, 2)
        For l = 1 To Te.Rows.Count - 1
            If Te(l, 3) < 0 Then
                Te.SetCellStyle(l, 3, Te.Styles("rojo"))
            End If
            For i = 4 To 16
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
            determina_columna_tela(fei, dr("OFECHA"), 3, 16, c)
            Te(l, c) = Te(l, c) + dr("PEDIDAS")
        Next

    End Sub

    'Private Sub si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Cursor = Cursors.WaitCursor
    '    si.Visible = False
    '    R1.Visible = True
    '    Impri.Visible = True
    '    Ex.Visible = True
    '    Cliente.Enabled = False
    '    revisa_consumo(ok)
    '    Te.Visible = True
    '    llena_todas_las_tablas()
    '    llena_principal()
    '    Cursor = Cursors.Default
    'End Sub

    'Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    si.Visible = True
    '    R1.Visible = False
    '    Impri.Visible = False
    '    Ex.Visible = False
    '    Cliente.Enabled = True
    '    Te.Rows.Count = 1
    'End Sub

    'Private Sub limpia_flex()
    '    Te.Visible = True
    'End Sub

    '' ===================================================================================
    ''
    '' Revisa si todos los Estilos Colores tienen consumo
    ''
    '' ===================================================================================
    'Private Sub setea_nc()
    '    fg.Visible = False
    '    nc.Visible = True
    '    nc.Clear()
    '    nc.Rows.Count = 1
    '    nc.Cols.Count = 4
    '    nc.Cols(0).Width = 5
    '    nc.Rows(0).Height = 30
    '    Dim c As Column = nc.Cols(1)
    '    nc.Cols(1).Name = "ESTILO"
    '    nc.Cols(2).Name = "COLOR"
    '    nc.Cols(3).Name = "ESTADO"
    '    nc.Cols(1).Width = 200
    '    nc.Cols(2).Width = 300
    '    nc.Cols(3).Width = 450
    'End Sub

    'Private Sub revisa_consumo(ByRef ok As Boolean)
    '    Dim dt As New DataTable()
    '    obj = New empresas()
    '    Dim seguro As MsgBoxResult
    '    nc.Visible = True
    '    Te.Visible = False
    '    ok = True
    '    Dim strSQL As String = "SELECT DISTINCT ESTILO,COLOR FROM CPO_D, CPO WHERE ESTADO = 'A' AND CLIENTE = '" & Cliente.Text & "' AND  CPO.CPO = CPO_D.CPO AND (ESTILO + COLOR NOT IN (SELECT DISTINCT ESTILO_CPO+COLOR_CPO FROM CONSUMO_TELA))"
    '    Dim dr As DataRow
    '    llena_tablas(dt, strSQL, cnn)
    '    lineas = dt.Rows.Count
    '    If lineas > 0 Then
    '        ok = False
    '        setea_nc()
    '        nc.Rows.Count = lineas + 1
    '        lineas = 1
    '        For Each dr In dt.Rows
    '            nc(lineas, 1) = dr("ESTILO")
    '            nc(lineas, 2) = dr("COLOR")
    '            nc(lineas, 3) = "NO TIENE CONSUMO"
    '            lineas = lineas + 1
    '        Next
    '        seguro = MsgBox("Antes de efectuar este proceso por favor ingrese los consumos. Desea Imprimir?  ", MsgBoxStyle.YesNo, "Faltan consumos !!!")
    '        If seguro = MsgBoxResult.Yes Then
    '            nc.PrintGrid("S/consumo", PrintGridFlags.FitToPageWidth, "Empresa: " + Trim(obj.nombre) + " Cliente: " + Trim(Cliente.Text) + "  Estilos Sin Consumo al " & Today, "")
    '        End If
    '    End If
    'End Sub

    'Private Sub Impri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Impri.Click
    '    Print_te()
    'End Sub

    'Private Sub Print_te()
    '    Dim pd As PrintDocument
    '    Dim fecha As String
    '    Dim mal As String = ""
    '    fecha = Format(Today, "dd/MM/yyy")
    '    pd = Te.PrintParameters.PrintDocument()
    '    With pd.DefaultPageSettings
    '        .Landscape = False
    '        .Margins.Left = 20
    '        .Margins.Right = 50
    '        .Margins.Top = 50
    '        .Margins.Bottom = 50
    '    End With
    '    Te.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
    '    Te.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
    '    Te.PrintGrid("Telas", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPrintDialog, Trim(Cliente.Text) + "    Balance de tela Al : " + fecha + "    " + MAL + Chr(9) + Chr(9) + "Pagina {0}", "")
    'End Sub

    'Private Sub Ex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ex.Click
    '    a_excel(Te, path, ok)
    'End Sub

    'Private Sub tela_sin_despachar()
    '    Dim strsql As String = "SELECT CORTE,ESTILO,COLOR,CPO,TOTAL,(SELECT SUM(YARDAS) FROM DMOVTO WHERE DMOVTO.CORTE = CORTES_S.CORTE AND TMOVTO = '4') AS DESPACHO  FROM CORTES_S WHERE ESTADO = 'A'  AND CLIENTE = '" & Cliente.Text & "' ORDER BY ESTILO,COLOR,CPO"
    '    llena_tablas(tsd, strsql, cnn)
    'End Sub

    'Private Sub ordena_te()
    '    Dim i As Integer
    '    For i = 1 To Te.Rows.Count - 1
    '        Te(i, 9) = Te(i, 1)
    '        Te(i, 1) = Te(i, 8)
    '    Next
    'End Sub

    'Private Sub Cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Cliente.Items.IndexOf(Cliente.Text) = -1 Then
    '        Cliente.Focus()
    '    End If
    'End Sub

    'Private Sub cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    AutoCompletar(Cliente, e)
    'End Sub

    'Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
    '    If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
    '        e.Handled = True
    '        If Trim(Cliente.Text) <> "" Then
    '            si.Focus()
    '        End If
    '    End If
    'End Sub 'keypressed

    'Private Sub Te_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Te.DoubleClick
    '    Dim linea As Integer = Te.RowSel
    '    Dim codigo As String = Te(linea, 9)
    '    Dim forma As New Bal_tela_prod_s1()
    '    forma.codigo = Te(linea, 17)
    '    forma.descripcion = Te(linea, 1)
    '    forma.colores = Te(linea, 2)
    '    forma.cliente = Cliente.Text
    '    forma.ShowDialog()
    'End Sub
End Class
