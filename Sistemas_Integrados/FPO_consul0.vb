Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized


Public Class FPO_consul0
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim g As String = "#######0"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn1 As New SqlClient.SqlConnection()
    Dim STRSQL As String
    Dim CSQL As String
    Dim CLIENTE As String
    Dim ESTADO As String
    Dim lineas As Integer
    Dim ROLLO As String

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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents FPOS As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents regresa As System.Windows.Forms.Button
    Friend WithEvents tipos As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FPO_consul0))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FPOS = New System.Windows.Forms.ComboBox()
        Me.tipos = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.regresa = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FPOS
        '
        Me.FPOS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.FPOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FPOS.Location = New System.Drawing.Point(8, 24)
        Me.FPOS.Name = "FPOS"
        Me.FPOS.Size = New System.Drawing.Size(240, 24)
        Me.FPOS.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.FPOS, "Elija la Fabric PO  a Consultar .")
        '
        'tipos
        '
        Me.tipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tipos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipos.Items.AddRange(New Object() {"TELA", "CUELLOS Y PUÑOS"})
        Me.tipos.Location = New System.Drawing.Point(280, 24)
        Me.tipos.Name = "tipos"
        Me.tipos.Size = New System.Drawing.Size(168, 24)
        Me.tipos.TabIndex = 55
        Me.ToolTip1.SetToolTip(Me.tipos, "Elija  el Tipo a Consultar")
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(567, 11)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 50
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton si Desea enviar a Excel  los Datos mostrados en la Pantalla.")
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(526, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 44
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(485, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 43
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Una vez Seleccionado el Estado y el  Cliente que se quiere consultar  Presione es" & _
                "te Boton para Iniciar la Busqueda")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'regresa
        '
        Me.regresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.regresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresa.ForeColor = System.Drawing.Color.Black
        Me.regresa.Image = CType(resources.GetObject("regresa.Image"), System.Drawing.Image)
        Me.regresa.Location = New System.Drawing.Point(485, 13)
        Me.regresa.Name = "regresa"
        Me.regresa.Size = New System.Drawing.Size(35, 35)
        Me.regresa.TabIndex = 53
        Me.regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.regresa, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.regresa.UseVisualStyleBackColor = False
        Me.regresa.Visible = False
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 56)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.Size = New System.Drawing.Size(968, 608)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 45
        Me.fg.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "FPO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(280, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 24)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Tipo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FPO_consul0
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 668)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tipos)
        Me.Controls.Add(Me.FPOS)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.regresa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FPO_consul0"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Fpos"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FPO_consul1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        busca_fpos()
        setea_grid()
        FPOS.SelectedIndex = 0
        tipos.SelectedIndex = 0
        FPOS.Focus()
    End Sub

    Private Sub setea_grid()
        Dim index As Integer
        fg.Rows.Count = 1
        fg.Cols.Count = 25
        fg.Cols(0).Width = 0
        fg.Rows(0).Height = 30
        fg.Cols(1).Name = "FPO"
        fg.Cols(2).Name = "KNIT"
        fg.Cols(3).Name = "COLOR"
        fg.Cols(4).Name = "TIPO"
        fg.Cols(5).Name = "LOTE"
        fg.Cols(6).Name = "CODIGO    DESCRIPCION"
        fg.Cols(7).Name = "CLIENTE"
        fg.Cols(8).Name = "YARN "
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
        fg.Cols(22).Name = "TEXTILERA"
        fg.Cols(23).Name = "EN TEXTI."
        fg.Cols(24).Name = "F.CONFIRMADA"
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 70
            fg(0, index) = fg.Cols(index).Name
            If index > 11 And index < 16 Then
                fg.Cols(index).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
                fg.Cols(index).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
            End If
        Next
        fg.Cols(1).Width = 60
        fg.Cols(2).Width = 110
        fg.Cols(3).Width = 120
        fg.Cols(4).Width = 60
        fg.Cols(5).Width = 60
        fg.Cols(6).Width = 300
        fg.Cols(7).Width = 100
        fg.Cols(8).Width = 100
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
        fg.Cols(22).Width = 150
        fg.Cols(24).Width = 150
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
        fg.Cols(23).Format = h
        fg.Cols(23).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
        fg.Cols(23).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
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
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim ahora As DateTime = DateTime.Now
        Dim semana As DateTime = ahora.AddDays(8)
        Dim req As Date
        Dim tipo As String
        If tipos.SelectedIndex = 0 Then
            tipo = "AND FPO.TIPO = 'TELA'"
        Else
            tipo = "AND FPO.TIPO <> 'TELA'"
        End If
        STRSQL = "SELECT FPO.*, F_CONFIRMADA,DESCRIPCION FROM FPO LEFT JOIN  CODIGO_TELA ON FPO.CODIGO = CODIGO_TELA.CODIGO LEFT JOIN FPO_CONFIRMADA ON FPO.FPO = FPO_CONFIRMADA.FPO AND FPO.TIPO = FPO_CONFIRMADA.TIPO AND FPO.KNIT = FPO_CONFIRMADA.KNIT AND FPO.COLOR = FPO_CONFIRMADA.COLOR AND FPO.LOTE = FPO_CONFIRMADA.LOTE WHERE FPO.FPO= '" & FPOS.SelectedItem & "' " & tipo
        ' STRSQL = "SELECT * FROM FPO LEFT JOIN  CODIGO_TELA ON FPO.CODIGO = CODIGO_TELA.CODIGO WHERE YEAR(IFECHA) = '2013' AND TIPO = 'TELA'"
        llena_tablas(dt, STRSQL, cnn1)
        lineas = dt.Rows.Count
        fg.Rows.Count = lineas + 1
        lineas = 1
        For Each dr In dt.Rows
            ESTADO = Trim(dr("STATUS"))
            fg(lineas, 1) = dr("FPO")
            fg(lineas, 2) = dr("KNIT")
            fg(lineas, 3) = dr("COLOR")
            fg(lineas, 4) = dr("TIPO")
            fg(lineas, 5) = dr("LOTE")
            fg(lineas, 6) = dr("CODIGO") & " - " & dr("DESCRIPCION")
            fg(lineas, 7) = dr("CLIENTE")
            fg(lineas, 8) = dr("YSIZE") + " " + dr("YFIBER") + " " + dr("YFINISH")
            fg(lineas, 9) = dr("LIBRAS")
            fg(lineas, 10) = dr("RECIBIDAS")
            fg(lineas, 11) = fg(lineas, 9) - fg(lineas, 10)
            fg(lineas, 12) = dr("IFECHA")
            fg(lineas, 13) = dr("RFECHA")
            fg(lineas, 14) = dr("OFECHA")
            fg(lineas, 16) = dr("ESTILO")
            fg(lineas, 17) = dr("CPO")
            fg(lineas, 18) = dr("ANCHO")
            fg(lineas, 19) = dr("PRECIO")
            fg(lineas, 20) = dr("PESO")
            fg(lineas, 21) = ESTADO
            fg(lineas, 22) = dr("TEXTILERA")
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
            If IsDBNull(dr("F_CONFIRMADA")) = False Then
                fg(lineas, 24) = dr("F_CONFIRMADA")
            End If
            lineas = lineas + 1
        Next
        fecha_recepcion()
        textilera()
        subtotales()
    End Sub

    Private Sub fecha_recepcion()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim fila As String
        Dim sel As Integer
        STRSQL = "SELECT DISTINCT FECHA, DMOVTO.FPO, TIPO, KNIT,COLOR, DMOVTO.BATCH FROM DMOVTO, ROLLOS WHERE DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO AND TMOVTO = '1' AND DMOVTO.FPO = '" & FPOS.SelectedItem & "'"
        ' STRSQL = "SELECT DISTINCT FECHA, DMOVTO.FPO, TIPO, KNIT,COLOR, DMOVTO.BATCH FROM DMOVTO, ROLLOS WHERE DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO AND TMOVTO = '1' AND YEAR(FECHA) = '2013'"
        llena_tablas(dt, STRSQL, cnn1)
        For Each dr In dt.Rows
            fila = dr("FPO") + dr("KNIT") + dr("COLOR") + dr("TIPO") + CStr(dr("BATCH"))
            sel = fg.FindRow(fila, 1, 0, True)
            If sel > 0 Then
                Try
                    fg(sel, 15) = dr("FECHA")
                Catch
                End Try
            End If
        Next
    End Sub

    Private Sub textilera()
        Dim fila As String
        Dim sel As Integer
        Dim textilera As New DataTable()
        STRSQL = "SELECT FPO,KNIT,COLOR,TIPO,LOTE,(SUM(ROLLOS.PESO)/SUM(ROLLOS.YARDAS_I) * SUM(ROLLOS.YARDAS)) AS LIBRAS FROM ROLLOS WHERE YARDAS >0 AND ACTIVO = '6' AND FPO = '" & FPOS.SelectedItem & "' GROUP BY FPO,KNIT,COLOR,TIPO,LOTE "
        Dim dr As DataRow
        llena_tablas(textilera, STRSQL, cnn1)
        fila = textilera.Rows.Count
        For Each dr In textilera.Rows
            fila = dr("FPO") & dr("KNIT") & dr("COLOR") & dr("TIPO") & CStr(dr("LOTE"))
            sel = fg.FindRow(fila, 1, 0, True)
            Try
                fg(sel, 23) = dr("LIBRAS")
            Catch
            End Try
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cursor = Cursors.WaitCursor
        setea_grid()
        llena_grid()
        Button1.Visible = False
        Button2.Visible = True
        Button3.Visible = True
        regresa.Visible = True
        FPOS.Enabled = False
        tipos.Enabled = False
        Cursor = Cursors.Default
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        fecha = Format(Today, "dd/MM/yyy")
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
        fg.PrintGrid("inventario", PrintGridFlags.ShowPreviewDialog, "Consulta de la FPO: " + FPOS.SelectedItem + "   al " + fecha + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print_fg()
    End Sub

    Private Sub subtotales()
        fg.Cols.Remove(0)
        fg.Cols.Insert(0)
        fg.Cols(0).Width = 0
        fg.ScrollBars = ScrollBars.Both
        'fg.Cols(0).AllowMerging = True
        fg.Cols(1).AllowMerging = True
        fg.Cols(2).AllowMerging = True
        fg.Cols(3).AllowMerging = True
        fg.Cols(4).AllowMerging = True
        fg.Cols(5).AllowMerging = True
        fg.Subtotal(AggregateEnum.Clear)
        fg.Subtotal(AggregateEnum.Sum, 1, 2, 3, 9, "Totales {0}")
        fg.Subtotal(AggregateEnum.Sum, 1, 2, 3, 10, "Totales {0}")
        fg.Subtotal(AggregateEnum.Sum, 1, 2, 3, 11, "Totales {0}")
        fg.Subtotal(AggregateEnum.Sum, 1, 2, 3, 23, "Totales {0}")
        fg.Subtotal(AggregateEnum.Sum, 0, 0, 0, 9, "Gran TOTAL ---->")
        fg.Subtotal(AggregateEnum.Sum, 0, 0, 0, 10, "Gran TOTAL ---->")
        fg.Subtotal(AggregateEnum.Sum, 0, 0, 0, 11, "Gran TOTAL ---->")
        fg.Subtotal(AggregateEnum.Sum, 0, 0, 0, 23, "Gran TOTAL ---->")
        fg.Redraw = True
        Cursor = Cursors.Default
    End Sub

    Private Sub datos_excel(ByRef si As Boolean)
        Dim path As String = "c:\reportes\Fpos.xls"
        Try
            If File.Exists(path) Then
                File.Delete(path)
            End If
            fg.Subtotal(AggregateEnum.Clear)
            fg.SaveGrid(path, FileFormatEnum.Excel, FileFlags.IncludeFixedCells)
            System.Diagnostics.Process.Start(path)
            si = True
        Catch
            MsgBox("Por favor cierre todas sus Hojas de Excel y vuelva a tratar. Gracias", MsgBoxStyle.OKOnly, "Atencion ")
            si = False
        End Try
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim si As Boolean
        datos_excel(si)
        If si Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio:  C:/  bajo el nombre de Diaria.xls ", MsgBoxStyle.OKOnly, "TRASLADO DE DATOS ")
            Close()
        End If
    End Sub

    Private Sub busca_fpos()
        Dim dt As New DataTable()
        Dim dr As DataRow
        FPOS.Items.Clear()
        Dim strSQL As String = "SELECT DISTINCT FPO FROM FPO order by 1"
        llena_tablas(dt, strSQL, cnn1)
        For Each dr In dt.Rows
            FPOS.Items.Add(dr("FPO"))
        Next
        Try
            FPOS.SelectedIndex = 0
        Catch
        End Try
    End Sub

    Private Sub regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regresa.Click
        setea_grid()
        Button1.Visible = True
        Button2.Visible = False
        Button3.Visible = False
        FPOS.Enabled = True
        tipos.Enabled = True
    End Sub

    Private Sub fpos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FPOS.KeyPress
        AutoCompletar(FPOS, e)
    End Sub
End Class
