Imports C1.Win.C1FlexGrid

Public Class Cajas30
    Inherits System.Windows.Forms.Form
    Dim dt As New DataTable
    Dim pr As New DataTable
    Dim ac As New DataTable
    Dim co As New DataTable
    Dim dr As DataRow
    Dim cnn As New SqlClient.SqlConnection()
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents regresa As System.Windows.Forms.Button
    Dim fechas As String
    Dim fechas2 As String
    Friend WithEvents excel As Button
    Dim con(3) As String
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cajas30))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.regresa = New System.Windows.Forms.Button()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.excel = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.fg.Location = New System.Drawing.Point(8, 60)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1111, 613)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(9, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 32)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Fecha:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(542, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 40)
        Me.Button1.TabIndex = 97
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'regresa
        '
        Me.regresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresa.ForeColor = System.Drawing.Color.Black
        Me.regresa.Image = CType(resources.GetObject("regresa.Image"), System.Drawing.Image)
        Me.regresa.Location = New System.Drawing.Point(542, 9)
        Me.regresa.Name = "regresa"
        Me.regresa.Size = New System.Drawing.Size(60, 40)
        Me.regresa.TabIndex = 98
        Me.regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.regresa.UseVisualStyleBackColor = False
        Me.regresa.Visible = False
        '
        'fecha
        '
        Me.fecha.CustomFormat = "dd/MM/yyyy"
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha.Location = New System.Drawing.Point(114, 23)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(136, 26)
        Me.fecha.TabIndex = 99
        '
        'fecha2
        '
        Me.fecha2.CustomFormat = "dd/MM/yyyy"
        Me.fecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha2.Location = New System.Drawing.Point(267, 23)
        Me.fecha2.Name = "fecha2"
        Me.fecha2.Size = New System.Drawing.Size(136, 26)
        Me.fecha2.TabIndex = 100
        '
        'excel
        '
        Me.excel.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.excel.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.excel.ForeColor = System.Drawing.Color.Black
        Me.excel.Image = CType(resources.GetObject("excel.Image"), System.Drawing.Image)
        Me.excel.Location = New System.Drawing.Point(608, 10)
        Me.excel.Name = "excel"
        Me.excel.Size = New System.Drawing.Size(55, 40)
        Me.excel.TabIndex = 101
        Me.excel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.excel, "Presione este Boton si Desea  convertir a Excel los datos. ")
        Me.excel.UseVisualStyleBackColor = False
        Me.excel.Visible = False
        '
        'Cajas30
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1155, 696)
        Me.Controls.Add(Me.excel)
        Me.Controls.Add(Me.fecha2)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.regresa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.fg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cajas30"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produccion Diaria Según Corte"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub Push05_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Height = Me.Height - 130
        fg.Width = Me.Width - 30
        setea_fg()
    End Sub
    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        fg.Cols(0).Width = 0
    End Sub
    Private Sub proceso()
        llena_datos()
        llena_fg()
    End Sub
    Private Sub llena_fg()
        Dim dr As DataRow
        Dim dj As DataRow = Nothing
        Dim l As Integer = 1
        fg.Rows.Count = pr.Rows.Count + 1
        For Each dr In pr.Rows
            fg(l, 0) = dr("EMPRESA")
            fg(l, 1) = dr("FECHA")
            fg(l, 2) = dr("SECCION")
            fg(l, 3) = dr("CORTE")
            fg(l, 8) = dr("UNIDADES")
            busca_datos(co, "EMPRESA = '" & dr("EMPRESA") & "' AND CORTE = '" & dr("CORTE") & "'", dj)
            fg(l, 4) = dj("CPO")
            fg(l, 5) = dj("ESTILO")
            fg(l, 6) = dj("COLOR")
            fg(l, 7) = dj("TOTAL")
            fg(l, 12) = dr("CLIENTE")
            fg(l, 13) = dr("SAM")
            Try
                fg(l, 10) = dj("VALES")
            Catch
                fg(l, 10) = 0
            End Try
            busca_datos(ac, "EMPRESA = '" & dr("EMPRESA") & "' AND CORTE = '" & dr("CORTE") & "'", dj)
            Try
                fg(l, 9) = dj("UNIDADES")
            Catch ex As Exception
                fg(l, 9) = 0
            End Try
            fg(l, 9) = fg(l, 9) + fg(l, 8)
            fg(l, 11) = fg(l, 7) - fg(l, 9) - fg(l, 10)
            l = l + 1
        Next
        fg.Sort(SortFlags.Ascending, 2)
    End Sub
    Private Sub busca_datos(ByVal dt As DataTable, ByVal busca As String, ByRef dj As DataRow)
        Dim dd As DataRow()
        dj = Nothing
        dd = dt.Select(busca)
        If dd.Length > 0 Then
            dj = dd(0)
        End If
    End Sub

    Private Sub llena_datos()
        Dim l As Integer = 1
        Dim strsql As String
        conexiones(con)
        pr = New DataTable
        ac = New DataTable
        co = New DataTable
        For i = 1 To 3
            Try
                dt = New DataTable
                cnn.ConnectionString = con(i)
                'strsql = "SELECT " & CStr(i) & " AS EMPRESA, SECCION,CONVERT(DATE,CAJAS04.FECHA) AS FECHA ,CAJAS01.CORTE,SUM(CAJAS01.UNIDADES) AS UNIDADES FROM CAJAS01 LEFT JOIN CAJAS04 ON CAJAS04.CAJA = CAJAS01.CAJA AND CAJAS01.CORTE = CAJAS04.CORTE AND CAJAS01.TALLA = CAJAS04.TALLA AND CAJAS04.TIPO = CAJAS01.TIPO where CONVERT (date,CAJAS04.FECHA) = '" & fechas & "' GROUP BY SECCION,CONVERT(DATE,CAJAS04.FECHA),CAJAS01.CORTE ORDER BY SECCION"
                'strsql = "SELECT " & CStr(i) & " AS EMPRESA,SECCION,CONVERT(DATE,CAJAS04.FECHA) AS FECHA ,CAJAS01.CORTE,SUM(CAJAS01.UNIDADES) AS UNIDADES,CAJAS01.CLIENTE FROM CAJAS01 LEFT JOIN CAJAS04 ON CAJAS04.CAJA = CAJAS01.CAJA AND CAJAS01.CORTE = CAJAS04.CORTE AND CAJAS01.TALLA = CAJAS04.TALLA AND CAJAS04.TIPO = CAJAS01.TIPO WHERE CAJAS04.FECHA BETWEEN CONVERT (date,'" & fechas & "') AND CONVERT (date,'" & fechas2 & "') GROUP BY SECCION,CONVERT(DATE,CAJAS04.FECHA),CAJAS01.CORTE,CAJAS01.CLIENTE ORDER BY SECCION"
                strsql = "SELECT " & CStr(i) & " AS EMPRESA,CAJAS01.SECCION,CONVERT(DATE,CAJAS04.FECHA) AS FECHA ,CAJAS01.CORTE,SUM(CAJAS01.UNIDADES) AS UNIDADES,CAJAS01.CLIENTE,ESTILOS.SAM FROM CAJAS01 LEFT JOIN CAJAS04 ON CAJAS04.CAJA = CAJAS01.CAJA AND CAJAS01.CORTE = CAJAS04.CORTE AND CAJAS01.TALLA = CAJAS04.TALLA AND CAJAS04.TIPO = CAJAS01.TIPO INNER JOIN CORTES ON CAJAS01.CORTE = CORTES.CORTE INNER JOIN ESTILOS ON CORTES.ESTILO = ESTILOS.ESTILO WHERE CAJAS04.FECHA BETWEEN CONVERT (date,'" & fechas & "') AND CONVERT (date,'" & fechas2 & "') GROUP BY CAJAS01.SECCION,CONVERT(DATE,CAJAS04.FECHA),CAJAS01.CORTE,CAJAS01.CLIENTE,ESTILOS.SAM ORDER BY SECCION"
                llena_tablas_e(dt, strsql, cnn)
                pr.Merge(dt)
            Catch
            End Try
            Try
                dt = New DataTable
                cnn.ConnectionString = con(i)
                'strsql = "SELECT " & CStr(i) & " AS EMPRESA,CAJAS04.CORTE,SUM(CAJAS01.UNIDADES) AS UNIDADES FROM CAJAS04 LEFT JOIN CAJAS01 ON CAJAS04.CAJA = CAJAS01.CAJA AND CAJAS01.CORTE = CAJAS04.CORTE AND CAJAS01.TALLA = CAJAS04.TALLA AND CAJAS04.TIPO = CAJAS01.TIPO WHERE CONVERT (date,CAJAS04.FECHA) < '" & fechas & "' AND CAJAS04.CORTE IN (SELECT DISTINCT CORTE FROM CAJAS04 WHERE CONVERT(date,CAJAS04.FECHA) = '" & fechas & "') GROUP BY CAJAS04.CORTE "
                'strsql = "SELECT " & CStr(i) & " AS EMPRESA,CAJAS04.CORTE,SUM(CAJAS01.UNIDADES) AS UNIDADES,CAJAS01.CLIENTE FROM CAJAS04 LEFT JOIN CAJAS01 ON CAJAS04.CAJA = CAJAS01.CAJA AND CAJAS01.CORTE = CAJAS04.CORTE AND CAJAS01.TALLA = CAJAS04.TALLA AND CAJAS04.TIPO = CAJAS01.TIPO WHERE CONVERT (date,CAJAS04.FECHA) < '" & fechas2 & "' AND CAJAS04.CORTE IN (SELECT DISTINCT CORTE FROM CAJAS04 WHERE CAJAS04.FECHA BETWEEN CONVERT (date,'" & fechas & "') AND CONVERT (date,'" & fechas2 & "')) GROUP BY CAJAS04.CORTE, CAJAS01.CLIENTE"
                strsql = "SELECT  " & CStr(i) & " AS EMPRESA,CAJAS04.CORTE,SUM(CAJAS01.UNIDADES) AS UNIDADES,CAJAS01.CLIENTE,CORTES.ESTILO,ESTILOS.SAM FROM CAJAS04 LEFT JOIN CAJAS01 ON CAJAS04.CAJA = CAJAS01.CAJA AND CAJAS01.CORTE = CAJAS04.CORTE AND CAJAS01.TALLA = CAJAS04.TALLA AND CAJAS04.TIPO = CAJAS01.TIPO INNER JOIN CORTES ON CAJAS01.CORTE = CORTES.CORTE INNER JOIN ESTILOS ON CORTES.ESTILO = ESTILOS.ESTILO WHERE  CONVERT (date,CAJAS04.FECHA) < '" & fechas2 & "' AND CAJAS04.CORTE IN (SELECT DISTINCT CORTE FROM CAJAS04 WHERE CAJAS04.FECHA BETWEEN CONVERT (date,'" & fechas & "') AND CONVERT (date,'" & fechas2 & "')) GROUP BY CAJAS04.CORTE, CAJAS01.CLIENTE,CORTES.ESTILO,ESTILOS.SAM"
                llena_tablas_e(dt, strsql, cnn)
                ac.Merge(dt)
            Catch
            End Try
            Try
                dt = New DataTable
                cnn.ConnectionString = con(i)
                'strsql = "SELECT " & CStr(i) & " AS EMPRESA,CORTE,CPO,ESTILO,COLOR,TOTAL,(SELECT SUM(UNIDADES) FROM CAJAS05 WHERE CAJAS05.CORTE = CORTES.CORTE) AS VALES FROM CORTES WHERE CORTE IN (SELECT DISTINCT CORTE FROM CAJAS04 WHERE CONVERT (date,CAJAS04.FECHA) = '" & fechas & "')"
                strsql = "SELECT " & CStr(i) & " AS EMPRESA,CORTE,CPO,ESTILO,COLOR,TOTAL,(SELECT SUM(UNIDADES) FROM CAJAS05 WHERE CAJAS05.CORTE = CORTES.CORTE) AS VALES FROM CORTES WHERE CORTE IN (SELECT DISTINCT CORTE FROM CAJAS04 WHERE CAJAS04.FECHA BETWEEN CONVERT (date,'" & fechas & "') AND CONVERT (date,'" & fechas2 & "'))"
                llena_tablas_e(dt, strsql, cnn)
                co.Merge(dt)
            Catch
            End Try
        Next
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        fechas = Format(fecha.Value, "yyyy-MM-dd")
        fechas2 = Format(fecha2.Value, "yyyy-MM-dd")
        proceso()
        fecha.Enabled = False
        fecha2.Enabled = False
        Button1.Visible = False
        regresa.Visible = True
        excel.Visible = True
    End Sub

    Private Sub regresa_Click(sender As System.Object, e As System.EventArgs) Handles regresa.Click
        setea_fg()
        fecha.Enabled = True
        fecha2.Enabled = True
        Button1.Visible = True
        regresa.Visible = False
        excel.Visible = False
    End Sub

    Private Sub excel_Click(sender As Object, e As EventArgs) Handles excel.Click
        Dim ok As Boolean
        a_excel(fg, "c:\reportes\prod_diaria_corte.xls", ok)
        If ok Then
            Close()
        End If
    End Sub
End Class
