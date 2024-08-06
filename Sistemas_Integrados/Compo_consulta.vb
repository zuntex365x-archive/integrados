Imports C1.Win.C1FlexGrid

Public Class Compo_consulta
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dr As DataRow
    Dim nuevo As Boolean
    Dim usuario As String
    Dim empre As New empresas
    Friend WithEvents jg As C1.Win.C1FlexGrid.C1FlexGrid
    Dim estados As String
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compo_consulta))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.jg = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 318)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(1016, 354)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'jg
        '
        Me.jg.AllowFiltering = True
        Me.jg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.jg.AutoGenerateColumns = False
        Me.jg.ColumnInfo = resources.GetString("jg.ColumnInfo")
        Me.jg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.jg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.jg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.jg.Location = New System.Drawing.Point(8, 12)
        Me.jg.Name = "jg"
        Me.jg.Rows.DefaultSize = 19
        Me.jg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.jg.Size = New System.Drawing.Size(803, 287)
        Me.jg.StyleInfo = resources.GetString("jg.StyleInfo")
        Me.jg.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.jg, "Area de Datos.")
        '
        'Compo_consulta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1042, 696)
        Me.Controls.Add(Me.jg)
        Me.Controls.Add(Me.fg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Compo_consulta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Componentes "
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Colores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setea_jg()
        setea_fg()
        llena_jg()
        Try
            jg.RowSel = 1
            llena_fg()
        Catch
        End Try
        jg.Focus()
    End Sub
    Private Sub setea_jg()
        jg.Rows.Count = 1
        jg.Rows(0).Height = 30
    End Sub

    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub
    Private Sub llena_jg()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim strsql As String = "SELECT DISTINCT CLIENTE+ESTILO+COLOR ,CLIENTE,ESTILO,COLOR FROM COMBO_TELA_1 WHERE ESTADO <> 'V' "
        llena_tablas(dt, strsql, cnn)
        jg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            jg(l, 1) = dr("CLIENTE")
            jg(l, 2) = dr("ESTILO")
            jg(l, 3) = dr("COLOR")
            l = l + 1
        Next
    End Sub
    Private Sub llena_fg() Handles jg.RowColChange
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        Dim f As Integer = jg.RowSel
        Try
            Dim strsql As String = "SELECT * FROM COMBO_TELA_1 WHERE CLIENTE = '" & jg(f, 1) & "' AND ESTILO = '" & jg(f, 2) & "' AND COLOR = '" & jg(f, 3) & "'"
            llena_tablas(dt, strsql, cnn)
            fg.Rows.Count = dt.Rows.Count + 1
            For Each dr In dt.Rows
                fg(l, 1) = dr("ESTILO")
                fg(l, 2) = dr("COLOR")
                fg(l, 3) = dr("COMPONENTE")
                fg(l, 4) = dr("COLOR_TELA")
                l = l + 1
            Next
        Catch
        End Try

    End Sub
End Class
