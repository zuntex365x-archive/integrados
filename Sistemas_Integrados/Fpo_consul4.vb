Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized


Public Class Fpo_consul4
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim g As String = "#######0"
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Public strsql As String
    Dim cpos As String
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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fpo_consul4))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 8)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.Size = New System.Drawing.Size(1054, 587)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 45
        Me.fg.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'Fpo_consul4
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1074, 607)
        Me.Controls.Add(Me.fg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Fpo_consul4"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Fpos"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FPO_consul1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setea_grid()
        llena_grid()
    End Sub

    Private Sub setea_grid()
        Dim index As Integer
        fg.Clear(ClearFlags.Style)
        fg.Rows.Count = 1
        fg.Cols.Count = 22
        fg.Cols(0).Width = 0
        fg.Rows(0).Height = 30
        fg.Cols(1).Name = "FPO"
        fg.Cols(2).Name = "COLOR"
        fg.Cols(3).Name = "KNIT"
        fg.Cols(4).Name = "TIPO"
        fg.Cols(5).Name = "LOTE"
        fg.Cols(6).Name = "CLIENTE"
        fg.Cols(7).Name = "YARN FIBER"
        fg.Cols(8).Name = "YARN FINISH"
        fg.Cols(9).Name = "LIBRAS"
        fg.Cols(10).Name = "RECIBIDO"
        fg.Cols(11).Name = "BALANCE"
        fg.Cols(12).Name = "F.FPO"
        fg.Cols(13).Name = "F.REQ."
        fg.Cols(14).Name = "F.OFRE."
        fg.Cols(15).Name = "F.REC."
        fg.Cols(16).Name = "ESTILO"
        fg.Cols(17).Name = "CPO"
        fg.Cols(18).Name = "ANCHO"
        fg.Cols(19).Name = "PRECIO"
        fg.Cols(20).Name = "PESO"
        fg.Cols(21).Name = "ESTADO"
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 70
            fg(0, index) = fg.Cols(index).Name
            If index > 11 And index < 16 Then
                fg.Cols(index).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
                fg.Cols(index).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
            End If
        Next
        fg.Cols(1).Width = 100
        fg.Cols(2).Width = 200
        fg.Cols(3).Width = 110
        fg.Cols(4).Width = 80
        fg.Cols(5).Width = 60
        fg.Cols(6).Width = 80
        fg.Cols(7).Width = 0
        fg.Cols(8).Width = 0
        fg.Cols(9).Width = 70
        fg.Cols(10).Width = 70
        fg.Cols(11).Width = 70
        fg.Cols(12).Width = 75
        fg.Cols(13).Width = 75
        fg.Cols(14).Width = 75
        fg.Cols(15).Width = 75
        fg.Cols(16).Width = 100
        fg.Cols(17).Width = 100
        fg.Cols(21).Width = 100
        fg.Cols(5).Format = g
        fg.Cols(5).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
        fg.Cols(5).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
        fg.Cols(9).Format = h
        fg.Cols(9).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
        fg.Cols(9).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
        fg.Cols(10).Format = h
        fg.Cols(10).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
        fg.Cols(10).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
        fg.Cols(11).Format = h
        fg.Cols(11).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
        fg.Cols(11).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
        fg.Cols(19).Format = h
        fg.Cols(19).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
        fg.Cols(19).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
        Dim s As C1.Win.C1FlexGrid.CellStyle
        s = fg.Styles.Add("verde")
        s.ForeColor = Color.White
        s.BackColor = Color.Green
        s = fg.Styles.Add("amarillo")
        s.ForeColor = Color.Black
        s.BackColor = Color.Yellow
        s = fg.Styles.Add("rojo")
        s.ForeColor = Color.White
        s.BackColor = Color.Red
    End Sub

    Private Sub llena_grid()
        Dim dr As DataRow
        Dim lineas As Integer
        Dim ahora As DateTime = DateTime.Now
        Dim semana As DateTime = ahora.AddDays(8)
        Dim req As Date
        Dim cpo As String = ""
        llena_tablas(dt, strsql, cnn)
        lineas = dt.Rows.Count
        fg.Rows.Count = lineas + 1
        lineas = 1
        For Each dr In dt.Rows
            CPO = dr("CPO")
            fg(lineas, 1) = dr("FPO")
            fg(lineas, 2) = dr("COLOR")
            fg(lineas, 3) = dr("KNIT")
            fg(lineas, 4) = dr("TIPO")
            fg(lineas, 5) = dr("LOTE")
            fg(lineas, 6) = dr("CLIENTE")
            fg(lineas, 7) = dr("YFIBER")
            fg(lineas, 8) = dr("YFINISH")
            fg(lineas, 9) = dr("LIBRAS")
            fg(lineas, 10) = dr("RECIBIDAS")
            fg(lineas, 11) = fg(lineas, 10) - fg(lineas, 9)
            fg(lineas, 12) = dr("IFECHA")
            fg(lineas, 13) = dr("RFECHA")
            fg(lineas, 14) = dr("OFECHA")
            fg(lineas, 16) = dr("ESTILO")
            fg(lineas, 17) = dr("CPO")
            fg(lineas, 18) = dr("ANCHO")
            fg(lineas, 19) = dr("PRECIO")
            fg(lineas, 20) = dr("PESO")
            fg(lineas, 21) = Trim(dr("STATUS"))
            fg(lineas, 0) = fg(lineas, 1) + fg(lineas, 2) + fg(lineas, 3) + fg(lineas, 4) + CStr(fg(lineas, 5))
            If fg(lineas, 10) < fg(lineas, 9) Then
                req = CDate(fg(lineas, 13))
                If req < ahora Then
                    fg.SetCellStyle(lineas, 13, fg.Styles("rojo"))
                Else
                    If req < semana Then
                        fg.SetCellStyle(lineas, 13, fg.Styles("amarillo"))
                    Else
                        fg.SetCellStyle(lineas, 13, fg.Styles("verde"))
                    End If
                End If
            End If
            lineas = lineas + 1
        Next
        fecha_recepcion(CPO)
        subtotales()
    End Sub

    Private Sub fecha_recepcion(ByVal fpo As String)
        Dim dr As DataRow
        Dim fila As String
        Dim sel As Integer
        strsql = "SELECT DISTINCT FECHA, DMOVTO.FPO, TIPO, KNIT,COLOR, DMOVTO.BATCH FROM DMOVTO LEFT JOIN ROLLOS ON DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO WHERE TMOVTO = '1' AND TIPO = 'TELA' AND DMOVTO.CPO = '" & fpo & "'"
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            fila = dr("FPO") + dr("COLOR") + dr("KNIT") + dr("TIPO") + CStr(dr("BATCH"))
            sel = fg.FindRow(fila, 1, 0, True)
            Try
                fg(sel, 15) = dr("FECHA")
            Catch
            End Try
        Next
    End Sub

    Private Sub subtotales()
        fg.Cols.Remove(0)
        fg.Cols.Insert(0)
        fg.Cols(0).Width = 0
        fg.ScrollBars = ScrollBars.Both
        fg.Cols(1).AllowMerging = True
        fg.Cols(2).AllowMerging = True
        fg.Cols(3).AllowMerging = True
        fg.Cols(4).AllowMerging = True
        fg.Cols(5).AllowMerging = True
        fg.Subtotal(AggregateEnum.Clear)
        fg.Subtotal(AggregateEnum.Sum, 1, 1, 2, 9, "Totales {0}")
        fg.Subtotal(AggregateEnum.Sum, 1, 1, 2, 10, "Totales {0}")
        fg.Subtotal(AggregateEnum.Sum, 1, 1, 2, 11, "Totales {0}")
        fg.Subtotal(AggregateEnum.Sum, 0, 0, 0, 9, "Gran TOTAL ---->")
        fg.Subtotal(AggregateEnum.Sum, 0, 0, 0, 10, "Gran TOTAL ---->")
        fg.Subtotal(AggregateEnum.Sum, 0, 0, 0, 11, "Gran TOTAL ---->")
        fg.Redraw = True
        Cursor = Cursors.Default
    End Sub

End Class
