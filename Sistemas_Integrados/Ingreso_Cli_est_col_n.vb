Imports C1.Win.C1FlexGrid


Public Class Ingreso_Cli_est_col_n
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Friend WithEvents ESTILOS As System.Windows.Forms.ComboBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents proceso As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ecliente As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ccliente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents comentarios As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents sigue As System.Windows.Forms.Button
    Friend WithEvents n_proceso As System.Windows.Forms.Button
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents COLORES As System.Windows.Forms.ComboBox
    Friend WithEvents CLIENTES As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Regresa As System.Windows.Forms.Button
    Friend WithEvents Graba As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingreso_Cli_est_col_n))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CLIENTES = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.COLORES = New System.Windows.Forms.ComboBox()
        Me.Regresa = New System.Windows.Forms.Button()
        Me.Graba = New System.Windows.Forms.Button()
        Me.ESTILOS = New System.Windows.Forms.ComboBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.proceso = New System.Windows.Forms.ComboBox()
        Me.ecliente = New System.Windows.Forms.TextBox()
        Me.ccliente = New System.Windows.Forms.TextBox()
        Me.descripcion = New System.Windows.Forms.TextBox()
        Me.comentarios = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.sigue = New System.Windows.Forms.Button()
        Me.n_proceso = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(264, 16)
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
        Me.Label7.Location = New System.Drawing.Point(16, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(264, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Estilo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CLIENTES
        '
        Me.CLIENTES.Location = New System.Drawing.Point(16, 32)
        Me.CLIENTES.MaxLength = 20
        Me.CLIENTES.Name = "CLIENTES"
        Me.CLIENTES.Size = New System.Drawing.Size(264, 21)
        Me.CLIENTES.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.CLIENTES, "Cliente")
        '
        'COLORES
        '
        Me.COLORES.Location = New System.Drawing.Point(354, 76)
        Me.COLORES.MaxLength = 25
        Me.COLORES.Name = "COLORES"
        Me.COLORES.Size = New System.Drawing.Size(328, 21)
        Me.COLORES.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.COLORES, "Cliente")
        '
        'Regresa
        '
        Me.Regresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Regresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresa.ForeColor = System.Drawing.Color.Black
        Me.Regresa.Image = CType(resources.GetObject("Regresa.Image"), System.Drawing.Image)
        Me.Regresa.Location = New System.Drawing.Point(888, 16)
        Me.Regresa.Name = "Regresa"
        Me.Regresa.Size = New System.Drawing.Size(35, 35)
        Me.Regresa.TabIndex = 49
        Me.Regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Regresa, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.Regresa.UseVisualStyleBackColor = False
        '
        'Graba
        '
        Me.Graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Graba.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Graba.ForeColor = System.Drawing.Color.Black
        Me.Graba.Image = CType(resources.GetObject("Graba.Image"), System.Drawing.Image)
        Me.Graba.Location = New System.Drawing.Point(847, 16)
        Me.Graba.Name = "Graba"
        Me.Graba.Size = New System.Drawing.Size(35, 35)
        Me.Graba.TabIndex = 50
        Me.Graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Graba, "Presione este Boton para Grabar o Actualizar los Datos")
        Me.Graba.UseVisualStyleBackColor = False
        Me.Graba.Visible = False
        '
        'ESTILOS
        '
        Me.ESTILOS.Location = New System.Drawing.Point(16, 76)
        Me.ESTILOS.MaxLength = 20
        Me.ESTILOS.Name = "ESTILOS"
        Me.ESTILOS.Size = New System.Drawing.Size(264, 21)
        Me.ESTILOS.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.ESTILOS, "Cliente")
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(11, 291)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 21
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(952, 397)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'proceso
        '
        Me.proceso.Location = New System.Drawing.Point(13, 79)
        Me.proceso.MaxLength = 20
        Me.proceso.Name = "proceso"
        Me.proceso.Size = New System.Drawing.Size(264, 21)
        Me.proceso.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.proceso, "Proceso")
        '
        'ecliente
        '
        Me.ecliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ecliente.Location = New System.Drawing.Point(13, 32)
        Me.ecliente.MaxLength = 30
        Me.ecliente.Name = "ecliente"
        Me.ecliente.Size = New System.Drawing.Size(264, 20)
        Me.ecliente.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.ecliente, "Estilo según el Cliente")
        '
        'ccliente
        '
        Me.ccliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccliente.Location = New System.Drawing.Point(351, 32)
        Me.ccliente.MaxLength = 30
        Me.ccliente.Name = "ccliente"
        Me.ccliente.Size = New System.Drawing.Size(462, 20)
        Me.ccliente.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.ccliente, "Color según el cliente")
        '
        'descripcion
        '
        Me.descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descripcion.Location = New System.Drawing.Point(351, 77)
        Me.descripcion.MaxLength = 80
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(462, 20)
        Me.descripcion.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.descripcion, "Descripción del Proceso")
        '
        'comentarios
        '
        Me.comentarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comentarios.Location = New System.Drawing.Point(351, 121)
        Me.comentarios.MaxLength = 80
        Me.comentarios.Name = "comentarios"
        Me.comentarios.Size = New System.Drawing.Size(462, 20)
        Me.comentarios.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.comentarios, "Comentarios")
        '
        'ComboBox2
        '
        Me.ComboBox2.Location = New System.Drawing.Point(16, 32)
        Me.ComboBox2.MaxLength = 20
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(264, 21)
        Me.ComboBox2.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.ComboBox2, "Cliente")
        '
        'ComboBox3
        '
        Me.ComboBox3.Location = New System.Drawing.Point(354, 76)
        Me.ComboBox3.MaxLength = 20
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(328, 21)
        Me.ComboBox3.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.ComboBox3, "Cliente")
        '
        'ComboBox4
        '
        Me.ComboBox4.Location = New System.Drawing.Point(16, 76)
        Me.ComboBox4.MaxLength = 20
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(264, 21)
        Me.ComboBox4.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.ComboBox4, "Cliente")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(847, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 50
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para Grabar o Actualizar los Datos")
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
        Me.Button2.Location = New System.Drawing.Point(888, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 49
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.")
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'sigue
        '
        Me.sigue.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.sigue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sigue.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sigue.ForeColor = System.Drawing.Color.Black
        Me.sigue.Image = CType(resources.GetObject("sigue.Image"), System.Drawing.Image)
        Me.sigue.Location = New System.Drawing.Point(847, 16)
        Me.sigue.Name = "sigue"
        Me.sigue.Size = New System.Drawing.Size(35, 35)
        Me.sigue.TabIndex = 4
        Me.sigue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.sigue, "Chequeo de Datos")
        Me.sigue.UseVisualStyleBackColor = False
        '
        'n_proceso
        '
        Me.n_proceso.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.n_proceso.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.n_proceso.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.n_proceso.ForeColor = System.Drawing.Color.Black
        Me.n_proceso.Image = CType(resources.GetObject("n_proceso.Image"), System.Drawing.Image)
        Me.n_proceso.Location = New System.Drawing.Point(847, 60)
        Me.n_proceso.Name = "n_proceso"
        Me.n_proceso.Size = New System.Drawing.Size(35, 35)
        Me.n_proceso.TabIndex = 10
        Me.n_proceso.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.n_proceso, "Chequeo de Datos")
        Me.n_proceso.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.SteelBlue
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(354, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(328, 16)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Color"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.sigue)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.CLIENTES)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.COLORES)
        Me.GroupBox2.Controls.Add(Me.ESTILOS)
        Me.GroupBox2.Controls.Add(Me.Graba)
        Me.GroupBox2.Controls.Add(Me.Regresa)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(944, 107)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(944, 107)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SteelBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(264, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cliente"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.SteelBlue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(16, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(264, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Estilo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.SteelBlue
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(354, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(328, 16)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Color"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Proceso"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.SteelBlue
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(13, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(264, 16)
        Me.Label22.TabIndex = 57
        Me.Label22.Text = "Estilo Cliente"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(351, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(462, 16)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Color Cliente"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(351, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(462, 16)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Descripción del Proceso"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(351, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(462, 16)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Comentarios"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.n_proceso)
        Me.GroupBox3.Controls.Add(Me.comentarios)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.descripcion)
        Me.GroupBox3.Controls.Add(Me.proceso)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.ccliente)
        Me.GroupBox3.Controls.Add(Me.ecliente)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 133)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(944, 152)
        Me.GroupBox3.TabIndex = 54
        Me.GroupBox3.TabStop = False
        '
        'Ingreso_Cli_est_col_n
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(970, 696)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ingreso_Cli_est_col_n"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de  Estilos_Colores por Cliente"
        Me.ToolTip1.SetToolTip(Me, "Ingreso de  Estilos_Colores por Cliente")
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler CLIENTES.KeyPress, AddressOf keypressed0
        AddHandler ESTILOS.KeyPress, AddressOf keypressed1
        AddHandler COLORES.KeyPress, AddressOf keypressed2
        AddHandler ecliente.KeyPress, AddressOf keypressed3
        AddHandler ccliente.KeyPress, AddressOf keypressed4
        AddHandler proceso.KeyPress, AddressOf keypressed5
        AddHandler descripcion.KeyPress, AddressOf keypressed6
        AddHandler comentarios.KeyPress, AddressOf keypressed7
        llena_combos(CLIENTES, "SELECT * FROM CLIENTES ORDER BY CLIENTE", "CLIENTE")
        llena_combos(proceso, "SELECT * FROM MAESTRO_PROCESOS ", "PROCESO")
        llena_estilos()
        limpia_variables()
    End Sub

    Private Sub limpia_variables()
        CLIENTES.Enabled = True
        ESTILOS.Enabled = True
        COLORES.Enabled = True
        Graba.Visible = False
        ecliente.Text = ""
        ccliente.Text = ""
        descripcion.Text = ""
        comentarios.Text = ""
        proceso.Enabled = False
        ecliente.Enabled = False
        ccliente.Enabled = False
        descripcion.Enabled = False
        comentarios.Enabled = False
        proceso.Enabled = False
        sigue.Visible = True
        setea_grid()
        CLIENTES.Focus()
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_grid()
        Dim dr As DataRow
        ok = False
        Dim strSQL As String = "SELECT * FROM CLI_EST_COL_P WHERE CLIENTE = '" & CLIENTES.Text & "' AND ESTILO = '" & ESTILOS.Text & "' AND COLOR = '" & COLORES.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            fg.Rows.Count = fg.Rows.Count + 1
            lineas = fg.Rows.Count - 1
            fg(lineas, 1) = dr("PROCESO")
            fg(lineas, 2) = dr("DETALLE")
            fg(lineas, 3) = dr("COMENTARIOS")
        Next
    End Sub
    Private Sub procesos()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim strsql As String = "SELECT * FROM CLI_EST_COL WHERE CLIENTE = '" & CLIENTES.Text & "' AND ESTILO = '" & ESTILOS.Text & "' AND COLOR = '" & COLORES.Text & "'"
        llena_tablas(dt, strsql, cnn)
        strsql = "SELECT * FROM CLI_EST_COL_1 WHERE CLIENTE = '" & CLIENTES.Text & "' AND ESTILO = '" & ESTILOS.Text & "' AND COLOR = '" & COLORES.Text & "'"
        llena_tablas(dt, strsql, cnn)
        For Each dr In dt.Rows
            ecliente.Text = dr("ESTILO_CLIENTE")
            ccliente.Text = dr("COLOR_CLIENTE")
        Next
        setea_grid()
        llena_grid()
        habilita()
    End Sub
    Private Sub habilita()
        CLIENTES.Enabled = False
        ESTILOS.Enabled = False
        COLORES.Enabled = False
        Graba.Visible = True
        proceso.Enabled = True
        ecliente.Enabled = True
        ccliente.Enabled = True
        descripcion.Enabled = True
        comentarios.Enabled = True
        proceso.Enabled = True
        sigue.Visible = False
        Graba.Visible = True
        ecliente.Focus()
    End Sub
    Private Sub llena_estilos()
        Dim strSQL As String = "SELECT * FROM ESTILOS WHERE CLIENTE =  '" & CLIENTES.Text & "' ORDER BY ESTILO"
        llena_combos(ESTILOS, strSQL, "ESTILO")
    End Sub
    Private Sub llena_colores()
        llena_combos(COLORES, "SELECT * FROM COLORES WHERE CLIENTE =  '" & CLIENTES.Text & "' AND ACTIVO = 'S' ORDER BY COLOR", "COLOR")
    End Sub

    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OkOnly, var + " NO VALIDO !!!! ")
    End Sub

    Private Sub seleccion(ByVal fil As Integer)
        If fil > 0 And fil < fg.Rows.Count Then
            proceso.SelectedIndex = proceso.Items.IndexOf(Trim(fg(fil, 1)))
            descripcion.Text = fg(fil, 2)
            comentarios.Text = fg(fil, 3)
        End If
    End Sub

    Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Up Then
            seleccion(fg.Row - 1)
        End If

        If e.KeyCode = Keys.Down Then
            seleccion(fg.Row + 1)
        End If
    End Sub
    '================================== HANDLERS ================================
    Private Sub keypressed0(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(CLIENTES.Text) <> "" Then
                ESTILOS.Focus()
            End If
        End If
    End Sub 'keypressed
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(ESTILOS.Text) <> "" Then
                COLORES.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(COLORES.Text) <> "" Then
                sigue.Focus()
            End If
        End If
    End Sub
    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(ecliente.Text) <> "" Then
                ccliente.Focus()
            End If
        End If
    End Sub
    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(ccliente.Text) <> "" Then
                proceso.Focus()
            End If
        End If
    End Sub
    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(proceso.Text) <> "" Then
                descripcion.Focus()
            End If
        End If
    End Sub
    Private Sub keypressed6(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(descripcion.Text) <> "" Then
                comentarios.Focus()
            End If
        End If
    End Sub
    Private Sub keypressed7(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            n_proceso.Focus()
        End If
    End Sub
    Private Sub fg_Click(sender As System.Object, e As System.EventArgs) Handles fg.DoubleClick
        lineas = fg.RowSel
        Dim seguro As MsgBoxResult
        Dim elimino As Boolean = False
        seguro = MsgBox("Seguro de Querer Eliminar   ", MsgBoxStyle.YesNo, "Eliminando Registro !!!")
        If seguro = MsgBoxResult.Yes Then
            fg.Rows.Remove(lineas)
        End If
    End Sub
    Private Sub graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Graba.Click
        If Trim(ESTILOS.Text) <> "" And Trim(COLORES.Text) <> "" Then
            graba_registro()
            limpia_variables()
        End If
    End Sub

    Private Sub CLIENTES_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLIENTES.SelectedIndexChanged
        llena_estilos()
        ESTILOS.Focus()
    End Sub

    Private Sub Regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Regresa.Click
        limpia_variables()
    End Sub

    Private Sub clientes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CLIENTES.KeyPress
        AutoCompletar(CLIENTES, e)
    End Sub
    Private Sub estilos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ESTILOS.KeyPress
        AutoCompletar(Estilos, e)
    End Sub
    Private Sub colores_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles COLORES.KeyPress
        AutoCompletar(COLORES, e)
    End Sub

    Private Sub procesos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles proceso.KeyPress
        AutoCompletar(proceso, e)
    End Sub
    Private Sub G1_Click(sender As System.Object, e As System.EventArgs) Handles sigue.Click
        procesos()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles n_proceso.Click
        nueva_linea()
    End Sub

    Private Sub nueva_linea()
        Dim l As Integer
        l = fg.FindRow(proceso.Text, 1, 1, False)
        If l < 1 Then
            l = fg.Rows.Count
            fg.Rows.Count = l + 1
        End If
        fg(l, 1) = UCase(proceso.Text)
        fg(l, 2) = UCase(descripcion.Text)
        fg(l, 3) = UCase(comentarios.Text)
        descripcion.Text = ""
        comentarios.Text = ""
        proceso.Focus()
    End Sub

    ' ========================================================
    ' =   ACTUALIZA DATOS
    ' ========================================================

    Private Sub graba_registro()
        Dim strsql As String
        Dim afectados As Integer
        Dim i As Integer

        ecliente.Text = UCase(ecliente.Text)
        ccliente.Text = UCase(ccliente.Text)
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "UPDATE CLI_EST_COL SET ESTILO = " & "'" & ESTILOS.Text & "'" & _
                          " , COLOR = " & "'" & COLORES.Text & "'" & _
                          " WHERE CLIENTE = '" & CLIENTES.Text & "' AND ESTILO = '" & ESTILOS.Text & "' AND COLOR = '" & COLORES.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()
            If afectados = 0 Then
                strsql = "INSERT INTO CLI_EST_COL (CLIENTE,ESTILO,COLOR,ESTADO) " & _
                  "VALUES ( '" & CLIENTES.Text & "','" & _
                      ESTILOS.Text & "','" & _
                      COLORES.Text & "','C')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If
            ' =========== CLI_EST_COL_1
            strsql = "UPDATE CLI_EST_COL_1 SET ESTILO_CLIENTE = " & "'" & ecliente.Text & "'" & _
                         " , COLOR_CLIENTE = " & "'" & ccliente.Text & "'" & _
                         " WHERE CLIENTE = '" & CLIENTES.Text & "' AND ESTILO = '" & ESTILOS.Text & "' AND COLOR = '" & COLORES.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()
            If afectados = 0 Then
                strsql = "INSERT INTO CLI_EST_COL_1 (CLIENTE,ESTILO,COLOR,ESTILO_CLIENTE,COLOR_CLIENTE) " & _
                  "VALUES ( '" & CLIENTES.Text & "','" & _
                                 ESTILOS.Text & "','" & _
                                 COLORES.Text & "','" & _
                                 ecliente.Text & "','" & _
                                 ccliente.Text & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            End If
            ' =========== CLI_EST_COL_P
            strsql = "DELETE CLI_EST_COL_P WHERE CLIENTE = '" & CLIENTES.Text & "' AND ESTILO = '" & ESTILOS.Text & "' AND COLOR = '" & COLORES.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            For i = 1 To fg.Rows.Count - 1
                strsql = "INSERT INTO CLI_EST_COL_P (CLIENTE,ESTILO,COLOR,PROCESO,DETALLE,COMENTARIOS) " & _
                  "VALUES ( '" & CLIENTES.Text & "','" & _
                                 ESTILOS.Text & "','" & _
                                 COLORES.Text & "','" & _
                                 fg(i, 1) & "','" & _
                                 fg(i, 2) & "','" & _
                                 fg(i, 3) & "')"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            Next


            transaccion.Commit()

            MsgBox("Grabación Exitosa !!!!", MsgBoxStyle.Information, "Actualización de Datos")

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

    Private Sub ESTILOS_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ESTILOS.SelectedIndexChanged
        llena_colores()
    End Sub
End Class
