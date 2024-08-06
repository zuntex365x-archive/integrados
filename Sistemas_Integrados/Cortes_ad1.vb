Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Cortes_ad1
    Inherits System.Windows.Forms.Form
    Dim si As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim fecha As String
    Dim fecha1 As String
    Dim path As String = "c:\reportes\procesos_adr.xls"
    Dim dt As New DataTable()
    Dim dr As DataRow
    Dim fila As Integer
    Dim ok As Boolean
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fecha_i As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fecha_f As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents S1 As System.Windows.Forms.Button
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents proceso As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents jg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cortes_ad1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fecha_i = New System.Windows.Forms.DateTimePicker()
        Me.fecha_f = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.S1 = New System.Windows.Forms.Button()
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.proceso = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.jg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.jg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ToolTip1.SetToolTip(Me.fecha_i, "Fecha Inicial")
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
        Me.ToolTip1.SetToolTip(Me.fecha_f, "Fecha Final")
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(448, 16)
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
        Me.Button2.Location = New System.Drawing.Point(408, 16)
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
        Me.S1.Location = New System.Drawing.Point(368, 16)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(35, 35)
        Me.S1.TabIndex = 58
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.S1, "Consultar")
        Me.S1.UseVisualStyleBackColor = False
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CANCELA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CANCELA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCELA.ForeColor = System.Drawing.Color.Black
        Me.CANCELA.Image = CType(resources.GetObject("CANCELA.Image"), System.Drawing.Image)
        Me.CANCELA.Location = New System.Drawing.Point(368, 16)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(35, 35)
        Me.CANCELA.TabIndex = 60
        Me.CANCELA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.CANCELA, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin" &
        " Grabar.")
        Me.CANCELA.UseVisualStyleBackColor = False
        Me.CANCELA.Visible = False
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
        'proceso
        '
        Me.proceso.BackColor = System.Drawing.Color.White
        Me.proceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.proceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proceso.ForeColor = System.Drawing.Color.Black
        Me.proceso.Items.AddRange(New Object() {"Serigrafia", "Bordado", "Sublimación"})
        Me.proceso.Location = New System.Drawing.Point(144, 72)
        Me.proceso.Name = "proceso"
        Me.proceso.Size = New System.Drawing.Size(164, 24)
        Me.proceso.TabIndex = 72
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 16)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Proceso:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'jg
        '
        Me.jg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.jg.AllowEditing = False
        Me.jg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.jg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.jg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.jg.ColumnInfo = resources.GetString("jg.ColumnInfo")
        Me.jg.Enabled = False
        Me.jg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.jg.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.jg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.jg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.jg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.jg.Location = New System.Drawing.Point(8, 584)
        Me.jg.Name = "jg"
        Me.jg.Rows.Count = 1
        Me.jg.Rows.DefaultSize = 19
        Me.jg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.jg.Size = New System.Drawing.Size(808, 80)
        Me.jg.StyleInfo = resources.GetString("jg.StyleInfo")
        Me.jg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.jg.TabIndex = 79
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(5, 104)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1000, 480)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 78
        '
        'Cortes_ad1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.Add(Me.jg)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.proceso)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.S1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.fecha_f)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fecha_i)
        Me.Controls.Add(Me.CANCELA)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cortes_ad1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Movimientos en Procesos Adicionales"
        CType(Me.jg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Cortes_Ad1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        proceso.SelectedIndex = 0
    End Sub


    Private Sub chequea_fechas(ByRef ok As Boolean)
        ok = True
        fecha = Format(CDate(fecha_i.Text), "yyyy-MM-dd")
        fecha1 = Format(CDate(fecha_f.Text), "yyyy-MM-dd")
        If fecha1 < fecha Then
            fecha = fecha1
            ok = False
            MsgBox("Error en las Fechas", MsgBoxStyle.Critical, "Por favor verifique !!")
        End If
    End Sub

    Private Sub llena_grid()
        dt = New DataTable()
        Dim dr As DataRow
        Dim prendas As Integer
        Dim saldo As Integer = 0
        Dim l As Integer = 1
        Dim strsql As String = "SELECT * FROM CORTES_PAR WHERE FECHA BETWEEN '" & fecha & "' AND '" & fecha1 & "' AND PROCESO = '" & proceso.Text & "' ORDER BY FECHA,CORTE,PROCESO,TIPO,DOCTO"
        If proceso.Text = "TODOS" Then
            strsql = "SELECT * FROM CORTES_PAR WHERE FECHA BETWEEN '" & fecha & "' AND '" & fecha1 & "' ORDER BY FECHA,CORTE,PROCESO,TIPO,DOCTO"
        End If
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("FECHA")
            fg(l, 2) = dr("CORTE")
            fg(l, 3) = dr("PROCESO")
            fg(l, 4) = dr("TIPO")
            fg(l, 5) = dr("DOCTO")
            fg(l, 6) = dr("LUGAR")
            fg(l, 7) = dr("RECIBIO")
            prendas = (dr("P0") + dr("P1") + dr("P2") + dr("P3") + dr("P4") + dr("P5") + dr("P6") + dr("P7") + dr("P8") + dr("P9") + dr("S0") + dr("S1") + dr("S2") + dr("S3") + dr("S4") + dr("S5") + dr("S6") + dr("S7") + dr("S8") + dr("S9"))
            fg(l, 8) = prendas
            l = l + 1
        Next
        If l > 1 Then
            fila = 1
            despliegue(fila)
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
        fecha = Format(Today, "dd/MM/yyyy")
        mal = obj.nombre + "  Procesos Adicionales a Cortes  del " + Format(CDate(fecha_i.Text), "dd/MM/yyyy") + " al " + Format(CDate(fecha_f.Text), "dd/MM/yyyy")
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = True
            .Margins.Left = 80
            .Margins.Right = 50
            .Margins.Top = 80
            .Margins.Bottom = 80
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("Empaque", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, mal + Chr(9) + Chr(9) + "Pagina {0}", "")
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
            llena_grid()
            S1.Visible = False
            CANCELA.Visible = True
            fecha_i.Enabled = False
            fecha_f.Enabled = False
            proceso.Enabled = False
            Button2.Visible = True
            Button3.Visible = True
        End If
    End Sub

    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELA.Click
        CANCELA.Visible = False
        S1.Visible = True
        fecha_i.Enabled = True
        fecha_f.Enabled = True
        proceso.Enabled = True
        Button2.Visible = False
        Button3.Visible = False
        fg.Rows.Count = 1
        jg.Rows.Count = 1
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        fila = fg.RowSel
        despliegue(fila)
    End Sub

    Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As RangeEventArgs) Handles fg.AfterRowColChange
        fila = fg.RowSel
        despliegue(fila)
    End Sub

    Private Sub despliegue(ByVal fila As Integer)
        Dim dd As DataRow()
        Dim dr As DataRow
        Dim i As Integer
        jg.Rows.Count = 3
        jg(1, 1) = "Primeras"
        jg(2, 1) = "Segundas"
        jg(1, 12) = 0
        jg(2, 12) = 0
        If fila > 0 And fila < fg.Rows.Count Then
            dd = dt.Select("DOCTO = '" & fg(fila, 5) & "'")
            If dd.Length > 0 Then
                dr = dd(0)
                For i = 0 To 9
                    jg(1, i + 2) = dr(i + 8)
                    jg(2, i + 2) = dr(i + 18)
                    jg(1, 12) = jg(1, 12) + dr(i + 8)
                    jg(2, 12) = jg(2, 12) + dr(i + 18)
                Next
                For i = 2 To 12
                    jg.Subtotal(AggregateEnum.Sum, 0, 0, i, "Gran Total -->")
                Next
            End If
        End If
    End Sub

End Class



