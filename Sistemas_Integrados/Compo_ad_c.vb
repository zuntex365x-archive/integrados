Imports C1.Win.C1FlexGrid

Public Class Compo_ad_c
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dr As DataRow
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents s1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents fe_i As System.Windows.Forms.DateTimePicker
    Friend WithEvents fe_f As System.Windows.Forms.DateTimePicker
    Friend WithEvents toex As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Dim fecha As String
    Dim fecha1 As String
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compo_ad_c))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.fe_i = New System.Windows.Forms.DateTimePicker()
        Me.fe_f = New System.Windows.Forms.DateTimePicker()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.s1 = New System.Windows.Forms.Button()
        Me.toex = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(1307, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 40)
        Me.Button3.TabIndex = 110
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Limpia variables")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'fe_i
        '
        Me.fe_i.CustomFormat = "dd/MM/yyyy"
        Me.fe_i.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fe_i.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fe_i.Location = New System.Drawing.Point(183, 12)
        Me.fe_i.Name = "fe_i"
        Me.fe_i.ShowUpDown = True
        Me.fe_i.Size = New System.Drawing.Size(143, 29)
        Me.fe_i.TabIndex = 111
        Me.ToolTip1.SetToolTip(Me.fe_i, "Período.")
        '
        'fe_f
        '
        Me.fe_f.CustomFormat = "dd/MM/yyyy"
        Me.fe_f.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fe_f.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fe_f.Location = New System.Drawing.Point(183, 42)
        Me.fe_f.Name = "fe_f"
        Me.fe_f.ShowUpDown = True
        Me.fe_f.Size = New System.Drawing.Size(143, 29)
        Me.fe_f.TabIndex = 116
        Me.ToolTip1.SetToolTip(Me.fe_f, "Período.")
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.AutoGenerateColumns = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(12, 87)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(1405, 597)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 118
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Fecha Inicial:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        's1
        '
        Me.s1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.s1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s1.ForeColor = System.Drawing.Color.Black
        Me.s1.Image = CType(resources.GetObject("s1.Image"), System.Drawing.Image)
        Me.s1.Location = New System.Drawing.Point(1241, 12)
        Me.s1.Name = "s1"
        Me.s1.Size = New System.Drawing.Size(60, 40)
        Me.s1.TabIndex = 109
        Me.s1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.s1.UseVisualStyleBackColor = False
        '
        'toex
        '
        Me.toex.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.toex.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toex.ForeColor = System.Drawing.Color.Black
        Me.toex.Image = CType(resources.GetObject("toex.Image"), System.Drawing.Image)
        Me.toex.Location = New System.Drawing.Point(1241, 12)
        Me.toex.Name = "toex"
        Me.toex.Size = New System.Drawing.Size(60, 40)
        Me.toex.TabIndex = 117
        Me.toex.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.toex.UseVisualStyleBackColor = False
        Me.toex.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 29)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Fecha Final:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Compo_ad_c
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1425, 696)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.fe_f)
        Me.Controls.Add(Me.fe_i)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.s1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.toex)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Compo_ad_c"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autorización de DM"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Colores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 50
        fg.Height = Me.Height - 120
        setea_fg()
    End Sub


    Private Sub chequea_fechas(ByRef ok As Boolean)
        ok = True
        fecha = Format(CDate(fe_i.Text), "yyyy-MM-dd")
        fecha1 = Format(CDate(fe_f.Text), "yyyy-MM-dd")
        If fecha1 < fecha Then
            fecha = fecha1
            ok = False
            MsgBox("Error en las Fechas", MsgBoxStyle.Critical, "Por favor verifique !!")
        End If
    End Sub
    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub
    Private Sub procesa()
        llena_fg()
    End Sub
    Private Sub llena_fg()
        Dim strsql As String
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        strsql = "SELECT COMBO_TELA_1.*,DESCRIPCION FROM COMBO_TELA_1 LEFT JOIN CODIGO_TELA ON COMBO_TELA_1.CODIGO = CODIGO_TELA.CODIGO WHERE CAST(FECHA_TELAS AS DATE) BETWEEN '" & fecha & "' AND '" & fecha1 & "'"
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("FECHA_TELAS")
            fg(l, 2) = dr("CLIENTE")
            fg(l, 3) = dr("ESTILO")
            fg(l, 4) = dr("COLOR")
            fg(l, 5) = dr("COMPONENTE")
            fg(l, 6) = dr("COLOR_TELA")
            fg(l, 7) = dr("DM")
            fg(l, 8) = dr("CODIGO")
            fg(l, 9) = dr("DESCRIPCION")
            fg(l, 10) = dr("VERIFICA_TELAS")
            l = l + 1
        Next
    End Sub
    Private Sub s1_Click(sender As System.Object, e As System.EventArgs) Handles s1.Click
        chequea_fechas(ok)
        If ok Then
            s1.Visible = False
            toex.Visible = True
            fe_i.Enabled = False
            fe_f.Enabled = False
            procesa()
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        fe_i.Enabled = True
        fe_f.Enabled = True
        s1.Visible = True
        toex.Visible = False
        setea_fg()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles toex.Click
        Dim path As String = "c:\Reportes\Autoriza_DM_" & fecha & ".xls"
        Dim ok As Boolean
        a_excel(fg, path, ok)
        If ok Then
            Close()
        End If
    End Sub
End Class
