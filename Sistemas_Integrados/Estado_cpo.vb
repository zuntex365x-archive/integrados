Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Estado_cpo
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim si As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim te(9) As String
    Dim tp(9) As String
    Dim da(9) As Integer
    Friend WithEvents cpo As System.Windows.Forms.ComboBox
    Friend WithEvents s1 As System.Windows.Forms.Button
    Friend WithEvents r1 As System.Windows.Forms.Button
    Dim dr As DataRow
    Dim tl() As String
    Friend WithEvents pr As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ex As C1.Win.C1FlexGrid.C1FlexGrid
    Dim ts As String
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Co As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Pe As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Clientes As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estado_cpo))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Co = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Pe = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Clientes = New System.Windows.Forms.TextBox()
        Me.cpo = New System.Windows.Forms.ComboBox()
        Me.s1 = New System.Windows.Forms.Button()
        Me.r1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pr = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ex = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.Co, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Co
        '
        Me.Co.AllowEditing = False
        Me.Co.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Co.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Co.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Co.ColumnInfo = resources.GetString("Co.ColumnInfo")
        Me.Co.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Co.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Co.ForeColor = System.Drawing.Color.Black
        Me.Co.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.Co.Location = New System.Drawing.Point(8, 248)
        Me.Co.Name = "Co"
        Me.Co.Rows.Count = 10
        Me.Co.Rows.DefaultSize = 19
        Me.Co.Rows.Fixed = 0
        Me.Co.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Co.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.Co.Size = New System.Drawing.Size(1081, 136)
        Me.Co.StyleInfo = resources.GetString("Co.StyleInfo")
        Me.Co.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Co.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.Co, "Area de Datos.")
        '
        'Pe
        '
        Me.Pe.AllowEditing = False
        Me.Pe.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Pe.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Pe.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Pe.ColumnInfo = resources.GetString("Pe.ColumnInfo")
        Me.Pe.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Pe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Pe.ForeColor = System.Drawing.Color.Black
        Me.Pe.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Pe.Location = New System.Drawing.Point(8, 48)
        Me.Pe.Name = "Pe"
        Me.Pe.Rows.DefaultSize = 19
        Me.Pe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Pe.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Pe.Size = New System.Drawing.Size(1081, 176)
        Me.Pe.StyleInfo = resources.GetString("Pe.StyleInfo")
        Me.Pe.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Pe.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.Pe, "Area de Datos.")
        '
        'Clientes
        '
        Me.Clientes.BackColor = System.Drawing.Color.White
        Me.Clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clientes.Location = New System.Drawing.Point(471, 8)
        Me.Clientes.MaxLength = 10
        Me.Clientes.Name = "Clientes"
        Me.Clientes.ReadOnly = True
        Me.Clientes.Size = New System.Drawing.Size(260, 22)
        Me.Clientes.TabIndex = 60
        Me.ToolTip1.SetToolTip(Me.Clientes, "Cliente")
        '
        'cpo
        '
        Me.cpo.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cpo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpo.Location = New System.Drawing.Point(70, 8)
        Me.cpo.Name = "cpo"
        Me.cpo.Size = New System.Drawing.Size(229, 24)
        Me.cpo.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cpo, "CPO")
        '
        's1
        '
        Me.s1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.s1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s1.ForeColor = System.Drawing.Color.Black
        Me.s1.Image = CType(resources.GetObject("s1.Image"), System.Drawing.Image)
        Me.s1.Location = New System.Drawing.Point(880, 3)
        Me.s1.Name = "s1"
        Me.s1.Size = New System.Drawing.Size(60, 40)
        Me.s1.TabIndex = 62
        Me.s1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.s1, "Chequeo de Datos")
        Me.s1.UseVisualStyleBackColor = False
        '
        'r1
        '
        Me.r1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.r1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r1.ForeColor = System.Drawing.Color.Black
        Me.r1.Image = CType(resources.GetObject("r1.Image"), System.Drawing.Image)
        Me.r1.Location = New System.Drawing.Point(880, 3)
        Me.r1.Name = "r1"
        Me.r1.Size = New System.Drawing.Size(60, 40)
        Me.r1.TabIndex = 68
        Me.r1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.r1, "Limpia datos sin Grabar ni Eliminar.")
        Me.r1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Cortado"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 392)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Producido"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 552)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Exportado"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 24)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "CPO:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Pedido"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(399, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 32)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Cliente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 696)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(496, 16)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Para obtener el detalle presione click sobre la celda a consultar."
        '
        'pr
        '
        Me.pr.AllowEditing = False
        Me.pr.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.pr.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.pr.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.pr.ColumnInfo = resources.GetString("pr.ColumnInfo")
        Me.pr.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.pr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.pr.ForeColor = System.Drawing.Color.Black
        Me.pr.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.pr.Location = New System.Drawing.Point(8, 413)
        Me.pr.Name = "pr"
        Me.pr.Rows.Count = 10
        Me.pr.Rows.DefaultSize = 19
        Me.pr.Rows.Fixed = 0
        Me.pr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.pr.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.pr.Size = New System.Drawing.Size(1081, 136)
        Me.pr.StyleInfo = resources.GetString("pr.StyleInfo")
        Me.pr.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.pr.TabIndex = 69
        Me.ToolTip1.SetToolTip(Me.pr, "Area de Datos.")
        '
        'ex
        '
        Me.ex.AllowEditing = False
        Me.ex.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.ex.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.ex.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ex.ColumnInfo = resources.GetString("ex.ColumnInfo")
        Me.ex.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.ex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ex.ForeColor = System.Drawing.Color.Black
        Me.ex.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.ex.Location = New System.Drawing.Point(8, 571)
        Me.ex.Name = "ex"
        Me.ex.Rows.Count = 10
        Me.ex.Rows.DefaultSize = 19
        Me.ex.Rows.Fixed = 0
        Me.ex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ex.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.ex.Size = New System.Drawing.Size(1081, 136)
        Me.ex.StyleInfo = resources.GetString("ex.StyleInfo")
        Me.ex.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.ex.TabIndex = 70
        Me.ToolTip1.SetToolTip(Me.ex, "Area de Datos.")
        '
        'Estado_cpo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1101, 711)
        Me.Controls.Add(Me.ex)
        Me.Controls.Add(Me.pr)
        Me.Controls.Add(Me.s1)
        Me.Controls.Add(Me.cpo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Clientes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Pe)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Co)
        Me.Controls.Add(Me.r1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Estado_cpo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado Acutal de la CPO"
        CType(Me.Co, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub ESTADO_cPO(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler cpo.KeyPress, AddressOf keypressed1
        llena_combos(cpo, "SELECT DISTINCT CPO FROM CPO_D ORDER BY CPO", "CPO")
        te = Split("XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6", ","c)
        tp = Split("P0,P1,P2,P3,P4,P5,P6,P7,P8,P9", ","c)
        setea_pe()
        setea_co()
        setea_pr()
        setea_EX()
        get_escalas(ts)
        tl = Split(ts, "|")
        cpo.Focus()
    End Sub
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cpo.Text) <> "" Then
                s1.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub busca_cpo(ByRef si As Boolean)
        Dim dt As New DataTable()
        Dim cliente As String
        Dim strSQL As String = "SELECT * FROM CPO WHERE CPO = '" & cpo.Text & "'"
        si = False
        llena_tablas(dt, strSQL, cnn)
        For Each Me.dr In dt.Rows
            si = True
            cliente = dr("CLIENTE")
            Clientes.Text = cliente
        Next
        If dt.Rows.Count = 0 Then
            MsgBox("CPO no Existe !!!!", MsgBoxStyle.Critical, "Error en los Datos !!!")
        End If
    End Sub

    Private Sub deshabilita()
        cpo.Enabled = False
    End Sub

    Private Sub setea_pe()
        Pe.Rows.Count = 1
        Pe.Cols(0).Width = 5
        Pe.Rows(0).Height = 30
        Pe.Cols(1).AllowMerging = True
        Pe.Cols(2).AllowMerging = True
        talla_Grid(Pe, 3, True)
    End Sub

    Private Sub llena_pe()
        Dim estilo As String
        Dim colo As String
        Dim i As Integer
        Dim dato As String
        Dim total As Integer
        Dim dt As New DataTable()
        Dim adulto As Boolean = True
        Dim escala As String = ""
        Dim strSQL As String = "SELECT * FROM CPO_D WHERE CPO = '" & cpo.Text & "' ORDER BY ESCALA,ESTILO, COLOR"
        llena_tablas(dt, strSQL, cnn)
        Pe.Rows.Count = dt.Rows.Count
        lineas = 0
        For Each Me.dr In dt.Rows
            If escala <> dr("ESCALA") Then
                escala = dr("ESCALA")
                Pe.Rows.Count = Pe.Rows.Count + 1
                div_tallas(Pe, escala, lineas)
                Pe(lineas, 13) = "TOTALES"
                Pe(lineas, 14) = "ESCALA"
                lineas = lineas + 1
            End If
            estilo = dr("ESTILO")
            colo = dr("COLOR")
            total = 0
            Pe(lineas, 1) = estilo
            Pe(lineas, 2) = colo
            For i = 0 To 9
                dato = te(i)
                Pe(lineas, i + 3) = dr(dato)
                total = total + Pe(lineas, i + 3)
            Next
            Pe(lineas, 13) = total
            Pe(lineas, 14) = tl(dr("ESCALA"))
            lineas = lineas + 1
        Next
        'talla_Grid(Co, 3, adulto)
        'talla_Grid(Pr, 4, adulto)
        'talla_Grid(Ex, 4, adulto)

    End Sub

    Private Sub div_tallas(ByRef ta As C1.Win.C1FlexGrid.C1FlexGrid, ByVal escala As String, ByVal l As Integer)
        Dim dr As DataRow
        Dim i As Integer
        Dim t As String
        dr = get_tallas(escala)
        ta(l, 1) = "ESTILO"
        ta(l, 2) = "COLOR"
        For i = 1 To 10
            t = dr(i + 1)
            ta(l, i + 2) = t
        Next
        ta.Rows(l).Style = Pe.Styles("titulo")
        ta.Rows(l).Height = 30
    End Sub
    '=============================================== CORTE ================================================
    Private Sub setea_co()
        Co.Rows.Count = 0
    End Sub

    Private Sub llena_co()
        Dim dt As New DataTable()
        Dim estilo As String
        Dim colo As String
        Dim i As Integer
        Dim dato As String
        Dim total As Integer = 0
        Dim escala As String = ""
        Dim strSQL As String = "SELECT CORTES.ESTILO,CORTES.COLOR,SUM(CORTES.XS) AS XS, SUM(CORTES.S) AS S, SUM(CORTES.M) AS M, SUM(CORTES.L) AS L, SUM(CORTES.XL) AS XL, SUM(CORTES.XL2) AS XL2, SUM(CORTES.XL3) AS XL3, SUM(CORTES.XL4) AS XL4, SUM(CORTES.XL5) AS XL5, SUM(CORTES.XL6) AS XL6 , ESCALA FROM CORTES LEFT JOIN CPO_D ON CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR WHERE CORTES.CPO = '" & cpo.Text & "'  GROUP BY ESCALA ,CORTES.ESTILO,CORTES.COLOR ORDER BY ESCALA ,CORTES.ESTILO,CORTES.COLOR"
        llena_tablas(dt, strSQL, cnn)
        lineas = 0
        Co.Rows.Count = dt.Rows.Count
        For Each Me.dr In dt.Rows
            If escala <> dr("ESCALA") Then
                escala = dr("ESCALA")
                Co.Rows.Count = Co.Rows.Count + 1
                div_tallas(Co, escala, lineas)
                Co(lineas, 13) = "TOTALES"
                lineas = lineas + 1
            End If
            estilo = dr("ESTILO")
            colo = dr("COLOR")
            total = 0
            Co(lineas, 1) = estilo
            Co(lineas, 2) = colo
            For i = 0 To 9
                dato = te(i)
                Co(lineas, i + 3) = dr(dato)
                total = total + Co(lineas, i + 3)
            Next
            Co(lineas, 13) = total
            lineas = lineas + 1
        Next
    End Sub

    '=============================================== PRODUCCION  ================================================
    Private Sub setea_pr()
        pr.Rows.Count = 0
    End Sub

    Private Sub llena_pr()
        Dim dt As New DataTable()
        Dim estilo As String
        Dim colo As String
        Dim i As Integer
        Dim dato As String
        Dim total As Integer = 0
        Dim escala As String = ""
        Dim strSQL As String = "SELECT CORTES.ESTILO,CORTES.COLOR, SUM(P0) AS P0, SUM(P1) AS P1, SUM(P2) AS P2,SUM(P3) AS P3, SUM(P4) AS P4,SUM(P5) AS P5, SUM(P6) AS P6, SUM(P7) AS P7, SUM(P8) AS P8, SUM(P9) AS P9, SUM(S0+S1+S2+S3+S4+S5+S6+S7+S8+S9) AS SEG , ESCALA FROM CORTES_P LEFT JOIN CORTES ON CORTES_P.CORTE = CORTES.CORTE LEFT JOIN CPO_D ON CORTES.CPO  = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR WHERE CORTES.CPO = '" & cpo.Text & "' GROUP BY ESCALA,CORTES.ESTILO, CORTES.COLOR ORDER BY ESCALA,CORTES.ESTILO, CORTES.COLOR"
        llena_tablas(dt, strSQL, cnn)
        lineas = 0
        pr.Rows.Count = dt.Rows.Count
        For Each Me.dr In dt.Rows
            If escala <> dr("ESCALA") Then
                escala = dr("ESCALA")
                pr.Rows.Count = pr.Rows.Count + 1
                div_tallas(pr, escala, lineas)
                pr(lineas, 13) = "SEG."
                pr(lineas, 14) = "TOTALES"
                lineas = lineas + 1
            End If
            estilo = dr("ESTILO")
            colo = dr("COLOR")
            pr(lineas, 1) = estilo
            pr(lineas, 2) = colo
            total = 0
            For i = 0 To 9
                dato = "P" + CStr(i)
                pr(lineas, i + 3) = pr(lineas, i + 3) + dr(dato)
                total = total + pr(lineas, i + 3)
            Next
            pr(lineas, 13) = dr("SEG")
            pr(lineas, 14) = total + pr(lineas, 13)
            lineas = lineas + 1
        Next
    End Sub

    '=============================================== EXPORTACION  ================================================

    Private Sub setea_EX()
        Ex.Rows.Count = 0
    End Sub

    Private Sub llena_EX()
        Dim dt As New DataTable()
        Dim estilo As String
        Dim colo As String
        Dim i As Integer
        Dim dato As String
        Dim total As Integer = 0
        Dim escala As String = ""
        Dim strSQL As String = "SELECT CORTES.ESTILO,CORTES.COLOR,SUM(P0) AS P0, SUM(P1) AS P1, SUM(P2) AS P2,SUM(P3) AS P3, SUM(P4) AS P4,SUM(P5) AS P5, SUM(P6) AS P6, SUM(P7) AS P7, SUM(P8) AS P8, SUM(P9) AS P9, SUM(S0+S1+S2+S3+S4+S5+S6+S7+S8+S9) AS SEG , ESCALA FROM CORTES_E LEFT JOIN CORTES ON CORTES_E.CORTE = CORTES.CORTE LEFT JOIN CPO_D ON CORTES.CPO  = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR WHERE CORTES.CORTE = CORTES_E.CORTE AND CORTES.CPO = '" & cpo.Text & "' GROUP BY ESCALA,CORTES.ESTILO, CORTES.COLOR ORDER BY ESCALA,CORTES.ESTILO, CORTES.COLOR"
        llena_tablas(dt, strSQL, cnn)
        lineas = 0
        ex.Rows.Count = dt.Rows.Count
        For Each Me.dr In dt.Rows
            If escala <> dr("ESCALA") Then
                escala = dr("ESCALA")
                ex.Rows.Count = ex.Rows.Count + 1
                div_tallas(ex, escala, lineas)
                ex(lineas, 13) = "SEG."
                ex(lineas, 14) = "TOTALES"
                lineas = lineas + 1
            End If
            estilo = dr("ESTILO")
            colo = dr("COLOR")
            ex(lineas, 1) = estilo
            ex(lineas, 2) = colo
            total = 0
            For i = 0 To 9
                dato = "P" + CStr(i)
                ex(lineas, i + 3) = ex(lineas, i + 3) + dr(dato)
                total = total + ex(lineas, i + 3)
            Next
            ex(lineas, 13) = dr("SEG")
            ex(lineas, 14) = total + ex(lineas, 13)
            stock(estilo, colo, lineas)
            lineas = lineas + 1
        Next
    End Sub

    Private Sub stock(ByVal estilo As String, ByVal colo As String, ByVal si As Integer)
        Dim dd As New DataTable()
        Dim talla As String
        Dim tipo As String
        Dim prendas As Integer
        Dim i As Integer
        Dim re(9) As String
        Dim tallas As String = "XS,S,M,L,XL,2XL,3XL,4XL,5XL,6XL"
        re = Split(tallas, ","c)
        Dim strSQL As String = "SELECT CPO,ESTILO,COLOR,TIPO,TALLA,SUM(PRENDAS) AS PRENDA FROM S_STOCK WHERE CPO = '" & cpo.Text & "' AND ESTILO = '" & estilo & "' AND COLOR = '" & colo & "' GROUP BY CPO,ESTILO,COLOR,TIPO,TALLA "
        llena_tablas(dd, strSQL, cnn)
        For Each Me.dr In dd.Rows
            tipo = dr("TIPO")
            talla = dr("TALLA")
            prendas = dr("PRENDA")
            i = Array.IndexOf(re, talla)
            If tipo = 0 Then
                Ex(si, i + 4) = Ex(si, i + 4) + prendas
                Ex(si, 14) = Ex(si, 14) + prendas
            Else
                Ex(si, 3) = Ex(si, 3) + prendas
                Ex(si, 14) = Ex(si, 14) + prendas
            End If
        Next
    End Sub

    Private Sub detalle_por_cortar(ByVal f As Integer)
        Dim forma As New Prendas_x_cortar()
        Try
            forma.Cpo.Text = cpo.Text
            forma.Estilo.Text = Co(f, 1)
            forma.Colo.Text = Co(f, 2)
            forma.ShowDialog()
        Catch
        End Try
    End Sub

    Private Sub detalle_costura(ByVal f As Integer)
        Dim forma As New Prendas_costura()
        Try
            forma.Cpo.Text = cpo.Text
            forma.Estilo.Text = pr(f, 1)
            forma.Colo.Text = pr(f, 2)
            forma.ShowDialog()
        Catch
        End Try
    End Sub

    Private Sub detalle_exportac(ByVal f As Integer)
        Dim forma As New Prendas_exportac()
        Try
            forma.Cpo.Text = cpo.Text
            forma.Estilo.Text = Ex(f, 1)
            forma.Colo.Text = Ex(f, 2)
            forma.ShowDialog()
        Catch
        End Try
    End Sub

    Private Sub Co_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Co.Click
        Dim f As Integer = Co.RowSel
        detalle_por_cortar(f)
    End Sub

    Private Sub Pr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As Integer = pr.RowSel
        detalle_costura(f)
    End Sub

    Private Sub Ex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As Integer = Ex.RowSel
        detalle_exportac(f)
    End Sub

    Private Sub cpo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cpo.KeyPress
        AutoCompletar(cpo, e)
    End Sub

    Private Sub s1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles s1.Click
        If cpo.Text <> "" Then
            ok = True
            busca_cpo(ok)
            If ok Then
                deshabilita()
                llena_pe()
                llena_co()
                llena_pr()
                llena_EX()
                s1.Visible = False
                r1.Visible = True
                r1.Focus()
            End If
        End If
    End Sub

    Private Sub r1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r1.Click
        cpo.Enabled = True
        Clientes.Text = ""
        r1.Visible = False
        s1.Visible = True
        setea_pe()
        setea_co()
        setea_pr()
        setea_EX()
        cpo.Focus()
    End Sub
End Class



