Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Bal_tela_prod_s1
    Inherits System.Windows.Forms.Form
    Public codigo As String
    Public descripcion As String
    Public colores As String
    Public necesario As Decimal
    Public inventar As Decimal
    Public pedido As Decimal
    Public balance As Decimal
    Public cliente As String
    Public ss As DataRow() = Nothing
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Pe As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents colors As System.Windows.Forms.Label
    Friend WithEvents desc_tela As System.Windows.Forms.Label
    Friend WithEvents Codi As System.Windows.Forms.Label
    Friend WithEvents ct As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fo As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bal_tela_prod_s1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Pe = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ct = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.fo = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.desc_tela = New System.Windows.Forms.Label()
        Me.colors = New System.Windows.Forms.Label()
        Me.Codi = New System.Windows.Forms.Label()
        CType(Me.Pe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pe
        '
        Me.Pe.AllowEditing = False
        Me.Pe.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Pe.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Pe.BackColor = System.Drawing.Color.White
        Me.Pe.ColumnInfo = resources.GetString("Pe.ColumnInfo")
        Me.Pe.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Pe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Pe.ForeColor = System.Drawing.Color.Black
        Me.Pe.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Pe.Location = New System.Drawing.Point(8, 64)
        Me.Pe.Name = "Pe"
        Me.Pe.Rows.DefaultSize = 19
        Me.Pe.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Pe.Size = New System.Drawing.Size(1424, 208)
        Me.Pe.StyleInfo = resources.GetString("Pe.StyleInfo")
        Me.Pe.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Pe.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.Pe, "Celdas en Rojo muestran Faltante en tela.")
        '
        'ct
        '
        Me.ct.AllowEditing = False
        Me.ct.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.ct.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.ct.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.ct.ColumnInfo = resources.GetString("ct.ColumnInfo")
        Me.ct.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ct.ForeColor = System.Drawing.Color.Black
        Me.ct.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.ct.Location = New System.Drawing.Point(8, 304)
        Me.ct.Name = "ct"
        Me.ct.Rows.DefaultSize = 19
        Me.ct.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.ct.Size = New System.Drawing.Size(1424, 248)
        Me.ct.StyleInfo = resources.GetString("ct.StyleInfo")
        Me.ct.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.ct.TabIndex = 73
        '
        'fo
        '
        Me.fo.AllowEditing = False
        Me.fo.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fo.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fo.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.fo.ColumnInfo = resources.GetString("fo.ColumnInfo")
        Me.fo.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fo.ForeColor = System.Drawing.Color.Black
        Me.fo.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fo.Location = New System.Drawing.Point(8, 592)
        Me.fo.Name = "fo"
        Me.fo.Rows.DefaultSize = 19
        Me.fo.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fo.Size = New System.Drawing.Size(1424, 176)
        Me.fo.StyleInfo = resources.GetString("fo.StyleInfo")
        Me.fo.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fo.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 16)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Prendas por Cortar"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 576)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Tela Pedida"
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
        'Bal_tela_prod_s1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1434, 792)
        Me.Controls.Add(Me.fo)
        Me.Controls.Add(Me.ct)
        Me.Controls.Add(Me.Codi)
        Me.Controls.Add(Me.colors)
        Me.Controls.Add(Me.desc_tela)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Pe)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Bal_tela_prod_s1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance de Tela por Fecha de Produccion"
        CType(Me.Pe, System.ComponentModel.ISupportInitialize).EndInit()
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
        inventario_inicial()
        llena_pe()
        llena_fo()
        acumula_valores()
        'Cursor = Cursors.Default
    End Sub

    Private Sub resumen()
        Dim i As Integer
        For i = 1 To Pe.Rows.Count - 1
            If Pe(i, 9) < 0 Then
                Pe.SetCellStyle(i, 9, Pe.Styles("rojo"))
            End If
        Next
    End Sub

    Private Sub setea_grids()
        Dim i As Integer
        Dim su(0, 7, 6, 5, 4, 3, 2, 1) As Integer
        Pe.Rows.Count = 1
        fo.Rows.Count = 1
        ct.Rows.Count = 1
        Pe.Cols(0).Width = 5
        ct.Rows(0).Height = 30
        fo.Rows(0).Height = 30
        Pe.Rows(0).Height = 30
        Pe.Rows.Count = 7
        pd = hoy.AddDays(-dis)
        Pe(0, 2) = UCase(Format(pd, "dd-MMM-yyyy"))
        ct(0, 2) = UCase(Format(pd, "dd-MMM-yyyy"))
        fo(0, 2) = UCase(Format(pd, "dd-MMM-yyyy"))
        fei = pd
        For i = 1 To 19
            pd = pd.AddDays(7)
            Pe(0, i + 2) = UCase(Format(pd, "dd-MMM-yyyy"))
            ct(0, i + 2) = UCase(Format(pd, "dd-MMM-yyyy"))
            fo(0, i + 2) = UCase(Format(pd, "dd-MMM-yyyy"))
        Next
        Pe(0, 21) = "> " & Pe(0, 20)
        ct(0, 21) = "> " & ct(0, 20)
        fo(0, 21) = "> " & fo(0, 20)
        Pe(1, 1) = "Costura"
        Pe(2, 1) = "Necesidad Tela"
        Pe(3, 1) = "FPO'S"
        Pe(4, 1) = "Acumulado nec."
        Pe(5, 1) = "Acumulado Tela"
        Pe(6, 1) = "Inventario"
        fo(0, 1) = "FPO"
        ct(0, 1) = "CPO"
        llena_tablas(con, "SELECT * FROM CONSUMO_TELA LEFT JOIN ESTILOS ON ESTILOS.ESTILO = CONSUMO_TELA.ESTILO_CPO WHERE CODIGO = '" & codigo & "' AND COLOR_TELA = '" & colores & "'", cnn)
        Pe.Rows(1).Style = Pe.Styles("amarillo")
        Pe.Rows(6).Style = Pe.Styles("verde")
    End Sub

    Private Sub llena_pe()
        Dim cortar As Decimal
        Dim fp As Date
        Dim ft As Date
        Dim fco As Date
        Dim col As Integer
        Dim l As Integer = 1
        Dim dd As DataRow()
        Dim cpo As String
        dd = ss
        For Each dr In dd
            cpo = dr("CPO")
            cortar = dr("NECESARIO")
            fp = dr("F_PROD")
            ft = dr("F_NEC")
            fco = dr("F_COR")
            '============== FECHA PRODUCCION
            determina_columna_tela(fei, fp, 2, 20, col)
            Pe(1, col) = Pe(1, col) + cortar
            '============== FECHA NECESITAMOS TELA
            determina_columna_tela(fei, ft, 2, 20, col)
            Pe(2, col) = Pe(2, col) + cortar

            l = ct.FindRow(cpo, 1, 1, False)
            If l < 0 Then
                l = ct.Rows.Count
                ct.Rows.Count = l + 1
                ct(l, 1) = cpo
            End If
            determina_columna_tela(fei, fco, 2, 20, col)
            ct(l, col) = ct(l, col) + dr("PRENDAS")
        Next
    End Sub


    Private Sub acumula_valores()
        Dim i As Integer
        Pe(4, 2) = Pe(2, 2)
        Pe(5, 2) = Pe(5, 2) + Pe(3, 2)
        Pe(6, 2) = Pe(5, 2) - Pe(4, 2)
        If Pe(6, 2) < 0 Then
            Pe.SetCellStyle(6, 2, Pe.Styles("rojo"))
        End If
        For i = 3 To 21
            Pe(4, i) = Pe(4, i - 1) + Pe(2, i)
            Pe(5, i) = Pe(5, i - 1) + Pe(3, i)
            Pe(6, i) = Pe(5, i) - Pe(4, i)
            If Pe(6, i) < 0 Then
                Pe.SetCellStyle(6, i, Pe.Styles("rojo"))
            End If
        Next
    End Sub

    '=============================================== Inventario ================================================
    Private Sub inventario_inicial()
        Dim dt As New DataTable()
        Dim libras As Decimal
        Dim strSQL As String = "SELECT SUM(C.LIBRAS) LIBRAS FROM (SELECT SUM((ROLLOS.PESO/ROLLOS.YARDAS_I) * ROLLOS.YARDAS) AS LIBRAS  FROM ROLLOS WHERE CODIGO = '" & codigo & "' And COLOR = '" & colores & "' And CLIENTE = '" & cliente & "' And YARDAS > 0 AND ACTIVO IN ('S','0','5') UNION SELECT sum((ROLLOS.PESO/ROLLOS.YARDAS_I) * ROLLOS.YARDAS) * -1 AS LIBRAS FROM ROLLOS INNER JOIN REQ_D ON ROLLOS.BATCH = REQ_D.BATCH AND ROLLOS.ROLLO = REQ_D.ROLLO AND DESPACHADO = 'N' WHERE CODIGO = '" & codigo & "' AND COLOR = '" & colores & "' AND ACTIVO IN ('S','0','5') And ROLLOS.YARDAS > 0 AND TIPO = 'TELA' AND CLIENTE = '" & cliente & "') AS C"

        '= "SELECT SUM((ROLLOS.PESO/ROLLOS.YARDAS_I) * ROLLOS.YARDAS) AS LIBRAS FROM ROLLOS WHERE CODIGO = '" & codigo & "' AND COLOR = '" & colores & "' AND YARDAS > 0 AND CLIENTE = '" & cliente & "' AND ACTIVO IN ('S','0','5')"
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            libras = 0
            Try
                libras = dr("LIBRAS")
            Catch
            End Try
            Pe(5, 2) = libras
        Next
    End Sub

    '=============================================== TELA PEDIDA   ================================================
    Private Sub llena_fo()
        Dim dt As New DataTable()
        Dim pedidos As Decimal
        Dim c As Integer
        Dim strSQL As String = "SELECT FPO,CLIENTE,OFECHA,SUM(LIBRAS - RECIBIDAS) AS PEDIDO FROM FPO WHERE CODIGO = '" & codigo & "' AND COLOR = '" & colores & "' AND TIPO = 'TELA' AND STATUS = 'ABIERTO' AND CLIENTE = '" & cliente & "' AND RECIBIDAS = 0 GROUP BY FPO,CLIENTE,OFECHA"
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn)
        lineas = dt.Rows.Count
        fo.Rows.Count = lineas + 1
        lineas = 1
        For Each dr In dt.Rows
            pedidos = dr("PEDIDO")
            determina_columna_tela(fei, dr("OFECHA"), 2, 20, c)
            fo(lineas, 1) = dr("FPO")
            fo(lineas, c) = fo(lineas, c) + pedidos
            Pe(3, c) = Pe(3, c) + pedidos
            lineas = lineas + 1
        Next
    End Sub

    Private Sub Pe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pe.DoubleClick
        Dim forma As New Bal_tela_prod_dd1()
        forma.codigo = Codi.Text
        forma.descripcion = desc_tela.Text
        forma.colores = colors.Text
        forma.cliente = cliente
        forma.tsd = tsd
        forma.ss = ss
        forma.ShowDialog()
    End Sub
End Class



