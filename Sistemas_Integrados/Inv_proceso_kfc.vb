Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized


Public Class Inv_proceso_kfc
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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fecha_i As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inv_proceso_kfc))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fecha_i = New System.Windows.Forms.DateTimePicker()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowFiltering = True
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 17
        Me.fg.Size = New System.Drawing.Size(976, 640)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 24
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(920, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 51
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        Me.Button2.Location = New System.Drawing.Point(864, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 50
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        Me.Button1.Location = New System.Drawing.Point(328, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 55
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 32)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Fecha Proceso:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fecha_i
        '
        Me.fecha_i.CustomFormat = "dd/MM/yyyy"
        Me.fecha_i.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_i.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_i.Location = New System.Drawing.Point(152, 8)
        Me.fecha_i.Name = "fecha_i"
        Me.fecha_i.Size = New System.Drawing.Size(136, 26)
        Me.fecha_i.TabIndex = 56
        '
        'Inv_proceso_kfc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(992, 692)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fecha_i)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.fg)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Inv_proceso_kfc"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario en Proceso (por Corte - Batch)"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim h As String = "#######0.00"
    Dim g As String = "#######0.0000"
    Dim x As String = "MM/dd/yyyy"
    Dim ok As Boolean
    Dim cnn As New SqlClient.SqlConnection()
    Dim obj As empresas
    Dim co1 As Integer
    Dim co2 As Integer
    Dim cor As New DataTable
    Dim exp As New DataTable
    Dim path As String = "c:/reportes/inv_proceso_r.xls"
    Dim fpr As New DataTable
    Private Sub Inv_proceso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        setea_grid()
    End Sub

    Private Sub setea_grid()
        fg.Styles.Normal.Border.Style = BorderStyleEnum.Inset
        fg.Rows.Count = 1
        fg.Cols(0).Width = 0
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_fg()
        Dim dt As New DataTable()
        Dim ct As New DataTable()
        Dim dr As DataRow
        Dim dw As DataRow()
        Dim dj As DataRow
        Dim strsql As String
        Dim l As Integer
        Dim fpo As String
        Dim fprod As String = ""
        Dim fechas As String = Format(CDate(fecha_i.Text), "yyyy-MM-dd")
        llena_tablas(fpr, "SELECT  DISTINCT PROD_DIARIA.CORTE,FECHA FROM PROD_DIARIA LEFT JOIN CORTES ON PROD_DIARIA.CORTE = CORTES.CORTE WHERE EXPORTADO <> 'S' ORDER BY CORTE,FECHA DESC", cnn)
        strsql = "SELECT  DISTINCT FPO,KNIT,COLOR,PRECIO FROM FPO WHERE FPO IN (SELECT DISTINCT DMOVTO.FPO FROM DMOVTO,CORTES WHERE DMOVTO.CORTE = CORTES.CORTE AND DMOVTO.TMOVTO > 3 AND EXPORTADO <> 'S') "
        llena_tablas(ct, strsql, cnn)

        'strsql = "SELECT DMOVTO.CORTE,FCORTE, FPROD,DMOVTO.BATCH, DMOVTO.CPO, DMOVTO.CLIENTE ,ROLLOS.KNIT, ROLLOS.COLOR, SUM(DMOVTO.YARDAS) AS YARDA, (SUM(ROLLOS.PESO)/ SUM(ROLLOS.YARDAS_I)) * SUM(DMOVTO.YARDAS) AS LIBRA, DMOVTO.FPO ,SUM(ROLLOS.PESO)AS PTOTAL,TOTAL,SECCION,SUM(DMOVTO.PRECIO*DMOVTO.LIBRAS) AS CTOTAL,ROLLOS.CODIGO,DESCRIPCION FROM DMOVTO LEFT JOIN ROLLOS ON DMOVTO.BATCH =ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO  LEFT JOIN CORTES ON DMOVTO.CORTE = CORTES.CORTE  LEFT JOIN CODIGO_TELA ON CODIGO_TELA.CODIGO = ROLLOS.CODIGO WHERE CORTES.CORTE = DMOVTO.CORTE AND DMOVTO.TMOVTO > 3 AND DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO AND CORTES.EXPORTADO <> 'S' AND (SELECT COUNT(PRENDAS) FROM PROD_DIARIA WHERE PROD_DIARIA.CORTE= CORTES.CORTE) = 0 AND FCORTE < = '" & fechas & "' GROUP BY DMOVTO.CORTE,FCORTE,FPROD,DMOVTO.BATCH,DMOVTO.CPO, DMOVTO.CLIENTE, ROLLOS.KNIT, ROLLOS.COLOR, DMOVTO.FPO ,TOTAL,SECCION,ROLLOS.CODIGO,DESCRIPCION ORDER BY DMOVTO.CORTE"
        strsql = "SELECT DISTINCT DMOVTO.CORTE,FCORTE,DMOVTO.CPO, DMOVTO.CLIENTE ,ROLLOS.COLOR,SECCION FROM DMOVTO LEFT JOIN ROLLOS ON DMOVTO.BATCH =ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO  LEFT JOIN CORTES ON DMOVTO.CORTE = CORTES.CORTE LEFT JOIN CODIGO_TELA ON CODIGO_TELA.CODIGO = ROLLOS.CODIGO WHERE CORTES.CORTE = DMOVTO.CORTE AND DMOVTO.TMOVTO > 3 AND DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO AND CORTES.EXPORTADO <> 'S' AND (SELECT COUNT(PRENDAS) FROM PROD_DIARIA WHERE PROD_DIARIA.CORTE= CORTES.CORTE) = 0 AND FCORTE < =  '" & fechas & "' GROUP BY DMOVTO.CORTE,FCORTE,FPROD,DMOVTO.BATCH,DMOVTO.CPO, DMOVTO.CLIENTE, ROLLOS.KNIT, ROLLOS.COLOR, DMOVTO.FPO ,TOTAL,SECCION,ROLLOS.CODIGO,DESCRIPCION ORDER BY DMOVTO.CORTE"
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        l = 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("CORTE")
            'fg(l, 2) = dr("BATCH")
            fg(l, 3) = dr("CPO")
            fg(l, 4) = dr("CLIENTE")
            ' fg(l, 5) = dr("KNIT")
            fg(l, 6) = dr("COLOR")
            ' fg(l, 7) = dr("YARDA")
            'Try
            'fg(l, 8) = CDec(Format(dr("LIBRA"), h))
            'Catch
            'End Try
            ''fpo = "FPO = '" & dr("FPO") & "' AND KNIT = '" & fg(l, 5) & "' AND COLOR = '" & fg(l, 6) & "'"
            'Try
            ''dw = ct.Select(fpo)
            'dj = dw(0)
            'fg(l, 9) = Format(dj("PRECIO"), g)
            'fg(l, 10) = fg(l, 8) * fg(l, 9)
            ' Catch
            'Try
            'fg(l, 9) = (dr("CTOTAL") / dr("LIBRA"))
            'fg(l, 10) = dr("CTOTAL")
            'Catch
            'End Try
            ' End Try
            fg(l, 11) = dr("FCORTE")
            ' fg(l, 12) = dr("TOTAL")
            fg(l, 13) = dr("SECCION")
            l = l + 1
        Next
        'busca_costos()
        estado_cpo()
        co1 = fg.Cols(8).Index
        co2 = fg.Cols(10).Index
        subtotales()
    End Sub

    Private Sub subtotales()
        fg.AllowEditing = True
        fg.Subtotal(AggregateEnum.Sum, -1, -1, 7, "Gran Total")
        fg.Subtotal(AggregateEnum.Sum, -1, -1, co1, "Gran Total")
        fg.Subtotal(AggregateEnum.Sum, -1, -1, co2, "Gran Total")
        fg.AllowEditing = False
    End Sub
    Private Sub busca_costos()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim dw As DataRow()
        Dim i As Integer
        Dim strsql = "SELECT * FROM FPO ORDER BY FPO DESC "
        llena_tablas(dt, strsql, cnn)
        For i = 1 To fg.Rows.Count - 1
            If fg(i, 9) = 0 Then
                dw = dt.Select("KNIT = '" & fg(i, 5) & "' AND COLOR = '" & fg(i, 6) & "'")
                If dw.Length > 0 Then
                    dr = dw(0)
                    fg(i, 9) = dr("PRECIO")
                    fg(i, 10) = fg(i, 9) * fg(i, 8)
                End If
            End If
        Next
    End Sub
    Private Sub estado_cpo()
        Dim i As Integer
        Dim st As New DataTable
        Dim dw As DataRow()
        Dim dr As DataRow
        Dim estado As String
        'fecha_exportac()
        Dim strsql = "SELECT CORTE,CPO_D.ESTADO FROM CORTES LEFT JOIN CPO_D ON CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR WHERE EXPORTADO = 'N'"
        llena_tablas(st, strsql, cnn)

        For i = 1 To fg.Rows.Count - 1
            dw = st.Select("CORTE = '" & fg(i, 1) & "'")
            If dw.Length > 0 Then
                Try
                    dr = dw(0)
                    estado = dr(1)
                    fg(i, 14) = estado
                Catch
                End Try
            End If
        Next
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
        fecha = Format(Today, "dd/MM/yyyy")
        mal = obj.nombre + "  Inventario en Proceso al " + fecha
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
        fg.PrintGrid("Proceso", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPrintDialog, mal + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim si As Boolean
        datos_excel(si)
        If si Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio: " + path, MsgBoxStyle.OkOnly, "TRASLADO DE DATOS ")
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
            MsgBox("Por favor cierre todas sus Hojas de Excel y vuelva a tratar. Gracias", MsgBoxStyle.OkOnly, "Atencion ")
            si = False
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cursor = Cursors.WaitCursor
        ' llena_cortes()
        llena_fg()
        fg.ScrollBars = ScrollBars.Both
        'Cursor = Cursors.Arrow
        Button2.Visible = True
        Button3.Visible = True
        Button1.Visible = False
        fecha_i.Enabled = False
        Cursor = Cursors.Default
    End Sub
    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.AfterFilter
        subtotales()
    End Sub
End Class


