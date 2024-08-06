Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized
Imports C1.C1Excel

Public Class Reporte_47b
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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents to_excel As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reporte_47b))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.to_excel = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Location = New System.Drawing.Point(6, 49)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(972, 583)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 59
        '
        'to_excel
        '
        Me.to_excel.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.to_excel.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.to_excel.ForeColor = System.Drawing.Color.Black
        Me.to_excel.Image = CType(resources.GetObject("to_excel.Image"), System.Drawing.Image)
        Me.to_excel.Location = New System.Drawing.Point(12, 3)
        Me.to_excel.Name = "to_excel"
        Me.to_excel.Size = New System.Drawing.Size(60, 40)
        Me.to_excel.TabIndex = 109
        Me.to_excel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.to_excel.UseVisualStyleBackColor = False
        '
        'Reporte_47b
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(990, 652)
        Me.Controls.Add(Me.to_excel)
        Me.Controls.Add(Me.fg)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reporte_47b"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Ingreso 47 "
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim cnn As New SqlClient.SqlConnection
    Dim lineas As Integer
    Dim obj As empresas
    Private Sub Inventario_Mat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        setea_grid()
        llena_fg()
    End Sub
    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_fg()
        Dim cnn1 As New System.Data.SqlClient.SqlConnection()
        Dim strsql As String = "SELECT * FROM CPO_D_47"
        Dim l As Integer
        Dim dt As New DataTable
        llena_tablas(dt, strsql, cnn)
        Dim dr As DataRow
        For Each dr In dt.Rows
            fg.Rows.Count = fg.Rows.Count + 1
            l = fg.Rows.Count - 1
            fg(l, 0) = dr("CPO") + dr("ESTILO") + dr("COLOR")
            fg(l, 1) = dr("CPO")
            fg(l, 2) = dr("ESTILO")
            fg(l, 3) = dr("COLOR")
            fg(l, 4) = dr("DESTINO")
            fg(l, 5) = dr("SERIGRAFIA")
            fg(l, 6) = dr("SUB_CPO")
            fg(l, 7) = dr("CORTE")
            fg(l, 8) = dr("XS")
            fg(l, 9) = dr("S")
            fg(l, 10) = dr("M")
            fg(l, 11) = dr("L")
            fg(l, 12) = dr("XL")
            fg(l, 13) = dr("XL2")
            fg(l, 14) = dr("XL3")
            fg(l, 15) = dr("XL4")
            fg(l, 16) = dr("XL5")
            fg(l, 17) = dr("XL6")
            fg(l, 18) = dr("TOTAL")
        Next
        sub_total()
    End Sub

    Private Sub sub_total()
        Dim i As Integer
        For i = 8 To 18
            fg.Subtotal(AggregateEnum.Sum, 0, 0, i, "Gran Total -->")
            fg.Subtotal(AggregateEnum.Sum, -1, -1, i, "Gran Total -->")
        Next i
    End Sub

    Private Sub to_excel_Click(sender As System.Object, e As System.EventArgs) Handles to_excel.Click
        Dim ok As Boolean
        Dim hora As String = "c:\reportes\Reporte_47 " & Format(Now, "yyyy_MMM_dd HH_mm") & ".xls"
        a_excel(fg, hora, ok)
        Close()
    End Sub
End Class
