Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Balance_Cpo
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim cnn1 As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim se As New C1.Win.C1FlexGrid.C1FlexGrid()
    Dim path As String = "c:\reportes\balance.xls"
    Dim dt As New DataTable()
    Dim dr As DataRow
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
    Friend WithEvents fp As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Balance_Cpo))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Cliente = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.si = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.R1 = New System.Windows.Forms.Button()
        Me.Impri = New System.Windows.Forms.Button()
        Me.Te = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Ex = New System.Windows.Forms.Button()
        Me.fp = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.nc = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Te, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fp, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(16, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
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
        Me.Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cliente.Location = New System.Drawing.Point(128, 16)
        Me.Cliente.MaxLength = 20
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(168, 21)
        Me.Cliente.TabIndex = 24
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
        Me.si.Location = New System.Drawing.Point(360, 8)
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
        Me.R1.Location = New System.Drawing.Point(360, 8)
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
        Me.Impri.Location = New System.Drawing.Point(408, 8)
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
        Me.Te.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.Te.AllowEditing = False
        Me.Te.AllowFiltering = True
        Me.Te.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.Te.BackColor = System.Drawing.Color.White
        Me.Te.ColumnInfo = resources.GetString("Te.ColumnInfo")
        Me.Te.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Te.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Te.ForeColor = System.Drawing.Color.Black
        Me.Te.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.Te.Location = New System.Drawing.Point(8, 48)
        Me.Te.Name = "Te"
        Me.Te.Rows.Count = 1
        Me.Te.Rows.DefaultSize = 19
        Me.Te.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Te.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
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
        Me.Ex.Location = New System.Drawing.Point(456, 8)
        Me.Ex.Name = "Ex"
        Me.Ex.Size = New System.Drawing.Size(35, 35)
        Me.Ex.TabIndex = 59
        Me.Ex.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Ex, "Presione este Boton si Desea  convertir a Excel los datos del  Inventario.")
        Me.Ex.UseVisualStyleBackColor = False
        Me.Ex.Visible = False
        '
        'fp
        '
        Me.fp.AllowEditing = False
        Me.fp.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fp.BackColor = System.Drawing.Color.White
        Me.fp.ColumnInfo = resources.GetString("fp.ColumnInfo")
        Me.fp.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fp.ForeColor = System.Drawing.Color.Black
        Me.fp.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fp.Location = New System.Drawing.Point(632, 48)
        Me.fp.Name = "fp"
        Me.fp.Rows.Count = 1
        Me.fp.Rows.DefaultSize = 19
        Me.fp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fp.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fp.Size = New System.Drawing.Size(360, 320)
        Me.fp.StyleInfo = resources.GetString("fp.StyleInfo")
        Me.fp.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fp.TabIndex = 60
        Me.ToolTip1.SetToolTip(Me.fp, "Presione Double Click sobre un Knit_Color para ver su Detalle")
        Me.fp.Visible = False
        '
        'nc
        '
        Me.nc.AllowEditing = False
        Me.nc.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.nc.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.nc.BackColor = System.Drawing.Color.White
        Me.nc.ColumnInfo = resources.GetString("nc.ColumnInfo")
        Me.nc.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.nc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nc.ForeColor = System.Drawing.Color.Black
        Me.nc.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.nc.Location = New System.Drawing.Point(8, 48)
        Me.nc.Name = "nc"
        Me.nc.Rows.Count = 1
        Me.nc.Rows.DefaultSize = 19
        Me.nc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.nc.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.nc.Size = New System.Drawing.Size(984, 608)
        Me.nc.StyleInfo = resources.GetString("nc.StyleInfo")
        Me.nc.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.nc.TabIndex = 56
        '
        'Balance_Cpo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 692)
        Me.Controls.Add(Me.Te)
        Me.Controls.Add(Me.nc)
        Me.Controls.Add(Me.Ex)
        Me.Controls.Add(Me.Impri)
        Me.Controls.Add(Me.si)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.fp)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Balance_Cpo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance de Tela por Cpo"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Te, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub consulta_cortes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Te.Width = Me.Width - 30
        Te.Height = Me.Height - 100
        llena_combos(Cliente, "SELECT * FROM CLIENTES ORDER BY CLIENTE", "CLIENTE")
        setea_te()
    End Sub


    Private Sub si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles si.Click
        Cursor = Cursors.WaitCursor
        si.Visible = False
        R1.Visible = True
        Impri.Visible = True
        Ex.Visible = False
        Cliente.Enabled = False
        llena_te()
        consumo_tela()
        pedidos()
        asignado()
        libras_necesarias()
        Cursor = Cursors.Default
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        si.Visible = True
        R1.Visible = False
        Impri.Visible = False
        Ex.Visible = False
        Cliente.Enabled = True
        setea_te()
        consumo_tela()
        libras_necesarias()
    End Sub


    Private Sub limpia_flex()
        Te.Visible = True
    End Sub

    ' ===================================================================================
    '
    '  Nc =  todas las telas del Cliente
    '
    ' ===================================================================================
    Private Sub consumo_tela()
        nc.Clear()
        nc.Rows.Count = 1
        nc.Cols.Count = 6
        Dim strSQL As String = "SELECT CPO_EST_COL.* FROM CPO_EST_COL WHERE ESTILO_CPO + COLOR_CPO IN (SELECT ESTILO + COLOR FROM CPO_D WHERE ESTADO = 'A') AND CLIENTE = '" & Cliente.Text & "'"
        llena_tablas(dt, strSQL, cnn1)
        lineas = dt.Rows.Count
        nc.Rows.Count = lineas + 1
        lineas = 1
        For Each Me.dr In dt.Rows
            nc(lineas, 1) = dr("ESTILO_CPO")
            nc(lineas, 2) = dr("COLOR_CPO")
            nc(lineas, 3) = dr("KNIT_TELA")
            nc(lineas, 4) = dr("COLOR_TELA")
            nc(lineas, 5) = dr("LIBRAS")
            nc(lineas, 0) = Trim(nc(lineas, 1)) + Trim(nc(lineas, 2))
            lineas = lineas + 1
        Next
        nc.Sort(SortFlags.Ascending, 0)
    End Sub


    ' ===================================================================================
    '
    '  fp =  todos los fpos del cliente
    '
    ' ===================================================================================
    Private Sub pedidos()
        fp.Clear()
        fp.Rows.Count = 1
        fp.Cols.Count = 5
        Dim strSQL As String = "SELECT FPO,CPO,KNIT,COLOR,SUM(LIBRAS) AS TLIBRA FROM FPO WHERE RECIBIDAS = 0  AND STATUS = 'ABIERTO' AND CLIENTE = '" & Cliente.Text & "' GROUP BY FPO,CPO,KNIT,COLOR "
        llena_tablas(dt, strSQL, cnn1)
        lineas = dt.Rows.Count
        fp.Rows.Count = lineas + 1
        lineas = 1
        For Each Me.dr In dt.Rows
            fp(lineas, 1) = dr("FPO")
            fp(lineas, 2) = dr("CPO")
            fp(lineas, 3) = dr("COLOR")
            fp(lineas, 4) = dr("TLIBRA")
            fp(lineas, 0) = Trim(fp(lineas, 2)) + Trim(dr("KNIT")) + Trim(fp(lineas, 3))
            lineas = lineas + 1
        Next
    End Sub


    ' ===================================================================================
    '
    '  fg =  todos los rollos del cliente
    '
    ' ===================================================================================
    Private Sub asignado()
        fg.Clear()
        fg.Rows.Count = 1
        fg.Cols.Count = 5
        Dim strSQL As String = "SELECT CPO,KNIT,COLOR,(SUM(ROLLOS.PESO)/SUM(ROLLOS.YARDAS_I) * SUM(ROLLOS.YARDAS)) AS TLIBRA FROM ROLLOS WHERE ACTIVO IN ('S','0','5') AND YARDAS > 0 AND TIPO = 'TELA' AND CLIENTE = '" & Cliente.Text & "' GROUP BY CPO,KNIT,COLOR ORDER BY CPO,KNIT,COLOR"
        llena_tablas(dt, strSQL, cnn1)
        lineas = dt.Rows.Count
        fg.Rows.Count = lineas + 1
        lineas = 1
        For Each Me.dr In dt.Rows
            fg(lineas, 1) = dr("CPO")
            fg(lineas, 2) = dr("KNIT")
            fg(lineas, 3) = dr("COLOR")
            fg(lineas, 4) = dr("TLIBRA")
            fg(lineas, 0) = Trim(fg(lineas, 1)) + Trim(fg(lineas, 2)) + Trim(fg(lineas, 3))
            lineas = lineas + 1
        Next
        fg.Sort(SortFlags.Ascending, 0)
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
        Te.Rows.Count = 1
        Te.Cols.Count = 11
        Te.Cols(0).Width = 5
        Te.Rows(0).Height = 30
        Dim c As Column = Te.Cols(1)
        Te.Cols(1).Name = "ENTREGA"
        Te.Cols(2).Name = "CPO"
        Te.Cols(3).Name = "ESTILO"
        Te.Cols(4).Name = "COLOR"
        Te.Cols(5).Name = "X CORTAR"
        Te.Cols(6).Name = "LBS.NEC."
        Te.Cols(7).Name = "LBS.ASIG."
        Te.Cols(8).Name = "LBS.FPO"
        Te.Cols(9).Name = "FPO.No"
        Te.Cols(10).Name = "BALANCE"
        For index = 1 To Te.Cols.Count - 1
            Te.Cols(index).Width = 110
            Te(0, index) = Te.Cols(index).Name
            If index > 4 Then
                Te.Cols(index).TextAlign = TextAlignEnum.RightCenter
                Te.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
                Te.Cols(index).DataType = GetType(Decimal)
                Te.Cols(index).Format = "#####0"
                Te.Cols(index).Width = 75
            End If
        Next
        Te.Cols(1).Width = 80
        Te.Cols(4).Width = 180
    End Sub

    Private Sub llena_te()
        Dim L As Integer
        Dim strsql As String
        Dim cortar As Integer
        Dim proceso As Integer
        Dim cortado As Integer
        Dim pedido As Integer
        strsql = "SELECT CPO_D.*, (SELECT SUM(TOTAL) FROM CORTES WHERE CPO_D.CPO = CORTES.CPO AND CPO_D.ESTILO = CORTES.ESTILO AND CPO_D.COLOR = CORTES.COLOR) AS CORTADO, (SELECT SUM(TOTAL) FROM CORTES_S WHERE CPO_D.CPO = CORTES_S.CPO AND CPO_D.ESTILO = CORTES_S.ESTILO AND CPO_D.COLOR = CORTES_S.COLOR AND ESTADO = 'A') AS PROCESO FROM CPO_D WHERE ESTADO = 'A' AND (SELECT CLIENTE FROM CPO WHERE CPO.CPO = CPO_D.CPO) = '" & Cliente.Text & "' ORDER BY CPO,ESTILO,COLOR"
        llena_tablas(dt, strsql, cnn1)
        L = dt.Rows.Count
        Te.Rows.Count = L + 1
        L = 1
        For Each Me.dr In dt.Rows
            Try
                pedido = dr("TOTAL")
            Catch
                pedido = 0
            End Try
            Try
                proceso = dr("PROCESO")
            Catch
                proceso = 0
            End Try
            Try
                cortado = dr("CORTADO")
            Catch
                cortado = 0
            End Try
            cortar = pedido - proceso - cortado
            If cortar > 0 Then
                Te(L, 1) = dr("F_ENTREGA")
                Te(L, 2) = dr("CPO")
                Te(L, 3) = dr("ESTILO")
                Te(L, 4) = dr("COLOR")
                Te(L, 5) = cortar
                L = L + 1
            Else
                Te.Rows.Remove(Te.Rows.Count - 1)
            End If
        Next
        Te.Sort(SortFlags.Ascending, 1)
    End Sub

    Private Sub libras_necesarias()
        Dim i As Integer
        Dim s As Integer
        Dim busca As String
        For i = 1 To Te.Rows.Count - 1
            busca = Trim(Te(i, 3)) + Trim(Te(i, 4))
            s = nc.FindRow(busca, 1, 0, True)
            If s > 0 Then
                While busca = nc(s, 0)
                    Te(i, 6) = Te(i, 6) + (Te(i, 5) * nc(s, 5))
                    tela_pedida(i, Trim(Te(i, 2)) + Trim(nc(s, 3)) + Trim(nc(s, 4)))
                    tela_asignada(i, Trim(Te(i, 2)) + Trim(nc(s, 3)) + Trim(nc(s, 4)))
                    s = s + 1
                    If s > nc.Rows.Count - 1 Then
                        s = 0
                    End If
                End While
            End If
            Te(i, 10) = Te(i, 7) + Te(i, 8) - Te(i, 6)
            If Te(i, 10) < 0 Then
                Te.SetCellStyle(i, 10, Te.Styles("rojo"))
            End If
        Next
    End Sub

    Private Sub tela_pedida(ByVal i As Integer, ByVal busca As String)
        Dim s As Integer
        s = fp.FindRow(busca, 1, 0, True)
        If s > 0 Then
            Te(i, 8) = Te(i, 8) + fp(s, 4)
            Te(i, 9) = fp(s, 1)
        End If
    End Sub


    Private Sub tela_asignada(ByVal i As Integer, ByVal busca As String)
        Dim s As Integer
        s = fg.FindRow(busca, 1, 0, True)
        If s > 0 Then
            Te(i, 7) = Te(i, 7) + fg(s, 4)
        End If
    End Sub

    Private Sub Te_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Te.DoubleClick
        Dim f As Integer
        Dim c As Integer
        Dim c1 As Integer = Te.Cols("X CORTAR").Index
        Dim c2 As Integer = Te.Cols("LBS.NEC.").Index
        Dim c3 As Integer = Te.Cols("LBS.ASIG.").Index
        Dim c4 As Integer = Te.Cols("LBS.FPO").Index
        f = Te.RowSel
        c = Te.ColSel
        If c = c1 Then
            detalle_por_cortar(f)
        End If
        If c = c2 Then
            tela_necesaria_cpo(f)
        End If
        If c = c3 Then
            tela_asignada_cpo(f)
        End If
        If c = c4 Then
            tela_pedida_cpo(f)
        End If
    End Sub

    Private Sub detalle_por_cortar(ByVal f As Integer)
        Dim forma As New Prendas_x_cortar()
        Cursor = Cursors.WaitCursor
        forma.Cpo.Text = Te(f, 2)
        forma.Estilo.Text = Te(f, 3)
        forma.Colo.Text = Te(f, 4)
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
        a_excel(fg, path, ok)
    End Sub

    Private Sub tela_necesaria_cpo(ByVal f As Integer)
        Dim forma As New Tela_necesa()
        Dim l As Integer
        Dim busca As String
        Dim s As Integer
        Dim b As Integer
        forma.fg.Clear()
        forma.Cpo.Text = Te(f, 2)
        forma.Estilo.Text = Te(f, 3)
        forma.Colo.Text = Te(f, 4)
        forma.Cortar.Text = Te(f, 5)
        busca = Trim(Te(f, 3)) + Trim(Te(f, 4))
        s = nc.FindRow(busca, 1, 0, True)
        If s > 0 Then
            While busca = nc(s, 0)
                l = forma.fg.Rows.Count
                forma.fg.Rows.Count = l + 1
                forma.fg(l, 1) = nc(s, 3)
                forma.fg(l, 2) = nc(s, 4)
                forma.fg(l, 3) = Te(f, 5)
                forma.fg(l, 4) = nc(s, 5)
                b = nc(s, 5)
                forma.fg(l, 5) = Te(f, 5) * nc(s, 5)
                b = fg.FindRow(Trim(Te(f, 2)) + Trim(nc(s, 3)) + Trim(nc(s, 4)), 1, 0, True)
                If b > 0 Then
                    forma.fg(l, 6) = fg(b, 4)
                End If
                b = fp.FindRow(Trim(Te(f, 2)) + Trim(nc(s, 3)) + Trim(nc(s, 4)), 1, 0, True)
                If b > 0 Then
                    forma.fg(l, 7) = fp(b, 4)
                End If
                If forma.fg(l, 7) > 0 Then
                    forma.fg(l, 8) = Te(f, 9)
                End If
                forma.fg(l, 9) = forma.fg(l, 6) + forma.fg(l, 7) - forma.fg(l, 5)
                If forma.fg(l, 9) < 0 Then
                    forma.fg.SetCellStyle(l, 9, forma.fg.Styles("rojo"))
                End If
                s = s + 1
                If s > nc.Rows.Count - 1 Then
                    s = 0
                End If
            End While
        End If
        forma.ShowDialog()
    End Sub

    Private Sub tela_asignada_cpo(ByVal f As Integer)
        Dim forma As New Tela_asigna()
        Dim busca As String
        forma.fg.Clear()
        forma.cliente = Cliente.Text
        forma.Cpo.Text = Te(f, 2)
        forma.Estilo.Text = Te(f, 3)
        forma.Colo.Text = Te(f, 4)
        forma.dentro = "('" & Te(f, 2) & Te(f, 4) & "')"
        forma.nodentro = "("
        busca = Trim(Te(f, 3)) + Trim(Te(f, 4))
        forma.ShowDialog()
    End Sub


    Private Sub tela_pedida_cpo(ByVal f As Integer)
        Dim forma As New Tela_pedida()
        Dim busca As String
        Dim s As Integer
        Dim b As Integer
        forma.fg.Clear()
        forma.Cpo.Text = Te(f, 2)
        forma.Estilo.Text = Te(f, 3)
        forma.Colo.Text = Te(f, 4)
        forma.dentro = "("
        busca = Trim(Te(f, 3)) + Trim(Te(f, 4))
        s = nc.FindRow(busca, 1, 0, True)
        If s > 0 Then
            While busca = nc(s, 0)
                forma.dentro = forma.dentro + "'" + Trim(nc(s, 4)) + "',"
                s = s + 1
                If s > nc.Rows.Count - 1 Then
                    s = 0
                End If
            End While
            b = forma.dentro.Length
            If b > 0 Then
                forma.dentro = Mid(forma.dentro, 1, b - 1) + ")"
            End If
        End If
        forma.ShowDialog()
    End Sub
End Class
