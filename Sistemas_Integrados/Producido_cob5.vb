Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized
Imports C1.C1Excel

Public Class Producido_cob5
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
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents sigue As System.Windows.Forms.Button
    Friend WithEvents imprime As System.Windows.Forms.Button
    Friend WithEvents fecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Producido_cob5))
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.sigue = New System.Windows.Forms.Button()
        Me.imprime = New System.Windows.Forms.Button()
        Me.fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CANCELA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CANCELA.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCELA.ForeColor = System.Drawing.Color.Black
        Me.CANCELA.Image = CType(resources.GetObject("CANCELA.Image"), System.Drawing.Image)
        Me.CANCELA.Location = New System.Drawing.Point(248, 16)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(35, 35)
        Me.CANCELA.TabIndex = 69
        Me.CANCELA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CANCELA.UseVisualStyleBackColor = False
        '
        'fecha
        '
        Me.fecha.CalendarForeColor = System.Drawing.SystemColors.Highlight
        Me.fecha.CustomFormat = "dd/MM/yyyy"
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha.Location = New System.Drawing.Point(96, 16)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(120, 26)
        Me.fecha.TabIndex = 1
        '
        'sigue
        '
        Me.sigue.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.sigue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sigue.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sigue.ForeColor = System.Drawing.Color.Black
        Me.sigue.Image = CType(resources.GetObject("sigue.Image"), System.Drawing.Image)
        Me.sigue.Location = New System.Drawing.Point(248, 16)
        Me.sigue.Name = "sigue"
        Me.sigue.Size = New System.Drawing.Size(35, 35)
        Me.sigue.TabIndex = 3
        Me.sigue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.sigue.UseVisualStyleBackColor = False
        '
        'imprime
        '
        Me.imprime.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.imprime.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.imprime.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imprime.ForeColor = System.Drawing.Color.Black
        Me.imprime.Image = CType(resources.GetObject("imprime.Image"), System.Drawing.Image)
        Me.imprime.Location = New System.Drawing.Point(296, 16)
        Me.imprime.Name = "imprime"
        Me.imprime.Size = New System.Drawing.Size(35, 35)
        Me.imprime.TabIndex = 94
        Me.imprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.imprime.UseVisualStyleBackColor = False
        Me.imprime.Visible = False
        '
        'fecha1
        '
        Me.fecha1.CalendarForeColor = System.Drawing.SystemColors.Highlight
        Me.fecha1.CustomFormat = "dd/MM/yyyy"
        Me.fecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecha1.Location = New System.Drawing.Point(96, 48)
        Me.fecha1.Name = "fecha1"
        Me.fecha1.Size = New System.Drawing.Size(120, 26)
        Me.fecha1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 26)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Desde:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 26)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Hasta:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(12, 79)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(974, 616)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 97
        Me.fg.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue
        '
        'Producido_cob5
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 707)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fecha1)
        Me.Controls.Add(Me.imprime)
        Me.Controls.Add(Me.sigue)
        Me.Controls.Add(Me.CANCELA)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Producido_cob5"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cortado vrs Producido"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim est As New DataTable()
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim cob As New DataTable()
    Dim dr As DataRow
    Dim fechas As String
    Dim rango As String
    Private Sub detalle_facturas_r(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler fecha.KeyPress, AddressOf keypressed1
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 150
        fecha.Value = Today
        deshabilita()
    End Sub

    Private Sub deshabilita()
        setea_grid()
        fecha.Enabled = True
        CANCELA.Visible = False
        sigue.Visible = True
        fecha.Focus()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    '================================================================
    '=                HANDLERS
    '================================================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(fecha.Text) <> "" Then
                sigue.Focus()
            End If
        End If
    End Sub
    Private Sub sigue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sigue.Click
        Dim ok As Boolean
        revisa_fechas(ok)
        If ok Then
            sigue.Visible = False
            CANCELA.Visible = True
            imprime.Visible = True
            fecha.Enabled = False
            fecha1.Enabled = False
            llena_fg()
        End If
    End Sub

    Private Sub revisa_fechas(ByRef ok As Boolean)
        rango = ""
        If fecha1.Value < fecha.Value Then
            MsgBox("La fecha final es menor que la inicial", MsgBoxStyle.Critical, "Por favor revise !!!!")
            ok = False
        Else
            ok = True
            rango = " FPROD BETWEEN '" & Format(fecha.Value, "yyyy-MM-dd") & "' AND '" & Format(fecha1.Value, "yyyy-MM-dd") & "' "
        End If
    End Sub

    Private Sub llena_fg()
        Dim f As Integer = 1
        Dim dt As New DataTable()
        Dim dr As DataRow
        llena_tablas(dt, "SELECT PROD_DIARIA.CORTE,CORTES.CPO,CORTES.ESTILO,CORTES.COLOR,CORTES_S.SALA AS SALA, CORTES.SECCION AS SECCION, CORTES.TOTAL AS CORTADO,SUM(PRENDAS) AS PRODUCIDO FROM PROD_DIARIA LEFT JOIN CORTES ON PROD_DIARIA.CORTE = CORTES.CORTE LEFT JOIN CORTES_S ON CORTES.CORTE = CORTES_S.CORTE WHERE " & rango & " GROUP BY PROD_DIARIA.CORTE,CORTES.CPO,CORTES.ESTILO,CORTES.COLOR,CORTES_S.SALA,CORTES.SECCION,CORTES.TOTAL  ORDER BY PROD_DIARIA.CORTE,CORTES.CPO,CORTES.ESTILO,CORTES.COLOR ", cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(f, 1) = dr("CORTE")
            fg(f, 2) = dr("CPO")
            fg(f, 3) = dr("ESTILO")
            fg(f, 4) = dr("COLOR")
            fg(f, 5) = dr("CORTADO")
            fg(f, 6) = dr("PRODUCIDO")
            fg(f, 7) = fg(f, 5) - fg(f, 6)
            fg(f, 8) = dr("SALA")
            fg(f, 9) = dr("SECCION")
            f = f + 1
        Next
        fg.Sort(SortFlags.Descending, 7)
        subtotales()
    End Sub
    Private Sub subtotales()
        Dim i As Integer
        For i = 5 To 7
            fg.Subtotal(AggregateEnum.Sum, -1, -1, i, "Gran Total -->")
        Next i
    End Sub
    Private Sub fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecha.ValueChanged
        fechas = Format(fecha.Value, "yyyy-MM-dd")
    End Sub

    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELA.Click
        sigue.Visible = True
        CANCELA.Visible = False
        imprime.Visible = False
        fecha.Enabled = True
        fecha1.Enabled = True
        fg.Rows.Count = 1
    End Sub

    Private Sub imprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imprime.Click
        Print_fg()
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fechad As String
        Dim mal As String
        Dim obj As empresas
        obj = New empresas()
        fechad = Format(fecha.Value, "dd/MM/yyyy")
        mal = "Cortado Vrs Producido " + fechad & "  al " & Format(fecha1.Value, "dd/MM/yyyy")
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = True
            .Margins.Left = 50
            .Margins.Right = 50
            .Margins.Top = 80
            .Margins.Bottom = 60
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("Prod_cob", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPrintDialog, mal + Chr(9) + Chr(9) + "Pagina {0}", UCase(Format(Now, "dd/MMM/yyyy  HH:mm:ss")))
    End Sub

    Private Sub fg_Click(sender As System.Object, e As System.EventArgs) Handles fg.AfterFilter
        subtotales()
    End Sub
End Class
