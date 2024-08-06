Imports C1.Win.C1FlexGrid

Public Class Ingreso_Cpo_N2
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnns As SqlClient.SqlConnection
    Dim cna As New SqlClient.SqlConnection()
    Dim TIPO As String
    Dim lineas As Integer
    Dim b As String = "0|0|0|0|0|0|0|0|0|0|0"
    Dim t As String = "XS|S|M|L|XL|XL2|XL3|XL4|XL5|XL6"
    Dim r As String()
    Dim g As String()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Dim cp As New DataTable()
    Friend WithEvents vendedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents comision As System.Windows.Forms.TextBox
    Friend WithEvents escala As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents ta As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents maximo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents minimo As System.Windows.Forms.TextBox
    Dim usuario As String
    Const dateFormatGt As String = "dd/MM/yyyy"


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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents F_PEDIDO As System.Windows.Forms.DateTimePicker
    Friend WithEvents F_ENTREGA As System.Windows.Forms.DateTimePicker
    Friend WithEvents COLORES As System.Windows.Forms.ComboBox
    Friend WithEvents CPOS As System.Windows.Forms.TextBox
    Friend WithEvents CLIENTES As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents G1 As System.Windows.Forms.Button
    Friend WithEvents E1 As System.Windows.Forms.Button
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents E2 As System.Windows.Forms.Button
    Friend WithEvents R2 As System.Windows.Forms.Button
    Friend WithEvents G2 As System.Windows.Forms.Button
    Friend WithEvents Estilos As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ct As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents destino As System.Windows.Forms.TextBox
    Friend WithEvents tp As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingreso_Cpo_N2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ct = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.G1 = New System.Windows.Forms.Button()
        Me.E1 = New System.Windows.Forms.Button()
        Me.R1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CPOS = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ta = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CLIENTES = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.F_PEDIDO = New System.Windows.Forms.DateTimePicker()
        Me.F_ENTREGA = New System.Windows.Forms.DateTimePicker()
        Me.COLORES = New System.Windows.Forms.ComboBox()
        Me.E2 = New System.Windows.Forms.Button()
        Me.R2 = New System.Windows.Forms.Button()
        Me.G2 = New System.Windows.Forms.Button()
        Me.Estilos = New System.Windows.Forms.ComboBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.destino = New System.Windows.Forms.TextBox()
        Me.vendedor = New System.Windows.Forms.ComboBox()
        Me.comision = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tp = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.escala = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.maximo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.minimo = New System.Windows.Forms.TextBox()
        CType(Me.ct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ct
        '
        Me.ct.ColumnInfo = resources.GetString("ct.ColumnInfo")
        Me.ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ct.Location = New System.Drawing.Point(8, 91)
        Me.ct.Name = "ct"
        Me.ct.Rows.Count = 1
        Me.ct.Rows.DefaultSize = 21
        Me.ct.Rows.Fixed = 0
        Me.ct.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ct.Size = New System.Drawing.Size(728, 32)
        Me.ct.StyleInfo = resources.GetString("ct.StyleInfo")
        Me.ct.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.ct, "Area de Datos.")
        '
        'G1
        '
        Me.G1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.G1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.G1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G1.ForeColor = System.Drawing.Color.Black
        Me.G1.Image = CType(resources.GetObject("G1.Image"), System.Drawing.Image)
        Me.G1.Location = New System.Drawing.Point(840, 16)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(35, 35)
        Me.G1.TabIndex = 20
        Me.G1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.G1, "Presione este Boton para Grabar o Actualizar los Datos")
        Me.G1.UseVisualStyleBackColor = False
        Me.G1.Visible = False
        '
        'E1
        '
        Me.E1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.E1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.E1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.E1.ForeColor = System.Drawing.Color.Black
        Me.E1.Image = CType(resources.GetObject("E1.Image"), System.Drawing.Image)
        Me.E1.Location = New System.Drawing.Point(936, 16)
        Me.E1.Name = "E1"
        Me.E1.Size = New System.Drawing.Size(35, 35)
        Me.E1.TabIndex = 21
        Me.E1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.E1, "Presione este Boton para Borrar el Registro Seleccionado.")
        Me.E1.UseVisualStyleBackColor = False
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.R1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.ForeColor = System.Drawing.Color.Black
        Me.R1.Image = CType(resources.GetObject("R1.Image"), System.Drawing.Image)
        Me.R1.Location = New System.Drawing.Point(888, 16)
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
        Me.Label9.Location = New System.Drawing.Point(372, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "F.Pedido"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CPOS
        '
        Me.CPOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPOS.Location = New System.Drawing.Point(16, 32)
        Me.CPOS.MaxLength = 20
        Me.CPOS.Name = "CPOS"
        Me.CPOS.Size = New System.Drawing.Size(160, 24)
        Me.CPOS.TabIndex = 1
        Me.CPOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.CPOS, "Numero de CPO")
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(190, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 16)
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
        Me.GroupBox1.Controls.Add(Me.ta)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.ct)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(984, 143)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tallas"
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
        Me.ta.Location = New System.Drawing.Point(6, 23)
        Me.ta.Name = "ta"
        Me.ta.Rows.Count = 2
        Me.ta.Rows.DefaultSize = 19
        Me.ta.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ta.Size = New System.Drawing.Size(827, 46)
        Me.ta.StyleInfo = resources.GetString("ta.StyleInfo")
        Me.ta.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(8, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(168, 16)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "Costo Unitario por Talla"
        '
        'CLIENTES
        '
        Me.CLIENTES.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLIENTES.Location = New System.Drawing.Point(190, 24)
        Me.CLIENTES.MaxLength = 20
        Me.CLIENTES.Name = "CLIENTES"
        Me.CLIENTES.Size = New System.Drawing.Size(168, 26)
        Me.CLIENTES.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.CLIENTES, "Cliente")
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
        'F_PEDIDO
        '
        Me.F_PEDIDO.CustomFormat = "dd/MM/yyyy"
        Me.F_PEDIDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F_PEDIDO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.F_PEDIDO.Location = New System.Drawing.Point(372, 24)
        Me.F_PEDIDO.Name = "F_PEDIDO"
        Me.F_PEDIDO.Size = New System.Drawing.Size(120, 24)
        Me.F_PEDIDO.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.F_PEDIDO, "Fecha de Pedido")
        '
        'F_ENTREGA
        '
        Me.F_ENTREGA.CustomFormat = "dd/MM/yyyy"
        Me.F_ENTREGA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.F_ENTREGA.Location = New System.Drawing.Point(376, 96)
        Me.F_ENTREGA.Name = "F_ENTREGA"
        Me.F_ENTREGA.Size = New System.Drawing.Size(96, 20)
        Me.F_ENTREGA.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.F_ENTREGA, "Fecha de Entrega")
        '
        'COLORES
        '
        Me.COLORES.Location = New System.Drawing.Point(160, 96)
        Me.COLORES.MaxLength = 20
        Me.COLORES.Name = "COLORES"
        Me.COLORES.Size = New System.Drawing.Size(208, 21)
        Me.COLORES.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.COLORES, "Cliente")
        '
        'E2
        '
        Me.E2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.E2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.E2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.E2.ForeColor = System.Drawing.Color.Black
        Me.E2.Image = CType(resources.GetObject("E2.Image"), System.Drawing.Image)
        Me.E2.Location = New System.Drawing.Point(944, 80)
        Me.E2.Name = "E2"
        Me.E2.Size = New System.Drawing.Size(35, 35)
        Me.E2.TabIndex = 51
        Me.E2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.E2, "Presione este Boton para Borrar el Registro Seleccionado.")
        Me.E2.UseVisualStyleBackColor = False
        '
        'R2
        '
        Me.R2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.R2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.R2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R2.ForeColor = System.Drawing.Color.Black
        Me.R2.Image = CType(resources.GetObject("R2.Image"), System.Drawing.Image)
        Me.R2.Location = New System.Drawing.Point(896, 80)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(35, 35)
        Me.R2.TabIndex = 49
        Me.R2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.R2, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.R2.UseVisualStyleBackColor = False
        Me.R2.Visible = False
        '
        'G2
        '
        Me.G2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.G2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.G2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G2.ForeColor = System.Drawing.Color.Black
        Me.G2.Image = CType(resources.GetObject("G2.Image"), System.Drawing.Image)
        Me.G2.Location = New System.Drawing.Point(848, 80)
        Me.G2.Name = "G2"
        Me.G2.Size = New System.Drawing.Size(35, 35)
        Me.G2.TabIndex = 50
        Me.G2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.G2, "Presione este Boton para Grabar o Actualizar los Datos")
        Me.G2.UseVisualStyleBackColor = False
        Me.G2.Visible = False
        '
        'Estilos
        '
        Me.Estilos.Location = New System.Drawing.Point(16, 96)
        Me.Estilos.MaxLength = 20
        Me.Estilos.Name = "Estilos"
        Me.Estilos.Size = New System.Drawing.Size(136, 21)
        Me.Estilos.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Estilos, "Cliente")
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(9, 313)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 21
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(983, 351)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'destino
        '
        Me.destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.destino.Location = New System.Drawing.Point(480, 96)
        Me.destino.MaxLength = 30
        Me.destino.Name = "destino"
        Me.destino.Size = New System.Drawing.Size(352, 20)
        Me.destino.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.destino, "Numero de CPO")
        '
        'vendedor
        '
        Me.vendedor.Location = New System.Drawing.Point(160, 140)
        Me.vendedor.MaxLength = 20
        Me.vendedor.Name = "vendedor"
        Me.vendedor.Size = New System.Drawing.Size(208, 21)
        Me.vendedor.TabIndex = 9
        '
        'comision
        '
        Me.comision.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comision.Location = New System.Drawing.Point(376, 139)
        Me.comision.MaxLength = 20
        Me.comision.Name = "comision"
        Me.comision.Size = New System.Drawing.Size(96, 24)
        Me.comision.TabIndex = 10
        Me.comision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.F_PEDIDO)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.E1)
        Me.GroupBox2.Controls.Add(Me.R1)
        Me.GroupBox2.Controls.Add(Me.G1)
        Me.GroupBox2.Controls.Add(Me.CLIENTES)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(984, 64)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
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
        'tp
        '
        Me.tp.BackColor = System.Drawing.Color.White
        Me.tp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tp.ForeColor = System.Drawing.Color.Black
        Me.tp.Location = New System.Drawing.Point(856, 664)
        Me.tp.Name = "tp"
        Me.tp.Size = New System.Drawing.Size(104, 32)
        Me.tp.TabIndex = 54
        Me.tp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(728, 664)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(128, 32)
        Me.Label23.TabIndex = 55
        Me.Label23.Text = "Total Prendas:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(160, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 16)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Vendedor"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.SteelBlue
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(376, 123)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(96, 16)
        Me.Label24.TabIndex = 58
        Me.Label24.Text = "% Comisión"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'escala
        '
        Me.escala.Location = New System.Drawing.Point(16, 140)
        Me.escala.MaxLength = 20
        Me.escala.Name = "escala"
        Me.escala.Size = New System.Drawing.Size(136, 21)
        Me.escala.TabIndex = 59
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.SteelBlue
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(16, 124)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(136, 16)
        Me.Label25.TabIndex = 60
        Me.Label25.Text = "Escala"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(582, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "% Máximo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'maximo
        '
        Me.maximo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maximo.Location = New System.Drawing.Point(582, 140)
        Me.maximo.MaxLength = 20
        Me.maximo.Name = "maximo"
        Me.maximo.Size = New System.Drawing.Size(96, 24)
        Me.maximo.TabIndex = 12
        Me.maximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(480, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "% Minimo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minimo
        '
        Me.minimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimo.Location = New System.Drawing.Point(480, 140)
        Me.minimo.MaxLength = 20
        Me.minimo.Name = "minimo"
        Me.minimo.Size = New System.Drawing.Size(96, 24)
        Me.minimo.TabIndex = 11
        Me.minimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Ingreso_Cpo_N2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1002, 703)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.maximo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.minimo)
        Me.Controls.Add(Me.escala)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.comision)
        Me.Controls.Add(Me.vendedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.tp)
        Me.Controls.Add(Me.destino)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Estilos)
        Me.Controls.Add(Me.E2)
        Me.Controls.Add(Me.R2)
        Me.Controls.Add(Me.G2)
        Me.Controls.Add(Me.COLORES)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CPOS)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.F_ENTREGA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label22)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ingreso_Cpo_N2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verificación de CPOs"
        Me.ToolTip1.SetToolTip(Me, "Verificación de CPOs")
        CType(Me.ct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub FPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler CPOS.KeyPress, AddressOf keypressed1
        AddHandler CLIENTES.KeyPress, AddressOf keypressed2
        AddHandler F_PEDIDO.KeyPress, AddressOf keypressed3
        AddHandler F_ENTREGA.KeyPress, AddressOf keypressed4
        AddHandler Estilos.KeyPress, AddressOf keypressed6
        AddHandler COLORES.KeyPress, AddressOf keypressed7
        AddHandler vendedor.KeyPress, AddressOf keypressed8a
        AddHandler comision.KeyPress, AddressOf keypressed8b
        AddHandler minimo.KeyPress, AddressOf keypressed8c
        AddHandler maximo.KeyPress, AddressOf keypressed8d
        AddHandler escala.KeyPress, AddressOf keypressed9
        AddHandler destino.KeyPress, AddressOf keypressed18
        Dim obj As New empresas()
        usuario = obj.usuario
        llena_tablas(cp, "SELECT * FROM CPO", cna)
        llena_combos(escala, "SELECT NOMBRE FROM E_TALLAS", "NOMBRE")
        'llena_clientes_cpo(CLIENTES)
        llena_combos(vendedor, "SELECT VENDEDOR FROM VENDEDORES WHERE ACTIVO = 'S'", "VENDEDOR")
        setea_grid()
        limpia_variables()
    End Sub

    Private Sub limpia_ta()
        Dim i As Integer
        For i = 1 To 11
            ta(1, i) = 0
        Next
    End Sub
    Private Sub limpia_variables()
        limpia_ta()
        CPOS.Enabled = True
        CPOS.ReadOnly = False
        CLIENTES.Enabled = False
        F_PEDIDO.Enabled = False
        F_ENTREGA.Enabled = False
        vendedor.Enabled = False
        comision.Enabled = False
        Estilos.Enabled = False
        COLORES.Enabled = False
        destino.Enabled = False
        escala.Enabled = False
        minimo.Enabled = False
        maximo.Enabled = False
        ta.Enabled = False
        G1.Visible = False
        E1.Visible = False
        R1.Visible = True
        G2.Visible = False
        R2.Visible = False
        E2.Visible = False
        destino.Text = ""
        comision.Text = "0.00"
        minimo.Text = "0"
        maximo.Text = "0"
        tp.Text = "0"
        r = Split(b, "|")
        setea_grid()
        setea_ct()
        ct.Enabled = False
        llena_clientes_cpo(CLIENTES)
        CPOS.Focus()
    End Sub

    Private Sub re_habilita()
        CPOS.Enabled = False
        CLIENTES.Enabled = True
        F_PEDIDO.Enabled = True
        E1.Visible = True
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
        fg.Clear()
        fg.Rows.Count = 1
        fg.Cols.Count = 18
        fg.Cols(0).Width = 5
        fg.Cols(1).Width = 0
        fg.Rows(0).Height = 30
        Dim c As Column = fg.Cols(1)
        fg.Cols(1).Name = "CPO"
        fg.Cols(2).Name = "ESTILO"
        fg.Cols(3).Name = "COLOR"
        fg.Cols(4).Name = "XS"
        fg.Cols(5).Name = "S"
        fg.Cols(6).Name = "M"
        fg.Cols(7).Name = "L"
        fg.Cols(8).Name = "XL"
        fg.Cols(9).Name = "2XL"
        fg.Cols(10).Name = "3XL"
        fg.Cols(11).Name = "4XL"
        fg.Cols(12).Name = "5XL"
        fg.Cols(13).Name = "6XL"
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
    End Sub

    Private Sub llena_grid()
        Dim dt As New DataTable()
        Dim dr As DataRow
        ok = False
        Dim strSQL As String = "SELECT CPO_D2.*, CLIENTE FROM CPO_D2  LEFT JOIN CPO_2 ON CPO_D2.CPO = CPO_2.CPO WHERE CPO_D2.CPO ='" & CPOS.Text & "'"
        llena_tablas(dt, strSQL, cna)
        fg.Rows.Count = dt.Rows.Count + 1
        lineas = 1
        For Each dr In dt.Rows
            CLIENTES.SelectedIndex = CLIENTES.Items.IndexOf(dr("CLIENTE"))
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
            fg(lineas, 16) = dr("F_ENTREGA")
            fg(lineas, 17) = dr("DESTINO")
            lineas = lineas + 1
        Next
        sub_total()
    End Sub
    Private Sub llena_estilos()
        Estilos.Items.Clear()
        Dim strSQL As String = "SELECT DISTINCT ESTILO FROM CLI_EST_COL WHERE CLIENTE =  '" & CLIENTES.Text & "' AND ESTADO = 'A' ORDER BY ESTILO"
        llena_combos(Estilos, strSQL, "ESTILO")
        If Estilos.Items.Count > 0 Then
            Estilos.SelectedIndex = 0
        End If
    End Sub

    Private Sub llena_colores()
        COLORES.Items.Clear()
        Dim strSQL As String = "SELECT DISTINCT COLOR FROM CLI_EST_COL WHERE CLIENTE =  '" & CLIENTES.Text & "' AND ESTILO = '" & Estilos.Text & "' AND ESTADO = 'A' ORDER BY COLOR"
        llena_combos(COLORES, strSQL, "COLOR")
        If COLORES.Items.Count > 0 Then
            COLORES.SelectedIndex = 0
        End If
    End Sub

    Private Sub busca_cpos()
        dt = New DataTable()
        Dim strSQL As String = "SELECT * FROM CPO_2 WHERE CPO =  '" & CPOS.Text & "'"
        llena_tablas(dt, strSQL, cna)
        If dt.Rows.Count > 0 Then
            dr = dt.Rows(0)
            CLIENTES.SelectedIndex = CLIENTES.Items.IndexOf(dr("CLIENTE"))
            F_PEDIDO.Text = dr("F_PEDIDO")
            llena_grid()
            E1.Visible = True
            habilita()
        Else
            re_habilita()
            CLIENTES.Focus()
        End If
    End Sub

    Private Sub busca_detalle()
        limpia_ta()
        Dim dr As DataRow
        dt = New DataTable()
        Dim strSQL As String = "SELECT * FROM CPO_D2 LEFT JOIN CPO_2 ON CPO_D2.CPO = CPO_2.CPO WHERE CPO_D2.CPO =  '" & CPOS.Text & "' AND ESTILO = '" & Estilos.Text & "' AND COLOR = '" & COLORES.Text & "'"
        llena_tablas(dt, strSQL, cna)
        For Each dr In dt.Rows
            CLIENTES.Text = dr("CLIENTE")
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
            escala.SelectedIndex = dr("ESCALA")
            ta(1, 11) = dr("TOTAL")
            F_ENTREGA.Text = dr("F_ENTREGA")
            destino.Text = dr("DESTINO")
            comision.Text = dr("COMISION")
            vendedor.SelectedIndex = vendedor.Items.IndexOf(dr("VENDEDOR"))
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
            minimo.Text = dr("MINIMO_P")
            maximo.Text = dr("MAXIMO_P")
            E2.Visible = True
        Next
        habilita1()
        F_ENTREGA.Focus()
    End Sub

    Private Sub habilita()
        CPOS.Enabled = False
        CLIENTES.Enabled = False
        F_PEDIDO.Enabled = False
        F_ENTREGA.Enabled = False
        Estilos.Enabled = True
        COLORES.Enabled = True
        destino.Enabled = False
        vendedor.Enabled = False
        comision.Enabled = False
        escala.Enabled = False
        minimo.Enabled = False
        maximo.Enabled = False
        G2.Visible = False
        R2.Visible = True
        E2.Visible = False
        ta.Enabled = False
        setea_ct()
        Estilos.Focus()
        sub_total()
    End Sub

    Private Sub habilita1()
        G2.Visible = True
        Estilos.Enabled = False
        COLORES.Enabled = False
        F_ENTREGA.Enabled = True
        destino.Enabled = True
        escala.Enabled = True
        vendedor.Enabled = True
        comision.Enabled = True
        minimo.Enabled = True
        maximo.Enabled = True
        ta.Enabled = True
        ct.Enabled = True
        r = Split(b, "|")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R1.Click
        limpia_variables()
    End Sub

    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OKOnly, var + " NO VALIDO !!!! ")
    End Sub

    Private Sub G1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G1.Click
        revisa_cpo(ok)
        If ok Then
            revisa_encabezado(ok)
        End If
        If ok Then
            llena_colores()
            llena_estilos()
            llena_grid()
            habilita()
            G1.Visible = False
            E1.Visible = False
        End If
    End Sub

    Private Sub revisa_encabezado(ByVal ok As Boolean)

        If Trim(CLIENTES.Text) = "" Then
            ok = False
            mensaje("CLIENTE")
        End If
        If Trim(F_PEDIDO.Text) = "" Then
            ok = False
            mensaje("FECHA DEL PEDIDO")
        End If
        If Trim(F_ENTREGA.Text) = "" Then
            ok = False
            mensaje("FECHA DE ENTREGA")
        End If
    End Sub

    Private Sub E1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E1.Click
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        seguro = MsgBox("Seguro de Querer Eliminar TODA LA CPO?  ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_todo()
            limpia_variables()
        End If
    End Sub

    Private Sub seleccion(ByVal fil As Integer)
        If fil > 0 And fil < fg.Rows.Count Then
            Dim e As Integer = Estilos.Items.IndexOf(fg(fil, 2))
            Dim c As Integer = COLORES.Items.IndexOf(fg(fil, 3))
            Try
                Estilos.Text = Estilos.Items(e)
                COLORES.Text = COLORES.Items(c)
                busca_detalle()
            Catch
            End Try
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
            If Trim(CPOS.Text) <> "" Then
                busca_cpos()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(CLIENTES.Text) <> "" Then
                F_PEDIDO.Focus()
            End If
        End If
    End Sub

    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(F_PEDIDO.Text) <> "" Then
                G1.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            destino.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed6(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Estilos.Text) <> "" Then
                COLORES.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub keypressed7(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(COLORES.Text) <> "" And Trim(Estilos.Text) <> "" Then
                busca_detalle()
                F_ENTREGA.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed8a(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(vendedor.Text) <> "" Then
                comision.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed8b(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(comision.Text) <> "" Then
                minimo.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub keypressed8c(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim min As Integer
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            Try
                min = CInt(minimo.Text)
                If min > 100 Then
                    min = 100
                End If
            Catch ex As Exception
                min = 0
            End Try
            maximo.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed8d(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        Dim max As Integer
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            Try
                max = CInt(maximo.Text)
                If max > 100 Then
                    max = 100
                End If
            Catch ex As Exception
                max = 0
            End Try
            ta.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed9(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(escala.Text) <> "" Then
                vendedor.Focus()
            End If
        End If
    End Sub 'keypressed


    Private Sub keypressed18(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            escala.Focus()
        End If
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
            MsgBox("Por favor revise las tallas", MsgBoxStyle.OKOnly, "Existen valores no Validos !!!! ")
            SI = False
        End Try
    End Sub

    Private Sub G2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G2.Click
        revisa_Detalle(ok)
        If ok Then
            graba_registro()
            habilita()
            limpia_ta()
            G1.Visible = False
            E1.Visible = False
            sub_total()
        End If
    End Sub

    Private Sub revisa_Detalle(ByRef ok As Boolean)
        Dim comi As Integer
        ok = True
        If Trim(Estilos.Text) = "" Then
            ok = False
            mensaje("ESTILO")
        End If
        If Trim(COLORES.Text) = "" Then
            ok = False
            mensaje("COLOR")
        End If
        Try
            comi = CDec(comision.Text)
        Catch ex As Exception
            comi = 0
            comision.Text = "0.00"
            mensaje("Error en la Comisión.")
            ok = False
        End Try
        If ta(1, 11) = 0 Then
            ok = False
            mensaje("Error en las Unidades")
        End If
        If vendedor.Text <> "NINGUNO" And comi = 0 Then
            mensaje("Error en la Comisión.")
            ok = False
        End If
        If ok Then
            revisa_fechas(ok)
        End If
        If ok Then
            revisa_costos(ok)
        End If
    End Sub


    Private Sub llena_lineas(ByVal lineas As Integer)
        Try
            fg(lineas, 0) = Trim(Estilos.Text) + Trim(COLORES.Text)
            fg(lineas, 1) = CPOS.Text
            fg(lineas, 2) = Estilos.Text
            fg(lineas, 3) = COLORES.Text
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
            fg(lineas, 16) = F_ENTREGA.Text
            fg(lineas, 17) = destino.Text
        Catch
        End Try
    End Sub


    Private Sub R2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R2.Click
        habilita()
        limpia_ta()
    End Sub

    Private Sub E2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E2.Click
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        Dim ok As Boolean = True
        seguro = MsgBox("Seguro de Querer Eliminar   ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina()
            habilita()
            limpia_ta()
            sub_total()
        End If
    End Sub

    Private Sub revisa_fechas(ByRef si As Boolean)
        If Date.ParseExact(F_PEDIDO.Text, dateFormatGt, System.Globalization.CultureInfo.InvariantCulture) > Date.ParseExact(F_ENTREGA.Text, dateFormatGt, System.Globalization.CultureInfo.InvariantCulture) Then
            si = False
            mensaje("Error en las Fechas")
        Else
            si = True
        End If
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

    Private Sub ct_rowcolchange(ByVal sender As Object, ByVal e As RowColEventArgs) Handles ct.AfterEdit
        Dim tot As Decimal
        Dim cont As Integer
        Dim i As Integer
        For i = 0 To 9
            If ct(0, i) > 0 Then
                tot = ct(0, i)
                cont = cont + 1
            End If
        Next
        If cont = 1 Then
            copia_costo(tot)
        End If
    End Sub
    Private Sub ta_rowcolchange(ByVal sender As Object, ByVal e As RowColEventArgs) Handles ta.AfterEdit
        Dim ok As Boolean
        TOTAL(ok)
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        fila = fg.RowSel
        seleccion(fila)
    End Sub

    Private Sub copia_costo(ByVal costo As Decimal)
        Dim i As Integer
        Dim dat As String = CStr(ta(1, 1)) + "|" + CStr(ta(1, 2)) + "|" + CStr(ta(1, 3)) + "|" + CStr(ta(1, 4)) + "|" + CStr(ta(1, 5)) + "|" + CStr(ta(1, 6)) + "|" + CStr(ta(1, 7)) + "|" + CStr(ta(1, 8)) + "|" + CStr(ta(1, 9)) + "|" + CStr(ta(1, 10))
        r = Split(dat, "|")
        For i = 0 To 9
            If r(i) > 0 Then
                ct(0, i) = costo
            End If
        Next
    End Sub

    Private Sub revisa_costos(ByRef ok As Boolean)
        Dim i As Integer
        Dim dat As String = CStr(ta(1, 1)) + "|" + CStr(ta(1, 2)) + "|" + CStr(ta(1, 3)) + "|" + CStr(ta(1, 4)) + "|" + CStr(ta(1, 5)) + "|" + CStr(ta(1, 6)) + "|" + CStr(ta(1, 7)) + "|" + CStr(ta(1, 8)) + "|" + CStr(ta(1, 9)) + "|" + CStr(ta(1, 10))
        Dim tas As String()
        r = Split(dat, "|")
        tas = Split(t, "|")
        For i = 0 To 9
            If r(i) > 0 And ct(0, i) = 0 Then
                MsgBox("Aun no ha ingresado costo para la talla " + tas(i), MsgBoxStyle.Critical, "Por favor revise !!!!")
                ok = False
            End If
        Next
    End Sub

    Private Sub verifica_ordenes(ByRef ok As Boolean)
        Dim dt As New DataTable()
        Dim strsql As String = "SELECT * FROM CORTES WHERE CPO = '" & CPOS.Text & "' AND ESTILO = '" & Estilos.Text & "' AND COLOR = '" & COLORES.Text & "' AND EXPORTADO = 'N'"
        llena_tablas(dt, strsql, cnns)
        If dt.Rows.Count > 0 Then
            ok = False
        Else
            ok = True
        End If
    End Sub

    Private Sub CLIENTES_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLIENTES.SelectedIndexChanged
        llena_estilos()
    End Sub

    Private Sub Estilos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Estilos.SelectedIndexChanged
        llena_colores()
    End Sub

    ' =================================================================================
    ' =                            ACTUALIZA TABLAS
    ' =================================================================================

    Private Sub graba_registro()
        Dim strsql As String
        Dim afectados As Integer
        Dim fecha1 As String
        Dim fecha2 As String
        Dim fechae As String = Format(Date.ParseExact(F_ENTREGA.Text, dateFormatGt, System.Globalization.CultureInfo.InvariantCulture), "yyyy-MM-dd")
        Dim hoy As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
        Dim escalas As String = Format(escala.SelectedIndex, "00")
        Dim min As Integer
        Dim max As Integer
        Try
            min = CInt(minimo.Text)
            max = CInt(maximo.Text)
        Catch ex As Exception
            min = 0
            max = 0
        End Try

        cna.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cna.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cna.CreateCommand()
        comando.Transaction = transaccion

        Try
            ' ================ ENCABEZADOS ====================
            fecha1 = Format(Date.ParseExact(F_PEDIDO.Text, dateFormatGt, System.Globalization.CultureInfo.InvariantCulture), "yyyy-MM-dd")
            fecha2 = Format(Date.ParseExact(F_ENTREGA.Text, dateFormatGt, System.Globalization.CultureInfo.InvariantCulture), "yyyy-MM-dd")
            strsql = "UPDATE CPO_2 SET CLIENTE = " & "'" & CLIENTES.Text & "'" & _
                                 " , F_PEDIDO = " & "'" & fecha1 & "'" & _
                                 " , F_ENTREGA = " & "'" & fecha2 & "'" & _
                                 " WHERE CPO = '" & CPOS.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()
            If afectados = 0 Then
                strsql = "INSERT INTO CPO_2 (CPO,CLIENTE,F_PEDIDO,F_ENTREGA) " & _
                         "VALUES ( '" & CPOS.Text & "','" & _
                             CLIENTES.Text & "','" & _
                             fecha1 & "','" & _
                             fecha2 & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If

            ' ================ DETALLE ====================
            strsql = "UPDATE CPO_D2  SET ESTILO = " & "'" & Estilos.Text & "'" & _
             " , COLOR = " & "'" & COLORES.Text & "'" & _
             " , XS = " & "'" & ta(1, 1) & "'" & _
             " , S = " & "'" & ta(1, 2) & "'" & _
             " , M = " & "'" & ta(1, 3) & "'" & _
             " , L = " & "'" & ta(1, 4) & "'" & _
             " , XL = " & "'" & ta(1, 5) & "'" & _
             " , XL2 = " & "'" & ta(1, 6) & "'" & _
             " , XL3 = " & "'" & ta(1, 7) & "'" & _
             " , XL4 = " & "'" & ta(1, 8) & " '" & _
             " , XL5 = " & "'" & ta(1, 9) & "'" & _
             " , XL6 = " & "'" & ta(1, 10) & "'" & _
             " , TOTAL = " & "'" & ta(1, 11) & "'" & _
             " , F_ENTREGA = " & "'" & fechae & "'" & _
             " , F_PROMETIDA = " & "'" & fechae & "'" & _
             " , DESTINO = " & "'" & destino.Text & "'" & _
             " , C1 = " & "'" & ct(0, 0) & "'" & _
             " , C2 = " & "'" & ct(0, 1) & "'" & _
             " , C3 = " & "'" & ct(0, 2) & "'" & _
             " , C4 = " & "'" & ct(0, 3) & "'" & _
             " , C5 = " & "'" & ct(0, 4) & "'" & _
             " , C6 = " & "'" & ct(0, 5) & "'" & _
             " , C7 = " & "'" & ct(0, 6) & "'" & _
             " , C8 = " & "'" & ct(0, 7) & "'" & _
             " , C9 = " & "'" & ct(0, 8) & "'" & _
             " , C0 = " & "'" & ct(0, 9) & "' , USUARIO = '" & usuario & "' , FECHA = '" & hoy & "', VENDEDOR = '" & vendedor.Text & "', COMISION = '" & comision.Text & "', ESCALA = '" & escalas & "', MINIMO_P = '" & CStr(min) & "', MAXIMO_P = '" & CStr(max) & "' WHERE CPO = '" & CPOS.Text & "' AND ESTILO = '" & Estilos.Text & "' AND COLOR = '" & COLORES.Text & "'"

            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()
            If afectados = 0 Then
                strsql = "INSERT INTO CPO_D2 (CPO,ESTILO,COLOR,XS,S,M,L,XL,XL2,XL3,XL4,XL5,XL6,TOTAL,F_ENTREGA,F_PROMETIDA,DESTINO,C1,C2,C3,C4,C5,C6,C7,C8,C9,C0,FECHA,USUARIO,VENDEDOR,COMISION,ESCALA,MINIMO_P,MAXIMO_P) " & _
                         "VALUES ( '" & CPOS.Text & "','" & _
                             Estilos.Text & "','" & _
                             COLORES.Text & "','" & _
                             ta(1, 1) & "','" & _
                             ta(1, 2) & "','" & _
                             ta(1, 3) & "','" & _
                             ta(1, 4) & "','" & _
                             ta(1, 5) & "','" & _
                             ta(1, 6) & "','" & _
                             ta(1, 7) & "','" & _
                             ta(1, 8) & "','" & _
                             ta(1, 9) & "','" & _
                             ta(1, 10) & "','" & _
                             ta(1, 11) & "','" & _
                             fechae & "','" & _
                             fechae & "','" & _
                             UCase(destino.Text) & "','" & _
                             ct(0, 0) & "','" & _
                             ct(0, 1) & "','" & _
                             ct(0, 2) & "','" & _
                             ct(0, 3) & "','" & _
                             ct(0, 4) & "','" & _
                             ct(0, 5) & "','" & _
                             ct(0, 6) & "','" & _
                             ct(0, 7) & "','" & _
                             ct(0, 8) & "','" & _
                             ct(0, 9) & "','" & hoy & "','" & usuario & "','" & vendedor.Text & "','" & comision.Text & "','" & escalas & "','" & _
                             CStr(min) & "','" & _
                             CStr(max) & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If

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
            cna.Close()
        End Try
    End Sub

    Private Sub elimina()
        Dim strsql As String
        Dim afectados As Integer

        cna.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cna.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cna.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE FROM CPO_D2 WHERE CPO = '" & CPOS.Text & "' AND ESTILO = '" & Estilos.Text & "' AND COLOR = '" & COLORES.Text & "'"
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
            cna.Close()
        End Try
    End Sub


    Private Sub elimina_todo()
        Dim strsql As String
        Dim afectados As Integer

        cna.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cna.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cna.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE FROM CPO_D2 WHERE CPO = '" & CPOS.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "DELETE FROM CPO_2 WHERE CPO = '" & CPOS.Text & "'"
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
            cna.Close()
        End Try
    End Sub

    Private Sub CPOS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CPOS.Leave
        Dim ok As Boolean
        revisa_cpo(ok)
        If Not ok Then
            CPOS.Focus()
        End If
    End Sub

    Private Sub revisa_cpo(ByRef ok As Boolean)
        Dim dd As DataRow()
        ok = True
        dd = cp.Select("CPO = '" & CPOS.Text & "'")
        If dd.Length > 0 Then
            MsgBox("Cpo ya existe !!!", MsgBoxStyle.Critical, "Por favor revise !!!")
            ok = False
        End If
    End Sub

    Private Sub sub_total()
        Dim i As Integer
        Dim t As Integer
        For i = 1 To fg.Rows.Count - 1
            t = t + fg(i, 14)
        Next
        tp.Text = Format(t, "##,###,##0")
        tp.Refresh()
    End Sub
    Private Sub clientes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CLIENTES.KeyPress
        AutoCompletar(CLIENTES, e)
    End Sub
    Private Sub estilos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Estilos.KeyPress
        AutoCompletar(Estilos, e)
    End Sub
    Private Sub colores_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles COLORES.KeyPress
        AutoCompletar(COLORES, e)
    End Sub
    Private Sub vendedores_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles vendedor.KeyPress
        AutoCompletar(vendedor, e)
    End Sub
    Private Sub escala_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles escala.KeyPress
        AutoCompletar(escala, e)
    End Sub

    Private Sub escala_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles escala.SelectedIndexChanged
        Dim t As String = Format(escala.SelectedIndex, "00")
        Dim dr As DataRow
        Dim i As Integer
        dr = get_tallas(t)
        For i = 1 To 10
            t = dr(i + 1)
            ta(0, i) = t
            ta(1, i) = 0
            If Trim(t) = "" Then
                ta.Cols(i).AllowEditing = False
            Else
                ta.Cols(i).AllowEditing = True
            End If
        Next
        ta(0, 11) = "TOTALES"
        ta(1, 11) = 0
        ta.SetCellStyle(1, 11, ta.Styles("amarillo"))
    End Sub

End Class
