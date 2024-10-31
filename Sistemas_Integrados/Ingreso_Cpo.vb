Imports C1.Win.C1FlexGrid

Public Class Ingreso_cpo
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnns As SqlClient.SqlConnection
    Dim cna As New SqlClient.SqlConnection()
    Dim TIPO As String
    Dim KNIT As String
    Dim COLOR As String
    Dim CLIENTE As String
    Dim IFECHA As Date
    Dim CPO As String
    Dim ESTILO As String
    Dim YSIZE As String
    Dim YFIBER As String
    Dim YFINISH As String
    Dim PESO As String
    Dim ANCHO As String
    Dim LIBRAS As Integer
    Dim CUELLOS As Integer
    Dim RFECHA As Date
    Dim STATUS As String
    Dim lineas As Integer
    Dim b As String = "0|0|0|0|0|0|0|0|0|0|0"
    Dim t As String = "XS|S|M|L|XL|XL2|XL3|XL4|XL5|XL6"
    Dim r As String()
    Dim g As String()
    Dim dt As New DataTable()
    Friend WithEvents destino As System.Windows.Forms.TextBox
    Friend WithEvents ta As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents escala As System.Windows.Forms.ComboBox
    Friend WithEvents C1Button1 As C1.Win.C1Input.C1Button
    Friend WithEvents Label3 As Label
    Friend WithEvents C1TextBox1 As C1.Win.C1Input.C1TextBox
    Dim dr As DataRow
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ESTADO As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents G2 As System.Windows.Forms.Button
    Friend WithEvents ct As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cpos As System.Windows.Forms.ComboBox
    Friend WithEvents F_pedido As System.Windows.Forms.Label
    Friend WithEvents clientes As System.Windows.Forms.Label
    Friend WithEvents colores As System.Windows.Forms.Label
    Friend WithEvents estilos As System.Windows.Forms.Label
    Friend WithEvents f_entrega As System.Windows.Forms.Label
    Friend WithEvents G1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingreso_cpo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ct = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.R1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.escala = New System.Windows.Forms.ComboBox()
        Me.ta = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ESTADO = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.G2 = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.G1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cpos = New System.Windows.Forms.ComboBox()
        Me.F_pedido = New System.Windows.Forms.Label()
        Me.clientes = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.colores = New System.Windows.Forms.Label()
        Me.estilos = New System.Windows.Forms.Label()
        Me.f_entrega = New System.Windows.Forms.Label()
        Me.destino = New System.Windows.Forms.TextBox()
        Me.C1TextBox1 = New C1.Win.C1Input.C1TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.C1Button1 = New C1.Win.C1Input.C1Button()
        CType(Me.ct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ct
        '
        Me.ct.ColumnInfo = resources.GetString("ct.ColumnInfo")
        Me.ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ct.Location = New System.Drawing.Point(8, 80)
        Me.ct.Name = "ct"
        Me.ct.Rows.Count = 1
        Me.ct.Rows.DefaultSize = 21
        Me.ct.Rows.Fixed = 0
        Me.ct.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ct.Size = New System.Drawing.Size(728, 32)
        Me.ct.StyleInfo = resources.GetString("ct.StyleInfo")
        Me.ct.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.ct, "Area de Datos.")
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(944, 16)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(35, 35)
        Me.R1.TabIndex = 19
        Me.R1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R1, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R1.UseVisualStyleBackColor = False
        Me.R1.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.SteelBlue
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(480, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "F.Pedido"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(248, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(16, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Estilo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.escala)
        Me.GroupBox1.Controls.Add(Me.ta)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.ESTADO)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ct)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(984, 128)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tallas"
        '
        'escala
        '
        Me.escala.Location = New System.Drawing.Point(742, 91)
        Me.escala.MaxLength = 20
        Me.escala.Name = "escala"
        Me.escala.Size = New System.Drawing.Size(136, 21)
        Me.escala.TabIndex = 61
        Me.escala.Visible = False
        '
        'ta
        '
        Me.ta.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.ta.AllowMergingFixed = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.ta.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.ta.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.ta.BackColor = System.Drawing.Color.White
        Me.ta.ColumnInfo = resources.GetString("ta.ColumnInfo")
        Me.ta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ta.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.ta.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.ta.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.ta.Location = New System.Drawing.Point(8, 19)
        Me.ta.Name = "ta"
        Me.ta.Rows.Count = 2
        Me.ta.Rows.DefaultSize = 19
        Me.ta.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ta.Size = New System.Drawing.Size(827, 46)
        Me.ta.StyleInfo = resources.GetString("ta.StyleInfo")
        Me.ta.TabIndex = 47
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(664, 128)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 16)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "4XL"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ESTADO
        '
        Me.ESTADO.Items.AddRange(New Object() {"A", "C", "X"})
        Me.ESTADO.Location = New System.Drawing.Point(864, 32)
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.Size = New System.Drawing.Size(40, 21)
        Me.ESTADO.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.ESTADO, "Estado <A>lta    <C>errada    <X> = cancelada")
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(848, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Estado:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(8, 680)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(536, 16)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Para Seleccionar una Fila en especial  Presione Double_Click."
        '
        'G2
        '
        Me.G2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.G2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.G2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G2.ForeColor = System.Drawing.Color.Black
        Me.G2.Image = CType(resources.GetObject("G2.Image"), System.Drawing.Image)
        Me.G2.Location = New System.Drawing.Point(952, 80)
        Me.G2.Name = "G2"
        Me.G2.Size = New System.Drawing.Size(35, 35)
        Me.G2.TabIndex = 50
        Me.G2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.G2, "Presione este Boton para Grabar o Actualizar los Datos")
        Me.G2.UseVisualStyleBackColor = False
        Me.G2.Visible = False
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(9, 256)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 21
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(983, 408)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'G1
        '
        Me.G1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.G1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.G1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G1.ForeColor = System.Drawing.Color.Black
        Me.G1.Image = CType(resources.GetObject("G1.Image"), System.Drawing.Image)
        Me.G1.Location = New System.Drawing.Point(904, 16)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(35, 35)
        Me.G1.TabIndex = 61
        Me.G1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.G1, "Chequeo de Datos")
        Me.G1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.SteelBlue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(376, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "F.Entrega"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.SteelBlue
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(160, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(208, 16)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Color"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.C1Button1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.C1TextBox1)
        Me.GroupBox2.Controls.Add(Me.G1)
        Me.GroupBox2.Controls.Add(Me.cpos)
        Me.GroupBox2.Controls.Add(Me.F_pedido)
        Me.GroupBox2.Controls.Add(Me.clientes)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.R1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(984, 64)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        '
        'cpos
        '
        Me.cpos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpos.Location = New System.Drawing.Point(0, 24)
        Me.cpos.Name = "cpos"
        Me.cpos.Size = New System.Drawing.Size(200, 28)
        Me.cpos.TabIndex = 1
        '
        'F_pedido
        '
        Me.F_pedido.BackColor = System.Drawing.Color.White
        Me.F_pedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.F_pedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F_pedido.ForeColor = System.Drawing.Color.Black
        Me.F_pedido.Location = New System.Drawing.Point(480, 24)
        Me.F_pedido.Name = "F_pedido"
        Me.F_pedido.Size = New System.Drawing.Size(120, 26)
        Me.F_pedido.TabIndex = 60
        Me.F_pedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'clientes
        '
        Me.clientes.BackColor = System.Drawing.Color.White
        Me.clientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientes.ForeColor = System.Drawing.Color.Black
        Me.clientes.Location = New System.Drawing.Point(248, 24)
        Me.clientes.Name = "clientes"
        Me.clientes.Size = New System.Drawing.Size(216, 26)
        Me.clientes.TabIndex = 59
        Me.clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.SteelBlue
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(480, 80)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(352, 16)
        Me.Label22.TabIndex = 48
        Me.Label22.Text = "Lugar de Envio"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'colores
        '
        Me.colores.BackColor = System.Drawing.Color.White
        Me.colores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.colores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colores.ForeColor = System.Drawing.Color.Black
        Me.colores.Location = New System.Drawing.Point(160, 96)
        Me.colores.Name = "colores"
        Me.colores.Size = New System.Drawing.Size(208, 20)
        Me.colores.TabIndex = 63
        Me.colores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'estilos
        '
        Me.estilos.BackColor = System.Drawing.Color.White
        Me.estilos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.estilos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estilos.ForeColor = System.Drawing.Color.Black
        Me.estilos.Location = New System.Drawing.Point(16, 96)
        Me.estilos.Name = "estilos"
        Me.estilos.Size = New System.Drawing.Size(136, 20)
        Me.estilos.TabIndex = 61
        Me.estilos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'f_entrega
        '
        Me.f_entrega.BackColor = System.Drawing.Color.White
        Me.f_entrega.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.f_entrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f_entrega.ForeColor = System.Drawing.Color.Black
        Me.f_entrega.Location = New System.Drawing.Point(376, 96)
        Me.f_entrega.Name = "f_entrega"
        Me.f_entrega.Size = New System.Drawing.Size(96, 20)
        Me.f_entrega.TabIndex = 62
        Me.f_entrega.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'destino
        '
        Me.destino.BackColor = System.Drawing.Color.White
        Me.destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.destino.ForeColor = System.Drawing.Color.Black
        Me.destino.Location = New System.Drawing.Point(480, 97)
        Me.destino.Name = "destino"
        Me.destino.Size = New System.Drawing.Size(352, 21)
        Me.destino.TabIndex = 65
        '
        'C1TextBox1
        '
        Me.C1TextBox1.Location = New System.Drawing.Point(652, 29)
        Me.C1TextBox1.Name = "C1TextBox1"
        Me.C1TextBox1.Size = New System.Drawing.Size(100, 18)
        Me.C1TextBox1.TabIndex = 62
        Me.C1TextBox1.Tag = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Fuchsia
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(642, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "MASIVO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'C1Button1
        '
        Me.C1Button1.Location = New System.Drawing.Point(778, 28)
        Me.C1Button1.Name = "C1Button1"
        Me.C1Button1.Size = New System.Drawing.Size(70, 20)
        Me.C1Button1.TabIndex = 64
        Me.C1Button1.Text = "Subir"
        Me.C1Button1.UseVisualStyleBackColor = True
        '
        'Ingreso_cpo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1002, 696)
        Me.Controls.Add(Me.destino)
        Me.Controls.Add(Me.colores)
        Me.Controls.Add(Me.estilos)
        Me.Controls.Add(Me.f_entrega)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.G2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label22)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ingreso_cpo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de  CPO'S"
        Me.ToolTip1.SetToolTip(Me, "Ingreso de CPO'S")
        CType(Me.ct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Button1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub FPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler cpos.KeyPress, AddressOf keypressed1
        llena_combos(escala, "SELECT NOMBRE FROM E_TALLAS", "NOMBRE")
        llena_combos(cpos, "SELECT * FROM CPO ORDER BY CPO", "CPO")
        If cpos.Items.Count > 0 Then
            cpos.SelectedIndex = 1
        End If
        setea_grid()
        limpia_variables()
    End Sub


    Private Sub limpia_variables()
        cpos.Enabled = True
        G1.Visible = True
        R1.Visible = True
        G2.Visible = False
        clientes.Text = ""
        ESTADO.SelectedIndex = 0
        colores.Text = ""
        estilos.Text = ""
        colores.Text = ""
        destino.Text = ""
        r = Split(b, "|")
        setea_grid()
        setea_ct()
        ct.Enabled = False
        destino.Enabled = False
        escala.SelectedIndex = 0
        cpos.Focus()
    End Sub

    Private Sub re_habilita()
        cpos.Enabled = False
        G1.Visible = True
        R1.Visible = True
    End Sub

    Private Sub setea_ct()
        Dim i As Integer
        ct.Clear()
        ct.Rows(0).Height = 25
        ct.Cols.Count = 10
        For i = 0 To 9
            ct.Cols(i).Width = 72
            ct.Cols(i).DataType = GetType(Decimal)
            ct.Cols(i).Format = "####0.00"
            ct.Cols(i).TextAlign = TextAlignEnum.RightCenter
            ct(0, i) = 0
            ct.KeyActionEnter = KeyActionEnum.MoveAcross
            ct.KeyActionTab = KeyActionEnum.MoveAcross
        Next
    End Sub

    Private Sub setea_grid()
        Dim index As Integer
        fg.Rows.Count = 1
        fg.Cols.Count = 18
        fg.Cols(0).Width = 5
        fg.Cols(1).Width = 0
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Name = "CPO"
        fg.Cols(2).Name = "ESTILO"
        fg.Cols(3).Name = "COLOR"
        fg.Cols(14).Name = "TOT."
        fg.Cols(15).Name = "ST"
        fg.Cols(16).Name = "F.ENTREGA"
        fg.Cols(17).Name = "LUGAR DE ENVIO"
        For index = 2 To fg.Cols.Count - 1
            fg.Cols(index).Width = 175
            fg(0, index) = fg.Cols(index).Name
            If index > 3 And index < 15 Then
                fg.Cols(index).DataType = GetType(Integer)
                fg.Cols(index).Format = "######0"
                fg.Cols(index).Width = 55
                fg.Cols(index).TextAlign = TextAlignEnum.RightCenter
                fg.Cols(index).TextAlignFixed = TextAlignEnum.RightCenter
            End If
        Next
        fg.Cols(2).Width = 115
        fg.Cols(15).Width = 40
        fg.Cols(15).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(15).TextAlignFixed = TextAlignEnum.CenterCenter
        talla_Grid(fg, 4, True)
    End Sub

    Private Sub llena_grid()
        Dim adulto As Boolean = True
        Dim dt As New DataTable()
        Dim dr As DataRow
        ok = False
        Dim strSQL As String = "SELECT * FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE CPO_D.CPO = '" & cpos.Text & "'"
        llena_tablas(dt, strSQL, cna)
        If fg.Rows.Count > 0 Then
            fg.Rows.Count = dt.Rows.Count + 1
            lineas = 1
            For Each dr In dt.Rows
                clientes.Text = dr("CLIENTE")
                fg(lineas, 0) = Trim(dr("ESTILO")) + Trim(dr("COLOR"))
                fg(lineas, 1) = dr("CPO")
                fg(lineas, 2) = dr("ESTILO")
                fg(lineas, 3) = dr("COLOR")
                fg(lineas, 4) = dr("XS")
                fg(lineas, 5) = dr("S")
                fg(lineas, 6) = dr("M")
                fg(lineas, 7) = dr("L")
                fg(lineas, 8) = dr("XL")
                fg(lineas, 9) = dr("XL2")
                fg(lineas, 10) = dr("XL3")
                fg(lineas, 11) = dr("XL4")
                fg(lineas, 12) = dr("XL5")
                fg(lineas, 13) = dr("XL6")
                fg(lineas, 14) = dr("TOTAL")
                fg(lineas, 15) = dr("ESTADO")
                fg(lineas, 16) = dr("F_ENTREGA")
                fg(lineas, 17) = dr("DESTINO")
                If dr("ESCALA") <> "00" Then
                    adulto = False
                End If
                lineas = lineas + 1
            Next
            seleccion(1)
        End If
        talla_Grid(fg, 4, adulto)
    End Sub


    Private Sub busca_cpos()
        dt = New DataTable()
        Dim strSQL As String = "SELECT * FROM CPO WHERE CPO =  '" & cpos.Text & "'"
        llena_tablas(dt, strSQL, cna)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            clientes.Text = dr("CLIENTE")
            F_pedido.Text = dr("F_PEDIDO")
            llena_grid()
            If fg.Rows.Count > 0 Then
                seleccion(1)
            End If
            cpos.Enabled = False
            destino.Enabled = True
            G1.Visible = False
        Else
            MsgBox("CPO NO EXISTE !!!!!", MsgBoxStyle.Critical, "Por favor revise !!!!!")
            cpos.Focus()
        End If
    End Sub

    Private Sub busca_detalle()
        Dim dr As DataRow
        dt = New DataTable()
        Dim strSQL As String = "SELECT * FROM CPO_D WHERE CPO =  '" & cpos.Text & "' AND ESTILO = '" & estilos.Text & "' AND COLOR = '" & colores.Text & "'"
        llena_tablas(dt, strSQL, cna)
        For Each dr In dt.Rows
            estilos.Text = dr("ESTILO")
            ta(1, 1) = dr("XS")
            ta(1, 2) = dr("S")
            ta(1, 3) = dr("M")
            ta(1, 4) = dr("L")
            ta(1, 5) = dr("XL")
            ta(1, 6) = dr("XL2")
            ta(1, 7) = dr("XL3")
            ta(1, 8) = dr("XL4")
            ta(1, 9) = dr("XL5")
            ta(1, 10) = dr("XL6")
            ta(1, 11) = dr("TOTAL")
            '   escala.SelectedIndex = dr("ESCALA")
            ESTADO.SelectedIndex = ESTADO.Items.IndexOf(dr("ESTADO"))
            f_entrega.Text = dr("F_ENTREGA")
            destino.Text = dr("DESTINO")
        Next
        habilita1()
    End Sub

    Private Sub llena_costos()
        Dim dr As DataRow
        dt = New DataTable()
        setea_ct()
        Dim strSQL As String = "SELECT * FROM CPO_COSTO WHERE CPO =  '" & cpos.Text & "' AND ESTILO = '" & estilos.Text & "' AND COLOR = '" & colores.Text & "'"
        llena_tablas(dt, strSQL, cna)
        For Each dr In dt.Rows
            ct(0, 0) = dr("C1")
            ct(0, 1) = dr("C2")
            ct(0, 2) = dr("C3")
            ct(0, 3) = dr("C4")
            ct(0, 4) = dr("C5")
            ct(0, 5) = dr("C6")
            ct(0, 6) = dr("C7")
            ct(0, 7) = dr("C8")
            ct(0, 8) = dr("C9")
            ct(0, 9) = dr("C0")
        Next
    End Sub


    Private Sub habilita1()
        G2.Visible = True
        ESTADO.Enabled = True
        ct.Enabled = True
        r = Split(b, "|")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        limpia_variables()
    End Sub

    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OkOnly, var + " NO VALIDO !!!! ")
    End Sub

    Private Sub revisa_cpos(ByRef ok As Boolean)
        Dim cor As New DataTable
        Dim strsql As String = "SELECT * FROM CORTES WHERE CPO = '" & cpos.Text & "'"
        ok = True
        llena_tablas(cor, strsql, cnns)
        If cor.Rows.Count > 0 Then
            ok = False
        End If
    End Sub

    Private Sub seleccion(ByVal fil As Integer)
        If fil > 0 And fil < fg.Rows.Count Then
            estilos.Text = fg(fil, 2)
            colores.Text = Trim(fg(fil, 3))
            busca_detalle()
            llena_costos()
        End If
    End Sub

    Private Sub fg_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ct.KeyDown
        If e.KeyCode = Keys.Up Then
            seleccion(fg.Row - 1)
        End If

        If e.KeyCode = Keys.Down Then
            seleccion(fg.Row + 1)
        End If
    End Sub


    '================================== HANDLERS ================================

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cpos.Text) <> "" Then
                busca_cpos()
            End If
        End If
    End Sub 'keypressed


    Private Sub VV(ByVal dato As String, ByRef bien As Boolean)
        Dim NUMERO As Integer
        bien = False
        Try
            bien = True
            NUMERO = CInt(dato)
            TOTAL(bien)
        Catch
            bien = False
        End Try
    End Sub

    Private Sub co(ByVal dato As String, ByVal bien As Boolean)
        Dim num As Decimal
        bien = True
        Try
            num = CDec(dato)
            bien = True
        Catch
            bien = False
        End Try
    End Sub


    Private Sub TOTAL(ByRef SI As Boolean)
        Try
            ta(1, 11) = ta(1, 1) + ta(1, 2) + ta(1, 3) + ta(1, 4) + ta(1, 5) + ta(1, 6) + ta(1, 7) + ta(1, 8) + ta(1, 9) + ta(1, 10)
        Catch
            MsgBox("Por favor revise las tallas", MsgBoxStyle.OkOnly, "Existen valores no Validos !!!! ")
            SI = False
        End Try
    End Sub


    Private Sub G2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G2.Click
        graba_registro()
        G1.Visible = False
        busca_cpos()
    End Sub

    Private Sub llena_lineas(ByVal lineas As Integer)
        Try
            fg(lineas, 0) = Trim(estilos.Text) + Trim(colores.Text)
            fg(lineas, 1) = cpos.Text
            fg(lineas, 2) = estilos.Text
            fg(lineas, 3) = colores.Text
            fg(lineas, 4) = ta(1, 1)
            fg(lineas, 5) = ta(1, 2)
            fg(lineas, 6) = ta(1, 3)
            fg(lineas, 7) = ta(1, 4)
            fg(lineas, 8) = ta(1, 5)
            fg(lineas, 9) = ta(1, 6)
            fg(lineas, 10) = ta(1, 7)
            fg(lineas, 11) = ta(1, 8)
            fg(lineas, 12) = ta(1, 9)
            fg(lineas, 13) = ta(1, 10)
            fg(lineas, 14) = ta(1, 11)
            fg(lineas, 16) = f_entrega.Text
            fg(lineas, 17) = destino.Text
        Catch
        End Try
    End Sub

    Private Sub ct_ValidateEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.ValidateEditEventArgs) Handles ct.ValidateEdit
        ' validate amounts
        If ct.Cols(e.Col).DataType Is GetType(Decimal) Then
            Try
                Dim dec As Decimal = Decimal.Parse(ct.Editor.Text())
            Catch
                MessageBox.Show("Por favor Ingrese un valor numerico!!!")
                e.Cancel = True
            End Try
        End If
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        fila = fg.RowSel
        seleccion(fila)
    End Sub

    Private Sub verifica_ordenes(ByRef ok As Boolean)
        Dim dt As New DataTable()
        Dim strsql As String = "SELECT * FROM CORTES WHERE CPO = '" & cpos.Text & "' AND ESTILO = '" & estilos.Text & "' AND COLOR = '" & colores.Text & "' AND EXPORTADO = 'N'"
        verifica_exportado()
        llena_tablas(dt, strsql, cnns)
        If dt.Rows.Count > 0 Then
            ok = False
        Else
            ok = True
        End If
    End Sub
    Private Sub verifica_exportado()
        Dim cortes As String = ""
        Dim dr As DataRow
        Dim dt As New DataTable()
        Dim strsql As String = "SELECT (SELECT TOP 1 EMBARQUE FROM PACKING_D WHERE PACKING_D.CORTE = CORTES.CORTE AND LEFT(EMBARQUE,3) <> 'JTS') AS EMBARQUE ,CORTE FROM CORTES WHERE CPO = '" & cpos.Text & "' AND ESTILO = '" & estilos.Text & "' AND COLOR = '" & colores.Text & "' AND EXPORTADO = 'N'"
        llena_tablas(dt, strsql, cnns)
        For Each dr In dt.Rows
            If IsDBNull(dr("EMBARQUE")) Then
            Else
                cortes = cortes + "'" & dr("CORTE") & "',"
            End If

        Next
        If cortes.Length > 0 Then
            cortes = Mid(cortes, 1, cortes.Length - 1)
            actualiza_cortes(cortes)
        End If
    End Sub

    Private Sub ESTADO_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ESTADO.Leave
        Dim ok As Boolean
        If ESTADO.SelectedIndex > 0 Then
            verifica_ordenes(ok)
            If Not ok Then
                MsgBox("No puede cerrar el Color en la Cpo.  Aun existen cortes sin exportación ", MsgBoxStyle.Critical, "Por favor Revise !!!!")
                ESTADO.SelectedIndex = 0
            End If
        End If
    End Sub

    ' =================================================================================
    ' =                            ACTUALIZA TABLAS
    ' =================================================================================

    Private Sub graba_registro()
        Dim strsql As String
        Dim afectados As Integer

        cna.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cna.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cna.CreateCommand()
        comando.Transaction = transaccion

        Try
            ' ================ DETALLE ====================
            strsql = "UPDATE CPO_D SET ESTADO = " & "'" & ESTADO.Text & "', DESTINO =  '" & destino.Text & "' " &
                     "WHERE CPO = '" & cpos.Text & "' AND ESTILO = '" & estilos.Text & "' AND COLOR = '" & colores.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            ' ============================== ACTUALIZA COSTOS =================================
            strsql = "UPDATE CPO_COSTO SET C1 = " & "'" & ct(0, 0) & "'" &
                                 " , C2 = " & "'" & ct(0, 1) & "'" &
                                 " , C3 = " & "'" & ct(0, 2) & "'" &
                                 " , C4 = " & "'" & ct(0, 3) & "'" &
                                 " , C5 = " & "'" & ct(0, 4) & "'" &
                                 " , C6 = " & "'" & ct(0, 5) & "'" &
                                 " , C7 = " & "'" & ct(0, 6) & "'" &
                                 " , C8 = " & "'" & ct(0, 7) & "'" &
                                 " , C9 = " & "'" & ct(0, 8) & "'" &
                                 " , C0 = " & "'" & ct(0, 9) & "' WHERE CPO = '" & cpos.Text & "' AND ESTILO = '" & estilos.Text & "' AND COLOR = '" & colores.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()
            If afectados = 0 Then
                strsql = "INSERT INTO CPO_COSTO (CPO,ESTILO,COLOR,C1,C2,C3,C4,C5,C6,C7,C8,C9,C0) " &
                                        "VALUES ( '" & cpos.Text & "','" &
                                           estilos.Text & "','" &
                                           colores.Text & "','" &
                                           ct(0, 0) & "','" &
                                           ct(0, 1) & "','" &
                                           ct(0, 2) & "','" &
                                           ct(0, 3) & "','" &
                                           ct(0, 4) & "','" &
                                           ct(0, 5) & "','" &
                                           ct(0, 6) & "','" &
                                           ct(0, 7) & "','" &
                                           ct(0, 8) & "','" &
                                          ct(0, 9) & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If
            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() &
                                      " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cna.Close()
        End Try
    End Sub

    Private Sub actualiza_cortes(ByVal cortes As String)
        Dim strsql As String
        Dim afectados As Integer

        cna.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cna.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cna.CreateCommand()
        comando.Transaction = transaccion

        Try
            ' ================ DETALLE ====================
            strsql = "UPDATE CORTES SET EXPORTADO = 'S' WHERE CORTE IN (" & cortes & ")"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()
            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() &
                                      " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cna.Close()
        End Try
    End Sub

    Private Sub G1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G1.Click
        busca_cpos()
    End Sub

    Private Sub cpos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cpos.KeyPress
        AutoCompletar(cpos, e)
    End Sub

    Private Sub escala_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles escala.SelectedIndexChanged
        talla_setea(ta, escala.SelectedIndex)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub C1TextBox1_TextChanged(sender As Object, e As EventArgs) Handles C1TextBox1.TextChanged

    End Sub

    Private Sub C1Button1_Click(sender As Object, e As EventArgs) Handles C1Button1.Click

    End Sub
End Class
