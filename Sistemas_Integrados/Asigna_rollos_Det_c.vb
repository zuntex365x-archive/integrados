Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Asigna_rollos_Det_c
    Inherits System.Windows.Forms.Form
    Public cliente As String
    Public cpo As String
    Public estilo As String
    Public colo As String
    Public knit As String
    Public colot As String
    Public prendas As Integer
    Public fp As C1.Win.C1FlexGrid.C1FlexGrid
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim si As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim estados As New ComboBox()
    Dim nec As Integer

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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents colors As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cpos As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Estilos As System.Windows.Forms.Label
    Friend WithEvents GRABA As System.Windows.Forms.Button
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents Ta As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Co As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Stock As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Asigna_rollos_Det_c))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GRABA = New System.Windows.Forms.Button()
        Me.R1 = New System.Windows.Forms.Button()
        Me.Ta = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Co = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Stock = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Estilos = New System.Windows.Forms.Label()
        Me.colors = New System.Windows.Forms.Label()
        Me.cpos = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Co, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 176)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(984, 392)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'GRABA
        '
        Me.GRABA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GRABA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GRABA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRABA.ForeColor = System.Drawing.Color.Black
        Me.GRABA.Image = CType(resources.GetObject("GRABA.Image"), System.Drawing.Image)
        Me.GRABA.Location = New System.Drawing.Point(912, 8)
        Me.GRABA.Name = "GRABA"
        Me.GRABA.Size = New System.Drawing.Size(35, 35)
        Me.GRABA.TabIndex = 74
        Me.GRABA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.GRABA, "Presione este Boton para Grabar todos los datos Ingresados.")
        Me.GRABA.UseVisualStyleBackColor = False
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(952, 8)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(35, 35)
        Me.R1.TabIndex = 75
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Salir sin efectuar modificaciones.")
        Me.R1.UseVisualStyleBackColor = False
        '
        'Ta
        '
        Me.Ta.AllowEditing = False
        Me.Ta.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Ta.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Ta.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Ta.ColumnInfo = resources.GetString("Ta.ColumnInfo")
        Me.Ta.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Ta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Ta.ForeColor = System.Drawing.Color.Black
        Me.Ta.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Ta.Location = New System.Drawing.Point(8, 56)
        Me.Ta.Name = "Ta"
        Me.Ta.Rows.DefaultSize = 19
        Me.Ta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Ta.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Ta.Size = New System.Drawing.Size(976, 96)
        Me.Ta.StyleInfo = resources.GetString("Ta.StyleInfo")
        Me.Ta.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Ta.TabIndex = 76
        Me.ToolTip1.SetToolTip(Me.Ta, "Area de Datos.")
        '
        'Co
        '
        Me.Co.AllowEditing = False
        Me.Co.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.Co.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.Co.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Co.ColumnInfo = resources.GetString("Co.ColumnInfo")
        Me.Co.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.Co.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Co.ForeColor = System.Drawing.Color.Black
        Me.Co.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Co.Location = New System.Drawing.Point(8, 592)
        Me.Co.Name = "Co"
        Me.Co.Rows.DefaultSize = 19
        Me.Co.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Co.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Co.Size = New System.Drawing.Size(984, 92)
        Me.Co.StyleInfo = resources.GetString("Co.StyleInfo")
        Me.Co.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.Co.TabIndex = 78
        Me.ToolTip1.SetToolTip(Me.Co, "Area de Datos.")
        '
        'Stock
        '
        Me.Stock.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Stock.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Stock.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stock.ForeColor = System.Drawing.Color.Black
        Me.Stock.Image = CType(resources.GetObject("Stock.Image"), System.Drawing.Image)
        Me.Stock.Location = New System.Drawing.Point(872, 8)
        Me.Stock.Name = "Stock"
        Me.Stock.Size = New System.Drawing.Size(35, 35)
        Me.Stock.TabIndex = 80
        Me.Stock.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Stock, "Presione este Boton para Grabar todos los Rollos escogidos en el Stock ")
        Me.Stock.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(232, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 24)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Estilo:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 16)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Inventario de Tela"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(512, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Color:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Estilos
        '
        Me.Estilos.BackColor = System.Drawing.Color.White
        Me.Estilos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Estilos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Estilos.Location = New System.Drawing.Point(288, 8)
        Me.Estilos.Name = "Estilos"
        Me.Estilos.Size = New System.Drawing.Size(192, 24)
        Me.Estilos.TabIndex = 70
        Me.Estilos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colors
        '
        Me.colors.BackColor = System.Drawing.Color.White
        Me.colors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.colors.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colors.Location = New System.Drawing.Point(568, 8)
        Me.colors.Name = "colors"
        Me.colors.Size = New System.Drawing.Size(280, 24)
        Me.colors.TabIndex = 71
        Me.colors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cpos
        '
        Me.cpos.BackColor = System.Drawing.Color.White
        Me.cpos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cpos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cpos.Location = New System.Drawing.Point(64, 8)
        Me.cpos.Name = "cpos"
        Me.cpos.Size = New System.Drawing.Size(144, 24)
        Me.cpos.TabIndex = 73
        Me.cpos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 24)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "CPO:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 16)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Necesidad de Tela"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 576)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 16)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "FPO's"
        '
        'Asigna_rollos_Det_c
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1002, 696)
        Me.Controls.Add(Me.Stock)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Co)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Ta)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.GRABA)
        Me.Controls.Add(Me.cpos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.colors)
        Me.Controls.Add(Me.Estilos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Asigna_rollos_Det_c"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asigna Rollos a las CPO"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Co, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Overloads Sub Bal_tela_Det(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cursor = Cursors.WaitCursor
        Estado_Tela(cnn, estados)
        cpos.Text = cpo
        Estilos.Text = estilo
        colors.Text = colo
        nec = prendas
        setea_Ta()
        llena_ta()
        setea_fg()
        setea_co()
        llena_fg()
        Cursor = Cursors.Default
    End Sub

    Private Sub setea_Ta()
        Dim index As Integer
        Ta.Clear()
        Ta.Rows.Count = 1
        Ta.Cols.Count = 9
        Ta.Cols(0).Width = 5
        Ta.Rows(0).Height = 30
        Dim c As Column = Ta.Cols(1)
        Ta.Cols(1).Name = "TELA"
        Ta.Cols(2).Name = "COLOR"
        Ta.Cols(3).Name = "CONSUMO"
        Ta.Cols(4).Name = "T.NECESA."
        Ta.Cols(5).Name = "T.CORTADA."
        Ta.Cols(6).Name = "ASIGNADAS"
        Ta.Cols(7).Name = "DIFERENCIA"
        For index = 1 To Ta.Cols.Count - 1
            Ta.Cols(index).Width = 210
            Ta(0, index) = Ta.Cols(index).Name
            Ta.Cols(index).AllowEditing = False
            If index > 2 And index < 8 Then
                Ta.Cols(index).DataType = GetType(Decimal)
                Ta.Cols(index).Format = "######0.00"
                Ta.Cols(index).Width = 105
                Ta.Cols(index).TextAlign = TextAlignEnum.RightCenter
                Ta.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next index
        Ta.Cols(1).Width = 300
        Ta.Cols(2).Width = 110
        Ta.Cols(8).Visible = False
    End Sub

    Private Sub llena_ta()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String = "SELECT CONSUMO_TELA.CODIGO,DESCRIPCION, COLOR_TELA, LIBRAS FROM CONSUMO_TELA LEFT JOIN CODIGO_TELA ON CODIGO_TELA.CODIGO = CONSUMO_TELA.CODIGO WHERE ESTILO_CPO = '" & Estilos.Text & "' AND COLOR_CPO = '" & colors.Text & "' AND CLIENTE = '" & cliente & "'"
        llena_tablas(dt, strSQL, cnn)
        Ta.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each dr In dt.Rows
            Ta(lineas, 1) = dr("DESCRIPCION")
            Ta(lineas, 2) = dr("COLOR_TELA")
            Ta(lineas, 3) = dr("LIBRAS")
            Ta(lineas, 4) = Ta(lineas, 3) * nec
            Ta(lineas, 8) = dr("CODIGO")
            Ta(lineas, 0) = Trim(Ta(lineas, 1)) + Trim(Ta(lineas, 2))
            lineas = lineas + 1
        Next
        necesarias()
    End Sub

    Private Sub necesarias()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim cortadas As Integer
        Dim strSQL As String = "SELECT SUM(TOTAL)AS CORTADAS FROM CORTES WHERE CPO = '" & cpos.Text & "' AND ESTILO = '" & Estilos.Text & "' AND COLOR = '" & colors.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            Try
                cortadas = dr("CORTADAS")
            Catch
            End Try
        Next
        Tela_usada()
    End Sub

    Private Sub setea_fg()
        Dim index As Integer
        fg.Clear()
        fg.Rows.Count = 1
        fg.Cols.Count = 12
        fg.Cols(0).Width = 5
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Name = "BATCH"
        fg.Cols(2).Name = "ROLLO"
        fg.Cols(3).Name = "TELA"
        fg.Cols(4).Name = "COLOR"
        fg.Cols(5).Name = "FPO"
        fg.Cols(6).Name = "CPO"
        fg.Cols(7).Name = "ESTILO"
        fg.Cols(8).Name = "ESTADO"
        fg.Cols(9).Name = "LIBRAS"
        fg.Cols(10).Name = "RESERVAR"
        fg.Cols(11).Name = "ANCHO"
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 80
            fg(0, index) = fg.Cols(index).Name
            fg.Cols(index).AllowEditing = False
            If index = 9 Then
                fg.Cols(index).DataType = GetType(Decimal)
                fg.Cols(index).Format = "######0.00"
                fg.Cols(index).Width = 75
                fg.Cols(index).TextAlign = TextAlignEnum.RightCenter
                fg.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
            If index = 10 Then
                fg.Cols(index).DataType = GetType(Boolean)
                fg.Cols(index).TextAlign = TextAlignEnum.CenterCenter
                fg.Cols(index).TextAlignFixed = TextAlignEnum.CenterCenter
                fg.Cols(index).AllowEditing = True
            End If
        Next
        fg.Cols(2).Width = 50
        fg.Cols(3).Width = 300
        fg.Cols(4).Width = 100
        fg.Cols(10).Width = 80
        fg.Cols(7).Visible = False
        fg.Cols(2).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(2).TextAlignFixed = TextAlignEnum.CenterCenter
    End Sub

    Private Sub setea_co()
        Dim index As Integer
        Co.Clear()
        Co.Rows.Count = 1
        Co.Cols.Count = 8
        Co.Cols(0).Width = 5
        Co.Rows(0).Height = 30
        Dim c As Column = Co.Cols(1)
        Co.Cols(1).Name = "FPO"
        Co.Cols(2).Name = "TELA"
        Co.Cols(3).Name = "COLOR"
        Co.Cols(4).Name = "LOTE"
        Co.Cols(5).Name = "CPO"
        Co.Cols(6).Name = "ESTILO"
        Co.Cols(7).Name = "LIBRAS"
        For index = 1 To Co.Cols.Count - 1
            Co.Cols(index).Width = 88
            Co(0, index) = Co.Cols(index).Name
            Co.Cols(index).AllowEditing = False
            If index = 7 Then
                Co.Cols(index).DataType = GetType(Decimal)
                Co.Cols(index).Format = "######0.00"
                Co.Cols(index).Width = 85
                Co.Cols(index).TextAlign = TextAlignEnum.RightCenter
                Co.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
        Co.Cols(1).Width = 100
        Co.Cols(2).Width = 350
        Co.Cols(3).Width = 150
        Co.Cols(4).Width = 80
    End Sub

    Private Sub busca_fpos(ByVal codigo As String, ByVal color_t As String, ByVal l As Integer)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String = "SELECT FPO.*, DESCRIPCION FROM FPO LEFT JOIN CODIGO_TELA ON FPO.CODIGO = CODIGO_TELA.CODIGO WHERE FPO.CODIGO = '" & codigo & "' AND COLOR = '" & color_t & "' AND STATUS = 'ABIERTO'"
        llena_tablas(dt, strSQL, cnn)
        lineas = Co.Rows.Count
        Co.Rows.Count = Co.Rows.Count + dt.Rows.Count
        For Each dr In dt.Rows
            Co(lineas, 1) = dr("FPO")
            Co(lineas, 2) = dr("DESCRIPCION")
            Co(lineas, 3) = dr("COLOR")
            Co(lineas, 4) = dr("LOTE")
            Co(lineas, 5) = dr("CPO")
            Co(lineas, 6) = dr("ESTILO")
            Co(lineas, 7) = dr("LIBRAS")
            lineas = lineas + 1
        Next
    End Sub

    Private Sub llena_fg()
        Dim i As Integer
        For i = 1 To Ta.Rows.Count - 1
            busca_telas(Ta(i, 8), Ta(i, 2), i)
            busca_fpos(Ta(i, 8), Ta(i, 2), i)
            Ta(i, 7) = Ta(i, 4) - Ta(i, 5) - Ta(i, 6)
        Next
        fg.Sort(SortFlags.Ascending, 1)
    End Sub

    Private Sub busca_telas(ByVal codigo As String, ByVal color_t As String, ByVal l As Integer)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim estado As String
        Dim i As Integer
        Dim strSQL As String = "SELECT ROLLOS.* ,((ROLLOS.PESO/ROLLOS.YARDAS_I) * ROLLOS.YARDAS) AS LIBRAS,DESCRIPCION FROM ROLLOS LEFT JOIN CODIGO_TELA ON ROLLOS.CODIGO = CODIGO_TELA.CODIGO WHERE ROLLOS.CODIGO = '" & codigo & "' AND COLOR = '" & color_t & "' AND ACTIVO <> 'N' AND YARDAS > 0 AND CLIENTE = '" & cliente & "' ORDER BY BATCH,ROLLO"
        llena_tablas(dt, strSQL, cnn)
        lineas = fg.Rows.Count
        fg.Rows.Count = fg.Rows.Count + dt.Rows.Count
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("BATCH")
            fg(lineas, 2) = dr("ROLLO")
            fg(lineas, 3) = dr("DESCRIPCION")
            fg(lineas, 4) = dr("COLOR")
            fg(lineas, 5) = dr("FPO")
            fg(lineas, 6) = dr("CPO")
            estado = dr("ACTIVO")
            If estado = "S" Then
                estado = 0
            End If
            fg(lineas, 8) = estados.Items.Item(estado)
            fg(lineas, 9) = dr("LIBRAS")
            fg(lineas, 0) = Trim(fg(lineas, 3)) + Trim(fg(lineas, 4)) + Trim(fg(lineas, 5)) + Trim(fg(lineas, 6))
            i = fp.FindRow(Trim(fg(lineas, 6)), 1, 1, True)
            If i > 0 Then
                fg(lineas, 7) = fp(i, 2)
            End If
            If Trim(fg(lineas, 6)) = Trim(cpo) Then
                fg(lineas, 10) = True
                Ta(l, 6) = Ta(l, 6) + fg(lineas, 9)
            End If
            fg(lineas, 11) = dr("ANCHO")
            lineas = lineas + 1
        Next
    End Sub

    Private Sub fg_ValidateEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.ValidateEditEventArgs) Handles fg.ValidateEdit
        If e.Col = 10 Then
            If fg(e.Row, e.Col) = True Then
                resta(e.Row)
            Else
                suma(e.Row)
            End If
        End If
    End Sub

    Private Sub suma(ByVal i As Integer)
        Dim p As Integer
        p = Ta.FindRow(Trim(fg(i, 3)) + Trim(fg(i, 4)), 1, 0, True)
        Ta(p, 6) = Ta(p, 6) + fg(i, 9)
        Ta(p, 7) = Ta(p, 4) - Ta(p, 5) - Ta(p, 6)
    End Sub

    Private Sub resta(ByVal i As Integer)
        Dim p As Integer
        p = Ta.FindRow(Trim(fg(i, 3)) + Trim(fg(i, 4)), 1, 0, True)
        Ta(p, 6) = Ta(p, 6) - fg(i, 9)
        Ta(p, 7) = Ta(p, 4) - Ta(p, 5) - Ta(p, 6)
    End Sub

    Private Sub Tela_usada()
        Try
            Dim dt As New DataTable()
            Dim dr As DataRow
            Dim knit As String
            Dim color As String
            Dim libras As Decimal
            Dim r As Integer
            Dim strSQL As String = "SELECT(SELECT DESCRIPCION  FROM ROLLOS,CODIGO_TELA WHERE DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLO AND ROLLOS.CODIGO = CODIGO_TELA.CODIGO) AS KNIT, (SELECT COLOR FROM ROLLOS WHERE DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLO) AS COLOR, LIBRAS FROM DMOVTO WHERE TMOVTO ='4' AND CORTE IN (SELECT CORTE FROM CORTES WHERE CPO = '" & cpo & "' AND ESTILO = '" & estilo & "' AND COLOR = '" & colo & "') ORDER BY KNIT, COLOR"
            llena_tablas(dt, strSQL, cnn)
            For Each dr In dt.Rows
                knit = dr("KNIT")
                color = dr("COLOR")
                libras = dr("LIBRAS")
                r = Ta.FindRow(Trim(knit) + Trim(color), 1, 0, True)
                If r > 0 Then
                    Ta(r, 5) = Ta(r, 5) + libras
                End If
            Next
        Catch
        End Try
    End Sub
    '=============================================== Inventario ================================================

    Private Sub GRABA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRABA.Click
        transaccion(cnn, "cpo")
        Close()
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        Close()
    End Sub

    Private Sub Stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Stock.Click
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        seguro = MsgBox("Seguro de colocar estos rollos en el Stock?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            transaccion(cnn, "stock")
        End If
        Close()
    End Sub


    Private Sub transaccion(ByVal cnn As SqlClient.SqlConnection, ByVal tipo As String)
        Dim afectados As Integer
        Dim i As Integer
        Dim strsql As String
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try

            For i = 1 To fg.Rows.Count - 1
                If fg(i, 10) = True Then
                    If tipo = "stock" Then
                        strsql = "UPDATE ROLLOS SET CPO = " & "'Stock'" & _
                                 "WHERE BATCH = '" & fg(i, 1) & "' AND ROLLO = '" & fg(i, 2) & "'"
                    Else
                        strsql = "UPDATE ROLLOS SET CPO = " & "'" & cpo & "' " & _
                                 "WHERE BATCH = '" & fg(i, 1) & "' AND ROLLO = '" & fg(i, 2) & "'"
                    End If
                    comando.CommandText = strsql
                    afectados = comando.ExecuteNonQuery()
                End If
            Next

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() & _
                                      " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub
End Class



