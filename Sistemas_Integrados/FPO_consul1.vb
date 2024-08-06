Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized


Public Class FPO_consul1
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim g As String = "#######0"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Dim STRSQL As String
    Dim CSQL As String
    Dim CLIENTE As String
    Dim ESTADO As String
    Dim lineas As Integer
    Dim ROLLO As String
    Dim da As System.Data.SqlClient.SqlDataAdapter
    Dim ds As DataSet
    Dim det As String
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
    Friend WithEvents C3 As System.Windows.Forms.ComboBox
    Friend WithEvents C4 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents regresa As System.Windows.Forms.Button
    Friend WithEvents tipos As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FPO_consul1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.C3 = New System.Windows.Forms.ComboBox()
        Me.C4 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.regresa = New System.Windows.Forms.Button()
        Me.tipos = New System.Windows.Forms.ComboBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Estado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'C3
        '
        Me.C3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C3.Items.AddRange(New Object() {"TODOS", "ABIERTO", "CERRADO", "CANCELADO", "RECHAZADO"})
        Me.C3.Location = New System.Drawing.Point(16, 24)
        Me.C3.Name = "C3"
        Me.C3.Size = New System.Drawing.Size(112, 21)
        Me.C3.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.C3, "Estado de la FPO")
        '
        'C4
        '
        Me.C4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C4.Location = New System.Drawing.Point(160, 24)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(128, 21)
        Me.C4.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.C4, "Elija el Cliente a Consultar o seleccione ""TODOS"" para una Busqueda Total")
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(160, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cliente"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Bitmap)
        Me.Button1.Location = New System.Drawing.Point(576, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 43
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Una vez Seleccionado el Estado y el  Cliente que se quiere consultar  Presione es" & _
        "te Boton para Iniciar la Busqueda")
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Bitmap)
        Me.Button2.Location = New System.Drawing.Point(632, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 44
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Bitmap)
        Me.Button3.Location = New System.Drawing.Point(688, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 50
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton si Desea enviar a Excel  los Datos mostrados en la Pantalla.")
        Me.Button3.Visible = False
        '
        'regresa
        '
        Me.regresa.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.regresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresa.ForeColor = System.Drawing.Color.Black
        Me.regresa.Image = CType(resources.GetObject("regresa.Image"), System.Drawing.Bitmap)
        Me.regresa.Location = New System.Drawing.Point(576, 8)
        Me.regresa.Name = "regresa"
        Me.regresa.Size = New System.Drawing.Size(35, 35)
        Me.regresa.TabIndex = 54
        Me.regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.regresa, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.regresa.Visible = False
        '
        'tipos
        '
        Me.tipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tipos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipos.Items.AddRange(New Object() {"TELA", "CUELLOS Y PUÑOS"})
        Me.tipos.Location = New System.Drawing.Point(312, 24)
        Me.tipos.Name = "tipos"
        Me.tipos.Size = New System.Drawing.Size(168, 21)
        Me.tipos.TabIndex = 56
        Me.ToolTip1.SetToolTip(Me.tipos, "Elija  el Tipo a Consultar")
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "1{TextAl" & _
        "ign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{TextAlign:LeftCenter;TextAlignFixed" & _
        ":LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{TextAlign:Lef" & _
        "tCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{TextAlign:LeftCenter;TextAlignFixed:LeftCe" & _
        "nter;}" & Microsoft.VisualBasic.ChrW(9) & "6{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{TextAlign:LeftCenter" & _
        ";TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "8{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & _
        "9{TextAlign:LeftCenter;TextAlignFixed:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.Size = New System.Drawing.Size(984, 616)
        Me.fg.StyleInfo = "Normal{Font:Microsoft Sans Serif, 8.25pt;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{}" & Microsoft.VisualBasic.ChrW(9) & "Fixed" & _
        "{BackColor:95, 156, 239;ForeColor:Black;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlig" & _
        "ht{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Focus{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackCol" & _
        "or:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:PaleGoldenrod;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & _
        "" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTota" & _
        "l{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:64, 64, 64;ForeColor:Whi" & _
        "te;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor:204, 239, 249;ForeColor:64, 64, 64;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColo" & _
        "r:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColo" & _
        "r:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackCo" & _
        "lor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(312, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Tipo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'FPO_consul1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(998, 668)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label3, Me.tipos, Me.Button3, Me.Button2, Me.Button1, Me.C4, Me.Label2, Me.C3, Me.Label1, Me.fg, Me.regresa})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FPO_consul1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Fpos por Cliente"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FPO_consul1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        llena_clientes(C4)
        setea_grid()
        C3.SelectedIndex = 1
        C4.SelectedIndex = 0
        tipos.SelectedIndex = 0
    End Sub

    Private Sub setea_grid()
        Try
            Dim index As Integer
            fg.Clear(ClearFlags.Style)
            fg.ScrollBars = ScrollBars.None
            fg.Rows.Count = 1
            fg.Cols.Count = 26
            fg.Cols(0).Width = 0
            fg.Rows(0).Height = 30
            fg.Cols(1).Name = "FPO"
            fg.Cols(2).Name = "KNIT"
            fg.Cols(3).Name = "COLOR"
            fg.Cols(4).Name = "TIPO"
            fg.Cols(5).Name = "LOTE"
            fg.Cols(6).Name = "CLIENTE"
            fg.Cols(7).Name = "DESCRIPCION TELA"
            fg.Cols(8).Name = "YARN FINISH"
            fg.Cols(9).Name = "LIBRAS"
            fg.Cols(10).Name = "RECIBIDO"
            fg.Cols(11).Name = "BALANCE"
            fg.Cols(12).Name = "F.FPO"
            fg.Cols(13).Name = "F.REQ"
            fg.Cols(14).Name = "F.OFRE."
            fg.Cols(15).Name = "F.RECI."
            fg.Cols(16).Name = "ESTILO"
            fg.Cols(17).Name = "CPO"
            fg.Cols(18).Name = "ANCHO"
            fg.Cols(19).Name = "PRECIO"
            fg.Cols(20).Name = "PESO"
            fg.Cols(21).Name = "ESTADO"
            fg.Cols(22).Name = "TEXTILERA"
            fg.Cols(23).Visible = False
            fg.Cols(24).Name = "EN TEXTI."
            fg.Cols(25).Name = "F.CONFIRMADA"
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
            fg.Cols(5).Width = 40
            fg.Cols(6).Width = 80
            fg.Cols(7).Width = 240
            fg.Cols(8).Width = 0
            fg.Cols(9).Width = 50
            fg.Cols(10).Width = 60
            fg.Cols(11).Width = 60
            fg.Cols(15).Width = 80
            fg.Cols(16).Width = 80
            fg.Cols(17).Width = 60
            fg.Cols(18).Width = 50
            fg.Cols(19).Width = 50
            fg.Cols(22).Width = 100
            fg.Cols(25).Width = 120
            fg.Cols(5).Format = g
            fg.Cols(5).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
            fg.Cols(5).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
            fg.Cols(9).Format = g
            fg.Cols(9).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
            fg.Cols(9).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
            fg.Cols(10).Format = g
            fg.Cols(10).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
            fg.Cols(10).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
            fg.Cols(11).Format = g
            fg.Cols(11).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
            fg.Cols(11).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
            fg.Cols(18).Format = h
            fg.Cols(18).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
            fg.Cols(18).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
            fg.Cols(24).Format = h
            fg.Cols(24).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
            fg.Cols(24).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
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
        Catch
        End Try
    End Sub

    Private Sub llena_grid()
        ok = False
        lineas = 0
        Dim req As Date
        Dim ahora As DateTime = DateTime.Now
        Dim semana As DateTime = ahora.AddDays(8)
        llena_tablas(dt, STRSQL, cnn)
        lineas = dt.Rows.Count
        fg.Rows.Count = lineas + 1
        lineas = 1
        For Each Me.dr In dt.Rows
            ESTADO = Trim(dr("STATUS"))
            fg.Rows.Count = lineas + 1
            fg(lineas, 1) = dr("FPO")
            fg(lineas, 2) = dr("KNIT")
            fg(lineas, 3) = dr("COLOR")
            fg(lineas, 4) = dr("TIPO")
            fg(lineas, 5) = dr("LOTE")
            fg(lineas, 6) = dr("CLIENTE")
            fg(lineas, 7) = dr("DESCRIPCION")
            fg(lineas, 8) = dr("YFINISH")
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
            fg(lineas, 23) = fg(lineas, 1) & fg(lineas, 2) & fg(lineas, 3) & fg(lineas, 4) & fg(lineas, 5)
            If IsDBNull(dr("F_CONFIRMADA")) = False Then
                fg(lineas, 25) = dr("F_CONFIRMADA")
            End If
            lineas = lineas + 1
        Next
        fecha_recepcion()
        textilera()
        subtotales()
    End Sub
    Private Sub fecha_recepcion()
        Dim fila As String
        Dim sel As Integer
        Dim fechas As New DataTable()
        STRSQL = "SELECT DISTINCT FECHA, DMOVTO.FPO, TIPO, KNIT,COLOR, DMOVTO.BATCH FROM DMOVTO, ROLLOS WHERE DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO AND TMOVTO = '1' AND DMOVTO.FPO IN (SELECT DISTINCT FPO FROM FPO " & det & ")"
        llena_tablas(fechas, STRSQL, cnn)
        fila = fechas.Rows.Count
        For Each Me.dr In fechas.Rows
            fila = dr("FPO") & dr("KNIT") & dr("COLOR") & dr("TIPO") & CStr(dr("BATCH"))
            sel = fg.FindRow(fila, 1, 23, True)
            Try
                fg(sel, 15) = dr("FECHA")
            Catch
            End Try
        Next
    End Sub

    Private Sub textilera()
        Dim fila As String
        Dim sel As Integer
        Dim textilera As New DataTable()
        det = ""
        If CLIENTE <> "TODOS" Then
            det = "AND CLIENTE = '" & CLIENTE & "' "
        End If
        STRSQL = "SELECT FPO,KNIT,COLOR,TIPO,LOTE,(SUM(ROLLOS.PESO)/SUM(ROLLOS.YARDAS_I) * SUM(ROLLOS.YARDAS)) AS LIBRAS FROM ROLLOS WHERE YARDAS >0 AND ACTIVO = '6' " & det & " GROUP BY FPO,KNIT,COLOR,TIPO,LOTE "
        llena_tablas(dt, STRSQL, cnn)
        fila = textilera.Rows.Count
        For Each Me.dr In textilera.Rows
            fila = dr("FPO") & dr("KNIT") & dr("COLOR") & dr("TIPO") & CStr(dr("LOTE"))
            sel = fg.FindRow(fila, 1, 23, True)
            Try
                fg(sel, 24) = dr("LIBRAS")
            Catch
            End Try
        Next
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cursor = Cursors.WaitCursor
        ESTADO = C3.Text
        CLIENTE = C4.Text
        If ESTADO = "TODOS" And CLIENTE = "TODOS" Then
            Cursor = Cursors.Arrow
            Exit Sub
        End If
        det = ""
        STRSQL = "SELECT FPO.*,DESCRIPCION,F_CONFIRMADA FROM FPO LEFT JOIN  CODIGO_TELA ON FPO.CODIGO = CODIGO_TELA.CODIGO LEFT JOIN FPO_CONFIRMADA ON FPO.FPO = FPO_CONFIRMADA.FPO AND FPO.TIPO = FPO_CONFIRMADA.TIPO AND FPO.KNIT = FPO_CONFIRMADA.KNIT AND FPO.COLOR = FPO_CONFIRMADA.COLOR AND FPO.LOTE = FPO_CONFIRMADA.LOTE "
        If ESTADO <> "TODOS" Then
            det = "WHERE STATUS = '" & ESTADO & "'"
            If CLIENTE <> "TODOS" Then
                det = det + " AND CLIENTE = '" & CLIENTE & "'"
            End If
        Else
            If CLIENTE <> "TODOS" Then
                det = "WHERE CLIENTE = '" & CLIENTE & "'"
            End If
        End If
        STRSQL = STRSQL + det
        If tipos.SelectedIndex = 0 Then
            STRSQL = STRSQL + "AND FPO.TIPO = 'TELA'"
        Else
            STRSQL = STRSQL + "AND FPO.TIPO <> 'TELA'"
        End If
        Button1.Visible = False
        Button2.Visible = True
        Button3.Visible = True
        regresa.Visible = True
        C3.Enabled = False
        C4.Enabled = False
        tipos.Enabled = False
        setea_grid()
        llena_grid()
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
        fg.PrintGrid("inventario", PrintGridFlags.ShowPreviewDialog, "Consulta de FPOS  al " + fecha + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print_fg()
    End Sub

    Private Sub subtotales()
        fg.ScrollBars = ScrollBars.Both
        fg.Cols(0).AllowMerging = True
        fg.Cols(1).AllowMerging = True
        fg.Cols(2).AllowMerging = True
        fg.Cols(3).AllowMerging = True
        fg.Cols(4).AllowMerging = True
        fg.Subtotal(AggregateEnum.Clear)
        fg.Subtotal(AggregateEnum.Sum, 1, 1, 4, 9, "Totales {0}")
        fg.Subtotal(AggregateEnum.Sum, 1, 1, 4, 10, "Totales {0}")
        fg.Subtotal(AggregateEnum.Sum, 1, 1, 4, 11, "Totales {0}")
        fg.Subtotal(AggregateEnum.Sum, 1, 1, 4, 24, "Totales {0}")
        fg.Subtotal(AggregateEnum.Sum, 0, 0, 0, 9, "Gran TOTAL ---->")
        fg.Subtotal(AggregateEnum.Sum, 0, 0, 0, 10, "Gran TOTAL ---->")
        fg.Subtotal(AggregateEnum.Sum, 0, 0, 0, 11, "Gran TOTAL ---->")
        fg.Subtotal(AggregateEnum.Sum, 0, 0, 0, 24, "Gran TOTAL ---->")
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
            MsgBox("Sus datos fueron trasladados a Excel en el directorio:  C:\reportes\  bajo el nombre de Diaria.xls ", MsgBoxStyle.OKOnly, "TRASLADO DE DATOS ")
            Close()
        End If
    End Sub

    Private Sub regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regresa.Click
        Button1.Visible = True
        Button2.Visible = False
        Button3.Visible = False
        regresa.Visible = False
        tipos.Enabled = True
        C3.Enabled = True
        C4.Enabled = True
        setea_grid()
    End Sub
End Class
