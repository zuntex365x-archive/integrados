Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Balance_Tela_c
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim tsd As New DataTable()
    Dim path As String = "c:\reportes\balance.xls"
    Dim obj As empresas
    Dim a As Integer = Screen.PrimaryScreen.Bounds.Height - 30
    Friend WithEvents C1XLBook1 As C1.C1Excel.C1XLBook
    Dim l As Integer = Screen.PrimaryScreen.Bounds.Width - 5
    Dim dm As New DataTable
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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents si As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Cliente As System.Windows.Forms.ComboBox
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents nc As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Te As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Impri As System.Windows.Forms.Button
    Friend WithEvents Ex As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Balance_Tela_c))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Cliente = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.si = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.R1 = New System.Windows.Forms.Button()
        Me.Impri = New System.Windows.Forms.Button()
        Me.Te = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Ex = New System.Windows.Forms.Button()
        Me.nc = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1XLBook1 = New C1.C1Excel.C1XLBook()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Te, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Te
        '
        Me.Te.AllowEditing = False
        Me.Te.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.Te.BackColor = System.Drawing.Color.White
        Me.Te.ColumnInfo = resources.GetString("Te.ColumnInfo")
        Me.Te.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Te.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.Te.ForeColor = System.Drawing.Color.Black
        Me.Te.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.Te.Location = New System.Drawing.Point(8, 48)
        Me.Te.Name = "Te"
        Me.Te.Rows.Count = 1
        Me.Te.Rows.DefaultSize = 20
        Me.Te.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Te.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Te.Size = New System.Drawing.Size(984, 632)
        Me.Te.StyleInfo = resources.GetString("Te.StyleInfo")
        Me.Te.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Te.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.Te, "Presione Double Click sobre un Knit_Color para ver su Detalle")
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
        'Balance_Tela_c
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 692)
        Me.Controls.Add(Me.Ex)
        Me.Controls.Add(Me.Impri)
        Me.Controls.Add(Me.si)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.Te)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.nc)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Balance_Tela_c"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance de Tela por Cliente Codificada"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Te, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub consulta_cortes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Cliente.KeyPress, AddressOf keypressed1
        nc.Width = l - 20
        nc.Height = a - 85
        fg.Width = Te.Width
        setea_grid()
        llena_combos(Cliente, "SELECT DISTINCT CLIENTE FROM CPO_D LEFT JOIN CPO ON CPO.CPO = CPO_D.CPO WHERE ESTADO = 'A' ORDER BY CLIENTE", "CLIENTE")
    End Sub

    Private Sub setea_grid()
        Dim index As Integer
        fg.Clear()
        fg.Styles.Normal.Border.Style = BorderStyleEnum.Inset
        fg.Rows.Count = 1
        fg.Cols.Count = 8
        fg.Cols(0).Width = 5
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Name = "ESTILO"
        fg.Cols(2).Name = "COLOR"
        fg.Cols(3).Name = "CPO"
        fg.Cols(4).Name = "PEDIDAS"
        fg.Cols(5).Name = "CORTADAS"
        fg.Cols(6).Name = "X CORTAR"
        fg.Cols(7).Name = "PROCESO"
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 160
            fg(0, index) = fg.Cols(index).Name
            If index > 3 Then
                fg.Cols(index).TextAlign = TextAlignEnum.RightCenter
                fg.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
                fg.Cols(index).DataType = GetType(Decimal)
                fg.Cols(index).Format = "#####0"
                fg.Cols(index).Width = 110
            End If
        Next
        fg.Cols(2).Width = 300
    End Sub

    Private Sub llena_grid()
        Dim strSQL As String = "SELECT ESTILO, COLOR ,CPO_D.CPO ,SUM(TOTAL) AS TOTAL FROM CPO_D , CPO WHERE ESTADO = 'A' AND CPO.CPO = CPO_D.CPO AND CLIENTE = '" & Cliente.Text & "' GROUP BY ESTILO,COLOR,CPO_D.CPO"
        Dim dt As New DataTable()
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn)
        lineas = dt.Rows.Count
        fg.Rows.Count = lineas + 1
        lineas = 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("ESTILO")
            fg(lineas, 2) = dr("COLOR")
            fg(lineas, 3) = dr("CPO")
            fg(lineas, 4) = dr("TOTAL")
            fg(lineas, 0) = Trim(fg(lineas, 1)) + Trim(fg(lineas, 2)) + Trim(fg(lineas, 3))
            lineas = lineas + 1
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
        If Not ok Then
            limpia_flex()
            crea_fg()
            tela_sin_despachar()
            busca_Cortado()
            llena_knit_color()
            nc.Visible = True
            setea_te()
            llena_Te()
            ordena_te()
            Te.Sort(SortFlags.Ascending, 2)
        End If
        Cursor = Cursors.Default
    End Sub
    Private Sub llena_dm()
        llena_tablas(dm, "SELECT * FROM DM WHERE CLIENTE = '" & Cliente.Text & "'", cnn)
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        si.Visible = True
        R1.Visible = False
        Impri.Visible = False
        Ex.Visible = False
        Cliente.Enabled = True
        setea_te()
    End Sub

    Private Sub limpia_flex()
        Te.Visible = True
    End Sub

    Private Sub llena_knit_color()
        Dim i As Integer
        Dim f As Integer
        Dim l As Integer
        Dim est_col As String
        consumo_tela()
        For i = 1 To fg.Rows.Count - 1
            est_col = Trim(fg(i, 1)) + Trim(fg(i, 2))
            f = nc.FindRow(est_col, 1, 0, True)
            If f <> -1 Then
                For l = f To nc.Rows.Count - 1
                    If Trim(nc(l, 0)) = est_col Then
                        nc(l, 6) = nc(l, 6) + fg(i, 6)
                    Else
                        Exit For
                    End If
                Next l
            End If
        Next
        For i = 1 To nc.Rows.Count - 1
            Try
                nc(i, 7) = nc(i, 5) * nc(i, 6)
            Catch
            End Try
        Next
        nc.Sort(SortFlags.Ascending, 3, 4)
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

    Private Sub revisa_consumo(ByVal ok As Boolean)
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
                nc.PrintGrid("S/consumo", PrintGridFlags.FitToPageWidth, "Empresa: " + Trim(obj.nombre) + "     Cliente: " + Trim(Cliente.Text) + "  Estilos Sin Consumo al " & Today, "")
            End If
        End If
    End Sub


    ' ===================================================================================
    '
    '  Nc =  todas las telas del Cliente
    '
    ' ===================================================================================
    Private Sub consumo_tela()
        Dim dt As New DataTable()
        nc.Clear()
        nc.Rows.Count = 1
        nc.Cols.Count = 10
        Dim strSQL As String = "SELECT * FROM CONSUMO_TELA JOIN CODIGO_TELA ON CONSUMO_TELA.CODIGO = CODIGO_TELA.CODIGO WHERE CLIENTE = '" & Cliente.Text & "'"
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn)
        lineas = dt.Rows.Count
        nc.Rows.Count = lineas + 1
        lineas = 1
        For Each dr In dt.Rows
            nc(lineas, 1) = dr("ESTILO_CPO")
            nc(lineas, 2) = dr("COLOR_CPO")
            nc(lineas, 3) = dr("CODIGO")
            nc(lineas, 4) = dr("COLOR_TELA")
            nc(lineas, 5) = dr("LIBRAS")
            nc(lineas, 0) = Trim(nc(lineas, 1)) + Trim(nc(lineas, 2))
            nc(lineas, 8) = Trim(nc(lineas, 1)) + Trim(nc(lineas, 2)) + Trim(nc(lineas, 3)) + Trim(nc(lineas, 4))
            nc(lineas, 9) = dr("DESCRIPCION")
            lineas = lineas + 1
        Next
    End Sub

    ' ===================================================================================
    '
    '  fg = Prendas por cortar
    '
    ' ===================================================================================

    Private Sub crea_fg()
        fg.Clear()
        fg.Rows.Count = 1
        fg.Cols.Count = 8
        Dim strSQL As String = "SELECT ESTILO, COLOR ,CPO_D.CPO ,SUM(TOTAL) AS TOTAL FROM CPO_D , CPO WHERE ESTADO = 'A' AND CPO.CPO = CPO_D.CPO AND CLIENTE = '" & Cliente.Text & "' GROUP BY ESTILO,COLOR,CPO_D.CPO"
        Dim dt As New DataTable()
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn)
        lineas = dt.Rows.Count
        fg.Rows.Count = lineas + 1
        lineas = 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("ESTILO")
            fg(lineas, 2) = dr("COLOR")
            fg(lineas, 3) = dr("CPO")
            fg(lineas, 4) = dr("TOTAL")
            fg(lineas, 0) = Trim(fg(lineas, 1)) + Trim(fg(lineas, 2)) + Trim(fg(lineas, 3))
            lineas = lineas + 1
        Next
    End Sub

    Private Sub busca_Cortado()
        Dim i As Integer
        Dim busca As String
        Dim cortado As Integer
        Dim proceso As Integer
        Dim linea As Integer
        Dim dt As New DataTable()
        Dim strSQL As String = "SELECT CORTES.ESTILO,CORTES.COLOR,CORTES.CPO,SUM(CORTES.TOTAL) AS CORTADO, (SELECT SUM(TOTAL) FROM CORTES_S WHERE CORTES_S.ESTILO = CORTES.ESTILO AND CORTES_S.COLOR = CORTES.COLOR AND CORTES_S.CPO = CORTES.CPO AND ESTADO = 'A' ) AS PROCESO FROM CORTES ,CPO_D WHERE CLIENTE = '" & Cliente.Text & "' AND ESTADO = 'A' AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR AND CORTES.CPO = CPO_D.CPO GROUP BY CORTES.ESTILO,CORTES.COLOR,CORTES.CPO"
        Dim dr As DataRow
        Dim pproc As Object = Nothing
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            busca = Trim(dr("ESTILO")) + Trim(dr("COLOR")) + Trim(dr("CPO"))
            cortado = dr("CORTADO")
            Try
                proceso = CInt(dr("PROCESO"))
            Catch
                proceso = 0
            End Try
            Try
                linea = fg.FindRow(busca, 1, 0, True)
                fg(linea, 5) = cortado
                fg(linea, 7) = proceso
                pproc = tsd.Compute("SUM(TOTAL)", "ESTILO = '" & fg(linea, 1) & "' AND COLOR = '" & fg(linea, 2) & "' AND CPO = '" & fg(linea, 3) & "' AND DESPACHO IS NULL")
            Catch
            End Try
            Try
                If (pproc > 0) And (fg(linea, 7) >= pproc) Then
                    fg(linea, 7) = fg(linea, 7) - pproc
                End If
            Catch
            End Try
            Try
                If (cortado + proceso) > fg(linea, 4) Then
                    fg.Rows.Remove(linea)
                End If
            Catch
            End Try
        Next
        For i = 1 To fg.Rows.Count - 1
            fg(i, 6) = fg(i, 4) - fg(i, 5) - fg(i, 7)
        Next
        fg.Sort(SortFlags.Ascending, 1, 2)
    End Sub
    ' ===================================================================================
    '
    '  te = balance de tela
    '
    ' ===================================================================================
    Private Sub setea_te()
        Dim index As Integer
        Te.Clear()
        Te.Styles.Normal.Border.Style = BorderStyleEnum.Inset
        Te.ScrollBars = ScrollBars.Both
        Te.Rows.Count = 1
        Te.Cols.Count = 10
        Te.Cols(0).Width = 5
        Te.Rows(0).Height = 30
        Dim c As Column = Te.Cols(1)
        Te.Cols(1).Name = "TELA"
        Te.Cols(2).Name = "COLOR"
        Te.Cols(3).Name = "LBS.NEC."
        Te.Cols(4).Name = "BODEGA"
        Te.Cols(5).Name = "PEDIDO"
        Te.Cols(6).Name = "BALANCE"
        Te.Cols(7).Name = "TEXTILERA"
        For index = 1 To Te.Cols.Count - 1
            Te.Cols(index).Width = 215
            Te(0, index) = Te.Cols(index).Name
            If index > 2 And index < 8 Then
                Te.Cols(index).TextAlign = TextAlignEnum.RightCenter
                Te.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
                Te.Cols(index).DataType = GetType(Decimal)
                Te.Cols(index).Format = "#####0"
                Te.Cols(index).Width = 100
            End If
        Next
        Te.Cols(8).Visible = False
        Te.Cols(9).Visible = False
        Te.Cols(1).Width = 500
        Te.Cols(2).Width = 300
    End Sub

    Private Sub llena_Te()
        Dim i As Integer
        Dim f As Integer
        Dim knit_col As String
        For i = 1 To nc.Rows.Count - 1
            knit_col = Trim(nc(i, 3)) + Trim(nc(i, 4))
            f = Te.FindRow(knit_col, 1, 0, True)
            If f <> -1 Then
                Te(f, 3) = Te(f, 3) + nc(i, 7)
            Else
                If nc(i, 7) > 0 Then
                    f = Te.Rows.Count
                    Te.Rows.Count = f + 1
                    Te(f, 0) = knit_col
                    Te(f, 1) = nc(i, 3)
                    Te(f, 2) = nc(i, 4)
                    Te(f, 3) = nc(i, 7)
                    knit_col = nc(i, 9)
                    Te(f, 8) = nc(i, 9)
                    '   Te(f, 9) = busca_registro(dm, "CODIGO",
                End If
            End If
        Next
        tela_inventario()
        tela_textilera()
        tela_pedida()
    End Sub

    Private Sub tela_inventario()
        Dim strsql As String
        Dim busca As String
        Dim linea As Integer
        Dim dt As New DataTable()
        strsql = "SELECT CODIGO,COLOR,(SUM(ROLLOS.PESO)/SUM(ROLLOS.YARDAS_I) * SUM(ROLLOS.YARDAS)) AS LIBRAS FROM ROLLOS WHERE ACTIVO IN ('S','0','5') AND CODIGO+COLOR IN (SELECT CODIGO +COLOR_TELA FROM CONSUMO_TELA WHERE CLIENTE = '" & Cliente.Text & "') AND YARDAS > 0 AND TIPO = 'TELA' AND CLIENTE = '" & Cliente.Text & "' GROUP BY CODIGO,COLOR"
        Dim dr As DataRow
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            busca = Trim(dr("CODIGO")) + Trim(dr("COLOR"))
            linea = Te.FindRow(busca, 1, 0, True)
            If linea > 0 Then
                Te(linea, 4) = CDec(dr("LIBRAS"))
            End If
        Next
    End Sub

    Private Sub tela_textilera()
        Dim strsql As String
        Dim busca As String
        Dim linea As Integer
        Dim dt As New DataTable()
        strsql = "SELECT CODIGO,COLOR,(SUM(ROLLOS.PESO)/SUM(ROLLOS.YARDAS_I) * SUM(ROLLOS.YARDAS)) AS LIBRAS FROM ROLLOS WHERE ACTIVO = '6' AND KNIT+COLOR IN (SELECT CODIGO+COLOR_TELA FROM CONSUMO_TELA WHERE CLIENTE = '" & Cliente.Text & "') AND YARDAS > 0 AND TIPO = 'TELA' AND CLIENTE = '" & Cliente.Text & "' GROUP BY CODIGO,COLOR"
        Dim dr As DataRow
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            busca = Trim(dr("CODIGO")) + Trim(dr("COLOR"))
            linea = Te.FindRow(busca, 1, 0, True)
            If linea > 0 Then
                Te(linea, 7) = CDec(dr("LIBRAS"))
                Te.SetCellStyle(linea, 7, Te.Styles("amarillo"))
            End If
        Next
    End Sub

    Private Sub tela_pedida()
        Dim i As Integer
        Dim strsql As String
        Dim busca As String
        Dim linea As Integer
        Dim pedi As Decimal
        Dim dt As New DataTable()
        strsql = "SELECT CODIGO,COLOR, (LIBRAS - RECIBIDAS) AS LIBRAS FROM FPO WHERE  RECIBIDAS = 0 AND TIPO = 'TELA' AND CODIGO+COLOR IN (SELECT CODIGO+COLOR_TELA FROM CONSUMO_TELA WHERE CLIENTE = '" & Cliente.Text & "' AND STATUS = 'ABIERTO') AND CLIENTE = '" & Cliente.Text & "' ORDER BY CODIGO,COLOR"
        Dim dr As DataRow
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            busca = Trim(dr("CODIGO")) + Trim(dr("COLOR"))
            linea = Te.FindRow(busca, 1, 0, True)
            pedi = CDec(dr("LIBRAS"))
            If linea > 0 And pedi > 0 Then
                Te(linea, 5) = Te(linea, 5) + pedi
            End If
        Next
        For i = 1 To Te.Rows.Count - 1
            Te(i, 6) = (Te(i, 4) + Te(i, 5)) - Te(i, 3)
            If Te(i, 6) < 0 Then
                Te.SetCellStyle(i, 6, Te.Styles("rojo"))
            End If
        Next i
        Te.Sort(SortFlags.Ascending, 1, 2)
    End Sub

    Private Sub Te_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Te.DoubleClick
        Dim col2 As Integer = Te.Cols("COLOR").Index
        Dim linea As Integer = Te.RowSel
        Dim codigo As String = Te(linea, 9)
        Dim colores As String = Te(linea, col2)
        Dim forma As New Bal_Tela_Det_c()
        forma.codigo = codigo
        forma.descripcion = Te(linea, 1)
        forma.colores = colores
        forma.necesario = Te(linea, 3)
        forma.inventar = Te(linea, 4)
        forma.pedido = Te(linea, 5)
        forma.balance = Te(linea, 6)
        forma.fg = nc
        forma.cliente = Cliente.Text
        forma.tsd = tsd
        forma.ShowDialog()
    End Sub

    Private Sub Impri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Impri.Click
        Print_te()
    End Sub

    Private Sub Print_te()
        Dim pd As PrintDocument
        Dim fecha As String
        Dim MAL As String = ""
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

End Class
