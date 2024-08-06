Imports C1.Win.C1FlexGrid

Public Class Consumo_tela_n
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim Z As String = "0000000000"
    Dim ok As Boolean
    Dim CODIGO As String
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Friend WithEvents codigos As System.Windows.Forms.ComboBox
    Friend WithEvents colort As System.Windows.Forms.ComboBox
    Dim lineas As Integer
    Dim te As New DataTable
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Unidad As System.Windows.Forms.TextBox
    Friend WithEvents Sigue As System.Windows.Forms.Button
    Friend WithEvents Colo As System.Windows.Forms.ComboBox
    Friend WithEvents Estilo As System.Windows.Forms.ComboBox
    Friend WithEvents Cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Ct As System.Windows.Forms.Button
    Friend WithEvents Descripcion As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consumo_tela_n))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.codigos = New System.Windows.Forms.ComboBox()
        Me.colort = New System.Windows.Forms.ComboBox()
        Me.Descripcion = New System.Windows.Forms.TextBox()
        Me.Ct = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cliente = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Estilo = New System.Windows.Forms.ComboBox()
        Me.Colo = New System.Windows.Forms.ComboBox()
        Me.Unidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Sigue = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 168)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 21
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1000, 488)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(872, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 54
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para Grabar o Actualizar los Datos de la FPO.")
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(952, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 21
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton para Borrar el Registro Seleccionado.")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(912, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 19
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.codigos)
        Me.GroupBox1.Controls.Add(Me.colort)
        Me.GroupBox1.Controls.Add(Me.Descripcion)
        Me.GroupBox1.Controls.Add(Me.Ct)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Cliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Estilo)
        Me.GroupBox1.Controls.Add(Me.Colo)
        Me.GroupBox1.Controls.Add(Me.Unidad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Sigue)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 152)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'codigos
        '
        Me.codigos.BackColor = System.Drawing.Color.White
        Me.codigos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codigos.ForeColor = System.Drawing.Color.Black
        Me.codigos.Location = New System.Drawing.Point(135, 93)
        Me.codigos.MaxLength = 25
        Me.codigos.Name = "codigos"
        Me.codigos.Size = New System.Drawing.Size(100, 24)
        Me.codigos.TabIndex = 64
        Me.ToolTip1.SetToolTip(Me.codigos, "Color")
        '
        'colort
        '
        Me.colort.BackColor = System.Drawing.Color.White
        Me.colort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colort.ForeColor = System.Drawing.Color.Black
        Me.colort.Location = New System.Drawing.Point(602, 92)
        Me.colort.MaxLength = 25
        Me.colort.Name = "colort"
        Me.colort.Size = New System.Drawing.Size(263, 24)
        Me.colort.TabIndex = 63
        Me.ToolTip1.SetToolTip(Me.colort, "Color")
        '
        'Descripcion
        '
        Me.Descripcion.BackColor = System.Drawing.Color.SkyBlue
        Me.Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Descripcion.Enabled = False
        Me.Descripcion.ForeColor = System.Drawing.Color.Black
        Me.Descripcion.Location = New System.Drawing.Point(277, 94)
        Me.Descripcion.Multiline = True
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Size = New System.Drawing.Size(272, 48)
        Me.Descripcion.TabIndex = 61
        '
        'Ct
        '
        Me.Ct.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Ct.Location = New System.Drawing.Point(240, 104)
        Me.Ct.Name = "Ct"
        Me.Ct.Size = New System.Drawing.Size(32, 16)
        Me.Ct.TabIndex = 4
        Me.Ct.Text = "..."
        Me.Ct.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(952, 16)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(35, 35)
        Me.Button5.TabIndex = 56
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button5, "Presione este Boton para Borrar el Registro Seleccionado.")
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(912, 88)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 35)
        Me.Button4.TabIndex = 55
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button4, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(551, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Color:"
        '
        'Cliente
        '
        Me.Cliente.BackColor = System.Drawing.Color.White
        Me.Cliente.ForeColor = System.Drawing.Color.Black
        Me.Cliente.Location = New System.Drawing.Point(135, 11)
        Me.Cliente.MaxLength = 25
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(232, 21)
        Me.Cliente.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Cliente, "Color")
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Cliente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Estilo
        '
        Me.Estilo.BackColor = System.Drawing.Color.White
        Me.Estilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Estilo.ForeColor = System.Drawing.Color.Black
        Me.Estilo.Location = New System.Drawing.Point(135, 35)
        Me.Estilo.MaxLength = 25
        Me.Estilo.Name = "Estilo"
        Me.Estilo.Size = New System.Drawing.Size(232, 21)
        Me.Estilo.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Estilo, "Color")
        '
        'Colo
        '
        Me.Colo.BackColor = System.Drawing.Color.White
        Me.Colo.ForeColor = System.Drawing.Color.Black
        Me.Colo.Location = New System.Drawing.Point(135, 59)
        Me.Colo.MaxLength = 25
        Me.Colo.Name = "Colo"
        Me.Colo.Size = New System.Drawing.Size(232, 21)
        Me.Colo.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Colo, "Color")
        '
        'Unidad
        '
        Me.Unidad.BackColor = System.Drawing.Color.White
        Me.Unidad.ForeColor = System.Drawing.Color.Black
        Me.Unidad.Location = New System.Drawing.Point(135, 120)
        Me.Unidad.MaxLength = 10
        Me.Unidad.Name = "Unidad"
        Me.Unidad.Size = New System.Drawing.Size(100, 20)
        Me.Unidad.TabIndex = 53
        Me.Unidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.Unidad, "Codigo del Material")
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(16, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 16)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Libras:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(16, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Codigo Tela:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 16)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Color:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(16, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 16)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Estilo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Sigue
        '
        Me.Sigue.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Sigue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Sigue.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sigue.ForeColor = System.Drawing.Color.Black
        Me.Sigue.Image = CType(resources.GetObject("Sigue.Image"), System.Drawing.Image)
        Me.Sigue.Location = New System.Drawing.Point(872, 16)
        Me.Sigue.Name = "Sigue"
        Me.Sigue.Size = New System.Drawing.Size(35, 35)
        Me.Sigue.TabIndex = 3
        Me.Sigue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Sigue, "Presione este Boton para Buscar el Registro Seleccionado.")
        Me.Sigue.UseVisualStyleBackColor = False
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
        'Consumo_tela_n
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1018, 696)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Consumo_tela_n"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consumo de Tela "
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Consumo_Tela__Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Cliente.KeyPress, AddressOf keypressed1
        AddHandler Estilo.KeyPress, AddressOf keypressed2
        AddHandler Colo.KeyPress, AddressOf keypressed3
        AddHandler codigos.KeyPress, AddressOf keypressed4
        AddHandler colort.KeyPress, AddressOf keypressed5
        AddHandler Unidad.KeyPress, AddressOf keypressed6
        llena_clientes(Cliente)
        Cliente.Items.Remove("TODOS")
        Try
            Cliente.SelectedIndex = 0
        Catch
        End Try
        setea_grid()
        limpia_variables()
    End Sub
    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_grid()
        Dim dt As New DataTable()
        Dim dr As DataRow
        setea_grid()
        ok = False
        Dim strSQL As String = "SELECT *,DESCRIPCION FROM CONSUMO_TELA LEFT JOIN CODIGO_TELA ON CONSUMO_TELA.CODIGO = CODIGO_TELA.CODIGO WHERE CLIENTE = '" & Cliente.Text & "' AND ESTILO_CPO = '" & Estilo.Text & "' AND COLOR_CPO = '" & Colo.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("CODIGO")
            fg(lineas, 2) = dr("DESCRIPCION")
            fg(lineas, 3) = dr("COLOR_TELA")
            fg(lineas, 4) = dr("LIBRAS")
            fg(lineas, 0) = fg(lineas, 1) + fg(lineas, 3)
            lineas = lineas + 1
        Next
    End Sub

    Private Sub limpia_variables()
        Cliente.Enabled = True
        Estilo.Enabled = True
        Colo.Enabled = True
        codigos.Enabled = False
        colort.Enabled = False
        Unidad.ReadOnly = True
        Ct.Enabled = False
        Sigue.Visible = True
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = True
        Button4.Visible = False
        Button5.Visible = False
        set_variables()
        setea_grid()
        Estilo.Focus()
    End Sub

    Private Sub set_variables()
        Unidad.Text = ""
    End Sub

    Private Sub habilita()
        Cliente.Enabled = False
        Estilo.Enabled = False
        Colo.Enabled = True
        colort.Enabled = True
        Unidad.ReadOnly = False
    End Sub

    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Cliente.Text) <> "" Then
                Estilo.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Estilo.Text) <> "" Then
                Colo.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Colo.Text) <> "" Then
                Sigue.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(codigos.Text) <> "" Then
                colort.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(colort.Text) <> "" Then
                Unidad.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub keypressed6(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Unidad.Text) <> "" Then
                Try
                    If CDec(Unidad.Text) > 0 Then
                        Button1.Focus()
                    End If
                Catch
                End Try
            End If
        End If
    End Sub 'keypressed


    Private Sub sigue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sigue.Click
        Dim ok As Boolean
        chequea_encabezado(ok)
        If ok Then
            llena_grid()
            habilita_detalle()
            Cliente.Enabled = False
            Estilo.Enabled = False
            Colo.Enabled = False
            Ct.Focus()
        End If
    End Sub

    Private Sub chequea_encabezado(ByRef ok As Boolean)
        ok = True
        If Trim(Cliente.Text) = "" Or Trim(Estilo.Text = "") Or Trim(Colo.Text) = "" Then
            MsgBox("Por favor revise !!", MsgBoxStyle.Critical, "Datos no validos")
            ok = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        limpia_variables()
    End Sub

    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OkOnly, var + " NO VALIDO !!!! ")
    End Sub

    Private Sub busca_detalle(ByRef ok As Boolean)
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String = "SELECT * FROM CONSUMO_TELA LEFT JOIN CODIGO_TELA ON CONSUMO_TELA.CODIGO = CODIGO_TELA.CODIGO WHERE CLIENTE = '" & Cliente.Text & "' AND ESTILO_CPO = '" & Estilo.Text & "' AND COLOR_CPO = '" & Colo.Text & "' AND CONSUMO_TELA.CODIGO = '" & codigos.Text & "' AND COLOR_TELA  = '" & colort.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            codigos.Text = dr("CODIGO")
            Try
                Descripcion.Text = dr("DESCRIPCION")
                colort.Text = dr("COLOR_TELA")
            Catch
            End Try
            Unidad.Text = dr("LIBRAS")
        Next
        If dt.Rows.Count > 0 Then
            Button2.Visible = True
        End If
        Ct.Enabled = False
        colort.Enabled = False
        Unidad.ReadOnly = False
        Button1.Visible = True
        Button5.Visible = True
        Unidad.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ok = True
        revisa_detalle(ok)
        If ok Then
            graba_registros()
            llena_grid()
            limpia_linea()
            habilita_detalle()
        End If
    End Sub

    Private Sub revisa_detalle(ByRef ok As Boolean)
        ok = True
        If codigos.Text = "" Or colort.Text = "" Then
            ok = False
        End If
        Try
            Unidad.Text = CDec(Unidad.Text)
            If Unidad.Text = 0 Then
                ok = False
            End If
        Catch
            ok = False
        End Try
        If Not ok Then
            MsgBox("Antes de Grabar por favor Complete los Datos", MsgBoxStyle.Critical, "Por favor revise !!!")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        Dim strsql As String = "DELETE CONSUMO_TELA WHERE CLIENTE = '" & Cliente.Text & "' AND ESTILO_CPO = '" & Estilo.Text & "' AND COLOR_CPO = '" & Colo.Text & "' AND CODIGO = '" & codigos.Text & "' AND COLOR_TELA = '" & colort.Text & "'"
        seguro = MsgBox("Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_registros(strsql)
            elimina_linea()
        End If
        llena_grid()
        limpia_linea()
        habilita_detalle()
    End Sub

    Private Sub limpia_linea()
        Unidad.Text = ""
        Button2.Visible = False
        Ct.Focus()
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        fila = fg.RowSel
        seleccion(fila)
    End Sub

    Private Sub seleccion(ByVal fil As Integer)
        Dim jj As Boolean
        If fil > 0 And fil < fg.Rows.Count Then
            codigos.Text = fg(fil, 1)
            Descripcion.Text = fg(fil, 2)
            colort.Text = fg(fil, 3)
            busca_detalle(jj)
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

    Private Sub agrega_linea()
        Dim lin As Integer = fg.Rows.Count
        fg.Rows.Count = lin + 1
        llena_lineas(lin)
        fg.Sort(SortFlags.Ascending, 1)
    End Sub

    Private Sub elimina_linea()
        Dim lin As Integer
        busca_linea(lin)
        fg.Rows.Remove(lin)
    End Sub

    Private Sub cambia_linea()
        Dim lin As Integer
        busca_linea(lin)
        llena_lineas(lin)
    End Sub

    Private Sub llena_lineas(ByVal lineas As Integer)
        fg(lineas, 1) = codigos.Text
        fg(lineas, 2) = Descripcion.Text
        fg(lineas, 3) = colort.Text
        fg(lineas, 4) = Unidad.Text
        fg(lineas, 0) = fg(lineas, 1) + fg(lineas, 2)
    End Sub

    Private Sub busca_linea(ByRef linea As Integer)
        Dim buscar As String = Trim(codigos.Text) + Trim(colort.Text)
        linea = fg.FindRow(buscar, 1, 0, False)
        If linea < 0 Then
            linea = 1
        End If
    End Sub

    Private Sub busca_estilo()
        Dim strSQL As String = "SELECT DISTINCT ESTILO FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE CLIENTE = '" & Cliente.Text & "' ORDER BY ESTILO"
        llena_combos(Estilo, strSQL, "ESTILO")
        If Estilo.Items.Count > 0 Then
            Estilo.SelectedIndex = 0
        End If
    End Sub

    Private Sub Cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cliente.SelectedIndexChanged
        Dim strsql As String = "SELECT DISTINCT COMBO_TELAS.CODIGO ,DESCRIPCION FROM COMBO_TELAS LEFT JOIN CODIGO_TELA ON COMBO_TELAS.CODIGO = CODIGO_TELA.CODIGO WHERE CLIENTE = '" & Cliente.Text & "' ORDER BY COMBO_TELAS.CODIGO"
        busca_estilo()
        llena_tablas(te, strsql, cnn)
        llena_combos_d(codigos, te, "CODIGO")
    End Sub

    Private Sub llena_colores()
        Dim strSQL As String = "SELECT DISTINCT COLOR_CPO FROM CONSUMO_TELA WHERE CLIENTE = '" & Cliente.Text & "' AND ESTILO_CPO = '" & Estilo.Text & "' ORDER BY COLOR_CPO"
        llena_combos(Colo, strSQL, "COLOR_CPO")
        If Colo.Items.Count > 0 Then
            Colo.SelectedIndex = 0
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        seguro = MsgBox("Seguro de Querer Eliminar todo el Cliente_Estilo_Color ?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_todo_consumo()
        End If
        limpia_variables()
    End Sub

    Private Sub elimina_todo_consumo()
        Dim strSQL As String
        strSQL = "DELETE CONSUMO_TELA WHERE CLIENTE = '" & Cliente.Text & "' AND ESTILO_CPO = '" & Estilo.Text & "' AND COLOR_CPO = '" & Colo.Text & "'"
        elimina_registros(strSQL)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        habilita_detalle()
    End Sub

    Private Sub habilita_detalle()
        Ct.Enabled = True
        colort.Enabled = True
        Unidad.ReadOnly = False
        codigos.Enabled = True
        Unidad.Text = ""
        Button1.Visible = True
        Button2.Visible = True
        Button4.Visible = True
        Sigue.Visible = False
    End Sub

    Private Sub Estilo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Estilo.SelectedIndexChanged
        llena_colores()
    End Sub

    Private Sub ct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ct.Click
        Dim forma As New Sel_combo_Tela()
        forma.color_T = ""
        forma.codigo_T = ""
        forma.descri = ""
        forma.cliente = Cliente.Text
        forma.ShowDialog()
        If forma.codigo_T <> "" Then
            codigos.SelectedIndex = codigos.Items.IndexOf(forma.codigo_T)
            Descripcion.Text = forma.descri
            colort.SelectedIndex = colort.Items.IndexOf(forma.color_T)
        End If
        Unidad.Focus()
    End Sub

    Private Sub cliente_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cliente.KeyPress
        AutoCompletar(Cliente, e)
    End Sub

    Private Sub estilo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Estilo.KeyPress
        AutoCompletar(Estilo, e)
    End Sub

    Private Sub colo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Colo.KeyPress
        AutoCompletar(Colo, e)
    End Sub

    Private Sub cliente_Lleave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cliente.Leave
        If Cliente.Items.IndexOf(Cliente.Text) = -1 Then
            Cliente.Focus()
        End If
    End Sub

    Private Sub Estilo_Lleave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Estilo.Leave
        If Estilo.Items.IndexOf(Estilo.Text) = -1 Then
            Estilo.Focus()
        End If
    End Sub

    Private Sub Colo_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Colo.Leave
        If Colo.Items.IndexOf(Colo.Text) = -1 Then
            Colo.Focus()
        End If
    End Sub

    ' =================================================================================
    ' =                     RUTINA DE GRABACION
    ' =
    ' =================================================================================
    Private Sub graba_registros()
        Dim afectados As Integer
        Dim strSQL As String
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try

            strSQL = "UPDATE CONSUMO_TELA SET LIBRAS = " & "'" & Unidad.Text & "'" & _
                                 " WHERE CLIENTE = '" & Cliente.Text & "' AND ESTILO_CPO = '" & Estilo.Text & "' AND COLOR_CPO = '" & Colo.Text & "' AND CODIGO = '" & codigos.Text & "' AND COLOR_TELA = '" & colort.Text & "'"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

            If afectados = 0 Then
                strSQL = "INSERT INTO CONSUMO_TELA (CLIENTE,ESTILO_CPO,COLOR_CPO,CODIGO,COLOR_TELA,LIBRAS) " & _
                         "VALUES ( '" & Cliente.Text & "','" & _
                             Estilo.Text & "','" & _
                             Colo.Text & "','" & _
                             codigos.Text & "','" & _
                             colort.Text & "','" & _
                             Unidad.Text & "')"
                comando.CommandText = strSQL
                afectados = comando.ExecuteNonQuery()
            End If

            transaccion.Commit()

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

    ' =================================================================================
    ' =                     RUTINA DE ELIMINACION
    ' =
    ' =================================================================================
    Private Sub elimina_registros(ByVal strsql As String)
        Dim afectados As Integer
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()

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


    Private Sub codigos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles codigos.KeyPress
        AutoCompletar(codigos, e)
    End Sub

    Private Sub colort_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles colort.KeyPress
        AutoCompletar(colort, e)
    End Sub

    Private Sub codigos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles codigos.SelectedIndexChanged
        Dim ok As Boolean
        busca_descripciones(te, codigos.Text, Descripcion.Text, ok)
        llena_color_tela()
    End Sub

    Private Sub llena_color_tela()
        Dim strsql As String = "SELECT COLOR_TELA  FROM COMBO_TELAS WHERE CLIENTE = '" & Cliente.Text & "' AND CODIGO = '" & codigos.Text & "' ORDER BY COLOR_TELA"
        llena_combos(colort, strsql, "COLOR_TELA")
    End Sub
End Class
