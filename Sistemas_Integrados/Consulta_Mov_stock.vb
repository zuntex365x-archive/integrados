Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized
Imports System.Math

Public Class Consulta_Mov_Stock
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tipo As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents mv As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Prendas As System.Windows.Forms.Label
    Friend WithEvents Cliente As System.Windows.Forms.Label
    Friend WithEvents Talla As System.Windows.Forms.Label
    Friend WithEvents colo As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Estilo As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consulta_Mov_Stock))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mv = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Prendas = New System.Windows.Forms.Label()
        Me.Cliente = New System.Windows.Forms.Label()
        Me.Talla = New System.Windows.Forms.Label()
        Me.tipo = New System.Windows.Forms.Label()
        Me.colo = New System.Windows.Forms.Label()
        Me.Estilo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.mv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(912, 632)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 29
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton para Regresar a escoger Material. ")
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 672)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(456, 16)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Presione Doble Click para consultar."
        '
        'mv
        '
        Me.mv.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.mv.AllowEditing = False
        Me.mv.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.mv.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.mv.ColumnInfo = resources.GetString("mv.ColumnInfo")
        Me.mv.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.mv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mv.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.mv.Location = New System.Drawing.Point(8, 176)
        Me.mv.Name = "mv"
        Me.mv.Rows.DefaultSize = 18
        Me.mv.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.mv.Size = New System.Drawing.Size(960, 448)
        Me.mv.StyleInfo = resources.GetString("mv.StyleInfo")
        Me.mv.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.mv.TabIndex = 28
        Me.mv.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Prendas)
        Me.GroupBox1.Controls.Add(Me.Cliente)
        Me.GroupBox1.Controls.Add(Me.Talla)
        Me.GroupBox1.Controls.Add(Me.tipo)
        Me.GroupBox1.Controls.Add(Me.colo)
        Me.GroupBox1.Controls.Add(Me.Estilo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(952, 160)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(824, 112)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(88, 26)
        Me.DateTimePicker1.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(672, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 24)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Consultar Desde:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Prendas
        '
        Me.Prendas.BackColor = System.Drawing.Color.White
        Me.Prendas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Prendas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prendas.ForeColor = System.Drawing.Color.Black
        Me.Prendas.Location = New System.Drawing.Point(824, 24)
        Me.Prendas.Name = "Prendas"
        Me.Prendas.Size = New System.Drawing.Size(120, 24)
        Me.Prendas.TabIndex = 21
        Me.Prendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cliente
        '
        Me.Cliente.BackColor = System.Drawing.Color.White
        Me.Cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cliente.ForeColor = System.Drawing.Color.Black
        Me.Cliente.Location = New System.Drawing.Point(144, 120)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(152, 24)
        Me.Cliente.TabIndex = 18
        Me.Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Talla
        '
        Me.Talla.BackColor = System.Drawing.Color.White
        Me.Talla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Talla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Talla.ForeColor = System.Drawing.Color.Black
        Me.Talla.Location = New System.Drawing.Point(144, 96)
        Me.Talla.Name = "Talla"
        Me.Talla.Size = New System.Drawing.Size(152, 24)
        Me.Talla.TabIndex = 17
        Me.Talla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tipo
        '
        Me.tipo.BackColor = System.Drawing.Color.White
        Me.tipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipo.ForeColor = System.Drawing.Color.Black
        Me.tipo.Location = New System.Drawing.Point(144, 72)
        Me.tipo.Name = "tipo"
        Me.tipo.Size = New System.Drawing.Size(440, 24)
        Me.tipo.TabIndex = 16
        Me.tipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'colo
        '
        Me.colo.BackColor = System.Drawing.Color.White
        Me.colo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.colo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colo.ForeColor = System.Drawing.Color.Black
        Me.colo.Location = New System.Drawing.Point(144, 48)
        Me.colo.Name = "colo"
        Me.colo.Size = New System.Drawing.Size(440, 24)
        Me.colo.TabIndex = 15
        Me.colo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Estilo
        '
        Me.Estilo.BackColor = System.Drawing.Color.White
        Me.Estilo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Estilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Estilo.ForeColor = System.Drawing.Color.Black
        Me.Estilo.Location = New System.Drawing.Point(144, 16)
        Me.Estilo.Name = "Estilo"
        Me.Estilo.Size = New System.Drawing.Size(120, 24)
        Me.Estilo.TabIndex = 14
        Me.Estilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 24)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Talla:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(696, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 24)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Existencia:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Cliente:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tipo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Color:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 24)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Estilo:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 12)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(970, 657)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 55
        Me.fg.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'Consulta_Mov_Stock
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(990, 692)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mv)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Consulta_Mov_Stock"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Movimientos Inventario de Stock"
        CType(Me.mv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim h As String = "#######0.00"
    Dim g As String = "######0"
    Dim r As String = "00000000"
    Dim x As String = "MM/dd/yyyy"
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim tipos As String
    Private Sub Inventario_Mat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        setea_grid()
    End Sub

    Private Sub setea_grid()
        Dim index As Integer
        fg.Clear()
        fg.Rows.Count = 1
        fg.Cols.Count = 7
        fg.Cols(0).Width = 0
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Name = "ESTILO"
        fg.Cols(2).Name = "COLOR"
        fg.Cols(3).Name = "TIPO"
        fg.Cols(4).Name = "TALLA"
        fg.Cols(5).Name = "CLIENTE"
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 150
            fg(0, index) = fg.Cols(index).Name
        Next
        fg.Cols(2).Width = 200
        fg.Cols(3).Width = 290
        fg.Cols(6).Visible = False
        llena_fg()
    End Sub

    Private Sub llena_fg()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String
        strSQL = "SELECT STOCK.* , (SELECT DESCRIPCION FROM TIPO_STOCK WHERE STOCK.TIPO = TIPO_STOCK.TIPO) AS DESCRIPCION FROM STOCK " 'WHERE UNIDADES <> 0 "
        llena_tablas(dt, strSQL, cnn)
        lineas = 1
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(lineas, 0) = dr("TIPO")
            fg(lineas, 1) = dr("ESTILO")
            fg(lineas, 2) = dr("COLOR")
            fg(lineas, 3) = dr("DESCRIPCION")
            fg(lineas, 4) = dr("TALLA")
            fg(lineas, 5) = dr("CLIENTE")
            fg(lineas, 6) = dr("UNIDADES")
            lineas = lineas + 1
        Next
    End Sub

 

    Private Sub despliega_prendas()
        Dim lin As Integer
        lin = fg.RowSel
        fg.Visible = False
        Label1.Visible = False
        Button3.Visible = True
        llena_datos(lin)
        setea_mv()
    End Sub

    Private Sub llena_datos(ByVal linea As Integer)
        Estilo.Text = fg(linea, 1)
        colo.Text = fg(linea, 2)
        Prendas.Text = fg(linea, 6)
        tipos = fg(linea, 0)
        Talla.Text = fg(linea, 4)
        Cliente.Text = fg(linea, 5)
        tipo.Text = fg(linea, 3)
    End Sub

    Private Sub setea_mv()
        Dim index As Integer
        mv.Clear()
        mv.Rows.Count = 1
        mv.Cols.Count = 8
        mv.Cols(0).Width = 0
        mv.Rows(0).Height = 30
        mv.ScrollBars = ScrollBars.None
        Dim c As Column = mv.Cols(1)
        mv.Cols(1).Name = "FECHA"
        mv.Cols(index).DataType = GetType(Date)
        mv.Cols(2).Name = "TIPO MOV."
        mv.Cols(3).Name = "CORTE"
        mv.Cols(4).Name = "EMBARQUE"
        mv.Cols(5).Name = "CPO"
        mv.Cols(6).Name = "ENTRADAS"
        mv.Cols(7).Name = "SALIDAS"
        For index = 1 To mv.Cols.Count - 1
            mv.Cols(index).Width = 133
            mv(0, index) = mv.Cols(index).Name
            If index > 5 Then
                mv.Cols(index).TextAlign = TextAlignEnum.RightCenter
                mv.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
                mv.Cols(index).DataType = GetType(Decimal)
                mv.Cols(index).Format = "#####0.00"
            End If
        Next
        mv.Cols(1).TextAlign = TextAlignEnum.CenterCenter
        mv.Cols(1).TextAlignFixed = TextAlignEnum.CenterCenter
        mv.Cols(3).TextAlign = TextAlignEnum.CenterCenter
        mv.Cols(3).TextAlignFixed = TextAlignEnum.CenterCenter
        llena_Mv()
    End Sub

    Private Sub llena_Mv()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String
        Dim MES As String
        Dim ANO As String
        MES = Mid(DateTimePicker1.Text, 1, 2)
        ANO = Mid(DateTimePicker1.Text, 4, 4)
        Dim fechas As String = "'" & ANO & "-" & MES & "-01'"
        strSQL = "SELECT * FROM E_STOCK WHERE FECHA > " & fechas & " AND ESTILO = '" & Estilo.Text & "' AND COLOR = '" & colo.Text & "' AND TIPO = '" & tipos & "' AND TALLA = '" & Talla.Text & "' AND CLIENTE = '" & Cliente.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        mv.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each dr In dt.Rows
            mv(lineas, 1) = dr("FECHA")
            mv(lineas, 2) = "Entrada"
            mv(lineas, 3) = dr("CORTE")
            mv(lineas, 6) = dr("PRENDAS")
            lineas = lineas + 1
        Next
        llena_salidas()
        mv.Sort(SortFlags.Ascending, 1)
        mv.Subtotal(AggregateEnum.Sum, -1, -1, 6, "Total")
        mv.Subtotal(AggregateEnum.Sum, -1, -1, 7, "Total")
        mv.ScrollBars = ScrollBars.Both

    End Sub

    Private Sub llena_salidas()
        Dim tb As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String
        Dim MES As String
        Dim ANO As String
        Dim fechas As String
        MES = Mid(DateTimePicker1.Text, 1, 2)
        ANO = Mid(DateTimePicker1.Text, 4, 4)
        fechas = "'" & ANO & "-" & MES & "-01'"
        strSQL = "SELECT * FROM S_STOCK WHERE FECHA > " & fechas & " AND ESTILO = '" & Estilo.Text & "' AND COLOR = '" & colo.Text & "' AND TIPO = '" & tipos & "' AND TALLA = '" & Talla.Text & "'"
        llena_tablas(tb, strSQL, cnn)
        For Each dr In tb.Rows
            lineas = mv.Rows.Count
            mv.Rows.Count = mv.Rows.Count + 1
            mv(lineas, 1) = dr("FECHA")
            mv(lineas, 2) = "Salida"
            mv(lineas, 4) = dr("EMBARQUE")
            mv(lineas, 5) = dr("CPO")
            mv(lineas, 7) = dr("PRENDAS")
        Next
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        setea_mv()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        fg.Visible = True
        Label1.Visible = True
        Button3.Visible = False
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        despliega_prendas()
    End Sub
End Class
