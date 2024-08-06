Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized
Imports C1.C1Excel

Public Class Prod_diaria_e
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents imprime As System.Windows.Forms.Button
    Friend WithEvents excel As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents mes As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sec As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prod_diaria_e))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.imprime = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.excel = New System.Windows.Forms.Button()
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.mes = New System.Windows.Forms.DateTimePicker()
        Me.sec = New System.Windows.Forms.ComboBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Mes:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'imprime
        '
        Me.imprime.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.imprime.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.imprime.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imprime.ForeColor = System.Drawing.Color.Black
        Me.imprime.Image = CType(resources.GetObject("imprime.Image"), System.Drawing.Image)
        Me.imprime.Location = New System.Drawing.Point(512, 8)
        Me.imprime.Name = "imprime"
        Me.imprime.Size = New System.Drawing.Size(35, 35)
        Me.imprime.TabIndex = 45
        Me.imprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.imprime, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.")
        Me.imprime.UseVisualStyleBackColor = False
        Me.imprime.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(464, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 46
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para Desplegar la Consulta.")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'excel
        '
        Me.excel.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.excel.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.excel.ForeColor = System.Drawing.Color.Black
        Me.excel.Image = CType(resources.GetObject("excel.Image"), System.Drawing.Image)
        Me.excel.Location = New System.Drawing.Point(560, 8)
        Me.excel.Name = "excel"
        Me.excel.Size = New System.Drawing.Size(35, 35)
        Me.excel.TabIndex = 49
        Me.excel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.excel, "Presione este Boton si Desea  convertir a Excel los datos. ")
        Me.excel.UseVisualStyleBackColor = False
        Me.excel.Visible = False
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CANCELA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CANCELA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCELA.ForeColor = System.Drawing.Color.Black
        Me.CANCELA.Image = CType(resources.GetObject("CANCELA.Image"), System.Drawing.Image)
        Me.CANCELA.Location = New System.Drawing.Point(464, 8)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(35, 35)
        Me.CANCELA.TabIndex = 69
        Me.CANCELA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.CANCELA, "Otro Pedido")
        Me.CANCELA.UseVisualStyleBackColor = False
        Me.CANCELA.Visible = False
        '
        'mes
        '
        Me.mes.CustomFormat = "MM/yyyy"
        Me.mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mes.Location = New System.Drawing.Point(80, 16)
        Me.mes.Name = "mes"
        Me.mes.ShowUpDown = True
        Me.mes.Size = New System.Drawing.Size(96, 26)
        Me.mes.TabIndex = 70
        Me.ToolTip1.SetToolTip(Me.mes, "Mes")
        '
        'sec
        '
        Me.sec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sec.Location = New System.Drawing.Point(296, 16)
        Me.sec.Name = "sec"
        Me.sec.Size = New System.Drawing.Size(80, 28)
        Me.sec.TabIndex = 72
        Me.ToolTip1.SetToolTip(Me.sec, "Elija el Cliente a consultar.")
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = "2,1,0,0,0,95,Columns:0{Width:3;Style:""TextAlign:LeftCenter;"";StyleFixed:""TextAlig" & _
    "n:LeftCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:158;Caption:""DIA"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 56)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 23
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(1000, 624)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(216, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 26)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Sección:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Prod_diaria_e
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 692)
        Me.Controls.Add(Me.sec)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mes)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.excel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.imprime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CANCELA)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Prod_diaria_e"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Producción Diaria por Estilo"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim pla As New DataTable()
    Dim cnn As New SqlClient.SqlConnection()
    Dim dr As DataRow
    Private Sub Prod_diaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 50
        fg.Height = Me.Height - 100
        mes.Text = CDate("01/" + mes.Text)
        llena_secciones()
        setea_grid()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Cols.Count = 2
        fg.Rows(0).Height = 40
    End Sub

    Private Sub imprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imprime.Click
        print_fg()
    End Sub

    Private Sub print_fg()
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
        fg.PrintGrid("estilos_prod", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, "Prendas producidas del mes de   " & mes.Text + "  Sección: " + sec.Text + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles excel.Click
        Dim ok As Boolean
        a_excel(fg, "c:\reportes\estilos_prod.xls", ok)
        If ok Then
            Close()
        End If
    End Sub
    '================================== llena mes  ==========================
    Private Sub llena_mes()
        Dim dt As New DataTable()
        Dim strsql As String
        Dim p As Integer
        Dim s As Integer
        Dim j As Integer
        Dim meses As String = Mid(mes.Text, 1, 2)
        Dim ano As String = Mid(mes.Text, 4, 4)
        Dim fecha As String
        Dim prendas As String
        Dim estilo As String
        Dim total As Integer
        Dim dr As DataRow
        If sec.Text = "TODAS" Then
            strsql = "SELECT FECHA,SECCION,ESTILO,SUM(PRENDAS)AS PRODUCCION FROM PRODUCCION WHERE MONTH(FECHA) = '" & meses & "' AND YEAR(FECHA) = '" & ano & "' GROUP BY FECHA,SECCION,ESTILO ORDER BY FECHA,ESTILO"
        Else
            strsql = "SELECT FECHA,SECCION,ESTILO,SUM(PRENDAS)AS PRODUCCION FROM PRODUCCION WHERE MONTH(FECHA) = '" & meses & "' AND YEAR(FECHA) = '" & ano & "' AND SECCION = '" & sec.Text & "' GROUP BY FECHA,SECCION,ESTILO ORDER BY FECHA,ESTILO"
        End If

        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            fecha = Format(dr("FECHA"), "dd - dddddd ")
            prendas = dr("PRODUCCION")
            estilo = dr("ESTILO")
            p = fg.FindRow(fecha, 1, 1, True)
            Try
                s = fg.Cols(estilo).Index()
            Catch
                agrega_columna(estilo, s)
            End Try
            If p < 0 Then
                p = fg.Rows.Count
                fg.Rows.Count = p + 1
                fg(p, 1) = fecha
            End If
            fg(p, s) = fg(p, s) + prendas
            total = total + prendas
        Next
        agrega_columna("TOTAL", s)
        s = fg.Cols.Count - 1
        For p = 1 To fg.Rows.Count - 1
            For j = 2 To fg.Cols.Count - 2
                fg(p, s) = fg(p, s) + fg(p, j)
            Next
        Next

        For p = 2 To fg.Cols.Count - 1
            fg.Subtotal(AggregateEnum.Sum, 0, 0, p, "Gran Total -->")
            Try
                If fg(fg.Rows.Count - 1, p) = 0 Then
                    'fg.Cols(p).Visible = False
                End If
                fg.Rows(fg.Rows.Count - 1).Height = 30
                fg(fg.Rows.Count - 1, 1) = "TOTALES ------>"
            Catch
            End Try
        Next
    End Sub

    Private Sub agrega_columna(ByVal nombre As String, ByRef c As Integer)
        c = fg.Cols.Count
        fg.Cols.Count = c + 1
        fg.Cols(c).DataType = GetType(Integer)
        fg.Cols(c).Format = "##,##0"
        fg.Cols(c).TextAlign = TextAlignEnum.RightCenter
        fg.Cols(c).TextAlignFixed = TextAlignEnum.CenterCenter
        fg.Cols(c).Width = 99
        fg.Cols(c).Name = nombre
        fg.Cols(c).Caption = nombre
    End Sub

    Private Sub procesa()
        Button1.Visible = False
        mes.Enabled = False
        sec.Enabled = False
        llena_mes()
        CANCELA.Visible = True
        imprime.Visible = True
        excel.Visible = True
        fg.ScrollBars = ScrollBars.Both
    End Sub

    Private Sub llena_secciones()
        Dim meses As String = Mid(mes.Text, 1, 2)
        Dim ano As String = Mid(mes.Text, 4, 4)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strsql As String = "SELECT DISTINCT SECCION FROM PRODUCCION WHERE MONTH(FECHA) = '" & meses & "' AND YEAR(FECHA) = '" & ano & "' ORDER BY SECCION"
        sec.Items.Clear()
        sec.Items.Add("TODAS")
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            sec.Items.Add(dr("SECCION"))
        Next
        Try
            sec.SelectedIndex = 0
        Catch
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        procesa()
    End Sub

    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELA.Click
        setea_grid()
        CANCELA.Visible = False
        imprime.Visible = False
        excel.Visible = False
        Button1.Visible = True
        mes.Enabled = True
        sec.Enabled = True
    End Sub

    Private Sub mes_ValueChanged(sender As System.Object, e As System.EventArgs) Handles mes.ValueChanged
        llena_secciones()
    End Sub
End Class
