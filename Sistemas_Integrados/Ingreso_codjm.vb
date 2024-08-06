Imports C1.Win.C1FlexGrid
Public Class Ingreso_codjm
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn As New System.Data.SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Dim lineas As Integer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cod As System.Windows.Forms.Label
    Friend WithEvents fib2 As System.Windows.Forms.Label
    Friend WithEvents fib1 As System.Windows.Forms.ComboBox
    Friend WithEvents con2 As System.Windows.Forms.Label
    Friend WithEvents con1 As System.Windows.Forms.ComboBox
    Friend WithEvents we2 As System.Windows.Forms.Label
    Friend WithEvents we1 As System.Windows.Forms.ComboBox
    Friend WithEvents fa2 As System.Windows.Forms.Label
    Friend WithEvents fa1 As System.Windows.Forms.ComboBox
    Dim fb As New DataTable
    Dim wg As New DataTable
    Dim ct As New DataTable
    Friend WithEvents fj As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents dm As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Dim fr As New DataTable

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
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents Elimi As System.Windows.Forms.Button
    Friend WithEvents Graba As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Descrip As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingreso_codjm))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.R1 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Elimi = New System.Windows.Forms.Button()
        Me.Graba = New System.Windows.Forms.Button()
        Me.Descrip = New System.Windows.Forms.Label()
        Me.fa2 = New System.Windows.Forms.Label()
        Me.we2 = New System.Windows.Forms.Label()
        Me.con2 = New System.Windows.Forms.Label()
        Me.fib2 = New System.Windows.Forms.Label()
        Me.cod = New System.Windows.Forms.Label()
        Me.fj = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.fib1 = New System.Windows.Forms.ComboBox()
        Me.con1 = New System.Windows.Forms.ComboBox()
        Me.we1 = New System.Windows.Forms.ComboBox()
        Me.fa1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dm = New System.Windows.Forms.ComboBox()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 254)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 25
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(992, 402)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(784, 16)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(60, 40)
        Me.R1.TabIndex = 19
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R1.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(8, 664)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(536, 16)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Para Seleccionar una Fila en especial  Presione Click."
        '
        'Elimi
        '
        Me.Elimi.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Elimi.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Elimi.ForeColor = System.Drawing.Color.Black
        Me.Elimi.Image = CType(resources.GetObject("Elimi.Image"), System.Drawing.Image)
        Me.Elimi.Location = New System.Drawing.Point(916, 16)
        Me.Elimi.Name = "Elimi"
        Me.Elimi.Size = New System.Drawing.Size(60, 40)
        Me.Elimi.TabIndex = 51
        Me.Elimi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Elimi, "Presione este Boton para Borrar el Registro Seleccionado.")
        Me.Elimi.UseVisualStyleBackColor = False
        '
        'Graba
        '
        Me.Graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Graba.ForeColor = System.Drawing.Color.Black
        Me.Graba.Image = CType(resources.GetObject("Graba.Image"), System.Drawing.Image)
        Me.Graba.Location = New System.Drawing.Point(850, 16)
        Me.Graba.Name = "Graba"
        Me.Graba.Size = New System.Drawing.Size(60, 40)
        Me.Graba.TabIndex = 50
        Me.Graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Graba, "Presione este Boton para Grabar o Actualizar los Datos")
        Me.Graba.UseVisualStyleBackColor = False
        Me.Graba.Visible = False
        '
        'Descrip
        '
        Me.Descrip.BackColor = System.Drawing.Color.White
        Me.Descrip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Descrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descrip.ForeColor = System.Drawing.Color.Black
        Me.Descrip.Location = New System.Drawing.Point(226, 181)
        Me.Descrip.Name = "Descrip"
        Me.Descrip.Size = New System.Drawing.Size(664, 26)
        Me.Descrip.TabIndex = 52
        Me.Descrip.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.Descrip, "Descripción de la Tela")
        '
        'fa2
        '
        Me.fa2.BackColor = System.Drawing.Color.White
        Me.fa2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fa2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fa2.ForeColor = System.Drawing.Color.Black
        Me.fa2.Location = New System.Drawing.Point(226, 16)
        Me.fa2.Name = "fa2"
        Me.fa2.Size = New System.Drawing.Size(476, 26)
        Me.fa2.TabIndex = 82
        Me.fa2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.fa2, "Descripción de la Tela")
        '
        'we2
        '
        Me.we2.BackColor = System.Drawing.Color.White
        Me.we2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.we2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.we2.ForeColor = System.Drawing.Color.Black
        Me.we2.Location = New System.Drawing.Point(226, 46)
        Me.we2.Name = "we2"
        Me.we2.Size = New System.Drawing.Size(476, 26)
        Me.we2.TabIndex = 84
        Me.we2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.we2, "Descripción de la Tela")
        '
        'con2
        '
        Me.con2.BackColor = System.Drawing.Color.White
        Me.con2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.con2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.con2.ForeColor = System.Drawing.Color.Black
        Me.con2.Location = New System.Drawing.Point(226, 76)
        Me.con2.Name = "con2"
        Me.con2.Size = New System.Drawing.Size(476, 26)
        Me.con2.TabIndex = 86
        Me.con2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.con2, "Descripción de la Tela")
        '
        'fib2
        '
        Me.fib2.BackColor = System.Drawing.Color.White
        Me.fib2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fib2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fib2.ForeColor = System.Drawing.Color.Black
        Me.fib2.Location = New System.Drawing.Point(226, 106)
        Me.fib2.Name = "fib2"
        Me.fib2.Size = New System.Drawing.Size(476, 26)
        Me.fib2.TabIndex = 88
        Me.fib2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.fib2, "Descripción de la Tela")
        '
        'cod
        '
        Me.cod.BackColor = System.Drawing.Color.White
        Me.cod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cod.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod.ForeColor = System.Drawing.Color.Black
        Me.cod.Location = New System.Drawing.Point(23, 181)
        Me.cod.Name = "cod"
        Me.cod.Size = New System.Drawing.Size(186, 26)
        Me.cod.TabIndex = 89
        Me.cod.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cod, "Descripción de la Tela")
        '
        'fj
        '
        Me.fj.AllowEditing = False
        Me.fj.ColumnInfo = resources.GetString("fj.ColumnInfo")
        Me.fj.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.fj.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fj.Location = New System.Drawing.Point(9, 254)
        Me.fj.Name = "fj"
        Me.fj.Rows.DefaultSize = 21
        Me.fj.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fj.Size = New System.Drawing.Size(992, 370)
        Me.fj.StyleInfo = resources.GetString("fj.StyleInfo")
        Me.fj.TabIndex = 49
        Me.ToolTip1.SetToolTip(Me.fj, "Area de Datos.")
        Me.fj.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dm)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cod)
        Me.GroupBox2.Controls.Add(Me.fib2)
        Me.GroupBox2.Controls.Add(Me.fib1)
        Me.GroupBox2.Controls.Add(Me.con2)
        Me.GroupBox2.Controls.Add(Me.con1)
        Me.GroupBox2.Controls.Add(Me.we2)
        Me.GroupBox2.Controls.Add(Me.we1)
        Me.GroupBox2.Controls.Add(Me.fa2)
        Me.GroupBox2.Controls.Add(Me.fa1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Descrip)
        Me.GroupBox2.Controls.Add(Me.R1)
        Me.GroupBox2.Controls.Add(Me.Graba)
        Me.GroupBox2.Controls.Add(Me.Elimi)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(992, 240)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        '
        'fib1
        '
        Me.fib1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fib1.Location = New System.Drawing.Point(133, 106)
        Me.fib1.Name = "fib1"
        Me.fib1.Size = New System.Drawing.Size(74, 26)
        Me.fib1.TabIndex = 87
        '
        'con1
        '
        Me.con1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.con1.Location = New System.Drawing.Point(133, 76)
        Me.con1.Name = "con1"
        Me.con1.Size = New System.Drawing.Size(74, 26)
        Me.con1.TabIndex = 85
        '
        'we1
        '
        Me.we1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.we1.Location = New System.Drawing.Point(133, 46)
        Me.we1.Name = "we1"
        Me.we1.Size = New System.Drawing.Size(74, 26)
        Me.we1.TabIndex = 83
        '
        'fa1
        '
        Me.fa1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fa1.Location = New System.Drawing.Point(133, 16)
        Me.fa1.Name = "fa1"
        Me.fa1.Size = New System.Drawing.Size(74, 26)
        Me.fa1.TabIndex = 81
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(23, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 26)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Fiber:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(23, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 26)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Contenido:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(23, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 26)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Weight:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 26)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Fabric:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(23, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 26)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "DM:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dm
        '
        Me.dm.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dm.Location = New System.Drawing.Point(133, 138)
        Me.dm.Name = "dm"
        Me.dm.Size = New System.Drawing.Size(186, 26)
        Me.dm.TabIndex = 91
        '
        'Ingreso_codj
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.fj)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ingreso_codj"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro de Códigos de Tela"
        Me.ToolTip1.SetToolTip(Me, "Maestro de Códigos de Tela")
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler fa1.KeyPress, AddressOf keypressed1
        AddHandler we1.KeyPress, AddressOf keypressed2
        AddHandler con1.KeyPress, AddressOf keypressed3
        AddHandler fib1.KeyPress, AddressOf keypressed4
        AddHandler dm.KeyPress, AddressOf keypressed5
        llena_datatables()
        limpia_variables()
        setea_grid()
        llena_grid()
    End Sub

    Private Sub limpia_variables()
        fa1.Enabled = True
        we1.Enabled = True
        con1.Enabled = True
        fib1.Enabled = True
        Graba.Visible = False
        Elimi.Visible = False
        fa1.Focus()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
    End Sub
    Private Sub llena_datatables()
        llena_tablas(fb, "SELECT * FROM MAE_TEL_FAB", cnn)
        llena_tablas(wg, "SELECT * FROM MAE_TEL_WEI", cnn)
        llena_tablas(ct, "SELECT * FROM MAE_TEL_CON", cnn)
        llena_tablas(fr, "SELECT * FROM MAE_TEL_FIB", cnn)
        llena_tipos_Telas(fb, fa1)
        llena_tipos_Telas(wg, we1)
        llena_tipos_Telas(ct, con1)
        llena_tipos_Telas(fr, fib1)
        Try
            fa1.SelectedIndex = 0
        Catch ex As Exception
        End Try
        Try
            we1.SelectedIndex = 0
        Catch ex As Exception
        End Try
        Try
            con1.SelectedIndex = 0
        Catch ex As Exception
        End Try
        Try
            fib1.SelectedIndex = 0
        Catch ex As Exception
        End Try
        llena_combos(dm, "SELECT * FROM DM", "DM")
    End Sub

    Private Sub llena_grid()
        Dim l As Integer = 1
        Dim strSQL As String = "SELECT * FROM CODIGO_TELA1 ORDER BY CODIGO"
        Dim dt As New DataTable()
        Dim dr As DataRow
        llena_tablas(dt, strSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + l
        For Each dr In dt.Rows
            fg(l, 1) = dr("CODIGO")
            fg(l, 2) = dr("DESCRIPCION")
            l = l + 1
        Next dr
    End Sub

    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OkOnly, var + " NO VALIDO !!!! ")
    End Sub

    Private Sub seleccion(ByVal fil As Integer)
        If fil > 0 And fil < fg.Rows.Count Then
            cod.Text = fg(fil, 1)
            busca_codigo()
        End If
    End Sub

    Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles fg.KeyDown
        If e.KeyCode = Keys.Up Then
            seleccion(fg.Row - 1)
        End If

        If e.KeyCode = Keys.Down Then
            seleccion(fg.Row + 1)
        End If
    End Sub

    Private Sub busca_codigo()
        Dim l As Integer = 1
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim codigo As String = cod.Text
        Dim strSQL As String = "SELECT * FROM CODIGO_TELA1 WHERE CODIGO = '" & codigo & "'"
        llena_tablas(dt, strSQL, cnn)
        If dt.Rows.Count = 0 Then
            If Not ok Then
                MsgBox("CODIGO MAL DEFINIDO !!!!", MsgBoxStyle.Critical, "POR FAVOR REVISE !!!")
                Exit Sub
            End If
        Else
            For Each dr In dt.Rows
                fa1.SelectedIndex = fa1.Items.IndexOf(Mid(codigo, 1, 3))
                we1.SelectedIndex = we1.Items.IndexOf(Mid(codigo, 4, 3))
                con1.SelectedIndex = con1.Items.IndexOf(Mid(codigo, 7, 3))
                fib1.SelectedIndex = fib1.Items.IndexOf(Mid(codigo, 10, 3))
                dm.SelectedIndex = dm.Items.IndexOf(dr("DM"))
            Next
        End If
        habilita()
    End Sub
    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(fa1.Text) <> "" Then
                we1.Focus()
            End If
        End If
    End Sub
    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(we1.Text) <> "" Then
                con1.Focus()
            End If
        End If
    End Sub
    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(con1.Text) <> "" Then
                fib1.Focus()
            End If
        End If
    End Sub
    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(fib1.Text) <> "" Then
                busca_codigo()
            End If
        End If
    End Sub

    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(dm.Text) <> "" Then
                busca_codigo()
            End If
        End If
    End Sub

    Private Sub graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Graba.Click
        If Trim(Descrip.Text) <> "" Then
            graba_registro()
            limpia_variables()
        Else
            MsgBox("Error en los Datos", MsgBoxStyle.Critical, "Por favor verifique !!!")
        End If
    End Sub

    Private Sub Elimi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Elimi.Click
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        seguro = MsgBox("Seguro de Querer Eliminar   ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina()
            limpia_variables()
        End If
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        fila = fg.RowSel
        seleccion(fila)
    End Sub

    Private Sub R1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        limpia_variables()
    End Sub

    Private Sub habilita()
        fa1.Enabled = False
        we1.Enabled = False
        con1.Enabled = False
        fib1.Enabled = False
        Graba.Visible = True
        Elimi.Visible = True
        Graba.Focus()
    End Sub

    Private Sub Regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpia_variables()
    End Sub

    Private Sub llena_maestro()
        Dim dr As DataRow
        Dim i As Integer
        Dim dt As New DataTable()
        Dim strSQl As String = "SELECT * FROM MAESTRO_TELA ORDER BY ORDEN"
        llena_tablas(dt, strSQl, cnn)
        i = dt.Rows.Count
        fj.Rows.Count = i + 1
        i = 1
        For Each dr In dt.Rows
            fj(i, 1) = CStr(Format(i, "00"))
            fj(i, 2) = dr("FABRIC")
            fj(i, 3) = dr("WEIGHT")
            fj(i, 4) = dr("CONTENID")
            fj(i, 5) = dr("FIBER")
            i = i + 1
        Next
    End Sub
    Private Sub fa1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fa1.SelectedIndexChanged
        busca_descripciones(fb, fa1.Text, fa2.Text, ok)
        llena_descr()
    End Sub

    Private Sub fa1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fa1.KeyPress
        AutoCompletar(fa1, e)
    End Sub
    Private Sub we1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles we1.KeyPress
        AutoCompletar(we1, e)
    End Sub
    Private Sub con1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles con1.KeyPress
        AutoCompletar(con1, e)
    End Sub
    Private Sub fib1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fib1.KeyPress
        AutoCompletar(fib1, e)
    End Sub

    Private Sub we1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles we1.SelectedIndexChanged
        busca_descripciones(wg, we1.Text, we2.Text, ok)
        llena_descr()
    End Sub

    Private Sub con1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles con1.SelectedIndexChanged
        busca_descripciones(ct, con1.Text, con2.Text, ok)
        llena_descr()
    End Sub

    Private Sub fib1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fib1.SelectedIndexChanged
        busca_descripciones(fr, fib1.Text, fib2.Text, ok)
        llena_descr()
    End Sub

    Private Sub llena_descr()
        Descrip.Text = Trim(fa2.Text) + " " + Trim(we2.Text) + " " + Trim(con2.Text) + " " + Trim(fib2.Text)
        cod.Text = Trim(fa1.Text) + Trim(we1.Text) + Trim(con1.Text) + Trim(fib1.Text)
    End Sub

    '=========================================================
    '=        GRABA REGISTRO
    '=========================================================

    Private Sub graba_registro()
        Dim strsql As String
        Dim afectados As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "UPDATE CODIGO_TELA1 SET DESCRIPCION = " & "'" & Descrip.Text & "' ,  DM = '" & dm.Text & "' " & _
                           " WHERE CODIGO  = '" & cod.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            If afectados = 0 Then
                strsql = "INSERT INTO CODIGO_TELA1 (CODIGO,DESCRIPCION,DM) " & _
                         "VALUES ( '" & cod.Text & "','" & Descrip.Text & "','" & dm.Text & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If

            transaccion.Commit()

            MsgBox("Grabación Exitosa !!!!", MsgBoxStyle.Information, "Actualización de Datos")

            setea_grid()
            llena_grid()
        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() & _
                                      " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try

    End Sub

    Private Sub elimina()
        Dim strsql As String
        Dim afectados As Integer

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE FROM CODIGO_TELA1 WHERE CODIGO  = '" & cod.Text & "' "
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()

            setea_grid()
            llena_grid()

        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() & _
                                      " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub

End Class
