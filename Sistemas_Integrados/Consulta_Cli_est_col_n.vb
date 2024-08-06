Imports C1.Win.C1FlexGrid

Public Class Consulta_Cli_est_col_n
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents cl As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents d6_ccolor As System.Windows.Forms.Label
    Friend WithEvents d6_cestilo As System.Windows.Forms.Label
    Friend WithEvents d6_color As System.Windows.Forms.Label
    Friend WithEvents d6_estilo As System.Windows.Forms.Label
    Friend WithEvents d6_cliente As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Dim lineas As Integer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consulta_Cli_est_col_n))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.cl = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.d6_ccolor = New System.Windows.Forms.Label()
        Me.d6_cestilo = New System.Windows.Forms.Label()
        Me.d6_color = New System.Windows.Forms.Label()
        Me.d6_estilo = New System.Windows.Forms.Label()
        Me.d6_cliente = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(11, 480)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 21
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(952, 208)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'cl
        '
        Me.cl.AllowEditing = False
        Me.cl.AllowFiltering = True
        Me.cl.ColumnInfo = resources.GetString("cl.ColumnInfo")
        Me.cl.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.cl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cl.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.cl.Location = New System.Drawing.Point(6, 12)
        Me.cl.Name = "cl"
        Me.cl.Rows.DefaultSize = 21
        Me.cl.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.cl.Size = New System.Drawing.Size(952, 259)
        Me.cl.StyleInfo = resources.GetString("cl.StyleInfo")
        Me.cl.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.cl, "Area de Datos.")
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.d6_ccolor)
        Me.GroupBox2.Controls.Add(Me.d6_cestilo)
        Me.GroupBox2.Controls.Add(Me.d6_color)
        Me.GroupBox2.Controls.Add(Me.d6_estilo)
        Me.GroupBox2.Controls.Add(Me.d6_cliente)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 277)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(950, 200)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        '
        'd6_ccolor
        '
        Me.d6_ccolor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.d6_ccolor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.d6_ccolor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.d6_ccolor.Location = New System.Drawing.Point(172, 157)
        Me.d6_ccolor.Name = "d6_ccolor"
        Me.d6_ccolor.Size = New System.Drawing.Size(340, 28)
        Me.d6_ccolor.TabIndex = 124
        Me.d6_ccolor.Text = " "
        Me.d6_ccolor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'd6_cestilo
        '
        Me.d6_cestilo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.d6_cestilo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.d6_cestilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.d6_cestilo.Location = New System.Drawing.Point(172, 126)
        Me.d6_cestilo.Name = "d6_cestilo"
        Me.d6_cestilo.Size = New System.Drawing.Size(340, 28)
        Me.d6_cestilo.TabIndex = 123
        Me.d6_cestilo.Text = " "
        Me.d6_cestilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'd6_color
        '
        Me.d6_color.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.d6_color.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.d6_color.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.d6_color.Location = New System.Drawing.Point(172, 73)
        Me.d6_color.Name = "d6_color"
        Me.d6_color.Size = New System.Drawing.Size(340, 28)
        Me.d6_color.TabIndex = 122
        Me.d6_color.Text = " "
        Me.d6_color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'd6_estilo
        '
        Me.d6_estilo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.d6_estilo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.d6_estilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.d6_estilo.Location = New System.Drawing.Point(172, 44)
        Me.d6_estilo.Name = "d6_estilo"
        Me.d6_estilo.Size = New System.Drawing.Size(340, 28)
        Me.d6_estilo.TabIndex = 121
        Me.d6_estilo.Text = " "
        Me.d6_estilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'd6_cliente
        '
        Me.d6_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.d6_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.d6_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.d6_cliente.Location = New System.Drawing.Point(172, 14)
        Me.d6_cliente.Name = "d6_cliente"
        Me.d6_cliente.Size = New System.Drawing.Size(340, 29)
        Me.d6_cliente.TabIndex = 120
        Me.d6_cliente.Text = " "
        Me.d6_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(16, 127)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(150, 28)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Estilo Cliente:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.SteelBlue
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(16, 157)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(150, 28)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "Color Cliente:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.SteelBlue
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(16, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(150, 28)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "Cliente:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.SteelBlue
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(16, 44)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(150, 28)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "Estilo:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.SteelBlue
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(16, 73)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(150, 28)
        Me.Label25.TabIndex = 47
        Me.Label25.Text = "Color:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Consulta_Cli_est_col_n
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(970, 696)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cl)
        Me.Controls.Add(Me.fg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Consulta_Cli_est_col_n"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de  Estilos_Colores por Cliente"
        Me.ToolTip1.SetToolTip(Me, "Consulta de  Estilos_Colores por Cliente")
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setea_estilos()
        llena_estilos()
        setea_fg()
        Try
            cl.RowSel = 1
        Catch
        End Try

    End Sub

    Private Sub setea_estilos()
        cl.Rows.Count = 1
        cl.Rows(0).Height = 30
        llena_estilos()
    End Sub

    Private Sub llena_estilos()
        Dim l As Integer = 1
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim strsql As String = "SELECT * FROM CLI_EST_COL "
        llena_tablas(dt, strsql, cnn)
        cl.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            cl(l, 1) = dr("CLIENTE")
            cl(l, 2) = dr("ESTILO")
            cl(l, 3) = dr("COLOR")
            l = l + 1
        Next

    End Sub
    Private Sub setea_fg()
        Dim r As Integer = cl.RowSel
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        d6_cestilo.Text = ""
        d6_ccolor.Text = ""
        d6_cliente.Text = cl(r, 1)
        d6_estilo.Text = cl(r, 2)
        d6_color.Text = cl(r, 3)
        llena_fg()
    End Sub

    Private Sub llena_fg()
        Dim l As Integer = 1
        Dim r As Integer = cl.RowSel
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim strsql As String = "SELECT * FROM CLI_EST_COL_1 WHERE CLIENTE = '" & cl(r, 1) & "' AND ESTILO = '" & cl(r, 2) & "' AND COLOR = '" & cl(r, 3) & "'"
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            d6_cestilo.Text = dr("ESTILO_CLIENTE")
            d6_ccolor.Text = dr("COLOR_CLIENTE")
        Next
        strsql = "SELECT * FROM CLI_EST_COL_P WHERE CLIENTE = '" & cl(r, 1) & "' AND ESTILO = '" & cl(r, 2) & "' AND COLOR = '" & cl(r, 3) & "'"
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("PROCESO")
            fg(l, 2) = dr("DETALLE")
            fg(l, 3) = dr("COMENTARIOS")
            l = l + 1
        Next
    End Sub

    Private Sub seleccion(ByVal fil As Integer)
        If fil > 0 And fil < cl.Rows.Count Then
            cl.RowSel = fil
            setea_fg()
        End If
    End Sub

    Private Sub cl_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles cl.KeyDown
        If e.KeyCode = Keys.Up Then
            seleccion(cl.Row - 1)
        End If

        If e.KeyCode = Keys.Down Then
            seleccion(cl.Row + 1)
        End If
    End Sub

    Private Sub cl_Click(sender As System.Object, e As System.EventArgs) Handles cl.Click
        Dim fil As Integer = cl.RowSel
        seleccion(fil)
    End Sub
End Class
