Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO
Imports C1.C1Excel

Public Class Detalle_cpo1
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim te(9) As String
    Friend WithEvents cpo As System.Windows.Forms.Label
    Friend WithEvents cliente As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents estilo As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents colores As System.Windows.Forms.Label
    Friend WithEvents co As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents pr As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ex As C1.Win.C1FlexGrid.C1FlexGrid
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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Pe As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents _book As C1.C1Excel.C1XLBook
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Detalle_cpo1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Pe = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.co = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.pr = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ex = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._book = New C1.C1Excel.C1XLBook()
        Me.cpo = New System.Windows.Forms.Label()
        Me.cliente = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.estilo = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.colores = New System.Windows.Forms.Label()
        CType(Me.Pe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.co, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pe
        '
        Me.Pe.AllowEditing = False
        Me.Pe.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Pe.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Pe.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Pe.ColumnInfo = resources.GetString("Pe.ColumnInfo")
        Me.Pe.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Pe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pe.ForeColor = System.Drawing.Color.Black
        Me.Pe.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Pe.Location = New System.Drawing.Point(8, 75)
        Me.Pe.Name = "Pe"
        Me.Pe.Rows.DefaultSize = 17
        Me.Pe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Pe.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Pe.Size = New System.Drawing.Size(1000, 99)
        Me.Pe.StyleInfo = resources.GetString("Pe.StyleInfo")
        Me.Pe.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Pe.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.Pe, "Area de Datos.")
        '
        'co
        '
        Me.co.AllowEditing = False
        Me.co.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.co.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.co.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.co.ColumnInfo = resources.GetString("co.ColumnInfo")
        Me.co.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.co.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.co.ForeColor = System.Drawing.Color.Black
        Me.co.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.co.Location = New System.Drawing.Point(8, 198)
        Me.co.Name = "co"
        Me.co.Rows.DefaultSize = 17
        Me.co.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.co.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.co.Size = New System.Drawing.Size(1000, 159)
        Me.co.StyleInfo = resources.GetString("co.StyleInfo")
        Me.co.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.co.TabIndex = 90
        Me.ToolTip1.SetToolTip(Me.co, "Area de Datos.")
        '
        'pr
        '
        Me.pr.AllowEditing = False
        Me.pr.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.pr.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.pr.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.pr.ColumnInfo = resources.GetString("pr.ColumnInfo")
        Me.pr.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.pr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pr.ForeColor = System.Drawing.Color.Black
        Me.pr.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.pr.Location = New System.Drawing.Point(8, 378)
        Me.pr.Name = "pr"
        Me.pr.Rows.DefaultSize = 17
        Me.pr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.pr.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.pr.Size = New System.Drawing.Size(1000, 145)
        Me.pr.StyleInfo = resources.GetString("pr.StyleInfo")
        Me.pr.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.pr.TabIndex = 91
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
        Me.ex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ex.ForeColor = System.Drawing.Color.Black
        Me.ex.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.ex.Location = New System.Drawing.Point(8, 553)
        Me.ex.Name = "ex"
        Me.ex.Rows.DefaultSize = 17
        Me.ex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ex.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.ex.Size = New System.Drawing.Size(1000, 154)
        Me.ex.StyleInfo = resources.GetString("ex.StyleInfo")
        Me.ex.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.ex.TabIndex = 92
        Me.ToolTip1.SetToolTip(Me.ex, "Area de Datos.")
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Cortado"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 360)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Producido"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 535)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 24)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Exportado"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 25)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "CPO:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Pedido"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(573, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Cliente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cpo
        '
        Me.cpo.BackColor = System.Drawing.Color.White
        Me.cpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cpo.ForeColor = System.Drawing.Color.Black
        Me.cpo.Location = New System.Drawing.Point(70, 11)
        Me.cpo.Name = "cpo"
        Me.cpo.Size = New System.Drawing.Size(141, 25)
        Me.cpo.TabIndex = 84
        Me.cpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cliente
        '
        Me.cliente.BackColor = System.Drawing.Color.White
        Me.cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cliente.ForeColor = System.Drawing.Color.Black
        Me.cliente.Location = New System.Drawing.Point(649, 39)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(329, 25)
        Me.cliente.TabIndex = 85
        Me.cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(255, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 24)
        Me.Label8.TabIndex = 86
        Me.Label8.Text = "Estilo:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'estilo
        '
        Me.estilo.BackColor = System.Drawing.Color.White
        Me.estilo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.estilo.ForeColor = System.Drawing.Color.Black
        Me.estilo.Location = New System.Drawing.Point(316, 8)
        Me.estilo.Name = "estilo"
        Me.estilo.Size = New System.Drawing.Size(218, 25)
        Me.estilo.TabIndex = 87
        Me.estilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(573, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 24)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "Color:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colores
        '
        Me.colores.BackColor = System.Drawing.Color.White
        Me.colores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.colores.ForeColor = System.Drawing.Color.Black
        Me.colores.Location = New System.Drawing.Point(649, 9)
        Me.colores.Name = "colores"
        Me.colores.Size = New System.Drawing.Size(329, 25)
        Me.colores.TabIndex = 89
        Me.colores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Detalle_cpo1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1018, 719)
        Me.Controls.Add(Me.ex)
        Me.Controls.Add(Me.pr)
        Me.Controls.Add(Me.co)
        Me.Controls.Add(Me.colores)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.estilo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.cpo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Pe)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Detalle_cpo1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Movimientos  de las CPO"
        CType(Me.Pe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.co, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub ESTADO_cPO(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        te = Split("XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6", ","c)
        setea_grids()
        llena_pe()
        llena_co()
        llena_pr()
        llena_ex()
    End Sub
    Private Sub setea_grids()
        Pe.Rows.Count = 1
        Pe.Rows(0).Height = 30
        co.Rows.Count = 1
        co.Rows(0).Height = 30
        pr.Rows.Count = 1
        pr.Rows(0).Height = 30
        ex.Rows.Count = 1
        ex.Rows(0).Height = 30
    End Sub
    '=============================================== PEDIDO  ================================================
    Private Sub llena_pe()
        Dim dt As New DataTable()
        Dim i As Integer
        Dim dato As String
        Dim total As Integer = 0
        Dim strSQL As String = "SELECT * FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO  WHERE CPO_D.CPO = '" & cpo.Text & "' AND ESTILO = '" & estilo.Text & "' AND COLOR = '" & colores.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        Pe.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each Me.dr In dt.Rows
            Pe(lineas, 1) = dr("F_PEDIDO")
            Pe(lineas, 2) = dr("F_ENTREGA")
            total = 0
            For i = 0 To 9
                dato = te(i)
                Pe(lineas, i + 3) = dr(dato)
                total = total + dr(dato)
            Next
            Pe(lineas, 13) = total
        Next
    End Sub
    '=============================================== CORTE ================================================
    Private Sub llena_co()
        Dim dt As New DataTable()
        Dim i As Integer
        Dim dato As String
        Dim total As Integer = 0
        Dim strSQL As String = "SELECT CORTES.*,SALA FROM CORTES LEFT JOIN CORTES_S ON CORTES.CORTE = CORTES_S.CORTE WHERE CORTES.CPO = '" & cpo.Text & "' AND CORTES.ESTILO = '" & estilo.Text & "' AND CORTES.COLOR = '" & colores.Text & "' ORDER BY FCORTE"
        llena_tablas(dt, strSQL, cnn)
        co.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each Me.dr In dt.Rows
            total = 0
            co(lineas, 1) = dr("CORTE")
            co(lineas, 2) = dr("FCORTE")
            For i = 0 To 9
                dato = te(i)
                co(lineas, i + 3) = dr(dato)
                co(lineas, 13) = co(lineas, 13) + dr(dato)
            Next
            co(lineas, 14) = dr("SALA")
            lineas = lineas + 1
        Next
        For i = 3 To 13
            co.Subtotal(AggregateEnum.Sum, -1, -1, i, "Subtotal")
        Next
    End Sub

    '=============================================== PRODUCCION  ================================================
    Private Sub llena_pr()
        Dim dt As New DataTable()
        Dim corte As String
        Dim tp As String
        Dim i As Integer
        Dim tipo As String
        Dim talla As String
        Dim strSQL As String = "SELECT PROD_DIARIA.CORTE,FECHA,TIPO,TALLA,SECCION,SUM(PRENDAS) AS PRENDAS FROM PROD_DIARIA LEFT JOIN CORTES ON PROD_DIARIA.CORTE = CORTES.CORTE WHERE CPO = '" & cpo.Text & "' AND ESTILO = '" & estilo.Text & "' AND COLOR = '" & colores.Text & "' GROUP BY PROD_DIARIA.CORTE,FECHA,TIPO,TALLA,SECCION ORDER BY FECHA,PROD_DIARIA.CORTE"
        llena_tablas(dt, strSQL, cnn)
        For Each Me.dr In dt.Rows
            corte = dr("CORTE")
            tp = dr("TIPO")
            talla = dr("TALLA")
            If tp = "0" Then
                tipo = "Pri"
            Else
                tipo = "Seg"
            End If
            lineas = pr.FindRow(corte + tipo, 1, 0, False)
            If lineas = -1 Then
                lineas = pr.Rows.Count
                pr.Rows.Count = lineas + 1
                pr(lineas, 0) = corte + tipo
            End If
            pr(lineas, 1) = corte
            pr(lineas, 2) = dr("FECHA")
            pr(lineas, 3) = tipo
            pr(lineas, 15) = dr("SECCION")
            i = Array.IndexOf(te, talla) + 4
            pr(lineas, i) = pr(lineas, i) + dr("PRENDAS")
            pr(lineas, 14) = pr(lineas, 14) + dr("PRENDAS")
        Next
        For i = 4 To 14
            pr.Subtotal(AggregateEnum.Sum, -1, -1, i, "Subtotal")
        Next
    End Sub

    '=============================================== EXPORTACION  ================================================
    Private Sub llena_ex()
        Dim dt As New DataTable()
        Dim corte As String
        Dim tp As String
        Dim i As Integer
        Dim tipo As String
        Dim embarque As String
        Dim strSQL As String = "SELECT * FROM PACKING_D WHERE CPO = '" & cpo.Text & "' AND ESTILO = '" & estilo.Text & "' AND COLOR = '" & colores.Text & "' ORDER BY FECHA,CORTE"
        llena_tablas(dt, strSQL, cnn)
        For Each Me.dr In dt.Rows
            corte = dr("CORTE")
            tp = dr("TIPO")
            embarque = dr("EMBARQUE")
            If tp = "Pri" Then
                tipo = "Pri"
            Else
                tipo = "Seg"
            End If
            lineas = ex.FindRow(corte + tipo + embarque, 1, 0, False)
            If lineas = -1 Then
                lineas = ex.Rows.Count
                ex.Rows.Count = lineas + 1
                ex(lineas, 0) = corte + tipo + embarque
            End If
            ex(lineas, 1) = corte
            ex(lineas, 2) = dr("FECHA")
            ex(lineas, 3) = tipo
            ex(lineas, 15) = embarque
            For i = 0 To 9
                ex(lineas, i + 4) = ex(lineas, i + 4) + dr(i + 8)
                ex(lineas, 14) = ex(lineas, 14) + dr(i + 8)
            Next
        Next
        For i = 4 To 14
            ex.Subtotal(AggregateEnum.Sum, -1, -1, i, "Subtotal")
        Next
    End Sub
End Class



