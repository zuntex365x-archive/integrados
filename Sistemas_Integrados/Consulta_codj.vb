Imports C1.Win.C1FlexGrid

Public Class Consulta_codj
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Dim lineas As Integer
    Dim da As System.Data.SqlClient.SqlDataAdapter
    Dim ct As New DataTable()
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
    Friend WithEvents fj As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consulta_codj))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fj = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 16)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(992, 672)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        Me.fg.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
        '
        'fj
        '
        Me.fj.AllowEditing = False
        Me.fj.ColumnInfo = resources.GetString("fj.ColumnInfo")
        Me.fj.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fj.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fj.Location = New System.Drawing.Point(9, 128)
        Me.fj.Name = "fj"
        Me.fj.Rows.DefaultSize = 19
        Me.fj.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fj.Size = New System.Drawing.Size(992, 496)
        Me.fj.StyleInfo = resources.GetString("fj.StyleInfo")
        Me.fj.TabIndex = 49
        Me.ToolTip1.SetToolTip(Me.fj, "Area de Datos.")
        Me.fj.Visible = False
        '
        'Consulta_codj
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.fj)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Consulta_codj"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro de Códigos de Tela"
        Me.ToolTip1.SetToolTip(Me, "Maestro de Códigos de Tela")
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        setea_grid()
        llena_grid()
    End Sub
    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Cols.Count = 3
        fg.Rows(0).Height = 35
    End Sub

    Private Sub llena_grid()
        Dim l As Integer = 1
        Dim s As Integer
        Dim strSQL As String = "SELECT * FROM CODIGO_TELA ORDER BY CODIGO "
        Dim dt As New DataTable()
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn)
        s = dt.Rows.Count
        fg.Rows.Count = fg.Rows.Count + s
        For Each dr In dt.Rows
            fg(l, 1) = dr("CODIGO")
            fg(l, 2) = dr("DESCRIPCION")
            fg.Rows(l).Height = 20
            l = l + 1
        Next dr
    End Sub

End Class
