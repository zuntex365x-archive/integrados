Imports C1.Win.C1FlexGrid

Public Class Cpo_con2
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn As SqlClient.SqlConnection
    Dim cna As New SqlClient.SqlConnection()
    Dim TIPO As String
    Dim lineas As Integer
    Dim b As String = "0|0|0|0|0|0|0|0|0|0|0"
    Dim t As String = "XS|S|M|L|XL|XL2|XL3|XL4|XL5|XL6"
    Dim r As String()
    Dim g As String()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Friend WithEvents vendedor As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents ta As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents escala As System.Windows.Forms.ComboBox
    Dim cp As New DataTable()
    Friend WithEvents minimo As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents maximo As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cpos As System.Windows.Forms.Label
    Dim adulto As Boolean = True

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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents clientes As System.Windows.Forms.Label
    Friend WithEvents F_pedido As System.Windows.Forms.Label
    Friend WithEvents estilos As System.Windows.Forms.Label
    Friend WithEvents colores As System.Windows.Forms.Label
    Friend WithEvents f_entrega As System.Windows.Forms.Label
    Friend WithEvents destino As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ct As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents estado As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents f_ingreso As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cpo_con2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ct = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.vendedor = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.F_pedido = New System.Windows.Forms.Label()
        Me.clientes = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.estilos = New System.Windows.Forms.Label()
        Me.colores = New System.Windows.Forms.Label()
        Me.f_entrega = New System.Windows.Forms.Label()
        Me.destino = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ta = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.f_ingreso = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.estado = New System.Windows.Forms.Label()
        Me.escala = New System.Windows.Forms.ComboBox()
        Me.minimo = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.maximo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cpos = New System.Windows.Forms.Label()
        CType(Me.ct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(488, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "F.Pedido"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(256, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(171, Byte), Integer))
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
        'ct
        '
        Me.ct.AllowEditing = False
        Me.ct.ColumnInfo = resources.GetString("ct.ColumnInfo")
        Me.ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ct.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.ct.Location = New System.Drawing.Point(8, 80)
        Me.ct.Name = "ct"
        Me.ct.Rows.Count = 1
        Me.ct.Rows.DefaultSize = 21
        Me.ct.Rows.Fixed = 0
        Me.ct.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ct.Size = New System.Drawing.Size(728, 28)
        Me.ct.StyleInfo = resources.GetString("ct.StyleInfo")
        Me.ct.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.ct, "Area de Datos.")
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(171, Byte), Integer))
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
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(171, Byte), Integer))
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
        Me.GroupBox2.Controls.Add(Me.cpos)
        Me.GroupBox2.Controls.Add(Me.vendedor)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.F_pedido)
        Me.GroupBox2.Controls.Add(Me.clientes)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(984, 64)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        '
        'vendedor
        '
        Me.vendedor.BackColor = System.Drawing.Color.White
        Me.vendedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.vendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vendedor.ForeColor = System.Drawing.Color.Black
        Me.vendedor.Location = New System.Drawing.Point(614, 24)
        Me.vendedor.Name = "vendedor"
        Me.vendedor.Size = New System.Drawing.Size(320, 28)
        Me.vendedor.TabIndex = 61
        Me.vendedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(614, 8)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(320, 16)
        Me.Label25.TabIndex = 60
        Me.Label25.Text = "Vendedor"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'F_pedido
        '
        Me.F_pedido.BackColor = System.Drawing.Color.White
        Me.F_pedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.F_pedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F_pedido.ForeColor = System.Drawing.Color.Black
        Me.F_pedido.Location = New System.Drawing.Point(488, 24)
        Me.F_pedido.Name = "F_pedido"
        Me.F_pedido.Size = New System.Drawing.Size(120, 26)
        Me.F_pedido.TabIndex = 57
        Me.F_pedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'clientes
        '
        Me.clientes.BackColor = System.Drawing.Color.White
        Me.clientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientes.ForeColor = System.Drawing.Color.Black
        Me.clientes.Location = New System.Drawing.Point(256, 24)
        Me.clientes.Name = "clientes"
        Me.clientes.Size = New System.Drawing.Size(216, 26)
        Me.clientes.TabIndex = 56
        Me.clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(480, 80)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(287, 16)
        Me.Label22.TabIndex = 48
        Me.Label22.Text = "Lugar de Envio"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.estilos.TabIndex = 57
        Me.estilos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.colores.TabIndex = 58
        Me.colores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.f_entrega.TabIndex = 58
        Me.f_entrega.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'destino
        '
        Me.destino.BackColor = System.Drawing.Color.White
        Me.destino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.destino.ForeColor = System.Drawing.Color.Black
        Me.destino.Location = New System.Drawing.Point(480, 96)
        Me.destino.Name = "destino"
        Me.destino.Size = New System.Drawing.Size(287, 20)
        Me.destino.TabIndex = 59
        Me.destino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(864, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "ESTADO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(8, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(168, 16)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "Costo Unitario por Talla"
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.ta)
        Me.GroupBox1.Controls.Add(Me.f_ingreso)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.estado)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
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
        Me.ta.Location = New System.Drawing.Point(8, 15)
        Me.ta.Name = "ta"
        Me.ta.Rows.Count = 2
        Me.ta.Rows.DefaultSize = 19
        Me.ta.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ta.Size = New System.Drawing.Size(827, 46)
        Me.ta.StyleInfo = resources.GetString("ta.StyleInfo")
        Me.ta.TabIndex = 72
        '
        'f_ingreso
        '
        Me.f_ingreso.BackColor = System.Drawing.Color.White
        Me.f_ingreso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.f_ingreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f_ingreso.ForeColor = System.Drawing.Color.Black
        Me.f_ingreso.Location = New System.Drawing.Point(752, 85)
        Me.f_ingreso.Name = "f_ingreso"
        Me.f_ingreso.Size = New System.Drawing.Size(184, 20)
        Me.f_ingreso.TabIndex = 71
        Me.f_ingreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(752, 68)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(184, 16)
        Me.Label24.TabIndex = 70
        Me.Label24.Text = "ACTUALIZADA"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'estado
        '
        Me.estado.BackColor = System.Drawing.Color.White
        Me.estado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estado.ForeColor = System.Drawing.Color.Black
        Me.estado.Location = New System.Drawing.Point(864, 32)
        Me.estado.Name = "estado"
        Me.estado.Size = New System.Drawing.Size(70, 20)
        Me.estado.TabIndex = 69
        Me.estado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'escala
        '
        Me.escala.Location = New System.Drawing.Point(850, 95)
        Me.escala.MaxLength = 20
        Me.escala.Name = "escala"
        Me.escala.Size = New System.Drawing.Size(136, 21)
        Me.escala.TabIndex = 62
        Me.escala.Visible = False
        '
        'minimo
        '
        Me.minimo.BackColor = System.Drawing.Color.White
        Me.minimo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.minimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimo.ForeColor = System.Drawing.Color.Black
        Me.minimo.Location = New System.Drawing.Point(774, 96)
        Me.minimo.Name = "minimo"
        Me.minimo.Size = New System.Drawing.Size(80, 20)
        Me.minimo.TabIndex = 73
        Me.minimo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(774, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "% MINIMO"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'maximo
        '
        Me.maximo.BackColor = System.Drawing.Color.White
        Me.maximo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.maximo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maximo.ForeColor = System.Drawing.Color.Black
        Me.maximo.Location = New System.Drawing.Point(862, 96)
        Me.maximo.Name = "maximo"
        Me.maximo.Size = New System.Drawing.Size(80, 20)
        Me.maximo.TabIndex = 75
        Me.maximo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(862, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "% MAXIMO"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cpos
        '
        Me.cpos.BackColor = System.Drawing.Color.White
        Me.cpos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cpos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpos.ForeColor = System.Drawing.Color.Black
        Me.cpos.Location = New System.Drawing.Point(8, 24)
        Me.cpos.Name = "cpos"
        Me.cpos.Size = New System.Drawing.Size(225, 26)
        Me.cpos.TabIndex = 62
        Me.cpos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cpo_con2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1002, 266)
        Me.Controls.Add(Me.maximo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.minimo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.escala)
        Me.Controls.Add(Me.destino)
        Me.Controls.Add(Me.colores)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.estilos)
        Me.Controls.Add(Me.f_entrega)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cpo_con2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de CPO's"
        Me.ToolTip1.SetToolTip(Me, "Consulta de CPO's")
        CType(Me.ct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Cpo_con1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena_combos(escala, "SELECT NOMBRE FROM E_TALLAS", "NOMBRE")
        busca_detalle()
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

    Private Sub busca_detalle()
        Dim dr As DataRow
        dt = New DataTable()
        Dim strSQL As String = "SELECT * FROM CPO_D LEFT JOIN CPO_COSTO ON CPO_D.CPO = CPO_COSTO.CPO AND CPO_D.ESTILO = CPO_COSTO.ESTILO AND CPO_D.COLOR = CPO_COSTO.COLOR LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO WHERE CPO_D.CPO =  '" & cpos.Text & "' AND CPO_D.ESTILO = '" & estilos.Text & "' AND CPO_D.COLOR = '" & colores.Text & "'"
        llena_tablas(dt, strSQL, cna)
        For Each dr In dt.Rows
            estilos.Text = dr("ESTILO")
            escala.SelectedIndex = dr("ESCALA")
            clientes.Text = dr("CLIENTE")
            F_pedido.Text = dr("F_PEDIDO")
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
            f_entrega.Text = Format(dr("F_ENTREGA"), "dd/MM/yyyy")
            destino.Text = dr("DESTINO")
            estado.Text = dr("ESTADO")
            vendedor.Text = dr("VENDEDOR")
            minimo.Text = dr("MINIMO_P")
            maximo.Text = dr("MAXIMO_P")
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
            Try
                f_ingreso.Text = Format(dr("F_INGRESO"), "yyyy-MM-dd  HH:mm:ss")
            Catch

            End Try
        Next
    End Sub

    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OkOnly, var + " NO VALIDO !!!! ")
    End Sub


    Private Sub escala_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles escala.SelectedIndexChanged
        talla_setea(ta, escala.SelectedIndex)
    End Sub
End Class
