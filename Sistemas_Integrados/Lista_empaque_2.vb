Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Printing
Imports C1.C1Excel
Public Class Lista_empaque_2
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim strSQl As String
    Dim dr As DataRow
    Dim dw As DataRow
    Dim dp As New DataTable()
    Dim cp As New DataTable()
    Dim ex As New DataTable()
    Dim fecha As Date
    Friend WithEvents C1PdfDocument1 As C1.C1Pdf.C1PdfDocument
    Dim escala As String = "00"
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Hoja As System.Windows.Forms.Button
    Friend WithEvents Imprimir As System.Windows.Forms.Button
    Friend WithEvents Regresar As System.Windows.Forms.Button
    Friend WithEvents pdf As C1.C1Pdf.C1PdfDocument
    Friend WithEvents pd As System.Windows.Forms.Button
    Friend WithEvents es As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents gs As System.Windows.Forms.Button
    Friend WithEvents _book As C1.C1Excel.C1XLBook
    Friend WithEvents embarque As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents destino As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lista_empaque_2))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Hoja = New System.Windows.Forms.Button()
        Me.Imprimir = New System.Windows.Forms.Button()
        Me.Regresar = New System.Windows.Forms.Button()
        Me.pd = New System.Windows.Forms.Button()
        Me.es = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.gs = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pdf = New C1.C1Pdf.C1PdfDocument()
        Me._book = New C1.C1Excel.C1XLBook()
        Me.embarque = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.destino = New System.Windows.Forms.Label()
        Me.C1PdfDocument1 = New C1.C1Pdf.C1PdfDocument()
        CType(Me.es, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        '
        'Hoja
        '
        Me.Hoja.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Hoja.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Hoja.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hoja.ForeColor = System.Drawing.Color.Black
        Me.Hoja.Image = CType(resources.GetObject("Hoja.Image"), System.Drawing.Image)
        Me.Hoja.Location = New System.Drawing.Point(864, 8)
        Me.Hoja.Name = "Hoja"
        Me.Hoja.Size = New System.Drawing.Size(35, 35)
        Me.Hoja.TabIndex = 82
        Me.Hoja.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Hoja, "Convierte a Excel")
        Me.Hoja.UseVisualStyleBackColor = False
        Me.Hoja.Visible = False
        '
        'Imprimir
        '
        Me.Imprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Imprimir.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Imprimir.ForeColor = System.Drawing.Color.Black
        Me.Imprimir.Image = CType(resources.GetObject("Imprimir.Image"), System.Drawing.Image)
        Me.Imprimir.Location = New System.Drawing.Point(904, 8)
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(35, 35)
        Me.Imprimir.TabIndex = 83
        Me.Imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Imprimir, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Imprimir.UseVisualStyleBackColor = False
        Me.Imprimir.Visible = False
        '
        'Regresar
        '
        Me.Regresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Regresar.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar.ForeColor = System.Drawing.Color.Black
        Me.Regresar.Image = CType(resources.GetObject("Regresar.Image"), System.Drawing.Image)
        Me.Regresar.Location = New System.Drawing.Point(784, 8)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(35, 35)
        Me.Regresar.TabIndex = 84
        Me.Regresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Regresar, "Presione este Boton para Refrescar la pantalla  y volver a solicitar datos de bus" &
        "queda.")
        Me.Regresar.UseVisualStyleBackColor = False
        Me.Regresar.Visible = False
        '
        'pd
        '
        Me.pd.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.pd.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pd.ForeColor = System.Drawing.Color.Black
        Me.pd.Image = CType(resources.GetObject("pd.Image"), System.Drawing.Image)
        Me.pd.Location = New System.Drawing.Point(944, 8)
        Me.pd.Name = "pd"
        Me.pd.Size = New System.Drawing.Size(35, 35)
        Me.pd.TabIndex = 85
        Me.pd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.pd, "Convierte a formato PDF")
        Me.pd.UseVisualStyleBackColor = False
        Me.pd.Visible = False
        '
        'es
        '
        Me.es.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.es.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.es.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.es.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.es.BackColor = System.Drawing.Color.White
        Me.es.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes
        Me.es.ColumnInfo = resources.GetString("es.ColumnInfo")
        Me.es.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.es.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.es.ForeColor = System.Drawing.Color.Black
        Me.es.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.es.Location = New System.Drawing.Point(200, 72)
        Me.es.Name = "es"
        Me.es.Rows.Count = 1
        Me.es.Rows.DefaultSize = 21
        Me.es.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.es.Size = New System.Drawing.Size(576, 568)
        Me.es.StyleInfo = resources.GetString("es.StyleInfo")
        Me.es.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.es, "Presione doble click para seleccionar un Embarque específico.")
        Me.es.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'gs
        '
        Me.gs.BackColor = System.Drawing.Color.Transparent
        Me.gs.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gs.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gs.ForeColor = System.Drawing.Color.Transparent
        Me.gs.Image = CType(resources.GetObject("gs.Image"), System.Drawing.Image)
        Me.gs.Location = New System.Drawing.Point(824, 8)
        Me.gs.Name = "gs"
        Me.gs.Size = New System.Drawing.Size(35, 35)
        Me.gs.TabIndex = 89
        Me.gs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.gs, "Convierte a Excel")
        Me.gs.UseVisualStyleBackColor = False
        Me.gs.Visible = False
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(992, 648)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(376, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 32)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Destino:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pdf
        '
        Me.pdf.DocumentInfo.Author = ""
        Me.pdf.DocumentInfo.CreationDate = New Date(CType(0, Long))
        Me.pdf.DocumentInfo.Creator = ""
        Me.pdf.DocumentInfo.Keywords = ""
        Me.pdf.DocumentInfo.Producer = "ComponentOne C1Pdf"
        Me.pdf.DocumentInfo.Subject = ""
        Me.pdf.DocumentInfo.Title = ""
        Me.pdf.MaxHeaderBookmarkLevel = 0
        Me.pdf.PdfVersion = "1.3"
        Me.pdf.RefDC = Nothing
        Me.pdf.RotateAngle = 0!
        Me.pdf.UseFastTextOut = True
        Me.pdf.UseFontShaping = True
        '
        'embarque
        '
        Me.embarque.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.embarque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.embarque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.embarque.ForeColor = System.Drawing.Color.Black
        Me.embarque.Location = New System.Drawing.Point(112, 8)
        Me.embarque.Name = "embarque"
        Me.embarque.Size = New System.Drawing.Size(168, 32)
        Me.embarque.TabIndex = 93
        Me.embarque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 32)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Embarque:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'destino
        '
        Me.destino.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.destino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.destino.ForeColor = System.Drawing.Color.Black
        Me.destino.Location = New System.Drawing.Point(464, 8)
        Me.destino.Name = "destino"
        Me.destino.Size = New System.Drawing.Size(248, 32)
        Me.destino.TabIndex = 94
        Me.destino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C1PdfDocument1
        '
        Me.C1PdfDocument1.DocumentInfo.Author = ""
        Me.C1PdfDocument1.DocumentInfo.CreationDate = New Date(CType(0, Long))
        Me.C1PdfDocument1.DocumentInfo.Creator = ""
        Me.C1PdfDocument1.DocumentInfo.Keywords = ""
        Me.C1PdfDocument1.DocumentInfo.Producer = "ComponentOne C1Pdf"
        Me.C1PdfDocument1.DocumentInfo.Subject = ""
        Me.C1PdfDocument1.DocumentInfo.Title = ""
        Me.C1PdfDocument1.MaxHeaderBookmarkLevel = 0
        Me.C1PdfDocument1.PdfVersion = "1.3"
        Me.C1PdfDocument1.RefDC = Nothing
        Me.C1PdfDocument1.RotateAngle = 0!
        Me.C1PdfDocument1.UseFastTextOut = True
        Me.C1PdfDocument1.UseFontShaping = True
        '
        'Lista_empaque_2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 703)
        Me.Controls.Add(Me.destino)
        Me.Controls.Add(Me.embarque)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gs)
        Me.Controls.Add(Me.es)
        Me.Controls.Add(Me.pd)
        Me.Controls.Add(Me.Imprimir)
        Me.Controls.Add(Me.Hoja)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Regresar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Lista_empaque_2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Empaque"
        CType(Me.es, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Lista_empaque_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        fg.Rows(0).Visible = False
        llena_es()
        es.Focus()
    End Sub

    Private Sub forma_lista()
        Dim dt As New DataTable()
        Dim dd As New DataTable()
        Dim l As Integer = 0
        Dim pri As Integer
        Dim i As Integer
        Dim j As Integer
        Dim talla As String = ""
        Dim c As Integer
        Dim prendas As Integer
        Dim t(11) As Integer
        Dim p(12) As Decimal
        Dim rgn As CellRange
        Dim da As DataRow()
        Dim dl As DataRow()
        Dim dc As DataRow
        Dim ep As DataRow
        Dim strsql As String = "SELECT PACKING_E.*,CLIENTE FROM PACKING_E LEFT JOIN CPO ON PACKING_E.CPO = CPO.CPO WHERE EMBARQUE = '" & embarque.Text & "' AND DESTINO = '" & destino.Text & "' ORDER BY CAJA_I "
        llena_tablas(dt, strsql, cnn)
        Try
            For Each Me.dr In dt.Rows
                strsql = "SELECT PACKING_C.*, FECHA FROM PACKING_C LEFT JOIN PACKING_E ON PACKING_C.EMBARQUE = PACKING_E.EMBARQUE AND PACKING_C.CPO = PACKING_E.CPO AND PACKING_C.ESTILO = PACKING_E.ESTILO AND PACKING_C.COLOR = PACKING_E.COLOR WHERE PACKING_C.EMBARQUE = '" & embarque.Text & "' AND PACKING_C.CPO = '" & dr("CPO") & "' AND PACKING_C.ESTILO = '" & dr("ESTILO") & "' AND PACKING_C.COLOR = '" & dr("COLOR") & "' ORDER BY CAJA"
                llena_tablas(dd, strsql, cnn)
                If dd.Rows.Count > 0 Then
                    dw = dd.Rows(0)
                    encabezado()
                    pri = fg.Rows.Count
                    talla = ""
                    'crea_linea(talla, c, l)
                End If
                For Each Me.dw In dd.Rows
                    j = dd.Rows.Count
                    If dw("TALLA") <> talla Or dw("PRENDAS") <> prendas Then
                        crea_linea(talla, c, l)
                    End If
                    prendas = CInt(dw("PRENDAS"))
                    fg(l, 2) = dw("CAJA")
                    fg(l, c) = fg(l, c) + prendas
                    fg(l, 18) = fg(l, 18) + prendas
                Next
                l = fg.Rows.Count
                fg.Rows.Count = l + 1
                rgn = fg.GetCellRange(pri, 1, l - 1, 18)
                rgn.Style = fg.Styles("si")
                For i = pri To l - 1
                    fg(i, 17) = fg(i, 2) - fg(i, 1) + 1
                    fg(i, 16) = fg(i, 18) / fg(i, 17)
                    For j = 6 To 18
                        If j <> 16 Then
                            fg(l, j) = fg(l, j) + fg(i, j)
                        End If
                    Next
                Next
                fg.Rows(l).Height = 25
                fg(l, 5) = "SUBTOTAL"
                rgn = fg.GetCellRange(l, 1, l, 18)
                rgn.Style = fg.Styles("sb")
                ep = Nothing
                da = cp.Select("CPO = '" & dw("CPO") & "' AND ESTILO = '" & dw("ESTILO") & "' AND COLOR = '" & dw("COLOR") & "'")
                If da.Length > 0 Then
                    dc = da(0)
                    escala = dc("ESCALA")
                    dl = ex.Select("CPO = '" & dw("CPO") & "' AND ESTILO = '" & dw("ESTILO") & "' AND COLOR = '" & dw("COLOR") & "'")
                    If dl.Length > 0 Then
                        ep = dl(0)
                    End If
                Else
                    dc = Nothing
                End If
                fg.Rows.Count = fg.Rows.Count + 4
                rgn = fg.GetCellRange(l + 1, 1, l + 1, 18)
                rgn.Style = fg.Styles("pj")
                ReDim p(11)
                For i = 0 To 9
                    t(i) = t(i) + fg(l, i + 6)
                    Try
                        p(i) = ep(i + 3) / dc(i + 3)
                        fg(l + 1, i + 6) = p(i)
                        p(10) = p(10) + dc(i + 3)
                        p(11) = p(11) + ep(i + 3)
                    Catch
                        p(i) = 0
                    End Try
                Next
                t(10) = t(10) + fg(l, 17)
                t(11) = t(11) + fg(l, 18)
                Try
                    fg(l + 1, 18) = p(11) / p(10)
                Catch
                End Try

                'PORCENTAJE ====================

                rgn = fg.GetCellRange(l + 2, 1, l + 4, 18)
                rgn.Style = fg.Styles("nada")
            Next

        Catch
        End Try

        ' ============== GRAN TOTAL ===================
        l = fg.Rows.Count - 1
        For i = 0 To 9
            fg(l, i + 6) = t(i)
        Next
        fg(l, 17) = t(10)
        fg(l, 18) = t(11)


        fg.Rows(l).Height = 30
        fg(l, 5) = "GRAN TOTAL"
        rgn = fg.GetCellRange(l, 1, l, 18)
        rgn.Style = fg.Styles("gt")

    End Sub

    Private Sub crea_linea(ByRef talla As String, ByRef c As Integer, ByRef l As Integer)
        Dim caja As String = dw("CAJA")
        l = fg.Rows.Count
        talla = dw("TALLA")
        c = fg.Cols.IndexOf(talla)
        If caja = fg(l - 1, 2) Then
            l = l - 1
            Exit Sub
        End If
        fg.Rows.Count = fg.Rows.Count + 1
        fg(l, 1) = dw("CAJA")
        fg(l, 3) = dw("ESTILO")
        fg(l, 4) = dw("CPO")
        fg(l, 5) = dw("COLOR")
    End Sub

    Private Sub encabezado()
        Dim descripcion As String = ""
        Dim rgn As CellRange
        Dim l As Integer = fg.Rows.Count
        Dim dn As DataRow
        Dim ds As DataRow()
        Dim estilo As String
        Dim cuenta As Integer = dp.Rows.Count
        Dim es As DataRow
    
        Try
            estilo = dw("ESTILO")
            ds = dp.Select("ESTILO = '" & estilo & "'")
            If ds.Length > 0 Then
                dn = ds(0)
                descripcion = dn("DESCRIPCION")
            End If
        Catch
        End Try
        fg.Rows.Count = fg.Rows.Count + 3
        fg.Rows(l).Height = 40
        fg.Rows(l + 1).Height = 30
        fg.Rows(l + 2).Height = 30

        fg.Rows(l).AllowMerging = True
        rgn = fg.GetCellRange(l, 0, l, 3)
        rgn.Data = dr("CLIENTE")
        rgn.Style = fg.Styles("cliente")

        rgn = fg.GetCellRange(l, 4, l, 14)
        rgn.Data = descripcion
        rgn.Style = fg.Styles("sin")

        rgn = fg.GetCellRange(l, 11, l, 18)
        rgn.Data = " "
        rgn.Style = fg.Styles("abajo")

        fg.Rows(l + 1).AllowMerging = True
        rgn = fg.GetCellRange(l + 1, 1, l + 1, 2)
        rgn.Data = "CARTON #"
        rgn.Style = fg.Styles("si")

        rgn = fg.GetCellRange(l + 1, 14, l + 1, 18)
        rgn.Style = fg.Styles("si")

        fg(l + 1, 16) = "PER"
        fg(l + 1, 17) = "TTL"
        fg(l + 1, 18) = "TTL"

        rgn = fg.GetCellRange(l + 1, 3, l + 1, 14)
        rgn.Data = ""
        rgn.Style = fg.Styles("abajo")

        l = l + 2
        rgn = fg.GetCellRange(l, 1, l, 18)
        rgn.Style = fg.Styles("normal")
        es = get_tallas(escala)
        fg(l, 1) = "FM"
        fg(l, 2) = "TO"
        fg(l, 3) = "STYLE"
        fg(l, 4) = "PO#"
        fg(l, 5) = "COLOR"
        tallas_cortes(dw("CPO"), dw("ESTILO"), dw("COLOR"), fg, l, 6)
        'For i = 1 To 10
        '    fg(l, i + 5) = es(i + 1)
        'Next
        fg(l, 16) = "CTNS"
        fg(l, 17) = "CTNS"
        fg(l, 18) = "PCS"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llena_descripcion()
        calcula_porcentaje()
        forma_lista()
        Hoja.Visible = True
        Imprimir.Visible = True
        pd.Visible = True
        embarque.Enabled = False
        destino.Enabled = False
        Regresar.Visible = True
    End Sub

    Private Sub Hoja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hoja.Click
        Dim forma As New Lista_empaque_4()
        forma.Embarque.Text = embarque.Text
        forma.ShowDialog()
    End Sub

    Private Sub Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Imprimir.Click
        Print_fg()
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String = Format(dw("FECHA"), "dd-MMM-yyyy")
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = False
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("Lista de Empaque", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, "Packing List   Shipment: " + embarque.Text + "     Destination: " + destino.Text + "    date: " + fecha + Chr(9) + Chr(9) + "Page {0}", "Shipment date: " + fecha)

    End Sub

    Private Sub Regresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Regresar.Click
        fg.Rows.Count = 1
        fg.Rows(0).Visible = False
        Hoja.Visible = False
        pd.Visible = False
        Imprimir.Visible = False
        Regresar.Visible = False
        gs.Visible = False
        embarque.Text = ""
        destino.Text = ""
        'llena_es()
        es.Visible = True
        es.Focus()
    End Sub

    Private Sub llena_descripcion()
        dp = New DataTable()
        llena_tablas(dp, "SELECT ESTILO,DESCRIPCION FROM ESTILOS WHERE ESTILO IN (SELECT DISTINCT ESTILO FROM PACKING_E WHERE EMBARQUE = '" & embarque.Text & "' AND DESTINO = '" & destino.Text & "')", cnn)
    End Sub

    Private Sub calcula_porcentaje()
        cp = New DataTable()
        llena_tablas(cp, "SELECT * FROM CPO_D WHERE CPO + ESTILO + COLOR IN (SELECT CPO+ESTILO+COLOR FROM PACKING_E WHERE EMBARQUE = '" & embarque.Text & "')", cnn)
        ex = New DataTable()
        llena_tablas(ex, "SELECT CPO,ESTILO,COLOR, SUM(XS) AS P0, SUM(S) AS P1,SUM(M) AS P2,SUM(L) AS P3,SUM(XL) AS P4,SUM(XL2) AS P5,SUM(XL3) AS P6,SUM(XL4) AS P7,SUM(XL5) AS P8,SUM(XL6) AS P9  FROM PACKING_D WHERE CPO+ESTILO+COLOR IN (SELECT CPO+ESTILO+COLOR FROM PACKING_D WHERE EMBARQUE = '" & embarque.Text & "') GROUP BY CPO,ESTILO,COLOR ", cnn)
    End Sub


    Private Sub pd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pd.Click
        Dim fecha As String = Format(dw("FECHA"), "dd-MMM-yyyy")
        Dim nombre As String = embarque.Text
        'adios(nombre)
        Dim archivo As String = "c:\reportes\Shipment_" + nombre + ".pdf"
        Dim encabezado As String = "Packing List   Shipment: " + embarque.Text + "     Destination: " + destino.Text + Chr(9) + Chr(9) + "Page {0}"
        Dim pie As String = "Shipment date: " + fecha
        a_pdf(fg, archivo, encabezado, pie)
    End Sub

    Private Sub llena_es()
        fg.Enabled = False
        es.Visible = True
        es.Rows.Count = 1
        es.Rows(0).Height = 35
        Dim l As Integer = 1
        Dim dt As New DataTable()
        llena_tablas(dt, "SELECT DISTINCT EMBARQUE, FECHA, DESTINO FROM PACKING_E LEFT JOIN CPO ON PACKING_E.CPO = CPO.CPO WHERE CLIENTE <> 'PERRY ELLIS' ORDER BY FECHA DESC", cnn)
        es.Rows.Count = dt.Rows.Count + 1
        If dt.Rows.Count = 0 Then
            Close()
        End If
        For Each Me.dr In dt.Rows
            es.Rows(l).Height = 22
            es(l, 1) = dr("FECHA")
            es(l, 2) = dr("EMBARQUE")
            es(l, 3) = dr("DESTINO")
            l = l + 1
        Next
    End Sub

    Private Sub es_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles es.DoubleClick
        Dim l As Integer = es.RowSel
        Cursor = Cursors.WaitCursor
        embarque.Text = es(l, 2)
        destino.Text = es(l, 3)
        es.Visible = False
        fg.Enabled = True
        Regresar.Visible = True
        Hoja.Visible = True
        Imprimir.Visible = True
        pd.Visible = True
        gs.Visible = True
        llena_descripcion()
        calcula_porcentaje()
        forma_lista()
        Cursor = Cursors.Default
    End Sub

    Private Sub gs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gs.Click
        Dim path As String = "c:\reportes\Shipment_" + embarque.Text + ".xls"
        Try
            If File.Exists(path) Then
                File.Delete(path)
            End If
        Catch
        End Try
        fg.SaveGrid(path, FileFormatEnum.Excel, FileFlags.IncludeFixedCells)
        Close()
    End Sub

End Class