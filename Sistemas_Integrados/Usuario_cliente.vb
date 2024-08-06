Imports C1.Win.C1FlexGrid

Public Class Usuario_cliente
    Inherits System.Windows.Forms.Form
    Dim h As String = "#######0.00"
    Dim ok As Boolean
    Dim EXISTE As Boolean
    Dim fila As Integer
    Dim codigo As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim cnn1 As New SqlClient.SqlConnection
    Dim lineas As Integer
    Dim dr As DataRow
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mbom As System.Windows.Forms.CheckBox
    Friend WithEvents abom As System.Windows.Forms.CheckBox
    Friend WithEvents rbom As System.Windows.Forms.CheckBox
    Friend WithEvents cbom As System.Windows.Forms.CheckBox
    Friend WithEvents est_col As System.Windows.Forms.CheckBox
    Friend WithEvents colo As System.Windows.Forms.CheckBox
    Friend WithEvents estilo As System.Windows.Forms.CheckBox
    Dim nuevo As Boolean
    Dim usuario As String
    Dim empre As New empresas
    Friend WithEvents correo As System.Windows.Forms.TextBox
    Friend WithEvents cliente As System.Windows.Forms.ComboBox
    Friend WithEvents user As System.Windows.Forms.ComboBox
    Dim obj As New empresas
    Friend WithEvents seg As System.Windows.Forms.CheckBox
    Friend WithEvents Elimina As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Dim cs As New Lib_SI.util
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
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents graba As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents nombre As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuario_cliente))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.graba = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.seg = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.correo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mbom = New System.Windows.Forms.CheckBox()
        Me.abom = New System.Windows.Forms.CheckBox()
        Me.rbom = New System.Windows.Forms.CheckBox()
        Me.cbom = New System.Windows.Forms.CheckBox()
        Me.est_col = New System.Windows.Forms.CheckBox()
        Me.colo = New System.Windows.Forms.CheckBox()
        Me.estilo = New System.Windows.Forms.CheckBox()
        Me.nombre = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cliente = New System.Windows.Forms.ComboBox()
        Me.user = New System.Windows.Forms.ComboBox()
        Me.Elimina = New System.Windows.Forms.Button()
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
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.SteelBlue
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(16, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 24)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Cliente:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(8, 326)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1016, 346)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(861, 8)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(60, 40)
        Me.graba.TabIndex = 18
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.graba, "Actualiza Registro.")
        Me.graba.UseVisualStyleBackColor = False
        Me.graba.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(926, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 40)
        Me.Button3.TabIndex = 19
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Limpia variables")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(8, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(186, 24)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Crea Colores:"
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
        Me.Label9.Size = New System.Drawing.Size(186, 24)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Revisa BOM:"
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
        Me.Label10.Size = New System.Drawing.Size(186, 24)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Modifica BOM:"
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
        Me.Label11.Size = New System.Drawing.Size(186, 24)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Crea BOM:"
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
        Me.Label2.Size = New System.Drawing.Size(186, 24)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Aprueba BOM:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.SteelBlue
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(533, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(143, 24)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Correo:"
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
        Me.Label6.Size = New System.Drawing.Size(350, 24)
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
        Me.Label7.Size = New System.Drawing.Size(186, 24)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Crea Estilo:"
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
        Me.Label8.Size = New System.Drawing.Size(186, 24)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Crea Estilo-Color:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label8, "Necesita Serigrafía?")
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.seg)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.correo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.mbom)
        Me.GroupBox1.Controls.Add(Me.abom)
        Me.GroupBox1.Controls.Add(Me.rbom)
        Me.GroupBox1.Controls.Add(Me.cbom)
        Me.GroupBox1.Controls.Add(Me.est_col)
        Me.GroupBox1.Controls.Add(Me.colo)
        Me.GroupBox1.Controls.Add(Me.estilo)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1024, 246)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'seg
        '
        Me.seg.AutoSize = True
        Me.seg.Location = New System.Drawing.Point(282, 216)
        Me.seg.Name = "seg"
        Me.seg.Size = New System.Drawing.Size(15, 14)
        Me.seg.TabIndex = 65
        Me.ToolTip1.SetToolTip(Me.seg, " ")
        Me.seg.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 24)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Seguimiento:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'correo
        '
        Me.correo.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.correo.Location = New System.Drawing.Point(682, 42)
        Me.correo.MaxLength = 30
        Me.correo.Name = "correo"
        Me.correo.Size = New System.Drawing.Size(329, 22)
        Me.correo.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.correo, " ")
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(534, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(477, 24)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Seguimiento"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mbom
        '
        Me.mbom.AutoSize = True
        Me.mbom.Location = New System.Drawing.Point(282, 191)
        Me.mbom.Name = "mbom"
        Me.mbom.Size = New System.Drawing.Size(15, 14)
        Me.mbom.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.mbom, " ")
        Me.mbom.UseVisualStyleBackColor = True
        '
        'abom
        '
        Me.abom.AutoSize = True
        Me.abom.Location = New System.Drawing.Point(282, 167)
        Me.abom.Name = "abom"
        Me.abom.Size = New System.Drawing.Size(15, 14)
        Me.abom.TabIndex = 9
        Me.abom.UseVisualStyleBackColor = True
        '
        'rbom
        '
        Me.rbom.AutoSize = True
        Me.rbom.Location = New System.Drawing.Point(282, 143)
        Me.rbom.Name = "rbom"
        Me.rbom.Size = New System.Drawing.Size(15, 14)
        Me.rbom.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.rbom, " ")
        Me.rbom.UseVisualStyleBackColor = True
        '
        'cbom
        '
        Me.cbom.AutoSize = True
        Me.cbom.Location = New System.Drawing.Point(282, 119)
        Me.cbom.Name = "cbom"
        Me.cbom.Size = New System.Drawing.Size(15, 14)
        Me.cbom.TabIndex = 7
        Me.cbom.UseVisualStyleBackColor = True
        '
        'est_col
        '
        Me.est_col.AutoSize = True
        Me.est_col.Location = New System.Drawing.Point(282, 95)
        Me.est_col.Name = "est_col"
        Me.est_col.Size = New System.Drawing.Size(15, 14)
        Me.est_col.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.est_col, " ")
        Me.est_col.UseVisualStyleBackColor = True
        '
        'colo
        '
        Me.colo.AutoSize = True
        Me.colo.Location = New System.Drawing.Point(282, 71)
        Me.colo.Name = "colo"
        Me.colo.Size = New System.Drawing.Size(15, 14)
        Me.colo.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.colo, " ")
        Me.colo.UseVisualStyleBackColor = True
        '
        'estilo
        '
        Me.estilo.AutoSize = True
        Me.estilo.Location = New System.Drawing.Point(282, 47)
        Me.estilo.Name = "estilo"
        Me.estilo.Size = New System.Drawing.Size(15, 14)
        Me.estilo.TabIndex = 4
        Me.estilo.UseVisualStyleBackColor = True
        '
        'nombre
        '
        Me.nombre.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.IntegralHeight = False
        Me.nombre.Location = New System.Drawing.Point(136, 8)
        Me.nombre.MaxLength = 10
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(613, 24)
        Me.nombre.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.nombre, "Usuario")
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(8, 672)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(536, 16)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Para Seleccionar una Fila en especial  Presione Click."
        '
        'cliente
        '
        Me.cliente.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.IntegralHeight = False
        Me.cliente.Location = New System.Drawing.Point(134, 40)
        Me.cliente.MaxLength = 10
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(615, 24)
        Me.cliente.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cliente, "Cliente.")
        '
        'user
        '
        Me.user.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.IntegralHeight = False
        Me.user.Location = New System.Drawing.Point(134, 70)
        Me.user.MaxLength = 10
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(613, 24)
        Me.user.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.user, "Cliente.")
        Me.user.Visible = False
        '
        'Elimina
        '
        Me.Elimina.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Elimina.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Elimina.ForeColor = System.Drawing.Color.Black
        Me.Elimina.Image = CType(resources.GetObject("Elimina.Image"), System.Drawing.Image)
        Me.Elimina.Location = New System.Drawing.Point(796, 8)
        Me.Elimina.Name = "Elimina"
        Me.Elimina.Size = New System.Drawing.Size(60, 40)
        Me.Elimina.TabIndex = 97
        Me.Elimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Elimina, "Elimina Registro")
        Me.Elimina.UseVisualStyleBackColor = False
        Me.Elimina.Visible = False
        '
        'Usuario_cliente
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1042, 696)
        Me.Controls.Add(Me.Elimina)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.graba)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Usuario_cliente"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Permisos Usuario - Cliente"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Estilos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler nombre.KeyPress, AddressOf keypressed1
        AddHandler cliente.KeyPress, AddressOf keypressed2
        AddHandler estilo.KeyPress, AddressOf keypressed3
        AddHandler colo.KeyPress, AddressOf keypressed4
        AddHandler est_col.KeyPress, AddressOf keypressed5
        AddHandler cbom.KeyPress, AddressOf keypressed6
        AddHandler rbom.KeyPress, AddressOf keypressed7
        AddHandler abom.KeyPress, AddressOf keypressed8
        AddHandler abom.KeyPress, AddressOf keypressed9
        AddHandler mbom.KeyPress, AddressOf keypressed9
        AddHandler correo.KeyPress, AddressOf keypressed9A
        cnn1.ConnectionString = cs.con_string("0")
        usuario = empre.clave
        llena_usuarios()
        llena_combos(cliente, "SELECT CLIENTE FROM CLIENTES WHERE ACTIVO = 'S'", "CLIENTE")
        Try
            nombre.SelectedIndex = 0
        Catch ex As Exception
        End Try
        habilita(False)
    End Sub
    Private Sub llena_usuarios()
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim strsql As String = "SELECT * FROM MEN_JAP ORDER BY USUARIO"
        nombre.Items.Clear()
        user.Items.Clear()
        llena_tablas_e(dt, strsql, cnn1)
        For Each dr In dt.Rows
            nombre.Items.Add(dr("USUARIO"))
            user.Items.Add(dr("PASSWORD"))
        Next
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
        Dim strSQL As String = "SELECT * FROM USUARIO_CLIENTE WHERE USUARIO = '" & user.Text & "'"
        user.SelectedIndex = nombre.SelectedIndex
        llena_tablas(dt, strSQL, cnn)
        lineas = dt.Rows.Count
        fg.Rows.Count = lineas + 1
        lineas = 1
        For Each dr In dt.Rows
            fg(lineas, 1) = dr("CLIENTE")
            crea_bol(dr("ESTILO"), fg(lineas, 2))
            crea_bol(dr("COLOR"), fg(lineas, 3))
            crea_bol(dr("CREA_EST_COL"), fg(lineas, 4))
            crea_bol(dr("CREACION_BOM"), fg(lineas, 5))
            crea_bol(dr("REVISION_BOM"), fg(lineas, 6))
            crea_bol(dr("APROBAR_BOM"), fg(lineas, 7))
            crea_bol(dr("MODIFICACION_BOM"), fg(lineas, 8))
            crea_bol(dr("SEGUIMIENTO_BOM"), fg(lineas, 9))
            fg(lineas, 10) = dr("CORREO")
            lineas = lineas + 1
        Next
    End Sub
    Private Sub set_variables()
        nombre.Enabled = True
        cliente.Enabled = True
        correo.Text = ""
        estilo.Checked = False
        colo.Checked = False
        est_col.Checked = False
        cbom.Checked = False
        rbom.Checked = False
        abom.Checked = False
        mbom.Checked = False
        seg.Checked = False
        habilita(False)
        graba.Visible = False
        Elimina.Visible = False
        setea_grid()
        llena_grid()
    End Sub

    Private Sub crea_bol(ByRef var As String, ByRef var_bol As Boolean)
        If var = "S" Then
            var_bol = True
        Else
            var_bol = False
        End If
    End Sub

    Private Sub crea_sn(ByRef var_sn As String, ByRef var As Boolean)
        If var Then
            var_sn = "S"
        Else
            var_sn = "N"
        End If
    End Sub
    Private Sub habilita(ByRef ok As Boolean)
        estilo.Enabled = ok
        colo.Enabled = ok
        est_col.Enabled = ok
        cbom.Enabled = ok
        rbom.Enabled = ok
        abom.Enabled = ok
        mbom.Enabled = ok
        seg.Enabled = ok
        correo.Enabled = ok
    End Sub
    '================================== HANDLERS ================================
    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            Dim dt As New DataTable()
            If Trim(nombre.Text) <> "" Then
                cliente.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed2(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(cliente.Text) <> "" Then
                busca_datos()
            End If
        End If
    End Sub
    Private Sub keypressed3(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(colo.Text) <> "" Then
                cbom.Focus()
            End If
        End If
    End Sub 'keypressed

    Private Sub keypressed4(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            rbom.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed5(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            abom.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed6(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            abom.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed7(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            cbom.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed8(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            rbom.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed9(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            abom.Focus()
        End If
    End Sub 'keypressed
    Private Sub keypressed9A(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            mbom.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed10(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            seg.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed11(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            correo.Focus()
        End If
    End Sub 'keypressed

    Private Sub keypressed15(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            graba.Focus()
        End If
    End Sub 'keypressed
    Private Sub mensaje(ByVal var As String)
        MsgBox("Por favor revise " + var, MsgBoxStyle.OkOnly, var)
    End Sub

    Private Sub busca_datos()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim strSQL As String = "SELECT * FROM USUARIO_CLIENTE WHERE USUARIO = '" & user.Text & "' AND CLIENTE = '" & cliente.Text & "'"
        llena_tablas(dt, strSQL, cnn)
        For Each dr In dt.Rows
            llena_Variables(dr)
            Elimina.Visible = True
        Next
        nombre.Enabled = False
        cliente.Enabled = False
        graba.Visible = True
        habilita(True)
        correo.Focus()
    End Sub

    Private Sub llena_Variables(ByVal dr As DataRow)
        correo.Text = dr("CORREO")
        crea_bol(dr("ESTILO"), estilo.Checked)
        crea_bol(dr("COLOR"), colo.Checked)
        crea_bol(dr("CREA_EST_COL"), est_col.Checked)
        crea_bol(dr("CREACION_BOM"), cbom.Checked)
        crea_bol(dr("REVISION_BOM"), rbom.Checked)
        crea_bol(dr("APROBAR_BOM"), abom.Checked)
        crea_bol(dr("MODIFICACION_BOM"), mbom.Checked)
        crea_bol(dr("SEGUIMIENTO_BOM"), seg.Checked)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graba.Click
        Dim ok As Boolean = False
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Actualizar los Datos?  ", MsgBoxStyle.YesNo, "Actualiza Datos !!!")
        If seguro = MsgBoxResult.Yes Then
            revisa_datos(ok)
            If ok Then
                graba_registros()
                setea_grid()
                set_variables()
            End If
        End If
    End Sub

    Private Sub revisa_datos(ByRef ok As Boolean)
        Dim valor As Decimal = 0
        If Trim(correo.Text) = "" Then
            mensaje("Debe de ingresar la direccion de Correo Electrónico.")
            Exit Sub
        End If
        ok = True
    End Sub
    Private Sub graba_registros()
        Dim afectados As Integer
        Dim strSQL As String
        Dim V(9) As String
        user.SelectedIndex = nombre.SelectedIndex
        crea_sn(V(1), estilo.Checked)
        crea_sn(V(2), colo.Checked)
        crea_sn(V(3), est_col.Checked)
        crea_sn(V(4), cbom.Checked)
        crea_sn(V(5), rbom.Checked)
        crea_sn(V(6), abom.Checked)
        crea_sn(V(7), mbom.Checked)
        crea_sn(V(8), seg.Checked)
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion


        '    ESTILO	COLOR	CREA_EST_COL	CREACION_BOM	REVISION_BOM	APROBAR_BOM	MODIFICACION_BOM	SEGUIMIENTO_BOM	CORREO
        Try
            ' =================== ACTUALIZA ESTILOS
            strSQL = "UPDATE USUARIO_CLIENTE SET ESTILO  = '" & V(1) & "' ,COLOR  = '" & V(2) & "',CREA_EST_COL = '" & V(3) & "',CREACION_BOM = '" & V(4) & "',REVISION_BOM  = '" & V(5) & "', APROBAR_BOM = '" & V(6) & "', MODIFICACION_BOM  = '" & V(7) & "', SEGUIMIENTO_BOM  = '" & V(8) & "' ,CORREO = '" & correo.Text & "'" & _
                                                        " WHERE USUARIO = '" & user.Text & "' AND CLIENTE = '" & cliente.Text & "'"
            comando.CommandText = strSQL
            afectados = comando.ExecuteNonQuery()

            If afectados = 0 Then
                strSQL = "INSERT INTO USUARIO_CLIENTE (USUARIO,CLIENTE,ESTILO,COLOR,CREA_EST_COL,CREACION_BOM,REVISION_BOM,APROBAR_BOM,MODIFICACION_BOM,SEGUIMIENTO_BOM,CORREO)" & _
                                                  " VALUES ( '" & user.Text & "','" & _
                                                                 cliente.Text & "','" & _
                                                                 V(1) & "','" & _
                                                                 V(2) & "','" & _
                                                                 V(3) & "','" & _
                                                                 V(4) & "','" & _
                                                                 V(5) & "','" & _
                                                                 V(6) & "','" & _
                                                                 V(7) & "','" & _
                                                                 V(8) & "','" & _
                                                                 correo.Text & "')"

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

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        cliente.Enabled = False
        fila = fg.RowSel
        seleccion(fila)
    End Sub

    Private Sub seleccion(ByVal fil As Integer)
        If fil > 0 And fil < fg.Rows.Count Then
            cliente.SelectedIndex = cliente.Items.IndexOf(fg(fil, 1))
            busca_datos()
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

    Private Sub llena_lineas(ByVal lineas As Integer)
        fg(lineas, 1) = nombre.Text
        fg(lineas, 2) = estilo.Checked
        fg(lineas, 3) = colo.Checked
        fg(lineas, 4) = est_col.Checked
        fg(lineas, 5) = cbom.Checked
        fg(lineas, 6) = rbom.Checked
        fg(lineas, 7) = abom.Checked
        fg(lineas, 8) = mbom.Checked
    End Sub

    Private Sub c4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nombre.KeyPress
        AutoCompletar(nombre, e)
    End Sub
    Private Sub CLIENTE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cliente.KeyPress
        AutoCompletar(cliente, e)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        llena_grid()
        estilo.Enabled = True
    End Sub

    Private Sub cliente_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles nombre.SelectedIndexChanged
        setea_grid()
        llena_grid()
        set_variables()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        set_variables()
        habilita(False)
        cliente.Enabled = True
        cliente.Focus()
    End Sub

    Private Sub cliente_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cliente.SelectedIndexChanged
        setea_grid()
        llena_grid()
    End Sub

    Private Sub Elimina_Click(sender As System.Object, e As System.EventArgs) Handles Elimina.Click
        Dim ok As Boolean = False
        Dim seguro As MsgBoxResult
        seguro = MsgBox("Seguro de Eliminar los Datos?  ", MsgBoxStyle.YesNo, "Actualiza Datos !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_registros()
            set_variables()
            End If
    End Sub


    Private Sub elimina_registros()
        Dim afectados As Integer
        Dim strSQL As String
        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            ' =================== ACTUALIZA ESTILOS
            strSQL = "DELETE USUARIO_CLIENTE WHERE USUARIO = '" & user.Text & "' AND CLIENTE = '" & cliente.Text & "'"
            comando.CommandText = strSQL
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
End Class
