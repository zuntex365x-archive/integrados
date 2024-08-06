Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized

Public Class Resumen_tela
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
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Fechaf As System.Windows.Forms.DateTimePicker
    Friend WithEvents C4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Resumen_tela))
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Fechaf = New System.Windows.Forms.DateTimePicker()
        Me.C4 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fecha
        '
        Me.fecha.CustomFormat = "dd/MM/yyyy"
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(144, 8)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(112, 26)
        Me.fecha.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.fecha, "Fecha de la cual se desea Consultar o Imprimir el Reporte de Tela Recibida.")
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 32)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fecha Incial"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 72)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(1000, 600)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 23
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(848, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 45
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(807, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 46
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para iniciar la Busqueda de Tela Recibida en la fecha Selecci" & _
                "onada.")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(889, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 49
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton si Desea enviar a Excel  los Datos mostrados en la Pantalla.")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Fechaf
        '
        Me.Fechaf.CustomFormat = "dd/MM/yyyy"
        Me.Fechaf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fechaf.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fechaf.Location = New System.Drawing.Point(144, 40)
        Me.Fechaf.Name = "Fechaf"
        Me.Fechaf.Size = New System.Drawing.Size(112, 26)
        Me.Fechaf.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.Fechaf, "Fecha de la cual se desea Consultar o Imprimir el Reporte de Tela Recibida.")
        '
        'C4
        '
        Me.C4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C4.Location = New System.Drawing.Point(400, 8)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(192, 28)
        Me.C4.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.C4, "Elija el Cliente a Consultar o seleccione ""TODOS"" para una Busqueda Total")
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 32)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Fecha Final:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(328, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Cliente:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Resumen_tela
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 676)
        Me.Controls.Add(Me.C4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Fechaf)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Resumen_tela"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen de Tela Recibida"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim h As String = "#######0.00"
    Dim g As String = "######0"
    Dim r As String = "00000000"
    Dim x As String = "MM/dd/yyyy"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim obj As empresas
    Dim strSql As String
    Dim FECHAS As String
    Dim FECHAS1 As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Dim cliente As String
    Private Sub Tela_diaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        llena_clientes()
        setea_grid()
    End Sub

    Private Sub setea_grid()
        'Try
        fg.ScrollBars = ScrollBars.None
        Dim index As Integer
        fg.DataSource = GetDataSource()
        fg.Cols.Count = 12
        fg.Cols(0).Width = 0
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Caption = "FECHA"
        fg.Cols(2).Caption = "BATCH"
        fg.Cols(3).Caption = "CLIENTE"
        fg.Cols(4).Caption = "KNIT"
        fg.Cols(5).Caption = "COLOR"
        fg.Cols(6).Caption = "FPO"
        fg.Cols(7).Caption = "CPO"
        fg.Cols(8).Caption = "ANCHO"
        fg.Cols(9).Caption = "No.ROLLOS"
        fg.Cols(10).Caption = "YARDAS"
        fg.Cols(11).Caption = "LIBRAS"
        fg.Cols(9).DataType = GetType(Decimal)
        fg.Cols(9).Format = g
        fg.Cols(9).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(9).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(10).DataType = GetType(Decimal)
        fg.Cols(10).Format = h
        fg.Cols(10).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(10).TextAlignFixed = TextAlignEnum.RightCenter
        fg.Cols(11).DataType = GetType(Decimal)
        fg.Cols(11).Format = h
        fg.Cols(11).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(11).TextAlignFixed = TextAlignEnum.RightCenter
        For index = 1 To fg.Cols.Count - 1
            fg.Cols(index).Width = 80
            fg(0, index) = fg.Cols(index).Caption
        Next
        fg.Cols(1).Width = 80
        fg.Cols(2).Width = 70
        fg.Cols(2).Width = 70
        fg.Cols(4).Width = 150
        fg.Cols(5).Width = 150
        fg.Cols(6).Width = 80
        subtotales()
    End Sub



    Private Sub subtotales()
        With fg
            Dim totalya As Integer = fg.Cols("YARDAS").Index
            fg.Subtotal(AggregateEnum.Sum, 1, 1, totalya)
            Dim totalib As Integer = fg.Cols("LIBRAS").Index
            fg.Subtotal(AggregateEnum.Sum, 1, 1, totalib)
            fg.Subtotal(AggregateEnum.Sum, 0, 0, totalya, "Gran Total -->")
            fg.Subtotal(AggregateEnum.Sum, 0, 0, totalib, "Gran Total -->")
        End With
        If fg.Rows.Count > 1 Then
            fg.ScrollBars = ScrollBars.Both
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        formatea_fechas()
        If FECHAS1 < FECHAS Then
            MsgBox("Inconsistencia en Fechas", MsgBoxStyle.Critical, "Fecha Final menor que Fecha Inicial")
        Else
            setea_grid()
        End If
    End Sub

    Private Sub formatea_fechas()
        FECHAS = Format(CDate(fecha.Text), "yyyy-MM-dd")
        FECHAS1 = Format(CDate(Fechaf.Text), "yyyy-MM-dd")
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print_fg()
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
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
        fg.PrintGrid("Telas", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, "Resumen de tele recibida del " + fecha.Text + " Al  " + Fechaf.Text + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim si As Boolean
        datos_excel(si)
        If si Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio:  C:/  bajo el nombre de Diaria.xls ", MsgBoxStyle.OKOnly, "TRASLADO DE DATOS ")
            Close()
        End If
    End Sub


    Private Sub datos_excel(ByRef si As Boolean)
        Dim path As String = "c:\reportes\diaria.xls"
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

    Private Function GetDataSource() As DataTable
        obj = New empresas()
        Dim conn As String = obj.constr
        Dim strSQL As String
        cliente = C4.Text
        If C4.Text = "TODOS" Then
            strSQL = "SELECT DMOVTO.FECHA AS FECHA, ROLLOS.BATCH AS BATCH, ROLLOS.CLIENTE AS CLIENTE , ROLLOS.KNIT AS KNIT, ROLLOS.COLOR AS COLOR, ROLLOS.FPO AS FPO,ROLLOS.CPO AS CPO,ANCHO,COUNT(ROLLOS.ROLLO) AS ROLLO, SUM(ROLLOS.YARDAS_I) AS YARDAS , SUM(PESO) AS LIBRAS FROM ROLLOS,DMOVTO WHERE DMOVTO.FECHA BETWEEN  '" & FECHAS & "' AND '" & FECHAS1 & "' AND DMOVTO.TMOVTO = '1'  AND DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO GROUP BY ROLLOS.BATCH, ROLLOS.KNIT, ROLLOS.COLOR, ROLLOS.CLIENTE, ROLLOS.FPO, ROLLOS.CPO, ROLLOS.YFIBER ,ANCHO, DMOVTO.FECHA ORDER BY DMOVTO.FECHA, ROLLOS.BATCH ,ROLLOS.KNIT"
        Else
            strSQL = "SELECT DMOVTO.FECHA AS FECHA, ROLLOS.BATCH AS BATCH, ROLLOS.CLIENTE AS CLIENTE , ROLLOS.KNIT AS KNIT, ROLLOS.COLOR AS COLOR, ROLLOS.FPO AS FPO,ROLLOS.CPO AS CPO,ANCHO,COUNT(ROLLOS.ROLLO) AS ROLLO, SUM(ROLLOS.YARDAS_I) AS YARDAS , SUM(PESO) AS LIBRAS FROM ROLLOS,DMOVTO WHERE DMOVTO.FECHA BETWEEN  '" & FECHAS & "' AND '" & FECHAS1 & "' AND DMOVTO.TMOVTO = '1'  AND DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO AND DMOVTO.CLIENTE = '" & cliente & "' GROUP BY ROLLOS.BATCH, ROLLOS.KNIT, ROLLOS.COLOR, ROLLOS.CLIENTE, ROLLOS.FPO, ROLLOS.CPO, ROLLOS.YFIBER ,ANCHO, DMOVTO.FECHA ORDER BY DMOVTO.FECHA, ROLLOS.BATCH ,ROLLOS.KNIT"
        End If
        llena_tablas(dt, strSQL, cnn)
        GetDataSource = dt
    End Function

    Private Sub llena_clientes()
        Dim strSQL As String = "SELECT * FROM CLIENTES"
        C4.Items.Add("TODOS")
        llena_tablas(dt, strSQL, cnn)
        For Each Me.dr In dt.Rows
            C4.Items.Add(dr("CLIENTE"))
        Next
        C4.SelectedIndex = 0
    End Sub
End Class
