Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized


Public Class Tela_oc
    Inherits System.Windows.Forms.Form
    Dim h As String = "####,##0.00"
    Dim g As String = "####,##0"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim tabla As New DataTable()
    Dim dr As DataRow
    Dim dw As DataRow
    Dim fechain As Date
    Dim fechafi As Date
    Dim STRSQL As String
    Dim CSQL As String
    Dim CLIENTE As String
    Dim ESTADO As String
    Dim lineas As Integer
    Dim ROLLO As String
    Dim COLORES As String
    Dim path As String = "c:\reportes\Utilizacion_OC.xls"
    Dim a As Integer = Screen.PrimaryScreen.Bounds.Height - 30
    Dim l As Integer = Screen.PrimaryScreen.Bounds.Width - 5
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents est As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Fechaf As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents jg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents re As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Button5 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tela_oc))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.est = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Fechaf = New System.Windows.Forms.DateTimePicker()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.jg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.re = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.re, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(600, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 43
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione para consultar.")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(680, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 44
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Fecha
        '
        Me.Fecha.CustomFormat = "dd/MM/yyyy"
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha.Location = New System.Drawing.Point(8, 24)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(104, 26)
        Me.Fecha.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Fecha, "Fecha incial")
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(720, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 50
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'est
        '
        Me.est.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.est.Location = New System.Drawing.Point(264, 24)
        Me.est.MaxDropDownItems = 10
        Me.est.Name = "est"
        Me.est.Size = New System.Drawing.Size(240, 24)
        Me.est.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.est, "Estilo a consultar.")
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(640, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 35)
        Me.Button4.TabIndex = 54
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button4, "Presione este Boton regresar a escoger Estilo ")
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Fechaf
        '
        Me.Fechaf.CustomFormat = "dd/MM/yyyy"
        Me.Fechaf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fechaf.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fechaf.Location = New System.Drawing.Point(128, 24)
        Me.Fechaf.Name = "Fechaf"
        Me.Fechaf.Size = New System.Drawing.Size(104, 26)
        Me.Fechaf.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Fechaf, "Fecha Final")
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.SteelBlue
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(816, 16)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(96, 35)
        Me.Button5.TabIndex = 59
        Me.Button5.Text = "Resumen"
        Me.ToolTip1.SetToolTip(Me.Button5, "Presione para consultar.")
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Fecha Inicial:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(0, 56)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 17
        Me.fg.Size = New System.Drawing.Size(1008, 440)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(264, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Estilo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Fecha Final:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'jg
        '
        Me.jg.AllowEditing = False
        Me.jg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.jg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.jg.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.jg.ColumnInfo = resources.GetString("jg.ColumnInfo")
        Me.jg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.jg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.jg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.jg.Location = New System.Drawing.Point(0, 496)
        Me.jg.Name = "jg"
        Me.jg.Rows.Count = 1
        Me.jg.Rows.DefaultSize = 17
        Me.jg.Size = New System.Drawing.Size(1008, 176)
        Me.jg.StyleInfo = resources.GetString("jg.StyleInfo")
        Me.jg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.jg.TabIndex = 57
        '
        're
        '
        Me.re.AllowEditing = False
        Me.re.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.re.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.re.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.re.ColumnInfo = resources.GetString("re.ColumnInfo")
        Me.re.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.re.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.re.ForeColor = System.Drawing.Color.Black
        Me.re.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.re.Location = New System.Drawing.Point(104, 216)
        Me.re.Name = "re"
        Me.re.Rows.Count = 6
        Me.re.Rows.DefaultSize = 17
        Me.re.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.re.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.re.Size = New System.Drawing.Size(784, 120)
        Me.re.StyleInfo = resources.GetString("re.StyleInfo")
        Me.re.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.re.TabIndex = 58
        '
        'Tela_oc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 684)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.jg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Fechaf)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.est)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.re)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tela_oc"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consumo de Tela por Estilo"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.re, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Tela_oc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Fecha.KeyPress, AddressOf keypressed1
        AddHandler Fechaf.KeyPress, AddressOf keypressed2
        AddHandler est.KeyPress, AddressOf keypressed3
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        Dim p As Point
        fg.Width = l - 20
        fg.Height = a - 185 - 70
        jg.Width = fg.Width - 80
        p.X = 0
        p.Y = fg.Height + 55
        jg.Location = p
        setea_grid()
        setea_jg()
        Fecha.Text = Today
        Fecha.Focus()
    End Sub

    Private Sub setea_grid()
        Try
            fg.Rows.Count = 1
            fg.Rows(0).Height = 30
            Dim s As C1.Win.C1FlexGrid.CellStyle
            s = fg.Styles.Add("verde")
            s.ForeColor = Color.Black
            s.BackColor = Color.LightBlue
            s = fg.Styles.Add("amarillo")
            s.ForeColor = Color.Black
            s.BackColor = Color.White
        Catch
        End Try
    End Sub

    Private Sub setea_jg()
        jg.Rows.Count = 1
        jg.Rows(0).Height = 30
    End Sub

    Private Sub llena_grid()
        Cursor = Cursors.WaitCursor
        ok = False
        lineas = 0
        setea_grid()
        subtotales()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        revisa_fechas(ok)
        fg.ScrollBars = ScrollBars.None
        If ok Then
            Fecha.Enabled = False
            Fechaf.Enabled = False
            est.Enabled = False
            Button1.Visible = False
            Button4.Visible = True
            Button2.Visible = True
            Button3.Visible = True
            llena_grid()
            calculo()
            colorea()
            llena_jg()
            Button5.Visible = True
        End If
        fg.ScrollBars = ScrollBars.Both
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fechas As String
        Dim cabeza As String
        fechain = CDate(Format(CDate(Fecha.Text), "dd-MM-yyyy"))
        fechafi = CDate(Format(CDate(Fechaf.Text), "dd-MM-yyyy"))
        cabeza = "Utilizacion de Tela del Estilo: " + est.Text + "  del " + fechain + " al " + fechafi + Chr(9) + Chr(9) + "Pagina: {0} "
        fechas = Format(Today, "dd/MM/yyy")
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = True
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("Utilizacion_Tela", PrintGridFlags.ShowPreviewDialog + PrintGridFlags.FitToPageWidth, cabeza, "")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print_fg()
    End Sub

    Private Sub subtotales()
        fg.Cols(1).AllowMerging = True
        fg.ScrollBars = ScrollBars.Both
        Cursor = Cursors.Default
    End Sub

    Private Sub calculo()
        Dim co As New DataTable()
        Dim mv As New DataTable()
        Dim td As New DataTable()
        Dim ct As String = ""
        Dim l As Integer = 1
        Dim dr As DataRow
        Dim dd As DataRow()
        Dim de As DataRow()
        Dim dw As DataRow
        Dim dc As DataRow
        Dim t As Integer
        Dim fin As String = Format(CDate(Fecha.Text), "yyyy-MM-dd")
        Dim ffn As String = Format(CDate(Fechaf.Text), "yyyy-MM-dd")
        Dim strsql As String = "SELECT * , SALA FROM CORTES LEFT JOIN CONSUMO_TELA ON CORTES.ESTILO = CONSUMO_TELA.ESTILO_CPO AND CORTES.COLOR = CONSUMO_TELA.COLOR_CPO LEFT JOIN CODIGO_TELA ON CODIGO_TELA.CODIGO = CONSUMO_TELA.CODIGO LEFT JOIN CORTES_S ON CORTES.CORTE = CORTES_S.CORTE WHERE CORTES.ESTILO = '" & est.Text & "' AND FCORTE BETWEEN '" & fin & "' AND '" & ffn & "' AND CORTES.TOTAL > 0 ORDER BY CORTES.CORTE"
        llena_tablas(co, strsql, cnn)
        fg.Rows.Count = co.Rows.Count + 1
        For Each dr In co.Rows
            fg(l, 1) = dr("CORTE")
            fg(l, 3) = dr("DESCRIPCION")
            fg(l, 4) = dr("COLOR_TELA")
            fg(l, 2) = dr("CPO")
            fg(l, 8) = dr("TOTAL")
            fg(l, 10) = dr("XS")
            fg(l, 11) = dr("S")
            fg(l, 12) = dr("M")
            fg(l, 13) = dr("L")
            fg(l, 14) = dr("XL")
            fg(l, 15) = dr("XL2")
            fg(l, 16) = dr("XL3")
            fg(l, 17) = dr("XL4")
            fg(l, 18) = dr("XL5")
            fg(l, 19) = dr("XL6")
            fg(l, 20) = dr("CODIGO")
            fg(l, 21) = dr("COLOR")
            fg(l, 22) = dr("SALA")
            fg(l, 0) = fg(l, 1) + dr("CODIGO") + fg(l, 4)
            If ct.IndexOf(fg(l, 1)) < 1 Then
                ct = ct + "'" + fg(l, 1) + "',"
            End If
            l = l + 1
        Next
        Try
            ct = Mid(ct, 1, ct.Length - 1)
        Catch
        End Try
        strsql = "SELECT DMOVTO.CORTE,ROLLOS.CODIGO,ROLLOS.COLOR,TMOVTO,SUM((ROLLOS.PESO/ROLLOS.YARDAS_I)*DMOVTO.YARDAS) AS LIBRAS FROM DMOVTO LEFT JOIN ROLLOS ON DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO  LEFT JOIN CORTES ON CORTES.CORTE = DMOVTO.CORTE WHERE  DMOVTO.CORTE IN (" & ct & ") AND ROLLOS.TIPO = 'TELA' AND  (DMOVTO.TMOVTO = '4' OR DMOVTO.TMOVTO = '2') GROUP BY DMOVTO.CORTE,TMOVTO,ROLLOS.CODIGO,ROLLOS.COLOR ORDER BY DMOVTO.CORTE,ROLLOS.CODIGO,TMOVTO"
        llena_tablas(mv, strsql, cnn)
        llena_tablas(td, "SELECT * FROM CODIGO_TELA", cnn)
        For Each dr In mv.Rows
            If dr("TMOVTO") = 4 Then
                t = 5
            Else
                t = 6
            End If
            l = fg.FindRow(dr("CORTE") + dr("CODIGO") + dr("COLOR"), 1, 0, False)
            If l = -1 Then
                dd = co.Select("CORTE = '" & dr("CORTE") & "'")
                If dd.Length > 0 Then
                    dw = dd(0)
                    l = fg.Rows.Count
                    fg.Rows.Count = l + 1
                    fg(l, 1) = dw("CORTE")
                    fg(l, 2) = dw("CPO")
                    de = td.Select("CODIGO = '" & dr("CODIGO") & "'")
                    If de.Length > 0 Then
                        dc = de(0)
                        fg(l, 3) = dc("DESCRIPCION")
                    Else
                        fg(l, 3) = ""
                    End If
                    fg(l, 4) = dr("COLOR")
                    fg(l, t) = fg(l, t) + dr("LIBRAS")
                    fg(l, 8) = dw("TOTAL")
                    fg(l, 10) = dw("XS")
                    fg(l, 11) = dw("S")
                    fg(l, 12) = dw("M")
                    fg(l, 13) = dw("L")
                    fg(l, 14) = dw("XL")
                    fg(l, 15) = dw("XL2")
                    fg(l, 16) = dw("XL3")
                    fg(l, 17) = dw("XL4")
                    fg(l, 18) = dw("XL5")
                    fg(l, 19) = dw("XL6")
                    fg(l, 20) = dr("CODIGO")
                    fg(l, 21) = dw("COLOR")
                    fg(l, 0) = fg(l, 1) + dr("CODIGO") + fg(l, 4)
                End If
            Else
                fg(l, t) = fg(l, t) + dr("LIBRAS")
            End If
        Next

        For t = 1 To fg.Rows.Count - 1
            fg(t, 7) = fg(t, 5) - fg(t, 6)
            If fg(t, 7) <= 0 Then
                fg(t, 21) = "ADIOS"
            End If
            Try
                fg(t, 9) = fg(t, 7) / fg(t, 8)
            Catch
                fg(t, 9) = 0
            End Try
        Next
        t = 1
        While t > 0
            t = fg.FindRow("ADIOS", 1, 21, False)
            Try
                fg.RemoveItem(t)
            Catch
            End Try
        End While
        fg.Sort(SortFlags.Ascending, 3)
        fg.Sort(SortFlags.Ascending, 2)
        fg.Sort(SortFlags.Ascending, 1)
    End Sub

    Private Sub llena_jg()
        Dim strSQL As String = "SELECT * FROM CONSUMO_TELA WHERE ESTILO_CPO = '" & est.Text & "'"
        Dim suma As String
        Dim i As Integer
        Dim l As Integer
        Dim j As Integer
        Dim dt As New DataTable()
        Dim foundrows() As DataRow
        llena_tablas(dt, strSQL, cnn)
        For i = 1 To fg.Rows.Count - 1
            l = jg.FindRow(fg(i, 3) + fg(i, 4) + fg(i, 21), 1, 0, True)
            If l < 1 Then
                l = jg.Rows.Count
                jg.Rows.Count = l + 1
                jg(l, 1) = fg(i, 3)
                jg(l, 2) = fg(i, 4)
                jg(l, 3) = fg(i, 21)
                suma = "CODIGO = '" & fg(i, 20) & "' AND COLOR_TELA = '" & jg(l, 2) & "' AND COLOR_CPO = '" & jg(l, 3) & "'"
                foundrows = dt.Select(suma)
                For j = 0 To foundrows.GetUpperBound(0)
                    dr = foundrows(j)
                    jg(l, 4) = dr("LIBRAS")
                Next
                jg(l, 0) = fg(i, 3) + fg(i, 4) + fg(i, 21)
            End If
            jg(l, 5) = jg(l, 5) + fg(i, 8)
            jg(l, 6) = (jg(l, 4) * jg(l, 5))
            jg(l, 7) = jg(l, 7) + fg(i, 7)
            jg(l, 8) = jg(l, 6) - jg(l, 7)
            Try
                jg(l, 9) = (jg(l, 7) * 100) / jg(l, 6)
            Catch
                jg(l, 9) = 0
            End Try
        Next
        For l = 1 To jg.Rows.Count - 1
            If jg(l, 9) > 100 Then
                jg.SetCellStyle(l, 9, jg.Styles("rojo"))
            End If
            If jg(l, 4) = 0 Then
                jg.SetCellStyle(l, 4, jg.Styles("rojo"))
                jg.SetCellStyle(l, 9, jg.Styles("rojo"))
            End If
        Next
        jg.Sort(SortFlags.Ascending, 1)
    End Sub

    Private Sub resumen()
        Dim i As Integer
        Dim l As Integer
        Dim prendas As Integer
        re.Rows.Count = 1
        For i = 1 To jg.Rows.Count - 1
            l = re.FindRow(jg(i, 1), 1, 1, True)
            If l = -1 Then
                l = re.Rows.Count
                re.Rows.Count = l + 1
                re(l, 1) = jg(i, 1)
            End If
            prendas = jg(i, 5)
            If jg(i, 6) > 0 Then
                re(l, 2) = ((re(l, 2) * re(l, 6)) + jg(i, 6)) / (re(l, 6) + prendas)
            Else
                prendas = 0
            End If
            Try
                re(l, 3) = ((re(l, 3) * re(l, 6)) + jg(i, 7)) / (re(l, 6) + prendas)
            Catch
            End Try
            re(l, 4) = re(l, 2) - re(l, 3)
            Try
                re(l, 5) = (re(l, 3) * 100) / re(l, 2)
            Catch
            End Try
            re(l, 6) = re(l, 6) + prendas
        Next
        Dim forma As New Tela_oc_1()
        forma.re = re
        forma.ShowDialog()
    End Sub


    Private Sub colorea()
        Dim i As Integer
        Dim corte As String = ""
        fg.Sort(SortFlags.Ascending, 1)
        For i = 1 To fg.Rows.Count - 1
            If fg(i, 1) <> corte Then
                If COLORES = "amarillo" Then
                    COLORES = "verde"
                Else
                    COLORES = "amarillo"
                End If
                corte = fg(i, 1)
            End If
            fg.Rows(i).Style = fg.Styles(COLORES)
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ok As Boolean
        llena_hoja(ok)
        If ok Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio: " + path, MsgBoxStyle.OKOnly, "TRASLADO DE DATOS ")
            Close()
        End If
    End Sub

    Private Sub llena_hoja(ByRef ok As Boolean)
        Try
            Dim ch As Char = Microsoft.VisualBasic.Chr(9)
            fg.Subtotal(AggregateEnum.Clear)
            If File.Exists(path) Then
                File.Delete(path)
            End If
            fg.SaveGrid(path, FileFormatEnum.Excel, FileFlags.IncludeFixedCells)
            System.Diagnostics.Process.Start(path)
            ok = True
        Catch
            MsgBox("Por favor cierre todas sus Hojas de Excel y vuelva a tratar. Gracias", MsgBoxStyle.OKOnly, "Atencion ")
            ok = False
        End Try
    End Sub

    Private Sub Fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fecha.ValueChanged
        llena_estilo()
    End Sub

    Private Sub Fechaf_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechaf.ValueChanged
        llena_estilo()
    End Sub

    Private Sub revisa_fechas(ByRef ok As Boolean)
        ok = True
        fechain = CDate(Format(CDate(Fecha.Text), "yyyy-MM-dd"))
        fechafi = CDate(Format(CDate(Fechaf.Text), "yyyy-MM-dd"))
        If fechafi < fechain Then
            MsgBox("Error !!!   Fecha inicial es mayor que la Fecha final ", MsgBoxStyle.Critical, "Por favor Revise !!!!")
            ok = False
        End If
    End Sub

    Private Sub llena_estilo()
        est.Items.Clear()
        Try
            Dim strSQL As String = "SELECT DISTINCT ESTILO FROM CORTES WHERE FCORTE BETWEEN '" & Format(CDate(Fecha.Text), "yyyy-MM-dd") & "' AND '" & Format(CDate(Fechaf.Text), "yyyy-MM-dd") & "' ORDER BY ESTILO"
            llena_tablas(dt, strSQL, cnn)
            For Each Me.dr In dt.Rows
                est.Items.Add(dr("ESTILO"))
            Next
            Try
                est.SelectedIndex = 0
            Catch
            End Try
        Catch
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        setea_grid()
        setea_jg()
        Fecha.Enabled = True
        Fechaf.Enabled = True
        est.Enabled = True
        Button1.Visible = True
        Button4.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button5.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        resumen()
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        resumen()
    End Sub
    '================================== HANDLERS ================================

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Fecha.Text) <> "" Then
                Fechaf.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Fechaf.Text) <> "" Then
                est.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(est.Text) <> "" Then
                Button1.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub est_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles est.KeyPress
        AutoCompletar(est, e)
    End Sub
End Class
