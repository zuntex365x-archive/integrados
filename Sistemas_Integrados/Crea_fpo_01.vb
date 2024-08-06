Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Crea_fpo_01
    Inherits System.Windows.Forms.Form
    Dim dt As New DataTable()
    Dim inv As New DataTable()
    Dim fpos As New DataTable()
    Dim fp As New DataTable()
    Dim fc As New DataTable()
    Dim res As New DataTable()
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
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
    Friend WithEvents nc As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Te As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Crea_fpo_01))
        Me.Cliente = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.si = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.R1 = New System.Windows.Forms.Button()
        Me.Te = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.nc = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.Te, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.R1.Location = New System.Drawing.Point(441, 8)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(35, 35)
        Me.R1.TabIndex = 55
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R1.UseVisualStyleBackColor = False
        Me.R1.Visible = False
        '
        'Te
        '
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(400, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "C"
        Me.Button1.UseVisualStyleBackColor = False
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
        'Crea_fpo_01
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 692)
        Me.Controls.Add(Me.Te)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.nc)
        Me.Controls.Add(Me.si)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Crea_fpo_01"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Creación Fpo Texpasa"
        CType(Me.Te, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub consulta_cortes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Cliente.KeyPress, AddressOf keypressed1
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
        fc = New DataTable()
        res = New DataTable()
        strsql = "SELECT CODIGO,COLOR,OFECHA,SUM((LIBRAS -RECIBIDAS)) AS PEDIDAS FROM FPO WHERE RECIBIDAS = 0  AND STATUS = 'ABIERTO' AND CLIENTE = '" & Cliente.Text & "' GROUP BY CODIGO,COLOR,OFECHA"
        llena_tablas(fpos, strsql, cnn)
        strsql = "SELECT CODIGO,COLOR ,SUM((ROLLOS.PESO/ROLLOS.YARDAS_I) * ROLLOS.YARDAS) AS LIBRAS FROM ROLLOS WHERE YARDAS > 0 AND CLIENTE = '" & Cliente.Text & "' AND ACTIVO IN ('S','0','5') GROUP BY CODIGO,COLOR"
        llena_tablas(inv, strsql, cnn)
        strsql = "SELECT CPO_D.CPO,F_INGRESO FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE CLIENTE = '" & Cliente.Text & "' AND ESTADO = 'A'"
        llena_tablas(fc, strsql, cnn)
        strsql = "SELECT REQ_D.CORTE,CODIGO,ROLLOS.COLOR,SUM(REQ_D.PESO)AS LIBRAS FROM REQ_D LEFT JOIN CORTES_S ON REQ_D.CORTE = CORTES_S.CORTE LEFT JOIN ROLLOS ON REQ_D.BATCH = ROLLOS.BATCH AND REQ_D.ROLLO = ROLLOS.ROLLO WHERE DESPACHADO = 'N' AND CORTES_S.CLIENTE = '" & Cliente.Text & "' GROUP BY REQ_D.CORTE,CODIGO,ROLLOS.COLOR"
        llena_tablas(res, strsql, cnn)
    End Sub

    Private Sub setea_grids()
        Te.Rows.Count = 1
        Te.Rows(0).Height = 30
    End Sub

    Private Sub llena_principal()
        Dim cpo As String
        Dim l As Integer
        Dim dr As DataRow
        Dim codigo As String
        Dim colort As String
        Dim nec As Decimal
        Dim dias As Integer = 21
        Dim estilo As String
        Dim colores As String
        Dim ca As Decimal
        calcula_tela_codigo(Cliente.Text, dt)
        Te.Rows.Count = dt.Rows.Count + 1
        l = 1
        For Each dr In dt.Rows
            codigo = dr("CODIGO")
            colort = dr("COLORT")
            estilo = dr("ESTILO")
            colores = dr("COLOR")
            nec = dr("NECESARIO")
            cpo = dr("CPO")
            fecha_ingreso(l, cpo, Te(l, 1))
            Te(l, 2) = cpo
            Te(l, 3) = dr("DESCRIPCION")
            Te(l, 5) = dr("COLORT")
            Te(l, 6) = nec
            If colort = "CORNFLOWER BLUE" Then
                Dim JJ As String
                JJ = "JJ"
            End If
            inventarios(codigo, colort, ca)
            Te(l, 7) = ca
            consumos_otros(codigo, colort, ca)
            Te(l, 7) = Te(l, 7) - ca
            Te(l, 8) = False
            Te(l, 9) = codigo
            l = l + 1
        Next
        Te.Sort(SortFlags.Descending, 1)
    End Sub

    Private Sub inventarios(ByVal codigo As String, ByVal colores As String, ByRef ca As Decimal)
        Dim dr As DataRow
        Dim dd As DataRow()
        ca = 0
        dd = inv.Select("CODIGO = '" & codigo & "' AND COLOR = '" & colores & "'")
        For Each dr In dd
            ca = ca + dr("LIBRAS")
        Next
        ' ========================= PEDIDOS
        dd = fpos.Select("CODIGO = '" & codigo & "' AND COLOR  = '" & colores & "'")
        For Each dr In dd
            ca = ca + dr("PEDIDAS")
        Next
    End Sub
    Private Sub consumos_otros(ByVal codigo As String, ByVal colores As String, ByRef con As Decimal)
        Dim dr As DataRow
        Dim dd As DataRow()
        con = 0
        dd = res.Select("CODIGO = '" & codigo & "' AND COLOR = '" & colores & "'")
        For Each dr In dd
            con = con + dr("LIBRAS")
        Next
        dd = dt.Select("CODIGO = '" & codigo & "' AND COLORT= '" & colores & "'")
        For Each dr In dd
            con = con + dr("NECESARIO")
        Next
    End Sub

    Private Sub fecha_ingreso(ByVal l As Integer, ByVal cpo As String, ByRef fecha As Date)
        Dim dr As DataRow
        Dim dd As DataRow()
        dd = fc.Select("CPO = '" & cpo & "'")
        If dd.Length > 0 Then
            dr = dd(0)
            fecha = dr("F_INGRESO")
        End If
    End Sub

    Private Sub si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles si.Click
        Cursor = Cursors.WaitCursor
        si.Visible = False
        R1.Visible = True
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
        Dim strSQL As String = "SELECT DISTINCT ESTILO,COLOR FROM CPO_D, CPO WHERE ESTADO = 'A' AND CLIENTE = '" & Cliente.Text & "' AND  CPO.CPO = CPO_D.CPO AND (ESTILO + COLOR NOT IN (SELECT DISTINCT ESTILO_CPO+COLOR_CPO FROM CONSUMO_TELA))"
        Dim dr As DataRow
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

    Private Sub Impri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        Te.PrintGrid("Telas", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPrintDialog, Trim(Cliente.Text) + "    Balance de tela Al : " + fecha + "    " + MAL + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Ex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        a_excel(Te, path, ok)
    End Sub

    Private Sub tela_sin_despachar()
        Dim strsql As String = "SELECT CORTE,ESTILO,COLOR,CPO,TOTAL,(SELECT SUM(YARDAS) FROM DMOVTO WHERE DMOVTO.CORTE = CORTES_S.CORTE AND TMOVTO = '4') AS DESPACHO  FROM CORTES_S WHERE ESTADO = 'A'  AND CLIENTE = '" & Cliente.Text & "' ORDER BY ESTILO,COLOR,CPO"
        llena_tablas(tsd, strsql, cnn)
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
        'Dim linea As Integer = Te.RowSel
        'Dim codigo As String = Te(linea, 25)
        'Dim forma As New Bal_tela_prod_s1()
        'Dim dd As DataRow()
        'dd = dt.Select("CODIGO = '" & codigo & "' AND COLORT = '" & Te(linea, 2) & "'")
        'forma.codigo = Te(linea, 25)
        'forma.descripcion = Te(linea, 1)
        'forma.colores = Te(linea, 2)
        'forma.cliente = Cliente.Text
        'forma.ss = dd
        'forma.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        procesa()
    End Sub

    Private Sub procesa()
        Dim ok As Boolean
        revisa_detalle(ok)
        If ok Then
            detalle()
        End If
    End Sub
    Private Sub detalle()
        Dim forma As New Crea_fpo_02
        forma.Size = New Size(l, a)
        llena_consumos()
        forma.fp = fp
        forma.ShowDialog()
    End Sub

    Private Sub revisa_detalle(ByRef ok As Boolean)
        Dim i As Integer
        Dim colores As String = ""
        ok = True
        For i = 1 To Te.Rows.Count - 1
            If Te(i, 8) = ok Then
                If colores = "" Then
                    colores = Te(i, 4)
                Else
                    If colores <> Te(i, 4) Then
                        MsgBox("Debe escoger solamente un Color", MsgBoxStyle.Critical, "Por favor revise !!!")
                        ok = False
                        Exit Sub
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub llena_consumos()
        Dim i As Integer
        fp = New DataTable
        fp.Columns.Add("CODIGO", GetType(String))
        fp.Columns.Add("COLOR", GetType(String))
        fp.Columns.Add("CPO", GetType(String))
        fp.Columns.Add("DESCRIPCION", GetType(String))
        fp.Columns.Add("CONSUMO", GetType(Decimal))

        For i = 1 To Te.Rows.Count - 1
            If Te(i, 8) Then

                fp.Rows.Add(Te(i, 9), Te(i, 5), Te(i, 2), Te(i, 3), Te(i, 6))
            End If
        Next
    End Sub
End Class
