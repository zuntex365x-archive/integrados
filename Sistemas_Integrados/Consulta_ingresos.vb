Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class consulta_ingresos
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim g As String = "######0"
    Dim r As String = "00000000"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Dim lineas As Integer
    Dim batch As String
    Dim docu As String
    Dim p As Point
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Docto As System.Windows.Forms.TextBox
    Friend WithEvents Observa As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Mes As System.Windows.Forms.DateTimePicker
    Friend WithEvents jg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fecha As System.Windows.Forms.TextBox
    Friend WithEvents Imprimir As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consulta_ingresos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Docto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Observa = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.fecha = New System.Windows.Forms.TextBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Mes = New System.Windows.Forms.DateTimePicker()
        Me.jg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Imprimir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Documento:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Docto
        '
        Me.Docto.BackColor = System.Drawing.Color.White
        Me.Docto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Docto.Location = New System.Drawing.Point(120, 24)
        Me.Docto.MaxLength = 10
        Me.Docto.Name = "Docto"
        Me.Docto.ReadOnly = True
        Me.Docto.Size = New System.Drawing.Size(112, 20)
        Me.Docto.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Docto, "Numero de Documento, Lista de Empaque Etc.")
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Observaciones:"
        '
        'Observa
        '
        Me.Observa.BackColor = System.Drawing.Color.White
        Me.Observa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Observa.Location = New System.Drawing.Point(120, 72)
        Me.Observa.MaxLength = 25
        Me.Observa.Name = "Observa"
        Me.Observa.ReadOnly = True
        Me.Observa.Size = New System.Drawing.Size(376, 20)
        Me.Observa.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.Observa, "Algun comentario del Ingreso de Tela.")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Docto)
        Me.GroupBox1.Controls.Add(Me.Imprimir)
        Me.GroupBox1.Controls.Add(Me.fecha)
        Me.GroupBox1.Controls.Add(Me.Observa)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(960, 104)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Documento"
        Me.GroupBox1.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(869, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 40)
        Me.Button3.TabIndex = 43
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton para regresar a Seleccionar Documentos.")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'fecha
        '
        Me.fecha.BackColor = System.Drawing.Color.White
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Location = New System.Drawing.Point(120, 48)
        Me.fecha.MaxLength = 10
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Size = New System.Drawing.Size(112, 20)
        Me.fecha.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.fecha, "Fecha en que fue recibida la Tela.")
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 120)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 14
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(968, 504)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 24
        Me.fg.Visible = False
        '
        'Mes
        '
        Me.Mes.CustomFormat = "MM/yyyy"
        Me.Mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Mes.Location = New System.Drawing.Point(104, 16)
        Me.Mes.Name = "Mes"
        Me.Mes.ShowUpDown = True
        Me.Mes.Size = New System.Drawing.Size(88, 26)
        Me.Mes.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.Mes, "Mes y a�o de los Documentos que deseamos desplegar.")
        '
        'jg
        '
        Me.jg.AllowEditing = False
        Me.jg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.jg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.jg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.jg.BackColor = System.Drawing.Color.White
        Me.jg.ColumnInfo = resources.GetString("jg.ColumnInfo")
        Me.jg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.jg.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jg.ForeColor = System.Drawing.Color.Black
        Me.jg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.jg.Location = New System.Drawing.Point(8, 64)
        Me.jg.Name = "jg"
        Me.jg.Rows.DefaultSize = 14
        Me.jg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.jg.Size = New System.Drawing.Size(968, 568)
        Me.jg.StyleInfo = resources.GetString("jg.StyleInfo")
        Me.jg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.jg.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.jg, "Para seleccionar un Documento en especial presione Doble-click")
        '
        'Imprimir
        '
        Me.Imprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Imprimir.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Imprimir.ForeColor = System.Drawing.Color.Black
        Me.Imprimir.Image = CType(resources.GetObject("Imprimir.Image"), System.Drawing.Image)
        Me.Imprimir.Location = New System.Drawing.Point(920, 15)
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(48, 40)
        Me.Imprimir.TabIndex = 55
        Me.Imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Imprimir, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Imprimir.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 32)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Mes:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'consulta_ingresos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 676)
        Me.Controls.Add(Me.Mes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.jg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fg)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "consulta_ingresos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Ingresos a Bodega"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub consulta_ingresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        p.X = jg.Width
        GroupBox1.Width = jg.Width
        fg.Width = jg.Width
        fg.Height = jg.Height - 150
        Mes.Value = CDate("01/01/2010")
        Mes.Value = Now
    End Sub

    Private Sub setea_fg()
        Try
            Dim index As Integer
            fg.Clear(ClearFlags.Style)
            fg.Rows.Count = 1
            fg.Cols.Count = 11
            fg.Cols(0).Width = 15
            fg.Rows(0).Height = 30
            Dim c As Column = fg.Cols(1)
            fg.Cols(1).Name = "BATCH"
            fg.Cols(2).Name = "FPO"
            fg.Cols(3).Name = "CLIENTE"
            fg.Cols(4).Name = "ITEM"
            fg.Cols(5).Name = "F.KNIT"
            fg.Cols(6).Name = "COLOR"
            fg.Cols(7).Name = "CPO"
            fg.Cols(8).Name = "No.ROLLO"
            fg.Cols(9).Name = "LIBRAS"
            fg.Cols(10).Name = "YARDAS"
            fg.Cols(8).DataType = GetType(Integer)
            fg.Cols(9).Format = r
            fg.Cols(8).TextAlign = TextAlignEnum.CenterCenter
            fg.Cols(8).TextAlignFixed = TextAlignEnum.CenterCenter
            fg.Cols(9).DataType = GetType(Decimal)
            fg.Cols(9).Format = "######.0"
            fg.Cols(9).TextAlign = TextAlignEnum.RightCenter
            fg.Cols(9).TextAlignFixed = TextAlignEnum.RightCenter
            fg.Cols(10).DataType = GetType(Decimal)
            fg.Cols(10).Format = "######.0"
            fg.Cols(10).TextAlign = TextAlignEnum.RightCenter
            fg.Cols(10).TextAlignFixed = TextAlignEnum.RightCenter
            For index = 1 To fg.Cols.Count - 1
                fg.Cols(index).Width = 115
                fg(0, index) = fg.Cols(index).Name
            Next
            fg.Cols(1).AllowMerging = True
            fg.Cols(2).AllowMerging = True
            fg.Cols(3).AllowMerging = True
            fg.Cols(4).AllowMerging = True
            fg.Cols(5).AllowMerging = True
            fg.Cols(6).AllowMerging = True
            fg.Cols(7).AllowMerging = True
            fg.Cols(3).Width = 150
        Catch
        End Try

    End Sub

    Private Sub setea_jg()
        Try
            Dim index As Integer
            jg.Clear()
            jg.Rows.Count = 1
            jg.Cols.Count = 10
            jg.Cols(0).Width = 15
            jg.Rows(0).Height = 30
            Dim c As Column = jg.Cols(1)
            jg.Cols(1).Name = "FECHA"
            jg.Cols(1).TextAlign = TextAlignEnum.CenterCenter
            jg.Cols(1).TextAlignFixed = TextAlignEnum.CenterCenter
            jg.Cols(2).Name = "DOCUMENTO"
            jg.Cols(3).Name = "CLIENTE"
            jg.Cols(4).Name = "FPO"
            jg.Cols(5).Name = "BATCH"
            jg.Cols(6).Name = "TOTAL ROLLOS"
            jg.Cols(7).Name = "TOTAL YARDAS"
            jg.Cols(8).Name = "TOTAL LIBRAS"
            jg.Cols(9).Name = "COSTO TOTAL"
            jg.Cols(6).DataType = GetType(Integer)
            jg.Cols(6).Format = "#####0"
            jg.Cols(6).TextAlign = TextAlignEnum.CenterCenter
            jg.Cols(6).TextAlignFixed = TextAlignEnum.CenterCenter
            jg.Cols(7).DataType = GetType(Decimal)
            jg.Cols(7).Format = "######.0"
            jg.Cols(7).TextAlign = TextAlignEnum.RightCenter
            jg.Cols(7).TextAlignFixed = TextAlignEnum.RightCenter
            jg.Cols(8).DataType = GetType(Decimal)
            jg.Cols(8).Format = "######.0"
            jg.Cols(8).TextAlign = TextAlignEnum.RightCenter
            jg.Cols(8).TextAlignFixed = TextAlignEnum.RightCenter
            jg.Cols(9).DataType = GetType(Decimal)
            jg.Cols(9).Format = "#####0.00"
            jg.Cols(9).TextAlign = TextAlignEnum.RightCenter
            jg.Cols(9).TextAlignFixed = TextAlignEnum.RightCenter
            For index = 1 To jg.Cols.Count - 1
                jg(0, index) = jg.Cols(index).Name
                jg.Cols(index).Width = 110
                If index > 6 Then
                    jg.Cols(index).Width = 85
                End If
            Next
        Catch
        End Try
    End Sub

    Private Sub busca_documentos()
        Dim strSQL As String
        Dim ano As String
        Dim meses As String
        ano = Mid(Mes.Text, 4, 4)
        meses = Mid(Mes.Text, 1, 2)
        strSQL = "SELECT FECHA, COUNT(ROLLO) AS ROLLO, SUM(YARDAS) AS YARDA, SUM(LIBRAS) AS LIBRAS, SUM(LIBRAS * PRECIO) AS CTOTAL, DOCTO, CLIENTE, FPO, BATCH FROM DMOVTO WHERE MONTH(FECHA) = '" & meses & "' AND YEAR(FECHA) = '" & ano & "'AND TMOVTO = '1'  GROUP BY FECHA, DOCTO, CLIENTE, FPO, BATCH ORDER BY FECHA"
        llena_tablas(dt, strSQL, cnn)
        For Each Me.dr In dt.Rows
            lineas = jg.Rows.Count
            jg.Rows.Count = jg.Rows.Count + 1
            jg(lineas, 1) = dr("FECHA")
            jg(lineas, 2) = dr("DOCTO")
            jg(lineas, 3) = dr("CLIENTE")
            jg(lineas, 4) = dr("FPO")
            jg(lineas, 5) = dr("BATCH")
            jg(lineas, 6) = dr("ROLLO")
            jg(lineas, 7) = dr("YARDA")
            jg(lineas, 8) = dr("LIBRAS")
            jg(lineas, 9) = dr("CTOTAL")
        Next
        jg.Subtotal(AggregateEnum.Clear)
        jg.Subtotal(AggregateEnum.Sum, 1, 1, 1, 7, "Totales {0}")
        jg.Subtotal(AggregateEnum.Sum, 1, 1, 1, 8, "Totales {0}")
        jg.Subtotal(AggregateEnum.Sum, 1, 1, 1, 9, "Totales {0}")
        jg.Subtotal(AggregateEnum.Sum, -1, -1, -1, 7, "Totales {0}")
        jg.Subtotal(AggregateEnum.Sum, -1, -1, -1, 8, "Totales {0}")
        jg.Subtotal(AggregateEnum.Sum, -1, -1, -1, 9, "Totales {0}")
        Imprimir.Visible = True
    End Sub

    Private Sub jg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jg.DoubleClick
        antes_fg()
        Button3.Focus()
    End Sub

    Private Sub antes_fg()
        Label4.Visible = False
        Mes.Visible = False
        jg.Visible = False
        docu = jg(jg.RowSel, "DOCUMENTO")
        batch = jg(jg.RowSel, "BATCH")
        GroupBox1.Visible = True
        fg.Visible = True
        busca_batch()
    End Sub

    Private Sub busca_batch()
        Dim strSQL As String
        Docto.Text = jg(jg.RowSel, "DOCUMENTO")
        fecha.Text = jg(jg.RowSel, "FECHA")
        setea_fg()
        strSQL = "SELECT * FROM EMOVTO WHERE DOCTO = '" & docu & "' AND TMOVTO = '1'"
        llena_tablas(dt, strSQL, cnn)
        For Each Me.dr In dt.Rows
            Observa.Text = dr("COMENTARIO")
        Next
        strSQL = "SELECT DMOVTO.BATCH AS BATCH , DMOVTO.ROLLO  AS ROLLO , DMOVTO.FPO AS FPO, DMOVTO.CLIENTE AS CLIENTE , DMOVTO.CPO AS CPO , ROLLOS.TIPO AS TIPO , ROLLOS.KNIT AS KNIT , ROLLOS.COLOR  AS COLOR ,ROLLOS.PESO AS PESO, ROLLOS.YARDAS_I  AS YARDAS FROM DMOVTO, ROLLOS  WHERE DMOVTO.DOCTO = '" & docu & "' AND DMOVTO.TMOVTO = '1' AND DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO"
        llena_tablas(dt, strSQL, cnn)
        For Each Me.dr In dt.Rows
            lineas = fg.Rows.Count
            fg.Rows.Count = fg.Rows.Count + 1
            fg(lineas, 1) = dr("BATCH")
            fg(lineas, 2) = dr("FPO")
            fg(lineas, 3) = dr("CLIENTE")
            fg(lineas, 4) = dr("TIPO")
            fg(lineas, 5) = dr("KNIT")
            fg(lineas, 6) = dr("COLOR")
            fg(lineas, 7) = dr("CPO")
            fg(lineas, 8) = dr("ROLLO")
            fg(lineas, 9) = dr("PESO")
            fg(lineas, 10) = dr("YARDAS")
        Next
        fg.Subtotal(AggregateEnum.Clear)
        fg.Subtotal(AggregateEnum.Sum, -1, -1, -1, 9, "Totales {0}")
        fg.Subtotal(AggregateEnum.Sum, -1, -1, -1, 10, "Totales {0}")

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GroupBox1.Visible = False
        Label4.Visible = True
        Mes.Visible = True
        fg.Visible = False
        jg.Visible = True
        Mes.Focus()
    End Sub

    Private Sub Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Imprimir.Click
        Print_fg()
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        fecha = Mes.Text
        pd = jg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = True
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With
        jg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        jg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        jg.PrintGrid("inventario", PrintGridFlags.ShowPreviewDialog, "Reporte de Ingreso de tela del mes de :  " + fecha + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub


    Private Sub Mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mes.ValueChanged
        setea_jg()
        busca_documentos()
    End Sub
End Class
