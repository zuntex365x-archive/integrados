Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO

Public Class Cumplimiento_5
    Inherits System.Windows.Forms.Form
    Dim pf As New DataTable
    Dim sf As New DataTable
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents fechaf As System.Windows.Forms.Label
    Dim cnn As New SqlClient.SqlConnection
    Dim ffinal As Date
    Dim sp As New DataTable
    Dim cs As New Lib_SI.util
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
    Friend WithEvents S1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cumplimiento_5))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.S1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.fechaf = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'S1
        '
        Me.S1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.S1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S1.ForeColor = System.Drawing.Color.Black
        Me.S1.Image = CType(resources.GetObject("S1.Image"), System.Drawing.Image)
        Me.S1.Location = New System.Drawing.Point(318, 12)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(60, 40)
        Me.S1.TabIndex = 57
        Me.S1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.S1, "Chequeo de Datos")
        Me.S1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 32)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Fecha F."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowMergingFixed = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(12, 71)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(986, 606)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 67
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(387, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 40)
        Me.Button3.TabIndex = 68
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'fechaf
        '
        Me.fechaf.BackColor = System.Drawing.Color.White
        Me.fechaf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fechaf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaf.Location = New System.Drawing.Point(105, 18)
        Me.fechaf.Name = "fechaf"
        Me.fechaf.Size = New System.Drawing.Size(183, 32)
        Me.fechaf.TabIndex = 69
        Me.fechaf.Text = " "
        Me.fechaf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cumplimiento_5
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.Add(Me.fechaf)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.S1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cumplimiento_5"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cumplimiento 5 semanas"
        Me.ToolTip1.SetToolTip(Me, " ")
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Cumplimiento_5_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim hoy As Date = Today
        Dim d As Integer = hoy.DayOfWeek
        fg.Height = Me.Height - 150
        fg.Width = Me.Width - 50
        ffinal = hoy.AddDays(-d)
        ffinal = ffinal.AddDays(35)
        llena_tablas_aux()
        fechaf.Text = Format(ffinal, "dd/MM/yyyy")
        setea_fg()
    End Sub
    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub
    Private Sub llena_fg()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim fspace As Date
        Dim ok As Boolean
        Dim dias As Integer
        Dim strsql As String = "SELECT * FROM FPO WHERE RECIBIDAS = 0 AND STATUS = 'ABIERTO' AND RFECHA < = '" & Format(ffinal, "yyyy-MM-dd") & "' ORDER BY FPO"
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("CLIENTE")
            fg(l, 2) = dr("FPO")
            fg(l, 3) = dr("LOTE")
            fg(l, 4) = dr("KNIT")
            fg(l, 5) = dr("COLOR")
            fg(l, 6) = dr("LIBRAS")
            fg(l, 7) = dr("IFECHA")
            fg(l, 8) = dr("RFECHA")
            busca_batch(dr("LOTE"), fspace, ok)
            If ok Then
                fg(l, 9) = fspace
                dias = DateDiff(DateInterval.Day, fg(l, 8), fg(l, 9))
                If dias < 366 Then
                    fg(l, 10) = dias
                End If
                If fg(l, 10) > 0 Then
                    fg.SetCellStyle(l, 10, "rojo")
                End If
                fg(l, 11) = DateDiff(DateInterval.Day, fg(l, 7), fg(l, 9))
            Else
                fg.SetCellStyle(l, 10, "rojo")
            End If
            l = l + 1
        Next
    End Sub
    Private Sub S1_Click(sender As System.Object, e As System.EventArgs) Handles S1.Click
        Cursor = Cursors.WaitCursor
        setea_fg()
        llena_fg()
        S1.Enabled = False
        Button3.Visible = True
        Cursor = Cursors.Default
    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim ok As Boolean
        Dim fec As String
        fec = "c:\reportes\Cumplimiento_" + Format(ffinal, "yyyy_MM_dd") + ".xls"
        a_excel(fg, fec, ok)
        If ok Then
            Close()
        End If
    End Sub
    Private Sub busca_batch(ByVal batch As String, ByRef fspace As Date, ByRef ok As Boolean)
        Dim dr As DataRow
        Dim dd As DataRow()
        ok = False
        dd = sp.Select("BATCH = '" & batch & "'")
        If dd.Length > 0 Then
            dr = dd(0)
            fspace = dr("ENTREGA")
            ok = True
        Else
            fspace = CDate("2099-12-31")
        End If
    End Sub
    Private Sub llena_tablas_aux()
        Dim dt As New DataTable
        Dim dr As DataRow = Nothing
        Dim strsql As String = "SELECT DISTINCT FECHA FROM SPACE ORDER BY FECHA DESC"
        Dim cnn0 As New SqlClient.SqlConnection
        cnn0.ConnectionString = cs.con_string(0)
        llena_tablas_e(dt, strsql, cnn0)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
        End If
        llena_tablas_e(sp, "SELECT BATCH,ENTREGA  FROM SPACE WHERE FECHA = '" & Format(dr("FECHA"), "yyyy-MM-dd") & "' ORDER BY BATCH", cnn0)
    End Sub
End Class



