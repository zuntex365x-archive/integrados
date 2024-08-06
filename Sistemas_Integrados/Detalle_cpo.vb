Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO
Imports C1.C1Excel

Public Class Detalle_cpo
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
    Dim dr As DataRow
    Dim tl() As String
    Dim ts As String
    Dim prod As New DataTable
    Dim exp As New DataTable
    Dim prs As New DataTable

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
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents S1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Co As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Pr As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Ex As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Pe As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Clientes As System.Windows.Forms.TextBox
    Friend WithEvents _book As C1.C1Excel.C1XLBook
    Friend WithEvents Hoja As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Detalle_cpo))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Co = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Pr = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Ex = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Pe = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Clientes = New System.Windows.Forms.TextBox()
        Me.cpo = New System.Windows.Forms.ComboBox()
        Me.Hoja = New System.Windows.Forms.Button()
        Me.S1 = New System.Windows.Forms.Button()
        Me.R1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._book = New C1.C1Excel.C1XLBook()
        CType(Me.Co, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pe, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Co.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Co.Location = New System.Drawing.Point(8, 216)
        Me.Co.Name = "Co"
        Me.Co.Rows.DefaultSize = 19
        Me.Co.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Co.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Co.Size = New System.Drawing.Size(1107, 160)
        Me.Co.StyleInfo = resources.GetString("Co.StyleInfo")
        Me.Co.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Co.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.Co, "Area de Datos.")
        '
        'Pr
        '
        Me.Pr.AllowEditing = False
        Me.Pr.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Pr.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Pr.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Pr.ColumnInfo = resources.GetString("Pr.ColumnInfo")
        Me.Pr.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Pr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Pr.ForeColor = System.Drawing.Color.Black
        Me.Pr.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Pr.Location = New System.Drawing.Point(8, 392)
        Me.Pr.Name = "Pr"
        Me.Pr.Rows.DefaultSize = 19
        Me.Pr.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Pr.Size = New System.Drawing.Size(1107, 152)
        Me.Pr.StyleInfo = resources.GetString("Pr.StyleInfo")
        Me.Pr.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Pr.TabIndex = 48
        Me.ToolTip1.SetToolTip(Me.Pr, "Area de Datos.")
        '
        'Ex
        '
        Me.Ex.AllowEditing = False
        Me.Ex.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Ex.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Ex.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Ex.ColumnInfo = resources.GetString("Ex.ColumnInfo")
        Me.Ex.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Ex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Ex.ForeColor = System.Drawing.Color.Black
        Me.Ex.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Ex.Location = New System.Drawing.Point(8, 560)
        Me.Ex.Name = "Ex"
        Me.Ex.Rows.DefaultSize = 19
        Me.Ex.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Ex.Size = New System.Drawing.Size(1107, 152)
        Me.Ex.StyleInfo = resources.GetString("Ex.StyleInfo")
        Me.Ex.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Ex.TabIndex = 50
        Me.ToolTip1.SetToolTip(Me.Ex, "Area de Datos.")
        '
        'Pe
        '
        Me.Pe.AllowEditing = False
        Me.Pe.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Pe.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Pe.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Pe.ColumnInfo = resources.GetString("Pe.ColumnInfo")
        Me.Pe.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Pe.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Pe.ForeColor = System.Drawing.Color.Black
        Me.Pe.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Pe.Location = New System.Drawing.Point(8, 48)
        Me.Pe.Name = "Pe"
        Me.Pe.Rows.DefaultSize = 19
        Me.Pe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Pe.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Pe.Size = New System.Drawing.Size(1107, 152)
        Me.Pe.StyleInfo = resources.GetString("Pe.StyleInfo")
        Me.Pe.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Pe.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.Pe, "Area de Datos.")
        '
        'Clientes
        '
        Me.Clientes.BackColor = System.Drawing.Color.White
        Me.Clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clientes.Location = New System.Drawing.Point(403, 8)
        Me.Clientes.MaxLength = 10
        Me.Clientes.Name = "Clientes"
        Me.Clientes.ReadOnly = True
        Me.Clientes.Size = New System.Drawing.Size(232, 22)
        Me.Clientes.TabIndex = 60
        Me.ToolTip1.SetToolTip(Me.Clientes, "Cliente")
        '
        'cpo
        '
        Me.cpo.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cpo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpo.Location = New System.Drawing.Point(59, 8)
        Me.cpo.Name = "cpo"
        Me.cpo.Size = New System.Drawing.Size(229, 24)
        Me.cpo.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cpo, "CPO a consultar.")
        '
        'Hoja
        '
        Me.Hoja.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Hoja.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Hoja.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hoja.ForeColor = System.Drawing.Color.Black
        Me.Hoja.Image = CType(resources.GetObject("Hoja.Image"), System.Drawing.Image)
        Me.Hoja.Location = New System.Drawing.Point(896, 8)
        Me.Hoja.Name = "Hoja"
        Me.Hoja.Size = New System.Drawing.Size(35, 35)
        Me.Hoja.TabIndex = 83
        Me.Hoja.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Hoja, "Convierte a Excel")
        Me.Hoja.UseVisualStyleBackColor = False
        Me.Hoja.Visible = False
        '
        'S1
        '
        Me.S1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.S1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.S1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S1.ForeColor = System.Drawing.Color.Black
        Me.S1.Image = CType(resources.GetObject("S1.Image"), System.Drawing.Image)
        Me.S1.Location = New System.Drawing.Point(848, 8)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(35, 35)
        Me.S1.TabIndex = 57
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.S1, "Chequeo de Datos")
        Me.S1.UseVisualStyleBackColor = False
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(848, 8)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(35, 35)
        Me.R1.TabIndex = 55
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Cortado"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 376)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 14)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Producido"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 544)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
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
        Me.Label1.Location = New System.Drawing.Point(337, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 32)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Cliente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Detalle_cpo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1277, 907)
        Me.Controls.Add(Me.cpo)
        Me.Controls.Add(Me.Hoja)
        Me.Controls.Add(Me.Clientes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.S1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Pe)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Ex)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Pr)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Co)
        Me.Controls.Add(Me.R1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Detalle_cpo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Movimientos  de las CPO"
        CType(Me.Co, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pe, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub S1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S1.Click
        If cpo.Text <> "" Then
            ok = True
            busca_cpo(ok)
            If ok Then
                llena_prod_exp()
                llena_pe()
                llena_co()
                llena_pr()
                llena_EX()
                S1.Visible = False
                R1.Visible = True
                Hoja.Visible = True
                R1.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cpo.Text) <> "" Then
                S1.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub llena_prod_exp()
        llena_tablas(prod, "SELECT * FROM PROD_DIARIA LEFT JOIN CORTES ON PROD_DIARIA.CORTE = CORTES.CORTE WHERE PROD_DIARIA.CORTE IN (SELECT DISTINCT CORTE FROM CORTES WHERE CPO = '" & cpo.Text & "') ORDER BY PROD_DIARIA.CORTE,FECHA DESC", cnn)
        llena_tablas(exp, "SELECT * FROM PACKING_D WHERE CPO = '" & cpo.Text & "' ORDER BY CORTE,FECHA DESC", cnn)
        llena_tablas(prs, "SELECT * FROM CAJAS04 LEFT JOIN CORTES ON CAJAS04.CORTE = CORTES.CORTE WHERE CAJAS04.CORTE IN (SELECT DISTINCT CORTE FROM CORTES WHERE CPO = '" & cpo.Text & "') ORDER BY CAJAS04.CORTE,FECHA DESC", cnn)
    End Sub
    Private Sub busca_cpo(ByRef si As Boolean)
        Dim dt As New DataTable()
        Dim cliente As String
        Dim strSQL As String = "SELECT * FROM CPO WHERE CPO = '" & cpo.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        For Each Me.dr In dt.Rows
            si = True
            cliente = dr("CLIENTE")
            Clientes.Text = cliente
        Next
        If dt.Rows.Count = 0 Then
            si = False
            MsgBox("CPO no Existe !!!!", MsgBoxStyle.Critical, "Error en los Datos !!!")
        End If
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        Clientes.Text = ""
        S1.Visible = True
        R1.Visible = False
        Hoja.Visible = False
        setea_pe()
        setea_co()
        setea_pr()
        setea_EX()
        cpo.Focus()
    End Sub

    Private Sub setea_pe()
        Pe.Rows.Count = 1
        Pe.Cols(1).AllowMerging = True
        Pe.Cols(2).AllowMerging = True
        Pe.Rows(0).Height = 30
        talla_Grid(Pe, 3, True)
    End Sub

    Private Sub llena_pe()
        Dim dt As New DataTable()
        Dim estilo As String
        Dim colo As String
        Dim i As Integer
        Dim dato As String
        Dim total As Integer = 0
        Dim adulto As Boolean = True
        Dim strSQL As String = "SELECT * FROM CPO_D WHERE CPO = '" & cpo.Text & "' ORDER BY ESTILO, COLOR"
        llena_tablas(dt, strSQL, cnn)
        For Each Me.dr In dt.Rows
            estilo = dr("ESTILO")
            colo = dr("COLOR")
            lineas = Pe.Rows.Count
            Pe.Rows.Count = Pe.Rows.Count + 1
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
            If dr("ESCALA") <> "00" Then
                adulto = False
            End If
        Next
        talla_Grid(Pe, 3, adulto)
        talla_Grid(Co, 4, adulto)
        talla_Grid(Pr, 5, adulto)
        talla_Grid(Ex, 5, adulto)
    End Sub
    '=============================================== CORTE ================================================
    Private Sub setea_co()
        Dim index As Integer
        Co.Clear()
        Co.Rows.Count = 1
        Co.Cols.Count = 15
        Co.Cols(0).Width = 0
        Co.Rows(0).Height = 30
        Dim c As Column = Co.Cols(1)
        Co.Cols(1).Name = "ESTILO"
        Co.Cols(2).Name = "COLOR"
        Co.Cols(3).Name = "CORTE"
        Co.Cols(4).Name = "XS"
        Co.Cols(5).Name = "S"
        Co.Cols(6).Name = "M"
        Co.Cols(7).Name = "L"
        Co.Cols(8).Name = "XL"
        Co.Cols(9).Name = "2XL"
        Co.Cols(10).Name = "3XL"
        Co.Cols(11).Name = "4XL"
        Co.Cols(12).Name = "5XL"
        Co.Cols(13).Name = "6XL"
        Co.Cols(14).Name = "TOT."
        For index = 1 To Co.Cols.Count - 1
            Co.Cols(index).Width = 110
            Co(0, index) = Co.Cols(index).Name
            Co.Cols(index).TextAlign = TextAlignEnum.LeftCenter
            Co.Cols(index).TextAlignFixed = TextAlignEnum.LeftCenter
            If index > 3 Then
                Co.Cols(index).DataType = GetType(Integer)
                Co.Cols(index).Format = "######0"
                Co.Cols(index).Width = 55
                Co.Cols(index).TextAlign = TextAlignEnum.RightCenter
                Co.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
        Co.Cols(3).Width = 80
        Co.Cols(1).AllowMerging = True
        Co.Cols(2).AllowMerging = True
    End Sub

    Private Sub llena_co()
        Dim dt As New DataTable()
        Dim estilo As String
        Dim colo As String
        Dim i As Integer
        Dim dato As String
        Dim total As Integer = 0
        Dim strSQL As String = "SELECT * FROM CORTES WHERE CPO = '" & cpo.Text & "' ORDER BY ESTILO, COLOR, CORTE"
        llena_tablas(dt, strSQL, cnn)
        Co.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each Me.dr In dt.Rows
            estilo = dr("ESTILO")
            colo = dr("COLOR")
            total = 0
            Co(lineas, 1) = estilo
            Co(lineas, 2) = colo
            Co(lineas, 3) = dr("CORTE")
            For i = 0 To 9
                dato = te(i)
                Co(lineas, i + 4) = dr(dato)
                total = total + Co(lineas, i + 4)
            Next
            Co(lineas, 14) = total
            lineas = lineas + 1
        Next
        For i = 4 To 14
            Co.Subtotal(AggregateEnum.Sum, 1, 1, 2, i, "Subtotal")
            Co.Subtotal(AggregateEnum.Sum, 0, 0, 1, i, "Subtotal")
        Next
    End Sub

    '=============================================== PRODUCCION  ================================================

    Private Sub setea_pr()
        Dim index As Integer
        Pr.Clear()
        Pr.Rows.Count = 1
        Pr.Cols.Count = 18
        Pr.Cols(0).Width = 5
        Pr.Rows(0).Height = 30
        Dim c As Column = Co.Cols(1)
        Pr.Cols(1).Name = "ESTILO"
        Pr.Cols(2).Name = "COLOR"
        Pr.Cols(3).Name = "CORTE"
        Pr.Cols(4).Name = "SEGUN."
        Pr.Cols(5).Name = "XS"
        Pr.Cols(6).Name = "S"
        Pr.Cols(7).Name = "M"
        Pr.Cols(8).Name = "L"
        Pr.Cols(9).Name = "XL"
        Pr.Cols(10).Name = "2XL"
        Pr.Cols(11).Name = "3XL"
        Pr.Cols(12).Name = "4XL"
        Pr.Cols(13).Name = "5XL"
        Pr.Cols(14).Name = "6XL"
        Pr.Cols(15).Name = "TOT."
        For index = 1 To Pr.Cols.Count - 1
            Pr.Cols(index).Width = 100
            Pr(0, index) = Pr.Cols(index).Name
            If index > 3 Then
                Pr.Cols(index).DataType = GetType(Integer)
                Pr.Cols(index).Format = "######0"
                Pr.Cols(index).Width = 55
                Pr.Cols(index).TextAlign = TextAlignEnum.RightCenter
                Pr.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
        Pr.Cols(1).Width = 85
        Pr.Cols(3).Width = 60
        Pr.Cols(16).DataType = GetType(Date)
        Pr.Cols(16).Width = 80
        Pr.Cols(16).Caption = "F.PROD"
        Pr.Cols(16).TextAlign = TextAlignEnum.CenterCenter
        Pr.Cols(16).TextAlignFixed = TextAlignEnum.CenterCenter
        Pr.Cols(17).DataType = GetType(String)
        Pr.Cols(17).Width = 100
        Pr.Cols(17).Caption = "PLANTA"
        Pr.Cols(17).TextAlign = TextAlignEnum.LeftCenter
        Pr.Cols(17).TextAlignFixed = TextAlignEnum.LeftCenter
        Pr.Cols(1).AllowMerging = True
        Pr.Cols(2).AllowMerging = True
    End Sub

    Private Sub llena_pr()
        Dim dt As New DataTable()
        Dim estilo As String
        Dim colo As String
        Dim i As Integer
        Dim dato As String
        Dim seg As Integer = 0
        Dim total As Integer = 0
        Dim strSQL As String = "SELECT CORTES_P.CORTE AS CORTE , ESTILO,COLOR, P0,P1,P2,P3,P4,P5,P6,P7,P8,P9,S0,S1,S2,S3,S4,S5,S6,S7,S8,S9,SECCION,FPROD  FROM CORTES_P, CORTES WHERE CORTES.CORTE = CORTES_P.CORTE AND CORTES.CPO = '" & cpo.Text & "' ORDER BY ESTILO,COLOR,CORTES_P.CORTE"
        llena_tablas(dt, strSQL, cnn)
        Pr.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each Me.dr In dt.Rows
            estilo = dr("ESTILO")
            colo = dr("COLOR")
            seg = 0
            total = 0
            Pr(lineas, 1) = estilo
            Pr(lineas, 2) = colo
            Pr(lineas, 3) = dr("CORTE")
            Pr(lineas, 17) = dr("SECCION")
            Pr(lineas, 16) = dr("FPROD")
            For i = 0 To 9
                dato = "P" + CStr(i)
                Pr(lineas, i + 5) = Pr(lineas, i + 5) + dr(dato)
                seg = seg + dr("S" + CStr(i))
                total = total + Pr(lineas, i + 5)
            Next
            Pr(lineas, 4) = seg
            Pr(lineas, 15) = total + Pr(lineas, 4)
            busca_fecha(prod, Pr(lineas, 3), Pr(lineas, 16))
            Try
                busca_fecha(prs, Pr(lineas, 3), Pr(lineas, 16))
            Catch ex As Exception

            End Try
            lineas = lineas + 1
        Next
        For i = 4 To 15
            Pr.Subtotal(AggregateEnum.Sum, 1, 1, 2, i, "Subtotal")
            Pr.Subtotal(AggregateEnum.Sum, 0, 0, 1, i, "Subtotal")
        Next
    End Sub

    '=============================================== EXPORTACION  ================================================

    Private Sub setea_EX()
        Dim index As Integer
        Ex.Clear()
        Ex.Rows.Count = 1
        Ex.Cols.Count = 19
        Ex.Cols(0).Width = 5
        Ex.Rows(0).Height = 30
        Dim c As Column = Co.Cols(1)
        Ex.Cols(1).Name = "ESTILO"
        Ex.Cols(2).Name = "COLOR"
        Ex.Cols(3).Name = "CORTE"
        Ex.Cols(4).Name = "SEGUN."
        Ex.Cols(5).Name = "XS"
        Ex.Cols(6).Name = "S"
        Ex.Cols(7).Name = "M"
        Ex.Cols(8).Name = "L"
        Ex.Cols(9).Name = "XL"
        Ex.Cols(10).Name = "2XL"
        Ex.Cols(11).Name = "3XL"
        Ex.Cols(12).Name = "4XL"
        Ex.Cols(13).Name = "5XL"
        Ex.Cols(14).Name = "6XL"
        Ex.Cols(15).Name = "TOT."
        Ex.Cols(16).Name = "CLAVE"
        Ex.Cols(16).Visible = False
        Ex.Cols(18).Name = "PLANTA"
        For index = 1 To Ex.Cols.Count - 1
            Ex.Cols(index).Width = 100
            Ex(0, index) = Ex.Cols(index).Name
            If index > 3 And index < 16 Then
                Ex.Cols(index).DataType = GetType(Integer)
                Ex.Cols(index).Format = "######0"
                Ex.Cols(index).Width = 55
                Ex.Cols(index).TextAlign = TextAlignEnum.RightCenter
                Ex.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
        Ex.Cols(1).Width = 85
        Ex.Cols(3).Width = 60
        Ex.Cols(17).Width = 80
        Ex.Cols(18).Width = 100
        Ex.Cols(17).DataType = GetType(Date)
        Ex.Cols(17).Width = 80
        Ex.Cols(17).Caption = "F.EXP."
        Ex.Cols(17).TextAlign = TextAlignEnum.CenterCenter
        Ex.Cols(17).TextAlignFixed = TextAlignEnum.CenterCenter
        Ex.Cols(1).AllowMerging = True
        Ex.Cols(2).AllowMerging = True
    End Sub

    Private Sub llena_EX()
        Dim dt As New DataTable()
        Dim estilo As String
        Dim colo As String
        Dim i As Integer
        Dim dato As String
        Dim seg As Integer
        Dim total As Integer = 0
        Dim strSQL As String = "SELECT CORTES_E.CORTE AS CORTE , ESTILO,COLOR, P0,P1,P2,P3,P4,P5,P6,P7,P8,P9,S0,S1,S2,S3,S4,S5,S6,S7,S8,S9,SECCION  FROM CORTES_E, CORTES WHERE CORTES.CORTE = CORTES_E.CORTE AND CORTES.CPO = '" & cpo.Text & "' ORDER BY ESTILO,COLOR,CORTES_E.CORTE"
        llena_tablas(dt, strSQL, cnn)
        Ex.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each Me.dr In dt.Rows
            estilo = dr("ESTILO")
            colo = dr("COLOR")
            seg = 0
            total = 0
            Ex(lineas, 1) = estilo
            Ex(lineas, 2) = colo
            Ex(lineas, 3) = dr("CORTE")
            Ex(lineas, 18) = dr("SECCION")
            For i = 0 To 9
                dato = "P" + CStr(i)
                Ex(lineas, i + 5) = Ex(lineas, i + 5) + dr(dato)
                seg = seg + dr("S" + CStr(i))
                total = total + Ex(lineas, i + 5)
            Next
            Ex(lineas, 4) = seg
            Ex(lineas, 15) = total + seg
            Ex(lineas, 16) = estilo + colo + dr("CORTE")
            busca_fecha(exp, Ex(lineas, 3), Ex(lineas, 17))
            lineas = lineas + 1
        Next
        stock()
        Ex.Sort(SortFlags.Ascending, 16)
        For i = 4 To 15
            Ex.Subtotal(AggregateEnum.Sum, 1, 1, 2, i, "Subtotal")
            Ex.Subtotal(AggregateEnum.Sum, 0, 0, 1, i, "Subtotal")
        Next
    End Sub

    Private Sub stock()
        Dim dt As New DataTable()
        Dim talla As String
        Dim tipo As String
        Dim prendas As Integer
        Dim estil As String
        Dim col As String
        Dim i As Integer
        Dim re(9) As String
        Dim busca As String
        Dim tallas As String = "XS,S,M,L,XL,2XL,3XL,4XL,5XL,6XL"
        re = Split(tallas, ","c)
        Dim strSQL As String = "SELECT CPO,ESTILO,COLOR,TIPO,TALLA,SUM(PRENDAS) AS PRENDA, EMBARQUE FROM S_STOCK WHERE CPO = '" & cpo.Text & "' GROUP BY CPO,ESTILO,COLOR,TIPO,TALLA,CLIENTE,EMBARQUE "
        llena_tablas(dt, strSQL, cnn)
        For Each Me.dr In dt.Rows
            estil = dr("ESTILO")
            col = dr("COLOR")
            busca = estil + col + "STOCK"
            si = Ex.FindRow(busca, 1, 16, True)
            If si = -1 Then
                si = Ex.Rows.Count
                Ex.Rows.Count = Ex.Rows.Count + 1
                Ex(si, 16) = busca
                Ex(si, 1) = estil
                Ex(si, 2) = col
                Ex(si, 3) = "STOCK"
            End If
            tipo = dr("TIPO")
            talla = dr("TALLA")
            prendas = dr("PRENDA")
            i = Array.IndexOf(re, talla)
            If tipo = "00" Then
                Ex(si, i + 5) = Ex(si, i + 5) + prendas
                Ex(si, 15) = Ex(si, 15) + prendas
            Else
                Ex(si, 4) = Ex(si, 4) + prendas
            End If
        Next
    End Sub

    Private Sub Hoja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hoja.Click
        'Dim nombre As String = cpo.Text
        'adios(nombre)
        'Dim path As String = "c:\reportes\Cpo_" + nombre + ".xls"
        'Try
        '    If File.Exists(path) Then
        '        File.Delete(path)
        '    End If
        'Catch
        'End Try
        'Pe.Subtotal(AggregateEnum.Clear)
        'Co.Subtotal(AggregateEnum.Clear)
        'Pr.Subtotal(AggregateEnum.Clear)
        'Ex.Subtotal(AggregateEnum.Clear)

        'Try
        '    _book.Clear()
        '    _book.Sheets.Clear()
        '    _book.DefaultFont = New Font("Tahoma", 10)
        '    Dim sheet As XLSheet = _book.Sheets.Add("Ordenado")
        '    sheet.DefaultRowHeight = 15
        '    SaveSheet(_book, Pe, sheet, True)
        '    _book.Sheets.SelectedIndex = 0
        '    sheet = _book.Sheets.Add("Cortado")
        '    SaveSheet(_book, Co, sheet, True)
        '    sheet = _book.Sheets.Add("Producido")
        '    SaveSheet(_book, Pr, sheet, True)
        '    sheet = _book.Sheets.Add("exportado")
        '    SaveSheet(_book, Ex, sheet, True)
        '    _book.Save(path)
        '    System.Diagnostics.Process.Start(path)
        '    MsgBox("Sus datos fueron trasladados a Excel en el directorio: " + path, MsgBoxStyle.OKOnly, "TRASLADO DE DATOS ")
        'Catch
        '    MsgBox("Por favor cierre todas sus Hojas de Excel y vuelva a tratar. Gracias", MsgBoxStyle.OKOnly, "Atencion ")
        'End Try
        'Close()
    End Sub

    Private Sub busca_fecha(ByVal tabla As DataTable, ByVal corte As String, ByRef fecha As Date)
        Dim dd As DataRow()
        Dim dr As DataRow
        dd = tabla.Select("CORTE = '" & corte & "'")
        If dd.Length > 0 Then
            dr = dd(0)
            fecha = dr("FECHA")
        End If
    End Sub
    Private Sub cpo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cpo.KeyPress
        AutoCompletar(cpo, e)
    End Sub

    Private Sub Co_Click(sender As System.Object, e As System.EventArgs) Handles Co.Click
        Dim l As Integer = Co.RowSel
        Dim forma As New Cortes_Detalle_1
        If Co(l, 3) <> "" Then
            forma.corte.Text = Co(l, 3)
            forma.ShowDialog()
        End If
    End Sub

    Private Sub Pr_Click(sender As System.Object, e As System.EventArgs) Handles Pr.Click
        Dim l As Integer = Pr.RowSel
        Dim forma As New Cortes_Detalle_1
        If Pr(l, 3) <> "" Then
            forma.corte.Text = Co(l, 3)
            forma.ShowDialog()
        End If
    End Sub

    Private Sub Ex_Click(sender As System.Object, e As System.EventArgs) Handles Ex.Click
        Dim l As Integer = Ex.RowSel
        Dim forma As New Cortes_Detalle_1
        If Ex(l, 3) <> "" Then
            forma.corte.Text = Ex(l, 3)
            forma.ShowDialog()
        End If
    End Sub

    Private Sub Pe_Click(sender As System.Object, e As System.EventArgs) Handles Pe.Click
        Dim l As Integer = Pe.RowSel
        Dim forma As New Cpo_con2
        If Pe(l, 1) <> "" Then
            forma.cpos.Text = cpo.Text
            forma.estilos.Text = Pe(l, 1)
            forma.colores.Text = Pe(l, 2)
            forma.ShowDialog()
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class



