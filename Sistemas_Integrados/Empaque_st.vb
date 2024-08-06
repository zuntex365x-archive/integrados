Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Empaque_st
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim si As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim te(9) As String
    Dim fecha As String
    Dim fecha1 As String
    Dim path As String = "c:\reportes\segundas.xls"
    Dim tc As New DataTable()
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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fecha_i As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fecha_f As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents S1 As System.Windows.Forms.Button
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents C4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empaque_st))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fecha_i = New System.Windows.Forms.DateTimePicker()
        Me.fecha_f = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.S1 = New System.Windows.Forms.Button()
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.C4 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(16, 72)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(976, 608)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        Me.fg.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'fecha_i
        '
        Me.fecha_i.CustomFormat = "dd/MM/yyyy"
        Me.fecha_i.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_i.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_i.Location = New System.Drawing.Point(144, 8)
        Me.fecha_i.Name = "fecha_i"
        Me.fecha_i.Size = New System.Drawing.Size(136, 26)
        Me.fecha_i.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.fecha_i, "Fecha inicial del rango de fechas.")
        '
        'fecha_f
        '
        Me.fecha_f.CustomFormat = "dd/MM/yyyy"
        Me.fecha_f.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_f.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_f.Location = New System.Drawing.Point(144, 40)
        Me.fecha_f.Name = "fecha_f"
        Me.fecha_f.Size = New System.Drawing.Size(136, 26)
        Me.fecha_f.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.fecha_f, "Fecha final del rango de fechas.")
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(824, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 53
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
        Me.Button2.Location = New System.Drawing.Point(776, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 52
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'S1
        '
        Me.S1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.S1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.S1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S1.ForeColor = System.Drawing.Color.Black
        Me.S1.Image = CType(resources.GetObject("S1.Image"), System.Drawing.Image)
        Me.S1.Location = New System.Drawing.Point(728, 16)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(35, 35)
        Me.S1.TabIndex = 58
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.S1, "Chequeo de Datos")
        Me.S1.UseVisualStyleBackColor = False
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CANCELA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CANCELA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCELA.ForeColor = System.Drawing.Color.Black
        Me.CANCELA.Image = CType(resources.GetObject("CANCELA.Image"), System.Drawing.Image)
        Me.CANCELA.Location = New System.Drawing.Point(728, 16)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(35, 35)
        Me.CANCELA.TabIndex = 60
        Me.CANCELA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.CANCELA, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin" &
        " Grabar.")
        Me.CANCELA.UseVisualStyleBackColor = False
        Me.CANCELA.Visible = False
        '
        'C4
        '
        Me.C4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C4.Location = New System.Drawing.Point(408, 16)
        Me.C4.MaxDropDownItems = 15
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(176, 24)
        Me.C4.TabIndex = 61
        Me.ToolTip1.SetToolTip(Me.C4, "Elija el Cliente a Consultar .")
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 32)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Fecha Inicial:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 32)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Fecha Final:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(328, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 24)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Cliente:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Empaque_st
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1002, 696)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.C4)
        Me.Controls.Add(Me.S1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.fecha_f)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fecha_i)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.CANCELA)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Empaque_st"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Segundas por tipo de Rechazo"
        Me.ToolTip1.SetToolTip(Me, "Captacion de la Produccion diaria")
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        fecha_i.Text = Today
        setea_grid()
    End Sub

    Private Sub setea_grid()
        Dim index As Integer
        Dim c As Integer
        fg.Clear()
        fg.Rows.Fixed = 2
        fg.Rows.Count = 2
        fg.Cols.Count = 37
        fg.Cols(0).Width = 0
        fg.Rows(0).Height = 22
        fg.Rows(1).Height = 30
        fg(1, 1) = "CORTE"
        fg(1, 2) = "CLIENTE"
        fg(1, 3) = "CPO"
        fg(1, 4) = "ESTILO"
        fg(1, 5) = "COLOR"
        fg(1, 6) = "FECHA"
        fg(1, 7) = "CORTE"
        fg(1, 8) = "PRIME."
        fg(1, 9) = "SEGUN."
        fg(1, 10) = "% SEG."
        fg.Rows(0).AllowMerging = True
        fg.Cols(6).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(6).DataType = GetType(Date)
        fg.Cols(10).DataType = GetType(Decimal)
        fg.Cols(10).Format = "####0.00"
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 80
            If index > 6 Then
                fg.Cols(index).Width = 45
                fg.Cols(index).TextAlign = TextAlignEnum.RightCenter
                fg.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
        Dim si As Boolean = True
        For index = 1 To 11
            c = (index - 1) * 2 + 11
            fg(1, c) = "Uni."
            fg(1, c + 1) = "%"
            fg.SetCellStyle(1, c, fg.GetCellStyle(0, c))
            fg.Cols(c).DataType = GetType(Integer)
            fg.Cols(c).Format = "######0"
            fg.Cols(c + 1).DataType = GetType(Decimal)
            fg.Cols(c + 1).Format = "#####.##"
            If index < 11 Then
                fg.SetCellStyle(1, index, fg.Styles("c2"))
            End If
            If Not si Then
                fg.SetCellStyle(1, c, fg.Styles("c1"))
                fg.SetCellStyle(1, c + 1, fg.Styles("c1"))
                si = True
            Else
                si = False
            End If
        Next

        fg.Cols(1).Width = 60
        fg.Cols(5).Width = 150
        fg.Cols(6).Width = 80
        fg.Cols(7).Width = 55
        fg.Cols(8).Width = 55
        fg.Cols(9).Width = 55
        fg.Cols(36).Width = 120

        Dim rng1 = fg.GetCellRange(0, 1, 0, 10)
        rng1.Data = "DATOS DEL CORTE"
        rng1.Style = fg.Styles("c2")


        rng1 = fg.GetCellRange(0, 11, 0, 12)
        rng1.Data = "T.FABRICAC."
        rng1.Style = fg.Styles("c0")

        rng1 = fg.GetCellRange(0, 13, 0, 14)
        rng1.Data = "T.MANCHAS"
        rng1.Style = fg.Styles("c1")

        rng1 = fg.GetCellRange(0, 15, 0, 16)
        rng1.Data = "T.AGUJEROS"
        rng1.Style = fg.Styles("c0")

        rng1 = fg.GetCellRange(0, 17, 0, 18)
        rng1.Data = "T.TONALIDAD"
        rng1.Style = fg.Styles("c1")

        rng1 = fg.GetCellRange(0, 19, 0, 20)
        rng1.Data = "CUELLOS/PU"
        rng1.Style = fg.Styles("c0")

        rng1 = fg.GetCellRange(0, 21, 0, 22)
        rng1.Data = "INCOMPLETAS"
        rng1.Style = fg.Styles("c1")

        rng1 = fg.GetCellRange(0, 23, 0, 24)
        rng1.Data = "P.COSTURA"
        rng1.Style = fg.Styles("c0")

        rng1 = fg.GetCellRange(0, 25, 0, 26)
        rng1.Data = "P.AGUJEROS"
        rng1.Style = fg.Styles("c1")

        rng1 = fg.GetCellRange(0, 27, 0, 28)
        rng1.Data = "P.TONALIDAD"
        rng1.Style = fg.Styles("c0")

        rng1 = fg.GetCellRange(0, 29, 0, 30)
        rng1.Data = "BORDADO"
        rng1.Style = fg.Styles("c1")

        rng1 = fg.GetCellRange(0, 31, 0, 32)
        rng1.Data = "MUESTRAS"
        rng1.Style = fg.Styles("c0")

        fg.Cols(36).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(36).DataType = GetType(String)
        fg.Cols(36).Caption = "SECCION"
    End Sub

    Private Sub llena_grid()
        ok = False
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim i As Integer
        Dim j As Integer
        Dim c As Integer
        Dim orden As String
        Dim talla As String
        Dim prendas As Integer
        Dim strSQL As String = "SELECT PROD_DIARIA.CORTE,CLIENTE,CPO,ESTILO,COLOR,TIPO,FECHA,TALLA,PRENDAS,TOTAL,SECCION FROM PROD_DIARIA, CORTES WHERE FECHA BETWEEN '" & fecha & "' AND '" & fecha1 & "'AND PROD_DIARIA.CORTE = CORTES.CORTE"
        If C4.Text <> "TODOS" Then
            strSQL = strSQL & " AND CLIENTE = '" & C4.Text & "'"
        End If
        llena_tablas(dt, strSQL, cnn)
        totales_corte(tc)
        For Each dr In dt.Rows
            orden = dr("CORTE")
            si = fg.FindRow(orden, 1, 1, True)
            If si = -1 Then
                crea_otra_linea(dr)
            End If
            i = dr("TIPO")
            talla = dr("TALLA")
            prendas = dr("PRENDAS")
            c = (i - 1) * 2 + 11
            If i > 0 Then
                fg(si, c) = fg(si, c) + prendas
                fg(si, 9) = fg(si, 9) + prendas
            Else
                fg(si, 8) = fg(si, 8) + prendas
            End If
        Next
        subtotales()
        Dim s As CellStyle = fg.Styles.Add("mas")
        s.Format = "#,##0.00"
        For i = 2 To fg.Rows.Count - 1
            For j = 1 To 11
                c = (j - 1) * 2 + 11
                fg(i, c + 1) = (fg(i, c) * 100) / fg(i, 7)
                If fg(i, c + 1) <> 0 Then
                    fg.SetCellStyle(i, c + 1, "mas")
                End If
            Next
            Try
                fg(i, 10) = (fg(i, 35) * 100) / fg(i, 7)
            Catch
                fg(i, 10) = 0
            End Try

            If (fg(i, 34) + fg(i, 34)) < fg(i, 7) And i > 2 Then
                fg.SetCellStyle(i, 7, fg.Styles("rojo"))
            End If
        Next
    End Sub

    Private Sub crea_otra_linea(ByVal dr As DataRow)
        Dim i As Integer
        Dim corte As String
        Dim drs As DataRow()
        Dim ds As DataRow
        corte = dr("CORTE")
        fg.Rows.Count = fg.Rows.Count + 1
        lineas = fg.Rows.Count - 1
        fg(lineas + i, 1) = corte
        fg(lineas + i, 2) = dr("CLIENTE")
        fg(lineas + i, 3) = dr("CPO")
        fg(lineas + i, 4) = dr("ESTILO")
        fg(lineas + i, 5) = dr("COLOR")
        fg(lineas + i, 6) = dr("FECHA")
        fg(lineas + i, 7) = dr("TOTAL")
        drs = tc.Select("CORTE = '" & corte & "'")
        If drs.Length > 0 Then
            ds = drs(0)
            fg(lineas + i, 34) = ds("PRIMERAS")
            fg(lineas + i, 35) = ds("SEGUNDAS")
        End If
        fg(lineas + i, 36) = dr("SECCION")
        si = lineas
    End Sub

    Private Sub totales_corte(ByRef tc As DataTable)
        Dim strsql As String = "SELECT CORTE, SUM(P0+P1+P2+P3+P4+P5+P6+P7+P8+P9) AS PRIMERAS, SUM(S0+S1+S2+S3+S4+S5+S6+S7+S8+S9) AS SEGUNDAS FROM CORTES_P WHERE CORTE IN (SELECT DISTINCT CORTE FROM PROD_DIARIA WHERE FECHA BETWEEN '" & fecha & "' AND '" & fecha1 & "') GROUP BY CORTE"
        llena_tablas(tc, strsql, cnn)
    End Sub

    Private Sub subtotales()
        Dim i As Integer

        With fg
            For i = 7 To 35
                fg.Subtotal(AggregateEnum.Sum, 0, 0, i, "Gran Total -->")
            Next i
        End With
        Try
            fg(2, 10) = (fg(2, 35) * 100) / fg(2, 7)
        Catch
        End Try
        fg.Cols(33).Visible = False
        fg.Cols(34).Visible = False
        fg.Cols(35).Visible = False

    End Sub


    Private Sub chequea_fechas(ByRef ok As Boolean)
        ok = True
        fecha = Format(CDate(fecha_i.Text), "yyyy-MM-dd")
        fecha1 = Format(CDate(fecha_f.Text), "yyyy-MM-dd")
        If fecha1 < fecha Then
            'fecha = fecha1
            ok = False
            MsgBox("Error en las Fechas", MsgBoxStyle.Critical, "Por favor verifique !!")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print_fg()
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        Dim mal As String
        Dim obj As empresas
        obj = New empresas()
        fecha = Format(Today, "dd/MM/yyy")
        mal = obj.nombre + "  Reporte de Segundas del: " + Format(CDate(fecha_i.Text), "dd/MM/yyyy") + " al " + Format(CDate(fecha_f.Text), "dd/MM/yyyy")
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = False
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 80
            .Margins.Bottom = 80
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("Empaque", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPrintDialog, mal + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim si As Boolean
        datos_excel(si)
        If si Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio: " + path, MsgBoxStyle.OKOnly, "TRASLADO DE DATOS ")
            Close()
        End If
    End Sub


    Private Sub datos_excel(ByRef si As Boolean)
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

    Private Sub S1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S1.Click
        chequea_fechas(ok)
        If ok Then
            setea_grid()
            llena_grid()
            S1.Visible = False
            C4.Enabled = False
            CANCELA.Visible = True
            fecha_i.Enabled = False
            fecha_f.Enabled = False
            Button2.Visible = True
            Button3.Visible = True
        End If
    End Sub

    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELA.Click
        CANCELA.Visible = False
        S1.Visible = True
        C4.Enabled = True
        fecha_i.Enabled = True
        fecha_f.Enabled = True
        Button2.Visible = False
        Button3.Visible = False
        setea_grid()
    End Sub

    Private Sub llena_clientes()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim fechai As String = Format(fecha_i.Value, "yyyy-MM-dd")
        Dim fechaf As String = Format(fecha_f.Value, "yyyy-MM-dd")
        Dim strsql As String = "SELECT DISTINCT(CLIENTE) FROM PROD_DIARIA LEFT JOIN CORTES ON PROD_DIARIA.CORTE = CORTES.CORTE  WHERE FECHA BETWEEN '" & fechai & "' AND '" & fechaf & "'ORDER BY CLIENTE"
        llena_tablas(dt, strsql, cnn)
        C4.Items.Clear()
        C4.Items.Add("TODOS")
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            C4.Items.Add(Trim(dr("CLIENTE")))
        Next
        Try
            C4.SelectedIndex = 0
        Catch
        End Try
    End Sub

    Private Sub fecha_i_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecha_i.ValueChanged
        llena_clientes()
    End Sub

    Private Sub fecha_f_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecha_f.ValueChanged
        llena_clientes()
    End Sub

    Private Sub c4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C4.KeyPress
        AutoCompletar(C4, e)
    End Sub
End Class



