Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized


Public Class FPO_consul3
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim g As String = "#######0"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cns As SqlClient.SqlConnection
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
    Friend WithEvents Fecha_final As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fecha_inicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FPO_consul3))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Fecha_final = New System.Windows.Forms.DateTimePicker()
        Me.fecha_inicial = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Bitmap)
        Me.Button1.Location = New System.Drawing.Point(328, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 43
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para Iniciar la Busqueda")
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Bitmap)
        Me.Button2.Location = New System.Drawing.Point(384, 8)
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
        Me.Button3.Location = New System.Drawing.Point(440, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 50
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton si Desea enviar a Excel  los Datos mostrados en la Pantalla.")
        Me.Button3.Visible = False
        '
        'Fecha_final
        '
        Me.Fecha_final.CustomFormat = "dd/MM/yyyy"
        Me.Fecha_final.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_final.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.Fecha_final.Location = New System.Drawing.Point(152, 40)
        Me.Fecha_final.Name = "Fecha_final"
        Me.Fecha_final.Size = New System.Drawing.Size(112, 26)
        Me.Fecha_final.TabIndex = 63
        Me.ToolTip1.SetToolTip(Me.Fecha_final, "Fecha final")
        '
        'fecha_inicial
        '
        Me.fecha_inicial.CustomFormat = "dd/MM/yyyy"
        Me.fecha_inicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.fecha_inicial.Location = New System.Drawing.Point(152, 8)
        Me.fecha_inicial.Name = "fecha_inicial"
        Me.fecha_inicial.Size = New System.Drawing.Size(112, 26)
        Me.fecha_inicial.TabIndex = 61
        Me.ToolTip1.SetToolTip(Me.fecha_inicial, "Fecha Inicial")
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(46, Byte), CType(196, Byte), CType(245, Byte))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Bitmap)
        Me.Button4.Location = New System.Drawing.Point(328, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 35)
        Me.Button4.TabIndex = 64
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button4, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.Button4.Visible = False
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
        Me.fg.Location = New System.Drawing.Point(0, 80)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.Size = New System.Drawing.Size(1000, 576)
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
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 32)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Fecha Final:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 32)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Fecha Inicial:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FPO_consul3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(237, Byte))
        Me.ClientSize = New System.Drawing.Size(1006, 668)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Fecha_final, Me.Label1, Me.fecha_inicial, Me.Label2, Me.Button3, Me.Button2, Me.Button1, Me.fg, Me.Button4})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FPO_consul3"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Fpos por fecha  Requerida"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FPO_consul1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        setea_grid()
    End Sub

    Private Sub setea_grid()
        Try
            Dim index As Integer
            fg.Clear(ClearFlags.Style)
            fg.ScrollBars = ScrollBars.None
            fg.Rows.Count = 1
            fg.Cols.Count = 21
            fg.Cols(0).Width = 0
            fg.Rows(0).Height = 30
            fg.Cols(1).Name = "FPO"
            fg.Cols(2).Name = "KNIT"
            fg.Cols(3).Name = "COLOR"
            fg.Cols(4).Name = "TIPO"
            fg.Cols(5).Name = "LOTE"
            fg.Cols(6).Name = "CLIENTE"
            fg.Cols(7).Name = "CODIGO DE TELA"
            fg.Cols(8).Name = "TEXTILERA"
            fg.Cols(9).Name = "LIBRAS"
            fg.Cols(10).Name = "RECIBIDO"
            fg.Cols(11).Name = "BALANCE"
            fg.Cols(12).Name = "F.CPO"
            fg.Cols(13).Name = "F.REQ."
            fg.Cols(14).Name = "F.OFREC."
            fg.Cols(15).Name = "ESTILO"
            fg.Cols(16).Name = "CPO"
            fg.Cols(17).Name = "ANCHO"
            fg.Cols(18).Name = "PRECIO"
            fg.Cols(19).Name = "PESO"
            fg.Cols(20).Name = "ESTADO"
            For index = 1 To fg.Cols.Count - 1
                fg.Cols(index).Width = 70
                fg(0, index) = fg.Cols(index).Name
                If index > 11 And index < 15 Then
                    fg.Cols(index).TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
                    fg.Cols(index).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
                End If
            Next
            fg.Cols(1).Width = 80
            fg.Cols(2).Width = 110
            fg.Cols(3).Width = 160
            fg.Cols(4).Width = 70
            fg.Cols(5).Width = 50
            fg.Cols(6).Width = 80
            fg.Cols(7).Width = 230
            fg.Cols(8).Width = 100
            fg.Cols(9).Width = 50
            fg.Cols(10).Width = 60
            fg.Cols(11).Width = 60
            fg.Cols(15).Width = 80
            fg.Cols(16).Width = 80
            fg.Cols(17).Width = 60
            fg.Cols(18).Width = 50
            fg.Cols(19).Width = 50
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
        Dim dt As New DataTable()
        Dim dr As DataRow
        ok = False
        lineas = 0
        Dim req As Date
        Dim ahora As DateTime = DateTime.Now
        Dim semana As DateTime = ahora.AddDays(8)
        llena_tablas(dt, STRSQL, cns)
        lineas = dt.Rows.Count
        fg.Rows.Count = lineas + 1
        lineas = 1
        For Each dr In dt.Rows
            ESTADO = dr("STATUS")
            fg(lineas, 1) = dr("FPO")
            fg(lineas, 2) = dr("KNIT")
            fg(lineas, 3) = dr("COLOR")
            fg(lineas, 4) = dr("TIPO")
            fg(lineas, 5) = dr("LOTE")
            fg(lineas, 6) = dr("CLIENTE")
            fg(lineas, 7) = dr("DESCRIPCION")
            fg(lineas, 8) = dr("TEXTILERA")
            fg(lineas, 9) = dr("LIBRAS")
            fg(lineas, 10) = dr("RECIBIDAS")
            fg(lineas, 11) = fg(lineas, 9) - fg(lineas, 10)
            fg(lineas, 12) = dr("IFECHA")
            fg(lineas, 13) = dr("RFECHA")
            fg(lineas, 14) = dr("OFECHA")
            fg(lineas, 15) = dr("ESTILO")
            fg(lineas, 16) = dr("CPO")
            fg(lineas, 17) = dr("ANCHO")
            fg(lineas, 18) = dr("PRECIO")
            fg(lineas, 19) = dr("PESO")
            fg(lineas, 20) = ESTADO
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
        subtotales()
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cursor = Cursors.WaitCursor
        If CDate(Fecha_final.Text) < CDate(fecha_inicial.Text) Then
            MsgBox("Error en las Fechas", MsgBoxStyle.Critical, "Fecha final es menor que la Inicial")
            Exit Sub
        End If
        Dim fechai As String
        Dim fechaf As String
        fechai = Format(CDate(fecha_inicial.Text), "yyyy-MM-dd")
        fechaf = Format(CDate(Fecha_final.Text), "yyyy-MM-dd")
        STRSQL = "SELECT * FROM FPO LEFT JOIN  CODIGO_TELA ON FPO.CODIGO = CODIGO_TELA.CODIGO WHERE RFECHA BETWEEN '" & fechai & "' AND '" & fechaf & "' AND STATUS = 'ABIERTO' AND TIPO = 'TELA'"
        setea_grid()
        llena_grid()
        Button2.Visible = True
        Button3.Visible = True
        Button1.Visible = False
        Button4.Visible = True
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
        fg.PrintGrid("Fpo's", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPrintDialog, "Fpo con fecha de entrega entre " + fecha_inicial.Text + " y " + Fecha_final.Text + Chr(9) + Chr(9) + "Pagina {0}", "Fecha: " + fecha)
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
        fg.Subtotal(AggregateEnum.Sum, 0, 0, 0, 9, "Gran TOTAL ---->")
        fg.Subtotal(AggregateEnum.Sum, 0, 0, 0, 10, "Gran TOTAL ---->")
        fg.Subtotal(AggregateEnum.Sum, 0, 0, 0, 11, "Gran TOTAL ---->")
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
            MsgBox("Sus datos fueron trasladados a Excel en el directorio:  C:/  bajo el nombre de Fpos.xls ", MsgBoxStyle.OKOnly, "TRASLADO DE DATOS ")
            Close()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button4.Visible = False
        Button1.Visible = True
        Button2.Visible = False
        Button3.Visible = False
        setea_grid()
    End Sub
End Class
