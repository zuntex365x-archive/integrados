Imports C1.Win.C1FlexGrid

Public Class Estilos_Consulta
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim lineas As Integer
    Dim dr As DataRow
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents empaque As System.Windows.Forms.CheckBox
    Friend WithEvents lavado As System.Windows.Forms.CheckBox
    Friend WithEvents tenido As System.Windows.Forms.CheckBox
    Friend WithEvents costura As System.Windows.Forms.CheckBox
    Friend WithEvents serigra As System.Windows.Forms.CheckBox
    Friend WithEvents bordado As System.Windows.Forms.CheckBox
    Friend WithEvents corte As System.Windows.Forms.CheckBox
    Dim nuevo As Boolean
    Dim usuario As String
    Friend WithEvents votros As System.Windows.Forms.Label
    Friend WithEvents vempaque As System.Windows.Forms.Label
    Friend WithEvents vhilo As System.Windows.Forms.Label
    Friend WithEvents vcostura As System.Windows.Forms.Label
    Friend WithEvents vcorte As System.Windows.Forms.Label
    Friend WithEvents cliente As System.Windows.Forms.Label
    Friend WithEvents estilo As System.Windows.Forms.Label
    Friend WithEvents descripcion As System.Windows.Forms.Label
    Friend WithEvents programa As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Dim empre As New empresas
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estilos_Consulta))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.empaque = New System.Windows.Forms.CheckBox()
        Me.lavado = New System.Windows.Forms.CheckBox()
        Me.tenido = New System.Windows.Forms.CheckBox()
        Me.costura = New System.Windows.Forms.CheckBox()
        Me.serigra = New System.Windows.Forms.CheckBox()
        Me.bordado = New System.Windows.Forms.CheckBox()
        Me.corte = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cliente = New System.Windows.Forms.Label()
        Me.estilo = New System.Windows.Forms.Label()
        Me.descripcion = New System.Windows.Forms.Label()
        Me.programa = New System.Windows.Forms.Label()
        Me.vcostura = New System.Windows.Forms.Label()
        Me.vcorte = New System.Windows.Forms.Label()
        Me.vhilo = New System.Windows.Forms.Label()
        Me.votros = New System.Windows.Forms.Label()
        Me.vempaque = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 371)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 444)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Programa:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.SteelBlue
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(16, 396)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 24)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Estilo:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.BackColor = System.Drawing.SystemColors.Info
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(16, 3)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 17
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(848, 365)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(8, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(143, 24)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Bordado:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.SteelBlue
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(8, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 24)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Teñido:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.SteelBlue
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(8, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 24)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Empaque:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.SteelBlue
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(8, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(143, 24)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Costura:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 24)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Lavado:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 420)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Descripcion:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.SteelBlue
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(587, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(143, 24)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Corte:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SteelBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(296, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Operaciones"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(8, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 24)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Corte:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.SteelBlue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(8, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 24)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Serigrafía:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label8, "Necesita Serigrafía?")
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.SteelBlue
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(587, 112)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(143, 24)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Empaque:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.SteelBlue
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(587, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(143, 24)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Hilo:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.votros)
        Me.GroupBox1.Controls.Add(Me.vempaque)
        Me.GroupBox1.Controls.Add(Me.vhilo)
        Me.GroupBox1.Controls.Add(Me.vcostura)
        Me.GroupBox1.Controls.Add(Me.vcorte)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.empaque)
        Me.GroupBox1.Controls.Add(Me.lavado)
        Me.GroupBox1.Controls.Add(Me.tenido)
        Me.GroupBox1.Controls.Add(Me.costura)
        Me.GroupBox1.Controls.Add(Me.serigra)
        Me.GroupBox1.Controls.Add(Me.bordado)
        Me.GroupBox1.Controls.Add(Me.corte)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 470)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1024, 216)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(588, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(296, 24)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Precio Manufactura"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'empaque
        '
        Me.empaque.AutoSize = True
        Me.empaque.Enabled = False
        Me.empaque.Location = New System.Drawing.Point(238, 189)
        Me.empaque.Name = "empaque"
        Me.empaque.Size = New System.Drawing.Size(15, 14)
        Me.empaque.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.empaque, "Es necesario empacar las prendas?")
        Me.empaque.UseVisualStyleBackColor = True
        '
        'lavado
        '
        Me.lavado.AutoSize = True
        Me.lavado.Enabled = False
        Me.lavado.Location = New System.Drawing.Point(238, 165)
        Me.lavado.Name = "lavado"
        Me.lavado.Size = New System.Drawing.Size(15, 14)
        Me.lavado.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.lavado, "Se lavan antes de empacar?")
        Me.lavado.UseVisualStyleBackColor = True
        '
        'tenido
        '
        Me.tenido.AutoSize = True
        Me.tenido.Enabled = False
        Me.tenido.Location = New System.Drawing.Point(238, 141)
        Me.tenido.Name = "tenido"
        Me.tenido.Size = New System.Drawing.Size(15, 14)
        Me.tenido.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.tenido, "Es necesario Teñido?")
        Me.tenido.UseVisualStyleBackColor = True
        '
        'costura
        '
        Me.costura.AutoSize = True
        Me.costura.Enabled = False
        Me.costura.Location = New System.Drawing.Point(238, 117)
        Me.costura.Name = "costura"
        Me.costura.Size = New System.Drawing.Size(15, 14)
        Me.costura.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.costura, "Se efectúa la Operación de Costura?")
        Me.costura.UseVisualStyleBackColor = True
        '
        'serigra
        '
        Me.serigra.AutoSize = True
        Me.serigra.Enabled = False
        Me.serigra.Location = New System.Drawing.Point(238, 93)
        Me.serigra.Name = "serigra"
        Me.serigra.Size = New System.Drawing.Size(15, 14)
        Me.serigra.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.serigra, "Necesita Serigrafía?")
        Me.serigra.UseVisualStyleBackColor = True
        '
        'bordado
        '
        Me.bordado.AutoSize = True
        Me.bordado.Enabled = False
        Me.bordado.Location = New System.Drawing.Point(238, 69)
        Me.bordado.Name = "bordado"
        Me.bordado.Size = New System.Drawing.Size(15, 14)
        Me.bordado.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.bordado, "Se Bordan las prendas?")
        Me.bordado.UseVisualStyleBackColor = True
        '
        'corte
        '
        Me.corte.AutoSize = True
        Me.corte.Enabled = False
        Me.corte.Location = New System.Drawing.Point(238, 45)
        Me.corte.Name = "corte"
        Me.corte.Size = New System.Drawing.Size(15, 14)
        Me.corte.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.corte, "Se cortan las Prendas del Estilo?")
        Me.corte.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.SteelBlue
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(587, 64)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(143, 24)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "Costura:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.SteelBlue
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(587, 136)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(143, 24)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "Otros:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cliente
        '
        Me.cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cliente.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.Location = New System.Drawing.Point(136, 374)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(278, 22)
        Me.cliente.TabIndex = 44
        Me.cliente.Text = " "
        Me.cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'estilo
        '
        Me.estilo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.estilo.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estilo.Location = New System.Drawing.Point(136, 398)
        Me.estilo.Name = "estilo"
        Me.estilo.Size = New System.Drawing.Size(278, 22)
        Me.estilo.TabIndex = 45
        Me.estilo.Text = " "
        Me.estilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'descripcion
        '
        Me.descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.descripcion.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descripcion.Location = New System.Drawing.Point(136, 422)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(613, 22)
        Me.descripcion.TabIndex = 46
        Me.descripcion.Text = " "
        Me.descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'programa
        '
        Me.programa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.programa.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.programa.Location = New System.Drawing.Point(136, 446)
        Me.programa.Name = "programa"
        Me.programa.Size = New System.Drawing.Size(613, 22)
        Me.programa.TabIndex = 47
        Me.programa.Text = " "
        Me.programa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'vcostura
        '
        Me.vcostura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vcostura.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vcostura.Location = New System.Drawing.Point(776, 64)
        Me.vcostura.Name = "vcostura"
        Me.vcostura.Size = New System.Drawing.Size(108, 22)
        Me.vcostura.TabIndex = 48
        Me.vcostura.Text = " "
        Me.vcostura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'vcorte
        '
        Me.vcorte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vcorte.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vcorte.Location = New System.Drawing.Point(776, 40)
        Me.vcorte.Name = "vcorte"
        Me.vcorte.Size = New System.Drawing.Size(108, 22)
        Me.vcorte.TabIndex = 49
        Me.vcorte.Text = " "
        Me.vcorte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'vhilo
        '
        Me.vhilo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vhilo.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhilo.Location = New System.Drawing.Point(776, 89)
        Me.vhilo.Name = "vhilo"
        Me.vhilo.Size = New System.Drawing.Size(108, 22)
        Me.vhilo.TabIndex = 49
        Me.vhilo.Text = " "
        Me.vhilo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'votros
        '
        Me.votros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.votros.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.votros.Location = New System.Drawing.Point(776, 137)
        Me.votros.Name = "votros"
        Me.votros.Size = New System.Drawing.Size(108, 22)
        Me.votros.TabIndex = 49
        Me.votros.Text = " "
        Me.votros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'vempaque
        '
        Me.vempaque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vempaque.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vempaque.Location = New System.Drawing.Point(776, 113)
        Me.vempaque.Name = "vempaque"
        Me.vempaque.Size = New System.Drawing.Size(108, 22)
        Me.vempaque.TabIndex = 50
        Me.vempaque.Text = " "
        Me.vempaque.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(908, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 69)
        Me.Button4.TabIndex = 58
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button4, "Despliega Specs del Estilo")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Estilos_Consulta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1042, 696)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.programa)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.estilo)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Estilos_Consulta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Estilos"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Estilos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setea_grid()
        llena_grid()
        Try
            seleccion(1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        llena_grid()
    End Sub

    Private Sub llena_grid()
        Dim dt As New DataTable
        Dim dr As DataRow
        ok = False
        Dim strSQL As String = "SELECT * FROM ESTILOS ORDER BY CLIENTE,ESTILO"
        llena_tablas(dt, strSQL, cnn)
        lineas = dt.Rows.Count
        fg.Rows.Count = lineas + 1
        lineas = 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("CLIENTE")
            fg(lineas, 2) = dr("ESTILO")
            lineas = lineas + 1
        Next
    End Sub
    Private Sub busca_estilo()
        Dim dt As New DataTable()
        Dim dr As DataRow

        Dim strSQL As String = "SELECT * FROM ESTILOS WHERE CLIENTE = '" & cliente.Text & "' AND ESTILO = '" & estilo.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            EXISTE = True
            nuevo = False
            llena_Variables(dr)
        Next
    End Sub

    Private Sub llena_Variables(ByVal dr As DataRow)
        descripcion.Text = dr("DESCRIPCION")
        programa.Text = dr("PROGRAMA")
        corte.Checked = dr("O1")
        bordado.Checked = dr("O2")
        serigra.Checked = dr("O3")
        costura.Checked = dr("O4")
        tenido.Checked = dr("O5")
        lavado.Checked = dr("O6")
        empaque.Checked = dr("O7")
        Try
            vcorte.Text = dr("CORTE")
            vcostura.Text = dr("COSTURA")
            vempaque.Text = dr("EMPAQUE")
            votros.Text = dr("OTROS")
            vhilo.Text = dr("HILO")
        Catch
        End Try

    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        fila = fg.RowSel
        seleccion(fila)
    End Sub

    Private Sub seleccion(ByVal fil As Integer)
        If fil > 0 And fil < fg.Rows.Count Then
            cliente.Text = fg(fil, 1)
            estilo.Text = fg(fil, 2)
            busca_estilo()
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

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Try
            despliega_spec(fg(fg.RowSel, 1), fg(fg.RowSel, 2))
        Catch
        End Try
        fg.Focus()
    End Sub
End Class
