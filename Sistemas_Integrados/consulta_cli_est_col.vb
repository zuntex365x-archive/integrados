Imports System.IO
Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.Collections.Specialized


Public Class consulta_cli_est_col
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Dim lineas As Integer
    Dim cliente As String
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C4 As System.Windows.Forms.ComboBox
    Friend WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents button3 As System.Windows.Forms.Button
    Friend WithEvents s1 As System.Windows.Forms.Button
    Friend WithEvents r1 As System.Windows.Forms.Button
    Dim path As String = "c:\reportes\cli_est_col.xls"
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consulta_cli_est_col))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C4 = New System.Windows.Forms.ComboBox()
        Me.s1 = New System.Windows.Forms.Button()
        Me.r1 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 32)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Cliente:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(11, 51)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(976, 601)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 102
        '
        'C4
        '
        Me.C4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C4.Location = New System.Drawing.Point(102, 16)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(240, 24)
        Me.C4.TabIndex = 0
        '
        's1
        '
        Me.s1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.s1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s1.ForeColor = System.Drawing.Color.Black
        Me.s1.Image = CType(resources.GetObject("s1.Image"), System.Drawing.Image)
        Me.s1.Location = New System.Drawing.Point(399, 5)
        Me.s1.Name = "s1"
        Me.s1.Size = New System.Drawing.Size(60, 40)
        Me.s1.TabIndex = 107
        Me.s1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.s1.UseVisualStyleBackColor = False
        '
        'r1
        '
        Me.r1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.r1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r1.ForeColor = System.Drawing.Color.Black
        Me.r1.Image = CType(resources.GetObject("r1.Image"), System.Drawing.Image)
        Me.r1.Location = New System.Drawing.Point(399, 5)
        Me.r1.Name = "r1"
        Me.r1.Size = New System.Drawing.Size(60, 40)
        Me.r1.TabIndex = 106
        Me.r1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.r1.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.Black
        Me.button2.Image = CType(resources.GetObject("button2.Image"), System.Drawing.Image)
        Me.button2.Location = New System.Drawing.Point(465, 5)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(60, 40)
        Me.button2.TabIndex = 105
        Me.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.button2.UseVisualStyleBackColor = False
        Me.button2.Visible = False
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.ForeColor = System.Drawing.Color.Black
        Me.button3.Image = CType(resources.GetObject("button3.Image"), System.Drawing.Image)
        Me.button3.Location = New System.Drawing.Point(531, 5)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(60, 40)
        Me.button3.TabIndex = 104
        Me.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.button3.UseVisualStyleBackColor = False
        Me.button3.Visible = False
        '
        'consulta_cli_est_col
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 668)
        Me.Controls.Add(Me.s1)
        Me.Controls.Add(Me.r1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.C4)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label4)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "consulta_cli_est_col"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Estilo_Colores por Cliente"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub consulta_cortes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler C4.KeyPress, AddressOf keypressed1
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        llena_combos(C4, "SELECT * FROM CLIENTES ORDER BY CLIENTE", "CLIENTE")
        setea_grid()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_grid(ByVal CLIENTE As String)
        ok = False
        Dim strSQL As String
        If CLIENTE = "TODOS" Then
            strSQL = "SELECT * FROM CLI_EST_COL ORDER BY CLIENTE,ESTILO,COLOR"
        Else
            strSQL = "SELECT * FROM CLI_EST_COL WHERE CLIENTE = '" & CLIENTE & "' ORDER BY CLIENTE,ESTILO,COLOR"
        End If
        llena_tablas(dt, strSQL, cnn)
        For Each Me.dr In dt.Rows
            fg.Rows.Count = fg.Rows.Count + 1
            lineas = fg.Rows.Count - 1
            fg(lineas, 1) = dr("CLIENTE")
            fg(lineas, 2) = dr("ESTILO")
            fg(lineas, 3) = dr("COLOR")
        Next
    End Sub

    Private Sub s1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles s1.Click
        cliente = C4.Text
        setea_grid()
        llena_grid(cliente)
        Button3.Visible = True
        button2.Visible = True
        s1.Visible = False
        r1.Visible = True
        C4.Enabled = False
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        fecha = Format(Today, "dd/MM/yyy")
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = False
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 12, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 10, FontStyle.Italic)
        fg.PrintGrid("inventario", PrintGridFlags.ShowPreviewDialog + PrintGridFlags.FitToPageWidth, "Consulta de Estilos_colores del Cliente: " + Trim(cliente) + "  al " + fecha + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Print_fg()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        a_excel(fg, path, ok)
        If ok Then
            Close()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r1.Click
        button2.Visible = False
        button3.Visible = False
        r1.Visible = False
        s1.Visible = True
        C4.Enabled = True
        setea_grid()
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            s1.Focus()
        End If
    End Sub 'keypressed

    Private Sub c4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C4.KeyPress
        AutoCompletar(C4, e)
    End Sub
End Class
