Imports System
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Diagnostics
Imports C1.C1Excel
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing


Public Class Lista_empaque_s
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim strSQl As String
    Dim dr As DataRow
    Dim dw As DataRow
    Dim dp As New DataTable()
    Dim cp As New DataTable()
    Dim ex As New DataTable()
    Dim batch As String
    Dim fpo As String
    Dim _styles As New Hashtable()
    Dim destino As String
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
    Friend WithEvents Regresar As System.Windows.Forms.Button
    Friend WithEvents pdf As C1.C1Pdf.C1PdfDocument
    Friend WithEvents su As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents es As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents _book As C1.C1Excel.C1XLBook
    Friend WithEvents hoja As System.Windows.Forms.Button
    Friend WithEvents embarque As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents _ex As C1.C1Excel.C1XLBook
    Friend WithEvents Imprimir As System.Windows.Forms.Button
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lista_empaque_s))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Regresar = New System.Windows.Forms.Button()
        Me.es = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.hoja = New System.Windows.Forms.Button()
        Me.Imprimir = New System.Windows.Forms.Button()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.su = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.embarque = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.es, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.su, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        '
        'Regresar
        '
        Me.Regresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Regresar.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar.ForeColor = System.Drawing.Color.Black
        Me.Regresar.Image = CType(resources.GetObject("Regresar.Image"), System.Drawing.Image)
        Me.Regresar.Location = New System.Drawing.Point(872, 8)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(35, 35)
        Me.Regresar.TabIndex = 7
        Me.Regresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Regresar, "Presione este Boton para Refrescar la pantalla  y volver a solicitar datos de bus" &
        "queda.")
        Me.Regresar.UseVisualStyleBackColor = False
        Me.Regresar.Visible = False
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
        Me.es.Location = New System.Drawing.Point(8, 8)
        Me.es.Name = "es"
        Me.es.Rows.Count = 1
        Me.es.Rows.DefaultSize = 21
        Me.es.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.es.Size = New System.Drawing.Size(576, 696)
        Me.es.StyleInfo = resources.GetString("es.StyleInfo")
        Me.es.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.es, "Presione doble click para seleccionar un Embarque específico.")
        Me.es.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'hoja
        '
        Me.hoja.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.hoja.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.hoja.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hoja.ForeColor = System.Drawing.Color.Black
        Me.hoja.Image = CType(resources.GetObject("hoja.Image"), System.Drawing.Image)
        Me.hoja.Location = New System.Drawing.Point(952, 8)
        Me.hoja.Name = "hoja"
        Me.hoja.Size = New System.Drawing.Size(35, 35)
        Me.hoja.TabIndex = 5
        Me.hoja.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.hoja, "Convierte a Excel")
        Me.hoja.UseVisualStyleBackColor = False
        Me.hoja.Visible = False
        '
        'Imprimir
        '
        Me.Imprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Imprimir.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Imprimir.ForeColor = System.Drawing.Color.Black
        Me.Imprimir.Image = CType(resources.GetObject("Imprimir.Image"), System.Drawing.Image)
        Me.Imprimir.Location = New System.Drawing.Point(912, 8)
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(35, 35)
        Me.Imprimir.TabIndex = 93
        Me.Imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Imprimir, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Imprimir.UseVisualStyleBackColor = False
        Me.Imprimir.Visible = False
        '
        'fecha
        '
        Me.fecha.CalendarForeColor = System.Drawing.SystemColors.Highlight
        Me.fecha.CustomFormat = "dd/MM/yyyy"
        Me.fecha.Enabled = False
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha.Location = New System.Drawing.Point(312, 16)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(104, 22)
        Me.fecha.TabIndex = 94
        Me.ToolTip1.SetToolTip(Me.fecha, "Fecha del Embarque")
        Me.fecha.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(24, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 32)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Embarque:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'su
        '
        Me.su.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.su.AllowEditing = False
        Me.su.AllowFiltering = True
        Me.su.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.su.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.su.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.su.BackColor = System.Drawing.Color.White
        Me.su.ColumnInfo = resources.GetString("su.ColumnInfo")
        Me.su.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.su.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.su.ForeColor = System.Drawing.Color.Black
        Me.su.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.su.Location = New System.Drawing.Point(9, 56)
        Me.su.Name = "su"
        Me.su.Rows.Count = 1
        Me.su.Rows.DefaultSize = 21
        Me.su.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.su.Size = New System.Drawing.Size(983, 408)
        Me.su.StyleInfo = resources.GetString("su.StyleInfo")
        Me.su.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.su.TabIndex = 90
        '
        'embarque
        '
        Me.embarque.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.embarque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.embarque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.embarque.ForeColor = System.Drawing.Color.Black
        Me.embarque.Location = New System.Drawing.Point(128, 8)
        Me.embarque.Name = "embarque"
        Me.embarque.Size = New System.Drawing.Size(168, 32)
        Me.embarque.TabIndex = 91
        Me.embarque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(8, 472)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 22
        Me.fg.Size = New System.Drawing.Size(984, 232)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 92
        '
        'Lista_empaque_s
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 703)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.Imprimir)
        Me.Controls.Add(Me.es)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.embarque)
        Me.Controls.Add(Me.hoja)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.su)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Lista_empaque_s"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Empaque Segundas"
        CType(Me.es, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.su, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Lista_empaque_4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        llena_es()
    End Sub

    Private Sub setea_grid()
        su.Rows.Count = 1
        embarque.Text = ""
    End Sub

    Private Sub llena_es()
        es.Visible = True
        es.Rows.Count = 1
        es.Rows(0).Height = 35
        Dim l As Integer = 1
        Dim dt As New DataTable()
        llena_tablas(dt, "SELECT DISTINCT EMBARQUE, FECHA  FROM PACKING_E WHERE EMBARQUE LIKE 'SEG-%' ORDER BY FECHA DESC", cnn)
        es.Rows.Count = dt.Rows.Count + 1
        If dt.Rows.Count = 0 Then
            '  Close()
        End If
        For Each Me.dr In dt.Rows
            es.Rows(l).Height = 22
            es(l, 1) = dr("FECHA")
            es(l, 2) = dr("EMBARQUE")
            es(l, 3) = "JT"
            l = l + 1
        Next
        setea_grid()
        Regresar.Visible = False
        hoja.Visible = False
        su.Enabled = False
    End Sub

    Private Sub es_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles es.DoubleClick
        Dim l As Integer = es.RowSel
        embarque.Text = es(l, 2)
        destino = es(l, 3)
        fecha.Text = es(l, 1)
        es.Visible = False
        su.Enabled = True
        Regresar.Visible = True
        Imprimir.Visible = True
        hoja.Visible = True
        llena_su()
        llena_fg()
    End Sub

    Private Sub busca_batch(ByVal cpo As String, ByVal estilo As String, ByVal colo As String, ByRef batch As String, ByRef fpo As String, ByRef cortes As String, ByRef seccion As String)
        Dim dw As DataRow()
        Dim dr As DataRow
        Dim bt As String
        Dim fp As String
        Dim ct As String
        Dim sc As String
        batch = ""
        fpo = ""
        cortes = ""
        seccion = ""
        dw = cp.Select("CPO = '" & cpo & "' AND ESTILO = '" & estilo & "' AND COLOR = '" & colo & "'")
        For Each dr In dw
            bt = dr("BATCH")
            fp = dr("FPO")
            ct = dr("CORTE")
            sc = dr("SECCION")
            If batch.IndexOf(bt + " ") = -1 Then
                batch = batch + bt + " "
            End If
            If fpo.IndexOf(fp + " ") = -1 Then
                fpo = fpo + fp + " "
            End If
            If cortes.IndexOf(ct + " ") = -1 Then
                cortes = cortes + ct + " "
            End If
            If seccion.IndexOf(sc + " ") = -1 Then
                seccion = seccion + sc + " "
            End If
        Next
    End Sub

    Private Sub Hoja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hoja.Click
        Dim nombre As String = embarque.Text
        adios(nombre)
        Dim path As String = "c:\reportes\Shipment_" + nombre
        Try
            'a_excel(fg, path + ".xls", ok)
            a_pdf(fg, path + ".pdf", "Shipment: " + embarque.Text, "")
            MsgBox("Sus datos fueron trasladados a Excel en el directorio: " + path, MsgBoxStyle.OKOnly, "TRASLADO DE DATOS ")
            Close()
        Catch
            MsgBox("Por favor cierre todas sus Hojas de Excel y vuelva a tratar. Gracias", MsgBoxStyle.OKOnly, "Atencion ")
        End Try

    End Sub

    Private Sub Regresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Regresar.Click
        Imprimir.Visible = False
        fg.Rows.Count = 1
        es.Visible = True
        'llena_es()
        es.Focus()
    End Sub

    Private Sub llena_cortes()
        cp = New DataTable()
        llena_tablas(cp, "SELECT * FROM CORTES WHERE CPO + ESTILO + COLOR IN (SELECT CPO+ESTILO+COLOR FROM PACKING_E WHERE EMBARQUE = '" & embarque.Text & "')", cnn)
    End Sub


    Private Sub llena_su()
        Dim sum As New DataTable
        Dim l As Integer = 1
        Dim r As Integer
        Dim total As Integer
        Dim strsql As String = "SELECT * FROM PACKING_C WHERE EMBARQUE = '" & embarque.Text & "' ORDER BY CAJA,ESTILO,COLOR "
        llena_tablas(sum, strsql, cnn)
        su.Rows(0).Height = 40
        su.Rows.Count = sum.Rows.Count + 2
        r = sum.Rows.Count + 1
        For Each Me.dr In sum.Rows
            su.Rows(l).Height = 22
            su(l, 1) = dr("CAJA")
            su(l, 2) = dr("ESTILO")
            su(l, 3) = dr("COLOR")
            su(l, 4) = dr("TALLA")
            su(l, 6) = dr("PRENDAS")
            su(l, 7) = dr("PRENDAS")
            total = total + dr("PRENDAS")
            l = l + 1
        Next
        su.Rows(r).Height = 30
        su(r, 3) = "GRAND TOTAL ....."
        su(r, 7) = total

        Dim rgn As CellRange
        rgn = su.GetCellRange(0, 0, 0, 7)
        rgn.Style = su.Styles("amarillo")

        rgn = su.GetCellRange(r, 0, r, 7)
        rgn.Style = su.Styles("totalon")
    End Sub

    Private Sub llena_fg()
        Dim i As Integer
        Dim total As Integer
        fg.Rows.Count = 1
        fg.Rows(0).Height = 35
        Dim l As Integer = 1
        Dim dt As New DataTable()
        llena_tablas(dt, "SELECT * FROM PACKING_D LEFT JOIN CORTES ON PACKING_D.CORTE = CORTES.CORTE WHERE EMBARQUE = '" & embarque.Text & "' ORDER BY PACKING_D.ESTILO,PACKING_D.COLOR", cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each Me.dr In dt.Rows
            fg(l, 0) = dr("EMBARQUE")
            fg(l, 1) = dr("ESTILO")
            fg(l, 2) = dr("COLOR")
            fg(l, 3) = dr("CORTE")
            fg(l, 4) = dr(20)
            total = 0
            For i = 8 To 17
                fg(l, i - 3) = dr(i)
                total = total + dr(i)
            Next
            fg(l, 15) = total
            fg(l, 16) = dr("SECCION")
            l = l + 1
        Next
    End Sub


    Private Sub Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Imprimir.Click
        Print_fg()
    End Sub

    Private Sub Print_fg()
        Dim fechas As String = Format(fecha.Text, "MMM-dd-yyyy")
        Dim pd As PrintDocument
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
        fg.PrintGrid("Packing List", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, "Packing List (Irregulars)  Shipment: " + embarque.Text + Chr(9) + Chr(9) + "Page {0}", "Shipment date: " + fechas)

        pd = su.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = False
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With
        su.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        su.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        su.PrintGrid("Packing List", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, "Packing List (Irregulars)  Shipment: " + embarque.Text + Chr(9) + Chr(9) + "Page {0}", "Shipment date: " + fechas)
    End Sub

End Class